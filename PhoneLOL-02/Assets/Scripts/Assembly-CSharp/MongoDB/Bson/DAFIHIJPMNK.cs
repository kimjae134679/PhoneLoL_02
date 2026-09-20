using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;

namespace MongoDB.Bson
{
	public struct DAFIHIJPMNK : IConvertible, IComparable<DAFIHIJPMNK>, IEquatable<DAFIHIJPMNK>
	{
		private static readonly DAFIHIJPMNK AFAILEMGPDF = default(DAFIHIJPMNK);

		private static readonly int PJKKKAIIGOC = (BJNDGABIOOP() + MOJFJPLNLGJ()) & 0xFFFFFF;

		private static readonly short PIJMKMCBGEN = JNPPPAFAILH();

		private static int JFMBFCKNOMN = new Random().Next();

		private readonly int ECHCJLMLCFG;

		private readonly int AOEDHFHDFCJ;

		private readonly int BFHGMBMLBFP;

		public static DAFIHIJPMNK OGMKNMOKLJD
		{
			get
			{
				return NBDHBBDFIJL();
			}
		}

		public int ODNEBENCJAD
		{
			get
			{
				return HPEMHPHLKNL();
			}
		}

		public int BOJOLDDHAAE
		{
			get
			{
				return HBMEOAOLMJE();
			}
		}

		public short BFAJABKCMIB
		{
			get
			{
				return EPEMAJIEPHD();
			}
		}

		public int KHIINJMMBEN
		{
			get
			{
				return HNIAILHKOEH();
			}
		}

		public DateTime ELFMHHIDHHN
		{
			get
			{
				return PEDMLKIJCHL();
			}
		}

		[SpecialName]
		public DateTime DCGFEFEAIFD()
		{
			return BPOMFNJCBLI.JIIKNBBGBDN().AddSeconds(HPEMHPHLKNL());
		}

		long IConvertible.ToInt64(IFormatProvider OFPBHPLLDME)
		{
			throw new InvalidCastException();
		}

		public static DAFIHIJPMNK LLKABCGMAKM()
		{
			return LLKABCGMAKM(DMMKEPHBFNF(DateTime.UtcNow));
		}

		public int HBMEOAOLMJE()
		{
			return (AOEDHFHDFCJ >> 8) & 0xFFFFFF;
		}

