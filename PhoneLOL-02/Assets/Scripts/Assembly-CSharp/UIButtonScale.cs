using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Button Scale")]
public class UIButtonScale : MonoBehaviour
{
	public Transform tweenTarget;

	public Vector3 hover = new Vector3(1.05f, 1.05f, 1.05f);

	public Vector3 pressed = new Vector3(0.95f, 0.95f, 0.95f);

	public float duration = 0.05f;

	private Vector3 MFIKMAAPKHH;

	private bool BAMIBNMGNBO;

	private void MCGBEHNCGEP()
	{
		if (BAMIBNMGNBO && tweenTarget != null)
		{
			TweenScale component = tweenTarget.GetComponent<TweenScale>();
			if (component != null)
			{
				component.set_value(MFIKMAAPKHH);
				component.enabled = false;
			}
		}
	}

	private void BAHAPLJBLEH(bool MLIBCICOOAI)
	{
		if (base.enabled)
		{
			if (!BAMIBNMGNBO)
			{
				Start();
			}
			TweenScale.OJMCICGBFJK(tweenTarget.gameObject, duration, (!MLIBCICOOAI) ? MFIKMAAPKHH : Vector3.Scale(MFIKMAAPKHH, hover)).method = UITweener.MAIJGNJIIIC.BounceIn;
		}
	}

	private void OnEnable()
	{
		if (BAMIBNMGNBO)
		{
			DGHCKMGOOGK(UICamera.IsHighlighted(base.gameObject));
		}
	}

	private void PBDCBOEHJLH(bool MLIBCICOOAI)
	{
		if (base.enabled)
		{
			if (!BAMIBNMGNBO)
			{
				Start();
			}
			TweenScale.OJMCICGBFJK(tweenTarget.gameObject, duration, (!MLIBCICOOAI) ? MFIKMAAPKHH : Vector3.Scale(MFIKMAAPKHH, hover)).method = UITweener.MAIJGNJIIIC.BounceIn;
		}
	}

	private void NMANMMOMHHD()
	{
		if (!BAMIBNMGNBO)
		{
			BAMIBNMGNBO = true;
			if (tweenTarget == null)
			{
				tweenTarget = base.transform;
			}
			MFIKMAAPKHH = tweenTarget.localScale;
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
			TweenScale.Begin(tweenTarget.gameObject, duration, (!MLIBCICOOAI) ? MFIKMAAPKHH : Vector3.Scale(MFIKMAAPKHH, hover)).method = UITweener.MAIJGNJIIIC.EaseInOut;
		}
	}

	private void FFHOHJFLPFD(bool JPNFGIEDOMM)
	{
		if (base.enabled)
		{
			if (!BAMIBNMGNBO)
			{
				Start();
			}
			TweenScale.GCAMBCOFKIH(tweenTarget.gameObject, duration, JPNFGIEDOMM ? Vector3.Scale(MFIKMAAPKHH, pressed) : ((!UICamera.DMOOCIJDAIK(base.gameObject)) ? MFIKMAAPKHH : Vector3.Scale(MFIKMAAPKHH, hover))).method = (UITweener.MAIJGNJIIIC)8;
		}
	}

	private void DBLCOCKIFPE()
	{
		if (BAMIBNMGNBO && tweenTarget != null)
		{
			TweenScale component = tweenTarget.GetComponent<TweenScale>();
			if (component != null)
			{
				component.set_value(MFIKMAAPKHH);
				component.enabled = true;
			}
		}
	}

	private void AFIMPCHAJPB(bool MLIBCICOOAI)
	{
		if (base.enabled)
		{
			if (!BAMIBNMGNBO)
			{
				NMANMMOMHHD();
			}
			TweenScale.GCAMBCOFKIH(tweenTarget.gameObject, duration, (!MLIBCICOOAI) ? MFIKMAAPKHH : Vector3.Scale(MFIKMAAPKHH, hover)).method = UITweener.MAIJGNJIIIC.EaseOut;
		}
	}

