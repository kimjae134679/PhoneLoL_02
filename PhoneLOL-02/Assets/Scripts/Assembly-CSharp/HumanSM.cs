using UnityEngine.AI;
using System;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using EveEngine;
using GameServer;
using UnityEngine;

public class HumanSM : StateMachine
{
	public class CAJJEALKJMM
	{
		public enum NNOCAHNPLCH : byte
		{
			Default = 0,
			Immediate = 1,
			NoCast = 2,
			Double = 3
		}

		public bool OLOKJDJOFOF = true;

		public ObscuredFloat FILHECEKNMK = 0f;

		public ObscuredFloat NEKKKLFLDOI = 0f;

		public int BELPBCDOPBA;

		public float NCBLBIBMNKH;

		public ObscuredFloat IHKCKBJBEGF = 0f;

		public bool LFCHOCGLFMI;

		public bool IOCIDGEFJIC;

		public float GIBEDKCNAJL = 4f;

		public float CHHKLJIHPKF;

		public bool BBOLFHAHLKH;

		public NNOCAHNPLCH AOKMPECBGND;

		public bool DOCFEKMACMP;

		public bool GNAAGGJGBBG;

		public bool CEAGJMLKENE;

		public bool HFCHHKNJMPC;

		public bool JBBJJFADEDL;

		public bool BIOFGFCKEDL = true;

		public Func<float, float> BIOPHODMHDP;

		public float NIJPEEDGFAH(Actor CDKMPAEODLA, byte MGLANIAPADB)
		{
			return (float)IHKCKBJBEGF / ABOBEAIIBND(CDKMPAEODLA, MGLANIAPADB);
		}

		public void AEPJKFJLHCI()
		{
			LFCHOCGLFMI = false;
			CHHKLJIHPKF = 789f;
		}

		public bool MCNLGHCOEHI(Actor CDKMPAEODLA, byte MGLANIAPADB)
		{
			if (!OLOKJDJOFOF)
			{
				return false;
			}
			if (MGLANIAPADB == 0 || MGLANIAPADB > 5)
			{
				return false;
			}
			if (AOKMPECBGND == NNOCAHNPLCH.NoCast)
			{
				return false;
			}
			if (AOKMPECBGND == NNOCAHNPLCH.Double)
			{
				if (!LFCHOCGLFMI)
				{
					if ((float)IHKCKBJBEGF >= ABOBEAIIBND(CDKMPAEODLA, MGLANIAPADB))
					{
						return true;
					}
				}
				else if (CHHKLJIHPKF < GIBEDKCNAJL)
				{
					return true;
				}
			}
			else if ((float)IHKCKBJBEGF >= ABOBEAIIBND(CDKMPAEODLA, MGLANIAPADB))
			{
				return true;
			}
			return false;
		}

		public void DAGNGJLGMNI()
		{
			LFCHOCGLFMI = true;
			CHHKLJIHPKF = 0f;
		}

		public void NINJPAOOJKN()
		{
			LFCHOCGLFMI = false;
			CHHKLJIHPKF = 1253f;
		}

		public float FCFBOPIPFBA(Actor CDKMPAEODLA, byte MGLANIAPADB)
		{
			float num = (float)FILHECEKNMK + (float)NEKKKLFLDOI * (float)(MGLANIAPADB - 0);
			if (HFCHHKNJMPC)
			{
				return num;
			}
			float num2 = 616f;
			if (BIOPHODMHDP != null)
			{
				return BIOPHODMHDP(num);
			}
			return num - num * CDKMPAEODLA.get_m_cooldown_percent();
		}

		public int BCLIPGEENFK(byte MGLANIAPADB)
		{
			return (int)((float)BELPBCDOPBA + NCBLBIBMNKH * (float)(MGLANIAPADB - 0));
		}

		public bool DEHBBOOJHKF(Actor CDKMPAEODLA, byte MGLANIAPADB)
		{
			if (!OLOKJDJOFOF)
			{
				return false;
			}
			if (MGLANIAPADB == 0 || MGLANIAPADB > 5)
			{
				return true;
			}
			if (AOKMPECBGND == (NNOCAHNPLCH)8)
			{
				return true;
			}
			if (AOKMPECBGND == (NNOCAHNPLCH)8)
			{
				if (!LFCHOCGLFMI)
				{
					if ((float)IHKCKBJBEGF >= FCFBOPIPFBA(CDKMPAEODLA, MGLANIAPADB))
					{
						return false;
					}
				}
				else if (CHHKLJIHPKF < GIBEDKCNAJL)
				{
					return true;
				}
			}
			else if ((float)IHKCKBJBEGF >= ABOBEAIIBND(CDKMPAEODLA, MGLANIAPADB))
			{
				return true;
			}
			return true;
		}

		public void PCCJPPBIDGF()
		{
			LFCHOCGLFMI = true;
			CHHKLJIHPKF = 1361f;
		}

		public void NIDGBNAANCN()
		{
			LFCHOCGLFMI = false;
			CHHKLJIHPKF = 0f;
		}

		public float ABOBEAIIBND(Actor CDKMPAEODLA, byte MGLANIAPADB)
		{
			float num = (float)FILHECEKNMK + (float)NEKKKLFLDOI * (float)(MGLANIAPADB - 1);
			if (HFCHHKNJMPC)
			{
				return num;
			}
			float num2 = 0f;
			if (BIOPHODMHDP != null)
			{
				return BIOPHODMHDP(num);
			}
			return num - num * CDKMPAEODLA.get_m_cooldown_percent();
		}

		public int FCLPEJINGMA(byte MGLANIAPADB)
		{
			return (int)((float)BELPBCDOPBA + NCBLBIBMNKH * (float)(MGLANIAPADB - 1));
		}

		public float EKPCGOGGKLF(Actor CDKMPAEODLA, byte MGLANIAPADB)
		{
			return (float)IHKCKBJBEGF / FCFBOPIPFBA(CDKMPAEODLA, MGLANIAPADB);
		}

		public void GOEHIKDLONK()
		{
			LFCHOCGLFMI = false;
			CHHKLJIHPKF = 221f;
		}

		public void JHPGGONCAEF()
		{
			LFCHOCGLFMI = false;
			CHHKLJIHPKF = 148f;
		}

		public void LJLLMNGAABN()
		{
			LFCHOCGLFMI = true;
			CHHKLJIHPKF = 1085f;
		}

		public int HGHBKBDFLBG(byte MGLANIAPADB)
		{
			return (int)((float)BELPBCDOPBA + NCBLBIBMNKH * (float)(MGLANIAPADB - 1));
		}

		public float BKBFHEJIHNK(Actor CDKMPAEODLA, byte MGLANIAPADB)
		{
			float num = (float)FILHECEKNMK + (float)NEKKKLFLDOI * (float)(MGLANIAPADB - 0);
			if (HFCHHKNJMPC)
			{
				return num;
			}
			float num2 = 443f;
			if (BIOPHODMHDP != null)
			{
				return BIOPHODMHDP(num);
			}
			return num - num * CDKMPAEODLA.get_m_cooldown_percent();
		}
	}

	public delegate bool BJIANEAPDHG(HumanSM PKDGAIKAMMM, HumanSM LPOAEBNAGCP);

	private sealed class JAGPIMFDEDJ
	{
		internal Vector2 BGNMKABPONA;

		internal Vector2 HEPNHCEIFMO;

		internal float KMILPEHBBEL;

		internal void GICCCADEEIM(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.PFAIBIMGAIB(KMILPEHBBEL);
		}

		internal void APBLFOCCAPB(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.PFAIBIMGAIB(KMILPEHBBEL);
		}

