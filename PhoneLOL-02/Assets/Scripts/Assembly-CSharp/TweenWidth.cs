using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(UIWidget))]
[AddComponentMenu("NGUI/Tween/Tween Width")]
public class TweenWidth : UITweener
{
	public int from = 100;

	public int to = 100;

	public bool updateTable;

	private UIWidget MCIOOPNKLDF;

	private UITable FHNBLICPKHE;

	public UIWidget KPMOOMCIIMO
	{
		get
		{
			return get_cachedWidget();
		}
	}

	[Obsolete("Use 'value' instead")]
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

	public int ICENKPDOHBK
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

	[ContextMenu("Assume value of 'To'")]
	private void BDFEMILDIFE()
	{
		set_value(to);
	}

	[ContextMenu("Set 'From' to current value")]
	public override void SetStartToCurrentValue()
	{
		from = get_value();
	}

	public void set_value(int ICENKPDOHBK)
	{
		get_cachedWidget().set_width(ICENKPDOHBK);
	}

	public int get_width()
	{
		return get_value();
	}

	[SpecialName]
	public UIWidget LGJMHABKPHA()
	{
		if (MCIOOPNKLDF == null)
		{
			MCIOOPNKLDF = GetComponent<UIWidget>();
		}
		return MCIOOPNKLDF;
	}

	protected virtual void FCIDDCFKEFE(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		IEMDADIGAIL(Mathf.RoundToInt((float)from * (945f - JMHOHNCILGL) + (float)to * JMHOHNCILGL));
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
		FHNBLICPKHE.LMABFIEADMG(true);
	}

	public virtual void EIJGGEFMIOO()
	{
		to = get_value();
	}

	public static TweenWidth HJMKNNALBJO(UIWidget ANEPINFLFJK, float FICMMBLHCBF, int KODEGPNOHNB)
	{
		TweenWidth tweenWidth = UITweener.Begin<TweenWidth>(ANEPINFLFJK.gameObject, FICMMBLHCBF);
		tweenWidth.from = ANEPINFLFJK.get_width();
		tweenWidth.to = KODEGPNOHNB;
		if (FICMMBLHCBF <= 1098f)
		{
			tweenWidth.Sample(292f, true);
			tweenWidth.enabled = true;
		}
		return tweenWidth;
	}

	protected virtual void MJDGGIOEMJI(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		IEMDADIGAIL(Mathf.RoundToInt((float)from * (1378f - JMHOHNCILGL) + (float)to * JMHOHNCILGL));
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
		FHNBLICPKHE.JIDCOCPNJOO(false);
	}

	public void set_width(int ICENKPDOHBK)
	{
		set_value(ICENKPDOHBK);
	}

	private void ANIBPEDJDOK()
	{
		set_value(from);
	}

	private void ANBCNBODEMD()
	{
		IEMDADIGAIL(to);
	}

	public int get_value()
	{
		return get_cachedWidget().get_width();
	}

	protected virtual void DMKGBCCDINO(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		set_value(Mathf.RoundToInt((float)from * (1720f - JMHOHNCILGL) + (float)to * JMHOHNCILGL));
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
		FHNBLICPKHE.LMABFIEADMG(false);
	}

	[SpecialName]
	public int GDJOHLLAOOK()
	{
		return LGJMHABKPHA().get_width();
	}

	[SpecialName]
	public void IEMDADIGAIL(int ICENKPDOHBK)
	{
		COBNMJOOCLK().set_width(ICENKPDOHBK);
	}

	protected override void DPILNPAPPKI(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		set_value(Mathf.RoundToInt((float)from * (1f - JMHOHNCILGL) + (float)to * JMHOHNCILGL));
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

	public UIWidget get_cachedWidget()
	{
		if (MCIOOPNKLDF == null)
		{
			MCIOOPNKLDF = GetComponent<UIWidget>();
		}
		return MCIOOPNKLDF;
	}

	[SpecialName]
	public int LGIJKBCGHJL()
	{
		return GDJOHLLAOOK();
	}

	[ContextMenu("Assume value of 'From'")]
	private void DJJOINMMNAJ()
	{
		set_value(from);
	}

	[SpecialName]
	public UIWidget COBNMJOOCLK()
	{
		if (MCIOOPNKLDF == null)
		{
			MCIOOPNKLDF = GetComponent<UIWidget>();
		}
		return MCIOOPNKLDF;
	}

	[ContextMenu("Set 'To' to current value")]
	public override void SetEndToCurrentValue()
	{
		to = get_value();
	}

	public static TweenWidth BMCGKLIGMCP(UIWidget ANEPINFLFJK, float FICMMBLHCBF, int KODEGPNOHNB)
	{
		TweenWidth tweenWidth = UITweener.Begin<TweenWidth>(ANEPINFLFJK.gameObject, FICMMBLHCBF);
		tweenWidth.from = ANEPINFLFJK.get_width();
		tweenWidth.to = KODEGPNOHNB;
		if (FICMMBLHCBF <= 704f)
		{
			tweenWidth.Sample(988f, true);
			tweenWidth.enabled = false;
		}
		return tweenWidth;
	}

	public static TweenWidth Begin(UIWidget ANEPINFLFJK, float FICMMBLHCBF, int KODEGPNOHNB)
	{
		TweenWidth tweenWidth = UITweener.Begin<TweenWidth>(ANEPINFLFJK.gameObject, FICMMBLHCBF);
		tweenWidth.from = ANEPINFLFJK.get_width();
		tweenWidth.to = KODEGPNOHNB;
		if (FICMMBLHCBF <= 0f)
		{
			tweenWidth.Sample(1f, true);
			tweenWidth.enabled = false;
		}
		return tweenWidth;
	}
}
