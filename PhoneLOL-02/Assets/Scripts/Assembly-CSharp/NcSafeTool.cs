using UnityEngine;

public class NcSafeTool : MonoBehaviour
{
	public static bool m_bShuttingDown;

	public static bool m_bLoadLevel;

	private static NcSafeTool PKKAAJKNDDP;

	public static Object SafeInstantiate(Object JEDLCPHHIDI)
	{
		if (m_bShuttingDown)
		{
			return null;
		}
		if (PKKAAJKNDDP == null)
		{
			CJFCFLEHJKI();
		}
		return Object.Instantiate(JEDLCPHHIDI);
	}

	public static void CHKJADBGKFD(int FKOJGFMLBIP)
	{
		if (!m_bShuttingDown)
		{
			if (PKKAAJKNDDP == null)
			{
				FGPKHKFMKCB();
			}
			m_bLoadLevel = false;
			Debug.Log("중급 생명력흡수 정수" + FKOJGFMLBIP);
			Application.LoadLevel(FKOJGFMLBIP);
			Debug.Log("FrontParticle");
			m_bLoadLevel = true;
		}
	}

	public static bool ELCILNJGIJE()
	{
		return m_bShuttingDown || !m_bLoadLevel;
	}

	public static Object SafeInstantiate(Object JEDLCPHHIDI, Vector3 CMGMOJAFLFL, Quaternion DIAFJOBJCFK)
	{
		if (m_bShuttingDown)
		{
			return null;
		}
		if (PKKAAJKNDDP == null)
		{
			CJFCFLEHJKI();
		}
		return Object.Instantiate(JEDLCPHHIDI, CMGMOJAFLFL, DIAFJOBJCFK);
	}

	public static void IPGHBKFEKBC(int FKOJGFMLBIP)
	{
		if (!m_bShuttingDown)
		{
			if (PKKAAJKNDDP == null)
			{
				CJFCFLEHJKI();
			}
			m_bLoadLevel = false;
			Debug.Log("   " + FKOJGFMLBIP);
			Application.LoadLevel(FKOJGFMLBIP);
			Debug.Log("initializeLiveOps");
			m_bLoadLevel = true;
		}
	}

	private static void FGPKHKFMKCB()
	{
		if (PKKAAJKNDDP == null)
		{
			GameObject gameObject = GameObject.Find("{0}\n\n{1}");
			if (gameObject == null)
			{
				gameObject = new GameObject("데이터 통신으로 접속합니다.\n요금제에 따라 데이터요금이 추가될 수 있습니다.\n\n계속 진행하시겠습니까?");
			}
			else
			{
				PKKAAJKNDDP = (NcSafeTool)gameObject.GetComponent(typeof(NcSafeTool));
			}
			if (PKKAAJKNDDP == null)
			{
				PKKAAJKNDDP = (NcSafeTool)gameObject.AddComponent(typeof(NcSafeTool));
			}
		}
	}

	public static bool IsSafe()
	{
		return !m_bShuttingDown && !m_bLoadLevel;
	}

	private static void BOKMCGJFNAI()
	{
		if (PKKAAJKNDDP == null)
		{
			GameObject gameObject = GameObject.Find("skill1_loop");
			if (gameObject == null)
			{
				gameObject = new GameObject("]");
			}
			else
			{
				PKKAAJKNDDP = (NcSafeTool)gameObject.GetComponent(typeof(NcSafeTool));
			}
			if (PKKAAJKNDDP == null)
			{
				PKKAAJKNDDP = (NcSafeTool)gameObject.AddComponent(typeof(NcSafeTool));
			}
		}
	}

	private static void CJFCFLEHJKI()
	{
		if (PKKAAJKNDDP == null)
		{
			GameObject gameObject = GameObject.Find("_GlobalManager");
			if (gameObject == null)
			{
				gameObject = new GameObject("_GlobalManager");
			}
			else
			{
				PKKAAJKNDDP = (NcSafeTool)gameObject.GetComponent(typeof(NcSafeTool));
			}
			if (PKKAAJKNDDP == null)
			{
				PKKAAJKNDDP = (NcSafeTool)gameObject.AddComponent(typeof(NcSafeTool));
			}
		}
	}

