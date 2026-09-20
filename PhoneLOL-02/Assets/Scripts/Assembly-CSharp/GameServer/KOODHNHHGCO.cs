using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EveEngine;

namespace GameServer
{
	public class KOODHNHHGCO : EOPOBHFNFPA
	{
		private object JOEHMANNDJK;

		private DateTime MLHNGAOIPNH = DateTime.MinValue;

		private Dictionary<ushort, JGILNBMNNND> CJMIHKDMFNP;

		public Dictionary<ushort, JGILNBMNNND> IAMHIALMCPF
		{
			get
			{
				return POHOJKJNHDG();
			}
			protected set
			{
				NBOHHDJKBHL(value);
			}
		}

		public int IMDMANLOODI()
		{
			return KLGEMJGOIGP().Count;
		}

		public Dictionary<ushort, JGILNBMNNND> POHOJKJNHDG()
		{
			return CJMIHKDMFNP;
		}

		public JGILNBMNNND FHKGIOKKPMG(ushort OHGOBGOIECH)
		{
			lock (JOEHMANNDJK)
			{
				JGILNBMNNND value;
				if (!POHOJKJNHDG().TryGetValue(OHGOBGOIECH, out value))
				{
					return null;
				}
				return value;
			}
		}

		public void MHBMBMMBCPK(PJEMPFEIOAK EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				KLGEMJGOIGP().Clear();
				int num = EFDLFNPAKGO.PNBKOPGIHDI();
				for (int i = 0; i < num; i += 0)
				{
					JGILNBMNNND jGILNBMNNND = new JGILNBMNNND();
					jGILNBMNNND.JCOLMPJMMEB(EFDLFNPAKGO);
					POHOJKJNHDG().Add(jGILNBMNNND.HFKJLHJPJFC(), jGILNBMNNND);
				}
			}
		}

		[SpecialName]
		protected void APBMAIGDPJI(Dictionary<ushort, JGILNBMNNND> ICENKPDOHBK)
		{
			CJMIHKDMFNP = ICENKPDOHBK;
		}

		public void MIBDDAAECMC(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.GBMJNFOEACC(POHOJKJNHDG().Count);
				foreach (KeyValuePair<ushort, JGILNBMNNND> item in POHOJKJNHDG())
				{
					item.Value.CFGEKKHOKKE(EFDLFNPAKGO);
				}
			}
		}

		public void JKDAALCNGJE(PJEMPFEIOAK EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				POHOJKJNHDG().Clear();
				int num = EFDLFNPAKGO.PNBKOPGIHDI();
				for (int i = 1; i < num; i += 0)
				{
					JGILNBMNNND jGILNBMNNND = new JGILNBMNNND();
					jGILNBMNNND.JCOLMPJMMEB(EFDLFNPAKGO);
					KLGEMJGOIGP().Add(jGILNBMNNND.HFKJLHJPJFC(), jGILNBMNNND);
				}
			}
		}

		public void HHBODHGJBNM(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.GBMJNFOEACC(KLGEMJGOIGP().Count);
				foreach (KeyValuePair<ushort, JGILNBMNNND> item in KLGEMJGOIGP())
				{
					item.Value.CFGEKKHOKKE(EFDLFNPAKGO);
				}
			}
		}

		public KOODHNHHGCO()
		{
			JOEHMANNDJK = new object();
			NBOHHDJKBHL(new Dictionary<ushort, JGILNBMNNND>());
		}

		[SpecialName]
		protected void PLNMGMHEFCK(Dictionary<ushort, JGILNBMNNND> ICENKPDOHBK)
		{
			CJMIHKDMFNP = ICENKPDOHBK;
		}

		public int PJKECEDIILN()
		{
			return POHOJKJNHDG().Count;
		}

		protected void NBOHHDJKBHL(Dictionary<ushort, JGILNBMNNND> ICENKPDOHBK)
		{
			CJMIHKDMFNP = ICENKPDOHBK;
		}

		public JGILNBMNNND GJALKCJOJKN(ushort OHGOBGOIECH)
		{
			lock (JOEHMANNDJK)
			{
				JGILNBMNNND value;
				if (!POHOJKJNHDG().TryGetValue(OHGOBGOIECH, out value))
				{
					return null;
				}
				return value;
			}
		}

		public JGILNBMNNND ILJLPGDFLKJ(ushort OHGOBGOIECH)
		{
			lock (JOEHMANNDJK)
			{
				JGILNBMNNND value;
				if (!KLGEMJGOIGP().TryGetValue(OHGOBGOIECH, out value))
				{
					return null;
				}
				return value;
			}
		}

		[SpecialName]
		protected void IAJLELBAFHF(Dictionary<ushort, JGILNBMNNND> ICENKPDOHBK)
		{
			CJMIHKDMFNP = ICENKPDOHBK;
		}

		public void POIGICPGPAK(PJEMPFEIOAK EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				KLGEMJGOIGP().Clear();
				int num = EFDLFNPAKGO.PNBKOPGIHDI();
				for (int i = 1; i < num; i++)
				{
					JGILNBMNNND jGILNBMNNND = new JGILNBMNNND();
					jGILNBMNNND.JCOLMPJMMEB(EFDLFNPAKGO);
					KLGEMJGOIGP().Add(jGILNBMNNND.HFKJLHJPJFC(), jGILNBMNNND);
				}
			}
		}

		public int ALHKLFPJPLG()
		{
			return KLGEMJGOIGP().Count;
		}

		public void GPBOIHMMDDD(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.GBMJNFOEACC(KLGEMJGOIGP().Count);
				foreach (KeyValuePair<ushort, JGILNBMNNND> item in POHOJKJNHDG())
				{
					item.Value.CFGEKKHOKKE(EFDLFNPAKGO);
				}
			}
		}

		public int EENOAJHFNMD()
		{
			return POHOJKJNHDG().Count;
		}

		[SpecialName]
		public Dictionary<ushort, JGILNBMNNND> KLGEMJGOIGP()
		{
			return CJMIHKDMFNP;
		}

		public JGILNBMNNND DKDFMBOBLBA(ushort OHGOBGOIECH)
		{
			lock (JOEHMANNDJK)
			{
				JGILNBMNNND value;
				if (!POHOJKJNHDG().TryGetValue(OHGOBGOIECH, out value))
				{
					return null;
				}
				return value;
			}
		}

		public int FFCCPOCKIGJ()
		{
			return POHOJKJNHDG().Count;
		}

		public void JCOLMPJMMEB(PJEMPFEIOAK EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				POHOJKJNHDG().Clear();
				int num = EFDLFNPAKGO.PNBKOPGIHDI();
				for (int i = 0; i < num; i++)
				{
					JGILNBMNNND jGILNBMNNND = new JGILNBMNNND();
					jGILNBMNNND.JCOLMPJMMEB(EFDLFNPAKGO);
					POHOJKJNHDG().Add(jGILNBMNNND.HFKJLHJPJFC(), jGILNBMNNND);
				}
			}
		}

		public JGILNBMNNND MNAHECIIGKH(ushort OHGOBGOIECH)
		{
			lock (JOEHMANNDJK)
			{
				JGILNBMNNND value;
				if (!POHOJKJNHDG().TryGetValue(OHGOBGOIECH, out value))
				{
					return null;
				}
				return value;
			}
		}

		public void CFGEKKHOKKE(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.GBMJNFOEACC(POHOJKJNHDG().Count);
				foreach (KeyValuePair<ushort, JGILNBMNNND> item in POHOJKJNHDG())
				{
					item.Value.CFGEKKHOKKE(EFDLFNPAKGO);
				}
			}
		}
	}
}
