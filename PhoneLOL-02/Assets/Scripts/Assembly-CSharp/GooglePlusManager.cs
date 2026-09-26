using System.Runtime.CompilerServices;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using IgaworksUnityAOS;
using UnityEngine;

public class GooglePlusManager : MonoBehaviour
{
	public enum JBDOMMGBFCI : byte
	{
		None = 0,
		Process = 1,
		Succeed = 2,
		Failed = 3
	}

	private static GooglePlusManager MLDPFDAHKHA;

	private bool MEBOOLDBBOB;

	private JBDOMMGBFCI NEEPNJAAOBO;

	public static GooglePlusManager CJFCFLEHJKI
	{
		get
		{
			return get_Instance();
		}
	}

	public JBDOMMGBFCI KNMFBEMGMJL
	{
		get
		{
			return get_m_loginState();
		}
		protected set
		{
			BBFPPCIDDAA(value);
		}
	}

	public bool HBKFDMAAOOG
	{
		get
		{
			return get_isAuth();
		}
	}

	public string IOOBGCCJMEP
	{
		get
		{
			return get_userID();
		}
	}

	public void LogoutOnly()
	{
		if (get_isAuth())
		{
			PlayGamesPlatform.Instance.SignOut();
		}
	}

	protected void BBFPPCIDDAA(JBDOMMGBFCI ICENKPDOHBK)
	{
		NEEPNJAAOBO = ICENKPDOHBK;
	}

	public string get_userID()
	{
		return V096OriginalDiagnostics.GetStableDeviceId();
	}

	public void OGOBPCDKMKP()
	{
		if (MKDBIDIFCIJ())
		{
			PlayGamesPlatform.Instance.SignOut();
		}
	}

	private void Awake()
	{
		Object.DontDestroyOnLoad(base.gameObject);
	}

	public void DONBIJPHEAE()
	{
		if (KADCDBIHOJG())
		{
			PlayGamesPlatform.Instance.SignOut();
			IgaworksUnityPluginAOS.LKLLDNCMKBH.GEGCIIKDGGO();
			Application.Quit();
		}
	}

	[SpecialName]
	public string NNLMAIPFDPO()
	{
		if (!MKDBIDIFCIJ())
		{
			return string.Empty;
		}
		return PlayGamesPlatform.Instance.GetUserId();
	}

	public bool get_isAuth()
	{
		return true;
	}

	[SpecialName]
	protected void KFDOHFIPGEN(JBDOMMGBFCI ICENKPDOHBK)
	{
		NEEPNJAAOBO = ICENKPDOHBK;
	}

	public void OEBPKFPDACI()
	{
		BBFPPCIDDAA(JBDOMMGBFCI.Process);
		if (!MEBOOLDBBOB)
		{
			PlayGamesClientConfiguration configuration = new PlayGamesClientConfiguration.Builder().Build();
			PlayGamesPlatform.InitializeInstance(configuration);
			PlayGamesPlatform.Activate();
			MEBOOLDBBOB = false;
		}
		Social.localUser.Authenticate(FDPHDKAMOGJ);
	}

	public void GMFGKLCGMPA()
	{
		KFDOHFIPGEN(JBDOMMGBFCI.Process);
		if (!MEBOOLDBBOB)
		{
			PlayGamesClientConfiguration configuration = new PlayGamesClientConfiguration.Builder().Build();
			PlayGamesPlatform.InitializeInstance(configuration);
			PlayGamesPlatform.Activate();
			MEBOOLDBBOB = false;
		}
		Social.localUser.Authenticate(FDPHDKAMOGJ);
	}

	public void Login()
	{
		NEEPNJAAOBO = JBDOMMGBFCI.Succeed;
	}

	public void Logout()
	{
		if (get_isAuth())
		{
			PlayGamesPlatform.Instance.SignOut();
			IgaworksUnityPluginAOS.LKLLDNCMKBH.GEGCIIKDGGO();
			Application.Quit();
		}
	}

