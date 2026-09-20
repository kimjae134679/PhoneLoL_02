using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(Camera))]
[AddComponentMenu("NGUI/Interaction/Draggable Camera")]
public class UIDraggableCamera : MonoBehaviour
{
	public Transform rootForBounds;

	public Vector2 scale = Vector2.one;

	public float scrollWheelFactor;

	public UIDragObject.FCDDKLAOAOD dragEffect = UIDragObject.FCDDKLAOAOD.MomentumAndSpring;

	public bool smoothDragStart = true;

	public float momentumAmount = 35f;

	private Camera OJNOBHMOJEG;

	private Transform NPLHCHNGMKF;

	private bool DOOIJMHCDAJ;

	private Vector2 JFJOCIKCCPI = Vector2.zero;

	private Bounds OMJLGNBILHK;

	private float GDADJFAGHMK;

	private UIRoot ONNMDGOJEBB;

	private bool NDLCPNHAPGB;

	public Vector2 JAKDLEAOIBI
	{
		get
		{
			return get_currentMomentum();
		}
		set
		{
			set_currentMomentum(value);
		}
	}

	private void FOGNMJLPHAI()
	{
		ONNMDGOJEBB = NLDABIMKKMP.ANPDHFFNJFD<UIRoot>(base.gameObject);
	}

	private void IJCPEFOBKHO()
	{
		ONNMDGOJEBB = NLDABIMKKMP.ANPDHFFNJFD<UIRoot>(base.gameObject);
	}

	[SpecialName]
	public void OCMMAPKJNHG(Vector2 ICENKPDOHBK)
	{
		JFJOCIKCCPI = ICENKPDOHBK;
	}

	private Vector3 PLEMPBNOHEI()
	{
		if (rootForBounds == null || rootForBounds.childCount == 0)
		{
			return Vector3.zero;
		}
		Vector3 position = new Vector3(OJNOBHMOJEG.rect.xMin * (float)Screen.width, OJNOBHMOJEG.rect.yMin * (float)Screen.height, 1358f);
		Vector3 position2 = new Vector3(OJNOBHMOJEG.rect.xMax * (float)Screen.width, OJNOBHMOJEG.rect.yMax * (float)Screen.height, 1504f);
		position = OJNOBHMOJEG.ScreenToWorldPoint(position);
		position2 = OJNOBHMOJEG.ScreenToWorldPoint(position2);
		Vector2 hCFEAFBPEKE = new Vector2(OMJLGNBILHK.min.x, OMJLGNBILHK.min.y);
		Vector2 hBPCPGFEACJ = new Vector2(OMJLGNBILHK.max.x, OMJLGNBILHK.max.y);
		return HHAINCPODGE.HGFCFKHEOHJ(hCFEAFBPEKE, hBPCPGFEACJ, position, position2);
	}

	private void Update()
	{
		float deltaTime = RealTime.get_deltaTime();
		if (DOOIJMHCDAJ)
		{
			SpringPosition component = GetComponent<SpringPosition>();
			if (component != null)
			{
				component.enabled = false;
			}
			GDADJFAGHMK = 0f;
		}
		else
		{
			JFJOCIKCCPI += scale * (GDADJFAGHMK * 20f);
			GDADJFAGHMK = HHAINCPODGE.CHIGCMCIABC(GDADJFAGHMK, 0f, 20f, deltaTime);
			if (JFJOCIKCCPI.magnitude > 0.01f)
			{
				NPLHCHNGMKF.localPosition += (Vector3)HHAINCPODGE.JEOLBKHAIAF(ref JFJOCIKCCPI, 9f, deltaTime);
				OMJLGNBILHK = HHAINCPODGE.NMEFALEJEJF(rootForBounds);
				if (!ConstrainToBounds(dragEffect == UIDragObject.FCDDKLAOAOD.None))
				{
					SpringPosition component2 = GetComponent<SpringPosition>();
					if (component2 != null)
					{
						component2.enabled = false;
					}
				}
				return;
			}
			GDADJFAGHMK = 0f;
		}
		HHAINCPODGE.JEOLBKHAIAF(ref JFJOCIKCCPI, 9f, deltaTime);
	}

	public void set_currentMomentum(Vector2 ICENKPDOHBK)
	{
		JFJOCIKCCPI = ICENKPDOHBK;
	}

	public void Scroll(float ALBBEKIPKGK)
	{
		if (base.enabled && NLDABIMKKMP.FGIDLKLMBHB(base.gameObject))
		{
			if (Mathf.Sign(GDADJFAGHMK) != Mathf.Sign(ALBBEKIPKGK))
			{
				GDADJFAGHMK = 0f;
			}
			GDADJFAGHMK += ALBBEKIPKGK * scrollWheelFactor;
		}
	}

