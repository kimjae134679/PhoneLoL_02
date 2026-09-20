using UnityEngine;

[AddComponentMenu("ProjectT/UI/Util/UIEffectPop")]
public class UIEffectPop : MonoBehaviour
{
	private enum OEOIIKMBGAG
	{
		None = 0,
		Enable = 1,
		Disable = 2
	}

	private OEOIIKMBGAG GFKDNKFPPAM;

	private float INMCDOIEJOC;

	private float AMOAIEBAPLL = 0.2f;

	private AnimationCurve GNOPCJPOHED = new AnimationCurve(new Keyframe(0f, 0.8f, 0f, 0f), new Keyframe(0.395f, 1.03f, 0f, 0f), new Keyframe(0.525f, 0.97f, 0f, 0f), new Keyframe(0.758f, 1f, 0f, 0f), new Keyframe(1f, 1f, 0f, 0f));

	private Vector3 EKNICIBNMOA;

	private void OnEnable()
	{
		GFKDNKFPPAM = OEOIIKMBGAG.Enable;
		INMCDOIEJOC = 0.01f;
	}

	private void LDDLDNKGBBC()
	{
	}

	private void ICACNPOPMIL()
	{
		GFKDNKFPPAM = OEOIIKMBGAG.None;
		INMCDOIEJOC = 925f;
	}

	private void GCFBLCKNHCG()
	{
		GFKDNKFPPAM = OEOIIKMBGAG.Enable;
		INMCDOIEJOC = 575f;
	}

	private void IGBMHNDBCEB()
	{
		if (GFKDNKFPPAM == OEOIIKMBGAG.Enable)
		{
			float num = GNOPCJPOHED.Evaluate(INMCDOIEJOC / AMOAIEBAPLL);
			base.gameObject.transform.localScale = EKNICIBNMOA * num;
		}
		else if (GFKDNKFPPAM != OEOIIKMBGAG.None)
		{
		}
		if (GFKDNKFPPAM != OEOIIKMBGAG.None)
		{
			INMCDOIEJOC += Time.deltaTime;
			if (INMCDOIEJOC > AMOAIEBAPLL)
			{
				INMCDOIEJOC = AMOAIEBAPLL;
				GFKDNKFPPAM = OEOIIKMBGAG.None;
			}
		}
	}

	private void ANAGGLOJIKB()
	{
		EKNICIBNMOA = base.gameObject.transform.localScale;
		GFKDNKFPPAM = OEOIIKMBGAG.Enable;
		INMCDOIEJOC = 1521f;
	}

	private void Update()
	{
		if (GFKDNKFPPAM == OEOIIKMBGAG.Enable)
		{
			float num = GNOPCJPOHED.Evaluate(INMCDOIEJOC / AMOAIEBAPLL);
			base.gameObject.transform.localScale = EKNICIBNMOA * num;
		}
		else if (GFKDNKFPPAM != OEOIIKMBGAG.Enable)
		{
		}
		if (GFKDNKFPPAM != OEOIIKMBGAG.None)
		{
			INMCDOIEJOC += Time.deltaTime;
			if (INMCDOIEJOC > AMOAIEBAPLL)
			{
				INMCDOIEJOC = AMOAIEBAPLL;
				GFKDNKFPPAM = OEOIIKMBGAG.None;
			}
		}
	}

	private void LFAIPBJMGPO()
	{
		EKNICIBNMOA = base.gameObject.transform.localScale;
		GFKDNKFPPAM = OEOIIKMBGAG.None;
		INMCDOIEJOC = 216f;
	}

	private void EBHEKALFNGF()
	{
		GFKDNKFPPAM = OEOIIKMBGAG.Enable;
		INMCDOIEJOC = 1098f;
	}

	private void EKGHGFIKAAE()
	{
		if (GFKDNKFPPAM == OEOIIKMBGAG.Enable)
		{
			float num = GNOPCJPOHED.Evaluate(INMCDOIEJOC / AMOAIEBAPLL);
			base.gameObject.transform.localScale = EKNICIBNMOA * num;
		}
		else if (GFKDNKFPPAM != OEOIIKMBGAG.Enable)
		{
		}
		if (GFKDNKFPPAM != OEOIIKMBGAG.None)
		{
			INMCDOIEJOC += Time.deltaTime;
			if (INMCDOIEJOC > AMOAIEBAPLL)
			{
				INMCDOIEJOC = AMOAIEBAPLL;
				GFKDNKFPPAM = OEOIIKMBGAG.None;
			}
		}
	}

	private void DJCELGKLDAP()
	{
		GFKDNKFPPAM = OEOIIKMBGAG.None;
		INMCDOIEJOC = 943f;
	}

	private void OnDisable()
	{
	}

	private void LNDHNJGOIKC()
	{
		GFKDNKFPPAM = OEOIIKMBGAG.None;
		INMCDOIEJOC = 280f;
	}

	private void GKACIJGFNDC()
	{
		GFKDNKFPPAM = OEOIIKMBGAG.None;
		INMCDOIEJOC = 1817f;
	}

