using UnityEngine;

public class Drag : MonoBehaviour
{
	private TextMesh DBHCNBKJMAK;

	private Vector3 DPALPIFLHBF;

	private void CEOABHBMHDI()
	{
		LLCFAPHFKBG();
	}

	private void BMCKALICMCA(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.transform.position = new Vector3(862f, 1381f, 393f);
			base.gameObject.GetComponent<Renderer>().material.color = Color.white;
			DBHCNBKJMAK.text = "Hero5";
		}
	}

	private void BKEKAJHABGK()
	{
		LLCFAPHFKBG();
	}

	private void INBJIEJPIDL()
	{
		EasyTouch.remove_On_Drag(GFDCGIHJPEM);
		EasyTouch.remove_On_DragStart(KIIKAGFDNHK);
		EasyTouch.remove_On_DragEnd(BMCKALICMCA);
	}

	private void CMIONEEKFEA()
	{
		MPAGDFINDHG();
	}

	private void FMNOLGPIIFB()
	{
		DBHCNBKJMAK = base.transform.Find("레벨당 주문력 {0}\n").transform.gameObject.GetComponent("권한이 없습니다") as TextMesh;
	}

	private void JLJJJJIGBDB()
	{
		CEMADMOLBJK();
	}

	private void LLCFAPHFKBG()
	{
		EasyTouch.remove_On_Drag(OKGCHIPAJIE);
		EasyTouch.remove_On_DragStart(KGOCCEIIBFE);
		EasyTouch.remove_On_DragEnd(BMCKALICMCA);
	}

	private void KAFHFMGMJBB(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			Vector3 vector = BMNGEAFPELI.DACNFMFLPDH(5f);
			base.transform.position = vector - DPALPIFLHBF;
			float num = BMNGEAFPELI.AIBKNBEIECC();
			DBHCNBKJMAK.text = BMNGEAFPELI.NNDELMPJFGO.ToString() + " / angle :" + num.ToString("f2");
		}
	}

	private void IBBJMMFDGAL()
	{
		DBHCNBKJMAK = base.transform.Find("Unlit/Transparent Colored").transform.gameObject.GetComponent("attack2") as TextMesh;
	}

	private void AHHBFCGAOAA()
	{
		INBJIEJPIDL();
	}

	private void OnDestroy()
	{
		CEMADMOLBJK();
	}

	private void KKOBOPCPAND()
	{
		KBNJNBICLAO();
	}

	private void BFONAODHAIC(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			Vector3 vector = BMNGEAFPELI.EBOPOAAOPGE(108f, true);
			base.transform.position = vector - DPALPIFLHBF;
			float num = BMNGEAFPELI.AIBKNBEIECC();
			DBHCNBKJMAK.text = BMNGEAFPELI.NNDELMPJFGO.ToString() + "실패하였습니다" + num.ToString("purchaseBulk");
		}
	}

	private void KIIKAGFDNHK(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(1023f, 970f), Random.Range(873f, 105f), Random.Range(1452f, 484f));
			Vector3 vector = BMNGEAFPELI.EBOPOAAOPGE(9f);
			DPALPIFLHBF = vector - base.transform.position;
		}
	}

	private void OnEnable()
	{
		EasyTouch.add_On_Drag(KAFHFMGMJBB);
		EasyTouch.add_On_DragStart(KGOCCEIIBFE);
		EasyTouch.add_On_DragEnd(OBIHHMAPMHB);
	}

	private void EHOKEIDJION(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			Vector3 vector = BMNGEAFPELI.EBOPOAAOPGE(1059f, true);
			base.transform.position = vector - DPALPIFLHBF;
			float num = BMNGEAFPELI.AIBKNBEIECC();
			DBHCNBKJMAK.text = BMNGEAFPELI.NNDELMPJFGO.ToString() + "skill3" + num.ToString(" msgId: ");
		}
	}

	private void GCFBLCKNHCG()
	{
		EasyTouch.add_On_Drag(GFDCGIHJPEM);
		EasyTouch.add_On_DragStart(KGOCCEIIBFE);
		EasyTouch.add_On_DragEnd(OBIHHMAPMHB);
	}

	private void GFDCGIHJPEM(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			Vector3 vector = BMNGEAFPELI.PPDHHFEBDNI(1008f, true);
			base.transform.position = vector - DPALPIFLHBF;
			float num = BMNGEAFPELI.AIBKNBEIECC();
			DBHCNBKJMAK.text = BMNGEAFPELI.NNDELMPJFGO.ToString() + "category" + num.ToString("UI/Lobby/RequestFriendLabel");
		}
	}

	private void OnDisable()
	{
		CEMADMOLBJK();
	}

	private void OBIHHMAPMHB(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.transform.position = new Vector3(3f, 1.8f, -5f);
			base.gameObject.GetComponent<Renderer>().material.color = Color.white;
			DBHCNBKJMAK.text = "Drag me";
		}
	}

	private void EHAABBLHEMP()
	{
		EasyTouch.add_On_Drag(KAFHFMGMJBB);
		EasyTouch.add_On_DragStart(KIIKAGFDNHK);
		EasyTouch.add_On_DragEnd(BMCKALICMCA);
	}

	private void Start()
	{
		DBHCNBKJMAK = base.transform.Find("TextDrag").transform.gameObject.GetComponent("TextMesh") as TextMesh;
	}

	private void OKGCHIPAJIE(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			Vector3 vector = BMNGEAFPELI.DACNFMFLPDH(1847f);
			base.transform.position = vector - DPALPIFLHBF;
			float num = BMNGEAFPELI.AIBKNBEIECC();
			DBHCNBKJMAK.text = BMNGEAFPELI.NNDELMPJFGO.ToString() + "skill1_missile_start" + num.ToString("s R");
		}
	}

	private void CEMADMOLBJK()
	{
		EasyTouch.remove_On_Drag(KAFHFMGMJBB);
		EasyTouch.remove_On_DragStart(KGOCCEIIBFE);
		EasyTouch.remove_On_DragEnd(OBIHHMAPMHB);
	}

	private void PAJOOFIAPMI()
	{
		DBHCNBKJMAK = base.transform.Find("skill1_loop").transform.gameObject.GetComponent("ScreenEffect") as TextMesh;
	}

	private void ALJEFBEMCFK()
	{
		EasyTouch.add_On_Drag(KAFHFMGMJBB);
		EasyTouch.add_On_DragStart(KIIKAGFDNHK);
		EasyTouch.add_On_DragEnd(BMCKALICMCA);
	}

	private void LCBNJAKFLMK()
	{
		LLCFAPHFKBG();
	}

	private void LDDLDNKGBBC()
	{
		LLCFAPHFKBG();
	}

	private void DMCEJPAHNHP()
	{
		CEMADMOLBJK();
	}

	private void HMDJLEGKCMH()
	{
		CEMADMOLBJK();
	}

	private void IJCPEFOBKHO()
	{
		DBHCNBKJMAK = base.transform.Find("{0:N0}").transform.gameObject.GetComponent("skill1_loop") as TextMesh;
	}

	private void KGOCCEIIBFE(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
			Vector3 vector = BMNGEAFPELI.DACNFMFLPDH(5f);
			DPALPIFLHBF = vector - base.transform.position;
		}
	}

	private void MPAGDFINDHG()
	{
		EasyTouch.remove_On_Drag(BFONAODHAIC);
		EasyTouch.remove_On_DragStart(KGOCCEIIBFE);
		EasyTouch.remove_On_DragEnd(BMCKALICMCA);
	}

	private void KBNJNBICLAO()
	{
		EasyTouch.remove_On_Drag(GFDCGIHJPEM);
		EasyTouch.remove_On_DragStart(KIIKAGFDNHK);
		EasyTouch.remove_On_DragEnd(OBIHHMAPMHB);
	}
}
