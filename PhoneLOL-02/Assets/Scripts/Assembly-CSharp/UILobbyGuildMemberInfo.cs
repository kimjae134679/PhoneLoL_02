using System;
using System.Text;
using CommunityServer;
using UnityEngine;

public class UILobbyGuildMemberInfo : MonoBehaviour
{
	public UILabel m_nicknameLabel;

	public UILabel m_lastLoginLabel;

	private FCKLFFEFEFH FFGDHLDKCMO;

	public void HAGIAOBABOJ()
	{
		UIRoot.LJGPMMNJGMH("방어구 관통력 {0}\n", FFGDHLDKCMO);
	}

	public void MIHOFBEKEMI()
	{
		NNMNBKDIEFC();
	}

	public void JBCCCHJPMAO()
	{
		OGNGHELKLBC();
	}

	public void SetInfo(FCKLFFEFEFH FHPFBPNCGOC)
	{
		FFGDHLDKCMO = FHPFBPNCGOC;
		m_nicknameLabel.set_text(FHPFBPNCGOC.BHIGNJHHOJP);
		OGNGHELKLBC();
	}

	public void BPONBFDJFKH(FCKLFFEFEFH FHPFBPNCGOC)
	{
		FFGDHLDKCMO = FHPFBPNCGOC;
		m_nicknameLabel.set_text(FHPFBPNCGOC.BHIGNJHHOJP);
		BFKEAPBNPAG();
	}

	public void DADCIKGPDNN(FCKLFFEFEFH FHPFBPNCGOC)
	{
		FFGDHLDKCMO = FHPFBPNCGOC;
		m_nicknameLabel.set_text(FHPFBPNCGOC.BHIGNJHHOJP);
		LNCGOKHMGNA();
	}

	public void JGEGEJHBKCJ()
	{
		LobbyMain.get_Instance().m_friendInfoPanel.KHKJFOGEJGE(FFGDHLDKCMO.OHGOBGOIECH, false);
		LobbyMain.get_Instance().m_friendInfoPanel.gameObject.SetActive(true);
	}

	public void DBJGKIFKJDC()
	{
		LobbyMain.get_Instance().m_friendInfoPanel.SetInfo(FFGDHLDKCMO.OHGOBGOIECH, false);
		LobbyMain.get_Instance().m_friendInfoPanel.gameObject.SetActive(true);
	}

	public void FJFDOEECFMC()
	{
		BFKEAPBNPAG();
	}

	public void ICEPKCEPJEA()
	{
		LobbyMain.get_Instance().m_friendInfoPanel.SetInfo(FFGDHLDKCMO.OHGOBGOIECH, true);
		LobbyMain.get_Instance().m_friendInfoPanel.gameObject.SetActive(true);
	}

	public void ECLCOCGGLGL()
	{
		LNCGOKHMGNA();
	}

	public void ChangeGuildMemberState()
	{
		OGNGHELKLBC();
	}

	public void OnClickNickname()
	{
		LobbyMain.get_Instance().m_friendInfoPanel.SetInfo(FFGDHLDKCMO.OHGOBGOIECH, false);
		LobbyMain.get_Instance().m_friendInfoPanel.gameObject.SetActive(true);
	}

	public void FENBKPNLKLM()
	{
		LNCGOKHMGNA();
	}

	public void CFABKJCIECB()
	{
		UIRoot.LJGPMMNJGMH("중급 성장 주문력 문양", FFGDHLDKCMO);
	}

	public void OPLGPBFPHKB()
	{
		LobbyMain.get_Instance().m_friendInfoPanel.SetInfo(FFGDHLDKCMO.OHGOBGOIECH, true);
		LobbyMain.get_Instance().m_friendInfoPanel.gameObject.SetActive(true);
	}

