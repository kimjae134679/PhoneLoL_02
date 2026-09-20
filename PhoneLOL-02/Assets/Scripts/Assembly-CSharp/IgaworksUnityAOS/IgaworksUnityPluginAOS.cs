using System;
using System.Collections.Generic;
using UnityEngine;

namespace IgaworksUnityAOS
{
	public class IgaworksUnityPluginAOS : MonoBehaviour
	{
		public class HIPJIBAEEDD
		{
			public static int OLKIMLJOCKH = 1;

			public static int IAGCADMMINB = 2;
		}

		public class EEOFDENODPE
		{
			public static string CAOKACJEFIG = "ff9d261c";

			public static string HPODHCPGKDE = "ff3d7caf";

			public static string PDLIAFIPCOB = "ffffba03";
		}

		public enum HOFDLCIPHKN
		{
			COHORT_1 = 0,
			COHORT_2 = 1,
			COHORT_3 = 2
		}

		public class EGOGGICIHDL
		{
			public static int LIMLMIFDBJM;

			public static int AJONLNBCPGJ = 1;

			public static int GMJJBOEBJMK = -1;

			public static int GHFKDECECNN = 2;

			public static int GNPPMMDBHNB = -2;
		}

		public class HLLIOPGOCNJ
		{
			public static int IDPCCOLDLKF;

			public static int GIGKINKJAFG = 1;

			public static int PKAAHHBHLFN = -1;
		}

		public class PGLAJHLKPIL
		{
			public static int MFLACNIFFGB;

			public static int MKEKNIEAGHA = 1;

			public static int BPDNMLECMJN = 2;

			public static int PMFJFBDKBNM = 4;

			public static int DBPBBJCDIFD = 8;
		}

		public static class LKLLDNCMKBH
		{
			public static void CDIJJEHNBNL()
			{
				DBEKIAMKGKA.CallStatic("startApplication");
				Debug.Log("IGAWorksAdbrixUnityPlugin Call StartApplication!!!");
			}

			public static void CDIJJEHNBNL(string MOEMCKHMNPG)
			{
				DBEKIAMKGKA.CallStatic("startApplication", MOEMCKHMNPG);
				Debug.Log("IGAWorksAdbrixUnityPlugin Call StartApplication with puid!!!");
			}

			public static void PFNPEDFANJE()
			{
				DBEKIAMKGKA.CallStatic("setDeferredLinkListener");
			}

			public static void MGMCMMOGCFN(string FHMPJMLPNIC)
			{
				DBEKIAMKGKA.CallStatic("setReferralUrl", FHMPJMLPNIC);
				Debug.Log("Igaworks Unity >> setReferralUrl: " + FHMPJMLPNIC);
			}

			public static void HFEABOAPLBA(string FHMPJMLPNIC)
			{
				DBEKIAMKGKA.CallStatic("setReferralUrl", FHMPJMLPNIC);
				Debug.Log("Igaworks Unity >> setReferralUrl: " + FHMPJMLPNIC);
			}

			public static void ADBMLKJEHAO()
			{
				DBEKIAMKGKA.CallStatic("startSession");
			}

			public static void GEGCIIKDGGO()
			{
				DBEKIAMKGKA.CallStatic("endSession");
			}

			public static void FOINHDAAIKE(string ANCDOGMDMKC)
			{
				DBEKIAMKGKA.CallStatic("setUserId", ANCDOGMDMKC);
			}
		}

		public static class DAFCIJBIOAJ
		{
			[Serializable]
			public class PurchaseItemModel
			{
				public string orderId = "unknown";

				public string productId = "unknown";

				public string productName = "unknown";

				public double price;

				public int quantity = 1;

				public string currency = "unknown";

				public string category = "unknown";

				public PurchaseItemModel(string FFHILJLPMBP, string JADEHNCMJBA, string BBCMMAELHCJ, double DHNOPCIJDBO, int LGHCJBAADHO, string JFHLDPNPDGA, string EKPDAIADJMM)
				{
					if (FFHILJLPMBP != null && FFHILJLPMBP.Length > 0)
					{
						orderId = FFHILJLPMBP;
					}
					if (JADEHNCMJBA != null && JADEHNCMJBA.Length > 0)
					{
						productId = JADEHNCMJBA;
					}
					if (BBCMMAELHCJ != null && BBCMMAELHCJ.Length > 0)
					{
						productName = BBCMMAELHCJ;
					}
					price = DHNOPCIJDBO;
					quantity = LGHCJBAADHO;
					if (JFHLDPNPDGA != null && JFHLDPNPDGA.Length > 0)
					{
						currency = JFHLDPNPDGA;
					}
					if (EKPDAIADJMM != null && EKPDAIADJMM.Length > 0)
					{
						category = EKPDAIADJMM;
					}
				}
			}

			public class LAHONAPNKHO
			{
				public string DJICKIMOKIJ = string.Empty;

				public string BBCMMAELHCJ = string.Empty;

				public double DHNOPCIJDBO;

				public double ACPDGIKFBIH;

				public int LGHCJBAADHO = 1;

				public string JFHLDPNPDGA = "unknown";

				public string EKPDAIADJMM;

				public Dictionary<string, string> MJGFAHFBJOI;

				public double BLEMLAMIIOA()
				{
					return DHNOPCIJDBO;
				}

				public LAHONAPNKHO AGDKFOFLEGD(string BBCMMAELHCJ)
				{
					this.BBCMMAELHCJ = BBCMMAELHCJ;
					return this;
				}

				public string GBCFMHNGEHL()
				{
					return DJICKIMOKIJ;
				}

				public string PCFFPCFECMB()
				{
					return BBCMMAELHCJ;
				}

				public LAHONAPNKHO GGJDGEOLNGE(double ACPDGIKFBIH)
				{
					this.ACPDGIKFBIH = ACPDGIKFBIH;
					return this;
				}

				public double OAKBGGCGBKF()
				{
					return ACPDGIKFBIH;
				}

				public LAHONAPNKHO GAMIKFAHEIN(string DJICKIMOKIJ)
				{
					this.DJICKIMOKIJ = DJICKIMOKIJ;
					return this;
				}

				public LAHONAPNKHO(string DJICKIMOKIJ, string BBCMMAELHCJ, double DHNOPCIJDBO, double ACPDGIKFBIH, int LGHCJBAADHO, string JFHLDPNPDGA, ONEJDIJCKJJ EKPDAIADJMM, OEHCGLEKDML OGLGGHCNNPM)
				{
					MJGFAHFBJOI = null;
					MJGFAHFBJOI = new Dictionary<string, string>();
					if (OGLGGHCNNPM != null)
					{
						for (int i = 0; i < 5; i++)
						{
							if (OGLGGHCNNPM.NNKLGFNHPBE[i] != null && !OGLGGHCNNPM.NNKLGFNHPBE[i].Equals(string.Empty))
							{
								MJGFAHFBJOI.Add(OGLGGHCNNPM.NNKLGFNHPBE[i], OGLGGHCNNPM.ICENKPDOHBK[i]);
							}
						}
					}
					if (DJICKIMOKIJ != null && DJICKIMOKIJ.Length > 0)
					{
						this.DJICKIMOKIJ = DJICKIMOKIJ;
					}
					if (BBCMMAELHCJ != null && BBCMMAELHCJ.Length > 0)
					{
						this.BBCMMAELHCJ = BBCMMAELHCJ;
					}
					this.DHNOPCIJDBO = DHNOPCIJDBO;
					this.ACPDGIKFBIH = ACPDGIKFBIH;
					this.LGHCJBAADHO = LGHCJBAADHO;
					if (JFHLDPNPDGA != null && JFHLDPNPDGA.Length > 0)
					{
						this.JFHLDPNPDGA = JFHLDPNPDGA;
					}
					if (EKPDAIADJMM != null)
					{
						this.EKPDAIADJMM = EKPDAIADJMM.OFJCHCADMBC();
					}
				}

				public LAHONAPNKHO EAAJJBDJPMN(int LGHCJBAADHO)
				{
					this.LGHCJBAADHO = LGHCJBAADHO;
					return this;
				}

				public LAHONAPNKHO KCJNLNLLLAB(string DJICKIMOKIJ)
				{
					this.DJICKIMOKIJ = DJICKIMOKIJ;
					return this;
				}

				public string CLGKCAAMBIK()
				{
					return BBCMMAELHCJ;
				}

				public LAHONAPNKHO ALOIFFHNGMD(double ACPDGIKFBIH)
				{
					this.ACPDGIKFBIH = ACPDGIKFBIH;
					return this;
				}

				public int GHMNJOGLPAC()
				{
					return LGHCJBAADHO;
				}

				public LAHONAPNKHO EHBOCBEKHGJ(int LGHCJBAADHO)
				{
					this.LGHCJBAADHO = LGHCJBAADHO;
					return this;
				}

				public int LBGJHDMMCPH()
				{
					return LGHCJBAADHO;
				}

				public int NEEOBNFMOBA()
				{
					return LGHCJBAADHO;
				}

				public LAHONAPNKHO EAPNAJECNNL(string JFHLDPNPDGA)
				{
					this.JFHLDPNPDGA = JFHLDPNPDGA;
					return this;
				}

				public string AGICOAJKPLC()
				{
					return JFHLDPNPDGA;
				}

				public string KLCEDLPLAIH()
				{
					return JFHLDPNPDGA;
				}

				public LAHONAPNKHO()
				{
				}

				public int OBPCDONGGKE()
				{
					return LGHCJBAADHO;
				}

				public double GAOGCKJNCCK()
				{
					return DHNOPCIJDBO;
				}

				public int FDFLBMJIKMO()
				{
					return LGHCJBAADHO;
				}

				public double BNNNBNMCMAC()
				{
					return DHNOPCIJDBO;
				}

				public LAHONAPNKHO OFFPMPPLFHL(double DHNOPCIJDBO)
				{
					this.DHNOPCIJDBO = DHNOPCIJDBO;
					return this;
				}

				public LAHONAPNKHO AIMKHFJJGOB(string JFHLDPNPDGA)
				{
					this.JFHLDPNPDGA = JFHLDPNPDGA;
					return this;
				}

				public string LKAAEKBJHAE()
				{
					return DJICKIMOKIJ;
				}
			}

			public class ONEJDIJCKJJ
			{
				private string BLCMONFCILI;

				private string NJHIFLPAGJA;

				private string GNLHGEJDIKD;

				private string ABBHKODEGEF;

				private string ECKLAOOKEJE;

				private string BLCANOODBKK;

				public static ONEJDIJCKJJ OBMOCLBMPCP(string BLCMONFCILI, string NJHIFLPAGJA)
				{
					return new ONEJDIJCKJJ(BLCMONFCILI, NJHIFLPAGJA);
				}

