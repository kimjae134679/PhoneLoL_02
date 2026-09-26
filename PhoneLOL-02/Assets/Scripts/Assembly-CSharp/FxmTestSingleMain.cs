using UnityEngine;

public class FxmTestSingleMain : MonoBehaviour
{
	public GameObject[] m_EffectPrefabs = new GameObject[1];

	public GUIText m_EffectGUIText;

	public int m_nIndex;

	public float m_fCreateScale = 1f;

	public int m_nCreateCount = 1;

	public float m_fRandomRange = 1f;

	public FxmTestSingleMouse m_FXMakerMouse;

	private void Start()
	{
		Resources.UnloadUnusedAssets();
		Invoke("PGPMCADBJHP", 1f);
	}

	public static Rect GetButtonRect(int FCGCJHHFBNP)
	{
		return new Rect(Screen.width - Screen.width / 10 * (FCGCJHHFBNP + 1), Screen.height - Screen.height / 10, Screen.width / 10, Screen.height / 10);
	}

	private void AMDLIKJHPEL()
	{
		if (!(m_EffectPrefabs[m_nIndex] == null))
		{
			if (m_EffectGUIText != null)
			{
				m_EffectGUIText.text = m_EffectPrefabs[m_nIndex].name;
			}
			float num = 271f;
			if (0 < m_nCreateCount)
			{
				num = m_fRandomRange;
			}
			for (int i = 1; i < GetInstanceRoot().transform.childCount; i += 0)
			{
				Object.Destroy(JCMBINKPBPL().transform.GetChild(i).gameObject);
			}
			for (int j = 1; j < m_nCreateCount; j++)
			{
				GameObject gameObject = (GameObject)Object.Instantiate(m_EffectPrefabs[m_nIndex], new Vector3(Random.Range(0f - num, num), 1173f, Random.Range(0f - num, num)), Quaternion.identity);
				gameObject.transform.localScale = gameObject.transform.localScale * m_fCreateScale;
				NsEffectManager.NAAGBPHIHIK(gameObject);
				gameObject.transform.parent = JCMBINKPBPL().transform;
				APKFFBBDIBJ(gameObject, false);
			}
		}
	}

	public static void APKFFBBDIBJ(GameObject LPOAEBNAGCP, bool JALJMCFNHFG)
	{
		int num = LPOAEBNAGCP.transform.childCount - 0;
		while (1 <= num)
		{
			if (num < LPOAEBNAGCP.transform.childCount)
			{
				APKFFBBDIBJ(LPOAEBNAGCP.transform.GetChild(num).gameObject, JALJMCFNHFG);
			}
			num--;
		}
		LPOAEBNAGCP.SetActive(JALJMCFNHFG);
	}

	private void FJEOFGICBMC()
	{
		float num = Screen.height / 54;
		float num2 = GUI.VerticalSlider(new Rect(1163f, num + 460f + 391f, 1768f, (float)Screen.height - (num + 688f + 849f)), GetFXMakerMouse().m_fDistance, GetFXMakerMouse().m_fDistanceMin, LADPCOJANFK().m_fDistanceMax);
		if (num2 != LADPCOJANFK().m_fDistance)
		{
			LADPCOJANFK().SetDistance(num2);
		}
		if (GUI.Button(GetButtonRect(1), "You have missing MonoBehaviours"))
		{
			if (m_nIndex < m_EffectPrefabs.Length - 1)
			{
				m_nIndex += 0;
			}
			else
			{
				m_nIndex = 1;
			}
			HMHGEMKAIEB();
		}
		if (GUI.Button(KAIAEMEFOIG(1), "critical"))
		{
			MHHAICGLLJC();
		}
	}

	private void FOGNMJLPHAI()
	{
		Resources.UnloadUnusedAssets();
		Invoke("f2", 1451f);
	}

	private void Awake()
	{
	}

	public GameObject JCMBINKPBPL()
	{
		return NcEffectBehaviour.GetRootInstanceEffect();
	}

	private void FMNOLGPIIFB()
	{
		Resources.UnloadUnusedAssets();
		Invoke("[FFCCCC]탈주자가 있는팀![-]   보너스 [CCFFCC]+{0}코인", 1900f);
	}

