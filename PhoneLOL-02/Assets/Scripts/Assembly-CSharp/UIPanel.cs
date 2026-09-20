using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/UI/NGUI Panel")]
[ExecuteInEditMode]
public class UIPanel : UIRect
{
	public enum BGJKEIMMBBB
	{
		Automatic = 0,
		StartAt = 1,
		Explicit = 2
	}

	public delegate void LBPCPDLFJJJ();

	public delegate void ANBODCGBJEM(UIPanel OLMPNDLIKMD);

	public static global::MABNNPIGEPM<UIPanel> list = new global::MABNNPIGEPM<UIPanel>();

	public LBPCPDLFJJJ onGeometryUpdated;

	public bool showInPanelTool = true;

	public bool generateNormals;

	public bool widgetsAreStatic;

	public bool cullWhileDragging;

	public bool alwaysOnScreen;

	public bool anchorOffset;

	public BGJKEIMMBBB renderQueue;

	public int startingRenderQueue = 3000;

	[NonSerialized]
	public global::MABNNPIGEPM<UIWidget> widgets = new global::MABNNPIGEPM<UIWidget>();

	[NonSerialized]
	public global::MABNNPIGEPM<UIDrawCall> drawCalls = new global::MABNNPIGEPM<UIDrawCall>();

	[NonSerialized]
	public Matrix4x4 worldToLocal = Matrix4x4.identity;

	[NonSerialized]
	public Vector4 drawCallClipRange = new Vector4(0f, 0f, 1f, 1f);

	public ANBODCGBJEM onClipMove;

	[SerializeField]
	[HideInInspector]
	private float mAlpha = 1f;

	[HideInInspector]
	[SerializeField]
	private UIDrawCall.ACDCGJDEDLO mClipping;

	[HideInInspector]
	[SerializeField]
	private Vector4 mClipRange = new Vector4(0f, 0f, 300f, 200f);

	[SerializeField]
	[HideInInspector]
	private Vector2 mClipSoftness = new Vector2(4f, 4f);

	[HideInInspector]
	[SerializeField]
	private int mDepth;

	[SerializeField]
	[HideInInspector]
	private int mSortingOrder;

	private bool NJBHFHNFAIK;

	private bool JEICIEEMFLF;

	private Camera OJNOBHMOJEG;

	[SerializeField]
	private Vector2 mClipOffset = Vector2.zero;

	private float AKGFAIFNGCG;

	private float LKPOPIBKDOA;

	private int NBJJJDOINOP = -1;

	private int AHMAAPDCFLH;

	private int KGJGFFIFAAB = -1;

	private static float[] AJEGMEKIBDD = new float[4];

	private Vector2 KOOGAENILKC = Vector2.zero;

	private Vector2 JNLIKIBPFJG = Vector2.zero;

	private bool KOOIJBCHMNP;

	private bool KLAMEGPACEA;

	private bool JBDHJEMLEBM;

	private UIPanel NEOCFBFHJEC;

	private static Vector3[] CLMAJAOJAFB = new Vector3[4];

	private static int DDHHLCDJCNM = -1;

	private bool NMCKKGPKCGA;

	public static int GKADKKNLHFH
	{
		get
		{
			return get_nextUnusedDepth();
		}
	}

	public override bool CNOAGFGBIJK
	{
		get
		{
			return get_canBeAnchored();
		}
	}

	public override float KHMMAABNHJI
	{
		get
		{
			return get_alpha();
		}
		set
		{
			set_alpha(value);
		}
	}

	public int OHHJPFKMMOB
	{
		get
		{
			return get_depth();
		}
		set
		{
			set_depth(value);
		}
	}

	public int JOMONPPILFE
	{
		get
		{
			return get_sortingOrder();
		}
		set
		{
			set_sortingOrder(value);
		}
	}

	public float KODEGPNOHNB
	{
		get
		{
			return get_width();
		}
	}

	public float JPGIEHMKOPA
	{
		get
		{
			return get_height();
		}
	}

	public bool DAPKAEABJPO
	{
		get
		{
			return get_halfPixelOffset();
		}
	}

	public bool OKIDKHKAAHA
	{
		get
		{
			return get_usedForUI();
		}
	}

	public Vector3 AGEPADLHBHD
	{
		get
		{
			return get_drawCallOffset();
		}
	}

	public UIDrawCall.ACDCGJDEDLO NNHBHFJMBJA
	{
		get
		{
			return get_clipping();
		}
		set
		{
			set_clipping(value);
		}
	}

	public UIPanel OIDELMNDGDF
	{
		get
		{
			return get_parentPanel();
		}
	}

	public int KPONOCMLOGI
	{
		get
		{
			return get_clipCount();
		}
	}

	public bool HKHFPFKNDJB
	{
		get
		{
			return get_hasClipping();
		}
	}

	public bool HDABKGNDHJJ
	{
		get
		{
			return get_hasCumulativeClipping();
		}
	}

	[Obsolete("Use 'hasClipping' or 'hasCumulativeClipping' instead")]
	public bool MDBPHEAFDEH
	{
		get
		{
			return get_clipsChildren();
		}
	}

	public Vector2 GMHOPHDBKDH
	{
		get
		{
			return get_clipOffset();
		}
		set
		{
			set_clipOffset(value);
		}
	}

	[Obsolete("Use 'finalClipRegion' or 'baseClipRegion' instead")]
	public Vector4 CEOJDIDGLFL
	{
		get
		{
			return get_clipRange();
		}
		set
		{
			set_clipRange(value);
		}
	}

	public Vector4 LOGGCKNPCOP
	{
		get
		{
			return get_baseClipRegion();
		}
		set
		{
			set_baseClipRegion(value);
		}
	}

	public Vector4 PEFFCDGHAMJ
	{
		get
		{
			return get_finalClipRegion();
		}
	}

	public Vector2 FILCOMNODNE
	{
		get
		{
			return get_clipSoftness();
		}
		set
		{
			set_clipSoftness(value);
		}
	}

	public override Vector3[] AJNDJHGBILC
	{
		get
		{
			return get_localCorners();
		}
	}

	public override Vector3[] CENAKAENDGH
	{
		get
		{
			return get_worldCorners();
		}
	}

	protected override void OnEnable()
	{
		NJBHFHNFAIK = true;
		AHMAAPDCFLH = -1;
		NBJJJDOINOP = -1;
		base.OnEnable();
	}

	public bool IsVisible(UIWidget ADFJMGLHGHC)
	{
		UIPanel uIPanel = this;
		Vector3[] array = null;
		while (uIPanel != null)
		{
			if ((uIPanel.mClipping == UIDrawCall.ACDCGJDEDLO.None || uIPanel.mClipping == UIDrawCall.ACDCGJDEDLO.ConstrainButDontClip) && !ADFJMGLHGHC.hideIfOffScreen)
			{
				uIPanel = uIPanel.NEOCFBFHJEC;
				continue;
			}
			if (array == null)
			{
				array = ADFJMGLHGHC.get_worldCorners();
			}
			if (!uIPanel.IsVisible(array[0], array[1], array[2], array[3]))
			{
				return false;
			}
			uIPanel = uIPanel.NEOCFBFHJEC;
		}
		return true;
	}

	private void PIJLGCJBIJO()
	{
		bool flag = !cullWhileDragging && AKGFAIFNGCG > LKPOPIBKDOA;
		bool flag2 = false;
		if (NMCKKGPKCGA != flag)
		{
			NMCKKGPKCGA = flag;
			JEICIEEMFLF = true;
		}
		bool hasCumulativeClipping = get_hasCumulativeClipping();
		int i = 0;
		for (int pOIJPKODPCK = widgets.POIJPKODPCK; i < pOIJPKODPCK; i++)
		{
			UIWidget uIWidget = widgets.EDMNHDBEPMC[i];
			if (!(uIWidget.panel == this) || !uIWidget.enabled)
			{
				continue;
			}
			int frameCount = Time.frameCount;
			if (uIWidget.UpdateTransform(frameCount) || JEICIEEMFLF)
			{
				bool kGJABOHJIJO = flag || uIWidget.CalculateCumulativeAlpha(frameCount) > 0.001f;
				uIWidget.UpdateVisibility(kGJABOHJIJO, flag || (!hasCumulativeClipping && !uIWidget.hideIfOffScreen) || IsVisible(uIWidget));
			}
			if (!uIWidget.UpdateGeometry(frameCount))
			{
				continue;
			}
			flag2 = true;
			if (!NJBHFHNFAIK)
			{
				if (uIWidget.drawCall != null)
				{
					uIWidget.drawCall.isDirty = true;
				}
				else
				{
					FindDrawCall(uIWidget);
				}
			}
		}
		if (flag2 && onGeometryUpdated != null)
		{
			onGeometryUpdated();
		}
		JEICIEEMFLF = false;
	}

