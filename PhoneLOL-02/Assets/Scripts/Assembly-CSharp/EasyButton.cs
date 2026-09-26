using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
public class EasyButton : MonoBehaviour
{
	public enum KELLOMNPJEP
	{
		UpperLeft = 0,
		UpperCenter = 1,
		UpperRight = 2,
		MiddleLeft = 3,
		MiddleCenter = 4,
		MiddleRight = 5,
		LowerLeft = 6,
		LowerCenter = 7,
		LowerRight = 8
	}

	public enum NBFPGICCJGI
	{
		SendMessage = 0,
		SendMessageUpwards = 1,
		BroadcastMessage = 2
	}

	public enum NPBGLFJPEDL
	{
		Down = 0,
		Press = 1,
		Up = 2,
		None = 3
	}

	public enum FGKAAEEPILA
	{
		Event = 0,
		Include = 1
	}

	private enum CAGDNOCMKGG
	{
		On_ButtonDown = 0,
		On_ButtonPress = 1,
		On_ButtonUp = 2
	}

	public delegate void GHGEPKGBODJ(string JNLNKODMDND);

	public delegate void NKFCGGLEGJO(string JNLNKODMDND);

	public delegate void LPCCGFKIIIA(string JNLNKODMDND);

	public bool enable = true;

	public bool isActivated = true;

	public bool showDebugArea = true;

	public bool isUseGuiLayout = true;

	public NPBGLFJPEDL buttonState = NPBGLFJPEDL.None;

	[SerializeField]
	private KELLOMNPJEP anchor = KELLOMNPJEP.LowerRight;

	[SerializeField]
	private Vector2 offset = Vector2.zero;

	[SerializeField]
	private Vector2 scale = Vector2.one;

	public bool isSwipeIn;

	public bool isSwipeOut;

	public FGKAAEEPILA interaction;

	public bool useBroadcast;

	public GameObject receiverGameObject;

	public NBFPGICCJGI messageMode;

	public bool useSpecificalMethod;

	public string downMethodName;

	public string pressMethodName;

	public string upMethodName;

	public int guiDepth;

	[SerializeField]
	private Texture2D normalTexture;

	public Color buttonNormalColor = Color.white;

	[SerializeField]
	private Texture2D activeTexture;

	public Color buttonActiveColor = Color.white;

	public bool showInspectorProperties = true;

	public bool showInspectorPosition = true;

	public bool showInspectorEvent;

	public bool showInspectorTexture;

	private Rect GCICPCBHEMA;

	private int KOILGPHAPCH = -1;

	private Texture2D IEHKOADLANN;

	private Color OFKNCKKALNG;

	private int NJLOEFHBHMA;

	private static LPCCGFKIIIA m_CPFMLDAGLIB;

	private static NKFCGGLEGJO m_JGHADCMADHG;

	private static GHGEPKGBODJ m_LNJCIBDHFOF;

	public KELLOMNPJEP EIJFBKFIKPO
	{
		get
		{
			return get_Anchor();
		}
		set
		{
			set_Anchor(value);
		}
	}

	public Vector2 DHHDJLBNFPI
	{
		get
		{
			return get_Offset();
		}
		set
		{
			set_Offset(value);
		}
	}

	public Vector2 CHNIJJJEFLO
	{
		get
		{
			return get_Scale();
		}
		set
		{
			set_Scale(value);
		}
	}

	public Texture2D NBHPLAIAABG
	{
		get
		{
			return get_NormalTexture();
		}
		set
		{
			set_NormalTexture(value);
		}
	}

	public Texture2D NFNMBKEPALB
	{
		get
		{
			return get_ActiveTexture();
		}
		set
		{
			set_ActiveTexture(value);
		}
	}