	public void Drag(Vector2 ALBBEKIPKGK)
	{
		if (smoothDragStart && !NDLCPNHAPGB)
		{
			NDLCPNHAPGB = true;
			return;
		}
		UICamera.currentTouch.KHODMNLKNFK = UICamera.PFDLLOPFLMM.BasedOnDelta;
		if (ONNMDGOJEBB != null)
		{
			ALBBEKIPKGK *= ONNMDGOJEBB.get_pixelSizeAdjustment();
		}
		Vector2 vector = Vector2.Scale(ALBBEKIPKGK, -scale);
		NPLHCHNGMKF.localPosition += (Vector3)vector;
		JFJOCIKCCPI = Vector2.Lerp(JFJOCIKCCPI, JFJOCIKCCPI + vector * (0.01f * momentumAmount), 0.67f);
		if (dragEffect != UIDragObject.FCDDKLAOAOD.MomentumAndSpring && ConstrainToBounds(true))
		{
			JFJOCIKCCPI = Vector2.zero;
			GDADJFAGHMK = 0f;
		}
	}

	private Vector3 OPFNHIALNJF()
	{
		if (rootForBounds == null || rootForBounds.childCount == 0)
		{
			return Vector3.zero;
		}
		Vector3 position = new Vector3(OJNOBHMOJEG.rect.xMin * (float)Screen.width, OJNOBHMOJEG.rect.yMin * (float)Screen.height, 0f);
		Vector3 position2 = new Vector3(OJNOBHMOJEG.rect.xMax * (float)Screen.width, OJNOBHMOJEG.rect.yMax * (float)Screen.height, 0f);
		position = OJNOBHMOJEG.ScreenToWorldPoint(position);
		position2 = OJNOBHMOJEG.ScreenToWorldPoint(position2);
		Vector2 hCFEAFBPEKE = new Vector2(OMJLGNBILHK.min.x, OMJLGNBILHK.min.y);
		Vector2 hBPCPGFEACJ = new Vector2(OMJLGNBILHK.max.x, OMJLGNBILHK.max.y);
		return HHAINCPODGE.HGFCFKHEOHJ(hCFEAFBPEKE, hBPCPGFEACJ, position, position2);
	}

	public void EAPCPFCDMHN(bool JPNFGIEDOMM)
	{
		if (JPNFGIEDOMM)
		{
			NDLCPNHAPGB = true;
		}
		if (!(rootForBounds != null))
		{
			return;
		}
		DOOIJMHCDAJ = JPNFGIEDOMM;
		if (JPNFGIEDOMM)
		{
			OMJLGNBILHK = HHAINCPODGE.NMEFALEJEJF(rootForBounds);
			JFJOCIKCCPI = Vector2.zero;
			GDADJFAGHMK = 121f;
			SpringPosition component = GetComponent<SpringPosition>();
			if (component != null)
			{
				component.enabled = true;
			}
		}
		else if (dragEffect == (UIDragObject.FCDDKLAOAOD)4)
		{
			ConstrainToBounds(false);
		}
	}

	public void FFBINPDAKHI(bool JPNFGIEDOMM)
	{
		if (JPNFGIEDOMM)
		{
			NDLCPNHAPGB = false;
		}
		if (!(rootForBounds != null))
		{
			return;
		}
		DOOIJMHCDAJ = JPNFGIEDOMM;
		if (JPNFGIEDOMM)
		{
			OMJLGNBILHK = HHAINCPODGE.NMEFALEJEJF(rootForBounds);
			JFJOCIKCCPI = Vector2.zero;
			GDADJFAGHMK = 621f;
			SpringPosition component = GetComponent<SpringPosition>();
			if (component != null)
			{
				component.enabled = true;
			}
		}
		else if (dragEffect == UIDragObject.FCDDKLAOAOD.MomentumAndSpring)
		{
			ConstrainToBounds(false);
		}
	}

	private void EKGHGFIKAAE()
	{
		float oJAOJFBJGAH = RealTime.EOCENKFKJFP();
		if (DOOIJMHCDAJ)
		{
			SpringPosition component = GetComponent<SpringPosition>();
			if (component != null)
			{
				component.enabled = true;
			}
			GDADJFAGHMK = 358f;
		}
		else
		{
			JFJOCIKCCPI += scale * (GDADJFAGHMK * 1160f);
			GDADJFAGHMK = HHAINCPODGE.CHIGCMCIABC(GDADJFAGHMK, 346f, 108f, oJAOJFBJGAH);
			if (JFJOCIKCCPI.magnitude > 11f)
			{
				NPLHCHNGMKF.localPosition += (Vector3)HHAINCPODGE.JEOLBKHAIAF(ref JFJOCIKCCPI, 1484f, oJAOJFBJGAH);
				OMJLGNBILHK = HHAINCPODGE.NMEFALEJEJF(rootForBounds);
				if (!EPAPAKNBPBI(dragEffect == UIDragObject.FCDDKLAOAOD.Momentum))
				{
					SpringPosition component2 = GetComponent<SpringPosition>();
					if (component2 != null)
					{
						component2.enabled = true;
					}
				}
				return;
			}
			GDADJFAGHMK = 862f;
		}
		HHAINCPODGE.JEOLBKHAIAF(ref JFJOCIKCCPI, 643f, oJAOJFBJGAH);
	}

