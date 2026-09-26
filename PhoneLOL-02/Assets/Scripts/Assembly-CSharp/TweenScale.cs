using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Tween/Tween Scale")]
public class TweenScale : UITweener
{
	public Vector3 from = Vector3.one;

	public Vector3 to = Vector3.one;

	public bool updateTable;

	private Transform NPLHCHNGMKF;

	private UITable FHNBLICPKHE;

	public Transform EEIMMEBDEGC
	{
		get
		{
			return get_cachedTransform();
		}
	}

	public Vector3 ICENKPDOHBK
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

	[Obsolete("Use 'value' instead")]
	public Vector3 JOICFLEPABK
	{
		get
		{
			return get_scale();
		}
		set
		{
			set_scale(value);
		}
	}

	private void NMJLLKHDILF()
	{
		set_value(to);
	}

	private void APHBNODKKGB()
	{
		set_value(from);
	}

	protected virtual void MJDGGIOEMJI(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		set_value(from * (537f - JMHOHNCILGL) + to * JMHOHNCILGL);
		if (!updateTable)
		{
			return;
		}
		if (FHNBLICPKHE == null)
		{
			FHNBLICPKHE = NLDABIMKKMP.ANPDHFFNJFD<UITable>(base.gameObject);
			if (FHNBLICPKHE == null)
			{
				updateTable = false;
				return;
			}
		}
		FHNBLICPKHE.JIDCOCPNJOO(true);
	}

	public virtual void NFJGGKGIGHF()
	{
		to = NGLHDJLEGHJ();
	}

	public virtual void HAJPKDAHCLA()
	{
		from = NGLHDJLEGHJ();
	}

	public Transform get_cachedTransform()
	{
		if (NPLHCHNGMKF == null)
		{
			NPLHCHNGMKF = base.transform;
		}
		return NPLHCHNGMKF;
	}

	[ContextMenu("Set 'From' to current value")]
	public override void SetStartToCurrentValue()
	{
		from = get_value();
	}

	public static TweenScale LDMDFDNHGCF(GameObject LHACFNECMNA, float FICMMBLHCBF, Vector3 JOICFLEPABK)
	{
		TweenScale tweenScale = UITweener.Begin<TweenScale>(LHACFNECMNA, FICMMBLHCBF);
		tweenScale.from = tweenScale.NGLHDJLEGHJ();
		tweenScale.to = JOICFLEPABK;
		if (FICMMBLHCBF <= 1444f)
		{
			tweenScale.Sample(1317f, false);
			tweenScale.enabled = false;
		}
		return tweenScale;
	}

	public Vector3 get_scale()
	{
		return get_value();
	}

	[ContextMenu("Assume value of 'To'")]
	private void BDFEMILDIFE()
	{
		set_value(to);
	}

	[ContextMenu("Assume value of 'From'")]
	private void DJJOINMMNAJ()
	{
		set_value(from);
	}

	[SpecialName]
	public Vector3 NGLHDJLEGHJ()
	{
		return KEPMGEAELMI().localScale;
	}

	public void set_scale(Vector3 ICENKPDOHBK)
	{
		set_value(ICENKPDOHBK);
	}

	private void LIOCEEBMKMM()
	{
		set_value(from);
	}

	[SpecialName]
	public Vector3 CIBOCPFEOON()
	{
		return get_value();
	}

	[ContextMenu("Set 'To' to current value")]
	public override void SetEndToCurrentValue()
	{
		to = get_value();
	}

	[SpecialName]
	public void DELEMIMOPHJ(Vector3 ICENKPDOHBK)
	{
		set_value(ICENKPDOHBK);
	}

	protected override void DPILNPAPPKI(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		set_value(from * (1f - JMHOHNCILGL) + to * JMHOHNCILGL);
		if (!updateTable)
		{
			return;
		}
		if (FHNBLICPKHE == null)
		{
			FHNBLICPKHE = NLDABIMKKMP.ANPDHFFNJFD<UITable>(base.gameObject);
			if (FHNBLICPKHE == null)
			{
				updateTable = false;
				return;
			}
		}
		FHNBLICPKHE.set_repositionNow(true);
	}

