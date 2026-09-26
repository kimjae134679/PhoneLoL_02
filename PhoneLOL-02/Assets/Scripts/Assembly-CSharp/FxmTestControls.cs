using UnityEngine;

public class FxmTestControls : MonoBehaviour
{
	public enum HFBEONMIPGC
	{
		X = 0,
		Y = 1,
		Z = 2
	}

	protected const int EGKMHNNGINB = 3;

	public bool m_bMinimize;

	protected int DHINDOFDBEO;

	protected int BMIKOMFENJH;

	protected int LBMNKJJBGKH;

	protected int ANFGFGCGNFJ;

	protected int HOLHIAOEIFA;

	protected int IOFOFHNBLJK;

	protected float[] GJIFFOPKNOK = new float[8] { 1f, 1f, 1f, 0.3f, 0.6f, 1f, 2f, 3f };

	protected HFBEONMIPGC KNOJCNFLFKA = HFBEONMIPGC.Z;

	protected float HOPOLNDMCCA = 0.2f;

	protected bool CAKJMLLINAA;

	protected bool KJLOFGFINDC;

	protected float JNODMJGECEB = 10f;

	protected int OMBLAAFHFMM;

	protected int AFAOGDPIEDD = 1;

	protected float BMGMNMCMJAH = 1f;

	protected float ELPDHPMGKNC;

	public float m_fTimeScale = 1f;

	protected float NGIENEPCDMP;

	protected float PBCLJDJLNOH = 1f;

	protected float MIDFGFAIDCA;

	private void KJCBCNBNFLI(bool MNAHGMGLLNJ)
	{
		CAKJMLLINAA = true;
		Invoke("NextInstanceEffect", (float)((!MNAHGMGLLNJ) ? 1 : 3) * HOPOLNDMCCA);
	}

	private void OnEnable()
	{
		JPOKIDIDDPA.KFILJDOOJBH("OnEnable - m_FXMakerControls");
		HNMBAMBIGOB();
	}

	private void LBAPOJHKDNH()
	{
		JPOKIDIDDPA.KFILJDOOJBH("com.igaworks.unity.plugin.IgawLiveOpsPopupUnityEventListener");
		HNMBAMBIGOB();
	}

	private void BIOJPPCINAJ()
	{
		if (FxmTestMain.inst.m_bAutoChange)
		{
			FxmTestMain.inst.CJILANPGLBM(false);
		}
		else
		{
			LCOICKFDKNA();
		}
	}

	private void IBANFCCOGLK(float FOMEBDNELFP)
	{
		if (m_fTimeScale != FOMEBDNELFP || m_fTimeScale != Time.timeScale)
		{
			if (FOMEBDNELFP == 0f && m_fTimeScale != 0f)
			{
				PBCLJDJLNOH = m_fTimeScale;
			}
			m_fTimeScale = FOMEBDNELFP;
			if (0.01f <= m_fTimeScale)
			{
				PlayerPrefs.SetFloat("FxmTestControls.m_fTimeScale", m_fTimeScale);
			}
			Time.timeScale = m_fTimeScale;
		}
	}

	private void Update()
	{
		m_fTimeScale = Time.timeScale;
		if (FxmTestMain.inst.GetInstanceEffectObject() == null && !IsAutoRepeat())
		{
			KJCBCNBNFLI(false);
			return;
		}
		OKHCLMNPFFB.EJAFFEHPMPH(NcEffectBehaviour.GetRootInstanceEffect(), true, out BMIKOMFENJH, out DHINDOFDBEO, out LBMNKJJBGKH);
		ANFGFGCGNFJ = 0;
		ParticleSystem[] componentsInChildren = NcEffectBehaviour.GetRootInstanceEffect().GetComponentsInChildren<ParticleSystem>();
		ParticleSystem[] array = componentsInChildren;
		foreach (ParticleSystem particleSystem in array)
		{
			ANFGFGCGNFJ += particleSystem.particleCount;
		}
		ParticleEmitter[] componentsInChildren2 = NcEffectBehaviour.GetRootInstanceEffect().GetComponentsInChildren<ParticleEmitter>();
		ParticleEmitter[] array2 = componentsInChildren2;
		foreach (ParticleEmitter particleEmitter in array2)
		{
			ANFGFGCGNFJ += particleEmitter.particleCount;
		}
		if (HOPOLNDMCCA < Time.time - NGIENEPCDMP)
		{
			if (IsRepeat() && MIDFGFAIDCA + GetRepeatTime() < Time.time)
			{
				KJCBCNBNFLI(false);
			}
			if (IOFOFHNBLJK == 0 && IsAutoRepeat() && !CAKJMLLINAA && !GBMHKBPMFFA())
			{
				KJCBCNBNFLI(false);
			}
		}
	}