	[CompilerGenerated]
	private void NDCLMGOCMJO(bool BGKAEFKEIIG)
	{
		if (BGKAEFKEIIG)
		{
			BBFPPCIDDAA(JBDOMMGBFCI.Succeed);
		}
		else
		{
			BBFPPCIDDAA(JBDOMMGBFCI.Failed);
		}
	}

	[SpecialName]
	public static GooglePlusManager ODHKBDLDDPD()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = Object.FindObjectOfType(typeof(GooglePlusManager)) as GooglePlusManager;
		}
		return MLDPFDAHKHA;
	}

	[SpecialName]
	public string EIINLKGAJPK()
	{
		if (!MKDBIDIFCIJ())
		{
			return string.Empty;
		}
		return PlayGamesPlatform.Instance.GetUserId();
	}

	private void GNGJFGMJLHA()
	{
		Object.DontDestroyOnLoad(base.gameObject);
	}

	public JBDOMMGBFCI get_m_loginState()
	{
		return NEEPNJAAOBO;
	}

	public static GooglePlusManager get_Instance()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = Object.FindObjectOfType(typeof(GooglePlusManager)) as GooglePlusManager;
		}
		return MLDPFDAHKHA;
	}

	[SpecialName]
	public bool KADCDBIHOJG()
	{
		return Social.localUser.authenticated;
	}

	public void DIDFAJBCINI()
	{
		KFDOHFIPGEN(JBDOMMGBFCI.None);
		if (!MEBOOLDBBOB)
		{
			PlayGamesClientConfiguration configuration = new PlayGamesClientConfiguration.Builder().Build();
			PlayGamesPlatform.InitializeInstance(configuration);
			PlayGamesPlatform.Activate();
			MEBOOLDBBOB = false;
		}
		Social.localUser.Authenticate((bool BGKAEFKEIIG) =>
		{
			if (BGKAEFKEIIG)
			{
				BBFPPCIDDAA(JBDOMMGBFCI.Succeed);
			}
			else
			{
				BBFPPCIDDAA(JBDOMMGBFCI.Failed);
			}
		});
	}

	private void IADENBHEOOM()
	{
		Object.DontDestroyOnLoad(base.gameObject);
	}

	[SpecialName]
	public bool DMCEJAHKIIF()
	{
		return Social.localUser.authenticated;
	}

	[SpecialName]
	public static GooglePlusManager AFPBELABPNM()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = Object.FindObjectOfType(typeof(GooglePlusManager)) as GooglePlusManager;
		}
		return MLDPFDAHKHA;
	}

	[SpecialName]
	public bool COCEGAJEAEK()
	{
		return Social.localUser.authenticated;
	}

	public void JJLPFIOHDDM()
	{
		if (KADCDBIHOJG())
		{
			PlayGamesPlatform.Instance.SignOut();
			IgaworksUnityPluginAOS.LKLLDNCMKBH.GEGCIIKDGGO();
			Application.Quit();
		}
	}

	[SpecialName]
	public bool MKDBIDIFCIJ()
	{
		return Social.localUser.authenticated;
	}

	private void ABMMGINPLAD()
	{
		Object.DontDestroyOnLoad(base.gameObject);
	}

	[SpecialName]
	public static GooglePlusManager DEBJGLHODJD()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = Object.FindObjectOfType(typeof(GooglePlusManager)) as GooglePlusManager;
		}
		return MLDPFDAHKHA;
	}

	private void FDPHDKAMOGJ(bool BGKAEFKEIIG)
	{
		if (BGKAEFKEIIG)
		{
			BBFPPCIDDAA((JBDOMMGBFCI)8);
		}
		else
		{
			BBFPPCIDDAA((JBDOMMGBFCI)4);
		}
	}

	[SpecialName]
	public JBDOMMGBFCI PGCKFPNMMPF()
	{
		return NEEPNJAAOBO;
	}

	[SpecialName]
	public bool DFPFDPGBBOE()
	{
		return Social.localUser.authenticated;
	}
}
