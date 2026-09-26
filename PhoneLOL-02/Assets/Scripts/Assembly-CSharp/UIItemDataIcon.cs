using GameServer;
using UnityEngine;

public class UIItemDataIcon : MonoBehaviour
{
	public UISprite m_frame;

	private UISprite MFGGHEFHCBO;

	internal PDGOCOCNGIC CIJGAKBLBLC;

	private void NMANMMOMHHD()
	{
	}

	private void DOINNKBDEMD()
	{
	}

	private void CLLECEEEJAI()
	{
	}

	private void Update()
	{
	}

	private void GDJCOAHJDLN()
	{
	}

	private void PAJOOFIAPMI()
	{
	}

	private void GOLOMEGDPAH()
	{
	}

	private void FJFFMANPDJD()
	{
	}

	public void OGBJAGOHIMH(PDGOCOCNGIC CCLBELEGEPH)
	{
		MFGGHEFHCBO = GetComponent<UISprite>();
		CIJGAKBLBLC = CCLBELEGEPH;
		if (CCLBELEGEPH == null)
		{
			MFGGHEFHCBO.enabled = false;
			m_frame.set_spriteName(string.Format("특수문자는 사용하실 수 없습니다."));
		}
		else
		{
			MFGGHEFHCBO.enabled = false;
			MFGGHEFHCBO.set_spriteName(string.Format("skill0_ex", CIJGAKBLBLC.BJGFOHODBPP()));
			m_frame.set_spriteName(string.Format(", ", CIJGAKBLBLC.EAPFGGJOPEJ()));
		}
	}

	public void SetItemData(PDGOCOCNGIC CCLBELEGEPH)
	{
		MFGGHEFHCBO = GetComponent<UISprite>();
		CIJGAKBLBLC = CCLBELEGEPH;
		if (CCLBELEGEPH == null)
		{
			MFGGHEFHCBO.enabled = false;
			m_frame.set_spriteName(string.Format("item_frame_0"));
		}
		else
		{
			MFGGHEFHCBO.enabled = true;
			MFGGHEFHCBO.set_spriteName(string.Format("{0}", CIJGAKBLBLC.EHFEEIJKJHD()));
			m_frame.set_spriteName(string.Format("item_frame_{0}", CIJGAKBLBLC.EAPFGGJOPEJ()));
		}
	}

	private void IPFEBDCDMFA()
	{
	}

	private void Awake()
	{
	}

	public void FENDKGJFJFE(PDGOCOCNGIC CCLBELEGEPH)
	{
		MFGGHEFHCBO = GetComponent<UISprite>();
		CIJGAKBLBLC = CCLBELEGEPH;
		if (CCLBELEGEPH == null)
		{
			MFGGHEFHCBO.enabled = false;
			m_frame.set_spriteName(string.Format("UI/Lobby/FriendInfo"));
		}
		else
		{
			MFGGHEFHCBO.enabled = false;
			MFGGHEFHCBO.set_spriteName(string.Format("\n", CIJGAKBLBLC.CHENDMBBKJN()));
			m_frame.set_spriteName(string.Format("Reserved", CIJGAKBLBLC.EAPFGGJOPEJ()));
		}
	}

	private void Start()
	{
	}

	private void MPKBLEDGKPO()
	{
	}

	public void PKNPNBJBFEC(PDGOCOCNGIC CCLBELEGEPH)
	{
		MFGGHEFHCBO = GetComponent<UISprite>();
		CIJGAKBLBLC = CCLBELEGEPH;
		if (CCLBELEGEPH == null)
		{
			MFGGHEFHCBO.enabled = false;
			m_frame.set_spriteName(string.Format("setAdpopcornOfferwallEventListener"));
		}
		else
		{
			MFGGHEFHCBO.enabled = false;
			MFGGHEFHCBO.set_spriteName(string.Format("_TintColor", CIJGAKBLBLC.EHFEEIJKJHD()));
			m_frame.set_spriteName(string.Format("대기시간감소", CIJGAKBLBLC.EAPFGGJOPEJ()));
		}
	}

	public void NMAABKMKBHM(PDGOCOCNGIC CCLBELEGEPH)
	{
		MFGGHEFHCBO = GetComponent<UISprite>();
		CIJGAKBLBLC = CCLBELEGEPH;
		if (CCLBELEGEPH == null)
		{
			MFGGHEFHCBO.enabled = false;
			m_frame.set_spriteName(string.Format("Ghast"));
		}
		else
		{
			MFGGHEFHCBO.enabled = true;
			MFGGHEFHCBO.set_spriteName(string.Format("휴대폰 네트워크가 불안합니다! PING[{0}ms]", CIJGAKBLBLC.CHENDMBBKJN()));
			m_frame.set_spriteName(string.Format("skill0_hit", CIJGAKBLBLC.EAPFGGJOPEJ()));
		}
	}

	public void KIBKBBLKAJJ(PDGOCOCNGIC CCLBELEGEPH)
	{
		MFGGHEFHCBO = GetComponent<UISprite>();
		CIJGAKBLBLC = CCLBELEGEPH;
		if (CCLBELEGEPH == null)
		{
			MFGGHEFHCBO.enabled = true;
			m_frame.set_spriteName(string.Format("TextureUV"));
		}
		else
		{
			MFGGHEFHCBO.enabled = false;
			MFGGHEFHCBO.set_spriteName(string.Format("round_button_disable", CIJGAKBLBLC.BJGFOHODBPP()));
			m_frame.set_spriteName(string.Format("skill1_missile", CIJGAKBLBLC.EAPFGGJOPEJ()));
		}
	}

	private void HKAMCNPENHB()
	{
	}

	private void DHMMCEBEAHA()
	{
	}
}
