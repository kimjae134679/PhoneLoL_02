using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EasyTouch : MonoBehaviour
{
	public enum ANGFCINKJKK
	{
		Tap = 0,
		Drag = 1,
		Swipe = 2,
		None = 3,
		LongTap = 4,
		Pinch = 5,
		Twist = 6,
		Cancel = 7,
		Acquisition = 8
	}

	public enum AGEGIBIJEOB
	{
		None = 0,
		Left = 1,
		Right = 2,
		Up = 3,
		Down = 4,
		Other = 5
	}

	private enum ENHMGALIDNH
	{
		None = 0,
		On_Cancel = 1,
		On_Cancel2Fingers = 2,
		On_TouchStart = 3,
		On_TouchDown = 4,
		On_TouchUp = 5,
		On_SimpleTap = 6,
		On_DoubleTap = 7,
		On_LongTapStart = 8,
		On_LongTap = 9,
		On_LongTapEnd = 10,
		On_DragStart = 11,
		On_Drag = 12,
		On_DragEnd = 13,
		On_SwipeStart = 14,
		On_Swipe = 15,
		On_SwipeEnd = 16,
		On_TouchStart2Fingers = 17,
		On_TouchDown2Fingers = 18,
		On_TouchUp2Fingers = 19,
		On_SimpleTap2Fingers = 20,
		On_DoubleTap2Fingers = 21,
		On_LongTapStart2Fingers = 22,
		On_LongTap2Fingers = 23,
		On_LongTapEnd2Fingers = 24,
		On_Twist = 25,
		On_TwistEnd = 26,
		On_PinchIn = 27,
		On_PinchOut = 28,
		On_PinchEnd = 29,
		On_DragStart2Fingers = 30,
		On_Drag2Fingers = 31,
		On_DragEnd2Fingers = 32,
		On_SwipeStart2Fingers = 33,
		On_Swipe2Fingers = 34,
		On_SwipeEnd2Fingers = 35
	}

	public delegate void LBBNLDGGNIB(NLKIHCFELMK BMNGEAFPELI);

	public delegate void AFNLHEHAJFE(NLKIHCFELMK BMNGEAFPELI);

	public delegate void OKGKIGCPDJH(NLKIHCFELMK BMNGEAFPELI);

	public delegate void NMENLGCLDKB(NLKIHCFELMK BMNGEAFPELI);

	public delegate void EFLKHCLGDPF(NLKIHCFELMK BMNGEAFPELI);

	public delegate void IBFFAOEHFHF(NLKIHCFELMK BMNGEAFPELI);

	public delegate void IBKJGPKACOO(NLKIHCFELMK BMNGEAFPELI);

	public delegate void JMJHJKBHKGH(NLKIHCFELMK BMNGEAFPELI);

	public delegate void NPEHMMDOMHF(NLKIHCFELMK BMNGEAFPELI);

	public delegate void DGEBLAAEJIH(NLKIHCFELMK BMNGEAFPELI);

	public delegate void GNNNGJGHIPJ(NLKIHCFELMK BMNGEAFPELI);

	public delegate void HLHOPCNBCMM(NLKIHCFELMK BMNGEAFPELI);

	public delegate void LEFJKFOPOAG(NLKIHCFELMK BMNGEAFPELI);

	public delegate void BIJKNLFNDOM(NLKIHCFELMK BMNGEAFPELI);

	public delegate void EDHLGKJEOCJ(NLKIHCFELMK BMNGEAFPELI);

	public delegate void BODJDOPJAGI(NLKIHCFELMK BMNGEAFPELI);

	public delegate void DPNDKKBILNP(NLKIHCFELMK BMNGEAFPELI);

	public delegate void LJPHGFOBFBD(NLKIHCFELMK BMNGEAFPELI);

	public delegate void JILPOOIIELM(NLKIHCFELMK BMNGEAFPELI);

	public delegate void MGGOPHOOEJO(NLKIHCFELMK BMNGEAFPELI);

	public delegate void DCHFDJEFKDP(NLKIHCFELMK BMNGEAFPELI);

	public delegate void IKDCGCMIJDF(NLKIHCFELMK BMNGEAFPELI);

	public delegate void JKAGCEOLDMF(NLKIHCFELMK BMNGEAFPELI);

	public delegate void EPJLIGMFBCN(NLKIHCFELMK BMNGEAFPELI);

	public delegate void DOAJPLHANBH(NLKIHCFELMK BMNGEAFPELI);

	public delegate void BGFLNJPKPOP(NLKIHCFELMK BMNGEAFPELI);

	public delegate void DLMHEJNJGHF(NLKIHCFELMK BMNGEAFPELI);

	public delegate void BGJJGNAHJIL(NLKIHCFELMK BMNGEAFPELI);

	public delegate void BMHDECJKIMK(NLKIHCFELMK BMNGEAFPELI);

	public delegate void DBEGNAOAHGC(NLKIHCFELMK BMNGEAFPELI);

	public delegate void ICPACHDFBPG(NLKIHCFELMK BMNGEAFPELI);

	public delegate void FGNOPNHNCEK(NLKIHCFELMK BMNGEAFPELI);

	public delegate void JGDFHDDCEHO(NLKIHCFELMK BMNGEAFPELI);

	public delegate void KHEMMAEPJJB(NLKIHCFELMK BMNGEAFPELI);

	public delegate void OJADGCJCPPJ(NLKIHCFELMK BMNGEAFPELI);

	public bool enable = true;

	public bool enableRemote;

	public bool useBroadcastMessage = true;

	public GameObject receiverObject;

	public bool isExtension;

	public bool enable2FingersGesture = true;

	public bool enableTwist = true;

	public bool enablePinch = true;

	public Camera easyTouchCamera;

	public bool autoSelect;

	public LayerMask pickableLayers;

	public float StationnaryTolerance = 25f;

	public float longTapTime = 1f;

	public float swipeTolerance = 0.85f;

	public float minPinchLength;

	public float minTwistAngle = 1f;

	public bool enabledNGuiMode;

	public LayerMask nGUILayers;

	public List<Camera> nGUICameras = new List<Camera>();

	private bool CELEADGHAHA;

	public List<Rect> reservedAreas = new List<Rect>();

	public bool enableReservedArea = true;

	public KeyCode twistKey = KeyCode.LeftAlt;

	public KeyCode swipeKey = KeyCode.LeftControl;

	public bool showGeneral = true;

	public bool showSelect = true;

	public bool showGesture = true;

	public bool showTwoFinger = true;

	public bool showSecondFinger = true;

	public static EasyTouch instance;

	private PLMFGMBFIAN ECGCNJMBCGE;

	private ANGFCINKJKK DJPLIMLLFFO = ANGFCINKJKK.None;

	private ANGFCINKJKK IMLJFPAMLBH = ANGFCINKJKK.None;

	private float GNLIGBBILPG;

	private PLICNHAMCPB[] PLOLGPDJALM = new PLICNHAMCPB[10];

	private PLICNHAMCPB[] DDAECCGKOBM = new PLICNHAMCPB[10];

	private GameObject MLONCPAOCCP;

	private GameObject ALCDBNDHBMG;

	public Texture secondFingerTexture;

	private Vector2 IDIMOENGDAB;

	private int MMGHDHKBPAL;

	private int FGBLDNAOEPN;

	private Vector2 FAJJPOCEFBK;

	private float DHJKIEGOCLH;

	private bool DIEMDCBFHDC;

	private bool PIKLMCJOIKH;

	private int PEFPPBKIKEI;

	private static LBBNLDGGNIB m_IFHDJPNBDJF;

	private static AFNLHEHAJFE m_CNECHHONONJ;

	private static OKGKIGCPDJH m_FHBOBAEJJFP;

	private static NMENLGCLDKB m_FEOACGMPIOG;

	private static EFLKHCLGDPF m_DGEFKKDJLAA;

	private static IBFFAOEHFHF m_KPMBACFCALN;

	private static IBKJGPKACOO m_CNALFPOJBIK;

	private static JMJHJKBHKGH m_FNOKPPHHPMM;

	private static NPEHMMDOMHF m_EFGICDIIKAM;

	private static DGEBLAAEJIH m_FLKIAEMGMGC;

	private static GNNNGJGHIPJ m_KGOCCEIIBFE;

	private static HLHOPCNBCMM m_KAFHFMGMJBB;

	private static LEFJKFOPOAG m_OBIHHMAPMHB;

	private static BIJKNLFNDOM m_NNKJJEOADNH;

	private static EDHLGKJEOCJ m_BFJPAIGMIFK;

	private static BODJDOPJAGI m_FCOOCIECLGH;

	private static DPNDKKBILNP m_AFOFMEOAPGI;

	private static LJPHGFOBFBD m_LIDNACGDMBJ;

	private static JILPOOIIELM m_KOHHHLFLMPO;

	private static MGGOPHOOEJO m_GPDOHJDELBC;

	private static DCHFDJEFKDP m_ONJCBIJOMPK;

	private static IKDCGCMIJDF m_PMPDDOODAOA;

	private static JKAGCEOLDMF m_ENIOAKLEPLE;

	private static EPJLIGMFBCN m_MCEENHCMNHK;

	private static DOAJPLHANBH m_PMLCMKBEGOG;

	private static BGFLNJPKPOP m_IMAKAFNDAFI;

	private static DLMHEJNJGHF m_JCKDDDPAGFN;

	private static BGJJGNAHJIL m_LKIMMJPPBBH;

	private static BMHDECJKIMK m_GNOJBMEKGLH;

	private static DBEGNAOAHGC m_HLENDKFOBNM;

	private static ICPACHDFBPG m_AOOLDEJNMCG;

	private static FGNOPNHNCEK m_GDPGENHMHKO;

	private static JGDFHDDCEHO m_GOIGCNAENKC;

	private static KHEMMAEPJJB m_AFNBBNNEDPC;

	private static OJADGCJCPPJ m_FNMKLMLAAMI;

	public static event LBBNLDGGNIB IFHDJPNBDJF
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_Cancel(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_Cancel(value);
		}
	}

	public static event AFNLHEHAJFE CNECHHONONJ
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_Cancel2Fingers(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_Cancel2Fingers(value);
		}
	}

	public static event OKGKIGCPDJH FHBOBAEJJFP
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_TouchStart(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_TouchStart(value);
		}
	}

	public static event NMENLGCLDKB FEOACGMPIOG
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_TouchDown(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_TouchDown(value);
		}
	}

	public static event EFLKHCLGDPF DGEFKKDJLAA
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_TouchUp(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_TouchUp(value);
		}
	}

	public static event IBFFAOEHFHF KPMBACFCALN
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_SimpleTap(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_SimpleTap(value);
		}
	}

	public static event IBKJGPKACOO CNALFPOJBIK
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_DoubleTap(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_DoubleTap(value);
		}
	}

	public static event JMJHJKBHKGH FNOKPPHHPMM
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_LongTapStart(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_LongTapStart(value);
		}
	}

	public static event NPEHMMDOMHF EFGICDIIKAM
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_LongTap(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_LongTap(value);
		}
	}

	public static event DGEBLAAEJIH FLKIAEMGMGC
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_LongTapEnd(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_LongTapEnd(value);
		}
	}

	public static event GNNNGJGHIPJ KGOCCEIIBFE
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_DragStart(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_DragStart(value);
		}
	}

	public static event HLHOPCNBCMM KAFHFMGMJBB
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_Drag(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_Drag(value);
		}
	}

	public static event LEFJKFOPOAG OBIHHMAPMHB
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_DragEnd(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_DragEnd(value);
		}
	}

	public static event BIJKNLFNDOM NNKJJEOADNH
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_SwipeStart(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_SwipeStart(value);
		}
	}

	public static event EDHLGKJEOCJ BFJPAIGMIFK
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_Swipe(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_Swipe(value);
		}
	}

	public static event BODJDOPJAGI FCOOCIECLGH
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_SwipeEnd(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_SwipeEnd(value);
		}
	}

	public static event DPNDKKBILNP AFOFMEOAPGI
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_TouchStart2Fingers(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_TouchStart2Fingers(value);
		}
	}

	public static event LJPHGFOBFBD LIDNACGDMBJ
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_TouchDown2Fingers(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_TouchDown2Fingers(value);
		}
	}

	public static event JILPOOIIELM KOHHHLFLMPO
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_TouchUp2Fingers(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_TouchUp2Fingers(value);
		}
	}

	public static event MGGOPHOOEJO GPDOHJDELBC
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_SimpleTap2Fingers(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_SimpleTap2Fingers(value);
		}
	}

	public static event DCHFDJEFKDP ONJCBIJOMPK
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_DoubleTap2Fingers(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_DoubleTap2Fingers(value);
		}
	}

	public static event IKDCGCMIJDF PMPDDOODAOA
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_LongTapStart2Fingers(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_LongTapStart2Fingers(value);
		}
	}

	public static event JKAGCEOLDMF ENIOAKLEPLE
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_LongTap2Fingers(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_LongTap2Fingers(value);
		}
	}

	public static event EPJLIGMFBCN MCEENHCMNHK
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_LongTapEnd2Fingers(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_LongTapEnd2Fingers(value);
		}
	}

	public static event DOAJPLHANBH PMLCMKBEGOG
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_Twist(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_Twist(value);
		}
	}

	public static event BGFLNJPKPOP IMAKAFNDAFI
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_TwistEnd(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_TwistEnd(value);
		}
	}

	public static event DLMHEJNJGHF JCKDDDPAGFN
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_PinchIn(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_PinchIn(value);
		}
	}

	public static event BGJJGNAHJIL LKIMMJPPBBH
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_PinchOut(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_PinchOut(value);
		}
	}

	public static event BMHDECJKIMK GNOJBMEKGLH
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_PinchEnd(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_PinchEnd(value);
		}
	}

	public static event DBEGNAOAHGC HLENDKFOBNM
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_DragStart2Fingers(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_DragStart2Fingers(value);
		}
	}

	public static event ICPACHDFBPG AOOLDEJNMCG
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_Drag2Fingers(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_Drag2Fingers(value);
		}
	}

	public static event FGNOPNHNCEK GDPGENHMHKO
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_DragEnd2Fingers(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_DragEnd2Fingers(value);
		}
	}

	public static event JGDFHDDCEHO GOIGCNAENKC
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_SwipeStart2Fingers(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_SwipeStart2Fingers(value);
		}
	}

	public static event KHEMMAEPJJB AFNBBNNEDPC
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_Swipe2Fingers(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_Swipe2Fingers(value);
		}
	}

	public static event OJADGCJCPPJ FNMKLMLAAMI
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_SwipeEnd2Fingers(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_SwipeEnd2Fingers(value);
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_LongTap(NPEHMMDOMHF ICENKPDOHBK)
	{
		EasyTouch.m_EFGICDIIKAM = (NPEHMMDOMHF)Delegate.Combine(EasyTouch.m_EFGICDIIKAM, ICENKPDOHBK);
	}

	public static float GetStationnaryTolerance()
	{
		return instance.StationnaryTolerance;
	}

	private int AMADCHJCJDJ(int LEOCLKHBLED)
	{
		int i = LEOCLKHBLED + 1;
		bool flag = false;
		for (; i < 10; i++)
		{
			if (flag)
			{
				break;
			}
			if (PLOLGPDJALM[i] != null && i >= LEOCLKHBLED)
			{
				flag = true;
			}
		}
		return i - 1;
	}

	public static float KNKCCDALHFO()
	{
		return instance.swipeTolerance;
	}

	public static bool GetEnableTwist()
	{
		return instance.enableTwist;
	}

	public static bool MCGJDNCLKGG()
	{
		return instance.enable2FingersGesture;
	}

	public EasyTouch()
	{
		enable = true;
		useBroadcastMessage = false;
		enable2FingersGesture = true;
		enableTwist = true;
		enablePinch = true;
		autoSelect = false;
		StationnaryTolerance = 25f;
		longTapTime = 1f;
		swipeTolerance = 0.85f;
		minPinchLength = 0f;
		minTwistAngle = 1f;
	}

	public static Camera GetCamera()
	{
		return instance.easyTouchCamera;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_SwipeStart(BIJKNLFNDOM ICENKPDOHBK)
	{
		EasyTouch.m_NNKJJEOADNH = (BIJKNLFNDOM)Delegate.Remove(EasyTouch.m_NNKJJEOADNH, ICENKPDOHBK);
	}

	private void OnDrawGizmos()
	{
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_DoubleTap(IBKJGPKACOO ICENKPDOHBK)
	{
		EasyTouch.m_CNALFPOJBIK = (IBKJGPKACOO)Delegate.Remove(EasyTouch.m_CNALFPOJBIK, ICENKPDOHBK);
	}

	public static void NAMNJBCNANF(int NKGNNOMNIKO)
	{
		instance.MNOJNMOOBFA(NKGNNOMNIKO).BMNGEAFPELI = ANGFCINKJKK.Drag;
	}

	public static void SetOtherReceiverObject(GameObject IJJCMEFPHGP)
	{
		instance.receiverObject = IJJCMEFPHGP;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_Drag(HLHOPCNBCMM ICENKPDOHBK)
	{
		EasyTouch.m_KAFHFMGMJBB = (HLHOPCNBCMM)Delegate.Combine(EasyTouch.m_KAFHFMGMJBB, ICENKPDOHBK);
	}

	public static void SetSwipeTolerance(float DCJJIFPIOOI)
	{
		instance.swipeTolerance = DCJJIFPIOOI;
	}

	public static void SetCamera(Camera DDKDLNDJAMA)
	{
		instance.easyTouchCamera = DDKDLNDJAMA;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_LongTapStart(JMJHJKBHKGH ICENKPDOHBK)
	{
		EasyTouch.m_FNOKPPHHPMM = (JMJHJKBHKGH)Delegate.Combine(EasyTouch.m_FNOKPPHHPMM, ICENKPDOHBK);
	}

	public static void SetIsReservedArea(bool EBBBIBCMBAM)
	{
		instance.enableReservedArea = EBBBIBCMBAM;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_Drag2Fingers(ICPACHDFBPG ICENKPDOHBK)
	{
		EasyTouch.m_AOOLDEJNMCG = (ICPACHDFBPG)Delegate.Remove(EasyTouch.m_AOOLDEJNMCG, ICENKPDOHBK);
	}

	public static void SetMinPinchLength(float DMNFHKDEOHL)
	{
		instance.minPinchLength = DMNFHKDEOHL;
	}

	public static bool IsRectUnderTouch(Rect HGMPLGNJEPC, bool BCBNFHOCHPO = false)
	{
		bool result = false;
		for (int i = 0; i < 10; i++)
		{
			if (instance.PLOLGPDJALM[i] != null)
			{
				if (BCBNFHOCHPO)
				{
					HGMPLGNJEPC = new Rect(HGMPLGNJEPC.x, (float)Screen.height - HGMPLGNJEPC.y - HGMPLGNJEPC.height, HGMPLGNJEPC.width, HGMPLGNJEPC.height);
				}
				result = HGMPLGNJEPC.Contains(instance.PLOLGPDJALM[i].CMGMOJAFLFL);
				break;
			}
		}
		return result;
	}

	private void NMIJGLBCPNI()
	{
		float nLKHLAAEPBI = 870f;
		bool flag = false;
		Vector2 zero = Vector2.zero;
		Vector2 zero2 = Vector2.zero;
		float num = 1082f;
		if (DJPLIMLLFFO == ANGFCINKJKK.None)
		{
			MMGHDHKBPAL = AMADCHJCJDJ(-1);
			FGBLDNAOEPN = AMADCHJCJDJ(MMGHDHKBPAL);
			GNLIGBBILPG = Time.realtimeSinceStartup;
			DJPLIMLLFFO = ANGFCINKJKK.Tap;
			PLOLGPDJALM[MMGHDHKBPAL].CNOAJLKBKGK = PLOLGPDJALM[MMGHDHKBPAL].CMGMOJAFLFL;
			PLOLGPDJALM[FGBLDNAOEPN].CNOAJLKBKGK = PLOLGPDJALM[FGBLDNAOEPN].CMGMOJAFLFL;
			PLOLGPDJALM[MMGHDHKBPAL].LIMLBJEAAIP = PLOLGPDJALM[MMGHDHKBPAL].CMGMOJAFLFL;
			PLOLGPDJALM[FGBLDNAOEPN].LIMLBJEAAIP = PLOLGPDJALM[FGBLDNAOEPN].CMGMOJAFLFL;
			DHJKIEGOCLH = Mathf.Abs(Vector2.Distance(PLOLGPDJALM[MMGHDHKBPAL].CMGMOJAFLFL, PLOLGPDJALM[FGBLDNAOEPN].CMGMOJAFLFL));
			IDIMOENGDAB = new Vector2((PLOLGPDJALM[MMGHDHKBPAL].CMGMOJAFLFL.x + PLOLGPDJALM[FGBLDNAOEPN].CMGMOJAFLFL.x) / 1595f, (PLOLGPDJALM[MMGHDHKBPAL].CMGMOJAFLFL.y + PLOLGPDJALM[FGBLDNAOEPN].CMGMOJAFLFL.y) / 1467f);
			zero2 = Vector2.zero;
			if (autoSelect)
			{
				MLONCPAOCCP = LJPAHGBFEPE(PLOLGPDJALM[MMGHDHKBPAL].CNOAJLKBKGK);
				if (MLONCPAOCCP != LJPAHGBFEPE(PLOLGPDJALM[FGBLDNAOEPN].CNOAJLKBKGK))
				{
					MLONCPAOCCP = null;
				}
			}
			PBAAOIACNEE((ENHMGALIDNH)(-114), IDIMOENGDAB, IDIMOENGDAB, zero2, nLKHLAAEPBI, AGEGIBIJEOB.None, 1902f, Vector2.zero, 1353f, 877f, DHJKIEGOCLH);
		}
		nLKHLAAEPBI = Time.realtimeSinceStartup - GNLIGBBILPG;
		zero = new Vector2((PLOLGPDJALM[MMGHDHKBPAL].CMGMOJAFLFL.x + PLOLGPDJALM[FGBLDNAOEPN].CMGMOJAFLFL.x) / 1012f, (PLOLGPDJALM[MMGHDHKBPAL].CMGMOJAFLFL.y + PLOLGPDJALM[FGBLDNAOEPN].CMGMOJAFLFL.y) / 1966f);
		zero2 = zero - FAJJPOCEFBK;
		num = Mathf.Abs(Vector2.Distance(PLOLGPDJALM[MMGHDHKBPAL].CMGMOJAFLFL, PLOLGPDJALM[FGBLDNAOEPN].CMGMOJAFLFL));
		if (PLOLGPDJALM[MMGHDHKBPAL].ELDOMOEIAJI == (TouchPhase)8 || PLOLGPDJALM[FGBLDNAOEPN].ELDOMOEIAJI == (TouchPhase)6)
		{
			DJPLIMLLFFO = ANGFCINKJKK.Swipe;
		}
		if (PLOLGPDJALM[MMGHDHKBPAL].ELDOMOEIAJI != TouchPhase.Began && PLOLGPDJALM[FGBLDNAOEPN].ELDOMOEIAJI != (TouchPhase)5 && DJPLIMLLFFO != ANGFCINKJKK.Cancel)
		{
			if (DJPLIMLLFFO == ANGFCINKJKK.Tap && nLKHLAAEPBI >= longTapTime && NBJPAKJNJNJ(PLOLGPDJALM[MMGHDHKBPAL]) && NBJPAKJNJNJ(PLOLGPDJALM[FGBLDNAOEPN]))
			{
				DJPLIMLLFFO = ANGFCINKJKK.Drag;
				PBAAOIACNEE((ENHMGALIDNH)(-97), IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, AGEGIBIJEOB.Left, 1032f, Vector2.zero, 1394f, 1863f, num);
			}
			if (false)
			{
				float num2 = Vector2.Dot(PLOLGPDJALM[MMGHDHKBPAL].DPALPIFLHBF.normalized, PLOLGPDJALM[FGBLDNAOEPN].DPALPIFLHBF.normalized);
				if (enablePinch && num != DHJKIEGOCLH)
				{
					if (Mathf.Abs(num - DHJKIEGOCLH) >= minPinchLength)
					{
						DJPLIMLLFFO = ANGFCINKJKK.None;
					}
					if (DJPLIMLLFFO == ANGFCINKJKK.LongTap)
					{
						if (num < DHJKIEGOCLH)
						{
							if (IMLJFPAMLBH != ANGFCINKJKK.Drag)
							{
								EGNPCINKJAC(IMLJFPAMLBH, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, false, num);
								GNLIGBBILPG = Time.realtimeSinceStartup;
							}
							PBAAOIACNEE((ENHMGALIDNH)(-74), IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, ELPEKFLEKOJ(PLOLGPDJALM[MMGHDHKBPAL].CNOAJLKBKGK, PLOLGPDJALM[MMGHDHKBPAL].CMGMOJAFLFL), 1943f, Vector2.zero, 291f, Mathf.Abs(num - DHJKIEGOCLH), num);
							DJPLIMLLFFO = ANGFCINKJKK.Swipe;
						}
						else if (num > DHJKIEGOCLH)
						{
							if (IMLJFPAMLBH != ANGFCINKJKK.Acquisition)
							{
								EGNPCINKJAC(IMLJFPAMLBH, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, true, num);
								GNLIGBBILPG = Time.realtimeSinceStartup;
							}
							PBAAOIACNEE((ENHMGALIDNH)79, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, ELPEKFLEKOJ(PLOLGPDJALM[MMGHDHKBPAL].CNOAJLKBKGK, PLOLGPDJALM[MMGHDHKBPAL].CMGMOJAFLFL), 143f, Vector2.zero, 1881f, Mathf.Abs(num - DHJKIEGOCLH), num);
							DJPLIMLLFFO = ANGFCINKJKK.Acquisition;
						}
					}
				}
				if (enableTwist)
				{
					if (Mathf.Abs(IJFFOJHKBOK()) > minTwistAngle)
					{
						if (DJPLIMLLFFO != ANGFCINKJKK.LongTap)
						{
							EGNPCINKJAC(DJPLIMLLFFO, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, false, num);
							GNLIGBBILPG = Time.realtimeSinceStartup;
						}
						DJPLIMLLFFO = ANGFCINKJKK.None;
					}
					if (DJPLIMLLFFO == ANGFCINKJKK.Drag)
					{
						PBAAOIACNEE(ENHMGALIDNH.On_LongTap2Fingers, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, AGEGIBIJEOB.Left, 765f, Vector2.zero, IJFFOJHKBOK(), 562f, num);
					}
					PLOLGPDJALM[MMGHDHKBPAL].LIMLBJEAAIP = PLOLGPDJALM[MMGHDHKBPAL].CMGMOJAFLFL;
					PLOLGPDJALM[FGBLDNAOEPN].LIMLBJEAAIP = PLOLGPDJALM[FGBLDNAOEPN].CMGMOJAFLFL;
				}
				if (num2 > 1078f)
				{
					if ((bool)MLONCPAOCCP && !DIEMDCBFHDC)
					{
						if (DJPLIMLLFFO != ANGFCINKJKK.Tap)
						{
							EGNPCINKJAC(DJPLIMLLFFO, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, false, num);
							GNLIGBBILPG = Time.realtimeSinceStartup;
						}
						PBAAOIACNEE((ENHMGALIDNH)(-78), IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, AGEGIBIJEOB.Left, 1942f, Vector2.zero, 578f, 444f, num);
						DIEMDCBFHDC = false;
					}
					else if (!MLONCPAOCCP && !PIKLMCJOIKH)
					{
						if (DJPLIMLLFFO != ANGFCINKJKK.Tap)
						{
							EGNPCINKJAC(DJPLIMLLFFO, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, false, num);
							GNLIGBBILPG = Time.realtimeSinceStartup;
						}
						PBAAOIACNEE((ENHMGALIDNH)(-121), IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, AGEGIBIJEOB.None, 98f, Vector2.zero, 1844f, 1967f, num);
						PIKLMCJOIKH = true;
					}
				}
				else if (num2 < 14f)
				{
					DIEMDCBFHDC = false;
					PIKLMCJOIKH = false;
				}
				if (DIEMDCBFHDC)
				{
					PBAAOIACNEE((ENHMGALIDNH)(-86), IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, ELPEKFLEKOJ(FAJJPOCEFBK, zero), 1720f, zero2, 674f, 59f, num);
				}
				if (PIKLMCJOIKH)
				{
					PBAAOIACNEE((ENHMGALIDNH)113, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, ELPEKFLEKOJ(FAJJPOCEFBK, zero), 1499f, zero2, 115f, 1615f, num);
				}
			}
			else if (DJPLIMLLFFO == ANGFCINKJKK.Tap)
			{
				PBAAOIACNEE(ENHMGALIDNH.On_PinchIn, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, AGEGIBIJEOB.Left, 454f, Vector2.zero, 950f, 1634f, num);
			}
			PBAAOIACNEE((ENHMGALIDNH)116, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, ELPEKFLEKOJ(FAJJPOCEFBK, zero), 622f, zero2, 116f, 296f, num);
			DHJKIEGOCLH = num;
			FAJJPOCEFBK = zero;
			IMLJFPAMLBH = DJPLIMLLFFO;
		}
		else
		{
			EGNPCINKJAC(DJPLIMLLFFO, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, false, num);
			DJPLIMLLFFO = ANGFCINKJKK.Swipe;
			MLONCPAOCCP = null;
			PIKLMCJOIKH = false;
			DIEMDCBFHDC = false;
		}
	}

	private float KAOJBNLPCEN(Vector2 GAKOOBECLIB, Vector2 IDFCFEOMBKP)
	{
		float y = GAKOOBECLIB.x * IDFCFEOMBKP.y - GAKOOBECLIB.y * IDFCFEOMBKP.x;
		return Mathf.Atan2(y, Vector2.Dot(GAKOOBECLIB, IDFCFEOMBKP));
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_TouchDown2Fingers(LJPHGFOBFBD ICENKPDOHBK)
	{
		EasyTouch.m_LIDNACGDMBJ = (LJPHGFOBFBD)Delegate.Remove(EasyTouch.m_LIDNACGDMBJ, ICENKPDOHBK);
	}

	public static void RemoveReservedArea(Rect BDDDNKEFMHN)
	{
		instance.reservedAreas.Remove(BDDDNKEFMHN);
	}

	private void MDIKJNDBEHC(ENHMGALIDNH AMOPEEBFAPD, NLKIHCFELMK BMNGEAFPELI)
	{
		if (receiverObject != null && receiverObject != BMNGEAFPELI.FAHLIEPIENC)
		{
			receiverObject.SendMessage(AMOPEEBFAPD.ToString(), BMNGEAFPELI, SendMessageOptions.DontRequireReceiver);
		}
		if (BMNGEAFPELI.FAHLIEPIENC != null)
		{
			BMNGEAFPELI.FAHLIEPIENC.SendMessage(AMOPEEBFAPD.ToString(), BMNGEAFPELI, SendMessageOptions.DontRequireReceiver);
		}
		else
		{
			SendMessage(AMOPEEBFAPD.ToString(), BMNGEAFPELI, SendMessageOptions.DontRequireReceiver);
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_DragStart2Fingers(DBEGNAOAHGC ICENKPDOHBK)
	{
		EasyTouch.m_HLENDKFOBNM = (DBEGNAOAHGC)Delegate.Remove(EasyTouch.m_HLENDKFOBNM, ICENKPDOHBK);
	}

	public static void OADAFGPOPEO(Rect BDDDNKEFMHN)
	{
		instance.reservedAreas.Add(BDDDNKEFMHN);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_TouchStart2Fingers(DPNDKKBILNP ICENKPDOHBK)
	{
		EasyTouch.m_AFOFMEOAPGI = (DPNDKKBILNP)Delegate.Remove(EasyTouch.m_AFOFMEOAPGI, ICENKPDOHBK);
	}

	private void CECDHGOIPGB()
	{
		float nLKHLAAEPBI = 0f;
		bool flag = false;
		Vector2 zero = Vector2.zero;
		Vector2 zero2 = Vector2.zero;
		float num = 0f;
		if (DJPLIMLLFFO == ANGFCINKJKK.None)
		{
			MMGHDHKBPAL = AMADCHJCJDJ(-1);
			FGBLDNAOEPN = AMADCHJCJDJ(MMGHDHKBPAL);
			GNLIGBBILPG = Time.realtimeSinceStartup;
			DJPLIMLLFFO = ANGFCINKJKK.Tap;
			PLOLGPDJALM[MMGHDHKBPAL].CNOAJLKBKGK = PLOLGPDJALM[MMGHDHKBPAL].CMGMOJAFLFL;
			PLOLGPDJALM[FGBLDNAOEPN].CNOAJLKBKGK = PLOLGPDJALM[FGBLDNAOEPN].CMGMOJAFLFL;
			PLOLGPDJALM[MMGHDHKBPAL].LIMLBJEAAIP = PLOLGPDJALM[MMGHDHKBPAL].CMGMOJAFLFL;
			PLOLGPDJALM[FGBLDNAOEPN].LIMLBJEAAIP = PLOLGPDJALM[FGBLDNAOEPN].CMGMOJAFLFL;
			DHJKIEGOCLH = Mathf.Abs(Vector2.Distance(PLOLGPDJALM[MMGHDHKBPAL].CMGMOJAFLFL, PLOLGPDJALM[FGBLDNAOEPN].CMGMOJAFLFL));
			IDIMOENGDAB = new Vector2((PLOLGPDJALM[MMGHDHKBPAL].CMGMOJAFLFL.x + PLOLGPDJALM[FGBLDNAOEPN].CMGMOJAFLFL.x) / 2f, (PLOLGPDJALM[MMGHDHKBPAL].CMGMOJAFLFL.y + PLOLGPDJALM[FGBLDNAOEPN].CMGMOJAFLFL.y) / 2f);
			zero2 = Vector2.zero;
			if (autoSelect)
			{
				MLONCPAOCCP = LJPAHGBFEPE(PLOLGPDJALM[MMGHDHKBPAL].CNOAJLKBKGK);
				if (MLONCPAOCCP != LJPAHGBFEPE(PLOLGPDJALM[FGBLDNAOEPN].CNOAJLKBKGK))
				{
					MLONCPAOCCP = null;
				}
			}
			PBAAOIACNEE(ENHMGALIDNH.On_TouchStart2Fingers, IDIMOENGDAB, IDIMOENGDAB, zero2, nLKHLAAEPBI, AGEGIBIJEOB.None, 0f, Vector2.zero, 0f, 0f, DHJKIEGOCLH);
		}
		nLKHLAAEPBI = Time.realtimeSinceStartup - GNLIGBBILPG;
		zero = new Vector2((PLOLGPDJALM[MMGHDHKBPAL].CMGMOJAFLFL.x + PLOLGPDJALM[FGBLDNAOEPN].CMGMOJAFLFL.x) / 2f, (PLOLGPDJALM[MMGHDHKBPAL].CMGMOJAFLFL.y + PLOLGPDJALM[FGBLDNAOEPN].CMGMOJAFLFL.y) / 2f);
		zero2 = zero - FAJJPOCEFBK;
		num = Mathf.Abs(Vector2.Distance(PLOLGPDJALM[MMGHDHKBPAL].CMGMOJAFLFL, PLOLGPDJALM[FGBLDNAOEPN].CMGMOJAFLFL));
		if (PLOLGPDJALM[MMGHDHKBPAL].ELDOMOEIAJI == TouchPhase.Canceled || PLOLGPDJALM[FGBLDNAOEPN].ELDOMOEIAJI == TouchPhase.Canceled)
		{
			DJPLIMLLFFO = ANGFCINKJKK.Cancel;
		}
		if (PLOLGPDJALM[MMGHDHKBPAL].ELDOMOEIAJI != TouchPhase.Ended && PLOLGPDJALM[FGBLDNAOEPN].ELDOMOEIAJI != TouchPhase.Ended && DJPLIMLLFFO != ANGFCINKJKK.Cancel)
		{
			if (DJPLIMLLFFO == ANGFCINKJKK.Tap && nLKHLAAEPBI >= longTapTime && NBJPAKJNJNJ(PLOLGPDJALM[MMGHDHKBPAL]) && NBJPAKJNJNJ(PLOLGPDJALM[FGBLDNAOEPN]))
			{
				DJPLIMLLFFO = ANGFCINKJKK.LongTap;
				PBAAOIACNEE(ENHMGALIDNH.On_LongTapStart2Fingers, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, AGEGIBIJEOB.None, 0f, Vector2.zero, 0f, 0f, num);
			}
			if (true)
			{
				float num2 = Vector2.Dot(PLOLGPDJALM[MMGHDHKBPAL].DPALPIFLHBF.normalized, PLOLGPDJALM[FGBLDNAOEPN].DPALPIFLHBF.normalized);
				if (enablePinch && num != DHJKIEGOCLH)
				{
					if (Mathf.Abs(num - DHJKIEGOCLH) >= minPinchLength)
					{
						DJPLIMLLFFO = ANGFCINKJKK.Pinch;
					}
					if (DJPLIMLLFFO == ANGFCINKJKK.Pinch)
					{
						if (num < DHJKIEGOCLH)
						{
							if (IMLJFPAMLBH != ANGFCINKJKK.Pinch)
							{
								EGNPCINKJAC(IMLJFPAMLBH, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, false, num);
								GNLIGBBILPG = Time.realtimeSinceStartup;
							}
							PBAAOIACNEE(ENHMGALIDNH.On_PinchIn, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, ELPEKFLEKOJ(PLOLGPDJALM[MMGHDHKBPAL].CNOAJLKBKGK, PLOLGPDJALM[MMGHDHKBPAL].CMGMOJAFLFL), 0f, Vector2.zero, 0f, Mathf.Abs(num - DHJKIEGOCLH), num);
							DJPLIMLLFFO = ANGFCINKJKK.Pinch;
						}
						else if (num > DHJKIEGOCLH)
						{
							if (IMLJFPAMLBH != ANGFCINKJKK.Pinch)
							{
								EGNPCINKJAC(IMLJFPAMLBH, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, false, num);
								GNLIGBBILPG = Time.realtimeSinceStartup;
							}
							PBAAOIACNEE(ENHMGALIDNH.On_PinchOut, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, ELPEKFLEKOJ(PLOLGPDJALM[MMGHDHKBPAL].CNOAJLKBKGK, PLOLGPDJALM[MMGHDHKBPAL].CMGMOJAFLFL), 0f, Vector2.zero, 0f, Mathf.Abs(num - DHJKIEGOCLH), num);
							DJPLIMLLFFO = ANGFCINKJKK.Pinch;
						}
					}
				}
				if (enableTwist)
				{
					if (Mathf.Abs(HACHPDDIMEM()) > minTwistAngle)
					{
						if (DJPLIMLLFFO != ANGFCINKJKK.Twist)
						{
							EGNPCINKJAC(DJPLIMLLFFO, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, false, num);
							GNLIGBBILPG = Time.realtimeSinceStartup;
						}
						DJPLIMLLFFO = ANGFCINKJKK.Twist;
					}
					if (DJPLIMLLFFO == ANGFCINKJKK.Twist)
					{
						PBAAOIACNEE(ENHMGALIDNH.On_Twist, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, AGEGIBIJEOB.None, 0f, Vector2.zero, HACHPDDIMEM(), 0f, num);
					}
					PLOLGPDJALM[MMGHDHKBPAL].LIMLBJEAAIP = PLOLGPDJALM[MMGHDHKBPAL].CMGMOJAFLFL;
					PLOLGPDJALM[FGBLDNAOEPN].LIMLBJEAAIP = PLOLGPDJALM[FGBLDNAOEPN].CMGMOJAFLFL;
				}
				if (num2 > 0f)
				{
					if ((bool)MLONCPAOCCP && !DIEMDCBFHDC)
					{
						if (DJPLIMLLFFO != ANGFCINKJKK.Tap)
						{
							EGNPCINKJAC(DJPLIMLLFFO, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, false, num);
							GNLIGBBILPG = Time.realtimeSinceStartup;
						}
						PBAAOIACNEE(ENHMGALIDNH.On_DragStart2Fingers, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, AGEGIBIJEOB.None, 0f, Vector2.zero, 0f, 0f, num);
						DIEMDCBFHDC = true;
					}
					else if (!MLONCPAOCCP && !PIKLMCJOIKH)
					{
						if (DJPLIMLLFFO != ANGFCINKJKK.Tap)
						{
							EGNPCINKJAC(DJPLIMLLFFO, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, false, num);
							GNLIGBBILPG = Time.realtimeSinceStartup;
						}
						PBAAOIACNEE(ENHMGALIDNH.On_SwipeStart2Fingers, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, AGEGIBIJEOB.None, 0f, Vector2.zero, 0f, 0f, num);
						PIKLMCJOIKH = true;
					}
				}
				else if (num2 < 0f)
				{
					DIEMDCBFHDC = false;
					PIKLMCJOIKH = false;
				}
				if (DIEMDCBFHDC)
				{
					PBAAOIACNEE(ENHMGALIDNH.On_Drag2Fingers, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, ELPEKFLEKOJ(FAJJPOCEFBK, zero), 0f, zero2, 0f, 0f, num);
				}
				if (PIKLMCJOIKH)
				{
					PBAAOIACNEE(ENHMGALIDNH.On_Swipe2Fingers, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, ELPEKFLEKOJ(FAJJPOCEFBK, zero), 0f, zero2, 0f, 0f, num);
				}
			}
			else if (DJPLIMLLFFO == ANGFCINKJKK.LongTap)
			{
				PBAAOIACNEE(ENHMGALIDNH.On_LongTap2Fingers, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, AGEGIBIJEOB.None, 0f, Vector2.zero, 0f, 0f, num);
			}
			PBAAOIACNEE(ENHMGALIDNH.On_TouchDown2Fingers, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, ELPEKFLEKOJ(FAJJPOCEFBK, zero), 0f, zero2, 0f, 0f, num);
			DHJKIEGOCLH = num;
			FAJJPOCEFBK = zero;
			IMLJFPAMLBH = DJPLIMLLFFO;
		}
		else
		{
			EGNPCINKJAC(DJPLIMLLFFO, IDIMOENGDAB, zero, zero2, nLKHLAAEPBI, true, num);
			DJPLIMLLFFO = ANGFCINKJKK.None;
			MLONCPAOCCP = null;
			PIKLMCJOIKH = false;
			DIEMDCBFHDC = false;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_Cancel(LBBNLDGGNIB ICENKPDOHBK)
	{
		EasyTouch.m_IFHDJPNBDJF = (LBBNLDGGNIB)Delegate.Combine(EasyTouch.m_IFHDJPNBDJF, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_SwipeStart2Fingers(JGDFHDDCEHO ICENKPDOHBK)
	{
		EasyTouch.m_GOIGCNAENKC = (JGDFHDDCEHO)Delegate.Combine(EasyTouch.m_GOIGCNAENKC, ICENKPDOHBK);
	}

	[SpecialName]
	public static void COJDMAHCIAG(DBEGNAOAHGC ICENKPDOHBK)
	{
		EasyTouch.m_HLENDKFOBNM = (DBEGNAOAHGC)Delegate.Remove(EasyTouch.m_HLENDKFOBNM, ICENKPDOHBK);
	}

	private void EGNPCINKJAC(ANGFCINKJKK BMNGEAFPELI, Vector2 CILKPHCEJAM, Vector2 CMGMOJAFLFL, Vector2 DPALPIFLHBF, float HBNDHMPNCME, bool MNHPFJLIBKP, float HJPMKLKHFDE)
	{
		switch (BMNGEAFPELI)
		{
		case ANGFCINKJKK.Tap:
			if (PLOLGPDJALM[MMGHDHKBPAL].CNHAAHEDDPC < 2 && PLOLGPDJALM[FGBLDNAOEPN].CNHAAHEDDPC < 2)
			{
				PBAAOIACNEE(ENHMGALIDNH.On_SimpleTap2Fingers, CILKPHCEJAM, CMGMOJAFLFL, DPALPIFLHBF, HBNDHMPNCME, AGEGIBIJEOB.None, 0f, Vector2.zero, 0f, 0f, HJPMKLKHFDE);
			}
			else
			{
				PBAAOIACNEE(ENHMGALIDNH.On_DoubleTap2Fingers, CILKPHCEJAM, CMGMOJAFLFL, DPALPIFLHBF, HBNDHMPNCME, AGEGIBIJEOB.None, 0f, Vector2.zero, 0f, 0f, HJPMKLKHFDE);
			}
			break;
		case ANGFCINKJKK.LongTap:
			PBAAOIACNEE(ENHMGALIDNH.On_LongTapEnd2Fingers, CILKPHCEJAM, CMGMOJAFLFL, DPALPIFLHBF, HBNDHMPNCME, AGEGIBIJEOB.None, 0f, Vector2.zero, 0f, 0f, HJPMKLKHFDE);
			break;
		case ANGFCINKJKK.Pinch:
			PBAAOIACNEE(ENHMGALIDNH.On_PinchEnd, CILKPHCEJAM, CMGMOJAFLFL, DPALPIFLHBF, HBNDHMPNCME, AGEGIBIJEOB.None, 0f, Vector2.zero, 0f, 0f, HJPMKLKHFDE);
			break;
		case ANGFCINKJKK.Twist:
			PBAAOIACNEE(ENHMGALIDNH.On_TwistEnd, CILKPHCEJAM, CMGMOJAFLFL, DPALPIFLHBF, HBNDHMPNCME, AGEGIBIJEOB.None, 0f, Vector2.zero, 0f, 0f, HJPMKLKHFDE);
			break;
		}
		if (MNHPFJLIBKP)
		{
			if (DIEMDCBFHDC)
			{
				PBAAOIACNEE(ENHMGALIDNH.On_DragEnd2Fingers, CILKPHCEJAM, CMGMOJAFLFL, DPALPIFLHBF, HBNDHMPNCME, ELPEKFLEKOJ(CILKPHCEJAM, CMGMOJAFLFL), (CMGMOJAFLFL - CILKPHCEJAM).magnitude, CMGMOJAFLFL - CILKPHCEJAM, 0f, 0f, HJPMKLKHFDE);
			}
			if (PIKLMCJOIKH)
			{
				PBAAOIACNEE(ENHMGALIDNH.On_SwipeEnd2Fingers, CILKPHCEJAM, CMGMOJAFLFL, DPALPIFLHBF, HBNDHMPNCME, ELPEKFLEKOJ(CILKPHCEJAM, CMGMOJAFLFL), (CMGMOJAFLFL - CILKPHCEJAM).magnitude, CMGMOJAFLFL - CILKPHCEJAM, 0f, 0f, HJPMKLKHFDE);
			}
			PBAAOIACNEE(ENHMGALIDNH.On_TouchUp2Fingers, CILKPHCEJAM, CMGMOJAFLFL, DPALPIFLHBF, HBNDHMPNCME, AGEGIBIJEOB.None, 0f, Vector2.zero, 0f, 0f, HJPMKLKHFDE);
		}
	}

	public static bool GetEnable2FingersGesture()
	{
		return instance.enable2FingersGesture;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_LongTap2Fingers(JKAGCEOLDMF ICENKPDOHBK)
	{
		EasyTouch.m_ENIOAKLEPLE = (JKAGCEOLDMF)Delegate.Remove(EasyTouch.m_ENIOAKLEPLE, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_TouchDown2Fingers(LJPHGFOBFBD ICENKPDOHBK)
	{
		EasyTouch.m_LIDNACGDMBJ = (LJPHGFOBFBD)Delegate.Combine(EasyTouch.m_LIDNACGDMBJ, ICENKPDOHBK);
	}

	public static void SetEnableAutoSelect(bool EBBBIBCMBAM)
	{
		instance.autoSelect = EBBBIBCMBAM;
	}

	public static GameObject BDCLFIEHGPE()
	{
		return instance.receiverObject;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_LongTapStart2Fingers(IKDCGCMIJDF ICENKPDOHBK)
	{
		EasyTouch.m_PMPDDOODAOA = (IKDCGCMIJDF)Delegate.Remove(EasyTouch.m_PMPDDOODAOA, ICENKPDOHBK);
	}

	private bool FLJCONFKDNH(int CCPKOHMGDEH)
	{
		bool flag = false;
		if (enabledNGuiMode)
		{
			LayerMask layerMask = nGUILayers;
			int num = 0;
			while (!flag && num < nGUICameras.Count)
			{
				Ray ray = nGUICameras[num].ScreenPointToRay(PLOLGPDJALM[CCPKOHMGDEH].CMGMOJAFLFL);
				RaycastHit hitInfo;
				flag = Physics.Raycast(ray, out hitInfo, float.MaxValue, layerMask);
				num++;
			}
		}
		return flag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_LongTap(NPEHMMDOMHF ICENKPDOHBK)
	{
		EasyTouch.m_EFGICDIIKAM = (NPEHMMDOMHF)Delegate.Remove(EasyTouch.m_EFGICDIIKAM, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_LongTapEnd(DGEBLAAEJIH ICENKPDOHBK)
	{
		EasyTouch.m_FLKIAEMGMGC = (DGEBLAAEJIH)Delegate.Remove(EasyTouch.m_FLKIAEMGMGC, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_SimpleTap(IBFFAOEHFHF ICENKPDOHBK)
	{
		EasyTouch.m_KPMBACFCALN = (IBFFAOEHFHF)Delegate.Remove(EasyTouch.m_KPMBACFCALN, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_Twist(DOAJPLHANBH ICENKPDOHBK)
	{
		EasyTouch.m_PMLCMKBEGOG = (DOAJPLHANBH)Delegate.Remove(EasyTouch.m_PMLCMKBEGOG, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_DragEnd2Fingers(FGNOPNHNCEK ICENKPDOHBK)
	{
		EasyTouch.m_GDPGENHMHKO = (FGNOPNHNCEK)Delegate.Remove(EasyTouch.m_GDPGENHMHKO, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_DragStart(GNNNGJGHIPJ ICENKPDOHBK)
	{
		EasyTouch.m_KGOCCEIIBFE = (GNNNGJGHIPJ)Delegate.Combine(EasyTouch.m_KGOCCEIIBFE, ICENKPDOHBK);
	}

	private PLICNHAMCPB MNOJNMOOBFA(int KEJEKFGGNML)
	{
		int i = 0;
		PLICNHAMCPB pLICNHAMCPB = null;
		for (; i < 10; i++)
		{
			if (pLICNHAMCPB != null)
			{
				break;
			}
			if (PLOLGPDJALM[i] != null && PLOLGPDJALM[i].NKGNNOMNIKO == KEJEKFGGNML)
			{
				pLICNHAMCPB = PLOLGPDJALM[i];
			}
		}
		return pLICNHAMCPB;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_PinchOut(BGJJGNAHJIL ICENKPDOHBK)
	{
		EasyTouch.m_LKIMMJPPBBH = (BGJJGNAHJIL)Delegate.Combine(EasyTouch.m_LKIMMJPPBBH, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_PinchOut(BGJJGNAHJIL ICENKPDOHBK)
	{
		EasyTouch.m_LKIMMJPPBBH = (BGJJGNAHJIL)Delegate.Remove(EasyTouch.m_LKIMMJPPBBH, ICENKPDOHBK);
	}

	private float HACHPDDIMEM()
	{
		Vector2 iDFCFEOMBKP = PLOLGPDJALM[MMGHDHKBPAL].CMGMOJAFLFL - PLOLGPDJALM[FGBLDNAOEPN].CMGMOJAFLFL;
		Vector2 gAKOOBECLIB = PLOLGPDJALM[MMGHDHKBPAL].LIMLBJEAAIP - PLOLGPDJALM[FGBLDNAOEPN].LIMLBJEAAIP;
		return 57.29578f * KAOJBNLPCEN(gAKOOBECLIB, iDFCFEOMBKP);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_Drag2Fingers(ICPACHDFBPG ICENKPDOHBK)
	{
		EasyTouch.m_AOOLDEJNMCG = (ICPACHDFBPG)Delegate.Combine(EasyTouch.m_AOOLDEJNMCG, ICENKPDOHBK);
	}

	[SpecialName]
	public static void JNCNOMBKNCI(BGFLNJPKPOP ICENKPDOHBK)
	{
		EasyTouch.m_IMAKAFNDAFI = (BGFLNJPKPOP)Delegate.Remove(EasyTouch.m_IMAKAFNDAFI, ICENKPDOHBK);
	}

	public static void SetStationnaryTolerance(float DCJJIFPIOOI)
	{
		instance.StationnaryTolerance = DCJJIFPIOOI;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_LongTapStart(JMJHJKBHKGH ICENKPDOHBK)
	{
		EasyTouch.m_FNOKPPHHPMM = (JMJHJKBHKGH)Delegate.Remove(EasyTouch.m_FNOKPPHHPMM, ICENKPDOHBK);
	}

	private void JIGDEFDHIDG(ENHMGALIDNH AMOPEEBFAPD, NLKIHCFELMK BMNGEAFPELI)
	{
		if (useBroadcastMessage)
		{
			if (receiverObject != null && receiverObject != BMNGEAFPELI.FAHLIEPIENC)
			{
				receiverObject.SendMessage(AMOPEEBFAPD.ToString(), BMNGEAFPELI, SendMessageOptions.DontRequireReceiver);
			}
			if ((bool)BMNGEAFPELI.FAHLIEPIENC)
			{
				BMNGEAFPELI.FAHLIEPIENC.SendMessage(AMOPEEBFAPD.ToString(), BMNGEAFPELI, SendMessageOptions.DontRequireReceiver);
			}
			else
			{
				SendMessage(AMOPEEBFAPD.ToString(), BMNGEAFPELI, SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	public static void SetlongTapTime(float HBNDHMPNCME)
	{
		instance.longTapTime = HBNDHMPNCME;
	}

	[SpecialName]
	public static void JDJGIPNNCDJ(BIJKNLFNDOM ICENKPDOHBK)
	{
		EasyTouch.m_NNKJJEOADNH = (BIJKNLFNDOM)Delegate.Combine(EasyTouch.m_NNKJJEOADNH, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_SwipeStart(BIJKNLFNDOM ICENKPDOHBK)
	{
		EasyTouch.m_NNKJJEOADNH = (BIJKNLFNDOM)Delegate.Combine(EasyTouch.m_NNKJJEOADNH, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_Twist(DOAJPLHANBH ICENKPDOHBK)
	{
		EasyTouch.m_PMLCMKBEGOG = (DOAJPLHANBH)Delegate.Combine(EasyTouch.m_PMLCMKBEGOG, ICENKPDOHBK);
	}

	private void HLOOCDJDMFO(ENHMGALIDNH PBONLONLGLE, NLKIHCFELMK BMNGEAFPELI)
	{
		switch (PBONLONLGLE)
		{
		case ENHMGALIDNH.On_Cancel:
			if (EasyTouch.m_IFHDJPNBDJF != null)
			{
				EasyTouch.m_IFHDJPNBDJF(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_Cancel2Fingers:
			if (EasyTouch.m_CNECHHONONJ != null)
			{
				EasyTouch.m_CNECHHONONJ(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_TouchStart:
			if (EasyTouch.m_FHBOBAEJJFP != null)
			{
				EasyTouch.m_FHBOBAEJJFP(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_TouchDown:
			if (EasyTouch.m_FEOACGMPIOG != null)
			{
				EasyTouch.m_FEOACGMPIOG(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_TouchUp:
			if (EasyTouch.m_DGEFKKDJLAA != null)
			{
				EasyTouch.m_DGEFKKDJLAA(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_SimpleTap:
			if (EasyTouch.m_KPMBACFCALN != null)
			{
				EasyTouch.m_KPMBACFCALN(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_DoubleTap:
			if (EasyTouch.m_CNALFPOJBIK != null)
			{
				EasyTouch.m_CNALFPOJBIK(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_LongTapStart:
			if (EasyTouch.m_FNOKPPHHPMM != null)
			{
				EasyTouch.m_FNOKPPHHPMM(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_LongTap:
			if (EasyTouch.m_EFGICDIIKAM != null)
			{
				EasyTouch.m_EFGICDIIKAM(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_LongTapEnd:
			if (EasyTouch.m_FLKIAEMGMGC != null)
			{
				EasyTouch.m_FLKIAEMGMGC(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_DragStart:
			if (EasyTouch.m_KGOCCEIIBFE != null)
			{
				EasyTouch.m_KGOCCEIIBFE(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_Drag:
			if (EasyTouch.m_KAFHFMGMJBB != null)
			{
				EasyTouch.m_KAFHFMGMJBB(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_DragEnd:
			if (EasyTouch.m_OBIHHMAPMHB != null)
			{
				EasyTouch.m_OBIHHMAPMHB(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_SwipeStart:
			if (EasyTouch.m_NNKJJEOADNH != null)
			{
				EasyTouch.m_NNKJJEOADNH(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_Swipe:
			if (EasyTouch.m_BFJPAIGMIFK != null)
			{
				EasyTouch.m_BFJPAIGMIFK(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_SwipeEnd:
			if (EasyTouch.m_FCOOCIECLGH != null)
			{
				EasyTouch.m_FCOOCIECLGH(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_TouchStart2Fingers:
			if (EasyTouch.m_AFOFMEOAPGI != null)
			{
				EasyTouch.m_AFOFMEOAPGI(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_TouchDown2Fingers:
			if (EasyTouch.m_LIDNACGDMBJ != null)
			{
				EasyTouch.m_LIDNACGDMBJ(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_TouchUp2Fingers:
			if (EasyTouch.m_KOHHHLFLMPO != null)
			{
				EasyTouch.m_KOHHHLFLMPO(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_SimpleTap2Fingers:
			if (EasyTouch.m_GPDOHJDELBC != null)
			{
				EasyTouch.m_GPDOHJDELBC(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_DoubleTap2Fingers:
			if (EasyTouch.m_ONJCBIJOMPK != null)
			{
				EasyTouch.m_ONJCBIJOMPK(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_LongTapStart2Fingers:
			if (EasyTouch.m_PMPDDOODAOA != null)
			{
				EasyTouch.m_PMPDDOODAOA(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_LongTap2Fingers:
			if (EasyTouch.m_ENIOAKLEPLE != null)
			{
				EasyTouch.m_ENIOAKLEPLE(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_LongTapEnd2Fingers:
			if (EasyTouch.m_MCEENHCMNHK != null)
			{
				EasyTouch.m_MCEENHCMNHK(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_Twist:
			if (EasyTouch.m_PMLCMKBEGOG != null)
			{
				EasyTouch.m_PMLCMKBEGOG(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_TwistEnd:
			if (EasyTouch.m_IMAKAFNDAFI != null)
			{
				EasyTouch.m_IMAKAFNDAFI(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_PinchIn:
			if (EasyTouch.m_JCKDDDPAGFN != null)
			{
				EasyTouch.m_JCKDDDPAGFN(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_PinchOut:
			if (EasyTouch.m_LKIMMJPPBBH != null)
			{
				EasyTouch.m_LKIMMJPPBBH(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_PinchEnd:
			if (EasyTouch.m_GNOJBMEKGLH != null)
			{
				EasyTouch.m_GNOJBMEKGLH(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_DragStart2Fingers:
			if (EasyTouch.m_HLENDKFOBNM != null)
			{
				EasyTouch.m_HLENDKFOBNM(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_Drag2Fingers:
			if (EasyTouch.m_AOOLDEJNMCG != null)
			{
				EasyTouch.m_AOOLDEJNMCG(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_DragEnd2Fingers:
			if (EasyTouch.m_GDPGENHMHKO != null)
			{
				EasyTouch.m_GDPGENHMHKO(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_SwipeStart2Fingers:
			if (EasyTouch.m_GOIGCNAENKC != null)
			{
				EasyTouch.m_GOIGCNAENKC(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_Swipe2Fingers:
			if (EasyTouch.m_AFNBBNNEDPC != null)
			{
				EasyTouch.m_AFNBBNNEDPC(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_SwipeEnd2Fingers:
			if (EasyTouch.m_FNMKLMLAAMI != null)
			{
				EasyTouch.m_FNMKLMLAAMI(BMNGEAFPELI);
			}
			break;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_Swipe(EDHLGKJEOCJ ICENKPDOHBK)
	{
		EasyTouch.m_BFJPAIGMIFK = (EDHLGKJEOCJ)Delegate.Remove(EasyTouch.m_BFJPAIGMIFK, ICENKPDOHBK);
	}

	public static void SetEnablePinch(bool EBBBIBCMBAM)
	{
		instance.enablePinch = EBBBIBCMBAM;
	}

	public static float GetMinTwistAngle()
	{
		return instance.minTwistAngle;
	}

	public static float GetlongTapTime()
	{
		return instance.longTapTime;
	}

	[SpecialName]
	public static void PNIEPHCANOI(IKDCGCMIJDF ICENKPDOHBK)
	{
		EasyTouch.m_PMPDDOODAOA = (IKDCGCMIJDF)Delegate.Combine(EasyTouch.m_PMPDDOODAOA, ICENKPDOHBK);
	}

	public static GameObject GetOtherReceiverObject()
	{
		return instance.receiverObject;
	}

	private void GAJCAKAHHDA(int CCPKOHMGDEH, ENHMGALIDNH AMOPEEBFAPD, PLICNHAMCPB ABANNGFHGFP, float NLKHLAAEPBI, AGEGIBIJEOB NNDELMPJFGO, float PBCPPDGGCBA, Vector2 BJGBOGIIFAI)
	{
		if (AMOPEEBFAPD == ENHMGALIDNH.On_TouchStart)
		{
			CELEADGHAHA = FLJCONFKDNH(CCPKOHMGDEH);
		}
		if (AMOPEEBFAPD == ENHMGALIDNH.On_Cancel || AMOPEEBFAPD == ENHMGALIDNH.On_TouchUp)
		{
			CELEADGHAHA = false;
		}
		if (!CELEADGHAHA)
		{
			NLKIHCFELMK nLKIHCFELMK = new NLKIHCFELMK();
			nLKIHCFELMK.NKGNNOMNIKO = ABANNGFHGFP.NKGNNOMNIKO;
			nLKIHCFELMK.OEMOGCPMIGC = ABANNGFHGFP.OEMOGCPMIGC;
			nLKIHCFELMK.CILKPHCEJAM = ABANNGFHGFP.CILKPHCEJAM;
			nLKIHCFELMK.CMGMOJAFLFL = ABANNGFHGFP.CMGMOJAFLFL;
			nLKIHCFELMK.DPALPIFLHBF = ABANNGFHGFP.DPALPIFLHBF;
			nLKIHCFELMK.NLKHLAAEPBI = NLKHLAAEPBI;
			nLKIHCFELMK.OJAOJFBJGAH = ABANNGFHGFP.OJAOJFBJGAH;
			nLKIHCFELMK.NNDELMPJFGO = NNDELMPJFGO;
			nLKIHCFELMK.PBCPPDGGCBA = PBCPPDGGCBA;
			nLKIHCFELMK.BJGBOGIIFAI = BJGBOGIIFAI;
			nLKIHCFELMK.GNNEHMBNGKD = 0f;
			nLKIHCFELMK.OFJKEDEMJGG = 0f;
			nLKIHCFELMK.FAHLIEPIENC = ABANNGFHGFP.OLEKGICMNHH;
			nLKIHCFELMK.BAJFHIHNDOL = receiverObject;
			nLKIHCFELMK.GFNKEFEIFNA = EDIGELNMKAL(CCPKOHMGDEH);
			if (useBroadcastMessage)
			{
				JIGDEFDHIDG(AMOPEEBFAPD, nLKIHCFELMK);
			}
			if (!useBroadcastMessage || isExtension)
			{
				HLOOCDJDMFO(AMOPEEBFAPD, nLKIHCFELMK);
			}
		}
	}

	public static void SetEnable2FingersGesture(bool EBBBIBCMBAM)
	{
		instance.enable2FingersGesture = EBBBIBCMBAM;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_SimpleTap2Fingers(MGGOPHOOEJO ICENKPDOHBK)
	{
		EasyTouch.m_GPDOHJDELBC = (MGGOPHOOEJO)Delegate.Remove(EasyTouch.m_GPDOHJDELBC, ICENKPDOHBK);
	}

	private void OnEnable()
	{
		if (Application.isPlaying && Application.isEditor)
		{
			LGBEBKMCCAH();
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_LongTapEnd2Fingers(EPJLIGMFBCN ICENKPDOHBK)
	{
		EasyTouch.m_MCEENHCMNHK = (EPJLIGMFBCN)Delegate.Remove(EasyTouch.m_MCEENHCMNHK, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_PinchEnd(BMHDECJKIMK ICENKPDOHBK)
	{
		EasyTouch.m_GNOJBMEKGLH = (BMHDECJKIMK)Delegate.Remove(EasyTouch.m_GNOJBMEKGLH, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_Cancel2Fingers(AFNLHEHAJFE ICENKPDOHBK)
	{
		EasyTouch.m_CNECHHONONJ = (AFNLHEHAJFE)Delegate.Remove(EasyTouch.m_CNECHHONONJ, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_DoubleTap(IBKJGPKACOO ICENKPDOHBK)
	{
		EasyTouch.m_CNALFPOJBIK = (IBKJGPKACOO)Delegate.Combine(EasyTouch.m_CNALFPOJBIK, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_TwistEnd(BGFLNJPKPOP ICENKPDOHBK)
	{
		EasyTouch.m_IMAKAFNDAFI = (BGFLNJPKPOP)Delegate.Remove(EasyTouch.m_IMAKAFNDAFI, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_Cancel(LBBNLDGGNIB ICENKPDOHBK)
	{
		EasyTouch.m_IFHDJPNBDJF = (LBBNLDGGNIB)Delegate.Remove(EasyTouch.m_IFHDJPNBDJF, ICENKPDOHBK);
	}

	public static GameObject GetCurrentPickedObject(int NKGNNOMNIKO)
	{
		return instance.LJPAHGBFEPE(instance.MNOJNMOOBFA(NKGNNOMNIKO).CMGMOJAFLFL);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_LongTapEnd(DGEBLAAEJIH ICENKPDOHBK)
	{
		EasyTouch.m_FLKIAEMGMGC = (DGEBLAAEJIH)Delegate.Combine(EasyTouch.m_FLKIAEMGMGC, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_TouchUp2Fingers(JILPOOIIELM ICENKPDOHBK)
	{
		EasyTouch.m_KOHHHLFLMPO = (JILPOOIIELM)Delegate.Remove(EasyTouch.m_KOHHHLFLMPO, ICENKPDOHBK);
	}

	public static float GetSwipeTolerance()
	{
		return instance.swipeTolerance;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_Swipe2Fingers(KHEMMAEPJJB ICENKPDOHBK)
	{
		EasyTouch.m_AFNBBNNEDPC = (KHEMMAEPJJB)Delegate.Remove(EasyTouch.m_AFNBBNNEDPC, ICENKPDOHBK);
	}

	public static int GetTouchCount()
	{
		return instance.ECGCNJMBCGE.PNFBOCJECKM();
	}

	public static Vector2 GetFingerPosition(int NKGNNOMNIKO)
	{
		if (instance.PLOLGPDJALM[NKGNNOMNIKO] != null)
		{
			return instance.MNOJNMOOBFA(NKGNNOMNIKO).CMGMOJAFLFL;
		}
		return Vector2.zero;
	}

	private float IJFFOJHKBOK()
	{
		Vector2 iDFCFEOMBKP = PLOLGPDJALM[MMGHDHKBPAL].CMGMOJAFLFL - PLOLGPDJALM[FGBLDNAOEPN].CMGMOJAFLFL;
		Vector2 gAKOOBECLIB = PLOLGPDJALM[MMGHDHKBPAL].LIMLBJEAAIP - PLOLGPDJALM[FGBLDNAOEPN].LIMLBJEAAIP;
		return 1203f * KAOJBNLPCEN(gAKOOBECLIB, iDFCFEOMBKP);
	}

	public static bool GetEnabled()
	{
		return instance.enable;
	}

	private GameObject LJPAHGBFEPE(Vector2 BMGKBJEIBGL)
	{
		if (easyTouchCamera != null)
		{
			Ray ray = easyTouchCamera.ScreenPointToRay(BMGKBJEIBGL);
			LayerMask layerMask = pickableLayers;
			RaycastHit hitInfo;
			if (Physics.Raycast(ray, out hitInfo, float.MaxValue, layerMask))
			{
				return hitInfo.collider.gameObject;
			}
		}
		else
		{
			Debug.LogWarning("No camera is assigned to EasyTouch");
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_TouchUp(EFLKHCLGDPF ICENKPDOHBK)
	{
		EasyTouch.m_DGEFKKDJLAA = (EFLKHCLGDPF)Delegate.Remove(EasyTouch.m_DGEFKKDJLAA, ICENKPDOHBK);
	}

	public static void SetEnableTwist(bool EBBBIBCMBAM)
	{
		instance.enableTwist = EBBBIBCMBAM;
	}

	private bool EDIGELNMKAL(int CCPKOHMGDEH)
	{
		bool flag = false;
		if (enableReservedArea)
		{
			int num = 0;
			while (!flag && num < reservedAreas.Count)
			{
				Rect realRect = VirtualScreen.GetRealRect(reservedAreas[num]);
				flag = new Rect(realRect.x, (float)Screen.height - realRect.y - realRect.height, realRect.width, realRect.height).Contains(PLOLGPDJALM[CCPKOHMGDEH].CMGMOJAFLFL);
				num++;
			}
		}
		return flag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_DragStart2Fingers(DBEGNAOAHGC ICENKPDOHBK)
	{
		EasyTouch.m_HLENDKFOBNM = (DBEGNAOAHGC)Delegate.Combine(EasyTouch.m_HLENDKFOBNM, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_SwipeEnd2Fingers(OJADGCJCPPJ ICENKPDOHBK)
	{
		EasyTouch.m_FNMKLMLAAMI = (OJADGCJCPPJ)Delegate.Combine(EasyTouch.m_FNMKLMLAAMI, ICENKPDOHBK);
	}

	[SpecialName]
	public static void JADLPABONCA(KHEMMAEPJJB ICENKPDOHBK)
	{
		EasyTouch.m_AFNBBNNEDPC = (KHEMMAEPJJB)Delegate.Remove(EasyTouch.m_AFNBBNNEDPC, ICENKPDOHBK);
	}

	private void Start()
	{
		LGBEBKMCCAH();
	}

	private AGEGIBIJEOB ELPEKFLEKOJ(Vector2 GAKOOBECLIB, Vector2 IDFCFEOMBKP)
	{
		Vector2 normalized = (IDFCFEOMBKP - GAKOOBECLIB).normalized;
		if (Mathf.Abs(normalized.y) > Mathf.Abs(normalized.x))
		{
			if (Vector2.Dot(normalized, Vector2.up) >= swipeTolerance)
			{
				return AGEGIBIJEOB.Up;
			}
			if (Vector2.Dot(normalized, -Vector2.up) >= swipeTolerance)
			{
				return AGEGIBIJEOB.Down;
			}
		}
		else
		{
			if (Vector2.Dot(normalized, Vector2.right) >= swipeTolerance)
			{
				return AGEGIBIJEOB.Right;
			}
			if (Vector2.Dot(normalized, -Vector2.right) >= swipeTolerance)
			{
				return AGEGIBIJEOB.Left;
			}
		}
		return AGEGIBIJEOB.Other;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_TouchStart2Fingers(DPNDKKBILNP ICENKPDOHBK)
	{
		EasyTouch.m_AFOFMEOAPGI = (DPNDKKBILNP)Delegate.Combine(EasyTouch.m_AFOFMEOAPGI, ICENKPDOHBK);
	}

	private void LGBEBKMCCAH()
	{
		ECGCNJMBCGE = new PLMFGMBFIAN();
		if (instance == null)
		{
			instance = this;
		}
		if (easyTouchCamera == null)
		{
			easyTouchCamera = Camera.main;
			if (easyTouchCamera == null && autoSelect)
			{
				Debug.LogWarning("No camera with flag \"MainCam\" was found in the scene, please setup the camera");
			}
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_TouchDown(NMENLGCLDKB ICENKPDOHBK)
	{
		EasyTouch.m_FEOACGMPIOG = (NMENLGCLDKB)Delegate.Remove(EasyTouch.m_FEOACGMPIOG, ICENKPDOHBK);
	}

	private void GPFFCFGJPCA(ENHMGALIDNH PBONLONLGLE, NLKIHCFELMK BMNGEAFPELI)
	{
		switch (PBONLONLGLE)
		{
		case ENHMGALIDNH.None:
			if (EasyTouch.m_IFHDJPNBDJF != null)
			{
				EasyTouch.m_IFHDJPNBDJF(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_Cancel:
			if (EasyTouch.m_CNECHHONONJ != null)
			{
				EasyTouch.m_CNECHHONONJ(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_Cancel2Fingers:
			if (EasyTouch.m_FHBOBAEJJFP != null)
			{
				EasyTouch.m_FHBOBAEJJFP(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_TouchStart:
			if (EasyTouch.m_FEOACGMPIOG != null)
			{
				EasyTouch.m_FEOACGMPIOG(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_TouchDown:
			if (EasyTouch.m_DGEFKKDJLAA != null)
			{
				EasyTouch.m_DGEFKKDJLAA(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_TouchUp:
			if (EasyTouch.m_KPMBACFCALN != null)
			{
				EasyTouch.m_KPMBACFCALN(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_SimpleTap:
			if (EasyTouch.m_CNALFPOJBIK != null)
			{
				EasyTouch.m_CNALFPOJBIK(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_DoubleTap:
			if (EasyTouch.m_FNOKPPHHPMM != null)
			{
				EasyTouch.m_FNOKPPHHPMM(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_LongTapStart:
			if (EasyTouch.m_EFGICDIIKAM != null)
			{
				EasyTouch.m_EFGICDIIKAM(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_LongTap:
			if (EasyTouch.m_FLKIAEMGMGC != null)
			{
				EasyTouch.m_FLKIAEMGMGC(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_LongTapEnd:
			if (EasyTouch.m_KGOCCEIIBFE != null)
			{
				EasyTouch.m_KGOCCEIIBFE(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_DragStart:
			if (EasyTouch.m_KAFHFMGMJBB != null)
			{
				EasyTouch.m_KAFHFMGMJBB(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_Drag:
			if (EasyTouch.m_OBIHHMAPMHB != null)
			{
				EasyTouch.m_OBIHHMAPMHB(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_DragEnd:
			if (EasyTouch.m_NNKJJEOADNH != null)
			{
				EasyTouch.m_NNKJJEOADNH(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_SwipeStart:
			if (EasyTouch.m_BFJPAIGMIFK != null)
			{
				EasyTouch.m_BFJPAIGMIFK(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_Swipe:
			if (EasyTouch.m_FCOOCIECLGH != null)
			{
				EasyTouch.m_FCOOCIECLGH(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_SwipeEnd:
			if (EasyTouch.m_AFOFMEOAPGI != null)
			{
				EasyTouch.m_AFOFMEOAPGI(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_TouchStart2Fingers:
			if (EasyTouch.m_LIDNACGDMBJ != null)
			{
				EasyTouch.m_LIDNACGDMBJ(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_TouchDown2Fingers:
			if (EasyTouch.m_KOHHHLFLMPO != null)
			{
				EasyTouch.m_KOHHHLFLMPO(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_TouchUp2Fingers:
			if (EasyTouch.m_GPDOHJDELBC != null)
			{
				EasyTouch.m_GPDOHJDELBC(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_SimpleTap2Fingers:
			if (EasyTouch.m_ONJCBIJOMPK != null)
			{
				EasyTouch.m_ONJCBIJOMPK(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_DoubleTap2Fingers:
			if (EasyTouch.m_PMPDDOODAOA != null)
			{
				EasyTouch.m_PMPDDOODAOA(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_LongTapStart2Fingers:
			if (EasyTouch.m_ENIOAKLEPLE != null)
			{
				EasyTouch.m_ENIOAKLEPLE(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_LongTap2Fingers:
			if (EasyTouch.m_MCEENHCMNHK != null)
			{
				EasyTouch.m_MCEENHCMNHK(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_LongTapEnd2Fingers:
			if (EasyTouch.m_PMLCMKBEGOG != null)
			{
				EasyTouch.m_PMLCMKBEGOG(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_Twist:
			if (EasyTouch.m_IMAKAFNDAFI != null)
			{
				EasyTouch.m_IMAKAFNDAFI(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_TwistEnd:
			if (EasyTouch.m_JCKDDDPAGFN != null)
			{
				EasyTouch.m_JCKDDDPAGFN(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_PinchIn:
			if (EasyTouch.m_LKIMMJPPBBH != null)
			{
				EasyTouch.m_LKIMMJPPBBH(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_PinchOut:
			if (EasyTouch.m_GNOJBMEKGLH != null)
			{
				EasyTouch.m_GNOJBMEKGLH(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_PinchEnd:
			if (EasyTouch.m_HLENDKFOBNM != null)
			{
				EasyTouch.m_HLENDKFOBNM(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_DragStart2Fingers:
			if (EasyTouch.m_AOOLDEJNMCG != null)
			{
				EasyTouch.m_AOOLDEJNMCG(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_Drag2Fingers:
			if (EasyTouch.m_GDPGENHMHKO != null)
			{
				EasyTouch.m_GDPGENHMHKO(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_DragEnd2Fingers:
			if (EasyTouch.m_GOIGCNAENKC != null)
			{
				EasyTouch.m_GOIGCNAENKC(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_SwipeStart2Fingers:
			if (EasyTouch.m_AFNBBNNEDPC != null)
			{
				EasyTouch.m_AFNBBNNEDPC(BMNGEAFPELI);
			}
			break;
		case ENHMGALIDNH.On_Swipe2Fingers:
			if (EasyTouch.m_FNMKLMLAAMI != null)
			{
				EasyTouch.m_FNMKLMLAAMI(BMNGEAFPELI);
			}
			break;
		}
	}

	public static void ResetTouch(int NKGNNOMNIKO)
	{
		instance.MNOJNMOOBFA(NKGNNOMNIKO).BMNGEAFPELI = ANGFCINKJKK.None;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_LongTapEnd2Fingers(EPJLIGMFBCN ICENKPDOHBK)
	{
		EasyTouch.m_MCEENHCMNHK = (EPJLIGMFBCN)Delegate.Combine(EasyTouch.m_MCEENHCMNHK, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_Swipe(EDHLGKJEOCJ ICENKPDOHBK)
	{
		EasyTouch.m_BFJPAIGMIFK = (EDHLGKJEOCJ)Delegate.Combine(EasyTouch.m_BFJPAIGMIFK, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_SwipeStart2Fingers(JGDFHDDCEHO ICENKPDOHBK)
	{
		EasyTouch.m_GOIGCNAENKC = (JGDFHDDCEHO)Delegate.Remove(EasyTouch.m_GOIGCNAENKC, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_SimpleTap(IBFFAOEHFHF ICENKPDOHBK)
	{
		EasyTouch.m_KPMBACFCALN = (IBFFAOEHFHF)Delegate.Combine(EasyTouch.m_KPMBACFCALN, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_DragEnd2Fingers(FGNOPNHNCEK ICENKPDOHBK)
	{
		EasyTouch.m_GDPGENHMHKO = (FGNOPNHNCEK)Delegate.Combine(EasyTouch.m_GDPGENHMHKO, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_Drag(HLHOPCNBCMM ICENKPDOHBK)
	{
		EasyTouch.m_KAFHFMGMJBB = (HLHOPCNBCMM)Delegate.Remove(EasyTouch.m_KAFHFMGMJBB, ICENKPDOHBK);
	}

	private void GBLNBBBEDCD()
	{
		for (int i = 0; i < 10; i++)
		{
			PLOLGPDJALM[i] = null;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_TouchDown(NMENLGCLDKB ICENKPDOHBK)
	{
		EasyTouch.m_FEOACGMPIOG = (NMENLGCLDKB)Delegate.Combine(EasyTouch.m_FEOACGMPIOG, ICENKPDOHBK);
	}

	public static bool GetEnableAutoSelect()
	{
		return instance.autoSelect;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_DoubleTap2Fingers(DCHFDJEFKDP ICENKPDOHBK)
	{
		EasyTouch.m_ONJCBIJOMPK = (DCHFDJEFKDP)Delegate.Combine(EasyTouch.m_ONJCBIJOMPK, ICENKPDOHBK);
	}

	public static bool GetIsReservedArea()
	{
		return instance.enableReservedArea;
	}

	private void CIDLIEKPJCC(bool EPCEILLIDLN, int OEMOGCPMIGC)
	{
		for (int i = 0; i < DDAECCGKOBM.Length; i++)
		{
			DDAECCGKOBM[i] = null;
		}
		PLOLGPDJALM.CopyTo(DDAECCGKOBM, 0);
		if (EPCEILLIDLN || enableRemote)
		{
			GBLNBBBEDCD();
			for (int j = 0; j < OEMOGCPMIGC; j++)
			{
				Touch touch = Input.GetTouch(j);
				for (int k = 0; k < 10; k++)
				{
					if (PLOLGPDJALM[j] != null)
					{
						break;
					}
					if (DDAECCGKOBM[k] != null && DDAECCGKOBM[k].NKGNNOMNIKO == touch.fingerId)
					{
						PLOLGPDJALM[j] = DDAECCGKOBM[k];
					}
				}
				if (PLOLGPDJALM[j] == null)
				{
					PLOLGPDJALM[j] = new PLICNHAMCPB();
					PLOLGPDJALM[j].NKGNNOMNIKO = touch.fingerId;
					PLOLGPDJALM[j].BMNGEAFPELI = ANGFCINKJKK.None;
					PLOLGPDJALM[j].ELDOMOEIAJI = TouchPhase.Began;
				}
				else
				{
					PLOLGPDJALM[j].ELDOMOEIAJI = touch.phase;
				}
				PLOLGPDJALM[j].CMGMOJAFLFL = touch.position;
				PLOLGPDJALM[j].DPALPIFLHBF = touch.deltaPosition;
				PLOLGPDJALM[j].CNHAAHEDDPC = touch.tapCount;
				PLOLGPDJALM[j].OJAOJFBJGAH = touch.deltaTime;
				PLOLGPDJALM[j].OEMOGCPMIGC = OEMOGCPMIGC;
			}
		}
		else
		{
			for (int l = 0; l < OEMOGCPMIGC; l++)
			{
				PLOLGPDJALM[l] = ECGCNJMBCGE.LDDNOHGCLPE(l, PLOLGPDJALM[l]);
				PLOLGPDJALM[l].OEMOGCPMIGC = OEMOGCPMIGC;
			}
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_DragStart(GNNNGJGHIPJ ICENKPDOHBK)
	{
		EasyTouch.m_KGOCCEIIBFE = (GNNNGJGHIPJ)Delegate.Remove(EasyTouch.m_KGOCCEIIBFE, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_LongTapStart2Fingers(IKDCGCMIJDF ICENKPDOHBK)
	{
		EasyTouch.m_PMPDDOODAOA = (IKDCGCMIJDF)Delegate.Combine(EasyTouch.m_PMPDDOODAOA, ICENKPDOHBK);
	}

	public static float GetMinPinchLength()
	{
		return instance.minPinchLength;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_TouchStart(OKGKIGCPDJH ICENKPDOHBK)
	{
		EasyTouch.m_FHBOBAEJJFP = (OKGKIGCPDJH)Delegate.Combine(EasyTouch.m_FHBOBAEJJFP, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_SwipeEnd(BODJDOPJAGI ICENKPDOHBK)
	{
		EasyTouch.m_FCOOCIECLGH = (BODJDOPJAGI)Delegate.Combine(EasyTouch.m_FCOOCIECLGH, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_DragEnd(LEFJKFOPOAG ICENKPDOHBK)
	{
		EasyTouch.m_OBIHHMAPMHB = (LEFJKFOPOAG)Delegate.Combine(EasyTouch.m_OBIHHMAPMHB, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_TouchUp(EFLKHCLGDPF ICENKPDOHBK)
	{
		EasyTouch.m_DGEFKKDJLAA = (EFLKHCLGDPF)Delegate.Combine(EasyTouch.m_DGEFKKDJLAA, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_Swipe2Fingers(KHEMMAEPJJB ICENKPDOHBK)
	{
		EasyTouch.m_AFNBBNNEDPC = (KHEMMAEPJJB)Delegate.Combine(EasyTouch.m_AFNBBNNEDPC, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_DoubleTap2Fingers(DCHFDJEFKDP ICENKPDOHBK)
	{
		EasyTouch.m_ONJCBIJOMPK = (DCHFDJEFKDP)Delegate.Remove(EasyTouch.m_ONJCBIJOMPK, ICENKPDOHBK);
	}

	private bool NBJPAKJNJNJ(PLICNHAMCPB ABANNGFHGFP)
	{
		if ((ABANNGFHGFP.CMGMOJAFLFL - ABANNGFHGFP.CILKPHCEJAM).sqrMagnitude <= StationnaryTolerance * StationnaryTolerance)
		{
			return true;
		}
		return false;
	}

	private void PBAAOIACNEE(ENHMGALIDNH AMOPEEBFAPD, Vector2 CILKPHCEJAM, Vector2 CMGMOJAFLFL, Vector2 DPALPIFLHBF, float NLKHLAAEPBI, AGEGIBIJEOB NNDELMPJFGO, float PBCPPDGGCBA, Vector2 BJGBOGIIFAI, float BNIJAPJPHDK, float HLIIKBOPBKL, float JIMBJHFMGHI)
	{
		if (AMOPEEBFAPD == ENHMGALIDNH.On_TouchStart2Fingers)
		{
			CELEADGHAHA = FLJCONFKDNH(FGBLDNAOEPN) & FLJCONFKDNH(MMGHDHKBPAL);
		}
		if (!CELEADGHAHA)
		{
			NLKIHCFELMK nLKIHCFELMK = new NLKIHCFELMK();
			nLKIHCFELMK.OEMOGCPMIGC = 2;
			nLKIHCFELMK.NKGNNOMNIKO = -1;
			nLKIHCFELMK.CILKPHCEJAM = CILKPHCEJAM;
			nLKIHCFELMK.CMGMOJAFLFL = CMGMOJAFLFL;
			nLKIHCFELMK.DPALPIFLHBF = DPALPIFLHBF;
			nLKIHCFELMK.NLKHLAAEPBI = NLKHLAAEPBI;
			if (PLOLGPDJALM[MMGHDHKBPAL] != null)
			{
				nLKIHCFELMK.OJAOJFBJGAH = PLOLGPDJALM[MMGHDHKBPAL].OJAOJFBJGAH;
			}
			else if (PLOLGPDJALM[FGBLDNAOEPN] != null)
			{
				nLKIHCFELMK.OJAOJFBJGAH = PLOLGPDJALM[FGBLDNAOEPN].OJAOJFBJGAH;
			}
			else
			{
				nLKIHCFELMK.OJAOJFBJGAH = 0f;
			}
			nLKIHCFELMK.NNDELMPJFGO = NNDELMPJFGO;
			nLKIHCFELMK.PBCPPDGGCBA = PBCPPDGGCBA;
			nLKIHCFELMK.BJGBOGIIFAI = BJGBOGIIFAI;
			nLKIHCFELMK.GNNEHMBNGKD = HLIIKBOPBKL;
			nLKIHCFELMK.OFJKEDEMJGG = BNIJAPJPHDK;
			nLKIHCFELMK.EHKPPINOHKI = JIMBJHFMGHI;
			if (AMOPEEBFAPD != ENHMGALIDNH.On_Cancel2Fingers)
			{
				nLKIHCFELMK.FAHLIEPIENC = MLONCPAOCCP;
			}
			else
			{
				nLKIHCFELMK.FAHLIEPIENC = ALCDBNDHBMG;
			}
			nLKIHCFELMK.BAJFHIHNDOL = receiverObject;
			if (useBroadcastMessage)
			{
				MDIKJNDBEHC(AMOPEEBFAPD, nLKIHCFELMK);
			}
			else
			{
				HLOOCDJDMFO(AMOPEEBFAPD, nLKIHCFELMK);
			}
		}
	}

	public static bool GetEnablePinch()
	{
		return instance.enablePinch;
	}

	public static void SetMinTwistAngle(float IINELJPKNBN)
	{
		instance.minTwistAngle = IINELJPKNBN;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_SimpleTap2Fingers(MGGOPHOOEJO ICENKPDOHBK)
	{
		EasyTouch.m_GPDOHJDELBC = (MGGOPHOOEJO)Delegate.Combine(EasyTouch.m_GPDOHJDELBC, ICENKPDOHBK);
	}

	public static void SetEnabled(bool EBBBIBCMBAM)
	{
		instance.enable = EBBBIBCMBAM;
		if (EBBBIBCMBAM)
		{
			instance.GBLNBBBEDCD();
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_LongTap2Fingers(JKAGCEOLDMF ICENKPDOHBK)
	{
		EasyTouch.m_ENIOAKLEPLE = (JKAGCEOLDMF)Delegate.Combine(EasyTouch.m_ENIOAKLEPLE, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_PinchIn(DLMHEJNJGHF ICENKPDOHBK)
	{
		EasyTouch.m_JCKDDDPAGFN = (DLMHEJNJGHF)Delegate.Combine(EasyTouch.m_JCKDDDPAGFN, ICENKPDOHBK);
	}

	[SpecialName]
	public static void BJLEJCKEKMC(FGNOPNHNCEK ICENKPDOHBK)
	{
		EasyTouch.m_GDPGENHMHKO = (FGNOPNHNCEK)Delegate.Combine(EasyTouch.m_GDPGENHMHKO, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_SwipeEnd2Fingers(OJADGCJCPPJ ICENKPDOHBK)
	{
		EasyTouch.m_FNMKLMLAAMI = (OJADGCJCPPJ)Delegate.Remove(EasyTouch.m_FNMKLMLAAMI, ICENKPDOHBK);
	}

	private void IEBCLGMIJPJ(int NKGNNOMNIKO)
	{
		float num = 0f;
		if (PLOLGPDJALM[NKGNNOMNIKO].BMNGEAFPELI == ANGFCINKJKK.None)
		{
			GNLIGBBILPG = Time.realtimeSinceStartup;
			PLOLGPDJALM[NKGNNOMNIKO].BMNGEAFPELI = ANGFCINKJKK.Acquisition;
			PLOLGPDJALM[NKGNNOMNIKO].CILKPHCEJAM = PLOLGPDJALM[NKGNNOMNIKO].CMGMOJAFLFL;
			if (autoSelect)
			{
				PLOLGPDJALM[NKGNNOMNIKO].OLEKGICMNHH = LJPAHGBFEPE(PLOLGPDJALM[NKGNNOMNIKO].CILKPHCEJAM);
			}
			GAJCAKAHHDA(NKGNNOMNIKO, ENHMGALIDNH.On_TouchStart, PLOLGPDJALM[NKGNNOMNIKO], 0f, AGEGIBIJEOB.None, 0f, Vector2.zero);
		}
		num = Time.realtimeSinceStartup - GNLIGBBILPG;
		if (PLOLGPDJALM[NKGNNOMNIKO].ELDOMOEIAJI == TouchPhase.Canceled)
		{
			PLOLGPDJALM[NKGNNOMNIKO].BMNGEAFPELI = ANGFCINKJKK.Cancel;
		}
		if (PLOLGPDJALM[NKGNNOMNIKO].ELDOMOEIAJI != TouchPhase.Ended && PLOLGPDJALM[NKGNNOMNIKO].ELDOMOEIAJI != TouchPhase.Canceled)
		{
			if (PLOLGPDJALM[NKGNNOMNIKO].ELDOMOEIAJI == TouchPhase.Stationary && num >= longTapTime && PLOLGPDJALM[NKGNNOMNIKO].BMNGEAFPELI == ANGFCINKJKK.Acquisition)
			{
				PLOLGPDJALM[NKGNNOMNIKO].BMNGEAFPELI = ANGFCINKJKK.LongTap;
				GAJCAKAHHDA(NKGNNOMNIKO, ENHMGALIDNH.On_LongTapStart, PLOLGPDJALM[NKGNNOMNIKO], num, AGEGIBIJEOB.None, 0f, Vector2.zero);
			}
			if ((PLOLGPDJALM[NKGNNOMNIKO].BMNGEAFPELI == ANGFCINKJKK.Acquisition || PLOLGPDJALM[NKGNNOMNIKO].BMNGEAFPELI == ANGFCINKJKK.LongTap) && !NBJPAKJNJNJ(PLOLGPDJALM[NKGNNOMNIKO]))
			{
				if (PLOLGPDJALM[NKGNNOMNIKO].BMNGEAFPELI == ANGFCINKJKK.LongTap)
				{
					PLOLGPDJALM[NKGNNOMNIKO].BMNGEAFPELI = ANGFCINKJKK.Cancel;
					GAJCAKAHHDA(NKGNNOMNIKO, ENHMGALIDNH.On_LongTapEnd, PLOLGPDJALM[NKGNNOMNIKO], num, AGEGIBIJEOB.None, 0f, Vector2.zero);
					PLOLGPDJALM[NKGNNOMNIKO].BMNGEAFPELI = ANGFCINKJKK.None;
				}
				else if ((bool)PLOLGPDJALM[NKGNNOMNIKO].OLEKGICMNHH)
				{
					PLOLGPDJALM[NKGNNOMNIKO].BMNGEAFPELI = ANGFCINKJKK.Drag;
					GAJCAKAHHDA(NKGNNOMNIKO, ENHMGALIDNH.On_DragStart, PLOLGPDJALM[NKGNNOMNIKO], num, AGEGIBIJEOB.None, 0f, Vector2.zero);
				}
				else
				{
					PLOLGPDJALM[NKGNNOMNIKO].BMNGEAFPELI = ANGFCINKJKK.Swipe;
					GAJCAKAHHDA(NKGNNOMNIKO, ENHMGALIDNH.On_SwipeStart, PLOLGPDJALM[NKGNNOMNIKO], num, AGEGIBIJEOB.None, 0f, Vector2.zero);
				}
			}
			ENHMGALIDNH eNHMGALIDNH = ENHMGALIDNH.None;
			switch (PLOLGPDJALM[NKGNNOMNIKO].BMNGEAFPELI)
			{
			case ANGFCINKJKK.LongTap:
				eNHMGALIDNH = ENHMGALIDNH.On_LongTap;
				break;
			case ANGFCINKJKK.Drag:
				eNHMGALIDNH = ENHMGALIDNH.On_Drag;
				break;
			case ANGFCINKJKK.Swipe:
				eNHMGALIDNH = ENHMGALIDNH.On_Swipe;
				break;
			}
			AGEGIBIJEOB nNDELMPJFGO = AGEGIBIJEOB.None;
			if (eNHMGALIDNH != ENHMGALIDNH.None)
			{
				nNDELMPJFGO = ELPEKFLEKOJ(new Vector2(0f, 0f), PLOLGPDJALM[NKGNNOMNIKO].DPALPIFLHBF);
				GAJCAKAHHDA(NKGNNOMNIKO, eNHMGALIDNH, PLOLGPDJALM[NKGNNOMNIKO], num, nNDELMPJFGO, 0f, PLOLGPDJALM[NKGNNOMNIKO].DPALPIFLHBF);
			}
			GAJCAKAHHDA(NKGNNOMNIKO, ENHMGALIDNH.On_TouchDown, PLOLGPDJALM[NKGNNOMNIKO], num, nNDELMPJFGO, 0f, PLOLGPDJALM[NKGNNOMNIKO].DPALPIFLHBF);
			return;
		}
		bool flag = true;
		switch (PLOLGPDJALM[NKGNNOMNIKO].BMNGEAFPELI)
		{
		case ANGFCINKJKK.Acquisition:
		{
			if (NBJPAKJNJNJ(PLOLGPDJALM[NKGNNOMNIKO]))
			{
				if (PLOLGPDJALM[NKGNNOMNIKO].CNHAAHEDDPC < 2)
				{
					GAJCAKAHHDA(NKGNNOMNIKO, ENHMGALIDNH.On_SimpleTap, PLOLGPDJALM[NKGNNOMNIKO], num, AGEGIBIJEOB.None, 0f, Vector2.zero);
				}
				else
				{
					GAJCAKAHHDA(NKGNNOMNIKO, ENHMGALIDNH.On_DoubleTap, PLOLGPDJALM[NKGNNOMNIKO], num, AGEGIBIJEOB.None, 0f, Vector2.zero);
				}
				break;
			}
			AGEGIBIJEOB nNDELMPJFGO2 = ELPEKFLEKOJ(new Vector2(0f, 0f), PLOLGPDJALM[NKGNNOMNIKO].DPALPIFLHBF);
			if ((bool)PLOLGPDJALM[NKGNNOMNIKO].OLEKGICMNHH)
			{
				GAJCAKAHHDA(NKGNNOMNIKO, ENHMGALIDNH.On_DragStart, PLOLGPDJALM[NKGNNOMNIKO], num, AGEGIBIJEOB.None, 0f, Vector2.zero);
				GAJCAKAHHDA(NKGNNOMNIKO, ENHMGALIDNH.On_Drag, PLOLGPDJALM[NKGNNOMNIKO], num, nNDELMPJFGO2, 0f, PLOLGPDJALM[NKGNNOMNIKO].DPALPIFLHBF);
				GAJCAKAHHDA(NKGNNOMNIKO, ENHMGALIDNH.On_DragEnd, PLOLGPDJALM[NKGNNOMNIKO], num, ELPEKFLEKOJ(PLOLGPDJALM[NKGNNOMNIKO].CILKPHCEJAM, PLOLGPDJALM[NKGNNOMNIKO].CMGMOJAFLFL), (PLOLGPDJALM[NKGNNOMNIKO].CILKPHCEJAM - PLOLGPDJALM[NKGNNOMNIKO].CMGMOJAFLFL).magnitude, PLOLGPDJALM[NKGNNOMNIKO].CMGMOJAFLFL - PLOLGPDJALM[NKGNNOMNIKO].CILKPHCEJAM);
			}
			else
			{
				GAJCAKAHHDA(NKGNNOMNIKO, ENHMGALIDNH.On_SwipeStart, PLOLGPDJALM[NKGNNOMNIKO], num, AGEGIBIJEOB.None, 0f, Vector2.zero);
				GAJCAKAHHDA(NKGNNOMNIKO, ENHMGALIDNH.On_Swipe, PLOLGPDJALM[NKGNNOMNIKO], num, nNDELMPJFGO2, 0f, PLOLGPDJALM[NKGNNOMNIKO].DPALPIFLHBF);
				GAJCAKAHHDA(NKGNNOMNIKO, ENHMGALIDNH.On_SwipeEnd, PLOLGPDJALM[NKGNNOMNIKO], num, ELPEKFLEKOJ(PLOLGPDJALM[NKGNNOMNIKO].CILKPHCEJAM, PLOLGPDJALM[NKGNNOMNIKO].CMGMOJAFLFL), (PLOLGPDJALM[NKGNNOMNIKO].CMGMOJAFLFL - PLOLGPDJALM[NKGNNOMNIKO].CILKPHCEJAM).magnitude, PLOLGPDJALM[NKGNNOMNIKO].CMGMOJAFLFL - PLOLGPDJALM[NKGNNOMNIKO].CILKPHCEJAM);
			}
			break;
		}
		case ANGFCINKJKK.LongTap:
			GAJCAKAHHDA(NKGNNOMNIKO, ENHMGALIDNH.On_LongTapEnd, PLOLGPDJALM[NKGNNOMNIKO], num, AGEGIBIJEOB.None, 0f, Vector2.zero);
			break;
		case ANGFCINKJKK.Drag:
			GAJCAKAHHDA(NKGNNOMNIKO, ENHMGALIDNH.On_DragEnd, PLOLGPDJALM[NKGNNOMNIKO], num, ELPEKFLEKOJ(PLOLGPDJALM[NKGNNOMNIKO].CILKPHCEJAM, PLOLGPDJALM[NKGNNOMNIKO].CMGMOJAFLFL), (PLOLGPDJALM[NKGNNOMNIKO].CILKPHCEJAM - PLOLGPDJALM[NKGNNOMNIKO].CMGMOJAFLFL).magnitude, PLOLGPDJALM[NKGNNOMNIKO].CMGMOJAFLFL - PLOLGPDJALM[NKGNNOMNIKO].CILKPHCEJAM);
			break;
		case ANGFCINKJKK.Swipe:
			GAJCAKAHHDA(NKGNNOMNIKO, ENHMGALIDNH.On_SwipeEnd, PLOLGPDJALM[NKGNNOMNIKO], num, ELPEKFLEKOJ(PLOLGPDJALM[NKGNNOMNIKO].CILKPHCEJAM, PLOLGPDJALM[NKGNNOMNIKO].CMGMOJAFLFL), (PLOLGPDJALM[NKGNNOMNIKO].CMGMOJAFLFL - PLOLGPDJALM[NKGNNOMNIKO].CILKPHCEJAM).magnitude, PLOLGPDJALM[NKGNNOMNIKO].CMGMOJAFLFL - PLOLGPDJALM[NKGNNOMNIKO].CILKPHCEJAM);
			break;
		case ANGFCINKJKK.Cancel:
			GAJCAKAHHDA(NKGNNOMNIKO, ENHMGALIDNH.On_Cancel, PLOLGPDJALM[NKGNNOMNIKO], 0f, AGEGIBIJEOB.None, 0f, Vector2.zero);
			break;
		}
		if (flag)
		{
			GAJCAKAHHDA(NKGNNOMNIKO, ENHMGALIDNH.On_TouchUp, PLOLGPDJALM[NKGNNOMNIKO], num, AGEGIBIJEOB.None, 0f, Vector2.zero);
			PLOLGPDJALM[NKGNNOMNIKO] = null;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_Cancel2Fingers(AFNLHEHAJFE ICENKPDOHBK)
	{
		EasyTouch.m_CNECHHONONJ = (AFNLHEHAJFE)Delegate.Combine(EasyTouch.m_CNECHHONONJ, ICENKPDOHBK);
	}

	private void Update()
	{
		if (!enable || !(instance == this))
		{
			return;
		}
		int num = ECGCNJMBCGE.PNFBOCJECKM();
		if (num > 10)
		{
			num = 10;
		}
		if (PEFPPBKIKEI == 2 && num != 2 && num > 0)
		{
			PBAAOIACNEE(ENHMGALIDNH.On_Cancel2Fingers, Vector2.zero, Vector2.zero, Vector2.zero, 0f, AGEGIBIJEOB.None, 0f, Vector2.zero, 0f, 0f, 0f);
		}
		CIDLIEKPJCC(true, num);
		ALCDBNDHBMG = MLONCPAOCCP;
		if (enable2FingersGesture)
		{
			if (num == 2)
			{
				CECDHGOIPGB();
			}
			else
			{
				DJPLIMLLFFO = ANGFCINKJKK.None;
				MLONCPAOCCP = null;
				PIKLMCJOIKH = false;
				DIEMDCBFHDC = false;
			}
		}
		for (int i = 0; i < 10; i++)
		{
			if (PLOLGPDJALM[i] != null)
			{
				IEBCLGMIJPJ(i);
			}
		}
		PEFPPBKIKEI = num;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_SwipeEnd(BODJDOPJAGI ICENKPDOHBK)
	{
		EasyTouch.m_FCOOCIECLGH = (BODJDOPJAGI)Delegate.Remove(EasyTouch.m_FCOOCIECLGH, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_DragEnd(LEFJKFOPOAG ICENKPDOHBK)
	{
		EasyTouch.m_OBIHHMAPMHB = (LEFJKFOPOAG)Delegate.Remove(EasyTouch.m_OBIHHMAPMHB, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_TwistEnd(BGFLNJPKPOP ICENKPDOHBK)
	{
		EasyTouch.m_IMAKAFNDAFI = (BGFLNJPKPOP)Delegate.Combine(EasyTouch.m_IMAKAFNDAFI, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_TouchUp2Fingers(JILPOOIIELM ICENKPDOHBK)
	{
		EasyTouch.m_KOHHHLFLMPO = (JILPOOIIELM)Delegate.Combine(EasyTouch.m_KOHHHLFLMPO, ICENKPDOHBK);
	}

	public static void AddReservedArea(Rect BDDDNKEFMHN)
	{
		instance.reservedAreas.Add(BDDDNKEFMHN);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_PinchEnd(BMHDECJKIMK ICENKPDOHBK)
	{
		EasyTouch.m_GNOJBMEKGLH = (BMHDECJKIMK)Delegate.Combine(EasyTouch.m_GNOJBMEKGLH, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_PinchIn(DLMHEJNJGHF ICENKPDOHBK)
	{
		EasyTouch.m_JCKDDDPAGFN = (DLMHEJNJGHF)Delegate.Remove(EasyTouch.m_JCKDDDPAGFN, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_TouchStart(OKGKIGCPDJH ICENKPDOHBK)
	{
		EasyTouch.m_FHBOBAEJJFP = (OKGKIGCPDJH)Delegate.Remove(EasyTouch.m_FHBOBAEJJFP, ICENKPDOHBK);
	}
}
