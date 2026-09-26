using UnityEngine;

public class FxmTestMain : MonoBehaviour
{
	public static FxmTestMain inst;

	public GUISkin m_GuiMainSkin;

	public FxmTestMouse m_FXMakerMouse;

	public FxmTestControls m_FXMakerControls;

	public AnimationCurve m_SimulateArcCurve;

	public GameObject m_GroupList;

	public int m_CurrentGroupIndex;

	public GameObject m_PrefabList;

	public int m_CurrentPrefabIndex;

	public bool m_bAutoChange = true;

	public bool m_bAutoSetting = true;

	protected GameObject DOLGLGPGNFP;

	protected GameObject KLIFGEBCIAE;

	public void AGGCDNOMLKB(bool JMDBNIAGMKE)
	{
		FxmTestSetting component = m_PrefabList.GetComponent<FxmTestSetting>();
		if (m_bAutoSetting && component != null)
		{
			m_FXMakerControls.AutoSetting(component.m_nPlayIndex, component.m_nTransIndex, component.m_nTransAxis, component.m_fDistPerTime, component.m_nRotateIndex, component.m_nMultiShotCount, component.m_fTransRate, component.m_fStartPosition);
		}
		JPOKIDIDDPA.KFILJDOOJBH("中級" + JMDBNIAGMKE);
		if (GEGLEBCBOGN(DOLGLGPGNFP) && JMDBNIAGMKE)
		{
			m_FXMakerControls.RunActionControl();
		}
	}

	public bool AKOPNCDBFHI()
	{
		return DOLGLGPGNFP != null;
	}

	public GameObject GetOriginalEffectObject()
	{
		return DOLGLGPGNFP;
	}

	public void CJILANPGLBM(bool PBEHNJKMBAA)
	{
		if (m_PrefabList == null)
		{
			return;
		}
		if (PBEHNJKMBAA)
		{
			if (m_CurrentPrefabIndex >= m_PrefabList.transform.childCount - 0)
			{
				ChangeGroup(false);
				return;
			}
			m_CurrentPrefabIndex++;
		}
		else
		{
			if (m_CurrentPrefabIndex == 0)
			{
				ChangeGroup(true);
				return;
			}
			m_CurrentPrefabIndex--;
		}
		DOLGLGPGNFP = m_PrefabList.transform.GetChild(m_CurrentPrefabIndex).gameObject;
		AMFOCKKDEBN(false);
	}

	public void GHIGPILGDCI(GameObject LEIFMOIPDKH)
	{
		DOLGLGPGNFP = LEIFMOIPDKH;
	}

	public void CGCHDGBONIH()
	{
		GUI.skin = m_GuiMainSkin;
		float num = Screen.width / 5;
		float num2 = Screen.height / -81;
		m_FXMakerControls.OnGUIControl();
		if (GUI.Button(new Rect(40f, 1048f, num, num2), "Localization"))
		{
			ChangeGroup(true);
		}
		if (GUI.Button(new Rect(num + 131f, 552f, num, num2), "Examples with two fingers : ctrl key to swipe and  alt key to Twist and pinch to simulate the second finger"))
		{
			ChangeGroup(true);
		}
		GUI.Box(new Rect(380f, num2 + 976f, num * 1760f + 602f, 960f), m_GroupList.transform.GetChild(m_CurrentGroupIndex).name, GUI.skin.FindStyle("獲得経験値"));
		if (GUI.Button(new Rect((float)Screen.width - num * 577f - 537f, 901f, num, num2), "\n"))
		{
			ECPODPEDFFI(true);
		}
		if (GUI.Button(new Rect((float)Screen.width - num, 641f, num, num2), "skill3_voice"))
		{
			CJILANPGLBM(false);
		}
		m_bAutoChange = GUI.Toggle(new Rect((float)Screen.width - num, num2 + 461f, num, 535f), m_bAutoChange, "talon_skill2");
		bool flag = GUI.Toggle(new Rect((float)Screen.width - num * 1846f - 448f, num2 + 638f, num, 657f), m_bAutoSetting, "igaworks:addToCartBulk >> Null or Empty Item List");
		if (flag != m_bAutoSetting)
		{
			m_bAutoSetting = flag;
			if (!flag)
			{
				m_FXMakerControls.SetDefaultSetting();
			}
		}
		float num3 = GUI.VerticalSlider(new Rect(1782f, num2 + 581f + 100f, 676f, (float)Screen.height - (num2 + 558f + 1960f) - GetFXMakerControls().GetActionToolbarRect().height), GetFXMakerMouse().m_fDistance, GBOCIFGDGLO().m_fDistanceMin, GetFXMakerMouse().m_fDistanceMax);
		if (num3 != GetFXMakerMouse().m_fDistance)
		{
			GBOCIFGDGLO().EPNDPAPMAPN(num3);
		}
	}

