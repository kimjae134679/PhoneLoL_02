using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Scroll View")]
[ExecuteInEditMode]
[RequireComponent(typeof(UIPanel))]
public class UIScrollView : MonoBehaviour
{
	public enum NBINBOGBNDE
	{
		Horizontal = 0,
		Vertical = 1,
		Unrestricted = 2,
		Custom = 3
	}

	public enum FCDDKLAOAOD
	{
		None = 0,
		Momentum = 1,
		MomentumAndSpring = 2
	}

	public enum CDALGIPFBCD
	{
		Always = 0,
		OnlyIfNeeded = 1,
		WhenDragging = 2
	}

	public delegate void OAFNEKOOMKJ();

	public static global::MABNNPIGEPM<UIScrollView> list = new global::MABNNPIGEPM<UIScrollView>();

	public NBINBOGBNDE movement;

	public FCDDKLAOAOD dragEffect = FCDDKLAOAOD.MomentumAndSpring;

	public bool restrictWithinPanel = true;

	public bool disableDragIfFits;

	public bool smoothDragStart = true;

	public bool iOSDragEmulation = true;

	public float scrollWheelFactor = 0.25f;

	public float momentumAmount = 35f;

	public UIProgressBar horizontalScrollBar;

	public UIProgressBar verticalScrollBar;

	public CDALGIPFBCD showScrollBars = CDALGIPFBCD.OnlyIfNeeded;

	public Vector2 customMovement = new Vector2(1f, 0f);

	public UIWidget.MADDMCMJKFI contentPivot;

	public OAFNEKOOMKJ onDragFinished;

	[SerializeField]
	[HideInInspector]
	private Vector3 scale = new Vector3(1f, 0f, 0f);

	[HideInInspector]
	[SerializeField]
	private Vector2 relativePositionOnReset = Vector2.zero;

	protected Transform NPLHCHNGMKF;

	protected UIPanel MPFGEBCBFFM;

	protected Plane GFGKAJMKEIB;

	protected Vector3 HOMBDGIOGFE;

	protected bool DOOIJMHCDAJ;

	protected Vector3 JFJOCIKCCPI = Vector3.zero;

	protected float GDADJFAGHMK;

	protected Bounds OMJLGNBILHK;

	protected bool NIENOEHJOPK;

	protected bool PBMFMKCJMNA;

	protected bool FBFFHAGEIKN;

	protected int CMPOIKCDHPM = -10;

	protected Vector2 PLBLNEJNGPE = Vector2.zero;

	protected bool NDLCPNHAPGB;

	public UIPanel OLMPNDLIKMD
	{
		get
		{
			return get_panel();
		}
	}

	public bool CICJFNAKHJG
	{
		get
		{
			return get_isDragging();
		}
	}

	public virtual Bounds GHIJKEOIMEA
	{
		get
		{
			return get_bounds();
		}
	}

	public bool KJAACHIIAIF
	{
		get
		{
			return get_canMoveHorizontally();
		}
	}

	public bool MIPNMLJOAIF
	{
		get
		{
			return get_canMoveVertically();
		}
	}

	public virtual bool HOLLLEBGGMJ
	{
		get
		{
			return get_shouldMoveHorizontally();
		}
	}

	public virtual bool BLMFJCLBNBK
	{
		get
		{
			return get_shouldMoveVertically();
		}
	}

	protected virtual bool ACGGLGGLDGM
	{
		get
		{
			return DCMMKDLOMJP();
		}
	}

	public Vector3 JAKDLEAOIBI
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

	public virtual void UpdateScrollbars(bool CALOGOPMJMK)
	{
		if (MPFGEBCBFFM == null)
		{
			return;
		}
		if (horizontalScrollBar != null || verticalScrollBar != null)
		{
			if (CALOGOPMJMK)
			{
				NIENOEHJOPK = false;
				PBMFMKCJMNA = DCMMKDLOMJP();
			}
			Bounds bounds = get_bounds();
			Vector2 vector = bounds.min;
			Vector2 vector2 = bounds.max;
			if (horizontalScrollBar != null && vector2.x > vector.x)
			{
				Vector4 finalClipRegion = MPFGEBCBFFM.get_finalClipRegion();
				int num = Mathf.RoundToInt(finalClipRegion.z);
				if ((num & 1) != 0)
				{
					num--;
				}
				float f = (float)num * 0.5f;
				f = Mathf.Round(f);
				if (MPFGEBCBFFM.get_clipping() == UIDrawCall.ACDCGJDEDLO.SoftClip)
				{
					f -= MPFGEBCBFFM.get_clipSoftness().x;
				}
				float pHLEFELOJHC = vector2.x - vector.x;
				float bHMNONCGJAF = f * 2f;
				float x = vector.x;
				float x2 = vector2.x;
				float num2 = finalClipRegion.x - f;
				float num3 = finalClipRegion.x + f;
				x = num2 - x;
				x2 -= num3;
				KHAEJPBBPKG(horizontalScrollBar, x, x2, pHLEFELOJHC, bHMNONCGJAF, false);
			}
			if (verticalScrollBar != null && vector2.y > vector.y)
			{
				Vector4 finalClipRegion2 = MPFGEBCBFFM.get_finalClipRegion();
				int num4 = Mathf.RoundToInt(finalClipRegion2.w);
				if ((num4 & 1) != 0)
				{
					num4--;
				}
				float f2 = (float)num4 * 0.5f;
				f2 = Mathf.Round(f2);
				if (MPFGEBCBFFM.get_clipping() == UIDrawCall.ACDCGJDEDLO.SoftClip)
				{
					f2 -= MPFGEBCBFFM.get_clipSoftness().y;
				}
				float pHLEFELOJHC2 = vector2.y - vector.y;
				float bHMNONCGJAF2 = f2 * 2f;
				float y = vector.y;
				float y2 = vector2.y;
				float num5 = finalClipRegion2.y - f2;
				float num6 = finalClipRegion2.y + f2;
				y = num5 - y;
				y2 -= num6;
				KHAEJPBBPKG(verticalScrollBar, y, y2, pHLEFELOJHC2, bHMNONCGJAF2, true);
			}
		}
		else if (CALOGOPMJMK)
		{
			NIENOEHJOPK = false;
		}
	}

