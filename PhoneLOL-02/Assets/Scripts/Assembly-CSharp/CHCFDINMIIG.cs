using UnityEngine;

public class CHCFDINMIIG : ACKONAFALLN
{
	public enum FJEGNINMNFG
	{
		NONE = 0,
		TOP_LEFT = 10,
		TOP_CENTER = 11,
		TOP_RIGHT = 12,
		EFFECT_LIST = 13,
		EFFECT_HIERARCHY = 14,
		EFFECT_CONTROLS = 15,
		PANEL_TEST = 16,
		TOOLIP_CURSOR = 17,
		MODAL_MSG = 18,
		MENUPOPUP = 19,
		SPRITEPOPUP = 20,
		POPUP = 100,
		RESOURCE_START = 200,
		HINTRECT = 300
	}

	public enum FOIJAOFLMKF
	{
		MODAL_NONE = 0,
		MODAL_MSG = 1,
		MODAL_OK = 2,
		MODAL_YESNO = 3,
		MODAL_OKCANCEL = 4
	}

	public enum DJBIPFPBGBA
	{
		MODALRETURN_SHOW = 0,
		MODALRETURN_OK = 1,
		MODALRETURN_CANCEL = 2
	}

	private sealed class EMDHDBEANDO
	{
		internal GUI.WindowFunction DCHDMCOLBDB;

		internal void NONHIHOOPJA(int OHGOBGOIECH)
		{
			GUI.depth = 0;
			int controlID = GUIUtility.GetControlID(FocusType.Passive);
			if (GUIUtility.hotControl < controlID)
			{
				GLPLEMACOFI(1);
			}
			DCHDMCOLBDB(OHGOBGOIECH);
			int controlID2 = GUIUtility.GetControlID(FocusType.Keyboard);
			if (GUIUtility.hotControl < controlID || (GUIUtility.hotControl > controlID2 && controlID2 != -1))
			{
				GLPLEMACOFI(-1);
			}
			GUI.FocusWindow(OHGOBGOIECH);
			GUI.BringWindowToFront(OHGOBGOIECH);
		}

		internal void FELNLIHMPGG(int OHGOBGOIECH)
		{
			GUI.depth = 0;
			int controlID = GUIUtility.GetControlID(FocusType.Keyboard);
			if (GUIUtility.hotControl < controlID)
			{
				GLPLEMACOFI(0);
			}
			DCHDMCOLBDB(OHGOBGOIECH);
			int controlID2 = GUIUtility.GetControlID(FocusType.Keyboard);
			if (GUIUtility.hotControl < controlID || (GUIUtility.hotControl > controlID2 && controlID2 != -1))
			{
				GLPLEMACOFI(-1);
			}
			GUI.FocusWindow(OHGOBGOIECH);
			GUI.BringWindowToFront(OHGOBGOIECH);
		}

		internal void KBDDHMMOBID(int OHGOBGOIECH)
		{
			GUI.depth = 1;
			int controlID = GUIUtility.GetControlID(FocusType.Keyboard);
			if (GUIUtility.hotControl < controlID)
			{
				GLPLEMACOFI(0);
			}
			DCHDMCOLBDB(OHGOBGOIECH);
			int controlID2 = GUIUtility.GetControlID(FocusType.Keyboard);
			if (GUIUtility.hotControl < controlID || (GUIUtility.hotControl > controlID2 && controlID2 != -1))
			{
				GLPLEMACOFI(-1);
			}
			GUI.FocusWindow(OHGOBGOIECH);
			GUI.BringWindowToFront(OHGOBGOIECH);
		}

		internal void KJMCPGCLCNB(int OHGOBGOIECH)
		{
			GUI.depth = 0;
			int controlID = GUIUtility.GetControlID(FocusType.Passive);
			if (GUIUtility.hotControl < controlID)
			{
				GLPLEMACOFI(1);
			}
			DCHDMCOLBDB(OHGOBGOIECH);
			int controlID2 = GUIUtility.GetControlID(FocusType.Passive);
			if (GUIUtility.hotControl < controlID || (GUIUtility.hotControl > controlID2 && controlID2 != -1))
			{
				GLPLEMACOFI(-1);
			}
			GUI.FocusWindow(OHGOBGOIECH);
			GUI.BringWindowToFront(OHGOBGOIECH);
		}

		internal void APCGNBAEICL(int OHGOBGOIECH)
		{
			GUI.depth = 0;
			int controlID = GUIUtility.GetControlID(FocusType.Passive);
			if (GUIUtility.hotControl < controlID)
			{
				GLPLEMACOFI(1);
			}
			DCHDMCOLBDB(OHGOBGOIECH);
			int controlID2 = GUIUtility.GetControlID(FocusType.Keyboard);
			if (GUIUtility.hotControl < controlID || (GUIUtility.hotControl > controlID2 && controlID2 != -1))
			{
				GLPLEMACOFI(-1);
			}
			GUI.FocusWindow(OHGOBGOIECH);
			GUI.BringWindowToFront(OHGOBGOIECH);
		}