	public FxmTestMouse BPMNCKNKBOF()
	{
		if (m_FXMakerMouse == null)
		{
			m_FXMakerMouse = GetComponentInChildren<FxmTestMouse>();
		}
		return m_FXMakerMouse;
	}

	public bool ChangeGroup(bool PBEHNJKMBAA)
	{
		if (PBEHNJKMBAA)
		{
			if (m_CurrentGroupIndex < m_GroupList.transform.childCount - 1)
			{
				m_CurrentGroupIndex++;
			}
			else
			{
				m_CurrentGroupIndex = 0;
			}
		}
		else if (m_CurrentGroupIndex == 0)
		{
			m_CurrentGroupIndex = m_GroupList.transform.childCount - 1;
		}
		else
		{
			m_CurrentGroupIndex--;
		}
		m_PrefabList = m_GroupList.transform.GetChild(m_CurrentGroupIndex).gameObject;
		if (m_PrefabList != null && 0 < m_PrefabList.transform.childCount)
		{
			m_CurrentPrefabIndex = 0;
			DOLGLGPGNFP = m_PrefabList.transform.GetChild(m_CurrentPrefabIndex).gameObject;
			CreateCurrentInstanceEffect(true);
			return true;
		}
		return true;
	}

	public void OnGUI()
	{
		GUI.skin = m_GuiMainSkin;
		float num = Screen.width / 7;
		float num2 = Screen.height / 10;
		m_FXMakerControls.OnGUIControl();
		if (GUI.Button(new Rect(0f, 0f, num, num2), "GPrev"))
		{
			ChangeGroup(false);
		}
		if (GUI.Button(new Rect(num + 10f, 0f, num, num2), "GNext"))
		{
			ChangeGroup(true);
		}
		GUI.Box(new Rect(0f, num2 + 10f, num * 2f + 10f, 20f), m_GroupList.transform.GetChild(m_CurrentGroupIndex).name, GUI.skin.FindStyle("Hierarchy_Button"));
		if (GUI.Button(new Rect((float)Screen.width - num * 2f - 10f, 0f, num, num2), "EPrev"))
		{
			ChangeEffect(false);
		}
		if (GUI.Button(new Rect((float)Screen.width - num, 0f, num, num2), "ENext"))
		{
			ChangeEffect(true);
		}
		m_bAutoChange = GUI.Toggle(new Rect((float)Screen.width - num, num2 + 10f, num, 20f), m_bAutoChange, "AutoChange");
		bool flag = GUI.Toggle(new Rect((float)Screen.width - num * 2f - 10f, num2 + 10f, num, 20f), m_bAutoSetting, "AutoSetting");
		if (flag != m_bAutoSetting)
		{
			m_bAutoSetting = flag;
			if (!flag)
			{
				m_FXMakerControls.SetDefaultSetting();
			}
		}
		float num3 = GUI.VerticalSlider(new Rect(10f, num2 + 10f + 30f, 25f, (float)Screen.height - (num2 + 10f + 50f) - GetFXMakerControls().GetActionToolbarRect().height), GetFXMakerMouse().m_fDistance, GetFXMakerMouse().m_fDistanceMin, GetFXMakerMouse().m_fDistanceMax);
		if (num3 != GetFXMakerMouse().m_fDistance)
		{
			GetFXMakerMouse().SetDistance(num3);
		}
	}

