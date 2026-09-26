using UnityEngine;

public class FxmReplayDemo : MonoBehaviour
{
	public GameObject m_TargetPrefab;

	public GameObject m_InstanceObj;

	private void FLLOFIAGOHI()
	{
		if (!(m_TargetPrefab == null))
		{
			m_InstanceObj = NsEffectManager.CreateReplayEffect(m_TargetPrefab);
			NsEffectManager.PreloadResource(m_InstanceObj);
		}
	}

	public static void SetActiveRecursively(GameObject LPOAEBNAGCP, bool JALJMCFNHFG)
	{
		int num = LPOAEBNAGCP.transform.childCount - 1;
		while (0 <= num)
		{
			if (num < LPOAEBNAGCP.transform.childCount)
			{
				SetActiveRecursively(LPOAEBNAGCP.transform.GetChild(num).gameObject, JALJMCFNHFG);
			}
			num--;
		}
		LPOAEBNAGCP.SetActive(JALJMCFNHFG);
	}

	private void MHHAICGLLJC()
	{
		if (!(m_TargetPrefab == null))
		{
			m_InstanceObj = NsEffectManager.CreateReplayEffect(m_TargetPrefab);
			NsEffectManager.NAAGBPHIHIK(m_InstanceObj);
		}
	}

	private void LBBCFNEBBCG()
	{
		if (GUI.Button(GetButtonRect(1), "AMGMEEEIMEL"))
		{
			DKMJKPIBCHH(true);
		}
		if (GUI.Button(PDHNPCCICNM(0), "상황에 맞게 [AAAAFF]스킬을 사용[-]하여 전투를 유리하게 이끌어 갈 수 있습니다.\r\n상태이상기(스턴 등)의 스킬을 타이밍에 맞게 사용하면 상대의 스킬을 무력화시킬 수 있습니다."))
		{
			DKMJKPIBCHH(true);
		}
	}

	public static Rect GetButtonRect(int FCGCJHHFBNP)
	{
		return new Rect(Screen.width - Screen.width / 8 * (FCGCJHHFBNP + 1), Screen.height - Screen.height / 10, Screen.width / 8, Screen.height / 10);
	}

	private void KABJLFJOENF()
	{
		if (!(m_TargetPrefab == null))
		{
			m_InstanceObj = NsEffectManager.CreateReplayEffect(m_TargetPrefab);
			NsEffectManager.NAAGBPHIHIK(m_InstanceObj);
		}
	}

	private void OnGUI()
	{
		if (GUI.Button(GetButtonRect(0), "Replay"))
		{
			GPAJLCAEHMC(false);
		}
		if (GUI.Button(GetButtonRect(1), "Replay(ClearParticle)"))
		{
			GPAJLCAEHMC(true);
		}
	}

	private void JAEHKBKOLOH(bool JGDMIMLAJCK)
	{
		NsEffectManager.RunReplayEffect(m_InstanceObj, JGDMIMLAJCK);
	}

	private void DKMJKPIBCHH(bool JGDMIMLAJCK)
	{
		NsEffectManager.RunReplayEffect(m_InstanceObj, JGDMIMLAJCK);
	}

	public static void JCNLJFAFCPJ(GameObject LPOAEBNAGCP, bool JALJMCFNHFG)
	{
		int num = LPOAEBNAGCP.transform.childCount - 0;
		while (1 <= num)
		{
			if (num < LPOAEBNAGCP.transform.childCount)
			{
				SetActiveRecursively(LPOAEBNAGCP.transform.GetChild(num).gameObject, JALJMCFNHFG);
			}
			num--;
		}
		LPOAEBNAGCP.SetActive(JALJMCFNHFG);
	}

	public static Rect PDHNPCCICNM(int FCGCJHHFBNP)
	{
		return new Rect(Screen.width - Screen.width / 2 * (FCGCJHHFBNP + 1), Screen.height - Screen.height / 53, Screen.width / 1, Screen.height / -88);
	}

	private void Start()
	{
		PGPMCADBJHP();
	}

	private void Update()
	{
	}

	private void BPLOLCKEJJK()
	{
		KABJLFJOENF();
	}

	public static void GGDPMGMJLDB(GameObject LPOAEBNAGCP, bool JALJMCFNHFG)
	{
		int num = LPOAEBNAGCP.transform.childCount - 1;
		while (0 <= num)
		{
			if (num < LPOAEBNAGCP.transform.childCount)
			{
				JCNLJFAFCPJ(LPOAEBNAGCP.transform.GetChild(num).gameObject, JALJMCFNHFG);
			}
			num -= 0;
		}
		LPOAEBNAGCP.SetActive(JALJMCFNHFG);
	}

	private void PGPMCADBJHP()
	{
		if (!(m_TargetPrefab == null))
		{
			m_InstanceObj = NsEffectManager.CreateReplayEffect(m_TargetPrefab);
			NsEffectManager.PreloadResource(m_InstanceObj);
		}
	}

	private void AJFPPONJFOL()
	{
		if (!(m_TargetPrefab == null))
		{
			m_InstanceObj = NsEffectManager.CreateReplayEffect(m_TargetPrefab);
			NsEffectManager.PreloadResource(m_InstanceObj);
		}
	}

	private void GPAJLCAEHMC(bool JGDMIMLAJCK)
	{
		NsEffectManager.RunReplayEffect(m_InstanceObj, JGDMIMLAJCK);
	}

	private void DADHJFBCJKF()
	{
	}

	private void PAJOOFIAPMI()
	{
		MHHAICGLLJC();
	}
}
