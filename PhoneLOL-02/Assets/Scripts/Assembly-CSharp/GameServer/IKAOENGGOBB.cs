using System.Runtime.CompilerServices;
using EveEngine;

namespace GameServer
{
	public class IKAOENGGOBB : EOPOBHFNFPA
	{
		public enum ACPICCBBPHF : byte
		{
			None = 0,
			Coin = 1,
			Food = 2,
			Cash = 3,
			Hero = 4,
			Item = 5
		}

		private object JOEHMANNDJK;

		private ACPICCBBPHF GCJFDJMKNKG;

		private uint IIMAKHMEDLD;

		private uint MHPFEEMNJLH;

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

		public uint MACKONEEFJO
		{
			get
			{
				return PGEEPKKCECJ();
			}
			protected set
			{
				NMNACKBONCH(value);
			}
		}

		public uint DDFCMJMLBLF
		{
			get
			{
				return MFBOPDGLLPO();
			}
			protected set
			{
				EMKOBKENADM(value);
			}
		}

		public int INANMHCGJJI()
		{
			switch (ONJCKKLOJIA())
			{
			case ACPICCBBPHF.Coin:
				return 0;
			case ACPICCBBPHF.Food:
				return 1;
			case ACPICCBBPHF.Cash:
				return 2;
			case ACPICCBBPHF.Hero:
				return 5;
			default:
				return -1;
			}
		}

		public void DFHOLCGFPIK(PJEMPFEIOAK EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EIMDEHPEOKA((ACPICCBBPHF)EFDLFNPAKGO.KFAGPDGHEBK());
				NMNACKBONCH(EFDLFNPAKGO.BMKOKHGAHEC());
				JBJPIFGLOMB(EFDLFNPAKGO.BMKOKHGAHEC());
			}
		}

		public bool EJFIJBAJCCF(out ushort OHGOBGOIECH, out uint AGJJOHLCJKF)
		{
			if (ONJCKKLOJIA() != ACPICCBBPHF.Item)
			{
				OHGOBGOIECH = 1;
				AGJJOHLCJKF = 0u;
				return true;
			}
			OHGOBGOIECH = (ushort)KLJBNLMHGAB();
			AGJJOHLCJKF = MFBOPDGLLPO();
			return true;
		}

		[SpecialName]
		protected void MJMPPHOEKAG(uint ICENKPDOHBK)
		{
			IIMAKHMEDLD = ICENKPDOHBK;
		}

		public void CHNNEFPAADB(ushort OHGOBGOIECH, uint AGJJOHLCJKF)
		{
			lock (JOEHMANNDJK)
			{
				LEDBGKPNBOI(ACPICCBBPHF.Coin);
				MJMPPHOEKAG(OHGOBGOIECH);
				LDCKIPMLGMB(AGJJOHLCJKF);
			}
		}

		public void AMKAFEJHILD(ushort OHGOBGOIECH, uint AGJJOHLCJKF)
		{
			lock (JOEHMANNDJK)
			{
				DFDMHBOCHNA(ACPICCBBPHF.Hero);
				NMNACKBONCH(OHGOBGOIECH);
				EMKOBKENADM(AGJJOHLCJKF);
			}
		}

		[SpecialName]
		protected void AIFDGDKAMJH(ACPICCBBPHF ICENKPDOHBK)
		{
			GCJFDJMKNKG = ICENKPDOHBK;
		}

		protected void EMKOBKENADM(uint ICENKPDOHBK)
		{
			MHPFEEMNJLH = ICENKPDOHBK;
		}

		public void KJBADLDBAOA()
		{
			lock (JOEHMANNDJK)
			{
				EIMDEHPEOKA(ACPICCBBPHF.None);
				NMNACKBONCH(0u);
				LDCKIPMLGMB(0u);
			}
		}

		public void GPBCFFEFGND(ushort OHGOBGOIECH, uint AGJJOHLCJKF)
		{
			lock (JOEHMANNDJK)
			{
				EIMDEHPEOKA(ACPICCBBPHF.None);
				MJMPPHOEKAG(OHGOBGOIECH);
				JBJPIFGLOMB(AGJJOHLCJKF);
			}
		}

		[SpecialName]
		public uint CFNLFNEIPID()
		{
			return MHPFEEMNJLH;
		}