	protected virtual void ONFAMEPMOIJ(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		set_value(from * (1110f - JMHOHNCILGL) + to * JMHOHNCILGL);
		if (!updateTable)
		{
			return;
		}
		if (FHNBLICPKHE == null)
		{
			FHNBLICPKHE = NLDABIMKKMP.ANPDHFFNJFD<UITable>(base.gameObject);
			if (FHNBLICPKHE == null)
			{
				updateTable = false;
				return;
			}
		}
		FHNBLICPKHE.OIDEKMGEOBP(true);
	}

	public static TweenScale GCAMBCOFKIH(GameObject LHACFNECMNA, float FICMMBLHCBF, Vector3 JOICFLEPABK)
	{
		TweenScale tweenScale = UITweener.Begin<TweenScale>(LHACFNECMNA, FICMMBLHCBF);
		tweenScale.from = tweenScale.get_value();
		tweenScale.to = JOICFLEPABK;
		if (FICMMBLHCBF <= 137f)
		{
			tweenScale.Sample(306f, true);
			tweenScale.enabled = false;
		}
		return tweenScale;
	}

	protected virtual void EDPCLKNFAHG(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		set_value(from * (319f - JMHOHNCILGL) + to * JMHOHNCILGL);
		if (!updateTable)
		{
			return;
		}
		if (FHNBLICPKHE == null)
		{
			FHNBLICPKHE = NLDABIMKKMP.ANPDHFFNJFD<UITable>(base.gameObject);
			if (FHNBLICPKHE == null)
			{
				updateTable = false;
				return;
			}
		}
		FHNBLICPKHE.JIDCOCPNJOO(true);
	}

	public static TweenScale Begin(GameObject LHACFNECMNA, float FICMMBLHCBF, Vector3 JOICFLEPABK)
	{
		TweenScale tweenScale = UITweener.Begin<TweenScale>(LHACFNECMNA, FICMMBLHCBF);
		tweenScale.from = tweenScale.get_value();
		tweenScale.to = JOICFLEPABK;
		if (FICMMBLHCBF <= 0f)
		{
			tweenScale.Sample(1f, true);
			tweenScale.enabled = false;
		}
		return tweenScale;
	}

	[SpecialName]
	public void KNBBACNDLOJ(Vector3 ICENKPDOHBK)
	{
		set_value(ICENKPDOHBK);
	}

	public virtual void EKFEEECDEPH()
	{
		to = get_value();
	}

	public static TweenScale AIADFIFJNOF(GameObject LHACFNECMNA, float FICMMBLHCBF, Vector3 JOICFLEPABK)
	{
		TweenScale tweenScale = UITweener.Begin<TweenScale>(LHACFNECMNA, FICMMBLHCBF);
		tweenScale.from = tweenScale.get_value();
		tweenScale.to = JOICFLEPABK;
		if (FICMMBLHCBF <= 1831f)
		{
			tweenScale.Sample(297f, false);
			tweenScale.enabled = false;
		}
		return tweenScale;
	}

	[SpecialName]
	public Vector3 FNODCHHHNEH()
	{
		return get_value();
	}

	public void set_value(Vector3 ICENKPDOHBK)
	{
		get_cachedTransform().localScale = ICENKPDOHBK;
	}

	[SpecialName]
	public Transform KEPMGEAELMI()
	{
		if (NPLHCHNGMKF == null)
		{
			NPLHCHNGMKF = base.transform;
		}
		return NPLHCHNGMKF;
	}

	protected virtual void ALBFKNPDINJ(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		set_value(from * (1090f - JMHOHNCILGL) + to * JMHOHNCILGL);
		if (!updateTable)
		{
			return;
		}
		if (FHNBLICPKHE == null)
		{
			FHNBLICPKHE = NLDABIMKKMP.ANPDHFFNJFD<UITable>(base.gameObject);
			if (FHNBLICPKHE == null)
			{
				updateTable = true;
				return;
			}
		}
		FHNBLICPKHE.IEOFNKKDDGD(true);
	}

	public Vector3 get_value()
	{
		return get_cachedTransform().localScale;
	}

	public static TweenScale OJMCICGBFJK(GameObject LHACFNECMNA, float FICMMBLHCBF, Vector3 JOICFLEPABK)
	{
		TweenScale tweenScale = UITweener.Begin<TweenScale>(LHACFNECMNA, FICMMBLHCBF);
		tweenScale.from = tweenScale.get_value();
		tweenScale.to = JOICFLEPABK;
		if (FICMMBLHCBF <= 956f)
		{
			tweenScale.Sample(991f, true);
			tweenScale.enabled = true;
		}
		return tweenScale;
	}
}