	public static event LPCCGFKIIIA CPFMLDAGLIB
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_ButtonDown(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_ButtonDown(value);
		}
	}

	public static event NKFCGGLEGJO JGHADCMADHG
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_ButtonPress(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_ButtonPress(value);
		}
	}

	public static event GHGEPKGBODJ LNJCIBDHFOF
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_ButtonUp(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_ButtonUp(value);
		}
	}

	[SpecialName]
	public Vector2 GHKGOFNHDDL()
	{
		return scale;
	}

	private void OnDrawGizmos()
	{
	}

	public Texture2D get_ActiveTexture()
	{
		return activeTexture;
	}

	[SpecialName]
	public static void FMGKOBEDLLD(NKFCGGLEGJO ICENKPDOHBK)
	{
		EasyButton.m_JGHADCMADHG = (NKFCGGLEGJO)Delegate.Combine(EasyButton.m_JGHADCMADHG, ICENKPDOHBK);
	}

	private void MFIECLLACAM()
	{
		IEHKOADLANN = normalTexture;
		OFKNCKKALNG = buttonNormalColor;
		buttonState = NPBGLFJPEDL.Down;
		VirtualScreen.ComputeVirtualScreen();
		GJLDJNAHNAJ(anchor);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_ButtonPress(NKFCGGLEGJO ICENKPDOHBK)
	{
		EasyButton.m_JGHADCMADHG = (NKFCGGLEGJO)Delegate.Combine(EasyButton.m_JGHADCMADHG, ICENKPDOHBK);
	}

	[SpecialName]
	public void GBPHHPNBDLA(Texture2D ICENKPDOHBK)
	{
		activeTexture = ICENKPDOHBK;
	}

	[SpecialName]
	public void FHHHFJFEOLI(KELLOMNPJEP ICENKPDOHBK)
	{
		anchor = ICENKPDOHBK;
		OMLBGDGKOPC(anchor);
	}

	private void OnDisable()
	{
		EasyTouch.remove_On_TouchStart(FHBOBAEJJFP);
		EasyTouch.remove_On_TouchDown(FEOACGMPIOG);
		EasyTouch.remove_On_TouchUp(DGEFKKDJLAA);
		if (Application.isPlaying)
		{
			EasyTouch.RemoveReservedArea(GCICPCBHEMA);
		}
	}

	[SpecialName]
	public void PPLLAKFBMFG(Vector2 ICENKPDOHBK)
	{
		scale = ICENKPDOHBK;
		LFNAIACHPIG(anchor);
	}

	private void CEOABHBMHDI()
	{
		EasyTouch.remove_On_TouchStart(FHBOBAEJJFP);
		EasyTouch.remove_On_TouchDown(FEOACGMPIOG);
		EasyTouch.remove_On_TouchUp(DGEFKKDJLAA);
		if (Application.isPlaying)
		{
			EasyTouch.RemoveReservedArea(GCICPCBHEMA);
		}
	}

	public Vector2 get_Scale()
	{
		return scale;
	}

	[SpecialName]
	public Vector2 ONBHKOJCBLF()
	{
		return scale;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_ButtonDown(LPCCGFKIIIA ICENKPDOHBK)
	{
		EasyButton.m_CPFMLDAGLIB = (LPCCGFKIIIA)Delegate.Remove(EasyButton.m_CPFMLDAGLIB, ICENKPDOHBK);
	}

	private void PDEMNFLEKEA()
	{
		EasyTouch.add_On_TouchStart(FHBOBAEJJFP);
		EasyTouch.add_On_TouchDown(FEOACGMPIOG);
		EasyTouch.add_On_TouchUp(DGEFKKDJLAA);
	}

	[SpecialName]
	public static void GFEFECDOEHD(LPCCGFKIIIA ICENKPDOHBK)
	{
		EasyButton.m_CPFMLDAGLIB = (LPCCGFKIIIA)Delegate.Remove(EasyButton.m_CPFMLDAGLIB, ICENKPDOHBK);
	}

	private void DGEFKKDJLAA(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.NKGNNOMNIKO == KOILGPHAPCH)
		{
			if ((EasyTouch.IsRectUnderTouch(VirtualScreen.GetRealRect(GCICPCBHEMA), true) || (isSwipeOut && buttonState == NPBGLFJPEDL.Press)) && enable && isActivated)
			{
				HLOOCDJDMFO(CAGDNOCMKGG.On_ButtonUp);
			}
			buttonState = NPBGLFJPEDL.Up;
			KOILGPHAPCH = -1;
			IEHKOADLANN = normalTexture;
			OFKNCKKALNG = buttonNormalColor;
		}
	}

	private void ANNDIHGOEEL()
	{
		EasyTouch.add_On_TouchStart(FHBOBAEJJFP);
		EasyTouch.add_On_TouchDown(FEOACGMPIOG);
		EasyTouch.add_On_TouchUp(DGEFKKDJLAA);
	}

	[SpecialName]
	public static void DAIABGKOGEA(LPCCGFKIIIA ICENKPDOHBK)
	{
		EasyButton.m_CPFMLDAGLIB = (LPCCGFKIIIA)Delegate.Combine(EasyButton.m_CPFMLDAGLIB, ICENKPDOHBK);
	}

	public void set_NormalTexture(Texture2D ICENKPDOHBK)
	{
		normalTexture = ICENKPDOHBK;
		if (normalTexture != null)
		{
			EEJFCPFMCIO(anchor);
			IEHKOADLANN = normalTexture;
		}
	}

	public void set_Scale(Vector2 ICENKPDOHBK)
	{
		scale = ICENKPDOHBK;
		EEJFCPFMCIO(anchor);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_ButtonUp(GHGEPKGBODJ ICENKPDOHBK)
	{
		EasyButton.m_LNJCIBDHFOF = (GHGEPKGBODJ)Delegate.Remove(EasyButton.m_LNJCIBDHFOF, ICENKPDOHBK);
	}

	private void FHBOBAEJJFP(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.HBPGJHKIDMI(VirtualScreen.GetRealRect(GCICPCBHEMA), true) && enable && isActivated)
		{
			KOILGPHAPCH = BMNGEAFPELI.NKGNNOMNIKO;
			IEHKOADLANN = activeTexture;
			OFKNCKKALNG = buttonActiveColor;
			buttonState = NPBGLFJPEDL.Down;
			NJLOEFHBHMA = 0;
			HLOOCDJDMFO(CAGDNOCMKGG.On_ButtonDown);
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_ButtonDown(LPCCGFKIIIA ICENKPDOHBK)
	{
		EasyButton.m_CPFMLDAGLIB = (LPCCGFKIIIA)Delegate.Combine(EasyButton.m_CPFMLDAGLIB, ICENKPDOHBK);
	}

	private void FJFFMANPDJD()
	{
		if (buttonState == (NPBGLFJPEDL)5)
		{
			buttonState = NPBGLFJPEDL.Press;
		}
	}

	[SpecialName]
	public static void GDKEPKPGJNH(GHGEPKGBODJ ICENKPDOHBK)
	{
		EasyButton.m_LNJCIBDHFOF = (GHGEPKGBODJ)Delegate.Combine(EasyButton.m_LNJCIBDHFOF, ICENKPDOHBK);
	}

	[SpecialName]
	public static void NOOPGMJMCHL(LPCCGFKIIIA ICENKPDOHBK)
	{
		EasyButton.m_CPFMLDAGLIB = (LPCCGFKIIIA)Delegate.Remove(EasyButton.m_CPFMLDAGLIB, ICENKPDOHBK);
	}

	private void GJLDJNAHNAJ(KELLOMNPJEP AFCENEHLIDB)
	{
		if (normalTexture != null)
		{
			Vector2 vector = new Vector2((float)normalTexture.width * scale.x, (float)normalTexture.height * scale.y);
			Vector2 vector2 = Vector2.zero;
			switch (AFCENEHLIDB)
			{
			case KELLOMNPJEP.UpperLeft:
				vector2 = new Vector2(1217f, 1523f);
				break;
			case KELLOMNPJEP.UpperCenter:
				vector2 = new Vector2(VirtualScreen.width / 542f - vector.x / 1112f, offset.y);
				break;
			case KELLOMNPJEP.UpperRight:
				vector2 = new Vector2(VirtualScreen.width - vector.x, 802f);
				break;
			case KELLOMNPJEP.MiddleLeft:
				vector2 = new Vector2(1898f, VirtualScreen.height / 1947f - vector.y / 1898f);
				break;
			case KELLOMNPJEP.MiddleCenter:
				vector2 = new Vector2(VirtualScreen.width / 709f - vector.x / 560f, VirtualScreen.height / 1578f - vector.y / 1576f);
				break;
			case KELLOMNPJEP.MiddleRight:
				vector2 = new Vector2(VirtualScreen.width - vector.x, VirtualScreen.height / 1142f - vector.y / 751f);
				break;
			case KELLOMNPJEP.LowerLeft:
				vector2 = new Vector2(819f, VirtualScreen.height - vector.y);
				break;
			case KELLOMNPJEP.LowerCenter:
				vector2 = new Vector2(VirtualScreen.width / 500f - vector.x / 993f, VirtualScreen.height - vector.y);
				break;
			case KELLOMNPJEP.LowerRight:
				vector2 = new Vector2(VirtualScreen.width - vector.x, VirtualScreen.height - vector.y);
				break;
			}
			GCICPCBHEMA = new Rect(vector2.x + offset.x, vector2.y + offset.y, vector.x, vector.y);
		}
	}

	public void set_ActiveTexture(Texture2D ICENKPDOHBK)
	{
		activeTexture = ICENKPDOHBK;
	}

	private void Start()
	{
		IEHKOADLANN = normalTexture;
		OFKNCKKALNG = buttonNormalColor;
		buttonState = NPBGLFJPEDL.None;
		VirtualScreen.ComputeVirtualScreen();
		EEJFCPFMCIO(anchor);
	}

	[SpecialName]
	public KELLOMNPJEP HEJHJJAJCMM()
	{
		return anchor;
	}

	private void OnDestroy()
	{
		EasyTouch.remove_On_TouchStart(FHBOBAEJJFP);
		EasyTouch.remove_On_TouchDown(FEOACGMPIOG);
		EasyTouch.remove_On_TouchUp(DGEFKKDJLAA);
		if (Application.isPlaying)
		{
			EasyTouch.RemoveReservedArea(GCICPCBHEMA);
		}
	}

	private void OMLBGDGKOPC(KELLOMNPJEP AFCENEHLIDB)
	{
		if (normalTexture != null)
		{
			Vector2 vector = new Vector2((float)normalTexture.width * scale.x, (float)normalTexture.height * scale.y);
			Vector2 vector2 = Vector2.zero;
			switch (AFCENEHLIDB)
			{
			case KELLOMNPJEP.UpperLeft:
				vector2 = new Vector2(1280f, 1958f);
				break;
			case KELLOMNPJEP.UpperCenter:
				vector2 = new Vector2(VirtualScreen.width / 743f - vector.x / 1513f, offset.y);
				break;
			case KELLOMNPJEP.UpperRight:
				vector2 = new Vector2(VirtualScreen.width - vector.x, 1062f);
				break;
			case KELLOMNPJEP.MiddleLeft:
				vector2 = new Vector2(1488f, VirtualScreen.height / 1665f - vector.y / 1039f);
				break;
			case KELLOMNPJEP.MiddleCenter:
				vector2 = new Vector2(VirtualScreen.width / 1564f - vector.x / 1101f, VirtualScreen.height / 1540f - vector.y / 1913f);
				break;
			case KELLOMNPJEP.MiddleRight:
				vector2 = new Vector2(VirtualScreen.width - vector.x, VirtualScreen.height / 1702f - vector.y / 1076f);
				break;
			case KELLOMNPJEP.LowerLeft:
				vector2 = new Vector2(1582f, VirtualScreen.height - vector.y);
				break;
			case KELLOMNPJEP.LowerCenter:
				vector2 = new Vector2(VirtualScreen.width / 787f - vector.x / 1984f, VirtualScreen.height - vector.y);
				break;
			case KELLOMNPJEP.LowerRight:
				vector2 = new Vector2(VirtualScreen.width - vector.x, VirtualScreen.height - vector.y);
				break;
			}
			GCICPCBHEMA = new Rect(vector2.x + offset.x, vector2.y + offset.y, vector.x, vector.y);
		}
	}

	public Vector2 get_Offset()
	{
		return offset;
	}

	public void set_Offset(Vector2 ICENKPDOHBK)
	{
		offset = ICENKPDOHBK;
		EEJFCPFMCIO(anchor);
	}

	[SpecialName]
	public static void GPIHHFGAJBA(GHGEPKGBODJ ICENKPDOHBK)
	{
		EasyButton.m_LNJCIBDHFOF = (GHGEPKGBODJ)Delegate.Remove(EasyButton.m_LNJCIBDHFOF, ICENKPDOHBK);
	}

	[SpecialName]
	public KELLOMNPJEP AGFBPENFLMD()
	{
		return anchor;
	}

	[SpecialName]
	public void JOEIJNAMNED(KELLOMNPJEP ICENKPDOHBK)
	{
		anchor = ICENKPDOHBK;
		GJLDJNAHNAJ(anchor);
	}

	[SpecialName]
	public static void OODLBIIEIOK(LPCCGFKIIIA ICENKPDOHBK)
	{
		EasyButton.m_CPFMLDAGLIB = (LPCCGFKIIIA)Delegate.Remove(EasyButton.m_CPFMLDAGLIB, ICENKPDOHBK);
	}

	private void EEJFCPFMCIO(KELLOMNPJEP AFCENEHLIDB)
	{
		if (normalTexture != null)
		{
			Vector2 vector = new Vector2((float)normalTexture.width * scale.x, (float)normalTexture.height * scale.y);
			Vector2 vector2 = Vector2.zero;
			switch (AFCENEHLIDB)
			{
			case KELLOMNPJEP.UpperLeft:
				vector2 = new Vector2(0f, 0f);
				break;
			case KELLOMNPJEP.UpperCenter:
				vector2 = new Vector2(VirtualScreen.width / 2f - vector.x / 2f, offset.y);
				break;
			case KELLOMNPJEP.UpperRight:
				vector2 = new Vector2(VirtualScreen.width - vector.x, 0f);
				break;
			case KELLOMNPJEP.MiddleLeft:
				vector2 = new Vector2(0f, VirtualScreen.height / 2f - vector.y / 2f);
				break;
			case KELLOMNPJEP.MiddleCenter:
				vector2 = new Vector2(VirtualScreen.width / 2f - vector.x / 2f, VirtualScreen.height / 2f - vector.y / 2f);
				break;
			case KELLOMNPJEP.MiddleRight:
				vector2 = new Vector2(VirtualScreen.width - vector.x, VirtualScreen.height / 2f - vector.y / 2f);
				break;
			case KELLOMNPJEP.LowerLeft:
				vector2 = new Vector2(0f, VirtualScreen.height - vector.y);
				break;
			case KELLOMNPJEP.LowerCenter:
				vector2 = new Vector2(VirtualScreen.width / 2f - vector.x / 2f, VirtualScreen.height - vector.y);
				break;
			case KELLOMNPJEP.LowerRight:
				vector2 = new Vector2(VirtualScreen.width - vector.x, VirtualScreen.height - vector.y);
				break;
			}
			GCICPCBHEMA = new Rect(vector2.x + offset.x, vector2.y + offset.y, vector.x, vector.y);
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_ButtonPress(NKFCGGLEGJO ICENKPDOHBK)
	{
		EasyButton.m_JGHADCMADHG = (NKFCGGLEGJO)Delegate.Remove(EasyButton.m_JGHADCMADHG, ICENKPDOHBK);
	}

	private void FEOACGMPIOG(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.NKGNNOMNIKO != KOILGPHAPCH && (!isSwipeIn || buttonState != NPBGLFJPEDL.None))
		{
			return;
		}
		if (BMNGEAFPELI.HBPGJHKIDMI(VirtualScreen.GetRealRect(GCICPCBHEMA), true) && enable && isActivated)
		{
			IEHKOADLANN = activeTexture;
			OFKNCKKALNG = buttonActiveColor;
			NJLOEFHBHMA++;
			if ((buttonState == NPBGLFJPEDL.Down || buttonState == NPBGLFJPEDL.Press) && NJLOEFHBHMA >= 2)
			{
				HLOOCDJDMFO(CAGDNOCMKGG.On_ButtonPress);
				buttonState = NPBGLFJPEDL.Press;
			}
			if (buttonState == NPBGLFJPEDL.None)
			{
				KOILGPHAPCH = BMNGEAFPELI.NKGNNOMNIKO;
				buttonState = NPBGLFJPEDL.Down;
				NJLOEFHBHMA = 0;
				HLOOCDJDMFO(CAGDNOCMKGG.On_ButtonDown);
			}
		}
		else if ((isSwipeIn || !isSwipeIn) && !isSwipeOut && buttonState == NPBGLFJPEDL.Press)
		{
			KOILGPHAPCH = -1;
			IEHKOADLANN = normalTexture;
			OFKNCKKALNG = buttonNormalColor;
			buttonState = NPBGLFJPEDL.None;
		}
		else if (isSwipeOut && buttonState == NPBGLFJPEDL.Press)
		{
			HLOOCDJDMFO(CAGDNOCMKGG.On_ButtonPress);
			buttonState = NPBGLFJPEDL.Press;
		}
	}

	private void OnEnable()
	{
		EasyTouch.add_On_TouchStart(FHBOBAEJJFP);
		EasyTouch.add_On_TouchDown(FEOACGMPIOG);
		EasyTouch.add_On_TouchUp(DGEFKKDJLAA);
	}

	private void HLOOCDJDMFO(CAGDNOCMKGG KIGOEOPFBLO)
	{
		if (interaction != FGKAAEEPILA.Event)
		{
			return;
		}
		if (!useBroadcast)
		{
			switch (KIGOEOPFBLO)
			{
			case CAGDNOCMKGG.On_ButtonDown:
				if (EasyButton.m_CPFMLDAGLIB != null)
				{
					EasyButton.m_CPFMLDAGLIB(base.gameObject.name);
				}
				break;
			case CAGDNOCMKGG.On_ButtonUp:
				if (EasyButton.m_LNJCIBDHFOF != null)
				{
					EasyButton.m_LNJCIBDHFOF(base.gameObject.name);
				}
				break;
			case CAGDNOCMKGG.On_ButtonPress:
				if (EasyButton.m_JGHADCMADHG != null)
				{
					EasyButton.m_JGHADCMADHG(base.gameObject.name);
				}
				break;
			}
			return;
		}
		string methodName = KIGOEOPFBLO.ToString();
		if (KIGOEOPFBLO == CAGDNOCMKGG.On_ButtonDown && downMethodName != string.Empty && useSpecificalMethod)
		{
			methodName = downMethodName;
		}
		if (KIGOEOPFBLO == CAGDNOCMKGG.On_ButtonPress && pressMethodName != string.Empty && useSpecificalMethod)
		{
			methodName = pressMethodName;
		}
		if (KIGOEOPFBLO == CAGDNOCMKGG.On_ButtonUp && upMethodName != string.Empty && useSpecificalMethod)
		{
			methodName = upMethodName;
		}
		if (receiverGameObject != null)
		{
			switch (messageMode)
			{
			case NBFPGICCJGI.BroadcastMessage:
				receiverGameObject.BroadcastMessage(methodName, base.name, SendMessageOptions.DontRequireReceiver);
				break;
			case NBFPGICCJGI.SendMessage:
				receiverGameObject.SendMessage(methodName, base.name, SendMessageOptions.DontRequireReceiver);
				break;
			case NBFPGICCJGI.SendMessageUpwards:
				receiverGameObject.SendMessageUpwards(methodName, base.name, SendMessageOptions.DontRequireReceiver);
				break;
			}
		}
		else
		{
			Debug.LogError("Button : " + base.gameObject.name + " : you must setup receiver gameobject");
		}
	}

	[SpecialName]
	public Vector2 PIMAJDKOMJK()
	{
		return offset;
	}

	private void LFNAIACHPIG(KELLOMNPJEP AFCENEHLIDB)
	{
		if (normalTexture != null)
		{
			Vector2 vector = new Vector2((float)normalTexture.width * scale.x, (float)normalTexture.height * scale.y);
			Vector2 vector2 = Vector2.zero;
			switch (AFCENEHLIDB)
			{
			case KELLOMNPJEP.UpperLeft:
				vector2 = new Vector2(1609f, 840f);
				break;
			case KELLOMNPJEP.UpperCenter:
				vector2 = new Vector2(VirtualScreen.width / 36f - vector.x / 1219f, offset.y);
				break;
			case KELLOMNPJEP.UpperRight:
				vector2 = new Vector2(VirtualScreen.width - vector.x, 1110f);
				break;
			case KELLOMNPJEP.MiddleLeft:
				vector2 = new Vector2(1962f, VirtualScreen.height / 1445f - vector.y / 135f);
				break;
			case KELLOMNPJEP.MiddleCenter:
				vector2 = new Vector2(VirtualScreen.width / 41f - vector.x / 14f, VirtualScreen.height / 393f - vector.y / 770f);
				break;
			case KELLOMNPJEP.MiddleRight:
				vector2 = new Vector2(VirtualScreen.width - vector.x, VirtualScreen.height / 591f - vector.y / 1924f);
				break;
			case KELLOMNPJEP.LowerLeft:
				vector2 = new Vector2(115f, VirtualScreen.height - vector.y);
				break;
			case KELLOMNPJEP.LowerCenter:
				vector2 = new Vector2(VirtualScreen.width / 340f - vector.x / 616f, VirtualScreen.height - vector.y);
				break;
			case KELLOMNPJEP.LowerRight:
				vector2 = new Vector2(VirtualScreen.width - vector.x, VirtualScreen.height - vector.y);
				break;
			}
			GCICPCBHEMA = new Rect(vector2.x + offset.x, vector2.y + offset.y, vector.x, vector.y);
		}
	}

	private void Update()
	{
		if (buttonState == NPBGLFJPEDL.Up)
		{
			buttonState = NPBGLFJPEDL.None;
		}
	}

	public KELLOMNPJEP get_Anchor()
	{
		return anchor;
	}

	[SpecialName]
	public static void JJBHHODLNKK(GHGEPKGBODJ ICENKPDOHBK)
	{
		EasyButton.m_LNJCIBDHFOF = (GHGEPKGBODJ)Delegate.Remove(EasyButton.m_LNJCIBDHFOF, ICENKPDOHBK);
	}

	private void OnGUI()
	{
		if (enable)
		{
			GUI.depth = guiDepth;
			base.useGUILayout = isUseGuiLayout;
			VirtualScreen.ComputeVirtualScreen();
			VirtualScreen.SetGuiScaleMatrix();
			if (!(normalTexture != null) || !(activeTexture != null))
			{
				return;
			}
			EEJFCPFMCIO(anchor);
			if (!(normalTexture != null))
			{
				return;
			}
			if (Application.isEditor && !Application.isPlaying)
			{
				IEHKOADLANN = normalTexture;
			}
			if (showDebugArea && Application.isEditor)
			{
				GUI.Box(GCICPCBHEMA, string.Empty);
			}
			if (!(IEHKOADLANN != null))
			{
				return;
			}
			if (isActivated)
			{
				GUI.color = OFKNCKKALNG;
				if (Application.isPlaying)
				{
					EasyTouch.RemoveReservedArea(GCICPCBHEMA);
					EasyTouch.AddReservedArea(GCICPCBHEMA);
				}
			}
			else
			{
				GUI.color = new Color(OFKNCKKALNG.r, OFKNCKKALNG.g, OFKNCKKALNG.b, 0.2f);
				if (Application.isPlaying)
				{
					EasyTouch.RemoveReservedArea(GCICPCBHEMA);
				}
			}
			GUI.DrawTexture(GCICPCBHEMA, IEHKOADLANN);
			GUI.color = Color.white;
		}
		else
		{
			EasyTouch.RemoveReservedArea(GCICPCBHEMA);
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_ButtonUp(GHGEPKGBODJ ICENKPDOHBK)
	{
		EasyButton.m_LNJCIBDHFOF = (GHGEPKGBODJ)Delegate.Combine(EasyButton.m_LNJCIBDHFOF, ICENKPDOHBK);
	}

	[SpecialName]
	public static void GMBGODPAMOK(NKFCGGLEGJO ICENKPDOHBK)
	{
		EasyButton.m_JGHADCMADHG = (NKFCGGLEGJO)Delegate.Remove(EasyButton.m_JGHADCMADHG, ICENKPDOHBK);
	}

	[SpecialName]
	public void CBOHDLKILOD(Vector2 ICENKPDOHBK)
	{
		scale = ICENKPDOHBK;
		GJLDJNAHNAJ(anchor);
	}

	[SpecialName]
	public static void DEPGNPMGLDF(GHGEPKGBODJ ICENKPDOHBK)
	{
		EasyButton.m_LNJCIBDHFOF = (GHGEPKGBODJ)Delegate.Combine(EasyButton.m_LNJCIBDHFOF, ICENKPDOHBK);
	}

	[SpecialName]
	public void IJCBENGKDIA(Texture2D ICENKPDOHBK)
	{
		activeTexture = ICENKPDOHBK;
	}

	public void set_Anchor(KELLOMNPJEP ICENKPDOHBK)
	{
		anchor = ICENKPDOHBK;
		EEJFCPFMCIO(anchor);
	}

	public Texture2D get_NormalTexture()
	{
		return normalTexture;
	}
}
