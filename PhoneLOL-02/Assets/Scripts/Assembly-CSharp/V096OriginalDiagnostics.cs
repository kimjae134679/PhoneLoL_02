using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

internal static class V096OriginalDiagnostics
{
	private const string Version = "v1.1.20";

	private const string CleanKey = "PhoneLOL.Diagnostics.Clean";

	private const string LastStageKey = "PhoneLOL.Diagnostics.LastStage";

	private const string InstallIdKey = "PhoneLOL.Diagnostics.InstallId";

	private const string LegacyCleanKey = "PhoneLOL.v0962.Diag.Clean";

	private const string LegacyLastStageKey = "PhoneLOL.v0962.Diag.LastStage";

	private const string StableDeviceKey = "PhoneLOL.Private.DeviceId";

	private const string ReportFileName = "PhoneLOL-diagnostic.log";

	private const string LegacyReportFileName = "PhoneLOL-v0.96.2-diagnostic.txt";

	private const string QueueDirectoryName = "PhoneLOL-v1.1.20-pending-diagnostics";

	private const string NativeReportUrl = "http://127.0.0.1:8080/d";

	private const string UploadUrl = "https://script.google.com/macros/s/AKfycbz--y_w-5SxlZWBeIQcZRB8gqyMlQhJciA_o4S55YGTlpe8dTHfAFXmgrE-vvCQ__A1Mg/exec";

	private const string UploadSecret = "aba53e66165c2f5c84a3ceafa56c6afe779280db026982133c08a74042512924";

	private const int MaxPendingReports = 100;

	private const int UploadTimeoutSeconds = 25;

	private static readonly object FileLock = new object();

	private static bool initialized;

	private static bool writing;

	private static bool pendingPreviousExitUpload;

	private static bool cleanExit;

	private static bool loginActive;

	private static bool loginWarned;

	private static bool loginReplyCompleted;

	private static bool awaitingGameConnect;

	private static bool gameConnectAfterReplyWarned;

	private static bool gameActive;

	private static bool gameWarned;

	private static bool gameProfileCompleted;

	private static bool battleActive;

	private static bool battleWarned;

	private static bool uploadConfigurationWarned;

	private static float bootTime;

	private static float loginStart;

	private static float loginReplyTime;

	private static float gameStart;

	private static float battleStart;

	private static float lastRealtime;

	private static float nextUploadAttempt;

	private static float uploadStarted;

	private static int uploadFailures;

	private static string persistentRoot = string.Empty;

	private static string installId = string.Empty;

	private static string deviceModel = "unknown";

	private static string operatingSystem = "unknown";

	private static string lastStage = "none";

	private static DateTime lastErrorQueuedUtc = DateTime.MinValue;

	private static WWW activeUpload;

	private static string activeQueueFile;

	[SpecialName]
	private static string get_ReportPath()
	{
		return Path.Combine(persistentRoot, "PhoneLOL-diagnostic.log");
	}

	[SpecialName]
	private static string get_QueuePath()
	{
		return Path.Combine(persistentRoot, "PhoneLOL-v1.1.20-pending-diagnostics");
	}

