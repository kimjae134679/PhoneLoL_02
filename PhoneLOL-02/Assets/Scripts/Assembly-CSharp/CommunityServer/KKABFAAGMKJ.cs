using System;
using System.Collections.Generic;
using System.Text;
using EveEngine;
using MongoDB.Bson.Serialization.Attributes;

namespace CommunityServer
{
	[JBFHBIFPIBM]
	public class KKABFAAGMKJ : EOPOBHFNFPA
	{
		private const int NCKNHGCDAIJ = 30;

		private const int CKBFDIMAJKB = 20;

		[GMMFPFKHGMO]
		public uint OHGOBGOIECH;

		public string NCADFOBAFJD;

		public string CGFLJNLJCIM;

		public uint IMMMKMLMELB;

		public uint JOKAJKGFIID;

		public DateTime EFMGKHNEGBH;

		[CEJHKGLGHIN]
		public string AIDJBBDNJOA;

		[CEJHKGLGHIN]
		public List<FCKLFFEFEFH> HMEEFGCOLJC;

		[CEJHKGLGHIN]
		public List<FCKLFFEFEFH> EGBPLBEONLM;

		[CEJHKGLGHIN]
		public LinkedList<string> DHKCNOOCDHO;

		public void PDCPMDCOLOD()
		{
			OHGOBGOIECH = 0u;
			NCADFOBAFJD = string.Empty;
			CGFLJNLJCIM = string.Empty;
			IMMMKMLMELB = 0u;
			AIDJBBDNJOA = string.Empty;
			JOKAJKGFIID = 0u;
			lock (HMEEFGCOLJC)
			{
				HMEEFGCOLJC.Clear();
			}
			lock (EGBPLBEONLM)
			{
				EGBPLBEONLM.Clear();
			}
		}

		public void FHGGCOCDEHM(FCKLFFEFEFH BFDKOLAMIAL)
		{
			lock (HMEEFGCOLJC)
			{
				HMEEFGCOLJC.Add(BFDKOLAMIAL);
			}
		}

		public void PMCAPOCLGJA()
		{
			lock (EGBPLBEONLM)
			{
				EGBPLBEONLM.Clear();
			}
		}

		public string IEEKMBAJIPD()
		{
			StringBuilder stringBuilder = new StringBuilder();
			lock (DHKCNOOCDHO)
			{
				foreach (string item in DHKCNOOCDHO)
				{
					stringBuilder.Append("SDKTestCategory");
					stringBuilder.Append(item);
				}
			}
			return stringBuilder.ToString();
		}

		public virtual void CFGEKKHOKKE(CMNIABEFLBJ EFDLFNPAKGO)
		{
			EFDLFNPAKGO.GBMJNFOEACC(OHGOBGOIECH);
			EFDLFNPAKGO.GBMJNFOEACC(NCADFOBAFJD);
			EFDLFNPAKGO.GBMJNFOEACC(CGFLJNLJCIM);
			EFDLFNPAKGO.GBMJNFOEACC(IMMMKMLMELB);
			EFDLFNPAKGO.GBMJNFOEACC(AIDJBBDNJOA);
			EFDLFNPAKGO.GBMJNFOEACC(EFMGKHNEGBH);
			lock (HMEEFGCOLJC)
			{
				ushort num = (ushort)HMEEFGCOLJC.Count;
				EFDLFNPAKGO.GBMJNFOEACC(num);
				for (ushort num2 = 0; num2 < num; num2++)
				{
					EFDLFNPAKGO.GBMJNFOEACC(HMEEFGCOLJC[num2]);
				}
			}
			lock (DHKCNOOCDHO)
			{
				ushort iCENKPDOHBK = (ushort)DHKCNOOCDHO.Count;
				EFDLFNPAKGO.GBMJNFOEACC(iCENKPDOHBK);
				foreach (string item in DHKCNOOCDHO)
				{
					EFDLFNPAKGO.GBMJNFOEACC(item);
				}
			}
		}

