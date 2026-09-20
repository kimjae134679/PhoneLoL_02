using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

public static class PhoneLOLRealtimeLog
{
    private static readonly object gate = new object();
    private static readonly AutoResetEvent wake = new AutoResetEvent(false);
    private static readonly Regex secrets = new Regex(@"(?i)\b(token|password|secret|authorization|authcode|access_token)\s*[:=]\s*[^\s,;]+");
    private static readonly string run = Guid.NewGuid().ToString("N");
    private static string directory, journal, version;
    private static int lines, failures;
    private static long sequence;
    private static volatile bool stopped, ready;
    public static string Status = "Waiting to start";
    public static string LastAcknowledgedUtc = "";
    public static string SessionId { get { return run; } }

    public static void Initialize(string root, string appVersion)
    {
        lock (gate) {
            if (ready) return;
            directory = Path.Combine(root, "PhoneLOL-live-logs");
            Directory.CreateDirectory(directory);
            journal = Path.Combine(directory, "active.journal");
            version = appVersion;
            // A process killed between writes keeps its unacknowledged journal.
            if (File.Exists(journal) && new FileInfo(journal).Length > 0) Rotate();
            ready = true;
        }
        new Thread(UploadLoop) { IsBackground = true, Name = "PhoneLOL diagnostics" }.Start();
        Record("LOG_START", "transport=HTTP ack=204 retained_until_ack=1");
    }

    public static void Record(string category, string message)
    {
        if (!ready) return;
        message = secrets.Replace(message ?? "", "$1=[REDACTED]").Replace("\r", "\\r").Replace("\n", "\\n");
        lock (gate) {
            try {
                int chunks = Math.Max(1, (message.Length + 699) / 700);
                string eventId = run + "-" + (++sequence);
                for (int part = 0; part < chunks; part++) {
                    string chunk = message.Substring(part * 700, Math.Min(700, message.Length - part * 700));
                    string line = DateTime.UtcNow.ToString("o") + "|version=" + version + "|event=" + eventId +
                        "|part=" + (part + 1) + "/" + chunks + "|" + category + "|" + chunk;
                    File.AppendAllText(journal, line + "\n", new UTF8Encoding(false));
                    if (++lines >= 8) Rotate();
                }
            } catch (Exception ex) { Status = "Log storage failed: " + ex.GetType().Name; }
        }
    }

    private static void Rotate()
    {
        if (!File.Exists(journal) || new FileInfo(journal).Length == 0) return;
        string target = Path.Combine(directory, DateTime.UtcNow.ToString("yyyyMMddHHmmssfffffff") + "-" + Guid.NewGuid().ToString("N") + ".pending");
        File.Move(journal, target);
        lines = 0;
    }

    public static void Flush()
    {
        if (!ready) return;
        lock (gate) {
            try { Rotate(); } catch (Exception ex) { Status = "Log flush failed: " + ex.GetType().Name; }
        }
        wake.Set();
    }

    private static void UploadLoop()
    {
        int delay = 2000;
        while (!stopped) {
            wake.WaitOne(delay);
            if (stopped) break;
            try {
                string[] files;
                lock (gate) {
                    Rotate();
                    files = Directory.GetFiles(directory, "*.pending");
                    Array.Sort(files, StringComparer.Ordinal);
                    if (files.Length > 512) {
                        int removed = files.Length - 512;
                        for (int i = 0; i < removed; i++) File.Delete(files[i]);
                        Record("LOG_QUEUE_OVERFLOW", "oldest_batches_removed=" + removed + " limit=512");
                        files = Directory.GetFiles(directory, "*.pending");
                        Array.Sort(files, StringComparer.Ordinal);
                    }
                }
                if (files.Length == 0) { delay = 2000; continue; }
                int delivered = 0;
                foreach (string file in files) {
                    if (stopped || delivered >= 10) break;
                    byte[] data = File.ReadAllBytes(file);
                    SendBatch(PhoneLOLServerSettings.Current, data);
                    File.Delete(file);
                    delivered++;
                    LastAcknowledgedUtc = DateTime.UtcNow.ToString("o");
                }
                failures = 0;
                delay = files.Length > delivered ? 250 : 2000;
                Status = "Delivered " + LastAcknowledgedUtc + " / pending " + Math.Max(0, files.Length - delivered);
                File.WriteAllText(Path.Combine(directory, "upload-status.txt"), Status);
            } catch (Exception ex) {
                failures++;
                delay = Math.Min(30000, 2000 * (1 << Math.Min(failures, 4)));
                Status = "Upload failed; retained for retry: " + ex.GetType().Name + " " + ex.Message;
                try { File.WriteAllText(Path.Combine(directory, "upload-status.txt"), Status); } catch { }
                // This is a transport status, not another Unity error that recursively uploads itself.
            }
        }
    }

    public static void SendBatch(PhoneLOLServerSettings endpoint, byte[] data)
    {
        if (data.Length == 0 || data.Length > 32768) throw new InvalidDataException("Diagnostic batch exceeds receiver limit.");
        using (TcpClient client = PhoneLOLTransport.Connect(endpoint))
        using (NetworkStream stream = client.GetStream()) {
            string request = "POST /phonelol-diag/v1 HTTP/1.1\r\nHost: " + endpoint +
                "\r\nContent-Type: text/plain; charset=utf-8\r\nContent-Length: " + data.Length +
                "\r\nConnection: close\r\n\r\n";
            byte[] header = Encoding.ASCII.GetBytes(request);
            stream.Write(header, 0, header.Length); stream.Write(data, 0, data.Length);
            var response = new StringBuilder();
            while (response.Length < 4096) {
                int c = stream.ReadByte();
                if (c < 0) throw new EndOfStreamException("Diagnostic acknowledgement missing.");
                response.Append((char)c);
                if (response.ToString().EndsWith("\r\n\r\n", StringComparison.Ordinal)) break;
            }
            if (!response.ToString().StartsWith("HTTP/1.1 204 ", StringComparison.Ordinal))
                throw new IOException("Diagnostics receiver did not acknowledge the batch.");
        }
    }

    public static void Shutdown()
    {
        Record("APP_EXIT", "pending logs retained");
        Flush(); stopped = true; wake.Set();
    }
}
