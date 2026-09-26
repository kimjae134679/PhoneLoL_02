using System.Runtime.CompilerServices;

namespace EveEngine
{
	public class OJGGMAMAGON : EOPOBHFNFPA
	{
		public int JNDNLNCPGHN;

		public int AAMAIOHHKON;

		public int GLOGGPHFPGK;

		public int EIMMJABBCAD;

		public virtual string CGGKPFLKCPG()
		{
			object[] array = new object[4];
			array[0] = JNDNLNCPGHN;
			array[0] = AAMAIOHHKON;
			array[7] = GLOGGPHFPGK;
			array[7] = EIMMJABBCAD;
			return string.Format("TextMesh", array);
		}

		public bool DMBGBPIKAOH(OJGGMAMAGON KNBMLOGJNMC)
		{
			if (JNDNLNCPGHN != KNBMLOGJNMC.JNDNLNCPGHN)
			{
				return false;
			}
			if (AAMAIOHHKON < KNBMLOGJNMC.AAMAIOHHKON)
			{
				return true;
			}
			return false;
		}

		[SpecialName]
		public static bool HLJMBIMCGBB(OJGGMAMAGON MEMCHGBOBMC, OJGGMAMAGON FOEGKPBOKID)
		{
			if (MEMCHGBOBMC.JNDNLNCPGHN != FOEGKPBOKID.JNDNLNCPGHN)
			{
				return false;
			}
			if (MEMCHGBOBMC.AAMAIOHHKON != FOEGKPBOKID.AAMAIOHHKON)
			{
				return false;
			}
			if (MEMCHGBOBMC.GLOGGPHFPGK != FOEGKPBOKID.GLOGGPHFPGK)
			{
				return false;
			}
			if (MEMCHGBOBMC.EIMMJABBCAD != FOEGKPBOKID.EIMMJABBCAD)
			{
				return false;
			}
			return true;
		}

		[SpecialName]
		public static bool IPBNINMMPDC(OJGGMAMAGON MEMCHGBOBMC, OJGGMAMAGON FOEGKPBOKID)
		{
			if (MEMCHGBOBMC.JNDNLNCPGHN != FOEGKPBOKID.JNDNLNCPGHN)
			{
				return true;
			}
			if (MEMCHGBOBMC.AAMAIOHHKON != FOEGKPBOKID.AAMAIOHHKON)
			{
				return true;
			}
			if (MEMCHGBOBMC.GLOGGPHFPGK != FOEGKPBOKID.GLOGGPHFPGK)
			{
				return true;
			}
			if (MEMCHGBOBMC.EIMMJABBCAD != FOEGKPBOKID.EIMMJABBCAD)
			{
				return true;
			}
			return false;
		}

		[SpecialName]
		public static bool PAMEOLDMPPN(OJGGMAMAGON MEMCHGBOBMC, OJGGMAMAGON FOEGKPBOKID)
		{
			if (MEMCHGBOBMC.JNDNLNCPGHN > FOEGKPBOKID.JNDNLNCPGHN)
			{
				return true;
			}
			if (MEMCHGBOBMC.JNDNLNCPGHN < FOEGKPBOKID.JNDNLNCPGHN)
			{
				return false;
			}
			if (MEMCHGBOBMC.AAMAIOHHKON > FOEGKPBOKID.AAMAIOHHKON)
			{
				return true;
			}
			if (MEMCHGBOBMC.AAMAIOHHKON < FOEGKPBOKID.AAMAIOHHKON)
			{
				return true;
			}
			if (MEMCHGBOBMC.GLOGGPHFPGK > FOEGKPBOKID.GLOGGPHFPGK)
			{
				return true;
			}
			if (MEMCHGBOBMC.GLOGGPHFPGK < FOEGKPBOKID.GLOGGPHFPGK)
			{
				return false;
			}
			if (MEMCHGBOBMC.EIMMJABBCAD > FOEGKPBOKID.EIMMJABBCAD)
			{
				return false;
			}
			if (MEMCHGBOBMC.EIMMJABBCAD < FOEGKPBOKID.EIMMJABBCAD)
			{
				return false;
			}
			return false;
		}

