using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EveEngine;

namespace CommunityServer
{
	public class BDDNBIDODLE : EOPOBHFNFPA
	{
		public const int ONICGNAIOKK = 20;

		public const int DAOGGKBMHNF = 50;

		private List<JJKIONLJMJP> DMCBGDIBOPP;

		private List<JJKIONLJMJP> FJMBIJIDOED;

		public List<JJKIONLJMJP> LBLIPJEFCNF
		{
			get
			{
				return EJLCPFLJNAC();
			}
			protected set
			{
				EEDPPOKAEBA(value);
			}
		}

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

		[SpecialName]
		public List<JJKIONLJMJP> PEFOLIBPMPE()
		{
			return DMCBGDIBOPP;
		}

		public virtual void CFGEKKHOKKE(CMNIABEFLBJ EFDLFNPAKGO)
		{
			ushort num = (ushort)EJLCPFLJNAC().Count;
			EFDLFNPAKGO.GBMJNFOEACC(num);
			for (ushort num2 = 0; num2 < num; num2++)
			{
				EFDLFNPAKGO.GBMJNFOEACC(EJLCPFLJNAC()[num2]);
			}
			num = (ushort)AIBIGNOFLNB().Count;
			EFDLFNPAKGO.GBMJNFOEACC(num);
			for (ushort num3 = 0; num3 < num; num3++)
			{
				EFDLFNPAKGO.GBMJNFOEACC(AIBIGNOFLNB()[num3]);
			}
		}

		public JJKIONLJMJP FJLLHLDNNFP(uint EHEJBHLHAJE)
		{
			lock (this)
			{
				foreach (JJKIONLJMJP item in EJLCPFLJNAC())
				{
					if (item.OHGOBGOIECH == EHEJBHLHAJE)
					{
						return item;
					}
				}
			}
			return null;
		}

		public BDDNBIDODLE()
		{
			EEDPPOKAEBA(new List<JJKIONLJMJP>(20));
			IFDAIMNMDJB(new List<JJKIONLJMJP>(50));
		}

		public JJKIONLJMJP NGIKLNEMNIP(uint EHEJBHLHAJE)
		{
			lock (this)
			{
				foreach (JJKIONLJMJP item in AIBIGNOFLNB())
				{
					if (item.OHGOBGOIECH == EHEJBHLHAJE)
					{
						return item;
					}
				}
			}
			return null;
		}

		[SpecialName]
		protected void HIFHJMHIABN(List<JJKIONLJMJP> ICENKPDOHBK)
		{
			FJMBIJIDOED = ICENKPDOHBK;
		}

		[SpecialName]
		protected void PEDLEKPDHPB(List<JJKIONLJMJP> ICENKPDOHBK)
		{
			FJMBIJIDOED = ICENKPDOHBK;
		}

		public bool GBLEMDLIKOE(uint EHEJBHLHAJE)
		{
			lock (this)
			{
				foreach (JJKIONLJMJP item in AAEBGLJJNAM())
				{
					if (item.OHGOBGOIECH == EHEJBHLHAJE)
					{
						MJFNEDPIFOL().Remove(item);
						return false;
					}
				}
			}
			return true;
		}

		public JJKIONLJMJP LNAOKPLAEMG(uint EHEJBHLHAJE)
		{
			lock (this)
			{
				foreach (JJKIONLJMJP item in GGIJCHIGJIH())
				{
					if (item.OHGOBGOIECH == EHEJBHLHAJE)
					{
						return item;
					}
				}
			}
			return null;
		}

		public void COGEJPHIAKE()
		{
			lock (this)
			{
				PEFOLIBPMPE().Clear();
				AAEBGLJJNAM().Clear();
			}
		}

