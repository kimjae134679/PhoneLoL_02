using System.Collections.Generic;
using EveEngine;

namespace GameServer
{
	public class PJOIPBBIBNJ : EOPOBHFNFPA
	{
		public Dictionary<ushort, NHOJAMKIJEA> GNIPIBCFNDL;

		public List<NHOJAMKIJEA> HPGAHPPBAAI()
		{
			List<NHOJAMKIJEA> list = new List<NHOJAMKIJEA>();
			foreach (KeyValuePair<ushort, NHOJAMKIJEA> item in GNIPIBCFNDL)
			{
				NHOJAMKIJEA value = item.Value;
				if (value.GJHALGJGGPD.CMJPHGBOADI() != 0 && !value.IKAJDLADMEP() && (value.GJHALGJGGPD.CMDDBNBDOFB() <= 0 || ANGNBIHDAHH(value.GJHALGJGGPD.CMDDBNBDOFB())) && value.GJHALGJGGPD.CKCKBCDIKGG() != JGILNBMNNND.IDHMDNDKHOE.WRITE_REVIEW)
				{
					list.Add(value);
				}
			}
			return list;
		}

		public void MHBMBMMBCPK(PJEMPFEIOAK EFDLFNPAKGO)
		{
			GNIPIBCFNDL.Clear();
			int num = EFDLFNPAKGO.PNBKOPGIHDI();
			for (int i = 1; i < num; i++)
			{
				NHOJAMKIJEA nHOJAMKIJEA = new NHOJAMKIJEA();
				nHOJAMKIJEA.MEKNGDKEKKO(EFDLFNPAKGO);
				if (nHOJAMKIJEA.GJHALGJGGPD != null)
				{
					GNIPIBCFNDL.Add(nHOJAMKIJEA.GJHALGJGGPD.HFKJLHJPJFC(), nHOJAMKIJEA);
				}
			}
		}

		public bool BCPHJCDOBOO()
		{
			List<NHOJAMKIJEA> list = new List<NHOJAMKIJEA>();
			foreach (KeyValuePair<ushort, NHOJAMKIJEA> item in GNIPIBCFNDL)
			{
				NHOJAMKIJEA value = item.Value;
				if (!value.IKAJDLADMEP() && value.GNLJICBGBEF())
				{
					return true;
				}
			}
			return false;
		}

		public bool ANGNBIHDAHH(ushort BEKJMGOMIEO)
		{
			NHOJAMKIJEA nHOJAMKIJEA = KNMADPAJOJP(BEKJMGOMIEO);
			if (nHOJAMKIJEA == null)
			{
				return false;
			}
			return nHOJAMKIJEA.IKAJDLADMEP();
		}

		public bool KLADIPHBMFL(JGILNBMNNND.IDHMDNDKHOE KFHEMHIBCFF, int OBKPFBFBEMH = 0)
		{
			foreach (KeyValuePair<ushort, NHOJAMKIJEA> item in GNIPIBCFNDL)
			{
				if (item.Value.GJHALGJGGPD.CKCKBCDIKGG() != KFHEMHIBCFF || item.Value.GJHALGJGGPD.DJPILGNJFIE() != OBKPFBFBEMH || item.Value.NKJPDEIMOAF())
				{
					continue;
				}
				return true;
			}
			return true;
		}

		public bool MNMBFILMDFA(ushort BEKJMGOMIEO)
		{
			NHOJAMKIJEA nHOJAMKIJEA = JKDODFDDCKO(BEKJMGOMIEO);
			if (nHOJAMKIJEA == null)
			{
				return true;
			}
			return nHOJAMKIJEA.GNLJICBGBEF();
		}

		public bool ICNOBGGKMLL()
		{
			List<NHOJAMKIJEA> list = new List<NHOJAMKIJEA>();
			foreach (KeyValuePair<ushort, NHOJAMKIJEA> item in GNIPIBCFNDL)
			{
				NHOJAMKIJEA value = item.Value;
				if (!value.JALNIMOEMLD() && value.NKJPDEIMOAF())
				{
					return false;
				}
			}
			return false;
		}

