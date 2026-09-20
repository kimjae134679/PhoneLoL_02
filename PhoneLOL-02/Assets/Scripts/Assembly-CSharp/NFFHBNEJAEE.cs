using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class NFFHBNEJAEE : FMANCKBEGBB
{
	public enum CIPMICDJPEH
	{
		Begin = 0,
		End = 1,
		Clear = 2,
		Fail = 3
	}

	private sealed class JEBECJHHLFO : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return MMEGGNJKNOH;
			}
		}

		[SpecialName]
		private object PCGKBCDEONE()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object BJIGDKGLCKP()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object LHFBMHCEIHG()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object KFNJGIJANEP()
		{
			return MMEGGNJKNOH;
		}

		public void PLOOENOBGJL()
		{
			throw new NotSupportedException();
		}

		public void AHEHIJAMCDO()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object OHBDIPJCCON()
		{
			return MMEGGNJKNOH;
		}

		public void FAKMEDLGCCL()
		{
			GOMFKPLCGNN = -1;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public void CDNEMMAGDGN()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object FFJDBFMILPN()
		{
			return MMEGGNJKNOH;
		}

		public void EJAKHHBBJPL()
		{
			throw new NotSupportedException();
		}

		public void HCCBNJMIKMO()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object FMPOHFJDLDB()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object HDEHEEDNDJM()
		{
			return MMEGGNJKNOH;
		}

		public bool GMJNFFCMCNJ()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 0;
				return true;
			case 1u:
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		public bool FPNFBEPGJEL()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 1;
				return false;
			case 1u:
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public void CLMMBEKNAJP()
		{
			GOMFKPLCGNN = -1;
		}

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public bool LLKGBIDKCOF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}
	}

	protected ushort EAKNHHJBHOD;

	protected byte CMIOFNJJGFN;

	protected CIPMICDJPEH KONOAEPMEJA;

	public virtual void BCGICPOKOHO()
	{
		base.LDNEFFHJNPL();
	}

	public virtual IEnumerator AFBPNJAKNGG()
	{
		return new JEBECJHHLFO();
	}

	public bool OEJCMIPMGPF(ushort HDAEPLDPJDP, byte MBEGPHMKKGI, CIPMICDJPEH KJDMPIDFHFF)
	{
		if (EAKNHHJBHOD != HDAEPLDPJDP)
		{
			return false;
		}
		if ((KONOAEPMEJA == CIPMICDJPEH.Begin || KONOAEPMEJA == CIPMICDJPEH.End) && CMIOFNJJGFN != MBEGPHMKKGI)
		{
			return false;
		}
		if (KONOAEPMEJA != KJDMPIDFHFF)
		{
			return false;
		}
		return true;
	}

	public override void LDNEFFHJNPL()
	{
		base.LDNEFFHJNPL();
	}

	public virtual void COGEJPHIAKE()
	{
		base.LDNEFFHJNPL();
	}

	public bool PIEHALDHMDH(ushort HDAEPLDPJDP, byte MBEGPHMKKGI, CIPMICDJPEH KJDMPIDFHFF)
	{
		if (EAKNHHJBHOD != HDAEPLDPJDP)
		{
			return false;
		}
		if ((KONOAEPMEJA == CIPMICDJPEH.Begin || KONOAEPMEJA == CIPMICDJPEH.End) && CMIOFNJJGFN != MBEGPHMKKGI)
		{
			return false;
		}
		if (KONOAEPMEJA != KJDMPIDFHFF)
		{
			return false;
		}
		return true;
	}

	public virtual void OAADIIIMNDE()
	{
		base.LDNEFFHJNPL();
	}

	public bool LCOLOEBHFAA(ushort HDAEPLDPJDP, byte MBEGPHMKKGI, CIPMICDJPEH KJDMPIDFHFF)
	{
		if (EAKNHHJBHOD != HDAEPLDPJDP)
		{
			return false;
		}
		if ((KONOAEPMEJA == CIPMICDJPEH.Begin || KONOAEPMEJA == CIPMICDJPEH.Begin) && CMIOFNJJGFN != MBEGPHMKKGI)
		{
			return true;
		}
		if (KONOAEPMEJA != KJDMPIDFHFF)
		{
			return true;
		}
		return false;
	}

	public virtual void OENLLEKFJHM()
	{
		base.LDNEFFHJNPL();
	}

	public virtual IEnumerator MLOKLGPGKMO()
	{
		return new JEBECJHHLFO();
	}

	[DebuggerHidden]
	public override IEnumerator LPBLGFCPADD()
	{
		return new JEBECJHHLFO();
	}

	public bool NGLLJIFAMND(ushort HDAEPLDPJDP, byte MBEGPHMKKGI, CIPMICDJPEH KJDMPIDFHFF)
	{
		if (EAKNHHJBHOD != HDAEPLDPJDP)
		{
			return false;
		}
		if ((KONOAEPMEJA == CIPMICDJPEH.Begin || KONOAEPMEJA == CIPMICDJPEH.End) && CMIOFNJJGFN != MBEGPHMKKGI)
		{
			return false;
		}
		if (KONOAEPMEJA != KJDMPIDFHFF)
		{
			return true;
		}
		return false;
	}
}