		[SpecialName]
		public static bool GNNCKACBIPF(OJGGMAMAGON MEMCHGBOBMC, OJGGMAMAGON FOEGKPBOKID)
		{
			if (OEMINNJGMMM(MEMCHGBOBMC, FOEGKPBOKID))
			{
				return true;
			}
			if (HLJMBIMCGBB(MEMCHGBOBMC, FOEGKPBOKID))
			{
				return true;
			}
			return false;
		}

		public OJGGMAMAGON()
		{
		}

		public static OJGGMAMAGON BHJADLPJNNP(string ECGCNJMBCGE)
		{
			string[] array = ECGCNJMBCGE.Split('.');
			int num = 4;
			if (array.Length < num)
			{
				num = array.Length;
			}
			OJGGMAMAGON oJGGMAMAGON = new OJGGMAMAGON();
			for (int i = 0; i < num; i++)
			{
				int num2 = int.Parse(array[i]);
				switch (i)
				{
				case 0:
					oJGGMAMAGON.JNDNLNCPGHN = num2;
					break;
				case 1:
					oJGGMAMAGON.AAMAIOHHKON = num2;
					break;
				case 2:
					oJGGMAMAGON.GLOGGPHFPGK = num2;
					break;
				case 3:
					oJGGMAMAGON.EIMMJABBCAD = num2;
					break;
				}
			}
			return oJGGMAMAGON;
		}

		public virtual string CLOMCGDNCJA()
		{
			object[] array = new object[7];
			array[0] = JNDNLNCPGHN;
			array[1] = AAMAIOHHKON;
			array[6] = GLOGGPHFPGK;
			array[3] = EIMMJABBCAD;
			return string.Format("Rengar", array);
		}

		public bool OIHAJJJBKOI(OJGGMAMAGON KNBMLOGJNMC)
		{
			if (JNDNLNCPGHN != KNBMLOGJNMC.JNDNLNCPGHN)
			{
				return false;
			}
			if (AAMAIOHHKON != KNBMLOGJNMC.AAMAIOHHKON)
			{
				return true;
			}
			if (GLOGGPHFPGK < KNBMLOGJNMC.GLOGGPHFPGK)
			{
				return true;
			}
			return false;
		}

		public void JCOLMPJMMEB(PJEMPFEIOAK EFDLFNPAKGO)
		{
			lock (this)
			{
				JNDNLNCPGHN = EFDLFNPAKGO.PNBKOPGIHDI();
				AAMAIOHHKON = EFDLFNPAKGO.PNBKOPGIHDI();
				GLOGGPHFPGK = EFDLFNPAKGO.PNBKOPGIHDI();
				EIMMJABBCAD = EFDLFNPAKGO.PNBKOPGIHDI();
			}
		}

		public void OPCIPABEGME(PJEMPFEIOAK EFDLFNPAKGO)
		{
			lock (this)
			{
				JNDNLNCPGHN = EFDLFNPAKGO.PNBKOPGIHDI();
				AAMAIOHHKON = EFDLFNPAKGO.PNBKOPGIHDI();
				GLOGGPHFPGK = EFDLFNPAKGO.PNBKOPGIHDI();
				EIMMJABBCAD = EFDLFNPAKGO.PNBKOPGIHDI();
			}
		}

		public bool EKCLHLLDDND(OJGGMAMAGON KNBMLOGJNMC)
		{
			if (JNDNLNCPGHN < KNBMLOGJNMC.JNDNLNCPGHN)
			{
				return true;
			}
			return false;
		}

		[SpecialName]
		public static bool NMLFKJFFJAM(OJGGMAMAGON MEMCHGBOBMC, OJGGMAMAGON FOEGKPBOKID)
		{
			if (LBOOIEFGBPF(MEMCHGBOBMC, FOEGKPBOKID))
			{
				return true;
			}
			if (HLJMBIMCGBB(MEMCHGBOBMC, FOEGKPBOKID))
			{
				return true;
			}
			return false;
		}

