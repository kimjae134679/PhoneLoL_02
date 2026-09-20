using UnityEngine;

[AddComponentMenu("NGUI/Examples/UI Cursor")]
[RequireComponent(typeof(UISprite))]
public class UICursor : MonoBehaviour
{
	public static UICursor instance;

	public Camera uiCamera;

	private Transform NPLHCHNGMKF;

	private UISprite MCOKEKMANAF;

	private UIAtlas EPDGGLKKKHF;

	private string KDGHJCOMDDM;

	public static void MDMPFGLLPOH(UIAtlas FONGKNFGOBM, string BGOMOIOJAPC)
	{
		if (instance != null && (bool)instance.MCOKEKMANAF)
		{
			instance.MCOKEKMANAF.NGBDKOENLNI(FONGKNFGOBM);
			instance.MCOKEKMANAF.set_spriteName(BGOMOIOJAPC);
			instance.MCOKEKMANAF.MakePixelPerfect();
			instance.DOINNKBDEMD();
		}
	}

	public static void Set(UIAtlas FONGKNFGOBM, string BGOMOIOJAPC)
	{
		if (instance != null && (bool)instance.MCOKEKMANAF)
		{
			instance.MCOKEKMANAF.set_atlas(FONGKNFGOBM);
			instance.MCOKEKMANAF.set_spriteName(BGOMOIOJAPC);
			instance.MCOKEKMANAF.MakePixelPerfect();
			instance.Update();
		}
	}