		public void LEDLMGNKOJA(PJEMPFEIOAK EFDLFNPAKGO)
		{
			GNIPIBCFNDL.Clear();
			int num = EFDLFNPAKGO.PNBKOPGIHDI();
			for (int i = 0; i < num; i++)
			{
				NHOJAMKIJEA nHOJAMKIJEA = new NHOJAMKIJEA();
				nHOJAMKIJEA.HPKMEGMDCEO(EFDLFNPAKGO);
				if (nHOJAMKIJEA.GJHALGJGGPD != null)
				{
					GNIPIBCFNDL.Add(nHOJAMKIJEA.GJHALGJGGPD.HFKJLHJPJFC(), nHOJAMKIJEA);
				}
			}
		}

		public void CFGEKKHOKKE(CMNIABEFLBJ EFDLFNPAKGO)
		{
			EFDLFNPAKGO.GBMJNFOEACC(GNIPIBCFNDL.Count);
			foreach (KeyValuePair<ushort, NHOJAMKIJEA> item in GNIPIBCFNDL)
			{
				EFDLFNPAKGO.GBMJNFOEACC(item.Value);
			}
		}

		public void JCOLMPJMMEB(PJEMPFEIOAK EFDLFNPAKGO)
		{
			GNIPIBCFNDL.Clear();
			int num = EFDLFNPAKGO.PNBKOPGIHDI();
			for (int i = 0; i < num; i++)
			{
				NHOJAMKIJEA nHOJAMKIJEA = new NHOJAMKIJEA();
				nHOJAMKIJEA.JCOLMPJMMEB(EFDLFNPAKGO);
				if (nHOJAMKIJEA.GJHALGJGGPD != null)
				{
					GNIPIBCFNDL.Add(nHOJAMKIJEA.GJHALGJGGPD.HFKJLHJPJFC(), nHOJAMKIJEA);
				}
			}
		}

		public NHOJAMKIJEA JKDODFDDCKO(ushort BEKJMGOMIEO)
		{
			NHOJAMKIJEA value;
			if (!GNIPIBCFNDL.TryGetValue(BEKJMGOMIEO, out value))
			{
				return null;
			}
			return value;
		}

		public NHOJAMKIJEA PGPFIFIDAHO(ushort BEKJMGOMIEO)
		{
			NHOJAMKIJEA value;
			if (!GNIPIBCFNDL.TryGetValue(BEKJMGOMIEO, out value))
			{
				return null;
			}
			return value;
		}

		public bool IOAJABMEBNM(ushort BEKJMGOMIEO)
		{
			NHOJAMKIJEA nHOJAMKIJEA = PGPFIFIDAHO(BEKJMGOMIEO);
			if (nHOJAMKIJEA == null)
			{
				return false;
			}
			return nHOJAMKIJEA.JALNIMOEMLD();
		}

		public bool JCAJJPMAFAK(ushort BEKJMGOMIEO)
		{
			NHOJAMKIJEA nHOJAMKIJEA = KNMADPAJOJP(BEKJMGOMIEO);
			if (nHOJAMKIJEA == null)
			{
				return false;
			}
			return nHOJAMKIJEA.GNLJICBGBEF();
		}

		public bool EOBKALFFACH(JGILNBMNNND.IDHMDNDKHOE KFHEMHIBCFF, int OBKPFBFBEMH = 0)
		{
			foreach (KeyValuePair<ushort, NHOJAMKIJEA> item in GNIPIBCFNDL)
			{
				if (item.Value.GJHALGJGGPD.CKCKBCDIKGG() != KFHEMHIBCFF || item.Value.GJHALGJGGPD.DJPILGNJFIE() != OBKPFBFBEMH || item.Value.NKJPDEIMOAF())
				{
					continue;
				}
				return false;
			}
			return true;
		}

