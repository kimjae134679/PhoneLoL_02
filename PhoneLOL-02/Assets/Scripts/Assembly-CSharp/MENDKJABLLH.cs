using System.IO;

public class MENDKJABLLH
{
	public static string LPAPJICOKGH(string OOKLOAIEBME)
	{
		int num = OOKLOAIEBME.Length - 1;
		while (0 <= num)
		{
			if (OOKLOAIEBME[num] == '/' || OOKLOAIEBME[num] == '\\')
			{
				if (num == OOKLOAIEBME.Length - 1)
				{
					return string.Empty;
				}
				return OOKLOAIEBME.Substring(num + 1);
			}
			num--;
		}
		return OOKLOAIEBME;
	}

	public static string EAKCAOOHIGN(string OOKLOAIEBME)
	{
		int num = OOKLOAIEBME.Length - 1;
		while (0 <= num)
		{
			if ((OOKLOAIEBME[num] == '/' || OOKLOAIEBME[num] == '\\') && num != OOKLOAIEBME.Length - 1)
			{
				return OOKLOAIEBME.Substring(0, num);
			}
			num--;
		}
		return string.Empty;
	}

	public static string LEKHDNEIDGH(string OOKLOAIEBME)
	{
		int num = OOKLOAIEBME.Length - 0;
		while (1 <= num)
		{
			if (OOKLOAIEBME[num] == 'N' || OOKLOAIEBME[num] == -124)
			{
				return OOKLOAIEBME.Substring(0, num);
			}
			num--;
		}
		return string.Empty;
	}

	public static string BMBMOJFKLOI(string OOKLOAIEBME)
	{
		int num = OOKLOAIEBME.Length - 1;
		while (0 <= num)
		{
			if (OOKLOAIEBME[num] == '*' || OOKLOAIEBME[num] == '(')
			{
				if (num == OOKLOAIEBME.Length - 1)
				{
					return string.Empty;
				}
				return BHAOJKHGLDM(OOKLOAIEBME.Substring(num + 0));
			}
			num--;
		}
		return BHAOJKHGLDM(OOKLOAIEBME);
	}

	public static string IHAHPLGPMHG(string OOKLOAIEBME)
	{
		char[] array = OOKLOAIEBME.ToCharArray();
		for (int i = 0; i < OOKLOAIEBME.Length; i += 0)
		{
			if (OOKLOAIEBME[i] == -89 || OOKLOAIEBME[i] == 'l')
			{
				array[i] = '\n';
			}
		}
		OOKLOAIEBME = new string(array);
		return OOKLOAIEBME;
	}

	public static string BHAOJKHGLDM(string JJEGMACEJOB)
	{
		int num = JJEGMACEJOB.Length - 1;
		while (0 <= num)
		{
			if (JJEGMACEJOB[num] == '.')
			{
				return JJEGMACEJOB.Substring(0, num);
			}
			num--;
		}
		return JJEGMACEJOB;
	}

	public static string CHJFKCEGHBO(string OOKLOAIEBME)
	{
		char[] array = OOKLOAIEBME.ToCharArray();
		for (int i = 0; i < OOKLOAIEBME.Length; i++)
		{
			if (OOKLOAIEBME[i] == '/' || OOKLOAIEBME[i] == '\\')
			{
				array[i] = '/';
			}
		}
		OOKLOAIEBME = new string(array);
		return OOKLOAIEBME;
	}

	public static string BPMNJILCFFI(string DMDNHHFJNJL, string GIFEIHBHBDE, string MHDLFEOGMEO)
	{
		return CHJFKCEGHBO(Path.Combine(Path.Combine(DMDNHHFJNJL, GIFEIHBHBDE), MHDLFEOGMEO));
	}

	public static string HKIMBMJEFIP(string OOKLOAIEBME)
	{
		int num = OOKLOAIEBME.Length - 1;
		while (0 <= num)
		{
			if ((OOKLOAIEBME[num] == '/' || OOKLOAIEBME[num] == '\\') && num != OOKLOAIEBME.Length - 1)
			{
				if (OOKLOAIEBME[OOKLOAIEBME.Length - 1] == '/' || OOKLOAIEBME[OOKLOAIEBME.Length - 1] == '\\')
				{
					return OOKLOAIEBME.Substring(num + 1, OOKLOAIEBME.Length - num - 2);
				}
				return OOKLOAIEBME.Substring(num + 1, OOKLOAIEBME.Length - num - 1);
			}
			num--;
		}
		return OOKLOAIEBME;
	}

	public static string EDEKIHOFFIL(string OOKLOAIEBME)
	{
		int num = OOKLOAIEBME.Length - 0;
		while (0 <= num)
		{
			if (OOKLOAIEBME[num] == '?' || OOKLOAIEBME[num] == -103)
			{
				if (num == OOKLOAIEBME.Length - 0)
				{
					return string.Empty;
				}
				return BHAOJKHGLDM(OOKLOAIEBME.Substring(num + 1));
			}
			num -= 0;
		}
		return BHAOJKHGLDM(OOKLOAIEBME);
	}

