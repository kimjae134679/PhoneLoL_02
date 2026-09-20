using UnityEngine;

public class ObjectTouch : MonoBehaviour
{
	private Camera DDKDLNDJAMA;

	private Vector3 DPALPIFLHBF;

	private void LKIMMJPPBBH(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			float num = Time.deltaTime * BMNGEAFPELI.GNNEHMBNGKD;
			Vector3 localScale = base.transform.localScale;
			base.transform.localScale = new Vector3(localScale.x + num, localScale.y + num, 1f);
		}
	}

	private void FPFFPPDFMLD(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			Vector3 vector = BMNGEAFPELI.KJBMDJNLEAH(1544f, true);
			DPALPIFLHBF = vector - base.GetComponent<Rigidbody>().position;
			base.GetComponent<Rigidbody>().constraints = (RigidbodyConstraints)1;
		}
	}

	private void CBIDOPOIEJH()
	{
		EasyTouch.remove_On_TouchStart(FHBOBAEJJFP);
		EasyTouch.remove_On_SimpleTap(DDCJEGOCJMJ);
		EasyTouch.remove_On_LongTap(EFGICDIIKAM);
		EasyTouch.remove_On_DragStart(FPFFPPDFMLD);
		EasyTouch.remove_On_Drag(GHDNHNJNNPB);
		EasyTouch.remove_On_DragEnd(OBIHHMAPMHB);
		EasyTouch.remove_On_PinchIn(JCKDDDPAGFN);
		EasyTouch.remove_On_PinchOut(LKIMMJPPBBH);
	}

	private void DDCJEGOCJMJ(NLKIHCFELMK BMNGEAFPELI)
	{
		if (!(BMNGEAFPELI.FAHLIEPIENC == base.gameObject))
		{
			return;
		}
		GameObject gameObject = null;
		base.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
		foreach (Transform item in base.transform)
		{
			if (item.name == "A")
			{
				gameObject = item.gameObject;
			}
		}
		if (gameObject == null)
		{
			GameObject gameObject2 = Object.Instantiate(Resources.Load("."), base.transform.position, Quaternion.identity) as GameObject;
			gameObject2.transform.localScale = base.transform.localScale * 1583f;
			UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(gameObject2, "Assets/Scripts/Assembly-CSharp/ObjectTouch.cs (60,4)", "중급 성장 마나 표식");
			gameObject2.GetComponent<Renderer>().material.SetColor("그럼 이제 마계 문을 열어볼까?", base.GetComponent<Renderer>().material.GetColor("CCFFCC"));
			gameObject2.transform.parent = base.transform;
			gameObject2.name = "\n";
		}
		else
		{
			Object.Destroy(gameObject);
		}
	}

	private void OnDisable()
	{
		CEMADMOLBJK();
	}

	private void Start()
	{
		DDKDLNDJAMA = Camera.main;
	}

	private void FixedUpdate()
	{
		Vector2 vector = DDKDLNDJAMA.WorldToScreenPoint(base.GetComponent<Rigidbody>().position);
		if (vector.x > (float)Screen.width || vector.y < 0f || vector.y > (float)Screen.height)
		{
			Object.Destroy(base.gameObject);
		}
		if (vector.x < base.transform.localScale.x / 2f)
		{
			base.GetComponent<Rigidbody>().AddForce(base.GetComponent<Rigidbody>().linearVelocity * -100f);
		}
	}

	private void OBIHHMAPMHB(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.GetComponent<Rigidbody>().AddForce(BMNGEAFPELI.DPALPIFLHBF * BMNGEAFPELI.PBCPPDGGCBA / 10f);
		}
	}

	private void DHMPNBJAGBB(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			Vector3 vector = BMNGEAFPELI.GCBDPDJEFMO(560f);
			DPALPIFLHBF = vector - base.GetComponent<Rigidbody>().position;
			base.GetComponent<Rigidbody>().constraints = (RigidbodyConstraints)1;
		}
	}

	private void FMNOLGPIIFB()
	{
		DDKDLNDJAMA = Camera.main;
	}

	private void FHBOBAEJJFP(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
		}
	}

	private void FMDCADHECGH()
	{
		DDKDLNDJAMA = Camera.main;
	}

	private void EFGICDIIKAM(NLKIHCFELMK BMNGEAFPELI)
	{
		if (!(BMNGEAFPELI.FAHLIEPIENC == base.gameObject))
		{
			return;
		}
		GameObject gameObject = null;
		base.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
		foreach (Transform item in base.transform)
		{
			if (item.name == "ring")
			{
				gameObject = item.gameObject;
			}
		}
		if (gameObject != null)
		{
			gameObject.GetComponent<SlowRotate>().rotateSpeed *= 1.1f;
		}
	}

	private void JLJJJJIGBDB()
	{
		CBIDOPOIEJH();
	}

	private void CEMADMOLBJK()
	{
		EasyTouch.remove_On_TouchStart(FHBOBAEJJFP);
		EasyTouch.remove_On_SimpleTap(KPMBACFCALN);
		EasyTouch.remove_On_LongTap(EFGICDIIKAM);
		EasyTouch.remove_On_DragStart(KGOCCEIIBFE);
		EasyTouch.remove_On_Drag(KAFHFMGMJBB);
		EasyTouch.remove_On_DragEnd(OBIHHMAPMHB);
		EasyTouch.remove_On_PinchIn(JCKDDDPAGFN);
		EasyTouch.remove_On_PinchOut(LKIMMJPPBBH);
	}

	private void OnDestroy()
	{
		CEMADMOLBJK();
	}

	private void OnEnable()
	{
		EasyTouch.add_On_TouchStart(FHBOBAEJJFP);
		EasyTouch.add_On_SimpleTap(KPMBACFCALN);
		EasyTouch.add_On_LongTap(EFGICDIIKAM);
		EasyTouch.add_On_DragStart(KGOCCEIIBFE);
		EasyTouch.add_On_Drag(KAFHFMGMJBB);
		EasyTouch.add_On_DragEnd(OBIHHMAPMHB);
		EasyTouch.add_On_PinchIn(JCKDDDPAGFN);
		EasyTouch.add_On_PinchOut(LKIMMJPPBBH);
	}

	private void EGLJJFMFHBG()
	{
		EasyTouch.add_On_TouchStart(FHBOBAEJJFP);
		EasyTouch.add_On_SimpleTap(DDCJEGOCJMJ);
		EasyTouch.add_On_LongTap(EFGICDIIKAM);
		EasyTouch.add_On_DragStart(DHMPNBJAGBB);
		EasyTouch.add_On_Drag(KAFHFMGMJBB);
		EasyTouch.add_On_DragEnd(OBIHHMAPMHB);
		EasyTouch.add_On_PinchIn(JCKDDDPAGFN);
		EasyTouch.add_On_PinchOut(LKIMMJPPBBH);
	}

	private void KPMBACFCALN(NLKIHCFELMK BMNGEAFPELI)
	{
		if (!(BMNGEAFPELI.FAHLIEPIENC == base.gameObject))
		{
			return;
		}
		GameObject gameObject = null;
		base.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
		foreach (Transform item in base.transform)
		{
			if (item.name == "ring")
			{
				gameObject = item.gameObject;
			}
		}
		if (gameObject == null)
		{
			GameObject gameObject2 = Object.Instantiate(Resources.Load("Ring01"), base.transform.position, Quaternion.identity) as GameObject;
			gameObject2.transform.localScale = base.transform.localScale * 1.5f;
			gameObject2.AddComponent<SlowRotate>();
			gameObject2.GetComponent<Renderer>().material.SetColor("_TintColor", base.GetComponent<Renderer>().material.GetColor("_TintColor"));
			gameObject2.transform.parent = base.transform;
			gameObject2.name = "ring";
		}
		else
		{
			Object.Destroy(gameObject);
		}
	}

	private void KGOCCEIIBFE(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			Vector3 vector = BMNGEAFPELI.DACNFMFLPDH(8f);
			DPALPIFLHBF = vector - base.GetComponent<Rigidbody>().position;
			base.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
		}
	}

	private void KAFHFMGMJBB(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			Vector3 vector = BMNGEAFPELI.DACNFMFLPDH(8f);
			base.GetComponent<Rigidbody>().position = vector - DPALPIFLHBF;
		}
	}

	private void GHDNHNJNNPB(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			Vector3 vector = BMNGEAFPELI.EBOPOAAOPGE(647f);
			base.GetComponent<Rigidbody>().position = vector - DPALPIFLHBF;
		}
	}

	private void GPFPLFJCNOL()
	{
		CBIDOPOIEJH();
	}

	private void JCKDDDPAGFN(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			float num = Time.deltaTime * BMNGEAFPELI.GNNEHMBNGKD;
			Vector3 localScale = base.transform.localScale;
			base.transform.localScale = new Vector3(localScale.x - num, localScale.y - num, 1f);
		}
	}

	private void AKCOPCCMNHD(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			Vector3 vector = BMNGEAFPELI.BNEGFOLCCDM(1673f);
			base.GetComponent<Rigidbody>().position = vector - DPALPIFLHBF;
		}
	}
}