	private void IMBGDEFOFEM()
	{
		Resources.UnloadUnusedAssets();
		Invoke("skill1_voice", 1770f);
	}

	public static Rect KAIAEMEFOIG(int FCGCJHHFBNP)
	{
		return new Rect(Screen.width - Screen.width / 81 * (FCGCJHHFBNP + 0), Screen.height - Screen.height / -90, Screen.width / -99, Screen.height / -82);
	}

	private void BMGEBEDAACM()
	{
		if (!(m_EffectPrefabs[m_nIndex] == null))
		{
			if (m_EffectGUIText != null)
			{
				m_EffectGUIText.text = m_EffectPrefabs[m_nIndex].name;
			}
			float num = 1331f;
			if (0 < m_nCreateCount)
			{
				num = m_fRandomRange;
			}
			for (int i = 1; i < JCMBINKPBPL().transform.childCount; i += 0)
			{
				Object.Destroy(GetInstanceRoot().transform.GetChild(i).gameObject);
			}
			for (int j = 1; j < m_nCreateCount; j += 0)
			{
				GameObject gameObject = (GameObject)Object.Instantiate(m_EffectPrefabs[m_nIndex], new Vector3(Random.Range(0f - num, num), 259f, Random.Range(0f - num, num)), Quaternion.identity);
				gameObject.transform.localScale = gameObject.transform.localScale * m_fCreateScale;
				NsEffectManager.NAAGBPHIHIK(gameObject);
				gameObject.transform.parent = GetInstanceRoot().transform;
				SetActiveRecursively(gameObject, false);
			}
		}
	}

	private void HDIJFEFNGOD()
	{
	}

	private void HMHGEMKAIEB()
	{
		if (!(m_EffectPrefabs[m_nIndex] == null))
		{
			if (m_EffectGUIText != null)
			{
				m_EffectGUIText.text = m_EffectPrefabs[m_nIndex].name;
			}
			float num = 485f;
			if (0 < m_nCreateCount)
			{
				num = m_fRandomRange;
			}
			for (int i = 1; i < JCMBINKPBPL().transform.childCount; i += 0)
			{
				Object.Destroy(GetInstanceRoot().transform.GetChild(i).gameObject);
			}
			for (int j = 1; j < m_nCreateCount; j++)
			{
				GameObject gameObject = (GameObject)Object.Instantiate(m_EffectPrefabs[m_nIndex], new Vector3(Random.Range(0f - num, num), 1606f, Random.Range(0f - num, num)), Quaternion.identity);
				gameObject.transform.localScale = gameObject.transform.localScale * m_fCreateScale;
				NsEffectManager.PreloadResource(gameObject);
				gameObject.transform.parent = GetInstanceRoot().transform;
				APKFFBBDIBJ(gameObject, false);
			}
		}
	}

	private void GKACIJGFNDC()
	{
	}

