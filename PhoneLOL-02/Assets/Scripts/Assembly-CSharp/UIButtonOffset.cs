using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Button Offset")]
public class UIButtonOffset : MonoBehaviour
{
	public Transform tweenTarget;

	public Vector3 hover = Vector3.zero;

	public Vector3 pressed = new Vector3(2f, -2f);

	public float duration = 0.2f;

	private Vector3 MJCNMNOABIK;

	private bool BAMIBNMGNBO;

	private void AFIMPCHAJPB(bool MLIBCICOOAI)
	{
		if (base.enabled)
		{
			if (!BAMIBNMGNBO)
			{
				IMBGDEFOFEM();
			}
			TweenPosition.BAJKKKBAMPC(tweenTarget.gameObject, duration, (!MLIBCICOOAI) ? MJCNMNOABIK : (MJCNMNOABIK + hover)).method = UITweener.MAIJGNJIIIC.EaseInOut;
		}
	}

	private void LBFBKPCCHIB(bool MLIBCICOOAI)
	{
		if (base.enabled)
		{
			if (!BAMIBNMGNBO)
			{
				IMBGDEFOFEM();
			}
			TweenPosition.OGCNJMGFHMO(tweenTarget.gameObject, duration, (!MLIBCICOOAI) ? MJCNMNOABIK : (MJCNMNOABIK + hover)).method = UITweener.MAIJGNJIIIC.BounceIn;
		}
	}

	private void KDMFFEPHLCB(bool IOGFFPOIBBB)
	{
		if (base.enabled && (!IOGFFPOIBBB || UICamera.currentScheme == (UICamera.DOCFHOGBBJH)7))
		{
			LBFBKPCCHIB(IOGFFPOIBBB);
		}
	}

	private void ICACNPOPMIL()
	{
		if (BAMIBNMGNBO)
		{
			LBFBKPCCHIB(UICamera.DMOOCIJDAIK(base.gameObject));
		}
	}

	private void PDEMNFLEKEA()
	{
		if (BAMIBNMGNBO)
		{
			AFIMPCHAJPB(UICamera.DMOOCIJDAIK(base.gameObject));
		}
	}

	private void OnDisable()
	{
		if (BAMIBNMGNBO && tweenTarget != null)
		{
			TweenPosition component = tweenTarget.GetComponent<TweenPosition>();
			if (component != null)
			{
				component.set_value(MJCNMNOABIK);
				component.enabled = false;
			}
		}
	}

	private void DGHCKMGOOGK(bool MLIBCICOOAI)
	{
		if (base.enabled)
		{
			if (!BAMIBNMGNBO)
			{
				Start();
			}
			TweenPosition.Begin(tweenTarget.gameObject, duration, (!MLIBCICOOAI) ? MJCNMNOABIK : (MJCNMNOABIK + hover)).method = UITweener.MAIJGNJIIIC.EaseInOut;
		}
	}

	private void JADBJGCMIMF(bool IOGFFPOIBBB)
	{
		if (base.enabled && (!IOGFFPOIBBB || UICamera.currentScheme == UICamera.DOCFHOGBBJH.Controller))
		{
			DGHCKMGOOGK(IOGFFPOIBBB);
		}
	}

	private void IMBGDEFOFEM()
	{
		if (!BAMIBNMGNBO)
		{
			BAMIBNMGNBO = true;
			if (tweenTarget == null)
			{
				tweenTarget = base.transform;
			}
			MJCNMNOABIK = tweenTarget.localPosition;
		}
	}

	private void NDNBPKKAKDJ(bool JPNFGIEDOMM)
	{
		if (base.enabled)
		{
			if (!BAMIBNMGNBO)
			{
				Start();
			}
			TweenPosition.Begin(tweenTarget.gameObject, duration, JPNFGIEDOMM ? (MJCNMNOABIK + pressed) : ((!UICamera.IsHighlighted(base.gameObject)) ? MJCNMNOABIK : (MJCNMNOABIK + hover))).method = UITweener.MAIJGNJIIIC.EaseInOut;
		}
	}

	private void ALBCLEIOIPG(bool JPNFGIEDOMM)
	{
		if (base.enabled)
		{
			if (!BAMIBNMGNBO)
			{
				Start();
			}
			TweenPosition.Begin(tweenTarget.gameObject, duration, JPNFGIEDOMM ? (MJCNMNOABIK + pressed) : ((!UICamera.DMOOCIJDAIK(base.gameObject)) ? MJCNMNOABIK : (MJCNMNOABIK + hover))).method = UITweener.MAIJGNJIIIC.EaseIn;
		}
	}

	private void Start()
	{
		if (!BAMIBNMGNBO)
		{
			BAMIBNMGNBO = true;
			if (tweenTarget == null)
			{
				tweenTarget = base.transform;
			}
			MJCNMNOABIK = tweenTarget.localPosition;
		}
	}

	private void OnEnable()
	{
		if (BAMIBNMGNBO)
		{
			DGHCKMGOOGK(UICamera.IsHighlighted(base.gameObject));
		}
	}

	private void HLDAKPBGKNI(bool IOGFFPOIBBB)
	{
		if (base.enabled && (!IOGFFPOIBBB || UICamera.currentScheme == UICamera.DOCFHOGBBJH.Controller))
		{
			AFIMPCHAJPB(IOGFFPOIBBB);
		}
	}

	private void MJIFCDGPEII(bool IOGFFPOIBBB)
	{
		if (base.enabled && (!IOGFFPOIBBB || UICamera.currentScheme == (UICamera.DOCFHOGBBJH)5))
		{
			DGHCKMGOOGK(IOGFFPOIBBB);
		}
	}

	private void ADLKMGPNJPA()
	{
		if (BAMIBNMGNBO)
		{
			DGHCKMGOOGK(UICamera.IsHighlighted(base.gameObject));
		}
	}
}
