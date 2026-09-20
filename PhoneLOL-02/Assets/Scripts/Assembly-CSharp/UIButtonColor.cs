using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Button Color")]
[ExecuteInEditMode]
public class UIButtonColor : UIWidgetContainer
{
	public enum OEOIIKMBGAG
	{
		Normal = 0,
		Hover = 1,
		Pressed = 2,
		Disabled = 3
	}

	public GameObject tweenTarget;

	public Color hover = new Color(225f / 255f, 200f / 255f, 150f / 255f, 1f);

	public Color pressed = new Color(183f / 255f, 163f / 255f, 123f / 255f, 1f);

	public Color disabledColor = Color.grey;

	public float duration = 0.2f;

	[NonSerialized]
	protected Color ICMIBPBBOJJ;

	[NonSerialized]
	protected Color BAOFOHKGELG;

	[NonSerialized]
	protected bool MCLOOFPOPDL;

	[NonSerialized]
	protected UIWidget MCIOOPNKLDF;

	[NonSerialized]
	protected OEOIIKMBGAG BKCIEADLBLD;

	public OEOIIKMBGAG EBILEBOJADB
	{
		get
		{
			return get_state();
		}
		set
		{
			set_state(value);
		}
	}

	public Color KOLHHDBHOJP
	{
		get
		{
			return get_defaultColor();
		}
		set
		{
			set_defaultColor(value);
		}
	}

	public virtual bool BEIOIHEIKOE
	{
		get
		{
			return get_isEnabled();
		}
		set
		{
			set_isEnabled(value);
		}
	}

	protected virtual void AHCJKIBBNOP()
	{
		if (get_isEnabled())
		{
			if (!MCLOOFPOPDL)
			{
				OHHOHFAGBBF();
			}
			if (tweenTarget != null)
			{
				SetState(OEOIIKMBGAG.Disabled, false);
			}
		}
	}

	protected virtual void CFEIPPFANKJ()
	{
		if (MCLOOFPOPDL)
		{
			DGHCKMGOOGK(UICamera.IsHighlighted(base.gameObject));
		}
		if (UICamera.currentTouch != null)
		{
			if (UICamera.currentTouch.NLGJIEONPNP == base.gameObject)
			{
				NDNBPKKAKDJ(true);
			}
			else if (UICamera.currentTouch.PPKODABGJDM == base.gameObject)
			{
				DGHCKMGOOGK(true);
			}
		}
	}

	private void PAJOOFIAPMI()
	{
		if (!get_isEnabled())
		{
			SetState(OEOIIKMBGAG.Normal, true);
		}
	}

	public void UpdateColor(bool MABBBDMDFHE)
	{
		TweenColor tweenColor;
		switch (BKCIEADLBLD)
		{
		case OEOIIKMBGAG.Hover:
			tweenColor = TweenColor.Begin(tweenTarget, duration, hover);
			break;
		case OEOIIKMBGAG.Pressed:
			tweenColor = TweenColor.Begin(tweenTarget, duration, pressed);
			break;
		case OEOIIKMBGAG.Disabled:
			tweenColor = TweenColor.Begin(tweenTarget, duration, disabledColor);
			break;
		default:
			tweenColor = TweenColor.Begin(tweenTarget, duration, BAOFOHKGELG);
			break;
		}
		if (MABBBDMDFHE && tweenColor != null)
		{
			tweenColor.set_value(tweenColor.to);
			tweenColor.enabled = false;
		}
	}

	public void MBMDHMJCAMH()
	{
		NBKHAELMBKJ(ICMIBPBBOJJ);
	}

	public virtual void AKNFNLNGEBE(OEOIIKMBGAG EBILEBOJADB, bool MABBBDMDFHE)
	{
		if (!MCLOOFPOPDL)
		{
			MCLOOFPOPDL = false;
			OHHOHFAGBBF();
		}
		if (BKCIEADLBLD != EBILEBOJADB)
		{
			BKCIEADLBLD = EBILEBOJADB;
			UpdateColor(MABBBDMDFHE);
		}
	}

	public void ResetDefaultColor()
	{
		set_defaultColor(ICMIBPBBOJJ);
	}

	private void Awake()
	{
		if (!MCLOOFPOPDL)
		{
			OHHOHFAGBBF();
		}
	}

	protected virtual void NJAPIAABFOI(bool IOGFFPOIBBB)
	{
		if (get_isEnabled() && (!IOGFFPOIBBB || UICamera.currentScheme == (UICamera.DOCFHOGBBJH)6) && tweenTarget != null)
		{
			DGHCKMGOOGK(IOGFFPOIBBB);
		}
	}

	protected virtual void LDDLDNKGBBC()
	{
		if (MCLOOFPOPDL && tweenTarget != null)
		{
			GFOLACFLJJJ(OEOIIKMBGAG.Hover, false);
			TweenColor component = tweenTarget.GetComponent<TweenColor>();
			if (component != null)
			{
				component.set_value(BAOFOHKGELG);
				component.enabled = false;
			}
		}
	}

