using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BattleServer;
using EveEngine;
using GameServer;
using UnityEngine;

public class UILobbySelectSkinWindow : MonoBehaviour
{
	private sealed class DKIOLGCDLKC
	{
		internal UICostumeIcon OKIBAAJIIAL;

		internal UILobbySelectSkinWindow KNIAJMGDGAA;

		internal void GIDFMBOPLPJ()
		{
			KNIAJMGDGAA.OnClickCostumeIcon(OKIBAAJIIAL);
		}

		internal void KMFIPEAFCDM()
		{
			KNIAJMGDGAA.OnClickCostumeIcon(OKIBAAJIIAL);
		}

		internal void ACDDCHGEBAL()
		{
			KNIAJMGDGAA.OnClickCostumeIcon(OKIBAAJIIAL);
		}

		internal void BDDCJPCEFHA()
		{
			KNIAJMGDGAA.OnClickCostumeIcon(OKIBAAJIIAL);
		}

		internal void HKPLANOFOMH()
		{
			KNIAJMGDGAA.OnClickCostumeIcon(OKIBAAJIIAL);
		}

		internal void OMEHHIBDOEO()
		{
			KNIAJMGDGAA.OnClickCostumeIcon(OKIBAAJIIAL);
		}

		internal void NKEBACJEBGL()
		{
			KNIAJMGDGAA.OnClickCostumeIcon(OKIBAAJIIAL);
		}

		internal void EAACAKABJFO()
		{
			KNIAJMGDGAA.OnClickCostumeIcon(OKIBAAJIIAL);
		}

		internal void HIJFGIFANON()
		{
			KNIAJMGDGAA.OnClickCostumeIcon(OKIBAAJIIAL);
		}
	}

	public UIGrid m_costumeGrid;

	private byte JPKCOBDIILJ;

	private NEFBHKKAMJF PLFLBNMECBJ;

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