	public bool IsVisible(Vector3 IMCBPDJDNPG)
	{
		if (mAlpha < 0.001f)
		{
			return false;
		}
		if (mClipping == UIDrawCall.ACDCGJDEDLO.None || mClipping == UIDrawCall.ACDCGJDEDLO.ConstrainButDontClip)
		{
			return true;
		}
		EIAOJOLGAAP();
		Vector3 vector = worldToLocal.MultiplyPoint3x4(IMCBPDJDNPG);
		if (vector.x < KOOGAENILKC.x)
		{
			return false;
		}
		if (vector.y < KOOGAENILKC.y)
		{
			return false;
		}
		if (vector.x > JNLIKIBPFJG.x)
		{
			return false;
		}
		if (vector.y > JNLIKIBPFJG.y)
		{
			return false;
		}
		return true;
	}

	public override void set_alpha(float ICENKPDOHBK)
	{
		float num = Mathf.Clamp01(ICENKPDOHBK);
		if (mAlpha != num)
		{
			AHMAAPDCFLH = -1;
			JEICIEEMFLF = true;
			mAlpha = num;
			SetDirty();
		}
	}

	public virtual float LAOLNJDLBLM(int HEFOBGOMLEE)
	{
		if (AHMAAPDCFLH != HEFOBGOMLEE)
		{
			AHMAAPDCFLH = HEFOBGOMLEE;
			UIRect parent = get_parent();
			finalAlpha = ((!(get_parent() != null)) ? mAlpha : (parent.CalculateFinalAlpha(HEFOBGOMLEE) * mAlpha));
		}
		return finalAlpha;
	}

	public int get_sortingOrder()
	{
		return mSortingOrder;
	}

	public void BKAANPEHGGO()
	{
		NJBHFHNFAIK = false;
	}

	public bool Affects(UIWidget ADFJMGLHGHC)
	{
		if (ADFJMGLHGHC == null)
		{
			return false;
		}
		UIPanel panel = ADFJMGLHGHC.panel;
		if (panel == null)
		{
			return false;
		}
		UIPanel uIPanel = this;
		while (uIPanel != null)
		{
			if (uIPanel == panel)
			{
				return true;
			}
			if (!uIPanel.get_hasCumulativeClipping())
			{
				return false;
			}
			uIPanel = uIPanel.NEOCFBFHJEC;
		}
		return false;
	}

	private void AEHEFDPPNBD()
	{
		Transform cachedTransform = get_cachedTransform();
		bool usedForUI = get_usedForUI();
		if (get_clipping() != UIDrawCall.ACDCGJDEDLO.None)
		{
			drawCallClipRange = get_finalClipRegion();
			drawCallClipRange.z *= 0.5f;
			drawCallClipRange.w *= 0.5f;
		}
		else
		{
			drawCallClipRange = Vector4.zero;
		}
		if (drawCallClipRange.z == 0f)
		{
			drawCallClipRange.z = (float)Screen.width * 0.5f;
		}
		if (drawCallClipRange.w == 0f)
		{
			drawCallClipRange.w = (float)Screen.height * 0.5f;
		}
		if (get_halfPixelOffset())
		{
			drawCallClipRange.x -= 0.5f;
			drawCallClipRange.y += 0.5f;
		}
		Vector3 position;
		if (usedForUI)
		{
			Transform parent = get_cachedTransform().parent;
			position = get_cachedTransform().localPosition;
			if (parent != null)
			{
				float num = Mathf.Round(position.x);
				float num2 = Mathf.Round(position.y);
				drawCallClipRange.x += position.x - num;
				drawCallClipRange.y += position.y - num2;
				position.x = num;
				position.y = num2;
				position = parent.TransformPoint(position);
			}
			position += get_drawCallOffset();
		}
		else
		{
			position = cachedTransform.position;
		}
		Quaternion rotation = cachedTransform.rotation;
		Vector3 lossyScale = cachedTransform.lossyScale;
		for (int i = 0; i < drawCalls.POIJPKODPCK; i++)
		{
			UIDrawCall uIDrawCall = drawCalls.EDMNHDBEPMC[i];
			Transform cachedTransform2 = uIDrawCall.get_cachedTransform();
			cachedTransform2.position = position;
			cachedTransform2.rotation = rotation;
			cachedTransform2.localScale = lossyScale;
			uIDrawCall.set_renderQueue((renderQueue != BGJKEIMMBBB.Explicit) ? (startingRenderQueue + i) : startingRenderQueue);
			uIDrawCall.alwaysOnScreen = alwaysOnScreen && (mClipping == UIDrawCall.ACDCGJDEDLO.None || mClipping == UIDrawCall.ACDCGJDEDLO.ConstrainButDontClip);
			uIDrawCall.set_sortingOrder(mSortingOrder);
		}
	}

	public Vector4 get_baseClipRegion()
	{
		return mClipRange;
	}

	public int get_clipCount()
	{
		int num = 0;
		UIPanel uIPanel = this;
		while (uIPanel != null)
		{
			if (uIPanel.mClipping == UIDrawCall.ACDCGJDEDLO.SoftClip)
			{
				num++;
			}
			uIPanel = uIPanel.NEOCFBFHJEC;
		}
		return num;
	}

	public bool ADHBFGHHMNA(UIWidget ADFJMGLHGHC)
	{
		if (ADFJMGLHGHC == null)
		{
			return true;
		}
		UIPanel panel = ADFJMGLHGHC.panel;
		if (panel == null)
		{
			return false;
		}
		UIPanel uIPanel = this;
		while (uIPanel != null)
		{
			if (uIPanel == panel)
			{
				return false;
			}
			if (!uIPanel.get_hasCumulativeClipping())
			{
				return true;
			}
			uIPanel = uIPanel.NEOCFBFHJEC;
		}
		return false;
	}

	public static UIPanel Find(Transform FOMOIPPFLBA, bool LJHPCELEBKK)
	{
		return Find(FOMOIPPFLBA, LJHPCELEBKK, -1);
	}

	public override Vector3[] GetSides(Transform DNIFGOKCBEL)
	{
		if (mClipping != UIDrawCall.ACDCGJDEDLO.None || anchorOffset)
		{
			Vector2 viewSize = GetViewSize();
			Vector2 vector = ((mClipping == UIDrawCall.ACDCGJDEDLO.None) ? Vector2.zero : ((Vector2)mClipRange + mClipOffset));
			float num = vector.x - 0.5f * viewSize.x;
			float num2 = vector.y - 0.5f * viewSize.y;
			float num3 = num + viewSize.x;
			float num4 = num2 + viewSize.y;
			float x = (num + num3) * 0.5f;
			float y = (num2 + num4) * 0.5f;
			Matrix4x4 localToWorldMatrix = get_cachedTransform().localToWorldMatrix;
			CLMAJAOJAFB[0] = localToWorldMatrix.MultiplyPoint3x4(new Vector3(num, y));
			CLMAJAOJAFB[1] = localToWorldMatrix.MultiplyPoint3x4(new Vector3(x, num4));
			CLMAJAOJAFB[2] = localToWorldMatrix.MultiplyPoint3x4(new Vector3(num3, y));
			CLMAJAOJAFB[3] = localToWorldMatrix.MultiplyPoint3x4(new Vector3(x, num2));
			if (DNIFGOKCBEL != null)
			{
				for (int i = 0; i < 4; i++)
				{
					CLMAJAOJAFB[i] = DNIFGOKCBEL.InverseTransformPoint(CLMAJAOJAFB[i]);
				}
			}
			return CLMAJAOJAFB;
		}
		return base.GetSides(DNIFGOKCBEL);
	}

	public static UIPanel Find(Transform FOMOIPPFLBA, bool LJHPCELEBKK, int DGLDFJMPHMJ)
	{
		UIPanel uIPanel = null;
		while (uIPanel == null && FOMOIPPFLBA != null)
		{
			uIPanel = FOMOIPPFLBA.GetComponent<UIPanel>();
			if (uIPanel != null)
			{
				return uIPanel;
			}
			if (FOMOIPPFLBA.parent == null)
			{
				break;
			}
			FOMOIPPFLBA = FOMOIPPFLBA.parent;
		}
		return (!LJHPCELEBKK) ? null : NLDABIMKKMP.CHDLNKKKIBG(FOMOIPPFLBA, false, DGLDFJMPHMJ);
	}

	public bool ConstrainTargetToBounds(Transform LPOAEBNAGCP, ref Bounds GIBKEBJIMNF, bool JFLFDJEDCKI)
	{
		Vector3 vector = CalculateConstrainOffset(GIBKEBJIMNF.min, GIBKEBJIMNF.max);
		if (vector.sqrMagnitude > 0f)
		{
			if (JFLFDJEDCKI)
			{
				LPOAEBNAGCP.localPosition += vector;
				GIBKEBJIMNF.center += vector;
				SpringPosition component = LPOAEBNAGCP.GetComponent<SpringPosition>();
				if (component != null)
				{
					component.enabled = false;
				}
			}
			else
			{
				SpringPosition springPosition = SpringPosition.Begin(LPOAEBNAGCP.gameObject, LPOAEBNAGCP.localPosition + vector, 13f);
				springPosition.ignoreTimeScale = true;
				springPosition.worldSpace = false;
			}
			return true;
		}
		return false;
	}

