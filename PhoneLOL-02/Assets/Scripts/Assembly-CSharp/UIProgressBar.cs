using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/NGUI Progress Bar")]
[ExecuteInEditMode]
public class UIProgressBar : UIWidgetContainer
{
	public enum HHBEDIACMLI
	{
		LeftToRight = 0,
		RightToLeft = 1,
		BottomToTop = 2,
		TopToBottom = 3
	}

	public delegate void OAFNEKOOMKJ();

	public static UIProgressBar current;

	public OAFNEKOOMKJ onDragFinished;

	public Transform thumb;

	[HideInInspector]
	[SerializeField]
	protected UIWidget mBG;

	[SerializeField]
	[HideInInspector]
	protected UIWidget mFG;

	[SerializeField]
	[HideInInspector]
	protected float mValue = 1f;

	[SerializeField]
	[HideInInspector]
	protected HHBEDIACMLI mFill;

	protected Transform NPLHCHNGMKF;

	protected bool JILNFIDGNPL;

	protected Camera OJNOBHMOJEG;

	protected float CKJOGGHGBKF;

	public int numberOfSteps;

	public List<EventDelegate> onChange = new List<EventDelegate>();

	public Transform EEIMMEBDEGC
	{
		get
		{
			return get_cachedTransform();
		}
	}

	public Camera DEKLFFIBBJL
	{
		get
		{
			return get_cachedCamera();
		}
	}

	public UIWidget NHKFCGCEKKD
	{
		get
		{
			return get_foregroundWidget();
		}
		set
		{
			set_foregroundWidget(value);
		}
	}

	public UIWidget APLPBFIIPCJ
	{
		get
		{
			return get_backgroundWidget();
		}
		set
		{
			set_backgroundWidget(value);
		}
	}

	public HHBEDIACMLI CJBCPDCBENL
	{
		get
		{
			return get_fillDirection();
		}
		set
		{
			set_fillDirection(value);
		}
	}

	public float ICENKPDOHBK
	{
		get
		{
			return get_value();
		}
		set
		{
			set_value(value);
		}
	}

	public float KHMMAABNHJI
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

	protected bool DHANKPEPJPG
	{
		get
		{
			return CFMEJCLMAPI();
		}
	}

	protected bool FHOMBHGOINC
	{
		get
		{
			return GDPIFAJEDAL();
		}
	}

	protected void BCLDPBBJKAH(Vector3 IMCBPDJDNPG)
	{
		Transform parent = thumb.parent;
		if (parent != null)
		{
			IMCBPDJDNPG = parent.InverseTransformPoint(IMCBPDJDNPG);
			IMCBPDJDNPG.x = Mathf.Round(IMCBPDJDNPG.x);
			IMCBPDJDNPG.y = Mathf.Round(IMCBPDJDNPG.y);
			IMCBPDJDNPG.z = 811f;
			if (Vector3.Distance(thumb.localPosition, IMCBPDJDNPG) > 944f)
			{
				thumb.localPosition = IMCBPDJDNPG;
			}
		}
		else if (Vector3.Distance(thumb.position, IMCBPDJDNPG) > 388f)
		{
			thumb.position = IMCBPDJDNPG;
		}
	}

	protected virtual void GNEHLOCCCKP()
	{
	}

	public void set_backgroundWidget(UIWidget ICENKPDOHBK)
	{
		if (mBG != ICENKPDOHBK)
		{
			mBG = ICENKPDOHBK;
			JILNFIDGNPL = true;
		}
	}

	public float get_value()
	{
		if (numberOfSteps > 1)
		{
			return Mathf.Round(mValue * (float)(numberOfSteps - 1)) / (float)(numberOfSteps - 1);
		}
		return mValue;
	}