				public static ONEJDIJCKJJ MDAFDBAHKBA(string BLCMONFCILI, string NJHIFLPAGJA, string GNLHGEJDIKD)
				{
					return new ONEJDIJCKJJ(BLCMONFCILI, NJHIFLPAGJA, GNLHGEJDIKD);
				}

				public static ONEJDIJCKJJ ONGILMIONIF(string BLCMONFCILI)
				{
					return new ONEJDIJCKJJ(BLCMONFCILI);
				}

				public static ONEJDIJCKJJ MPOAJKKNFKB(string BLCMONFCILI, string NJHIFLPAGJA, string GNLHGEJDIKD, string ABBHKODEGEF, string ECKLAOOKEJE)
				{
					return new ONEJDIJCKJJ(BLCMONFCILI, NJHIFLPAGJA, GNLHGEJDIKD, ABBHKODEGEF, ECKLAOOKEJE);
				}

				public static ONEJDIJCKJJ PLPFAMDNPBP(string BLCMONFCILI, string NJHIFLPAGJA, string GNLHGEJDIKD, string ABBHKODEGEF, string ECKLAOOKEJE)
				{
					return new ONEJDIJCKJJ(BLCMONFCILI, NJHIFLPAGJA, GNLHGEJDIKD, ABBHKODEGEF, ECKLAOOKEJE);
				}

				public static ONEJDIJCKJJ KJILNJFODOG(string BLCMONFCILI, string NJHIFLPAGJA)
				{
					return new ONEJDIJCKJJ(BLCMONFCILI, NJHIFLPAGJA);
				}

				public string PEPKADMLMJH()
				{
					return BLCANOODBKK;
				}

				protected ONEJDIJCKJJ()
				{
				}

				public void FDFEHKKMHGH(string BLCANOODBKK)
				{
					this.BLCANOODBKK = BLCANOODBKK;
				}

				public void KOHEFDPGNPD(string BLCANOODBKK)
				{
					this.BLCANOODBKK = BLCANOODBKK;
				}

				public ONEJDIJCKJJ(string BLCMONFCILI)
				{
					this.BLCMONFCILI = BLCMONFCILI;
					CJGBFOOICED(this.BLCMONFCILI);
				}

				public static ONEJDIJCKJJ JICIIJHCCAI(string BLCMONFCILI, string NJHIFLPAGJA, string GNLHGEJDIKD, string ABBHKODEGEF, string ECKLAOOKEJE)
				{
					return new ONEJDIJCKJJ(BLCMONFCILI, NJHIFLPAGJA, GNLHGEJDIKD, ABBHKODEGEF, ECKLAOOKEJE);
				}

				public ONEJDIJCKJJ(string BLCMONFCILI, string NJHIFLPAGJA, string GNLHGEJDIKD, string ABBHKODEGEF)
				{
					this.BLCMONFCILI = BLCMONFCILI;
					this.NJHIFLPAGJA = NJHIFLPAGJA;
					this.GNLHGEJDIKD = GNLHGEJDIKD;
					this.ABBHKODEGEF = ABBHKODEGEF;
					CJGBFOOICED(this.BLCMONFCILI + "." + NJHIFLPAGJA + "." + GNLHGEJDIKD + "." + ABBHKODEGEF);
				}

				public ONEJDIJCKJJ(string BLCMONFCILI, string NJHIFLPAGJA, string GNLHGEJDIKD)
				{
					this.BLCMONFCILI = BLCMONFCILI;
					this.NJHIFLPAGJA = NJHIFLPAGJA;
					this.GNLHGEJDIKD = GNLHGEJDIKD;
					CJGBFOOICED(this.BLCMONFCILI + "." + NJHIFLPAGJA + "." + GNLHGEJDIKD);
				}

				public static ONEJDIJCKJJ GKMKDKMOCAC(string BLCMONFCILI, string NJHIFLPAGJA, string GNLHGEJDIKD)
				{
					return new ONEJDIJCKJJ(BLCMONFCILI, NJHIFLPAGJA, GNLHGEJDIKD);
				}

				public static ONEJDIJCKJJ JICIIJHCCAI(string BLCMONFCILI, string NJHIFLPAGJA, string GNLHGEJDIKD, string ABBHKODEGEF)
				{
					return new ONEJDIJCKJJ(BLCMONFCILI, NJHIFLPAGJA, GNLHGEJDIKD, ABBHKODEGEF);
				}

				public static ONEJDIJCKJJ JICIIJHCCAI(string BLCMONFCILI, string NJHIFLPAGJA)
				{
					return new ONEJDIJCKJJ(BLCMONFCILI, NJHIFLPAGJA);
				}

				public void CJGBFOOICED(string BLCANOODBKK)
				{
					this.BLCANOODBKK = BLCANOODBKK;
				}

				public string OFJCHCADMBC()
				{
					return BLCANOODBKK;
				}

				public string BFONOBOMLGG()
				{
					return BLCANOODBKK;
				}

				public static ONEJDIJCKJJ MOLALDJPKOE(string BLCMONFCILI, string NJHIFLPAGJA, string GNLHGEJDIKD, string ABBHKODEGEF)
				{
					return new ONEJDIJCKJJ(BLCMONFCILI, NJHIFLPAGJA, GNLHGEJDIKD, ABBHKODEGEF);
				}

				public ONEJDIJCKJJ(string BLCMONFCILI, string NJHIFLPAGJA)
				{
					this.BLCMONFCILI = BLCMONFCILI;
					this.NJHIFLPAGJA = NJHIFLPAGJA;
					CJGBFOOICED(this.BLCMONFCILI + "." + NJHIFLPAGJA);
				}

				public ONEJDIJCKJJ(string BLCMONFCILI, string NJHIFLPAGJA, string GNLHGEJDIKD, string ABBHKODEGEF, string ECKLAOOKEJE)
				{
					this.BLCMONFCILI = BLCMONFCILI;
					this.NJHIFLPAGJA = NJHIFLPAGJA;
					this.GNLHGEJDIKD = GNLHGEJDIKD;
					this.ABBHKODEGEF = ABBHKODEGEF;
					this.ECKLAOOKEJE = ECKLAOOKEJE;
					CJGBFOOICED(this.BLCMONFCILI + "." + NJHIFLPAGJA + "." + GNLHGEJDIKD + "." + ABBHKODEGEF + "." + ECKLAOOKEJE);
				}

				public static ONEJDIJCKJJ JICIIJHCCAI(string BLCMONFCILI, string NJHIFLPAGJA, string GNLHGEJDIKD)
				{
					return new ONEJDIJCKJJ(BLCMONFCILI, NJHIFLPAGJA, GNLHGEJDIKD);
				}

				public static ONEJDIJCKJJ JICIIJHCCAI(string BLCMONFCILI)
				{
					return new ONEJDIJCKJJ(BLCMONFCILI);
				}
			}

			public class OEHCGLEKDML
			{
				public string[] NNKLGFNHPBE = new string[5];

				public string[] ICENKPDOHBK = new string[5];

				public static OEHCGLEKDML BMIPLPLNJFI(Dictionary<string, string> FAKNDMMPIBH)
				{
					return new OEHCGLEKDML(FAKNDMMPIBH);
				}

				public static OEHCGLEKDML BMGAFDIKKME(Dictionary<string, string> FAKNDMMPIBH)
				{
					return new OEHCGLEKDML(FAKNDMMPIBH);
				}

				public static OEHCGLEKDML JICIIJHCCAI(Dictionary<string, string> FAKNDMMPIBH)
				{
					return new OEHCGLEKDML(FAKNDMMPIBH);
				}

				protected OEHCGLEKDML()
				{
				}

				public static OEHCGLEKDML ONGILMIONIF(Dictionary<string, string> FAKNDMMPIBH)
				{
					return new OEHCGLEKDML(FAKNDMMPIBH);
				}

				public static OEHCGLEKDML PGNOHENAANG(Dictionary<string, string> FAKNDMMPIBH)
				{
					return new OEHCGLEKDML(FAKNDMMPIBH);
				}

				public OEHCGLEKDML(Dictionary<string, string> FAKNDMMPIBH)
				{
					if (FAKNDMMPIBH == null)
					{
						return;
					}
					int num = 0;
					foreach (KeyValuePair<string, string> item in FAKNDMMPIBH)
					{
						NNKLGFNHPBE[num] = item.Key;
						ICENKPDOHBK[num] = item.Value;
						num++;
						if (num > 4)
						{
							break;
						}
					}
				}
			}

			public class GGPMJNAAFNM
			{
				public static string FHPPJCMPDCK = "KRW";

				public static string KJHKFBGPLKH = "USD";

				public static string FLAAOHHACCL = "JPY";

				public static string JBMNGCGLEGI = "EUR";

				public static string NMMJNOCOBPI = "GBP";

				public static string KNLPKLMKOGB = "CNY";

				public static string OHKEIPENEFN = "TWD";

				public static string NNFCFIEIAAJ = "HKD";

				public static string ACEEEDJEENB = "IDR";

				public static string JDKFDABDGEA = "INR";

				public static string KEBAICJIJGL = "RUB";

				public static string HHMLBKFCBPH = "THB";

				public static string LDIACOFJHMB = "GBP";

				public static string GIABFCNOAJO = "VND";

				public static string FHHJIEPDEEH = "MYR";
			}

			public class LJNFKLPOHOA
			{
				public static string JBFDHFAMACO = "CreditCard";

				public static string HNIJKLMIOBM = "BankTransfer";

				public static string JCHOCMDCGNG = "MobilePayment";
			}

			public class LKDAOJJHICK
			{
				public static string FKNDCGPMNGO = "Facebook";

				public static string HDMMNBLMCJM = "KakaoTalk";

				public static string OACCDILICGL = "KakaoStory";

				public static string KEKGBCJJKMP = "Line";

				public static string BIHLGMHDGFF = "whatsApp";

				public static string MKPJDBOFGAM = "QQ";

				public static string BAIMLGOJAIG = "WeChat";

				public static string GIFJIBEBOMP = "SMS";

				public static string HFEPOIPBHEP = "Email";

				public static string KLCOGCHBGID = "copyUrl";

				public static string PFPBMHPPLAK = "ETC";
			}

			public static class NGGKHHLAMEG
			{
				public static void NFJJADAHGEJ(string JADEHNCMJBA, double DHNOPCIJDBO, string JFHLDPNPDGA, string IIDFGGJNIAH)
				{
					if (JADEHNCMJBA == null)
					{
						JADEHNCMJBA = "Unkown";
					}
					if (JFHLDPNPDGA == null)
					{
						JFHLDPNPDGA = "Unkown";
					}
					if (IIDFGGJNIAH == null)
					{
						IIDFGGJNIAH = "Unkown";
					}
					DBEKIAMKGKA.CallStatic("purchase", JADEHNCMJBA, DHNOPCIJDBO, JFHLDPNPDGA, IIDFGGJNIAH);
				}