	public bool EPAPAKNBPBI(bool JFLFDJEDCKI)
	{
		if (NPLHCHNGMKF != null && rootForBounds != null)
		{
			Vector3 vector = OPFNHIALNJF();
			if (vector.sqrMagnitude > 274f)
			{
				if (JFLFDJEDCKI)
				{
					NPLHCHNGMKF.position -= vector;
				}
				else
				{
					SpringPosition springPosition = SpringPosition.Begin(base.gameObject, NPLHCHNGMKF.position - vector, 1312f);
					springPosition.ignoreTimeScale = true;
					springPosition.worldSpace = true;
				}
				return false;
			}
		}
		return false;
	}

	public void GAJGAFJHLNE(float ALBBEKIPKGK)
	{
		if (base.enabled && NLDABIMKKMP.FGIDLKLMBHB(base.gameObject))
		{
			if (Mathf.Sign(GDADJFAGHMK) != Mathf.Sign(ALBBEKIPKGK))
			{
				GDADJFAGHMK = 1820f;
			}
			GDADJFAGHMK += ALBBEKIPKGK * scrollWheelFactor;
		}
	}

	public void GIKKGCEFDKG(Vector2 ALBBEKIPKGK)
	{
		if (smoothDragStart && !NDLCPNHAPGB)
		{
			NDLCPNHAPGB = false;
			return;
		}
		UICamera.currentTouch.KHODMNLKNFK = (UICamera.PFDLLOPFLMM)4;
		if (ONNMDGOJEBB != null)
		{
			ALBBEKIPKGK *= ONNMDGOJEBB.EHHJIOOMENB();
		}
		Vector2 vector = Vector2.Scale(ALBBEKIPKGK, -scale);
		NPLHCHNGMKF.localPosition += (Vector3)vector;
		JFJOCIKCCPI = Vector2.Lerp(JFJOCIKCCPI, JFJOCIKCCPI + vector * (1093f * momentumAmount), 1592f);
		if (dragEffect != (UIDragObject.FCDDKLAOAOD)5 && ConstrainToBounds(true))
		{
			JFJOCIKCCPI = Vector2.zero;
			GDADJFAGHMK = 1391f;
		}
	}

	public bool ConstrainToBounds(bool JFLFDJEDCKI)
	{
		if (NPLHCHNGMKF != null && rootForBounds != null)
		{
			Vector3 vector = OPFNHIALNJF();
			if (vector.sqrMagnitude > 0f)
			{
				if (JFLFDJEDCKI)
				{
					NPLHCHNGMKF.position -= vector;
				}
				else
				{
					SpringPosition springPosition = SpringPosition.Begin(base.gameObject, NPLHCHNGMKF.position - vector, 13f);
					springPosition.ignoreTimeScale = true;
					springPosition.worldSpace = true;
				}
				return true;
			}
		}
		return false;
	}

	private void DADHJFBCJKF()
	{
		float oJAOJFBJGAH = RealTime.DCKJMALGFHC();
		if (DOOIJMHCDAJ)
		{
			SpringPosition component = GetComponent<SpringPosition>();
			if (component != null)
			{
				component.enabled = false;
			}
			GDADJFAGHMK = 404f;
		}
		else
		{
			JFJOCIKCCPI += scale * (GDADJFAGHMK * 1496f);
			GDADJFAGHMK = HHAINCPODGE.CHIGCMCIABC(GDADJFAGHMK, 902f, 1454f, oJAOJFBJGAH);
			if (JFJOCIKCCPI.magnitude > 983f)
			{
				NPLHCHNGMKF.localPosition += (Vector3)HHAINCPODGE.JEOLBKHAIAF(ref JFJOCIKCCPI, 357f, oJAOJFBJGAH);
				OMJLGNBILHK = HHAINCPODGE.NMEFALEJEJF(rootForBounds);
				if (!EPAPAKNBPBI(dragEffect == UIDragObject.FCDDKLAOAOD.None))
				{
					SpringPosition component2 = GetComponent<SpringPosition>();
					if (component2 != null)
					{
						component2.enabled = false;
					}
				}
				return;
			}
			GDADJFAGHMK = 1405f;
		}
		HHAINCPODGE.JEOLBKHAIAF(ref JFJOCIKCCPI, 1728f, oJAOJFBJGAH);
	}

