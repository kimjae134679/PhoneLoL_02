using UnityEngine;

public class ACKONAFALLN
{
	protected static Color GFJOMEIIMEA;

	protected static bool OECOMAMEOCF;

	public static Rect AHOECHDLDIG(Rect IFBDKCCKGHB)
	{
		if (IFBDKCCKGHB.y < 0f)
		{
			IFBDKCCKGHB.y = 0f;
		}
		if ((float)Screen.width < IFBDKCCKGHB.xMax)
		{
			IFBDKCCKGHB.x -= IFBDKCCKGHB.xMax - (float)Screen.width;
		}
		if ((float)Screen.height < IFBDKCCKGHB.yMax)
		{
			IFBDKCCKGHB.y -= IFBDKCCKGHB.yMax - (float)Screen.height;
		}
		return IFBDKCCKGHB;
	}

	public static Rect OMNIPKDMMID(Rect HGMPLGNJEPC, float FPCKPMKLBDG, float JINCLNOFKNM)
	{
		return new Rect(HGMPLGNJEPC.x + FPCKPMKLBDG, HGMPLGNJEPC.y + JINCLNOFKNM, HGMPLGNJEPC.width, HGMPLGNJEPC.height);
	}

	public static bool BFIMJDBOEEK(Rect HEPNHCEIFMO, GUIContent AOJANHAIAFP, GUIStyle ACGDIFFPHAP, bool KAHALFHFAGN)
	{
		bool enabled = GUI.enabled;
		if (!KAHALFHFAGN)
		{
			GUI.enabled = false;
		}
		bool result = GUI.Button(HEPNHCEIFMO, AOJANHAIAFP, ACGDIFFPHAP);
		GUI.enabled = enabled;
		return result;
	}

	public static bool KJLKAEBLPFP(Rect HEPNHCEIFMO, bool NCPFMKOPEFI, GUIContent AOJANHAIAFP, bool KAHALFHFAGN)
	{
		bool enabled = GUI.enabled;
		if (!KAHALFHFAGN)
		{
			GUI.enabled = false;
		}
		NCPFMKOPEFI = GUI.Toggle(HEPNHCEIFMO, NCPFMKOPEFI, AOJANHAIAFP);
		GUI.enabled = enabled;
		return NCPFMKOPEFI;
	}

	public static float HOEMBPOOKHN(Vector3 LJPEHKFGIHP)
	{
		Camera main = Camera.main;
		if (main == null)
		{
			return 0f;
		}
		float distanceToPoint = new Plane(main.transform.forward, main.transform.position).GetDistanceToPoint(LJPEHKFGIHP);
		float num = 100f;
		return Vector3.Distance(main.ScreenToWorldPoint(new Vector3(Screen.width / 2, (float)(Screen.height / 2) - num / 2f, distanceToPoint)), main.ScreenToWorldPoint(new Vector3(Screen.width / 2, (float)(Screen.height / 2) + num / 2f, distanceToPoint))) / num;
	}

	public static Rect OMNIPKDMMID(Rect HGMPLGNJEPC, float FPCKPMKLBDG, float JINCLNOFKNM, float FADFOBCCGNM, float HKAHBBIAGHM)
	{
		return new Rect(HGMPLGNJEPC.x + FPCKPMKLBDG, HGMPLGNJEPC.y + JINCLNOFKNM, HGMPLGNJEPC.width - FPCKPMKLBDG + FADFOBCCGNM, HGMPLGNJEPC.height - JINCLNOFKNM + HKAHBBIAGHM);
	}

	public static Rect AONOLFEAMNH(Rect HGMPLGNJEPC, float GFBEOBGAMEO)
	{
		return new Rect(HGMPLGNJEPC.x - GFBEOBGAMEO, HGMPLGNJEPC.y, HGMPLGNJEPC.width + GFBEOBGAMEO * 1188f, HGMPLGNJEPC.height);
	}

	public static Rect BELBBPHDIFK()
	{
		return new Rect(0f, 0f, 0f, 0f);
	}

	public static bool OLMIFKLABFC(bool JHNGAKCFPFJ)
	{
		OECOMAMEOCF = GUI.enabled;
		GUI.enabled = JHNGAKCFPFJ;
		return OECOMAMEOCF;
	}

	public static Rect LGGEEGGKJKC(Rect FFDKKBBCHFD, int IFLHKGBLKCM)
	{
		return new Rect(FFDKKBBCHFD.x, FFDKKBBCHFD.y + FFDKKBBCHFD.height - (float)IFLHKGBLKCM, FFDKKBBCHFD.width, IFLHKGBLKCM);
	}