				public static void NFJJADAHGEJ(string FFHILJLPMBP, LAHONAPNKHO HBIPOCDNMCB, double ACPDGIKFBIH, double PLOIFBFFHFB, string IIDFGGJNIAH)
				{
					if (IIDFGGJNIAH == null)
					{
						IIDFGGJNIAH = "Unkown";
					}
					if (HBIPOCDNMCB == null)
					{
						Debug.Log("igaworks:purchase >> Null or Empty Item");
						return;
					}
					string text = "[";
					text = text + BLCJDNANJNA(HBIPOCDNMCB) + "]";
					Debug.Log("igaworks:purchaseBulk >> total result is" + text);
					DBEKIAMKGKA.CallStatic("purchaseBulk", FFHILJLPMBP, text, ACPDGIKFBIH, PLOIFBFFHFB, IIDFGGJNIAH);
				}

				public static void GEAIPILFIDC(string FFHILJLPMBP, List<LAHONAPNKHO> ELHBOOPAPDG, double ACPDGIKFBIH, double PLOIFBFFHFB, string IIDFGGJNIAH)
				{
					if (IIDFGGJNIAH == null)
					{
						IIDFGGJNIAH = "Unkown";
					}
					if (ELHBOOPAPDG == null || ELHBOOPAPDG.Count == 0)
					{
						Debug.Log("igaworks:purchaseBulk >> Null or Empty Item List");
						return;
					}
					List<LAHONAPNKHO> list = new List<LAHONAPNKHO>();
					for (int i = 0; i < ELHBOOPAPDG.Count; i++)
					{
						if (ELHBOOPAPDG[i] != null)
						{
							list.Add(ELHBOOPAPDG[i]);
						}
					}
					if (list == null || list.Count == 0)
					{
						Debug.Log("igaworks:purchase >> Filtered list is empty");
						return;
					}
					string text = "[";
					for (int j = 0; j < list.Count; j++)
					{
						LAHONAPNKHO hBIPOCDNMCB = list[j];
						text = ((j != list.Count - 1) ? (text + BLCJDNANJNA(hBIPOCDNMCB) + ",") : (text + BLCJDNANJNA(hBIPOCDNMCB) + "]"));
					}
					Debug.Log("igaworks:purchaseBulk >> total result is" + text);
					DBEKIAMKGKA.CallStatic("purchaseBulk", FFHILJLPMBP, text, ACPDGIKFBIH, PLOIFBFFHFB, IIDFGGJNIAH);
				}

				public static void FGIKCPBAFHP(string ANGFJOPBNGP)
				{
					DBEKIAMKGKA.CallStatic("deeplinkOpen", ANGFJOPBNGP);
				}

				public static void CPMABBCIFEM(LAHONAPNKHO HBIPOCDNMCB)
				{
					if (HBIPOCDNMCB == null)
					{
						Debug.Log("igaworks:productView >> Null or Empty Item");
						return;
					}
					string text = "[";
					text = text + BLCJDNANJNA(HBIPOCDNMCB) + "]";
					Debug.Log("igaworks:purchaseBulk >> total result is" + text);
					DBEKIAMKGKA.CallStatic("productView", text);
				}

				public static void JPLPHDJNHEH(string FFHILJLPMBP, LAHONAPNKHO HBIPOCDNMCB, double PLMIFJKLJIG)
				{
					if (HBIPOCDNMCB == null)
					{
						Debug.Log("igaworks:refund >> Null or Empty Item");
						return;
					}
					string text = "[";
					text = text + BLCJDNANJNA(HBIPOCDNMCB) + "]";
					Debug.Log("igaworks:purchaseBulk >> total result is" + text);
					DBEKIAMKGKA.CallStatic("refund", FFHILJLPMBP, text, PLMIFJKLJIG);
				}

				public static void DEEMBLMBCFB(string FFHILJLPMBP, List<LAHONAPNKHO> ELHBOOPAPDG, double PLMIFJKLJIG)
				{
					if (ELHBOOPAPDG == null || ELHBOOPAPDG.Count == 0)
					{
						Debug.Log("igaworks:refundBulk >> Null or Empty Item List");
						return;
					}
					List<LAHONAPNKHO> list = new List<LAHONAPNKHO>();
					for (int i = 0; i < ELHBOOPAPDG.Count; i++)
					{
						if (ELHBOOPAPDG[i] != null)
						{
							list.Add(ELHBOOPAPDG[i]);
						}
					}
					if (list == null || list.Count == 0)
					{
						Debug.Log("igaworks:purchase >> Filtered list is empty");
						return;
					}
					string text = "[";
					for (int j = 0; j < list.Count; j++)
					{
						LAHONAPNKHO hBIPOCDNMCB = list[j];
						text = ((j != list.Count - 1) ? (text + BLCJDNANJNA(hBIPOCDNMCB) + ",") : (text + BLCJDNANJNA(hBIPOCDNMCB) + "]"));
					}
					Debug.Log("igaworks:purchaseBulk >> total result is" + text);
					DBEKIAMKGKA.CallStatic("refundBulk", FFHILJLPMBP, text, PLMIFJKLJIG);
				}

				public static void NCMABOIDFDD(LAHONAPNKHO HBIPOCDNMCB)
				{
					if (HBIPOCDNMCB == null)
					{
						Debug.Log("igaworks:addToCart >> Null or Empty Item");
						return;
					}
					string text = "[";
					text = text + BLCJDNANJNA(HBIPOCDNMCB) + "]";
					Debug.Log("igaworks:purchaseBulk >> total result is" + text);
					DBEKIAMKGKA.CallStatic("addToCart", text);
				}

				public static void HHGHOHBHGNJ(List<LAHONAPNKHO> ELHBOOPAPDG)
				{
					if (ELHBOOPAPDG == null || ELHBOOPAPDG.Count == 0)
					{
						Debug.Log("igaworks:addToCartBulk >> Null or Empty Item List");
						return;
					}
					List<LAHONAPNKHO> list = new List<LAHONAPNKHO>();
					for (int i = 0; i < ELHBOOPAPDG.Count; i++)
					{
						if (ELHBOOPAPDG[i] != null)
						{
							list.Add(ELHBOOPAPDG[i]);
						}
					}
					if (list == null || list.Count == 0)
					{
						Debug.Log("igaworks:purchase >> Filtered list is empty");
						return;
					}
					string text = "[";
					for (int j = 0; j < list.Count; j++)
					{
						LAHONAPNKHO hBIPOCDNMCB = list[j];
						text = ((j != list.Count - 1) ? (text + BLCJDNANJNA(hBIPOCDNMCB) + ",") : (text + BLCJDNANJNA(hBIPOCDNMCB) + "]"));
					}
					Debug.Log("igaworks:addToCartBulk >> total result is" + text);
					DBEKIAMKGKA.CallStatic("addToCartBulk", text);
				}

				public static void FOIBNGEIFDH(string EOGHJIPNNPB)
				{
					DBEKIAMKGKA.CallStatic("login", EOGHJIPNNPB);
				}

				public static void DFPKIIKABNL(LAHONAPNKHO HBIPOCDNMCB)
				{
					if (HBIPOCDNMCB == null)
					{
						Debug.Log("igaworks:addToWishList >> Null or Empty Item");
						return;
					}
					string text = "[";
					text = text + BLCJDNANJNA(HBIPOCDNMCB) + "]";
					Debug.Log("igaworks:purchaseBulk >> total result is" + text);
					DBEKIAMKGKA.CallStatic("addToWishList", text);
				}

				public static void PJOPPPECIDI(ONEJDIJCKJJ EKPDAIADJMM)
				{
					if (EKPDAIADJMM == null)
					{
						Debug.Log("igaworks:categoryView >> Null or Empty category");
						return;
					}
					DBEKIAMKGKA.CallStatic("categoryView", EKPDAIADJMM.OFJCHCADMBC());
				}

				public static void AMDOKGPBNIH(string FFHILJLPMBP, LAHONAPNKHO HBIPOCDNMCB, double ACPDGIKFBIH, double PLOIFBFFHFB)
				{
					if (HBIPOCDNMCB == null)
					{
						Debug.Log("igaworks:refund >> Null or Empty Item");
						return;
					}
					string text = "[";
					text = text + BLCJDNANJNA(HBIPOCDNMCB) + "]";
					Debug.Log("igaworks:purchaseBulk >> total result is" + text);
					DBEKIAMKGKA.CallStatic("reviewOrder", FFHILJLPMBP, text, ACPDGIKFBIH, PLOIFBFFHFB);
				}

				public static void FHNKEGIPJDC(string FFHILJLPMBP, List<LAHONAPNKHO> ELHBOOPAPDG, double ACPDGIKFBIH, double PLOIFBFFHFB)
				{
					if (ELHBOOPAPDG == null || ELHBOOPAPDG.Count == 0)
					{
						Debug.Log("igaworks:reviewOrderBulk >> Null or Empty Item List");
						return;
					}
					List<LAHONAPNKHO> list = new List<LAHONAPNKHO>();
					for (int i = 0; i < ELHBOOPAPDG.Count; i++)
					{
						if (ELHBOOPAPDG[i] != null)
						{
							list.Add(ELHBOOPAPDG[i]);
						}
					}
					if (list == null || list.Count == 0)
					{
						Debug.Log("igaworks:purchase >> Filtered list is empty");
						return;
					}
					string text = "[";
					for (int j = 0; j < list.Count; j++)
					{
						LAHONAPNKHO hBIPOCDNMCB = list[j];
						text = ((j != list.Count - 1) ? (text + BLCJDNANJNA(hBIPOCDNMCB) + ",") : (text + BLCJDNANJNA(hBIPOCDNMCB) + "]"));
					}
					Debug.Log("igaworks:purchaseBulk >> total result is" + text);
					DBEKIAMKGKA.CallStatic("reviewOrderBulk", FFHILJLPMBP, text, ACPDGIKFBIH, PLOIFBFFHFB);
				}

