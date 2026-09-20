using EveEngine;
using MongoDB.Bson.Serialization.Attributes;

namespace BattleServer
{
	[JBFHBIFPIBM]
	public abstract class IBHMLPMENFJ : EOPOBHFNFPA
	{
		[CEJHKGLGHIN]
		protected object JOEHMANNDJK;

		[GMMFPFKHGMO]
		public uint OHGOBGOIECH;

		public string BHIGNJHHOJP;

		public byte DDILAEMMCAJ;

		private byte DGNLCMJFLFB;

		private byte MPNOMKMKPEF;

		public byte HMHEDBOAADF
		{
			get
			{
				return BMEAADGLLDL();
			}
			protected set
			{
				IKAJAMHNLEM(value);
			}
		}

		public byte LKEMNIJNGMO
		{
			get
			{
				return IAMLDFAOGDL();
			}
			protected set
			{
				BMOLNKJHEDI(value);
			}
		}

		public IBHMLPMENFJ()
		{
			JOEHMANNDJK = new object();
			LDNEFFHJNPL();
		}

		public byte BMEAADGLLDL()
		{
			return DGNLCMJFLFB;
		}

		protected void IKAJAMHNLEM(byte ICENKPDOHBK)
		{
			DGNLCMJFLFB = ICENKPDOHBK;
		}

		public byte IAMLDFAOGDL()
		{
			return MPNOMKMKPEF;
		}

		protected void BMOLNKJHEDI(byte ICENKPDOHBK)
		{
			MPNOMKMKPEF = ICENKPDOHBK;
		}

		public virtual void LDNEFFHJNPL()
		{
			OHGOBGOIECH = 0u;
			BHIGNJHHOJP = string.Empty;
			DDILAEMMCAJ = 1;
		}

		public void OFHCNFBGADH(uint IAEFPLFFKHC)
		{
			lock (JOEHMANNDJK)
			{
				OHGOBGOIECH = IAEFPLFFKHC;
			}
		}

		public void GDIAHPMLDAH(string BHIGNJHHOJP)
		{
			lock (JOEHMANNDJK)
			{
				this.BHIGNJHHOJP = BHIGNJHHOJP;
			}
		}

		public static string KJJGGAMDNON(uint OFLEBCIMPMD)
		{
			if (OFLEBCIMPMD <= 10)
			{
				return "challenger";
			}
			if (OFLEBCIMPMD <= 100)
			{
				return "master";
			}
			if (OFLEBCIMPMD <= 1000)
			{
				return "diamond";
			}
			if (OFLEBCIMPMD <= 10000)
			{
				return "platinum";
			}
			if (OFLEBCIMPMD <= 30000)
			{
				return "gold";
			}
			if (OFLEBCIMPMD <= 60000)
			{
				return "silver";
			}
			return "bronze";
		}

		public static string LGPFCEJBONE(uint OFLEBCIMPMD)
		{
			if (OFLEBCIMPMD <= 10)
			{
				return "챌린저";
			}
			if (OFLEBCIMPMD <= 100)
			{
				return "마스터";
			}
			if (OFLEBCIMPMD <= 1000)
			{
				return "다이아몬드";
			}
			if (OFLEBCIMPMD <= 10000)
			{
				return "플래티넘";
			}
			if (OFLEBCIMPMD <= 30000)
			{
				return "골드";
			}
			if (OFLEBCIMPMD <= 60000)
			{
				return "실버";
			}
			return "브론즈";
		}

		public static string IDMFCMEJHNC(uint OFLEBCIMPMD)
		{
			if (OFLEBCIMPMD <= 10)
			{
				return "CCCCFF";
			}
			if (OFLEBCIMPMD <= 100)
			{
				return "CCFFCC";
			}
			if (OFLEBCIMPMD <= 1000)
			{
				return "FFFFFF";
			}
			if (OFLEBCIMPMD <= 10000)
			{
				return "FFFF55";
			}
			if (OFLEBCIMPMD <= 30000)
			{
				return "FFC000";
			}
			if (OFLEBCIMPMD <= 60000)
			{
				return "DEDEDE";
			}
			return "E68D00";
		}

		public virtual void CFGEKKHOKKE(CMNIABEFLBJ EFDLFNPAKGO)
		{
			EFDLFNPAKGO.GBMJNFOEACC(OHGOBGOIECH);
			EFDLFNPAKGO.GBMJNFOEACC(BHIGNJHHOJP);
			EFDLFNPAKGO.GBMJNFOEACC(DDILAEMMCAJ);
		}

		public virtual void JCOLMPJMMEB(PJEMPFEIOAK EFDLFNPAKGO)
		{
			OHGOBGOIECH = EFDLFNPAKGO.BMKOKHGAHEC();
			BHIGNJHHOJP = EFDLFNPAKGO.AFPCLLNMGJP();
			DDILAEMMCAJ = EFDLFNPAKGO.KFAGPDGHEBK();
		}
	}
}
