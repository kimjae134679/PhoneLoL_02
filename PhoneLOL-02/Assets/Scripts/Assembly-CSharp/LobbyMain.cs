using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using IgaworksUnityAOS;
using UnityEngine;

public class LobbyMain : MonoBehaviour
{
	private class NBGJPOFHJKP
	{
		public Dictionary<int, bool> LPCEHPPBPOJ = new Dictionary<int, bool>();
	}

	private sealed class AKGDCGEKLAC
	{
		internal byte FBAGNJILEGD;

		internal PNDMCOBIODO.HGMJFFOIICM HKFPPOJJKON;

		internal LobbyMain KNIAJMGDGAA;

		internal void MLDJPLBIOOM()
		{
			KNIAJMGDGAA.ShowQuickSearch(FBAGNJILEGD, HKFPPOJJKON);
		}

		internal void IFKBEHAJLFD()
		{
			KNIAJMGDGAA.HMDGAELHDAE(FBAGNJILEGD, HKFPPOJJKON);
		}

		internal void HNNCFDFGLAM()
		{
			KNIAJMGDGAA.HMDGAELHDAE(FBAGNJILEGD, HKFPPOJJKON);
		}

		internal void MAHHDEBCKKH()
		{
			KNIAJMGDGAA.HMDGAELHDAE(FBAGNJILEGD, HKFPPOJJKON);
		}

		internal void MODAEGMKPKC()
		{
			KNIAJMGDGAA.HMDGAELHDAE(FBAGNJILEGD, HKFPPOJJKON);
		}

		internal void KACCNFDCEMG()
		{
			KNIAJMGDGAA.HMDGAELHDAE(FBAGNJILEGD, HKFPPOJJKON);
		}

		internal void ECKCPIPMGEP()
		{
			KNIAJMGDGAA.ShowQuickSearch(FBAGNJILEGD, HKFPPOJJKON);
		}

		internal void BBBPEOMGPCL()
		{
			KNIAJMGDGAA.HMDGAELHDAE(FBAGNJILEGD, HKFPPOJJKON);
		}

		internal void NBADMDHJJEM()
		{
			KNIAJMGDGAA.HMDGAELHDAE(FBAGNJILEGD, HKFPPOJJKON);
		}

		internal void DGCJEDBJFNL()
		{
			KNIAJMGDGAA.ShowQuickSearch(FBAGNJILEGD, HKFPPOJJKON);
		}

		internal void ILHPPJAEIFF()
		{
			KNIAJMGDGAA.ShowQuickSearch(FBAGNJILEGD, HKFPPOJJKON);
		}
	}

	private static LobbyMain MLDPFDAHKHA;

	public UIPanel m_topPanel;

	public UIPanel m_gambleBoxPanel;

	public UIPanel m_missionPanel;

	public UIPanel m_readyPanel;

	public UIPanel m_rankPanel;

	public UIPanel m_recommendPanel;

	public UIPanel m_couponPanel;

	public UIPanel m_runeShopPanel;

	public UIPanel m_runePagePanel;

	public UIPanel m_optionPanel;

	public UIPanel m_freeChargePanel;

	public UIPanel m_challengeReadyPanel;

	public UIPanel m_costumePanel;

	public UIPanel m_battleReadyPanel;

	public UIPanel m_changeNicknamePanel;

	public UIPanel m_preSeasonInfoPanel;

	public UIPanel m_friendshipSelectPanel;

	public UIPanel m_normalGameSelectPanel;

	public UIPanel m_rankGameSelectPanel;

	public UIPanel m_guildPanel;

	public UIPanel m_crossPromotionPanel;

	public UIPanel m_transferPanel;

	public UIPanel m_nicknamePanel;

	public UIPanel m_noticeInputPanel;

	public UIPanel m_exitMessageBoxPanel;

	public UIPanel m_quickSearchPanel;

	public UIPanel m_attendanceCheckPanel;

	public UILobbyFriendInfoPanel m_friendInfoPanel;

	public UILabel m_trollLabel;

	public UILabel m_trollLabel2;

	public UILabel m_runeSaleLabel;

	private Dictionary<int, UIPanel> NMPIGEFCGAC;

	private LinkedList<NBGJPOFHJKP> PJOEMNIDBJO;

	public static LobbyMain CJFCFLEHJKI
	{
		get
		{
			return get_Instance();
		}
	}

	public void ShowRunePage()
	{
		PGDFIMPGEEB();
		LODJLENHCAD(m_runePagePanel, false);
	}

