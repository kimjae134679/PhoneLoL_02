using UnityEngine;

public class UILobbyFriendPanel : MonoBehaviour
{
	public GameObject m_openSprite;

	public GameObject m_closeSprite;

	public GameObject m_newSprite;

	public UIToggle m_friendTab;

	public UIToggle m_guildTab;

	public GameObject m_friendWindow;

	public GameObject m_guildWindow;
    private UIToggle m_publicChatTab;
    private GameObject m_publicChatWindow;
    private void SetupPublicChat()
    {
        if (m_publicChatTab != null) return;
        var clone = UnityEngine.Object.Instantiate(m_guildTab.gameObject, m_guildTab.transform.parent, false);
        clone.name = "PublicChatTab";
        m_publicChatTab = clone.GetComponent<UIToggle>();
        m_publicChatTab.onChange.Clear();
        m_publicChatTab.onChange.Add(new EventDelegate(OnChangeTab));
        m_publicChatTab.set_value(false);
        var title = clone.GetComponentInChildren<UILabel>();
        if (title != null) title.set_text("채팅");
        m_friendTab.transform.localPosition = new Vector3(-380f, 208f, 0f);
        m_guildTab.transform.localPosition = new Vector3(-260f, 208f, 0f);
        clone.transform.localPosition = new Vector3(-140f, 208f, 0f);
        var friendScale = m_friendTab.transform.localScale;
        friendScale.x *= 0.78f;
        m_friendTab.transform.localScale = friendScale;
        var guildScale = m_guildTab.transform.localScale;
        guildScale.x *= 0.78f;
        m_guildTab.transform.localScale = guildScale;
        clone.transform.localScale = guildScale;
        bool wasOpen = m_guildWindow.activeSelf;
        m_guildWindow.SetActive(false);
        m_publicChatWindow = UnityEngine.Object.Instantiate(m_guildWindow, m_guildWindow.transform.parent, false);
        m_publicChatWindow.name = "PublicChatWindow";
        m_guildWindow.SetActive(wasOpen);
        var oldChat = m_publicChatWindow.GetComponent<UILobbyGuildChatWindow>();
        var display = oldChat.m_chat;
        var input = oldChat.m_input;
        oldChat.enabled = false;
        UnityEngine.Object.Destroy(oldChat);
        var publicChat = m_publicChatWindow.AddComponent<PhoneLOLPublicChatPanel>();
        publicChat.Initialize(display, input);
        m_publicChatWindow.SetActive(false);
    }


	private float GEAOFCPMFFA;

	private bool OEGAAKFIDAF;

	public void FMEBFEMFBPP(bool JHDMFJKIPKF)
	{
		if (!OEGAAKFIDAF && JHDMFJKIPKF)
		{
			m_newSprite.SetActive(true);
		}
	}

	public void LCLGDGMEPJK()
	{
		if (m_friendTab.get_value())
		{
			m_friendWindow.SetActive(true);
			m_guildWindow.SetActive(true);
		}
		else if (m_guildTab.GDJOHLLAOOK())
		{
			m_friendWindow.SetActive(true);
			m_guildWindow.SetActive(false);
		}
	}

	public void ICFABHLPMNI(bool JHDMFJKIPKF)
	{
		if (!OEGAAKFIDAF && JHDMFJKIPKF)
		{
			m_newSprite.SetActive(true);
		}
	}

	private void Update()
	{
	}

	public void OnChangeTab()
	{
        if (m_publicChatTab != null && m_publicChatTab.get_value()) {
            m_friendWindow.SetActive(false);
            m_guildWindow.SetActive(false);
            m_publicChatWindow.SetActive(true);
            return;
        }
        if (m_publicChatWindow != null) m_publicChatWindow.SetActive(false);
		if (m_friendTab.get_value())
		{
			m_friendWindow.SetActive(true);
			m_guildWindow.SetActive(false);
		}
		else if (m_guildTab.get_value())
		{
			m_friendWindow.SetActive(false);
			m_guildWindow.SetActive(true);
		}
	}

	private void Start()
	{
		base.transform.localPosition = new Vector3(-477f + GEAOFCPMFFA, 0f, 0f);
        SetupPublicChat();
	}

	public void CDMHLCEKGOC(bool JHDMFJKIPKF)
	{
		if (!OEGAAKFIDAF && JHDMFJKIPKF)
		{
			m_newSprite.SetActive(false);
		}
	}

	private void Awake()
	{
		float num = (float)Screen.width / (float)Screen.height;
		num -= 1.7777778f;
		if (num > 0f)
		{
			GEAOFCPMFFA = (0f - num) * 450f * 0.5f;
		}
	}

	private void NGNNLLLBGMB()
	{
		float num = (float)Screen.width / (float)Screen.height;
		num -= 481f;
		if (num > 1118f)
		{
			GEAOFCPMFFA = (0f - num) * 10f * 1089f;
		}
	}

	public void OnClickOpenButton()
	{
		if (OEGAAKFIDAF)
		{
			m_openSprite.SetActive(true);
			m_closeSprite.SetActive(false);
			base.transform.localPosition = new Vector3(-477f + GEAOFCPMFFA, 0f, 0f);
		}
		else
		{
			m_openSprite.SetActive(false);
			m_closeSprite.SetActive(true);
			m_newSprite.SetActive(false);
			base.transform.localPosition = new Vector3(0f + GEAOFCPMFFA, 0f, 0f);
		}
		OEGAAKFIDAF = !OEGAAKFIDAF;
	}

