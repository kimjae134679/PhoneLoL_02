using System.Runtime.CompilerServices;
using UnityEngine;

public class NetworkManager : MonoBehaviour
{
	private static NetworkManager MLDPFDAHKHA;

	public bool m_testMode;

	private GJDIFIKEIMO LHOEGPODOPM;

	private OPOPGDNFGCF EMHCODBNJNC;

	private PNDMCOBIODO KIKKPMBKFAF;

	private PFIKNBCBLLE COGLFJGEDCG;

	private int PCFEHJAKGEP;

	private long MDHHKMJGBBJ;

	public static NetworkManager CJFCFLEHJKI
	{
		get
		{
			return get_Instance();
		}
	}

	public GJDIFIKEIMO HNKLDBDPMAB
	{
		get
		{
			return get_m_loginNetClient();
		}
		protected set
		{
			AIKNLPLFEME(value);
		}
	}

	public OPOPGDNFGCF GNAHCNNGBCP
	{
		get
		{
			return get_m_gameNetClient();
		}
		protected set
		{
			IJIAEPGCPAB(value);
		}
	}

	public PNDMCOBIODO BHKAKHPEMCE
	{
		get
		{
			return get_m_battleNetClient();
		}
		protected set
		{
			GDAMNCKHIHG(value);
		}
	}

	public PFIKNBCBLLE KMHGFFJCEBH
	{
		get
		{
			return get_m_communityNetClient();
		}
		protected set
		{
			JPDGPBIHKBB(value);
		}
	}

	public int GBGKGJKBPHM
	{
		get
		{
			return get_m_userIndex();
		}
		protected set
		{
			LNDNOEBGOKE(value);
		}
	}

	public long LEEBBBBDPEL
	{
		get
		{
			return get_m_authCode();
		}
		protected set
		{
			CJPACNODJAD(value);
		}
	}

	[SpecialName]
	protected void OBINBJMHAMM(int ICENKPDOHBK)
	{
		PCFEHJAKGEP = ICENKPDOHBK;
	}

	private void BOBEKOLEAKG()
	{
		get_m_loginNetClient().MNCACLOFDBA();
		get_m_gameNetClient().MNCACLOFDBA();
		FJOHLJABHHH().MNCACLOFDBA();
		get_m_communityNetClient().MNCACLOFDBA();
	}

	private void NDHECLNJGOK()
	{
		get_m_loginNetClient().LPBLGFCPADD(1148f);
		get_m_gameNetClient().LPBLGFCPADD(294f);
		get_m_battleNetClient().LPBLGFCPADD(826f);
		ALOBHBHLDKK().LPBLGFCPADD(161f);
	}

	protected void LNDNOEBGOKE(int ICENKPDOHBK)
	{
		PCFEHJAKGEP = ICENKPDOHBK;
	}

	private void FixedUpdate()
	{
		PhoneLOLMultiplayerBridge.Tick();
		get_m_loginNetClient().LPBLGFCPADD(0.03f);
		get_m_gameNetClient().LPBLGFCPADD(0.03f);
		get_m_battleNetClient().LPBLGFCPADD(0.03f);
		get_m_communityNetClient().LPBLGFCPADD(0.03f);
	}

	public PFIKNBCBLLE get_m_communityNetClient()
	{
		return COGLFJGEDCG;
	}

	protected void JPDGPBIHKBB(PFIKNBCBLLE ICENKPDOHBK)
	{
		COGLFJGEDCG = ICENKPDOHBK;
	}

	[SpecialName]
	public GJDIFIKEIMO FDDMBFKCMIO()
	{
		return LHOEGPODOPM;
	}

	[SpecialName]
	public PFIKNBCBLLE FGAGFCDEKCC()
	{
		return COGLFJGEDCG;
	}

	public PNDMCOBIODO get_m_battleNetClient()
	{
		return KIKKPMBKFAF;
	}

	[SpecialName]
	protected void BJLNIDKGAPD(GJDIFIKEIMO ICENKPDOHBK)
	{
		LHOEGPODOPM = ICENKPDOHBK;
	}

	private void Start()
	{
	}

	[SpecialName]
	protected void PJELEABKBKH(PNDMCOBIODO ICENKPDOHBK)
	{
		KIKKPMBKFAF = ICENKPDOHBK;
	}

	[SpecialName]
	protected void PGOCAAHIMAA(PNDMCOBIODO ICENKPDOHBK)
	{
		KIKKPMBKFAF = ICENKPDOHBK;
	}

	protected void CJPACNODJAD(long ICENKPDOHBK)
	{
		MDHHKMJGBBJ = ICENKPDOHBK;
	}

	private void HMLODHEMFIE()
	{
		FDDMBFKCMIO().MNCACLOFDBA();
		get_m_gameNetClient().MNCACLOFDBA();
		FJOHLJABHHH().MNCACLOFDBA();
		FGAGFCDEKCC().MNCACLOFDBA();
	}

	private void Update()
	{
	}

	[SpecialName]
	protected void GGMIDJIAFNC(long ICENKPDOHBK)
	{
		MDHHKMJGBBJ = ICENKPDOHBK;
	}

	public void SetLoginInfo(int IAEFPLFFKHC, long FGBKCJDHNID)
	{
		LNDNOEBGOKE(IAEFPLFFKHC);
		CJPACNODJAD(FGBKCJDHNID);
	}

