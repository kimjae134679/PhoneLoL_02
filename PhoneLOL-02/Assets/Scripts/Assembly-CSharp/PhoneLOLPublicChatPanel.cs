using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using UnityEngine;

// Persistent account chat, displayed in pages of fifty messages.
public sealed class PhoneLOLPublicChatPanel : MonoBehaviour
{
    private sealed class Message {
        public uint id;
        public long time;
        public string nickname, text;
    }
    private UILabel display;
    private UIInput input;
    private Transform sendButton;
    private Vector3 inputHome, buttonHome;
    private int posting;
    private readonly object gate = new object();
    private List<Message> pending, page = new List<Message>();
    private string pendingError, failedDraft;
    private bool historical;
    private int busy;
    private float nextPoll;
    private volatile bool refreshAfterPost;

    public void Initialize(UILabel chat, UIInput field)
    {
        display = chat;
        input = field;
        display.set_supportEncoding(false);
        input.onSubmit.Clear();
        input.onSubmit.Add(new EventDelegate(Post));
        input.onReturnKey = UIInput.NBNDGIACPBN.Submit;
        input.label.set_multiLine(false);
        input.characterLimit = 200;
        // Reserve space for a visible, touchable send button in the original composer.
        var background = input.GetComponent<UISprite>();
        if (background == null) throw new InvalidOperationException("Chat input has no background sprite");
        input.label.set_width(296);
        background.set_width(308);
        var hit = input.GetComponent<BoxCollider>();
        if (hit != null) hit.size = new Vector3(308f, hit.size.y, hit.size.z);
        input.transform.localPosition += new Vector3(-38f, 0f, 0f);
        var button = new GameObject("PublicChatSend");
        button.layer = input.gameObject.layer;
        button.transform.SetParent(input.transform.parent, false);
        button.transform.localPosition = input.transform.localPosition + new Vector3(189f, 0f, 0f);
        var surface = button.AddComponent<UISprite>();
        surface.set_atlas(background.get_atlas());
        surface.set_spriteName(background.get_spriteName());
        surface.set_width(74); surface.set_height(40);
        surface.set_depth(background.get_depth());
        var title = UnityEngine.Object.Instantiate(input.label.gameObject, button.transform, false).GetComponent<UILabel>();
        title.name = "SendLabel"; title.transform.localPosition = Vector3.zero;
        title.set_text("보내기"); title.set_width(74); title.set_height(32);
        title.set_depth(background.get_depth() + 1);
        button.AddComponent<BoxCollider>().size = new Vector3(74f, 48f, 1f);
        UIEventListener.Get(button).onClick = _ => Post();
        sendButton = button.transform;
        inputHome = input.transform.localPosition;
        buttonHome = sendButton.localPosition;
        AddHistoryButton("EarlierMessages", "이전 대화", -92f, LoadOlder);
        AddHistoryButton("LatestMessages", "최신 대화", 92f, LoadLatest);
    }
    private void AddHistoryButton(string name, string title, float x, Action click)
    {
        var button = new GameObject(name);
        button.layer = display.gameObject.layer;
        button.transform.SetParent(transform, false);
        button.transform.localPosition = new Vector3(x, 155f, 0f);
        var label = button.AddComponent<UILabel>();
        label.set_bitmapFont(display.get_bitmapFont());
        label.set_fontSize(14);
        label.set_text(title);
        label.set_width(120);
        label.set_height(32);
        button.AddComponent<BoxCollider>().size = new Vector3(120f, 32f, 1f);
        UIEventListener.Get(button).onClick = _ => click();
    }
    private void OnEnable()
    {
        if (display != null) {
            if (PhoneLOLOfflineSession.Enabled) display.set_text("로컬 모드에서는 전체 채팅을 사용할 수 없어요.");
            else LoadLatest();
        }
    }
    private void OnDisable()
    {
        if (input != null) input.transform.localPosition = inputHome;
        if (sendButton != null) sendButton.localPosition = buttonHome;
    }
    private void KeepComposerAboveKeyboard()
    {
        if (input == null || sendButton == null) return;
        var cameraUI = UICamera.FindCameraForLayer(input.gameObject.layer);
        var camera = cameraUI == null ? null : cameraUI.get_cachedCamera();
        if (camera == null || !TouchScreenKeyboard.visible) {
            input.transform.localPosition = inputHome;
            sendButton.localPosition = buttonHome;
            return;
        }
        var screen = camera.WorldToScreenPoint(input.transform.parent.TransformPoint(inputHome));
        float keyboardHeight = TouchScreenKeyboard.area.height;
        if (keyboardHeight < 1f) keyboardHeight = Screen.height * 0.53f;
        float clearY = Mathf.Min(Screen.height - 64f, keyboardHeight + 54f);
        var world = camera.ScreenToWorldPoint(new Vector3(screen.x, Mathf.Max(clearY, screen.y), screen.z));
        var local = input.transform.parent.InverseTransformPoint(world);
        float rise = Mathf.Max(0f, local.y - inputHome.y);
        input.transform.localPosition = inputHome + new Vector3(0f, rise, 0f);
        sendButton.localPosition = buttonHome + new Vector3(0f, rise, 0f);
    }
    private void Update()
    {
        KeepComposerAboveKeyboard();
        List<Message> messages;
        string error;
        lock (gate) {
            messages = pending; error = pendingError;
            if (failedDraft != null && input.get_value().Length == 0) input.set_value(failedDraft);
            failedDraft = null;
            pending = null; pendingError = null;
        }
        if (messages != null) {
            page = messages;
            Render();
            Interlocked.Exchange(ref busy, 0);
        } else if (error != null) {
            display.set_text(error);
            Interlocked.Exchange(ref busy, 0);
        }
        if (refreshAfterPost) {
            refreshAfterPost = false;
            nextPoll = 0f;
            historical = false;
        }
        if (!PhoneLOLOfflineSession.Enabled && !historical && Time.unscaledTime >= nextPoll && Volatile.Read(ref busy) == 0) {
            nextPoll = Time.unscaledTime + 5f;
            Fetch(0);
        }
    }
    private void Render()
    {
        if (page.Count == 0) {
            display.set_text(historical ? "이전 대화가 없습니다." : "아직 대화가 없습니다.");
            return;
        }
        var result = new StringBuilder();
        foreach (var item in page) {
            var when = new DateTime(1970, 1, 1).AddSeconds(item.time).ToLocalTime();
            result.Append(when.ToString("MM/dd HH:mm")).Append("  ").Append(item.nickname)
                .Append(": ").Append(item.text).Append('\n');
        }
        display.set_text(result.ToString());
    }
    private void Fetch(uint before)
    {
        if (Interlocked.CompareExchange(ref busy, 1, 0) != 0) return;
        var request = new byte[8];
        Buffer.BlockCopy(BitConverter.GetBytes(before), 0, request, 0, 4);
        ThreadPool.QueueUserWorkItem(_ => {
            try {
                var reply = PhoneLOLLocalHost.PublicBoardRequest(1, request);
                using (var reader = new BinaryReader(new MemoryStream(reply))) {
                    if (reader.ReadByte() != 0) throw new InvalidDataException("Chat request rejected.");
                    int count = reader.ReadUInt16();
                    if (count > 50) throw new InvalidDataException("Chat page too large.");
                    var messages = new List<Message>(count);
                    for (int i = 0; i < count; i++)
                        messages.Add(new Message {
                            id = reader.ReadUInt32(), time = reader.ReadInt64(),
                            nickname = PhoneLOLTransport.ReadText(reader),
                            text = PhoneLOLTransport.ReadText(reader)
                        });
                    if (reader.BaseStream.Position != reader.BaseStream.Length)
                        throw new InvalidDataException("Chat data malformed.");
                    lock (gate) pending = messages;
                }
            } catch (Exception error) {
                lock (gate) pendingError = "채팅을 불러오지 못했어요. " + error.GetType().Name;
            }
        });
    }
    private void LoadLatest()
    {
        historical = false;
        nextPoll = Time.unscaledTime + 5f;
        Fetch(0);
    }
    private void LoadOlder()
    {
        if (page.Count == 0) return;
        historical = true;
        Fetch(page[0].id);
    }
    public void Post()
    {
        if (PhoneLOLOfflineSession.Enabled) return;
        string message = input.get_value().Trim();
        if (message.Length == 0) return;
        if (message.Length > 200) {
            display.set_text("채팅은 200자 이내로 입력해 주세요.");
            return;
        }
        if (Interlocked.CompareExchange(ref posting, 1, 0) != 0) return;
        input.set_value(string.Empty);
        ThreadPool.QueueUserWorkItem(_ => {
            try {
                byte[] body = Encoding.UTF8.GetBytes(message);
                byte[] request = new byte[2 + body.Length];
                Buffer.BlockCopy(BitConverter.GetBytes((ushort)body.Length), 0, request, 0, 2);
                Buffer.BlockCopy(body, 0, request, 2, body.Length);
                byte[] reply = PhoneLOLLocalHost.PublicBoardRequest(2, request);
                if (reply[0] != 0) {
                    lock (gate) { pendingError = "잠시 기다렸다가 다시 보내 주세요."; failedDraft = message; }
                    return;
                }
                refreshAfterPost = true;
            } catch (Exception error) {
                lock (gate) { pendingError = "채팅을 보내지 못했어요. " + error.GetType().Name; failedDraft = message; }
            } finally { Interlocked.Exchange(ref posting, 0); }
        });
    }
}
