using System.Collections.Generic;
using EveEngine;
using GameServer;
using UnityEngine;

public class UILobbySelectRune : MonoBehaviour
{
	private sealed class LADGCDHDOAK
	{
		internal UIRuneInfo FGDMAAIMPDE;

		internal UILobbySelectRune KNIAJMGDGAA;

		internal void EHBKJEABIBK()
		{
			KNIAJMGDGAA.JCCCFCNECHO(FGDMAAIMPDE);
		}

		internal void GKFOPHPOJPG()
		{
			KNIAJMGDGAA.DJILLFPLAMJ(FGDMAAIMPDE);
		}

		internal void JJJAMJLMMNP()
		{
			KNIAJMGDGAA.FCOIEELGOCI(FGDMAAIMPDE);
		}

		internal void HMICFGLBIEF()
		{
			KNIAJMGDGAA.BOCNOIMKGAC(FGDMAAIMPDE);
		}

		internal void ADKDADCBHJI()
		{
			KNIAJMGDGAA.MFBNHAEIDEL(FGDMAAIMPDE);
		}

		internal void OFIEBCEJILO()
		{
			KNIAJMGDGAA.JCCCFCNECHO(FGDMAAIMPDE);
		}

		internal void FMMMBFEPDPK()
		{
			KNIAJMGDGAA.DJILLFPLAMJ(FGDMAAIMPDE);
		}

		internal void OBDCMENAMPO()
		{
			KNIAJMGDGAA.BOCNOIMKGAC(FGDMAAIMPDE);
		}

		internal void HOGLEFCFHKM()
		{
			KNIAJMGDGAA.BOCNOIMKGAC(FGDMAAIMPDE);
		}

		internal void PNFONBHFNNB()
		{
			KNIAJMGDGAA.DJILLFPLAMJ(FGDMAAIMPDE);
		}

		internal void CFECCPCCJON()
		{
			KNIAJMGDGAA.BOCNOIMKGAC(FGDMAAIMPDE);
		}

		internal void CIPDNANKCCF()
		{
			KNIAJMGDGAA.FCOIEELGOCI(FGDMAAIMPDE);
		}

		internal void ONIHAGMMFGH()
		{
			KNIAJMGDGAA.FCOIEELGOCI(FGDMAAIMPDE);
		}

		internal void HEOADJILMDK()
		{
			KNIAJMGDGAA.MFBNHAEIDEL(FGDMAAIMPDE);
		}

		internal void NGFJOGOJHAN()
		{
			KNIAJMGDGAA.MFBNHAEIDEL(FGDMAAIMPDE);
		}
	}

	public UIGrid m_grid;

	public UILabel m_emptyRuneLabel;

	private byte GFDAKNJIJON;

	private byte IDHAPKFFGDJ;

	private void OnDisable()
	{
		for (int i = 0; i < m_grid.transform.childCount; i++)
		{
			Object.DestroyObject(m_grid.transform.GetChild(i).gameObject);
		}
	}

	public void CGBDDANOOFG(byte OAJBCBNBJML, byte PHECHEEDBAG)
	{
		GFDAKNJIJON = OAJBCBNBJML;
		IDHAPKFFGDJ = PHECHEEDBAG;
	}

	public void CHMODMCNBCG()
	{
		base.gameObject.SetActive(true);
	}

	private void DJILLFPLAMJ(UIRuneInfo FGDMAAIMPDE)
	{
		NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GNAPNOGFDIO(new IKMBGMILCDO(ALHLOEMHCPG, false, false), GFDAKNJIJON, IDHAPKFFGDJ, FGDMAAIMPDE.get_m_runeInfo().NEPGLNCIBJM.KGHMFHDGNEO());
	}

