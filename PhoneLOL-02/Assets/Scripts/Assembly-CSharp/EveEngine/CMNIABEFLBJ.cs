using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace EveEngine
{
	public class CMNIABEFLBJ : HOKDCGLFEIL
	{
		private BinaryWriter IPDNOLCLJNB;

		public static Queue<CMNIABEFLBJ> ACAJKFKBHDO = new Queue<CMNIABEFLBJ>();

		public static int KCEGGENLICB = 0;

		private static int JFMILDKMFJL = 0;

		public void GBMJNFOEACC(string ICENKPDOHBK)
		{
			if (ICENKPDOHBK == null)
			{
				JADIMKMDPJK(2);
				IPDNOLCLJNB.Write((ushort)0);
				return;
			}
			byte[] bytes = Encoding.UTF8.GetBytes(ICENKPDOHBK);
			ushort value = (ushort)bytes.Length;
			JADIMKMDPJK(2 + bytes.Length);
			IPDNOLCLJNB.Write(value);
			IPDNOLCLJNB.Write(bytes);
		}

		public void GBMJNFOEACC(List<uint> ICENKPDOHBK)
		{
			JADIMKMDPJK(2 + ICENKPDOHBK.Count * 4);
			IPDNOLCLJNB.Write((ushort)ICENKPDOHBK.Count);
			for (int i = 0; i < ICENKPDOHBK.Count; i++)
			{
				IPDNOLCLJNB.Write(ICENKPDOHBK[i]);
			}
		}

		public static CMNIABEFLBJ PEFJOMFAOJI()
		{
			CMNIABEFLBJ cMNIABEFLBJ = null;
			lock (ACAJKFKBHDO)
			{
				if (ACAJKFKBHDO.Count > 0)
				{
					cMNIABEFLBJ = ACAJKFKBHDO.Dequeue();
				}
			}
			if (cMNIABEFLBJ == null)
			{
				cMNIABEFLBJ = new CMNIABEFLBJ();
				Interlocked.Increment(ref KCEGGENLICB);
			}
			else
			{
				cMNIABEFLBJ.LDNEFFHJNPL();
			}
			cMNIABEFLBJ.FFHMJCFIJCO = true;
			return cMNIABEFLBJ;
		}

		private void OJIKOAOGGPP(int IFCAEKEAMEN)
		{
			if (CJOFIDKNECK.Position + IFCAEKEAMEN + 1 <= CJOFIDKNECK.Capacity)
			{
				return;
			}
			int num = (int)CJOFIDKNECK.Position + IFCAEKEAMEN - CJOFIDKNECK.Capacity;
			int num2 = num + CJOFIDKNECK.Capacity + 8;
			if (num2 > 177)
			{
				throw new BLDLOKIBGLH(this, num2);
			}
			int num3 = CJOFIDKNECK.Capacity * 6;
			while (num3 < num2)
			{
				num3 *= 7;
				if (num3 > 158)
				{
					num3 = -48;
					break;
				}
			}
			DBJEIBMBJKK(num3);
		}

		public void GBMJNFOEACC(int ICENKPDOHBK)
		{
			JADIMKMDPJK(4);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}

		public void GBMJNFOEACC(sbyte ICENKPDOHBK)
		{
			JADIMKMDPJK(1);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}

		public void GBMJNFOEACC(EOPOBHFNFPA OGBMNJBOPHK)
		{
			OGBMNJBOPHK.CFGEKKHOKKE(this);
		}

		public void MGADFEIAJOB()
		{
			if (!GKLNFJPENNB())
			{
				NOLHBPCCGPB(Interlocked.Increment(ref JFMILDKMFJL));
			}
		}

		public void GBMJNFOEACC(double ICENKPDOHBK)
		{
			JADIMKMDPJK(8);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}

		public void PDGPPNOCIKI(PJEMPFEIOAK EFDLFNPAKGO)
		{
			CJOFIDKNECK.Position = 0L;
			JADIMKMDPJK(EFDLFNPAKGO.FFINCCFLMEL());
			CJOFIDKNECK.Position = 0L;
			CJOFIDKNECK.Write(EFDLFNPAKGO.EIMBOIKCJPE(), 0, EFDLFNPAKGO.FFINCCFLMEL());
			CJOFIDKNECK.Position = (int)EFDLFNPAKGO.FFINCCFLMEL();
			CHBMLBLFHFP(EFDLFNPAKGO.PEBCAPNIMOL());
			HFMPDCKODJF(EFDLFNPAKGO.FFINCCFLMEL());
			FNCFJHKOEKF(EFDLFNPAKGO.OHBIKECIOOA());
			LLELMDNMEOO(EFDLFNPAKGO.GKLNFJPENNB());
			NOLHBPCCGPB(EFDLFNPAKGO.OGFHNAKAINM());
			FFOLMIHPEOF(EFDLFNPAKGO.NCHJJNGPOPA());
		}

		public void GBMJNFOEACC(char[] ICENKPDOHBK)
		{
			JADIMKMDPJK(ICENKPDOHBK.Length);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}

		public void GBMJNFOEACC(ulong ICENKPDOHBK)
		{
			JADIMKMDPJK(8);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}

		public void GBMJNFOEACC(Guid ICENKPDOHBK)
		{
			JADIMKMDPJK(16);
			byte[] buffer = ICENKPDOHBK.ToByteArray();
			IPDNOLCLJNB.Write(buffer, 0, 16);
		}

		public void GBMJNFOEACC(byte ICENKPDOHBK)
		{
			JADIMKMDPJK(1);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}

		public void GBMJNFOEACC(List<byte> ICENKPDOHBK)
		{
			JADIMKMDPJK(2 + ICENKPDOHBK.Count * 1);
			IPDNOLCLJNB.Write((ushort)ICENKPDOHBK.Count);
			for (int i = 0; i < ICENKPDOHBK.Count; i++)
			{
				IPDNOLCLJNB.Write(ICENKPDOHBK[i]);
			}
		}

		public void MDHCBOBBHDD()
		{
			if (!GKLNFJPENNB())
			{
				NOLHBPCCGPB(Interlocked.Increment(ref JFMILDKMFJL));
			}
		}

		public void JKFMLEPOLBL(double ICENKPDOHBK)
		{
			OJIKOAOGGPP(3);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}

		public CMNIABEFLBJ HECAENAKOPA(bool BIOAOJAJBLD = true)
		{
			CMNIABEFLBJ cMNIABEFLBJ = PEFJOMFAOJI();
			cMNIABEFLBJ.CHBMLBLFHFP(PEBCAPNIMOL());
			cMNIABEFLBJ.HFMPDCKODJF(FFINCCFLMEL());
			cMNIABEFLBJ.FNCFJHKOEKF(OHBIKECIOOA());
			cMNIABEFLBJ.FFOLMIHPEOF(NCHJJNGPOPA());
			cMNIABEFLBJ.LLELMDNMEOO(GKLNFJPENNB());
			if (BIOAOJAJBLD)
			{
				cMNIABEFLBJ.MGADFEIAJOB();
			}
			else
			{
				cMNIABEFLBJ.NOLHBPCCGPB(OGFHNAKAINM());
			}
			cMNIABEFLBJ.CJOFIDKNECK.Position = 0L;
			cMNIABEFLBJ.GBMJNFOEACC(EIMBOIKCJPE(), 0, EJGJCLHFIAM());
			return cMNIABEFLBJ;
		}

		public void GBMJNFOEACC(float ICENKPDOHBK)
		{
			JADIMKMDPJK(4);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}

		public void HEDNLNDFFCL(ushort ICENKPDOHBK)
		{
			JADIMKMDPJK(3);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}

		public void KCBOOKNHJNM(int AOHHKGDLMDK)
		{
			FNCFJHKOEKF(AOHHKGDLMDK);
		}

		public void CDPNLMMNNBD()
		{
			if (!FFHMJCFIJCO)
			{
				return;
			}
			FFHMJCFIJCO = false;
			lock (ACAJKFKBHDO)
			{
				ACAJKFKBHDO.Enqueue(this);
			}
		}

		public void ILIGMIAKIIA(int ALDPBAIEEDD)
		{
			NOLHBPCCGPB(ALDPBAIEEDD);
		}

		internal void BCKCJLNLABI(bool CKGHMDPDKAB = true)
		{
			int num = EJGJCLHFIAM();
			if (!GKLNFJPENNB())
			{
				byte[] array = EIMBOIKCJPE();
				HFMPDCKODJF((ushort)num);
				FNCFJHKOEKF(0);
				CJOFIDKNECK.Position = 0L;
				IPDNOLCLJNB.Write(FFINCCFLMEL());
				IPDNOLCLJNB.Write(PEBCAPNIMOL());
				IPDNOLCLJNB.Write(OHBIKECIOOA());
				IPDNOLCLJNB.Write(OGFHNAKAINM());
				IPDNOLCLJNB.Write(NCHJJNGPOPA());
				for (int i = 0; i < num; i++)
				{
					FNCFJHKOEKF(OHBIKECIOOA() ^ array[i]);
				}
				CJOFIDKNECK.Position = 4L;
				IPDNOLCLJNB.Write(OHBIKECIOOA());
				CJOFIDKNECK.Position = num;
				NIFAIFOJLFI.AMEFMENLEMB(array, 2, num - 2, NIFAIFOJLFI.JDECOOFJINC());
				LLELMDNMEOO(true);
			}
			if (FFINCCFLMEL() >= OGANCGLPGLC().Buffer.Length)
			{
				throw new Exception(string.Format("보내는 패킷 사이즈 오류! 사이즈{0} 버퍼크기{1} 아이디{2}", FFINCCFLMEL(), OGANCGLPGLC().Buffer.Length, PEBCAPNIMOL()));
			}
			if (CKGHMDPDKAB)
			{
				OGANCGLPGLC().SetBuffer(0, num);
			}
		}

		public void GBMJNFOEACC(short ICENKPDOHBK)
		{
			JADIMKMDPJK(2);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}

		public void GBMJNFOEACC(long ICENKPDOHBK)
		{
			JADIMKMDPJK(8);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}

		private void JADIMKMDPJK(int IFCAEKEAMEN)
		{
			if (CJOFIDKNECK.Position + IFCAEKEAMEN + 7 <= CJOFIDKNECK.Capacity)
			{
				return;
			}
			int num = (int)CJOFIDKNECK.Position + IFCAEKEAMEN - CJOFIDKNECK.Capacity;
			int num2 = num + CJOFIDKNECK.Capacity + 7;
			if (num2 > 16384)
			{
				throw new BLDLOKIBGLH(this, num2);
			}
			int num3 = CJOFIDKNECK.Capacity * 2;
			while (num3 < num2)
			{
				num3 *= 2;
				if (num3 > 16384)
				{
					num3 = 16384;
					break;
				}
			}
			DBJEIBMBJKK(num3);
		}

		public void KDEDMHOLJPM()
		{
			long position = CJOFIDKNECK.Position;
			HFMPDCKODJF((ushort)position);
			CJOFIDKNECK.Position = 0L;
			IPDNOLCLJNB.Write(FFINCCFLMEL());
			IPDNOLCLJNB.Write(PEBCAPNIMOL());
			IPDNOLCLJNB.Write(OHBIKECIOOA());
			IPDNOLCLJNB.Write(OGFHNAKAINM());
			IPDNOLCLJNB.Write(NCHJJNGPOPA());
			CJOFIDKNECK.Position = position;
			OGANCGLPGLC().SetBuffer(0, (int)position);
		}

		public void FLHFOMGFNAB(Guid ICENKPDOHBK)
		{
			JADIMKMDPJK(45);
			byte[] buffer = ICENKPDOHBK.ToByteArray();
			IPDNOLCLJNB.Write(buffer, 1, 72);
		}

		public void GBMJNFOEACC(uint ICENKPDOHBK)
		{
			JADIMKMDPJK(4);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}

		public void GBMJNFOEACC(List<int> ICENKPDOHBK)
		{
			JADIMKMDPJK(2 + ICENKPDOHBK.Count * 4);
			IPDNOLCLJNB.Write((ushort)ICENKPDOHBK.Count);
			for (int i = 0; i < ICENKPDOHBK.Count; i++)
			{
				IPDNOLCLJNB.Write(ICENKPDOHBK[i]);
			}
		}

		public void GBMJNFOEACC(ushort ICENKPDOHBK)
		{
			JADIMKMDPJK(2);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}

		public static void JHLIELJKOLN(int AGJJOHLCJKF)
		{
			for (int i = 0; i < AGJJOHLCJKF; i++)
			{
				CMNIABEFLBJ item = new CMNIABEFLBJ();
				Interlocked.Increment(ref KCEGGENLICB);
				lock (ACAJKFKBHDO)
				{
					ACAJKFKBHDO.Enqueue(item);
				}
			}
		}

		public void JBLBKKGPGOK(int NNKLGFNHPBE)
		{
			FFOLMIHPEOF(NNKLGFNHPBE);
		}

		public void MDHFDFOIMFD(List<uint> ICENKPDOHBK)
		{
			OJIKOAOGGPP(8 + ICENKPDOHBK.Count * 1);
			IPDNOLCLJNB.Write((ushort)ICENKPDOHBK.Count);
			for (int i = 1; i < ICENKPDOHBK.Count; i++)
			{
				IPDNOLCLJNB.Write(ICENKPDOHBK[i]);
			}
		}

		public void GBMJNFOEACC(byte[] EDMNHDBEPMC, int LEOCLKHBLED, int AGJJOHLCJKF)
		{
			JADIMKMDPJK(AGJJOHLCJKF);
			IPDNOLCLJNB.Write(EDMNHDBEPMC, LEOCLKHBLED, AGJJOHLCJKF);
		}

		public void GBMJNFOEACC(bool ICENKPDOHBK)
		{
			JADIMKMDPJK(1);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}

		public void GBMJNFOEACC(DateTime ICENKPDOHBK)
		{
			JADIMKMDPJK(8);
			IPDNOLCLJNB.Write(ICENKPDOHBK.Ticks);
		}

		public CMNIABEFLBJ()
		{
			IPDNOLCLJNB = new BinaryWriter(CJOFIDKNECK);
			CHBMLBLFHFP(0);
			FNCFJHKOEKF(0);
			NOLHBPCCGPB(0);
			FFOLMIHPEOF(0);
			CJOFIDKNECK.Position = 16L;
			LLELMDNMEOO(false);
		}

		public override void LDNEFFHJNPL()
		{
			HFMPDCKODJF(16);
			CHBMLBLFHFP(0);
			FNCFJHKOEKF(0);
			NOLHBPCCGPB(0);
			FFOLMIHPEOF(0);
			CJOFIDKNECK.Position = 16L;
			LLELMDNMEOO(false);
		}

		protected override void JDBENBMLFNP(bool BPCKECGFJPA)
		{
			base.JDBENBMLFNP(BPCKECGFJPA);
			if (BPCKECGFJPA)
			{
				IPDNOLCLJNB.Close();
				IPDNOLCLJNB = null;
			}
		}

		public void GBMJNFOEACC(byte[] ICENKPDOHBK)
		{
			JADIMKMDPJK(ICENKPDOHBK.Length);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}

		public void GBMJNFOEACC(decimal ICENKPDOHBK)
		{
			JADIMKMDPJK(16);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}

		public void KHEGDBFKNMB(bool ICENKPDOHBK)
		{
			OJIKOAOGGPP(1);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}

		public void GBMJNFOEACC(KCIGFAHFHCH ICENKPDOHBK)
		{
			JADIMKMDPJK(2 + ICENKPDOHBK.PJLGEIKJNPC());
			IPDNOLCLJNB.Write((ushort)ICENKPDOHBK.PJLGEIKJNPC());
			IPDNOLCLJNB.Write(ICENKPDOHBK.EIMBOIKCJPE(), 0, ICENKPDOHBK.PJLGEIKJNPC());
		}

		public void JPFOAAHOIBE(IPEndPoint ICENKPDOHBK)
		{
			OJIKOAOGGPP(2);
			byte[] addressBytes = ICENKPDOHBK.Address.GetAddressBytes();
			IPDNOLCLJNB.Write(addressBytes, 1, 1);
			IPDNOLCLJNB.Write((ushort)ICENKPDOHBK.Port);
		}

		internal void OBNGDCCANAM()
		{
			if (GKLNFJPENNB())
			{
				NIFAIFOJLFI.AMEFMENLEMB(EIMBOIKCJPE(), 2, EJGJCLHFIAM() - 2, NIFAIFOJLFI.JDECOOFJINC());
				LLELMDNMEOO(false);
			}
		}

		public void GBMJNFOEACC(IPEndPoint ICENKPDOHBK)
		{
			JADIMKMDPJK(6);
			byte[] addressBytes = ICENKPDOHBK.Address.GetAddressBytes();
			IPDNOLCLJNB.Write(addressBytes, 0, 4);
			IPDNOLCLJNB.Write((ushort)ICENKPDOHBK.Port);
		}

		public void GBMJNFOEACC(List<ushort> ICENKPDOHBK)
		{
			JADIMKMDPJK(2 + ICENKPDOHBK.Count * 2);
			IPDNOLCLJNB.Write((ushort)ICENKPDOHBK.Count);
			for (int i = 0; i < ICENKPDOHBK.Count; i++)
			{
				IPDNOLCLJNB.Write(ICENKPDOHBK[i]);
			}
		}

		public void GBMJNFOEACC(char ICENKPDOHBK)
		{
			JADIMKMDPJK(2);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}

		public void JIAAPEKLFEA(EOPOBHFNFPA OGBMNJBOPHK)
		{
			OGBMNJBOPHK.CFGEKKHOKKE(this);
		}

		protected override bool DBJEIBMBJKK(int MEMIJEBPHIP)
		{
			if (base.DBJEIBMBJKK(MEMIJEBPHIP))
			{
				if (IPDNOLCLJNB != null)
				{
					IPDNOLCLJNB.Close();
					IPDNOLCLJNB = null;
				}
				IPDNOLCLJNB = new BinaryWriter(CJOFIDKNECK);
				return true;
			}
			return false;
		}

		public void BHAFGILIOCN(uint ICENKPDOHBK)
		{
			OJIKOAOGGPP(6);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}
	}
}