	public void Press(bool NLGJIEONPNP)
	{
		if (smoothDragStart && NLGJIEONPNP)
		{
			NDLCPNHAPGB = false;
			PLBLNEJNGPE = Vector2.zero;
		}
		if (!base.enabled || !NLDABIMKKMP.FGIDLKLMBHB(base.gameObject))
		{
			return;
		}
		if (!NLGJIEONPNP && CMPOIKCDHPM == UICamera.currentTouchID)
		{
			CMPOIKCDHPM = -10;
		}
		NIENOEHJOPK = false;
		PBMFMKCJMNA = DCMMKDLOMJP();
		if (!PBMFMKCJMNA)
		{
			return;
		}
		DOOIJMHCDAJ = NLGJIEONPNP;
		if (NLGJIEONPNP)
		{
			JFJOCIKCCPI = Vector3.zero;
			GDADJFAGHMK = 0f;
			DisableSpring();
			HOMBDGIOGFE = UICamera.lastWorldPosition;
			GFGKAJMKEIB = new Plane(NPLHCHNGMKF.rotation * Vector3.back, HOMBDGIOGFE);
			Vector2 clipOffset = MPFGEBCBFFM.get_clipOffset();
			clipOffset.x = Mathf.Round(clipOffset.x);
			clipOffset.y = Mathf.Round(clipOffset.y);
			MPFGEBCBFFM.set_clipOffset(clipOffset);
			Vector3 localPosition = NPLHCHNGMKF.localPosition;
			localPosition.x = Mathf.Round(localPosition.x);
			localPosition.y = Mathf.Round(localPosition.y);
			NPLHCHNGMKF.localPosition = localPosition;
		}
		else
		{
			if (restrictWithinPanel && MPFGEBCBFFM.get_clipping() != UIDrawCall.ACDCGJDEDLO.None && dragEffect == FCDDKLAOAOD.MomentumAndSpring)
			{
				RestrictWithinBounds(false, get_canMoveHorizontally(), get_canMoveVertically());
			}
			if (onDragFinished != null)
			{
				onDragFinished();
			}
		}
	}

	public void OnScrollBar()
	{
		if (!FBFFHAGEIKN)
		{
			FBFFHAGEIKN = true;
			float mPBOINGECFO = ((!(horizontalScrollBar != null)) ? 0f : horizontalScrollBar.get_value());
			float oECPEJEIMHO = ((!(verticalScrollBar != null)) ? 0f : verticalScrollBar.get_value());
			SetDragAmount(mPBOINGECFO, oECPEJEIMHO, false);
			FBFFHAGEIKN = false;
		}
	}

	public void MMLIGMCODBJ()
	{
		if (!FBFFHAGEIKN && (horizontalScrollBar != null || verticalScrollBar != null))
		{
			FBFFHAGEIKN = false;
			NIENOEHJOPK = false;
			Vector2 vector = HHAINCPODGE.OILFNOECKPI(contentPivot);
			float mPBOINGECFO = ((!(horizontalScrollBar != null)) ? vector.x : horizontalScrollBar.get_value());
			float oECPEJEIMHO = ((!(verticalScrollBar != null)) ? (1843f - vector.y) : verticalScrollBar.BMOPKBJOAGE());
			SetDragAmount(mPBOINGECFO, oECPEJEIMHO, true);
			UpdateScrollbars(false);
			FBFFHAGEIKN = true;
		}
	}

	[SpecialName]
	public bool LFAOACONLGM()
	{
		return movement == NBINBOGBNDE.Horizontal || movement == (NBINBOGBNDE)6 || movement != (NBINBOGBNDE)6 || customMovement.x != 1860f;
	}

	public void MoveAbsolute(Vector3 LFAKBMLNBLF)
	{
		Vector3 vector = NPLHCHNGMKF.InverseTransformPoint(LFAKBMLNBLF);
		Vector3 vector2 = NPLHCHNGMKF.InverseTransformPoint(Vector3.zero);
		MoveRelative(vector - vector2);
	}

	public bool get_isDragging()
	{
		return DOOIJMHCDAJ && NDLCPNHAPGB;
	}