	protected virtual void NDNBPKKAKDJ(bool JPNFGIEDOMM)
	{
		if (!get_isEnabled() || UICamera.currentTouch == null)
		{
			return;
		}
		if (!MCLOOFPOPDL)
		{
			OHHOHFAGBBF();
		}
		if (!(tweenTarget != null))
		{
			return;
		}
		if (JPNFGIEDOMM)
		{
			SetState(OEOIIKMBGAG.Pressed, false);
		}
		else if (UICamera.currentTouch.PPKODABGJDM == base.gameObject)
		{
			if (UICamera.currentScheme == UICamera.DOCFHOGBBJH.Controller)
			{
				SetState(OEOIIKMBGAG.Hover, false);
			}
			else if (UICamera.currentScheme == UICamera.DOCFHOGBBJH.Mouse && UICamera.hoveredObject == base.gameObject)
			{
				SetState(OEOIIKMBGAG.Hover, false);
			}
			else
			{
				SetState(OEOIIKMBGAG.Normal, false);
			}
		}
		else
		{
			SetState(OEOIIKMBGAG.Normal, false);
		}
	}

	private void Start()
	{
		if (!get_isEnabled())
		{
			SetState(OEOIIKMBGAG.Disabled, true);
		}
	}

	public void set_state(OEOIIKMBGAG ICENKPDOHBK)
	{
		SetState(ICENKPDOHBK, false);
	}

	protected virtual void BPCIDNODNHP()
	{
		if (get_isEnabled())
		{
			if (!MCLOOFPOPDL)
			{
				OHHOHFAGBBF();
			}
			if (tweenTarget != null)
			{
				SetState((OEOIIKMBGAG)4, false);
			}
		}
	}

	[SpecialName]
	public OEOIIKMBGAG LAKIHPDNIJG()
	{
		return BKCIEADLBLD;
	}

	protected virtual void MBDLDNAHAIM()
	{
		if (MCLOOFPOPDL && tweenTarget != null)
		{
			GLPNDBIKLMH(OEOIIKMBGAG.Normal, false);
			TweenColor component = tweenTarget.GetComponent<TweenColor>();
			if (component != null)
			{
				component.JJLJDLCDJOH(BAOFOHKGELG);
				component.enabled = false;
			}
		}
	}

	[SpecialName]
	public Color CCHLPJJPILL()
	{
		if (!MCLOOFPOPDL)
		{
			OHHOHFAGBBF();
		}
		return BAOFOHKGELG;
	}

	protected virtual void DGHCKMGOOGK(bool MLIBCICOOAI)
	{
		if (get_isEnabled())
		{
			if (!MCLOOFPOPDL)
			{
				OHHOHFAGBBF();
			}
			if (tweenTarget != null)
			{
				SetState(MLIBCICOOAI ? OEOIIKMBGAG.Hover : OEOIIKMBGAG.Normal, false);
			}
		}
	}

	protected virtual void CEOPNIHIIIB(bool IOGFFPOIBBB)
	{
		if (get_isEnabled() && (!IOGFFPOIBBB || UICamera.currentScheme == (UICamera.DOCFHOGBBJH)4) && tweenTarget != null)
		{
			DGHCKMGOOGK(IOGFFPOIBBB);
		}
	}

	public virtual void GLPNDBIKLMH(OEOIIKMBGAG EBILEBOJADB, bool MABBBDMDFHE)
	{
		if (!MCLOOFPOPDL)
		{
			MCLOOFPOPDL = false;
			OHHOHFAGBBF();
		}
		if (BKCIEADLBLD != EBILEBOJADB)
		{
			BKCIEADLBLD = EBILEBOJADB;
			UpdateColor(MABBBDMDFHE);
		}
	}

	protected virtual void OnDisable()
	{
		if (MCLOOFPOPDL && tweenTarget != null)
		{
			SetState(OEOIIKMBGAG.Normal, true);
			TweenColor component = tweenTarget.GetComponent<TweenColor>();
			if (component != null)
			{
				component.set_value(BAOFOHKGELG);
				component.enabled = false;
			}
		}
	}

	public virtual bool get_isEnabled()
	{
		return base.enabled;
	}

	public virtual void GFOLACFLJJJ(OEOIIKMBGAG EBILEBOJADB, bool MABBBDMDFHE)
	{
		if (!MCLOOFPOPDL)
		{
			MCLOOFPOPDL = false;
			OHHOHFAGBBF();
		}
		if (BKCIEADLBLD != EBILEBOJADB)
		{
			BKCIEADLBLD = EBILEBOJADB;
			UpdateColor(MABBBDMDFHE);
		}
	}

	private void NMANMMOMHHD()
	{
		if (!get_isEnabled())
		{
			GLPNDBIKLMH(OEOIIKMBGAG.Pressed, false);
		}
	}