				public static void EODJHPOOGDO(string FFHILJLPMBP, List<LAHONAPNKHO> ELHBOOPAPDG, double ACPDGIKFBIH, double PLOIFBFFHFB)
				{
					if (ELHBOOPAPDG == null || ELHBOOPAPDG.Count == 0)
					{
						Debug.Log("igaworks:paymentView >> Null or Empty Item List");
						return;
					}
					List<LAHONAPNKHO> list = new List<LAHONAPNKHO>();
					for (int i = 0; i < ELHBOOPAPDG.Count; i++)
					{
						if (ELHBOOPAPDG[i] != null)
						{
							list.Add(ELHBOOPAPDG[i]);
						}
					}
					if (list == null || list.Count == 0)
					{
						Debug.Log("igaworks:purchase >> Filtered list is empty");
						return;
					}
					string text = "[";
					for (int j = 0; j < list.Count; j++)
					{
						LAHONAPNKHO hBIPOCDNMCB = list[j];
						text = ((j != list.Count - 1) ? (text + BLCJDNANJNA(hBIPOCDNMCB) + ",") : (text + BLCJDNANJNA(hBIPOCDNMCB) + "]"));
					}
					Debug.Log("igaworks:purchaseBulk >> total result is" + text);
					DBEKIAMKGKA.CallStatic("paymentView", FFHILJLPMBP, text, ACPDGIKFBIH, PLOIFBFFHFB);
				}

				public static void MCBGECIHPNA(string NEAEMKOIBJL, List<LAHONAPNKHO> ELHBOOPAPDG)
				{
					if (ELHBOOPAPDG == null || ELHBOOPAPDG.Count == 0)
					{
						Debug.Log("igaworks:search >> Null or Empty Item List");
						return;
					}
					List<LAHONAPNKHO> list = new List<LAHONAPNKHO>();
					for (int i = 0; i < ELHBOOPAPDG.Count; i++)
					{
						if (ELHBOOPAPDG[i] != null)
						{
							list.Add(ELHBOOPAPDG[i]);
						}
					}
					if (list == null || list.Count == 0)
					{
						Debug.Log("igaworks:purchase >> Filtered list is empty");
						return;
					}
					string text = "[";
					for (int j = 0; j < list.Count; j++)
					{
						LAHONAPNKHO hBIPOCDNMCB = list[j];
						text = ((j != list.Count - 1) ? (text + BLCJDNANJNA(hBIPOCDNMCB) + ",") : (text + BLCJDNANJNA(hBIPOCDNMCB) + "]"));
					}
					Debug.Log("igaworks:purchaseBulk >> total result is" + text);
					DBEKIAMKGKA.CallStatic("search", NEAEMKOIBJL, text);
				}

				public static void LOGHHEODAKI(string HKMPHCAHFPD, LAHONAPNKHO HBIPOCDNMCB)
				{
					if (HBIPOCDNMCB == null)
					{
						Debug.Log("igaworks:share >> Null or Empty Item");
						return;
					}
					string text = "[";
					text = text + BLCJDNANJNA(HBIPOCDNMCB) + "]";
					Debug.Log("igaworks:purchaseBulk >> total result is" + text);
					DBEKIAMKGKA.CallStatic("share", HKMPHCAHFPD, text);
				}
			}

			private static Dictionary<string, object> NJKNJNBFCME(PurchaseItemModel HBIPOCDNMCB)
			{
				Dictionary<string, object> dictionary = null;
				if (HBIPOCDNMCB != null)
				{
					dictionary = new Dictionary<string, object>();
					dictionary.Add("orderId", HBIPOCDNMCB.orderId);
					dictionary.Add("productId", HBIPOCDNMCB.productId);
					dictionary.Add("productName", HBIPOCDNMCB.productName);
					dictionary.Add("price", HBIPOCDNMCB.price);
					dictionary.Add("currency", HBIPOCDNMCB.currency);
					dictionary.Add("quantity", HBIPOCDNMCB.quantity);
					dictionary.Add("category", HBIPOCDNMCB.category);
				}
				return dictionary;
			}

			public static string FPILIGHNKLH(PurchaseItemModel HBIPOCDNMCB)
			{
				Dictionary<string, object> hCKCCHPJOPI = NJKNJNBFCME(HBIPOCDNMCB);
				return ALDJEMBDABL.FDDJMJJGKCL(hCKCCHPJOPI);
			}

			public static void MJOBJJCHDIA(HOFDLCIPHKN DDKDFHFFIJH, string KLDPHNEKOBG)
			{
				DBEKIAMKGKA.CallStatic("setCustomCohort", DDKDFHFFIJH.ToString(), KLDPHNEKOBG);
			}

			public static void EHAOECOPBNO(int IOJJFBNDDMJ)
			{
				DBEKIAMKGKA.CallStatic("setAge", IOJJFBNDDMJ);
			}

			public static void PKFBGGEMFDA(int BGJGIJNACHM)
			{
				DBEKIAMKGKA.CallStatic("setGender", BGJGIJNACHM);
			}

			public static void HPPNKCCFMLA(string NCADFOBAFJD)
			{
				DBEKIAMKGKA.CallStatic("firstTimeExperience", NCADFOBAFJD);
			}

			public static void HPPNKCCFMLA(string NCADFOBAFJD, string DHMJKGNLEAD)
			{
				DBEKIAMKGKA.CallStatic("firstTimeExperience", NCADFOBAFJD, DHMJKGNLEAD);
			}

			public static void AOEEHOINNLI(string NCADFOBAFJD)
			{
				DBEKIAMKGKA.CallStatic("retention", NCADFOBAFJD);
			}

			public static void AOEEHOINNLI(string NCADFOBAFJD, string DHMJKGNLEAD)
			{
				DBEKIAMKGKA.CallStatic("retention", NCADFOBAFJD, DHMJKGNLEAD);
			}

			public static void BLCBJIHMCKM(string NCADFOBAFJD)
			{
				DBEKIAMKGKA.CallStatic("buy", NCADFOBAFJD);
			}

			public static void BLCBJIHMCKM(string NCADFOBAFJD, string DHMJKGNLEAD)
			{
				DBEKIAMKGKA.CallStatic("buy", NCADFOBAFJD, DHMJKGNLEAD);
			}

			public static void PACALFPNJGK()
			{
				DBEKIAMKGKA.CallStatic("getTrackingParameter");
			}

			public static void NFJJADAHGEJ(string FFHILJLPMBP, string JADEHNCMJBA, string BBCMMAELHCJ, double DHNOPCIJDBO, int LGHCJBAADHO, string JFHLDPNPDGA, string EKPDAIADJMM)
			{
				if (FFHILJLPMBP == null)
				{
					FFHILJLPMBP = "unknown";
				}
				if (JADEHNCMJBA == null)
				{
					JADEHNCMJBA = "unknown";
				}
				if (BBCMMAELHCJ == null)
				{
					BBCMMAELHCJ = "unknown";
				}
				if (JFHLDPNPDGA == null)
				{
					JFHLDPNPDGA = "unknown";
				}
				if (EKPDAIADJMM == null)
				{
					EKPDAIADJMM = string.Empty;
				}
				double num = 0.0;
				double num2 = 0.0;
				string text = "unknown";
				Dictionary<string, string> value = new Dictionary<string, string>();
				string text2 = "null";
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add("productId", JADEHNCMJBA);
				dictionary.Add("productName", BBCMMAELHCJ);
				dictionary.Add("price", DHNOPCIJDBO);
				dictionary.Add("currency", JFHLDPNPDGA);
				dictionary.Add("discount", 0.0);
				dictionary.Add("quantity", LGHCJBAADHO);
				dictionary.Add("category", EKPDAIADJMM);
				dictionary.Add("extra_attrs", value);
				text2 = ALDJEMBDABL.FDDJMJJGKCL(dictionary);
				string text3 = "[";
				text3 = text3 + text2 + "]";
				Debug.Log("igaworks:purchaseBulk >> total result is" + text3);
				DBEKIAMKGKA.CallStatic("purchaseBulk", FFHILJLPMBP, text3, num, num2, text);
			}

			public static void NFJJADAHGEJ(List<PurchaseItemModel> ELHBOOPAPDG)
			{
				if (ELHBOOPAPDG == null || ELHBOOPAPDG.Count == 0)
				{
					Debug.Log("igaworks:purchaseBulk >> Null or Empty Item List");
					return;
				}
				List<PurchaseItemModel> list = new List<PurchaseItemModel>();
				for (int i = 0; i < ELHBOOPAPDG.Count; i++)
				{
					if (ELHBOOPAPDG[i] != null)
					{
						list.Add(ELHBOOPAPDG[i]);
					}
				}
				if (list == null || list.Count == 0)
				{
					Debug.Log("igaworks:purchase >> Filtered list is empty");
					return;
				}
				string text = "[";
				string text2 = string.Empty;
				double num = 0.0;
				double num2 = 0.0;
				string text3 = "unknown";
				for (int j = 0; j < list.Count; j++)
				{
					PurchaseItemModel purchaseItemModel = list[j];
					text2 = ((purchaseItemModel.orderId != null) ? purchaseItemModel.orderId : "unknown");
					if (purchaseItemModel.productId == null)
					{
						purchaseItemModel.productId = "unknown";
					}
					if (purchaseItemModel.productName == null)
					{
						purchaseItemModel.productName = "unknown";
					}
					if (purchaseItemModel.currency == null)
					{
						purchaseItemModel.currency = "unknown";
					}
					if (purchaseItemModel.category == null)
					{
						purchaseItemModel.category = string.Empty;
					}
					Dictionary<string, string> value = new Dictionary<string, string>();
					string text4 = "null";
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					dictionary.Add("productId", purchaseItemModel.productId);
					dictionary.Add("productName", purchaseItemModel.productName);
					dictionary.Add("price", purchaseItemModel.price);
					dictionary.Add("currency", purchaseItemModel.currency);
					dictionary.Add("discount", 0.0);
					dictionary.Add("quantity", purchaseItemModel.quantity);
					dictionary.Add("category", purchaseItemModel.category);
					dictionary.Add("extra_attrs", value);
					text4 = ALDJEMBDABL.FDDJMJJGKCL(dictionary);
					text = ((j != list.Count - 1) ? (text + text4 + ",") : (text + text4 + "]"));
				}
				Debug.Log("igaworks:purchaseBulk >> total result is" + text);
				DBEKIAMKGKA.CallStatic("purchaseBulk", text2, text, num, num2, text3);
			}