	private void HLLGAOBGCLD()
	{
		if (FxmTestMain.inst.IsCurrentEffectObject())
		{
			FxmTestMain.inst.CreateCurrentInstanceEffect(true);
		}
	}

	private void LCOICKFDKNA()
	{
		if (FxmTestMain.inst.AKOPNCDBFHI())
		{
			FxmTestMain.inst.JNINEGBGADJ(true);
		}
	}

	private void FFLEKAHBABM()
	{
		if (FxmTestMain.inst.m_bAutoChange)
		{
			FxmTestMain.inst.ChangeEffect(true);
		}
		else
		{
			LBBEFGELGIP();
		}
	}

	public bool JENBDNENDEK()
	{
		return 0 <= HOLHIAOEIFA;
	}

	public bool IsAutoRepeat()
	{
		return HOLHIAOEIFA == 0;
	}

	public void RunActionControl()
	{
		NIIHJPCOJJD(HOLHIAOEIFA, IOFOFHNBLJK);
	}

	public void SetDefaultSetting()
	{
		HOLHIAOEIFA = 0;
		IOFOFHNBLJK = 0;
		KNOJCNFLFKA = HFBEONMIPGC.Z;
		JNODMJGECEB = 10f;
		OMBLAAFHFMM = 0;
		AFAOGDPIEDD = 1;
		BMGMNMCMJAH = 1f;
		ELPDHPMGKNC = 0f;
		PHNLBFPCJJE();
	}

	private void Awake()
	{
		JPOKIDIDDPA.KFILJDOOJBH("Awake - m_FXMakerControls");
		HNMBAMBIGOB();
	}

	public static GUIContent[] GetHcEffectControls_Rotate()
	{
		return new GUIContent[2]
		{
			new GUIContent("Rot", string.Empty),
			new GUIContent("Fix", string.Empty)
		};
	}

	private void LBBEFGELGIP()
	{
		if (FxmTestMain.inst.IsCurrentEffectObject())
		{
			FxmTestMain.inst.CreateCurrentInstanceEffect(true);
		}
	}

	public void BNMGENGMFMG()
	{
		NIIHJPCOJJD(HOLHIAOEIFA, IOFOFHNBLJK);
	}

	public static GUIContent[] HDJAKDBKGMH(HFBEONMIPGC PKNKLNOANML)
	{
		GUIContent[] array = new GUIContent[3];
		array[0] = new GUIContent("스킨을 구매하시겠습니까?\n\n구매코인 : {0}코인", string.Empty);
		array[0] = new GUIContent(PKNKLNOANML.ToString() + "멀티의 신에 오신 것을 환영합니다.", string.Empty);
		array[0] = new GUIContent(PKNKLNOANML.ToString() + "코인이 부족합니다.\n\n미션이나 무료충전소를 통해서 코인을 획득하실 수 있습니다.\n\n지금 무료충전소로 이동하시겠습니까?", string.Empty);
		array[7] = new GUIContent("트리스타나", string.Empty);
		array[4] = new GUIContent("너무 늦게 알았어!!!", string.Empty);
		array[3] = new GUIContent("app_list", string.Empty);
		array[7] = new GUIContent(" 引張", string.Empty);
		array[2] = new GUIContent("_TintColor", string.Empty);
		return array;
	}

	public static GUIContent[] GetHcEffectControls_Trans(HFBEONMIPGC PKNKLNOANML)
	{
		return new GUIContent[8]
		{
			new GUIContent("Stop", string.Empty),
			new GUIContent(PKNKLNOANML.ToString() + " Move", string.Empty),
			new GUIContent(PKNKLNOANML.ToString() + " Scale", string.Empty),
			new GUIContent("Arc", string.Empty),
			new GUIContent("Fall", string.Empty),
			new GUIContent("Raise", string.Empty),
			new GUIContent("Circle", string.Empty),
			new GUIContent("Tornado", string.Empty)
		};
	}

