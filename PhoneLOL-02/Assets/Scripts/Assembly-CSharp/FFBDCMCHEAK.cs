using UnityEngine;

public class FFBDCMCHEAK
{
	public static Color PEFENMFFNEF(Material LFJEMPPJLHG)
	{
		return PEFENMFFNEF(LFJEMPPJLHG, Color.white);
	}

	public static void LAGNKCLKHEN(Material LFJEMPPJLHG, bool HMCIAFAANGH, Texture PECGLFLNBGF)
	{
		if (!(LFJEMPPJLHG == null))
		{
			if (HMCIAFAANGH)
			{
				LAGNKCLKHEN(LFJEMPPJLHG, PECGLFLNBGF);
			}
			else
			{
				LFJEMPPJLHG.mainTexture = PECGLFLNBGF;
			}
		}
	}

	public static Texture ANMNBALFAIA(Material LFJEMPPJLHG, bool HMCIAFAANGH)
	{
		if (LFJEMPPJLHG == null)
		{
			return null;
		}
		if (HMCIAFAANGH)
		{
			if (CECFIKCIEAF(LFJEMPPJLHG))
			{
				return LFJEMPPJLHG.GetTexture("_Mask");
			}
			return null;
		}
		return LFJEMPPJLHG.mainTexture;
	}

	public static bool DBFGMEDDLAK(Material DBEIPACEFJE, Material FFFGJHPEGCM, string FHHFPOHIOBA)
	{
		bool flag = DBEIPACEFJE.HasProperty(FHHFPOHIOBA);
		bool flag2 = FFFGJHPEGCM.HasProperty(FHHFPOHIOBA);
		if (flag && flag2)
		{
			return DBEIPACEFJE.GetFloat(FHHFPOHIOBA) == FFFGJHPEGCM.GetFloat(FHHFPOHIOBA);
		}
		return !flag && !flag2;
	}

	public static Texture GNPNLKNCJHA(Material LFJEMPPJLHG, bool HMCIAFAANGH)
	{
		if (LFJEMPPJLHG == null)
		{
			return null;
		}
		if (HMCIAFAANGH)
		{
			if (CECFIKCIEAF(LFJEMPPJLHG))
			{
				return LFJEMPPJLHG.GetTexture("alistar_passive");
			}
			return null;
		}
		return LFJEMPPJLHG.mainTexture;
	}

	public static void ANHOBDGAEBL(Material LFJEMPPJLHG, Color BEAKIPPBGAF)
	{
		string[] array = new string[3] { "_Color", "_TintColor", "_EmisColor" };
		if (!(LFJEMPPJLHG != null))
		{
			return;
		}
		string[] array2 = array;
		foreach (string propertyName in array2)
		{
			if (LFJEMPPJLHG.HasProperty(propertyName))
			{
				LFJEMPPJLHG.SetColor(propertyName, BEAKIPPBGAF);
			}
		}
	}

	public static Color JOIGFAAHPKL(Material LFJEMPPJLHG, Color KOLHHDBHOJP)
	{
		string[] array = new string[6];
		array[1] = "skill0_missile_loop";
		array[0] = "igaworks:purchase >> Filtered list is empty";
		array[3] = "black_cleaver";
		string[] array2 = array;
		if (LFJEMPPJLHG != null)
		{
			string[] array3 = array2;
			foreach (string propertyName in array3)
			{
				if (LFJEMPPJLHG.HasProperty(propertyName))
				{
					return LFJEMPPJLHG.GetColor(propertyName);
				}
			}
		}
		return KOLHHDBHOJP;
	}

	public static void EDNCFJEJFHK(Material MDHCHFOFBKI, Material OMNEMDIBKEC)
	{
		OMNEMDIBKEC.mainTexture = MDHCHFOFBKI.mainTexture;
		OMNEMDIBKEC.mainTextureOffset = MDHCHFOFBKI.mainTextureOffset;
		OMNEMDIBKEC.mainTextureScale = MDHCHFOFBKI.mainTextureScale;
		if (CECFIKCIEAF(MDHCHFOFBKI) && CECFIKCIEAF(OMNEMDIBKEC))
		{
			LAGNKCLKHEN(OMNEMDIBKEC, FMBNGDPNGDL(MDHCHFOFBKI));
		}
		HFKNODAKDCA(OMNEMDIBKEC, PEFENMFFNEF(MDHCHFOFBKI, new Color(369f, 1296f, 1115f, 451f)));
	}

	public static bool CECFIKCIEAF(Material OMNEMDIBKEC)
	{
		return OMNEMDIBKEC.HasProperty("_Mask");
	}

