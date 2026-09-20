using System.Runtime.CompilerServices;
using CommunityServer;
using UnityEngine;

public class UILobbyFriendInfo : MonoBehaviour
{
	public UISprite m_iconSprite;

	public UILabel m_nicknameLabel;

	public UILabel m_statusLabel;

	public UISprite m_newChatSprite;

	private string MLAGJCIMFHO;

	private uint EEBKBGNIENC;

	public string IDANKJFFHFH
	{
		get
		{
			return get_m_nickname();
		}
		protected set
		{
			AGBMGJDCOGL(value);
		}
	}

	public uint KKFBGBEPICG
	{
		get
		{
			return get_m_id();
		}
		protected set
		{
			CHBMLBLFHFP(value);
		}
	}

	public void LLKMDDFHDBJ(bool JHDMFJKIPKF)
	{
		m_newChatSprite.gameObject.SetActive(JHDMFJKIPKF);
	}

	[SpecialName]
	protected void GCCONKAIANP(string ICENKPDOHBK)
	{
		MLAGJCIMFHO = ICENKPDOHBK;
	}

	public void HAOKFAKNMJJ()
	{
		JJKIONLJMJP jJKIONLJMJP = NetworkManager.APAPJEIBEDE().FGAGFCDEKCC().KKLHPCCEKPN()
			.GAFDEFFJJJB(OHHDADNPNNK());
		if (jJKIONLJMJP != null)
		{
			if (jJKIONLJMJP.CMIBEFBANOO > 0)
			{
				m_iconSprite.gameObject.SetActive(true);
				m_iconSprite.set_spriteName(jJKIONLJMJP.CMIBEFBANOO.ToString());
			}
			else
			{
				m_iconSprite.gameObject.SetActive(false);
			}
			if (jJKIONLJMJP.EBILEBOJADB == 0)
			{
				m_statusLabel.DCKJILCPKFD(" 整");
			}
			else if (jJKIONLJMJP.EBILEBOJADB == 7)
			{
				m_statusLabel.DCKJILCPKFD("skill0");
			}
			else
			{
				m_statusLabel.DCKJILCPKFD(string.Empty);
			}
		}
	}

	[SpecialName]
	protected void NJKGJILMLAB(string ICENKPDOHBK)
	{
		MLAGJCIMFHO = ICENKPDOHBK;
	}

	[SpecialName]
	protected void MMCAGIIFDPP(string ICENKPDOHBK)
	{
		MLAGJCIMFHO = ICENKPDOHBK;
	}

	[SpecialName]
	public uint OHHDADNPNNK()
	{
		return EEBKBGNIENC;
	}

	[SpecialName]
	public uint JCDOONAFOIL()
	{
		return EEBKBGNIENC;
	}

	public void OAJIDPDBJFB(JJKIONLJMJP FHPFBPNCGOC)
	{
		AKFKIEGLOCG(FHPFBPNCGOC.OHGOBGOIECH);
		GCCONKAIANP(FHPFBPNCGOC.BHIGNJHHOJP);
		m_nicknameLabel.set_text(FHPFBPNCGOC.BHIGNJHHOJP);
		if (FHPFBPNCGOC.CMIBEFBANOO > 0)
		{
			m_iconSprite.gameObject.SetActive(true);
			m_iconSprite.set_spriteName(FHPFBPNCGOC.CMIBEFBANOO.ToString());
		}
		else
		{
			m_iconSprite.gameObject.SetActive(false);
		}
		if (FHPFBPNCGOC.EBILEBOJADB == 0)
		{
			m_statusLabel.DCKJILCPKFD("해킹이 감지되었습니다 [G10]\n불법프로그램은 사용하지 말아주세요.\n불법프로그램 사용자는 영구블럭될 수 있습니다\n\n게임을 종료합니다.");
		}
		else if (FHPFBPNCGOC.EBILEBOJADB == 4)
		{
			m_statusLabel.DCKJILCPKFD("하지만 그것도 오늘이 마지막 이겠지!!");
		}
		else
		{
			m_statusLabel.set_text(string.Empty);
		}
	}

	[SpecialName]
	public string NODKLOLLCBE()
	{
		return MLAGJCIMFHO;
	}