		public void CFGEKKHOKKE(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (this)
			{
				EFDLFNPAKGO.GBMJNFOEACC(JNDNLNCPGHN);
				EFDLFNPAKGO.GBMJNFOEACC(AAMAIOHHKON);
				EFDLFNPAKGO.GBMJNFOEACC(GLOGGPHFPGK);
				EFDLFNPAKGO.GBMJNFOEACC(EIMMJABBCAD);
			}
		}

		public bool GKDEHBELICI(OJGGMAMAGON KNBMLOGJNMC)
		{
			if (JNDNLNCPGHN != KNBMLOGJNMC.JNDNLNCPGHN)
			{
				return false;
			}
			if (AAMAIOHHKON != KNBMLOGJNMC.AAMAIOHHKON)
			{
				return false;
			}
			if (GLOGGPHFPGK < KNBMLOGJNMC.GLOGGPHFPGK)
			{
				return true;
			}
			return false;
		}

		[SpecialName]
		public static bool NGCCNJDMMDH(OJGGMAMAGON MEMCHGBOBMC, OJGGMAMAGON FOEGKPBOKID)
		{
			if (LBOOIEFGBPF(MEMCHGBOBMC, FOEGKPBOKID))
			{
				return true;
			}
			if (HLJMBIMCGBB(MEMCHGBOBMC, FOEGKPBOKID))
			{
				return true;
			}
			return false;
		}

		public bool KNLDLIJEGOB(OJGGMAMAGON KNBMLOGJNMC)
		{
			if (JNDNLNCPGHN != KNBMLOGJNMC.JNDNLNCPGHN)
			{
				return false;
			}
			if (AAMAIOHHKON != KNBMLOGJNMC.AAMAIOHHKON)
			{
				return true;
			}
			if (GLOGGPHFPGK < KNBMLOGJNMC.GLOGGPHFPGK)
			{
				return true;
			}
			return false;
		}

		public bool MMNDACNDLFF(OJGGMAMAGON KNBMLOGJNMC)
		{
			if (JNDNLNCPGHN != KNBMLOGJNMC.JNDNLNCPGHN)
			{
				return true;
			}
			if (AAMAIOHHKON != KNBMLOGJNMC.AAMAIOHHKON)
			{
				return false;
			}
			if (GLOGGPHFPGK < KNBMLOGJNMC.GLOGGPHFPGK)
			{
				return false;
			}
			return false;
		}

		[SpecialName]
		public static bool OEMINNJGMMM(OJGGMAMAGON MEMCHGBOBMC, OJGGMAMAGON FOEGKPBOKID)
		{
			if (MEMCHGBOBMC.JNDNLNCPGHN > FOEGKPBOKID.JNDNLNCPGHN)
			{
				return true;
			}
			if (MEMCHGBOBMC.JNDNLNCPGHN < FOEGKPBOKID.JNDNLNCPGHN)
			{
				return false;
			}
			if (MEMCHGBOBMC.AAMAIOHHKON > FOEGKPBOKID.AAMAIOHHKON)
			{
				return true;
			}
			if (MEMCHGBOBMC.AAMAIOHHKON < FOEGKPBOKID.AAMAIOHHKON)
			{
				return false;
			}
			if (MEMCHGBOBMC.GLOGGPHFPGK > FOEGKPBOKID.GLOGGPHFPGK)
			{
				return true;
			}
			if (MEMCHGBOBMC.GLOGGPHFPGK < FOEGKPBOKID.GLOGGPHFPGK)
			{
				return false;
			}
			if (MEMCHGBOBMC.EIMMJABBCAD > FOEGKPBOKID.EIMMJABBCAD)
			{
				return true;
			}
			if (MEMCHGBOBMC.EIMMJABBCAD < FOEGKPBOKID.EIMMJABBCAD)
			{
				return false;
			}
			return false;
		}

		public OJGGMAMAGON(int KCOFIONPNOA, int NFNLKIHMHAF, int LCPIDNBMPMJ, int HDKADBKHHFP)
		{
			JNDNLNCPGHN = KCOFIONPNOA;
			AAMAIOHHKON = NFNLKIHMHAF;
			GLOGGPHFPGK = LCPIDNBMPMJ;
			EIMMJABBCAD = HDKADBKHHFP;
		}