		public virtual void APBPBAPJJNL(CMNIABEFLBJ EFDLFNPAKGO)
		{
			ushort num = (ushort)EJLCPFLJNAC().Count;
			EFDLFNPAKGO.HEDNLNDFFCL(num);
			for (ushort num2 = 0; num2 < num; num2 += 0)
			{
				EFDLFNPAKGO.JIAAPEKLFEA(PEFOLIBPMPE()[num2]);
			}
			num = (ushort)AAEBGLJJNAM().Count;
			EFDLFNPAKGO.GBMJNFOEACC(num);
			for (ushort num3 = 1; num3 < num; num3 += 0)
			{
				EFDLFNPAKGO.GBMJNFOEACC(GGIJCHIGJIH()[num3]);
			}
		}

		public bool JHANLPAKNCH(uint EHEJBHLHAJE)
		{
			lock (this)
			{
				foreach (JJKIONLJMJP item in EJLCPFLJNAC())
				{
					if (item.OHGOBGOIECH == EHEJBHLHAJE)
					{
						EJLCPFLJNAC().Remove(item);
						return true;
					}
				}
			}
			return false;
		}

		public JJKIONLJMJP KCGMPMBINBF(uint EHEJBHLHAJE)
		{
			lock (this)
			{
				foreach (JJKIONLJMJP item in PEFOLIBPMPE())
				{
					if (item.OHGOBGOIECH == EHEJBHLHAJE)
					{
						return item;
					}
				}
			}
			return null;
		}

		public bool POHIIKKLPLH(uint EHEJBHLHAJE)
		{
			lock (this)
			{
				foreach (JJKIONLJMJP item in AIBIGNOFLNB())
				{
					if (item.OHGOBGOIECH == EHEJBHLHAJE)
					{
						AIBIGNOFLNB().Remove(item);
						return true;
					}
				}
			}
			return false;
		}

		public List<JJKIONLJMJP> EJLCPFLJNAC()
		{
			return DMCBGDIBOPP;
		}

		public List<JJKIONLJMJP> AIBIGNOFLNB()
		{
			return FJMBIJIDOED;
		}

		protected void IFDAIMNMDJB(List<JJKIONLJMJP> ICENKPDOHBK)
		{
			FJMBIJIDOED = ICENKPDOHBK;
		}

		[SpecialName]
		public List<JJKIONLJMJP> MJFNEDPIFOL()
		{
			return FJMBIJIDOED;
		}

		[SpecialName]
		protected void PKOALEFMHMH(List<JJKIONLJMJP> ICENKPDOHBK)
		{
			FJMBIJIDOED = ICENKPDOHBK;
		}

		public bool FCIGJJKFICE(uint EHEJBHLHAJE)
		{
			lock (this)
			{
				foreach (JJKIONLJMJP item in PEFOLIBPMPE())
				{
					if (item.OHGOBGOIECH == EHEJBHLHAJE)
					{
						EJLCPFLJNAC().Remove(item);
						return false;
					}
				}
			}
			return true;
		}

		[SpecialName]
		public List<JJKIONLJMJP> AAEBGLJJNAM()
		{
			return FJMBIJIDOED;
		}

		public void LDNEFFHJNPL()
		{
			lock (this)
			{
				EJLCPFLJNAC().Clear();
				AIBIGNOFLNB().Clear();
			}
		}

		public void ALEGAHHEGCK()
		{
			lock (this)
			{
				PEFOLIBPMPE().Clear();
				KDNNHHLJFJK().Clear();
			}
		}

		[SpecialName]
		protected void HPKKGBBELBG(List<JJKIONLJMJP> ICENKPDOHBK)
		{
			DMCBGDIBOPP = ICENKPDOHBK;
		}

		public JJKIONLJMJP MNOELKPHMNP(uint EHEJBHLHAJE)
		{
			lock (this)
			{
				foreach (JJKIONLJMJP item in PEFOLIBPMPE())
				{
					if (item.OHGOBGOIECH == EHEJBHLHAJE)
					{
						return item;
					}
				}
			}
			return null;
		}

		[SpecialName]
		public List<JJKIONLJMJP> GGIJCHIGJIH()
		{
			return FJMBIJIDOED;
		}