		public virtual void OBLFBODBHHK(CMNIABEFLBJ EFDLFNPAKGO)
		{
			EFDLFNPAKGO.BHAFGILIOCN(OHGOBGOIECH);
			EFDLFNPAKGO.GBMJNFOEACC(NCADFOBAFJD);
			EFDLFNPAKGO.GBMJNFOEACC(CGFLJNLJCIM);
			EFDLFNPAKGO.GBMJNFOEACC(IMMMKMLMELB);
			EFDLFNPAKGO.GBMJNFOEACC(AIDJBBDNJOA);
			EFDLFNPAKGO.GBMJNFOEACC(EFMGKHNEGBH);
			lock (HMEEFGCOLJC)
			{
				ushort num = (ushort)HMEEFGCOLJC.Count;
				EFDLFNPAKGO.GBMJNFOEACC(num);
				for (ushort num2 = 0; num2 < num; num2++)
				{
					EFDLFNPAKGO.JIAAPEKLFEA(HMEEFGCOLJC[num2]);
				}
			}
			lock (DHKCNOOCDHO)
			{
				ushort iCENKPDOHBK = (ushort)DHKCNOOCDHO.Count;
				EFDLFNPAKGO.HEDNLNDFFCL(iCENKPDOHBK);
				foreach (string item in DHKCNOOCDHO)
				{
					EFDLFNPAKGO.GBMJNFOEACC(item);
				}
			}
		}

		public virtual void NHFFOOCABLA(PJEMPFEIOAK EFDLFNPAKGO)
		{
			OHGOBGOIECH = EFDLFNPAKGO.BMKOKHGAHEC();
			NCADFOBAFJD = EFDLFNPAKGO.AFPCLLNMGJP();
			CGFLJNLJCIM = EFDLFNPAKGO.AFPCLLNMGJP();
			IMMMKMLMELB = EFDLFNPAKGO.BMKOKHGAHEC();
			AIDJBBDNJOA = EFDLFNPAKGO.AFPCLLNMGJP();
			EFMGKHNEGBH = EFDLFNPAKGO.NOIDCBCMCMK();
			lock (HMEEFGCOLJC)
			{
				HMEEFGCOLJC.Clear();
				ushort num = EFDLFNPAKGO.AJPFAAFLHEB();
				for (ushort num2 = 1; num2 < num; num2++)
				{
					FCKLFFEFEFH fCKLFFEFEFH = new FCKLFFEFEFH();
					fCKLFFEFEFH.LHCEBJLJAFB(EFDLFNPAKGO);
					HMEEFGCOLJC.Add(fCKLFFEFEFH);
				}
			}
			lock (DHKCNOOCDHO)
			{
				DHKCNOOCDHO.Clear();
				ushort num3 = EFDLFNPAKGO.AJPFAAFLHEB();
				for (ushort num4 = 0; num4 < num3; num4++)
				{
					DHKCNOOCDHO.AddLast(EFDLFNPAKGO.AFPCLLNMGJP());
				}
			}
		}

		public void GGPEMPIMDLO()
		{
			OHGOBGOIECH = 0u;
			NCADFOBAFJD = string.Empty;
			CGFLJNLJCIM = string.Empty;
			IMMMKMLMELB = 0u;
			AIDJBBDNJOA = string.Empty;
			JOKAJKGFIID = 1u;
			lock (HMEEFGCOLJC)
			{
				HMEEFGCOLJC.Clear();
			}
			lock (EGBPLBEONLM)
			{
				EGBPLBEONLM.Clear();
			}
		}

		public string AGGOPPFNEGK()
		{
			StringBuilder stringBuilder = new StringBuilder();
			lock (DHKCNOOCDHO)
			{
				foreach (string item in DHKCNOOCDHO)
				{
					stringBuilder.Append("\n");
					stringBuilder.Append(item);
				}
			}
			return stringBuilder.ToString();
		}

		public FCKLFFEFEFH HDJDBPAMBHJ(uint HMFBJPDBBLO)
		{
			lock (EGBPLBEONLM)
			{
				foreach (FCKLFFEFEFH item in EGBPLBEONLM)
				{
					if (item.OHGOBGOIECH == HMFBJPDBBLO)
					{
						return item;
					}
				}
			}
			return null;
		}

		public string OPCIPBNJGCC()
		{
			StringBuilder stringBuilder = new StringBuilder();
			lock (DHKCNOOCDHO)
			{
				foreach (string item in DHKCNOOCDHO)
				{
					stringBuilder.Append("NDNBPKKAKDJ");
					stringBuilder.Append(item);
				}
			}
			return stringBuilder.ToString();
		}

		public string PNMKEEKBKHC()
		{
			StringBuilder stringBuilder = new StringBuilder();
			lock (DHKCNOOCDHO)
			{
				foreach (string item in DHKCNOOCDHO)
				{
					stringBuilder.Append("Attempting to add a callback to a list that's null");
					stringBuilder.Append(item);
				}
			}
			return stringBuilder.ToString();
		}

