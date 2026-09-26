using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Button Rotation")]
public class UIButtonRotation : MonoBehaviour
{
	public Transform tweenTarget;

	public Vector3 hover = Vector3.zero;

	public Vector3 pressed = Vector3.zero;

	public float duration = 0.2f;

	private Quaternion IPFGPLLEKHF;

	private bool BAMIBNMGNBO;

	private void LKJEHBBCCDH()
	{
		if (BAMIBNMGNBO && tweenTarget != null)
		{
			TweenRotation component = tweenTarget.GetComponent<TweenRotation>();
			if (component != null)
			{
				component.set_value(IPFGPLLEKHF);
				component.enabled = false;
			}
		}
	}

	private void EBHEKALFNGF()
	{
		if (BAMIBNMGNBO)
		{
			KMPOCJKOAHJ(UICamera.DMOOCIJDAIK(base.gameObject));
		}
	}

	private void FOGNMJLPHAI()
	{
		if (!BAMIBNMGNBO)
		{
			BAMIBNMGNBO = false;
			if (tweenTarget == null)
			{
				tweenTarget = base.transform;
			}
			IPFGPLLEKHF = tweenTarget.localRotation;
		}
	}

	private void FGECOIGPMOK(bool JPNFGIEDOMM)
	{
		if (base.enabled)
		{
			if (!BAMIBNMGNBO)
			{
				DMPIIJNBDID();
			}
			TweenRotation.Begin(tweenTarget.gameObject, duration, JPNFGIEDOMM ? (IPFGPLLEKHF * Quaternion.Euler(pressed)) : ((!UICamera.DMOOCIJDAIK(base.gameObject)) ? IPFGPLLEKHF : (IPFGPLLEKHF * Quaternion.Euler(hover)))).method = UITweener.MAIJGNJIIIC.EaseOut;
		}
	}

	private void KAAKBCLDABF(bool JPNFGIEDOMM)
	{
		if (base.enabled)
		{
			if (!BAMIBNMGNBO)
			{
				FOGNMJLPHAI();
			}
			TweenRotation.Begin(tweenTarget.gameObject, duration, JPNFGIEDOMM ? (IPFGPLLEKHF * Quaternion.Euler(pressed)) : ((!UICamera.DMOOCIJDAIK(base.gameObject)) ? IPFGPLLEKHF : (IPFGPLLEKHF * Quaternion.Euler(hover)))).method = UITweener.MAIJGNJIIIC.BounceOut;
		}
	}

	private void GDJCOAHJDLN()
	{
		if (!BAMIBNMGNBO)
		{
			BAMIBNMGNBO = false;
			if (tweenTarget == null)
			{
				tweenTarget = base.transform;
			}
			IPFGPLLEKHF = tweenTarget.localRotation;
		}
	}

	private void EHAABBLHEMP()
	{
		if (BAMIBNMGNBO)
		{
			OJMBNBMBAMK(UICamera.DMOOCIJDAIK(base.gameObject));
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
			TweenRotation.Begin(tweenTarget.gameObject, duration, JPNFGIEDOMM ? (IPFGPLLEKHF * Quaternion.Euler(pressed)) : ((!UICamera.IsHighlighted(base.gameObject)) ? IPFGPLLEKHF : (IPFGPLLEKHF * Quaternion.Euler(hover)))).method = UITweener.MAIJGNJIIIC.EaseInOut;
		}
	}

	private void NMADMKGHNGF(bool JPNFGIEDOMM)
	{
		if (base.enabled)
		{
			if (!BAMIBNMGNBO)
			{
				Start();
			}
			TweenRotation.OJMCICGBFJK(tweenTarget.gameObject, duration, JPNFGIEDOMM ? (IPFGPLLEKHF * Quaternion.Euler(pressed)) : ((!UICamera.IsHighlighted(base.gameObject)) ? IPFGPLLEKHF : (IPFGPLLEKHF * Quaternion.Euler(hover)))).method = UITweener.MAIJGNJIIIC.BounceOut;
		}
	}

	private void KMPOCJKOAHJ(bool MLIBCICOOAI)
	{
		if (base.enabled)
		{
			if (!BAMIBNMGNBO)
			{
				GDJCOAHJDLN();
			}
			TweenRotation.OJMCICGBFJK(tweenTarget.gameObject, duration, (!MLIBCICOOAI) ? IPFGPLLEKHF : (IPFGPLLEKHF * Quaternion.Euler(hover))).method = (UITweener.MAIJGNJIIIC)7;
		}
	}