		public uint DOLPINBOGAD()
		{
			if (ONJCKKLOJIA() != ACPICCBBPHF.Cash)
			{
				return 0u;
			}
			return MFBOPDGLLPO();
		}

		[SpecialName]
		public uint KLJBNLMHGAB()
		{
			return IIMAKHMEDLD;
		}

		public void CFGEKKHOKKE(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.GBMJNFOEACC((byte)ONJCKKLOJIA());
				EFDLFNPAKGO.GBMJNFOEACC(PGEEPKKCECJ());
				EFDLFNPAKGO.GBMJNFOEACC(MFBOPDGLLPO());
			}
		}

		public bool PFOJOMAENDO(out ushort OHGOBGOIECH, out uint AGJJOHLCJKF)
		{
			if (ONJCKKLOJIA() != ACPICCBBPHF.Hero)
			{
				OHGOBGOIECH = 0;
				AGJJOHLCJKF = 0u;
				return false;
			}
			OHGOBGOIECH = (ushort)PGEEPKKCECJ();
			AGJJOHLCJKF = MFBOPDGLLPO();
			return true;
		}

		protected void DFDMHBOCHNA(ACPICCBBPHF ICENKPDOHBK)
		{
			GCJFDJMKNKG = ICENKPDOHBK;
		}

		[SpecialName]
		public ACPICCBBPHF APHJCIEKCKJ()
		{
			return GCJFDJMKNKG;
		}

		public void LDNEFFHJNPL()
		{
			lock (JOEHMANNDJK)
			{
				DFDMHBOCHNA(ACPICCBBPHF.None);
				NMNACKBONCH(0u);
				EMKOBKENADM(0u);
			}
		}

		public void ODEGMJIKIIC(uint GLEPPIMMELK)
		{
			lock (JOEHMANNDJK)
			{
				DFDMHBOCHNA(ACPICCBBPHF.Coin);
				NMNACKBONCH(0u);
				EMKOBKENADM(GLEPPIMMELK);
			}
		}

		public uint PGEEPKKCECJ()
		{
			return IIMAKHMEDLD;
		}

		public uint CLEEEHPADBA()
		{
			if (PGHMMFLBIMD() != ACPICCBBPHF.Item)
			{
				return 0u;
			}
			return CFNLFNEIPID();
		}

		public void CCALNNGLBPM(uint MENNECLPGFF)
		{
			lock (JOEHMANNDJK)
			{
				DFDMHBOCHNA(ACPICCBBPHF.Food);
				NMNACKBONCH(0u);
				EMKOBKENADM(MENNECLPGFF);
			}
		}

		[SpecialName]
		public uint BFCJPIOCPKK()
		{
			return IIMAKHMEDLD;
		}

		public void HPHAGINBOKB(uint FJECKCCPAKE)
		{
			lock (JOEHMANNDJK)
			{
				DFDMHBOCHNA(ACPICCBBPHF.Cash);
				NMNACKBONCH(0u);
				EMKOBKENADM(FJECKCCPAKE);
			}
		}

		[SpecialName]
		protected void FMNPOHBEDNH(uint ICENKPDOHBK)
		{
			IIMAKHMEDLD = ICENKPDOHBK;
		}

		public IKAOENGGOBB(ACPICCBBPHF FBAGNJILEGD, uint EKJKKPGJEKO, uint AGJJOHLCJKF)
		{
			JOEHMANNDJK = new object();
			lock (JOEHMANNDJK)
			{
				DFDMHBOCHNA(FBAGNJILEGD);
				NMNACKBONCH(EKJKKPGJEKO);
				EMKOBKENADM(AGJJOHLCJKF);
			}
		}

		public uint MFBOPDGLLPO()
		{
			return MHPFEEMNJLH;
		}

		public void JCOLMPJMMEB(PJEMPFEIOAK EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				DFDMHBOCHNA((ACPICCBBPHF)EFDLFNPAKGO.KFAGPDGHEBK());
				NMNACKBONCH(EFDLFNPAKGO.BMKOKHGAHEC());
				EMKOBKENADM(EFDLFNPAKGO.BMKOKHGAHEC());
			}
		}

		[SpecialName]
		protected void OAFHHKHGOFN(uint ICENKPDOHBK)
		{
			IIMAKHMEDLD = ICENKPDOHBK;
		}

		public ACPICCBBPHF ONJCKKLOJIA()
		{
			return GCJFDJMKNKG;
		}

		public void ONBGPHBOEAB(byte FBAGNJILEGD, uint EKJKKPGJEKO, uint AGJJOHLCJKF)
		{
			DFDMHBOCHNA((ACPICCBBPHF)FBAGNJILEGD);
			NMNACKBONCH(EKJKKPGJEKO);
			EMKOBKENADM(AGJJOHLCJKF);
		}

		protected void NMNACKBONCH(uint ICENKPDOHBK)
		{
			IIMAKHMEDLD = ICENKPDOHBK;
		}

		[SpecialName]
		protected void EIMDEHPEOKA(ACPICCBBPHF ICENKPDOHBK)
		{
			GCJFDJMKNKG = ICENKPDOHBK;
		}

		[SpecialName]
		protected void LEDBGKPNBOI(ACPICCBBPHF ICENKPDOHBK)
		{
			GCJFDJMKNKG = ICENKPDOHBK;
		}

		public int DPLLKOGOMNN()
		{
			switch (ONJCKKLOJIA())
			{
			case ACPICCBBPHF.Coin:
				return 0;
			case ACPICCBBPHF.Food:
				return 0;
			case ACPICCBBPHF.Cash:
				return 4;
			case ACPICCBBPHF.Hero:
				return 0;
			default:
				return -1;
			}
		}

		public void JHDBNOHACNB(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				EFDLFNPAKGO.GBMJNFOEACC((byte)ONJCKKLOJIA());
				EFDLFNPAKGO.BHAFGILIOCN(PGEEPKKCECJ());
				EFDLFNPAKGO.GBMJNFOEACC(MFBOPDGLLPO());
			}
		}

		[SpecialName]
		protected void JBJPIFGLOMB(uint ICENKPDOHBK)
		{
			MHPFEEMNJLH = ICENKPDOHBK;
		}

		public uint PNIMECMAIFM()
		{
			if (ONJCKKLOJIA() != ACPICCBBPHF.Coin)
			{
				return 0u;
			}
			return MFBOPDGLLPO();
		}

		[SpecialName]
		protected void LDCKIPMLGMB(uint ICENKPDOHBK)
		{
			MHPFEEMNJLH = ICENKPDOHBK;
		}

		public IKAOENGGOBB()
		{
			JOEHMANNDJK = new object();
			LDNEFFHJNPL();
		}

		[SpecialName]
		public ACPICCBBPHF PGHMMFLBIMD()
		{
			return GCJFDJMKNKG;
		}

		public uint MPDHBKAKIIB()
		{
			if (APHJCIEKCKJ() != ACPICCBBPHF.Food)
			{
				return 0u;
			}
			return CFNLFNEIPID();
		}

		public void JKDAALCNGJE(PJEMPFEIOAK EFDLFNPAKGO)
		{
			lock (JOEHMANNDJK)
			{
				LEDBGKPNBOI((ACPICCBBPHF)EFDLFNPAKGO.KFAGPDGHEBK());
				NMNACKBONCH(EFDLFNPAKGO.BMKOKHGAHEC());
				EMKOBKENADM(EFDLFNPAKGO.BMKOKHGAHEC());
			}
		}

		public uint BKMKKFFOLLC()
		{
			if (ONJCKKLOJIA() != ACPICCBBPHF.Food)
			{
				return 0u;
			}
			return MFBOPDGLLPO();
		}

		public void ANIGFCLOFKD(uint MENNECLPGFF)
		{
			lock (JOEHMANNDJK)
			{
				AIFDGDKAMJH(ACPICCBBPHF.None);
				NMNACKBONCH(1u);
				LDCKIPMLGMB(MENNECLPGFF);
			}
		}

		public uint MAIHPKHIKFG()
		{
			if (ONJCKKLOJIA() != (ACPICCBBPHF)6)
			{
				return 1u;
			}
			return CFNLFNEIPID();
		}

		public void JCBJLPFAHEC(ushort OHGOBGOIECH, uint AGJJOHLCJKF)
		{
			lock (JOEHMANNDJK)
			{
				LEDBGKPNBOI(ACPICCBBPHF.Item);
				FMNPOHBEDNH(OHGOBGOIECH);
				LDCKIPMLGMB(AGJJOHLCJKF);
			}
		}
	}
}