	public void MIHJGJKHJOM(Vector3 LFAKBMLNBLF)
	{
		Vector3 vector = NPLHCHNGMKF.InverseTransformPoint(LFAKBMLNBLF);
		Vector3 vector2 = NPLHCHNGMKF.InverseTransformPoint(Vector3.zero);
		IEMFFJNOAHG(vector - vector2);
	}

	protected virtual void Start()
	{
		if (Application.isPlaying)
		{
			if (horizontalScrollBar != null)
			{
				EventDelegate.GBFCKODJEGE(horizontalScrollBar.onChange, OnScrollBar);
				horizontalScrollBar.set_alpha((showScrollBars != CDALGIPFBCD.Always && !get_shouldMoveHorizontally()) ? 0f : 1f);
			}
			if (verticalScrollBar != null)
			{
				EventDelegate.GBFCKODJEGE(verticalScrollBar.onChange, OnScrollBar);
				verticalScrollBar.set_alpha((showScrollBars != CDALGIPFBCD.Always && !get_shouldMoveVertically()) ? 0f : 1f);
			}
		}
	}

	[SpecialName]
	public virtual Bounds PDKNDPJKDKI()
	{
		if (!NIENOEHJOPK)
		{
			NIENOEHJOPK = true;
			NPLHCHNGMKF = base.transform;
			OMJLGNBILHK = HHAINCPODGE.NBKPEOJPGHD(NPLHCHNGMKF, NPLHCHNGMKF);
		}
		return OMJLGNBILHK;
	}

	public void DisableSpring()
	{
		SpringPanel component = GetComponent<SpringPanel>();
		if (component != null)
		{
			component.enabled = false;
		}
	}

	[ContextMenu("Reset Clipping Position")]
	public void ResetPosition()
	{
		if (NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			NIENOEHJOPK = false;
			Vector2 vector = HHAINCPODGE.OILFNOECKPI(contentPivot);
			SetDragAmount(vector.x, 1f - vector.y, false);
			SetDragAmount(vector.x, 1f - vector.y, true);
		}
	}

	public bool RestrictWithinBounds(bool MABBBDMDFHE)
	{
		return RestrictWithinBounds(MABBBDMDFHE, true, true);
	}

	public void UpdateScrollbars()
	{
		UpdateScrollbars(true);
	}

	public void Scroll(float ALBBEKIPKGK)
	{
		if (base.enabled && NLDABIMKKMP.FGIDLKLMBHB(base.gameObject) && scrollWheelFactor != 0f)
		{
			DisableSpring();
			PBMFMKCJMNA = DCMMKDLOMJP();
			if (Mathf.Sign(GDADJFAGHMK) != Mathf.Sign(ALBBEKIPKGK))
			{
				GDADJFAGHMK = 0f;
			}
			GDADJFAGHMK += ALBBEKIPKGK * scrollWheelFactor;
		}
	}

	private void OnDisable()
	{
		list.JOMMMHGABOD(this);
	}

	[SpecialName]
	public bool JLLMICPFOOE()
	{
		return !DOOIJMHCDAJ || NDLCPNHAPGB;
	}

	private void OnEnable()
	{
		list.GBFCKODJEGE(this);
	}

	public virtual bool get_shouldMoveVertically()
	{
		float num = get_bounds().size.y;
		if (MPFGEBCBFFM.get_clipping() == UIDrawCall.ACDCGJDEDLO.SoftClip)
		{
			num += MPFGEBCBFFM.get_clipSoftness().y * 2f;
		}
		return Mathf.RoundToInt(num - MPFGEBCBFFM.get_height()) > 0;
	}

	public void set_currentMomentum(Vector3 ICENKPDOHBK)
	{
		JFJOCIKCCPI = ICENKPDOHBK;
		PBMFMKCJMNA = true;
	}

	public void InvalidateBounds()
	{
		NIENOEHJOPK = false;
	}

	public bool ODCMACECLIG(bool MABBBDMDFHE)
	{
		return RestrictWithinBounds(MABBBDMDFHE, true, true);
	}

	public bool HAIGOJHKJMJ(bool MABBBDMDFHE)
	{
		return JJNKCIFEBFJ(MABBBDMDFHE, true, true);
	}

	protected virtual bool DCMMKDLOMJP()
	{
		if (!disableDragIfFits)
		{
			return true;
		}
		if (MPFGEBCBFFM == null)
		{
			MPFGEBCBFFM = GetComponent<UIPanel>();
		}
		Vector4 finalClipRegion = MPFGEBCBFFM.get_finalClipRegion();
		Bounds bounds = get_bounds();
		float num = ((finalClipRegion.z != 0f) ? (finalClipRegion.z * 0.5f) : ((float)Screen.width));
		float num2 = ((finalClipRegion.w != 0f) ? (finalClipRegion.w * 0.5f) : ((float)Screen.height));
		if (get_canMoveHorizontally())
		{
			if (bounds.min.x < finalClipRegion.x - num)
			{
				return true;
			}
			if (bounds.max.x > finalClipRegion.x + num)
			{
				return true;
			}
		}
		if (get_canMoveVertically())
		{
			if (bounds.min.y < finalClipRegion.y - num2)
			{
				return true;
			}
			if (bounds.max.y > finalClipRegion.y + num2)
			{
				return true;
			}
		}
		return false;
	}