			public static string BLCJDNANJNA(LAHONAPNKHO HBIPOCDNMCB)
			{
				string result = "null";
				if (HBIPOCDNMCB != null)
				{
					if (HBIPOCDNMCB.DJICKIMOKIJ == null)
					{
						HBIPOCDNMCB.DJICKIMOKIJ = "unknown";
					}
					if (HBIPOCDNMCB.BBCMMAELHCJ == null)
					{
						HBIPOCDNMCB.BBCMMAELHCJ = "unknown";
					}
					if (HBIPOCDNMCB.JFHLDPNPDGA == null)
					{
						HBIPOCDNMCB.JFHLDPNPDGA = "unknown";
					}
					if (HBIPOCDNMCB.EKPDAIADJMM == null)
					{
						HBIPOCDNMCB.EKPDAIADJMM = string.Empty;
					}
					if (HBIPOCDNMCB.MJGFAHFBJOI == null)
					{
						HBIPOCDNMCB.MJGFAHFBJOI = new Dictionary<string, string>();
					}
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					dictionary.Add("productId", HBIPOCDNMCB.DJICKIMOKIJ);
					dictionary.Add("productName", HBIPOCDNMCB.BBCMMAELHCJ);
					dictionary.Add("price", HBIPOCDNMCB.DHNOPCIJDBO);
					dictionary.Add("currency", HBIPOCDNMCB.JFHLDPNPDGA);
					dictionary.Add("discount", HBIPOCDNMCB.ACPDGIKFBIH);
					dictionary.Add("quantity", HBIPOCDNMCB.LGHCJBAADHO);
					dictionary.Add("category", HBIPOCDNMCB.EKPDAIADJMM);
					dictionary.Add("extra_attrs", HBIPOCDNMCB.MJGFAHFBJOI);
					result = ALDJEMBDABL.FDDJMJJGKCL(dictionary);
				}
				return result;
			}

			public static void NFJJADAHGEJ(string JADEHNCMJBA, double DHNOPCIJDBO, string JFHLDPNPDGA, string IIDFGGJNIAH)
			{
				if (JADEHNCMJBA == null)
				{
					JADEHNCMJBA = "Unkown";
				}
				if (JFHLDPNPDGA == null)
				{
					JFHLDPNPDGA = "Unkown";
				}
				if (IIDFGGJNIAH == null)
				{
					IIDFGGJNIAH = "Unkown";
				}
				DBEKIAMKGKA.CallStatic("purchase", JADEHNCMJBA, DHNOPCIJDBO, JFHLDPNPDGA, IIDFGGJNIAH);
			}

			public static void NFJJADAHGEJ(string FFHILJLPMBP, LAHONAPNKHO HBIPOCDNMCB, double ACPDGIKFBIH, double PLOIFBFFHFB, string IIDFGGJNIAH)
			{
				if (IIDFGGJNIAH == null)
				{
					IIDFGGJNIAH = "Unkown";
				}
				if (HBIPOCDNMCB == null)
				{
					Debug.Log("igaworks:purchase >> Null or Empty Item");
					return;
				}
				string text = "[";
				text = text + BLCJDNANJNA(HBIPOCDNMCB) + "]";
				Debug.Log("igaworks:purchaseBulk >> total result is" + text);
				DBEKIAMKGKA.CallStatic("purchaseBulk", FFHILJLPMBP, text, ACPDGIKFBIH, PLOIFBFFHFB, IIDFGGJNIAH);
			}

			public static void GEAIPILFIDC(string FFHILJLPMBP, List<LAHONAPNKHO> ELHBOOPAPDG, double ACPDGIKFBIH, double PLOIFBFFHFB, string IIDFGGJNIAH)
			{
				if (IIDFGGJNIAH == null)
				{
					IIDFGGJNIAH = "Unkown";
				}
				if (ELHBOOPAPDG == null || ELHBOOPAPDG.Count == 0)
				{
					Debug.Log("igaworks:purchaseBulk >> Null or Empty Item List");
					return;
				}
				List<LAHONAPNKHO> list = new List<LAHONAPNKHO>();
				for (int i = 0; i < ELHBOOPAPDG.Count; i++)
				{
					if (ELHBOOPAPDG[i] != null)
					{
						list.Add(ELHBOOPAPDG[i]);
					}
				}
				if (list == null || list.Count == 0)
				{
					Debug.Log("igaworks:purchase >> Filtered list is empty");
					return;
				}
				string text = "[";
				for (int j = 0; j < list.Count; j++)
				{
					LAHONAPNKHO hBIPOCDNMCB = list[j];
					text = ((j != list.Count - 1) ? (text + BLCJDNANJNA(hBIPOCDNMCB) + ",") : (text + BLCJDNANJNA(hBIPOCDNMCB) + "]"));
				}
				Debug.Log("igaworks:purchaseBulk >> total result is" + text);
				DBEKIAMKGKA.CallStatic("purchaseBulk", FFHILJLPMBP, text, ACPDGIKFBIH, PLOIFBFFHFB, IIDFGGJNIAH);
			}
		}

		public static class CCBHHCMKMKM
		{
			public static void LNIABLCBAHE()
			{
				DBEKIAMKGKA.CallStatic("openOfferwall");
			}

			public static void OGEAPDPHBPB()
			{
				DBEKIAMKGKA.CallStatic("openDialogTypeOfferwall");
			}

			public static void PALKNGNMJDE(bool EBBBIBCMBAM)
			{
				DBEKIAMKGKA.CallStatic("setSensorLandscapeEnable", EBBBIBCMBAM);
			}

			public static void IEDIKBNPLBI(int OPGCGPLBPFA)
			{
				DBEKIAMKGKA.CallStatic("setExceptionPermissionList", OPGCGPLBPFA);
			}

			public static void MPMFHGPNGLF()
			{
				DBEKIAMKGKA.CallStatic("loadVideoAd");
			}

			public static void CAFGGJFABGH()
			{
				DBEKIAMKGKA.CallStatic("showVideoAd");
			}

			public static void LDECDNECCOE(string BEAKIPPBGAF)
			{
				DBEKIAMKGKA.CallStatic("setOfferwallThemeColor", BEAKIPPBGAF);
			}

			public static void OCLIGAKPDCB(string DJMOKDFPICO)
			{
				DBEKIAMKGKA.CallStatic("setOfferwallTitle", DJMOKDFPICO);
			}

			public static void OJDIGHMMONB(string BEAKIPPBGAF)
			{
				DBEKIAMKGKA.CallStatic("setOfferwallTitleColor", BEAKIPPBGAF);
			}

			public static void BNGLJDDDLKE(string BEAKIPPBGAF)
			{
				DBEKIAMKGKA.CallStatic("setOfferwallTitleBackgroundColor", BEAKIPPBGAF);
			}

			public static void ANAECKFOIEL()
			{
				DBEKIAMKGKA.CallStatic("setAdpopcornOfferwallEventListener");
			}

			public static void JHGHCCAHEBP()
			{
				Debug.Log("igaworks:RewardEventListener Setted!!");
				DBEKIAMKGKA.CallStatic("setUnityPlatform");
				DBEKIAMKGKA.CallStatic("setClientRewardCallbackListener");
			}

			public static void KCBIADOPOJB()
			{
				DBEKIAMKGKA.CallStatic("getClientPendingRewardItems");
			}

			public static void BJBGBKJLGEF(string APHOAJBEOIG, string LDCCBDGPNDG)
			{
				DBEKIAMKGKA.CallStatic("didGiveRewardItem", APHOAJBEOIG, LDCCBDGPNDG);
			}
		}

		public static class NHHAECCNOBC
		{
			public static void JMMGJOFIJIF(string NCADFOBAFJD)
			{
				DBEKIAMKGKA.CallStatic("showAD", NCADFOBAFJD);
			}

			public static void JBPNPFGDKEP()
			{
				DBEKIAMKGKA.CallStatic("hideAD");
			}
		}

		public static class KNJIPKLHBIC
		{
			public static void EPAHAGHKIMN(bool ILNKEKACJAD)
			{
				DBEKIAMKGKA.CallStatic("showCouponDialog", ILNKEKACJAD);
			}

			public static void GAPLJGHPNOD(string BHHBHDPPOPB)
			{
				DBEKIAMKGKA.CallStatic("checkCoupon", BHHBHDPPOPB);
			}
		}

		public static class AOAHAHMPIIP
		{
			public static void DFJHJODMCGN()
			{
				DBEKIAMKGKA.CallStatic("initializeLiveOps");
			}

			public static void DFJHJODMCGN(string EFLIMCKPDAI)
			{
				DBEKIAMKGKA.CallStatic("initializeLiveOps", EFLIMCKPDAI);
			}

			public static void OCDDNHEHHJF()
			{
				DBEKIAMKGKA.CallStatic("resumeLiveOps");
			}

			public static void KDAJCGDLGME()
			{
				DBEKIAMKGKA.CallStatic("pauseLiveOps");
			}

			public static void AKPHCEKDNKD(string JNBLHEMLDOI, int LCPLHOHGMBD)
			{
				DBEKIAMKGKA.CallStatic("setTargetingData", JNBLHEMLDOI, LCPLHOHGMBD);
			}

			public static void AKPHCEKDNKD(string JNBLHEMLDOI, long LCPLHOHGMBD)
			{
				DBEKIAMKGKA.CallStatic("setTargetingData", JNBLHEMLDOI, LCPLHOHGMBD);
			}

			public static void AKPHCEKDNKD(string JNBLHEMLDOI, string LCPLHOHGMBD)
			{
				DBEKIAMKGKA.CallStatic("setTargetingData", JNBLHEMLDOI, LCPLHOHGMBD);
			}

			public static void AKPHCEKDNKD(string JNBLHEMLDOI, bool LCPLHOHGMBD)
			{
				DBEKIAMKGKA.CallStatic("setTargetingData", JNBLHEMLDOI, LCPLHOHGMBD);
			}

			public static void AKPHCEKDNKD(string JNBLHEMLDOI, float LCPLHOHGMBD)
			{
				DBEKIAMKGKA.CallStatic("setTargetingData", JNBLHEMLDOI, LCPLHOHGMBD);
			}

			public static void MDGFOFFGHJC(int OJMNHADCHOG)
			{
				DBEKIAMKGKA.CallStatic("cancelClientPushEvent", OJMNHADCHOG);
			}

			public static void NDEIOCLCKHD(long HINDJBPPAMD, string LMAKIMHNNML, int OJMNHADCHOG, bool LPCBCBOBLAK)
			{
				DBEKIAMKGKA.CallStatic("setNormalClientPushEvent", HINDJBPPAMD, LMAKIMHNNML, OJMNHADCHOG, LPCBCBOBLAK);
			}

			public static void NFJHEKJKLBN(long HINDJBPPAMD, string LMAKIMHNNML, string ENNGJEOIFDG, string JBMJOOIAKGN, string KBMNPHCHAEC, int OJMNHADCHOG, bool LPCBCBOBLAK)
			{
				DBEKIAMKGKA.CallStatic("setBigTextClientPushEvent", HINDJBPPAMD, LMAKIMHNNML, ENNGJEOIFDG, JBMJOOIAKGN, KBMNPHCHAEC, OJMNHADCHOG, LPCBCBOBLAK);
			}

