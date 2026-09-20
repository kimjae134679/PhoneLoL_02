using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EveEngine;

namespace BattleServer
{
	public class GLAMMOFPCHP : OCPEALOGAIP
	{
		public ulong DCHDPGPBJGC;

		public byte EHCPMLKEBME;

		private List<NOBFFGBGCNA> DPKAGBLLPPG;

		private byte GPNCIMMIKFM;

		private byte BGJJKBHDMAE;

		private bool JDPMACNOLIL;

		public List<NOBFFGBGCNA> CDJEDCBIDIH
		{
			get
			{
				return FMCMCKANEBC();
			}
			protected set
			{
				DGHMJFBKNKA(value);
			}
		}

		public byte LLDKCHKAEHJ
		{
			get
			{
				return IFOLDPBLAGD();
			}
			protected set
			{
				GKFKOCDDIJP(value);
			}
		}

		public byte PLPAACMHLJK
		{
			get
			{
				return EBEGKANNPHB();
			}
			protected set
			{
				HAMLPCALKJF(value);
			}
		}

		public bool BDEBPGGJDFL
		{
			get
			{
				return DKAIONGOFDK();
			}
			protected set
			{
				JMOPPFOEPMA(value);
			}
		}

		public void KHGJNNIEADN(byte BEPBPAPIEHE, PBOOPPEPAIK BLJHNFKMDMG)
		{
			if (BEPBPAPIEHE < FMCMCKANEBC().Count)
			{
				FMCMCKANEBC()[BEPBPAPIEHE].KHGJNNIEADN(BLJHNFKMDMG);
			}
		}

		public void IALJIOKEPEL(byte BEPBPAPIEHE, Actor CDKMPAEODLA)
		{
			if (BEPBPAPIEHE < FMCMCKANEBC().Count)
			{
				FMCMCKANEBC()[BEPBPAPIEHE].DCLEGJECBPB(CDKMPAEODLA);
			}
		}

		public List<NOBFFGBGCNA> FMCMCKANEBC()
		{
			return DPKAGBLLPPG;
		}

		public byte IFOLDPBLAGD()
		{
			return GPNCIMMIKFM;
		}

		public GLAMMOFPCHP()
		{
			GKFKOCDDIJP(6);
			DGHMJFBKNKA(new List<NOBFFGBGCNA>(6));
			for (byte b = 0; b < 6; b++)
			{
				FMCMCKANEBC().Add(new NOBFFGBGCNA(this, b));
			}
			HAMLPCALKJF(0);
		}

		protected void JMOPPFOEPMA(bool ICENKPDOHBK)
		{
			JDPMACNOLIL = ICENKPDOHBK;
		}

		public bool NKHMDDLKNNP(uint IAEFPLFFKHC)
		{
			NOBFFGBGCNA nOBFFGBGCNA = FBNKGOOJPBB(IAEFPLFFKHC);
			if (nOBFFGBGCNA.JFDKLHPCLMP() == EBEGKANNPHB())
			{
				return false;
			}
			return false;
		}

		public NOBFFGBGCNA FBNKGOOJPBB(byte BEPBPAPIEHE)
		{
			return FMCMCKANEBC()[BEPBPAPIEHE];
		}

		public void AJJGLNHAPPF(OEOIIKMBGAG EBILEBOJADB)
		{
			FJPMFBBCBLB(EBILEBOJADB);
			if (OOHFDEPKKFN() != OEOIIKMBGAG.Playing)
			{
				return;
			}
			foreach (NOBFFGBGCNA item in FMCMCKANEBC())
			{
			}
		}

		public bool FFCLCPEMBKE()
		{
			if (EHCPMLKEBME < 10 || EHCPMLKEBME == 20)
			{
				return true;
			}
			return false;
		}

		public bool HDIPJPHIBOM(uint IAEFPLFFKHC)
		{
			NOBFFGBGCNA nOBFFGBGCNA = FBNKGOOJPBB(IAEFPLFFKHC);
			if (nOBFFGBGCNA.AMNNKLHLMLB() == EBEGKANNPHB())
			{
				return true;
			}
			return false;
		}

