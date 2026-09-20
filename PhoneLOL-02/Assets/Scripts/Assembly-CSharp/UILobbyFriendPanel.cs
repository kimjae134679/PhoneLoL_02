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
