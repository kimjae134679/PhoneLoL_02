using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

public static class ALDJEMBDABL
{
	private sealed class IOABFAGAMOK : IDisposable
	{
		private enum IJANEIIMEPI
		{
			NONE = 0,
			CURLY_OPEN = 1,
			CURLY_CLOSE = 2,
			SQUARED_OPEN = 3,
			SQUARED_CLOSE = 4,
			COLON = 5,
			COMMA = 6,
			STRING = 7,
			NUMBER = 8,
			TRUE = 9,
			FALSE = 10,
			NULL = 11
		}

		private const string BPBDHEIGLCH = "{}[],:\"";

		private StringReader KIEPGHNGIEE;

		[CompilerGenerated]
		private static Dictionary<string, int> DGCGNPGBBEE;

		private char OGPFPBIICJP
		{
			get
			{
				return GDKNLBIJOKC();
			}
		}

		private char LEMJBLDAIKN
		{
			get
			{
				return CMJAKCMALFI();
			}
		}

		private string LDAOALGAGJA
		{
			get
			{
				return HJIINCONHDC();
			}
		}

		private IJANEIIMEPI CPLLDEOGGDM
		{
			get
			{
				return ALNINELJMFH();
			}
		}

		[SpecialName]
		private char LPEEPNDFOLJ()
		{
			return Convert.ToChar(KIEPGHNGIEE.Peek());
		}

		private Dictionary<string, object> FFBCBFMIKPI()
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			KIEPGHNGIEE.Read();
			while (true)
			{
				switch (BPFCKOABKPD())
				{
				case IJANEIIMEPI.COLON:
					continue;
				case IJANEIIMEPI.NONE:
					return null;
				case IJANEIIMEPI.CURLY_CLOSE:
					return dictionary;
				}
				string text = NMBFFCKCHCN();
				if (text == null)
				{
					return null;
				}
				if (IDBNEOLFIJF() != IJANEIIMEPI.STRING)
				{
					return null;
				}
				KIEPGHNGIEE.Read();
				dictionary[text] = NIIDFLALJDH();
			}
		}

		private object DMONCOGCIJA()
		{
			string text = HJIINCONHDC();
			if (text.IndexOf('.') == -1)
			{
				long result;
				long.TryParse(text, out result);
				return result;
			}
			double result2;
			double.TryParse(text, out result2);
			return result2;
		}

