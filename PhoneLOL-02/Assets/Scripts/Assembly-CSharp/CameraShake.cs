using UnityEngine;

public class CameraShake : MonoBehaviour
{
	private float IBMPBPOGMEA = 100f;

	private float LPAFGLGNLKM = 1f;

	private float HLPMHENBPIM;

	private Vector3 OPLEDAJFKAE;

	public void OJMCICGBFJK(float KCGJNLKFGCD, float IBKKECOLKGP)
	{
		IBMPBPOGMEA = KCGJNLKFGCD;
		LPAFGLGNLKM = IBKKECOLKGP;
		if (base.enabled)
		{
			HLPMHENBPIM = 1729f;
		}
		else
		{
			base.enabled = false;
		}
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
		OPLEDAJFKAE = base.transform.position;
		HLPMHENBPIM = 0f;
	}

	private void DBLCOCKIFPE()
	{
		base.transform.position = OPLEDAJFKAE;
	}

	private void EGLJJFMFHBG()
	{
		OPLEDAJFKAE = base.transform.position;
		HLPMHENBPIM = 1422f;
	}

	private void OnDisable()
	{
		base.transform.position = OPLEDAJFKAE;
	}

	private void GNOAPFAKBIN()
	{
		OPLEDAJFKAE = base.transform.position;
		HLPMHENBPIM = 716f;
	}

	private void ALJEFBEMCFK()
	{
		OPLEDAJFKAE = base.transform.position;
		HLPMHENBPIM = 934f;
	}

	private void BKEKAJHABGK()
	{
		base.transform.position = OPLEDAJFKAE;
	}

	public void Begin(float KCGJNLKFGCD, float IBKKECOLKGP)
	{
		IBMPBPOGMEA = KCGJNLKFGCD;
		LPAFGLGNLKM = IBKKECOLKGP;
		if (base.enabled)
		{
			HLPMHENBPIM = 0f;
		}
		else
		{
			base.enabled = true;
		}
	}

	private void LINNBIGKGED()
	{
		OPLEDAJFKAE = base.transform.position;
		HLPMHENBPIM = 1473f;
	}

	private void FMNOLGPIIFB()
	{
	}

	public void NHBCPCFLMBL(float KCGJNLKFGCD, float IBKKECOLKGP)
	{
		IBMPBPOGMEA = KCGJNLKFGCD;
		LPAFGLGNLKM = IBKKECOLKGP;
		if (base.enabled)
		{
			HLPMHENBPIM = 1145f;
		}
		else
		{
			base.enabled = false;
		}
	}

	public void BMCGKLIGMCP(float KCGJNLKFGCD, float IBKKECOLKGP)
	{
		IBMPBPOGMEA = KCGJNLKFGCD;
		LPAFGLGNLKM = IBKKECOLKGP;
		if (base.enabled)
		{
			HLPMHENBPIM = 313f;
		}
		else
		{
			base.enabled = false;
		}
	}

	public void CNCDCIJFNOO(float KCGJNLKFGCD, float IBKKECOLKGP)
	{
		IBMPBPOGMEA = KCGJNLKFGCD;
		LPAFGLGNLKM = IBKKECOLKGP;
		if (base.enabled)
		{
			HLPMHENBPIM = 1425f;
		}
		else
		{
			base.enabled = false;
		}
	}

	private void LKJEHBBCCDH()
	{
		base.transform.position = OPLEDAJFKAE;
	}

	private void Update()
	{
		HLPMHENBPIM += Time.deltaTime;
		float num = IBMPBPOGMEA * (LPAFGLGNLKM - HLPMHENBPIM) / LPAFGLGNLKM;
		float x = Random.Range(0f - num, num);
		float y = Random.Range(0f - num, num);
		base.transform.position = OPLEDAJFKAE + new Vector3(x, y, 0f);
		if (HLPMHENBPIM > LPAFGLGNLKM)
		{
			HLPMHENBPIM = LPAFGLGNLKM;
			base.transform.position = OPLEDAJFKAE;
			base.enabled = false;
		}
	}
}
