using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

public static class MGDLEEIDDII
{
	public enum NBEGJBKHJLH
	{
		Automatic = 0,
		Left = 1,
		Center = 2,
		Right = 3,
		Justified = 4
	}

	public enum OOGEENANIAD
	{
		None = 0,
		Normal = 1,
		Colored = 2
	}

	public class HNMKLCNAJKP
	{
		public Vector2 GKBGMNLKFMK;

		public Vector2 MEMCHGBOBMC;

		public Vector2 NEIEGGLBIEF;

		public Vector2 PFLGILEHKCJ;

		public float EBOEDCPKDAB;

		public int KCPGFCKMAPI;

		public bool CFGOMDEHGAC;
	}

	public static UIFont BOLNHAFHHLH;

	public static Font AFADEAFMPPG;

	public static HNMKLCNAJKP AFCAIJOEGCH = new HNMKLCNAJKP();

	public static int DIDGACJBIGL = 16;

	public static float OEFOGDBMFFN = 1f;

	public static float EGMANIMPOJD = 1f;

	public static FontStyle LAMAEKKHDLJ = FontStyle.Normal;

	public static NBEGJBKHJLH JGHJBDJBMNF = NBEGJBKHJLH.Left;

	public static Color EHGLADDANIC = Color.white;

	public static int IDNLBBKJDAH = 1000000;

	public static int JNPNECNIPBM = 1000000;

	public static int EGBDNLHOLPE = 0;

	public static bool HIFLOBIANFE = false;

	public static Color BHIBCMKMAHH = Color.white;

	public static Color EDDGAHPMAHL = Color.white;

	public static bool EAGEFFBJIKH = false;

	public static float JLBLOKCFICG = 0f;

	public static float HIANFGDCCFG = 0f;

	public static bool GBBLFPAEBKG = false;

	public static OOGEENANIAD GGLDLMGHBIK;

	public static int PDEIFLEEEOL = 0;

	public static float BJBMDDIGANL = 0f;

	public static float FDIDNKHIBHG = 0f;

	public static float PEIDGBOOMJE = 0f;

	public static bool EGBDMGOBCBG = false;

	private static Color LNLEFKMCGBC = new Color(0f, 0f, 0f, 0f);

	private static global::MABNNPIGEPM<Color> PDGKKAMJLHO = new global::MABNNPIGEPM<Color>();

	private static float HHABLPHFEDL = 1f;

	private static CharacterInfo IMONDCKPNHJ;

	private static global::MABNNPIGEPM<float> LFHDDLCPHFP = new global::MABNNPIGEPM<float>();

	private static Color32 DBBFEFEEJIB;

	private static Color32 IHKFNOIPAOP;

	private static float[] EOGOIDLFOCB = new float[8] { -0.5f, 0f, 0.5f, 0f, 0f, -0.5f, 0f, 0.5f };

	[CompilerGenerated]
	private static Dictionary<string, int> LAGJJJDFBKB;

	[CompilerGenerated]
	private static Dictionary<string, int> LFOCJOMAIHD;

	[CompilerGenerated]
	private static Dictionary<string, int> GCKPGDGCMMJ;

	[CompilerGenerated]
	private static Dictionary<string, int> MFCGFJNFLFH;

	public static void LPBLGFCPADD()
	{
		LPBLGFCPADD(true);
	}

	public static void LPBLGFCPADD(bool LIHBPPGGOJH)
	{
		PDEIFLEEEOL = Mathf.RoundToInt((float)DIDGACJBIGL / EGMANIMPOJD);
		BJBMDDIGANL = JLBLOKCFICG * OEFOGDBMFFN;
		FDIDNKHIBHG = ((float)DIDGACJBIGL + HIANFGDCCFG) * OEFOGDBMFFN;
		EGBDMGOBCBG = BOLNHAFHHLH != null && BOLNHAFHHLH.get_hasSymbols() && EAGEFFBJIKH && GGLDLMGHBIK != OOGEENANIAD.None;
		if (!(AFADEAFMPPG != null) || !LIHBPPGGOJH)
		{
			return;
		}
		AFADEAFMPPG.RequestCharactersInTexture(")_-", PDEIFLEEEOL, LAMAEKKHDLJ);
		if (!AFADEAFMPPG.GetCharacterInfo(')', out IMONDCKPNHJ, PDEIFLEEEOL, LAMAEKKHDLJ))
		{
			AFADEAFMPPG.RequestCharactersInTexture("A", PDEIFLEEEOL, LAMAEKKHDLJ);
			if (!AFADEAFMPPG.GetCharacterInfo('A', out IMONDCKPNHJ, PDEIFLEEEOL, LAMAEKKHDLJ))
			{
				PEIDGBOOMJE = 0f;
				return;
			}
		}
		float yMax = IMONDCKPNHJ.vert.yMax;
		float yMin = IMONDCKPNHJ.vert.yMin;
		PEIDGBOOMJE = Mathf.Round(yMax + ((float)PDEIFLEEEOL - yMax + yMin) * 0.5f);
	}

	public static void OFDEHCIAHLD(string BMNKKBDCELE)
	{
		if (AFADEAFMPPG != null)
		{
			AFADEAFMPPG.RequestCharactersInTexture(BMNKKBDCELE, PDEIFLEEEOL, LAMAEKKHDLJ);
		}
	}

	public static BMSymbol EBHJAKJAHLH(string BMNKKBDCELE, int LEOCLKHBLED, int LDBGBEKBKOC)
	{
		return (!(BOLNHAFHHLH != null)) ? null : BOLNHAFHHLH.MatchSymbol(BMNKKBDCELE, LEOCLKHBLED, LDBGBEKBKOC);
	}

	public static float GAAPHMFJFOE(int JBIBLBJBBAM, int GGDGAIFKLCB)
	{
		if (BOLNHAFHHLH != null)
		{
			BMGlyph bMGlyph = BOLNHAFHHLH.get_bmFont().KHLMNHAIBFH(JBIBLBJBBAM);
			if (bMGlyph != null)
			{
				return OEFOGDBMFFN * (float)((GGDGAIFKLCB == 0) ? bMGlyph.advance : (bMGlyph.advance + bMGlyph.FHILFKOLILD(GGDGAIFKLCB)));
			}
		}
		else if (AFADEAFMPPG != null && AFADEAFMPPG.GetCharacterInfo((char)JBIBLBJBBAM, out IMONDCKPNHJ, PDEIFLEEEOL, LAMAEKKHDLJ))
		{
			return IMONDCKPNHJ.width * OEFOGDBMFFN * EGMANIMPOJD;
		}
		return 0f;
	}

