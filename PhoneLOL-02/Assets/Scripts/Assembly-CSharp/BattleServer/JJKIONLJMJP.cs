using System;
using System.Runtime.CompilerServices;
using EveEngine;

namespace BattleServer
{
	public class JJKIONLJMJP : IBHMLPMENFJ
	{
		private DateTime IGFDIHPLFOD;

		private DateTime NMCLFJCLBBO;

		public DateTime NFAICHNHCDA
		{
			get
			{
				return JFHIJKPLPLG();
			}
			protected set
			{
				GKMAFACIJDA(value);
			}
		}

		public DateTime NGKHAMOJLPC
		{
			get
			{
				return LGMICGFMMJF();
			}
			protected set
			{
				ELHKDLOKKGI(value);
			}
		}

		protected void GKMAFACIJDA(DateTime ICENKPDOHBK)
		{
			IGFDIHPLFOD = ICENKPDOHBK;
		}

		[SpecialName]
		protected void JFAGDLAPCCP(DateTime ICENKPDOHBK)
		{
			IGFDIHPLFOD = ICENKPDOHBK;
		}

		public DateTime JFHIJKPLPLG()
		{
			return IGFDIHPLFOD;
		}

		[SpecialName]
		public DateTime MHMPDMJIKOP()
		{
			return NMCLFJCLBBO;
		}

		public void FIGLEPBIEEJ(uint IAEFPLFFKHC, string BHIGNJHHOJP, byte DDILAEMMCAJ, DateTime BOEGDPPNHAC, DateTime CFIMBNOEJEM)
		{
			lock (JOEHMANNDJK)
			{
				OHGOBGOIECH = IAEFPLFFKHC;
				base.BHIGNJHHOJP = BHIGNJHHOJP;
				base.DDILAEMMCAJ = DDILAEMMCAJ;
				GKMAFACIJDA(BOEGDPPNHAC);
				ELHKDLOKKGI(CFIMBNOEJEM);
			}
		}

		public void OAJIDPDBJFB(uint IAEFPLFFKHC, string BHIGNJHHOJP, byte DDILAEMMCAJ, DateTime BOEGDPPNHAC, DateTime CFIMBNOEJEM)
		{
			lock (JOEHMANNDJK)
			{
				OHGOBGOIECH = IAEFPLFFKHC;
				base.BHIGNJHHOJP = BHIGNJHHOJP;
				base.DDILAEMMCAJ = DDILAEMMCAJ;
				AENHJKAINNO(BOEGDPPNHAC);
				ELHKDLOKKGI(CFIMBNOEJEM);
			}
		}

		public override void CFGEKKHOKKE(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				base.CFGEKKHOKKE(EFDLFNPAKGO);
				EFDLFNPAKGO.GBMJNFOEACC(JFHIJKPLPLG());
			}
		}

		public virtual void EIMLGHFBJAB(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				base.CFGEKKHOKKE(EFDLFNPAKGO);
				EFDLFNPAKGO.GBMJNFOEACC(BBJLJOGKGIA());
			}
		}

		public virtual void NECJDAEBLDA()
		{
			base.LDNEFFHJNPL();
		}

		public override void JCOLMPJMMEB(PJEMPFEIOAK EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				base.JCOLMPJMMEB(EFDLFNPAKGO);
				GKMAFACIJDA(EFDLFNPAKGO.NOIDCBCMCMK());
			}
		}

		[SpecialName]
		public DateTime NEBNADHCICA()
		{
			return NMCLFJCLBBO;
		}

		public DateTime LGMICGFMMJF()
		{
			return NMCLFJCLBBO;
		}

		[SpecialName]
		protected void ELKLOECGNMI(DateTime ICENKPDOHBK)
		{
			IGFDIHPLFOD = ICENKPDOHBK;
		}

		[SpecialName]
		protected void JPIBAEIGOIJ(DateTime ICENKPDOHBK)
		{
			IGFDIHPLFOD = ICENKPDOHBK;
		}

		public virtual void OAADIIIMNDE()
		{
			base.LDNEFFHJNPL();
		}

		protected void ELHKDLOKKGI(DateTime ICENKPDOHBK)
		{
			NMCLFJCLBBO = ICENKPDOHBK;
		}

		[SpecialName]
		protected void AENHJKAINNO(DateTime ICENKPDOHBK)
		{
			IGFDIHPLFOD = ICENKPDOHBK;
		}

		[SpecialName]
		public DateTime AIJELBDKMFG()
		{
			return IGFDIHPLFOD;
		}

		[SpecialName]
		public DateTime BBJLJOGKGIA()
		{
			return IGFDIHPLFOD;
		}

		public override void LDNEFFHJNPL()
		{
			base.LDNEFFHJNPL();
		}
	}
}
