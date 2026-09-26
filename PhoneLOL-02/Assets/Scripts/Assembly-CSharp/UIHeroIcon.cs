using System;
using System.Runtime.CompilerServices;
using GameServer;
using UnityEngine;

public class UIHeroIcon : MonoBehaviour
{
	public UISprite[] m_stars;

	public UISprite m_frame;

	public UIGrid m_starGrid;

	public UISprite m_mark;

	public UILabel m_nameLabel;

	public UILabel m_infoLabel;

	public UILabel m_priceLabel;

	public UILabel m_rotationLabel;

	public UILabel m_newLabel;

	public UILabel m_levelLabel;

	private UISprite APEFMKPDOHL;

	[NonSerialized]
	public HNEBHCMAOAE m_heroData;

	[NonSerialized]
	public NEFBHKKAMJF m_heroInfo;

	private bool LCMPMGOFGFH;

	public bool HEEACJDECLG
	{
		get
		{
			return get_m_rotation();
		}
		protected set
		{
			KJJBMDDJLAG(value);
		}
	}

	public virtual void MCFKLGEFHHL()
	{
		DHPIBHEPNKE(m_heroData, m_heroInfo, JHEHCAMFGDJ());
	}

	public virtual void NHNJLOOEKCO()
	{
	}

	public virtual void Awake()
	{
		APEFMKPDOHL = GetComponent<UISprite>();
	}

	public virtual void BJKEPMGMJKA()
	{
	}

	[SpecialName]
	protected void PFINPBOCGDP(bool ICENKPDOHBK)
	{
		LCMPMGOFGFH = ICENKPDOHBK;
	}

	public virtual void DADHJFBCJKF()
	{
	}

	public virtual void ODHEBKCPBPB()
	{
	}