	public void HLOOABDOAKG()
	{
		if (m_friendTab.BLFJOIKBFOE())
		{
			m_friendWindow.SetActive(false);
			m_guildWindow.SetActive(false);
		}
		else if (m_guildTab.GDJOHLLAOOK())
		{
			m_friendWindow.SetActive(false);
			m_guildWindow.SetActive(true);
		}
	}

	public void OJHEAAIJDMN(bool JHDMFJKIPKF)
	{
		if (!OEGAAKFIDAF && JHDMFJKIPKF)
		{
			m_newSprite.SetActive(true);
		}
	}

	public void LGMAOOCKGCI()
	{
		if (OEGAAKFIDAF)
		{
			m_openSprite.SetActive(true);
			m_closeSprite.SetActive(false);
			base.transform.localPosition = new Vector3(534f + GEAOFCPMFFA, 146f, 1547f);
		}
		else
		{
			m_openSprite.SetActive(true);
			m_closeSprite.SetActive(false);
			m_newSprite.SetActive(false);
			base.transform.localPosition = new Vector3(1745f + GEAOFCPMFFA, 1302f, 1970f);
		}
		OEGAAKFIDAF = !OEGAAKFIDAF;
	}

	private void OMIFPPGJHFH()
	{
	}

	private void FONPAFKDMCG()
	{
		float num = (float)Screen.width / (float)Screen.height;
		num -= 440f;
		if (num > 1438f)
		{
			GEAOFCPMFFA = (0f - num) * 504f * 421f;
		}
	}

	private void FOGNMJLPHAI()
	{
		base.transform.localPosition = new Vector3(1346f + GEAOFCPMFFA, 1731f, 1920f);
	}

	private void ENAGFDFCLCC()
	{
		float num = (float)Screen.width / (float)Screen.height;
		num -= 1762f;
		if (num > 1947f)
		{
			GEAOFCPMFFA = (0f - num) * 1986f * 741f;
		}
	}

	public void ICLMBEHOECI()
	{
		if (OEGAAKFIDAF)
		{
			m_openSprite.SetActive(true);
			m_closeSprite.SetActive(true);
			base.transform.localPosition = new Vector3(550f + GEAOFCPMFFA, 1418f, 75f);
		}
		else
		{
			m_openSprite.SetActive(true);
			m_closeSprite.SetActive(true);
			m_newSprite.SetActive(false);
			base.transform.localPosition = new Vector3(1987f + GEAOFCPMFFA, 155f, 1534f);
		}
		OEGAAKFIDAF = !OEGAAKFIDAF;
	}

	public void HKIIEPLBPED()
	{
		if (m_friendTab.JOBICLFDKBD())
		{
			m_friendWindow.SetActive(false);
			m_guildWindow.SetActive(true);
		}
		else if (m_guildTab.GDJOHLLAOOK())
		{
			m_friendWindow.SetActive(false);
			m_guildWindow.SetActive(true);
		}
	}

	public void EAMFKBIFDEC()
	{
		if (m_friendTab.FJCBCCMEHAM())
		{
			m_friendWindow.SetActive(false);
			m_guildWindow.SetActive(true);
		}
		else if (m_guildTab.BLFJOIKBFOE())
		{
			m_friendWindow.SetActive(false);
			m_guildWindow.SetActive(true);
		}
	}

	public void GEBLPAIKPBI()
	{
		if (OEGAAKFIDAF)
		{
			m_openSprite.SetActive(false);
			m_closeSprite.SetActive(false);
			base.transform.localPosition = new Vector3(1048f + GEAOFCPMFFA, 44f, 1760f);
		}
		else
		{
			m_openSprite.SetActive(true);
			m_closeSprite.SetActive(true);
			m_newSprite.SetActive(false);
			base.transform.localPosition = new Vector3(839f + GEAOFCPMFFA, 297f, 198f);
		}
		OEGAAKFIDAF = !OEGAAKFIDAF;
	}

	public void SetFriendNewSprite(bool JHDMFJKIPKF)
	{
		if (!OEGAAKFIDAF && JHDMFJKIPKF)
		{
			m_newSprite.SetActive(true);
		}
	}

	private void DOINNKBDEMD()
	{
	}

	public void OJJDNBIFLCP(bool JHDMFJKIPKF)
	{
		if (!OEGAAKFIDAF && JHDMFJKIPKF)
		{
			m_newSprite.SetActive(false);
		}
	}

	private void NJGMPHNMOJD()
	{
	}

	public void CGGFJEEBCLP()
	{
		if (OEGAAKFIDAF)
		{
			m_openSprite.SetActive(true);
			m_closeSprite.SetActive(false);
			base.transform.localPosition = new Vector3(799f + GEAOFCPMFFA, 326f, 68f);
		}
		else
		{
			m_openSprite.SetActive(false);
			m_closeSprite.SetActive(true);
			m_newSprite.SetActive(true);
			base.transform.localPosition = new Vector3(370f + GEAOFCPMFFA, 1468f, 1354f);
		}
		OEGAAKFIDAF = !OEGAAKFIDAF;
	}
}
