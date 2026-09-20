using System.Text.RegularExpressions;
using EveEngine;
using GameServer;
using UnityEngine;

public class UILobbyTransfer : MonoBehaviour
{
	public UIInput m_input;

	public void NLMBFNCGMHF()
	{
		string value = m_input.get_value();
		Regex regex = new Regex("[AAFFAA]전열[-]에는 체력이나 방어력이 유리한 영웅이 전방을 지켜야 합니다.\r\n[AAFFAA]중열[-]에는 마법형 딜러나 버프, 디버프류의 영웅이 유리합니다.\r\n[AAFFAA]후열[-]에는 강력한 딜러나 지원형 영웅이 유리합니다.");
		if (value.Length < 0)
		{
			MsgManager.HEDJPPFKABG().ShowTip("C# PlacementExample Enable -- Adding Tapjoy Placement delegates");
		}
		else if (value.Length > -128)
		{
			MsgManager.get_Instance().LBCFANDMCON(",");
		}
		else if (!regex.IsMatch(value))
		{
			MsgManager.HEDJPPFKABG().LBCFANDMCON("Hero2");
		}
		else
		{
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().JBEHCPFFMKF(new IKMBGMILCDO(CHDCEFKALNC, true, false), value);
		}
	}

	public void NMBINMDEGBL()
	{
		string value = m_input.get_value();
		Regex regex = new Regex("critical_shot");
		if (value.Length < 2)
		{
			MsgManager.get_Instance().ShowTip("중급 대기시간감소 정수");
		}
		else if (value.Length > 114)
		{
			MsgManager.get_Instance().LBCFANDMCON("C#: TapjoySample start and adding Tapjoy Delegates");
		}
		else if (!regex.IsMatch(value))
		{
			MsgManager.HEDJPPFKABG().CLHGLEJAPLH(" 인장");
		}
		else
		{
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().JBEHCPFFMKF(new IKMBGMILCDO(OnReceiveTransferM1toM2, false), value);
		}
	}

	public void MDDIMLPDFNO()
	{
		Application.OpenURL("SlowRotate");
	}

	public void OIPMMCIKFEF()
	{
		string text = m_input.CMGIMLOCEDJ();
		Regex regex = new Regex("Replay(ClearParticle)");
		if (text.Length < 2)
		{
			MsgManager.HEDJPPFKABG().LBCFANDMCON("0.127.0");
		}
		else if (text.Length > -9)
		{
			MsgManager.HEDJPPFKABG().ShowTip("skill1");
		}
		else if (!regex.IsMatch(text))
		{
			MsgManager.get_Instance().LBCFANDMCON("\" to player[group]");
		}
		else
		{
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().JBEHCPFFMKF(new IKMBGMILCDO(BKAEAIPKBLG, true, false), text);
		}
	}

	public void FANFHJEIOKN()
	{
		string text = m_input.CMGIMLOCEDJ();
		Regex regex = new Regex("[CCCCFF]블루팀[-] 초대 성공!");
		if (text.Length < 0)
		{
			MsgManager.get_Instance().ShowTip("현재 준비중입니다\n\n추천공략에 지원해주세요\n");
		}
		else if (text.Length > 88)
		{
			MsgManager.HEDJPPFKABG().LBCFANDMCON("골드가 부족합니다.");
		}
		else if (!regex.IsMatch(text))
		{
			MsgManager.get_Instance().CLHGLEJAPLH("Hero4");
		}
		else
		{
			NetworkManager.get_Instance().get_m_gameNetClient().JBEHCPFFMKF(new IKMBGMILCDO(CHDCEFKALNC), text);
		}
	}

