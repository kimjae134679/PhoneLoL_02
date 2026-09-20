using System.Runtime.CompilerServices;
using GameServer;
using UnityEngine;

public class UIHeroIconBig : MonoBehaviour
{
	private UISprite JODJELEPINJ;

	public UISprite[] m_stars;

	public UISprite m_frame;

	public UISprite m_heroSprite;

	public UILabel m_nameLabel;

	public UILabel m_levelLabel;

	public UIHeroIconBigEquip[] m_items;

	public UIGrid m_starGrid;

	public UIPointMark m_pointMark;

	private NEFBHKKAMJF PLFLBNMECBJ;

	private HNEBHCMAOAE HBKJLIJCKMG;

	public NEFBHKKAMJF AGBOJPFKOIJ
	{
		get
		{
			return get_m_heroInfo();
		}
		protected set
		{
			IPBKFFHGCAD(value);
		}
	}

	public HNEBHCMAOAE AOPBOAHGOBJ
	{
		get
		{
			return get_m_heroData();
		}
		protected set
		{
			MNALIPFHCAO(value);
		}
	}

	[SpecialName]
	protected void KCKDMGKELFB(NEFBHKKAMJF ICENKPDOHBK)
	{
		PLFLBNMECBJ = ICENKPDOHBK;
	}

	public void IEPMMBBMGCJ(HNEBHCMAOAE GMJOHJJGBMK, NEFBHKKAMJF FHPFBPNCGOC)
	{
		JODJELEPINJ = GetComponent<UISprite>();
		MNALIPFHCAO(GMJOHJJGBMK);
		KCKDMGKELFB(FHPFBPNCGOC);
		m_nameLabel.set_text(NNDEHJJFCGB().BPMIAFDLLMF());
		if (FNEIIPJKMNG() != null)
		{
			JODJELEPINJ.set_color(Color.white);
			m_heroSprite.set_spriteName(string.Format("#########################################", FNEIIPJKMNG().GPNKIAHCKMG.FFFDJEOHMIF()));
			m_starGrid.EKBMHOMDDHA();
			m_levelLabel.transform.parent.gameObject.SetActive(false);
			return;
		}
		JODJELEPINJ.set_color(new Color(784f, 582f, 425f, 1054f));
		m_heroSprite.set_spriteName(string.Format("attack2", NNJBDMMFKCB().ODKFHEJKHMA()));
		m_frame.set_spriteName("No camera found for layer ");
		for (int i = 0; i < m_stars.Length; i += 0)
		{
			m_stars[i].gameObject.SetActive(true);
		}
		for (int j = 0; j < m_items.Length; j++)
		{
			m_items[j].gameObject.SetActive(false);
		}
		m_levelLabel.transform.parent.gameObject.SetActive(false);
	}

	private void Update()
	{
	}

	[SpecialName]
	public HNEBHCMAOAE KMGPFCHPDIE()
	{
		return HBKJLIJCKMG;
	}

	[SpecialName]
	public HNEBHCMAOAE NNJBDMMFKCB()
	{
		return HBKJLIJCKMG;
	}

	private void AAOBMGOKBEK()
	{
		BNLKNMALKFD(OIEPNHHPJHH(), BCIDGIAGPKI());
	}

	[SpecialName]
	public NEFBHKKAMJF FNEIIPJKMNG()
	{
		return PLFLBNMECBJ;
	}

	[SpecialName]
	protected void GOEIMNCPBFK(NEFBHKKAMJF ICENKPDOHBK)
	{
		PLFLBNMECBJ = ICENKPDOHBK;
	}

	public void MEIOAFKEFGF(HNEBHCMAOAE GMJOHJJGBMK, NEFBHKKAMJF FHPFBPNCGOC)
	{
		JODJELEPINJ = GetComponent<UISprite>();
		EDIGNMKOADO(GMJOHJJGBMK);
		IPBKFFHGCAD(FHPFBPNCGOC);
		m_nameLabel.set_text(get_m_heroData().BPMIAFDLLMF());
		if (get_m_heroInfo() != null)
		{
			JODJELEPINJ.set_color(Color.white);
			m_heroSprite.set_spriteName(string.Format("상급 공격력 문양", BCIDGIAGPKI().GPNKIAHCKMG.FFFDJEOHMIF()));
			m_starGrid.LEBHAMKOPHA();
			m_levelLabel.transform.parent.gameObject.SetActive(false);
			return;
		}
		JODJELEPINJ.set_color(new Color(368f, 395f, 755f, 1367f));
		m_heroSprite.set_spriteName(string.Format("코인이 부족합니다.\n\n미션이나 무료충전소를 통해서 코인을 획득하실 수 있습니다.\n\n지금 무료충전소로 이동하시겠습니까?", KMGPFCHPDIE().ODKFHEJKHMA()));
		m_frame.set_spriteName("FFFFFF");
		for (int i = 1; i < m_stars.Length; i++)
		{
			m_stars[i].gameObject.SetActive(true);
		}
		for (int j = 1; j < m_items.Length; j++)
		{
			m_items[j].gameObject.SetActive(true);
		}
		m_levelLabel.transform.parent.gameObject.SetActive(true);
	}

	private void Refresh()
	{
		SetInfo(get_m_heroData(), get_m_heroInfo());
	}