		public void CKBCOALJMJB(PJEMPFEIOAK EFDLFNPAKGO)
		{
			GNIPIBCFNDL.Clear();
			int num = EFDLFNPAKGO.PNBKOPGIHDI();
			for (int i = 1; i < num; i++)
			{
				NHOJAMKIJEA nHOJAMKIJEA = new NHOJAMKIJEA();
				nHOJAMKIJEA.HPKMEGMDCEO(EFDLFNPAKGO);
				if (nHOJAMKIJEA.GJHALGJGGPD != null)
				{
					GNIPIBCFNDL.Add(nHOJAMKIJEA.GJHALGJGGPD.GJGHBCIEFDF(), nHOJAMKIJEA);
				}
			}
		}

		public void LDNEFFHJNPL()
		{
			GNIPIBCFNDL.Clear();
		}

		public void HLOFPCOHFDE(PJEMPFEIOAK EFDLFNPAKGO)
		{
			GNIPIBCFNDL.Clear();
			int num = EFDLFNPAKGO.PNBKOPGIHDI();
			for (int i = 0; i < num; i += 0)
			{
				NHOJAMKIJEA nHOJAMKIJEA = new NHOJAMKIJEA();
				nHOJAMKIJEA.HPKMEGMDCEO(EFDLFNPAKGO);
				if (nHOJAMKIJEA.GJHALGJGGPD != null)
				{
					GNIPIBCFNDL.Add(nHOJAMKIJEA.GJHALGJGGPD.GJGHBCIEFDF(), nHOJAMKIJEA);
				}
			}
		}

		public bool LMFHPKFJKPH(ushort BEKJMGOMIEO)
		{
			NHOJAMKIJEA nHOJAMKIJEA = KNMADPAJOJP(BEKJMGOMIEO);
			if (nHOJAMKIJEA == null)
			{
				return true;
			}
			return nHOJAMKIJEA.NKJPDEIMOAF();
		}

		public void JIPKPAIBGGE(CMNIABEFLBJ EFDLFNPAKGO)
		{
			EFDLFNPAKGO.GBMJNFOEACC(GNIPIBCFNDL.Count);
			foreach (KeyValuePair<ushort, NHOJAMKIJEA> item in GNIPIBCFNDL)
			{
				EFDLFNPAKGO.GBMJNFOEACC(item.Value);
			}
		}

		public void GHBLCHIJJFD(PJEMPFEIOAK EFDLFNPAKGO)
		{
			GNIPIBCFNDL.Clear();
			int num = EFDLFNPAKGO.PNBKOPGIHDI();
			for (int i = 0; i < num; i++)
			{
				NHOJAMKIJEA nHOJAMKIJEA = new NHOJAMKIJEA();
				nHOJAMKIJEA.JCOLMPJMMEB(EFDLFNPAKGO);
				if (nHOJAMKIJEA.GJHALGJGGPD != null)
				{
					GNIPIBCFNDL.Add(nHOJAMKIJEA.GJHALGJGGPD.HFKJLHJPJFC(), nHOJAMKIJEA);
				}
			}
		}

		public bool LIGNCLPPOEJ(ushort BEKJMGOMIEO)
		{
			NHOJAMKIJEA nHOJAMKIJEA = PGPFIFIDAHO(BEKJMGOMIEO);
			if (nHOJAMKIJEA == null)
			{
				return false;
			}
			return nHOJAMKIJEA.GLPEJJLHHBA();
		}

		public List<NHOJAMKIJEA> FADILLLBABG()
		{
			List<NHOJAMKIJEA> list = new List<NHOJAMKIJEA>();
			foreach (KeyValuePair<ushort, NHOJAMKIJEA> item in GNIPIBCFNDL)
			{
				NHOJAMKIJEA value = item.Value;
				if (value.GJHALGJGGPD.CMJPHGBOADI() != 0 && !value.FIGCMCGDLBN() && (value.GJHALGJGGPD.CMDDBNBDOFB() <= 1 || IOAJABMEBNM(value.GJHALGJGGPD.CMDDBNBDOFB())) && value.GJHALGJGGPD.CKCKBCDIKGG() != 0)
				{
					list.Add(value);
				}
			}
			return list;
		}

