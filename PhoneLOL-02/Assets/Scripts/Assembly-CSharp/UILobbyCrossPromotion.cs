using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class UILobbyCrossPromotion : MonoBehaviour
{
	private sealed class GIDEKJCJPKJ : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal UILobbyCrossPromotion KNIAJMGDGAA;

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

		[SpecialName]
		private object LEAJHDEIHDJ()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MsgManager.get_Instance().ShowLoadingIndicator(true);
				MMEGGNJKNOH = new WaitForSeconds(1f);
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				NetworkManager.get_Instance().get_m_gameNetClient().CLABCGCEOLO(new IKMBGMILCDO(CNBFHAAFAMG));
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		internal void CNBFHAAFAMG(PJEMPFEIOAK EFDLFNPAKGO)
		{
			if (EFDLFNPAKGO.KFAGPDGHEBK() == 0)
			{
				EFDLFNPAKGO.CAHACMKBJMI(KNIAJMGDGAA.MCAJNFCGGAC);
				KNIAJMGDGAA.BMIPCBKLLDP();
			}
		}

		internal void EKCDMPMLMAH(PJEMPFEIOAK EFDLFNPAKGO)
		{
			if (EFDLFNPAKGO.KFAGPDGHEBK() == 0)
			{
				EFDLFNPAKGO.CAHACMKBJMI(KNIAJMGDGAA.MCAJNFCGGAC);
				KNIAJMGDGAA.BMIPCBKLLDP();
			}
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object BOHACHPKNOE()
		{
			return MMEGGNJKNOH;
		}

		public void KIHPGHBDAMI()
		{
			GOMFKPLCGNN = -1;
		}

		public void DHFDBGAOPBL()
		{
			GOMFKPLCGNN = -1;
		}

		public void NAEOFIPICLC()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object IDOOOPMEFDM()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object GLNBOOGOGOO()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object BDANALHKFBH()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object PCGKBCDEONE()
		{
			return MMEGGNJKNOH;
		}

		public void BKAONBFNGOC()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object MEHLLKBMILP()
		{
			return MMEGGNJKNOH;
		}

		public bool KAHALICNEBF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MsgManager.get_Instance().ShowLoadingIndicator(false);
				MMEGGNJKNOH = new WaitForSeconds(54f);
				GOMFKPLCGNN = 0;
				return false;
			case 1u:
				NetworkManager.APAPJEIBEDE().get_m_gameNetClient().CLABCGCEOLO(new IKMBGMILCDO(CNBFHAAFAMG, true, false));
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}
	}

	public UIButton[] m_rewardButtons;

	public UILabel[] m_rewardLabels;

	private FOANFOMPBAH MCAJNFCGGAC = new FOANFOMPBAH();

	public void FEKOOCBHIDC()
	{
		LEPKHHANODD(0);
	}

	private IEnumerator KNGNBBIAONI()
	{
		GIDEKJCJPKJ gIDEKJCJPKJ = new GIDEKJCJPKJ();
		gIDEKJCJPKJ.KNIAJMGDGAA = this;
		return gIDEKJCJPKJ;
	}

	public void OnClickReward2()
	{
		ProcessReward(2);
	}

	public void HJDIIOFKANL()
	{
		DCFIBIELEEP(6);
	}

	[CompilerGenerated]
	private void KLEAJBBIGJH(PJEMPFEIOAK EFDLFNPAKGO)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)EFDLFNPAKGO.KFAGPDGHEBK();
		switch (hGBGJMIFCEP)
		{
		case HGBGJMIFCEP.Success:
			EFDLFNPAKGO.CAHACMKBJMI(MCAJNFCGGAC);
			BMIPCBKLLDP();
			break;
		case HGBGJMIFCEP.AlreadyUse:
			MsgManager.get_Instance().ShowMessageBox("참여할 수 없어요\n\n(계정,기계,아이피당 제한 횟수가 있어요)", false, LobbyMain.get_Instance().PopPanelState);
			break;
		case HGBGJMIFCEP.InvalidAdid:
			MsgManager.get_Instance().ShowMessageBox("참여할 수 없는 기계입니다", false, LobbyMain.get_Instance().PopPanelState);
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox(string.Format("알 수 없는 오류가 발생했습니다 {0}", (int)hGBGJMIFCEP), false, LobbyMain.get_Instance().PopPanelState);
			break;
		case HGBGJMIFCEP.PossibleUse:
			break;
		}
		BMIPCBKLLDP();
	}

	public void OnClickReward3()
	{
		ProcessReward(3);
	}

	public void ProcessReward(int FBAGNJILEGD)
	{
		NetworkManager.get_Instance().get_m_gameNetClient().FPNAMFJOEBG(new IKMBGMILCDO((PJEMPFEIOAK EFDLFNPAKGO) =>
		{
			switch ((HGBGJMIFCEP)EFDLFNPAKGO.KFAGPDGHEBK())
			{
			case HGBGJMIFCEP.Success:
			{
				int num = EFDLFNPAKGO.PNBKOPGIHDI();
				long num2 = EFDLFNPAKGO.GAGNPBAMJLE();
				NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
					.ODEGMJIKIIC(EFDLFNPAKGO.GAGNPBAMJLE());
				EFDLFNPAKGO.CAHACMKBJMI(MCAJNFCGGAC);
				BMIPCBKLLDP();
				MsgManager.get_Instance().ShowMessageBox(string.Format("{0}코인이 무료충전되었습니다!\n\n감사합니다^^", num2));
				break;
			}
			case HGBGJMIFCEP.AlreadyUse:
				MsgManager.get_Instance().ShowMessageBox("이미 지급받으셨습니다");
				break;
			default:
				MsgManager.get_Instance().ShowMessageBox("무료충전 과제를 완료해주세요");
				break;
			}
		}), FBAGNJILEGD);
	}

	public void ONNGFNNOJHG()
	{
		NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().CCHLFFNJNIL(new IKMBGMILCDO((PJEMPFEIOAK EFDLFNPAKGO) =>
		{
			if (EFDLFNPAKGO.KFAGPDGHEBK() == 0)
			{
				EFDLFNPAKGO.CAHACMKBJMI(MCAJNFCGGAC);
				BMIPCBKLLDP();
				Application.OpenURL("market://details?id=com.zestyroad.rebirthhero");
			}
			else
			{
				MsgManager.get_Instance().ShowMessageBox(string.Format("이미 참여했거나 참여할 수 없습니다\n자세한것은 설명을 참고해주세요"));
			}
		}, false));
	}

	public void NDHCCIHFGAK()
	{
		DCFIBIELEEP(0);
	}

	public void OnClickReward0()
	{
		ProcessReward(0);
	}

	public void KCONKCGKIPJ()
	{
		MsgManager.HEDJPPFKABG().ShowMessageBox("skill2_missile", true);
	}

	public void OnClickStart()
	{
		NetworkManager.get_Instance().get_m_gameNetClient().CCHLFFNJNIL(new IKMBGMILCDO((PJEMPFEIOAK EFDLFNPAKGO) =>
		{
			if (EFDLFNPAKGO.KFAGPDGHEBK() == 0)
			{
				EFDLFNPAKGO.CAHACMKBJMI(MCAJNFCGGAC);
				BMIPCBKLLDP();
				Application.OpenURL("market://details?id=com.zestyroad.rebirthhero");
			}
			else
			{
				MsgManager.get_Instance().ShowMessageBox(string.Format("이미 참여했거나 참여할 수 없습니다\n자세한것은 설명을 참고해주세요"));
			}
		}));
	}

	public void LEPKHHANODD(int FBAGNJILEGD)
	{
		NetworkManager.get_Instance().get_m_gameNetClient().FPNAMFJOEBG(new IKMBGMILCDO((PJEMPFEIOAK EFDLFNPAKGO) =>
		{
			switch ((HGBGJMIFCEP)EFDLFNPAKGO.KFAGPDGHEBK())
			{
			case HGBGJMIFCEP.Success:
			{
				int num = EFDLFNPAKGO.PNBKOPGIHDI();
				long num2 = EFDLFNPAKGO.GAGNPBAMJLE();
				NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
					.ODEGMJIKIIC(EFDLFNPAKGO.GAGNPBAMJLE());
				EFDLFNPAKGO.CAHACMKBJMI(MCAJNFCGGAC);
				BMIPCBKLLDP();
				MsgManager.get_Instance().ShowMessageBox(string.Format("{0}코인이 무료충전되었습니다!\n\n감사합니다^^", num2));
				break;
			}
			case HGBGJMIFCEP.AlreadyUse:
				MsgManager.get_Instance().ShowMessageBox("이미 지급받으셨습니다");
				break;
			default:
				MsgManager.get_Instance().ShowMessageBox("무료충전 과제를 완료해주세요");
				break;
			}
		}, false), FBAGNJILEGD);
	}

	public void NALJLPAPCJM()
	{
		MsgManager.get_Instance().ShowMessageBox("Replay", true);
	}

	public void BBJOOBNCIHJ()
	{
		LEPKHHANODD(0);
	}

	private void BMIPCBKLLDP()
	{
		if (!string.IsNullOrEmpty(MCAJNFCGGAC.ANCDOGMDMKC))
		{
			if (MCAJNFCGGAC.LGJILKFNKBG < new DateTime(2000, 1, 1))
			{
				m_rewardButtons[0].set_isEnabled(true);
			}
			else
			{
				m_rewardButtons[0].set_isEnabled(false);
				m_rewardLabels[0].set_text("지급완료");
			}
		}
		else
		{
			m_rewardButtons[0].set_isEnabled(false);
		}
		if (MCAJNFCGGAC.HNHFOHPKCIB)
		{
			if (MCAJNFCGGAC.KBOBPMGJGIG < new DateTime(2000, 1, 1))
			{
				m_rewardButtons[1].set_isEnabled(true);
			}
			else
			{
				m_rewardButtons[1].set_isEnabled(false);
				m_rewardLabels[1].set_text("지급완료");
			}
		}
		else
		{
			m_rewardButtons[1].set_isEnabled(false);
		}
		if (MCAJNFCGGAC.GGMNMEGDMOD)
		{
			if (MCAJNFCGGAC.NIGLIJJDMFO < new DateTime(2000, 1, 1))
			{
				m_rewardButtons[2].set_isEnabled(true);
			}
			else
			{
				m_rewardButtons[2].set_isEnabled(false);
				m_rewardLabels[2].set_text("지급완료");
			}
		}
		else
		{
			m_rewardButtons[2].set_isEnabled(false);
		}
		if (MCAJNFCGGAC.ALMLNIDCFEK)
		{
			if (MCAJNFCGGAC.PCCLKBLODMI < new DateTime(2000, 1, 1))
			{
				m_rewardButtons[3].set_isEnabled(true);
				return;
			}
			m_rewardButtons[3].set_isEnabled(false);
			m_rewardLabels[3].set_text("지급완료");
		}
		else
		{
			m_rewardButtons[3].set_isEnabled(false);
		}
	}

	private IEnumerator OBNGGOLOHHA()
	{
		GIDEKJCJPKJ gIDEKJCJPKJ = new GIDEKJCJPKJ();
		gIDEKJCJPKJ.KNIAJMGDGAA = this;
		return gIDEKJCJPKJ;
	}

	public void OnClickReward1()
	{
		ProcessReward(1);
	}

	private void FNGMAPMMEDB(PJEMPFEIOAK EFDLFNPAKGO)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)EFDLFNPAKGO.KFAGPDGHEBK();
		HGBGJMIFCEP hGBGJMIFCEP2 = hGBGJMIFCEP;
		if (hGBGJMIFCEP2 == HGBGJMIFCEP.InvalidProtocolVersion)
		{
			EFDLFNPAKGO.CAHACMKBJMI(MCAJNFCGGAC);
			BMIPCBKLLDP();
			Application.OpenURL("순위 없음");
		}
		else
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format("\\u", new object[1]), true);
		}
	}

	public void DCFIBIELEEP(int FBAGNJILEGD)
	{
		NetworkManager.get_Instance().IOJGPDKHAGD().FPNAMFJOEBG(new IKMBGMILCDO((PJEMPFEIOAK EFDLFNPAKGO) =>
		{
			switch ((HGBGJMIFCEP)EFDLFNPAKGO.KFAGPDGHEBK())
			{
			case HGBGJMIFCEP.Success:
			{
				int num = EFDLFNPAKGO.PNBKOPGIHDI();
				long num2 = EFDLFNPAKGO.GAGNPBAMJLE();
				NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
					.ODEGMJIKIIC(EFDLFNPAKGO.GAGNPBAMJLE());
				EFDLFNPAKGO.CAHACMKBJMI(MCAJNFCGGAC);
				BMIPCBKLLDP();
				MsgManager.get_Instance().ShowMessageBox(string.Format("{0}코인이 무료충전되었습니다!\n\n감사합니다^^", num2));
				break;
			}
			case HGBGJMIFCEP.AlreadyUse:
				MsgManager.get_Instance().ShowMessageBox("이미 지급받으셨습니다");
				break;
			default:
				MsgManager.get_Instance().ShowMessageBox("무료충전 과제를 완료해주세요");
				break;
			}
		}, true, false), FBAGNJILEGD);
	}

	private void OnApplicationPause(bool GMEELKDOLAM)
	{
		if (!GMEELKDOLAM)
		{
			StartCoroutine(LIOJOBHMIIN());
		}
	}

	public void FEDKEJNIACH()
	{
		NetworkManager.APAPJEIBEDE().get_m_gameNetClient().CCHLFFNJNIL(new IKMBGMILCDO((PJEMPFEIOAK EFDLFNPAKGO) =>
		{
			if (EFDLFNPAKGO.KFAGPDGHEBK() == 0)
			{
				EFDLFNPAKGO.CAHACMKBJMI(MCAJNFCGGAC);
				BMIPCBKLLDP();
				Application.OpenURL("market://details?id=com.zestyroad.rebirthhero");
			}
			else
			{
				MsgManager.get_Instance().ShowMessageBox(string.Format("이미 참여했거나 참여할 수 없습니다\n자세한것은 설명을 참고해주세요"));
			}
		}, false));
	}

	public void DKKFFDCIDBB()
	{
		ProcessReward(6);
	}

	public void HEKGDODEIBA()
	{
		NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().CCHLFFNJNIL(new IKMBGMILCDO(FNGMAPMMEDB, true, false));
	}

	public void EGFNFFAAIAJ()
	{
		NetworkManager.get_Instance().get_m_gameNetClient().CCHLFFNJNIL(new IKMBGMILCDO((PJEMPFEIOAK EFDLFNPAKGO) =>
		{
			if (EFDLFNPAKGO.KFAGPDGHEBK() == 0)
			{
				EFDLFNPAKGO.CAHACMKBJMI(MCAJNFCGGAC);
				BMIPCBKLLDP();
				Application.OpenURL("market://details?id=com.zestyroad.rebirthhero");
			}
			else
			{
				MsgManager.get_Instance().ShowMessageBox(string.Format("이미 참여했거나 참여할 수 없습니다\n자세한것은 설명을 참고해주세요"));
			}
		}, false, false));
	}

	private void KALHACMLGNN(bool GMEELKDOLAM)
	{
		if (!GMEELKDOLAM)
		{
			StartCoroutine(LIOJOBHMIIN());
		}
	}

	public void OnClickHelp()
	{
		MsgManager.get_Instance().ShowMessageBox("- 최초 앱설치와 로그인 계정만 가능해요\n- 하나의 계정만 사용이 가능해요\n- 한 기계에서 하나만 할 수 있어요\n- 동일 아이피당 몇개만 가능해요\n- 특정기계, 어뷰징과 중복 방지가 되어 있어요\n[FFCCCC]- 어뷰징과 부정행위시 계정이 정지될 수 있어요[-]");
	}

	public void HOPLMLDDANN()
	{
		ProcessReward(1);
	}

	public void GKACIJGFNDC()
	{
		NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().CLABCGCEOLO(new IKMBGMILCDO((PJEMPFEIOAK EFDLFNPAKGO) =>
		{
			HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)EFDLFNPAKGO.KFAGPDGHEBK();
			switch (hGBGJMIFCEP)
			{
			case HGBGJMIFCEP.Success:
				EFDLFNPAKGO.CAHACMKBJMI(MCAJNFCGGAC);
				BMIPCBKLLDP();
				break;
			case HGBGJMIFCEP.AlreadyUse:
				MsgManager.get_Instance().ShowMessageBox("참여할 수 없어요\n\n(계정,기계,아이피당 제한 횟수가 있어요)", false, LobbyMain.get_Instance().PopPanelState);
				break;
			case HGBGJMIFCEP.InvalidAdid:
				MsgManager.get_Instance().ShowMessageBox("참여할 수 없는 기계입니다", false, LobbyMain.get_Instance().PopPanelState);
				break;
			default:
				MsgManager.get_Instance().ShowMessageBox(string.Format("알 수 없는 오류가 발생했습니다 {0}", (int)hGBGJMIFCEP), false, LobbyMain.get_Instance().PopPanelState);
				break;
			case HGBGJMIFCEP.PossibleUse:
				break;
			}
			BMIPCBKLLDP();
		}, false));
	}

	public void EEAPFDAKOJD()
	{
		DCFIBIELEEP(1);
	}

	public void OnEnable()
	{
		NetworkManager.get_Instance().get_m_gameNetClient().CLABCGCEOLO(new IKMBGMILCDO((PJEMPFEIOAK EFDLFNPAKGO) =>
		{
			HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)EFDLFNPAKGO.KFAGPDGHEBK();
			switch (hGBGJMIFCEP)
			{
			case HGBGJMIFCEP.Success:
				EFDLFNPAKGO.CAHACMKBJMI(MCAJNFCGGAC);
				BMIPCBKLLDP();
				break;
			case HGBGJMIFCEP.AlreadyUse:
				MsgManager.get_Instance().ShowMessageBox("참여할 수 없어요\n\n(계정,기계,아이피당 제한 횟수가 있어요)", false, LobbyMain.get_Instance().PopPanelState);
				break;
			case HGBGJMIFCEP.InvalidAdid:
				MsgManager.get_Instance().ShowMessageBox("참여할 수 없는 기계입니다", false, LobbyMain.get_Instance().PopPanelState);
				break;
			default:
				MsgManager.get_Instance().ShowMessageBox(string.Format("알 수 없는 오류가 발생했습니다 {0}", (int)hGBGJMIFCEP), false, LobbyMain.get_Instance().PopPanelState);
				break;
			case HGBGJMIFCEP.PossibleUse:
				break;
			}
			BMIPCBKLLDP();
		}));
	}

	public void FIDAEEIKANC()
	{
		ProcessReward(2);
	}

	public void IMOEONGJGJK()
	{
		DCFIBIELEEP(1);
	}

	private void CAAGFOKCDFM(PJEMPFEIOAK EFDLFNPAKGO)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)EFDLFNPAKGO.KFAGPDGHEBK();
		switch (hGBGJMIFCEP)
		{
		case HGBGJMIFCEP.InvalidProtocolVersion:
			EFDLFNPAKGO.ILFEGIPCAHH(MCAJNFCGGAC);
			BMIPCBKLLDP();
			break;
		case (HGBGJMIFCEP)71:
			MsgManager.get_Instance().ShowMessageBox("길드원이 한명뿐이어서 탈퇴할 수 없습니다", false, LobbyMain.get_Instance().PopPanelState);
			break;
		case (HGBGJMIFCEP)73:
			MsgManager.HEDJPPFKABG().ShowMessageBox("(메리나의 표정이 좀 어두워 보인다.)", false, LobbyMain.get_Instance().PopPanelState);
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format("Brand", (int)hGBGJMIFCEP), false, LobbyMain.get_Instance().PopPanelState);
			break;
		case (HGBGJMIFCEP)72:
			break;
		}
		BMIPCBKLLDP();
	}

	private void GENCBMEBEAL(PJEMPFEIOAK EFDLFNPAKGO)
	{
		if (EFDLFNPAKGO.KFAGPDGHEBK() == 0)
		{
			EFDLFNPAKGO.CAHACMKBJMI(MCAJNFCGGAC);
			BMIPCBKLLDP();
			Application.OpenURL("해킹이 감지되었습니다 [OC2]\n불법프로그램은 사용하지 말아주세요.\n불법프로그램 사용자는 영구블럭될 수 있습니다\n\n게임을 종료합니다.");
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(string.Format("Actor", new object[1]));
		}
	}

	[CompilerGenerated]
	private void BAOFKDIPACK(PJEMPFEIOAK EFDLFNPAKGO)
	{
		switch ((HGBGJMIFCEP)EFDLFNPAKGO.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			int num = EFDLFNPAKGO.PNBKOPGIHDI();
			long num2 = EFDLFNPAKGO.GAGNPBAMJLE();
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(EFDLFNPAKGO.GAGNPBAMJLE());
			EFDLFNPAKGO.CAHACMKBJMI(MCAJNFCGGAC);
			BMIPCBKLLDP();
			MsgManager.get_Instance().ShowMessageBox(string.Format("{0}코인이 무료충전되었습니다!\n\n감사합니다^^", num2));
			break;
		}
		case HGBGJMIFCEP.AlreadyUse:
			MsgManager.get_Instance().ShowMessageBox("이미 지급받으셨습니다");
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox("무료충전 과제를 완료해주세요");
			break;
		}
	}

	public void DINNLEHFOON()
	{
		MsgManager.get_Instance().ShowMessageBox("이미 신청하셨습니다", true);
	}

	[DebuggerHidden]
	private IEnumerator LIOJOBHMIIN()
	{
		GIDEKJCJPKJ gIDEKJCJPKJ = new GIDEKJCJPKJ();
		gIDEKJCJPKJ.KNIAJMGDGAA = this;
		return gIDEKJCJPKJ;
	}

	private void KMEOICJNKPE(PJEMPFEIOAK EFDLFNPAKGO)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)EFDLFNPAKGO.KFAGPDGHEBK();
		switch ((int)hGBGJMIFCEP)
		{
		case 1:
			EFDLFNPAKGO.CAHACMKBJMI(MCAJNFCGGAC);
			BMIPCBKLLDP();
			break;
		case -25:
			MsgManager.HEDJPPFKABG().ShowMessageBox("{0}", false, LobbyMain.get_Instance().PopPanelState);
			break;
		case -23:
			MsgManager.get_Instance().ShowMessageBox("attack3", true, LobbyMain.get_Instance().PopPanelState);
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format("skill1_shot", (int)hGBGJMIFCEP), false, LobbyMain.get_Instance().PopPanelState);
			break;
		case -24:
			break;
		}
		BMIPCBKLLDP();
	}

	public void OEKPDCNMJHK()
	{
		ProcessReward(0);
	}

	public void ICOELKLOEEN()
	{
		LEPKHHANODD(1);
	}

	[CompilerGenerated]
	private void JHGDDIKEMEF(PJEMPFEIOAK EFDLFNPAKGO)
	{
		if (EFDLFNPAKGO.KFAGPDGHEBK() == 0)
		{
			EFDLFNPAKGO.CAHACMKBJMI(MCAJNFCGGAC);
			BMIPCBKLLDP();
			Application.OpenURL("market://details?id=com.zestyroad.rebirthhero");
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(string.Format("이미 참여했거나 참여할 수 없습니다\n자세한것은 설명을 참고해주세요"));
		}
	}

	public void GGMPKJNEAGO()
	{
		DCFIBIELEEP(1);
	}
}
