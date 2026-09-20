using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EveEngine;

namespace GameServer
{
	public class PCFDENCBEMB : EOPOBHFNFPA
	{
		private object JOEHMANNDJK;

		private Dictionary<ushort, OJGKANNHOAG> IABDAJPKHHM;

		public Dictionary<ushort, OJGKANNHOAG> HHHPHPOPBGG
		{
			get
			{
				return GNKACBCHIGA();
			}
			protected set
			{
				OFNKCJLMIHH(value);
			}
		}

		public void CFGEKKHOKKE(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.GBMJNFOEACC((ushort)GNKACBCHIGA().Count);
				foreach (KeyValuePair<ushort, OJGKANNHOAG> item in GNKACBCHIGA())
				{
					item.Value.CFGEKKHOKKE(EFDLFNPAKGO);
				}
			}
		}

		public void JANBGPFAFJF(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.GBMJNFOEACC((ushort)GNKACBCHIGA().Count);
				foreach (KeyValuePair<ushort, OJGKANNHOAG> item in LBONPPMBEAB())
				{
					item.Value.MIBDDAAECMC(EFDLFNPAKGO);
				}
			}
		}

		public OJGKANNHOAG DDIBAIMBOGJ(ushort CDLJHFICDDI)
		{
			lock (JOEHMANNDJK)
			{
				OJGKANNHOAG value;
				if (!LPCKDEKAGEO().TryGetValue(CDLJHFICDDI, out value))
				{
					return null;
				}
				return value;
			}
		}

		public int MGONEDOJNGH(ushort CDLJHFICDDI, uint AGJJOHLCJKF)
		{
			OJGKANNHOAG oJGKANNHOAG = DDIBAIMBOGJ(CDLJHFICDDI);
			if (oJGKANNHOAG == null)
			{
				return 0;
			}
			if (oJGKANNHOAG.IBKLJMLCGAN() < AGJJOHLCJKF)
			{
				return 8;
			}
			return 0;
		}

		[SpecialName]
		public Dictionary<ushort, OJGKANNHOAG> EEILEPJPEON()
		{
			return IABDAJPKHHM;
		}

		public void JCOLMPJMMEB(PJEMPFEIOAK EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				GNKACBCHIGA().Clear();
				ushort num = EFDLFNPAKGO.AJPFAAFLHEB();
				for (ushort num2 = 0; num2 < num; num2++)
				{
					OJGKANNHOAG oJGKANNHOAG = new OJGKANNHOAG();
					oJGKANNHOAG.JCOLMPJMMEB(EFDLFNPAKGO);
					GNKACBCHIGA().Add(oJGKANNHOAG.AGHCOCAJMCI().EHFEEIJKJHD(), oJGKANNHOAG);
				}
			}
		}

		public bool NNECHJPELNH(ushort CDLJHFICDDI, uint AGJJOHLCJKF)
		{
			OJGKANNHOAG oJGKANNHOAG = FPICNOOFDOA(CDLJHFICDDI);
			if (oJGKANNHOAG == null)
			{
				return false;
			}
			if (oJGKANNHOAG.CLPPFOKCGLF() < AGJJOHLCJKF)
			{
				return false;
			}
			if (oJGKANNHOAG.CLPPFOKCGLF() == AGJJOHLCJKF)
			{
				lock (JOEHMANNDJK)
				{
					GNKACBCHIGA().Remove(CDLJHFICDDI);
				}
			}
			else
			{
				oJGKANNHOAG.FEIPBCECGMO(AGJJOHLCJKF);
			}
			return true;
		}

		public OJGKANNHOAG AALBNFJJHNK(ushort CDLJHFICDDI)
		{
			lock (JOEHMANNDJK)
			{
				OJGKANNHOAG value;
				if (!GNKACBCHIGA().TryGetValue(CDLJHFICDDI, out value))
				{
					return null;
				}
				return value;
			}
		}

		public PCFDENCBEMB()
		{
			JOEHMANNDJK = new object();
			OFNKCJLMIHH(new Dictionary<ushort, OJGKANNHOAG>());
		}

		public void PGNKPIFFMJE(ushort CDLJHFICDDI, uint AGJJOHLCJKF)
		{
			if (CDLJHFICDDI != 0)
			{
				OJGKANNHOAG oJGKANNHOAG = FPICNOOFDOA(CDLJHFICDDI);
				if (oJGKANNHOAG == null)
				{
					oJGKANNHOAG = new OJGKANNHOAG(KIMJPIBNFGA.JJBDAOJIDAL().AINHKAMIPOJ().FPICNOOFDOA(CDLJHFICDDI));
					oJGKANNHOAG.OKGEMEJBCAN(AGJJOHLCJKF);
					GNKACBCHIGA().Add(CDLJHFICDDI, oJGKANNHOAG);
				}
				else
				{
					oJGKANNHOAG.PEIIGDBFGMK(AGJJOHLCJKF);
				}
			}
		}

		public void PGNKPIFFMJE(List<ushort> AOAMEPEMDKI)
		{
			foreach (ushort item in AOAMEPEMDKI)
			{
				PGNKPIFFMJE(item, 1u);
			}
		}

		public int JGCOGIEKACL(ushort CDLJHFICDDI, uint AGJJOHLCJKF)
		{
			OJGKANNHOAG oJGKANNHOAG = DDIBAIMBOGJ(CDLJHFICDDI);
			if (oJGKANNHOAG == null)
			{
				return 0;
			}
			if (oJGKANNHOAG.CLPPFOKCGLF() < AGJJOHLCJKF)
			{
				return 7;
			}
			return 1;
		}

		public void LDNEFFHJNPL()
		{
			lock (JOEHMANNDJK)
			{
				GNKACBCHIGA().Clear();
			}
		}

		[SpecialName]
		protected void BFKNPFNEKLL(Dictionary<ushort, OJGKANNHOAG> ICENKPDOHBK)
		{
			IABDAJPKHHM = ICENKPDOHBK;
		}

		public int MBCEBKJDEAK(ushort CDLJHFICDDI, uint AGJJOHLCJKF)
		{
			OJGKANNHOAG oJGKANNHOAG = FPICNOOFDOA(CDLJHFICDDI);
			if (oJGKANNHOAG == null)
			{
				return 1;
			}
			if (oJGKANNHOAG.CLPPFOKCGLF() < AGJJOHLCJKF)
			{
				return 2;
			}
			return 0;
		}

		public void IPKAMEFEKNP(List<ushort> AOAMEPEMDKI)
		{
			foreach (ushort item in AOAMEPEMDKI)
			{
				JBFJMCBAPGA(item, 1u);
			}
		}

		[SpecialName]
		public Dictionary<ushort, OJGKANNHOAG> LPCKDEKAGEO()
		{
			return IABDAJPKHHM;
		}

		public Dictionary<ushort, OJGKANNHOAG> GNKACBCHIGA()
		{
			return IABDAJPKHHM;
		}

		public int POHJDPLNMOA(ushort CDLJHFICDDI, uint AGJJOHLCJKF)
		{
			OJGKANNHOAG oJGKANNHOAG = DDIBAIMBOGJ(CDLJHFICDDI);
			if (oJGKANNHOAG == null)
			{
				return 1;
			}
			if (oJGKANNHOAG.CLPPFOKCGLF() < AGJJOHLCJKF)
			{
				return 5;
			}
			return 1;
		}

		protected void OFNKCJLMIHH(Dictionary<ushort, OJGKANNHOAG> ICENKPDOHBK)
		{
			IABDAJPKHHM = ICENKPDOHBK;
		}

		[SpecialName]
		public Dictionary<ushort, OJGKANNHOAG> KHIKKDBAJJJ()
		{
			return IABDAJPKHHM;
		}

		public OJGKANNHOAG FPICNOOFDOA(ushort CDLJHFICDDI)
		{
			lock (JOEHMANNDJK)
			{
				OJGKANNHOAG value;
				if (!GNKACBCHIGA().TryGetValue(CDLJHFICDDI, out value))
				{
					return null;
				}
				return value;
			}
		}

		public void JBFJMCBAPGA(ushort CDLJHFICDDI, uint AGJJOHLCJKF)
		{
			if (CDLJHFICDDI != 0)
			{
				OJGKANNHOAG oJGKANNHOAG = DDIBAIMBOGJ(CDLJHFICDDI);
				if (oJGKANNHOAG == null)
				{
					oJGKANNHOAG = new OJGKANNHOAG(KIMJPIBNFGA.HEDJPPFKABG().AINHKAMIPOJ().FPICNOOFDOA(CDLJHFICDDI));
					oJGKANNHOAG.OKGEMEJBCAN(AGJJOHLCJKF);
					KHIKKDBAJJJ().Add(CDLJHFICDDI, oJGKANNHOAG);
				}
				else
				{
					oJGKANNHOAG.NAOMOEDEKAD(AGJJOHLCJKF);
				}
			}
		}

		public uint PANOGPIDAKP(ushort CDLJHFICDDI)
		{
			OJGKANNHOAG oJGKANNHOAG = FPICNOOFDOA(CDLJHFICDDI);
			if (oJGKANNHOAG == null)
			{
				return 1u;
			}
			return oJGKANNHOAG.CLPPFOKCGLF();
		}

		[SpecialName]
		public Dictionary<ushort, OJGKANNHOAG> LBONPPMBEAB()
		{
			return IABDAJPKHHM;
		}
	}
}
