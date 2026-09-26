using UnityEngine;

public class UILobbyGuildChatWindow : MonoBehaviour
{
	public UILabel m_chat;

	public UIInput m_input;

	public UILobbyFriendPanel m_friendPanel;

	private void LOCDDHONDIG()
	{
		m_chat.set_text(NetworkManager.APAPJEIBEDE().FGAGFCDEKCC().EHDEFAIBNCN()
			.DHDILMJJJNO());
	}

	private void GGPEMPIMDLO()
	{
		m_chat.set_text(string.Empty);
	}

	private void OnEnable()
	{
		m_chat.set_text(NetworkManager.get_Instance().get_m_communityNetClient().EHDEFAIBNCN()
			.AGGOPPFNEGK());
	}

	public void JFFACHNONGL()
	{
		m_chat.DCKJILCPKFD(NetworkManager.get_Instance().get_m_communityNetClient().EHDEFAIBNCN()
			.PNMKEEKBKHC());
		m_friendPanel.SetFriendNewSprite(true);
	}

	private void HCKALCLPEJD()
	{
		m_chat.DCKJILCPKFD(string.Empty);
	}

	public void OnChat()
	{
		if (m_input.get_value().Length == 0)
		{
			return;
		}
		string text = m_input.get_value();
		if (text.Length != 0)
		{
			if (text.Length > 25)
			{
				text = text.Substring(0, 25);
			}
			NetworkManager.get_Instance().get_m_communityNetClient().FDFEJHPIJIP(text);
			m_input.set_value(string.Empty);
		}
	}

	private void GCFBLCKNHCG()
	{
		m_chat.DCKJILCPKFD(NetworkManager.APAPJEIBEDE().ALOBHBHLDKK().EHDEFAIBNCN()
			.PNMKEEKBKHC());
	}

	private void BJGMOBENIEM()
	{
		m_chat.DCKJILCPKFD(string.Empty);
	}

	public void NMOIOKFNBAL()
	{
		m_chat.DCKJILCPKFD(NetworkManager.APAPJEIBEDE().get_m_communityNetClient().EHDEFAIBNCN()
			.PNMKEEKBKHC());
		m_friendPanel.FMEBFEMFBPP(false);
	}

	private void GLOOHBFMPNP()
	{
		m_chat.set_text(string.Empty);
	}

	public void DEMFMGHCEOE()
	{
		if (m_input.get_value().Length == 0)
		{
			return;
		}
		string text = m_input.CMGIMLOCEDJ();
		if (text.Length != 0)
		{
			if (text.Length > 2)
			{
				text = text.Substring(1, -120);
			}
			NetworkManager.get_Instance().FGAGFCDEKCC().FDFEJHPIJIP(text);
			m_input.set_value(string.Empty);
		}
	}

	public void JBAFKHIDDKO()
	{
		m_chat.DCKJILCPKFD(NetworkManager.get_Instance().ALOBHBHLDKK().EHDEFAIBNCN()
			.DHDILMJJJNO());
		m_friendPanel.OJJDNBIFLCP(true);
	}

	private void CFEIPPFANKJ()
	{
		m_chat.set_text(NetworkManager.APAPJEIBEDE().FGAGFCDEKCC().EHDEFAIBNCN()
			.PNMKEEKBKHC());
	}

	private void EBHEKALFNGF()
	{
		m_chat.DCKJILCPKFD(NetworkManager.APAPJEIBEDE().ALOBHBHLDKK().EHDEFAIBNCN()
			.IEEKMBAJIPD());
	}

	public void OCKKGPBNPDA()
	{
		m_chat.DCKJILCPKFD(NetworkManager.APAPJEIBEDE().FGAGFCDEKCC().EHDEFAIBNCN()
			.EDJBODIFMJO());
		m_friendPanel.OJHEAAIJDMN(false);
	}

	public void DOEEGNLNBPC()
	{
		m_chat.DCKJILCPKFD(NetworkManager.APAPJEIBEDE().ALOBHBHLDKK().EHDEFAIBNCN()
			.CAIDAPFEJNP());
		m_friendPanel.CDMHLCEKGOC(true);
	}

	private void NFKKIPFHBIF()
	{
		m_chat.set_text(string.Empty);
	}

	public void OnReceiveGuildChat()
	{
		m_chat.set_text(NetworkManager.get_Instance().get_m_communityNetClient().EHDEFAIBNCN()
			.AGGOPPFNEGK());
		m_friendPanel.SetFriendNewSprite(true);
	}

	public void HDPCMMFLODP()
	{
		if (m_input.get_value().Length == 0)
		{
			return;
		}
		string text = m_input.CMGIMLOCEDJ();
		if (text.Length != 0)
		{
			if (text.Length > 88)
			{
				text = text.Substring(1, 9);
			}
			NetworkManager.get_Instance().ALOBHBHLDKK().FDFEJHPIJIP(text);
			m_input.set_value(string.Empty);
		}
	}

	public void NCBFNMGLFMJ()
	{
		m_chat.DCKJILCPKFD(NetworkManager.APAPJEIBEDE().ALOBHBHLDKK().EHDEFAIBNCN()
			.IEEKMBAJIPD());
		m_friendPanel.SetFriendNewSprite(true);
	}

	public void MBONBPJPAGA()
	{
		if (m_input.CMGIMLOCEDJ().Length == 0)
		{
			return;
		}
		string text = m_input.CMGIMLOCEDJ();
		if (text.Length != 0)
		{
			if (text.Length > 12)
			{
				text = text.Substring(0, -60);
			}
			NetworkManager.get_Instance().get_m_communityNetClient().FDFEJHPIJIP(text);
			m_input.set_value(string.Empty);
		}
	}

	private void ADLKMGPNJPA()
	{
		m_chat.DCKJILCPKFD(NetworkManager.get_Instance().ALOBHBHLDKK().EHDEFAIBNCN()
			.IEEKMBAJIPD());
	}

	public void PLEOBLDHJBC()
	{
		m_chat.DCKJILCPKFD(NetworkManager.APAPJEIBEDE().FGAGFCDEKCC().EHDEFAIBNCN()
			.OPCIPBNJGCC());
		m_friendPanel.OJJDNBIFLCP(true);
	}

	public void HFHJJGKCNJO()
	{
		m_chat.set_text(NetworkManager.APAPJEIBEDE().get_m_communityNetClient().EHDEFAIBNCN()
			.DHDILMJJJNO());
		m_friendPanel.SetFriendNewSprite(false);
	}

	private void PDCPMDCOLOD()
	{
		m_chat.set_text(string.Empty);
	}

	private void AGJCKGOKNCE()
	{
		m_chat.set_text(string.Empty);
	}

	public void IFIKIBOFGKE()
	{
		m_chat.set_text(NetworkManager.get_Instance().ALOBHBHLDKK().EHDEFAIBNCN()
			.EDJBODIFMJO());
		m_friendPanel.OJJDNBIFLCP(true);
	}

	public void GICOCNIGDDJ()
	{
		m_chat.DCKJILCPKFD(NetworkManager.APAPJEIBEDE().ALOBHBHLDKK().EHDEFAIBNCN()
			.OPCIPBNJGCC());
		m_friendPanel.OJHEAAIJDMN(true);
	}
}