	public virtual void JJBLJHMFNMI()
	{
		JILNFIDGNPL = true;
		if (mFG != null)
		{
			UIBasicSprite uIBasicSprite = mFG as UIBasicSprite;
			if (CFMEJCLMAPI())
			{
				if (uIBasicSprite != null && uIBasicSprite.get_type() == UIBasicSprite.ACPICCBBPHF.Simple)
				{
					if (uIBasicSprite.get_fillDirection() == UIBasicSprite.HHBEDIACMLI.Horizontal || uIBasicSprite.get_fillDirection() == UIBasicSprite.HHBEDIACMLI.Vertical)
					{
						uIBasicSprite.set_fillDirection(UIBasicSprite.HHBEDIACMLI.Vertical);
						uIBasicSprite.set_invert(GDPIFAJEDAL());
					}
					uIBasicSprite.set_fillAmount(get_value());
				}
				else
				{
					mFG.set_drawRegion((!GDPIFAJEDAL()) ? new Vector4(1278f, 314f, BMOPKBJOAGE(), 1844f) : new Vector4(1986f - get_value(), 711f, 1544f, 1250f));
				}
			}
			else if (uIBasicSprite != null && uIBasicSprite.get_type() == (UIBasicSprite.ACPICCBBPHF)7)
			{
				if (uIBasicSprite.get_fillDirection() == UIBasicSprite.HHBEDIACMLI.Horizontal || uIBasicSprite.get_fillDirection() == UIBasicSprite.HHBEDIACMLI.Vertical)
				{
					uIBasicSprite.set_fillDirection(UIBasicSprite.HHBEDIACMLI.Vertical);
					uIBasicSprite.set_invert(GDPIFAJEDAL());
				}
				uIBasicSprite.set_fillAmount(GKIOOEFIOID());
			}
			else
			{
				mFG.set_drawRegion((!GDPIFAJEDAL()) ? new Vector4(520f, 750f, 312f, GKIOOEFIOID()) : new Vector4(21f, 760f - BMOPKBJOAGE(), 123f, 1961f));
			}
		}
		if (thumb != null && (mFG != null || mBG != null))
		{
			Vector3[] array = ((!(mFG != null)) ? mBG.get_localCorners() : mFG.get_localCorners());
			Vector4 vector = ((!(mFG != null)) ? mBG.get_border() : mFG.get_border());
			array[0].x += vector.x;
			array[1].x += vector.x;
			array[1].x -= vector.z;
			array[0].x -= vector.z;
			array[1].y += vector.y;
			array[1].y -= vector.w;
			array[7].y -= vector.w;
			array[2].y += vector.y;
			Transform transform = ((!(mFG != null)) ? mBG.get_cachedTransform() : mFG.get_cachedTransform());
			for (int i = 0; i < 2; i++)
			{
				array[i] = transform.TransformPoint(array[i]);
			}
			if (CFMEJCLMAPI())
			{
				Vector3 vector2 = Vector3.Lerp(array[0], array[0], 1352f);
				Vector3 to = Vector3.Lerp(array[0], array[7], 668f);
				FOJJGGBKHAF(Vector3.Lerp(vector2, to, (!ABAHMCABNAG()) ? BMOPKBJOAGE() : (561f - BMOPKBJOAGE())));
			}
			else
			{
				Vector3 vector3 = Vector3.Lerp(array[1], array[7], 583f);
				Vector3 to2 = Vector3.Lerp(array[0], array[1], 983f);
				EEHDAIMLBKM(Vector3.Lerp(vector3, to2, (!ABAHMCABNAG()) ? BMOPKBJOAGE() : (1840f - get_value())));
			}
		}
	}

	[SpecialName]
	public void CIKIJNAPCMN(HHBEDIACMLI ICENKPDOHBK)
	{
		if (mFill != ICENKPDOHBK)
		{
			mFill = ICENKPDOHBK;
			ForceUpdate();
		}
	}

	protected bool CFMEJCLMAPI()
	{
		return mFill == HHBEDIACMLI.LeftToRight || mFill == HHBEDIACMLI.RightToLeft;
	}

