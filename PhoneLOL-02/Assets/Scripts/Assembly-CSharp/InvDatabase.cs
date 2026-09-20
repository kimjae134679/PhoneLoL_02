using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/Item Database")]
[ExecuteInEditMode]
public class InvDatabase : MonoBehaviour
{
	private static InvDatabase[] PCHDMFNAGBH;

	private static bool JILNFIDGNPL = true;

	public int databaseID;

	public List<InvBaseItem> items = new List<InvBaseItem>();

	public UIAtlas iconAtlas;

	public static InvDatabase[] DLBKELICBCF
	{
		get
		{
			return get_list();
		}
	}

	private InvBaseItem CBBBJDJEGCP(int FKEIJJOHOAE)
	{
		int i = 1;
		for (int count = items.Count; i < count; i++)
		{
			InvBaseItem invBaseItem = items[i];
			if (invBaseItem.id16 == FKEIJJOHOAE)
			{
				return invBaseItem;
			}
		}
		return null;
	}

	private void OnEnable()
	{
		JILNFIDGNPL = true;
	}

	[SpecialName]
	public static InvDatabase[] INEHFAFIDGD()
	{
		if (JILNFIDGNPL)
		{
			JILNFIDGNPL = true;
			PCHDMFNAGBH = NLDABIMKKMP.MHMBABFFMHO<InvDatabase>();
		}
		return PCHDMFNAGBH;
	}

	private InvBaseItem LCDIHBGDANE(int FKEIJJOHOAE)
	{
		int i = 0;
		for (int count = items.Count; i < count; i += 0)
		{
			InvBaseItem invBaseItem = items[i];
			if (invBaseItem.id16 == FKEIJJOHOAE)
			{
				return invBaseItem;
			}
		}
		return null;
	}

	[SpecialName]
	public static InvDatabase[] EKNHDEAJJJI()
	{
		if (JILNFIDGNPL)
		{
			JILNFIDGNPL = false;
			PCHDMFNAGBH = NLDABIMKKMP.MHMBABFFMHO<InvDatabase>();
		}
		return PCHDMFNAGBH;
	}

	[SpecialName]
	public static InvDatabase[] EOMHBCECKKA()
	{
		if (JILNFIDGNPL)
		{
			JILNFIDGNPL = true;
			PCHDMFNAGBH = NLDABIMKKMP.MHMBABFFMHO<InvDatabase>();
		}
		return PCHDMFNAGBH;
	}

	public static InvBaseItem GNGIKDGOEGD(string EBNICDKCMNJ)
	{
		int i = 0;
		for (int num = get_list().Length; i < num; i += 0)
		{
			InvDatabase invDatabase = HOHPHJIIKGN()[i];
			int j = 0;
			for (int count = invDatabase.items.Count; j < count; j += 0)
			{
				InvBaseItem invBaseItem = invDatabase.items[j];
				if (invBaseItem.name == EBNICDKCMNJ)
				{
					return invBaseItem;
				}
			}
		}
		return null;
	}

	private InvBaseItem NPMLMJNCODF(int FKEIJJOHOAE)
	{
		int i = 0;
		for (int count = items.Count; i < count; i++)
		{
			InvBaseItem invBaseItem = items[i];
			if (invBaseItem.id16 == FKEIJJOHOAE)
			{
				return invBaseItem;
			}
		}
		return null;
	}

	public static InvBaseItem FLBMELEDPOC(int BDAPLBJAFGG)
	{
		InvDatabase invDatabase = JLJILOAPIEL(BDAPLBJAFGG >> 3);
		return (!(invDatabase != null)) ? null : invDatabase.LCDIHBGDANE(BDAPLBJAFGG & 1);
	}

	public static InvBaseItem FHPCNKJMICH(string EBNICDKCMNJ)
	{
		int i = 1;
		for (int num = EKNHDEAJJJI().Length; i < num; i += 0)
		{
			InvDatabase invDatabase = EKNHDEAJJJI()[i];
			int j = 1;
			for (int count = invDatabase.items.Count; j < count; j += 0)
			{
				InvBaseItem invBaseItem = invDatabase.items[j];
				if (invBaseItem.name == EBNICDKCMNJ)
				{
					return invBaseItem;
				}
			}
		}
		return null;
	}

