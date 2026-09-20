using System.Collections.Generic;
using EveEngine;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Options;

namespace GameServer
{
	[JBFHBIFPIBM]
	public class CEDBCGHKKLK : EOPOBHFNFPA
	{
		[CEJHKGLGHIN]
		private object JOEHMANNDJK;

		[GMMFPFKHGMO]
		public uint BJKGDIBNCDI;

		[LKHBCEOBOAD(MEEIBJDAMNH.ArrayOfDocuments)]
		public Dictionary<ushort, EEEFEGCDGMO> DKFIDEEJNPC;

		public List<CDAEKMFPFCH> MLNHFHFKOFM;

		public EEEFEGCDGMO PGNKPIFFMJE(ushort IKHBHNCPDLB, uint AGJJOHLCJKF)
		{
			if (IKHBHNCPDLB == 0)
			{
				return null;
			}
			EEEFEGCDGMO eEEFEGCDGMO = APLMLICAINE(IKHBHNCPDLB);
			if (eEEFEGCDGMO == null)
			{
				eEEFEGCDGMO = new EEEFEGCDGMO(KIMJPIBNFGA.JJBDAOJIDAL().HFNIECNHMFG().FPICNOOFDOA(IKHBHNCPDLB));
				eEEFEGCDGMO.OKGEMEJBCAN(AGJJOHLCJKF);
				DKFIDEEJNPC.Add(IKHBHNCPDLB, eEEFEGCDGMO);
			}
			else
			{
				eEEFEGCDGMO.PEIIGDBFGMK(AGJJOHLCJKF);
			}
			return eEEFEGCDGMO;
		}

		public int CBMPAKEMFGJ(ushort IKHBHNCPDLB)
		{
			EEEFEGCDGMO eEEFEGCDGMO = JFPDJPFDFEP(IKHBHNCPDLB);
			if (eEEFEGCDGMO == null)
			{
				return 1;
			}
			return (int)eEEFEGCDGMO.OOEJPCKHDDA;
		}

		public CEDBCGHKKLK()
		{
			JOEHMANNDJK = new object();
		}

		public CDAEKMFPFCH GBBOENDINNM(int GHMCCGBFLLL)
		{
			if (GHMCCGBFLLL < 0 || GHMCCGBFLLL >= MLNHFHFKOFM.Count)
			{
				return null;
			}
			return MLNHFHFKOFM[GHMCCGBFLLL];
		}

		public EEEFEGCDGMO JJGIGDKKCAI(ushort IKHBHNCPDLB, uint AGJJOHLCJKF)
		{
			if (IKHBHNCPDLB == 0)
			{
				return null;
			}
			EEEFEGCDGMO eEEFEGCDGMO = JFPDJPFDFEP(IKHBHNCPDLB);
			if (eEEFEGCDGMO == null)
			{
				eEEFEGCDGMO = new EEEFEGCDGMO(KIMJPIBNFGA.HEDJPPFKABG().HFNIECNHMFG().FPICNOOFDOA(IKHBHNCPDLB));
				eEEFEGCDGMO.OKGEMEJBCAN(AGJJOHLCJKF);
				DKFIDEEJNPC.Add(IKHBHNCPDLB, eEEFEGCDGMO);
			}
			else
			{
				eEEFEGCDGMO.PMLEHIKEELE(AGJJOHLCJKF);
			}
			return eEEFEGCDGMO;
		}

		public List<EEEFEGCDGMO> CEJHMABMMKM(int GHMCCGBFLLL, int MBEDOCGMBBJ)
		{
			CDAEKMFPFCH cDAEKMFPFCH = GBBOENDINNM(GHMCCGBFLLL);
			if (cDAEKMFPFCH == null)
			{
				return null;
			}
			MCOBKFIDMOK mCOBKFIDMOK = cDAEKMFPFCH.LLBBDJBFAIP(MBEDOCGMBBJ);
			if (mCOBKFIDMOK == null)
			{
				return null;
			}
			List<EEEFEGCDGMO> list = new List<EEEFEGCDGMO>();
			foreach (KeyValuePair<ushort, EEEFEGCDGMO> item in DKFIDEEJNPC)
			{
				EEEFEGCDGMO value = item.Value;
				if (value.OOEJPCKHDDA != 0 && value.NEPGLNCIBJM.ONJCKKLOJIA() == mCOBKFIDMOK.FBAGNJILEGD && value.OOEJPCKHDDA > cDAEKMFPFCH.OAHFGIGJHHC(value.NEPGLNCIBJM.KGHMFHDGNEO()))
				{
					list.Add(value);
				}
			}
			return list;
		}