		internal void GELLFFFJKLM(int OHGOBGOIECH)
		{
			GUI.depth = 0;
			int controlID = GUIUtility.GetControlID(FocusType.Passive);
			if (GUIUtility.hotControl < controlID)
			{
				GLPLEMACOFI(0);
			}
			DCHDMCOLBDB(OHGOBGOIECH);
			int controlID2 = GUIUtility.GetControlID(FocusType.Passive);
			if (GUIUtility.hotControl < controlID || (GUIUtility.hotControl > controlID2 && controlID2 != -1))
			{
				GLPLEMACOFI(-1);
			}
			GUI.FocusWindow(OHGOBGOIECH);
			GUI.BringWindowToFront(OHGOBGOIECH);
		}

		internal void LKJJHNCEGPC(int OHGOBGOIECH)
		{
			GUI.depth = 0;
			int controlID = GUIUtility.GetControlID(FocusType.Keyboard);
			if (GUIUtility.hotControl < controlID)
			{
				GLPLEMACOFI(0);
			}
			DCHDMCOLBDB(OHGOBGOIECH);
			int controlID2 = GUIUtility.GetControlID(FocusType.Passive);
			if (GUIUtility.hotControl < controlID || (GUIUtility.hotControl > controlID2 && controlID2 != -1))
			{
				GLPLEMACOFI(-1);
			}
			GUI.FocusWindow(OHGOBGOIECH);
			GUI.BringWindowToFront(OHGOBGOIECH);
		}

		internal void POOMNFOFBIB(int OHGOBGOIECH)
		{
			GUI.depth = 0;
			int controlID = GUIUtility.GetControlID(FocusType.Passive);
			if (GUIUtility.hotControl < controlID)
			{
				GLPLEMACOFI(1);
			}
			DCHDMCOLBDB(OHGOBGOIECH);
			int controlID2 = GUIUtility.GetControlID(FocusType.Keyboard);
			if (GUIUtility.hotControl < controlID || (GUIUtility.hotControl > controlID2 && controlID2 != -1))
			{
				GLPLEMACOFI(-1);
			}
			GUI.FocusWindow(OHGOBGOIECH);
			GUI.BringWindowToFront(OHGOBGOIECH);
		}

		internal void KOJEKPBBJCP(int OHGOBGOIECH)
		{
			GUI.depth = 1;
			int controlID = GUIUtility.GetControlID(FocusType.Passive);
			if (GUIUtility.hotControl < controlID)
			{
				GLPLEMACOFI(0);
			}
			DCHDMCOLBDB(OHGOBGOIECH);
			int controlID2 = GUIUtility.GetControlID(FocusType.Passive);
			if (GUIUtility.hotControl < controlID || (GUIUtility.hotControl > controlID2 && controlID2 != -1))
			{
				GLPLEMACOFI(-1);
			}
			GUI.FocusWindow(OHGOBGOIECH);
			GUI.BringWindowToFront(OHGOBGOIECH);
		}

		internal void HIHBFLALFHC(int OHGOBGOIECH)
		{
			GUI.depth = 1;
			int controlID = GUIUtility.GetControlID(FocusType.Keyboard);
			if (GUIUtility.hotControl < controlID)
			{
				GLPLEMACOFI(0);
			}
			DCHDMCOLBDB(OHGOBGOIECH);
			int controlID2 = GUIUtility.GetControlID(FocusType.Keyboard);
			if (GUIUtility.hotControl < controlID || (GUIUtility.hotControl > controlID2 && controlID2 != -1))
			{
				GLPLEMACOFI(-1);
			}
			GUI.FocusWindow(OHGOBGOIECH);
			GUI.BringWindowToFront(OHGOBGOIECH);
		}

		internal void AJFNBIIIGFE(int OHGOBGOIECH)
		{
			GUI.depth = 0;
			int controlID = GUIUtility.GetControlID(FocusType.Passive);
			if (GUIUtility.hotControl < controlID)
			{
				GLPLEMACOFI(0);
			}
			DCHDMCOLBDB(OHGOBGOIECH);
			int controlID2 = GUIUtility.GetControlID(FocusType.Passive);
			if (GUIUtility.hotControl < controlID || (GUIUtility.hotControl > controlID2 && controlID2 != -1))
			{
				GLPLEMACOFI(-1);
			}
			GUI.FocusWindow(OHGOBGOIECH);
			GUI.BringWindowToFront(OHGOBGOIECH);
		}

		internal void IOPGDMFAJHA(int OHGOBGOIECH)
		{
			GUI.depth = 1;
			int controlID = GUIUtility.GetControlID(FocusType.Keyboard);
			if (GUIUtility.hotControl < controlID)
			{
				GLPLEMACOFI(1);
			}
			DCHDMCOLBDB(OHGOBGOIECH);
			int controlID2 = GUIUtility.GetControlID(FocusType.Passive);
			if (GUIUtility.hotControl < controlID || (GUIUtility.hotControl > controlID2 && controlID2 != -1))
			{
				GLPLEMACOFI(-1);
			}
			GUI.FocusWindow(OHGOBGOIECH);
			GUI.BringWindowToFront(OHGOBGOIECH);
		}
	}

	public const string FFBLOJGPCNA = "v1.4.2";

	public const int OPCIJGKGDNO = 100;

	public const int OICHEMHHMJP = 500;

