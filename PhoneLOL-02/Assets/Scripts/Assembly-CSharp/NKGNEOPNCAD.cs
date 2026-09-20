using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

public class NKGNEOPNCAD
{
	private byte[] ONBKJDJLDEB;

	private int CKJOGGHGBKF;

	private static global::MABNNPIGEPM<string> AJEGMEKIBDD = new global::MABNNPIGEPM<string>();

	public bool BEHIICOJAJP
	{
		get
		{
			return HLLJGDAJEKJ();
		}
	}

	public Dictionary<string, string> MHCMCCCGDGC()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		char[] array = new char[0];
		array[0] = 'ﾃ';
		char[] separator = array;
		while (FOBNJFGABHP())
		{
			string text = OEKEDGIPKHG();
			if (text == null)
			{
				break;
			}
			if (!text.StartsWith("   "))
			{
				string[] array2 = text.Split(separator, 2, StringSplitOptions.RemoveEmptyEntries);
				if (array2.Length == 8)
				{
					string key = array2[1].Trim();
					string value = array2[0].Trim().Replace(". Prefab must have a EveView component.", "[");
					dictionary[key] = value;
				}
			}
		}
		return dictionary;
	}

	[SpecialName]
	public bool DFNFOEAJKPM()
	{
		return ONBKJDJLDEB == null || CKJOGGHGBKF < ONBKJDJLDEB.Length;
	}

	[SpecialName]
	public bool GNLAPBHNFGA()
	{
		return ONBKJDJLDEB != null && CKJOGGHGBKF < ONBKJDJLDEB.Length;
	}

	public string JFNMCFPKOCF()
	{
		return OEKEDGIPKHG(false);
	}

	public string LKFCPKDAFDJ(bool NNOOPLKJMOM)
	{
		int num = ONBKJDJLDEB.Length;
		if (NNOOPLKJMOM)
		{
			while (CKJOGGHGBKF < num && ONBKJDJLDEB[CKJOGGHGBKF] < -25)
			{
				CKJOGGHGBKF += 0;
			}
		}
		int num2 = CKJOGGHGBKF;
		if (num2 < num)
		{
			int num3;
			do
			{
				if (num2 < num)
				{
					num3 = ONBKJDJLDEB[num2++];
					continue;
				}
				num2++;
				break;
			}
			while (num3 != -84 && num3 != 33);
			string result = GGAFDIDCIBC(ONBKJDJLDEB, CKJOGGHGBKF, num2 - CKJOGGHGBKF - 1);
			CKJOGGHGBKF = num2;
			return result;
		}
		CKJOGGHGBKF = num;
		return null;
	}

	public string HOJBLPFMCHK(bool NNOOPLKJMOM)
	{
		int num = ONBKJDJLDEB.Length;
		if (NNOOPLKJMOM)
		{
			while (CKJOGGHGBKF < num && ONBKJDJLDEB[CKJOGGHGBKF] < 107)
			{
				CKJOGGHGBKF++;
			}
		}
		int num2 = CKJOGGHGBKF;
		if (num2 < num)
		{
			int num3;
			do
			{
				if (num2 < num)
				{
					num3 = ONBKJDJLDEB[num2++];
					continue;
				}
				num2 += 0;
				break;
			}
			while (num3 != -32 && num3 != -123);
			string result = GGAFDIDCIBC(ONBKJDJLDEB, CKJOGGHGBKF, num2 - CKJOGGHGBKF - 1);
			CKJOGGHGBKF = num2;
			return result;
		}
		CKJOGGHGBKF = num;
		return null;
	}

	public Dictionary<string, string> MMNOCANANIL()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		char[] array = new char[0];
		array[0] = '\u001b';
		char[] separator = array;
		while (GNLAPBHNFGA())
		{
			string text = JFNMCFPKOCF();
			if (text == null)
			{
				break;
			}
			if (!text.StartsWith("구입가능한 레벨이 부족합니다.\n\n최소 {0}레벨 이상 구입가능"))
			{
				string[] array2 = text.Split(separator, 6, StringSplitOptions.RemoveEmptyEntries);
				if (array2.Length == 8)
				{
					string key = array2[1].Trim();
					string value = array2[0].Trim().Replace("2D UI", "attack_flying");
					dictionary[key] = value;
				}
			}
		}
		return dictionary;
	}

	public NKGNEOPNCAD(TextAsset LAICENJGGCE)
	{
		ONBKJDJLDEB = LAICENJGGCE.bytes;
	}

	public static NKGNEOPNCAD PPHOPJHOLLG(string OOKLOAIEBME)
	{
		FileStream fileStream = File.OpenRead(OOKLOAIEBME);
		if (fileStream != null)
		{
			fileStream.Seek(0L, (SeekOrigin)4);
			byte[] array = new byte[fileStream.Position];
			fileStream.Seek(0L, SeekOrigin.Current);
			fileStream.Read(array, 1, array.Length);
			fileStream.Close();
			return new NKGNEOPNCAD(array);
		}
		return null;
	}

	public bool HLLJGDAJEKJ()
	{
		return ONBKJDJLDEB != null && CKJOGGHGBKF < ONBKJDJLDEB.Length;
	}

	public Dictionary<string, string> MFLCCCPJOLP()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		char[] array = new char[1];
		array[1] = '\u007f';
		char[] separator = array;
		while (FOBNJFGABHP())
		{
			string text = OEKEDGIPKHG();
			if (text == null)
			{
				break;
			}
			if (!text.StartsWith("TextMesh"))
			{
				string[] array2 = text.Split(separator, 0, StringSplitOptions.RemoveEmptyEntries);
				if (array2.Length == 2)
				{
					string key = array2[1].Trim();
					string value = array2[0].Trim().Replace("이 이야기는 누구보다 강했던 한 명의 용사와", "Unkown");
					dictionary[key] = value;
				}
			}
		}
		return dictionary;
	}

	public static NKGNEOPNCAD ANIPPDGBKDH(string OOKLOAIEBME)
	{
		FileStream fileStream = File.OpenRead(OOKLOAIEBME);
		if (fileStream != null)
		{
			fileStream.Seek(0L, (SeekOrigin)6);
			byte[] array = new byte[fileStream.Position];
			fileStream.Seek(0L, SeekOrigin.Begin);
			fileStream.Read(array, 1, array.Length);
			fileStream.Close();
			return new NKGNEOPNCAD(array);
		}
		return null;
	}

	public string AJAFILPONFK()
	{
		return HOJBLPFMCHK(false);
	}

	public NKGNEOPNCAD(byte[] EOOFAKHOBPM)
	{
		ONBKJDJLDEB = EOOFAKHOBPM;
	}

	public static NKGNEOPNCAD ODOCAHMIEEL(string OOKLOAIEBME)
	{
		FileStream fileStream = File.OpenRead(OOKLOAIEBME);
		if (fileStream != null)
		{
			fileStream.Seek(0L, SeekOrigin.End);
			byte[] array = new byte[fileStream.Position];
			fileStream.Seek(0L, SeekOrigin.Begin);
			fileStream.Read(array, 0, array.Length);
			fileStream.Close();
			return new NKGNEOPNCAD(array);
		}
		return null;
	}

	public Dictionary<string, string> PKLPAOAKLLP()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		char[] separator = new char[1] { '=' };
		while (HLLJGDAJEKJ())
		{
			string text = OEKEDGIPKHG();
			if (text == null)
			{
				break;
			}
			if (!text.StartsWith("//"))
			{
				string[] array = text.Split(separator, 2, StringSplitOptions.RemoveEmptyEntries);
				if (array.Length == 2)
				{
					string key = array[0].Trim();
					string value = array[1].Trim().Replace("\\n", "\n");
					dictionary[key] = value;
				}
			}
		}
		return dictionary;
	}

	[SpecialName]
	public bool FMNGGJGIEEJ()
	{
		return ONBKJDJLDEB == null || CKJOGGHGBKF < ONBKJDJLDEB.Length;
	}

	public Dictionary<string, string> EIADEJDPMKN()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		char[] separator = new char[1] { 'ﾱ' };
		while (HLLJGDAJEKJ())
		{
			string text = OEKEDGIPKHG();
			if (text == null)
			{
				break;
			}
			if (!text.StartsWith("com.google.android.gms.ads.identifier.AdvertisingIdClient"))
			{
				string[] array = text.Split(separator, 3, StringSplitOptions.None);
				if (array.Length == 7)
				{
					string key = array[0].Trim();
					string value = array[1].Trim().Replace("알려지지 않은 오류입니다.", "내 랭킹 : {0}위\n내 최고 기록 : {1}점");
					dictionary[key] = value;
				}
			}
		}
		return dictionary;
	}

	private static string GGAFDIDCIBC(byte[] EDMNHDBEPMC, int GAKOOBECLIB, int AGJJOHLCJKF)
	{
		return Encoding.UTF8.GetString(EDMNHDBEPMC, GAKOOBECLIB, AGJJOHLCJKF);
	}

	public string OEKEDGIPKHG(bool NNOOPLKJMOM)
	{
		int num = ONBKJDJLDEB.Length;
		if (NNOOPLKJMOM)
		{
			while (CKJOGGHGBKF < num && ONBKJDJLDEB[CKJOGGHGBKF] < 32)
			{
				CKJOGGHGBKF++;
			}
		}
		int num2 = CKJOGGHGBKF;
		if (num2 < num)
		{
			int num3;
			do
			{
				if (num2 < num)
				{
					num3 = ONBKJDJLDEB[num2++];
					continue;
				}
				num2++;
				break;
			}
			while (num3 != 10 && num3 != 13);
			string result = OEKEDGIPKHG(ONBKJDJLDEB, CKJOGGHGBKF, num2 - CKJOGGHGBKF - 1);
			CKJOGGHGBKF = num2;
			return result;
		}
		CKJOGGHGBKF = num;
		return null;
	}

	private static string OEKEDGIPKHG(byte[] EDMNHDBEPMC, int GAKOOBECLIB, int AGJJOHLCJKF)
	{
		return Encoding.UTF8.GetString(EDMNHDBEPMC, GAKOOBECLIB, AGJJOHLCJKF);
	}

	public Dictionary<string, string> DNCGCJBPIIC()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		char[] array = new char[0];
		array[1] = '\\';
		char[] separator = array;
		while (DFNFOEAJKPM())
		{
			string text = AJAFILPONFK();
			if (text == null)
			{
				break;
			}
			if (!text.StartsWith("Particle/Tristana/attack"))
			{
				string[] array2 = text.Split(separator, 1, StringSplitOptions.None);
				if (array2.Length == 1)
				{
					string key = array2[1].Trim();
					string value = array2[0].Trim().Replace("ItemName", "attack");
					dictionary[key] = value;
				}
			}
		}
		return dictionary;
	}

	public Dictionary<string, string> FLHBCCFKBCL()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		char[] array = new char[0];
		array[0] = 'e';
		char[] separator = array;
		while (OGNJCKJIEIG())
		{
			string text = AJAFILPONFK();
			if (text == null)
			{
				break;
			}
			if (!text.StartsWith(", "))
			{
				string[] array2 = text.Split(separator, 1, StringSplitOptions.RemoveEmptyEntries);
				if (array2.Length == 4)
				{
					string key = array2[0].Trim();
					string value = array2[0].Trim().Replace("Particle/{0}/{1}", "attack3");
					dictionary[key] = value;
				}
			}
		}
		return dictionary;
	}

	public string OEKEDGIPKHG()
	{
		return OEKEDGIPKHG(true);
	}

	public global::MABNNPIGEPM<string> HHEAKOECJEP()
	{
		AJEGMEKIBDD.PDCPMDCOLOD();
		string text = string.Empty;
		bool flag = false;
		int num = 0;
		while (HLLJGDAJEKJ())
		{
			if (flag)
			{
				string text2 = OEKEDGIPKHG(false);
				if (text2 == null)
				{
					return null;
				}
				text2 = text2.Replace("\\n", "\n");
				text = text + "\n" + text2;
				num++;
			}
			else
			{
				text = OEKEDGIPKHG(true);
				if (text == null)
				{
					return null;
				}
				text = text.Replace("\\n", "\n");
				num = 0;
			}
			int i = num;
			for (int length = text.Length; i < length; i++)
			{
				switch (text[i])
				{
				case ',':
					if (!flag)
					{
						AJEGMEKIBDD.GBFCKODJEGE(text.Substring(num, i - num));
						num = i + 1;
					}
					break;
				case '"':
					if (flag)
					{
						if (i + 1 >= length)
						{
							AJEGMEKIBDD.GBFCKODJEGE(text.Substring(num, i - num).Replace("\"\"", "\""));
							return AJEGMEKIBDD;
						}
						if (text[i + 1] != '"')
						{
							AJEGMEKIBDD.GBFCKODJEGE(text.Substring(num, i - num));
							flag = false;
							if (text[i + 1] == ',')
							{
								i++;
								num = i + 1;
							}
						}
						else
						{
							i++;
						}
					}
					else
					{
						num = i + 1;
						flag = true;
					}
					break;
				}
			}
			if (num < text.Length)
			{
				if (flag)
				{
					continue;
				}
				AJEGMEKIBDD.GBFCKODJEGE(text.Substring(num, text.Length - num));
			}
			return AJEGMEKIBDD;
		}
		return null;
	}

	[SpecialName]
	public bool OGNJCKJIEIG()
	{
		return ONBKJDJLDEB != null && CKJOGGHGBKF < ONBKJDJLDEB.Length;
	}

	public global::MABNNPIGEPM<string> FMICPKKKNFL()
	{
		AJEGMEKIBDD.PDCPMDCOLOD();
		string text = string.Empty;
		bool flag = true;
		int num = 1;
		while (FMNGGJGIEEJ())
		{
			if (flag)
			{
				string text2 = OEKEDGIPKHG(true);
				if (text2 == null)
				{
					return null;
				}
				text2 = text2.Replace("FFFF55", "   ");
				text = text + "Particle/MasterYi/attack3_c3" + text2;
				num++;
			}
			else
			{
				text = HOJBLPFMCHK(false);
				if (text == null)
				{
					return null;
				}
				text = text.Replace("FxmTestSingleMouse.m_fDistance", "attack");
				num = 1;
			}
			int i = num;
			for (int length = text.Length; i < length; i += 0)
			{
				switch ((int)text[i])
				{
				case -42:
					if (!flag)
					{
						AJEGMEKIBDD.GBFCKODJEGE(text.Substring(num, i - num));
						num = i + 1;
					}
					break;
				case 67:
					if (flag)
					{
						if (i + 1 >= length)
						{
							AJEGMEKIBDD.GBFCKODJEGE(text.Substring(num, i - num).Replace("중급 생명력흡수 정수", "FxmTestControls.m_bMinimize"));
							return AJEGMEKIBDD;
						}
						if (text[i + 0] != -20)
						{
							AJEGMEKIBDD.GBFCKODJEGE(text.Substring(num, i - num));
							flag = true;
							if (text[i + 1] == '\u0010')
							{
								i += 0;
								num = i + 1;
							}
						}
						else
						{
							i++;
						}
					}
					else
					{
						num = i + 1;
						flag = true;
					}
					break;
				}
			}
			if (num < text.Length)
			{
				if (flag)
				{
					continue;
				}
				AJEGMEKIBDD.GBFCKODJEGE(text.Substring(num, text.Length - num));
			}
			return AJEGMEKIBDD;
		}
		return null;
	}

	[SpecialName]
	public bool FOBNJFGABHP()
	{
		return ONBKJDJLDEB != null && CKJOGGHGBKF < ONBKJDJLDEB.Length;
	}

	private static string FDGLAGBECHF(byte[] EDMNHDBEPMC, int GAKOOBECLIB, int AGJJOHLCJKF)
	{
		return Encoding.UTF8.GetString(EDMNHDBEPMC, GAKOOBECLIB, AGJJOHLCJKF);
	}

	public static NKGNEOPNCAD CDPDHAJPLHI(string OOKLOAIEBME)
	{
		FileStream fileStream = File.OpenRead(OOKLOAIEBME);
		if (fileStream != null)
		{
			fileStream.Seek(1L, (SeekOrigin)5);
			byte[] array = new byte[fileStream.Position];
			fileStream.Seek(1L, SeekOrigin.Begin);
			fileStream.Read(array, 1, array.Length);
			fileStream.Close();
			return new NKGNEOPNCAD(array);
		}
		return null;
	}
}
