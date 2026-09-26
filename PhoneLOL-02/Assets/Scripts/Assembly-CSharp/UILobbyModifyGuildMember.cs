using CommunityServer;
using EveEngine;
using UnityEngine;

public class UILobbyModifyGuildMember : MonoBehaviour
{
	public UILabel m_nicknameLabel;

	private FCKLFFEFEFH HKPBNEHJBMM;

	public void GMDKOKNGLAK(FCKLFFEFEFH FHPFBPNCGOC)
	{
		HKPBNEHJBMM = FHPFBPNCGOC;
	}

	public void OnClickRemoveMember()
	{
		NetworkManager.get_Instance().get_m_communityNetClient().HNAEKAEKPEH(new IKMBGMILCDO(OnReceiveRemoveGuildMember), HKPBNEHJBMM.OHGOBGOIECH);
	}

	public void CJALGACAGBN(FCKLFFEFEFH FHPFBPNCGOC)
	{
		HKPBNEHJBMM = FHPFBPNCGOC;
	}

	public void DMHPGOEFPLB()
	{
		NetworkManager.APAPJEIBEDE().get_m_communityNetClient().JAMKBPILJAH(new IKMBGMILCDO(OnReceiveSetGuildMaster, false), HKPBNEHJBMM.OHGOBGOIECH);
	}

	public void NKLJFNEOKBE(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((int)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case 0:
		{
			uint iMMMKMLMELB = HMOAHNANKNE.BMKOKHGAHEC();
			string aIDJBBDNJOA = HMOAHNANKNE.AFPCLLNMGJP();
			NetworkManager.APAPJEIBEDE().FGAGFCDEKCC().EHDEFAIBNCN()
				.IMMMKMLMELB = iMMMKMLMELB;
			NetworkManager.APAPJEIBEDE().ALOBHBHLDKK().EHDEFAIBNCN()
				.AIDJBBDNJOA = aIDJBBDNJOA;
			base.gameObject.SetActive(false);
			MsgManager.HEDJPPFKABG().ShowMessageBox("Attack Damage");
			break;
		}
		case -49:
			MsgManager.get_Instance().ShowMessageBox("invalid udp packet", true);
			break;
		case 49:
			MsgManager.HEDJPPFKABG().ShowMessageBox("골드가 부족합니다.", true);
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox("OnReceiveGuildChat");
			break;
		}
	}

	public void EINNCAEHIFE(FCKLFFEFEFH FHPFBPNCGOC)
	{
		HKPBNEHJBMM = FHPFBPNCGOC;
	}

	private void OnEnable()
	{
		m_nicknameLabel.set_text(HKPBNEHJBMM.BHIGNJHHOJP);
	}

	public void IEPMMBBMGCJ(FCKLFFEFEFH FHPFBPNCGOC)
	{
		HKPBNEHJBMM = FHPFBPNCGOC;
	}

	public void OnClickGuildMaster()
	{
		NetworkManager.get_Instance().get_m_communityNetClient().JAMKBPILJAH(new IKMBGMILCDO(OnReceiveSetGuildMaster), HKPBNEHJBMM.OHGOBGOIECH);
	}

