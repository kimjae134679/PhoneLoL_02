using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/UI/NGUI Widget")]
[ExecuteInEditMode]
public class UIWidget : UIRect
{
	public enum MADDMCMJKFI
	{
		TopLeft = 0,
		Top = 1,
		TopRight = 2,
		Left = 3,
		Center = 4,
		Right = 5,
		BottomLeft = 6,
		Bottom = 7,
		BottomRight = 8
	}

	public enum GELJGGLMEIB
	{
		Free = 0,
		BasedOnWidth = 1,
		BasedOnHeight = 2
	}

	public delegate void PJPHICLEDFN();

	public delegate bool FMNNBIMGJMF(Vector3 IMCBPDJDNPG);

	[HideInInspector]
	[SerializeField]
	protected Color mColor = Color.white;

	[HideInInspector]
	[SerializeField]
	protected MADDMCMJKFI mPivot = MADDMCMJKFI.Center;

	[SerializeField]
	[HideInInspector]
	protected int mWidth = 100;

	[HideInInspector]
	[SerializeField]
	protected int mHeight = 100;

	[HideInInspector]
	[SerializeField]
	protected int mDepth;

	public PJPHICLEDFN onChange;

	public bool autoResizeBoxCollider;

	public bool hideIfOffScreen;

	public GELJGGLMEIB keepAspectRatio;

	public float aspectRatio = 1f;

	public FMNNBIMGJMF hitCheck;

	[NonSerialized]
	public UIPanel panel;

	[NonSerialized]
	public OILILBKNHMB geometry = new OILILBKNHMB();

	[NonSerialized]
	public bool fillGeometry = true;

	[NonSerialized]
	protected bool FEMGPGAHDFB = true;

	[NonSerialized]
	protected Vector4 IGHALEOANNP = new Vector4(0f, 0f, 1f, 1f);

	[NonSerialized]
	private Matrix4x4 KBFDGGMEEFN;

	[NonSerialized]
	private bool BFNKIGBPKGD = true;

	[NonSerialized]
	private bool GKDEKHFNHEE = true;

	[NonSerialized]
	private bool KLEONCAKEIB = true;

	[NonSerialized]
	private float OOJFPGHMJJA;

	[NonSerialized]
	private bool HOGLHHCCKMJ;

	[NonSerialized]
	public UIDrawCall drawCall;

	[NonSerialized]
	protected Vector3[] CLMAJAOJAFB = new Vector3[4];

	[NonSerialized]
	private int AHMAAPDCFLH = -1;

	private int NBJJJDOINOP = -1;

	private Vector3 IKIEJNLJKAK;

	private Vector3 CLPJBKEKKLF;

	public Vector4 NFLOLOCLNGN
	{
		get
		{
			return get_drawRegion();
		}
		set
		{
			set_drawRegion(value);
		}
	}

	public Vector2 GKIFEKJCNJK
	{
		get
		{
			return get_pivotOffset();
		}
	}

	public int KODEGPNOHNB
	{
		get
		{
			return get_width();
		}
		set
		{
			set_width(value);
		}
	}

	public int JPGIEHMKOPA
	{
		get
		{
			return get_height();
		}
		set
		{
			set_height(value);
		}
	}

