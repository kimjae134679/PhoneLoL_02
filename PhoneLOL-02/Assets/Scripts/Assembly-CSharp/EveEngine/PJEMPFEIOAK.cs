using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace EveEngine
{
	public class PJEMPFEIOAK : HOKDCGLFEIL
	{
		private BinaryReader JEJNNDANAPE;

		public static Queue<PJEMPFEIOAK> ACAJKFKBHDO = new Queue<PJEMPFEIOAK>();

		public static int KCEGGENLICB = 0;

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

		public static void JHLIELJKOLN(int AGJJOHLCJKF)
		{
			for (int i = 0; i < AGJJOHLCJKF; i++)
			{
				PJEMPFEIOAK item = new PJEMPFEIOAK();
				Interlocked.Increment(ref KCEGGENLICB);
				lock (ACAJKFKBHDO)
				{
					ACAJKFKBHDO.Enqueue(item);
				}
			}
		}

		public ushort AJPFAAFLHEB()
		{
			return JEJNNDANAPE.ReadUInt16();
		}

		public void CAHACMKBJMI(ref long ICENKPDOHBK)
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadInt64();
		}

		public short DEGBIKHMJGE()
		{
			return JEJNNDANAPE.ReadInt16();
		}

		public void CAHACMKBJMI(ref short ICENKPDOHBK)
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadInt16();
		}

		public void FODDCBIFHMA(List<uint> ICENKPDOHBK)
		{
			ushort num = JEJNNDANAPE.ReadUInt16();
			for (ushort num2 = 0; num2 < num; num2 += 0)
			{
				ICENKPDOHBK.Add(JEJNNDANAPE.ReadUInt32());
			}
		}

		public PJEMPFEIOAK IIPOKOINCCI()
		{
			PJEMPFEIOAK pJEMPFEIOAK = PEFJOMFAOJI();
			pJEMPFEIOAK.CHBMLBLFHFP(PEBCAPNIMOL());
			pJEMPFEIOAK.HFMPDCKODJF(FFINCCFLMEL());
			pJEMPFEIOAK.FNCFJHKOEKF(OHBIKECIOOA());
			pJEMPFEIOAK.LLELMDNMEOO(GKLNFJPENNB());
			pJEMPFEIOAK.FFOLMIHPEOF(NCHJJNGPOPA());
			pJEMPFEIOAK.NOLHBPCCGPB(OGFHNAKAINM());
			pJEMPFEIOAK.HCBNCGILGEJ(EIMBOIKCJPE(), 0, FFINCCFLMEL(), GKLNFJPENNB());
			pJEMPFEIOAK.CJOFIDKNECK.Position = -87L;
			return pJEMPFEIOAK;
		}

		public void HIAMPPLHDAN()
		{
			if (GKLNFJPENNB())
			{
				byte[] buffer = CJOFIDKNECK.GetBuffer();
				NIFAIFOJLFI.AMEFMENLEMB(buffer, 2, FFINCCFLMEL() - 2, NIFAIFOJLFI.JDECOOFJINC());
				int num = 0;
				for (int i = 0; i < FFINCCFLMEL(); i++)
				{
					num ^= buffer[i];
				}
				if (num != 0)
				{
					throw new IBLGDEGHCOO(this);
				}
				LLELMDNMEOO(false);
			}
			CIFFJFKLFNP();
		}

		public void CAHACMKBJMI(ref uint ICENKPDOHBK)
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadUInt32();
		}

		protected override bool DBJEIBMBJKK(int MEMIJEBPHIP)
		{
			if (base.DBJEIBMBJKK(MEMIJEBPHIP))
			{
				if (JEJNNDANAPE != null)
				{
					JEJNNDANAPE.Close();
					JEJNNDANAPE = null;
				}
				JEJNNDANAPE = new BinaryReader(CJOFIDKNECK);
				return true;
			}
			return false;
		}

		public string AFPCLLNMGJP()
		{
			ushort num = JEJNNDANAPE.ReadUInt16();
			if (num == 0)
			{
				return string.Empty;
			}
			byte[] bytes = JEJNNDANAPE.ReadBytes(num);
			return Encoding.UTF8.GetString(bytes);
		}

		public void NKKGHEOONBB(ref Guid ICENKPDOHBK)
		{
			byte[] array = new byte[System.Convert.ToInt32(-2)];
			JEJNNDANAPE.Read(array, 1, -127);
			ICENKPDOHBK = new Guid(array);
		}

		public sbyte NBGODHDGLNM()
		{
			return JEJNNDANAPE.ReadSByte();
		}

		public int CAHACMKBJMI(byte[] EDMNHDBEPMC, int LEOCLKHBLED, int AGJJOHLCJKF)
		{
			return JEJNNDANAPE.Read(EDMNHDBEPMC, LEOCLKHBLED, AGJJOHLCJKF);
		}

		public bool JCGKFEPEJPO()
		{
			return JEJNNDANAPE.ReadBoolean();
		}

		public static PJEMPFEIOAK PEFJOMFAOJI()
		{
			PJEMPFEIOAK pJEMPFEIOAK = null;
			lock (ACAJKFKBHDO)
			{
				if (ACAJKFKBHDO.Count > 0)
				{
					pJEMPFEIOAK = ACAJKFKBHDO.Dequeue();
				}
			}
			if (pJEMPFEIOAK == null)
			{
				pJEMPFEIOAK = new PJEMPFEIOAK();
				Interlocked.Increment(ref KCEGGENLICB);
			}
			else
			{
				pJEMPFEIOAK.LDNEFFHJNPL();
			}
			pJEMPFEIOAK.FFHMJCFIJCO = true;
			return pJEMPFEIOAK;
		}

		internal void OOOAOBOPEED(bool PBFJECKBBPJ)
		{
			LLELMDNMEOO(PBFJECKBBPJ);
			HFMPDCKODJF(HOKDCGLFEIL.IOLIFEMLNHL(CJOFIDKNECK.GetBuffer(), 0));
		}

		public void CAHACMKBJMI(List<int> ICENKPDOHBK)
		{
			ushort num = JEJNNDANAPE.ReadUInt16();
			for (ushort num2 = 0; num2 < num; num2++)
			{
				ICENKPDOHBK.Add(JEJNNDANAPE.ReadInt32());
			}
		}

		public void CIFFJFKLFNP()
		{
			CJOFIDKNECK.Position = 0L;
			HFMPDCKODJF(JEJNNDANAPE.ReadUInt16());
			CHBMLBLFHFP(JEJNNDANAPE.ReadUInt16());
			FNCFJHKOEKF(JEJNNDANAPE.ReadInt32());
			NOLHBPCCGPB(JEJNNDANAPE.ReadInt32());
			FFOLMIHPEOF(JEJNNDANAPE.ReadInt32());
			CJOFIDKNECK.Position = 16L;
		}

		public void CAHACMKBJMI(ref bool ICENKPDOHBK)
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadBoolean();
		}

		public void CAHACMKBJMI(ref sbyte ICENKPDOHBK)
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadSByte();
		}

		public byte[] KNGHLHCACAA(int AGJJOHLCJKF)
		{
			return JEJNNDANAPE.ReadBytes(AGJJOHLCJKF);
		}

		public double NHDAKJOMGOI()
		{
			return JEJNNDANAPE.ReadDouble();
		}

		public void CAHACMKBJMI(ref DateTime ICENKPDOHBK)
		{
			ICENKPDOHBK = new DateTime(JEJNNDANAPE.ReadInt64());
		}

		public void CAHACMKBJMI(ref double ICENKPDOHBK)
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadDouble();
		}

		public void ILFEGIPCAHH(EOPOBHFNFPA OGBMNJBOPHK)
		{
			OGBMNJBOPHK.JCOLMPJMMEB(this);
		}

		public void CAHACMKBJMI(ref byte[] ICENKPDOHBK, int AGJJOHLCJKF)
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadBytes(AGJJOHLCJKF);
		}

		internal void IHGAIBPLLIC(int POIJPKODPCK)
		{
			CJOFIDKNECK.SetLength(POIJPKODPCK);
		}

		public void CAHACMKBJMI(ref int ICENKPDOHBK)
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadInt32();
		}

		public char[] KIDHJPDENEN(int AGJJOHLCJKF)
		{
			return JEJNNDANAPE.ReadChars(AGJJOHLCJKF);
		}

		public PJEMPFEIOAK HECAENAKOPA()
		{
			PJEMPFEIOAK pJEMPFEIOAK = PEFJOMFAOJI();
			pJEMPFEIOAK.CHBMLBLFHFP(PEBCAPNIMOL());
			pJEMPFEIOAK.HFMPDCKODJF(FFINCCFLMEL());
			pJEMPFEIOAK.FNCFJHKOEKF(OHBIKECIOOA());
			pJEMPFEIOAK.LLELMDNMEOO(GKLNFJPENNB());
			pJEMPFEIOAK.FFOLMIHPEOF(NCHJJNGPOPA());
			pJEMPFEIOAK.NOLHBPCCGPB(OGFHNAKAINM());
			pJEMPFEIOAK.HCBNCGILGEJ(EIMBOIKCJPE(), 0, FFINCCFLMEL(), GKLNFJPENNB());
			pJEMPFEIOAK.CJOFIDKNECK.Position = 16L;
			return pJEMPFEIOAK;
		}

		public decimal IAFBAOKMODJ()
		{
			return JEJNNDANAPE.ReadDecimal();
		}

		public void CAHACMKBJMI(ref char[] ICENKPDOHBK, int AGJJOHLCJKF)
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadChars(AGJJOHLCJKF);
		}

		public void CAHACMKBJMI(ref char ICENKPDOHBK)
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadChar();
		}

		public long GAGNPBAMJLE()
		{
			return JEJNNDANAPE.ReadInt64();
		}

		public void CAHACMKBJMI(List<ushort> ICENKPDOHBK)
		{
			ushort num = JEJNNDANAPE.ReadUInt16();
			for (ushort num2 = 0; num2 < num; num2++)
			{
				ICENKPDOHBK.Add(JEJNNDANAPE.ReadUInt16());
			}
		}

		public void CAHACMKBJMI(KCIGFAHFHCH OGJFDNEEDCP)
		{
			ushort num = AJPFAAFLHEB();
			OGJFDNEEDCP.DBJEIBMBJKK(num);
			JEJNNDANAPE.Read(OGJFDNEEDCP.EIMBOIKCJPE(), 0, num);
			OGJFDNEEDCP.IKAGBBOMAOP(0);
			OGJFDNEEDCP.HEDMHINGICJ(num);
		}

		public void CAHACMKBJMI(List<uint> ICENKPDOHBK)
		{
			ushort num = JEJNNDANAPE.ReadUInt16();
			for (ushort num2 = 0; num2 < num; num2++)
			{
				ICENKPDOHBK.Add(JEJNNDANAPE.ReadUInt32());
			}
		}

		public IPEndPoint KJFAHHKIGAJ()
		{
			byte[] array = new byte[4];
			JEJNNDANAPE.Read(array, 0, 4);
			ushort port = JEJNNDANAPE.ReadUInt16();
			return new IPEndPoint(new IPAddress(array), port);
		}

		public void CAHACMKBJMI(ref float ICENKPDOHBK)
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadSingle();
		}

		public int PNBKOPGIHDI()
		{
			return JEJNNDANAPE.ReadInt32();
		}

		public void CAHACMKBJMI(ref byte ICENKPDOHBK)
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadByte();
		}

		public uint BMKOKHGAHEC()
		{
			return JEJNNDANAPE.ReadUInt32();
		}

		public void CAHACMKBJMI(ref string ICENKPDOHBK)
		{
			ushort count = JEJNNDANAPE.ReadUInt16();
			byte[] bytes = JEJNNDANAPE.ReadBytes(count);
			ICENKPDOHBK = Encoding.UTF8.GetString(bytes);
		}

		public double PBAFJIENJHC()
		{
			return JEJNNDANAPE.ReadDouble();
		}

		public PJEMPFEIOAK(int POIJPKODPCK)
			: base(POIJPKODPCK)
		{
			JEJNNDANAPE = new BinaryReader(CJOFIDKNECK);
		}

		public ulong ODFEGIDCMPH()
		{
			return JEJNNDANAPE.ReadUInt64();
		}

		public void CAHACMKBJMI(ref ushort ICENKPDOHBK)
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadUInt16();
		}

		public void AAKCBMFHBPO()
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

		public float GCFOKBADLFB()
		{
			return JEJNNDANAPE.ReadSingle();
		}

		public void BNLCLGMMAPD(ref int ICENKPDOHBK)
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadInt32();
		}

		public void FCGDFCGJACC(ref ushort ICENKPDOHBK)
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadUInt16();
		}

		public void CAHACMKBJMI(List<byte> ICENKPDOHBK)
		{
			ushort num = JEJNNDANAPE.ReadUInt16();
			for (ushort num2 = 0; num2 < num; num2++)
			{
				ICENKPDOHBK.Add(JEJNNDANAPE.ReadByte());
			}
		}

		public void ADLGHIAPFHL(List<int> ICENKPDOHBK)
		{
			ushort num = JEJNNDANAPE.ReadUInt16();
			for (ushort num2 = 0; num2 < num; num2++)
			{
				ICENKPDOHBK.Add(JEJNNDANAPE.ReadInt32());
			}
		}

		public static void COILBAOLKDP(int AGJJOHLCJKF)
		{
			for (int i = 0; i < AGJJOHLCJKF; i++)
			{
				PJEMPFEIOAK item = new PJEMPFEIOAK();
				Interlocked.Increment(ref KCEGGENLICB);
				lock (ACAJKFKBHDO)
				{
					ACAJKFKBHDO.Enqueue(item);
				}
			}
		}

		public char KMCJMBPFHPE()
		{
			return JEJNNDANAPE.ReadChar();
		}

		protected override void JDBENBMLFNP(bool BPCKECGFJPA)
		{
			base.JDBENBMLFNP(BPCKECGFJPA);
			if (BPCKECGFJPA)
			{
				JEJNNDANAPE.Close();
				JEJNNDANAPE = null;
			}
		}

		public void OHBHDFIBNBF(ref short ICENKPDOHBK)
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadInt16();
		}

		public DateTime NOIDCBCMCMK()
		{
			long num = JEJNNDANAPE.ReadInt64();
			if (num >= 0L && num <= 3155378975999999999L)
			{
				return new DateTime(num);
			}
			return new DateTime(0L);
		}

		public Guid HMOIDOJKFHP()
		{
			byte[] array = new byte[16];
			JEJNNDANAPE.Read(array, 0, 16);
			return new Guid(array);
		}

		public void HCBNCGILGEJ(byte[] EDMNHDBEPMC, int BFEECILPJLM, int AGJJOHLCJKF, bool PBFJECKBBPJ = true)
		{
			if (AGJJOHLCJKF > CJOFIDKNECK.Capacity)
			{
				DBJEIBMBJKK(AGJJOHLCJKF);
			}
			LLELMDNMEOO(PBFJECKBBPJ);
			CJOFIDKNECK.Write(EDMNHDBEPMC, BFEECILPJLM, AGJJOHLCJKF);
			HFMPDCKODJF(HOKDCGLFEIL.IOLIFEMLNHL(EDMNHDBEPMC, BFEECILPJLM));
		}

		public void CAHACMKBJMI(ref ulong ICENKPDOHBK)
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadUInt64();
		}

		public byte KFAGPDGHEBK()
		{
			return JEJNNDANAPE.ReadByte();
		}

		protected virtual bool BPPABHIDJNM(int MEMIJEBPHIP)
		{
			if (base.DBJEIBMBJKK(MEMIJEBPHIP))
			{
				if (JEJNNDANAPE != null)
				{
					JEJNNDANAPE.Close();
					JEJNNDANAPE = null;
				}
				JEJNNDANAPE = new BinaryReader(CJOFIDKNECK);
				return false;
			}
			return false;
		}

		public PJEMPFEIOAK()
		{
			JEJNNDANAPE = new BinaryReader(CJOFIDKNECK);
		}

		public void CAHACMKBJMI(ref Guid ICENKPDOHBK)
		{
			byte[] array = new byte[16];
			JEJNNDANAPE.Read(array, 0, 16);
			ICENKPDOHBK = new Guid(array);
		}

		public void CAHACMKBJMI(EOPOBHFNFPA OGBMNJBOPHK)
		{
			OGBMNJBOPHK.JCOLMPJMMEB(this);
		}

		public void PCCGOJFLEAJ(ref long ICENKPDOHBK)
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadInt64();
		}

		public void CAPAIIHJJNB(ref bool ICENKPDOHBK)
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadBoolean();
		}

		public void CAHACMKBJMI(ref decimal ICENKPDOHBK)
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadDecimal();
		}
	}
}