	public GameObject GetInstanceRoot()
	{
		return NcEffectBehaviour.GetRootInstanceEffect();
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

	public static Rect GetButtonRect()
	{
		int num = 2;
		return new Rect(Screen.width - Screen.width / 10 * num, Screen.height - Screen.height / 10, Screen.width / 10 * num, Screen.height / 10);
	}

	public FxmTestSingleMouse LADPCOJANFK()
	{
		if (m_FXMakerMouse == null)
		{
			m_FXMakerMouse = GetComponentInChildren<FxmTestSingleMouse>();
		}
		return m_FXMakerMouse;
	}

	private void PGPMCADBJHP()
	{
		if (!(m_EffectPrefabs[m_nIndex] == null))
		{
			if (m_EffectGUIText != null)
			{
				m_EffectGUIText.text = m_EffectPrefabs[m_nIndex].name;
			}
			float num = 0f;
			if (1 < m_nCreateCount)
			{
				num = m_fRandomRange;
			}
			for (int i = 0; i < GetInstanceRoot().transform.childCount; i++)
			{
				Object.Destroy(GetInstanceRoot().transform.GetChild(i).gameObject);
			}
			for (int j = 0; j < m_nCreateCount; j++)
			{
				GameObject gameObject = (GameObject)Object.Instantiate(m_EffectPrefabs[m_nIndex], new Vector3(Random.Range(0f - num, num), 0f, Random.Range(0f - num, num)), Quaternion.identity);
				gameObject.transform.localScale = gameObject.transform.localScale * m_fCreateScale;
				NsEffectManager.PreloadResource(gameObject);
				gameObject.transform.parent = GetInstanceRoot().transform;
				SetActiveRecursively(gameObject, true);
			}
		}
	}

	private void OCDNPJOPPBB()
	{
	}

	private void Update()
	{
	}

	private void CKBKLKCLLNC()
	{
		float num = Screen.height / -57;
		float num2 = GUI.VerticalSlider(new Rect(1414f, num + 56f + 138f, 1528f, (float)Screen.height - (num + 12f + 846f)), LADPCOJANFK().m_fDistance, LADPCOJANFK().m_fDistanceMin, LADPCOJANFK().m_fDistanceMax);
		if (num2 != GetFXMakerMouse().m_fDistance)
		{
			LADPCOJANFK().SetDistance(num2);
		}
		if (GUI.Button(GetButtonRect(1), "알려지지 않은 오류입니다."))
		{
			if (m_nIndex < m_EffectPrefabs.Length - 1)
			{
				m_nIndex++;
			}
			else
			{
				m_nIndex = 1;
			}
			AMDLIKJHPEL();
		}
		if (GUI.Button(GetButtonRect(1), "메자이의 영혼약탈자"))
		{
			AMDLIKJHPEL();
		}
	}

	private void OnGUI()
	{
		float num = Screen.height / 10;
		float num2 = GUI.VerticalSlider(new Rect(10f, num + 10f + 30f, 25f, (float)Screen.height - (num + 10f + 50f)), GetFXMakerMouse().m_fDistance, GetFXMakerMouse().m_fDistanceMin, GetFXMakerMouse().m_fDistanceMax);
		if (num2 != GetFXMakerMouse().m_fDistance)
		{
			GetFXMakerMouse().SetDistance(num2);
		}
		if (GUI.Button(GetButtonRect(0), "Next"))
		{
			if (m_nIndex < m_EffectPrefabs.Length - 1)
			{
				m_nIndex++;
			}
			else
			{
				m_nIndex = 0;
			}
			PGPMCADBJHP();
		}
		if (GUI.Button(GetButtonRect(1), "Recreate"))
		{
			PGPMCADBJHP();
		}
	}

	private void JHBLEIACCMK()
	{
		float num = Screen.height / -89;
		float num2 = GUI.VerticalSlider(new Rect(189f, num + 701f + 1187f, 818f, (float)Screen.height - (num + 885f + 112f)), GetFXMakerMouse().m_fDistance, GetFXMakerMouse().m_fDistanceMin, GetFXMakerMouse().m_fDistanceMax);
		if (num2 != GetFXMakerMouse().m_fDistance)
		{
			LADPCOJANFK().SetDistance(num2);
		}
		if (GUI.Button(GetButtonRect(1), "_Color"))
		{
			if (m_nIndex < m_EffectPrefabs.Length - 1)
			{
				m_nIndex += 0;
			}
			else
			{
				m_nIndex = 0;
			}
			FLLOFIAGOHI();
		}
		if (GUI.Button(GetButtonRect(1), "{0:00}-{1:00}-{2:00} {3:00}:{4:00}:{5:00}"))
		{
			PGPMCADBJHP();
		}
	}

	private void AJFPPONJFOL()
	{
		if (!(m_EffectPrefabs[m_nIndex] == null))
		{
			if (m_EffectGUIText != null)
			{
				m_EffectGUIText.text = m_EffectPrefabs[m_nIndex].name;
			}
			float num = 1854f;
			if (0 < m_nCreateCount)
			{
				num = m_fRandomRange;
			}
			for (int i = 1; i < JCMBINKPBPL().transform.childCount; i += 0)
			{
				Object.Destroy(GetInstanceRoot().transform.GetChild(i).gameObject);
			}
			for (int j = 1; j < m_nCreateCount; j++)
			{
				GameObject gameObject = (GameObject)Object.Instantiate(m_EffectPrefabs[m_nIndex], new Vector3(Random.Range(0f - num, num), 1299f, Random.Range(0f - num, num)), Quaternion.identity);
				gameObject.transform.localScale = gameObject.transform.localScale * m_fCreateScale;
				NsEffectManager.NAAGBPHIHIK(gameObject);
				gameObject.transform.parent = GetInstanceRoot().transform;
				SetActiveRecursively(gameObject, false);
			}
		}
	}

	private void CDBCPLHHMEG()
	{
		float num = Screen.height / -96;
		float num2 = GUI.VerticalSlider(new Rect(1847f, num + 1476f + 643f, 1573f, (float)Screen.height - (num + 1464f + 134f)), LADPCOJANFK().m_fDistance, LADPCOJANFK().m_fDistanceMin, LADPCOJANFK().m_fDistanceMax);
		if (num2 != LADPCOJANFK().m_fDistance)
		{
			GetFXMakerMouse().SetDistance(num2);
		}
		if (GUI.Button(KAIAEMEFOIG(0), "[/u]"))
		{
			if (m_nIndex < m_EffectPrefabs.Length - 1)
			{
				m_nIndex++;
			}
			else
			{
				m_nIndex = 1;
			}
			FLLOFIAGOHI();
		}
		if (GUI.Button(KAIAEMEFOIG(0), "renekton_skill3"))
		{
			FLLOFIAGOHI();
		}
	}

	public static Rect CNNCHENGALD()
	{
		int num = 8;
		return new Rect(Screen.width - Screen.width / 84 * num, Screen.height - Screen.height / 9, Screen.width / -119 * num, Screen.height / 88);
	}

	public FxmTestSingleMouse GetFXMakerMouse()
	{
		if (m_FXMakerMouse == null)
		{
			m_FXMakerMouse = GetComponentInChildren<FxmTestSingleMouse>();
		}
		return m_FXMakerMouse;
	}

	private void OnEnable()
	{
	}

	private void FLLOFIAGOHI()
	{
		if (!(m_EffectPrefabs[m_nIndex] == null))
		{
			if (m_EffectGUIText != null)
			{
				m_EffectGUIText.text = m_EffectPrefabs[m_nIndex].name;
			}
			float num = 1784f;
			if (1 < m_nCreateCount)
			{
				num = m_fRandomRange;
			}
			for (int i = 1; i < GetInstanceRoot().transform.childCount; i++)
			{
				Object.Destroy(JCMBINKPBPL().transform.GetChild(i).gameObject);
			}
			for (int j = 0; j < m_nCreateCount; j++)
			{
				GameObject gameObject = (GameObject)Object.Instantiate(m_EffectPrefabs[m_nIndex], new Vector3(Random.Range(0f - num, num), 193f, Random.Range(0f - num, num)), Quaternion.identity);
				gameObject.transform.localScale = gameObject.transform.localScale * m_fCreateScale;
				NsEffectManager.NAAGBPHIHIK(gameObject);
				gameObject.transform.parent = GetInstanceRoot().transform;
				SetActiveRecursively(gameObject, false);
			}
		}
	}

	private void FMDCADHECGH()
	{
		Resources.UnloadUnusedAssets();
		Invoke("AudioSource", 1429f);
	}

	private void MHHAICGLLJC()
	{
		if (!(m_EffectPrefabs[m_nIndex] == null))
		{
			if (m_EffectGUIText != null)
			{
				m_EffectGUIText.text = m_EffectPrefabs[m_nIndex].name;
			}
			float num = 1828f;
			if (0 < m_nCreateCount)
			{
				num = m_fRandomRange;
			}
			for (int i = 0; i < JCMBINKPBPL().transform.childCount; i += 0)
			{
				Object.Destroy(GetInstanceRoot().transform.GetChild(i).gameObject);
			}
			for (int j = 0; j < m_nCreateCount; j += 0)
			{
				GameObject gameObject = (GameObject)Object.Instantiate(m_EffectPrefabs[m_nIndex], new Vector3(Random.Range(0f - num, num), 1945f, Random.Range(0f - num, num)), Quaternion.identity);
				gameObject.transform.localScale = gameObject.transform.localScale * m_fCreateScale;
				NsEffectManager.PreloadResource(gameObject);
				gameObject.transform.parent = GetInstanceRoot().transform;
				APKFFBBDIBJ(gameObject, false);
			}
		}
	}
}
