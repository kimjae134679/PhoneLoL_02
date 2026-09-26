using System;

namespace MongoDB.Bson
{
	public static class BPOMFNJCBLI
	{
		private static readonly long CPMGNLKKBNJ;

		private static readonly long DNCIHMBHNBL;

		private static readonly DateTime KBBKMINDJIC;

		public static long LOCFLHINGEJ
		{
			get
			{
				return EIINCOPLLLJ();
			}
		}

		public static long GMHJONALAHB
		{
			get
			{
				return LNHJBFDLGNO();
			}
		}

		public static DateTime NLNLPKHPAKP
		{
			get
			{
				return JIIKNBBGBDN();
			}
		}

		static BPOMFNJCBLI()
		{
			KBBKMINDJIC = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			CPMGNLKKBNJ = (DateTime.MaxValue - KBBKMINDJIC).Ticks / 10000;
			DNCIHMBHNBL = (DateTime.MinValue - KBBKMINDJIC).Ticks / 10000;
		}

		public static long EIINCOPLLLJ()
		{
			return CPMGNLKKBNJ;
		}

		public static long LNHJBFDLGNO()
		{
			return DNCIHMBHNBL;
		}

		public static DateTime JIIKNBBGBDN()
		{
			return KBBKMINDJIC;
		}
	}
}
