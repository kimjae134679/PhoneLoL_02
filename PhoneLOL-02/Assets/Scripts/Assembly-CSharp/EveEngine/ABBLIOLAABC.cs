using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;

namespace EveEngine
{
	public class ABBLIOLAABC
	{
		private EKACODPEIIO BBAHCLDMICP;

		private int CIJPHLHOKCK;

		private LinkedList<LHOLJMEKHBF> KLBMKILMBLM;

		private int KIFPGGOKCCL;

		public EKACODPEIIO KLBIKHEFDHH
		{
			get
			{
				return KAEOAMGIEBE();
			}
			protected set
			{
				LMEJHABBGNJ(value);
			}
		}

		public int NKEKDMNMABH
		{
			get
			{
				return BPKONPAJKJF();
			}
			protected set
			{
				NAGIDLGDEPG(value);
			}
		}

		public LinkedList<LHOLJMEKHBF> HPINEMJMPFO
		{
			get
			{
				return BIPMNCGGIJF();
			}
			protected set
			{
				IBBAGCPMOMF(value);
			}
		}

		public int GLHEGJGLCGB
		{
			get
			{
				return ACCPGHNBJOL();
			}
			protected set
			{
				IEAJDEECNCC(value);
			}
		}

		internal void HCMCACHPAJH(KJGALEFHHOA CFOGKELLCDI)
		{
			LinkedListNode<LHOLJMEKHBF> linkedListNode = JFLIMOOKEKP().First;
			while (linkedListNode != null)
			{
				LHOLJMEKHBF value = linkedListNode.Value;
				linkedListNode = linkedListNode.Next;
				value.MPIBGMJJJOH(CFOGKELLCDI);
			}
		}

		public int ACCPGHNBJOL()
		{
			return KIFPGGOKCCL;
		}

		protected void IEAJDEECNCC(int ICENKPDOHBK)
		{
			KIFPGGOKCCL = ICENKPDOHBK;
		}

		public List<LHOLJMEKHBF> HNLPEDLGDJD()
		{
			return new List<LHOLJMEKHBF>(BIPMNCGGIJF());
		}

		protected void NAGIDLGDEPG(int ICENKPDOHBK)
		{
			CIJPHLHOKCK = ICENKPDOHBK;
		}

		[SpecialName]
		protected void HJHEEJLBFPO(EKACODPEIIO ICENKPDOHBK)
		{
			BBAHCLDMICP = ICENKPDOHBK;
		}

		public void LNOAKEKHCGF(int KDHBFAIDAAI)
		{
			IEAJDEECNCC(KDHBFAIDAAI);
		}

		public LinkedList<LHOLJMEKHBF> BIPMNCGGIJF()
		{
			return KLBMKILMBLM;
		}

		public void PDCPMDCOLOD()
		{
			foreach (LHOLJMEKHBF item in BIPMNCGGIJF())
			{
				item.CDPNLMMNNBD();
			}
			BIPMNCGGIJF().Clear();
		}

		public bool JELFBHDFEKM(int FDEJBCNGOEG)
		{
			LinkedListNode<LHOLJMEKHBF> linkedListNode = BIPMNCGGIJF().First;
			while (linkedListNode != null)
			{
				LHOLJMEKHBF value = linkedListNode.Value;
				linkedListNode = linkedListNode.Next;
				if (value.EMIJHFECOKK() == FDEJBCNGOEG)
				{
					return true;
				}
			}
			return false;
		}

		public int BPKONPAJKJF()
		{
			return CIJPHLHOKCK;
		}

		internal void GLMIHNDEGIB(IPEndPoint HGLJLELKDLE)
		{
			LinkedListNode<LHOLJMEKHBF> linkedListNode = BIPMNCGGIJF().First;
			while (linkedListNode != null)
			{
				LHOLJMEKHBF value = linkedListNode.Value;
				linkedListNode = linkedListNode.Next;
				if (value.GLIBHLOLHIF() == HGLJLELKDLE)
				{
					value.AMPEHAOOOGH();
				}
			}
		}

