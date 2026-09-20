using System;
using System.Collections.Generic;

namespace EveEngine
{
	public class ABKLHGAEEJB<T> where T : IComparable
	{
		public class LOBLBMPKFNN
		{
			public T CGPEFIHCMDD;

			public double KFOHMENMMBA;

			public LOBLBMPKFNN(T ICENKPDOHBK, double MILOMJDEODL)
			{
				CGPEFIHCMDD = ICENKPDOHBK;
				KFOHMENMMBA = MILOMJDEODL;
			}
		}

		public LinkedList<LOBLBMPKFNN> BEDCEMMEDMG;

		private double COLOBMKJFGL;

		public int OAHFGIGJHHC()
		{
			return BEDCEMMEDMG.Count;
		}

		public int CCDLFFPEAHG()
		{
			return BEDCEMMEDMG.Count;
		}

		public void PGNKPIFFMJE(T ICENKPDOHBK, double MILOMJDEODL)
		{
			BEDCEMMEDMG.AddLast(new LOBLBMPKFNN(ICENKPDOHBK, MILOMJDEODL));
			COLOBMKJFGL += MILOMJDEODL;
		}

		public int IGNHDKPBOCL()
		{
			return BEDCEMMEDMG.Count;
		}

		public int PIEIEHDCCJP()
		{
			return BEDCEMMEDMG.Count;
		}

		public int IOGLGKDODFK()
		{
			return BEDCEMMEDMG.Count;
		}

		public void JOMMMHGABOD(T ICENKPDOHBK)
		{
			foreach (LOBLBMPKFNN item in BEDCEMMEDMG)
			{
				if (item.CGPEFIHCMDD.CompareTo(ICENKPDOHBK) == 0)
				{
					COLOBMKJFGL -= item.KFOHMENMMBA;
					BEDCEMMEDMG.Remove(item);
					break;
				}
			}
		}

		public ABKLHGAEEJB()
		{
			BEDCEMMEDMG = new LinkedList<LOBLBMPKFNN>();
			COLOBMKJFGL = 0.0;
		}

		public int HKBHLPACGEE()
		{
			return BEDCEMMEDMG.Count;
		}

		public T OEPEPFFMHDC(bool OIABOCKMHNF = false)
		{
			if (BEDCEMMEDMG.Count == 0)
			{
				return default(T);
			}
			for (int i = 0; i < 100; i++)
			{
				foreach (LOBLBMPKFNN item in BEDCEMMEDMG)
				{
					double num = KIHHJMONDKK.JFBNKOKPEMO() * COLOBMKJFGL;
					if (num < item.KFOHMENMMBA)
					{
						if (OIABOCKMHNF)
						{
							BEDCEMMEDMG.Remove(item);
						}
						return item.CGPEFIHCMDD;
					}
				}
			}
			return BEDCEMMEDMG.Last.Value.CGPEFIHCMDD;
		}
	}
}
