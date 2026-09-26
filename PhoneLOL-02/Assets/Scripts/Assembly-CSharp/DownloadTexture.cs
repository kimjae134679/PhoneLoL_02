using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(UITexture))]
public class DownloadTexture : MonoBehaviour
{
	private sealed class OGCNCDFODDH : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal WWW LBLJCLJGDFA;

		internal UITexture KDBPHEOLPGM;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal DownloadTexture KNIAJMGDGAA;

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

		public void HCCBNJMIKMO()
		{
			throw new NotSupportedException();
		}

		public void IPDOJJOFHCN()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object FKNAIGMNFIB()
		{
			return MMEGGNJKNOH;
		}

		public bool IMGKDFCPNAO()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				LBLJCLJGDFA = new WWW(KNIAJMGDGAA.url);
				MMEGGNJKNOH = LBLJCLJGDFA;
				GOMFKPLCGNN = 1;
				return false;
			case 1u:
				KNIAJMGDGAA.MIIBAAABCBG = LBLJCLJGDFA.texture;
				if (KNIAJMGDGAA.MIIBAAABCBG != null)
				{
					KDBPHEOLPGM = KNIAJMGDGAA.GetComponent<UITexture>();
					KDBPHEOLPGM.set_mainTexture(KNIAJMGDGAA.MIIBAAABCBG);
					KDBPHEOLPGM.BGALGIGNIJG();
				}
				LBLJCLJGDFA.Dispose();
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public bool FHOEAAAJKIA()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				LBLJCLJGDFA = new WWW(KNIAJMGDGAA.url);
				MMEGGNJKNOH = LBLJCLJGDFA;
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				KNIAJMGDGAA.MIIBAAABCBG = LBLJCLJGDFA.texture;
				if (KNIAJMGDGAA.MIIBAAABCBG != null)
				{
					KDBPHEOLPGM = KNIAJMGDGAA.GetComponent<UITexture>();
					KDBPHEOLPGM.set_mainTexture(KNIAJMGDGAA.MIIBAAABCBG);
					KDBPHEOLPGM.MakePixelPerfect();
				}
				LBLJCLJGDFA.Dispose();
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
				LBLJCLJGDFA = new WWW(KNIAJMGDGAA.url);
				MMEGGNJKNOH = LBLJCLJGDFA;
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				KNIAJMGDGAA.MIIBAAABCBG = LBLJCLJGDFA.texture;
				if (KNIAJMGDGAA.MIIBAAABCBG != null)
				{
					KDBPHEOLPGM = KNIAJMGDGAA.GetComponent<UITexture>();
					KDBPHEOLPGM.set_mainTexture(KNIAJMGDGAA.MIIBAAABCBG);
					KDBPHEOLPGM.MakePixelPerfect();
				}
				LBLJCLJGDFA.Dispose();
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

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object LCJGIOCHEJO()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object KFNJGIJANEP()
		{
			return MMEGGNJKNOH;
		}

		public void DAOEJAEGMFP()
		{
			GOMFKPLCGNN = -1;
		}

		public void KOOOABDNJBP()
		{
			throw new NotSupportedException();
		}

		public void BKAONBFNGOC()
		{
			throw new NotSupportedException();
		}

		public void AOLCKHCODEM()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object LNGNAHOMCFE()
		{
			return MMEGGNJKNOH;
		}

		public void DFNHAOEKBCI()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public void CLMMBEKNAJP()
		{
			GOMFKPLCGNN = -1;
		}

		public void NKPIIPIJNGL()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object PCGKBCDEONE()
		{
			return MMEGGNJKNOH;
		}

		public void JGCPFKEPPOM()
		{
			GOMFKPLCGNN = -1;
		}

