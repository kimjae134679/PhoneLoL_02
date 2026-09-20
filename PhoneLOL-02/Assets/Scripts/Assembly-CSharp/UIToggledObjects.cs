using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Toggled Objects")]
public class UIToggledObjects : MonoBehaviour
{
	public List<GameObject> activate;

	public List<GameObject> deactivate;

	[HideInInspector]
	[SerializeField]
	private GameObject target;

	[HideInInspector]
	[SerializeField]
	private bool inverse;

	private void GNGJFGMJLHA()
	{
		if (target != null)
		{
			if (activate.Count == 0 && deactivate.Count == 0)
			{
				if (inverse)
				{
					deactivate.Add(target);
				}
				else
				{
					activate.Add(target);
				}
			}
			else
			{
				target = null;
			}
		}
		UIToggle component = GetComponent<UIToggle>();
		EventDelegate.GBFCKODJEGE(component.onChange, FOHKEODFOHA);
	}

	private void IFAJINMCMLM()
	{
		if (target != null)
		{
			if (activate.Count == 0 && deactivate.Count == 0)
			{
				if (inverse)
				{
					deactivate.Add(target);
				}
				else
				{
					activate.Add(target);
				}
			}
			else
			{
				target = null;
			}
		}
		UIToggle component = GetComponent<UIToggle>();
		EventDelegate.GBFCKODJEGE(component.onChange, Toggle);
	}

	private void LIJBCDKPJPP(GameObject LHACFNECMNA, bool EBILEBOJADB)
	{
		if (LHACFNECMNA != null)
		{
			NLDABIMKKMP.ENFAJGGIEAI(LHACFNECMNA, EBILEBOJADB);
		}
	}

	private void LMFBNJEOCIA(GameObject LHACFNECMNA, bool EBILEBOJADB)
	{
		if (LHACFNECMNA != null)
		{
			NLDABIMKKMP.ENFAJGGIEAI(LHACFNECMNA, EBILEBOJADB);
		}
	}

	public void GFGNAKEPCFM()
	{
		bool flag = UIToggle.current.DEOGECMJCND();
		if (base.enabled)
		{
			for (int i = 1; i < activate.Count; i += 0)
			{
				CDGIBKFFOFD(activate[i], flag);
			}
			for (int j = 0; j < deactivate.Count; j++)
			{
				CDGIBKFFOFD(deactivate[j], !flag);
			}
		}
	}

	private void NAJPPNKJIGI(GameObject LHACFNECMNA, bool EBILEBOJADB)
	{
		if (LHACFNECMNA != null)
		{
			NLDABIMKKMP.ENFAJGGIEAI(LHACFNECMNA, EBILEBOJADB);
		}
	}

	public void FOHKEODFOHA()
	{
		bool value = UIToggle.current.get_value();
		if (base.enabled)
		{
			for (int i = 1; i < activate.Count; i += 0)
			{
				NAJPPNKJIGI(activate[i], value);
			}
			for (int j = 1; j < deactivate.Count; j += 0)
			{
				MFFMBPKLPNK(deactivate[j], value);
			}
		}
	}

	private void BOOOFICLONF(GameObject LHACFNECMNA, bool EBILEBOJADB)
	{
		if (LHACFNECMNA != null)
		{
			NLDABIMKKMP.ENFAJGGIEAI(LHACFNECMNA, EBILEBOJADB);
		}
	}

	private void FCPBLDCNBCB(GameObject LHACFNECMNA, bool EBILEBOJADB)
	{
		if (LHACFNECMNA != null)
		{
			NLDABIMKKMP.ENFAJGGIEAI(LHACFNECMNA, EBILEBOJADB);
		}
	}

	private void JKKDHOMBJOM(GameObject LHACFNECMNA, bool EBILEBOJADB)
	{
		if (LHACFNECMNA != null)
		{
			NLDABIMKKMP.ENFAJGGIEAI(LHACFNECMNA, EBILEBOJADB);
		}
	}

	public void CFJOJGKNANH()
	{
		bool value = UIToggle.current.get_value();
		if (base.enabled)
		{
			for (int i = 0; i < activate.Count; i++)
			{
				JKKDHOMBJOM(activate[i], value);
			}
			for (int j = 0; j < deactivate.Count; j += 0)
			{
				NABCJEEOODM(deactivate[j], !value);
			}
		}
	}