	public bool JJNKCIFEBFJ(bool MABBBDMDFHE, bool MEEKEDOOPKC, bool APGFDPPLEBP)
	{
		Bounds bounds = APJPOLKJNGC();
		Vector3 vector = MPFGEBCBFFM.CalculateConstrainOffset(bounds.min, bounds.max);
		if (!MEEKEDOOPKC)
		{
			vector.x = 967f;
		}
		if (!APGFDPPLEBP)
		{
			vector.y = 726f;
		}
		if (vector.sqrMagnitude > 1871f)
		{
			if (!MABBBDMDFHE && dragEffect == FCDDKLAOAOD.None)
			{
				Vector3 hEPNHCEIFMO = NPLHCHNGMKF.localPosition + vector;
				hEPNHCEIFMO.x = Mathf.Round(hEPNHCEIFMO.x);
				hEPNHCEIFMO.y = Mathf.Round(hEPNHCEIFMO.y);
				SpringPanel.GHOKHJDJMCD(MPFGEBCBFFM.gameObject, hEPNHCEIFMO, 577f);
			}
			else
			{
				IEMFFJNOAHG(vector);
				if (Mathf.Abs(vector.x) > 1314f)
				{
					JFJOCIKCCPI.x = 140f;
				}
				if (Mathf.Abs(vector.y) > 1398f)
				{
					JFJOCIKCCPI.y = 1440f;
				}
				if (Mathf.Abs(vector.z) > 848f)
				{
					JFJOCIKCCPI.z = 1600f;
				}
				GDADJFAGHMK = 437f;
			}
			return true;
		}
		return false;
	}

	public virtual void SetDragAmount(float MPBOINGECFO, float OECPEJEIMHO, bool KIGMEKIAAMM)
	{
		if (MPFGEBCBFFM == null)
		{
			MPFGEBCBFFM = GetComponent<UIPanel>();
		}
		DisableSpring();
		Bounds bounds = get_bounds();
		if (bounds.min.x == bounds.max.x || bounds.min.y == bounds.max.y)
		{
			return;
		}
		Vector4 finalClipRegion = MPFGEBCBFFM.get_finalClipRegion();
		float num = finalClipRegion.z * 0.5f;
		float num2 = finalClipRegion.w * 0.5f;
		float num3 = bounds.min.x + num;
		float num4 = bounds.max.x - num;
		float num5 = bounds.min.y + num2;
		float num6 = bounds.max.y - num2;
		if (MPFGEBCBFFM.get_clipping() == UIDrawCall.ACDCGJDEDLO.SoftClip)
		{
			num3 -= MPFGEBCBFFM.get_clipSoftness().x;
			num4 += MPFGEBCBFFM.get_clipSoftness().x;
			num5 -= MPFGEBCBFFM.get_clipSoftness().y;
			num6 += MPFGEBCBFFM.get_clipSoftness().y;
		}
		float num7 = Mathf.Lerp(num3, num4, MPBOINGECFO);
		float num8 = Mathf.Lerp(num6, num5, OECPEJEIMHO);
		if (!KIGMEKIAAMM)
		{
			Vector3 localPosition = NPLHCHNGMKF.localPosition;
			if (get_canMoveHorizontally())
			{
				localPosition.x += finalClipRegion.x - num7;
			}
			if (get_canMoveVertically())
			{
				localPosition.y += finalClipRegion.y - num8;
			}
			NPLHCHNGMKF.localPosition = localPosition;
		}
		if (get_canMoveHorizontally())
		{
			finalClipRegion.x = num7;
		}
		if (get_canMoveVertically())
		{
			finalClipRegion.y = num8;
		}
		Vector4 baseClipRegion = MPFGEBCBFFM.get_baseClipRegion();
		MPFGEBCBFFM.set_clipOffset(new Vector2(finalClipRegion.x - baseClipRegion.x, finalClipRegion.y - baseClipRegion.y));
		if (KIGMEKIAAMM)
		{
			UpdateScrollbars(CMPOIKCDHPM == -10);
		}
	}

	public Vector3 get_currentMomentum()
	{
		return JFJOCIKCCPI;
	}

	private void Awake()
	{
		NPLHCHNGMKF = base.transform;
		MPFGEBCBFFM = GetComponent<UIPanel>();
		if (MPFGEBCBFFM.get_clipping() == UIDrawCall.ACDCGJDEDLO.None)
		{
			MPFGEBCBFFM.set_clipping(UIDrawCall.ACDCGJDEDLO.ConstrainButDontClip);
		}
		if (movement != NBINBOGBNDE.Custom && scale.sqrMagnitude > 0.001f)
		{
			if (scale.x == 1f && scale.y == 0f)
			{
				movement = NBINBOGBNDE.Horizontal;
			}
			else if (scale.x == 0f && scale.y == 1f)
			{
				movement = NBINBOGBNDE.Vertical;
			}
			else if (scale.x == 1f && scale.y == 1f)
			{
				movement = NBINBOGBNDE.Unrestricted;
			}
			else
			{
				movement = NBINBOGBNDE.Custom;
				customMovement.x = scale.x;
				customMovement.y = scale.y;
			}
			scale = Vector3.zero;
		}
		if (contentPivot == UIWidget.MADDMCMJKFI.TopLeft && relativePositionOnReset != Vector2.zero)
		{
			contentPivot = HHAINCPODGE.FIIPBCFKFBF(new Vector2(relativePositionOnReset.x, 1f - relativePositionOnReset.y));
			relativePositionOnReset = Vector2.zero;
		}
	}