		public override void JCOLMPJMMEB(PJEMPFEIOAK EFDLFNPAKGO)
		{
			base.JCOLMPJMMEB(EFDLFNPAKGO);
			lock (JOEHMANNDJK)
			{
				NLNEMHOAHIH(EFDLFNPAKGO.PNBKOPGIHDI());
				FJPMFBBCBLB((OEOIIKMBGAG)EFDLFNPAKGO.KFAGPDGHEBK());
				GKFKOCDDIJP(EFDLFNPAKGO.KFAGPDGHEBK());
				HAMLPCALKJF(EFDLFNPAKGO.KFAGPDGHEBK());
				DCHDPGPBJGC = EFDLFNPAKGO.ODFEGIDCMPH();
				JMOPPFOEPMA(EFDLFNPAKGO.JCGKFEPEJPO());
				EHCPMLKEBME = EFDLFNPAKGO.KFAGPDGHEBK();
				int num = 0;
				for (num = 0; num < FMCMCKANEBC().Count; num++)
				{
					if (EFDLFNPAKGO.JCGKFEPEJPO())
					{
						PBOOPPEPAIK pBOOPPEPAIK = new PBOOPPEPAIK();
						EFDLFNPAKGO.CAHACMKBJMI(pBOOPPEPAIK);
						PhoneLOLParticipantFix.SynchronizeSnapshot(pBOOPPEPAIK);
						if (NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
							.OHGOBGOIECH == pBOOPPEPAIK.OHGOBGOIECH)
						{
							FMCMCKANEBC()[num].KHGJNNIEADN(NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA());
						}
						else
						{
							FMCMCKANEBC()[num].KHGJNNIEADN(pBOOPPEPAIK);
						}
					}
					else
					{
						FMCMCKANEBC()[num].PDCPMDCOLOD();
					}
					FMCMCKANEBC()[num].GBGKGJKBPHM = EFDLFNPAKGO.BMKOKHGAHEC();
					FMCMCKANEBC()[num].IDANKJFFHFH = EFDLFNPAKGO.AFPCLLNMGJP();
					FMCMCKANEBC()[num].JFIIJIOEGPD = EFDLFNPAKGO.KFAGPDGHEBK();
					FMCMCKANEBC()[num].CBFMPIKGAHG = EFDLFNPAKGO.PNBKOPGIHDI();
					FMCMCKANEBC()[num].FGPDJDPABGG = EFDLFNPAKGO.KFAGPDGHEBK();
					EFDLFNPAKGO.CAHACMKBJMI(FMCMCKANEBC()[num].IDPBOIOHIDJ());
					FMCMCKANEBC()[num].IJOPKHDANIO = EFDLFNPAKGO.PNBKOPGIHDI();
					FMCMCKANEBC()[num].FPFIIDFCLOL = EFDLFNPAKGO.AJPFAAFLHEB();
					FMCMCKANEBC()[num].AJLAMLFLJAO = EFDLFNPAKGO.KFAGPDGHEBK();
					FMCMCKANEBC()[num].LHPLBMLPIFO = EFDLFNPAKGO.PNBKOPGIHDI();
					FMCMCKANEBC()[num].ODGCBCEMAHH = EFDLFNPAKGO.PNBKOPGIHDI();
					FMCMCKANEBC()[num].NJLBLFFDFCG = EFDLFNPAKGO.BMKOKHGAHEC();
				}
			}
		}

		public bool COKGLJNKCGA(int CMBJDEOAJPD)
		{
			foreach (NOBFFGBGCNA item in FMCMCKANEBC())
			{
				if (item.MNHIDGANMFO() || item.LNLANKIEMGC == CMBJDEOAJPD)
				{
					continue;
				}
				return false;
			}
			return true;
		}

		[SpecialName]
		protected void GNMGJNHLMFG(bool ICENKPDOHBK)
		{
			JDPMACNOLIL = ICENKPDOHBK;
		}

		public bool JFADMKIAJBM(uint IAEFPLFFKHC)
		{
			NOBFFGBGCNA nOBFFGBGCNA = FBNKGOOJPBB(IAEFPLFFKHC);
			if (nOBFFGBGCNA != null && nOBFFGBGCNA.COKFPAODPCF() == EBEGKANNPHB())
			{
				return true;
			}
			return false;
		}