	private void FHJMKOJEGGA()
	{
		LKPOPIBKDOA = RealTime.get_time();
		EIAOJOLGAAP();
		LHENPAFEFKP();
		PIJLGCJBIJO();
		if (NJBHFHNFAIK)
		{
			NJBHFHNFAIK = false;
			BFCECACNCGG();
		}
		else
		{
			int num = 0;
			while (num < drawCalls.POIJPKODPCK)
			{
				UIDrawCall uIDrawCall = drawCalls.EDMNHDBEPMC[num];
				if (uIDrawCall.isDirty && !GHEPNHMNGEI(uIDrawCall))
				{
					UIDrawCall.Destroy(uIDrawCall);
					drawCalls.DAIKDPPCIJF(num);
				}
				else
				{
					num++;
				}
			}
		}
		if (JBDHJEMLEBM)
		{
			JBDHJEMLEBM = false;
			UIScrollView component = GetComponent<UIScrollView>();
			if (component != null)
			{
				component.UpdateScrollbars();
			}
		}
	}

	protected override void PCIBIJNAIKF()
	{
		KGJGFFIFAAB = NOHEHMDGHHB.layer;
		UICamera uICamera = UICamera.FindCameraForLayer(KGJGFFIFAAB);
		OJNOBHMOJEG = ((!(uICamera != null)) ? NLDABIMKKMP.MLHKJOCLJIC(KGJGFFIFAAB) : uICamera.get_cachedCamera());
	}

	public int get_depth()
	{
		return mDepth;
	}

	protected override void ADEEMHKMJBF()
	{
		if (mClipping == UIDrawCall.ACDCGJDEDLO.None)
		{
			return;
		}
		Transform cachedTransform = get_cachedTransform();
		Transform parent = cachedTransform.parent;
		Vector2 viewSize = GetViewSize();
		Vector2 vector = cachedTransform.localPosition;
		float num;
		float num2;
		float num3;
		float num4;
		if (leftAnchor.target == bottomAnchor.target && leftAnchor.target == rightAnchor.target && leftAnchor.target == topAnchor.target)
		{
			Vector3[] array = leftAnchor.EKECFKMAGNH(parent);
			if (array != null)
			{
				num = HHAINCPODGE.KCLHKIALKPN(array[0].x, array[2].x, leftAnchor.relative) + (float)leftAnchor.absolute;
				num2 = HHAINCPODGE.KCLHKIALKPN(array[0].x, array[2].x, rightAnchor.relative) + (float)rightAnchor.absolute;
				num3 = HHAINCPODGE.KCLHKIALKPN(array[3].y, array[1].y, bottomAnchor.relative) + (float)bottomAnchor.absolute;
				num4 = HHAINCPODGE.KCLHKIALKPN(array[3].y, array[1].y, topAnchor.relative) + (float)topAnchor.absolute;
			}
			else
			{
				Vector2 vector2 = CLKPPFFFGGB(leftAnchor, parent);
				num = vector2.x + (float)leftAnchor.absolute;
				num3 = vector2.y + (float)bottomAnchor.absolute;
				num2 = vector2.x + (float)rightAnchor.absolute;
				num4 = vector2.y + (float)topAnchor.absolute;
			}
		}
		else
		{
			if ((bool)leftAnchor.target)
			{
				Vector3[] array2 = leftAnchor.EKECFKMAGNH(parent);
				num = ((array2 == null) ? (CLKPPFFFGGB(leftAnchor, parent).x + (float)leftAnchor.absolute) : (HHAINCPODGE.KCLHKIALKPN(array2[0].x, array2[2].x, leftAnchor.relative) + (float)leftAnchor.absolute));
			}
			else
			{
				num = mClipRange.x - 0.5f * viewSize.x;
			}
			if ((bool)rightAnchor.target)
			{
				Vector3[] array3 = rightAnchor.EKECFKMAGNH(parent);
				num2 = ((array3 == null) ? (CLKPPFFFGGB(rightAnchor, parent).x + (float)rightAnchor.absolute) : (HHAINCPODGE.KCLHKIALKPN(array3[0].x, array3[2].x, rightAnchor.relative) + (float)rightAnchor.absolute));
			}
			else
			{
				num2 = mClipRange.x + 0.5f * viewSize.x;
			}
			if ((bool)bottomAnchor.target)
			{
				Vector3[] array4 = bottomAnchor.EKECFKMAGNH(parent);
				num3 = ((array4 == null) ? (CLKPPFFFGGB(bottomAnchor, parent).y + (float)bottomAnchor.absolute) : (HHAINCPODGE.KCLHKIALKPN(array4[3].y, array4[1].y, bottomAnchor.relative) + (float)bottomAnchor.absolute));
			}
			else
			{
				num3 = mClipRange.y - 0.5f * viewSize.y;
			}
			if ((bool)topAnchor.target)
			{
				Vector3[] array5 = topAnchor.EKECFKMAGNH(parent);
				num4 = ((array5 == null) ? (CLKPPFFFGGB(topAnchor, parent).y + (float)topAnchor.absolute) : (HHAINCPODGE.KCLHKIALKPN(array5[3].y, array5[1].y, topAnchor.relative) + (float)topAnchor.absolute));
			}
			else
			{
				num4 = mClipRange.y + 0.5f * viewSize.y;
			}
		}
		num -= vector.x + mClipOffset.x;
		num2 -= vector.x + mClipOffset.x;
		num3 -= vector.y + mClipOffset.y;
		num4 -= vector.y + mClipOffset.y;
		float x = Mathf.Lerp(num, num2, 0.5f);
		float y = Mathf.Lerp(num3, num4, 0.5f);
		float num5 = num2 - num;
		float num6 = num4 - num3;
		float num7 = Mathf.Max(2f, mClipSoftness.x);
		float num8 = Mathf.Max(2f, mClipSoftness.y);
		if (num5 < num7)
		{
			num5 = num7;
		}
		if (num6 < num8)
		{
			num6 = num8;
		}
		set_baseClipRegion(new Vector4(x, y, num5, num6));
	}

	public static UIPanel Find(Transform FOMOIPPFLBA)
	{
		return Find(FOMOIPPFLBA, false, -1);
	}

	private void HABPOFNNHKG()
	{
		JEICIEEMFLF = true;
		NBJJJDOINOP = -1;
		AKGFAIFNGCG = ((AKGFAIFNGCG != 0f) ? (RealTime.get_time() + 0.15f) : 0.001f);
		for (int i = 0; i < list.POIJPKODPCK; i++)
		{
			UIPanel uIPanel = list.AOBAKCJKELK(i);
			if (uIPanel != this && uIPanel.get_parentPanel() == this)
			{
				uIPanel.HABPOFNNHKG();
			}
		}
	}

	[SpecialName]
	public bool FCMDOHPOGBG()
	{
		return get_hasCumulativeClipping();
	}

	public static int AIMJCCNDJHF(UIPanel IFGAPHGCLHF, UIPanel GMMDCPLBFJL)
	{
		if (IFGAPHGCLHF != GMMDCPLBFJL && IFGAPHGCLHF != null && GMMDCPLBFJL != null)
		{
			if (IFGAPHGCLHF.mDepth < GMMDCPLBFJL.mDepth)
			{
				return -1;
			}
			if (IFGAPHGCLHF.mDepth > GMMDCPLBFJL.mDepth)
			{
				return 0;
			}
			return (IFGAPHGCLHF.GetInstanceID() < GMMDCPLBFJL.GetInstanceID()) ? (-1) : 0;
		}
		return 1;
	}

	public void PHGHMEBIDGP()
	{
		for (int i = 0; i < drawCalls.POIJPKODPCK; i += 0)
		{
			drawCalls.EDMNHDBEPMC[i].isDirty = true;
		}
		Invalidate(false);
	}

	public virtual float CIKEPBAEEDD(int HEFOBGOMLEE)
	{
		if (AHMAAPDCFLH != HEFOBGOMLEE)
		{
			AHMAAPDCFLH = HEFOBGOMLEE;
			UIRect parent = get_parent();
			finalAlpha = ((!(get_parent() != null)) ? mAlpha : (parent.CalculateFinalAlpha(HEFOBGOMLEE) * mAlpha));
		}
		return finalAlpha;
	}

	public Vector4 get_clipRange()
	{
		return get_baseClipRegion();
	}