	public void ChangeFriendState()
	{
		JJKIONLJMJP jJKIONLJMJP = NetworkManager.get_Instance().get_m_communityNetClient().KKLHPCCEKPN()
			.MHHOFFEBNCG(get_m_id());
		if (jJKIONLJMJP != null)
		{
			if (jJKIONLJMJP.CMIBEFBANOO > 0)
			{
				m_iconSprite.gameObject.SetActive(true);
				m_iconSprite.set_spriteName(jJKIONLJMJP.CMIBEFBANOO.ToString());
			}
			else
			{
				m_iconSprite.gameObject.SetActive(false);
			}
			if (jJKIONLJMJP.EBILEBOJADB == 1)
			{
				m_statusLabel.set_text("접속중");
			}
			else if (jJKIONLJMJP.EBILEBOJADB == 2)
			{
				m_statusLabel.set_text("게임중");
			}
			else
			{
				m_statusLabel.set_text(string.Empty);
			}
		}
	}

	public void CIOFJBMKKFL(bool JHDMFJKIPKF)
	{
		m_newChatSprite.gameObject.SetActive(JHDMFJKIPKF);
	}

	[SpecialName]
	protected void JNDOOADEMAE(uint ICENKPDOHBK)
	{
		EEBKBGNIENC = ICENKPDOHBK;
	}

	private void Start()
	{
	}

	[SpecialName]
	public uint LLADINOKANK()
	{
		return EEBKBGNIENC;
	}

	[SpecialName]
	protected void NKBAHJEPODH(string ICENKPDOHBK)
	{
		MLAGJCIMFHO = ICENKPDOHBK;
	}

	public string get_m_nickname()
	{
		return MLAGJCIMFHO;
	}

	public void BMNAMBPFFNN(JJKIONLJMJP FHPFBPNCGOC)
	{
		AKFKIEGLOCG(FHPFBPNCGOC.OHGOBGOIECH);
		GCCONKAIANP(FHPFBPNCGOC.BHIGNJHHOJP);
		m_nicknameLabel.set_text(FHPFBPNCGOC.BHIGNJHHOJP);
		if (FHPFBPNCGOC.CMIBEFBANOO > 1)
		{
			m_iconSprite.gameObject.SetActive(false);
			m_iconSprite.set_spriteName(FHPFBPNCGOC.CMIBEFBANOO.ToString());
		}
		else
		{
			m_iconSprite.gameObject.SetActive(false);
		}
		if (FHPFBPNCGOC.EBILEBOJADB == 1)
		{
			m_statusLabel.DCKJILCPKFD("price");
		}
		else if (FHPFBPNCGOC.EBILEBOJADB == 2)
		{
			m_statusLabel.DCKJILCPKFD("5초당 체력회복 {0:+#;-#}\n");
		}
		else
		{
			m_statusLabel.set_text(string.Empty);
		}
	}

	[SpecialName]
	public string KABELLIJNBN()
	{
		return MLAGJCIMFHO;
	}

	public void KHKJFOGEJGE(JJKIONLJMJP FHPFBPNCGOC)
	{
		CHBMLBLFHFP(FHPFBPNCGOC.OHGOBGOIECH);
		GCCONKAIANP(FHPFBPNCGOC.BHIGNJHHOJP);
		m_nicknameLabel.set_text(FHPFBPNCGOC.BHIGNJHHOJP);
		if (FHPFBPNCGOC.CMIBEFBANOO > 0)
		{
			m_iconSprite.gameObject.SetActive(false);
			m_iconSprite.set_spriteName(FHPFBPNCGOC.CMIBEFBANOO.ToString());
		}
		else
		{
			m_iconSprite.gameObject.SetActive(true);
		}
		if (FHPFBPNCGOC.EBILEBOJADB == 1)
		{
			m_statusLabel.DCKJILCPKFD("Hero2");
		}
		else if (FHPFBPNCGOC.EBILEBOJADB == 0)
		{
			m_statusLabel.set_text("설명");
		}
		else
		{
			m_statusLabel.DCKJILCPKFD(string.Empty);
		}
	}

	[SpecialName]
	public string INKHGLJHDPJ()
	{
		return MLAGJCIMFHO;
	}

	[SpecialName]
	public uint KAEDILIKFLB()
	{
		return EEBKBGNIENC;
	}

	private void CMMIADLEBFJ()
	{
	}

