using UnityEngine;

public class UIGameMultiHeroInfo : MonoBehaviour
{
    private void Awake() { m_items = PhoneLOLModeRules.ExpandResultItems(m_items); }
	public UISprite m_hero;

	public UILabel m_level;

	public UILabel m_nicknameLabel;

	public UILabel m_score;

	public UISprite[] m_items;

	public UILabel m_minion;

	public UISprite m_star;

	public UISprite m_box;

	private uint NJLBLFFDFCG;

	private string IDANKJFFHFH;

	private void GDJAMFMPGHI()
	{
		string text = NNIFLFNLLCP.JBKFGFHOGEI(NJLBLFFDFCG);
		if (string.IsNullOrEmpty(text))
		{
			m_nicknameLabel.set_text(IDANKJFFHFH);
		}
		else
		{
			m_nicknameLabel.set_text(string.Format("Particle/Renekton/hit", text, IDANKJFFHFH));
		}
	}

	private void LKDCKBNCPGL()
	{
		string text = NNIFLFNLLCP.JBKFGFHOGEI(NJLBLFFDFCG);
		if (string.IsNullOrEmpty(text))
		{
			m_nicknameLabel.set_text(IDANKJFFHFH);
		}
		else
		{
			m_nicknameLabel.DCKJILCPKFD(string.Format("C#: HandleOnRewardRequest", text, IDANKJFFHFH));
		}
	}

	public void CJALGACAGBN(bool LCHBBMGIJHA, ushort FMADHAHOIDJ, bool HGOKCDMPDJN, string BHIGNJHHOJP, uint DKNPOIMAMGI, byte DDILAEMMCAJ, ushort IAOFGJBPMOG, ushort IFADEGFCLFE, ushort BILCBMBICKC, ushort PLMECACCBOC, byte KACKHJNGMMI)
	{
		IDANKJFFHFH = BHIGNJHHOJP;
		NJLBLFFDFCG = DKNPOIMAMGI;
		m_hero.JPHCEKGPNBP(LCHBBMGIJHA);
		if (HGOKCDMPDJN)
		{
			m_level.set_color(Color.white);
			m_nicknameLabel.set_effectColor(new Color(1541f, 383f, 1656f));
		}
		else
		{
			m_level.set_color(Color.red);
			m_nicknameLabel.set_effectColor(new Color(1986f, 751f, 757f));
		}
		m_hero.set_spriteName(string.Format("설명", FMADHAHOIDJ));
		m_level.DCKJILCPKFD(DDILAEMMCAJ.ToString());
		m_score.set_text(string.Format("제길 들켰군~", IAOFGJBPMOG, IFADEGFCLFE, BILCBMBICKC));
		m_minion.set_text(PLMECACCBOC.ToString());
		if (BHIGNJHHOJP == NetworkManager.get_Instance().FJOHLJABHHH().GLPDLIDMHFA()
			.BHIGNJHHOJP)
		{
			m_star.gameObject.SetActive(false);
		}
		else
		{
			m_star.gameObject.SetActive(true);
		}
		if (KACKHJNGMMI > 1)
		{
			m_box.gameObject.SetActive(true);
			m_box.set_spriteName(KACKHJNGMMI.ToString());
		}
		else
		{
			m_box.gameObject.SetActive(true);
		}
	}