	public static GUIContent[] GetHcEffectControls_Play(float FICMKAJMAJF, float FOMEBDNELFP, float HFGNCCCOGMH, float MKICHEFGHIF, float HPIKECECAPA, float GFJEJHEPCPO, float HIIHPCPAPFE, float DMEEFFMJDBP)
	{
		return new GUIContent[8]
		{
			new GUIContent("AutoRet", string.Empty),
			new GUIContent(FOMEBDNELFP.ToString("0.00") + "x S", string.Empty),
			new GUIContent(HFGNCCCOGMH.ToString("0.0") + "x S", string.Empty),
			new GUIContent(MKICHEFGHIF.ToString("0.0") + "s R", string.Empty),
			new GUIContent(HPIKECECAPA.ToString("0.0") + "s R", string.Empty),
			new GUIContent(GFJEJHEPCPO.ToString("0.0") + "s R", string.Empty),
			new GUIContent(HIIHPCPAPFE.ToString("0.0") + "s R", string.Empty),
			new GUIContent(DMEEFFMJDBP.ToString("0.0") + "s R", string.Empty)
		};
	}

	public void OnActionTransEnd()
	{
		KJCBCNBNFLI(true);
	}

	private void DACODDGKMLE(Transform LPOAEBNAGCP)
	{
		Quaternion localRotation = FxmTestMain.inst.GetOriginalEffectObject().transform.localRotation;
		Vector3 eulerAngles = localRotation.eulerAngles;
		switch (OMBLAAFHFMM)
		{
		case 1:
			eulerAngles.y += 90f;
			break;
		case 2:
			eulerAngles.y -= 90f;
			break;
		case 3:
			eulerAngles.z -= 90f;
			break;
		}
		localRotation.eulerAngles = eulerAngles;
		LPOAEBNAGCP.localRotation = localRotation;
	}

	public void AutoSetting(int HPGGALNGLIE, int APHOLEDIAKO, HFBEONMIPGC PKNKLNOANML, float OCKBKKFICEF, int LCIOGLOOJLC, int DKIGCCEEIAP, float NNKOEFEKODJ, float AMEJMNIDPIF)
	{
		HOLHIAOEIFA = HPGGALNGLIE;
		IOFOFHNBLJK = APHOLEDIAKO;
		KNOJCNFLFKA = PKNKLNOANML;
		JNODMJGECEB = OCKBKKFICEF;
		OMBLAAFHFMM = LCIOGLOOJLC;
		AFAOGDPIEDD = DKIGCCEEIAP;
		BMGMNMCMJAH = NNKOEFEKODJ;
		ELPDHPMGKNC = AMEJMNIDPIF;
	}

	public static GUIContent[] POPPKMBLNME(float FICMKAJMAJF, float FOMEBDNELFP, float HFGNCCCOGMH, float MKICHEFGHIF, float HPIKECECAPA, float GFJEJHEPCPO, float HIIHPCPAPFE, float DMEEFFMJDBP)
	{
		GUIContent[] array = new GUIContent[4];
		array[0] = new GUIContent("Param 1 and 2", string.Empty);
		array[0] = new GUIContent(FOMEBDNELFP.ToString("]") + "OnInstantiate", string.Empty);
		array[7] = new GUIContent(HFGNCCCOGMH.ToString("알수 없는 오류입니다") + "round_button", string.Empty);
		array[3] = new GUIContent(MKICHEFGHIF.ToString("Hero10002") + "ElapsedTime", string.Empty);
		array[8] = new GUIContent(HPIKECECAPA.ToString("설명") + "{0}", string.Empty);
		array[5] = new GUIContent(GFJEJHEPCPO.ToString("점점 마계 깊숙히 들어가고 있으니 한순간도 방심하지 말어!") + "master", string.Empty);
		array[6] = new GUIContent(HIIHPCPAPFE.ToString("Skill3Rpc") + " has been dismissed", string.Empty);
		array[2] = new GUIContent(DMEEFFMJDBP.ToString("Regen") + "기본공격시 대상체력6%에 해당하는 추가물리피해. 사용시 적챔피언에게 마법피해 및 이동속도감소", string.Empty);
		return array;
	}