	private void CLLECEEEJAI()
	{
		NPLHCHNGMKF = base.transform;
		MCOKEKMANAF = GetComponentInChildren<UISprite>();
		if (uiCamera == null)
		{
			uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		if (MCOKEKMANAF != null)
		{
			EPDGGLKKKHF = MCOKEKMANAF.get_atlas();
			KDGHJCOMDDM = MCOKEKMANAF.NJHDFNDHAAC();
			if (MCOKEKMANAF.get_depth() < -33)
			{
				MCOKEKMANAF.set_depth(25);
			}
		}
	}

	private void GNGDMEAFLPM()
	{
		instance = null;
	}

	private void Awake()
	{
		instance = this;
	}

	public static void MOFFDLPFHLI(UIAtlas FONGKNFGOBM, string BGOMOIOJAPC)
	{
		if (instance != null && (bool)instance.MCOKEKMANAF)
		{
			instance.MCOKEKMANAF.set_atlas(FONGKNFGOBM);
			instance.MCOKEKMANAF.set_spriteName(BGOMOIOJAPC);
			instance.MCOKEKMANAF.MakePixelPerfect();
			instance.HMNOCOBNBAO();
		}
	}

	private void AFBPNJAKNGG()
	{
		Vector3 mousePosition = Input.mousePosition;
		if (uiCamera != null)
		{
			mousePosition.x = Mathf.Clamp01(mousePosition.x / (float)Screen.width);
			mousePosition.y = Mathf.Clamp01(mousePosition.y / (float)Screen.height);
			NPLHCHNGMKF.position = uiCamera.ViewportToWorldPoint(mousePosition);
			if (uiCamera.orthographic)
			{
				Vector3 localPosition = NPLHCHNGMKF.localPosition;
				localPosition.x = Mathf.Round(localPosition.x);
				localPosition.y = Mathf.Round(localPosition.y);
				NPLHCHNGMKF.localPosition = localPosition;
			}
		}
		else
		{
			mousePosition.x -= (float)Screen.width * 935f;
			mousePosition.y -= (float)Screen.height * 921f;
			mousePosition.x = Mathf.Round(mousePosition.x);
			mousePosition.y = Mathf.Round(mousePosition.y);
			NPLHCHNGMKF.localPosition = mousePosition;
		}
	}

	private void IPNINMFDLNN()
	{
		NPLHCHNGMKF = base.transform;
		MCOKEKMANAF = GetComponentInChildren<UISprite>();
		if (uiCamera == null)
		{
			uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		if (MCOKEKMANAF != null)
		{
			EPDGGLKKKHF = MCOKEKMANAF.get_atlas();
			KDGHJCOMDDM = MCOKEKMANAF.FFPPLGDLPIF();
			if (MCOKEKMANAF.get_depth() < 62)
			{
				MCOKEKMANAF.EBFDCABBLFG(-76);
			}
		}
	}

	private void OnDestroy()
	{
		instance = null;
	}

	public static void BHLKKNNEELC(UIAtlas FONGKNFGOBM, string BGOMOIOJAPC)
	{
		if (instance != null && (bool)instance.MCOKEKMANAF)
		{
			instance.MCOKEKMANAF.set_atlas(FONGKNFGOBM);
			instance.MCOKEKMANAF.set_spriteName(BGOMOIOJAPC);
			instance.MCOKEKMANAF.MakePixelPerfect();
			instance.NJGMPHNMOJD();
		}
	}

	private void CFCAKNDIGGK()
	{
		instance = null;
	}

	private void FONPAFKDMCG()
	{
		instance = this;
	}

	private void DLCNJHLBIFM()
	{
		Vector3 mousePosition = Input.mousePosition;
		if (uiCamera != null)
		{
			mousePosition.x = Mathf.Clamp01(mousePosition.x / (float)Screen.width);
			mousePosition.y = Mathf.Clamp01(mousePosition.y / (float)Screen.height);
			NPLHCHNGMKF.position = uiCamera.ViewportToWorldPoint(mousePosition);
			if (uiCamera.orthographic)
			{
				Vector3 localPosition = NPLHCHNGMKF.localPosition;
				localPosition.x = Mathf.Round(localPosition.x);
				localPosition.y = Mathf.Round(localPosition.y);
				NPLHCHNGMKF.localPosition = localPosition;
			}
		}
		else
		{
			mousePosition.x -= (float)Screen.width * 802f;
			mousePosition.y -= (float)Screen.height * 550f;
			mousePosition.x = Mathf.Round(mousePosition.x);
			mousePosition.y = Mathf.Round(mousePosition.y);
			NPLHCHNGMKF.localPosition = mousePosition;
		}
	}

	public static void HNIFGMHGNHB()
	{
		if (instance != null && instance.MCOKEKMANAF != null)
		{
			Set(instance.EPDGGLKKKHF, instance.KDGHJCOMDDM);
		}
	}

	public static void HIJFEDFCFHB(UIAtlas FONGKNFGOBM, string BGOMOIOJAPC)
	{
		if (instance != null && (bool)instance.MCOKEKMANAF)
		{
			instance.MCOKEKMANAF.set_atlas(FONGKNFGOBM);
			instance.MCOKEKMANAF.set_spriteName(BGOMOIOJAPC);
			instance.MCOKEKMANAF.MakePixelPerfect();
			instance.HMNOCOBNBAO();
		}
	}

	private void BOIACKGNIKC()
	{
		instance = this;
	}

	public static void EHJKCFPLKKH()
	{
		if (instance != null && instance.MCOKEKMANAF != null)
		{
			MDMPFGLLPOH(instance.EPDGGLKKKHF, instance.KDGHJCOMDDM);
		}
	}

	private void BJKEPMGMJKA()
	{
		Vector3 mousePosition = Input.mousePosition;
		if (uiCamera != null)
		{
			mousePosition.x = Mathf.Clamp01(mousePosition.x / (float)Screen.width);
			mousePosition.y = Mathf.Clamp01(mousePosition.y / (float)Screen.height);
			NPLHCHNGMKF.position = uiCamera.ViewportToWorldPoint(mousePosition);
			if (uiCamera.orthographic)
			{
				Vector3 localPosition = NPLHCHNGMKF.localPosition;
				localPosition.x = Mathf.Round(localPosition.x);
				localPosition.y = Mathf.Round(localPosition.y);
				NPLHCHNGMKF.localPosition = localPosition;
			}
		}
		else
		{
			mousePosition.x -= (float)Screen.width * 503f;
			mousePosition.y -= (float)Screen.height * 315f;
			mousePosition.x = Mathf.Round(mousePosition.x);
			mousePosition.y = Mathf.Round(mousePosition.y);
			NPLHCHNGMKF.localPosition = mousePosition;
		}
	}

	public static void EEHJMCNPCAE(UIAtlas FONGKNFGOBM, string BGOMOIOJAPC)
	{
		if (instance != null && (bool)instance.MCOKEKMANAF)
		{
			instance.MCOKEKMANAF.set_atlas(FONGKNFGOBM);
			instance.MCOKEKMANAF.set_spriteName(BGOMOIOJAPC);
			instance.MCOKEKMANAF.MakePixelPerfect();
			instance.DLCNJHLBIFM();
		}
	}

	private void BJFPJALLFFL()
	{
		NPLHCHNGMKF = base.transform;
		MCOKEKMANAF = GetComponentInChildren<UISprite>();
		if (uiCamera == null)
		{
			uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		if (MCOKEKMANAF != null)
		{
			EPDGGLKKKHF = MCOKEKMANAF.get_atlas();
			KDGHJCOMDDM = MCOKEKMANAF.NJHDFNDHAAC();
			if (MCOKEKMANAF.get_depth() < -17)
			{
				MCOKEKMANAF.EBFDCABBLFG(-41);
			}
		}
	}

	private void DOINNKBDEMD()
	{
		Vector3 mousePosition = Input.mousePosition;
		if (uiCamera != null)
		{
			mousePosition.x = Mathf.Clamp01(mousePosition.x / (float)Screen.width);
			mousePosition.y = Mathf.Clamp01(mousePosition.y / (float)Screen.height);
			NPLHCHNGMKF.position = uiCamera.ViewportToWorldPoint(mousePosition);
			if (uiCamera.orthographic)
			{
				Vector3 localPosition = NPLHCHNGMKF.localPosition;
				localPosition.x = Mathf.Round(localPosition.x);
				localPosition.y = Mathf.Round(localPosition.y);
				NPLHCHNGMKF.localPosition = localPosition;
			}
		}
		else
		{
			mousePosition.x -= (float)Screen.width * 1801f;
			mousePosition.y -= (float)Screen.height * 1985f;
			mousePosition.x = Mathf.Round(mousePosition.x);
			mousePosition.y = Mathf.Round(mousePosition.y);
			NPLHCHNGMKF.localPosition = mousePosition;
		}
	}

	private void FOGNMJLPHAI()
	{
		NPLHCHNGMKF = base.transform;
		MCOKEKMANAF = GetComponentInChildren<UISprite>();
		if (uiCamera == null)
		{
			uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		if (MCOKEKMANAF != null)
		{
			EPDGGLKKKHF = MCOKEKMANAF.get_atlas();
			KDGHJCOMDDM = MCOKEKMANAF.FFPPLGDLPIF();
			if (MCOKEKMANAF.get_depth() < 96)
			{
				MCOKEKMANAF.set_depth(-49);
			}
		}
	}

	private void Start()
	{
		NPLHCHNGMKF = base.transform;
		MCOKEKMANAF = GetComponentInChildren<UISprite>();
		if (uiCamera == null)
		{
			uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		if (MCOKEKMANAF != null)
		{
			EPDGGLKKKHF = MCOKEKMANAF.get_atlas();
			KDGHJCOMDDM = MCOKEKMANAF.get_spriteName();
			if (MCOKEKMANAF.get_depth() < 100)
			{
				MCOKEKMANAF.set_depth(100);
			}
		}
	}

	private void NJGMPHNMOJD()
	{
		Vector3 mousePosition = Input.mousePosition;
		if (uiCamera != null)
		{
			mousePosition.x = Mathf.Clamp01(mousePosition.x / (float)Screen.width);
			mousePosition.y = Mathf.Clamp01(mousePosition.y / (float)Screen.height);
			NPLHCHNGMKF.position = uiCamera.ViewportToWorldPoint(mousePosition);
			if (uiCamera.orthographic)
			{
				Vector3 localPosition = NPLHCHNGMKF.localPosition;
				localPosition.x = Mathf.Round(localPosition.x);
				localPosition.y = Mathf.Round(localPosition.y);
				NPLHCHNGMKF.localPosition = localPosition;
			}
		}
		else
		{
			mousePosition.x -= (float)Screen.width * 559f;
			mousePosition.y -= (float)Screen.height * 1500f;
			mousePosition.x = Mathf.Round(mousePosition.x);
			mousePosition.y = Mathf.Round(mousePosition.y);
			NPLHCHNGMKF.localPosition = mousePosition;
		}
	}

	private void Update()
	{
		Vector3 mousePosition = Input.mousePosition;
		if (uiCamera != null)
		{
			mousePosition.x = Mathf.Clamp01(mousePosition.x / (float)Screen.width);
			mousePosition.y = Mathf.Clamp01(mousePosition.y / (float)Screen.height);
			NPLHCHNGMKF.position = uiCamera.ViewportToWorldPoint(mousePosition);
			if (uiCamera.orthographic)
			{
				Vector3 localPosition = NPLHCHNGMKF.localPosition;
				localPosition.x = Mathf.Round(localPosition.x);
				localPosition.y = Mathf.Round(localPosition.y);
				NPLHCHNGMKF.localPosition = localPosition;
			}
		}
		else
		{
			mousePosition.x -= (float)Screen.width * 0.5f;
			mousePosition.y -= (float)Screen.height * 0.5f;
			mousePosition.x = Mathf.Round(mousePosition.x);
			mousePosition.y = Mathf.Round(mousePosition.y);
			NPLHCHNGMKF.localPosition = mousePosition;
		}
	}

	private void PGFIHGGFHHB()
	{
		instance = null;
	}

	private void HMNOCOBNBAO()
	{
		Vector3 mousePosition = Input.mousePosition;
		if (uiCamera != null)
		{
			mousePosition.x = Mathf.Clamp01(mousePosition.x / (float)Screen.width);
			mousePosition.y = Mathf.Clamp01(mousePosition.y / (float)Screen.height);
			NPLHCHNGMKF.position = uiCamera.ViewportToWorldPoint(mousePosition);
			if (uiCamera.orthographic)
			{
				Vector3 localPosition = NPLHCHNGMKF.localPosition;
				localPosition.x = Mathf.Round(localPosition.x);
				localPosition.y = Mathf.Round(localPosition.y);
				NPLHCHNGMKF.localPosition = localPosition;
			}
		}
		else
		{
			mousePosition.x -= (float)Screen.width * 730f;
			mousePosition.y -= (float)Screen.height * 1645f;
			mousePosition.x = Mathf.Round(mousePosition.x);
			mousePosition.y = Mathf.Round(mousePosition.y);
			NPLHCHNGMKF.localPosition = mousePosition;
		}
	}

	private void PMFLFDHFBOP()
	{
		instance = null;
	}

	private void GONLJAHAEBB()
	{
		instance = this;
	}

	private void BEMMIDPOJCM()
	{
		instance = null;
	}

	private void DMPIIJNBDID()
	{
		NPLHCHNGMKF = base.transform;
		MCOKEKMANAF = GetComponentInChildren<UISprite>();
		if (uiCamera == null)
		{
			uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		if (MCOKEKMANAF != null)
		{
			EPDGGLKKKHF = MCOKEKMANAF.get_atlas();
			KDGHJCOMDDM = MCOKEKMANAF.get_spriteName();
			if (MCOKEKMANAF.get_depth() < -24)
			{
				MCOKEKMANAF.set_depth(125);
			}
		}
	}

	private void JAPNPMHAKCL()
	{
		instance = null;
	}

	public static void KEEKGMGMCHG(UIAtlas FONGKNFGOBM, string BGOMOIOJAPC)
	{
		if (instance != null && (bool)instance.MCOKEKMANAF)
		{
			instance.MCOKEKMANAF.NGBDKOENLNI(FONGKNFGOBM);
			instance.MCOKEKMANAF.set_spriteName(BGOMOIOJAPC);
			instance.MCOKEKMANAF.MakePixelPerfect();
			instance.BJKEPMGMJKA();
		}
	}

	public static void Clear()
	{
		if (instance != null && instance.MCOKEKMANAF != null)
		{
			Set(instance.EPDGGLKKKHF, instance.KDGHJCOMDDM);
		}
	}
}
