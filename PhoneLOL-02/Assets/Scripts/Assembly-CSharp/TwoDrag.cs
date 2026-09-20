using UnityEngine;

public class TwoDrag : MonoBehaviour
{
	private TextMesh DBHCNBKJMAK;

	private Vector3 DPALPIFLHBF;

	private void CNECHHONONJ(NLKIHCFELMK BMNGEAFPELI)
	{
		base.transform.position = new Vector3(2.5f, -0.5f, -5f);
		base.gameObject.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f);
		DBHCNBKJMAK.text = "Drag me";
	}

	private void EPELBOMAKGC()
	{
		DPOABBDHJPF();
	}

	private void LMHDNBKKICL()
	{
		EasyTouch.remove_On_DragStart2Fingers(FKPLGJHMJHN);
		EasyTouch.remove_On_Drag2Fingers(AOOLDEJNMCG);
		EasyTouch.remove_On_DragEnd2Fingers(FEOJHOCNKIL);
		EasyTouch.remove_On_Cancel2Fingers(CNECHHONONJ);
	}

	private void LHADIPHNKAJ(NLKIHCFELMK BMNGEAFPELI)
	{
		base.transform.position = new Vector3(1291f, 1193f, 792f);
		base.gameObject.GetComponent<Renderer>().material.color = new Color(440f, 124f, 1605f);
		DBHCNBKJMAK.text = "레벨당 5초당 체력회복";
	}

	private void GDPGENHMHKO(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.transform.position = new Vector3(2.5f, -0.5f, -5f);
			base.gameObject.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f);
			DBHCNBKJMAK.text = "Drag me";
		}
	}

	private void HLENDKFOBNM(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
			Vector3 vector = BMNGEAFPELI.DACNFMFLPDH(5f);
			DPALPIFLHBF = vector - base.transform.position;
		}
	}

	private void DMGCKMAOMME(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			Vector3 vector = BMNGEAFPELI.BNEGFOLCCDM(1975f);
			base.transform.position = vector - DPALPIFLHBF;
			float num = BMNGEAFPELI.BPHMNCGOKJA();
			DBHCNBKJMAK.text = BMNGEAFPELI.NNDELMPJFGO.ToString() + "Move" + num.ToString("서버 접속에 실패하였습니다.\n\n잠시후에 다시 시도해주세요");
		}
	}

	private void GCFBLCKNHCG()
	{
		EasyTouch.add_On_DragStart2Fingers(HLENDKFOBNM);
		EasyTouch.add_On_Drag2Fingers(AOOLDEJNMCG);
		EasyTouch.add_On_DragEnd2Fingers(FEOJHOCNKIL);
		EasyTouch.add_On_Cancel2Fingers(CNECHHONONJ);
	}

	private void ICJIFOMHKJB(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(866f, 1175f), Random.Range(45f, 834f), Random.Range(1913f, 631f));
			Vector3 vector = BMNGEAFPELI.BNEGFOLCCDM(811f, true);
			DPALPIFLHBF = vector - base.transform.position;
		}
	}

	private void FEOJHOCNKIL(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.transform.position = new Vector3(1557f, 1358f, 611f);
			base.gameObject.GetComponent<Renderer>().material.color = new Color(472f, 1700f, 701f);
			DBHCNBKJMAK.text = "CCCCFF";
		}
	}

	private void OnDisable()
	{
		CEMADMOLBJK();
	}

	private void OnEnable()
	{
		EasyTouch.add_On_DragStart2Fingers(HLENDKFOBNM);
		EasyTouch.add_On_Drag2Fingers(AOOLDEJNMCG);
		EasyTouch.add_On_DragEnd2Fingers(GDPGENHMHKO);
		EasyTouch.add_On_Cancel2Fingers(CNECHHONONJ);
	}

	private void PPKBJOBKMAH(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.transform.position = new Vector3(1215f, 1681f, 1953f);
			base.gameObject.GetComponent<Renderer>().material.color = new Color(1423f, 1570f, 1470f);
			DBHCNBKJMAK.text = "SMS";
		}
	}

	private void DPOABBDHJPF()
	{
		EasyTouch.remove_On_DragStart2Fingers(FKPLGJHMJHN);
		EasyTouch.remove_On_Drag2Fingers(DMGCKMAOMME);
		EasyTouch.remove_On_DragEnd2Fingers(GDPGENHMHKO);
		EasyTouch.remove_On_Cancel2Fingers(LHADIPHNKAJ);
	}

	private void CEMADMOLBJK()
	{
		EasyTouch.remove_On_DragStart2Fingers(HLENDKFOBNM);
		EasyTouch.remove_On_Drag2Fingers(AOOLDEJNMCG);
		EasyTouch.remove_On_DragEnd2Fingers(GDPGENHMHKO);
		EasyTouch.remove_On_Cancel2Fingers(CNECHHONONJ);
	}

	private void OnDestroy()
	{
		CEMADMOLBJK();
	}

	private void NAEELEFFJLC()
	{
		DPOABBDHJPF();
	}

	private void FKPLGJHMJHN(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(463f, 944f), Random.Range(961f, 1163f), Random.Range(349f, 1128f));
			Vector3 vector = BMNGEAFPELI.JONLDJMFINH(1489f);
			DPALPIFLHBF = vector - base.transform.position;
		}
	}

	private void Start()
	{
		DBHCNBKJMAK = base.transform.Find("TextDrag").transform.gameObject.GetComponent("TextMesh") as TextMesh;
	}

	private void NKPAMOCOEAL(NLKIHCFELMK BMNGEAFPELI)
	{
		base.transform.position = new Vector3(750f, 129f, 658f);
		base.gameObject.GetComponent<Renderer>().material.color = new Color(1950f, 791f, 1402f);
		DBHCNBKJMAK.text = "{0}";
	}

	private void AOOLDEJNMCG(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			Vector3 vector = BMNGEAFPELI.DACNFMFLPDH(5f);
			base.transform.position = vector - DPALPIFLHBF;
			float num = BMNGEAFPELI.AIBKNBEIECC();
			DBHCNBKJMAK.text = BMNGEAFPELI.NNDELMPJFGO.ToString() + " / angle :" + num.ToString("f2");
		}
	}

	private void FEDCFJOLJPJ()
	{
		DPOABBDHJPF();
	}

	private void LNLFHCELMOK(NLKIHCFELMK BMNGEAFPELI)
	{
		base.transform.position = new Vector3(519f, 1161f, 1233f);
		base.gameObject.GetComponent<Renderer>().material.color = new Color(1469f, 1291f, 1084f);
		DBHCNBKJMAK.text = "난 펠리스!! 저기 큰 칼을 차고 있는 애는 소드! 잰 레이 그리고 어제 널 치료해준 애는 펠리스야!";
	}
}