	private void Start()
	{
	}

	public void OnGUIControl()
	{
		GUI.Window(10, GetActionToolbarRect(), JJCBLJALPEB, "PrefabSimulate - " + ((!FxmTestMain.inst.IsCurrentEffectObject()) ? "Not Selected" : FxmTestMain.inst.GetOriginalEffectObject().name));
	}

	private void HNMBAMBIGOB()
	{
		HOLHIAOEIFA = PlayerPrefs.GetInt("FxmTestControls.m_nPlayIndex", HOLHIAOEIFA);
		IOFOFHNBLJK = PlayerPrefs.GetInt("FxmTestControls.m_nTransIndex", IOFOFHNBLJK);
		m_fTimeScale = PlayerPrefs.GetFloat("FxmTestControls.m_fTimeScale", m_fTimeScale);
		JNODMJGECEB = PlayerPrefs.GetFloat("FxmTestControls.m_fDistPerTime", JNODMJGECEB);
		OMBLAAFHFMM = PlayerPrefs.GetInt("FxmTestControls.m_nRotateIndex", OMBLAAFHFMM);
		KNOJCNFLFKA = (HFBEONMIPGC)PlayerPrefs.GetInt("FxmTestControls.m_nTransAxis", (int)KNOJCNFLFKA);
		m_bMinimize = PlayerPrefs.GetInt("FxmTestControls.m_bMinimize", m_bMinimize ? 1 : 0) == 1;
		IBANFCCOGLK(m_fTimeScale);
	}