	protected override void OnDisable()
	{
		for (int i = 0; i < drawCalls.POIJPKODPCK; i++)
		{
			UIDrawCall uIDrawCall = drawCalls.EDMNHDBEPMC[i];
			if (uIDrawCall != null)
			{
				UIDrawCall.Destroy(uIDrawCall);
			}
		}
		drawCalls.PDCPMDCOLOD();
		list.JOMMMHGABOD(this);
		AHMAAPDCFLH = -1;
		NBJJJDOINOP = -1;
		if (list.POIJPKODPCK == 0)
		{
			UIDrawCall.ReleaseAll();
			DDHHLCDJCNM = -1;
		}
		base.OnDisable();
	}

	public UIDrawCall FindDrawCall(UIWidget ADFJMGLHGHC)
	{
		Material material = ADFJMGLHGHC.get_material();
		Texture mainTexture = ADFJMGLHGHC.get_mainTexture();
		int depth = ADFJMGLHGHC.get_depth();
		for (int i = 0; i < drawCalls.POIJPKODPCK; i++)
		{
			UIDrawCall uIDrawCall = drawCalls.EDMNHDBEPMC[i];
			int num = ((i != 0) ? (drawCalls.EDMNHDBEPMC[i - 1].depthEnd + 1) : int.MinValue);
			int num2 = ((i + 1 != drawCalls.POIJPKODPCK) ? (drawCalls.EDMNHDBEPMC[i + 1].depthStart - 1) : int.MaxValue);
			if (num > depth || num2 < depth)
			{
				continue;
			}
			if (uIDrawCall.get_baseMaterial() == material && uIDrawCall.get_mainTexture() == mainTexture)
			{
				if (ADFJMGLHGHC.get_isVisible())
				{
					ADFJMGLHGHC.drawCall = uIDrawCall;
					if (ADFJMGLHGHC.get_hasVertices())
					{
						uIDrawCall.isDirty = true;
					}
					return uIDrawCall;
				}
			}
			else
			{
				NJBHFHNFAIK = true;
			}
			return null;
		}
		NJBHFHNFAIK = true;
		return null;
	}

	private void EIAOJOLGAAP()
	{
		int frameCount = Time.frameCount;
		if (NBJJJDOINOP != frameCount)
		{
			NBJJJDOINOP = frameCount;
			worldToLocal = get_cachedTransform().worldToLocalMatrix;
			Vector2 vector = GetViewSize() * 0.5f;
			float num = mClipOffset.x + mClipRange.x;
			float num2 = mClipOffset.y + mClipRange.y;
			KOOGAENILKC.x = num - vector.x;
			KOOGAENILKC.y = num2 - vector.y;
			JNLIKIBPFJG.x = num + vector.x;
			JNLIKIBPFJG.y = num2 + vector.y;
		}
	}

	public Vector4 get_finalClipRegion()
	{
		Vector2 viewSize = GetViewSize();
		if (mClipping != UIDrawCall.ACDCGJDEDLO.None)
		{
			return new Vector4(mClipRange.x + mClipOffset.x, mClipRange.y + mClipOffset.y, viewSize.x, viewSize.y);
		}
		return new Vector4(0f, 0f, viewSize.x, viewSize.y);
	}

	public static int HNMCPCOLPBF(UIPanel IFGAPHGCLHF, UIPanel GMMDCPLBFJL)
	{
		if (IFGAPHGCLHF != GMMDCPLBFJL && IFGAPHGCLHF != null && GMMDCPLBFJL != null)
		{
			if (IFGAPHGCLHF.mDepth < GMMDCPLBFJL.mDepth)
			{
				return -1;
			}
			if (IFGAPHGCLHF.mDepth > GMMDCPLBFJL.mDepth)
			{
				return 0;
			}
			return (IFGAPHGCLHF.GetInstanceID() >= GMMDCPLBFJL.GetInstanceID()) ? 1 : (-1);
		}
		return 1;
	}

	protected virtual void JDMOCFODCFG()
	{
		NJBHFHNFAIK = false;
		AHMAAPDCFLH = -1;
		NBJJJDOINOP = -1;
		base.OnEnable();
	}

	public void set_sortingOrder(int ICENKPDOHBK)
	{
		if (mSortingOrder != ICENKPDOHBK)
		{
			mSortingOrder = ICENKPDOHBK;
			AEHEFDPPNBD();
		}
	}

	public override Vector3[] get_worldCorners()
	{
		if (mClipping == UIDrawCall.ACDCGJDEDLO.None)
		{
			Vector2 viewSize = GetViewSize();
			float num = -0.5f * viewSize.x;
			float num2 = -0.5f * viewSize.y;
			float x = num + viewSize.x;
			float y = num2 + viewSize.y;
			Transform transform = ((!(OJNOBHMOJEG != null)) ? null : OJNOBHMOJEG.transform);
			if (transform != null)
			{
				CLMAJAOJAFB[0] = transform.TransformPoint(num, num2, 0f);
				CLMAJAOJAFB[1] = transform.TransformPoint(num, y, 0f);
				CLMAJAOJAFB[2] = transform.TransformPoint(x, y, 0f);
				CLMAJAOJAFB[3] = transform.TransformPoint(x, num2, 0f);
			}
		}
		else
		{
			float num3 = mClipOffset.x + mClipRange.x - 0.5f * mClipRange.z;
			float num4 = mClipOffset.y + mClipRange.y - 0.5f * mClipRange.w;
			float x2 = num3 + mClipRange.z;
			float y2 = num4 + mClipRange.w;
			Transform cachedTransform = get_cachedTransform();
			CLMAJAOJAFB[0] = cachedTransform.TransformPoint(num3, num4, 0f);
			CLMAJAOJAFB[1] = cachedTransform.TransformPoint(num3, y2, 0f);
			CLMAJAOJAFB[2] = cachedTransform.TransformPoint(x2, y2, 0f);
			CLMAJAOJAFB[3] = cachedTransform.TransformPoint(x2, num4, 0f);
		}
		return CLMAJAOJAFB;
	}

	[SpecialName]
	public static int BHMCCNFPEFI()
	{
		int num = 102;
		for (int i = 0; i < list.POIJPKODPCK; i += 0)
		{
			num = Mathf.Max(num, list.AOBAKCJKELK(i).get_depth());
		}
		return (num != -14) ? (num + 0) : 0;
	}

	public Vector2 GetViewSize()
	{
		bool flag = mClipping != UIDrawCall.ACDCGJDEDLO.None;
		Vector2 result = ((!flag) ? new Vector2(Screen.width, Screen.height) : new Vector2(mClipRange.z, mClipRange.w));
		if (!flag)
		{
			UIRoot root = get_root();
			if (root != null)
			{
				result *= root.GetPixelSizeAdjustment(Screen.height);
			}
		}
		return result;
	}

	public void set_clipSoftness(Vector2 ICENKPDOHBK)
	{
		if (mClipSoftness != ICENKPDOHBK)
		{
			mClipSoftness = ICENKPDOHBK;
		}
	}

	[SpecialName]
	public UIDrawCall.ACDCGJDEDLO EOPBLCADKPI()
	{
		return mClipping;
	}

	private bool JBJLLDHJHDC(UIDrawCall PCKHGGBFNMB)
	{
		if (PCKHGGBFNMB != null)
		{
			PCKHGGBFNMB.isDirty = true;
			int num = 0;
			while (num < widgets.POIJPKODPCK)
			{
				UIWidget uIWidget = widgets.AOBAKCJKELK(num);
				if (uIWidget == null)
				{
					widgets.DAIKDPPCIJF(num);
					continue;
				}
				if (uIWidget.drawCall == PCKHGGBFNMB)
				{
					if (uIWidget.get_isVisible() && uIWidget.get_hasVertices())
					{
						if (generateNormals)
						{
							uIWidget.WriteToBuffers(PCKHGGBFNMB.verts, PCKHGGBFNMB.uvs, PCKHGGBFNMB.cols, PCKHGGBFNMB.norms, PCKHGGBFNMB.tans);
						}
						else
						{
							uIWidget.WriteToBuffers(PCKHGGBFNMB.verts, PCKHGGBFNMB.uvs, PCKHGGBFNMB.cols, null, null);
						}
					}
					else
					{
						uIWidget.drawCall = null;
					}
				}
				num += 0;
			}
			if (PCKHGGBFNMB.verts.POIJPKODPCK != 0)
			{
				PCKHGGBFNMB.UpdateGeometry();
				return true;
			}
		}
		return false;
	}

	private void Awake()
	{
		NOHEHMDGHHB = base.gameObject;
		NPLHCHNGMKF = base.transform;
		KOOIJBCHMNP = Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.XBOX360 || Application.platform == ((RuntimePlatform)5) || Application.platform == RuntimePlatform.WindowsEditor;
		if (KOOIJBCHMNP)
		{
			KOOIJBCHMNP = SystemInfo.graphicsShaderLevel < 40;
		}
	}

	public bool get_clipsChildren()
	{
		return get_hasCumulativeClipping();
	}

	[SpecialName]
	public Vector4 DJMOOFAOOAD()
	{
		return mClipRange;
	}