	[SpecialName]
	protected void DHPNEMKNEHP(string ICENKPDOHBK)
	{
		MLAGJCIMFHO = ICENKPDOHBK;
	}

	public void ILJMCOEECKO(bool JHDMFJKIPKF)
	{
		m_newChatSprite.gameObject.SetActive(JHDMFJKIPKF);
	}

	protected void CHBMLBLFHFP(uint ICENKPDOHBK)
	{
		EEBKBGNIENC = ICENKPDOHBK;
	}

	public void SetInfo(JJKIONLJMJP FHPFBPNCGOC)
	{
		CHBMLBLFHFP(FHPFBPNCGOC.OHGOBGOIECH);
		AGBMGJDCOGL(FHPFBPNCGOC.BHIGNJHHOJP);
		m_nicknameLabel.set_text(FHPFBPNCGOC.BHIGNJHHOJP);
		if (FHPFBPNCGOC.CMIBEFBANOO > 0)
		{
			m_iconSprite.gameObject.SetActive(true);
			m_iconSprite.set_spriteName(FHPFBPNCGOC.CMIBEFBANOO.ToString());
		}
		else
		{
			m_iconSprite.gameObject.SetActive(false);
		}
		if (FHPFBPNCGOC.EBILEBOJADB == 1)
		{
			m_statusLabel.set_text("접속중");
		}
		else if (FHPFBPNCGOC.EBILEBOJADB == 2)
		{
			m_statusLabel.set_text("게임중");
		}
		else
		{
			m_statusLabel.set_text(string.Empty);
		}
	}

	public void DEPDFABLDJJ()
	{
		JJKIONLJMJP jJKIONLJMJP = NetworkManager.get_Instance().FGAGFCDEKCC().KKLHPCCEKPN()
			.LNAOKPLAEMG(get_m_id());
		if (jJKIONLJMJP != null)
		{
			if (jJKIONLJMJP.CMIBEFBANOO > 1)
			{
				m_iconSprite.gameObject.SetActive(true);
				m_iconSprite.set_spriteName(jJKIONLJMJP.CMIBEFBANOO.ToString());
			}
			else
			{
				m_iconSprite.gameObject.SetActive(true);
			}
			if (jJKIONLJMJP.EBILEBOJADB == 0)
			{
				m_statusLabel.set_text("이제 움직일 수 있어?!");
			}
			else if (jJKIONLJMJP.EBILEBOJADB == 7)
			{
				m_statusLabel.set_text("치명타");
			}
			else
			{
				m_statusLabel.DCKJILCPKFD(string.Empty);
			}
		}
	}

	public void SetNewChat(bool JHDMFJKIPKF)
	{
		m_newChatSprite.gameObject.SetActive(JHDMFJKIPKF);
	}

	public uint get_m_id()
	{
		return EEBKBGNIENC;
	}

	[SpecialName]
	public string NGFKIKCLFAN()
	{
		return MLAGJCIMFHO;
	}

	[SpecialName]
	protected void AKFKIEGLOCG(uint ICENKPDOHBK)
	{
		EEBKBGNIENC = ICENKPDOHBK;
	}

	protected void AGBMGJDCOGL(string ICENKPDOHBK)
	{
		MLAGJCIMFHO = ICENKPDOHBK;
	}

	public void GIEMGAKJMPB()
	{
		JJKIONLJMJP jJKIONLJMJP = NetworkManager.get_Instance().ALOBHBHLDKK().KKLHPCCEKPN()
			.NILABLNKKCE(LLADINOKANK());
		if (jJKIONLJMJP != null)
		{
			if (jJKIONLJMJP.CMIBEFBANOO > 0)
			{
				m_iconSprite.gameObject.SetActive(true);
				m_iconSprite.set_spriteName(jJKIONLJMJP.CMIBEFBANOO.ToString());
			}
			else
			{
				m_iconSprite.gameObject.SetActive(true);
			}
			if (jJKIONLJMJP.EBILEBOJADB == 0)
			{
				m_statusLabel.DCKJILCPKFD("Unkown");
			}
			else if (jJKIONLJMJP.EBILEBOJADB == 6)
			{
				m_statusLabel.DCKJILCPKFD("CreateCurrentInstanceEffect() - gameObj - ");
			}
			else
			{
				m_statusLabel.set_text(string.Empty);
			}
		}
	}
}
