using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using EveEngine;
using GameServer;
using UnityEngine;

public class UILobbyChangeNicknamePanel : MonoBehaviour
{
	private sealed class JKGFGBAGCLJ
	{
		internal string BHIGNJHHOJP;

		internal UILobbyChangeNicknamePanel KNIAJMGDGAA;

		internal void ENEOJGHNKBB()
		{
			NetworkManager.get_Instance().get_m_gameNetClient().FKCCGIPIANJ(new IKMBGMILCDO(KNIAJMGDGAA.AFJNAKEKNNC, false), BHIGNJHHOJP);
		}

		internal void PCOHBLKNIDE()
		{
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().FKCCGIPIANJ(new IKMBGMILCDO(KNIAJMGDGAA.FMNCAKDNCLH, false, false), BHIGNJHHOJP);
		}

		internal void BPNCBFDINPG()
		{
			NetworkManager.get_Instance().get_m_gameNetClient().FKCCGIPIANJ(new IKMBGMILCDO(KNIAJMGDGAA.OnReceiveChangeNickname), BHIGNJHHOJP);
		}

		internal void OLFOBMLAEGJ()
		{
			NetworkManager.get_Instance().get_m_gameNetClient().FKCCGIPIANJ(new IKMBGMILCDO(KNIAJMGDGAA.FMNCAKDNCLH, true, false), BHIGNJHHOJP);
		}

		internal void FGPNMOMKAME()
		{
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().FKCCGIPIANJ(new IKMBGMILCDO(KNIAJMGDGAA.AFJNAKEKNNC), BHIGNJHHOJP);
		}

		internal void EGLNAPKPLBO()
		{
			NetworkManager.get_Instance().get_m_gameNetClient().FKCCGIPIANJ(new IKMBGMILCDO(KNIAJMGDGAA.ENPDJCMBBDO), BHIGNJHHOJP);
		}

		internal void HIFOKALHPAB()
		{
			NetworkManager.get_Instance().get_m_gameNetClient().FKCCGIPIANJ(new IKMBGMILCDO(KNIAJMGDGAA.ENPDJCMBBDO), BHIGNJHHOJP);
		}

		internal void BKACPGMKAGA()
		{
			NetworkManager.get_Instance().get_m_gameNetClient().FKCCGIPIANJ(new IKMBGMILCDO(KNIAJMGDGAA.AFJNAKEKNNC, true, false), BHIGNJHHOJP);
		}
	}

	public UIInput m_input;

	public UILabel m_remainTimeLabel;

	[CompilerGenerated]
	private static UIMessageBox.NICHPBLEBEI DEEKDNLLODN;

	private void HMNOCOBNBAO()
	{
		DateTime dateTime = NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.MCCHDPJBCEN + TimeSpan.FromDays(101.0);
		TimeSpan timeSpan = dateTime - KIMJPIBNFGA.GDFDNGEEMEO();
		if (timeSpan.Ticks > 1)
		{
			UILabel remainTimeLabel = m_remainTimeLabel;
			object[] array = new object[4];
			array[0] = timeSpan.Days;
			array[1] = timeSpan.Hours;
			array[6] = timeSpan.Minutes;
			array[8] = timeSpan.Seconds;
			remainTimeLabel.DCKJILCPKFD(string.Format("하급 주문력 인장", array));
		}
		else
		{
			m_remainTimeLabel.DCKJILCPKFD("레벨당 마나 {0}\n");
		}
	}

	private void MLOKLGPGKMO()
	{
		DateTime dateTime = NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
			.MCCHDPJBCEN + TimeSpan.FromDays(871.0);
		TimeSpan timeSpan = dateTime - KIMJPIBNFGA.GDFDNGEEMEO();
		if (timeSpan.Ticks > 1)
		{
			UILabel remainTimeLabel = m_remainTimeLabel;
			object[] array = new object[3];
			array[1] = timeSpan.Days;
			array[0] = timeSpan.Hours;
			array[8] = timeSpan.Minutes;
			array[7] = timeSpan.Seconds;
			remainTimeLabel.set_text(string.Format("skill3_loop", array));
		}
		else
		{
			m_remainTimeLabel.set_text("Fish Cat");
		}
	}