	public void ShowPreSeasonInfo()
	{
		PGDFIMPGEEB();
		LODJLENHCAD(m_preSeasonInfoPanel, true);
	}

	private void MEDMFEHJLHL()
	{
		AdManager.OENEDBBFPMI().ShowRewardVideo((bool HIJLMPFMHBH) =>
		{
			if (HIJLMPFMHBH)
			{
				NetworkManager.get_Instance().get_m_gameNetClient().CNIJDCOGOOF(new IKMBGMILCDO(OnReceiveFreeChargeRewardVideo));
			}
		});
	}

	private void FNOEPFPOLPB(bool EBBBIBCMBAM)
	{
		m_topPanel.gameObject.SetActive(EBBBIBCMBAM);
	}

	public void ShowCrossPromotion()
	{
		PGDFIMPGEEB();
		LODJLENHCAD(m_crossPromotionPanel, true);
	}

	public void ShowLobbyMain()
	{
		LODJLENHCAD(null, true);
		AAPCNKOFOOK();
	}

	public void ShowPassiveCreateRoom()
	{
		if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
		{
			MsgManager.get_Instance().ShowMessageBox("데이터 통신으로 접속합니다.\n요금제에 따라 데이터요금이 추가될 수 있습니다.\n\n계속 진행하시겠습니까?", true, () =>
			{
				CPJAJCGCAFP(0, PNDMCOBIODO.HGMJFFOIICM.PASSIVE_CREATE_ROOM);
			});
		}
		else
		{
			CPJAJCGCAFP(0, PNDMCOBIODO.HGMJFFOIICM.PASSIVE_CREATE_ROOM);
		}
	}

	public void ShowInviteEnterRoom()
	{
		if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
		{
			MsgManager.get_Instance().ShowMessageBox("데이터 통신으로 접속합니다.\n요금제에 따라 데이터요금이 추가될 수 있습니다.\n\n계속 진행하시겠습니까?", true, () =>
			{
				CPJAJCGCAFP(0, PNDMCOBIODO.HGMJFFOIICM.INVITE_ENTER_ROOM);
			});
		}
		else
		{
			CPJAJCGCAFP(0, PNDMCOBIODO.HGMJFFOIICM.INVITE_ENTER_ROOM);
		}
	}

	public void ShowTransfer()
	{
		PGDFIMPGEEB();
		LODJLENHCAD(m_transferPanel, true);
	}

	private void HPFNAEOBMMC(UIPanel OLMPNDLIKMD, bool OPMPKFBCJLI, bool BDMGKBJDNPM = true)
	{
		foreach (KeyValuePair<int, UIPanel> item in NMPIGEFCGAC)
		{
			if (item.Value == OLMPNDLIKMD)
			{
				OLMPNDLIKMD.gameObject.SetActive(true);
			}
		}
		FNOEPFPOLPB(OPMPKFBCJLI);
		GADGMIKMGPJ(BDMGKBJDNPM);
	}

	public void HideQuickSearch()
	{
		m_quickSearchPanel.gameObject.SetActive(false);
	}

