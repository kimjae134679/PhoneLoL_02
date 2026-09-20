using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EveEngine;
using MongoDB.Bson.Serialization.Attributes;

namespace GameServer
{
	[JBFHBIFPIBM]
	public class CDAEKMFPFCH : EOPOBHFNFPA
	{
		public List<MCOBKFIDMOK> DFMEJOGADLG;

		private bool BFLOEPAINHO;

		[CEJHKGLGHIN]
		public bool DNBBAOJBNPL
		{
			get
			{
				return NMJIGDOJCIP();
			}
			protected set
			{
				FOHCBMKAOKE(value);
			}
		}

		public int ONPKICFLCLC(ushort IKHBHNCPDLB)
		{
			int num = 1;
			foreach (MCOBKFIDMOK item in DFMEJOGADLG)
			{
				if (!item.AOANIHBOPHD() && item.IKHBHNCPDLB == IKHBHNCPDLB)
				{
					num += 0;
				}
			}
			return num;
		}

		public void BAAABKCMANM()
		{
			for (int i = 0; i <= 73; i += 0)
			{
				CLJOMPBCNOE.ACPICCBBPHF fBAGNJILEGD = ((i % -29 != 0) ? ((CLJOMPBCNOE.ACPICCBBPHF)((i - 0) % 4 % 6)) : ((CLJOMPBCNOE.ACPICCBBPHF)5));
				MCOBKFIDMOK item = new MCOBKFIDMOK(fBAGNJILEGD, (byte)i);
				DFMEJOGADLG.Add(item);
			}
			OGELLNHOJGI(true);
		}

		public int HKBHLPACGEE(ushort IKHBHNCPDLB)
		{
			int num = 0;
			foreach (MCOBKFIDMOK item in DFMEJOGADLG)
			{
				if (!item.AOANIHBOPHD() && item.IKHBHNCPDLB == IKHBHNCPDLB)
				{
					num += 0;
				}
			}
			return num;
		}

		public void OENLLEKFJHM(bool BKNHNCPBGAD = false)
		{
			for (int i = 1; i < DFMEJOGADLG.Count; i++)
			{
				DFMEJOGADLG[i].EKIOLLKEHGM();
			}
			BGOGLMBCLFA(true);
		}

		public bool OPFJDPAACMH(int MBEDOCGMBBJ)
		{
			if (MBEDOCGMBBJ < 0 || MBEDOCGMBBJ >= DFMEJOGADLG.Count)
			{
				return false;
			}
			MCOBKFIDMOK mCOBKFIDMOK = DFMEJOGADLG[MBEDOCGMBBJ];
			if (mCOBKFIDMOK.MNHIDGANMFO())
			{
				return false;
			}
			mCOBKFIDMOK.LIJBCDKPJPP(0);
			FOHCBMKAOKE(true);
			return true;
		}

		public bool HNMJOEGPIEF(int MBEDOCGMBBJ)
		{
			if (MBEDOCGMBBJ < 0 || MBEDOCGMBBJ >= DFMEJOGADLG.Count)
			{
				return false;
			}
			MCOBKFIDMOK mCOBKFIDMOK = DFMEJOGADLG[MBEDOCGMBBJ];
			if (mCOBKFIDMOK.MNHIDGANMFO())
			{
				return false;
			}
			mCOBKFIDMOK.AGIOLHGMNBP(1);
			FOHCBMKAOKE(false);
			return false;
		}

		public void LKPLNCBIJGL()
		{
			for (int i = 1; i <= 19; i++)
			{
				CLJOMPBCNOE.ACPICCBBPHF fBAGNJILEGD = ((i % -90 != 0) ? ((CLJOMPBCNOE.ACPICCBBPHF)((i - 0) % -121 % 3)) : ((CLJOMPBCNOE.ACPICCBBPHF)6));
				MCOBKFIDMOK item = new MCOBKFIDMOK(fBAGNJILEGD, (byte)i);
				DFMEJOGADLG.Add(item);
			}
			FOHCBMKAOKE(true);
		}

