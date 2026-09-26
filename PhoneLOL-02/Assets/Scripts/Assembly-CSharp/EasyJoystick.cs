using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
public class EasyJoystick : MonoBehaviour
{
	public enum GJGAAIHMKPP
	{
		None = 0,
		UpperLeft = 1,
		UpperCenter = 2,
		UpperRight = 3,
		MiddleLeft = 4,
		MiddleCenter = 5,
		MiddleRight = 6,
		LowerLeft = 7,
		LowerCenter = 8,
		LowerRight = 9
	}

	public enum PPBPHBNOLPB
	{
		Rotate = 0,
		RotateLocal = 1,
		Translate = 2,
		TranslateLocal = 3,
		Scale = 4
	}

	public enum AAKCEIHPOBA
	{
		X = 0,
		Y = 1,
		Z = 2,
		XYZ = 3
	}

	public enum OBOLKCNLKBD
	{
		FullScreen = 0,
		Left = 1,
		Right = 2,
		Top = 3,
		Bottom = 4,
		TopLeft = 5,
		TopRight = 6,
		BottomLeft = 7,
		BottomRight = 8
	}

	public enum FGKAAEEPILA
	{
		Direct = 0,
		Include = 1,
		EventNotification = 2,
		DirectAndEvent = 3
	}

	public enum NBFPGICCJGI
	{
		SendMessage = 0,
		SendMessageUpwards = 1,
		BroadcastMessage = 2
	}

	private enum CAGDNOCMKGG
	{
		On_JoystickMoveStart = 0,
		On_JoystickTouchStart = 1,
		On_JoystickTouchUp = 2,
		On_JoystickMove = 3,
		On_JoystickMoveEnd = 4,
		On_JoystickTap = 5,
		On_JoystickDoubleTap = 6
	}

	public delegate void ANANFHIGIAE(OIAKHGNLGJC PLACJCAMHBF);

	public delegate void NEMGKMNAJJN(OIAKHGNLGJC PLACJCAMHBF);

	public delegate void ODBDPJAPFBA(OIAKHGNLGJC PLACJCAMHBF);

	public delegate void BEFGOCGLIBP(OIAKHGNLGJC PLACJCAMHBF);

	public delegate void OKABMNMIBDA(OIAKHGNLGJC PLACJCAMHBF);

	public delegate void DJDBIIPMJGL(OIAKHGNLGJC PLACJCAMHBF);

	public delegate void DOLJGKPLHON(OIAKHGNLGJC PLACJCAMHBF);

	private Vector2 JHNFMPMLMPL;

	private Vector2 OCOLOFPLDBM;

	private Vector2 JPDJKPFNJFC;

	public bool enable = true;

	public bool isActivated = true;

	public bool showDebugRadius;

	public bool useFixedUpdate;

	public bool isUseGuiLayout = true;

	[SerializeField]
	private bool dynamicJoystick;

	public OBOLKCNLKBD area;

	[SerializeField]
	private GJGAAIHMKPP joyAnchor = GJGAAIHMKPP.LowerLeft;

	[SerializeField]
	private Vector2 joystickPositionOffset = Vector2.zero;

	[SerializeField]
	private float zoneRadius = 100f;

	[SerializeField]
	private float touchSize = 30f;

	public float deadZone = 20f;

	[SerializeField]
	private bool restrictArea;

	public bool resetFingerExit;

	[SerializeField]
	private FGKAAEEPILA interaction;

	public bool useBroadcast;

	public NBFPGICCJGI messageMode;

	public GameObject receiverGameObject;

	public Vector2 speed;

	public bool enableXaxis = true;

	[SerializeField]
	private Transform xAxisTransform;

	public CharacterController xAxisCharacterController;

	public float xAxisGravity;

	[SerializeField]
	private PPBPHBNOLPB xTI;

	public AAKCEIHPOBA xAI;

	public bool inverseXAxis;

	public bool enableXClamp;

	public float clampXMax;

	public float clampXMin;

	public bool enableXAutoStab;

	[SerializeField]
	private float thresholdX = 0.01f;

	[SerializeField]
	private float stabSpeedX = 20f;

	public bool enableYaxis = true;

	[SerializeField]
	private Transform yAxisTransform;

	public CharacterController yAxisCharacterController;

	public float yAxisGravity;

	[SerializeField]
	private PPBPHBNOLPB yTI;

	public AAKCEIHPOBA yAI;

	public bool inverseYAxis;

	public bool enableYClamp;

	public float clampYMax;

	public float clampYMin;

	public bool enableYAutoStab;

	[SerializeField]
	private float thresholdY = 0.01f;

	[SerializeField]
	private float stabSpeedY = 20f;

	public bool enableSmoothing;

	[SerializeField]
	public Vector2 smoothing = new Vector2(2f, 2f);

	public bool enableInertia;

	[SerializeField]
	public Vector2 inertia = new Vector2(100f, 100f);

	public int guiDepth;

	public bool showZone = true;

	public bool showTouch = true;

	public bool showDeadZone = true;

	public Texture areaTexture;

	public Color areaColor = Color.white;

	public Texture touchTexture;

	public Color touchColor = Color.white;

	public Texture deadTexture;

	public bool showProperties = true;

	public bool showInteraction;

	public bool showAppearance;

	public bool showPosition = true;

	private Vector2 PBBOJAFNGFH;

	private Rect NELBEGGMOMI;

	private Rect CINHFGBLLOI;

	private Vector2 IEGKLIGGLLG = Vector2.zero;

	private bool JACHCBBOAGI = true;

	private int CFCEALHPHFC = -1;

	private float PABBNPDKFBP;

	private bool FCNPFIEOCGB = true;

	private float POIJFFKKHFD;

	private float CKEDDDHLBND;

	private static ANANFHIGIAE m_HKLAGCKOMEL;

	private static NEMGKMNAJJN m_MLIFCDJLCEB;

	private static ODBDPJAPFBA m_IMCJMGALMBC;

	private static BEFGOCGLIBP m_EPPIABHFCFI;

	private static OKABMNMIBDA m_HKDNJMDPIAD;

	private static DJDBIIPMJGL m_PPHKCKCJAKP;

	private static DOLJGKPLHON m_BKOMIBGDDMP;

	public Vector2 AKMFFDCNNHA
	{
		get
		{
			return get_JoystickAxis();
		}
	}

	public Vector2 APELNCLCEHD
	{
		get
		{
			return get_JoystickTouch();
		}
		set
		{
			set_JoystickTouch(value);
		}
	}

	public Vector2 CNINKNPNFIH
	{
		get
		{
			return get_JoystickValue();
		}
	}

	public bool BNCGCNOJHDJ
	{
		get
		{
			return get_DynamicJoystick();
		}
		set
		{
			set_DynamicJoystick(value);
		}
	}

	public GJGAAIHMKPP HPHHHCKCAJP
	{
		get
		{
			return get_JoyAnchor();
		}
		set
		{
			set_JoyAnchor(value);
		}
	}

	public Vector2 GELDKNAIPDB
	{
		get
		{
			return get_JoystickPositionOffset();
		}
		set
		{
			set_JoystickPositionOffset(value);
		}
	}

	public float EPLFNDKKGHB
	{
		get
		{
			return get_ZoneRadius();
		}
		set
		{
			set_ZoneRadius(value);
		}
	}

	public float PCLGJKJLIAB
	{
		get
		{
			return get_TouchSize();
		}
		set
		{
			set_TouchSize(value);
		}
	}

	public bool DGEEMAGKPBJ
	{
		get
		{
			return get_RestrictArea();
		}
		set
		{
			set_RestrictArea(value);
		}
	}

	public FGKAAEEPILA JLNMNNBPILF
	{
		get
		{
			return get_Interaction();
		}
		set
		{
			set_Interaction(value);
		}
	}

	public Transform APFINLNJBEA
	{
		get
		{
			return get_XAxisTransform();
		}
		set
		{
			set_XAxisTransform(value);
		}
	}

	public PPBPHBNOLPB LFJCDDOGHEA
	{
		get
		{
			return get_XTI();
		}
		set
		{
			set_XTI(value);
		}
	}

	public float PJIGDNKHCBB
	{
		get
		{
			return get_ThresholdX();
		}
		set
		{
			set_ThresholdX(value);
		}
	}

	public float NJKKCABBMHJ
	{
		get
		{
			return get_StabSpeedX();
		}
		set
		{
			set_StabSpeedX(value);
		}
	}

	public Transform FMNEBKDBFPA
	{
		get
		{
			return get_YAxisTransform();
		}
		set
		{
			set_YAxisTransform(value);
		}
	}

	public PPBPHBNOLPB PJNMPPLCBBL
	{
		get
		{
			return get_YTI();
		}
		set
		{
			set_YTI(value);
		}
	}

	public float BEFKFDCHJKM
	{
		get
		{
			return get_ThresholdY();
		}
		set
		{
			set_ThresholdY(value);
		}
	}

