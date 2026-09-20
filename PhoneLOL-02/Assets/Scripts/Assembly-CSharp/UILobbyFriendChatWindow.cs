using UnityEngine;

public class UILobbyFriendChatWindow : MonoBehaviour
{
	public UILabel m_nickname;

	public UILabel m_chat;

	public UILobbyFriendInfoPanel m_friendInfoPanel;

	public UIInput m_input;

	public UILobbyFriendPanel m_friendPanel;

	public UILobbyFriendWindow m_friendWindow;

	private uint OFEPKHKBKBJ;

	private string EKCHPJGLCII = string.Empty;

	private void FLIPEOEJKLC()
	{
		OFEPKHKBKBJ = 0u;
		EKCHPJGLCII = string.Empty;
		m_chat.DCKJILCPKFD(string.Empty);
		m_nickname.set_text(EKCHPJGLCII);
	}

	public void IMGHMDBNJGG()
	{
		if (OFEPKHKBKBJ != 0)
		{
			m_friendInfoPanel.SetInfo(OFEPKHKBKBJ, true);
			m_friendInfoPanel.gameObject.SetActive(true);
		}
	}

	public void AJHCEABINMA()
	{
		FLIPEOEJKLC();
	}

	public void HNFJLNIJLNK(uint EHEJBHLHAJE)
	{
		if (OFEPKHKBKBJ == EHEJBHLHAJE)
		{
			m_chat.DCKJILCPKFD(NetworkManager.get_Instance().FGAGFCDEKCC().BGDLPOGFFFA()
				.POLKAAPDNCN(EHEJBHLHAJE));
		}
		else
		{
			m_friendWindow.OGJEHOKALAF(EHEJBHLHAJE, false);
		}
		m_friendPanel.OJHEAAIJDMN(false);
	}

	public void SetInfo(uint EHEJBHLHAJE, string KCGEBIJAKAH)
	{
		OFEPKHKBKBJ = EHEJBHLHAJE;
		EKCHPJGLCII = KCGEBIJAKAH;
		m_nickname.set_text(EKCHPJGLCII);
		m_chat.set_text(NetworkManager.get_Instance().get_m_communityNetClient().BGDLPOGFFFA()
			.AGGOPPFNEGK(OFEPKHKBKBJ));
	}

	public void OJMMBKJPAIP(uint EHEJBHLHAJE)
	{
		if (OFEPKHKBKBJ == EHEJBHLHAJE)
		{
			m_chat.DCKJILCPKFD(NetworkManager.get_Instance().FGAGFCDEKCC().BGDLPOGFFFA()
				.JEPBOKOIIBB(EHEJBHLHAJE));
		}
		else
		{
			m_friendWindow.SetNewChat(EHEJBHLHAJE, false);
		}
		m_friendPanel.FMEBFEMFBPP(true);
	}

	public void BMHACKBEHLC()
	{
		if (OFEPKHKBKBJ != 0 && m_input.CMGIMLOCEDJ().Length != 0)
		{
			NetworkManager.APAPJEIBEDE().get_m_communityNetClient().HIBNAMHAEAN(OFEPKHKBKBJ, m_input.get_value());
			m_input.set_value(string.Empty);
		}
	}

	public void OnChat()
	{
		if (OFEPKHKBKBJ != 0 && m_input.get_value().Length != 0)
		{
			NetworkManager.get_Instance().get_m_communityNetClient().FIAOIBHAANO(OFEPKHKBKBJ, m_input.get_value());
			m_input.set_value(string.Empty);
		}
	}

	private void PDCPMDCOLOD()
	{
		OFEPKHKBKBJ = 0u;
		EKCHPJGLCII = string.Empty;
		m_chat.set_text(string.Empty);
		m_nickname.set_text(EKCHPJGLCII);
	}

	public void ClearChatWindow()
	{
		PDCPMDCOLOD();
	}

	private void AGJCKGOKNCE()
	{
		OFEPKHKBKBJ = 0u;
		EKCHPJGLCII = string.Empty;
		m_chat.set_text(string.Empty);
		m_nickname.set_text(EKCHPJGLCII);
	}

