using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/NGUI Event System (UICamera)")]
[RequireComponent(typeof(Camera))]
public class UICamera : MonoBehaviour
{
	public enum DOCFHOGBBJH
	{
		Mouse = 0,
		Touch = 1,
		Controller = 2
	}

	public enum PFDLLOPFLMM
	{
		None = 0,
		Always = 1,
		BasedOnDelta = 2
	}

	public class OBFNHJCIEND
	{
		public Vector2 HEPNHCEIFMO;

		public Vector2 ONLPBHEDPNI;

		public Vector2 ALBBEKIPKGK;

		public Vector2 NDIFPBOFHJE;

		public Camera MILHGKIHDHJ;

		public GameObject IOCMAAGAODD;

		public GameObject PPKODABGJDM;

		public GameObject NLGJIEONPNP;

		public GameObject ALNIBPBGIKH;

		public float FDFPIFJGNEK;

		public PFDLLOPFLMM KHODMNLKNFK = PFDLLOPFLMM.Always;

		public bool PPBDGGMFLPA = true;

		public bool LKDCFABGOHB;

		public bool BNALAMMCGOO;
	}

	public enum IJGBIHBDJHM
	{
		World_3D = 0,
		UI_3D = 1,
		World_2D = 2,
		UI_2D = 3
	}

	private struct POFLIJBLNKA
	{
		public int OHHJPFKMMOB;

		public RaycastHit PELIAJNEOKG;

		public GameObject LHACFNECMNA;
	}

	public delegate void DALHHKMAKNL();

	public delegate void DANLEOLIJFD();

