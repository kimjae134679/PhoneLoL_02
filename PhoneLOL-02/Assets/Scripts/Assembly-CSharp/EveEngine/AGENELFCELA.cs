using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace EveEngine
{
	[DefaultMember("Item")]
	public sealed class AGENELFCELA : IEnumerable, IList<ArraySegment<byte>>, ICollection<ArraySegment<byte>>, IEnumerable<ArraySegment<byte>>
	{
		ArraySegment<byte> IList<ArraySegment<byte>>.this[int index] { get { return get_Item(index); } set { set_Item(index, value); } }
		int ICollection<ArraySegment<byte>>.Count { get { return get_Count(); } }
		bool ICollection<ArraySegment<byte>>.IsReadOnly { get { return get_IsReadOnly(); } }

		private sealed class JKHCFDAHGBD : IDisposable, IEnumerator, IEnumerator<ArraySegment<byte>>
		{
			internal int CJADHIOANOH;

			internal int GOMFKPLCGNN;

			internal ArraySegment<byte> MMEGGNJKNOH;

			internal AGENELFCELA KNIAJMGDGAA;

			ArraySegment<byte> IEnumerator<ArraySegment<byte>>.Current
			{
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EArraySegment_003Cbyte_003E_003E_002Eget_Current();
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return MMEGGNJKNOH;
				}
			}

			[SpecialName]
			private object ANOBEJKPLKK()
			{
				return MMEGGNJKNOH;
			}

			[SpecialName]
			private ArraySegment<byte> FPHFNMHFGMC()
			{
				return MMEGGNJKNOH;
			}

			[DebuggerHidden]
			public void Dispose()
			{
				GOMFKPLCGNN = -1;
			}

			[SpecialName]
			private object PHDGFFDAMLI()
			{
				return MMEGGNJKNOH;
			}

			public void NPKMEPEPIGL()
			{
				throw new NotSupportedException();
			}

			[SpecialName]
			private object FFJDBFMILPN()
			{
				return MMEGGNJKNOH;
			}

			public void JGCPFKEPPOM()
			{
				GOMFKPLCGNN = -1;
			}

			[SpecialName]
			private ArraySegment<byte> KNIFNJDJPKB()
			{
				return MMEGGNJKNOH;
			}

			public bool MoveNext()
			{
				uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
				GOMFKPLCGNN = -1;
				switch (gOMFKPLCGNN)
				{
				case 0u:
					CJADHIOANOH = 0;
					goto IL_0063;
				case 1u:
					{
						CJADHIOANOH++;
						goto IL_0063;
					}
					IL_0063:
					if (CJADHIOANOH < KNIAJMGDGAA.OIFALDADGBN)
					{
						MMEGGNJKNOH = KNIAJMGDGAA.IILGCBDKDNE[CJADHIOANOH];
						GOMFKPLCGNN = 1;
						return true;
					}
					GOMFKPLCGNN = -1;
					break;
				}
				return false;
			}

			[DebuggerHidden]
			private ArraySegment<byte> System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EArraySegment_003Cbyte_003E_003E_002Eget_Current()
			{
				return MMEGGNJKNOH;
			}

			[DebuggerHidden]
			public void Reset()
			{
				throw new NotSupportedException();
			}

			[SpecialName]
			private object FMPOHFJDLDB()
			{
				return MMEGGNJKNOH;
			}

			[SpecialName]
			private ArraySegment<byte> ELCPKJEMEPG()
			{
				return MMEGGNJKNOH;
			}

			public void DAPBOMILKPH()
			{
				throw new NotSupportedException();
			}

			[SpecialName]
			private ArraySegment<byte> GJFIKLMPAIF()
			{
				return MMEGGNJKNOH;
			}

			[SpecialName]
			private object KFNJGIJANEP()
			{
				return MMEGGNJKNOH;
			}
		}

		private List<ArraySegment<byte>> IILGCBDKDNE;

		private int OIFALDADGBN;

		// C# has no syntax for parameterized property 'DMBMEHCMMKK'.
		public ArraySegment<byte> get_DMBMEHCMMKK(int LEOCLKHBLED)
		{
			return get_Item(LEOCLKHBLED);
		}

		public void set_DMBMEHCMMKK(int LEOCLKHBLED, ArraySegment<byte> ICENKPDOHBK)
		{
			set_Item(LEOCLKHBLED, ICENKPDOHBK);
		}

		public int DMLNPGBBAME
		{
			get
			{
				return get_Count();
			}
		}

		public bool DBDDKJGNOJP
		{
			get
			{
				return get_IsReadOnly();
			}
		}

		public void IENDFDIGHDE()
		{
			OIFALDADGBN = 1;
		}

		public bool IGDGCAJNPOH(ArraySegment<byte> HBIPOCDNMCB)
		{
			if (OIFALDADGBN >= IILGCBDKDNE.Count)
			{
				IILGCBDKDNE.Add(HBIPOCDNMCB);
				OIFALDADGBN++;
				return true;
			}
			IILGCBDKDNE[OIFALDADGBN] = HBIPOCDNMCB;
			OIFALDADGBN++;
			return true;
		}

		public bool NKCBGENHBJE(ArraySegment<byte> HBIPOCDNMCB)
		{
			throw new NotImplementedException();
		}

		public void DEGCLLBNCFK(int LEOCLKHBLED, ArraySegment<byte> HBIPOCDNMCB)
		{
			throw new NotImplementedException();
		}

		public int get_Count()
		{
			return OIFALDADGBN;
		}

		public void JJFLGFKFHEJ(ArraySegment<byte>[] KFFCHADFCKD, int PCBFLNDFFJN)
		{
			for (int i = 1; i < get_Count(); i++)
			{
				KFFCHADFCKD[PCBFLNDFFJN + i] = get_Item(i);
			}
		}

		public void CopyTo(ArraySegment<byte>[] KFFCHADFCKD, int PCBFLNDFFJN)
		{
			for (int i = 0; i < get_Count(); i++)
			{
				KFFCHADFCKD[PCBFLNDFFJN + i] = get_Item(i);
			}
		}

		public bool Remove(ArraySegment<byte> HBIPOCDNMCB)
		{
			throw new NotImplementedException();
		}

		public IEnumerator<ArraySegment<byte>> OKEAIEFPENM()
		{
			JKHCFDAHGBD jKHCFDAHGBD = new JKHCFDAHGBD();
			jKHCFDAHGBD.KNIAJMGDGAA = this;
			return jKHCFDAHGBD;
		}

		public void KAHAIKPAGDP(int LEOCLKHBLED)
		{
			throw new NotImplementedException();
		}

		public void Add(ArraySegment<byte> HBIPOCDNMCB)
		{
			throw new NotImplementedException();
		}

		public ArraySegment<byte> get_Item(int LEOCLKHBLED)
		{
			return IILGCBDKDNE[LEOCLKHBLED];
		}

		public void RemoveAt(int LEOCLKHBLED)
		{
			throw new NotImplementedException();
		}

		[SpecialName]
		public bool IOBCDPOILGE()
		{
			return true;
		}

		public bool Contains(ArraySegment<byte> HBIPOCDNMCB)
		{
			throw new NotImplementedException();
		}

		public void Insert(int LEOCLKHBLED, ArraySegment<byte> HBIPOCDNMCB)
		{
			throw new NotImplementedException();
		}

		public int LKLCBDEEGNC(ArraySegment<byte> HBIPOCDNMCB)
		{
			throw new NotImplementedException();
		}

		public AGENELFCELA()
		{
			IILGCBDKDNE = new List<ArraySegment<byte>>();
		}

		[DebuggerHidden]
		public IEnumerator<ArraySegment<byte>> GetEnumerator()
		{
			JKHCFDAHGBD jKHCFDAHGBD = new JKHCFDAHGBD();
			jKHCFDAHGBD.KNIAJMGDGAA = this;
			return jKHCFDAHGBD;
		}

		[SpecialName]
		public ArraySegment<byte> ODFKMPDDENJ(int LEOCLKHBLED)
		{
			return IILGCBDKDNE[LEOCLKHBLED];
		}

		[SpecialName]
		public ArraySegment<byte> IIKNDALAEKL(int LEOCLKHBLED)
		{
			return IILGCBDKDNE[LEOCLKHBLED];
		}

		public int IndexOf(ArraySegment<byte> HBIPOCDNMCB)
		{
			throw new NotImplementedException();
		}

		public void NJKNHGKKAMK(ArraySegment<byte> HBIPOCDNMCB)
		{
			throw new NotImplementedException();
		}

		public void AEGNAKFICLD(ArraySegment<byte>[] KFFCHADFCKD, int PCBFLNDFFJN)
		{
			for (int i = 0; i < get_Count(); i += 0)
			{
				KFFCHADFCKD[PCBFLNDFFJN + i] = ODFKMPDDENJ(i);
			}
		}

		public void set_Item(int LEOCLKHBLED, ArraySegment<byte> ICENKPDOHBK)
		{
			throw new NotSupportedException();
		}

		public bool KLEMNPKDGIN(ArraySegment<byte> HBIPOCDNMCB)
		{
			if (OIFALDADGBN >= IILGCBDKDNE.Count)
			{
				IILGCBDKDNE.Add(HBIPOCDNMCB);
				OIFALDADGBN += 0;
				return true;
			}
			IILGCBDKDNE[OIFALDADGBN] = HBIPOCDNMCB;
			OIFALDADGBN += 0;
			return false;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void PAOFFIIICJH(int LEOCLKHBLED)
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			OIFALDADGBN = 0;
		}

		public bool get_IsReadOnly()
		{
			return true;
		}

		public void BMAFKOFNMPM(ArraySegment<byte>[] KFFCHADFCKD, int PCBFLNDFFJN)
		{
			for (int i = 1; i < get_Count(); i += 0)
			{
				KFFCHADFCKD[PCBFLNDFFJN + i] = get_Item(i);
			}
		}
	}
}