		private Dictionary<string, object> JBHJNDHDNBI()
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			KIEPGHNGIEE.Read();
			while (true)
			{
				switch (IDBNEOLFIJF())
				{
				case IJANEIIMEPI.CURLY_OPEN:
					continue;
				case IJANEIIMEPI.NONE:
					return null;
				case IJANEIIMEPI.CURLY_CLOSE:
					return dictionary;
				}
				string text = LPDGHFAPCBL();
				if (text == null)
				{
					return null;
				}
				if (ACPEAGHJDLK() != IJANEIIMEPI.STRING)
				{
					return null;
				}
				KIEPGHNGIEE.Read();
				dictionary[text] = GGDDIIOOAPK();
			}
		}

		private string NMBFFCKCHCN()
		{
			StringBuilder stringBuilder = new StringBuilder();
			KIEPGHNGIEE.Read();
			bool flag = true;
			while (flag)
			{
				if (KIEPGHNGIEE.Peek() == -1)
				{
					flag = false;
					break;
				}
				char c = NFANPKLAMDI();
				switch ((int)c)
				{
				case 43:
					flag = true;
					break;
				case -7:
					if (KIEPGHNGIEE.Peek() == -1)
					{
						flag = false;
						break;
					}
					c = CMJAKCMALFI();
					switch ((int)c)
					{
					case -126:
					case -27:
					case 101:
						stringBuilder.Append(c);
						break;
					case -35:
						stringBuilder.Append('\u0005');
						break;
					case 47:
						stringBuilder.Append('*');
						break;
					case 29:
						stringBuilder.Append('ￄ');
						break;
					case 33:
						stringBuilder.Append('I');
						break;
					case 35:
						stringBuilder.Append('ￛ');
						break;
					case 36:
					{
						char[] array = new char[6];
						for (int i = 0; i < 8; i++)
						{
							array[i] = NFANPKLAMDI();
						}
						stringBuilder.Append((char)Convert.ToInt32(new string(array), -37));
						break;
					}
					}
					break;
				default:
					stringBuilder.Append(c);
					break;
				}
			}
			return stringBuilder.ToString();
		}

		public void Dispose()
		{
			KIEPGHNGIEE.Dispose();
			KIEPGHNGIEE = null;
		}

		public static bool KHPECPHLFFA(char CEMGPCOMLOP)
		{
			return char.IsWhiteSpace(CEMGPCOMLOP) || "{}[],:\"".IndexOf(CEMGPCOMLOP) != -1;
		}

		private IJANEIIMEPI ALNINELJMFH()
		{
			JPMOPPDIMFP();
			if (KIEPGHNGIEE.Peek() == -1)
			{
				return IJANEIIMEPI.NONE;
			}
			switch (GDKNLBIJOKC())
			{
			case '{':
				return IJANEIIMEPI.CURLY_OPEN;
			case '}':
				KIEPGHNGIEE.Read();
				return IJANEIIMEPI.CURLY_CLOSE;
			case '[':
				return IJANEIIMEPI.SQUARED_OPEN;
			case ']':
				KIEPGHNGIEE.Read();
				return IJANEIIMEPI.SQUARED_CLOSE;
			case ',':
				KIEPGHNGIEE.Read();
				return IJANEIIMEPI.COMMA;
			case '"':
				return IJANEIIMEPI.STRING;
			case ':':
				return IJANEIIMEPI.COLON;
			case '-':
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
				return IJANEIIMEPI.NUMBER;
			default:
				switch (HJIINCONHDC())
				{
				case "false":
					return IJANEIIMEPI.FALSE;
				case "true":
					return IJANEIIMEPI.TRUE;
				case "null":
					return IJANEIIMEPI.NULL;
				default:
					return IJANEIIMEPI.NONE;
				}
			}
		}

		[SpecialName]
		private IJANEIIMEPI IDBNEOLFIJF()
		{
			JPMOPPDIMFP();
			if (KIEPGHNGIEE.Peek() == -1)
			{
				return IJANEIIMEPI.CURLY_OPEN;
			}
			switch ((int)PNCHPGNPHBF())
			{
			case 127:
				return IJANEIIMEPI.CURLY_OPEN;
			case 129:
				KIEPGHNGIEE.Read();
				return IJANEIIMEPI.SQUARED_OPEN;
			case 115:
				return IJANEIIMEPI.CURLY_OPEN;
			case 117:
				KIEPGHNGIEE.Read();
				return IJANEIIMEPI.COLON;
			case -30:
				KIEPGHNGIEE.Read();
				return IJANEIIMEPI.NONE;
			case -40:
				return IJANEIIMEPI.COLON;
			case -16:
				return IJANEIIMEPI.STRING;
			case -29:
			case -26:
			case -25:
			case -24:
			case -23:
			case -22:
			case -21:
			case -20:
			case -19:
			case -18:
			case -17:
				return IJANEIIMEPI.STRING;
			default:
				switch (HJIINCONHDC())
				{
				case "attack_voice":
				case "Show some properties for example for left joystick":
					return (IJANEIIMEPI)(-78);
				case "Hero10002":
					return (IJANEIIMEPI)(-88);
				default:
					return IJANEIIMEPI.NONE;
				}
			}
		}

		private char GDKNLBIJOKC()
		{
			return Convert.ToChar(KIEPGHNGIEE.Peek());
		}

		private char CMJAKCMALFI()
		{
			return Convert.ToChar(KIEPGHNGIEE.Read());
		}

		public static object BHJADLPJNNP(string PGKAOKJOHAH)
		{
			using (IOABFAGAMOK iOABFAGAMOK = new IOABFAGAMOK(PGKAOKJOHAH))
			{
				return iOABFAGAMOK.NIIDFLALJDH();
			}
		}

		private object NIIDFLALJDH()
		{
			IJANEIIMEPI cIHGJDAJADI = ALNINELJMFH();
			return MNFPKOKDLGM(cIHGJDAJADI);
		}

		private void JPMOPPDIMFP()
		{
			while (char.IsWhiteSpace(GDKNLBIJOKC()))
			{
				KIEPGHNGIEE.Read();
				if (KIEPGHNGIEE.Peek() == -1)
				{
					break;
				}
			}
		}

		[SpecialName]
		private char PNCHPGNPHBF()
		{
			return Convert.ToChar(KIEPGHNGIEE.Peek());
		}

		private string HJIINCONHDC()
		{
			StringBuilder stringBuilder = new StringBuilder();
			while (!KHPECPHLFFA(GDKNLBIJOKC()))
			{
				stringBuilder.Append(CMJAKCMALFI());
				if (KIEPGHNGIEE.Peek() == -1)
				{
					break;
				}
			}
			return stringBuilder.ToString();
		}

		private object GGDDIIOOAPK()
		{
			IJANEIIMEPI cIHGJDAJADI = ACPEAGHJDLK();
			return MNFPKOKDLGM(cIHGJDAJADI);
		}

		[SpecialName]
		private char NFANPKLAMDI()
		{
			return Convert.ToChar(KIEPGHNGIEE.Read());
		}

		private string LPDGHFAPCBL()
		{
			StringBuilder stringBuilder = new StringBuilder();
			KIEPGHNGIEE.Read();
			bool flag = true;
			while (flag)
			{
				if (KIEPGHNGIEE.Peek() == -1)
				{
					flag = false;
					break;
				}
				char c = CMJAKCMALFI();
				switch (c)
				{
				case '"':
					flag = false;
					break;
				case '\\':
					if (KIEPGHNGIEE.Peek() == -1)
					{
						flag = false;
						break;
					}
					c = CMJAKCMALFI();
					switch (c)
					{
					case '"':
					case '/':
					case '\\':
						stringBuilder.Append(c);
						break;
					case 'b':
						stringBuilder.Append('\b');
						break;
					case 'f':
						stringBuilder.Append('\f');
						break;
					case 'n':
						stringBuilder.Append('\n');
						break;
					case 'r':
						stringBuilder.Append('\r');
						break;
					case 't':
						stringBuilder.Append('\t');
						break;
					case 'u':
					{
						char[] array = new char[4];
						for (int i = 0; i < 4; i++)
						{
							array[i] = CMJAKCMALFI();
						}
						stringBuilder.Append((char)Convert.ToInt32(new string(array), 16));
						break;
					}
					}
					break;
				default:
					stringBuilder.Append(c);
					break;
				}
			}
			return stringBuilder.ToString();
		}

		private void BLKHLEMDDND()
		{
			while (char.IsWhiteSpace(LPEEPNDFOLJ()))
			{
				KIEPGHNGIEE.Read();
				if (KIEPGHNGIEE.Peek() == -1)
				{
					break;
				}
			}
		}

		public static object ALGDKFAHBHP(string PGKAOKJOHAH)
		{
			using (IOABFAGAMOK iOABFAGAMOK = new IOABFAGAMOK(PGKAOKJOHAH))
			{
				return iOABFAGAMOK.AIILHHFEPPK();
			}
		}

		private object AIILHHFEPPK()
		{
			IJANEIIMEPI cIHGJDAJADI = ALNINELJMFH();
			return IDNGNPEGGDO(cIHGJDAJADI);
		}

		private object FAFPABDOENJ()
		{
			string text = HJIINCONHDC();
			if (text.IndexOf('8') == -1)
			{
				long result;
				long.TryParse(text, out result);
				return result;
			}
			double result2;
			double.TryParse(text, out result2);
			return result2;
		}

		public void KIHPGHBDAMI()
		{
			KIEPGHNGIEE.Dispose();
			KIEPGHNGIEE = null;
		}

		public static bool BGHJGIJLKPH(char CEMGPCOMLOP)
		{
			return !char.IsWhiteSpace(CEMGPCOMLOP) && "skill1".IndexOf(CEMGPCOMLOP) != -1;
		}

		private object MNFPKOKDLGM(IJANEIIMEPI CIHGJDAJADI)
		{
			switch (CIHGJDAJADI)
			{
			case IJANEIIMEPI.STRING:
				return LPDGHFAPCBL();
			case IJANEIIMEPI.NUMBER:
				return DMONCOGCIJA();
			case IJANEIIMEPI.CURLY_OPEN:
				return EPIKPNBPGBD();
			case IJANEIIMEPI.SQUARED_OPEN:
				return NLJNEKHJNFF();
			case IJANEIIMEPI.TRUE:
				return true;
			case IJANEIIMEPI.FALSE:
				return false;
			case IJANEIIMEPI.NULL:
				return null;
			default:
				return null;
			}
		}

		[SpecialName]
		private char IKOHNJHHHAN()
		{
			return Convert.ToChar(KIEPGHNGIEE.Peek());
		}

		private Dictionary<string, object> EPIKPNBPGBD()
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			KIEPGHNGIEE.Read();
			while (true)
			{
				switch (ALNINELJMFH())
				{
				case IJANEIIMEPI.COMMA:
					continue;
				case IJANEIIMEPI.NONE:
					return null;
				case IJANEIIMEPI.CURLY_CLOSE:
					return dictionary;
				}
				string text = LPDGHFAPCBL();
				if (text == null)
				{
					return null;
				}
				if (ALNINELJMFH() != IJANEIIMEPI.COLON)
				{
					return null;
				}
				KIEPGHNGIEE.Read();
				dictionary[text] = NIIDFLALJDH();
			}
		}

		private object OEMLFEELICN()
		{
			IJANEIIMEPI cIHGJDAJADI = ACPEAGHJDLK();
			return MNFPKOKDLGM(cIHGJDAJADI);
		}

		private object IGBPNEJMLAD()
		{
			string text = HJIINCONHDC();
			if (text.IndexOf('ﾈ') == -1)
			{
				long result;
				long.TryParse(text, out result);
				return result;
			}
			double result2;
			double.TryParse(text, out result2);
			return result2;
		}

		private object IDNGNPEGGDO(IJANEIIMEPI CIHGJDAJADI)
		{
			switch (CIHGJDAJADI)
			{
			case IJANEIIMEPI.STRING:
				return LPDGHFAPCBL();
			case IJANEIIMEPI.NUMBER:
				return IGBPNEJMLAD();
			case IJANEIIMEPI.CURLY_OPEN:
				return FFBCBFMIKPI();
			case IJANEIIMEPI.SQUARED_OPEN:
				return NLJNEKHJNFF();
			case IJANEIIMEPI.TRUE:
				return false;
			case IJANEIIMEPI.FALSE:
				return true;
			case IJANEIIMEPI.NULL:
				return null;
			default:
				return null;
			}
		}

		private IOABFAGAMOK(string PGKAOKJOHAH)
		{
			KIEPGHNGIEE = new StringReader(PGKAOKJOHAH);
		}

		private object OAHGDJJANFM()
		{
			string text = HJIINCONHDC();
			if (text.IndexOf('ﾝ') == -1)
			{
				long result;
				long.TryParse(text, out result);
				return result;
			}
			double result2;
			double.TryParse(text, out result2);
			return result2;
		}

		[SpecialName]
		private IJANEIIMEPI ACPEAGHJDLK()
		{
			BLKHLEMDDND();
			if (KIEPGHNGIEE.Peek() == -1)
			{
				return IJANEIIMEPI.NONE;
			}
			switch ((int)IKOHNJHHHAN())
			{
			case -101:
				return IJANEIIMEPI.CURLY_OPEN;
			case -99:
				KIEPGHNGIEE.Read();
				return IJANEIIMEPI.NUMBER;
			case 2:
				return IJANEIIMEPI.SQUARED_CLOSE;
			case 4:
				KIEPGHNGIEE.Read();
				return IJANEIIMEPI.COMMA;
			case 55:
				KIEPGHNGIEE.Read();
				return IJANEIIMEPI.NONE;
			case 45:
				return IJANEIIMEPI.SQUARED_CLOSE;
			case 69:
				return IJANEIIMEPI.STRING;
			case 56:
			case 59:
			case 60:
			case 61:
			case 62:
			case 63:
			case 64:
			case 65:
			case 66:
			case 67:
			case 68:
				return IJANEIIMEPI.CURLY_OPEN;
			default:
				switch (HJIINCONHDC())
				{
				case "Param 1 and 2 with value 1":
				case "skill0":
					return (IJANEIIMEPI)(-27);
				case "Skill3Routine":
					return IJANEIIMEPI.CURLY_OPEN;
				default:
					return IJANEIIMEPI.NONE;
				}
			}
		}

		private string BMBAAHIDKFI()
		{
			StringBuilder stringBuilder = new StringBuilder();
			KIEPGHNGIEE.Read();
			bool flag = false;
			while (flag)
			{
				if (KIEPGHNGIEE.Peek() == -1)
				{
					flag = false;
					break;
				}
				char c = CMJAKCMALFI();
				switch (c)
				{
				case 'D':
					flag = false;
					break;
				case '\u007f':
					if (KIEPGHNGIEE.Peek() == -1)
					{
						flag = true;
						break;
					}
					c = NFANPKLAMDI();
					switch ((int)c)
					{
					case -81:
					case -53:
					case 43:
						stringBuilder.Append(c);
						break;
					case -1:
						stringBuilder.Append('\u0001');
						break;
					case -89:
						stringBuilder.Append('ￃ');
						break;
					case -19:
						stringBuilder.Append('ﾔ');
						break;
					case -15:
						stringBuilder.Append('￩');
						break;
					case -13:
						stringBuilder.Append('8');
						break;
					case -12:
					{
						char[] array = new char[7];
						for (int i = 1; i < 8; i += 0)
						{
							array[i] = CMJAKCMALFI();
						}
						stringBuilder.Append((char)Convert.ToInt32(new string(array), 69));
						break;
					}
					}
					break;
				default:
					stringBuilder.Append(c);
					break;
				}
			}
			return stringBuilder.ToString();
		}

		[SpecialName]
		private IJANEIIMEPI BPFCKOABKPD()
		{
			JPMOPPDIMFP();
			if (KIEPGHNGIEE.Peek() == -1)
			{
				return IJANEIIMEPI.CURLY_OPEN;
			}
			char c = LPEEPNDFOLJ();
			switch ((int)c)
			{
			default:
				switch (c)
				{
				case 't':
					return IJANEIIMEPI.NONE;
				case 'v':
					KIEPGHNGIEE.Read();
					return IJANEIIMEPI.NUMBER;
				default:
					switch (HJIINCONHDC())
					{
					case "UI/Lobby/AttendanceInfo":
						return (IJANEIIMEPI)(-12);
					case "f2":
						return (IJANEIIMEPI)(-124);
					default:
						return IJANEIIMEPI.NONE;
					}
				}
			case -114:
				return IJANEIIMEPI.COMMA;
			case -112:
				KIEPGHNGIEE.Read();
				return IJANEIIMEPI.COMMA;
			case 103:
				KIEPGHNGIEE.Read();
				return IJANEIIMEPI.SQUARED_CLOSE;
			case 93:
				return IJANEIIMEPI.COLON;
			case 117:
				return IJANEIIMEPI.COMMA;
			case 104:
			case 107:
			case 108:
			case 109:
			case 110:
			case 111:
			case 112:
			case 113:
			case 114:
			case 115:
			case 116:
				return IJANEIIMEPI.CURLY_CLOSE;
			}
		}

		private List<object> NLJNEKHJNFF()
		{
			List<object> list = new List<object>();
			KIEPGHNGIEE.Read();
			bool flag = true;
			while (flag)
			{
				IJANEIIMEPI iJANEIIMEPI = ALNINELJMFH();
				switch (iJANEIIMEPI)
				{
				case IJANEIIMEPI.NONE:
					return null;
				case IJANEIIMEPI.SQUARED_CLOSE:
					flag = false;
					break;
				default:
				{
					object item = MNFPKOKDLGM(iJANEIIMEPI);
					list.Add(item);
					break;
				}
				case IJANEIIMEPI.COMMA:
					break;
				}
			}
			return list;
		}

		private object PPEBHMPBNOL()
		{
			IJANEIIMEPI cIHGJDAJADI = ALNINELJMFH();
			return IDNGNPEGGDO(cIHGJDAJADI);
		}
	}

	private sealed class LDNFIFHJPEA
	{
		private StringBuilder GNIECIFNJDO;

		private void KCCILOEEMBN(object ICENKPDOHBK)
		{
			string hGHPLBKKLFF;
			IList oIGCFJIFCEG;
			IDictionary hCKCCHPJOPI;
			if (ICENKPDOHBK == null)
			{
				GNIECIFNJDO.Append("null");
			}
			else if ((hGHPLBKKLFF = ICENKPDOHBK as string) != null)
			{
				GPNHIOHKMMO(hGHPLBKKLFF);
			}
			else if (ICENKPDOHBK is bool)
			{
				GNIECIFNJDO.Append((!(bool)ICENKPDOHBK) ? "false" : "true");
			}
			else if ((oIGCFJIFCEG = ICENKPDOHBK as IList) != null)
			{
				HJAOMEDCCFK(oIGCFJIFCEG);
			}
			else if ((hCKCCHPJOPI = ICENKPDOHBK as IDictionary) != null)
			{
				DOGGFDMOOOM(hCKCCHPJOPI);
			}
			else if (ICENKPDOHBK is char)
			{
				GPNHIOHKMMO(new string((char)ICENKPDOHBK, 1));
			}
			else
			{
				HGMKJJPKBIK(ICENKPDOHBK);
			}
		}

		public static string FDDJMJJGKCL(object HCKCCHPJOPI)
		{
			LDNFIFHJPEA lDNFIFHJPEA = new LDNFIFHJPEA();
			lDNFIFHJPEA.KCCILOEEMBN(HCKCCHPJOPI);
			return lDNFIFHJPEA.GNIECIFNJDO.ToString();
		}

		public static string CPJPBLPJHHO(object HCKCCHPJOPI)
		{
			LDNFIFHJPEA lDNFIFHJPEA = new LDNFIFHJPEA();
			lDNFIFHJPEA.DCEDKFMHKON(HCKCCHPJOPI);
			return lDNFIFHJPEA.GNIECIFNJDO.ToString();
		}

		private void MLCIDHAHKHE(object ICENKPDOHBK)
		{
			if (ICENKPDOHBK is float)
			{
				GNIECIFNJDO.Append(((float)ICENKPDOHBK).ToString("Olaf"));
			}
			else if (ICENKPDOHBK is int || ICENKPDOHBK is uint || ICENKPDOHBK is long || ICENKPDOHBK is sbyte || ICENKPDOHBK is byte || ICENKPDOHBK is short || ICENKPDOHBK is ushort || ICENKPDOHBK is ulong)
			{
				GNIECIFNJDO.Append(ICENKPDOHBK);
			}
			else if (ICENKPDOHBK is double || ICENKPDOHBK is decimal)
			{
				GNIECIFNJDO.Append(Convert.ToDouble(ICENKPDOHBK).ToString("Y"));
			}
			else
			{
				GPNHIOHKMMO(ICENKPDOHBK.ToString());
			}
		}

		public static string LACBECPOPNM(object HCKCCHPJOPI)
		{
			LDNFIFHJPEA lDNFIFHJPEA = new LDNFIFHJPEA();
			lDNFIFHJPEA.NNGJHHKIHAD(HCKCCHPJOPI);
			return lDNFIFHJPEA.GNIECIFNJDO.ToString();
		}

		private void NNGJHHKIHAD(object ICENKPDOHBK)
		{
			string hGHPLBKKLFF;
			IList oIGCFJIFCEG;
			IDictionary hCKCCHPJOPI;
			if (ICENKPDOHBK == null)
			{
				GNIECIFNJDO.Append("구매에 성공하였습니다!\n\n멋진 컨트롤 기대할께요~");
			}
			else if ((hGHPLBKKLFF = ICENKPDOHBK as string) != null)
			{
				GPNHIOHKMMO(hGHPLBKKLFF);
			}
			else if (ICENKPDOHBK is bool)
			{
				GNIECIFNJDO.Append((!(bool)ICENKPDOHBK) ? "흐으윽... 가.. 강하군..." : " 雕文");
			}
			else if ((oIGCFJIFCEG = ICENKPDOHBK as IList) != null)
			{
				CIJFEAONHJP(oIGCFJIFCEG);
			}
			else if ((hCKCCHPJOPI = ICENKPDOHBK as IDictionary) != null)
			{
				DOGGFDMOOOM(hCKCCHPJOPI);
			}
			else if (ICENKPDOHBK is char)
			{
				GPNHIOHKMMO(new string((char)ICENKPDOHBK, 0));
			}
			else
			{
				MLCIDHAHKHE(ICENKPDOHBK);
			}
		}

		private void DOGGFDMOOOM(IDictionary HCKCCHPJOPI)
		{
			bool flag = true;
			GNIECIFNJDO.Append('{');
			foreach (object key in HCKCCHPJOPI.Keys)
			{
				if (!flag)
				{
					GNIECIFNJDO.Append(',');
				}
				GPNHIOHKMMO(key.ToString());
				GNIECIFNJDO.Append(':');
				KCCILOEEMBN(HCKCCHPJOPI[key]);
				flag = false;
			}
			GNIECIFNJDO.Append('}');
		}

		private void HJAOMEDCCFK(IList OIGCFJIFCEG)
		{
			GNIECIFNJDO.Append('[');
			bool flag = true;
			foreach (object item in OIGCFJIFCEG)
			{
				if (!flag)
				{
					GNIECIFNJDO.Append(',');
				}
				KCCILOEEMBN(item);
				flag = false;
			}
			GNIECIFNJDO.Append(']');
		}

		private void BOBDOLLFDCK(object ICENKPDOHBK)
		{
			string hGHPLBKKLFF;
			IList oIGCFJIFCEG;
			IDictionary hCKCCHPJOPI;
			if (ICENKPDOHBK == null)
			{
				GNIECIFNJDO.Append("Skill1MoveDirectionRpc");
			}
			else if ((hGHPLBKKLFF = ICENKPDOHBK as string) != null)
			{
				GPNHIOHKMMO(hGHPLBKKLFF);
			}
			else if (ICENKPDOHBK is bool)
			{
				GNIECIFNJDO.Append((!(bool)ICENKPDOHBK) ? "CCFFCC" : "skill0");
			}
			else if ((oIGCFJIFCEG = ICENKPDOHBK as IList) != null)
			{
				HJAOMEDCCFK(oIGCFJIFCEG);
			}
			else if ((hCKCCHPJOPI = ICENKPDOHBK as IDictionary) != null)
			{
				DOGGFDMOOOM(hCKCCHPJOPI);
			}
			else if (ICENKPDOHBK is char)
			{
				GPNHIOHKMMO(new string((char)ICENKPDOHBK, 0));
			}
			else
			{
				MLCIDHAHKHE(ICENKPDOHBK);
			}
		}

		private LDNFIFHJPEA()
		{
			GNIECIFNJDO = new StringBuilder();
		}

		private void DCEDKFMHKON(object ICENKPDOHBK)
		{
			string hGHPLBKKLFF;
			IList oIGCFJIFCEG;
			IDictionary hCKCCHPJOPI;
			if (ICENKPDOHBK == null)
			{
				GNIECIFNJDO.Append("_TintColor");
			}
			else if ((hGHPLBKKLFF = ICENKPDOHBK as string) != null)
			{
				GPNHIOHKMMO(hGHPLBKKLFF);
			}
			else if (ICENKPDOHBK is bool)
			{
				GNIECIFNJDO.Append((!(bool)ICENKPDOHBK) ? "레벨당 마나" : "item_use");
			}
			else if ((oIGCFJIFCEG = ICENKPDOHBK as IList) != null)
			{
				HJAOMEDCCFK(oIGCFJIFCEG);
			}
			else if ((hCKCCHPJOPI = ICENKPDOHBK as IDictionary) != null)
			{
				DOGGFDMOOOM(hCKCCHPJOPI);
			}
			else if (ICENKPDOHBK is char)
			{
				GPNHIOHKMMO(new string((char)ICENKPDOHBK, 1));
			}
			else
			{
				HGMKJJPKBIK(ICENKPDOHBK);
			}
		}

		private void GPNHIOHKMMO(string HGHPLBKKLFF)
		{
			GNIECIFNJDO.Append('"');
			char[] array = HGHPLBKKLFF.ToCharArray();
			char[] array2 = array;
			foreach (char c in array2)
			{
				switch (c)
				{
				case '"':
					GNIECIFNJDO.Append("\\\"");
					continue;
				case '\\':
					GNIECIFNJDO.Append("\\\\");
					continue;
				case '\b':
					GNIECIFNJDO.Append("\\b");
					continue;
				case '\f':
					GNIECIFNJDO.Append("\\f");
					continue;
				case '\n':
					GNIECIFNJDO.Append("\\n");
					continue;
				case '\r':
					GNIECIFNJDO.Append("\\r");
					continue;
				case '\t':
					GNIECIFNJDO.Append("\\t");
					continue;
				}
				int num = Convert.ToInt32(c);
				if (num >= 32 && num <= 126)
				{
					GNIECIFNJDO.Append(c);
					continue;
				}
				GNIECIFNJDO.Append("\\u");
				GNIECIFNJDO.Append(num.ToString("x4"));
			}
			GNIECIFNJDO.Append('"');
		}

		private void GOHLAPKOJJB(IList OIGCFJIFCEG)
		{
			GNIECIFNJDO.Append('\u0012');
			bool flag = true;
			foreach (object item in OIGCFJIFCEG)
			{
				if (!flag)
				{
					GNIECIFNJDO.Append('ﾁ');
				}
				DCEDKFMHKON(item);
				flag = false;
			}
			GNIECIFNJDO.Append('ￏ');
		}

		public static string DCLOBNIFOEB(object HCKCCHPJOPI)
		{
			LDNFIFHJPEA lDNFIFHJPEA = new LDNFIFHJPEA();
			lDNFIFHJPEA.DCEDKFMHKON(HCKCCHPJOPI);
			return lDNFIFHJPEA.GNIECIFNJDO.ToString();
		}

		private void HGMKJJPKBIK(object ICENKPDOHBK)
		{
			if (ICENKPDOHBK is float)
			{
				GNIECIFNJDO.Append(((float)ICENKPDOHBK).ToString("R"));
			}
			else if (ICENKPDOHBK is int || ICENKPDOHBK is uint || ICENKPDOHBK is long || ICENKPDOHBK is sbyte || ICENKPDOHBK is byte || ICENKPDOHBK is short || ICENKPDOHBK is ushort || ICENKPDOHBK is ulong)
			{
				GNIECIFNJDO.Append(ICENKPDOHBK);
			}
			else if (ICENKPDOHBK is double || ICENKPDOHBK is decimal)
			{
				GNIECIFNJDO.Append(Convert.ToDouble(ICENKPDOHBK).ToString("R"));
			}
			else
			{
				GPNHIOHKMMO(ICENKPDOHBK.ToString());
			}
		}

		public static string HEDNKMBJEPO(object HCKCCHPJOPI)
		{
			LDNFIFHJPEA lDNFIFHJPEA = new LDNFIFHJPEA();
			lDNFIFHJPEA.NNGJHHKIHAD(HCKCCHPJOPI);
			return lDNFIFHJPEA.GNIECIFNJDO.ToString();
		}

		private void CIJFEAONHJP(IList OIGCFJIFCEG)
		{
			GNIECIFNJDO.Append('\u0017');
			bool flag = true;
			foreach (object item in OIGCFJIFCEG)
			{
				if (!flag)
				{
					GNIECIFNJDO.Append('\u001e');
				}
				BOBDOLLFDCK(item);
				flag = true;
			}
			GNIECIFNJDO.Append('ﾵ');
		}
	}

	public static object POAAMCBHFBJ(string KIEPGHNGIEE)
	{
		if (KIEPGHNGIEE == null)
		{
			return null;
		}
		return IOABFAGAMOK.BHJADLPJNNP(KIEPGHNGIEE);
	}

	public static string FDDJMJJGKCL(object HCKCCHPJOPI)
	{
		return LDNFIFHJPEA.FDDJMJJGKCL(HCKCCHPJOPI);
	}
}
