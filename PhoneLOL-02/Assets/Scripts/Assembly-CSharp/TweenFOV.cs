using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Tween/Tween Field of View")]
[RequireComponent(typeof(Camera))]
public class TweenFOV : UITweener
{
	public float from = 45f;

	public float to = 45f;

	private Camera OJNOBHMOJEG;

	public Camera DEKLFFIBBJL
	{
		get
		{
			return get_cachedCamera();
		}
	}

	[Obsolete("Use 'value' instead")]
	public float IIFJIPKNCDA
	{
		get
		{
			return get_fov();
		}
		set
		{
			set_fov(value);
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

	public Camera get_cachedCamera()
	{
		if (OJNOBHMOJEG == null)
		{
			OJNOBHMOJEG = base.GetComponent<Camera>();
		}
		return OJNOBHMOJEG;
	}

	[ContextMenu("Set 'From' to current value")]
	public override void SetStartToCurrentValue()
	{
		from = get_value();
	}

	public static TweenFOV GCAMBCOFKIH(GameObject LHACFNECMNA, float FICMMBLHCBF, float CIBKFGPHPGN)
	{
		TweenFOV tweenFOV = UITweener.Begin<TweenFOV>(LHACFNECMNA, FICMMBLHCBF);
		tweenFOV.from = tweenFOV.get_value();
		tweenFOV.to = CIBKFGPHPGN;
		if (FICMMBLHCBF <= 508f)
		{
			tweenFOV.Sample(69f, false);
			tweenFOV.enabled = true;
		}
		return tweenFOV;
	}

	[ContextMenu("Assume value of 'From'")]
	private void DJJOINMMNAJ()
	{
		set_value(from);
	}

	public float get_fov()
	{
		return get_value();
	}

	private void NLKJGJJDOMJ()
	{
		set_value(from);
	}

	public static TweenFOV Begin(GameObject LHACFNECMNA, float FICMMBLHCBF, float CIBKFGPHPGN)
	{
		TweenFOV tweenFOV = UITweener.Begin<TweenFOV>(LHACFNECMNA, FICMMBLHCBF);
		tweenFOV.from = tweenFOV.get_value();
		tweenFOV.to = CIBKFGPHPGN;
		if (FICMMBLHCBF <= 0f)
		{
			tweenFOV.Sample(1f, true);
			tweenFOV.enabled = false;
		}
		return tweenFOV;
	}

	private void APHBNODKKGB()
	{
		set_value(from);
	}

	public void set_fov(float ICENKPDOHBK)
	{
		set_value(ICENKPDOHBK);
	}

	public static TweenFOV GKICFCINACN(GameObject LHACFNECMNA, float FICMMBLHCBF, float CIBKFGPHPGN)
	{
		TweenFOV tweenFOV = UITweener.Begin<TweenFOV>(LHACFNECMNA, FICMMBLHCBF);
		tweenFOV.from = tweenFOV.get_value();
		tweenFOV.to = CIBKFGPHPGN;
		if (FICMMBLHCBF <= 801f)
		{
			tweenFOV.Sample(127f, false);
			tweenFOV.enabled = true;
		}
		return tweenFOV;
	}

	protected override void DPILNPAPPKI(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		set_value(from * (1f - JMHOHNCILGL) + to * JMHOHNCILGL);
	}

	[SpecialName]
	public Camera OJMAMIIGFHD()
	{
		if (OJNOBHMOJEG == null)
		{
			OJNOBHMOJEG = base.GetComponent<Camera>();
		}
		return OJNOBHMOJEG;
	}

	[SpecialName]
	public void MHGBEGINMCN(float ICENKPDOHBK)
	{
		DLOFJAJAAED(ICENKPDOHBK);
	}

	[ContextMenu("Set 'To' to current value")]
	public override void SetEndToCurrentValue()
	{
		to = get_value();
	}

	public virtual void AEJKKHLDEEP()
	{
		to = get_value();
	}

	[SpecialName]
	public Camera PFMGPEANEEN()
	{
		if (OJNOBHMOJEG == null)
		{
			OJNOBHMOJEG = base.GetComponent<Camera>();
		}
		return OJNOBHMOJEG;
	}

	[ContextMenu("Assume value of 'To'")]
	private void BDFEMILDIFE()
	{
		set_value(to);
	}

	public virtual void NFJGGKGIGHF()
	{
		to = get_value();
	}

	public float get_value()
	{
		return get_cachedCamera().fieldOfView;
	}

	public virtual void MHNOKBKLNOF()
	{
		from = get_value();
	}

	private void ANIBPEDJDOK()
	{
		DLOFJAJAAED(from);
	}

	private void FIHMGCICBIM()
	{
		DLOFJAJAAED(from);
	}

	public void set_value(float ICENKPDOHBK)
	{
		get_cachedCamera().fieldOfView = ICENKPDOHBK;
	}

	private void CDBJAIMMBNN()
	{
		DLOFJAJAAED(to);
	}

	[SpecialName]
	public void DLOFJAJAAED(float ICENKPDOHBK)
	{
		OJMAMIIGFHD().fieldOfView = ICENKPDOHBK;
	}

	public virtual void BCGAMHDNGIG()
	{
		to = get_value();
	}

	[SpecialName]
	public Camera AJOGBFBKGKI()
	{
		if (OJNOBHMOJEG == null)
		{
			OJNOBHMOJEG = base.GetComponent<Camera>();
		}
		return OJNOBHMOJEG;
	}
}