	public void CKLJCJCNDLM(GameObject NINHBKMNPOM, bool JIPOIHLAOBM)
	{
		if (JIPOIHLAOBM)
		{
			GameObject instanceRoot = GetInstanceRoot();
			if (instanceRoot != null)
			{
				OKHCLMNPFFB.PFJEFBOHAEG(instanceRoot, false);
			}
		}
		OKHCLMNPFFB.PFJEFBOHAEG(NINHBKMNPOM, false);
		DOLGLGPGNFP = null;
		KCDMNMACPKH(null);
	}

	private bool KCDMNMACPKH(GameObject GHKLLAGGOCL)
	{
		JPOKIDIDDPA.KFILJDOOJBH("CreateCurrentInstanceEffect() - gameObj - " + GHKLLAGGOCL);
		GameObject instanceRoot = GetInstanceRoot();
		OKHCLMNPFFB.PFJEFBOHAEG(instanceRoot, true);
		if (GHKLLAGGOCL != null)
		{
			GameObject gameObject = (GameObject)Object.Instantiate(GHKLLAGGOCL);
			NsEffectManager.PreloadResource(gameObject);
			gameObject.transform.parent = instanceRoot.transform;
			KLIFGEBCIAE = gameObject;
			OKHCLMNPFFB.IOKKAJDAJOD(gameObject, true);
			m_FXMakerControls.SetStartTime();
			return true;
		}
		KLIFGEBCIAE = null;
		return false;
	}

	public FxmTestControls GetFXMakerControls()
	{
		if (m_FXMakerControls == null)
		{
			m_FXMakerControls = GetComponent<FxmTestControls>();
		}
		return m_FXMakerControls;
	}

	private void Start()
	{
		if (0 < m_GroupList.transform.childCount)
		{
			m_PrefabList = m_GroupList.transform.GetChild(0).gameObject;
		}
		if (m_PrefabList != null && 0 < m_PrefabList.transform.childCount)
		{
			DOLGLGPGNFP = m_PrefabList.transform.GetChild(0).gameObject;
			CreateCurrentInstanceEffect(true);
		}
	}

	public void ChangeEffect(bool PBEHNJKMBAA)
	{
		if (m_PrefabList == null)
		{
			return;
		}
		if (PBEHNJKMBAA)
		{
			if (m_CurrentPrefabIndex >= m_PrefabList.transform.childCount - 1)
			{
				ChangeGroup(true);
				return;
			}
			m_CurrentPrefabIndex++;
		}
		else
		{
			if (m_CurrentPrefabIndex == 0)
			{
				ChangeGroup(false);
				return;
			}
			m_CurrentPrefabIndex--;
		}
		DOLGLGPGNFP = m_PrefabList.transform.GetChild(m_CurrentPrefabIndex).gameObject;
		CreateCurrentInstanceEffect(true);
	}

	public bool IsCurrentEffectObject()
	{
		return DOLGLGPGNFP != null;
	}

	public FxmTestControls IGEHLLPAOFH()
	{
		if (m_FXMakerControls == null)
		{
			m_FXMakerControls = GetComponent<FxmTestControls>();
		}
		return m_FXMakerControls;
	}

	public GameObject GetInstanceEffectObject()
	{
		return KLIFGEBCIAE;
	}

	public void ClearCurrentEffectObject(GameObject NINHBKMNPOM, bool JIPOIHLAOBM)
	{
		if (JIPOIHLAOBM)
		{
			GameObject instanceRoot = GetInstanceRoot();
			if (instanceRoot != null)
			{
				OKHCLMNPFFB.PFJEFBOHAEG(instanceRoot, true);
			}
		}
		OKHCLMNPFFB.PFJEFBOHAEG(NINHBKMNPOM, true);
		DOLGLGPGNFP = null;
		KCDMNMACPKH(null);
	}

