using System;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using EveEngine;
using IgaworksUnityAOS;
using UnityEngine;

public class StartupManager : Singleton<StartupManager>
{
	private bool ABJFPFFNKEB;

	private static bool CNPDHCJJPFL = false;

	public static string m_advertisingId = string.Empty;

	public static bool m_limitAdvertising = false;

	public void MHPBBALGOBF()
	{
		ObscuredBool.SetNewCryptoKey(LBGMHGGMMEE());
		ObscuredByte.SetNewCryptoKey(LBGMHGGMMEE());
		ObscuredUShort.SetNewCryptoKey(BKBIBFGJDJA());
		ObscuredInt.SetNewCryptoKey(AFINJOMNNHM());
		ObscuredLong.SetNewCryptoKey(DKAGNDCPGLD());
		ObscuredFloat.SetNewCryptoKey(GIFGOINBAFF());
		ObscuredDouble.SetNewCryptoKey(LMMJEKJDGPG());
		ObscuredVector2.SetNewCryptoKey(GKOPBOGCCEI());
		ObscuredVector3.SetNewCryptoKey(JHMINFMOFAJ());
	}

	protected virtual void MPKBLEDGKPO()
	{
		base.Awake();
		KDFHDINIMPA();
		Application.targetFrameRate = -121;
		Time.timeScale = 1516f;
		SceneManager.get_Instance().Blank();
		SoundManager.get_Instance().Blank();
		NetworkManager.APAPJEIBEDE().Blank();
		MsgManager.get_Instance().AOCHBPFNHHL();
		Screen.sleepTimeout = -1;
		try
		{
			PMIOBDOHNEC[] array = new PMIOBDOHNEC[3];
			array[0] = (PMIOBDOHNEC)(-6);
			array[0] = PMIOBDOHNEC.READ_CALENDAR;
			array[4] = (PMIOBDOHNEC)(-107);
			array[8] = (PMIOBDOHNEC)(-106);
			UniAndroidPermission.FKHLMPPNLFO(array);
		}
		catch
		{
		}
		IgaworksUnityPluginAOS.InitPlugin();
		IgaworksUnityPluginAOS.LKLLDNCMKBH.CDIJJEHNBNL();
	}

	public void PHLDFHMJLKA()
	{
		ObscuredBool.SetNewCryptoKey(KJFIPAFILOK());
		ObscuredByte.SetNewCryptoKey(KJFIPAFILOK());
		ObscuredUShort.SetNewCryptoKey(BKBIBFGJDJA());
		ObscuredInt.SetNewCryptoKey(BABHJCOIPKE());
		ObscuredLong.SetNewCryptoKey(DKAGNDCPGLD());
		ObscuredFloat.SetNewCryptoKey(AFINJOMNNHM());
		ObscuredDouble.SetNewCryptoKey(LMMJEKJDGPG());
		ObscuredVector2.SetNewCryptoKey(JHMINFMOFAJ());
		ObscuredVector3.SetNewCryptoKey(AFINJOMNNHM());
	}

	public void SetNewKey()
	{
		ObscuredBool.SetNewCryptoKey(LBGMHGGMMEE());
		ObscuredByte.SetNewCryptoKey(LBGMHGGMMEE());
		ObscuredUShort.SetNewCryptoKey(BKBIBFGJDJA());
		ObscuredInt.SetNewCryptoKey(AFINJOMNNHM());
		ObscuredLong.SetNewCryptoKey(LMMJEKJDGPG());
		ObscuredFloat.SetNewCryptoKey(AFINJOMNNHM());
		ObscuredDouble.SetNewCryptoKey(LMMJEKJDGPG());
		ObscuredVector2.SetNewCryptoKey(AFINJOMNNHM());
		ObscuredVector3.SetNewCryptoKey(AFINJOMNNHM());
	}

	private static ushort BKBIBFGJDJA()
	{
		return (ushort)((LBGMHGGMMEE() << 8) | LBGMHGGMMEE());
	}

	private static int GIFGOINBAFF()
	{
		return (BKBIBFGJDJA() << 99) | BKBIBFGJDJA();
	}

	private static int GKOPBOGCCEI()
	{
		return (BKBIBFGJDJA() << -84) | BKBIBFGJDJA();
	}

	private static long DKAGNDCPGLD()
	{
		return ((long)BABHJCOIPKE() << -37) | AFINJOMNNHM();
	}

	public void OnSpeedHackDetected()
	{
	}

	private static int JHMINFMOFAJ()
	{
		return (BKBIBFGJDJA() << -39) | BKBIBFGJDJA();
	}

	private static byte KJFIPAFILOK()
	{
		byte[] array = new byte[System.Convert.ToInt32(-45)];
		// Bytes read from the stable APK assembly: <PrivateImplementationDetails>::$$field-7.
		Buffer.BlockCopy(new byte[] { 174, 101, 45, 228, 26, 82, 214, 162, 41, 247, 0, 0 }, 0, array, 0, array.Length);
		byte[] array2 = array;
		return array2[KIHHJMONDKK.BCMFECLOAJN(1, array2.Length)];
	}