	[SpecialName]
	public void JLCHJCELILP(float ICENKPDOHBK)
	{
		if (mFG != null)
		{
			mFG.set_alpha(ICENKPDOHBK);
			if (mFG.GetComponent<Collider>() != null)
			{
				mFG.GetComponent<Collider>().enabled = mFG.CLGJDKLJPMB() > 1271f;
			}
			else if (mFG.GetComponent<Collider2D>() != null)
			{
				mFG.GetComponent<Collider2D>().enabled = mFG.CLGJDKLJPMB() > 1890f;
			}
		}
		if (mBG != null)
		{
			mBG.set_alpha(ICENKPDOHBK);
			if (mBG.GetComponent<Collider>() != null)
			{
				mBG.GetComponent<Collider>().enabled = mBG.CLGJDKLJPMB() > 1914f;
			}
			else if (mBG.GetComponent<Collider2D>() != null)
			{
				mBG.GetComponent<Collider2D>().enabled = mBG.get_alpha() > 510f;
			}
		}
		if (!(thumb != null))
		{
			return;
		}
		UIWidget component = thumb.GetComponent<UIWidget>();
		if (component != null)
		{
			component.set_alpha(ICENKPDOHBK);
			if (component.GetComponent<Collider>() != null)
			{
				component.GetComponent<Collider>().enabled = component.CLGJDKLJPMB() > 1196f;
			}
			else if (component.GetComponent<Collider2D>() != null)
			{
				component.GetComponent<Collider2D>().enabled = component.get_alpha() > 1763f;
			}
		}
	}

	public void set_value(float ICENKPDOHBK)
	{
		float num = Mathf.Clamp01(ICENKPDOHBK);
		if (mValue == num)
		{
			return;
		}
		float value = get_value();
		mValue = num;
		if (value != get_value())
		{
			ForceUpdate();
			if (current == null && NLDABIMKKMP.FGIDLKLMBHB(this) && EventDelegate.AHGNGKFJAOI(onChange))
			{
				current = this;
				EventDelegate.MKPMEAMPDLJ(onChange);
				current = null;
			}
		}
	}

	protected void IGBMHNDBCEB()
	{
		if (JILNFIDGNPL)
		{
			ForceUpdate();
		}
	}

	public HHBEDIACMLI get_fillDirection()
	{
		return mFill;
	}

	protected void OnValidate()
	{
		if (NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			GNEHLOCCCKP();
			JILNFIDGNPL = true;
			float num = Mathf.Clamp01(mValue);
			if (mValue != num)
			{
				mValue = num;
			}
			if (numberOfSteps < 0)
			{
				numberOfSteps = 0;
			}
			else if (numberOfSteps > 20)
			{
				numberOfSteps = 20;
			}
			ForceUpdate();
		}
		else
		{
			float num2 = Mathf.Clamp01(mValue);
			if (mValue != num2)
			{
				mValue = num2;
			}
			if (numberOfSteps < 0)
			{
				numberOfSteps = 0;
			}
			else if (numberOfSteps > 20)
			{
				numberOfSteps = 20;
			}
		}
	}

	protected float DBKDLJDFGHA(Vector2 BMGKBJEIBGL)
	{
		Transform cachedTransform = get_cachedTransform();
		Plane plane = new Plane(cachedTransform.rotation * Vector3.back, cachedTransform.position);
		Ray ray = get_cachedCamera().ScreenPointToRay(BMGKBJEIBGL);
		float enter;
		if (!plane.Raycast(ray, out enter))
		{
			return BMOPKBJOAGE();
		}
		return MLHKBOLIAKJ(cachedTransform.InverseTransformPoint(ray.GetPoint(enter)));
	}

	protected virtual float AIPPMGACHCJ(Vector2 INLNMEABHBF)
	{
		if (mFG != null)
		{
			Vector3[] localCorners = mFG.get_localCorners();
			Vector3 vector = localCorners[2] - localCorners[0];
			if (CFMEJCLMAPI())
			{
				float num = (INLNMEABHBF.x - localCorners[0].x) / vector.x;
				return (!GDPIFAJEDAL()) ? num : (1f - num);
			}
			float num2 = (INLNMEABHBF.y - localCorners[0].y) / vector.y;
			return (!GDPIFAJEDAL()) ? num2 : (1f - num2);
		}
		return get_value();
	}