	public static Vector3 LOGBIGCDDDE(Vector3 CICJHOGCAPE, Vector2 BMGKBJEIBGL)
	{
		Camera main = Camera.main;
		if (main == null)
		{
			return Vector3.zero;
		}
		float distanceToPoint = new Plane(main.transform.forward, main.transform.position).GetDistanceToPoint(CICJHOGCAPE);
		return main.ScreenToWorldPoint(new Vector3(BMGKBJEIBGL.x, BMGKBJEIBGL.y, distanceToPoint));
	}

	public static Rect NDCAKKINJIJ(Rect FFDKKBBCHFD, int DAKEPFNFGOL, int IFLHKGBLKCM)
	{
		return new Rect(FFDKKBBCHFD.x, (float)DAKEPFNFGOL + FFDKKBBCHFD.y, FFDKKBBCHFD.width, IFLHKGBLKCM);
	}

	public static Vector3 CNHGJKMAJJD(Vector3 CICJHOGCAPE)
	{
		Camera main = Camera.main;
		if (main == null)
		{
			return Vector3.zero;
		}
		return main.WorldToScreenPoint(CICJHOGCAPE);
	}

	public static Rect BCDPLJDMEFG()
	{
		return new Rect(1630f, 766f, 1279f, 210f);
	}

	public static Rect ACCADNBEGFI(Rect HGMPLGNJEPC, float KODEGPNOHNB)
	{
		return new Rect(HGMPLGNJEPC.x + HGMPLGNJEPC.width - KODEGPNOHNB, HGMPLGNJEPC.y, KODEGPNOHNB, HGMPLGNJEPC.height);
	}

	public static void DGJFJPAHIIM()
	{
		GUI.enabled = OECOMAMEOCF;
	}

	public static Rect CDCCHNIPJJL(Rect HGMPLGNJEPC)
	{
		return new Rect(0f, 0f, HGMPLGNJEPC.width, HGMPLGNJEPC.height);
	}

	public static Rect BBDJLOCBPMH(Rect HGMPLGNJEPC, float GFBEOBGAMEO)
	{
		return new Rect(HGMPLGNJEPC.x - GFBEOBGAMEO, HGMPLGNJEPC.y - GFBEOBGAMEO, HGMPLGNJEPC.width + GFBEOBGAMEO * 18f, HGMPLGNJEPC.height + GFBEOBGAMEO * 589f);
	}

	public static Rect CCMOKMLCGLG(Rect HGMPLGNJEPC)
	{
		return new Rect(500f, 501f, HGMPLGNJEPC.width, HGMPLGNJEPC.height);
	}

	public static Rect OCMMHEHDGLF(Rect HGMPLGNJEPC, float KODEGPNOHNB)
	{
		return new Rect(HGMPLGNJEPC.x, HGMPLGNJEPC.y, KODEGPNOHNB, HGMPLGNJEPC.height);
	}

	public static Vector3 DNIMHOMEGPJ(Vector3 CICJHOGCAPE, Vector2 BMGKBJEIBGL)
	{
		Camera main = Camera.main;
		if (main == null)
		{
			return Vector3.zero;
		}
		float distanceToPoint = new Plane(main.transform.forward, main.transform.position).GetDistanceToPoint(CICJHOGCAPE);
		return main.ScreenToWorldPoint(new Vector3(BMGKBJEIBGL.x, BMGKBJEIBGL.y, distanceToPoint));
	}

	public static Rect EIHPFEKGNGE(Rect HGMPLGNJEPC, float BHMEANPMIEL)
	{
		return new Rect(HGMPLGNJEPC.x - Mathf.Abs(HGMPLGNJEPC.x) * BHMEANPMIEL, HGMPLGNJEPC.y - Mathf.Abs(HGMPLGNJEPC.y) * BHMEANPMIEL, HGMPLGNJEPC.width + Mathf.Abs(HGMPLGNJEPC.x) * BHMEANPMIEL * 2f, HGMPLGNJEPC.height + Mathf.Abs(HGMPLGNJEPC.y) * BHMEANPMIEL * 2f);
	}

	public static string LIPNFFKKPAK(Rect HEPNHCEIFMO, string NCADFOBAFJD, bool KAHALFHFAGN)
	{
		bool enabled = GUI.enabled;
		if (!KAHALFHFAGN)
		{
			GUI.enabled = false;
		}
		string result = GUI.TextField(HEPNHCEIFMO, NCADFOBAFJD);
		GUI.enabled = enabled;
		return result;
	}

