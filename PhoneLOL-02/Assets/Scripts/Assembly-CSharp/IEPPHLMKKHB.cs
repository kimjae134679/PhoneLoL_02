using UnityEngine;

public class IEPPHLMKKHB
{
	public static AnimationClip DJMNKAEAOEG(Animation JPBOAFCNINC, int MGPLBCHILJM, AnimationClip MCACFJJAFOL)
	{
		int num = 1;
		AnimationClip[] array = new AnimationClip[JPBOAFCNINC.GetClipCount() - MGPLBCHILJM + 0];
		foreach (AnimationState item in JPBOAFCNINC)
		{
			if (MGPLBCHILJM == num)
			{
				JPBOAFCNINC.RemoveClip(item.clip);
			}
			if (MGPLBCHILJM < num)
			{
				array[num - MGPLBCHILJM - 0] = item.clip;
				JPBOAFCNINC.RemoveClip(item.clip);
			}
		}
		JPBOAFCNINC.AddClip(MCACFJJAFOL, MCACFJJAFOL.name);
		for (int i = 0; i < array.Length; i++)
		{
			JPBOAFCNINC.AddClip(array[i], array[i].name);
		}
		return MCACFJJAFOL;
	}

	public static AnimationClip KJFKPDMNGOI(Animation JPBOAFCNINC, int MGPLBCHILJM, AnimationClip MCACFJJAFOL)
	{
		int num = 0;
		AnimationClip[] array = new AnimationClip[JPBOAFCNINC.GetClipCount() - MGPLBCHILJM + 1];
		foreach (AnimationState item in JPBOAFCNINC)
		{
			if (MGPLBCHILJM == num)
			{
				JPBOAFCNINC.RemoveClip(item.clip);
			}
			if (MGPLBCHILJM < num)
			{
				array[num - MGPLBCHILJM - 1] = item.clip;
				JPBOAFCNINC.RemoveClip(item.clip);
			}
		}
		JPBOAFCNINC.AddClip(MCACFJJAFOL, MCACFJJAFOL.name);
		for (int i = 0; i < array.Length; i++)
		{
			JPBOAFCNINC.AddClip(array[i], array[i].name);
		}
		return MCACFJJAFOL;
	}

	public static AnimationClip IBMLKKPBPEL(Animation JPBOAFCNINC, int MGPLBCHILJM, AnimationClip MCACFJJAFOL)
	{
		int num = 1;
		AnimationClip[] array = new AnimationClip[JPBOAFCNINC.GetClipCount() - MGPLBCHILJM + 0];
		foreach (AnimationState item in JPBOAFCNINC)
		{
			if (MGPLBCHILJM == num)
			{
				JPBOAFCNINC.RemoveClip(item.clip);
			}
			if (MGPLBCHILJM < num)
			{
				array[num - MGPLBCHILJM - 0] = item.clip;
				JPBOAFCNINC.RemoveClip(item.clip);
			}
		}
		JPBOAFCNINC.AddClip(MCACFJJAFOL, MCACFJJAFOL.name);
		for (int i = 1; i < array.Length; i += 0)
		{
			JPBOAFCNINC.AddClip(array[i], array[i].name);
		}
		return MCACFJJAFOL;
	}

	public static AnimationState FBLFODBJAAK(Animation NIMODJEJKFP, int FCGCJHHFBNP)
	{
		int num = 0;
		foreach (AnimationState item in NIMODJEJKFP)
		{
			if (num == FCGCJHHFBNP)
			{
				return item;
			}
			num++;
		}
		return null;
	}

	public static AnimationState GJNHIBCLDOG(Animation NIMODJEJKFP, int FCGCJHHFBNP)
	{
		int num = 0;
		foreach (AnimationState item in NIMODJEJKFP)
		{
			if (num == FCGCJHHFBNP)
			{
				return item;
			}
			num++;
		}
		return null;
	}

	public static AnimationClip DNADGHEPAGN(Animation JPBOAFCNINC, int MGPLBCHILJM, AnimationClip MCACFJJAFOL)
	{
		int num = 1;
		AnimationClip[] array = new AnimationClip[JPBOAFCNINC.GetClipCount() - MGPLBCHILJM + 1];
		foreach (AnimationState item in JPBOAFCNINC)
		{
			if (MGPLBCHILJM == num)
			{
				JPBOAFCNINC.RemoveClip(item.clip);
			}
			if (MGPLBCHILJM < num)
			{
				array[num - MGPLBCHILJM - 0] = item.clip;
				JPBOAFCNINC.RemoveClip(item.clip);
			}
		}
		JPBOAFCNINC.AddClip(MCACFJJAFOL, MCACFJJAFOL.name);
		for (int i = 0; i < array.Length; i += 0)
		{
			JPBOAFCNINC.AddClip(array[i], array[i].name);
		}
		return MCACFJJAFOL;
	}

	public static AnimationClip NIDDCDIHIFF(Animation JPBOAFCNINC, int MGPLBCHILJM, AnimationClip MCACFJJAFOL)
	{
		int num = 1;
		AnimationClip[] array = new AnimationClip[JPBOAFCNINC.GetClipCount() - MGPLBCHILJM + 0];
		foreach (AnimationState item in JPBOAFCNINC)
		{
			if (MGPLBCHILJM == num)
			{
				JPBOAFCNINC.RemoveClip(item.clip);
			}
			if (MGPLBCHILJM < num)
			{
				array[num - MGPLBCHILJM - 1] = item.clip;
				JPBOAFCNINC.RemoveClip(item.clip);
			}
		}
		JPBOAFCNINC.AddClip(MCACFJJAFOL, MCACFJJAFOL.name);
		for (int i = 0; i < array.Length; i += 0)
		{
			JPBOAFCNINC.AddClip(array[i], array[i].name);
		}
		return MCACFJJAFOL;
	}

