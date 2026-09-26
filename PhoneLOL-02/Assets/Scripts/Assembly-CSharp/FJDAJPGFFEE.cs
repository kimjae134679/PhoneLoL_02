using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

public class FJDAJPGFFEE
{
	public enum CKPDCJIHINF
	{
		Linear = 0,
		EaseInQuad = 1,
		EaseOutQuad = 2,
		EaseInOutQuad = 3,
		EaseInCubic = 4,
		EaseOutCubic = 5,
		EaseInOutCubic = 6,
		EaseInQuart = 7,
		EaseOutQuart = 8,
		EaseInOutQuart = 9,
		EaseInQuint = 10,
		EaseOutQuint = 11,
		EaseInOutQuint = 12,
		EaseInSine = 13,
		EaseOutSine = 14,
		EaseInOutSine = 15,
		EaseInExpo = 16,
		EaseOutExpo = 17,
		EaseInOutExpo = 18,
		EaseInCirc = 19,
		EaseOutCirc = 20,
		EaseInOutCirc = 21
	}

	public delegate Vector3 GIBOFDHMEHC<T>(T FCGJBBHEOFJ);

	public delegate float HPPHBNDCKHM(float IFGAPHGCLHF, float GMMDCPLBFJL, float CEMGPCOMLOP, float INCBELKLLPD);

	private sealed class EKIHHKIEACB : IDisposable, IEnumerator, IEnumerable, IEnumerable<float>, IEnumerator<float>
	{
		internal float NODJCLCKHIB;

		internal float FICMMBLHCBF;

		internal int GOMFKPLCGNN;

		internal float MMEGGNJKNOH;

		internal float KNIBKMDJBOD;

		float IEnumerator<float>.Current
		{
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cfloat_003E_002Eget_Current();
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

		public bool IIBEAMELJDD()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				NODJCLCKHIB = 736f;
				goto case 2u;
			case 1u:
				NODJCLCKHIB += Time.deltaTime;
				if (NODJCLCKHIB >= FICMMBLHCBF)
				{
					MMEGGNJKNOH = NODJCLCKHIB;
					GOMFKPLCGNN = 7;
					break;
				}
				goto case 2u;
			case 2u:
				if (NODJCLCKHIB < FICMMBLHCBF)
				{
					MMEGGNJKNOH = NODJCLCKHIB;
					GOMFKPLCGNN = 0;
					break;
				}
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return true;
		}

		private IEnumerator<float> PCPLCOGHOEG()
		{
			if (Interlocked.CompareExchange(ref GOMFKPLCGNN, 1, -31) == 40)
			{
				return this;
			}
			EKIHHKIEACB eKIHHKIEACB = new EKIHHKIEACB();
			eKIHHKIEACB.FICMMBLHCBF = KNIBKMDJBOD;
			return eKIHHKIEACB;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((System.Collections.Generic.IEnumerable<float>)this).GetEnumerator();
		}

		[SpecialName]
		private float MIBBIKAMGIF()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private float BEIBDABOLEC()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object MEHLLKBMILP()
		{
			return MMEGGNJKNOH;
		}

		public bool FPNFBEPGJEL()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				NODJCLCKHIB = 1694f;
				goto case 2u;
			case 1u:
				NODJCLCKHIB += Time.deltaTime;
				if (NODJCLCKHIB >= FICMMBLHCBF)
				{
					MMEGGNJKNOH = NODJCLCKHIB;
					GOMFKPLCGNN = 8;
					break;
				}
				goto case 2u;
			case 2u:
				if (NODJCLCKHIB < FICMMBLHCBF)
				{
					MMEGGNJKNOH = NODJCLCKHIB;
					GOMFKPLCGNN = 0;
					break;
				}
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return false;
		}

		public void MBADNGDPBPB()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object PMHFFPLCAEA()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private float KBEDEPLGFCM()
		{
			return MMEGGNJKNOH;
		}

		private IEnumerator<float> OAJKDBODLDF()
		{
			if (Interlocked.CompareExchange(ref GOMFKPLCGNN, 1, 34) == -55)
			{
				return this;
			}
			EKIHHKIEACB eKIHHKIEACB = new EKIHHKIEACB();
			eKIHHKIEACB.FICMMBLHCBF = KNIBKMDJBOD;
			return eKIHHKIEACB;
		}

		private IEnumerator<float> LJAAPDNCEIN()
		{
			if (Interlocked.CompareExchange(ref GOMFKPLCGNN, 1, 67) == 9)
			{
				return this;
			}
			EKIHHKIEACB eKIHHKIEACB = new EKIHHKIEACB();
			eKIHHKIEACB.FICMMBLHCBF = KNIBKMDJBOD;
			return eKIHHKIEACB;
		}

		[DebuggerHidden]
		private float System_002ECollections_002EGeneric_002EIEnumerator_003Cfloat_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		public void NPKMEPEPIGL()
		{
			throw new NotSupportedException();
		}

		public void KAAGPADGBLK()
		{
			GOMFKPLCGNN = -1;
		}