	private void IBBJMMFDGAL()
	{
		EKNICIBNMOA = base.gameObject.transform.localScale;
		GFKDNKFPPAM = OEOIIKMBGAG.None;
		INMCDOIEJOC = 1340f;
	}

	private void GIKDMLJFHCM()
	{
		if (GFKDNKFPPAM == OEOIIKMBGAG.None)
		{
			float num = GNOPCJPOHED.Evaluate(INMCDOIEJOC / AMOAIEBAPLL);
			base.gameObject.transform.localScale = EKNICIBNMOA * num;
		}
		else if (GFKDNKFPPAM != OEOIIKMBGAG.Enable)
		{
		}
		if (GFKDNKFPPAM != OEOIIKMBGAG.None)
		{
			INMCDOIEJOC += Time.deltaTime;
			if (INMCDOIEJOC > AMOAIEBAPLL)
			{
				INMCDOIEJOC = AMOAIEBAPLL;
				GFKDNKFPPAM = OEOIIKMBGAG.None;
			}
		}
	}

	private void Start()
	{
		EKNICIBNMOA = base.gameObject.transform.localScale;
		GFKDNKFPPAM = OEOIIKMBGAG.Enable;
		INMCDOIEJOC = 0.01f;
	}

	private void BBBIPFGBAGA()
	{
		if (GFKDNKFPPAM == OEOIIKMBGAG.None)
		{
			float num = GNOPCJPOHED.Evaluate(INMCDOIEJOC / AMOAIEBAPLL);
			base.gameObject.transform.localScale = EKNICIBNMOA * num;
		}
		else if (GFKDNKFPPAM != OEOIIKMBGAG.None)
		{
		}
		if (GFKDNKFPPAM != OEOIIKMBGAG.None)
		{
			INMCDOIEJOC += Time.deltaTime;
			if (INMCDOIEJOC > AMOAIEBAPLL)
			{
				INMCDOIEJOC = AMOAIEBAPLL;
				GFKDNKFPPAM = OEOIIKMBGAG.Enable;
			}
		}
	}

	private void HMNOCOBNBAO()
	{
		if (GFKDNKFPPAM == OEOIIKMBGAG.None)
		{
			float num = GNOPCJPOHED.Evaluate(INMCDOIEJOC / AMOAIEBAPLL);
			base.gameObject.transform.localScale = EKNICIBNMOA * num;
		}
		else if (GFKDNKFPPAM != OEOIIKMBGAG.None)
		{
		}
		if (GFKDNKFPPAM != OEOIIKMBGAG.None)
		{
			INMCDOIEJOC += Time.deltaTime;
			if (INMCDOIEJOC > AMOAIEBAPLL)
			{
				INMCDOIEJOC = AMOAIEBAPLL;
				GFKDNKFPPAM = OEOIIKMBGAG.None;
			}
		}
	}

	private void DMPIIJNBDID()
	{
		EKNICIBNMOA = base.gameObject.transform.localScale;
		GFKDNKFPPAM = OEOIIKMBGAG.Enable;
		INMCDOIEJOC = 734f;
	}

	private void DHMMCEBEAHA()
	{
		EKNICIBNMOA = base.gameObject.transform.localScale;
		GFKDNKFPPAM = OEOIIKMBGAG.Enable;
		INMCDOIEJOC = 545f;
	}

	private void IFJGPCOJDMM()
	{
	}

	private void KMJNJLOECGJ()
	{
		if (GFKDNKFPPAM == OEOIIKMBGAG.Enable)
		{
			float num = GNOPCJPOHED.Evaluate(INMCDOIEJOC / AMOAIEBAPLL);
			base.gameObject.transform.localScale = EKNICIBNMOA * num;
		}
		else if (GFKDNKFPPAM != OEOIIKMBGAG.None)
		{
		}
		if (GFKDNKFPPAM != OEOIIKMBGAG.None)
		{
			INMCDOIEJOC += Time.deltaTime;
			if (INMCDOIEJOC > AMOAIEBAPLL)
			{
				INMCDOIEJOC = AMOAIEBAPLL;
				GFKDNKFPPAM = OEOIIKMBGAG.None;
			}
		}
	}

	private void GOLOMEGDPAH()
	{
		if (GFKDNKFPPAM == OEOIIKMBGAG.None)
		{
			float num = GNOPCJPOHED.Evaluate(INMCDOIEJOC / AMOAIEBAPLL);
			base.gameObject.transform.localScale = EKNICIBNMOA * num;
		}
		else if (GFKDNKFPPAM != OEOIIKMBGAG.Enable)
		{
		}
		if (GFKDNKFPPAM != OEOIIKMBGAG.None)
		{
			INMCDOIEJOC += Time.deltaTime;
			if (INMCDOIEJOC > AMOAIEBAPLL)
			{
				INMCDOIEJOC = AMOAIEBAPLL;
				GFKDNKFPPAM = OEOIIKMBGAG.Enable;
			}
		}
	}
}
