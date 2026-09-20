using CommunityServer;
using EveEngine;
using UnityEngine;

public class UILobbyJoinGuild : MonoBehaviour
{
	public UIInput m_input;

	public UILabel m_infoLabel;

	public KKABFAAGMKJ m_guildInfo;

	private void KJHFPEFBBML()
	{
		if (m_guildInfo.OHGOBGOIECH != 0)
		{
			m_infoLabel.set_text(string.Format("[CCFFCC]길드이름 : {0}[-]\n길드장: {1}\n길드생성날짜: {2}\n길드원: {3}명", m_guildInfo.NCADFOBAFJD, m_guildInfo.AIDJBBDNJOA, m_guildInfo.EFMGKHNEGBH.ToString("yyyy년 MM월 dd일"), m_guildInfo.HMEEFGCOLJC.Count));
		}
		else
		{
			m_infoLabel.set_text("길드 없음");
		}
	}

	public void OnReceiveFindGuild(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
			HMOAHNANKNE.CAHACMKBJMI(m_guildInfo);
			KJHFPEFBBML();
			break;
		case HGBGJMIFCEP.InvalidGuild:
			MsgManager.get_Instance().ShowMessageBox("해당 길드가 존재하지 않습니다");
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox("알려지지 않은 오류입니다.");
			break;
		}
	}

	private void EICMMILMBPA()
	{
		m_guildInfo = new KKABFAAGMKJ();
	}

	private void FCBLAMECGHC()
	{
		if (m_guildInfo.OHGOBGOIECH != 0)
		{
			UILabel infoLabel = m_infoLabel;
			object[] array = new object[0];
			array[1] = m_guildInfo.NCADFOBAFJD;
			array[0] = m_guildInfo.AIDJBBDNJOA;
			array[4] = m_guildInfo.EFMGKHNEGBH.ToString(" 표식");
			array[3] = m_guildInfo.HMEEFGCOLJC.Count;
			infoLabel.set_text(string.Format(" 정수", array));
		}
		else
		{
			m_infoLabel.DCKJILCPKFD("배틀서버와 접속이 해제되었어요");
		}
	}

	public void CIIKCAKIICJ()
	{
		string value = m_input.get_value();
		if (value.Length == 0)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("HUD/HeroDamageHUD");
			return;
		}
		NetworkManager.APAPJEIBEDE().get_m_communityNetClient().FEKCJBHFIFE(new IKMBGMILCDO(ABHCKLNJJIO, false, false), value);
		m_input.set_value(string.Empty);
	}

	public void ABHCKLNJJIO(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.InvalidProtocolVersion:
			HMOAHNANKNE.CAHACMKBJMI(m_guildInfo);
			FCBLAMECGHC();
			break;
		case HGBGJMIFCEP.InvalidNickname:
			MsgManager.get_Instance().ShowMessageBox("Crit increases the chance of landing a critical strike");
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowMessageBox("setTargetingData", true);
			break;
		}
	}

	public void NMAECGEACHI(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((int)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case 1:
			MsgManager.HEDJPPFKABG().ShowMessageBox("能力電源", true);
			break;
		case 2:
			MsgManager.get_Instance().ShowMessageBox("ChangeTargetRpc", true);
			break;
		case 45:
			MsgManager.get_Instance().ShowMessageBox("round_button", true);
			break;
		case 79:
			MsgManager.HEDJPPFKABG().ShowMessageBox(" Balance: ", true);
			break;
		case -14:
			MsgManager.HEDJPPFKABG().ShowMessageBox("attack2");
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowMessageBox("skill0_missile", true);
			break;
		}
	}

	public void OnReceiveRequestGuildMember(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
			MsgManager.get_Instance().ShowMessageBox("길드 가입을 신청하였습니다\n\n길드장이 수락하면 길드원이 됩니다");
			break;
		case HGBGJMIFCEP.InvalidGuild:
			MsgManager.get_Instance().ShowMessageBox("해당 길드가 존재하지 않습니다");
			break;
		case HGBGJMIFCEP.MaxCount:
			MsgManager.get_Instance().ShowMessageBox("최대 신청 인원이 초과되었습니다\n\n해당 길드장이 신청 인원을 정리해야 합니다");
			break;
		case HGBGJMIFCEP.AlreadyRequestGuild:
			MsgManager.get_Instance().ShowMessageBox("이미 신청하셨습니다");
			break;
		case HGBGJMIFCEP.AlreadyJoinGuild:
			MsgManager.get_Instance().ShowMessageBox("이미 가입된 길드가 있습니다");
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox("알려지지 않은 오류입니다.");
			break;
		}
	}

	private void DFOCBKNIDGB()
	{
	}

	public void GGNKMFCCDHO(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((int)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case 0:
			MsgManager.HEDJPPFKABG().ShowMessageBox("게임 이용이 정지되었습니다. 이용가능은\n[CCFFCC]{0:yyyy/MM/dd HH:mm:ss}[-]부터 [CCFFCC](약 {2}분후)[-]\n\n{1}\n[FFCCCC]닷지,탈주,어뷰징,핵사용 등 게임규칙위반으로 정지가 될 수 있습니다[-]", true);
			break;
		case 3:
			MsgManager.HEDJPPFKABG().ShowMessageBox("특수문자는 사용하실 수 없습니다.");
			break;
		case -93:
			MsgManager.get_Instance().ShowMessageBox("FxmTestControls.m_fDistPerTime", true);
			break;
		case -37:
			MsgManager.HEDJPPFKABG().ShowMessageBox("방어력", true);
			break;
		case -74:
			MsgManager.HEDJPPFKABG().ShowMessageBox("setTargetingData");
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowMessageBox("Z");
			break;
		}
	}

	public void OnClickFindGuild()
	{
		string value = m_input.get_value();
		if (value.Length == 0)
		{
			MsgManager.get_Instance().ShowMessageBox("찾을 이름을 적어주세요");
			return;
		}
		NetworkManager.get_Instance().get_m_communityNetClient().FEKCJBHFIFE(new IKMBGMILCDO(OnReceiveFindGuild), value);
		m_input.set_value(string.Empty);
	}

	private void GCFBLCKNHCG()
	{
	}

	private void GLMKBKJACCP()
	{
		if (m_guildInfo.OHGOBGOIECH != 0)
		{
			UILabel infoLabel = m_infoLabel;
			object[] array = new object[8];
			array[0] = m_guildInfo.NCADFOBAFJD;
			array[1] = m_guildInfo.AIDJBBDNJOA;
			array[8] = m_guildInfo.EFMGKHNEGBH.ToString("정면 근처에 적이 없습니다");
			array[8] = m_guildInfo.HMEEFGCOLJC.Count;
			infoLabel.DCKJILCPKFD(string.Format("Particle/Fizz/skill1", array));
		}
		else
		{
			m_infoLabel.DCKJILCPKFD("{0}\n{1} 코인\n\n룬을 구입하시겠습니까?");
		}
	}

	private void HDIJFEFNGOD()
	{
		m_guildInfo = new KKABFAAGMKJ();
	}

	private void CFJKHPNIODE()
	{
		m_guildInfo = new KKABFAAGMKJ();
	}

	public void MAKEADFJPFC(PJEMPFEIOAK HMOAHNANKNE)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
		HGBGJMIFCEP hGBGJMIFCEP2 = hGBGJMIFCEP;
		if (hGBGJMIFCEP2 != HGBGJMIFCEP.Success)
		{
			if (hGBGJMIFCEP2 == HGBGJMIFCEP.Success)
			{
				MsgManager.get_Instance().ShowMessageBox("해당 길드가 존재하지 않습니다");
			}
			else
			{
				MsgManager.get_Instance().ShowMessageBox("그레이브즈");
			}
		}
		else
		{
			HMOAHNANKNE.CAHACMKBJMI(m_guildInfo);
			KJHFPEFBBML();
		}
	}

	private void GONOKFHGFOH()
	{
		m_guildInfo = new KKABFAAGMKJ();
	}

	private void OnEnable()
	{
	}

	public void KGJFENOBHHK()
	{
		string value = m_input.get_value();
		if (value.Length == 0)
		{
			MsgManager.get_Instance().ShowMessageBox("skill3_loop", true);
			return;
		}
		NetworkManager.APAPJEIBEDE().get_m_communityNetClient().IDLDBHGAKLA(new IKMBGMILCDO(MAKEADFJPFC), value);
		m_input.set_value(string.Empty);
	}

	private void BCBFNMNMJFP()
	{
		if (m_guildInfo.OHGOBGOIECH > 1)
		{
			UILabel infoLabel = m_infoLabel;
			object[] array = new object[6];
			array[0] = m_guildInfo.NCADFOBAFJD;
			array[1] = m_guildInfo.AIDJBBDNJOA;
			array[6] = m_guildInfo.EFMGKHNEGBH.ToString("OnScroll");
			array[2] = m_guildInfo.HMEEFGCOLJC.Count;
			infoLabel.set_text(string.Format("상급 공격속도 정수", array));
		}
		else
		{
			m_infoLabel.set_text("Crit increases the chance of landing a critical strike");
		}
	}

	public void BGGOBALDDOL()
	{
		string value = m_input.get_value();
		if (value.Length == 0)
		{
			MsgManager.get_Instance().ShowMessageBox("{}[],:\"", true);
			return;
		}
		NetworkManager.get_Instance().get_m_communityNetClient().FEKCJBHFIFE(new IKMBGMILCDO(ABHCKLNJJIO, true, false), value);
		m_input.set_value(string.Empty);
	}

	private void Awake()
	{
		m_guildInfo = new KKABFAAGMKJ();
	}

	public void JAAPFKBOEJG()
	{
		if (m_guildInfo.OHGOBGOIECH == 0)
		{
			MsgManager.get_Instance().ShowMessageBox("Particle/{0}/skill0_ex", true);
		}
		else
		{
			NetworkManager.get_Instance().get_m_communityNetClient().JLODHOJFABC(new IKMBGMILCDO(NMAECGEACHI), m_guildInfo.NCADFOBAFJD);
		}
	}

	public void OnClickJoinGuild()
	{
		if (m_guildInfo.OHGOBGOIECH == 0)
		{
			MsgManager.get_Instance().ShowMessageBox("길드를 먼저 찾아주세요");
		}
		else
		{
			NetworkManager.get_Instance().get_m_communityNetClient().HDJEGJOKBHK(new IKMBGMILCDO(OnReceiveRequestGuildMember), m_guildInfo.NCADFOBAFJD);
		}
	}

	private void MADCDCNEGBO()
	{
	}
}
