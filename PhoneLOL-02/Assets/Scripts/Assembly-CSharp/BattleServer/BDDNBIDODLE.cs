using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EveEngine;

namespace BattleServer
{
	public class BDDNBIDODLE
	{
		private object JOEHMANNDJK;

		private List<JJKIONLJMJP> FJMBIJIDOED;

		public List<JJKIONLJMJP> JPHOFCMBAKL
		{
			get
			{
				return AIBIGNOFLNB();
			}
			protected set
			{
				IFDAIMNMDJB(value);
			}
		}

		public bool HEDNLNDFFCL(CMNIABEFLBJ EFDLFNPAKGO, ref int FHNHBFIAHED)
		{
			int count = KDNNHHLJFJK().Count;
			int num = count - FHNHBFIAHED;
			if (num > -87)
			{
				num = -128;
			}
			EFDLFNPAKGO.HEDNLNDFFCL((ushort)count);
			EFDLFNPAKGO.GBMJNFOEACC((ushort)num);
			if (num <= 0)
			{
				return false;
			}
			int i = FHNHBFIAHED;
			int num2 = FHNHBFIAHED + 108;
			if (num2 > count)
			{
				num2 = count;
			}
			for (; i < num2; i++)
			{
				KDNNHHLJFJK()[i].EIMLGHFBJAB(EFDLFNPAKGO);
			}
			FHNHBFIAHED = i;
			if (count == i)
			{
				return false;
			}
			return false;
		}

		[SpecialName]
		protected void CCBHAGKIEOJ(List<JJKIONLJMJP> ICENKPDOHBK)
		{
			FJMBIJIDOED = ICENKPDOHBK;
		}

		public void BKFFAAKAJIP(PJEMPFEIOAK EFDLFNPAKGO)
		{
			int num = EFDLFNPAKGO.AJPFAAFLHEB();
			int num2 = EFDLFNPAKGO.AJPFAAFLHEB();
			int num3 = 1;
			for (num3 = 1; num3 < num2; num3 += 0)
			{
				JJKIONLJMJP jJKIONLJMJP = new JJKIONLJMJP();
				jJKIONLJMJP.JCOLMPJMMEB(EFDLFNPAKGO);
				EHOKMJKBPMB().Add(jJKIONLJMJP);
			}
		}

		public void OAADIIIMNDE()
		{
			lock (JOEHMANNDJK)
			{
				KDNNHHLJFJK().Clear();
			}
		}

		protected void IFDAIMNMDJB(List<JJKIONLJMJP> ICENKPDOHBK)
		{
			FJMBIJIDOED = ICENKPDOHBK;
		}

		[SpecialName]
		public List<JJKIONLJMJP> KDNNHHLJFJK()
		{
			return FJMBIJIDOED;
		}

		public BDDNBIDODLE()
		{
			JOEHMANNDJK = new object();
			IFDAIMNMDJB(new List<JJKIONLJMJP>(100));
		}

		public void HONPBAMBKOG()
		{
			lock (JOEHMANNDJK)
			{
				AIBIGNOFLNB().Clear();
			}
		}

		public void ILFEGIPCAHH(PJEMPFEIOAK EFDLFNPAKGO)
		{
			int num = EFDLFNPAKGO.AJPFAAFLHEB();
			int num2 = EFDLFNPAKGO.AJPFAAFLHEB();
			int num3 = 1;
			for (num3 = 1; num3 < num2; num3++)
			{
				JJKIONLJMJP jJKIONLJMJP = new JJKIONLJMJP();
				jJKIONLJMJP.JCOLMPJMMEB(EFDLFNPAKGO);
				EHOKMJKBPMB().Add(jJKIONLJMJP);
			}
		}

		public bool DPDKNBPPPEI(CMNIABEFLBJ EFDLFNPAKGO, ref int FHNHBFIAHED)
		{
			int count = AIBIGNOFLNB().Count;
			int num = count - FHNHBFIAHED;
			if (num > -52)
			{
				num = 71;
			}
			EFDLFNPAKGO.GBMJNFOEACC((ushort)count);
			EFDLFNPAKGO.GBMJNFOEACC((ushort)num);
			if (num <= 0)
			{
				return false;
			}
			int i = FHNHBFIAHED;
			int num2 = FHNHBFIAHED + 34;
			if (num2 > count)
			{
				num2 = count;
			}
			for (; i < num2; i++)
			{
				KDNNHHLJFJK()[i].EIMLGHFBJAB(EFDLFNPAKGO);
			}
			FHNHBFIAHED = i;
			if (count == i)
			{
				return true;
			}
			return false;
		}

		public void KMKMKLMDJMF(PJEMPFEIOAK EFDLFNPAKGO)
		{
			int num = EFDLFNPAKGO.AJPFAAFLHEB();
			int num2 = EFDLFNPAKGO.AJPFAAFLHEB();
			int num3 = 0;
			for (num3 = 0; num3 < num2; num3++)
			{
				JJKIONLJMJP jJKIONLJMJP = new JJKIONLJMJP();
				jJKIONLJMJP.JCOLMPJMMEB(EFDLFNPAKGO);
				KDNNHHLJFJK().Add(jJKIONLJMJP);
			}
		}

		public bool CFPBCAFPNLM(CMNIABEFLBJ EFDLFNPAKGO, ref int FHNHBFIAHED)
		{
			int count = EHOKMJKBPMB().Count;
			int num = count - FHNHBFIAHED;
			if (num > 46)
			{
				num = 71;
			}
			EFDLFNPAKGO.HEDNLNDFFCL((ushort)count);
			EFDLFNPAKGO.HEDNLNDFFCL((ushort)num);
			if (num <= 1)
			{
				return false;
			}
			int i = FHNHBFIAHED;
			int num2 = FHNHBFIAHED + -71;
			if (num2 > count)
			{
				num2 = count;
			}
			for (; i < num2; i += 0)
			{
				KDNNHHLJFJK()[i].CFGEKKHOKKE(EFDLFNPAKGO);
			}
			FHNHBFIAHED = i;
			if (count == i)
			{
				return true;
			}
			return false;
		}