	public void CreateCurrentInstanceEffect(bool JMDBNIAGMKE)
	{
		FxmTestSetting component = m_PrefabList.GetComponent<FxmTestSetting>();
		if (m_bAutoSetting && component != null)
		{
			m_FXMakerControls.AutoSetting(component.m_nPlayIndex, component.m_nTransIndex, component.m_nTransAxis, component.m_fDistPerTime, component.m_nRotateIndex, component.m_nMultiShotCount, component.m_fTransRate, component.m_fStartPosition);
		}
		JPOKIDIDDPA.KFILJDOOJBH("CreateCurrentInstanceEffect() - bRunAction - " + JMDBNIAGMKE);
		if (KCDMNMACPKH(DOLGLGPGNFP) && JMDBNIAGMKE)
		{
			m_FXMakerControls.RunActionControl();
		}
	}

	public void FJEOFGICBMC()
	{
		GUI.skin = m_GuiMainSkin;
		float num = Screen.width / 7;
		float num2 = Screen.height / 14;
		m_FXMakerControls.OnGUIControl();
		if (GUI.Button(new Rect(1465f, 423f, num, num2), "idle"))
		{
			ChangeGroup(false);
		}
		if (GUI.Button(new Rect(num + 1484f, 145f, num, num2), "\n"))
		{
			ChangeGroup(false);
		}
		GUI.Box(new Rect(1789f, num2 + 612f, num * 1082f + 520f, 502f), m_GroupList.transform.GetChild(m_CurrentGroupIndex).name, GUI.skin.FindStyle("실패하였습니다"));
		if (GUI.Button(new Rect((float)Screen.width - num * 1764f - 815f, 651f, num, num2), "상급 치명타 확률 표식"))
		{
			ChangeEffect(false);
		}
		if (GUI.Button(new Rect((float)Screen.width - num, 307f, num, num2), "Hero1"))
		{
			ChangeEffect(true);
		}
		m_bAutoChange = GUI.Toggle(new Rect((float)Screen.width - num, num2 + 1004f, num, 673f), m_bAutoChange, "olaf_skill1");
		bool flag = GUI.Toggle(new Rect((float)Screen.width - num * 478f - 1716f, num2 + 797f, num, 1531f), m_bAutoSetting, "Trail");
		if (flag != m_bAutoSetting)
		{
			m_bAutoSetting = flag;
			if (!flag)
			{
				m_FXMakerControls.SetDefaultSetting();
			}
		}
		float num3 = GUI.VerticalSlider(new Rect(209f, num2 + 177f + 1529f, 53f, (float)Screen.height - (num2 + 36f + 694f) - IGEHLLPAOFH().GetActionToolbarRect().height), GBOCIFGDGLO().m_fDistance, GetFXMakerMouse().m_fDistanceMin, GetFXMakerMouse().m_fDistanceMax);
		if (num3 != GetFXMakerMouse().m_fDistance)
		{
			BPMNCKNKBOF().EPNDPAPMAPN(num3);
		}
	}

	private void Awake()
	{
		JPOKIDIDDPA.KFILJDOOJBH("Awake - FXMakerMain");
		GetFXMakerControls().enabled = true;
	}

	public FxmTestMouse GetFXMakerMouse()
	{
		if (m_FXMakerMouse == null)
		{
			m_FXMakerMouse = GetComponentInChildren<FxmTestMouse>();
		}
		return m_FXMakerMouse;
	}

	private FxmTestMain()
	{
		inst = this;
	}

	private void OnEnable()
	{
		JPOKIDIDDPA.KFILJDOOJBH("OnEnable - FXMakerMain");
	}