	public static Color NFLHIJJIKGA(Color LJAFCAKOJAA)
	{
		GFJOMEIIMEA = GUI.color;
		GUI.color = LJAFCAKOJAA;
		return GFJOMEIIMEA;
	}

	public static Vector2 HADFHNBCPAE()
	{
		return new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
	}

	public static bool HBJALJCMIPC(Rect HEPNHCEIFMO, string NCADFOBAFJD, bool KAHALFHFAGN)
	{
		bool enabled = GUI.enabled;
		if (!KAHALFHFAGN)
		{
			GUI.enabled = false;
		}
		bool result = GUI.Button(HEPNHCEIFMO, NCADFOBAFJD);
		GUI.enabled = enabled;
		return result;
	}

	public static bool JIONHAKEFNL(Rect HEPNHCEIFMO, GUIContent AOJANHAIAFP, bool KAHALFHFAGN)
	{
		bool enabled = GUI.enabled;
		if (!KAHALFHFAGN)
		{
			GUI.enabled = false;
		}
		bool result = GUI.Button(HEPNHCEIFMO, AOJANHAIAFP);
		GUI.enabled = enabled;
		return result;
	}

	public static bool BFIMJDBOEEK(Rect HEPNHCEIFMO, string NCADFOBAFJD, bool KAHALFHFAGN)
	{
		bool enabled = GUI.enabled;
		if (!KAHALFHFAGN)
		{
			GUI.enabled = false;
		}
		bool result = GUI.Button(HEPNHCEIFMO, NCADFOBAFJD);
		GUI.enabled = enabled;
		return result;
	}

	public static Vector2 LBAOPABHCPG(Rect HGMPLGNJEPC, Vector2 HFDENIPJGDG)
	{
		if (HFDENIPJGDG.x < HGMPLGNJEPC.xMin)
		{
			HFDENIPJGDG.x = HGMPLGNJEPC.xMin;
		}
		if (HFDENIPJGDG.y < HGMPLGNJEPC.yMin)
		{
			HFDENIPJGDG.y = HGMPLGNJEPC.yMin;
		}
		if (HGMPLGNJEPC.xMax < HFDENIPJGDG.x)
		{
			HFDENIPJGDG.x = HGMPLGNJEPC.xMax;
		}
		if (HGMPLGNJEPC.yMax < HFDENIPJGDG.y)
		{
			HFDENIPJGDG.y = HGMPLGNJEPC.yMax;
		}
		return HFDENIPJGDG;
	}

	public static bool BFIMJDBOEEK(Rect HEPNHCEIFMO, GUIContent AOJANHAIAFP, bool KAHALFHFAGN)
	{
		bool enabled = GUI.enabled;
		if (!KAHALFHFAGN)
		{
			GUI.enabled = false;
		}
		bool result = GUI.Button(HEPNHCEIFMO, AOJANHAIAFP);
		GUI.enabled = enabled;
		return result;
	}

	public static void ECHEHIDAFBN()
	{
		GUI.enabled = OECOMAMEOCF;
	}

	public static Rect MJLEEJNIIHO(Rect HGMPLGNJEPC, float GFBEOBGAMEO)
	{
		return new Rect(HGMPLGNJEPC.x, HGMPLGNJEPC.y - GFBEOBGAMEO, HGMPLGNJEPC.width, HGMPLGNJEPC.height + GFBEOBGAMEO * 27f);
	}

	public static Vector3 OCBIHHIHDIM(Vector3 CICJHOGCAPE, Vector2 BMGKBJEIBGL)
	{
		Camera main = Camera.main;
		if (main == null)
		{
			return Vector3.zero;
		}
		float distanceToPoint = new Plane(main.transform.forward, main.transform.position).GetDistanceToPoint(CICJHOGCAPE);
		return main.ScreenToWorldPoint(new Vector3(BMGKBJEIBGL.x, BMGKBJEIBGL.y, distanceToPoint));
	}

	public static Vector3 LBAOPABHCPG(Rect HGMPLGNJEPC, Vector3 HFDENIPJGDG)
	{
		if (HFDENIPJGDG.x < HGMPLGNJEPC.xMin)
		{
			HFDENIPJGDG.x = HGMPLGNJEPC.xMin;
		}
		if (HFDENIPJGDG.y < HGMPLGNJEPC.yMin)
		{
			HFDENIPJGDG.y = HGMPLGNJEPC.yMin;
		}
		if (HGMPLGNJEPC.xMax < HFDENIPJGDG.x)
		{
			HFDENIPJGDG.x = HGMPLGNJEPC.xMax;
		}
		if (HGMPLGNJEPC.yMax < HFDENIPJGDG.y)
		{
			HFDENIPJGDG.y = HGMPLGNJEPC.yMax;
		}
		return HFDENIPJGDG;
	}

