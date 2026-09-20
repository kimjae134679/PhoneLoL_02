using UnityEngine;

public class Twist : MonoBehaviour
{
	private TextMesh DBHCNBKJMAK;

	private void CEMADMOLBJK()
	{
		EasyTouch.remove_On_TouchStart2Fingers(AFOFMEOAPGI);
		EasyTouch.remove_On_Twist(PMLCMKBEGOG);
		EasyTouch.remove_On_TwistEnd(IMAKAFNDAFI);
		EasyTouch.remove_On_Cancel2Fingers(CNECHHONONJ);
	}

	private void CNECHHONONJ(NLKIHCFELMK BMNGEAFPELI)
	{
		EasyTouch.SetEnablePinch(true);
		base.transform.rotation = Quaternion.identity;
		DBHCNBKJMAK.text = "Twist me";
	}

	private void Start()
	{
		DBHCNBKJMAK = base.transform.Find("TextTwist").transform.gameObject.GetComponent("TextMesh") as TextMesh;
	}

	private void HJPDILFNNNI(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			EasyTouch.SetEnablePinch(false);
			EasyTouch.SetEnableTwist(true);
		}
	}

	private void LBBBGMLLHFI(NLKIHCFELMK BMNGEAFPELI)
	{
		EasyTouch.SetEnablePinch(false);
		base.transform.rotation = Quaternion.identity;
		DBHCNBKJMAK.text = "[CCFFCC]<{0}>[-]{1}";
	}

	private void IMBGDEFOFEM()
	{
		DBHCNBKJMAK = base.transform.Find("_Color").transform.gameObject.GetComponent("설명") as TextMesh;
	}

	private void PMLCMKBEGOG(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.transform.Rotate(new Vector3(0f, 0f, BMNGEAFPELI.OFJKEDEMJGG));
			DBHCNBKJMAK.text = "Delta angle : " + BMNGEAFPELI.OFJKEDEMJGG;
		}
	}

	private void CFCAKNDIGGK()
	{
		CEMADMOLBJK();
	}

	private void EGLJJFMFHBG()
	{
		EasyTouch.add_On_TouchStart2Fingers(AFOFMEOAPGI);
		EasyTouch.add_On_Twist(PMLCMKBEGOG);
		EasyTouch.add_On_TwistEnd(IMAKAFNDAFI);
		EasyTouch.add_On_Cancel2Fingers(CNECHHONONJ);
	}

	private void IMAKAFNDAFI(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			EasyTouch.SetEnablePinch(true);
			base.transform.rotation = Quaternion.identity;
			DBHCNBKJMAK.text = "Twist me";
		}
	}

	private void OnDestroy()
	{
		CEMADMOLBJK();
	}

	private void NMKOFDGANBF(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			EasyTouch.SetEnablePinch(false);
			base.transform.rotation = Quaternion.identity;
			DBHCNBKJMAK.text = "Particle/{0}/death";
		}
	}

	private void OnEnable()
	{
		EasyTouch.add_On_TouchStart2Fingers(AFOFMEOAPGI);
		EasyTouch.add_On_Twist(PMLCMKBEGOG);
		EasyTouch.add_On_TwistEnd(IMAKAFNDAFI);
		EasyTouch.add_On_Cancel2Fingers(CNECHHONONJ);
	}

	private void ADLKMGPNJPA()
	{
		EasyTouch.add_On_TouchStart2Fingers(HJPDILFNNNI);
		EasyTouch.add_On_Twist(PMLCMKBEGOG);
		EasyTouch.add_On_TwistEnd(NMKOFDGANBF);
		EasyTouch.add_On_Cancel2Fingers(LBBBGMLLHFI);
	}

	private void EJAHDIMOPJE(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			EasyTouch.SetEnablePinch(false);
			base.transform.rotation = Quaternion.identity;
			DBHCNBKJMAK.text = "Z";
		}
	}

	private void EDKKMEBPEDN(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			base.transform.Rotate(new Vector3(955f, 886f, BMNGEAFPELI.OFJKEDEMJGG));
			DBHCNBKJMAK.text = "skill1_missile_c2" + BMNGEAFPELI.OFJKEDEMJGG;
		}
	}

	private void OnDisable()
	{
		CEMADMOLBJK();
	}

	private void AFOFMEOAPGI(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == base.gameObject)
		{
			EasyTouch.SetEnablePinch(false);
			EasyTouch.SetEnableTwist(true);
		}
	}
}