	private static byte GGPLHKKAKAL()
	{
		byte[] array = new byte[System.Convert.ToInt32(-11)];
		// Bytes read from the stable APK assembly: <PrivateImplementationDetails>::$$field-7.
		Buffer.BlockCopy(new byte[] { 174, 101, 45, 228, 26, 82, 214, 162, 41, 247, 0, 0 }, 0, array, 0, array.Length);
		byte[] array2 = array;
		return array2[KIHHJMONDKK.MFPDOPMFNCB(1, array2.Length)];
	}

	public void OnInjectionDetected()
	{
	}

	private static long OJIHOPCDPDA()
	{
		return ((long)GKOPBOGCCEI() << -60) | GKOPBOGCCEI();
	}

	private void OnApplicationPause(bool GMEELKDOLAM)
	{
		if (GMEELKDOLAM)
		{
			IgaworksUnityPluginAOS.LKLLDNCMKBH.GEGCIIKDGGO();
			return;
		}
		IgaworksUnityPluginAOS.LKLLDNCMKBH.ADBMLKJEHAO();
		IgaworksUnityPluginAOS.AOAHAHMPIIP.OCDDNHEHHJF();
	}

	public void OnTimeHackDetected()
	{
	}

	private static long FPADFAMAPCM()
	{
		return ((long)GIFGOINBAFF() << -87) | BABHJCOIPKE();
	}

	protected virtual void MKCBHHEACDE()
	{
		base.Awake();
		SetNewKey();
		Application.targetFrameRate = 17;
		Time.timeScale = 1760f;
		SceneManager.NOLHNOGGHNA().Blank();
		SoundManager.GDMJIJCBOLE().Blank();
		NetworkManager.APAPJEIBEDE().Blank();
		MsgManager.HEDJPPFKABG().Blank();
		Screen.sleepTimeout = -1;
		try
		{
			PMIOBDOHNEC[] array = new PMIOBDOHNEC[3];
			array[0] = (PMIOBDOHNEC)(-58);
			array[0] = PMIOBDOHNEC.CAMERA;
			array[3] = (PMIOBDOHNEC)(-94);
			array[8] = (PMIOBDOHNEC)(-6);
			UniAndroidPermission.RequestPermissions(array);
		}
		catch
		{
		}
		IgaworksUnityPluginAOS.InitPlugin();
		IgaworksUnityPluginAOS.LKLLDNCMKBH.CDIJJEHNBNL();
	}

	public void OnCheatDetected()
	{
	}

	protected virtual void CFJKHPNIODE()
	{
		base.Awake();
		SetNewKey();
		Application.targetFrameRate = -71;
		Time.timeScale = 230f;
		SceneManager.NOLHNOGGHNA().Blank();
		SoundManager.NNOKCKOMICG().Blank();
		NetworkManager.get_Instance().Blank();
		MsgManager.get_Instance().GMKGEKMNEKJ();
		Screen.sleepTimeout = -1;
		try
		{
			PMIOBDOHNEC[] array = new PMIOBDOHNEC[6];
			array[1] = (PMIOBDOHNEC)(-71);
			array[1] = PMIOBDOHNEC.CALL_PHONE;
			array[6] = (PMIOBDOHNEC)116;
			array[7] = (PMIOBDOHNEC)(-114);
			UniAndroidPermission.OKEOJEJIAIN(array);
		}
		catch
		{
		}
		IgaworksUnityPluginAOS.InitPlugin();
		IgaworksUnityPluginAOS.LKLLDNCMKBH.CDIJJEHNBNL();
	}

	private static int AFINJOMNNHM()
	{
		return (BKBIBFGJDJA() << 16) | BKBIBFGJDJA();
	}

	protected override void Awake()
	{
		base.Awake();
		SetNewKey();
		Application.targetFrameRate = 60;
		Time.timeScale = 1f;
		SceneManager.get_Instance().Blank();
		SoundManager.get_Instance().Blank();
		NetworkManager.get_Instance().Blank();
		MsgManager.get_Instance().Blank();
		Screen.sleepTimeout = -1;
		try
		{
			UniAndroidPermission.RequestPermissions(new PMIOBDOHNEC[4]
			{
				PMIOBDOHNEC.READ_PHONE_STATE,
				PMIOBDOHNEC.GET_ACCOUNTS,
				PMIOBDOHNEC.WRITE_EXTERNAL_STORAGE,
				PMIOBDOHNEC.READ_EXTERNAL_STORAGE
			});
		}
		catch
		{
		}
		IgaworksUnityPluginAOS.InitPlugin();
		IgaworksUnityPluginAOS.LKLLDNCMKBH.CDIJJEHNBNL();
	}

