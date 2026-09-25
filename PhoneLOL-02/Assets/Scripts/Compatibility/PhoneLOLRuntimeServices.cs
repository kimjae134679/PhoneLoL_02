using System;
using UnityEngine;
using UnityEngine.SceneManagement;

[DefaultExecutionOrder(-32000)]
public sealed class PhoneLOLRuntimeServices : MonoBehaviour
{
    private static PhoneLOLRuntimeServices instance;
    private PhoneLOLLocalHost host;
    private bool panel;
    [SerializeField] private bool showServerDiagnostics;
    private static int criticalConsolePending;
    private string hostname, port, feedback = "";
    private float nextHeartbeat;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void Ensure()
    {
        if (instance != null) return;
        new GameObject("PhoneLOL Runtime Services").AddComponent<PhoneLOLRuntimeServices>();
    }

    private void Awake()
    {
        if (instance != null) { Destroy(gameObject); return; }
        instance = this; DontDestroyOnLoad(gameObject);
        criticalConsolePending = 0;
        Debug.developerConsoleVisible = false;
        Debug.developerConsoleEnabled = false;
        PhoneLOLServerSettings.Load();
        PhoneLOLRealtimeLog.Initialize(Application.persistentDataPath, Application.version);
        Application.logMessageReceivedThreaded += UnityLog;
        AppDomain.CurrentDomain.UnhandledException += Unhandled;
        UnityEngine.SceneManagement.SceneManager.sceneLoaded += SceneLoaded;
        Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.Full);
        Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.Full);
        Screen.autorotateToPortrait = false;
        Screen.autorotateToPortraitUpsideDown = false;
        Screen.autorotateToLandscapeLeft = true;
        Screen.autorotateToLandscapeRight = true;
        Screen.orientation = ScreenOrientation.AutoRotation;
        PhoneLOLRealtimeLog.Record("BOOT", "unity=" + Application.unityVersion + " platform=" + Application.platform +
            " os=" + SystemInfo.operatingSystem + " model=" + SystemInfo.deviceModel +
            " cpu=" + SystemInfo.processorType + " pointer_bytes=" + IntPtr.Size +
            " graphics=" + SystemInfo.graphicsDeviceName + " screen=" + Screen.width + "x" + Screen.height);
        RestartHost();
    }

    private void RestartHost()
    {
        if (host != null) host.Dispose();
        host = null;
        try { host = new PhoneLOLLocalHost(PhoneLOLServerSettings.Current); }
        catch (Exception ex) { Debug.LogException(ex); feedback = ex.Message; }
        hostname = PhoneLOLServerSettings.Current.host;
        port = PhoneLOLServerSettings.Current.port.ToString();
    }

    private static void UnityLog(string message, string trace, LogType type)
    {
        if (type == LogType.Exception || type == LogType.Assert)
            System.Threading.Interlocked.Exchange(ref criticalConsolePending, 1);
        PhoneLOLRealtimeLog.Record("UNITY_" + type, message + (string.IsNullOrEmpty(trace) ? "" : "\n" + trace));
    }

    private static void Unhandled(object sender, UnhandledExceptionEventArgs e)
    {
        System.Threading.Interlocked.Exchange(ref criticalConsolePending, 1);
        PhoneLOLRealtimeLog.Record("UNHANDLED", Convert.ToString(e.ExceptionObject));
        PhoneLOLRealtimeLog.Flush();
    }

    private static void SceneLoaded(Scene scene, LoadSceneMode mode)
    {
        PhoneLOLRealtimeLog.Record("SCENE_LOADED", scene.name);
        PhoneLOLRealtimeLog.Flush();
    }

    private void Update()
    {
        if (System.Threading.Interlocked.Exchange(ref criticalConsolePending, 0) != 0) {
            Debug.developerConsoleEnabled = true;
            Debug.developerConsoleVisible = true;
        } else if (!Debug.developerConsoleVisible) {
            Debug.developerConsoleEnabled = false;
        }
        if (Time.realtimeSinceStartup < nextHeartbeat) return;
        nextHeartbeat = Time.realtimeSinceStartup + 15;
        PhoneLOLRealtimeLog.Record("HEARTBEAT", "scene=" + UnityEngine.SceneManagement.SceneManager.GetActiveScene().name +
            " reachability=" + Application.internetReachability + " orientation=" + Screen.orientation +
            " memory_mb=" + (GC.GetTotalMemory(false) / 1048576));
    }

    private void OnApplicationPause(bool paused)
    {
        PhoneLOLRealtimeLog.Record("APP_PAUSE", paused.ToString());
        PhoneLOLRealtimeLog.Flush();
    }

    private void OnApplicationFocus(bool focused)
    {
        PhoneLOLRealtimeLog.Record("APP_FOCUS", focused.ToString());
    }

    private void OnGUI()
    {
        if (!showServerDiagnostics) return;
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name != "Login") return;
        Matrix4x4 previous = GUI.matrix;
        int previousDepth = GUI.depth;
        GUI.matrix = Matrix4x4.Scale(new Vector3(Screen.width / 1000f, Screen.height / 600f, 1));
        GUI.depth = -1000;
        var button = new GUIStyle(GUI.skin.button) { fontSize = 20 };
        var label = new GUIStyle(GUI.skin.label) { fontSize = 19, wordWrap = true };
        var field = new GUIStyle(GUI.skin.textField) { fontSize = 22 };
        if (GUI.Button(new Rect(820, 12, 165, 42), "서버 / 로그", button)) panel = !panel;
        if (panel) {
            GUI.Box(new Rect(180, 80, 640, 445), "");
            GUI.Label(new Rect(205, 100, 585, 30), "서버 연결 설정", label);
            GUI.Label(new Rect(205, 145, 150, 30), "서버 주소", label);
            hostname = GUI.TextField(new Rect(350, 140, 435, 42), hostname, 253, field);
            GUI.Label(new Rect(205, 200, 150, 30), "포트", label);
            port = GUI.TextField(new Rect(350, 195, 160, 42), port, 5, field);
            if (GUI.Button(new Rect(530, 195, 255, 42), "저장하고 다시 연결", button)) {
                try {
                    int value;
                    if (!int.TryParse(port, out value)) throw new ArgumentException("포트를 숫자로 입력해 주세요.");
                    PhoneLOLServerSettings.Save(hostname, value);
                    RestartHost();
                    feedback = "저장했어요. 창을 닫고 로그인을 눌러 주세요.";
                    PhoneLOLRealtimeLog.Record("ENDPOINT_CHANGED", PhoneLOLServerSettings.Current.ToString());
                } catch (Exception ex) { feedback = ex.Message; }
            }
            GUI.Label(new Rect(205, 250, 580, 60), feedback, label);
            GUI.Label(new Rect(205, 315, 580, 85), "로그 전송: " + PhoneLOLRealtimeLog.Status, label);
            GUI.Label(new Rect(205, 405, 580, 35), "진단 ID: " + PhoneLOLRealtimeLog.SessionId.Substring(0, 12), label);
            if (GUI.Button(new Rect(205, 460, 270, 42), "로그 지금 보내기", button)) PhoneLOLRealtimeLog.Flush();
            if (GUI.Button(new Rect(515, 460, 270, 42), "닫기", button)) panel = false;
        }
        GUI.matrix = previous;
        GUI.depth = previousDepth;
    }

    private void OnDestroy()
    {
        if (instance != this) return;
        Application.logMessageReceivedThreaded -= UnityLog;
        AppDomain.CurrentDomain.UnhandledException -= Unhandled;
        UnityEngine.SceneManagement.SceneManager.sceneLoaded -= SceneLoaded;
        if (host != null) host.Dispose();
        PhoneLOLRealtimeLog.Shutdown();
        instance = null;
    }
}