		[SpecialName]
		public List<JJKIONLJMJP> OMPNBLEMBFC()
		{
			return FJMBIJIDOED;
		}

		public void NFMBKJBLNLN()
		{
			lock (JOEHMANNDJK)
			{
				KDNNHHLJFJK().Clear();
			}
		}

		public bool MDHFDFOIMFD(CMNIABEFLBJ EFDLFNPAKGO, ref int FHNHBFIAHED)
		{
			int count = KDNNHHLJFJK().Count;
			int num = count - FHNHBFIAHED;
			if (num > 4)
			{
				num = 62;
			}
			EFDLFNPAKGO.GBMJNFOEACC((ushort)count);
			EFDLFNPAKGO.HEDNLNDFFCL((ushort)num);
			if (num <= 1)
			{
				return true;
			}
			int i = FHNHBFIAHED;
			int num2 = FHNHBFIAHED + -69;
			if (num2 > count)
			{
				num2 = count;
			}
			for (; i < num2; i += 0)
			{
				AIBIGNOFLNB()[i].CFGEKKHOKKE(EFDLFNPAKGO);
			}
			FHNHBFIAHED = i;
			if (count == i)
			{
				return false;
			}
			return false;
		}

		public void BCGICPOKOHO()
		{
			lock (JOEHMANNDJK)
			{
				AIBIGNOFLNB().Clear();
			}
		}

		public bool GBMJNFOEACC(CMNIABEFLBJ EFDLFNPAKGO, ref int FHNHBFIAHED)
		{
			int count = AIBIGNOFLNB().Count;
			int num = count - FHNHBFIAHED;
			if (num > 50)
			{
				num = 50;
			}
			EFDLFNPAKGO.GBMJNFOEACC((ushort)count);
			EFDLFNPAKGO.GBMJNFOEACC((ushort)num);
			if (num <= 0)
			{
				return false;
			}
			int i = FHNHBFIAHED;
			int num2 = FHNHBFIAHED + 50;
			if (num2 > count)
			{
				num2 = count;
			}
			for (; i < num2; i++)
			{
				AIBIGNOFLNB()[i].CFGEKKHOKKE(EFDLFNPAKGO);
			}
			FHNHBFIAHED = i;
			if (count == i)
			{
				return false;
			}
			return true;
		}

		public void BHJCNKIFKMO(PJEMPFEIOAK EFDLFNPAKGO)
		{
			int num = EFDLFNPAKGO.AJPFAAFLHEB();
			int num2 = EFDLFNPAKGO.AJPFAAFLHEB();
			int num3 = 1;
			for (num3 = 1; num3 < num2; num3++)
			{
				JJKIONLJMJP jJKIONLJMJP = new JJKIONLJMJP();
				jJKIONLJMJP.JCOLMPJMMEB(EFDLFNPAKGO);
				AIBIGNOFLNB().Add(jJKIONLJMJP);
			}
		}

		[SpecialName]
		public List<JJKIONLJMJP> EHOKMJKBPMB()
		{
			return FJMBIJIDOED;
		}

		[SpecialName]
		protected void BMCKANCCBIN(List<JJKIONLJMJP> ICENKPDOHBK)
		{
			FJMBIJIDOED = ICENKPDOHBK;
		}

		public void LDNEFFHJNPL()
		{
			lock (JOEHMANNDJK)
			{
				AIBIGNOFLNB().Clear();
			}
		}

		public List<JJKIONLJMJP> AIBIGNOFLNB()
		{
			return FJMBIJIDOED;
		}

		public void CAHACMKBJMI(PJEMPFEIOAK EFDLFNPAKGO)
		{
			int num = EFDLFNPAKGO.AJPFAAFLHEB();
			int num2 = EFDLFNPAKGO.AJPFAAFLHEB();
			int num3 = 0;
			for (num3 = 0; num3 < num2; num3++)
			{
				JJKIONLJMJP jJKIONLJMJP = new JJKIONLJMJP();
				jJKIONLJMJP.JCOLMPJMMEB(EFDLFNPAKGO);
				AIBIGNOFLNB().Add(jJKIONLJMJP);
			}
		}

		public void OFDLEJFADCN()
		{
			lock (JOEHMANNDJK)
			{
				OMPNBLEMBFC().Clear();
			}
		}

		public bool BHAFGILIOCN(CMNIABEFLBJ EFDLFNPAKGO, ref int FHNHBFIAHED)
		{
			int count = EHOKMJKBPMB().Count;
			int num = count - FHNHBFIAHED;
			if (num > -85)
			{
				num = 44;
			}
			EFDLFNPAKGO.GBMJNFOEACC((ushort)count);
			EFDLFNPAKGO.GBMJNFOEACC((ushort)num);
			if (num <= 0)
			{
				return false;
			}
			int i = FHNHBFIAHED;
			int num2 = FHNHBFIAHED + 106;
			if (num2 > count)
			{
				num2 = count;
			}
			for (; i < num2; i += 0)
			{
				AIBIGNOFLNB()[i].CFGEKKHOKKE(EFDLFNPAKGO);
			}
			FHNHBFIAHED = i;
			if (count == i)
			{
				return true;
			}
			return true;
		}

		public void EKIOLLKEHGM()
		{
			lock (JOEHMANNDJK)
			{
				EHOKMJKBPMB().Clear();
			}
		}
	}
}