	public const int AGEONFOEBPN = 500;

	public const int FPFDOLNOJPL = 1000;

	public const float FKLEMOCNOPL = 1f;

	public const float AJHABNDIPCE = 0.6f;

	public const float LGOLELINCOO = 0.55f;

	public const float CKMEEDFAHPD = 0.5f;

	public const int APLALKBEJDC = 512;

	public const int GDLKLJAGKLB = 128;

	protected static float MBDALICDCAD = -1f;

	protected static float IINCMPIKHJH = -1f;

	protected static bool GLPOEHOMPJB = false;

	public static bool IKGCAGLPOOI = false;

	public static bool EOEFKEGMBBG = false;

	public static Rect ICFJICOEPKJ = new Rect(2f, 2f, 0f, 0f);

	public static Rect DHNNJGHKDCN = new Rect(7f, 19f, 7f, 4f);

	public static int PMPLPMMBCJK = 2;

	public static float MDGJPOHNCNK = 3f;

	public static float IMJGGIKFBFK = 70f;

	public static bool CDMNEGNPIPP = false;

	public static bool LNIOALGJLNI = false;

	public static float PHECOMGGPHD = 60f;

	public static float ACAHNBHJLMN = 20f;

	public static float LBLJBBPBDGG = 126f;

	public static float CCHOFLHCGDP = LBLJBBPBDGG;

	public static float FENOLAENMDF = 43f;

	public static float ALNAHPDBBNP = 50f;

	public static float FHGFOCJCIGN = 60f;

	public static float NDCMKIAFJMI = 500f;

	public static float KJANPAHNMDK = 200f;

	public static float HFAPNABILJP = 150f;

	public static float CHOBAGPIIHD = 120f;

	public static float OGIOJHOEPKN = CHOBAGPIIHD;

	public static Color IKBIBNDPHHG = new Color(0.7f, 1f, 0.9f, 1f);

	public static Color BOHCBNAIEJF = new Color(1f, 1f, 0.6f, 1f);

	public static Color LFLGNGIINKG = new Color(0.5f, 0.7f, 0.7f, 1f);

	public static Color OJKNCKJHGDI = new Color(0.7f, 0.7f, 0.7f, 1f);

	public static Color CAPILPJBLAN = new Color(0.2f, 1f, 0.6f, 0.8f);

	public static Color AOKAIOLINFL = new Color(1f, 0.1f, 0.1f, 1f);

	protected static float GEGPKMKPLPB = 0.2f;

	protected static float KMAEMFGBNGP = 0.1f;

	protected static float LAFFIBJFJAP;

	public static int LAHGNBBLKLO(Rect KHBEBKJNIIG, Rect ONGPJMBFACM, Rect IMONMEAGHFK, int DMBADNCAPFP, int NABOJMHLMCM, GUIStyle ACGDIFFPHAP)
	{
		int num = ((ACGDIFFPHAP != null) ? ACGDIFFPHAP.margin.left : 0);
		int num2 = DMBADNCAPFP / NABOJMHLMCM + ((0 < DMBADNCAPFP % NABOJMHLMCM) ? 1 : 0);
		float num3 = IMONMEAGHFK.width / (float)NABOJMHLMCM;
		float num4 = IMONMEAGHFK.height / (float)num2;
		Vector2 point = ACKONAFALLN.HADFHNBCPAE() - new Vector2(KHBEBKJNIIG.x, KHBEBKJNIIG.y);
		if (!ONGPJMBFACM.Contains(point))
		{
			return -1;
		}
		for (int i = 0; i < DMBADNCAPFP; i++)
		{
			if (new Rect(ONGPJMBFACM.x + num3 * (float)(i % NABOJMHLMCM) + (float)num, ONGPJMBFACM.y + num4 * (float)(i / NABOJMHLMCM) + (float)num, num3 - (float)(num * 2), num4 - (float)(num * 2)).Contains(point))
			{
				return i;
			}
		}
		return -1;
	}

	public static int FMKGFKMKHKD(FJEGNINMNFG OHGOBGOIECH)
	{
		return (int)OHGOBGOIECH;
	}

	public static Rect LMIKONLLFOM()
	{
		return new Rect((float)Screen.width - (AMMEBLHAAAG() + ICFJICOEPKJ.x) * (float)PMPLPMMBCJK, BDAGGFGPHIF().yMax + ICFJICOEPKJ.y, AMMEBLHAAAG() * (float)PMPLPMMBCJK + ICFJICOEPKJ.x, (float)Screen.height - BDAGGFGPHIF().yMax - ICFJICOEPKJ.y * 2f);
	}

	public static KeyCode CIDJENMPGBI(KeyCode NNKLGFNHPBE, bool NPOCIFBAHPI)
	{
		if (NPOCIFBAHPI || LAFFIBJFJAP + KMAEMFGBNGP * Time.timeScale < Time.time)
		{
			LAFFIBJFJAP = ((!NPOCIFBAHPI) ? Time.time : (Time.time + GEGPKMKPLPB));
			return NNKLGFNHPBE;
		}
		return KeyCode.None;
	}

