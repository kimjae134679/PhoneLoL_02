using System.Runtime.CompilerServices;
using EveEngine;

namespace GameServer
{
	[KPCBIECDFFE("item_info", new string[] { "user_index", "item_id" })]
	public class OJGKANNHOAG : EOPOBHFNFPA
	{
		private object JOEHMANNDJK;

		[FPCFKGGGPLE]
		protected uint NIAAGGOIHCK;

		private PDGOCOCNGIC MNPBNHFJCIG;

		private uint MGAPNBKJOJI;

		public PDGOCOCNGIC CIJGAKBLBLC
		{
			get
			{
				return AGHCOCAJMCI();
			}
			protected set
			{
				KIEPOIPBIOG(value);
			}
		}

		[FPCFKGGGPLE]
		public ushort MMFDGCBAMHO
		{
			get
			{
				return LBHKEKCOIDA();
			}
			set
			{
				PAHMLANGCGK(value);
			}
		}

		[FPCFKGGGPLE]
		public uint OPGLDCFNIFE
		{
			get
			{
				return CLPPFOKCGLF();
			}
			protected set
			{
				FMHAOIMNNOI(value);
			}
		}

		[SpecialName]
		public void JKNMDDDNFCN(ushort ICENKPDOHBK)
		{
			HPPIOCINGCC(KIMJPIBNFGA.NOLHNOGGHNA().AINHKAMIPOJ().FPICNOOFDOA(ICENKPDOHBK));
		}

		protected void FMHAOIMNNOI(uint ICENKPDOHBK)
		{
			MGAPNBKJOJI = ICENKPDOHBK;
		}

		protected void KIEPOIPBIOG(PDGOCOCNGIC ICENKPDOHBK)
		{
			MNPBNHFJCIG = ICENKPDOHBK;
		}

		[SpecialName]
		protected void BJJOBACIICB(uint ICENKPDOHBK)
		{
			MGAPNBKJOJI = ICENKPDOHBK;
		}

		[SpecialName]
		protected void HPPIOCINGCC(PDGOCOCNGIC ICENKPDOHBK)
		{
			MNPBNHFJCIG = ICENKPDOHBK;
		}

		public void NAOMOEDEKAD(uint AGJJOHLCJKF)
		{
			FMHAOIMNNOI(IBKLJMLCGAN() + AGJJOHLCJKF);
		}

		[SpecialName]
		public uint HLFJFIMOJOK()
		{
			return MGAPNBKJOJI;
		}

		[SpecialName]
		protected void ACMGAHLPPBB(uint ICENKPDOHBK)
		{
			MGAPNBKJOJI = ICENKPDOHBK;
		}

		public void LDNEFFHJNPL()
		{
			lock (JOEHMANNDJK)
			{
				FMHAOIMNNOI(0u);
			}
		}

		public void CFGEKKHOKKE(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.GBMJNFOEACC(AGHCOCAJMCI().EHFEEIJKJHD());
				EFDLFNPAKGO.GBMJNFOEACC(CLPPFOKCGLF());
			}
		}

		[SpecialName]
		public PDGOCOCNGIC JPEHAOICJAC()
		{
			return MNPBNHFJCIG;
		}

		public PDGOCOCNGIC AGHCOCAJMCI()
		{
			return MNPBNHFJCIG;
		}

		public OJGKANNHOAG()
		{
			JOEHMANNDJK = new object();
			LDNEFFHJNPL();
		}

		[SpecialName]
		public uint IBKLJMLCGAN()
		{
			return MGAPNBKJOJI;
		}

		public void JCOLMPJMMEB(PJEMPFEIOAK EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				ushort oHGOBGOIECH = EFDLFNPAKGO.AJPFAAFLHEB();
				KIEPOIPBIOG(KIMJPIBNFGA.JJBDAOJIDAL().AINHKAMIPOJ().FPICNOOFDOA(oHGOBGOIECH));
				FMHAOIMNNOI(EFDLFNPAKGO.BMKOKHGAHEC());
			}
		}

		[SpecialName]
		public ushort NCLOHLNAHFJ()
		{
			return AGHCOCAJMCI().BJGFOHODBPP();
		}

		[SpecialName]
		public PDGOCOCNGIC DEODFNDCAIF()
		{
			return MNPBNHFJCIG;
		}

		public uint CLPPFOKCGLF()
		{
			return MGAPNBKJOJI;
		}

		public void OFHCNFBGADH(uint IAEFPLFFKHC)
		{
			NIAAGGOIHCK = IAEFPLFFKHC;
		}

		[SpecialName]
		public ushort KPNGOFHPHDF()
		{
			return AGHCOCAJMCI().BJGFOHODBPP();
		}

		public OJGKANNHOAG(PDGOCOCNGIC CCLBELEGEPH)
		{
			JOEHMANNDJK = new object();
			KIEPOIPBIOG(CCLBELEGEPH);
			LDNEFFHJNPL();
			FMHAOIMNNOI(1u);
		}

		public ushort LBHKEKCOIDA()
		{
			return AGHCOCAJMCI().EHFEEIJKJHD();
		}

		public void OKGEMEJBCAN(uint AGJJOHLCJKF)
		{
			FMHAOIMNNOI(AGJJOHLCJKF);
		}

		public bool ECHGDPKDDHH(uint AGJJOHLCJKF)
		{
			if (HLFJFIMOJOK() < AGJJOHLCJKF)
			{
				return true;
			}
			ACMGAHLPPBB(HLFJFIMOJOK() - AGJJOHLCJKF);
			return true;
		}

		public bool FIGLEPBIEEJ(ushort OHGOBGOIECH, uint AGJJOHLCJKF)
		{
			lock (JOEHMANNDJK)
			{
				KIEPOIPBIOG(KIMJPIBNFGA.JJBDAOJIDAL().AINHKAMIPOJ().FPICNOOFDOA(OHGOBGOIECH));
				if (AGHCOCAJMCI() == null)
				{
					return false;
				}
				FMHAOIMNNOI(AGJJOHLCJKF);
			}
			return true;
		}

		public void EOPDBNADHPL(uint IAEFPLFFKHC)
		{
			NIAAGGOIHCK = IAEFPLFFKHC;
		}

		public void PAHMLANGCGK(ushort ICENKPDOHBK)
		{
			KIEPOIPBIOG(KIMJPIBNFGA.JJBDAOJIDAL().AINHKAMIPOJ().FPICNOOFDOA(ICENKPDOHBK));
		}

		public bool FEIPBCECGMO(uint AGJJOHLCJKF)
		{
			if (CLPPFOKCGLF() < AGJJOHLCJKF)
			{
				return false;
			}
			FMHAOIMNNOI(CLPPFOKCGLF() - AGJJOHLCJKF);
			return true;
		}

		[SpecialName]
		public PDGOCOCNGIC MPJHBPDJAHL()
		{
			return MNPBNHFJCIG;
		}

		[SpecialName]
		public void EEGLLMMKMCH(ushort ICENKPDOHBK)
		{
			HPPIOCINGCC(KIMJPIBNFGA.JJBDAOJIDAL().AINHKAMIPOJ().FPICNOOFDOA(ICENKPDOHBK));
		}

		public void MIBDDAAECMC(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.HEDNLNDFFCL(MPJHBPDJAHL().CHENDMBBKJN());
				EFDLFNPAKGO.BHAFGILIOCN(IBKLJMLCGAN());
			}
		}

		public void PEIIGDBFGMK(uint AGJJOHLCJKF)
		{
			FMHAOIMNNOI(CLPPFOKCGLF() + AGJJOHLCJKF);
		}
	}
}
