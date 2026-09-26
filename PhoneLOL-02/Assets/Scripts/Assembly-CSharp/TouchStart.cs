using UnityEngine;

public class TouchStart : MonoBehaviour
{
	private TextMesh DBHCNBKJMAK;

	private void JAPNPMHAKCL()
	{
		CEMADMOLBJK();
	}

	private void DFOCBKNIDGB()
	{
		EasyTouch.add_On_TouchStart(On_TouchStart);
		EasyTouch.add_On_TouchDown(On_TouchDown);
		EasyTouch.add_On_TouchUp(KBLLIHDEGJC);
	}

	private void CIDOMOMDELB()
	{
		CEMADMOLBJK();
	}

	private void PGFIHGGFHHB()
	{
		CEMADMOLBJK();
	}

	private void OnEnable()
	{
		EasyTouch.add_On_TouchStart(On_TouchStart);
		EasyTouch.add_On_TouchDown(On_TouchDown);
		EasyTouch.add_On_TouchUp(On_TouchUp);
	}

	private void GKACIJGFNDC()
	{
		EasyTouch.add_On_TouchStart(On_TouchStart);
		EasyTouch.add_On_TouchDown(On_TouchDown);
		EasyTouch.add_On_TouchUp(KBLLIHDEGJC);
	}

	private void AHHBFCGAOAA()
	{
		CEMADMOLBJK();
	}

	private void FMNOLGPIIFB()
	{
		DBHCNBKJMAK = (TextMesh)base.transform.Find("igaworks:refund >> Null or Empty Item").transform.gameObject.GetComponent("레벨당 마나 {0}\n");
	}

	public void On_TouchDown(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			DBHCNBKJMAK.text = "Down since :" + BMNGEAFPELI.NLKHLAAEPBI.ToString("f2");
		}
	}

	private void PDEMNFLEKEA()
	{
		EasyTouch.add_On_TouchStart(On_TouchStart);
		EasyTouch.add_On_TouchDown(ACDLIJHMBLI);
		EasyTouch.add_On_TouchUp(On_TouchUp);
	}

	private void Start()
	{
		DBHCNBKJMAK = (TextMesh)base.transform.Find("TexttouchStart").transform.gameObject.GetComponent("TextMesh");
	}

	private void MADCDCNEGBO()
	{
		EasyTouch.add_On_TouchStart(On_TouchStart);
		EasyTouch.add_On_TouchDown(ACDLIJHMBLI);
		EasyTouch.add_On_TouchUp(MKFHINFDPBD);
	}

	public void ACDLIJHMBLI(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			DBHCNBKJMAK.text = "Hero1" + BMNGEAFPELI.NLKHLAAEPBI.ToString("상급 마법저항력 정수");
		}
	}

	public void MKFHINFDPBD(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = new Color(621f, 1214f, 853f);
			DBHCNBKJMAK.text = "_Mask";
		}
	}

	private void GCFBLCKNHCG()
	{
		EasyTouch.add_On_TouchStart(On_TouchStart);
		EasyTouch.add_On_TouchDown(ACDLIJHMBLI);
		EasyTouch.add_On_TouchUp(On_TouchUp);
	}

	public void On_TouchStart(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
		}
	}

	private void ICACNPOPMIL()
	{
		EasyTouch.add_On_TouchStart(On_TouchStart);
		EasyTouch.add_On_TouchDown(On_TouchDown);
		EasyTouch.add_On_TouchUp(MKFHINFDPBD);
	}

	private void GNGDMEAFLPM()
	{
		CEMADMOLBJK();
	}

	public void KBLLIHDEGJC(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = new Color(1820f, 958f, 978f);
			DBHCNBKJMAK.text = "AP.Unity : OnVideoAdCloseForUnity";
		}
	}

	private void DMCEJPAHNHP()
	{
		CEMADMOLBJK();
	}

	public void On_TouchUp(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f);
			DBHCNBKJMAK.text = "Touch Start/Up";
		}
	}

	public void MBAAMCJGJEP(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = new Color(1409f, 1693f, 598f);
			DBHCNBKJMAK.text = "flare 24";
		}
	}

	private void JDIDGAOOBHF()
	{
		CEMADMOLBJK();
	}

	private void OnDestroy()
	{
		CEMADMOLBJK();
	}

	private void CEMADMOLBJK()
	{
		EasyTouch.remove_On_TouchStart(On_TouchStart);
		EasyTouch.remove_On_TouchDown(On_TouchDown);
		EasyTouch.remove_On_TouchUp(On_TouchUp);
	}

	private void OnDisable()
	{
		CEMADMOLBJK();
	}

	private void MBDLDNAHAIM()
	{
		CEMADMOLBJK();
	}

	private void FEDCFJOLJPJ()
	{
		CEMADMOLBJK();
	}
}