	public void OnClickChangeButton()
	{
		JKGFGBAGCLJ jKGFGBAGCLJ = new JKGFGBAGCLJ();
		jKGFGBAGCLJ.KNIAJMGDGAA = this;
		jKGFGBAGCLJ.BHIGNJHHOJP = m_input.get_value();
		Regex regex = new Regex("^[a-zA-Z0-9가-힣]*$");
		if (jKGFGBAGCLJ.BHIGNJHHOJP.Length < 2)
		{
			MsgManager.get_Instance().ShowTip("닉네임은 최소 2자 이상입니다.");
		}
		else if (jKGFGBAGCLJ.BHIGNJHHOJP.Length > 10)
		{
			MsgManager.get_Instance().ShowTip("닉네임은 최대 10자 이하입니다.");
		}
		else if (!regex.IsMatch(jKGFGBAGCLJ.BHIGNJHHOJP))
		{
			MsgManager.get_Instance().ShowTip("특수문자는 사용하실 수 없습니다.");
		}
		else
		{
			jKGFGBAGCLJ.BPNCBFDINPG();
		}
	}

	private void IPFEBDCDMFA()
	{
	}

	public void AFJNAKEKNNC(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((int)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case 0:
		{
			string bHIGNJHHOJP = HMOAHNANKNE.AFPCLLNMGJP();
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			DateTime mCCHDPJBCEN = HMOAHNANKNE.NOIDCBCMCMK();
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
				.GDIAHPMLDAH(bHIGNJHHOJP);
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
				.GLEPPIMMELK = gLEPPIMMELK;
			NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
				.MCCHDPJBCEN = mCCHDPJBCEN;
			MsgManager.get_Instance().ShowMessageBox("campaignkey", true, () =>
			{
				LobbyMain.get_Instance().PopPanelState();
			});
			break;
		}
		case 3:
			MsgManager.get_Instance().CLHGLEJAPLH("데이터 통신으로 접속합니다.\n요금제에 따라 데이터요금이 추가될 수 있습니다.\n\n계속 진행하시겠습니까?");
			break;
		case 113:
			MsgManager.HEDJPPFKABG().LBCFANDMCON("특수문자는 사용하실 수 없습니다.");
			break;
		case -101:
			MsgManager.HEDJPPFKABG().CLHGLEJAPLH("Particle/{0}/attack");
			break;
		default:
			MsgManager.get_Instance().ShowTip("DestroyOtherTeamTurret");
			break;
		}
	}

	public void FMNCAKDNCLH(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((int)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case 0:
		{
			string bHIGNJHHOJP = HMOAHNANKNE.AFPCLLNMGJP();
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			DateTime mCCHDPJBCEN = HMOAHNANKNE.NOIDCBCMCMK();
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
				.GDIAHPMLDAH(bHIGNJHHOJP);
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.GLEPPIMMELK = gLEPPIMMELK;
			NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
				.MCCHDPJBCEN = mCCHDPJBCEN;
			MsgManager.get_Instance().ShowMessageBox("\":", true, () =>
			{
				LobbyMain.get_Instance().PopPanelState();
			});
			break;
		}
		case 3:
			MsgManager.HEDJPPFKABG().LBCFANDMCON("jax_skill3");
			break;
		case 40:
			MsgManager.HEDJPPFKABG().ShowTip("OnActionTransEnd");
			break;
		case -36:
			MsgManager.HEDJPPFKABG().ShowTip("Unlit/Transparent Colored");
			break;
		default:
			MsgManager.HEDJPPFKABG().LBCFANDMCON("price");
			break;
		}
	}