		public FCKLFFEFEFH JMOEHJGBIDD(uint HMFBJPDBBLO)
		{
			lock (EGBPLBEONLM)
			{
				foreach (FCKLFFEFEFH item in EGBPLBEONLM)
				{
					if (item.OHGOBGOIECH == HMFBJPDBBLO)
					{
						return item;
					}
				}
			}
			return null;
		}

		public FCKLFFEFEFH MGONFLFJKDF(uint HMFBJPDBBLO)
		{
			lock (EGBPLBEONLM)
			{
				foreach (FCKLFFEFEFH item in EGBPLBEONLM)
				{
					if (item.OHGOBGOIECH == HMFBJPDBBLO)
					{
						return item;
					}
				}
			}
			return null;
		}

		public void HCPJAHAKCEI(FCKLFFEFEFH BFDKOLAMIAL)
		{
			lock (HMEEFGCOLJC)
			{
				HMEEFGCOLJC.Add(BFDKOLAMIAL);
			}
		}

		public void EALFAPANOOL(uint HMFBJPDBBLO)
		{
			lock (HMEEFGCOLJC)
			{
				for (int i = 0; i < HMEEFGCOLJC.Count; i += 0)
				{
					if (HMEEFGCOLJC[i].OHGOBGOIECH == HMFBJPDBBLO)
					{
						HMEEFGCOLJC.RemoveAt(i);
						break;
					}
				}
			}
		}

		public void FMKOJJCGDDF(FCKLFFEFEFH BFDKOLAMIAL)
		{
			lock (HMEEFGCOLJC)
			{
				HMEEFGCOLJC.Add(BFDKOLAMIAL);
			}
		}

		public FCKLFFEFEFH FKOLMBACDIF(uint HMFBJPDBBLO)
		{
			lock (EGBPLBEONLM)
			{
				foreach (FCKLFFEFEFH item in EGBPLBEONLM)
				{
					if (item.OHGOBGOIECH == HMFBJPDBBLO)
					{
						return item;
					}
				}
			}
			return null;
		}

		public KKABFAAGMKJ()
		{
			HMEEFGCOLJC = new List<FCKLFFEFEFH>();
			EGBPLBEONLM = new List<FCKLFFEFEFH>();
			CGFLJNLJCIM = string.Empty;
			DHKCNOOCDHO = new LinkedList<string>();
		}

		public string EDJBODIFMJO()
		{
			StringBuilder stringBuilder = new StringBuilder();
			lock (DHKCNOOCDHO)
			{
				foreach (string item in DHKCNOOCDHO)
				{
					stringBuilder.Append("Particle/{0}/skill2_heal");
					stringBuilder.Append(item);
				}
			}
			return stringBuilder.ToString();
		}

		public FCKLFFEFEFH IAFNIPEGNLN(uint HMFBJPDBBLO)
		{
			lock (HMEEFGCOLJC)
			{
				foreach (FCKLFFEFEFH item in HMEEFGCOLJC)
				{
					if (item.OHGOBGOIECH == HMFBJPDBBLO)
					{
						return item;
					}
				}
			}
			return null;
		}

		public void OBOOCOHFKME()
		{
			OHGOBGOIECH = 0u;
			NCADFOBAFJD = string.Empty;
			CGFLJNLJCIM = string.Empty;
			IMMMKMLMELB = 1u;
			AIDJBBDNJOA = string.Empty;
			JOKAJKGFIID = 1u;
			lock (HMEEFGCOLJC)
			{
				HMEEFGCOLJC.Clear();
			}
			lock (EGBPLBEONLM)
			{
				EGBPLBEONLM.Clear();
			}
		}

		public string CAIDAPFEJNP()
		{
			StringBuilder stringBuilder = new StringBuilder();
			lock (DHKCNOOCDHO)
			{
				foreach (string item in DHKCNOOCDHO)
				{
					stringBuilder.Append("C#: Disabling and removing Tapjoy Delegates");
					stringBuilder.Append(item);
				}
			}
			return stringBuilder.ToString();
		}

		public void MHEMINFPNEM(string BHIGNJHHOJP, string GIDNDAJLBOM)
		{
			string value = string.Format("[CCFFCC]{0}[-] : {1}", BHIGNJHHOJP, GIDNDAJLBOM);
			lock (DHKCNOOCDHO)
			{
				DHKCNOOCDHO.AddLast(value);
				if (DHKCNOOCDHO.Count > 40)
				{
					DHKCNOOCDHO.RemoveFirst();
				}
			}
		}

