using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Button")]
public class UIButton : UIButtonColor
{
	public static UIButton current;

	public bool dragHighlight;

	public string hoverSprite;

	public string pressedSprite;

	public string disabledSprite;

	public Sprite hoverSprite2D;

	public Sprite pressedSprite2D;

	public Sprite disabledSprite2D;

	public bool pixelSnap;

	public List<EventDelegate> onClick = new List<EventDelegate>();

	[NonSerialized]
	private UISprite MCOKEKMANAF;

	[NonSerialized]
	private UI2DSprite PKBBBEEDMAF;

	[NonSerialized]
	private string CAGEOALEDKB;

	[NonSerialized]
	private Sprite CDJFFBKJDPO;

	public override bool BEIOIHEIKOE
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

	public string LABMMBJADFM
	{
		get
		{
			return get_normalSprite();
		}
		set
		{
			set_normalSprite(value);
		}
	}

	public Sprite BPOKAMHDIME
	{
		get
		{
			return get_normalSprite2D();
		}
		set
		{
			set_normalSprite2D(value);
		}
	}

	protected void AABAAJNDKHK(string NBEPJPOEBBE)
	{
		if (MCOKEKMANAF != null && !string.IsNullOrEmpty(NBEPJPOEBBE) && MCOKEKMANAF.NJHDFNDHAAC() != NBEPJPOEBBE)
		{
			MCOKEKMANAF.set_spriteName(NBEPJPOEBBE);
			if (pixelSnap)
			{
				MCOKEKMANAF.MakePixelPerfect();
			}
		}
	}

	public string get_normalSprite()
	{
		if (!MCLOOFPOPDL)
		{
			OHHOHFAGBBF();
		}
		return CAGEOALEDKB;
	}

	protected override void OnEnable()
	{
		if (get_isEnabled())
		{
			if (MCLOOFPOPDL)
			{
				if (UICamera.currentScheme == UICamera.DOCFHOGBBJH.Controller)
				{
					DGHCKMGOOGK(UICamera.get_selectedObject() == base.gameObject);
				}
				else if (UICamera.currentScheme == UICamera.DOCFHOGBBJH.Mouse)
				{
					DGHCKMGOOGK(UICamera.hoveredObject == base.gameObject);
				}
				else
				{
					SetState(OEOIIKMBGAG.Normal, false);
				}
			}
		}
		else
		{
			SetState(OEOIIKMBGAG.Disabled, true);
		}
	}

	protected virtual void OnClick()
	{
		string text = "Button : " + base.gameObject.name;
		V096OriginalDiagnostics.Write(text);
		V096OriginalDiagnostics.QueueAutomaticReportImmediate(text);
		if (current == null && get_isEnabled())
		{
			current = this;
			EventDelegate.MKPMEAMPDLJ(onClick);
			current = null;
		}
		string text2 = "OnClick" + base.gameObject.name;
		V096OriginalDiagnostics.Write(text2);
		V096OriginalDiagnostics.QueueAutomaticReportImmediate(text2);
	}

	public override void set_isEnabled(bool ICENKPDOHBK)
	{
		if (get_isEnabled() == ICENKPDOHBK)
		{
			return;
		}
		Collider collider = base.GetComponent<Collider>();
		if (collider != null)
		{
			collider.enabled = ICENKPDOHBK;
			SetState((!ICENKPDOHBK) ? OEOIIKMBGAG.Disabled : OEOIIKMBGAG.Normal, false);
			return;
		}
		Collider2D component = GetComponent<Collider2D>();
		if (component != null)
		{
			component.enabled = ICENKPDOHBK;
			SetState((!ICENKPDOHBK) ? OEOIIKMBGAG.Disabled : OEOIIKMBGAG.Normal, false);
		}
		else
		{
			base.enabled = ICENKPDOHBK;
		}
	}

	public override void SetState(OEOIIKMBGAG EBILEBOJADB, bool JFLFDJEDCKI)
	{
		base.SetState(EBILEBOJADB, JFLFDJEDCKI);
		if (MCOKEKMANAF != null)
		{
			switch (EBILEBOJADB)
			{
			case OEOIIKMBGAG.Normal:
				PBKIONJCBBD(CAGEOALEDKB);
				break;
			case OEOIIKMBGAG.Hover:
				PBKIONJCBBD(hoverSprite);
				break;
			case OEOIIKMBGAG.Pressed:
				PBKIONJCBBD(pressedSprite);
				break;
			case OEOIIKMBGAG.Disabled:
				PBKIONJCBBD(disabledSprite);
				break;
			}
		}
		else if (PKBBBEEDMAF != null)
		{
			switch (EBILEBOJADB)
			{
			case OEOIIKMBGAG.Normal:
				PBKIONJCBBD(CDJFFBKJDPO);
				break;
			case OEOIIKMBGAG.Hover:
				PBKIONJCBBD(hoverSprite2D);
				break;
			case OEOIIKMBGAG.Pressed:
				PBKIONJCBBD(pressedSprite2D);
				break;
			case OEOIIKMBGAG.Disabled:
				PBKIONJCBBD(disabledSprite2D);
				break;
			}
		}
	}

