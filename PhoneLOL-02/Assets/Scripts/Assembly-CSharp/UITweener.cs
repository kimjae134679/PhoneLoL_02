using System;
using System.Collections.Generic;
using AnimationOrTween;
using UnityEngine;

public abstract class UITweener : MonoBehaviour
{
	public enum MAIJGNJIIIC
	{
		Linear = 0,
		EaseIn = 1,
		EaseOut = 2,
		EaseInOut = 3,
		BounceIn = 4,
		BounceOut = 5
	}

	public enum OLMJPELFKPD
	{
		Once = 0,
		Loop = 1,
		PingPong = 2
	}

	public static UITweener current;

	[HideInInspector]
	public MAIJGNJIIIC method;

	[HideInInspector]
	public OLMJPELFKPD style;

	[HideInInspector]
	public AnimationCurve animationCurve = new AnimationCurve(new Keyframe(0f, 0f, 0f, 1f), new Keyframe(1f, 1f, 1f, 0f));

	[HideInInspector]
	public bool ignoreTimeScale = true;

	[HideInInspector]
	public float delay;

	[HideInInspector]
	public float duration = 1f;

	[HideInInspector]
	public bool steeperCurves;

	[HideInInspector]
	public int tweenGroup;

	[HideInInspector]
	public List<EventDelegate> onFinished = new List<EventDelegate>();

	[HideInInspector]
	public GameObject eventReceiver;

	[HideInInspector]
	public string callWhenFinished;

	private bool BAMIBNMGNBO;

	private float KKLEHNAFNJG;

	private float GINMAGELLIL;

	private float AAEOIFAKFFL = 1000f;

	private float HHNDNHAAFJL;

	private List<EventDelegate> AJEGMEKIBDD;

	public float BJCOBOLDCDG
	{
		get
		{
			return get_amountPerDelta();
		}
	}

	public float NIPJEMIIPOJ
	{
		get
		{
			return get_tweenFactor();
		}
		set
		{
			set_tweenFactor(value);
		}
	}

	public EHIFBHANFAJ IJMNFOGNFAC
	{
		get
		{
			return get_direction();
		}
	}

	public float get_amountPerDelta()
	{
		if (GINMAGELLIL != duration)
		{
			GINMAGELLIL = duration;
			AAEOIFAKFFL = Mathf.Abs((!(duration > 0f)) ? 1000f : (1f / duration));
		}
		return AAEOIFAKFFL;
	}

	public float get_tweenFactor()
	{
		return HHNDNHAAFJL;
	}

	public void set_tweenFactor(float ICENKPDOHBK)
	{
		HHNDNHAAFJL = Mathf.Clamp01(ICENKPDOHBK);
	}

	public EHIFBHANFAJ get_direction()
	{
		return (!(AAEOIFAKFFL < 0f)) ? EHIFBHANFAJ.Forward : EHIFBHANFAJ.Reverse;
	}

	private void Reset()
	{
		if (!BAMIBNMGNBO)
		{
			SetStartToCurrentValue();
			SetEndToCurrentValue();
		}
	}

	protected virtual void Start()
	{
		Update();
	}

