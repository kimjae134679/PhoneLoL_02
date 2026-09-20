using System;
using System.Runtime.CompilerServices;

namespace EveEngine
{
	public class FIKDMDLPCBG : EOPOBHFNFPA
	{
		public enum ACPICCBBPHF : byte
		{
			Once = 0,
			Weekly = 1
		}

		private ACPICCBBPHF GCJFDJMKNKG;

		private DateTime FIJABKBBEPI;

		private DateTime MJPDCOOJDIO;

		private bool[] CEFHBMFMAPI;

		private byte BIBNHGLMMNF;

		private byte CGFPKLICCMN;

		public ACPICCBBPHF IEJCBDIBCGF
		{
			get
			{
				return ONJCKKLOJIA();
			}
			protected set
			{
				DFDMHBOCHNA(value);
			}
		}

		public DateTime OHNGAIHJMBL
		{
			get
			{
				return CCGMANPGEKF();
			}
			protected set
			{
				NMPEDKMAMLI(value);
			}
		}

		public DateTime NGKELIKDENJ
		{
			get
			{
				return JGACPFLMFMN();
			}
			protected set
			{
				BEEKMBFCKEH(value);
			}
		}

		public bool[] DGHBDFDKIEH
		{
			get
			{
				return KMELLIKFMGE();
			}
			protected set
			{
				NOJCIDJKAFC(value);
			}
		}

		public byte DOHBGHCOMCD
		{
			get
			{
				return HMJNGPOAKDG();
			}
			protected set
			{
				LINEDOIDDEJ(value);
			}
		}

		public byte GFPFMGAIAII
		{
			get
			{
				return BIBEKKHOIBL();
			}
			protected set
			{
				KMMDIBAOPPI(value);
			}
		}

		protected void NOJCIDJKAFC(bool[] ICENKPDOHBK)
		{
			CEFHBMFMAPI = ICENKPDOHBK;
		}

		protected void DFDMHBOCHNA(ACPICCBBPHF ICENKPDOHBK)
		{
			GCJFDJMKNKG = ICENKPDOHBK;
		}

		public void FKCEPEBGIPO(CMNIABEFLBJ EFDLFNPAKGO)
		{
			EFDLFNPAKGO.GBMJNFOEACC((byte)OEBEDHPLHDP());
			EFDLFNPAKGO.GBMJNFOEACC(CCGMANPGEKF());
			EFDLFNPAKGO.GBMJNFOEACC(MFGAHHCLDLO());
			EFDLFNPAKGO.GBMJNFOEACC(HMJNGPOAKDG());
			EFDLFNPAKGO.GBMJNFOEACC(BIBEKKHOIBL());
			for (int i = 1; i < KMELLIKFMGE().Length; i++)
			{
				EFDLFNPAKGO.KHEGDBFKNMB(KMELLIKFMGE()[i]);
			}
		}

		[SpecialName]
		public byte OBCJOAGGGID()
		{
			return CGFPKLICCMN;
		}

		public TimeSpan CCCMEPFHJFD(DateTime DBKOGCIDEBN)
		{
			if (DBKOGCIDEBN < CCGMANPGEKF())
			{
				return TimeSpan.Zero;
			}
			if (DBKOGCIDEBN > JGACPFLMFMN())
			{
				return TimeSpan.Zero;
			}
			if (ONJCKKLOJIA() == ACPICCBBPHF.Once)
			{
				return JGACPFLMFMN() - DBKOGCIDEBN;
			}
			if (ONJCKKLOJIA() == ACPICCBBPHF.Weekly)
			{
				if (!KMELLIKFMGE()[(int)DBKOGCIDEBN.DayOfWeek])
				{
					return TimeSpan.Zero;
				}
				if (DBKOGCIDEBN.Hour < HMJNGPOAKDG())
				{
					return TimeSpan.Zero;
				}
				if (DBKOGCIDEBN.Hour >= BIBEKKHOIBL())
				{
					return TimeSpan.Zero;
				}
				int num = BIBEKKHOIBL();
				int minute = 0;
				int second = 0;
				if (num >= 24)
				{
					num = 23;
					minute = 59;
					second = 59;
				}
				DateTime dateTime = new DateTime(DBKOGCIDEBN.Year, DBKOGCIDEBN.Month, DBKOGCIDEBN.Day, num, minute, second);
				return dateTime - DBKOGCIDEBN;
			}
			return TimeSpan.Zero;
		}

