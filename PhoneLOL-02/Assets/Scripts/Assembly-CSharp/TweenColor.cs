using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Tween/Tween Color")]
public class TweenColor : UITweener
{
	public Color from = Color.white;

	public Color to = Color.white;

	private bool POAEHCAPMJO;

	private UIWidget MCIOOPNKLDF;

	private Material AAJODBBAEGG;

	private Light IIMKAFFFNJE;

	[Obsolete("Use 'value' instead")]
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

	public Color ICENKPDOHBK
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

	[ContextMenu("Set 'To' to current value")]
	public override void SetEndToCurrentValue()
	{
		to = get_value();
	}

	[SpecialName]
	public void LGEMMGCDBHO(Color ICENKPDOHBK)
	{
		JJLJDLCDJOH(ICENKPDOHBK);
	}

	private void HBMGBEJHIPL()
	{
		POAEHCAPMJO = true;
		MCIOOPNKLDF = GetComponent<UIWidget>();
		Renderer renderer = base.GetComponent<Renderer>();
		if (renderer != null)
		{
			AAJODBBAEGG = renderer.material;
		}
		IIMKAFFFNJE = base.GetComponent<Light>();
		if (MCIOOPNKLDF == null && AAJODBBAEGG == null && IIMKAFFFNJE == null)
		{
			MCIOOPNKLDF = GetComponentInChildren<UIWidget>();
		}
	}

	[ContextMenu("Set 'From' to current value")]
	public override void SetStartToCurrentValue()
	{
		from = get_value();
	}

	[SpecialName]
	public void PFKBBDBKKFK(Color ICENKPDOHBK)
	{
		JJLJDLCDJOH(ICENKPDOHBK);
	}

	public Color get_color()
	{
		return get_value();
	}

	private void ANBCNBODEMD()
	{
		set_value(to);
	}

	public void set_value(Color ICENKPDOHBK)
	{
		if (!POAEHCAPMJO)
		{
			HBMGBEJHIPL();
		}
		if (MCIOOPNKLDF != null)
		{
			MCIOOPNKLDF.set_color(ICENKPDOHBK);
		}
		if (AAJODBBAEGG != null)
		{
			AAJODBBAEGG.color = ICENKPDOHBK;
		}
		if (IIMKAFFFNJE != null)
		{
			IIMKAFFFNJE.color = ICENKPDOHBK;
			IIMKAFFFNJE.enabled = ICENKPDOHBK.r + ICENKPDOHBK.g + ICENKPDOHBK.b > 0.01f;
		}
	}

	public Color get_value()
	{
		if (!POAEHCAPMJO)
		{
			HBMGBEJHIPL();
		}
		if (MCIOOPNKLDF != null)
		{
			return MCIOOPNKLDF.get_color();
		}
		if (IIMKAFFFNJE != null)
		{
			return IIMKAFFFNJE.color;
		}
		if (AAJODBBAEGG != null)
		{
			return AAJODBBAEGG.color;
		}
		return Color.black;
	}

	[ContextMenu("Assume value of 'From'")]
	private void DJJOINMMNAJ()
	{
		set_value(from);
	}

	protected override void DPILNPAPPKI(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		set_value(Color.Lerp(from, to, JMHOHNCILGL));
	}

	public virtual void BCGAMHDNGIG()
	{
		to = get_value();
	}

	public virtual void AGIJJBPEDLC()
	{
		from = get_value();
	}

	[SpecialName]
	public void JJLJDLCDJOH(Color ICENKPDOHBK)
	{
		if (!POAEHCAPMJO)
		{
			HBMGBEJHIPL();
		}
		if (MCIOOPNKLDF != null)
		{
			MCIOOPNKLDF.set_color(ICENKPDOHBK);
		}
		if (AAJODBBAEGG != null)
		{
			AAJODBBAEGG.color = ICENKPDOHBK;
		}
		if (IIMKAFFFNJE != null)
		{
			IIMKAFFFNJE.color = ICENKPDOHBK;
			IIMKAFFFNJE.enabled = ICENKPDOHBK.r + ICENKPDOHBK.g + ICENKPDOHBK.b > 709f;
		}
	}

	public virtual void MHNOKBKLNOF()
	{
		from = NGLHDJLEGHJ();
	}

	[ContextMenu("Assume value of 'To'")]
	private void BDFEMILDIFE()
	{
		set_value(to);
	}

	private void CDBJAIMMBNN()
	{
		JJLJDLCDJOH(to);
	}

	protected virtual void MJDGGIOEMJI(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		set_value(Color.Lerp(from, to, JMHOHNCILGL));
	}

	public void set_color(Color ICENKPDOHBK)
	{
		set_value(ICENKPDOHBK);
	}

	[SpecialName]
	public Color NGLHDJLEGHJ()
	{
		if (!POAEHCAPMJO)
		{
			HBMGBEJHIPL();
		}
		if (MCIOOPNKLDF != null)
		{
			return MCIOOPNKLDF.get_color();
		}
		if (IIMKAFFFNJE != null)
		{
			return IIMKAFFFNJE.color;
		}
		if (AAJODBBAEGG != null)
		{
			return AAJODBBAEGG.color;
		}
		return Color.black;
	}

	public static TweenColor Begin(GameObject LHACFNECMNA, float FICMMBLHCBF, Color BEAKIPPBGAF)
	{
		TweenColor tweenColor = UITweener.Begin<TweenColor>(LHACFNECMNA, FICMMBLHCBF);
		tweenColor.from = tweenColor.get_value();
		tweenColor.to = BEAKIPPBGAF;
		if (FICMMBLHCBF <= 0f)
		{
			tweenColor.Sample(1f, true);
			tweenColor.enabled = false;
		}
		return tweenColor;
	}
}
