using System;
using System.IO;
using System.Net.Sockets;

namespace EveEngine
{
	public abstract class HOKDCGLFEIL : IDisposable
	{
		public const int AKEJHCPLAFH = 512;

		public const int PNIOFCCKGLO = 100000000;

		public const int DBMJMPNLAAN = 16384;

		public const int BAODIIGDAMK = 1000;

		public const int CEDJEMFIFNA = 16;

		protected MemoryStream CJOFIDKNECK;

		public EventHandler<SocketAsyncEventArgs> HCEDHMOLCEN;

		public bool FFHMJCFIJCO;

		public static uint[] AKKALMDAFGH = new uint[4] { 2522822253u, 3514188164u, 2554300735u, 1315490373u };

		private ushort GFOGNIDHDAB;

		private ushort EEBKBGNIENC;

		private int JAMKAPGHBPK;

		private int JCIANFHIKLA;

		private int NMPLJHGLHBN;

		private bool ODKBLLEBCDC;

		private SocketAsyncEventArgs ABPKLNMEMHM;

		public ushort KFKCHCJEFPK
		{
			get
			{
				return FFINCCFLMEL();
			}
			protected set
			{
				HFMPDCKODJF(value);
			}
		}

		public ushort KKFBGBEPICG
		{
			get
			{
				return PEBCAPNIMOL();
			}
			protected set
			{
				CHBMLBLFHFP(value);
			}
		}

		public int FCHFDJGCFHH
		{
			get
			{
				return OHBIKECIOOA();
			}
			protected set
			{
				FNCFJHKOEKF(value);
			}
		}

		public int CIGEEDBPDDM
		{
			get
			{
				return OGFHNAKAINM();
			}
			protected set
			{
				NOLHBPCCGPB(value);
			}
		}

		public int ODGCBCEMAHH
		{
			get
			{
				return NCHJJNGPOPA();
			}
			protected set
			{
				FFOLMIHPEOF(value);
			}
		}

		public bool JNIFPGGMNHF
		{
			get
			{
				return GKLNFJPENNB();
			}
			protected set
			{
				LLELMDNMEOO(value);
			}
		}

		public SocketAsyncEventArgs NHFFOCHCFNL
		{
			get
			{
				return OGANCGLPGLC();
			}
			protected set
			{
				IELBALDEGEJ(value);
			}
		}

		public HOKDCGLFEIL()
		{
			CJOFIDKNECK = new MemoryStream(512);
			IELBALDEGEJ(new SocketAsyncEventArgs());
			OGANCGLPGLC().UserToken = this;
			OGANCGLPGLC().SetBuffer(CJOFIDKNECK.GetBuffer(), 0, 512);
			HFMPDCKODJF(0);
			CHBMLBLFHFP(0);
			NOLHBPCCGPB(0);
			FNCFJHKOEKF(0);
			FFOLMIHPEOF(0);
			LLELMDNMEOO(false);
		}

		public HOKDCGLFEIL(int POIJPKODPCK)
		{
			CJOFIDKNECK = new MemoryStream(POIJPKODPCK);
			IELBALDEGEJ(new SocketAsyncEventArgs());
			OGANCGLPGLC().UserToken = this;
			OGANCGLPGLC().SetBuffer(CJOFIDKNECK.GetBuffer(), 0, POIJPKODPCK);
			HFMPDCKODJF(0);
			CHBMLBLFHFP(0);
			NOLHBPCCGPB(0);
			FNCFJHKOEKF(0);
			FFOLMIHPEOF(0);
			LLELMDNMEOO(false);
		}

		public ushort FFINCCFLMEL()
		{
			return GFOGNIDHDAB;
		}

		protected void HFMPDCKODJF(ushort ICENKPDOHBK)
		{
			GFOGNIDHDAB = ICENKPDOHBK;
		}

		public ushort PEBCAPNIMOL()
		{
			return EEBKBGNIENC;
		}

		protected void CHBMLBLFHFP(ushort ICENKPDOHBK)
		{
			EEBKBGNIENC = ICENKPDOHBK;
		}

		public int OHBIKECIOOA()
		{
			return JAMKAPGHBPK;
		}

		protected void FNCFJHKOEKF(int ICENKPDOHBK)
		{
			JAMKAPGHBPK = ICENKPDOHBK;
		}