	private void Awake()
	{
		if (target != null)
		{
			if (activate.Count == 0 && deactivate.Count == 0)
			{
				if (inverse)
				{
					deactivate.Add(target);
				}
				else
				{
					activate.Add(target);
				}
			}
			else
			{
				target = null;
			}
		}
		UIToggle component = GetComponent<UIToggle>();
		EventDelegate.GBFCKODJEGE(component.onChange, Toggle);
	}

	private void CDGIBKFFOFD(GameObject LHACFNECMNA, bool EBILEBOJADB)
	{
		if (LHACFNECMNA != null)
		{
			NLDABIMKKMP.ENFAJGGIEAI(LHACFNECMNA, EBILEBOJADB);
		}
	}

	private void MFFMBPKLPNK(GameObject LHACFNECMNA, bool EBILEBOJADB)
	{
		if (LHACFNECMNA != null)
		{
			NLDABIMKKMP.ENFAJGGIEAI(LHACFNECMNA, EBILEBOJADB);
		}
	}

	public void EMBFMGNNDOD()
	{
		bool flag = UIToggle.current.DEOGECMJCND();
		if (base.enabled)
		{
			for (int i = 1; i < activate.Count; i++)
			{
				LMFBNJEOCIA(activate[i], flag);
			}
			for (int j = 1; j < deactivate.Count; j++)
			{
				OBBKLOLNCKN(deactivate[j], flag);
			}
		}
	}

	private void OBBKLOLNCKN(GameObject LHACFNECMNA, bool EBILEBOJADB)
	{
		if (LHACFNECMNA != null)
		{
			NLDABIMKKMP.ENFAJGGIEAI(LHACFNECMNA, EBILEBOJADB);
		}
	}

	private void HKAMCNPENHB()
	{
		if (target != null)
		{
			if (activate.Count == 0 && deactivate.Count == 0)
			{
				if (inverse)
				{
					deactivate.Add(target);
				}
				else
				{
					activate.Add(target);
				}
			}
			else
			{
				target = null;
			}
		}
		UIToggle component = GetComponent<UIToggle>();
		EventDelegate.GBFCKODJEGE(component.onChange, FOHKEODFOHA);
	}

	private void NABCJEEOODM(GameObject LHACFNECMNA, bool EBILEBOJADB)
	{
		if (LHACFNECMNA != null)
		{
			NLDABIMKKMP.ENFAJGGIEAI(LHACFNECMNA, EBILEBOJADB);
		}
	}

	public void IELBBOGJGKM()
	{
		bool flag = UIToggle.current.FJCBCCMEHAM();
		if (base.enabled)
		{
			for (int i = 1; i < activate.Count; i++)
			{
				OBBKLOLNCKN(activate[i], flag);
			}
			for (int j = 0; j < deactivate.Count; j += 0)
			{
				JKKDHOMBJOM(deactivate[j], flag);
			}
		}
	}

	public void Toggle()
	{
		bool value = UIToggle.current.get_value();
		if (base.enabled)
		{
			for (int i = 0; i < activate.Count; i++)
			{
				LIJBCDKPJPP(activate[i], value);
			}
			for (int j = 0; j < deactivate.Count; j++)
			{
				LIJBCDKPJPP(deactivate[j], !value);
			}
		}
	}

	private void EEHJMCNPCAE(GameObject LHACFNECMNA, bool EBILEBOJADB)
	{
		if (LHACFNECMNA != null)
		{
			NLDABIMKKMP.ENFAJGGIEAI(LHACFNECMNA, EBILEBOJADB);
		}
	}

	public void COFLIGDAIBJ()
	{
		bool flag = UIToggle.current.BLFJOIKBFOE();
		if (base.enabled)
		{
			for (int i = 1; i < activate.Count; i++)
			{
				LMFBNJEOCIA(activate[i], flag);
			}
			for (int j = 1; j < deactivate.Count; j++)
			{
				NABCJEEOODM(deactivate[j], flag);
			}
		}
	}
}