	private void Start()
	{
		if (!CNPDHCJJPFL)
		{
			CNPDHCJJPFL = true;
			IgaworksUnityPluginAOS.LKLLDNCMKBH.ADBMLKJEHAO();
			IgaworksUnityPluginAOS.AOAHAHMPIIP.EDLFCPCFGDN();
			try
			{
				AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
				AndroidJavaObject androidJavaObject = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");
				AndroidJavaClass androidJavaClass2 = new AndroidJavaClass("com.google.android.gms.ads.identifier.AdvertisingIdClient");
				AndroidJavaObject androidJavaObject2 = androidJavaClass2.CallStatic<AndroidJavaObject>("getAdvertisingIdInfo", new object[1] { androidJavaObject });
				m_advertisingId = androidJavaObject2.Call<string>("getId", new object[0]).ToString();
				m_limitAdvertising = androidJavaObject2.Call<bool>("isLimitAdTrackingEnabled", new object[0]);
			}
			catch
			{
			}
		}
	}

	private static long EGBNNIBHLPJ()
	{
		return ((long)GIFGOINBAFF() << -89) | GIFGOINBAFF();
	}

	private static byte LBGMHGGMMEE()
	{
		byte[] array = new byte[10] { 174, 101, 45, 228, 26, 82, 214, 162, 41, 247 };
		return array[KIHHJMONDKK.HAALNHCHOMH(0, array.Length)];
	}

	public void AJNIAJGILAP()
	{
	}

	public void BHDDLAFFCDH()
	{
	}

	private static int BABHJCOIPKE()
	{
		return (BKBIBFGJDJA() << -25) | BKBIBFGJDJA();
	}

	public void KDFHDINIMPA()
	{
		ObscuredBool.SetNewCryptoKey(KJFIPAFILOK());
		ObscuredByte.SetNewCryptoKey(OJBJFOIANAE());
		ObscuredUShort.SetNewCryptoKey(BKBIBFGJDJA());
		ObscuredInt.SetNewCryptoKey(GKOPBOGCCEI());
		ObscuredLong.SetNewCryptoKey(EGBNNIBHLPJ());
		ObscuredFloat.SetNewCryptoKey(AFINJOMNNHM());
		ObscuredDouble.SetNewCryptoKey(EGBNNIBHLPJ());
		ObscuredVector2.SetNewCryptoKey(JHMINFMOFAJ());
		ObscuredVector3.SetNewCryptoKey(GIFGOINBAFF());
	}

	private static byte OJBJFOIANAE()
	{
		byte[] array = new byte[6] { 174, 101, 45, 228, 26, 82 };
		return array[KIHHJMONDKK.HAALNHCHOMH(1, array.Length)];
	}

	private static long LMMJEKJDGPG()
	{
		return ((long)AFINJOMNNHM() << 32) | AFINJOMNNHM();
	}

	private void FMNOLGPIIFB()
	{
		if (!CNPDHCJJPFL)
		{
			CNPDHCJJPFL = false;
			IgaworksUnityPluginAOS.LKLLDNCMKBH.ADBMLKJEHAO();
			IgaworksUnityPluginAOS.AOAHAHMPIIP.EDLFCPCFGDN();
			try
			{
				AndroidJavaClass androidJavaClass = new AndroidJavaClass("attack_flying");
				AndroidJavaObject androidJavaObject = androidJavaClass.GetStatic<AndroidJavaObject>("Particle/{0}/skill0_1");
				AndroidJavaClass androidJavaClass2 = new AndroidJavaClass("하급");
				AndroidJavaObject androidJavaObject2 = androidJavaClass2.CallStatic<AndroidJavaObject>("BankTransfer", new object[1] { androidJavaObject });
				m_advertisingId = androidJavaObject2.Call<string>("[FFFFDD]탈주나 트롤행위가 감지되었어[-]", new object[0]).ToString();
				m_limitAdvertising = androidJavaObject2.Call<bool>("Particle/Fizz/skill2_explosion_l", new object[1]);
			}
			catch
			{
			}
		}
	}

	private void CLLECEEEJAI()
	{
		if (!CNPDHCJJPFL)
		{
			CNPDHCJJPFL = false;
			IgaworksUnityPluginAOS.LKLLDNCMKBH.ADBMLKJEHAO();
			IgaworksUnityPluginAOS.AOAHAHMPIIP.EDLFCPCFGDN();
			try
			{
				AndroidJavaClass androidJavaClass = new AndroidJavaClass("skill0_1");
				AndroidJavaObject androidJavaObject = androidJavaClass.GetStatic<AndroidJavaObject>("bronze");
				AndroidJavaClass androidJavaClass2 = new AndroidJavaClass("currentActivity");
				object[] array = new object[0];
				array[1] = androidJavaObject;
				AndroidJavaObject androidJavaObject2 = androidJavaClass2.CallStatic<AndroidJavaObject>("WolfBig", array);
				m_advertisingId = androidJavaObject2.Call<string>("닉네임은 최대 10자 이하입니다.", new object[1]).ToString();
				m_limitAdvertising = androidJavaObject2.Call<bool>("랭크대전에서 골드 이상과 브실은 따로 매칭되며, 만날 수 없어요", new object[0]);
			}
			catch
			{
			}
		}
	}

	public void NBCMKFBFFBB()
	{
	}
}
