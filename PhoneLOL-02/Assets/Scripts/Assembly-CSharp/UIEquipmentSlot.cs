using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/UI Equipment Slot")]
public class UIEquipmentSlot : UIItemSlot
{
	public InvEquipment equipment;

	public InvBaseItem.LKHKFHOMLLD slot;

	protected override InvGameItem IJDFFCGIIKC
	{
		get
		{
			return OKFJBLHDOCD();
		}
	}

	[SpecialName]
	protected virtual InvGameItem MCFFEBNEFGO()
	{
		return (!(equipment != null)) ? null : equipment.OBBMEJOKNKJ(slot);
	}

	protected override InvGameItem OKFJBLHDOCD()
	{
		return (!(equipment != null)) ? null : equipment.GetItem(slot);
	}

	protected override InvGameItem DHCPGJEEBAF(InvGameItem HBIPOCDNMCB)
	{
		return (!(equipment != null)) ? HBIPOCDNMCB : equipment.Replace(slot, HBIPOCDNMCB);
	}

	[SpecialName]
	protected virtual InvGameItem PENJGOIANHA()
	{
		return (!(equipment != null)) ? null : equipment.GetItem(slot);
	}

	[SpecialName]
	protected virtual InvGameItem FLMDCJMLPNP()
	{
		return (!(equipment != null)) ? null : equipment.JCHHFNEEAOF(slot);
	}

	[SpecialName]
	protected virtual InvGameItem PLLODIPCDML()
	{
		return (!(equipment != null)) ? null : equipment.OBBMEJOKNKJ(slot);
	}

	[SpecialName]
	protected virtual InvGameItem LOLJBDMAPJF()
	{
		return (!(equipment != null)) ? null : equipment.JCHHFNEEAOF(slot);
	}

	protected virtual InvGameItem CJCCEBCOBIJ(InvGameItem HBIPOCDNMCB)
	{
		return (!(equipment != null)) ? HBIPOCDNMCB : equipment.Replace(slot, HBIPOCDNMCB);
	}

	[SpecialName]
	protected virtual InvGameItem BDCJFDBCKJE()
	{
		return (!(equipment != null)) ? null : equipment.GetItem(slot);
	}

	protected virtual InvGameItem MOLDBNCEGAA(InvGameItem HBIPOCDNMCB)
	{
		return (!(equipment != null)) ? HBIPOCDNMCB : equipment.GLNGLBIAAAG(slot, HBIPOCDNMCB);
	}

	protected virtual InvGameItem EHIAEBGLAGD(InvGameItem HBIPOCDNMCB)
	{
		return (!(equipment != null)) ? HBIPOCDNMCB : equipment.GLNGLBIAAAG(slot, HBIPOCDNMCB);
	}

	protected virtual InvGameItem KCCCGMNOLDK(InvGameItem HBIPOCDNMCB)
	{
		return (!(equipment != null)) ? HBIPOCDNMCB : equipment.BDMJNCBJLOB(slot, HBIPOCDNMCB);
	}

	protected virtual InvGameItem POCPNHIPJIO(InvGameItem HBIPOCDNMCB)
	{
		return (!(equipment != null)) ? HBIPOCDNMCB : equipment.GLNGLBIAAAG(slot, HBIPOCDNMCB);
	}
}
