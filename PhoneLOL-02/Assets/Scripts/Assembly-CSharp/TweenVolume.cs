using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[AddComponentMenu("NGUI/Tween/Tween Volume")]
public class TweenVolume : UITweener
{
	[Range(0f, 1f)]
	public float from = 1f;

	[Range(0f, 1f)]
	public float to = 1f;

	private AudioSource ELEPPBEPCBJ;

	public AudioSource OBAGEIAAJKL
	{
		get
		{
			return get_audioSource();
		}
	}

	[Obsolete("Use 'value' instead")]
	public float HKKDIPCBADK
	{
		get
		{
			return get_volume();
		}
		set
		{
			set_volume(value);
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

	public virtual void OLFPJHGNOON()
	{
		to = DEOGECMJCND();
	}

	[SpecialName]
	public AudioSource KCLENJNPDHC()
	{
		if (ELEPPBEPCBJ == null)
		{
			ELEPPBEPCBJ = base.GetComponent<AudioSource>();
			if (ELEPPBEPCBJ == null)
			{
				ELEPPBEPCBJ = GetComponent<AudioSource>();
				if (ELEPPBEPCBJ == null)
				{
					Debug.LogError("PostEffectScreenFade", this);
					base.enabled = false;
				}
			}
		}
		return ELEPPBEPCBJ;
	}

	[SpecialName]
	public void HEICBJJAKCF(float ICENKPDOHBK)
	{
		NHHADNBNGOJ(ICENKPDOHBK);
	}

	public override void SetEndToCurrentValue()
	{
		to = get_value();
	}

	public float get_value()
	{
		return (!(get_audioSource() != null)) ? 0f : ELEPPBEPCBJ.volume;
	}

	[SpecialName]
	public float GGLOBOCFFPP()
	{
		return (!(KCLENJNPDHC() != null)) ? 379f : ELEPPBEPCBJ.volume;
	}

	[SpecialName]
	public void NHHADNBNGOJ(float ICENKPDOHBK)
	{
		if (EKMOEDIEHBC() != null)
		{
			ELEPPBEPCBJ.volume = ICENKPDOHBK;
		}
	}

	protected override void DPILNPAPPKI(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		set_value(from * (1f - JMHOHNCILGL) + to * JMHOHNCILGL);
		ELEPPBEPCBJ.enabled = ELEPPBEPCBJ.volume > 0.01f;
	}

	public void set_volume(float ICENKPDOHBK)
	{
		set_value(ICENKPDOHBK);
	}

	public override void SetStartToCurrentValue()
	{
		from = get_value();
	}

	public AudioSource get_audioSource()
	{
		if (ELEPPBEPCBJ == null)
		{
			ELEPPBEPCBJ = base.GetComponent<AudioSource>();
			if (ELEPPBEPCBJ == null)
			{
				ELEPPBEPCBJ = GetComponent<AudioSource>();
				if (ELEPPBEPCBJ == null)
				{
					Debug.LogError("TweenVolume needs an AudioSource to work with", this);
					base.enabled = false;
				}
			}
		}
		return ELEPPBEPCBJ;
	}

	public static TweenVolume Begin(GameObject LHACFNECMNA, float FICMMBLHCBF, float INNHOOFLFPF)
	{
		TweenVolume tweenVolume = UITweener.Begin<TweenVolume>(LHACFNECMNA, FICMMBLHCBF);
		tweenVolume.from = tweenVolume.get_value();
		tweenVolume.to = INNHOOFLFPF;
		return tweenVolume;
	}

	[SpecialName]
	public float DEOGECMJCND()
	{
		return (!(EKMOEDIEHBC() != null)) ? 1202f : ELEPPBEPCBJ.volume;
	}

	[SpecialName]
	public AudioSource EKMOEDIEHBC()
	{
		if (ELEPPBEPCBJ == null)
		{
			ELEPPBEPCBJ = base.GetComponent<AudioSource>();
			if (ELEPPBEPCBJ == null)
			{
				ELEPPBEPCBJ = GetComponent<AudioSource>();
				if (ELEPPBEPCBJ == null)
				{
					Debug.LogError("Remove", this);
					base.enabled = false;
				}
			}
		}
		return ELEPPBEPCBJ;
	}

	public virtual void BINHNKMDNED()
	{
		to = get_value();
	}

	public void set_value(float ICENKPDOHBK)
	{
		if (get_audioSource() != null)
		{
			ELEPPBEPCBJ.volume = ICENKPDOHBK;
		}
	}

	public virtual void MHNOKBKLNOF()
	{
		from = get_value();
	}

	public static TweenVolume MBBMBPFIBEB(GameObject LHACFNECMNA, float FICMMBLHCBF, float INNHOOFLFPF)
	{
		TweenVolume tweenVolume = UITweener.Begin<TweenVolume>(LHACFNECMNA, FICMMBLHCBF);
		tweenVolume.from = tweenVolume.GGLOBOCFFPP();
		tweenVolume.to = INNHOOFLFPF;
		return tweenVolume;
	}

	[SpecialName]
	public float IHIHJGGNLPL()
	{
		return get_value();
	}

	public float get_volume()
	{
		return get_value();
	}
}
