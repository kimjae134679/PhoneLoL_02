using System.Runtime.CompilerServices;
using UnityEngine;

public class UICostumeShopItem : MonoBehaviour
{
	private UISprite DKMPKBBNANF;

	private ushort FKNAHDHLPKD;

	public ushort PBEOOJJNPCN
	{
		get
		{
			return get_m_itemID();
		}
		protected set
		{
			EKNHDOIKPMP(value);
		}
	}

	public void EINNCAEHIFE(ushort CDLJHFICDDI)
	{
		EKNHDOIKPMP(CDLJHFICDDI);
		DKMPKBBNANF.set_spriteName(JIDDADAAEFO().ToString());
	}

	public void CBMCDGCDGLA(UIToggle DEBPDDIJKDH)
	{
		if (!DEBPDDIJKDH.GDJOHLLAOOK())
		{
		}
	}

	protected void EKNHDOIKPMP(ushort ICENKPDOHBK)
	{
		FKNAHDHLPKD = ICENKPDOHBK;
	}

	[SpecialName]
	public ushort JIDDADAAEFO()
	{
		return FKNAHDHLPKD;
	}

	private void Update()
	{
	}

	public void DOHBFGODMDM(ushort CDLJHFICDDI)
	{
		CJKONIHOOPI(CDLJHFICDDI);
		DKMPKBBNANF.set_spriteName(PNMPBGINLML().ToString());
	}

	private void PCFCEAOOAEE()
	{
		DKMPKBBNANF = GetComponent<UISprite>();
	}

	public void HHLNKPKIANJ(UIToggle DEBPDDIJKDH)
	{
		if (!DEBPDDIJKDH.JOBICLFDKBD())
		{
		}
	}

	private void MLOKLGPGKMO()
	{
	}

	[SpecialName]
	public ushort FMDOBLGOEHG()
	{
		return FKNAHDHLPKD;
	}

	public void LMJOANHHCHI(ushort CDLJHFICDDI)
	{
		CJKONIHOOPI(CDLJHFICDDI);
		DKMPKBBNANF.set_spriteName(PNMPBGINLML().ToString());
	}

	public void SetInfo(ushort CDLJHFICDDI)
	{
		EKNHDOIKPMP(CDLJHFICDDI);
		DKMPKBBNANF.set_spriteName(get_m_itemID().ToString());
	}

	public ushort get_m_itemID()
	{
		return FKNAHDHLPKD;
	}

	private void Awake()
	{
		DKMPKBBNANF = GetComponent<UISprite>();
	}

	private void ENAGFDFCLCC()
	{
		DKMPKBBNANF = GetComponent<UISprite>();
	}

	private void FONPAFKDMCG()
	{
		DKMPKBBNANF = GetComponent<UISprite>();
	}

	[SpecialName]
	protected void CJKONIHOOPI(ushort ICENKPDOHBK)
	{
		FKNAHDHLPKD = ICENKPDOHBK;
	}

	public void DFOCLGJGFEF(UIToggle DEBPDDIJKDH)
	{
		if (!DEBPDDIJKDH.DEOGECMJCND())
		{
		}
	}

	[SpecialName]
	public ushort PNMPBGINLML()
	{
		return FKNAHDHLPKD;
	}

	private void ACBGKIDKKKM()
	{
	}

	public void BLGBBMLNAMA(ushort CDLJHFICDDI)
	{
		CJKONIHOOPI(CDLJHFICDDI);
		DKMPKBBNANF.set_spriteName(JIDDADAAEFO().ToString());
	}

	public void OnChange(UIToggle DEBPDDIJKDH)
	{
		if (!DEBPDDIJKDH.get_value())
		{
		}
	}

	public void BHAMHNJNALK(UIToggle DEBPDDIJKDH)
	{
		if (!DEBPDDIJKDH.get_value())
		{
		}
	}
}
