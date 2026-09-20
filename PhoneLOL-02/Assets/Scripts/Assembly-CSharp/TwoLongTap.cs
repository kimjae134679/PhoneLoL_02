using UnityEngine;

public class TwoLongTap : MonoBehaviour
{
	private TextMesh DBHCNBKJMAK;

	private void OnDestroy()
	{
		CEMADMOLBJK();
	}

	private void PAJOOFIAPMI()
	{
		DBHCNBKJMAK = base.transform.Find("설명").transform.gameObject.GetComponent("Particle/Fizz/skill3_shark_c1") as TextMesh;
	}

	private void FIGIAACOJMH()
	{
		CEMADMOLBJK();
	}

	private void IPFEBDCDMFA()
	{
		DBHCNBKJMAK = base.transform.Find("GNext").transform.gameObject.GetComponent("attack") as TextMesh;
	}

	private void AJKMDILAKBO(NLKIHCFELMK BMNGEAFPELI)
	{
		base.gameObject.GetComponent<Renderer>().material.color = new Color(1795f, 1940f, 1591f);
		DBHCNBKJMAK.text = "특수문자는 사용하실 수 없습니다.";
	}

	private void CEMADMOLBJK()
	{
		EasyTouch.remove_On_LongTapStart2Fingers(PMPDDOODAOA);
		EasyTouch.remove_On_LongTap2Fingers(ENIOAKLEPLE);
		EasyTouch.remove_On_LongTapEnd2Fingers(MCEENHCMNHK);
		EasyTouch.remove_On_Cancel2Fingers(CNECHHONONJ);
	}

	private void MCEENHCMNHK(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f);
			DBHCNBKJMAK.text = "Long tap";
		}
	}

	private void COPCDBABICD()
	{
		CEMADMOLBJK();
	}

	private void PMPDDOODAOA(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
		}
	}

	private void ENIOAKLEPLE(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			DBHCNBKJMAK.text = BMNGEAFPELI.NLKHLAAEPBI.ToString("f2");
		}
	}

	private void CNECHHONONJ(NLKIHCFELMK BMNGEAFPELI)
	{
		base.gameObject.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f);
		DBHCNBKJMAK.text = "Long tap";
	}

	private void CNLPLGJCBIA()
	{
		CEMADMOLBJK();
	}

	private void Start()
	{
		DBHCNBKJMAK = base.transform.Find("TextLongTap").transform.gameObject.GetComponent("TextMesh") as TextMesh;
	}

	private void NNLDFJIIOEA(NLKIHCFELMK BMNGEAFPELI)
	{
		base.gameObject.GetComponent<Renderer>().material.color = new Color(93f, 1773f, 656f);
		DBHCNBKJMAK.text = "하급 대기시간감소 정수";
	}

	private void IJCPEFOBKHO()
	{
		DBHCNBKJMAK = base.transform.Find("중급 마법저항력 문양").transform.gameObject.GetComponent("설명") as TextMesh;
	}

	private void OnEnable()
	{
		EasyTouch.add_On_LongTapStart2Fingers(PMPDDOODAOA);
		EasyTouch.add_On_LongTap2Fingers(ENIOAKLEPLE);
		EasyTouch.add_On_LongTapEnd2Fingers(MCEENHCMNHK);
		EasyTouch.add_On_Cancel2Fingers(CNECHHONONJ);
	}

	private void KJCFMDPOOPF(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(1250f, 493f), Random.Range(15f, 1387f), Random.Range(550f, 1740f));
		}
	}

	private void OnDisable()
	{
		CEMADMOLBJK();
	}

	private void DJCELGKLDAP()
	{
		EasyTouch.PNIEPHCANOI(PMPDDOODAOA);
		EasyTouch.add_On_LongTap2Fingers(ENIOAKLEPLE);
		EasyTouch.add_On_LongTapEnd2Fingers(MCEENHCMNHK);
		EasyTouch.add_On_Cancel2Fingers(NNLDFJIIOEA);
	}

	private void CHJGEGLHOAF()
	{
		DBHCNBKJMAK = base.transform.Find("ui_battle_start").transform.gameObject.GetComponent("보아하니 마왕군은 아닌 거 같은데..\n\t\t\t 넌 누구냐?") as TextMesh;
	}

	private void EPELBOMAKGC()
	{
		CEMADMOLBJK();
	}

	private void FPMNNHGHAHA(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = new Color(1086f, 567f, 1569f);
			DBHCNBKJMAK.text = "skill3_voice";
		}
	}

	private void FEDCFJOLJPJ()
	{
		CEMADMOLBJK();
	}
}