	private void JJCBLJALPEB(int OHGOBGOIECH)
	{
		Rect actionToolbarRect = GetActionToolbarRect();
		string text = string.Empty;
		string hGHPLBKKLFF = string.Empty;
		int num = 10;
		int aGJJOHLCJKF = 5;
		m_bMinimize = GUI.Toggle(new Rect(3f, 1f, CHCFDINMIIG.PHECOMGGPHD, CHCFDINMIIG.ACAHNBHJLMN), m_bMinimize, "Mini");
		if (GUI.changed)
		{
			PlayerPrefs.SetInt("FxmTestControls.m_bMinimize", m_bMinimize ? 1 : 0);
		}
		GUI.changed = false;
		Rect position;
		Rect fFDKKBBCHFD;
		if (CHCFDINMIIG.LNIOALGJLNI || m_bMinimize)
		{
			aGJJOHLCJKF = 1;
			fFDKKBBCHFD = CHCFDINMIIG.CNJEJJJCLBB(actionToolbarRect, 0, aGJJOHLCJKF, 0, 1);
			if (FxmTestMain.inst.IsCurrentEffectObject())
			{
				text = string.Format("P={0} M={1} T={2}", ANFGFGCGNFJ, LBMNKJJBGKH, DHINDOFDBEO);
				hGHPLBKKLFF = string.Format("ParticleCount = {0} MeshCount = {1}\n Mesh: Triangles = {2} Vertices = {3}", ANFGFGCGNFJ, LBMNKJJBGKH, DHINDOFDBEO, BMIKOMFENJH);
			}
			GUI.Box(CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num, 0, 2), text);
			if (FxmTestMain.inst.IsCurrentEffectObject())
			{
				float rightValue = ((3 > HOLHIAOEIFA) ? 10f : GJIFFOPKNOK[HOLHIAOEIFA]);
				fFDKKBBCHFD = CHCFDINMIIG.CNJEJJJCLBB(actionToolbarRect, 0, aGJJOHLCJKF, 0, 1);
				GUI.Box(CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num, 2, 2), "ElapsedTime " + (Time.time - NGIENEPCDMP).ToString("0.000"));
				position = CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num, 4, 4);
				position.y += 5f;
				GUI.HorizontalSlider(position, Time.time - NGIENEPCDMP, 0f, rightValue);
				fFDKKBBCHFD = CHCFDINMIIG.CNJEJJJCLBB(actionToolbarRect, 0, aGJJOHLCJKF, 0, 1);
				if (GUI.Button(CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num, 8, 2), "Restart"))
				{
					LBBEFGELGIP();
				}
			}
			return;
		}
		fFDKKBBCHFD = CHCFDINMIIG.CNJEJJJCLBB(actionToolbarRect, 0, aGJJOHLCJKF, 0, 2);
		if ((bool)NcEffectBehaviour.GetRootInstanceEffect())
		{
			text = string.Format("P = {0}\nM = {1}\nT = {2}", ANFGFGCGNFJ, LBMNKJJBGKH, DHINDOFDBEO);
			hGHPLBKKLFF = string.Format("ParticleCount = {0} MeshCount = {1}\n Mesh: Triangles = {2} Vertices = {3}", ANFGFGCGNFJ, LBMNKJJBGKH, DHINDOFDBEO, BMIKOMFENJH);
		}
		GUI.Box(CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num, 0, 1), new GUIContent(text, DGHGGAOJIPG(hGHPLBKKLFF)));
		if (FxmTestMain.inst.IsCurrentEffectObject())
		{
			bool flag = false;
			GUIContent[] hcEffectControls_Play = GetHcEffectControls_Play(0f, m_fTimeScale, GJIFFOPKNOK[1], GJIFFOPKNOK[3], GJIFFOPKNOK[4], GJIFFOPKNOK[5], GJIFFOPKNOK[6], GJIFFOPKNOK[7]);
			fFDKKBBCHFD = CHCFDINMIIG.CNJEJJJCLBB(actionToolbarRect, 0, aGJJOHLCJKF, 0, 1);
			GUI.Box(CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num, 1, 1), new GUIContent("Play", string.Empty));
			int hPGGALNGLIE = CHCFDINMIIG.HBDNFKGLPAL(actionToolbarRect, CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num, 2, 8), HOLHIAOEIFA, hcEffectControls_Play, hcEffectControls_Play.Length);
			if (GUI.changed)
			{
				flag = true;
			}
			GUIContent[] hcEffectControls_Trans = GetHcEffectControls_Trans(KNOJCNFLFKA);
			fFDKKBBCHFD = CHCFDINMIIG.CNJEJJJCLBB(actionToolbarRect, 0, aGJJOHLCJKF, 1, 1);
			GUI.Box(CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num, 1, 1), new GUIContent("Trans", string.Empty));
			int num2 = CHCFDINMIIG.HBDNFKGLPAL(actionToolbarRect, CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num, 2, 8), IOFOFHNBLJK, hcEffectControls_Trans, hcEffectControls_Trans.Length);
			if (GUI.changed)
			{
				flag = true;
				if ((num2 == 1 || num2 == 2) && Input.GetMouseButtonUp(1))
				{
					if (KNOJCNFLFKA == HFBEONMIPGC.Z)
					{
						KNOJCNFLFKA = HFBEONMIPGC.X;
					}
					else
					{
						KNOJCNFLFKA++;
					}
					PlayerPrefs.SetInt("FxmTestControls.m_nTransAxis", (int)KNOJCNFLFKA);
				}
			}
			if (flag)
			{
				FxmTestMain.inst.CreateCurrentInstanceEffect(false);
				NIIHJPCOJJD(hPGGALNGLIE, num2);
				PlayerPrefs.SetInt("FxmTestControls.m_nPlayIndex", HOLHIAOEIFA);
				PlayerPrefs.SetInt("FxmTestControls.m_nTransIndex", IOFOFHNBLJK);
			}
		}
		float jNODMJGECEB = JNODMJGECEB;
		fFDKKBBCHFD = CHCFDINMIIG.CNJEJJJCLBB(actionToolbarRect, 0, aGJJOHLCJKF, 2, 1);
		GUIContent gUIContent = new GUIContent("DistPerTime", string.Empty);
		GUIContent gUIContent2 = gUIContent;
		gUIContent2.text = gUIContent2.text + " " + JNODMJGECEB.ToString("00.00");
		GUI.Box(CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num, 0, 2), gUIContent);
		position = CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num, 2, 5);
		position.y += 5f;
		jNODMJGECEB = GUI.HorizontalSlider(position, jNODMJGECEB, 0.1f, 40f);
		if (GUI.Button(CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num * 2, 14, 1), new GUIContent("<", string.Empty)))
		{
			jNODMJGECEB = (int)(jNODMJGECEB - 1f);
		}
		if (GUI.Button(CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num * 2, 15, 1), new GUIContent(">", string.Empty)))
		{
			jNODMJGECEB = (int)(jNODMJGECEB + 1f);
		}
		if (jNODMJGECEB != JNODMJGECEB)
		{
			JNODMJGECEB = ((jNODMJGECEB != 0f) ? jNODMJGECEB : 0.1f);
			PlayerPrefs.SetFloat("FxmTestControls.m_fDistPerTime", JNODMJGECEB);
			if (0 < IOFOFHNBLJK)
			{
				LBBEFGELGIP();
			}
		}
		if (ACKONAFALLN.BFIMJDBOEEK(CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num, 9, 1), new GUIContent("Multi", AFAOGDPIEDD.ToString()), true))
		{
			if (Input.GetMouseButtonUp(0))
			{
				AFAOGDPIEDD++;
				if (4 < AFAOGDPIEDD)
				{
					AFAOGDPIEDD = 1;
				}
			}
			else
			{
				AFAOGDPIEDD = 1;
			}
			LBBEFGELGIP();
		}
		GUIContent[] hcEffectControls_Rotate = GetHcEffectControls_Rotate();
		fFDKKBBCHFD = CHCFDINMIIG.CNJEJJJCLBB(actionToolbarRect, 0, aGJJOHLCJKF, 2, 1);
		int num3 = CHCFDINMIIG.HBDNFKGLPAL(actionToolbarRect, CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num, 8, 1), OMBLAAFHFMM, hcEffectControls_Rotate, hcEffectControls_Rotate.Length);
		if (num3 != OMBLAAFHFMM)
		{
			OMBLAAFHFMM = num3;
			PlayerPrefs.SetInt("FxmTestControls.m_nRotateIndex", OMBLAAFHFMM);
			if (0 < IOFOFHNBLJK)
			{
				LBBEFGELGIP();
			}
		}
		float fTimeScale = m_fTimeScale;
		fFDKKBBCHFD = CHCFDINMIIG.CNJEJJJCLBB(actionToolbarRect, 0, aGJJOHLCJKF, 3, 1);
		gUIContent = new GUIContent("TimeScale", string.Empty);
		GUIContent gUIContent3 = gUIContent;
		gUIContent3.text = gUIContent3.text + " " + m_fTimeScale.ToString("0.00");
		GUI.Box(CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num, 0, 2), gUIContent);
		position = CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num, 2, 5);
		position.y += 5f;
		fTimeScale = GUI.HorizontalSlider(position, fTimeScale, 0f, 3f);
		if (fTimeScale == 0f)
		{
			if (GUI.Button(CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num, 7, 1), new GUIContent("Resume", string.Empty)))
			{
				fTimeScale = PBCLJDJLNOH;
			}
		}
		else if (GUI.Button(CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num, 7, 1), new GUIContent("Pause", string.Empty)))
		{
			fTimeScale = 0f;
		}
		if (GUI.Button(CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num, 8, 1), new GUIContent("Reset", string.Empty)))
		{
			fTimeScale = 1f;
		}
		IBANFCCOGLK(fTimeScale);
		if (FxmTestMain.inst.IsCurrentEffectObject())
		{
			float rightValue2 = ((3 > HOLHIAOEIFA) ? 10f : GJIFFOPKNOK[HOLHIAOEIFA]);
			fFDKKBBCHFD = CHCFDINMIIG.CNJEJJJCLBB(actionToolbarRect, 0, aGJJOHLCJKF, 4, 1);
			gUIContent = new GUIContent("ElapsedTime", string.Empty);
			GUIContent gUIContent4 = gUIContent;
			gUIContent4.text = gUIContent4.text + " " + (Time.time - NGIENEPCDMP).ToString("0.000");
			GUI.Box(CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num, 0, 2), gUIContent);
			position = CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num, 2, 5);
			position.y += 5f;
			GUI.HorizontalSlider(position, Time.time - NGIENEPCDMP, 0f, rightValue2);
			if (GUI.Button(CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num * 2, 14, 1), new GUIContent("+.5", string.Empty)))
			{
				IBANFCCOGLK(1f);
				Invoke("FJAFALKBCFO", 0.5f);
			}
			if (GUI.Button(CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num * 2, 15, 1), new GUIContent("+.1", string.Empty)))
			{
				IBANFCCOGLK(0.4f);
				Invoke("FJAFALKBCFO", 0.1f);
			}
			if (GUI.Button(CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num * 2, 16, 1), new GUIContent("+.05", string.Empty)))
			{
				IBANFCCOGLK(0.2f);
				Invoke("FJAFALKBCFO", 0.05f);
			}
			if (GUI.Button(CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num * 2, 17, 1), new GUIContent("+.01", string.Empty)))
			{
				IBANFCCOGLK(0.04f);
				Invoke("FJAFALKBCFO", 0.01f);
			}
			fFDKKBBCHFD = CHCFDINMIIG.CNJEJJJCLBB(actionToolbarRect, 0, aGJJOHLCJKF, 3, 2);
			if (GUI.Button(CHCFDINMIIG.EKKPMOOKBPO(fFDKKBBCHFD, num, 9, 1), new GUIContent("Restart", string.Empty)))
			{
				LBBEFGELGIP();
			}
		}
	}

	public Rect GetActionToolbarRect()
	{
		float num = (float)Screen.height * ((!m_bMinimize) ? 0.35f : 0.1f);
		return new Rect(0f, (float)Screen.height - num, Screen.width, num);
	}

	public bool IsRepeat()
	{
		return 3 <= HOLHIAOEIFA;
	}

	public float GetRepeatTime()
	{
		return GJIFFOPKNOK[HOLHIAOEIFA];
	}

	private void FJAFALKBCFO()
	{
		IBANFCCOGLK(0f);
	}

	protected void NIIHJPCOJJD(int HPGGALNGLIE, int APHOLEDIAKO)
	{
		JPOKIDIDDPA.KFILJDOOJBH("RunActionControl() - nPlayIndex " + HPGGALNGLIE);
		CancelInvoke();
		CAKJMLLINAA = false;
		ResumeTimeScale();
		KJLOFGFINDC = false;
		switch (HPGGALNGLIE)
		{
		case 2:
			IBANFCCOGLK(GJIFFOPKNOK[HPGGALNGLIE]);
			break;
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
			if (HPGGALNGLIE != HOLHIAOEIFA)
			{
				APHOLEDIAKO = 0;
			}
			break;
		}
		if (0 < APHOLEDIAKO)
		{
			float num = ((!(Camera.main != null)) ? 1f : (Vector3.Magnitude(Camera.main.transform.position) * 0.8f)) * BMGMNMCMJAH;
			GameObject instanceEffectObject = FxmTestMain.inst.GetInstanceEffectObject();
			GameObject gameObject = OKHCLMNPFFB.AJIPOBLNDAB(instanceEffectObject.transform.parent.gameObject, "simulate");
			FxmTestSimulate fxmTestSimulate = gameObject.AddComponent<FxmTestSimulate>();
			instanceEffectObject.transform.parent = gameObject.transform;
			FxmTestMain.inst.ChangeRoot_InstanceEffectObject(gameObject);
			fxmTestSimulate.Init(this, AFAOGDPIEDD);
			switch (APHOLEDIAKO)
			{
			case 1:
				fxmTestSimulate.SimulateMove(KNOJCNFLFKA, num, JNODMJGECEB, OMBLAAFHFMM == 0);
				break;
			case 2:
				fxmTestSimulate.SimulateScale(KNOJCNFLFKA, num * 0.3f, ELPDHPMGKNC, JNODMJGECEB, OMBLAAFHFMM == 0);
				break;
			case 3:
				fxmTestSimulate.SimulateArc(num * 0.7f, JNODMJGECEB, OMBLAAFHFMM == 0);
				break;
			case 4:
				fxmTestSimulate.SimulateFall(num * 0.7f, JNODMJGECEB, OMBLAAFHFMM == 0);
				break;
			case 5:
				fxmTestSimulate.SimulateRaise(num * 0.7f, JNODMJGECEB, OMBLAAFHFMM == 0);
				break;
			case 6:
				fxmTestSimulate.SimulateCircle(num * 0.5f, JNODMJGECEB, OMBLAAFHFMM == 0);
				break;
			case 7:
				fxmTestSimulate.SimulateTornado(num * 0.3f, num * 0.7f, JNODMJGECEB, OMBLAAFHFMM == 0);
				break;
			}
		}
		if (0 < APHOLEDIAKO && 3 <= HPGGALNGLIE)
		{
			HPGGALNGLIE = 0;
		}
		HOLHIAOEIFA = HPGGALNGLIE;
		IOFOFHNBLJK = APHOLEDIAKO;
		if (IsRepeat())
		{
			MIDFGFAIDCA = Time.time;
		}
	}

	private void PHNLBFPCJJE()
	{
		PlayerPrefs.SetInt("FxmTestControls.m_nPlayIndex", HOLHIAOEIFA);
		PlayerPrefs.SetInt("FxmTestControls.m_nTransIndex", IOFOFHNBLJK);
		PlayerPrefs.SetFloat("FxmTestControls.m_fTimeScale", m_fTimeScale);
		PlayerPrefs.SetFloat("FxmTestControls.m_fDistPerTime", JNODMJGECEB);
		PlayerPrefs.SetInt("FxmTestControls.m_nRotateIndex", OMBLAAFHFMM);
		PlayerPrefs.SetInt("FxmTestControls.m_nTransAxis", (int)KNOJCNFLFKA);
	}

	private string DGHGGAOJIPG(string HGHPLBKKLFF)
	{
		return HGHPLBKKLFF;
	}

	public void ResumeTimeScale()
	{
		if (m_fTimeScale == 0f)
		{
			IBANFCCOGLK(PBCLJDJLNOH);
		}
	}

	private void NDIEGKILKHF()
	{
		JPOKIDIDDPA.KFILJDOOJBH("스킨을 구매하시겠습니까?\n\n구매코인 : {0}코인");
		HNMBAMBIGOB();
	}

	private void LBNCLNOIGAL()
	{
		if (FxmTestMain.inst.m_bAutoChange)
		{
			FxmTestMain.inst.CJILANPGLBM(true);
		}
		else
		{
			LCOICKFDKNA();
		}
	}

	public float GetTimeScale()
	{
		return m_fTimeScale;
	}

	public void SetStartTime()
	{
		NGIENEPCDMP = Time.time;
	}

	private bool GBMHKBPMFFA()
	{
		GameObject rootInstanceEffect = NcEffectBehaviour.GetRootInstanceEffect();
		Transform[] componentsInChildren = rootInstanceEffect.GetComponentsInChildren<Transform>(true);
		Transform[] array = componentsInChildren;
		foreach (Transform transform in array)
		{
			int num = -1;
			int num2 = -1;
			bool flag = false;
			NcEffectBehaviour[] components = transform.GetComponents<NcEffectBehaviour>();
			NcEffectBehaviour[] array2 = components;
			foreach (NcEffectBehaviour ncEffectBehaviour in array2)
			{
				switch (ncEffectBehaviour.GetAnimationState())
				{
				case 1:
					num = 1;
					break;
				case 0:
					num = 0;
					break;
				}
			}
			if (transform.GetComponent<ParticleSystem>() != null)
			{
				num2 = 0;
				if (OKHCLMNPFFB.NHKIEEJHEJH(transform.gameObject) && ((transform.GetComponent<ParticleSystem>().enableEmission && transform.GetComponent<ParticleSystem>().IsAlive()) || 0 < transform.GetComponent<ParticleSystem>().particleCount))
				{
					num2 = 1;
				}
			}
			if (num2 < 1 && transform.GetComponent<ParticleEmitter>() != null)
			{
				num2 = 0;
				if (OKHCLMNPFFB.NHKIEEJHEJH(transform.gameObject) && (transform.GetComponent<ParticleEmitter>().emit || 0 < transform.GetComponent<ParticleEmitter>().particleCount))
				{
					num2 = 1;
				}
			}
			if (transform.GetComponent<Renderer>() != null && transform.GetComponent<Renderer>().enabled && OKHCLMNPFFB.NHKIEEJHEJH(transform.gameObject))
			{
				flag = true;
			}
			if (0 < num)
			{
				return true;
			}
			if (num2 == 1)
			{
				return true;
			}
			if (flag && (transform.GetComponent<MeshFilter>() != null || transform.GetComponent<TrailRenderer>() != null || transform.GetComponent<LineRenderer>() != null))
			{
				return true;
			}
		}
		return false;
	}
}