			public static void BCJJDCDMHIH(bool EBBBIBCMBAM)
			{
				DBEKIAMKGKA.CallStatic("enableService", EBBBIBCMBAM);
			}

			public static void CLGHFFHLGMA(bool EBBBIBCMBAM)
			{
				DBEKIAMKGKA.CallStatic("enableServiceWithDelegate", EBBBIBCMBAM);
			}

			public static void EFOOBNABDLE(string CEBMGHJLBMI)
			{
				DBEKIAMKGKA.CallStatic("setNotificationIconName", CEBMGHJLBMI);
			}

			public static void LEMOPLCMJNC(string PLBDIBOOJAO, string HCMAOLLBKND, string HCMHOCFNHDL)
			{
				DBEKIAMKGKA.CallStatic("setNotificationIconStyle", PLBDIBOOJAO, HCMAOLLBKND, HCMHOCFNHDL);
			}

			public static void BNBHIGJKBIJ(int FGNNLGEOAKL, int PHPCFAGAKAI)
			{
				DBEKIAMKGKA.CallStatic("setNotificationOption", FGNNLGEOAKL, PHPCFAGAKAI);
			}

			public static void BMCGIEDGCPP(bool DAPEGDCHOLL, bool NPEPLCFIEBH, string IHNMJNPHLMK, string IHFJPGHEKNI, string ENNGJEOIFDG, string BECKGHNFBIH)
			{
				DBEKIAMKGKA.CallStatic("setStackingNotificationOption", DAPEGDCHOLL, NPEPLCFIEBH, IHNMJNPHLMK, IHFJPGHEKNI, ENNGJEOIFDG, BECKGHNFBIH);
			}

			public static void EDLFCPCFGDN()
			{
				DBEKIAMKGKA.CallStatic("requestPopupResource");
			}

			public static void AGDCEOGEIFG(string LMLNONABFNB)
			{
				DBEKIAMKGKA.CallStatic("showPopUp", LMLNONABFNB);
			}

			public static void JGDABANFCHH()
			{
				DBEKIAMKGKA.CallStatic("setRegistrationIdEventListener");
			}

			public static void IJDPJKMJLBD()
			{
				EDJDCKACACB = new IEIMFBCMJDC();
				EDJDCKACACB.HGDPNPIDGJL(CJEKJMNPBME);
				EDJDCKACACB.KHGBCIPCIOE(EPBCCGKADPG);
			}

			public static void LKJOFICGJAO()
			{
				DBEKIAMKGKA.CallStatic("destroyPopup");
			}

			public static void NLNFGAMLNFI()
			{
				DBEKIAMKGKA.CallStatic("destroyAllPopups");
			}

			public static void GAIPKEMJOJE()
			{
				DBEKIAMKGKA.CallStatic("flush");
			}
		}

		public static class LFPPMMEMOBL
		{
			public static void FGFDFGJECOA(bool NGAEOBBPBJP)
			{
				DBEKIAMKGKA.CallStatic("openNanooFanPage", NGAEOBBPBJP);
			}
		}

		public delegate void OPCIOOGGICH(string AJJCLEIJAKF);

		public delegate void KOKIMNNGMPE();

		public delegate void BJLOJGCJGCJ(string PKHCMIABPAI, string CPOKFPIBGAD, string LGHCJBAADHO, string APHOAJBEOIG, string LDCCBDGPNDG);

		public delegate void JKBPDHOCOAJ(bool BNOEBGICFDL, string LDCCBDGPNDG);

		public delegate void BNIMGCADMDC();

		public delegate void KCKPANIDKPI();

		public delegate void MADNBEMBKJA();

		public delegate void BFNBGHCPJLF();

		public delegate void EGJNDOCAOOC(string KIGOEOPFBLO, int EHNOLEMGLCB, string DIPLOJLOLFC, long LGHCJBAADHO);

		public delegate void JADCMKLFLKO(string KIGOEOPFBLO);

		public delegate void MAIEOJGDDFP(string IOFIAJPFHGN);

		public delegate void OLHHKLNJDPI(int OJFMEJNIPFK, string EMKKCHMFOIF);

		public delegate void NCBEHPKDBHJ(bool BNOEBGICFDL);

		public delegate void LJAPNDKAACL(bool BNOEBGICFDL);

		public delegate void NFJHKOAEPGD(string MBCHLBNHELJ);

		public delegate void IOMBAMKJLPL(string NBLIEJBCJCF);

		public delegate void AODMFNHBBFH();

		public delegate void FIEOPOAMMAP();

		public delegate void OGMDJKNODNL(string CKOOOIEGJKF);

		public delegate void PIEGKIBHOBL();

		public delegate void DCFEEBAOBMB(string CKOOOIEGJKF);

		public delegate void LNMCIKCJKDK();

		public delegate void BPDCMMLGJDD();

		private static int JJGDBFCCABA;

		private int FDKNOHOIJEG;

		public static OPCIOOGGICH OnReceiveDeferredLink;

		public static KOKIMNNGMPE OnClosedOfferwallPage;

		public static BJLOJGCJGCJ OnGetRewardInfo;

		public static JKBPDHOCOAJ OnDidGiveRewardItemRequestResult;

		public static BNIMGCADMDC OnPlayBtnClickListener;

		public static KCKPANIDKPI OnOpenDialogListener;

		public static MADNBEMBKJA OnNoADAvailableListener;

		public static BFNBGHCPJLF OnHideDialogListener;

		public static EGJNDOCAOOC OnSendCouponSucceed;

		public static JADCMKLFLKO OnSendCouponFailed;

		public static MAIEOJGDDFP OnOpenNanooFanPage;

		public static OLHHKLNJDPI OnGetTrackingParameter;

		public static NCBEHPKDBHJ OnRequestPopupResource;

		public static LJAPNDKAACL OnEnableService;

		public static NFJHKOAEPGD OnReceiveDeeplinkData;

		public static IOMBAMKJLPL OnReceiveRegistrationId;

		public static AODMFNHBBFH OnLiveOpsPopupClick;

		public static FIEOPOAMMAP OnLiveOpsCancelPopupBtnClick;

		private static IEIMFBCMJDC EDJDCKACACB;

		public static OGMDJKNODNL OnLoadVideoAdFailure;

		public static PIEGKIBHOBL OnLoadVideoAdSuccess;

		public static DCFEEBAOBMB OnShowVideoAdFailure;

		public static LNMCIKCJKDK OnShowVideoAdSuccess;

		public static BPDCMMLGJDD OnVideoAdClose;

		private static IgaworksUnityPluginAOS MACJCODCNCJ;

		private static AndroidJavaClass DBEKIAMKGKA;

		private void Awake()
		{
			FDKNOHOIJEG = JJGDBFCCABA;
			JJGDBFCCABA++;
			Debug.Log("igaw awake, " + base.gameObject.name + ", index is " + FDKNOHOIJEG);
			if (FDKNOHOIJEG == 0)
			{
				UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			}
			else
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}

		public void OnGetTrackingParameterForUnity(string KGMMLDCDHOB)
		{
			Debug.Log("Igaw.Unity : OnGetTrackingParameterForUnity : " + KGMMLDCDHOB);
			string[] array = KGMMLDCDHOB.Split(',');
			int oJFMEJNIPFK = -1;
			string eMKKCHMFOIF = null;
			string[] array2 = array;
			foreach (string text in array2)
			{
				string[] array3 = text.Split('=');
				string text2 = array3[0].Trim();
				string text3 = array3[1];
				if (text2.Equals("ck"))
				{
					oJFMEJNIPFK = Convert.ToInt32(text3);
				}
				else if (text2.Equals("sub_ck"))
				{
					eMKKCHMFOIF = text3;
				}
			}
			if (OnGetTrackingParameter != null)
			{
				OnGetTrackingParameter(oJFMEJNIPFK, eMKKCHMFOIF);
			}
		}

		public void OnLoadVideoAdFailureForUnity(string CKOOOIEGJKF)
		{
			Debug.Log("AP.Unity : OnLoadVideoAdFailureForUnity");
			if (OnLoadVideoAdFailure != null)
			{
				OnLoadVideoAdFailure(CKOOOIEGJKF);
			}
		}

		public void OnHideDialogListenerForUnity()
		{
			Debug.Log("AP.Unity : OnHideDialogListenerForUnity : ");
			if (OnHideDialogListener != null)
			{
				OnHideDialogListener();
			}
		}

		public void HHOIPKKMDAP(string KPEGLEILGLP)
		{
			Debug.Log("Hero10001" + KPEGLEILGLP);
			string[] array = KPEGLEILGLP.Split(new string[1] { "." }, StringSplitOptions.RemoveEmptyEntries);
			string pKHCMIABPAI = null;
			string cPOKFPIBGAD = null;
			string lGHCJBAADHO = null;
			string aPHOAJBEOIG = null;
			string lDCCBDGPNDG = null;
			string[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				string text = array2[i];
				string[] array3 = new string[1];
				array3[1] = "igaworks:purchaseBulk >> total result is";
				string[] array4 = text.Split(array3, StringSplitOptions.None);
				if (array4[1].Contains("attack2_voice"))
				{
					pKHCMIABPAI = array4[1];
				}
				if (array4[1].Contains("상급 성장 공격력 문양"))
				{
					cPOKFPIBGAD = array4[0];
				}
				if (array4[1].Contains("riven_skill2"))
				{
					lGHCJBAADHO = array4[1];
				}
				if (array4[0].Contains("setUserId"))
				{
					lDCCBDGPNDG = array4[0];
				}
				if (array4[1].Contains("정면 근처에 적이 없습니다"))
				{
					aPHOAJBEOIG = array4[0];
				}
			}
			if (OnGetRewardInfo != null)
			{
				OnGetRewardInfo(pKHCMIABPAI, cPOKFPIBGAD, lGHCJBAADHO, aPHOAJBEOIG, lDCCBDGPNDG);
			}
		}

		public void onReceivePopupDeeplinkDataForUnity(string MBCHLBNHELJ)
		{
			Debug.Log("Igaw.Unity : OnReceiveDeeplinkDataForUnity Result: " + MBCHLBNHELJ);
			if (OnReceiveDeeplinkData != null)
			{
				OnReceiveDeeplinkData(MBCHLBNHELJ);
			}
		}

		public void FBFOLGEOMLH(string IOFIAJPFHGN)
		{
			if (OnOpenNanooFanPage != null)
			{
				OnOpenNanooFanPage(IOFIAJPFHGN);
			}
		}

