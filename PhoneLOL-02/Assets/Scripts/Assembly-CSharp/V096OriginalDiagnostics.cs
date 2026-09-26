using System;
using UnityEngine;

// Preserve recovered call sites while routing diagnostics through the persistent runtime service.
internal static class V096OriginalDiagnostics
{
    private static bool loginActive, loginReply, gameActive, battleActive;
    private static float loginStart, gameStart, battleStart;
    public static void Initialize() { PhoneLOLRuntimeServices.Ensure(); }

    public static string GetStableDeviceId()
    {
        Initialize();
        // Keep the exact key used by 1.15.11 so an update does not silently create a new identity.
        const string key = "START: HOST TRIGGER SEEN ";
        string value = PlayerPrefs.GetString(key, "");
        if (string.IsNullOrEmpty(value)) value = PlayerPrefs.GetString("PhoneLOL.Private.DeviceId", "");
        if (string.IsNullOrEmpty(value)) value = SystemInfo.deviceUniqueIdentifier;
        if (string.IsNullOrEmpty(value) || value == "unknown") value = Guid.NewGuid().ToString("N");
        PlayerPrefs.SetString(key, value);
        PlayerPrefs.Save();
        return value;
    }

    public static void Write(string stage) { PhoneLOLRealtimeLog.Record("STAGE", stage); }
    public static void LoginConnect() {
        Initialize(); loginActive = true; loginReply = false; loginStart = Time.realtimeSinceStartup;
        Write("LOGIN_CONNECT loopback=20000 central=" + PhoneLOLServerSettings.Current); PhoneLOLRealtimeLog.Flush();
    }
    public static void LoginPacketBuilt() { Write("LOGIN_PACKET_BUILT protocol=24 mode=device"); }
    public static void LoginPacketSent() { Write("LOGIN_PACKET_QUEUED"); }
    public static void LoginReply() { loginActive = false; loginReply = true; Write("LOGIN_REPLY_HANDLED"); }
    public static bool ShouldHandleLoginFailure() {
        loginActive = false; Write(loginReply ? "LOGIN_CLOSED_AFTER_REPLY" : "LOGIN_FAILED_BEFORE_REPLY");
        PhoneLOLRealtimeLog.Flush(); return !loginReply;
    }
    public static void GameConnect() { gameActive = true; gameStart = Time.realtimeSinceStartup; Write("GAME_CONNECT"); }
    public static void GameReply() { Write("GAME_AUTH_REPLY"); }
    public static void GameReplyCompleted() { Write("GAME_AUTH_HANDLER_COMPLETED"); }
    public static void GameProfileHandlerEnter() { Write("PROFILE_HANDLER_ENTER"); }
    public static void GameProfileContractBypassed() { Write("PROFILE_CONTRACT_BYPASSED"); }
    public static void GameProfileHandlerCompleted() { Write("PROFILE_HANDLER_COMPLETED"); }
    public static void GameProfileStatusRejected() { gameActive = false; Write("PROFILE_REJECTED"); }
    public static void GameReady() { gameActive = false; Write("GAME_LOGIN_READY"); PhoneLOLRealtimeLog.Flush(); }
    public static void BattleLoadingStart() { battleActive = true; battleStart = Time.realtimeSinceStartup; Write("BATTLE_LOADING_START"); }
    public static void BattleLoadingExit() { battleActive = false; Write("BATTLE_LOADING_EXIT"); }
    public static void Tick() {
        float now = Time.realtimeSinceStartup;
        if (loginActive && now - loginStart > 12) { loginActive = false; QueueAutomaticReportImmediate("LOGIN_TIMEOUT_12S"); }
        if (gameActive && now - gameStart > 15) { gameActive = false; QueueAutomaticReportImmediate("GAME_LOGIN_TIMEOUT_15S"); }
        if (battleActive && now - battleStart > 30) { battleActive = false; QueueAutomaticReportImmediate("BATTLE_LOADING_TIMEOUT_30S"); }
    }
    public static void CleanExit() { Write("CLEAN_EXIT_REQUESTED"); PhoneLOLRealtimeLog.Flush(); }
    public static void ShareReport() { QueueAutomaticReportImmediate("USER_REPORT"); }
    public static void QueueAutomaticReportImmediate(string reason) { Write(reason); PhoneLOLRealtimeLog.Flush(); }
}
