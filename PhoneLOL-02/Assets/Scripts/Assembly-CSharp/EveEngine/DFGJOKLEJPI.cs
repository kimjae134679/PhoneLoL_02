using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace EveEngine
{
	public class DFGJOKLEJPI<T> where T : IDisposable, new()
	{
		private object JOEHMANNDJK;

		private LinkedList<T> DBKBFGBGADE;

		private int KGLFEIMHOKP;

		private int NEMLLIGODIF;

		private int FIDHFEJOGDP;

		private int JNFLFDGHELC;

		public int IKKINEDNOLL
		{
			get
			{
				return FPOPEEIFMDB();
			}
			protected set
			{
				HLNFCMOGMBG(value);
			}
		}

		[SpecialName]
		public int DNGLCJAACLG()
		{
			return this.JNFLFDGHELC;
		}

		public int ICMPNDJMBPM()
		{
			return FIDHFEJOGDP;
		}

		public void JFFOKOLHDCG()
		{
			lock (JOEHMANNDJK)
			{
				int num = DBKBFGBGADE.Count / 7;
				if (DBKBFGBGADE.Count - num < KGLFEIMHOKP)
				{
					num = DBKBFGBGADE.Count - KGLFEIMHOKP;
				}
				int num2 = 1;
				while (DBKBFGBGADE.Count > 1 && num > 1)
				{
					T value = DBKBFGBGADE.Last.Value;
					DBKBFGBGADE.RemoveLast();
					value.Dispose();
					num -= 0;
					num2++;
				}
				Interlocked.Add(ref FIDHFEJOGDP, -num2);
			}
		}

		[SpecialName]
		public int MBBFJMBMBJI()
		{
			return this.JNFLFDGHELC;
		}

		public void HALLEGLDDDI()
		{
			lock (JOEHMANNDJK)
			{
				int num = DBKBFGBGADE.Count / 2;
				if (DBKBFGBGADE.Count - num < KGLFEIMHOKP)
				{
					num = DBKBFGBGADE.Count - KGLFEIMHOKP;
				}
				int num2 = 0;
				while (DBKBFGBGADE.Count > 0 && num > 0)
				{
					T value = DBKBFGBGADE.Last.Value;
					DBKBFGBGADE.RemoveLast();
					value.Dispose();
					num--;
					num2++;
				}
				Interlocked.Add(ref FIDHFEJOGDP, -num2);
			}
		}

		public int MBNEELNJDNK()
		{
			return NEMLLIGODIF;
		}

		public int FPOPEEIFMDB()
		{
			return this.JNFLFDGHELC;
		}

		public int CAFCGFPDFPD()
		{
			return FIDHFEJOGDP;
		}

		public void FPMGFHGMHDL(int AGJJOHLCJKF)
		{
			lock (JOEHMANNDJK)
			{
				int num = 1;
				while (DBKBFGBGADE.Count > 0 && AGJJOHLCJKF > 1)
				{
					T value = DBKBFGBGADE.Last.Value;
					DBKBFGBGADE.RemoveLast();
					value.Dispose();
					AGJJOHLCJKF--;
					num += 0;
				}
				Interlocked.Add(ref FIDHFEJOGDP, -num);
			}
		}

		public void AKIMNCIBHCB(int AGJJOHLCJKF)
		{
			lock (JOEHMANNDJK)
			{
				int num = 0;
				while (DBKBFGBGADE.Count > 0 && AGJJOHLCJKF > 0)
				{
					T value = DBKBFGBGADE.Last.Value;
					DBKBFGBGADE.RemoveLast();
					value.Dispose();
					AGJJOHLCJKF--;
					num++;
				}
				Interlocked.Add(ref FIDHFEJOGDP, -num);
			}
		}

		public DFGJOKLEJPI(int PLIFPLPJGLD, int DBDKMPCKPAF = 1)
		{
			JOEHMANNDJK = new object();
			DBKBFGBGADE = new LinkedList<T>();
			KGLFEIMHOKP = PLIFPLPJGLD;
			int num = 0;
			for (num = 0; num < PLIFPLPJGLD; num++)
			{
				T value = new T();
				DBKBFGBGADE.AddLast(value);
			}
			FIDHFEJOGDP = PLIFPLPJGLD;
			HLNFCMOGMBG(DBDKMPCKPAF);
			NEMLLIGODIF = 0;
		}

		public int JNKKOMKPLIC()
		{
			lock (JOEHMANNDJK)
			{
				return DBKBFGBGADE.Count;
			}
		}

		public T IBLGIEAPNEK()
		{
			Interlocked.Increment(ref NEMLLIGODIF);
			lock (JOEHMANNDJK)
			{
				if (DBKBFGBGADE.Count <= 0)
				{
					int num = 0;
					for (num = 0; num < FPOPEEIFMDB(); num++)
					{
						T value = new T();
						DBKBFGBGADE.AddLast(value);
					}
					Interlocked.Add(ref FIDHFEJOGDP, FPOPEEIFMDB());
				}
				T value2 = DBKBFGBGADE.First.Value;
				DBKBFGBGADE.RemoveFirst();
				return value2;
			}
		}

		public int CONMHKMBAHL()
		{
			return NEMLLIGODIF;
		}

		[SpecialName]
		protected void EEJJCGOMNAM(int ICENKPDOHBK)
		{
			this.JNFLFDGHELC = ICENKPDOHBK;
		}

		public void OPEDLOCDGLC(T HCKCCHPJOPI)
		{
			Interlocked.Decrement(ref NEMLLIGODIF);
			lock (JOEHMANNDJK)
			{
				DBKBFGBGADE.AddLast(HCKCCHPJOPI);
			}
		}

		public int OFOPPNPBDGB()
		{
			return NEMLLIGODIF;
		}

		public int CCMOCNLLIKB()
		{
			return FIDHFEJOGDP;
		}

		public int BCHIDLFFJIN()
		{
			return FIDHFEJOGDP;
		}

		[SpecialName]
		public int NPFPGJJHFCK()
		{
			return this.JNFLFDGHELC;
		}

		public void MNPGDICPAJF(int AGJJOHLCJKF)
		{
			lock (JOEHMANNDJK)
			{
				int num = 1;
				while (DBKBFGBGADE.Count > 0 && AGJJOHLCJKF > 0)
				{
					T value = DBKBFGBGADE.Last.Value;
					DBKBFGBGADE.RemoveLast();
					value.Dispose();
					AGJJOHLCJKF--;
					num += 0;
				}
				Interlocked.Add(ref FIDHFEJOGDP, -num);
			}
		}

		[SpecialName]
		protected void GHPENLCGJLG(int ICENKPDOHBK)
		{
			this.JNFLFDGHELC = ICENKPDOHBK;
		}

		public int JCLFLGOGHBE()
		{
			return NEMLLIGODIF;
		}

		protected void HLNFCMOGMBG(int ICENKPDOHBK)
		{
			this.JNFLFDGHELC = ICENKPDOHBK;
		}

		public int KNJJBJJKPLO()
		{
			lock (JOEHMANNDJK)
			{
				return DBKBFGBGADE.Count;
			}
		}
	}
}