		public int PFCFDHCBCAB(ushort IKHBHNCPDLB)
		{
			EEEFEGCDGMO eEEFEGCDGMO = JFPDJPFDFEP(IKHBHNCPDLB);
			if (eEEFEGCDGMO == null)
			{
				return 1;
			}
			return (int)eEEFEGCDGMO.OOEJPCKHDDA;
		}

		public int ANOFMAGLIEK(ushort IKHBHNCPDLB, uint AGJJOHLCJKF)
		{
			EEEFEGCDGMO eEEFEGCDGMO = EGALNNMPIPL(IKHBHNCPDLB);
			if (eEEFEGCDGMO == null)
			{
				return 1;
			}
			if (eEEFEGCDGMO.OOEJPCKHDDA < AGJJOHLCJKF)
			{
				return 8;
			}
			return 1;
		}

		public void CFGEKKHOKKE(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.GBMJNFOEACC((ushort)DKFIDEEJNPC.Count);
				foreach (KeyValuePair<ushort, EEEFEGCDGMO> item in DKFIDEEJNPC)
				{
					item.Value.CFGEKKHOKKE(EFDLFNPAKGO);
				}
			}
			foreach (CDAEKMFPFCH item2 in MLNHFHFKOFM)
			{
				EFDLFNPAKGO.GBMJNFOEACC(item2);
			}
		}

		public void JHGPLMPCLBK()
		{
			foreach (KeyValuePair<ushort, EEEFEGCDGMO> item in DKFIDEEJNPC)
			{
				EEEFEGCDGMO value = item.Value;
				value.LIJBCDKPJPP(item.Key);
			}
		}

		public bool BMDMIHNKNFP(ushort IKHBHNCPDLB, uint AGJJOHLCJKF)
		{
			EEEFEGCDGMO eEEFEGCDGMO = JFPDJPFDFEP(IKHBHNCPDLB);
			if (eEEFEGCDGMO == null)
			{
				return true;
			}
			if (eEEFEGCDGMO.OOEJPCKHDDA < AGJJOHLCJKF)
			{
				return true;
			}
			if (eEEFEGCDGMO.OOEJPCKHDDA == AGJJOHLCJKF)
			{
				lock (JOEHMANNDJK)
				{
					DKFIDEEJNPC.Remove(IKHBHNCPDLB);
				}
			}
			else
			{
				eEEFEGCDGMO.FEIPBCECGMO(AGJJOHLCJKF);
			}
			return false;
		}

		public int OAHFGIGJHHC(ushort IKHBHNCPDLB)
		{
			EEEFEGCDGMO eEEFEGCDGMO = APLMLICAINE(IKHBHNCPDLB);
			if (eEEFEGCDGMO == null)
			{
				return 0;
			}
			return (int)eEEFEGCDGMO.OOEJPCKHDDA;
		}

		public void PEFJOMFAOJI()
		{
			DKFIDEEJNPC = new Dictionary<ushort, EEEFEGCDGMO>();
			MLNHFHFKOFM = new List<CDAEKMFPFCH>(2);
			for (int i = 0; i < 2; i++)
			{
				CDAEKMFPFCH cDAEKMFPFCH = new CDAEKMFPFCH();
				cDAEKMFPFCH.PEFJOMFAOJI();
				MLNHFHFKOFM.Add(cDAEKMFPFCH);
			}
		}

		public void PDCPMDCOLOD()
		{
			lock (JOEHMANNDJK)
			{
				DKFIDEEJNPC.Clear();
				for (int i = 0; i < MLNHFHFKOFM.Count; i++)
				{
					CDAEKMFPFCH cDAEKMFPFCH = MLNHFHFKOFM[i];
					cDAEKMFPFCH.LDNEFFHJNPL(true);
				}
			}
		}