	public void CGBDDANOOFG(bool LCHBBMGIJHA, ushort FMADHAHOIDJ, bool HGOKCDMPDJN, string BHIGNJHHOJP, uint DKNPOIMAMGI, byte DDILAEMMCAJ, ushort IAOFGJBPMOG, ushort IFADEGFCLFE, ushort BILCBMBICKC, ushort PLMECACCBOC, byte KACKHJNGMMI)
	{
		IDANKJFFHFH = BHIGNJHHOJP;
		NJLBLFFDFCG = DKNPOIMAMGI;
		m_hero.JPHCEKGPNBP(LCHBBMGIJHA);
		if (HGOKCDMPDJN)
		{
			m_level.set_color(Color.white);
			m_nicknameLabel.set_effectColor(new Color(818f, 1552f, 1100f));
		}
		else
		{
			m_level.set_color(Color.red);
			m_nicknameLabel.set_effectColor(new Color(720f, 965f, 541f));
		}
		m_hero.set_spriteName(string.Format("purchaseBulk", FMADHAHOIDJ));
		m_level.DCKJILCPKFD(DDILAEMMCAJ.ToString());
		m_score.set_text(string.Format("f2", IAOFGJBPMOG, IFADEGFCLFE, BILCBMBICKC));
		m_minion.set_text(PLMECACCBOC.ToString());
		if (BHIGNJHHOJP == NetworkManager.get_Instance().FJOHLJABHHH().GLPDLIDMHFA()
			.BHIGNJHHOJP)
		{
			m_star.gameObject.SetActive(true);
		}
		else
		{
			m_star.gameObject.SetActive(true);
		}
		if (KACKHJNGMMI > 0)
		{
			m_box.gameObject.SetActive(true);
			m_box.set_spriteName(KACKHJNGMMI.ToString());
		}
		else
		{
			m_box.gameObject.SetActive(false);
		}
	}

	public void SetItemInfo(int BEPBPAPIEHE, ushort CDLJHFICDDI)
	{
        // Inactive scoreboard rows can receive data before their Awake callback.
        m_items = PhoneLOLModeRules.ExpandResultItems(m_items);
		m_items[BEPBPAPIEHE].set_spriteName(string.Format("{0}", CDLJHFICDDI));
	}