	public static void Initialize()
	{
		if (!initialized)
		{
			initialized = true;
			bootTime = Time.realtimeSinceStartup;
			lastRealtime = bootTime;
			persistentRoot = Application.persistentDataPath;
			try
			{
				deviceModel = SystemInfo.deviceModel;
				operatingSystem = SystemInfo.operatingSystem;
			}
			catch
			{
			}
			try
			{
				Application.RegisterLogCallback(OnUnityLog);
				AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
			}
			catch (Exception ex)
			{
				RawAppend("SERVER: CONNECTED" + Safe(ex.GetType().FullName) + "|" + Safe(ex.Message));
			}
			MigrateLegacyReport();
			installId = PlayerPrefs.GetString("PhoneLOL.Diagnostics.InstallId", string.Empty);
			if (string.IsNullOrEmpty(installId))
			{
				installId = Guid.NewGuid().ToString("N");
				PlayerPrefs.SetString("PhoneLOL.Diagnostics.InstallId", installId);
			}
			int num = (PlayerPrefs.HasKey("PhoneLOL.Diagnostics.Clean") ? PlayerPrefs.GetInt("PhoneLOL.Diagnostics.Clean", 1) : PlayerPrefs.GetInt("START: GUEST TRIGGER SEEN", 1));
			string value = (lastStage = (PlayerPrefs.HasKey("PhoneLOL.Diagnostics.LastStage") ? PlayerPrefs.GetString("PhoneLOL.Diagnostics.LastStage", "none") : PlayerPrefs.GetString("PhoneLOL.v0962.Diag.LastStage", "none")));
			if (num == 0)
			{
				RawAppend("PREVIOUS_RUN_ENDED_WITHOUT_CLEAN_EXIT|last=" + Safe(value));
				pendingPreviousExitUpload = true;
			}
			PlayerPrefs.SetInt("PhoneLOL.Diagnostics.Clean", 0);
			PlayerPrefs.Save();
			Directory.CreateDirectory(get_QueuePath());
			Write("BOOT|version=v1.1.20|previous_clean=" + num + "ROOM: NOT JOINED" + Safe(value));
			nextUploadAttempt = bootTime;
			if (pendingPreviousExitUpload)
			{
				pendingPreviousExitUpload = false;
				QueueAutomaticReport("PREVIOUS_RUN_UNCLEAN_EXIT_IMMEDIATE");
			}
			QueueAutomaticReport("BOOT_AND_EMBEDDED_SERVER_START");
			TickAutomaticUpload(bootTime);
		}
	}

	public static string GetStableDeviceId()
	{
		Initialize();
		string text = PlayerPrefs.GetString("START: HOST TRIGGER SEEN ", string.Empty);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		try
		{
			text = SystemInfo.deviceUniqueIdentifier;
		}
		catch
		{
			text = string.Empty;
		}
		if (string.IsNullOrEmpty(text) || text == "unknown")
		{
			text = Guid.NewGuid().ToString("N");
		}
		PlayerPrefs.SetString("START: HOST TRIGGER SEEN ", text);
		PlayerPrefs.Save();
		Write("DEVICE_ID_READY|length=" + text.Length);
		return text;
	}

	public static void LoginConnect()
	{
		Initialize();
		loginActive = true;
		loginWarned = false;
		loginReplyCompleted = false;
		awaitingGameConnect = false;
		gameConnectAfterReplyWarned = false;
		loginStart = Time.realtimeSinceStartup;
		Write("LOGIN_CONNECT|127.0.0.1:20000");
		QueueAutomaticReportImmediate("SERVER_LOGIN_CONNECT_BEGIN");
	}

	public static void LoginPacketBuilt()
	{
		Write("LOGIN_PACKET_BUILT|protocol=24|mode=device");
	}

	public static void LoginPacketSent()
	{
		Write("SERVER: OFFLINE  ");
		QueueAutomaticReport("CHECKPOINT_LOGIN_PACKET_SENT");
	}

	public static void LoginReply()
	{
		loginActive = false;
		loginReplyCompleted = true;
		awaitingGameConnect = false;
		gameConnectAfterReplyWarned = false;
		RawAppend("LOGIN_REPLY_HANDLER_COMPLETED");
	}

	public static bool ShouldHandleLoginFailure()
	{
		loginActive = false;
		if (loginReplyCompleted)
		{
			RawAppend("LOGIN_CONNECTION_CLOSED_AFTER_REPLY|ignored=1");
			return false;
		}
		RawAppend("LOGIN_CONNECTION_FAILED_BEFORE_REPLY");
		return true;
	}

	public static void GameConnect()
	{
		awaitingGameConnect = false;
		gameActive = true;
		gameWarned = false;
		gameStart = Time.realtimeSinceStartup;
		gameProfileCompleted = false;
		RawAppend("GAME_CONNECT|127.0.0.1:20001");
	}

	public static void GameReply()
	{
		RawAppend("GAME_DISPATCH_ENTER|MAIN1");
	}

	public static void GameReplyCompleted()
	{
		gameActive = false;
		RawAppend("GAME_DISPATCH_RETURN|MAIN                       ");
	}

	public static void GameProfileHandlerEnter()
	{
	}

	public static void GameProfileContractBypassed()
	{
		RawAppend("PROFILE_WIRE_BYPASS|ZERO_READ                                         ");
	}

	public static void GameProfileHandlerCompleted()
	{
	}

	public static void GameProfileStatusRejected()
	{
		RawAppend("PROFILE_LOCAL_APPLY_DONE    ");
	}