	public void OnReceiveChangeNickname(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			string bHIGNJHHOJP = HMOAHNANKNE.AFPCLLNMGJP();
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			DateTime mCCHDPJBCEN = HMOAHNANKNE.NOIDCBCMCMK();
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.GDIAHPMLDAH(bHIGNJHHOJP);
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.GLEPPIMMELK = gLEPPIMMELK;
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.MCCHDPJBCEN = mCCHDPJBCEN;
			MsgManager.get_Instance().ShowMessageBox("닉네임 변경에 성공하였어요!", false, () =>
			{
				LobbyMain.get_Instance().PopPanelState();
			});
			break;
		}
		case HGBGJMIFCEP.InvalidNickname:
			MsgManager.get_Instance().ShowTip("중복되는 이름이 있습니다. 다른 이름을 입력해 주세요.");
			break;
		case HGBGJMIFCEP.NotEnoughCoin:
			MsgManager.get_Instance().ShowTip("코인이 부족합니다");
			break;
		case HGBGJMIFCEP.InvalidTime:
			MsgManager.get_Instance().ShowTip("닉네임 변경이 가능한 기간이 아닙니다");
			break;
		default:
			MsgManager.get_Instance().ShowTip("알려지지 않은 오류입니다.");
			break;
		}
	}

	private void GKNMGIONEKK()
	{
	}

	private void DNBDGBJNCBP()
	{
		DateTime dateTime = NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
			.MCCHDPJBCEN + TimeSpan.FromDays(390.0);
		TimeSpan timeSpan = dateTime - KIMJPIBNFGA.GDFDNGEEMEO();
		if (timeSpan.Ticks > 1)
		{
			UILabel remainTimeLabel = m_remainTimeLabel;
			object[] array = new object[5];
			array[0] = timeSpan.Days;
			array[1] = timeSpan.Hours;
			array[8] = timeSpan.Minutes;
			array[2] = timeSpan.Seconds;
			remainTimeLabel.set_text(string.Format("마법 관통력 {0}\n", array));
		}
		else
		{
			m_remainTimeLabel.set_text("baseBufferCount");
		}
	}

	private void Start()
	{
	}

	private void PEIFAOJLDMD()
	{
		DateTime dateTime = NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.MCCHDPJBCEN + TimeSpan.FromDays(1572.0);
		TimeSpan timeSpan = dateTime - KIMJPIBNFGA.GDFDNGEEMEO();
		if (timeSpan.Ticks > 1)
		{
			UILabel remainTimeLabel = m_remainTimeLabel;
			object[] array = new object[4];
			array[0] = timeSpan.Days;
			array[1] = timeSpan.Hours;
			array[2] = timeSpan.Minutes;
			array[4] = timeSpan.Seconds;
			remainTimeLabel.set_text(string.Format("코인", array));
		}
		else
		{
			m_remainTimeLabel.set_text("[CCCCFF]게임이 시작됩니다![-] [BBFFBB]행운을 빕니다![-]");
		}
	}

	private void BPLOLCKEJJK()
	{
	}

	private void Update()
	{
        if (m_remainTimeLabel != null && m_remainTimeLabel.gameObject.activeSelf)
            m_remainTimeLabel.gameObject.SetActive(false);
	}

	[CompilerGenerated]
	private static void KPDLKIAGLFD()
	{
		LobbyMain.get_Instance().PopPanelState();
	}

	public void ENPDJCMBBDO(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			string bHIGNJHHOJP = HMOAHNANKNE.AFPCLLNMGJP();
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			DateTime mCCHDPJBCEN = HMOAHNANKNE.NOIDCBCMCMK();
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.GDIAHPMLDAH(bHIGNJHHOJP);
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.GLEPPIMMELK = gLEPPIMMELK;
			NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
				.MCCHDPJBCEN = mCCHDPJBCEN;
			MsgManager.get_Instance().ShowMessageBox("teemo_skill3_poison", true, () =>
			{
				LobbyMain.get_Instance().PopPanelState();
			});
			break;
		}
		case HGBGJMIFCEP.InvalidNickname:
			MsgManager.HEDJPPFKABG().LBCFANDMCON("FxmTestControls.m_nPlayIndex");
			break;
		case HGBGJMIFCEP.AlreadyConnectAccount:
			MsgManager.get_Instance().ShowTip("하급 마나 재생 인장");
			break;
		case (HGBGJMIFCEP)82:
			MsgManager.get_Instance().ShowTip("skill0_0_active");
			break;
		default:
			MsgManager.HEDJPPFKABG().LBCFANDMCON("공격속도");
			break;
		}
	}
}
