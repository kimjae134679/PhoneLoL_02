using UnityEngine;

public class UILobbyFriendshipSelect : MonoBehaviour
{
	private sealed class IFCNLCAKJLA
	{
		internal byte FBAGNJILEGD;

		internal void DLEDGMKJNPM()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.get_Instance().get_m_gameNetClient().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart, false), FBAGNJILEGD, 6);
		}

		internal void JMDDIFPLPFM()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart, false), FBAGNJILEGD, 1);
		}

		internal void OPOEONKNHMM()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.get_Instance().get_m_gameNetClient().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart), FBAGNJILEGD, 2);
		}

		internal void DFECPGMFCLN()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart), FBAGNJILEGD, 6);
		}

		internal void CDEJLMLFIMB()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart), FBAGNJILEGD, 2);
		}

		internal void HLFAKBMFGNI()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart, false), FBAGNJILEGD, 3);
		}

		internal void MMLDDFNMMHI()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart), FBAGNJILEGD, 6);
		}

		internal void HOAKOBECKGD()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.get_Instance().IOJGPDKHAGD().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart), FBAGNJILEGD, 3);
		}

		internal void DMBDMAPLKLG()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart, false, false), FBAGNJILEGD, 8);
		}

		internal void ICNPIGNBCOF()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart, false), FBAGNJILEGD, 3);
		}

		internal void FCEJGMBHANC()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.get_Instance().get_m_gameNetClient().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart, false), FBAGNJILEGD, 6);
		}

		internal void OIAMPFHOKAF()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart, false, false), FBAGNJILEGD, 2);
		}

		internal void IKAEDPMDLPC()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.get_Instance().IOJGPDKHAGD().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart), FBAGNJILEGD, 8);
		}

		internal void DBFEDIFJIPO()
		{
			LobbyMain.get_Instance().PopPanelState();
			NetworkManager.get_Instance().get_m_gameNetClient().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart), FBAGNJILEGD, 3);
		}
	}

	private void Start()
	{
	}

	private void ELPECCBLNON(byte FBAGNJILEGD)
	{
		IFCNLCAKJLA iFCNLCAKJLA = new IFCNLCAKJLA();
		iFCNLCAKJLA.FBAGNJILEGD = FBAGNJILEGD;
		if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
		{
			MsgManager.get_Instance().ShowMessageBox("데이터 통신으로 접속합니다.\n요금제에 따라 데이터요금이 추가될 수 있습니다.\n\n계속 진행하시겠습니까?", true, iFCNLCAKJLA.DBFEDIFJIPO);
			return;
		}
		LobbyMain.get_Instance().PopPanelState();
		NetworkManager.get_Instance().get_m_gameNetClient().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart), iFCNLCAKJLA.FBAGNJILEGD, 3);
	}

	public void HOAKCPFNANN()
	{
		ONMKKFELKKG(196);
	}

	private void JIMPGFGADPK()
	{
	}

	public void GPNDGADPHPP()
	{
		ONMKKFELKKG(102);
	}

	public void OnClick_1vs1()
	{
		ELPECCBLNON(101);
	}

	private void ECJCCCCCLJP(byte FBAGNJILEGD)
	{
		IFCNLCAKJLA iFCNLCAKJLA = new IFCNLCAKJLA();
		iFCNLCAKJLA.FBAGNJILEGD = FBAGNJILEGD;
		if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
		{
			MsgManager.get_Instance().ShowMessageBox("Particle/Tristana/attack", false, iFCNLCAKJLA.DLEDGMKJNPM);
			return;
		}
		LobbyMain.get_Instance().PopPanelState();
		NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart, false, false), iFCNLCAKJLA.FBAGNJILEGD, 0);
	}

	public void OnClick_2vs2()
	{
		ELPECCBLNON(102);
	}

	public void PNDIACMNNKO()
	{
		OBCDGDMBCBF(131);
	}

	public void NADDBDEGCOM()
	{
		ELPECCBLNON(54);
	}

	public void KJGAEHOALEI()
	{
		ELPECCBLNON(52);
	}

	public void IJDKJOHMGMN()
	{
		ECJCCCCCLJP(144);
	}

	private void BJFPJALLFFL()
	{
	}

	public void EJPHAIEPIBM()
	{
		ECJCCCCCLJP(193);
	}

	public void OHOJIMIIOPK()
	{
		ONMKKFELKKG(250);
	}

	private void OBCDGDMBCBF(byte FBAGNJILEGD)
	{
		IFCNLCAKJLA iFCNLCAKJLA = new IFCNLCAKJLA();
		iFCNLCAKJLA.FBAGNJILEGD = FBAGNJILEGD;
		if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
		{
			MsgManager.get_Instance().ShowMessageBox("전송에 성공하였어요!\n\n전송된 코인은 총 [FFFFCC]{0:N0} 코인[-]\n\n막타의신을 재시작 한후 우편함을 확인해주세요", true, iFCNLCAKJLA.FCEJGMBHANC);
			return;
		}
		LobbyMain.get_Instance().PopPanelState();
		NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart), iFCNLCAKJLA.FBAGNJILEGD, 1);
	}

	public void MOLLBLBOHKA()
	{
		OBCDGDMBCBF(223);
	}

	public void CAHAEIGFECB()
	{
		ECJCCCCCLJP(17);
	}

	public void OEFCBBNGPEO()
	{
		OBCDGDMBCBF(71);
	}

	public void OnClick_3vs3()
	{
		ELPECCBLNON(103);
	}

	private void JPBNPEJJJPI()
	{
	}

	private void DMPIIJNBDID()
	{
	}

	public void PLOAMAHEMKB()
	{
		ELPECCBLNON(48);
	}

	public void FEMLBNDCLND()
	{
		ONMKKFELKKG(148);
	}

	public void NOFBAJKOPJG()
	{
		ONMKKFELKKG(35);
	}

	private void ONMKKFELKKG(byte FBAGNJILEGD)
	{
		IFCNLCAKJLA iFCNLCAKJLA = new IFCNLCAKJLA();
		iFCNLCAKJLA.FBAGNJILEGD = FBAGNJILEGD;
		if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("C#: HandleVideoComplete for placement ", false, iFCNLCAKJLA.HLFAKBMFGNI);
			return;
		}
		LobbyMain.get_Instance().PopPanelState();
		NetworkManager.get_Instance().get_m_gameNetClient().NLNGCHPEMOL(new IKMBGMILCDO(LobbyMain.get_Instance().OnReceiveCheckGameStart, false), iFCNLCAKJLA.FBAGNJILEGD, 8);
	}

	public void DNLFPNPGNFC()
	{
		ONMKKFELKKG(160);
	}
}