	public float NONMENIKMGC
	{
		get
		{
			return get_StabSpeedY();
		}
		set
		{
			set_StabSpeedY(value);
		}
	}

	public Vector2 AGIOKGKHICL
	{
		get
		{
			return get_Smoothing();
		}
		set
		{
			set_Smoothing(value);
		}
	}

	public Vector2 CFLMNEGMGNL
	{
		get
		{
			return get_Inertia();
		}
		set
		{
			set_Inertia(value);
		}
	}

	public static event ANANFHIGIAE HKLAGCKOMEL
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_JoystickMoveStart(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_JoystickMoveStart(value);
		}
	}

	public static event NEMGKMNAJJN MLIFCDJLCEB
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_JoystickMove(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_JoystickMove(value);
		}
	}

	public static event ODBDPJAPFBA IMCJMGALMBC
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_JoystickMoveEnd(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_JoystickMoveEnd(value);
		}
	}

	public static event BEFGOCGLIBP EPPIABHFCFI
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_JoystickTouchStart(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_JoystickTouchStart(value);
		}
	}

	public static event OKABMNMIBDA HKDNJMDPIAD
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_JoystickTap(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_JoystickTap(value);
		}
	}

	public static event DJDBIIPMJGL PPHKCKCJAKP
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_JoystickDoubleTap(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_JoystickDoubleTap(value);
		}
	}

	public static event DOLJGKPLHON BKOMIBGDDMP
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_JoystickTouchUp(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_JoystickTouchUp(value);
		}
	}

	public float get_TouchSize()
	{
		return touchSize;
	}

	public Vector2 get_Inertia()
	{
		return inertia;
	}

	public bool get_DynamicJoystick()
	{
		return dynamicJoystick;
	}

	public void set_Interaction(FGKAAEEPILA ICENKPDOHBK)
	{
		interaction = ICENKPDOHBK;
		if (interaction == FGKAAEEPILA.Direct || interaction == FGKAAEEPILA.Include)
		{
			useBroadcast = false;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_JoystickMoveStart(ANANFHIGIAE ICENKPDOHBK)
	{
		EasyJoystick.m_HKLAGCKOMEL = (ANANFHIGIAE)Delegate.Remove(EasyJoystick.m_HKLAGCKOMEL, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_JoystickTouchUp(DOLJGKPLHON ICENKPDOHBK)
	{
		EasyJoystick.m_BKOMIBGDDMP = (DOLJGKPLHON)Delegate.Combine(EasyJoystick.m_BKOMIBGDDMP, ICENKPDOHBK);
	}

	[SpecialName]
	public void CKKJFPLIEAG(bool ICENKPDOHBK)
	{
		if (!Application.isPlaying)
		{
			CFCEALHPHFC = -1;
			dynamicJoystick = ICENKPDOHBK;
			if (dynamicJoystick)
			{
				JACHCBBOAGI = false;
				return;
			}
			JACHCBBOAGI = true;
			PBBOJAFNGFH = joystickPositionOffset;
		}
	}

	private void OnDisable()
	{
		EasyTouch.remove_On_TouchStart(FHBOBAEJJFP);
		EasyTouch.remove_On_TouchUp(DGEFKKDJLAA);
		EasyTouch.remove_On_TouchDown(FEOACGMPIOG);
		EasyTouch.remove_On_SimpleTap(KPMBACFCALN);
		EasyTouch.remove_On_DoubleTap(CNALFPOJBIK);
		if (Application.isPlaying)
		{
			EasyTouch.RemoveReservedArea(NELBEGGMOMI);
		}
	}

	public float get_StabSpeedY()
	{
		return stabSpeedY;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_JoystickMove(NEMGKMNAJJN ICENKPDOHBK)
	{
		EasyJoystick.m_MLIFCDJLCEB = (NEMGKMNAJJN)Delegate.Combine(EasyJoystick.m_MLIFCDJLCEB, ICENKPDOHBK);
	}

	private void GIDDBKOINLC()
	{
		if (xAxisCharacterController != null && xAxisGravity > 0f)
		{
			xAxisCharacterController.Move(Vector3.down * xAxisGravity * Time.deltaTime);
		}
		if (yAxisCharacterController != null && yAxisGravity > 0f)
		{
			yAxisCharacterController.Move(Vector3.down * yAxisGravity * Time.deltaTime);
		}
	}

	private float FOJEPAPKJNM(Transform JGFNCGJLLJD, AAKCEIHPOBA BGCBMDCJMBK)
	{
		float num = 0f;
		if (JGFNCGJLLJD != null)
		{
			switch (BGCBMDCJMBK)
			{
			case AAKCEIHPOBA.X:
				num = JGFNCGJLLJD.localRotation.eulerAngles.x;
				break;
			case AAKCEIHPOBA.Y:
				num = JGFNCGJLLJD.localRotation.eulerAngles.y;
				break;
			case AAKCEIHPOBA.Z:
				num = JGFNCGJLLJD.localRotation.eulerAngles.z;
				break;
			}
			if (num <= 360f && num >= 180f)
			{
				num -= 360f;
			}
		}
		return num;
	}

	public Vector2 get_JoystickTouch()
	{
		return new Vector2(OCOLOFPLDBM.x / zoneRadius, OCOLOFPLDBM.y / zoneRadius);
	}

	private void DKFFHGEMAKM(GJGAAIHMKPP AFCENEHLIDB)
	{
		float num = 0f;
		if (!restrictArea)
		{
			num = touchSize;
		}
		switch (AFCENEHLIDB)
		{
		case GJGAAIHMKPP.UpperLeft:
			IEGKLIGGLLG = new Vector2(zoneRadius + num, zoneRadius + num);
			break;
		case GJGAAIHMKPP.UpperCenter:
			IEGKLIGGLLG = new Vector2(VirtualScreen.width / 2f, zoneRadius + num);
			break;
		case GJGAAIHMKPP.UpperRight:
			IEGKLIGGLLG = new Vector2(VirtualScreen.width - zoneRadius - num, zoneRadius + num);
			break;
		case GJGAAIHMKPP.MiddleLeft:
			IEGKLIGGLLG = new Vector2(zoneRadius + num, VirtualScreen.height / 2f);
			break;
		case GJGAAIHMKPP.MiddleCenter:
			IEGKLIGGLLG = new Vector2(VirtualScreen.width / 2f, VirtualScreen.height / 2f);
			break;
		case GJGAAIHMKPP.MiddleRight:
			IEGKLIGGLLG = new Vector2(VirtualScreen.width - zoneRadius - num, VirtualScreen.height / 2f);
			break;
		case GJGAAIHMKPP.LowerLeft:
			IEGKLIGGLLG = new Vector2(zoneRadius + num, VirtualScreen.height - zoneRadius - num);
			break;
		case GJGAAIHMKPP.LowerCenter:
			IEGKLIGGLLG = new Vector2(VirtualScreen.width / 2f, VirtualScreen.height - zoneRadius - num);
			break;
		case GJGAAIHMKPP.LowerRight:
			IEGKLIGGLLG = new Vector2(VirtualScreen.width - zoneRadius - num, VirtualScreen.height - zoneRadius - num);
			break;
		case GJGAAIHMKPP.None:
			IEGKLIGGLLG = Vector2.zero;
			break;
		}
		NELBEGGMOMI = new Rect(IEGKLIGGLLG.x + PBBOJAFNGFH.x - zoneRadius, IEGKLIGGLLG.y + PBBOJAFNGFH.y - zoneRadius, zoneRadius * 2f, zoneRadius * 2f);
		CINHFGBLLOI = new Rect(IEGKLIGGLLG.x + PBBOJAFNGFH.x - deadZone, IEGKLIGGLLG.y + PBBOJAFNGFH.y - deadZone, deadZone * 2f, deadZone * 2f);
	}

	private void NADHBMIGHKA(Transform JGFNCGJLLJD, AAKCEIHPOBA BGCBMDCJMBK, float HKELOLINJBK, float KPCBCBDDOAK, float HFEBFPFOOID)
	{
		float num = 0f;
		switch (BGCBMDCJMBK)
		{
		case AAKCEIHPOBA.X:
			num = JGFNCGJLLJD.localRotation.eulerAngles.x;
			break;
		case AAKCEIHPOBA.Y:
			num = JGFNCGJLLJD.localRotation.eulerAngles.y;
			break;
		case AAKCEIHPOBA.Z:
			num = JGFNCGJLLJD.localRotation.eulerAngles.z;
			break;
		}
		if (num <= 360f && num >= 180f)
		{
			num -= 360f;
		}
		num = Mathf.Clamp(num, 0f - KPCBCBDDOAK, HKELOLINJBK);
		switch (BGCBMDCJMBK)
		{
		case AAKCEIHPOBA.X:
			JGFNCGJLLJD.localEulerAngles = new Vector3(num, JGFNCGJLLJD.localEulerAngles.y, JGFNCGJLLJD.localEulerAngles.z);
			break;
		case AAKCEIHPOBA.Y:
			JGFNCGJLLJD.localEulerAngles = new Vector3(JGFNCGJLLJD.localEulerAngles.x, num, JGFNCGJLLJD.localEulerAngles.z);
			break;
		case AAKCEIHPOBA.Z:
			JGFNCGJLLJD.localEulerAngles = new Vector3(JGFNCGJLLJD.localEulerAngles.x, JGFNCGJLLJD.localEulerAngles.y, num);
			break;
		}
	}

	public void set_JoyAnchor(GJGAAIHMKPP ICENKPDOHBK)
	{
		joyAnchor = ICENKPDOHBK;
		DKFFHGEMAKM(joyAnchor);
	}

	public Vector2 get_JoystickPositionOffset()
	{
		return joystickPositionOffset;
	}

	public void set_YAxisTransform(Transform ICENKPDOHBK)
	{
		yAxisTransform = ICENKPDOHBK;
		if (yAxisTransform != null)
		{
			yAxisCharacterController = yAxisTransform.GetComponent<CharacterController>();
			return;
		}
		yAxisCharacterController = null;
		yAxisGravity = 0f;
	}

	public void set_StabSpeedY(float ICENKPDOHBK)
	{
		if (ICENKPDOHBK <= 0f)
		{
			stabSpeedY = ICENKPDOHBK * -1f;
		}
		else
		{
			stabSpeedY = ICENKPDOHBK;
		}
	}

	public void set_RestrictArea(bool ICENKPDOHBK)
	{
		restrictArea = ICENKPDOHBK;
		if (restrictArea)
		{
			PABBNPDKFBP = touchSize;
		}
		else
		{
			PABBNPDKFBP = 0f;
		}
		DKFFHGEMAKM(joyAnchor);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_JoystickDoubleTap(DJDBIIPMJGL ICENKPDOHBK)
	{
		EasyJoystick.m_PPHKCKCJAKP = (DJDBIIPMJGL)Delegate.Remove(EasyJoystick.m_PPHKCKCJAKP, ICENKPDOHBK);
	}

	private void FixedUpdate()
	{
		if (useFixedUpdate && enable)
		{
			DJPGGPBBJOM();
		}
	}

	private void OnDrawGizmos()
	{
	}

	private void MFKGDIPIHEG()
	{
		if (!Application.isPlaying || !isActivated)
		{
			return;
		}
		if (CFCEALHPHFC == -1 || (JHNFMPMLMPL == Vector2.zero && CFCEALHPHFC > -1))
		{
			if (enableXAutoStab)
			{
				BKPNIKHLGDG(xAxisTransform, xAI, thresholdX, stabSpeedX, POIJFFKKHFD);
			}
			if (enableYAutoStab)
			{
				BKPNIKHLGDG(yAxisTransform, yAI, thresholdY, stabSpeedY, CKEDDDHLBND);
			}
		}
		if (!dynamicJoystick)
		{
			PBBOJAFNGFH = joystickPositionOffset;
		}
		if (CFCEALHPHFC == -1)
		{
			if (!enableSmoothing)
			{
				OCOLOFPLDBM = Vector2.zero;
			}
			else if ((double)OCOLOFPLDBM.sqrMagnitude > 1260.0)
			{
				OCOLOFPLDBM = new Vector2(OCOLOFPLDBM.x - OCOLOFPLDBM.x * smoothing.x * Time.deltaTime, OCOLOFPLDBM.y - OCOLOFPLDBM.y * smoothing.y * Time.deltaTime);
			}
			else
			{
				OCOLOFPLDBM = Vector2.zero;
			}
		}
		Vector2 vector = new Vector2(JHNFMPMLMPL.x, JHNFMPMLMPL.y);
		float num = KFMBNOKBBMK();
		JHNFMPMLMPL = new Vector2(OCOLOFPLDBM.x * num, OCOLOFPLDBM.y * num);
		if (inverseXAxis)
		{
			JHNFMPMLMPL.x *= 959f;
		}
		if (inverseYAxis)
		{
			JHNFMPMLMPL.y *= 169f;
		}
		Vector2 vector2 = new Vector2(speed.x * JHNFMPMLMPL.x, speed.y * JHNFMPMLMPL.y);
		if (enableInertia)
		{
			Vector2 vector3 = vector2 - JPDJKPFNJFC;
			vector3.x /= inertia.x;
			vector3.y /= inertia.y;
			JPDJKPFNJFC += vector3;
		}
		else
		{
			JPDJKPFNJFC = vector2;
		}
		if (vector == Vector2.zero && JHNFMPMLMPL != Vector2.zero && interaction != FGKAAEEPILA.Direct && interaction != FGKAAEEPILA.Direct)
		{
			FOGNBDIHANK(CAGDNOCMKGG.On_JoystickTouchStart);
		}
		GIDDBKOINLC();
		if (JHNFMPMLMPL != Vector2.zero)
		{
			FCNPFIEOCGB = true;
			switch (interaction)
			{
			case FGKAAEEPILA.Direct:
				FBPOCLGLLAL();
				break;
			case FGKAAEEPILA.EventNotification:
				BAAALCMEKBP((CAGDNOCMKGG)8);
				break;
			case FGKAAEEPILA.DirectAndEvent:
				FBPOCLGLLAL();
				LKNPJGEGHAC((CAGDNOCMKGG)8);
				break;
			case FGKAAEEPILA.Include:
				break;
			}
		}
		else if (!FCNPFIEOCGB)
		{
			BAAALCMEKBP(CAGDNOCMKGG.On_JoystickMoveStart);
			FCNPFIEOCGB = true;
		}
	}

	private void EECFMDHBIDH(Transform JGFNCGJLLJD, PPBPHBNOLPB NOBJPEPNNPM, Vector3 AJGDIGGBFAL, float LDEFMAOBHCH, CharacterController KDPKHGGKJKI)
	{
		switch (NOBJPEPNNPM)
		{
		case PPBPHBNOLPB.Rotate:
			JGFNCGJLLJD.Rotate(AJGDIGGBFAL * LDEFMAOBHCH * Time.deltaTime, Space.Self);
			break;
		case PPBPHBNOLPB.RotateLocal:
			JGFNCGJLLJD.Rotate(AJGDIGGBFAL * LDEFMAOBHCH * Time.deltaTime, Space.World);
			break;
		case PPBPHBNOLPB.Translate:
			if (KDPKHGGKJKI == null)
			{
				JGFNCGJLLJD.Translate(AJGDIGGBFAL * LDEFMAOBHCH * Time.deltaTime, Space.Self);
			}
			else
			{
				KDPKHGGKJKI.Move(AJGDIGGBFAL * LDEFMAOBHCH * Time.deltaTime);
			}
			break;
		case PPBPHBNOLPB.TranslateLocal:
			if (KDPKHGGKJKI == null)
			{
				JGFNCGJLLJD.Translate(AJGDIGGBFAL * LDEFMAOBHCH * Time.deltaTime, Space.World);
			}
			else
			{
				KDPKHGGKJKI.Move(KDPKHGGKJKI.transform.TransformDirection(AJGDIGGBFAL) * LDEFMAOBHCH * Time.deltaTime);
			}
			break;
		case PPBPHBNOLPB.Scale:
			JGFNCGJLLJD.localScale += AJGDIGGBFAL * LDEFMAOBHCH * Time.deltaTime;
			break;
		}
	}

	public float get_ZoneRadius()
	{
		return zoneRadius;
	}

	private void FOGNBDIHANK(CAGDNOCMKGG AMOPEEBFAPD)
	{
		OIAKHGNLGJC oIAKHGNLGJC = new OIAKHGNLGJC();
		oIAKHGNLGJC.CEIPKAJDKGK = base.gameObject.name;
		oIAKHGNLGJC.JHNFMPMLMPL = JHNFMPMLMPL;
		oIAKHGNLGJC.JPDJKPFNJFC = JPDJKPFNJFC;
		oIAKHGNLGJC.COLADFPAFPP = this;
		if (!useBroadcast)
		{
			switch (AMOPEEBFAPD)
			{
			case CAGDNOCMKGG.On_JoystickMoveStart:
				if (EasyJoystick.m_HKLAGCKOMEL != null)
				{
					EasyJoystick.m_HKLAGCKOMEL(oIAKHGNLGJC);
				}
				break;
			case CAGDNOCMKGG.On_JoystickMove:
				if (EasyJoystick.m_MLIFCDJLCEB != null)
				{
					EasyJoystick.m_MLIFCDJLCEB(oIAKHGNLGJC);
				}
				break;
			case CAGDNOCMKGG.On_JoystickMoveEnd:
				if (EasyJoystick.m_IMCJMGALMBC != null)
				{
					EasyJoystick.m_IMCJMGALMBC(oIAKHGNLGJC);
				}
				break;
			case CAGDNOCMKGG.On_JoystickTouchStart:
				if (EasyJoystick.m_EPPIABHFCFI != null)
				{
					EasyJoystick.m_EPPIABHFCFI(oIAKHGNLGJC);
				}
				break;
			case CAGDNOCMKGG.On_JoystickTap:
				if (EasyJoystick.m_HKDNJMDPIAD != null)
				{
					EasyJoystick.m_HKDNJMDPIAD(oIAKHGNLGJC);
				}
				break;
			case CAGDNOCMKGG.On_JoystickDoubleTap:
				if (EasyJoystick.m_PPHKCKCJAKP != null)
				{
					EasyJoystick.m_PPHKCKCJAKP(oIAKHGNLGJC);
				}
				break;
			case CAGDNOCMKGG.On_JoystickTouchUp:
				if (EasyJoystick.m_BKOMIBGDDMP != null)
				{
					EasyJoystick.m_BKOMIBGDDMP(oIAKHGNLGJC);
				}
				break;
			}
		}
		else
		{
			if (!useBroadcast)
			{
				return;
			}
			if (receiverGameObject != null)
			{
				switch (messageMode)
				{
				case NBFPGICCJGI.BroadcastMessage:
					receiverGameObject.BroadcastMessage(AMOPEEBFAPD.ToString(), oIAKHGNLGJC, SendMessageOptions.RequireReceiver);
					break;
				case NBFPGICCJGI.SendMessage:
					receiverGameObject.SendMessage(AMOPEEBFAPD.ToString(), oIAKHGNLGJC, SendMessageOptions.RequireReceiver);
					break;
				case NBFPGICCJGI.SendMessageUpwards:
					receiverGameObject.SendMessageUpwards(AMOPEEBFAPD.ToString(), oIAKHGNLGJC, SendMessageOptions.RequireReceiver);
					break;
				}
			}
			else
			{
				Debug.LogError("설명" + base.gameObject.name + "skill1_voice");
			}
		}
	}

	[SpecialName]
	public float IJPFONCNJLB()
	{
		return thresholdY;
	}

	private void OnDestroy()
	{
		EasyTouch.remove_On_TouchStart(FHBOBAEJJFP);
		EasyTouch.remove_On_TouchUp(DGEFKKDJLAA);
		EasyTouch.remove_On_TouchDown(FEOACGMPIOG);
		EasyTouch.remove_On_SimpleTap(KPMBACFCALN);
		EasyTouch.remove_On_DoubleTap(CNALFPOJBIK);
		if (Application.isPlaying)
		{
			EasyTouch.RemoveReservedArea(NELBEGGMOMI);
		}
	}

	public void set_Inertia(Vector2 ICENKPDOHBK)
	{
		inertia = ICENKPDOHBK;
		if (inertia.x <= 0f)
		{
			inertia.x = 1f;
		}
		if (inertia.y <= 0f)
		{
			inertia.y = 1f;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_JoystickMoveEnd(ODBDPJAPFBA ICENKPDOHBK)
	{
		EasyJoystick.m_IMCJMGALMBC = (ODBDPJAPFBA)Delegate.Remove(EasyJoystick.m_IMCJMGALMBC, ICENKPDOHBK);
	}

	private void KDKJCDHPNIB(Transform JGFNCGJLLJD, PPBPHBNOLPB NOBJPEPNNPM, Vector3 AJGDIGGBFAL, float LDEFMAOBHCH, CharacterController KDPKHGGKJKI)
	{
		switch (NOBJPEPNNPM)
		{
		case PPBPHBNOLPB.Rotate:
			JGFNCGJLLJD.Rotate(AJGDIGGBFAL * LDEFMAOBHCH * Time.deltaTime, Space.World);
			break;
		case PPBPHBNOLPB.RotateLocal:
			JGFNCGJLLJD.Rotate(AJGDIGGBFAL * LDEFMAOBHCH * Time.deltaTime, Space.Self);
			break;
		case PPBPHBNOLPB.Translate:
			if (KDPKHGGKJKI == null)
			{
				JGFNCGJLLJD.Translate(AJGDIGGBFAL * LDEFMAOBHCH * Time.deltaTime, Space.World);
			}
			else
			{
				KDPKHGGKJKI.Move(AJGDIGGBFAL * LDEFMAOBHCH * Time.deltaTime);
			}
			break;
		case PPBPHBNOLPB.TranslateLocal:
			if (KDPKHGGKJKI == null)
			{
				JGFNCGJLLJD.Translate(AJGDIGGBFAL * LDEFMAOBHCH * Time.deltaTime, Space.Self);
			}
			else
			{
				KDPKHGGKJKI.Move(KDPKHGGKJKI.transform.TransformDirection(AJGDIGGBFAL) * LDEFMAOBHCH * Time.deltaTime);
			}
			break;
		case PPBPHBNOLPB.Scale:
			JGFNCGJLLJD.localScale += AJGDIGGBFAL * LDEFMAOBHCH * Time.deltaTime;
			break;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_JoystickMoveEnd(ODBDPJAPFBA ICENKPDOHBK)
	{
		EasyJoystick.m_IMCJMGALMBC = (ODBDPJAPFBA)Delegate.Combine(EasyJoystick.m_IMCJMGALMBC, ICENKPDOHBK);
	}

	private void OnGUI()
	{
		if (enable)
		{
			GUI.depth = guiDepth;
			base.useGUILayout = isUseGuiLayout;
			if (dynamicJoystick && Application.isEditor && !Application.isPlaying)
			{
				switch (area)
				{
				case OBOLKCNLKBD.Bottom:
					DKFFHGEMAKM(GJGAAIHMKPP.LowerCenter);
					break;
				case OBOLKCNLKBD.BottomLeft:
					DKFFHGEMAKM(GJGAAIHMKPP.LowerLeft);
					break;
				case OBOLKCNLKBD.BottomRight:
					DKFFHGEMAKM(GJGAAIHMKPP.LowerRight);
					break;
				case OBOLKCNLKBD.FullScreen:
					DKFFHGEMAKM(GJGAAIHMKPP.MiddleCenter);
					break;
				case OBOLKCNLKBD.Left:
					DKFFHGEMAKM(GJGAAIHMKPP.MiddleLeft);
					break;
				case OBOLKCNLKBD.Right:
					DKFFHGEMAKM(GJGAAIHMKPP.MiddleRight);
					break;
				case OBOLKCNLKBD.Top:
					DKFFHGEMAKM(GJGAAIHMKPP.UpperCenter);
					break;
				case OBOLKCNLKBD.TopLeft:
					DKFFHGEMAKM(GJGAAIHMKPP.UpperLeft);
					break;
				case OBOLKCNLKBD.TopRight:
					DKFFHGEMAKM(GJGAAIHMKPP.UpperRight);
					break;
				}
			}
			if (Application.isEditor && !Application.isPlaying)
			{
				VirtualScreen.ComputeVirtualScreen();
				DKFFHGEMAKM(joyAnchor);
			}
			VirtualScreen.SetGuiScaleMatrix();
			if ((showZone && areaTexture != null && !dynamicJoystick) || (showZone && dynamicJoystick && JACHCBBOAGI && areaTexture != null) || (dynamicJoystick && Application.isEditor && !Application.isPlaying))
			{
				if (isActivated)
				{
					GUI.color = areaColor;
					if (Application.isPlaying && !dynamicJoystick)
					{
						EasyTouch.RemoveReservedArea(NELBEGGMOMI);
						EasyTouch.AddReservedArea(NELBEGGMOMI);
					}
				}
				else
				{
					GUI.color = new Color(areaColor.r, areaColor.g, areaColor.b, 0.2f);
					if (Application.isPlaying && !dynamicJoystick)
					{
						EasyTouch.RemoveReservedArea(NELBEGGMOMI);
					}
				}
				if (showDebugRadius && Application.isEditor)
				{
					GUI.Box(NELBEGGMOMI, string.Empty);
				}
				GUI.DrawTexture(NELBEGGMOMI, areaTexture, ScaleMode.StretchToFill, true);
			}
			if ((showTouch && touchTexture != null && !dynamicJoystick) || (showTouch && dynamicJoystick && JACHCBBOAGI && touchTexture != null) || (dynamicJoystick && Application.isEditor && !Application.isPlaying))
			{
				if (isActivated)
				{
					GUI.color = touchColor;
				}
				else
				{
					GUI.color = new Color(touchColor.r, touchColor.g, touchColor.b, 0.2f);
				}
				GUI.DrawTexture(new Rect(IEGKLIGGLLG.x + PBBOJAFNGFH.x + (OCOLOFPLDBM.x - touchSize), IEGKLIGGLLG.y + PBBOJAFNGFH.y - (OCOLOFPLDBM.y + touchSize), touchSize * 2f, touchSize * 2f), touchTexture, ScaleMode.ScaleToFit, true);
			}
			if ((showDeadZone && deadTexture != null && !dynamicJoystick) || (showDeadZone && dynamicJoystick && JACHCBBOAGI && deadTexture != null) || (dynamicJoystick && Application.isEditor && !Application.isPlaying))
			{
				GUI.DrawTexture(CINHFGBLLOI, deadTexture, ScaleMode.ScaleToFit, true);
			}
			GUI.color = Color.white;
		}
		else
		{
			EasyTouch.RemoveReservedArea(NELBEGGMOMI);
		}
	}

	public void set_XAxisTransform(Transform ICENKPDOHBK)
	{
		xAxisTransform = ICENKPDOHBK;
		if (xAxisTransform != null)
		{
			xAxisCharacterController = xAxisTransform.GetComponent<CharacterController>();
			return;
		}
		xAxisCharacterController = null;
		xAxisGravity = 0f;
	}

	private void BAAALCMEKBP(CAGDNOCMKGG AMOPEEBFAPD)
	{
		OIAKHGNLGJC oIAKHGNLGJC = new OIAKHGNLGJC();
		oIAKHGNLGJC.CEIPKAJDKGK = base.gameObject.name;
		oIAKHGNLGJC.JHNFMPMLMPL = JHNFMPMLMPL;
		oIAKHGNLGJC.JPDJKPFNJFC = JPDJKPFNJFC;
		oIAKHGNLGJC.COLADFPAFPP = this;
		if (!useBroadcast)
		{
			switch (AMOPEEBFAPD)
			{
			case CAGDNOCMKGG.On_JoystickMoveStart:
				if (EasyJoystick.m_HKLAGCKOMEL != null)
				{
					EasyJoystick.m_HKLAGCKOMEL(oIAKHGNLGJC);
				}
				break;
			case CAGDNOCMKGG.On_JoystickMove:
				if (EasyJoystick.m_MLIFCDJLCEB != null)
				{
					EasyJoystick.m_MLIFCDJLCEB(oIAKHGNLGJC);
				}
				break;
			case CAGDNOCMKGG.On_JoystickMoveEnd:
				if (EasyJoystick.m_IMCJMGALMBC != null)
				{
					EasyJoystick.m_IMCJMGALMBC(oIAKHGNLGJC);
				}
				break;
			case CAGDNOCMKGG.On_JoystickTouchStart:
				if (EasyJoystick.m_EPPIABHFCFI != null)
				{
					EasyJoystick.m_EPPIABHFCFI(oIAKHGNLGJC);
				}
				break;
			case CAGDNOCMKGG.On_JoystickTap:
				if (EasyJoystick.m_HKDNJMDPIAD != null)
				{
					EasyJoystick.m_HKDNJMDPIAD(oIAKHGNLGJC);
				}
				break;
			case CAGDNOCMKGG.On_JoystickDoubleTap:
				if (EasyJoystick.m_PPHKCKCJAKP != null)
				{
					EasyJoystick.m_PPHKCKCJAKP(oIAKHGNLGJC);
				}
				break;
			case CAGDNOCMKGG.On_JoystickTouchUp:
				if (EasyJoystick.m_BKOMIBGDDMP != null)
				{
					EasyJoystick.m_BKOMIBGDDMP(oIAKHGNLGJC);
				}
				break;
			}
		}
		else
		{
			if (!useBroadcast)
			{
				return;
			}
			if (receiverGameObject != null)
			{
				switch (messageMode)
				{
				case NBFPGICCJGI.BroadcastMessage:
					receiverGameObject.BroadcastMessage(AMOPEEBFAPD.ToString(), oIAKHGNLGJC, SendMessageOptions.DontRequireReceiver);
					break;
				case NBFPGICCJGI.SendMessage:
					receiverGameObject.SendMessage(AMOPEEBFAPD.ToString(), oIAKHGNLGJC, SendMessageOptions.DontRequireReceiver);
					break;
				case NBFPGICCJGI.SendMessageUpwards:
					receiverGameObject.SendMessageUpwards(AMOPEEBFAPD.ToString(), oIAKHGNLGJC, SendMessageOptions.DontRequireReceiver);
					break;
				}
			}
			else
			{
				Debug.LogError("Joystick : " + base.gameObject.name + " : you must setup receiver gameobject");
			}
		}
	}

	public Transform get_XAxisTransform()
	{
		return xAxisTransform;
	}

	public Vector2 get_JoystickValue()
	{
		return JPDJKPFNJFC;
	}

	private void KPMBACFCALN(NLKIHCFELMK BMNGEAFPELI)
	{
		if (((!BMNGEAFPELI.GFNKEFEIFNA && dynamicJoystick) || !dynamicJoystick) && isActivated && BMNGEAFPELI.NKGNNOMNIKO == CFCEALHPHFC)
		{
			BAAALCMEKBP(CAGDNOCMKGG.On_JoystickTap);
		}
	}

	[SpecialName]
	public static void IDGEEDFNLDA(ODBDPJAPFBA ICENKPDOHBK)
	{
		EasyJoystick.m_IMCJMGALMBC = (ODBDPJAPFBA)Delegate.Combine(EasyJoystick.m_IMCJMGALMBC, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_JoystickDoubleTap(DJDBIIPMJGL ICENKPDOHBK)
	{
		EasyJoystick.m_PPHKCKCJAKP = (DJDBIIPMJGL)Delegate.Combine(EasyJoystick.m_PPHKCKCJAKP, ICENKPDOHBK);
	}

	private Vector3 BBODKBLDMJA(AAKCEIHPOBA BGCBMDCJMBK)
	{
		Vector3 result = Vector3.zero;
		switch (BGCBMDCJMBK)
		{
		case AAKCEIHPOBA.X:
			result = Vector3.right;
			break;
		case AAKCEIHPOBA.Y:
			result = Vector3.up;
			break;
		case AAKCEIHPOBA.Z:
			result = Vector3.forward;
			break;
		case AAKCEIHPOBA.XYZ:
			result = Vector3.one;
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_JoystickMoveStart(ANANFHIGIAE ICENKPDOHBK)
	{
		EasyJoystick.m_HKLAGCKOMEL = (ANANFHIGIAE)Delegate.Combine(EasyJoystick.m_HKLAGCKOMEL, ICENKPDOHBK);
	}

	public void set_ThresholdY(float ICENKPDOHBK)
	{
		if (ICENKPDOHBK <= 0f)
		{
			thresholdY = ICENKPDOHBK * -1f;
		}
		else
		{
			thresholdY = ICENKPDOHBK;
		}
	}

	public Vector2 get_Smoothing()
	{
		return smoothing;
	}

	[SpecialName]
	public GJGAAIHMKPP KEKGKMKCHJK()
	{
		return joyAnchor;
	}

	public float get_ThresholdY()
	{
		return thresholdY;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_JoystickTap(OKABMNMIBDA ICENKPDOHBK)
	{
		EasyJoystick.m_HKDNJMDPIAD = (OKABMNMIBDA)Delegate.Remove(EasyJoystick.m_HKDNJMDPIAD, ICENKPDOHBK);
	}

	private float CDCGLCEOJJM(Transform JGFNCGJLLJD, AAKCEIHPOBA BGCBMDCJMBK)
	{
		float num = 1994f;
		if (JGFNCGJLLJD != null)
		{
			switch (BGCBMDCJMBK)
			{
			case AAKCEIHPOBA.X:
				num = JGFNCGJLLJD.localRotation.eulerAngles.x;
				break;
			case AAKCEIHPOBA.Y:
				num = JGFNCGJLLJD.localRotation.eulerAngles.y;
				break;
			case AAKCEIHPOBA.Z:
				num = JGFNCGJLLJD.localRotation.eulerAngles.z;
				break;
			}
			if (num <= 824f && num >= 797f)
			{
				num -= 423f;
			}
		}
		return num;
	}

	private float KFMBNOKBBMK()
	{
		float num = 0f;
		float num2 = Mathf.Max(OCOLOFPLDBM.magnitude, 0.1f);
		if (restrictArea)
		{
			return Mathf.Max(num2 - deadZone, 0f) / (zoneRadius - touchSize - deadZone) / num2;
		}
		return Mathf.Max(num2 - deadZone, 0f) / (zoneRadius - deadZone) / num2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_JoystickTouchStart(BEFGOCGLIBP ICENKPDOHBK)
	{
		EasyJoystick.m_EPPIABHFCFI = (BEFGOCGLIBP)Delegate.Remove(EasyJoystick.m_EPPIABHFCFI, ICENKPDOHBK);
	}

	public Vector2 get_JoystickAxis()
	{
		return JHNFMPMLMPL;
	}

	public void set_Smoothing(Vector2 ICENKPDOHBK)
	{
		smoothing = ICENKPDOHBK;
		if (smoothing.x < 0f)
		{
			smoothing.x = 0f;
		}
		if (smoothing.y < 0f)
		{
			smoothing.y = 0f;
		}
	}

	public PPBPHBNOLPB get_XTI()
	{
		return xTI;
	}

	public void set_TouchSize(float ICENKPDOHBK)
	{
		touchSize = ICENKPDOHBK;
		if (touchSize > zoneRadius / 2f && restrictArea)
		{
			touchSize = zoneRadius / 2f;
		}
		DKFFHGEMAKM(joyAnchor);
	}

	[SpecialName]
	public float DDIDOLKMFOJ()
	{
		return stabSpeedX;
	}

	public GJGAAIHMKPP get_JoyAnchor()
	{
		return joyAnchor;
	}

	private void DGEFKKDJLAA(NLKIHCFELMK BMNGEAFPELI)
	{
		if (((!BMNGEAFPELI.GFNKEFEIFNA && dynamicJoystick) || !dynamicJoystick) && isActivated && BMNGEAFPELI.NKGNNOMNIKO == CFCEALHPHFC)
		{
			CFCEALHPHFC = -1;
			if (dynamicJoystick)
			{
				JACHCBBOAGI = false;
			}
			BAAALCMEKBP(CAGDNOCMKGG.On_JoystickTouchUp);
		}
	}

	private void FEOACGMPIOG(NLKIHCFELMK BMNGEAFPELI)
	{
		if (((BMNGEAFPELI.GFNKEFEIFNA || !dynamicJoystick) && dynamicJoystick) || !isActivated)
		{
			return;
		}
		Vector2 vector = new Vector2((IEGKLIGGLLG.x + PBBOJAFNGFH.x) * VirtualScreen.xRatio, (VirtualScreen.height - (IEGKLIGGLLG.y + PBBOJAFNGFH.y)) * VirtualScreen.yRatio);
		if (BMNGEAFPELI.NKGNNOMNIKO != CFCEALHPHFC)
		{
			return;
		}
		if (((BMNGEAFPELI.CMGMOJAFLFL - vector).sqrMagnitude < zoneRadius * VirtualScreen.xRatio * (zoneRadius * VirtualScreen.xRatio) && resetFingerExit) || !resetFingerExit)
		{
			OCOLOFPLDBM = new Vector2(BMNGEAFPELI.CMGMOJAFLFL.x, BMNGEAFPELI.CMGMOJAFLFL.y) - vector;
			OCOLOFPLDBM = new Vector2(OCOLOFPLDBM.x / VirtualScreen.xRatio, OCOLOFPLDBM.y / VirtualScreen.yRatio);
			if (!enableXaxis)
			{
				OCOLOFPLDBM.x = 0f;
			}
			if (!enableYaxis)
			{
				OCOLOFPLDBM.y = 0f;
			}
			if ((OCOLOFPLDBM / (zoneRadius - PABBNPDKFBP)).sqrMagnitude > 1f)
			{
				OCOLOFPLDBM.Normalize();
				OCOLOFPLDBM *= zoneRadius - PABBNPDKFBP;
			}
		}
		else
		{
			DGEFKKDJLAA(BMNGEAFPELI);
		}
	}

	private void Start()
	{
		if (!dynamicJoystick)
		{
			PBBOJAFNGFH = joystickPositionOffset;
			DKFFHGEMAKM(joyAnchor);
			JACHCBBOAGI = true;
		}
		else
		{
			JACHCBBOAGI = false;
		}
		VirtualScreen.ComputeVirtualScreen();
		POIJFFKKHFD = FOJEPAPKJNM(xAxisTransform, xAI);
		CKEDDDHLBND = FOJEPAPKJNM(yAxisTransform, yAI);
	}

	private void BKPNIKHLGDG(Transform JGFNCGJLLJD, AAKCEIHPOBA BGCBMDCJMBK, float IEFOOHDGFFP, float MEGDEIKCOII, float HFEBFPFOOID)
	{
		float num = 0f;
		switch (BGCBMDCJMBK)
		{
		case AAKCEIHPOBA.X:
			num = JGFNCGJLLJD.localRotation.eulerAngles.x;
			break;
		case AAKCEIHPOBA.Y:
			num = JGFNCGJLLJD.localRotation.eulerAngles.y;
			break;
		case AAKCEIHPOBA.Z:
			num = JGFNCGJLLJD.localRotation.eulerAngles.z;
			break;
		}
		if (num <= 360f && num >= 180f)
		{
			num -= 360f;
		}
		if (num > HFEBFPFOOID - IEFOOHDGFFP || num < HFEBFPFOOID + IEFOOHDGFFP)
		{
			float num2 = 0f;
			Vector3 euler = Vector3.zero;
			if (num > HFEBFPFOOID - IEFOOHDGFFP)
			{
				num2 = num + MEGDEIKCOII / 100f * Mathf.Abs(num - HFEBFPFOOID) * Time.deltaTime * -1f;
			}
			if (num < HFEBFPFOOID + IEFOOHDGFFP)
			{
				num2 = num + MEGDEIKCOII / 100f * Mathf.Abs(num - HFEBFPFOOID) * Time.deltaTime;
			}
			switch (BGCBMDCJMBK)
			{
			case AAKCEIHPOBA.X:
				euler = new Vector3(num2, JGFNCGJLLJD.localRotation.eulerAngles.y, JGFNCGJLLJD.localRotation.eulerAngles.z);
				break;
			case AAKCEIHPOBA.Y:
				euler = new Vector3(JGFNCGJLLJD.localRotation.eulerAngles.x, num2, JGFNCGJLLJD.localRotation.eulerAngles.z);
				break;
			case AAKCEIHPOBA.Z:
				euler = new Vector3(JGFNCGJLLJD.localRotation.eulerAngles.x, JGFNCGJLLJD.localRotation.eulerAngles.y, num2);
				break;
			}
			JGFNCGJLLJD.localRotation = Quaternion.Euler(euler);
		}
	}

	public void set_ThresholdX(float ICENKPDOHBK)
	{
		if (ICENKPDOHBK <= 0f)
		{
			thresholdX = ICENKPDOHBK * -1f;
		}
		else
		{
			thresholdX = ICENKPDOHBK;
		}
	}

	[SpecialName]
	public static void APKGOHKNNFC(NEMGKMNAJJN ICENKPDOHBK)
	{
		EasyJoystick.m_MLIFCDJLCEB = (NEMGKMNAJJN)Delegate.Combine(EasyJoystick.m_MLIFCDJLCEB, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_JoystickTouchStart(BEFGOCGLIBP ICENKPDOHBK)
	{
		EasyJoystick.m_EPPIABHFCFI = (BEFGOCGLIBP)Delegate.Combine(EasyJoystick.m_EPPIABHFCFI, ICENKPDOHBK);
	}

	private void OnEnable()
	{
		EasyTouch.add_On_TouchStart(FHBOBAEJJFP);
		EasyTouch.add_On_TouchUp(DGEFKKDJLAA);
		EasyTouch.add_On_TouchDown(FEOACGMPIOG);
		EasyTouch.add_On_SimpleTap(KPMBACFCALN);
		EasyTouch.add_On_DoubleTap(CNALFPOJBIK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_JoystickTap(OKABMNMIBDA ICENKPDOHBK)
	{
		EasyJoystick.m_HKDNJMDPIAD = (OKABMNMIBDA)Delegate.Combine(EasyJoystick.m_HKDNJMDPIAD, ICENKPDOHBK);
	}

	public void set_JoystickPositionOffset(Vector2 ICENKPDOHBK)
	{
		joystickPositionOffset = ICENKPDOHBK;
		DKFFHGEMAKM(joyAnchor);
	}

	public FGKAAEEPILA get_Interaction()
	{
		return interaction;
	}

	public void set_ZoneRadius(float ICENKPDOHBK)
	{
		zoneRadius = ICENKPDOHBK;
		DKFFHGEMAKM(joyAnchor);
	}

	public float get_StabSpeedX()
	{
		return stabSpeedX;
	}

	[SpecialName]
	public static void FKNNBGPDHNB(OKABMNMIBDA ICENKPDOHBK)
	{
		EasyJoystick.m_HKDNJMDPIAD = (OKABMNMIBDA)Delegate.Combine(EasyJoystick.m_HKDNJMDPIAD, ICENKPDOHBK);
	}

	public void set_StabSpeedX(float ICENKPDOHBK)
	{
		if (ICENKPDOHBK <= 0f)
		{
			stabSpeedX = ICENKPDOHBK * -1f;
		}
		else
		{
			stabSpeedX = ICENKPDOHBK;
		}
	}

	private void CNALFPOJBIK(NLKIHCFELMK BMNGEAFPELI)
	{
		if (((!BMNGEAFPELI.GFNKEFEIFNA && dynamicJoystick) || !dynamicJoystick) && isActivated && BMNGEAFPELI.NKGNNOMNIKO == CFCEALHPHFC)
		{
			BAAALCMEKBP(CAGDNOCMKGG.On_JoystickDoubleTap);
		}
	}

	public Transform get_YAxisTransform()
	{
		return yAxisTransform;
	}

	public bool get_RestrictArea()
	{
		return restrictArea;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_JoystickMove(NEMGKMNAJJN ICENKPDOHBK)
	{
		EasyJoystick.m_MLIFCDJLCEB = (NEMGKMNAJJN)Delegate.Remove(EasyJoystick.m_MLIFCDJLCEB, ICENKPDOHBK);
	}

	public void set_JoystickTouch(Vector2 ICENKPDOHBK)
	{
		float x = Mathf.Clamp(ICENKPDOHBK.x, -1f, 1f) * zoneRadius;
		float y = Mathf.Clamp(ICENKPDOHBK.y, -1f, 1f) * zoneRadius;
		OCOLOFPLDBM = new Vector2(x, y);
	}

	public void set_YTI(PPBPHBNOLPB ICENKPDOHBK)
	{
		yTI = ICENKPDOHBK;
		if (yTI != PPBPHBNOLPB.RotateLocal)
		{
			enableYAutoStab = false;
			enableYClamp = false;
		}
	}

	[SpecialName]
	public void FCMKCDEGDBP(GJGAAIHMKPP ICENKPDOHBK)
	{
		joyAnchor = ICENKPDOHBK;
		DKFFHGEMAKM(joyAnchor);
	}

	public void set_DynamicJoystick(bool ICENKPDOHBK)
	{
		if (!Application.isPlaying)
		{
			CFCEALHPHFC = -1;
			dynamicJoystick = ICENKPDOHBK;
			if (dynamicJoystick)
			{
				JACHCBBOAGI = false;
				return;
			}
			JACHCBBOAGI = true;
			PBBOJAFNGFH = joystickPositionOffset;
		}
	}

	public void set_XTI(PPBPHBNOLPB ICENKPDOHBK)
	{
		xTI = ICENKPDOHBK;
		if (xTI != PPBPHBNOLPB.RotateLocal)
		{
			enableXAutoStab = false;
			enableXClamp = false;
		}
	}

	public PPBPHBNOLPB get_YTI()
	{
		return yTI;
	}

	public float get_ThresholdX()
	{
		return thresholdX;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_JoystickTouchUp(DOLJGKPLHON ICENKPDOHBK)
	{
		EasyJoystick.m_BKOMIBGDDMP = (DOLJGKPLHON)Delegate.Remove(EasyJoystick.m_BKOMIBGDDMP, ICENKPDOHBK);
	}

	private void EEIAFDGONIA(Transform JGFNCGJLLJD, PPBPHBNOLPB NOBJPEPNNPM, Vector3 AJGDIGGBFAL, float LDEFMAOBHCH, CharacterController KDPKHGGKJKI)
	{
		switch (NOBJPEPNNPM)
		{
		case PPBPHBNOLPB.Rotate:
			JGFNCGJLLJD.Rotate(AJGDIGGBFAL * LDEFMAOBHCH * Time.deltaTime, Space.Self);
			break;
		case PPBPHBNOLPB.RotateLocal:
			JGFNCGJLLJD.Rotate(AJGDIGGBFAL * LDEFMAOBHCH * Time.deltaTime, Space.World);
			break;
		case PPBPHBNOLPB.Translate:
			if (KDPKHGGKJKI == null)
			{
				JGFNCGJLLJD.Translate(AJGDIGGBFAL * LDEFMAOBHCH * Time.deltaTime, Space.Self);
			}
			else
			{
				KDPKHGGKJKI.Move(AJGDIGGBFAL * LDEFMAOBHCH * Time.deltaTime);
			}
			break;
		case PPBPHBNOLPB.TranslateLocal:
			if (KDPKHGGKJKI == null)
			{
				JGFNCGJLLJD.Translate(AJGDIGGBFAL * LDEFMAOBHCH * Time.deltaTime, Space.World);
			}
			else
			{
				KDPKHGGKJKI.Move(KDPKHGGKJKI.transform.TransformDirection(AJGDIGGBFAL) * LDEFMAOBHCH * Time.deltaTime);
			}
			break;
		case PPBPHBNOLPB.Scale:
			JGFNCGJLLJD.localScale += AJGDIGGBFAL * LDEFMAOBHCH * Time.deltaTime;
			break;
		}
	}

	[SpecialName]
	public Vector2 ODIPMJFCAGI()
	{
		return JHNFMPMLMPL;
	}

	[SpecialName]
	public void FEFAAAGDKIE(float ICENKPDOHBK)
	{
		if (ICENKPDOHBK <= 887f)
		{
			stabSpeedX = ICENKPDOHBK * 403f;
		}
		else
		{
			stabSpeedX = ICENKPDOHBK;
		}
	}

	[SpecialName]
	public static void KFFPEAHADEE(NEMGKMNAJJN ICENKPDOHBK)
	{
		EasyJoystick.m_MLIFCDJLCEB = (NEMGKMNAJJN)Delegate.Combine(EasyJoystick.m_MLIFCDJLCEB, ICENKPDOHBK);
	}

	private void Update()
	{
		if (!useFixedUpdate && enable)
		{
			DJPGGPBBJOM();
		}
	}

	private void FBPOCLGLLAL()
	{
		if (xAxisTransform != null)
		{
			Vector3 aJGDIGGBFAL = BBODKBLDMJA(xAI);
			KDKJCDHPNIB(xAxisTransform, xTI, aJGDIGGBFAL, JPDJKPFNJFC.x, xAxisCharacterController);
			if (enableXClamp && xTI == PPBPHBNOLPB.RotateLocal)
			{
				NADHBMIGHKA(xAxisTransform, xAI, clampXMin, clampXMax, POIJFFKKHFD);
			}
		}
		if (get_YAxisTransform() != null)
		{
			Vector3 aJGDIGGBFAL2 = BBODKBLDMJA(yAI);
			KDKJCDHPNIB(yAxisTransform, yTI, aJGDIGGBFAL2, JPDJKPFNJFC.y, yAxisCharacterController);
			if (enableYClamp && yTI == PPBPHBNOLPB.RotateLocal)
			{
				NADHBMIGHKA(yAxisTransform, yAI, clampYMin, clampYMax, CKEDDDHLBND);
			}
		}
	}

	[SpecialName]
	public void HKHBGLBIBCA(float ICENKPDOHBK)
	{
		touchSize = ICENKPDOHBK;
		if (touchSize > zoneRadius / 692f && restrictArea)
		{
			touchSize = zoneRadius / 691f;
		}
		DKFFHGEMAKM(joyAnchor);
	}

	private void DJPGGPBBJOM()
	{
		if (!Application.isPlaying || !isActivated)
		{
			return;
		}
		if (CFCEALHPHFC == -1 || (JHNFMPMLMPL == Vector2.zero && CFCEALHPHFC > -1))
		{
			if (enableXAutoStab)
			{
				BKPNIKHLGDG(xAxisTransform, xAI, thresholdX, stabSpeedX, POIJFFKKHFD);
			}
			if (enableYAutoStab)
			{
				BKPNIKHLGDG(yAxisTransform, yAI, thresholdY, stabSpeedY, CKEDDDHLBND);
			}
		}
		if (!dynamicJoystick)
		{
			PBBOJAFNGFH = joystickPositionOffset;
		}
		if (CFCEALHPHFC == -1)
		{
			if (!enableSmoothing)
			{
				OCOLOFPLDBM = Vector2.zero;
			}
			else if ((double)OCOLOFPLDBM.sqrMagnitude > 0.0001)
			{
				OCOLOFPLDBM = new Vector2(OCOLOFPLDBM.x - OCOLOFPLDBM.x * smoothing.x * Time.deltaTime, OCOLOFPLDBM.y - OCOLOFPLDBM.y * smoothing.y * Time.deltaTime);
			}
			else
			{
				OCOLOFPLDBM = Vector2.zero;
			}
		}
		Vector2 vector = new Vector2(JHNFMPMLMPL.x, JHNFMPMLMPL.y);
		float num = KFMBNOKBBMK();
		JHNFMPMLMPL = new Vector2(OCOLOFPLDBM.x * num, OCOLOFPLDBM.y * num);
		if (inverseXAxis)
		{
			JHNFMPMLMPL.x *= -1f;
		}
		if (inverseYAxis)
		{
			JHNFMPMLMPL.y *= -1f;
		}
		Vector2 vector2 = new Vector2(speed.x * JHNFMPMLMPL.x, speed.y * JHNFMPMLMPL.y);
		if (enableInertia)
		{
			Vector2 vector3 = vector2 - JPDJKPFNJFC;
			vector3.x /= inertia.x;
			vector3.y /= inertia.y;
			JPDJKPFNJFC += vector3;
		}
		else
		{
			JPDJKPFNJFC = vector2;
		}
		if (vector == Vector2.zero && JHNFMPMLMPL != Vector2.zero && interaction != FGKAAEEPILA.Direct && interaction != FGKAAEEPILA.Include)
		{
			BAAALCMEKBP(CAGDNOCMKGG.On_JoystickMoveStart);
		}
		GIDDBKOINLC();
		if (JHNFMPMLMPL != Vector2.zero)
		{
			FCNPFIEOCGB = false;
			switch (interaction)
			{
			case FGKAAEEPILA.Direct:
				FBPOCLGLLAL();
				break;
			case FGKAAEEPILA.EventNotification:
				BAAALCMEKBP(CAGDNOCMKGG.On_JoystickMove);
				break;
			case FGKAAEEPILA.DirectAndEvent:
				FBPOCLGLLAL();
				BAAALCMEKBP(CAGDNOCMKGG.On_JoystickMove);
				break;
			case FGKAAEEPILA.Include:
				break;
			}
		}
		else if (!FCNPFIEOCGB)
		{
			BAAALCMEKBP(CAGDNOCMKGG.On_JoystickMoveEnd);
			FCNPFIEOCGB = true;
		}
	}

	private void FHBOBAEJJFP(NLKIHCFELMK BMNGEAFPELI)
	{
		if (((BMNGEAFPELI.GFNKEFEIFNA || !dynamicJoystick) && dynamicJoystick) || !isActivated)
		{
			return;
		}
		if (!dynamicJoystick)
		{
			Vector2 vector = new Vector2((IEGKLIGGLLG.x + PBBOJAFNGFH.x) * VirtualScreen.xRatio, (VirtualScreen.height - IEGKLIGGLLG.y - PBBOJAFNGFH.y) * VirtualScreen.yRatio);
			if ((BMNGEAFPELI.CMGMOJAFLFL - vector).sqrMagnitude < zoneRadius * VirtualScreen.xRatio * (zoneRadius * VirtualScreen.xRatio))
			{
				CFCEALHPHFC = BMNGEAFPELI.NKGNNOMNIKO;
				BAAALCMEKBP(CAGDNOCMKGG.On_JoystickTouchStart);
			}
		}
		else
		{
			if (JACHCBBOAGI)
			{
				return;
			}
			switch (area)
			{
			case OBOLKCNLKBD.FullScreen:
				JACHCBBOAGI = true;
				break;
			case OBOLKCNLKBD.Bottom:
				if (BMNGEAFPELI.CMGMOJAFLFL.y < (float)(Screen.height / 2))
				{
					JACHCBBOAGI = true;
				}
				break;
			case OBOLKCNLKBD.Top:
				if (BMNGEAFPELI.CMGMOJAFLFL.y > (float)(Screen.height / 2))
				{
					JACHCBBOAGI = true;
				}
				break;
			case OBOLKCNLKBD.Right:
				if (BMNGEAFPELI.CMGMOJAFLFL.x > (float)(Screen.width / 2))
				{
					JACHCBBOAGI = true;
				}
				break;
			case OBOLKCNLKBD.Left:
				if (BMNGEAFPELI.CMGMOJAFLFL.x < (float)(Screen.width / 2))
				{
					JACHCBBOAGI = true;
				}
				break;
			case OBOLKCNLKBD.TopRight:
				if (BMNGEAFPELI.CMGMOJAFLFL.y > (float)(Screen.height / 2) && BMNGEAFPELI.CMGMOJAFLFL.x > (float)(Screen.width / 2))
				{
					JACHCBBOAGI = true;
				}
				break;
			case OBOLKCNLKBD.TopLeft:
				if (BMNGEAFPELI.CMGMOJAFLFL.y > (float)(Screen.height / 2) && BMNGEAFPELI.CMGMOJAFLFL.x < (float)(Screen.width / 2))
				{
					JACHCBBOAGI = true;
				}
				break;
			case OBOLKCNLKBD.BottomRight:
				if (BMNGEAFPELI.CMGMOJAFLFL.y < (float)(Screen.height / 2) && BMNGEAFPELI.CMGMOJAFLFL.x > (float)(Screen.width / 2))
				{
					JACHCBBOAGI = true;
				}
				break;
			case OBOLKCNLKBD.BottomLeft:
				if (BMNGEAFPELI.CMGMOJAFLFL.y < (float)(Screen.height / 2) && BMNGEAFPELI.CMGMOJAFLFL.x < (float)(Screen.width / 2))
				{
					JACHCBBOAGI = true;
				}
				break;
			}
			if (JACHCBBOAGI)
			{
				PBBOJAFNGFH = new Vector2(BMNGEAFPELI.CMGMOJAFLFL.x / VirtualScreen.xRatio, VirtualScreen.height - BMNGEAFPELI.CMGMOJAFLFL.y / VirtualScreen.yRatio);
				set_JoyAnchor(GJGAAIHMKPP.None);
				CFCEALHPHFC = BMNGEAFPELI.NKGNNOMNIKO;
			}
		}
	}

	private void LKNPJGEGHAC(CAGDNOCMKGG AMOPEEBFAPD)
	{
		OIAKHGNLGJC oIAKHGNLGJC = new OIAKHGNLGJC();
		oIAKHGNLGJC.CEIPKAJDKGK = base.gameObject.name;
		oIAKHGNLGJC.JHNFMPMLMPL = JHNFMPMLMPL;
		oIAKHGNLGJC.JPDJKPFNJFC = JPDJKPFNJFC;
		oIAKHGNLGJC.COLADFPAFPP = this;
		if (!useBroadcast)
		{
			switch (AMOPEEBFAPD)
			{
			case CAGDNOCMKGG.On_JoystickMoveStart:
				if (EasyJoystick.m_HKLAGCKOMEL != null)
				{
					EasyJoystick.m_HKLAGCKOMEL(oIAKHGNLGJC);
				}
				break;
			case CAGDNOCMKGG.On_JoystickMove:
				if (EasyJoystick.m_MLIFCDJLCEB != null)
				{
					EasyJoystick.m_MLIFCDJLCEB(oIAKHGNLGJC);
				}
				break;
			case CAGDNOCMKGG.On_JoystickMoveEnd:
				if (EasyJoystick.m_IMCJMGALMBC != null)
				{
					EasyJoystick.m_IMCJMGALMBC(oIAKHGNLGJC);
				}
				break;
			case CAGDNOCMKGG.On_JoystickTouchStart:
				if (EasyJoystick.m_EPPIABHFCFI != null)
				{
					EasyJoystick.m_EPPIABHFCFI(oIAKHGNLGJC);
				}
				break;
			case CAGDNOCMKGG.On_JoystickTap:
				if (EasyJoystick.m_HKDNJMDPIAD != null)
				{
					EasyJoystick.m_HKDNJMDPIAD(oIAKHGNLGJC);
				}
				break;
			case CAGDNOCMKGG.On_JoystickDoubleTap:
				if (EasyJoystick.m_PPHKCKCJAKP != null)
				{
					EasyJoystick.m_PPHKCKCJAKP(oIAKHGNLGJC);
				}
				break;
			case CAGDNOCMKGG.On_JoystickTouchUp:
				if (EasyJoystick.m_BKOMIBGDDMP != null)
				{
					EasyJoystick.m_BKOMIBGDDMP(oIAKHGNLGJC);
				}
				break;
			}
		}
		else
		{
			if (!useBroadcast)
			{
				return;
			}
			if (receiverGameObject != null)
			{
				switch (messageMode)
				{
				case NBFPGICCJGI.BroadcastMessage:
					receiverGameObject.BroadcastMessage(AMOPEEBFAPD.ToString(), oIAKHGNLGJC, SendMessageOptions.DontRequireReceiver);
					break;
				case NBFPGICCJGI.SendMessage:
					receiverGameObject.SendMessage(AMOPEEBFAPD.ToString(), oIAKHGNLGJC, SendMessageOptions.RequireReceiver);
					break;
				case NBFPGICCJGI.SendMessageUpwards:
					receiverGameObject.SendMessageUpwards(AMOPEEBFAPD.ToString(), oIAKHGNLGJC, SendMessageOptions.DontRequireReceiver);
					break;
				}
			}
			else
			{
				Debug.LogError("설명" + base.gameObject.name + "attack2");
			}
		}
	}

	private float PJAEHCCDAIB(Transform JGFNCGJLLJD, AAKCEIHPOBA BGCBMDCJMBK)
	{
		float num = 406f;
		if (JGFNCGJLLJD != null)
		{
			switch (BGCBMDCJMBK)
			{
			case AAKCEIHPOBA.X:
				num = JGFNCGJLLJD.localRotation.eulerAngles.x;
				break;
			case AAKCEIHPOBA.Y:
				num = JGFNCGJLLJD.localRotation.eulerAngles.y;
				break;
			case AAKCEIHPOBA.Z:
				num = JGFNCGJLLJD.localRotation.eulerAngles.z;
				break;
			}
			if (num <= 136f && num >= 1197f)
			{
				num -= 856f;
			}
		}
		return num;
	}
}