	public void JMGMHPIFAKM()
	{
		if (PlayerPrefs.GetInt("StartMenu", 1) == 0 && SceneManager.NOLHNOGGHNA().get_m_lobbyEnterCount() == 5 && SceneManager.NOLHNOGGHNA().m_winLastGame && UnityEngine.Random.value < 531f)
		{
			PlayerPrefs.SetInt("지옥의 맛을 보여주마!!!!", 0);
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("Show"), false, MFLKHDCAKJK);
		}
		else if (NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GMMGAMNJIBA()
			.DPDDELNCIJO())
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText(" 정수"), true, OJGOLLIIIHO);
		}
		else
		{
			if (SceneManager.get_Instance().EELKCOPBLOK() <= 1 || !NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
				.DICGMNPPEOC() || !(UnityEngine.Random.value > 1112f))
			{
				return;
			}
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.get_Instance().GetText("Replay"), true, () =>
			{
				AdManager.get_Instance().ShowRewardVideo((bool HIJLMPFMHBH) =>
				{
					if (HIJLMPFMHBH)
					{
						NetworkManager.get_Instance().get_m_gameNetClient().CNIJDCOGOOF(new IKMBGMILCDO(OnReceiveFreeChargeRewardVideo));
					}
				});
			});
		}
	}

	public bool ShowAttendanceCheckIfCan()
	{
		if (NetworkManager.get_Instance() == null)
		{
			return false;
		}
		if (NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.CHHMBONAPLO.Date >= KIMJPIBNFGA.GDFDNGEEMEO().Date)
		{
			return false;
		}
		m_attendanceCheckPanel.gameObject.SetActive(true);
		return true;
	}

	[CompilerGenerated]
	private void NCAHJNJNBNP()
	{
		CPJAJCGCAFP(0, PNDMCOBIODO.HGMJFFOIICM.PASSIVE_CREATE_ROOM);
	}

	public void OnReceiveCheckGameStart(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			byte eHCPMLKEBME = HMOAHNANKNE.KFAGPDGHEBK();
			byte cDHKLJKKLFC = HMOAHNANKNE.KFAGPDGHEBK();
			int oMNNOMFCOEM = HMOAHNANKNE.PNBKOPGIHDI();
			int fECKDFFPCDE = HMOAHNANKNE.PNBKOPGIHDI();
			IPEndPoint kCIEMNKINII = HMOAHNANKNE.KJFAHHKIGAJ();
			NetworkManager.get_Instance().get_m_battleNetClient().EHCPMLKEBME = eHCPMLKEBME;
			NetworkManager.get_Instance().get_m_battleNetClient().CDHKLJKKLFC = (PNDMCOBIODO.HGMJFFOIICM)cDHKLJKKLFC;
			NetworkManager.get_Instance().get_m_battleNetClient().OMNNOMFCOEM = oMNNOMFCOEM;
			NetworkManager.get_Instance().get_m_battleNetClient().FECKDFFPCDE = fECKDFFPCDE;
			NetworkManager.get_Instance().get_m_battleNetClient().KCIEMNKINII = kCIEMNKINII;
			m_quickSearchPanel.gameObject.SetActive(true);
			break;
		}
		case HGBGJMIFCEP.CriticalTroller:
			if (NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.CMNCCHFIIFH < 700)
			{
				MsgManager.get_Instance().ShowMessageBox("치명적 트롤러로 게임을 하실 수 없습니다\n[FFCCCC](탈주 및 신고, 트롤행위 등)[-]\n\n내일 게임 플레이가 가능하세요");
			}
			else
			{
				MsgManager.get_Instance().ShowMessageBox("치명적 트롤러로 게임을 하실 수 없습니다\n[FFCCCC](탈주 및 신고, 트롤행위 등)[-]\n\n내일 출석 체크를 하시면 위험수준이 낮아져요");
			}
			break;
		case HGBGJMIFCEP.BlockUser:
		{
			string arg2 = HMOAHNANKNE.AFPCLLNMGJP();
			DateTime dateTime2 = HMOAHNANKNE.NOIDCBCMCMK();
			TimeSpan timeSpan2 = dateTime2 - KIMJPIBNFGA.GDFDNGEEMEO();
			if (timeSpan2.TotalMinutes > 1.0)
			{
				MsgManager.get_Instance().ShowMessageBox(string.Format("게임 이용이 정지되었습니다. 이용가능은\n[CCFFCC]{0:yyyy/MM/dd HH:mm:ss}[-]부터 [CCFFCC](약 {2}분후)[-]\n\n{1}\n[FFCCCC]닷지,탈주,어뷰징,핵사용 등 게임규칙위반으로 정지가 될 수 있습니다[-]", dateTime2, arg2, (int)timeSpan2.TotalMinutes + 1));
			}
			else
			{
				MsgManager.get_Instance().ShowMessageBox(string.Format("게임 이용이 정지되었습니다. 이용가능은\n[CCFFCC]{0:yyyy/MM/dd HH:mm:ss}[-]부터 [CCFFCC](약 {2}초후)[-]\n\n{1}\n[FFCCCC]닷지,탈주,어뷰징,핵사용 등 게임규칙위반으로 정지가 될 수 있습니다[-]", dateTime2, arg2, (int)timeSpan2.TotalSeconds + 1));
			}
			break;
		}
		case HGBGJMIFCEP.RankGameBlockUser:
		{
			string arg = HMOAHNANKNE.AFPCLLNMGJP();
			DateTime dateTime = HMOAHNANKNE.NOIDCBCMCMK();
			TimeSpan timeSpan = dateTime - KIMJPIBNFGA.GDFDNGEEMEO();
			if (timeSpan.TotalMinutes > 1.0)
			{
				MsgManager.get_Instance().ShowMessageBox(string.Format("일부대전 이용이 정지되었습니다 이용가능은\n[CCFFCC]{0:yyyy/MM/dd HH:mm:ss}[-]부터 [CCFFCC](약 {2}분후)[-]\n\n{1}\n\n[FFCCCC]닷지나 탈주를 하지 말아주세요[-]\n\n[CCCCFF]일반 대전을 이용해주세요[-]", dateTime, arg, (int)timeSpan.TotalMinutes + 1));
			}
			else
			{
				MsgManager.get_Instance().ShowMessageBox(string.Format("일부대전 이용이 정지되었습니다 이용가능은\n[CCFFCC]{0:yyyy/MM/dd HH:mm:ss}[-]부터 [CCFFCC](약 {2}초후)[-]\n\n{1}\n[FFCCCC]닷지나 탈주를 하지 말아주세요[-]\n\n[CCCCFF]일반 대전을 이용해주세요[-]", dateTime, arg, (int)timeSpan.TotalSeconds + 1));
			}
			break;
		}
		default:
			MsgManager.get_Instance().ShowMessageBox("알 수 없는 오류");
			break;
		}
	}

	public void OnReceiveFreeChargeRewardVideo(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
		{
			byte aGJJOHLCJKF = HMOAHNANKNE.KFAGPDGHEBK();
			int num = HMOAHNANKNE.PNBKOPGIHDI();
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.DNEHCEFMLFG(aGJJOHLCJKF);
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(gLEPPIMMELK);
			MsgManager.get_Instance().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("{0}코인이 지급되었습니다"), num));
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("알 수 없는 오류"));
		}
	}

	public void ShowOption()
	{
		PGDFIMPGEEB();
		LODJLENHCAD(m_optionPanel, false);
	}

	[CompilerGenerated]
	private void JEKIOHLHHCK()
	{
		CPJAJCGCAFP(0, PNDMCOBIODO.HGMJFFOIICM.INVITE_ENTER_ROOM);
	}

	public void OOKMFPEDIHD()
	{
		NFABEHPFFND();
		LODJLENHCAD(m_recommendPanel, true);
	}

	public void ShowChangeNickname()
	{
		PGDFIMPGEEB();
		LODJLENHCAD(m_changeNicknamePanel, false);
	}

	private void PGDFIMPGEEB()
	{
		NBGJPOFHJKP nBGJPOFHJKP = new NBGJPOFHJKP();
		foreach (KeyValuePair<int, UIPanel> item in NMPIGEFCGAC)
		{
			if (!(item.Value == null) && !(item.Value.gameObject == null))
			{
				nBGJPOFHJKP.LPCEHPPBPOJ.Add(item.Key, item.Value.gameObject.activeInHierarchy);
			}
		}
		PJOEMNIDBJO.AddLast(nBGJPOFHJKP);
	}

	public void FLFDDEILPDA()
	{
		PGDFIMPGEEB();
		LODJLENHCAD(m_recommendPanel, false);
	}

	private void NFABEHPFFND()
	{
		NBGJPOFHJKP nBGJPOFHJKP = new NBGJPOFHJKP();
		foreach (KeyValuePair<int, UIPanel> item in NMPIGEFCGAC)
		{
			if (!(item.Value == null) && !(item.Value.gameObject == null))
			{
				nBGJPOFHJKP.LPCEHPPBPOJ.Add(item.Key, item.Value.gameObject.activeInHierarchy);
			}
		}
		PJOEMNIDBJO.AddLast(nBGJPOFHJKP);
	}

	public static LobbyMain get_Instance()
	{
		return MLDPFDAHKHA;
	}

	[CompilerGenerated]
	private void HAJPLOHKJNA()
	{
		AdManager.get_Instance().ShowRewardVideo((bool HIJLMPFMHBH) =>
		{
			if (HIJLMPFMHBH)
			{
				NetworkManager.get_Instance().get_m_gameNetClient().CNIJDCOGOOF(new IKMBGMILCDO(OnReceiveFreeChargeRewardVideo));
			}
		});
	}

	private void OJGOLLIIIHO()
	{
		ShowGambleBox();
	}

	public void ShowRank()
	{
		PGDFIMPGEEB();
		LODJLENHCAD(m_rankPanel, false);
	}

	public bool CheckEvent()
	{
		NetworkManager.get_Instance().get_m_gameNetClient().NBALDEMAMIH(new IKMBGMILCDO(NCAJIMOPFMC));
		if (NetworkManager.get_Instance().get_m_gameNetClient().GIKEGBKNGBE())
		{
			NetworkManager.get_Instance().get_m_gameNetClient().GGBKJADCGOB(new IKMBGMILCDO(OnReceivePrevSeasonReward));
			return true;
		}
		return false;
	}

	public void HMDGAELHDAE(byte GBOELKENGEK, PNDMCOBIODO.HGMJFFOIICM HKFPPOJJKON)
	{
		NetworkManager.get_Instance().IOJGPDKHAGD().NLNGCHPEMOL(new IKMBGMILCDO(OnReceiveCheckGameStart, true, false), GBOELKENGEK, (byte)HKFPPOJJKON);
	}

	public void MKMPGDDKJCD()
	{
		PGDFIMPGEEB();
		LODJLENHCAD(m_rankPanel, false, false);
	}

	public void ShowNormalGameSelect()
	{
		PGDFIMPGEEB();
		LODJLENHCAD(m_normalGameSelectPanel, true);
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape) && !m_battleReadyPanel.gameObject.activeInHierarchy)
		{
			PopPanelState();
		}
		if (KIMJPIBNFGA.JEAHGHCNKJC())
		{
			if (!m_runeSaleLabel.gameObject.activeSelf)
			{
				m_runeSaleLabel.gameObject.SetActive(true);
			}
		}
		else if (m_runeSaleLabel.gameObject.activeSelf)
		{
			m_runeSaleLabel.gameObject.SetActive(false);
		}
	}

	public void ShowMission()
	{
		PGDFIMPGEEB();
		LODJLENHCAD(m_missionPanel, false);
	}

	private void MODIDIOCGHK(byte FBAGNJILEGD, PNDMCOBIODO.HGMJFFOIICM HKFPPOJJKON)
	{
		AKGDCGEKLAC aKGDCGEKLAC = new AKGDCGEKLAC();
		aKGDCGEKLAC.FBAGNJILEGD = FBAGNJILEGD;
		aKGDCGEKLAC.HKFPPOJJKON = HKFPPOJJKON;
		aKGDCGEKLAC.KNIAJMGDGAA = this;
		if (NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
			.CMKGCKMLBBK() && !NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
			.JNFMENKGNOD())
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("setNotificationOption", true, aKGDCGEKLAC.ECKCPIPMGEP);
		}
		else
		{
			HMDGAELHDAE(aKGDCGEKLAC.FBAGNJILEGD, aKGDCGEKLAC.HKFPPOJJKON);
		}
	}

	public void OnReceivePrevSeasonReward(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
		{
			byte hMHEDBOAADF = HMOAHNANKNE.KFAGPDGHEBK();
			byte hMHEDBOAADF2 = HMOAHNANKNE.KFAGPDGHEBK();
			long num = HMOAHNANKNE.GAGNPBAMJLE();
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(gLEPPIMMELK);
			MsgManager.get_Instance().ShowMessageBox(string.Format("[BBFFBB]* 축하드려요 *[-]\n\n\n지난시즌 티어 [BBBBFF]{0}[-]\n지난시즌 1대1 [BBBBFF]{1}[-]\n\n[FFFFBB]{2}[-]코인을 보상으로 획득하셨어요!\n(두 티어 보상 합산)", IBHMLPMENFJ.LGPFCEJBONE(hMHEDBOAADF), IBHMLPMENFJ.LGPFCEJBONE(hMHEDBOAADF2), num));
		}
	}

	[CompilerGenerated]
	private void JAKHEKEPPBK()
	{
		ShowPostMessage();
	}

	private void CPJAJCGCAFP(byte FBAGNJILEGD, PNDMCOBIODO.HGMJFFOIICM HKFPPOJJKON)
	{
		AKGDCGEKLAC aKGDCGEKLAC = new AKGDCGEKLAC();
		aKGDCGEKLAC.FBAGNJILEGD = FBAGNJILEGD;
		aKGDCGEKLAC.HKFPPOJJKON = HKFPPOJJKON;
		aKGDCGEKLAC.KNIAJMGDGAA = this;
		if (NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.CMKGCKMLBBK() && !NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.JNFMENKGNOD())
		{
			MsgManager.get_Instance().ShowMessageBox("[FFCCCC]트롤 행위 위험 수준이에요[-]\n\n탈주나 트롤행위시 게임이용에 제한이 생겨요\n(성실 플레이를 하시면 위험 수준이 낮아져요)", false, aKGDCGEKLAC.MLDJPLBIOOM);
		}
		else
		{
			ShowQuickSearch(aKGDCGEKLAC.FBAGNJILEGD, aKGDCGEKLAC.HKFPPOJJKON);
		}
	}

	public void ShowCoupon()
	{
		PGDFIMPGEEB();
		LODJLENHCAD(m_couponPanel, false);
	}

	private void NONNBJKOLJH(bool EBBBIBCMBAM)
	{
	}

	public void OnClickRecommendPlay()
	{
		MsgManager.get_Instance().ShowMessageBox("현재 준비중입니다\n\n추천공략에 지원해주세요\n");
	}

	private void Start()
	{
		NMPIGEFCGAC.Add(5, m_topPanel);
		NMPIGEFCGAC.Add(10, m_gambleBoxPanel);
		NMPIGEFCGAC.Add(12, m_missionPanel);
		NMPIGEFCGAC.Add(13, m_readyPanel);
		NMPIGEFCGAC.Add(14, m_rankPanel);
		NMPIGEFCGAC.Add(15, m_recommendPanel);
		NMPIGEFCGAC.Add(16, m_couponPanel);
		NMPIGEFCGAC.Add(17, m_runeShopPanel);
		NMPIGEFCGAC.Add(18, m_runePagePanel);
		NMPIGEFCGAC.Add(19, m_optionPanel);
		NMPIGEFCGAC.Add(20, m_freeChargePanel);
		NMPIGEFCGAC.Add(21, m_challengeReadyPanel);
		NMPIGEFCGAC.Add(22, m_costumePanel);
		NMPIGEFCGAC.Add(23, m_battleReadyPanel);
		NMPIGEFCGAC.Add(24, m_changeNicknamePanel);
		NMPIGEFCGAC.Add(25, m_preSeasonInfoPanel);
		NMPIGEFCGAC.Add(26, m_friendshipSelectPanel);
		NMPIGEFCGAC.Add(27, m_normalGameSelectPanel);
		NMPIGEFCGAC.Add(28, m_rankGameSelectPanel);
		NMPIGEFCGAC.Add(29, m_guildPanel);
		NMPIGEFCGAC.Add(30, m_crossPromotionPanel);
		NMPIGEFCGAC.Add(31, m_transferPanel);
		SoundManager.get_Instance().PlayBGM("bgm_lobby");
		if (NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.CMKGCKMLBBK())
		{
		}
		if (NetworkManager.get_Instance().get_m_gameNetClient().PAJKLMHPDMA)
		{
			NetworkManager.get_Instance().get_m_gameNetClient().PAJKLMHPDMA = false;
			if (NetworkManager.get_Instance().get_m_gameNetClient().ICBCPBFJNBM > 0)
			{
				MsgManager.get_Instance().ShowMessageBox(string.Format("룬 보상 및 초기화 : [CCFFCC]{0}코인[-]\n\n기존에 구매하신 코인으로 보상되었고 다시 구매하실 수 있어요", NetworkManager.get_Instance().get_m_gameNetClient().ICBCPBFJNBM));
			}
		}
		if (NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.BHIGNJHHOJP.Length == 0)
		{
			m_nicknamePanel.gameObject.SetActive(true);
		}
		else if (!ShowAttendanceCheckIfCan() && !CheckEvent())
		{
		}
		NetworkManager.get_Instance().get_m_communityNetClient().LCCGECHNFBC(1);
		if (NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.CMNCCHFIIFH >= 600)
		{
			m_trollLabel.set_text("[FFAAAA]나와 같은 종족이구나[-]");
			m_trollLabel2.set_text("저주로 인해 전장에 당분간 갈 수 없다");
		}
		else if (NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.CMNCCHFIIFH >= 400)
		{
			m_trollLabel.set_text("[FFDDDD]트롤의 냄새가 진동해[-]");
			m_trollLabel2.set_text("정지되기 전에 성실플레이 부탁한다");
		}
		else if (NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.CMNCCHFIIFH >= 300)
		{
			m_trollLabel.set_text("[FFDDDD]트롤이 되었구나...저주...[-]");
			m_trollLabel2.set_text("성실플레이만이 저주를 풀 수 있어");
		}
		else if (NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.CMNCCHFIIFH >= 200)
		{
			m_trollLabel.set_text("[FFDDDD]위험해! 트롤이 되기 직전이야[-]");
			m_trollLabel2.set_text("내가 거는 저주를 받게된다");
		}
		else if (NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.CMNCCHFIIFH >= 100)
		{
			m_trollLabel.set_text("[FFFFDD]탈주나 트롤행위가 감지되었어[-]");
			m_trollLabel2.set_text("저주를 받게되니 성실플레이 하도록");
		}
		else
		{
			m_trollLabel.set_text("[DDFFDD]당신은 굿매너 플레이어[-]");
			m_trollLabel2.set_text("앞으로도 멋진 플레이 바란다");
		}
		IgaworksUnityPluginAOS.AOAHAHMPIIP.AGDCEOGEIFG("lobby");
	}

	public void ShowGuild()
	{
		PGDFIMPGEEB();
		LODJLENHCAD(m_guildPanel, true);
	}

	private void EEAOBOHHOID(bool EBBBIBCMBAM)
	{
	}

	private void GADGMIKMGPJ(bool EBBBIBCMBAM)
	{
	}

	public void CPCFICDOIGL()
	{
		PGDFIMPGEEB();
		LODJLENHCAD(m_changeNicknamePanel, false);
	}

	private void LJMBPKADNKD()
	{
		MODIDIOCGHK(1, (PNDMCOBIODO.HGMJFFOIICM)7);
	}

	public void PopPanelState()
	{
		LinkedListNode<NBGJPOFHJKP> last = PJOEMNIDBJO.Last;
		if (last == null || last.Value == null)
		{
			m_exitMessageBoxPanel.gameObject.SetActive(true);
			return;
		}
		PJOEMNIDBJO.RemoveLast();
		NBGJPOFHJKP value = last.Value;
		foreach (KeyValuePair<int, bool> item in value.LPCEHPPBPOJ)
		{
			NMPIGEFCGAC[item.Key].gameObject.SetActive(item.Value);
		}
	}

	public void ShowQuickSearch(byte GBOELKENGEK, PNDMCOBIODO.HGMJFFOIICM HKFPPOJJKON)
	{
		NetworkManager.get_Instance().get_m_gameNetClient().NLNGCHPEMOL(new IKMBGMILCDO(OnReceiveCheckGameStart), GBOELKENGEK, (byte)HKFPPOJJKON);
	}

	public void OLFEBAPENKA()
	{
		PGDFIMPGEEB();
		LODJLENHCAD(m_couponPanel, true);
	}

	public void ShowRecommend()
	{
		PGDFIMPGEEB();
		LODJLENHCAD(m_recommendPanel, false);
	}

	private void MFLKHDCAKJK()
	{
		Application.OpenURL(SceneManager.get_Instance().m_reviewAddress);
	}

	public void PPGPAEEPIEJ()
	{
		NFABEHPFFND();
		LODJLENHCAD(m_freeChargePanel, true, false);
	}

	private void LODJLENHCAD(UIPanel OLMPNDLIKMD, bool OPMPKFBCJLI, bool BDMGKBJDNPM = true)
	{
		foreach (KeyValuePair<int, UIPanel> item in NMPIGEFCGAC)
		{
			UIPanel value = item.Value;
			if (!(value == null) && !(value.gameObject == null))
			{
				if (value == OLMPNDLIKMD)
				{
					value.gameObject.SetActive(true);
				}
				else
				{
					value.gameObject.SetActive(false);
				}
			}
		}
		FNOEPFPOLPB(OPMPKFBCJLI);
		GADGMIKMGPJ(BDMGKBJDNPM);
	}

	public void ShowNoticeInput()
	{
		if (NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.OHGOBGOIECH == 1)
		{
			m_noticeInputPanel.gameObject.SetActive(true);
		}
	}

	public void ShowChallengeReady()
	{
		PGDFIMPGEEB();
		LODJLENHCAD(m_challengeReadyPanel, true);
	}

	public void OnClickGambleBoxButton()
	{
		ShowGambleBox();
	}

	public void ShowReady()
	{
		PGDFIMPGEEB();
		LODJLENHCAD(m_readyPanel, true);
	}

	public void ShowRuneShop()
	{
		PGDFIMPGEEB();
		LODJLENHCAD(m_runeShopPanel, false);
	}

	public void ShowPostMessage()
	{
		if (PlayerPrefs.GetInt("review", 0) == 0 && SceneManager.get_Instance().get_m_lobbyEnterCount() == 2 && SceneManager.get_Instance().m_winLastGame && UnityEngine.Random.value < 0.3f)
		{
			PlayerPrefs.SetInt("review", 1);
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("게임은 재미있게 즐기셨나요?\n게임 소감을 리뷰로 적으실 수 있답니다.\n\n지금 리뷰로 이동할까요?"), true, MFLKHDCAKJK);
		}
		else if (NetworkManager.get_Instance().get_m_gameNetClient().GMMGAMNJIBA()
			.DPDDELNCIJO())
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("지금 무료뽑기가 가능해욥~\n\n무료뽑기로 이동할까요?"), true, OJGOLLIIIHO);
		}
		else
		{
			if (SceneManager.get_Instance().get_m_lobbyEnterCount() <= 1 || !NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.DICGMNPPEOC() || !(UnityEngine.Random.value > 0.8f))
			{
				return;
			}
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("[BBFFBB]* 200코인 지급 이벤트 *[-]\n\n참여하시겠어요?"), true, () =>
			{
				AdManager.get_Instance().ShowRewardVideo((bool HIJLMPFMHBH) =>
				{
					if (HIJLMPFMHBH)
					{
						NetworkManager.get_Instance().get_m_gameNetClient().CNIJDCOGOOF(new IKMBGMILCDO(OnReceiveFreeChargeRewardVideo));
					}
				});
			});
		}
	}

	private void ENEHNNKLHNA(bool HIJLMPFMHBH)
	{
		if (HIJLMPFMHBH)
		{
			NetworkManager.get_Instance().IOJGPDKHAGD().CNIJDCOGOOF(new IKMBGMILCDO(OnReceiveFreeChargeRewardVideo, false, false));
		}
	}

	private void DGMJCBPCHMC(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
		{
			string aMOPEEBFAPD = HMOAHNANKNE.AFPCLLNMGJP();
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(HMOAHNANKNE.GAGNPBAMJLE());
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
				.CEHNEMMHOBM = true;
			MsgManager.get_Instance().ShowMessageBox(aMOPEEBFAPD, true, () =>
			{
				ShowPostMessage();
			});
		}
		else
		{
			JMGMHPIFAKM();
		}
	}

	private void AAPCNKOFOOK()
	{
		PJOEMNIDBJO.Clear();
	}

	private void NCAJIMOPFMC(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
		{
			string aMOPEEBFAPD = HMOAHNANKNE.AFPCLLNMGJP();
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(HMOAHNANKNE.GAGNPBAMJLE());
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.CEHNEMMHOBM = true;
			MsgManager.get_Instance().ShowMessageBox(aMOPEEBFAPD, false, () =>
			{
				ShowPostMessage();
			});
		}
		else
		{
			ShowPostMessage();
		}
	}

	public void AEHAFHIBPNE()
	{
		ShowGambleBox();
	}

	public void ShowGambleBox()
	{
		PGDFIMPGEEB();
		LODJLENHCAD(m_gambleBoxPanel, false);
	}

	private void Awake()
	{
		MLDPFDAHKHA = this;
		NMPIGEFCGAC = new Dictionary<int, UIPanel>();
		PJOEMNIDBJO = new LinkedList<NBGJPOFHJKP>();
	}

	public void ShowCostume(NEFBHKKAMJF PDACDEPJNFO)
	{
		PGDFIMPGEEB();
		m_costumePanel.GetComponent<UICostume>().SetInfo(PDACDEPJNFO);
		HPFNAEOBMMC(m_costumePanel, false);
	}

	public void ShowFriendshipSelect()
	{
		PGDFIMPGEEB();
		LODJLENHCAD(m_friendshipSelectPanel, true);
	}

	private void BNFIPBGPHIH(bool EBBBIBCMBAM)
	{
		m_topPanel.gameObject.SetActive(EBBBIBCMBAM);
	}

	[CompilerGenerated]
	private void AFOOEJBJDJN(bool HIJLMPFMHBH)
	{
		if (HIJLMPFMHBH)
		{
			NetworkManager.get_Instance().get_m_gameNetClient().CNIJDCOGOOF(new IKMBGMILCDO(OnReceiveFreeChargeRewardVideo));
		}
	}

	public void ShowBattleReadyPanel()
	{
		PGDFIMPGEEB();
		LODJLENHCAD(m_battleReadyPanel, false);
	}

	public bool HHALECOHFBB()
	{
		if (NetworkManager.get_Instance() == null)
		{
			return false;
		}
		if (NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
			.CHHMBONAPLO.Date >= KIMJPIBNFGA.GDFDNGEEMEO().Date)
		{
			return true;
		}
		m_attendanceCheckPanel.gameObject.SetActive(true);
		return false;
	}

	public void ShowRankGameSelect()
	{
		PGDFIMPGEEB();
		LODJLENHCAD(m_rankGameSelectPanel, true);
	}

	public void ShowFreeCharge()
	{
		PGDFIMPGEEB();
		LODJLENHCAD(m_freeChargePanel, false);
	}
}