	[SpecialName]
	public string LJKDIDJHGBE()
	{
		if (!MCLOOFPOPDL)
		{
			OHHOHFAGBBF();
		}
		return CAGEOALEDKB;
	}

	[SpecialName]
	public Sprite CDIBCMCMCCD()
	{
		if (!MCLOOFPOPDL)
		{
			GIIDNEAAJOB();
		}
		return CDJFFBKJDPO;
	}

	public virtual void KCBCLGMPBAE(OEOIIKMBGAG EBILEBOJADB, bool JFLFDJEDCKI)
	{
		base.AKNFNLNGEBE(EBILEBOJADB, JFLFDJEDCKI);
		if (MCOKEKMANAF != null)
		{
			switch (EBILEBOJADB)
			{
			case OEOIIKMBGAG.Normal:
				AABAAJNDKHK(CAGEOALEDKB);
				break;
			case OEOIIKMBGAG.Hover:
				AABAAJNDKHK(hoverSprite);
				break;
			case OEOIIKMBGAG.Pressed:
				PBKIONJCBBD(pressedSprite);
				break;
			case OEOIIKMBGAG.Disabled:
				AABAAJNDKHK(disabledSprite);
				break;
			}
		}
		else if (PKBBBEEDMAF != null)
		{
			switch (EBILEBOJADB)
			{
			case OEOIIKMBGAG.Normal:
				PBKIONJCBBD(CDJFFBKJDPO);
				break;
			case OEOIIKMBGAG.Hover:
				PBKIONJCBBD(hoverSprite2D);
				break;
			case OEOIIKMBGAG.Pressed:
				PBKIONJCBBD(pressedSprite2D);
				break;
			case OEOIIKMBGAG.Disabled:
				PBKIONJCBBD(disabledSprite2D);
				break;
			}
		}
	}

	public virtual void OHLFDACPFDL(OEOIIKMBGAG EBILEBOJADB, bool JFLFDJEDCKI)
	{
		base.GLPNDBIKLMH(EBILEBOJADB, JFLFDJEDCKI);
		if (MCOKEKMANAF != null)
		{
			switch (EBILEBOJADB)
			{
			case OEOIIKMBGAG.Normal:
				AABAAJNDKHK(CAGEOALEDKB);
				break;
			case OEOIIKMBGAG.Hover:
				AABAAJNDKHK(hoverSprite);
				break;
			case OEOIIKMBGAG.Pressed:
				AABAAJNDKHK(pressedSprite);
				break;
			case OEOIIKMBGAG.Disabled:
				PBKIONJCBBD(disabledSprite);
				break;
			}
		}
		else if (PKBBBEEDMAF != null)
		{
			switch (EBILEBOJADB)
			{
			case OEOIIKMBGAG.Normal:
				PBKIONJCBBD(CDJFFBKJDPO);
				break;
			case OEOIIKMBGAG.Hover:
				PBKIONJCBBD(hoverSprite2D);
				break;
			case OEOIIKMBGAG.Pressed:
				PBKIONJCBBD(pressedSprite2D);
				break;
			case OEOIIKMBGAG.Disabled:
				PBKIONJCBBD(disabledSprite2D);
				break;
			}
		}
	}

	[SpecialName]
	public void LOGLPIGEGDP(string ICENKPDOHBK)
	{
		if (MCOKEKMANAF != null && !string.IsNullOrEmpty(CAGEOALEDKB) && CAGEOALEDKB == MCOKEKMANAF.DCLPIGEEKNF())
		{
			CAGEOALEDKB = ICENKPDOHBK;
			AABAAJNDKHK(ICENKPDOHBK);
			NLDABIMKKMP.KIODMNBCEMD(MCOKEKMANAF);
			return;
		}
		CAGEOALEDKB = ICENKPDOHBK;
		if (BKCIEADLBLD == OEOIIKMBGAG.Normal)
		{
			PBKIONJCBBD(ICENKPDOHBK);
		}
	}

	protected void PBKIONJCBBD(Sprite NBEPJPOEBBE)
	{
		if (NBEPJPOEBBE != null && PKBBBEEDMAF != null && PKBBBEEDMAF.get_sprite2D() != NBEPJPOEBBE)
		{
			PKBBBEEDMAF.set_sprite2D(NBEPJPOEBBE);
			if (pixelSnap)
			{
				PKBBBEEDMAF.MakePixelPerfect();
			}
		}
	}

