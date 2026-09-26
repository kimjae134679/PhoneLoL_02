using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;

// Loads operator-edited lobby notices from the existing game server.
public sealed class PhoneLOLLobbyNotice : MonoBehaviour
{
    [Serializable]
    private sealed class Notice { public string headline; public string body; }

    public static string CurrentBody { get; private set; }
    private readonly object gate = new object();
    private string pendingHeadline, pendingBody;
    private LobbyMain lobby;
    private bool started;

    private void Start()
    {
        lobby = GetComponent<LobbyMain>();
        CurrentBody = null;
        Fetch();
    }

    private void OnEnable()
    {
        if (started) Fetch();
    }

    private void Fetch()
    {
        if (started && lobby == null) return;
        started = true;
        var endpoint = PhoneLOLServerSettings.Current;
        ThreadPool.QueueUserWorkItem(_ => {
            try {
                using (var client = PhoneLOLTransport.Connect(endpoint))
                using (var stream = client.GetStream())
                using (var buffer = new MemoryStream()) {
                    var request = Encoding.ASCII.GetBytes("GET /phonelol-notice/v1 HTTP/1.1\r\nHost: " + endpoint +
                        "\r\nConnection: close\r\n\r\n");
                    stream.Write(request, 0, request.Length);
                    var bytes = new byte[1024];
                    int count;
                    while ((count = stream.Read(bytes, 0, bytes.Length)) != 0) {
                        if (buffer.Length + count > 8192) throw new InvalidDataException("Notice response too large.");
                        buffer.Write(bytes, 0, count);
                    }
                    string response = Encoding.UTF8.GetString(buffer.ToArray());
                    int split = response.IndexOf("\r\n\r\n", StringComparison.Ordinal);
                    if (split < 0 || !response.StartsWith("HTTP/1.1 200 ", StringComparison.Ordinal)) return;
                    var notice = JsonUtility.FromJson<Notice>(response.Substring(split + 4));
                    if (notice == null || notice.headline == null || notice.body == null) return;
                    lock (gate) { pendingHeadline = notice.headline; pendingBody = notice.body; }
                }
            } catch (Exception error) {
                PhoneLOLRealtimeLog.Record("NOTICE_FETCH_FAILED", error.GetType().Name);
            }
        });
    }

    private void Update()
    {
        string headline, body;
        lock (gate) {
            if (pendingHeadline == null) return;
            headline = pendingHeadline; body = pendingBody;
            pendingHeadline = null;
        }
        if (lobby == null || lobby.m_topPanel == null) return;
        var panel = lobby.m_topPanel.GetComponent<LobbyTopPanel>();
        if (panel == null || panel.m_noticeLabel == null) return;
        SceneManager.get_Instance().m_lobbyNotice = headline;
        CurrentBody = body;
        panel.m_noticeLabel.set_text(headline);
    }
}