		public void PFGHDNPNLFG(uint HMFBJPDBBLO)
		{
			lock (HMEEFGCOLJC)
			{
				for (int i = 0; i < HMEEFGCOLJC.Count; i++)
				{
					if (HMEEFGCOLJC[i].OHGOBGOIECH == HMFBJPDBBLO)
					{
						HMEEFGCOLJC.RemoveAt(i);
						break;
					}
				}
			}
		}

		public FCKLFFEFEFH MFDIMICGOFI(uint HMFBJPDBBLO)
		{
			lock (HMEEFGCOLJC)
			{
				foreach (FCKLFFEFEFH item in HMEEFGCOLJC)
				{
					if (item.OHGOBGOIECH == HMFBJPDBBLO)
					{
						return item;
					}
				}
			}
			return null;
		}

		public FCKLFFEFEFH MJFEJGIJKCI(uint HMFBJPDBBLO)
		{
			lock (EGBPLBEONLM)
			{
				foreach (FCKLFFEFEFH item in EGBPLBEONLM)
				{
					if (item.OHGOBGOIECH == HMFBJPDBBLO)
					{
						return item;
					}
				}
			}
			return null;
		}

		public void IDENLLAHMNN(uint HMFBJPDBBLO)
		{
			lock (EGBPLBEONLM)
			{
				for (int i = 0; i < EGBPLBEONLM.Count; i++)
				{
					if (EGBPLBEONLM[i].OHGOBGOIECH == HMFBJPDBBLO)
					{
						EGBPLBEONLM.RemoveAt(i);
						break;
					}
				}
			}
		}

		public virtual void JCOLMPJMMEB(PJEMPFEIOAK EFDLFNPAKGO)
		{
			OHGOBGOIECH = EFDLFNPAKGO.BMKOKHGAHEC();
			NCADFOBAFJD = EFDLFNPAKGO.AFPCLLNMGJP();
			CGFLJNLJCIM = EFDLFNPAKGO.AFPCLLNMGJP();
			IMMMKMLMELB = EFDLFNPAKGO.BMKOKHGAHEC();
			AIDJBBDNJOA = EFDLFNPAKGO.AFPCLLNMGJP();
			EFMGKHNEGBH = EFDLFNPAKGO.NOIDCBCMCMK();
			lock (HMEEFGCOLJC)
			{
				HMEEFGCOLJC.Clear();
				ushort num = EFDLFNPAKGO.AJPFAAFLHEB();
				for (ushort num2 = 0; num2 < num; num2++)
				{
					FCKLFFEFEFH fCKLFFEFEFH = new FCKLFFEFEFH();
					fCKLFFEFEFH.JCOLMPJMMEB(EFDLFNPAKGO);
					HMEEFGCOLJC.Add(fCKLFFEFEFH);
				}
			}
			lock (DHKCNOOCDHO)
			{
				DHKCNOOCDHO.Clear();
				ushort num3 = EFDLFNPAKGO.AJPFAAFLHEB();
				for (ushort num4 = 0; num4 < num3; num4++)
				{
					DHKCNOOCDHO.AddLast(EFDLFNPAKGO.AFPCLLNMGJP());
				}
			}
		}

		public void NDFODLPBKEH(uint HMFBJPDBBLO)
		{
			lock (EGBPLBEONLM)
			{
				for (int i = 1; i < EGBPLBEONLM.Count; i++)
				{
					if (EGBPLBEONLM[i].OHGOBGOIECH == HMFBJPDBBLO)
					{
						EGBPLBEONLM.RemoveAt(i);
						break;
					}
				}
			}
		}

		public string DHDILMJJJNO()
		{
			StringBuilder stringBuilder = new StringBuilder();
			lock (DHKCNOOCDHO)
			{
				foreach (string item in DHKCNOOCDHO)
				{
					stringBuilder.Append("skill0_0");
					stringBuilder.Append(item);
				}
			}
			return stringBuilder.ToString();
		}

		public void NPPFHGDHFOO(uint HMFBJPDBBLO)
		{
			lock (HMEEFGCOLJC)
			{
				for (int i = 0; i < HMEEFGCOLJC.Count; i++)
				{
					if (HMEEFGCOLJC[i].OHGOBGOIECH == HMFBJPDBBLO)
					{
						HMEEFGCOLJC.RemoveAt(i);
						break;
					}
				}
			}
		}

