using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(UIWidget))]
[AddComponentMenu("NGUI/Tween/Tween Height")]
public class TweenHeight : UITweener
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

	protected virtual void CDNHNOCLMPP(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		IEMDADIGAIL(Mathf.RoundToInt((float)from * (846f - JMHOHNCILGL) + (float)to * JMHOHNCILGL));
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
		FHNBLICPKHE.set_repositionNow(false);
	}

	[ContextMenu("Set 'To' to current value")]
	public override void SetEndToCurrentValue()
	{
		to = get_value();
	}

	public int get_height()
	{
		return get_value();
	}

	[SpecialName]
	public void GPOPEFLHBEF(int ICENKPDOHBK)
	{
		get_cachedWidget().set_height(ICENKPDOHBK);
	}

	[SpecialName]
	public int LHECGEMDJMH()
	{
		return FHOKOOFGEJA().get_height();
	}

	[SpecialName]
	public void FOBPGMDAIDB(int ICENKPDOHBK)
	{
		get_cachedWidget().set_height(ICENKPDOHBK);
	}

	public virtual void MHNOKBKLNOF()
	{
		from = get_value();
	}

	[SpecialName]
	public int GKIOOEFIOID()
	{
		return get_cachedWidget().get_height();
	}

	private void MAIKGCGGBBA()
	{
		set_value(to);
	}

	[SpecialName]
	public void HPOLGFBOLKH(int ICENKPDOHBK)
	{
		GPOPEFLHBEF(ICENKPDOHBK);
	}

	public virtual void JHAAJLKKGLD()
	{
		to = GKIOOEFIOID();
	}

	public virtual void LKOGEKNAOAO()
	{
		from = get_value();
	}

	[SpecialName]
	public int JLFKBPKOHGN()
	{
		return LHECGEMDJMH();
	}

	[SpecialName]
	public void ICKFKDNHDOG(int ICENKPDOHBK)
	{
		FHOKOOFGEJA().set_height(ICENKPDOHBK);
	}

	public virtual void PMEDDBMKFNO()
	{
		to = LHECGEMDJMH();
	}

	[SpecialName]
	public void HKCOAAAFBFI(int ICENKPDOHBK)
	{
		IEMDADIGAIL(ICENKPDOHBK);
	}

	public int get_value()
	{
		return get_cachedWidget().get_height();
	}

	public virtual void PBBCOINAAII()
	{
		to = MJDIPFMIAGE();
	}

	[ContextMenu("Assume value of 'From'")]
	private void DJJOINMMNAJ()
	{
		set_value(from);
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

	public static TweenHeight GHOKHJDJMCD(UIWidget ANEPINFLFJK, float FICMMBLHCBF, int JPGIEHMKOPA)
	{
		TweenHeight tweenHeight = UITweener.Begin<TweenHeight>(ANEPINFLFJK.gameObject, FICMMBLHCBF);
		tweenHeight.from = ANEPINFLFJK.get_height();
		tweenHeight.to = JPGIEHMKOPA;
		if (FICMMBLHCBF <= 268f)
		{
			tweenHeight.Sample(686f, true);
			tweenHeight.enabled = true;
		}
		return tweenHeight;
	}

	private void KFEKJBIOOHE()
	{
		INGGBCLDOGO(from);
	}

	public void set_height(int ICENKPDOHBK)
	{
		set_value(ICENKPDOHBK);
	}

	protected virtual void EPHNLJGAMAJ(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		FOBPGMDAIDB(Mathf.RoundToInt((float)from * (1470f - JMHOHNCILGL) + (float)to * JMHOHNCILGL));
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
		FHNBLICPKHE.IEOFNKKDDGD(true);
	}

	protected virtual void GNLBHFEOCAF(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		INGGBCLDOGO(Mathf.RoundToInt((float)from * (1281f - JMHOHNCILGL) + (float)to * JMHOHNCILGL));
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

	private void BODCDIOGKJB()
	{
		ICKFKDNHDOG(from);
	}

	[SpecialName]
	public int MJDIPFMIAGE()
	{
		return FHOKOOFGEJA().get_height();
	}

	public static TweenHeight Begin(UIWidget ANEPINFLFJK, float FICMMBLHCBF, int JPGIEHMKOPA)
	{
		TweenHeight tweenHeight = UITweener.Begin<TweenHeight>(ANEPINFLFJK.gameObject, FICMMBLHCBF);
		tweenHeight.from = ANEPINFLFJK.get_height();
		tweenHeight.to = JPGIEHMKOPA;
		if (FICMMBLHCBF <= 0f)
		{
			tweenHeight.Sample(1f, true);
			tweenHeight.enabled = false;
		}
		return tweenHeight;
	}

	public static TweenHeight AIADFIFJNOF(UIWidget ANEPINFLFJK, float FICMMBLHCBF, int JPGIEHMKOPA)
	{
		TweenHeight tweenHeight = UITweener.Begin<TweenHeight>(ANEPINFLFJK.gameObject, FICMMBLHCBF);
		tweenHeight.from = ANEPINFLFJK.get_height();
		tweenHeight.to = JPGIEHMKOPA;
		if (FICMMBLHCBF <= 1586f)
		{
			tweenHeight.Sample(1752f, true);
			tweenHeight.enabled = true;
		}
		return tweenHeight;
	}

	private void OIFMMKMGHBH()
	{
		GPOPEFLHBEF(from);
	}

	[SpecialName]
	public void IEMDADIGAIL(int ICENKPDOHBK)
	{
		FHOKOOFGEJA().set_height(ICENKPDOHBK);
	}

	[SpecialName]
	public void INGGBCLDOGO(int ICENKPDOHBK)
	{
		FHOKOOFGEJA().set_height(ICENKPDOHBK);
	}

	[ContextMenu("Assume value of 'To'")]
	private void BDFEMILDIFE()
	{
		set_value(to);
	}

	[SpecialName]
	public void GBLOPCOPJKE(int ICENKPDOHBK)
	{
		ICKFKDNHDOG(ICENKPDOHBK);
	}

	public void set_value(int ICENKPDOHBK)
	{
		get_cachedWidget().set_height(ICENKPDOHBK);
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
	public UIWidget FHOKOOFGEJA()
	{
		if (MCIOOPNKLDF == null)
		{
			MCIOOPNKLDF = GetComponent<UIWidget>();
		}
		return MCIOOPNKLDF;
	}

	private void NMJLLKHDILF()
	{
		IEMDADIGAIL(to);
	}

	[ContextMenu("Set 'From' to current value")]
	public override void SetStartToCurrentValue()
	{
		from = get_value();
	}
}
