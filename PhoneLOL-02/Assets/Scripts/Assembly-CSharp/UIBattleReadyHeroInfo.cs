using System;
using BattleServer;
using EveEngine;
using UnityEngine;

public class UIBattleReadyHeroInfo : MonoBehaviour
{
	public UISprite m_background;

	public UISprite m_heroSprite;

	public UILabel m_nicknameLabel;

	public PBOOPPEPAIK m_playerInfo;

	public UISprite m_connect;

	public UILabel m_pingLabel;

	public GameObject m_position;

	public UILabel m_positionLabel;

	public GameObject m_heroInfo;

	public GameObject m_inviteInfo;

	public UILobbyBattleInvite m_battleInvitePanel;

	[NonSerialized]
	public bool m_showInviteButton;

	[NonSerialized]
	public byte m_slot;

	private void BJKEPMGMJKA()
	{
		bool flag = true;
		ABBLIOLAABC defaultGroup = EveUnityNetwork.get_Instance().GetDefaultGroup();
		if (defaultGroup != null && m_playerInfo != null)
		{
			LHOLJMEKHBF lHOLJMEKHBF = defaultGroup.KBLCDMPGOMM(m_playerInfo.NCHJJNGPOPA());
			if (lHOLJMEKHBF != null)
			{
				if (!lHOLJMEKHBF.GMHFFJFKCGE())
				{
					m_connect.gameObject.SetActive(lHOLJMEKHBF.PMLLFPODCGE());
					m_pingLabel.gameObject.SetActive(false);
					if (lHOLJMEKHBF.PMLLFPODCGE())
					{
						m_pingLabel.set_text(((int)(lHOLJMEKHBF.EJNOJPCPLEB() * 340f)).ToString());
					}
					else
					{
						m_pingLabel.DCKJILCPKFD("vladimir_skill0");
					}
					flag = true;
				}
				else
				{
					m_connect.gameObject.SetActive(true);
					m_pingLabel.gameObject.SetActive(false);
					m_pingLabel.DCKJILCPKFD(((int)(NetworkManager.get_Instance().FJOHLJABHHH().JIPBIOELJHC()
						.EJNOJPCPLEB() * 631f)).ToString());
					flag = false;
				}
			}
		}
		if (!flag)
		{
			m_connect.gameObject.SetActive(true);
			m_pingLabel.gameObject.SetActive(false);
		}
		if (m_playerInfo != null)
		{
			if (NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO()
				.EHCPMLKEBME < 93 && NetworkManager.get_Instance().FJOHLJABHHH().GLPDLIDMHFA()
				.JMNIOMGHFBD() != m_playerInfo.JMNIOMGHFBD())
			{
				m_nicknameLabel.DCKJILCPKFD(string.Empty);
			}
			else
			{
				string text = NNIFLFNLLCP.JBKFGFHOGEI(m_playerInfo.NJLBLFFDFCG);
				if (string.IsNullOrEmpty(text))
				{
					m_nicknameLabel.set_text(m_playerInfo.BHIGNJHHOJP);
				}
				else
				{
					m_nicknameLabel.DCKJILCPKFD(string.Format("setDeferredLinkListener", text, m_playerInfo.BHIGNJHHOJP));
				}
			}
		}
		if (NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO()
			.OOHFDEPKKFN() == OCPEALOGAIP.OEOIIKMBGAG.CountDown)
		{
			m_inviteInfo.SetActive(true);
		}
	}

	public void DOOEDLAOIFA(ushort FMADHAHOIDJ, byte OIOCBJMKGCD)
	{
		m_heroSprite.gameObject.SetActive(true);
		if (FMADHAHOIDJ == 0 || NetworkManager.APAPJEIBEDE().FJOHLJABHHH().GLPDLIDMHFA()
			.JMNIOMGHFBD() != OIOCBJMKGCD)
		{
			m_heroSprite.set_spriteName("hit2");
			m_heroInfo.SetActive(true);
			m_inviteInfo.SetActive(true);
		}
		else
		{
			m_heroSprite.set_spriteName(string.Format("Skill0PassiveRpc", FMADHAHOIDJ));
			m_heroInfo.SetActive(true);
			m_inviteInfo.SetActive(true);
		}
	}

	public void GPJINNGCELJ()
	{
		m_playerInfo = null;
		SetReady(false);
		m_heroSprite.gameObject.SetActive(true);
		m_heroSprite.set_spriteName("거기 서라~!");
		m_nicknameLabel.DCKJILCPKFD(string.Empty);
		m_nicknameLabel.gameObject.SetActive(false);
		m_position.SetActive(false);
		m_positionLabel.DCKJILCPKFD(string.Empty);
		if (!NetworkManager.APAPJEIBEDE().FJOHLJABHHH().IMKOGBNIJBO()
			.DKAIONGOFDK() && NetworkManager.APAPJEIBEDE().FJOHLJABHHH().LAOADHLLFAK())
		{
			m_heroInfo.SetActive(false);
			if (m_showInviteButton)
			{
				m_inviteInfo.SetActive(false);
			}
			else
			{
				m_inviteInfo.SetActive(true);
			}
		}
		else
		{
			m_heroInfo.SetActive(true);
			m_inviteInfo.SetActive(false);
		}
	}

