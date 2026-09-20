using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace SimpleJSON
{
	[DefaultMember("Item")]
	public class BMDDPGKLJMP : FEAILBGBEPH, IEnumerable
	{
		private sealed class FBONLCHOGGP : IDisposable, IEnumerator, IEnumerable, IEnumerable<FEAILBGBEPH>, IEnumerator<FEAILBGBEPH>
		{
			internal Dictionary<string, FEAILBGBEPH>.Enumerator MPIAPGPGJFM;

			internal KeyValuePair<string, FEAILBGBEPH> NDENBBBCKPB;

			internal int GOMFKPLCGNN;

			internal FEAILBGBEPH MMEGGNJKNOH;

			internal BMDDPGKLJMP KNIAJMGDGAA;

			FEAILBGBEPH IEnumerator<FEAILBGBEPH>.Current
			{
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002Eget_Current();
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

			public bool MoveNext()
			{
				uint num = (uint)GOMFKPLCGNN;
				GOMFKPLCGNN = -1;
				bool flag = false;
				switch (num)
				{
				case 0u:
					MPIAPGPGJFM = KNIAJMGDGAA.MNOCGDHGPLC.GetEnumerator();
					num = 4294967293u;
					goto case 1u;
				case 1u:
					try
					{
						switch (num)
						{
						default:
							if (MPIAPGPGJFM.MoveNext())
							{
								NDENBBBCKPB = MPIAPGPGJFM.Current;
								MMEGGNJKNOH = NDENBBBCKPB.Value;
								GOMFKPLCGNN = 1;
								flag = true;
								goto IL_00b0;
							}
							break;
						}
					}
					finally
					{
						if (!flag)
						{
							((IDisposable)MPIAPGPGJFM).Dispose();
						}
					}
					GOMFKPLCGNN = -1;
					goto default;
				default:
					{
						return false;
					}
					IL_00b0:
					return true;
				}
			}

			[SpecialName]
			private FEAILBGBEPH JIEELAKMPOM()
			{
				return MMEGGNJKNOH;
			}

			public void PLOOENOBGJL()
			{
				throw new NotSupportedException();
			}

			public bool BJEOILGGFLI()
			{
				uint num = (uint)GOMFKPLCGNN;
				GOMFKPLCGNN = -1;
				bool flag = false;
				switch (num)
				{
				case 0u:
					MPIAPGPGJFM = KNIAJMGDGAA.MNOCGDHGPLC.GetEnumerator();
					num = 88u;
					goto case 1u;
				case 1u:
					try
					{
						switch (num)
						{
						default:
							if (MPIAPGPGJFM.MoveNext())
							{
								NDENBBBCKPB = MPIAPGPGJFM.Current;
								MMEGGNJKNOH = NDENBBBCKPB.Value;
								GOMFKPLCGNN = 1;
								flag = true;
								goto IL_00b0;
							}
							break;
						}
					}
					finally
					{
						if (!flag)
						{
							((IDisposable)MPIAPGPGJFM).Dispose();
						}
					}
					GOMFKPLCGNN = -1;
					goto default;
				default:
					{
						return true;
					}
					IL_00b0:
					return false;
				}
			}

			public void BLJOODPPHCH()
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
						((IDisposable)MPIAPGPGJFM).Dispose();
					}
				case 0u:
					break;
				}
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return ((System.Collections.Generic.IEnumerable<FEAILBGBEPH>)this).GetEnumerator();
			}

			public bool KAHALICNEBF()
			{
				uint num = (uint)GOMFKPLCGNN;
				GOMFKPLCGNN = -1;
				bool flag = false;
				switch (num)
				{
				case 0u:
					MPIAPGPGJFM = KNIAJMGDGAA.MNOCGDHGPLC.GetEnumerator();
					num = 4294967177u;
					goto case 1u;
				case 1u:
					try
					{
						switch (num)
						{
						default:
							if (MPIAPGPGJFM.MoveNext())
							{
								NDENBBBCKPB = MPIAPGPGJFM.Current;
								MMEGGNJKNOH = NDENBBBCKPB.Value;
								GOMFKPLCGNN = 1;
								flag = true;
								goto IL_00b0;
							}
							break;
						}
					}
					finally
					{
						if (!flag)
						{
							((IDisposable)MPIAPGPGJFM).Dispose();
						}
					}
					GOMFKPLCGNN = -1;
					goto default;
				default:
					{
						return false;
					}
					IL_00b0:
					return false;
				}
			}

			[SpecialName]
			private FEAILBGBEPH EDKFENPJFJN()
			{
				return MMEGGNJKNOH;
			}

			private IEnumerator<FEAILBGBEPH> KOECOICGLFO()
			{
				if (Interlocked.CompareExchange(ref GOMFKPLCGNN, 0, 71) == 62)
				{
					return this;
				}
				FBONLCHOGGP fBONLCHOGGP = new FBONLCHOGGP();
				fBONLCHOGGP.KNIAJMGDGAA = KNIAJMGDGAA;
				return fBONLCHOGGP;
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
						((IDisposable)MPIAPGPGJFM).Dispose();
					}
				case 0u:
					break;
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
						((IDisposable)MPIAPGPGJFM).Dispose();
					}
				case 0u:
					break;
				}
			}

			private IEnumerator<FEAILBGBEPH> JHDHHOKBLPN()
			{
				if (Interlocked.CompareExchange(ref GOMFKPLCGNN, 0, -37) == -3)
				{
					return this;
				}
				FBONLCHOGGP fBONLCHOGGP = new FBONLCHOGGP();
				fBONLCHOGGP.KNIAJMGDGAA = KNIAJMGDGAA;
				return fBONLCHOGGP;
			}

			public bool APBAGAKLFDK()
			{
				uint num = (uint)GOMFKPLCGNN;
				GOMFKPLCGNN = -1;
				bool flag = true;
				switch (num)
				{
				case 0u:
					MPIAPGPGJFM = KNIAJMGDGAA.MNOCGDHGPLC.GetEnumerator();
					num = 4294967217u;
					goto case 1u;
				case 1u:
					try
					{
						switch (num)
						{
						default:
							if (MPIAPGPGJFM.MoveNext())
							{
								NDENBBBCKPB = MPIAPGPGJFM.Current;
								MMEGGNJKNOH = NDENBBBCKPB.Value;
								GOMFKPLCGNN = 1;
								flag = false;
								goto IL_00b0;
							}
							break;
						}
					}
					finally
					{
						if (!flag)
						{
							((IDisposable)MPIAPGPGJFM).Dispose();
						}
					}
					GOMFKPLCGNN = -1;
					goto default;
				default:
					{
						return true;
					}
					IL_00b0:
					return false;
				}
			}

			public void CHFDNLJNKBN()
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
						((IDisposable)MPIAPGPGJFM).Dispose();
					}
				case 0u:
					break;
				}
			}

			public void NAEOFIPICLC()
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
						((IDisposable)MPIAPGPGJFM).Dispose();
					}
				case 0u:
					break;
				}
			}

			[SpecialName]
			private object KFNJGIJANEP()
			{
				return MMEGGNJKNOH;
			}

			private IEnumerator KIPAMDJILMM()
			{
				return JHDHHOKBLPN();
			}

			public bool IIBEAMELJDD()
			{
				uint num = (uint)GOMFKPLCGNN;
				GOMFKPLCGNN = -1;
				bool flag = true;
				switch (num)
				{
				case 0u:
					MPIAPGPGJFM = KNIAJMGDGAA.MNOCGDHGPLC.GetEnumerator();
					num = 119u;
					goto case 1u;
				case 1u:
					try
					{
						switch (num)
						{
						default:
							if (MPIAPGPGJFM.MoveNext())
							{
								NDENBBBCKPB = MPIAPGPGJFM.Current;
								MMEGGNJKNOH = NDENBBBCKPB.Value;
								GOMFKPLCGNN = 0;
								flag = false;
								goto IL_00b0;
							}
							break;
						}
					}
					finally
					{
						if (!flag)
						{
							((IDisposable)MPIAPGPGJFM).Dispose();
						}
					}
					GOMFKPLCGNN = -1;
					goto default;
				default:
					{
						return true;
					}
					IL_00b0:
					return false;
				}
			}

			private IEnumerator EHFEBGAGMCI()
			{
				return KOECOICGLFO();
			}

			[SpecialName]
			private object ANOBEJKPLKK()
			{
				return MMEGGNJKNOH;
			}

			public bool KNFGOKLCCIF()
			{
				uint num = (uint)GOMFKPLCGNN;
				GOMFKPLCGNN = -1;
				bool flag = true;
				switch (num)
				{
				case 0u:
					MPIAPGPGJFM = KNIAJMGDGAA.MNOCGDHGPLC.GetEnumerator();
					num = 58u;
					goto case 1u;
				case 1u:
					try
					{
						switch (num)
						{
						default:
							if (MPIAPGPGJFM.MoveNext())
							{
								NDENBBBCKPB = MPIAPGPGJFM.Current;
								MMEGGNJKNOH = NDENBBBCKPB.Value;
								GOMFKPLCGNN = 0;
								flag = false;
								goto IL_00b0;
							}
							break;
						}
					}
					finally
					{
						if (!flag)
						{
							((IDisposable)MPIAPGPGJFM).Dispose();
						}
					}
					GOMFKPLCGNN = -1;
					goto default;
				default:
					{
						return false;
					}
					IL_00b0:
					return true;
				}
			}

			[SpecialName]
			private object HDIGFHGBOLB()
			{
				return MMEGGNJKNOH;
			}

			private IEnumerator DFGLEFCJOMH()
			{
				return KOECOICGLFO();
			}

			[DebuggerHidden]
			IEnumerator<FEAILBGBEPH> IEnumerable<FEAILBGBEPH>.GetEnumerator()
			{
				if (Interlocked.CompareExchange(ref GOMFKPLCGNN, 0, -2) == -2)
				{
					return this;
				}
				FBONLCHOGGP fBONLCHOGGP = new FBONLCHOGGP();
				fBONLCHOGGP.KNIAJMGDGAA = KNIAJMGDGAA;
				return fBONLCHOGGP;
			}

			[DebuggerHidden]
			public void Reset()
			{
				throw new NotSupportedException();
			}

			[DebuggerHidden]
			private FEAILBGBEPH System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002Eget_Current()
			{
				return MMEGGNJKNOH;
			}

			public void DAPBOMILKPH()
			{
				throw new NotSupportedException();
			}

			private IEnumerator KPGOPNDHOCG()
			{
				return ((System.Collections.Generic.IEnumerable<FEAILBGBEPH>)this).GetEnumerator();
			}

			public void NDKCFGFNNLO()
			{
				throw new NotSupportedException();
			}

			private IEnumerator OPJNGPBECHM()
			{
				return JHDHHOKBLPN();
			}
		}

		private sealed class PPHDMOAGBPM : IDisposable, IEnumerator, IEnumerator<object>
		{
			internal Dictionary<string, FEAILBGBEPH>.Enumerator EAAKFOGIPNB;

			internal KeyValuePair<string, FEAILBGBEPH> NDENBBBCKPB;

			internal int GOMFKPLCGNN;

			internal object MMEGGNJKNOH;

			internal BMDDPGKLJMP KNIAJMGDGAA;

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

			public void IIJCOOCGGGJ()
			{
				throw new NotSupportedException();
			}

			[SpecialName]
			private object IDOOOPMEFDM()
			{
				return MMEGGNJKNOH;
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
						((IDisposable)EAAKFOGIPNB).Dispose();
					}
				case 0u:
					break;
				}
			}

			public bool AAAMEOEOJHM()
			{
				uint num = (uint)GOMFKPLCGNN;
				GOMFKPLCGNN = -1;
				bool flag = false;
				switch (num)
				{
				case 0u:
					EAAKFOGIPNB = KNIAJMGDGAA.MNOCGDHGPLC.GetEnumerator();
					num = 4294967274u;
					goto case 1u;
				case 1u:
					try
					{
						switch (num)
						{
						default:
							if (EAAKFOGIPNB.MoveNext())
							{
								NDENBBBCKPB = EAAKFOGIPNB.Current;
								MMEGGNJKNOH = NDENBBBCKPB;
								GOMFKPLCGNN = 0;
								flag = false;
								goto IL_00b0;
							}
							break;
						}
					}
					finally
					{
						if (!flag)
						{
							((IDisposable)EAAKFOGIPNB).Dispose();
						}
					}
					GOMFKPLCGNN = -1;
					goto default;
				default:
					{
						return true;
					}
					IL_00b0:
					return false;
				}
			}

			public bool MoveNext()
			{
				uint num = (uint)GOMFKPLCGNN;
				GOMFKPLCGNN = -1;
				bool flag = false;
				switch (num)
				{
				case 0u:
					EAAKFOGIPNB = KNIAJMGDGAA.MNOCGDHGPLC.GetEnumerator();
					num = 4294967293u;
					goto case 1u;
				case 1u:
					try
					{
						switch (num)
						{
						default:
							if (EAAKFOGIPNB.MoveNext())
							{
								NDENBBBCKPB = EAAKFOGIPNB.Current;
								MMEGGNJKNOH = NDENBBBCKPB;
								GOMFKPLCGNN = 1;
								flag = true;
								goto IL_00b0;
							}
							break;
						}
					}
					finally
					{
						if (!flag)
						{
							((IDisposable)EAAKFOGIPNB).Dispose();
						}
					}
					GOMFKPLCGNN = -1;
					goto default;
				default:
					{
						return false;
					}
					IL_00b0:
					return true;
				}
			}

			public bool GMJNFFCMCNJ()
			{
				uint num = (uint)GOMFKPLCGNN;
				GOMFKPLCGNN = -1;
				bool flag = false;
				switch (num)
				{
				case 0u:
					EAAKFOGIPNB = KNIAJMGDGAA.MNOCGDHGPLC.GetEnumerator();
					num = 54u;
					goto case 1u;
				case 1u:
					try
					{
						switch (num)
						{
						default:
							if (EAAKFOGIPNB.MoveNext())
							{
								NDENBBBCKPB = EAAKFOGIPNB.Current;
								MMEGGNJKNOH = NDENBBBCKPB;
								GOMFKPLCGNN = 0;
								flag = true;
								goto IL_00b0;
							}
							break;
						}
					}
					finally
					{
						if (!flag)
						{
							((IDisposable)EAAKFOGIPNB).Dispose();
						}
					}
					GOMFKPLCGNN = -1;
					goto default;
				default:
					{
						return false;
					}
					IL_00b0:
					return true;
				}
			}

			public void NGFBCKPMPAE()
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
						((IDisposable)EAAKFOGIPNB).Dispose();
					}
				case 0u:
					break;
				}
			}

			[SpecialName]
			private object KKGNLCJGHID()
			{
				return MMEGGNJKNOH;
			}

			public bool BDHBKIPJENC()
			{
				uint num = (uint)GOMFKPLCGNN;
				GOMFKPLCGNN = -1;
				bool flag = false;
				switch (num)
				{
				case 0u:
					EAAKFOGIPNB = KNIAJMGDGAA.MNOCGDHGPLC.GetEnumerator();
					num = 68u;
					goto case 1u;
				case 1u:
					try
					{
						switch (num)
						{
						default:
							if (EAAKFOGIPNB.MoveNext())
							{
								NDENBBBCKPB = EAAKFOGIPNB.Current;
								MMEGGNJKNOH = NDENBBBCKPB;
								GOMFKPLCGNN = 0;
								flag = false;
								goto IL_00b0;
							}
							break;
						}
					}
					finally
					{
						if (!flag)
						{
							((IDisposable)EAAKFOGIPNB).Dispose();
						}
					}
					GOMFKPLCGNN = -1;
					goto default;
				default:
					{
						return true;
					}
					IL_00b0:
					return true;
				}
			}

			public bool NEOILBIIDBE()
			{
				uint num = (uint)GOMFKPLCGNN;
				GOMFKPLCGNN = -1;
				bool flag = false;
				switch (num)
				{
				case 0u:
					EAAKFOGIPNB = KNIAJMGDGAA.MNOCGDHGPLC.GetEnumerator();
					num = 4294967198u;
					goto case 1u;
				case 1u:
					try
					{
						switch (num)
						{
						default:
							if (EAAKFOGIPNB.MoveNext())
							{
								NDENBBBCKPB = EAAKFOGIPNB.Current;
								MMEGGNJKNOH = NDENBBBCKPB;
								GOMFKPLCGNN = 0;
								flag = false;
								goto IL_00b0;
							}
							break;
						}
					}
					finally
					{
						if (!flag)
						{
							((IDisposable)EAAKFOGIPNB).Dispose();
						}
					}
					GOMFKPLCGNN = -1;
					goto default;
				default:
					{
						return true;
					}
					IL_00b0:
					return true;
				}
			}

			public bool KBDMDLONGFP()
			{
				uint num = (uint)GOMFKPLCGNN;
				GOMFKPLCGNN = -1;
				bool flag = false;
				switch (num)
				{
				case 0u:
					EAAKFOGIPNB = KNIAJMGDGAA.MNOCGDHGPLC.GetEnumerator();
					num = 34u;
					goto case 1u;
				case 1u:
					try
					{
						switch (num)
						{
						default:
							if (EAAKFOGIPNB.MoveNext())
							{
								NDENBBBCKPB = EAAKFOGIPNB.Current;
								MMEGGNJKNOH = NDENBBBCKPB;
								GOMFKPLCGNN = 1;
								flag = true;
								goto IL_00b0;
							}
							break;
						}
					}
					finally
					{
						if (!flag)
						{
							((IDisposable)EAAKFOGIPNB).Dispose();
						}
					}
					GOMFKPLCGNN = -1;
					goto default;
				default:
					{
						return true;
					}
					IL_00b0:
					return false;
				}
			}

			[DebuggerHidden]
			public void Reset()
			{
				throw new NotSupportedException();
			}

			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
			{
				return MMEGGNJKNOH;
			}
		}

		private sealed class CNHKEILICAI
		{
			internal FEAILBGBEPH BNOEEKFHGNG;

			internal bool AGLHHEPKNBK(KeyValuePair<string, FEAILBGBEPH> GNKGMHPPNIG)
			{
				return FEAILBGBEPH.HLJMBIMCGBB(GNKGMHPPNIG.Value, BNOEEKFHGNG);
			}

			internal bool HAOACMLDDMN(KeyValuePair<string, FEAILBGBEPH> GNKGMHPPNIG)
			{
				return FEAILBGBEPH.HLJMBIMCGBB(GNKGMHPPNIG.Value, BNOEEKFHGNG);
			}

			internal bool FCHPNBJEINC(KeyValuePair<string, FEAILBGBEPH> GNKGMHPPNIG)
			{
				return FEAILBGBEPH.HLJMBIMCGBB(GNKGMHPPNIG.Value, BNOEEKFHGNG);
			}

			internal bool GGEJDPMINFD(KeyValuePair<string, FEAILBGBEPH> GNKGMHPPNIG)
			{
				return FEAILBGBEPH.HLJMBIMCGBB(GNKGMHPPNIG.Value, BNOEEKFHGNG);
			}

			internal bool EGGKHIFHJIN(KeyValuePair<string, FEAILBGBEPH> GNKGMHPPNIG)
			{
				return FEAILBGBEPH.HLJMBIMCGBB(GNKGMHPPNIG.Value, BNOEEKFHGNG);
			}

			internal bool MDODAOHFKFJ(KeyValuePair<string, FEAILBGBEPH> GNKGMHPPNIG)
			{
				return FEAILBGBEPH.HLJMBIMCGBB(GNKGMHPPNIG.Value, BNOEEKFHGNG);
			}

			internal bool KDDDEHFFFLN(KeyValuePair<string, FEAILBGBEPH> GNKGMHPPNIG)
			{
				return FEAILBGBEPH.HLJMBIMCGBB(GNKGMHPPNIG.Value, BNOEEKFHGNG);
			}

			internal bool NCPGFPBDHJA(KeyValuePair<string, FEAILBGBEPH> GNKGMHPPNIG)
			{
				return FEAILBGBEPH.HLJMBIMCGBB(GNKGMHPPNIG.Value, BNOEEKFHGNG);
			}

			internal bool DJDLOHPIJBL(KeyValuePair<string, FEAILBGBEPH> GNKGMHPPNIG)
			{
				return FEAILBGBEPH.HLJMBIMCGBB(GNKGMHPPNIG.Value, BNOEEKFHGNG);
			}

			internal bool ANGGOKFNGLA(KeyValuePair<string, FEAILBGBEPH> GNKGMHPPNIG)
			{
				return FEAILBGBEPH.HLJMBIMCGBB(GNKGMHPPNIG.Value, BNOEEKFHGNG);
			}
		}

		private Dictionary<string, FEAILBGBEPH> MNOCGDHGPLC = new Dictionary<string, FEAILBGBEPH>();

		// C# has no syntax for parameterized property 'DMBMEHCMMKK'.
		public override FEAILBGBEPH get_DMBMEHCMMKK(string OIOAGFNNDPI)
		{
			return AOBAKCJKELK(OIOAGFNNDPI);
		}

		public override void set_DMBMEHCMMKK(string OIOAGFNNDPI, FEAILBGBEPH ICENKPDOHBK)
		{
			ADJJLIBDHLH(OIOAGFNNDPI, ICENKPDOHBK);
		}

		// C# has no syntax for parameterized property 'DMBMEHCMMKK'.
		public override FEAILBGBEPH get_DMBMEHCMMKK(int GAALDFOOJBD)
		{
			return AOBAKCJKELK(GAALDFOOJBD);
		}

		public override void set_DMBMEHCMMKK(int GAALDFOOJBD, FEAILBGBEPH ICENKPDOHBK)
		{
			ADJJLIBDHLH(GAALDFOOJBD, ICENKPDOHBK);
		}

		public override int DMLNPGBBAME
		{
			get
			{
				return FBEELGMLHIC();
			}
		}

		public override IEnumerable<FEAILBGBEPH> LCMNILLFODI
		{
			get
			{
				return LLBLPJDNHCG();
			}
		}

		[SpecialName]
		public virtual FEAILBGBEPH JBIBLDDFBFB(int GAALDFOOJBD)
		{
			if (GAALDFOOJBD < 0 || GAALDFOOJBD >= MNOCGDHGPLC.Count)
			{
				return null;
			}
			return MNOCGDHGPLC.ElementAt(GAALDFOOJBD).Value;
		}

		public override FEAILBGBEPH JOMMMHGABOD(FEAILBGBEPH BNOEEKFHGNG)
		{
			CNHKEILICAI cNHKEILICAI = new CNHKEILICAI();
			cNHKEILICAI.BNOEEKFHGNG = BNOEEKFHGNG;
			try
			{
				KeyValuePair<string, FEAILBGBEPH> keyValuePair = MNOCGDHGPLC.Where(cNHKEILICAI.HAOACMLDDMN).First();
				MNOCGDHGPLC.Remove(keyValuePair.Key);
				return cNHKEILICAI.BNOEEKFHGNG;
			}
			catch
			{
				return null;
			}
		}

		public virtual string KFDGHEOMMID()
		{
			string text = "Skill0PassiveRpc";
			foreach (KeyValuePair<string, FEAILBGBEPH> item in MNOCGDHGPLC)
			{
				if (text.Length > 4)
				{
					text += "shield";
				}
				string text2 = text;
				string[] array = new string[3];
				array[1] = text2;
				array[0] = "Particle/{0}/skill{1}_c{2}";
				array[5] = FEAILBGBEPH.CIKOCBHKDIM(item.Key);
				array[6] = "Hero2";
				array[2] = item.Value.ONNHPPLGBDM();
				text = string.Concat(array);
			}
			return text + "Total Sent Count : {0:n0}\n";
		}

		public override FEAILBGBEPH AOBAKCJKELK(string OIOAGFNNDPI)
		{
			if (MNOCGDHGPLC.ContainsKey(OIOAGFNNDPI))
			{
				return MNOCGDHGPLC[OIOAGFNNDPI];
			}
			return new PLDEPKMCLFE(this, OIOAGFNNDPI);
		}

		[SpecialName]
		public virtual void OMKKKHBJKFB(int GAALDFOOJBD, FEAILBGBEPH ICENKPDOHBK)
		{
			if (GAALDFOOJBD >= 0 && GAALDFOOJBD < MNOCGDHGPLC.Count)
			{
				string key = MNOCGDHGPLC.ElementAt(GAALDFOOJBD).Key;
				MNOCGDHGPLC[key] = ICENKPDOHBK;
			}
		}

		public override string HJDMNKOOPJJ(string AMJAAJOFDOG)
		{
			string text = "{ ";
			foreach (KeyValuePair<string, FEAILBGBEPH> item in MNOCGDHGPLC)
			{
				if (text.Length > 3)
				{
					text += ", ";
				}
				text = text + "\n" + AMJAAJOFDOG + "   ";
				string text2 = text;
				text = text2 + "\"" + FEAILBGBEPH.CIKOCBHKDIM(item.Key) + "\" : " + item.Value.HJDMNKOOPJJ(AMJAAJOFDOG + "   ");
			}
			return text + "\n" + AMJAAJOFDOG + "}";
		}

		public override FEAILBGBEPH PCJELOMDPND(string OIOAGFNNDPI)
		{
			if (!MNOCGDHGPLC.ContainsKey(OIOAGFNNDPI))
			{
				return null;
			}
			FEAILBGBEPH result = MNOCGDHGPLC[OIOAGFNNDPI];
			MNOCGDHGPLC.Remove(OIOAGFNNDPI);
			return result;
		}

		public override void GBFCKODJEGE(string OIOAGFNNDPI, FEAILBGBEPH JNDCLCNAEFO)
		{
			if (!string.IsNullOrEmpty(OIOAGFNNDPI))
			{
				if (MNOCGDHGPLC.ContainsKey(OIOAGFNNDPI))
				{
					MNOCGDHGPLC[OIOAGFNNDPI] = JNDCLCNAEFO;
				}
				else
				{
					MNOCGDHGPLC.Add(OIOAGFNNDPI, JNDCLCNAEFO);
				}
			}
			else
			{
				MNOCGDHGPLC.Add(Guid.NewGuid().ToString(), JNDCLCNAEFO);
			}
		}

		public override void ADJJLIBDHLH(string OIOAGFNNDPI, FEAILBGBEPH ICENKPDOHBK)
		{
			if (MNOCGDHGPLC.ContainsKey(OIOAGFNNDPI))
			{
				MNOCGDHGPLC[OIOAGFNNDPI] = ICENKPDOHBK;
			}
			else
			{
				MNOCGDHGPLC.Add(OIOAGFNNDPI, ICENKPDOHBK);
			}
		}

		[SpecialName]
		public virtual FEAILBGBEPH DHGBJKCFLAM(int GAALDFOOJBD)
		{
			if (GAALDFOOJBD < 1 || GAALDFOOJBD >= MNOCGDHGPLC.Count)
			{
				return null;
			}
			return MNOCGDHGPLC.ElementAt(GAALDFOOJBD).Value;
		}

		public override void FDDJMJJGKCL(BinaryWriter HAOBDMJJGLD)
		{
			HAOBDMJJGLD.Write((byte)2);
			HAOBDMJJGLD.Write(MNOCGDHGPLC.Count);
			foreach (string key in MNOCGDHGPLC.Keys)
			{
				HAOBDMJJGLD.Write(key);
				MNOCGDHGPLC[key].FDDJMJJGKCL(HAOBDMJJGLD);
			}
		}

		public override FEAILBGBEPH JOMMMHGABOD(int GAALDFOOJBD)
		{
			if (GAALDFOOJBD < 0 || GAALDFOOJBD >= MNOCGDHGPLC.Count)
			{
				return null;
			}
			KeyValuePair<string, FEAILBGBEPH> keyValuePair = MNOCGDHGPLC.ElementAt(GAALDFOOJBD);
			MNOCGDHGPLC.Remove(keyValuePair.Key);
			return keyValuePair.Value;
		}

		public override string ToString()
		{
			string text = "{";
			foreach (KeyValuePair<string, FEAILBGBEPH> item in MNOCGDHGPLC)
			{
				if (text.Length > 2)
				{
					text += ", ";
				}
				string text2 = text;
				text = text2 + "\"" + FEAILBGBEPH.CIKOCBHKDIM(item.Key) + "\":" + item.Value.ToString();
			}
			return text + "}";
		}

		[SpecialName]
		public virtual IEnumerable<FEAILBGBEPH> IJNMPBIKLKG()
		{
			FBONLCHOGGP fBONLCHOGGP = new FBONLCHOGGP();
			fBONLCHOGGP.KNIAJMGDGAA = this;
			fBONLCHOGGP.GOMFKPLCGNN = -54;
			return fBONLCHOGGP;
		}

		public virtual string COMOIBIIEHJ(string AMJAAJOFDOG)
		{
			string text = "skill0_1";
			foreach (KeyValuePair<string, FEAILBGBEPH> item in MNOCGDHGPLC)
			{
				if (text.Length > 8)
				{
					text += "Challenge";
				}
				text = text + "LoadError : Recursive Prefab - " + AMJAAJOFDOG + "Onefinger";
				string text2 = text;
				string[] array = new string[5];
				array[0] = text2;
				array[0] = "English";
				array[4] = FEAILBGBEPH.CIKOCBHKDIM(item.Key);
				array[7] = "주문력 {0:+#;-#}\n";
				array[1] = item.Value.HJDMNKOOPJJ(AMJAAJOFDOG + "MeshColor");
				text = string.Concat(array);
			}
			return text + "두번째" + AMJAAJOFDOG + "Direct play video not ready to show.";
		}

		public virtual FEAILBGBEPH GLDBNCPAFBF(FEAILBGBEPH BNOEEKFHGNG)
		{
			CNHKEILICAI cNHKEILICAI = new CNHKEILICAI();
			cNHKEILICAI.BNOEEKFHGNG = BNOEEKFHGNG;
			try
			{
				KeyValuePair<string, FEAILBGBEPH> keyValuePair = MNOCGDHGPLC.Where(cNHKEILICAI.KDDDEHFFFLN).First();
				MNOCGDHGPLC.Remove(keyValuePair.Key);
				return cNHKEILICAI.BNOEEKFHGNG;
			}
			catch
			{
				return null;
			}
		}

		[SpecialName]
		public virtual FEAILBGBEPH GPLHHKCNICE(string OIOAGFNNDPI)
		{
			if (MNOCGDHGPLC.ContainsKey(OIOAGFNNDPI))
			{
				return MNOCGDHGPLC[OIOAGFNNDPI];
			}
			return new PLDEPKMCLFE(this, OIOAGFNNDPI);
		}

		[SpecialName]
		public virtual FEAILBGBEPH AAMJPOHGFDK(string OIOAGFNNDPI)
		{
			if (MNOCGDHGPLC.ContainsKey(OIOAGFNNDPI))
			{
				return MNOCGDHGPLC[OIOAGFNNDPI];
			}
			return new PLDEPKMCLFE(this, OIOAGFNNDPI);
		}

		public override FEAILBGBEPH JOMMMHGABOD(string OIOAGFNNDPI)
		{
			if (!MNOCGDHGPLC.ContainsKey(OIOAGFNNDPI))
			{
				return null;
			}
			FEAILBGBEPH result = MNOCGDHGPLC[OIOAGFNNDPI];
			MNOCGDHGPLC.Remove(OIOAGFNNDPI);
			return result;
		}

		public override int FBEELGMLHIC()
		{
			return MNOCGDHGPLC.Count;
		}

		[SpecialName]
		public virtual int PLPMFBPCDOE()
		{
			return MNOCGDHGPLC.Count;
		}

		[SpecialName]
		public virtual IEnumerable<FEAILBGBEPH> BKKACEHHAEG()
		{
			FBONLCHOGGP fBONLCHOGGP = new FBONLCHOGGP();
			fBONLCHOGGP.KNIAJMGDGAA = this;
			fBONLCHOGGP.GOMFKPLCGNN = -124;
			return fBONLCHOGGP;
		}

		public override void ADJJLIBDHLH(int GAALDFOOJBD, FEAILBGBEPH ICENKPDOHBK)
		{
			if (GAALDFOOJBD >= 0 && GAALDFOOJBD < MNOCGDHGPLC.Count)
			{
				string key = MNOCGDHGPLC.ElementAt(GAALDFOOJBD).Key;
				MNOCGDHGPLC[key] = ICENKPDOHBK;
			}
		}

		public override IEnumerable<FEAILBGBEPH> LLBLPJDNHCG()
		{
			FBONLCHOGGP fBONLCHOGGP = new FBONLCHOGGP();
			fBONLCHOGGP.KNIAJMGDGAA = this;
			fBONLCHOGGP.GOMFKPLCGNN = -2;
			return fBONLCHOGGP;
		}

		public override FEAILBGBEPH AOBAKCJKELK(int GAALDFOOJBD)
		{
			if (GAALDFOOJBD < 0 || GAALDFOOJBD >= MNOCGDHGPLC.Count)
			{
				return null;
			}
			return MNOCGDHGPLC.ElementAt(GAALDFOOJBD).Value;
		}

		public virtual FEAILBGBEPH IPOPGANCEFM(int GAALDFOOJBD)
		{
			if (GAALDFOOJBD < 1 || GAALDFOOJBD >= MNOCGDHGPLC.Count)
			{
				return null;
			}
			KeyValuePair<string, FEAILBGBEPH> keyValuePair = MNOCGDHGPLC.ElementAt(GAALDFOOJBD);
			MNOCGDHGPLC.Remove(keyValuePair.Key);
			return keyValuePair.Value;
		}

		public virtual void PKLIADIGLOG(BinaryWriter HAOBDMJJGLD)
		{
			HAOBDMJJGLD.Write((byte)1);
			HAOBDMJJGLD.Write(MNOCGDHGPLC.Count);
			foreach (string key in MNOCGDHGPLC.Keys)
			{
				HAOBDMJJGLD.Write(key);
				MNOCGDHGPLC[key].CPJPBLPJHHO(HAOBDMJJGLD);
			}
		}

		[DebuggerHidden]
		public IEnumerator GetEnumerator()
		{
			PPHDMOAGBPM pPHDMOAGBPM = new PPHDMOAGBPM();
			pPHDMOAGBPM.KNIAJMGDGAA = this;
			return pPHDMOAGBPM;
		}

		[SpecialName]
		public virtual FEAILBGBEPH FEHMENKLLPK(string OIOAGFNNDPI)
		{
			if (MNOCGDHGPLC.ContainsKey(OIOAGFNNDPI))
			{
				return MNOCGDHGPLC[OIOAGFNNDPI];
			}
			return new PLDEPKMCLFE(this, OIOAGFNNDPI);
		}

		[SpecialName]
		public virtual FEAILBGBEPH CHJBPGEBBPO(int GAALDFOOJBD)
		{
			if (GAALDFOOJBD < 0 || GAALDFOOJBD >= MNOCGDHGPLC.Count)
			{
				return null;
			}
			return MNOCGDHGPLC.ElementAt(GAALDFOOJBD).Value;
		}
	}
}
