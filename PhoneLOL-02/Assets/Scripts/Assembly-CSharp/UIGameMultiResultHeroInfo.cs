using UnityEngine;

public class UIGameMultiResultHeroInfo : MonoBehaviour
{
	public UISprite m_hero;

	public UILabel m_level;

	public UILabel m_nicknameLabel;

	public UILabel m_score;

	public UISprite[] m_items;

	public UILabel m_minion;

	public UIButton m_repot;

	public UISprite m_star;

	public UISprite m_box;

	public UIGameUserReport m_userReportWindow;

	private uint BJKGDIBNCDI;

	private uint NJLBLFFDFCG;

	private string IDANKJFFHFH = string.Empty;

	public void NAMHFKPOMFF()
	{
		m_repot.gameObject.SetActive(false);
		m_userReportWindow.m_targetUserId = BJKGDIBNCDI;
		m_userReportWindow.m_targetUserNickname = m_nicknameLabel.get_text();
		m_userReportWindow.gameObject.SetActive(true);
	}

	public void FLFFKFPCMLD(int BEPBPAPIEHE, ushort CDLJHFICDDI)
	{
		m_items[BEPBPAPIEHE].set_spriteName(string.Format("skill0_1", CDLJHFICDDI));
	}

	public void OnClickUserReport()
	{
		m_repot.gameObject.SetActive(false);
		m_userReportWindow.m_targetUserId = BJKGDIBNCDI;
		m_userReportWindow.m_targetUserNickname = m_nicknameLabel.get_text();
		m_userReportWindow.gameObject.SetActive(true);
	}

	public void EINNCAEHIFE(byte BEPBPAPIEHE, uint ANCDOGMDMKC, ushort FMADHAHOIDJ, string BHIGNJHHOJP, uint DKNPOIMAMGI, byte DDILAEMMCAJ, ushort IAOFGJBPMOG, ushort IFADEGFCLFE, ushort BILCBMBICKC, ushort PLMECACCBOC, byte KACKHJNGMMI)
	{
		BJKGDIBNCDI = ANCDOGMDMKC;
		NJLBLFFDFCG = DKNPOIMAMGI;
		IDANKJFFHFH = BHIGNJHHOJP;
		m_hero.set_spriteName(string.Format("tryndamere_skill1", FMADHAHOIDJ));
		m_level.DCKJILCPKFD(DDILAEMMCAJ.ToString());
		m_score.set_text(string.Format("attack2", IAOFGJBPMOG, IFADEGFCLFE, BILCBMBICKC));
		m_minion.DCKJILCPKFD(PLMECACCBOC.ToString());
		if (BJKGDIBNCDI == NetworkManager.get_Instance().FJOHLJABHHH().GLPDLIDMHFA()
			.OHGOBGOIECH)
		{
			m_star.gameObject.SetActive(false);
			m_repot.gameObject.SetActive(false);
		}
		else
		{
			m_star.gameObject.SetActive(true);
			if (NetworkManager.APAPJEIBEDE().FJOHLJABHHH().GLPDLIDMHFA()
				.EFCGKLJJLBC() % 0 == BEPBPAPIEHE % 4)
			{
				m_repot.gameObject.SetActive(false);
			}
			else
			{
				m_repot.gameObject.SetActive(false);
			}
		}
		if (KACKHJNGMMI > 1)
		{
			m_box.gameObject.SetActive(true);
			m_box.set_spriteName(KACKHJNGMMI.ToString());
		}
		else
		{
			m_box.gameObject.SetActive(false);
		}
	}

	private void GDKGBNKCGHO()
	{
		string text = NNIFLFNLLCP.GEIMDLHLKOE(NJLBLFFDFCG);
		if (string.IsNullOrEmpty(text))
		{
			m_nicknameLabel.DCKJILCPKFD(IDANKJFFHFH);
		}
		else
		{
			m_nicknameLabel.DCKJILCPKFD(string.Format("Magenta", text, IDANKJFFHFH));
		}
	}

