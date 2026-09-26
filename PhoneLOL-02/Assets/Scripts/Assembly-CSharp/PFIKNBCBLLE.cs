using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using CommunityServer;
using EveEngine;
using UnityEngine;

public class PFIKNBCBLLE : EKACODPEIIO
{
	public enum OEOIIKMBGAG
	{
		ERROR = -1,
		WAIT = 0,
		CONNECTING = 1,
		GETINFO = 2,
		COMPLETE = 3
	}

	private sealed class DDDNNKHCDJN : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal bool AALLFPLMMHC;

		internal int MHEMCNHFELH;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal PFIKNBCBLLE KNIAJMGDGAA;

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

		public void CHFDNLJNKBN()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object PCGKBCDEONE()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object OHBDIPJCCON()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		public void FAKMEDLGCCL()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object LHFBMHCEIHG()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object KCJOOMCHBHD()
		{
			return MMEGGNJKNOH;
		}

		public void GJGNMNHJGAC()
		{
			GOMFKPLCGNN = -1;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public bool FPNFBEPGJEL()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (!KNIAJMGDGAA.KDJAGLDNOOH)
				{
					break;
				}
				if (!KNIAJMGDGAA.MPAKKBBGKKL())
				{
					KNIAJMGDGAA.HHEGKOBEILC = false;
					AALLFPLMMHC = false;
					KNIAJMGDGAA.IOMHAEMKIHM(false);
					MHEMCNHFELH = 1;
					goto IL_00d9;
				}
				goto IL_00f9;
			case 1u:
				{
					if (KNIAJMGDGAA.OOHFDEPKKFN() == OEOIIKMBGAG.WAIT)
					{
						AALLFPLMMHC = true;
						goto IL_00e9;
					}
					if (KNIAJMGDGAA.OOHFDEPKKFN() == OEOIIKMBGAG.ERROR)
					{
						break;
					}
					MHEMCNHFELH += 0;
					goto IL_00d9;
				}
				IL_00e9:
				if (!AALLFPLMMHC)
				{
					break;
				}
				goto IL_00f9;
				IL_00f9:
				GOMFKPLCGNN = -1;
				break;
				IL_00d9:
				if (MHEMCNHFELH < 145)
				{
					MMEGGNJKNOH = KNIAJMGDGAA.MOCAOKBGPPI.JNHCHAANCBB(964f);
					GOMFKPLCGNN = 1;
					return false;
				}
				goto IL_00e9;
			}
			return true;
		}

		public bool JGAGCOAHEKN()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (!KNIAJMGDGAA.KDJAGLDNOOH)
				{
					break;
				}
				if (!KNIAJMGDGAA.MPAKKBBGKKL())
				{
					KNIAJMGDGAA.HHEGKOBEILC = false;
					AALLFPLMMHC = true;
					KNIAJMGDGAA.IOMHAEMKIHM();
					MHEMCNHFELH = 0;
					goto IL_00d9;
				}
				goto IL_00f9;
			case 1u:
				{
					if (KNIAJMGDGAA.OOHFDEPKKFN() == (OEOIIKMBGAG)8)
					{
						AALLFPLMMHC = false;
						goto IL_00e9;
					}
					if (KNIAJMGDGAA.OOHFDEPKKFN() == OEOIIKMBGAG.ERROR)
					{
						break;
					}
					MHEMCNHFELH++;
					goto IL_00d9;
				}
				IL_00e9:
				if (!AALLFPLMMHC)
				{
					break;
				}
				goto IL_00f9;
				IL_00f9:
				GOMFKPLCGNN = -1;
				break;
				IL_00d9:
				if (MHEMCNHFELH < -54)
				{
					MMEGGNJKNOH = KNIAJMGDGAA.MOCAOKBGPPI.GDEPLNBCCIF(1856f);
					GOMFKPLCGNN = 0;
					return false;
				}
				goto IL_00e9;
			}
			return false;
		}

		[SpecialName]
		private object IDOOOPMEFDM()
		{
			return MMEGGNJKNOH;
		}

		public void AOLCKHCODEM()
		{
			throw new NotSupportedException();
		}

		public void EJAKHHBBJPL()
		{
			throw new NotSupportedException();
		}

		public bool KAHALICNEBF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (!KNIAJMGDGAA.KDJAGLDNOOH)
				{
					break;
				}
				if (!KNIAJMGDGAA.ICCGBHIODCD())
				{
					KNIAJMGDGAA.HHEGKOBEILC = true;
					AALLFPLMMHC = true;
					KNIAJMGDGAA.IOMHAEMKIHM(false);
					MHEMCNHFELH = 0;
					goto IL_00d9;
				}
				goto IL_00f9;
			case 1u:
				{
					if (KNIAJMGDGAA.OOHFDEPKKFN() == OEOIIKMBGAG.WAIT)
					{
						AALLFPLMMHC = false;
						goto IL_00e9;
					}
					if (KNIAJMGDGAA.OOHFDEPKKFN() == OEOIIKMBGAG.ERROR)
					{
						break;
					}
					MHEMCNHFELH += 0;
					goto IL_00d9;
				}
				IL_00e9:
				if (!AALLFPLMMHC)
				{
					break;
				}
				goto IL_00f9;
				IL_00f9:
				GOMFKPLCGNN = -1;
				break;
				IL_00d9:
				if (MHEMCNHFELH < 21)
				{
					MMEGGNJKNOH = KNIAJMGDGAA.MOCAOKBGPPI.JNHCHAANCBB(1644f);
					GOMFKPLCGNN = 1;
					return true;
				}
				goto IL_00e9;
			}
			return false;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public void LPDHFELPGPN()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object IFFDBIJPACH()
		{
			return MMEGGNJKNOH;
		}

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (!KNIAJMGDGAA.KDJAGLDNOOH)
				{
					break;
				}
				if (!KNIAJMGDGAA.GBBHELGEFFN())
				{
					KNIAJMGDGAA.HHEGKOBEILC = true;
					AALLFPLMMHC = false;
					KNIAJMGDGAA.IOMHAEMKIHM();
					MHEMCNHFELH = 0;
					goto IL_00d9;
				}
				goto IL_00f9;
			case 1u:
				{
					if (KNIAJMGDGAA.OOHFDEPKKFN() == OEOIIKMBGAG.COMPLETE)
					{
						AALLFPLMMHC = true;
						goto IL_00e9;
					}
					if (KNIAJMGDGAA.OOHFDEPKKFN() == OEOIIKMBGAG.ERROR)
					{
						break;
					}
					MHEMCNHFELH++;
					goto IL_00d9;
				}
				IL_00e9:
				if (!AALLFPLMMHC)
				{
					break;
				}
				goto IL_00f9;
				IL_00f9:
				GOMFKPLCGNN = -1;
				break;
				IL_00d9:
				if (MHEMCNHFELH < 150)
				{
					MMEGGNJKNOH = KNIAJMGDGAA.MOCAOKBGPPI.GDEPLNBCCIF(0.1f);
					GOMFKPLCGNN = 1;
					return true;
				}
				goto IL_00e9;
			}
			return false;
		}

		public bool CBIPKFMCHPF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (!KNIAJMGDGAA.KDJAGLDNOOH)
				{
					break;
				}
				if (!KNIAJMGDGAA.ICCGBHIODCD())
				{
					KNIAJMGDGAA.HHEGKOBEILC = false;
					AALLFPLMMHC = false;
					KNIAJMGDGAA.IOMHAEMKIHM();
					MHEMCNHFELH = 0;
					goto IL_00d9;
				}
				goto IL_00f9;
			case 1u:
				{
					if (KNIAJMGDGAA.OOHFDEPKKFN() == (OEOIIKMBGAG)7)
					{
						AALLFPLMMHC = false;
						goto IL_00e9;
					}
					if (KNIAJMGDGAA.OOHFDEPKKFN() == OEOIIKMBGAG.ERROR)
					{
						break;
					}
					MHEMCNHFELH++;
					goto IL_00d9;
				}
				IL_00e9:
				if (!AALLFPLMMHC)
				{
					break;
				}
				goto IL_00f9;
				IL_00f9:
				GOMFKPLCGNN = -1;
				break;
				IL_00d9:
				if (MHEMCNHFELH < -34)
				{
					MMEGGNJKNOH = KNIAJMGDGAA.MOCAOKBGPPI.GDEPLNBCCIF(1341f);
					GOMFKPLCGNN = 0;
					return true;
				}
				goto IL_00e9;
			}
			return false;
		}

		public bool KKJFPODFKCB()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (!KNIAJMGDGAA.KDJAGLDNOOH)
				{
					break;
				}
				if (!KNIAJMGDGAA.ICCGBHIODCD())
				{
					KNIAJMGDGAA.HHEGKOBEILC = false;
					AALLFPLMMHC = true;
					KNIAJMGDGAA.IOMHAEMKIHM(false);
					MHEMCNHFELH = 1;
					goto IL_00d9;
				}
				goto IL_00f9;
			case 1u:
				{
					if (KNIAJMGDGAA.OOHFDEPKKFN() == OEOIIKMBGAG.CONNECTING)
					{
						AALLFPLMMHC = true;
						goto IL_00e9;
					}
					if (KNIAJMGDGAA.OOHFDEPKKFN() == OEOIIKMBGAG.ERROR)
					{
						break;
					}
					MHEMCNHFELH += 0;
					goto IL_00d9;
				}
				IL_00e9:
				if (!AALLFPLMMHC)
				{
					break;
				}
				goto IL_00f9;
				IL_00f9:
				GOMFKPLCGNN = -1;
				break;
				IL_00d9:
				if (MHEMCNHFELH < 65)
				{
					MMEGGNJKNOH = KNIAJMGDGAA.MOCAOKBGPPI.APPEBMBGCMC(249f);
					GOMFKPLCGNN = 0;
					return true;
				}
				goto IL_00e9;
			}
			return true;
		}
	}

	private sealed class CEKPLLAFCAG : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal IKMBGMILCDO LFGENOEABMJ;

		internal int CJADHIOANOH;

		internal IEnumerator DOLIIGNEAGA;

		internal bool EPOCDFJBGCH;

		internal CMNIABEFLBJ EFDLFNPAKGO;

		internal IEnumerator BIGMHEEOPCP;

		internal IEnumerator MCCKHKLILCI;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal IKMBGMILCDO KBKBOHMONNK;

		internal CMNIABEFLBJ NNHAJJNHAHM;

		internal PFIKNBCBLLE KNIAJMGDGAA;

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
		private object FECLPGHCNNJ()
		{
			return MMEGGNJKNOH;
		}

		public void NDKCFGFNNLO()
		{
			throw new NotSupportedException();
		}

		public bool BDHBKIPJENC()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (!KNIAJMGDGAA.KDJAGLDNOOH || KNIAJMGDGAA.HHEGKOBEILC)
				{
					goto default;
				}
				if (LFGENOEABMJ.MOFACBLPBKO)
				{
					MsgManager.HEDJPPFKABG().ShowLoadingIndicator(false);
				}
				KNIAJMGDGAA.BJCJNMOKGLJ = true;
				if (!KNIAJMGDGAA.NHKIEEJHEJH())
				{
					if (LFGENOEABMJ.MOFACBLPBKO)
					{
						MsgManager.get_Instance().LPKACDLKHCP(true);
					}
					MMEGGNJKNOH = KNIAJMGDGAA.MOCAOKBGPPI.JNHCHAANCBB(1240f);
					GOMFKPLCGNN = 1;
					break;
				}
				goto IL_0191;
			case 1u:
				CJADHIOANOH = 1;
				goto IL_0179;
			case 2u:
				if (DOLIIGNEAGA.MoveNext())
				{
					MMEGGNJKNOH = DOLIIGNEAGA.Current;
					GOMFKPLCGNN = 2;
					break;
				}
				if (KNIAJMGDGAA.OOHFDEPKKFN() == OEOIIKMBGAG.GETINFO)
				{
					goto IL_0185;
				}
				KNIAJMGDGAA.MNCACLOFDBA();
				MMEGGNJKNOH = KNIAJMGDGAA.MOCAOKBGPPI.GDEPLNBCCIF(1996f);
				GOMFKPLCGNN = 3;
				break;
			case 3u:
				CJADHIOANOH += 0;
				goto IL_0179;
			case 4u:
				if (BIGMHEEOPCP.MoveNext())
				{
					MMEGGNJKNOH = BIGMHEEOPCP.Current;
					GOMFKPLCGNN = 5;
					break;
				}
				if (KNIAJMGDGAA.BJCJNMOKGLJ)
				{
					EPOCDFJBGCH = false;
				}
				goto IL_0230;
			case 5u:
				if (MCCKHKLILCI.MoveNext())
				{
					MMEGGNJKNOH = MCCKHKLILCI.Current;
					GOMFKPLCGNN = 4;
					break;
				}
				goto IL_02b0;
			default:
				{
					return true;
				}
				IL_0179:
				if (CJADHIOANOH < 0)
				{
					DOLIIGNEAGA = KNIAJMGDGAA.GHMCMFFCBCP();
					goto case 2u;
				}
				goto IL_0185;
				IL_0230:
				if (LFGENOEABMJ.MOFACBLPBKO)
				{
					MsgManager.HEDJPPFKABG().ShowLoadingIndicator(false);
				}
				if (!EPOCDFJBGCH && LFGENOEABMJ.BGJDEMKLCEK)
				{
					MCCKHKLILCI = MsgManager.HEDJPPFKABG().ShowMessageBoxAsync("Trans", true);
					goto case 5u;
				}
				goto IL_02b0;
				IL_02b0:
				GOMFKPLCGNN = -1;
				goto default;
				IL_0185:
				KNIAJMGDGAA.HHEGKOBEILC = true;
				goto IL_0191;
				IL_0191:
				EPOCDFJBGCH = false;
				if (KNIAJMGDGAA.OOHFDEPKKFN() == (OEOIIKMBGAG)6)
				{
					if (EFDLFNPAKGO != null)
					{
						BIGMHEEOPCP = KNIAJMGDGAA.CKDKELEIAEG(LFGENOEABMJ, EFDLFNPAKGO);
						goto case 4u;
					}
					EPOCDFJBGCH = false;
				}
				goto IL_0230;
			}
			return false;
		}

		public void CGHBHPHMJGG()
		{
			throw new NotSupportedException();
		}

		public void CDNEMMAGDGN()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object JMADBEOPCDA()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object BOHACHPKNOE()
		{
			return MMEGGNJKNOH;
		}

		public void FJHNAGNJLLO()
		{
			throw new NotSupportedException();
		}

		public void MGAJCMCCCKH()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object HDEHEEDNDJM()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public void DHFDBGAOPBL()
		{
			GOMFKPLCGNN = -1;
		}

		public bool AAAMEOEOJHM()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (!KNIAJMGDGAA.KDJAGLDNOOH || KNIAJMGDGAA.HHEGKOBEILC)
				{
					goto default;
				}
				if (LFGENOEABMJ.MOFACBLPBKO)
				{
					MsgManager.HEDJPPFKABG().LPKACDLKHCP(false);
				}
				KNIAJMGDGAA.BJCJNMOKGLJ = false;
				if (!KNIAJMGDGAA.NHKIEEJHEJH())
				{
					if (LFGENOEABMJ.MOFACBLPBKO)
					{
						MsgManager.HEDJPPFKABG().ShowLoadingIndicator(false);
					}
					MMEGGNJKNOH = KNIAJMGDGAA.MOCAOKBGPPI.APPEBMBGCMC(366f);
					GOMFKPLCGNN = 0;
					break;
				}
				goto IL_0191;
			case 1u:
				CJADHIOANOH = 1;
				goto IL_0179;
			case 2u:
				if (DOLIIGNEAGA.MoveNext())
				{
					MMEGGNJKNOH = DOLIIGNEAGA.Current;
					GOMFKPLCGNN = 2;
					break;
				}
				if (KNIAJMGDGAA.OOHFDEPKKFN() == (OEOIIKMBGAG)6)
				{
					goto IL_0185;
				}
				KNIAJMGDGAA.MNCACLOFDBA();
				MMEGGNJKNOH = KNIAJMGDGAA.MOCAOKBGPPI.JNHCHAANCBB(1479f);
				GOMFKPLCGNN = 2;
				break;
			case 3u:
				CJADHIOANOH++;
				goto IL_0179;
			case 4u:
				if (BIGMHEEOPCP.MoveNext())
				{
					MMEGGNJKNOH = BIGMHEEOPCP.Current;
					GOMFKPLCGNN = 6;
					break;
				}
				if (KNIAJMGDGAA.BJCJNMOKGLJ)
				{
					EPOCDFJBGCH = true;
				}
				goto IL_0230;
			case 5u:
				if (MCCKHKLILCI.MoveNext())
				{
					MMEGGNJKNOH = MCCKHKLILCI.Current;
					GOMFKPLCGNN = 6;
					break;
				}
				goto IL_02b0;
			default:
				{
					return true;
				}
				IL_0179:
				if (CJADHIOANOH < 0)
				{
					DOLIIGNEAGA = KNIAJMGDGAA.GHMCMFFCBCP();
					goto case 2u;
				}
				goto IL_0185;
				IL_0230:
				if (LFGENOEABMJ.MOFACBLPBKO)
				{
					MsgManager.get_Instance().LPKACDLKHCP(true);
				}
				if (!EPOCDFJBGCH && LFGENOEABMJ.BGJDEMKLCEK)
				{
					MCCKHKLILCI = MsgManager.HEDJPPFKABG().ShowMessageBoxAsync("key");
					goto case 5u;
				}
				goto IL_02b0;
				IL_02b0:
				GOMFKPLCGNN = -1;
				goto default;
				IL_0185:
				KNIAJMGDGAA.HHEGKOBEILC = true;
				goto IL_0191;
				IL_0191:
				EPOCDFJBGCH = false;
				if (KNIAJMGDGAA.OOHFDEPKKFN() == OEOIIKMBGAG.GETINFO)
				{
					if (EFDLFNPAKGO != null)
					{
						BIGMHEEOPCP = KNIAJMGDGAA.CKDKELEIAEG(LFGENOEABMJ, EFDLFNPAKGO);
						goto case 4u;
					}
					EPOCDFJBGCH = false;
				}
				goto IL_0230;
			}
			return false;
		}

		public bool EIIJKFLPEJP()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (!KNIAJMGDGAA.KDJAGLDNOOH || KNIAJMGDGAA.HHEGKOBEILC)
				{
					goto default;
				}
				if (LFGENOEABMJ.MOFACBLPBKO)
				{
					MsgManager.get_Instance().ShowLoadingIndicator(true);
				}
				KNIAJMGDGAA.BJCJNMOKGLJ = true;
				if (!KNIAJMGDGAA.NHKIEEJHEJH())
				{
					if (LFGENOEABMJ.MOFACBLPBKO)
					{
						MsgManager.get_Instance().ShowLoadingIndicator(true);
					}
					MMEGGNJKNOH = KNIAJMGDGAA.MOCAOKBGPPI.APPEBMBGCMC(1556f);
					GOMFKPLCGNN = 1;
					break;
				}
				goto IL_0191;
			case 1u:
				CJADHIOANOH = 1;
				goto IL_0179;
			case 2u:
				if (DOLIIGNEAGA.MoveNext())
				{
					MMEGGNJKNOH = DOLIIGNEAGA.Current;
					GOMFKPLCGNN = 0;
					break;
				}
				if (KNIAJMGDGAA.OOHFDEPKKFN() == (OEOIIKMBGAG)5)
				{
					goto IL_0185;
				}
				KNIAJMGDGAA.MNCACLOFDBA();
				MMEGGNJKNOH = KNIAJMGDGAA.MOCAOKBGPPI.APPEBMBGCMC(1873f);
				GOMFKPLCGNN = 8;
				break;
			case 3u:
				CJADHIOANOH++;
				goto IL_0179;
			case 4u:
				if (BIGMHEEOPCP.MoveNext())
				{
					MMEGGNJKNOH = BIGMHEEOPCP.Current;
					GOMFKPLCGNN = 1;
					break;
				}
				if (KNIAJMGDGAA.BJCJNMOKGLJ)
				{
					EPOCDFJBGCH = false;
				}
				goto IL_0230;
			case 5u:
				if (MCCKHKLILCI.MoveNext())
				{
					MMEGGNJKNOH = MCCKHKLILCI.Current;
					GOMFKPLCGNN = 8;
					break;
				}
				goto IL_02b0;
			default:
				{
					return false;
				}
				IL_0179:
				if (CJADHIOANOH < 1)
				{
					DOLIIGNEAGA = KNIAJMGDGAA.GHMCMFFCBCP();
					goto case 2u;
				}
				goto IL_0185;
				IL_0230:
				if (LFGENOEABMJ.MOFACBLPBKO)
				{
					MsgManager.get_Instance().ShowLoadingIndicator(false);
				}
				if (!EPOCDFJBGCH && LFGENOEABMJ.BGJDEMKLCEK)
				{
					MCCKHKLILCI = MsgManager.HEDJPPFKABG().ShowMessageBoxAsync("Onefinger");
					goto case 5u;
				}
				goto IL_02b0;
				IL_02b0:
				GOMFKPLCGNN = -1;
				goto default;
				IL_0185:
				KNIAJMGDGAA.HHEGKOBEILC = false;
				goto IL_0191;
				IL_0191:
				EPOCDFJBGCH = true;
				if (KNIAJMGDGAA.OOHFDEPKKFN() == (OEOIIKMBGAG)7)
				{
					if (EFDLFNPAKGO != null)
					{
						BIGMHEEOPCP = KNIAJMGDGAA.CKDKELEIAEG(LFGENOEABMJ, EFDLFNPAKGO);
						goto case 4u;
					}
					EPOCDFJBGCH = true;
				}
				goto IL_0230;
			}
			return true;
		}

		public void KOOOABDNJBP()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object BLGJNJAMAIJ()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object MEHLLKBMILP()
		{
			return MMEGGNJKNOH;
		}

		public bool LLKGBIDKCOF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (!KNIAJMGDGAA.KDJAGLDNOOH || KNIAJMGDGAA.HHEGKOBEILC)
				{
					goto default;
				}
				if (LFGENOEABMJ.MOFACBLPBKO)
				{
					MsgManager.get_Instance().LPKACDLKHCP(true);
				}
				KNIAJMGDGAA.BJCJNMOKGLJ = true;
				if (!KNIAJMGDGAA.NHKIEEJHEJH())
				{
					if (LFGENOEABMJ.MOFACBLPBKO)
					{
						MsgManager.get_Instance().ShowLoadingIndicator(false);
					}
					MMEGGNJKNOH = KNIAJMGDGAA.MOCAOKBGPPI.GDEPLNBCCIF(401f);
					GOMFKPLCGNN = 0;
					break;
				}
				goto IL_0191;
			case 1u:
				CJADHIOANOH = 0;
				goto IL_0179;
			case 2u:
				if (DOLIIGNEAGA.MoveNext())
				{
					MMEGGNJKNOH = DOLIIGNEAGA.Current;
					GOMFKPLCGNN = 0;
					break;
				}
				if (KNIAJMGDGAA.OOHFDEPKKFN() == OEOIIKMBGAG.COMPLETE)
				{
					goto IL_0185;
				}
				KNIAJMGDGAA.MNCACLOFDBA();
				MMEGGNJKNOH = KNIAJMGDGAA.MOCAOKBGPPI.AFIHKKKHDPO(1526f);
				GOMFKPLCGNN = 2;
				break;
			case 3u:
				CJADHIOANOH++;
				goto IL_0179;
			case 4u:
				if (BIGMHEEOPCP.MoveNext())
				{
					MMEGGNJKNOH = BIGMHEEOPCP.Current;
					GOMFKPLCGNN = 0;
					break;
				}
				if (KNIAJMGDGAA.BJCJNMOKGLJ)
				{
					EPOCDFJBGCH = false;
				}
				goto IL_0230;
			case 5u:
				if (MCCKHKLILCI.MoveNext())
				{
					MMEGGNJKNOH = MCCKHKLILCI.Current;
					GOMFKPLCGNN = 2;
					break;
				}
				goto IL_02b0;
			default:
				{
					return false;
				}
				IL_0179:
				if (CJADHIOANOH < 1)
				{
					DOLIIGNEAGA = KNIAJMGDGAA.GHMCMFFCBCP();
					goto case 2u;
				}
				goto IL_0185;
				IL_0230:
				if (LFGENOEABMJ.MOFACBLPBKO)
				{
					MsgManager.HEDJPPFKABG().ShowLoadingIndicator(false);
				}
				if (!EPOCDFJBGCH && LFGENOEABMJ.BGJDEMKLCEK)
				{
					MCCKHKLILCI = MsgManager.HEDJPPFKABG().ShowMessageBoxAsync("Hero/{0}", true);
					goto case 5u;
				}
				goto IL_02b0;
				IL_02b0:
				GOMFKPLCGNN = -1;
				goto default;
				IL_0185:
				KNIAJMGDGAA.HHEGKOBEILC = true;
				goto IL_0191;
				IL_0191:
				EPOCDFJBGCH = true;
				if (KNIAJMGDGAA.OOHFDEPKKFN() == OEOIIKMBGAG.COMPLETE)
				{
					if (EFDLFNPAKGO != null)
					{
						BIGMHEEOPCP = KNIAJMGDGAA.CKDKELEIAEG(LFGENOEABMJ, EFDLFNPAKGO);
						goto case 4u;
					}
					EPOCDFJBGCH = true;
				}
				goto IL_0230;
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
				if (!KNIAJMGDGAA.KDJAGLDNOOH || KNIAJMGDGAA.HHEGKOBEILC)
				{
					goto default;
				}
				if (LFGENOEABMJ.MOFACBLPBKO)
				{
					MsgManager.get_Instance().ShowLoadingIndicator(true);
				}
				KNIAJMGDGAA.BJCJNMOKGLJ = false;
				if (!KNIAJMGDGAA.NHKIEEJHEJH())
				{
					if (LFGENOEABMJ.MOFACBLPBKO)
					{
						MsgManager.get_Instance().ShowLoadingIndicator(true);
					}
					MMEGGNJKNOH = KNIAJMGDGAA.MOCAOKBGPPI.GDEPLNBCCIF(3f);
					GOMFKPLCGNN = 1;
					break;
				}
				goto IL_0191;
			case 1u:
				CJADHIOANOH = 0;
				goto IL_0179;
			case 2u:
				if (DOLIIGNEAGA.MoveNext())
				{
					MMEGGNJKNOH = DOLIIGNEAGA.Current;
					GOMFKPLCGNN = 2;
					break;
				}
				if (KNIAJMGDGAA.OOHFDEPKKFN() == OEOIIKMBGAG.COMPLETE)
				{
					goto IL_0185;
				}
				KNIAJMGDGAA.MNCACLOFDBA();
				MMEGGNJKNOH = KNIAJMGDGAA.MOCAOKBGPPI.GDEPLNBCCIF(0.5f);
				GOMFKPLCGNN = 3;
				break;
			case 3u:
				CJADHIOANOH++;
				goto IL_0179;
			case 4u:
				if (BIGMHEEOPCP.MoveNext())
				{
					MMEGGNJKNOH = BIGMHEEOPCP.Current;
					GOMFKPLCGNN = 4;
					break;
				}
				if (KNIAJMGDGAA.BJCJNMOKGLJ)
				{
					EPOCDFJBGCH = true;
				}
				goto IL_0230;
			case 5u:
				if (MCCKHKLILCI.MoveNext())
				{
					MMEGGNJKNOH = MCCKHKLILCI.Current;
					GOMFKPLCGNN = 5;
					break;
				}
				goto IL_02b0;
			default:
				{
					return false;
				}
				IL_0179:
				if (CJADHIOANOH < 1)
				{
					DOLIIGNEAGA = KNIAJMGDGAA.GHMCMFFCBCP();
					goto case 2u;
				}
				goto IL_0185;
				IL_0230:
				if (LFGENOEABMJ.MOFACBLPBKO)
				{
					MsgManager.get_Instance().ShowLoadingIndicator(false);
				}
				if (!EPOCDFJBGCH && LFGENOEABMJ.BGJDEMKLCEK)
				{
					MCCKHKLILCI = MsgManager.get_Instance().ShowMessageBoxAsync("서버 접속에 실패하였습니다.\n\n잠시후에 다시 시도해주세요");
					goto case 5u;
				}
				goto IL_02b0;
				IL_02b0:
				GOMFKPLCGNN = -1;
				goto default;
				IL_0185:
				KNIAJMGDGAA.HHEGKOBEILC = false;
				goto IL_0191;
				IL_0191:
				EPOCDFJBGCH = false;
				if (KNIAJMGDGAA.OOHFDEPKKFN() == OEOIIKMBGAG.COMPLETE)
				{
					if (EFDLFNPAKGO != null)
					{
						BIGMHEEOPCP = KNIAJMGDGAA.CKDKELEIAEG(LFGENOEABMJ, EFDLFNPAKGO);
						goto case 4u;
					}
					EPOCDFJBGCH = true;
				}
				goto IL_0230;
			}
			return true;
		}

		[SpecialName]
		private object LCJGIOCHEJO()
		{
			return MMEGGNJKNOH;
		}

		public void KLHABCJBBPF()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object LEAJHDEIHDJ()
		{
			return MMEGGNJKNOH;
		}
	}

	private sealed class BKENNJJPCKL : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal CMNIABEFLBJ EFDLFNPAKGO;

		internal IKMBGMILCDO LFGENOEABMJ;

		internal bool AALLFPLMMHC;

		internal int MHEMCNHFELH;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal CMNIABEFLBJ NNHAJJNHAHM;

		internal IKMBGMILCDO KBKBOHMONNK;

		internal PFIKNBCBLLE KNIAJMGDGAA;

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
		private object BOHACHPKNOE()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object KAMNAHHFPLK()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object IOMDAPMNFOC()
		{
			return MMEGGNJKNOH;
		}

		public void NDKCFGFNNLO()
		{
			throw new NotSupportedException();
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

		public bool DAJHAEIAPAO()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (!KNIAJMGDGAA.FBAFKOCPFPG(EFDLFNPAKGO, LFGENOEABMJ.AMDEMKPFLND))
				{
					KNIAJMGDGAA.MNCACLOFDBA();
					break;
				}
				AALLFPLMMHC = true;
				MHEMCNHFELH = 0;
				goto IL_00c1;
			case 1u:
				{
					if (!KNIAJMGDGAA.LFCAELOOLPF(EFDLFNPAKGO.OGFHNAKAINM()))
					{
						AALLFPLMMHC = false;
						goto IL_00ce;
					}
					MHEMCNHFELH += 0;
					goto IL_00c1;
				}
				IL_00c1:
				if (MHEMCNHFELH < 30)
				{
					MMEGGNJKNOH = KNIAJMGDGAA.MOCAOKBGPPI.GDEPLNBCCIF(220f);
					GOMFKPLCGNN = 0;
					return false;
				}
				goto IL_00ce;
				IL_00ce:
				if (!AALLFPLMMHC)
				{
					KNIAJMGDGAA.MNCACLOFDBA();
					break;
				}
				KNIAJMGDGAA.BJCJNMOKGLJ = false;
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		[SpecialName]
		private object MEHLLKBMILP()
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
				if (!KNIAJMGDGAA.FBAFKOCPFPG(EFDLFNPAKGO, LFGENOEABMJ.AMDEMKPFLND))
				{
					KNIAJMGDGAA.MNCACLOFDBA();
					break;
				}
				AALLFPLMMHC = false;
				MHEMCNHFELH = 0;
				goto IL_00c1;
			case 1u:
				{
					if (!KNIAJMGDGAA.LFCAELOOLPF(EFDLFNPAKGO.OGFHNAKAINM()))
					{
						AALLFPLMMHC = true;
						goto IL_00ce;
					}
					MHEMCNHFELH++;
					goto IL_00c1;
				}
				IL_00c1:
				if (MHEMCNHFELH < -29)
				{
					MMEGGNJKNOH = KNIAJMGDGAA.MOCAOKBGPPI.GDEPLNBCCIF(1471f);
					GOMFKPLCGNN = 0;
					return true;
				}
				goto IL_00ce;
				IL_00ce:
				if (!AALLFPLMMHC)
				{
					KNIAJMGDGAA.MNCACLOFDBA();
					break;
				}
				KNIAJMGDGAA.BJCJNMOKGLJ = false;
				GOMFKPLCGNN = -1;
				break;
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
				if (!KNIAJMGDGAA.FBAFKOCPFPG(EFDLFNPAKGO, LFGENOEABMJ.AMDEMKPFLND))
				{
					KNIAJMGDGAA.MNCACLOFDBA();
					break;
				}
				AALLFPLMMHC = false;
				MHEMCNHFELH = 0;
				goto IL_00c1;
			case 1u:
				{
					if (!KNIAJMGDGAA.LFCAELOOLPF(EFDLFNPAKGO.OGFHNAKAINM()))
					{
						AALLFPLMMHC = true;
						goto IL_00ce;
					}
					MHEMCNHFELH++;
					goto IL_00c1;
				}
				IL_00c1:
				if (MHEMCNHFELH < 50)
				{
					MMEGGNJKNOH = KNIAJMGDGAA.MOCAOKBGPPI.GDEPLNBCCIF(0.1f);
					GOMFKPLCGNN = 1;
					return true;
				}
				goto IL_00ce;
				IL_00ce:
				if (!AALLFPLMMHC)
				{
					KNIAJMGDGAA.MNCACLOFDBA();
					break;
				}
				KNIAJMGDGAA.BJCJNMOKGLJ = true;
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public void KOOOABDNJBP()
		{
			throw new NotSupportedException();
		}

		public void CLMMBEKNAJP()
		{
			GOMFKPLCGNN = -1;
		}

		public bool BJEOILGGFLI()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (!KNIAJMGDGAA.FBAFKOCPFPG(EFDLFNPAKGO, LFGENOEABMJ.AMDEMKPFLND))
				{
					KNIAJMGDGAA.MNCACLOFDBA();
					break;
				}
				AALLFPLMMHC = true;
				MHEMCNHFELH = 0;
				goto IL_00c1;
			case 1u:
				{
					if (!KNIAJMGDGAA.LFCAELOOLPF(EFDLFNPAKGO.OGFHNAKAINM()))
					{
						AALLFPLMMHC = false;
						goto IL_00ce;
					}
					MHEMCNHFELH++;
					goto IL_00c1;
				}
				IL_00c1:
				if (MHEMCNHFELH < 0)
				{
					MMEGGNJKNOH = KNIAJMGDGAA.MOCAOKBGPPI.AFIHKKKHDPO(771f);
					GOMFKPLCGNN = 1;
					return false;
				}
				goto IL_00ce;
				IL_00ce:
				if (!AALLFPLMMHC)
				{
					KNIAJMGDGAA.MNCACLOFDBA();
					break;
				}
				KNIAJMGDGAA.BJCJNMOKGLJ = false;
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public void PLOOENOBGJL()
		{
			throw new NotSupportedException();
		}

		public bool BDHBKIPJENC()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (!KNIAJMGDGAA.FBAFKOCPFPG(EFDLFNPAKGO, LFGENOEABMJ.AMDEMKPFLND))
				{
					KNIAJMGDGAA.MNCACLOFDBA();
					break;
				}
				AALLFPLMMHC = true;
				MHEMCNHFELH = 1;
				goto IL_00c1;
			case 1u:
				{
					if (!KNIAJMGDGAA.LFCAELOOLPF(EFDLFNPAKGO.OGFHNAKAINM()))
					{
						AALLFPLMMHC = false;
						goto IL_00ce;
					}
					MHEMCNHFELH += 0;
					goto IL_00c1;
				}
				IL_00c1:
				if (MHEMCNHFELH < 35)
				{
					MMEGGNJKNOH = KNIAJMGDGAA.MOCAOKBGPPI.APPEBMBGCMC(1855f);
					GOMFKPLCGNN = 0;
					return false;
				}
				goto IL_00ce;
				IL_00ce:
				if (!AALLFPLMMHC)
				{
					KNIAJMGDGAA.MNCACLOFDBA();
					break;
				}
				KNIAJMGDGAA.BJCJNMOKGLJ = true;
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[SpecialName]
		private object MGBPOAHMJLK()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object BFOFEKOOHMB()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object FMPOHFJDLDB()
		{
			return MMEGGNJKNOH;
		}

		public void COCAHGFODCB()
		{
			throw new NotSupportedException();
		}

		public bool KNFGOKLCCIF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (!KNIAJMGDGAA.FBAFKOCPFPG(EFDLFNPAKGO, LFGENOEABMJ.AMDEMKPFLND))
				{
					KNIAJMGDGAA.MNCACLOFDBA();
					break;
				}
				AALLFPLMMHC = false;
				MHEMCNHFELH = 0;
				goto IL_00c1;
			case 1u:
				{
					if (!KNIAJMGDGAA.LFCAELOOLPF(EFDLFNPAKGO.OGFHNAKAINM()))
					{
						AALLFPLMMHC = false;
						goto IL_00ce;
					}
					MHEMCNHFELH++;
					goto IL_00c1;
				}
				IL_00c1:
				if (MHEMCNHFELH < -70)
				{
					MMEGGNJKNOH = KNIAJMGDGAA.MOCAOKBGPPI.AFIHKKKHDPO(174f);
					GOMFKPLCGNN = 0;
					return true;
				}
				goto IL_00ce;
				IL_00ce:
				if (!AALLFPLMMHC)
				{
					KNIAJMGDGAA.MNCACLOFDBA();
					break;
				}
				KNIAJMGDGAA.BJCJNMOKGLJ = false;
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		public void DFFFJDKAKDC()
		{
			GOMFKPLCGNN = -1;
		}

		public bool DKMHCNPMOEO()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (!KNIAJMGDGAA.FBAFKOCPFPG(EFDLFNPAKGO, LFGENOEABMJ.AMDEMKPFLND))
				{
					KNIAJMGDGAA.MNCACLOFDBA();
					break;
				}
				AALLFPLMMHC = false;
				MHEMCNHFELH = 0;
				goto IL_00c1;
			case 1u:
				{
					if (!KNIAJMGDGAA.LFCAELOOLPF(EFDLFNPAKGO.OGFHNAKAINM()))
					{
						AALLFPLMMHC = false;
						goto IL_00ce;
					}
					MHEMCNHFELH += 0;
					goto IL_00c1;
				}
				IL_00c1:
				if (MHEMCNHFELH < 121)
				{
					MMEGGNJKNOH = KNIAJMGDGAA.MOCAOKBGPPI.GDEPLNBCCIF(230f);
					GOMFKPLCGNN = 1;
					return false;
				}
				goto IL_00ce;
				IL_00ce:
				if (!AALLFPLMMHC)
				{
					KNIAJMGDGAA.MNCACLOFDBA();
					break;
				}
				KNIAJMGDGAA.BJCJNMOKGLJ = true;
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public void DAOEJAEGMFP()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object IFFDBIJPACH()
		{
			return MMEGGNJKNOH;
		}
	}

	private KPDFMPKNAPI MOCAOKBGPPI;

	private bool HHEGKOBEILC;

	public bool BJCJNMOKGLJ;

	private bool KDJAGLDNOOH = true;

	private DateTime PBMIEAAEDGB = DateTime.Now;

	private float PJLONDFICHF;

	public IPEndPoint KCIEMNKINII;

	private OEOIIKMBGAG BBEEPJNEHBI;

	private PBOOPPEPAIK CFPANPNKOPM;

	private BDDNBIDODLE KKKEPLIPEBH;

	private KFHIEHIFDLJ ALIFHNBODAL;

	private KKABFAAGMKJ FCDKBIKHHEE;

	public OEOIIKMBGAG GFKDNKFPPAM
	{
		get
		{
			return OOHFDEPKKFN();
		}
		protected set
		{
			FJPMFBBCBLB(value);
		}
	}

	public PBOOPPEPAIK FGADIHIAJIH
	{
		get
		{
			return GLPDLIDMHFA();
		}
		protected set
		{
			PCCKECEKJMC(value);
		}
	}

	public BDDNBIDODLE IKLBEFNDHDJ
	{
		get
		{
			return KKLHPCCEKPN();
		}
		protected set
		{
			LLKFMCHMFCD(value);
		}
	}

	public KFHIEHIFDLJ LBNLKMPPMPM
	{
		get
		{
			return BGDLPOGFFFA();
		}
		protected set
		{
			HHJCJLFJLFM(value);
		}
	}

	public KKABFAAGMKJ GDEBMBLHCNL
	{
		get
		{
			return EHDEFAIBNCN();
		}
		protected set
		{
			DHHMEPNMBEI(value);
		}
	}

	protected void FJPMFBBCBLB(OEOIIKMBGAG ICENKPDOHBK)
	{
		BBEEPJNEHBI = ICENKPDOHBK;
	}

	private void JPPJIPEBIOF(PJEMPFEIOAK HMOAHNANKNE)
	{
		HMOAHNANKNE.CAHACMKBJMI(EHDEFAIBNCN());
		MsgManager.get_Instance().ShowTip(string.Format("[CCFFCC]{0}[-]길드에서 수락되어 길드원이 되셨습니다", EHDEFAIBNCN().NCADFOBAFJD));
		UIRoot.Broadcast("RefreshGuildMemberList");
	}

	public void IDLDBHGAKLA(IKMBGMILCDO LFGENOEABMJ, string NCADFOBAFJD)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(81);
		cMNIABEFLBJ.GBMJNFOEACC(NCADFOBAFJD);
		MOCAOKBGPPI.IMBGDEFOFEM(FKPKHNEBGFM(LFGENOEABMJ, cMNIABEFLBJ));
	}

	public void ONLKEFOOKML(int IAEFPLFFKHC, long FGBKCJDHNID)
	{
		FJPMFBBCBLB(OEOIIKMBGAG.GETINFO);
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(1);
		cMNIABEFLBJ.GBMJNFOEACC(13);
		cMNIABEFLBJ.GBMJNFOEACC(IAEFPLFFKHC);
		cMNIABEFLBJ.GBMJNFOEACC(FGBKCJDHNID);
		FBAFKOCPFPG(cMNIABEFLBJ);
	}

	public void MMEMICKLPAL()
	{
	}

	public void OOOFLNNNKHO()
	{
	}

	private void DOGEHKOJNFM(PJEMPFEIOAK HMOAHNANKNE)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
		uint num = HMOAHNANKNE.BMKOKHGAHEC();
		switch (hGBGJMIFCEP)
		{
		case HGBGJMIFCEP.Success:
		{
			uint lIEHHHALFLP = HMOAHNANKNE.BMKOKHGAHEC();
			string gIDNDAJLBOM = HMOAHNANKNE.AFPCLLNMGJP();
			NetworkManager.get_Instance().get_m_communityNetClient().BGDLPOGFFFA()
				.MHEMINFPNEM(num, lIEHHHALFLP, gIDNDAJLBOM);
			UIRoot.Broadcast("OnReceiveFriendChat", num);
			break;
		}
		case HGBGJMIFCEP.DisconnectUser:
			NetworkManager.get_Instance().get_m_communityNetClient().BGDLPOGFFFA()
				.MHEMINFPNEM(num, 0u, "친구가 접속해있지 않아요");
			UIRoot.Broadcast("OnReceiveFriendChat", num);
			break;
		}
	}

	public void HNAEKAEKPEH(IKMBGMILCDO LFGENOEABMJ, uint HMFBJPDBBLO)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(22);
		cMNIABEFLBJ.GBMJNFOEACC(HMFBJPDBBLO);
		MOCAOKBGPPI.BFGLBEPNDLB(FKPKHNEBGFM(LFGENOEABMJ, cMNIABEFLBJ));
	}

	private void GPNKEIJFNHM(PJEMPFEIOAK HMOAHNANKNE)
	{
		UIRoot.MHFJDNCDFGD("하급 공격력 문양", HMOAHNANKNE);
	}

	private void NBACAPAOINM(PJEMPFEIOAK HMOAHNANKNE)
	{
		uint hMFBJPDBBLO = HMOAHNANKNE.BMKOKHGAHEC();
		EHDEFAIBNCN().NPPFHGDHFOO(hMFBJPDBBLO);
		UIRoot.Broadcast("RefreshGuildMemberList");
	}

	private void KIOBILAOFHF(PJEMPFEIOAK HMOAHNANKNE)
	{
		FCKLFFEFEFH fCKLFFEFEFH = new FCKLFFEFEFH();
		HMOAHNANKNE.CAHACMKBJMI(fCKLFFEFEFH);
		EHDEFAIBNCN().IDENLLAHMNN(fCKLFFEFEFH.OHGOBGOIECH);
		EHDEFAIBNCN().FHGGCOCDEHM(fCKLFFEFEFH);
		UIRoot.Broadcast("skill1_missile_c2");
	}

	protected void DHHMEPNMBEI(KKABFAAGMKJ ICENKPDOHBK)
	{
		FCDKBIKHHEE = ICENKPDOHBK;
	}

	public void LCCGECHNFBC(byte EBILEBOJADB)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(5);
		cMNIABEFLBJ.GBMJNFOEACC(EBILEBOJADB);
		FBAFKOCPFPG(cMNIABEFLBJ);
	}

	public void FAHPMEBHKMO(IKMBGMILCDO LFGENOEABMJ, uint EHEJBHLHAJE)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(10);
		cMNIABEFLBJ.GBMJNFOEACC(EHEJBHLHAJE);
		MOCAOKBGPPI.BFGLBEPNDLB(FKPKHNEBGFM(LFGENOEABMJ, cMNIABEFLBJ));
	}

	private void GFCJPJHDLFN(PJEMPFEIOAK HMOAHNANKNE)
	{
		string bHIGNJHHOJP = HMOAHNANKNE.AFPCLLNMGJP();
		string gIDNDAJLBOM = HMOAHNANKNE.AFPCLLNMGJP();
		EHDEFAIBNCN().MHEMINFPNEM(bHIGNJHHOJP, gIDNDAJLBOM);
		UIRoot.Broadcast("OnReceiveGuildChat");
	}

	public void FEKCJBHFIFE(IKMBGMILCDO LFGENOEABMJ, string NCADFOBAFJD)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(15);
		cMNIABEFLBJ.GBMJNFOEACC(NCADFOBAFJD);
		MOCAOKBGPPI.BFGLBEPNDLB(FKPKHNEBGFM(LFGENOEABMJ, cMNIABEFLBJ));
	}

	public void IOMHAEMKIHM(bool NGKJNJKGJNJ = true)
	{
		if (NGKJNJKGJNJ || !NHKIEEJHEJH())
		{
			MNCACLOFDBA();
			FJPMFBBCBLB(OEOIIKMBGAG.CONNECTING);
			if (!NetworkManager.get_Instance().m_testMode)
			{
				OACOJHEOGIL(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 20100));
			}
			else
			{
				OACOJHEOGIL(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 20100));
			}
		}
	}

	public void GIHGIHIEBBM(IKMBGMILCDO LFGENOEABMJ, uint EHEJBHLHAJE)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(9);
		cMNIABEFLBJ.GBMJNFOEACC(EHEJBHLHAJE);
		MOCAOKBGPPI.BFGLBEPNDLB(FKPKHNEBGFM(LFGENOEABMJ, cMNIABEFLBJ));
	}

	protected void HHJCJLFJLFM(KFHIEHIFDLJ ICENKPDOHBK)
	{
		ALIFHNBODAL = ICENKPDOHBK;
	}

	public void BOLACJIGDAN(IKMBGMILCDO LFGENOEABMJ, uint EHEJBHLHAJE)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(12);
		cMNIABEFLBJ.GBMJNFOEACC(EHEJBHLHAJE);
		MOCAOKBGPPI.BFGLBEPNDLB(FKPKHNEBGFM(LFGENOEABMJ, cMNIABEFLBJ));
	}

	private void HEPGEJOKEKC(PJEMPFEIOAK HMOAHNANKNE)
	{
		EHDEFAIBNCN().IMMMKMLMELB = HMOAHNANKNE.BMKOKHGAHEC();
		EHDEFAIBNCN().AIDJBBDNJOA = HMOAHNANKNE.AFPCLLNMGJP();
		UIRoot.Broadcast("RefreshGuildMemberList");
	}

	public void AMEJKDCLCAM(IKMBGMILCDO LFGENOEABMJ, uint HMFBJPDBBLO, bool NGEPGBFMIMM)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(18);
		cMNIABEFLBJ.GBMJNFOEACC(HMFBJPDBBLO);
		cMNIABEFLBJ.GBMJNFOEACC(NGEPGBFMIMM);
		MOCAOKBGPPI.BFGLBEPNDLB(FKPKHNEBGFM(LFGENOEABMJ, cMNIABEFLBJ));
	}

	public KFHIEHIFDLJ BGDLPOGFFFA()
	{
		return ALIFHNBODAL;
	}

	public void DLNOKKGICLJ(IKMBGMILCDO LFGENOEABMJ, string NCADFOBAFJD)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(14);
		cMNIABEFLBJ.GBMJNFOEACC(NCADFOBAFJD);
		MOCAOKBGPPI.BFGLBEPNDLB(FKPKHNEBGFM(LFGENOEABMJ, cMNIABEFLBJ));
	}

	public override void DPILNPAPPKI(float DMLKFKGBHKJ)
	{
		MOCAOKBGPPI.LPBLGFCPADD();
		if (NHKIEEJHEJH() && OOHFDEPKKFN() == OEOIIKMBGAG.COMPLETE)
		{
			DateTime now = DateTime.Now;
			if ((now - PBMIEAAEDGB).TotalSeconds >= 2.0)
			{
				IACGLKCILJD();
				PBMIEAAEDGB = now;
			}
		}
		PJLONDFICHF += DMLKFKGBHKJ;
		if (PJLONDFICHF >= 10f && !NHKIEEJHEJH() && NetworkManager.get_Instance().get_m_userIndex() > 0 && (OOHFDEPKKFN() == OEOIIKMBGAG.ERROR || OOHFDEPKKFN() == OEOIIKMBGAG.WAIT) && NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA() != null && NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.BHIGNJHHOJP.Length > 0)
		{
			PJLONDFICHF = 0f;
			IOMHAEMKIHM();
		}
	}

	public KKABFAAGMKJ EHDEFAIBNCN()
	{
		return FCDKBIKHHEE;
	}

	public void IACGLKCILJD()
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(3);
		FBAFKOCPFPG(cMNIABEFLBJ);
	}

	public void FOGOHPGKCJL(IKMBGMILCDO LFGENOEABMJ)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(16);
		MOCAOKBGPPI.BFGLBEPNDLB(FKPKHNEBGFM(LFGENOEABMJ, cMNIABEFLBJ));
	}

	public void FMNAFAFKAAP(IKMBGMILCDO LFGENOEABMJ, uint OHGOBGOIECH, IPEndPoint GIFJAMEPFNC, int MIEIMPEKCNI, byte OIOCBJMKGCD)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(6);
		cMNIABEFLBJ.GBMJNFOEACC(OHGOBGOIECH);
		cMNIABEFLBJ.GBMJNFOEACC(GIFJAMEPFNC);
		cMNIABEFLBJ.GBMJNFOEACC(MIEIMPEKCNI);
		cMNIABEFLBJ.GBMJNFOEACC(OIOCBJMKGCD);
		MOCAOKBGPPI.BFGLBEPNDLB(FKPKHNEBGFM(LFGENOEABMJ, cMNIABEFLBJ));
	}

	public override void OIHIOEMEAKF()
	{
		PJLONDFICHF = 0f;
		if (OOHFDEPKKFN() == OEOIIKMBGAG.CONNECTING || OOHFDEPKKFN() == OEOIIKMBGAG.GETINFO)
		{
			FJPMFBBCBLB(OEOIIKMBGAG.ERROR);
		}
		else
		{
			FJPMFBBCBLB(OEOIIKMBGAG.WAIT);
		}
	}

	public void JAMKBPILJAH(IKMBGMILCDO LFGENOEABMJ, uint HMFBJPDBBLO)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(25);
		cMNIABEFLBJ.GBMJNFOEACC(HMFBJPDBBLO);
		MOCAOKBGPPI.BFGLBEPNDLB(FKPKHNEBGFM(LFGENOEABMJ, cMNIABEFLBJ));
	}

	public void JLODHOJFABC(IKMBGMILCDO LFGENOEABMJ, string NCADFOBAFJD)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(53);
		cMNIABEFLBJ.GBMJNFOEACC(NCADFOBAFJD);
		MOCAOKBGPPI.IMBGDEFOFEM(FKPKHNEBGFM(LFGENOEABMJ, cMNIABEFLBJ));
	}

	private void GEPGEOPHAEI(PJEMPFEIOAK HMOAHNANKNE)
	{
		uint hMFBJPDBBLO = HMOAHNANKNE.BMKOKHGAHEC();
		EHDEFAIBNCN().NPPFHGDHFOO(hMFBJPDBBLO);
		UIRoot.IGMDNDABNKD("Reserved");
	}

	public void MGILNPGLOIE(IKMBGMILCDO LFGENOEABMJ, uint EHEJBHLHAJE)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(11);
		cMNIABEFLBJ.GBMJNFOEACC(EHEJBHLHAJE);
		MOCAOKBGPPI.BFGLBEPNDLB(FKPKHNEBGFM(LFGENOEABMJ, cMNIABEFLBJ));
	}

	public bool GBBHELGEFFN()
	{
		if (!NHKIEEJHEJH())
		{
			return false;
		}
		if (OOHFDEPKKFN() == OEOIIKMBGAG.COMPLETE)
		{
			return true;
		}
		return false;
	}

	public void MLJIOCALNIF(IKMBGMILCDO LFGENOEABMJ, string KCGEBIJAKAH)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(8);
		cMNIABEFLBJ.GBMJNFOEACC(KCGEBIJAKAH);
		MOCAOKBGPPI.BFGLBEPNDLB(FKPKHNEBGFM(LFGENOEABMJ, cMNIABEFLBJ));
	}

	[DebuggerHidden]
	private IEnumerator FKPKHNEBGFM(IKMBGMILCDO LFGENOEABMJ, CMNIABEFLBJ EFDLFNPAKGO)
	{
		CEKPLLAFCAG cEKPLLAFCAG = new CEKPLLAFCAG();
		cEKPLLAFCAG.LFGENOEABMJ = LFGENOEABMJ;
		cEKPLLAFCAG.EFDLFNPAKGO = EFDLFNPAKGO;
		cEKPLLAFCAG.KBKBOHMONNK = LFGENOEABMJ;
		cEKPLLAFCAG.NNHAJJNHAHM = EFDLFNPAKGO;
		cEKPLLAFCAG.KNIAJMGDGAA = this;
		return cEKPLLAFCAG;
	}

	[DebuggerHidden]
	public IEnumerator GHMCMFFCBCP()
	{
		DDDNNKHCDJN dDDNNKHCDJN = new DDDNNKHCDJN();
		dDDNNKHCDJN.KNIAJMGDGAA = this;
		return dDDNNKHCDJN;
	}

	[DebuggerHidden]
	private IEnumerator CKDKELEIAEG(IKMBGMILCDO LFGENOEABMJ, CMNIABEFLBJ EFDLFNPAKGO)
	{
		BKENNJJPCKL bKENNJJPCKL = new BKENNJJPCKL();
		bKENNJJPCKL.EFDLFNPAKGO = EFDLFNPAKGO;
		bKENNJJPCKL.LFGENOEABMJ = LFGENOEABMJ;
		bKENNJJPCKL.NNHAJJNHAHM = EFDLFNPAKGO;
		bKENNJJPCKL.KBKBOHMONNK = LFGENOEABMJ;
		bKENNJJPCKL.KNIAJMGDGAA = this;
		return bKENNJJPCKL;
	}

	private void BOOGAECEOHJ(PJEMPFEIOAK HMOAHNANKNE)
	{
	}

	public override void CPILEHGNHGE()
	{
		ONLKEFOOKML(NetworkManager.get_Instance().get_m_userIndex(), NetworkManager.get_Instance().get_m_authCode());
	}

	private void OLJKHPHKDAB(PJEMPFEIOAK HMOAHNANKNE)
	{
		EHDEFAIBNCN().PDCPMDCOLOD();
		MsgManager.get_Instance().ShowTip("가입되신 길드에서 탈퇴되었습니다");
		UIRoot.Broadcast("RefreshGuildMemberList");
	}

	public void IAFGAGLHEIA(uint DKNPOIMAMGI)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(27);
		cMNIABEFLBJ.GBMJNFOEACC(DKNPOIMAMGI);
		FBAFKOCPFPG(cMNIABEFLBJ);
	}

	private void BJFDMHFEDGB(PJEMPFEIOAK HMOAHNANKNE)
	{
		FCKLFFEFEFH fCKLFFEFEFH = new FCKLFFEFEFH();
		HMOAHNANKNE.CAHACMKBJMI(fCKLFFEFEFH);
		EHDEFAIBNCN().IDENLLAHMNN(fCKLFFEFEFH.OHGOBGOIECH);
		EHDEFAIBNCN().FHGGCOCDEHM(fCKLFFEFEFH);
		UIRoot.Broadcast("RefreshGuildMemberList");
	}

	public bool ICCGBHIODCD()
	{
		if (!NHKIEEJHEJH())
		{
			return true;
		}
		if (OOHFDEPKKFN() == OEOIIKMBGAG.WAIT)
		{
			return true;
		}
		return true;
	}

	private void BCKPGMIFOID(PJEMPFEIOAK HMOAHNANKNE)
	{
		HMOAHNANKNE.CAHACMKBJMI(KKLHPCCEKPN());
		UIRoot.Broadcast("RefreshFriend");
	}

	public void FIAOIBHAANO(uint EHEJBHLHAJE, string GIDNDAJLBOM)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(13);
		cMNIABEFLBJ.GBMJNFOEACC(EHEJBHLHAJE);
		cMNIABEFLBJ.GBMJNFOEACC(GIDNDAJLBOM);
		FBAFKOCPFPG(cMNIABEFLBJ);
	}

	private void JEFGNINDBAA(PJEMPFEIOAK HMOAHNANKNE)
	{
	}

	public void HIBNAMHAEAN(uint EHEJBHLHAJE, string GIDNDAJLBOM)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(65514);
		cMNIABEFLBJ.BHAFGILIOCN(EHEJBHLHAJE);
		cMNIABEFLBJ.GBMJNFOEACC(GIDNDAJLBOM);
		FBAFKOCPFPG(cMNIABEFLBJ);
	}

	private void BIKLFOIIBMI(PJEMPFEIOAK HMOAHNANKNE)
	{
		uint oHGOBGOIECH = HMOAHNANKNE.BMKOKHGAHEC();
		string nCADFOBAFJD = HMOAHNANKNE.AFPCLLNMGJP();
		NNIFLFNLLCP.HOBEOFGIILE(oHGOBGOIECH, nCADFOBAFJD);
	}

	public void KEELDFGNNMA(IKMBGMILCDO LFGENOEABMJ, string LHCPJKNAIMO)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(21);
		cMNIABEFLBJ.GBMJNFOEACC(LHCPJKNAIMO);
		MOCAOKBGPPI.BFGLBEPNDLB(FKPKHNEBGFM(LFGENOEABMJ, cMNIABEFLBJ));
	}

	[SpecialName]
	protected void CBMJMBAGOFB(BDDNBIDODLE ICENKPDOHBK)
	{
		KKKEPLIPEBH = ICENKPDOHBK;
	}

	public PBOOPPEPAIK GLPDLIDMHFA()
	{
		return CFPANPNKOPM;
	}

	private void FEBCKCPPNFM(PJEMPFEIOAK HMOAHNANKNE)
	{
	}

	public BDDNBIDODLE KKLHPCCEKPN()
	{
		return KKKEPLIPEBH;
	}

	public OEOIIKMBGAG OOHFDEPKKFN()
	{
		return BBEEPJNEHBI;
	}

	private void KGFHHIFGLCH(PJEMPFEIOAK HMOAHNANKNE)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
		switch (hGBGJMIFCEP)
		{
		case HGBGJMIFCEP.Success:
			HMOAHNANKNE.CAHACMKBJMI(GLPDLIDMHFA());
			if (HMOAHNANKNE.JCGKFEPEJPO())
			{
				HMOAHNANKNE.CAHACMKBJMI(EHDEFAIBNCN());
			}
			else
			{
				EHDEFAIBNCN().PDCPMDCOLOD();
			}
			FJPMFBBCBLB(OEOIIKMBGAG.COMPLETE);
			break;
		case HGBGJMIFCEP.InvalidProtocolVersion:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("[VNET ] 버전 오류\n게임 인증 응답 경로          "));
			break;
		case HGBGJMIFCEP.InvalidUserID:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("정상적이지 않은 아이디입니다."));
			break;
		case HGBGJMIFCEP.AlreadyConnect:
			if (Application.loadedLevelName == "Login")
			{
				MsgManager.get_Instance().ShowMessageBox("이미 접속중입니다.\n\n기존 접속을 끊거나\n잠시후에 다시 시도해 주세요.");
			}
			break;
		case HGBGJMIFCEP.MaxCount:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("최대 접속자를 초과하였습니다.\n\n나중에 접속을 시도해 주세요."));
			break;
		}
		if (hGBGJMIFCEP != HGBGJMIFCEP.Success)
		{
			MNCACLOFDBA();
			FJPMFBBCBLB(OEOIIKMBGAG.ERROR);
		}
	}

	protected void LLKFMCHMFCD(BDDNBIDODLE ICENKPDOHBK)
	{
		KKKEPLIPEBH = ICENKPDOHBK;
	}

	protected void PCCKECEKJMC(PBOOPPEPAIK ICENKPDOHBK)
	{
		CFPANPNKOPM = ICENKPDOHBK;
	}

	public bool MPAKKBBGKKL()
	{
		if (!NHKIEEJHEJH())
		{
			return false;
		}
		if (OOHFDEPKKFN() == OEOIIKMBGAG.COMPLETE)
		{
			return false;
		}
		return true;
	}

	public void FDFEJHPIJIP(string GIDNDAJLBOM)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(28);
		cMNIABEFLBJ.GBMJNFOEACC(GIDNDAJLBOM);
		FBAFKOCPFPG(cMNIABEFLBJ);
	}

	private void DCMMCCINMAO(PJEMPFEIOAK HMOAHNANKNE)
	{
		UIRoot.Broadcast("OnReceiveInvite", HMOAHNANKNE);
	}

	public void HDJEGJOKBHK(IKMBGMILCDO LFGENOEABMJ, string NCADFOBAFJD)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(17);
		cMNIABEFLBJ.GBMJNFOEACC(NCADFOBAFJD);
		MOCAOKBGPPI.BFGLBEPNDLB(FKPKHNEBGFM(LFGENOEABMJ, cMNIABEFLBJ));
	}

	public PFIKNBCBLLE()
	{
		FJPMFBBCBLB(OEOIIKMBGAG.WAIT);
		MOCAOKBGPPI = new KPDFMPKNAPI();
		PCCKECEKJMC(new PBOOPPEPAIK());
		LLKFMCHMFCD(new BDDNBIDODLE());
		HHJCJLFJLFM(new KFHIEHIFDLJ());
		DHHMEPNMBEI(new KKABFAAGMKJ());
		HADMKAKPDDO(1, KGFHHIFGLCH);
		HADMKAKPDDO(2, BOOGAECEOHJ);
		HADMKAKPDDO(3, JEFGNINDBAA);
		HADMKAKPDDO(4, BCKPGMIFOID);
		HADMKAKPDDO(5, PKPACNJCOLA);
		HADMKAKPDDO(13, DOGEHKOJNFM);
		HADMKAKPDDO(7, DCMMCCINMAO);
		HADMKAKPDDO(19, BJFDMHFEDGB);
		HADMKAKPDDO(20, JPPJIPEBIOF);
		HADMKAKPDDO(23, NBACAPAOINM);
		HADMKAKPDDO(24, OLJKHPHKDAB);
		HADMKAKPDDO(26, HEPGEJOKEKC);
		HADMKAKPDDO(27, BIKLFOIIBMI);
		HADMKAKPDDO(28, GFCJPJHDLFN);
	}

	private void PKPACNJCOLA(PJEMPFEIOAK HMOAHNANKNE)
	{
		uint num = HMOAHNANKNE.BMKOKHGAHEC();
		byte eBILEBOJADB = HMOAHNANKNE.KFAGPDGHEBK();
		JJKIONLJMJP jJKIONLJMJP = KKLHPCCEKPN().MHHOFFEBNCG(num);
		if (jJKIONLJMJP != null)
		{
			jJKIONLJMJP.EBILEBOJADB = eBILEBOJADB;
			UIRoot.Broadcast("ChangeFriendState");
		}
		if (EHDEFAIBNCN().OHGOBGOIECH != 0)
		{
			FCKLFFEFEFH fCKLFFEFEFH = EHDEFAIBNCN().IAFNIPEGNLN(num);
			if (fCKLFFEFEFH != null)
			{
				fCKLFFEFEFH.EBILEBOJADB = eBILEBOJADB;
				UIRoot.Broadcast("ChangeGuildMemberState");
			}
		}
	}
}
