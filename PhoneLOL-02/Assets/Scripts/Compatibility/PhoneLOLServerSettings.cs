using System;
using System.IO;
using UnityEngine;

[Serializable]
public sealed class PhoneLOLServerSettings
{
    public string host = "uko9ef6n.free.pwrp.cc";
    public int port = 10045;
    public static PhoneLOLServerSettings Current { get; private set; } = new PhoneLOLServerSettings();
    private static string path;

    public static void Load()
    {
        path = Path.Combine(Application.persistentDataPath, "PhoneLOL-server-settings.json");
        if (!File.Exists(path)) return;
        try {
            var value = JsonUtility.FromJson<PhoneLOLServerSettings>(File.ReadAllText(path));
            Validate(value.host, value.port);
            Current = value;
        } catch (Exception ex) {
            Debug.LogWarning("Server settings could not be loaded: " + ex.Message);
        }
    }

    public static void Save(string host, int port)
    {
        host = host.Trim();
        Validate(host, port);
        var value = new PhoneLOLServerSettings { host = host, port = port };
        File.WriteAllText(path + ".tmp", JsonUtility.ToJson(value, true));
        if (File.Exists(path)) File.Copy(path, path + ".previous", true);
        File.Copy(path + ".tmp", path, true);
        File.Delete(path + ".tmp");
        Current = value;
    }

    private static void Validate(string host, int port)
    {
        if (string.IsNullOrWhiteSpace(host) || Uri.CheckHostName(host) == UriHostNameType.Unknown)
            throw new ArgumentException("Enter a host name or IP address without a URL path.");
        if (port < 1 || port > 65535) throw new ArgumentException("Port must be between 1 and 65535.");
    }

    public override string ToString() { return host + ":" + port; }
}
