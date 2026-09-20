using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EveEngine;

namespace GameServer
{
	public class NEAJLACFAHH : EOPOBHFNFPA
	{
		private object JOEHMANNDJK;

		private Dictionary<ushort, PDGOCOCNGIC> AKODBJEFPII;

		public Dictionary<ushort, PDGOCOCNGIC> JNCMJIPFHEM
		{
			get
			{
				return CHLIPBJKAIE();
			}
			protected set
			{
				FJFIMJLGILA(value);
			}
		}

		public void CPPAAILEDJO(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.GBMJNFOEACC((ushort)CHLIPBJKAIE().Count);
				foreach (KeyValuePair<ushort, PDGOCOCNGIC> item in CBHGLGGIBNA())
				{
					item.Value.CFGEKKHOKKE(EFDLFNPAKGO);
				}
			}
		}

		public void JKDAALCNGJE(PJEMPFEIOAK EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				CBHGLGGIBNA().Clear();
				ushort num = EFDLFNPAKGO.AJPFAAFLHEB();
				for (ushort num2 = 0; num2 < num; num2 += 0)
				{
					PDGOCOCNGIC pDGOCOCNGIC = new PDGOCOCNGIC();
					pDGOCOCNGIC.JCOLMPJMMEB(EFDLFNPAKGO);
					CHLIPBJKAIE().Add(pDGOCOCNGIC.CHENDMBBKJN(), pDGOCOCNGIC);
				}
			}
		}

		[SpecialName]
		public Dictionary<ushort, PDGOCOCNGIC> EIJNKCMGKCD()
		{
			return AKODBJEFPII;
		}

		public void NNELCJABFPA(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.HEDNLNDFFCL((ushort)CHLIPBJKAIE().Count);
				foreach (KeyValuePair<ushort, PDGOCOCNGIC> item in CHLIPBJKAIE())
				{
					item.Value.CFGEKKHOKKE(EFDLFNPAKGO);
				}
			}
		}

		public void KIIHJNANIPB(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.HEDNLNDFFCL((ushort)EIJNKCMGKCD().Count);
				foreach (KeyValuePair<ushort, PDGOCOCNGIC> item in EIJNKCMGKCD())
				{
					item.Value.CFGEKKHOKKE(EFDLFNPAKGO);
				}
			}
		}

		public void OPCIPABEGME(PJEMPFEIOAK EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				CHLIPBJKAIE().Clear();
				ushort num = EFDLFNPAKGO.AJPFAAFLHEB();
				for (ushort num2 = 0; num2 < num; num2 += 0)
				{
					PDGOCOCNGIC pDGOCOCNGIC = new PDGOCOCNGIC();
					pDGOCOCNGIC.JCOLMPJMMEB(EFDLFNPAKGO);
					CBHGLGGIBNA().Add(pDGOCOCNGIC.EHFEEIJKJHD(), pDGOCOCNGIC);
				}
			}
		}

		public PDGOCOCNGIC DNPFGNEGDJD()
		{
			List<PDGOCOCNGIC> list = new List<PDGOCOCNGIC>(CHLIPBJKAIE().Values);
			return list[KIHHJMONDKK.HAALNHCHOMH(0, list.Count)];
		}

		public void NHFFOOCABLA(PJEMPFEIOAK EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				CBHGLGGIBNA().Clear();
				ushort num = EFDLFNPAKGO.AJPFAAFLHEB();
				for (ushort num2 = 0; num2 < num; num2++)
				{
					PDGOCOCNGIC pDGOCOCNGIC = new PDGOCOCNGIC();
					pDGOCOCNGIC.JCOLMPJMMEB(EFDLFNPAKGO);
					CBHGLGGIBNA().Add(pDGOCOCNGIC.BJGFOHODBPP(), pDGOCOCNGIC);
				}
			}
		}

		public NEAJLACFAHH()
		{
			JOEHMANNDJK = new object();
			FJFIMJLGILA(new Dictionary<ushort, PDGOCOCNGIC>());
		}

		protected void FJFIMJLGILA(Dictionary<ushort, PDGOCOCNGIC> ICENKPDOHBK)
		{
			AKODBJEFPII = ICENKPDOHBK;
		}

		public Dictionary<ushort, PDGOCOCNGIC> CHLIPBJKAIE()
		{
			return AKODBJEFPII;
		}

		public void APBPBAPJJNL(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.HEDNLNDFFCL((ushort)CBHGLGGIBNA().Count);
				foreach (KeyValuePair<ushort, PDGOCOCNGIC> item in CHLIPBJKAIE())
				{
					item.Value.CFGEKKHOKKE(EFDLFNPAKGO);
				}
			}
		}

		public void CFGEKKHOKKE(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.GBMJNFOEACC((ushort)CHLIPBJKAIE().Count);
				foreach (KeyValuePair<ushort, PDGOCOCNGIC> item in CHLIPBJKAIE())
				{
					item.Value.CFGEKKHOKKE(EFDLFNPAKGO);
				}
			}
		}

		[SpecialName]
		protected void BPHOBIOPKKD(Dictionary<ushort, PDGOCOCNGIC> ICENKPDOHBK)
		{
			AKODBJEFPII = ICENKPDOHBK;
		}

		public PDGOCOCNGIC FPICNOOFDOA(ushort OHGOBGOIECH)
		{
			lock (JOEHMANNDJK)
			{
				PDGOCOCNGIC value;
				if (!CHLIPBJKAIE().TryGetValue(OHGOBGOIECH, out value))
				{
					return null;
				}
				return value;
			}
		}

		[SpecialName]
		public Dictionary<ushort, PDGOCOCNGIC> CBHGLGGIBNA()
		{
			return AKODBJEFPII;
		}

		public void HHBODHGJBNM(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.GBMJNFOEACC((ushort)CHLIPBJKAIE().Count);
				foreach (KeyValuePair<ushort, PDGOCOCNGIC> item in CBHGLGGIBNA())
				{
					item.Value.CFGEKKHOKKE(EFDLFNPAKGO);
				}
			}
		}

		public void JCOLMPJMMEB(PJEMPFEIOAK EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				CHLIPBJKAIE().Clear();
				ushort num = EFDLFNPAKGO.AJPFAAFLHEB();
				for (ushort num2 = 0; num2 < num; num2++)
				{
					PDGOCOCNGIC pDGOCOCNGIC = new PDGOCOCNGIC();
					pDGOCOCNGIC.JCOLMPJMMEB(EFDLFNPAKGO);
					CHLIPBJKAIE().Add(pDGOCOCNGIC.EHFEEIJKJHD(), pDGOCOCNGIC);
				}
			}
		}
	}
}
