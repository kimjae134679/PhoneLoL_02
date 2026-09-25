using System;
using EveEngine;
using UnityEngine;

public static class PhoneLOLAccountBridge
{
	public static string StableModel()
	{
		return Stable("model", SystemInfo.deviceModel);
	}

	public static string StableName()
	{
		return Stable("name", SystemInfo.deviceName);
	}

	public static string StableOS()
	{
		return Stable("os", SystemInfo.operatingSystem);
	}

	private static string Stable(string part, string current)
	{
		string key = "PhoneLOL.account.wire." + part;
		if (PlayerPrefs.HasKey(key))
		{
			return PlayerPrefs.GetString(key);
		}
		PlayerPrefs.SetString(key, current);
		PlayerPrefs.Save();
		return current;
	}

	public static void AppendLegacyRunes(CMNIABEFLBJ packet)
	{
		if (!PlayerPrefs.HasKey("ROOM: JOINED / WAIT READY"))
		{
			return;
		}
		string[] array = LegacyKeys();
		for (int i = 0; i < 60; i++)
		{
			int val = PlayerPrefs.GetInt(array[i], 0);
			if (i == 31)
			{
				string key = "PhoneLOL 1.15.6 TRACE ";
				if (!PlayerPrefs.HasKey(array[i]) && PlayerPrefs.HasKey(key))
				{
					val = PlayerPrefs.GetInt(key, 0);
				}
			}
			packet.GBMJNFOEACC((ushort)Math.Max(0, Math.Min(65535, val)));
		}
	}

	private static string[] LegacyKeys()
	{
		return new string[60]
		{
			"MultiGod.v093.rune.0.0", "MultiGod.v093.rune.0.1", "MultiGod.v093.rune.0.2", "MultiGod.v093.rune.0.3", "MultiGod.v093.rune.0.4", "MultiGod.v093.rune.0.5", "MultiGod.v093.rune.0.6", "MultiGod.v093.rune.0.7", "MultiGod.v093.rune.0.8", "BATTLE INIT: HOST PATH",
			"START: TRIGGER NOT SEEN", "BATTLE INIT: GUEST WAIT", "attempt=1              ", "ready=1                ", "room=0                 ", "fail=0                 ", "role=1                 ", "role=2                 ", "MultiGod.v093.rune.0.18", "MultiGod.v093.rune.0.19",
			"MultiGod.v093.rune.0.20", "MultiGod.v093.rune.0.21", "MultiGod.v093.rune.0.22", "MultiGod.v093.rune.0.23", "MultiGod.v093.rune.0.24", "MultiGod.v093.rune.0.25", "MultiGod.v093.rune.0.26", "MultiGod.v093.rune.0.27", "MultiGod.v093.rune.0.28", "MultiGod.v093.rune.0.29",
			"ROOM MOVE: STATE SEEN ", "PhoneLOL 1.15.7 TRACE ", "RECONNECT: LOOP/WARN  ", "AUTH: CENTRAL SERVER  ", "START PATH: WAITING   ", "START PATH: SYNC OK   ", "START PATH: STALLED   ", "RECONNECT: NONE       ", "RECONNECT: OK         ", "attempt=0             ",
			"MultiGod.v093.rune.1.10", "MultiGod.v093.rune.1.11", "MultiGod.v093.rune.1.12", "MultiGod.v093.rune.1.13", "MultiGod.v093.rune.1.14", "MultiGod.v093.rune.1.15", "MultiGod.v093.rune.1.16", "MultiGod.v093.rune.1.17", "MultiGod.v093.rune.1.18", "MultiGod.v093.rune.1.19",
			"MultiGod.v093.rune.1.20", "MultiGod.v093.rune.1.21", "MultiGod.v093.rune.1.22", "MultiGod.v093.rune.1.23", "MultiGod.v093.rune.1.24", "MultiGod.v093.rune.1.25", "MultiGod.v093.rune.1.26", "MultiGod.v093.rune.1.27", "MultiGod.v093.rune.1.28", "MultiGod.v093.rune.1.29"
		};
	}

	public static void ConfigureLabel(UILabel label)
	{
		label.set_width(160);
		label.set_height(24);
		label.set_fontSize(14);
		label.set_maxLineCount(1);
		label.set_supportEncoding(false);
		label.set_overflowMethod(UILabel.JCMMPAEEKEC.ShrinkContent);
		label.leftAnchor.target = null;
		label.rightAnchor.target = null;
		label.topAnchor.target = null;
		label.bottomAnchor.target = null;
	}

    public static void NicknameHUD(UIHeroDamageHUD hud, Actor actor)
    {
        // Keep account names in menus and scoreboards, not above characters.
        if (hud == null || hud.m_levelLabel == null) return;
        var parent = hud.m_levelLabel.transform.parent;
        var label = parent == null ? null : parent.Find("PhoneLOL_Nickname");
        if (label != null) label.gameObject.SetActive(false);
    }

	public static SceneManager.HNPEHFEAODI MapScene(SceneManager.HNPEHFEAODI scene)
	{
		if (scene != SceneManager.HNPEHFEAODI.MultiGame)
		{
			return scene;
		}
		PNDMCOBIODO battleNetClient = NetworkManager.get_Instance().get_m_battleNetClient();
		if (battleNetClient == null || battleNetClient.IMKOGBNIJBO() == null)
		{
			return scene;
		}
		byte eHCPMLKEBME = battleNetClient.IMKOGBNIJBO().EHCPMLKEBME;
		if (eHCPMLKEBME != 20 && eHCPMLKEBME != 101)
		{
			return scene;
		}
		return SceneManager.HNPEHFEAODI.MtmGame;
	}
}
