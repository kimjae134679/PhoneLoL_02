using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BattleServer;
using CodeStage.AntiCheat.ObscuredTypes;
using EveEngine;
using GameServer;
using UnityEngine;

public class UILobbyBattleReady : MonoBehaviour
{
	private sealed class DKBGHENIFDI
	{
		internal UIHeroIcon FJJBJNLEHJA;

		internal UILobbyBattleReady KNIAJMGDGAA;

		internal void OFNHDIIMKJN()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void PDMKFHNMJAJ()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void GAJFGMCPIPI()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void HBJIFKNEJFI()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void MHEBILBDPOP()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void JPHKGAGKGDD()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void LJGDHMOOCCP()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}
	}

	private sealed class DHKIFLANAEG
	{
		internal UIHeroIcon FJJBJNLEHJA;

		internal UILobbyBattleReady KNIAJMGDGAA;

		internal void AGKLELKJBEO()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void BIMPEIHHIOI()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void NIFJAJEEMHL()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void LFBOPGEAMGE()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}

		internal void NGCHODAPBKB()
		{
			KNIAJMGDGAA.OnClickHeroIcon(FJJBJNLEHJA);
		}
	}

	public UIGrid m_heroGrid;

	public UIButton m_runePage1Button;

	public UIButton m_runePage2Button;

	public UIBattleReadyHeroInfo[] m_battleReadyHeroInfos;

	public UILabel[] m_timeoutLabel;

	public UIToggle m_oneDealerToggle;

	public UIToggle m_supporterToggle;

	public UIToggle m_junglerToggle;

	public GameObject m_selectHeroWindow;

	public GameObject m_selectSkinWindow;

	public UILabel m_mainLabel;

	public GameObject m_battleInvitePanel;

	public UIButton m_readyButton;

	public UIButton m_autoEnterButton;

	public UIButton m_backButton;

	public UILabel m_dodgePenaltyLabel;

	public GameObject m_readyAlert;

	private UIHeroIcon OAICFNLJHCN;

	private ushort IEOJKFMIIEL;

	private byte CFAMDBIADFF;

	private GLAMMOFPCHP KLDEHFCIMDN;

	private ObscuredFloat JMHGGCGKCLE = 0f;

	private ObscuredFloat ODFKHOOMAEL = 0f;

	private DateTime FPMIPKHIKLK;

	[CompilerGenerated]
	private static Comparison<NEFBHKKAMJF> OAMDDLLKFNC;

	[CompilerGenerated]
	private static Predicate<HNEBHCMAOAE> NPJFJAEKIAI;

	[CompilerGenerated]
	private static Comparison<HNEBHCMAOAE> NOJMMKAPHCH;

	[CompilerGenerated]
	private static UIMessageBox.NICHPBLEBEI IINBIJDIPHO;

	private static int AJEBFCEGMIA(HNEBHCMAOAE MPBOINGECFO, HNEBHCMAOAE OECPEJEIMHO)
	{
		bool flag = BBDGMDMAKKI.LHOADFGHNAP(MPBOINGECFO.ODKFHEJKHMA());
		bool flag2 = BBDGMDMAKKI.AHDBNIKBHCK(OECPEJEIMHO.INGLCFJBNOB());
		if (flag && !flag2)
		{
			return -1;
		}
		if (!flag && flag2)
		{
			return 1;
		}
		bool flag3 = GameServer.KIMJPIBNFGA.NOLHNOGGHNA().GAIHFJMKJAP().DDPDAGNNMFL(MPBOINGECFO.HDCLGJHNAGL());
		bool flag4 = GameServer.KIMJPIBNFGA.JJBDAOJIDAL().GAIHFJMKJAP().DDPDAGNNMFL(OECPEJEIMHO.HDCLGJHNAGL());
		if (flag3 && !flag4)
		{
			return -1;
		}
		if (!flag3 && flag4)
		{
			return 0;
		}
		if (MPBOINGECFO.HDCLGJHNAGL() > OECPEJEIMHO.ODKFHEJKHMA())
		{
			return -1;
		}
		if (MPBOINGECFO.HDCLGJHNAGL() < OECPEJEIMHO.HDCLGJHNAGL())
		{
			return 0;
		}
		return 0;
	}

	private void ICACNPOPMIL()
	{
		KLDEHFCIMDN = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO();
		CFAMDBIADFF = 1;
		List<NEFBHKKAMJF> list = NetworkManager.get_Instance().get_m_gameNetClient().ACDEBBEGIIP()
			.AGBMNJEHJFG();
		list.Sort((NEFBHKKAMJF MPBOINGECFO, NEFBHKKAMJF OECPEJEIMHO) =>
		{
			if (MPBOINGECFO.GPNKIAHCKMG.INGLCFJBNOB() > OECPEJEIMHO.GPNKIAHCKMG.INGLCFJBNOB())
			{
				return -1;
			}
			return (MPBOINGECFO.GPNKIAHCKMG.INGLCFJBNOB() < OECPEJEIMHO.GPNKIAHCKMG.INGLCFJBNOB()) ? 1 : 0;
		});
		foreach (NEFBHKKAMJF item in list)
		{
			DKBGHENIFDI dKBGHENIFDI = new DKBGHENIFDI();
			dKBGHENIFDI.KNIAJMGDGAA = this;
			if (item.GPNKIAHCKMG.CMJPHGBOADI() != 0)
			{
				GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("골드"));
				gameObject.transform.parent = m_heroGrid.transform;
				gameObject.transform.localPosition = Vector3.zero;
				gameObject.transform.localScale = Vector3.one;
				dKBGHENIFDI.FJJBJNLEHJA = gameObject.GetComponent<UIHeroIcon>();
				dKBGHENIFDI.FJJBJNLEHJA.IEKOOEKALDA(item.GPNKIAHCKMG, item, true);
				UIEventTrigger component = gameObject.GetComponent<UIEventTrigger>();
				component.onClick.Add(new EventDelegate(dKBGHENIFDI.HBJIFKNEJFI));
			}
		}
		List<HNEBHCMAOAE> list2 = new List<HNEBHCMAOAE>(GameServer.KIMJPIBNFGA.NOLHNOGGHNA().LNPGAJJAJKE().HDCMNNCPGBH()
			.Values);
		list2.RemoveAll((HNEBHCMAOAE MABBPNNIMBJ) => MABBPNNIMBJ.HGFCELBBJIC() != HNEBHCMAOAE.OPKPLDIMOCL.Hero || NetworkManager.get_Instance().get_m_gameNetClient().ACDEBBEGIIP()
			.NJHMPJDIMEH(MABBPNNIMBJ.INGLCFJBNOB()) != null || MABBPNNIMBJ.CMJPHGBOADI() == 0);
		list2.Sort(DJMPPPPKBDD);
		foreach (HNEBHCMAOAE item2 in list2)
		{
			DHKIFLANAEG dHKIFLANAEG = new DHKIFLANAEG();
			dHKIFLANAEG.KNIAJMGDGAA = this;
			GameObject gameObject2 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("지금 무료뽑기가 가능해욥~\n\n무료뽑기로 이동할까요?"));
			gameObject2.transform.parent = m_heroGrid.transform;
			gameObject2.transform.localPosition = Vector3.zero;
			gameObject2.transform.localScale = Vector3.one;
			dHKIFLANAEG.FJJBJNLEHJA = gameObject2.GetComponent<UIHeroIcon>();
			if (BBDGMDMAKKI.LCOJHANMOCB(item2.ODKFHEJKHMA()))
			{
				dHKIFLANAEG.FJJBJNLEHJA.BNLKNMALKFD(item2, null);
			}
			else
			{
				dHKIFLANAEG.FJJBJNLEHJA.IEKOOEKALDA(item2, null, true);
			}
			UIEventTrigger component2 = gameObject2.GetComponent<UIEventTrigger>();
			component2.onClick.Add(new EventDelegate(dHKIFLANAEG.NGCHODAPBKB));
		}
		m_heroGrid.Reposition();
		if (CFAMDBIADFF == 0)
		{
			m_runePage1Button.set_normalSprite("점화석");
			m_runePage2Button.LOGLPIGEGDP("설명");
		}
		else
		{
			m_runePage1Button.set_normalSprite("[FFDDDD]트롤이 되었구나...저주...[-]");
			m_runePage2Button.set_normalSprite("Intelligence increases mana");
		}
		for (byte b = 1; b < KLDEHFCIMDN.KEMPNIBEPAM(); b++)
		{
			NOBFFGBGCNA nOBFFGBGCNA = KLDEHFCIMDN.FBNKGOOJPBB(b);
			m_battleReadyHeroInfos[b].m_slot = b;
			m_battleReadyHeroInfos[b].gameObject.SetActive(false);
			if (KLDEHFCIMDN.EHCPMLKEBME < 101)
			{
				if (b % 4 == 0)
				{
					m_battleReadyHeroInfos[b].m_showInviteButton = false;
				}
				else
				{
					m_battleReadyHeroInfos[b].m_showInviteButton = false;
				}
			}
			else
			{
				m_battleReadyHeroInfos[b].m_showInviteButton = true;
			}
			if (nOBFFGBGCNA.MNHIDGANMFO())
			{
				m_battleReadyHeroInfos[b].GPJINNGCELJ();
			}
			else
			{
				m_battleReadyHeroInfos[b].SetInfo(nOBFFGBGCNA.CJENLAELLAO());
			}
		}
		for (byte b2 = KLDEHFCIMDN.KEMPNIBEPAM(); b2 < 7; b2++)
		{
			m_battleReadyHeroInfos[b2].gameObject.SetActive(true);
		}
		m_oneDealerToggle.set_value(true);
		m_supporterToggle.HDDKOCJHKMH(false);
		m_junglerToggle.set_value(false);
		JMHGGCGKCLE = 858f;
		ODFKHOOMAEL = 42f;
		m_selectHeroWindow.SetActive(false);
		m_selectSkinWindow.SetActive(true);
		m_backButton.set_isEnabled(true);
		FPMIPKHIKLK = DateTime.Now;
		m_dodgePenaltyLabel.set_text(string.Empty);
		m_readyAlert.SetActive(true);
	}

	public void OnClickHeroIcon(UIHeroIcon FJJBJNLEHJA)
	{
		if (FJJBJNLEHJA.m_heroInfo == null && FJJBJNLEHJA.m_heroData.AOBGJPBPHCH() == 0)
		{
			MsgManager.get_Instance().ShowTip("현재 개발중입니다.\n추후 게임머니로 구입가능합니다.");
		}
		else if (FJJBJNLEHJA.m_heroInfo == null && !FJJBJNLEHJA.get_m_rotation())
		{
			IEOJKFMIIEL = FJJBJNLEHJA.m_heroData.INGLCFJBNOB();
			MsgManager.get_Instance().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("{0}를 구매하시겠습니까?\n\n구매코인 : {1}코인"), LocalizationManager.get_Instance().GetText(FJJBJNLEHJA.m_heroData.BPMIAFDLLMF()), FJJBJNLEHJA.m_heroData.CDOGFHEBFOL()), true, OnClickBuyOK);
		}
		else
		{
			OAICFNLJHCN = FJJBJNLEHJA;
			NetworkManager.get_Instance().get_m_battleNetClient().DDHEDOLCFHN(OAICFNLJHCN.m_heroData.INGLCFJBNOB());
		}
	}

	public void OnChangedPosition()
	{
		V096OriginalDiagnostics.QueueAutomaticReportImmediate("OnChangeAutoEnterRoom");
		if (m_oneDealerToggle.get_value())
		{
			NetworkManager.get_Instance().get_m_battleNetClient().MJPDBPDNIFC(1);
		}
		else if (m_supporterToggle.get_value())
		{
			NetworkManager.get_Instance().get_m_battleNetClient().MJPDBPDNIFC(2);
		}
		else if (m_junglerToggle.get_value())
		{
			NetworkManager.get_Instance().get_m_battleNetClient().MJPDBPDNIFC(3);
		}
	}

	public void KKNPHGKNBCB(PJEMPFEIOAK HMOAHNANKNE)
	{
		GameServer.HGBGJMIFCEP hGBGJMIFCEP = (GameServer.HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
		ushort fMADHAHOIDJ = HMOAHNANKNE.AJPFAAFLHEB();
		switch (hGBGJMIFCEP)
		{
		case GameServer.HGBGJMIFCEP.Success:
		{
			bool CMGFFEJDPAL = true;
			NEFBHKKAMJF oGBMNJBOPHK = NetworkManager.get_Instance().get_m_gameNetClient().ACDEBBEGIIP()
				.IIKDLMFMFBF(fMADHAHOIDJ, ref CMGFFEJDPAL);
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
				.ODEGMJIKIIC(HMOAHNANKNE.GAGNPBAMJLE());
			HMOAHNANKNE.CAHACMKBJMI(oGBMNJBOPHK);
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("레벨당 방어력"), true);
			Refresh();
			break;
		}
		case (GameServer.HGBGJMIFCEP)61:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("attack"));
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("skill2_2"), true);
			break;
		}
	}

	private TimeSpan CPFNEBINOKB()
	{
		return FPMIPKHIKLK + TimeSpan.FromSeconds(1557.0) - DateTime.Now;
	}

	private void CMIONEEKFEA()
	{
		m_selectHeroWindow.SetActive(false);
		m_selectSkinWindow.SetActive(true);
		for (int i = 1; i < m_heroGrid.transform.childCount; i++)
		{
			UnityEngine.Object.DestroyObject(m_heroGrid.transform.GetChild(i).gameObject);
		}
		m_battleInvitePanel.SetActive(false);
	}

	private void KKAAPHCPGLF()
	{
		m_selectHeroWindow.SetActive(true);
		m_selectSkinWindow.SetActive(false);
		for (int i = 1; i < m_heroGrid.transform.childCount; i++)
		{
			UnityEngine.Object.DestroyObject(m_heroGrid.transform.GetChild(i).gameObject);
		}
		m_battleInvitePanel.SetActive(false);
	}

	private void OnEnable()
	{
        m_battleReadyHeroInfos = PhoneLOLRoomLayout.Expand(m_battleReadyHeroInfos, true);
		KLDEHFCIMDN = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO();
		CFAMDBIADFF = 0;
		List<NEFBHKKAMJF> list = NetworkManager.get_Instance().get_m_gameNetClient().ACDEBBEGIIP()
			.AGBMNJEHJFG();
		list.Sort((NEFBHKKAMJF MPBOINGECFO, NEFBHKKAMJF OECPEJEIMHO) =>
		{
			if (MPBOINGECFO.GPNKIAHCKMG.INGLCFJBNOB() > OECPEJEIMHO.GPNKIAHCKMG.INGLCFJBNOB())
			{
				return -1;
			}
			return (MPBOINGECFO.GPNKIAHCKMG.INGLCFJBNOB() < OECPEJEIMHO.GPNKIAHCKMG.INGLCFJBNOB()) ? 1 : 0;
		});
		foreach (NEFBHKKAMJF item in list)
		{
			DKBGHENIFDI dKBGHENIFDI = new DKBGHENIFDI();
			dKBGHENIFDI.KNIAJMGDGAA = this;
			if (item.GPNKIAHCKMG.CMJPHGBOADI() != 0)
			{
				GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("UI/Common/HeroIcon"));
				gameObject.transform.parent = m_heroGrid.transform;
				gameObject.transform.localPosition = Vector3.zero;
				gameObject.transform.localScale = Vector3.one;
				dKBGHENIFDI.FJJBJNLEHJA = gameObject.GetComponent<UIHeroIcon>();
				dKBGHENIFDI.FJJBJNLEHJA.SetInfo(item.GPNKIAHCKMG, item);
				UIEventTrigger component = gameObject.GetComponent<UIEventTrigger>();
				component.onClick.Add(new EventDelegate(dKBGHENIFDI.HBJIFKNEJFI));
			}
		}
		List<HNEBHCMAOAE> list2 = new List<HNEBHCMAOAE>(GameServer.KIMJPIBNFGA.JJBDAOJIDAL().LNPGAJJAJKE().EPEJNKKPCCG()
			.Values);
		list2.RemoveAll((HNEBHCMAOAE MABBPNNIMBJ) => MABBPNNIMBJ.HGFCELBBJIC() != HNEBHCMAOAE.OPKPLDIMOCL.Hero || NetworkManager.get_Instance().get_m_gameNetClient().ACDEBBEGIIP()
			.NJHMPJDIMEH(MABBPNNIMBJ.INGLCFJBNOB()) != null || MABBPNNIMBJ.CMJPHGBOADI() == 0);
		list2.Sort((HNEBHCMAOAE MPBOINGECFO, HNEBHCMAOAE OECPEJEIMHO) =>
		{
			bool flag = BBDGMDMAKKI.OHFCIDJNLNM(MPBOINGECFO.INGLCFJBNOB());
			bool flag2 = BBDGMDMAKKI.OHFCIDJNLNM(OECPEJEIMHO.INGLCFJBNOB());
			if (flag && !flag2)
			{
				return -1;
			}
			if (!flag && flag2)
			{
				return 1;
			}
			bool flag3 = GameServer.KIMJPIBNFGA.JJBDAOJIDAL().LNPGAJJAJKE().DDPDAGNNMFL(MPBOINGECFO.INGLCFJBNOB());
			bool flag4 = GameServer.KIMJPIBNFGA.JJBDAOJIDAL().LNPGAJJAJKE().DDPDAGNNMFL(OECPEJEIMHO.INGLCFJBNOB());
			if (flag3 && !flag4)
			{
				return -1;
			}
			if (!flag3 && flag4)
			{
				return 1;
			}
			if (MPBOINGECFO.INGLCFJBNOB() > OECPEJEIMHO.INGLCFJBNOB())
			{
				return -1;
			}
			return (MPBOINGECFO.INGLCFJBNOB() < OECPEJEIMHO.INGLCFJBNOB()) ? 1 : 0;
		});
		foreach (HNEBHCMAOAE item2 in list2)
		{
			DHKIFLANAEG dHKIFLANAEG = new DHKIFLANAEG();
			dHKIFLANAEG.KNIAJMGDGAA = this;
			GameObject gameObject2 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("UI/Common/HeroIcon"));
			gameObject2.transform.parent = m_heroGrid.transform;
			gameObject2.transform.localPosition = Vector3.zero;
			gameObject2.transform.localScale = Vector3.one;
			dHKIFLANAEG.FJJBJNLEHJA = gameObject2.GetComponent<UIHeroIcon>();
			if (BBDGMDMAKKI.OHFCIDJNLNM(item2.INGLCFJBNOB()))
			{
				dHKIFLANAEG.FJJBJNLEHJA.SetInfo(item2, null, true);
			}
			else
			{
				dHKIFLANAEG.FJJBJNLEHJA.SetInfo(item2, null);
			}
			UIEventTrigger component2 = gameObject2.GetComponent<UIEventTrigger>();
			component2.onClick.Add(new EventDelegate(dHKIFLANAEG.BIMPEIHHIOI));
		}
		m_heroGrid.Reposition();
		if (CFAMDBIADFF == 0)
		{
			m_runePage1Button.set_normalSprite("square_small_button");
			m_runePage2Button.set_normalSprite("square_small_button_disable");
		}
		else
		{
			m_runePage1Button.set_normalSprite("square_small_button_disable");
			m_runePage2Button.set_normalSprite("square_small_button");
		}
		for (byte b = 0; b < KLDEHFCIMDN.IFOLDPBLAGD(); b++)
		{
			NOBFFGBGCNA nOBFFGBGCNA = KLDEHFCIMDN.FBNKGOOJPBB(b);
			m_battleReadyHeroInfos[b].m_slot = b;
			m_battleReadyHeroInfos[b].gameObject.SetActive(true);
			if (KLDEHFCIMDN.EHCPMLKEBME < 100)
			{
				if (b % 2 == 0)
				{
					m_battleReadyHeroInfos[b].m_showInviteButton = true;
				}
				else
				{
					m_battleReadyHeroInfos[b].m_showInviteButton = false;
				}
			}
			else
			{
				m_battleReadyHeroInfos[b].m_showInviteButton = true;
			}
			if (nOBFFGBGCNA.MNHIDGANMFO())
			{
				m_battleReadyHeroInfos[b].SetEmpty();
			}
			else
			{
				m_battleReadyHeroInfos[b].SetInfo(nOBFFGBGCNA.CJENLAELLAO());
			}
		}
		for (byte b2 = KLDEHFCIMDN.IFOLDPBLAGD(); b2 < 6; b2++)
		{
			m_battleReadyHeroInfos[b2].gameObject.SetActive(false);
		}
		m_oneDealerToggle.set_value(false);
		m_supporterToggle.set_value(false);
		m_junglerToggle.set_value(false);
		JMHGGCGKCLE = 99f;
		ODFKHOOMAEL = 10f;
		m_selectHeroWindow.SetActive(true);
		m_selectSkinWindow.SetActive(false);
		m_backButton.set_isEnabled(true);
		FPMIPKHIKLK = DateTime.Now;
		m_dodgePenaltyLabel.set_text(string.Empty);
		m_readyAlert.SetActive(false);
		V093CompatibilityFix.RestoreBattleRunePage(this);
	}

	public void OnClickRunePage2()
	{
		CFAMDBIADFF = 1;
		m_runePage1Button.set_normalSprite("square_small_button_disable");
		m_runePage2Button.set_normalSprite("square_small_button");
		NetworkManager.get_Instance().get_m_battleNetClient().MEFOOGMOJKD(1);
		V093CompatibilityFix.SaveBattleRunePage(1);
	}

	private TimeSpan KDHIIMFGBFF()
	{
		return FPMIPKHIKLK + TimeSpan.FromSeconds(120.0) - DateTime.Now;
	}

	private void OnApplicationPause(bool KDAJCGDLGME)
	{
		if (KDAJCGDLGME)
		{
			GLAMMOFPCHP gLAMMOFPCHP = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO();
			NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
			LobbyMain.get_Instance().PopPanelState();
		}
	}

	private void Start()
	{
		V096OriginalDiagnostics.Write("Lobby");
		V096OriginalDiagnostics.QueueAutomaticReportImmediate("Lobby");
		OAICFNLJHCN = null;
	}

	private static bool AANCCFIJPAF(HNEBHCMAOAE MABBPNNIMBJ)
	{
		return MABBPNNIMBJ.HGFCELBBJIC() == HNEBHCMAOAE.OPKPLDIMOCL.Hero && NetworkManager.get_Instance().get_m_gameNetClient().ACDEBBEGIIP()
			.FCICGLKEDND(MABBPNNIMBJ.HDCLGJHNAGL()) == null && MABBPNNIMBJ.CMJPHGBOADI() == 0;
	}

	[CompilerGenerated]
	private static void KBBKDKMAAHO()
	{
		NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
		LobbyMain.get_Instance().PopPanelState();
	}

	private void IFJGPCOJDMM()
	{
		m_selectHeroWindow.SetActive(true);
		m_selectSkinWindow.SetActive(false);
		for (int i = 1; i < m_heroGrid.transform.childCount; i++)
		{
			UnityEngine.Object.DestroyObject(m_heroGrid.transform.GetChild(i).gameObject);
		}
		m_battleInvitePanel.SetActive(true);
	}

	private static int INLGKNEEJMG(HNEBHCMAOAE MPBOINGECFO, HNEBHCMAOAE OECPEJEIMHO)
	{
		bool flag = BBDGMDMAKKI.LHOADFGHNAP(MPBOINGECFO.INGLCFJBNOB());
		bool flag2 = BBDGMDMAKKI.LHOADFGHNAP(OECPEJEIMHO.FFFDJEOHMIF());
		if (flag && !flag2)
		{
			return -1;
		}
		if (!flag && flag2)
		{
			return 1;
		}
		bool flag3 = GameServer.KIMJPIBNFGA.NOLHNOGGHNA().GAIHFJMKJAP().DDPDAGNNMFL(MPBOINGECFO.INGLCFJBNOB());
		bool flag4 = GameServer.KIMJPIBNFGA.JJBDAOJIDAL().LNPGAJJAJKE().DDPDAGNNMFL(OECPEJEIMHO.ODKFHEJKHMA());
		if (flag3 && !flag4)
		{
			return -1;
		}
		if (!flag3 && flag4)
		{
			return 1;
		}
		if (MPBOINGECFO.ODKFHEJKHMA() > OECPEJEIMHO.FFFDJEOHMIF())
		{
			return -1;
		}
		if (MPBOINGECFO.FFFDJEOHMIF() < OECPEJEIMHO.HDCLGJHNAGL())
		{
			return 1;
		}
		return 1;
	}

	[CompilerGenerated]
	private static int POBJFFOLMLE(NEFBHKKAMJF MPBOINGECFO, NEFBHKKAMJF OECPEJEIMHO)
	{
		if (MPBOINGECFO.GPNKIAHCKMG.INGLCFJBNOB() > OECPEJEIMHO.GPNKIAHCKMG.INGLCFJBNOB())
		{
			return -1;
		}
		if (MPBOINGECFO.GPNKIAHCKMG.INGLCFJBNOB() < OECPEJEIMHO.GPNKIAHCKMG.INGLCFJBNOB())
		{
			return 1;
		}
		return 0;
	}

	public void OnClickBackButton()
	{
		V096OriginalDiagnostics.QueueAutomaticReportImmediate("Lobby");
		if (KLDEHFCIMDN.FFCLCPEMBKE() && KDHIIMFGBFF().TotalSeconds > 0.0)
		{
			MsgManager.get_Instance().ShowMessageBox("지금 나가시면 [FFCCCC]닷지 패널티[-]가 적용됩니다\n\n일정시간동안 [FFCCCC]일부대전 이용이 제한[-]됩니다\n\n그래도 나가시겠습니까?", true, () =>
			{
				NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
				LobbyMain.get_Instance().PopPanelState();
			});
		}
		else
		{
			NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
			LobbyMain.get_Instance().PopPanelState();
		}
	}

	public void NIBLDDDNFCG()
	{
		if (m_oneDealerToggle.DEOGECMJCND())
		{
			NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MJPDBPDNIFC(0);
		}
		else if (m_supporterToggle.JOBICLFDKBD())
		{
			NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MJPDBPDNIFC(2);
		}
		else if (m_junglerToggle.get_value())
		{
			NetworkManager.get_Instance().FJOHLJABHHH().MJPDBPDNIFC(4);
		}
	}

	private void EHAABBLHEMP()
	{
		KLDEHFCIMDN = NetworkManager.APAPJEIBEDE().get_m_battleNetClient().IMKOGBNIJBO();
		CFAMDBIADFF = 0;
		List<NEFBHKKAMJF> list = NetworkManager.APAPJEIBEDE().get_m_gameNetClient().ACDEBBEGIIP()
			.AGBMNJEHJFG();
		list.Sort(MOLNMGICCJE);
		foreach (NEFBHKKAMJF item in list)
		{
			DKBGHENIFDI dKBGHENIFDI = new DKBGHENIFDI();
			dKBGHENIFDI.KNIAJMGDGAA = this;
			if (item.GPNKIAHCKMG.CMJPHGBOADI() != 0)
			{
				GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("하급 체력 표식"));
				gameObject.transform.parent = m_heroGrid.transform;
				gameObject.transform.localPosition = Vector3.zero;
				gameObject.transform.localScale = Vector3.one;
				dKBGHENIFDI.FJJBJNLEHJA = gameObject.GetComponent<UIHeroIcon>();
				dKBGHENIFDI.FJJBJNLEHJA.IMPMNGGLGGN(item.GPNKIAHCKMG, item);
				UIEventTrigger component = gameObject.GetComponent<UIEventTrigger>();
				component.onClick.Add(new EventDelegate(dKBGHENIFDI.PDMKFHNMJAJ));
			}
		}
		List<HNEBHCMAOAE> list2 = new List<HNEBHCMAOAE>(GameServer.KIMJPIBNFGA.HEDJPPFKABG().GAIHFJMKJAP().EPEJNKKPCCG()
			.Values);
		list2.RemoveAll(AANCCFIJPAF);
		list2.Sort(INLGKNEEJMG);
		foreach (HNEBHCMAOAE item2 in list2)
		{
			DHKIFLANAEG dHKIFLANAEG = new DHKIFLANAEG();
			dHKIFLANAEG.KNIAJMGDGAA = this;
			GameObject gameObject2 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(","));
			gameObject2.transform.parent = m_heroGrid.transform;
			gameObject2.transform.localPosition = Vector3.zero;
			gameObject2.transform.localScale = Vector3.one;
			dHKIFLANAEG.FJJBJNLEHJA = gameObject2.GetComponent<UIHeroIcon>();
			if (BBDGMDMAKKI.LCOJHANMOCB(item2.ODKFHEJKHMA()))
			{
				dHKIFLANAEG.FJJBJNLEHJA.IEKOOEKALDA(item2, null, true);
			}
			else
			{
				dHKIFLANAEG.FJJBJNLEHJA.BNLKNMALKFD(item2, null, true);
			}
			UIEventTrigger component2 = gameObject2.GetComponent<UIEventTrigger>();
			component2.onClick.Add(new EventDelegate(dHKIFLANAEG.BIMPEIHHIOI));
		}
		m_heroGrid.LEBHAMKOPHA();
		if (CFAMDBIADFF == 0)
		{
			m_runePage1Button.LOGLPIGEGDP("C#: HandleVideoComplete for placement ");
			m_runePage2Button.LOGLPIGEGDP("설명");
		}
		else
		{
			m_runePage1Button.set_normalSprite("Shadow");
			m_runePage2Button.set_normalSprite("Garen");
		}
		for (byte b = 0; b < KLDEHFCIMDN.KEMPNIBEPAM(); b++)
		{
			NOBFFGBGCNA nOBFFGBGCNA = KLDEHFCIMDN.IGNMALEPCPH(b);
			m_battleReadyHeroInfos[b].m_slot = b;
			m_battleReadyHeroInfos[b].gameObject.SetActive(true);
			if (KLDEHFCIMDN.EHCPMLKEBME < -26)
			{
				if (b % 7 == 0)
				{
					m_battleReadyHeroInfos[b].m_showInviteButton = true;
				}
				else
				{
					m_battleReadyHeroInfos[b].m_showInviteButton = true;
				}
			}
			else
			{
				m_battleReadyHeroInfos[b].m_showInviteButton = true;
			}
			if (nOBFFGBGCNA.MNHIDGANMFO())
			{
				m_battleReadyHeroInfos[b].GPJINNGCELJ();
			}
			else
			{
				m_battleReadyHeroInfos[b].EINNCAEHIFE(nOBFFGBGCNA.CJENLAELLAO());
			}
		}
		for (byte b2 = KLDEHFCIMDN.KEMPNIBEPAM(); b2 < 5; b2++)
		{
			m_battleReadyHeroInfos[b2].gameObject.SetActive(false);
		}
		m_oneDealerToggle.MEMNMJBHFJE(true);
		m_supporterToggle.HDDKOCJHKMH(true);
		m_junglerToggle.HDDKOCJHKMH(true);
		JMHGGCGKCLE = 1736f;
		ODFKHOOMAEL = 1190f;
		m_selectHeroWindow.SetActive(false);
		m_selectSkinWindow.SetActive(true);
		m_backButton.DMAMACNDKGD(true);
		FPMIPKHIKLK = DateTime.Now;
		m_dodgePenaltyLabel.set_text(string.Empty);
		m_readyAlert.SetActive(true);
	}

	private static int DJMPPPPKBDD(HNEBHCMAOAE MPBOINGECFO, HNEBHCMAOAE OECPEJEIMHO)
	{
		bool flag = BBDGMDMAKKI.OHFCIDJNLNM(MPBOINGECFO.FFFDJEOHMIF());
		bool flag2 = BBDGMDMAKKI.AHDBNIKBHCK(OECPEJEIMHO.FFFDJEOHMIF());
		if (flag && !flag2)
		{
			return -1;
		}
		if (!flag && flag2)
		{
			return 0;
		}
		bool flag3 = GameServer.KIMJPIBNFGA.HEDJPPFKABG().LNPGAJJAJKE().DDPDAGNNMFL(MPBOINGECFO.INGLCFJBNOB());
		bool flag4 = GameServer.KIMJPIBNFGA.NOLHNOGGHNA().LNPGAJJAJKE().DDPDAGNNMFL(OECPEJEIMHO.HDCLGJHNAGL());
		if (flag3 && !flag4)
		{
			return -1;
		}
		if (!flag3 && flag4)
		{
			return 1;
		}
		if (MPBOINGECFO.FFFDJEOHMIF() > OECPEJEIMHO.INGLCFJBNOB())
		{
			return -1;
		}
		if (MPBOINGECFO.HDCLGJHNAGL() < OECPEJEIMHO.ODKFHEJKHMA())
		{
			return 0;
		}
		return 0;
	}

	public void LOFBDLEGFML()
	{
		if (KLDEHFCIMDN.FFCLCPEMBKE() && KDHIIMFGBFF().TotalSeconds > 973.0)
		{
			MsgManager.get_Instance().ShowMessageBox("Hero3", true, () =>
			{
				NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
				LobbyMain.get_Instance().PopPanelState();
			});
		}
		else
		{
			NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MNCACLOFDBA();
			LobbyMain.get_Instance().PopPanelState();
		}
	}

	[CompilerGenerated]
	private static bool EPBBDCMHJEA(HNEBHCMAOAE MABBPNNIMBJ)
	{
		return MABBPNNIMBJ.HGFCELBBJIC() != HNEBHCMAOAE.OPKPLDIMOCL.Hero || NetworkManager.get_Instance().get_m_gameNetClient().ACDEBBEGIIP()
			.NJHMPJDIMEH(MABBPNNIMBJ.INGLCFJBNOB()) != null || MABBPNNIMBJ.CMJPHGBOADI() == 0;
	}

	public void EEFBHLOPLBC()
	{
		CFAMDBIADFF = 0;
		m_runePage1Button.set_normalSprite("마법저항력");
		m_runePage2Button.set_normalSprite("Nexus");
		NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MEFOOGMOJKD(0);
	}

	public void OnClickReadyButton()
	{
		V096OriginalDiagnostics.Write("voice_OK_Ready");
		V096OriginalDiagnostics.QueueAutomaticReportImmediate("voice_OK_Ready");
		if (NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.IBFJBIBACIA() == 0)
		{
			MsgManager.get_Instance().ShowTip("챔피언을 선택해 주세요.");
		}
		else
		{
			NetworkManager.get_Instance().get_m_battleNetClient().DFPELPCDPGK();
		}
	}

	[CompilerGenerated]
	private static int EJEIFNHNKIE(HNEBHCMAOAE MPBOINGECFO, HNEBHCMAOAE OECPEJEIMHO)
	{
		bool flag = BBDGMDMAKKI.OHFCIDJNLNM(MPBOINGECFO.INGLCFJBNOB());
		bool flag2 = BBDGMDMAKKI.OHFCIDJNLNM(OECPEJEIMHO.INGLCFJBNOB());
		if (flag && !flag2)
		{
			return -1;
		}
		if (!flag && flag2)
		{
			return 1;
		}
		bool flag3 = GameServer.KIMJPIBNFGA.JJBDAOJIDAL().LNPGAJJAJKE().DDPDAGNNMFL(MPBOINGECFO.INGLCFJBNOB());
		bool flag4 = GameServer.KIMJPIBNFGA.JJBDAOJIDAL().LNPGAJJAJKE().DDPDAGNNMFL(OECPEJEIMHO.INGLCFJBNOB());
		if (flag3 && !flag4)
		{
			return -1;
		}
		if (!flag3 && flag4)
		{
			return 1;
		}
		if (MPBOINGECFO.INGLCFJBNOB() > OECPEJEIMHO.INGLCFJBNOB())
		{
			return -1;
		}
		if (MPBOINGECFO.INGLCFJBNOB() < OECPEJEIMHO.INGLCFJBNOB())
		{
			return 1;
		}
		return 0;
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

	private void Refresh()
	{
		for (int i = 0; i < m_heroGrid.transform.childCount; i++)
		{
			Transform child = m_heroGrid.GetChild(i);
			if (!(child == null))
			{
				UIHeroIcon component = child.GetComponent<UIHeroIcon>();
				if (!(component == null))
				{
					component.SetInfo(component.m_heroData, NetworkManager.get_Instance().get_m_gameNetClient().ACDEBBEGIIP()
						.NJHMPJDIMEH(component.m_heroData.INGLCFJBNOB()), component.get_m_rotation());
				}
			}
		}
		for (byte b = 0; b < KLDEHFCIMDN.IFOLDPBLAGD(); b++)
		{
			NOBFFGBGCNA nOBFFGBGCNA = KLDEHFCIMDN.FBNKGOOJPBB(b);
			if (nOBFFGBGCNA != null && !nOBFFGBGCNA.MNHIDGANMFO())
			{
				m_battleReadyHeroInfos[b].SetInfo(nOBFFGBGCNA.CJENLAELLAO());
			}
			else
			{
				m_battleReadyHeroInfos[b].SetEmpty();
			}
		}
		if (NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.HHIEBIMNHPL())
		{
			m_selectHeroWindow.SetActive(false);
			m_selectSkinWindow.SetActive(true);
		}
		if (NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO()
			.OOHFDEPKKFN() != BattleServer.OCPEALOGAIP.OEOIIKMBGAG.CountDown)
		{
			ODFKHOOMAEL = 10f;
		}
	}

	public void OnChangeAutoEnterRoom()
	{
		Refresh();
		V096OriginalDiagnostics.ShareReport();
		V096OriginalDiagnostics.QueueAutomaticReportImmediate("OnChangeAutoEnterRoom");
	}

	private static int MOLNMGICCJE(NEFBHKKAMJF MPBOINGECFO, NEFBHKKAMJF OECPEJEIMHO)
	{
		if (MPBOINGECFO.GPNKIAHCKMG.INGLCFJBNOB() > OECPEJEIMHO.GPNKIAHCKMG.ODKFHEJKHMA())
		{
			return -1;
		}
		if (MPBOINGECFO.GPNKIAHCKMG.INGLCFJBNOB() < OECPEJEIMHO.GPNKIAHCKMG.INGLCFJBNOB())
		{
			return 0;
		}
		return 0;
	}

	public void CHPLKJBCEHO()
	{
		NetworkManager.get_Instance().IOJGPDKHAGD().PBCPEDIIHKO(new IKMBGMILCDO(OnReceiveHeroBuy), IEOJKFMIIEL);
	}

	public void JNABIMKPGON()
	{
		Refresh();
	}

	private void Update()
	{
		NOBFFGBGCNA nOBFFGBGCNA = KLDEHFCIMDN.FBNKGOOJPBB(NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.OHGOBGOIECH);
			if (nOBFFGBGCNA != null && !nOBFFGBGCNA.MNHIDGANMFO() && !nOBFFGBGCNA.CJENLAELLAO().HHIEBIMNHPL())
			{
				if (KLDEHFCIMDN.EHCPMLKEBME < 100 && KLDEHFCIMDN.DKAIONGOFDK())
				{
					JMHGGCGKCLE = (float)JMHGGCGKCLE - Time.unscaledDeltaTime;
				}
				if (KLDEHFCIMDN.FFCLCPEMBKE() && (float)JMHGGCGKCLE <= 15f && !m_readyAlert.activeInHierarchy)
				{
					m_readyAlert.SetActive(true);
				}
				if ((float)JMHGGCGKCLE <= 0f)
				{
					JMHGGCGKCLE = float.MaxValue;
					NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
					LobbyMain.get_Instance().PopPanelState();
				}
				else
				{
					int num = NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
						.LBHFMHJNPMD();
					for (int i = 0; i < m_timeoutLabel.Length; i++)
					{
						if (i == num)
						{
							m_timeoutLabel[i].gameObject.SetActive(true);
							m_timeoutLabel[i].set_text(Mathf.CeilToInt((float)JMHGGCGKCLE).ToString());
							if ((float)JMHGGCGKCLE > 10f)
							{
								m_timeoutLabel[i].set_color(new Color(1f, 1f, 1f));
							}
							else
							{
								m_timeoutLabel[i].set_color(new Color(1f, 0f, 0f));
							}
						}
						else
						{
							m_timeoutLabel[i].gameObject.SetActive(false);
						}
					}
				}
			}
			else
			{
				for (int j = 0; j < m_timeoutLabel.Length; j++)
				{
					m_timeoutLabel[j].gameObject.SetActive(false);
				}
				JMHGGCGKCLE = 20f;
				if (m_readyAlert.activeInHierarchy)
				{
					m_readyAlert.SetActive(false);
				}
			}
			GLAMMOFPCHP gLAMMOFPCHP = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO();
			if (gLAMMOFPCHP.OOHFDEPKKFN() == BattleServer.OCPEALOGAIP.OEOIIKMBGAG.CountDown)
			{
				ODFKHOOMAEL = (float)ODFKHOOMAEL - Time.deltaTime;
				if ((float)ODFKHOOMAEL < 1f)
				{
					m_mainLabel.set_text("[CCCCFF]게임이 시작됩니다![-] [BBFFBB]행운을 빕니다![-]");
				}
				else
				{
					m_mainLabel.set_text(string.Format("[FFAAAA]{0}초[-] 뒤에 게임이 시작됩니다.\n[CCCCFF]서로의 포지션을 정해주세요![-]", (int)(float)ODFKHOOMAEL));
				}
				if ((float)ODFKHOOMAEL < 6f)
				{
					m_backButton.set_isEnabled(false);
				}
				else
				{
					m_backButton.set_isEnabled(true);
				}
				if ((float)ODFKHOOMAEL <= -1f && (float)ODFKHOOMAEL > -10f)
				{
					ODFKHOOMAEL = -10f;
					NetworkManager.get_Instance().get_m_battleNetClient().HIHDKMNFGIK();
				}
			}
			else
			{
				m_mainLabel.set_text("다른 플레이어들을 기다려 주세요.");
				ODFKHOOMAEL = 10f;
				m_backButton.set_isEnabled(true);
			}
			if (KLDEHFCIMDN.EHCPMLKEBME < 100 && NetworkManager.get_Instance().get_m_battleNetClient().LAOADHLLFAK())
			{
				if (KLDEHFCIMDN.DKAIONGOFDK())
				{
					m_readyButton.gameObject.SetActive(true);
					m_autoEnterButton.gameObject.SetActive(true);
				}
				else
				{
					m_readyButton.gameObject.SetActive(true);
					m_autoEnterButton.gameObject.SetActive(true);
				}
			}
			else
			{
				m_readyButton.gameObject.SetActive(true);
				m_autoEnterButton.gameObject.SetActive(true);
			}
			if (KLDEHFCIMDN.FFCLCPEMBKE())
			{
				int num2 = (int)KDHIIMFGBFF().TotalSeconds;
				if (num2 > 0)
				{
					m_dodgePenaltyLabel.set_text(string.Format("닷지가능까지\n{0}초 남음", num2));
					return;
				}
				m_dodgePenaltyLabel.set_text(string.Empty);
				V093CompatibilityFix.UpdateTeamButton(this);
			}
		}

		public void OnClickRunePage1()
		{
			CFAMDBIADFF = 0;
			m_runePage1Button.set_normalSprite("square_small_button");
			m_runePage2Button.set_normalSprite("square_small_button_disable");
			NetworkManager.get_Instance().get_m_battleNetClient().MEFOOGMOJKD(0);
			V093CompatibilityFix.SaveBattleRunePage(0);
		}

		public void OnClickBuyOK()
		{
			OnReceiveHeroBuy(null);
		}

		public void CIHBHCPNKDG()
		{
			Refresh();
		}

		private void BKEKAJHABGK()
		{
			m_selectHeroWindow.SetActive(true);
			m_selectSkinWindow.SetActive(false);
			for (int i = 0; i < m_heroGrid.transform.childCount; i++)
			{
				UnityEngine.Object.DestroyObject(m_heroGrid.transform.GetChild(i).gameObject);
			}
			m_battleInvitePanel.SetActive(false);
		}

		private void OnDisable()
		{
			V096OriginalDiagnostics.QueueAutomaticReportImmediate("Exit");
			m_selectHeroWindow.SetActive(true);
			m_selectSkinWindow.SetActive(false);
			for (int i = 0; i < m_heroGrid.transform.childCount; i++)
			{
				UnityEngine.Object.DestroyObject(m_heroGrid.transform.GetChild(i).gameObject);
			}
			m_battleInvitePanel.SetActive(false);
		}

		public void OnClickAutoEnterButton()
		{
			V096OriginalDiagnostics.Write("자리 이동");
			V093CompatibilityFix.RequestTeamMove(this);
		}

		private void CFEIPPFANKJ()
		{
			KLDEHFCIMDN = NetworkManager.APAPJEIBEDE().get_m_battleNetClient().IMKOGBNIJBO();
			CFAMDBIADFF = 1;
			List<NEFBHKKAMJF> list = NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().ACDEBBEGIIP()
				.AGBMNJEHJFG();
			list.Sort(MOLNMGICCJE);
			foreach (NEFBHKKAMJF item in list)
			{
				DKBGHENIFDI dKBGHENIFDI = new DKBGHENIFDI();
				dKBGHENIFDI.KNIAJMGDGAA = this;
				if (item.GPNKIAHCKMG.CMJPHGBOADI() != 0)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("発注力"));
					gameObject.transform.parent = m_heroGrid.transform;
					gameObject.transform.localPosition = Vector3.zero;
					gameObject.transform.localScale = Vector3.one;
					dKBGHENIFDI.FJJBJNLEHJA = gameObject.GetComponent<UIHeroIcon>();
					dKBGHENIFDI.FJJBJNLEHJA.SetInfo(item.GPNKIAHCKMG, item, true);
					UIEventTrigger component = gameObject.GetComponent<UIEventTrigger>();
					component.onClick.Add(new EventDelegate(dKBGHENIFDI.LJGDHMOOCCP));
				}
			}
			List<HNEBHCMAOAE> list2 = new List<HNEBHCMAOAE>(GameServer.KIMJPIBNFGA.JJBDAOJIDAL().LNPGAJJAJKE().EPEJNKKPCCG()
				.Values);
			list2.RemoveAll((HNEBHCMAOAE MABBPNNIMBJ) => MABBPNNIMBJ.HGFCELBBJIC() != HNEBHCMAOAE.OPKPLDIMOCL.Hero || NetworkManager.get_Instance().get_m_gameNetClient().ACDEBBEGIIP()
				.NJHMPJDIMEH(MABBPNNIMBJ.INGLCFJBNOB()) != null || MABBPNNIMBJ.CMJPHGBOADI() == 0);
			list2.Sort(AJEBFCEGMIA);
			foreach (HNEBHCMAOAE item2 in list2)
			{
				DHKIFLANAEG dHKIFLANAEG = new DHKIFLANAEG();
				dHKIFLANAEG.KNIAJMGDGAA = this;
				GameObject gameObject2 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("Skill1MoveDirectionRpc"));
				gameObject2.transform.parent = m_heroGrid.transform;
				gameObject2.transform.localPosition = Vector3.zero;
				gameObject2.transform.localScale = Vector3.one;
				dHKIFLANAEG.FJJBJNLEHJA = gameObject2.GetComponent<UIHeroIcon>();
				if (BBDGMDMAKKI.LHOADFGHNAP(item2.FFFDJEOHMIF()))
				{
					dHKIFLANAEG.FJJBJNLEHJA.BNLKNMALKFD(item2, null);
				}
				else
				{
					dHKIFLANAEG.FJJBJNLEHJA.IEKOOEKALDA(item2, null, true);
				}
				UIEventTrigger component2 = gameObject2.GetComponent<UIEventTrigger>();
				component2.onClick.Add(new EventDelegate(dHKIFLANAEG.BIMPEIHHIOI));
			}
			m_heroGrid.Reposition();
			if (CFAMDBIADFF == 0)
			{
				m_runePage1Button.LOGLPIGEGDP("AMGMEEEIMEL");
				m_runePage2Button.LOGLPIGEGDP("OnPreRender");
			}
			else
			{
				m_runePage1Button.set_normalSprite("attack2");
				m_runePage2Button.LOGLPIGEGDP("ChangeTargetRpc");
			}
			for (byte b = 1; b < KLDEHFCIMDN.IFOLDPBLAGD(); b++)
			{
				NOBFFGBGCNA nOBFFGBGCNA = KLDEHFCIMDN.FBNKGOOJPBB(b);
				m_battleReadyHeroInfos[b].m_slot = b;
				m_battleReadyHeroInfos[b].gameObject.SetActive(true);
				if (KLDEHFCIMDN.EHCPMLKEBME < -73)
				{
					if (b % 4 == 0)
					{
						m_battleReadyHeroInfos[b].m_showInviteButton = false;
					}
					else
					{
						m_battleReadyHeroInfos[b].m_showInviteButton = false;
					}
				}
				else
				{
					m_battleReadyHeroInfos[b].m_showInviteButton = false;
				}
				if (nOBFFGBGCNA.MNHIDGANMFO())
				{
					m_battleReadyHeroInfos[b].GPJINNGCELJ();
				}
				else
				{
					m_battleReadyHeroInfos[b].EINNCAEHIFE(nOBFFGBGCNA.CJENLAELLAO());
				}
			}
			for (byte b2 = KLDEHFCIMDN.KEMPNIBEPAM(); b2 < 4; b2 += 0)
			{
				m_battleReadyHeroInfos[b2].gameObject.SetActive(false);
			}
			m_oneDealerToggle.MEMNMJBHFJE(false);
			m_supporterToggle.MEMNMJBHFJE(true);
			m_junglerToggle.MEMNMJBHFJE(true);
			JMHGGCGKCLE = 941f;
			ODFKHOOMAEL = 257f;
			m_selectHeroWindow.SetActive(false);
			m_selectSkinWindow.SetActive(false);
			m_backButton.set_isEnabled(false);
			FPMIPKHIKLK = DateTime.Now;
			m_dodgePenaltyLabel.DCKJILCPKFD(string.Empty);
			m_readyAlert.SetActive(true);
		}

		public void OJKCJEMICOI()
		{
			NetworkManager.get_Instance().get_m_gameNetClient().PBCPEDIIHKO(new IKMBGMILCDO(KKNPHGKNBCB, true, false), IEOJKFMIIEL);
		}
	}