	protected void PBKIONJCBBD(string NBEPJPOEBBE)
	{
		if (MCOKEKMANAF != null && !string.IsNullOrEmpty(NBEPJPOEBBE) && MCOKEKMANAF.get_spriteName() != NBEPJPOEBBE)
		{
			MCOKEKMANAF.set_spriteName(NBEPJPOEBBE);
			if (pixelSnap)
			{
				MCOKEKMANAF.MakePixelPerfect();
			}
		}
	}

	[SpecialName]
	public string IDMMDNJIDGM()
	{
		if (!MCLOOFPOPDL)
		{
			OHHOHFAGBBF();
		}
		return CAGEOALEDKB;
	}

	public void set_normalSprite2D(Sprite ICENKPDOHBK)
	{
		if (PKBBBEEDMAF != null && CDJFFBKJDPO == PKBBBEEDMAF.get_sprite2D())
		{
			CDJFFBKJDPO = ICENKPDOHBK;
			PBKIONJCBBD(ICENKPDOHBK);
			NLDABIMKKMP.KIODMNBCEMD(MCOKEKMANAF);
			return;
		}
		CDJFFBKJDPO = ICENKPDOHBK;
		if (BKCIEADLBLD == OEOIIKMBGAG.Normal)
		{
			PBKIONJCBBD(ICENKPDOHBK);
		}
	}

	protected override void OHHOHFAGBBF()
	{
		base.OHHOHFAGBBF();
		MCOKEKMANAF = MCIOOPNKLDF as UISprite;
		PKBBBEEDMAF = MCIOOPNKLDF as UI2DSprite;
		if (MCOKEKMANAF != null)
		{
			CAGEOALEDKB = MCOKEKMANAF.get_spriteName();
		}
		if (PKBBBEEDMAF != null)
		{
			CDJFFBKJDPO = PKBBBEEDMAF.get_sprite2D();
		}
	}

	protected override void LJAIHEEJBID()
	{
		if (get_isEnabled() && (dragHighlight || UICamera.currentTouch.NLGJIEONPNP == base.gameObject))
		{
			base.LJAIHEEJBID();
		}
	}

	[SpecialName]
	public Sprite NJHPGEBCAFB()
	{
		if (!MCLOOFPOPDL)
		{
			OHHOHFAGBBF();
		}
		return CDJFFBKJDPO;
	}

	protected virtual void GIIDNEAAJOB()
	{
		base.OHHOHFAGBBF();
		MCOKEKMANAF = MCIOOPNKLDF as UISprite;
		PKBBBEEDMAF = MCIOOPNKLDF as UI2DSprite;
		if (MCOKEKMANAF != null)
		{
			CAGEOALEDKB = MCOKEKMANAF.DCLPIGEEKNF();
		}
		if (PKBBBEEDMAF != null)
		{
			CDJFFBKJDPO = PKBBBEEDMAF.get_sprite2D();
		}
	}

	public virtual void AOAFMNDPLBF(OEOIIKMBGAG EBILEBOJADB, bool JFLFDJEDCKI)
	{
		base.AKNFNLNGEBE(EBILEBOJADB, JFLFDJEDCKI);
		if (MCOKEKMANAF != null)
		{
			switch (EBILEBOJADB)
			{
			case OEOIIKMBGAG.Normal:
				AABAAJNDKHK(CAGEOALEDKB);
				break;
			case OEOIIKMBGAG.Hover:
				PBKIONJCBBD(hoverSprite);
				break;
			case OEOIIKMBGAG.Pressed:
				PBKIONJCBBD(pressedSprite);
				break;
			case OEOIIKMBGAG.Disabled:
				PBKIONJCBBD(disabledSprite);
				break;
			}
		}
		else if (PKBBBEEDMAF != null)
		{
			switch (EBILEBOJADB)
			{
			case OEOIIKMBGAG.Normal:
				PBKIONJCBBD(CDJFFBKJDPO);
				break;
			case OEOIIKMBGAG.Hover:
				PBKIONJCBBD(hoverSprite2D);
				break;
			case OEOIIKMBGAG.Pressed:
				PBKIONJCBBD(pressedSprite2D);
				break;
			case OEOIIKMBGAG.Disabled:
				PBKIONJCBBD(disabledSprite2D);
				break;
			}
		}
	}