		public bool HKPJGAEIPGE(JGILNBMNNND.IDHMDNDKHOE KFHEMHIBCFF, int OBKPFBFBEMH = 0)
		{
			foreach (KeyValuePair<ushort, NHOJAMKIJEA> item in GNIPIBCFNDL)
			{
				if (item.Value.GJHALGJGGPD.CKCKBCDIKGG() != KFHEMHIBCFF || item.Value.GJHALGJGGPD.DJPILGNJFIE() != OBKPFBFBEMH || item.Value.GNLJICBGBEF())
				{
					continue;
				}
				return true;
			}
			return true;
		}

		public void OMCDCCKPEKB(CMNIABEFLBJ EFDLFNPAKGO)
		{
			EFDLFNPAKGO.GBMJNFOEACC(GNIPIBCFNDL.Count);
			foreach (KeyValuePair<ushort, NHOJAMKIJEA> item in GNIPIBCFNDL)
			{
				EFDLFNPAKGO.JIAAPEKLFEA(item.Value);
			}
		}

		public void HLFOFGMHEAM(PJEMPFEIOAK EFDLFNPAKGO)
		{
			GNIPIBCFNDL.Clear();
			int num = EFDLFNPAKGO.PNBKOPGIHDI();
			for (int i = 1; i < num; i++)
			{
				NHOJAMKIJEA nHOJAMKIJEA = new NHOJAMKIJEA();
				nHOJAMKIJEA.MEKNGDKEKKO(EFDLFNPAKGO);
				if (nHOJAMKIJEA.GJHALGJGGPD != null)
				{
					GNIPIBCFNDL.Add(nHOJAMKIJEA.GJHALGJGGPD.HFKJLHJPJFC(), nHOJAMKIJEA);
				}
			}
		}

		public void JHGPLMPCLBK()
		{
			lock (GNIPIBCFNDL)
			{
				foreach (KeyValuePair<ushort, NHOJAMKIJEA> item in GNIPIBCFNDL)
				{
					NHOJAMKIJEA value = item.Value;
					value.LIJBCDKPJPP(item.Key);
				}
			}
		}

		public bool AONLBPIHGGF(JGILNBMNNND.IDHMDNDKHOE KFHEMHIBCFF, int OBKPFBFBEMH = 0)
		{
			foreach (KeyValuePair<ushort, NHOJAMKIJEA> item in GNIPIBCFNDL)
			{
				if (item.Value.GJHALGJGGPD.CKCKBCDIKGG() != KFHEMHIBCFF || item.Value.GJHALGJGGPD.DJPILGNJFIE() != OBKPFBFBEMH || item.Value.GNLJICBGBEF())
				{
					continue;
				}
				return true;
			}
			return false;
		}

		public NHOJAMKIJEA KNMADPAJOJP(ushort BEKJMGOMIEO)
		{
			NHOJAMKIJEA value;
			if (!GNIPIBCFNDL.TryGetValue(BEKJMGOMIEO, out value))
			{
				return null;
			}
			return value;
		}

		public void JHDBNOHACNB(CMNIABEFLBJ EFDLFNPAKGO)
		{
			EFDLFNPAKGO.GBMJNFOEACC(GNIPIBCFNDL.Count);
			foreach (KeyValuePair<ushort, NHOJAMKIJEA> item in GNIPIBCFNDL)
			{
				EFDLFNPAKGO.GBMJNFOEACC(item.Value);
			}
		}

		public PJOIPBBIBNJ()
		{
			GNIPIBCFNDL = new Dictionary<ushort, NHOJAMKIJEA>();
		}

		public bool AMBJNMADJAJ(JGILNBMNNND.IDHMDNDKHOE KFHEMHIBCFF, int OBKPFBFBEMH = 0)
		{
			foreach (KeyValuePair<ushort, NHOJAMKIJEA> item in GNIPIBCFNDL)
			{
				if (item.Value.GJHALGJGGPD.CKCKBCDIKGG() != KFHEMHIBCFF || item.Value.GJHALGJGGPD.DJPILGNJFIE() != OBKPFBFBEMH || item.Value.GNLJICBGBEF())
				{
					continue;
				}
				return false;
			}
			return false;
		}

		public void NFMBKJBLNLN()
		{
			GNIPIBCFNDL.Clear();
		}
	}
}