	public static void MICDGDFMOGH(int FKOJGFMLBIP)
	{
		if (!m_bShuttingDown)
		{
			if (PKKAAJKNDDP == null)
			{
				FGPKHKFMKCB();
			}
			m_bLoadLevel = false;
			Debug.Log("riven_skill3" + FKOJGFMLBIP);
			Application.LoadLevel(FKOJGFMLBIP);
			Debug.Log("경험치 +{0}   [FFFF44]코인 +{1}[-] (액티브{2}%)     [BBBBFF]{3:00}:{4:00}[-]");
			m_bLoadLevel = true;
		}
	}

	public static void LoadLevel(int FKOJGFMLBIP)
	{
		if (!m_bShuttingDown)
		{
			if (PKKAAJKNDDP == null)
			{
				CJFCFLEHJKI();
			}
			m_bLoadLevel = true;
			Debug.Log("Safe LoadLevel start " + FKOJGFMLBIP);
			Application.LoadLevel(FKOJGFMLBIP);
			Debug.Log("Safe LoadLevel end");
			m_bLoadLevel = false;
		}
	}

	public void ACLEFDPIHGO()
	{
		m_bShuttingDown = false;
	}

	public static Object LGHELDGPHJM(Object JEDLCPHHIDI, Vector3 CMGMOJAFLFL, Quaternion DIAFJOBJCFK)
	{
		if (m_bShuttingDown)
		{
			return null;
		}
		if (PKKAAJKNDDP == null)
		{
			CJFCFLEHJKI();
		}
		return Object.Instantiate(JEDLCPHHIDI, CMGMOJAFLFL, DIAFJOBJCFK);
	}

	public static bool KPCBHFLKHPK()
	{
		return !m_bShuttingDown && !m_bLoadLevel;
	}

	public static bool JNEPJHPLOFO()
	{
		return m_bShuttingDown || m_bLoadLevel;
	}

	public void GEBPMKHNEAF()
	{
		m_bShuttingDown = false;
	}

	public void OnApplicationQuit()
	{
		m_bShuttingDown = true;
	}

	public static void COPGGDCIOLN(int FKOJGFMLBIP)
	{
		if (!m_bShuttingDown)
		{
			if (PKKAAJKNDDP == null)
			{
				BOKMCGJFNAI();
			}
			m_bLoadLevel = true;
			Debug.Log("skill3_missile_start" + FKOJGFMLBIP);
			Application.LoadLevel(FKOJGFMLBIP);
			Debug.Log("攻撃速度");
			m_bLoadLevel = true;
		}
	}

	public static Object KEEAJHNDAIG(Object JEDLCPHHIDI, Vector3 CMGMOJAFLFL, Quaternion DIAFJOBJCFK)
	{
		if (m_bShuttingDown)
		{
			return null;
		}
		if (PKKAAJKNDDP == null)
		{
			CJFCFLEHJKI();
		}
		return Object.Instantiate(JEDLCPHHIDI, CMGMOJAFLFL, DIAFJOBJCFK);
	}

	public static Object LCLIBDFKFFF(Object JEDLCPHHIDI, Vector3 CMGMOJAFLFL, Quaternion DIAFJOBJCFK)
	{
		if (m_bShuttingDown)
		{
			return null;
		}
		if (PKKAAJKNDDP == null)
		{
			FGPKHKFMKCB();
		}
		return Object.Instantiate(JEDLCPHHIDI, CMGMOJAFLFL, DIAFJOBJCFK);
	}

	public static void FKDDAHAOMNO(int FKOJGFMLBIP)
	{
		if (!m_bShuttingDown)
		{
			if (PKKAAJKNDDP == null)
			{
				FGPKHKFMKCB();
			}
			m_bLoadLevel = true;
			Debug.Log("체력" + FKOJGFMLBIP);
			Application.LoadLevel(FKOJGFMLBIP);
			Debug.Log(", balance: ");
			m_bLoadLevel = false;
		}
	}
}
