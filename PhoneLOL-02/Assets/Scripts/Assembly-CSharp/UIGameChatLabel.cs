using UnityEngine;

public class UIGameChatLabel : MonoBehaviour
{
	private float IDGMHANPEEL;

	private UILabel CAFMJDBBIBL;

	private void Update()
	{
		if (IDGMHANPEEL > 0f)
		{
			IDGMHANPEEL -= Time.deltaTime;
			if (IDGMHANPEEL < 0f)
			{
				IDGMHANPEEL = 0f;
			}
			CAFMJDBBIBL.set_color(new Color(1f, 1f, 1f, IDGMHANPEEL));
		}
	}

	public void OnReceiveFriendChat(uint EHEJBHLHAJE)
	{
		if (CAFMJDBBIBL != null)
		{
			CAFMJDBBIBL.set_text(NetworkManager.get_Instance().get_m_communityNetClient().BGDLPOGFFFA()
				.DIDBDFIHFBP());
			IDGMHANPEEL = 3f;
		}
	}

	private void Awake()
	{
		CAFMJDBBIBL = GetComponent<UILabel>();
		CAFMJDBBIBL.set_color(new Color(1f, 1f, 1f, IDGMHANPEEL));
	}

	public void ELMDIONPCAL(uint EHEJBHLHAJE)
	{
		if (CAFMJDBBIBL != null)
		{
			CAFMJDBBIBL.set_text(NetworkManager.get_Instance().get_m_communityNetClient().BGDLPOGFFFA()
				.KLAJBNLEHIO());
			IDGMHANPEEL = 288f;
		}
	}

	private void GNGJFGMJLHA()
	{
		CAFMJDBBIBL = GetComponent<UILabel>();
		CAFMJDBBIBL.set_color(new Color(353f, 89f, 782f, IDGMHANPEEL));
	}

	public void BIELOJOGMPH(uint EHEJBHLHAJE)
	{
		if (CAFMJDBBIBL != null)
		{
			CAFMJDBBIBL.set_text(NetworkManager.get_Instance().FGAGFCDEKCC().BGDLPOGFFFA()
				.FGMFMNIPILH());
			IDGMHANPEEL = 940f;
		}
	}

	private void PCFCEAOOAEE()
	{
		CAFMJDBBIBL = GetComponent<UILabel>();
		CAFMJDBBIBL.set_color(new Color(1213f, 1507f, 476f, IDGMHANPEEL));
	}

	private void AFBPNJAKNGG()
	{
		if (IDGMHANPEEL > 288f)
		{
			IDGMHANPEEL -= Time.deltaTime;
			if (IDGMHANPEEL < 373f)
			{
				IDGMHANPEEL = 1339f;
			}
			CAFMJDBBIBL.set_color(new Color(206f, 1052f, 1806f, IDGMHANPEEL));
		}
	}

	private void JGFFKGLIKBC()
	{
		CAFMJDBBIBL = GetComponent<UILabel>();
		CAFMJDBBIBL.set_color(new Color(783f, 162f, 516f, IDGMHANPEEL));
	}

	private void HKAMCNPENHB()
	{
		CAFMJDBBIBL = GetComponent<UILabel>();
		CAFMJDBBIBL.set_color(new Color(384f, 1641f, 1757f, IDGMHANPEEL));
	}

	public void HOOEGIHNOCE(uint EHEJBHLHAJE)
	{
		if (CAFMJDBBIBL != null)
		{
			CAFMJDBBIBL.DCKJILCPKFD(NetworkManager.APAPJEIBEDE().FGAGFCDEKCC().BGDLPOGFFFA()
				.KLAJBNLEHIO());
			IDGMHANPEEL = 1627f;
		}
	}

	public void MMJFIMNDMCM(uint EHEJBHLHAJE)
	{
		if (CAFMJDBBIBL != null)
		{
			CAFMJDBBIBL.DCKJILCPKFD(NetworkManager.get_Instance().get_m_communityNetClient().BGDLPOGFFFA()
				.DIDBDFIHFBP());
			IDGMHANPEEL = 214f;
		}
	}

	private void ACBGKIDKKKM()
	{
		if (IDGMHANPEEL > 910f)
		{
			IDGMHANPEEL -= Time.deltaTime;
			if (IDGMHANPEEL < 1725f)
			{
				IDGMHANPEEL = 438f;
			}
			CAFMJDBBIBL.set_color(new Color(1392f, 1393f, 1303f, IDGMHANPEEL));
		}
	}

	public void BIJGHFMNHOP(uint EHEJBHLHAJE)
	{
		if (CAFMJDBBIBL != null)
		{
			CAFMJDBBIBL.set_text(NetworkManager.get_Instance().ALOBHBHLDKK().BGDLPOGFFFA()
				.DIDBDFIHFBP());
			IDGMHANPEEL = 1589f;
		}
	}

	private void EKGHGFIKAAE()
	{
		if (IDGMHANPEEL > 1060f)
		{
			IDGMHANPEEL -= Time.deltaTime;
			if (IDGMHANPEEL < 1506f)
			{
				IDGMHANPEEL = 1437f;
			}
			CAFMJDBBIBL.set_color(new Color(65f, 53f, 1187f, IDGMHANPEEL));
		}
	}

	public void CBNIMGHKEDP(uint EHEJBHLHAJE)
	{
		if (CAFMJDBBIBL != null)
		{
			CAFMJDBBIBL.set_text(NetworkManager.APAPJEIBEDE().get_m_communityNetClient().BGDLPOGFFFA()
				.FGMFMNIPILH());
			IDGMHANPEEL = 359f;
		}
	}

	public void ECMLKDAMCHJ(uint EHEJBHLHAJE)
	{
		if (CAFMJDBBIBL != null)
		{
			CAFMJDBBIBL.DCKJILCPKFD(NetworkManager.APAPJEIBEDE().FGAGFCDEKCC().BGDLPOGFFFA()
				.DIDBDFIHFBP());
			IDGMHANPEEL = 304f;
		}
	}

	private void OCDNPJOPPBB()
	{
		if (IDGMHANPEEL > 26f)
		{
			IDGMHANPEEL -= Time.deltaTime;
			if (IDGMHANPEEL < 25f)
			{
				IDGMHANPEEL = 1371f;
			}
			CAFMJDBBIBL.set_color(new Color(824f, 505f, 336f, IDGMHANPEEL));
		}
	}
}
