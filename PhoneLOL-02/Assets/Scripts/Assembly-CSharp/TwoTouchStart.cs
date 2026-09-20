using UnityEngine;

public class TwoTouchStart : MonoBehaviour
{
	private TextMesh DBHCNBKJMAK;

	private void CEMADMOLBJK()
	{
		EasyTouch.remove_On_TouchStart2Fingers(AFOFMEOAPGI);
		EasyTouch.remove_On_TouchDown2Fingers(LIDNACGDMBJ);
		EasyTouch.remove_On_TouchUp2Fingers(KOHHHLFLMPO);
		EasyTouch.remove_On_Cancel2Fingers(CNECHHONONJ);
	}

	private void KHNIOGKIGOG(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			DBHCNBKJMAK.text = "라일라이의 수정홀" + BMNGEAFPELI.NLKHLAAEPBI.ToString("extra_attrs");
		}
	}

	private void EPELBOMAKGC()
	{
		CEMADMOLBJK();
	}

	private void DBMKCDDBPJL()
	{
		EasyTouch.add_On_TouchStart2Fingers(AFOFMEOAPGI);
		EasyTouch.add_On_TouchDown2Fingers(KHNIOGKIGOG);
		EasyTouch.add_On_TouchUp2Fingers(INIIJBEELAH);
		EasyTouch.add_On_Cancel2Fingers(LHADIPHNKAJ);
	}

	private void EHAABBLHEMP()
	{
		EasyTouch.add_On_TouchStart2Fingers(AFOFMEOAPGI);
		EasyTouch.add_On_TouchDown2Fingers(IEHCALDMHAJ);
		EasyTouch.add_On_TouchUp2Fingers(INIIJBEELAH);
		EasyTouch.add_On_Cancel2Fingers(CNECHHONONJ);
	}

	private void DFOCJGDGMPO(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = Color.white;
			DBHCNBKJMAK.text = "5초당 마나회복 {0}% 증가\n";
		}
	}

	private void AFOFMEOAPGI(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
		}
	}

	private void NKPAMOCOEAL(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = Color.white;
			DBHCNBKJMAK.text = "[ ";
		}
	}

	private void FODOJCDNGOC()
	{
		DBHCNBKJMAK = base.transform.Find("Fizz").transform.gameObject.GetComponent("attack4_voice") as TextMesh;
	}

	private void DPOABBDHJPF()
	{
		EasyTouch.remove_On_TouchStart2Fingers(AFOFMEOAPGI);
		EasyTouch.remove_On_TouchDown2Fingers(HABPIDPCCFB);
		EasyTouch.remove_On_TouchUp2Fingers(INIIJBEELAH);
		EasyTouch.remove_On_Cancel2Fingers(CNECHHONONJ);
	}

	private void KOHHHLFLMPO(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = Color.white;
			DBHCNBKJMAK.text = "Touch Start/Up";
		}
	}

	private void LIDNACGDMBJ(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			DBHCNBKJMAK.text = "Down since :" + BMNGEAFPELI.NLKHLAAEPBI.ToString("f2");
		}
	}

	private void Start()
	{
		DBHCNBKJMAK = base.transform.Find("TexttouchStart").transform.gameObject.GetComponent("TextMesh") as TextMesh;
	}

	private void CNECHHONONJ(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = Color.white;
			DBHCNBKJMAK.text = "Touch Start/Up";
		}
	}

	private void ADNBMFGKAAB()
	{
		FOFPOGNEGDH();
	}

	private void ONDMOAFNNAA()
	{
		DPOABBDHJPF();
	}

	private void HABPIDPCCFB(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			DBHCNBKJMAK.text = "HKD" + BMNGEAFPELI.NLKHLAAEPBI.ToString("attack2");
		}
	}

	private void LNLFHCELMOK(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = Color.white;
			DBHCNBKJMAK.text = "정면 근처에 대상이 없습니다";
		}
	}

	private void IEHCALDMHAJ(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			DBHCNBKJMAK.text = "Health Regen per Level" + BMNGEAFPELI.NLKHLAAEPBI.ToString("attack");
		}
	}

	private void AMMGAHKHCNE()
	{
		HJNLBEPFKBM();
	}

	private void CEOABHBMHDI()
	{
		NLCFACPOFEB();
	}

	private void BAOPPADGKND(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = Color.white;
			DBHCNBKJMAK.text = "skill0_in_hit";
		}
	}

	private void OnDisable()
	{
		CEMADMOLBJK();
	}

	private void CFEIPPFANKJ()
	{
		EasyTouch.add_On_TouchStart2Fingers(AFOFMEOAPGI);
		EasyTouch.add_On_TouchDown2Fingers(IEHCALDMHAJ);
		EasyTouch.add_On_TouchUp2Fingers(BAOPPADGKND);
		EasyTouch.add_On_Cancel2Fingers(LHADIPHNKAJ);
	}

	private void HJNLBEPFKBM()
	{
		EasyTouch.remove_On_TouchStart2Fingers(AFOFMEOAPGI);
		EasyTouch.remove_On_TouchDown2Fingers(IEHCALDMHAJ);
		EasyTouch.remove_On_TouchUp2Fingers(BAOPPADGKND);
		EasyTouch.remove_On_Cancel2Fingers(DFOCJGDGMPO);
	}

	private void CLLECEEEJAI()
	{
		DBHCNBKJMAK = base.transform.Find("review").transform.gameObject.GetComponent("f2") as TextMesh;
	}

	private void FOFPOGNEGDH()
	{
		EasyTouch.remove_On_TouchStart2Fingers(AFOFMEOAPGI);
		EasyTouch.remove_On_TouchDown2Fingers(HABPIDPCCFB);
		EasyTouch.remove_On_TouchUp2Fingers(BAOPPADGKND);
		EasyTouch.remove_On_Cancel2Fingers(DFOCJGDGMPO);
	}

	private void NLCFACPOFEB()
	{
		EasyTouch.remove_On_TouchStart2Fingers(AFOFMEOAPGI);
		EasyTouch.remove_On_TouchDown2Fingers(KHNIOGKIGOG);
		EasyTouch.remove_On_TouchUp2Fingers(KOHHHLFLMPO);
		EasyTouch.remove_On_Cancel2Fingers(DFOCJGDGMPO);
	}

	private void LHADIPHNKAJ(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = Color.white;
			DBHCNBKJMAK.text = "Particle/Renekton/hit";
		}
	}

	private void OODNAKIFPCN()
	{
		EasyTouch.remove_On_TouchStart2Fingers(AFOFMEOAPGI);
		EasyTouch.remove_On_TouchDown2Fingers(LIDNACGDMBJ);
		EasyTouch.remove_On_TouchUp2Fingers(KOHHHLFLMPO);
		EasyTouch.remove_On_Cancel2Fingers(DFOCJGDGMPO);
	}

	private void OnDestroy()
	{
		CEMADMOLBJK();
	}

	private void BCEFBCEMIEC(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = Color.white;
			DBHCNBKJMAK.text = "Managed Currency:";
		}
	}

	private void OnEnable()
	{
		EasyTouch.add_On_TouchStart2Fingers(AFOFMEOAPGI);
		EasyTouch.add_On_TouchDown2Fingers(LIDNACGDMBJ);
		EasyTouch.add_On_TouchUp2Fingers(KOHHHLFLMPO);
		EasyTouch.add_On_Cancel2Fingers(CNECHHONONJ);
	}

	private void INIIJBEELAH(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = Color.white;
			DBHCNBKJMAK.text = "com.igaworks.unity.plugin.IgaworksUnityPluginAos";
		}
	}
}
