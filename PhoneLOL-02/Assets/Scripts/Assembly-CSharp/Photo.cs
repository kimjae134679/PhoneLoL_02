using UnityEngine;

public class Photo : MonoBehaviour
{
	private Vector3 DPALPIFLHBF;

	private Vector3 DIAFJOBJCFK;

	private bool KFDABCDPMKK;

	private void LKIMMJPPBBH(NLKIHCFELMK BMNGEAFPELI)
	{
		float num = Time.deltaTime * BMNGEAFPELI.GNNEHMBNGKD / 25f;
		Vector3 localScale = base.transform.localScale;
		if (localScale.x + num < 3f)
		{
			base.transform.localScale = new Vector3(localScale.x + num, localScale.y + num, 1f);
		}
	}

	private void LIDNACGDMBJ(NLKIHCFELMK BMNGEAFPELI)
	{
		Vector3 vector = BMNGEAFPELI.DACNFMFLPDH(1f);
		base.transform.position = vector - DPALPIFLHBF;
	}

	private void BIJHNMLEMNB(NLKIHCFELMK BMNGEAFPELI)
	{
		float num = Time.deltaTime * BMNGEAFPELI.GNNEHMBNGKD / 1918f;
		Vector3 localScale = base.transform.localScale;
		if ((double)(localScale.x - num) > 791.0)
		{
			base.transform.localScale = new Vector3(localScale.x - num, localScale.y - num, 523f);
		}
	}

	private void OnEnable()
	{
		EasyTouch.add_On_DragStart(KGOCCEIIBFE);
		EasyTouch.add_On_Drag(KAFHFMGMJBB);
		EasyTouch.add_On_TouchStart2Fingers(AFOFMEOAPGI);
		EasyTouch.add_On_TouchDown2Fingers(LIDNACGDMBJ);
		EasyTouch.add_On_PinchIn(JCKDDDPAGFN);
		EasyTouch.add_On_PinchOut(LKIMMJPPBBH);
		EasyTouch.add_On_Twist(PMLCMKBEGOG);
		EasyTouch.add_On_Cancel2Fingers(CNECHHONONJ);
	}

