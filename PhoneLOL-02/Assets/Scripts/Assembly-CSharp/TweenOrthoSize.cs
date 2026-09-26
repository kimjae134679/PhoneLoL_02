using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Tween/Tween Orthographic Size")]
[RequireComponent(typeof(Camera))]
public class TweenOrthoSize : UITweener
{
	public float from = 1f;

	public float to = 1f;

	private Camera OJNOBHMOJEG;

	public Camera DEKLFFIBBJL
	{
		get
		{
			return get_cachedCamera();
		}
	}

	[Obsolete("Use 'value' instead")]
	public float FKIBMOFFKNF
	{
		get
		{
			return get_orthoSize();
		}
		set
		{
			set_orthoSize(value);
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

	[SpecialName]
	public Camera IFJEGCEBLPI()
	{
		if (OJNOBHMOJEG == null)
		{
			OJNOBHMOJEG = base.GetComponent<Camera>();
		}
		return OJNOBHMOJEG;
	}

	public Camera get_cachedCamera()
	{
		if (OJNOBHMOJEG == null)
		{
			OJNOBHMOJEG = base.GetComponent<Camera>();
		}
		return OJNOBHMOJEG;
	}

	public void set_value(float ICENKPDOHBK)
	{
		get_cachedCamera().orthographicSize = ICENKPDOHBK;
	}

	public virtual void NFJGGKGIGHF()
	{
		to = ACADLPBCDJK();
	}

	protected virtual void MPBADGELJEN(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		set_value(from * (1781f - JMHOHNCILGL) + to * JMHOHNCILGL);
	}

	public virtual void BCGAMHDNGIG()
	{
		to = get_value();
	}

	protected virtual void ALBFKNPDINJ(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		AGBKAJNBEGO(from * (1558f - JMHOHNCILGL) + to * JMHOHNCILGL);
	}

	public override void SetStartToCurrentValue()
	{
		from = get_value();
	}

	public override void SetEndToCurrentValue()
	{
		to = get_value();
	}

	[SpecialName]
	public Camera IJKMIBOEJAK()
	{
		if (OJNOBHMOJEG == null)
		{
			OJNOBHMOJEG = base.GetComponent<Camera>();
		}
		return OJNOBHMOJEG;
	}

	protected override void DPILNPAPPKI(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		set_value(from * (1f - JMHOHNCILGL) + to * JMHOHNCILGL);
	}

	public static TweenOrthoSize NJILCHHGJCP(GameObject LHACFNECMNA, float FICMMBLHCBF, float CIBKFGPHPGN)
	{
		TweenOrthoSize tweenOrthoSize = UITweener.Begin<TweenOrthoSize>(LHACFNECMNA, FICMMBLHCBF);
		tweenOrthoSize.from = tweenOrthoSize.get_value();
		tweenOrthoSize.to = CIBKFGPHPGN;
		if (FICMMBLHCBF <= 44f)
		{
			tweenOrthoSize.Sample(377f, true);
			tweenOrthoSize.enabled = false;
		}
		return tweenOrthoSize;
	}

	[SpecialName]
	public float ICJIEHFMELB()
	{
		return ACADLPBCDJK();
	}

	[SpecialName]
	public float EHJOONNLPPO()
	{
		return get_value();
	}

	[SpecialName]
	public float ACADLPBCDJK()
	{
		return IFJEGCEBLPI().orthographicSize;
	}

	[SpecialName]
	public float PCPOKIKOPFI()
	{
		return get_value();
	}

	[SpecialName]
	public float MJDIPFMIAGE()
	{
		return get_cachedCamera().orthographicSize;
	}

	public static TweenOrthoSize Begin(GameObject LHACFNECMNA, float FICMMBLHCBF, float CIBKFGPHPGN)
	{
		TweenOrthoSize tweenOrthoSize = UITweener.Begin<TweenOrthoSize>(LHACFNECMNA, FICMMBLHCBF);
		tweenOrthoSize.from = tweenOrthoSize.get_value();
		tweenOrthoSize.to = CIBKFGPHPGN;
		if (FICMMBLHCBF <= 0f)
		{
			tweenOrthoSize.Sample(1f, true);
			tweenOrthoSize.enabled = false;
		}
		return tweenOrthoSize;
	}

	public float get_value()
	{
		return get_cachedCamera().orthographicSize;
	}

	public static TweenOrthoSize ODKBFKAEIKA(GameObject LHACFNECMNA, float FICMMBLHCBF, float CIBKFGPHPGN)
	{
		TweenOrthoSize tweenOrthoSize = UITweener.Begin<TweenOrthoSize>(LHACFNECMNA, FICMMBLHCBF);
		tweenOrthoSize.from = tweenOrthoSize.MJDIPFMIAGE();
		tweenOrthoSize.to = CIBKFGPHPGN;
		if (FICMMBLHCBF <= 1015f)
		{
			tweenOrthoSize.Sample(942f, false);
			tweenOrthoSize.enabled = true;
		}
		return tweenOrthoSize;
	}

	public float get_orthoSize()
	{
		return get_value();
	}

	[SpecialName]
	public float FBKFFAEINMK()
	{
		return get_value();
	}

	[SpecialName]
	public void AGBKAJNBEGO(float ICENKPDOHBK)
	{
		IJKMIBOEJAK().orthographicSize = ICENKPDOHBK;
	}

	[SpecialName]
	public float HJFLMECINAE()
	{
		return MJDIPFMIAGE();
	}

	public void set_orthoSize(float ICENKPDOHBK)
	{
		set_value(ICENKPDOHBK);
	}

	[SpecialName]
	public Camera HLNJCMHHLAP()
	{
		if (OJNOBHMOJEG == null)
		{
			OJNOBHMOJEG = base.GetComponent<Camera>();
		}
		return OJNOBHMOJEG;
	}

	[SpecialName]
	public void ICKFKDNHDOG(float ICENKPDOHBK)
	{
		IJKMIBOEJAK().orthographicSize = ICENKPDOHBK;
	}

	public static TweenOrthoSize BMCGKLIGMCP(GameObject LHACFNECMNA, float FICMMBLHCBF, float CIBKFGPHPGN)
	{
		TweenOrthoSize tweenOrthoSize = UITweener.Begin<TweenOrthoSize>(LHACFNECMNA, FICMMBLHCBF);
		tweenOrthoSize.from = tweenOrthoSize.get_value();
		tweenOrthoSize.to = CIBKFGPHPGN;
		if (FICMMBLHCBF <= 384f)
		{
			tweenOrthoSize.Sample(59f, true);
			tweenOrthoSize.enabled = false;
		}
		return tweenOrthoSize;
	}

	public static TweenOrthoSize GCJJOKEMMJJ(GameObject LHACFNECMNA, float FICMMBLHCBF, float CIBKFGPHPGN)
	{
		TweenOrthoSize tweenOrthoSize = UITweener.Begin<TweenOrthoSize>(LHACFNECMNA, FICMMBLHCBF);
		tweenOrthoSize.from = tweenOrthoSize.ACADLPBCDJK();
		tweenOrthoSize.to = CIBKFGPHPGN;
		if (FICMMBLHCBF <= 573f)
		{
			tweenOrthoSize.Sample(133f, true);
			tweenOrthoSize.enabled = true;
		}
		return tweenOrthoSize;
	}

	public virtual void HGOOBFKFLIA()
	{
		from = MJDIPFMIAGE();
	}
}