	protected virtual void ALJEFBEMCFK()
	{
		if (get_isEnabled())
		{
			if (MCLOOFPOPDL)
			{
				if (UICamera.currentScheme == UICamera.DOCFHOGBBJH.Controller)
				{
					DGHCKMGOOGK(UICamera.get_selectedObject() == base.gameObject);
				}
				else if (UICamera.currentScheme == UICamera.DOCFHOGBBJH.Mouse)
				{
					DGHCKMGOOGK(UICamera.hoveredObject == base.gameObject);
				}
				else
				{
					AOAFMNDPLBF(OEOIIKMBGAG.Normal, true);
				}
			}
		}
		else
		{
			SetState(OEOIIKMBGAG.Disabled, true);
		}
	}

	[SpecialName]
	public virtual void DMAMACNDKGD(bool ICENKPDOHBK)
	{
		if (get_isEnabled() == ICENKPDOHBK)
		{
			return;
		}
		Collider collider = base.GetComponent<Collider>();
		if (collider != null)
		{
			collider.enabled = ICENKPDOHBK;
			AOAFMNDPLBF((!ICENKPDOHBK) ? OEOIIKMBGAG.Pressed : OEOIIKMBGAG.Normal, false);
			return;
		}
		Collider2D component = GetComponent<Collider2D>();
		if (component != null)
		{
			component.enabled = ICENKPDOHBK;
			KCBCLGMPBAE(ICENKPDOHBK ? OEOIIKMBGAG.Hover : OEOIIKMBGAG.Pressed, true);
		}
		else
		{
			base.enabled = ICENKPDOHBK;
		}
	}

	public void set_normalSprite(string ICENKPDOHBK)
	{
		if (MCOKEKMANAF != null && !string.IsNullOrEmpty(CAGEOALEDKB) && CAGEOALEDKB == MCOKEKMANAF.get_spriteName())
		{
			CAGEOALEDKB = ICENKPDOHBK;
			PBKIONJCBBD(ICENKPDOHBK);
			NLDABIMKKMP.KIODMNBCEMD(MCOKEKMANAF);
			return;
		}
		CAGEOALEDKB = ICENKPDOHBK;
		if (BKCIEADLBLD == OEOIIKMBGAG.Normal)
		{
			PBKIONJCBBD(ICENKPDOHBK);
		}
	}

	[SpecialName]
	public Sprite DCFCOMLGCMB()
	{
		if (!MCLOOFPOPDL)
		{
			GIIDNEAAJOB();
		}
		return CDJFFBKJDPO;
	}

	protected override void HDOPLMKBFEA()
	{
		if (get_isEnabled() && (dragHighlight || UICamera.currentTouch.NLGJIEONPNP == base.gameObject))
		{
			base.HDOPLMKBFEA();
		}
	}

	[SpecialName]
	public virtual void FHCMBHPGINO(bool ICENKPDOHBK)
	{
		if (get_isEnabled() == ICENKPDOHBK)
		{
			return;
		}
		Collider collider = base.GetComponent<Collider>();
		if (collider != null)
		{
			collider.enabled = ICENKPDOHBK;
			OHLFDACPFDL(ICENKPDOHBK ? OEOIIKMBGAG.Hover : ((OEOIIKMBGAG)8), false);
			return;
		}
		Collider2D component = GetComponent<Collider2D>();
		if (component != null)
		{
			component.enabled = ICENKPDOHBK;
			OHLFDACPFDL((!ICENKPDOHBK) ? ((OEOIIKMBGAG)8) : OEOIIKMBGAG.Normal, true);
		}
		else
		{
			base.enabled = ICENKPDOHBK;
		}
	}

	public override bool get_isEnabled()
	{
		if (!base.enabled)
		{
			return false;
		}
		Collider collider = base.GetComponent<Collider>();
		if ((bool)collider && collider.enabled)
		{
			return true;
		}
		Collider2D component = GetComponent<Collider2D>();
		return (bool)component && component.enabled;
	}

	protected virtual void JDMOCFODCFG()
	{
		if (get_isEnabled())
		{
			if (MCLOOFPOPDL)
			{
				if (UICamera.currentScheme == (UICamera.DOCFHOGBBJH)6)
				{
					DGHCKMGOOGK(UICamera.get_selectedObject() == base.gameObject);
				}
				else if (UICamera.currentScheme == UICamera.DOCFHOGBBJH.Mouse)
				{
					DGHCKMGOOGK(UICamera.hoveredObject == base.gameObject);
				}
				else
				{
					OHLFDACPFDL(OEOIIKMBGAG.Hover, false);
				}
			}
		}
		else
		{
			OHLFDACPFDL(OEOIIKMBGAG.Pressed, true);
		}
	}

	public Sprite get_normalSprite2D()
	{
		if (!MCLOOFPOPDL)
		{
			OHHOHFAGBBF();
		}
		return CDJFFBKJDPO;
	}
}
