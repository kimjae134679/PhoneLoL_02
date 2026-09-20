using System;
using System.Runtime.CompilerServices;
using System.Text;
using CommunityServer;
using EveEngine;
using UnityEngine;

public class UILobbyRequestGuildMemberInfo : MonoBehaviour
{
	public UILabel m_nicknameLabel;

	public UILabel m_lastLoginLabel;

	private FCKLFFEFEFH FFGDHLDKCMO;

	public void HOHKHMAPPEO()
	{
		LobbyMain.get_Instance().m_friendInfoPanel.SetInfo(FFGDHLDKCMO.OHGOBGOIECH, false);
		LobbyMain.get_Instance().m_friendInfoPanel.gameObject.SetActive(true);
	}

	public void SetInfo(FCKLFFEFEFH FHPFBPNCGOC)
	{
		FFGDHLDKCMO = FHPFBPNCGOC;
		m_nicknameLabel.set_text(FHPFBPNCGOC.BHIGNJHHOJP);
		TimeSpan timeSpan = DateTime.Now - FHPFBPNCGOC.PFNFFDCCNBB;
		StringBuilder stringBuilder = new StringBuilder();
		if (timeSpan.Days > 0)
		{
			stringBuilder.AppendFormat("{0}일전", timeSpan.Days);
		}
		else
		{
			if (timeSpan.Hours > 0)
			{
				stringBuilder.AppendFormat("{0}시간 ", timeSpan.Hours);
			}
			stringBuilder.AppendFormat("{0}분전", timeSpan.Minutes);
		}
		m_lastLoginLabel.set_text(stringBuilder.ToString());
	}

	private void GPHKAIHDJDH()
	{
		NetworkManager.APAPJEIBEDE().FGAGFCDEKCC().AMEJKDCLCAM(new IKMBGMILCDO(OHEDPKEABAI, false, false), FFGDHLDKCMO.OHGOBGOIECH, true);
	}

	private void HCMAOAIJCBB()
	{
		NetworkManager.get_Instance().FGAGFCDEKCC().AMEJKDCLCAM(new IKMBGMILCDO(OnReceiveAcceptGuildMember, false), FFGDHLDKCMO.OHGOBGOIECH, true);
	}