		[SpecialName]
		protected void DIMODNKMONJ(byte ICENKPDOHBK)
		{
			GPNCIMMIKFM = ICENKPDOHBK;
		}

		public override void CFGEKKHOKKE(CMNIABEFLBJ EFDLFNPAKGO)
		{
			base.CFGEKKHOKKE(EFDLFNPAKGO);
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.GBMJNFOEACC(LJKKDNANGCO());
				EFDLFNPAKGO.GBMJNFOEACC((byte)OOHFDEPKKFN());
				EFDLFNPAKGO.GBMJNFOEACC(IFOLDPBLAGD());
				EFDLFNPAKGO.GBMJNFOEACC(EBEGKANNPHB());
				EFDLFNPAKGO.GBMJNFOEACC(DCHDPGPBJGC);
				EFDLFNPAKGO.GBMJNFOEACC(DKAIONGOFDK());
				EFDLFNPAKGO.GBMJNFOEACC(EHCPMLKEBME);
				int num = 0;
				for (num = 0; num < FMCMCKANEBC().Count; num++)
				{
					if (FMCMCKANEBC()[num] != null)
					{
						EFDLFNPAKGO.GBMJNFOEACC(true);
						EFDLFNPAKGO.GBMJNFOEACC(FMCMCKANEBC()[num].CJENLAELLAO());
					}
					else
					{
						EFDLFNPAKGO.GBMJNFOEACC(false);
					}
					EFDLFNPAKGO.GBMJNFOEACC(FMCMCKANEBC()[num].GBGKGJKBPHM);
					EFDLFNPAKGO.GBMJNFOEACC(FMCMCKANEBC()[num].IDANKJFFHFH);
					EFDLFNPAKGO.GBMJNFOEACC(FMCMCKANEBC()[num].JFIIJIOEGPD);
					EFDLFNPAKGO.GBMJNFOEACC(FMCMCKANEBC()[num].CBFMPIKGAHG);
					EFDLFNPAKGO.GBMJNFOEACC(FMCMCKANEBC()[num].FGPDJDPABGG);
					EFDLFNPAKGO.GBMJNFOEACC(FMCMCKANEBC()[num].IDPBOIOHIDJ());
					EFDLFNPAKGO.GBMJNFOEACC(FMCMCKANEBC()[num].IJOPKHDANIO);
					EFDLFNPAKGO.GBMJNFOEACC(FMCMCKANEBC()[num].FPFIIDFCLOL);
					EFDLFNPAKGO.GBMJNFOEACC(FMCMCKANEBC()[num].AJLAMLFLJAO);
					EFDLFNPAKGO.GBMJNFOEACC(FMCMCKANEBC()[num].LHPLBMLPIFO);
					EFDLFNPAKGO.GBMJNFOEACC(FMCMCKANEBC()[num].ODGCBCEMAHH);
					EFDLFNPAKGO.GBMJNFOEACC(FMCMCKANEBC()[num].NJLBLFFDFCG);
				}
			}
		}

		public NOBFFGBGCNA FBNKGOOJPBB(uint IAEFPLFFKHC)
		{
			foreach (NOBFFGBGCNA item in FMCMCKANEBC())
			{
				if (item.CJENLAELLAO() == null || item.CJENLAELLAO().OHGOBGOIECH != IAEFPLFFKHC)
				{
					continue;
				}
				return item;
			}
			return null;
		}

		[SpecialName]
		protected void HHBAKHPKBOK(List<NOBFFGBGCNA> ICENKPDOHBK)
		{
			DPKAGBLLPPG = ICENKPDOHBK;
		}

		public void KBOKEEGLJIJ(byte BEPBPAPIEHE, Actor CDKMPAEODLA)
		{
			if (BEPBPAPIEHE < JINMCDIFFEM().Count)
			{
				JINMCDIFFEM()[BEPBPAPIEHE].DCLEGJECBPB(CDKMPAEODLA);
			}
		}