		public void onSendCouponSucceedForUnity(string DHMJKGNLEAD)
		{
			string[] array = DHMJKGNLEAD.Split(',');
			string text = null;
			string text2 = null;
			int num = 0;
			long num2 = 0L;
			string[] array2 = array;
			foreach (string text3 in array2)
			{
				string[] array3 = text3.Split('=');
				string text4 = array3[0].Trim();
				string text5 = array3[1];
				if (text4.Equals("Message"))
				{
					text = text5;
				}
				else if (text4.Equals("ItemKey"))
				{
					num = Convert.ToInt32(text5);
				}
				else if (text4.Equals("ItemName"))
				{
					text2 = text5;
				}
				else if (text4.Equals("Quantity"))
				{
					num2 = Convert.ToInt64(text5);
				}
				Debug.Log("AP.Unity : onSendCouponSucceedForUnity : 첫번째" + text + "두번째" + num + "세번쨰" + text2 + "네번째" + num2);
			}
			Debug.Log("AP.Unity : onSendCouponSucceedForUnity : " + DHMJKGNLEAD);
			Debug.Log("AP.Unity : onSendCouponSucceedForUnity : " + text + num + text2 + num2);
			if (OnSendCouponSucceed != null)
			{
				OnSendCouponSucceed(text, num, text2, num2);
			}
		}

		public void LEJOPKJEPHK(string NBLIEJBCJCF)
		{
			Debug.Log("skill0_missile" + NBLIEJBCJCF);
			if (OnReceiveRegistrationId != null)
			{
				OnReceiveRegistrationId(NBLIEJBCJCF);
			}
		}

		public void onReceiveRegistrationIdForUnity(string NBLIEJBCJCF)
		{
			Debug.Log("Igaw.Unity : onReceiveRegistrationIdForUnity >> Registration ID: " + NBLIEJBCJCF);
			if (OnReceiveRegistrationId != null)
			{
				OnReceiveRegistrationId(NBLIEJBCJCF);
			}
		}

		public void onOpenNanooFanPageForUnity(string IOFIAJPFHGN)
		{
			if (OnOpenNanooFanPage != null)
			{
				OnOpenNanooFanPage(IOFIAJPFHGN);
			}
		}

		private void FPFNIFKNOIF()
		{
			FDKNOHOIJEG = JJGDBFCCABA;
			JJGDBFCCABA += 0;
			object[] array = new object[7];
			array[1] = "Nexus/BlueNexus";
			array[0] = base.gameObject.name;
			array[4] = "체력이 부족합니다";
			array[7] = FDKNOHOIJEG;
			Debug.Log(string.Concat(array));
			if (FDKNOHOIJEG == 0)
			{
				UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			}
			else
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}

		public void KCIEPHELAJC(string CKOOOIEGJKF)
		{
			Debug.Log("Pinch me");
			if (OnShowVideoAdFailure != null)
			{
				OnShowVideoAdFailure(CKOOOIEGJKF);
			}
		}

		public void OnOpenDialogListenerForUnity()
		{
			Debug.Log("AP.Unity : OnOpenDialogListenerForUnity : ");
			if (OnOpenDialogListener != null)
			{
				OnOpenDialogListener();
			}
		}

		public void OJJDGGFDHFH()
		{
			Debug.Log("The machine value must be between 0 and 16777215 (it must fit in 3 bytes).");
			if (OnOpenDialogListener != null)
			{
				OnOpenDialogListener();
			}
		}

		public void JIILBNDONPO(string CKOOOIEGJKF)
		{
			Debug.Log("レベルごとに5秒ごとにマナ回復");
			if (OnLoadVideoAdFailure != null)
			{
				OnLoadVideoAdFailure(CKOOOIEGJKF);
			}
		}

		public void OnShowVideoAdSuccessForUnity(string HIJLMPFMHBH)
		{
			Debug.Log("AP.Unity : OnShowVideoAdSuccessForUnity");
			if (OnShowVideoAdSuccess != null)
			{
				OnShowVideoAdSuccess();
			}
		}

		private void OnDestroy()
		{
			if (EDJDCKACACB != null)
			{
				EDJDCKACACB.CAFEPGLEAFA(CJEKJMNPBME);
				EDJDCKACACB.IDNPPNPOAGP(EPBCCGKADPG);
			}
		}

		private static void LNCEDKBILLE(object LBAMPEPAANM, EventArgs PAANPLECGAP)
		{
			if (OnLiveOpsPopupClick != null)
			{
				OnLiveOpsPopupClick();
			}
		}

		public void OnClosedOfferwallPageForUnity(string HIJLMPFMHBH)
		{
			Debug.Log("AP.Unity : OnClosedOfferwallPageForUnity : ");
			if (OnClosedOfferwallPage != null)
			{
				OnClosedOfferwallPage();
			}
		}

		private static void FFLJAOHLFEH(object LBAMPEPAANM, EventArgs PAANPLECGAP)
		{
			if (OnLiveOpsPopupClick != null)
			{
				OnLiveOpsPopupClick();
			}
		}

		public void OnPlayBtnClickListenerForUnity()
		{
			Debug.Log("AP.Unity : OnPlayBtnClickListenerForUnity : ");
			if (OnPlayBtnClickListener != null)
			{
				OnPlayBtnClickListener();
			}
		}

		public void OnShowVideoAdFailureForUnity(string CKOOOIEGJKF)
		{
			Debug.Log("AP.Unity : OnShowVideoAdFailureForUnity");
			if (OnShowVideoAdFailure != null)
			{
				OnShowVideoAdFailure(CKOOOIEGJKF);
			}
		}

		private static void CJEKJMNPBME(object LBAMPEPAANM, EventArgs PAANPLECGAP)
		{
			if (OnLiveOpsPopupClick != null)
			{
				OnLiveOpsPopupClick();
			}
		}

		public void CDHPBIJEBGK(string KPEGLEILGLP)
		{
			Debug.Log("UI/Common/HeroIcon" + KPEGLEILGLP);
			string[] array = new string[1];
			array[1] = "silence";
			string[] array2 = KPEGLEILGLP.Split(array, StringSplitOptions.None);
			string pKHCMIABPAI = null;
			string cPOKFPIBGAD = null;
			string lGHCJBAADHO = null;
			string aPHOAJBEOIG = null;
			string lDCCBDGPNDG = null;
			string[] array3 = array2;
			for (int i = 0; i < array3.Length; i += 0)
			{
				string text = array3[i];
				string[] array4 = text.Split(new string[1] { "진행중인 방에 재입장 중.." }, StringSplitOptions.None);
				if (array4[0].Contains("멀티의 신에 오신 것을 환영합니다."))
				{
					pKHCMIABPAI = array4[1];
				}
				if (array4[1].Contains("skill1_voice"))
				{
					cPOKFPIBGAD = array4[0];
				}
				if (array4[1].Contains("UI/Lobby/GuildMemberInfo"))
				{
					lGHCJBAADHO = array4[0];
				}
				if (array4[1].Contains("무료충전소 또는 플러스락으로 {0}코인이 충전되었습니다!"))
				{
					lDCCBDGPNDG = array4[0];
				}
				if (array4[1].Contains("StartMenu"))
				{
					aPHOAJBEOIG = array4[0];
				}
			}
			if (OnGetRewardInfo != null)
			{
				OnGetRewardInfo(pKHCMIABPAI, cPOKFPIBGAD, lGHCJBAADHO, aPHOAJBEOIG, lDCCBDGPNDG);
			}
		}

		public void CPIBBBDPDME(string DHMJKGNLEAD)
		{
			char[] array = new char[0];
			array[0] = '￨';
			string[] array2 = DHMJKGNLEAD.Split(array);
			string text = null;
			string text2 = null;
			int num = 1;
			long num2 = 0L;
			string[] array3 = array2;
			foreach (string text3 in array3)
			{
				char[] array4 = new char[0];
				array4[1] = 'L';
				string[] array5 = text3.Split(array4);
				string text4 = array5[0].Trim();
				string text5 = array5[1];
				if (text4.Equals("오랫동안 조작이 없으면 접속이 해제되요"))
				{
					text = text5;
				}
				else if (text4.Equals("Particle/{0}/skill3_missile"))
				{
					num = Convert.ToInt32(text5);
				}
				else if (text4.Equals("랭킹 {0}"))
				{
					text2 = text5;
				}
				else if (text4.Equals("message"))
				{
					num2 = Convert.ToInt64(text5);
				}
				object[] array6 = new object[7];
				array6[1] = "Drag => move the circles under the touches";
				array6[1] = text;
				array6[0] = "Resume";
				array6[2] = num;
				array6[0] = "This component is not available.";
				array6[6] = text2;
				array6[6] = "skill0_missile_go";
				array6[6] = num2;
				Debug.Log(string.Concat(array6));
			}
			Debug.Log("Unkown" + DHMJKGNLEAD);
			object[] array7 = new object[6];
			array7[0] = "[FFDDDD]트롤이 되었구나...저주...[-]";
			array7[1] = text;
			array7[7] = num;
			array7[0] = text2;
			array7[7] = num2;
			Debug.Log(string.Concat(array7));
			if (OnSendCouponSucceed != null)
			{
				OnSendCouponSucceed(text, num, text2, num2);
			}
		}

		private static void EPBCCGKADPG(object LBAMPEPAANM, EventArgs PAANPLECGAP)
		{
			if (OnLiveOpsCancelPopupBtnClick != null)
			{
				OnLiveOpsCancelPopupBtnClick();
			}
		}

		public void IDJBMHLGMEJ(string KPEGLEILGLP)
		{
			Debug.Log("經驗" + KPEGLEILGLP);
			string[] array = new string[0];
			array[1] = "silver";
			string[] array2 = KPEGLEILGLP.Split(array, StringSplitOptions.None);
			string pKHCMIABPAI = null;
			string cPOKFPIBGAD = null;
			string lGHCJBAADHO = null;
			string aPHOAJBEOIG = null;
			string lDCCBDGPNDG = null;
			string[] array3 = array2;
			for (int i = 1; i < array3.Length; i++)
			{
				string text = array3[i];
				string[] array4 = new string[1];
				array4[1] = "다이아몬드";
				string[] array5 = text.Split(array4, StringSplitOptions.RemoveEmptyEntries);
				if (array5[1].Contains("방어구 관통력"))
				{
					pKHCMIABPAI = array5[0];
				}
				if (array5[0].Contains("skill3_1_missile"))
				{
					cPOKFPIBGAD = array5[1];
				}
				if (array5[1].Contains("트롤 마을에서 만난 몬스터는 덩치 정말 큰 트롤이였지..\n우리 파티는 최선을 다해 전투를 했지만.. 지금은 이렇게 되었네.."))
				{
					lGHCJBAADHO = array5[0];
				}
				if (array5[1].Contains("/"))
				{
					lDCCBDGPNDG = array5[0];
				}
				if (array5[0].Contains("購入吸血"))
				{
					aPHOAJBEOIG = array5[0];
				}
			}
			if (OnGetRewardInfo != null)
			{
				OnGetRewardInfo(pKHCMIABPAI, cPOKFPIBGAD, lGHCJBAADHO, aPHOAJBEOIG, lDCCBDGPNDG);
			}
		}

