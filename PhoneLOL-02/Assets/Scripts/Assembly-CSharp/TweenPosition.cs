using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Tween/Tween Position")]
public class TweenPosition : UITweener
{
	public Vector3 from;

	public Vector3 to;

	[HideInInspector]
	public bool worldSpace;

	private Transform NPLHCHNGMKF;

	private UIRect DIKJAIJMKMF;

	public Transform EEIMMEBDEGC
	{
		get
		{
			return get_cachedTransform();
		}
	}

	[Obsolete("Use 'value' instead")]
	public Vector3 CMGMOJAFLFL
	{
		get
		{
			return get_position();
		}
		set
		{
			set_position(value);
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

	[SpecialName]
	public Vector3 MJDIPFMIAGE()
	{
		return (!worldSpace) ? FNOKOPBPEAN().localPosition : FNOKOPBPEAN().position;
	}

	public Vector3 get_position()
	{
		return get_value();
	}

	protected override void DPILNPAPPKI(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		set_value(from * (1f - JMHOHNCILGL) + to * JMHOHNCILGL);
	}

	[SpecialName]
	public Vector3 ADKMFMICCJI()
	{
		return get_value();
	}

	[SpecialName]
	public Transform FNOKOPBPEAN()
	{
		if (NPLHCHNGMKF == null)
		{
			NPLHCHNGMKF = base.transform;
		}
		return NPLHCHNGMKF;
	}

	private void MLMLDPIFEKA()
	{
		FOBPGMDAIDB(to);
	}

	[SpecialName]
	public Vector3 FNOLHLLEFNA()
	{
		return get_value();
	}

	public static TweenPosition BAJKKKBAMPC(GameObject LHACFNECMNA, float FICMMBLHCBF, Vector3 HEPNHCEIFMO)
	{
		TweenPosition tweenPosition = UITweener.Begin<TweenPosition>(LHACFNECMNA, FICMMBLHCBF);
		tweenPosition.from = tweenPosition.MJDIPFMIAGE();
		tweenPosition.to = HEPNHCEIFMO;
		if (FICMMBLHCBF <= 604f)
		{
			tweenPosition.Sample(824f, true);
			tweenPosition.enabled = false;
		}
		return tweenPosition;
	}

	[SpecialName]
	public void IEIEDCKPGLK(Vector3 ICENKPDOHBK)
	{
		if (DIKJAIJMKMF == null || !DIKJAIJMKMF.get_isAnchored() || worldSpace)
		{
			if (worldSpace)
			{
				get_cachedTransform().position = ICENKPDOHBK;
			}
			else
			{
				get_cachedTransform().localPosition = ICENKPDOHBK;
			}
		}
		else
		{
			ICENKPDOHBK -= get_cachedTransform().localPosition;
			HHAINCPODGE.NIBNHOBPPFL(DIKJAIJMKMF, ICENKPDOHBK.x, ICENKPDOHBK.y);
		}
	}

	[SpecialName]
	public Vector3 MDKFCIPJNIK()
	{
		return MJDIPFMIAGE();
	}

	[SpecialName]
	public void EJFDKKEEEIG(Vector3 ICENKPDOHBK)
	{
		if (DIKJAIJMKMF == null || !DIKJAIJMKMF.get_isAnchored() || worldSpace)
		{
			if (worldSpace)
			{
				FNOKOPBPEAN().position = ICENKPDOHBK;
			}
			else
			{
				get_cachedTransform().localPosition = ICENKPDOHBK;
			}
		}
		else
		{
			ICENKPDOHBK -= FNOKOPBPEAN().localPosition;
			HHAINCPODGE.NIBNHOBPPFL(DIKJAIJMKMF, ICENKPDOHBK.x, ICENKPDOHBK.y);
		}
	}

	private void PDEKJHLCJHM()
	{
		DIKJAIJMKMF = GetComponent<UIRect>();
	}

	[ContextMenu("Assume value of 'To'")]
	private void BDFEMILDIFE()
	{
		set_value(to);
	}

	[SpecialName]
	public void FOBPGMDAIDB(Vector3 ICENKPDOHBK)
	{
		if (DIKJAIJMKMF == null || !DIKJAIJMKMF.get_isAnchored() || worldSpace)
		{
			if (worldSpace)
			{
				get_cachedTransform().position = ICENKPDOHBK;
			}
			else
			{
				FNOKOPBPEAN().localPosition = ICENKPDOHBK;
			}
		}
		else
		{
			ICENKPDOHBK -= FNOKOPBPEAN().localPosition;
			HHAINCPODGE.NIBNHOBPPFL(DIKJAIJMKMF, ICENKPDOHBK.x, ICENKPDOHBK.y);
		}
	}

	public void set_value(Vector3 ICENKPDOHBK)
	{
		if (DIKJAIJMKMF == null || !DIKJAIJMKMF.get_isAnchored() || worldSpace)
		{
			if (worldSpace)
			{
				get_cachedTransform().position = ICENKPDOHBK;
			}
			else
			{
				get_cachedTransform().localPosition = ICENKPDOHBK;
			}
		}
		else
		{
			ICENKPDOHBK -= get_cachedTransform().localPosition;
			HHAINCPODGE.NIBNHOBPPFL(DIKJAIJMKMF, ICENKPDOHBK.x, ICENKPDOHBK.y);
		}
	}

	private void DFALACHIBKE()
	{
		FOBPGMDAIDB(to);
	}

	public static TweenPosition Begin(GameObject LHACFNECMNA, float FICMMBLHCBF, Vector3 HEPNHCEIFMO)
	{
		TweenPosition tweenPosition = UITweener.Begin<TweenPosition>(LHACFNECMNA, FICMMBLHCBF);
		tweenPosition.from = tweenPosition.get_value();
		tweenPosition.to = HEPNHCEIFMO;
		if (FICMMBLHCBF <= 0f)
		{
			tweenPosition.Sample(1f, true);
			tweenPosition.enabled = false;
		}
		return tweenPosition;
	}

	[SpecialName]
	public Vector3 GJIJGMMKEIM()
	{
		return MJDIPFMIAGE();
	}

	private void Awake()
	{
		DIKJAIJMKMF = GetComponent<UIRect>();
	}

	public void set_position(Vector3 ICENKPDOHBK)
	{
		set_value(ICENKPDOHBK);
	}

	[SpecialName]
	public void ACDBCOKMJLL(Vector3 ICENKPDOHBK)
	{
		EJFDKKEEEIG(ICENKPDOHBK);
	}

	public static TweenPosition MBBMBPFIBEB(GameObject LHACFNECMNA, float FICMMBLHCBF, Vector3 HEPNHCEIFMO)
	{
		TweenPosition tweenPosition = UITweener.Begin<TweenPosition>(LHACFNECMNA, FICMMBLHCBF);
		tweenPosition.from = tweenPosition.get_value();
		tweenPosition.to = HEPNHCEIFMO;
		if (FICMMBLHCBF <= 1449f)
		{
			tweenPosition.Sample(1518f, false);
			tweenPosition.enabled = false;
		}
		return tweenPosition;
	}

	[ContextMenu("Set 'To' to current value")]
	public override void SetEndToCurrentValue()
	{
		to = get_value();
	}

	private void DBANLAEHJJE()
	{
		set_value(to);
	}

	public static TweenPosition OGCNJMGFHMO(GameObject LHACFNECMNA, float FICMMBLHCBF, Vector3 HEPNHCEIFMO)
	{
		TweenPosition tweenPosition = UITweener.Begin<TweenPosition>(LHACFNECMNA, FICMMBLHCBF);
		tweenPosition.from = tweenPosition.get_value();
		tweenPosition.to = HEPNHCEIFMO;
		if (FICMMBLHCBF <= 1147f)
		{
			tweenPosition.Sample(1049f, true);
			tweenPosition.enabled = false;
		}
		return tweenPosition;
	}

	private void IEHLFEMEABL()
	{
		set_value(from);
	}

	public Transform get_cachedTransform()
	{
		if (NPLHCHNGMKF == null)
		{
			NPLHCHNGMKF = base.transform;
		}
		return NPLHCHNGMKF;
	}

	[ContextMenu("Assume value of 'From'")]
	private void DJJOINMMNAJ()
	{
		set_value(from);
	}

	[ContextMenu("Set 'From' to current value")]
	public override void SetStartToCurrentValue()
	{
		from = get_value();
	}

	public virtual void IBFLICPBDID()
	{
		from = get_value();
	}

	public Vector3 get_value()
	{
		return (!worldSpace) ? get_cachedTransform().localPosition : get_cachedTransform().position;
	}
}