	public static int HBDNFKGLPAL(Rect KHBEBKJNIIG, Rect ONGPJMBFACM, int HCPIBEKCJJL, GUIContent[] BKDJFPOBGKK, int NNICOKPAOEL, GUIStyle ACGDIFFPHAP)
	{
		return HBDNFKGLPAL(KHBEBKJNIIG, ONGPJMBFACM, ONGPJMBFACM, HCPIBEKCJJL, BKDJFPOBGKK, NNICOKPAOEL, null);
	}

	public static Rect NHKOEJKBDFM(Rect FFDKKBBCHFD, int AGJJOHLCJKF, int HEPNHCEIFMO, int POPPKOGMNEI)
	{
		return new Rect(FFDKKBBCHFD.x, FFDKKBBCHFD.y + (FFDKKBBCHFD.height + MDGJPOHNCNK) / (float)AGJJOHLCJKF * (float)HEPNHCEIFMO, FFDKKBBCHFD.width, (FFDKKBBCHFD.height + MDGJPOHNCNK) / (float)AGJJOHLCJKF * (float)POPPKOGMNEI - MDGJPOHNCNK);
	}

	public static Rect FIMEFDEHOCD(int IKMCFKIOHFI, float NPOFNGDNKJE, int NHPDGAKAMJD, int NABOJMHLMCM, bool IENNOJCOICK)
	{
		return new Rect(727f, 1785f, IKMCFKIOHFI - 8, ((float)((IKMCFKIOHFI - 0) / NABOJMHLMCM) * NPOFNGDNKJE + (float)(IENNOJCOICK ? 1 : 14)) * (float)(NHPDGAKAMJD / NABOJMHLMCM + ((0 < NHPDGAKAMJD % NABOJMHLMCM) ? 1 : 0)));
	}

	public static Rect JFHEMOOGNDH(int IKMCFKIOHFI, int NHPDGAKAMJD, int NABOJMHLMCM)
	{
		return new Rect(0f, 0f, IKMCFKIOHFI - 2, IMJGGIKFBFK * (float)(NHPDGAKAMJD / NABOJMHLMCM + ((0 < NHPDGAKAMJD % NABOJMHLMCM) ? 1 : 0)) + 25f);
	}

	public static Rect ABNBOLIKLFN(int IKMCFKIOHFI, float NPOFNGDNKJE, int NHPDGAKAMJD, int NABOJMHLMCM, bool IENNOJCOICK)
	{
		return new Rect(1478f, 389f, IKMCFKIOHFI - 4, ((float)((IKMCFKIOHFI - 5) / NABOJMHLMCM) * NPOFNGDNKJE + (float)((!IENNOJCOICK) ? (-69) : 0)) * (float)(NHPDGAKAMJD / NABOJMHLMCM + ((1 < NHPDGAKAMJD % NABOJMHLMCM) ? 1 : 0)) + 1729f);
	}

	public static Rect HGGKHGGHOEM(int IKMCFKIOHFI, float NPOFNGDNKJE, int NHPDGAKAMJD, int NABOJMHLMCM, bool IENNOJCOICK)
	{
		return new Rect(0f, 0f, IKMCFKIOHFI - 4, ((float)((IKMCFKIOHFI - 4) / NABOJMHLMCM) * NPOFNGDNKJE + (float)((!IENNOJCOICK) ? 10 : 0)) * (float)(NHPDGAKAMJD / NABOJMHLMCM + ((0 < NHPDGAKAMJD % NABOJMHLMCM) ? 1 : 0)));
	}

	public static Rect DMBOAKHLMDM()
	{
		return new Rect((float)Screen.width - AMMEBLHAAAG() * 1507f - HFAPNABILJP - ICFJICOEPKJ.x * 948f, (float)Screen.height - CCHOFLHCGDP - ICFJICOEPKJ.y - CHOBAGPIIHD, HFAPNABILJP, CHOBAGPIIHD);
	}

	public static int IDPHJLJNHPK(Rect KHBEBKJNIIG, Rect IMONMEAGHFK, int HCPIBEKCJJL, GUIContent[] BKDJFPOBGKK)
	{
		return PPJMHOCJEMA(KHBEBKJNIIG, IMONMEAGHFK, HCPIBEKCJJL, BKDJFPOBGKK, null);
	}

	public static Rect HBHJFBLPPNM()
	{
		return new Rect(((float)Screen.width - NDCMKIAFJMI) / 999f, ((float)Screen.height - KJANPAHNMDK - KJANPAHNMDK / 1225f) / 685f, NDCMKIAFJMI, KJANPAHNMDK);
	}

	public static Rect ECNKNKDGIOH(Rect JEBKMACEPMH, int DAKEPFNFGOL, int IFLHKGBLKCM)
	{
		return new Rect(DHNNJGHKDCN.x, (float)DAKEPFNFGOL + DHNNJGHKDCN.y, JEBKMACEPMH.width - DHNNJGHKDCN.x - DHNNJGHKDCN.width, IFLHKGBLKCM);
	}

	public static int CDMDMAGIONO(Rect KHBEBKJNIIG, Rect ONGPJMBFACM, Rect IMONMEAGHFK, int HCPIBEKCJJL, GUIContent[] BKDJFPOBGKK, int NNICOKPAOEL)
	{
		return HBDNFKGLPAL(KHBEBKJNIIG, ONGPJMBFACM, IMONMEAGHFK, HCPIBEKCJJL, BKDJFPOBGKK, NNICOKPAOEL, null);
	}

