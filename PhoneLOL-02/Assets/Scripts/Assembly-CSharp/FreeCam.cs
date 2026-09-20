using UnityEngine;

public class FreeCam : MonoBehaviour
{
	private float BFIJBHKFDNI;

	private float NKNEDBCNLDF;

	private Camera DDKDLNDJAMA;

	private void DMPIIJNBDID()
	{
		DDKDLNDJAMA = Camera.main;
	}

	private void MGPBNBDGMOJ(NLKIHCFELMK BMNGEAFPELI)
	{
		BFIJBHKFDNI += BMNGEAFPELI.DPALPIFLHBF.x;
		NKNEDBCNLDF += BMNGEAFPELI.DPALPIFLHBF.y;
		DDKDLNDJAMA.transform.localRotation = Quaternion.AngleAxis(BFIJBHKFDNI, Vector3.up);
		DDKDLNDJAMA.transform.localRotation *= Quaternion.AngleAxis(NKNEDBCNLDF, Vector3.left);
	}

	private void BFJPAIGMIFK(NLKIHCFELMK BMNGEAFPELI)
	{
		BFIJBHKFDNI += BMNGEAFPELI.DPALPIFLHBF.x;
		NKNEDBCNLDF += BMNGEAFPELI.DPALPIFLHBF.y;
		DDKDLNDJAMA.transform.localRotation = Quaternion.AngleAxis(BFIJBHKFDNI, Vector3.up);
		DDKDLNDJAMA.transform.localRotation *= Quaternion.AngleAxis(NKNEDBCNLDF, Vector3.left);
	}

	private void ELAEJCKHPEC()
	{
		OODNAKIFPCN();
	}

	private void AMMGAHKHCNE()
	{
		CEMADMOLBJK();
	}

	private void OnDestroy()
	{
		CEMADMOLBJK();
	}

	private void CLLECEEEJAI()
	{
		DDKDLNDJAMA = Camera.main;
	}

	private void OnEnable()
	{
		EasyTouch.add_On_TouchDown(FEOACGMPIOG);
		EasyTouch.add_On_Swipe(BFJPAIGMIFK);
	}

	private void CNLPLGJCBIA()
	{
		OODNAKIFPCN();
	}

	private void ALJEFBEMCFK()
	{
		EasyTouch.add_On_TouchDown(FEOACGMPIOG);
		EasyTouch.add_On_Swipe(MGPBNBDGMOJ);
	}

	private void DJCELGKLDAP()
	{
		EasyTouch.add_On_TouchDown(FMFJJOENCEG);
		EasyTouch.add_On_Swipe(MGPBNBDGMOJ);
	}

	private void OODNAKIFPCN()
	{
		EasyTouch.remove_On_TouchDown(FEOACGMPIOG);
		EasyTouch.remove_On_Swipe(BFJPAIGMIFK);
	}

	private void FEOACGMPIOG(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.OEMOGCPMIGC == 2)
		{
			DDKDLNDJAMA.transform.Translate(new Vector3(0f, 0f, 1f) * Time.deltaTime);
		}
		if (BMNGEAFPELI.OEMOGCPMIGC == 3)
		{
			DDKDLNDJAMA.transform.Translate(new Vector3(0f, 0f, -1f) * Time.deltaTime);
		}
	}

	private void OnDisable()
	{
		CEMADMOLBJK();
	}

	private void NDIEGKILKHF()
	{
		EasyTouch.add_On_TouchDown(FEOACGMPIOG);
		EasyTouch.add_On_Swipe(BFJPAIGMIFK);
	}

	private void FMFJJOENCEG(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.OEMOGCPMIGC == 1)
		{
			DDKDLNDJAMA.transform.Translate(new Vector3(293f, 1118f, 1923f) * Time.deltaTime);
		}
		if (BMNGEAFPELI.OEMOGCPMIGC == 4)
		{
			DDKDLNDJAMA.transform.Translate(new Vector3(1132f, 807f, 1524f) * Time.deltaTime);
		}
	}

	private void CEMADMOLBJK()
	{
		EasyTouch.remove_On_TouchDown(FEOACGMPIOG);
		EasyTouch.remove_On_Swipe(BFJPAIGMIFK);
	}

	private void Start()
	{
		DDKDLNDJAMA = Camera.main;
	}
}