	protected virtual void KHKBNJELENL()
	{
		if (MCLOOFPOPDL && tweenTarget != null)
		{
			GLPNDBIKLMH(OEOIIKMBGAG.Hover, true);
			TweenColor component = tweenTarget.GetComponent<TweenColor>();
			if (component != null)
			{
				component.set_value(BAOFOHKGELG);
				component.enabled = false;
			}
		}
	}

	protected virtual void JADBJGCMIMF(bool IOGFFPOIBBB)
	{
		if (get_isEnabled() && (!IOGFFPOIBBB || UICamera.currentScheme == UICamera.DOCFHOGBBJH.Controller) && tweenTarget != null)
		{
			DGHCKMGOOGK(IOGFFPOIBBB);
		}
	}

	protected virtual void OnEnable()
	{
		if (MCLOOFPOPDL)
		{
			DGHCKMGOOGK(UICamera.IsHighlighted(base.gameObject));
		}
		if (UICamera.currentTouch != null)
		{
			if (UICamera.currentTouch.NLGJIEONPNP == base.gameObject)
			{
				NDNBPKKAKDJ(true);
			}
			else if (UICamera.currentTouch.PPKODABGJDM == base.gameObject)
			{
				DGHCKMGOOGK(true);
			}
		}
	}

	[SpecialName]
	public void NBKHAELMBKJ(Color ICENKPDOHBK)
	{
		if (!MCLOOFPOPDL)
		{
			OHHOHFAGBBF();
		}
		BAOFOHKGELG = ICENKPDOHBK;
		OEOIIKMBGAG bKCIEADLBLD = BKCIEADLBLD;
		BKCIEADLBLD = (OEOIIKMBGAG)6;
		GLPNDBIKLMH(bKCIEADLBLD, true);
	}

	public virtual void SetState(OEOIIKMBGAG EBILEBOJADB, bool MABBBDMDFHE)
	{
		if (!MCLOOFPOPDL)
		{
			MCLOOFPOPDL = true;
			OHHOHFAGBBF();
		}
		if (BKCIEADLBLD != EBILEBOJADB)
		{
			BKCIEADLBLD = EBILEBOJADB;
			UpdateColor(MABBBDMDFHE);
		}
	}

	public virtual void set_isEnabled(bool ICENKPDOHBK)
	{
		base.enabled = ICENKPDOHBK;
	}

	public OEOIIKMBGAG get_state()
	{
		return BKCIEADLBLD;
	}

	public void set_defaultColor(Color ICENKPDOHBK)
	{
		if (!MCLOOFPOPDL)
		{
			OHHOHFAGBBF();
		}
		BAOFOHKGELG = ICENKPDOHBK;
		OEOIIKMBGAG bKCIEADLBLD = BKCIEADLBLD;
		BKCIEADLBLD = OEOIIKMBGAG.Disabled;
		SetState(bKCIEADLBLD, false);
	}

	protected virtual void HDOPLMKBFEA()
	{
		if (get_isEnabled())
		{
			if (!MCLOOFPOPDL)
			{
				OHHOHFAGBBF();
			}
			if (tweenTarget != null)
			{
				SetState(OEOIIKMBGAG.Normal, false);
			}
		}
	}

	protected virtual void OHHOHFAGBBF()
	{
		MCLOOFPOPDL = true;
		if (tweenTarget == null)
		{
			tweenTarget = base.gameObject;
		}
		MCIOOPNKLDF = tweenTarget.GetComponent<UIWidget>();
		if (MCIOOPNKLDF != null)
		{
			BAOFOHKGELG = MCIOOPNKLDF.get_color();
			ICMIBPBBOJJ = BAOFOHKGELG;
			return;
		}
		Renderer renderer = tweenTarget.GetComponent<Renderer>();
		if (renderer != null)
		{
			BAOFOHKGELG = ((!Application.isPlaying) ? renderer.sharedMaterial.color : renderer.material.color);
			ICMIBPBBOJJ = BAOFOHKGELG;
			return;
		}
		Light light = tweenTarget.GetComponent<Light>();
		if (light != null)
		{
			BAOFOHKGELG = light.color;
			ICMIBPBBOJJ = BAOFOHKGELG;
		}
		else
		{
			tweenTarget = null;
			MCLOOFPOPDL = false;
		}
	}

	protected virtual void LJAIHEEJBID()
	{
		if (get_isEnabled())
		{
			if (!MCLOOFPOPDL)
			{
				OHHOHFAGBBF();
			}
			if (tweenTarget != null)
			{
				SetState(OEOIIKMBGAG.Pressed, false);
			}
		}
	}

	public Color get_defaultColor()
	{
		if (!MCLOOFPOPDL)
		{
			OHHOHFAGBBF();
		}
		return BAOFOHKGELG;
	}
}