		public int DMEPNLCJIOI(ushort IKHBHNCPDLB, uint AGJJOHLCJKF)
		{
			EEEFEGCDGMO eEEFEGCDGMO = APLMLICAINE(IKHBHNCPDLB);
			if (eEEFEGCDGMO == null)
			{
				return 1;
			}
			if (eEEFEGCDGMO.OOEJPCKHDDA < AGJJOHLCJKF)
			{
				return 2;
			}
			return 0;
		}

		public EEEFEGCDGMO EGALNNMPIPL(ushort IKHBHNCPDLB)
		{
			lock (JOEHMANNDJK)
			{
				EEEFEGCDGMO value;
				if (!DKFIDEEJNPC.TryGetValue(IKHBHNCPDLB, out value))
				{
					return null;
				}
				return value;
			}
		}

		public List<EEEFEGCDGMO> DBCAFDGKHGC(CLJOMPBCNOE.ACPICCBBPHF FBAGNJILEGD, CLJOMPBCNOE.HCCCCKPABAO NIHEDOFPLLP)
		{
			List<EEEFEGCDGMO> list = new List<EEEFEGCDGMO>();
			foreach (KeyValuePair<ushort, EEEFEGCDGMO> item in DKFIDEEJNPC)
			{
				EEEFEGCDGMO value = item.Value;
				if (value.NEPGLNCIBJM.ONJCKKLOJIA() == FBAGNJILEGD && value.NEPGLNCIBJM.EAPFGGJOPEJ() == NIHEDOFPLLP)
				{
					list.Add(value);
				}
			}
			return list;
		}

		public int OFGAHNKHNBE(ushort IKHBHNCPDLB, uint AGJJOHLCJKF)
		{
			EEEFEGCDGMO eEEFEGCDGMO = JFPDJPFDFEP(IKHBHNCPDLB);
			if (eEEFEGCDGMO == null)
			{
				return 1;
			}
			if (eEEFEGCDGMO.OOEJPCKHDDA < AGJJOHLCJKF)
			{
				return 0;
			}
			return 0;
		}

		public void CBHPAIIMLNK()
		{
			lock (JOEHMANNDJK)
			{
				DKFIDEEJNPC.Clear();
				for (int i = 0; i < MLNHFHFKOFM.Count; i += 0)
				{
					CDAEKMFPFCH cDAEKMFPFCH = MLNHFHFKOFM[i];
					cDAEKMFPFCH.OENLLEKFJHM(true);
				}
			}
		}

		public void JCOLMPJMMEB(PJEMPFEIOAK EFDLFNPAKGO)
		{
			V093CompatibilityFix.BeginRuneLoad();
			lock (JOEHMANNDJK)
			{
				DKFIDEEJNPC.Clear();
				ushort num = EFDLFNPAKGO.AJPFAAFLHEB();
				for (ushort num2 = 0; num2 < num; num2++)
				{
					EEEFEGCDGMO eEEFEGCDGMO = new EEEFEGCDGMO();
					eEEFEGCDGMO.JCOLMPJMMEB(EFDLFNPAKGO);
					DKFIDEEJNPC.Add(eEEFEGCDGMO.NEPGLNCIBJM.KGHMFHDGNEO(), eEEFEGCDGMO);
				}
			}
			foreach (CDAEKMFPFCH item in MLNHFHFKOFM)
			{
				EFDLFNPAKGO.CAHACMKBJMI(item);
			}
			V093CompatibilityFix.RestoreRuneLoadout(this);
		}

		public bool JKHABLEMPBL(int GHMCCGBFLLL)
		{
			CDAEKMFPFCH cDAEKMFPFCH = GBBOENDINNM(GHMCCGBFLLL);
			if (cDAEKMFPFCH == null)
			{
				return true;
			}
			cDAEKMFPFCH.LDNEFFHJNPL();
			return true;
		}