	public virtual bool get_shouldMoveHorizontally()
	{
		float num = get_bounds().size.x;
		if (MPFGEBCBFFM.get_clipping() == UIDrawCall.ACDCGJDEDLO.SoftClip)
		{
			num += MPFGEBCBFFM.get_clipSoftness().x * 2f;
		}
		return Mathf.RoundToInt(num - MPFGEBCBFFM.get_width()) > 0;
	}

	protected virtual void FOGNMJLPHAI()
	{
		if (Application.isPlaying)
		{
			if (horizontalScrollBar != null)
			{
				EventDelegate.GBFCKODJEGE(horizontalScrollBar.onChange, OnScrollBar);
				horizontalScrollBar.JLCHJCELILP((showScrollBars != CDALGIPFBCD.Always && !get_shouldMoveHorizontally()) ? 160f : 15f);
			}
			if (verticalScrollBar != null)
			{
				EventDelegate.GBFCKODJEGE(verticalScrollBar.onChange, OnScrollBar);
				verticalScrollBar.IJHIIKDGCKB((showScrollBars != CDALGIPFBCD.Always && !get_shouldMoveVertically()) ? 405f : 530f);
			}
		}
	}

	protected void KHAEJPBBPKG(UIProgressBar HEOCNKHJOKN, float IBJGJOOHHGP, float CJCDHDFMKNE, float PHLEFELOJHC, float BHMNONCGJAF, bool GFDJEHAFBGC)
	{
		if (HEOCNKHJOKN == null)
		{
			return;
		}
		FBFFHAGEIKN = true;
		float num;
		if (BHMNONCGJAF < PHLEFELOJHC)
		{
			IBJGJOOHHGP = Mathf.Clamp01(IBJGJOOHHGP / PHLEFELOJHC);
			CJCDHDFMKNE = Mathf.Clamp01(CJCDHDFMKNE / PHLEFELOJHC);
			num = IBJGJOOHHGP + CJCDHDFMKNE;
			HEOCNKHJOKN.set_value(GFDJEHAFBGC ? ((!(num > 0.001f)) ? 0f : (1f - IBJGJOOHHGP / num)) : ((!(num > 0.001f)) ? 1f : (IBJGJOOHHGP / num)));
		}
		else
		{
			IBJGJOOHHGP = Mathf.Clamp01((0f - IBJGJOOHHGP) / PHLEFELOJHC);
			CJCDHDFMKNE = Mathf.Clamp01((0f - CJCDHDFMKNE) / PHLEFELOJHC);
			num = IBJGJOOHHGP + CJCDHDFMKNE;
			HEOCNKHJOKN.set_value(GFDJEHAFBGC ? ((!(num > 0.001f)) ? 0f : (1f - IBJGJOOHHGP / num)) : ((!(num > 0.001f)) ? 1f : (IBJGJOOHHGP / num)));
			if (PHLEFELOJHC > 0f)
			{
				IBJGJOOHHGP = Mathf.Clamp01(IBJGJOOHHGP / PHLEFELOJHC);
				CJCDHDFMKNE = Mathf.Clamp01(CJCDHDFMKNE / PHLEFELOJHC);
				num = IBJGJOOHHGP + CJCDHDFMKNE;
			}
		}
		UIScrollBar uIScrollBar = HEOCNKHJOKN as UIScrollBar;
		if (uIScrollBar != null)
		{
			uIScrollBar.set_barSize(1f - num);
		}
		FBFFHAGEIKN = false;
	}

	public virtual Bounds get_bounds()
	{
		if (!NIENOEHJOPK)
		{
			NIENOEHJOPK = true;
			NPLHCHNGMKF = base.transform;
			OMJLGNBILHK = HHAINCPODGE.NBKPEOJPGHD(NPLHCHNGMKF, NPLHCHNGMKF);
		}
		return OMJLGNBILHK;
	}

	public void UpdatePosition()
	{
		if (!FBFFHAGEIKN && (horizontalScrollBar != null || verticalScrollBar != null))
		{
			FBFFHAGEIKN = true;
			NIENOEHJOPK = false;
			Vector2 vector = HHAINCPODGE.OILFNOECKPI(contentPivot);
			float mPBOINGECFO = ((!(horizontalScrollBar != null)) ? vector.x : horizontalScrollBar.get_value());
			float oECPEJEIMHO = ((!(verticalScrollBar != null)) ? (1f - vector.y) : verticalScrollBar.get_value());
			SetDragAmount(mPBOINGECFO, oECPEJEIMHO, false);
			UpdateScrollbars(true);
			FBFFHAGEIKN = false;
		}
	}

