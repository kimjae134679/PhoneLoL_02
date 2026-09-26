using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Tween/Tween Rotation")]
public class TweenRotation : UITweener
{
	public Vector3 from;

	public Vector3 to;

	private Transform NPLHCHNGMKF;

	public Transform EEIMMEBDEGC
	{
		get
		{
			return get_cachedTransform();
		}
	}

	[Obsolete("Use 'value' instead")]
	public Quaternion DIAFJOBJCFK
	{
		get
		{
			return get_rotation();
		}
		set
		{
			set_rotation(value);
		}
	}

	public Quaternion ICENKPDOHBK
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
	public Quaternion PEJFJIAGMKF()
	{
		return get_cachedTransform().localRotation;
	}

	public void set_rotation(Quaternion ICENKPDOHBK)
	{
		set_value(ICENKPDOHBK);
	}

	public static TweenRotation Begin(GameObject LHACFNECMNA, float FICMMBLHCBF, Quaternion KMILPEHBBEL)
	{
		TweenRotation tweenRotation = UITweener.Begin<TweenRotation>(LHACFNECMNA, FICMMBLHCBF);
		tweenRotation.from = tweenRotation.get_value().eulerAngles;
		tweenRotation.to = KMILPEHBBEL.eulerAngles;
		if (FICMMBLHCBF <= 0f)
		{
			tweenRotation.Sample(1f, true);
			tweenRotation.enabled = false;
		}
		return tweenRotation;
	}

	[SpecialName]
	public Quaternion LFKBEPDDKJM()
	{
		return CMGIMLOCEDJ();
	}

	[ContextMenu("Assume value of 'From'")]
	private void DJJOINMMNAJ()
	{
		set_value(Quaternion.Euler(from));
	}

	private void OBOKLGNNPCF()
	{
		set_value(Quaternion.Euler(to));
	}

	[SpecialName]
	public Transform IHPILNNIKMM()
	{
		if (NPLHCHNGMKF == null)
		{
			NPLHCHNGMKF = base.transform;
		}
		return NPLHCHNGMKF;
	}

	public void set_value(Quaternion ICENKPDOHBK)
	{
		get_cachedTransform().localRotation = ICENKPDOHBK;
	}

	[ContextMenu("Assume value of 'To'")]
	private void BDFEMILDIFE()
	{
		set_value(Quaternion.Euler(to));
	}

	public static TweenRotation OJMCICGBFJK(GameObject LHACFNECMNA, float FICMMBLHCBF, Quaternion KMILPEHBBEL)
	{
		TweenRotation tweenRotation = UITweener.Begin<TweenRotation>(LHACFNECMNA, FICMMBLHCBF);
		tweenRotation.from = tweenRotation.PEJFJIAGMKF().eulerAngles;
		tweenRotation.to = KMILPEHBBEL.eulerAngles;
		if (FICMMBLHCBF <= 1246f)
		{
			tweenRotation.Sample(957f, false);
			tweenRotation.enabled = true;
		}
		return tweenRotation;
	}

	[ContextMenu("Set 'From' to current value")]
	public override void SetStartToCurrentValue()
	{
		from = get_value().eulerAngles;
	}

	protected virtual void GBAEKPEIHIN(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		INGGBCLDOGO(Quaternion.Euler(new Vector3(Mathf.Lerp(from.x, to.x, JMHOHNCILGL), Mathf.Lerp(from.y, to.y, JMHOHNCILGL), Mathf.Lerp(from.z, to.z, JMHOHNCILGL))));
	}

	public Quaternion get_rotation()
	{
		return get_value();
	}

	[SpecialName]
	public void DLOFJAJAAED(Quaternion ICENKPDOHBK)
	{
		get_cachedTransform().localRotation = ICENKPDOHBK;
	}

	[SpecialName]
	public Quaternion CMGIMLOCEDJ()
	{
		return get_cachedTransform().localRotation;
	}

	protected override void DPILNPAPPKI(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		set_value(Quaternion.Euler(new Vector3(Mathf.Lerp(from.x, to.x, JMHOHNCILGL), Mathf.Lerp(from.y, to.y, JMHOHNCILGL), Mathf.Lerp(from.z, to.z, JMHOHNCILGL))));
	}

	[ContextMenu("Set 'To' to current value")]
	public override void SetEndToCurrentValue()
	{
		to = get_value().eulerAngles;
	}

	public Quaternion get_value()
	{
		return get_cachedTransform().localRotation;
	}

	public Transform get_cachedTransform()
	{
		if (NPLHCHNGMKF == null)
		{
			NPLHCHNGMKF = base.transform;
		}
		return NPLHCHNGMKF;
	}

	[SpecialName]
	public Quaternion HCPKDHNIJBJ()
	{
		return PEJFJIAGMKF();
	}

	[SpecialName]
	public void INGGBCLDOGO(Quaternion ICENKPDOHBK)
	{
		get_cachedTransform().localRotation = ICENKPDOHBK;
	}

	[SpecialName]
	public void LLMMCELOHMG(Quaternion ICENKPDOHBK)
	{
		IHPILNNIKMM().localRotation = ICENKPDOHBK;
	}
}