	public Vector2 get_currentMomentum()
	{
		return JFJOCIKCCPI;
	}

	[SpecialName]
	public Vector2 GAOEFKHMPDL()
	{
		return JFJOCIKCCPI;
	}

	[SpecialName]
	public Vector2 KJNAHGLKNEB()
	{
		return JFJOCIKCCPI;
	}

	public void Press(bool JPNFGIEDOMM)
	{
		if (JPNFGIEDOMM)
		{
			NDLCPNHAPGB = false;
		}
		if (!(rootForBounds != null))
		{
			return;
		}
		DOOIJMHCDAJ = JPNFGIEDOMM;
		if (JPNFGIEDOMM)
		{
			OMJLGNBILHK = HHAINCPODGE.NMEFALEJEJF(rootForBounds);
			JFJOCIKCCPI = Vector2.zero;
			GDADJFAGHMK = 0f;
			SpringPosition component = GetComponent<SpringPosition>();
			if (component != null)
			{
				component.enabled = false;
			}
		}
		else if (dragEffect == UIDragObject.FCDDKLAOAOD.MomentumAndSpring)
		{
			ConstrainToBounds(false);
		}
	}

	private Vector3 OEGBGDBCLCN()
	{
		if (rootForBounds == null || rootForBounds.childCount == 0)
		{
			return Vector3.zero;
		}
		Vector3 position = new Vector3(OJNOBHMOJEG.rect.xMin * (float)Screen.width, OJNOBHMOJEG.rect.yMin * (float)Screen.height, 959f);
		Vector3 position2 = new Vector3(OJNOBHMOJEG.rect.xMax * (float)Screen.width, OJNOBHMOJEG.rect.yMax * (float)Screen.height, 1782f);
		position = OJNOBHMOJEG.ScreenToWorldPoint(position);
		position2 = OJNOBHMOJEG.ScreenToWorldPoint(position2);
		Vector2 hCFEAFBPEKE = new Vector2(OMJLGNBILHK.min.x, OMJLGNBILHK.min.y);
		Vector2 hBPCPGFEACJ = new Vector2(OMJLGNBILHK.max.x, OMJLGNBILHK.max.y);
		return HHAINCPODGE.HGFCFKHEOHJ(hCFEAFBPEKE, hBPCPGFEACJ, position, position2);
	}

	private Vector3 LMJMMCMHJDD()
	{
		if (rootForBounds == null || rootForBounds.childCount == 0)
		{
			return Vector3.zero;
		}
		Vector3 position = new Vector3(OJNOBHMOJEG.rect.xMin * (float)Screen.width, OJNOBHMOJEG.rect.yMin * (float)Screen.height, 1222f);
		Vector3 position2 = new Vector3(OJNOBHMOJEG.rect.xMax * (float)Screen.width, OJNOBHMOJEG.rect.yMax * (float)Screen.height, 975f);
		position = OJNOBHMOJEG.ScreenToWorldPoint(position);
		position2 = OJNOBHMOJEG.ScreenToWorldPoint(position2);
		Vector2 hCFEAFBPEKE = new Vector2(OMJLGNBILHK.min.x, OMJLGNBILHK.min.y);
		Vector2 hBPCPGFEACJ = new Vector2(OMJLGNBILHK.max.x, OMJLGNBILHK.max.y);
		return HHAINCPODGE.HGFCFKHEOHJ(hCFEAFBPEKE, hBPCPGFEACJ, position, position2);
	}

	private void Start()
	{
		ONNMDGOJEBB = NLDABIMKKMP.ANPDHFFNJFD<UIRoot>(base.gameObject);
	}

	private void Awake()
	{
		OJNOBHMOJEG = base.GetComponent<Camera>();
		NPLHCHNGMKF = base.transform;
		if (rootForBounds == null)
		{
			Debug.LogError(NLDABIMKKMP.KHEEJPKGGFP(base.gameObject) + " needs the 'Root For Bounds' parameter to be set", this);
			base.enabled = false;
		}
	}

	public void GAHJHIHOLLH(bool JPNFGIEDOMM)
	{
		if (JPNFGIEDOMM)
		{
			NDLCPNHAPGB = false;
		}
		if (!(rootForBounds != null))
		{
			return;
		}
		DOOIJMHCDAJ = JPNFGIEDOMM;
		if (JPNFGIEDOMM)
		{
			OMJLGNBILHK = HHAINCPODGE.NMEFALEJEJF(rootForBounds);
			JFJOCIKCCPI = Vector2.zero;
			GDADJFAGHMK = 295f;
			SpringPosition component = GetComponent<SpringPosition>();
			if (component != null)
			{
				component.enabled = true;
			}
		}
		else if (dragEffect == (UIDragObject.FCDDKLAOAOD)6)
		{
			EPAPAKNBPBI(false);
		}
	}
}