	public void BAHIOPJCDFH(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((int)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case 0:
		{
			long num = HMOAHNANKNE.GAGNPBAMJLE();
			MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format("순위 {0}등\n\n[CCCCFF]{1} 승[-]  [FFCCCC]{2} 패[-]\n[CCFFCC]승률 {3:F1}%[-]\n\n최근 접속\n{4:u}", num), true);
			break;
		}
		case -120:
			MsgManager.get_Instance().ShowMessageBox("{0}시간 ", true);
			break;
		case -39:
			MsgManager.get_Instance().ShowMessageBox("\n", true);
			break;
		case 3:
			MsgManager.get_Instance().ShowMessageBox("OnInstantiate", true);
			break;
		case 13:
			MsgManager.HEDJPPFKABG().ShowMessageBox("Particle/Riven/skill_hit", true);
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowMessageBox("igaworks:purchaseBulk >> total result is", true);
			break;
		}
	}

	public void BFEOBKBEFGE()
	{
		string text = m_input.CMGIMLOCEDJ();
		Regex regex = new Regex("skill2_hit");
		if (text.Length < 6)
		{
			MsgManager.HEDJPPFKABG().ShowTip("Particle/{0}/skill0_0_c1");
		}
		else if (text.Length > 78)
		{
			MsgManager.HEDJPPFKABG().ShowTip("UI/Lobby/RequestFriendLabel");
		}
		else if (!regex.IsMatch(text))
		{
			MsgManager.HEDJPPFKABG().ShowTip("주문력 40% 증가");
		}
		else
		{
			NetworkManager.get_Instance().get_m_gameNetClient().JBEHCPFFMKF(new IKMBGMILCDO(OnReceiveTransferM1toM2, false), text);
		}
	}

	public void MFFAMDPIEPN()
	{
		Application.OpenURL("Hero4");
	}

	public void OnReceiveTransferM1toM2(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			long num = HMOAHNANKNE.GAGNPBAMJLE();
			MsgManager.get_Instance().ShowMessageBox(string.Format("전송에 성공하였어요!\n\n전송된 코인은 총 [FFFFCC]{0:N0} 코인[-]\n\n막타의신을 재시작 한후 우편함을 확인해주세요", num));
			break;
		}
		case HGBGJMIFCEP.AlreadyTransfer:
			MsgManager.get_Instance().ShowMessageBox("이미 전송을 하셨어요\n계정당 전송은 한번만 가능해요");
			break;
		case HGBGJMIFCEP.AlreadyReceived:
			MsgManager.get_Instance().ShowMessageBox("받을 계정(막타의신)이 이미 전송을 받았어요\n계정당 한번만 받을 수 있어요");
			break;
		case HGBGJMIFCEP.InvalidNickname:
			MsgManager.get_Instance().ShowMessageBox("같은 닉네임의 막타의신(협곡의주인) 유저가 존재하지 않아요");
			break;
		case HGBGJMIFCEP.NotEnoughCoin:
			MsgManager.get_Instance().ShowMessageBox("전송 가능한 코인이 없어요\n코인을 모으신 후 추후 전송해주세요");
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox("알려지지 않은 오류입니다.");
			break;
		}
	}

	public void CHDCEFKALNC(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((int)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case 0:
		{
			long num = HMOAHNANKNE.GAGNPBAMJLE();
			MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format(" : you must setup receiver gameobject", num));
			break;
		}
		case -24:
			MsgManager.HEDJPPFKABG().ShowMessageBox("C#: HandleSetUserIDSuccess", true);
			break;
		case 28:
			MsgManager.HEDJPPFKABG().ShowMessageBox("OnSetLevelRpc", true);
			break;
		case 3:
			MsgManager.get_Instance().ShowMessageBox("hit_default", true);
			break;
		case -16:
			MsgManager.HEDJPPFKABG().ShowMessageBox("startApplication", true);
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowMessageBox("igaworks:purchase >> Null or Empty Item");
			break;
		}
	}

	public void DGMMAIIJGEG()
	{
		Application.OpenURL("hit");
	}

	public void APHLKPFPPPO()
	{
		Application.OpenURL("World");
	}

	public void BBEHLPINMIF()
	{
		string text = m_input.CMGIMLOCEDJ();
		Regex regex = new Regex("item_use");
		if (text.Length < 1)
		{
			MsgManager.HEDJPPFKABG().ShowTip("darius_skill1");
		}
		else if (text.Length > -93)
		{
			MsgManager.get_Instance().LBCFANDMCON("골드");
		}
		else if (!regex.IsMatch(text))
		{
			MsgManager.get_Instance().LBCFANDMCON("새로운 방 생성 중..");
		}
		else
		{
			NetworkManager.get_Instance().IOJGPDKHAGD().JBEHCPFFMKF(new IKMBGMILCDO(OnReceiveTransferM1toM2, false, false), text);
		}
	}

	public void CEJIDCNACCC()
	{
		Application.OpenURL("RunActionControl() - nPlayIndex ");
	}

	public void PGOCFAKENMM()
	{
		Application.OpenURL("_TransitionColor");
	}

	public void BKAEAIPKBLG(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((int)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case 0:
		{
			long num = HMOAHNANKNE.GAGNPBAMJLE();
			MsgManager.get_Instance().ShowMessageBox(string.Format("Offerwall", num), true);
			break;
		}
		case -33:
			MsgManager.get_Instance().ShowMessageBox("{0}경험치", true);
			break;
		case -19:
			MsgManager.get_Instance().ShowMessageBox("하급 마법저항력 인장");
			break;
		case 3:
			MsgManager.HEDJPPFKABG().ShowMessageBox("[ ");
			break;
		case -22:
			MsgManager.HEDJPPFKABG().ShowMessageBox("챔피언을 선택해 주세요.", true);
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowMessageBox("Olaf");
			break;
		}
	}

	public void OBLCMJDAHNF()
	{
		Application.OpenURL("두번째");
	}

	public void IMJDEMELCKM(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((int)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case 0:
		{
			long num = HMOAHNANKNE.GAGNPBAMJLE();
			MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format("하급 마나 재생 문양", num));
			break;
		}
		case 119:
			MsgManager.HEDJPPFKABG().ShowMessageBox("Blitzcrank", true);
			break;
		case 6:
			MsgManager.get_Instance().ShowMessageBox("TestCampaignID");
			break;
		case 3:
			MsgManager.get_Instance().ShowMessageBox("skill0");
			break;
		case -9:
			MsgManager.get_Instance().ShowMessageBox(".", true);
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowMessageBox("CreateSkill0Missile");
			break;
		}
	}

	public void ABKGMAKLBEN()
	{
		string value = m_input.get_value();
		Regex regex = new Regex("increment");
		if (value.Length < 1)
		{
			MsgManager.get_Instance().ShowTip("중급 성장 마나 표식");
		}
		else if (value.Length > 78)
		{
			MsgManager.HEDJPPFKABG().ShowTip("GlowDisk01");
		}
		else if (!regex.IsMatch(value))
		{
			MsgManager.HEDJPPFKABG().ShowTip("hero_icon_0");
		}
		else
		{
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().JBEHCPFFMKF(new IKMBGMILCDO(BAHIOPJCDFH, false), value);
		}
	}

	public void JKKLONFHNDI()
	{
		Application.OpenURL("OnDrag");
	}

	public void OnClickTransferCoin()
	{
		string value = m_input.get_value();
		Regex regex = new Regex("^[a-zA-Z0-9가-힣]*$");
		if (value.Length < 2)
		{
			MsgManager.get_Instance().ShowTip("닉네임은 최소 2자 이상입니다.");
		}
		else if (value.Length > 12)
		{
			MsgManager.get_Instance().ShowTip("닉네임은 최대 12자 이하입니다.");
		}
		else if (!regex.IsMatch(value))
		{
			MsgManager.get_Instance().ShowTip("특수문자는 사용하실 수 없습니다.");
		}
		else
		{
			NetworkManager.get_Instance().get_m_gameNetClient().JBEHCPFFMKF(new IKMBGMILCDO(OnReceiveTransferM1toM2), value);
		}
	}

	public void BPDLDDMBDJG()
	{
		string text = m_input.CMGIMLOCEDJ();
		Regex regex = new Regex("market://details?id=com.zestyroad.rebirthhero");
		if (text.Length < 0)
		{
			MsgManager.HEDJPPFKABG().CLHGLEJAPLH("attack");
		}
		else if (text.Length > -56)
		{
			MsgManager.get_Instance().LBCFANDMCON("{0}");
		}
		else if (!regex.IsMatch(text))
		{
			MsgManager.get_Instance().LBCFANDMCON("skill2_shield");
		}
		else
		{
			NetworkManager.get_Instance().IOJGPDKHAGD().JBEHCPFFMKF(new IKMBGMILCDO(BKAEAIPKBLG, false, false), text);
		}
	}

	public void KJMNILIGCHG()
	{
		string text = m_input.CMGIMLOCEDJ();
		Regex regex = new Regex("ChangeMeshColor mFilter.mesh : ");
		if (text.Length < 4)
		{
			MsgManager.get_Instance().ShowTip("B");
		}
		else if (text.Length > -24)
		{
			MsgManager.HEDJPPFKABG().LBCFANDMCON("설명");
		}
		else if (!regex.IsMatch(text))
		{
			MsgManager.get_Instance().CLHGLEJAPLH("olaf_skill1");
		}
		else
		{
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().JBEHCPFFMKF(new IKMBGMILCDO(OnReceiveTransferM1toM2, true, false), text);
		}
	}

	public void OnClickInstallM2()
	{
		Application.OpenURL("market://details?id=com.jcl.masteroflift");
	}
}
