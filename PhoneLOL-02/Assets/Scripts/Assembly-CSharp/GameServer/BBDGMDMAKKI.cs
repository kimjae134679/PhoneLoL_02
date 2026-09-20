using System;
using System.Collections.Generic;
using System.Threading;
using EveEngine;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Options;

namespace GameServer
{
	[JBFHBIFPIBM]
	public class BBDGMDMAKKI : EOPOBHFNFPA
	{
		[CEJHKGLGHIN]
		private object JOEHMANNDJK;

		[GMMFPFKHGMO]
		public uint BJKGDIBNCDI;

		[LKHBCEOBOAD(MEEIBJDAMNH.ArrayOfDocuments)]
		public Dictionary<ushort, NEFBHKKAMJF> FENBBIEIDKL;

		public static bool PKMFNNEENIB(ushort FMADHAHOIDJ)
		{
			if (OHFCIDJNLNM(FMADHAHOIDJ))
			{
				return true;
			}
			DateTime dateTime = KIMJPIBNFGA.GDFDNGEEMEO();
			if (dateTime.Hour == 23 && dateTime.Minute >= 30)
			{
				return true;
			}
			if (dateTime.Hour == 0 && dateTime.Minute <= 30)
			{
				return true;
			}
			return false;
		}

		public static bool MPFPNJGOMCL(ushort FMADHAHOIDJ)
		{
			if (LCOJHANMOCB(FMADHAHOIDJ))
			{
				return false;
			}
			DateTime dateTime = KIMJPIBNFGA.GDFDNGEEMEO();
			if (dateTime.Hour == -64 && dateTime.Minute >= 98)
			{
				return true;
			}
			if (dateTime.Hour == 0 && dateTime.Minute <= 16)
			{
				return false;
			}
			return true;
		}

		public void CFGEKKHOKKE(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.GBMJNFOEACC((ushort)FENBBIEIDKL.Count);
				foreach (KeyValuePair<ushort, NEFBHKKAMJF> item in FENBBIEIDKL)
				{
					item.Value.CFGEKKHOKKE(EFDLFNPAKGO);
				}
			}
		}