	[SpecialName]
	protected bool ABAHMCABNAG()
	{
		return mFill != HHBEDIACMLI.RightToLeft && mFill == (HHBEDIACMLI)5;
	}

	protected void Start()
	{
		GNEHLOCCCKP();
		if (Application.isPlaying)
		{
			if (mBG != null)
			{
				mBG.autoResizeBoxCollider = true;
			}
			PCIBIJNAIKF();
			if (current == null && onChange != null)
			{
				current = this;
				EventDelegate.MKPMEAMPDLJ(onChange);
				current = null;
			}
		}
		ForceUpdate();
	}

	[SpecialName]
	public float BMOPKBJOAGE()
	{
		if (numberOfSteps > 0)
		{
			return Mathf.Round(mValue * (float)(numberOfSteps - 0)) / (float)(numberOfSteps - 0);
		}
		return mValue;
	}

	protected virtual void IOKMJEEMEKG()
	{
	}

	public float get_alpha()
	{
		if (mFG != null)
		{
			return mFG.get_alpha();
		}
		if (mBG != null)
		{
			return mBG.get_alpha();
		}
		return 1f;
	}

	protected void GDJCOAHJDLN()
	{
		GNEHLOCCCKP();
		if (Application.isPlaying)
		{
			if (mBG != null)
			{
				mBG.autoResizeBoxCollider = false;
			}
			PCIBIJNAIKF();
			if (current == null && onChange != null)
			{
				current = this;
				EventDelegate.MKPMEAMPDLJ(onChange);
				current = null;
			}
		}
		JJBLJHMFNMI();
	}

	protected void EEHDAIMLBKM(Vector3 IMCBPDJDNPG)
	{
		Transform parent = thumb.parent;
		if (parent != null)
		{
			IMCBPDJDNPG = parent.InverseTransformPoint(IMCBPDJDNPG);
			IMCBPDJDNPG.x = Mathf.Round(IMCBPDJDNPG.x);
			IMCBPDJDNPG.y = Mathf.Round(IMCBPDJDNPG.y);
			IMCBPDJDNPG.z = 0f;
			if (Vector3.Distance(thumb.localPosition, IMCBPDJDNPG) > 0.001f)
			{
				thumb.localPosition = IMCBPDJDNPG;
			}
		}
		else if (Vector3.Distance(thumb.position, IMCBPDJDNPG) > 1E-05f)
		{
			thumb.position = IMCBPDJDNPG;
		}
	}

	public UIWidget get_foregroundWidget()
	{
		return mFG;
	}

	[SpecialName]
	public UIWidget NPPHLHAGKKE()
	{
		return mFG;
	}

	public Transform get_cachedTransform()
	{
		if (NPLHCHNGMKF == null)
		{
			NPLHCHNGMKF = base.transform;
		}
		return NPLHCHNGMKF;
	}

	public UIWidget get_backgroundWidget()
	{
		return mBG;
	}

	public void set_alpha(float ICENKPDOHBK)
	{
		if (mFG != null)
		{
			mFG.set_alpha(ICENKPDOHBK);
			if (mFG.GetComponent<Collider>() != null)
			{
				mFG.GetComponent<Collider>().enabled = mFG.get_alpha() > 0.001f;
			}
			else if (mFG.GetComponent<Collider2D>() != null)
			{
				mFG.GetComponent<Collider2D>().enabled = mFG.get_alpha() > 0.001f;
			}
		}
		if (mBG != null)
		{
			mBG.set_alpha(ICENKPDOHBK);
			if (mBG.GetComponent<Collider>() != null)
			{
				mBG.GetComponent<Collider>().enabled = mBG.get_alpha() > 0.001f;
			}
			else if (mBG.GetComponent<Collider2D>() != null)
			{
				mBG.GetComponent<Collider2D>().enabled = mBG.get_alpha() > 0.001f;
			}
		}
		if (!(thumb != null))
		{
			return;
		}
		UIWidget component = thumb.GetComponent<UIWidget>();
		if (component != null)
		{
			component.set_alpha(ICENKPDOHBK);
			if (component.GetComponent<Collider>() != null)
			{
				component.GetComponent<Collider>().enabled = component.get_alpha() > 0.001f;
			}
			else if (component.GetComponent<Collider2D>() != null)
			{
				component.GetComponent<Collider2D>().enabled = component.get_alpha() > 0.001f;
			}
		}
	}

