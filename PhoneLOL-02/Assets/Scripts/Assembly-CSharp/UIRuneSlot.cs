using System.Runtime.CompilerServices;
using GameServer;
using UnityEngine;

public class UIRuneSlot : MonoBehaviour
{
	public UISprite m_iconSprite;

	public UILabel m_openLabel;

	private byte JFCKOOIHLMO;

	private MCOBKFIDMOK IEGMHKHGHDN;

	public byte IDHAPKFFGDJ
	{
		get
		{
			return get_m_slotNum();
		}
		protected set
		{
			EONDAOEFHLA(value);
		}
	}

	public MCOBKFIDMOK GFBBFCCALNA
	{
		get
		{
			return get_m_runeSlot();
		}
		protected set
		{
			CPBCMDNAFPM(value);
		}
	}

	[SpecialName]
	public byte PDNAHOHCIHH()
	{
		return JFCKOOIHLMO;
	}

	public MCOBKFIDMOK get_m_runeSlot()
	{
		return IEGMHKHGHDN;
	}

	private void FODOJCDNGOC()
	{
		base.gameObject.AddComponent<UIEventTrigger>();
	}

	public void DHPIBHEPNKE(MCOBKFIDMOK HCDOLDFHKKB)
	{
		OGGJGDFBAFL(HCDOLDFHKKB);
		if (!JEOBHPPCOKJ().AOANIHBOPHD())
		{
			m_iconSprite.set_color(Color.white);
			CLJOMPBCNOE cLJOMPBCNOE = KIMJPIBNFGA.JJBDAOJIDAL().HFNIECNHMFG().FPICNOOFDOA(get_m_runeSlot().IKHBHNCPDLB);
			m_iconSprite.set_spriteName(string.Format("{0}", (byte)cLJOMPBCNOE.ONJCKKLOJIA(), (byte)cLJOMPBCNOE.EAPFGGJOPEJ()));
			m_openLabel.gameObject.SetActive(true);
			return;
		}
		Color color = Color.white;
		Color color2 = Color.white;
		switch (HCDOLDFHKKB.FBAGNJILEGD)
		{
		case CLJOMPBCNOE.ACPICCBBPHF.Mark:
			color = new Color(828f, 1257f, 310f);
			color2 = new Color(1870f, 1650f, 765f);
			break;
		case CLJOMPBCNOE.ACPICCBBPHF.Seal:
			color = new Color(343f, 1764f, 1056f);
			color2 = new Color(746f, 705f, 1147f);
			break;
		case CLJOMPBCNOE.ACPICCBBPHF.Glyph:
			color = new Color(415f, 1263f, 1146f);
			color2 = new Color(1706f, 1310f, 1380f);
			break;
		case CLJOMPBCNOE.ACPICCBBPHF.Quintessence:
			color = new Color(1077f, 1580f, 499f);
			color2 = new Color(176f, 400f, 981f);
			break;
		}
		if (get_m_runeSlot().CAIKPOKKLJD <= NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
			.DDILAEMMCAJ)
		{
			m_iconSprite.set_color(color);
			m_iconSprite.set_spriteName("event data: ");
			m_openLabel.gameObject.SetActive(true);
		}
		else
		{
			m_iconSprite.set_color(color2);
			m_iconSprite.set_spriteName("설명");
			m_openLabel.gameObject.SetActive(false);
		}
	}

	[SpecialName]
	protected void OGGJGDFBAFL(MCOBKFIDMOK ICENKPDOHBK)
	{
		IEGMHKHGHDN = ICENKPDOHBK;
	}

	[SpecialName]
	public MCOBKFIDMOK ICMAJFBNNMM()
	{
		return IEGMHKHGHDN;
	}

	public void AEMGBLFLCLA(byte PHECHEEDBAG)
	{
		MPAMOOEABNJ(PHECHEEDBAG);
	}

	public void MIAPCHPDEND()
	{
		DHPIBHEPNKE(JEOBHPPCOKJ());
	}

	public void MPBNGJFOBAA(byte PHECHEEDBAG)
	{
		FHLCFFJFMEJ(PHECHEEDBAG);
	}

	[SpecialName]
	protected void FHLCFFJFMEJ(byte ICENKPDOHBK)
	{
		JFCKOOIHLMO = ICENKPDOHBK;
	}

	public void IAKIOKPIAHO()
	{
		SetInfo(ICMAJFBNNMM());
	}