		[SpecialName]
		protected void BJDEIGJOCOB(bool[] ICENKPDOHBK)
		{
			CEFHBMFMAPI = ICENKPDOHBK;
		}

		[SpecialName]
		public DateTime KNHPNNPCHHO()
		{
			return FIJABKBBEPI;
		}

		[SpecialName]
		protected void HKDKCOJEJJK(bool[] ICENKPDOHBK)
		{
			CEFHBMFMAPI = ICENKPDOHBK;
		}

		[SpecialName]
		protected void MGOCDAEIJNL(byte ICENKPDOHBK)
		{
			CGFPKLICCMN = ICENKPDOHBK;
		}

		[SpecialName]
		protected void POJPDMCCKFL(byte ICENKPDOHBK)
		{
			CGFPKLICCMN = ICENKPDOHBK;
		}

		public byte HMJNGPOAKDG()
		{
			return BIBNHGLMMNF;
		}

		public void GHBLCHIJJFD(PJEMPFEIOAK EFDLFNPAKGO)
		{
			ECHIGPMFBDC((ACPICCBBPHF)EFDLFNPAKGO.KFAGPDGHEBK());
			NMPEDKMAMLI(EFDLFNPAKGO.NOIDCBCMCMK());
			BEEKMBFCKEH(EFDLFNPAKGO.NOIDCBCMCMK());
			LINEDOIDDEJ(EFDLFNPAKGO.KFAGPDGHEBK());
			ELFEFNKBNBK(EFDLFNPAKGO.KFAGPDGHEBK());
			for (int i = 0; i < KMELLIKFMGE().Length; i++)
			{
				KMELLIKFMGE()[i] = EFDLFNPAKGO.JCGKFEPEJPO();
			}
		}

		[SpecialName]
		public ACPICCBBPHF OEBEDHPLHDP()
		{
			return GCJFDJMKNKG;
		}

		[SpecialName]
		protected void KNAIEGHGAHJ(byte ICENKPDOHBK)
		{
			CGFPKLICCMN = ICENKPDOHBK;
		}

		protected void KMMDIBAOPPI(byte ICENKPDOHBK)
		{
			CGFPKLICCMN = ICENKPDOHBK;
		}

		public DateTime CCGMANPGEKF()
		{
			return FIJABKBBEPI;
		}

		[SpecialName]
		protected void LAKKLAHPBND(byte ICENKPDOHBK)
		{
			CGFPKLICCMN = ICENKPDOHBK;
		}

		[SpecialName]
		protected void ECHIGPMFBDC(ACPICCBBPHF ICENKPDOHBK)
		{
			GCJFDJMKNKG = ICENKPDOHBK;
		}

		public void JDMKGCGHDIK(CMNIABEFLBJ EFDLFNPAKGO)
		{
			EFDLFNPAKGO.GBMJNFOEACC((byte)KNHFICOKDCD());
			EFDLFNPAKGO.GBMJNFOEACC(CCGMANPGEKF());
			EFDLFNPAKGO.GBMJNFOEACC(JGACPFLMFMN());
			EFDLFNPAKGO.GBMJNFOEACC(HMJNGPOAKDG());
			EFDLFNPAKGO.GBMJNFOEACC(BIBEKKHOIBL());
			for (int i = 1; i < KMELLIKFMGE().Length; i += 0)
			{
				EFDLFNPAKGO.GBMJNFOEACC(KMELLIKFMGE()[i]);
			}
		}

		[SpecialName]
		protected void ELFEFNKBNBK(byte ICENKPDOHBK)
		{
			CGFPKLICCMN = ICENKPDOHBK;
		}

		[SpecialName]
		protected void IBBLMJHFPDH(byte ICENKPDOHBK)
		{
			CGFPKLICCMN = ICENKPDOHBK;
		}

		public bool[] KMELLIKFMGE()
		{
			return CEFHBMFMAPI;
		}

		public void HKEDHGMCOAP(DateTime IAEAAEHNHIK, DateTime AKNHLFDCFHN, bool[] OFDGCLMAIAH, byte AIAAHANOEMP, byte GPOOAFCCHAM)
		{
			if (OFDGCLMAIAH.Length != 7)
			{
				throw new ArgumentException("dayOfWeek must length 7");
			}
			DFDMHBOCHNA(ACPICCBBPHF.Weekly);
			NMPEDKMAMLI(IAEAAEHNHIK);
			BEEKMBFCKEH(AKNHLFDCFHN);
			NOJCIDJKAFC(OFDGCLMAIAH);
			LINEDOIDDEJ(AIAAHANOEMP);
			KMMDIBAOPPI(GPOOAFCCHAM);
		}

