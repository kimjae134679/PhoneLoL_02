using System.Collections.Generic;
using System.Net;

namespace EveEngine
{
	public class FMMNGEJDCOH
	{
		private Dictionary<int, ABBLIOLAABC> BJGGCKHADHN;

		private EKACODPEIIO KLBIKHEFDHH;

		public static float JCDCNJANAPD = 1f;

		public static float APODHPLMBGL = 3f;

		public static float DLIFPJEHOIB = 15f;

		public LHOLJMEKHBF CDFEIEEJJOL(int NECJILEFBAO, int FDEJBCNGOEG, int KDHBFAIDAAI, IPEndPoint HGLJLELKDLE, IPEndPoint EJLHGDDBGIO)
		{
			ABBLIOLAABC aBBLIOLAABC = BAEKNEEELFH(NECJILEFBAO);
			if (aBBLIOLAABC == null)
			{
				aBBLIOLAABC = new ABBLIOLAABC(KLBIKHEFDHH, NECJILEFBAO, KDHBFAIDAAI);
				BJGGCKHADHN.Add(NECJILEFBAO, aBBLIOLAABC);
			}
			return aBBLIOLAABC.JAPMCIEFPJL(FDEJBCNGOEG, KDHBFAIDAAI, HGLJLELKDLE, EJLHGDDBGIO);
		}

		public ABBLIOLAABC BAEKNEEELFH(int NECJILEFBAO)
		{
			ABBLIOLAABC value = null;
			if (BJGGCKHADHN.TryGetValue(NECJILEFBAO, out value))
			{
				return value;
			}
			return null;
		}

		public void MOIEMOCFCCG()
		{
			BJGGCKHADHN.Clear();
		}

		public void FLIPEOEJKLC()
		{
			BJGGCKHADHN.Clear();
		}

		public void BBBIPFGBAGA(float DMLKFKGBHKJ)
		{
			Dictionary<int, ABBLIOLAABC>.Enumerator enumerator = BJGGCKHADHN.GetEnumerator();
			while (enumerator.MoveNext())
			{
				enumerator.Current.Value.LPBLGFCPADD(DMLKFKGBHKJ);
			}
		}

		public bool MFBHHKPJDOD(int NECJILEFBAO, int KDHBFAIDAAI)
		{
			ABBLIOLAABC aBBLIOLAABC = BAEKNEEELFH(NECJILEFBAO);
			if (aBBLIOLAABC != null)
			{
				return false;
			}
			aBBLIOLAABC = new ABBLIOLAABC(KLBIKHEFDHH, NECJILEFBAO, KDHBFAIDAAI);
			BJGGCKHADHN.Add(NECJILEFBAO, aBBLIOLAABC);
			return true;
		}

		public LHOLJMEKHBF NGMAFIGMGFH(int FDEJBCNGOEG)
		{
			LHOLJMEKHBF lHOLJMEKHBF = null;
			Dictionary<int, ABBLIOLAABC>.Enumerator enumerator = BJGGCKHADHN.GetEnumerator();
			while (enumerator.MoveNext())
			{
				lHOLJMEKHBF = enumerator.Current.Value.KBLCDMPGOMM(FDEJBCNGOEG);
				if (lHOLJMEKHBF != null)
				{
					return lHOLJMEKHBF;
				}
			}
			return lHOLJMEKHBF;
		}

		public LHOLJMEKHBF CEFLFNJBGOM(int FDEJBCNGOEG)
		{
			LHOLJMEKHBF lHOLJMEKHBF = null;
			Dictionary<int, ABBLIOLAABC>.Enumerator enumerator = BJGGCKHADHN.GetEnumerator();
			while (enumerator.MoveNext())
			{
				lHOLJMEKHBF = enumerator.Current.Value.KBLCDMPGOMM(FDEJBCNGOEG);
				if (lHOLJMEKHBF != null)
				{
					return lHOLJMEKHBF;
				}
			}
			return lHOLJMEKHBF;
		}

