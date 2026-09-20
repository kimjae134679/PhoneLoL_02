using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Tween/Tween Alpha")]
public class TweenAlpha : UITweener
{
	[Range(0f, 1f)]
	public float from = 1f;

	[Range(0f, 1f)]
	public float to = 1f;

	private UIRect DIKJAIJMKMF;

	public UIRect BPOOKPONNDE
	{
		get
		{
			return get_cachedRect();
		}
	}

	[Obsolete("Use 'value' instead")]
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

	public virtual void AGIJJBPEDLC()
	{
		from = NGLHDJLEGHJ();
	}

	public float get_alpha()
	{
		return get_value();
	}

	public void set_alpha(float ICENKPDOHBK)
	{
		set_value(ICENKPDOHBK);
	}

	[SpecialName]
	public float MMGHEOFGKJP()
	{
		return NGLHDJLEGHJ();
	}

	public static TweenAlpha Begin(GameObject LHACFNECMNA, float FICMMBLHCBF, float KHMMAABNHJI)
	{
		TweenAlpha tweenAlpha = UITweener.Begin<TweenAlpha>(LHACFNECMNA, FICMMBLHCBF);
		tweenAlpha.from = tweenAlpha.get_value();
		tweenAlpha.to = KHMMAABNHJI;
		if (FICMMBLHCBF <= 0f)
		{
			tweenAlpha.Sample(1f, true);
			tweenAlpha.enabled = false;
		}
		return tweenAlpha;
	}

	protected virtual void ALBFKNPDINJ(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		LAAKIDMLCFA(Mathf.Lerp(from, to, JMHOHNCILGL));
	}

	public virtual void FBMAKJJNOHE()
	{
		from = get_value();
	}

	[SpecialName]
	public void IFGJFOHIGEM(float ICENKPDOHBK)
	{
		get_cachedRect().set_alpha(ICENKPDOHBK);
	}

	public float get_value()
	{
		return get_cachedRect().get_alpha();
	}

	[SpecialName]
	public float GCDLJOCAMBP()
	{
		return get_value();
	}

	[SpecialName]
	public float NGLHDJLEGHJ()
	{
		return get_cachedRect().get_alpha();
	}

	public void set_value(float ICENKPDOHBK)
	{
		get_cachedRect().set_alpha(ICENKPDOHBK);
	}

	protected override void DPILNPAPPKI(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		set_value(Mathf.Lerp(from, to, JMHOHNCILGL));
	}

	public virtual void BEAAKHGCIOO()
	{
		from = NGLHDJLEGHJ();
	}

	[SpecialName]
	public float GJALIEBEBKD()
	{
		return get_value();
	}

	public override void SetStartToCurrentValue()
	{
		from = get_value();
	}

	public virtual void HONNDLHIPDP()
	{
		from = get_value();
	}

	public override void SetEndToCurrentValue()
	{
		to = get_value();
	}

	public UIRect get_cachedRect()
	{
		if (DIKJAIJMKMF == null)
		{
			DIKJAIJMKMF = GetComponent<UIRect>();
			if (DIKJAIJMKMF == null)
			{
				DIKJAIJMKMF = GetComponentInChildren<UIRect>();
			}
		}
		return DIKJAIJMKMF;
	}

	[SpecialName]
	public float IFGOMKEJKDI()
	{
		return get_value();
	}

	[SpecialName]
	public void LAAKIDMLCFA(float ICENKPDOHBK)
	{
		get_cachedRect().set_alpha(ICENKPDOHBK);
	}

	public virtual void BCGAMHDNGIG()
	{
		to = NGLHDJLEGHJ();
	}
}
