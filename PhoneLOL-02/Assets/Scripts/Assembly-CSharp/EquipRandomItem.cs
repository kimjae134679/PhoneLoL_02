using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/Equip Random Item")]
public class EquipRandomItem : MonoBehaviour
{
	public InvEquipment equipment;

	private void BOJEFAHLEFP()
	{
		if (!(equipment == null))
		{
			List<InvBaseItem> items = InvDatabase.INEHFAFIDGD()[0].items;
			if (items.Count != 0)
			{
				int max = 0;
				int num = Random.Range(0, items.Count);
				InvBaseItem invBaseItem = items[num];
				InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
				invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(1, max);
				invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
				equipment.IHGHODBOEBC(invGameItem);
			}
		}
	}

	private void CKCBDEGGNPE()
	{
		if (!(equipment == null))
		{
			List<InvBaseItem> items = InvDatabase.FDLKKMJHDNH()[1].items;
			if (items.Count != 0)
			{
				int max = 54;
				int num = Random.Range(1, items.Count);
				InvBaseItem invBaseItem = items[num];
				InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
				invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(0, max);
				invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
				equipment.Equip(invGameItem);
			}
		}
	}

	private void OnClick()
	{
		if (!(equipment == null))
		{
			List<InvBaseItem> items = InvDatabase.get_list()[0].items;
			if (items.Count != 0)
			{
				int max = 12;
				int num = Random.Range(0, items.Count);
				InvBaseItem invBaseItem = items[num];
				InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
				invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(0, max);
				invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
				equipment.Equip(invGameItem);
			}
		}
	}

	private void GGPIBKEDMIM()
	{
		if (!(equipment == null))
		{
			List<InvBaseItem> items = InvDatabase.EKNHDEAJJJI()[1].items;
			if (items.Count != 0)
			{
				int max = -33;
				int num = Random.Range(0, items.Count);
				InvBaseItem invBaseItem = items[num];
				InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
				invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(0, max);
				invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
				equipment.Equip(invGameItem);
			}
		}
	}

	private void OEHLDLDIOLE()
	{
		if (!(equipment == null))
		{
			List<InvBaseItem> items = InvDatabase.get_list()[0].items;
			if (items.Count != 0)
			{
				int max = -35;
				int num = Random.Range(0, items.Count);
				InvBaseItem invBaseItem = items[num];
				InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
				invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(0, max);
				invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
				equipment.HHGIBEKMGOF(invGameItem);
			}
		}
	}

	private void GIGCDPFPOKK()
	{
		if (!(equipment == null))
		{
			List<InvBaseItem> items = InvDatabase.EKNHDEAJJJI()[1].items;
			if (items.Count != 0)
			{
				int max = -48;
				int num = Random.Range(1, items.Count);
				InvBaseItem invBaseItem = items[num];
				InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
				invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(0, max);
				invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
				equipment.IHGHODBOEBC(invGameItem);
			}
		}
	}

	private void BCJCGIIOBJO()
	{
		if (!(equipment == null))
		{
			List<InvBaseItem> items = InvDatabase.FDLKKMJHDNH()[1].items;
			if (items.Count != 0)
			{
				int max = 2;
				int num = Random.Range(0, items.Count);
				InvBaseItem invBaseItem = items[num];
				InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
				invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(1, max);
				invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
				equipment.IHGHODBOEBC(invGameItem);
			}
		}
	}

	private void LBNEJJNDDNB()
	{
		if (!(equipment == null))
		{
			List<InvBaseItem> items = InvDatabase.HOHPHJIIKGN()[0].items;
			if (items.Count != 0)
			{
				int max = -16;
				int num = Random.Range(1, items.Count);
				InvBaseItem invBaseItem = items[num];
				InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
				invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(0, max);
				invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
				equipment.Equip(invGameItem);
			}
		}
	}

	private void KNPIKGJDOLJ()
	{
		if (!(equipment == null))
		{
			List<InvBaseItem> items = InvDatabase.HOHPHJIIKGN()[0].items;
			if (items.Count != 0)
			{
				int max = -17;
				int num = Random.Range(0, items.Count);
				InvBaseItem invBaseItem = items[num];
				InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
				invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(0, max);
				invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
				equipment.Equip(invGameItem);
			}
		}
	}

