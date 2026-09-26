using System;
using EveEngine;
using MongoDB.Bson.Serialization.Attributes;

namespace GameServer
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

		public byte HMHEDBOAADF;

		public byte LKEMNIJNGMO;

		public DateTime PFNFFDCCNBB;

		public byte CMIBEFBANOO;

		public IBHMLPMENFJ()
		{
			JOEHMANNDJK = new object();
			BHIGNJHHOJP = string.Empty;
			DDILAEMMCAJ = 1;
			PFNFFDCCNBB = DateTime.MinValue;
		}

		public virtual void LDNEFFHJNPL()
		{
			OHGOBGOIECH = 0u;
			BHIGNJHHOJP = string.Empty;
			DDILAEMMCAJ = 1;
			CMIBEFBANOO = 0;
		}

		public void OFHCNFBGADH(uint OHGOBGOIECH)
		{
			lock (JOEHMANNDJK)
			{
				this.OHGOBGOIECH = OHGOBGOIECH;
			}
		}

		public void GDIAHPMLDAH(string BHIGNJHHOJP)
		{
			lock (JOEHMANNDJK)
			{
				this.BHIGNJHHOJP = BHIGNJHHOJP;
			}
		}

		public static string KJJGGAMDNON(byte HMHEDBOAADF)
		{
			switch (HMHEDBOAADF)
			{
			case 7:
				return "challenger";
			case 6:
				return "master";
			case 5:
				return "diamond";
			case 4:
				return "platinum";
			case 3:
				return "gold";
			case 2:
				return "silver";
			case 1:
				return "bronze";
			default:
				return "unrank";
			}
		}

		public static string LGPFCEJBONE(byte HMHEDBOAADF)
		{
			switch (HMHEDBOAADF)
			{
			case 7:
				return "챌린저";
			case 6:
				return "마스터";
			case 5:
				return "다이아몬드";
			case 4:
				return "플래티넘";
			case 3:
				return "골드";
			case 2:
				return "실버";
			case 1:
				return "브론즈";
			default:
				return "티어 없음";
			}
		}

		public static string IDMFCMEJHNC(byte HMHEDBOAADF)
		{
			switch (HMHEDBOAADF)
			{
			case 7:
				return "CCCCFF";
			case 6:
				return "CCFFCC";
			case 5:
				return "FFFFFF";
			case 4:
				return "FFFF55";
			case 3:
				return "FFC000";
			case 2:
				return "DEDEDE";
			case 1:
				return "E68D00";
			default:
				return "E68D00";
			}
		}

		public virtual void CFGEKKHOKKE(CMNIABEFLBJ EFDLFNPAKGO)
		{
			EFDLFNPAKGO.GBMJNFOEACC(OHGOBGOIECH);
			EFDLFNPAKGO.GBMJNFOEACC(BHIGNJHHOJP);
			EFDLFNPAKGO.GBMJNFOEACC(DDILAEMMCAJ);
			EFDLFNPAKGO.GBMJNFOEACC(HMHEDBOAADF);
			EFDLFNPAKGO.GBMJNFOEACC(LKEMNIJNGMO);
			EFDLFNPAKGO.GBMJNFOEACC(CMIBEFBANOO);
		}

		public virtual void JCOLMPJMMEB(PJEMPFEIOAK EFDLFNPAKGO)
		{
			OHGOBGOIECH = EFDLFNPAKGO.BMKOKHGAHEC();
			BHIGNJHHOJP = EFDLFNPAKGO.AFPCLLNMGJP();
			DDILAEMMCAJ = EFDLFNPAKGO.KFAGPDGHEBK();
			HMHEDBOAADF = EFDLFNPAKGO.KFAGPDGHEBK();
			LKEMNIJNGMO = EFDLFNPAKGO.KFAGPDGHEBK();
			CMIBEFBANOO = EFDLFNPAKGO.KFAGPDGHEBK();
		}
	}
}