	private void KAPAMKEBFPO(bool JPNFGIEDOMM)
	{
		if (base.enabled)
		{
			if (!BAMIBNMGNBO)
			{
				DMPIIJNBDID();
			}
			TweenRotation.OJMCICGBFJK(tweenTarget.gameObject, duration, JPNFGIEDOMM ? (IPFGPLLEKHF * Quaternion.Euler(pressed)) : ((!UICamera.IsHighlighted(base.gameObject)) ? IPFGPLLEKHF : (IPFGPLLEKHF * Quaternion.Euler(hover)))).method = (UITweener.MAIJGNJIIIC)6;
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
			TweenRotation.Begin(tweenTarget.gameObject, duration, (!MLIBCICOOAI) ? IPFGPLLEKHF : (IPFGPLLEKHF * Quaternion.Euler(hover))).method = UITweener.MAIJGNJIIIC.EaseInOut;
		}
	}

	private void OnEnable()
	{
		if (BAMIBNMGNBO)
		{
			DGHCKMGOOGK(UICamera.IsHighlighted(base.gameObject));
		}
	}

	private void DMPIIJNBDID()
	{
		if (!BAMIBNMGNBO)
		{
			BAMIBNMGNBO = false;
			if (tweenTarget == null)
			{
				tweenTarget = base.transform;
			}
			IPFGPLLEKHF = tweenTarget.localRotation;
		}
	}

	private void OHACFIIOGAI(bool MLIBCICOOAI)
	{
		if (base.enabled)
		{
			if (!BAMIBNMGNBO)
			{
				FOGNMJLPHAI();
			}
			TweenRotation.Begin(tweenTarget.gameObject, duration, (!MLIBCICOOAI) ? IPFGPLLEKHF : (IPFGPLLEKHF * Quaternion.Euler(hover))).method = UITweener.MAIJGNJIIIC.BounceOut;
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
			TweenRotation.OJMCICGBFJK(tweenTarget.gameObject, duration, (!MLIBCICOOAI) ? IPFGPLLEKHF : (IPFGPLLEKHF * Quaternion.Euler(hover))).method = (UITweener.MAIJGNJIIIC)7;
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
			IPFGPLLEKHF = tweenTarget.localRotation;
		}
	}

	private void OnDisable()
	{
		if (BAMIBNMGNBO && tweenTarget != null)
		{
			TweenRotation component = tweenTarget.GetComponent<TweenRotation>();
			if (component != null)
			{
				component.set_value(IPFGPLLEKHF);
				component.enabled = false;
			}
		}
	}

	private void JADBJGCMIMF(bool IOGFFPOIBBB)
	{
		if (base.enabled && (!IOGFFPOIBBB || UICamera.currentScheme == UICamera.DOCFHOGBBJH.Controller))
		{
			DGHCKMGOOGK(IOGFFPOIBBB);
		}
	}

	private void CNLPLGJCBIA()
	{
		if (BAMIBNMGNBO && tweenTarget != null)
		{
			TweenRotation component = tweenTarget.GetComponent<TweenRotation>();
			if (component != null)
			{
				component.DLOFJAJAAED(IPFGPLLEKHF);
				component.enabled = false;
			}
		}
	}

	private void PDHMMBNMGJF(bool MLIBCICOOAI)
	{
		if (base.enabled)
		{
			if (!BAMIBNMGNBO)
			{
				Start();
			}
			TweenRotation.Begin(tweenTarget.gameObject, duration, (!MLIBCICOOAI) ? IPFGPLLEKHF : (IPFGPLLEKHF * Quaternion.Euler(hover))).method = UITweener.MAIJGNJIIIC.Linear;
		}
	}

	private void MBDLDNAHAIM()
	{
		if (BAMIBNMGNBO && tweenTarget != null)
		{
			TweenRotation component = tweenTarget.GetComponent<TweenRotation>();
			if (component != null)
			{
				component.DLOFJAJAAED(IPFGPLLEKHF);
				component.enabled = false;
			}
		}
	}

	private void OGDMMMMJGOB(bool IOGFFPOIBBB)
	{
		if (base.enabled && (!IOGFFPOIBBB || UICamera.currentScheme == (UICamera.DOCFHOGBBJH)8))
		{
			KMPOCJKOAHJ(IOGFFPOIBBB);
		}
	}

	private void JMKIGAADECK(bool MLIBCICOOAI)
	{
		if (base.enabled)
		{
			if (!BAMIBNMGNBO)
			{
				FOGNMJLPHAI();
			}
			TweenRotation.Begin(tweenTarget.gameObject, duration, (!MLIBCICOOAI) ? IPFGPLLEKHF : (IPFGPLLEKHF * Quaternion.Euler(hover))).method = UITweener.MAIJGNJIIIC.EaseInOut;
		}
	}
}
