using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nas;
using TapjoyUnity;
using UnityEngine;

public class AdManager : MonoBehaviour
{
	private static AdManager MLDPFDAHKHA;

	private float KDBENONAKLK;

	private TJPlacement BIOLGKICOAH;

	private TJPlacement POFCIAJABPC;

	private TJPlacement OJLCKACNKDI;

	private bool CKKIBAIDNCP;

	private List<Action<bool>> HIAIIBNNHPK;

	[CompilerGenerated]
	private static Action<bool> MDFOHMEKNIO;

	public static AdManager CJFCFLEHJKI
	{
		get
		{
			return get_Instance();
		}
	}

	public void BIDMPDFHMKE(TJPlacement CJPEKCEFKFF)
	{
		MsgManager.HEDJPPFKABG().LPKACDLKHCP(true);
		CKKIBAIDNCP = false;
		KGKFJNDDBHM(false);
	}

	public void FGNNOKBLDHH()
	{
		if (BIOLGKICOAH == null)
		{
			BIOLGKICOAH = TJPlacement.CreatePlacement("중급 마법저항력 표식");
		}
		if (BIOLGKICOAH != null)
		{
			MsgManager.get_Instance().LPKACDLKHCP(false);
			BIOLGKICOAH.RequestContent();
		}
	}