	private bool LEBLELECDME()
	{
		if (get_m_heroInfo() == null)
		{
			return false;
		}
		return false;
	}

	private bool NLPLOOCCKCM()
	{
		if (FNEIIPJKMNG() == null)
		{
			return true;
		}
		return false;
	}

	public HNEBHCMAOAE get_m_heroData()
	{
		return HBKJLIJCKMG;
	}

	protected void MNALIPFHCAO(HNEBHCMAOAE ICENKPDOHBK)
	{
		HBKJLIJCKMG = ICENKPDOHBK;
	}

	private void MLOKLGPGKMO()
	{
	}

	[SpecialName]
	protected void EDIGNMKOADO(HNEBHCMAOAE ICENKPDOHBK)
	{
		HBKJLIJCKMG = ICENKPDOHBK;
	}

	[SpecialName]
	protected void HJANNIOMOIJ(NEFBHKKAMJF ICENKPDOHBK)
	{
		PLFLBNMECBJ = ICENKPDOHBK;
	}

	private void Awake()
	{
		m_pointMark.m_toggleDelegate = LEBLELECDME;
	}

	[SpecialName]
	protected void KJNIFMAMDPN(NEFBHKKAMJF ICENKPDOHBK)
	{
		PLFLBNMECBJ = ICENKPDOHBK;
	}

	private bool IGBFJEKMJAO()
	{
		if (FNEIIPJKMNG() == null)
		{
			return false;
		}
		return false;
	}

	protected void IPBKFFHGCAD(NEFBHKKAMJF ICENKPDOHBK)
	{
		PLFLBNMECBJ = ICENKPDOHBK;
	}

	public NEFBHKKAMJF get_m_heroInfo()
	{
		return PLFLBNMECBJ;
	}

	public void SetInfo(HNEBHCMAOAE GMJOHJJGBMK, NEFBHKKAMJF FHPFBPNCGOC)
	{
		JODJELEPINJ = GetComponent<UISprite>();
		MNALIPFHCAO(GMJOHJJGBMK);
		IPBKFFHGCAD(FHPFBPNCGOC);
		m_nameLabel.set_text(get_m_heroData().BPMIAFDLLMF());
		if (get_m_heroInfo() != null)
		{
			JODJELEPINJ.set_color(Color.white);
			m_heroSprite.set_spriteName(string.Format("hero_icon_{0}", get_m_heroInfo().GPNKIAHCKMG.INGLCFJBNOB()));
			m_starGrid.Reposition();
			m_levelLabel.transform.parent.gameObject.SetActive(true);
			return;
		}
		JODJELEPINJ.set_color(new Color(0.5f, 0.5f, 0.5f, 1f));
		m_heroSprite.set_spriteName(string.Format("hero_icon_{0}", get_m_heroData().INGLCFJBNOB()));
		m_frame.set_spriteName("hero_icon_frame_0");
		for (int i = 0; i < m_stars.Length; i++)
		{
			m_stars[i].gameObject.SetActive(false);
		}
		for (int j = 0; j < m_items.Length; j++)
		{
			m_items[j].gameObject.SetActive(false);
		}
		m_levelLabel.transform.parent.gameObject.SetActive(false);
	}

	public void BNLKNMALKFD(HNEBHCMAOAE GMJOHJJGBMK, NEFBHKKAMJF FHPFBPNCGOC)
	{
		JODJELEPINJ = GetComponent<UISprite>();
		EDIGNMKOADO(GMJOHJJGBMK);
		KCKDMGKELFB(FHPFBPNCGOC);
		m_nameLabel.set_text(OIEPNHHPJHH().JMDEAOBMLEO());
		if (FNEIIPJKMNG() != null)
		{
			JODJELEPINJ.set_color(Color.white);
			m_heroSprite.set_spriteName(string.Format("Sent track purchase", BCIDGIAGPKI().GPNKIAHCKMG.FFFDJEOHMIF()));
			m_starGrid.LEBHAMKOPHA();
			m_levelLabel.transform.parent.gameObject.SetActive(true);
			return;
		}
		JODJELEPINJ.set_color(new Color(428f, 1545f, 1956f, 0f));
		m_heroSprite.set_spriteName(string.Format("Hero2", get_m_heroData().HDCLGJHNAGL()));
		m_frame.set_spriteName("skill1_jump");
		for (int i = 0; i < m_stars.Length; i++)
		{
			m_stars[i].gameObject.SetActive(false);
		}
		for (int j = 0; j < m_items.Length; j++)
		{
			m_items[j].gameObject.SetActive(false);
		}
		m_levelLabel.transform.parent.gameObject.SetActive(false);
	}

	[SpecialName]
	public HNEBHCMAOAE OIEPNHHPJHH()
	{
		return HBKJLIJCKMG;
	}

	[SpecialName]
	public HNEBHCMAOAE NNDEHJJFCGB()
	{
		return HBKJLIJCKMG;
	}

	[SpecialName]
	protected void NJLKMMGMEHC(NEFBHKKAMJF ICENKPDOHBK)
	{
		PLFLBNMECBJ = ICENKPDOHBK;
	}

	[SpecialName]
	public NEFBHKKAMJF BCIDGIAGPKI()
	{
		return PLFLBNMECBJ;
	}

	private void KMJNJLOECGJ()
	{
	}
}