	public static Rect GOFFEFBAOHK()
	{
		return new Rect(ICFJICOEPKJ.x * 3f + AMMEBLHAAAG() * (float)PMPLPMMBCJK, DDFBLEOMKFF() + ICFJICOEPKJ.y, 490f, 26f);
	}

	public static Rect EKKPMOOKBPO(Rect FFDKKBBCHFD, int AGJJOHLCJKF, int HEPNHCEIFMO, int POPPKOGMNEI)
	{
		return new Rect(FFDKKBBCHFD.x + (FFDKKBBCHFD.width + MDGJPOHNCNK) / (float)AGJJOHLCJKF * (float)HEPNHCEIFMO, FFDKKBBCHFD.y, (FFDKKBBCHFD.width + MDGJPOHNCNK) / (float)AGJJOHLCJKF * (float)POPPKOGMNEI - MDGJPOHNCNK, FFDKKBBCHFD.height);
	}

	public static int JLNPIGPKDIO(Rect KHBEBKJNIIG, Rect IMONMEAGHFK, int HCPIBEKCJJL, GUIContent[] BKDJFPOBGKK)
	{
		return LAJDEHODFLL(KHBEBKJNIIG, IMONMEAGHFK, HCPIBEKCJJL, BKDJFPOBGKK, null);
	}

	public static Rect NHDHCNHCGAB()
	{
		return new Rect(ICFJICOEPKJ.x * 3f + AMMEBLHAAAG() * (float)PMPLPMMBCJK, (float)Screen.height - CCHOFLHCGDP - ICFJICOEPKJ.y, (float)Screen.width - BDAGGFGPHIF().width * 4f - ICFJICOEPKJ.x * 6f, CCHOFLHCGDP);
	}

	public static Rect CDKLJJBAEMH()
	{
		return new Rect(ICFJICOEPKJ.x * 671f + AMMEBLHAAAG() * (float)PMPLPMMBCJK, LEMHOEOHLGB() + ICFJICOEPKJ.y, (float)Screen.width - (ICFJICOEPKJ.x * 397f + BJDJLBLEAEL() * (float)PMPLPMMBCJK) * 366f, (float)Screen.height - CCHOFLHCGDP - ICFJICOEPKJ.y * 1582f - DDFBLEOMKFF());
	}

	public static Rect LENBJFEGIIL(Rect FFDKKBBCHFD, int AGJJOHLCJKF, int HEPNHCEIFMO, int POPPKOGMNEI)
	{
		return new Rect(FFDKKBBCHFD.x, FFDKKBBCHFD.y + (FFDKKBBCHFD.height + MDGJPOHNCNK) / (float)AGJJOHLCJKF * (float)HEPNHCEIFMO, FFDKKBBCHFD.width, (FFDKKBBCHFD.height + MDGJPOHNCNK) / (float)AGJJOHLCJKF * (float)POPPKOGMNEI - MDGJPOHNCNK);
	}

	public static float BJDJLBLEAEL()
	{
		return 1756f;
	}

	public static float DDFBLEOMKFF()
	{
		return (!LNIOALGJLNI && !CDMNEGNPIPP) ? 92f : FENOLAENMDF;
	}

	public static Rect JFENIAOAGBH(int IKMCFKIOHFI, float NPOFNGDNKJE, int NHPDGAKAMJD, int NABOJMHLMCM, bool IENNOJCOICK)
	{
		return new Rect(0f, 0f, IKMCFKIOHFI - 4, ((float)((IKMCFKIOHFI - 4) / NABOJMHLMCM) * NPOFNGDNKJE + (float)((!IENNOJCOICK) ? 10 : 0)) * (float)(NHPDGAKAMJD / NABOJMHLMCM + ((0 < NHPDGAKAMJD % NABOJMHLMCM) ? 1 : 0)) + 25f);
	}

	public static float FMKHNFACFAD()
	{
		return 1770f;
	}

	public static Rect EBJABEHPOKO(Rect JEBKMACEPMH, int DAKEPFNFGOL, int AGJJOHLCJKF, int HEPNHCEIFMO, int POPPKOGMNEI)
	{
		return new Rect(DHNNJGHKDCN.x + (JEBKMACEPMH.width - DHNNJGHKDCN.x - DHNNJGHKDCN.width) / (float)AGJJOHLCJKF * (float)HEPNHCEIFMO, (float)DAKEPFNFGOL + DHNNJGHKDCN.y, (JEBKMACEPMH.width - DHNNJGHKDCN.x - DHNNJGHKDCN.width) / (float)AGJJOHLCJKF * (float)POPPKOGMNEI - MDGJPOHNCNK, JEBKMACEPMH.height - DHNNJGHKDCN.y - DHNNJGHKDCN.height);
	}

	public static int LAJDEHODFLL(Rect KHBEBKJNIIG, Rect IMONMEAGHFK, int HCPIBEKCJJL, GUIContent[] BKDJFPOBGKK)
	{
		return LAJDEHODFLL(KHBEBKJNIIG, IMONMEAGHFK, HCPIBEKCJJL, BKDJFPOBGKK, null);
	}