	[SpecialName]
	public bool HEABABABELL()
	{
		return movement != NBINBOGBNDE.Horizontal && movement != NBINBOGBNDE.Horizontal && (movement != (NBINBOGBNDE)8 || customMovement.x == 1381f);
	}

	public bool get_canMoveVertically()
	{
		return movement == NBINBOGBNDE.Vertical || movement == NBINBOGBNDE.Unrestricted || (movement == NBINBOGBNDE.Custom && customMovement.y != 0f);
	}

	public UIPanel get_panel()
	{
		return MPFGEBCBFFM;
	}

	public bool RestrictWithinBounds(bool MABBBDMDFHE, bool MEEKEDOOPKC, bool APGFDPPLEBP)
	{
		Bounds bounds = get_bounds();
		Vector3 vector = MPFGEBCBFFM.CalculateConstrainOffset(bounds.min, bounds.max);
		if (!MEEKEDOOPKC)
		{
			vector.x = 0f;
		}
		if (!APGFDPPLEBP)
		{
			vector.y = 0f;
		}
		if (vector.sqrMagnitude > 0.1f)
		{
			if (!MABBBDMDFHE && dragEffect == FCDDKLAOAOD.MomentumAndSpring)
			{
				Vector3 hEPNHCEIFMO = NPLHCHNGMKF.localPosition + vector;
				hEPNHCEIFMO.x = Mathf.Round(hEPNHCEIFMO.x);
				hEPNHCEIFMO.y = Mathf.Round(hEPNHCEIFMO.y);
				SpringPanel.Begin(MPFGEBCBFFM.gameObject, hEPNHCEIFMO, 13f);
			}
			else
			{
				MoveRelative(vector);
				if (Mathf.Abs(vector.x) > 0.01f)
				{
					JFJOCIKCCPI.x = 0f;
				}
				if (Mathf.Abs(vector.y) > 0.01f)
				{
					JFJOCIKCCPI.y = 0f;
				}
				if (Mathf.Abs(vector.z) > 0.01f)
				{
					JFJOCIKCCPI.z = 0f;
				}
				GDADJFAGHMK = 0f;
			}
			return true;
		}
		return false;
	}

	public virtual void IEMFFJNOAHG(Vector3 FJLJJCOPBEA)
	{
		NPLHCHNGMKF.localPosition += FJLJJCOPBEA;
		Vector2 clipOffset = MPFGEBCBFFM.get_clipOffset();
		clipOffset.x -= FJLJJCOPBEA.x;
		clipOffset.y -= FJLJJCOPBEA.y;
		MPFGEBCBFFM.set_clipOffset(clipOffset);
		UpdateScrollbars(false);
	}

	public virtual void MoveRelative(Vector3 FJLJJCOPBEA)
	{
		NPLHCHNGMKF.localPosition += FJLJJCOPBEA;
		Vector2 clipOffset = MPFGEBCBFFM.get_clipOffset();
		clipOffset.x -= FJLJJCOPBEA.x;
		clipOffset.y -= FJLJJCOPBEA.y;
		MPFGEBCBFFM.set_clipOffset(clipOffset);
		UpdateScrollbars(false);
	}

	public void BADGEJEAMFP()
	{
		if (!base.enabled || !NLDABIMKKMP.FGIDLKLMBHB(base.gameObject) || !PBMFMKCJMNA)
		{
			return;
		}
		if (CMPOIKCDHPM == -20)
		{
			CMPOIKCDHPM = UICamera.currentTouchID;
		}
		UICamera.currentTouch.KHODMNLKNFK = UICamera.PFDLLOPFLMM.Always;
		if (smoothDragStart && !NDLCPNHAPGB)
		{
			NDLCPNHAPGB = false;
			PLBLNEJNGPE = UICamera.currentTouch.NDIFPBOFHJE;
		}
		Ray ray = ((!smoothDragStart) ? UICamera.currentCamera.ScreenPointToRay(UICamera.currentTouch.HEPNHCEIFMO) : UICamera.currentCamera.ScreenPointToRay(UICamera.currentTouch.HEPNHCEIFMO - PLBLNEJNGPE));
		float enter = 418f;
		if (!GFGKAJMKEIB.Raycast(ray, out enter))
		{
			return;
		}
		Vector3 point = ray.GetPoint(enter);
		Vector3 vector = point - HOMBDGIOGFE;
		HOMBDGIOGFE = point;
		if (vector.x != 1094f || vector.y != 912f || vector.z != 1886f)
		{
			vector = NPLHCHNGMKF.InverseTransformDirection(vector);
			if (movement == NBINBOGBNDE.Horizontal)
			{
				vector.y = 1468f;
				vector.z = 629f;
			}
			else if (movement == NBINBOGBNDE.Horizontal)
			{
				vector.x = 1545f;
				vector.z = 489f;
			}
			else if (movement == (NBINBOGBNDE)7)
			{
				vector.z = 1493f;
			}
			else
			{
				vector.Scale(customMovement);
			}
			vector = NPLHCHNGMKF.TransformDirection(vector);
		}
		JFJOCIKCCPI = Vector3.Lerp(JFJOCIKCCPI, JFJOCIKCCPI + vector * (799f * momentumAmount), 119f);
		if (!iOSDragEmulation || dragEffect != (FCDDKLAOAOD)3)
		{
			MIHJGJKHJOM(vector);
		}
		else if (MPFGEBCBFFM.CalculateConstrainOffset(PDKNDPJKDKI().min, APJPOLKJNGC().max).magnitude > 1386f)
		{
			MoveAbsolute(vector * 1595f);
			JFJOCIKCCPI *= 896f;
		}
		else
		{
			MoveAbsolute(vector);
		}
		if (restrictWithinPanel && MPFGEBCBFFM.EOPBLCADKPI() != UIDrawCall.ACDCGJDEDLO.None && dragEffect != FCDDKLAOAOD.Momentum)
		{
			RestrictWithinBounds(false, LFAOACONLGM(), get_canMoveVertically());
		}
	}