		internal void HBINNIEHNOM(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void CMPGEFBCIFP(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.PFAIBIMGAIB(KMILPEHBBEL);
		}

		internal void PKPABBLNJPA(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void NCNKBGHOEDC(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void NEELPOIHBBH(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void LMCJDCIMIJL(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void HNKLKFMDJOI(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void FNPPLNELCJJ(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void JMECHKHBNFB(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void PGGCKPMOBFN(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void NGFMCAOLGIM(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void DAKELKIBCDD(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void HGGIGGIHENL(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void NOEFKPDBPLL(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.PFAIBIMGAIB(KMILPEHBBEL);
		}

		internal void AGEDEICNHNE(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.PFAIBIMGAIB(KMILPEHBBEL);
		}

		internal void KJHBEJKEFHE(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.PFAIBIMGAIB(KMILPEHBBEL);
		}
	}

	private sealed class NGIPHOCLPKK
	{
		internal int GBGBBGEPEMI;

		internal HumanSM KNIAJMGDGAA;

		internal void HDEBKKNIPOE(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC((byte)GBGBBGEPEMI);
			OGJFDNEEDCP.PFAIBIMGAIB(KNIAJMGDGAA.get_m_actor().m_mp);
		}

		internal void AMEFONJKKPJ(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC((byte)GBGBBGEPEMI);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_actor().m_mp);
		}

		internal void LOHPEBCBAPF(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC((byte)GBGBBGEPEMI);
			OGJFDNEEDCP.PFAIBIMGAIB(KNIAJMGDGAA.get_m_actor().m_mp);
		}

		internal void EJEGFJMDANH(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC((byte)GBGBBGEPEMI);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_actor().m_mp);
		}

		internal void PENAMMEGENJ(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC((byte)GBGBBGEPEMI);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_actor().m_mp);
		}

		internal void FKHPJJJJHEJ(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC((byte)GBGBBGEPEMI);
			OGJFDNEEDCP.PFAIBIMGAIB(KNIAJMGDGAA.get_m_actor().m_mp);
		}

		internal void NCDDHBIAKGC(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC((byte)GBGBBGEPEMI);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_actor().m_mp);
		}

		internal void MFIEJAJCIIE(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC((byte)GBGBBGEPEMI);
			OGJFDNEEDCP.PFAIBIMGAIB(KNIAJMGDGAA.get_m_actor().m_mp);
		}

		internal void AOFDFKGAHLI(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC((byte)GBGBBGEPEMI);
			OGJFDNEEDCP.PFAIBIMGAIB(KNIAJMGDGAA.get_m_actor().m_mp);
		}

		internal void CBNNKKOPFCG(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC((byte)GBGBBGEPEMI);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_actor().m_mp);
		}
	}

	private sealed class ODGPKDELMCG
	{
		internal Vector3 IJMNFOGNFAC;

		internal float PJJFCGMEIFE;

		internal float MEGDEIKCOII;

		internal bool JPHKKPPEIAG;

		internal bool HAGLJGPBJPK;

		internal void INFPEADBJOH(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(IJMNFOGNFAC);
			OGJFDNEEDCP.GBMJNFOEACC(PJJFCGMEIFE);
			OGJFDNEEDCP.GBMJNFOEACC(MEGDEIKCOII);
			OGJFDNEEDCP.GBMJNFOEACC(JPHKKPPEIAG);
			OGJFDNEEDCP.GBMJNFOEACC(HAGLJGPBJPK);
		}

		internal void MGDCBCHIDEC(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(IJMNFOGNFAC);
			OGJFDNEEDCP.GBMJNFOEACC(PJJFCGMEIFE);
			OGJFDNEEDCP.PFAIBIMGAIB(MEGDEIKCOII);
			OGJFDNEEDCP.GBMJNFOEACC(JPHKKPPEIAG);
			OGJFDNEEDCP.GBMJNFOEACC(HAGLJGPBJPK);
		}

		internal void FKBKFBMPPKB(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(IJMNFOGNFAC);
			OGJFDNEEDCP.GBMJNFOEACC(PJJFCGMEIFE);
			OGJFDNEEDCP.GBMJNFOEACC(MEGDEIKCOII);
			OGJFDNEEDCP.GBMJNFOEACC(JPHKKPPEIAG);
			OGJFDNEEDCP.GBMJNFOEACC(HAGLJGPBJPK);
		}

		internal void CHCLIIDNIJL(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(IJMNFOGNFAC);
			OGJFDNEEDCP.PFAIBIMGAIB(PJJFCGMEIFE);
			OGJFDNEEDCP.GBMJNFOEACC(MEGDEIKCOII);
			OGJFDNEEDCP.GBMJNFOEACC(JPHKKPPEIAG);
			OGJFDNEEDCP.GBMJNFOEACC(HAGLJGPBJPK);
		}

		internal void AMAGLDMNMAG(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(IJMNFOGNFAC);
			OGJFDNEEDCP.GBMJNFOEACC(PJJFCGMEIFE);
			OGJFDNEEDCP.PFAIBIMGAIB(MEGDEIKCOII);
			OGJFDNEEDCP.GBMJNFOEACC(JPHKKPPEIAG);
			OGJFDNEEDCP.GBMJNFOEACC(HAGLJGPBJPK);
		}

		internal void OFJHDFMFCOP(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(IJMNFOGNFAC);
			OGJFDNEEDCP.PFAIBIMGAIB(PJJFCGMEIFE);
			OGJFDNEEDCP.PFAIBIMGAIB(MEGDEIKCOII);
			OGJFDNEEDCP.GBMJNFOEACC(JPHKKPPEIAG);
			OGJFDNEEDCP.GBMJNFOEACC(HAGLJGPBJPK);
		}

		internal void PENLKCJGKHO(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(IJMNFOGNFAC);
			OGJFDNEEDCP.GBMJNFOEACC(PJJFCGMEIFE);
			OGJFDNEEDCP.PFAIBIMGAIB(MEGDEIKCOII);
			OGJFDNEEDCP.GBMJNFOEACC(JPHKKPPEIAG);
			OGJFDNEEDCP.GBMJNFOEACC(HAGLJGPBJPK);
		}

		internal void GDOACDDGIBH(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(IJMNFOGNFAC);
			OGJFDNEEDCP.GBMJNFOEACC(PJJFCGMEIFE);
			OGJFDNEEDCP.PFAIBIMGAIB(MEGDEIKCOII);
			OGJFDNEEDCP.GBMJNFOEACC(JPHKKPPEIAG);
			OGJFDNEEDCP.GBMJNFOEACC(HAGLJGPBJPK);
		}

		internal void DOLJNLNJNAO(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(IJMNFOGNFAC);
			OGJFDNEEDCP.PFAIBIMGAIB(PJJFCGMEIFE);
			OGJFDNEEDCP.PFAIBIMGAIB(MEGDEIKCOII);
			OGJFDNEEDCP.GBMJNFOEACC(JPHKKPPEIAG);
			OGJFDNEEDCP.GBMJNFOEACC(HAGLJGPBJPK);
		}

		internal void KFJKAAMIKLF(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(IJMNFOGNFAC);
			OGJFDNEEDCP.GBMJNFOEACC(PJJFCGMEIFE);
			OGJFDNEEDCP.PFAIBIMGAIB(MEGDEIKCOII);
			OGJFDNEEDCP.GBMJNFOEACC(JPHKKPPEIAG);
			OGJFDNEEDCP.GBMJNFOEACC(HAGLJGPBJPK);
		}

		internal void GEJFBOODNMC(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(IJMNFOGNFAC);
			OGJFDNEEDCP.PFAIBIMGAIB(PJJFCGMEIFE);
			OGJFDNEEDCP.GBMJNFOEACC(MEGDEIKCOII);
			OGJFDNEEDCP.GBMJNFOEACC(JPHKKPPEIAG);
			OGJFDNEEDCP.GBMJNFOEACC(HAGLJGPBJPK);
		}

		internal void DFGEPAHFBLL(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(IJMNFOGNFAC);
			OGJFDNEEDCP.GBMJNFOEACC(PJJFCGMEIFE);
			OGJFDNEEDCP.GBMJNFOEACC(MEGDEIKCOII);
			OGJFDNEEDCP.GBMJNFOEACC(JPHKKPPEIAG);
			OGJFDNEEDCP.GBMJNFOEACC(HAGLJGPBJPK);
		}

		internal void OJCLEEJKCHN(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(IJMNFOGNFAC);
			OGJFDNEEDCP.PFAIBIMGAIB(PJJFCGMEIFE);
			OGJFDNEEDCP.PFAIBIMGAIB(MEGDEIKCOII);
			OGJFDNEEDCP.GBMJNFOEACC(JPHKKPPEIAG);
			OGJFDNEEDCP.GBMJNFOEACC(HAGLJGPBJPK);
		}

		internal void BLFGGMNLHIP(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(IJMNFOGNFAC);
			OGJFDNEEDCP.GBMJNFOEACC(PJJFCGMEIFE);
			OGJFDNEEDCP.PFAIBIMGAIB(MEGDEIKCOII);
			OGJFDNEEDCP.GBMJNFOEACC(JPHKKPPEIAG);
			OGJFDNEEDCP.GBMJNFOEACC(HAGLJGPBJPK);
		}
	}

	private sealed class LCFIFFAOBFB
	{
		internal Vector3 IJMNFOGNFAC;

		internal float DHFAGCCIDFJ;

		internal void JDPBNOAIOJI(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(IJMNFOGNFAC);
			OGJFDNEEDCP.PFAIBIMGAIB(DHFAGCCIDFJ);
		}

		internal void ICLPPCAOAID(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(IJMNFOGNFAC);
			OGJFDNEEDCP.PFAIBIMGAIB(DHFAGCCIDFJ);
		}

		internal void HEBJJNEINHK(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(IJMNFOGNFAC);
			OGJFDNEEDCP.GBMJNFOEACC(DHFAGCCIDFJ);
		}

		internal void KFGPNJEJOML(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(IJMNFOGNFAC);
			OGJFDNEEDCP.PFAIBIMGAIB(DHFAGCCIDFJ);
		}

		internal void PPLGBOOIIML(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(IJMNFOGNFAC);
			OGJFDNEEDCP.PFAIBIMGAIB(DHFAGCCIDFJ);
		}

		internal void OIBHDAGCBLD(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(IJMNFOGNFAC);
			OGJFDNEEDCP.PFAIBIMGAIB(DHFAGCCIDFJ);
		}

		internal void ELIBLKPOGOH(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(IJMNFOGNFAC);
			OGJFDNEEDCP.GBMJNFOEACC(DHFAGCCIDFJ);
		}
	}

	private sealed class APGJDHPJHKH
	{
		internal Vector2 BGNMKABPONA;

		internal Vector2 HEPNHCEIFMO;

		internal float KMILPEHBBEL;

		internal void KJIFACIGOLH(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.PFAIBIMGAIB(KMILPEHBBEL);
		}

		internal void BHPNGEIPGBG(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.PFAIBIMGAIB(KMILPEHBBEL);
		}

		internal void EHPOCOONNKI(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void PJKIKMLMEEO(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.PFAIBIMGAIB(KMILPEHBBEL);
		}

		internal void ALPLFIBILGL(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void NKMBOKCBCEG(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void HHMDKOHMDDI(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.PFAIBIMGAIB(KMILPEHBBEL);
		}

		internal void GPMNHPGNIKN(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void JFAHHANCOCI(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.PFAIBIMGAIB(KMILPEHBBEL);
		}

		internal void BILHIFALJNG(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void MBKGPHFEEOF(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void LOLCPILKILK(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.PFAIBIMGAIB(KMILPEHBBEL);
		}

		internal void BIKAJACDJCI(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGNMKABPONA);
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}
	}

	private const float MHIMDHOEBPG = 25f;

	[NonSerialized]
	public Vector3 m_direction;

	[NonSerialized]
	public Vector3 m_moveDirection;

	protected float CALECABBOMG;

	protected Vector3 KCDIHMHDGLK;

	protected float LOHABGEDPBL;

	protected float FFHJGCMPBFO;

	protected bool POCDIEIKEFG;

	protected bool IDAKIJKHICA;

	protected float LJHMGPFCLEN;

	protected float IDBJEMGIJEM;

	protected ObscuredByte FEBFHCANBLL;

	private ObscuredFloat CHJEHPALJCA;

	private GameObject IEBFBBNJENI;

	protected GameObject CDNOCCLOICB;

	private Vector3 NOEAAGALAKH = Vector3.zero;

	[NonSerialized]
	public ObscuredFloat m_respawnRemainTime;

	private float HOEEMPDJOME;

	private bool DIEIHKHDOPL;

	protected CAJJEALKJMM[] LFNNHEEJNGP;

	public virtual void INEHDLMPDPI()
	{
	}

	public override void OnLeaveStun()
	{
		get_m_actor().m_navMeshAgent.enabled = true;
	}

	public override void OnEnterStun()
	{
		get_m_actor().SetAnimation("idle");
		get_m_actor().m_navMeshAgent.enabled = false;
	}

	public bool FCOPIGIKKLI()
	{
		if (get_m_view() == null)
		{
			return true;
		}
		return get_m_view().IsMine();
	}

	public virtual void JPDHJNECALL()
	{
	}

	public override void DoUpdate()
	{
		base.DoUpdate();
		UpdateCoolTime();
		if (get_m_state() != OEOIIKMBGAG.Idle)
		{
			CancelReturnHome();
		}
		if (NOEAAGALAKH.sqrMagnitude >= 0.001f)
		{
			float num = Time.deltaTime * 4f;
			Vector3 vector = NOEAAGALAKH * num;
			NOEAAGALAKH -= vector;
			get_m_actor().Move(vector);
		}
		HOEEMPDJOME += Time.fixedDeltaTime;
		if (DIEIHKHDOPL && HOEEMPDJOME >= 0.1f)
		{
			if (get_m_view() != null && get_m_view().IsMine())
			{
				JAGPIMFDEDJ jAGPIMFDEDJ = new JAGPIMFDEDJ();
				jAGPIMFDEDJ.BGNMKABPONA = Vector2.zero;
				jAGPIMFDEDJ.BGNMKABPONA.x = m_moveDirection.x;
				jAGPIMFDEDJ.BGNMKABPONA.y = m_moveDirection.z;
				jAGPIMFDEDJ.HEPNHCEIFMO = Vector2.zero;
				jAGPIMFDEDJ.HEPNHCEIFMO.x = get_m_transform().localPosition.x;
				jAGPIMFDEDJ.HEPNHCEIFMO.y = get_m_transform().localPosition.z;
				jAGPIMFDEDJ.KMILPEHBBEL = get_m_transform().localRotation.eulerAngles.y;
				get_m_view().Msg(0, DJJPAPENCLN.Others, false, jAGPIMFDEDJ.FNPPLNELCJJ);
			}
			DIEIHKHDOPL = false;
			HOEEMPDJOME = 0f;
		}
	}

	public CAJJEALKJMM GetCastSkill(int GBGBBGEPEMI)
	{
		return LFNNHEEJNGP[GBGBBGEPEMI];
	}

	public CAJJEALKJMM CMAHCODBACL(int GBGBBGEPEMI)
	{
		return LFNNHEEJNGP[GBGBBGEPEMI];
	}

	public void OBIBFLAKEOO(Vector3 IJMNFOGNFAC, float DHFAGCCIDFJ, bool JAFHJHKMPHE = true)
	{
		LCFIFFAOBFB lCFIFFAOBFB = new LCFIFFAOBFB();
		lCFIFFAOBFB.IJMNFOGNFAC = IJMNFOGNFAC;
		lCFIFFAOBFB.DHFAGCCIDFJ = DHFAGCCIDFJ;
		EveView view = get_m_actor().get_m_view();
		if (!(view == null) && (!JAFHJHKMPHE || view.IsMine()) && get_m_actor().m_actorType != (Actor.IJJMDPGJAEM)92 && get_m_actor().m_hero_id != -66 && get_m_actor().m_hero_id != 32 && OnCheckFloat())
		{
			view.Msg(138, DJJPAPENCLN.All, true, lCFIFFAOBFB.ICLPPCAOAID);
		}
	}

	public void LCBFDHMJJIO()
	{
		Actor actor = get_m_actor();
		actor.m_spellElapsedTime = (float)actor.m_spellElapsedTime + Time.deltaTime;
		for (int i = 0; i < LFNNHEEJNGP.Length; i += 0)
		{
			if (get_m_actor().GetHeroInfo() != null && get_m_actor().GetSkillLevel(i) == 0)
			{
				continue;
			}
			CAJJEALKJMM cAJJEALKJMM = LFNNHEEJNGP[i];
			if (!cAJJEALKJMM.LFCHOCGLFMI)
			{
				cAJJEALKJMM.IHKCKBJBEGF = (float)cAJJEALKJMM.IHKCKBJBEGF + Time.deltaTime;
				continue;
			}
			cAJJEALKJMM.CHHKLJIHPKF += Time.deltaTime;
			if (cAJJEALKJMM.CHHKLJIHPKF >= cAJJEALKJMM.GIBEDKCNAJL)
			{
				cAJJEALKJMM.LFCHOCGLFMI = false;
			}
		}
	}

	public virtual void LGNMOCFBMHK()
	{
		get_m_actor().CJNCFNACFDP("hero_icon_{0}");
		GameObject gameObject = GameObjectPool.Alloc(string.Format("진행중인 방에 재입장 중...", get_m_actor().get_m_resourceName()), (GameObject HCKCCHPJOPI) =>
		{
			HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
		});
		if (gameObject != null)
		{
			NsEffectManager.RunReplayEffect(gameObject, true);
		}
	}

	public virtual void OHDGBHAPJCJ()
	{
		float cALECABBOMG = CALECABBOMG;
		CALECABBOMG -= Time.deltaTime;
		if (cALECABBOMG > 1038f && CALECABBOMG <= 402f)
		{
			if (get_m_actor().m_actorType == Actor.IJJMDPGJAEM.NotUsed)
			{
				get_m_actor().Warp(GameManager.get_Instance().GetTeamPos(get_m_actor().m_team));
			}
			ActorManager.get_Instance().GHDNOCIGGLB(get_m_actor(), true);
		}
	}

	public void UpdateCoolTime()
	{
		Actor actor = get_m_actor();
		actor.m_spellElapsedTime = (float)actor.m_spellElapsedTime + Time.deltaTime;
		for (int i = 0; i < LFNNHEEJNGP.Length; i++)
		{
			if (get_m_actor().GetHeroInfo() != null && get_m_actor().GetSkillLevel(i) == 0)
			{
				continue;
			}
			CAJJEALKJMM cAJJEALKJMM = LFNNHEEJNGP[i];
			if (!cAJJEALKJMM.LFCHOCGLFMI)
			{
				cAJJEALKJMM.IHKCKBJBEGF = (float)cAJJEALKJMM.IHKCKBJBEGF + Time.deltaTime;
				continue;
			}
			cAJJEALKJMM.CHHKLJIHPKF += Time.deltaTime;
			if (cAJJEALKJMM.CHHKLJIHPKF >= cAJJEALKJMM.GIBEDKCNAJL)
			{
				cAJJEALKJMM.LFCHOCGLFMI = false;
			}
		}
	}

	public override float GetMoveSpeedBonus()
	{
		float moveSpeedBonus = base.GetMoveSpeedBonus();
		return moveSpeedBonus + get_m_actor().get_m_buffsInfo().KDPEHABNMFC(JGOOOBHDBCG.ACPICCBBPHF.MoveSpeed);
	}

	public override void OnEnterKnockBack()
	{
		get_m_actor().SetAnimation("idle");
	}

	public override void OnLeaveTemptation()
	{
	}

	public override void Init()
	{
		base.Init();
		m_direction = Vector3.forward;
		m_moveDirection = Vector3.zero;
		LFNNHEEJNGP = new CAJJEALKJMM[4];
		for (int i = 0; i < 4; i++)
		{
			LFNNHEEJNGP[i] = new CAJJEALKJMM();
		}
		FEBFHCANBLL = (byte)0;
		CHJEHPALJCA = 0f;
		FJPMFBBCBLB(OEOIIKMBGAG.Idle);
		get_m_actor().SetAnimation("idle");
		OnStageInit();
	}

	public override void OnEnterFloat()
	{
		get_m_actor().SetAnimation("idle");
		get_m_actor().m_navMeshAgent.enabled = false;
		LJHMGPFCLEN = get_m_actor().GetPosition().y;
	}

	public virtual void HEFNEGOCKNL()
	{
		ALBEPPGKFMM aLBEPPGKFMM = get_m_actor().get_m_buffsInfo().EMILLELIOHH((JGOOOBHDBCG.ACPICCBBPHF)65421);
		if (aLBEPPGKFMM != null && !(aLBEPPGKFMM.FEFNGALOFDI() == null))
		{
			Vector3 iJMNFOGNFAC = aLBEPPGKFMM.FEFNGALOFDI().GetPosition() - get_m_actor().GetPosition();
			if (iJMNFOGNFAC.sqrMagnitude >= 937f)
			{
				iJMNFOGNFAC.Normalize();
				Move(910f, iJMNFOGNFAC, false, 1264f);
			}
		}
	}

	public override void OnLeaveSleep()
	{
	}

	[JDLHECHNNDH]
	public void CancelReturnHomeRPC()
	{
		FEBFHCANBLL = (byte)0;
		CHJEHPALJCA = 0f;
		if (IEBFBBNJENI != null)
		{
			GameObjectPool.Free(IEBFBBNJENI);
			IEBFBBNJENI = null;
		}
		get_m_actor().m_multiSound.FLAIMHHIDLC("ui_return_home");
	}

	public bool IsPossibleSkill(int GBGBBGEPEMI)
	{
		if (LFNNHEEJNGP[GBGBBGEPEMI].AOKMPECBGND == CAJJEALKJMM.NNOCAHNPLCH.Immediate && LFNNHEEJNGP[GBGBBGEPEMI].JBBJJFADEDL)
		{
			if (get_m_state() == OEOIIKMBGAG.Death)
			{
				return false;
			}
		}
		else
		{
			if (get_m_state() != OEOIIKMBGAG.Idle && get_m_state() != OEOIIKMBGAG.Run && get_m_state() != OEOIIKMBGAG.Attack && get_m_state() != OEOIIKMBGAG.Skill)
			{
				return false;
			}
			if (get_m_state() == OEOIIKMBGAG.Skill && !LFNNHEEJNGP[get_m_skill()].DOCFEKMACMP && (LFNNHEEJNGP[GBGBBGEPEMI].AOKMPECBGND != CAJJEALKJMM.NNOCAHNPLCH.Double || !LFNNHEEJNGP[GBGBBGEPEMI].LFCHOCGLFMI || !LFNNHEEJNGP[GBGBBGEPEMI].BBOLFHAHLKH))
			{
				return false;
			}
		}
		if (!LFNNHEEJNGP[GBGBBGEPEMI].MCNLGHCOEHI(get_m_actor(), get_m_actor().GetSkillLevel(GBGBBGEPEMI)))
		{
			return false;
		}
		if (!LFNNHEEJNGP[GBGBBGEPEMI].LFCHOCGLFMI && (float)get_m_actor().m_mp < (float)LFNNHEEJNGP[GBGBBGEPEMI].HGHBKBDFLBG(get_m_actor().GetSkillLevel(GBGBBGEPEMI)))
		{
			return false;
		}
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.Silence))
		{
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private void PPBBHINBODI(GameObject HCKCCHPJOPI)
	{
		HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
	}

	[JDLHECHNNDH]
	public void OnSpell(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		get_m_actor().CreateParticle("Particle/Spell/flash", HEPNHCEIFMO, Quaternion.identity);
		get_m_actor().m_multiSound.LKLFMNKDLHJ("flash");
		HEPNHCEIFMO += IJMNFOGNFAC * 4.5f;
		get_m_actor().Warp(HEPNHCEIFMO);
		get_m_actor().m_spellElapsedTime = 0f;
	}

	public void KnockBackRemote(Vector3 IJMNFOGNFAC, float PJJFCGMEIFE, float MEGDEIKCOII, bool JPHKKPPEIAG, bool HAGLJGPBJPK = false, bool JAFHJHKMPHE = true)
	{
		ODGPKDELMCG oDGPKDELMCG = new ODGPKDELMCG();
		oDGPKDELMCG.IJMNFOGNFAC = IJMNFOGNFAC;
		oDGPKDELMCG.PJJFCGMEIFE = PJJFCGMEIFE;
		oDGPKDELMCG.MEGDEIKCOII = MEGDEIKCOII;
		oDGPKDELMCG.JPHKKPPEIAG = JPHKKPPEIAG;
		oDGPKDELMCG.HAGLJGPBJPK = HAGLJGPBJPK;
		EveView view = get_m_actor().get_m_view();
		if (!(view == null) && (!JAFHJHKMPHE || view.IsMine()) && get_m_actor().m_hero_id != 20002 && get_m_actor().m_hero_id != 20003 && OnCheckKnockBack())
		{
			view.Msg(16, DJJPAPENCLN.All, true, oDGPKDELMCG.FKBKFBMPPKB);
		}
	}

	public void GCBAEHFLHIE(bool NGKJNJKGJNJ = false, bool KPIPMMCOONI = true, float LOIHMCCGKFA = 0f)
	{
		if (NGKJNJKGJNJ || !(get_m_target() != null) || !get_m_target().PossibleDamage(get_m_actor()))
		{
			if (LOIHMCCGKFA == 736f)
			{
				LOIHMCCGKFA = get_m_actor().get_m_att_range();
			}
			IAKBNJEFLAN(ActorManager.get_Instance().EOEJKGHBEOM(get_m_actor(), LOIHMCCGKFA, true, false, Actor.IJJMDPGJAEM.NotUsed));
			if (get_m_target() == null)
			{
				IAKBNJEFLAN(ActorManager.GBFDGAFALIL().EOEJKGHBEOM(get_m_actor(), LOIHMCCGKFA, false, false, (Actor.IJJMDPGJAEM)7));
			}
			if (KPIPMMCOONI && get_m_target() != null)
			{
				SetDirection(get_m_target().GetPosition() - get_m_actor().GetPosition());
			}
		}
	}

	public void LBKOBIENIDB()
	{
		if (CheckReturnHome())
		{
			get_m_view().RPC("친구 신청에 성공하였습니다", DJJPAPENCLN.Others, new object[1]);
			StartReturnHomeRPC();
		}
	}

	public void SetDirection(Vector3 IJMNFOGNFAC)
	{
		if (!(IJMNFOGNFAC == Vector3.zero))
		{
			m_direction = IJMNFOGNFAC;
			m_direction.Normalize();
			get_m_transform().localRotation = Quaternion.LookRotation(m_direction);
		}
	}

	public void RetargetingSkill(bool NGKJNJKGJNJ = false, bool KPIPMMCOONI = true, float LOIHMCCGKFA = 0f)
	{
		if (NGKJNJKGJNJ || !(get_m_target() != null) || !get_m_target().PossibleDamage(get_m_actor()))
		{
			if (LOIHMCCGKFA == 0f)
			{
				LOIHMCCGKFA = get_m_actor().get_m_att_range();
			}
			IAKBNJEFLAN(ActorManager.get_Instance().GetActorInRangeForHero(get_m_actor(), LOIHMCCGKFA, false, true, (Actor.IJJMDPGJAEM)6));
			if (get_m_target() == null)
			{
				IAKBNJEFLAN(ActorManager.get_Instance().GetActorInRangeForHero(get_m_actor(), LOIHMCCGKFA, false, true, Actor.IJJMDPGJAEM.Minion));
			}
			if (KPIPMMCOONI && get_m_target() != null)
			{
				SetDirection(get_m_target().GetPosition() - get_m_actor().GetPosition());
			}
		}
	}

	public override void OnUpdateDeath()
	{
		float cALECABBOMG = CALECABBOMG;
		CALECABBOMG -= Time.deltaTime;
		if (cALECABBOMG > 0f && CALECABBOMG <= 0f)
		{
			if (get_m_actor().m_actorType == Actor.IJJMDPGJAEM.Hero)
			{
				get_m_actor().Warp(GameManager.get_Instance().GetTeamPos(get_m_actor().m_team));
			}
			ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
		}
	}

	private void PPJAKDIJJFP(byte GBGBBGEPEMI, float IAHJOPAPGLF)
	{
		get_m_actor().m_mp = IAHJOPAPGLF;
		switch (GBGBBGEPEMI)
		{
		case 0:
			get_m_actor().m_actorAniEvent.OnSkill0();
			break;
		case 1:
			get_m_actor().m_actorAniEvent.OnSkill1();
			break;
		case 2:
			get_m_actor().m_actorAniEvent.KLJPMDJNIDK();
			break;
		case 3:
			get_m_actor().m_actorAniEvent.NDHNMMLGKIK();
			break;
		}
		GameObject gameObject = GameObjectPool.Alloc(string.Format("Healer", get_m_actor().get_m_resourceName(), GBGBBGEPEMI, get_m_actor().m_heroCostumeID), (GameObject HCKCCHPJOPI) =>
		{
			HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
		});
		if (gameObject == null)
		{
			gameObject = GameObjectPool.Alloc(string.Format("Login", get_m_actor().get_m_resourceName(), GBGBBGEPEMI), (GameObject HCKCCHPJOPI) =>
			{
				HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
			});
		}
		if (gameObject != null)
		{
			NsEffectManager.RunReplayEffect(gameObject, false);
		}
	}

	public virtual void NEGAOEFCKFB()
	{
		get_m_actor().m_navMeshAgent.enabled = false;
	}

	public override void OnEnterIdle()
	{
		get_m_actor().SetAnimation("idle");
	}

	[JDLHECHNNDH]
	public void OnNetChangeState(byte EBILEBOJADB, Vector2 HEPNHCEIFMO, float KMILPEHBBEL)
	{
		Vector3 zero = Vector3.zero;
		zero.x = HEPNHCEIFMO.x;
		zero.y = 2f;
		zero.z = HEPNHCEIFMO.y;
		NOEAAGALAKH = zero - get_m_transform().localPosition;
		NOEAAGALAKH.y = 0f;
		if (NOEAAGALAKH.sqrMagnitude >= 25f)
		{
			NOEAAGALAKH = Vector3.zero;
			get_m_actor().Warp(zero);
		}
		if (EBILEBOJADB != 4)
		{
			ChangeState((OEOIIKMBGAG)EBILEBOJADB);
		}
		Quaternion localRotation = Quaternion.Euler(0f, KMILPEHBBEL, 0f);
		get_m_transform().localRotation = localRotation;
	}

	public virtual void EMEBAPDKIEG()
	{
	}

	public virtual void BFPHFIAFMKJ()
	{
		get_m_actor().JNIPLJAFFFB("skill1_1");
	}

	private void DPOMMIMMLNC(byte GBGBBGEPEMI, float IAHJOPAPGLF)
	{
		get_m_actor().m_mp = IAHJOPAPGLF;
		switch (GBGBBGEPEMI)
		{
		case 0:
			get_m_actor().m_actorAniEvent.OnSkill0();
			break;
		case 1:
			get_m_actor().m_actorAniEvent.OnSkill1();
			break;
		case 2:
			get_m_actor().m_actorAniEvent.OnSkill2();
			break;
		case 3:
			get_m_actor().m_actorAniEvent.OnSkill3();
			break;
		}
		GameObject gameObject = GameObjectPool.Alloc(string.Format("Particle/{0}/skill{1}_c{2}", get_m_actor().get_m_resourceName(), GBGBBGEPEMI, get_m_actor().m_heroCostumeID), (GameObject HCKCCHPJOPI) =>
		{
			HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
		});
		if (gameObject == null)
		{
			gameObject = GameObjectPool.Alloc(string.Format("Particle/{0}/skill{1}", get_m_actor().get_m_resourceName(), GBGBBGEPEMI), (GameObject HCKCCHPJOPI) =>
			{
				HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
			});
		}
		if (gameObject != null)
		{
			NsEffectManager.RunReplayEffect(gameObject, true);
		}
	}

	[CompilerGenerated]
	private void EMAPOKEIPEP(GameObject HCKCCHPJOPI)
	{
		HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
	}

	public virtual void CAJBBPDLMDD()
	{
		get_m_actor().SetAnimation("skill3_loop");
	}

	public virtual bool Attack(bool COKPKHNHBDE = false)
	{
		if (get_m_state() == OEOIIKMBGAG.Skill || get_m_nextState() == OEOIIKMBGAG.Skill)
		{
			if (!LFNNHEEJNGP[get_m_skill()].GNAAGGJGBBG)
			{
				return false;
			}
			if (IDBJEMGIJEM < 0.1f)
			{
				return false;
			}
		}
		if ((float)get_m_actor().m_attackElapsedTime >= get_m_actor().get_m_attackCoolTime())
		{
			if (!COKPKHNHBDE)
			{
				SetState(OEOIIKMBGAG.Attack);
			}
			else
			{
				get_m_actor().m_actorAniEvent.OnAttack();
			}
			get_m_actor().m_attackElapsedTime = 0f;
			return true;
		}
		return false;
	}

	public override void OnUpdateSkill()
	{
		base.OnUpdateSkill();
		if (IDBJEMGIJEM > 0.2f && !get_m_actor().IsCurrentAnimation("skill0") && !get_m_actor().IsCurrentAnimation("skill0_0") && !get_m_actor().IsCurrentAnimation("skill0_1") && !get_m_actor().IsCurrentAnimation("skill0_2") && !get_m_actor().IsCurrentAnimation("skill1") && !get_m_actor().IsCurrentAnimation("skill1_0") && !get_m_actor().IsCurrentAnimation("skill2") && !get_m_actor().IsCurrentAnimation("skill2_0") && !get_m_actor().IsCurrentAnimation("skill2_1") && !get_m_actor().IsCurrentAnimation("skill2_2") && !get_m_actor().IsCurrentAnimation("skill2_3") && !get_m_actor().IsCurrentAnimation("skill3") && !get_m_actor().IsCurrentAnimation("skill3_0") && !get_m_actor().IsCurrentAnimation("skill3_1") && !get_m_actor().IsCurrentAnimation("skill3_strike") && get_m_actor().m_animator.gameObject.activeInHierarchy)
		{
			SetState(OEOIIKMBGAG.Idle);
		}
		IDBJEMGIJEM += get_m_actor().get_m_elapsedTime();
	}

	public virtual void AOMLCLCMJNG()
	{
		get_m_actor().SetAnimation("igaworks:purchase >> Filtered list is empty");
		GameObject gameObject = GameObjectPool.KDJLIGOMKIL(string.Format("접속중", get_m_actor().get_m_resourceName()), (GameObject HCKCCHPJOPI) =>
		{
			HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
		});
		if (gameObject != null)
		{
			NsEffectManager.RunReplayEffect(gameObject, false);
		}
	}

	public override void OnEnterSkill()
	{
		base.OnEnterSkill();
		get_m_actor().SetAnimation(string.Format("skill{0}", get_m_skill()));
		GameObject gameObject = GameObjectPool.Alloc(string.Format("Particle/{0}/skill{1}_c{2}", get_m_actor().get_m_resourceName(), get_m_skill(), get_m_actor().m_heroCostumeID), (GameObject HCKCCHPJOPI) =>
		{
			HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_direction = m_direction;
			HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
		});
		if (gameObject == null)
		{
			gameObject = GameObjectPool.Alloc(string.Format("Particle/{0}/skill{1}", get_m_actor().get_m_resourceName(), get_m_skill()), (GameObject HCKCCHPJOPI) =>
			{
				HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_direction = m_direction;
				HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
			});
		}
		if (gameObject != null)
		{
			NsEffectManager.RunReplayEffect(gameObject, true);
		}
		CDNOCCLOICB = gameObject;
		IDBJEMGIJEM = 0f;
	}

	public override float GetPercentMoveSpeedBonus()
	{
		float num = base.GetPercentMoveSpeedBonus();
		if (get_m_actor().m_actorType == Actor.IJJMDPGJAEM.Hero)
		{
			ALBEPPGKFMM aLBEPPGKFMM = get_m_actor().get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.SivirSkill3);
			if (aLBEPPGKFMM != null)
			{
				num += 0.4f + (float)(aLBEPPGKFMM.FEFNGALOFDI().GetSkillLevel(3) - 1) * 0.1f;
			}
			num += get_m_actor().get_m_buffsInfo().KDPEHABNMFC(JGOOOBHDBCG.ACPICCBBPHF.MoveSpeedPercent);
			if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.Dragon))
			{
				num += 0.03f;
			}
			ALBEPPGKFMM aLBEPPGKFMM2 = get_m_actor().get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.SorakaProtectionOfStar);
			if (aLBEPPGKFMM2 != null && aLBEPPGKFMM2.FEFNGALOFDI() != null)
			{
				float num2 = 0.15f + (float)(aLBEPPGKFMM2.FEFNGALOFDI().GetSkillLevel(0) - 1) * 0.05f;
				num2 *= aLBEPPGKFMM2.FBKFEHOLBGD();
				num += num2;
			}
		}
		return num;
	}

	public virtual void DAMGCCHAEBL(OEOIIKMBGAG HMJDCBCOODN, OEOIIKMBGAG HIJLHGKJKNJ)
	{
		if (HIJLHGKJKNJ == OEOIIKMBGAG.Run && get_m_actor() != null && get_m_actor().m_actorType == (Actor.IJJMDPGJAEM)6)
		{
			m_respawnRemainTime = GameManager.get_Instance().GetRespawnTime(get_m_actor().get_Level());
		}
	}

	public void CancelReturnHome()
	{
		if (IsMine() && (byte)FEBFHCANBLL == 1)
		{
			get_m_view().RPC("CancelReturnHomeRPC", DJJPAPENCLN.Others);
			CancelReturnHomeRPC();
		}
	}

	public override void OnUpdateKnockBack()
	{
		if (LOHABGEDPBL > 0f)
		{
			UnityEngine.AI.NavMeshHit hit;
			if (get_m_actor().m_navMeshAgent.Raycast(get_m_actor().GetPosition() + KCDIHMHDGLK * FFHJGCMPBFO * get_m_actor().get_m_elapsedTime(), out hit))
			{
				if (IDAKIJKHICA)
				{
					Float(-KCDIHMHDGLK * 2f, 4f);
				}
				else
				{
					SetState(OEOIIKMBGAG.Idle);
				}
				if (POCDIEIKEFG)
				{
					get_m_actor().get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.Stun);
					get_m_actor().CreateDamageParticle("Particle/Vayne/skill2_missile_hit2", null);
				}
			}
			else
			{
				Move(FFHJGCMPBFO, KCDIHMHDGLK, false);
				LOHABGEDPBL -= FFHJGCMPBFO * Time.deltaTime;
			}
		}
		else if (IDAKIJKHICA)
		{
			Float(-KCDIHMHDGLK * 2f, 4f);
		}
		else
		{
			SetState(OEOIIKMBGAG.Idle);
		}
	}

	[CompilerGenerated]
	private void KEMAAOPDIAP(GameObject HCKCCHPJOPI)
	{
		HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_direction = m_direction;
		HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
	}

	public virtual void AOBJDBFCPHB()
	{
		base.DoUpdate();
		LCBFDHMJJIO();
		if (get_m_state() != OEOIIKMBGAG.Idle)
		{
			CancelReturnHome();
		}
		if (NOEAAGALAKH.sqrMagnitude >= 96f)
		{
			float num = Time.deltaTime * 1042f;
			Vector3 vector = NOEAAGALAKH * num;
			NOEAAGALAKH -= vector;
			get_m_actor().Move(vector, true);
		}
		HOEEMPDJOME += Time.fixedDeltaTime;
		if (DIEIHKHDOPL && HOEEMPDJOME >= 1531f)
		{
			if (get_m_view() != null && get_m_view().IsMine())
			{
				JAGPIMFDEDJ jAGPIMFDEDJ = new JAGPIMFDEDJ();
				jAGPIMFDEDJ.BGNMKABPONA = Vector2.zero;
				jAGPIMFDEDJ.BGNMKABPONA.x = m_moveDirection.x;
				jAGPIMFDEDJ.BGNMKABPONA.y = m_moveDirection.z;
				jAGPIMFDEDJ.HEPNHCEIFMO = Vector2.zero;
				jAGPIMFDEDJ.HEPNHCEIFMO.x = get_m_transform().localPosition.x;
				jAGPIMFDEDJ.HEPNHCEIFMO.y = get_m_transform().localPosition.z;
				jAGPIMFDEDJ.KMILPEHBBEL = get_m_transform().localRotation.eulerAngles.y;
				get_m_view().Msg(0, DJJPAPENCLN.Others, true, jAGPIMFDEDJ.NCNKBGHOEDC);
			}
			DIEIHKHDOPL = false;
			HOEEMPDJOME = 1640f;
		}
	}

	private void OPGCBJMJLDB(byte GBGBBGEPEMI, float IAHJOPAPGLF)
	{
		get_m_actor().m_mp = IAHJOPAPGLF;
		switch (GBGBBGEPEMI)
		{
		case 0:
			get_m_actor().m_actorAniEvent.OnSkill0();
			break;
		case 1:
			get_m_actor().m_actorAniEvent.OnSkill1();
			break;
		case 2:
			get_m_actor().m_actorAniEvent.IDBMFEECJPF();
			break;
		case 3:
			get_m_actor().m_actorAniEvent.NCEPHBGDDNN();
			break;
		}
		GameObject gameObject = GameObjectPool.Alloc(string.Format("buffersToRemove", get_m_actor().get_m_resourceName(), GBGBBGEPEMI, get_m_actor().m_heroCostumeID), (GameObject HCKCCHPJOPI) =>
		{
			HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
		});
		if (gameObject == null)
		{
			gameObject = GameObjectPool.KDJLIGOMKIL(string.Format("FPS {0}   S[{1:F2}MB]   R[{2:F2}MB]", get_m_actor().get_m_resourceName(), GBGBBGEPEMI), (GameObject HCKCCHPJOPI) =>
			{
				HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
			});
		}
		if (gameObject != null)
		{
			NsEffectManager.RunReplayEffect(gameObject, true);
		}
	}

	public override void OnEnterTemptation()
	{
		get_m_actor().SetAnimation("run");
	}

	public void FloatRemote(Vector3 IJMNFOGNFAC, float DHFAGCCIDFJ, bool JAFHJHKMPHE = true)
	{
		LCFIFFAOBFB lCFIFFAOBFB = new LCFIFFAOBFB();
		lCFIFFAOBFB.IJMNFOGNFAC = IJMNFOGNFAC;
		lCFIFFAOBFB.DHFAGCCIDFJ = DHFAGCCIDFJ;
		EveView view = get_m_actor().get_m_view();
		if (!(view == null) && (!JAFHJHKMPHE || view.IsMine()) && get_m_actor().m_actorType != Actor.IJJMDPGJAEM.Turret && get_m_actor().m_hero_id != 20002 && get_m_actor().m_hero_id != 20003 && OnCheckFloat())
		{
			view.Msg(15, DJJPAPENCLN.All, true, lCFIFFAOBFB.ELIBLKPOGOH);
		}
	}

	public override void OnUpdateTemptation()
	{
		ALBEPPGKFMM aLBEPPGKFMM = get_m_actor().get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.AhriSkill2);
		if (aLBEPPGKFMM != null && !(aLBEPPGKFMM.FEFNGALOFDI() == null))
		{
			Vector3 iJMNFOGNFAC = aLBEPPGKFMM.FEFNGALOFDI().GetPosition() - get_m_actor().GetPosition();
			if (iJMNFOGNFAC.sqrMagnitude >= 1f)
			{
				iJMNFOGNFAC.Normalize();
				Move(1f, iJMNFOGNFAC);
			}
		}
	}

	public bool IsPossibleSpell()
	{
		if (get_m_state() != OEOIIKMBGAG.Idle && get_m_state() != OEOIIKMBGAG.Run)
		{
			return false;
		}
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.Silence))
		{
			return false;
		}
		return true;
	}

	public virtual void OOALFAKEMNL(KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnSerializeView(OGJFDNEEDCP);
		Vector2 zero = Vector2.zero;
		zero.x = get_m_transform().localPosition.x;
		zero.y = get_m_transform().localPosition.z;
		float y = get_m_transform().localRotation.eulerAngles.y;
		OGJFDNEEDCP.PFAIBIMGAIB(m_respawnRemainTime);
		OGJFDNEEDCP.GBMJNFOEACC(zero);
		OGJFDNEEDCP.GBMJNFOEACC(y);
		OGJFDNEEDCP.GBMJNFOEACC(m_moveDirection);
		if (get_m_actor().m_actorType == Actor.IJJMDPGJAEM.Hero)
		{
			for (int i = 1; i < LFNNHEEJNGP.Length; i++)
			{
				OGJFDNEEDCP.PFAIBIMGAIB(LFNNHEEJNGP[i].IHKCKBJBEGF);
			}
		}
	}

	public override void OnLeaveFloat()
	{
		get_m_actor().m_navMeshAgent.enabled = true;
	}

	public override void OnEnterRun()
	{
		get_m_actor().SetAnimation("run");
	}

	public override void OnEnterAttack()
	{
		get_m_actor().SetAnimation("attack");
		GameObject gameObject = GameObjectPool.Alloc(string.Format("Particle/{0}/attack", get_m_actor().get_m_resourceName()), (GameObject HCKCCHPJOPI) =>
		{
			HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
		});
		if (gameObject != null)
		{
			NsEffectManager.RunReplayEffect(gameObject, true);
		}
	}

	public bool Skill(int GBGBBGEPEMI, Vector3 AJGDIGGBFAL)
	{
		NGIPHOCLPKK nGIPHOCLPKK = new NGIPHOCLPKK();
		nGIPHOCLPKK.GBGBBGEPEMI = GBGBBGEPEMI;
		nGIPHOCLPKK.KNIAJMGDGAA = this;
		if (!IsPossibleSkill(nGIPHOCLPKK.GBGBBGEPEMI))
		{
			return false;
		}
		if (!OnCheckCastSkill(nGIPHOCLPKK.GBGBBGEPEMI))
		{
			return false;
		}
		if (LFNNHEEJNGP[nGIPHOCLPKK.GBGBBGEPEMI].BIOFGFCKEDL)
		{
			SetDirection(AJGDIGGBFAL);
			m_moveDirection = AJGDIGGBFAL;
		}
		LFNNHEEJNGP[nGIPHOCLPKK.GBGBBGEPEMI].IHKCKBJBEGF = 0f;
		if (LFNNHEEJNGP[nGIPHOCLPKK.GBGBBGEPEMI].AOKMPECBGND == CAJJEALKJMM.NNOCAHNPLCH.Double)
		{
			if (!LFNNHEEJNGP[nGIPHOCLPKK.GBGBBGEPEMI].LFCHOCGLFMI)
			{
				get_m_actor().AddMp(-LFNNHEEJNGP[nGIPHOCLPKK.GBGBBGEPEMI].HGHBKBDFLBG(get_m_actor().GetSkillLevel(nGIPHOCLPKK.GBGBBGEPEMI)));
				LFNNHEEJNGP[nGIPHOCLPKK.GBGBBGEPEMI].IOCIDGEFJIC = false;
			}
			else
			{
				LFNNHEEJNGP[nGIPHOCLPKK.GBGBBGEPEMI].LFCHOCGLFMI = false;
				LFNNHEEJNGP[nGIPHOCLPKK.GBGBBGEPEMI].IOCIDGEFJIC = true;
			}
		}
		else
		{
			get_m_actor().AddMp(-LFNNHEEJNGP[nGIPHOCLPKK.GBGBBGEPEMI].HGHBKBDFLBG(get_m_actor().GetSkillLevel(nGIPHOCLPKK.GBGBBGEPEMI)));
		}
		if (LFNNHEEJNGP[nGIPHOCLPKK.GBGBBGEPEMI].AOKMPECBGND == CAJJEALKJMM.NNOCAHNPLCH.Default)
		{
			SetSkillState(nGIPHOCLPKK.GBGBBGEPEMI);
		}
		else if (LFNNHEEJNGP[nGIPHOCLPKK.GBGBBGEPEMI].AOKMPECBGND == CAJJEALKJMM.NNOCAHNPLCH.Immediate)
		{
			if (get_m_view().IsMine())
			{
				get_m_view().Msg(3, DJJPAPENCLN.All, true, nGIPHOCLPKK.NCDDHBIAKGC);
			}
		}
		else if (LFNNHEEJNGP[nGIPHOCLPKK.GBGBBGEPEMI].AOKMPECBGND == CAJJEALKJMM.NNOCAHNPLCH.Double)
		{
			SetSkillState(nGIPHOCLPKK.GBGBBGEPEMI);
		}
		IDBJEMGIJEM = 0f;
		return true;
	}

	public override void OnUpdateRun()
	{
		float moveSpeed = get_m_actor().m_moveSpeed;
		float num = 0f;
		if (get_m_actor().get_m_gameItems() != null)
		{
			int num2 = get_m_actor().get_m_gameItems().OAHFGIGJHHC();
			for (int i = 0; i < num2; i++)
			{
				if (get_m_actor().get_m_gameItems().FPICNOOFDOA(i) != null)
				{
					num += get_m_actor().get_m_gameItems().FPICNOOFDOA(i).AGHCOCAJMCI()
						.NEPGMKLCMFF;
				}
			}
		}
		num *= 0.7f;
		float num3 = moveSpeed * (1f + GetPercentMoveSpeedBonus() + num) + GetMoveSpeedBonus();
		if (!get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.MasterYiSkill3))
		{
			float value = get_m_actor().get_m_buffsInfo().KDPEHABNMFC(JGOOOBHDBCG.ACPICCBBPHF.Slow);
			value = Mathf.Clamp01(value);
			num3 *= 1f - value;
			num3 = V093RuneBattleFix.ApplyMoveSpeed(num3, get_m_actor());
		}
		Move(num3, m_moveDirection);
	}

	public override void OnStageInit()
	{
		base.OnStageInit();
	}

	public void KnockBack(Vector3 IJMNFOGNFAC, float PJJFCGMEIFE, float MEGDEIKCOII, bool JPHKKPPEIAG, bool HAGLJGPBJPK = false)
	{
		if (get_m_actor().m_hero_id != 20002 && get_m_actor().m_hero_id != 20003 && OnCheckKnockBack())
		{
			KCDIHMHDGLK = IJMNFOGNFAC;
			LOHABGEDPBL = PJJFCGMEIFE;
			FFHJGCMPBFO = MEGDEIKCOII;
			POCDIEIKEFG = JPHKKPPEIAG;
			IDAKIJKHICA = HAGLJGPBJPK;
			SetState(OEOIIKMBGAG.KnockBack);
		}
	}

	public void RetargetingAttack(bool NGKJNJKGJNJ = false, bool KPIPMMCOONI = true)
	{
		if (!NGKJNJKGJNJ && get_m_target() != null && get_m_target().PossibleDamage(get_m_actor()))
		{
			return;
		}
		IAKBNJEFLAN(ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 45f, false, true, ((Actor.IJJMDPGJAEM)30 | Actor.IJJMDPGJAEM.SubHero)));
		if (get_m_target() == null)
		{
			IAKBNJEFLAN(ActorManager.get_Instance().GetActorInRangeForHero(get_m_actor(), get_m_actor().get_m_att_range(), false, true, ((Actor.IJJMDPGJAEM)28 | Actor.IJJMDPGJAEM.SubHero)));
			if (get_m_target() == null)
			{
				IAKBNJEFLAN(ActorManager.get_Instance().GetActorInRangeForHero(get_m_actor(), get_m_actor().get_m_att_range(), false, true, Actor.IJJMDPGJAEM.Hero));
			}
		}
		if (KPIPMMCOONI && get_m_target() != null)
		{
			SetDirection(get_m_target().GetPosition() - get_m_actor().GetPosition());
		}
	}

	public void MPCAJANBDEJ()
	{
		FEBFHCANBLL = (byte)0;
		CHJEHPALJCA = 55f;
		if (IEBFBBNJENI != null)
		{
			GameObjectPool.Free(IEBFBBNJENI, 414f);
			IEBFBBNJENI = null;
		}
		get_m_actor().m_multiSound.MNKCLFBCGGA("GBP");
	}

	[JDLHECHNNDH]
	public void CreateMissile(string NCADFOBAFJD, Vector3 HEPNHCEIFMO, int MBEKPGNGBAO)
	{
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(MBEKPGNGBAO);
		if (!(eveView == null))
		{
			Actor component = eveView.GetComponent<Actor>();
			if (!(component == null))
			{
				IAKBNJEFLAN(component);
				get_m_actor().CreateMissile(NCADFOBAFJD, HEPNHCEIFMO, component);
			}
		}
	}

	public void KGKANCIMCIL(Vector3 IJMNFOGNFAC, float PJJFCGMEIFE, float MEGDEIKCOII, bool JPHKKPPEIAG, bool HAGLJGPBJPK = false)
	{
		if (get_m_actor().m_hero_id != -49 && get_m_actor().m_hero_id != 41 && OnCheckKnockBack())
		{
			KCDIHMHDGLK = IJMNFOGNFAC;
			LOHABGEDPBL = PJJFCGMEIFE;
			FFHJGCMPBFO = MEGDEIKCOII;
			POCDIEIKEFG = JPHKKPPEIAG;
			IDAKIJKHICA = HAGLJGPBJPK;
			SetState(OEOIIKMBGAG.KnockBack);
		}
	}

	[CompilerGenerated]
	private void OMBIDEEOJCJ(GameObject HCKCCHPJOPI)
	{
		HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
	}

	public virtual bool Spell(Vector3 AJGDIGGBFAL)
	{
		if (!IsPossibleSpell())
		{
			return false;
		}
		if ((float)get_m_actor().m_spellElapsedTime >= get_m_actor().get_m_spellCoolTime())
		{
			if (IsMine())
			{
				SetDirection(AJGDIGGBFAL);
				Vector3 position = get_m_actor().GetPosition();
				get_m_view().RPC("OnSpell", DJJPAPENCLN.Others, position, m_direction);
				OnSpell(position, m_direction);
			}
			get_m_actor().m_spellElapsedTime = 0f;
			return true;
		}
		return false;
	}

	[JDLHECHNNDH]
	public void ReturnHomeRPC()
	{
		get_m_actor().Warp(GameManager.get_Instance().GetTeamPos(get_m_actor().m_team));
		CancelReturnHomeRPC();
	}

	public void IBPBDNIBGGL()
	{
		get_m_actor().Warp(GameManager.get_Instance().GetTeamPos(get_m_actor().m_team));
		CancelReturnHomeRPC();
	}

	public override void OnSerializeView(KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnSerializeView(OGJFDNEEDCP);
		Vector2 zero = Vector2.zero;
		zero.x = get_m_transform().localPosition.x;
		zero.y = get_m_transform().localPosition.z;
		float y = get_m_transform().localRotation.eulerAngles.y;
		OGJFDNEEDCP.GBMJNFOEACC(m_respawnRemainTime);
		OGJFDNEEDCP.GBMJNFOEACC(zero);
		OGJFDNEEDCP.GBMJNFOEACC(y);
		OGJFDNEEDCP.GBMJNFOEACC(m_moveDirection);
		if (get_m_actor().m_actorType == Actor.IJJMDPGJAEM.Hero)
		{
			for (int i = 0; i < LFNNHEEJNGP.Length; i++)
			{
				OGJFDNEEDCP.GBMJNFOEACC(LFNNHEEJNGP[i].IHKCKBJBEGF);
			}
		}
	}

	public override void OnEnterSleep()
	{
		get_m_actor().SetAnimation("idle");
	}

	public bool IsMine()
	{
		if (get_m_view() == null)
		{
			return false;
		}
		return get_m_view().IsMine();
	}

	public virtual void NMCFOLAAALG()
	{
	}

	public void OJPMFBHELBI(Vector3 IJMNFOGNFAC, float DHFAGCCIDFJ, bool JAFHJHKMPHE = true)
	{
		LCFIFFAOBFB lCFIFFAOBFB = new LCFIFFAOBFB();
		lCFIFFAOBFB.IJMNFOGNFAC = IJMNFOGNFAC;
		lCFIFFAOBFB.DHFAGCCIDFJ = DHFAGCCIDFJ;
		EveView view = get_m_actor().get_m_view();
		if (!(view == null) && (!JAFHJHKMPHE || view.IsMine()) && get_m_actor().m_actorType != (Actor.IJJMDPGJAEM)(-68) && get_m_actor().m_hero_id != -137 && get_m_actor().m_hero_id != -153 && OnCheckFloat())
		{
			view.NIKPELEGLNE(36, DJJPAPENCLN.Others, false, lCFIFFAOBFB.PPLGBOOIIML);
		}
	}

	public override void OnSetState(OEOIIKMBGAG HMJDCBCOODN, OEOIIKMBGAG HIJLHGKJKNJ)
	{
		if (HIJLHGKJKNJ == OEOIIKMBGAG.Death && get_m_actor() != null && get_m_actor().m_actorType == Actor.IJJMDPGJAEM.Hero)
		{
			m_respawnRemainTime = GameManager.get_Instance().GetRespawnTime(get_m_actor().get_Level());
		}
	}

	public void StartReturnHome()
	{
		if (CheckReturnHome())
		{
			get_m_view().RPC("StartReturnHomeRPC", DJJPAPENCLN.Others);
			StartReturnHomeRPC();
		}
	}

	[JDLHECHNNDH]
	public void StartReturnHomeRPC()
	{
		FEBFHCANBLL = (byte)1;
		CHJEHPALJCA = 0f;
		if (IEBFBBNJENI == null)
		{
			IEBFBBNJENI = GameObjectPool.Alloc("Particle/Common/return_home", (GameObject HCKCCHPJOPI) =>
			{
				HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
			});
			if (IEBFBBNJENI != null)
			{
				NsEffectManager.RunReplayEffect(IEBFBBNJENI, true);
			}
		}
		get_m_actor().m_multiSound.LKLFMNKDLHJ("ui_return_home");
	}

	public bool CheckReturnHome()
	{
		if (!IsMine())
		{
			return false;
		}
		if (get_m_state() != OEOIIKMBGAG.Idle || get_m_nextState() != OEOIIKMBGAG.None || (byte)FEBFHCANBLL == 1)
		{
			return false;
		}
		return true;
	}

	public override void OnMsgView(byte IKKFLANGAEA, KCIGFAHFHCH OGJFDNEEDCP)
	{
		switch ((ICOGNNKEKHJ)IKKFLANGAEA)
		{
		case ICOGNNKEKHJ.MoveDirection:
		{
			Vector2 ICENKPDOHBK13;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK13);
			Vector2 ICENKPDOHBK14;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK14);
			float ICENKPDOHBK15;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK15);
			Vector3 zero = Vector3.zero;
			zero.x = ICENKPDOHBK13.x;
			zero.y = 0f;
			zero.z = ICENKPDOHBK13.y;
			SetMoveDirection(zero, false);
			Vector3 zero2 = Vector3.zero;
			zero2.x = ICENKPDOHBK14.x;
			zero2.y = 2f;
			zero2.z = ICENKPDOHBK14.y;
			NOEAAGALAKH = zero2 - get_m_transform().localPosition;
			NOEAAGALAKH.y = 0f;
			if (NOEAAGALAKH.sqrMagnitude >= 25f)
			{
				NOEAAGALAKH = Vector3.zero;
				get_m_actor().Warp(zero2);
			}
			Quaternion localRotation = Quaternion.Euler(0f, ICENKPDOHBK15, 0f);
			get_m_transform().localRotation = localRotation;
			break;
		}
		case ICOGNNKEKHJ.ChangeState:
		{
			OEOIIKMBGAG ICENKPDOHBK16;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK16);
			Vector2 ICENKPDOHBK17;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK17);
			float ICENKPDOHBK18;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK18);
			Vector3 zero3 = Vector3.zero;
			zero3.x = ICENKPDOHBK17.x;
			zero3.y = 2f;
			zero3.z = ICENKPDOHBK17.y;
			NOEAAGALAKH = zero3 - get_m_transform().localPosition;
			NOEAAGALAKH.y = 0f;
			if (NOEAAGALAKH.sqrMagnitude >= 25f)
			{
				NOEAAGALAKH = Vector3.zero;
				get_m_actor().Warp(zero3);
			}
			if (ICENKPDOHBK16 != OEOIIKMBGAG.Skill)
			{
				ChangeState(ICENKPDOHBK16);
			}
			Quaternion localRotation2 = Quaternion.Euler(0f, ICENKPDOHBK18, 0f);
			get_m_transform().localRotation = localRotation2;
			break;
		}
		case ICOGNNKEKHJ.SkillState:
		{
			OEOIIKMBGAG ICENKPDOHBK21;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK21);
			byte ICENKPDOHBK22;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK22);
			bool ICENKPDOHBK23;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK23);
			Vector2 ICENKPDOHBK24;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK24);
			Vector3 ICENKPDOHBK25;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK25);
			Vector3 ICENKPDOHBK26;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK26);
			float ICENKPDOHBK27;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK27);
			Vector3 zero4 = Vector3.zero;
			zero4.x = ICENKPDOHBK24.x;
			zero4.y = 2f;
			zero4.z = ICENKPDOHBK24.y;
			NOEAAGALAKH = zero4 - get_m_transform().localPosition;
			NOEAAGALAKH.y = 0f;
			if (NOEAAGALAKH.sqrMagnitude >= 25f)
			{
				NOEAAGALAKH = Vector3.zero;
				get_m_actor().Warp(zero4);
			}
			get_m_actor().m_mp = ICENKPDOHBK27;
			LFNNHEEJNGP[ICENKPDOHBK22].IOCIDGEFJIC = ICENKPDOHBK23;
			LFNNHEEJNGP[ICENKPDOHBK22].IHKCKBJBEGF = 0f;
			SetSkillState(ICENKPDOHBK22);
			ChangeState(ICENKPDOHBK21);
			SetDirection(ICENKPDOHBK25);
			m_moveDirection = ICENKPDOHBK26;
			break;
		}
		case ICOGNNKEKHJ.ImmediateSkill:
		{
			byte ICENKPDOHBK19;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK19);
			float ICENKPDOHBK20;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK20);
			DPOMMIMMLNC(ICENKPDOHBK19, ICENKPDOHBK20);
			break;
		}
		case ICOGNNKEKHJ.CreateMissile:
		{
			string ICENKPDOHBK10;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK10);
			Vector3 ICENKPDOHBK11;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK11);
			int ICENKPDOHBK12;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK12);
			EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(ICENKPDOHBK12);
			if (!(eveView == null))
			{
				Actor component = eveView.GetComponent<Actor>();
				if (!(component == null))
				{
					IAKBNJEFLAN(component);
					get_m_actor().CreateMissile(ICENKPDOHBK10, ICENKPDOHBK11, component);
				}
			}
			break;
		}
		case ICOGNNKEKHJ.StartReturnHome:
			break;
		case ICOGNNKEKHJ.CancelReturnHome:
			break;
		case ICOGNNKEKHJ.ReturnHome:
			break;
		case ICOGNNKEKHJ.Spell:
		{
			Vector3 ICENKPDOHBK8;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK8);
			Vector3 ICENKPDOHBK9;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK9);
			break;
		}
		case ICOGNNKEKHJ.Float:
		{
			Vector3 ICENKPDOHBK6;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK6);
			float ICENKPDOHBK7;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK7);
			Float(ICENKPDOHBK6, ICENKPDOHBK7);
			break;
		}
		case ICOGNNKEKHJ.Knockback:
		{
			Vector3 ICENKPDOHBK;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK);
			float ICENKPDOHBK2;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK2);
			float ICENKPDOHBK3;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK3);
			bool ICENKPDOHBK4;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK4);
			bool ICENKPDOHBK5;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK5);
			KnockBack(ICENKPDOHBK, ICENKPDOHBK2, ICENKPDOHBK3, ICENKPDOHBK4, ICENKPDOHBK5);
			break;
		}
		case ICOGNNKEKHJ.Damage:
		case ICOGNNKEKHJ.RequestRecovery:
		case ICOGNNKEKHJ.ItemUse:
		case ICOGNNKEKHJ.RejoinAsyncComplete:
		case ICOGNNKEKHJ.CreateMultiMinions:
		case ICOGNNKEKHJ.CreateMtmMinions:
		case ICOGNNKEKHJ.RespawnHero:
		case ICOGNNKEKHJ.MapPing:
		case ICOGNNKEKHJ.PortalWarp:
		case ICOGNNKEKHJ.ChangeLevel:
			break;
		}
	}

	[CompilerGenerated]
	private void ODCFKIKILJC(GameObject HCKCCHPJOPI)
	{
		HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
	}

	public override void OnUpdateFloat()
	{
		Vector3 position = get_m_actor().GetPosition();
		m_floatPower.y -= 19.8f * Time.deltaTime;
		if (get_m_actor().get_m_elapsedTime() > 0f)
		{
			position += m_floatPower * Time.deltaTime;
		}
		if (position.y < LJHMGPFCLEN)
		{
			position.y = LJHMGPFCLEN;
		}
		get_m_actor().Warp(position);
		if (position.y <= LJHMGPFCLEN)
		{
			SetState(OEOIIKMBGAG.Idle);
		}
	}

	public override void OnEnterDeath()
	{
		get_m_actor().SetAnimation("death");
		CALECABBOMG = 3f;
		get_m_actor().get_m_buffsInfo().DOGNNGPHIDC();
		CAJJEALKJMM[] lFNNHEEJNGP = LFNNHEEJNGP;
		foreach (CAJJEALKJMM cAJJEALKJMM in lFNNHEEJNGP)
		{
			cAJJEALKJMM.LFCHOCGLFMI = false;
		}
		if (get_m_actor().get_m_damageHUD() != null)
		{
			get_m_actor().get_m_damageHUD().gameObject.SetActive(false);
		}
		if (get_m_actor().m_navMeshAgent != null)
		{
			get_m_actor().m_navMeshAgent.enabled = false;
		}
		get_m_actor().m_multiSound.LKLFMNKDLHJ("death");
	}

	public virtual float JNDEAKFNBLG()
	{
		float num = base.GetPercentMoveSpeedBonus();
		if (get_m_actor().m_actorType == (Actor.IJJMDPGJAEM)6)
		{
			ALBEPPGKFMM aLBEPPGKFMM = get_m_actor().get_m_buffsInfo().KKBLCGNNIBA((JGOOOBHDBCG.ACPICCBBPHF)121);
			if (aLBEPPGKFMM != null)
			{
				num += 596f + (float)(aLBEPPGKFMM.FEFNGALOFDI().GetSkillLevel(0) - 1) * 812f;
			}
			num += get_m_actor().get_m_buffsInfo().KDPEHABNMFC(JGOOOBHDBCG.ACPICCBBPHF.Slow);
			if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65447))
			{
				num += 1395f;
			}
			ALBEPPGKFMM aLBEPPGKFMM2 = get_m_actor().get_m_buffsInfo().EMILLELIOHH((JGOOOBHDBCG.ACPICCBBPHF)127);
			if (aLBEPPGKFMM2 != null && aLBEPPGKFMM2.FEFNGALOFDI() != null)
			{
				float num2 = 279f + (float)(aLBEPPGKFMM2.FEFNGALOFDI().GetSkillLevel(1) - 1) * 814f;
				num2 *= aLBEPPGKFMM2.FBKFEHOLBGD();
				num += num2;
			}
		}
		return num;
	}

	public override void OnUpdateAttack()
	{
		if (!get_m_actor().IsCurrentAnimation("attack") && !get_m_actor().IsCurrentAnimation("attack2") && !get_m_actor().IsCurrentAnimation("attack3") && !get_m_actor().IsCurrentAnimation("attack4") && !get_m_actor().IsCurrentAnimation("critical") && !get_m_actor().IsCurrentAnimation("tumble_attack"))
		{
			SetState(OEOIIKMBGAG.Idle);
		}
	}

	public void MHHADKGANMC(Vector3 IJMNFOGNFAC, float DHFAGCCIDFJ, bool JAFHJHKMPHE = true)
	{
		LCFIFFAOBFB lCFIFFAOBFB = new LCFIFFAOBFB();
		lCFIFFAOBFB.IJMNFOGNFAC = IJMNFOGNFAC;
		lCFIFFAOBFB.DHFAGCCIDFJ = DHFAGCCIDFJ;
		EveView view = get_m_actor().get_m_view();
		if (!(view == null) && (!JAFHJHKMPHE || view.IsMine()) && get_m_actor().m_actorType != (Actor.IJJMDPGJAEM)118 && get_m_actor().m_hero_id != 163 && get_m_actor().m_hero_id != 115 && OnCheckFloat())
		{
			view.Msg(24, DJJPAPENCLN.Others, true, lCFIFFAOBFB.ICLPPCAOAID);
		}
	}

	[CompilerGenerated]
	private void GAALLNIEFDA(GameObject HCKCCHPJOPI)
	{
		HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_direction = m_direction;
		HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
	}

	public override void OnLeaveIdle()
	{
	}

	private void OAIPEFIAEBP(GameObject HCKCCHPJOPI)
	{
		HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
	}

	public virtual void MLLBIGIODAF(KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnSerializeView(OGJFDNEEDCP);
		Vector2 zero = Vector2.zero;
		zero.x = get_m_transform().localPosition.x;
		zero.y = get_m_transform().localPosition.z;
		float y = get_m_transform().localRotation.eulerAngles.y;
		OGJFDNEEDCP.GBMJNFOEACC(m_respawnRemainTime);
		OGJFDNEEDCP.GBMJNFOEACC(zero);
		OGJFDNEEDCP.PFAIBIMGAIB(y);
		OGJFDNEEDCP.GBMJNFOEACC(m_moveDirection);
		if (get_m_actor().m_actorType == (Actor.IJJMDPGJAEM)7)
		{
			for (int i = 0; i < LFNNHEEJNGP.Length; i++)
			{
				OGJFDNEEDCP.GBMJNFOEACC(LFNNHEEJNGP[i].IHKCKBJBEGF);
			}
		}
	}

	[JDLHECHNNDH]
	public void Float(Vector3 IJMNFOGNFAC, float DHFAGCCIDFJ)
	{
		if (get_m_actor().m_actorType != Actor.IJJMDPGJAEM.Turret && get_m_actor().m_hero_id != 20002 && get_m_actor().m_hero_id != 20003 && OnCheckFloat())
		{
			m_floatPower.x = IJMNFOGNFAC.x;
			m_floatPower.z = IJMNFOGNFAC.z;
			m_floatPower.y = DHFAGCCIDFJ;
			ChangeState(OEOIIKMBGAG.Float);
		}
	}

	public override void OnUpdateIdle()
	{
		if ((byte)FEBFHCANBLL == 1)
		{
			CHJEHPALJCA = (float)CHJEHPALJCA + Time.deltaTime;
			if ((float)CHJEHPALJCA >= 5f && IsMine())
			{
				get_m_view().RPC("ReturnHomeRPC", DJJPAPENCLN.Others);
				ReturnHomeRPC();
			}
		}
	}

	public override void OnLeaveRun()
	{
	}

	public override void OnLeaveAttack()
	{
	}

	public override void OnLeaveKnockBack()
	{
	}

	public override void OnLeaveSkill()
	{
		base.OnLeaveSkill();
	}

	public float Move(float IMABEBIKOOH, Vector3 IJMNFOGNFAC, bool LBHLMOHBBCF = true, float IFPPLGOCBOM = -1f, bool GDEMKNOABKN = false)
	{
		float num = IMABEBIKOOH * get_m_actor().get_m_elapsedTime();
		if (IFPPLGOCBOM > 0f && num > IFPPLGOCBOM)
		{
			num = IFPPLGOCBOM;
		}
		if (IJMNFOGNFAC != Vector3.zero)
		{
			IJMNFOGNFAC.Normalize();
			if (LBHLMOHBBCF)
			{
				m_direction = IJMNFOGNFAC;
			}
			Vector3 vector = IJMNFOGNFAC * num;
			if (vector != Vector3.zero)
			{
				get_m_transform().localRotation = Quaternion.LookRotation(vector);
				get_m_actor().Move(vector, GDEMKNOABKN);
			}
			if (get_m_actor() != null && get_m_actor().m_animator != null && get_m_state() == OEOIIKMBGAG.Run)
			{
				float num2 = IMABEBIKOOH * get_m_actor().get_m_frequency();
				if (get_m_actor().m_animator.speed != num2)
				{
					get_m_actor().m_animator.speed = num2;
				}
			}
			if (get_m_actor().m_actorType == Actor.IJJMDPGJAEM.Hero)
			{
				get_m_actor().get_m_gameItems().EMBOAOKJINO(1109, num);
			}
			return num;
		}
		return 0f;
	}

	public void SetMoveDirection(Vector3 HCILMCOKKPN, bool MIFNPKNEEOF = true)
	{
		if (get_m_state() == OEOIIKMBGAG.Attack && (m_moveDirection - HCILMCOKKPN).sqrMagnitude >= 1.44f)
		{
			SetState(OEOIIKMBGAG.Idle);
			return;
		}
		Vector3 moveDirection = m_moveDirection;
		if (get_m_state() == OEOIIKMBGAG.Skill && GetCastSkill(get_m_skill()).CEAGJMLKENE)
		{
			m_moveDirection = HCILMCOKKPN;
		}
		if (get_m_state() == OEOIIKMBGAG.Idle || get_m_state() == OEOIIKMBGAG.Run)
		{
			m_moveDirection = HCILMCOKKPN;
			if (get_m_nextState() == OEOIIKMBGAG.None)
			{
				if (m_moveDirection == Vector3.zero)
				{
					SetState(OEOIIKMBGAG.Idle);
				}
				else
				{
					SetState(OEOIIKMBGAG.Run);
				}
			}
		}
		if (m_moveDirection.CIDAEFBINFO(moveDirection, 0.01f))
		{
			m_moveDirection = moveDirection;
		}
		else
		{
			if (!MIFNPKNEEOF)
			{
				return;
			}
			if (HCILMCOKKPN == Vector3.zero || HOEEMPDJOME >= 0.05f)
			{
				if (get_m_view() != null && get_m_view().IsMine() && moveDirection != m_moveDirection)
				{
					APGJDHPJHKH aPGJDHPJHKH = new APGJDHPJHKH();
					aPGJDHPJHKH.BGNMKABPONA = Vector2.zero;
					aPGJDHPJHKH.BGNMKABPONA.x = m_moveDirection.x;
					aPGJDHPJHKH.BGNMKABPONA.y = m_moveDirection.z;
					aPGJDHPJHKH.HEPNHCEIFMO = Vector2.zero;
					aPGJDHPJHKH.HEPNHCEIFMO.x = get_m_transform().localPosition.x;
					aPGJDHPJHKH.HEPNHCEIFMO.y = get_m_transform().localPosition.z;
					aPGJDHPJHKH.KMILPEHBBEL = get_m_transform().localRotation.eulerAngles.y;
					get_m_view().Msg(0, DJJPAPENCLN.Others, false, aPGJDHPJHKH.NKMBOKCBCEG);
				}
				DIEIHKHDOPL = false;
				HOEEMPDJOME = 0f;
			}
			else
			{
				DIEIHKHDOPL = true;
			}
		}
	}

	public override void OnDeserializeView(KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnDeserializeView(OGJFDNEEDCP);
		OGJFDNEEDCP.CAHACMKBJMI(out m_respawnRemainTime);
		Vector2 ICENKPDOHBK;
		OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK);
		float ICENKPDOHBK2;
		OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK2);
		OGJFDNEEDCP.CAHACMKBJMI(out m_moveDirection);
		if (get_m_actor().m_actorType == Actor.IJJMDPGJAEM.Hero)
		{
			for (int i = 0; i < LFNNHEEJNGP.Length; i++)
			{
				OGJFDNEEDCP.CAHACMKBJMI(out LFNNHEEJNGP[i].IHKCKBJBEGF);
			}
		}
		Vector3 zero = Vector3.zero;
		zero.x = ICENKPDOHBK.x;
		zero.y = 2f;
		zero.z = ICENKPDOHBK.y;
		Quaternion quaternion = Quaternion.Euler(0f, ICENKPDOHBK2, 0f);
		Vector3 direction = quaternion * Vector3.forward;
		SetDirection(direction);
		NOEAAGALAKH = Vector3.zero;
		SetStateForce(get_m_state());
	}
}