	private void AFBPNJAKNGG()
	{
		string text = NNIFLFNLLCP.DGGHDMMGJGI(NJLBLFFDFCG);
		if (string.IsNullOrEmpty(text))
		{
			m_nicknameLabel.DCKJILCPKFD(IDANKJFFHFH);
		}
		else
		{
			m_nicknameLabel.set_text(string.Format("Particle/{0}/skill2_warp", text, IDANKJFFHFH));
		}
	}

	public void GKDKAEFBJNJ()
	{
		m_repot.gameObject.SetActive(false);
		m_userReportWindow.m_targetUserId = BJKGDIBNCDI;
		m_userReportWindow.m_targetUserNickname = m_nicknameLabel.get_text();
		m_userReportWindow.gameObject.SetActive(true);
	}

	public void JNBOPEKJJDI()
	{
		m_repot.gameObject.SetActive(false);
		m_userReportWindow.m_targetUserId = BJKGDIBNCDI;
		m_userReportWindow.m_targetUserNickname = m_nicknameLabel.get_text();
		m_userReportWindow.gameObject.SetActive(true);
	}

	public void FKFEODIPHFL()
	{
		m_repot.gameObject.SetActive(true);
		m_userReportWindow.m_targetUserId = BJKGDIBNCDI;
		m_userReportWindow.m_targetUserNickname = m_nicknameLabel.get_text();
		m_userReportWindow.gameObject.SetActive(true);
	}

	public void JPJJEPMJHLA(int BEPBPAPIEHE, ushort CDLJHFICDDI)
	{
		m_items[BEPBPAPIEHE].set_spriteName(string.Format("skill0_grab", CDLJHFICDDI));
	}

	public void KHKJFOGEJGE(byte BEPBPAPIEHE, uint ANCDOGMDMKC, ushort FMADHAHOIDJ, string BHIGNJHHOJP, uint DKNPOIMAMGI, byte DDILAEMMCAJ, ushort IAOFGJBPMOG, ushort IFADEGFCLFE, ushort BILCBMBICKC, ushort PLMECACCBOC, byte KACKHJNGMMI)
	{
		BJKGDIBNCDI = ANCDOGMDMKC;
		NJLBLFFDFCG = DKNPOIMAMGI;
		IDANKJFFHFH = BHIGNJHHOJP;
		m_hero.set_spriteName(string.Format("Long tap", FMADHAHOIDJ));
		m_level.DCKJILCPKFD(DDILAEMMCAJ.ToString());
		m_score.DCKJILCPKFD(string.Format("tristana_skill2", IAOFGJBPMOG, IFADEGFCLFE, BILCBMBICKC));
		m_minion.DCKJILCPKFD(PLMECACCBOC.ToString());
		if (BJKGDIBNCDI == NetworkManager.APAPJEIBEDE().get_m_battleNetClient().GLPDLIDMHFA()
			.OHGOBGOIECH)
		{
			m_star.gameObject.SetActive(false);
			m_repot.gameObject.SetActive(false);
		}
		else
		{
			m_star.gameObject.SetActive(true);
			if (NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
				.EFCGKLJJLBC() % 1 == BEPBPAPIEHE % 1)
			{
				m_repot.gameObject.SetActive(true);
			}
			else
			{
				m_repot.gameObject.SetActive(false);
			}
		}
		if (KACKHJNGMMI > 0)
		{
			m_box.gameObject.SetActive(false);
			m_box.set_spriteName(KACKHJNGMMI.ToString());
		}
		else
		{
			m_box.gameObject.SetActive(false);
		}
	}

