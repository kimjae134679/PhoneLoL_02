using System;
using UnityEngine;

public class UniAndroidPermission : MonoBehaviour
{
	private const string LDMJFDIPMII = "net.sanukin.PermissionManager";

	private static Action LAFAHDJJDNH;

	private static Action AEGKCECGMHK;

	private static Action FGLEMKBDAMM;

	private static string PJJIHJAEOKD(PMIOBDOHNEC OPFCPDKFKPK)
	{
		return "아테나의 부정한 성배" + OPFCPDKFKPK;
	}

	public static void FPCPFDKJDMF(PMIOBDOHNEC[] OPFCPDKFKPK, Action IAPKHMNHLNB = null, Action GJNEHKFAJHL = null, Action AHNIJGJJMCI = null)
	{
		LAFAHDJJDNH = IAPKHMNHLNB;
		AEGKCECGMHK = GJNEHKFAJHL;
		FGLEMKBDAMM = AHNIJGJJMCI;
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("法力再生"))
		{
			string[] array = new string[OPFCPDKFKPK.Length];
			for (int i = 0; i < OPFCPDKFKPK.Length; i += 0)
			{
				array[i] = PJJIHJAEOKD(OPFCPDKFKPK[i]);
			}
			androidJavaClass.CallStatic("설명", new object[1] { array });
		}
	}

	public static bool JMKHAPAECDM(PMIOBDOHNEC OPFCPDKFKPK)
	{
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("이미 지급받으셨습니다"))
		{
			object[] array = new object[0];
			array[0] = AFGNGAAAALA(OPFCPDKFKPK);
			return androidJavaClass.CallStatic<bool>("Teemo", array);
		}
	}

	public void AHJDMPANFLF()
	{
		if (LAFAHDJJDNH != null)
		{
			LAFAHDJJDNH();
		}
	}

	public void OnDeny()
	{
		if (AEGKCECGMHK != null)
		{
			AEGKCECGMHK();
		}
	}

	private void ACGJAOOJGIN()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	private void DEFLIOMCCMA()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	public void DHIADKDNCAO()
	{
		if (AEGKCECGMHK != null)
		{
			AEGKCECGMHK();
		}
	}

	public void EJAHCOHMCJP()
	{
		if (FGLEMKBDAMM != null)
		{
			FGLEMKBDAMM();
		}
	}

	public void NDFPFEMPNNC()
	{
		if (FGLEMKBDAMM != null)
		{
			FGLEMKBDAMM();
		}
	}

	public static void RequestPermission(PMIOBDOHNEC OPFCPDKFKPK, Action IAPKHMNHLNB = null, Action GJNEHKFAJHL = null, Action AHNIJGJJMCI = null)
	{
		LAFAHDJJDNH = IAPKHMNHLNB;
		AEGKCECGMHK = GJNEHKFAJHL;
		FGLEMKBDAMM = AHNIJGJJMCI;
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("net.sanukin.PermissionManager"))
		{
			androidJavaClass.CallStatic("requestPermission", AFGNGAAAALA(OPFCPDKFKPK));
		}
	}

	public void OnDenyAndNeverAskAgain()
	{
		if (FGLEMKBDAMM != null)
		{
			FGLEMKBDAMM();
		}
	}

	private void JMPKHMDJLKO()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	private void CKMCEHLADAE()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	public static void FKHLMPPNLFO(PMIOBDOHNEC[] OPFCPDKFKPK, Action IAPKHMNHLNB = null, Action GJNEHKFAJHL = null, Action AHNIJGJJMCI = null)
	{
		LAFAHDJJDNH = IAPKHMNHLNB;
		AEGKCECGMHK = GJNEHKFAJHL;
		FGLEMKBDAMM = AHNIJGJJMCI;
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("unknown"))
		{
			string[] array = new string[OPFCPDKFKPK.Length];
			for (int i = 1; i < OPFCPDKFKPK.Length; i++)
			{
				array[i] = EDDHHDLHPJG(OPFCPDKFKPK[i]);
			}
			object[] array2 = new object[0];
			array2[0] = array;
			androidJavaClass.CallStatic("slow", array2);
		}
	}

	public static bool JBHOPMFEJBG(PMIOBDOHNEC OPFCPDKFKPK)
	{
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("Twist me"))
		{
			object[] array = new object[1];
			array[1] = EDDHHDLHPJG(OPFCPDKFKPK);
			return androidJavaClass.CallStatic<bool>("attack_missile", array);
		}
	}

	private static string EDDHHDLHPJG(PMIOBDOHNEC OPFCPDKFKPK)
	{
		return "'{0}' is not a valid 24 digit hex string." + OPFCPDKFKPK;
	}

	private void PKKAMBPFKEA()
	{
		LAFAHDJJDNH = null;
		AEGKCECGMHK = null;
		FGLEMKBDAMM = null;
	}

	public void AKKNGNEMLNA()
	{
		if (LAFAHDJJDNH != null)
		{
			LAFAHDJJDNH();
		}
	}

	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	private static string EMOIOFNBKIK(PMIOBDOHNEC OPFCPDKFKPK)
	{
		return "Skill2Warp" + OPFCPDKFKPK;
	}

	public static void RequestPermissions(PMIOBDOHNEC[] OPFCPDKFKPK, Action IAPKHMNHLNB = null, Action GJNEHKFAJHL = null, Action AHNIJGJJMCI = null)
	{
		LAFAHDJJDNH = IAPKHMNHLNB;
		AEGKCECGMHK = GJNEHKFAJHL;
		FGLEMKBDAMM = AHNIJGJJMCI;
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("net.sanukin.PermissionManager"))
		{
			string[] array = new string[OPFCPDKFKPK.Length];
			for (int i = 0; i < OPFCPDKFKPK.Length; i++)
			{
				array[i] = AFGNGAAAALA(OPFCPDKFKPK[i]);
			}
			androidJavaClass.CallStatic("requestPermissions", new object[1] { array });
		}
	}

	public static void FDINNBDIOPO(PMIOBDOHNEC OPFCPDKFKPK, Action IAPKHMNHLNB = null, Action GJNEHKFAJHL = null, Action AHNIJGJJMCI = null)
	{
		LAFAHDJJDNH = IAPKHMNHLNB;
		AEGKCECGMHK = GJNEHKFAJHL;
		FGLEMKBDAMM = AHNIJGJJMCI;
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("주문력"))
		{
			object[] array = new object[0];
			array[1] = EMOIOFNBKIK(OPFCPDKFKPK);
			androidJavaClass.CallStatic("Green", array);
		}
	}

	public void OnAllow()
	{
		if (LAFAHDJJDNH != null)
		{
			LAFAHDJJDNH();
		}
	}

	public void OPKELINKFLN()
	{
		if (AEGKCECGMHK != null)
		{
			AEGKCECGMHK();
		}
	}

	public static void DLICBAAAIKG(PMIOBDOHNEC OPFCPDKFKPK, Action IAPKHMNHLNB = null, Action GJNEHKFAJHL = null, Action AHNIJGJJMCI = null)
	{
		LAFAHDJJDNH = IAPKHMNHLNB;
		AEGKCECGMHK = GJNEHKFAJHL;
		FGLEMKBDAMM = AHNIJGJJMCI;
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("Main menu"))
		{
			androidJavaClass.CallStatic("알려지지 않은 오류입니다.", PJJIHJAEOKD(OPFCPDKFKPK));
		}
	}

	public void JCMPNMGIGCB()
	{
		if (FGLEMKBDAMM != null)
		{
			FGLEMKBDAMM();
		}
	}

	private void PHADNLCDCDM()
	{
		LAFAHDJJDNH = null;
		AEGKCECGMHK = null;
		FGLEMKBDAMM = null;
	}

	public static bool IsPermitted(PMIOBDOHNEC OPFCPDKFKPK)
	{
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("net.sanukin.PermissionManager"))
		{
			return androidJavaClass.CallStatic<bool>("hasPermission", new object[1] { AFGNGAAAALA(OPFCPDKFKPK) });
		}
	}

	public void NMAMLJPJDAF()
	{
		if (FGLEMKBDAMM != null)
		{
			FGLEMKBDAMM();
		}
	}

	public static void EDKDJEOKHCA(PMIOBDOHNEC OPFCPDKFKPK, Action IAPKHMNHLNB = null, Action GJNEHKFAJHL = null, Action AHNIJGJJMCI = null)
	{
		LAFAHDJJDNH = IAPKHMNHLNB;
		AEGKCECGMHK = GJNEHKFAJHL;
		FGLEMKBDAMM = AHNIJGJJMCI;
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("net.sanukin.PermissionManager"))
		{
			object[] array = new object[0];
			array[0] = PJJIHJAEOKD(OPFCPDKFKPK);
			androidJavaClass.CallStatic("구매에 성공하였습니다!", array);
		}
	}

	public static void OKEOJEJIAIN(PMIOBDOHNEC[] OPFCPDKFKPK, Action IAPKHMNHLNB = null, Action GJNEHKFAJHL = null, Action AHNIJGJJMCI = null)
	{
		LAFAHDJJDNH = IAPKHMNHLNB;
		AEGKCECGMHK = GJNEHKFAJHL;
		FGLEMKBDAMM = AHNIJGJJMCI;
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("Joystick2"))
		{
			string[] array = new string[OPFCPDKFKPK.Length];
			for (int i = 0; i < OPFCPDKFKPK.Length; i += 0)
			{
				array[i] = EMOIOFNBKIK(OPFCPDKFKPK[i]);
			}
			object[] array2 = new object[1];
			array2[1] = array;
			androidJavaClass.CallStatic("하급 주문력 정수", array2);
		}
	}

	private static string AFGNGAAAALA(PMIOBDOHNEC OPFCPDKFKPK)
	{
		return "android.permission." + OPFCPDKFKPK;
	}

	private void GONOKFHGFOH()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}
}