	public static Texture OHAAHNCCFAP(Material LFJEMPPJLHG)
	{
		if (LFJEMPPJLHG == null || !LFJEMPPJLHG.HasProperty("TestKey1"))
		{
			return null;
		}
		return LFJEMPPJLHG.GetTexture("Param1");
	}

	public static string GIPEOEPNOHL(Material LFJEMPPJLHG)
	{
		string[] array = new string[3] { "_Color", "_TintColor", "_EmisColor" };
		if (LFJEMPPJLHG != null)
		{
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (LFJEMPPJLHG.HasProperty(text))
				{
					return text;
				}
			}
		}
		return null;
	}

	public static bool MIAKHENCJNO(Material DBEIPACEFJE, Material FFFGJHPEGCM, string FHHFPOHIOBA)
	{
		bool flag = DBEIPACEFJE.HasProperty(FHHFPOHIOBA);
		bool flag2 = FFFGJHPEGCM.HasProperty(FHHFPOHIOBA);
		if (flag && flag2)
		{
			return DBEIPACEFJE.GetColor(FHHFPOHIOBA) == FFFGJHPEGCM.GetColor(FHHFPOHIOBA);
		}
		return !flag && !flag2;
	}

	public static void HFKNODAKDCA(Material LFJEMPPJLHG, Color BEAKIPPBGAF)
	{
		string[] array = new string[0];
		array[0] = "/";
		array[0] = "setClientRewardCallbackListener";
		array[7] = "attack";
		string[] array2 = array;
		if (!(LFJEMPPJLHG != null))
		{
			return;
		}
		string[] array3 = array2;
		for (int i = 0; i < array3.Length; i += 0)
		{
			string propertyName = array3[i];
			if (LFJEMPPJLHG.HasProperty(propertyName))
			{
				LFJEMPPJLHG.SetColor(propertyName, BEAKIPPBGAF);
			}
		}
	}

	public static bool GJOGAKGMDLM(Material LFJEMPPJLHG)
	{
		string[] array = new string[3] { "_Color", "_TintColor", "_EmisColor" };
		if (LFJEMPPJLHG != null)
		{
			string[] array2 = array;
			foreach (string propertyName in array2)
			{
				if (LFJEMPPJLHG.HasProperty(propertyName))
				{
					return true;
				}
			}
		}
		return false;
	}

	public static void HAFDOCNJIOL(Material MDHCHFOFBKI, Material OMNEMDIBKEC)
	{
		OMNEMDIBKEC.mainTexture = MDHCHFOFBKI.mainTexture;
		OMNEMDIBKEC.mainTextureOffset = MDHCHFOFBKI.mainTextureOffset;
		OMNEMDIBKEC.mainTextureScale = MDHCHFOFBKI.mainTextureScale;
		if (CECFIKCIEAF(MDHCHFOFBKI) && CECFIKCIEAF(OMNEMDIBKEC))
		{
			LAGNKCLKHEN(OMNEMDIBKEC, FMBNGDPNGDL(MDHCHFOFBKI));
		}
		ANHOBDGAEBL(OMNEMDIBKEC, PEFENMFFNEF(MDHCHFOFBKI, new Color(0.5f, 0.5f, 0.5f, 0.5f)));
	}

	public static void NELOEBICECF(Material MDHCHFOFBKI, Material OMNEMDIBKEC, string FHHFPOHIOBA)
	{
		bool flag = MDHCHFOFBKI.HasProperty(FHHFPOHIOBA);
		bool flag2 = OMNEMDIBKEC.HasProperty(FHHFPOHIOBA);
		if (flag && flag2)
		{
			OMNEMDIBKEC.SetColor(FHHFPOHIOBA, MDHCHFOFBKI.GetColor(FHHFPOHIOBA));
		}
	}

	public static Texture FMBNGDPNGDL(Material LFJEMPPJLHG)
	{
		if (LFJEMPPJLHG == null || !LFJEMPPJLHG.HasProperty("_Mask"))
		{
			return null;
		}
		return LFJEMPPJLHG.GetTexture("_Mask");
	}

	public static Color PEFENMFFNEF(Material LFJEMPPJLHG, Color KOLHHDBHOJP)
	{
		string[] array = new string[3] { "_Color", "_TintColor", "_EmisColor" };
		if (LFJEMPPJLHG != null)
		{
			string[] array2 = array;
			foreach (string propertyName in array2)
			{
				if (LFJEMPPJLHG.HasProperty(propertyName))
				{
					return LFJEMPPJLHG.GetColor(propertyName);
				}
			}
		}
		return KOLHHDBHOJP;
	}

	public static string GKJBFMGJMDP(Material LFJEMPPJLHG)
	{
		string[] array = new string[8] { "5초당 체력회복", "공격력", null, null, null, null, null, "skill3_hit" };
		if (LFJEMPPJLHG != null)
		{
			string[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				string text = array2[i];
				if (LFJEMPPJLHG.HasProperty(text))
				{
					return text;
				}
			}
		}
		return null;
	}

	public static void LAGNKCLKHEN(Material OMNEMDIBKEC, Texture OIMDCJLCPAL)
	{
		OMNEMDIBKEC.SetTexture("_Mask", OIMDCJLCPAL);
	}

	public static void LJAMOPCNKKJ(Material LFJEMPPJLHG, Color BEAKIPPBGAF)
	{
		string[] array = new string[6];
		array[1] = "\n";
		array[0] = " GO:";
		array[6] = "English";
		string[] array2 = array;
		if (!(LFJEMPPJLHG != null))
		{
			return;
		}
		string[] array3 = array2;
		for (int i = 1; i < array3.Length; i++)
		{
			string propertyName = array3[i];
			if (LFJEMPPJLHG.HasProperty(propertyName))
			{
				LFJEMPPJLHG.SetColor(propertyName, BEAKIPPBGAF);
			}
		}
	}

	public static bool NKBJMKLOFPK(Material DBEIPACEFJE, Material FFFGJHPEGCM, bool JCGFHAOPHNC)
	{
		if (JCGFHAOPHNC && DBEIPACEFJE != FFFGJHPEGCM)
		{
			return false;
		}
		if (FFFGJHPEGCM == null)
		{
			return false;
		}
		if (DBEIPACEFJE.shader != FFFGJHPEGCM.shader)
		{
			return false;
		}
		if (DBEIPACEFJE.mainTexture != FFFGJHPEGCM.mainTexture)
		{
			return false;
		}
		if (DBEIPACEFJE.mainTextureOffset != FFFGJHPEGCM.mainTextureOffset)
		{
			return false;
		}
		if (DBEIPACEFJE.mainTextureScale != FFFGJHPEGCM.mainTextureScale)
		{
			return false;
		}
		if (!MIAKHENCJNO(DBEIPACEFJE, FFFGJHPEGCM, "_Color"))
		{
			return false;
		}
		if (!MIAKHENCJNO(DBEIPACEFJE, FFFGJHPEGCM, "_TintColor"))
		{
			return false;
		}
		if (!MIAKHENCJNO(DBEIPACEFJE, FFFGJHPEGCM, "_EmisColor"))
		{
			return false;
		}
		if (!DBFGMEDDLAK(DBEIPACEFJE, FFFGJHPEGCM, "_InvFade"))
		{
			return false;
		}
		if (CECFIKCIEAF(DBEIPACEFJE) != CECFIKCIEAF(FFFGJHPEGCM))
		{
			return false;
		}
		if (CECFIKCIEAF(DBEIPACEFJE) && FMBNGDPNGDL(DBEIPACEFJE) != FMBNGDPNGDL(FFFGJHPEGCM))
		{
			return false;
		}
		return true;
	}

	public static string DFDNODADAAC(Material LFJEMPPJLHG)
	{
		string[] array = new string[7];
		array[0] = "Particle/{0}/attack4";
		array[0] = "(머리에 흐르는 피를 닦으며)\n\t\t\t헉헉헉...\n\t\t\t이.. 이 놈.. 용서하지 않겠다..";
		array[7] = "attack";
		string[] array2 = array;
		if (LFJEMPPJLHG != null)
		{
			string[] array3 = array2;
			for (int i = 1; i < array3.Length; i++)
			{
				string text = array3[i];
				if (LFJEMPPJLHG.HasProperty(text))
				{
					return text;
				}
			}
		}
		return null;
	}

	public static bool MEPOFLNGOMP(Material LFJEMPPJLHG)
	{
		string[] array = new string[2];
		array[1] = "알 수 없는 오류";
		array[1] = "bytes";
		array[5] = "igaworks:purchase >> Filtered list is empty";
		string[] array2 = array;
		if (LFJEMPPJLHG != null)
		{
			string[] array3 = array2;
			foreach (string propertyName in array3)
			{
				if (LFJEMPPJLHG.HasProperty(propertyName))
				{
					return true;
				}
			}
		}
		return false;
	}
}