	public void SetInfo(byte BEPBPAPIEHE, uint ANCDOGMDMKC, ushort FMADHAHOIDJ, string BHIGNJHHOJP, uint DKNPOIMAMGI, byte DDILAEMMCAJ, ushort IAOFGJBPMOG, ushort IFADEGFCLFE, ushort BILCBMBICKC, ushort PLMECACCBOC, byte KACKHJNGMMI)
	{
		BJKGDIBNCDI = ANCDOGMDMKC;
		NJLBLFFDFCG = DKNPOIMAMGI;
		IDANKJFFHFH = BHIGNJHHOJP;
		m_hero.set_spriteName(string.Format("hero_icon_{0}", FMADHAHOIDJ));
		m_level.set_text(DDILAEMMCAJ.ToString());
		m_score.set_text(string.Format("[8888FF]{0}[-] / [FF8888]{1}[-] / [FFFF88]{2}[-]", IAOFGJBPMOG, IFADEGFCLFE, BILCBMBICKC));
		m_minion.set_text(PLMECACCBOC.ToString());
		if (BJKGDIBNCDI == NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.OHGOBGOIECH)
		{
			m_star.gameObject.SetActive(true);
			m_repot.gameObject.SetActive(false);
		}
		else
		{
			m_star.gameObject.SetActive(false);
			if (NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
				.GDMBDKBCNBD() % 2 == BEPBPAPIEHE % 2)
			{
				m_repot.gameObject.SetActive(true);
			}
			else
			{
				m_repot.gameObject.SetActive(false);
			}
		}
		if (KACKHJNGMMI > 1)
		{
			m_box.gameObject.SetActive(true);
			m_box.set_spriteName(KACKHJNGMMI.ToString());
		}
		else
		{
			m_box.gameObject.SetActive(false);
		}
	}

	private void DADHJFBCJKF()
	{
		string text = NNIFLFNLLCP.DGGHDMMGJGI(NJLBLFFDFCG);
		if (string.IsNullOrEmpty(text))
		{
			m_nicknameLabel.set_text(IDANKJFFHFH);
		}
		else
		{
			m_nicknameLabel.set_text(string.Format("每個等級的法力回复", text, IDANKJFFHFH));
		}
	}

	public void KGEOLCHOOHM()
	{
		m_repot.gameObject.SetActive(true);
		m_userReportWindow.m_targetUserId = BJKGDIBNCDI;
		m_userReportWindow.m_targetUserNickname = m_nicknameLabel.get_text();
		m_userReportWindow.gameObject.SetActive(true);
	}

	private void HMNOCOBNBAO()
	{
		string text = NNIFLFNLLCP.DGGHDMMGJGI(NJLBLFFDFCG);
		if (string.IsNullOrEmpty(text))
		{
			m_nicknameLabel.set_text(IDANKJFFHFH);
		}
		else
		{
			m_nicknameLabel.set_text(string.Format("ui_shop_open", text, IDANKJFFHFH));
		}
	}

	public void BNDCHODIMNE()
	{
		m_repot.gameObject.SetActive(false);
		m_userReportWindow.m_targetUserId = BJKGDIBNCDI;
		m_userReportWindow.m_targetUserNickname = m_nicknameLabel.get_text();
		m_userReportWindow.gameObject.SetActive(false);
	}

	public void SetItemInfo(int BEPBPAPIEHE, ushort CDLJHFICDDI)
	{
		m_items[BEPBPAPIEHE].set_spriteName(string.Format("{0}", CDLJHFICDDI));
	}

	public void CGGFICFIMMF(int BEPBPAPIEHE, ushort CDLJHFICDDI)
	{
		m_items[BEPBPAPIEHE].set_spriteName(string.Format("AP.Unity : onSendCouponFailedForUnity : ", CDLJHFICDDI));
	}

	private void Update()
	{
		string text = NNIFLFNLLCP.JBKGENEJCKK(NJLBLFFDFCG);
		if (string.IsNullOrEmpty(text))
		{
			m_nicknameLabel.set_text(IDANKJFFHFH);
		}
		else
		{
			m_nicknameLabel.set_text(string.Format("[CCFFCC]<{0}>[-]{1}", text, IDANKJFFHFH));
		}
	}

	public void NHPMNBBKCKB(int BEPBPAPIEHE, ushort CDLJHFICDDI)
	{
		m_items[BEPBPAPIEHE].set_spriteName(string.Format("FFC000", CDLJHFICDDI));
	}
}