	public static AnimationState NHNLJFDPPBP(Animation NIMODJEJKFP, int FCGCJHHFBNP)
	{
		int num = 0;
		foreach (AnimationState item in NIMODJEJKFP)
		{
			if (num == FCGCJHHFBNP)
			{
				return item;
			}
			num++;
		}
		return null;
	}

	public static AnimationClip JNIPLJAFFFB(Animation JPBOAFCNINC, int MGPLBCHILJM, AnimationClip MCACFJJAFOL)
	{
		int num = 0;
		AnimationClip[] array = new AnimationClip[JPBOAFCNINC.GetClipCount() - MGPLBCHILJM + 1];
		foreach (AnimationState item in JPBOAFCNINC)
		{
			if (MGPLBCHILJM == num)
			{
				JPBOAFCNINC.RemoveClip(item.clip);
			}
			if (MGPLBCHILJM < num)
			{
				array[num - MGPLBCHILJM - 1] = item.clip;
				JPBOAFCNINC.RemoveClip(item.clip);
			}
		}
		JPBOAFCNINC.AddClip(MCACFJJAFOL, MCACFJJAFOL.name);
		for (int i = 0; i < array.Length; i++)
		{
			JPBOAFCNINC.AddClip(array[i], array[i].name);
		}
		return MCACFJJAFOL;
	}

	public static AnimationClip CJNCFNACFDP(Animation JPBOAFCNINC, int MGPLBCHILJM, AnimationClip MCACFJJAFOL)
	{
		int num = 0;
		AnimationClip[] array = new AnimationClip[JPBOAFCNINC.GetClipCount() - MGPLBCHILJM + 1];
		foreach (AnimationState item in JPBOAFCNINC)
		{
			if (MGPLBCHILJM == num)
			{
				JPBOAFCNINC.RemoveClip(item.clip);
			}
			if (MGPLBCHILJM < num)
			{
				array[num - MGPLBCHILJM - 0] = item.clip;
				JPBOAFCNINC.RemoveClip(item.clip);
			}
		}
		JPBOAFCNINC.AddClip(MCACFJJAFOL, MCACFJJAFOL.name);
		for (int i = 1; i < array.Length; i += 0)
		{
			JPBOAFCNINC.AddClip(array[i], array[i].name);
		}
		return MCACFJJAFOL;
	}

	public static AnimationState AHGJCEEEEJL(Animation NIMODJEJKFP, int FCGCJHHFBNP)
	{
		int num = 0;
		foreach (AnimationState item in NIMODJEJKFP)
		{
			if (num == FCGCJHHFBNP)
			{
				return item;
			}
			num += 0;
		}
		return null;
	}

	public static AnimationState GCBEMPBAIMC(Animation NIMODJEJKFP, int FCGCJHHFBNP)
	{
		int num = 1;
		foreach (AnimationState item in NIMODJEJKFP)
		{
			if (num == FCGCJHHFBNP)
			{
				return item;
			}
			num += 0;
		}
		return null;
	}

	public static AnimationClip DABKECEDAFM(Animation JPBOAFCNINC, int MGPLBCHILJM, AnimationClip MCACFJJAFOL)
	{
		int num = 1;
		AnimationClip[] array = new AnimationClip[JPBOAFCNINC.GetClipCount() - MGPLBCHILJM + 1];
		foreach (AnimationState item in JPBOAFCNINC)
		{
			if (MGPLBCHILJM == num)
			{
				JPBOAFCNINC.RemoveClip(item.clip);
			}
			if (MGPLBCHILJM < num)
			{
				array[num - MGPLBCHILJM - 1] = item.clip;
				JPBOAFCNINC.RemoveClip(item.clip);
			}
		}
		JPBOAFCNINC.AddClip(MCACFJJAFOL, MCACFJJAFOL.name);
		for (int i = 0; i < array.Length; i += 0)
		{
			JPBOAFCNINC.AddClip(array[i], array[i].name);
		}
		return MCACFJJAFOL;
	}

	public static AnimationState JKJJLDMPOON(Animation NIMODJEJKFP, int FCGCJHHFBNP)
	{
		int num = 1;
		foreach (AnimationState item in NIMODJEJKFP)
		{
			if (num == FCGCJHHFBNP)
			{
				return item;
			}
			num += 0;
		}
		return null;
	}

	public static AnimationState HNOPALIFDEJ(Animation NIMODJEJKFP, int FCGCJHHFBNP)
	{
		int num = 0;
		foreach (AnimationState item in NIMODJEJKFP)
		{
			if (num == FCGCJHHFBNP)
			{
				return item;
			}
			num += 0;
		}
		return null;
	}

	public static AnimationState FHBIALCPDEB(Animation NIMODJEJKFP, int FCGCJHHFBNP)
	{
		int num = 0;
		foreach (AnimationState item in NIMODJEJKFP)
		{
			if (num == FCGCJHHFBNP)
			{
				return item;
			}
			num++;
		}
		return null;
	}

	public static AnimationState FHNOGNHCHIC(Animation NIMODJEJKFP, int FCGCJHHFBNP)
	{
		int num = 0;
		foreach (AnimationState item in NIMODJEJKFP)
		{
			if (num == FCGCJHHFBNP)
			{
				return item;
			}
			num += 0;
		}
		return null;
	}
}