		public void GJLNCHPCJJA(int NECJILEFBAO, int KDHBFAIDAAI)
		{
			ABBLIOLAABC aBBLIOLAABC = ALNCFMJOPCC(NECJILEFBAO);
			if (aBBLIOLAABC != null)
			{
				aBBLIOLAABC.LNOAKEKHCGF(KDHBFAIDAAI);
			}
		}

		public LHOLJMEKHBF EDEIEIHNNMD(int NECJILEFBAO, int FDEJBCNGOEG, int KDHBFAIDAAI, IPEndPoint HGLJLELKDLE, IPEndPoint EJLHGDDBGIO)
		{
			ABBLIOLAABC aBBLIOLAABC = KBLCDMPGOMM(NECJILEFBAO);
			if (aBBLIOLAABC == null)
			{
				aBBLIOLAABC = new ABBLIOLAABC(KLBIKHEFDHH, NECJILEFBAO, KDHBFAIDAAI);
				BJGGCKHADHN.Add(NECJILEFBAO, aBBLIOLAABC);
			}
			return aBBLIOLAABC.EDEIEIHNNMD(FDEJBCNGOEG, KDHBFAIDAAI, HGLJLELKDLE, EJLHGDDBGIO);
		}

		public FMMNGEJDCOH(EKACODPEIIO FHALIMDOODA)
		{
			KLBIKHEFDHH = FHALIMDOODA;
			BJGGCKHADHN = new Dictionary<int, ABBLIOLAABC>();
		}

		public ABBLIOLAABC NNHKFEEGDLG()
		{
			Dictionary<int, ABBLIOLAABC>.Enumerator enumerator = BJGGCKHADHN.GetEnumerator();
			if (enumerator.MoveNext())
			{
				return enumerator.Current.Value;
			}
			return null;
		}

		public bool PCKEOANHGBD(int NECJILEFBAO, int FDEJBCNGOEG, int KDHBFAIDAAI)
		{
			ABBLIOLAABC aBBLIOLAABC = KBLCDMPGOMM(NECJILEFBAO);
			if (aBBLIOLAABC == null)
			{
				return false;
			}
			aBBLIOLAABC.PCKEOANHGBD(FDEJBCNGOEG, KDHBFAIDAAI);
			return true;
		}

		internal void EBMDMJNBKKH(IPEndPoint HGLJLELKDLE)
		{
			Dictionary<int, ABBLIOLAABC>.Enumerator enumerator = BJGGCKHADHN.GetEnumerator();
			while (enumerator.MoveNext())
			{
				enumerator.Current.Value.AMPEHAOOOGH(HGLJLELKDLE);
			}
		}

		public void IDFOPLPMIJB(int NECJILEFBAO, int KDHBFAIDAAI)
		{
			ABBLIOLAABC aBBLIOLAABC = GIPLDLCMIDO(NECJILEFBAO);
			if (aBBLIOLAABC != null)
			{
				aBBLIOLAABC.LNOAKEKHCGF(KDHBFAIDAAI);
			}
		}

		public ABBLIOLAABC KBLCDMPGOMM(int NECJILEFBAO)
		{
			ABBLIOLAABC value = null;
			if (BJGGCKHADHN.TryGetValue(NECJILEFBAO, out value))
			{
				return value;
			}
			return null;
		}

		public LHOLJMEKHBF MLJCOJJAFHB(int NECJILEFBAO, int FDEJBCNGOEG, int KDHBFAIDAAI, IPEndPoint HGLJLELKDLE, IPEndPoint EJLHGDDBGIO)
		{
			ABBLIOLAABC aBBLIOLAABC = KBLCDMPGOMM(NECJILEFBAO);
			if (aBBLIOLAABC == null)
			{
				aBBLIOLAABC = new ABBLIOLAABC(KLBIKHEFDHH, NECJILEFBAO, KDHBFAIDAAI);
				BJGGCKHADHN.Add(NECJILEFBAO, aBBLIOLAABC);
			}
			return aBBLIOLAABC.JAPMCIEFPJL(FDEJBCNGOEG, KDHBFAIDAAI, HGLJLELKDLE, EJLHGDDBGIO);
		}