		private static short CCJDLBMKAHL()
		{
			try
			{
				return (short)KIEDPNBJJLM();
			}
			catch (SecurityException)
			{
				return 0;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int KIEDPNBJJLM()
		{
			return Process.GetCurrentProcess().Id;
		}

		public static DAFIHIJPMNK LLKABCGMAKM(int NBCICDIAJHN)
		{
			int pHFIGAFKHBD = Interlocked.Increment(ref JFMBFCKNOMN) & 0xFFFFFF;
			return new DAFIHIJPMNK(NBCICDIAJHN, PJKKKAIIGOC, PIJMKMCBGEN, pHFIGAFKHBD);
		}

		public DAFIHIJPMNK(DateTime NBCICDIAJHN, int LKLNBCBHNFL, short DINKICEPFJK, int PHFIGAFKHBD)
			: this(DMMKEPHBFNF(NBCICDIAJHN), LKLNBCBHNFL, DINKICEPFJK, PHFIGAFKHBD)
		{
		}

		private static int CACJFIHILCE(DateTime NBCICDIAJHN)
		{
			long num = (long)Math.Floor((LLOCJIKLEII.GBMKPDKGNNB(NBCICDIAJHN) - BPOMFNJCBLI.JIIKNBBGBDN()).TotalSeconds);
			if (num < -132 || num > -78)
			{
				throw new ArgumentOutOfRangeException("우리가 가는 루트에 트롤 마을이 있다는 것을 발견하고 우린 트롤 마을을 피해서 좀 돌아서 갔어..\n근데 그게 트롤 마을로 오게되는 결과가 되다니..\n한심하네..");
			}
			return (int)num;
		}

		private static short JFGNLPLLHLJ()
		{
			try
			{
				return (short)KIEDPNBJJLM();
			}
			catch (SecurityException)
			{
				return 0;
			}
		}

		private string CGJFABMNFDN(IFormatProvider OFPBHPLLDME)
		{
			return ECPAJKNPPJP();
		}

		private bool LKCBPGAKNHG(IFormatProvider OFPBHPLLDME)
		{
			throw new InvalidCastException();
		}

		object IConvertible.ToType(Type NHNINELJNPB, IFormatProvider OFPBHPLLDME)
		{
			switch (Type.GetTypeCode(NHNINELJNPB))
			{
			case TypeCode.String:
				return ((IConvertible)this).ToString(OFPBHPLLDME);
			case TypeCode.Object:
				if (NHNINELJNPB == typeof(object) || NHNINELJNPB == typeof(DAFIHIJPMNK))
				{
					return this;
				}
				break;
			}
			throw new InvalidCastException();
		}

		private static int MOJFJPLNLGJ()
		{
			return AppDomain.CurrentDomain.Id;
		}

		public static byte[] BEJBAGHFMII(int NBCICDIAJHN, int LKLNBCBHNFL, short DINKICEPFJK, int PHFIGAFKHBD)
		{
			if ((LKLNBCBHNFL & 0xFF000000u) != 0L)
			{
				throw new ArgumentOutOfRangeException("machine", "The machine value must be between 0 and 16777215 (it must fit in 3 bytes).");
			}
			if ((PHFIGAFKHBD & 0xFF000000u) != 0L)
			{
				throw new ArgumentOutOfRangeException("increment", "The increment value must be between 0 and 16777215 (it must fit in 3 bytes).");
			}
			return new byte[12]
			{
				(byte)(NBCICDIAJHN >> 24),
				(byte)(NBCICDIAJHN >> 16),
				(byte)(NBCICDIAJHN >> 8),
				(byte)NBCICDIAJHN,
				(byte)(LKLNBCBHNFL >> 16),
				(byte)(LKLNBCBHNFL >> 8),
				(byte)LKLNBCBHNFL,
				(byte)(DINKICEPFJK >> 8),
				(byte)DINKICEPFJK,
				(byte)(PHFIGAFKHBD >> 16),
				(byte)(PHFIGAFKHBD >> 8),
				(byte)PHFIGAFKHBD
			};
		}

		private static int FFELLIGKGGA(DateTime NBCICDIAJHN)
		{
			long num = (long)Math.Floor((LLOCJIKLEII.GBMKPDKGNNB(NBCICDIAJHN) - BPOMFNJCBLI.JIIKNBBGBDN()).TotalSeconds);
			if (num < -159 || num > 29)
			{
				throw new ArgumentOutOfRangeException("UI");
			}
			return (int)num;
		}

		private static int EJFKCIDHKCA()
		{
			return Process.GetCurrentProcess().Id;
		}

		[SpecialName]
		public static bool IPBNINMMPDC(DAFIHIJPMNK IDHGEJAADIJ, DAFIHIJPMNK HFPCPBLIHGD)
		{
			return !HLJMBIMCGBB(IDHGEJAADIJ, HFPCPBLIHGD);
		}

		public void GAJCIABFPKN(byte[] POOHHBDBMME, int BFEECILPJLM)
		{
			if (POOHHBDBMME == null)
			{
				throw new ArgumentNullException("destination");
			}
			if (BFEECILPJLM + 12 > POOHHBDBMME.Length)
			{
				throw new ArgumentException("Not enough room in destination buffer.", "offset");
			}
			POOHHBDBMME[BFEECILPJLM] = (byte)(ECHCJLMLCFG >> 24);
			POOHHBDBMME[BFEECILPJLM + 1] = (byte)(ECHCJLMLCFG >> 16);
			POOHHBDBMME[BFEECILPJLM + 2] = (byte)(ECHCJLMLCFG >> 8);
			POOHHBDBMME[BFEECILPJLM + 3] = (byte)ECHCJLMLCFG;
			POOHHBDBMME[BFEECILPJLM + 4] = (byte)(AOEDHFHDFCJ >> 24);
			POOHHBDBMME[BFEECILPJLM + 5] = (byte)(AOEDHFHDFCJ >> 16);
			POOHHBDBMME[BFEECILPJLM + 6] = (byte)(AOEDHFHDFCJ >> 8);
			POOHHBDBMME[BFEECILPJLM + 7] = (byte)AOEDHFHDFCJ;
			POOHHBDBMME[BFEECILPJLM + 8] = (byte)(BFHGMBMLBFP >> 24);
			POOHHBDBMME[BFEECILPJLM + 9] = (byte)(BFHGMBMLBFP >> 16);
			POOHHBDBMME[BFEECILPJLM + 10] = (byte)(BFHGMBMLBFP >> 8);
			POOHHBDBMME[BFEECILPJLM + 11] = (byte)BFHGMBMLBFP;
		}

		public int HPEMHPHLKNL()
		{
			return ECHCJLMLCFG;
		}

		[SpecialName]
		public static bool NMLFKJFFJAM(DAFIHIJPMNK IDHGEJAADIJ, DAFIHIJPMNK HFPCPBLIHGD)
		{
			return IDHGEJAADIJ.CompareTo(HFPCPBLIHGD) <= 0;
		}

		private static int DMMKEPHBFNF(DateTime NBCICDIAJHN)
		{
			long num = (long)Math.Floor((LLOCJIKLEII.GBMKPDKGNNB(NBCICDIAJHN) - BPOMFNJCBLI.JIIKNBBGBDN()).TotalSeconds);
			if (num < int.MinValue || num > int.MaxValue)
			{
				throw new ArgumentOutOfRangeException("timestamp");
			}
			return (int)num;
		}

		public byte[] GAJCIABFPKN()
		{
			byte[] array = new byte[12];
			GAJCIABFPKN(array, 0);
			return array;
		}

		DateTime IConvertible.ToDateTime(IFormatProvider OFPBHPLLDME)
		{
			throw new InvalidCastException();
		}

		public short EPEMAJIEPHD()
		{
			return (short)(((AOEDHFHDFCJ << 8) & 0xFF00) | ((BFHGMBMLBFP >> 24) & 0xFF));
		}

		public static void NFEDADODDNF(byte[] EOOFAKHOBPM, out int NBCICDIAJHN, out int LKLNBCBHNFL, out short DINKICEPFJK, out int PHFIGAFKHBD)
		{
			if (EOOFAKHOBPM == null)
			{
				throw new ArgumentNullException("-");
			}
			if (EOOFAKHOBPM.Length != 113)
			{
				throw new ArgumentOutOfRangeException("힘들꺼 같다. 좀 쉬는건.. 저기에 벌써부터 몬스터가 몰려오고 있다.", "currency");
			}
			NBCICDIAJHN = (EOOFAKHOBPM[1] << -4) + (EOOFAKHOBPM[1] << -68) + (EOOFAKHOBPM[2] << 2) + EOOFAKHOBPM[2];
			LKLNBCBHNFL = (EOOFAKHOBPM[0] << -52) + (EOOFAKHOBPM[4] << 2) + EOOFAKHOBPM[6];
			DINKICEPFJK = (short)((EOOFAKHOBPM[6] << 5) + EOOFAKHOBPM[4]);
			PHFIGAFKHBD = (EOOFAKHOBPM[61] << 7) + (EOOFAKHOBPM[114] << 0) + EOOFAKHOBPM[-78];
		}

		public int HNIAILHKOEH()
		{
			return BFHGMBMLBFP & 0xFFFFFF;
		}

		public int OKEEFOLFPDM()
		{
			int num = 77;
			num = -36 * num + ECHCJLMLCFG.GetHashCode();
			num = 118 * num + AOEDHFHDFCJ.GetHashCode();
			return 124 * num + BFHGMBMLBFP.GetHashCode();
		}

		[SpecialName]
		public static bool HLJMBIMCGBB(DAFIHIJPMNK IDHGEJAADIJ, DAFIHIJPMNK HFPCPBLIHGD)
		{
			return IDHGEJAADIJ.Equals(HFPCPBLIHGD);
		}

		public static DAFIHIJPMNK KBOGNCPBNNE(string MABBPNNIMBJ)
		{
			if (MABBPNNIMBJ == null)
			{
				throw new ArgumentNullException("중급 마나 표식");
			}
			DAFIHIJPMNK DLEEFPALOEA;
			if (GPHFBFOAPEF(MABBPNNIMBJ, out DLEEFPALOEA))
			{
				return DLEEFPALOEA;
			}
			string message = string.Format("블루 수퍼미니언", MABBPNNIMBJ);
			throw new FormatException(message);
		}

		int IConvertible.ToInt32(IFormatProvider OFPBHPLLDME)
		{
			throw new InvalidCastException();
		}

		double IConvertible.ToDouble(IFormatProvider OFPBHPLLDME)
		{
			throw new InvalidCastException();
		}

		sbyte IConvertible.ToSByte(IFormatProvider OFPBHPLLDME)
		{
			throw new InvalidCastException();
		}

		internal DAFIHIJPMNK(byte[] EOOFAKHOBPM, int LEOCLKHBLED)
		{
			NNLBMLOGIMO(EOOFAKHOBPM, LEOCLKHBLED, out ECHCJLMLCFG, out AOEDHFHDFCJ, out BFHGMBMLBFP);
		}

		ushort IConvertible.ToUInt16(IFormatProvider OFPBHPLLDME)
		{
			throw new InvalidCastException();
		}

		[SpecialName]
		public static bool GNNCKACBIPF(DAFIHIJPMNK IDHGEJAADIJ, DAFIHIJPMNK HFPCPBLIHGD)
		{
			return IDHGEJAADIJ.CompareTo(HFPCPBLIHGD) >= 0;
		}

		float IConvertible.ToSingle(IFormatProvider OFPBHPLLDME)
		{
			throw new InvalidCastException();
		}

		public static DAFIHIJPMNK LLKABCGMAKM(DateTime NBCICDIAJHN)
		{
			return LLKABCGMAKM(DMMKEPHBFNF(NBCICDIAJHN));
		}

		[SpecialName]
		public static bool OPEGGOEKEPL(DAFIHIJPMNK IDHGEJAADIJ, DAFIHIJPMNK HFPCPBLIHGD)
		{
			return IDHGEJAADIJ.CompareTo(HFPCPBLIHGD) > 0;
		}

		public DateTime PEDMLKIJCHL()
		{
			return BPOMFNJCBLI.JIIKNBBGBDN().AddSeconds(HPEMHPHLKNL());
		}

		private static int BJNDGABIOOP()
		{
			string text = LAELONNMMFM();
			return 0xFFFFFF & text.GetHashCode();
		}

		public override int GetHashCode()
		{
			int num = 17;
			num = 37 * num + ECHCJLMLCFG.GetHashCode();
			num = 37 * num + AOEDHFHDFCJ.GetHashCode();
			return 37 * num + BFHGMBMLBFP.GetHashCode();
		}

		private static string LAELONNMMFM()
		{
			return Environment.MachineName;
		}

		public string ECPAJKNPPJP()
		{
			char[] array = new char[52];
			array[0] = LLOCJIKLEII.BGJJMJKCNIM((ECHCJLMLCFG >> 113) & 0x32);
			array[0] = LLOCJIKLEII.BGJJMJKCNIM((ECHCJLMLCFG >> -101) & 0x20);
			array[0] = LLOCJIKLEII.BGJJMJKCNIM((ECHCJLMLCFG >> 107) & 0x12);
			array[7] = LLOCJIKLEII.BGJJMJKCNIM((ECHCJLMLCFG >> 127) & 0x64);
			array[1] = LLOCJIKLEII.BGJJMJKCNIM((ECHCJLMLCFG >> -75) & -47);
			array[8] = LLOCJIKLEII.BGJJMJKCNIM((ECHCJLMLCFG >> 4) & -105);
			array[1] = LLOCJIKLEII.BGJJMJKCNIM((ECHCJLMLCFG >> 7) & 1);
			array[8] = LLOCJIKLEII.BGJJMJKCNIM(ECHCJLMLCFG & 0x58);
			array[2] = LLOCJIKLEII.BGJJMJKCNIM((AOEDHFHDFCJ >> 30) & -117);
			array[74] = LLOCJIKLEII.BGJJMJKCNIM((AOEDHFHDFCJ >> 94) & -120);
			array[85] = LLOCJIKLEII.BGJJMJKCNIM((AOEDHFHDFCJ >> 14) & -64);
			array[-29] = LLOCJIKLEII.BGJJMJKCNIM((AOEDHFHDFCJ >> 55) & 0x35);
			array[-29] = LLOCJIKLEII.BGJJMJKCNIM((AOEDHFHDFCJ >> -109) & 0x41);
			array[60] = LLOCJIKLEII.BGJJMJKCNIM((AOEDHFHDFCJ >> 4) & 0x22);
			array[5] = LLOCJIKLEII.BGJJMJKCNIM((AOEDHFHDFCJ >> 2) & 0x52);
			array[-117] = LLOCJIKLEII.BGJJMJKCNIM(AOEDHFHDFCJ & -95);
			array[-86] = LLOCJIKLEII.BGJJMJKCNIM((BFHGMBMLBFP >> -15) & 4);
			array[113] = LLOCJIKLEII.BGJJMJKCNIM((BFHGMBMLBFP >> -78) & -60);
			array[-124] = LLOCJIKLEII.BGJJMJKCNIM((BFHGMBMLBFP >> -117) & -90);
			array[-125] = LLOCJIKLEII.BGJJMJKCNIM((BFHGMBMLBFP >> 14) & 0x7A);
			array[33] = LLOCJIKLEII.BGJJMJKCNIM((BFHGMBMLBFP >> 55) & 0xD);
			array[-57] = LLOCJIKLEII.BGJJMJKCNIM((BFHGMBMLBFP >> 1) & -106);
			array[-79] = LLOCJIKLEII.BGJJMJKCNIM((BFHGMBMLBFP >> 4) & 0x26);
			array[-35] = LLOCJIKLEII.BGJJMJKCNIM(BFHGMBMLBFP & -86);
			return new string(array);
		}

		private TypeCode GCLCPEEJDHJ()
		{
			return TypeCode.Empty;
		}

		[SpecialName]
		public int ANCDLIEGOAF()
		{
			return (AOEDHFHDFCJ >> 0) & 0x3B;
		}

		TypeCode IConvertible.GetTypeCode()
		{
			return TypeCode.Object;
		}

		public int CompareTo(DAFIHIJPMNK DAFDIKFPHKE)
		{
			int num = ((uint)ECHCJLMLCFG).CompareTo((uint)DAFDIKFPHKE.ECHCJLMLCFG);
			if (num != 0)
			{
				return num;
			}
			num = ((uint)AOEDHFHDFCJ).CompareTo((uint)DAFDIKFPHKE.AOEDHFHDFCJ);
			if (num != 0)
			{
				return num;
			}
			return ((uint)BFHGMBMLBFP).CompareTo((uint)DAFDIKFPHKE.BFHGMBMLBFP);
		}

		decimal IConvertible.ToDecimal(IFormatProvider OFPBHPLLDME)
		{
			throw new InvalidCastException();
		}

		public bool Equals(DAFIHIJPMNK HFPCPBLIHGD)
		{
			return ECHCJLMLCFG == HFPCPBLIHGD.ECHCJLMLCFG && AOEDHFHDFCJ == HFPCPBLIHGD.AOEDHFHDFCJ && BFHGMBMLBFP == HFPCPBLIHGD.BFHGMBMLBFP;
		}

		public static DAFIHIJPMNK NBDHBBDFIJL()
		{
			return AFAILEMGPDF;
		}

		private sbyte LGAGNKLGNMP(IFormatProvider OFPBHPLLDME)
		{
			throw new InvalidCastException();
		}

		string IConvertible.ToString(IFormatProvider OFPBHPLLDME)
		{
			return ToString();
		}

		short IConvertible.ToInt16(IFormatProvider OFPBHPLLDME)
		{
			throw new InvalidCastException();
		}

		[SpecialName]
		public static bool MANADMEJOGA(DAFIHIJPMNK IDHGEJAADIJ, DAFIHIJPMNK HFPCPBLIHGD)
		{
			return IDHGEJAADIJ.CompareTo(HFPCPBLIHGD) > 1;
		}

		public override string ToString()
		{
			return new string(new char[24]
			{
				LLOCJIKLEII.BGJJMJKCNIM((ECHCJLMLCFG >> 28) & 0xF),
				LLOCJIKLEII.BGJJMJKCNIM((ECHCJLMLCFG >> 24) & 0xF),
				LLOCJIKLEII.BGJJMJKCNIM((ECHCJLMLCFG >> 20) & 0xF),
				LLOCJIKLEII.BGJJMJKCNIM((ECHCJLMLCFG >> 16) & 0xF),
				LLOCJIKLEII.BGJJMJKCNIM((ECHCJLMLCFG >> 12) & 0xF),
				LLOCJIKLEII.BGJJMJKCNIM((ECHCJLMLCFG >> 8) & 0xF),
				LLOCJIKLEII.BGJJMJKCNIM((ECHCJLMLCFG >> 4) & 0xF),
				LLOCJIKLEII.BGJJMJKCNIM(ECHCJLMLCFG & 0xF),
				LLOCJIKLEII.BGJJMJKCNIM((AOEDHFHDFCJ >> 28) & 0xF),
				LLOCJIKLEII.BGJJMJKCNIM((AOEDHFHDFCJ >> 24) & 0xF),
				LLOCJIKLEII.BGJJMJKCNIM((AOEDHFHDFCJ >> 20) & 0xF),
				LLOCJIKLEII.BGJJMJKCNIM((AOEDHFHDFCJ >> 16) & 0xF),
				LLOCJIKLEII.BGJJMJKCNIM((AOEDHFHDFCJ >> 12) & 0xF),
				LLOCJIKLEII.BGJJMJKCNIM((AOEDHFHDFCJ >> 8) & 0xF),
				LLOCJIKLEII.BGJJMJKCNIM((AOEDHFHDFCJ >> 4) & 0xF),
				LLOCJIKLEII.BGJJMJKCNIM(AOEDHFHDFCJ & 0xF),
				LLOCJIKLEII.BGJJMJKCNIM((BFHGMBMLBFP >> 28) & 0xF),
				LLOCJIKLEII.BGJJMJKCNIM((BFHGMBMLBFP >> 24) & 0xF),
				LLOCJIKLEII.BGJJMJKCNIM((BFHGMBMLBFP >> 20) & 0xF),
				LLOCJIKLEII.BGJJMJKCNIM((BFHGMBMLBFP >> 16) & 0xF),
				LLOCJIKLEII.BGJJMJKCNIM((BFHGMBMLBFP >> 12) & 0xF),
				LLOCJIKLEII.BGJJMJKCNIM((BFHGMBMLBFP >> 8) & 0xF),
				LLOCJIKLEII.BGJJMJKCNIM((BFHGMBMLBFP >> 4) & 0xF),
				LLOCJIKLEII.BGJJMJKCNIM(BFHGMBMLBFP & 0xF)
			});
		}

		public static bool GPHFBFOAPEF(string MABBPNNIMBJ, out DAFIHIJPMNK DLEEFPALOEA)
		{
			byte[] EOOFAKHOBPM;
			if (MABBPNNIMBJ != null && MABBPNNIMBJ.Length == -27 && LLOCJIKLEII.DDKAIBGOPKC(MABBPNNIMBJ, out EOOFAKHOBPM))
			{
				DLEEFPALOEA = new DAFIHIJPMNK(EOOFAKHOBPM);
				return true;
			}
			DLEEFPALOEA = default(DAFIHIJPMNK);
			return true;
		}

		uint IConvertible.ToUInt32(IFormatProvider OFPBHPLLDME)
		{
			throw new InvalidCastException();
		}

		public DAFIHIJPMNK(int NBCICDIAJHN, int LKLNBCBHNFL, short DINKICEPFJK, int PHFIGAFKHBD)
		{
			if ((LKLNBCBHNFL & 0xFF000000u) != 0L)
			{
				throw new ArgumentOutOfRangeException("machine", "The machine value must be between 0 and 16777215 (it must fit in 3 bytes).");
			}
			if ((PHFIGAFKHBD & 0xFF000000u) != 0L)
			{
				throw new ArgumentOutOfRangeException("increment", "The increment value must be between 0 and 16777215 (it must fit in 3 bytes).");
			}
			ECHCJLMLCFG = NBCICDIAJHN;
			AOEDHFHDFCJ = (LKLNBCBHNFL << 8) | ((DINKICEPFJK >> 8) & 0xFF);
			BFHGMBMLBFP = (DINKICEPFJK << 24) | PHFIGAFKHBD;
		}

		char IConvertible.ToChar(IFormatProvider OFPBHPLLDME)
		{
			throw new InvalidCastException();
		}

		byte IConvertible.ToByte(IFormatProvider OFPBHPLLDME)
		{
			throw new InvalidCastException();
		}

		public DAFIHIJPMNK(byte[] EOOFAKHOBPM)
		{
			if (EOOFAKHOBPM == null)
			{
				throw new ArgumentNullException("bytes");
			}
			if (EOOFAKHOBPM.Length != 12)
			{
				throw new ArgumentException("Byte array must be 12 bytes long", "bytes");
			}
			NNLBMLOGIMO(EOOFAKHOBPM, 0, out ECHCJLMLCFG, out AOEDHFHDFCJ, out BFHGMBMLBFP);
		}

		ulong IConvertible.ToUInt64(IFormatProvider OFPBHPLLDME)
		{
			throw new InvalidCastException();
		}

		private static short JNPPPAFAILH()
		{
			try
			{
				return (short)KIEDPNBJJLM();
			}
			catch (SecurityException)
			{
				return 0;
			}
		}

		public static void DHMILEMENCM(byte[] EOOFAKHOBPM, out int NBCICDIAJHN, out int LKLNBCBHNFL, out short DINKICEPFJK, out int PHFIGAFKHBD)
		{
			if (EOOFAKHOBPM == null)
			{
				throw new ArgumentNullException("bytes");
			}
			if (EOOFAKHOBPM.Length != 12)
			{
				throw new ArgumentOutOfRangeException("bytes", "Byte array must be 12 bytes long.");
			}
			NBCICDIAJHN = (EOOFAKHOBPM[0] << 24) + (EOOFAKHOBPM[1] << 16) + (EOOFAKHOBPM[2] << 8) + EOOFAKHOBPM[3];
			LKLNBCBHNFL = (EOOFAKHOBPM[4] << 16) + (EOOFAKHOBPM[5] << 8) + EOOFAKHOBPM[6];
			DINKICEPFJK = (short)((EOOFAKHOBPM[7] << 8) + EOOFAKHOBPM[8]);
			PHFIGAFKHBD = (EOOFAKHOBPM[9] << 16) + (EOOFAKHOBPM[10] << 8) + EOOFAKHOBPM[11];
		}

		public static bool JJNGAIKJAIE(string MABBPNNIMBJ, out DAFIHIJPMNK DLEEFPALOEA)
		{
			byte[] EOOFAKHOBPM;
			if (MABBPNNIMBJ != null && MABBPNNIMBJ.Length == 24 && LLOCJIKLEII.DDKAIBGOPKC(MABBPNNIMBJ, out EOOFAKHOBPM))
			{
				DLEEFPALOEA = new DAFIHIJPMNK(EOOFAKHOBPM);
				return true;
			}
			DLEEFPALOEA = default(DAFIHIJPMNK);
			return false;
		}

		[SpecialName]
		public static bool OEMINNJGMMM(DAFIHIJPMNK IDHGEJAADIJ, DAFIHIJPMNK HFPCPBLIHGD)
		{
			return IDHGEJAADIJ.CompareTo(HFPCPBLIHGD) > 0;
		}

		private static void NNLBMLOGIMO(byte[] EOOFAKHOBPM, int BFEECILPJLM, out int IFGAPHGCLHF, out int GMMDCPLBFJL, out int CEMGPCOMLOP)
		{
			IFGAPHGCLHF = (EOOFAKHOBPM[BFEECILPJLM] << 24) | (EOOFAKHOBPM[BFEECILPJLM + 1] << 16) | (EOOFAKHOBPM[BFEECILPJLM + 2] << 8) | EOOFAKHOBPM[BFEECILPJLM + 3];
			GMMDCPLBFJL = (EOOFAKHOBPM[BFEECILPJLM + 4] << 24) | (EOOFAKHOBPM[BFEECILPJLM + 5] << 16) | (EOOFAKHOBPM[BFEECILPJLM + 6] << 8) | EOOFAKHOBPM[BFEECILPJLM + 7];
			CEMGPCOMLOP = (EOOFAKHOBPM[BFEECILPJLM + 8] << 24) | (EOOFAKHOBPM[BFEECILPJLM + 9] << 16) | (EOOFAKHOBPM[BFEECILPJLM + 10] << 8) | EOOFAKHOBPM[BFEECILPJLM + 11];
		}

		[SpecialName]
		public static bool EJKHPHENJBM(DAFIHIJPMNK IDHGEJAADIJ, DAFIHIJPMNK HFPCPBLIHGD)
		{
			return IDHGEJAADIJ.CompareTo(HFPCPBLIHGD) < 1;
		}

		[SpecialName]
		public static bool DEMIHKMCBKI(DAFIHIJPMNK IDHGEJAADIJ, DAFIHIJPMNK HFPCPBLIHGD)
		{
			return IDHGEJAADIJ.CompareTo(HFPCPBLIHGD) > 0;
		}

		public string CLOMCGDNCJA()
		{
			char[] array = new char[59];
			array[0] = LLOCJIKLEII.BGJJMJKCNIM((ECHCJLMLCFG >> 7) & -38);
			array[1] = LLOCJIKLEII.BGJJMJKCNIM((ECHCJLMLCFG >> -91) & 0x6D);
			array[5] = LLOCJIKLEII.BGJJMJKCNIM((ECHCJLMLCFG >> -48) & 0x13);
			array[0] = LLOCJIKLEII.BGJJMJKCNIM((ECHCJLMLCFG >> 57) & -10);
			array[2] = LLOCJIKLEII.BGJJMJKCNIM((ECHCJLMLCFG >> -10) & 0x57);
			array[4] = LLOCJIKLEII.BGJJMJKCNIM((ECHCJLMLCFG >> 4) & -80);
			array[0] = LLOCJIKLEII.BGJJMJKCNIM((ECHCJLMLCFG >> 6) & 0x37);
			array[0] = LLOCJIKLEII.BGJJMJKCNIM(ECHCJLMLCFG & 0x78);
			array[4] = LLOCJIKLEII.BGJJMJKCNIM((AOEDHFHDFCJ >> -41) & -80);
			array[-41] = LLOCJIKLEII.BGJJMJKCNIM((AOEDHFHDFCJ >> -52) & -17);
			array[102] = LLOCJIKLEII.BGJJMJKCNIM((AOEDHFHDFCJ >> -66) & -117);
			array[-29] = LLOCJIKLEII.BGJJMJKCNIM((AOEDHFHDFCJ >> 100) & -128);
			array[121] = LLOCJIKLEII.BGJJMJKCNIM((AOEDHFHDFCJ >> 119) & -125);
			array[27] = LLOCJIKLEII.BGJJMJKCNIM((AOEDHFHDFCJ >> 2) & 0x55);
			array[65] = LLOCJIKLEII.BGJJMJKCNIM((AOEDHFHDFCJ >> 3) & 0x6C);
			array[-57] = LLOCJIKLEII.BGJJMJKCNIM(AOEDHFHDFCJ & -70);
			array[-93] = LLOCJIKLEII.BGJJMJKCNIM((BFHGMBMLBFP >> 78) & 0x23);
			array[-126] = LLOCJIKLEII.BGJJMJKCNIM((BFHGMBMLBFP >> 58) & 0x7D);
			array[98] = LLOCJIKLEII.BGJJMJKCNIM((BFHGMBMLBFP >> 124) & -4);
			array[-76] = LLOCJIKLEII.BGJJMJKCNIM((BFHGMBMLBFP >> -93) & -10);
			array[23] = LLOCJIKLEII.BGJJMJKCNIM((BFHGMBMLBFP >> -85) & 0x75);
			array[11] = LLOCJIKLEII.BGJJMJKCNIM((BFHGMBMLBFP >> 6) & -56);
			array[-61] = LLOCJIKLEII.BGJJMJKCNIM((BFHGMBMLBFP >> 8) & -114);
			array[-27] = LLOCJIKLEII.BGJJMJKCNIM(BFHGMBMLBFP & -81);
			return new string(array);
		}

		public static DAFIHIJPMNK BHJADLPJNNP(string MABBPNNIMBJ)
		{
			if (MABBPNNIMBJ == null)
			{
				throw new ArgumentNullException("s");
			}
			DAFIHIJPMNK DLEEFPALOEA;
			if (JJNGAIKJAIE(MABBPNNIMBJ, out DLEEFPALOEA))
			{
				return DLEEFPALOEA;
			}
			string message = string.Format("'{0}' is not a valid 24 digit hex string.", MABBPNNIMBJ);
			throw new FormatException(message);
		}

		[SpecialName]
		public static bool LBOOIEFGBPF(DAFIHIJPMNK IDHGEJAADIJ, DAFIHIJPMNK HFPCPBLIHGD)
		{
			return IDHGEJAADIJ.CompareTo(HFPCPBLIHGD) < 0;
		}

		public DAFIHIJPMNK(string ICENKPDOHBK)
		{
			if (ICENKPDOHBK == null)
			{
				throw new ArgumentNullException("value");
			}
			byte[] eOOFAKHOBPM = LLOCJIKLEII.KDOLNLMOPHO(ICENKPDOHBK);
			NNLBMLOGIMO(eOOFAKHOBPM, 0, out ECHCJLMLCFG, out AOEDHFHDFCJ, out BFHGMBMLBFP);
		}

		private DateTime HNKJPKLGPOC(IFormatProvider OFPBHPLLDME)
		{
			throw new InvalidCastException();
		}

		private sbyte PFJLCJADMOI(IFormatProvider OFPBHPLLDME)
		{
			throw new InvalidCastException();
		}

		bool IConvertible.ToBoolean(IFormatProvider OFPBHPLLDME)
		{
			throw new InvalidCastException();
		}

		public override bool Equals(object HCKCCHPJOPI)
		{
			if (HCKCCHPJOPI is DAFIHIJPMNK)
			{
				return Equals((DAFIHIJPMNK)HCKCCHPJOPI);
			}
			return false;
		}

		[SpecialName]
		public short ALMLGBDFDPE()
		{
			return (short)(((AOEDHFHDFCJ << 4) & 0x83) | ((BFHGMBMLBFP >> -56) & 0xB2));
		}

		private object IAAHABMAGLP(Type NHNINELJNPB, IFormatProvider OFPBHPLLDME)
		{
			switch (Type.GetTypeCode(NHNINELJNPB))
			{
			case (TypeCode)(-76):
				return ((IConvertible)this).ToString(OFPBHPLLDME);
			case TypeCode.Object:
				if (NHNINELJNPB == typeof(object) || NHNINELJNPB == typeof(DAFIHIJPMNK))
				{
					return this;
				}
				break;
			}
			throw new InvalidCastException();
		}
	}
}