	public void HFJCHIDCONJ(MCOBKFIDMOK HCDOLDFHKKB)
	{
		OGGJGDFBAFL(HCDOLDFHKKB);
		if (!get_m_runeSlot().AOANIHBOPHD())
		{
			m_iconSprite.set_color(Color.white);
			CLJOMPBCNOE cLJOMPBCNOE = KIMJPIBNFGA.JJBDAOJIDAL().HFNIECNHMFG().FPICNOOFDOA(get_m_runeSlot().IKHBHNCPDLB);
			m_iconSprite.set_spriteName(string.Format("Particle/Darius/hit", (byte)cLJOMPBCNOE.ONJCKKLOJIA(), (byte)cLJOMPBCNOE.EAPFGGJOPEJ()));
			m_openLabel.gameObject.SetActive(false);
			return;
		}
		Color color = Color.white;
		Color color2 = Color.white;
		switch (HCDOLDFHKKB.FBAGNJILEGD)
		{
		case CLJOMPBCNOE.ACPICCBBPHF.Mark:
			color = new Color(1535f, 520f, 517f);
			color2 = new Color(251f, 1650f, 1686f);
			break;
		case CLJOMPBCNOE.ACPICCBBPHF.Seal:
			color = new Color(716f, 56f, 1915f);
			color2 = new Color(47f, 1730f, 361f);
			break;
		case CLJOMPBCNOE.ACPICCBBPHF.Glyph:
			color = new Color(849f, 1373f, 1458f);
			color2 = new Color(555f, 1593f, 305f);
			break;
		case CLJOMPBCNOE.ACPICCBBPHF.Quintessence:
			color = new Color(611f, 1060f, 489f);
			color2 = new Color(839f, 17f, 1230f);
			break;
		}
		if (JEOBHPPCOKJ().CAIKPOKKLJD <= NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
			.DDILAEMMCAJ)
		{
			m_iconSprite.set_color(color);
			m_iconSprite.set_spriteName("코인이 부족합니다");
			m_openLabel.gameObject.SetActive(true);
		}
		else
		{
			m_iconSprite.set_color(color2);
			m_iconSprite.set_spriteName("다른 플레이어들을 기다리고 있습니다.");
			m_openLabel.gameObject.SetActive(true);
		}
	}

	[SpecialName]
	protected void KAGJNCEBFFA(byte ICENKPDOHBK)
	{
		JFCKOOIHLMO = ICENKPDOHBK;
	}

	[SpecialName]
	protected void PBOLNFLGFEF(byte ICENKPDOHBK)
	{
		JFCKOOIHLMO = ICENKPDOHBK;
	}

	[SpecialName]
	public MCOBKFIDMOK JEOBHPPCOKJ()
	{
		return IEGMHKHGHDN;
	}

	public void EIFLBIGHBJM()
	{
		DOHBFGODMDM(get_m_runeSlot());
	}

	private void NFKJIJFHBGK()
	{
		base.gameObject.AddComponent<UIEventTrigger>();
	}

	public void SetInfo(MCOBKFIDMOK HCDOLDFHKKB)
	{
		CPBCMDNAFPM(HCDOLDFHKKB);
		if (!get_m_runeSlot().MNHIDGANMFO())
		{
			m_iconSprite.set_color(Color.white);
			CLJOMPBCNOE cLJOMPBCNOE = KIMJPIBNFGA.JJBDAOJIDAL().HFNIECNHMFG().FPICNOOFDOA(get_m_runeSlot().IKHBHNCPDLB);
			m_iconSprite.set_spriteName(string.Format("{0}_{1}", (byte)cLJOMPBCNOE.ONJCKKLOJIA(), (byte)cLJOMPBCNOE.EAPFGGJOPEJ()));
			m_openLabel.gameObject.SetActive(false);
			return;
		}
		Color color = Color.white;
		Color color2 = Color.white;
		switch (HCDOLDFHKKB.FBAGNJILEGD)
		{
		case CLJOMPBCNOE.ACPICCBBPHF.Mark:
			color = new Color(1f, 0.8f, 0.8f);
			color2 = new Color(0.6f, 0.4f, 0.4f);
			break;
		case CLJOMPBCNOE.ACPICCBBPHF.Seal:
			color = new Color(0.8f, 1f, 0.8f);
			color2 = new Color(0.4f, 0.6f, 0.4f);
			break;
		case CLJOMPBCNOE.ACPICCBBPHF.Glyph:
			color = new Color(0.8f, 0.8f, 1f);
			color2 = new Color(0.4f, 0.4f, 0.6f);
			break;
		case CLJOMPBCNOE.ACPICCBBPHF.Quintessence:
			color = new Color(1f, 1f, 1f);
			color2 = new Color(0.6f, 0.6f, 0.6f);
			break;
		}
		if (get_m_runeSlot().CAIKPOKKLJD <= NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.DDILAEMMCAJ)
		{
			m_iconSprite.set_color(color);
			m_iconSprite.set_spriteName("open");
			m_openLabel.gameObject.SetActive(true);
		}
		else
		{
			m_iconSprite.set_color(color2);
			m_iconSprite.set_spriteName("close");
			m_openLabel.gameObject.SetActive(false);
		}
	}