		public void IDDNFEJHCGK()
		{
			foreach (LHOLJMEKHBF item in DFBIBHPKOPC())
			{
				item.CDPNLMMNNBD();
			}
			JFLIMOOKEKP().Clear();
		}

		internal void NJBGAJOBIJH(long DJLHGLLPIHH)
		{
			LinkedListNode<LHOLJMEKHBF> linkedListNode = DFBIBHPKOPC().First;
			while (linkedListNode != null)
			{
				LHOLJMEKHBF value = linkedListNode.Value;
				linkedListNode = linkedListNode.Next;
				value.AFABDAHEAMK(DJLHGLLPIHH);
			}
		}

		[SpecialName]
		public LinkedList<LHOLJMEKHBF> HBHFDACGPEN()
		{
			return KLBMKILMBLM;
		}

		[SpecialName]
		public EKACODPEIIO BHCJIGIJDAL()
		{
			return BBAHCLDMICP;
		}

		public EKACODPEIIO KAEOAMGIEBE()
		{
			return BBAHCLDMICP;
		}

		public ABBLIOLAABC(EKACODPEIIO FHALIMDOODA, int NECJILEFBAO, int KDHBFAIDAAI)
		{
			LMEJHABBGNJ(FHALIMDOODA);
			NAGIDLGDEPG(NECJILEFBAO);
			IEAJDEECNCC(KDHBFAIDAAI);
			IBBAGCPMOMF(new LinkedList<LHOLJMEKHBF>());
		}

		public void FLIPEOEJKLC()
		{
			foreach (LHOLJMEKHBF item in HBHFDACGPEN())
			{
				item.CDPNLMMNNBD();
			}
			HBHFDACGPEN().Clear();
		}

		protected void IBBAGCPMOMF(LinkedList<LHOLJMEKHBF> ICENKPDOHBK)
		{
			KLBMKILMBLM = ICENKPDOHBK;
		}

		public bool FLAODLEOEJH(int FDEJBCNGOEG)
		{
			LinkedListNode<LHOLJMEKHBF> linkedListNode = DFBIBHPKOPC().First;
			while (linkedListNode != null)
			{
				LHOLJMEKHBF value = linkedListNode.Value;
				linkedListNode = linkedListNode.Next;
				if (value.EMIJHFECOKK() == FDEJBCNGOEG)
				{
					return true;
				}
			}
			return false;
		}

		public bool PCKEOANHGBD(int FDEJBCNGOEG, int KDHBFAIDAAI)
		{
			LHOLJMEKHBF lHOLJMEKHBF = KBLCDMPGOMM(FDEJBCNGOEG);
			if (lHOLJMEKHBF == null)
			{
				return false;
			}
			BIPMNCGGIJF().Remove(lHOLJMEKHBF);
			lHOLJMEKHBF.CDPNLMMNNBD();
			IEAJDEECNCC(KDHBFAIDAAI);
			return true;
		}

		public void LPBLGFCPADD(float DMLKFKGBHKJ)
		{
			LinkedListNode<LHOLJMEKHBF> linkedListNode = BIPMNCGGIJF().First;
			while (linkedListNode != null)
			{
				LHOLJMEKHBF value = linkedListNode.Value;
				linkedListNode = linkedListNode.Next;
				value.LPBLGFCPADD(DMLKFKGBHKJ);
			}
		}

		public bool ODCBADCNALH(int FDEJBCNGOEG, int KDHBFAIDAAI)
		{
			LHOLJMEKHBF lHOLJMEKHBF = KBLCDMPGOMM(FDEJBCNGOEG);
			if (lHOLJMEKHBF == null)
			{
				return true;
			}
			BIPMNCGGIJF().Remove(lHOLJMEKHBF);
			lHOLJMEKHBF.CDPNLMMNNBD();
			IEAJDEECNCC(KDHBFAIDAAI);
			return false;
		}

