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
    private readonly object gate = new object();
    private List<Message> pending, page = new List<Message>();
    private string pendingError;
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
        if (display != null) LoadLatest();
    }
    private void Update()
    {
        List<Message> messages;
        string error;
        lock (gate) {
            messages = pending; error = pendingError;
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
        if (!historical && Time.unscaledTime >= nextPoll && Volatile.Read(ref busy) == 0) {
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
        string message = input.get_value().Trim();
        if (message.Length == 0) return;
        if (message.Length > 200) {
            display.set_text("채팅은 200자 이내로 입력해 주세요.");
            return;
        }
        input.set_value(string.Empty);
        ThreadPool.QueueUserWorkItem(_ => {
            try {
                byte[] body = Encoding.UTF8.GetBytes(message);
                byte[] request = new byte[2 + body.Length];
                Buffer.BlockCopy(BitConverter.GetBytes((ushort)body.Length), 0, request, 0, 2);
                Buffer.BlockCopy(body, 0, request, 2, body.Length);
                byte[] reply = PhoneLOLLocalHost.PublicBoardRequest(2, request);
                if (reply[0] != 0) {
                    lock (gate) pendingError = "잠시 기다렸다가 다시 보내 주세요.";
                    return;
                }
                refreshAfterPost = true;
            } catch (Exception error) {
                lock (gate) pendingError = "채팅을 보내지 못했어요. " + error.GetType().Name;
            }
        });
    }
}