		public int OGFHNAKAINM()
		{
			return JCIANFHIKLA;
		}

		protected void NOLHBPCCGPB(int ICENKPDOHBK)
		{
			JCIANFHIKLA = ICENKPDOHBK;
		}

		public int NCHJJNGPOPA()
		{
			return NMPLJHGLHBN;
		}

		protected void FFOLMIHPEOF(int ICENKPDOHBK)
		{
			NMPLJHGLHBN = ICENKPDOHBK;
		}

		public bool GKLNFJPENNB()
		{
			return ODKBLLEBCDC;
		}

		protected void LLELMDNMEOO(bool ICENKPDOHBK)
		{
			ODKBLLEBCDC = ICENKPDOHBK;
		}

		public SocketAsyncEventArgs OGANCGLPGLC()
		{
			return ABPKLNMEMHM;
		}

		protected void IELBALDEGEJ(SocketAsyncEventArgs ICENKPDOHBK)
		{
			ABPKLNMEMHM = ICENKPDOHBK;
		}

		public virtual void LDNEFFHJNPL()
		{
			HFMPDCKODJF(0);
			CHBMLBLFHFP(0);
			NOLHBPCCGPB(0);
			FNCFJHKOEKF(0);
			FFOLMIHPEOF(0);
			LLELMDNMEOO(false);
			CJOFIDKNECK.Position = 0L;
		}

		public void Dispose()
		{
			JDBENBMLFNP(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void JDBENBMLFNP(bool BPCKECGFJPA)
		{
			if (BPCKECGFJPA)
			{
				OGANCGLPGLC().Dispose();
				CJOFIDKNECK.Dispose();
			}
		}

		protected virtual bool DBJEIBMBJKK(int BAIOLIOHGAA)
		{
			if (BAIOLIOHGAA <= CJOFIDKNECK.Capacity)
			{
				return false;
			}
			int num;
			for (num = CJOFIDKNECK.Capacity; num < BAIOLIOHGAA; num *= 2)
			{
			}
			MemoryStream memoryStream = new MemoryStream(num);
			CJOFIDKNECK.WriteTo(memoryStream);
			memoryStream.Position = CJOFIDKNECK.Position;
			CJOFIDKNECK.Dispose();
			CJOFIDKNECK = memoryStream;
			OGANCGLPGLC().SetBuffer(CJOFIDKNECK.GetBuffer(), 0, num);
			return true;
		}

		private bool BFPFOKCJOCH()
		{
			if (FFINCCFLMEL() == 0 || FFINCCFLMEL() > CJOFIDKNECK.Capacity)
			{
				return false;
			}
			return true;
		}

		public void DGFDHOLDCDL(ushort OHGOBGOIECH)
		{
			CHBMLBLFHFP(OHGOBGOIECH);
		}

		public ushort KCGNKBDGONC()
		{
			return PEBCAPNIMOL();
		}

		public byte[] EIMBOIKCJPE()
		{
			return CJOFIDKNECK.GetBuffer();
		}

		public int EJGJCLHFIAM()
		{
			return (int)CJOFIDKNECK.Position;
		}

		public void BFFJJKCEODA(EventHandler<SocketAsyncEventArgs> JAKNGPIIAKM)
		{
			if (HCEDHMOLCEN != null)
			{
				OGANCGLPGLC().Completed -= HCEDHMOLCEN;
			}
			HCEDHMOLCEN = JAKNGPIIAKM;
			OGANCGLPGLC().Completed += HCEDHMOLCEN;
		}

		internal void KDOJNBAJJEO(int CMGMOJAFLFL)
		{
			CJOFIDKNECK.Position = CMGMOJAFLFL;
		}

		public static ushort IOLIFEMLNHL(byte[] EDMNHDBEPMC, int BFEECILPJLM)
		{
			if (BitConverter.IsLittleEndian)
			{
				return BitConverter.ToUInt16(EDMNHDBEPMC, BFEECILPJLM);
			}
			return BitConverter.ToUInt16(new byte[2]
			{
				EDMNHDBEPMC[BFEECILPJLM + 1],
				EDMNHDBEPMC[BFEECILPJLM]
			}, 0);
		}
	}
}
