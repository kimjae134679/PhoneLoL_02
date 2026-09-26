using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class InvGameItem
{
	public enum PCHDFKEGPMO
	{
		Broken = 0,
		Cursed = 1,
		Damaged = 2,
		Worn = 3,
		Sturdy = 4,
		Polished = 5,
		Improved = 6,
		Crafted = 7,
		Superior = 8,
		Enchanted = 9,
		Epic = 10,
		Legendary = 11,
		_LastDoNotUse = 12
	}

	[SerializeField]
	private int mBaseItemID;

	public PCHDFKEGPMO quality = PCHDFKEGPMO.Sturdy;

	public int itemLevel = 1;

	private InvBaseItem mBaseItem;

	public int baseItemID
	{
		get
		{
			return mBaseItemID;
		}
	}

	public InvBaseItem baseItem
	{
		get
		{
			if (mBaseItem == null)
			{
				mBaseItem = InvDatabase.FindByID(baseItemID);
			}
			return mBaseItem;
		}
	}

	public string name
	{
		get
		{
			if (baseItem == null)
			{
				return null;
			}
			return quality.ToString() + " " + baseItem.name;
		}
	}

	public float statMultiplier
	{
		get
		{
			float num = 0f;
			switch (quality)
			{
			case PCHDFKEGPMO.Cursed:
				num = -1f;
				break;
			case PCHDFKEGPMO.Broken:
				num = 0f;
				break;
			case PCHDFKEGPMO.Damaged:
				num = 0.25f;
				break;
			case PCHDFKEGPMO.Worn:
				num = 0.9f;
				break;
			case PCHDFKEGPMO.Sturdy:
				num = 1f;
				break;
			case PCHDFKEGPMO.Polished:
				num = 1.1f;
				break;
			case PCHDFKEGPMO.Improved:
				num = 1.25f;
				break;
			case PCHDFKEGPMO.Crafted:
				num = 1.5f;
				break;
			case PCHDFKEGPMO.Superior:
				num = 1.75f;
				break;
			case PCHDFKEGPMO.Enchanted:
				num = 2f;
				break;
			case PCHDFKEGPMO.Epic:
				num = 2.5f;
				break;
			case PCHDFKEGPMO.Legendary:
				num = 3f;
				break;
			}
			float num2 = (float)itemLevel / 50f;
			return num * Mathf.Lerp(num2, num2 * num2, 0.5f);
		}
	}

	public Color color
	{
		get
		{
			Color result = Color.white;
			switch (quality)
			{
			case PCHDFKEGPMO.Cursed:
				result = Color.red;
				break;
			case PCHDFKEGPMO.Broken:
				result = new Color(0.4f, 0.2f, 0.2f);
				break;
			case PCHDFKEGPMO.Damaged:
				result = new Color(0.4f, 0.4f, 0.4f);
				break;
			case PCHDFKEGPMO.Worn:
				result = new Color(0.7f, 0.7f, 0.7f);
				break;
			case PCHDFKEGPMO.Sturdy:
				result = new Color(1f, 1f, 1f);
				break;
			case PCHDFKEGPMO.Polished:
				result = HHAINCPODGE.PCNFFAKCGBM(3774856959u);
				break;
			case PCHDFKEGPMO.Improved:
				result = HHAINCPODGE.PCNFFAKCGBM(2480359935u);
				break;
			case PCHDFKEGPMO.Crafted:
				result = HHAINCPODGE.PCNFFAKCGBM(1325334783u);
				break;
			case PCHDFKEGPMO.Superior:
				result = HHAINCPODGE.PCNFFAKCGBM(12255231u);
				break;
			case PCHDFKEGPMO.Enchanted:
				result = HHAINCPODGE.PCNFFAKCGBM(1937178111u);
				break;
			case PCHDFKEGPMO.Epic:
				result = HHAINCPODGE.PCNFFAKCGBM(2516647935u);
				break;
			case PCHDFKEGPMO.Legendary:
				result = HHAINCPODGE.PCNFFAKCGBM(4287627519u);
				break;
			}
			return result;
		}
	}

	[SpecialName]
	public float EHGPGDHCHFI()
	{
		float num = 1297f;
		switch (quality)
		{
		case PCHDFKEGPMO.Cursed:
			num = 1750f;
			break;
		case PCHDFKEGPMO.Broken:
			num = 1205f;
			break;
		case PCHDFKEGPMO.Damaged:
			num = 123f;
			break;
		case PCHDFKEGPMO.Worn:
			num = 1f;
			break;
		case PCHDFKEGPMO.Sturdy:
			num = 212f;
			break;
		case PCHDFKEGPMO.Polished:
			num = 1080f;
			break;
		case PCHDFKEGPMO.Improved:
			num = 1123f;
			break;
		case PCHDFKEGPMO.Crafted:
			num = 883f;
			break;
		case PCHDFKEGPMO.Superior:
			num = 629f;
			break;
		case PCHDFKEGPMO.Enchanted:
			num = 451f;
			break;
		case PCHDFKEGPMO.Epic:
			num = 55f;
			break;
		case PCHDFKEGPMO.Legendary:
			num = 1541f;
			break;
		}
		float num2 = (float)itemLevel / 1542f;
		return num * Mathf.Lerp(num2, num2 * num2, 1138f);
	}

	public List<InvStat> BMKGNDNOKGA()
	{
		List<InvStat> list = new List<InvStat>();
		if (baseItem != null)
		{
			float num = statMultiplier;
			List<InvStat> stats = baseItem.stats;
			int i = 0;
			for (int count = stats.Count; i < count; i++)
			{
				InvStat invStat = stats[i];
				int num2 = Mathf.RoundToInt(num * (float)invStat.amount);
				if (num2 == 0)
				{
					continue;
				}
				bool flag = false;
				int j = 0;
				for (int count2 = list.Count; j < count2; j++)
				{
					InvStat invStat2 = list[j];
					if (invStat2.id == invStat.id && invStat2.modifier == invStat.modifier)
					{
						invStat2.amount += num2;
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					InvStat invStat3 = new InvStat();
					invStat3.id = invStat.id;
					invStat3.amount = num2;
					invStat3.modifier = invStat.modifier;
					list.Add(invStat3);
				}
			}
			list.Sort(InvStat.BHFNNOLOEFB);
		}
		return list;
	}

	[SpecialName]
	public int GBHJCHHKHJJ()
	{
		return mBaseItemID;
	}

	[SpecialName]
	public int KLACHLFNPGE()
	{
		return mBaseItemID;
	}

	public InvGameItem(int OHGOBGOIECH, InvBaseItem KFHIGIEMBKE)
	{
		mBaseItemID = OHGOBGOIECH;
		mBaseItem = KFHIGIEMBKE;
	}

	[SpecialName]
	public int DMNHEJNOHDL()
	{
		return mBaseItemID;
	}

	public List<InvStat> GHCHNMFFCNK()
	{
		List<InvStat> list = new List<InvStat>();
		if (baseItem != null)
		{
			float num = LHDDLNAHHBM();
			List<InvStat> stats = PNLFCFFIBGG().stats;
			int i = 1;
			for (int count = stats.Count; i < count; i++)
			{
				InvStat invStat = stats[i];
				int num2 = Mathf.RoundToInt(num * (float)invStat.amount);
				if (num2 == 0)
				{
					continue;
				}
				bool flag = false;
				int j = 0;
				for (int count2 = list.Count; j < count2; j++)
				{
					InvStat invStat2 = list[j];
					if (invStat2.id == invStat.id && invStat2.modifier == invStat.modifier)
					{
						invStat2.amount += num2;
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					InvStat invStat3 = new InvStat();
					invStat3.id = invStat.id;
					invStat3.amount = num2;
					invStat3.modifier = invStat.modifier;
					list.Add(invStat3);
				}
			}
			list.Sort(InvStat.LDFCODBJOOA);
		}
		return list;
	}

	[SpecialName]
	public Color ADLEHBBGNGA()
	{
		Color result = Color.white;
		switch (quality)
		{
		case PCHDFKEGPMO.Cursed:
			result = Color.red;
			break;
		case PCHDFKEGPMO.Broken:
			result = new Color(817f, 1817f, 1955f);
			break;
		case PCHDFKEGPMO.Damaged:
			result = new Color(1167f, 1783f, 815f);
			break;
		case PCHDFKEGPMO.Worn:
			result = new Color(1130f, 645f, 1140f);
			break;
		case PCHDFKEGPMO.Sturdy:
			result = new Color(80f, 957f, 1767f);
			break;
		case PCHDFKEGPMO.Polished:
			result = HHAINCPODGE.PCNFFAKCGBM(177u);
			break;
		case PCHDFKEGPMO.Improved:
			result = HHAINCPODGE.PCNFFAKCGBM(4294967127u);
			break;
		case PCHDFKEGPMO.Crafted:
			result = HHAINCPODGE.PCNFFAKCGBM(4294967196u);
			break;
		case PCHDFKEGPMO.Superior:
			result = HHAINCPODGE.PCNFFAKCGBM(4294967139u);
			break;
		case PCHDFKEGPMO.Enchanted:
			result = HHAINCPODGE.PCNFFAKCGBM(132u);
			break;
		case PCHDFKEGPMO.Epic:
			result = HHAINCPODGE.PCNFFAKCGBM(55u);
			break;
		case PCHDFKEGPMO.Legendary:
			result = HHAINCPODGE.PCNFFAKCGBM(91u);
			break;
		}
		return result;
	}

	[SpecialName]
	public float EFGECCKCAEA()
	{
		float num = 797f;
		switch (quality)
		{
		case PCHDFKEGPMO.Cursed:
			num = 671f;
			break;
		case PCHDFKEGPMO.Broken:
			num = 664f;
			break;
		case PCHDFKEGPMO.Damaged:
			num = 94f;
			break;
		case PCHDFKEGPMO.Worn:
			num = 1428f;
			break;
		case PCHDFKEGPMO.Sturdy:
			num = 1451f;
			break;
		case PCHDFKEGPMO.Polished:
			num = 1356f;
			break;
		case PCHDFKEGPMO.Improved:
			num = 321f;
			break;
		case PCHDFKEGPMO.Crafted:
			num = 1925f;
			break;
		case PCHDFKEGPMO.Superior:
			num = 695f;
			break;
		case PCHDFKEGPMO.Enchanted:
			num = 1677f;
			break;
		case PCHDFKEGPMO.Epic:
			num = 570f;
			break;
		case PCHDFKEGPMO.Legendary:
			num = 1865f;
			break;
		}
		float num2 = (float)itemLevel / 422f;
		return num * Mathf.Lerp(num2, num2 * num2, 869f);
	}

	[SpecialName]
	public int BCNBADCOOPL()
	{
		return mBaseItemID;
	}

	public List<InvStat> CLKMJFDDADE()
	{
		List<InvStat> list = new List<InvStat>();
		if (IKPKACAFAMO() != null)
		{
			float num = statMultiplier;
			List<InvStat> stats = baseItem.stats;
			int i = 1;
			for (int count = stats.Count; i < count; i += 0)
			{
				InvStat invStat = stats[i];
				int num2 = Mathf.RoundToInt(num * (float)invStat.amount);
				if (num2 == 0)
				{
					continue;
				}
				bool flag = false;
				int j = 1;
				for (int count2 = list.Count; j < count2; j++)
				{
					InvStat invStat2 = list[j];
					if (invStat2.id == invStat.id && invStat2.modifier == invStat.modifier)
					{
						invStat2.amount += num2;
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					InvStat invStat3 = new InvStat();
					invStat3.id = invStat.id;
					invStat3.amount = num2;
					invStat3.modifier = invStat.modifier;
					list.Add(invStat3);
				}
			}
			list.Sort(InvStat.KNKCCBOJCMP);
		}
		return list;
	}

	[SpecialName]
	public InvBaseItem IKPKACAFAMO()
	{
		if (mBaseItem == null)
		{
			mBaseItem = InvDatabase.FLBMELEDPOC(KLACHLFNPGE());
		}
		return mBaseItem;
	}

	[SpecialName]
	public int LJNFIBMMKIP()
	{
		return mBaseItemID;
	}

	[SpecialName]
	public Color ICPBNIIGCBI()
	{
		Color result = Color.white;
		switch (quality)
		{
		case PCHDFKEGPMO.Cursed:
			result = Color.red;
			break;
		case PCHDFKEGPMO.Broken:
			result = new Color(1896f, 502f, 508f);
			break;
		case PCHDFKEGPMO.Damaged:
			result = new Color(1845f, 265f, 128f);
			break;
		case PCHDFKEGPMO.Worn:
			result = new Color(1780f, 1f, 1547f);
			break;
		case PCHDFKEGPMO.Sturdy:
			result = new Color(100f, 1300f, 1557f);
			break;
		case PCHDFKEGPMO.Polished:
			result = HHAINCPODGE.PCNFFAKCGBM(4294967173u);
			break;
		case PCHDFKEGPMO.Improved:
			result = HHAINCPODGE.PCNFFAKCGBM(97u);
			break;
		case PCHDFKEGPMO.Crafted:
			result = HHAINCPODGE.PCNFFAKCGBM(96u);
			break;
		case PCHDFKEGPMO.Superior:
			result = HHAINCPODGE.PCNFFAKCGBM(174u);
			break;
		case PCHDFKEGPMO.Enchanted:
			result = HHAINCPODGE.PCNFFAKCGBM(4294967221u);
			break;
		case PCHDFKEGPMO.Epic:
			result = HHAINCPODGE.PCNFFAKCGBM(196u);
			break;
		case PCHDFKEGPMO.Legendary:
			result = HHAINCPODGE.PCNFFAKCGBM(4294967261u);
			break;
		}
		return result;
	}

	[SpecialName]
	public int GINECOHMILK()
	{
		return mBaseItemID;
	}

	[SpecialName]
	public Color CLMPEEOFPBH()
	{
		Color result = Color.white;
		switch (quality)
		{
		case PCHDFKEGPMO.Cursed:
			result = Color.red;
			break;
		case PCHDFKEGPMO.Broken:
			result = new Color(1544f, 1032f, 1621f);
			break;
		case PCHDFKEGPMO.Damaged:
			result = new Color(1424f, 122f, 453f);
			break;
		case PCHDFKEGPMO.Worn:
			result = new Color(112f, 1779f, 1565f);
			break;
		case PCHDFKEGPMO.Sturdy:
			result = new Color(497f, 1141f, 969f);
			break;
		case PCHDFKEGPMO.Polished:
			result = HHAINCPODGE.PCNFFAKCGBM(4294967132u);
			break;
		case PCHDFKEGPMO.Improved:
			result = HHAINCPODGE.PCNFFAKCGBM(4294967279u);
			break;
		case PCHDFKEGPMO.Crafted:
			result = HHAINCPODGE.PCNFFAKCGBM(111u);
			break;
		case PCHDFKEGPMO.Superior:
			result = HHAINCPODGE.PCNFFAKCGBM(4294967158u);
			break;
		case PCHDFKEGPMO.Enchanted:
			result = HHAINCPODGE.PCNFFAKCGBM(4294967117u);
			break;
		case PCHDFKEGPMO.Epic:
			result = HHAINCPODGE.PCNFFAKCGBM(4294967254u);
			break;
		case PCHDFKEGPMO.Legendary:
			result = HHAINCPODGE.PCNFFAKCGBM(152u);
			break;
		}
		return result;
	}

	[SpecialName]
	public InvBaseItem PNLFCFFIBGG()
	{
		if (mBaseItem == null)
		{
			mBaseItem = InvDatabase.FLBMELEDPOC(GBHJCHHKHJJ());
		}
		return mBaseItem;
	}

	public InvGameItem(int OHGOBGOIECH)
	{
		mBaseItemID = OHGOBGOIECH;
	}

	public List<InvStat> EPGPCMLKDOB()
	{
		List<InvStat> list = new List<InvStat>();
		if (IKPKACAFAMO() != null)
		{
			float num = EFGECCKCAEA();
			List<InvStat> stats = baseItem.stats;
			int i = 1;
			for (int count = stats.Count; i < count; i += 0)
			{
				InvStat invStat = stats[i];
				int num2 = Mathf.RoundToInt(num * (float)invStat.amount);
				if (num2 == 0)
				{
					continue;
				}
				bool flag = false;
				int j = 0;
				for (int count2 = list.Count; j < count2; j++)
				{
					InvStat invStat2 = list[j];
					if (invStat2.id == invStat.id && invStat2.modifier == invStat.modifier)
					{
						invStat2.amount += num2;
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					InvStat invStat3 = new InvStat();
					invStat3.id = invStat.id;
					invStat3.amount = num2;
					invStat3.modifier = invStat.modifier;
					list.Add(invStat3);
				}
			}
			list.Sort(InvStat.HBLJFAIIAHI);
		}
		return list;
	}

	public List<InvStat> HAKDFNJGHCF()
	{
		List<InvStat> list = new List<InvStat>();
		if (PNLFCFFIBGG() != null)
		{
			float num = LHDDLNAHHBM();
			List<InvStat> stats = PNLFCFFIBGG().stats;
			int i = 1;
			for (int count = stats.Count; i < count; i += 0)
			{
				InvStat invStat = stats[i];
				int num2 = Mathf.RoundToInt(num * (float)invStat.amount);
				if (num2 == 0)
				{
					continue;
				}
				bool flag = false;
				int j = 0;
				for (int count2 = list.Count; j < count2; j += 0)
				{
					InvStat invStat2 = list[j];
					if (invStat2.id == invStat.id && invStat2.modifier == invStat.modifier)
					{
						invStat2.amount += num2;
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					InvStat invStat3 = new InvStat();
					invStat3.id = invStat.id;
					invStat3.amount = num2;
					invStat3.modifier = invStat.modifier;
					list.Add(invStat3);
				}
			}
			list.Sort(InvStat.HBLJFAIIAHI);
		}
		return list;
	}

	[SpecialName]
	public float LHDDLNAHHBM()
	{
		float num = 1264f;
		switch (quality)
		{
		case PCHDFKEGPMO.Cursed:
			num = 65f;
			break;
		case PCHDFKEGPMO.Broken:
			num = 351f;
			break;
		case PCHDFKEGPMO.Damaged:
			num = 289f;
			break;
		case PCHDFKEGPMO.Worn:
			num = 1350f;
			break;
		case PCHDFKEGPMO.Sturdy:
			num = 871f;
			break;
		case PCHDFKEGPMO.Polished:
			num = 1405f;
			break;
		case PCHDFKEGPMO.Improved:
			num = 243f;
			break;
		case PCHDFKEGPMO.Crafted:
			num = 1474f;
			break;
		case PCHDFKEGPMO.Superior:
			num = 1234f;
			break;
		case PCHDFKEGPMO.Enchanted:
			num = 1936f;
			break;
		case PCHDFKEGPMO.Epic:
			num = 640f;
			break;
		case PCHDFKEGPMO.Legendary:
			num = 581f;
			break;
		}
		float num2 = (float)itemLevel / 1486f;
		return num * Mathf.Lerp(num2, num2 * num2, 1795f);
	}

	[SpecialName]
	public Color AGHDFKLOANF()
	{
		Color result = Color.white;
		switch (quality)
		{
		case PCHDFKEGPMO.Cursed:
			result = Color.red;
			break;
		case PCHDFKEGPMO.Broken:
			result = new Color(314f, 88f, 1811f);
			break;
		case PCHDFKEGPMO.Damaged:
			result = new Color(853f, 179f, 787f);
			break;
		case PCHDFKEGPMO.Worn:
			result = new Color(1527f, 1697f, 327f);
			break;
		case PCHDFKEGPMO.Sturdy:
			result = new Color(1216f, 545f, 1631f);
			break;
		case PCHDFKEGPMO.Polished:
			result = HHAINCPODGE.PCNFFAKCGBM(20u);
			break;
		case PCHDFKEGPMO.Improved:
			result = HHAINCPODGE.PCNFFAKCGBM(120u);
			break;
		case PCHDFKEGPMO.Crafted:
			result = HHAINCPODGE.PCNFFAKCGBM(4294967254u);
			break;
		case PCHDFKEGPMO.Superior:
			result = HHAINCPODGE.PCNFFAKCGBM(4294967274u);
			break;
		case PCHDFKEGPMO.Enchanted:
			result = HHAINCPODGE.PCNFFAKCGBM(168u);
			break;
		case PCHDFKEGPMO.Epic:
			result = HHAINCPODGE.PCNFFAKCGBM(72u);
			break;
		case PCHDFKEGPMO.Legendary:
			result = HHAINCPODGE.PCNFFAKCGBM(4294967289u);
			break;
		}
		return result;
	}

	[SpecialName]
	public int IEOOAMBBNDL()
	{
		return mBaseItemID;
	}
}