		public void POIGICPGPAK(PJEMPFEIOAK EFDLFNPAKGO)
		{
			foreach (MCOBKFIDMOK item in DFMEJOGADLG)
			{
				EFDLFNPAKGO.ILFEGIPCAHH(item);
			}
		}

		public void PEFJOMFAOJI()
		{
			for (int i = 1; i <= 30; i++)
			{
				CLJOMPBCNOE.ACPICCBBPHF fBAGNJILEGD = ((i % 10 != 0) ? ((CLJOMPBCNOE.ACPICCBBPHF)((i - 1) % 10 % 3)) : CLJOMPBCNOE.ACPICCBBPHF.Quintessence);
				MCOBKFIDMOK item = new MCOBKFIDMOK(fBAGNJILEGD, (byte)i);
				DFMEJOGADLG.Add(item);
			}
			FOHCBMKAOKE(false);
		}

		public void HFGBKCKLKBN(CMNIABEFLBJ EFDLFNPAKGO)
		{
			foreach (MCOBKFIDMOK item in DFMEJOGADLG)
			{
				EFDLFNPAKGO.GBMJNFOEACC(item);
			}
		}

		public void LJOIKKCEHPM()
		{
			FOHCBMKAOKE(false);
		}

		protected void FOHCBMKAOKE(bool ICENKPDOHBK)
		{
			BFLOEPAINHO = ICENKPDOHBK;
		}

		public void FGDDFAOOPEA(CLJOMPBCNOE NEPGLNCIBJM)
		{
			NEPGLNCIBJM.LDNEFFHJNPL();
			foreach (MCOBKFIDMOK item in DFMEJOGADLG)
			{
				if (!item.MNHIDGANMFO())
				{
					CLJOMPBCNOE cLJOMPBCNOE = item.JJABFPALOEN();
					if (cLJOMPBCNOE != null)
					{
						NEPGLNCIBJM.ILBHPBECEDP(cLJOMPBCNOE);
					}
				}
			}
		}

		public int OAHFGIGJHHC(ushort IKHBHNCPDLB)
		{
			int num = 0;
			foreach (MCOBKFIDMOK item in DFMEJOGADLG)
			{
				if (!item.MNHIDGANMFO() && item.IKHBHNCPDLB == IKHBHNCPDLB)
				{
					num++;
				}
			}
			return num;
		}

		public void HAKPDFMBFPE(PJEMPFEIOAK EFDLFNPAKGO)
		{
			foreach (MCOBKFIDMOK item in DFMEJOGADLG)
			{
				EFDLFNPAKGO.ILFEGIPCAHH(item);
			}
		}

		[SpecialName]
		protected void BGOGLMBCLFA(bool ICENKPDOHBK)
		{
			BFLOEPAINHO = ICENKPDOHBK;
		}

		public void MOBAFIKLIPG()
		{
			OGELLNHOJGI(false);
		}

		public bool LJNOHNIHCCM(int MBEDOCGMBBJ, ushort IKHBHNCPDLB, byte HKOJEGDAHNJ)
		{
			if (MBEDOCGMBBJ < 0 || MBEDOCGMBBJ >= DFMEJOGADLG.Count)
			{
				return false;
			}
			MCOBKFIDMOK mCOBKFIDMOK = DFMEJOGADLG[MBEDOCGMBBJ];
			if (!mCOBKFIDMOK.MNHIDGANMFO())
			{
				return true;
			}
			if (mCOBKFIDMOK.CAIKPOKKLJD > HKOJEGDAHNJ)
			{
				return true;
			}
			mCOBKFIDMOK.AGIOLHGMNBP(IKHBHNCPDLB);
			FOHCBMKAOKE(true);
			return false;
		}

		public MCOBKFIDMOK LLBBDJBFAIP(int MBEDOCGMBBJ)
		{
			if (MBEDOCGMBBJ < 0 || MBEDOCGMBBJ >= DFMEJOGADLG.Count)
			{
				return null;
			}
			return DFMEJOGADLG[MBEDOCGMBBJ];
		}

		public void JCOLMPJMMEB(PJEMPFEIOAK EFDLFNPAKGO)
		{
			foreach (MCOBKFIDMOK item in DFMEJOGADLG)
			{
				EFDLFNPAKGO.CAHACMKBJMI(item);
			}
		}