	public static void BattleLoadingStart()
	{
		Write("BATTLE_LOADING_START");
		QueueAutomaticReportImmediate("BATTLE_LOADING_START");
	}

	public static void BattleLoadingExit()
	{
		Write("BATTLE_LOADING_EXIT_COMPLETE");
		QueueAutomaticReportImmediate("BATTLE_LOADING_EXIT_COMPLETE");
	}

	public static void Tick()
	{
		if (Time.realtimeSinceStartup - bootTime > 10f)
		{
			bootTime = Time.realtimeSinceStartup;
			QueueAutomaticReportImmediate("Refresh");
		}
		if (!initialized)
		{
			Initialize();
		}
		float num = (lastRealtime = Time.realtimeSinceStartup);
		if (pendingPreviousExitUpload)
		{
			pendingPreviousExitUpload = false;
			QueueAutomaticReport("PREVIOUS_RUN_UNCLEAN_EXIT");
		}
		if (loginActive && !loginWarned && num - loginStart > 12f)
		{
			loginWarned = true;
			Write("LOGIN_TIMEOUT_12S");
			QueueAutomaticReport("LOGIN_TIMEOUT_12S");
		}
		if (awaitingGameConnect && !gameConnectAfterReplyWarned && num - loginReplyTime > 10f)
		{
			gameConnectAfterReplyWarned = true;
			Write("GAME_CONNECT_NOT_STARTED_AFTER_LOGIN_REPLY_10S");
			QueueAutomaticReport("GAME_CONNECT_NOT_STARTED_AFTER_LOGIN_REPLY_10S");
		}
		if (gameActive && !gameWarned && num - gameStart > 15f)
		{
			gameWarned = true;
			Write("GAME_AUTH_TIMEOUT_15S");
			QueueAutomaticReport("GAME_AUTH_TIMEOUT_15S");
		}
		if (battleActive && !battleWarned && num - battleStart > 30f)
		{
			battleWarned = true;
			Write("BATTLE_LOADING_TIMEOUT_30S");
			QueueAutomaticReport("BATTLE_LOADING_TIMEOUT_30S");
		}
		TickAutomaticUpload(num);
	}

	public static void CleanExit()
	{
		cleanExit = true;
		Write("CLEAN_EXIT");
		PlayerPrefs.SetInt("PhoneLOL.Diagnostics.Clean", 1);
		PlayerPrefs.Save();
	}

	public static void ShareReport()
	{
		try
		{
			RawAppend(Encoding.UTF8.GetString(new WebClient().DownloadData("http://127.0.0.1:8080/d")));
		}
		catch (Exception)
		{
		}
	}

	private static void QueueAutomaticReport(string reason)
	{
		Initialize();
		try
		{
			string text = Guid.NewGuid().ToString("N");
			string text2 = DateTime.UtcNow.ToString("o");
			RawAppend("AUTO_UPLOAD_QUEUED|reason=" + Safe(reason) + "|event=" + text);
			string s = BuildReportText();
			string contents = "PHONELOL_DIAG_V1\naba53e66165c2f5c84a3ceafa56c6afe779280db026982133c08a74042512924\n1.15.11 \n" + installId + "\n" + text + "\n" + text2 + "\n" + Convert.ToBase64String(Encoding.UTF8.GetBytes(reason)) + "\n" + Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
			lock (FileLock)
			{
				Directory.CreateDirectory(get_QueuePath());
				File.WriteAllText(Path.Combine(get_QueuePath(), DateTime.UtcNow.ToString("yyyyMMddHHmmssfff") + "-" + text + ".pending"), contents, Encoding.UTF8);
				TrimPendingQueue();
			}
			if (nextUploadAttempt > lastRealtime + 0.5f)
			{
				nextUploadAttempt = lastRealtime + 0.5f;
			}
		}
		catch (Exception ex)
		{
			Write("AUTO_UPLOAD_QUEUE_FAILED|" + Safe(ex.GetType().FullName) + "|" + Safe(ex.Message));
		}
	}

	public static void QueueAutomaticReportImmediate(string reason)
	{
		QueueAutomaticReport(reason);
		try
		{
			float num = (lastRealtime = Time.realtimeSinceStartup);
			if (nextUploadAttempt > num)
			{
				nextUploadAttempt = num;
			}
			TickAutomaticUpload(num);
			TickAutomaticUpload(num);
		}
		catch (Exception ex)
		{
			Write("AUTO_UPLOAD_IMMEDIATE_START_FAILED|" + Safe(ex.GetType().FullName) + "|" + Safe(ex.Message));
		}
	}