	public Color BEAKIPPBGAF
	{
		get
		{
			return get_color();
		}
		set
		{
			set_color(value);
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

	public bool FOMJEOOANFA
	{
		get
		{
			return get_isVisible();
		}
	}

	public bool GMLJCNHIJLA
	{
		get
		{
			return get_hasVertices();
		}
	}

	public MADDMCMJKFI JHGIAFICIOE
	{
		get
		{
			return get_rawPivot();
		}
		set
		{
			set_rawPivot(value);
		}
	}

	public MADDMCMJKFI NKHHGLDCFOE
	{
		get
		{
			return get_pivot();
		}
		set
		{
			set_pivot(value);
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

	public int FJGDHODPJNM
	{
		get
		{
			return get_raycastDepth();
		}
	}

	public override Vector3[] AJNDJHGBILC
	{
		get
		{
			return get_localCorners();
		}
	}

	public virtual Vector2 DOOJEHPBIGK
	{
		get
		{
			return get_localSize();
		}
	}

	public Vector3 ECIJKIDFGBM
	{
		get
		{
			return get_localCenter();
		}
	}

	public override Vector3[] CENAKAENDGH
	{
		get
		{
			return get_worldCorners();
		}
	}

	public Vector3 APKEHHEPHOA
	{
		get
		{
			return get_worldCenter();
		}
	}

	public virtual Vector4 KJGNCIJHNCN
	{
		get
		{
			return get_drawingDimensions();
		}
	}

	public virtual Material BJJILBPBOGP
	{
		get
		{
			return get_material();
		}
		set
		{
			set_material(value);
		}
	}

	public virtual Texture GCKGBLNJBGL
	{
		get
		{
			return get_mainTexture();
		}
		set
		{
			set_mainTexture(value);
		}
	}

	public virtual Shader DCIJHGKPFOI
	{
		get
		{
			return get_shader();
		}
		set
		{
			set_shader(value);
		}
	}

	[Obsolete("There is no relative scale anymore. Widgets now have width and height instead")]
	public Vector2 CEDPKLFPMEF
	{
		get
		{
			return get_relativeSize();
		}
	}

	public bool OAHMMPCAMPE
	{
		get
		{
			return get_hasBoxCollider();
		}
	}

	public virtual int AAHPICGBDMF
	{
		get
		{
			return get_minWidth();
		}
	}

	public virtual int MNMJMJPFNMA
	{
		get
		{
			return get_minHeight();
		}
	}

	public virtual Vector4 PCPJPDGKIMC
	{
		get
		{
			return get_border();
		}
		set
		{
			set_border(value);
		}
	}

	protected override void DPILNPAPPKI()
	{
		if (panel == null)
		{
			CreatePanel();
		}
	}

	public Color get_color()
	{
		return mColor;
	}

	protected void IIOHKCGNGGC(int HEFOBGOMLEE)
	{
		if (!BFNKIGBPKGD || !KLEONCAKEIB)
		{
			finalAlpha = 0f;
			return;
		}
		UIRect parent = get_parent();
		finalAlpha = ((!(get_parent() != null)) ? mColor.a : (parent.CalculateFinalAlpha(HEFOBGOMLEE) * mColor.a));
	}

	public Vector2 get_pivotOffset()
	{
		return HHAINCPODGE.OILFNOECKPI(get_pivot());
	}

	public UIPanel CreatePanel()
	{
		if (BAMIBNMGNBO && panel == null && base.enabled && NLDABIMKKMP.FGIDLKLMBHB(base.gameObject))
		{
			panel = UIPanel.Find(get_cachedTransform(), true, get_cachedGameObject().layer);
			if (panel != null)
			{
				CFCNOGOJNFC = false;
				panel.AddWidget(this);
				CheckLayer();
				Invalidate(true);
			}
		}
		return panel;
	}

	public override Vector3[] get_localCorners()
	{
		Vector2 pivotOffset = get_pivotOffset();
		float num = (0f - pivotOffset.x) * (float)mWidth;
		float num2 = (0f - pivotOffset.y) * (float)mHeight;
		float x = num + (float)mWidth;
		float y = num2 + (float)mHeight;
		CLMAJAOJAFB[0] = new Vector3(num, num2);
		CLMAJAOJAFB[1] = new Vector3(num, y);
		CLMAJAOJAFB[2] = new Vector3(x, y);
		CLMAJAOJAFB[3] = new Vector3(x, num2);
		return CLMAJAOJAFB;
	}

	public Bounds CalculateBounds()
	{
		return CalculateBounds(null);
	}

	private void OnDestroy()
	{
		KKCBEKLBFMN();
	}

	public void set_color(Color ICENKPDOHBK)
	{
		if (mColor != ICENKPDOHBK)
		{
			bool jMCCPCFOHKC = mColor.a != ICENKPDOHBK.a;
			mColor = ICENKPDOHBK;
			Invalidate(jMCCPCFOHKC);
		}
	}

	protected virtual void Awake()
	{
		NOHEHMDGHHB = base.gameObject;
		FEMGPGAHDFB = Application.isPlaying;
	}

	public float CalculateCumulativeAlpha(int HEFOBGOMLEE)
	{
		UIRect parent = get_parent();
		return (!(parent != null)) ? mColor.a : (parent.CalculateFinalAlpha(HEFOBGOMLEE) * mColor.a);
	}

	public bool get_hasVertices()
	{
		return geometry != null && geometry.NOGNPLFBAPG();
	}

	public virtual void set_shader(Shader ICENKPDOHBK)
	{
		throw new NotImplementedException(string.Concat(GetType(), " has no shader setter"));
	}

	public bool UpdateVisibility(bool KGJABOHJIJO, bool BOBIHEOCFKM)
	{
		if (BFNKIGBPKGD != KGJABOHJIJO || GKDEKHFNHEE != BOBIHEOCFKM)
		{
			DJAFKDJINKI = true;
			BFNKIGBPKGD = KGJABOHJIJO;
			GKDEKHFNHEE = BOBIHEOCFKM;
			return true;
		}
		return false;
	}

	public void set_pivot(MADDMCMJKFI ICENKPDOHBK)
	{
		if (mPivot != ICENKPDOHBK)
		{
			Vector3 vector = get_worldCorners()[0];
			mPivot = ICENKPDOHBK;
			DJAFKDJINKI = true;
			Vector3 vector2 = get_worldCorners()[0];
			Transform cachedTransform = get_cachedTransform();
			Vector3 position = cachedTransform.position;
			float z = cachedTransform.localPosition.z;
			position.x += vector.x - vector2.x;
			position.y += vector.y - vector2.y;
			get_cachedTransform().position = position;
			position = get_cachedTransform().localPosition;
			position.x = Mathf.Round(position.x);
			position.y = Mathf.Round(position.y);
			position.z = z;
			get_cachedTransform().localPosition = position;
		}
	}

	public override float CalculateFinalAlpha(int HEFOBGOMLEE)
	{
		if (AHMAAPDCFLH != HEFOBGOMLEE)
		{
			AHMAAPDCFLH = HEFOBGOMLEE;
			IIOHKCGNGGC(HEFOBGOMLEE);
		}
		return finalAlpha;
	}

	protected override void PCIBIJNAIKF()
	{
		CreatePanel();
	}

	public bool UpdateGeometry(int NJLOEFHBHMA)
	{
		float num = CalculateFinalAlpha(NJLOEFHBHMA);
		if (BFNKIGBPKGD && OOJFPGHMJJA != num)
		{
			DJAFKDJINKI = true;
		}
		OOJFPGHMJJA = num;
		if (DJAFKDJINKI)
		{
			DJAFKDJINKI = false;
			if (BFNKIGBPKGD && num > 0.001f && get_shader() != null)
			{
				bool result = geometry.NOGNPLFBAPG();
				if (fillGeometry)
				{
					geometry.PDCPMDCOLOD();
					OnFill(geometry.HILIICKOOFH, geometry.MDBIEMHCFFO, geometry.NAMIAMEOHAP);
				}
				if (geometry.NOGNPLFBAPG())
				{
					if (NBJJJDOINOP != NJLOEFHBHMA)
					{
						KBFDGGMEEFN = panel.worldToLocal * get_cachedTransform().localToWorldMatrix;
						NBJJJDOINOP = NJLOEFHBHMA;
					}
					geometry.NDBCCEOKBIK(KBFDGGMEEFN);
					HOGLHHCCKMJ = false;
					return true;
				}
				return result;
			}
			if (geometry.NOGNPLFBAPG())
			{
				if (fillGeometry)
				{
					geometry.PDCPMDCOLOD();
				}
				HOGLHHCCKMJ = false;
				return true;
			}
		}
		else if (HOGLHHCCKMJ && geometry.NOGNPLFBAPG())
		{
			if (NBJJJDOINOP != NJLOEFHBHMA)
			{
				KBFDGGMEEFN = panel.worldToLocal * get_cachedTransform().localToWorldMatrix;
				NBJJJDOINOP = NJLOEFHBHMA;
			}
			geometry.NDBCCEOKBIK(KBFDGGMEEFN);
			HOGLHHCCKMJ = false;
			return true;
		}
		HOGLHHCCKMJ = false;
		return false;
	}

	public int get_height()
	{
		return mHeight;
	}

	public Vector4 get_drawRegion()
	{
		return IGHALEOANNP;
	}

	public virtual void set_border(Vector4 ICENKPDOHBK)
	{
	}

	public Vector2 get_relativeSize()
	{
		return Vector2.one;
	}

	public void WriteToBuffers(global::MABNNPIGEPM<Vector3> FCGJBBHEOFJ, global::MABNNPIGEPM<Vector2> KMFDLFDOELD, global::MABNNPIGEPM<Color32> CEMGPCOMLOP, global::MABNNPIGEPM<Vector3> JNLKGIHJHCF, global::MABNNPIGEPM<Vector4> FFMBLAOKAKN)
	{
		geometry.LDOGPMOIMBG(FCGJBBHEOFJ, KMFDLFDOELD, CEMGPCOMLOP, JNLKGIHJHCF, FFMBLAOKAKN);
	}

	public Vector3 get_worldCenter()
	{
		return get_cachedTransform().TransformPoint(get_localCenter());
	}

	public bool UpdateTransform(int NJLOEFHBHMA)
	{
		if (!HOGLHHCCKMJ && !panel.widgetsAreStatic && get_cachedTransform().hasChanged)
		{
			NPLHCHNGMKF.hasChanged = false;
			KBFDGGMEEFN = panel.worldToLocal * get_cachedTransform().localToWorldMatrix;
			NBJJJDOINOP = NJLOEFHBHMA;
			Vector2 pivotOffset = get_pivotOffset();
			float num = (0f - pivotOffset.x) * (float)mWidth;
			float num2 = (0f - pivotOffset.y) * (float)mHeight;
			float x = num + (float)mWidth;
			float y = num2 + (float)mHeight;
			Transform cachedTransform = get_cachedTransform();
			Vector3 v = cachedTransform.TransformPoint(num, num2, 0f);
			Vector3 v2 = cachedTransform.TransformPoint(x, y, 0f);
			v = panel.worldToLocal.MultiplyPoint3x4(v);
			v2 = panel.worldToLocal.MultiplyPoint3x4(v2);
			if (Vector3.SqrMagnitude(IKIEJNLJKAK - v) > 1E-06f || Vector3.SqrMagnitude(CLPJBKEKKLF - v2) > 1E-06f)
			{
				HOGLHHCCKMJ = true;
				IKIEJNLJKAK = v;
				CLPJBKEKKLF = v2;
			}
		}
		if (HOGLHHCCKMJ && onChange != null)
		{
			onChange();
		}
		return HOGLHHCCKMJ || DJAFKDJINKI;
	}

	protected virtual void BPIKOOJHKLN()
	{
		Vector3 localScale = get_cachedTransform().localScale;
		mWidth = Mathf.Abs(Mathf.RoundToInt(localScale.x));
		mHeight = Mathf.Abs(Mathf.RoundToInt(localScale.y));
		NLDABIMKKMP.AFNBJACCKKC(base.gameObject, true);
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public static int PanelCompareFunc(UIWidget FPCKPMKLBDG, UIWidget FADFOBCCGNM)
	{
		if (FPCKPMKLBDG.mDepth < FADFOBCCGNM.mDepth)
		{
			return -1;
		}
		if (FPCKPMKLBDG.mDepth > FADFOBCCGNM.mDepth)
		{
			return 1;
		}
		Material material = FPCKPMKLBDG.get_material();
		Material material2 = FADFOBCCGNM.get_material();
		if (material == material2)
		{
			return 0;
		}
		if (material != null)
		{
			return -1;
		}
		if (material2 != null)
		{
			return 1;
		}
		return (material.GetInstanceID() >= material2.GetInstanceID()) ? 1 : (-1);
	}

	public virtual int get_minWidth()
	{
		return 2;
	}

	[SpecialName]
	public virtual Vector2 DKCJFGKEAON()
	{
		Vector3[] localCorners = get_localCorners();
		return localCorners[2] - localCorners[1];
	}

	[SpecialName]
	public virtual Vector2 OAECCCFHPPB()
	{
		Vector3[] localCorners = get_localCorners();
		return localCorners[0] - localCorners[0];
	}

	public virtual Vector4 get_border()
	{
		return Vector4.zero;
	}

	protected void KKCBEKLBFMN()
	{
		if (panel != null)
		{
			panel.RemoveWidget(this);
			panel = null;
		}
	}

	public int get_raycastDepth()
	{
		if (panel == null)
		{
			CreatePanel();
		}
		return (!(panel != null)) ? mDepth : (mDepth + panel.get_depth() * 1000);
	}

	protected virtual void MBDLDNAHAIM()
	{
		KKCBEKLBFMN();
		base.OnDisable();
	}

	public override void ParentHasChanged()
	{
		base.ParentHasChanged();
		if (panel != null)
		{
			UIPanel uIPanel = UIPanel.Find(get_cachedTransform(), true, get_cachedGameObject().layer);
			if (panel != uIPanel)
			{
				KKCBEKLBFMN();
				CreatePanel();
			}
		}
	}

	protected override void OHHOHFAGBBF()
	{
		base.OHHOHFAGBBF();
		KKCBEKLBFMN();
		HOGLHHCCKMJ = true;
		if (mWidth == 100 && mHeight == 100 && get_cachedTransform().localScale.magnitude > 8f)
		{
			BPIKOOJHKLN();
			get_cachedTransform().localScale = Vector3.one;
		}
	}

	[SpecialName]
	public virtual float CLGJDKLJPMB()
	{
		return mColor.a;
	}

	public bool get_hasBoxCollider()
	{
		BoxCollider boxCollider = base.GetComponent<Collider>() as BoxCollider;
		if (boxCollider != null)
		{
			return true;
		}
		return GetComponent<BoxCollider2D>() != null;
	}

	public virtual void OnFill(global::MABNNPIGEPM<Vector3> HILIICKOOFH, global::MABNNPIGEPM<Vector2> MDBIEMHCFFO, global::MABNNPIGEPM<Color32> NAMIAMEOHAP)
	{
	}

	public void CCKGPKCAHDB()
	{
		if (drawCall != null)
		{
			drawCall.isDirty = true;
		}
		else if (get_isVisible() && get_hasVertices())
		{
			CreatePanel();
		}
	}

	public void set_rawPivot(MADDMCMJKFI ICENKPDOHBK)
	{
		if (mPivot != ICENKPDOHBK)
		{
			mPivot = ICENKPDOHBK;
			if (autoResizeBoxCollider)
			{
				ResizeCollider();
			}
			MarkAsChanged();
		}
	}

	public void CheckLayer()
	{
		if (panel != null && panel.gameObject.layer != base.gameObject.layer)
		{
			UnityEngine.Debug.LogWarning("You can't place widgets on a layer different than the UIPanel that manages them.\nIf you want to move widgets to a different layer, parent them to a new panel instead.", this);
			base.gameObject.layer = panel.gameObject.layer;
		}
	}

	public MADDMCMJKFI get_pivot()
	{
		return mPivot;
	}

	public virtual Vector4 get_drawingDimensions()
	{
		Vector2 pivotOffset = get_pivotOffset();
		float num = (0f - pivotOffset.x) * (float)mWidth;
		float num2 = (0f - pivotOffset.y) * (float)mHeight;
		float num3 = num + (float)mWidth;
		float num4 = num2 + (float)mHeight;
		return new Vector4((IGHALEOANNP.x != 0f) ? Mathf.Lerp(num, num3, IGHALEOANNP.x) : num, (IGHALEOANNP.y != 0f) ? Mathf.Lerp(num2, num4, IGHALEOANNP.y) : num2, (IGHALEOANNP.z != 1f) ? Mathf.Lerp(num, num3, IGHALEOANNP.z) : num3, (IGHALEOANNP.w != 1f) ? Mathf.Lerp(num2, num4, IGHALEOANNP.w) : num4);
	}

	protected virtual void JJILIJAFPGJ()
	{
		if (panel == null)
		{
			CreatePanel();
		}
	}

	protected virtual void OJIPABHONHD()
	{
		CreatePanel();
	}

	public override Vector3[] get_worldCorners()
	{
		Vector2 pivotOffset = get_pivotOffset();
		float num = (0f - pivotOffset.x) * (float)mWidth;
		float num2 = (0f - pivotOffset.y) * (float)mHeight;
		float x = num + (float)mWidth;
		float y = num2 + (float)mHeight;
		Transform cachedTransform = get_cachedTransform();
		CLMAJAOJAFB[0] = cachedTransform.TransformPoint(num, num2, 0f);
		CLMAJAOJAFB[1] = cachedTransform.TransformPoint(num, y, 0f);
		CLMAJAOJAFB[2] = cachedTransform.TransformPoint(x, y, 0f);
		CLMAJAOJAFB[3] = cachedTransform.TransformPoint(x, num2, 0f);
		return CLMAJAOJAFB;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static int FullCompareFunc(UIWidget FPCKPMKLBDG, UIWidget FADFOBCCGNM)
	{
		int num = UIPanel.CompareFunc(FPCKPMKLBDG.panel, FADFOBCCGNM.panel);
		return (num != 0) ? num : PanelCompareFunc(FPCKPMKLBDG, FADFOBCCGNM);
	}

	public virtual int get_minHeight()
	{
		return 2;
	}

	public virtual Vector2 get_localSize()
	{
		Vector3[] localCorners = get_localCorners();
		return localCorners[2] - localCorners[0];
	}

	public int get_width()
	{
		return mWidth;
	}

	public override void SetRect(float MPBOINGECFO, float OECPEJEIMHO, float KODEGPNOHNB, float JPGIEHMKOPA)
	{
		Vector2 pivotOffset = get_pivotOffset();
		float num = Mathf.Lerp(MPBOINGECFO, MPBOINGECFO + KODEGPNOHNB, pivotOffset.x);
		float num2 = Mathf.Lerp(OECPEJEIMHO, OECPEJEIMHO + JPGIEHMKOPA, pivotOffset.y);
		int num3 = Mathf.FloorToInt(KODEGPNOHNB + 0.5f);
		int num4 = Mathf.FloorToInt(JPGIEHMKOPA + 0.5f);
		if (pivotOffset.x == 0.5f)
		{
			num3 = num3 >> 1 << 1;
		}
		if (pivotOffset.y == 0.5f)
		{
			num4 = num4 >> 1 << 1;
		}
		Transform cachedTransform = get_cachedTransform();
		Vector3 localPosition = cachedTransform.localPosition;
		localPosition.x = Mathf.Floor(num + 0.5f);
		localPosition.y = Mathf.Floor(num2 + 0.5f);
		if (num3 < get_minWidth())
		{
			num3 = get_minWidth();
		}
		if (num4 < get_minHeight())
		{
			num4 = get_minHeight();
		}
		cachedTransform.localPosition = localPosition;
		set_width(num3);
		set_height(num4);
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

	protected override void OnDisable()
	{
		KKCBEKLBFMN();
		base.OnDisable();
	}

	public virtual void MarkAsChanged()
	{
		if (NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			DJAFKDJINKI = true;
			if (panel != null && base.enabled && NLDABIMKKMP.FGIDLKLMBHB(base.gameObject) && !FEMGPGAHDFB)
			{
				SetDirty();
				CheckLayer();
			}
		}
	}

	[SpecialName]
	public virtual Texture KMMDJIEACEL()
	{
		Material material = get_material();
		return (!(material != null)) ? null : material.mainTexture;
	}

	public virtual void set_mainTexture(Texture ICENKPDOHBK)
	{
		throw new NotImplementedException(string.Concat(GetType(), " has no mainTexture setter"));
	}

	public MADDMCMJKFI get_rawPivot()
	{
		return mPivot;
	}

	public override float get_alpha()
	{
		return mColor.a;
	}

	[SpecialName]
	public void EBFDCABBLFG(int ICENKPDOHBK)
	{
		if (mDepth == ICENKPDOHBK)
		{
			return;
		}
		if (panel != null)
		{
			panel.RemoveWidget(this);
		}
		mDepth = ICENKPDOHBK;
		if (panel != null)
		{
			panel.AddWidget(this);
			if (!Application.isPlaying)
			{
				panel.SortWidgets();
				panel.RebuildAllDrawCalls();
			}
		}
	}

	public override Vector3[] GetSides(Transform DNIFGOKCBEL)
	{
		Vector2 pivotOffset = get_pivotOffset();
		float num = (0f - pivotOffset.x) * (float)mWidth;
		float num2 = (0f - pivotOffset.y) * (float)mHeight;
		float num3 = num + (float)mWidth;
		float num4 = num2 + (float)mHeight;
		float x = (num + num3) * 0.5f;
		float y = (num2 + num4) * 0.5f;
		Transform cachedTransform = get_cachedTransform();
		CLMAJAOJAFB[0] = cachedTransform.TransformPoint(num, y, 0f);
		CLMAJAOJAFB[1] = cachedTransform.TransformPoint(x, num4, 0f);
		CLMAJAOJAFB[2] = cachedTransform.TransformPoint(num3, y, 0f);
		CLMAJAOJAFB[3] = cachedTransform.TransformPoint(x, num2, 0f);
		if (DNIFGOKCBEL != null)
		{
			for (int i = 0; i < 4; i++)
			{
				CLMAJAOJAFB[i] = DNIFGOKCBEL.InverseTransformPoint(CLMAJAOJAFB[i]);
			}
		}
		return CLMAJAOJAFB;
	}

	public Bounds CalculateBounds(Transform FAHBOGCNLFB)
	{
		if (FAHBOGCNLFB == null)
		{
			Vector3[] localCorners = get_localCorners();
			Bounds result = new Bounds(localCorners[0], Vector3.zero);
			for (int i = 1; i < 4; i++)
			{
				result.Encapsulate(localCorners[i]);
			}
			return result;
		}
		Matrix4x4 worldToLocalMatrix = FAHBOGCNLFB.worldToLocalMatrix;
		Vector3[] worldCorners = get_worldCorners();
		Bounds result2 = new Bounds(worldToLocalMatrix.MultiplyPoint3x4(worldCorners[0]), Vector3.zero);
		for (int j = 1; j < 4; j++)
		{
			result2.Encapsulate(worldToLocalMatrix.MultiplyPoint3x4(worldCorners[j]));
		}
		return result2;
	}

	public virtual Shader get_shader()
	{
		Material material = get_material();
		return (!(material != null)) ? null : material.shader;
	}

	public float NCOEHLMCAFJ(int HEFOBGOMLEE)
	{
		UIRect parent = get_parent();
		return (!(parent != null)) ? mColor.a : (parent.CalculateFinalAlpha(HEFOBGOMLEE) * mColor.a);
	}

	public void set_width(int ICENKPDOHBK)
	{
		int minWidth = get_minWidth();
		if (ICENKPDOHBK < minWidth)
		{
			ICENKPDOHBK = minWidth;
		}
		if (mWidth == ICENKPDOHBK || keepAspectRatio == GELJGGLMEIB.BasedOnHeight)
		{
			return;
		}
		if (get_isAnchoredHorizontally())
		{
			if (leftAnchor.target != null && rightAnchor.target != null)
			{
				if (mPivot == MADDMCMJKFI.BottomLeft || mPivot == MADDMCMJKFI.Left || mPivot == MADDMCMJKFI.TopLeft)
				{
					HHAINCPODGE.JOHHMNNEHPJ(this, 0f, 0f, ICENKPDOHBK - mWidth, 0f);
					return;
				}
				if (mPivot == MADDMCMJKFI.BottomRight || mPivot == MADDMCMJKFI.Right || mPivot == MADDMCMJKFI.TopRight)
				{
					HHAINCPODGE.JOHHMNNEHPJ(this, mWidth - ICENKPDOHBK, 0f, 0f, 0f);
					return;
				}
				int num = ICENKPDOHBK - mWidth;
				num -= num & 1;
				if (num != 0)
				{
					HHAINCPODGE.JOHHMNNEHPJ(this, (float)(-num) * 0.5f, 0f, (float)num * 0.5f, 0f);
				}
			}
			else if (leftAnchor.target != null)
			{
				HHAINCPODGE.JOHHMNNEHPJ(this, 0f, 0f, ICENKPDOHBK - mWidth, 0f);
			}
			else
			{
				HHAINCPODGE.JOHHMNNEHPJ(this, mWidth - ICENKPDOHBK, 0f, 0f, 0f);
			}
		}
		else
		{
			SetDimensions(ICENKPDOHBK, mHeight);
		}
	}

	public virtual Material get_material()
	{
		return null;
	}

	protected override void ADEEMHKMJBF()
	{
		Transform cachedTransform = get_cachedTransform();
		Transform parent = cachedTransform.parent;
		Vector3 localPosition = cachedTransform.localPosition;
		Vector2 pivotOffset = get_pivotOffset();
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
				KLEONCAKEIB = true;
			}
			else
			{
				Vector3 vector = CLKPPFFFGGB(leftAnchor, parent);
				num = vector.x + (float)leftAnchor.absolute;
				num3 = vector.y + (float)bottomAnchor.absolute;
				num2 = vector.x + (float)rightAnchor.absolute;
				num4 = vector.y + (float)topAnchor.absolute;
				KLEONCAKEIB = !hideIfOffScreen || vector.z >= 0f;
			}
		}
		else
		{
			KLEONCAKEIB = true;
			if ((bool)leftAnchor.target)
			{
				Vector3[] array2 = leftAnchor.EKECFKMAGNH(parent);
				num = ((array2 == null) ? (CLKPPFFFGGB(leftAnchor, parent).x + (float)leftAnchor.absolute) : (HHAINCPODGE.KCLHKIALKPN(array2[0].x, array2[2].x, leftAnchor.relative) + (float)leftAnchor.absolute));
			}
			else
			{
				num = localPosition.x - pivotOffset.x * (float)mWidth;
			}
			if ((bool)rightAnchor.target)
			{
				Vector3[] array3 = rightAnchor.EKECFKMAGNH(parent);
				num2 = ((array3 == null) ? (CLKPPFFFGGB(rightAnchor, parent).x + (float)rightAnchor.absolute) : (HHAINCPODGE.KCLHKIALKPN(array3[0].x, array3[2].x, rightAnchor.relative) + (float)rightAnchor.absolute));
			}
			else
			{
				num2 = localPosition.x - pivotOffset.x * (float)mWidth + (float)mWidth;
			}
			if ((bool)bottomAnchor.target)
			{
				Vector3[] array4 = bottomAnchor.EKECFKMAGNH(parent);
				num3 = ((array4 == null) ? (CLKPPFFFGGB(bottomAnchor, parent).y + (float)bottomAnchor.absolute) : (HHAINCPODGE.KCLHKIALKPN(array4[3].y, array4[1].y, bottomAnchor.relative) + (float)bottomAnchor.absolute));
			}
			else
			{
				num3 = localPosition.y - pivotOffset.y * (float)mHeight;
			}
			if ((bool)topAnchor.target)
			{
				Vector3[] array5 = topAnchor.EKECFKMAGNH(parent);
				num4 = ((array5 == null) ? (CLKPPFFFGGB(topAnchor, parent).y + (float)topAnchor.absolute) : (HHAINCPODGE.KCLHKIALKPN(array5[3].y, array5[1].y, topAnchor.relative) + (float)topAnchor.absolute));
			}
			else
			{
				num4 = localPosition.y - pivotOffset.y * (float)mHeight + (float)mHeight;
			}
		}
		Vector3 vector2 = new Vector3(Mathf.Lerp(num, num2, pivotOffset.x), Mathf.Lerp(num3, num4, pivotOffset.y), localPosition.z);
		int num5 = Mathf.FloorToInt(num2 - num + 0.5f);
		int num6 = Mathf.FloorToInt(num4 - num3 + 0.5f);
		if (keepAspectRatio != GELJGGLMEIB.Free && aspectRatio != 0f)
		{
			if (keepAspectRatio == GELJGGLMEIB.BasedOnHeight)
			{
				num5 = Mathf.RoundToInt((float)num6 * aspectRatio);
			}
			else
			{
				num6 = Mathf.RoundToInt((float)num5 / aspectRatio);
			}
		}
		if (num5 < get_minWidth())
		{
			num5 = get_minWidth();
		}
		if (num6 < get_minHeight())
		{
			num6 = get_minHeight();
		}
		if (Vector3.SqrMagnitude(localPosition - vector2) > 0.001f)
		{
			get_cachedTransform().localPosition = vector2;
			if (KLEONCAKEIB)
			{
				DJAFKDJINKI = true;
			}
		}
		if (mWidth != num5 || mHeight != num6)
		{
			mWidth = num5;
			mHeight = num6;
			if (KLEONCAKEIB)
			{
				DJAFKDJINKI = true;
			}
			if (autoResizeBoxCollider)
			{
				ResizeCollider();
			}
		}
	}

	[SpecialName]
	public void EPCLGPBEJPL(MADDMCMJKFI ICENKPDOHBK)
	{
		if (mPivot != ICENKPDOHBK)
		{
			Vector3 vector = get_worldCorners()[0];
			mPivot = ICENKPDOHBK;
			DJAFKDJINKI = false;
			Vector3 vector2 = get_worldCorners()[0];
			Transform cachedTransform = get_cachedTransform();
			Vector3 position = cachedTransform.position;
			float z = cachedTransform.localPosition.z;
			position.x += vector.x - vector2.x;
			position.y += vector.y - vector2.y;
			get_cachedTransform().position = position;
			position = get_cachedTransform().localPosition;
			position.x = Mathf.Round(position.x);
			position.y = Mathf.Round(position.y);
			position.z = z;
			get_cachedTransform().localPosition = position;
		}
	}

	public void set_drawRegion(Vector4 ICENKPDOHBK)
	{
		if (IGHALEOANNP != ICENKPDOHBK)
		{
			IGHALEOANNP = ICENKPDOHBK;
			if (autoResizeBoxCollider)
			{
				ResizeCollider();
			}
			MarkAsChanged();
		}
	}

	private void OnApplicationPause(bool BFAJFNNAODA)
	{
		if (!BFAJFNNAODA)
		{
			MarkAsChanged();
		}
	}

	public void set_depth(int ICENKPDOHBK)
	{
		if (mDepth == ICENKPDOHBK)
		{
			return;
		}
		if (panel != null)
		{
			panel.RemoveWidget(this);
		}
		mDepth = ICENKPDOHBK;
		if (panel != null)
		{
			panel.AddWidget(this);
			if (!Application.isPlaying)
			{
				panel.SortWidgets();
				panel.RebuildAllDrawCalls();
			}
		}
	}

	public override void set_alpha(float ICENKPDOHBK)
	{
		if (mColor.a != ICENKPDOHBK)
		{
			mColor.a = ICENKPDOHBK;
			Invalidate(true);
		}
	}

	public void set_height(int ICENKPDOHBK)
	{
		int minHeight = get_minHeight();
		if (ICENKPDOHBK < minHeight)
		{
			ICENKPDOHBK = minHeight;
		}
		if (mHeight == ICENKPDOHBK || keepAspectRatio == GELJGGLMEIB.BasedOnWidth)
		{
			return;
		}
		if (get_isAnchoredVertically())
		{
			if (bottomAnchor.target != null && topAnchor.target != null)
			{
				if (mPivot == MADDMCMJKFI.BottomLeft || mPivot == MADDMCMJKFI.Bottom || mPivot == MADDMCMJKFI.BottomRight)
				{
					HHAINCPODGE.JOHHMNNEHPJ(this, 0f, 0f, 0f, ICENKPDOHBK - mHeight);
					return;
				}
				if (mPivot == MADDMCMJKFI.TopLeft || mPivot == MADDMCMJKFI.Top || mPivot == MADDMCMJKFI.TopRight)
				{
					HHAINCPODGE.JOHHMNNEHPJ(this, 0f, mHeight - ICENKPDOHBK, 0f, 0f);
					return;
				}
				int num = ICENKPDOHBK - mHeight;
				num -= num & 1;
				if (num != 0)
				{
					HHAINCPODGE.JOHHMNNEHPJ(this, 0f, (float)(-num) * 0.5f, 0f, (float)num * 0.5f);
				}
			}
			else if (bottomAnchor.target != null)
			{
				HHAINCPODGE.JOHHMNNEHPJ(this, 0f, 0f, 0f, ICENKPDOHBK - mHeight);
			}
			else
			{
				HHAINCPODGE.JOHHMNNEHPJ(this, 0f, mHeight - ICENKPDOHBK, 0f, 0f);
			}
		}
		else
		{
			SetDimensions(mWidth, ICENKPDOHBK);
		}
	}

	public virtual void MakePixelPerfect()
	{
		Vector3 localPosition = get_cachedTransform().localPosition;
		localPosition.z = Mathf.Round(localPosition.z);
		localPosition.x = Mathf.Round(localPosition.x);
		localPosition.y = Mathf.Round(localPosition.y);
		get_cachedTransform().localPosition = localPosition;
		Vector3 localScale = get_cachedTransform().localScale;
		get_cachedTransform().localScale = new Vector3(Mathf.Sign(localScale.x), Mathf.Sign(localScale.y), 1f);
	}

	public void ResizeCollider()
	{
		if (NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			NLDABIMKKMP.AFNBJACCKKC(base.gameObject);
		}
	}

	[SpecialName]
	public virtual Vector3[] LJODMMODACC()
	{
		Vector2 pivotOffset = get_pivotOffset();
		float num = (0f - pivotOffset.x) * (float)mWidth;
		float num2 = (0f - pivotOffset.y) * (float)mHeight;
		float x = num + (float)mWidth;
		float y = num2 + (float)mHeight;
		Transform cachedTransform = get_cachedTransform();
		CLMAJAOJAFB[1] = cachedTransform.TransformPoint(num, num2, 540f);
		CLMAJAOJAFB[0] = cachedTransform.TransformPoint(num, y, 1774f);
		CLMAJAOJAFB[4] = cachedTransform.TransformPoint(x, y, 1918f);
		CLMAJAOJAFB[4] = cachedTransform.TransformPoint(x, num2, 581f);
		return CLMAJAOJAFB;
	}

	public int get_depth()
	{
		return mDepth;
	}

	public void SetDimensions(int ADFJMGLHGHC, int JDMNMKGGLIH)
	{
		if (mWidth != ADFJMGLHGHC || mHeight != JDMNMKGGLIH)
		{
			mWidth = ADFJMGLHGHC;
			mHeight = JDMNMKGGLIH;
			if (keepAspectRatio == GELJGGLMEIB.BasedOnWidth)
			{
				mHeight = Mathf.RoundToInt((float)mWidth / aspectRatio);
			}
			else if (keepAspectRatio == GELJGGLMEIB.BasedOnHeight)
			{
				mWidth = Mathf.RoundToInt((float)mHeight * aspectRatio);
			}
			else if (keepAspectRatio == GELJGGLMEIB.Free)
			{
				aspectRatio = (float)mWidth / (float)mHeight;
			}
			HOGLHHCCKMJ = true;
			if (autoResizeBoxCollider)
			{
				ResizeCollider();
			}
			MarkAsChanged();
		}
	}

	public bool get_isVisible()
	{
		return GKDEKHFNHEE && BFNKIGBPKGD && KLEONCAKEIB && finalAlpha > 0.001f && NLDABIMKKMP.FGIDLKLMBHB(this);
	}

	public virtual void set_material(Material ICENKPDOHBK)
	{
		throw new NotImplementedException(string.Concat(GetType(), " has no material setter"));
	}

	public Vector3 get_localCenter()
	{
		Vector3[] localCorners = get_localCorners();
		return Vector3.Lerp(localCorners[0], localCorners[2], 0.5f);
	}

	public override void Invalidate(bool JMCCPCFOHKC)
	{
		DJAFKDJINKI = true;
		AHMAAPDCFLH = -1;
		if (panel != null)
		{
			bool bOBIHEOCFKM = (!hideIfOffScreen && !panel.get_hasCumulativeClipping()) || panel.IsVisible(this);
			UpdateVisibility(CalculateCumulativeAlpha(Time.frameCount) > 0.001f, bOBIHEOCFKM);
			IIOHKCGNGGC(Time.frameCount);
			if (JMCCPCFOHKC)
			{
				base.Invalidate(true);
			}
		}
	}

	public virtual Texture get_mainTexture()
	{
		Material material = get_material();
		return (!(material != null)) ? null : material.mainTexture;
	}

	public void SetDirty()
	{
		if (drawCall != null)
		{
			drawCall.isDirty = true;
		}
		else if (get_isVisible() && get_hasVertices())
		{
			CreatePanel();
		}
	}
}