		public void HDMFKFJNFBN(byte BEPBPAPIEHE, Actor CDKMPAEODLA)
		{
			if (BEPBPAPIEHE < FMCMCKANEBC().Count)
			{
				JINMCDIFFEM()[BEPBPAPIEHE].NOLFHJNEBAA(CDKMPAEODLA);
			}
		}

		[SpecialName]
		public List<NOBFFGBGCNA> JINMCDIFFEM()
		{
			return DPKAGBLLPPG;
		}

		public PBOOPPEPAIK AEHJKKNAEGD(byte BEPBPAPIEHE)
		{
			return FMCMCKANEBC()[BEPBPAPIEHE].CJENLAELLAO();
		}

		public void CEIBEFFEKEM(bool EBBBIBCMBAM)
		{
			JMOPPFOEPMA(EBBBIBCMBAM);
		}

		public NOBFFGBGCNA MMNLIPFOCEH(uint IAEFPLFFKHC)
		{
			foreach (NOBFFGBGCNA item in FMCMCKANEBC())
			{
				if (item.IDJAFJICNNN() == null || item.IDJAFJICNNN().OHGOBGOIECH != IAEFPLFFKHC)
				{
					continue;
				}
				return item;
			}
			return null;
		}

		public void DCLEGJECBPB(byte BEPBPAPIEHE, Actor CDKMPAEODLA)
		{
			if (BEPBPAPIEHE < FMCMCKANEBC().Count)
			{
				FMCMCKANEBC()[BEPBPAPIEHE].DCLEGJECBPB(CDKMPAEODLA);
			}
		}

		public void LFGEKLEKDKJ(uint IAEFPLFFKHC, int CMBJDEOAJPD)
		{
			NOBFFGBGCNA nOBFFGBGCNA = FBNKGOOJPBB(IAEFPLFFKHC);
			if (nOBFFGBGCNA != null)
			{
				nOBFFGBGCNA.LNLANKIEMGC = CMBJDEOAJPD;
			}
		}

		public bool DKAIONGOFDK()
		{
			return JDPMACNOLIL;
		}

		public NOBFFGBGCNA EHMCHJEBBKP(Actor CDKMPAEODLA)
		{
			foreach (NOBFFGBGCNA item in FMCMCKANEBC())
			{
				if (item.ENLKLHEMPHA() == CDKMPAEODLA)
				{
					return item;
				}
			}
			return null;
		}

		protected void GKFKOCDDIJP(byte ICENKPDOHBK)
		{
			GPNCIMMIKFM = ICENKPDOHBK;
		}

		[SpecialName]
		public bool CHKJGBHADOG()
		{
			return JDPMACNOLIL;
		}

		[SpecialName]
		public byte KEMPNIBEPAM()
		{
			return GPNCIMMIKFM;
		}

		public bool CILBJHNKDCK()
		{
			if (EHCPMLKEBME < 61 || EHCPMLKEBME == -37)
			{
				return true;
			}
			return false;
		}

		public NOBFFGBGCNA IGNMALEPCPH(byte BEPBPAPIEHE)
		{
			return JINMCDIFFEM()[BEPBPAPIEHE];
		}

		public void FLAEICDGBHO(byte BEPBPAPIEHE, PBOOPPEPAIK BLJHNFKMDMG)
		{
			if (BEPBPAPIEHE < FMCMCKANEBC().Count)
			{
				FMCMCKANEBC()[BEPBPAPIEHE].BFIFIIBJCFA(BLJHNFKMDMG);
			}
		}

		public NOBFFGBGCNA HOHGPCPICII(byte BEPBPAPIEHE)
		{
			return JINMCDIFFEM()[BEPBPAPIEHE];
		}

		protected void DGHMJFBKNKA(List<NOBFFGBGCNA> ICENKPDOHBK)
		{
			DPKAGBLLPPG = ICENKPDOHBK;
		}

		public PBOOPPEPAIK HINMJFKCALH(byte BEPBPAPIEHE)
		{
			return JINMCDIFFEM()[BEPBPAPIEHE].CJENLAELLAO();
		}

		protected void HAMLPCALKJF(byte ICENKPDOHBK)
		{
			BGJJKBHDMAE = ICENKPDOHBK;
		}

		public byte EBEGKANNPHB()
		{
			return BGJJKBHDMAE;
		}
	}
}