		public ABBLIOLAABC ALNCFMJOPCC(int NECJILEFBAO)
		{
			ABBLIOLAABC value = null;
			if (BJGGCKHADHN.TryGetValue(NECJILEFBAO, out value))
			{
				return value;
			}
			return null;
		}

		internal void PBCAAFAINJI(KJGALEFHHOA CFOGKELLCDI)
		{
			Dictionary<int, ABBLIOLAABC>.Enumerator enumerator = BJGGCKHADHN.GetEnumerator();
			while (enumerator.MoveNext())
			{
				enumerator.Current.Value.HCMCACHPAJH(CFOGKELLCDI);
			}
		}

		public void PDCPMDCOLOD()
		{
			BJGGCKHADHN.Clear();
		}

		public void LPBLGFCPADD(float DMLKFKGBHKJ)
		{
			if (KLBIKHEFDHH.JIPBIOELJHC() != null)
			{
				Dictionary<int, ABBLIOLAABC>.Enumerator enumerator = BJGGCKHADHN.GetEnumerator();
				while (enumerator.MoveNext())
				{
					enumerator.Current.Value.LPBLGFCPADD(DMLKFKGBHKJ);
				}
			}
		}

		public bool GCKJMAIOBHF(int NECJILEFBAO)
		{
			ABBLIOLAABC aBBLIOLAABC = KBLCDMPGOMM(NECJILEFBAO);
			if (aBBLIOLAABC == null)
			{
				return false;
			}
			aBBLIOLAABC.PDCPMDCOLOD();
			return BJGGCKHADHN.Remove(NECJILEFBAO);
		}

		public void BPJAIEICKPC(int NECJILEFBAO, int KDHBFAIDAAI)
		{
			ABBLIOLAABC aBBLIOLAABC = KBLCDMPGOMM(NECJILEFBAO);
			if (aBBLIOLAABC != null)
			{
				aBBLIOLAABC.LNOAKEKHCGF(KDHBFAIDAAI);
			}
		}

		internal void MPIBGMJJJOH(KJGALEFHHOA CFOGKELLCDI)
		{
			Dictionary<int, ABBLIOLAABC>.Enumerator enumerator = BJGGCKHADHN.GetEnumerator();
			while (enumerator.MoveNext())
			{
				enumerator.Current.Value.MPIBGMJJJOH(CFOGKELLCDI);
			}
		}

		public ABBLIOLAABC GIPLDLCMIDO(int NECJILEFBAO)
		{
			ABBLIOLAABC value = null;
			if (BJGGCKHADHN.TryGetValue(NECJILEFBAO, out value))
			{
				return value;
			}
			return null;
		}

		public void LBMGEFMOIGL(int NECJILEFBAO, int KDHBFAIDAAI)
		{
			ABBLIOLAABC aBBLIOLAABC = KBLCDMPGOMM(NECJILEFBAO);
			if (aBBLIOLAABC != null)
			{
				aBBLIOLAABC.LNOAKEKHCGF(KDHBFAIDAAI);
			}
		}

		public LHOLJMEKHBF MCHMMAKELNH(int FDEJBCNGOEG)
		{
			LHOLJMEKHBF lHOLJMEKHBF = null;
			Dictionary<int, ABBLIOLAABC>.Enumerator enumerator = BJGGCKHADHN.GetEnumerator();
			while (enumerator.MoveNext())
			{
				lHOLJMEKHBF = enumerator.Current.Value.KBLCDMPGOMM(FDEJBCNGOEG);
				if (lHOLJMEKHBF != null)
				{
					return lHOLJMEKHBF;
				}
			}
			return lHOLJMEKHBF;
		}

