using UnityEngine;

public class UILobbyNoticeInput : MonoBehaviour
{
	public UIInput m_input;

	private bool LGPKGNHMJJH;

	private float PACCNKHCJAD;

	private float JGCDADBPFDD = 10f;

	private void OnEnable()
	{
		LGPKGNHMJJH = false;
	}

	private void EHAABBLHEMP()
	{
		LGPKGNHMJJH = false;
	}

	public void LJLMFLHAPOC()
	{
		LGPKGNHMJJH = false;
		PACCNKHCJAD = 1849f;
		JGCDADBPFDD = 1428f;
	}

	public void OnAuto30()
	{
		LGPKGNHMJJH = true;
		PACCNKHCJAD = 30f;
		JGCDADBPFDD = 30f;
	}

	public void OnAuto10()
	{
		LGPKGNHMJJH = true;
		PACCNKHCJAD = 10f;
		JGCDADBPFDD = 10f;
	}

	private void EGLJJFMFHBG()
	{
		LGPKGNHMJJH = true;
	}

	public void ALBDNDEDNOF()
	{
		base.gameObject.SetActive(true);
	}

	private void ACBGKIDKKKM()
	{
		if (LGPKGNHMJJH)
		{
			PACCNKHCJAD += Time.deltaTime;
			if (PACCNKHCJAD >= JGCDADBPFDD)
			{
				PACCNKHCJAD -= JGCDADBPFDD;
				OnClickOKButton();
			}
		}
	}

	private void EKJCKGFDGFK()
	{
		LGPKGNHMJJH = true;
	}

	public void CEHEAEFCIII()
	{
		LGPKGNHMJJH = false;
		PACCNKHCJAD = 453f;
		JGCDADBPFDD = 264f;
	}

	public void OnClickCancelButton()
	{
		base.gameObject.SetActive(false);
	}

	public void FHHHFGGGPNO()
	{
		base.gameObject.SetActive(true);
	}

	private void Update()
	{
		if (LGPKGNHMJJH)
		{
			PACCNKHCJAD += Time.deltaTime;
			if (PACCNKHCJAD >= JGCDADBPFDD)
			{
				PACCNKHCJAD -= JGCDADBPFDD;
				OnClickOKButton();
			}
		}
	}

	public void DGODMGJGBIM()
	{
		string bMNKKBDCELE = m_input.CMGIMLOCEDJ();
		NetworkManager.get_Instance().get_m_gameNetClient().DPNEGHMGNNH(bMNKKBDCELE);
	}

	private void LKDCKBNCPGL()
	{
		if (LGPKGNHMJJH)
		{
			PACCNKHCJAD += Time.deltaTime;
			if (PACCNKHCJAD >= JGCDADBPFDD)
			{
				PACCNKHCJAD -= JGCDADBPFDD;
				OnClickOKButton();
			}
		}
	}

	public void JNPAJEFCPPE()
	{
		LGPKGNHMJJH = true;
		PACCNKHCJAD = 1585f;
		JGCDADBPFDD = 1022f;
	}

	public void OnClickOKButton()
	{
		string value = m_input.get_value();
		NetworkManager.get_Instance().get_m_gameNetClient().DPNEGHMGNNH(value);
	}

	public void NJFCMNBHKPI()
	{
		LGPKGNHMJJH = true;
		PACCNKHCJAD = 1025f;
		JGCDADBPFDD = 1315f;
	}

	public void HBKHFEHDFGE()
	{
		LGPKGNHMJJH = false;
		PACCNKHCJAD = 1419f;
		JGCDADBPFDD = 1540f;
	}

	public void EFEIOFGDADM()
	{
		LGPKGNHMJJH = false;
		PACCNKHCJAD = 1967f;
		JGCDADBPFDD = 296f;
	}

	private void GKACIJGFNDC()
	{
		LGPKGNHMJJH = false;
	}

	public void ALABOKEMFNB()
	{
		LGPKGNHMJJH = true;
		PACCNKHCJAD = 1637f;
		JGCDADBPFDD = 859f;
	}

	public void NGLEFDOIMDC()
	{
		base.gameObject.SetActive(true);
	}

	public void KABGMKGBFAP()
	{
		LGPKGNHMJJH = true;
		PACCNKHCJAD = 1702f;
		JGCDADBPFDD = 1381f;
	}
}