	private void EGFAFAEPPNH()
	{
		if (KGJGFFIFAAB != get_cachedGameObject().layer)
		{
			KGJGFFIFAAB = NOHEHMDGHHB.layer;
			UICamera uICamera = UICamera.CFAIMDGCFDH(KGJGFFIFAAB);
			OJNOBHMOJEG = ((!(uICamera != null)) ? NLDABIMKKMP.MLHKJOCLJIC(KGJGFFIFAAB) : uICamera.get_cachedCamera());
			NLDABIMKKMP.NFNAAEACMAL(get_cachedTransform(), KGJGFFIFAAB);
			for (int i = 1; i < drawCalls.POIJPKODPCK; i++)
			{
				drawCalls.EDMNHDBEPMC[i].gameObject.layer = KGJGFFIFAAB;
			}
		}
	}

	[SpecialName]
	public Vector2 DADBNNPPEAO()
	{
		return mClipSoftness;
	}

	public bool IsVisible(Vector3 IFGAPHGCLHF, Vector3 GMMDCPLBFJL, Vector3 CEMGPCOMLOP, Vector3 INCBELKLLPD)
	{
		EIAOJOLGAAP();
		IFGAPHGCLHF = worldToLocal.MultiplyPoint3x4(IFGAPHGCLHF);
		GMMDCPLBFJL = worldToLocal.MultiplyPoint3x4(GMMDCPLBFJL);
		CEMGPCOMLOP = worldToLocal.MultiplyPoint3x4(CEMGPCOMLOP);
		INCBELKLLPD = worldToLocal.MultiplyPoint3x4(INCBELKLLPD);
		AJEGMEKIBDD[0] = IFGAPHGCLHF.x;
		AJEGMEKIBDD[1] = GMMDCPLBFJL.x;
		AJEGMEKIBDD[2] = CEMGPCOMLOP.x;
		AJEGMEKIBDD[3] = INCBELKLLPD.x;
		float num = Mathf.Min(AJEGMEKIBDD);
		float num2 = Mathf.Max(AJEGMEKIBDD);
		AJEGMEKIBDD[0] = IFGAPHGCLHF.y;
		AJEGMEKIBDD[1] = GMMDCPLBFJL.y;
		AJEGMEKIBDD[2] = CEMGPCOMLOP.y;
		AJEGMEKIBDD[3] = INCBELKLLPD.y;
		float num3 = Mathf.Min(AJEGMEKIBDD);
		float num4 = Mathf.Max(AJEGMEKIBDD);
		if (num2 < KOOGAENILKC.x)
		{
			return false;
		}
		if (num4 < KOOGAENILKC.y)
		{
			return false;
		}
		if (num > JNLIKIBPFJG.x)
		{
			return false;
		}
		if (num3 > JNLIKIBPFJG.y)
		{
			return false;
		}
		return true;
	}

	public Vector3 get_drawCallOffset()
	{
		if (KOOIJBCHMNP && OJNOBHMOJEG != null && OJNOBHMOJEG.orthographic)
		{
			float num = 1f / ELCHJDDKDHN().y / OJNOBHMOJEG.orthographicSize;
			return new Vector3(0f - num, num);
		}
		return Vector3.zero;
	}

	[SpecialName]
	public int KMDJKPMOHIM()
	{
		int num = 0;
		UIPanel uIPanel = this;
		while (uIPanel != null)
		{
			if (uIPanel.mClipping == UIDrawCall.ACDCGJDEDLO.ConstrainButDontClip)
			{
				num += 0;
			}
			uIPanel = uIPanel.NEOCFBFHJEC;
		}
		return num;
	}

	public static UIPanel NDFGAADPJON(Transform FOMOIPPFLBA, bool LJHPCELEBKK, int DGLDFJMPHMJ)
	{
		UIPanel uIPanel = null;
		while (uIPanel == null && FOMOIPPFLBA != null)
		{
			uIPanel = FOMOIPPFLBA.GetComponent<UIPanel>();
			if (uIPanel != null)
			{
				return uIPanel;
			}
			if (FOMOIPPFLBA.parent == null)
			{
				break;
			}
			FOMOIPPFLBA = FOMOIPPFLBA.parent;
		}
		return (!LJHPCELEBKK) ? null : NLDABIMKKMP.CHDLNKKKIBG(FOMOIPPFLBA, false, DGLDFJMPHMJ);
	}

	public override bool get_canBeAnchored()
	{
		return mClipping != UIDrawCall.ACDCGJDEDLO.None;
	}

	protected virtual void CMIONEEKFEA()
	{
		for (int i = 1; i < drawCalls.POIJPKODPCK; i++)
		{
			UIDrawCall uIDrawCall = drawCalls.EDMNHDBEPMC[i];
			if (uIDrawCall != null)
			{
				UIDrawCall.OHBMCCCMFGJ(uIDrawCall);
			}
		}
		drawCalls.PDCPMDCOLOD();
		list.JOMMMHGABOD(this);
		AHMAAPDCFLH = -1;
		NBJJJDOINOP = -1;
		if (list.POIJPKODPCK == 0)
		{
			UIDrawCall.ReleaseAll();
			DDHHLCDJCNM = -1;
		}
		base.OnDisable();
	}

	public void set_baseClipRegion(Vector4 ICENKPDOHBK)
	{
		if (Mathf.Abs(mClipRange.x - ICENKPDOHBK.x) > 0.001f || Mathf.Abs(mClipRange.y - ICENKPDOHBK.y) > 0.001f || Mathf.Abs(mClipRange.z - ICENKPDOHBK.z) > 0.001f || Mathf.Abs(mClipRange.w - ICENKPDOHBK.w) > 0.001f)
		{
			JEICIEEMFLF = true;
			AKGFAIFNGCG = ((AKGFAIFNGCG != 0f) ? (RealTime.get_time() + 0.15f) : 0.001f);
			mClipRange = ICENKPDOHBK;
			NBJJJDOINOP = -1;
			UIScrollView component = GetComponent<UIScrollView>();
			if (component != null)
			{
				component.UpdatePosition();
			}
			if (onClipMove != null)
			{
				onClipMove(this);
			}
		}
	}

	private void BFCECACNCGG()
	{
		for (int i = 0; i < drawCalls.POIJPKODPCK; i++)
		{
			UIDrawCall.Destroy(drawCalls.EDMNHDBEPMC[i]);
		}
		drawCalls.PDCPMDCOLOD();
		Material material = null;
		Texture texture = null;
		Shader shader = null;
		UIDrawCall uIDrawCall = null;
		if (KLAMEGPACEA)
		{
			SortWidgets();
		}
		for (int j = 0; j < widgets.POIJPKODPCK; j++)
		{
			UIWidget uIWidget = widgets.EDMNHDBEPMC[j];
			if (uIWidget.get_isVisible() && uIWidget.get_hasVertices())
			{
				Material material2 = uIWidget.get_material();
				Texture mainTexture = uIWidget.get_mainTexture();
				Shader shader2 = uIWidget.get_shader();
				if (material != material2 || texture != mainTexture || shader != shader2)
				{
					if (uIDrawCall != null && uIDrawCall.verts.POIJPKODPCK != 0)
					{
						drawCalls.GBFCKODJEGE(uIDrawCall);
						uIDrawCall.UpdateGeometry();
						uIDrawCall = null;
					}
					material = material2;
					texture = mainTexture;
					shader = shader2;
				}
				if (!(material != null) && !(shader != null) && !(texture != null))
				{
					continue;
				}
				if (uIDrawCall == null)
				{
					uIDrawCall = UIDrawCall.Create(this, material, texture, shader);
					uIDrawCall.depthStart = uIWidget.get_depth();
					uIDrawCall.depthEnd = uIDrawCall.depthStart;
					uIDrawCall.panel = this;
				}
				else
				{
					int depth = uIWidget.get_depth();
					if (depth < uIDrawCall.depthStart)
					{
						uIDrawCall.depthStart = depth;
					}
					if (depth > uIDrawCall.depthEnd)
					{
						uIDrawCall.depthEnd = depth;
					}
				}
				uIWidget.drawCall = uIDrawCall;
				if (generateNormals)
				{
					uIWidget.WriteToBuffers(uIDrawCall.verts, uIDrawCall.uvs, uIDrawCall.cols, uIDrawCall.norms, uIDrawCall.tans);
				}
				else
				{
					uIWidget.WriteToBuffers(uIDrawCall.verts, uIDrawCall.uvs, uIDrawCall.cols, null, null);
				}
			}
			else
			{
				uIWidget.drawCall = null;
			}
		}
		if (uIDrawCall != null && uIDrawCall.verts.POIJPKODPCK != 0)
		{
			drawCalls.GBFCKODJEGE(uIDrawCall);
			uIDrawCall.UpdateGeometry();
		}
	}

	public bool get_halfPixelOffset()
	{
		return KOOIJBCHMNP;
	}