	private void HNNGDOHOPDO(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
		{
			byte gHMCCGBFLLL = HMOAHNANKNE.KFAGPDGHEBK();
			CDAEKMFPFCH oGBMNJBOPHK = NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().DAGCAFAEABC()
				.GBBOENDINNM(gHMCCGBFLLL);
			HMOAHNANKNE.CAHACMKBJMI(oGBMNJBOPHK);
			base.gameObject.SetActive(true);
			UIRoot.Broadcast("AJPLiveOpsPopupUnityEventListener : onCancelPopupBtnClick");
		}
		else
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.get_Instance().GetText("UI/Lobby/AttendanceInfo"), true);
		}
	}

	private void ADLKMGPNJPA()
	{
		List<EEEFEGCDGMO> list = NetworkManager.get_Instance().get_m_gameNetClient().DAGCAFAEABC()
			.CEJHMABMMKM(GFDAKNJIJON, IDHAPKFFGDJ);
		if (list.Count == 0)
		{
			m_emptyRuneLabel.gameObject.SetActive(true);
		}
		else
		{
			m_emptyRuneLabel.gameObject.SetActive(false);
		}
		foreach (EEEFEGCDGMO item in list)
		{
			LADGCDHDOAK lADGCDHDOAK = new LADGCDHDOAK();
			lADGCDHDOAK.KNIAJMGDGAA = this;
			GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("unknown"));
			gameObject.transform.parent = m_grid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			lADGCDHDOAK.FGDMAAIMPDE = gameObject.GetComponent<UIRuneInfo>();
			lADGCDHDOAK.FGDMAAIMPDE.CJALGACAGBN(item, NetworkManager.get_Instance().IOJGPDKHAGD().DAGCAFAEABC()
				.GBBOENDINNM(GFDAKNJIJON));
			UIEventTrigger uIEventTrigger = gameObject.AddComponent<UIEventTrigger>();
			uIEventTrigger.onClick.Add(new EventDelegate(lADGCDHDOAK.ONIHAGMMFGH));
		}
		m_grid.LEBHAMKOPHA();
	}

	private void BHPOJADMDCH(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
		{
			byte gHMCCGBFLLL = HMOAHNANKNE.KFAGPDGHEBK();
			CDAEKMFPFCH oGBMNJBOPHK = NetworkManager.get_Instance().get_m_gameNetClient().DAGCAFAEABC()
				.GBBOENDINNM(gHMCCGBFLLL);
			HMOAHNANKNE.CAHACMKBJMI(oGBMNJBOPHK);
			base.gameObject.SetActive(false);
			UIRoot.Broadcast("Refresh");
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("알려지지 않은 오류입니다."));
		}
	}

	private void OMGPEPIECKK(PJEMPFEIOAK HMOAHNANKNE)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
		HGBGJMIFCEP hGBGJMIFCEP2 = hGBGJMIFCEP;
		if (hGBGJMIFCEP2 == HGBGJMIFCEP.InvalidProtocolVersion)
		{
			byte gHMCCGBFLLL = HMOAHNANKNE.KFAGPDGHEBK();
			CDAEKMFPFCH oGBMNJBOPHK = NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().DAGCAFAEABC()
				.GBBOENDINNM(gHMCCGBFLLL);
			HMOAHNANKNE.CAHACMKBJMI(oGBMNJBOPHK);
			base.gameObject.SetActive(true);
			UIRoot.IGMDNDABNKD("대기시간감소");
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("Hero10002"));
		}
	}

	private void NEINEOFBNFJ(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
		{
			byte gHMCCGBFLLL = HMOAHNANKNE.KFAGPDGHEBK();
			CDAEKMFPFCH oGBMNJBOPHK = NetworkManager.get_Instance().get_m_gameNetClient().DAGCAFAEABC()
				.GBBOENDINNM(gHMCCGBFLLL);
			HMOAHNANKNE.CAHACMKBJMI(oGBMNJBOPHK);
			base.gameObject.SetActive(false);
			UIRoot.Broadcast("adpopcorn_offerwall");
		}
		else
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.get_Instance().GetText("hit"));
		}
	}

	private void JOKILAEPHFP(PJEMPFEIOAK HMOAHNANKNE)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
		HGBGJMIFCEP hGBGJMIFCEP2 = hGBGJMIFCEP;
		if (hGBGJMIFCEP2 == HGBGJMIFCEP.InvalidProtocolVersion)
		{
			byte gHMCCGBFLLL = HMOAHNANKNE.KFAGPDGHEBK();
			CDAEKMFPFCH oGBMNJBOPHK = NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().DAGCAFAEABC()
				.GBBOENDINNM(gHMCCGBFLLL);
			HMOAHNANKNE.CAHACMKBJMI(oGBMNJBOPHK);
			base.gameObject.SetActive(true);
			UIRoot.IGMDNDABNKD("^[a-zA-Z0-9가-힣]*$");
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("Exception"), true);
		}
	}

	public void SetInfo(byte OAJBCBNBJML, byte PHECHEEDBAG)
	{
		GFDAKNJIJON = OAJBCBNBJML;
		IDHAPKFFGDJ = PHECHEEDBAG;
	}

	public void OnClickExit()
	{
		base.gameObject.SetActive(false);
	}

	private void MFBNHAEIDEL(UIRuneInfo FGDMAAIMPDE)
	{
		NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GNAPNOGFDIO(new IKMBGMILCDO(BHPOJADMDCH, false), GFDAKNJIJON, IDHAPKFFGDJ, FGDMAAIMPDE.JEDNNLONMKL().NEPGLNCIBJM.KGHMFHDGNEO());
	}

	private void EKJCKGFDGFK()
	{
		List<EEEFEGCDGMO> list = NetworkManager.get_Instance().get_m_gameNetClient().DAGCAFAEABC()
			.CEJHMABMMKM(GFDAKNJIJON, IDHAPKFFGDJ);
		if (list.Count == 0)
		{
			m_emptyRuneLabel.gameObject.SetActive(true);
		}
		else
		{
			m_emptyRuneLabel.gameObject.SetActive(true);
		}
		foreach (EEEFEGCDGMO item in list)
		{
			LADGCDHDOAK lADGCDHDOAK = new LADGCDHDOAK();
			lADGCDHDOAK.KNIAJMGDGAA = this;
			GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("skill2"));
			gameObject.transform.parent = m_grid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			lADGCDHDOAK.FGDMAAIMPDE = gameObject.GetComponent<UIRuneInfo>();
			lADGCDHDOAK.FGDMAAIMPDE.GAGCCNCIKKG(item, NetworkManager.get_Instance().get_m_gameNetClient().DAGCAFAEABC()
				.GBBOENDINNM(GFDAKNJIJON));
			UIEventTrigger uIEventTrigger = gameObject.AddComponent<UIEventTrigger>();
			uIEventTrigger.onClick.Add(new EventDelegate(lADGCDHDOAK.OBDCMENAMPO));
		}
		m_grid.Reposition();
	}

	public void JPAIIIMLJDD(byte OAJBCBNBJML, byte PHECHEEDBAG)
	{
		GFDAKNJIJON = OAJBCBNBJML;
		IDHAPKFFGDJ = PHECHEEDBAG;
	}

	private void PDEMNFLEKEA()
	{
		List<EEEFEGCDGMO> list = NetworkManager.get_Instance().IOJGPDKHAGD().DAGCAFAEABC()
			.CEJHMABMMKM(GFDAKNJIJON, IDHAPKFFGDJ);
		if (list.Count == 0)
		{
			m_emptyRuneLabel.gameObject.SetActive(true);
		}
		else
		{
			m_emptyRuneLabel.gameObject.SetActive(true);
		}
		foreach (EEEFEGCDGMO item in list)
		{
			LADGCDHDOAK lADGCDHDOAK = new LADGCDHDOAK();
			lADGCDHDOAK.KNIAJMGDGAA = this;
			GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("#########################################"));
			gameObject.transform.parent = m_grid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			lADGCDHDOAK.FGDMAAIMPDE = gameObject.GetComponent<UIRuneInfo>();
			lADGCDHDOAK.FGDMAAIMPDE.IEPMMBBMGCJ(item, NetworkManager.get_Instance().get_m_gameNetClient().DAGCAFAEABC()
				.GBBOENDINNM(GFDAKNJIJON));
			UIEventTrigger uIEventTrigger = gameObject.AddComponent<UIEventTrigger>();
			uIEventTrigger.onClick.Add(new EventDelegate(lADGCDHDOAK.NGFJOGOJHAN));
		}
		m_grid.EKBMHOMDDHA();
	}

	private void GJKDGOMCEFO(PJEMPFEIOAK HMOAHNANKNE)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
		HGBGJMIFCEP hGBGJMIFCEP2 = hGBGJMIFCEP;
		if (hGBGJMIFCEP2 == HGBGJMIFCEP.InvalidProtocolVersion)
		{
			byte gHMCCGBFLLL = HMOAHNANKNE.KFAGPDGHEBK();
			CDAEKMFPFCH oGBMNJBOPHK = NetworkManager.get_Instance().IOJGPDKHAGD().DAGCAFAEABC()
				.GBBOENDINNM(gHMCCGBFLLL);
			HMOAHNANKNE.ILFEGIPCAHH(oGBMNJBOPHK);
			base.gameObject.SetActive(false);
			UIRoot.Broadcast("정면 근처에 적이 없습니다");
		}
		else
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.get_Instance().GetText("null"), true);
		}
	}

	public void LMJOANHHCHI(byte OAJBCBNBJML, byte PHECHEEDBAG)
	{
		GFDAKNJIJON = OAJBCBNBJML;
		IDHAPKFFGDJ = PHECHEEDBAG;
	}

	private void JMIFCHKCBCB()
	{
		for (int i = 1; i < m_grid.transform.childCount; i++)
		{
			Object.DestroyObject(m_grid.transform.GetChild(i).gameObject);
		}
	}

	public void MJOELMJHLKP()
	{
		base.gameObject.SetActive(true);
	}

	private void OnEnable()
	{
		List<EEEFEGCDGMO> list = NetworkManager.get_Instance().get_m_gameNetClient().DAGCAFAEABC()
			.CEJHMABMMKM(GFDAKNJIJON, IDHAPKFFGDJ);
		if (list.Count == 0)
		{
			m_emptyRuneLabel.gameObject.SetActive(true);
		}
		else
		{
			m_emptyRuneLabel.gameObject.SetActive(false);
		}
		foreach (EEEFEGCDGMO item in list)
		{
			LADGCDHDOAK lADGCDHDOAK = new LADGCDHDOAK();
			lADGCDHDOAK.KNIAJMGDGAA = this;
			GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("UI/Lobby/RuneInfo"));
			gameObject.transform.parent = m_grid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			lADGCDHDOAK.FGDMAAIMPDE = gameObject.GetComponent<UIRuneInfo>();
			lADGCDHDOAK.FGDMAAIMPDE.SetInfo(item, NetworkManager.get_Instance().get_m_gameNetClient().DAGCAFAEABC()
				.GBBOENDINNM(GFDAKNJIJON));
			UIEventTrigger uIEventTrigger = gameObject.AddComponent<UIEventTrigger>();
			uIEventTrigger.onClick.Add(new EventDelegate(lADGCDHDOAK.ONIHAGMMFGH));
		}
		m_grid.Reposition();
	}

	public void CGBEGPCNKPA()
	{
		base.gameObject.SetActive(false);
	}

	public void KHKJFOGEJGE(byte OAJBCBNBJML, byte PHECHEEDBAG)
	{
		GFDAKNJIJON = OAJBCBNBJML;
		IDHAPKFFGDJ = PHECHEEDBAG;
	}

	private void ALJEFBEMCFK()
	{
		List<EEEFEGCDGMO> list = NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().DAGCAFAEABC()
			.CEJHMABMMKM(GFDAKNJIJON, IDHAPKFFGDJ);
		if (list.Count == 0)
		{
			m_emptyRuneLabel.gameObject.SetActive(true);
		}
		else
		{
			m_emptyRuneLabel.gameObject.SetActive(false);
		}
		foreach (EEEFEGCDGMO item in list)
		{
			LADGCDHDOAK lADGCDHDOAK = new LADGCDHDOAK();
			lADGCDHDOAK.KNIAJMGDGAA = this;
			GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("{0}일전"));
			gameObject.transform.parent = m_grid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			lADGCDHDOAK.FGDMAAIMPDE = gameObject.GetComponent<UIRuneInfo>();
			lADGCDHDOAK.FGDMAAIMPDE.HFJCHIDCONJ(item, NetworkManager.get_Instance().get_m_gameNetClient().DAGCAFAEABC()
				.GBBOENDINNM(GFDAKNJIJON));
			UIEventTrigger uIEventTrigger = gameObject.AddComponent<UIEventTrigger>();
			uIEventTrigger.onClick.Add(new EventDelegate(lADGCDHDOAK.OBDCMENAMPO));
		}
		m_grid.LEBHAMKOPHA();
	}

	private void DMCEJPAHNHP()
	{
		for (int i = 0; i < m_grid.transform.childCount; i++)
		{
			Object.DestroyObject(m_grid.transform.GetChild(i).gameObject);
		}
	}

	private void JCCCFCNECHO(UIRuneInfo FGDMAAIMPDE)
	{
		NetworkManager.get_Instance().get_m_gameNetClient().GNAPNOGFDIO(new IKMBGMILCDO(GJKDGOMCEFO, true, false), GFDAKNJIJON, IDHAPKFFGDJ, FGDMAAIMPDE.CBJLDIJCDCB().NEPGLNCIBJM.KGHMFHDGNEO());
	}

	private void EHAABBLHEMP()
	{
		List<EEEFEGCDGMO> list = NetworkManager.get_Instance().get_m_gameNetClient().DAGCAFAEABC()
			.CEJHMABMMKM(GFDAKNJIJON, IDHAPKFFGDJ);
		if (list.Count == 0)
		{
			m_emptyRuneLabel.gameObject.SetActive(true);
		}
		else
		{
			m_emptyRuneLabel.gameObject.SetActive(true);
		}
		foreach (EEEFEGCDGMO item in list)
		{
			LADGCDHDOAK lADGCDHDOAK = new LADGCDHDOAK();
			lADGCDHDOAK.KNIAJMGDGAA = this;
			GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("Observer"));
			gameObject.transform.parent = m_grid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			lADGCDHDOAK.FGDMAAIMPDE = gameObject.GetComponent<UIRuneInfo>();
			lADGCDHDOAK.FGDMAAIMPDE.HFJCHIDCONJ(item, NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().DAGCAFAEABC()
				.GBBOENDINNM(GFDAKNJIJON));
			UIEventTrigger uIEventTrigger = gameObject.AddComponent<UIEventTrigger>();
			uIEventTrigger.onClick.Add(new EventDelegate(lADGCDHDOAK.HMICFGLBIEF));
		}
		m_grid.LEBHAMKOPHA();
	}

	private void GKACIJGFNDC()
	{
		List<EEEFEGCDGMO> list = NetworkManager.get_Instance().get_m_gameNetClient().DAGCAFAEABC()
			.CEJHMABMMKM(GFDAKNJIJON, IDHAPKFFGDJ);
		if (list.Count == 0)
		{
			m_emptyRuneLabel.gameObject.SetActive(false);
		}
		else
		{
			m_emptyRuneLabel.gameObject.SetActive(false);
		}
		foreach (EEEFEGCDGMO item in list)
		{
			LADGCDHDOAK lADGCDHDOAK = new LADGCDHDOAK();
			lADGCDHDOAK.KNIAJMGDGAA = this;
			GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("알려지지 않은 오류입니다."));
			gameObject.transform.parent = m_grid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			lADGCDHDOAK.FGDMAAIMPDE = gameObject.GetComponent<UIRuneInfo>();
			lADGCDHDOAK.FGDMAAIMPDE.SetInfo(item, NetworkManager.get_Instance().IOJGPDKHAGD().DAGCAFAEABC()
				.GBBOENDINNM(GFDAKNJIJON));
			UIEventTrigger uIEventTrigger = gameObject.AddComponent<UIEventTrigger>();
			uIEventTrigger.onClick.Add(new EventDelegate(lADGCDHDOAK.EHBKJEABIBK));
		}
		m_grid.LEBHAMKOPHA();
	}

	public void DELJHDABMGB(byte OAJBCBNBJML, byte PHECHEEDBAG)
	{
		GFDAKNJIJON = OAJBCBNBJML;
		IDHAPKFFGDJ = PHECHEEDBAG;
	}

	private void ALHLOEMHCPG(PJEMPFEIOAK HMOAHNANKNE)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
		HGBGJMIFCEP hGBGJMIFCEP2 = hGBGJMIFCEP;
		if (hGBGJMIFCEP2 == HGBGJMIFCEP.InvalidProtocolVersion)
		{
			byte gHMCCGBFLLL = HMOAHNANKNE.KFAGPDGHEBK();
			CDAEKMFPFCH oGBMNJBOPHK = NetworkManager.APAPJEIBEDE().get_m_gameNetClient().DAGCAFAEABC()
				.GBBOENDINNM(gHMCCGBFLLL);
			HMOAHNANKNE.CAHACMKBJMI(oGBMNJBOPHK);
			base.gameObject.SetActive(false);
			UIRoot.IGMDNDABNKD("마법저항력");
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("skill0_1"), true);
		}
	}

	public void NNFFCOFLEJE()
	{
		base.gameObject.SetActive(true);
	}

	private void BOCNOIMKGAC(UIRuneInfo FGDMAAIMPDE)
	{
		NetworkManager.get_Instance().IOJGPDKHAGD().GNAPNOGFDIO(new IKMBGMILCDO(NEINEOFBNFJ, false, false), GFDAKNJIJON, IDHAPKFFGDJ, FGDMAAIMPDE.CBJLDIJCDCB().NEPGLNCIBJM.KGHMFHDGNEO());
	}

	private void FCOIEELGOCI(UIRuneInfo FGDMAAIMPDE)
	{
		NetworkManager.get_Instance().get_m_gameNetClient().GNAPNOGFDIO(new IKMBGMILCDO(BHPOJADMDCH), GFDAKNJIJON, IDHAPKFFGDJ, FGDMAAIMPDE.get_m_runeInfo().NEPGLNCIBJM.KGHMFHDGNEO());
	}
}
