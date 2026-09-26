using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TheaterManager : MonoBehaviour
{
	public enum BOJNCLHKEBB
	{
		Play = 0,
		Pause = 1
	}

	private sealed class OPLNDNGCJML : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal TheaterTalkIllustBehaviour.CGNFDFOCFHO HEPNHCEIFMO;

		internal string NCADFOBAFJD;

		internal bool NCDNGHPLOGH;

		internal TheaterTalkWindowBehaviour.MKLGBPDOGFC BDIGPAOEKPN;

		internal string BMNKKBDCELE;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal TheaterTalkIllustBehaviour.CGNFDFOCFHO NKFEPGMMNMM;

		internal string DEOIGLHAKDJ;

		internal bool LOMLGABOCEP;

		internal TheaterTalkWindowBehaviour.MKLGBPDOGFC JACIEODFGOP;

		internal string IHIEHDNONHD;

		internal TheaterManager KNIAJMGDGAA;

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

		public bool MHEGNOHIKCL()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.MPOKAKGEKJJ.EHCGDHECEMI.SetInfo(HEPNHCEIFMO, NCADFOBAFJD, NCDNGHPLOGH);
				KNIAJMGDGAA.MPOKAKGEKJJ.INPAINJGMOJ.KHKJFOGEJGE(BDIGPAOEKPN, BMNKKBDCELE);
				KNIAJMGDGAA.MPOKAKGEKJJ.DCDDKOHBFKK();
				goto IL_00b0;
			case 1u:
				{
					if (!KNIAJMGDGAA.MPOKAKGEKJJ.INPAINJGMOJ.DJNCNFIDNHK())
					{
						goto IL_00b0;
					}
					goto IL_00ca;
				}
				IL_00b0:
				if (!KNIAJMGDGAA.MPOKAKGEKJJ.INPAINJGMOJ.OJCCJCCNJDB())
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 1;
					return false;
				}
				goto IL_00ca;
				IL_00ca:
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		public void IIJCOOCGGGJ()
		{
			throw new NotSupportedException();
		}

		public void LGKLIIJCFMM()
		{
			GOMFKPLCGNN = -1;
		}

		public void DAPBOMILKPH()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object PHDGFFDAMLI()
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
				KNIAJMGDGAA.MPOKAKGEKJJ.EHCGDHECEMI.SetInfo(HEPNHCEIFMO, NCADFOBAFJD, NCDNGHPLOGH);
				KNIAJMGDGAA.MPOKAKGEKJJ.INPAINJGMOJ.SetInfo(BDIGPAOEKPN, BMNKKBDCELE);
				KNIAJMGDGAA.MPOKAKGEKJJ.MGOENKOOFLO();
				goto IL_00b0;
			case 1u:
				{
					if (!KNIAJMGDGAA.MPOKAKGEKJJ.INPAINJGMOJ.get_m_clicked())
					{
						goto IL_00b0;
					}
					goto IL_00ca;
				}
				IL_00b0:
				if (!KNIAJMGDGAA.MPOKAKGEKJJ.INPAINJGMOJ.IsFullViewText())
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 1;
					return true;
				}
				goto IL_00ca;
				IL_00ca:
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public bool DAJHAEIAPAO()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.MPOKAKGEKJJ.EHCGDHECEMI.LDEJCMKPHFE(HEPNHCEIFMO, NCADFOBAFJD, NCDNGHPLOGH);
				KNIAJMGDGAA.MPOKAKGEKJJ.INPAINJGMOJ.IEPMMBBMGCJ(BDIGPAOEKPN, BMNKKBDCELE);
				KNIAJMGDGAA.MPOKAKGEKJJ.DCDDKOHBFKK();
				goto IL_00b0;
			case 1u:
				{
					if (!KNIAJMGDGAA.MPOKAKGEKJJ.INPAINJGMOJ.get_m_clicked())
					{
						goto IL_00b0;
					}
					goto IL_00ca;
				}
				IL_00b0:
				if (!KNIAJMGDGAA.MPOKAKGEKJJ.INPAINJGMOJ.OJCCJCCNJDB())
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 0;
					return false;
				}
				goto IL_00ca;
				IL_00ca:
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public bool APBAGAKLFDK()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.MPOKAKGEKJJ.EHCGDHECEMI.LMJOANHHCHI(HEPNHCEIFMO, NCADFOBAFJD, NCDNGHPLOGH);
				KNIAJMGDGAA.MPOKAKGEKJJ.INPAINJGMOJ.KHKJFOGEJGE(BDIGPAOEKPN, BMNKKBDCELE);
				KNIAJMGDGAA.MPOKAKGEKJJ.MADCDCNEGBO();
				goto IL_00b0;
			case 1u:
				{
					if (!KNIAJMGDGAA.MPOKAKGEKJJ.INPAINJGMOJ.get_m_clicked())
					{
						goto IL_00b0;
					}
					goto IL_00ca;
				}
				IL_00b0:
				if (!KNIAJMGDGAA.MPOKAKGEKJJ.INPAINJGMOJ.IsFullViewText())
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 1;
					return false;
				}
				goto IL_00ca;
				IL_00ca:
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[SpecialName]
		private object IDHECIOOCMD()
		{
			return MMEGGNJKNOH;
		}

		public void BFAMOEFLLGH()
		{
			throw new NotSupportedException();
		}

		public void FPLNHDDGGHP()
		{
			GOMFKPLCGNN = -1;
		}

		public bool LLKGBIDKCOF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.MPOKAKGEKJJ.EHCGDHECEMI.IEPMMBBMGCJ(HEPNHCEIFMO, NCADFOBAFJD, NCDNGHPLOGH);
				KNIAJMGDGAA.MPOKAKGEKJJ.INPAINJGMOJ.KHKJFOGEJGE(BDIGPAOEKPN, BMNKKBDCELE);
				KNIAJMGDGAA.MPOKAKGEKJJ.MADCDCNEGBO();
				goto IL_00b0;
			case 1u:
				{
					if (!KNIAJMGDGAA.MPOKAKGEKJJ.INPAINJGMOJ.get_m_clicked())
					{
						goto IL_00b0;
					}
					goto IL_00ca;
				}
				IL_00b0:
				if (!KNIAJMGDGAA.MPOKAKGEKJJ.INPAINJGMOJ.IsFullViewText())
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 1;
					return false;
				}
				goto IL_00ca;
				IL_00ca:
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object FECLPGHCNNJ()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public void JGCPFKEPPOM()
		{
			GOMFKPLCGNN = -1;
		}
	}

	private sealed class AGGLLMDLBIF : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal string BMNKKBDCELE;

		internal Color BEAKIPPBGAF;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal string IHIEHDNONHD;

		internal Color LFPNEMBHJJC;

		internal TheaterManager KNIAJMGDGAA;

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

		public void AHEHIJAMCDO()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object BLGJNJAMAIJ()
		{
			return MMEGGNJKNOH;
		}

		public void BFAMOEFLLGH()
		{
			throw new NotSupportedException();
		}

		public void BKAONBFNGOC()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		public bool BDHBKIPJENC()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.CDIMJOMLGNG.CDIMJOMLGNG.DOHBFGODMDM(BMNKKBDCELE, BEAKIPPBGAF);
				KNIAJMGDGAA.CDIMJOMLGNG.NDIEGKILKHF();
				goto case 1u;
			case 1u:
				if (!KNIAJMGDGAA.CDIMJOMLGNG.CDIMJOMLGNG.DMGJFJJGLON())
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 0;
					return true;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public void OCFAAIMPJFI()
		{
			throw new NotSupportedException();
		}

		public void AOLCKHCODEM()
		{
			throw new NotSupportedException();
		}

		public bool MNHCKJNDJOG()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.CDIMJOMLGNG.CDIMJOMLGNG.DHPIBHEPNKE(BMNKKBDCELE, BEAKIPPBGAF);
				KNIAJMGDGAA.CDIMJOMLGNG.NDIEGKILKHF();
				goto case 1u;
			case 1u:
				if (!KNIAJMGDGAA.CDIMJOMLGNG.CDIMJOMLGNG.DMGJFJJGLON())
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 1;
					return false;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object FKNAIGMNFIB()
		{
			return MMEGGNJKNOH;
		}

		public void LGKLIIJCFMM()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object MGBPOAHMJLK()
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
				KNIAJMGDGAA.CDIMJOMLGNG.CDIMJOMLGNG.DHPIBHEPNKE(BMNKKBDCELE, BEAKIPPBGAF);
				KNIAJMGDGAA.CDIMJOMLGNG.MGOENKOOFLO();
				goto case 1u;
			case 1u:
				if (!KNIAJMGDGAA.CDIMJOMLGNG.CDIMJOMLGNG.IsFullViewText())
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 0;
					return false;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[SpecialName]
		private object PGFJCOHEGDG()
		{
			return MMEGGNJKNOH;
		}

		public void CDNEMMAGDGN()
		{
			throw new NotSupportedException();
		}

		public void FJHNAGNJLLO()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public bool KKJFPODFKCB()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.CDIMJOMLGNG.CDIMJOMLGNG.DHPIBHEPNKE(BMNKKBDCELE, BEAKIPPBGAF);
				KNIAJMGDGAA.CDIMJOMLGNG.NDIEGKILKHF();
				goto case 1u;
			case 1u:
				if (!KNIAJMGDGAA.CDIMJOMLGNG.CDIMJOMLGNG.DMGJFJJGLON())
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 0;
					return true;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		public void KAAGPADGBLK()
		{
			GOMFKPLCGNN = -1;
		}

		public void NAEOFIPICLC()
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
				KNIAJMGDGAA.CDIMJOMLGNG.CDIMJOMLGNG.SetInfo(BMNKKBDCELE, BEAKIPPBGAF);
				KNIAJMGDGAA.CDIMJOMLGNG.MGOENKOOFLO();
				goto case 1u;
			case 1u:
				if (!KNIAJMGDGAA.CDIMJOMLGNG.CDIMJOMLGNG.IsFullViewText())
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 1;
					return true;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}
	}

	private sealed class MGLCNFMCJLM : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal TheaterManager KNIAJMGDGAA;

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

		public void NGFBCKPMPAE()
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
			case 1u:
				if (KNIAJMGDGAA.CEMCACLEPCA != null)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 0;
					return false;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		public void DAOEJAEGMFP()
		{
			GOMFKPLCGNN = -1;
		}

		public void EJAKHHBBJPL()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object KLKKJPIHLNB()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object ILBNFHMAGCF()
		{
			return MMEGGNJKNOH;
		}

		public void KIHPGHBDAMI()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object IFFDBIJPACH()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object DMGHHPDEMLE()
		{
			return MMEGGNJKNOH;
		}

		public void DFNHAOEKBCI()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object BFBDKFOJMAK()
		{
			return MMEGGNJKNOH;
		}

		public void NPKMEPEPIGL()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		public bool JGAGCOAHEKN()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
			case 1u:
				if (KNIAJMGDGAA.CEMCACLEPCA != null)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 0;
					return true;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public bool CBFNJGFKGKG()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
			case 1u:
				if (KNIAJMGDGAA.CEMCACLEPCA != null)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 0;
					return false;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		public void KAAGPADGBLK()
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
			case 1u:
				if (KNIAJMGDGAA.CEMCACLEPCA != null)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 1;
					return true;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public void DHFDBGAOPBL()
		{
			GOMFKPLCGNN = -1;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object MGBPOAHMJLK()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object ANOBEJKPLKK()
		{
			return MMEGGNJKNOH;
		}

		public void FAKMEDLGCCL()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object LEAJHDEIHDJ()
		{
			return MMEGGNJKNOH;
		}

		public void MGAJCMCCCKH()
		{
			GOMFKPLCGNN = -1;
		}

		public void CHFDNLJNKBN()
		{
			GOMFKPLCGNN = -1;
		}
	}

	private static TheaterManager MLDPFDAHKHA;

	private bool PIGFGHMKJKF;

	private BOJNCLHKEBB HFFKEPAOFHG;

	public Camera m_gameCamera;

	public GameObject m_gameGUI;

	public UILabel m_skipLabel;

	public TheaterTalkIllustBehaviour m_talkIllustBehaviour;

	public TheaterTalkWindowBehaviour m_talkWindowBehaviour;

	public TheaterNarrationBehaviour m_narrationBehaviour;

	private ADMODEGAHFK MPOKAKGEKJJ;

	private BFCECIKIONE CDIMJOMLGNG;

	private List<FMANCKBEGBB> ALLHPDILDIB;

	private FMANCKBEGBB CEMCACLEPCA;

	public static TheaterManager CJFCFLEHJKI
	{
		get
		{
			return get_Instance();
		}
	}

	public IEnumerator JDDGNIIBOHB(string BMNKKBDCELE, Color BEAKIPPBGAF)
	{
		AGGLLMDLBIF aGGLLMDLBIF = new AGGLLMDLBIF();
		aGGLLMDLBIF.BMNKKBDCELE = BMNKKBDCELE;
		aGGLLMDLBIF.BEAKIPPBGAF = BEAKIPPBGAF;
		aGGLLMDLBIF.IHIEHDNONHD = BMNKKBDCELE;
		aGGLLMDLBIF.LFPNEMBHJJC = BEAKIPPBGAF;
		aGGLLMDLBIF.KNIAJMGDGAA = this;
		return aGGLLMDLBIF;
	}

	public void JAAKMLDJDMM(bool EGPIIGGMKHJ)
	{
		m_gameGUI.SetActive(EGPIIGGMKHJ);
	}

	public IEnumerator JEMIHKHJNAP(TheaterTalkWindowBehaviour.MKLGBPDOGFC BDIGPAOEKPN, TheaterTalkIllustBehaviour.CGNFDFOCFHO HEPNHCEIFMO, string NCADFOBAFJD, bool NCDNGHPLOGH, string BMNKKBDCELE)
	{
		OPLNDNGCJML oPLNDNGCJML = new OPLNDNGCJML();
		oPLNDNGCJML.HEPNHCEIFMO = HEPNHCEIFMO;
		oPLNDNGCJML.NCADFOBAFJD = NCADFOBAFJD;
		oPLNDNGCJML.NCDNGHPLOGH = NCDNGHPLOGH;
		oPLNDNGCJML.BDIGPAOEKPN = BDIGPAOEKPN;
		oPLNDNGCJML.BMNKKBDCELE = BMNKKBDCELE;
		oPLNDNGCJML.NKFEPGMMNMM = HEPNHCEIFMO;
		oPLNDNGCJML.DEOIGLHAKDJ = NCADFOBAFJD;
		oPLNDNGCJML.LOMLGABOCEP = NCDNGHPLOGH;
		oPLNDNGCJML.JACIEODFGOP = BDIGPAOEKPN;
		oPLNDNGCJML.IHIEHDNONHD = BMNKKBDCELE;
		oPLNDNGCJML.KNIAJMGDGAA = this;
		return oPLNDNGCJML;
	}

	private void IGBMHNDBCEB()
	{
	}

	public void CloseTalk()
	{
		MPOKAKGEKJJ.HIGCLCKDNIB();
	}

	[DebuggerHidden]
	public IEnumerator Talk(TheaterTalkWindowBehaviour.MKLGBPDOGFC BDIGPAOEKPN, TheaterTalkIllustBehaviour.CGNFDFOCFHO HEPNHCEIFMO, string NCADFOBAFJD, bool NCDNGHPLOGH, string BMNKKBDCELE)
	{
		OPLNDNGCJML oPLNDNGCJML = new OPLNDNGCJML();
		oPLNDNGCJML.HEPNHCEIFMO = HEPNHCEIFMO;
		oPLNDNGCJML.NCADFOBAFJD = NCADFOBAFJD;
		oPLNDNGCJML.NCDNGHPLOGH = NCDNGHPLOGH;
		oPLNDNGCJML.BDIGPAOEKPN = BDIGPAOEKPN;
		oPLNDNGCJML.BMNKKBDCELE = BMNKKBDCELE;
		oPLNDNGCJML.NKFEPGMMNMM = HEPNHCEIFMO;
		oPLNDNGCJML.DEOIGLHAKDJ = NCADFOBAFJD;
		oPLNDNGCJML.LOMLGABOCEP = NCDNGHPLOGH;
		oPLNDNGCJML.JACIEODFGOP = BDIGPAOEKPN;
		oPLNDNGCJML.IHIEHDNONHD = BMNKKBDCELE;
		oPLNDNGCJML.KNIAJMGDGAA = this;
		return oPLNDNGCJML;
	}

	private void Update()
	{
	}

	public IEnumerator OFOKCLEBFNK()
	{
		MGLCNFMCJLM mGLCNFMCJLM = new MGLCNFMCJLM();
		mGLCNFMCJLM.KNIAJMGDGAA = this;
		return mGLCNFMCJLM;
	}

	public void BeginDungeon(ushort HDAEPLDPJDP, byte MBEGPHMKKGI, NFFHBNEJAEE.CIPMICDJPEH KJDMPIDFHFF)
	{
		if (CEMCACLEPCA != null)
		{
			return;
		}
		foreach (FMANCKBEGBB item in ALLHPDILDIB)
		{
			NFFHBNEJAEE nFFHBNEJAEE = (NFFHBNEJAEE)item;
			if (nFFHBNEJAEE == null || !nFFHBNEJAEE.OEJCMIPMGPF(HDAEPLDPJDP, MBEGPHMKKGI, KJDMPIDFHFF))
			{
				continue;
			}
			base.gameObject.SetActive(true);
			m_skipLabel.gameObject.SetActive(true);
			CEMCACLEPCA = nFFHBNEJAEE;
			StartCoroutine(nFFHBNEJAEE.LPBLGFCPADD());
			break;
		}
	}

	public void IGNGJCFLOIG(ushort HDAEPLDPJDP, byte MBEGPHMKKGI, NFFHBNEJAEE.CIPMICDJPEH KJDMPIDFHFF)
	{
		if (CEMCACLEPCA != null)
		{
			return;
		}
		foreach (FMANCKBEGBB item in ALLHPDILDIB)
		{
			NFFHBNEJAEE nFFHBNEJAEE = (NFFHBNEJAEE)item;
			if (nFFHBNEJAEE == null || !nFFHBNEJAEE.PIEHALDHMDH(HDAEPLDPJDP, MBEGPHMKKGI, KJDMPIDFHFF))
			{
				continue;
			}
			base.gameObject.SetActive(false);
			m_skipLabel.gameObject.SetActive(true);
			CEMCACLEPCA = nFFHBNEJAEE;
			StartCoroutine(nFFHBNEJAEE.AFBPNJAKNGG());
			break;
		}
	}

	public void PPFNCCANFKC()
	{
		MPOKAKGEKJJ.CNLPLGJCBIA();
	}

	private void MADPEEGGCLD()
	{
		ALLHPDILDIB = new List<FMANCKBEGBB>();
		ALLHPDILDIB.Add(new HIFEHJCHCCF());
		ALLHPDILDIB.Add(new HDAFJAAIFEL());
		ALLHPDILDIB.Add(new IGHINNCEDKE());
		ALLHPDILDIB.Add(new OKCPOBNPJOD());
		ALLHPDILDIB.Add(new IEJANNAMHLF());
		ALLHPDILDIB.Add(new LGEHGOCNHMD());
		ALLHPDILDIB.Add(new JILDPDPNIKC());
		MPOKAKGEKJJ = new ADMODEGAHFK(m_talkIllustBehaviour, m_talkWindowBehaviour);
		CDIMJOMLGNG = new BFCECIKIONE(m_narrationBehaviour);
	}

	private void Awake()
	{
		ALLHPDILDIB = new List<FMANCKBEGBB>();
		ALLHPDILDIB.Add(new HIFEHJCHCCF());
		ALLHPDILDIB.Add(new HDAFJAAIFEL());
		ALLHPDILDIB.Add(new IGHINNCEDKE());
		ALLHPDILDIB.Add(new OKCPOBNPJOD());
		ALLHPDILDIB.Add(new IEJANNAMHLF());
		ALLHPDILDIB.Add(new LGEHGOCNHMD());
		ALLHPDILDIB.Add(new JILDPDPNIKC());
		MPOKAKGEKJJ = new ADMODEGAHFK(m_talkIllustBehaviour, m_talkWindowBehaviour);
		CDIMJOMLGNG = new BFCECIKIONE(m_narrationBehaviour);
	}

	public IEnumerator JBMKDPDDIJC()
	{
		MGLCNFMCJLM mGLCNFMCJLM = new MGLCNFMCJLM();
		mGLCNFMCJLM.KNIAJMGDGAA = this;
		return mGLCNFMCJLM;
	}

	public IEnumerator NPMDFHKKJCH()
	{
		MGLCNFMCJLM mGLCNFMCJLM = new MGLCNFMCJLM();
		mGLCNFMCJLM.KNIAJMGDGAA = this;
		return mGLCNFMCJLM;
	}

	public void BCEKDFCCNJK(ushort HDAEPLDPJDP, byte MBEGPHMKKGI, NFFHBNEJAEE.CIPMICDJPEH KJDMPIDFHFF)
	{
		if (CEMCACLEPCA != null)
		{
			return;
		}
		foreach (FMANCKBEGBB item in ALLHPDILDIB)
		{
			NFFHBNEJAEE nFFHBNEJAEE = (NFFHBNEJAEE)item;
			if (nFFHBNEJAEE == null || !nFFHBNEJAEE.NGLLJIFAMND(HDAEPLDPJDP, MBEGPHMKKGI, KJDMPIDFHFF))
			{
				continue;
			}
			base.gameObject.SetActive(false);
			m_skipLabel.gameObject.SetActive(false);
			CEMCACLEPCA = nFFHBNEJAEE;
			StartCoroutine(nFFHBNEJAEE.LPBLGFCPADD());
			break;
		}
	}

	public IEnumerator NLOLJLKHHBN(TheaterTalkWindowBehaviour.MKLGBPDOGFC BDIGPAOEKPN, TheaterTalkIllustBehaviour.CGNFDFOCFHO HEPNHCEIFMO, string NCADFOBAFJD, bool NCDNGHPLOGH, string BMNKKBDCELE)
	{
		OPLNDNGCJML oPLNDNGCJML = new OPLNDNGCJML();
		oPLNDNGCJML.HEPNHCEIFMO = HEPNHCEIFMO;
		oPLNDNGCJML.NCADFOBAFJD = NCADFOBAFJD;
		oPLNDNGCJML.NCDNGHPLOGH = NCDNGHPLOGH;
		oPLNDNGCJML.BDIGPAOEKPN = BDIGPAOEKPN;
		oPLNDNGCJML.BMNKKBDCELE = BMNKKBDCELE;
		oPLNDNGCJML.NKFEPGMMNMM = HEPNHCEIFMO;
		oPLNDNGCJML.DEOIGLHAKDJ = NCADFOBAFJD;
		oPLNDNGCJML.LOMLGABOCEP = NCDNGHPLOGH;
		oPLNDNGCJML.JACIEODFGOP = BDIGPAOEKPN;
		oPLNDNGCJML.IHIEHDNONHD = BMNKKBDCELE;
		oPLNDNGCJML.KNIAJMGDGAA = this;
		return oPLNDNGCJML;
	}

	public void DCFMPNIALMM()
	{
		if (CEMCACLEPCA != null)
		{
			StopCoroutine(CEMCACLEPCA.LPBLGFCPADD());
			CEMCACLEPCA = null;
		}
		base.gameObject.SetActive(false);
		m_skipLabel.gameObject.SetActive(false);
	}

	[DebuggerHidden]
	public IEnumerator Narration(string BMNKKBDCELE, Color BEAKIPPBGAF)
	{
		AGGLLMDLBIF aGGLLMDLBIF = new AGGLLMDLBIF();
		aGGLLMDLBIF.BMNKKBDCELE = BMNKKBDCELE;
		aGGLLMDLBIF.BEAKIPPBGAF = BEAKIPPBGAF;
		aGGLLMDLBIF.IHIEHDNONHD = BMNKKBDCELE;
		aGGLLMDLBIF.LFPNEMBHJJC = BEAKIPPBGAF;
		aGGLLMDLBIF.KNIAJMGDGAA = this;
		return aGGLLMDLBIF;
	}

	public void OnClickSkipButton()
	{
		if (CEMCACLEPCA != null)
		{
			CEMCACLEPCA.HIGCLCKDNIB();
		}
	}

	public IEnumerator NOPBAAAOMLP(TheaterTalkWindowBehaviour.MKLGBPDOGFC BDIGPAOEKPN, TheaterTalkIllustBehaviour.CGNFDFOCFHO HEPNHCEIFMO, string NCADFOBAFJD, bool NCDNGHPLOGH, string BMNKKBDCELE)
	{
		OPLNDNGCJML oPLNDNGCJML = new OPLNDNGCJML();
		oPLNDNGCJML.HEPNHCEIFMO = HEPNHCEIFMO;
		oPLNDNGCJML.NCADFOBAFJD = NCADFOBAFJD;
		oPLNDNGCJML.NCDNGHPLOGH = NCDNGHPLOGH;
		oPLNDNGCJML.BDIGPAOEKPN = BDIGPAOEKPN;
		oPLNDNGCJML.BMNKKBDCELE = BMNKKBDCELE;
		oPLNDNGCJML.NKFEPGMMNMM = HEPNHCEIFMO;
		oPLNDNGCJML.DEOIGLHAKDJ = NCADFOBAFJD;
		oPLNDNGCJML.LOMLGABOCEP = NCDNGHPLOGH;
		oPLNDNGCJML.JACIEODFGOP = BDIGPAOEKPN;
		oPLNDNGCJML.IHIEHDNONHD = BMNKKBDCELE;
		oPLNDNGCJML.KNIAJMGDGAA = this;
		return oPLNDNGCJML;
	}

	public IEnumerator KEGOGOCGOHB(TheaterTalkWindowBehaviour.MKLGBPDOGFC BDIGPAOEKPN, TheaterTalkIllustBehaviour.CGNFDFOCFHO HEPNHCEIFMO, string NCADFOBAFJD, bool NCDNGHPLOGH, string BMNKKBDCELE)
	{
		OPLNDNGCJML oPLNDNGCJML = new OPLNDNGCJML();
		oPLNDNGCJML.HEPNHCEIFMO = HEPNHCEIFMO;
		oPLNDNGCJML.NCADFOBAFJD = NCADFOBAFJD;
		oPLNDNGCJML.NCDNGHPLOGH = NCDNGHPLOGH;
		oPLNDNGCJML.BDIGPAOEKPN = BDIGPAOEKPN;
		oPLNDNGCJML.BMNKKBDCELE = BMNKKBDCELE;
		oPLNDNGCJML.NKFEPGMMNMM = HEPNHCEIFMO;
		oPLNDNGCJML.DEOIGLHAKDJ = NCADFOBAFJD;
		oPLNDNGCJML.LOMLGABOCEP = NCDNGHPLOGH;
		oPLNDNGCJML.JACIEODFGOP = BDIGPAOEKPN;
		oPLNDNGCJML.IHIEHDNONHD = BMNKKBDCELE;
		oPLNDNGCJML.KNIAJMGDGAA = this;
		return oPLNDNGCJML;
	}

	public IEnumerator ELEJEEKMJMM()
	{
		MGLCNFMCJLM mGLCNFMCJLM = new MGLCNFMCJLM();
		mGLCNFMCJLM.KNIAJMGDGAA = this;
		return mGLCNFMCJLM;
	}

	public IEnumerator HHMFNENHCIJ()
	{
		MGLCNFMCJLM mGLCNFMCJLM = new MGLCNFMCJLM();
		mGLCNFMCJLM.KNIAJMGDGAA = this;
		return mGLCNFMCJLM;
	}

	public IEnumerator MAEACOCCOOE()
	{
		MGLCNFMCJLM mGLCNFMCJLM = new MGLCNFMCJLM();
		mGLCNFMCJLM.KNIAJMGDGAA = this;
		return mGLCNFMCJLM;
	}

	private void EKGHGFIKAAE()
	{
	}

	public void JBCNCHLPOOB()
	{
		if (CEMCACLEPCA != null)
		{
			CEMCACLEPCA.HIGCLCKDNIB();
		}
	}

	public void ToggleGUI(bool EGPIIGGMKHJ)
	{
		m_gameGUI.SetActive(EGPIIGGMKHJ);
	}

	public void End()
	{
		if (CEMCACLEPCA != null)
		{
			StopCoroutine(CEMCACLEPCA.LPBLGFCPADD());
			CEMCACLEPCA = null;
		}
		base.gameObject.SetActive(false);
		m_skipLabel.gameObject.SetActive(false);
	}

	private void Start()
	{
	}

	public void CameraShake(float KCGJNLKFGCD, float IBKKECOLKGP)
	{
		CameraShake component = m_gameCamera.GetComponent<CameraShake>();
		if (!(component == null))
		{
			component.Begin(KCGJNLKFGCD, IBKKECOLKGP);
		}
	}

	[DebuggerHidden]
	public IEnumerator WaitForEndAction()
	{
		MGLCNFMCJLM mGLCNFMCJLM = new MGLCNFMCJLM();
		mGLCNFMCJLM.KNIAJMGDGAA = this;
		return mGLCNFMCJLM;
	}

	public IEnumerator JMKJONADPJC(TheaterTalkWindowBehaviour.MKLGBPDOGFC BDIGPAOEKPN, TheaterTalkIllustBehaviour.CGNFDFOCFHO HEPNHCEIFMO, string NCADFOBAFJD, bool NCDNGHPLOGH, string BMNKKBDCELE)
	{
		OPLNDNGCJML oPLNDNGCJML = new OPLNDNGCJML();
		oPLNDNGCJML.HEPNHCEIFMO = HEPNHCEIFMO;
		oPLNDNGCJML.NCADFOBAFJD = NCADFOBAFJD;
		oPLNDNGCJML.NCDNGHPLOGH = NCDNGHPLOGH;
		oPLNDNGCJML.BDIGPAOEKPN = BDIGPAOEKPN;
		oPLNDNGCJML.BMNKKBDCELE = BMNKKBDCELE;
		oPLNDNGCJML.NKFEPGMMNMM = HEPNHCEIFMO;
		oPLNDNGCJML.DEOIGLHAKDJ = NCADFOBAFJD;
		oPLNDNGCJML.LOMLGABOCEP = NCDNGHPLOGH;
		oPLNDNGCJML.JACIEODFGOP = BDIGPAOEKPN;
		oPLNDNGCJML.IHIEHDNONHD = BMNKKBDCELE;
		oPLNDNGCJML.KNIAJMGDGAA = this;
		return oPLNDNGCJML;
	}

	public void NNHGODHJLOJ(bool EGPIIGGMKHJ)
	{
		m_gameGUI.SetActive(EGPIIGGMKHJ);
	}

	public static TheaterManager get_Instance()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(TheaterManager)) as TheaterManager;
			if (MLDPFDAHKHA == null)
			{
				MLDPFDAHKHA = new GameObject("TheaterManager", typeof(TheaterManager)).GetComponent<TheaterManager>();
			}
		}
		return MLDPFDAHKHA;
	}
}