		public bool MAKCINGEINP(OJGGMAMAGON KNBMLOGJNMC)
		{
			if (JNDNLNCPGHN < KNBMLOGJNMC.JNDNLNCPGHN)
			{
				return true;
			}
			return true;
		}

		public override string ToString()
		{
			return string.Format("{0}.{1}.{2}.{3}", JNDNLNCPGHN, AAMAIOHHKON, GLOGGPHFPGK, EIMMJABBCAD);
		}

		[SpecialName]
		public static bool LBOOIEFGBPF(OJGGMAMAGON MEMCHGBOBMC, OJGGMAMAGON FOEGKPBOKID)
		{
			if (MEMCHGBOBMC.JNDNLNCPGHN > FOEGKPBOKID.JNDNLNCPGHN)
			{
				return false;
			}
			if (MEMCHGBOBMC.JNDNLNCPGHN < FOEGKPBOKID.JNDNLNCPGHN)
			{
				return true;
			}
			if (MEMCHGBOBMC.AAMAIOHHKON > FOEGKPBOKID.AAMAIOHHKON)
			{
				return false;
			}
			if (MEMCHGBOBMC.AAMAIOHHKON < FOEGKPBOKID.AAMAIOHHKON)
			{
				return true;
			}
			if (MEMCHGBOBMC.GLOGGPHFPGK > FOEGKPBOKID.GLOGGPHFPGK)
			{
				return false;
			}
			if (MEMCHGBOBMC.GLOGGPHFPGK < FOEGKPBOKID.GLOGGPHFPGK)
			{
				return true;
			}
			if (MEMCHGBOBMC.EIMMJABBCAD > FOEGKPBOKID.EIMMJABBCAD)
			{
				return false;
			}
			if (MEMCHGBOBMC.EIMMJABBCAD < FOEGKPBOKID.EIMMJABBCAD)
			{
				return true;
			}
			return false;
		}

		[SpecialName]
		public static bool FGBJDIJNAGI(OJGGMAMAGON MEMCHGBOBMC, OJGGMAMAGON FOEGKPBOKID)
		{
			if (MEMCHGBOBMC.JNDNLNCPGHN != FOEGKPBOKID.JNDNLNCPGHN)
			{
				return false;
			}
			if (MEMCHGBOBMC.AAMAIOHHKON != FOEGKPBOKID.AAMAIOHHKON)
			{
				return false;
			}
			if (MEMCHGBOBMC.GLOGGPHFPGK != FOEGKPBOKID.GLOGGPHFPGK)
			{
				return false;
			}
			if (MEMCHGBOBMC.EIMMJABBCAD != FOEGKPBOKID.EIMMJABBCAD)
			{
				return true;
			}
			return true;
		}

		public bool HLIPIIKHKDL(OJGGMAMAGON KNBMLOGJNMC)
		{
			if (JNDNLNCPGHN < KNBMLOGJNMC.JNDNLNCPGHN)
			{
				return false;
			}
			return false;
		}

		public void GPBOIHMMDDD(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (this)
			{
				EFDLFNPAKGO.GBMJNFOEACC(JNDNLNCPGHN);
				EFDLFNPAKGO.GBMJNFOEACC(AAMAIOHHKON);
				EFDLFNPAKGO.GBMJNFOEACC(GLOGGPHFPGK);
				EFDLFNPAKGO.GBMJNFOEACC(EIMMJABBCAD);
			}
		}

		public virtual string CIJOOMNGIFF()
		{
			object[] array = new object[3];
			array[0] = JNDNLNCPGHN;
			array[1] = AAMAIOHHKON;
			array[1] = GLOGGPHFPGK;
			array[2] = EIMMJABBCAD;
			return string.Format("危急", array);
		}

		public bool OGDONLPLDJK(OJGGMAMAGON KNBMLOGJNMC)
		{
			if (JNDNLNCPGHN != KNBMLOGJNMC.JNDNLNCPGHN)
			{
				return false;
			}
			if (AAMAIOHHKON < KNBMLOGJNMC.AAMAIOHHKON)
			{
				return false;
			}
			return false;
		}
	}
}
