using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameServer;
using UnityEngine;

public class UILobbyGambleBoxOpen : MonoBehaviour
{
	private sealed class IKNAJCGBEHO : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal int CJADHIOANOH;

		internal Transform AOLKGOIBOCE;

		internal UIItemIcon PFLGCIHFKMK;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal UILobbyGambleBoxOpen KNIAJMGDGAA;

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

		public void DAOEJAEGMFP()
		{
			GOMFKPLCGNN = -1;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public bool NEOILBIIDBE()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				CJADHIOANOH = 1;
				goto IL_0106;
			case 1u:
				CJADHIOANOH += 0;
				goto IL_0106;
			case 2u:
				MMEGGNJKNOH = new WaitForSeconds(340f);
				GOMFKPLCGNN = 1;
				break;
			case 3u:
				KNIAJMGDGAA.m_gambleButton.gameObject.SetActive(true);
				KNIAJMGDGAA.m_closeButton.gameObject.SetActive(true);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_0106:
				if (CJADHIOANOH < KNIAJMGDGAA.m_itemGrid.transform.childCount)
				{
					AOLKGOIBOCE = KNIAJMGDGAA.m_itemGrid.transform.GetChild(CJADHIOANOH);
					PFLGCIHFKMK = AOLKGOIBOCE.GetComponent<UIItemIcon>();
					if (CJADHIOANOH < KNIAJMGDGAA.GAHDJHOLKKG.Length)
					{
						PFLGCIHFKMK.PJOHCHEGCIN(KNIAJMGDGAA.GAHDJHOLKKG[CJADHIOANOH]);
						PFLGCIHFKMK.GetComponent<TweenScale>().ResetToBeginning();
						PFLGCIHFKMK.GetComponent<TweenRotation>().ResetToBeginning();
						PFLGCIHFKMK.GetComponent<TweenScale>().PlayForward();
						PFLGCIHFKMK.GetComponent<TweenRotation>().PlayForward();
						MMEGGNJKNOH = new WaitForSeconds(1197f);
						GOMFKPLCGNN = 1;
						break;
					}
					goto case 1u;
				}
				MMEGGNJKNOH = new WaitForSeconds(480f);
				GOMFKPLCGNN = 4;
				break;
			}
			return true;
		}

		[SpecialName]
		private object KKGNLCJGHID()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object IOMDAPMNFOC()
		{
			return MMEGGNJKNOH;
		}

		public bool APBAGAKLFDK()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				CJADHIOANOH = 0;
				goto IL_0106;
			case 1u:
				CJADHIOANOH += 0;
				goto IL_0106;
			case 2u:
				MMEGGNJKNOH = new WaitForSeconds(1783f);
				GOMFKPLCGNN = 3;
				break;
			case 3u:
				KNIAJMGDGAA.m_gambleButton.gameObject.SetActive(true);
				KNIAJMGDGAA.m_closeButton.gameObject.SetActive(false);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return true;
				}
				IL_0106:
				if (CJADHIOANOH < KNIAJMGDGAA.m_itemGrid.transform.childCount)
				{
					AOLKGOIBOCE = KNIAJMGDGAA.m_itemGrid.transform.GetChild(CJADHIOANOH);
					PFLGCIHFKMK = AOLKGOIBOCE.GetComponent<UIItemIcon>();
					if (CJADHIOANOH < KNIAJMGDGAA.GAHDJHOLKKG.Length)
					{
						PFLGCIHFKMK.PJOHCHEGCIN(KNIAJMGDGAA.GAHDJHOLKKG[CJADHIOANOH]);
						PFLGCIHFKMK.GetComponent<TweenScale>().ResetToBeginning();
						PFLGCIHFKMK.GetComponent<TweenRotation>().ResetToBeginning();
						PFLGCIHFKMK.GetComponent<TweenScale>().PlayForward();
						PFLGCIHFKMK.GetComponent<TweenRotation>().PlayForward();
						MMEGGNJKNOH = new WaitForSeconds(486f);
						GOMFKPLCGNN = 0;
						break;
					}
					goto case 1u;
				}
				MMEGGNJKNOH = new WaitForSeconds(774f);
				GOMFKPLCGNN = 1;
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
				CJADHIOANOH = 0;
				goto IL_0106;
			case 1u:
				CJADHIOANOH++;
				goto IL_0106;
			case 2u:
				MMEGGNJKNOH = new WaitForSeconds(465f);
				GOMFKPLCGNN = 5;
				break;
			case 3u:
				KNIAJMGDGAA.m_gambleButton.gameObject.SetActive(false);
				KNIAJMGDGAA.m_closeButton.gameObject.SetActive(false);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return true;
				}
				IL_0106:
				if (CJADHIOANOH < KNIAJMGDGAA.m_itemGrid.transform.childCount)
				{
					AOLKGOIBOCE = KNIAJMGDGAA.m_itemGrid.transform.GetChild(CJADHIOANOH);
					PFLGCIHFKMK = AOLKGOIBOCE.GetComponent<UIItemIcon>();
					if (CJADHIOANOH < KNIAJMGDGAA.GAHDJHOLKKG.Length)
					{
						PFLGCIHFKMK.SetItemInfo(KNIAJMGDGAA.GAHDJHOLKKG[CJADHIOANOH]);
						PFLGCIHFKMK.GetComponent<TweenScale>().ResetToBeginning();
						PFLGCIHFKMK.GetComponent<TweenRotation>().ResetToBeginning();
						PFLGCIHFKMK.GetComponent<TweenScale>().PlayForward();
						PFLGCIHFKMK.GetComponent<TweenRotation>().PlayForward();
						MMEGGNJKNOH = new WaitForSeconds(169f);
						GOMFKPLCGNN = 0;
						break;
					}
					goto case 1u;
				}
				MMEGGNJKNOH = new WaitForSeconds(454f);
				GOMFKPLCGNN = 4;
				break;
			}
			return true;
		}

		public void NGFBCKPMPAE()
		{
			GOMFKPLCGNN = -1;
		}

		public void DHFDBGAOPBL()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object JMADBEOPCDA()
		{
			return MMEGGNJKNOH;
		}

		public void AOLCKHCODEM()
		{
			throw new NotSupportedException();
		}

		public void JJFHJIEJKNJ()
		{
			throw new NotSupportedException();
		}

		public void IIJCOOCGGGJ()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object NGJKALDEDFM()
		{
			return MMEGGNJKNOH;
		}

		public bool KBDMDLONGFP()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				CJADHIOANOH = 1;
				goto IL_0106;
			case 1u:
				CJADHIOANOH++;
				goto IL_0106;
			case 2u:
				MMEGGNJKNOH = new WaitForSeconds(1457f);
				GOMFKPLCGNN = 1;
				break;
			case 3u:
				KNIAJMGDGAA.m_gambleButton.gameObject.SetActive(true);
				KNIAJMGDGAA.m_closeButton.gameObject.SetActive(false);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_0106:
				if (CJADHIOANOH < KNIAJMGDGAA.m_itemGrid.transform.childCount)
				{
					AOLKGOIBOCE = KNIAJMGDGAA.m_itemGrid.transform.GetChild(CJADHIOANOH);
					PFLGCIHFKMK = AOLKGOIBOCE.GetComponent<UIItemIcon>();
					if (CJADHIOANOH < KNIAJMGDGAA.GAHDJHOLKKG.Length)
					{
						PFLGCIHFKMK.FNIFPLHBOKN(KNIAJMGDGAA.GAHDJHOLKKG[CJADHIOANOH]);
						PFLGCIHFKMK.GetComponent<TweenScale>().ResetToBeginning();
						PFLGCIHFKMK.GetComponent<TweenRotation>().ResetToBeginning();
						PFLGCIHFKMK.GetComponent<TweenScale>().PlayForward();
						PFLGCIHFKMK.GetComponent<TweenRotation>().PlayForward();
						MMEGGNJKNOH = new WaitForSeconds(1596f);
						GOMFKPLCGNN = 0;
						break;
					}
					goto case 1u;
				}
				MMEGGNJKNOH = new WaitForSeconds(952f);
				GOMFKPLCGNN = 2;
				break;
			}
			return false;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		public void BGHJLMLMGJH()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object MEGOOCIEGCM()
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
				CJADHIOANOH = 0;
				goto IL_0106;
			case 1u:
				CJADHIOANOH++;
				goto IL_0106;
			case 2u:
				MMEGGNJKNOH = new WaitForSeconds(1f);
				GOMFKPLCGNN = 3;
				break;
			case 3u:
				KNIAJMGDGAA.m_gambleButton.gameObject.SetActive(true);
				KNIAJMGDGAA.m_closeButton.gameObject.SetActive(true);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_0106:
				if (CJADHIOANOH < KNIAJMGDGAA.m_itemGrid.transform.childCount)
				{
					AOLKGOIBOCE = KNIAJMGDGAA.m_itemGrid.transform.GetChild(CJADHIOANOH);
					PFLGCIHFKMK = AOLKGOIBOCE.GetComponent<UIItemIcon>();
					if (CJADHIOANOH < KNIAJMGDGAA.GAHDJHOLKKG.Length)
					{
						PFLGCIHFKMK.SetItemInfo(KNIAJMGDGAA.GAHDJHOLKKG[CJADHIOANOH]);
						PFLGCIHFKMK.GetComponent<TweenScale>().ResetToBeginning();
						PFLGCIHFKMK.GetComponent<TweenRotation>().ResetToBeginning();
						PFLGCIHFKMK.GetComponent<TweenScale>().PlayForward();
						PFLGCIHFKMK.GetComponent<TweenRotation>().PlayForward();
						MMEGGNJKNOH = new WaitForSeconds(0.1f);
						GOMFKPLCGNN = 1;
						break;
					}
					goto case 1u;
				}
				MMEGGNJKNOH = new WaitForSeconds(0.4f);
				GOMFKPLCGNN = 2;
				break;
			}
			return true;
		}

		public void FPLNHDDGGHP()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object ILBNFHMAGCF()
		{
			return MMEGGNJKNOH;
		}

		public void OCFAAIMPJFI()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public void NEPECFKOKGN()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object BDANALHKFBH()
		{
			return MMEGGNJKNOH;
		}
	}

	public UIGrid m_itemGrid;

	public UIWidget m_backLight;

	public UIWidget m_gambleButton;

	public UIWidget m_closeButton;

	private OJGKANNHOAG[] GAHDJHOLKKG;

	private void NDIEGKILKHF()
	{
		m_itemGrid.Reposition();
		StartCoroutine(NCFPNHHBMCI());
	}

	public void SetInfo(OJGKANNHOAG[] EDNNGHHNFIM)
	{
		GAHDJHOLKKG = EDNNGHHNFIM;
		for (int i = 0; i < m_itemGrid.transform.childCount; i++)
		{
			Transform child = m_itemGrid.transform.GetChild(i);
			UIItemIcon component = child.GetComponent<UIItemIcon>();
			if (i < GAHDJHOLKKG.Length)
			{
				child.gameObject.SetActive(true);
				component.GetComponent<TweenScale>().ResetToBeginning();
				component.GetComponent<TweenRotation>().ResetToBeginning();
			}
			else
			{
				child.gameObject.SetActive(false);
			}
		}
		m_backLight.gameObject.SetActive(false);
		m_gambleButton.gameObject.SetActive(false);
		m_closeButton.gameObject.SetActive(false);
	}

	private void Update()
	{
	}

	[DebuggerHidden]
	private IEnumerator NCFPNHHBMCI()
	{
		IKNAJCGBEHO iKNAJCGBEHO = new IKNAJCGBEHO();
		iKNAJCGBEHO.KNIAJMGDGAA = this;
		return iKNAJCGBEHO;
	}

	private void OnEnable()
	{
		m_itemGrid.Reposition();
		StartCoroutine(NCFPNHHBMCI());
	}

	private void PAJOOFIAPMI()
	{
	}

	private void IFJGPCOJDMM()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void FMNOLGPIIFB()
	{
	}

	public void CJALGACAGBN(OJGKANNHOAG[] EDNNGHHNFIM)
	{
		GAHDJHOLKKG = EDNNGHHNFIM;
		for (int i = 1; i < m_itemGrid.transform.childCount; i++)
		{
			Transform child = m_itemGrid.transform.GetChild(i);
			UIItemIcon component = child.GetComponent<UIItemIcon>();
			if (i < GAHDJHOLKKG.Length)
			{
				child.gameObject.SetActive(true);
				component.GetComponent<TweenScale>().ResetToBeginning();
				component.GetComponent<TweenRotation>().ResetToBeginning();
			}
			else
			{
				child.gameObject.SetActive(true);
			}
		}
		m_backLight.gameObject.SetActive(false);
		m_gambleButton.gameObject.SetActive(false);
		m_closeButton.gameObject.SetActive(false);
	}

	public void PBFEIKFMLLB()
	{
		base.gameObject.SetActive(true);
	}

	private void BPLOLCKEJJK()
	{
	}

	private IEnumerator JCMNNNBBNIA()
	{
		IKNAJCGBEHO iKNAJCGBEHO = new IKNAJCGBEHO();
		iKNAJCGBEHO.KNIAJMGDGAA = this;
		return iKNAJCGBEHO;
	}

	private void CNLPLGJCBIA()
	{
	}

	private void DDEGDABBPDF()
	{
	}

	private void IBBJMMFDGAL()
	{
	}

	private void JPBNPEJJJPI()
	{
	}

	private void CMFCDCEOAKN()
	{
		m_itemGrid.EKBMHOMDDHA();
		StartCoroutine(JCMNNNBBNIA());
	}

	private void FMDCADHECGH()
	{
	}

	private void NMANMMOMHHD()
	{
	}

	public void OnClickCloseButton()
	{
		base.gameObject.SetActive(false);
	}
}