	private void Update()
	{
		float num = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.get_deltaTime());
		float num2 = ((!ignoreTimeScale) ? Time.time : RealTime.get_time());
		if (!BAMIBNMGNBO)
		{
			BAMIBNMGNBO = true;
			KKLEHNAFNJG = num2 + delay;
		}
		if (num2 < KKLEHNAFNJG)
		{
			return;
		}
		HHNDNHAAFJL += get_amountPerDelta() * num;
		if (style == OLMJPELFKPD.Loop)
		{
			if (HHNDNHAAFJL > 1f)
			{
				HHNDNHAAFJL -= Mathf.Floor(HHNDNHAAFJL);
			}
		}
		else if (style == OLMJPELFKPD.PingPong)
		{
			if (HHNDNHAAFJL > 1f)
			{
				HHNDNHAAFJL = 1f - (HHNDNHAAFJL - Mathf.Floor(HHNDNHAAFJL));
				AAEOIFAKFFL = 0f - AAEOIFAKFFL;
			}
			else if (HHNDNHAAFJL < 0f)
			{
				HHNDNHAAFJL = 0f - HHNDNHAAFJL;
				HHNDNHAAFJL -= Mathf.Floor(HHNDNHAAFJL);
				AAEOIFAKFFL = 0f - AAEOIFAKFFL;
			}
		}
		if (style == OLMJPELFKPD.Once && (duration == 0f || HHNDNHAAFJL > 1f || HHNDNHAAFJL < 0f))
		{
			HHNDNHAAFJL = Mathf.Clamp01(HHNDNHAAFJL);
			Sample(HHNDNHAAFJL, true);
			if (duration == 0f || (HHNDNHAAFJL == 1f && AAEOIFAKFFL > 0f) || (HHNDNHAAFJL == 0f && AAEOIFAKFFL < 0f))
			{
				base.enabled = false;
			}
			if (!(current == null))
			{
				return;
			}
			current = this;
			if (onFinished != null)
			{
				AJEGMEKIBDD = onFinished;
				onFinished = new List<EventDelegate>();
				EventDelegate.MKPMEAMPDLJ(AJEGMEKIBDD);
				for (int i = 0; i < AJEGMEKIBDD.Count; i++)
				{
					EventDelegate eventDelegate = AJEGMEKIBDD[i];
					if (eventDelegate != null)
					{
						EventDelegate.GBFCKODJEGE(onFinished, eventDelegate, eventDelegate.oneShot);
					}
				}
				AJEGMEKIBDD = null;
			}
			if (eventReceiver != null && !string.IsNullOrEmpty(callWhenFinished))
			{
				eventReceiver.SendMessage(callWhenFinished, this, SendMessageOptions.DontRequireReceiver);
			}
			current = null;
		}
		else
		{
			Sample(HHNDNHAAFJL, false);
		}
	}

	public void SetOnFinished(EventDelegate.CIDNDMIFCDP JAANBCBMGMC)
	{
		EventDelegate.LIJBCDKPJPP(onFinished, JAANBCBMGMC);
	}

	public void SetOnFinished(EventDelegate JAANBCBMGMC)
	{
		EventDelegate.LIJBCDKPJPP(onFinished, JAANBCBMGMC);
	}

	public void AddOnFinished(EventDelegate.CIDNDMIFCDP JAANBCBMGMC)
	{
		EventDelegate.GBFCKODJEGE(onFinished, JAANBCBMGMC);
	}

	public void AddOnFinished(EventDelegate JAANBCBMGMC)
	{
		EventDelegate.GBFCKODJEGE(onFinished, JAANBCBMGMC);
	}

	public void RemoveOnFinished(EventDelegate JAANBCBMGMC)
	{
		if (onFinished != null)
		{
			onFinished.Remove(JAANBCBMGMC);
		}
		if (AJEGMEKIBDD != null)
		{
			AJEGMEKIBDD.Remove(JAANBCBMGMC);
		}
	}

	private void OnDisable()
	{
		BAMIBNMGNBO = false;
	}

	public void Sample(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		float num = Mathf.Clamp01(JMHOHNCILGL);
		if (method == MAIJGNJIIIC.EaseIn)
		{
			num = 1f - Mathf.Sin((float)Math.PI / 2f * (1f - num));
			if (steeperCurves)
			{
				num *= num;
			}
		}
		else if (method == MAIJGNJIIIC.EaseOut)
		{
			num = Mathf.Sin((float)Math.PI / 2f * num);
			if (steeperCurves)
			{
				num = 1f - num;
				num = 1f - num * num;
			}
		}
		else if (method == MAIJGNJIIIC.EaseInOut)
		{
			num -= Mathf.Sin(num * ((float)Math.PI * 2f)) / ((float)Math.PI * 2f);
			if (steeperCurves)
			{
				num = num * 2f - 1f;
				float num2 = Mathf.Sign(num);
				num = 1f - Mathf.Abs(num);
				num = 1f - num * num;
				num = num2 * num * 0.5f + 0.5f;
			}
		}
		else if (method == MAIJGNJIIIC.BounceIn)
		{
			num = PAOPBHGENHC(num);
		}
		else if (method == MAIJGNJIIIC.BounceOut)
		{
			num = 1f - PAOPBHGENHC(1f - num);
		}
		DPILNPAPPKI((animationCurve == null) ? num : animationCurve.Evaluate(num), HOFIHPAKPME);
	}

	private float PAOPBHGENHC(float JKJGJMOEHDO)
	{
		JKJGJMOEHDO = ((JKJGJMOEHDO < 0.363636f) ? (7.5685f * JKJGJMOEHDO * JKJGJMOEHDO) : ((JKJGJMOEHDO < 0.727272f) ? (7.5625f * (JKJGJMOEHDO -= 0.545454f) * JKJGJMOEHDO + 0.75f) : ((!(JKJGJMOEHDO < 0.90909f)) ? (7.5625f * (JKJGJMOEHDO -= 0.9545454f) * JKJGJMOEHDO + 63f / 64f) : (7.5625f * (JKJGJMOEHDO -= 0.818181f) * JKJGJMOEHDO + 0.9375f))));
		return JKJGJMOEHDO;
	}

	[Obsolete("Use PlayForward() instead")]
	public void Play()
	{
		Play(true);
	}

	public void PlayForward()
	{
		Play(true);
	}

	public void PlayReverse()
	{
		Play(false);
	}

	public void Play(bool CPFNGALHNGL)
	{
		AAEOIFAKFFL = Mathf.Abs(get_amountPerDelta());
		if (!CPFNGALHNGL)
		{
			AAEOIFAKFFL = 0f - AAEOIFAKFFL;
		}
		base.enabled = true;
		Update();
	}

	public void ResetToBeginning()
	{
		BAMIBNMGNBO = false;
		HHNDNHAAFJL = ((!(AAEOIFAKFFL < 0f)) ? 0f : 1f);
		Sample(HHNDNHAAFJL, false);
	}

	public void Toggle()
	{
		if (HHNDNHAAFJL > 0f)
		{
			AAEOIFAKFFL = 0f - get_amountPerDelta();
		}
		else
		{
			AAEOIFAKFFL = Mathf.Abs(get_amountPerDelta());
		}
		base.enabled = true;
	}

	protected abstract void DPILNPAPPKI(float JMHOHNCILGL, bool HOFIHPAKPME);

	public static T Begin<T>(GameObject LHACFNECMNA, float FICMMBLHCBF) where T : UITweener
	{
		T val = LHACFNECMNA.GetComponent<T>();
		if (val != null && val.tweenGroup != 0)
		{
			val = (T)null;
			T[] components = LHACFNECMNA.GetComponents<T>();
			int i = 0;
			for (int num = components.Length; i < num; i++)
			{
				val = components[i];
				if (val != null && val.tweenGroup == 0)
				{
					break;
				}
				val = (T)null;
			}
		}
		if (val == null)
		{
			val = LHACFNECMNA.AddComponent<T>();
		}
		val.BAMIBNMGNBO = false;
		val.duration = FICMMBLHCBF;
		val.HHNDNHAAFJL = 0f;
		val.AAEOIFAKFFL = Mathf.Abs(val.AAEOIFAKFFL);
		val.style = OLMJPELFKPD.Once;
		val.animationCurve = new AnimationCurve(new Keyframe(0f, 0f, 0f, 1f), new Keyframe(1f, 1f, 1f, 0f));
		val.eventReceiver = null;
		val.callWhenFinished = null;
		val.enabled = true;
		if (FICMMBLHCBF <= 0f)
		{
			val.Sample(1f, true);
			val.enabled = false;
		}
		return val;
	}

	public virtual void SetStartToCurrentValue()
	{
	}

	public virtual void SetEndToCurrentValue()
	{
	}
}