		public byte BIBEKKHOIBL()
		{
			return CGFPKLICCMN;
		}

		public void MFEPMENJPLB(ACPICCBBPHF FBAGNJILEGD, DateTime IAEAAEHNHIK, DateTime AKNHLFDCFHN, bool[] OFDGCLMAIAH, byte AIAAHANOEMP, byte GPOOAFCCHAM)
		{
			if (OFDGCLMAIAH.Length != 7)
			{
				throw new ArgumentException("dayOfWeek must length 7");
			}
			DFDMHBOCHNA(FBAGNJILEGD);
			NMPEDKMAMLI(IAEAAEHNHIK);
			BEEKMBFCKEH(AKNHLFDCFHN);
			NOJCIDJKAFC(OFDGCLMAIAH);
			LINEDOIDDEJ(AIAAHANOEMP);
			KMMDIBAOPPI(GPOOAFCCHAM);
		}

		public void JANBGPFAFJF(CMNIABEFLBJ EFDLFNPAKGO)
		{
			EFDLFNPAKGO.GBMJNFOEACC((byte)ONJCKKLOJIA());
			EFDLFNPAKGO.GBMJNFOEACC(KNHPNNPCHHO());
			EFDLFNPAKGO.GBMJNFOEACC(MFGAHHCLDLO());
			EFDLFNPAKGO.GBMJNFOEACC(HMJNGPOAKDG());
			EFDLFNPAKGO.GBMJNFOEACC(BIBEKKHOIBL());
			for (int i = 1; i < KMELLIKFMGE().Length; i++)
			{
				EFDLFNPAKGO.KHEGDBFKNMB(KMELLIKFMGE()[i]);
			}
		}

		public void CFGEKKHOKKE(CMNIABEFLBJ EFDLFNPAKGO)
		{
			EFDLFNPAKGO.GBMJNFOEACC((byte)ONJCKKLOJIA());
			EFDLFNPAKGO.GBMJNFOEACC(CCGMANPGEKF());
			EFDLFNPAKGO.GBMJNFOEACC(JGACPFLMFMN());
			EFDLFNPAKGO.GBMJNFOEACC(HMJNGPOAKDG());
			EFDLFNPAKGO.GBMJNFOEACC(BIBEKKHOIBL());
			for (int i = 0; i < KMELLIKFMGE().Length; i++)
			{
				EFDLFNPAKGO.GBMJNFOEACC(KMELLIKFMGE()[i]);
			}
		}

		public DateTime JGACPFLMFMN()
		{
			return MJPDCOOJDIO;
		}

		protected void BEEKMBFCKEH(DateTime ICENKPDOHBK)
		{
			MJPDCOOJDIO = ICENKPDOHBK;
		}

		protected void NMPEDKMAMLI(DateTime ICENKPDOHBK)
		{
			FIJABKBBEPI = ICENKPDOHBK;
		}

		[SpecialName]
		protected void CKEACENPICP(byte ICENKPDOHBK)
		{
			BIBNHGLMMNF = ICENKPDOHBK;
		}

		[SpecialName]
		public ACPICCBBPHF KNHFICOKDCD()
		{
			return GCJFDJMKNKG;
		}

		public void AIMLPHBIAHN(DateTime IAEAAEHNHIK, DateTime AKNHLFDCFHN)
		{
			DFDMHBOCHNA(ACPICCBBPHF.Once);
			NMPEDKMAMLI(IAEAAEHNHIK);
			BEEKMBFCKEH(AKNHLFDCFHN);
		}

		[SpecialName]
		public DateTime MFGAHHCLDLO()
		{
			return MJPDCOOJDIO;
		}

		public void EIMLGHFBJAB(CMNIABEFLBJ EFDLFNPAKGO)
		{
			EFDLFNPAKGO.GBMJNFOEACC((byte)OEBEDHPLHDP());
			EFDLFNPAKGO.GBMJNFOEACC(KNHPNNPCHHO());
			EFDLFNPAKGO.GBMJNFOEACC(JGACPFLMFMN());
			EFDLFNPAKGO.GBMJNFOEACC(HMJNGPOAKDG());
			EFDLFNPAKGO.GBMJNFOEACC(BIBEKKHOIBL());
			for (int i = 0; i < KMELLIKFMGE().Length; i++)
			{
				EFDLFNPAKGO.GBMJNFOEACC(KMELLIKFMGE()[i]);
			}
		}