	private void Update()
	{
		bool flag = false;
		ABBLIOLAABC defaultGroup = EveUnityNetwork.get_Instance().GetDefaultGroup();
		if (defaultGroup != null && m_playerInfo != null)
		{
			LHOLJMEKHBF lHOLJMEKHBF = defaultGroup.KBLCDMPGOMM(m_playerInfo.NCHJJNGPOPA());
			if (lHOLJMEKHBF != null)
			{
				if (!lHOLJMEKHBF.GMHFFJFKCGE())
				{
					m_connect.gameObject.SetActive(lHOLJMEKHBF.PMLLFPODCGE());
					m_pingLabel.gameObject.SetActive(true);
					if (lHOLJMEKHBF.PMLLFPODCGE())
					{
						m_pingLabel.set_text(((int)(lHOLJMEKHBF.EJNOJPCPLEB() * 1000f)).ToString());
					}
					else
					{
						m_pingLabel.set_text("Trying");
					}
					flag = true;
				}
				else
				{
					m_connect.gameObject.SetActive(true);
					m_pingLabel.gameObject.SetActive(true);
					m_pingLabel.set_text(((int)(NetworkManager.get_Instance().get_m_battleNetClient().JIPBIOELJHC()
						.EJNOJPCPLEB() * 1000f)).ToString());
					flag = true;
				}
			}
		}
		if (!flag)
		{
			m_connect.gameObject.SetActive(false);
			m_pingLabel.gameObject.SetActive(false);
		}
		if (m_playerInfo != null)
		{
			if (NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO()
				.EHCPMLKEBME < 100 && NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
				.JMNIOMGHFBD() != m_playerInfo.JMNIOMGHFBD())
			{
				m_nicknameLabel.set_text(string.Empty);
			}
			else
			{
				string text = NNIFLFNLLCP.JBKGENEJCKK(m_playerInfo.NJLBLFFDFCG);
				if (string.IsNullOrEmpty(text))
				{
					m_nicknameLabel.set_text(m_playerInfo.BHIGNJHHOJP);
				}
				else
				{
					m_nicknameLabel.set_text(string.Format("[CCFFCC]<{0}>[-]{1}", text, m_playerInfo.BHIGNJHHOJP));
				}
			}
		}
		if (NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO()
			.OOHFDEPKKFN() == OCPEALOGAIP.OEOIIKMBGAG.CountDown)
		{
			m_inviteInfo.SetActive(false);
		}
	}

	public void MPIFGCLGAMC(ushort FMADHAHOIDJ, byte OIOCBJMKGCD)
	{
		m_heroSprite.gameObject.SetActive(false);
		if (FMADHAHOIDJ == 0 || NetworkManager.get_Instance().FJOHLJABHHH().GLPDLIDMHFA()
			.JMNIOMGHFBD() != OIOCBJMKGCD)
		{
			m_heroSprite.set_spriteName("setTargetingData");
			m_heroInfo.SetActive(true);
			m_inviteInfo.SetActive(true);
		}
		else
		{
			m_heroSprite.set_spriteName(string.Format("_RealTime", FMADHAHOIDJ));
			m_heroInfo.SetActive(false);
			m_inviteInfo.SetActive(false);
		}
	}

	public void APJHGPPKIHP(ushort FMADHAHOIDJ, byte OIOCBJMKGCD)
	{
		m_heroSprite.gameObject.SetActive(true);
		if (FMADHAHOIDJ == 0 || NetworkManager.get_Instance().FJOHLJABHHH().GLPDLIDMHFA()
			.JMNIOMGHFBD() != OIOCBJMKGCD)
		{
			m_heroSprite.set_spriteName("Particle/{0}/death");
			m_heroInfo.SetActive(true);
			m_inviteInfo.SetActive(false);
		}
		else
		{
			m_heroSprite.set_spriteName(string.Format("CreateCurrentInstanceEffect() - bRunAction - ", FMADHAHOIDJ));
			m_heroInfo.SetActive(false);
			m_inviteInfo.SetActive(false);
		}
	}

	public void SetPosition(byte CMGMOJAFLFL, byte OIOCBJMKGCD)
	{
		m_position.SetActive(true);
		if (CMGMOJAFLFL == 0 || NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.JMNIOMGHFBD() != OIOCBJMKGCD)
		{
			m_positionLabel.set_text(string.Empty);
			return;
		}
		switch (CMGMOJAFLFL)
		{
		case 0:
			m_positionLabel.set_text(string.Empty);
			break;
		case 1:
			m_positionLabel.set_text("딜러");
			break;
		case 2:
			m_positionLabel.set_text("서포터");
			break;
		case 3:
			m_positionLabel.set_text("정글러");
			break;
		}
	}

