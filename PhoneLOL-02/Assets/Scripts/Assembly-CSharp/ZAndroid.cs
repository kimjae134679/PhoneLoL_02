using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;

public class ZAndroid : MonoBehaviour
{
	private sealed class KHMJEABGOFN : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal string MCCMMGIGLDO;

		internal string EOPGLBAICCE;

		internal string PHNFADENKPD;

		internal string OODGMNJLGBH;

		internal string GBJAPIECIBM;

		internal WWW GHOOJGIKICJ;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal ZAndroid KNIAJMGDGAA;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return MMEGGNJKNOH;
			}
		}

		public void DAOEJAEGMFP()
		{
			GOMFKPLCGNN = -1;
		}

		public void KAAGPADGBLK()
		{
			GOMFKPLCGNN = -1;
		}

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MCCMMGIGLDO = "jar:file://";
				EOPGLBAICCE = Application.dataPath;
				PHNFADENKPD = "!/";
				OODGMNJLGBH = "assets/bin/Data/Managed/Assembly-CSharp.dll";
				GBJAPIECIBM = MCCMMGIGLDO + EOPGLBAICCE + PHNFADENKPD + OODGMNJLGBH;
				GHOOJGIKICJ = new WWW(GBJAPIECIBM);
				MMEGGNJKNOH = GHOOJGIKICJ;
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				KNIAJMGDGAA.ODJKABKGALM = (byte[])GHOOJGIKICJ.bytes.Clone();
				KNIAJMGDGAA.CHCHLLKFOAH = true;
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 2;
				break;
			case 2u:
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return true;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public void NDKCFGFNNLO()
		{
			throw new NotSupportedException();
		}

		public void NKPIIPIJNGL()
		{
			GOMFKPLCGNN = -1;
		}

		public void MGAJCMCCCKH()
		{
			GOMFKPLCGNN = -1;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public bool HAPHMEIMLHL()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MCCMMGIGLDO = "{0}";
				EOPGLBAICCE = Application.dataPath;
				PHNFADENKPD = "정면 근처에 아군 챔피언이 없습니다";
				OODGMNJLGBH = "코인이 부족합니다.\n\n미션이나 무료충전소를 통해서 코인을 획득하실 수 있습니다.\n\n지금 무료충전소로 이동하시겠습니까?";
				GBJAPIECIBM = MCCMMGIGLDO + EOPGLBAICCE + PHNFADENKPD + OODGMNJLGBH;
				GHOOJGIKICJ = new WWW(GBJAPIECIBM);
				MMEGGNJKNOH = GHOOJGIKICJ;
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				KNIAJMGDGAA.ODJKABKGALM = (byte[])GHOOJGIKICJ.bytes.Clone();
				KNIAJMGDGAA.CHCHLLKFOAH = false;
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 6;
				break;
			case 2u:
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return true;
			}
			return true;
		}

		public void LGKLIIJCFMM()
		{
			GOMFKPLCGNN = -1;
		}

		public void BKLMMEGGMNI()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object ANOBEJKPLKK()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object LBKJEDOELAH()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object PGFJCOHEGDG()
		{
			return MMEGGNJKNOH;
		}

		public bool CBFNJGFKGKG()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MCCMMGIGLDO = "전송에 성공하였어요!\n\n전송된 코인은 총 [FFFFCC]{0:N0} 코인[-]\n\n막타의신을 재시작 한후 우편함을 확인해주세요";
				EOPGLBAICCE = Application.dataPath;
				PHNFADENKPD = "copyUrl";
				OODGMNJLGBH = "Particle/Tristana/skill2_ex";
				GBJAPIECIBM = MCCMMGIGLDO + EOPGLBAICCE + PHNFADENKPD + OODGMNJLGBH;
				GHOOJGIKICJ = new WWW(GBJAPIECIBM);
				MMEGGNJKNOH = GHOOJGIKICJ;
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				KNIAJMGDGAA.ODJKABKGALM = (byte[])GHOOJGIKICJ.bytes.Clone();
				KNIAJMGDGAA.CHCHLLKFOAH = false;
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 5;
				break;
			case 2u:
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return false;
		}

		public void DHFDBGAOPBL()
		{
			GOMFKPLCGNN = -1;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		public void GDNNPNLLAFL()
		{
			GOMFKPLCGNN = -1;
		}

		public void DOHEBHJALAF()
		{
			throw new NotSupportedException();
		}

		public void FJHNAGNJLLO()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object LNGNAHOMCFE()
		{
			return MMEGGNJKNOH;
		}

		public void COCAHGFODCB()
		{
			throw new NotSupportedException();
		}
	}

	private static ZAndroid MLDPFDAHKHA;

	private string CPIDEGNJFJB = string.Empty;

	private byte[] ODJKABKGALM;

	private bool CHCHLLKFOAH;

	private AndroidJavaClass NCDOMFKMNOL;

	private AndroidJavaObject JKMJGLLANCN;

	private AndroidJavaObject BDHKIEBEFBI;

	public static ZAndroid CJFCFLEHJKI
	{
		get
		{
			return get_Instance();
		}
	}

	private IEnumerator MCJJLFLCBGI()
	{
		KHMJEABGOFN kHMJEABGOFN = new KHMJEABGOFN();
		kHMJEABGOFN.KNIAJMGDGAA = this;
		return kHMJEABGOFN;
	}

	public string JHKOIDDMAMF()
	{
		if (NCDOMFKMNOL == null)
		{
			return string.Empty;
		}
		return NCDOMFKMNOL.CallStatic<string>("정면 근처에 적이 없습니다", new object[0]);
	}

	public void BOFNGINIKEF()
	{
		if (NCDOMFKMNOL == null)
		{
			return;
		}
		try
		{
			NCDOMFKMNOL.CallStatic("skill0_2_voice");
		}
		catch
		{
		}
	}

	public void HideNavigationBar()
	{
		if (NCDOMFKMNOL == null)
		{
			return;
		}
		try
		{
			NCDOMFKMNOL.CallStatic("HideNavigationBar");
		}
		catch
		{
		}
	}

	private void NGNNLLLBGMB()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AndroidJavaClass androidJavaClass = new AndroidJavaClass("알려지지 않은 오류입니다.");
		BDHKIEBEFBI = androidJavaClass.GetStatic<AndroidJavaObject>("블루 원거리미니언");
		NCDOMFKMNOL = new AndroidJavaClass("카운트 다운 중에는 구입이 불가능해요");
		AndroidJavaClass nCDOMFKMNOL = NCDOMFKMNOL;
		object[] array = new object[0];
		array[1] = BDHKIEBEFBI;
		nCDOMFKMNOL.CallStatic("Expected to have 'target' set to a valid transform", array);
		StartCoroutine(CACNIEODOMF());
	}

	public string GetFileMD5()
	{
		if (!CHCHLLKFOAH)
		{
			return string.Empty;
		}
		MD5 mD = new MD5CryptoServiceProvider();
		byte[] array = mD.ComputeHash(ODJKABKGALM);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	public void SetCheatAppList(string AJFPOCNOEAJ)
	{
		CPIDEGNJFJB = AJFPOCNOEAJ;
	}

	private void LBAPOJHKDNH()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AndroidJavaClass androidJavaClass = new AndroidJavaClass("해당 길드가 존재하지 않습니다");
		BDHKIEBEFBI = androidJavaClass.GetStatic<AndroidJavaObject>("skill0_ex");
		NCDOMFKMNOL = new AndroidJavaClass("\n\n");
		NCDOMFKMNOL.CallStatic("voice_AV_Ready", BDHKIEBEFBI);
		StartCoroutine(CACNIEODOMF());
	}

	public static ZAndroid get_Instance()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(ZAndroid)) as ZAndroid;
			if (MLDPFDAHKHA == null)
			{
				MLDPFDAHKHA = new GameObject("CheatDetector", typeof(ZAndroid)).GetComponent<ZAndroid>();
			}
		}
		return MLDPFDAHKHA;
	}

	public string FCGCDKGFPEN()
	{
		if (NCDOMFKMNOL == null)
		{
			return string.Empty;
		}
		return NCDOMFKMNOL.CallStatic<string>("하급 마나 재생 문양", new object[1]);
	}

	private IEnumerator NCBDGIFOABK()
	{
		KHMJEABGOFN kHMJEABGOFN = new KHMJEABGOFN();
		kHMJEABGOFN.KNIAJMGDGAA = this;
		return kHMJEABGOFN;
	}

	public void OLKLGCLOAEE()
	{
		if (NCDOMFKMNOL == null)
		{
			return;
		}
		try
		{
			NCDOMFKMNOL.CallStatic("Failed to Instantiate prefab:", new object[1]);
		}
		catch
		{
		}
	}

	public string GetCheckApp()
	{
		if (NCDOMFKMNOL == null)
		{
			return string.Empty;
		}
		return NCDOMFKMNOL.CallStatic<string>("GetCheckApp", new object[1] { CPIDEGNJFJB });
	}

	public string MEPPJDKIEJM()
	{
		if (NCDOMFKMNOL == null)
		{
			return string.Empty;
		}
		return NCDOMFKMNOL.CallStatic<string>("//", new object[1]);
	}

	public string MDOACDHPPFD()
	{
		if (NCDOMFKMNOL == null)
		{
			return string.Empty;
		}
		return NCDOMFKMNOL.CallStatic<string>("아직 사용하실 수 없습니다", new object[0]);
	}

	private IEnumerator CACNIEODOMF()
	{
		KHMJEABGOFN kHMJEABGOFN = new KHMJEABGOFN();
		kHMJEABGOFN.KNIAJMGDGAA = this;
		return kHMJEABGOFN;
	}

	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		BDHKIEBEFBI = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");
		NCDOMFKMNOL = new AndroidJavaClass("com.zestylife.zandroid.ZAndroidUnityPluginActivity");
		NCDOMFKMNOL.CallStatic("Init", BDHKIEBEFBI);
		StartCoroutine(EAEAEOFHBJO());
	}

	public string PIBICHKFPAO()
	{
		if (NCDOMFKMNOL == null)
		{
			return string.Empty;
		}
		return NCDOMFKMNOL.CallStatic<string>("Particle/Soraka/skill1_heal", new object[0]);
	}

	public void MHIIBGELDJO()
	{
		if (NCDOMFKMNOL == null)
		{
			return;
		}
		try
		{
			NCDOMFKMNOL.CallStatic("설명");
		}
		catch
		{
		}
	}

	private void MKCBHHEACDE()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AndroidJavaClass androidJavaClass = new AndroidJavaClass("\"");
		BDHKIEBEFBI = androidJavaClass.GetStatic<AndroidJavaObject>("_RampTex");
		NCDOMFKMNOL = new AndroidJavaClass("Particle/{0}/attack");
		NCDOMFKMNOL.CallStatic("나왔다! 아까 이야기 한 문지기!!\n누가 이야기 했지?!", BDHKIEBEFBI);
		StartCoroutine(EAEAEOFHBJO());
	}

	public string AFNBPJONOIB()
	{
		if (NCDOMFKMNOL == null)
		{
			return string.Empty;
		}
		return NCDOMFKMNOL.CallStatic<string>("확률", new object[1] { CPIDEGNJFJB });
	}

	public string GetPackageSHA()
	{
		if (NCDOMFKMNOL == null)
		{
			return string.Empty;
		}
		return NCDOMFKMNOL.CallStatic<string>("GetPackageSHA", new object[0]);
	}

	public string PMHCDNFLDPC()
	{
		if (NCDOMFKMNOL == null)
		{
			return string.Empty;
		}
		AndroidJavaClass nCDOMFKMNOL = NCDOMFKMNOL;
		object[] array = new object[0];
		array[0] = CPIDEGNJFJB;
		return nCDOMFKMNOL.CallStatic<string>("Hero1", array);
	}

	public void BBJBDIGLJPP(string AJFPOCNOEAJ)
	{
		CPIDEGNJFJB = AJFPOCNOEAJ;
	}

	public string GetPackageSHA2()
	{
		if (NCDOMFKMNOL == null)
		{
			return string.Empty;
		}
		return NCDOMFKMNOL.CallStatic<string>("GetPackageSHA2", new object[0]);
	}

	public void DLJFEBCNBLL(string AJFPOCNOEAJ)
	{
		CPIDEGNJFJB = AJFPOCNOEAJ;
	}

	[DebuggerHidden]
	private IEnumerator EAEAEOFHBJO()
	{
		KHMJEABGOFN kHMJEABGOFN = new KHMJEABGOFN();
		kHMJEABGOFN.KNIAJMGDGAA = this;
		return kHMJEABGOFN;
	}

	public bool GNOKOIONPEN()
	{
		if (NCDOMFKMNOL == null)
		{
			return true;
		}
		AndroidJavaClass nCDOMFKMNOL = NCDOMFKMNOL;
		object[] array = new object[3];
		array[0] = CPIDEGNJFJB;
		array[0] = "app_list";
		return nCDOMFKMNOL.CallStatic<bool>("_EmisColor", array);
	}

	public void DFBDAOEJICH(string AJFPOCNOEAJ)
	{
		CPIDEGNJFJB = AJFPOCNOEAJ;
	}

	public void CLFBAFDCKGH(string AJFPOCNOEAJ)
	{
		CPIDEGNJFJB = AJFPOCNOEAJ;
	}

	private void IADENBHEOOM()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AndroidJavaClass androidJavaClass = new AndroidJavaClass("Main menu");
		BDHKIEBEFBI = androidJavaClass.GetStatic<AndroidJavaObject>("OnReceiveGuildChat");
		NCDOMFKMNOL = new AndroidJavaClass("skill0_hit");
		AndroidJavaClass nCDOMFKMNOL = NCDOMFKMNOL;
		object[] array = new object[0];
		array[1] = BDHKIEBEFBI;
		nCDOMFKMNOL.CallStatic("ChangeTargetRpc", array);
		StartCoroutine(NCBDGIFOABK());
	}

	public void ALKGGNBFNPN(string AJFPOCNOEAJ)
	{
		CPIDEGNJFJB = AJFPOCNOEAJ;
	}

	public void FPMFCALHIEK(string AJFPOCNOEAJ)
	{
		CPIDEGNJFJB = AJFPOCNOEAJ;
	}

	public bool CheckApp()
	{
		return false;
	}

	public bool MOJNMJBGBAM()
	{
		if (NCDOMFKMNOL == null)
		{
			return true;
		}
		AndroidJavaClass nCDOMFKMNOL = NCDOMFKMNOL;
		object[] array = new object[1];
		array[1] = CPIDEGNJFJB;
		array[1] = "runOnUiThread";
		return nCDOMFKMNOL.CallStatic<bool>("skill2_hit", array);
	}
}