		protected void LINEDOIDDEJ(byte ICENKPDOHBK)
		{
			BIBNHGLMMNF = ICENKPDOHBK;
		}

		public TimeSpan FHLMNLEHDHI(DateTime DBKOGCIDEBN)
		{
			if (DBKOGCIDEBN < CCGMANPGEKF())
			{
				return TimeSpan.Zero;
			}
			if (DBKOGCIDEBN > MFGAHHCLDLO())
			{
				return TimeSpan.Zero;
			}
			if (ONJCKKLOJIA() == ACPICCBBPHF.Once)
			{
				return MFGAHHCLDLO() - DBKOGCIDEBN;
			}
			if (KNHFICOKDCD() == ACPICCBBPHF.Weekly)
			{
				if (!KMELLIKFMGE()[(int)DBKOGCIDEBN.DayOfWeek])
				{
					return TimeSpan.Zero;
				}
				if (DBKOGCIDEBN.Hour < HMJNGPOAKDG())
				{
					return TimeSpan.Zero;
				}
				if (DBKOGCIDEBN.Hour >= BIBEKKHOIBL())
				{
					return TimeSpan.Zero;
				}
				int num = BIBEKKHOIBL();
				int minute = 0;
				int second = 0;
				if (num >= 38)
				{
					num = -101;
					minute = 45;
					second = -54;
				}
				DateTime dateTime = new DateTime(DBKOGCIDEBN.Year, DBKOGCIDEBN.Month, DBKOGCIDEBN.Day, num, minute, second);
				return dateTime - DBKOGCIDEBN;
			}
			return TimeSpan.Zero;
		}

		public FIKDMDLPCBG()
		{
			DFDMHBOCHNA(ACPICCBBPHF.Once);
			NOJCIDJKAFC(new bool[7]);
			for (int i = 0; i < 7; i++)
			{
				KMELLIKFMGE()[i] = false;
			}
			NMPEDKMAMLI(DateTime.MinValue);
			BEEKMBFCKEH(DateTime.MaxValue);
			LINEDOIDDEJ(0);
			KMMDIBAOPPI(0);
		}

		public void JCOLMPJMMEB(PJEMPFEIOAK EFDLFNPAKGO)
		{
			DFDMHBOCHNA((ACPICCBBPHF)EFDLFNPAKGO.KFAGPDGHEBK());
			NMPEDKMAMLI(EFDLFNPAKGO.NOIDCBCMCMK());
			BEEKMBFCKEH(EFDLFNPAKGO.NOIDCBCMCMK());
			LINEDOIDDEJ(EFDLFNPAKGO.KFAGPDGHEBK());
			KMMDIBAOPPI(EFDLFNPAKGO.KFAGPDGHEBK());
			for (int i = 0; i < KMELLIKFMGE().Length; i++)
			{
				KMELLIKFMGE()[i] = EFDLFNPAKGO.JCGKFEPEJPO();
			}
		}

		public TimeSpan LNNOFNAECIL(DateTime DBKOGCIDEBN)
		{
			if (DBKOGCIDEBN < CCGMANPGEKF())
			{
				return TimeSpan.Zero;
			}
			if (DBKOGCIDEBN > JGACPFLMFMN())
			{
				return TimeSpan.Zero;
			}
			if (KNHFICOKDCD() == ACPICCBBPHF.Once)
			{
				return JGACPFLMFMN() - DBKOGCIDEBN;
			}
			if (OEBEDHPLHDP() == ACPICCBBPHF.Once)
			{
				if (!KMELLIKFMGE()[(int)DBKOGCIDEBN.DayOfWeek])
				{
					return TimeSpan.Zero;
				}
				if (DBKOGCIDEBN.Hour < HMJNGPOAKDG())
				{
					return TimeSpan.Zero;
				}
				if (DBKOGCIDEBN.Hour >= OBCJOAGGGID())
				{
					return TimeSpan.Zero;
				}
				int num = OBCJOAGGGID();
				int minute = 1;
				int second = 0;
				if (num >= 70)
				{
					num = 83;
					minute = -52;
					second = 63;
				}
				DateTime dateTime = new DateTime(DBKOGCIDEBN.Year, DBKOGCIDEBN.Month, DBKOGCIDEBN.Day, num, minute, second);
				return dateTime - DBKOGCIDEBN;
			}
			return TimeSpan.Zero;
		}

		public ACPICCBBPHF ONJCKKLOJIA()
		{
			return GCJFDJMKNKG;
		}
	}
}