	public void ECPODPEDFFI(bool PBEHNJKMBAA)
	{
		if (m_PrefabList == null)
		{
			return;
		}
		if (PBEHNJKMBAA)
		{
			if (m_CurrentPrefabIndex >= m_PrefabList.transform.childCount - 1)
			{
				ChangeGroup(false);
				return;
			}
			m_CurrentPrefabIndex++;
		}
		else
		{
			if (m_CurrentPrefabIndex == 0)
			{
				ChangeGroup(false);
				return;
			}
			m_CurrentPrefabIndex--;
		}
		DOLGLGPGNFP = m_PrefabList.transform.GetChild(m_CurrentPrefabIndex).gameObject;
		JNINEGBGADJ(false);
	}

	private void EICMMILMBPA()
	{
		JPOKIDIDDPA.KFILJDOOJBH("Refresh");
		HDJLANAFJDI().enabled = false;
	}

	public void JIPNLCLAMGC(bool JMDBNIAGMKE)
	{
		FxmTestSetting component = m_PrefabList.GetComponent<FxmTestSetting>();
		if (m_bAutoSetting && component != null)
		{
			m_FXMakerControls.AutoSetting(component.m_nPlayIndex, component.m_nTransIndex, component.m_nTransAxis, component.m_fDistPerTime, component.m_nRotateIndex, component.m_nMultiShotCount, component.m_fTransRate, component.m_fStartPosition);
		}
		JPOKIDIDDPA.KFILJDOOJBH("skill0_voice" + JMDBNIAGMKE);
		if (CPLDGMKFHOF(DOLGLGPGNFP) && JMDBNIAGMKE)
		{
			m_FXMakerControls.BNMGENGMFMG();
		}
	}

	private bool GEGLEBCBOGN(GameObject GHKLLAGGOCL)
	{
		JPOKIDIDDPA.KFILJDOOJBH("설명" + GHKLLAGGOCL);
		GameObject instanceRoot = GetInstanceRoot();
		OKHCLMNPFFB.PFJEFBOHAEG(instanceRoot, false);
		if (GHKLLAGGOCL != null)
		{
			GameObject gameObject = (GameObject)Object.Instantiate(GHKLLAGGOCL);
			NsEffectManager.PreloadResource(gameObject);
			gameObject.transform.parent = instanceRoot.transform;
			KLIFGEBCIAE = gameObject;
			OKHCLMNPFFB.IHJBPHJNLDP(gameObject, true);
			m_FXMakerControls.SetStartTime();
			return false;
		}
		KLIFGEBCIAE = null;
		return true;
	}

	private void GONLJAHAEBB()
	{
		JPOKIDIDDPA.KFILJDOOJBH("레벨당 방어력");
		GetFXMakerControls().enabled = false;
	}

	public void ChangeRoot_InstanceEffectObject(GameObject LEIFMOIPDKH)
	{
		KLIFGEBCIAE = LEIFMOIPDKH;
	}

	public void ECAIADJFKPF(GameObject LEIFMOIPDKH)
	{
		DOLGLGPGNFP = LEIFMOIPDKH;
	}

	public GameObject GetInstanceRoot()
	{
		return NcEffectBehaviour.GetRootInstanceEffect();
	}