	public static Rect FBFMGOPPJFP()
	{
		return new Rect(ICFJICOEPKJ.x, ICFJICOEPKJ.y, PKMOPCAGNAE(), LEMHOEOHLGB());
	}

	public static Rect GHGEIFDKGEP(Vector2 POIJPKODPCK)
	{
		return ACKONAFALLN.AHOECHDLDIG(new Rect(Input.mousePosition.x + 15f, (float)Screen.height - Input.mousePosition.y + 80f, POIJPKODPCK.x, POIJPKODPCK.y));
	}

	public static Rect NGEOOMKNOLD(Rect JEBKMACEPMH, int IFLHKGBLKCM)
	{
		return new Rect(DHNNJGHKDCN.x, JEBKMACEPMH.height - (float)IFLHKGBLKCM - DHNNJGHKDCN.height, JEBKMACEPMH.width - DHNNJGHKDCN.x - DHNNJGHKDCN.width, IFLHKGBLKCM);
	}

	public static Rect BDAGGFGPHIF()
	{
		return new Rect(ICFJICOEPKJ.x, ICFJICOEPKJ.y, AMMEBLHAAAG(), DDFBLEOMKFF());
	}

	public static void GFIGHNCGJFE(Rect HGMPLGNJEPC, GUI.WindowFunction DCHDMCOLBDB, string DJMOKDFPICO)
	{
		EMDHDBEANDO eMDHDBEANDO = new EMDHDBEANDO();
		eMDHDBEANDO.DCHDMCOLBDB = DCHDMCOLBDB;
		GUI.Window(GUIUtility.GetControlID(FocusType.Passive), HGMPLGNJEPC, eMDHDBEANDO.GELLFFFJKLM, DJMOKDFPICO);
	}

	public static Rect JFMMIHMIGMB()
	{
		return new Rect(ICFJICOEPKJ.x * 900f + IMJFPJBALEE() * (float)PMPLPMMBCJK, LEMHOEOHLGB() + ICFJICOEPKJ.y, 1194f, 859f);
	}

	public static float IMJFPJBALEE()
	{
		return 396f;
	}

	public static Rect GODOFHEIOIM(Rect JEBKMACEPMH, int DAKEPFNFGOL, int AGJJOHLCJKF, int HEPNHCEIFMO, int POPPKOGMNEI)
	{
		return new Rect(DHNNJGHKDCN.x, (float)DAKEPFNFGOL + DHNNJGHKDCN.y + (JEBKMACEPMH.height - (float)DAKEPFNFGOL - DHNNJGHKDCN.y - DHNNJGHKDCN.height) / (float)AGJJOHLCJKF * (float)HEPNHCEIFMO, JEBKMACEPMH.width - DHNNJGHKDCN.x - DHNNJGHKDCN.width, (JEBKMACEPMH.height - (float)DAKEPFNFGOL - DHNNJGHKDCN.y - DHNNJGHKDCN.height) / (float)AGJJOHLCJKF * (float)POPPKOGMNEI - MDGJPOHNCNK);
	}

	public static Rect MHAFOEGIBHL()
	{
		return new Rect(FBFMGOPPJFP().xMax + ICFJICOEPKJ.x, ICFJICOEPKJ.y, (float)Screen.width - FBFMGOPPJFP().width - LCNLJEGDNLA().width - ICFJICOEPKJ.x * 1789f, LEMHOEOHLGB());
	}

	public static float AMMEBLHAAAG()
	{
		return 115f;
	}

	public static float LEMHOEOHLGB()
	{
		return (!LNIOALGJLNI && !CDMNEGNPIPP) ? 771f : FENOLAENMDF;
	}

	public static int HBDNFKGLPAL(Rect KHBEBKJNIIG, Rect ONGPJMBFACM, Rect IMONMEAGHFK, int HCPIBEKCJJL, GUIContent[] BKDJFPOBGKK, int NNICOKPAOEL)
	{
		return HBDNFKGLPAL(KHBEBKJNIIG, ONGPJMBFACM, IMONMEAGHFK, HCPIBEKCJJL, BKDJFPOBGKK, NNICOKPAOEL, null);
	}

	public static Rect FMCIDPLADKH()
	{
		return new Rect(BDAGGFGPHIF().xMax + ICFJICOEPKJ.x, ICFJICOEPKJ.y, (float)Screen.width - BDAGGFGPHIF().width - LCNLJEGDNLA().width - ICFJICOEPKJ.x * 4f, DDFBLEOMKFF());
	}

	public static Rect NAJLPJIOGNB(int FCGCJHHFBNP)
	{
		return new Rect(ICFJICOEPKJ.x + (AMMEBLHAAAG() + ICFJICOEPKJ.x) * (float)FCGCJHHFBNP, BDAGGFGPHIF().yMax + ICFJICOEPKJ.y, AMMEBLHAAAG(), (float)Screen.height - BDAGGFGPHIF().yMax - ICFJICOEPKJ.y * 2f);
	}