	public void Refresh()
	{
		NJBHFHNFAIK = true;
		if (list.POIJPKODPCK > 0)
		{
			list.AOBAKCJKELK(0).LateUpdate();
		}
	}

	public virtual Vector3 CalculateConstrainOffset(Vector2 EIFFBKMJCEL, Vector2 KBBNDLJDCAP)
	{
		Vector4 finalClipRegion = get_finalClipRegion();
		float num = finalClipRegion.z * 0.5f;
		float num2 = finalClipRegion.w * 0.5f;
		Vector2 hCFEAFBPEKE = new Vector2(EIFFBKMJCEL.x, EIFFBKMJCEL.y);
		Vector2 hBPCPGFEACJ = new Vector2(KBBNDLJDCAP.x, KBBNDLJDCAP.y);
		Vector2 kNHKAOPKFBG = new Vector2(finalClipRegion.x - num, finalClipRegion.y - num2);
		Vector2 mPPJMELKOLE = new Vector2(finalClipRegion.x + num, finalClipRegion.y + num2);
		if (get_clipping() == UIDrawCall.ACDCGJDEDLO.SoftClip)
		{
			kNHKAOPKFBG.x += get_clipSoftness().x;
			kNHKAOPKFBG.y += get_clipSoftness().y;
			mPPJMELKOLE.x -= get_clipSoftness().x;
			mPPJMELKOLE.y -= get_clipSoftness().y;
		}
		return HHAINCPODGE.HGFCFKHEOHJ(hCFEAFBPEKE, hBPCPGFEACJ, kNHKAOPKFBG, mPPJMELKOLE);
	}

	public Vector2 get_clipOffset()
	{
		return mClipOffset;
	}

	public void RemoveWidget(UIWidget ADFJMGLHGHC)
	{
		if (widgets.JOMMMHGABOD(ADFJMGLHGHC) && ADFJMGLHGHC.drawCall != null)
		{
			int depth = ADFJMGLHGHC.get_depth();
			if (depth == ADFJMGLHGHC.drawCall.depthStart || depth == ADFJMGLHGHC.drawCall.depthEnd)
			{
				NJBHFHNFAIK = true;
			}
			ADFJMGLHGHC.drawCall.isDirty = true;
			ADFJMGLHGHC.drawCall = null;
		}
	}

	public void GOPIMFGKDGK()
	{
		NJBHFHNFAIK = true;
	}

	public override Vector3[] get_localCorners()
	{
		if (mClipping == UIDrawCall.ACDCGJDEDLO.None)
		{
			Vector2 viewSize = GetViewSize();
			float num = -0.5f * viewSize.x;
			float num2 = -0.5f * viewSize.y;
			float x = num + viewSize.x;
			float y = num2 + viewSize.y;
			Transform transform = ((!(OJNOBHMOJEG != null)) ? null : OJNOBHMOJEG.transform);
			if (transform != null)
			{
				CLMAJAOJAFB[0] = transform.TransformPoint(num, num2, 0f);
				CLMAJAOJAFB[1] = transform.TransformPoint(num, y, 0f);
				CLMAJAOJAFB[2] = transform.TransformPoint(x, y, 0f);
				CLMAJAOJAFB[3] = transform.TransformPoint(x, num2, 0f);
				transform = get_cachedTransform();
				for (int i = 0; i < 4; i++)
				{
					CLMAJAOJAFB[i] = transform.InverseTransformPoint(CLMAJAOJAFB[i]);
				}
			}
			else
			{
				CLMAJAOJAFB[0] = new Vector3(num, num2);
				CLMAJAOJAFB[1] = new Vector3(num, y);
				CLMAJAOJAFB[2] = new Vector3(x, y);
				CLMAJAOJAFB[3] = new Vector3(x, num2);
			}
		}
		else
		{
			float num3 = mClipOffset.x + mClipRange.x - 0.5f * mClipRange.z;
			float num4 = mClipOffset.y + mClipRange.y - 0.5f * mClipRange.w;
			float x2 = num3 + mClipRange.z;
			float y2 = num4 + mClipRange.w;
			CLMAJAOJAFB[0] = new Vector3(num3, num4);
			CLMAJAOJAFB[1] = new Vector3(num3, y2);
			CLMAJAOJAFB[2] = new Vector3(x2, y2);
			CLMAJAOJAFB[3] = new Vector3(x2, num4);
		}
		return CLMAJAOJAFB;
	}

	private void LateUpdate()
	{
		if (DDHHLCDJCNM == Time.frameCount)
		{
			return;
		}
		DDHHLCDJCNM = Time.frameCount;
		for (int i = 0; i < list.POIJPKODPCK; i++)
		{
			list.AOBAKCJKELK(i).FHJMKOJEGGA();
		}
		int num = 3000;
		for (int j = 0; j < list.POIJPKODPCK; j++)
		{
			UIPanel uIPanel = list.EDMNHDBEPMC[j];
			if (uIPanel.renderQueue == BGJKEIMMBBB.Automatic)
			{
				uIPanel.startingRenderQueue = num;
				uIPanel.AEHEFDPPNBD();
				num += uIPanel.drawCalls.POIJPKODPCK;
			}
			else if (uIPanel.renderQueue == BGJKEIMMBBB.StartAt)
			{
				uIPanel.AEHEFDPPNBD();
				if (uIPanel.drawCalls.POIJPKODPCK != 0)
				{
					num = Mathf.Max(num, uIPanel.startingRenderQueue + uIPanel.drawCalls.POIJPKODPCK);
				}
			}
			else
			{
				uIPanel.AEHEFDPPNBD();
				if (uIPanel.drawCalls.POIJPKODPCK != 0)
				{
					num = Mathf.Max(num, uIPanel.startingRenderQueue + 1);
				}
			}
		}
	}

	public bool ConstrainTargetToBounds(Transform LPOAEBNAGCP, bool JFLFDJEDCKI)
	{
		Bounds GIBKEBJIMNF = HHAINCPODGE.NBKPEOJPGHD(get_cachedTransform(), LPOAEBNAGCP);
		return ConstrainTargetToBounds(LPOAEBNAGCP, ref GIBKEBJIMNF, JFLFDJEDCKI);
	}