	[SpecialName]
	protected void FKIONCMJADB(NEFBHKKAMJF ICENKPDOHBK)
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
				if (NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
					.FKECPLMGIFB() == component.get_m_costume())
				{
					component.SetSelect(true);
				}
				else
				{
					component.SetSelect(false);
				}
			}
		}
	}

	[SpecialName]
	protected void HJANNIOMOIJ(NEFBHKKAMJF ICENKPDOHBK)
	{
		PLFLBNMECBJ = ICENKPDOHBK;
	}

	public void OnClickCostumeIcon(UICostumeIcon OKIBAAJIIAL)
	{
		NetworkManager.get_Instance().get_m_battleNetClient().KHFONJGOBEB(OKIBAAJIIAL.get_m_costume());
		NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.DHGDPAGDFIK(OKIBAAJIIAL.get_m_costume());
		Refresh();
	}

	private void OnEnable()
	{
		NEFBHKKAMJF nEFBHKKAMJF = new NEFBHKKAMJF();
		nEFBHKKAMJF.FIGLEPBIEEJ(NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.IBFJBIBACIA());
		IPBKFFHGCAD(nEFBHKKAMJF);
		if (get_m_heroInfo() != null && get_m_heroInfo().GPNKIAHCKMG.FKNPBEJDKGM().Count > 1)
		{
			List<byte> list = get_m_heroInfo().KHFDGOCCODF();
			for (int i = 0; i < get_m_heroInfo().GPNKIAHCKMG.FKNPBEJDKGM().Count; i++)
			{
				DKIOLGCDLKC dKIOLGCDLKC = new DKIOLGCDLKC();
				dKIOLGCDLKC.KNIAJMGDGAA = this;
				GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("UI/Lobby/CostumeInfo"));
				gameObject.transform.parent = m_costumeGrid.transform;
				gameObject.transform.localPosition = Vector3.zero;
				gameObject.transform.localScale = Vector3.one;
				dKIOLGCDLKC.OKIBAAJIIAL = gameObject.GetComponent<UICostumeIcon>();
				dKIOLGCDLKC.OKIBAAJIIAL.SetInfo(get_m_heroInfo(), (byte)i);
				UIEventTrigger component = gameObject.GetComponent<UIEventTrigger>();
				component.onClick.Add(new EventDelegate(dKIOLGCDLKC.HKPLANOFOMH));
			}
			m_costumeGrid.Reposition();
			Refresh();
		}
	}

	private void OPAFMNEOEPE()
	{
		for (int i = 1; i < m_costumeGrid.transform.childCount; i += 0)
		{
			UICostumeIcon component = m_costumeGrid.GetChild(i).GetComponent<UICostumeIcon>();
			if (!(component == null))
			{
				component.GMDKOKNGLAK(get_m_heroInfo(), component.KDNFAAFHEML());
				if (NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
					.FKECPLMGIFB() == component.KDNFAAFHEML())
				{
					component.KKDLEOCJACN(true);
				}
				else
				{
					component.SetSelect(false);
				}
			}
		}
	}

	public void OnReceiveCostumeBuy(PJEMPFEIOAK HMOAHNANKNE)
	{
		GameServer.HGBGJMIFCEP hGBGJMIFCEP = (GameServer.HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
		ushort num = HMOAHNANKNE.AJPFAAFLHEB();
		byte mKILOIPGILH = HMOAHNANKNE.KFAGPDGHEBK();
		switch (hGBGJMIFCEP)
		{
		case GameServer.HGBGJMIFCEP.Success:
			get_m_heroInfo().NODILPPNGKC(mKILOIPGILH);
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(HMOAHNANKNE.GAGNPBAMJLE());
			HMOAHNANKNE.CAHACMKBJMI(get_m_heroInfo());
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("구매에 성공하였습니다!"));
			Refresh();
			break;
		case GameServer.HGBGJMIFCEP.NotEnoughCoin:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("코인이 부족합니다"));
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("알려지지 않은 오류입니다."));
			break;
		}
	}

	public void EODKFBCMAEK()
	{
	}

	public void HAELDHDFPOD()
	{
		GLAMMOFPCHP gLAMMOFPCHP = NetworkManager.APAPJEIBEDE().get_m_battleNetClient().IMKOGBNIJBO();
		if (gLAMMOFPCHP.OOHFDEPKKFN() == (BattleServer.OCPEALOGAIP.OEOIIKMBGAG)8)
		{
			MsgManager.HEDJPPFKABG().LBCFANDMCON("중급 체력 인장");
		}
		else
		{
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().HEIBAPMDIME(new IKMBGMILCDO(OnReceiveCostumeBuy, true, false), BCIDGIAGPKI().GPNKIAHCKMG.HDCLGJHNAGL(), JPKCOBDIILJ);
		}
	}

	protected void IPBKFFHGCAD(NEFBHKKAMJF ICENKPDOHBK)
	{
		PLFLBNMECBJ = ICENKPDOHBK;
	}

	public NEFBHKKAMJF get_m_heroInfo()
	{
		return PLFLBNMECBJ;
	}

	private void OnDisable()
	{
		for (int i = 0; i < m_costumeGrid.transform.childCount; i++)
		{
			Object.DestroyObject(m_costumeGrid.transform.GetChild(i).gameObject);
		}
	}

	public void OnClickBuyOK()
	{
		GLAMMOFPCHP gLAMMOFPCHP = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO();
		if (gLAMMOFPCHP.OOHFDEPKKFN() == BattleServer.OCPEALOGAIP.OEOIIKMBGAG.CountDown)
		{
			MsgManager.get_Instance().ShowTip("카운트 다운 중에는 구입이 불가능해요");
		}
		else
		{
			NetworkManager.get_Instance().get_m_gameNetClient().HEIBAPMDIME(new IKMBGMILCDO(OnReceiveCostumeBuy), get_m_heroInfo().GPNKIAHCKMG.INGLCFJBNOB(), JPKCOBDIILJ);
		}
	}

	public void OnClickBackButton()
	{
	}

	private void CNLPLGJCBIA()
	{
		for (int i = 1; i < m_costumeGrid.transform.childCount; i++)
		{
			Object.DestroyObject(m_costumeGrid.transform.GetChild(i).gameObject);
		}
	}

	public void ENMKCKPEBGC()
	{
		GLAMMOFPCHP gLAMMOFPCHP = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO();
		if (gLAMMOFPCHP.OOHFDEPKKFN() == (BattleServer.OCPEALOGAIP.OEOIIKMBGAG)7)
		{
			MsgManager.HEDJPPFKABG().ShowTip("skill3_voice");
		}
		else
		{
			NetworkManager.get_Instance().get_m_gameNetClient().HEIBAPMDIME(new IKMBGMILCDO(OnReceiveCostumeBuy, false, false), get_m_heroInfo().GPNKIAHCKMG.FFFDJEOHMIF(), JPKCOBDIILJ);
		}
	}

	public void OOJMBIFEEAI(PJEMPFEIOAK HMOAHNANKNE)
	{
		GameServer.HGBGJMIFCEP hGBGJMIFCEP = (GameServer.HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
		ushort num = HMOAHNANKNE.AJPFAAFLHEB();
		byte mKILOIPGILH = HMOAHNANKNE.KFAGPDGHEBK();
		switch ((int)hGBGJMIFCEP)
		{
		case 0:
			get_m_heroInfo().NODILPPNGKC(mKILOIPGILH);
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
				.ODEGMJIKIIC(HMOAHNANKNE.GAGNPBAMJLE());
			HMOAHNANKNE.ILFEGIPCAHH(get_m_heroInfo());
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("Hero1"));
			OPAFMNEOEPE();
			break;
		case -17:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.get_Instance().GetText("재생"), true);
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("ETC"));
			break;
		}
	}

	[SpecialName]
	protected void GEPCICOCCJA(NEFBHKKAMJF ICENKPDOHBK)
	{
		PLFLBNMECBJ = ICENKPDOHBK;
	}

	[SpecialName]
	public NEFBHKKAMJF BCIDGIAGPKI()
	{
		return PLFLBNMECBJ;
	}
}