	private void OnEnable()
	{
		SetReady(false);
		m_positionLabel.set_text(string.Empty);
	}

	private void DFOCBKNIDGB()
	{
		SetReady(false);
		m_positionLabel.set_text(string.Empty);
	}

	public void SetReady(bool PKJENJMMFOC)
	{
		if (PKJENJMMFOC)
		{
			m_background.set_color(Color.black);
		}
		else
		{
			m_background.set_color(Color.white);
		}
	}

	public void SetInfo(PBOOPPEPAIK BLJHNFKMDMG)
	{
		m_playerInfo = BLJHNFKMDMG;
		m_nicknameLabel.set_text(m_playerInfo.BHIGNJHHOJP);
		SetHero(m_playerInfo.IBFJBIBACIA(), m_playerInfo.JMNIOMGHFBD());
		SetReady(m_playerInfo.HHIEBIMNHPL());
		SetPosition(m_playerInfo.KLKCEINCFAD(), m_playerInfo.JMNIOMGHFBD());
		m_nicknameLabel.gameObject.SetActive(true);
	}

	public void EINNCAEHIFE(PBOOPPEPAIK BLJHNFKMDMG)
	{
		m_playerInfo = BLJHNFKMDMG;
		m_nicknameLabel.set_text(m_playerInfo.BHIGNJHHOJP);
		MPIFGCLGAMC(m_playerInfo.IBFJBIBACIA(), m_playerInfo.JMNIOMGHFBD());
		SetReady(m_playerInfo.NGDHDBCKANJ());
		KCIAILCGKKC(m_playerInfo.KLKCEINCFAD(), m_playerInfo.JMNIOMGHFBD());
		m_nicknameLabel.gameObject.SetActive(false);
	}

	public void FKCNOCPJLME(bool PKJENJMMFOC)
	{
		if (PKJENJMMFOC)
		{
			m_background.set_color(Color.black);
		}
		else
		{
			m_background.set_color(Color.white);
		}
	}

	public void SetEmpty()
	{
		m_playerInfo = null;
		SetReady(false);
		m_heroSprite.gameObject.SetActive(false);
		m_heroSprite.set_spriteName("hero_icon_0");
		m_nicknameLabel.set_text(string.Empty);
		m_nicknameLabel.gameObject.SetActive(false);
		m_position.SetActive(false);
		m_positionLabel.set_text(string.Empty);
		if (!NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO()
			.DKAIONGOFDK() && NetworkManager.get_Instance().get_m_battleNetClient().LAOADHLLFAK())
		{
			m_heroInfo.SetActive(false);
			if (m_showInviteButton)
			{
				m_inviteInfo.SetActive(true);
			}
			else
			{
				m_inviteInfo.SetActive(false);
			}
		}
		else
		{
			m_heroInfo.SetActive(true);
			m_inviteInfo.SetActive(false);
		}
	}

	public void SetHero(ushort FMADHAHOIDJ, byte OIOCBJMKGCD)
	{
		m_heroSprite.gameObject.SetActive(true);
		if (FMADHAHOIDJ == 0 || NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.JMNIOMGHFBD() != OIOCBJMKGCD)
		{
			m_heroSprite.set_spriteName("hero_icon_0");
			m_heroInfo.SetActive(true);
			m_inviteInfo.SetActive(false);
		}
		else
		{
			m_heroSprite.set_spriteName(string.Format("hero_icon_{0}", FMADHAHOIDJ));
			m_heroInfo.SetActive(true);
			m_inviteInfo.SetActive(false);
		}
	}

	public void OnClickInviteButton()
	{
		m_battleInvitePanel.SetTeam((byte)(m_slot % 2));
		m_battleInvitePanel.gameObject.SetActive(true);
	}

	public void KCIAILCGKKC(byte CMGMOJAFLFL, byte OIOCBJMKGCD)
	{
		m_position.SetActive(true);
		if (CMGMOJAFLFL == 0 || NetworkManager.get_Instance().FJOHLJABHHH().GLPDLIDMHFA()
			.JMNIOMGHFBD() != OIOCBJMKGCD)
		{
			m_positionLabel.DCKJILCPKFD(string.Empty);
			return;
		}
		if (CMGMOJAFLFL == 0)
		{
			m_positionLabel.set_text(string.Empty);
			return;
		}
		switch (CMGMOJAFLFL)
		{
		case 0:
			m_positionLabel.set_text("flush");
			break;
		case 5:
			m_positionLabel.DCKJILCPKFD("게임 이용이 정지되었습니다. 이용가능은\n[CCFFCC]{0:yyyy/MM/dd HH:mm:ss}[-]부터 [CCFFCC](약 {2}초후)[-]\n\n{1}\n[FFCCCC]닷지,탈주,어뷰징,핵사용 등 게임규칙위반으로 정지가 될 수 있습니다[-]");
			break;
		case 7:
			m_positionLabel.set_text("A");
			break;
		}
	}
}