	private void IBAKNHPONCI(bool JPNFGIEDOMM)
	{
		if (base.enabled)
		{
			if (!BAMIBNMGNBO)
			{
				Start();
			}
			TweenScale.GCAMBCOFKIH(tweenTarget.gameObject, duration, JPNFGIEDOMM ? Vector3.Scale(MFIKMAAPKHH, pressed) : ((!UICamera.IsHighlighted(base.gameObject)) ? MFIKMAAPKHH : Vector3.Scale(MFIKMAAPKHH, hover))).method = (UITweener.MAIJGNJIIIC)6;
		}
	}

	private void BKEKAJHABGK()
	{
		if (BAMIBNMGNBO && tweenTarget != null)
		{
			TweenScale component = tweenTarget.GetComponent<TweenScale>();
			if (component != null)
			{
				component.set_value(MFIKMAAPKHH);
				component.enabled = true;
			}
		}
	}

	private void OJMBNBMBAMK(bool MLIBCICOOAI)
	{
		if (base.enabled)
		{
			if (!BAMIBNMGNBO)
			{
				Start();
			}
			TweenScale.LDMDFDNHGCF(tweenTarget.gameObject, duration, (!MLIBCICOOAI) ? MFIKMAAPKHH : Vector3.Scale(MFIKMAAPKHH, hover)).method = UITweener.MAIJGNJIIIC.EaseIn;
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
			MFIKMAAPKHH = tweenTarget.localScale;
		}
	}

	private void OMCPFAHFHHA(bool JPNFGIEDOMM)
	{
		if (base.enabled)
		{
			if (!BAMIBNMGNBO)
			{
				FOGNMJLPHAI();
			}
			TweenScale.AIADFIFJNOF(tweenTarget.gameObject, duration, JPNFGIEDOMM ? Vector3.Scale(MFIKMAAPKHH, pressed) : ((!UICamera.DMOOCIJDAIK(base.gameObject)) ? MFIKMAAPKHH : Vector3.Scale(MFIKMAAPKHH, hover))).method = UITweener.MAIJGNJIIIC.EaseInOut;
		}
	}

	private void JADBJGCMIMF(bool IOGFFPOIBBB)
	{
		if (base.enabled && (!IOGFFPOIBBB || UICamera.currentScheme == UICamera.DOCFHOGBBJH.Controller))
		{
			DGHCKMGOOGK(IOGFFPOIBBB);
		}
	}

	private void IBBJMMFDGAL()
	{
		if (!BAMIBNMGNBO)
		{
			BAMIBNMGNBO = true;
			if (tweenTarget == null)
			{
				tweenTarget = base.transform;
			}
			MFIKMAAPKHH = tweenTarget.localScale;
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
			TweenScale.Begin(tweenTarget.gameObject, duration, JPNFGIEDOMM ? Vector3.Scale(MFIKMAAPKHH, pressed) : ((!UICamera.IsHighlighted(base.gameObject)) ? MFIKMAAPKHH : Vector3.Scale(MFIKMAAPKHH, hover))).method = UITweener.MAIJGNJIIIC.EaseInOut;
		}
	}

	private void DDEGDABBPDF()
	{
		if (BAMIBNMGNBO && tweenTarget != null)
		{
			TweenScale component = tweenTarget.GetComponent<TweenScale>();
			if (component != null)
			{
				component.set_value(MFIKMAAPKHH);
				component.enabled = false;
			}
		}
	}

	private void FOGNMJLPHAI()
	{
		if (!BAMIBNMGNBO)
		{
			BAMIBNMGNBO = true;
			if (tweenTarget == null)
			{
				tweenTarget = base.transform;
			}
			MFIKMAAPKHH = tweenTarget.localScale;
		}
	}

	private void OnDisable()
	{
		if (BAMIBNMGNBO && tweenTarget != null)
		{
			TweenScale component = tweenTarget.GetComponent<TweenScale>();
			if (component != null)
			{
				component.set_value(MFIKMAAPKHH);
				component.enabled = false;
			}
		}
	}
}
