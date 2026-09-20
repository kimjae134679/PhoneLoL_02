using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/UI Storage Slot")]
public class UIStorageSlot : UIItemSlot
{
	public UIItemStorage storage;

	public int slot;

	protected override InvGameItem IJDFFCGIIKC
	{
		get
		{
			return OKFJBLHDOCD();
		}
	}

	protected virtual InvGameItem GLNGLBIAAAG(InvGameItem HBIPOCDNMCB)
	{
		return (!(storage != null)) ? HBIPOCDNMCB : storage.BHFAGJNAHAM(slot, HBIPOCDNMCB);
	}

	protected virtual InvGameItem LEEJJMKOOEN(InvGameItem HBIPOCDNMCB)
	{
		return (!(storage != null)) ? HBIPOCDNMCB : storage.BHHEDCLPFHI(slot, HBIPOCDNMCB);
	}

	protected virtual InvGameItem CPGMGPGNCCD(InvGameItem HBIPOCDNMCB)
	{
		return (!(storage != null)) ? HBIPOCDNMCB : storage.BHFAGJNAHAM(slot, HBIPOCDNMCB);
	}

	protected override InvGameItem OKFJBLHDOCD()
	{
		return (!(storage != null)) ? null : storage.GetItem(slot);
	}

	protected virtual InvGameItem OPKDMNHDPBN(InvGameItem HBIPOCDNMCB)
	{
		return (!(storage != null)) ? HBIPOCDNMCB : storage.JHJEBBIAEGA(slot, HBIPOCDNMCB);
	}

	protected virtual InvGameItem KAFPMCDFDJD(InvGameItem HBIPOCDNMCB)
	{
		return (!(storage != null)) ? HBIPOCDNMCB : storage.MOLDBNCEGAA(slot, HBIPOCDNMCB);
	}

	[SpecialName]
	protected virtual InvGameItem BDCJFDBCKJE()
	{
		return (!(storage != null)) ? null : storage.KEHENJKBHKP(slot);
	}

	protected virtual InvGameItem BDMJNCBJLOB(InvGameItem HBIPOCDNMCB)
	{
		return (!(storage != null)) ? HBIPOCDNMCB : storage.BHFAGJNAHAM(slot, HBIPOCDNMCB);
	}

	[SpecialName]
	protected virtual InvGameItem AHIAPJPEMJL()
	{
		return (!(storage != null)) ? null : storage.GetItem(slot);
	}

	[SpecialName]
	protected virtual InvGameItem EFEKLEJFAOC()
	{
		return (!(storage != null)) ? null : storage.JHKDBBEOBCO(slot);
	}

	protected virtual InvGameItem KCCCGMNOLDK(InvGameItem HBIPOCDNMCB)
	{
		return (!(storage != null)) ? HBIPOCDNMCB : storage.MOLDBNCEGAA(slot, HBIPOCDNMCB);
	}

	[SpecialName]
	protected virtual InvGameItem EGLEDEAPCMN()
	{
		return (!(storage != null)) ? null : storage.COGFCGDAMLF(slot);
	}

	protected override InvGameItem DHCPGJEEBAF(InvGameItem HBIPOCDNMCB)
	{
		return (!(storage != null)) ? HBIPOCDNMCB : storage.Replace(slot, HBIPOCDNMCB);
	}

	[SpecialName]
	protected virtual InvGameItem AHLCMFIKHMP()
	{
		return (!(storage != null)) ? null : storage.GetItem(slot);
	}

	protected virtual InvGameItem JKBOHKHEOKA(InvGameItem HBIPOCDNMCB)
	{
		return (!(storage != null)) ? HBIPOCDNMCB : storage.BHFAGJNAHAM(slot, HBIPOCDNMCB);
	}

	protected virtual InvGameItem BPGJDLKKLON(InvGameItem HBIPOCDNMCB)
	{
		return (!(storage != null)) ? HBIPOCDNMCB : storage.BHFAGJNAHAM(slot, HBIPOCDNMCB);
	}

	protected virtual InvGameItem MJKNBAECLGL(InvGameItem HBIPOCDNMCB)
	{
		return (!(storage != null)) ? HBIPOCDNMCB : storage.BHFAGJNAHAM(slot, HBIPOCDNMCB);
	}

	[SpecialName]
	protected virtual InvGameItem KANHAFKBJPK()
	{
		return (!(storage != null)) ? null : storage.GetItem(slot);
	}

	protected virtual InvGameItem JHJEBBIAEGA(InvGameItem HBIPOCDNMCB)
	{
		return (!(storage != null)) ? HBIPOCDNMCB : storage.BHFAGJNAHAM(slot, HBIPOCDNMCB);
	}

	[SpecialName]
	protected virtual InvGameItem PLLODIPCDML()
	{
		return (!(storage != null)) ? null : storage.JHKDBBEOBCO(slot);
	}
}