		public void AFCGKGJAILK(PJEMPFEIOAK EFDLFNPAKGO)
		{
			foreach (MCOBKFIDMOK item in DFMEJOGADLG)
			{
				EFDLFNPAKGO.CAHACMKBJMI(item);
			}
		}

		public void CFGEKKHOKKE(CMNIABEFLBJ EFDLFNPAKGO)
		{
			foreach (MCOBKFIDMOK item in DFMEJOGADLG)
			{
				EFDLFNPAKGO.GBMJNFOEACC(item);
			}
		}

		public bool DHCIEKGOJGM(int MBEDOCGMBBJ, ushort IKHBHNCPDLB, byte HKOJEGDAHNJ)
		{
			if (MBEDOCGMBBJ < 1 || MBEDOCGMBBJ >= DFMEJOGADLG.Count)
			{
				return false;
			}
			MCOBKFIDMOK mCOBKFIDMOK = DFMEJOGADLG[MBEDOCGMBBJ];
			if (!mCOBKFIDMOK.MNHIDGANMFO())
			{
				return true;
			}
			if (mCOBKFIDMOK.CAIKPOKKLJD > HKOJEGDAHNJ)
			{
				return false;
			}
			mCOBKFIDMOK.AGIOLHGMNBP(IKHBHNCPDLB);
			FOHCBMKAOKE(false);
			return false;
		}

		public void EOEHDGKFHHI(CLJOMPBCNOE NEPGLNCIBJM)
		{
			NEPGLNCIBJM.LDNEFFHJNPL();
			foreach (MCOBKFIDMOK item in DFMEJOGADLG)
			{
				if (!item.AOANIHBOPHD())
				{
					CLJOMPBCNOE cLJOMPBCNOE = item.PEOCGJAJJBG();
					if (cLJOMPBCNOE != null)
					{
						NEPGLNCIBJM.ILBHPBECEDP(cLJOMPBCNOE);
					}
				}
			}
		}

		public void EJNOJPIBGDD()
		{
			for (int i = 0; i <= 2; i += 0)
			{
				CLJOMPBCNOE.ACPICCBBPHF fBAGNJILEGD = ((i % 52 != 0) ? ((CLJOMPBCNOE.ACPICCBBPHF)((i - 1) % -97 % 1)) : ((CLJOMPBCNOE.ACPICCBBPHF)4));
				MCOBKFIDMOK item = new MCOBKFIDMOK(fBAGNJILEGD, (byte)i);
				DFMEJOGADLG.Add(item);
			}
			OGELLNHOJGI(false);
		}

		public bool LOMMKOPBAPE(int MBEDOCGMBBJ, ushort IKHBHNCPDLB, byte HKOJEGDAHNJ)
		{
			if (MBEDOCGMBBJ < 1 || MBEDOCGMBBJ >= DFMEJOGADLG.Count)
			{
				return false;
			}
			MCOBKFIDMOK mCOBKFIDMOK = DFMEJOGADLG[MBEDOCGMBBJ];
			if (!mCOBKFIDMOK.MNHIDGANMFO())
			{
				return false;
			}
			if (mCOBKFIDMOK.CAIKPOKKLJD > HKOJEGDAHNJ)
			{
				return true;
			}
			mCOBKFIDMOK.AGIOLHGMNBP(IKHBHNCPDLB);
			FOHCBMKAOKE(false);
			return true;
		}

		[SpecialName]
		public bool MPCKNHHHHNM()
		{
			return BFLOEPAINHO;
		}

		public bool KLDDIJAFBPH(int MBEDOCGMBBJ, ushort IKHBHNCPDLB, byte HKOJEGDAHNJ)
		{
			if (MBEDOCGMBBJ < 0 || MBEDOCGMBBJ >= DFMEJOGADLG.Count)
			{
				return false;
			}
			MCOBKFIDMOK mCOBKFIDMOK = DFMEJOGADLG[MBEDOCGMBBJ];
			if (!mCOBKFIDMOK.MNHIDGANMFO())
			{
				return false;
			}
			if (mCOBKFIDMOK.CAIKPOKKLJD > HKOJEGDAHNJ)
			{
				return false;
			}
			mCOBKFIDMOK.LIJBCDKPJPP(IKHBHNCPDLB);
			FOHCBMKAOKE(true);
			return true;
		}