	public void EKFLKEINFMP(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			uint num = HMOAHNANKNE.BMKOKHGAHEC();
			if (num == NetworkManager.get_Instance().FGAGFCDEKCC().GLPDLIDMHFA()
				.OHGOBGOIECH)
			{
				NetworkManager.APAPJEIBEDE().get_m_communityNetClient().EHDEFAIBNCN()
					.IENDFDIGHDE();
			}
			else
			{
				NetworkManager.APAPJEIBEDE().FGAGFCDEKCC().EHDEFAIBNCN()
					.EALFAPANOOL(num);
			}
			base.gameObject.SetActive(false);
			MsgManager.get_Instance().ShowMessageBox("skill3_voice");
			break;
		}
		case HGBGJMIFCEP.NotEnoughFood:
			MsgManager.get_Instance().ShowMessageBox("AP.Unity : OnCompleteMessage : ");
			break;
		case HGBGJMIFCEP.NotEnoughSkillPoint:
			MsgManager.get_Instance().ShowMessageBox("sivir_passive", true);
			break;
		case HGBGJMIFCEP.NotEnoughHeart:
			MsgManager.HEDJPPFKABG().ShowMessageBox("Y axis speed : ", true);
			break;
		}
	}

	public void CMGANEHBOHE()
	{
		NetworkManager.APAPJEIBEDE().FGAGFCDEKCC().JAMKBPILJAH(new IKMBGMILCDO(NKLJFNEOKBE, true, false), HKPBNEHJBMM.OHGOBGOIECH);
	}

	public void SetInfo(FCKLFFEFEFH FHPFBPNCGOC)
	{
		HKPBNEHJBMM = FHPFBPNCGOC;
	}

	public void OnReceiveSetGuildMaster(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			uint iMMMKMLMELB = HMOAHNANKNE.BMKOKHGAHEC();
			string aIDJBBDNJOA = HMOAHNANKNE.AFPCLLNMGJP();
			NetworkManager.get_Instance().get_m_communityNetClient().EHDEFAIBNCN()
				.IMMMKMLMELB = iMMMKMLMELB;
			NetworkManager.get_Instance().get_m_communityNetClient().EHDEFAIBNCN()
				.AIDJBBDNJOA = aIDJBBDNJOA;
			base.gameObject.SetActive(false);
			MsgManager.get_Instance().ShowMessageBox("길드장 위임에 성공하였습니다");
			break;
		}
		case HGBGJMIFCEP.CantGuildMaster:
			MsgManager.get_Instance().ShowMessageBox("길드장은 변경할 수 없습니다");
			break;
		case HGBGJMIFCEP.NoPermission:
			MsgManager.get_Instance().ShowMessageBox("권한이 없습니다");
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox("실패하였습니다");
			break;
		}
	}

	public void OnReceiveRemoveGuildMember(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			uint num = HMOAHNANKNE.BMKOKHGAHEC();
			if (num == NetworkManager.get_Instance().get_m_communityNetClient().GLPDLIDMHFA()
				.OHGOBGOIECH)
			{
				NetworkManager.get_Instance().get_m_communityNetClient().EHDEFAIBNCN()
					.PDCPMDCOLOD();
			}
			else
			{
				NetworkManager.get_Instance().get_m_communityNetClient().EHDEFAIBNCN()
					.NPPFHGDHFOO(num);
			}
			base.gameObject.SetActive(false);
			MsgManager.get_Instance().ShowMessageBox("탈퇴에 성공하였습니다");
			break;
		}
		case HGBGJMIFCEP.CantGuildMaster:
			MsgManager.get_Instance().ShowMessageBox("길드장은 탈퇴할 수 없습니다\n\n타인에게 길드장을 위임 후 탈퇴해주세요");
			break;
		case HGBGJMIFCEP.CantRemoveGuildOnlyOne:
			MsgManager.get_Instance().ShowMessageBox("길드원이 한명뿐이어서 탈퇴할 수 없습니다");
			break;
		case HGBGJMIFCEP.NoPermission:
			MsgManager.get_Instance().ShowMessageBox("권한이 없습니다");
			break;
		}
	}

	public void OnClickExit()
	{
		base.gameObject.SetActive(false);
	}

	private void ADLKMGPNJPA()
	{
		m_nicknameLabel.set_text(HKPBNEHJBMM.BHIGNJHHOJP);
	}

	public void NOFJHIJIFID(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((int)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case 1:
		{
			uint iMMMKMLMELB = HMOAHNANKNE.BMKOKHGAHEC();
			string aIDJBBDNJOA = HMOAHNANKNE.AFPCLLNMGJP();
			NetworkManager.APAPJEIBEDE().get_m_communityNetClient().EHDEFAIBNCN()
				.IMMMKMLMELB = iMMMKMLMELB;
			NetworkManager.APAPJEIBEDE().get_m_communityNetClient().EHDEFAIBNCN()
				.AIDJBBDNJOA = aIDJBBDNJOA;
			base.gameObject.SetActive(true);
			MsgManager.get_Instance().ShowMessageBox("드래곤");
			break;
		}
		case -106:
			MsgManager.get_Instance().ShowMessageBox("256");
			break;
		case 104:
			MsgManager.get_Instance().ShowMessageBox("igaworks:purchaseBulk >> total result is");
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox("current_version", true);
			break;
		}
	}
}