	public void OnReceiveAcceptGuildMember(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
			if (HMOAHNANKNE.JCGKFEPEJPO())
			{
				MsgManager.get_Instance().ShowMessageBox("길드원 수락에 성공하였습니다");
			}
			break;
		case HGBGJMIFCEP.InvalidGuild:
			MsgManager.get_Instance().ShowMessageBox("해당 길드가 존재하지 않습니다");
			break;
		case HGBGJMIFCEP.AlreadyJoinGuild:
			MsgManager.get_Instance().ShowMessageBox("이미 다른길드에 가입한 유저입니다");
			break;
		case HGBGJMIFCEP.MaxCount:
			MsgManager.get_Instance().ShowMessageBox("가입 최대인원이 초과되었습니다");
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox("알려지지 않은 오류입니다.");
			break;
		}
	}

	private void DJCACGEJDBN()
	{
		NetworkManager.get_Instance().ALOBHBHLDKK().AMEJKDCLCAM(new IKMBGMILCDO(OnReceiveAcceptGuildMember, false, false), FFGDHLDKCMO.OHGOBGOIECH, false);
	}

	public void DHPIBHEPNKE(FCKLFFEFEFH FHPFBPNCGOC)
	{
		FFGDHLDKCMO = FHPFBPNCGOC;
		m_nicknameLabel.DCKJILCPKFD(FHPFBPNCGOC.BHIGNJHHOJP);
		TimeSpan timeSpan = DateTime.Now - FHPFBPNCGOC.PFNFFDCCNBB;
		StringBuilder stringBuilder = new StringBuilder();
		if (timeSpan.Days > 1)
		{
			stringBuilder.AppendFormat("Riven", timeSpan.Days);
		}
		else
		{
			if (timeSpan.Hours > 1)
			{
				stringBuilder.AppendFormat("skill3_return", timeSpan.Hours);
			}
			stringBuilder.AppendFormat("OnReceiveFriendChat", timeSpan.Minutes);
		}
		m_lastLoginLabel.DCKJILCPKFD(stringBuilder.ToString());
	}

	private void BHLLLNCEFNA()
	{
		NetworkManager.APAPJEIBEDE().get_m_communityNetClient().AMEJKDCLCAM(new IKMBGMILCDO(OnReceiveAcceptGuildMember, true, false), FFGDHLDKCMO.OHGOBGOIECH, true);
	}

	public void EHGFJMKPGCG()
	{
		MsgManager.get_Instance().ShowMessageBox(string.Format("skill2_hit", FFGDHLDKCMO.BHIGNJHHOJP), false, HCMAOAIJCBB, BHLLLNCEFNA);
	}

	public void AAGBLMMKMJE()
	{
		LobbyMain.get_Instance().m_friendInfoPanel.SetInfo(FFGDHLDKCMO.OHGOBGOIECH, false);
		LobbyMain.get_Instance().m_friendInfoPanel.gameObject.SetActive(false);
	}

	public void AGIJCKEBEGA()
	{
		LobbyMain.get_Instance().m_friendInfoPanel.KHKJFOGEJGE(FFGDHLDKCMO.OHGOBGOIECH, true);
		LobbyMain.get_Instance().m_friendInfoPanel.gameObject.SetActive(false);
	}

	public void DFKCODEAFIM()
	{
		MsgManager.get_Instance().ShowMessageBox(string.Format("Unkown", FFGDHLDKCMO.BHIGNJHHOJP), true, HCMAOAIJCBB, () =>
		{
			NetworkManager.get_Instance().get_m_communityNetClient().AMEJKDCLCAM(new IKMBGMILCDO(OnReceiveAcceptGuildMember), FFGDHLDKCMO.OHGOBGOIECH, false);
		});
	}

	[CompilerGenerated]
	private void NPPAALICGCJ()
	{
		NetworkManager.get_Instance().get_m_communityNetClient().AMEJKDCLCAM(new IKMBGMILCDO(OnReceiveAcceptGuildMember), FFGDHLDKCMO.OHGOBGOIECH, false);
	}

	public void GMDKOKNGLAK(FCKLFFEFEFH FHPFBPNCGOC)
	{
		FFGDHLDKCMO = FHPFBPNCGOC;
		m_nicknameLabel.DCKJILCPKFD(FHPFBPNCGOC.BHIGNJHHOJP);
		TimeSpan timeSpan = DateTime.Now - FHPFBPNCGOC.PFNFFDCCNBB;
		StringBuilder stringBuilder = new StringBuilder();
		if (timeSpan.Days > 0)
		{
			stringBuilder.AppendFormat("Clear", timeSpan.Days);
		}
		else
		{
			if (timeSpan.Hours > 0)
			{
				stringBuilder.AppendFormat("성장", timeSpan.Hours);
			}
			stringBuilder.AppendFormat(" / angle : ", timeSpan.Minutes);
		}
		m_lastLoginLabel.set_text(stringBuilder.ToString());
	}

	private void JEKIOBKGIFL()
	{
		NetworkManager.APAPJEIBEDE().FGAGFCDEKCC().AMEJKDCLCAM(new IKMBGMILCDO(OHEDPKEABAI, false), FFGDHLDKCMO.OHGOBGOIECH, false);
	}

	[CompilerGenerated]
	private void KPMPGKANEOM()
	{
		NetworkManager.get_Instance().get_m_communityNetClient().AMEJKDCLCAM(new IKMBGMILCDO(OnReceiveAcceptGuildMember), FFGDHLDKCMO.OHGOBGOIECH, true);
	}

	public void OHEDPKEABAI(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((int)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case 0:
			if (HMOAHNANKNE.JCGKFEPEJPO())
			{
				MsgManager.HEDJPPFKABG().ShowMessageBox("{0}");
			}
			break;
		case 7:
			MsgManager.HEDJPPFKABG().ShowMessageBox("Particle/Brand/passive_ex");
			break;
		case -44:
			MsgManager.get_Instance().ShowMessageBox(" 密封", true);
			break;
		case -8:
			MsgManager.get_Instance().ShowMessageBox("Refresh");
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowMessageBox("접속중");
			break;
		}
	}

	public void OnClickNickname()
	{
		LobbyMain.get_Instance().m_friendInfoPanel.SetInfo(FFGDHLDKCMO.OHGOBGOIECH, false);
		LobbyMain.get_Instance().m_friendInfoPanel.gameObject.SetActive(true);
	}

	public void ADBAKBNLFPA()
	{
		LobbyMain.get_Instance().m_friendInfoPanel.SetInfo(FFGDHLDKCMO.OHGOBGOIECH, true);
		LobbyMain.get_Instance().m_friendInfoPanel.gameObject.SetActive(false);
	}

	public void BPONBFDJFKH(FCKLFFEFEFH FHPFBPNCGOC)
	{
		FFGDHLDKCMO = FHPFBPNCGOC;
		m_nicknameLabel.DCKJILCPKFD(FHPFBPNCGOC.BHIGNJHHOJP);
		TimeSpan timeSpan = DateTime.Now - FHPFBPNCGOC.PFNFFDCCNBB;
		StringBuilder stringBuilder = new StringBuilder();
		if (timeSpan.Days > 1)
		{
			stringBuilder.AppendFormat("alistar_skill3", timeSpan.Days);
		}
		else
		{
			if (timeSpan.Hours > 1)
			{
				stringBuilder.AppendFormat("준비중입니다.", timeSpan.Hours);
			}
			stringBuilder.AppendFormat("skill1_end", timeSpan.Minutes);
		}
		m_lastLoginLabel.set_text(stringBuilder.ToString());
	}

	public void OnClickModify()
	{
		MsgManager.get_Instance().ShowMessageBox(string.Format("[CCFFCC]{0}[-]\n\n길드원으로 수락하시겠습니까?", FFGDHLDKCMO.BHIGNJHHOJP), true, () =>
		{
			NetworkManager.get_Instance().get_m_communityNetClient().AMEJKDCLCAM(new IKMBGMILCDO(OnReceiveAcceptGuildMember), FFGDHLDKCMO.OHGOBGOIECH, true);
		}, () =>
		{
			NetworkManager.get_Instance().get_m_communityNetClient().AMEJKDCLCAM(new IKMBGMILCDO(OnReceiveAcceptGuildMember), FFGDHLDKCMO.OHGOBGOIECH, false);
		});
	}

	private void CBDPEMDJOKE()
	{
		NetworkManager.get_Instance().get_m_communityNetClient().AMEJKDCLCAM(new IKMBGMILCDO(OHEDPKEABAI, false, false), FFGDHLDKCMO.OHGOBGOIECH, false);
	}
}