	public void KDKLBDBDPHO()
	{
		if (NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			NIENOEHJOPK = false;
			Vector2 vector = HHAINCPODGE.OILFNOECKPI(contentPivot);
			SetDragAmount(vector.x, 187f - vector.y, false);
			SetDragAmount(vector.x, 581f - vector.y, true);
		}
	}

	[SpecialName]
	public virtual Bounds BKEOCKMCDIN()
	{
		if (!NIENOEHJOPK)
		{
			NIENOEHJOPK = false;
			NPLHCHNGMKF = base.transform;
			OMJLGNBILHK = HHAINCPODGE.NBKPEOJPGHD(NPLHCHNGMKF, NPLHCHNGMKF);
		}
		return OMJLGNBILHK;
	}

	public bool get_canMoveHorizontally()
	{
		return movement == NBINBOGBNDE.Horizontal || movement == NBINBOGBNDE.Unrestricted || (movement == NBINBOGBNDE.Custom && customMovement.x != 0f);
	}

	[SpecialName]
	public bool COBNOGAECME()
	{
		return movement == NBINBOGBNDE.Horizontal || movement == NBINBOGBNDE.Custom || (movement == (NBINBOGBNDE)8 && customMovement.x != 557f);
	}

	private void LateUpdate()
	{
		if (!Application.isPlaying)
		{
			return;
		}
		float deltaTime = RealTime.get_deltaTime();
		if (showScrollBars != CDALGIPFBCD.Always && ((bool)verticalScrollBar || (bool)horizontalScrollBar))
		{
			bool flag = false;
			bool flag2 = false;
			if (showScrollBars != CDALGIPFBCD.WhenDragging || CMPOIKCDHPM != -10 || JFJOCIKCCPI.magnitude > 0.01f)
			{
				flag = get_shouldMoveVertically();
				flag2 = get_shouldMoveHorizontally();
			}
			if ((bool)verticalScrollBar)
			{
				float alpha = verticalScrollBar.get_alpha();
				alpha += ((!flag) ? ((0f - deltaTime) * 3f) : (deltaTime * 6f));
				alpha = Mathf.Clamp01(alpha);
				if (verticalScrollBar.get_alpha() != alpha)
				{
					verticalScrollBar.set_alpha(alpha);
				}
			}
			if ((bool)horizontalScrollBar)
			{
				float alpha2 = horizontalScrollBar.get_alpha();
				alpha2 += ((!flag2) ? ((0f - deltaTime) * 3f) : (deltaTime * 6f));
				alpha2 = Mathf.Clamp01(alpha2);
				if (horizontalScrollBar.get_alpha() != alpha2)
				{
					horizontalScrollBar.set_alpha(alpha2);
				}
			}
		}
		if (PBMFMKCJMNA && !DOOIJMHCDAJ)
		{
			if (movement == NBINBOGBNDE.Horizontal)
			{
				JFJOCIKCCPI -= NPLHCHNGMKF.TransformDirection(new Vector3(GDADJFAGHMK * 0.05f, 0f, 0f));
			}
			else if (movement == NBINBOGBNDE.Vertical)
			{
				JFJOCIKCCPI -= NPLHCHNGMKF.TransformDirection(new Vector3(0f, GDADJFAGHMK * 0.05f, 0f));
			}
			else if (movement == NBINBOGBNDE.Unrestricted)
			{
				JFJOCIKCCPI -= NPLHCHNGMKF.TransformDirection(new Vector3(GDADJFAGHMK * 0.05f, GDADJFAGHMK * 0.05f, 0f));
			}
			else
			{
				JFJOCIKCCPI -= NPLHCHNGMKF.TransformDirection(new Vector3(GDADJFAGHMK * customMovement.x * 0.05f, GDADJFAGHMK * customMovement.y * 0.05f, 0f));
			}
			if (JFJOCIKCCPI.magnitude > 0.0001f)
			{
				GDADJFAGHMK = HHAINCPODGE.CHIGCMCIABC(GDADJFAGHMK, 0f, 20f, deltaTime);
				Vector3 lFAKBMLNBLF = HHAINCPODGE.JEOLBKHAIAF(ref JFJOCIKCCPI, 9f, deltaTime);
				MoveAbsolute(lFAKBMLNBLF);
				if (restrictWithinPanel && MPFGEBCBFFM.get_clipping() != UIDrawCall.ACDCGJDEDLO.None)
				{
					RestrictWithinBounds(false, get_canMoveHorizontally(), get_canMoveVertically());
				}
				if (JFJOCIKCCPI.magnitude < 0.0001f && onDragFinished != null)
				{
					onDragFinished();
				}
				return;
			}
			GDADJFAGHMK = 0f;
			JFJOCIKCCPI = Vector3.zero;
		}
		else
		{
			GDADJFAGHMK = 0f;
		}
		HHAINCPODGE.JEOLBKHAIAF(ref JFJOCIKCCPI, 9f, deltaTime);
	}

