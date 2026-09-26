using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EveEngine;
using IgaworksUnityAOS;
using UnityEngine;

public class UILobbyFreeCharge : MonoBehaviour
{
	private sealed class HLKEPNNEDIM : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal UILobbyFreeCharge KNIAJMGDGAA;

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

		public void KLHABCJBBPF()
		{
			throw new NotSupportedException();
		}

		public bool LLKGBIDKCOF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MsgManager.HEDJPPFKABG().ShowLoadingIndicator(true);
				MMEGGNJKNOH = new WaitForSeconds(853f);
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().NIKLNPKNCBA(new IKMBGMILCDO(KNIAJMGDGAA.OnReceiveFreeCharge, false));
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public void NDKCFGFNNLO()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object EKEFFEBDAHE()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object BFBDKFOJMAK()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object BEGFHDBBBJN()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object IOMDAPMNFOC()
		{
			return MMEGGNJKNOH;
		}

		public void IIJCOOCGGGJ()
		{
			throw new NotSupportedException();
		}

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MsgManager.get_Instance().ShowLoadingIndicator(true);
				MMEGGNJKNOH = new WaitForSeconds(3f);
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				NetworkManager.get_Instance().get_m_gameNetClient().NIKLNPKNCBA(new IKMBGMILCDO(KNIAJMGDGAA.OnReceiveFreeCharge));
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public bool AAAMEOEOJHM()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MsgManager.HEDJPPFKABG().ShowLoadingIndicator(false);
				MMEGGNJKNOH = new WaitForSeconds(283f);
				GOMFKPLCGNN = 1;
				return false;
			case 1u:
				NetworkManager.get_Instance().IOJGPDKHAGD().NIKLNPKNCBA(new IKMBGMILCDO(KNIAJMGDGAA.OnReceiveFreeCharge));
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public bool NEOILBIIDBE()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MsgManager.HEDJPPFKABG().LPKACDLKHCP(true);
				MMEGGNJKNOH = new WaitForSeconds(1401f);
				GOMFKPLCGNN = 0;
				return true;
			case 1u:
				NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().NIKLNPKNCBA(new IKMBGMILCDO(KNIAJMGDGAA.OnReceiveFreeCharge, false));
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public bool IIBEAMELJDD()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MsgManager.HEDJPPFKABG().ShowLoadingIndicator(true);
				MMEGGNJKNOH = new WaitForSeconds(951f);
				GOMFKPLCGNN = 0;
				return false;
			case 1u:
				NetworkManager.get_Instance().IOJGPDKHAGD().NIKLNPKNCBA(new IKMBGMILCDO(KNIAJMGDGAA.OnReceiveFreeCharge, false));
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public void NGFBCKPMPAE()
		{
			GOMFKPLCGNN = -1;
		}

		public void EJAKHHBBJPL()
		{
			throw new NotSupportedException();
		}

		public bool MHEGNOHIKCL()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MsgManager.HEDJPPFKABG().ShowLoadingIndicator(false);
				MMEGGNJKNOH = new WaitForSeconds(1426f);
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				NetworkManager.APAPJEIBEDE().get_m_gameNetClient().NIKLNPKNCBA(new IKMBGMILCDO(KNIAJMGDGAA.OnReceiveFreeCharge, false));
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[SpecialName]
		private object BFOFEKOOHMB()
		{
			return MMEGGNJKNOH;
		}

		public void OPAJADMNCIF()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object JGDFFAFIKFC()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object JNKGFHPIOPG()
		{
			return MMEGGNJKNOH;
		}