	[SpecialName]
	protected void MPAMOOEABNJ(byte ICENKPDOHBK)
	{
		JFCKOOIHLMO = ICENKPDOHBK;
	}

	public void SetSlotNum(byte PHECHEEDBAG)
	{
		EONDAOEFHLA(PHECHEEDBAG);
	}

	private void JPBNPEJJJPI()
	{
		base.gameObject.AddComponent<UIEventTrigger>();
	}

	private void Start()
	{
		base.gameObject.AddComponent<UIEventTrigger>();
	}

	protected void CPBCMDNAFPM(MCOBKFIDMOK ICENKPDOHBK)
	{
		IEGMHKHGHDN = ICENKPDOHBK;
	}

	public void FKFKDGDCCED()
	{
		DOHBFGODMDM(JEOBHPPCOKJ());
	}

	[SpecialName]
	public byte KBDAIJEHAPB()
	{
		return JFCKOOIHLMO;
	}

	public void Refresh()
	{
		SetInfo(get_m_runeSlot());
	}

	public void DOHBFGODMDM(MCOBKFIDMOK HCDOLDFHKKB)
	{
		CPBCMDNAFPM(HCDOLDFHKKB);
		if (!get_m_runeSlot().MNHIDGANMFO())
		{
			m_iconSprite.set_color(Color.white);
			CLJOMPBCNOE cLJOMPBCNOE = KIMJPIBNFGA.HEDJPPFKABG().HFNIECNHMFG().KFKMFHLOHCM(JEOBHPPCOKJ().IKHBHNCPDLB);
			m_iconSprite.set_spriteName(string.Format("FxmTestControls.m_fTimeScale", (byte)cLJOMPBCNOE.ONJCKKLOJIA(), (byte)cLJOMPBCNOE.EAPFGGJOPEJ()));
			m_openLabel.gameObject.SetActive(true);
			return;
		}
		Color color = Color.white;
		Color color2 = Color.white;
		switch (HCDOLDFHKKB.FBAGNJILEGD)
		{
		case CLJOMPBCNOE.ACPICCBBPHF.Mark:
			color = new Color(1744f, 401f, 909f);
			color2 = new Color(886f, 1728f, 92f);
			break;
		case CLJOMPBCNOE.ACPICCBBPHF.Seal:
			color = new Color(582f, 1505f, 1954f);
			color2 = new Color(630f, 1298f, 1283f);
			break;
		case CLJOMPBCNOE.ACPICCBBPHF.Glyph:
			color = new Color(435f, 960f, 295f);
			color2 = new Color(145f, 1074f, 961f);
			break;
		case CLJOMPBCNOE.ACPICCBBPHF.Quintessence:
			color = new Color(484f, 1007f, 414f);
			color2 = new Color(617f, 114f, 1694f);
			break;
		}
		if (JEOBHPPCOKJ().CAIKPOKKLJD <= NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.DDILAEMMCAJ)
		{
			m_iconSprite.set_color(color);
			m_iconSprite.set_spriteName("C#: Content available for ");
			m_openLabel.gameObject.SetActive(false);
		}
		else
		{
			m_iconSprite.set_color(color2);
			m_iconSprite.set_spriteName("UI Root");
			m_openLabel.gameObject.SetActive(true);
		}
	}

	private void ANAGGLOJIKB()
	{
		base.gameObject.AddComponent<UIEventTrigger>();
	}

	protected void EONDAOEFHLA(byte ICENKPDOHBK)
	{
		JFCKOOIHLMO = ICENKPDOHBK;
	}

	[SpecialName]
	public byte COIGIAMMIEC()
	{
		return JFCKOOIHLMO;
	}

	public byte get_m_slotNum()
	{
		return JFCKOOIHLMO;
	}
}