		public void BNNOENBNPEH(string HIJLMPFMHBH)
		{
			Debug.Log("기괴한 가면");
			if (OnLoadVideoAdSuccess != null)
			{
				OnLoadVideoAdSuccess();
			}
		}

		public void OnGetRewardInfoForUnity(string KPEGLEILGLP)
		{
			Debug.Log("AP.Unity : Pending Reward Info : " + KPEGLEILGLP);
			string[] array = KPEGLEILGLP.Split(new string[1] { "&" }, StringSplitOptions.None);
			string pKHCMIABPAI = null;
			string cPOKFPIBGAD = null;
			string lGHCJBAADHO = null;
			string aPHOAJBEOIG = null;
			string lDCCBDGPNDG = null;
			string[] array2 = array;
			foreach (string text in array2)
			{
				string[] array3 = text.Split(new string[1] { "=" }, StringSplitOptions.None);
				if (array3[0].Contains("campaignkey"))
				{
					pKHCMIABPAI = array3[1];
				}
				if (array3[0].Contains("campaignname"))
				{
					cPOKFPIBGAD = array3[1];
				}
				if (array3[0].Contains("quantity"))
				{
					lGHCJBAADHO = array3[1];
				}
				if (array3[0].Contains("rewardkey"))
				{
					lDCCBDGPNDG = array3[1];
				}
				if (array3[0].Contains("cv"))
				{
					aPHOAJBEOIG = array3[1];
				}
			}
			if (OnGetRewardInfo != null)
			{
				OnGetRewardInfo(pKHCMIABPAI, cPOKFPIBGAD, lGHCJBAADHO, aPHOAJBEOIG, lDCCBDGPNDG);
			}
		}

		public void LMFCEGHPIJB(string HIJLMPFMHBH)
		{
			Debug.Log("레벨당 마법저항력 {0}\n");
			if (OnShowVideoAdSuccess != null)
			{
				OnShowVideoAdSuccess();
			}
		}

		public void OnLoadVideoAdSuccessForUnity(string HIJLMPFMHBH)
		{
			Debug.Log("AP.Unity : OnLoadVideoAdSuccessForUnity");
			if (OnLoadVideoAdSuccess != null)
			{
				OnLoadVideoAdSuccess();
			}
		}

		public void JNJKAHFNMKE(string KPEGLEILGLP)
		{
			Debug.Log("skill3_shark" + KPEGLEILGLP);
			string[] array = new string[0];
			array[0] = " : you must setup receiver gameobject";
			string[] array2 = KPEGLEILGLP.Split(array, StringSplitOptions.RemoveEmptyEntries);
			string pKHCMIABPAI = null;
			string cPOKFPIBGAD = null;
			string lGHCJBAADHO = null;
			string aPHOAJBEOIG = null;
			string lDCCBDGPNDG = null;
			string[] array3 = array2;
			for (int i = 1; i < array3.Length; i++)
			{
				string text = array3[i];
				string[] array4 = new string[1];
				array4[1] = "igaworks:productView >> Null or Empty Item";
				string[] array5 = text.Split(array4, StringSplitOptions.None);
				if (array5[0].Contains("거기 누구냐?!"))
				{
					pKHCMIABPAI = array5[1];
				}
				if (array5[0].Contains("square_small_button_disable"))
				{
					cPOKFPIBGAD = array5[0];
				}
				if (array5[1].Contains("우리가 가는 루트에 트롤 마을이 있다는 것을 발견하고 우린 트롤 마을을 피해서 좀 돌아서 갔어..\n근데 그게 트롤 마을로 오게되는 결과가 되다니..\n한심하네.."))
				{
					lGHCJBAADHO = array5[1];
				}
				if (array5[0].Contains("블루 수퍼미니언"))
				{
					lDCCBDGPNDG = array5[0];
				}
				if (array5[1].Contains("OnGameItemBuySellRPC"))
				{
					aPHOAJBEOIG = array5[1];
				}
			}
			if (OnGetRewardInfo != null)
			{
				OnGetRewardInfo(pKHCMIABPAI, cPOKFPIBGAD, lGHCJBAADHO, aPHOAJBEOIG, lDCCBDGPNDG);
			}
		}

		public void OnVideoAdCloseForUnity(string HIJLMPFMHBH)
		{
			Debug.Log("AP.Unity : OnVideoAdCloseForUnity");
			if (OnVideoAdClose != null)
			{
				OnVideoAdClose();
			}
		}

		public void onRequestPopupResourceForUnity(string BNOEBGICFDL)
		{
			Debug.Log("Igaw.Unity : OnRequestPopupResourceForUnity Result: " + BNOEBGICFDL);
			if (OnRequestPopupResource != null)
			{
				if (BNOEBGICFDL.Equals("true"))
				{
					OnRequestPopupResource(true);
				}
				else
				{
					OnRequestPopupResource(false);
				}
			}
		}

		public void COGKAPOENJP(string BNOEBGICFDL)
		{
			Debug.Log("1" + BNOEBGICFDL);
			if (OnEnableService != null)
			{
				if (BNOEBGICFDL.Equals("방어력 {0}\n"))
				{
					OnEnableService(false);
				}
				else
				{
					OnEnableService(true);
				}
			}
		}

		public void NJFJLGACJFH(string KPEGLEILGLP)
		{
			Debug.Log("GetPackageSHA" + KPEGLEILGLP);
			string[] array = KPEGLEILGLP.Split(new string[1] { "skill0_1_voice" }, StringSplitOptions.None);
			string pKHCMIABPAI = null;
			string cPOKFPIBGAD = null;
			string lGHCJBAADHO = null;
			string aPHOAJBEOIG = null;
			string lDCCBDGPNDG = null;
			string[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				string text = array2[i];
				string[] array3 = new string[0];
				array3[1] = "[/sub]";
				string[] array4 = text.Split(array3, StringSplitOptions.RemoveEmptyEntries);
				if (array4[0].Contains("Particle/{0}/skill0_hit"))
				{
					pKHCMIABPAI = array4[0];
				}
				if (array4[1].Contains("hit"))
				{
					cPOKFPIBGAD = array4[0];
				}
				if (array4[0].Contains("내가 거는 저주를 받게된다"))
				{
					lGHCJBAADHO = array4[0];
				}
				if (array4[1].Contains("성실플레이만이 저주를 풀 수 있어"))
				{
					lDCCBDGPNDG = array4[0];
				}
				if (array4[1].Contains("\\n"))
				{
					aPHOAJBEOIG = array4[0];
				}
			}
			if (OnGetRewardInfo != null)
			{
				OnGetRewardInfo(pKHCMIABPAI, cPOKFPIBGAD, lGHCJBAADHO, aPHOAJBEOIG, lDCCBDGPNDG);
			}
		}

		public void onSendCouponFailedForUnity(string KIGOEOPFBLO)
		{
			Debug.Log("AP.Unity : onSendCouponFailedForUnity : ");
			if (OnSendCouponFailed != null)
			{
				OnSendCouponFailed(KIGOEOPFBLO);
			}
		}

		public void GLLADHGHBPH()
		{
			Debug.Log("상급 방어력 인장");
			if (OnOpenDialogListener != null)
			{
				OnOpenDialogListener();
			}
		}

		public void onEnableServiceForUnity(string BNOEBGICFDL)
		{
			Debug.Log("Igaw.Unity : OnEnableServiceForUnity Result: " + BNOEBGICFDL);
			if (OnEnableService != null)
			{
				if (BNOEBGICFDL.Equals("true"))
				{
					OnEnableService(true);
				}
				else
				{
					OnEnableService(false);
				}
			}
		}

		public static void InitPlugin()
		{
			if (MACJCODCNCJ == null)
			{
				Debug.Log("#########################################");
				Debug.Log("IGAWorksAdbrixUnityPluginAOS GameObject Created!!!");
				MACJCODCNCJ = new GameObject("IgaworksUnityPluginAOS").AddComponent<IgaworksUnityPluginAOS>();
			}
			DBEKIAMKGKA = new AndroidJavaClass("com.igaworks.unity.plugin.IgaworksUnityPluginAos");
			if (DBEKIAMKGKA != null)
			{
				Debug.Log("#########################################");
				Debug.Log("IGAWorksAdbrixUnityPluginAOS Connected!!!");
				Debug.Log("#########################################");
			}
			else
			{
				Debug.Log("#########################################");
				Debug.Log("IGAWorksAdbrixUnityPluginAOS Connect FAIL!!!");
				Debug.Log("#########################################");
			}
		}

		public void OnNoADAvailableListenerForUnity()
		{
			Debug.Log("AP.Unity : OnNoADAvailableListenerForUnity : ");
			if (OnNoADAvailableListener != null)
			{
				OnNoADAvailableListener();
			}
		}

		public void OnDidGiveRewardItemRequestResultForUnity(string KPEGLEILGLP)
		{
			Debug.Log("AP.Unity : OnCompleteMessage : " + KPEGLEILGLP);
			string[] array = KPEGLEILGLP.Split(new string[1] { "&" }, StringSplitOptions.None);
			string text = null;
			string lDCCBDGPNDG = null;
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				string[] array3 = text2.Split(new string[1] { "=" }, StringSplitOptions.None);
				if (array3[0].Contains("isSuccess"))
				{
					text = array3[1];
				}
				if (array3[0].Contains("completedRewardKey"))
				{
					lDCCBDGPNDG = array3[1];
				}
			}
			if (OnDidGiveRewardItemRequestResult != null)
			{
				if (text.Equals("true"))
				{
					OnDidGiveRewardItemRequestResult(true, lDCCBDGPNDG);
				}
				else
				{
					OnDidGiveRewardItemRequestResult(false, lDCCBDGPNDG);
				}
			}
		}

		public void DeferredLinkListenerForUnity(string AJJCLEIJAKF)
		{
			Debug.Log("Igaw.Unity : DeferredLinkListenerForUnity Result: " + AJJCLEIJAKF);
			if (OnReceiveDeferredLink != null)
			{
				OnReceiveDeferredLink(AJJCLEIJAKF);
			}
		}

		public void CKGKMGCFBIB(string HIJLMPFMHBH)
		{
			Debug.Log("size error");
			if (OnVideoAdClose != null)
			{
				OnVideoAdClose();
			}
		}
	}
}