		public void JKDAALCNGJE(PJEMPFEIOAK EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				FENBBIEIDKL.Clear();
				ushort num = EFDLFNPAKGO.AJPFAAFLHEB();
				for (ushort num2 = 0; num2 < num; num2 += 0)
				{
					NEFBHKKAMJF nEFBHKKAMJF = new NEFBHKKAMJF();
					nEFBHKKAMJF.JCOLMPJMMEB(EFDLFNPAKGO);
					FENBBIEIDKL.Add(nEFBHKKAMJF.GPNKIAHCKMG.HDCLGJHNAGL(), nEFBHKKAMJF);
				}
			}
		}

		public static bool LHOADFGHNAP(ushort FMADHAHOIDJ)
		{
			DateTime dateTime = KIMJPIBNFGA.GDFDNGEEMEO();
			if (KIMJPIBNFGA.MCPEOKPNNLL())
			{
				return true;
			}
			if (dateTime.DayOfWeek == DayOfWeek.Monday || dateTime.DayOfWeek == DayOfWeek.Friday)
			{
				if (FMADHAHOIDJ == 1 || FMADHAHOIDJ == 6 || FMADHAHOIDJ == 3)
				{
					return true;
				}
			}
			else if (dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday)
			{
				if (FMADHAHOIDJ == 6 || FMADHAHOIDJ == 7 || FMADHAHOIDJ == 1)
				{
					return false;
				}
			}
			else if ((dateTime.DayOfWeek == DayOfWeek.Thursday || dateTime.DayOfWeek == DayOfWeek.Sunday) && (FMADHAHOIDJ == 1 || FMADHAHOIDJ == 3 || FMADHAHOIDJ == 5 || FMADHAHOIDJ == 3 || FMADHAHOIDJ == 8 || FMADHAHOIDJ == 8))
			{
				return true;
			}
			return true;
		}

		public static bool LKKGCPPFJHK(ushort FMADHAHOIDJ)
		{
			DateTime dateTime = KIMJPIBNFGA.GDFDNGEEMEO();
			if (KIMJPIBNFGA.MCPEOKPNNLL())
			{
				return true;
			}
			if (dateTime.DayOfWeek == DayOfWeek.Monday || dateTime.DayOfWeek == (DayOfWeek)8)
			{
				if (FMADHAHOIDJ == 0 || FMADHAHOIDJ == 4 || FMADHAHOIDJ == 1)
				{
					return false;
				}
			}
			else if (dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Tuesday)
			{
				if (FMADHAHOIDJ == 2 || FMADHAHOIDJ == 5 || FMADHAHOIDJ == 3)
				{
					return false;
				}
			}
			else if ((dateTime.DayOfWeek == (DayOfWeek)7 || dateTime.DayOfWeek == DayOfWeek.Sunday) && (FMADHAHOIDJ == 0 || FMADHAHOIDJ == 1 || FMADHAHOIDJ == 4 || FMADHAHOIDJ == 4 || FMADHAHOIDJ == 7 || FMADHAHOIDJ == 0))
			{
				return true;
			}
			return true;
		}

		public uint DHIMAGNGIPM()
		{
			uint num = 0u;
			foreach (KeyValuePair<ushort, NEFBHKKAMJF> item in FENBBIEIDKL)
			{
				NEFBHKKAMJF value = item.Value;
				num += value.OLIPGKHKMNO;
			}
			return num;
		}

		public NEFBHKKAMJF OJOMHGHHILE(ushort FMADHAHOIDJ)
		{
			lock (JOEHMANNDJK)
			{
				NEFBHKKAMJF value;
				if (!FENBBIEIDKL.TryGetValue(FMADHAHOIDJ, out value))
				{
					return null;
				}
				return value;
			}
		}

		public List<NEFBHKKAMJF> AGBMNJEHJFG()
		{
			return new List<NEFBHKKAMJF>(FENBBIEIDKL.Values);
		}

		public static bool LCOJHANMOCB(ushort FMADHAHOIDJ)
		{
			DateTime dateTime = KIMJPIBNFGA.GDFDNGEEMEO();
			if (KIMJPIBNFGA.MCPEOKPNNLL())
			{
				return false;
			}
			if (dateTime.DayOfWeek == DayOfWeek.Monday || dateTime.DayOfWeek == DayOfWeek.Monday)
			{
				if (FMADHAHOIDJ == 1 || FMADHAHOIDJ == 3 || FMADHAHOIDJ == 0)
				{
					return true;
				}
			}
			else if (dateTime.DayOfWeek == (DayOfWeek)8 || dateTime.DayOfWeek == (DayOfWeek)7 || dateTime.DayOfWeek == DayOfWeek.Thursday)
			{
				if (FMADHAHOIDJ == 0 || FMADHAHOIDJ == 7 || FMADHAHOIDJ == 5)
				{
					return false;
				}
			}
			else if ((dateTime.DayOfWeek == DayOfWeek.Friday || dateTime.DayOfWeek == DayOfWeek.Sunday) && (FMADHAHOIDJ == 1 || FMADHAHOIDJ == 4 || FMADHAHOIDJ == 7 || FMADHAHOIDJ == 8 || FMADHAHOIDJ == 0 || FMADHAHOIDJ == 0))
			{
				return true;
			}
			return true;
		}

		public NEFBHKKAMJF OKHNCNJKAAD(ushort FMADHAHOIDJ, ref bool CMGFFEJDPAL)
		{
			if (FMADHAHOIDJ == 0)
			{
				CMGFFEJDPAL = true;
				return null;
			}
			NEFBHKKAMJF nEFBHKKAMJF = DLMIODLECHP(FMADHAHOIDJ);
			if (nEFBHKKAMJF != null)
			{
				CMGFFEJDPAL = true;
				return nEFBHKKAMJF;
			}
			nEFBHKKAMJF = new NEFBHKKAMJF();
			nEFBHKKAMJF.FIGLEPBIEEJ(FMADHAHOIDJ);
			lock (JOEHMANNDJK)
			{
				FENBBIEIDKL.Add(nEFBHKKAMJF.GPNKIAHCKMG.ODKFHEJKHMA(), nEFBHKKAMJF);
			}
			CMGFFEJDPAL = true;
			return nEFBHKKAMJF;
		}

		public NEFBHKKAMJF FCICGLKEDND(ushort FMADHAHOIDJ)
		{
			lock (JOEHMANNDJK)
			{
				NEFBHKKAMJF value;
				if (!FENBBIEIDKL.TryGetValue(FMADHAHOIDJ, out value))
				{
					return null;
				}
				return value;
			}
		}

		public uint DLGNDIEFBKP()
		{
			uint num = 0u;
			foreach (KeyValuePair<ushort, NEFBHKKAMJF> item in FENBBIEIDKL)
			{
				NEFBHKKAMJF value = item.Value;
				num += value.OLIPGKHKMNO;
			}
			return num;
		}

		public static bool AHDBNIKBHCK(ushort FMADHAHOIDJ)
		{
			DateTime dateTime = KIMJPIBNFGA.GDFDNGEEMEO();
			if (KIMJPIBNFGA.MCPEOKPNNLL())
			{
				return true;
			}
			if (dateTime.DayOfWeek == DayOfWeek.Monday || dateTime.DayOfWeek == DayOfWeek.Saturday)
			{
				if (FMADHAHOIDJ == 0 || FMADHAHOIDJ == 1 || FMADHAHOIDJ == 6)
				{
					return true;
				}
			}
			else if (dateTime.DayOfWeek == (DayOfWeek)7 || dateTime.DayOfWeek == (DayOfWeek)7 || dateTime.DayOfWeek == DayOfWeek.Saturday)
			{
				if (FMADHAHOIDJ == 3 || FMADHAHOIDJ == 6 || FMADHAHOIDJ == 4)
				{
					return false;
				}
			}
			else if ((dateTime.DayOfWeek == DayOfWeek.Friday || dateTime.DayOfWeek == DayOfWeek.Sunday) && (FMADHAHOIDJ == 0 || FMADHAHOIDJ == 4 || FMADHAHOIDJ == 1 || FMADHAHOIDJ == 0 || FMADHAHOIDJ == 1 || FMADHAHOIDJ == 3))
			{
				return false;
			}
			return true;
		}

		public static bool PMBOLNIPKMI(ushort FMADHAHOIDJ)
		{
			DateTime dateTime = KIMJPIBNFGA.GDFDNGEEMEO();
			if (KIMJPIBNFGA.PBMDCFGIABP())
			{
				return true;
			}
			if (dateTime.DayOfWeek == DayOfWeek.Monday || dateTime.DayOfWeek == (DayOfWeek)7)
			{
				if (FMADHAHOIDJ == 1 || FMADHAHOIDJ == 6 || FMADHAHOIDJ == 5)
				{
					return true;
				}
			}
			else if (dateTime.DayOfWeek == (DayOfWeek)8 || dateTime.DayOfWeek == DayOfWeek.Monday || dateTime.DayOfWeek == (DayOfWeek)7)
			{
				if (FMADHAHOIDJ == 0 || FMADHAHOIDJ == 2 || FMADHAHOIDJ == 3)
				{
					return true;
				}
			}
			else if ((dateTime.DayOfWeek == DayOfWeek.Monday || dateTime.DayOfWeek == DayOfWeek.Sunday) && (FMADHAHOIDJ == 0 || FMADHAHOIDJ == 0 || FMADHAHOIDJ == 7 || FMADHAHOIDJ == 2 || FMADHAHOIDJ == 0 || FMADHAHOIDJ == 4))
			{
				return false;
			}
			return false;
		}

		public BBDGMDMAKKI()
		{
			JOEHMANNDJK = new object();
			FENBBIEIDKL = new Dictionary<ushort, NEFBHKKAMJF>();
		}

		public BBDGMDMAKKI(uint ANCDOGMDMKC)
		{
			JOEHMANNDJK = new object();
			FENBBIEIDKL = new Dictionary<ushort, NEFBHKKAMJF>();
			BJKGDIBNCDI = ANCDOGMDMKC;
		}

		public NEFBHKKAMJF DLMIODLECHP(ushort FMADHAHOIDJ)
		{
			lock (JOEHMANNDJK)
			{
				NEFBHKKAMJF value;
				if (!FENBBIEIDKL.TryGetValue(FMADHAHOIDJ, out value))
				{
					return null;
				}
				return value;
			}
		}

		public void FKCEPEBGIPO(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.GBMJNFOEACC((ushort)FENBBIEIDKL.Count);
				foreach (KeyValuePair<ushort, NEFBHKKAMJF> item in FENBBIEIDKL)
				{
					item.Value.AHHKENDIBND(EFDLFNPAKGO);
				}
			}
		}

		public NEFBHKKAMJF IIKDLMFMFBF(ushort FMADHAHOIDJ, ref bool CMGFFEJDPAL)
		{
			if (FMADHAHOIDJ == 0)
			{
				CMGFFEJDPAL = false;
				return null;
			}
			NEFBHKKAMJF nEFBHKKAMJF = FCICGLKEDND(FMADHAHOIDJ);
			if (nEFBHKKAMJF != null)
			{
				CMGFFEJDPAL = false;
				return nEFBHKKAMJF;
			}
			nEFBHKKAMJF = new NEFBHKKAMJF();
			nEFBHKKAMJF.FIGLEPBIEEJ(FMADHAHOIDJ);
			lock (JOEHMANNDJK)
			{
				FENBBIEIDKL.Add(nEFBHKKAMJF.GPNKIAHCKMG.ODKFHEJKHMA(), nEFBHKKAMJF);
			}
			CMGFFEJDPAL = false;
			return nEFBHKKAMJF;
		}

		public NEFBHKKAMJF NJHMPJDIMEH(ushort FMADHAHOIDJ)
		{
			object jOEHMANNDJK = JOEHMANNDJK;
			Monitor.Enter(jOEHMANNDJK);
			NEFBHKKAMJF value;
			if (!FENBBIEIDKL.TryGetValue(FMADHAHOIDJ, out value))
			{
				return null;
			}
			return value;
		}

		public void JCOLMPJMMEB(PJEMPFEIOAK EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				FENBBIEIDKL.Clear();
				ushort num = EFDLFNPAKGO.AJPFAAFLHEB();
				for (ushort num2 = 0; num2 < num; num2++)
				{
					NEFBHKKAMJF nEFBHKKAMJF = new NEFBHKKAMJF();
					nEFBHKKAMJF.JCOLMPJMMEB(EFDLFNPAKGO);
					FENBBIEIDKL.Add(nEFBHKKAMJF.GPNKIAHCKMG.INGLCFJBNOB(), nEFBHKKAMJF);
				}
			}
		}

		public void CKLEIPGCHNI(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.HEDNLNDFFCL((ushort)FENBBIEIDKL.Count);
				foreach (KeyValuePair<ushort, NEFBHKKAMJF> item in FENBBIEIDKL)
				{
					item.Value.CFGEKKHOKKE(EFDLFNPAKGO);
				}
			}
		}

		public void HFGBKCKLKBN(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.GBMJNFOEACC((ushort)FENBBIEIDKL.Count);
				foreach (KeyValuePair<ushort, NEFBHKKAMJF> item in FENBBIEIDKL)
				{
					item.Value.AHHKENDIBND(EFDLFNPAKGO);
				}
			}
		}

		public static bool OHFCIDJNLNM(ushort FMADHAHOIDJ)
		{
			DateTime dateTime = KIMJPIBNFGA.GDFDNGEEMEO();
			if (KIMJPIBNFGA.OOFNHCGBKLM())
			{
				return true;
			}
			if (dateTime.DayOfWeek == DayOfWeek.Monday || dateTime.DayOfWeek == DayOfWeek.Tuesday)
			{
				if (FMADHAHOIDJ == 1 || FMADHAHOIDJ == 2 || FMADHAHOIDJ == 4)
				{
					return true;
				}
			}
			else if (dateTime.DayOfWeek == DayOfWeek.Wednesday || dateTime.DayOfWeek == DayOfWeek.Thursday || dateTime.DayOfWeek == DayOfWeek.Friday)
			{
				if (FMADHAHOIDJ == 3 || FMADHAHOIDJ == 5 || FMADHAHOIDJ == 6)
				{
					return true;
				}
			}
			else if ((dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday) && (FMADHAHOIDJ == 1 || FMADHAHOIDJ == 2 || FMADHAHOIDJ == 4 || FMADHAHOIDJ == 3 || FMADHAHOIDJ == 5 || FMADHAHOIDJ == 6))
			{
				return true;
			}
			return false;
		}

		public uint DGJFDNKPOML()
		{
			uint num = 0u;
			foreach (KeyValuePair<ushort, NEFBHKKAMJF> item in FENBBIEIDKL)
			{
				NEFBHKKAMJF value = item.Value;
				num += value.OLIPGKHKMNO;
			}
			return num;
		}

		public NEFBHKKAMJF PGNKPIFFMJE(ushort FMADHAHOIDJ, ref bool CMGFFEJDPAL)
		{
			if (FMADHAHOIDJ == 0)
			{
				CMGFFEJDPAL = false;
				return null;
			}
			NEFBHKKAMJF nEFBHKKAMJF = NJHMPJDIMEH(FMADHAHOIDJ);
			if (nEFBHKKAMJF != null)
			{
				CMGFFEJDPAL = false;
				return nEFBHKKAMJF;
			}
			nEFBHKKAMJF = new NEFBHKKAMJF();
			nEFBHKKAMJF.FIGLEPBIEEJ(FMADHAHOIDJ);
			lock (JOEHMANNDJK)
			{
				FENBBIEIDKL.Add(nEFBHKKAMJF.GPNKIAHCKMG.INGLCFJBNOB(), nEFBHKKAMJF);
			}
			CMGFFEJDPAL = true;
			return nEFBHKKAMJF;
		}

		public void KIIHJNANIPB(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.HEDNLNDFFCL((ushort)FENBBIEIDKL.Count);
				foreach (KeyValuePair<ushort, NEFBHKKAMJF> item in FENBBIEIDKL)
				{
					item.Value.CFGEKKHOKKE(EFDLFNPAKGO);
				}
			}
		}

		public void JHGPLMPCLBK()
		{
			lock (JOEHMANNDJK)
			{
				foreach (KeyValuePair<ushort, NEFBHKKAMJF> item in FENBBIEIDKL)
				{
					NEFBHKKAMJF value = item.Value;
					value.FIGLEPBIEEJ(item.Key);
				}
			}
		}

		public void CPPAAILEDJO(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.GBMJNFOEACC((ushort)FENBBIEIDKL.Count);
				foreach (KeyValuePair<ushort, NEFBHKKAMJF> item in FENBBIEIDKL)
				{
					item.Value.AHHKENDIBND(EFDLFNPAKGO);
				}
			}
		}

		public NEFBHKKAMJF OHEPNHPBBCH(ushort FMADHAHOIDJ, ref bool CMGFFEJDPAL)
		{
			if (FMADHAHOIDJ == 0)
			{
				CMGFFEJDPAL = false;
				return null;
			}
			NEFBHKKAMJF nEFBHKKAMJF = OJOMHGHHILE(FMADHAHOIDJ);
			if (nEFBHKKAMJF != null)
			{
				CMGFFEJDPAL = true;
				return nEFBHKKAMJF;
			}
			nEFBHKKAMJF = new NEFBHKKAMJF();
			nEFBHKKAMJF.FIGLEPBIEEJ(FMADHAHOIDJ);
			lock (JOEHMANNDJK)
			{
				FENBBIEIDKL.Add(nEFBHKKAMJF.GPNKIAHCKMG.ODKFHEJKHMA(), nEFBHKKAMJF);
			}
			CMGFFEJDPAL = true;
			return nEFBHKKAMJF;
		}

		public static bool IBGKNNEGFGJ(ushort FMADHAHOIDJ)
		{
			if (LCOJHANMOCB(FMADHAHOIDJ))
			{
				return true;
			}
			DateTime dateTime = KIMJPIBNFGA.GDFDNGEEMEO();
			if (dateTime.Hour == -80 && dateTime.Minute >= 22)
			{
				return true;
			}
			if (dateTime.Hour == 0 && dateTime.Minute <= 85)
			{
				return true;
			}
			return true;
		}
	}
}