		public void EJAKHHBBJPL()
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
				LBLJCLJGDFA = new WWW(KNIAJMGDGAA.url);
				MMEGGNJKNOH = LBLJCLJGDFA;
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				KNIAJMGDGAA.MIIBAAABCBG = LBLJCLJGDFA.texture;
				if (KNIAJMGDGAA.MIIBAAABCBG != null)
				{
					KDBPHEOLPGM = KNIAJMGDGAA.GetComponent<UITexture>();
					KDBPHEOLPGM.set_mainTexture(KNIAJMGDGAA.MIIBAAABCBG);
					KDBPHEOLPGM.BGALGIGNIJG();
				}
				LBLJCLJGDFA.Dispose();
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public void DHFDBGAOPBL()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object GDHBJAJPNBF()
		{
			return MMEGGNJKNOH;
		}
	}

	public string url = "http://www.yourwebsite.com/logo.png";

	private Texture2D MIIBAAABCBG;

	private IEnumerator NFKJIJFHBGK()
	{
		OGCNCDFODDH oGCNCDFODDH = new OGCNCDFODDH();
		oGCNCDFODDH.KNIAJMGDGAA = this;
		return oGCNCDFODDH;
	}

	[DebuggerHidden]
	private IEnumerator Start()
	{
		OGCNCDFODDH oGCNCDFODDH = new OGCNCDFODDH();
		oGCNCDFODDH.KNIAJMGDGAA = this;
		return oGCNCDFODDH;
	}

	private IEnumerator BPLOLCKEJJK()
	{
		OGCNCDFODDH oGCNCDFODDH = new OGCNCDFODDH();
		oGCNCDFODDH.KNIAJMGDGAA = this;
		return oGCNCDFODDH;
	}

	private void OnDestroy()
	{
		if (MIIBAAABCBG != null)
		{
			UnityEngine.Object.Destroy(MIIBAAABCBG);
		}
	}

	private void IEOICBBDALE()
	{
		if (MIIBAAABCBG != null)
		{
			UnityEngine.Object.Destroy(MIIBAAABCBG);
		}
	}

	private void CFCAKNDIGGK()
	{
		if (MIIBAAABCBG != null)
		{
			UnityEngine.Object.Destroy(MIIBAAABCBG);
		}
	}

	private IEnumerator CMMIADLEBFJ()
	{
		OGCNCDFODDH oGCNCDFODDH = new OGCNCDFODDH();
		oGCNCDFODDH.KNIAJMGDGAA = this;
		return oGCNCDFODDH;
	}

	private void FEDCFJOLJPJ()
	{
		if (MIIBAAABCBG != null)
		{
			UnityEngine.Object.Destroy(MIIBAAABCBG);
		}
	}

	private IEnumerator FMNOLGPIIFB()
	{
		OGCNCDFODDH oGCNCDFODDH = new OGCNCDFODDH();
		oGCNCDFODDH.KNIAJMGDGAA = this;
		return oGCNCDFODDH;
	}

	private IEnumerator IMBGDEFOFEM()
	{
		OGCNCDFODDH oGCNCDFODDH = new OGCNCDFODDH();
		oGCNCDFODDH.KNIAJMGDGAA = this;
		return oGCNCDFODDH;
	}

	private IEnumerator DHMMCEBEAHA()
	{
		OGCNCDFODDH oGCNCDFODDH = new OGCNCDFODDH();
		oGCNCDFODDH.KNIAJMGDGAA = this;
		return oGCNCDFODDH;
	}

	private void COPCDBABICD()
	{
		if (MIIBAAABCBG != null)
		{
			UnityEngine.Object.Destroy(MIIBAAABCBG);
		}
	}

	private void JBJBNNPMGII()
	{
		if (MIIBAAABCBG != null)
		{
			UnityEngine.Object.Destroy(MIIBAAABCBG);
		}
	}

	private void JLJJJJIGBDB()
	{
		if (MIIBAAABCBG != null)
		{
			UnityEngine.Object.Destroy(MIIBAAABCBG);
		}
	}

	private void GNGDMEAFLPM()
	{
		if (MIIBAAABCBG != null)
		{
			UnityEngine.Object.Destroy(MIIBAAABCBG);
		}
	}
}
