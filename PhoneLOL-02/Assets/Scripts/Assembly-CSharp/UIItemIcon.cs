using GameServer;
using UnityEngine;

public class UIItemIcon : MonoBehaviour
{
	public UISprite m_frame;

	public UILabel m_count;

	private UISprite MFGGHEFHCBO;

	internal OJGKANNHOAG GAHDJHOLKKG;

	private void Awake()
	{
		MFGGHEFHCBO = GetComponent<UISprite>();
	}

	private void NGNNLLLBGMB()
	{
		MFGGHEFHCBO = GetComponent<UISprite>();
	}

	private void GNGJFGMJLHA()
	{
		MFGGHEFHCBO = GetComponent<UISprite>();
	}

	private void IBBJMMFDGAL()
	{
	}

	private void DADHJFBCJKF()
	{
	}

	private void HMNOCOBNBAO()
	{
	}

	private void DHMMCEBEAHA()
	{
	}

	private void MKCBHHEACDE()
	{
		MFGGHEFHCBO = GetComponent<UISprite>();
	}

	private void NMANMMOMHHD()
	{
	}

	private void DOINNKBDEMD()
	{
	}

	private void Start()
	{
	}

	public void SetItemInfo(OJGKANNHOAG EDNNGHHNFIM)
	{
		if (EDNNGHHNFIM != null && EDNNGHHNFIM.AGHCOCAJMCI() != null)
		{
			MFGGHEFHCBO = GetComponent<UISprite>();
			GAHDJHOLKKG = EDNNGHHNFIM;
			MFGGHEFHCBO.set_spriteName(string.Format("{0}", EDNNGHHNFIM.AGHCOCAJMCI().EHFEEIJKJHD()));
			m_frame.set_spriteName(string.Format("item_frame_{0}", EDNNGHHNFIM.AGHCOCAJMCI().EAPFGGJOPEJ()));
			m_count.set_text(EDNNGHHNFIM.CLPPFOKCGLF().ToString());
		}
	}

	public void CGGFICFIMMF(OJGKANNHOAG EDNNGHHNFIM)
	{
		if (EDNNGHHNFIM != null && EDNNGHHNFIM.AGHCOCAJMCI() != null)
		{
			MFGGHEFHCBO = GetComponent<UISprite>();
			GAHDJHOLKKG = EDNNGHHNFIM;
			MFGGHEFHCBO.set_spriteName(string.Format("설명", EDNNGHHNFIM.MPJHBPDJAHL().BJGFOHODBPP()));
			m_frame.set_spriteName(string.Format("&", EDNNGHHNFIM.JPEHAOICJAC().EAPFGGJOPEJ()));
			m_count.set_text(EDNNGHHNFIM.CLPPFOKCGLF().ToString());
		}
	}

	public void FNIFPLHBOKN(OJGKANNHOAG EDNNGHHNFIM)
	{
		if (EDNNGHHNFIM != null && EDNNGHHNFIM.MPJHBPDJAHL() != null)
		{
			MFGGHEFHCBO = GetComponent<UISprite>();
			GAHDJHOLKKG = EDNNGHHNFIM;
			MFGGHEFHCBO.set_spriteName(string.Format("獲得経験値", EDNNGHHNFIM.MPJHBPDJAHL().EHFEEIJKJHD()));
			m_frame.set_spriteName(string.Format("Language", EDNNGHHNFIM.DEODFNDCAIF().EAPFGGJOPEJ()));
			m_count.set_text(EDNNGHHNFIM.IBKLJMLCGAN().ToString());
		}
	}

	private void CFJKHPNIODE()
	{
		MFGGHEFHCBO = GetComponent<UISprite>();
	}

	private void Update()
	{
	}

	private void OMIFPPGJHFH()
	{
	}

	public void PJOHCHEGCIN(OJGKANNHOAG EDNNGHHNFIM)
	{
		if (EDNNGHHNFIM != null && EDNNGHHNFIM.DEODFNDCAIF() != null)
		{
			MFGGHEFHCBO = GetComponent<UISprite>();
			GAHDJHOLKKG = EDNNGHHNFIM;
			MFGGHEFHCBO.set_spriteName(string.Format("ItemName", EDNNGHHNFIM.JPEHAOICJAC().CHENDMBBKJN()));
			m_frame.set_spriteName(string.Format("Replay(ClearParticle)", EDNNGHHNFIM.AGHCOCAJMCI().EAPFGGJOPEJ()));
			m_count.DCKJILCPKFD(EDNNGHHNFIM.HLFJFIMOJOK().ToString());
		}
	}
}