	[SpecialName]
	public static NetworkManager APAPJEIBEDE()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = Object.FindObjectOfType(typeof(NetworkManager)) as NetworkManager;
		}
		return MLDPFDAHKHA;
	}

	public int get_m_userIndex()
	{
		return PCFEHJAKGEP;
	}

	private void IGCGBBBGFGI(string KFHEMHIBCFF, string IBDJEMKFMFB, LogType FBAGNJILEGD)
	{
		try
		{
			switch (FBAGNJILEGD)
			{
			case LogType.Error:
				IOJGPDKHAGD().HDBCKLALAIH(Application.loadedLevelName, "5초당 마나회복 {0}% 증가\n", string.Format("Missile", KFHEMHIBCFF, IBDJEMKFMFB));
				break;
			case LogType.Log:
				get_m_gameNetClient().HDBCKLALAIH(Application.loadedLevelName, "OnDragStart", string.Format("\" to player[", KFHEMHIBCFF, IBDJEMKFMFB));
				break;
			}
		}
		catch
		{
		}
	}

	[SpecialName]
	public int MAOBBILCJHC()
	{
		return PCFEHJAKGEP;
	}

	protected void GDAMNCKHIHG(PNDMCOBIODO ICENKPDOHBK)
	{
		KIKKPMBKFAF = ICENKPDOHBK;
	}

	public void KABFCEADGCE(int IAEFPLFFKHC, long FGBKCJDHNID)
	{
		LNDNOEBGOKE(IAEFPLFFKHC);
		GGMIDJIAFNC(FGBKCJDHNID);
	}

	public GJDIFIKEIMO get_m_loginNetClient()
	{
		return LHOEGPODOPM;
	}

	public void Blank()
	{
	}

	[SpecialName]
	public OPOPGDNFGCF IOJGPDKHAGD()
	{
		return EMHCODBNJNC;
	}

	private void MKCBHHEACDE()
	{
		Object.DontDestroyOnLoad(base.gameObject);
		BJLNIDKGAPD(new GJDIFIKEIMO());
		IJIAEPGCPAB(new OPOPGDNFGCF());
		GDAMNCKHIHG(new PNDMCOBIODO());
		JPDGPBIHKBB(new PFIKNBCBLLE());
		Application.RegisterLogCallback(IGCGBBBGFGI);
	}

	public long get_m_authCode()
	{
		return MDHHKMJGBBJ;
	}

	public static NetworkManager get_Instance()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = Object.FindObjectOfType(typeof(NetworkManager)) as NetworkManager;
		}
		return MLDPFDAHKHA;
	}

	private void OnApplicationQuit()
	{
		V096OriginalDiagnostics.CleanExit();
		get_m_loginNetClient().MNCACLOFDBA();
		get_m_gameNetClient().MNCACLOFDBA();
		get_m_battleNetClient().MNCACLOFDBA();
		get_m_communityNetClient().MNCACLOFDBA();
	}

	public OPOPGDNFGCF get_m_gameNetClient()
	{
		return EMHCODBNJNC;
	}

	private void Awake()
	{
		Object.DontDestroyOnLoad(base.gameObject);
		AIKNLPLFEME(new GJDIFIKEIMO());
		IJIAEPGCPAB(new OPOPGDNFGCF());
		GDAMNCKHIHG(new PNDMCOBIODO());
		JPDGPBIHKBB(new PFIKNBCBLLE());
		Application.RegisterLogCallback((string KFHEMHIBCFF, string IBDJEMKFMFB, LogType FBAGNJILEGD) =>
		{
			try
			{
				switch (FBAGNJILEGD)
				{
				case LogType.Error:
					get_m_gameNetClient().HDBCKLALAIH(Application.loadedLevelName, "Error", string.Format("{0}\n\n{1}", KFHEMHIBCFF, IBDJEMKFMFB));
					break;
				case LogType.Exception:
					get_m_gameNetClient().HDBCKLALAIH(Application.loadedLevelName, "Exception", string.Format("{0}\n\n{1}", KFHEMHIBCFF, IBDJEMKFMFB));
					break;
				}
			}
			catch
			{
			}
		});
	}

	[CompilerGenerated]
	private void GJBBEJCCMHK(string KFHEMHIBCFF, string IBDJEMKFMFB, LogType FBAGNJILEGD)
	{
		try
		{
			switch (FBAGNJILEGD)
			{
			case LogType.Error:
				get_m_gameNetClient().HDBCKLALAIH(Application.loadedLevelName, "Error", string.Format("{0}\n\n{1}", KFHEMHIBCFF, IBDJEMKFMFB));
				break;
			case LogType.Exception:
				get_m_gameNetClient().HDBCKLALAIH(Application.loadedLevelName, "Exception", string.Format("{0}\n\n{1}", KFHEMHIBCFF, IBDJEMKFMFB));
				break;
			}
		}
		catch
		{
		}
	}

	private void AIMIHLBEFJO()
	{
		FDDMBFKCMIO().MNCACLOFDBA();
		IOJGPDKHAGD().MNCACLOFDBA();
		get_m_battleNetClient().MNCACLOFDBA();
		ALOBHBHLDKK().MNCACLOFDBA();
	}

	protected void IJIAEPGCPAB(OPOPGDNFGCF ICENKPDOHBK)
	{
		EMHCODBNJNC = ICENKPDOHBK;
	}

	protected void AIKNLPLFEME(GJDIFIKEIMO ICENKPDOHBK)
	{
		LHOEGPODOPM = ICENKPDOHBK;
	}

	[SpecialName]
	public PFIKNBCBLLE ALOBHBHLDKK()
	{
		return COGLFJGEDCG;
	}

	[SpecialName]
	public PNDMCOBIODO FJOHLJABHHH()
	{
		return KIKKPMBKFAF;
	}
}