		public LHOLJMEKHBF IAFNIPEGNLN(int FDEJBCNGOEG)
		{
			LHOLJMEKHBF lHOLJMEKHBF = null;
			Dictionary<int, ABBLIOLAABC>.Enumerator enumerator = BJGGCKHADHN.GetEnumerator();
			while (enumerator.MoveNext())
			{
				lHOLJMEKHBF = enumerator.Current.Value.KBLCDMPGOMM(FDEJBCNGOEG);
				if (lHOLJMEKHBF != null)
				{
					return lHOLJMEKHBF;
				}
			}
			return lHOLJMEKHBF;
		}

		public bool MGGPMGKEDJL(int NECJILEFBAO, int FDEJBCNGOEG, int KDHBFAIDAAI)
		{
			ABBLIOLAABC aBBLIOLAABC = GIPLDLCMIDO(NECJILEFBAO);
			if (aBBLIOLAABC == null)
			{
				return false;
			}
			aBBLIOLAABC.ODCBADCNALH(FDEJBCNGOEG, KDHBFAIDAAI);
			return true;
		}

		internal void AMPEHAOOOGH(IPEndPoint HGLJLELKDLE)
		{
			Dictionary<int, ABBLIOLAABC>.Enumerator enumerator = BJGGCKHADHN.GetEnumerator();
			while (enumerator.MoveNext())
			{
				enumerator.Current.Value.AMPEHAOOOGH(HGLJLELKDLE);
			}
		}

		public void GJJFNPJFBFC(float DMLKFKGBHKJ)
		{
			Dictionary<int, ABBLIOLAABC>.Enumerator enumerator = BJGGCKHADHN.GetEnumerator();
			while (enumerator.MoveNext())
			{
				enumerator.Current.Value.LPBLGFCPADD(DMLKFKGBHKJ);
			}
		}

		public ABBLIOLAABC LMEJDPEKMOD()
		{
			Dictionary<int, ABBLIOLAABC>.Enumerator enumerator = BJGGCKHADHN.GetEnumerator();
			if (enumerator.MoveNext())
			{
				return enumerator.Current.Value;
			}
			return null;
		}

		public ABBLIOLAABC KICCBFBCHLF()
		{
			Dictionary<int, ABBLIOLAABC>.Enumerator enumerator = BJGGCKHADHN.GetEnumerator();
			if (enumerator.MoveNext())
			{
				return enumerator.Current.Value;
			}
			return null;
		}

		public void JNAHBIOCCOD(int NECJILEFBAO, int KDHBFAIDAAI)
		{
			ABBLIOLAABC aBBLIOLAABC = KBLCDMPGOMM(NECJILEFBAO);
			if (aBBLIOLAABC != null)
			{
				aBBLIOLAABC.LNOAKEKHCGF(KDHBFAIDAAI);
			}
		}

		internal void AFABDAHEAMK(long DJLHGLLPIHH)
		{
			Dictionary<int, ABBLIOLAABC>.Enumerator enumerator = BJGGCKHADHN.GetEnumerator();
			while (enumerator.MoveNext())
			{
				enumerator.Current.Value.AFABDAHEAMK(DJLHGLLPIHH);
			}
		}

		public bool MMJOMFGEJHC(int NECJILEFBAO, int KDHBFAIDAAI)
		{
			ABBLIOLAABC aBBLIOLAABC = KBLCDMPGOMM(NECJILEFBAO);
			if (aBBLIOLAABC != null)
			{
				return false;
			}
			aBBLIOLAABC = new ABBLIOLAABC(KLBIKHEFDHH, NECJILEFBAO, KDHBFAIDAAI);
			BJGGCKHADHN.Add(NECJILEFBAO, aBBLIOLAABC);
			return true;
		}

		public void FMNCGDJMGKC(int NECJILEFBAO, int KDHBFAIDAAI)
		{
			ABBLIOLAABC aBBLIOLAABC = KBLCDMPGOMM(NECJILEFBAO);
			if (aBBLIOLAABC != null)
			{
				aBBLIOLAABC.LNOAKEKHCGF(KDHBFAIDAAI);
			}
		}
	}
}