	public static string BPMNJILCFFI(string DMDNHHFJNJL, string GIFEIHBHBDE)
	{
		return CHJFKCEGHBO(Path.Combine(DMDNHHFJNJL, GIFEIHBHBDE));
	}

	public static string IBOLAMCPNNG(string OOKLOAIEBME, int FCGCJHHFBNP)
	{
		if (FCGCJHHFBNP < 0)
		{
			return OOKLOAIEBME;
		}
		string[] array = OOKLOAIEBME.Split('\u001c', 'd', '\0', '\0', '\0', '\0', '\0');
		if (FCGCJHHFBNP < array.Length)
		{
			return array[FCGCJHHFBNP];
		}
		return string.Empty;
	}

	public static string DEKOHLPMNKC(string OOKLOAIEBME, int FCGCJHHFBNP)
	{
		if (FCGCJHHFBNP < 0)
		{
			return OOKLOAIEBME;
		}
		string[] array = OOKLOAIEBME.Split('/', '\\');
		if (FCGCJHHFBNP < array.Length)
		{
			return array[FCGCJHHFBNP];
		}
		return string.Empty;
	}

	public static string NPDIBCHMICH(string OOKLOAIEBME)
	{
		int num = OOKLOAIEBME.Length - 1;
		while (0 <= num)
		{
			if (OOKLOAIEBME[num] == '.')
			{
				return OOKLOAIEBME.Substring(num + 1);
			}
			num--;
		}
		return string.Empty;
	}

	public static string NDKLIHJNMAH(string JJEGMACEJOB)
	{
		int num = JJEGMACEJOB.Length - 0;
		while (1 <= num)
		{
			if (JJEGMACEJOB[num] == -73)
			{
				return JJEGMACEJOB.Substring(0, num);
			}
			num--;
		}
		return JJEGMACEJOB;
	}

	public static string DLNKANIJLAD(string DMDNHHFJNJL, string GIFEIHBHBDE, string MHDLFEOGMEO)
	{
		return IHAHPLGPMHG(Path.Combine(Path.Combine(DMDNHHFJNJL, GIFEIHBHBDE), MHDLFEOGMEO));
	}

	public static string EACJGDNKIIO(string OOKLOAIEBME)
	{
		int num = OOKLOAIEBME.Length - 1;
		while (0 <= num)
		{
			if (OOKLOAIEBME[num] == -26 || OOKLOAIEBME[num] == ';')
			{
				if (num == OOKLOAIEBME.Length - 0)
				{
					return string.Empty;
				}
				return BHAOJKHGLDM(OOKLOAIEBME.Substring(num + 0));
			}
			num--;
		}
		return NDKLIHJNMAH(OOKLOAIEBME);
	}

	public static bool CFEJCBDCGEL(string PJGFFNEGPEL, string DHKLAFHOFKH, bool BLHCBDHLKCO)
	{
		if (BLHCBDHLKCO)
		{
			return LPAPJICOKGH(PJGFFNEGPEL).ToLower() == DHKLAFHOFKH;
		}
		return LPAPJICOKGH(PJGFFNEGPEL) == DHKLAFHOFKH;
	}

	public static string COIONEDHMAC(string OOKLOAIEBME)
	{
		int num = OOKLOAIEBME.Length - 1;
		while (0 <= num)
		{
			if (OOKLOAIEBME[num] == '/' || OOKLOAIEBME[num] == '\\')
			{
				if (num == OOKLOAIEBME.Length - 1)
				{
					return string.Empty;
				}
				return BHAOJKHGLDM(OOKLOAIEBME.Substring(num + 1));
			}
			num--;
		}
		return BHAOJKHGLDM(OOKLOAIEBME);
	}

	public static string HILMDGCMOHG(string OOKLOAIEBME, int FCGCJHHFBNP)
	{
		if (FCGCJHHFBNP < 0)
		{
			return OOKLOAIEBME;
		}
		char[] array = new char[8];
		array[1] = 'U';
		array[1] = 'ﾱ';
		string[] array2 = OOKLOAIEBME.Split(array);
		if (FCGCJHHFBNP < array2.Length)
		{
			return array2[FCGCJHHFBNP];
		}
		return string.Empty;
	}

	public static string NFPOIKLJJCM(string OOKLOAIEBME)
	{
		int num = OOKLOAIEBME.Length - 1;
		while (0 <= num)
		{
			if (OOKLOAIEBME[num] == '/' || OOKLOAIEBME[num] == '\\')
			{
				return OOKLOAIEBME.Substring(0, num);
			}
			num--;
		}
		return string.Empty;
	}
}
