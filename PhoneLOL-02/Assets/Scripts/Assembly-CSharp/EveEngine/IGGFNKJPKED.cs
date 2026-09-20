using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EveEngine
{
	public class IGGFNKJPKED : IDisposable
	{
		[Flags]
		public enum BKBDEHOLPGL : uint
		{
			TIME_ONESHOT = 0u,
			TIME_PERIODIC = 1u,
			TIME_CALLBACK_FUNCTION = 0u
		}

		private delegate void BMKBLGDCGDL(uint NNADMLEALBE, uint CCCMAIMNKOD, UIntPtr BPCKNIGGGGM, UIntPtr KPKLIPNBDOP, UIntPtr BADBOBJCFOP);

		private uint OHGOBGOIECH;

		private BMKBLGDCGDL FJFJHCJBHEL;

		private object DAHJAKJHOEN = new object();

		private bool BEACHHNMEBN;

		private CGLHCCALMMC m_HOGDBCMCCLL;

		private bool JANKGDFLNKN;

		private bool HNLOHMDGGKA;

		private uint CACKOIILKFC;

		public bool LELOKKNLHBH
		{
			get
			{
				return CJPOALOOMPK();
			}
			set
			{
				MDIFPJANAGL(value);
			}
		}

		public bool HHBHGBNFHPJ
		{
			get
			{
				return OAIBPCCMBHE();
			}
			private set
			{
				CPGHDLICIDN(value);
			}
		}

		public uint KCPEECGCKED
		{
			get
			{
				return GHBPLOOENCP();
			}
			set
			{
				LHGEDLGANML(value);
			}
		}

		public event CGLHCCALMMC HOGDBCMCCLL
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				APELFEGNALG(value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				OJADNGPGPDL(value);
			}
		}

		public void LBFAAEILMBA()
		{
			Dispose();
		}

		[DllImport("Winmm.dll", CharSet = CharSet.Auto, EntryPoint = "timeGetTime")]
		private static extern uint ILJDHACGMOJ();

		[SpecialName]
		public void JKBOFNNKIHN(CGLHCCALMMC ICENKPDOHBK)
		{
			this.m_HOGDBCMCCLL = (CGLHCCALMMC)Delegate.Combine(this.m_HOGDBCMCCLL, ICENKPDOHBK);
		}

		public void MDIFPJANAGL(bool ICENKPDOHBK)
		{
			JANKGDFLNKN = ICENKPDOHBK;
		}

		[SpecialName]
		public void ACGIJDKDIMN(CGLHCCALMMC ICENKPDOHBK)
		{
			this.m_HOGDBCMCCLL = (CGLHCCALMMC)Delegate.Combine(this.m_HOGDBCMCCLL, ICENKPDOHBK);
		}

		private void IMKOPEDFMAM(uint NNADMLEALBE, uint CCCMAIMNKOD, UIntPtr BPCKNIGGGGM, UIntPtr KPKLIPNBDOP, UIntPtr BADBOBJCFOP)
		{
			FKFIMFCCFLD();
		}

		[SpecialName]
		public bool BDJNJKGCAFI()
		{
			return HNLOHMDGGKA;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void OJADNGPGPDL(CGLHCCALMMC ICENKPDOHBK)
		{
			this.m_HOGDBCMCCLL = (CGLHCCALMMC)Delegate.Remove(this.m_HOGDBCMCCLL, ICENKPDOHBK);
		}

		public IGGFNKJPKED()
		{
			LHGEDLGANML(100u);
			MDIFPJANAGL(true);
			CPGHDLICIDN(false);
			FJFJHCJBHEL = IMKOPEDFMAM;
		}

		[SpecialName]
		public uint EIOIALBMEJD()
		{
			return CACKOIILKFC;
		}

		~IGGFNKJPKED()
		{
			JDBENBMLFNP(false);
		}

		public void MGKFILLMPIB()
		{
			Dispose();
		}

		protected virtual void FKFIMFCCFLD()
		{
			if (this.m_HOGDBCMCCLL != null)
			{
				this.m_HOGDBCMCCLL(this, new OBEMLAAJFEK());
			}
		}

		[DllImport("Winmm.dll", CharSet = CharSet.Auto, EntryPoint = "timeBeginPeriod")]
		private static extern uint BAPEPIPJDNL(uint HAAOLNMEGHE);

		[SpecialName]
		public void ALLGEAHAEMM(uint ICENKPDOHBK)
		{
			CACKOIILKFC = ICENKPDOHBK;
		}

		private void CPGHDLICIDN(bool ICENKPDOHBK)
		{
			HNLOHMDGGKA = ICENKPDOHBK;
		}

		public IGGFNKJPKED(uint DHCBPODBGOG)
		{
			LHGEDLGANML(DHCBPODBGOG);
			MDIFPJANAGL(true);
			CPGHDLICIDN(false);
			FJFJHCJBHEL = IMKOPEDFMAM;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void APELFEGNALG(CGLHCCALMMC ICENKPDOHBK)
		{
			this.m_HOGDBCMCCLL = (CGLHCCALMMC)Delegate.Combine(this.m_HOGDBCMCCLL, ICENKPDOHBK);
		}

		public void LHGEDLGANML(uint ICENKPDOHBK)
		{
			CACKOIILKFC = ICENKPDOHBK;
		}

		public void FLAIMHHIDLC()
		{
			lock (DAHJAKJHOEN)
			{
				if (OHGOBGOIECH != 0)
				{
					HPCDHHDIMDG(OHGOBGOIECH);
					OHGOBGOIECH = 0u;
					CPGHDLICIDN(false);
				}
			}
		}

		public uint GHBPLOOENCP()
		{
			return CACKOIILKFC;
		}

		private void JDBENBMLFNP(bool BPCKECGFJPA)
		{
			if (!BEACHHNMEBN && BPCKECGFJPA)
			{
				FLAIMHHIDLC();
			}
			BEACHHNMEBN = true;
		}

		public bool CJPOALOOMPK()
		{
			return JANKGDFLNKN;
		}

		public void PNCGJPNPPOP()
		{
			Dispose();
		}

		[DllImport("Winmm.dll", CharSet = CharSet.Auto, EntryPoint = "timeEndPeriod")]
		private static extern uint OHFFJMIJLBC(uint HAAOLNMEGHE);

		[SpecialName]
		public void ICDFKHHJDAI(bool ICENKPDOHBK)
		{
			JANKGDFLNKN = ICENKPDOHBK;
		}

		[SpecialName]
		public void AMKOBHEKELM(CGLHCCALMMC ICENKPDOHBK)
		{
			this.m_HOGDBCMCCLL = (CGLHCCALMMC)Delegate.Combine(this.m_HOGDBCMCCLL, ICENKPDOHBK);
		}

		public void JPBJAJALAAB()
		{
			Dispose();
		}

		public bool OAIBPCCMBHE()
		{
			return HNLOHMDGGKA;
		}

		[DllImport("Winmm.dll", CharSet = CharSet.Auto, EntryPoint = "timeSetEvent")]
		private static extern uint NDHJDFOBEEN(uint NCMFIFDEBBP, uint ALLJANOECKH, BMKBLGDCGDL LENBFPEPOFO, UIntPtr BPCKNIGGGGM, uint BKBDEHOLPGL);

		public void Dispose()
		{
			JDBENBMLFNP(true);
			GC.SuppressFinalize(this);
		}

		[DllImport("Winmm.dll", CharSet = CharSet.Auto, EntryPoint = "timeKillEvent")]
		private static extern uint HPCDHHDIMDG(uint NNADMLEALBE);

		public void BFGLBEPNDLB()
		{
			lock (DAHJAKJHOEN)
			{
				FLAIMHHIDLC();
				CPGHDLICIDN(false);
				BKBDEHOLPGL bKBDEHOLPGL = (BKBDEHOLPGL)(0 | (CJPOALOOMPK() ? 1 : 0));
				OHGOBGOIECH = NDHJDFOBEEN(GHBPLOOENCP(), 0u, FJFJHCJBHEL, UIntPtr.Zero, (uint)bKBDEHOLPGL);
				if (OHGOBGOIECH == 0)
				{
					throw new Exception("timeSetEvent error");
				}
				CPGHDLICIDN(true);
			}
		}
	}
}