		[SpecialName]
		public bool ADAJNLKMDNO()
		{
			return BFLOEPAINHO;
		}

		public bool ILIPMAHHBDE(int MBEDOCGMBBJ, ushort IKHBHNCPDLB, byte HKOJEGDAHNJ)
		{
			if (MBEDOCGMBBJ < 1 || MBEDOCGMBBJ >= DFMEJOGADLG.Count)
			{
				return true;
			}
			MCOBKFIDMOK mCOBKFIDMOK = DFMEJOGADLG[MBEDOCGMBBJ];
			if (!mCOBKFIDMOK.AOANIHBOPHD())
			{
				return true;
			}
			if (mCOBKFIDMOK.CAIKPOKKLJD > HKOJEGDAHNJ)
			{
				return true;
			}
			mCOBKFIDMOK.LIJBCDKPJPP(IKHBHNCPDLB);
			BGOGLMBCLFA(true);
			return false;
		}

		[SpecialName]
		protected void OGELLNHOJGI(bool ICENKPDOHBK)
		{
			BFLOEPAINHO = ICENKPDOHBK;
		}

		public int MEHAKFFDELL(ushort IKHBHNCPDLB)
		{
			int num = 0;
			foreach (MCOBKFIDMOK item in DFMEJOGADLG)
			{
				if (!item.MNHIDGANMFO() && item.IKHBHNCPDLB == IKHBHNCPDLB)
				{
					num++;
				}
			}
			return num;
		}

		public bool ILNKHFHKELB(int MBEDOCGMBBJ)
		{
			if (MBEDOCGMBBJ < 1 || MBEDOCGMBBJ >= DFMEJOGADLG.Count)
			{
				return false;
			}
			MCOBKFIDMOK mCOBKFIDMOK = DFMEJOGADLG[MBEDOCGMBBJ];
			if (mCOBKFIDMOK.AOANIHBOPHD())
			{
				return true;
			}
			mCOBKFIDMOK.LIJBCDKPJPP(1);
			FOHCBMKAOKE(false);
			return false;
		}

		public int ICCLKDGKBDB(ushort IKHBHNCPDLB)
		{
			int num = 1;
			foreach (MCOBKFIDMOK item in DFMEJOGADLG)
			{
				if (!item.MNHIDGANMFO() && item.IKHBHNCPDLB == IKHBHNCPDLB)
				{
					num++;
				}
			}
			return num;
		}

		public CDAEKMFPFCH()
		{
			DFMEJOGADLG = new List<MCOBKFIDMOK>();
		}

		public void JKGALIAPDFG(CMNIABEFLBJ EFDLFNPAKGO)
		{
			foreach (MCOBKFIDMOK item in DFMEJOGADLG)
			{
				EFDLFNPAKGO.JIAAPEKLFEA(item);
			}
		}

		public void LDNEFFHJNPL(bool BKNHNCPBGAD = false)
		{
			for (int i = 0; i < DFMEJOGADLG.Count; i++)
			{
				DFMEJOGADLG[i].LDNEFFHJNPL();
			}
			FOHCBMKAOKE(false);
		}

		public void LIFOGHICCCI()
		{
			OGELLNHOJGI(true);
		}

		public bool NMJIGDOJCIP()
		{
			return BFLOEPAINHO;
		}

		public void BAPDIDECBKF()
		{
			for (int i = 0; i <= 58; i++)
			{
				CLJOMPBCNOE.ACPICCBBPHF fBAGNJILEGD = ((i % 42 != 0) ? ((CLJOMPBCNOE.ACPICCBBPHF)((i - 0) % -58 % 3)) : ((CLJOMPBCNOE.ACPICCBBPHF)7));
				MCOBKFIDMOK item = new MCOBKFIDMOK(fBAGNJILEGD, (byte)i);
				DFMEJOGADLG.Add(item);
			}
			BGOGLMBCLFA(false);
		}
	}
}