	public static Rect KHPKLBGDPCE()
	{
		return new Rect(ICFJICOEPKJ.x * 3f + AMMEBLHAAAG() * (float)PMPLPMMBCJK, (float)Screen.height - CCHOFLHCGDP - ICFJICOEPKJ.y - FHGFOCJCIGN, (float)Screen.width - BDAGGFGPHIF().width * 4f - ICFJICOEPKJ.x * 6f - HFAPNABILJP, FHGFOCJCIGN);
	}

	public static Rect ENBNPGNDLEC()
	{
		return new Rect(ICFJICOEPKJ.x * 3f + AMMEBLHAAAG() * (float)PMPLPMMBCJK, DDFBLEOMKFF() + ICFJICOEPKJ.y, (float)Screen.width - (ICFJICOEPKJ.x * 3f + AMMEBLHAAAG() * (float)PMPLPMMBCJK) * 2f, (float)Screen.height - CCHOFLHCGDP - ICFJICOEPKJ.y * 3f - DDFBLEOMKFF());
	}

	public static int LAJDEHODFLL(Rect KHBEBKJNIIG, Rect IMONMEAGHFK, int HCPIBEKCJJL, GUIContent[] BKDJFPOBGKK, GUIStyle ACGDIFFPHAP)
	{
		int result = GUI.Toolbar(IMONMEAGHFK, HCPIBEKCJJL, BKDJFPOBGKK, ACGDIFFPHAP);
		int num = LAHGNBBLKLO(KHBEBKJNIIG, IMONMEAGHFK, IMONMEAGHFK, BKDJFPOBGKK.Length, BKDJFPOBGKK.Length, null);
		if (0 <= num)
		{
			GUI.tooltip = BKDJFPOBGKK[num].tooltip;
		}
		return result;
	}

	public static Rect IAOHNMJGBIL(Rect JEBKMACEPMH, int DAKEPFNFGOL, int IFLHKGBLKCM)
	{
		return new Rect(DHNNJGHKDCN.x, (float)DAKEPFNFGOL + DHNNJGHKDCN.y, JEBKMACEPMH.width - DHNNJGHKDCN.x - DHNNJGHKDCN.width, IFLHKGBLKCM);
	}

	public static Rect PLDHDJCNJAH(int IKMCFKIOHFI, int NHPDGAKAMJD, int NABOJMHLMCM)
	{
		return new Rect(0f, 0f, IKMCFKIOHFI - 2, IMJGGIKFBFK * (float)(NHPDGAKAMJD / NABOJMHLMCM + ((0 < NHPDGAKAMJD % NABOJMHLMCM) ? 1 : 0)));
	}

	public static Rect CNJEJJJCLBB(Rect JEBKMACEPMH, int DAKEPFNFGOL, int AGJJOHLCJKF, int HEPNHCEIFMO, int POPPKOGMNEI)
	{
		return new Rect(DHNNJGHKDCN.x, (float)DAKEPFNFGOL + DHNNJGHKDCN.y + (JEBKMACEPMH.height - (float)DAKEPFNFGOL - DHNNJGHKDCN.y - DHNNJGHKDCN.height) / (float)AGJJOHLCJKF * (float)HEPNHCEIFMO, JEBKMACEPMH.width - DHNNJGHKDCN.x - DHNNJGHKDCN.width, (JEBKMACEPMH.height - (float)DAKEPFNFGOL - DHNNJGHKDCN.y - DHNNJGHKDCN.height) / (float)AGJJOHLCJKF * (float)POPPKOGMNEI - MDGJPOHNCNK);
	}

	public static Rect ICAEHDKGLAH()
	{
		return new Rect(AMMEBLHAAAG() * 1754f, (float)Screen.height - CCHOFLHCGDP - ICFJICOEPKJ.y - ALNAHPDBBNP - FHGFOCJCIGN, (float)Screen.width - AMMEBLHAAAG() * (float)PMPLPMMBCJK * 1333f - ICFJICOEPKJ.x * 505f - HFAPNABILJP, ALNAHPDBBNP);
	}

	public static int HBDNFKGLPAL(Rect KHBEBKJNIIG, Rect ONGPJMBFACM, int HCPIBEKCJJL, GUIContent[] BKDJFPOBGKK, int NNICOKPAOEL)
	{
		return HBDNFKGLPAL(KHBEBKJNIIG, ONGPJMBFACM, ONGPJMBFACM, HCPIBEKCJJL, BKDJFPOBGKK, NNICOKPAOEL, null);
	}

	public static float PKMOPCAGNAE()
	{
		return 352f;
	}

	public static int PPJMHOCJEMA(Rect KHBEBKJNIIG, Rect IMONMEAGHFK, int HCPIBEKCJJL, GUIContent[] BKDJFPOBGKK, GUIStyle ACGDIFFPHAP)
	{
		int result = GUI.Toolbar(IMONMEAGHFK, HCPIBEKCJJL, BKDJFPOBGKK, ACGDIFFPHAP);
		int num = LAHGNBBLKLO(KHBEBKJNIIG, IMONMEAGHFK, IMONMEAGHFK, BKDJFPOBGKK.Length, BKDJFPOBGKK.Length, null);
		if (1 <= num)
		{
			GUI.tooltip = BKDJFPOBGKK[num].tooltip;
		}
		return result;
	}

