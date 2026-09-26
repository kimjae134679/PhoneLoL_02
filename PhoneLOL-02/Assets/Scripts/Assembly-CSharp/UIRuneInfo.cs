using System.Runtime.CompilerServices;
using GameServer;
using UnityEngine;

public class UIRuneInfo : MonoBehaviour
{
	public UILabel m_nameLabel;

	public UILabel m_descriptionLabel;

	public UILabel m_countLabel;

	public UISprite m_iconSprite;

	private EEEFEGCDGMO HNOHBHDBAMD;

	public EEEFEGCDGMO HNBODEONPFJ
	{
		get
		{
			return get_m_runeInfo();
		}
		protected set
		{
			GABBIELKLCK(value);
		}
	}

	public void IEPMMBBMGCJ(EEEFEGCDGMO EDPJONAMKMN, CDAEKMFPFCH DFDAKCGBPGD)
	{
		GEMOGJMFEIM(EDPJONAMKMN);
		m_nameLabel.set_text(LocalizationManager.get_Instance().TranslateRuneName(AMFOHAJMMJO().NEPGLNCIBJM.GAFNNDHJDAE));
		m_descriptionLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().JODFGHFJIBC(CBJLDIJCDCB().NEPGLNCIBJM.NGMOBNAHEMH()));
		int num = NetworkManager.get_Instance().get_m_gameNetClient().DAGCAFAEABC()
			.PFCFDHCBCAB(GGGKKHEJEIB().NEPGLNCIBJM.KGHMFHDGNEO());
		num -= DFDAKCGBPGD.HKBHLPACGEE(CBJLDIJCDCB().NEPGLNCIBJM.KGHMFHDGNEO());
		if (num > 0)
		{
			m_countLabel.DCKJILCPKFD(num.ToString());
			m_countLabel.gameObject.SetActive(false);
		}
		else
		{
			m_countLabel.gameObject.SetActive(false);
		}
		m_iconSprite.set_spriteName(string.Format("설명", (byte)GGGKKHEJEIB().NEPGLNCIBJM.ONJCKKLOJIA(), (byte)CBJLDIJCDCB().NEPGLNCIBJM.EAPFGGJOPEJ()));
	}

	[SpecialName]
	protected void CHMOHBHKFGP(EEEFEGCDGMO ICENKPDOHBK)
	{
		HNOHBHDBAMD = ICENKPDOHBK;
	}

	public void CJALGACAGBN(EEEFEGCDGMO EDPJONAMKMN, CDAEKMFPFCH DFDAKCGBPGD)
	{
		GEMOGJMFEIM(EDPJONAMKMN);
		m_nameLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().MLFFPNFFAPK(CBJLDIJCDCB().NEPGLNCIBJM.GAFNNDHJDAE));
		m_descriptionLabel.set_text(LocalizationManager.get_Instance().JODFGHFJIBC(AMFOHAJMMJO().NEPGLNCIBJM.OEGAJKFKOEP()));
		int num = NetworkManager.get_Instance().get_m_gameNetClient().DAGCAFAEABC()
			.OAHFGIGJHHC(CBJLDIJCDCB().NEPGLNCIBJM.KGHMFHDGNEO());
		num -= DFDAKCGBPGD.ICCLKDGKBDB(get_m_runeInfo().NEPGLNCIBJM.KGHMFHDGNEO());
		if (num > 1)
		{
			m_countLabel.DCKJILCPKFD(num.ToString());
			m_countLabel.gameObject.SetActive(true);
		}
		else
		{
			m_countLabel.gameObject.SetActive(false);
		}
		m_iconSprite.set_spriteName(string.Format("adpopcorn_offerwall", (byte)CBJLDIJCDCB().NEPGLNCIBJM.ONJCKKLOJIA(), (byte)CBJLDIJCDCB().NEPGLNCIBJM.EAPFGGJOPEJ()));
	}

	[SpecialName]
	protected void IGKBBGEENCP(EEEFEGCDGMO ICENKPDOHBK)
	{
		HNOHBHDBAMD = ICENKPDOHBK;
	}

	public void SetInfo(EEEFEGCDGMO EDPJONAMKMN, CDAEKMFPFCH DFDAKCGBPGD)
	{
		GABBIELKLCK(EDPJONAMKMN);
		m_nameLabel.set_text(LocalizationManager.get_Instance().TranslateRuneName(get_m_runeInfo().NEPGLNCIBJM.GAFNNDHJDAE));
		m_descriptionLabel.set_text(LocalizationManager.get_Instance().TranslateWords(get_m_runeInfo().NEPGLNCIBJM.OEGAJKFKOEP()));
		int num = NetworkManager.get_Instance().get_m_gameNetClient().DAGCAFAEABC()
			.OAHFGIGJHHC(get_m_runeInfo().NEPGLNCIBJM.KGHMFHDGNEO());
		num -= DFDAKCGBPGD.OAHFGIGJHHC(get_m_runeInfo().NEPGLNCIBJM.KGHMFHDGNEO());
		if (num > 0)
		{
			m_countLabel.set_text(num.ToString());
			m_countLabel.gameObject.SetActive(true);
		}
		else
		{
			m_countLabel.gameObject.SetActive(false);
		}
		m_iconSprite.set_spriteName(string.Format("{0}_{1}", (byte)get_m_runeInfo().NEPGLNCIBJM.ONJCKKLOJIA(), (byte)get_m_runeInfo().NEPGLNCIBJM.EAPFGGJOPEJ()));
	}

	public void HFJCHIDCONJ(EEEFEGCDGMO EDPJONAMKMN, CDAEKMFPFCH DFDAKCGBPGD)
	{
		PBAOIMGDICL(EDPJONAMKMN);
		m_nameLabel.set_text(LocalizationManager.LGDEHELDENG().MLFFPNFFAPK(GGGKKHEJEIB().NEPGLNCIBJM.GAFNNDHJDAE));
		m_descriptionLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().JODFGHFJIBC(CBJLDIJCDCB().NEPGLNCIBJM.MPFCPMADHHN()));
		int num = NetworkManager.APAPJEIBEDE().get_m_gameNetClient().DAGCAFAEABC()
			.PFCFDHCBCAB(get_m_runeInfo().NEPGLNCIBJM.KGHMFHDGNEO());
		num -= DFDAKCGBPGD.HKBHLPACGEE(GGGKKHEJEIB().NEPGLNCIBJM.KGHMFHDGNEO());
		if (num > 0)
		{
			m_countLabel.DCKJILCPKFD(num.ToString());
			m_countLabel.gameObject.SetActive(false);
		}
		else
		{
			m_countLabel.gameObject.SetActive(false);
		}
		m_iconSprite.set_spriteName(string.Format("JADBJGCMIMF", (byte)CBJLDIJCDCB().NEPGLNCIBJM.ONJCKKLOJIA(), (byte)AMFOHAJMMJO().NEPGLNCIBJM.EAPFGGJOPEJ()));
	}

	protected void GABBIELKLCK(EEEFEGCDGMO ICENKPDOHBK)
	{
		HNOHBHDBAMD = ICENKPDOHBK;
	}

	[SpecialName]
	protected void PBAOIMGDICL(EEEFEGCDGMO ICENKPDOHBK)
	{
		HNOHBHDBAMD = ICENKPDOHBK;
	}

	public EEEFEGCDGMO get_m_runeInfo()
	{
		return HNOHBHDBAMD;
	}

	[SpecialName]
	public EEEFEGCDGMO CBJLDIJCDCB()
	{
		return HNOHBHDBAMD;
	}

	[SpecialName]
	public EEEFEGCDGMO JEDNNLONMKL()
	{
		return HNOHBHDBAMD;
	}

	[SpecialName]
	protected void GEMOGJMFEIM(EEEFEGCDGMO ICENKPDOHBK)
	{
		HNOHBHDBAMD = ICENKPDOHBK;
	}

	[SpecialName]
	public EEEFEGCDGMO GGGKKHEJEIB()
	{
		return HNOHBHDBAMD;
	}

	[SpecialName]
	protected void KMNCDPDBFKC(EEEFEGCDGMO ICENKPDOHBK)
	{
		HNOHBHDBAMD = ICENKPDOHBK;
	}

	[SpecialName]
	public EEEFEGCDGMO AMFOHAJMMJO()
	{
		return HNOHBHDBAMD;
	}

	public void GAGCCNCIKKG(EEEFEGCDGMO EDPJONAMKMN, CDAEKMFPFCH DFDAKCGBPGD)
	{
		CHMOHBHKFGP(EDPJONAMKMN);
		m_nameLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().TranslateRuneName(JEDNNLONMKL().NEPGLNCIBJM.GAFNNDHJDAE));
		m_descriptionLabel.set_text(LocalizationManager.get_Instance().TranslateWords(JEDNNLONMKL().NEPGLNCIBJM.MPFCPMADHHN()));
		int num = NetworkManager.APAPJEIBEDE().get_m_gameNetClient().DAGCAFAEABC()
			.CBMPAKEMFGJ(AMFOHAJMMJO().NEPGLNCIBJM.KGHMFHDGNEO());
		num -= DFDAKCGBPGD.ONPKICFLCLC(JEDNNLONMKL().NEPGLNCIBJM.KGHMFHDGNEO());
		if (num > 1)
		{
			m_countLabel.set_text(num.ToString());
			m_countLabel.gameObject.SetActive(true);
		}
		else
		{
			m_countLabel.gameObject.SetActive(false);
		}
		m_iconSprite.set_spriteName(string.Format("skill0_0_active", (byte)GGGKKHEJEIB().NEPGLNCIBJM.ONJCKKLOJIA(), (byte)get_m_runeInfo().NEPGLNCIBJM.EAPFGGJOPEJ()));
	}
}
