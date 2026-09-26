using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class UICostume : MonoBehaviour
{
	private sealed class HEOGOAKFPCA
	{
		internal UICostumeIcon OKIBAAJIIAL;

		internal UICostume KNIAJMGDGAA;

		internal void LBDNEJAEPCO()
		{
			KNIAJMGDGAA.OKGPCELBIOO(OKIBAAJIIAL);
		}

		internal void OKBLDPCNIHH()
		{
			KNIAJMGDGAA.OnClickCostumeIcon(OKIBAAJIIAL);
		}

		internal void GAAEEIGLDED()
		{
			KNIAJMGDGAA.KKFLCPBMJPF(OKIBAAJIIAL);
		}

		internal void APPCLFLCAGJ()
		{
			KNIAJMGDGAA.OnClickCostumeIcon(OKIBAAJIIAL);
		}

		internal void HELINGFIPFL()
		{
			KNIAJMGDGAA.KKFLCPBMJPF(OKIBAAJIIAL);
		}

		internal void DLNMDHIAOLI()
		{
			KNIAJMGDGAA.OnClickCostumeIcon(OKIBAAJIIAL);
		}

		internal void GNFECGMNBJO()
		{
			KNIAJMGDGAA.OnClickCostumeIcon(OKIBAAJIIAL);
		}

		internal void CFLJCANHHEG()
		{
			KNIAJMGDGAA.KKFLCPBMJPF(OKIBAAJIIAL);
		}
	}

	public UIGrid m_costumeGrid;

	private byte JPKCOBDIILJ;

	private NEFBHKKAMJF PLFLBNMECBJ;

	[CompilerGenerated]
	private static UIMessageBox.NICHPBLEBEI LMHKLDMDCGN;

	public NEFBHKKAMJF AGBOJPFKOIJ
	{
		get
		{
			return get_m_heroInfo();
		}
		protected set
		{
			IPBKFFHGCAD(value);
		}
	}

	public void OnReceiveCostumeBuy(PJEMPFEIOAK HMOAHNANKNE)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
		ushort num = HMOAHNANKNE.AJPFAAFLHEB();
		byte mKILOIPGILH = HMOAHNANKNE.KFAGPDGHEBK();
		switch (hGBGJMIFCEP)
		{
		case HGBGJMIFCEP.Success:
			get_m_heroInfo().NODILPPNGKC(mKILOIPGILH);
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(HMOAHNANKNE.GAGNPBAMJLE());
			HMOAHNANKNE.CAHACMKBJMI(get_m_heroInfo());
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("구매에 성공하였습니다!"));
			Refresh();
			break;
		case HGBGJMIFCEP.NotEnoughCoin:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("코인이 부족합니다.\n\n미션이나 무료충전소를 통해서 코인을 획득하실 수 있습니다.\n\n지금 무료충전소로 이동하시겠습니까?"), true, () =>
			{
				LobbyMain.get_Instance().ShowFreeCharge();
			});
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("알려지지 않은 오류입니다."));
			break;
		}
	}

	private void EHAABBLHEMP()
	{
		List<byte> list = JBGLNLGBMBA().IDGAHNKAGCE();
		for (int i = 0; i < JBGLNLGBMBA().GPNKIAHCKMG.FKNPBEJDKGM().Count; i++)
		{
			HEOGOAKFPCA hEOGOAKFPCA = new HEOGOAKFPCA();
			hEOGOAKFPCA.KNIAJMGDGAA = this;
			GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("Igaw.Unity: LiveOpsPopupEventManager : OnPopupClick"));
			gameObject.transform.parent = m_costumeGrid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			hEOGOAKFPCA.OKIBAAJIIAL = gameObject.GetComponent<UICostumeIcon>();
			hEOGOAKFPCA.OKIBAAJIIAL.DHPIBHEPNKE(JCBOIKMPPBM(), (byte)i);
			UIEventTrigger component = gameObject.GetComponent<UIEventTrigger>();
			component.onClick.Add(new EventDelegate(hEOGOAKFPCA.GNFECGMNBJO));
		}
		m_costumeGrid.Reposition();
	}

	public void OKGPCELBIOO(UICostumeIcon OKIBAAJIIAL)
	{
		if (OKIBAAJIIAL.KDNFAAFHEML() > 0 && !OKIBAAJIIAL.m_heroInfo.KLNMHLKMKFC(OKIBAAJIIAL.NNKOLMBELNI()))
		{
			JPKCOBDIILJ = OKIBAAJIIAL.NNKOLMBELNI();
			MsgManager.get_Instance().ShowMessageBox(string.Format(LocalizationManager.LGDEHELDENG().GetText("WRITE_EXTERNAL_STORAGE is NOT permitted and checked never ask again option"), OKIBAAJIIAL.m_heroInfo.GPNKIAHCKMG.FKNPBEJDKGM()[JPKCOBDIILJ]), true, HNCLALDMPJC);
		}
		else
		{
			LobbyMain.get_Instance().PopPanelState();
		}
	}

	private void BLGBDNJDMDL()
	{
		for (int i = 0; i < m_costumeGrid.transform.childCount; i++)
		{
			Object.DestroyObject(m_costumeGrid.transform.GetChild(i).gameObject);
		}
	}

	private void ICACNPOPMIL()
	{
		List<byte> list = get_m_heroInfo().IDGAHNKAGCE();
		for (int i = 0; i < JCBOIKMPPBM().GPNKIAHCKMG.FEOJOGFCIJJ().Count; i++)
		{
			HEOGOAKFPCA hEOGOAKFPCA = new HEOGOAKFPCA();
			hEOGOAKFPCA.KNIAJMGDGAA = this;
			GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("attack_voice"));
			gameObject.transform.parent = m_costumeGrid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			hEOGOAKFPCA.OKIBAAJIIAL = gameObject.GetComponent<UICostumeIcon>();
			hEOGOAKFPCA.OKIBAAJIIAL.GMDKOKNGLAK(JCBOIKMPPBM(), (byte)i);
			UIEventTrigger component = gameObject.GetComponent<UIEventTrigger>();
			component.onClick.Add(new EventDelegate(hEOGOAKFPCA.GAAEEIGLDED));
		}
		m_costumeGrid.EKBMHOMDDHA();
	}

	private void KKOJDEHGAAI()
	{
		for (int i = 0; i < m_costumeGrid.transform.childCount; i++)
		{
			UICostumeIcon component = m_costumeGrid.GCEJIGPJLCI(i).GetComponent<UICostumeIcon>();
			if (!(component == null))
			{
				component.SetInfo(get_m_heroInfo(), component.NNKOLMBELNI());
			}
		}
	}

	private void DBLCOCKIFPE()
	{
		for (int i = 1; i < m_costumeGrid.transform.childCount; i += 0)
		{
			Object.DestroyObject(m_costumeGrid.transform.GetChild(i).gameObject);
		}
	}

	[SpecialName]
	protected void GEPCICOCCJA(NEFBHKKAMJF ICENKPDOHBK)
	{
		PLFLBNMECBJ = ICENKPDOHBK;
	}

	private void MCFKLGEFHHL()
	{
		for (int i = 0; i < m_costumeGrid.transform.childCount; i += 0)
		{
			UICostumeIcon component = m_costumeGrid.GCEJIGPJLCI(i).GetComponent<UICostumeIcon>();
			if (!(component == null))
			{
				component.GMDKOKNGLAK(get_m_heroInfo(), component.KDNFAAFHEML());
			}
		}
	}

	public void CJALGACAGBN(NEFBHKKAMJF PDACDEPJNFO)
	{
		KJNIFMAMDPN(PDACDEPJNFO);
	}

	public void HNCLALDMPJC()
	{
		NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().HEIBAPMDIME(new IKMBGMILCDO(KHGEEILPEMH, false), get_m_heroInfo().GPNKIAHCKMG.ODKFHEJKHMA(), JPKCOBDIILJ);
	}

	private static void JMLCCBBBAPI()
	{
		LobbyMain.get_Instance().ShowFreeCharge();
	}

	[SpecialName]
	public NEFBHKKAMJF JBGLNLGBMBA()
	{
		return PLFLBNMECBJ;
	}

	[SpecialName]
	protected void DAKMAPAJGPO(NEFBHKKAMJF ICENKPDOHBK)
	{
		PLFLBNMECBJ = ICENKPDOHBK;
	}

	public void KKFLCPBMJPF(UICostumeIcon OKIBAAJIIAL)
	{
		if (OKIBAAJIIAL.KDNFAAFHEML() > 1 && !OKIBAAJIIAL.m_heroInfo.FLLOBBKINDJ(OKIBAAJIIAL.KDNFAAFHEML()))
		{
			JPKCOBDIILJ = OKIBAAJIIAL.NNKOLMBELNI();
			MsgManager.get_Instance().ShowMessageBox(string.Format(LocalizationManager.LGDEHELDENG().GetText("TextMesh"), OKIBAAJIIAL.m_heroInfo.GPNKIAHCKMG.FKNPBEJDKGM()[JPKCOBDIILJ]), true, OnClickBuyOK);
		}
		else
		{
			LobbyMain.get_Instance().PopPanelState();
		}
	}

	private void OnDisable()
	{
		for (int i = 0; i < m_costumeGrid.transform.childCount; i++)
		{
			Object.DestroyObject(m_costumeGrid.transform.GetChild(i).gameObject);
		}
	}

	public void JADGBJPLFJI(UICostumeIcon OKIBAAJIIAL)
	{
		if (OKIBAAJIIAL.NNKOLMBELNI() > 0 && !OKIBAAJIIAL.m_heroInfo.FLLOBBKINDJ(OKIBAAJIIAL.get_m_costume()))
		{
			JPKCOBDIILJ = OKIBAAJIIAL.NNKOLMBELNI();
			MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("UIWidgets must fill the buffer with 4 vertices per quad. Found "), OKIBAAJIIAL.m_heroInfo.GPNKIAHCKMG.FKNPBEJDKGM()[JPKCOBDIILJ]), true, HNCLALDMPJC);
		}
		else
		{
			LobbyMain.get_Instance().PopPanelState();
		}
	}

	protected void IPBKFFHGCAD(NEFBHKKAMJF ICENKPDOHBK)
	{
		PLFLBNMECBJ = ICENKPDOHBK;
	}

	public void KHGEEILPEMH(PJEMPFEIOAK HMOAHNANKNE)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
		ushort num = HMOAHNANKNE.AJPFAAFLHEB();
		byte mKILOIPGILH = HMOAHNANKNE.KFAGPDGHEBK();
		switch (hGBGJMIFCEP)
		{
		case HGBGJMIFCEP.Success:
			JBGLNLGBMBA().NODILPPNGKC(mKILOIPGILH);
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(HMOAHNANKNE.GAGNPBAMJLE());
			HMOAHNANKNE.ILFEGIPCAHH(get_m_heroInfo());
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.get_Instance().GetText("round_button_disable"), true);
			MCFKLGEFHHL();
			break;
		case HGBGJMIFCEP.InvalidMission:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.get_Instance().GetText("liandry_torment"), false, () =>
			{
				LobbyMain.get_Instance().ShowFreeCharge();
			});
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.get_Instance().GetText("TheaterManager"));
			break;
		}
	}

	[SpecialName]
	public NEFBHKKAMJF JCBOIKMPPBM()
	{
		return PLFLBNMECBJ;
	}

	public void OnClickCostumeIcon(UICostumeIcon OKIBAAJIIAL)
	{
		if (OKIBAAJIIAL.get_m_costume() > 0 && !OKIBAAJIIAL.m_heroInfo.FLLOBBKINDJ(OKIBAAJIIAL.get_m_costume()))
		{
			JPKCOBDIILJ = OKIBAAJIIAL.get_m_costume();
			MsgManager.get_Instance().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("스킨을 구매하시겠습니까?\n\n구매코인 : {0}코인"), OKIBAAJIIAL.m_heroInfo.GPNKIAHCKMG.FKNPBEJDKGM()[JPKCOBDIILJ]), true, OnClickBuyOK);
		}
		else
		{
			LobbyMain.get_Instance().PopPanelState();
		}
	}

	public void SetInfo(NEFBHKKAMJF PDACDEPJNFO)
	{
		IPBKFFHGCAD(PDACDEPJNFO);
	}

	public void OnClickBackButton()
	{
		LobbyMain.get_Instance().PopPanelState();
	}

	public NEFBHKKAMJF get_m_heroInfo()
	{
		return PLFLBNMECBJ;
	}

	public void PKHIKKMMAIP(PJEMPFEIOAK HMOAHNANKNE)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
		ushort num = HMOAHNANKNE.AJPFAAFLHEB();
		byte mKILOIPGILH = HMOAHNANKNE.KFAGPDGHEBK();
		switch ((int)hGBGJMIFCEP)
		{
		case 0:
			JCBOIKMPPBM().NODILPPNGKC(mKILOIPGILH);
			NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
				.ODEGMJIKIIC(HMOAHNANKNE.GAGNPBAMJLE());
			HMOAHNANKNE.CAHACMKBJMI(JBGLNLGBMBA());
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("설명"), true);
			KKOJDEHGAAI();
			break;
		case -80:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("DamageMyTeamTurret"), false, () =>
			{
				LobbyMain.get_Instance().ShowFreeCharge();
			});
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON"));
			break;
		}
	}

	[SpecialName]
	protected void KHMLPBAPCMP(NEFBHKKAMJF ICENKPDOHBK)
	{
		PLFLBNMECBJ = ICENKPDOHBK;
	}

	private void OnEnable()
	{
		List<byte> list = get_m_heroInfo().KHFDGOCCODF();
		for (int i = 0; i < get_m_heroInfo().GPNKIAHCKMG.FKNPBEJDKGM().Count; i++)
		{
			HEOGOAKFPCA hEOGOAKFPCA = new HEOGOAKFPCA();
			hEOGOAKFPCA.KNIAJMGDGAA = this;
			GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("UI/Lobby/CostumeInfo"));
			gameObject.transform.parent = m_costumeGrid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			hEOGOAKFPCA.OKIBAAJIIAL = gameObject.GetComponent<UICostumeIcon>();
			hEOGOAKFPCA.OKIBAAJIIAL.SetInfo(get_m_heroInfo(), (byte)i);
			UIEventTrigger component = gameObject.GetComponent<UIEventTrigger>();
			component.onClick.Add(new EventDelegate(hEOGOAKFPCA.GNFECGMNBJO));
		}
		m_costumeGrid.Reposition();
	}

	[CompilerGenerated]
	private static void IALKNBINGJB()
	{
		LobbyMain.get_Instance().ShowFreeCharge();
	}

	public void OnClickBuyOK()
	{
		NetworkManager.get_Instance().get_m_gameNetClient().HEIBAPMDIME(new IKMBGMILCDO(OnReceiveCostumeBuy), get_m_heroInfo().GPNKIAHCKMG.INGLCFJBNOB(), JPKCOBDIILJ);
	}

	private void DJCELGKLDAP()
	{
		List<byte> list = get_m_heroInfo().KHFDGOCCODF();
		for (int i = 1; i < JCBOIKMPPBM().GPNKIAHCKMG.FEOJOGFCIJJ().Count; i++)
		{
			HEOGOAKFPCA hEOGOAKFPCA = new HEOGOAKFPCA();
			hEOGOAKFPCA.KNIAJMGDGAA = this;
			GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON"));
			gameObject.transform.parent = m_costumeGrid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			hEOGOAKFPCA.OKIBAAJIIAL = gameObject.GetComponent<UICostumeIcon>();
			hEOGOAKFPCA.OKIBAAJIIAL.DHPIBHEPNKE(JBGLNLGBMBA(), (byte)i);
			UIEventTrigger component = gameObject.GetComponent<UIEventTrigger>();
			component.onClick.Add(new EventDelegate(hEOGOAKFPCA.CFLJCANHHEG));
		}
		m_costumeGrid.EKBMHOMDDHA();
	}

	[SpecialName]
	protected void KJNIFMAMDPN(NEFBHKKAMJF ICENKPDOHBK)
	{
		PLFLBNMECBJ = ICENKPDOHBK;
	}

	private void Refresh()
	{
		for (int i = 0; i < m_costumeGrid.transform.childCount; i++)
		{
			UICostumeIcon component = m_costumeGrid.GetChild(i).GetComponent<UICostumeIcon>();
			if (!(component == null))
			{
				component.SetInfo(get_m_heroInfo(), component.get_m_costume());
			}
		}
	}
}