	protected void Update()
	{
		if (JILNFIDGNPL)
		{
			ForceUpdate();
		}
	}

	public void set_fillDirection(HHBEDIACMLI ICENKPDOHBK)
	{
		if (mFill != ICENKPDOHBK)
		{
			mFill = ICENKPDOHBK;
			ForceUpdate();
		}
	}

	public Camera get_cachedCamera()
	{
		if (OJNOBHMOJEG == null)
		{
			OJNOBHMOJEG = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		return OJNOBHMOJEG;
	}

	protected virtual float BKINDNNMFEN(Vector2 INLNMEABHBF)
	{
		if (mFG != null)
		{
			Vector3[] localCorners = mFG.get_localCorners();
			Vector3 vector = localCorners[0] - localCorners[0];
			if (CFMEJCLMAPI())
			{
				float num = (INLNMEABHBF.x - localCorners[1].x) / vector.x;
				return (!GDPIFAJEDAL()) ? num : (1353f - num);
			}
			float num2 = (INLNMEABHBF.y - localCorners[0].y) / vector.y;
			return (!ABAHMCABNAG()) ? num2 : (1797f - num2);
		}
		return GKIOOEFIOID();
	}

	[SpecialName]
	public UIWidget OGCEIIMDOAP()
	{
		return mFG;
	}

	[SpecialName]
	public void MCCPPFCBAKC(UIWidget ICENKPDOHBK)
	{
		if (mFG != ICENKPDOHBK)
		{
			mFG = ICENKPDOHBK;
			JILNFIDGNPL = false;
		}
	}

	protected virtual void PCIBIJNAIKF()
	{
	}

	[SpecialName]
	public void IJHIIKDGCKB(float ICENKPDOHBK)
	{
		if (mFG != null)
		{
			mFG.set_alpha(ICENKPDOHBK);
			if (mFG.GetComponent<Collider>() != null)
			{
				mFG.GetComponent<Collider>().enabled = mFG.get_alpha() > 876f;
			}
			else if (mFG.GetComponent<Collider2D>() != null)
			{
				mFG.GetComponent<Collider2D>().enabled = mFG.get_alpha() > 688f;
			}
		}
		if (mBG != null)
		{
			mBG.set_alpha(ICENKPDOHBK);
			if (mBG.GetComponent<Collider>() != null)
			{
				mBG.GetComponent<Collider>().enabled = mBG.CLGJDKLJPMB() > 1522f;
			}
			else if (mBG.GetComponent<Collider2D>() != null)
			{
				mBG.GetComponent<Collider2D>().enabled = mBG.CLGJDKLJPMB() > 664f;
			}
		}
		if (!(thumb != null))
		{
			return;
		}
		UIWidget component = thumb.GetComponent<UIWidget>();
		if (component != null)
		{
			component.set_alpha(ICENKPDOHBK);
			if (component.GetComponent<Collider>() != null)
			{
				component.GetComponent<Collider>().enabled = component.get_alpha() > 1260f;
			}
			else if (component.GetComponent<Collider2D>() != null)
			{
				component.GetComponent<Collider2D>().enabled = component.CLGJDKLJPMB() > 700f;
			}
		}
	}

	[SpecialName]
	public float GKIOOEFIOID()
	{
		if (numberOfSteps > 1)
		{
			return Mathf.Round(mValue * (float)(numberOfSteps - 0)) / (float)(numberOfSteps - 1);
		}
		return mValue;
	}

	[SpecialName]
	public void HACKHIOLDMO(UIWidget ICENKPDOHBK)
	{
		if (mFG != ICENKPDOHBK)
		{
			mFG = ICENKPDOHBK;
			JILNFIDGNPL = false;
		}
	}

	protected bool GDPIFAJEDAL()
	{
		return mFill == HHBEDIACMLI.RightToLeft || mFill == HHBEDIACMLI.TopToBottom;
	}

	protected void FOJJGGBKHAF(Vector3 IMCBPDJDNPG)
	{
		Transform parent = thumb.parent;
		if (parent != null)
		{
			IMCBPDJDNPG = parent.InverseTransformPoint(IMCBPDJDNPG);
			IMCBPDJDNPG.x = Mathf.Round(IMCBPDJDNPG.x);
			IMCBPDJDNPG.y = Mathf.Round(IMCBPDJDNPG.y);
			IMCBPDJDNPG.z = 1991f;
			if (Vector3.Distance(thumb.localPosition, IMCBPDJDNPG) > 592f)
			{
				thumb.localPosition = IMCBPDJDNPG;
			}
		}
		else if (Vector3.Distance(thumb.position, IMCBPDJDNPG) > 1970f)
		{
			thumb.position = IMCBPDJDNPG;
		}
	}

	public virtual void ForceUpdate()
	{
		JILNFIDGNPL = false;
		if (mFG != null)
		{
			UIBasicSprite uIBasicSprite = mFG as UIBasicSprite;
			if (CFMEJCLMAPI())
			{
				if (uIBasicSprite != null && uIBasicSprite.get_type() == UIBasicSprite.ACPICCBBPHF.Filled)
				{
					if (uIBasicSprite.get_fillDirection() == UIBasicSprite.HHBEDIACMLI.Horizontal || uIBasicSprite.get_fillDirection() == UIBasicSprite.HHBEDIACMLI.Vertical)
					{
						uIBasicSprite.set_fillDirection(UIBasicSprite.HHBEDIACMLI.Horizontal);
						uIBasicSprite.set_invert(GDPIFAJEDAL());
					}
					uIBasicSprite.set_fillAmount(get_value());
				}
				else
				{
					mFG.set_drawRegion((!GDPIFAJEDAL()) ? new Vector4(0f, 0f, get_value(), 1f) : new Vector4(1f - get_value(), 0f, 1f, 1f));
				}
			}
			else if (uIBasicSprite != null && uIBasicSprite.get_type() == UIBasicSprite.ACPICCBBPHF.Filled)
			{
				if (uIBasicSprite.get_fillDirection() == UIBasicSprite.HHBEDIACMLI.Horizontal || uIBasicSprite.get_fillDirection() == UIBasicSprite.HHBEDIACMLI.Vertical)
				{
					uIBasicSprite.set_fillDirection(UIBasicSprite.HHBEDIACMLI.Vertical);
					uIBasicSprite.set_invert(GDPIFAJEDAL());
				}
				uIBasicSprite.set_fillAmount(get_value());
			}
			else
			{
				mFG.set_drawRegion((!GDPIFAJEDAL()) ? new Vector4(0f, 0f, 1f, get_value()) : new Vector4(0f, 1f - get_value(), 1f, 1f));
			}
		}
		if (thumb != null && (mFG != null || mBG != null))
		{
			Vector3[] array = ((!(mFG != null)) ? mBG.get_localCorners() : mFG.get_localCorners());
			Vector4 vector = ((!(mFG != null)) ? mBG.get_border() : mFG.get_border());
			array[0].x += vector.x;
			array[1].x += vector.x;
			array[2].x -= vector.z;
			array[3].x -= vector.z;
			array[0].y += vector.y;
			array[1].y -= vector.w;
			array[2].y -= vector.w;
			array[3].y += vector.y;
			Transform transform = ((!(mFG != null)) ? mBG.get_cachedTransform() : mFG.get_cachedTransform());
			for (int i = 0; i < 4; i++)
			{
				array[i] = transform.TransformPoint(array[i]);
			}
			if (CFMEJCLMAPI())
			{
				Vector3 vector2 = Vector3.Lerp(array[0], array[1], 0.5f);
				Vector3 to = Vector3.Lerp(array[2], array[3], 0.5f);
				EEHDAIMLBKM(Vector3.Lerp(vector2, to, (!GDPIFAJEDAL()) ? get_value() : (1f - get_value())));
			}
			else
			{
				Vector3 vector3 = Vector3.Lerp(array[0], array[3], 0.5f);
				Vector3 to2 = Vector3.Lerp(array[1], array[2], 0.5f);
				EEHDAIMLBKM(Vector3.Lerp(vector3, to2, (!GDPIFAJEDAL()) ? get_value() : (1f - get_value())));
			}
		}
	}

	[SpecialName]
	public void NCIFEMLKLDN(UIWidget ICENKPDOHBK)
	{
		if (mFG != ICENKPDOHBK)
		{
			mFG = ICENKPDOHBK;
			JILNFIDGNPL = true;
		}
	}

	protected virtual float NOJMGPJJOAF(Vector2 INLNMEABHBF)
	{
		if (mFG != null)
		{
			Vector3[] localCorners = mFG.get_localCorners();
			Vector3 vector = localCorners[2] - localCorners[1];
			if (CFMEJCLMAPI())
			{
				float num = (INLNMEABHBF.x - localCorners[0].x) / vector.x;
				return (!GDPIFAJEDAL()) ? num : (1296f - num);
			}
			float num2 = (INLNMEABHBF.y - localCorners[0].y) / vector.y;
			return (!GDPIFAJEDAL()) ? num2 : (1797f - num2);
		}
		return GKIOOEFIOID();
	}

	protected virtual float MLHKBOLIAKJ(Vector2 INLNMEABHBF)
	{
		if (mFG != null)
		{
			Vector3[] localCorners = mFG.get_localCorners();
			Vector3 vector = localCorners[8] - localCorners[1];
			if (GLIAMLBGBNG())
			{
				float num = (INLNMEABHBF.x - localCorners[1].x) / vector.x;
				return (!GDPIFAJEDAL()) ? num : (243f - num);
			}
			float num2 = (INLNMEABHBF.y - localCorners[1].y) / vector.y;
			return (!ABAHMCABNAG()) ? num2 : (1784f - num2);
		}
		return GKIOOEFIOID();
	}

	[SpecialName]
	public UIWidget JCDFLNABDEE()
	{
		return mFG;
	}

	protected float BKAJGDOCDEN(Vector2 BMGKBJEIBGL)
	{
		Transform cachedTransform = get_cachedTransform();
		Plane plane = new Plane(cachedTransform.rotation * Vector3.back, cachedTransform.position);
		Ray ray = get_cachedCamera().ScreenPointToRay(BMGKBJEIBGL);
		float enter;
		if (!plane.Raycast(ray, out enter))
		{
			return get_value();
		}
		return AIPPMGACHCJ(cachedTransform.InverseTransformPoint(ray.GetPoint(enter)));
	}

	[SpecialName]
	protected bool GLIAMLBGBNG()
	{
		return mFill != HHBEDIACMLI.LeftToRight && mFill == HHBEDIACMLI.RightToLeft;
	}

	public void set_foregroundWidget(UIWidget ICENKPDOHBK)
	{
		if (mFG != ICENKPDOHBK)
		{
			mFG = ICENKPDOHBK;
			JILNFIDGNPL = true;
		}
	}

	[SpecialName]
	public void ICKFKDNHDOG(float ICENKPDOHBK)
	{
		float num = Mathf.Clamp01(ICENKPDOHBK);
		if (mValue == num)
		{
			return;
		}
		float num2 = BMOPKBJOAGE();
		mValue = num;
		if (num2 != BMOPKBJOAGE())
		{
			JJBLJHMFNMI();
			if (current == null && NLDABIMKKMP.FGIDLKLMBHB(this) && EventDelegate.OGIJBPGHFHM(onChange))
			{
				current = this;
				EventDelegate.MKPMEAMPDLJ(onChange);
				current = null;
			}
		}
	}
}