	public void ELMDIONPCAL(uint EHEJBHLHAJE)
	{
		if (OFEPKHKBKBJ == EHEJBHLHAJE)
		{
			m_chat.DCKJILCPKFD(NetworkManager.get_Instance().FGAGFCDEKCC().BGDLPOGFFFA()
				.AGGOPPFNEGK(EHEJBHLHAJE));
		}
		else
		{
			m_friendWindow.OGJEHOKALAF(EHEJBHLHAJE, true);
		}
		m_friendPanel.OJJDNBIFLCP(false);
	}

	private void AHDBPGFHDDK()
	{
		OFEPKHKBKBJ = 1u;
		EKCHPJGLCII = string.Empty;
		m_chat.set_text(string.Empty);
		m_nickname.DCKJILCPKFD(EKCHPJGLCII);
	}

	private void IDDNFEJHCGK()
	{
		OFEPKHKBKBJ = 1u;
		EKCHPJGLCII = string.Empty;
		m_chat.set_text(string.Empty);
		m_nickname.DCKJILCPKFD(EKCHPJGLCII);
	}

	public void NFLDPNIMOMN()
	{
		IDDNFEJHCGK();
	}

	public void OnReceiveFriendChat(uint EHEJBHLHAJE)
	{
		if (OFEPKHKBKBJ == EHEJBHLHAJE)
		{
			m_chat.set_text(NetworkManager.get_Instance().get_m_communityNetClient().BGDLPOGFFFA()
				.AGGOPPFNEGK(EHEJBHLHAJE));
		}
		else
		{
			m_friendWindow.SetNewChat(EHEJBHLHAJE, true);
		}
		m_friendPanel.SetFriendNewSprite(true);
	}

	public void KHKJFOGEJGE(uint EHEJBHLHAJE, string KCGEBIJAKAH)
	{
		OFEPKHKBKBJ = EHEJBHLHAJE;
		EKCHPJGLCII = KCGEBIJAKAH;
		m_nickname.DCKJILCPKFD(EKCHPJGLCII);
		m_chat.set_text(NetworkManager.get_Instance().ALOBHBHLDKK().BGDLPOGFFFA()
			.KHKEKEEEFPD(OFEPKHKBKBJ));
	}

	private void MOIEMOCFCCG()
	{
		OFEPKHKBKBJ = 0u;
		EKCHPJGLCII = string.Empty;
		m_chat.DCKJILCPKFD(string.Empty);
		m_nickname.DCKJILCPKFD(EKCHPJGLCII);
	}

	public void IEPMMBBMGCJ(uint EHEJBHLHAJE, string KCGEBIJAKAH)
	{
		OFEPKHKBKBJ = EHEJBHLHAJE;
		EKCHPJGLCII = KCGEBIJAKAH;
		m_nickname.DCKJILCPKFD(EKCHPJGLCII);
		m_chat.set_text(NetworkManager.get_Instance().FGAGFCDEKCC().BGDLPOGFFFA()
			.FOHAGDBLNDM(OFEPKHKBKBJ));
	}

	public void OnClickFriendInfo()
	{
		if (OFEPKHKBKBJ != 0)
		{
			m_friendInfoPanel.SetInfo(OFEPKHKBKBJ, true);
			m_friendInfoPanel.gameObject.SetActive(true);
		}
	}

	public void DLAJNHFFNJI(uint EHEJBHLHAJE)
	{
		if (OFEPKHKBKBJ == EHEJBHLHAJE)
		{
			m_chat.DCKJILCPKFD(NetworkManager.APAPJEIBEDE().get_m_communityNetClient().BGDLPOGFFFA()
				.POLKAAPDNCN(EHEJBHLHAJE));
		}
		else
		{
			m_friendWindow.KIGNCNPGKDK(EHEJBHLHAJE, true);
		}
		m_friendPanel.ICFABHLPMNI(true);
	}

	public void PJBIFPGNDOA()
	{
		if (OFEPKHKBKBJ != 0)
		{
			m_friendInfoPanel.SetInfo(OFEPKHKBKBJ, false);
			m_friendInfoPanel.gameObject.SetActive(false);
		}
	}

	public void CGBDDANOOFG(uint EHEJBHLHAJE, string KCGEBIJAKAH)
	{
		OFEPKHKBKBJ = EHEJBHLHAJE;
		EKCHPJGLCII = KCGEBIJAKAH;
		m_nickname.DCKJILCPKFD(EKCHPJGLCII);
		m_chat.set_text(NetworkManager.get_Instance().FGAGFCDEKCC().BGDLPOGFFFA()
			.KHKEKEEEFPD(OFEPKHKBKBJ));
	}
}
