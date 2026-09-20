using UnityEngine;

public class UILobbyNormalGameSelect : MonoBehaviour
{
	private sealed class OHFCNMLOBAD
	{
		internal byte FBAGNJILEGD;

		internal PNDMCOBIODO.HGMJFFOIICM HKFPPOJJKON;

		internal void OAGNDFOMEDI()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.get_Instance().get_m_gameNetClient().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart, true, false), FBAGNJILEGD, (byte)HKFPPOJJKON);
		}

		internal void OALFANAFKIB()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart, true, false), FBAGNJILEGD, (byte)HKFPPOJJKON);
		}

		internal void LFGBFFLDHKM()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart, false), FBAGNJILEGD, (byte)HKFPPOJJKON);
		}

		internal void DJDDLAFPHIC()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart, true, false), FBAGNJILEGD, (byte)HKFPPOJJKON);
		}

		internal void PCBDDCMEMJH()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.get_Instance().get_m_gameNetClient().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart, true, false), FBAGNJILEGD, (byte)HKFPPOJJKON);
		}

		internal void FLGPAMGOAAE()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.get_Instance().get_m_gameNetClient().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart), FBAGNJILEGD, (byte)HKFPPOJJKON);
		}

		internal void FLDDENOGADK()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart, true, false), FBAGNJILEGD, (byte)HKFPPOJJKON);
		}

		internal void NBDKBIMCNML()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart, true, false), FBAGNJILEGD, (byte)HKFPPOJJKON);
		}

		internal void OCCDFBLJLNF()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.get_Instance().get_m_gameNetClient().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart), FBAGNJILEGD, (byte)HKFPPOJJKON);
		}

		internal void HFJOCJECJFN()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart, false), FBAGNJILEGD, (byte)HKFPPOJJKON);
		}

		internal void LDPEKGHIEEA()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart, true, false), FBAGNJILEGD, (byte)HKFPPOJJKON);
		}
	}

	private void NMANMMOMHHD()
	{
	}

	private void EGICIKIFCGI(byte FBAGNJILEGD, PNDMCOBIODO.HGMJFFOIICM HKFPPOJJKON)
	{
		OHFCNMLOBAD oHFCNMLOBAD = new OHFCNMLOBAD();
		oHFCNMLOBAD.FBAGNJILEGD = FBAGNJILEGD;
		oHFCNMLOBAD.HKFPPOJJKON = HKFPPOJJKON;
		if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
		{
			MsgManager.get_Instance().ShowMessageBox("skill0", true, oHFCNMLOBAD.NBDKBIMCNML);
			return;
		}
		LobbyMain.get_Instance().PopPanelState();
		NetworkManager.get_Instance().IOJGPDKHAGD().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart), oHFCNMLOBAD.FBAGNJILEGD, (byte)oHFCNMLOBAD.HKFPPOJJKON);
	}

	private void LCPCELAJEDO(byte FBAGNJILEGD, PNDMCOBIODO.HGMJFFOIICM HKFPPOJJKON)
	{
		OHFCNMLOBAD oHFCNMLOBAD = new OHFCNMLOBAD();
		oHFCNMLOBAD.FBAGNJILEGD = FBAGNJILEGD;
		oHFCNMLOBAD.HKFPPOJJKON = HKFPPOJJKON;
		if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("skill0_missile_hit", false, oHFCNMLOBAD.LDPEKGHIEEA);
			return;
		}
		LobbyMain.get_Instance().PopPanelState();
		NetworkManager.get_Instance().IOJGPDKHAGD().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart), oHFCNMLOBAD.FBAGNJILEGD, (byte)oHFCNMLOBAD.HKFPPOJJKON);
	}

	private void AGFMHMLGEGP(byte FBAGNJILEGD, PNDMCOBIODO.HGMJFFOIICM HKFPPOJJKON)
	{
		OHFCNMLOBAD oHFCNMLOBAD = new OHFCNMLOBAD();
		oHFCNMLOBAD.FBAGNJILEGD = FBAGNJILEGD;
		oHFCNMLOBAD.HKFPPOJJKON = HKFPPOJJKON;
		if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("하급 마법저항력 정수", false, oHFCNMLOBAD.LFGBFFLDHKM);
			return;
		}
		LobbyMain.get_Instance().PopPanelState();
		NetworkManager.get_Instance().get_m_gameNetClient().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart, false), oHFCNMLOBAD.FBAGNJILEGD, (byte)oHFCNMLOBAD.HKFPPOJJKON);
	}

	public void DKCHJAOPCFH()
	{
		AGFMHMLGEGP(111, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
	}

	public void JDCKFLNDPAJ()
	{
		AGFMHMLGEGP(122, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
	}

	public void MLADHFCHAFP()
	{
		OBCDGDMBCBF(208, PNDMCOBIODO.HGMJFFOIICM.PASSIVE_CREATE_ROOM);
	}

	private void CLLECEEEJAI()
	{
	}

	public void GEBDPMBIIBG()
	{
		AGFMHMLGEGP(164, PNDMCOBIODO.HGMJFFOIICM.PASSIVE_CREATE_ROOM);
	}

	public void LECHCHMLNOC()
	{
		AGFMHMLGEGP(33, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
	}

	public void OnClickPlayGame()
	{
		ELPECCBLNON(10, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
	}

	private void DMPIIJNBDID()
	{
	}

	private void OBCDGDMBCBF(byte FBAGNJILEGD, PNDMCOBIODO.HGMJFFOIICM HKFPPOJJKON)
	{
		OHFCNMLOBAD oHFCNMLOBAD = new OHFCNMLOBAD();
		oHFCNMLOBAD.FBAGNJILEGD = FBAGNJILEGD;
		oHFCNMLOBAD.HKFPPOJJKON = HKFPPOJJKON;
		if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
		{
			MsgManager.get_Instance().ShowMessageBox("Death{0}", true, oHFCNMLOBAD.FLGPAMGOAAE);
			return;
		}
		LobbyMain.get_Instance().PopPanelState();
		NetworkManager.get_Instance().get_m_gameNetClient().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart), oHFCNMLOBAD.FBAGNJILEGD, (byte)oHFCNMLOBAD.HKFPPOJJKON);
	}

	public void OnClickCreateRoom()
	{
		ELPECCBLNON(10, PNDMCOBIODO.HGMJFFOIICM.PASSIVE_CREATE_ROOM);
	}

	public void PPMKNLAOMOD()
	{
		AGFMHMLGEGP(72, PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH);
	}

	private void ELPECCBLNON(byte FBAGNJILEGD, PNDMCOBIODO.HGMJFFOIICM HKFPPOJJKON)
	{
		OHFCNMLOBAD oHFCNMLOBAD = new OHFCNMLOBAD();
		oHFCNMLOBAD.FBAGNJILEGD = FBAGNJILEGD;
		oHFCNMLOBAD.HKFPPOJJKON = HKFPPOJJKON;
		if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
		{
			MsgManager.get_Instance().ShowMessageBox("데이터 통신으로 접속합니다.\n요금제에 따라 데이터요금이 추가될 수 있습니다.\n\n계속 진행하시겠습니까?", true, oHFCNMLOBAD.FLGPAMGOAAE);
			return;
		}
		LobbyMain.get_Instance().PopPanelState();
		NetworkManager.get_Instance().get_m_gameNetClient().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart), oHFCNMLOBAD.FBAGNJILEGD, (byte)oHFCNMLOBAD.HKFPPOJJKON);
	}

	private void Start()
	{
	}
}
