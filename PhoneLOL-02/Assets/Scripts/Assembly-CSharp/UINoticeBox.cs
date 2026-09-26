using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UINoticeBox : MonoBehaviour
{
	private sealed class IAOBPLNAODM : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal string ILIBFGIOAMH;

		internal Color ONNJIECGCIP;

		internal float PEBEILOHLCB;

		internal float EGAFBAPAEBP;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal UINoticeBox KNIAJMGDGAA;

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

		public void DHFDBGAOPBL()
		{
			GOMFKPLCGNN = -1;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object MEHLLKBMILP()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object JGDFFAFIKFC()
		{
			return MMEGGNJKNOH;
		}

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 1u:
				PEBEILOHLCB += 0.04f;
				goto IL_011a;
			case 2u:
				EGAFBAPAEBP = 1f;
				goto IL_01c1;
			case 3u:
				EGAFBAPAEBP -= 0.04f;
				goto IL_01c1;
			case 0u:
				if (KNIAJMGDGAA.LAOHFOKEEHL.Count > 0 && (KNIAJMGDGAA.m_showAtBusy || !(GameManager.get_Instance() != null)))
				{
					ILIBFGIOAMH = KNIAJMGDGAA.LAOHFOKEEHL.First.Value;
					KNIAJMGDGAA.LAOHFOKEEHL.RemoveFirst();
					KNIAJMGDGAA.m_label.set_text(ILIBFGIOAMH);
					ONNJIECGCIP = Color.white;
					PEBEILOHLCB = 0f;
					goto IL_011a;
				}
				KNIAJMGDGAA.gameObject.SetActive(false);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_01c1:
				if (EGAFBAPAEBP > 0f)
				{
					ONNJIECGCIP.a = EGAFBAPAEBP;
					KNIAJMGDGAA.m_bg.set_color(ONNJIECGCIP);
					KNIAJMGDGAA.m_label.set_color(ONNJIECGCIP);
					MMEGGNJKNOH = new WaitForSeconds(0.02f);
					GOMFKPLCGNN = 3;
					break;
				}
				ONNJIECGCIP.a = 0f;
				KNIAJMGDGAA.m_bg.set_color(ONNJIECGCIP);
				KNIAJMGDGAA.m_label.set_color(ONNJIECGCIP);
				goto case 0u;
				IL_011a:
				if (PEBEILOHLCB <= 1f)
				{
					ONNJIECGCIP.a = PEBEILOHLCB;
					KNIAJMGDGAA.m_bg.set_color(ONNJIECGCIP);
					KNIAJMGDGAA.m_label.set_color(ONNJIECGCIP);
					MMEGGNJKNOH = new WaitForSeconds(0.02f);
					GOMFKPLCGNN = 1;
				}
				else
				{
					MMEGGNJKNOH = new WaitForSeconds(5f);
					GOMFKPLCGNN = 2;
				}
				break;
			}
			return true;
		}

		[SpecialName]
		private object FFJDBFMILPN()
		{
			return MMEGGNJKNOH;
		}

		public void MBADNGDPBPB()
		{
			GOMFKPLCGNN = -1;
		}

		public void BKAONBFNGOC()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object BOHACHPKNOE()
		{
			return MMEGGNJKNOH;
		}

		public bool KKJFPODFKCB()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 1u:
				PEBEILOHLCB += 1416f;
				goto IL_011a;
			case 2u:
				EGAFBAPAEBP = 452f;
				goto IL_01c1;
			case 3u:
				EGAFBAPAEBP -= 1128f;
				goto IL_01c1;
			case 0u:
				if (KNIAJMGDGAA.LAOHFOKEEHL.Count > 1 && (KNIAJMGDGAA.m_showAtBusy || !(GameManager.get_Instance() != null)))
				{
					ILIBFGIOAMH = KNIAJMGDGAA.LAOHFOKEEHL.First.Value;
					KNIAJMGDGAA.LAOHFOKEEHL.RemoveFirst();
					KNIAJMGDGAA.m_label.set_text(ILIBFGIOAMH);
					ONNJIECGCIP = Color.white;
					PEBEILOHLCB = 1638f;
					goto IL_011a;
				}
				KNIAJMGDGAA.gameObject.SetActive(true);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_01c1:
				if (EGAFBAPAEBP > 797f)
				{
					ONNJIECGCIP.a = EGAFBAPAEBP;
					KNIAJMGDGAA.m_bg.set_color(ONNJIECGCIP);
					KNIAJMGDGAA.m_label.set_color(ONNJIECGCIP);
					MMEGGNJKNOH = new WaitForSeconds(82f);
					GOMFKPLCGNN = 7;
					break;
				}
				ONNJIECGCIP.a = 774f;
				KNIAJMGDGAA.m_bg.set_color(ONNJIECGCIP);
				KNIAJMGDGAA.m_label.set_color(ONNJIECGCIP);
				goto case 0u;
				IL_011a:
				if (PEBEILOHLCB <= 623f)
				{
					ONNJIECGCIP.a = PEBEILOHLCB;
					KNIAJMGDGAA.m_bg.set_color(ONNJIECGCIP);
					KNIAJMGDGAA.m_label.set_color(ONNJIECGCIP);
					MMEGGNJKNOH = new WaitForSeconds(877f);
					GOMFKPLCGNN = 1;
				}
				else
				{
					MMEGGNJKNOH = new WaitForSeconds(1192f);
					GOMFKPLCGNN = 5;
				}
				break;
			}
			return false;
		}

		public void CDNEMMAGDGN()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object GLNBOOGOGOO()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public void HCCBNJMIKMO()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object LHFBMHCEIHG()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object IDHECIOOCMD()
		{
			return MMEGGNJKNOH;
		}

		public bool AAAMEOEOJHM()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 1u:
				PEBEILOHLCB += 48f;
				goto IL_011a;
			case 2u:
				EGAFBAPAEBP = 426f;
				goto IL_01c1;
			case 3u:
				EGAFBAPAEBP -= 100f;
				goto IL_01c1;
			case 0u:
				if (KNIAJMGDGAA.LAOHFOKEEHL.Count > 1 && (KNIAJMGDGAA.m_showAtBusy || !(GameManager.get_Instance() != null)))
				{
					ILIBFGIOAMH = KNIAJMGDGAA.LAOHFOKEEHL.First.Value;
					KNIAJMGDGAA.LAOHFOKEEHL.RemoveFirst();
					KNIAJMGDGAA.m_label.set_text(ILIBFGIOAMH);
					ONNJIECGCIP = Color.white;
					PEBEILOHLCB = 1203f;
					goto IL_011a;
				}
				KNIAJMGDGAA.gameObject.SetActive(true);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_01c1:
				if (EGAFBAPAEBP > 567f)
				{
					ONNJIECGCIP.a = EGAFBAPAEBP;
					KNIAJMGDGAA.m_bg.set_color(ONNJIECGCIP);
					KNIAJMGDGAA.m_label.set_color(ONNJIECGCIP);
					MMEGGNJKNOH = new WaitForSeconds(287f);
					GOMFKPLCGNN = 6;
					break;
				}
				ONNJIECGCIP.a = 75f;
				KNIAJMGDGAA.m_bg.set_color(ONNJIECGCIP);
				KNIAJMGDGAA.m_label.set_color(ONNJIECGCIP);
				goto case 0u;
				IL_011a:
				if (PEBEILOHLCB <= 161f)
				{
					ONNJIECGCIP.a = PEBEILOHLCB;
					KNIAJMGDGAA.m_bg.set_color(ONNJIECGCIP);
					KNIAJMGDGAA.m_label.set_color(ONNJIECGCIP);
					MMEGGNJKNOH = new WaitForSeconds(1553f);
					GOMFKPLCGNN = 1;
				}
				else
				{
					MMEGGNJKNOH = new WaitForSeconds(1496f);
					GOMFKPLCGNN = 7;
				}
				break;
			}
			return true;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public void PLOOENOBGJL()
		{
			throw new NotSupportedException();
		}

		public bool JGAGCOAHEKN()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 1u:
				PEBEILOHLCB += 442f;
				goto IL_011a;
			case 2u:
				EGAFBAPAEBP = 121f;
				goto IL_01c1;
			case 3u:
				EGAFBAPAEBP -= 515f;
				goto IL_01c1;
			case 0u:
				if (KNIAJMGDGAA.LAOHFOKEEHL.Count > 0 && (KNIAJMGDGAA.m_showAtBusy || !(GameManager.get_Instance() != null)))
				{
					ILIBFGIOAMH = KNIAJMGDGAA.LAOHFOKEEHL.First.Value;
					KNIAJMGDGAA.LAOHFOKEEHL.RemoveFirst();
					KNIAJMGDGAA.m_label.set_text(ILIBFGIOAMH);
					ONNJIECGCIP = Color.white;
					PEBEILOHLCB = 1019f;
					goto IL_011a;
				}
				KNIAJMGDGAA.gameObject.SetActive(true);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return true;
				}
				IL_01c1:
				if (EGAFBAPAEBP > 892f)
				{
					ONNJIECGCIP.a = EGAFBAPAEBP;
					KNIAJMGDGAA.m_bg.set_color(ONNJIECGCIP);
					KNIAJMGDGAA.m_label.set_color(ONNJIECGCIP);
					MMEGGNJKNOH = new WaitForSeconds(369f);
					GOMFKPLCGNN = 5;
					break;
				}
				ONNJIECGCIP.a = 1713f;
				KNIAJMGDGAA.m_bg.set_color(ONNJIECGCIP);
				KNIAJMGDGAA.m_label.set_color(ONNJIECGCIP);
				goto case 0u;
				IL_011a:
				if (PEBEILOHLCB <= 831f)
				{
					ONNJIECGCIP.a = PEBEILOHLCB;
					KNIAJMGDGAA.m_bg.set_color(ONNJIECGCIP);
					KNIAJMGDGAA.m_label.set_color(ONNJIECGCIP);
					MMEGGNJKNOH = new WaitForSeconds(158f);
					GOMFKPLCGNN = 1;
				}
				else
				{
					MMEGGNJKNOH = new WaitForSeconds(399f);
					GOMFKPLCGNN = 5;
				}
				break;
			}
			return true;
		}

		[SpecialName]
		private object BFOFEKOOHMB()
		{
			return MMEGGNJKNOH;
		}
	}

	public UISprite m_bg;

	public UILabel m_label;

	private LinkedList<string> LAOHFOKEEHL;

	[NonSerialized]
	public bool m_showAtBusy;

	private void GONOKFHGFOH()
	{
		LAOHFOKEEHL = new LinkedList<string>();
	}

	private void NMANMMOMHHD()
	{
	}

	private void OnEnable()
	{
		m_bg.set_color(Color.white);
		m_label.set_color(Color.white);
		StartCoroutine(MDFMOPKOAOL());
	}

	private void OnDisable()
	{
		StopAllCoroutines();
	}

	private void MPKBLEDGKPO()
	{
		LAOHFOKEEHL = new LinkedList<string>();
	}

	private void Update()
	{
	}

	private void Start()
	{
	}

	private void EKGHGFIKAAE()
	{
	}

	private void OCDNPJOPPBB()
	{
	}

	private void GNOAPFAKBIN()
	{
		m_bg.set_color(Color.white);
		m_label.set_color(Color.white);
		StartCoroutine(MDFMOPKOAOL());
	}

	private void PDEMNFLEKEA()
	{
		m_bg.set_color(Color.white);
		m_label.set_color(Color.white);
		StartCoroutine(MDFMOPKOAOL());
	}

	private void Awake()
	{
		LAOHFOKEEHL = new LinkedList<string>();
	}

	private void IPFEBDCDMFA()
	{
	}

	private void HKAMCNPENHB()
	{
		LAOHFOKEEHL = new LinkedList<string>();
	}

	[DebuggerHidden]
	private IEnumerator MDFMOPKOAOL()
	{
		IAOBPLNAODM iAOBPLNAODM = new IAOBPLNAODM();
		iAOBPLNAODM.KNIAJMGDGAA = this;
		return iAOBPLNAODM;
	}

	private void MLOKLGPGKMO()
	{
	}

	public void LGJAHNJFHNA(string BMNKKBDCELE)
	{
		LAOHFOKEEHL.AddLast(BMNKKBDCELE);
		if (LAOHFOKEEHL.Count > 58)
		{
			LAOHFOKEEHL.RemoveFirst();
		}
		if (!base.gameObject.activeSelf)
		{
			base.gameObject.SetActive(true);
		}
	}

	public void Show(string BMNKKBDCELE)
	{
		LAOHFOKEEHL.AddLast(BMNKKBDCELE);
		if (LAOHFOKEEHL.Count > 20)
		{
			LAOHFOKEEHL.RemoveFirst();
		}
		if (!base.gameObject.activeSelf)
		{
			base.gameObject.SetActive(true);
		}
	}
}