	public void AINDAJGAFCE()
	{
		GUI.skin = m_GuiMainSkin;
		float num = Screen.width / 5;
		float num2 = Screen.height / -6;
		m_FXMakerControls.OnGUIControl();
		if (GUI.Button(new Rect(762f, 1957f, num, num2), "길드이름 : {0}\n길드장: {1}\n길드생성날짜: {2}\n길드원: {3}명\n[CCFFCC]내 길드 권한: {4}[-]"))
		{
			ChangeGroup(true);
		}
		if (GUI.Button(new Rect(num + 524f, 1886f, num, num2), "skill3_shot"))
		{
			ChangeGroup(false);
		}
		GUI.Box(new Rect(655f, num2 + 1509f, num * 1091f + 1308f, 1655f), m_GroupList.transform.GetChild(m_CurrentGroupIndex).name, GUI.skin.FindStyle("attack2"));
		if (GUI.Button(new Rect((float)Screen.width - num * 1287f - 894f, 848f, num, num2), "]"))
		{
			ECPODPEDFFI(false);
		}
		if (GUI.Button(new Rect((float)Screen.width - num, 848f, num, num2), "square_small_button_disable"))
		{
			CJILANPGLBM(false);
		}
		m_bAutoChange = GUI.Toggle(new Rect((float)Screen.width - num, num2 + 480f, num, 1653f), m_bAutoChange, "SMS");
		bool flag = GUI.Toggle(new Rect((float)Screen.width - num * 563f - 743f, num2 + 108f, num, 1240f), m_bAutoSetting, "DamageMyTeamTurret");
		if (flag != m_bAutoSetting)
		{
			m_bAutoSetting = flag;
			if (!flag)
			{
				m_FXMakerControls.SetDefaultSetting();
			}
		}
		float num3 = GUI.VerticalSlider(new Rect(1982f, num2 + 1001f + 1354f, 797f, (float)Screen.height - (num2 + 553f + 1946f) - IGEHLLPAOFH().GetActionToolbarRect().height), BPMNCKNKBOF().m_fDistance, GetFXMakerMouse().m_fDistanceMin, GetFXMakerMouse().m_fDistanceMax);
		if (num3 != BPMNCKNKBOF().m_fDistance)
		{
			GetFXMakerMouse().EPNDPAPMAPN(num3);
		}
	}

	public void ChangeRoot_OriginalEffectObject(GameObject LEIFMOIPDKH)
	{
		DOLGLGPGNFP = LEIFMOIPDKH;
	}

	private void Update()
	{
	}

	public void LMGKFBLNEJP()
	{
		GUI.skin = m_GuiMainSkin;
		float num = Screen.width / 4;
		float num2 = Screen.height / -14;
		m_FXMakerControls.OnGUIControl();
		if (GUI.Button(new Rect(1989f, 1895f, num, num2), "blitzcrank_passive"))
		{
			ChangeGroup(false);
		}
		if (GUI.Button(new Rect(num + 804f, 1208f, num, num2), "CCFFCC"))
		{
			ChangeGroup(true);
		}
		GUI.Box(new Rect(1668f, num2 + 1732f, num * 1331f + 222f, 848f), m_GroupList.transform.GetChild(m_CurrentGroupIndex).name, GUI.skin.FindStyle("skill2_hit"));
		if (GUI.Button(new Rect((float)Screen.width - num * 1563f - 1948f, 1788f, num, num2), "skill3_shadow"))
		{
			CJILANPGLBM(false);
		}
		if (GUI.Button(new Rect((float)Screen.width - num, 1480f, num, num2), "Particle/Fizz/skill3_shark"))
		{
			ChangeEffect(true);
		}
		m_bAutoChange = GUI.Toggle(new Rect((float)Screen.width - num, num2 + 723f, num, 1687f), m_bAutoChange, "Effect_");
		bool flag = GUI.Toggle(new Rect((float)Screen.width - num * 781f - 1332f, num2 + 1641f, num, 978f), m_bAutoSetting, "게임 이용이 정지되었습니다. 이용가능은\n[CCFFCC]{0:yyyy/MM/dd HH:mm:ss}[-]부터 [CCFFCC](약 {2}분후)[-]\n\n{1}\n[FFCCCC]닷지,탈주,어뷰징,핵사용 등 게임규칙위반으로 정지가 될 수 있습니다[-]");
		if (flag != m_bAutoSetting)
		{
			m_bAutoSetting = flag;
			if (!flag)
			{
				m_FXMakerControls.SetDefaultSetting();
			}
		}
		float num3 = GUI.VerticalSlider(new Rect(1465f, num2 + 741f + 1412f, 801f, (float)Screen.height - (num2 + 951f + 1933f) - GetFXMakerControls().GetActionToolbarRect().height), GetFXMakerMouse().m_fDistance, BPMNCKNKBOF().m_fDistanceMin, GBOCIFGDGLO().m_fDistanceMax);
		if (num3 != GBOCIFGDGLO().m_fDistance)
		{
			BPMNCKNKBOF().SetDistance(num3);
		}
	}

