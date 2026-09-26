using System.Runtime.CompilerServices;
using UnityEngine;

public class UILobbyRankGameSelect : MonoBehaviour
{
	private sealed class OAGJAABGAPO
	{
		internal byte FBAGNJILEGD;

		internal PNDMCOBIODO.HGMJFFOIICM HKFPPOJJKON;

		internal UILobbyRankGameSelect KNIAJMGDGAA;

		internal void GBMPDPNPLNE()
		{
			KNIAJMGDGAA.HMDGAELHDAE(FBAGNJILEGD, HKFPPOJJKON);
		}

		internal void GCANGDKBHEH()
		{
			KNIAJMGDGAA.CHCPLPLNGLN(FBAGNJILEGD, HKFPPOJJKON);
		}

		internal void DHHDOJOHMEL()
		{
			KNIAJMGDGAA.CHCPLPLNGLN(FBAGNJILEGD, HKFPPOJJKON);
		}

		internal void CBIIKMICPOK()
		{
			KNIAJMGDGAA.JPJKKNCMBLF(FBAGNJILEGD, HKFPPOJJKON);
		}

		internal void MDICNNFHJNN()
		{
			KNIAJMGDGAA.HMDGAELHDAE(FBAGNJILEGD, HKFPPOJJKON);
		}

		internal void JEMEODJFNIM()
		{
			KNIAJMGDGAA.IGHIBGKMCFD(FBAGNJILEGD, HKFPPOJJKON);
		}

		internal void KOMCMGBDGPO()
		{
			KNIAJMGDGAA.CHCPLPLNGLN(FBAGNJILEGD, HKFPPOJJKON);
		}
	}

	public void CAJLNFKDODM()
	{
		if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("attack3", false, HFDBJOEIJNM);
		}
		else
		{
			CPJAJCGCAFP(0, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
		}
	}