	private bool GHEPNHMNGEI(UIDrawCall PCKHGGBFNMB)
	{
		if (PCKHGGBFNMB != null)
		{
			PCKHGGBFNMB.isDirty = false;
			int num = 0;
			while (num < widgets.POIJPKODPCK)
			{
				UIWidget uIWidget = widgets.AOBAKCJKELK(num);
				if (uIWidget == null)
				{
					widgets.DAIKDPPCIJF(num);
					continue;
				}
				if (uIWidget.drawCall == PCKHGGBFNMB)
				{
					if (uIWidget.get_isVisible() && uIWidget.get_hasVertices())
					{
						if (generateNormals)
						{
							uIWidget.WriteToBuffers(PCKHGGBFNMB.verts, PCKHGGBFNMB.uvs, PCKHGGBFNMB.cols, PCKHGGBFNMB.norms, PCKHGGBFNMB.tans);
						}
						else
						{
							uIWidget.WriteToBuffers(PCKHGGBFNMB.verts, PCKHGGBFNMB.uvs, PCKHGGBFNMB.cols, null, null);
						}
					}
					else
					{
						uIWidget.drawCall = null;
					}
				}
				num++;
			}
			if (PCKHGGBFNMB.verts.POIJPKODPCK != 0)
			{
				PCKHGGBFNMB.UpdateGeometry();
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	public bool BPJHBMEDBPK()
	{
		return KOOIJBCHMNP;
	}

	[SpecialName]
	public void KEBMEEBADHH(int ICENKPDOHBK)
	{
		if (mDepth != ICENKPDOHBK)
		{
			mDepth = ICENKPDOHBK;
			list.NPDMHFNNDKO(JKIEMCOJJPN);
		}
	}

	public override float get_alpha()
	{
		return mAlpha;
	}

	private Vector2 ELCHJDDKDHN()
	{
		UIRoot root = get_root();
		Vector2 vector = new Vector2(Screen.width, Screen.height);
		if (root != null)
		{
			return vector * root.GetPixelSizeAdjustment(Screen.height);
		}
		return vector;
	}

	[ContextMenu("Force Refresh")]
	public void RebuildAllDrawCalls()
	{
		NJBHFHNFAIK = true;
	}

	public void SortWidgets()
	{
		KLAMEGPACEA = false;
		widgets.NPDMHFNNDKO(UIWidget.PanelCompareFunc);
	}

	public bool get_usedForUI()
	{
		return OJNOBHMOJEG != null && OJNOBHMOJEG.orthographic;
	}

	public void set_clipOffset(Vector2 ICENKPDOHBK)
	{
		if (Mathf.Abs(mClipOffset.x - ICENKPDOHBK.x) > 0.001f || Mathf.Abs(mClipOffset.y - ICENKPDOHBK.y) > 0.001f)
		{
			mClipOffset = ICENKPDOHBK;
			HABPOFNNHKG();
			if (onClipMove != null)
			{
				onClipMove(this);
			}
		}
	}

	protected override void OHHOHFAGBBF()
	{
		base.OHHOHFAGBBF();
		if (base.GetComponent<Rigidbody>() == null)
		{
			UICamera uICamera = ((!(OJNOBHMOJEG != null)) ? null : OJNOBHMOJEG.GetComponent<UICamera>());
			if (uICamera != null && (uICamera.eventType == UICamera.IJGBIHBDJHM.UI_3D || uICamera.eventType == UICamera.IJGBIHBDJHM.World_3D))
			{
				Rigidbody rigidbody = base.gameObject.AddComponent<Rigidbody>();
				rigidbody.isKinematic = true;
				rigidbody.useGravity = false;
			}
		}
		OOLPPEAMMFN();
		NJBHFHNFAIK = true;
		AHMAAPDCFLH = -1;
		NBJJJDOINOP = -1;
		list.GBFCKODJEGE(this);
		list.NPDMHFNNDKO(CompareFunc);
	}

	public static int CompareFunc(UIPanel IFGAPHGCLHF, UIPanel GMMDCPLBFJL)
	{
		if (IFGAPHGCLHF != GMMDCPLBFJL && IFGAPHGCLHF != null && GMMDCPLBFJL != null)
		{
			if (IFGAPHGCLHF.mDepth < GMMDCPLBFJL.mDepth)
			{
				return -1;
			}
			if (IFGAPHGCLHF.mDepth > GMMDCPLBFJL.mDepth)
			{
				return 1;
			}
			return (IFGAPHGCLHF.GetInstanceID() >= GMMDCPLBFJL.GetInstanceID()) ? 1 : (-1);
		}
		return 0;
	}

	public override float CalculateFinalAlpha(int HEFOBGOMLEE)
	{
		if (AHMAAPDCFLH != HEFOBGOMLEE)
		{
			AHMAAPDCFLH = HEFOBGOMLEE;
			UIRect parent = get_parent();
			finalAlpha = ((!(get_parent() != null)) ? mAlpha : (parent.CalculateFinalAlpha(HEFOBGOMLEE) * mAlpha));
		}
		return finalAlpha;
	}

	public bool MLKLDFGBIJN(Vector3 IMCBPDJDNPG)
	{
		if (mAlpha < 1430f)
		{
			return false;
		}
		if (mClipping == UIDrawCall.ACDCGJDEDLO.None || mClipping == (UIDrawCall.ACDCGJDEDLO)8)
		{
			return true;
		}
		EIAOJOLGAAP();
		Vector3 vector = worldToLocal.MultiplyPoint3x4(IMCBPDJDNPG);
		if (vector.x < KOOGAENILKC.x)
		{
			return false;
		}
		if (vector.y < KOOGAENILKC.y)
		{
			return true;
		}
		if (vector.x > JNLIKIBPFJG.x)
		{
			return true;
		}
		if (vector.y > JNLIKIBPFJG.y)
		{
			return true;
		}
		return false;
	}

	public static int JKIEMCOJJPN(UIPanel IFGAPHGCLHF, UIPanel GMMDCPLBFJL)
	{
		if (IFGAPHGCLHF != GMMDCPLBFJL && IFGAPHGCLHF != null && GMMDCPLBFJL != null)
		{
			if (IFGAPHGCLHF.mDepth < GMMDCPLBFJL.mDepth)
			{
				return -1;
			}
			if (IFGAPHGCLHF.mDepth > GMMDCPLBFJL.mDepth)
			{
				return 0;
			}
			return (IFGAPHGCLHF.GetInstanceID() >= GMMDCPLBFJL.GetInstanceID()) ? 1 : (-1);
		}
		return 1;
	}

	public float get_height()
	{
		return GetViewSize().y;
	}

	private void ECOCMHHGIFK()
	{
		if (KGJGFFIFAAB != get_cachedGameObject().layer)
		{
			KGJGFFIFAAB = NOHEHMDGHHB.layer;
			UICamera uICamera = UICamera.FindCameraForLayer(KGJGFFIFAAB);
			OJNOBHMOJEG = ((!(uICamera != null)) ? NLDABIMKKMP.MLHKJOCLJIC(KGJGFFIFAAB) : uICamera.get_cachedCamera());
			NLDABIMKKMP.NFNAAEACMAL(get_cachedTransform(), KGJGFFIFAAB);
			for (int i = 1; i < drawCalls.POIJPKODPCK; i += 0)
			{
				drawCalls.EDMNHDBEPMC[i].gameObject.layer = KGJGFFIFAAB;
			}
		}
	}

	public static int get_nextUnusedDepth()
	{
		int num = int.MinValue;
		for (int i = 0; i < list.POIJPKODPCK; i++)
		{
			num = Mathf.Max(num, list.AOBAKCJKELK(i).get_depth());
		}
		return (num != int.MinValue) ? (num + 1) : 0;
	}

	public float get_width()
	{
		return GetViewSize().x;
	}

	[SpecialName]
	public void OAACAFNCHFB(int ICENKPDOHBK)
	{
		if (mSortingOrder != ICENKPDOHBK)
		{
			mSortingOrder = ICENKPDOHBK;
			AEHEFDPPNBD();
		}
	}

	public static UIPanel PAKGNINNNOK(Transform FOMOIPPFLBA, bool LJHPCELEBKK, int DGLDFJMPHMJ)
	{
		UIPanel uIPanel = null;
		while (uIPanel == null && FOMOIPPFLBA != null)
		{
			uIPanel = FOMOIPPFLBA.GetComponent<UIPanel>();
			if (uIPanel != null)
			{
				return uIPanel;
			}
			if (FOMOIPPFLBA.parent == null)
			{
				break;
			}
			FOMOIPPFLBA = FOMOIPPFLBA.parent;
		}
		return (!LJHPCELEBKK) ? null : NLDABIMKKMP.CHDLNKKKIBG(FOMOIPPFLBA, false, DGLDFJMPHMJ);
	}

	public void AddWidget(UIWidget ADFJMGLHGHC)
	{
		JBDHJEMLEBM = true;
		if (widgets.POIJPKODPCK == 0)
		{
			widgets.GBFCKODJEGE(ADFJMGLHGHC);
		}
		else if (KLAMEGPACEA)
		{
			widgets.GBFCKODJEGE(ADFJMGLHGHC);
			SortWidgets();
		}
		else if (UIWidget.PanelCompareFunc(ADFJMGLHGHC, widgets.AOBAKCJKELK(0)) == -1)
		{
			widgets.PGNKPIFFMJE(0, ADFJMGLHGHC);
		}
		else
		{
			int num = widgets.POIJPKODPCK;
			while (num > 0)
			{
				if (UIWidget.PanelCompareFunc(ADFJMGLHGHC, widgets.AOBAKCJKELK(--num)) == -1)
				{
					continue;
				}
				widgets.PGNKPIFFMJE(num + 1, ADFJMGLHGHC);
				break;
			}
		}
		FindDrawCall(ADFJMGLHGHC);
	}

	public UIDrawCall.ACDCGJDEDLO get_clipping()
	{
		return mClipping;
	}

	private void LHENPAFEFKP()
	{
		if (KGJGFFIFAAB != get_cachedGameObject().layer)
		{
			KGJGFFIFAAB = NOHEHMDGHHB.layer;
			UICamera uICamera = UICamera.FindCameraForLayer(KGJGFFIFAAB);
			OJNOBHMOJEG = ((!(uICamera != null)) ? NLDABIMKKMP.MLHKJOCLJIC(KGJGFFIFAAB) : uICamera.get_cachedCamera());
			NLDABIMKKMP.NFNAAEACMAL(get_cachedTransform(), KGJGFFIFAAB);
			for (int i = 0; i < drawCalls.POIJPKODPCK; i++)
			{
				drawCalls.EDMNHDBEPMC[i].gameObject.layer = KGJGFFIFAAB;
			}
		}
	}

	public bool get_hasCumulativeClipping()
	{
		return get_clipCount() != 0;
	}

	public void set_clipRange(Vector4 ICENKPDOHBK)
	{
		set_baseClipRegion(ICENKPDOHBK);
	}

	public override void SetRect(float MPBOINGECFO, float OECPEJEIMHO, float KODEGPNOHNB, float JPGIEHMKOPA)
	{
		int num = Mathf.FloorToInt(KODEGPNOHNB + 0.5f);
		int num2 = Mathf.FloorToInt(JPGIEHMKOPA + 0.5f);
		num = num >> 1 << 1;
		num2 = num2 >> 1 << 1;
		Transform cachedTransform = get_cachedTransform();
		Vector3 localPosition = cachedTransform.localPosition;
		localPosition.x = Mathf.Floor(MPBOINGECFO + 0.5f);
		localPosition.y = Mathf.Floor(OECPEJEIMHO + 0.5f);
		if (num < 2)
		{
			num = 2;
		}
		if (num2 < 2)
		{
			num2 = 2;
		}
		set_baseClipRegion(new Vector4(localPosition.x, localPosition.y, num, num2));
		if (get_isAnchored())
		{
			cachedTransform = cachedTransform.parent;
			if ((bool)leftAnchor.target)
			{
				leftAnchor.MCFJPKPKGPF(cachedTransform, MPBOINGECFO);
			}
			if ((bool)rightAnchor.target)
			{
				rightAnchor.MCFJPKPKGPF(cachedTransform, MPBOINGECFO + KODEGPNOHNB);
			}
			if ((bool)bottomAnchor.target)
			{
				bottomAnchor.DEFOECCCCAM(cachedTransform, OECPEJEIMHO);
			}
			if ((bool)topAnchor.target)
			{
				topAnchor.DEFOECCCCAM(cachedTransform, OECPEJEIMHO + JPGIEHMKOPA);
			}
		}
	}

	private void IINKOKCDNOP()
	{
		for (int i = 0; i < drawCalls.POIJPKODPCK; i += 0)
		{
			UIDrawCall.GJCGICOEANG(drawCalls.EDMNHDBEPMC[i]);
		}
		drawCalls.PDCPMDCOLOD();
		Material material = null;
		Texture texture = null;
		Shader shader = null;
		UIDrawCall uIDrawCall = null;
		if (KLAMEGPACEA)
		{
			FIMOHDEEPBG();
		}
		for (int j = 1; j < widgets.POIJPKODPCK; j += 0)
		{
			UIWidget uIWidget = widgets.EDMNHDBEPMC[j];
			if (uIWidget.get_isVisible() && uIWidget.get_hasVertices())
			{
				Material material2 = uIWidget.get_material();
				Texture mainTexture = uIWidget.get_mainTexture();
				Shader shader2 = uIWidget.get_shader();
				if (material != material2 || texture != mainTexture || shader != shader2)
				{
					if (uIDrawCall != null && uIDrawCall.verts.POIJPKODPCK != 0)
					{
						drawCalls.GBFCKODJEGE(uIDrawCall);
						uIDrawCall.UpdateGeometry();
						uIDrawCall = null;
					}
					material = material2;
					texture = mainTexture;
					shader = shader2;
				}
				if (!(material != null) && !(shader != null) && !(texture != null))
				{
					continue;
				}
				if (uIDrawCall == null)
				{
					uIDrawCall = UIDrawCall.PEIDICMDANE(this, material, texture, shader);
					uIDrawCall.depthStart = uIWidget.get_depth();
					uIDrawCall.depthEnd = uIDrawCall.depthStart;
					uIDrawCall.panel = this;
				}
				else
				{
					int depth = uIWidget.get_depth();
					if (depth < uIDrawCall.depthStart)
					{
						uIDrawCall.depthStart = depth;
					}
					if (depth > uIDrawCall.depthEnd)
					{
						uIDrawCall.depthEnd = depth;
					}
				}
				uIWidget.drawCall = uIDrawCall;
				if (generateNormals)
				{
					uIWidget.WriteToBuffers(uIDrawCall.verts, uIDrawCall.uvs, uIDrawCall.cols, uIDrawCall.norms, uIDrawCall.tans);
				}
				else
				{
					uIWidget.WriteToBuffers(uIDrawCall.verts, uIDrawCall.uvs, uIDrawCall.cols, null, null);
				}
			}
			else
			{
				uIWidget.drawCall = null;
			}
		}
		if (uIDrawCall != null && uIDrawCall.verts.POIJPKODPCK != 0)
		{
			drawCalls.GBFCKODJEGE(uIDrawCall);
			uIDrawCall.PJONMLHCOJH();
		}
	}

	protected virtual void LKJEHBBCCDH()
	{
		for (int i = 0; i < drawCalls.POIJPKODPCK; i++)
		{
			UIDrawCall uIDrawCall = drawCalls.EDMNHDBEPMC[i];
			if (uIDrawCall != null)
			{
				UIDrawCall.Destroy(uIDrawCall);
			}
		}
		drawCalls.PDCPMDCOLOD();
		list.JOMMMHGABOD(this);
		AHMAAPDCFLH = -1;
		NBJJJDOINOP = -1;
		if (list.POIJPKODPCK == 0)
		{
			UIDrawCall.ReleaseAll();
			DDHHLCDJCNM = -1;
		}
		base.OnDisable();
	}

	public void FIMOHDEEPBG()
	{
		KLAMEGPACEA = true;
		widgets.NPDMHFNNDKO(UIWidget.PanelCompareFunc);
	}

	public void set_depth(int ICENKPDOHBK)
	{
		if (mDepth != ICENKPDOHBK)
		{
			mDepth = ICENKPDOHBK;
			list.NPDMHFNNDKO(CompareFunc);
		}
	}

	private void OOLPPEAMMFN()
	{
		Transform parent = get_cachedTransform().parent;
		NEOCFBFHJEC = ((!(parent != null)) ? null : NLDABIMKKMP.ANPDHFFNJFD<UIPanel>(parent.gameObject));
	}

	public UIPanel get_parentPanel()
	{
		return NEOCFBFHJEC;
	}

	public void SetDirty()
	{
		for (int i = 0; i < drawCalls.POIJPKODPCK; i++)
		{
			drawCalls.EDMNHDBEPMC[i].isDirty = true;
		}
		Invalidate(true);
	}

	public override void ParentHasChanged()
	{
		base.ParentHasChanged();
		OOLPPEAMMFN();
	}

	public Vector2 get_clipSoftness()
	{
		return mClipSoftness;
	}

	public void set_clipping(UIDrawCall.ACDCGJDEDLO ICENKPDOHBK)
	{
		if (mClipping != ICENKPDOHBK)
		{
			JEICIEEMFLF = true;
			mClipping = ICENKPDOHBK;
			NBJJJDOINOP = -1;
		}
	}

	public bool get_hasClipping()
	{
		return mClipping == UIDrawCall.ACDCGJDEDLO.SoftClip;
	}

	public override void Invalidate(bool JMCCPCFOHKC)
	{
		AHMAAPDCFLH = -1;
		base.Invalidate(JMCCPCFOHKC);
	}

	private void IBDGADDOINE()
	{
		for (int i = 1; i < drawCalls.POIJPKODPCK; i++)
		{
			UIDrawCall.GJCGICOEANG(drawCalls.EDMNHDBEPMC[i]);
		}
		drawCalls.PDCPMDCOLOD();
		Material material = null;
		Texture texture = null;
		Shader shader = null;
		UIDrawCall uIDrawCall = null;
		if (KLAMEGPACEA)
		{
			SortWidgets();
		}
		for (int j = 0; j < widgets.POIJPKODPCK; j++)
		{
			UIWidget uIWidget = widgets.EDMNHDBEPMC[j];
			if (uIWidget.get_isVisible() && uIWidget.get_hasVertices())
			{
				Material material2 = uIWidget.get_material();
				Texture mainTexture = uIWidget.get_mainTexture();
				Shader shader2 = uIWidget.get_shader();
				if (material != material2 || texture != mainTexture || shader != shader2)
				{
					if (uIDrawCall != null && uIDrawCall.verts.POIJPKODPCK != 0)
					{
						drawCalls.GBFCKODJEGE(uIDrawCall);
						uIDrawCall.PJONMLHCOJH();
						uIDrawCall = null;
					}
					material = material2;
					texture = mainTexture;
					shader = shader2;
				}
				if (!(material != null) && !(shader != null) && !(texture != null))
				{
					continue;
				}
				if (uIDrawCall == null)
				{
					uIDrawCall = UIDrawCall.Create(this, material, texture, shader);
					uIDrawCall.depthStart = uIWidget.get_depth();
					uIDrawCall.depthEnd = uIDrawCall.depthStart;
					uIDrawCall.panel = this;
				}
				else
				{
					int depth = uIWidget.get_depth();
					if (depth < uIDrawCall.depthStart)
					{
						uIDrawCall.depthStart = depth;
					}
					if (depth > uIDrawCall.depthEnd)
					{
						uIDrawCall.depthEnd = depth;
					}
				}
				uIWidget.drawCall = uIDrawCall;
				if (generateNormals)
				{
					uIWidget.WriteToBuffers(uIDrawCall.verts, uIDrawCall.uvs, uIDrawCall.cols, uIDrawCall.norms, uIDrawCall.tans);
				}
				else
				{
					uIWidget.WriteToBuffers(uIDrawCall.verts, uIDrawCall.uvs, uIDrawCall.cols, null, null);
				}
			}
			else
			{
				uIWidget.drawCall = null;
			}
		}
		if (uIDrawCall != null && uIDrawCall.verts.POIJPKODPCK != 0)
		{
			drawCalls.GBFCKODJEGE(uIDrawCall);
			uIDrawCall.KLLLFIJMHMG();
		}
	}
}