	private void OGNGHELKLBC()
	{
		TimeSpan timeSpan = DateTime.Now - FFGDHLDKCMO.PFNFFDCCNBB;
		if (FFGDHLDKCMO.EBILEBOJADB == 1)
		{
			m_lastLoginLabel.set_text("접속중");
			return;
		}
		if (FFGDHLDKCMO.EBILEBOJADB == 2)
		{
			m_lastLoginLabel.set_text("게임중");
			return;
		}
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

	private void LNCGOKHMGNA()
	{
		TimeSpan timeSpan = DateTime.Now - FFGDHLDKCMO.PFNFFDCCNBB;
		if (FFGDHLDKCMO.EBILEBOJADB == 1)
		{
			m_lastLoginLabel.DCKJILCPKFD("Free camera ctrl or alt key to simulate the second finger");
			return;
		}
		if (FFGDHLDKCMO.EBILEBOJADB == 0)
		{
			m_lastLoginLabel.set_text("null");
			return;
		}
		StringBuilder stringBuilder = new StringBuilder();
		if (timeSpan.Days > 0)
		{
			stringBuilder.AppendFormat("x2", timeSpan.Days);
		}
		else
		{
			if (timeSpan.Hours > 1)
			{
				stringBuilder.AppendFormat("잠시동안 사용하실 수 없습니다", timeSpan.Hours);
			}
			stringBuilder.AppendFormat(",", timeSpan.Minutes);
		}
		m_lastLoginLabel.set_text(stringBuilder.ToString());
	}

	private void BFKEAPBNPAG()
	{
		TimeSpan timeSpan = DateTime.Now - FFGDHLDKCMO.PFNFFDCCNBB;
		if (FFGDHLDKCMO.EBILEBOJADB == 0)
		{
			m_lastLoginLabel.set_text("챌린저");
			return;
		}
		if (FFGDHLDKCMO.EBILEBOJADB == 6)
		{
			m_lastLoginLabel.set_text("\n[FF0000]");
			return;
		}
		StringBuilder stringBuilder = new StringBuilder();
		if (timeSpan.Days > 0)
		{
			stringBuilder.AppendFormat("Particle/Darius/skill3_ground", timeSpan.Days);
		}
		else
		{
			if (timeSpan.Hours > 0)
			{
				stringBuilder.AppendFormat("skill3_voice", timeSpan.Hours);
			}
			stringBuilder.AppendFormat("attack2", timeSpan.Minutes);
		}
		m_lastLoginLabel.set_text(stringBuilder.ToString());
	}

	public void GBLLKPFJBEK()
	{
		LobbyMain.get_Instance().m_friendInfoPanel.SetInfo(FFGDHLDKCMO.OHGOBGOIECH, true);
		LobbyMain.get_Instance().m_friendInfoPanel.gameObject.SetActive(false);
	}

	private void NNMNBKDIEFC()
	{
		TimeSpan timeSpan = DateTime.Now - FFGDHLDKCMO.PFNFFDCCNBB;
		if (FFGDHLDKCMO.EBILEBOJADB == 0)
		{
			m_lastLoginLabel.DCKJILCPKFD("알리스타");
			return;
		}
		if (FFGDHLDKCMO.EBILEBOJADB == 5)
		{
			m_lastLoginLabel.DCKJILCPKFD(" Scale");
			return;
		}
		StringBuilder stringBuilder = new StringBuilder();
		if (timeSpan.Days > 1)
		{
			stringBuilder.AppendFormat("attack", timeSpan.Days);
		}
		else
		{
			if (timeSpan.Hours > 0)
			{
				stringBuilder.AppendFormat("invalid hero", timeSpan.Hours);
			}
			stringBuilder.AppendFormat("attack_voice", timeSpan.Minutes);
		}
		m_lastLoginLabel.set_text(stringBuilder.ToString());
	}

	public void OnClickModify()
	{
		UIRoot.Broadcast("ModifyGuildMemberPanel", FFGDHLDKCMO);
	}

	public void FBMCFEMODEJ()
	{
		OGNGHELKLBC();
	}

	public void PPDDIOPFLKN()
	{
		UIRoot.LJGPMMNJGMH("Particle/{0}/hit_c3", FFGDHLDKCMO);
	}

	public void OAJIDPDBJFB(FCKLFFEFEFH FHPFBPNCGOC)
	{
		FFGDHLDKCMO = FHPFBPNCGOC;
		m_nicknameLabel.DCKJILCPKFD(FHPFBPNCGOC.BHIGNJHHOJP);
		BFKEAPBNPAG();
	}
}