		public bool FPNFBEPGJEL()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MsgManager.get_Instance().LPKACDLKHCP(false);
				MMEGGNJKNOH = new WaitForSeconds(219f);
				GOMFKPLCGNN = 1;
				return false;
			case 1u:
				NetworkManager.APAPJEIBEDE().get_m_gameNetClient().NIKLNPKNCBA(new IKMBGMILCDO(KNIAJMGDGAA.OnReceiveFreeCharge, false, false));
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}
	}

	public GameObject m_freeCharge4Button;

	private bool LJAJCJIMPGF;

	private int PLAMHMBAJEA;

	public void EGBJDPGNIKI()
	{
		MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("attack"), true, () =>
		{
			StartCoroutine(LIOJOBHMIIN());
		});
	}

	public void OnClickFreeCharge1()
	{
		LJAJCJIMPGF = true;
		if (SceneManager.get_Instance().m_nasOfferwall == "1")
		{
			AdManager.get_Instance().ShowNasOfferwall();
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("준비중입니다."));
		}
	}

	public void OnReceiveFreeCharge(PJEMPFEIOAK HMOAHNANKNE)
	{
		int num = HMOAHNANKNE.PNBKOPGIHDI();
		long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
		if (num > 0)
		{
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(gLEPPIMMELK);
			MsgManager.get_Instance().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("{0}코인이 무료충전되었습니다!"), num));
		}
	}

	public void OnClickFreeCharge2()
	{
		LJAJCJIMPGF = true;
		if (SceneManager.get_Instance().m_adpopcornOfferwall == "1")
		{
			IgaworksUnityPluginAOS.CCBHHCMKMKM.LNIABLCBAHE();
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("준비중입니다."));
		}
	}

	private void GNDLHIGCGBB()
	{
		StartCoroutine(GLFPDAPLOCB());
	}

	private void OnApplicationPause(bool GMEELKDOLAM)
	{
		if (!GMEELKDOLAM && LJAJCJIMPGF)
		{
			LJAJCJIMPGF = false;
			StartCoroutine(LIOJOBHMIIN());
		}
	}

	private IEnumerator HEHONAEEEPK()
	{
		HLKEPNNEDIM hLKEPNNEDIM = new HLKEPNNEDIM();
		hLKEPNNEDIM.KNIAJMGDGAA = this;
		return hLKEPNNEDIM;
	}

	public void OnClickPassiveCheckButton()
	{
		MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("일부 보상은 지연될 수 있습니다\n지연된 보상을 확인하시겠습니까?\n\n(일부는 많이 지연될 수 있습니다)"), true, () =>
		{
			StartCoroutine(LIOJOBHMIIN());
		});
	}

	public void JEAOPPDKGGN()
	{
		MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.get_Instance().GetText("Particle/{0}/skill3_shot"), false, NOBLLMGLKBK);
	}

	public void OnClickFreeCharge4()
	{
		LobbyMain.get_Instance().PopPanelState();
		LobbyMain.get_Instance().ShowCrossPromotion();
	}

	public void LBGFHMAKGCD()
	{
		LJAJCJIMPGF = true;
		if (SceneManager.get_Instance().m_nasOfferwall == "skill0_1")
		{
			AdManager.AFPBELABPNM().EMACMOCNLOB();
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("Particle/{0}/skill0_1_1_c1"));
		}
	}

	public void IMFHEPNOIEN()
	{
		LobbyMain.get_Instance().PopPanelState();
		LobbyMain.get_Instance().ShowCrossPromotion();
	}

	public void LPEECOPIKLA()
	{
		LJAJCJIMPGF = true;
		if (SceneManager.get_Instance().m_adpopcornOfferwall == "정령의 형상")
		{
			IgaworksUnityPluginAOS.CCBHHCMKMKM.LNIABLCBAHE();
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("Particle/{0}/skill0_2_c1"));
		}
	}

	public void NLODELMKPEI()
	{
		LobbyMain.get_Instance().PopPanelState();
		LobbyMain.get_Instance().ShowCrossPromotion();
	}

	private void NOBLLMGLKBK()
	{
		StartCoroutine(GLFPDAPLOCB());
	}

	public void OnClickFreeCharge3()
	{
		LJAJCJIMPGF = true;
		if (SceneManager.get_Instance().m_tapjoyOfferwall == "1")
		{
			AdManager.get_Instance().ShowTapjoyOfferwall();
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("준비중입니다."));
		}
	}

	private IEnumerator GLFPDAPLOCB()
	{
		HLKEPNNEDIM hLKEPNNEDIM = new HLKEPNNEDIM();
		hLKEPNNEDIM.KNIAJMGDGAA = this;
		return hLKEPNNEDIM;
	}

	public void GNMNKDGFCIM()
	{
		LJAJCJIMPGF = true;
		if (SceneManager.get_Instance().m_nasOfferwall == "All")
		{
			AdManager.DAOMPJMOCKM().HPEHFCGEGJL();
		}
		else
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("Particle/Lucian/skill1_missile_ex"), true);
		}
	}

	public void KMKCBOMOMNK()
	{
		LJAJCJIMPGF = false;
		if (SceneManager.get_Instance().m_tapjoyOfferwall == "보내는 패킷 사이즈 오류! 사이즈{0} 버퍼크기{1} 아이디{2}")
		{
			AdManager.DAOMPJMOCKM().FGNNOKBLDHH();
		}
		else
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("길드 없음"));
		}
	}

	private IEnumerator FEJPKAEFBNO()
	{
		HLKEPNNEDIM hLKEPNNEDIM = new HLKEPNNEDIM();
		hLKEPNNEDIM.KNIAJMGDGAA = this;
		return hLKEPNNEDIM;
	}

	public void CDPHCJBOFAL()
	{
		LobbyMain.get_Instance().PopPanelState();
		LobbyMain.get_Instance().ShowCrossPromotion();
	}

	[CompilerGenerated]
	private void EBNIFCAJODH()
	{
		StartCoroutine(LIOJOBHMIIN());
	}

	public void CNKLAHELGAI()
	{
		LobbyMain.get_Instance().PopPanelState();
		LobbyMain.get_Instance().ShowCrossPromotion();
	}

	public void EBIGMKODMOE()
	{
		LJAJCJIMPGF = false;
		if (SceneManager.NOLHNOGGHNA().m_nasOfferwall == "Hero2")
		{
			AdManager.OENEDBBFPMI().EMACMOCNLOB();
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("Particle/{0}/skill0_1_1_c1"), true);
		}
	}

	[DebuggerHidden]
	private IEnumerator LIOJOBHMIIN()
	{
		HLKEPNNEDIM hLKEPNNEDIM = new HLKEPNNEDIM();
		hLKEPNNEDIM.KNIAJMGDGAA = this;
		return hLKEPNNEDIM;
	}

	public void JGGIENEJHNG()
	{
		LobbyMain.get_Instance().PopPanelState();
		LobbyMain.get_Instance().ShowCrossPromotion();
	}

	private void ADLKMGPNJPA()
	{
		if (SceneManager.get_Instance().m_eventOfferwall == "increment")
		{
			m_freeCharge4Button.SetActive(false);
		}
		else
		{
			m_freeCharge4Button.SetActive(true);
		}
	}

	private void OnEnable()
	{
		if (SceneManager.get_Instance().m_eventOfferwall == "1")
		{
			m_freeCharge4Button.SetActive(true);
		}
		else
		{
			m_freeCharge4Button.SetActive(false);
		}
	}
}