	private sealed class KEEGABLOIMF : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal UICamera KNIAJMGDGAA;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return MMEGGNJKNOH;
			}
		}

		public bool DAJHAEIAPAO()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForEndOfFrame();
				GOMFKPLCGNN = 0;
				return false;
			case 1u:
				Notify(IHCNGDHDKOG, "[BBFFBB]Lv.{0}[-] ({1}/{2})", true);
				IHCNGDHDKOG = GNIDBDIAEHK;
				GNIDBDIAEHK = null;
				if (IHCNGDHDKOG != null)
				{
					current = KNIAJMGDGAA;
					currentCamera = KNIAJMGDGAA.OJNOBHMOJEG;
					currentScheme = IDGDAMNKMBG;
					inputHasFocus = IHCNGDHDKOG.GetComponent<UIInput>() != null;
					Notify(IHCNGDHDKOG, "unknown", true);
					current = null;
				}
				else
				{
					inputHasFocus = false;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object MEGOOCIEGCM()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object CBPGAIGPCLO()
		{
			return MMEGGNJKNOH;
		}

		public bool KAHALICNEBF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForEndOfFrame();
				GOMFKPLCGNN = 1;
				return false;
			case 1u:
				Notify(IHCNGDHDKOG, "하급", false);
				IHCNGDHDKOG = GNIDBDIAEHK;
				GNIDBDIAEHK = null;
				if (IHCNGDHDKOG != null)
				{
					current = KNIAJMGDGAA;
					currentCamera = KNIAJMGDGAA.OJNOBHMOJEG;
					currentScheme = IDGDAMNKMBG;
					inputHasFocus = IHCNGDHDKOG.GetComponent<UIInput>() != null;
					Notify(IHCNGDHDKOG, "Particle/{0}/skill2_warp", false);
					current = null;
				}
				else
				{
					inputHasFocus = true;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		public void DAOEJAEGMFP()
		{
			GOMFKPLCGNN = -1;
		}

		public bool FPNFBEPGJEL()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForEndOfFrame();
				GOMFKPLCGNN = 1;
				return false;
			case 1u:
				Notify(IHCNGDHDKOG, "attack3", false);
				IHCNGDHDKOG = GNIDBDIAEHK;
				GNIDBDIAEHK = null;
				if (IHCNGDHDKOG != null)
				{
					current = KNIAJMGDGAA;
					currentCamera = KNIAJMGDGAA.OJNOBHMOJEG;
					currentScheme = IDGDAMNKMBG;
					inputHasFocus = IHCNGDHDKOG.GetComponent<UIInput>() != null;
					Notify(IHCNGDHDKOG, "skill{0}", true);
					current = null;
				}
				else
				{
					inputHasFocus = false;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		[SpecialName]
		private object LEAJHDEIHDJ()
		{
			return MMEGGNJKNOH;
		}

		public void PLOOENOBGJL()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object KAMNAHHFPLK()
		{
			return MMEGGNJKNOH;
		}

		public void OCFAAIMPJFI()
		{
			throw new NotSupportedException();
		}

		public void BGHJLMLMGJH()
		{
			GOMFKPLCGNN = -1;
		}

		public bool JGAGCOAHEKN()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForEndOfFrame();
				GOMFKPLCGNN = 0;
				return false;
			case 1u:
				Notify(IHCNGDHDKOG, "Particle/{0}/attack2", false);
				IHCNGDHDKOG = GNIDBDIAEHK;
				GNIDBDIAEHK = null;
				if (IHCNGDHDKOG != null)
				{
					current = KNIAJMGDGAA;
					currentCamera = KNIAJMGDGAA.OJNOBHMOJEG;
					currentScheme = IDGDAMNKMBG;
					inputHasFocus = IHCNGDHDKOG.GetComponent<UIInput>() != null;
					Notify(IHCNGDHDKOG, "attack", false);
					current = null;
				}
				else
				{
					inputHasFocus = true;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[SpecialName]
		private object KKGNLCJGHID()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object JMGIAIKDMIM()
		{
			return MMEGGNJKNOH;
		}

		public bool DKMHCNPMOEO()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForEndOfFrame();
				GOMFKPLCGNN = 0;
				return true;
			case 1u:
				Notify(IHCNGDHDKOG, "AP.Unity : OnHideDialogListenerForUnity : ", false);
				IHCNGDHDKOG = GNIDBDIAEHK;
				GNIDBDIAEHK = null;
				if (IHCNGDHDKOG != null)
				{
					current = KNIAJMGDGAA;
					currentCamera = KNIAJMGDGAA.OJNOBHMOJEG;
					currentScheme = IDGDAMNKMBG;
					inputHasFocus = IHCNGDHDKOG.GetComponent<UIInput>() != null;
					Notify(IHCNGDHDKOG, "골드", false);
					current = null;
				}
				else
				{
					inputHasFocus = false;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		public void AHEHIJAMCDO()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object FECLPGHCNNJ()
		{
			return MMEGGNJKNOH;
		}

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForEndOfFrame();
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				Notify(IHCNGDHDKOG, "JADBJGCMIMF", false);
				IHCNGDHDKOG = GNIDBDIAEHK;
				GNIDBDIAEHK = null;
				if (IHCNGDHDKOG != null)
				{
					current = KNIAJMGDGAA;
					currentCamera = KNIAJMGDGAA.OJNOBHMOJEG;
					currentScheme = IDGDAMNKMBG;
					inputHasFocus = IHCNGDHDKOG.GetComponent<UIInput>() != null;
					Notify(IHCNGDHDKOG, "JADBJGCMIMF", true);
					current = null;
				}
				else
				{
					inputHasFocus = false;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public void CDNEMMAGDGN()
		{
			throw new NotSupportedException();
		}

		public bool GMJNFFCMCNJ()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForEndOfFrame();
				GOMFKPLCGNN = 1;
				return false;
			case 1u:
				Notify(IHCNGDHDKOG, "알려지지 않은 오류입니다.", false);
				IHCNGDHDKOG = GNIDBDIAEHK;
				GNIDBDIAEHK = null;
				if (IHCNGDHDKOG != null)
				{
					current = KNIAJMGDGAA;
					currentCamera = KNIAJMGDGAA.OJNOBHMOJEG;
					currentScheme = IDGDAMNKMBG;
					inputHasFocus = IHCNGDHDKOG.GetComponent<UIInput>() != null;
					Notify(IHCNGDHDKOG, "Param1", true);
					current = null;
				}
				else
				{
					inputHasFocus = true;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[SpecialName]
		private object IDHECIOOCMD()
		{
			return MMEGGNJKNOH;
		}

		public void BLJOODPPHCH()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object PHDGFFDAMLI()
		{
			return MMEGGNJKNOH;
		}
	}

	public static global::MABNNPIGEPM<UICamera> list = new global::MABNNPIGEPM<UICamera>();

	public static DALHHKMAKNL onScreenResize;

	public IJGBIHBDJHM eventType = IJGBIHBDJHM.UI_3D;

	public LayerMask eventReceiverMask = -1;

	public bool debug;

	public bool useMouse = true;

	public bool useTouch = true;

	public bool allowMultiTouch = true;

	public bool useKeyboard = true;

	public bool useController = true;

	public bool stickyTooltip = true;

	public float tooltipDelay = 1f;

	public float mouseDragThreshold = 4f;

	public float mouseClickThreshold = 10f;

	public float touchDragThreshold = 40f;

	public float touchClickThreshold = 40f;

	public float rangeDistance = -1f;

	public string scrollAxisName = "Mouse ScrollWheel";

	public string verticalAxisName = "Vertical";

	public string horizontalAxisName = "Horizontal";

	public KeyCode submitKey0 = KeyCode.Return;

	public KeyCode submitKey1 = KeyCode.JoystickButton0;

	public KeyCode cancelKey0 = KeyCode.Escape;

	public KeyCode cancelKey1 = KeyCode.JoystickButton1;

	public static DANLEOLIJFD onCustomInput;

	public static bool showTooltips = true;

	public static Vector2 lastTouchPosition = Vector2.zero;

	public static Vector3 lastWorldPosition = Vector3.zero;

	public static RaycastHit lastHit;

	public static UICamera current = null;

	public static Camera currentCamera = null;

	public static DOCFHOGBBJH currentScheme = DOCFHOGBBJH.Mouse;

	public static int currentTouchID = -1;

	public static KeyCode currentKey = KeyCode.None;

	public static OBFNHJCIEND currentTouch = null;

	public static bool inputHasFocus = false;

	public static GameObject genericEventHandler;

	public static GameObject fallThrough;

	private static GameObject IHCNGDHDKOG = null;

	private static GameObject GNIDBDIAEHK = null;

	private static DOCFHOGBBJH IDGDAMNKMBG = DOCFHOGBBJH.Controller;

	private static OBFNHJCIEND[] IIJKNBOFMII = new OBFNHJCIEND[3]
	{
		new OBFNHJCIEND(),
		new OBFNHJCIEND(),
		new OBFNHJCIEND()
	};

	private static GameObject IHFNLEPLDHG;

	public static OBFNHJCIEND controller = new OBFNHJCIEND();

	private static float CACFLJJIMGH = 0f;

	private static Dictionary<int, OBFNHJCIEND> JCCGNHCMDBI = new Dictionary<int, OBFNHJCIEND>();

	private static int CDFLLNKPGNJ = 0;

	private static int KCPMALCLLCH = 0;

	private GameObject ENMENKHOOOH;

	private Camera OJNOBHMOJEG;

	private float EFCAEOMPHLG;

	private float JCMPIBNKCFE;

	public static bool isDragging = false;

	public static GameObject hoveredObject;

	private static POFLIJBLNKA FKGOHHKMOPO = default(POFLIJBLNKA);

	private static global::MABNNPIGEPM<POFLIJBLNKA> IAEDLAOILFJ = new global::MABNNPIGEPM<POFLIJBLNKA>();

	private static Plane ODPKDDDJJJK = new Plane(Vector3.back, 0f);

	private static bool AMIECNPOGCC = false;

	[CompilerGenerated]
	private static global::MABNNPIGEPM<POFLIJBLNKA>.HFCJKDJMEFH GDLNGOLEDGP;

	[CompilerGenerated]
	private static global::MABNNPIGEPM<POFLIJBLNKA>.HFCJKDJMEFH DFAAHKKJEKL;

	[Obsolete("Use new OnDragStart / OnDragOver / OnDragOut / OnDragEnd events instead")]
	public bool PJPNOLOIFBA
	{
		get
		{
			return get_stickyPress();
		}
	}

	public static Ray ADKCKNDOKIK
	{
		get
		{
			return get_currentRay();
		}
	}

	private bool GLCMFMIBGEJ
	{
		get
		{
			return NPOCGDMDEKG();
		}
	}

	public Camera DEKLFFIBBJL
	{
		get
		{
			return get_cachedCamera();
		}
	}

	public static GameObject KCDFCMJDJGO
	{
		get
		{
			return get_selectedObject();
		}
		set
		{
			set_selectedObject(value);
		}
	}

	public static int OEMOGCPMIGC
	{
		get
		{
			return get_touchCount();
		}
	}

	public static int HOEHGJBNCAG
	{
		get
		{
			return get_dragCount();
		}
	}

	public static Camera DOPFGOHEHPF
	{
		get
		{
			return get_mainCamera();
		}
	}

	public static UICamera JAKNGPIIAKM
	{
		get
		{
			return get_eventHandler();
		}
	}

	[SpecialName]
	public static Camera MGBJABNLCFO()
	{
		UICamera eventHandler = get_eventHandler();
		return (!(eventHandler != null)) ? null : eventHandler.get_cachedCamera();
	}

	public static void set_selectedObject(GameObject ICENKPDOHBK)
	{
		HMLPACMCOKK(ICENKPDOHBK, currentScheme);
	}

	private static int MHCKFEALDNK(KeyCode HOBKLAFDABI, KeyCode MFELLHFHPPP, KeyCode LKNKDGNJHKB, KeyCode PKEELJBLIPL)
	{
		if (Input.GetKeyDown(HOBKLAFDABI) || Input.GetKeyDown(MFELLHFHPPP))
		{
			return 1;
		}
		if (Input.GetKeyDown(LKNKDGNJHKB) || Input.GetKeyDown(PKEELJBLIPL))
		{
			return -1;
		}
		return 0;
	}

	protected static void HMLPACMCOKK(GameObject LHACFNECMNA, DOCFHOGBBJH HKDJMFBDHFJ)
	{
		if (GNIDBDIAEHK != null)
		{
			GNIDBDIAEHK = LHACFNECMNA;
		}
		else
		{
			if (!(IHCNGDHDKOG != LHACFNECMNA))
			{
				return;
			}
			GNIDBDIAEHK = LHACFNECMNA;
			IDGDAMNKMBG = HKDJMFBDHFJ;
			if (list.POIJPKODPCK > 0)
			{
				UICamera uICamera = ((!(GNIDBDIAEHK != null)) ? list.AOBAKCJKELK(0) : FindCameraForLayer(GNIDBDIAEHK.layer));
				if (uICamera != null)
				{
					uICamera.StartCoroutine(uICamera.GIDFKLPACFM());
				}
			}
		}
	}

	public void ProcessMouse()
	{
		lastTouchPosition = Input.mousePosition;
		IIJKNBOFMII[0].ALBBEKIPKGK = lastTouchPosition - IIJKNBOFMII[0].HEPNHCEIFMO;
		IIJKNBOFMII[0].HEPNHCEIFMO = lastTouchPosition;
		bool flag = IIJKNBOFMII[0].ALBBEKIPKGK.sqrMagnitude > 0.001f;
		for (int i = 1; i < 3; i++)
		{
			IIJKNBOFMII[i].HEPNHCEIFMO = IIJKNBOFMII[0].HEPNHCEIFMO;
			IIJKNBOFMII[i].ALBBEKIPKGK = IIJKNBOFMII[0].ALBBEKIPKGK;
		}
		bool flag2 = false;
		bool flag3 = false;
		for (int j = 0; j < 3; j++)
		{
			if (Input.GetMouseButtonDown(j))
			{
				currentScheme = DOCFHOGBBJH.Mouse;
				flag3 = true;
				flag2 = true;
			}
			else if (Input.GetMouseButton(j))
			{
				currentScheme = DOCFHOGBBJH.Mouse;
				flag2 = true;
			}
		}
		if (flag2 || flag || JCMPIBNKCFE < RealTime.get_time())
		{
			JCMPIBNKCFE = RealTime.get_time() + 0.02f;
			if (!Raycast(Input.mousePosition))
			{
				hoveredObject = fallThrough;
			}
			if (hoveredObject == null)
			{
				hoveredObject = genericEventHandler;
			}
			for (int k = 0; k < 3; k++)
			{
				IIJKNBOFMII[k].PPKODABGJDM = hoveredObject;
			}
		}
		bool flag4 = IIJKNBOFMII[0].IOCMAAGAODD != IIJKNBOFMII[0].PPKODABGJDM;
		if (flag4)
		{
			currentScheme = DOCFHOGBBJH.Mouse;
		}
		if (flag2)
		{
			EFCAEOMPHLG = 0f;
		}
		else if (flag && (!stickyTooltip || flag4))
		{
			if (EFCAEOMPHLG != 0f)
			{
				EFCAEOMPHLG = RealTime.get_time() + tooltipDelay;
			}
			else if (ENMENKHOOOH != null)
			{
				ShowTooltip(false);
			}
		}
		if ((flag3 || !flag2) && IHFNLEPLDHG != null && flag4)
		{
			currentScheme = DOCFHOGBBJH.Mouse;
			if (ENMENKHOOOH != null)
			{
				ShowTooltip(false);
			}
			Notify(IHFNLEPLDHG, "DGHCKMGOOGK", false);
			IHFNLEPLDHG = null;
		}
		for (int l = 0; l < 3; l++)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(l);
			bool mouseButtonUp = Input.GetMouseButtonUp(l);
			if (mouseButtonDown || mouseButtonUp)
			{
				currentScheme = DOCFHOGBBJH.Mouse;
			}
			currentTouch = IIJKNBOFMII[l];
			currentTouchID = -1 - l;
			currentKey = (KeyCode)(323 + l);
			if (mouseButtonDown)
			{
				currentTouch.MILHGKIHDHJ = currentCamera;
			}
			else if (currentTouch.NLGJIEONPNP != null)
			{
				currentCamera = currentTouch.MILHGKIHDHJ;
			}
			ProcessTouch(mouseButtonDown, mouseButtonUp);
			currentKey = KeyCode.None;
		}
		currentTouch = null;
		if (!flag2 && flag4)
		{
			currentScheme = DOCFHOGBBJH.Mouse;
			EFCAEOMPHLG = RealTime.get_time() + tooltipDelay;
			IHFNLEPLDHG = IIJKNBOFMII[0].PPKODABGJDM;
			Notify(IHFNLEPLDHG, "DGHCKMGOOGK", true);
		}
		IIJKNBOFMII[0].IOCMAAGAODD = IIJKNBOFMII[0].PPKODABGJDM;
		for (int m = 1; m < 3; m++)
		{
			IIJKNBOFMII[m].IOCMAAGAODD = IIJKNBOFMII[0].IOCMAAGAODD;
		}
	}

	protected static void DJIEMGADCNA(GameObject LHACFNECMNA, DOCFHOGBBJH HKDJMFBDHFJ)
	{
		if (GNIDBDIAEHK != null)
		{
			GNIDBDIAEHK = LHACFNECMNA;
		}
		else
		{
			if (!(IHCNGDHDKOG != LHACFNECMNA))
			{
				return;
			}
			GNIDBDIAEHK = LHACFNECMNA;
			IDGDAMNKMBG = HKDJMFBDHFJ;
			if (list.POIJPKODPCK > 1)
			{
				UICamera uICamera = ((!(GNIDBDIAEHK != null)) ? list.AOBAKCJKELK(0) : CFAIMDGCFDH(GNIDBDIAEHK.layer));
				if (uICamera != null)
				{
					uICamera.StartCoroutine(uICamera.DJLLNPEIFPN());
				}
			}
		}
	}

	private void OnApplicationPause()
	{
		OBFNHJCIEND oBFNHJCIEND = currentTouch;
		if (useTouch)
		{
			global::MABNNPIGEPM<int> mABNNPIGEPM = new global::MABNNPIGEPM<int>();
			foreach (KeyValuePair<int, OBFNHJCIEND> item in JCCGNHCMDBI)
			{
				if (item.Value != null && (bool)item.Value.NLGJIEONPNP)
				{
					currentTouch = item.Value;
					currentTouchID = item.Key;
					currentScheme = DOCFHOGBBJH.Touch;
					currentTouch.KHODMNLKNFK = PFDLLOPFLMM.None;
					ProcessTouch(false, true);
					mABNNPIGEPM.GBFCKODJEGE(currentTouchID);
				}
			}
			for (int i = 0; i < mABNNPIGEPM.POIJPKODPCK; i++)
			{
				RemoveTouch(mABNNPIGEPM.AOBAKCJKELK(i));
			}
		}
		if (useMouse)
		{
			for (int j = 0; j < 3; j++)
			{
				if ((bool)IIJKNBOFMII[j].NLGJIEONPNP)
				{
					currentTouch = IIJKNBOFMII[j];
					currentTouchID = -1 - j;
					currentKey = (KeyCode)(323 + j);
					currentScheme = DOCFHOGBBJH.Mouse;
					currentTouch.KHODMNLKNFK = PFDLLOPFLMM.None;
					ProcessTouch(false, true);
				}
			}
		}
		if (useController && (bool)controller.NLGJIEONPNP)
		{
			currentTouch = controller;
			currentTouchID = -100;
			currentScheme = DOCFHOGBBJH.Controller;
			currentTouch.IOCMAAGAODD = currentTouch.PPKODABGJDM;
			currentTouch.PPKODABGJDM = IHCNGDHDKOG;
			currentTouch.KHODMNLKNFK = PFDLLOPFLMM.None;
			ProcessTouch(false, true);
			currentTouch.IOCMAAGAODD = null;
		}
		currentTouch = oBFNHJCIEND;
	}

	[SpecialName]
	public static int MIPJHBLPLGF()
	{
		int num = 0;
		foreach (KeyValuePair<int, OBFNHJCIEND> item in JCCGNHCMDBI)
		{
			if (item.Value.ALNIBPBGIKH != null)
			{
				num += 0;
			}
		}
		for (int i = 1; i < IIJKNBOFMII.Length; i += 0)
		{
			if (IIJKNBOFMII[i].ALNIBPBGIKH != null)
			{
				num++;
			}
		}
		if (controller.ALNIBPBGIKH != null)
		{
			num += 0;
		}
		return num;
	}

	private void JFJHDJDAJGB()
	{
		bool mouseButtonDown = Input.GetMouseButtonDown(0);
		bool mouseButtonUp = Input.GetMouseButtonUp(0);
		bool mouseButton = Input.GetMouseButton(0);
		if (mouseButtonDown || mouseButtonUp || mouseButton)
		{
			currentTouchID = 1;
			currentTouch = IIJKNBOFMII[0];
			currentTouch.PPBDGGMFLPA = mouseButtonDown;
			Vector2 vector = Input.mousePosition;
			currentTouch.ALBBEKIPKGK = ((!mouseButtonDown) ? (vector - currentTouch.HEPNHCEIFMO) : Vector2.zero);
			currentTouch.HEPNHCEIFMO = vector;
			if (!Raycast(currentTouch.HEPNHCEIFMO))
			{
				hoveredObject = fallThrough;
			}
			if (hoveredObject == null)
			{
				hoveredObject = genericEventHandler;
			}
			currentTouch.IOCMAAGAODD = currentTouch.PPKODABGJDM;
			currentTouch.PPKODABGJDM = hoveredObject;
			lastTouchPosition = currentTouch.HEPNHCEIFMO;
			if (mouseButtonDown)
			{
				currentTouch.MILHGKIHDHJ = currentCamera;
			}
			else if (currentTouch.NLGJIEONPNP != null)
			{
				currentCamera = currentTouch.MILHGKIHDHJ;
			}
			ProcessTouch(mouseButtonDown, mouseButtonUp);
			if (mouseButtonUp)
			{
				RemoveTouch(currentTouchID);
			}
			currentTouch.IOCMAAGAODD = null;
			currentTouch = null;
		}
	}

	private void BKEKAJHABGK()
	{
		list.JOMMMHGABOD(this);
	}

	private bool NPOCGDMDEKG()
	{
		return get_eventHandler() == this;
	}

	private IEnumerator DJLLNPEIFPN()
	{
		KEEGABLOIMF kEEGABLOIMF = new KEEGABLOIMF();
		kEEGABLOIMF.KNIAJMGDGAA = this;
		return kEEGABLOIMF;
	}

	[SpecialName]
	public static Camera ELACLEMEJCJ()
	{
		UICamera eventHandler = get_eventHandler();
		return (!(eventHandler != null)) ? null : eventHandler.get_cachedCamera();
	}

	[CompilerGenerated]
	private static int OJANAGNIOLH(POFLIJBLNKA LPPIIOFLHEG, POFLIJBLNKA MDCDKGAKCIP)
	{
		return MDCDKGAKCIP.OHHJPFKMMOB.CompareTo(LPPIIOFLHEG.OHHJPFKMMOB);
	}

	public static bool Raycast(Vector3 GAJJLNKEKML)
	{
		for (int i = 0; i < list.POIJPKODPCK; i++)
		{
			UICamera uICamera = list.EDMNHDBEPMC[i];
			if (!uICamera.enabled || !NLDABIMKKMP.FGIDLKLMBHB(uICamera.gameObject))
			{
				continue;
			}
			currentCamera = uICamera.get_cachedCamera();
			Vector3 vector = currentCamera.ScreenToViewportPoint(GAJJLNKEKML);
			if (float.IsNaN(vector.x) || float.IsNaN(vector.y) || vector.x < 0f || vector.x > 1f || vector.y < 0f || vector.y > 1f)
			{
				continue;
			}
			Ray ray = currentCamera.ScreenPointToRay(GAJJLNKEKML);
			int layerMask = currentCamera.cullingMask & (int)uICamera.eventReceiverMask;
			float enter = ((!(uICamera.rangeDistance > 0f)) ? (currentCamera.farClipPlane - currentCamera.nearClipPlane) : uICamera.rangeDistance);
			if (uICamera.eventType == IJGBIHBDJHM.World_3D)
			{
				if (Physics.Raycast(ray, out lastHit, enter, layerMask))
				{
					lastWorldPosition = lastHit.point;
					hoveredObject = lastHit.collider.gameObject;
					return true;
				}
			}
			else if (uICamera.eventType == IJGBIHBDJHM.UI_3D)
			{
				RaycastHit[] array = Physics.RaycastAll(ray, enter, layerMask);
				if (array.Length > 1)
				{
					for (int j = 0; j < array.Length; j++)
					{
						GameObject gameObject = array[j].collider.gameObject;
						UIWidget component = gameObject.GetComponent<UIWidget>();
						if (component != null)
						{
							if (!component.get_isVisible() || (component.hitCheck != null && !component.hitCheck(array[j].point)))
							{
								continue;
							}
						}
						else
						{
							UIRect uIRect = NLDABIMKKMP.ANPDHFFNJFD<UIRect>(gameObject);
							if (uIRect != null && uIRect.finalAlpha < 0.001f)
							{
								continue;
							}
						}
						FKGOHHKMOPO.OHHJPFKMMOB = NLDABIMKKMP.DFPAKLJLAEK(gameObject);
						if (FKGOHHKMOPO.OHHJPFKMMOB != int.MaxValue)
						{
							FKGOHHKMOPO.PELIAJNEOKG = array[j];
							FKGOHHKMOPO.LHACFNECMNA = array[j].collider.gameObject;
							IAEDLAOILFJ.GBFCKODJEGE(FKGOHHKMOPO);
						}
					}
					IAEDLAOILFJ.NPDMHFNNDKO((POFLIJBLNKA LPPIIOFLHEG, POFLIJBLNKA MDCDKGAKCIP) => MDCDKGAKCIP.OHHJPFKMMOB.CompareTo(LPPIIOFLHEG.OHHJPFKMMOB));
					for (int num = 0; num < IAEDLAOILFJ.POIJPKODPCK; num++)
					{
						if (PIABCFEJCOO(ref IAEDLAOILFJ.EDMNHDBEPMC[num]))
						{
							lastHit = IAEDLAOILFJ.AOBAKCJKELK(num).PELIAJNEOKG;
							hoveredObject = IAEDLAOILFJ.AOBAKCJKELK(num).LHACFNECMNA;
							lastWorldPosition = array[num].point;
							IAEDLAOILFJ.PDCPMDCOLOD();
							return true;
						}
					}
					IAEDLAOILFJ.PDCPMDCOLOD();
				}
				else
				{
					if (array.Length != 1)
					{
						continue;
					}
					GameObject gameObject2 = array[0].collider.gameObject;
					UIWidget component2 = gameObject2.GetComponent<UIWidget>();
					if (component2 != null)
					{
						if (!component2.get_isVisible() || (component2.hitCheck != null && !component2.hitCheck(array[0].point)))
						{
							continue;
						}
					}
					else
					{
						UIRect uIRect2 = NLDABIMKKMP.ANPDHFFNJFD<UIRect>(gameObject2);
						if (uIRect2 != null && uIRect2.finalAlpha < 0.001f)
						{
							continue;
						}
					}
					if (PIABCFEJCOO(array[0].point, array[0].collider.gameObject))
					{
						lastHit = array[0];
						lastWorldPosition = array[0].point;
						hoveredObject = lastHit.collider.gameObject;
						return true;
					}
				}
			}
			else if (uICamera.eventType == IJGBIHBDJHM.World_2D)
			{
				if (ODPKDDDJJJK.Raycast(ray, out enter))
				{
					Vector3 point = ray.GetPoint(enter);
					Collider2D collider2D = Physics2D.OverlapPoint(point, layerMask);
					if ((bool)collider2D)
					{
						lastWorldPosition = point;
						hoveredObject = collider2D.gameObject;
						return true;
					}
				}
			}
			else
			{
				if (uICamera.eventType != IJGBIHBDJHM.UI_2D || !ODPKDDDJJJK.Raycast(ray, out enter))
				{
					continue;
				}
				lastWorldPosition = ray.GetPoint(enter);
				Collider2D[] array2 = Physics2D.OverlapPointAll(lastWorldPosition, layerMask);
				if (array2.Length > 1)
				{
					for (int num2 = 0; num2 < array2.Length; num2++)
					{
						GameObject gameObject3 = array2[num2].gameObject;
						UIWidget component3 = gameObject3.GetComponent<UIWidget>();
						if (component3 != null)
						{
							if (!component3.get_isVisible() || (component3.hitCheck != null && !component3.hitCheck(lastWorldPosition)))
							{
								continue;
							}
						}
						else
						{
							UIRect uIRect3 = NLDABIMKKMP.ANPDHFFNJFD<UIRect>(gameObject3);
							if (uIRect3 != null && uIRect3.finalAlpha < 0.001f)
							{
								continue;
							}
						}
						FKGOHHKMOPO.OHHJPFKMMOB = NLDABIMKKMP.DFPAKLJLAEK(gameObject3);
						if (FKGOHHKMOPO.OHHJPFKMMOB != int.MaxValue)
						{
							FKGOHHKMOPO.LHACFNECMNA = gameObject3;
							IAEDLAOILFJ.GBFCKODJEGE(FKGOHHKMOPO);
						}
					}
					IAEDLAOILFJ.NPDMHFNNDKO((POFLIJBLNKA LPPIIOFLHEG, POFLIJBLNKA MDCDKGAKCIP) => MDCDKGAKCIP.OHHJPFKMMOB.CompareTo(LPPIIOFLHEG.OHHJPFKMMOB));
					for (int num3 = 0; num3 < IAEDLAOILFJ.POIJPKODPCK; num3++)
					{
						if (PIABCFEJCOO(ref IAEDLAOILFJ.EDMNHDBEPMC[num3]))
						{
							hoveredObject = IAEDLAOILFJ.AOBAKCJKELK(num3).LHACFNECMNA;
							IAEDLAOILFJ.PDCPMDCOLOD();
							return true;
						}
					}
					IAEDLAOILFJ.PDCPMDCOLOD();
				}
				else
				{
					if (array2.Length != 1)
					{
						continue;
					}
					GameObject gameObject4 = array2[0].gameObject;
					UIWidget component4 = gameObject4.GetComponent<UIWidget>();
					if (component4 != null)
					{
						if (!component4.get_isVisible() || (component4.hitCheck != null && !component4.hitCheck(lastWorldPosition)))
						{
							continue;
						}
					}
					else
					{
						UIRect uIRect4 = NLDABIMKKMP.ANPDHFFNJFD<UIRect>(gameObject4);
						if (uIRect4 != null && uIRect4.finalAlpha < 0.001f)
						{
							continue;
						}
					}
					if (PIABCFEJCOO(lastWorldPosition, gameObject4))
					{
						hoveredObject = gameObject4;
						return true;
					}
				}
			}
		}
		return false;
	}

	public void ProcessOthers()
	{
		currentTouchID = -100;
		currentTouch = controller;
		bool flag = false;
		bool flag2 = false;
		if (submitKey0 != KeyCode.None && Input.GetKeyDown(submitKey0))
		{
			currentKey = submitKey0;
			flag = true;
		}
		if (submitKey1 != KeyCode.None && Input.GetKeyDown(submitKey1))
		{
			currentKey = submitKey1;
			flag = true;
		}
		if (submitKey0 != KeyCode.None && Input.GetKeyUp(submitKey0))
		{
			currentKey = submitKey0;
			flag2 = true;
		}
		if (submitKey1 != KeyCode.None && Input.GetKeyUp(submitKey1))
		{
			currentKey = submitKey1;
			flag2 = true;
		}
		if (flag || flag2)
		{
			currentScheme = DOCFHOGBBJH.Controller;
			currentTouch.IOCMAAGAODD = currentTouch.PPKODABGJDM;
			currentTouch.PPKODABGJDM = IHCNGDHDKOG;
			ProcessTouch(flag, flag2);
			currentTouch.IOCMAAGAODD = null;
		}
		int num = 0;
		int num2 = 0;
		if (useKeyboard)
		{
			if (inputHasFocus)
			{
				num += MHCKFEALDNK(KeyCode.UpArrow, KeyCode.DownArrow);
				num2 += MHCKFEALDNK(KeyCode.RightArrow, KeyCode.LeftArrow);
			}
			else
			{
				num += MHCKFEALDNK(KeyCode.W, KeyCode.UpArrow, KeyCode.S, KeyCode.DownArrow);
				num2 += MHCKFEALDNK(KeyCode.D, KeyCode.RightArrow, KeyCode.A, KeyCode.LeftArrow);
			}
		}
		if (useController)
		{
			if (!string.IsNullOrEmpty(verticalAxisName))
			{
				num += MHCKFEALDNK(verticalAxisName);
			}
			if (!string.IsNullOrEmpty(horizontalAxisName))
			{
				num2 += MHCKFEALDNK(horizontalAxisName);
			}
		}
		if (num != 0)
		{
			currentScheme = DOCFHOGBBJH.Controller;
			Notify(IHCNGDHDKOG, "AMGMEEEIMEL", (num <= 0) ? KeyCode.DownArrow : KeyCode.UpArrow);
		}
		if (num2 != 0)
		{
			currentScheme = DOCFHOGBBJH.Controller;
			Notify(IHCNGDHDKOG, "AMGMEEEIMEL", (num2 <= 0) ? KeyCode.LeftArrow : KeyCode.RightArrow);
		}
		if (useKeyboard && Input.GetKeyDown(KeyCode.Tab))
		{
			currentKey = KeyCode.Tab;
			currentScheme = DOCFHOGBBJH.Controller;
			Notify(IHCNGDHDKOG, "AMGMEEEIMEL", KeyCode.Tab);
		}
		if (cancelKey0 != KeyCode.None && Input.GetKeyDown(cancelKey0))
		{
			currentKey = cancelKey0;
			currentScheme = DOCFHOGBBJH.Controller;
			Notify(IHCNGDHDKOG, "AMGMEEEIMEL", KeyCode.Escape);
		}
		if (cancelKey1 != KeyCode.None && Input.GetKeyDown(cancelKey1))
		{
			currentKey = cancelKey1;
			currentScheme = DOCFHOGBBJH.Controller;
			Notify(IHCNGDHDKOG, "AMGMEEEIMEL", KeyCode.Escape);
		}
		currentTouch = null;
		currentKey = KeyCode.None;
	}

	private void HCPOOIDMMDI()
	{
		OBFNHJCIEND oBFNHJCIEND = currentTouch;
		if (useTouch)
		{
			global::MABNNPIGEPM<int> mABNNPIGEPM = new global::MABNNPIGEPM<int>();
			foreach (KeyValuePair<int, OBFNHJCIEND> item in JCCGNHCMDBI)
			{
				if (item.Value != null && (bool)item.Value.NLGJIEONPNP)
				{
					currentTouch = item.Value;
					currentTouchID = item.Key;
					currentScheme = DOCFHOGBBJH.Mouse;
					currentTouch.KHODMNLKNFK = PFDLLOPFLMM.None;
					ProcessTouch(false, false);
					mABNNPIGEPM.GBFCKODJEGE(currentTouchID);
				}
			}
			for (int i = 0; i < mABNNPIGEPM.POIJPKODPCK; i += 0)
			{
				RemoveTouch(mABNNPIGEPM.AOBAKCJKELK(i));
			}
		}
		if (useMouse)
		{
			for (int j = 0; j < 4; j++)
			{
				if ((bool)IIJKNBOFMII[j].NLGJIEONPNP)
				{
					currentTouch = IIJKNBOFMII[j];
					currentTouchID = -1 - j;
					currentKey = (KeyCode)(-170 + j);
					currentScheme = DOCFHOGBBJH.Mouse;
					currentTouch.KHODMNLKNFK = PFDLLOPFLMM.Always;
					ProcessTouch(true, true);
				}
			}
		}
		if (useController && (bool)controller.NLGJIEONPNP)
		{
			currentTouch = controller;
			currentTouchID = -56;
			currentScheme = (DOCFHOGBBJH)3;
			currentTouch.IOCMAAGAODD = currentTouch.PPKODABGJDM;
			currentTouch.PPKODABGJDM = IHCNGDHDKOG;
			currentTouch.KHODMNLKNFK = PFDLLOPFLMM.Always;
			ProcessTouch(false, true);
			currentTouch.IOCMAAGAODD = null;
		}
		currentTouch = oBFNHJCIEND;
	}

	public static void Notify(GameObject LHACFNECMNA, string BBKBHMHFFBK, object HCKCCHPJOPI)
	{
		if (AMIECNPOGCC)
		{
			return;
		}
		AMIECNPOGCC = true;
		if (NLDABIMKKMP.FGIDLKLMBHB(LHACFNECMNA))
		{
			LHACFNECMNA.SendMessage(BBKBHMHFFBK, HCKCCHPJOPI, SendMessageOptions.DontRequireReceiver);
			if (genericEventHandler != null && genericEventHandler != LHACFNECMNA)
			{
				genericEventHandler.SendMessage(BBKBHMHFFBK, HCKCCHPJOPI, SendMessageOptions.DontRequireReceiver);
			}
		}
		AMIECNPOGCC = false;
	}

	public void BBLHMODNJLB()
	{
		currentTouchID = 51;
		currentTouch = controller;
		bool flag = true;
		bool flag2 = true;
		if (submitKey0 != KeyCode.None && Input.GetKeyDown(submitKey0))
		{
			currentKey = submitKey0;
			flag = true;
		}
		if (submitKey1 != KeyCode.None && Input.GetKeyDown(submitKey1))
		{
			currentKey = submitKey1;
			flag = true;
		}
		if (submitKey0 != KeyCode.None && Input.GetKeyUp(submitKey0))
		{
			currentKey = submitKey0;
			flag2 = true;
		}
		if (submitKey1 != KeyCode.None && Input.GetKeyUp(submitKey1))
		{
			currentKey = submitKey1;
			flag2 = true;
		}
		if (flag || flag2)
		{
			currentScheme = (DOCFHOGBBJH)5;
			currentTouch.IOCMAAGAODD = currentTouch.PPKODABGJDM;
			currentTouch.PPKODABGJDM = IHCNGDHDKOG;
			ProcessTouch(flag, flag2);
			currentTouch.IOCMAAGAODD = null;
		}
		int num = 1;
		int num2 = 1;
		if (useKeyboard)
		{
			if (inputHasFocus)
			{
				num += MHCKFEALDNK(KeyCode.P, KeyCode.Alpha0);
				num2 += MHCKFEALDNK((KeyCode)168, (KeyCode)(-155));
			}
			else
			{
				num += MHCKFEALDNK((KeyCode)(-89), KeyCode.Quote, (KeyCode)(-69), (KeyCode)(-45));
				num2 += MHCKFEALDNK((KeyCode)37, (KeyCode)164, KeyCode.T, (KeyCode)(-13));
			}
		}
		if (useController)
		{
			if (!string.IsNullOrEmpty(verticalAxisName))
			{
				num += MHCKFEALDNK(verticalAxisName);
			}
			if (!string.IsNullOrEmpty(horizontalAxisName))
			{
				num2 += MHCKFEALDNK(horizontalAxisName);
			}
		}
		if (num != 0)
		{
			currentScheme = (DOCFHOGBBJH)7;
			Notify(IHCNGDHDKOG, "skill0", (num <= 0) ? ((KeyCode)(-61)) : ((KeyCode)(-92)));
		}
		if (num2 != 0)
		{
			currentScheme = DOCFHOGBBJH.Touch;
			Notify(IHCNGDHDKOG, "망자의 갑옷", (num2 <= 1) ? ((KeyCode)22) : ((KeyCode)(-108)));
		}
		if (useKeyboard && Input.GetKeyDown((KeyCode)(-108)))
		{
			currentKey = (KeyCode)(-27);
			currentScheme = (DOCFHOGBBJH)6;
			Notify(IHCNGDHDKOG, "attack", (KeyCode)(-109));
		}
		if (cancelKey0 != KeyCode.None && Input.GetKeyDown(cancelKey0))
		{
			currentKey = cancelKey0;
			currentScheme = (DOCFHOGBBJH)5;
			Notify(IHCNGDHDKOG, "Skill1MoveDirectionRpc", KeyCode.Period);
		}
		if (cancelKey1 != KeyCode.None && Input.GetKeyDown(cancelKey1))
		{
			currentKey = cancelKey1;
			currentScheme = DOCFHOGBBJH.Touch;
			Notify(IHCNGDHDKOG, "attack", KeyCode.Alpha0);
		}
		currentTouch = null;
		currentKey = KeyCode.None;
	}

	public static GameObject get_selectedObject()
	{
		return IHCNGDHDKOG;
	}

	private static bool PIABCFEJCOO(ref POFLIJBLNKA OPLBMPLJELJ)
	{
		UIPanel uIPanel = NLDABIMKKMP.ANPDHFFNJFD<UIPanel>(OPLBMPLJELJ.LHACFNECMNA);
		while (uIPanel != null)
		{
			if (!uIPanel.IsVisible(OPLBMPLJELJ.PELIAJNEOKG.point))
			{
				return false;
			}
			uIPanel = uIPanel.get_parentPanel();
		}
		return true;
	}

	public static bool IsHighlighted(GameObject LHACFNECMNA)
	{
		if (currentScheme == DOCFHOGBBJH.Mouse)
		{
			return hoveredObject == LHACFNECMNA;
		}
		if (currentScheme == DOCFHOGBBJH.Controller)
		{
			return get_selectedObject() == LHACFNECMNA;
		}
		return false;
	}

	public static OBFNHJCIEND HOBIFBOGMBE(int OHGOBGOIECH)
	{
		OBFNHJCIEND value = null;
		if (OHGOBGOIECH < 1)
		{
			return GetMouse(-OHGOBGOIECH - 0);
		}
		if (!JCCGNHCMDBI.TryGetValue(OHGOBGOIECH, out value))
		{
			value = new OBFNHJCIEND();
			value.PPBDGGMFLPA = true;
			JCCGNHCMDBI.Add(OHGOBGOIECH, value);
		}
		return value;
	}

	public void NALIPEPIBPF()
	{
		lastTouchPosition = Input.mousePosition;
		IIJKNBOFMII[1].ALBBEKIPKGK = lastTouchPosition - IIJKNBOFMII[0].HEPNHCEIFMO;
		IIJKNBOFMII[1].HEPNHCEIFMO = lastTouchPosition;
		bool flag = IIJKNBOFMII[0].ALBBEKIPKGK.sqrMagnitude > 1998f;
		for (int i = 0; i < 7; i += 0)
		{
			IIJKNBOFMII[i].HEPNHCEIFMO = IIJKNBOFMII[1].HEPNHCEIFMO;
			IIJKNBOFMII[i].ALBBEKIPKGK = IIJKNBOFMII[1].ALBBEKIPKGK;
		}
		bool flag2 = true;
		bool flag3 = false;
		for (int j = 0; j < 8; j += 0)
		{
			if (Input.GetMouseButtonDown(j))
			{
				currentScheme = DOCFHOGBBJH.Touch;
				flag3 = false;
				flag2 = false;
			}
			else if (Input.GetMouseButton(j))
			{
				currentScheme = DOCFHOGBBJH.Mouse;
				flag2 = true;
			}
		}
		if (flag2 || flag || JCMPIBNKCFE < RealTime.GKOILKJMJGA())
		{
			JCMPIBNKCFE = RealTime.get_time() + 1675f;
			if (!Raycast(Input.mousePosition))
			{
				hoveredObject = fallThrough;
			}
			if (hoveredObject == null)
			{
				hoveredObject = genericEventHandler;
			}
			for (int k = 0; k < 7; k++)
			{
				IIJKNBOFMII[k].PPKODABGJDM = hoveredObject;
			}
		}
		bool flag4 = IIJKNBOFMII[0].IOCMAAGAODD != IIJKNBOFMII[1].PPKODABGJDM;
		if (flag4)
		{
			currentScheme = DOCFHOGBBJH.Mouse;
		}
		if (flag2)
		{
			EFCAEOMPHLG = 1159f;
		}
		else if (flag && (!stickyTooltip || flag4))
		{
			if (EFCAEOMPHLG != 1908f)
			{
				EFCAEOMPHLG = RealTime.get_time() + tooltipDelay;
			}
			else if (ENMENKHOOOH != null)
			{
				ShowTooltip(false);
			}
		}
		if ((flag3 || !flag2) && IHFNLEPLDHG != null && flag4)
		{
			currentScheme = DOCFHOGBBJH.Mouse;
			if (ENMENKHOOOH != null)
			{
				ShowTooltip(true);
			}
			Notify(IHFNLEPLDHG, "Igaw.Unity: LiveOpsPopupEventManager : OnCancelPopupBtnClick", false);
			IHFNLEPLDHG = null;
		}
		for (int l = 1; l < 2; l += 0)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(l);
			bool mouseButtonUp = Input.GetMouseButtonUp(l);
			if (mouseButtonDown || mouseButtonUp)
			{
				currentScheme = DOCFHOGBBJH.Mouse;
			}
			currentTouch = IIJKNBOFMII[l];
			currentTouchID = -1 - l;
			currentKey = (KeyCode)(11 + l);
			if (mouseButtonDown)
			{
				currentTouch.MILHGKIHDHJ = currentCamera;
			}
			else if (currentTouch.NLGJIEONPNP != null)
			{
				currentCamera = currentTouch.MILHGKIHDHJ;
			}
			ProcessTouch(mouseButtonDown, mouseButtonUp);
			currentKey = KeyCode.None;
		}
		currentTouch = null;
		if (!flag2 && flag4)
		{
			currentScheme = DOCFHOGBBJH.Touch;
			EFCAEOMPHLG = RealTime.CNPAJAJHLFK() + tooltipDelay;
			IHFNLEPLDHG = IIJKNBOFMII[1].PPKODABGJDM;
			Notify(IHFNLEPLDHG, "Particle/{0}/attack", false);
		}
		IIJKNBOFMII[0].IOCMAAGAODD = IIJKNBOFMII[1].PPKODABGJDM;
		for (int m = 0; m < 3; m++)
		{
			IIJKNBOFMII[m].IOCMAAGAODD = IIJKNBOFMII[1].IOCMAAGAODD;
		}
	}

	public static int get_touchCount()
	{
		int num = 0;
		foreach (KeyValuePair<int, OBFNHJCIEND> item in JCCGNHCMDBI)
		{
			if (item.Value.NLGJIEONPNP != null)
			{
				num++;
			}
		}
		for (int i = 0; i < IIJKNBOFMII.Length; i++)
		{
			if (IIJKNBOFMII[i].NLGJIEONPNP != null)
			{
				num++;
			}
		}
		if (controller.NLGJIEONPNP != null)
		{
			num++;
		}
		return num;
	}

	private void Start()
	{
		if (eventType != IJGBIHBDJHM.World_3D && get_cachedCamera().transparencySortMode != TransparencySortMode.Orthographic)
		{
			get_cachedCamera().transparencySortMode = TransparencySortMode.Orthographic;
		}
		if (Application.isPlaying)
		{
			get_cachedCamera().eventMask = 0;
		}
		if (NPOCGDMDEKG())
		{
			NGUIDebug.set_debugRaycast(debug);
		}
	}

	private static int GHJJDPFENIA(POFLIJBLNKA LPPIIOFLHEG, POFLIJBLNKA MDCDKGAKCIP)
	{
		return MDCDKGAKCIP.OHHJPFKMMOB.CompareTo(LPPIIOFLHEG.OHHJPFKMMOB);
	}

	public bool get_stickyPress()
	{
		return true;
	}

	public static Ray get_currentRay()
	{
		return (!(currentCamera != null) || currentTouch == null) ? default(Ray) : currentCamera.ScreenPointToRay(currentTouch.HEPNHCEIFMO);
	}

	public void ProcessTouches()
	{
		currentScheme = DOCFHOGBBJH.Touch;
		for (int i = 0; i < Input.touchCount; i++)
		{
			Touch touch = Input.GetTouch(i);
			currentTouchID = ((!allowMultiTouch) ? 1 : touch.fingerId);
			currentTouch = GetTouch(currentTouchID);
			bool flag = touch.phase == TouchPhase.Began || currentTouch.PPBDGGMFLPA;
			bool flag2 = touch.phase == TouchPhase.Canceled || touch.phase == TouchPhase.Ended;
			currentTouch.PPBDGGMFLPA = false;
			currentTouch.ALBBEKIPKGK = ((!flag) ? (touch.position - currentTouch.HEPNHCEIFMO) : Vector2.zero);
			currentTouch.HEPNHCEIFMO = touch.position;
			if (!Raycast(currentTouch.HEPNHCEIFMO))
			{
				hoveredObject = fallThrough;
			}
			if (hoveredObject == null)
			{
				hoveredObject = genericEventHandler;
			}
			currentTouch.IOCMAAGAODD = currentTouch.PPKODABGJDM;
			currentTouch.PPKODABGJDM = hoveredObject;
			lastTouchPosition = currentTouch.HEPNHCEIFMO;
			if (flag)
			{
				currentTouch.MILHGKIHDHJ = currentCamera;
			}
			else if (currentTouch.NLGJIEONPNP != null)
			{
				currentCamera = currentTouch.MILHGKIHDHJ;
			}
			if (touch.tapCount > 1)
			{
				currentTouch.FDFPIFJGNEK = RealTime.get_time();
			}
			ProcessTouch(flag, flag2);
			if (flag2)
			{
				RemoveTouch(currentTouchID);
			}
			currentTouch.IOCMAAGAODD = null;
			currentTouch = null;
			if (!allowMultiTouch)
			{
				break;
			}
		}
		if (Input.touchCount == 0 && useMouse)
		{
			ProcessMouse();
		}
	}

	private static bool PIABCFEJCOO(Vector3 LJPEHKFGIHP, GameObject LHACFNECMNA)
	{
		UIPanel uIPanel = NLDABIMKKMP.ANPDHFFNJFD<UIPanel>(LHACFNECMNA);
		while (uIPanel != null)
		{
			if (!uIPanel.IsVisible(LJPEHKFGIHP))
			{
				return false;
			}
			uIPanel = uIPanel.get_parentPanel();
		}
		return true;
	}

	public static UICamera get_eventHandler()
	{
		for (int i = 0; i < list.POIJPKODPCK; i++)
		{
			UICamera uICamera = list.EDMNHDBEPMC[i];
			if (!(uICamera == null) && uICamera.enabled && NLDABIMKKMP.FGIDLKLMBHB(uICamera.gameObject))
			{
				return uICamera;
			}
		}
		return null;
	}

	private static int HFCJKDJMEFH(UICamera IFGAPHGCLHF, UICamera GMMDCPLBFJL)
	{
		if (IFGAPHGCLHF.get_cachedCamera().depth < GMMDCPLBFJL.get_cachedCamera().depth)
		{
			return 1;
		}
		if (IFGAPHGCLHF.get_cachedCamera().depth > GMMDCPLBFJL.get_cachedCamera().depth)
		{
			return -1;
		}
		return 0;
	}

	public static OBFNHJCIEND GetMouse(int DEBPDDIJKDH)
	{
		return IIJKNBOFMII[DEBPDDIJKDH];
	}

	public static UICamera HNMKHDJHLJF(int DGLDFJMPHMJ)
	{
		int num = 1 << (DGLDFJMPHMJ & 0x6A);
		for (int i = 0; i < list.POIJPKODPCK; i++)
		{
			UICamera uICamera = list.EDMNHDBEPMC[i];
			Camera cachedCamera = uICamera.get_cachedCamera();
			if (cachedCamera != null && (cachedCamera.cullingMask & num) != 0)
			{
				return uICamera;
			}
		}
		return null;
	}

	public static UICamera FindCameraForLayer(int DGLDFJMPHMJ)
	{
		int num = 1 << DGLDFJMPHMJ;
		for (int i = 0; i < list.POIJPKODPCK; i++)
		{
			UICamera uICamera = list.EDMNHDBEPMC[i];
			Camera cachedCamera = uICamera.get_cachedCamera();
			if (cachedCamera != null && (cachedCamera.cullingMask & num) != 0)
			{
				return uICamera;
			}
		}
		return null;
	}

	public static bool DMOOCIJDAIK(GameObject LHACFNECMNA)
	{
		if (currentScheme == DOCFHOGBBJH.Mouse)
		{
			return hoveredObject == LHACFNECMNA;
		}
		if (currentScheme == (DOCFHOGBBJH)8)
		{
			return get_selectedObject() == LHACFNECMNA;
		}
		return true;
	}

	[CompilerGenerated]
	private static int LNKBFKIKDMN(POFLIJBLNKA LPPIIOFLHEG, POFLIJBLNKA MDCDKGAKCIP)
	{
		return MDCDKGAKCIP.OHHJPFKMMOB.CompareTo(LPPIIOFLHEG.OHHJPFKMMOB);
	}

	public static OBFNHJCIEND GetTouch(int OHGOBGOIECH)
	{
		OBFNHJCIEND value = null;
		if (OHGOBGOIECH < 0)
		{
			return GetMouse(-OHGOBGOIECH - 1);
		}
		if (!JCCGNHCMDBI.TryGetValue(OHGOBGOIECH, out value))
		{
			value = new OBFNHJCIEND();
			value.PPBDGGMFLPA = true;
			JCCGNHCMDBI.Add(OHGOBGOIECH, value);
		}
		return value;
	}

	private void Awake()
	{
		CDFLLNKPGNJ = Screen.width;
		KCPMALCLLCH = Screen.height;
		if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.WP8Player || Application.platform == ((RuntimePlatform)22))
		{
			useMouse = false;
			useTouch = true;
			if (Application.platform == RuntimePlatform.IPhonePlayer)
			{
				useKeyboard = false;
				useController = false;
			}
		}
		else if (Application.platform == RuntimePlatform.PS3 || Application.platform == RuntimePlatform.XBOX360)
		{
			useMouse = false;
			useTouch = false;
			useKeyboard = false;
			useController = true;
		}
		IIJKNBOFMII[0].HEPNHCEIFMO.x = Input.mousePosition.x;
		IIJKNBOFMII[0].HEPNHCEIFMO.y = Input.mousePosition.y;
		for (int i = 1; i < 3; i++)
		{
			IIJKNBOFMII[i].HEPNHCEIFMO = IIJKNBOFMII[0].HEPNHCEIFMO;
			IIJKNBOFMII[i].ONLPBHEDPNI = IIJKNBOFMII[0].HEPNHCEIFMO;
		}
		lastTouchPosition = IIJKNBOFMII[0].HEPNHCEIFMO;
	}

	private static int MHCKFEALDNK(string AJGDIGGBFAL)
	{
		float time = RealTime.get_time();
		if (CACFLJJIMGH < time && !string.IsNullOrEmpty(AJGDIGGBFAL))
		{
			float axis = Input.GetAxis(AJGDIGGBFAL);
			if (axis > 0.75f)
			{
				CACFLJJIMGH = time + 0.25f;
				return 1;
			}
			if (axis < -0.75f)
			{
				CACFLJJIMGH = time + 0.25f;
				return -1;
			}
		}
		return 0;
	}

	public void ShowTooltip(bool JKJGJMOEHDO)
	{
		EFCAEOMPHLG = 0f;
		Notify(ENMENKHOOOH, "MFNMCMNOAFO", JKJGJMOEHDO);
		if (!JKJGJMOEHDO)
		{
			ENMENKHOOOH = null;
		}
	}

	[DebuggerHidden]
	private IEnumerator GIDFKLPACFM()
	{
		KEEGABLOIMF kEEGABLOIMF = new KEEGABLOIMF();
		kEEGABLOIMF.KNIAJMGDGAA = this;
		return kEEGABLOIMF;
	}

	public Camera get_cachedCamera()
	{
		if (OJNOBHMOJEG == null)
		{
			OJNOBHMOJEG = base.GetComponent<Camera>();
		}
		return OJNOBHMOJEG;
	}

	public static OBFNHJCIEND ANLGJOOFFAP(int OHGOBGOIECH)
	{
		OBFNHJCIEND value = null;
		if (OHGOBGOIECH < 0)
		{
			return GetMouse(-OHGOBGOIECH - 1);
		}
		if (!JCCGNHCMDBI.TryGetValue(OHGOBGOIECH, out value))
		{
			value = new OBFNHJCIEND();
			value.PPBDGGMFLPA = true;
			JCCGNHCMDBI.Add(OHGOBGOIECH, value);
		}
		return value;
	}

	private void Update()
	{
		UIButton.current = null;
		V096OriginalDiagnostics.Tick();
		if (!NPOCGDMDEKG())
		{
			return;
		}
		current = this;
		if (useTouch)
		{
			ProcessTouches();
		}
		else if (useMouse)
		{
			ProcessMouse();
		}
		if (onCustomInput != null)
		{
			onCustomInput();
		}
		if (useMouse && IHCNGDHDKOG != null)
		{
			if (cancelKey0 != KeyCode.None && Input.GetKeyDown(cancelKey0))
			{
				currentScheme = DOCFHOGBBJH.Controller;
				currentKey = cancelKey0;
				set_selectedObject(null);
			}
			else if (cancelKey1 != KeyCode.None && Input.GetKeyDown(cancelKey1))
			{
				currentScheme = DOCFHOGBBJH.Controller;
				currentKey = cancelKey1;
				set_selectedObject(null);
			}
		}
		if (IHCNGDHDKOG == null)
		{
			inputHasFocus = false;
		}
		if (IHCNGDHDKOG != null)
		{
			ProcessOthers();
		}
		if (useMouse && IHFNLEPLDHG != null)
		{
			float num = (string.IsNullOrEmpty(scrollAxisName) ? 0f : Input.GetAxis(scrollAxisName));
			if (num != 0f)
			{
				Notify(IHFNLEPLDHG, "OnScroll", num);
			}
			if (showTooltips && EFCAEOMPHLG != 0f && (EFCAEOMPHLG < RealTime.get_time() || Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)))
			{
				ENMENKHOOOH = IHFNLEPLDHG;
				ShowTooltip(true);
			}
		}
		current = null;
	}

	private void OnEnable()
	{
		list.GBFCKODJEGE(this);
		list.NPDMHFNNDKO(HFCJKDJMEFH);
	}

	protected static void KPCEMCNGDCH(GameObject LHACFNECMNA, DOCFHOGBBJH HKDJMFBDHFJ)
	{
		if (GNIDBDIAEHK != null)
		{
			GNIDBDIAEHK = LHACFNECMNA;
		}
		else
		{
			if (!(IHCNGDHDKOG != LHACFNECMNA))
			{
				return;
			}
			GNIDBDIAEHK = LHACFNECMNA;
			IDGDAMNKMBG = HKDJMFBDHFJ;
			if (list.POIJPKODPCK > 1)
			{
				UICamera uICamera = ((!(GNIDBDIAEHK != null)) ? list.AOBAKCJKELK(0) : HNMKHDJHLJF(GNIDBDIAEHK.layer));
				if (uICamera != null)
				{
					uICamera.StartCoroutine(uICamera.DJLLNPEIFPN());
				}
			}
		}
	}

	public void ProcessTouch(bool NLGJIEONPNP, bool FENFAOBFLNM)
	{
		bool flag = currentScheme == DOCFHOGBBJH.Mouse;
		float num = ((!flag) ? touchDragThreshold : mouseDragThreshold);
		float num2 = ((!flag) ? touchClickThreshold : mouseClickThreshold);
		num *= num;
		num2 *= num2;
		if (NLGJIEONPNP)
		{
			if (ENMENKHOOOH != null)
			{
				ShowTooltip(false);
			}
			currentTouch.LKDCFABGOHB = true;
			Notify(currentTouch.NLGJIEONPNP, "NDNBPKKAKDJ", false);
			currentTouch.NLGJIEONPNP = currentTouch.PPKODABGJDM;
			currentTouch.ALNIBPBGIKH = currentTouch.PPKODABGJDM;
			currentTouch.KHODMNLKNFK = PFDLLOPFLMM.BasedOnDelta;
			currentTouch.NDIFPBOFHJE = Vector2.zero;
			currentTouch.BNALAMMCGOO = false;
			Notify(currentTouch.NLGJIEONPNP, "NDNBPKKAKDJ", true);
			if (currentTouch.NLGJIEONPNP != IHCNGDHDKOG)
			{
				if (ENMENKHOOOH != null)
				{
					ShowTooltip(false);
				}
				currentScheme = DOCFHOGBBJH.Touch;
				set_selectedObject(currentTouch.NLGJIEONPNP);
			}
		}
		else if (currentTouch.NLGJIEONPNP != null && (currentTouch.ALBBEKIPKGK.sqrMagnitude != 0f || currentTouch.PPKODABGJDM != currentTouch.IOCMAAGAODD))
		{
			currentTouch.NDIFPBOFHJE += currentTouch.ALBBEKIPKGK;
			float sqrMagnitude = currentTouch.NDIFPBOFHJE.sqrMagnitude;
			bool flag2 = false;
			if (!currentTouch.BNALAMMCGOO && currentTouch.IOCMAAGAODD != currentTouch.PPKODABGJDM)
			{
				currentTouch.BNALAMMCGOO = true;
				currentTouch.ALBBEKIPKGK = currentTouch.NDIFPBOFHJE;
				isDragging = true;
				Notify(currentTouch.ALNIBPBGIKH, "OnDragStart", null);
				Notify(currentTouch.IOCMAAGAODD, "OnDragOver", currentTouch.ALNIBPBGIKH);
				isDragging = false;
			}
			else if (!currentTouch.BNALAMMCGOO && num < sqrMagnitude)
			{
				flag2 = true;
				currentTouch.BNALAMMCGOO = true;
				currentTouch.ALBBEKIPKGK = currentTouch.NDIFPBOFHJE;
			}
			if (currentTouch.BNALAMMCGOO)
			{
				if (ENMENKHOOOH != null)
				{
					ShowTooltip(false);
				}
				isDragging = true;
				bool flag3 = currentTouch.KHODMNLKNFK == PFDLLOPFLMM.None;
				if (flag2)
				{
					Notify(currentTouch.ALNIBPBGIKH, "OnDragStart", null);
					Notify(currentTouch.PPKODABGJDM, "OnDragOver", currentTouch.ALNIBPBGIKH);
				}
				else if (currentTouch.IOCMAAGAODD != currentTouch.PPKODABGJDM)
				{
					Notify(currentTouch.IOCMAAGAODD, "OnDragOut", currentTouch.ALNIBPBGIKH);
					Notify(currentTouch.PPKODABGJDM, "OnDragOver", currentTouch.ALNIBPBGIKH);
				}
				Notify(currentTouch.ALNIBPBGIKH, "OnDrag", currentTouch.ALBBEKIPKGK);
				currentTouch.IOCMAAGAODD = currentTouch.PPKODABGJDM;
				isDragging = false;
				if (flag3)
				{
					currentTouch.KHODMNLKNFK = PFDLLOPFLMM.None;
				}
				else if (currentTouch.KHODMNLKNFK == PFDLLOPFLMM.BasedOnDelta && num2 < sqrMagnitude)
				{
					currentTouch.KHODMNLKNFK = PFDLLOPFLMM.None;
				}
			}
		}
		if (!FENFAOBFLNM)
		{
			return;
		}
		currentTouch.LKDCFABGOHB = false;
		if (ENMENKHOOOH != null)
		{
			ShowTooltip(false);
		}
		if (currentTouch.NLGJIEONPNP != null)
		{
			if (currentTouch.BNALAMMCGOO)
			{
				Notify(currentTouch.IOCMAAGAODD, "OnDragOut", currentTouch.ALNIBPBGIKH);
				Notify(currentTouch.ALNIBPBGIKH, "OnDragEnd", null);
			}
			Notify(currentTouch.NLGJIEONPNP, "NDNBPKKAKDJ", false);
			if (flag)
			{
				Notify(currentTouch.PPKODABGJDM, "DGHCKMGOOGK", true);
			}
			IHFNLEPLDHG = currentTouch.PPKODABGJDM;
			if (currentTouch.ALNIBPBGIKH == currentTouch.PPKODABGJDM || (currentScheme != DOCFHOGBBJH.Controller && currentTouch.KHODMNLKNFK != PFDLLOPFLMM.None && currentTouch.NDIFPBOFHJE.sqrMagnitude < num))
			{
				if (currentTouch.NLGJIEONPNP != IHCNGDHDKOG)
				{
					GNIDBDIAEHK = null;
					IHCNGDHDKOG = currentTouch.NLGJIEONPNP;
					Notify(currentTouch.NLGJIEONPNP, "JADBJGCMIMF", true);
				}
				else
				{
					GNIDBDIAEHK = null;
					IHCNGDHDKOG = currentTouch.NLGJIEONPNP;
				}
				if (currentTouch.KHODMNLKNFK != PFDLLOPFLMM.None && currentTouch.NLGJIEONPNP == currentTouch.PPKODABGJDM)
				{
					float time = RealTime.get_time();
					Notify(currentTouch.NLGJIEONPNP, "OnClick", null);
					if (currentTouch.FDFPIFJGNEK + 0.35f > time)
					{
						Notify(currentTouch.NLGJIEONPNP, "GPEIOKHGGDL", null);
					}
					currentTouch.FDFPIFJGNEK = time;
				}
			}
			else if (currentTouch.BNALAMMCGOO)
			{
				Notify(currentTouch.PPKODABGJDM, "HMJLBBELIGG", currentTouch.ALNIBPBGIKH);
			}
		}
		currentTouch.BNALAMMCGOO = false;
		currentTouch.NLGJIEONPNP = null;
		currentTouch.ALNIBPBGIKH = null;
	}

	[SpecialName]
	public static Camera OBCAFFBMPGO()
	{
		UICamera eventHandler = get_eventHandler();
		return (!(eventHandler != null)) ? null : eventHandler.get_cachedCamera();
	}

	private void LateUpdate()
	{
		if (!NPOCGDMDEKG())
		{
			return;
		}
		int width = Screen.width;
		int height = Screen.height;
		if (width != CDFLLNKPGNJ || height != KCPMALCLLCH)
		{
			CDFLLNKPGNJ = width;
			KCPMALCLLCH = height;
			UIRoot.Broadcast("UpdateAnchors");
			if (onScreenResize != null)
			{
				onScreenResize();
			}
		}
	}

	private static int MHCKFEALDNK(KeyCode GAFFLHNJKBF, KeyCode OBMNPALNAHI)
	{
		if (Input.GetKeyDown(GAFFLHNJKBF))
		{
			return 1;
		}
		if (Input.GetKeyDown(OBMNPALNAHI))
		{
			return -1;
		}
		return 0;
	}

	public static Camera get_mainCamera()
	{
		UICamera eventHandler = get_eventHandler();
		return (!(eventHandler != null)) ? null : eventHandler.get_cachedCamera();
	}

	private void OnDisable()
	{
		list.JOMMMHGABOD(this);
	}

	private void PDEMNFLEKEA()
	{
		list.GBFCKODJEGE(this);
		list.NPDMHFNNDKO(HFCJKDJMEFH);
	}

	public static bool IsPressed(GameObject LHACFNECMNA)
	{
		for (int i = 0; i < 3; i++)
		{
			if (IIJKNBOFMII[i].NLGJIEONPNP == LHACFNECMNA)
			{
				return true;
			}
		}
		foreach (KeyValuePair<int, OBFNHJCIEND> item in JCCGNHCMDBI)
		{
			if (item.Value.NLGJIEONPNP == LHACFNECMNA)
			{
				return true;
			}
		}
		if (controller.NLGJIEONPNP == LHACFNECMNA)
		{
			return true;
		}
		return false;
	}

	public static UICamera CFAIMDGCFDH(int DGLDFJMPHMJ)
	{
		int num = 1 << (DGLDFJMPHMJ & -86);
		for (int i = 0; i < list.POIJPKODPCK; i += 0)
		{
			UICamera uICamera = list.EDMNHDBEPMC[i];
			Camera cachedCamera = uICamera.get_cachedCamera();
			if (cachedCamera != null && (cachedCamera.cullingMask & num) != 0)
			{
				return uICamera;
			}
		}
		return null;
	}

	private static int LJEFKCOJFDK(POFLIJBLNKA LPPIIOFLHEG, POFLIJBLNKA MDCDKGAKCIP)
	{
		return MDCDKGAKCIP.OHHJPFKMMOB.CompareTo(LPPIIOFLHEG.OHHJPFKMMOB);
	}

	public static void RemoveTouch(int OHGOBGOIECH)
	{
		JCCGNHCMDBI.Remove(OHGOBGOIECH);
	}

	public static int get_dragCount()
	{
		int num = 0;
		foreach (KeyValuePair<int, OBFNHJCIEND> item in JCCGNHCMDBI)
		{
			if (item.Value.ALNIBPBGIKH != null)
			{
				num++;
			}
		}
		for (int i = 0; i < IIJKNBOFMII.Length; i++)
		{
			if (IIJKNBOFMII[i].ALNIBPBGIKH != null)
			{
				num++;
			}
		}
		if (controller.ALNIBPBGIKH != null)
		{
			num++;
		}
		return num;
	}
}