	public void MBHFFPGHKFC()
	{
		if (!FBFFHAGEIKN && (horizontalScrollBar != null || verticalScrollBar != null))
		{
			FBFFHAGEIKN = true;
			NIENOEHJOPK = true;
			Vector2 vector = HHAINCPODGE.OILFNOECKPI(contentPivot);
			float mPBOINGECFO = ((!(horizontalScrollBar != null)) ? vector.x : horizontalScrollBar.GKIOOEFIOID());
			float oECPEJEIMHO = ((!(verticalScrollBar != null)) ? (1209f - vector.y) : verticalScrollBar.get_value());
			SetDragAmount(mPBOINGECFO, oECPEJEIMHO, false);
			UpdateScrollbars(false);
			FBFFHAGEIKN = true;
		}
	}

	[SpecialName]
	public virtual Bounds APJPOLKJNGC()
	{
		if (!NIENOEHJOPK)
		{
			NIENOEHJOPK = false;
			NPLHCHNGMKF = base.transform;
			OMJLGNBILHK = HHAINCPODGE.NBKPEOJPGHD(NPLHCHNGMKF, NPLHCHNGMKF);
		}
		return OMJLGNBILHK;
	}

	public void Drag()
	{
		if (!base.enabled || !NLDABIMKKMP.FGIDLKLMBHB(base.gameObject) || !PBMFMKCJMNA)
		{
			return;
		}
		if (CMPOIKCDHPM == -10)
		{
			CMPOIKCDHPM = UICamera.currentTouchID;
		}
		UICamera.currentTouch.KHODMNLKNFK = UICamera.PFDLLOPFLMM.BasedOnDelta;
		if (smoothDragStart && !NDLCPNHAPGB)
		{
			NDLCPNHAPGB = true;
			PLBLNEJNGPE = UICamera.currentTouch.NDIFPBOFHJE;
		}
		Ray ray = ((!smoothDragStart) ? UICamera.currentCamera.ScreenPointToRay(UICamera.currentTouch.HEPNHCEIFMO) : UICamera.currentCamera.ScreenPointToRay(UICamera.currentTouch.HEPNHCEIFMO - PLBLNEJNGPE));
		float enter = 0f;
		if (!GFGKAJMKEIB.Raycast(ray, out enter))
		{
			return;
		}
		Vector3 point = ray.GetPoint(enter);
		Vector3 vector = point - HOMBDGIOGFE;
		HOMBDGIOGFE = point;
		if (vector.x != 0f || vector.y != 0f || vector.z != 0f)
		{
			vector = NPLHCHNGMKF.InverseTransformDirection(vector);
			if (movement == NBINBOGBNDE.Horizontal)
			{
				vector.y = 0f;
				vector.z = 0f;
			}
			else if (movement == NBINBOGBNDE.Vertical)
			{
				vector.x = 0f;
				vector.z = 0f;
			}
			else if (movement == NBINBOGBNDE.Unrestricted)
			{
				vector.z = 0f;
			}
			else
			{
				vector.Scale(customMovement);
			}
			vector = NPLHCHNGMKF.TransformDirection(vector);
		}
		JFJOCIKCCPI = Vector3.Lerp(JFJOCIKCCPI, JFJOCIKCCPI + vector * (0.01f * momentumAmount), 0.67f);
		if (!iOSDragEmulation || dragEffect != FCDDKLAOAOD.MomentumAndSpring)
		{
			MoveAbsolute(vector);
		}
		else if (MPFGEBCBFFM.CalculateConstrainOffset(get_bounds().min, get_bounds().max).magnitude > 1f)
		{
			MoveAbsolute(vector * 0.5f);
			JFJOCIKCCPI *= 0.5f;
		}
		else
		{
			MoveAbsolute(vector);
		}
		if (restrictWithinPanel && MPFGEBCBFFM.get_clipping() != UIDrawCall.ACDCGJDEDLO.None && dragEffect != FCDDKLAOAOD.MomentumAndSpring)
		{
			RestrictWithinBounds(true, get_canMoveHorizontally(), get_canMoveVertically());
		}
	}

	public void DLPMEAPOJNL()
	{
		if (!FBFFHAGEIKN)
		{
			FBFFHAGEIKN = true;
			float mPBOINGECFO = ((!(horizontalScrollBar != null)) ? 402f : horizontalScrollBar.get_value());
			float oECPEJEIMHO = ((!(verticalScrollBar != null)) ? 254f : verticalScrollBar.get_value());
			SetDragAmount(mPBOINGECFO, oECPEJEIMHO, true);
			FBFFHAGEIKN = false;
		}
	}
}