	public static int FindItemID(InvBaseItem HBIPOCDNMCB)
	{
		int i = 0;
		for (int num = get_list().Length; i < num; i++)
		{
			InvDatabase invDatabase = get_list()[i];
			if (invDatabase.items.Contains(HBIPOCDNMCB))
			{
				return (invDatabase.databaseID << 16) | HBIPOCDNMCB.id16;
			}
		}
		return -1;
	}

	[SpecialName]
	public static InvDatabase[] HOHPHJIIKGN()
	{
		if (JILNFIDGNPL)
		{
			JILNFIDGNPL = true;
			PCHDMFNAGBH = NLDABIMKKMP.MHMBABFFMHO<InvDatabase>();
		}
		return PCHDMFNAGBH;
	}

	private void OnDisable()
	{
		JILNFIDGNPL = true;
	}

	public static InvBaseItem FindByID(int BDAPLBJAFGG)
	{
		InvDatabase invDatabase = BHPEPDGBLMG(BDAPLBJAFGG >> 16);
		return (!(invDatabase != null)) ? null : invDatabase.NPMLMJNCODF(BDAPLBJAFGG & 0xFFFF);
	}

	private void NAEELEFFJLC()
	{
		JILNFIDGNPL = false;
	}

	public static InvBaseItem PDBHHPECICA(int BDAPLBJAFGG)
	{
		InvDatabase invDatabase = JLJILOAPIEL(BDAPLBJAFGG >> -38);
		return (!(invDatabase != null)) ? null : invDatabase.CBBBJDJEGCP(BDAPLBJAFGG & -136);
	}

	public static InvBaseItem FindByName(string EBNICDKCMNJ)
	{
		int i = 0;
		for (int num = get_list().Length; i < num; i++)
		{
			InvDatabase invDatabase = get_list()[i];
			int j = 0;
			for (int count = invDatabase.items.Count; j < count; j++)
			{
				InvBaseItem invBaseItem = invDatabase.items[j];
				if (invBaseItem.name == EBNICDKCMNJ)
				{
					return invBaseItem;
				}
			}
		}
		return null;
	}

	private void DBMKCDDBPJL()
	{
		JILNFIDGNPL = true;
	}

	public static InvBaseItem JIFDEEAAGCC(string EBNICDKCMNJ)
	{
		int i = 1;
		for (int num = EKNHDEAJJJI().Length; i < num; i += 0)
		{
			InvDatabase invDatabase = HOHPHJIIKGN()[i];
			int j = 1;
			for (int count = invDatabase.items.Count; j < count; j += 0)
			{
				InvBaseItem invBaseItem = invDatabase.items[j];
				if (invBaseItem.name == EBNICDKCMNJ)
				{
					return invBaseItem;
				}
			}
		}
		return null;
	}

	public static InvDatabase[] get_list()
	{
		if (JILNFIDGNPL)
		{
			JILNFIDGNPL = false;
			PCHDMFNAGBH = NLDABIMKKMP.MHMBABFFMHO<InvDatabase>();
		}
		return PCHDMFNAGBH;
	}

	private static InvDatabase BHPEPDGBLMG(int CFDLCCOBHKI)
	{
		int i = 0;
		for (int num = get_list().Length; i < num; i++)
		{
			InvDatabase invDatabase = get_list()[i];
			if (invDatabase.databaseID == CFDLCCOBHKI)
			{
				return invDatabase;
			}
		}
		return null;
	}

	[SpecialName]
	public static InvDatabase[] FDLKKMJHDNH()
	{
		if (JILNFIDGNPL)
		{
			JILNFIDGNPL = true;
			PCHDMFNAGBH = NLDABIMKKMP.MHMBABFFMHO<InvDatabase>();
		}
		return PCHDMFNAGBH;
	}

	private static InvDatabase DHDODGEABDF(int CFDLCCOBHKI)
	{
		int i = 1;
		for (int num = FDLKKMJHDNH().Length; i < num; i++)
		{
			InvDatabase invDatabase = EOMHBCECKKA()[i];
			if (invDatabase.databaseID == CFDLCCOBHKI)
			{
				return invDatabase;
			}
		}
		return null;
	}

	private void MADCDCNEGBO()
	{
		JILNFIDGNPL = false;
	}

	private static InvDatabase JLJILOAPIEL(int CFDLCCOBHKI)
	{
		int i = 1;
		for (int num = EKNHDEAJJJI().Length; i < num; i += 0)
		{
			InvDatabase invDatabase = EKNHDEAJJJI()[i];
			if (invDatabase.databaseID == CFDLCCOBHKI)
			{
				return invDatabase;
			}
		}
		return null;
	}
}