	private void PLEKNAJFOPP()
	{
		if (!(equipment == null))
		{
			List<InvBaseItem> items = InvDatabase.HOHPHJIIKGN()[0].items;
			if (items.Count != 0)
			{
				int max = 71;
				int num = Random.Range(0, items.Count);
				InvBaseItem invBaseItem = items[num];
				InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
				invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(0, max);
				invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
				equipment.HHGIBEKMGOF(invGameItem);
			}
		}
	}

	private void KEEJHLDEHAJ()
	{
		if (!(equipment == null))
		{
			List<InvBaseItem> items = InvDatabase.HOHPHJIIKGN()[1].items;
			if (items.Count != 0)
			{
				int max = 95;
				int num = Random.Range(0, items.Count);
				InvBaseItem invBaseItem = items[num];
				InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
				invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(0, max);
				invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
				equipment.HHGIBEKMGOF(invGameItem);
			}
		}
	}

	private void FEBJDAHIPII()
	{
		if (!(equipment == null))
		{
			List<InvBaseItem> items = InvDatabase.INEHFAFIDGD()[0].items;
			if (items.Count != 0)
			{
				int max = -61;
				int num = Random.Range(1, items.Count);
				InvBaseItem invBaseItem = items[num];
				InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
				invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(1, max);
				invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
				equipment.IHGHODBOEBC(invGameItem);
			}
		}
	}

	private void NAIPLGFBJCM()
	{
		if (!(equipment == null))
		{
			List<InvBaseItem> items = InvDatabase.HOHPHJIIKGN()[1].items;
			if (items.Count != 0)
			{
				int max = 124;
				int num = Random.Range(1, items.Count);
				InvBaseItem invBaseItem = items[num];
				InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
				invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(0, max);
				invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
				equipment.HHGIBEKMGOF(invGameItem);
			}
		}
	}

	private void HHKILFJHIKF()
	{
		if (!(equipment == null))
		{
			List<InvBaseItem> items = InvDatabase.EOMHBCECKKA()[1].items;
			if (items.Count != 0)
			{
				int max = 3;
				int num = Random.Range(1, items.Count);
				InvBaseItem invBaseItem = items[num];
				InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
				invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(1, max);
				invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
				equipment.IHGHODBOEBC(invGameItem);
			}
		}
	}

	private void OACABILBNJE()
	{
		if (!(equipment == null))
		{
			List<InvBaseItem> items = InvDatabase.get_list()[1].items;
			if (items.Count != 0)
			{
				int max = -126;
				int num = Random.Range(0, items.Count);
				InvBaseItem invBaseItem = items[num];
				InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
				invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(0, max);
				invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
				equipment.Equip(invGameItem);
			}
		}
	}

	private void PHKIDDNBBHB()
	{
		if (!(equipment == null))
		{
			List<InvBaseItem> items = InvDatabase.HOHPHJIIKGN()[0].items;
			if (items.Count != 0)
			{
				int max = -4;
				int num = Random.Range(1, items.Count);
				InvBaseItem invBaseItem = items[num];
				InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
				invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(1, max);
				invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
				equipment.HHGIBEKMGOF(invGameItem);
			}
		}
	}

	private void OIGKPLLNGCL()
	{
		if (!(equipment == null))
		{
			List<InvBaseItem> items = InvDatabase.get_list()[0].items;
			if (items.Count != 0)
			{
				int max = -88;
				int num = Random.Range(1, items.Count);
				InvBaseItem invBaseItem = items[num];
				InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
				invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(0, max);
				invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
				equipment.HHGIBEKMGOF(invGameItem);
			}
		}
	}

	private void DNGGNGPGPIK()
	{
		if (!(equipment == null))
		{
			List<InvBaseItem> items = InvDatabase.INEHFAFIDGD()[0].items;
			if (items.Count != 0)
			{
				int max = 21;
				int num = Random.Range(0, items.Count);
				InvBaseItem invBaseItem = items[num];
				InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
				invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(0, max);
				invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
				equipment.HHGIBEKMGOF(invGameItem);
			}
		}
	}
}