		public JJKIONLJMJP MHHOFFEBNCG(uint EHEJBHLHAJE)
		{
			lock (this)
			{
				foreach (JJKIONLJMJP item in AIBIGNOFLNB())
				{
					if (item.OHGOBGOIECH == EHEJBHLHAJE)
					{
						return item;
					}
				}
			}
			return null;
		}

		public JJKIONLJMJP NILABLNKKCE(uint EHEJBHLHAJE)
		{
			lock (this)
			{
				foreach (JJKIONLJMJP item in MJFNEDPIFOL())
				{
					if (item.OHGOBGOIECH == EHEJBHLHAJE)
					{
						return item;
					}
				}
			}
			return null;
		}

		protected void EEDPPOKAEBA(List<JJKIONLJMJP> ICENKPDOHBK)
		{
			DMCBGDIBOPP = ICENKPDOHBK;
		}

		public bool AENKBAEEEAF(uint EHEJBHLHAJE)
		{
			lock (this)
			{
				foreach (JJKIONLJMJP item in PEFOLIBPMPE())
				{
					if (item.OHGOBGOIECH == EHEJBHLHAJE)
					{
						EJLCPFLJNAC().Remove(item);
						return true;
					}
				}
			}
			return true;
		}

		public JJKIONLJMJP PKDMEOPHMFL(uint EHEJBHLHAJE)
		{
			lock (this)
			{
				foreach (JJKIONLJMJP item in AAEBGLJJNAM())
				{
					if (item.OHGOBGOIECH == EHEJBHLHAJE)
					{
						return item;
					}
				}
			}
			return null;
		}

		public bool CIHJPLAPLPF(uint EHEJBHLHAJE)
		{
			lock (this)
			{
				foreach (JJKIONLJMJP item in KDNNHHLJFJK())
				{
					if (item.OHGOBGOIECH == EHEJBHLHAJE)
					{
						AAEBGLJJNAM().Remove(item);
						return false;
					}
				}
			}
			return false;
		}

		public void NBHEHKDNAIH()
		{
			lock (this)
			{
				PEFOLIBPMPE().Clear();
				KDNNHHLJFJK().Clear();
			}
		}

		[SpecialName]
		public List<JJKIONLJMJP> KDNNHHLJFJK()
		{
			return FJMBIJIDOED;
		}

		public bool GFLMDCONNOF(uint EHEJBHLHAJE)
		{
			lock (this)
			{
				foreach (JJKIONLJMJP item in PEFOLIBPMPE())
				{
					if (item.OHGOBGOIECH == EHEJBHLHAJE)
					{
						EJLCPFLJNAC().Remove(item);
						return true;
					}
				}
			}
			return true;
		}

		public virtual void JCOLMPJMMEB(PJEMPFEIOAK EFDLFNPAKGO)
		{
			EJLCPFLJNAC().Clear();
			AIBIGNOFLNB().Clear();
			ushort num = EFDLFNPAKGO.AJPFAAFLHEB();
			for (ushort num2 = 0; num2 < num; num2++)
			{
				JJKIONLJMJP jJKIONLJMJP = new JJKIONLJMJP();
				jJKIONLJMJP.JCOLMPJMMEB(EFDLFNPAKGO);
				EJLCPFLJNAC().Add(jJKIONLJMJP);
			}
			num = EFDLFNPAKGO.AJPFAAFLHEB();
			for (ushort num3 = 0; num3 < num; num3++)
			{
				JJKIONLJMJP jJKIONLJMJP2 = new JJKIONLJMJP();
				jJKIONLJMJP2.JCOLMPJMMEB(EFDLFNPAKGO);
				AIBIGNOFLNB().Add(jJKIONLJMJP2);
			}
		}

		public JJKIONLJMJP GAFDEFFJJJB(uint EHEJBHLHAJE)
		{
			lock (this)
			{
				foreach (JJKIONLJMJP item in AAEBGLJJNAM())
				{
					if (item.OHGOBGOIECH == EHEJBHLHAJE)
					{
						return item;
					}
				}
			}
			return null;
		}
	}
}