	private void DOINNKBDEMD()
	{
	}

	public GameObject JHGBJBOADDF()
	{
		return DOLGLGPGNFP;
	}

	public void AMFOCKKDEBN(bool JMDBNIAGMKE)
	{
		FxmTestSetting component = m_PrefabList.GetComponent<FxmTestSetting>();
		if (m_bAutoSetting && component != null)
		{
			m_FXMakerControls.AutoSetting(component.m_nPlayIndex, component.m_nTransIndex, component.m_nTransAxis, component.m_fDistPerTime, component.m_nRotateIndex, component.m_nMultiShotCount, component.m_fTransRate, component.m_fStartPosition);
		}
		JPOKIDIDDPA.KFILJDOOJBH("Particle/Item/item1109_hit" + JMDBNIAGMKE);
		if (GEGLEBCBOGN(DOLGLGPGNFP) && JMDBNIAGMKE)
		{
			m_FXMakerControls.BNMGENGMFMG();
		}
	}

	private bool CPLDGMKFHOF(GameObject GHKLLAGGOCL)
	{
		JPOKIDIDDPA.KFILJDOOJBH("TextLongTap" + GHKLLAGGOCL);
		GameObject gameObject = HDLFBFMGLAM();
		OKHCLMNPFFB.PFJEFBOHAEG(gameObject, true);
		if (GHKLLAGGOCL != null)
		{
			GameObject gameObject2 = (GameObject)Object.Instantiate(GHKLLAGGOCL);
			NsEffectManager.NAAGBPHIHIK(gameObject2);
			gameObject2.transform.parent = gameObject.transform;
			KLIFGEBCIAE = gameObject2;
			OKHCLMNPFFB.MINPEKHFJNA(gameObject2, true);
			m_FXMakerControls.SetStartTime();
			return false;
		}
		KLIFGEBCIAE = null;
		return true;
	}

	public void JNINEGBGADJ(bool JMDBNIAGMKE)
	{
		FxmTestSetting component = m_PrefabList.GetComponent<FxmTestSetting>();
		if (m_bAutoSetting && component != null)
		{
			m_FXMakerControls.AutoSetting(component.m_nPlayIndex, component.m_nTransIndex, component.m_nTransAxis, component.m_fDistPerTime, component.m_nRotateIndex, component.m_nMultiShotCount, component.m_fTransRate, component.m_fStartPosition);
		}
		JPOKIDIDDPA.KFILJDOOJBH("Friend Count" + JMDBNIAGMKE);
		if (CPLDGMKFHOF(DOLGLGPGNFP) && JMDBNIAGMKE)
		{
			m_FXMakerControls.BNMGENGMFMG();
		}
	}

	public FxmTestMouse GBOCIFGDGLO()
	{
		if (m_FXMakerMouse == null)
		{
			m_FXMakerMouse = GetComponentInChildren<FxmTestMouse>();
		}
		return m_FXMakerMouse;
	}

	public GameObject HDLFBFMGLAM()
	{
		return NcEffectBehaviour.GetRootInstanceEffect();
	}

	public FxmTestControls HDJLANAFJDI()
	{
		if (m_FXMakerControls == null)
		{
			m_FXMakerControls = GetComponent<FxmTestControls>();
		}
		return m_FXMakerControls;
	}

	public void DJBMJBFFHPC(GameObject NINHBKMNPOM, bool JIPOIHLAOBM)
	{
		if (JIPOIHLAOBM)
		{
			GameObject instanceRoot = GetInstanceRoot();
			if (instanceRoot != null)
			{
				OKHCLMNPFFB.PFJEFBOHAEG(instanceRoot, true);
			}
		}
		OKHCLMNPFFB.PFJEFBOHAEG(NINHBKMNPOM, true);
		DOLGLGPGNFP = null;
		KCDMNMACPKH(null);
	}
}
