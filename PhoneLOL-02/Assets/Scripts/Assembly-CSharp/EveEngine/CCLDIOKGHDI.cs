using System.Runtime.InteropServices;

namespace EveEngine
{
	internal static class CCLDIOKGHDI
	{
		[StructLayout(LayoutKind.Explicit)]
		private struct GKFNBBBDJFE
		{
			[FieldOffset(0)]
			public uint DCFAEKEPJNE;

			[FieldOffset(0)]
			public float KLKILFKIBFP;
		}

		[StructLayout(LayoutKind.Explicit)]
		private struct PFPIGOLNFOH
		{
			[FieldOffset(0)]
			public ulong INKEAMNAAMM;

			[FieldOffset(0)]
			public double MCLEFNCHFOL;
		}

		public static uint BPCLMLKGEFL(float MPOACFLBKFH)
		{
			GKFNBBBDJFE gKFNBBBDJFE = new GKFNBBBDJFE
			{
				KLKILFKIBFP = MPOACFLBKFH
			};
			return gKFNBBBDJFE.DCFAEKEPJNE;
		}

		public static float ECCBAGKCJMK(uint JEGKPPHBBKI)
		{
			GKFNBBBDJFE gKFNBBBDJFE = new GKFNBBBDJFE
			{
				DCFAEKEPJNE = JEGKPPHBBKI
			};
			return gKFNBBBDJFE.KLKILFKIBFP;
		}

		public static ulong INDIBLGHJDE(double INCBELKLLPD)
		{
			PFPIGOLNFOH pFPIGOLNFOH = new PFPIGOLNFOH
			{
				MCLEFNCHFOL = INCBELKLLPD
			};
			return pFPIGOLNFOH.INKEAMNAAMM;
		}

		public static double GMFOIFGOFLJ(ulong EHHIHHOIPPE)
		{
			PFPIGOLNFOH pFPIGOLNFOH = new PFPIGOLNFOH
			{
				INKEAMNAAMM = EHHIHHOIPPE
			};
			return pFPIGOLNFOH.MCLEFNCHFOL;
		}
	}
}