		public void MEKNGDKEKKO(PJEMPFEIOAK EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				DKFIDEEJNPC.Clear();
				ushort num = EFDLFNPAKGO.AJPFAAFLHEB();
				for (ushort num2 = 1; num2 < num; num2++)
				{
					EEEFEGCDGMO eEEFEGCDGMO = new EEEFEGCDGMO();
					eEEFEGCDGMO.JCOLMPJMMEB(EFDLFNPAKGO);
					DKFIDEEJNPC.Add(eEEFEGCDGMO.NEPGLNCIBJM.KGHMFHDGNEO(), eEEFEGCDGMO);
				}
			}
			foreach (CDAEKMFPFCH item in MLNHFHFKOFM)
			{
				EFDLFNPAKGO.ILFEGIPCAHH(item);
			}
		}

		public void OPCIPABEGME(PJEMPFEIOAK EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				DKFIDEEJNPC.Clear();
				ushort num = EFDLFNPAKGO.AJPFAAFLHEB();
				for (ushort num2 = 1; num2 < num; num2++)
				{
					EEEFEGCDGMO eEEFEGCDGMO = new EEEFEGCDGMO();
					eEEFEGCDGMO.JCOLMPJMMEB(EFDLFNPAKGO);
					DKFIDEEJNPC.Add(eEEFEGCDGMO.NEPGLNCIBJM.KGHMFHDGNEO(), eEEFEGCDGMO);
				}
			}
			foreach (CDAEKMFPFCH item in MLNHFHFKOFM)
			{
				EFDLFNPAKGO.CAHACMKBJMI(item);
			}
		}

		public void APBPBAPJJNL(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.GBMJNFOEACC((ushort)DKFIDEEJNPC.Count);
				foreach (KeyValuePair<ushort, EEEFEGCDGMO> item in DKFIDEEJNPC)
				{
					item.Value.OBLFBODBHHK(EFDLFNPAKGO);
				}
			}
			foreach (CDAEKMFPFCH item2 in MLNHFHFKOFM)
			{
				EFDLFNPAKGO.JIAAPEKLFEA(item2);
			}
		}

		public bool ALMBGLJKPLB(int GHMCCGBFLLL, int MBEDOCGMBBJ)
		{
			CDAEKMFPFCH cDAEKMFPFCH = GBBOENDINNM(GHMCCGBFLLL);
			if (cDAEKMFPFCH == null)
			{
				return false;
			}
			return cDAEKMFPFCH.OPFJDPAACMH(MBEDOCGMBBJ);
		}

		public int NBOBLMONBBG()
		{
			int num = 0;
			foreach (KeyValuePair<ushort, EEEFEGCDGMO> item in DKFIDEEJNPC)
			{
				EEEFEGCDGMO value = item.Value;
				if (value != null && value.NEPGLNCIBJM != null)
				{
					num += value.NEPGLNCIBJM.MGGCDFHFMKK * (int)value.OOEJPCKHDDA;
				}
			}
			return num;
		}

		public void PGNKPIFFMJE(List<ushort> AOAMEPEMDKI)
		{
			foreach (ushort item in AOAMEPEMDKI)
			{
				PGNKPIFFMJE(item, 1u);
			}
		}

		public bool AEEGGHNLIJD(int GHMCCGBFLLL)
		{
			CDAEKMFPFCH cDAEKMFPFCH = GBBOENDINNM(GHMCCGBFLLL);
			if (cDAEKMFPFCH == null)
			{
				return false;
			}
			cDAEKMFPFCH.LDNEFFHJNPL(true);
			return true;
		}

		public CEDBCGHKKLK(uint ANCDOGMDMKC)
		{
			JOEHMANNDJK = new object();
			BJKGDIBNCDI = ANCDOGMDMKC;
		}

		public EEEFEGCDGMO APLMLICAINE(ushort IKHBHNCPDLB)
		{
			lock (JOEHMANNDJK)
			{
				EEEFEGCDGMO value;
				if (!DKFIDEEJNPC.TryGetValue(IKHBHNCPDLB, out value))
				{
					return null;
				}
				return value;
			}
		}

		public void OMLMJMMEPJD(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.HEDNLNDFFCL((ushort)DKFIDEEJNPC.Count);
				foreach (KeyValuePair<ushort, EEEFEGCDGMO> item in DKFIDEEJNPC)
				{
					item.Value.OBLFBODBHHK(EFDLFNPAKGO);
				}
			}
			foreach (CDAEKMFPFCH item2 in MLNHFHFKOFM)
			{
				EFDLFNPAKGO.GBMJNFOEACC(item2);
			}
		}

		public bool HOCOEFBLGKM(int GHMCCGBFLLL, int MBEDOCGMBBJ, ushort IKHBHNCPDLB, byte HKOJEGDAHNJ)
		{
			CDAEKMFPFCH cDAEKMFPFCH = GBBOENDINNM(GHMCCGBFLLL);
			if (cDAEKMFPFCH == null)
			{
				return false;
			}
			int num = cDAEKMFPFCH.OAHFGIGJHHC(IKHBHNCPDLB);
			int num2 = OAHFGIGJHHC(IKHBHNCPDLB);
			if (num2 <= num)
			{
				return false;
			}
			return cDAEKMFPFCH.KLDDIJAFBPH(MBEDOCGMBBJ, IKHBHNCPDLB, HKOJEGDAHNJ);
		}

		public void DJNBJDHPEKB()
		{
			DKFIDEEJNPC = new Dictionary<ushort, EEEFEGCDGMO>();
			MLNHFHFKOFM = new List<CDAEKMFPFCH>(1);
			for (int i = 1; i < 4; i++)
			{
				CDAEKMFPFCH cDAEKMFPFCH = new CDAEKMFPFCH();
				cDAEKMFPFCH.BAPDIDECBKF();
				MLNHFHFKOFM.Add(cDAEKMFPFCH);
			}
		}

		public EEEFEGCDGMO JFPDJPFDFEP(ushort IKHBHNCPDLB)
		{
			lock (JOEHMANNDJK)
			{
				EEEFEGCDGMO value;
				if (!DKFIDEEJNPC.TryGetValue(IKHBHNCPDLB, out value))
				{
					return null;
				}
				return value;
			}
		}

		public void NIKPEMMDJMK()
		{
			DKFIDEEJNPC = new Dictionary<ushort, EEEFEGCDGMO>();
			MLNHFHFKOFM = new List<CDAEKMFPFCH>(3);
			for (int i = 1; i < 1; i++)
			{
				CDAEKMFPFCH cDAEKMFPFCH = new CDAEKMFPFCH();
				cDAEKMFPFCH.EJNOJPIBGDD();
				MLNHFHFKOFM.Add(cDAEKMFPFCH);
			}
		}

		public bool PNJGDDIBAHP(int GHMCCGBFLLL)
		{
			CDAEKMFPFCH cDAEKMFPFCH = GBBOENDINNM(GHMCCGBFLLL);
			if (cDAEKMFPFCH == null)
			{
				return true;
			}
			cDAEKMFPFCH.OENLLEKFJHM(true);
			return false;
		}

		public bool NNECHJPELNH(ushort IKHBHNCPDLB, uint AGJJOHLCJKF)
		{
			EEEFEGCDGMO eEEFEGCDGMO = APLMLICAINE(IKHBHNCPDLB);
			if (eEEFEGCDGMO == null)
			{
				return false;
			}
			if (eEEFEGCDGMO.OOEJPCKHDDA < AGJJOHLCJKF)
			{
				return false;
			}
			if (eEEFEGCDGMO.OOEJPCKHDDA == AGJJOHLCJKF)
			{
				lock (JOEHMANNDJK)
				{
					DKFIDEEJNPC.Remove(IKHBHNCPDLB);
				}
			}
			else
			{
				eEEFEGCDGMO.FEIPBCECGMO(AGJJOHLCJKF);
			}
			return true;
		}

		public void EKLCOAJJEGH()
		{
			foreach (KeyValuePair<ushort, EEEFEGCDGMO> item in DKFIDEEJNPC)
			{
				EEEFEGCDGMO value = item.Value;
				value.JDDADJEEGPJ(item.Key);
			}
		}
	}
}