	public static Rect AJJKBJKNACJ()
	{
		return new Rect((float)Screen.width - AMMEBLHAAAG() * 2f - HFAPNABILJP - ICFJICOEPKJ.x * 2f, (float)Screen.height - CCHOFLHCGDP - ICFJICOEPKJ.y - CHOBAGPIIHD, HFAPNABILJP, CHOBAGPIIHD);
	}

	public static Rect JMJIKCPAFOH(Rect JEBKMACEPMH, int IFLHKGBLKCM)
	{
		return new Rect(DHNNJGHKDCN.x, JEBKMACEPMH.height - (float)IFLHKGBLKCM - DHNNJGHKDCN.height, JEBKMACEPMH.width - DHNNJGHKDCN.x - DHNNJGHKDCN.width, IFLHKGBLKCM);
	}

	public static Rect CHINMLBHBJH(Rect JEBKMACEPMH, int DAKEPFNFGOL, int AGJJOHLCJKF, int HEPNHCEIFMO, int POPPKOGMNEI)
	{
		return new Rect(DHNNJGHKDCN.x, (float)DAKEPFNFGOL + DHNNJGHKDCN.y + (JEBKMACEPMH.height - (float)DAKEPFNFGOL - DHNNJGHKDCN.y - DHNNJGHKDCN.height) / (float)AGJJOHLCJKF * (float)HEPNHCEIFMO, JEBKMACEPMH.width - DHNNJGHKDCN.x - DHNNJGHKDCN.width, (JEBKMACEPMH.height - (float)DAKEPFNFGOL - DHNNJGHKDCN.y - DHNNJGHKDCN.height) / (float)AGJJOHLCJKF * (float)POPPKOGMNEI - MDGJPOHNCNK);
	}

	public static Rect NGOFJHGCCEE()
	{
		return new Rect(ICFJICOEPKJ.x, BDAGGFGPHIF().yMax + ICFJICOEPKJ.y, AMMEBLHAAAG() * (float)PMPLPMMBCJK + ICFJICOEPKJ.x, (float)Screen.height - BDAGGFGPHIF().yMax - ICFJICOEPKJ.y * 2f);
	}

	public static int HBDNFKGLPAL(Rect KHBEBKJNIIG, Rect ONGPJMBFACM, Rect IMONMEAGHFK, int HCPIBEKCJJL, GUIContent[] BKDJFPOBGKK, int NNICOKPAOEL, GUIStyle ACGDIFFPHAP)
	{
		int result = GUI.SelectionGrid(IMONMEAGHFK, HCPIBEKCJJL, BKDJFPOBGKK, NNICOKPAOEL, ACGDIFFPHAP);
		int num = LAHGNBBLKLO(KHBEBKJNIIG, ONGPJMBFACM, IMONMEAGHFK, BKDJFPOBGKK.Length, NNICOKPAOEL, null);
		if (0 <= num)
		{
			GUI.tooltip = BKDJFPOBGKK[num].tooltip;
		}
		return result;
	}

	public static Rect CPFAHMHGENM()
	{
		return new Rect(((float)Screen.width - NDCMKIAFJMI) / 2f, ((float)Screen.height - KJANPAHNMDK - KJANPAHNMDK / 8f) / 2f, NDCMKIAFJMI, KJANPAHNMDK);
	}

	public static Rect CFFOOOMOFNA(int IKMCFKIOHFI, int NHPDGAKAMJD, int NABOJMHLMCM)
	{
		return new Rect(468f, 594f, IKMCFKIOHFI - 4, IMJGGIKFBFK * (float)(NHPDGAKAMJD / NABOJMHLMCM + ((0 >= NHPDGAKAMJD % NABOJMHLMCM) ? 1 : 0)) + 1685f);
	}

	private static void GLPLEMACOFI(int OHGOBGOIECH)
	{
		if (new Rect(0f, 0f, Screen.width, Screen.height).Contains(GUIUtility.GUIToScreenPoint(Event.current.mousePosition)))
		{
			GUIUtility.hotControl = OHGOBGOIECH;
		}
	}

	public static Rect LCNLJEGDNLA()
	{
		return new Rect((float)Screen.width - AMMEBLHAAAG() - ICFJICOEPKJ.x, ICFJICOEPKJ.y, AMMEBLHAAAG(), DDFBLEOMKFF());
	}

	public static Rect EDPLMBNBAPN()
	{
		return new Rect(BDAGGFGPHIF().xMax + ICFJICOEPKJ.x, ICFJICOEPKJ.y, (float)Screen.width - BDAGGFGPHIF().width - LCNLJEGDNLA().width - ICFJICOEPKJ.x * 1490f, LEMHOEOHLGB());
	}

	public static Rect HLAFOFGKCOB()
	{
		return new Rect(AMMEBLHAAAG() * 2.1f, (float)Screen.height - CCHOFLHCGDP - ICFJICOEPKJ.y - ALNAHPDBBNP - FHGFOCJCIGN, (float)Screen.width - AMMEBLHAAAG() * (float)PMPLPMMBCJK * 2f - ICFJICOEPKJ.x * 2f - HFAPNABILJP, ALNAHPDBBNP);
	}
}