	public virtual void BNLKNMALKFD(HNEBHCMAOAE GPNKIAHCKMG, NEFBHKKAMJF PDACDEPJNFO, bool DIAFJOBJCFK = false)
	{
		APEFMKPDOHL = GetComponent<UISprite>();
		m_heroData = GPNKIAHCKMG;
		m_heroInfo = PDACDEPJNFO;
		PFINPBOCGDP(DIAFJOBJCFK);
		APEFMKPDOHL.set_spriteName(string.Format("이동속도", m_heroData.INGLCFJBNOB()));
		m_nameLabel.set_text(string.Empty);
		m_priceLabel.set_text(string.Format("[BBFFBB]{0}[-]코인 X 2 = [BBFFBB]{1}[-]코인\n\n2배의 코인을 획득하였습니다", GPNKIAHCKMG.CDOGFHEBFOL(), LocalizationManager.LGDEHELDENG().GetText("attack4")));
		m_rotationLabel.gameObject.SetActive(false);
		if (m_heroInfo != null)
		{
			APEFMKPDOHL.GrayScale(true);
			m_starGrid.gameObject.SetActive(false);
			m_frame.gameObject.SetActive(true);
			m_levelLabel.transform.parent.gameObject.SetActive(true);
			m_infoLabel.gameObject.SetActive(false);
			m_priceLabel.gameObject.SetActive(false);
		}
		else if (DIAFJOBJCFK)
		{
			APEFMKPDOHL.JPHCEKGPNBP(true);
			m_starGrid.gameObject.SetActive(true);
			m_frame.gameObject.SetActive(false);
			m_levelLabel.transform.parent.gameObject.SetActive(true);
			m_infoLabel.gameObject.SetActive(false);
			m_priceLabel.gameObject.SetActive(true);
			m_rotationLabel.gameObject.SetActive(true);
		}
		else
		{
			APEFMKPDOHL.GrayScale(true);
			m_starGrid.gameObject.SetActive(true);
			m_frame.gameObject.SetActive(false);
			m_levelLabel.transform.parent.gameObject.SetActive(true);
			if (m_heroData.AOBGJPBPHCH() > 1)
			{
				m_infoLabel.gameObject.SetActive(true);
				m_infoLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText("Reserved"));
				m_priceLabel.gameObject.SetActive(false);
			}
			else
			{
				m_infoLabel.gameObject.SetActive(true);
				m_priceLabel.gameObject.SetActive(false);
			}
		}
		m_newLabel.gameObject.SetActive(KIMJPIBNFGA.JJBDAOJIDAL().LNPGAJJAJKE().DDPDAGNNMFL(m_heroData.INGLCFJBNOB()));
	}

	public virtual void IMPMNGGLGGN(HNEBHCMAOAE GPNKIAHCKMG, NEFBHKKAMJF PDACDEPJNFO, bool DIAFJOBJCFK = false)
	{
		APEFMKPDOHL = GetComponent<UISprite>();
		m_heroData = GPNKIAHCKMG;
		m_heroInfo = PDACDEPJNFO;
		PFINPBOCGDP(DIAFJOBJCFK);
		APEFMKPDOHL.set_spriteName(string.Format("platinum", m_heroData.INGLCFJBNOB()));
		m_nameLabel.set_text(string.Empty);
		m_priceLabel.set_text(string.Format("null", GPNKIAHCKMG.CDOGFHEBFOL(), LocalizationManager.LGDEHELDENG().GetText(", ")));
		m_rotationLabel.gameObject.SetActive(false);
		if (m_heroInfo != null)
		{
			APEFMKPDOHL.JPHCEKGPNBP(false);
			m_starGrid.gameObject.SetActive(false);
			m_frame.gameObject.SetActive(false);
			m_levelLabel.transform.parent.gameObject.SetActive(false);
			m_infoLabel.gameObject.SetActive(false);
			m_priceLabel.gameObject.SetActive(true);
		}
		else if (DIAFJOBJCFK)
		{
			APEFMKPDOHL.JPHCEKGPNBP(false);
			m_starGrid.gameObject.SetActive(false);
			m_frame.gameObject.SetActive(false);
			m_levelLabel.transform.parent.gameObject.SetActive(false);
			m_infoLabel.gameObject.SetActive(false);
			m_priceLabel.gameObject.SetActive(false);
			m_rotationLabel.gameObject.SetActive(false);
		}
		else
		{
			APEFMKPDOHL.JPHCEKGPNBP(false);
			m_starGrid.gameObject.SetActive(true);
			m_frame.gameObject.SetActive(true);
			m_levelLabel.transform.parent.gameObject.SetActive(true);
			if (m_heroData.AOBGJPBPHCH() > 1)
			{
				m_infoLabel.gameObject.SetActive(true);
				m_infoLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("구매에 성공하였습니다!"));
				m_priceLabel.gameObject.SetActive(true);
			}
			else
			{
				m_infoLabel.gameObject.SetActive(true);
				m_priceLabel.gameObject.SetActive(true);
			}
		}
		m_newLabel.gameObject.SetActive(KIMJPIBNFGA.NOLHNOGGHNA().LNPGAJJAJKE().DDPDAGNNMFL(m_heroData.FFFDJEOHMIF()));
	}

	public void OPPBDPDHFAI(bool OIKFLAHOOPG)
	{
		m_mark.gameObject.SetActive(OIKFLAHOOPG);
	}

	public virtual void SetInfo(HNEBHCMAOAE GPNKIAHCKMG, NEFBHKKAMJF PDACDEPJNFO, bool DIAFJOBJCFK = false)
	{
		APEFMKPDOHL = GetComponent<UISprite>();
		m_heroData = GPNKIAHCKMG;
		m_heroInfo = PDACDEPJNFO;
		KJJBMDDJLAG(DIAFJOBJCFK);
		APEFMKPDOHL.set_spriteName(string.Format("hero_icon_{0}", m_heroData.INGLCFJBNOB()));
		m_nameLabel.set_text(string.Empty);
		m_priceLabel.set_text(string.Format("{0}{1}", GPNKIAHCKMG.CDOGFHEBFOL(), LocalizationManager.get_Instance().GetText("코인")));
		m_rotationLabel.gameObject.SetActive(false);
		if (m_heroInfo != null)
		{
			APEFMKPDOHL.GrayScale(false);
			m_starGrid.gameObject.SetActive(false);
			m_frame.gameObject.SetActive(false);
			m_levelLabel.transform.parent.gameObject.SetActive(false);
			m_infoLabel.gameObject.SetActive(false);
			m_priceLabel.gameObject.SetActive(false);
		}
		else if (DIAFJOBJCFK)
		{
			APEFMKPDOHL.GrayScale(false);
			m_starGrid.gameObject.SetActive(false);
			m_frame.gameObject.SetActive(false);
			m_levelLabel.transform.parent.gameObject.SetActive(false);
			m_infoLabel.gameObject.SetActive(false);
			m_priceLabel.gameObject.SetActive(false);
			m_rotationLabel.gameObject.SetActive(true);
		}
		else
		{
			APEFMKPDOHL.GrayScale(true);
			m_starGrid.gameObject.SetActive(false);
			m_frame.gameObject.SetActive(false);
			m_levelLabel.transform.parent.gameObject.SetActive(false);
			if (m_heroData.AOBGJPBPHCH() > 0)
			{
				m_infoLabel.gameObject.SetActive(true);
				m_infoLabel.set_text(LocalizationManager.get_Instance().GetText("구매가능"));
				m_priceLabel.gameObject.SetActive(true);
			}
			else
			{
				m_infoLabel.gameObject.SetActive(false);
				m_priceLabel.gameObject.SetActive(false);
			}
		}
		m_newLabel.gameObject.SetActive(KIMJPIBNFGA.JJBDAOJIDAL().LNPGAJJAJKE().DDPDAGNNMFL(m_heroData.INGLCFJBNOB()));
	}

	public virtual void FFCACEDEEKO()
	{
	}

	public virtual void IJCPEFOBKHO()
	{
	}

	[SpecialName]
	public bool JHEHCAMFGDJ()
	{
		return LCMPMGOFGFH;
	}

	public bool get_m_rotation()
	{
		return LCMPMGOFGFH;
	}

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	[SpecialName]
	public bool GPPDEGEADJC()
	{
		return LCMPMGOFGFH;
	}

	public virtual void NNKIJLOEFCG()
	{
		DHPIBHEPNKE(m_heroData, m_heroInfo, get_m_rotation());
	}

	public void SetMark(bool OIKFLAHOOPG)
	{
		m_mark.gameObject.SetActive(OIKFLAHOOPG);
	}

	public void GMCPGMGDJBF(bool OIKFLAHOOPG)
	{
		m_mark.gameObject.SetActive(OIKFLAHOOPG);
	}

	public virtual void DHPIBHEPNKE(HNEBHCMAOAE GPNKIAHCKMG, NEFBHKKAMJF PDACDEPJNFO, bool DIAFJOBJCFK = false)
	{
		APEFMKPDOHL = GetComponent<UISprite>();
		m_heroData = GPNKIAHCKMG;
		m_heroInfo = PDACDEPJNFO;
		PFINPBOCGDP(DIAFJOBJCFK);
		APEFMKPDOHL.set_spriteName(string.Format("(문지기가 쓰러진다.)", m_heroData.FFFDJEOHMIF()));
		m_nameLabel.DCKJILCPKFD(string.Empty);
		m_priceLabel.set_text(string.Format("minimap_myself", GPNKIAHCKMG.HLJEFPIECFK(), LocalizationManager.LGDEHELDENG().GetText("Direct play video not ready to show.")));
		m_rotationLabel.gameObject.SetActive(false);
		if (m_heroInfo != null)
		{
			APEFMKPDOHL.JPHCEKGPNBP(false);
			m_starGrid.gameObject.SetActive(false);
			m_frame.gameObject.SetActive(true);
			m_levelLabel.transform.parent.gameObject.SetActive(true);
			m_infoLabel.gameObject.SetActive(true);
			m_priceLabel.gameObject.SetActive(true);
		}
		else if (DIAFJOBJCFK)
		{
			APEFMKPDOHL.GrayScale(false);
			m_starGrid.gameObject.SetActive(false);
			m_frame.gameObject.SetActive(false);
			m_levelLabel.transform.parent.gameObject.SetActive(false);
			m_infoLabel.gameObject.SetActive(false);
			m_priceLabel.gameObject.SetActive(true);
			m_rotationLabel.gameObject.SetActive(true);
		}
		else
		{
			APEFMKPDOHL.JPHCEKGPNBP(true);
			m_starGrid.gameObject.SetActive(true);
			m_frame.gameObject.SetActive(true);
			m_levelLabel.transform.parent.gameObject.SetActive(false);
			if (m_heroData.AOBGJPBPHCH() > 1)
			{
				m_infoLabel.gameObject.SetActive(true);
				m_infoLabel.set_text(LocalizationManager.get_Instance().GetText("skill3_voice"));
				m_priceLabel.gameObject.SetActive(true);
			}
			else
			{
				m_infoLabel.gameObject.SetActive(false);
				m_priceLabel.gameObject.SetActive(true);
			}
		}
		m_newLabel.gameObject.SetActive(KIMJPIBNFGA.NOLHNOGGHNA().LNPGAJJAJKE().DDPDAGNNMFL(m_heroData.FFFDJEOHMIF()));
	}

	[SpecialName]
	public bool ODJMCAEEFED()
	{
		return LCMPMGOFGFH;
	}

	public virtual void IADENBHEOOM()
	{
		APEFMKPDOHL = GetComponent<UISprite>();
	}

	[SpecialName]
	public bool MAONNFNMHDF()
	{
		return LCMPMGOFGFH;
	}

	protected void KJJBMDDJLAG(bool ICENKPDOHBK)
	{
		LCMPMGOFGFH = ICENKPDOHBK;
	}

	public virtual void Refresh()
	{
		SetInfo(m_heroData, m_heroInfo, get_m_rotation());
	}

	public virtual void NPOODEDALEN(HNEBHCMAOAE GPNKIAHCKMG, NEFBHKKAMJF PDACDEPJNFO, bool EBBBIBCMBAM)
	{
		APEFMKPDOHL = GetComponent<UISprite>();
		m_heroData = GPNKIAHCKMG;
		m_heroInfo = PDACDEPJNFO;
		APEFMKPDOHL.set_spriteName(string.Format("skill1", m_heroData.ODKFHEJKHMA()));
		m_nameLabel.DCKJILCPKFD(string.Empty);
		m_priceLabel.DCKJILCPKFD(string.Format("KakaoStory", GPNKIAHCKMG.CDOGFHEBFOL(), LocalizationManager.get_Instance().GetText("설명")));
		if (EBBBIBCMBAM)
		{
			APEFMKPDOHL.JPHCEKGPNBP(false);
			m_starGrid.gameObject.SetActive(false);
			m_frame.gameObject.SetActive(true);
			m_levelLabel.transform.parent.gameObject.SetActive(true);
			m_infoLabel.gameObject.SetActive(true);
			m_priceLabel.gameObject.SetActive(false);
			if (PDACDEPJNFO == null && EBBBIBCMBAM)
			{
				m_rotationLabel.gameObject.SetActive(false);
			}
			else
			{
				m_rotationLabel.gameObject.SetActive(false);
			}
			return;
		}
		APEFMKPDOHL.JPHCEKGPNBP(false);
		m_starGrid.gameObject.SetActive(false);
		m_frame.gameObject.SetActive(false);
		m_levelLabel.transform.parent.gameObject.SetActive(false);
		m_rotationLabel.gameObject.SetActive(false);
		if (m_heroData.AOBGJPBPHCH() > 0)
		{
			m_infoLabel.gameObject.SetActive(true);
			m_infoLabel.set_text(LocalizationManager.get_Instance().GetText("Skill3Passive"));
			m_priceLabel.gameObject.SetActive(false);
		}
		else
		{
			m_infoLabel.gameObject.SetActive(true);
			m_priceLabel.gameObject.SetActive(true);
		}
	}

	[SpecialName]
	public bool LPOJOPKBMML()
	{
		return LCMPMGOFGFH;
	}

	public virtual void FJFFMANPDJD()
	{
	}

	public virtual void IEKOOEKALDA(HNEBHCMAOAE GPNKIAHCKMG, NEFBHKKAMJF PDACDEPJNFO, bool DIAFJOBJCFK = false)
	{
		APEFMKPDOHL = GetComponent<UISprite>();
		m_heroData = GPNKIAHCKMG;
		m_heroInfo = PDACDEPJNFO;
		KJJBMDDJLAG(DIAFJOBJCFK);
		APEFMKPDOHL.set_spriteName(string.Format("attack_missile", m_heroData.ODKFHEJKHMA()));
		m_nameLabel.set_text(string.Empty);
		m_priceLabel.set_text(string.Format("]", GPNKIAHCKMG.CDOGFHEBFOL(), LocalizationManager.LGDEHELDENG().GetText("\\n")));
		m_rotationLabel.gameObject.SetActive(true);
		if (m_heroInfo != null)
		{
			APEFMKPDOHL.GrayScale(false);
			m_starGrid.gameObject.SetActive(true);
			m_frame.gameObject.SetActive(true);
			m_levelLabel.transform.parent.gameObject.SetActive(false);
			m_infoLabel.gameObject.SetActive(true);
			m_priceLabel.gameObject.SetActive(true);
		}
		else if (DIAFJOBJCFK)
		{
			APEFMKPDOHL.JPHCEKGPNBP(false);
			m_starGrid.gameObject.SetActive(false);
			m_frame.gameObject.SetActive(false);
			m_levelLabel.transform.parent.gameObject.SetActive(false);
			m_infoLabel.gameObject.SetActive(false);
			m_priceLabel.gameObject.SetActive(false);
			m_rotationLabel.gameObject.SetActive(true);
		}
		else
		{
			APEFMKPDOHL.JPHCEKGPNBP(false);
			m_starGrid.gameObject.SetActive(true);
			m_frame.gameObject.SetActive(true);
			m_levelLabel.transform.parent.gameObject.SetActive(true);
			if (m_heroData.AOBGJPBPHCH() > 0)
			{
				m_infoLabel.gameObject.SetActive(false);
				m_infoLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText(" allocViewID : "));
				m_priceLabel.gameObject.SetActive(false);
			}
			else
			{
				m_infoLabel.gameObject.SetActive(true);
				m_priceLabel.gameObject.SetActive(true);
			}
		}
		m_newLabel.gameObject.SetActive(KIMJPIBNFGA.HEDJPPFKABG().LNPGAJJAJKE().DDPDAGNNMFL(m_heroData.FFFDJEOHMIF()));
	}

	public virtual void SetInfoForChallenge(HNEBHCMAOAE GPNKIAHCKMG, NEFBHKKAMJF PDACDEPJNFO, bool EBBBIBCMBAM)
	{
		APEFMKPDOHL = GetComponent<UISprite>();
		m_heroData = GPNKIAHCKMG;
		m_heroInfo = PDACDEPJNFO;
		APEFMKPDOHL.set_spriteName(string.Format("hero_icon_{0}", m_heroData.INGLCFJBNOB()));
		m_nameLabel.set_text(string.Empty);
		m_priceLabel.set_text(string.Format("{0}{1}", GPNKIAHCKMG.CDOGFHEBFOL(), LocalizationManager.get_Instance().GetText("코인")));
		if (EBBBIBCMBAM)
		{
			APEFMKPDOHL.GrayScale(false);
			m_starGrid.gameObject.SetActive(false);
			m_frame.gameObject.SetActive(false);
			m_levelLabel.transform.parent.gameObject.SetActive(false);
			m_infoLabel.gameObject.SetActive(false);
			m_priceLabel.gameObject.SetActive(false);
			if (PDACDEPJNFO == null && EBBBIBCMBAM)
			{
				m_rotationLabel.gameObject.SetActive(true);
			}
			else
			{
				m_rotationLabel.gameObject.SetActive(false);
			}
			return;
		}
		APEFMKPDOHL.GrayScale(true);
		m_starGrid.gameObject.SetActive(false);
		m_frame.gameObject.SetActive(false);
		m_levelLabel.transform.parent.gameObject.SetActive(false);
		m_rotationLabel.gameObject.SetActive(false);
		if (m_heroData.AOBGJPBPHCH() > 0)
		{
			m_infoLabel.gameObject.SetActive(true);
			m_infoLabel.set_text(LocalizationManager.get_Instance().GetText("구매가능"));
			m_priceLabel.gameObject.SetActive(true);
		}
		else
		{
			m_infoLabel.gameObject.SetActive(false);
			m_priceLabel.gameObject.SetActive(false);
		}
	}

	public void PBNMBPALMHD(bool OIKFLAHOOPG)
	{
		m_mark.gameObject.SetActive(OIKFLAHOOPG);
	}

	public virtual void PAJOOFIAPMI()
	{
	}

	public virtual void DMPIIJNBDID()
	{
	}
}