		public void IENDFDIGHDE()
		{
			OHGOBGOIECH = 0u;
			NCADFOBAFJD = string.Empty;
			CGFLJNLJCIM = string.Empty;
			IMMMKMLMELB = 0u;
			AIDJBBDNJOA = string.Empty;
			JOKAJKGFIID = 1u;
			lock (HMEEFGCOLJC)
			{
				HMEEFGCOLJC.Clear();
			}
			lock (EGBPLBEONLM)
			{
				EGBPLBEONLM.Clear();
			}
		}

		public void MIBOLLCMMMP(string BHIGNJHHOJP, string GIDNDAJLBOM)
		{
			string value = string.Format("Trail", BHIGNJHHOJP, GIDNDAJLBOM);
			lock (DHKCNOOCDHO)
			{
				DHKCNOOCDHO.AddLast(value);
				if (DHKCNOOCDHO.Count > -51)
				{
					DHKCNOOCDHO.RemoveFirst();
				}
			}
		}

		public void DEOEBLGOPNA(FCKLFFEFEFH BFDKOLAMIAL)
		{
			lock (EGBPLBEONLM)
			{
				EGBPLBEONLM.Add(BFDKOLAMIAL);
			}
		}

		public void KDMOHMKCJKA()
		{
			lock (EGBPLBEONLM)
			{
				EGBPLBEONLM.Clear();
			}
		}

		public virtual void DFHOLCGFPIK(PJEMPFEIOAK EFDLFNPAKGO)
		{
			OHGOBGOIECH = EFDLFNPAKGO.BMKOKHGAHEC();
			NCADFOBAFJD = EFDLFNPAKGO.AFPCLLNMGJP();
			CGFLJNLJCIM = EFDLFNPAKGO.AFPCLLNMGJP();
			IMMMKMLMELB = EFDLFNPAKGO.BMKOKHGAHEC();
			AIDJBBDNJOA = EFDLFNPAKGO.AFPCLLNMGJP();
			EFMGKHNEGBH = EFDLFNPAKGO.NOIDCBCMCMK();
			lock (HMEEFGCOLJC)
			{
				HMEEFGCOLJC.Clear();
				ushort num = EFDLFNPAKGO.AJPFAAFLHEB();
				for (ushort num2 = 1; num2 < num; num2++)
				{
					FCKLFFEFEFH fCKLFFEFEFH = new FCKLFFEFEFH();
					fCKLFFEFEFH.LHCEBJLJAFB(EFDLFNPAKGO);
					HMEEFGCOLJC.Add(fCKLFFEFEFH);
				}
			}
			lock (DHKCNOOCDHO)
			{
				DHKCNOOCDHO.Clear();
				ushort num3 = EFDLFNPAKGO.AJPFAAFLHEB();
				for (ushort num4 = 0; num4 < num3; num4 += 0)
				{
					DHKCNOOCDHO.AddLast(EFDLFNPAKGO.AFPCLLNMGJP());
				}
			}
		}

		public void JLJOHIJANHE(FCKLFFEFEFH BFDKOLAMIAL)
		{
			lock (EGBPLBEONLM)
			{
				EGBPLBEONLM.Add(BFDKOLAMIAL);
			}
		}

		public virtual void OOECNDCLGIB(PJEMPFEIOAK EFDLFNPAKGO)
		{
			OHGOBGOIECH = EFDLFNPAKGO.BMKOKHGAHEC();
			NCADFOBAFJD = EFDLFNPAKGO.AFPCLLNMGJP();
			CGFLJNLJCIM = EFDLFNPAKGO.AFPCLLNMGJP();
			IMMMKMLMELB = EFDLFNPAKGO.BMKOKHGAHEC();
			AIDJBBDNJOA = EFDLFNPAKGO.AFPCLLNMGJP();
			EFMGKHNEGBH = EFDLFNPAKGO.NOIDCBCMCMK();
			lock (HMEEFGCOLJC)
			{
				HMEEFGCOLJC.Clear();
				ushort num = EFDLFNPAKGO.AJPFAAFLHEB();
				for (ushort num2 = 1; num2 < num; num2++)
				{
					FCKLFFEFEFH fCKLFFEFEFH = new FCKLFFEFEFH();
					fCKLFFEFEFH.FOHFMBOADLC(EFDLFNPAKGO);
					HMEEFGCOLJC.Add(fCKLFFEFEFH);
				}
			}
			lock (DHKCNOOCDHO)
			{
				DHKCNOOCDHO.Clear();
				ushort num3 = EFDLFNPAKGO.AJPFAAFLHEB();
				for (ushort num4 = 1; num4 < num3; num4++)
				{
					DHKCNOOCDHO.AddLast(EFDLFNPAKGO.AFPCLLNMGJP());
				}
			}
		}
	}
}