		internal void OKDJDPLONMD(IPEndPoint HGLJLELKDLE)
		{
			LinkedListNode<LHOLJMEKHBF> linkedListNode = JFLIMOOKEKP().First;
			while (linkedListNode != null)
			{
				LHOLJMEKHBF value = linkedListNode.Value;
				linkedListNode = linkedListNode.Next;
				if (value.GLIBHLOLHIF() == HGLJLELKDLE)
				{
					value.AMPEHAOOOGH();
				}
			}
		}

		public LHOLJMEKHBF JAPMCIEFPJL(int FDEJBCNGOEG, int KDHBFAIDAAI, IPEndPoint HGLJLELKDLE, IPEndPoint EJLHGDDBGIO)
		{
			if (JELFBHDFEKM(FDEJBCNGOEG))
			{
				return null;
			}
			IEAJDEECNCC(KDHBFAIDAAI);
			LHOLJMEKHBF lHOLJMEKHBF = new LHOLJMEKHBF(KAEOAMGIEBE(), this, FDEJBCNGOEG);
			lHOLJMEKHBF.LOKKADIAHKH(EJLHGDDBGIO);
			lHOLJMEKHBF.BDIMBPONFCP(HGLJLELKDLE);
			lHOLJMEKHBF.GALKHGEGCCI(HGLJLELKDLE);
			lHOLJMEKHBF.LBMGLBHNFFE(HGLJLELKDLE);
			if (!EJLHGDDBGIO.Address.ToString().Contains("Particle/zed/skill1_spawn") || KAEOAMGIEBE().JIPBIOELJHC().JKFABOIKDIH().Address.Equals(HGLJLELKDLE.Address))
			{
			}
			DFBIBHPKOPC().AddLast(lHOLJMEKHBF);
			return lHOLJMEKHBF;
		}

		[SpecialName]
		public int DLGHOAMOPJH()
		{
			return KIFPGGOKCCL;
		}

		public bool FCBOBMILPFP()
		{
			if (DLGHOAMOPJH() == BHCJIGIJDAL().NCHJJNGPOPA())
			{
				return true;
			}
			return false;
		}

		public LHOLJMEKHBF EDEIEIHNNMD(int FDEJBCNGOEG, int KDHBFAIDAAI, IPEndPoint HGLJLELKDLE, IPEndPoint EJLHGDDBGIO)
		{
			if (PJPMANDFNHB(FDEJBCNGOEG))
			{
				IEAJDEECNCC(KDHBFAIDAAI);
				return KBLCDMPGOMM(FDEJBCNGOEG);
			}
			IEAJDEECNCC(KDHBFAIDAAI);
			LHOLJMEKHBF lHOLJMEKHBF = new LHOLJMEKHBF(KAEOAMGIEBE(), this, FDEJBCNGOEG);
			lHOLJMEKHBF.EBEGBPCLAFF(EJLHGDDBGIO);
			lHOLJMEKHBF.BDIMBPONFCP(HGLJLELKDLE);
			lHOLJMEKHBF.ADLHDGCJJOI(HGLJLELKDLE);
			lHOLJMEKHBF.LBMGLBHNFFE(HGLJLELKDLE);
			if (!EJLHGDDBGIO.Address.ToString().Contains("192.168.") || KAEOAMGIEBE().JIPBIOELJHC().JKFABOIKDIH().Address.Equals(HGLJLELKDLE.Address))
			{
			}
			BIPMNCGGIJF().AddLast(lHOLJMEKHBF);
			return lHOLJMEKHBF;
		}