	public static HNMKLCNAJKP KHLMNHAIBFH(int JBIBLBJBBAM, int GGDGAIFKLCB)
	{
		if (BOLNHAFHHLH != null)
		{
			BMGlyph bMGlyph = BOLNHAFHHLH.get_bmFont().KHLMNHAIBFH(JBIBLBJBBAM);
			if (bMGlyph != null)
			{
				int num = ((GGDGAIFKLCB != 0) ? bMGlyph.FHILFKOLILD(GGDGAIFKLCB) : 0);
				AFCAIJOEGCH.GKBGMNLKFMK.x = ((GGDGAIFKLCB == 0) ? bMGlyph.offsetX : (bMGlyph.offsetX + num));
				AFCAIJOEGCH.MEMCHGBOBMC.y = -bMGlyph.offsetY;
				AFCAIJOEGCH.MEMCHGBOBMC.x = AFCAIJOEGCH.GKBGMNLKFMK.x + (float)bMGlyph.width;
				AFCAIJOEGCH.GKBGMNLKFMK.y = AFCAIJOEGCH.MEMCHGBOBMC.y - (float)bMGlyph.height;
				AFCAIJOEGCH.NEIEGGLBIEF.x = bMGlyph.x;
				AFCAIJOEGCH.NEIEGGLBIEF.y = bMGlyph.y + bMGlyph.height;
				AFCAIJOEGCH.PFLGILEHKCJ.x = bMGlyph.x + bMGlyph.width;
				AFCAIJOEGCH.PFLGILEHKCJ.y = bMGlyph.y;
				AFCAIJOEGCH.EBOEDCPKDAB = bMGlyph.advance + num;
				AFCAIJOEGCH.KCPGFCKMAPI = bMGlyph.channel;
				AFCAIJOEGCH.CFGOMDEHGAC = false;
				if (OEFOGDBMFFN != 1f)
				{
					AFCAIJOEGCH.GKBGMNLKFMK *= OEFOGDBMFFN;
					AFCAIJOEGCH.MEMCHGBOBMC *= OEFOGDBMFFN;
					AFCAIJOEGCH.EBOEDCPKDAB *= OEFOGDBMFFN;
				}
				return AFCAIJOEGCH;
			}
		}
		else if (AFADEAFMPPG != null && AFADEAFMPPG.GetCharacterInfo((char)JBIBLBJBBAM, out IMONDCKPNHJ, PDEIFLEEEOL, LAMAEKKHDLJ))
		{
			AFCAIJOEGCH.GKBGMNLKFMK.x = IMONDCKPNHJ.vert.xMin;
			AFCAIJOEGCH.MEMCHGBOBMC.x = AFCAIJOEGCH.GKBGMNLKFMK.x + IMONDCKPNHJ.vert.width;
			AFCAIJOEGCH.GKBGMNLKFMK.y = IMONDCKPNHJ.vert.yMax - PEIDGBOOMJE;
			AFCAIJOEGCH.MEMCHGBOBMC.y = AFCAIJOEGCH.GKBGMNLKFMK.y - IMONDCKPNHJ.vert.height;
			AFCAIJOEGCH.NEIEGGLBIEF.x = IMONDCKPNHJ.uv.xMin;
			AFCAIJOEGCH.NEIEGGLBIEF.y = IMONDCKPNHJ.uv.yMin;
			AFCAIJOEGCH.PFLGILEHKCJ.x = IMONDCKPNHJ.uv.xMax;
			AFCAIJOEGCH.PFLGILEHKCJ.y = IMONDCKPNHJ.uv.yMax;
			AFCAIJOEGCH.EBOEDCPKDAB = IMONDCKPNHJ.width;
			AFCAIJOEGCH.KCPGFCKMAPI = 0;
			AFCAIJOEGCH.CFGOMDEHGAC = IMONDCKPNHJ.flipped;
			AFCAIJOEGCH.GKBGMNLKFMK.x = Mathf.Round(AFCAIJOEGCH.GKBGMNLKFMK.x);
			AFCAIJOEGCH.GKBGMNLKFMK.y = Mathf.Round(AFCAIJOEGCH.GKBGMNLKFMK.y);
			AFCAIJOEGCH.MEMCHGBOBMC.x = Mathf.Round(AFCAIJOEGCH.MEMCHGBOBMC.x);
			AFCAIJOEGCH.MEMCHGBOBMC.y = Mathf.Round(AFCAIJOEGCH.MEMCHGBOBMC.y);
			float num2 = OEFOGDBMFFN * EGMANIMPOJD;
			if (num2 != 1f)
			{
				AFCAIJOEGCH.GKBGMNLKFMK *= num2;
				AFCAIJOEGCH.MEMCHGBOBMC *= num2;
				AFCAIJOEGCH.EBOEDCPKDAB *= num2;
			}
			return AFCAIJOEGCH;
		}
		return null;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public static float NKHGJLHIFBL(string BMNKKBDCELE, int LEOCLKHBLED)
	{
		int num = (HHAINCPODGE.DCGHFDGMJGN(BMNKKBDCELE[LEOCLKHBLED + 1]) << 4) | HHAINCPODGE.DCGHFDGMJGN(BMNKKBDCELE[LEOCLKHBLED + 2]);
		return Mathf.Clamp01((float)num / 255f);
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public static Color LMBKNJGDFLG(string BMNKKBDCELE, int BFEECILPJLM)
	{
		return DFHHEKCDFGD(BMNKKBDCELE, BFEECILPJLM);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static Color DFHHEKCDFGD(string BMNKKBDCELE, int BFEECILPJLM)
	{
		int num = (HHAINCPODGE.DCGHFDGMJGN(BMNKKBDCELE[BFEECILPJLM]) << 4) | HHAINCPODGE.DCGHFDGMJGN(BMNKKBDCELE[BFEECILPJLM + 1]);
		int num2 = (HHAINCPODGE.DCGHFDGMJGN(BMNKKBDCELE[BFEECILPJLM + 2]) << 4) | HHAINCPODGE.DCGHFDGMJGN(BMNKKBDCELE[BFEECILPJLM + 3]);
		int num3 = (HHAINCPODGE.DCGHFDGMJGN(BMNKKBDCELE[BFEECILPJLM + 4]) << 4) | HHAINCPODGE.DCGHFDGMJGN(BMNKKBDCELE[BFEECILPJLM + 5]);
		float num4 = 1f / 255f;
		return new Color(num4 * (float)num, num4 * (float)num2, num4 * (float)num3);
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public static Color MMOHLLLHLLI(string BMNKKBDCELE, int BFEECILPJLM)
	{
		int num = (HHAINCPODGE.DCGHFDGMJGN(BMNKKBDCELE[BFEECILPJLM]) << 4) | HHAINCPODGE.DCGHFDGMJGN(BMNKKBDCELE[BFEECILPJLM + 1]);
		int num2 = (HHAINCPODGE.DCGHFDGMJGN(BMNKKBDCELE[BFEECILPJLM + 2]) << 4) | HHAINCPODGE.DCGHFDGMJGN(BMNKKBDCELE[BFEECILPJLM + 3]);
		int num3 = (HHAINCPODGE.DCGHFDGMJGN(BMNKKBDCELE[BFEECILPJLM + 4]) << 4) | HHAINCPODGE.DCGHFDGMJGN(BMNKKBDCELE[BFEECILPJLM + 5]);
		int num4 = (HHAINCPODGE.DCGHFDGMJGN(BMNKKBDCELE[BFEECILPJLM + 6]) << 4) | HHAINCPODGE.DCGHFDGMJGN(BMNKKBDCELE[BFEECILPJLM + 7]);
		float num5 = 1f / 255f;
		return new Color(num5 * (float)num, num5 * (float)num2, num5 * (float)num3, num5 * (float)num4);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static string CMILNJAOOCB(Color CEMGPCOMLOP)
	{
		return INJJFDNPJMD(CEMGPCOMLOP);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static string KNKGHONPADN(float IFGAPHGCLHF)
	{
		int aOKGMGEAHDH = Mathf.Clamp(Mathf.RoundToInt(IFGAPHGCLHF * 255f), 0, 255);
		return HHAINCPODGE.EMCAPPABKPJ(aOKGMGEAHDH);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static string INJJFDNPJMD(Color CEMGPCOMLOP)
	{
		int aOKGMGEAHDH = 0xFFFFFF & (HHAINCPODGE.KLHHMOMABPJ(CEMGPCOMLOP) >> 8);
		return HHAINCPODGE.LCNAAGNGCAG(aOKGMGEAHDH);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static string IGGJAFKNFNN(Color CEMGPCOMLOP)
	{
		int aOKGMGEAHDH = HHAINCPODGE.KLHHMOMABPJ(CEMGPCOMLOP);
		return HHAINCPODGE.OIPMDKJABOE(aOKGMGEAHDH);
	}

	public static bool JGBDKHJIKKB(string BMNKKBDCELE, ref int LEOCLKHBLED)
	{
		int NJGLLDGGAHP = 1;
		bool GGDCFIBLNLG = false;
		bool LIDDKOHNDBM = false;
		bool NLPNKKFEPDE = false;
		bool BMINLKMGIOC = false;
		return JGBDKHJIKKB(BMNKKBDCELE, ref LEOCLKHBLED, null, false, ref NJGLLDGGAHP, ref GGDCFIBLNLG, ref LIDDKOHNDBM, ref NLPNKKFEPDE, ref BMINLKMGIOC);
	}

	public static bool JGBDKHJIKKB(string BMNKKBDCELE, ref int LEOCLKHBLED, global::MABNNPIGEPM<Color> IKCFCNJCHFJ, bool GBBLFPAEBKG, ref int NJGLLDGGAHP, ref bool GGDCFIBLNLG, ref bool LIDDKOHNDBM, ref bool NLPNKKFEPDE, ref bool BMINLKMGIOC)
	{
		int length = BMNKKBDCELE.Length;
		if (LEOCLKHBLED + 3 > length || BMNKKBDCELE[LEOCLKHBLED] != '[')
		{
			return false;
		}
		if (BMNKKBDCELE[LEOCLKHBLED + 2] == ']')
		{
			if (BMNKKBDCELE[LEOCLKHBLED + 1] == '-')
			{
				if (IKCFCNJCHFJ != null && IKCFCNJCHFJ.POIJPKODPCK > 1)
				{
					IKCFCNJCHFJ.DAIKDPPCIJF(IKCFCNJCHFJ.POIJPKODPCK - 1);
				}
				LEOCLKHBLED += 3;
				return true;
			}
			switch (BMNKKBDCELE.Substring(LEOCLKHBLED, 3))
			{
			case "[b]":
				GGDCFIBLNLG = true;
				LEOCLKHBLED += 3;
				return true;
			case "[i]":
				LIDDKOHNDBM = true;
				LEOCLKHBLED += 3;
				return true;
			case "[u]":
				NLPNKKFEPDE = true;
				LEOCLKHBLED += 3;
				return true;
			case "[s]":
				BMINLKMGIOC = true;
				LEOCLKHBLED += 3;
				return true;
			}
		}
		if (LEOCLKHBLED + 4 > length)
		{
			return false;
		}
		if (BMNKKBDCELE[LEOCLKHBLED + 3] == ']')
		{
			switch (BMNKKBDCELE.Substring(LEOCLKHBLED, 4))
			{
			case "[/b]":
				GGDCFIBLNLG = false;
				LEOCLKHBLED += 4;
				return true;
			case "[/i]":
				LIDDKOHNDBM = false;
				LEOCLKHBLED += 4;
				return true;
			case "[/u]":
				NLPNKKFEPDE = false;
				LEOCLKHBLED += 4;
				return true;
			case "[/s]":
				BMINLKMGIOC = false;
				LEOCLKHBLED += 4;
				return true;
			default:
			{
				int num = (HHAINCPODGE.DCGHFDGMJGN(BMNKKBDCELE[LEOCLKHBLED + 1]) << 4) | HHAINCPODGE.DCGHFDGMJGN(BMNKKBDCELE[LEOCLKHBLED + 2]);
				HHABLPHFEDL = (float)num / 255f;
				LEOCLKHBLED += 4;
				return true;
			}
			}
		}
		if (LEOCLKHBLED + 5 > length)
		{
			return false;
		}
		if (BMNKKBDCELE[LEOCLKHBLED + 4] == ']')
		{
			switch (BMNKKBDCELE.Substring(LEOCLKHBLED, 5))
			{
			case "[sub]":
				NJGLLDGGAHP = 1;
				LEOCLKHBLED += 5;
				return true;
			case "[sup]":
				NJGLLDGGAHP = 2;
				LEOCLKHBLED += 5;
				return true;
			}
		}
		if (LEOCLKHBLED + 6 > length)
		{
			return false;
		}
		if (BMNKKBDCELE[LEOCLKHBLED + 5] == ']')
		{
			switch (BMNKKBDCELE.Substring(LEOCLKHBLED, 6))
			{
			case "[/sub]":
				NJGLLDGGAHP = 0;
				LEOCLKHBLED += 6;
				return true;
			case "[/sup]":
				NJGLLDGGAHP = 0;
				LEOCLKHBLED += 6;
				return true;
			case "[/url]":
				LEOCLKHBLED += 6;
				return true;
			}
		}
		if (BMNKKBDCELE[LEOCLKHBLED + 1] == 'u' && BMNKKBDCELE[LEOCLKHBLED + 2] == 'r' && BMNKKBDCELE[LEOCLKHBLED + 3] == 'l' && BMNKKBDCELE[LEOCLKHBLED + 4] == '=')
		{
			int num2 = BMNKKBDCELE.IndexOf(']', LEOCLKHBLED + 4);
			if (num2 != -1)
			{
				LEOCLKHBLED = num2 + 1;
				return true;
			}
			LEOCLKHBLED = BMNKKBDCELE.Length;
			return true;
		}
		if (LEOCLKHBLED + 8 > length)
		{
			return false;
		}
		if (BMNKKBDCELE[LEOCLKHBLED + 7] == ']')
		{
			Color color = DFHHEKCDFGD(BMNKKBDCELE, LEOCLKHBLED + 1);
			if (INJJFDNPJMD(color) != BMNKKBDCELE.Substring(LEOCLKHBLED + 1, 6).ToUpper())
			{
				return false;
			}
			if (IKCFCNJCHFJ != null)
			{
				color.a = IKCFCNJCHFJ.AOBAKCJKELK(IKCFCNJCHFJ.POIJPKODPCK - 1).a;
				if (GBBLFPAEBKG && color.a != 1f)
				{
					color = Color.Lerp(LNLEFKMCGBC, color, color.a);
				}
				IKCFCNJCHFJ.GBFCKODJEGE(color);
			}
			LEOCLKHBLED += 8;
			return true;
		}
		if (LEOCLKHBLED + 10 > length)
		{
			return false;
		}
		if (BMNKKBDCELE[LEOCLKHBLED + 9] == ']')
		{
			Color color2 = MMOHLLLHLLI(BMNKKBDCELE, LEOCLKHBLED + 1);
			if (IGGJAFKNFNN(color2) != BMNKKBDCELE.Substring(LEOCLKHBLED + 1, 8).ToUpper())
			{
				return false;
			}
			if (IKCFCNJCHFJ != null)
			{
				if (GBBLFPAEBKG && color2.a != 1f)
				{
					color2 = Color.Lerp(LNLEFKMCGBC, color2, color2.a);
				}
				IKCFCNJCHFJ.GBFCKODJEGE(color2);
			}
			LEOCLKHBLED += 10;
			return true;
		}
		return false;
	}

	public static string AFNLFGAHKKC(string BMNKKBDCELE)
	{
		if (BMNKKBDCELE != null)
		{
			int num = 0;
			int length = BMNKKBDCELE.Length;
			while (num < length)
			{
				char c = BMNKKBDCELE[num];
				if (c == '[')
				{
					int NJGLLDGGAHP = 0;
					bool GGDCFIBLNLG = false;
					bool LIDDKOHNDBM = false;
					bool NLPNKKFEPDE = false;
					bool BMINLKMGIOC = false;
					int LEOCLKHBLED = num;
					if (JGBDKHJIKKB(BMNKKBDCELE, ref LEOCLKHBLED, null, false, ref NJGLLDGGAHP, ref GGDCFIBLNLG, ref LIDDKOHNDBM, ref NLPNKKFEPDE, ref BMINLKMGIOC))
					{
						BMNKKBDCELE = BMNKKBDCELE.Remove(num, LEOCLKHBLED - num);
						length = BMNKKBDCELE.Length;
						continue;
					}
				}
				num++;
			}
		}
		return BMNKKBDCELE;
	}

	public static void OHKIJDOHNOE(global::MABNNPIGEPM<Vector3> HILIICKOOFH, int PINABLADDKL, float HNHGAOBNODG)
	{
		switch (JGHJBDJBMNF)
		{
		case NBEGJBKHJLH.Right:
		{
			float num14 = (float)IDNLBBKJDAH - HNHGAOBNODG;
			if (!(num14 < 0f))
			{
				for (int j = PINABLADDKL; j < HILIICKOOFH.POIJPKODPCK; j++)
				{
					HILIICKOOFH.EDMNHDBEPMC[j].x += num14;
				}
			}
			break;
		}
		case NBEGJBKHJLH.Center:
		{
			float num11 = ((float)IDNLBBKJDAH - HNHGAOBNODG) * 0.5f;
			if (!(num11 < 0f))
			{
				int num12 = Mathf.RoundToInt((float)IDNLBBKJDAH - HNHGAOBNODG);
				int num13 = Mathf.RoundToInt(IDNLBBKJDAH);
				bool flag = (num12 & 1) == 1;
				bool flag2 = (num13 & 1) == 1;
				if ((flag && !flag2) || (!flag && flag2))
				{
					num11 += 0.5f * OEFOGDBMFFN;
				}
				for (int i = PINABLADDKL; i < HILIICKOOFH.POIJPKODPCK; i++)
				{
					HILIICKOOFH.EDMNHDBEPMC[i].x += num11;
				}
			}
			break;
		}
		case NBEGJBKHJLH.Justified:
		{
			if (HNHGAOBNODG < (float)IDNLBBKJDAH * 0.65f)
			{
				break;
			}
			float num = ((float)IDNLBBKJDAH - HNHGAOBNODG) * 0.5f;
			if (num < 1f)
			{
				break;
			}
			int num2 = (HILIICKOOFH.POIJPKODPCK - PINABLADDKL) / 4;
			if (num2 >= 1)
			{
				float num3 = 1f / (float)(num2 - 1);
				float num4 = (float)IDNLBBKJDAH / HNHGAOBNODG;
				int num5 = PINABLADDKL + 4;
				int num6 = 1;
				while (num5 < HILIICKOOFH.POIJPKODPCK)
				{
					float x = HILIICKOOFH.EDMNHDBEPMC[num5].x;
					float x2 = HILIICKOOFH.EDMNHDBEPMC[num5 + 2].x;
					float num7 = x2 - x;
					float num8 = x * num4;
					float num9 = num8 + num7;
					float num10 = x2 * num4;
					float to = num10 - num7;
					float t = (float)num6 * num3;
					x = Mathf.Lerp(num8, to, t);
					x2 = Mathf.Lerp(num9, num10, t);
					x = Mathf.Round(x);
					x2 = Mathf.Round(x2);
					HILIICKOOFH.EDMNHDBEPMC[num5++].x = x;
					HILIICKOOFH.EDMNHDBEPMC[num5++].x = x;
					HILIICKOOFH.EDMNHDBEPMC[num5++].x = x2;
					HILIICKOOFH.EDMNHDBEPMC[num5++].x = x2;
					num6++;
				}
			}
			break;
		}
		}
	}

	public static int FDNLMBEIOLL(global::MABNNPIGEPM<Vector3> HILIICKOOFH, Vector2 HEPNHCEIFMO)
	{
		float num = float.MaxValue;
		float num2 = float.MaxValue;
		int result = 0;
		for (int i = 0; i < HILIICKOOFH.POIJPKODPCK; i++)
		{
			float num3 = Mathf.Abs(HEPNHCEIFMO.y - HILIICKOOFH.AOBAKCJKELK(i).y);
			if (!(num3 > num2))
			{
				float num4 = Mathf.Abs(HEPNHCEIFMO.x - HILIICKOOFH.AOBAKCJKELK(i).x);
				if (num3 < num2)
				{
					num2 = num3;
					num = num4;
					result = i;
				}
				else if (num4 < num)
				{
					num = num4;
					result = i;
				}
			}
		}
		return result;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	private static bool FAIIBBKNPMJ(int JBIBLBJBBAM)
	{
		return JBIBLBJBBAM == 32 || JBIBLBJBBAM == 8202 || JBIBLBJBBAM == 8203;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static void IFNNFJPJDOJ(ref StringBuilder MABBPNNIMBJ)
	{
		int num = MABBPNNIMBJ.Length - 1;
		if (num > 0 && FAIIBBKNPMJ(MABBPNNIMBJ[num]))
		{
			MABBPNNIMBJ[num] = '\n';
		}
		else
		{
			MABBPNNIMBJ.Append('\n');
		}
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	private static void KNPNHAOCPHB(ref StringBuilder MABBPNNIMBJ)
	{
		int num = MABBPNNIMBJ.Length - 1;
		if (num > 0 && FAIIBBKNPMJ(MABBPNNIMBJ[num]))
		{
			MABBPNNIMBJ[num] = '\n';
		}
	}

	public static Vector2 BFKLHLHHKDJ(string BMNKKBDCELE)
	{
		Vector2 zero = Vector2.zero;
		if (!string.IsNullOrEmpty(BMNKKBDCELE))
		{
			if (EAGEFFBJIKH)
			{
				BMNKKBDCELE = AFNLFGAHKKC(BMNKKBDCELE);
			}
			OFDEHCIAHLD(BMNKKBDCELE);
			float num = 0f;
			float num2 = 0f;
			float num3 = 0f;
			int length = BMNKKBDCELE.Length;
			int num4 = 0;
			int gGDGAIFKLCB = 0;
			for (int i = 0; i < length; i++)
			{
				num4 = BMNKKBDCELE[i];
				if (num4 == 10)
				{
					if (num > num3)
					{
						num3 = num;
					}
					num = 0f;
					num2 += FDIDNKHIBHG;
				}
				else
				{
					if (num4 < 32)
					{
						continue;
					}
					BMSymbol bMSymbol = ((!EGBDMGOBCBG) ? null : EBHJAKJAHLH(BMNKKBDCELE, i, length));
					if (bMSymbol == null)
					{
						float num5 = GAAPHMFJFOE(num4, gGDGAIFKLCB);
						if (num5 == 0f)
						{
							continue;
						}
						num5 += BJBMDDIGANL;
						if (Mathf.RoundToInt(num + num5) > IDNLBBKJDAH)
						{
							if (num > num3)
							{
								num3 = num - BJBMDDIGANL;
							}
							num = num5;
							num2 += FDIDNKHIBHG;
						}
						else
						{
							num += num5;
						}
						gGDGAIFKLCB = num4;
						continue;
					}
					float num6 = BJBMDDIGANL + (float)bMSymbol.advance * OEFOGDBMFFN;
					if (Mathf.RoundToInt(num + num6) > IDNLBBKJDAH)
					{
						if (num > num3)
						{
							num3 = num - BJBMDDIGANL;
						}
						num = num6;
						num2 += FDIDNKHIBHG;
					}
					else
					{
						num += num6;
					}
					i += bMSymbol.sequence.Length - 1;
					gGDGAIFKLCB = 0;
				}
			}
			zero.x = ((!(num > num3)) ? num3 : (num - BJBMDDIGANL));
			zero.y = num2 + FDIDNKHIBHG;
		}
		return zero;
	}

	public static int FEGCCKFOIHO(string BMNKKBDCELE)
	{
		if (string.IsNullOrEmpty(BMNKKBDCELE) || IDNLBBKJDAH < 1)
		{
			return 0;
		}
		OFDEHCIAHLD(BMNKKBDCELE);
		int length = BMNKKBDCELE.Length;
		int num = 0;
		int gGDGAIFKLCB = 0;
		int i = 0;
		for (int length2 = BMNKKBDCELE.Length; i < length2; i++)
		{
			BMSymbol bMSymbol = ((!EGBDMGOBCBG) ? null : EBHJAKJAHLH(BMNKKBDCELE, i, length));
			if (bMSymbol == null)
			{
				num = BMNKKBDCELE[i];
				float num2 = GAAPHMFJFOE(num, gGDGAIFKLCB);
				if (num2 != 0f)
				{
					LFHDDLCPHFP.GBFCKODJEGE(BJBMDDIGANL + num2);
				}
				gGDGAIFKLCB = num;
				continue;
			}
			LFHDDLCPHFP.GBFCKODJEGE(BJBMDDIGANL + (float)bMSymbol.advance * OEFOGDBMFFN);
			int j = 0;
			for (int num3 = bMSymbol.sequence.Length - 1; j < num3; j++)
			{
				LFHDDLCPHFP.GBFCKODJEGE(0f);
			}
			i += bMSymbol.sequence.Length - 1;
			gGDGAIFKLCB = 0;
		}
		float num4 = IDNLBBKJDAH;
		int num5 = LFHDDLCPHFP.POIJPKODPCK;
		while (num5 > 0 && num4 > 0f)
		{
			num4 -= LFHDDLCPHFP.AOBAKCJKELK(--num5);
		}
		LFHDDLCPHFP.PDCPMDCOLOD();
		if (num4 < 0f)
		{
			num5++;
		}
		return num5;
	}

	public static string PNHHLNNLGBD(string BMNKKBDCELE)
	{
		int length = BMNKKBDCELE.Length;
		int num = FEGCCKFOIHO(BMNKKBDCELE);
		return BMNKKBDCELE.Substring(num, length - num);
	}

	public static bool FMONJIFJCJA(string BMNKKBDCELE, out string EKDLKPJOKAB)
	{
		return FMONJIFJCJA(BMNKKBDCELE, out EKDLKPJOKAB, false);
	}

	public static bool FMONJIFJCJA(string BMNKKBDCELE, out string EKDLKPJOKAB, bool OHMMNCGDCHN)
	{
		if (IDNLBBKJDAH < 1 || JNPNECNIPBM < 1 || FDIDNKHIBHG < 1f)
		{
			EKDLKPJOKAB = string.Empty;
			return false;
		}
		float num = ((EGBDNLHOLPE <= 0) ? ((float)JNPNECNIPBM) : Mathf.Min(JNPNECNIPBM, FDIDNKHIBHG * (float)EGBDNLHOLPE));
		int num2 = ((EGBDNLHOLPE <= 0) ? 1000000 : EGBDNLHOLPE);
		num2 = Mathf.FloorToInt(Mathf.Min(num2, num / FDIDNKHIBHG) + 0.01f);
		if (num2 == 0)
		{
			EKDLKPJOKAB = string.Empty;
			return false;
		}
		if (string.IsNullOrEmpty(BMNKKBDCELE))
		{
			BMNKKBDCELE = " ";
		}
		OFDEHCIAHLD(BMNKKBDCELE);
		StringBuilder MABBPNNIMBJ = new StringBuilder();
		int length = BMNKKBDCELE.Length;
		float num3 = IDNLBBKJDAH;
		int num4 = 0;
		int i = 0;
		int num5 = 1;
		int gGDGAIFKLCB = 0;
		bool flag = true;
		bool flag2 = true;
		bool flag3 = false;
		for (; i < length; i++)
		{
			char c = BMNKKBDCELE[i];
			if (c > '⿿')
			{
				flag3 = true;
			}
			if (c == '\n')
			{
				if (num5 == num2)
				{
					break;
				}
				num3 = IDNLBBKJDAH;
				if (num4 < i)
				{
					MABBPNNIMBJ.Append(BMNKKBDCELE.Substring(num4, i - num4 + 1));
				}
				else
				{
					MABBPNNIMBJ.Append(c);
				}
				flag = true;
				num5++;
				num4 = i + 1;
				gGDGAIFKLCB = 0;
				continue;
			}
			if (EAGEFFBJIKH && JGBDKHJIKKB(BMNKKBDCELE, ref i))
			{
				i--;
				continue;
			}
			BMSymbol bMSymbol = ((!EGBDMGOBCBG) ? null : EBHJAKJAHLH(BMNKKBDCELE, i, length));
			float num7;
			if (bMSymbol == null)
			{
				float num6 = GAAPHMFJFOE(c, gGDGAIFKLCB);
				if (num6 == 0f)
				{
					continue;
				}
				num7 = BJBMDDIGANL + num6;
			}
			else
			{
				num7 = BJBMDDIGANL + (float)bMSymbol.advance * OEFOGDBMFFN;
			}
			num3 -= num7;
			if (FAIIBBKNPMJ(c) && !flag3 && num4 < i)
			{
				int num8 = i - num4 + 1;
				if (num5 == num2 && num3 <= 0f && i < length)
				{
					char c2 = BMNKKBDCELE[i];
					if (c2 < ' ' || FAIIBBKNPMJ(c2))
					{
						num8--;
					}
				}
				MABBPNNIMBJ.Append(BMNKKBDCELE.Substring(num4, num8));
				flag = false;
				num4 = i + 1;
				gGDGAIFKLCB = c;
			}
			if (Mathf.RoundToInt(num3) < 0)
			{
				if (!flag && num5 != num2)
				{
					flag = true;
					num3 = IDNLBBKJDAH;
					i = num4 - 1;
					gGDGAIFKLCB = 0;
					if (num5++ == num2)
					{
						break;
					}
					if (OHMMNCGDCHN)
					{
						KNPNHAOCPHB(ref MABBPNNIMBJ);
					}
					else
					{
						IFNNFJPJDOJ(ref MABBPNNIMBJ);
					}
					continue;
				}
				MABBPNNIMBJ.Append(BMNKKBDCELE.Substring(num4, Mathf.Max(0, i - num4)));
				bool flag4 = FAIIBBKNPMJ(c);
				if (!flag4 && !flag3)
				{
					flag2 = false;
				}
				if (num5++ == num2)
				{
					num4 = i;
					break;
				}
				if (OHMMNCGDCHN)
				{
					KNPNHAOCPHB(ref MABBPNNIMBJ);
				}
				else
				{
					IFNNFJPJDOJ(ref MABBPNNIMBJ);
				}
				flag = true;
				if (flag4)
				{
					num4 = i + 1;
					num3 = IDNLBBKJDAH;
				}
				else
				{
					num4 = i;
					num3 = (float)IDNLBBKJDAH - num7;
				}
				gGDGAIFKLCB = 0;
			}
			else
			{
				gGDGAIFKLCB = c;
			}
			if (bMSymbol != null)
			{
				i += bMSymbol.length - 1;
				gGDGAIFKLCB = 0;
			}
		}
		if (num4 < i)
		{
			MABBPNNIMBJ.Append(BMNKKBDCELE.Substring(num4, i - num4));
		}
		EKDLKPJOKAB = MABBPNNIMBJ.ToString();
		return flag2 && (i == length || num5 <= Mathf.Min(EGBDNLHOLPE, num2));
	}

	public static void AAPMNAMDAEE(string BMNKKBDCELE, global::MABNNPIGEPM<Vector3> HILIICKOOFH, global::MABNNPIGEPM<Vector2> MDBIEMHCFFO, global::MABNNPIGEPM<Color32> NAMIAMEOHAP)
	{
		if (string.IsNullOrEmpty(BMNKKBDCELE))
		{
			return;
		}
		int pOIJPKODPCK = HILIICKOOFH.POIJPKODPCK;
		OFDEHCIAHLD(BMNKKBDCELE);
		PDGKKAMJLHO.GBFCKODJEGE(Color.white);
		HHABLPHFEDL = 1f;
		int num = 0;
		int gGDGAIFKLCB = 0;
		float num2 = 0f;
		float num3 = 0f;
		float num4 = 0f;
		float num5 = PDEIFLEEEOL;
		Color a = EHGLADDANIC * BHIBCMKMAHH;
		Color b = EHGLADDANIC * EDDGAHPMAHL;
		Color32 color = EHGLADDANIC;
		int length = BMNKKBDCELE.Length;
		Rect rect = default(Rect);
		float num6 = 0f;
		float num7 = 0f;
		float num8 = num5 * EGMANIMPOJD;
		bool flag = false;
		int NJGLLDGGAHP = 0;
		bool GGDCFIBLNLG = false;
		bool LIDDKOHNDBM = false;
		bool NLPNKKFEPDE = false;
		bool BMINLKMGIOC = false;
		float num9 = 0f;
		if (BOLNHAFHHLH != null)
		{
			rect = BOLNHAFHHLH.get_uvRect();
			num6 = rect.width / (float)BOLNHAFHHLH.get_texWidth();
			num7 = rect.height / (float)BOLNHAFHHLH.get_texHeight();
		}
		for (int i = 0; i < length; i++)
		{
			num = BMNKKBDCELE[i];
			num9 = num2;
			if (num == 10)
			{
				if (num2 > num4)
				{
					num4 = num2;
				}
				if (JGHJBDJBMNF != NBEGJBKHJLH.Left)
				{
					OHKIJDOHNOE(HILIICKOOFH, pOIJPKODPCK, num2 - BJBMDDIGANL);
					pOIJPKODPCK = HILIICKOOFH.POIJPKODPCK;
				}
				num2 = 0f;
				num3 += FDIDNKHIBHG;
				gGDGAIFKLCB = 0;
				continue;
			}
			if (num < 32)
			{
				gGDGAIFKLCB = num;
				continue;
			}
			if (EAGEFFBJIKH && JGBDKHJIKKB(BMNKKBDCELE, ref i, PDGKKAMJLHO, GBBLFPAEBKG, ref NJGLLDGGAHP, ref GGDCFIBLNLG, ref LIDDKOHNDBM, ref NLPNKKFEPDE, ref BMINLKMGIOC))
			{
				Color color2 = EHGLADDANIC * PDGKKAMJLHO.AOBAKCJKELK(PDGKKAMJLHO.POIJPKODPCK - 1);
				color2.a *= HHABLPHFEDL;
				color = color2;
				int j = 0;
				for (int num10 = PDGKKAMJLHO.POIJPKODPCK - 2; j < num10; j++)
				{
					color2.a *= PDGKKAMJLHO.AOBAKCJKELK(j).a;
				}
				if (HIFLOBIANFE)
				{
					a = BHIBCMKMAHH * color2;
					b = EDDGAHPMAHL * color2;
				}
				i--;
				continue;
			}
			BMSymbol bMSymbol = ((!EGBDMGOBCBG) ? null : EBHJAKJAHLH(BMNKKBDCELE, i, length));
			float num11;
			float num12;
			float num14;
			float num13;
			if (bMSymbol != null)
			{
				num11 = num2 + (float)bMSymbol.offsetX * OEFOGDBMFFN;
				num12 = num11 + (float)bMSymbol.width * OEFOGDBMFFN;
				num13 = 0f - (num3 + (float)bMSymbol.offsetY * OEFOGDBMFFN);
				num14 = num13 - (float)bMSymbol.height * OEFOGDBMFFN;
				if (Mathf.RoundToInt(num2 + (float)bMSymbol.advance * OEFOGDBMFFN) > IDNLBBKJDAH)
				{
					if (num2 == 0f)
					{
						return;
					}
					if (JGHJBDJBMNF != NBEGJBKHJLH.Left && pOIJPKODPCK < HILIICKOOFH.POIJPKODPCK)
					{
						OHKIJDOHNOE(HILIICKOOFH, pOIJPKODPCK, num2 - BJBMDDIGANL);
						pOIJPKODPCK = HILIICKOOFH.POIJPKODPCK;
					}
					num11 -= num2;
					num12 -= num2;
					num14 -= FDIDNKHIBHG;
					num13 -= FDIDNKHIBHG;
					num2 = 0f;
					num3 += FDIDNKHIBHG;
					num9 = 0f;
				}
				HILIICKOOFH.GBFCKODJEGE(new Vector3(num11, num14));
				HILIICKOOFH.GBFCKODJEGE(new Vector3(num11, num13));
				HILIICKOOFH.GBFCKODJEGE(new Vector3(num12, num13));
				HILIICKOOFH.GBFCKODJEGE(new Vector3(num12, num14));
				num2 += BJBMDDIGANL + (float)bMSymbol.advance * OEFOGDBMFFN;
				i += bMSymbol.length - 1;
				gGDGAIFKLCB = 0;
				if (MDBIEMHCFFO != null)
				{
					Rect uvRect = bMSymbol.uvRect;
					float xMin = uvRect.xMin;
					float yMin = uvRect.yMin;
					float xMax = uvRect.xMax;
					float yMax = uvRect.yMax;
					MDBIEMHCFFO.GBFCKODJEGE(new Vector2(xMin, yMin));
					MDBIEMHCFFO.GBFCKODJEGE(new Vector2(xMin, yMax));
					MDBIEMHCFFO.GBFCKODJEGE(new Vector2(xMax, yMax));
					MDBIEMHCFFO.GBFCKODJEGE(new Vector2(xMax, yMin));
				}
				if (NAMIAMEOHAP == null)
				{
					continue;
				}
				if (GGLDLMGHBIK == OOGEENANIAD.Colored)
				{
					for (int k = 0; k < 4; k++)
					{
						NAMIAMEOHAP.GBFCKODJEGE(color);
					}
					continue;
				}
				Color32 hBIPOCDNMCB = Color.white;
				hBIPOCDNMCB.a = color.a;
				for (int l = 0; l < 4; l++)
				{
					NAMIAMEOHAP.GBFCKODJEGE(hBIPOCDNMCB);
				}
				continue;
			}
			HNMKLCNAJKP hNMKLCNAJKP = KHLMNHAIBFH(num, gGDGAIFKLCB);
			if (hNMKLCNAJKP == null)
			{
				continue;
			}
			gGDGAIFKLCB = num;
			if (NJGLLDGGAHP != 0)
			{
				hNMKLCNAJKP.GKBGMNLKFMK.x *= 0.75f;
				hNMKLCNAJKP.GKBGMNLKFMK.y *= 0.75f;
				hNMKLCNAJKP.MEMCHGBOBMC.x *= 0.75f;
				hNMKLCNAJKP.MEMCHGBOBMC.y *= 0.75f;
				if (NJGLLDGGAHP == 1)
				{
					hNMKLCNAJKP.GKBGMNLKFMK.y -= OEFOGDBMFFN * (float)DIDGACJBIGL * 0.4f;
					hNMKLCNAJKP.MEMCHGBOBMC.y -= OEFOGDBMFFN * (float)DIDGACJBIGL * 0.4f;
				}
				else
				{
					hNMKLCNAJKP.GKBGMNLKFMK.y += OEFOGDBMFFN * (float)DIDGACJBIGL * 0.05f;
					hNMKLCNAJKP.MEMCHGBOBMC.y += OEFOGDBMFFN * (float)DIDGACJBIGL * 0.05f;
				}
			}
			float y = hNMKLCNAJKP.GKBGMNLKFMK.y;
			float y2 = hNMKLCNAJKP.MEMCHGBOBMC.y;
			num11 = hNMKLCNAJKP.GKBGMNLKFMK.x + num2;
			num14 = hNMKLCNAJKP.GKBGMNLKFMK.y - num3;
			num12 = hNMKLCNAJKP.MEMCHGBOBMC.x + num2;
			num13 = hNMKLCNAJKP.MEMCHGBOBMC.y - num3;
			float num15 = hNMKLCNAJKP.EBOEDCPKDAB;
			if (BJBMDDIGANL < 0f)
			{
				num15 += BJBMDDIGANL;
			}
			if (Mathf.RoundToInt(num2 + num15) > IDNLBBKJDAH)
			{
				if (num2 == 0f)
				{
					return;
				}
				if (JGHJBDJBMNF != NBEGJBKHJLH.Left && pOIJPKODPCK < HILIICKOOFH.POIJPKODPCK)
				{
					OHKIJDOHNOE(HILIICKOOFH, pOIJPKODPCK, num2 - BJBMDDIGANL);
					pOIJPKODPCK = HILIICKOOFH.POIJPKODPCK;
				}
				num11 -= num2;
				num12 -= num2;
				num14 -= FDIDNKHIBHG;
				num13 -= FDIDNKHIBHG;
				num2 = 0f;
				num3 += FDIDNKHIBHG;
				num9 = 0f;
			}
			if (FAIIBBKNPMJ(num))
			{
				if (NLPNKKFEPDE)
				{
					num = 95;
				}
				else if (BMINLKMGIOC)
				{
					num = 45;
				}
			}
			num2 += ((NJGLLDGGAHP != 0) ? ((BJBMDDIGANL + hNMKLCNAJKP.EBOEDCPKDAB) * 0.75f) : (BJBMDDIGANL + hNMKLCNAJKP.EBOEDCPKDAB));
			if (FAIIBBKNPMJ(num))
			{
				continue;
			}
			if (MDBIEMHCFFO != null)
			{
				if (BOLNHAFHHLH != null)
				{
					hNMKLCNAJKP.NEIEGGLBIEF.x = rect.xMin + num6 * hNMKLCNAJKP.NEIEGGLBIEF.x;
					hNMKLCNAJKP.PFLGILEHKCJ.x = rect.xMin + num6 * hNMKLCNAJKP.PFLGILEHKCJ.x;
					hNMKLCNAJKP.NEIEGGLBIEF.y = rect.yMax - num7 * hNMKLCNAJKP.NEIEGGLBIEF.y;
					hNMKLCNAJKP.PFLGILEHKCJ.y = rect.yMax - num7 * hNMKLCNAJKP.PFLGILEHKCJ.y;
				}
				int m = 0;
				for (int num16 = ((!GGDCFIBLNLG) ? 1 : 4); m < num16; m++)
				{
					if (hNMKLCNAJKP.CFGOMDEHGAC)
					{
						MDBIEMHCFFO.GBFCKODJEGE(hNMKLCNAJKP.NEIEGGLBIEF);
						MDBIEMHCFFO.GBFCKODJEGE(new Vector2(hNMKLCNAJKP.PFLGILEHKCJ.x, hNMKLCNAJKP.NEIEGGLBIEF.y));
						MDBIEMHCFFO.GBFCKODJEGE(hNMKLCNAJKP.PFLGILEHKCJ);
						MDBIEMHCFFO.GBFCKODJEGE(new Vector2(hNMKLCNAJKP.NEIEGGLBIEF.x, hNMKLCNAJKP.PFLGILEHKCJ.y));
					}
					else
					{
						MDBIEMHCFFO.GBFCKODJEGE(hNMKLCNAJKP.NEIEGGLBIEF);
						MDBIEMHCFFO.GBFCKODJEGE(new Vector2(hNMKLCNAJKP.NEIEGGLBIEF.x, hNMKLCNAJKP.PFLGILEHKCJ.y));
						MDBIEMHCFFO.GBFCKODJEGE(hNMKLCNAJKP.PFLGILEHKCJ);
						MDBIEMHCFFO.GBFCKODJEGE(new Vector2(hNMKLCNAJKP.PFLGILEHKCJ.x, hNMKLCNAJKP.NEIEGGLBIEF.y));
					}
				}
			}
			if (NAMIAMEOHAP != null)
			{
				if (hNMKLCNAJKP.KCPGFCKMAPI == 0 || hNMKLCNAJKP.KCPGFCKMAPI == 15)
				{
					if (HIFLOBIANFE)
					{
						float num17 = num8 + y / OEFOGDBMFFN;
						float num18 = num8 + y2 / OEFOGDBMFFN;
						num17 /= num8;
						num18 /= num8;
						DBBFEFEEJIB = Color.Lerp(a, b, num17);
						IHKFNOIPAOP = Color.Lerp(a, b, num18);
						int n = 0;
						for (int num19 = ((!GGDCFIBLNLG) ? 1 : 4); n < num19; n++)
						{
							NAMIAMEOHAP.GBFCKODJEGE(DBBFEFEEJIB);
							NAMIAMEOHAP.GBFCKODJEGE(IHKFNOIPAOP);
							NAMIAMEOHAP.GBFCKODJEGE(IHKFNOIPAOP);
							NAMIAMEOHAP.GBFCKODJEGE(DBBFEFEEJIB);
						}
					}
					else
					{
						int num20 = 0;
						for (int num21 = ((!GGDCFIBLNLG) ? 4 : 16); num20 < num21; num20++)
						{
							NAMIAMEOHAP.GBFCKODJEGE(color);
						}
					}
				}
				else
				{
					Color color3 = color;
					color3 *= 0.49f;
					switch (hNMKLCNAJKP.KCPGFCKMAPI)
					{
					case 1:
						color3.b += 0.51f;
						break;
					case 2:
						color3.g += 0.51f;
						break;
					case 4:
						color3.r += 0.51f;
						break;
					case 8:
						color3.a += 0.51f;
						break;
					}
					Color32 hBIPOCDNMCB2 = color3;
					int num22 = 0;
					for (int num23 = ((!GGDCFIBLNLG) ? 4 : 16); num22 < num23; num22++)
					{
						NAMIAMEOHAP.GBFCKODJEGE(hBIPOCDNMCB2);
					}
				}
			}
			if (!GGDCFIBLNLG)
			{
				if (!LIDDKOHNDBM)
				{
					HILIICKOOFH.GBFCKODJEGE(new Vector3(num11, num14));
					HILIICKOOFH.GBFCKODJEGE(new Vector3(num11, num13));
					HILIICKOOFH.GBFCKODJEGE(new Vector3(num12, num13));
					HILIICKOOFH.GBFCKODJEGE(new Vector3(num12, num14));
				}
				else
				{
					float num24 = (float)DIDGACJBIGL * 0.1f * ((num13 - num14) / (float)DIDGACJBIGL);
					HILIICKOOFH.GBFCKODJEGE(new Vector3(num11 - num24, num14));
					HILIICKOOFH.GBFCKODJEGE(new Vector3(num11 + num24, num13));
					HILIICKOOFH.GBFCKODJEGE(new Vector3(num12 + num24, num13));
					HILIICKOOFH.GBFCKODJEGE(new Vector3(num12 - num24, num14));
				}
			}
			else
			{
				for (int num25 = 0; num25 < 4; num25++)
				{
					float num26 = EOGOIDLFOCB[num25 * 2];
					float num27 = EOGOIDLFOCB[num25 * 2 + 1];
					float num28 = num26 + ((!LIDDKOHNDBM) ? 0f : ((float)DIDGACJBIGL * 0.1f * ((num13 - num14) / (float)DIDGACJBIGL)));
					HILIICKOOFH.GBFCKODJEGE(new Vector3(num11 - num28, num14 + num27));
					HILIICKOOFH.GBFCKODJEGE(new Vector3(num11 + num28, num13 + num27));
					HILIICKOOFH.GBFCKODJEGE(new Vector3(num12 + num28, num13 + num27));
					HILIICKOOFH.GBFCKODJEGE(new Vector3(num12 - num28, num14 + num27));
				}
			}
			if (!NLPNKKFEPDE && !BMINLKMGIOC)
			{
				continue;
			}
			HNMKLCNAJKP hNMKLCNAJKP2 = KHLMNHAIBFH((!BMINLKMGIOC) ? 95 : 45, gGDGAIFKLCB);
			if (hNMKLCNAJKP2 == null)
			{
				continue;
			}
			if (MDBIEMHCFFO != null)
			{
				if (BOLNHAFHHLH != null)
				{
					hNMKLCNAJKP2.NEIEGGLBIEF.x = rect.xMin + num6 * hNMKLCNAJKP2.NEIEGGLBIEF.x;
					hNMKLCNAJKP2.PFLGILEHKCJ.x = rect.xMin + num6 * hNMKLCNAJKP2.PFLGILEHKCJ.x;
					hNMKLCNAJKP2.NEIEGGLBIEF.y = rect.yMax - num7 * hNMKLCNAJKP2.NEIEGGLBIEF.y;
					hNMKLCNAJKP2.PFLGILEHKCJ.y = rect.yMax - num7 * hNMKLCNAJKP2.PFLGILEHKCJ.y;
				}
				float x = (hNMKLCNAJKP2.NEIEGGLBIEF.x + hNMKLCNAJKP2.PFLGILEHKCJ.x) * 0.5f;
				float y3 = (hNMKLCNAJKP2.NEIEGGLBIEF.y + hNMKLCNAJKP2.PFLGILEHKCJ.y) * 0.5f;
				MDBIEMHCFFO.GBFCKODJEGE(new Vector2(x, y3));
				MDBIEMHCFFO.GBFCKODJEGE(new Vector2(x, y3));
				MDBIEMHCFFO.GBFCKODJEGE(new Vector2(x, y3));
				MDBIEMHCFFO.GBFCKODJEGE(new Vector2(x, y3));
			}
			if (flag && BMINLKMGIOC)
			{
				num14 = (0f - num3 + hNMKLCNAJKP2.GKBGMNLKFMK.y) * 0.75f;
				num13 = (0f - num3 + hNMKLCNAJKP2.MEMCHGBOBMC.y) * 0.75f;
			}
			else
			{
				num14 = 0f - num3 + hNMKLCNAJKP2.GKBGMNLKFMK.y;
				num13 = 0f - num3 + hNMKLCNAJKP2.MEMCHGBOBMC.y;
			}
			HILIICKOOFH.GBFCKODJEGE(new Vector3(num9, num14));
			HILIICKOOFH.GBFCKODJEGE(new Vector3(num9, num13));
			HILIICKOOFH.GBFCKODJEGE(new Vector3(num2, num13));
			HILIICKOOFH.GBFCKODJEGE(new Vector3(num2, num14));
			Color color4 = color;
			if (BMINLKMGIOC)
			{
				color4.r *= 0.5f;
				color4.g *= 0.5f;
				color4.b *= 0.5f;
			}
			color4.a *= 0.75f;
			Color32 hBIPOCDNMCB3 = color4;
			NAMIAMEOHAP.GBFCKODJEGE(hBIPOCDNMCB3);
			NAMIAMEOHAP.GBFCKODJEGE(color);
			NAMIAMEOHAP.GBFCKODJEGE(color);
			NAMIAMEOHAP.GBFCKODJEGE(hBIPOCDNMCB3);
		}
		if (JGHJBDJBMNF != NBEGJBKHJLH.Left && pOIJPKODPCK < HILIICKOOFH.POIJPKODPCK)
		{
			OHKIJDOHNOE(HILIICKOOFH, pOIJPKODPCK, num2 - BJBMDDIGANL);
			pOIJPKODPCK = HILIICKOOFH.POIJPKODPCK;
		}
		PDGKKAMJLHO.PDCPMDCOLOD();
	}

	public static void KLANINGKMOI(string BMNKKBDCELE, global::MABNNPIGEPM<Vector3> HILIICKOOFH, global::MABNNPIGEPM<int> LLPKHHBBLGA)
	{
		if (string.IsNullOrEmpty(BMNKKBDCELE))
		{
			BMNKKBDCELE = " ";
		}
		OFDEHCIAHLD(BMNKKBDCELE);
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		float num4 = (float)DIDGACJBIGL * OEFOGDBMFFN * 0.5f;
		int length = BMNKKBDCELE.Length;
		int pOIJPKODPCK = HILIICKOOFH.POIJPKODPCK;
		int num5 = 0;
		int gGDGAIFKLCB = 0;
		for (int i = 0; i < length; i++)
		{
			num5 = BMNKKBDCELE[i];
			HILIICKOOFH.GBFCKODJEGE(new Vector3(num, 0f - num2 - num4));
			LLPKHHBBLGA.GBFCKODJEGE(i);
			if (num5 == 10)
			{
				if (num > num3)
				{
					num3 = num;
				}
				if (JGHJBDJBMNF != NBEGJBKHJLH.Left)
				{
					OHKIJDOHNOE(HILIICKOOFH, pOIJPKODPCK, num - BJBMDDIGANL);
					pOIJPKODPCK = HILIICKOOFH.POIJPKODPCK;
				}
				num = 0f;
				num2 += FDIDNKHIBHG;
				gGDGAIFKLCB = 0;
				continue;
			}
			if (num5 < 32)
			{
				gGDGAIFKLCB = 0;
				continue;
			}
			if (EAGEFFBJIKH && JGBDKHJIKKB(BMNKKBDCELE, ref i))
			{
				i--;
				continue;
			}
			BMSymbol bMSymbol = ((!EGBDMGOBCBG) ? null : EBHJAKJAHLH(BMNKKBDCELE, i, length));
			if (bMSymbol == null)
			{
				float num6 = GAAPHMFJFOE(num5, gGDGAIFKLCB);
				if (num6 == 0f)
				{
					continue;
				}
				num6 += BJBMDDIGANL;
				if (Mathf.RoundToInt(num + num6) > IDNLBBKJDAH)
				{
					if (num == 0f)
					{
						return;
					}
					if (JGHJBDJBMNF != NBEGJBKHJLH.Left && pOIJPKODPCK < HILIICKOOFH.POIJPKODPCK)
					{
						OHKIJDOHNOE(HILIICKOOFH, pOIJPKODPCK, num - BJBMDDIGANL);
						pOIJPKODPCK = HILIICKOOFH.POIJPKODPCK;
					}
					num = num6;
					num2 += FDIDNKHIBHG;
				}
				else
				{
					num += num6;
				}
				HILIICKOOFH.GBFCKODJEGE(new Vector3(num, 0f - num2 - num4));
				LLPKHHBBLGA.GBFCKODJEGE(i + 1);
				gGDGAIFKLCB = num5;
				continue;
			}
			float num7 = (float)bMSymbol.advance * OEFOGDBMFFN + BJBMDDIGANL;
			if (Mathf.RoundToInt(num + num7) > IDNLBBKJDAH)
			{
				if (num == 0f)
				{
					return;
				}
				if (JGHJBDJBMNF != NBEGJBKHJLH.Left && pOIJPKODPCK < HILIICKOOFH.POIJPKODPCK)
				{
					OHKIJDOHNOE(HILIICKOOFH, pOIJPKODPCK, num - BJBMDDIGANL);
					pOIJPKODPCK = HILIICKOOFH.POIJPKODPCK;
				}
				num = num7;
				num2 += FDIDNKHIBHG;
			}
			else
			{
				num += num7;
			}
			HILIICKOOFH.GBFCKODJEGE(new Vector3(num, 0f - num2 - num4));
			LLPKHHBBLGA.GBFCKODJEGE(i + 1);
			i += bMSymbol.sequence.Length - 1;
			gGDGAIFKLCB = 0;
		}
		if (JGHJBDJBMNF != NBEGJBKHJLH.Left && pOIJPKODPCK < HILIICKOOFH.POIJPKODPCK)
		{
			OHKIJDOHNOE(HILIICKOOFH, pOIJPKODPCK, num - BJBMDDIGANL);
		}
	}

	public static void NIEPAJBCLJI(string BMNKKBDCELE, int GAKOOBECLIB, int IDFCFEOMBKP, global::MABNNPIGEPM<Vector3> LFBNHHCAIEA, global::MABNNPIGEPM<Vector3> PFPDDKFJGAO)
	{
		if (string.IsNullOrEmpty(BMNKKBDCELE))
		{
			BMNKKBDCELE = " ";
		}
		OFDEHCIAHLD(BMNKKBDCELE);
		int num = IDFCFEOMBKP;
		if (GAKOOBECLIB > IDFCFEOMBKP)
		{
			IDFCFEOMBKP = GAKOOBECLIB;
			GAKOOBECLIB = num;
		}
		float num2 = 0f;
		float num3 = 0f;
		float num4 = 0f;
		float num5 = (float)DIDGACJBIGL * OEFOGDBMFFN;
		int pINABLADDKL = ((LFBNHHCAIEA != null) ? LFBNHHCAIEA.POIJPKODPCK : 0);
		int num6 = ((PFPDDKFJGAO != null) ? PFPDDKFJGAO.POIJPKODPCK : 0);
		int length = BMNKKBDCELE.Length;
		int i = 0;
		int num7 = 0;
		int gGDGAIFKLCB = 0;
		bool flag = false;
		bool flag2 = false;
		Vector2 vector = Vector2.zero;
		Vector2 vector2 = Vector2.zero;
		for (; i < length; i++)
		{
			if (LFBNHHCAIEA != null && !flag2 && num <= i)
			{
				flag2 = true;
				LFBNHHCAIEA.GBFCKODJEGE(new Vector3(num2 - 1f, 0f - num3 - num5));
				LFBNHHCAIEA.GBFCKODJEGE(new Vector3(num2 - 1f, 0f - num3));
				LFBNHHCAIEA.GBFCKODJEGE(new Vector3(num2 + 1f, 0f - num3));
				LFBNHHCAIEA.GBFCKODJEGE(new Vector3(num2 + 1f, 0f - num3 - num5));
			}
			num7 = BMNKKBDCELE[i];
			if (num7 == 10)
			{
				if (num2 > num4)
				{
					num4 = num2;
				}
				if (LFBNHHCAIEA != null && flag2)
				{
					if (JGHJBDJBMNF != NBEGJBKHJLH.Left)
					{
						OHKIJDOHNOE(LFBNHHCAIEA, pINABLADDKL, num2 - BJBMDDIGANL);
					}
					LFBNHHCAIEA = null;
				}
				if (PFPDDKFJGAO != null)
				{
					if (flag)
					{
						flag = false;
						PFPDDKFJGAO.GBFCKODJEGE(vector2);
						PFPDDKFJGAO.GBFCKODJEGE(vector);
					}
					else if (GAKOOBECLIB <= i && IDFCFEOMBKP > i)
					{
						PFPDDKFJGAO.GBFCKODJEGE(new Vector3(num2, 0f - num3 - num5));
						PFPDDKFJGAO.GBFCKODJEGE(new Vector3(num2, 0f - num3));
						PFPDDKFJGAO.GBFCKODJEGE(new Vector3(num2 + 2f, 0f - num3));
						PFPDDKFJGAO.GBFCKODJEGE(new Vector3(num2 + 2f, 0f - num3 - num5));
					}
					if (JGHJBDJBMNF != NBEGJBKHJLH.Left && num6 < PFPDDKFJGAO.POIJPKODPCK)
					{
						OHKIJDOHNOE(PFPDDKFJGAO, num6, num2 - BJBMDDIGANL);
						num6 = PFPDDKFJGAO.POIJPKODPCK;
					}
				}
				num2 = 0f;
				num3 += FDIDNKHIBHG;
				gGDGAIFKLCB = 0;
				continue;
			}
			if (num7 < 32)
			{
				gGDGAIFKLCB = 0;
				continue;
			}
			if (EAGEFFBJIKH && JGBDKHJIKKB(BMNKKBDCELE, ref i))
			{
				i--;
				continue;
			}
			BMSymbol bMSymbol = ((!EGBDMGOBCBG) ? null : EBHJAKJAHLH(BMNKKBDCELE, i, length));
			float num8 = ((bMSymbol == null) ? GAAPHMFJFOE(num7, gGDGAIFKLCB) : ((float)bMSymbol.advance * OEFOGDBMFFN));
			if (num8 == 0f)
			{
				continue;
			}
			float num9 = num2;
			float num10 = num2 + num8;
			float num11 = 0f - num3 - num5;
			float num12 = 0f - num3;
			if (Mathf.RoundToInt(num10 + BJBMDDIGANL) > IDNLBBKJDAH)
			{
				if (num2 == 0f)
				{
					return;
				}
				if (num2 > num4)
				{
					num4 = num2;
				}
				if (LFBNHHCAIEA != null && flag2)
				{
					if (JGHJBDJBMNF != NBEGJBKHJLH.Left)
					{
						OHKIJDOHNOE(LFBNHHCAIEA, pINABLADDKL, num2 - BJBMDDIGANL);
					}
					LFBNHHCAIEA = null;
				}
				if (PFPDDKFJGAO != null)
				{
					if (flag)
					{
						flag = false;
						PFPDDKFJGAO.GBFCKODJEGE(vector2);
						PFPDDKFJGAO.GBFCKODJEGE(vector);
					}
					else if (GAKOOBECLIB <= i && IDFCFEOMBKP > i)
					{
						PFPDDKFJGAO.GBFCKODJEGE(new Vector3(num2, 0f - num3 - num5));
						PFPDDKFJGAO.GBFCKODJEGE(new Vector3(num2, 0f - num3));
						PFPDDKFJGAO.GBFCKODJEGE(new Vector3(num2 + 2f, 0f - num3));
						PFPDDKFJGAO.GBFCKODJEGE(new Vector3(num2 + 2f, 0f - num3 - num5));
					}
					if (JGHJBDJBMNF != NBEGJBKHJLH.Left && num6 < PFPDDKFJGAO.POIJPKODPCK)
					{
						OHKIJDOHNOE(PFPDDKFJGAO, num6, num2 - BJBMDDIGANL);
						num6 = PFPDDKFJGAO.POIJPKODPCK;
					}
				}
				num9 -= num2;
				num10 -= num2;
				num11 -= FDIDNKHIBHG;
				num12 -= FDIDNKHIBHG;
				num2 = 0f;
				num3 += FDIDNKHIBHG;
			}
			num2 += num8 + BJBMDDIGANL;
			if (PFPDDKFJGAO != null)
			{
				if (GAKOOBECLIB > i || IDFCFEOMBKP <= i)
				{
					if (flag)
					{
						flag = false;
						PFPDDKFJGAO.GBFCKODJEGE(vector2);
						PFPDDKFJGAO.GBFCKODJEGE(vector);
					}
				}
				else if (!flag)
				{
					flag = true;
					PFPDDKFJGAO.GBFCKODJEGE(new Vector3(num9, num11));
					PFPDDKFJGAO.GBFCKODJEGE(new Vector3(num9, num12));
				}
			}
			vector = new Vector2(num10, num11);
			vector2 = new Vector2(num10, num12);
			gGDGAIFKLCB = num7;
		}
		if (LFBNHHCAIEA != null)
		{
			if (!flag2)
			{
				LFBNHHCAIEA.GBFCKODJEGE(new Vector3(num2 - 1f, 0f - num3 - num5));
				LFBNHHCAIEA.GBFCKODJEGE(new Vector3(num2 - 1f, 0f - num3));
				LFBNHHCAIEA.GBFCKODJEGE(new Vector3(num2 + 1f, 0f - num3));
				LFBNHHCAIEA.GBFCKODJEGE(new Vector3(num2 + 1f, 0f - num3 - num5));
			}
			if (JGHJBDJBMNF != NBEGJBKHJLH.Left)
			{
				OHKIJDOHNOE(LFBNHHCAIEA, pINABLADDKL, num2 - BJBMDDIGANL);
			}
		}
		if (PFPDDKFJGAO != null)
		{
			if (flag)
			{
				PFPDDKFJGAO.GBFCKODJEGE(vector2);
				PFPDDKFJGAO.GBFCKODJEGE(vector);
			}
			else if (GAKOOBECLIB < i && IDFCFEOMBKP == i)
			{
				PFPDDKFJGAO.GBFCKODJEGE(new Vector3(num2, 0f - num3 - num5));
				PFPDDKFJGAO.GBFCKODJEGE(new Vector3(num2, 0f - num3));
				PFPDDKFJGAO.GBFCKODJEGE(new Vector3(num2 + 2f, 0f - num3));
				PFPDDKFJGAO.GBFCKODJEGE(new Vector3(num2 + 2f, 0f - num3 - num5));
			}
			if (JGHJBDJBMNF != NBEGJBKHJLH.Left && num6 < PFPDDKFJGAO.POIJPKODPCK)
			{
				OHKIJDOHNOE(PFPDDKFJGAO, num6, num2 - BJBMDDIGANL);
			}
		}
	}
}
