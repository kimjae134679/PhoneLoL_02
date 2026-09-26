using EveEngine;
using GameServer;
using UnityEngine;

public class UILobbyCoupon : MonoBehaviour
{
	public UIInput m_couponInput;

	private void BMEDFIPNBJM()
	{
	}

	private void DBMKCDDBPJL()
	{
	}

	private void OnDisable()
	{
	}

	private void KKAAPHCPGLF()
	{
	}

	private void DFOCBKNIDGB()
	{
	}

	private void BGHOAINJPDI(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((int)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case 0:
		{
			int num = HMOAHNANKNE.PNBKOPGIHDI();
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(gLEPPIMMELK);
			MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("completedRewardKey"), num));
			break;
		}
		case -23:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("CreateCurrentInstanceEffect() - gameObj - "));
			break;
		case -22:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("Exit"));
			break;
		case -21:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("skill2_hit"));
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("attack2_voice"), true);
			break;
		}
	}

	private void IOPIDJGICGI(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((int)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case 1:
		{
			int num = HMOAHNANKNE.PNBKOPGIHDI();
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(gLEPPIMMELK);
			MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("Mesh"), num));
			break;
		}
		case -7:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("ui_click"));
			break;
		case -6:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("CreateAttackMissile"), true);
			break;
		case -5:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("Project T\r\n\r\nRagtime presents"), true);
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("skill0_hit"), true);
			break;
		}
	}

	private void IFJGPCOJDMM()
	{
	}

	private void KKKCJJKNKII(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((int)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case 0:
		{
			int num = HMOAHNANKNE.PNBKOPGIHDI();
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
				.ODEGMJIKIIC(gLEPPIMMELK);
			MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("RedMinionWizard"), num));
			break;
		}
		case -128:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("能力電源"));
			break;
		case -127:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("설명"));
			break;
		case -126:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.get_Instance().GetText("이미 접속중입니다.\n\n기존 접속을 끊거나\n잠시후에 다시 시도해 주세요."));
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.get_Instance().GetText("Touch Start/Up"));
			break;
		}
	}

	private void JDMOCFODCFG()
	{
	}

	private void DDEGDABBPDF()
	{
	}

	private void NDIEGKILKHF()
	{
	}

	private void CMIONEEKFEA()
	{
	}

	private void CMFCDCEOAKN()
	{
	}

	private void LECBGJIJDMI(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			int num = HMOAHNANKNE.PNBKOPGIHDI();
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(gLEPPIMMELK);
			MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("Skill2Wave"), num));
			break;
		}
		case (HGBGJMIFCEP)104:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("출석체크로 [BBFFBB]{0}[-]코인을 획득"));
			break;
		case (HGBGJMIFCEP)105:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("Twist me"), true);
			break;
		case (HGBGJMIFCEP)106:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.get_Instance().GetText(" msgId: "));
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("\r"), true);
			break;
		}
	}

	private void EOEMDFLLKGL(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			int num = HMOAHNANKNE.PNBKOPGIHDI();
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
				.ODEGMJIKIIC(gLEPPIMMELK);
			MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format(LocalizationManager.LGDEHELDENG().GetText("cv"), num));
			break;
		}
		case (HGBGJMIFCEP)116:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("move_speed_percent"));
			break;
		case (HGBGJMIFCEP)117:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("HKD"), true);
			break;
		case (HGBGJMIFCEP)118:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("dragon"));
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.get_Instance().GetText("[Client]HeroData"));
			break;
		}
	}

	private void OLNPLGEDFKL(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			int num = HMOAHNANKNE.PNBKOPGIHDI();
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
				.ODEGMJIKIIC(gLEPPIMMELK);
			MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format(LocalizationManager.LGDEHELDENG().GetText("챔피언을 선택해 주세요."), num));
			break;
		}
		case (HGBGJMIFCEP)81:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("Mana"));
			break;
		case (HGBGJMIFCEP)82:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("방어구 관통력"));
			break;
		case (HGBGJMIFCEP)83:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.get_Instance().GetText("레벨당 마법저항력"));
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("Particle/{0}/attack"));
			break;
		}
	}

	public void OnClickOKButton()
	{
		string value = m_couponInput.get_value();
		if (value.Length < 5)
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("잘못된 쿠폰번호입니다."));
		}
		else
		{
			NetworkManager.get_Instance().get_m_gameNetClient().DJKEMFACFEN(new IKMBGMILCDO(CNGNPFHPNHI), value);
		}
	}

	private void LNDHNJGOIKC()
	{
	}

	private void CNGNPFHPNHI(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			int num = HMOAHNANKNE.PNBKOPGIHDI();
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(gLEPPIMMELK);
			MsgManager.get_Instance().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("[BBFFBB]{0}[-]코인을 획득하였습니다"), num));
			break;
		}
		case HGBGJMIFCEP.InvalidCoupon:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("잘못된 쿠폰번호입니다."));
			break;
		case HGBGJMIFCEP.ExpireCoupon:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("기간이 지난 쿠폰입니다."));
			break;
		case HGBGJMIFCEP.AlreadyUseCoupon:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("이미 사용한 쿠폰입니다."));
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("알려지지 않은 오류입니다."));
			break;
		}
	}

	private void KKOBOPCPAND()
	{
	}

	public void HNIKOIBNMBJ()
	{
		string text = m_couponInput.CMGIMLOCEDJ();
		if (text.Length < 4)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("MeshColor"), true);
		}
		else
		{
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().DJKEMFACFEN(new IKMBGMILCDO(JLACGKOEECF), text);
		}
	}

	public void AENBIGLEGGN()
	{
		string text = m_couponInput.CMGIMLOCEDJ();
		if (text.Length < 6)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("C#: HandleVideoStarted for placement "), true);
		}
		else
		{
			NetworkManager.get_Instance().get_m_gameNetClient().DJKEMFACFEN(new IKMBGMILCDO(EOEMDFLLKGL, false, false), text);
		}
	}

	private void ONDMOAFNNAA()
	{
	}

	private void OnEnable()
	{
	}

	private void CAFGDJHGDHP(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((int)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case 0:
		{
			int num = HMOAHNANKNE.PNBKOPGIHDI();
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(gLEPPIMMELK);
			MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("우린 마계로 들어가는 입구로 가기 위해서는 이 숲을 지나는 중이였어!"), num));
			break;
		}
		case -39:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.get_Instance().GetText("하급 방어력 정수"));
			break;
		case -38:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("#########################################"));
			break;
		case -37:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("RespwanHero"));
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("Particle/{0}/attack"));
			break;
		}
	}

	private void JLACGKOEECF(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((int)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case 1:
		{
			int num = HMOAHNANKNE.PNBKOPGIHDI();
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(gLEPPIMMELK);
			MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("AP.Unity : OnHideDialogListenerForUnity : "), num));
			break;
		}
		case -23:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("skill2"));
			break;
		case -22:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("실패하였습니다"), true);
			break;
		case -21:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("TestKey1"));
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.get_Instance().GetText("진행중인 방에 재입장 중.."), true);
			break;
		}
	}
}
