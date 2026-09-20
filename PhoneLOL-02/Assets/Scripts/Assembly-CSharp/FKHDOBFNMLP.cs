using System;
using System.Collections.Generic;
using UnityEngine;

public static class FKHDOBFNMLP
{
	public static bool HMHKMGPHMIM = false;

	private static string[] IFHJLEFHGJD = null;

	private static Dictionary<string, string> EGLOGIOKKPN = new Dictionary<string, string>();

	private static Dictionary<string, string[]> BHIAKNHEFFK = new Dictionary<string, string[]>();

	private static int DLMNHEECJJA = -1;

	private static string BMFOJGBJFHB;

	public static Dictionary<string, string[]> OIDFMAINNPH
	{
		get
		{
			return JDPLMFJJDEI();
		}
		set
		{
			PAFMKOLDFEH(value);
		}
	}

	public static string[] CCODLOHMGKO
	{
		get
		{
			return APDIGFJIPEG();
		}
	}

	public static string GEEAMJJMPNB
	{
		get
		{
			return PMMHAHNIMCE();
		}
		set
		{
			CMMNJECGPDP(value);
		}
	}

	[Obsolete("Localization is now always active. You no longer need to check this property.")]
	public static bool DHDCGEBNAFB
	{
		get
		{
			return KPODHLJLDGE();
		}
	}

	public static Dictionary<string, string[]> JDPLMFJJDEI()
	{
		if (!HMHKMGPHMIM)
		{
			CMMNJECGPDP(PlayerPrefs.GetString("Language", "English"));
		}
		return BHIAKNHEFFK;
	}

	public static void PAFMKOLDFEH(Dictionary<string, string[]> ICENKPDOHBK)
	{
		HMHKMGPHMIM = ICENKPDOHBK != null;
		BHIAKNHEFFK = ICENKPDOHBK;
	}

	public static string[] APDIGFJIPEG()
	{
		if (!HMHKMGPHMIM)
		{
			EEKBCJLIAAB(PlayerPrefs.GetString("Language", "English"));
		}
		return IFHJLEFHGJD;
	}

	public static string PMMHAHNIMCE()
	{
		if (string.IsNullOrEmpty(BMFOJGBJFHB))
		{
			string[] array = APDIGFJIPEG();
			BMFOJGBJFHB = PlayerPrefs.GetString("Language", (array == null) ? "English" : array[0]);
			ANNLKGMFNDM(BMFOJGBJFHB);
		}
		return BMFOJGBJFHB;
	}

	public static void CMMNJECGPDP(string ICENKPDOHBK)
	{
		if (BMFOJGBJFHB != ICENKPDOHBK)
		{
			BMFOJGBJFHB = ICENKPDOHBK;
			ANNLKGMFNDM(ICENKPDOHBK);
		}
	}

	private static bool EEKBCJLIAAB(string ICENKPDOHBK)
	{
		TextAsset textAsset = ((!HMHKMGPHMIM) ? (Resources.Load("Localization", typeof(TextAsset)) as TextAsset) : null);
		HMHKMGPHMIM = true;
		if (textAsset != null && OIIDDENGJIP(textAsset))
		{
			return true;
		}
		if (string.IsNullOrEmpty(ICENKPDOHBK))
		{
			return false;
		}
		textAsset = Resources.Load(ICENKPDOHBK, typeof(TextAsset)) as TextAsset;
		if (textAsset != null)
		{
			AOBEBHBHAHB(textAsset);
			return true;
		}
		return false;
	}

	private static bool ANNLKGMFNDM(string ICENKPDOHBK)
	{
		if (!string.IsNullOrEmpty(ICENKPDOHBK))
		{
			if (BHIAKNHEFFK.Count == 0 && !EEKBCJLIAAB(ICENKPDOHBK))
			{
				return false;
			}
			if (BJDOAPLIJHP(ICENKPDOHBK))
			{
				return true;
			}
		}
		if (EGLOGIOKKPN.Count > 0)
		{
			return true;
		}
		EGLOGIOKKPN.Clear();
		BHIAKNHEFFK.Clear();
		if (string.IsNullOrEmpty(ICENKPDOHBK))
		{
			PlayerPrefs.DeleteKey("Language");
		}
		return false;
	}

	public static void AOBEBHBHAHB(TextAsset LAICENJGGCE)
	{
		NKGNEOPNCAD nKGNEOPNCAD = new NKGNEOPNCAD(LAICENJGGCE);
		LIJBCDKPJPP(LAICENJGGCE.name, nKGNEOPNCAD.PKLPAOAKLLP());
	}

