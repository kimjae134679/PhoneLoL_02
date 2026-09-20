using System;
using System.Runtime.InteropServices;

namespace EveEngine
{
	public class MKHMMHLIGIL
	{
		private struct FFIJLGOKIIB
		{
			public ushort ILOFNFEKFCI;

			public ushort FCFFFGEHMEI;

			public ushort PGKKKBHCMFK;

			public ushort NACFBBMCEDA;

			public ushort FOKHJEPJAAF;

			public ushort IKEJPNFJDEH;

			public ushort BNJBKDNNPBB;

			public ushort GGMKFDBHEKP;
		}

		public static uint CEMGIJAGFDG(DateTime HBNDHMPNCME)
		{
			FFIJLGOKIIB CKJBOMODCIB = new FFIJLGOKIIB
			{
				ILOFNFEKFCI = (ushort)HBNDHMPNCME.Year,
				FCFFFGEHMEI = (ushort)HBNDHMPNCME.Month,
				PGKKKBHCMFK = (ushort)HBNDHMPNCME.DayOfWeek,
				NACFBBMCEDA = (ushort)HBNDHMPNCME.Day,
				FOKHJEPJAAF = (ushort)HBNDHMPNCME.Hour,
				IKEJPNFJDEH = (ushort)HBNDHMPNCME.Minute,
				BNJBKDNNPBB = (ushort)HBNDHMPNCME.Second,
				GGMKFDBHEKP = (ushort)HBNDHMPNCME.Millisecond
			};
			return BAELLEJJHIK(ref CKJBOMODCIB);
		}

		[DllImport("kernel32.dll", EntryPoint = "SetSystemTime")]
		private static extern uint BAELLEJJHIK(ref FFIJLGOKIIB CKJBOMODCIB);

		[DllImport("kernel32.dll", EntryPoint = "GetSystemTime")]
		private static extern void AEENMLEOKAJ(ref FFIJLGOKIIB CKJBOMODCIB);

		protected MKHMMHLIGIL()
		{
		}

		public static uint BAELLEJJHIK(DateTime HBNDHMPNCME)
		{
			FFIJLGOKIIB CKJBOMODCIB = new FFIJLGOKIIB
			{
				ILOFNFEKFCI = (ushort)HBNDHMPNCME.Year,
				FCFFFGEHMEI = (ushort)HBNDHMPNCME.Month,
				PGKKKBHCMFK = (ushort)HBNDHMPNCME.DayOfWeek,
				NACFBBMCEDA = (ushort)HBNDHMPNCME.Day,
				FOKHJEPJAAF = (ushort)HBNDHMPNCME.Hour,
				IKEJPNFJDEH = (ushort)HBNDHMPNCME.Minute,
				BNJBKDNNPBB = (ushort)HBNDHMPNCME.Second,
				GGMKFDBHEKP = (ushort)HBNDHMPNCME.Millisecond
			};
			return BAELLEJJHIK(ref CKJBOMODCIB);
		}

		public static uint OFPGPCMFAAN(DateTime HBNDHMPNCME)
		{
			FFIJLGOKIIB CKJBOMODCIB = new FFIJLGOKIIB
			{
				ILOFNFEKFCI = (ushort)HBNDHMPNCME.Year,
				FCFFFGEHMEI = (ushort)HBNDHMPNCME.Month,
				PGKKKBHCMFK = (ushort)HBNDHMPNCME.DayOfWeek,
				NACFBBMCEDA = (ushort)HBNDHMPNCME.Day,
				FOKHJEPJAAF = (ushort)HBNDHMPNCME.Hour,
				IKEJPNFJDEH = (ushort)HBNDHMPNCME.Minute,
				BNJBKDNNPBB = (ushort)HBNDHMPNCME.Second,
				GGMKFDBHEKP = (ushort)HBNDHMPNCME.Millisecond
			};
			return BAELLEJJHIK(ref CKJBOMODCIB);
		}

		public static uint NNFMOCJOCPD(DateTime HBNDHMPNCME)
		{
			FFIJLGOKIIB CKJBOMODCIB = new FFIJLGOKIIB
			{
				ILOFNFEKFCI = (ushort)HBNDHMPNCME.Year,
				FCFFFGEHMEI = (ushort)HBNDHMPNCME.Month,
				PGKKKBHCMFK = (ushort)HBNDHMPNCME.DayOfWeek,
				NACFBBMCEDA = (ushort)HBNDHMPNCME.Day,
				FOKHJEPJAAF = (ushort)HBNDHMPNCME.Hour,
				IKEJPNFJDEH = (ushort)HBNDHMPNCME.Minute,
				BNJBKDNNPBB = (ushort)HBNDHMPNCME.Second,
				GGMKFDBHEKP = (ushort)HBNDHMPNCME.Millisecond
			};
			return BAELLEJJHIK(ref CKJBOMODCIB);
		}

		public static uint HPBDDLJKLME(DateTime HBNDHMPNCME)
		{
			FFIJLGOKIIB CKJBOMODCIB = new FFIJLGOKIIB
			{
				ILOFNFEKFCI = (ushort)HBNDHMPNCME.Year,
				FCFFFGEHMEI = (ushort)HBNDHMPNCME.Month,
				PGKKKBHCMFK = (ushort)HBNDHMPNCME.DayOfWeek,
				NACFBBMCEDA = (ushort)HBNDHMPNCME.Day,
				FOKHJEPJAAF = (ushort)HBNDHMPNCME.Hour,
				IKEJPNFJDEH = (ushort)HBNDHMPNCME.Minute,
				BNJBKDNNPBB = (ushort)HBNDHMPNCME.Second,
				GGMKFDBHEKP = (ushort)HBNDHMPNCME.Millisecond
			};
			return BAELLEJJHIK(ref CKJBOMODCIB);
		}
	}
}