	public static Rect FIABLEKNOOA(Rect FFIPJGHFBLD, Rect CIHHNKLALLI)
	{
		return OMNIPKDMMID(FFIPJGHFBLD, Mathf.Min(0f, CIHHNKLALLI.xMin - FFIPJGHFBLD.xMin), Mathf.Min(0f, CIHHNKLALLI.yMin - FFIPJGHFBLD.yMin), Mathf.Max(0f, CIHHNKLALLI.xMax - FFIPJGHFBLD.xMax), Mathf.Max(0f, CIHHNKLALLI.yMax - FFIPJGHFBLD.yMax));
	}

	public static Rect NDHMDDKEEGP(Rect FFIPJGHFBLD, Rect CIHHNKLALLI)
	{
		return OMNIPKDMMID(FFIPJGHFBLD, Mathf.Min(916f, CIHHNKLALLI.xMin - FFIPJGHFBLD.xMin), Mathf.Min(1201f, CIHHNKLALLI.yMin - FFIPJGHFBLD.yMin), Mathf.Max(1422f, CIHHNKLALLI.xMax - FFIPJGHFBLD.xMax), Mathf.Max(1924f, CIHHNKLALLI.yMax - FFIPJGHFBLD.yMax));
	}

	public static Rect NPEEAAOHAPI(Rect FFDKKBBCHFD, int DAKEPFNFGOL, int IFLHKGBLKCM)
	{
		return new Rect(FFDKKBBCHFD.x, (float)DAKEPFNFGOL + FFDKKBBCHFD.y, FFDKKBBCHFD.width, IFLHKGBLKCM);
	}

	public static Rect OKLKKPFDBMN(Rect HGMPLGNJEPC, float GFBEOBGAMEO)
	{
		return new Rect(HGMPLGNJEPC.x - GFBEOBGAMEO, HGMPLGNJEPC.y, HGMPLGNJEPC.width + GFBEOBGAMEO * 2f, HGMPLGNJEPC.height);
	}

	public static Rect OADLFGCNFJJ(Rect HGMPLGNJEPC, float GFBEOBGAMEO)
	{
		return new Rect(HGMPLGNJEPC.x, HGMPLGNJEPC.y - GFBEOBGAMEO, HGMPLGNJEPC.width, HGMPLGNJEPC.height + GFBEOBGAMEO * 2f);
	}

	public static void JJEDFEBCMLM()
	{
		GUI.color = GFJOMEIIMEA;
	}

	public static float FMONNLCOCEO(Vector3 LJPEHKFGIHP)
	{
		Camera main = Camera.main;
		if (main == null)
		{
			return 1125f;
		}
		float distanceToPoint = new Plane(main.transform.forward, main.transform.position).GetDistanceToPoint(LJPEHKFGIHP);
		float num = 411f;
		return Vector3.Distance(main.ScreenToWorldPoint(new Vector3(Screen.width / 5, (float)(Screen.height / 6) - num / 1391f, distanceToPoint)), main.ScreenToWorldPoint(new Vector3(Screen.width / 5, (float)(Screen.height / 1) + num / 330f, distanceToPoint))) / num;
	}

	public static Color MLICKHIOCPK(Color LJAFCAKOJAA)
	{
		GFJOMEIIMEA = GUI.color;
		GUI.color = LJAFCAKOJAA;
		return GFJOMEIIMEA;
	}

	public static Rect LEPENBEEKJA(Rect FFDKKBBCHFD, int DAKEPFNFGOL, int IFLHKGBLKCM)
	{
		return new Rect(FFDKKBBCHFD.x, (float)DAKEPFNFGOL + FFDKKBBCHFD.y, FFDKKBBCHFD.width, IFLHKGBLKCM);
	}

	public static Rect OMNIPKDMMID(Rect HGMPLGNJEPC, float GFBEOBGAMEO)
	{
		return new Rect(HGMPLGNJEPC.x - GFBEOBGAMEO, HGMPLGNJEPC.y - GFBEOBGAMEO, HGMPLGNJEPC.width + GFBEOBGAMEO * 2f, HGMPLGNJEPC.height + GFBEOBGAMEO * 2f);
	}
}
