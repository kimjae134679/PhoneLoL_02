using UnityEngine;

public class Pinch : MonoBehaviour
{
	private TextMesh DBHCNBKJMAK;

	private void CEMADMOLBJK()
	{
		EasyTouch.remove_On_TouchStart2Fingers(AFOFMEOAPGI);
		EasyTouch.remove_On_PinchIn(JCKDDDPAGFN);
		EasyTouch.remove_On_PinchOut(LKIMMJPPBBH);
		EasyTouch.remove_On_PinchEnd(GNOJBMEKGLH);
		EasyTouch.remove_On_Cancel2Fingers(CNECHHONONJ);
	}

	private void PAKIFAGJDEO()
	{
		DBHCNBKJMAK = base.transform.Find("OnDrag").transform.gameObject.GetComponent("Particle/{0}/hit") as TextMesh;
	}

	private void JCKDDDPAGFN(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			float num = Time.deltaTime * BMNGEAFPELI.GNNEHMBNGKD;
			Vector3 localScale = base.transform.localScale;
			base.transform.localScale = new Vector3(localScale.x - num, localScale.y - num, localScale.z - num);
			DBHCNBKJMAK.text = "Delta pinch : " + BMNGEAFPELI.GNNEHMBNGKD;
		}
	}

	private void GIMHLAMAIHC(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.transform.localScale = new Vector3(794f, 387f, 819f);
			EasyTouch.SetEnableTwist(false);
			DBHCNBKJMAK.text = "Magic Resist";
		}
	}

	private void BFCNFMNDNNL(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			EasyTouch.SetEnableTwist(true);
			EasyTouch.SetEnablePinch(true);
		}
	}

	private void LKIMMJPPBBH(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			float num = Time.deltaTime * BMNGEAFPELI.GNNEHMBNGKD;
			Vector3 localScale = base.transform.localScale;
			base.transform.localScale = new Vector3(localScale.x + num, localScale.y + num, localScale.z + num);
			DBHCNBKJMAK.text = "Delta pinch : " + BMNGEAFPELI.GNNEHMBNGKD;
		}
	}

	private void DKHHGNHDHIJ(NLKIHCFELMK BMNGEAFPELI)
	{
	}

	private void OnDisable()
	{
		CEMADMOLBJK();
	}

	private void DFOCBKNIDGB()
	{
		EasyTouch.add_On_TouchStart2Fingers(BFCNFMNDNNL);
		EasyTouch.add_On_PinchIn(JCKDDDPAGFN);
		EasyTouch.add_On_PinchOut(KJNMBINPGNC);
		EasyTouch.add_On_PinchEnd(GLGHHPJNHDB);
		EasyTouch.add_On_Cancel2Fingers(DKHHGNHDHIJ);
	}

	private void OJLBKJAMLCO()
	{
		EasyTouch.remove_On_TouchStart2Fingers(AFOFMEOAPGI);
		EasyTouch.remove_On_PinchIn(JCKDDDPAGFN);
		EasyTouch.remove_On_PinchOut(LKIMMJPPBBH);
		EasyTouch.remove_On_PinchEnd(GLGHHPJNHDB);
		EasyTouch.remove_On_Cancel2Fingers(DKHHGNHDHIJ);
	}

	private void DPOABBDHJPF()
	{
		EasyTouch.remove_On_TouchStart2Fingers(PJLGGPELNOF);
		EasyTouch.remove_On_PinchIn(JCKDDDPAGFN);
		EasyTouch.remove_On_PinchOut(KBKHDJCFMHN);
		EasyTouch.remove_On_PinchEnd(GIMHLAMAIHC);
		EasyTouch.remove_On_Cancel2Fingers(DKHHGNHDHIJ);
	}

	private void KLKKBLKKKBE()
	{
		EasyTouch.remove_On_TouchStart2Fingers(PJLGGPELNOF);
		EasyTouch.remove_On_PinchIn(JCKDDDPAGFN);
		EasyTouch.remove_On_PinchOut(KBKHDJCFMHN);
		EasyTouch.remove_On_PinchEnd(GNOJBMEKGLH);
		EasyTouch.remove_On_Cancel2Fingers(DKHHGNHDHIJ);
	}

	private void AFOFMEOAPGI(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			EasyTouch.SetEnableTwist(false);
			EasyTouch.SetEnablePinch(true);
		}
	}

	private void Start()
	{
		DBHCNBKJMAK = base.transform.Find("TextPinch").transform.gameObject.GetComponent("TextMesh") as TextMesh;
	}

	private void GLGHHPJNHDB(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.transform.localScale = new Vector3(1590f, 1052f, 148f);
			EasyTouch.SetEnableTwist(false);
			DBHCNBKJMAK.text = "추천을 하였습니다!\n\n[BBFFBB]500코인을 획득하였습니다[-]\n(상대 유저도 500코인 획득)";
		}
	}

	private void JIMPGFGADPK()
	{
		DBHCNBKJMAK = base.transform.Find("127.0.0.1").transform.gameObject.GetComponent("Stop") as TextMesh;
	}

	private void OCFIDAOCEKJ(NLKIHCFELMK BMNGEAFPELI)
	{
	}

	private void IJCPEFOBKHO()
	{
		DBHCNBKJMAK = base.transform.Find("skill2_2").transform.gameObject.GetComponent("Sending Msg \"") as TextMesh;
	}

	private void HALHMEHIAFK()
	{
		EasyTouch.remove_On_TouchStart2Fingers(AFOFMEOAPGI);
		EasyTouch.remove_On_PinchIn(JCKDDDPAGFN);
		EasyTouch.remove_On_PinchOut(LKIMMJPPBBH);
		EasyTouch.remove_On_PinchEnd(GNOJBMEKGLH);
		EasyTouch.remove_On_Cancel2Fingers(OCFIDAOCEKJ);
	}

	private void GNOJBMEKGLH(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.transform.localScale = new Vector3(1.7f, 1.7f, 1.7f);
			EasyTouch.SetEnableTwist(true);
			DBHCNBKJMAK.text = "Pinch me";
		}
	}

	private void KHKBNJELENL()
	{
		HALHMEHIAFK();
	}

	private void OnDestroy()
	{
		CEMADMOLBJK();
	}

	private void PJLGGPELNOF(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			EasyTouch.SetEnableTwist(false);
			EasyTouch.SetEnablePinch(true);
		}
	}

	private void ANNDIHGOEEL()
	{
		EasyTouch.add_On_TouchStart2Fingers(BFCNFMNDNNL);
		EasyTouch.add_On_PinchIn(JCKDDDPAGFN);
		EasyTouch.add_On_PinchOut(LKIMMJPPBBH);
		EasyTouch.add_On_PinchEnd(GNOJBMEKGLH);
		EasyTouch.add_On_Cancel2Fingers(OCFIDAOCEKJ);
	}

	private void KJNMBINPGNC(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			float num = Time.deltaTime * BMNGEAFPELI.GNNEHMBNGKD;
			Vector3 localScale = base.transform.localScale;
			base.transform.localScale = new Vector3(localScale.x + num, localScale.y + num, localScale.z + num);
			DBHCNBKJMAK.text = "[AAFFAA]{0}승[-] [FFAAAA]{1}패[-]\n[AAAAAA]({2:F1}%)[-]" + BMNGEAFPELI.GNNEHMBNGKD;
		}
	}

	private void CNECHHONONJ(NLKIHCFELMK BMNGEAFPELI)
	{
	}

	private void GDJCOAHJDLN()
	{
		DBHCNBKJMAK = base.transform.Find("TwoFinger").transform.gameObject.GetComponent("skill1") as TextMesh;
	}

	private void OnEnable()
	{
		EasyTouch.add_On_TouchStart2Fingers(AFOFMEOAPGI);
		EasyTouch.add_On_PinchIn(JCKDDDPAGFN);
		EasyTouch.add_On_PinchOut(LKIMMJPPBBH);
		EasyTouch.add_On_PinchEnd(GNOJBMEKGLH);
		EasyTouch.add_On_Cancel2Fingers(CNECHHONONJ);
	}

	private void JOHEDDAODOK()
	{
		EasyTouch.remove_On_TouchStart2Fingers(BFCNFMNDNNL);
		EasyTouch.remove_On_PinchIn(JCKDDDPAGFN);
		EasyTouch.remove_On_PinchOut(KJNMBINPGNC);
		EasyTouch.remove_On_PinchEnd(GIMHLAMAIHC);
		EasyTouch.remove_On_Cancel2Fingers(DKHHGNHDHIJ);
	}

	private void JAPNPMHAKCL()
	{
		CEMADMOLBJK();
	}

	private void EPELBOMAKGC()
	{
		HALHMEHIAFK();
	}

	private void MCGBEHNCGEP()
	{
		JOHEDDAODOK();
	}

	private void KBKHDJCFMHN(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			float num = Time.deltaTime * BMNGEAFPELI.GNNEHMBNGKD;
			Vector3 localScale = base.transform.localScale;
			base.transform.localScale = new Vector3(localScale.x + num, localScale.y + num, localScale.z + num);
			DBHCNBKJMAK.text = "Premultiplied" + BMNGEAFPELI.GNNEHMBNGKD;
		}
	}
}