		public bool PJPMANDFNHB(int FDEJBCNGOEG)
		{
			LinkedListNode<LHOLJMEKHBF> linkedListNode = BIPMNCGGIJF().First;
			while (linkedListNode != null)
			{
				LHOLJMEKHBF value = linkedListNode.Value;
				linkedListNode = linkedListNode.Next;
				if (value.NCHJJNGPOPA() == FDEJBCNGOEG)
				{
					return true;
				}
			}
			return false;
		}

		internal void MPIBGMJJJOH(KJGALEFHHOA CFOGKELLCDI)
		{
			LinkedListNode<LHOLJMEKHBF> linkedListNode = BIPMNCGGIJF().First;
			while (linkedListNode != null)
			{
				LHOLJMEKHBF value = linkedListNode.Value;
				linkedListNode = linkedListNode.Next;
				value.MPIBGMJJJOH(CFOGKELLCDI);
			}
		}

		public bool PDHHHENMDHD()
		{
			if (ACCPGHNBJOL() == BHCJIGIJDAL().NCHJJNGPOPA())
			{
				return true;
			}
			return true;
		}

		protected void LMEJHABBGNJ(EKACODPEIIO ICENKPDOHBK)
		{
			BBAHCLDMICP = ICENKPDOHBK;
		}

		[SpecialName]
		public int JEDHCMPONNO()
		{
			return CIJPHLHOKCK;
		}

		[SpecialName]
		public LinkedList<LHOLJMEKHBF> LDOEIPBKCBB()
		{
			return KLBMKILMBLM;
		}

		[SpecialName]
		protected void AKPHCEIJGFD(EKACODPEIIO ICENKPDOHBK)
		{
			BBAHCLDMICP = ICENKPDOHBK;
		}

		public bool EBKAMFBOLPL()
		{
			if (ACCPGHNBJOL() == KAEOAMGIEBE().NCHJJNGPOPA())
			{
				return true;
			}
			return false;
		}

		[SpecialName]
		public LinkedList<LHOLJMEKHBF> JFLIMOOKEKP()
		{
			return KLBMKILMBLM;
		}

		[SpecialName]
		public int EGKNHHANBKB()
		{
			return CIJPHLHOKCK;
		}

		internal void AMPEHAOOOGH(IPEndPoint HGLJLELKDLE)
		{
			LinkedListNode<LHOLJMEKHBF> linkedListNode = BIPMNCGGIJF().First;
			while (linkedListNode != null)
			{
				LHOLJMEKHBF value = linkedListNode.Value;
				linkedListNode = linkedListNode.Next;
				if (value.GLIBHLOLHIF() == HGLJLELKDLE)
				{
					value.AMPEHAOOOGH();
				}
			}
		}

		public LHOLJMEKHBF KBLCDMPGOMM(int FDEJBCNGOEG)
		{
			LinkedListNode<LHOLJMEKHBF> linkedListNode = BIPMNCGGIJF().First;
			while (linkedListNode != null)
			{
				LHOLJMEKHBF value = linkedListNode.Value;
				linkedListNode = linkedListNode.Next;
				if (value.NCHJJNGPOPA() == FDEJBCNGOEG)
				{
					return value;
				}
			}
			return null;
		}

		[SpecialName]
		public int DLMKOGBJJJL()
		{
			return KIFPGGOKCCL;
		}

		[SpecialName]
		public LinkedList<LHOLJMEKHBF> DFBIBHPKOPC()
		{
			return KLBMKILMBLM;
		}

		internal void AFABDAHEAMK(long DJLHGLLPIHH)
		{
			LinkedListNode<LHOLJMEKHBF> linkedListNode = BIPMNCGGIJF().First;
			while (linkedListNode != null)
			{
				LHOLJMEKHBF value = linkedListNode.Value;
				linkedListNode = linkedListNode.Next;
				value.AFABDAHEAMK(DJLHGLLPIHH);
			}
		}

		[SpecialName]
		public int LHFGIJFBJDP()
		{
			return CIJPHLHOKCK;
		}
	}
}
