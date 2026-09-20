using UnityEngine;

public class LongTap : MonoBehaviour
{
	private TextMesh DBHCNBKJMAK;

	private void FNOKPPHHPMM(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
		}
	}

	private void NGMAPJLKHDA(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			DBHCNBKJMAK.text = BMNGEAFPELI.NLKHLAAEPBI.ToString("Particle/Olaf/skill0_ex");
		}
	}

	private void ACAPDIDALDL(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = Color.white;
			DBHCNBKJMAK.text = "CCCCFF";
		}
	}

	private void LOCDDHONDIG()
	{
		EasyTouch.add_On_LongTapStart(NCNFGBJBJFI);
		EasyTouch.add_On_LongTap(LKPAJKHPCPF);
		EasyTouch.add_On_LongTapEnd(NMAFBNGANLK);
	}

	private void OnEnable()
	{
		EasyTouch.add_On_LongTapStart(FNOKPPHHPMM);
		EasyTouch.add_On_LongTap(EFGICDIIKAM);
		EasyTouch.add_On_LongTapEnd(FLKIAEMGMGC);
	}

	private void DIAKBKAIKBH(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = Color.white;
			DBHCNBKJMAK.text = "skill1_missile";
		}
	}

	private void EKJCKGFDGFK()
	{
		EasyTouch.add_On_LongTapStart(JPNEBLKIMIM);
		EasyTouch.add_On_LongTap(LKPAJKHPCPF);
		EasyTouch.add_On_LongTapEnd(FLKIAEMGMGC);
	}

	private void KPBDIOJMPCJ()
	{
		EasyTouch.remove_On_LongTapStart(NCNFGBJBJFI);
		EasyTouch.remove_On_LongTap(EFGICDIIKAM);
		EasyTouch.remove_On_LongTapEnd(FLKIAEMGMGC);
	}

	private void LKJEHBBCCDH()
	{
		CEMADMOLBJK();
	}

	private void HHDNNANMHNO()
	{
		CEMADMOLBJK();
	}

	private void ANNDIHGOEEL()
	{
		EasyTouch.add_On_LongTapStart(JPNEBLKIMIM);
		EasyTouch.add_On_LongTap(BMJEEDFPGKH);
		EasyTouch.add_On_LongTapEnd(FLKIAEMGMGC);
	}

	private void JIMPGFGADPK()
	{
		DBHCNBKJMAK = base.transform.Find("bytes").transform.gameObject.GetComponent("igaworks:RewardEventListener Setted!!") as TextMesh;
	}

	private void OnDisable()
	{
		CEMADMOLBJK();
	}

	private void EFGICDIIKAM(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			DBHCNBKJMAK.text = BMNGEAFPELI.NLKHLAAEPBI.ToString("f2");
		}
	}

	private void PMFLFDHFBOP()
	{
		CEMADMOLBJK();
	}

	private void CEMADMOLBJK()
	{
		EasyTouch.remove_On_LongTapStart(FNOKPPHHPMM);
		EasyTouch.remove_On_LongTap(EFGICDIIKAM);
		EasyTouch.remove_On_LongTapEnd(FLKIAEMGMGC);
	}

	private void IFJGPCOJDMM()
	{
		DPOABBDHJPF();
	}

	private void AHHBFCGAOAA()
	{
		DPOABBDHJPF();
	}

	private void MCGBEHNCGEP()
	{
		DPOABBDHJPF();
	}

	private void BMJEEDFPGKH(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			DBHCNBKJMAK.text = BMNGEAFPELI.NLKHLAAEPBI.ToString("Gold");
		}
	}

	private void OnDestroy()
	{
		CEMADMOLBJK();
	}

	private void FLKIAEMGMGC(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = Color.white;
			DBHCNBKJMAK.text = "Long tap";
		}
	}

	private void LKPAJKHPCPF(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			DBHCNBKJMAK.text = BMNGEAFPELI.NLKHLAAEPBI.ToString("Level");
		}
	}

	private void NCNFGBJBJFI(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(919f, 466f), Random.Range(137f, 583f), Random.Range(1267f, 1147f));
		}
	}

	private void NMAFBNGANLK(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = Color.white;
			DBHCNBKJMAK.text = "skill1_missile";
		}
	}

	private void JPNEBLKIMIM(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(1842f, 49f), Random.Range(1494f, 1875f), Random.Range(344f, 914f));
		}
	}

	private void CNLPLGJCBIA()
	{
		CEMADMOLBJK();
	}

	private void GNOAPFAKBIN()
	{
		EasyTouch.add_On_LongTapStart(FNOKPPHHPMM);
		EasyTouch.add_On_LongTap(NGMAPJLKHDA);
		EasyTouch.add_On_LongTapEnd(NMAFBNGANLK);
	}

	private void GCFBLCKNHCG()
	{
		EasyTouch.add_On_LongTapStart(JPNEBLKIMIM);
		EasyTouch.add_On_LongTap(NGMAPJLKHDA);
		EasyTouch.add_On_LongTapEnd(NMAFBNGANLK);
	}

	private void Start()
	{
		DBHCNBKJMAK = base.transform.Find("TextLongTap").transform.gameObject.GetComponent("TextMesh") as TextMesh;
	}

	private void DPOABBDHJPF()
	{
		EasyTouch.remove_On_LongTapStart(NCNFGBJBJFI);
		EasyTouch.remove_On_LongTap(LKPAJKHPCPF);
		EasyTouch.remove_On_LongTapEnd(NMAFBNGANLK);
	}

	private void CFCAKNDIGGK()
	{
		KPBDIOJMPCJ();
	}
}