	private void HEKOGEBFANK()
	{
		CPJAJCGCAFP(249, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
	}

	private void BPEOOGIFJMN(byte GBOELKENGEK, PNDMCOBIODO.HGMJFFOIICM HKFPPOJJKON)
	{
		LobbyMain.get_Instance().PopPanelState();
		NetworkManager.APAPJEIBEDE().get_m_gameNetClient().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart, true, false), GBOELKENGEK, (byte)HKFPPOJJKON);
	}

	public void ShowMtmQuickSearchWithMessage()
	{
		if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
		{
			MsgManager.get_Instance().ShowMessageBox("데이터 통신으로 접속합니다.\n요금제에 따라 데이터요금이 추가될 수 있습니다.\n\n계속 진행하시겠습니까?", true, () =>
			{
				CPJAJCGCAFP(20, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
			});
		}
		else
		{
			CPJAJCGCAFP(20, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
		}
	}

	private void DDHDFKCIPFG()
	{
		CLMFHOIJPEF(92, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
	}

	public void MJHPMNBCHEM()
	{
		if (Application.internetReachability == NetworkReachability.NotReachable)
		{
			MsgManager.get_Instance().ShowMessageBox("레벨당 마나", false, DDHDFKCIPFG);
		}
		else
		{
			CLMFHOIJPEF(109, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
		}
	}

	private void HFDBJOEIJNM()
	{
		CPJAJCGCAFP(0, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
	}

	private void IGHIBGKMCFD(byte GBOELKENGEK, PNDMCOBIODO.HGMJFFOIICM HKFPPOJJKON)
	{
		LobbyMain.get_Instance().PopPanelState();
		NetworkManager.get_Instance().IOJGPDKHAGD().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart, false), GBOELKENGEK, (byte)HKFPPOJJKON);
	}

	private void AOINMLMCJOP()
	{
		CLMFHOIJPEF(0, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
	}

	public void PACJBEJHMCI()
	{
		if (Application.internetReachability == NetworkReachability.NotReachable)
		{
			MsgManager.get_Instance().ShowMessageBox("soraka_protectionofstar", true, () =>
			{
				CPJAJCGCAFP(0, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
			});
		}
		else
		{
			CPJAJCGCAFP(0, PNDMCOBIODO.HGMJFFOIICM.PASSIVE_CREATE_ROOM);
		}
	}

	private void MGBNNFMNLAC()
	{
		CPJAJCGCAFP(149, PNDMCOBIODO.HGMJFFOIICM.PASSIVE_CREATE_ROOM);
	}

	private void CPJAJCGCAFP(byte FBAGNJILEGD, PNDMCOBIODO.HGMJFFOIICM HKFPPOJJKON)
	{
		OAGJAABGAPO oAGJAABGAPO = new OAGJAABGAPO();
		oAGJAABGAPO.FBAGNJILEGD = FBAGNJILEGD;
		oAGJAABGAPO.HKFPPOJJKON = HKFPPOJJKON;
		oAGJAABGAPO.KNIAJMGDGAA = this;
		if (NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.CMKGCKMLBBK() && !NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.JNFMENKGNOD())
		{
			MsgManager.get_Instance().ShowMessageBox("[FFCCCC]트롤 행위 위험 수준이에요[-]\n\n탈주나 트롤행위시 게임이용에 제한이 생겨요\n(성실 플레이를 하시면 위험 수준이 낮아져요)", false, oAGJAABGAPO.GCANGDKBHEH);
		}
		else
		{
			CHCPLPLNGLN(oAGJAABGAPO.FBAGNJILEGD, oAGJAABGAPO.HKFPPOJJKON);
		}
	}

	private void JPJKKNCMBLF(byte GBOELKENGEK, PNDMCOBIODO.HGMJFFOIICM HKFPPOJJKON)
	{
		LobbyMain.get_Instance().PopPanelState();
		NetworkManager.APAPJEIBEDE().get_m_gameNetClient().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart), GBOELKENGEK, (byte)HKFPPOJJKON);
	}

	private void KOGCMCKNOKD()
	{
		CPJAJCGCAFP(31, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
	}

	[CompilerGenerated]
	private void MGJLMMNNFDC()
	{
		CPJAJCGCAFP(0, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
	}

	public void GKHDCKEMALF()
	{
		if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("사거리 안에 미니언이 없으면 헛공격을 하게 됩니다.", false, HDIBMKCAEOK);
		}
		else
		{
			CLMFHOIJPEF(252, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
		}
	}

	public void KMMKLGDOGNL()
	{
		if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
		{
			MsgManager.get_Instance().ShowMessageBox("설명", true, HEKOGEBFANK);
		}
		else
		{
			CPJAJCGCAFP(118, PNDMCOBIODO.HGMJFFOIICM.PASSIVE_CREATE_ROOM);
		}
	}

	public void ShowQuickSearchWithMessage()
	{
		if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
		{
			MsgManager.get_Instance().ShowMessageBox("데이터 통신으로 접속합니다.\n요금제에 따라 데이터요금이 추가될 수 있습니다.\n\n계속 진행하시겠습니까?", true, () =>
			{
				CPJAJCGCAFP(0, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
			});
		}
		else
		{
			CPJAJCGCAFP(0, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
		}
	}

	private void HNMNPFDEMOI()
	{
		CPJAJCGCAFP(44, PNDMCOBIODO.HGMJFFOIICM.PASSIVE_CREATE_ROOM);
	}

	private void HDIBMKCAEOK()
	{
		CPJAJCGCAFP(174, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
	}

	private void HMDGAELHDAE(byte GBOELKENGEK, PNDMCOBIODO.HGMJFFOIICM HKFPPOJJKON)
	{
		LobbyMain.get_Instance().PopPanelState();
		NetworkManager.APAPJEIBEDE().get_m_gameNetClient().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart), GBOELKENGEK, (byte)HKFPPOJJKON);
	}

	public void LKACBOMFJIF()
	{
		if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("Type of observed is unknown when receiving.", false, HDIBMKCAEOK);
		}
		else
		{
			CPJAJCGCAFP(18, PNDMCOBIODO.HGMJFFOIICM.PASSIVE_CREATE_ROOM);
		}
	}

	private void GJJHECPGMEN()
	{
		CPJAJCGCAFP(0, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
	}

	public void BHCFLJOKDIP()
	{
		if (Application.internetReachability == NetworkReachability.NotReachable)
		{
			MsgManager.get_Instance().ShowMessageBox("UIWidgets must fill the buffer with 4 vertices per quad. Found ", true, DDHDFKCIPFG);
		}
		else
		{
			CLMFHOIJPEF(14, PNDMCOBIODO.HGMJFFOIICM.PASSIVE_CREATE_ROOM);
		}
	}

	private void HMCIGJELFPL()
	{
		CLMFHOIJPEF(81, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
	}

	private void CHCPLPLNGLN(byte GBOELKENGEK, PNDMCOBIODO.HGMJFFOIICM HKFPPOJJKON)
	{
		LobbyMain.get_Instance().PopPanelState();
		NetworkManager.get_Instance().get_m_gameNetClient().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart), GBOELKENGEK, (byte)HKFPPOJJKON);
	}

	public void NEEHFIEJCFJ()
	{
		if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("가능한 적이 없습니다", false, HEKOGEBFANK);
		}
		else
		{
			CLMFHOIJPEF(52, PNDMCOBIODO.HGMJFFOIICM.PASSIVE_CREATE_ROOM);
		}
	}

	public void CLEANDIDMJB()
	{
		if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
		{
			MsgManager.get_Instance().ShowMessageBox("Touch Start/Up", true, () =>
			{
				CPJAJCGCAFP(0, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
			});
		}
		else
		{
			CLMFHOIJPEF(1, PNDMCOBIODO.HGMJFFOIICM.PASSIVE_CREATE_ROOM);
		}
	}

	public void DPIAODFEFCJ()
	{
		if (Application.internetReachability == NetworkReachability.NotReachable)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("The increment value must be between 0 and 16777215 (it must fit in 3 bytes).", true, HNMNPFDEMOI);
		}
		else
		{
			CLMFHOIJPEF(248, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
		}
	}

	private void CLMFHOIJPEF(byte FBAGNJILEGD, PNDMCOBIODO.HGMJFFOIICM HKFPPOJJKON)
	{
		OAGJAABGAPO oAGJAABGAPO = new OAGJAABGAPO();
		oAGJAABGAPO.FBAGNJILEGD = FBAGNJILEGD;
		oAGJAABGAPO.HKFPPOJJKON = HKFPPOJJKON;
		oAGJAABGAPO.KNIAJMGDGAA = this;
		if (NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.CMKGCKMLBBK() && !NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
			.JNFMENKGNOD())
		{
			MsgManager.get_Instance().ShowMessageBox("Particle/{0}/skill0_2_1_c1", false, oAGJAABGAPO.DHHDOJOHMEL);
		}
		else
		{
			CHCPLPLNGLN(oAGJAABGAPO.FBAGNJILEGD, oAGJAABGAPO.HKFPPOJJKON);
		}
	}

	public void APIOAPDJHML()
	{
		if (Application.internetReachability == NetworkReachability.NotReachable)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("stun", true, HFDBJOEIJNM);
		}
		else
		{
			CPJAJCGCAFP(0, PNDMCOBIODO.HGMJFFOIICM.PASSIVE_CREATE_ROOM);
		}
	}

	[CompilerGenerated]
	private void OMNGKADJPHO()
	{
		CPJAJCGCAFP(20, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
	}
}
