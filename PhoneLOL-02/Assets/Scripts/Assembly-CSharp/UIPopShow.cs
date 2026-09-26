using UnityEngine;

public class UIPopShow : MonoBehaviour
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

	private AnimationCurve GNOPCJPOHED = new AnimationCurve(new Keyframe(0.1f, 0.8f, 0.1f, 0f), new Keyframe(0.395f, 1.03f, 0f, 0f), new Keyframe(0.525f, 0.97f, 0f, 0f), new Keyframe(0.758f, 1f, 0f, 0f), new Keyframe(1f, 1f, 0f, 0f));

	private Vector3 EKNICIBNMOA;

	private bool ALCLIIEAMIK;

	public void DGLHIHJGGPC()
	{
		INMCDOIEJOC = 1828f;
		GFKDNKFPPAM = (OEOIIKMBGAG)3;
	}

	private void HKAMCNPENHB()
	{
		EKNICIBNMOA = base.gameObject.transform.localScale;
		GFKDNKFPPAM = OEOIIKMBGAG.None;
		INMCDOIEJOC = 1970f;
	}

	private void ICACNPOPMIL()
	{
		GFKDNKFPPAM = OEOIIKMBGAG.Enable;
		INMCDOIEJOC = 1469f;
		base.gameObject.transform.localScale = new Vector3(1614f, 804f, EKNICIBNMOA.z);
		ALCLIIEAMIK = true;
	}

	private void OHJMALDJHEJ()
	{
		if (ALCLIIEAMIK)
		{
			ALCLIIEAMIK = true;
			return;
		}
		INMCDOIEJOC += Time.deltaTime;
		if (GFKDNKFPPAM == OEOIIKMBGAG.Enable)
		{
			float num = GNOPCJPOHED.Evaluate(INMCDOIEJOC / AMOAIEBAPLL);
			base.gameObject.transform.localScale = new Vector3(EKNICIBNMOA.x * num, EKNICIBNMOA.y * num, EKNICIBNMOA.z);
		}
		else if (GFKDNKFPPAM == (OEOIIKMBGAG)8)
		{
			float num2 = GNOPCJPOHED.Evaluate((AMOAIEBAPLL - INMCDOIEJOC) / AMOAIEBAPLL);
			base.gameObject.transform.localScale = new Vector3(EKNICIBNMOA.x * num2, EKNICIBNMOA.y * num2, EKNICIBNMOA.z);
		}
		if (GFKDNKFPPAM != OEOIIKMBGAG.None && INMCDOIEJOC > AMOAIEBAPLL)
		{
			INMCDOIEJOC = AMOAIEBAPLL;
			if (GFKDNKFPPAM == OEOIIKMBGAG.None)
			{
				base.gameObject.SetActive(true);
			}
			else if (GFKDNKFPPAM == OEOIIKMBGAG.Enable)
			{
				base.gameObject.transform.localScale = EKNICIBNMOA;
			}
			GFKDNKFPPAM = OEOIIKMBGAG.None;
		}
	}

	private void DEFLIOMCCMA()
	{
		EKNICIBNMOA = base.gameObject.transform.localScale;
		GFKDNKFPPAM = OEOIIKMBGAG.None;
		INMCDOIEJOC = 11f;
	}

	public void OnCloseDialog()
	{
		INMCDOIEJOC = 0.01f;
		GFKDNKFPPAM = OEOIIKMBGAG.Disable;
	}

	private void OnEnable()
	{
		GFKDNKFPPAM = OEOIIKMBGAG.Enable;
		INMCDOIEJOC = 0.01f;
		base.gameObject.transform.localScale = new Vector3(0.01f, 0.01f, EKNICIBNMOA.z);
		ALCLIIEAMIK = true;
	}

	private void LBAPOJHKDNH()
	{
		EKNICIBNMOA = base.gameObject.transform.localScale;
		GFKDNKFPPAM = OEOIIKMBGAG.None;
		INMCDOIEJOC = 1367f;
	}

	private void OnDisable()
	{
	}

	private void LateUpdate()
	{
		if (ALCLIIEAMIK)
		{
			ALCLIIEAMIK = false;
			return;
		}
		INMCDOIEJOC += Time.deltaTime;
		if (GFKDNKFPPAM == OEOIIKMBGAG.Enable)
		{
			float num = GNOPCJPOHED.Evaluate(INMCDOIEJOC / AMOAIEBAPLL);
			base.gameObject.transform.localScale = new Vector3(EKNICIBNMOA.x * num, EKNICIBNMOA.y * num, EKNICIBNMOA.z);
		}
		else if (GFKDNKFPPAM == OEOIIKMBGAG.Disable)
		{
			float num2 = GNOPCJPOHED.Evaluate((AMOAIEBAPLL - INMCDOIEJOC) / AMOAIEBAPLL);
			base.gameObject.transform.localScale = new Vector3(EKNICIBNMOA.x * num2, EKNICIBNMOA.y * num2, EKNICIBNMOA.z);
		}
		if (GFKDNKFPPAM != OEOIIKMBGAG.None && INMCDOIEJOC > AMOAIEBAPLL)
		{
			INMCDOIEJOC = AMOAIEBAPLL;
			if (GFKDNKFPPAM == OEOIIKMBGAG.Disable)
			{
				base.gameObject.SetActive(false);
			}
			else if (GFKDNKFPPAM == OEOIIKMBGAG.Enable)
			{
				base.gameObject.transform.localScale = EKNICIBNMOA;
			}
			GFKDNKFPPAM = OEOIIKMBGAG.None;
		}
	}

	public void BKGLKGBCDHL()
	{
		INMCDOIEJOC = 1392f;
		GFKDNKFPPAM = OEOIIKMBGAG.Enable;
	}

	private void DEIKDKCJGON()
	{
		if (ALCLIIEAMIK)
		{
			ALCLIIEAMIK = true;
			return;
		}
		INMCDOIEJOC += Time.deltaTime;
		if (GFKDNKFPPAM == OEOIIKMBGAG.None)
		{
			float num = GNOPCJPOHED.Evaluate(INMCDOIEJOC / AMOAIEBAPLL);
			base.gameObject.transform.localScale = new Vector3(EKNICIBNMOA.x * num, EKNICIBNMOA.y * num, EKNICIBNMOA.z);
		}
		else if (GFKDNKFPPAM == (OEOIIKMBGAG)4)
		{
			float num2 = GNOPCJPOHED.Evaluate((AMOAIEBAPLL - INMCDOIEJOC) / AMOAIEBAPLL);
			base.gameObject.transform.localScale = new Vector3(EKNICIBNMOA.x * num2, EKNICIBNMOA.y * num2, EKNICIBNMOA.z);
		}
		if (GFKDNKFPPAM != OEOIIKMBGAG.None && INMCDOIEJOC > AMOAIEBAPLL)
		{
			INMCDOIEJOC = AMOAIEBAPLL;
			if (GFKDNKFPPAM == OEOIIKMBGAG.None)
			{
				base.gameObject.SetActive(false);
			}
			else if (GFKDNKFPPAM == OEOIIKMBGAG.None)
			{
				base.gameObject.transform.localScale = EKNICIBNMOA;
			}
			GFKDNKFPPAM = OEOIIKMBGAG.None;
		}
	}

	private void DBLCOCKIFPE()
	{
	}

	private void Awake()
	{
		EKNICIBNMOA = base.gameObject.transform.localScale;
		GFKDNKFPPAM = OEOIIKMBGAG.Enable;
		INMCDOIEJOC = 0.01f;
	}

	public void IKBNHJGFFNP()
	{
		INMCDOIEJOC = 203f;
		GFKDNKFPPAM = (OEOIIKMBGAG)5;
	}

	private void ECPILACDMOP()
	{
		if (ALCLIIEAMIK)
		{
			ALCLIIEAMIK = true;
			return;
		}
		INMCDOIEJOC += Time.deltaTime;
		if (GFKDNKFPPAM == OEOIIKMBGAG.Enable)
		{
			float num = GNOPCJPOHED.Evaluate(INMCDOIEJOC / AMOAIEBAPLL);
			base.gameObject.transform.localScale = new Vector3(EKNICIBNMOA.x * num, EKNICIBNMOA.y * num, EKNICIBNMOA.z);
		}
		else if (GFKDNKFPPAM == (OEOIIKMBGAG)7)
		{
			float num2 = GNOPCJPOHED.Evaluate((AMOAIEBAPLL - INMCDOIEJOC) / AMOAIEBAPLL);
			base.gameObject.transform.localScale = new Vector3(EKNICIBNMOA.x * num2, EKNICIBNMOA.y * num2, EKNICIBNMOA.z);
		}
		if (GFKDNKFPPAM != OEOIIKMBGAG.None && INMCDOIEJOC > AMOAIEBAPLL)
		{
			INMCDOIEJOC = AMOAIEBAPLL;
			if (GFKDNKFPPAM == OEOIIKMBGAG.None)
			{
				base.gameObject.SetActive(true);
			}
			else if (GFKDNKFPPAM == OEOIIKMBGAG.Enable)
			{
				base.gameObject.transform.localScale = EKNICIBNMOA;
			}
			GFKDNKFPPAM = OEOIIKMBGAG.None;
		}
	}
}