	private static void TickAutomaticUpload(float now)
	{
		if (activeUpload != null)
		{
			if (activeUpload.isDone)
			{
				FinishAutomaticUpload(now, false);
			}
			else if (now - uploadStarted > 25f)
			{
				FinishAutomaticUpload(now, true);
			}
		}
		else
		{
			if (now < nextUploadAttempt)
			{
				return;
			}
			if (UploadConfigured())
			{
				try
				{
					string[] files;
					lock (FileLock)
					{
						Directory.CreateDirectory(get_QueuePath());
						files = Directory.GetFiles(get_QueuePath(), "*.pending");
					}
					if (files.Length == 0)
					{
						nextUploadAttempt = now + 5f;
					}
					else
					{
						Array.Sort(files, StringComparer.Ordinal);
						activeQueueFile = files[0];
						byte[] postData;
						lock (FileLock)
						{
							postData = File.ReadAllBytes(activeQueueFile);
						}
						activeUpload = new WWW("https://script.google.com/macros/s/AKfycbz--y_w-5SxlZWBeIQcZRB8gqyMlQhJciA_o4S55YGTlpe8dTHfAFXmgrE-vvCQ__A1Mg/exec", postData);
						uploadStarted = now;
					}
					return;
				}
				catch (Exception ex)
				{
					RegisterUploadFailure(now, "START|" + Safe(ex.Message));
					return;
				}
			}
			nextUploadAttempt = now + 300f;
			if (!uploadConfigurationWarned)
			{
				uploadConfigurationWarned = true;
				Write("AUTO_UPLOAD_NOT_CONFIGURED");
			}
		}
	}