	[SpecialName]
	public static AdManager AFPBELABPNM()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(AdManager)) as AdManager;
		}
		return MLDPFDAHKHA;
	}

	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		KDBENONAKLK = 0f;
		HIAIIBNNHPK = new List<Action<bool>>();
	}

	private void Start()
	{
		if (LegacyAndroidServices.IsAvailable("com.nas.unity.NasUnityPlugin")) Plugin.Instance.init(false, string.Empty);
		if (Application.platform == RuntimePlatform.Android)
		{
			AndroidJNI.AttachCurrentThread();
		}
		if (LegacyAndroidServices.IsAvailable("com.tapjoy.Tapjoy"))
        {
            TJPlacement.OnRequestSuccess += OnTapjoyRequestSuccess;
		TJPlacement.OnRequestFailure += OnTapjoyRequestFailure;
		TJPlacement.OnVideoComplete += OnTapjoyVideoComplete;
		TJPlacement.OnVideoError += OnTapjoyVideoError;
		TJPlacement.OnContentDismiss += OnTapjoyContentDismiss;
        }
	}

	public void MMKNPGIJLIB(TJPlacement CJPEKCEFKFF)
	{
		if (!CKKIBAIDNCP)
		{
			MsgManager.HEDJPPFKABG().ShowLoadingIndicator(false);
			KGKFJNDDBHM(false);
		}
	}

	private void OnApplicationPause(bool KDAJCGDLGME)
	{
	}

	public void AHKLKMAPHNI(string EMLCHLFKLJD)
	{
	}

	public void ShowNasOfferwall()
	{
		uint oHGOBGOIECH = NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.OHGOBGOIECH;
		if (oHGOBGOIECH == 0)
		{
			MsgManager.get_Instance().ShowMessageBox("정상 로그인후에 다시 시도해주세요");
		}
		else
		{
			Plugin.Instance.open(oHGOBGOIECH.ToString());
		}
	}

	public void OnTapjoyRequestFailure(TJPlacement CJPEKCEFKFF, string MAOLPBBJOJB)
	{
		if (CJPEKCEFKFF == BIOLGKICOAH)
		{
			MsgManager.get_Instance().ShowLoadingIndicator(false);
		}
		else if (CJPEKCEFKFF == POFCIAJABPC)
		{
			MsgManager.get_Instance().ShowLoadingIndicator(false);
			MsgManager.get_Instance().ShowMessageBox("컨텐츠가 준비되지 않았습니다\n잠시후에 다시 시도해주세요");
		}
	}

	public void MPEBFPOFOKP(string EMLCHLFKLJD)
	{
	}

	private void DHHDGELEADC(bool KDAJCGDLGME)
	{
	}

	public void EMACMOCNLOB()
	{
		uint oHGOBGOIECH = NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
			.OHGOBGOIECH;
		if (oHGOBGOIECH == 0)
		{
			MsgManager.get_Instance().ShowMessageBox(".");
		}
		else
		{
			Plugin.Instance.open(oHGOBGOIECH.ToString());
		}
	}

	private void PKEDBMOICPL(bool KDAJCGDLGME)
	{
	}

	public void ShowTapjoyOfferwall()
	{
		if (BIOLGKICOAH == null)
		{
			BIOLGKICOAH = TJPlacement.CreatePlacement("Offerwall");
		}
		if (BIOLGKICOAH != null)
		{
			MsgManager.get_Instance().ShowLoadingIndicator(true);
			BIOLGKICOAH.RequestContent();
		}
	}

	public void LHNNNGEMKLO(string EMLCHLFKLJD)
	{
	}

	private void KGKFJNDDBHM(bool HIJLMPFMHBH)
	{
		for (int i = 0; i < HIAIIBNNHPK.Count; i++)
		{
			try
			{
				HIAIIBNNHPK[i](HIJLMPFMHBH);
			}
			catch
			{
			}
		}
		HIAIIBNNHPK.Clear();
	}

	[CompilerGenerated]
	private static void LEALPGEOHKD(bool HIJLMPFMHBH)
	{
		V096OriginalDiagnostics.QueueAutomaticReportImmediate("CLEAN_EXIT");
		Application.Quit();
	}

	public void OnTapjoyContentDismiss(TJPlacement CJPEKCEFKFF)
	{
		if (!CKKIBAIDNCP)
		{
			MsgManager.get_Instance().ShowLoadingIndicator(false);
			KGKFJNDDBHM(false);
		}
	}

	public void JFOILEENHPD(string EMLCHLFKLJD)
	{
	}

	public void HandleReceivedInterstitial(string EMLCHLFKLJD)
	{
	}

	public void OnTapjoyVideoComplete(TJPlacement CJPEKCEFKFF)
	{
		MsgManager.get_Instance().ShowLoadingIndicator(false);
		CKKIBAIDNCP = true;
		KGKFJNDDBHM(true);
	}

	[SpecialName]
	public static AdManager GDMJIJCBOLE()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(AdManager)) as AdManager;
		}
		return MLDPFDAHKHA;
	}

	public void ShowRewardVideo(Action<bool> MHJPJFBBHIJ)
	{
		if (POFCIAJABPC == null)
		{
			POFCIAJABPC = TJPlacement.CreatePlacement("Box");
		}
		if (POFCIAJABPC != null)
		{
			MsgManager.get_Instance().ShowLoadingIndicator(true);
			HIAIIBNNHPK.Add(MHJPJFBBHIJ);
			CKKIBAIDNCP = false;
			POFCIAJABPC.RequestContent();
		}
	}

	public void OnTapjoyVideoError(TJPlacement CJPEKCEFKFF, string MAOLPBBJOJB)
	{
		if (!CKKIBAIDNCP)
		{
			MsgManager.get_Instance().ShowLoadingIndicator(false);
			KGKFJNDDBHM(false);
		}
	}

	[SpecialName]
	public static AdManager OENEDBBFPMI()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(AdManager)) as AdManager;
		}
		return MLDPFDAHKHA;
	}

	public void HandleFailedToReceiveInterstitial()
	{
	}

	private void DEFLIOMCCMA()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		KDBENONAKLK = 1317f;
		HIAIIBNNHPK = new List<Action<bool>>();
	}

	private void BOIACKGNIKC()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		KDBENONAKLK = 1816f;
		HIAIIBNNHPK = new List<Action<bool>>();
	}

	private void OnDestroy()
	{
	}

	[SpecialName]
	public static AdManager DAOMPJMOCKM()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(AdManager)) as AdManager;
		}
		return MLDPFDAHKHA;
	}

	public void ICPKPHODFHA(TJPlacement CJPEKCEFKFF)
	{
		if (!CKKIBAIDNCP)
		{
			MsgManager.HEDJPPFKABG().ShowLoadingIndicator(true);
			KGKFJNDDBHM(false);
		}
	}

	public static AdManager get_Instance()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(AdManager)) as AdManager;
		}
		return MLDPFDAHKHA;
	}

	public void HPEHFCGEGJL()
	{
		uint oHGOBGOIECH = NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.OHGOBGOIECH;
		if (oHGOBGOIECH == 0)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("currentActivity");
		}
		else
		{
			Plugin.Instance.open(oHGOBGOIECH.ToString());
		}
	}

	public void OnTapjoyRequestSuccess(TJPlacement CJPEKCEFKFF)
	{
		if (CJPEKCEFKFF == BIOLGKICOAH)
		{
			MsgManager.get_Instance().ShowLoadingIndicator(false);
			if (CJPEKCEFKFF.IsContentAvailable())
			{
				BIOLGKICOAH.ShowContent();
			}
		}
		else if (CJPEKCEFKFF == POFCIAJABPC)
		{
			POFCIAJABPC.ShowContent();
		}
	}

	public void GLFGKCOFMKK()
	{
		if (BIOLGKICOAH == null)
		{
			BIOLGKICOAH = TJPlacement.CreatePlacement("[FFCCCC]트롤 행위 위험 수준이에요[-]\n\n탈주나 트롤행위시 게임이용에 제한이 생겨요\n(성실 플레이를 하시면 위험 수준이 낮아져요)");
		}
		if (BIOLGKICOAH != null)
		{
			MsgManager.get_Instance().ShowLoadingIndicator(false);
			BIOLGKICOAH.RequestContent();
		}
	}

	private void DMENDMLGGLD(bool KDAJCGDLGME)
	{
	}

	public void HandleDismissedInterstitial()
	{
	}

	public void GNGCEJGCGFN()
	{
	}

	public void ShowEndingInterstitial()
	{
		if (KDBENONAKLK + 1f < Time.realtimeSinceStartup)
		{
			if (POFCIAJABPC == null)
			{
				POFCIAJABPC = TJPlacement.CreatePlacement("Exit");
			}
			if (POFCIAJABPC != null)
			{
				MsgManager.get_Instance().ShowLoadingIndicator(true);
				HIAIIBNNHPK.Add((bool HIJLMPFMHBH) =>
				{
					V096OriginalDiagnostics.QueueAutomaticReportImmediate("CLEAN_EXIT");
					Application.Quit();
				});
				CKKIBAIDNCP = false;
				POFCIAJABPC.RequestContent();
			}
		}
		else
		{
			Application.Quit();
		}
	}
}
