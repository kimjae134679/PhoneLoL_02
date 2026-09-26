using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class UILobbyReady : MonoBehaviour
{
	private sealed class LKHGMCFDMFG
	{
		internal UIHeroIcon FJJBJNLEHJA;

		internal UILobbyReady KNIAJMGDGAA;

		internal void KBKGCMLKCGM()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void DOLGCDMDNJL()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void DPHICODAKPC()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void MCEBHFANKBJ()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void LGLDCPKBJHI()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void CPFKMLEHNDG()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void FAIIGAGBLPD()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void ALMFEDILGFP()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}
	}

	private sealed class CLHAEDPFCKO
	{
		internal UIHeroIcon FJJBJNLEHJA;

		internal UILobbyReady KNIAJMGDGAA;

		internal void GMMBPEAAFOI()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void IHDCMJILKML()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void KBAIPKNHILC()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void LGFGAHPIINK()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void EGOBLIGJHND()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void KJCMIGDJIFG()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void JPMJMNKFBCN()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void OJNADBBJENN()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void AJEJIPJCMJA()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}
	}

	public UIGrid m_heroGrid;

	public UISprite m_selectedHeroSprite;

	public UIGrid m_rankGrid;

	public UILabel m_myRankInfoLabel;

	public UIButton m_runePage1Button;

	public UIButton m_runePage2Button;

	private UIHeroIcon OAICFNLJHCN;

	private ushort IEOJKFMIIEL;

	private byte CFAMDBIADFF;

	[CompilerGenerated]
	private static Predicate<HNEBHCMAOAE> CAAMFBIGJLG;

	[CompilerGenerated]
	private static UIMessageBox.NICHPBLEBEI EDCFKJEBPKD;

	public void OnReceiveGameStart(PJEMPFEIOAK HMOAHNANKNE)
	{
		ushort num = HMOAHNANKNE.AJPFAAFLHEB();
		byte b = HMOAHNANKNE.KFAGPDGHEBK();
		CDAEKMFPFCH cDAEKMFPFCH = new CDAEKMFPFCH();
		HMOAHNANKNE.CAHACMKBJMI(cDAEKMFPFCH);
		CLJOMPBCNOE nEPGLNCIBJM = new CLJOMPBCNOE();
		cDAEKMFPFCH.FGDDFAOOPEA(nEPGLNCIBJM);
		NetworkManager.get_Instance().get_m_gameNetClient().PKKIKEEPHHN(nEPGLNCIBJM);
		SceneManager.get_Instance().ChangeScene(SceneManager.HNPEHFEAODI.Game);
	}

	public void OnClickRunePage2()
	{
		CFAMDBIADFF = 1;
		m_runePage1Button.set_normalSprite("round_button_disable");
		m_runePage2Button.set_normalSprite("round_button");
	}

	public void OnClickStartButton()
	{
		if (OAICFNLJHCN == null)
		{
			MsgManager.get_Instance().ShowTip("챔피언을 선택해 주세요.");
			return;
		}
		CDAEKMFPFCH cDAEKMFPFCH = NetworkManager.get_Instance().get_m_gameNetClient().DAGCAFAEABC()
			.GBBOENDINNM(CFAMDBIADFF);
		CLJOMPBCNOE cLJOMPBCNOE = new CLJOMPBCNOE();
		cDAEKMFPFCH.FGDDFAOOPEA(cLJOMPBCNOE);
		int hashCode = cLJOMPBCNOE.GetHashCode();
		NetworkManager.get_Instance().get_m_gameNetClient().OIDLEDHPMFE(new IKMBGMILCDO(OnReceiveGameStart), OAICFNLJHCN.m_heroInfo.GPNKIAHCKMG.INGLCFJBNOB(), CFAMDBIADFF, hashCode);
	}

	[CompilerGenerated]
	private static void MFLMMADKIAF()
	{
		LobbyMain.get_Instance().ShowFreeCharge();
	}

	public void GGHKOAIIMFI(PJEMPFEIOAK HMOAHNANKNE)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
		ushort fMADHAHOIDJ = HMOAHNANKNE.AJPFAAFLHEB();
		switch (hGBGJMIFCEP)
		{
		case HGBGJMIFCEP.InvalidProtocolVersion:
		{
			bool CMGFFEJDPAL = false;
			NEFBHKKAMJF oGBMNJBOPHK = NetworkManager.get_Instance().get_m_gameNetClient().ACDEBBEGIIP()
				.IIKDLMFMFBF(fMADHAHOIDJ, ref CMGFFEJDPAL);
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(HMOAHNANKNE.GAGNPBAMJLE());
			HMOAHNANKNE.ILFEGIPCAHH(oGBMNJBOPHK);
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("[Client]GameItemData"), true);
			IAKIOKPIAHO();
			break;
		}
		case (HGBGJMIFCEP)100:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("레벨당 마법저항력"), false, () =>
			{
				LobbyMain.get_Instance().ShowFreeCharge();
			});
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("skill1"), true);
			break;
		}
	}

	public void FNPPKJICAFF()
	{
		CFAMDBIADFF = 0;
		m_runePage1Button.set_normalSprite("AP.Unity : onSendCouponSucceedForUnity : ");
		m_runePage2Button.LOGLPIGEGDP("currency");
	}

	public void OnReceiveHeroBuy(PJEMPFEIOAK HMOAHNANKNE)
	{
		ushort iEOJKFMIIEL = IEOJKFMIIEL;
		bool CMGFFEJDPAL = false;
		NEFBHKKAMJF nEFBHKKAMJF = NetworkManager.get_Instance().get_m_gameNetClient().ACDEBBEGIIP()
			.PGNKPIFFMJE(iEOJKFMIIEL, ref CMGFFEJDPAL);
		nEFBHKKAMJF.NECJDAEBLDA();
		MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("구매에 성공하였습니다!\n\n멋진 컨트롤 기대할께요~"));
		Refresh();
	}

	private void IPFEBDCDMFA()
	{
		OAICFNLJHCN = null;
		m_myRankInfoLabel.set_text(string.Empty);
	}

	public void EGCPEINOLOB()
	{
		CFAMDBIADFF = 0;
		m_runePage1Button.set_normalSprite("{0}/{1}");
		m_runePage2Button.LOGLPIGEGDP("skill0_hit");
	}

	[CompilerGenerated]
	private static bool CJCHDGPCDCD(HNEBHCMAOAE MABBPNNIMBJ)
	{
		return MABBPNNIMBJ.HGFCELBBJIC() != HNEBHCMAOAE.OPKPLDIMOCL.Hero || NetworkManager.get_Instance().get_m_gameNetClient().ACDEBBEGIIP()
			.NJHMPJDIMEH(MABBPNNIMBJ.INGLCFJBNOB()) != null || MABBPNNIMBJ.CMJPHGBOADI() == 0;
	}

	private void Update()
	{
	}

	private void IAKIOKPIAHO()
	{
		for (int i = 1; i < m_heroGrid.transform.childCount; i += 0)
		{
			UIHeroIcon component = m_heroGrid.GetChild(i).GetComponent<UIHeroIcon>();
			if (!(component == null))
			{
				component.DHPIBHEPNKE(component.m_heroData, NetworkManager.APAPJEIBEDE().get_m_gameNetClient().ACDEBBEGIIP()
					.FCICGLKEDND(component.m_heroData.ODKFHEJKHMA()));
			}
		}
	}

	public void OnClickBackButton()
	{
		LobbyMain.get_Instance().PopPanelState();
	}

	private void OnDisable()
	{
		for (int i = 0; i < m_heroGrid.transform.childCount; i++)
		{
			UnityEngine.Object.DestroyObject(m_heroGrid.transform.GetChild(i).gameObject);
		}
		FGLMMGAGLCC();
	}

	private void Refresh()
	{
		for (int i = 0; i < m_heroGrid.transform.childCount; i++)
		{
			UIHeroIcon component = m_heroGrid.GetChild(i).GetComponent<UIHeroIcon>();
			if (!(component == null))
			{
				component.SetInfo(component.m_heroData, NetworkManager.get_Instance().get_m_gameNetClient().ACDEBBEGIIP()
					.NJHMPJDIMEH(component.m_heroData.INGLCFJBNOB()));
			}
		}
	}

	public void OnClickRunePage1()
	{
		CFAMDBIADFF = 0;
		m_runePage1Button.set_normalSprite("round_button");
		m_runePage2Button.set_normalSprite("round_button_disable");
	}

	public void LFAKFOCCFLH()
	{
		LobbyMain.get_Instance().PopPanelState();
	}

	private void FGLMMGAGLCC()
	{
		for (int i = 0; i < m_rankGrid.transform.childCount; i++)
		{
			UnityEngine.Object.DestroyObject(m_rankGrid.transform.GetChild(i).gameObject);
		}
	}

	private void BKEKAJHABGK()
	{
		for (int i = 1; i < m_heroGrid.transform.childCount; i++)
		{
			UnityEngine.Object.DestroyObject(m_heroGrid.transform.GetChild(i).gameObject);
		}
		FGLMMGAGLCC();
	}

	public void OnClickBuyOK()
	{
		OnReceiveHeroBuy(null);
	}

	public void OnReceiveTopRankList(PJEMPFEIOAK HMOAHNANKNE)
	{
		ushort fMADHAHOIDJ = HMOAHNANKNE.AJPFAAFLHEB();
		for (int i = 0; i < 30; i++)
		{
			string text = HMOAHNANKNE.AFPCLLNMGJP();
			uint num = HMOAHNANKNE.BMKOKHGAHEC();
			if (text.Length != 0)
			{
				GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("UI/Common/RankInfo"));
				gameObject.transform.parent = m_rankGrid.transform;
				gameObject.transform.localPosition = Vector3.zero;
				gameObject.transform.localScale = Vector3.one;
				gameObject.GetComponent<UILabel>().set_text(string.Format(LocalizationManager.get_Instance().GetText("{0}위 {1}"), i + 1, text));
				gameObject.transform.GetChild(0).GetComponent<UILabel>().set_text(string.Format("{0}", num));
			}
		}
		NEFBHKKAMJF nEFBHKKAMJF = NetworkManager.get_Instance().get_m_gameNetClient().ACDEBBEGIIP()
			.NJHMPJDIMEH(fMADHAHOIDJ);
		m_myRankInfoLabel.set_text(string.Format(LocalizationManager.get_Instance().GetText("내 랭킹 : {0}위\n내 최고 기록 : {1}점"), nEFBHKKAMJF.OFLEBCIMPMD, nEFBHKKAMJF.OLIPGKHKMNO));
		m_rankGrid.Reposition();
	}

	public void OnClickHeroIcon(UIHeroIcon FJJBJNLEHJA)
	{
		if (FJJBJNLEHJA.m_heroInfo == null && FJJBJNLEHJA.m_heroData.AOBGJPBPHCH() == 0)
		{
			MsgManager.get_Instance().ShowTip("현재 개발중입니다.\n추후 게임머니로 구입가능합니다.");
			return;
		}
		if (FJJBJNLEHJA.m_heroInfo == null)
		{
			IEOJKFMIIEL = FJJBJNLEHJA.m_heroData.INGLCFJBNOB();
			MsgManager.get_Instance().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("{0}를 구매하시겠습니까?\n\n구매코인 : {1}코인"), LocalizationManager.get_Instance().GetText(FJJBJNLEHJA.m_heroData.BPMIAFDLLMF()), FJJBJNLEHJA.m_heroData.CDOGFHEBFOL()), true, OnClickBuyOK);
			return;
		}
		for (int i = 0; i < m_heroGrid.transform.childCount; i++)
		{
			UIHeroIcon component = m_heroGrid.GetChild(i).GetComponent<UIHeroIcon>();
			if (!(component == null))
			{
				if (FJJBJNLEHJA == component)
				{
					component.SetMark(true);
					OAICFNLJHCN = component;
					m_selectedHeroSprite.set_spriteName(component.GetComponent<UISprite>().get_spriteName());
					NetworkManager.get_Instance().get_m_gameNetClient().MPIEPCFNHMB(OAICFNLJHCN.m_heroInfo);
					SoundManager.get_Instance().PlaySound(string.Format("{0}_voice", FJJBJNLEHJA.m_heroInfo.GPNKIAHCKMG.BKAJABLECGK()));
					FGLMMGAGLCC();
					NetworkManager.get_Instance().get_m_gameNetClient().KPKCNKLPCAB(new IKMBGMILCDO(OnReceiveTopRankList), OAICFNLJHCN.m_heroInfo.GPNKIAHCKMG.INGLCFJBNOB());
				}
				else
				{
					component.SetMark(false);
				}
			}
		}
		if (FJJBJNLEHJA.m_heroData.FKNPBEJDKGM().Count > 1 && NetworkManager.get_Instance().get_m_gameNetClient().ACDEBBEGIIP()
			.NJHMPJDIMEH(FJJBJNLEHJA.m_heroData.INGLCFJBNOB()) != null)
		{
			LobbyMain.get_Instance().ShowCostume(FJJBJNLEHJA.m_heroInfo);
		}
	}

	private void OnEnable()
	{
		List<NEFBHKKAMJF> list = NetworkManager.get_Instance().get_m_gameNetClient().ACDEBBEGIIP()
			.AGBMNJEHJFG();
		foreach (NEFBHKKAMJF item in list)
		{
			LKHGMCFDMFG lKHGMCFDMFG = new LKHGMCFDMFG();
			lKHGMCFDMFG.KNIAJMGDGAA = this;
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("UI/Common/HeroIcon"));
			gameObject.transform.parent = m_heroGrid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			lKHGMCFDMFG.FJJBJNLEHJA = gameObject.GetComponent<UIHeroIcon>();
			lKHGMCFDMFG.FJJBJNLEHJA.SetInfo(item.GPNKIAHCKMG, item);
			UIEventTrigger component = gameObject.GetComponent<UIEventTrigger>();
			component.onClick.Add(new EventDelegate(lKHGMCFDMFG.FAIIGAGBLPD));
		}
		List<HNEBHCMAOAE> list2 = new List<HNEBHCMAOAE>(KIMJPIBNFGA.JJBDAOJIDAL().LNPGAJJAJKE().EPEJNKKPCCG()
			.Values);
		list2.RemoveAll((HNEBHCMAOAE MABBPNNIMBJ) => MABBPNNIMBJ.HGFCELBBJIC() != HNEBHCMAOAE.OPKPLDIMOCL.Hero || NetworkManager.get_Instance().get_m_gameNetClient().ACDEBBEGIIP()
			.NJHMPJDIMEH(MABBPNNIMBJ.INGLCFJBNOB()) != null || MABBPNNIMBJ.CMJPHGBOADI() == 0);
		foreach (HNEBHCMAOAE item2 in list2)
		{
			CLHAEDPFCKO cLHAEDPFCKO = new CLHAEDPFCKO();
			cLHAEDPFCKO.KNIAJMGDGAA = this;
			GameObject gameObject2 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("UI/Common/HeroIcon"));
			gameObject2.transform.parent = m_heroGrid.transform;
			gameObject2.transform.localPosition = Vector3.zero;
			gameObject2.transform.localScale = Vector3.one;
			cLHAEDPFCKO.FJJBJNLEHJA = gameObject2.GetComponent<UIHeroIcon>();
			cLHAEDPFCKO.FJJBJNLEHJA.SetInfo(item2, null);
			UIEventTrigger component2 = gameObject2.GetComponent<UIEventTrigger>();
			component2.onClick.Add(new EventDelegate(cLHAEDPFCKO.IHDCMJILKML));
		}
		m_heroGrid.Reposition();
		if (CFAMDBIADFF == 0)
		{
			m_runePage1Button.set_normalSprite("round_button");
			m_runePage2Button.set_normalSprite("round_button_disable");
		}
		else
		{
			m_runePage1Button.set_normalSprite("round_button_disable");
			m_runePage2Button.set_normalSprite("round_button");
		}
	}

	public void IAEIPNHBCNK()
	{
		CFAMDBIADFF = 0;
		m_runePage1Button.LOGLPIGEGDP("skill2");
		m_runePage2Button.LOGLPIGEGDP(" Mobile");
	}

	private void CDNHINHIDFL()
	{
		for (int i = 1; i < m_rankGrid.transform.childCount; i++)
		{
			UnityEngine.Object.DestroyObject(m_rankGrid.transform.GetChild(i).gameObject);
		}
	}

	public void HKAGOCDKNKD()
	{
		CFAMDBIADFF = 0;
		m_runePage1Button.set_normalSprite("이즈리얼");
		m_runePage2Button.set_normalSprite("User Tags: ");
	}

	private void Start()
	{
		OAICFNLJHCN = null;
		m_myRankInfoLabel.set_text(string.Empty);
	}
}