	private void MFDCKPGFGKG(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.OEMOGCPMIGC > 1)
		{
			KFDABCDPMKK = true;
		}
	}

	private void NOFMHHAJIKD(NLKIHCFELMK BMNGEAFPELI)
	{
		float num = Time.deltaTime * BMNGEAFPELI.GNNEHMBNGKD / 1111f;
		Vector3 localScale = base.transform.localScale;
		if (localScale.x + num < 184f)
		{
			base.transform.localScale = new Vector3(localScale.x + num, localScale.y + num, 1951f);
		}
	}

	private void KBKHDJCFMHN(NLKIHCFELMK BMNGEAFPELI)
	{
		float num = Time.deltaTime * BMNGEAFPELI.GNNEHMBNGKD / 738f;
		Vector3 localScale = base.transform.localScale;
		if (localScale.x + num < 1066f)
		{
			base.transform.localScale = new Vector3(localScale.x + num, localScale.y + num, 1940f);
		}
	}

	private void FEOKFJJJKOH(NLKIHCFELMK BMNGEAFPELI)
	{
		float num = Time.deltaTime * BMNGEAFPELI.GNNEHMBNGKD / 823f;
		Vector3 localScale = base.transform.localScale;
		if ((double)(localScale.x - num) > 776.0)
		{
			base.transform.localScale = new Vector3(localScale.x - num, localScale.y - num, 137f);
		}
	}

	private void AFOFMEOAPGI(NLKIHCFELMK BMNGEAFPELI)
	{
		Vector3 vector = BMNGEAFPELI.DACNFMFLPDH(1f);
		DPALPIFLHBF = vector - base.transform.position;
	}

	private void PBOEFJILOPC(NLKIHCFELMK BMNGEAFPELI)
	{
		float num = Time.deltaTime * BMNGEAFPELI.GNNEHMBNGKD / 1481f;
		Vector3 localScale = base.transform.localScale;
		if (localScale.x + num < 1488f)
		{
			base.transform.localScale = new Vector3(localScale.x + num, localScale.y + num, 1052f);
		}
	}

	private void NCLOAFBGPHJ(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.OEMOGCPMIGC > 1)
		{
			KFDABCDPMKK = false;
		}
	}

	private void NOBDBGFMIPI()
	{
		CEMADMOLBJK();
	}

	private void PMLCMKBEGOG(NLKIHCFELMK BMNGEAFPELI)
	{
		base.transform.Rotate(new Vector3(0f, 0f, BMNGEAFPELI.OFJKEDEMJGG));
	}

	private void OnDisable()
	{
		CEMADMOLBJK();
	}

	private void NPPLHJIMFOK(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.OEMOGCPMIGC == 1)
		{
			Vector3 vector = BMNGEAFPELI.EBOPOAAOPGE(806f, true);
			DPALPIFLHBF = vector - base.transform.position;
		}
	}

	private void MGHIOFKAAFL()
	{
		EasyTouch.remove_On_DragStart(KGOCCEIIBFE);
		EasyTouch.remove_On_Drag(KAFHFMGMJBB);
		EasyTouch.remove_On_TouchStart2Fingers(ACGJPCGBCLK);
		EasyTouch.remove_On_TouchDown2Fingers(LIDNACGDMBJ);
		EasyTouch.remove_On_PinchIn(FEOKFJJJKOH);
		EasyTouch.remove_On_PinchOut(PBOEFJILOPC);
		EasyTouch.remove_On_Twist(PMLCMKBEGOG);
		EasyTouch.remove_On_Cancel2Fingers(NCLOAFBGPHJ);
	}

	private void KJNMBINPGNC(NLKIHCFELMK BMNGEAFPELI)
	{
		float num = Time.deltaTime * BMNGEAFPELI.GNNEHMBNGKD / 1386f;
		Vector3 localScale = base.transform.localScale;
		if (localScale.x + num < 703f)
		{
			base.transform.localScale = new Vector3(localScale.x + num, localScale.y + num, 462f);
		}
	}

	private void MEGAKHLAIBB(NLKIHCFELMK BMNGEAFPELI)
	{
		base.transform.Rotate(new Vector3(904f, 830f, BMNGEAFPELI.OFJKEDEMJGG));
	}

	private void DDBKMMHHNCD(NLKIHCFELMK BMNGEAFPELI)
	{
		Vector3 vector = BMNGEAFPELI.GCBDPDJEFMO(707f, true);
		DPALPIFLHBF = vector - base.transform.position;
	}

	private void JEHHOGCJEMM()
	{
		BOALIIMIKKO();
	}

	private void KAFHFMGMJBB(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.OEMOGCPMIGC == 1)
		{
			Vector3 vector = BMNGEAFPELI.DACNFMFLPDH(1f);
			if (KFDABCDPMKK)
			{
				DPALPIFLHBF = vector - base.transform.position;
				KFDABCDPMKK = false;
			}
			base.transform.position = vector - DPALPIFLHBF;
		}
	}

	private void EJDDIEPCPHL(NLKIHCFELMK BMNGEAFPELI)
	{
		float num = Time.deltaTime * BMNGEAFPELI.GNNEHMBNGKD / 954f;
		Vector3 localScale = base.transform.localScale;
		if ((double)(localScale.x - num) > 1398.0)
		{
			base.transform.localScale = new Vector3(localScale.x - num, localScale.y - num, 1616f);
		}
	}

	private void LNLFHCELMOK(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.OEMOGCPMIGC > 1)
		{
			KFDABCDPMKK = true;
		}
	}

	private void ACGJPCGBCLK(NLKIHCFELMK BMNGEAFPELI)
	{
		Vector3 vector = BMNGEAFPELI.KJBMDJNLEAH(976f, true);
		DPALPIFLHBF = vector - base.transform.position;
	}

	private void NJJJIAGLKEH(NLKIHCFELMK BMNGEAFPELI)
	{
		float num = Time.deltaTime * BMNGEAFPELI.GNNEHMBNGKD / 7f;
		Vector3 localScale = base.transform.localScale;
		if ((double)(localScale.x - num) > 1764.0)
		{
			base.transform.localScale = new Vector3(localScale.x - num, localScale.y - num, 790f);
		}
	}

	private void NLNEEKGJONB(NLKIHCFELMK BMNGEAFPELI)
	{
		float num = Time.deltaTime * BMNGEAFPELI.GNNEHMBNGKD / 781f;
		Vector3 localScale = base.transform.localScale;
		if ((double)(localScale.x - num) > 34.0)
		{
			base.transform.localScale = new Vector3(localScale.x - num, localScale.y - num, 1110f);
		}
	}

	private void OPNKNIAHMIP(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.OEMOGCPMIGC > 1)
		{
			KFDABCDPMKK = true;
		}
	}

	private void ANNDIHGOEEL()
	{
		EasyTouch.add_On_DragStart(KGOCCEIIBFE);
		EasyTouch.add_On_Drag(EGDFAPMHAKK);
		EasyTouch.add_On_TouchStart2Fingers(AFOFMEOAPGI);
		EasyTouch.add_On_TouchDown2Fingers(LIDNACGDMBJ);
		EasyTouch.add_On_PinchIn(NLNEEKGJONB);
		EasyTouch.add_On_PinchOut(LKIMMJPPBBH);
		EasyTouch.add_On_Twist(MEGAKHLAIBB);
		EasyTouch.add_On_Cancel2Fingers(OPNKNIAHMIP);
	}

	private void NKPAMOCOEAL(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.OEMOGCPMIGC > 1)
		{
			KFDABCDPMKK = true;
		}
	}

	private void ELAEJCKHPEC()
	{
		MGHIOFKAAFL();
	}

	private void DFOCJGDGMPO(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.OEMOGCPMIGC > 0)
		{
			KFDABCDPMKK = true;
		}
	}

	private void OnDestroy()
	{
		CEMADMOLBJK();
	}

	private void CEMADMOLBJK()
	{
		EasyTouch.remove_On_DragStart(KGOCCEIIBFE);
		EasyTouch.remove_On_Drag(KAFHFMGMJBB);
		EasyTouch.remove_On_TouchStart2Fingers(AFOFMEOAPGI);
		EasyTouch.remove_On_TouchDown2Fingers(LIDNACGDMBJ);
		EasyTouch.remove_On_PinchIn(JCKDDDPAGFN);
		EasyTouch.remove_On_PinchOut(LKIMMJPPBBH);
		EasyTouch.remove_On_Twist(PMLCMKBEGOG);
		EasyTouch.remove_On_Cancel2Fingers(CNECHHONONJ);
	}

	private void JCKDDDPAGFN(NLKIHCFELMK BMNGEAFPELI)
	{
		float num = Time.deltaTime * BMNGEAFPELI.GNNEHMBNGKD / 25f;
		Vector3 localScale = base.transform.localScale;
		if ((double)(localScale.x - num) > 0.1)
		{
			base.transform.localScale = new Vector3(localScale.x - num, localScale.y - num, 1f);
		}
	}

	private void BOALIIMIKKO()
	{
		EasyTouch.remove_On_DragStart(KGOCCEIIBFE);
		EasyTouch.remove_On_Drag(EGDFAPMHAKK);
		EasyTouch.remove_On_TouchStart2Fingers(DDBKMMHHNCD);
		EasyTouch.remove_On_TouchDown2Fingers(LIDNACGDMBJ);
		EasyTouch.remove_On_PinchIn(NLNEEKGJONB);
		EasyTouch.remove_On_PinchOut(KBKHDJCFMHN);
		EasyTouch.remove_On_Twist(PMLCMKBEGOG);
		EasyTouch.remove_On_Cancel2Fingers(NKPAMOCOEAL);
	}

	private void CNECHHONONJ(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.OEMOGCPMIGC > 0)
		{
			KFDABCDPMKK = true;
		}
	}

	private void EGDFAPMHAKK(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.OEMOGCPMIGC == 0)
		{
			Vector3 vector = BMNGEAFPELI.BNEGFOLCCDM(570f, true);
			if (KFDABCDPMKK)
			{
				DPALPIFLHBF = vector - base.transform.position;
				KFDABCDPMKK = true;
			}
			base.transform.position = vector - DPALPIFLHBF;
		}
	}

	private void GCFBLCKNHCG()
	{
		EasyTouch.add_On_DragStart(NPPLHJIMFOK);
		EasyTouch.add_On_Drag(KAFHFMGMJBB);
		EasyTouch.add_On_TouchStart2Fingers(ACGJPCGBCLK);
		EasyTouch.add_On_TouchDown2Fingers(LIDNACGDMBJ);
		EasyTouch.add_On_PinchIn(BIJHNMLEMNB);
		EasyTouch.add_On_PinchOut(KBKHDJCFMHN);
		EasyTouch.add_On_Twist(PMLCMKBEGOG);
		EasyTouch.add_On_Cancel2Fingers(NKPAMOCOEAL);
	}

	private void KGOCCEIIBFE(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.OEMOGCPMIGC == 1)
		{
			Vector3 vector = BMNGEAFPELI.DACNFMFLPDH(1f);
			DPALPIFLHBF = vector - base.transform.position;
		}
	}
}