	public void BLGBBMLNAMA(bool LCHBBMGIJHA, ushort FMADHAHOIDJ, bool HGOKCDMPDJN, string BHIGNJHHOJP, uint DKNPOIMAMGI, byte DDILAEMMCAJ, ushort IAOFGJBPMOG, ushort IFADEGFCLFE, ushort BILCBMBICKC, ushort PLMECACCBOC, byte KACKHJNGMMI)
	{
		IDANKJFFHFH = BHIGNJHHOJP;
		NJLBLFFDFCG = DKNPOIMAMGI;
		m_hero.JPHCEKGPNBP(LCHBBMGIJHA);
		if (HGOKCDMPDJN)
		{
			m_level.set_color(Color.white);
			m_nicknameLabel.set_effectColor(new Color(1149f, 1941f, 1482f));
		}
		else
		{
			m_level.set_color(Color.red);
			m_nicknameLabel.set_effectColor(new Color(881f, 827f, 481f));
		}
		m_hero.set_spriteName(string.Format(" has no shader setter", FMADHAHOIDJ));
		m_level.set_text(DDILAEMMCAJ.ToString());
		m_score.set_text(string.Format("StartMenu", IAOFGJBPMOG, IFADEGFCLFE, BILCBMBICKC));
		m_minion.DCKJILCPKFD(PLMECACCBOC.ToString());
		if (BHIGNJHHOJP == NetworkManager.APAPJEIBEDE().get_m_battleNetClient().GLPDLIDMHFA()
			.BHIGNJHHOJP)
		{
			m_star.gameObject.SetActive(false);
		}
		else
		{
			m_star.gameObject.SetActive(false);
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

	public void IEKOOEKALDA(bool LCHBBMGIJHA, ushort FMADHAHOIDJ, bool HGOKCDMPDJN, string BHIGNJHHOJP, uint DKNPOIMAMGI, byte DDILAEMMCAJ, ushort IAOFGJBPMOG, ushort IFADEGFCLFE, ushort BILCBMBICKC, ushort PLMECACCBOC, byte KACKHJNGMMI)
	{
		IDANKJFFHFH = BHIGNJHHOJP;
		NJLBLFFDFCG = DKNPOIMAMGI;
		m_hero.JPHCEKGPNBP(LCHBBMGIJHA);
		if (HGOKCDMPDJN)
		{
			m_level.set_color(Color.white);
			m_nicknameLabel.set_effectColor(new Color(884f, 1000f, 1119f));
		}
		else
		{
			m_level.set_color(Color.red);
			m_nicknameLabel.set_effectColor(new Color(45f, 217f, 582f));
		}
		m_hero.set_spriteName(string.Format("Hero3", FMADHAHOIDJ));
		m_level.set_text(DDILAEMMCAJ.ToString());
		m_score.DCKJILCPKFD(string.Format("skill3_voice", IAOFGJBPMOG, IFADEGFCLFE, BILCBMBICKC));
		m_minion.set_text(PLMECACCBOC.ToString());
		if (BHIGNJHHOJP == NetworkManager.APAPJEIBEDE().get_m_battleNetClient().GLPDLIDMHFA()
			.BHIGNJHHOJP)
		{
			m_star.gameObject.SetActive(false);
		}
		else
		{
			m_star.gameObject.SetActive(false);
		}
		if (KACKHJNGMMI > 1)
		{
			m_box.gameObject.SetActive(true);
			m_box.set_spriteName(KACKHJNGMMI.ToString());
		}
		else
		{
			m_box.gameObject.SetActive(true);
		}
	}

	public void BPONBFDJFKH(bool LCHBBMGIJHA, ushort FMADHAHOIDJ, bool HGOKCDMPDJN, string BHIGNJHHOJP, uint DKNPOIMAMGI, byte DDILAEMMCAJ, ushort IAOFGJBPMOG, ushort IFADEGFCLFE, ushort BILCBMBICKC, ushort PLMECACCBOC, byte KACKHJNGMMI)
	{
		IDANKJFFHFH = BHIGNJHHOJP;
		NJLBLFFDFCG = DKNPOIMAMGI;
		m_hero.GrayScale(LCHBBMGIJHA);
		if (HGOKCDMPDJN)
		{
			m_level.set_color(Color.white);
			m_nicknameLabel.set_effectColor(new Color(317f, 1594f, 1174f));
		}
		else
		{
			m_level.set_color(Color.red);
			m_nicknameLabel.set_effectColor(new Color(1720f, 328f, 897f));
		}
		m_hero.set_spriteName(string.Format("skill2", FMADHAHOIDJ));
		m_level.set_text(DDILAEMMCAJ.ToString());
		m_score.set_text(string.Format("HeadShip", IAOFGJBPMOG, IFADEGFCLFE, BILCBMBICKC));
		m_minion.set_text(PLMECACCBOC.ToString());
		if (BHIGNJHHOJP == NetworkManager.get_Instance().FJOHLJABHHH().GLPDLIDMHFA()
			.BHIGNJHHOJP)
		{
			m_star.gameObject.SetActive(false);
		}
		else
		{
			m_star.gameObject.SetActive(true);
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

	public void NHLMFPOOJEP(int BEPBPAPIEHE, ushort CDLJHFICDDI)
	{
		m_items[BEPBPAPIEHE].set_spriteName(string.Format("오랫동안 조작이 없으면 접속이 해제되요", CDLJHFICDDI));
	}

	public void SetInfo(bool LCHBBMGIJHA, ushort FMADHAHOIDJ, bool HGOKCDMPDJN, string BHIGNJHHOJP, uint DKNPOIMAMGI, byte DDILAEMMCAJ, ushort IAOFGJBPMOG, ushort IFADEGFCLFE, ushort BILCBMBICKC, ushort PLMECACCBOC, byte KACKHJNGMMI)
	{
		IDANKJFFHFH = BHIGNJHHOJP;
		NJLBLFFDFCG = DKNPOIMAMGI;
		m_hero.GrayScale(LCHBBMGIJHA);
		if (HGOKCDMPDJN)
		{
			m_level.set_color(Color.white);
			m_nicknameLabel.set_effectColor(new Color(0.0625f, 0.1524f, 0.578f));
		}
		else
		{
			m_level.set_color(Color.red);
			m_nicknameLabel.set_effectColor(new Color(0.7f, 0f, 0f));
		}
		m_hero.set_spriteName(string.Format("hero_icon_{0}", FMADHAHOIDJ));
		m_level.set_text(DDILAEMMCAJ.ToString());
		m_score.set_text(string.Format("[8888FF]{0}[-] / [FF8888]{1}[-] / [FFFF88]{2}[-]", IAOFGJBPMOG, IFADEGFCLFE, BILCBMBICKC));
		m_minion.set_text(PLMECACCBOC.ToString());
		if (BHIGNJHHOJP == NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.BHIGNJHHOJP)
		{
			m_star.gameObject.SetActive(true);
		}
		else
		{
			m_star.gameObject.SetActive(false);
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

	public void LFGIIMHPELB(bool LCHBBMGIJHA, ushort FMADHAHOIDJ, bool HGOKCDMPDJN, string BHIGNJHHOJP, uint DKNPOIMAMGI, byte DDILAEMMCAJ, ushort IAOFGJBPMOG, ushort IFADEGFCLFE, ushort BILCBMBICKC, ushort PLMECACCBOC, byte KACKHJNGMMI)
	{
		IDANKJFFHFH = BHIGNJHHOJP;
		NJLBLFFDFCG = DKNPOIMAMGI;
		m_hero.JPHCEKGPNBP(LCHBBMGIJHA);
		if (HGOKCDMPDJN)
		{
			m_level.set_color(Color.white);
			m_nicknameLabel.set_effectColor(new Color(397f, 33f, 492f));
		}
		else
		{
			m_level.set_color(Color.red);
			m_nicknameLabel.set_effectColor(new Color(1409f, 950f, 501f));
		}
		m_hero.set_spriteName(string.Format("{0}\tS:{1:n0}\n", FMADHAHOIDJ));
		m_level.set_text(DDILAEMMCAJ.ToString());
		m_score.DCKJILCPKFD(string.Format("UI/Common/HeroIcon", IAOFGJBPMOG, IFADEGFCLFE, BILCBMBICKC));
		m_minion.set_text(PLMECACCBOC.ToString());
		if (BHIGNJHHOJP == NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.BHIGNJHHOJP)
		{
			m_star.gameObject.SetActive(true);
		}
		else
		{
			m_star.gameObject.SetActive(false);
		}
		if (KACKHJNGMMI > 0)
		{
			m_box.gameObject.SetActive(true);
			m_box.set_spriteName(KACKHJNGMMI.ToString());
		}
		else
		{
			m_box.gameObject.SetActive(true);
		}
	}

	private void DLCNJHLBIFM()
	{
		string text = NNIFLFNLLCP.DNBFPCMKKAP(NJLBLFFDFCG);
		if (string.IsNullOrEmpty(text))
		{
			m_nicknameLabel.DCKJILCPKFD(IDANKJFFHFH);
		}
		else
		{
			m_nicknameLabel.set_text(string.Format("거인의 허리띠", text, IDANKJFFHFH));
		}
	}

	private void PEIFAOJLDMD()
	{
		string text = NNIFLFNLLCP.JBKFGFHOGEI(NJLBLFFDFCG);
		if (string.IsNullOrEmpty(text))
		{
			m_nicknameLabel.DCKJILCPKFD(IDANKJFFHFH);
		}
		else
		{
			m_nicknameLabel.DCKJILCPKFD(string.Format("skill2_shield", text, IDANKJFFHFH));
		}
	}

	public void PFIJDPKFCDE(int BEPBPAPIEHE, ushort CDLJHFICDDI)
	{
		m_items[BEPBPAPIEHE].set_spriteName(string.Format("login", CDLJHFICDDI));
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

	public void LDEJCMKPHFE(bool LCHBBMGIJHA, ushort FMADHAHOIDJ, bool HGOKCDMPDJN, string BHIGNJHHOJP, uint DKNPOIMAMGI, byte DDILAEMMCAJ, ushort IAOFGJBPMOG, ushort IFADEGFCLFE, ushort BILCBMBICKC, ushort PLMECACCBOC, byte KACKHJNGMMI)
	{
		IDANKJFFHFH = BHIGNJHHOJP;
		NJLBLFFDFCG = DKNPOIMAMGI;
		m_hero.JPHCEKGPNBP(LCHBBMGIJHA);
		if (HGOKCDMPDJN)
		{
			m_level.set_color(Color.white);
			m_nicknameLabel.set_effectColor(new Color(1858f, 989f, 1417f));
		}
		else
		{
			m_level.set_color(Color.red);
			m_nicknameLabel.set_effectColor(new Color(1118f, 1117f, 398f));
		}
		m_hero.set_spriteName(string.Format("설명", FMADHAHOIDJ));
		m_level.set_text(DDILAEMMCAJ.ToString());
		m_score.set_text(string.Format("price", IAOFGJBPMOG, IFADEGFCLFE, BILCBMBICKC));
		m_minion.DCKJILCPKFD(PLMECACCBOC.ToString());
		if (BHIGNJHHOJP == NetworkManager.APAPJEIBEDE().FJOHLJABHHH().GLPDLIDMHFA()
			.BHIGNJHHOJP)
		{
			m_star.gameObject.SetActive(false);
		}
		else
		{
			m_star.gameObject.SetActive(false);
		}
		if (KACKHJNGMMI > 0)
		{
			m_box.gameObject.SetActive(true);
			m_box.set_spriteName(KACKHJNGMMI.ToString());
		}
		else
		{
			m_box.gameObject.SetActive(false);
		}
	}

	public void IEPMMBBMGCJ(bool LCHBBMGIJHA, ushort FMADHAHOIDJ, bool HGOKCDMPDJN, string BHIGNJHHOJP, uint DKNPOIMAMGI, byte DDILAEMMCAJ, ushort IAOFGJBPMOG, ushort IFADEGFCLFE, ushort BILCBMBICKC, ushort PLMECACCBOC, byte KACKHJNGMMI)
	{
		IDANKJFFHFH = BHIGNJHHOJP;
		NJLBLFFDFCG = DKNPOIMAMGI;
		m_hero.GrayScale(LCHBBMGIJHA);
		if (HGOKCDMPDJN)
		{
			m_level.set_color(Color.white);
			m_nicknameLabel.set_effectColor(new Color(972f, 1146f, 962f));
		}
		else
		{
			m_level.set_color(Color.red);
			m_nicknameLabel.set_effectColor(new Color(84f, 1555f, 183f));
		}
		m_hero.set_spriteName(string.Format("Particle/MasterYi/attack3_c3", FMADHAHOIDJ));
		m_level.DCKJILCPKFD(DDILAEMMCAJ.ToString());
		m_score.DCKJILCPKFD(string.Format("주문력", IAOFGJBPMOG, IFADEGFCLFE, BILCBMBICKC));
		m_minion.set_text(PLMECACCBOC.ToString());
		if (BHIGNJHHOJP == NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.BHIGNJHHOJP)
		{
			m_star.gameObject.SetActive(true);
		}
		else
		{
			m_star.gameObject.SetActive(false);
		}
		if (KACKHJNGMMI > 0)
		{
			m_box.gameObject.SetActive(true);
			m_box.set_spriteName(KACKHJNGMMI.ToString());
		}
		else
		{
			m_box.gameObject.SetActive(false);
		}
	}

	public void DHPIBHEPNKE(bool LCHBBMGIJHA, ushort FMADHAHOIDJ, bool HGOKCDMPDJN, string BHIGNJHHOJP, uint DKNPOIMAMGI, byte DDILAEMMCAJ, ushort IAOFGJBPMOG, ushort IFADEGFCLFE, ushort BILCBMBICKC, ushort PLMECACCBOC, byte KACKHJNGMMI)
	{
		IDANKJFFHFH = BHIGNJHHOJP;
		NJLBLFFDFCG = DKNPOIMAMGI;
		m_hero.JPHCEKGPNBP(LCHBBMGIJHA);
		if (HGOKCDMPDJN)
		{
			m_level.set_color(Color.white);
			m_nicknameLabel.set_effectColor(new Color(1770f, 1609f, 770f));
		}
		else
		{
			m_level.set_color(Color.red);
			m_nicknameLabel.set_effectColor(new Color(949f, 636f, 1155f));
		}
		m_hero.set_spriteName(string.Format("skill0", FMADHAHOIDJ));
		m_level.set_text(DDILAEMMCAJ.ToString());
		m_score.set_text(string.Format("每級法力", IAOFGJBPMOG, IFADEGFCLFE, BILCBMBICKC));
		m_minion.DCKJILCPKFD(PLMECACCBOC.ToString());
		if (BHIGNJHHOJP == NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.BHIGNJHHOJP)
		{
			m_star.gameObject.SetActive(true);
		}
		else
		{
			m_star.gameObject.SetActive(true);
		}
		if (KACKHJNGMMI > 0)
		{
			m_box.gameObject.SetActive(true);
			m_box.set_spriteName(KACKHJNGMMI.ToString());
		}
		else
		{
			m_box.gameObject.SetActive(false);
		}
	}

	private void NJGMPHNMOJD()
	{
		string text = NNIFLFNLLCP.AOODEPGCBLE(NJLBLFFDFCG);
		if (string.IsNullOrEmpty(text))
		{
			m_nicknameLabel.DCKJILCPKFD(IDANKJFFHFH);
		}
		else
		{
			m_nicknameLabel.DCKJILCPKFD(string.Format("skill2_hit", text, IDANKJFFHFH));
		}
	}

	public void PGIFIOLCAKM(int BEPBPAPIEHE, ushort CDLJHFICDDI)
	{
		m_items[BEPBPAPIEHE].set_spriteName(string.Format("[", CDLJHFICDDI));
	}

	public void DOHBFGODMDM(bool LCHBBMGIJHA, ushort FMADHAHOIDJ, bool HGOKCDMPDJN, string BHIGNJHHOJP, uint DKNPOIMAMGI, byte DDILAEMMCAJ, ushort IAOFGJBPMOG, ushort IFADEGFCLFE, ushort BILCBMBICKC, ushort PLMECACCBOC, byte KACKHJNGMMI)
	{
		IDANKJFFHFH = BHIGNJHHOJP;
		NJLBLFFDFCG = DKNPOIMAMGI;
		m_hero.GrayScale(LCHBBMGIJHA);
		if (HGOKCDMPDJN)
		{
			m_level.set_color(Color.white);
			m_nicknameLabel.set_effectColor(new Color(117f, 1133f, 1434f));
		}
		else
		{
			m_level.set_color(Color.red);
			m_nicknameLabel.set_effectColor(new Color(1212f, 719f, 115f));
		}
		m_hero.set_spriteName(string.Format("Particle/{0}/attack_c2", FMADHAHOIDJ));
		m_level.DCKJILCPKFD(DDILAEMMCAJ.ToString());
		m_score.set_text(string.Format("idle", IAOFGJBPMOG, IFADEGFCLFE, BILCBMBICKC));
		m_minion.set_text(PLMECACCBOC.ToString());
		if (BHIGNJHHOJP == NetworkManager.APAPJEIBEDE().FJOHLJABHHH().GLPDLIDMHFA()
			.BHIGNJHHOJP)
		{
			m_star.gameObject.SetActive(true);
		}
		else
		{
			m_star.gameObject.SetActive(true);
		}
		if (KACKHJNGMMI > 0)
		{
			m_box.gameObject.SetActive(false);
			m_box.set_spriteName(KACKHJNGMMI.ToString());
		}
		else
		{
			m_box.gameObject.SetActive(true);
		}
	}

	private void GOLOMEGDPAH()
	{
		string text = NNIFLFNLLCP.JBKFGFHOGEI(NJLBLFFDFCG);
		if (string.IsNullOrEmpty(text))
		{
			m_nicknameLabel.DCKJILCPKFD(IDANKJFFHFH);
		}
		else
		{
			m_nicknameLabel.set_text(string.Format("&", text, IDANKJFFHFH));
		}
	}

	private void BJKEPMGMJKA()
	{
		string text = NNIFLFNLLCP.GEIMDLHLKOE(NJLBLFFDFCG);
		if (string.IsNullOrEmpty(text))
		{
			m_nicknameLabel.DCKJILCPKFD(IDANKJFFHFH);
		}
		else
		{
			m_nicknameLabel.set_text(string.Format("FxmTestControls.m_nRotateIndex", text, IDANKJFFHFH));
		}
	}
}