	private static void FinishAutomaticUpload(float now, bool timedOut)
	{
		string value = (timedOut ? "TIMEOUT" : activeUpload.error);
		string text = string.Empty;
		if (!timedOut)
		{
			try
			{
				text = activeUpload.text;
			}
			catch (Exception ex)
			{
				value = "READ|" + ex.Message;
			}
		}
		try
		{
			activeUpload.Dispose();
		}
		catch
		{
		}
		activeUpload = null;
		if (string.IsNullOrEmpty(value) && text.IndexOf("\"ok\":true", StringComparison.Ordinal) >= 0)
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(activeQueueFile);
			try
			{
				lock (FileLock)
				{
					if (File.Exists(activeQueueFile))
					{
						File.Delete(activeQueueFile);
					}
				}
			}
			catch (Exception ex2)
			{
				RegisterUploadFailure(now, "DELETE|" + Safe(ex2.Message));
				return;
			}
			activeQueueFile = string.Empty;
			uploadFailures = 0;
			nextUploadAttempt = now + 0.25f;
			Write("AUTO_UPLOAD_OK|event=" + Safe(fileNameWithoutExtension));
		}
		else
		{
			RegisterUploadFailure(now, Safe(value));
		}
	}

	private static void RegisterUploadFailure(float now, string error)
	{
		activeQueueFile = string.Empty;
		uploadFailures++;
		int num = ((uploadFailures > 6) ? 6 : uploadFailures);
		int num2 = 5 * (1 << num);
		if (num2 > 300)
		{
			num2 = 300;
		}
		nextUploadAttempt = now + (float)num2;
		Write("AUTO_UPLOAD_FAILED|retry_seconds=" + num2 + "|error=" + Safe(error));
	}

	private static bool UploadConfigured()
	{
		if ("https://script.google.com/macros/s/AKfycbz--y_w-5SxlZWBeIQcZRB8gqyMlQhJciA_o4S55YGTlpe8dTHfAFXmgrE-vvCQ__A1Mg/exec".StartsWith("https://script.google.com/macros/s/", StringComparison.Ordinal) && "https://script.google.com/macros/s/AKfycbz--y_w-5SxlZWBeIQcZRB8gqyMlQhJciA_o4S55YGTlpe8dTHfAFXmgrE-vvCQ__A1Mg/exec".EndsWith("/exec", StringComparison.Ordinal) && "aba53e66165c2f5c84a3ceafa56c6afe779280db026982133c08a74042512924".Length >= 32)
		{
			return "aba53e66165c2f5c84a3ceafa56c6afe779280db026982133c08a74042512924".IndexOf("__PHONELOL_", StringComparison.Ordinal) < 0;
		}
		return false;
	}

	private static string BuildReportText()
	{
		string text;
		try
		{
			lock (FileLock)
			{
				text = (File.Exists(get_ReportPath()) ? File.ReadAllText(get_ReportPath()) : "diagnostic file not created");
			}
		}
		catch (Exception ex)
		{
			text = "diagnostic read failed: " + ex.Message;
		}
		if (text.Length > 48000)
		{
			text = "[SNAPSHOT_TRIMMED]\n" + text.Substring(text.Length - 48000);
		}
		return "PhoneLOL 1.15.11  direct-APK diagnostics\nNative live report: http://127.0.0.1:8080/d\nInstall: " + installId + "\nDevice: " + deviceModel + "\nOS: " + operatingSystem + "\nLast stage: " + lastStage + "\n\n" + text;
	}

	public static void Write(string stage)
	{
		NGUIDebug.JONCGPFBBNO(stage);
		Initialize();
		lastStage = stage;
		PlayerPrefs.SetString("PhoneLOL.Diagnostics.LastStage", stage);
		if (!cleanExit)
		{
			PlayerPrefs.SetInt("PhoneLOL.Diagnostics.Clean", 0);
		}
		PlayerPrefs.Save();
		RawAppend(stage);
	}

	private static void RawAppend(string stage)
	{
		lock (FileLock)
		{
			if (writing)
			{
				return;
			}
			writing = true;
			try
			{
				if (File.Exists(get_ReportPath()) && new FileInfo(get_ReportPath()).Length > 65536)
				{
					string text = File.ReadAllText(get_ReportPath());
					if (text.Length > 48000)
					{
						text = text.Substring(text.Length - 48000);
					}
					File.WriteAllText(get_ReportPath(), "[ROLLING_LOG_TRIMMED]\n" + text);
				}
				string text2 = DateTime.UtcNow.ToString("o") + "|t=" + lastRealtime.ToString("F3") + "|" + stage;
				File.AppendAllText(get_ReportPath(), text2 + Environment.NewLine, Encoding.UTF8);
			}
			catch
			{
			}
			finally
			{
				writing = false;
			}
		}
	}

	private static void TrimPendingQueue()
	{
		string[] files = Directory.GetFiles(get_QueuePath(), "*.pending");
		if (files.Length > 100)
		{
			Array.Sort(files, StringComparer.Ordinal);
			int num = files.Length - 100;
			for (int i = 0; i < num; i++)
			{
				File.Delete(files[i]);
			}
			RawAppend("AUTO_UPLOAD_QUEUE_TRIMMED|removed=" + num);
		}
	}

	private static void MigrateLegacyReport()
	{
		try
		{
			string text = Path.Combine(persistentRoot, "PhoneLOL-v0.96.2-diagnostic.txt");
			if (!File.Exists(get_ReportPath()) && File.Exists(text))
			{
				File.Copy(text, get_ReportPath());
			}
		}
		catch
		{
		}
	}

	private static string Safe(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return "none";
		}
		value = value.Replace("\r", " ").Replace("\n", " ");
		if (value.Length > 512)
		{
			value = value.Substring(0, 512);
		}
		return value;
	}

	private static void OnUnityLog(string condition, string stackTrace, LogType type)
	{
		if (!writing && (type == LogType.Error || type == LogType.Assert || type == LogType.Exception))
		{
			RawAppend("peer=0" + type.ToString() + "|" + Safe(condition) + "|" + Safe(stackTrace));
			DateTime utcNow = DateTime.UtcNow;
			if ((utcNow - lastErrorQueuedUtc).TotalSeconds >= 30.0)
			{
				lastErrorQueuedUtc = utcNow;
				QueueAutomaticReport("peer=0" + type);
			}
		}
	}

	private static void OnUnhandledException(object sender, UnhandledExceptionEventArgs args)
	{
		RawAppend("UNHANDLED_EXCEPTION|terminating=" + args.IsTerminating + "|" + Safe(Convert.ToString(args.ExceptionObject)));
		QueueAutomaticReport("ROOM: READY SYNC OK");
	}
}