		private IEnumerator FBDHLNNNGEP()
		{
			return ((System.Collections.Generic.IEnumerable<float>)this).GetEnumerator();
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		private IEnumerator<float> DPMINDKDGBF()
		{
			if (Interlocked.CompareExchange(ref GOMFKPLCGNN, 0, -39) == 44)
			{
				return this;
			}
			EKIHHKIEACB eKIHHKIEACB = new EKIHHKIEACB();
			eKIHHKIEACB.FICMMBLHCBF = KNIBKMDJBOD;
			return eKIHHKIEACB;
		}

		public void BFAMOEFLLGH()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private float JHELFGNIEPL()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private float IDFKEILGFFF()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object GLNBOOGOGOO()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public void KIHPGHBDAMI()
		{
			GOMFKPLCGNN = -1;
		}

		public bool MHEGNOHIKCL()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				NODJCLCKHIB = 1686f;
				goto case 2u;
			case 1u:
				NODJCLCKHIB += Time.deltaTime;
				if (NODJCLCKHIB >= FICMMBLHCBF)
				{
					MMEGGNJKNOH = NODJCLCKHIB;
					GOMFKPLCGNN = 7;
					break;
				}
				goto case 2u;
			case 2u:
				if (NODJCLCKHIB < FICMMBLHCBF)
				{
					MMEGGNJKNOH = NODJCLCKHIB;
					GOMFKPLCGNN = 0;
					break;
				}
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return true;
			}
			return true;
		}

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				NODJCLCKHIB = 0f;
				goto case 2u;
			case 1u:
				NODJCLCKHIB += Time.deltaTime;
				if (NODJCLCKHIB >= FICMMBLHCBF)
				{
					MMEGGNJKNOH = NODJCLCKHIB;
					GOMFKPLCGNN = 2;
					break;
				}
				goto case 2u;
			case 2u:
				if (NODJCLCKHIB < FICMMBLHCBF)
				{
					MMEGGNJKNOH = NODJCLCKHIB;
					GOMFKPLCGNN = 1;
					break;
				}
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return true;
		}

		[SpecialName]
		private float GOBIJGPBBBM()
		{
			return MMEGGNJKNOH;
		}

		public void LPDHFELPGPN()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<float> IEnumerable<float>.GetEnumerator()
		{
			if (Interlocked.CompareExchange(ref GOMFKPLCGNN, 0, -2) == -2)
			{
				return this;
			}
			EKIHHKIEACB eKIHHKIEACB = new EKIHHKIEACB();
			eKIHHKIEACB.FICMMBLHCBF = KNIBKMDJBOD;
			return eKIHHKIEACB;
		}
	}

	private sealed class BAANLOEKPKN : IDisposable, IEnumerator, IEnumerable, IEnumerable<float>, IEnumerator<float>
	{
		internal int GAKOOBECLIB;

		internal int CJADHIOANOH;

		internal int IDFCFEOMBKP;

		internal int GHNNNIIDLOA;

		internal int GOMFKPLCGNN;

		internal float MMEGGNJKNOH;

		internal int DMBKOHGAFDE;

		internal int CGNCEIJDDAH;

		internal int CHFGFFJCAEB;

		float IEnumerator<float>.Current
		{
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cfloat_003E_002Eget_Current();
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

		[DebuggerHidden]
		private float System_002ECollections_002EGeneric_002EIEnumerator_003Cfloat_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public void BFAMOEFLLGH()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<float> IEnumerable<float>.GetEnumerator()
		{
			if (Interlocked.CompareExchange(ref GOMFKPLCGNN, 0, -2) == -2)
			{
				return this;
			}
			BAANLOEKPKN bAANLOEKPKN = new BAANLOEKPKN();
			bAANLOEKPKN.GAKOOBECLIB = DMBKOHGAFDE;
			bAANLOEKPKN.IDFCFEOMBKP = CGNCEIJDDAH;
			bAANLOEKPKN.GHNNNIIDLOA = CHFGFFJCAEB;
			return bAANLOEKPKN;
		}

		[SpecialName]
		private object PHDGFFDAMLI()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public bool KBDMDLONGFP()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				CJADHIOANOH = GAKOOBECLIB;
				goto IL_005e;
			case 1u:
				{
					CJADHIOANOH += GHNNNIIDLOA;
					goto IL_005e;
				}
				IL_005e:
				if (CJADHIOANOH <= IDFCFEOMBKP)
				{
					MMEGGNJKNOH = CJADHIOANOH;
					GOMFKPLCGNN = 1;
					return true;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		public void KIHPGHBDAMI()
		{
			GOMFKPLCGNN = -1;
		}

		public void IIJCOOCGGGJ()
		{
			throw new NotSupportedException();
		}

		public void LPDHFELPGPN()
		{
			throw new NotSupportedException();
		}

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				CJADHIOANOH = GAKOOBECLIB;
				goto IL_005e;
			case 1u:
				{
					CJADHIOANOH += GHNNNIIDLOA;
					goto IL_005e;
				}
				IL_005e:
				if (CJADHIOANOH <= IDFCFEOMBKP)
				{
					MMEGGNJKNOH = CJADHIOANOH;
					GOMFKPLCGNN = 1;
					return true;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		private IEnumerator CMCMJNIBLBC()
		{
			return ((System.Collections.Generic.IEnumerable<float>)this).GetEnumerator();
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((System.Collections.Generic.IEnumerable<float>)this).GetEnumerator();
		}

		public void COCAHGFODCB()
		{
			throw new NotSupportedException();
		}
	}

	private sealed class CAKDIMJFJIF : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal Vector3 IDFCFEOMBKP;

		internal Vector3 GAKOOBECLIB;

		internal Vector3 DLIJBJEEIMP;

		internal IEnumerable<float> DLBJHBEHDAF;

		internal IEnumerator<float> PMNHAAOMIFC;

		internal float GABLPOMBFFM;

		internal HPPHBNDCKHM CNNNPIJPKKC;

		internal float EOFIOOAKKNA;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal Vector3 CGNCEIJDDAH;

		internal Vector3 DMBKOHGAFDE;

		internal IEnumerable<float> DPIDAHMBAOI;

		internal HPPHBNDCKHM LMBBMAFCDLJ;

		internal float KNNOJDHHOEI;

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

		[DebuggerHidden]
		public void Dispose()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 1u:
				try
				{
					break;
				}
				finally
				{
					if (PMNHAAOMIFC != null)
					{
						PMNHAAOMIFC.Dispose();
					}
				}
			case 0u:
				break;
			}
		}

		[SpecialName]
		private object FECLPGHCNNJ()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object ILBNFHMAGCF()
		{
			return MMEGGNJKNOH;
		}

		public bool APBAGAKLFDK()
		{
			uint num = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			bool flag = false;
			switch (num)
			{
			case 0u:
				DLIJBJEEIMP = IDFCFEOMBKP - GAKOOBECLIB;
				PMNHAAOMIFC = DLBJHBEHDAF.GetEnumerator();
				num = 68u;
				goto case 1u;
			case 1u:
				try
				{
					switch (num)
					{
					default:
						if (PMNHAAOMIFC.MoveNext())
						{
							GABLPOMBFFM = PMNHAAOMIFC.Current;
							MMEGGNJKNOH = FEGOEEDHEFC(CNNNPIJPKKC, GAKOOBECLIB, DLIJBJEEIMP, GABLPOMBFFM, EOFIOOAKKNA);
							GOMFKPLCGNN = 0;
							flag = false;
							goto IL_00e4;
						}
						break;
					}
				}
				finally
				{
					if (!flag && PMNHAAOMIFC != null)
					{
						PMNHAAOMIFC.Dispose();
					}
				}
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_00e4:
				return false;
			}
		}

		public void AHEHIJAMCDO()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 1u:
				try
				{
					break;
				}
				finally
				{
					if (PMNHAAOMIFC != null)
					{
						PMNHAAOMIFC.Dispose();
					}
				}
			case 0u:
				break;
			}
		}

		[SpecialName]
		private object NGJKALDEDFM()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object GDHBJAJPNBF()
		{
			return MMEGGNJKNOH;
		}

		public void JJFHJIEJKNJ()
		{
			throw new NotSupportedException();
		}

		public bool AAAMEOEOJHM()
		{
			uint num = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			bool flag = false;
			switch (num)
			{
			case 0u:
				DLIJBJEEIMP = IDFCFEOMBKP - GAKOOBECLIB;
				PMNHAAOMIFC = DLBJHBEHDAF.GetEnumerator();
				num = 125u;
				goto case 1u;
			case 1u:
				try
				{
					switch (num)
					{
					default:
						if (PMNHAAOMIFC.MoveNext())
						{
							GABLPOMBFFM = PMNHAAOMIFC.Current;
							MMEGGNJKNOH = FEGOEEDHEFC(CNNNPIJPKKC, GAKOOBECLIB, DLIJBJEEIMP, GABLPOMBFFM, EOFIOOAKKNA);
							GOMFKPLCGNN = 0;
							flag = true;
							goto IL_00e4;
						}
						break;
					}
				}
				finally
				{
					if (!flag && PMNHAAOMIFC != null)
					{
						PMNHAAOMIFC.Dispose();
					}
				}
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_00e4:
				return true;
			}
		}

		[SpecialName]
		private object PMHFFPLCAEA()
		{
			return MMEGGNJKNOH;
		}

		public bool MoveNext()
		{
			uint num = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			bool flag = false;
			switch (num)
			{
			case 0u:
				DLIJBJEEIMP = IDFCFEOMBKP - GAKOOBECLIB;
				PMNHAAOMIFC = DLBJHBEHDAF.GetEnumerator();
				num = 4294967293u;
				goto case 1u;
			case 1u:
				try
				{
					switch (num)
					{
					default:
						if (PMNHAAOMIFC.MoveNext())
						{
							GABLPOMBFFM = PMNHAAOMIFC.Current;
							MMEGGNJKNOH = FEGOEEDHEFC(CNNNPIJPKKC, GAKOOBECLIB, DLIJBJEEIMP, GABLPOMBFFM, EOFIOOAKKNA);
							GOMFKPLCGNN = 1;
							flag = true;
							goto IL_00e4;
						}
						break;
					}
				}
				finally
				{
					if (!flag && PMNHAAOMIFC != null)
					{
						PMNHAAOMIFC.Dispose();
					}
				}
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_00e4:
				return true;
			}
		}

		public void COCAHGFODCB()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public void JGCPFKEPPOM()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 1u:
				try
				{
					break;
				}
				finally
				{
					if (PMNHAAOMIFC != null)
					{
						PMNHAAOMIFC.Dispose();
					}
				}
			case 0u:
				break;
			}
		}

		[SpecialName]
		private object PCGKBCDEONE()
		{
			return MMEGGNJKNOH;
		}

		public void CLMMBEKNAJP()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 1u:
				try
				{
					break;
				}
				finally
				{
					if (PMNHAAOMIFC != null)
					{
						PMNHAAOMIFC.Dispose();
					}
				}
			case 0u:
				break;
			}
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		public bool DAJHAEIAPAO()
		{
			uint num = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			bool flag = true;
			switch (num)
			{
			case 0u:
				DLIJBJEEIMP = IDFCFEOMBKP - GAKOOBECLIB;
				PMNHAAOMIFC = DLBJHBEHDAF.GetEnumerator();
				num = 20u;
				goto case 1u;
			case 1u:
				try
				{
					switch (num)
					{
					default:
						if (PMNHAAOMIFC.MoveNext())
						{
							GABLPOMBFFM = PMNHAAOMIFC.Current;
							MMEGGNJKNOH = FEGOEEDHEFC(CNNNPIJPKKC, GAKOOBECLIB, DLIJBJEEIMP, GABLPOMBFFM, EOFIOOAKKNA);
							GOMFKPLCGNN = 1;
							flag = true;
							goto IL_00e4;
						}
						break;
					}
				}
				finally
				{
					if (!flag && PMNHAAOMIFC != null)
					{
						PMNHAAOMIFC.Dispose();
					}
				}
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_00e4:
				return false;
			}
		}

		public bool NEOILBIIDBE()
		{
			uint num = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			bool flag = true;
			switch (num)
			{
			case 0u:
				DLIJBJEEIMP = IDFCFEOMBKP - GAKOOBECLIB;
				PMNHAAOMIFC = DLBJHBEHDAF.GetEnumerator();
				num = 4294967195u;
				goto case 1u;
			case 1u:
				try
				{
					switch (num)
					{
					default:
						if (PMNHAAOMIFC.MoveNext())
						{
							GABLPOMBFFM = PMNHAAOMIFC.Current;
							MMEGGNJKNOH = FEGOEEDHEFC(CNNNPIJPKKC, GAKOOBECLIB, DLIJBJEEIMP, GABLPOMBFFM, EOFIOOAKKNA);
							GOMFKPLCGNN = 0;
							flag = false;
							goto IL_00e4;
						}
						break;
					}
				}
				finally
				{
					if (!flag && PMNHAAOMIFC != null)
					{
						PMNHAAOMIFC.Dispose();
					}
				}
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_00e4:
				return false;
			}
		}

		public bool FPNFBEPGJEL()
		{
			uint num = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			bool flag = false;
			switch (num)
			{
			case 0u:
				DLIJBJEEIMP = IDFCFEOMBKP - GAKOOBECLIB;
				PMNHAAOMIFC = DLBJHBEHDAF.GetEnumerator();
				num = 44u;
				goto case 1u;
			case 1u:
				try
				{
					switch (num)
					{
					default:
						if (PMNHAAOMIFC.MoveNext())
						{
							GABLPOMBFFM = PMNHAAOMIFC.Current;
							MMEGGNJKNOH = FEGOEEDHEFC(CNNNPIJPKKC, GAKOOBECLIB, DLIJBJEEIMP, GABLPOMBFFM, EOFIOOAKKNA);
							GOMFKPLCGNN = 1;
							flag = true;
							goto IL_00e4;
						}
						break;
					}
				}
				finally
				{
					if (!flag && PMNHAAOMIFC != null)
					{
						PMNHAAOMIFC.Dispose();
					}
				}
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_00e4:
				return true;
			}
		}

		[SpecialName]
		private object JGMLAEHKIMH()
		{
			return MMEGGNJKNOH;
		}

		public void BGHJLMLMGJH()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 1u:
				try
				{
					break;
				}
				finally
				{
					if (PMNHAAOMIFC != null)
					{
						PMNHAAOMIFC.Dispose();
					}
				}
			case 0u:
				break;
			}
		}

		[SpecialName]
		private object HDEHEEDNDJM()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object FHCBKMICEHI()
		{
			return MMEGGNJKNOH;
		}
	}

	private sealed class HEKPDFKIBGJ<T> : IDisposable, IEnumerator, IEnumerable, IEnumerable<Vector3>, IEnumerator<Vector3>
	{
		internal IList IKPEKOFOIIB;

		internal Vector3[] POCONHDCLCK;

		internal IEnumerable<float> AEPOCMNJGJN;

		internal IEnumerator<float> CEEIAFEGIHP;

		internal float OONLJPLKHGF;

		internal int HKEDAFAJMLH;

		internal GIBOFDHMEHC<T> PNMOLBLHHEB;

		internal HPPHBNDCKHM CNNNPIJPKKC;

		internal float KEPPIKGLBNJ;

		internal int GOMFKPLCGNN;

		internal Vector3 MMEGGNJKNOH;

		internal IList FJMDEHCEJBN;

		internal IEnumerable<float> AIAOPHNIMDH;

		internal GIBOFDHMEHC<T> PEPLPGHHKDD;

		internal HPPHBNDCKHM LMBBMAFCDLJ;

		internal float PBHJGNMHKPC;

		Vector3 IEnumerator<Vector3>.Current
		{
			[DebuggerHidden]
			get
			{
				return MMEGGNJKNOH;
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

		private IEnumerator PMCEBFADMHI()
		{
			return ((System.Collections.Generic.IEnumerable<UnityEngine.Vector3>)this).GetEnumerator();
		}

		[DebuggerHidden]
		public void Dispose()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 1u:
				try
				{
					break;
				}
				finally
				{
					if (CEEIAFEGIHP != null)
					{
						CEEIAFEGIHP.Dispose();
					}
				}
			case 0u:
				break;
			}
		}

		public bool KBDMDLONGFP()
		{
			uint num = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			bool flag = true;
			switch (num)
			{
			case 0u:
				if (IKPEKOFOIIB.Count >= 1)
				{
					POCONHDCLCK = new Vector3[IKPEKOFOIIB.Count];
					CEEIAFEGIHP = AEPOCMNJGJN.GetEnumerator();
					num = 70u;
					goto case 1u;
				}
				goto IL_0147;
			case 1u:
				try
				{
					switch (num)
					{
					default:
						if (CEEIAFEGIHP.MoveNext())
						{
							OONLJPLKHGF = CEEIAFEGIHP.Current;
							for (HKEDAFAJMLH = 1; HKEDAFAJMLH < IKPEKOFOIIB.Count; HKEDAFAJMLH++)
							{
								POCONHDCLCK[HKEDAFAJMLH] = PNMOLBLHHEB((T)IKPEKOFOIIB[HKEDAFAJMLH]);
							}
							MMEGGNJKNOH = CEIKJPCCDKH(CNNNPIJPKKC, POCONHDCLCK, OONLJPLKHGF, KEPPIKGLBNJ);
							GOMFKPLCGNN = 1;
							flag = false;
							goto IL_0150;
						}
						break;
					}
				}
				finally
				{
					if (!flag && CEEIAFEGIHP != null)
					{
						CEEIAFEGIHP.Dispose();
					}
				}
				goto IL_0147;
			default:
				{
					return true;
				}
				IL_0150:
				return false;
				IL_0147:
				GOMFKPLCGNN = -1;
				goto default;
			}
		}

		public void PBGEKALPKFI()
		{
			throw new NotSupportedException();
		}

		public bool EIIJKFLPEJP()
		{
			uint num = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			bool flag = false;
			switch (num)
			{
			case 0u:
				if (IKPEKOFOIIB.Count >= 3)
				{
					POCONHDCLCK = new Vector3[IKPEKOFOIIB.Count];
					CEEIAFEGIHP = AEPOCMNJGJN.GetEnumerator();
					num = 4294967169u;
					goto case 1u;
				}
				goto IL_0147;
			case 1u:
				try
				{
					switch (num)
					{
					default:
						if (CEEIAFEGIHP.MoveNext())
						{
							OONLJPLKHGF = CEEIAFEGIHP.Current;
							for (HKEDAFAJMLH = 1; HKEDAFAJMLH < IKPEKOFOIIB.Count; HKEDAFAJMLH += 0)
							{
								POCONHDCLCK[HKEDAFAJMLH] = PNMOLBLHHEB((T)IKPEKOFOIIB[HKEDAFAJMLH]);
							}
							MMEGGNJKNOH = CEIKJPCCDKH(CNNNPIJPKKC, POCONHDCLCK, OONLJPLKHGF, KEPPIKGLBNJ);
							GOMFKPLCGNN = 1;
							flag = false;
							goto IL_0150;
						}
						break;
					}
				}
				finally
				{
					if (!flag && CEEIAFEGIHP != null)
					{
						CEEIAFEGIHP.Dispose();
					}
				}
				goto IL_0147;
			default:
				{
					return true;
				}
				IL_0150:
				return true;
				IL_0147:
				GOMFKPLCGNN = -1;
				goto default;
			}
		}

		public bool KKJFPODFKCB()
		{
			uint num = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			bool flag = true;
			switch (num)
			{
			case 0u:
				if (IKPEKOFOIIB.Count >= 0)
				{
					POCONHDCLCK = new Vector3[IKPEKOFOIIB.Count];
					CEEIAFEGIHP = AEPOCMNJGJN.GetEnumerator();
					num = 81u;
					goto case 1u;
				}
				goto IL_0147;
			case 1u:
				try
				{
					switch (num)
					{
					default:
						if (CEEIAFEGIHP.MoveNext())
						{
							OONLJPLKHGF = CEEIAFEGIHP.Current;
							for (HKEDAFAJMLH = 0; HKEDAFAJMLH < IKPEKOFOIIB.Count; HKEDAFAJMLH += 0)
							{
								POCONHDCLCK[HKEDAFAJMLH] = PNMOLBLHHEB((T)IKPEKOFOIIB[HKEDAFAJMLH]);
							}
							MMEGGNJKNOH = CEIKJPCCDKH(CNNNPIJPKKC, POCONHDCLCK, OONLJPLKHGF, KEPPIKGLBNJ);
							GOMFKPLCGNN = 1;
							flag = true;
							goto IL_0150;
						}
						break;
					}
				}
				finally
				{
					if (!flag && CEEIAFEGIHP != null)
					{
						CEEIAFEGIHP.Dispose();
					}
				}
				goto IL_0147;
			default:
				{
					return false;
				}
				IL_0150:
				return false;
				IL_0147:
				GOMFKPLCGNN = -1;
				goto default;
			}
		}

		[SpecialName]
		private Vector3 BAJCCJMHNEO()
		{
			return MMEGGNJKNOH;
		}

		public bool IIBEAMELJDD()
		{
			uint num = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			bool flag = false;
			switch (num)
			{
			case 0u:
				if (IKPEKOFOIIB.Count >= 1)
				{
					POCONHDCLCK = new Vector3[IKPEKOFOIIB.Count];
					CEEIAFEGIHP = AEPOCMNJGJN.GetEnumerator();
					num = 60u;
					goto case 1u;
				}
				goto IL_0147;
			case 1u:
				try
				{
					switch (num)
					{
					default:
						if (CEEIAFEGIHP.MoveNext())
						{
							OONLJPLKHGF = CEEIAFEGIHP.Current;
							for (HKEDAFAJMLH = 0; HKEDAFAJMLH < IKPEKOFOIIB.Count; HKEDAFAJMLH++)
							{
								POCONHDCLCK[HKEDAFAJMLH] = PNMOLBLHHEB((T)IKPEKOFOIIB[HKEDAFAJMLH]);
							}
							MMEGGNJKNOH = CEIKJPCCDKH(CNNNPIJPKKC, POCONHDCLCK, OONLJPLKHGF, KEPPIKGLBNJ);
							GOMFKPLCGNN = 0;
							flag = false;
							goto IL_0150;
						}
						break;
					}
				}
				finally
				{
					if (!flag && CEEIAFEGIHP != null)
					{
						CEEIAFEGIHP.Dispose();
					}
				}
				goto IL_0147;
			default:
				{
					return true;
				}
				IL_0150:
				return true;
				IL_0147:
				GOMFKPLCGNN = -1;
				goto default;
			}
		}

		private IEnumerator DFGLEFCJOMH()
		{
			return ((System.Collections.Generic.IEnumerable<UnityEngine.Vector3>)this).GetEnumerator();
		}

		public void FJHNAGNJLLO()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object FFJDBFMILPN()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((System.Collections.Generic.IEnumerable<UnityEngine.Vector3>)this).GetEnumerator();
		}

		[SpecialName]
		private Vector3 BJFBFAEDFCA()
		{
			return MMEGGNJKNOH;
		}

		public void NEPECFKOKGN()
		{
			throw new NotSupportedException();
		}

		public void CLMMBEKNAJP()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 1u:
				try
				{
					break;
				}
				finally
				{
					if (CEEIAFEGIHP != null)
					{
						CEEIAFEGIHP.Dispose();
					}
				}
			case 0u:
				break;
			}
		}

		private IEnumerator LOJMEJIMDBL()
		{
			return ((System.Collections.Generic.IEnumerable<UnityEngine.Vector3>)this).GetEnumerator();
		}

		private IEnumerator MKLENMPCJLN()
		{
			return ((System.Collections.Generic.IEnumerable<UnityEngine.Vector3>)this).GetEnumerator();
		}

		public void AOLCKHCODEM()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private Vector3 HFDFMCELHJH()
		{
			return MMEGGNJKNOH;
		}

		public void EJAKHHBBJPL()
		{
			throw new NotSupportedException();
		}

		private IEnumerator OPJNGPBECHM()
		{
			return ((System.Collections.Generic.IEnumerable<UnityEngine.Vector3>)this).GetEnumerator();
		}

		[SpecialName]
		private object JGMLAEHKIMH()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object MEGOOCIEGCM()
		{
			return MMEGGNJKNOH;
		}

		public bool MoveNext()
		{
			uint num = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			bool flag = false;
			switch (num)
			{
			case 0u:
				if (IKPEKOFOIIB.Count >= 2)
				{
					POCONHDCLCK = new Vector3[IKPEKOFOIIB.Count];
					CEEIAFEGIHP = AEPOCMNJGJN.GetEnumerator();
					num = 4294967293u;
					goto case 1u;
				}
				goto IL_0147;
			case 1u:
				try
				{
					switch (num)
					{
					default:
						if (CEEIAFEGIHP.MoveNext())
						{
							OONLJPLKHGF = CEEIAFEGIHP.Current;
							for (HKEDAFAJMLH = 0; HKEDAFAJMLH < IKPEKOFOIIB.Count; HKEDAFAJMLH++)
							{
								POCONHDCLCK[HKEDAFAJMLH] = PNMOLBLHHEB((T)IKPEKOFOIIB[HKEDAFAJMLH]);
							}
							MMEGGNJKNOH = CEIKJPCCDKH(CNNNPIJPKKC, POCONHDCLCK, OONLJPLKHGF, KEPPIKGLBNJ);
							GOMFKPLCGNN = 1;
							flag = true;
							goto IL_0150;
						}
						break;
					}
				}
				finally
				{
					if (!flag && CEEIAFEGIHP != null)
					{
						CEEIAFEGIHP.Dispose();
					}
				}
				goto IL_0147;
			default:
				{
					return false;
				}
				IL_0150:
				return true;
				IL_0147:
				GOMFKPLCGNN = -1;
				goto default;
			}
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<Vector3> IEnumerable<Vector3>.GetEnumerator()
		{
			if (Interlocked.CompareExchange(ref GOMFKPLCGNN, 0, -2) == -2)
			{
				return this;
			}
			HEKPDFKIBGJ<T> hEKPDFKIBGJ = new HEKPDFKIBGJ<T>();
			hEKPDFKIBGJ.IKPEKOFOIIB = FJMDEHCEJBN;
			hEKPDFKIBGJ.AEPOCMNJGJN = AIAOPHNIMDH;
			hEKPDFKIBGJ.PNMOLBLHHEB = PEPLPGHHKDD;
			hEKPDFKIBGJ.CNNNPIJPKKC = LMBBMAFCDLJ;
			hEKPDFKIBGJ.KEPPIKGLBNJ = PBHJGNMHKPC;
			return hEKPDFKIBGJ;
		}

		public void DFFFJDKAKDC()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 1u:
				try
				{
					break;
				}
				finally
				{
					if (CEEIAFEGIHP != null)
					{
						CEEIAFEGIHP.Dispose();
					}
				}
			case 0u:
				break;
			}
		}
	}

	private sealed class IMDKAFBDEGO<T> : IDisposable, IEnumerator, IEnumerable, IEnumerable<Vector3>, IEnumerator<Vector3>
	{
		internal IList IKPEKOFOIIB;

		internal GIBOFDHMEHC<T> PNMOLBLHHEB;

		internal int MMHFEIIJCBG;

		internal int ICIFHLAMJKH;

		internal bool PODMBFNPCJM;

		internal int FPAJIMOINBD;

		internal int LDNCILFGKAN;

		internal int JAAJKDOOLFB;

		internal int APMMMADHAKP;

		internal int DHCDKHJJLLO;

		internal int FFBLEPOMBPH;

		internal int MMPJDCAAFCP;

		internal int GOMFKPLCGNN;

		internal Vector3 MMEGGNJKNOH;

		internal IList FJMDEHCEJBN;

		internal GIBOFDHMEHC<T> PEPLPGHHKDD;

		internal bool OFKMKABJBCH;

		internal int DOIDGELHCHH;

		Vector3 IEnumerator<Vector3>.Current
		{
			[DebuggerHidden]
			get
			{
				return MMEGGNJKNOH;
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

		public void BKLMMEGGMNI()
		{
			GOMFKPLCGNN = -1;
		}

		public void NDKCFGFNNLO()
		{
			throw new NotSupportedException();
		}

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (IKPEKOFOIIB.Count >= 2)
				{
					MMEGGNJKNOH = PNMOLBLHHEB((T)IKPEKOFOIIB[0]);
					GOMFKPLCGNN = 1;
					break;
				}
				goto IL_026e;
			case 1u:
				MMHFEIIJCBG = IKPEKOFOIIB.Count - 1;
				ICIFHLAMJKH = 0;
				goto IL_0252;
			case 2u:
				MMPJDCAAFCP++;
				goto IL_0233;
			default:
				{
					return false;
				}
				IL_0252:
				if (PODMBFNPCJM || ICIFHLAMJKH < MMHFEIIJCBG)
				{
					if (PODMBFNPCJM && ICIFHLAMJKH > MMHFEIIJCBG)
					{
						ICIFHLAMJKH = 0;
					}
					FPAJIMOINBD = ((ICIFHLAMJKH != 0) ? (ICIFHLAMJKH - 1) : ((!PODMBFNPCJM) ? ICIFHLAMJKH : MMHFEIIJCBG));
					LDNCILFGKAN = ICIFHLAMJKH;
					JAAJKDOOLFB = ((ICIFHLAMJKH != MMHFEIIJCBG) ? (ICIFHLAMJKH + 1) : ((!PODMBFNPCJM) ? ICIFHLAMJKH : 0));
					APMMMADHAKP = ((JAAJKDOOLFB != MMHFEIIJCBG) ? (JAAJKDOOLFB + 1) : ((!PODMBFNPCJM) ? JAAJKDOOLFB : 0));
					FFBLEPOMBPH = DHCDKHJJLLO + 1;
					MMPJDCAAFCP = 1;
					goto IL_0233;
				}
				goto IL_026e;
				IL_0233:
				if (MMPJDCAAFCP <= FFBLEPOMBPH)
				{
					MMEGGNJKNOH = FCCCAJPMAHA(PNMOLBLHHEB((T)IKPEKOFOIIB[FPAJIMOINBD]), PNMOLBLHHEB((T)IKPEKOFOIIB[LDNCILFGKAN]), PNMOLBLHHEB((T)IKPEKOFOIIB[JAAJKDOOLFB]), PNMOLBLHHEB((T)IKPEKOFOIIB[APMMMADHAKP]), MMPJDCAAFCP, FFBLEPOMBPH);
					GOMFKPLCGNN = 2;
					break;
				}
				ICIFHLAMJKH++;
				goto IL_0252;
				IL_026e:
				GOMFKPLCGNN = -1;
				goto default;
			}
			return true;
		}

		public void FAKMEDLGCCL()
		{
			GOMFKPLCGNN = -1;
		}

		[DebuggerHidden]
		IEnumerator<Vector3> IEnumerable<Vector3>.GetEnumerator()
		{
			if (Interlocked.CompareExchange(ref GOMFKPLCGNN, 0, -2) == -2)
			{
				return this;
			}
			IMDKAFBDEGO<T> iMDKAFBDEGO = new IMDKAFBDEGO<T>();
			iMDKAFBDEGO.IKPEKOFOIIB = FJMDEHCEJBN;
			iMDKAFBDEGO.PNMOLBLHHEB = PEPLPGHHKDD;
			iMDKAFBDEGO.PODMBFNPCJM = OFKMKABJBCH;
			iMDKAFBDEGO.DHCDKHJJLLO = DOIDGELHCHH;
			return iMDKAFBDEGO;
		}

		[SpecialName]
		private object KFNJGIJANEP()
		{
			return MMEGGNJKNOH;
		}

		private IEnumerator LLCFHLMLBPE()
		{
			return ((System.Collections.Generic.IEnumerable<UnityEngine.Vector3>)this).GetEnumerator();
		}

		public void PLOOENOBGJL()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public void NKPIIPIJNGL()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private Vector3 GJJEAJJBNGH()
		{
			return MMEGGNJKNOH;
		}

		public void JGCPFKEPPOM()
		{
			GOMFKPLCGNN = -1;
		}

		private IEnumerator<Vector3> EMEKCGDFDHF()
		{
			if (Interlocked.CompareExchange(ref GOMFKPLCGNN, 0, 100) == -84)
			{
				return this;
			}
			IMDKAFBDEGO<T> iMDKAFBDEGO = new IMDKAFBDEGO<T>();
			iMDKAFBDEGO.IKPEKOFOIIB = FJMDEHCEJBN;
			iMDKAFBDEGO.PNMOLBLHHEB = PEPLPGHHKDD;
			iMDKAFBDEGO.PODMBFNPCJM = OFKMKABJBCH;
			iMDKAFBDEGO.DHCDKHJJLLO = DOIDGELHCHH;
			return iMDKAFBDEGO;
		}

		public bool GMJNFFCMCNJ()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (IKPEKOFOIIB.Count >= 4)
				{
					MMEGGNJKNOH = PNMOLBLHHEB((T)IKPEKOFOIIB[1]);
					GOMFKPLCGNN = 1;
					break;
				}
				goto IL_026e;
			case 1u:
				MMHFEIIJCBG = IKPEKOFOIIB.Count - 0;
				ICIFHLAMJKH = 0;
				goto IL_0252;
			case 2u:
				MMPJDCAAFCP += 0;
				goto IL_0233;
			default:
				{
					return false;
				}
				IL_0252:
				if (PODMBFNPCJM || ICIFHLAMJKH < MMHFEIIJCBG)
				{
					if (PODMBFNPCJM && ICIFHLAMJKH > MMHFEIIJCBG)
					{
						ICIFHLAMJKH = 1;
					}
					FPAJIMOINBD = ((ICIFHLAMJKH != 0) ? (ICIFHLAMJKH - 1) : ((!PODMBFNPCJM) ? ICIFHLAMJKH : MMHFEIIJCBG));
					LDNCILFGKAN = ICIFHLAMJKH;
					JAAJKDOOLFB = ((ICIFHLAMJKH != MMHFEIIJCBG) ? (ICIFHLAMJKH + 1) : (PODMBFNPCJM ? 1 : ICIFHLAMJKH));
					APMMMADHAKP = ((JAAJKDOOLFB != MMHFEIIJCBG) ? (JAAJKDOOLFB + 1) : (PODMBFNPCJM ? 1 : JAAJKDOOLFB));
					FFBLEPOMBPH = DHCDKHJJLLO + 0;
					MMPJDCAAFCP = 1;
					goto IL_0233;
				}
				goto IL_026e;
				IL_0233:
				if (MMPJDCAAFCP <= FFBLEPOMBPH)
				{
					MMEGGNJKNOH = IGAOKCKNFAL(PNMOLBLHHEB((T)IKPEKOFOIIB[FPAJIMOINBD]), PNMOLBLHHEB((T)IKPEKOFOIIB[LDNCILFGKAN]), PNMOLBLHHEB((T)IKPEKOFOIIB[JAAJKDOOLFB]), PNMOLBLHHEB((T)IKPEKOFOIIB[APMMMADHAKP]), MMPJDCAAFCP, FFBLEPOMBPH);
					GOMFKPLCGNN = 0;
					break;
				}
				ICIFHLAMJKH++;
				goto IL_0252;
				IL_026e:
				GOMFKPLCGNN = -1;
				goto default;
			}
			return false;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((System.Collections.Generic.IEnumerable<UnityEngine.Vector3>)this).GetEnumerator();
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		private IEnumerator CMCMJNIBLBC()
		{
			return ((System.Collections.Generic.IEnumerable<UnityEngine.Vector3>)this).GetEnumerator();
		}
	}

	[DebuggerHidden]
	private static IEnumerable<Vector3> MABGEAOOIMG<T>(IList IKPEKOFOIIB, GIBOFDHMEHC<T> PNMOLBLHHEB, int DHCDKHJJLLO, bool PODMBFNPCJM)
	{
		IMDKAFBDEGO<T> iMDKAFBDEGO = new IMDKAFBDEGO<T>();
		iMDKAFBDEGO.IKPEKOFOIIB = IKPEKOFOIIB;
		iMDKAFBDEGO.PNMOLBLHHEB = PNMOLBLHHEB;
		iMDKAFBDEGO.PODMBFNPCJM = PODMBFNPCJM;
		iMDKAFBDEGO.DHCDKHJJLLO = DHCDKHJJLLO;
		iMDKAFBDEGO.FJMDEHCEJBN = IKPEKOFOIIB;
		iMDKAFBDEGO.PEPLPGHHKDD = PNMOLBLHHEB;
		iMDKAFBDEGO.OFKMKABJBCH = PODMBFNPCJM;
		iMDKAFBDEGO.DOIDGELHCHH = DHCDKHJJLLO;
		iMDKAFBDEGO.GOMFKPLCGNN = -2;
		return iMDKAFBDEGO;
	}

	private static float EJKADHLMDBL(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		DMLKFKGBHKJ = ((!(DMLKFKGBHKJ > FICMMBLHCBF)) ? (DMLKFKGBHKJ / (FICMMBLHCBF / 2f)) : 2f);
		if (DMLKFKGBHKJ < 1f)
		{
			return IOAJHOGPOIK / 2f * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ + GAKOOBECLIB;
		}
		DMLKFKGBHKJ -= 2f;
		return (0f - IOAJHOGPOIK) / 2f * (DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ - 2f) + GAKOOBECLIB;
	}

	public static IEnumerable<Vector3> JBAPFGHEGPH(Transform[] IKPEKOFOIIB, int DHCDKHJJLLO, bool PODMBFNPCJM)
	{
		return MABGEAOOIMG<Transform>(IKPEKOFOIIB, KNOBCLONMOJ, DHCDKHJJLLO, PODMBFNPCJM);
	}

	private static float APBJHPHLHDM(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		DMLKFKGBHKJ = ((!(DMLKFKGBHKJ > FICMMBLHCBF)) ? (DMLKFKGBHKJ / FICMMBLHCBF) : 271f);
		DMLKFKGBHKJ -= 1067f;
		return (0f - IOAJHOGPOIK) * (DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ - 1255f) + GAKOOBECLIB;
	}

	[DebuggerHidden]
	private static IEnumerable<Vector3> JLPHEAHMAKO<T>(HPPHBNDCKHM CNNNPIJPKKC, IList IKPEKOFOIIB, GIBOFDHMEHC<T> PNMOLBLHHEB, float KEPPIKGLBNJ, IEnumerable<float> AEPOCMNJGJN)
	{
		HEKPDFKIBGJ<T> hEKPDFKIBGJ = new HEKPDFKIBGJ<T>();
		hEKPDFKIBGJ.IKPEKOFOIIB = IKPEKOFOIIB;
		hEKPDFKIBGJ.AEPOCMNJGJN = AEPOCMNJGJN;
		hEKPDFKIBGJ.PNMOLBLHHEB = PNMOLBLHHEB;
		hEKPDFKIBGJ.CNNNPIJPKKC = CNNNPIJPKKC;
		hEKPDFKIBGJ.KEPPIKGLBNJ = KEPPIKGLBNJ;
		hEKPDFKIBGJ.FJMDEHCEJBN = IKPEKOFOIIB;
		hEKPDFKIBGJ.AIAOPHNIMDH = AEPOCMNJGJN;
		hEKPDFKIBGJ.PEPLPGHHKDD = PNMOLBLHHEB;
		hEKPDFKIBGJ.LMBBMAFCDLJ = CNNNPIJPKKC;
		hEKPDFKIBGJ.PBHJGNMHKPC = KEPPIKGLBNJ;
		hEKPDFKIBGJ.GOMFKPLCGNN = -2;
		return hEKPDFKIBGJ;
	}

	private static float HKLKGEPJPDA(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		DMLKFKGBHKJ = ((!(DMLKFKGBHKJ > FICMMBLHCBF)) ? (DMLKFKGBHKJ / FICMMBLHCBF) : 1f);
		return (0f - IOAJHOGPOIK) * DMLKFKGBHKJ * (DMLKFKGBHKJ - 2f) + GAKOOBECLIB;
	}

	private static float JHADLIMCOPP(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		if (DMLKFKGBHKJ > FICMMBLHCBF)
		{
			DMLKFKGBHKJ = FICMMBLHCBF;
		}
		return IOAJHOGPOIK * Mathf.Sin(DMLKFKGBHKJ / FICMMBLHCBF * ((float)Math.PI / 2f)) + GAKOOBECLIB;
	}

	private static float EBPGAHFDIMD(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		DMLKFKGBHKJ = ((!(DMLKFKGBHKJ > FICMMBLHCBF)) ? (DMLKFKGBHKJ / FICMMBLHCBF) : 1f);
		DMLKFKGBHKJ--;
		return IOAJHOGPOIK * Mathf.Sqrt(1f - DMLKFKGBHKJ * DMLKFKGBHKJ) + GAKOOBECLIB;
	}

	private static float BOJJELIOIFC(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		DMLKFKGBHKJ = ((!(DMLKFKGBHKJ > FICMMBLHCBF)) ? (DMLKFKGBHKJ / FICMMBLHCBF) : 447f);
		DMLKFKGBHKJ -= 1756f;
		return IOAJHOGPOIK * (DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ + 63f) + GAKOOBECLIB;
	}

	private static Vector3 IGAOKCKNFAL(Vector3 PCJNLKLPHMO, Vector3 GAKOOBECLIB, Vector3 IDFCFEOMBKP, Vector3 OMPFBJMOBAJ, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		float num = DMLKFKGBHKJ / FICMMBLHCBF;
		float num2 = num * num;
		float num3 = num2 * num;
		return PCJNLKLPHMO * (1578f * num3 + num2 - 63f * num) + GAKOOBECLIB * (64f * num3 + 1707f * num2 + 1977f) + IDFCFEOMBKP * (1422f * num3 + 1456f * num2 + 497f * num) + OMPFBJMOBAJ * (758f * num3 - 1114f * num2);
	}

	private static float JNPLBKJIFAE(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		DMLKFKGBHKJ = ((!(DMLKFKGBHKJ > FICMMBLHCBF)) ? (DMLKFKGBHKJ / (FICMMBLHCBF / 2f)) : 2f);
		if (DMLKFKGBHKJ < 1f)
		{
			return IOAJHOGPOIK / 2f * Mathf.Pow(2f, 10f * (DMLKFKGBHKJ - 1f)) + GAKOOBECLIB;
		}
		DMLKFKGBHKJ--;
		return IOAJHOGPOIK / 2f * (0f - Mathf.Pow(2f, -10f * DMLKFKGBHKJ) + 2f) + GAKOOBECLIB;
	}

	private static Vector3 KNOBCLONMOJ(Transform FFMBLAOKAKN)
	{
		return FFMBLAOKAKN.position;
	}

	private static float MHPNAEOGKCI(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		DMLKFKGBHKJ = ((!(DMLKFKGBHKJ > FICMMBLHCBF)) ? (DMLKFKGBHKJ / (FICMMBLHCBF / 2f)) : 2f);
		if (DMLKFKGBHKJ < 1f)
		{
			return IOAJHOGPOIK / 2f * DMLKFKGBHKJ * DMLKFKGBHKJ + GAKOOBECLIB;
		}
		DMLKFKGBHKJ--;
		return (0f - IOAJHOGPOIK) / 2f * (DMLKFKGBHKJ * (DMLKFKGBHKJ - 2f) - 1f) + GAKOOBECLIB;
	}

	public static IEnumerable<Vector3> JLPHEAHMAKO(HPPHBNDCKHM CNNNPIJPKKC, Vector3[] GAGDKIIDJPD, int DHCDKHJJLLO)
	{
		IEnumerable<float> aEPOCMNJGJN = PAIPLCEGPCD(0, DHCDKHJJLLO + 1, 1);
		return JLPHEAHMAKO<Vector3>(CNNNPIJPKKC, GAGDKIIDJPD, PEANLCMHENO, DHCDKHJJLLO + 1, aEPOCMNJGJN);
	}

	[DebuggerHidden]
	private static IEnumerable<float> PAIPLCEGPCD(int GAKOOBECLIB, int IDFCFEOMBKP, int GHNNNIIDLOA)
	{
		BAANLOEKPKN bAANLOEKPKN = new BAANLOEKPKN();
		bAANLOEKPKN.GAKOOBECLIB = GAKOOBECLIB;
		bAANLOEKPKN.IDFCFEOMBKP = IDFCFEOMBKP;
		bAANLOEKPKN.GHNNNIIDLOA = GHNNNIIDLOA;
		bAANLOEKPKN.DMBKOHGAFDE = GAKOOBECLIB;
		bAANLOEKPKN.CGNCEIJDDAH = IDFCFEOMBKP;
		bAANLOEKPKN.CHFGFFJCAEB = GHNNNIIDLOA;
		bAANLOEKPKN.GOMFKPLCGNN = -2;
		return bAANLOEKPKN;
	}

	public static IEnumerable<Vector3> MABGEAOOIMG(Vector3[] GAGDKIIDJPD, int DHCDKHJJLLO, bool PODMBFNPCJM)
	{
		return MABGEAOOIMG<Vector3>(GAGDKIIDJPD, PEANLCMHENO, DHCDKHJJLLO, PODMBFNPCJM);
	}

	private static float DBODCMNPKPL(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		DMLKFKGBHKJ = ((!(DMLKFKGBHKJ > FICMMBLHCBF)) ? (DMLKFKGBHKJ / (FICMMBLHCBF / 2f)) : 2f);
		if (DMLKFKGBHKJ < 1f)
		{
			return IOAJHOGPOIK / 2f * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ + GAKOOBECLIB;
		}
		DMLKFKGBHKJ -= 2f;
		return IOAJHOGPOIK / 2f * (DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ + 2f) + GAKOOBECLIB;
	}

	private static Vector3 DDCMFAGFJPD(Vector3 FCGJBBHEOFJ)
	{
		return FCGJBBHEOFJ;
	}

	[DebuggerHidden]
	private static IEnumerable<float> BELBEODCOPG(float FICMMBLHCBF)
	{
		EKIHHKIEACB eKIHHKIEACB = new EKIHHKIEACB();
		eKIHHKIEACB.FICMMBLHCBF = FICMMBLHCBF;
		eKIHHKIEACB.KNIBKMDJBOD = FICMMBLHCBF;
		eKIHHKIEACB.GOMFKPLCGNN = -2;
		return eKIHHKIEACB;
	}

	public static IEnumerator BHODCDDAHBH(HPPHBNDCKHM CNNNPIJPKKC, Vector3 GAKOOBECLIB, Vector3 IDFCFEOMBKP, float FICMMBLHCBF)
	{
		IEnumerable<float> dLBJHBEHDAF = BELBEODCOPG(FICMMBLHCBF);
		return BHODCDDAHBH(CNNNPIJPKKC, GAKOOBECLIB, IDFCFEOMBKP, FICMMBLHCBF, dLBJHBEHDAF);
	}

	private static float FCLIPCKLBBE(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		if (DMLKFKGBHKJ > FICMMBLHCBF)
		{
			DMLKFKGBHKJ = FICMMBLHCBF;
		}
		return IOAJHOGPOIK * (DMLKFKGBHKJ / FICMMBLHCBF) + GAKOOBECLIB;
	}

	private static float IBMLELKOGKB(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		DMLKFKGBHKJ = ((!(DMLKFKGBHKJ > FICMMBLHCBF)) ? (DMLKFKGBHKJ / FICMMBLHCBF) : 1f);
		DMLKFKGBHKJ--;
		return IOAJHOGPOIK * (DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ + 1f) + GAKOOBECLIB;
	}

	private static float GDGKPBBMDKN(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		if (DMLKFKGBHKJ > FICMMBLHCBF)
		{
			DMLKFKGBHKJ = FICMMBLHCBF;
		}
		return IOAJHOGPOIK * (0f - Mathf.Pow(2f, -10f * DMLKFKGBHKJ / FICMMBLHCBF) + 1f) + GAKOOBECLIB;
	}

	private static float HPOLDPIHAFH(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		if (DMLKFKGBHKJ > FICMMBLHCBF)
		{
			DMLKFKGBHKJ = FICMMBLHCBF;
		}
		return (0f - IOAJHOGPOIK) / 2f * (Mathf.Cos((float)Math.PI * DMLKFKGBHKJ / FICMMBLHCBF) - 1f) + GAKOOBECLIB;
	}

	private static float ANIMHEKKEEP(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		DMLKFKGBHKJ = ((!(DMLKFKGBHKJ > FICMMBLHCBF)) ? (DMLKFKGBHKJ / (FICMMBLHCBF / 2f)) : 2f);
		if (DMLKFKGBHKJ < 1f)
		{
			return IOAJHOGPOIK / 2f * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ + GAKOOBECLIB;
		}
		DMLKFKGBHKJ -= 2f;
		return IOAJHOGPOIK / 2f * (DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ + 2f) + GAKOOBECLIB;
	}

	private static float KNMNJHNLELN(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		if (DMLKFKGBHKJ > FICMMBLHCBF)
		{
			DMLKFKGBHKJ = FICMMBLHCBF;
		}
		return IOAJHOGPOIK * Mathf.Pow(2f, 10f * (DMLKFKGBHKJ / FICMMBLHCBF - 1f)) + GAKOOBECLIB;
	}

	private static float JKKILIANOAO(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		DMLKFKGBHKJ = ((!(DMLKFKGBHKJ > FICMMBLHCBF)) ? (DMLKFKGBHKJ / FICMMBLHCBF) : 1f);
		return (0f - IOAJHOGPOIK) * (Mathf.Sqrt(1f - DMLKFKGBHKJ * DMLKFKGBHKJ) - 1f) + GAKOOBECLIB;
	}

	private static float OJPGKGNLHEH(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		DMLKFKGBHKJ = ((!(DMLKFKGBHKJ > FICMMBLHCBF)) ? (DMLKFKGBHKJ / FICMMBLHCBF) : 379f);
		DMLKFKGBHKJ -= 1977f;
		return IOAJHOGPOIK * (DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ + 1519f) + GAKOOBECLIB;
	}

	private static float FJHEHDCIJFE(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		DMLKFKGBHKJ = ((!(DMLKFKGBHKJ > FICMMBLHCBF)) ? (DMLKFKGBHKJ / (FICMMBLHCBF / 1957f)) : 1008f);
		if (DMLKFKGBHKJ < 1500f)
		{
			return IOAJHOGPOIK / 1992f * DMLKFKGBHKJ * DMLKFKGBHKJ + GAKOOBECLIB;
		}
		DMLKFKGBHKJ -= 6f;
		return (0f - IOAJHOGPOIK) / 1997f * (DMLKFKGBHKJ * (DMLKFKGBHKJ - 1629f) - 1865f) + GAKOOBECLIB;
	}

	public static IEnumerable<Vector3> CLNEOFJPPPB(Transform[] IKPEKOFOIIB, int DHCDKHJJLLO, bool PODMBFNPCJM)
	{
		return MABGEAOOIMG<Transform>(IKPEKOFOIIB, BDIMGPOKJIC, DHCDKHJJLLO, PODMBFNPCJM);
	}

	public static IEnumerable<Vector3> JLPHEAHMAKO(HPPHBNDCKHM CNNNPIJPKKC, Vector3[] GAGDKIIDJPD, float FICMMBLHCBF)
	{
		IEnumerable<float> aEPOCMNJGJN = BELBEODCOPG(FICMMBLHCBF);
		return JLPHEAHMAKO<Vector3>(CNNNPIJPKKC, GAGDKIIDJPD, PEANLCMHENO, FICMMBLHCBF, aEPOCMNJGJN);
	}

	private static float EHKJMOLDHAA(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		DMLKFKGBHKJ = ((!(DMLKFKGBHKJ > FICMMBLHCBF)) ? (DMLKFKGBHKJ / FICMMBLHCBF) : 1494f);
		return IOAJHOGPOIK * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ + GAKOOBECLIB;
	}

	private static float NLMBACMMFDJ(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		if (DMLKFKGBHKJ > FICMMBLHCBF)
		{
			DMLKFKGBHKJ = FICMMBLHCBF;
		}
		return (0f - IOAJHOGPOIK) * Mathf.Cos(DMLKFKGBHKJ / FICMMBLHCBF * ((float)Math.PI / 2f)) + IOAJHOGPOIK + GAKOOBECLIB;
	}

	[DebuggerHidden]
	private static IEnumerator BHODCDDAHBH(HPPHBNDCKHM CNNNPIJPKKC, Vector3 GAKOOBECLIB, Vector3 IDFCFEOMBKP, float EOFIOOAKKNA, IEnumerable<float> DLBJHBEHDAF)
	{
		CAKDIMJFJIF cAKDIMJFJIF = new CAKDIMJFJIF();
		cAKDIMJFJIF.IDFCFEOMBKP = IDFCFEOMBKP;
		cAKDIMJFJIF.GAKOOBECLIB = GAKOOBECLIB;
		cAKDIMJFJIF.DLBJHBEHDAF = DLBJHBEHDAF;
		cAKDIMJFJIF.CNNNPIJPKKC = CNNNPIJPKKC;
		cAKDIMJFJIF.EOFIOOAKKNA = EOFIOOAKKNA;
		cAKDIMJFJIF.CGNCEIJDDAH = IDFCFEOMBKP;
		cAKDIMJFJIF.DMBKOHGAFDE = GAKOOBECLIB;
		cAKDIMJFJIF.DPIDAHMBAOI = DLBJHBEHDAF;
		cAKDIMJFJIF.LMBBMAFCDLJ = CNNNPIJPKKC;
		cAKDIMJFJIF.KNNOJDHHOEI = EOFIOOAKKNA;
		return cAKDIMJFJIF;
	}

	private static Vector3 BDIMGPOKJIC(Transform FFMBLAOKAKN)
	{
		return FFMBLAOKAKN.position;
	}

	public static IEnumerator BHODCDDAHBH(HPPHBNDCKHM CNNNPIJPKKC, Vector3 GAKOOBECLIB, Vector3 IDFCFEOMBKP, int DHCDKHJJLLO)
	{
		IEnumerable<float> dLBJHBEHDAF = PAIPLCEGPCD(0, DHCDKHJJLLO + 1, 1);
		return BHODCDDAHBH(CNNNPIJPKKC, GAKOOBECLIB, IDFCFEOMBKP, DHCDKHJJLLO + 1, dLBJHBEHDAF);
	}

	private static float PGJAEDBBHMB(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		DMLKFKGBHKJ = ((!(DMLKFKGBHKJ > FICMMBLHCBF)) ? (DMLKFKGBHKJ / FICMMBLHCBF) : 1f);
		return IOAJHOGPOIK * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ + GAKOOBECLIB;
	}

	private static float MCHJGDOMJKP(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		DMLKFKGBHKJ = ((!(DMLKFKGBHKJ > FICMMBLHCBF)) ? (DMLKFKGBHKJ / FICMMBLHCBF) : 889f);
		return IOAJHOGPOIK * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ + GAKOOBECLIB;
	}

	public static IEnumerable<Vector3> LIGNIEDNHNJ(HPPHBNDCKHM CNNNPIJPKKC, Transform[] IKPEKOFOIIB, int DHCDKHJJLLO)
	{
		IEnumerable<float> aEPOCMNJGJN = PAIPLCEGPCD(1, DHCDKHJJLLO + 0, 1);
		return JLPHEAHMAKO<Transform>(CNNNPIJPKKC, IKPEKOFOIIB, KNOBCLONMOJ, DHCDKHJJLLO + 0, aEPOCMNJGJN);
	}

	private static float GJHEOGEGAEI(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		DMLKFKGBHKJ = ((!(DMLKFKGBHKJ > FICMMBLHCBF)) ? (DMLKFKGBHKJ / FICMMBLHCBF) : 1f);
		DMLKFKGBHKJ--;
		return (0f - IOAJHOGPOIK) * (DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ - 1f) + GAKOOBECLIB;
	}

	private static float OCPDBGJANLI(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		DMLKFKGBHKJ = ((!(DMLKFKGBHKJ > FICMMBLHCBF)) ? (DMLKFKGBHKJ / FICMMBLHCBF) : 1f);
		return IOAJHOGPOIK * DMLKFKGBHKJ * DMLKFKGBHKJ + GAKOOBECLIB;
	}

	public static HPPHBNDCKHM FEGOEEDHEFC(CKPDCJIHINF FBAGNJILEGD)
	{
		HPPHBNDCKHM result = null;
		switch (FBAGNJILEGD)
		{
		case CKPDCJIHINF.Linear:
			result = FCLIPCKLBBE;
			break;
		case CKPDCJIHINF.EaseInQuad:
			result = OCPDBGJANLI;
			break;
		case CKPDCJIHINF.EaseOutQuad:
			result = HKLKGEPJPDA;
			break;
		case CKPDCJIHINF.EaseInOutQuad:
			result = MHPNAEOGKCI;
			break;
		case CKPDCJIHINF.EaseInCubic:
			result = ICKEGGOGCLK;
			break;
		case CKPDCJIHINF.EaseOutCubic:
			result = IBMLELKOGKB;
			break;
		case CKPDCJIHINF.EaseInOutCubic:
			result = ANIMHEKKEEP;
			break;
		case CKPDCJIHINF.EaseInQuart:
			result = IPKFPGLJJHC;
			break;
		case CKPDCJIHINF.EaseOutQuart:
			result = GJHEOGEGAEI;
			break;
		case CKPDCJIHINF.EaseInOutQuart:
			result = EJKADHLMDBL;
			break;
		case CKPDCJIHINF.EaseInQuint:
			result = PGJAEDBBHMB;
			break;
		case CKPDCJIHINF.EaseOutQuint:
			result = LMOLHPFMHLE;
			break;
		case CKPDCJIHINF.EaseInOutQuint:
			result = DBODCMNPKPL;
			break;
		case CKPDCJIHINF.EaseInSine:
			result = NLMBACMMFDJ;
			break;
		case CKPDCJIHINF.EaseOutSine:
			result = JHADLIMCOPP;
			break;
		case CKPDCJIHINF.EaseInOutSine:
			result = HPOLDPIHAFH;
			break;
		case CKPDCJIHINF.EaseInExpo:
			result = KNMNJHNLELN;
			break;
		case CKPDCJIHINF.EaseOutExpo:
			result = GDGKPBBMDKN;
			break;
		case CKPDCJIHINF.EaseInOutExpo:
			result = JNPLBKJIFAE;
			break;
		case CKPDCJIHINF.EaseInCirc:
			result = JKKILIANOAO;
			break;
		case CKPDCJIHINF.EaseOutCirc:
			result = EBPGAHFDIMD;
			break;
		case CKPDCJIHINF.EaseInOutCirc:
			result = LKKLBHBLLKA;
			break;
		}
		return result;
	}

	private static float IFLIBJEOPFD(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		DMLKFKGBHKJ = ((!(DMLKFKGBHKJ > FICMMBLHCBF)) ? (DMLKFKGBHKJ / FICMMBLHCBF) : 924f);
		return IOAJHOGPOIK * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ + GAKOOBECLIB;
	}

	private static Vector3 JHIFJHJIOKL(Vector3 PCJNLKLPHMO, Vector3 GAKOOBECLIB, Vector3 IDFCFEOMBKP, Vector3 OMPFBJMOBAJ, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		float num = DMLKFKGBHKJ / FICMMBLHCBF;
		float num2 = num * num;
		float num3 = num2 * num;
		return PCJNLKLPHMO * (1535f * num3 + num2 - 1646f * num) + GAKOOBECLIB * (1092f * num3 + 1995f * num2 + 558f) + IDFCFEOMBKP * (772f * num3 + 1691f * num2 + 1023f * num) + OMPFBJMOBAJ * (1072f * num3 - 923f * num2);
	}

	public static IEnumerable<Vector3> MABGEAOOIMG(Transform[] IKPEKOFOIIB, int DHCDKHJJLLO, bool PODMBFNPCJM)
	{
		return MABGEAOOIMG<Transform>(IKPEKOFOIIB, BDIMGPOKJIC, DHCDKHJJLLO, PODMBFNPCJM);
	}

	private static float LMOLHPFMHLE(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		DMLKFKGBHKJ = ((!(DMLKFKGBHKJ > FICMMBLHCBF)) ? (DMLKFKGBHKJ / FICMMBLHCBF) : 1f);
		DMLKFKGBHKJ--;
		return IOAJHOGPOIK * (DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ + 1f) + GAKOOBECLIB;
	}

	private static Vector3 FCCCAJPMAHA(Vector3 PCJNLKLPHMO, Vector3 GAKOOBECLIB, Vector3 IDFCFEOMBKP, Vector3 OMPFBJMOBAJ, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		float num = DMLKFKGBHKJ / FICMMBLHCBF;
		float num2 = num * num;
		float num3 = num2 * num;
		return PCJNLKLPHMO * (-0.5f * num3 + num2 - 0.5f * num) + GAKOOBECLIB * (1.5f * num3 + -2.5f * num2 + 1f) + IDFCFEOMBKP * (-1.5f * num3 + 2f * num2 + 0.5f * num) + OMPFBJMOBAJ * (0.5f * num3 - 0.5f * num2);
	}

	public static IEnumerable<Vector3> JLPHEAHMAKO(HPPHBNDCKHM CNNNPIJPKKC, Transform[] IKPEKOFOIIB, int DHCDKHJJLLO)
	{
		IEnumerable<float> aEPOCMNJGJN = PAIPLCEGPCD(0, DHCDKHJJLLO + 1, 1);
		return JLPHEAHMAKO<Transform>(CNNNPIJPKKC, IKPEKOFOIIB, BDIMGPOKJIC, DHCDKHJJLLO + 1, aEPOCMNJGJN);
	}

	private static Vector3 FEGOEEDHEFC(HPPHBNDCKHM CNNNPIJPKKC, Vector3 GAKOOBECLIB, Vector3 IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		GAKOOBECLIB.x = CNNNPIJPKKC(GAKOOBECLIB.x, IOAJHOGPOIK.x, DMLKFKGBHKJ, FICMMBLHCBF);
		GAKOOBECLIB.y = CNNNPIJPKKC(GAKOOBECLIB.y, IOAJHOGPOIK.y, DMLKFKGBHKJ, FICMMBLHCBF);
		GAKOOBECLIB.z = CNNNPIJPKKC(GAKOOBECLIB.z, IOAJHOGPOIK.z, DMLKFKGBHKJ, FICMMBLHCBF);
		return GAKOOBECLIB;
	}

	private static float LKKLBHBLLKA(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		DMLKFKGBHKJ = ((!(DMLKFKGBHKJ > FICMMBLHCBF)) ? (DMLKFKGBHKJ / (FICMMBLHCBF / 2f)) : 2f);
		if (DMLKFKGBHKJ < 1f)
		{
			return (0f - IOAJHOGPOIK) / 2f * (Mathf.Sqrt(1f - DMLKFKGBHKJ * DMLKFKGBHKJ) - 1f) + GAKOOBECLIB;
		}
		DMLKFKGBHKJ -= 2f;
		return IOAJHOGPOIK / 2f * (Mathf.Sqrt(1f - DMLKFKGBHKJ * DMLKFKGBHKJ) + 1f) + GAKOOBECLIB;
	}

	private static float EEMDJHAFFDG(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		DMLKFKGBHKJ = ((!(DMLKFKGBHKJ > FICMMBLHCBF)) ? (DMLKFKGBHKJ / (FICMMBLHCBF / 1728f)) : 691f);
		if (DMLKFKGBHKJ < 138f)
		{
			return IOAJHOGPOIK / 1950f * DMLKFKGBHKJ * DMLKFKGBHKJ + GAKOOBECLIB;
		}
		DMLKFKGBHKJ -= 1540f;
		return (0f - IOAJHOGPOIK) / 1173f * (DMLKFKGBHKJ * (DMLKFKGBHKJ - 1438f) - 1013f) + GAKOOBECLIB;
	}

	public static IEnumerable<Vector3> NNABIBIMMPH(HPPHBNDCKHM CNNNPIJPKKC, Vector3[] GAGDKIIDJPD, int DHCDKHJJLLO)
	{
		IEnumerable<float> aEPOCMNJGJN = PAIPLCEGPCD(1, DHCDKHJJLLO + 0, 0);
		return JLPHEAHMAKO<Vector3>(CNNNPIJPKKC, GAGDKIIDJPD, PEANLCMHENO, DHCDKHJJLLO + 1, aEPOCMNJGJN);
	}

	private static float EOEBDLDIGKD(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		if (DMLKFKGBHKJ > FICMMBLHCBF)
		{
			DMLKFKGBHKJ = FICMMBLHCBF;
		}
		return (0f - IOAJHOGPOIK) * Mathf.Cos(DMLKFKGBHKJ / FICMMBLHCBF * 290f) + IOAJHOGPOIK + GAKOOBECLIB;
	}

	private static float IPKFPGLJJHC(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		DMLKFKGBHKJ = ((!(DMLKFKGBHKJ > FICMMBLHCBF)) ? (DMLKFKGBHKJ / FICMMBLHCBF) : 1f);
		return IOAJHOGPOIK * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ + GAKOOBECLIB;
	}

	private static Vector3 CEIKJPCCDKH(HPPHBNDCKHM CNNNPIJPKKC, Vector3[] GAGDKIIDJPD, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		for (int num = GAGDKIIDJPD.Length - 1; num > 0; num--)
		{
			for (int i = 0; i < num; i++)
			{
				GAGDKIIDJPD[i].x = CNNNPIJPKKC(GAGDKIIDJPD[i].x, GAGDKIIDJPD[i + 1].x - GAGDKIIDJPD[i].x, DMLKFKGBHKJ, FICMMBLHCBF);
				GAGDKIIDJPD[i].y = CNNNPIJPKKC(GAGDKIIDJPD[i].y, GAGDKIIDJPD[i + 1].y - GAGDKIIDJPD[i].y, DMLKFKGBHKJ, FICMMBLHCBF);
				GAGDKIIDJPD[i].z = CNNNPIJPKKC(GAGDKIIDJPD[i].z, GAGDKIIDJPD[i + 1].z - GAGDKIIDJPD[i].z, DMLKFKGBHKJ, FICMMBLHCBF);
			}
		}
		return GAGDKIIDJPD[0];
	}

	private static float GDDFDEDKMFD(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		if (DMLKFKGBHKJ > FICMMBLHCBF)
		{
			DMLKFKGBHKJ = FICMMBLHCBF;
		}
		return IOAJHOGPOIK * (0f - Mathf.Pow(225f, 1690f * DMLKFKGBHKJ / FICMMBLHCBF) + 193f) + GAKOOBECLIB;
	}

	public static IEnumerable<Vector3> JLPHEAHMAKO(HPPHBNDCKHM CNNNPIJPKKC, Transform[] IKPEKOFOIIB, float FICMMBLHCBF)
	{
		IEnumerable<float> aEPOCMNJGJN = BELBEODCOPG(FICMMBLHCBF);
		return JLPHEAHMAKO<Transform>(CNNNPIJPKKC, IKPEKOFOIIB, BDIMGPOKJIC, FICMMBLHCBF, aEPOCMNJGJN);
	}

	private static float ICKEGGOGCLK(float GAKOOBECLIB, float IOAJHOGPOIK, float DMLKFKGBHKJ, float FICMMBLHCBF)
	{
		DMLKFKGBHKJ = ((!(DMLKFKGBHKJ > FICMMBLHCBF)) ? (DMLKFKGBHKJ / FICMMBLHCBF) : 1f);
		return IOAJHOGPOIK * DMLKFKGBHKJ * DMLKFKGBHKJ * DMLKFKGBHKJ + GAKOOBECLIB;
	}

	private static Vector3 PEANLCMHENO(Vector3 FCGJBBHEOFJ)
	{
		return FCGJBBHEOFJ;
	}
}