	public static bool OIIDDENGJIP(TextAsset LAICENJGGCE)
	{
		NKGNEOPNCAD nKGNEOPNCAD = new NKGNEOPNCAD(LAICENJGGCE);
		global::MABNNPIGEPM<string> mABNNPIGEPM = nKGNEOPNCAD.HHEAKOECJEP();
		if (mABNNPIGEPM.POIJPKODPCK < 2)
		{
			return false;
		}
		mABNNPIGEPM.ADJJLIBDHLH(0, "KEY");
		if (!string.Equals(mABNNPIGEPM.AOBAKCJKELK(0), "KEY"))
		{
			Debug.LogError("Invalid localization CSV file. The first value is expected to be 'KEY', followed by language columns.\nInstead found '" + mABNNPIGEPM.AOBAKCJKELK(0) + "'", LAICENJGGCE);
			return false;
		}
		IFHJLEFHGJD = new string[mABNNPIGEPM.POIJPKODPCK - 1];
		for (int i = 0; i < IFHJLEFHGJD.Length; i++)
		{
			IFHJLEFHGJD[i] = mABNNPIGEPM.AOBAKCJKELK(i + 1);
		}
		BHIAKNHEFFK.Clear();
		while (mABNNPIGEPM != null)
		{
			EJIDKABOGMO(mABNNPIGEPM);
			mABNNPIGEPM = nKGNEOPNCAD.HHEAKOECJEP();
		}
		return true;
	}

	private static bool BJDOAPLIJHP(string GEEAMJJMPNB)
	{
		DLMNHEECJJA = -1;
		if (BHIAKNHEFFK.Count == 0)
		{
			return false;
		}
		string[] value;
		if (BHIAKNHEFFK.TryGetValue("KEY", out value))
		{
			for (int i = 0; i < value.Length; i++)
			{
				if (value[i] == GEEAMJJMPNB)
				{
					EGLOGIOKKPN.Clear();
					DLMNHEECJJA = i;
					BMFOJGBJFHB = GEEAMJJMPNB;
					PlayerPrefs.SetString("Language", BMFOJGBJFHB);
					UIRoot.Broadcast("OnLocalize");
					return true;
				}
			}
		}
		return false;
	}

	private static void EJIDKABOGMO(global::MABNNPIGEPM<string> GGOOLLLBEDD)
	{
		if (GGOOLLLBEDD.POIJPKODPCK < 2)
		{
			return;
		}
		string[] array = new string[GGOOLLLBEDD.POIJPKODPCK - 1];
		for (int i = 1; i < GGOOLLLBEDD.POIJPKODPCK; i++)
		{
			array[i - 1] = GGOOLLLBEDD.AOBAKCJKELK(i);
		}
		try
		{
			BHIAKNHEFFK.Add(GGOOLLLBEDD.AOBAKCJKELK(0), array);
		}
		catch (Exception ex)
		{
			Debug.LogError("Unable to add '" + GGOOLLLBEDD.AOBAKCJKELK(0) + "' to the Localization dictionary.\n" + ex.Message);
		}
	}

	public static void LIJBCDKPJPP(string ADEDNBHHLGA, Dictionary<string, string> OIDFMAINNPH)
	{
		BMFOJGBJFHB = ADEDNBHHLGA;
		PlayerPrefs.SetString("Language", BMFOJGBJFHB);
		EGLOGIOKKPN = OIDFMAINNPH;
		HMHKMGPHMIM = false;
		DLMNHEECJJA = -1;
		IFHJLEFHGJD = new string[1] { ADEDNBHHLGA };
		UIRoot.Broadcast("OnLocalize");
	}

	public static string OHKHGNFHJJM(string NNKLGFNHPBE)
	{
		if (!HMHKMGPHMIM)
		{
			CMMNJECGPDP(PlayerPrefs.GetString("Language", "English"));
		}
		string key = NNKLGFNHPBE + " Mobile";
		string[] value;
		string value2;
		if (DLMNHEECJJA != -1 && BHIAKNHEFFK.TryGetValue(key, out value))
		{
			if (DLMNHEECJJA < value.Length)
			{
				return value[DLMNHEECJJA];
			}
		}
		else if (EGLOGIOKKPN.TryGetValue(key, out value2))
		{
			return value2;
		}
		if (DLMNHEECJJA != -1 && BHIAKNHEFFK.TryGetValue(NNKLGFNHPBE, out value))
		{
			if (DLMNHEECJJA < value.Length)
			{
				return value[DLMNHEECJJA];
			}
		}
		else if (EGLOGIOKKPN.TryGetValue(NNKLGFNHPBE, out value2))
		{
			return value2;
		}
		return NNKLGFNHPBE;
	}

	public static bool KPODHLJLDGE()
	{
		return true;
	}

	[Obsolete("Use Localization.Get instead")]
	public static string HONAJKBMOLE(string NNKLGFNHPBE)
	{
		return OHKHGNFHJJM(NNKLGFNHPBE);
	}

	public static bool AHJFIHAPDEG(string NNKLGFNHPBE)
	{
		if (!HMHKMGPHMIM)
		{
			CMMNJECGPDP(PlayerPrefs.GetString("Language", "English"));
		}
		string key = NNKLGFNHPBE + " Mobile";
		if (BHIAKNHEFFK.ContainsKey(key))
		{
			return true;
		}
		if (EGLOGIOKKPN.ContainsKey(key))
		{
			return true;
		}
		return BHIAKNHEFFK.ContainsKey(NNKLGFNHPBE) || EGLOGIOKKPN.ContainsKey(NNKLGFNHPBE);
	}
}
