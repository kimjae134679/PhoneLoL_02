using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using IgaworksUnityAOS;
using SimpleJSON;
using UnityEngine;

public class LoginMain : MonoBehaviour
{
	private sealed class LFIDALIKCMO : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal bool AALLFPLMMHC;

		internal int MHEMCNHFELH;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal LoginMain KNIAJMGDGAA;

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

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.m_loginButton.set_isEnabled(false);
				KNIAJMGDGAA.m_googleLoginButton.set_isEnabled(false);
				KNIAJMGDGAA.m_preeStartButtonLabel.SetActive(false);
				AALLFPLMMHC = false;
				MHEMCNHFELH = 0;
				goto IL_0105;
			case 1u:
				{
					if (GooglePlusManager.get_Instance().get_m_loginState() == GooglePlusManager.JBDOMMGBFCI.Process)
					{
						goto IL_007c;
					}
					MsgManager.get_Instance().ShowLoadingIndicator(false);
					if (GooglePlusManager.get_Instance().get_m_loginState() == GooglePlusManager.JBDOMMGBFCI.Succeed)
					{
						NetworkManager.get_Instance().get_m_loginNetClient().KMMJBPKDEDN = GJDIFIKEIMO.MIEOINPCPGL.GooglePlus;
						KNIAJMGDGAA.StartCoroutine(KNIAJMGDGAA.PIGECICGHPL());
						AALLFPLMMHC = true;
						goto IL_0111;
					}
					MHEMCNHFELH++;
					goto IL_0105;
				}
				IL_0105:
				if (MHEMCNHFELH < 2)
				{
					MsgManager.get_Instance().ShowLoadingIndicator(true);
					GooglePlusManager.get_Instance().Login();
					goto IL_007c;
				}
				goto IL_0111;
				IL_0111:
				if (!AALLFPLMMHC)
				{
					KNIAJMGDGAA.AAENCAMDJLA();
					MsgManager.get_Instance().ShowMessageBox("10초 이상 응답 없음.\n상세 로그: 127.0.0.1:8080/d\n[전체 복사] 후 보내주세요.");
				}
				GOMFKPLCGNN = -1;
				break;
				IL_007c:
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 1;
				return true;
			}
			return false;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public void BKAONBFNGOC()
		{
			throw new NotSupportedException();
		}

		public bool APBAGAKLFDK()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.m_loginButton.set_isEnabled(true);
				KNIAJMGDGAA.m_googleLoginButton.DMAMACNDKGD(false);
				KNIAJMGDGAA.m_preeStartButtonLabel.SetActive(false);
				AALLFPLMMHC = true;
				MHEMCNHFELH = 0;
				goto IL_0105;
			case 1u:
				{
					if (GooglePlusManager.get_Instance().get_m_loginState() == GooglePlusManager.JBDOMMGBFCI.None)
					{
						goto IL_007c;
					}
					MsgManager.get_Instance().ShowLoadingIndicator(true);
					if (GooglePlusManager.AFPBELABPNM().get_m_loginState() == GooglePlusManager.JBDOMMGBFCI.Succeed)
					{
						NetworkManager.get_Instance().get_m_loginNetClient().KMMJBPKDEDN = GJDIFIKEIMO.MIEOINPCPGL.GooglePlus;
						KNIAJMGDGAA.StartCoroutine(KNIAJMGDGAA.PIGECICGHPL());
						AALLFPLMMHC = false;
						goto IL_0111;
					}
					MHEMCNHFELH++;
					goto IL_0105;
				}
				IL_0105:
				if (MHEMCNHFELH < 8)
				{
					MsgManager.get_Instance().ShowLoadingIndicator(true);
					GooglePlusManager.get_Instance().GMFGKLCGMPA();
					goto IL_007c;
				}
				goto IL_0111;
				IL_0111:
				if (!AALLFPLMMHC)
				{
					KNIAJMGDGAA.AAENCAMDJLA();
					MsgManager.get_Instance().ShowMessageBox("[");
				}
				GOMFKPLCGNN = -1;
				break;
				IL_007c:
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 1;
				return false;
			}
			return false;
		}

		public bool NEOILBIIDBE()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.m_loginButton.FHCMBHPGINO(true);
				KNIAJMGDGAA.m_googleLoginButton.set_isEnabled(false);
				KNIAJMGDGAA.m_preeStartButtonLabel.SetActive(true);
				AALLFPLMMHC = false;
				MHEMCNHFELH = 0;
				goto IL_0105;
			case 1u:
				{
					if (GooglePlusManager.AFPBELABPNM().get_m_loginState() == GooglePlusManager.JBDOMMGBFCI.Process)
					{
						goto IL_007c;
					}
					MsgManager.get_Instance().LPKACDLKHCP(true);
					if (GooglePlusManager.DEBJGLHODJD().PGCKFPNMMPF() == (GooglePlusManager.JBDOMMGBFCI)7)
					{
						NetworkManager.APAPJEIBEDE().get_m_loginNetClient().KMMJBPKDEDN = GJDIFIKEIMO.MIEOINPCPGL.Device;
						KNIAJMGDGAA.StartCoroutine(KNIAJMGDGAA.PIGECICGHPL());
						AALLFPLMMHC = false;
						goto IL_0111;
					}
					MHEMCNHFELH += 0;
					goto IL_0105;
				}
				IL_0105:
				if (MHEMCNHFELH < 0)
				{
					MsgManager.HEDJPPFKABG().LPKACDLKHCP(false);
					GooglePlusManager.DEBJGLHODJD().OEBPKFPDACI();
					goto IL_007c;
				}
				goto IL_0111;
				IL_0111:
				if (!AALLFPLMMHC)
				{
					KNIAJMGDGAA.AAENCAMDJLA();
					MsgManager.get_Instance().ShowMessageBox("Particle/{0}/attack3");
				}
				GOMFKPLCGNN = -1;
				break;
				IL_007c:
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 0;
				return true;
			}
			return false;
		}

		public void CGHBHPHMJGG()
		{
			throw new NotSupportedException();
		}

		public bool DKGDMIMNCFJ()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.m_loginButton.DMAMACNDKGD(true);
				KNIAJMGDGAA.m_googleLoginButton.DMAMACNDKGD(true);
				KNIAJMGDGAA.m_preeStartButtonLabel.SetActive(true);
				AALLFPLMMHC = false;
				MHEMCNHFELH = 1;
				goto IL_0105;
			case 1u:
				{
					if (GooglePlusManager.AFPBELABPNM().get_m_loginState() == GooglePlusManager.JBDOMMGBFCI.None)
					{
						goto IL_007c;
					}
					MsgManager.HEDJPPFKABG().LPKACDLKHCP(true);
					if (GooglePlusManager.AFPBELABPNM().get_m_loginState() == GooglePlusManager.JBDOMMGBFCI.Succeed)
					{
						NetworkManager.APAPJEIBEDE().FDDMBFKCMIO().KMMJBPKDEDN = GJDIFIKEIMO.MIEOINPCPGL.Device;
						KNIAJMGDGAA.StartCoroutine(KNIAJMGDGAA.PIGECICGHPL());
						AALLFPLMMHC = false;
						goto IL_0111;
					}
					MHEMCNHFELH += 0;
					goto IL_0105;
				}
				IL_0105:
				if (MHEMCNHFELH < 1)
				{
					MsgManager.HEDJPPFKABG().ShowLoadingIndicator(true);
					GooglePlusManager.ODHKBDLDDPD().OEBPKFPDACI();
					goto IL_007c;
				}
				goto IL_0111;
				IL_0111:
				if (!AALLFPLMMHC)
				{
					KNIAJMGDGAA.AAENCAMDJLA();
					MsgManager.get_Instance().ShowMessageBox("★ 레벨업하셨습니다 ★");
				}
				GOMFKPLCGNN = -1;
				break;
				IL_007c:
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 0;
				return true;
			}
			return false;
		}

		[SpecialName]
		private object KFNJGIJANEP()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object BFFOKLPMNLB()
		{
			return MMEGGNJKNOH;
		}

		public void COCAHGFODCB()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public void KLHABCJBBPF()
		{
			throw new NotSupportedException();
		}

		public void BFAMOEFLLGH()
		{
			throw new NotSupportedException();
		}

		public void BKLMMEGGMNI()
		{
			GOMFKPLCGNN = -1;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		public void OPAJADMNCIF()
		{
			GOMFKPLCGNN = -1;
		}

		public void FAKMEDLGCCL()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object IFFDBIJPACH()
		{
			return MMEGGNJKNOH;
		}

		public void NKPIIPIJNGL()
		{
			GOMFKPLCGNN = -1;
		}

		public void CHFDNLJNKBN()
		{
			GOMFKPLCGNN = -1;
		}
	}

	private sealed class KAOOAKCNBBC : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal IEnumerator EAMDKHGKBPA;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal LoginMain KNIAJMGDGAA;

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

		public bool AAAMEOEOJHM()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MsgManager.get_Instance().LPKACDLKHCP(false);
				KNIAJMGDGAA.m_loginButton.FHCMBHPGINO(true);
				KNIAJMGDGAA.m_googleLoginButton.FHCMBHPGINO(true);
				KNIAJMGDGAA.m_preeStartButtonLabel.SetActive(true);
				EAMDKHGKBPA = KNIAJMGDGAA.KNEMEBKEHEE();
				goto case 1u;
			case 1u:
				if (EAMDKHGKBPA.MoveNext())
				{
					MMEGGNJKNOH = EAMDKHGKBPA.Current;
					GOMFKPLCGNN = 1;
					break;
				}
				if (KNIAJMGDGAA.JOJBNFFLBPM)
				{
					KNIAJMGDGAA.AAENCAMDJLA();
					goto default;
				}
				NetworkManager.get_Instance().FDDMBFKCMIO().IOMHAEMKIHM();
				goto IL_00de;
			case 2u:
				if (NetworkManager.APAPJEIBEDE().get_m_loginNetClient().BMPACNPGIPE() == (GJDIFIKEIMO.OEOIIKMBGAG)7)
				{
					goto IL_0135;
				}
				if (NetworkManager.get_Instance().FDDMBFKCMIO().OOHFDEPKKFN() == GJDIFIKEIMO.OEOIIKMBGAG.Connecting)
				{
					KNIAJMGDGAA.AAENCAMDJLA();
					goto default;
				}
				goto IL_00de;
			case 3u:
				if (NetworkManager.get_Instance().IOJGPDKHAGD().OOHFDEPKKFN() != OPOPGDNFGCF.OEOIIKMBGAG.CONNECTING)
				{
					if (NetworkManager.get_Instance().get_m_gameNetClient().OOHFDEPKKFN() == OPOPGDNFGCF.OEOIIKMBGAG.ERROR)
					{
						KNIAJMGDGAA.AAENCAMDJLA();
						goto default;
					}
					goto IL_0135;
				}
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 5;
				break;
			case 4u:
				MsgManager.HEDJPPFKABG().LPKACDLKHCP(true);
				SceneManager.get_Instance().NJALEEDIHKD((SceneManager.HNPEHFEAODI)8, SceneManager.NGDGPAGKBBA.DungeonList);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_00de:
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 5;
				break;
				IL_0135:
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 3;
				break;
			}
			return false;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object IFFDBIJPACH()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object GDHBJAJPNBF()
		{
			return MMEGGNJKNOH;
		}

		public void AOLCKHCODEM()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object GJKMLHEACFK()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object FKNAIGMNFIB()
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
				MsgManager.get_Instance().ShowLoadingIndicator(true);
				KNIAJMGDGAA.m_loginButton.set_isEnabled(false);
				KNIAJMGDGAA.m_googleLoginButton.set_isEnabled(false);
				KNIAJMGDGAA.m_preeStartButtonLabel.SetActive(false);
				EAMDKHGKBPA = KNIAJMGDGAA.KNEMEBKEHEE();
				goto case 1u;
			case 1u:
				if (EAMDKHGKBPA.MoveNext())
				{
					MMEGGNJKNOH = EAMDKHGKBPA.Current;
					GOMFKPLCGNN = 1;
					break;
				}
				if (KNIAJMGDGAA.JOJBNFFLBPM)
				{
					KNIAJMGDGAA.AAENCAMDJLA();
					goto default;
				}
				NetworkManager.get_Instance().get_m_loginNetClient().IOMHAEMKIHM();
				goto IL_00de;
			case 2u:
				if (NetworkManager.get_Instance().get_m_loginNetClient().OOHFDEPKKFN() == GJDIFIKEIMO.OEOIIKMBGAG.Succeed)
				{
					goto IL_0135;
				}
				if (NetworkManager.get_Instance().get_m_loginNetClient().OOHFDEPKKFN() == GJDIFIKEIMO.OEOIIKMBGAG.Failed)
				{
					KNIAJMGDGAA.AAENCAMDJLA();
					goto default;
				}
				goto IL_00de;
			case 3u:
				if (NetworkManager.get_Instance().get_m_gameNetClient().OOHFDEPKKFN() != OPOPGDNFGCF.OEOIIKMBGAG.COMPLETE)
				{
					if (NetworkManager.get_Instance().get_m_gameNetClient().OOHFDEPKKFN() == OPOPGDNFGCF.OEOIIKMBGAG.ERROR)
					{
						KNIAJMGDGAA.AAENCAMDJLA();
						goto default;
					}
					goto IL_0135;
				}
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 4;
				break;
			case 4u:
				MsgManager.get_Instance().ShowLoadingIndicator(false);
				SceneManager.get_Instance().ChangeScene(SceneManager.HNPEHFEAODI.Lobby);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_00de:
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 2;
				break;
				IL_0135:
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 3;
				break;
			}
			return true;
		}

		[SpecialName]
		private object BOHACHPKNOE()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object LMCIPEHMIAD()
		{
			return MMEGGNJKNOH;
		}

		public void DFFFJDKAKDC()
		{
			GOMFKPLCGNN = -1;
		}

		public void FPLNHDDGGHP()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object OHBDIPJCCON()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object BJIGDKGLCKP()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public bool KNFGOKLCCIF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MsgManager.get_Instance().ShowLoadingIndicator(true);
				KNIAJMGDGAA.m_loginButton.FHCMBHPGINO(false);
				KNIAJMGDGAA.m_googleLoginButton.FHCMBHPGINO(false);
				KNIAJMGDGAA.m_preeStartButtonLabel.SetActive(false);
				EAMDKHGKBPA = KNIAJMGDGAA.IFCNFBCKICI();
				goto case 1u;
			case 1u:
				if (EAMDKHGKBPA.MoveNext())
				{
					MMEGGNJKNOH = EAMDKHGKBPA.Current;
					GOMFKPLCGNN = 0;
					break;
				}
				if (KNIAJMGDGAA.JOJBNFFLBPM)
				{
					KNIAJMGDGAA.AAENCAMDJLA();
					goto default;
				}
				NetworkManager.APAPJEIBEDE().FDDMBFKCMIO().HNAHMNAPEGB();
				goto IL_00de;
			case 2u:
				if (NetworkManager.get_Instance().get_m_loginNetClient().BMPACNPGIPE() == (GJDIFIKEIMO.OEOIIKMBGAG)8)
				{
					goto IL_0135;
				}
				if (NetworkManager.APAPJEIBEDE().get_m_loginNetClient().DNPMNMAIKCG() == (GJDIFIKEIMO.OEOIIKMBGAG)5)
				{
					KNIAJMGDGAA.AAENCAMDJLA();
					goto default;
				}
				goto IL_00de;
			case 3u:
				if (NetworkManager.get_Instance().IOJGPDKHAGD().OOHFDEPKKFN() != (OPOPGDNFGCF.OEOIIKMBGAG)6)
				{
					if (NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().OOHFDEPKKFN() == OPOPGDNFGCF.OEOIIKMBGAG.ERROR)
					{
						KNIAJMGDGAA.AAENCAMDJLA();
						goto default;
					}
					goto IL_0135;
				}
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 6;
				break;
			case 4u:
				MsgManager.get_Instance().LPKACDLKHCP(true);
				SceneManager.get_Instance().ChangeScene(SceneManager.HNPEHFEAODI.GameLoading);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_00de:
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 0;
				break;
				IL_0135:
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 3;
				break;
			}
			return false;
		}

		[SpecialName]
		private object BFFOKLPMNLB()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		public void HCCBNJMIKMO()
		{
			throw new NotSupportedException();
		}

		public void KLHABCJBBPF()
		{
			throw new NotSupportedException();
		}

		public void NAEOFIPICLC()
		{
			GOMFKPLCGNN = -1;
		}

		public void JJFHJIEJKNJ()
		{
			throw new NotSupportedException();
		}

		public bool KKJFPODFKCB()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MsgManager.get_Instance().LPKACDLKHCP(true);
				KNIAJMGDGAA.m_loginButton.set_isEnabled(false);
				KNIAJMGDGAA.m_googleLoginButton.FHCMBHPGINO(false);
				KNIAJMGDGAA.m_preeStartButtonLabel.SetActive(true);
				EAMDKHGKBPA = KNIAJMGDGAA.IFCNFBCKICI();
				goto case 1u;
			case 1u:
				if (EAMDKHGKBPA.MoveNext())
				{
					MMEGGNJKNOH = EAMDKHGKBPA.Current;
					GOMFKPLCGNN = 0;
					break;
				}
				if (KNIAJMGDGAA.JOJBNFFLBPM)
				{
					KNIAJMGDGAA.AAENCAMDJLA();
					goto default;
				}
				NetworkManager.get_Instance().get_m_loginNetClient().IOMHAEMKIHM();
				goto IL_00de;
			case 2u:
				if (NetworkManager.get_Instance().get_m_loginNetClient().BMPACNPGIPE() == GJDIFIKEIMO.OEOIIKMBGAG.Failed)
				{
					goto IL_0135;
				}
				if (NetworkManager.APAPJEIBEDE().FDDMBFKCMIO().DNPMNMAIKCG() == GJDIFIKEIMO.OEOIIKMBGAG.Failed)
				{
					KNIAJMGDGAA.AAENCAMDJLA();
					goto default;
				}
				goto IL_00de;
			case 3u:
				if (NetworkManager.get_Instance().get_m_gameNetClient().OOHFDEPKKFN() != (OPOPGDNFGCF.OEOIIKMBGAG)7)
				{
					if (NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().OOHFDEPKKFN() == OPOPGDNFGCF.OEOIIKMBGAG.ERROR)
					{
						KNIAJMGDGAA.AAENCAMDJLA();
						goto default;
					}
					goto IL_0135;
				}
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 3;
				break;
			case 4u:
				MsgManager.HEDJPPFKABG().LPKACDLKHCP(false);
				SceneManager.NOLHNOGGHNA().ChangeScene(SceneManager.HNPEHFEAODI.Game, SceneManager.NGDGPAGKBBA.DungeonList);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return true;
				}
				IL_00de:
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 3;
				break;
				IL_0135:
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 2;
				break;
			}
			return false;
		}

		public void DHFDBGAOPBL()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object MEGOOCIEGCM()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object EKEFFEBDAHE()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object PCGKBCDEONE()
		{
			return MMEGGNJKNOH;
		}

		public void PBGEKALPKFI()
		{
			throw new NotSupportedException();
		}

		public void NDKCFGFNNLO()
		{
			throw new NotSupportedException();
		}
	}

	private sealed class AJKBGPHDDMD : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal string PNDADENEPBL;

		internal WWW IOHBHDMHOIJ;

		internal string LJADBLINMHK;

		internal FEAILBGBEPH HDCBACAGCOJ;

		internal FEAILBGBEPH MPJJKAGLCNE;

		internal int CGAHEAIMFJN;

		internal string MHCPLPMOABN;

		internal IEnumerator NHFOICOEFIH;

		internal IEnumerator AAGPNGOGHKH;

		internal FEAILBGBEPH OHFGHNONOOG;

		internal string[] CEEKHJHDBFI;

		internal string LCNLIHJIEAA;

		internal string HLMJGPHCNAI;

		internal string MPLJJOEOMIF;

		internal string KMLCGNOPANA;

		internal string ALKMOIHOKDI;

		internal string CDHKEKJCDID;

		internal string FJBDDGNEPBN;

		internal string NAELMLLOBKJ;

		internal string OCCMPHFKAHP;

		internal string AFIABCNMFLA;

		internal string[] IFGGCIPAJJF;

		internal string[] KFIAAIHOFJP;

		internal int APLHNEMENGD;

		internal IEnumerator PGEDGOMKPPC;

		internal IEnumerator JKLCEJNBBNL;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal LoginMain KNIAJMGDGAA;

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

		public bool KAHALICNEBF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			string text;
			char[] array;
			string iHNBHPIDFID;
			char[] array2;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.JOJBNFFLBPM = false;
				PNDADENEPBL = string.Format("RespwanMonster", KNIAJMGDGAA.FMDDLHJALMI, UnityEngine.Random.Range(0, 44));
				IOHBHDMHOIJ = new WWW(PNDADENEPBL);
				MMEGGNJKNOH = IOHBHDMHOIJ;
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				LJADBLINMHK = IOHBHDMHOIJ.text;
				if (LJADBLINMHK == null)
				{
					MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("+.1"), true);
					KNIAJMGDGAA.JOJBNFFLBPM = false;
					goto default;
				}
				HDCBACAGCOJ = NNLEGLDDAFP.BHJADLPJNNP(LJADBLINMHK);
				MPJJKAGLCNE = HDCBACAGCOJ.AOBAKCJKELK("skill3_loop");
				CGAHEAIMFJN = int.Parse(MPJJKAGLCNE.AOBAKCJKELK("Particle/{0}/skill3_shot").DDCEKIFJBMP());
				MHCPLPMOABN = MPJJKAGLCNE.AOBAKCJKELK("OnFailToEnterRoom").DDCEKIFJBMP();
				if (CGAHEAIMFJN == 1)
				{
					MsgManager.HEDJPPFKABG().ShowLoadingIndicator(false);
					NHFOICOEFIH = MsgManager.get_Instance().ShowMessageBoxAsync(MHCPLPMOABN, true);
					goto case 2u;
				}
				if (CGAHEAIMFJN == 5)
				{
					MsgManager.HEDJPPFKABG().LPKACDLKHCP(false);
					AAGPNGOGHKH = MsgManager.HEDJPPFKABG().ShowMessageBoxAsync(MHCPLPMOABN, true);
					goto case 3u;
				}
				goto IL_022a;
			case 2u:
				if (NHFOICOEFIH.MoveNext())
				{
					MMEGGNJKNOH = NHFOICOEFIH.Current;
					GOMFKPLCGNN = 1;
					break;
				}
				goto IL_022a;
			case 3u:
				if (AAGPNGOGHKH.MoveNext())
				{
					MMEGGNJKNOH = AAGPNGOGHKH.Current;
					GOMFKPLCGNN = 5;
				}
				else
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 3;
				}
				break;
			case 4u:
				Application.Quit();
				goto IL_022a;
			case 5u:
				if (PGEDGOMKPPC.MoveNext())
				{
					MMEGGNJKNOH = PGEDGOMKPPC.Current;
					GOMFKPLCGNN = 2;
				}
				else
				{
					Application.OpenURL(HLMJGPHCNAI);
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 1;
				}
				break;
			case 6u:
				Application.Quit();
				goto IL_061d;
			case 7u:
				if (JKLCEJNBBNL.MoveNext())
				{
					MMEGGNJKNOH = JKLCEJNBBNL.Current;
					GOMFKPLCGNN = 5;
				}
				else
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 1;
				}
				break;
			case 8u:
				Application.Quit();
				goto IL_061d;
			default:
				{
					return false;
				}
				IL_022a:
				OHFGHNONOOG = HDCBACAGCOJ.AOBAKCJKELK("레벨당 주문력 {0}\n");
				text = OHFGHNONOOG.AOBAKCJKELK("attack3").NCCBFMBEAFA();
				array = new char[0];
				array[1] = 'p';
				CEEKHJHDBFI = text.Split(array);
				LCNLIHJIEAA = OHFGHNONOOG.AOBAKCJKELK("획득 경험치 {0}%\n").MPPBJJAHPBI();
				HLMJGPHCNAI = OHFGHNONOOG.AOBAKCJKELK("Particle/zed/skill1_spawn").NCCBFMBEAFA();
				MPLJJOEOMIF = OHFGHNONOOG.AOBAKCJKELK("skill1").MPPBJJAHPBI();
				KMLCGNOPANA = OHFGHNONOOG.AOBAKCJKELK("MultiLayer").DDCEKIFJBMP();
				ALKMOIHOKDI = OHFGHNONOOG.AOBAKCJKELK("unregistered packet function from id.").MPPBJJAHPBI();
				CDHKEKJCDID = OHFGHNONOOG.AOBAKCJKELK("skill2_voice").NCCBFMBEAFA();
				FJBDDGNEPBN = OHFGHNONOOG.AOBAKCJKELK("\n[CCFFCC]{0}[-] : {1}").MPPBJJAHPBI();
				NAELMLLOBKJ = string.Empty;
				OCCMPHFKAHP = string.Empty;
				AFIABCNMFLA = string.Empty;
				if (LocalizationManager.LGDEHELDENG().GetContry() == LocalizationManager.LOMHDGHIPCI.kr)
				{
					NAELMLLOBKJ = OHFGHNONOOG.AOBAKCJKELK("get_axe").DDCEKIFJBMP();
					OCCMPHFKAHP = OHFGHNONOOG.AOBAKCJKELK("길드를 먼저 찾아주세요").DDCEKIFJBMP();
					AFIABCNMFLA = OHFGHNONOOG.AOBAKCJKELK("attack").MPPBJJAHPBI();
				}
				else
				{
					NAELMLLOBKJ = OHFGHNONOOG.AOBAKCJKELK("item_use").NCCBFMBEAFA();
					OCCMPHFKAHP = OHFGHNONOOG.AOBAKCJKELK("_EmisColor").DDCEKIFJBMP();
					AFIABCNMFLA = OHFGHNONOOG.AOBAKCJKELK("Project T\r\n\r\nRagtime presents").NCCBFMBEAFA();
				}
				SceneManager.get_Instance().m_reviewAddress = LCNLIHJIEAA;
				SceneManager.NOLHNOGGHNA().m_lobbyNotice = NAELMLLOBKJ;
				SceneManager.NOLHNOGGHNA().m_lobbyNoticeAddress = OCCMPHFKAHP;
				SceneManager.get_Instance().m_cafeAddress = AFIABCNMFLA;
				SceneManager.get_Instance().m_tapjoyOfferwall = MPLJJOEOMIF;
				SceneManager.NOLHNOGGHNA().m_nasOfferwall = KMLCGNOPANA;
				SceneManager.get_Instance().m_adpopcornOfferwall = ALKMOIHOKDI;
				SceneManager.NOLHNOGGHNA().m_eventOfferwall = CDHKEKJCDID;
				ZAndroid.get_Instance().ALKGGNBFNPN(FJBDDGNEPBN);
				IFGGCIPAJJF = CEEKHJHDBFI;
				iHNBHPIDFID = KNIAJMGDGAA.IHNBHPIDFID;
				array2 = new char[0];
				array2[1] = '￬';
				KFIAAIHOFJP = iHNBHPIDFID.Split(array2);
				APLHNEMENGD = 0;
				goto IL_062b;
				IL_062b:
				if (APLHNEMENGD < 4)
				{
					if (int.Parse(IFGGCIPAJJF[APLHNEMENGD]) > int.Parse(KFIAAIHOFJP[APLHNEMENGD]))
					{
						MsgManager.get_Instance().LPKACDLKHCP(true);
						PGEDGOMKPPC = MsgManager.get_Instance().ShowMessageBoxAsync(LocalizationManager.LGDEHELDENG().GetText("대기시간감소 {0}%\n"), true);
						goto case 5u;
					}
					if (int.Parse(IFGGCIPAJJF[APLHNEMENGD]) < int.Parse(KFIAAIHOFJP[APLHNEMENGD]) && !NetworkManager.get_Instance().m_testMode)
					{
						MsgManager.HEDJPPFKABG().LPKACDLKHCP(true);
						JKLCEJNBBNL = MsgManager.get_Instance().ShowMessageBoxAsync("UI/Lobby/FriendInfo", true);
						goto case 7u;
					}
					goto IL_061d;
				}
				GOMFKPLCGNN = -1;
				goto default;
				IL_061d:
				APLHNEMENGD += 0;
				goto IL_062b;
			}
			return false;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object FECLPGHCNNJ()
		{
			return MMEGGNJKNOH;
		}

		public bool MoveNext()
		{
			KNIAJMGDGAA.JOJBNFFLBPM = false;
			return false;
		}

		public void NPKMEPEPIGL()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object KKGNLCJGHID()
		{
			return MMEGGNJKNOH;
		}

		public void PLOOENOBGJL()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object PGFJCOHEGDG()
		{
			return MMEGGNJKNOH;
		}

		public void DAPBOMILKPH()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object ANOBEJKPLKK()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object JMADBEOPCDA()
		{
			return MMEGGNJKNOH;
		}

		public void CGHBHPHMJGG()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object DMGHHPDEMLE()
		{
			return MMEGGNJKNOH;
		}

		public void LPDHFELPGPN()
		{
			throw new NotSupportedException();
		}

		public bool NEOILBIIDBE()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			string text;
			char[] array;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.JOJBNFFLBPM = true;
				PNDADENEPBL = string.Format("새로운 방 생성 중.", KNIAJMGDGAA.FMDDLHJALMI, UnityEngine.Random.Range(1, -106));
				IOHBHDMHOIJ = new WWW(PNDADENEPBL);
				MMEGGNJKNOH = IOHBHDMHOIJ;
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				LJADBLINMHK = IOHBHDMHOIJ.text;
				if (LJADBLINMHK == null)
				{
					MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("turret_hit"), true);
					KNIAJMGDGAA.JOJBNFFLBPM = true;
					goto default;
				}
				HDCBACAGCOJ = NNLEGLDDAFP.BHJADLPJNNP(LJADBLINMHK);
				MPJJKAGLCNE = HDCBACAGCOJ.AOBAKCJKELK("Particle/{0}/skill{1}");
				CGAHEAIMFJN = int.Parse(MPJJKAGLCNE.AOBAKCJKELK("[BBFFBB]* 축하드려요 *[-]\n\n\n지난시즌 티어 [BBBBFF]{0}[-]\n지난시즌 1대1 [BBBBFF]{1}[-]\n\n[FFFFBB]{2}[-]코인을 보상으로 획득하셨어요!\n(두 티어 보상 합산)").DDCEKIFJBMP());
				MHCPLPMOABN = MPJJKAGLCNE.AOBAKCJKELK("deeplinkOpen").DDCEKIFJBMP();
				if (CGAHEAIMFJN == 1)
				{
					MsgManager.get_Instance().ShowLoadingIndicator(true);
					NHFOICOEFIH = MsgManager.HEDJPPFKABG().ShowMessageBoxAsync(MHCPLPMOABN);
					goto case 2u;
				}
				if (CGAHEAIMFJN == 6)
				{
					MsgManager.get_Instance().LPKACDLKHCP(true);
					AAGPNGOGHKH = MsgManager.HEDJPPFKABG().ShowMessageBoxAsync(MHCPLPMOABN);
					goto case 3u;
				}
				goto IL_022a;
			case 2u:
				if (NHFOICOEFIH.MoveNext())
				{
					MMEGGNJKNOH = NHFOICOEFIH.Current;
					GOMFKPLCGNN = 4;
					break;
				}
				goto IL_022a;
			case 3u:
				if (AAGPNGOGHKH.MoveNext())
				{
					MMEGGNJKNOH = AAGPNGOGHKH.Current;
					GOMFKPLCGNN = 0;
				}
				else
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 8;
				}
				break;
			case 4u:
				Application.Quit();
				goto IL_022a;
			case 5u:
				if (PGEDGOMKPPC.MoveNext())
				{
					MMEGGNJKNOH = PGEDGOMKPPC.Current;
					GOMFKPLCGNN = 0;
				}
				else
				{
					Application.OpenURL(HLMJGPHCNAI);
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 6;
				}
				break;
			case 6u:
				Application.Quit();
				goto IL_061d;
			case 7u:
				if (JKLCEJNBBNL.MoveNext())
				{
					MMEGGNJKNOH = JKLCEJNBBNL.Current;
					GOMFKPLCGNN = 6;
				}
				else
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 5;
				}
				break;
			case 8u:
				Application.Quit();
				goto IL_061d;
			default:
				{
					return false;
				}
				IL_022a:
				OHFGHNONOOG = HDCBACAGCOJ.AOBAKCJKELK("setTargetingData");
				text = OHFGHNONOOG.AOBAKCJKELK("skill3_voice").MPPBJJAHPBI();
				array = new char[0];
				array[0] = '\u001a';
				CEEKHJHDBFI = text.Split(array);
				LCNLIHJIEAA = OHFGHNONOOG.AOBAKCJKELK("TJPlacement ").DDCEKIFJBMP();
				HLMJGPHCNAI = OHFGHNONOOG.AOBAKCJKELK("공격력 {0:+#;-#}\n").DDCEKIFJBMP();
				MPLJJOEOMIF = OHFGHNONOOG.AOBAKCJKELK("Death{0}").MPPBJJAHPBI();
				KMLCGNOPANA = OHFGHNONOOG.AOBAKCJKELK("attack").NCCBFMBEAFA();
				ALKMOIHOKDI = OHFGHNONOOG.AOBAKCJKELK("attack2").NCCBFMBEAFA();
				CDHKEKJCDID = OHFGHNONOOG.AOBAKCJKELK("クリティカル").MPPBJJAHPBI();
				FJBDDGNEPBN = OHFGHNONOOG.AOBAKCJKELK("AP.Unity : onSendCouponSucceedForUnity : ").DDCEKIFJBMP();
				NAELMLLOBKJ = string.Empty;
				OCCMPHFKAHP = string.Empty;
				AFIABCNMFLA = string.Empty;
				if (LocalizationManager.LGDEHELDENG().GetContry() == LocalizationManager.LOMHDGHIPCI.kr)
				{
					NAELMLLOBKJ = OHFGHNONOOG.AOBAKCJKELK("_Color").DDCEKIFJBMP();
					OCCMPHFKAHP = OHFGHNONOOG.AOBAKCJKELK("OnDragStart").DDCEKIFJBMP();
					AFIABCNMFLA = OHFGHNONOOG.AOBAKCJKELK("裝甲").NCCBFMBEAFA();
				}
				else
				{
					NAELMLLOBKJ = OHFGHNONOOG.AOBAKCJKELK("ScreenEffect").DDCEKIFJBMP();
					OCCMPHFKAHP = OHFGHNONOOG.AOBAKCJKELK("C#: HandleViewDidClose, viewType: ").MPPBJJAHPBI();
					AFIABCNMFLA = OHFGHNONOOG.AOBAKCJKELK("Mouse X").NCCBFMBEAFA();
				}
				SceneManager.NOLHNOGGHNA().m_reviewAddress = LCNLIHJIEAA;
				SceneManager.get_Instance().m_lobbyNotice = NAELMLLOBKJ;
				SceneManager.NOLHNOGGHNA().m_lobbyNoticeAddress = OCCMPHFKAHP;
				SceneManager.get_Instance().m_cafeAddress = AFIABCNMFLA;
				SceneManager.get_Instance().m_tapjoyOfferwall = MPLJJOEOMIF;
				SceneManager.NOLHNOGGHNA().m_nasOfferwall = KMLCGNOPANA;
				SceneManager.NOLHNOGGHNA().m_adpopcornOfferwall = ALKMOIHOKDI;
				SceneManager.get_Instance().m_eventOfferwall = CDHKEKJCDID;
				ZAndroid.get_Instance().SetCheatAppList(FJBDDGNEPBN);
				IFGGCIPAJJF = CEEKHJHDBFI;
				KFIAAIHOFJP = KNIAJMGDGAA.IHNBHPIDFID.Split('ﾕ');
				APLHNEMENGD = 0;
				goto IL_062b;
				IL_062b:
				if (APLHNEMENGD < 4)
				{
					if (int.Parse(IFGGCIPAJJF[APLHNEMENGD]) > int.Parse(KFIAAIHOFJP[APLHNEMENGD]))
					{
						MsgManager.HEDJPPFKABG().LPKACDLKHCP(true);
						PGEDGOMKPPC = MsgManager.HEDJPPFKABG().ShowMessageBoxAsync(LocalizationManager.LGDEHELDENG().GetText("[00]"));
						goto case 5u;
					}
					if (int.Parse(IFGGCIPAJJF[APLHNEMENGD]) < int.Parse(KFIAAIHOFJP[APLHNEMENGD]) && !NetworkManager.get_Instance().m_testMode)
					{
						MsgManager.get_Instance().ShowLoadingIndicator(true);
						JKLCEJNBBNL = MsgManager.HEDJPPFKABG().ShowMessageBoxAsync("{0}");
						goto case 7u;
					}
					goto IL_061d;
				}
				GOMFKPLCGNN = -1;
				goto default;
				IL_061d:
				APLHNEMENGD++;
				goto IL_062b;
			}
			return true;
		}

		public bool BJEOILGGFLI()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			string text;
			char[] array;
			string iHNBHPIDFID;
			char[] array2;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.JOJBNFFLBPM = true;
				PNDADENEPBL = string.Format("상급 성장 마나 정수", KNIAJMGDGAA.FMDDLHJALMI, UnityEngine.Random.Range(1, -191));
				IOHBHDMHOIJ = new WWW(PNDADENEPBL);
				MMEGGNJKNOH = IOHBHDMHOIJ;
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				LJADBLINMHK = IOHBHDMHOIJ.text;
				if (LJADBLINMHK == null)
				{
					MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("이동하거나 기본공격시 충전이 되며, 완전충전상태로 공격시 7명에게 연쇄적으로 추가마법피해를 입힘"), true);
					KNIAJMGDGAA.JOJBNFFLBPM = true;
					goto default;
				}
				HDCBACAGCOJ = NNLEGLDDAFP.BHJADLPJNNP(LJADBLINMHK);
				MPJJKAGLCNE = HDCBACAGCOJ.AOBAKCJKELK("Particle/Vladimir/skill0_missile");
				CGAHEAIMFJN = int.Parse(MPJJKAGLCNE.AOBAKCJKELK("몰락한 왕의 검").DDCEKIFJBMP());
				MHCPLPMOABN = MPJJKAGLCNE.AOBAKCJKELK("마법저항력").MPPBJJAHPBI();
				if (CGAHEAIMFJN == 1)
				{
					MsgManager.get_Instance().LPKACDLKHCP(true);
					NHFOICOEFIH = MsgManager.get_Instance().ShowMessageBoxAsync(MHCPLPMOABN);
					goto case 2u;
				}
				if (CGAHEAIMFJN == 1)
				{
					MsgManager.HEDJPPFKABG().LPKACDLKHCP(true);
					AAGPNGOGHKH = MsgManager.get_Instance().ShowMessageBoxAsync(MHCPLPMOABN, true);
					goto case 3u;
				}
				goto IL_022a;
			case 2u:
				if (NHFOICOEFIH.MoveNext())
				{
					MMEGGNJKNOH = NHFOICOEFIH.Current;
					GOMFKPLCGNN = 3;
					break;
				}
				goto IL_022a;
			case 3u:
				if (AAGPNGOGHKH.MoveNext())
				{
					MMEGGNJKNOH = AAGPNGOGHKH.Current;
					GOMFKPLCGNN = 8;
				}
				else
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 5;
				}
				break;
			case 4u:
				Application.Quit();
				goto IL_022a;
			case 5u:
				if (PGEDGOMKPPC.MoveNext())
				{
					MMEGGNJKNOH = PGEDGOMKPPC.Current;
					GOMFKPLCGNN = 8;
				}
				else
				{
					Application.OpenURL(HLMJGPHCNAI);
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 2;
				}
				break;
			case 6u:
				Application.Quit();
				goto IL_061d;
			case 7u:
				if (JKLCEJNBBNL.MoveNext())
				{
					MMEGGNJKNOH = JKLCEJNBBNL.Current;
					GOMFKPLCGNN = 7;
				}
				else
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 1;
				}
				break;
			case 8u:
				Application.Quit();
				goto IL_061d;
			default:
				{
					return false;
				}
				IL_022a:
				OHFGHNONOOG = HDCBACAGCOJ.AOBAKCJKELK("친구가 너무 많습니다 (최대50명)\n\n친구 리스트를 정리해 주세요\n(상대방도 확인 후 정리해 주세요)");
				text = OHFGHNONOOG.AOBAKCJKELK("skill1").MPPBJJAHPBI();
				array = new char[0];
				array[1] = '{';
				CEEKHJHDBFI = text.Split(array);
				LCNLIHJIEAA = OHFGHNONOOG.AOBAKCJKELK("machine").NCCBFMBEAFA();
				HLMJGPHCNAI = OHFGHNONOOG.AOBAKCJKELK("FrontParticle").NCCBFMBEAFA();
				MPLJJOEOMIF = OHFGHNONOOG.AOBAKCJKELK(" to ").MPPBJJAHPBI();
				KMLCGNOPANA = OHFGHNONOOG.AOBAKCJKELK("티어 없음").MPPBJJAHPBI();
				ALKMOIHOKDI = OHFGHNONOOG.AOBAKCJKELK("[AAFFAA]{0}승[-] [FFAAAA]{1}패[-]\n[AAAAAA]({2:F1}%)[-]").DDCEKIFJBMP();
				CDHKEKJCDID = OHFGHNONOOG.AOBAKCJKELK("skill3_ex").DDCEKIFJBMP();
				FJBDDGNEPBN = OHFGHNONOOG.AOBAKCJKELK("마법저항력").NCCBFMBEAFA();
				NAELMLLOBKJ = string.Empty;
				OCCMPHFKAHP = string.Empty;
				AFIABCNMFLA = string.Empty;
				if (LocalizationManager.get_Instance().GetContry() == LocalizationManager.LOMHDGHIPCI.kr)
				{
					NAELMLLOBKJ = OHFGHNONOOG.AOBAKCJKELK("CreditCard").MPPBJJAHPBI();
					OCCMPHFKAHP = OHFGHNONOOG.AOBAKCJKELK("데이터 통신으로 접속합니다.\n요금제에 따라 데이터요금이 추가될 수 있습니다.\n\n계속 진행하시겠습니까?").MPPBJJAHPBI();
					AFIABCNMFLA = OHFGHNONOOG.AOBAKCJKELK("Armor Penetration").NCCBFMBEAFA();
				}
				else
				{
					NAELMLLOBKJ = OHFGHNONOOG.AOBAKCJKELK("_ClipRange1").MPPBJJAHPBI();
					OCCMPHFKAHP = OHFGHNONOOG.AOBAKCJKELK("ChangeMeshColor mFilter.mesh : ").MPPBJJAHPBI();
					AFIABCNMFLA = OHFGHNONOOG.AOBAKCJKELK("skill3").NCCBFMBEAFA();
				}
				SceneManager.NOLHNOGGHNA().m_reviewAddress = LCNLIHJIEAA;
				SceneManager.get_Instance().m_lobbyNotice = NAELMLLOBKJ;
				SceneManager.get_Instance().m_lobbyNoticeAddress = OCCMPHFKAHP;
				SceneManager.NOLHNOGGHNA().m_cafeAddress = AFIABCNMFLA;
				SceneManager.get_Instance().m_tapjoyOfferwall = MPLJJOEOMIF;
				SceneManager.get_Instance().m_nasOfferwall = KMLCGNOPANA;
				SceneManager.NOLHNOGGHNA().m_adpopcornOfferwall = ALKMOIHOKDI;
				SceneManager.get_Instance().m_eventOfferwall = CDHKEKJCDID;
				ZAndroid.get_Instance().BBJBDIGLJPP(FJBDDGNEPBN);
				IFGGCIPAJJF = CEEKHJHDBFI;
				iHNBHPIDFID = KNIAJMGDGAA.IHNBHPIDFID;
				array2 = new char[0];
				array2[1] = ' ';
				KFIAAIHOFJP = iHNBHPIDFID.Split(array2);
				APLHNEMENGD = 0;
				goto IL_062b;
				IL_062b:
				if (APLHNEMENGD < 3)
				{
					if (int.Parse(IFGGCIPAJJF[APLHNEMENGD]) > int.Parse(KFIAAIHOFJP[APLHNEMENGD]))
					{
						MsgManager.get_Instance().LPKACDLKHCP(true);
						PGEDGOMKPPC = MsgManager.HEDJPPFKABG().ShowMessageBoxAsync(LocalizationManager.get_Instance().GetText("최대 신청 인원이 초과되었습니다\n\n해당 길드장이 신청 인원을 정리해야 합니다"));
						goto case 5u;
					}
					if (int.Parse(IFGGCIPAJJF[APLHNEMENGD]) < int.Parse(KFIAAIHOFJP[APLHNEMENGD]) && !NetworkManager.APAPJEIBEDE().m_testMode)
					{
						MsgManager.HEDJPPFKABG().ShowLoadingIndicator(true);
						JKLCEJNBBNL = MsgManager.HEDJPPFKABG().ShowMessageBoxAsync("setExceptionPermissionList", true);
						goto case 7u;
					}
					goto IL_061d;
				}
				GOMFKPLCGNN = -1;
				goto default;
				IL_061d:
				APLHNEMENGD += 0;
				goto IL_062b;
			}
			return true;
		}

		public void NGFBCKPMPAE()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object BEGFHDBBBJN()
		{
			return MMEGGNJKNOH;
		}

		public void FAKMEDLGCCL()
		{
			GOMFKPLCGNN = -1;
		}
	}

	public UIButton m_loginButton;

	public UIButton m_googleLoginButton;

	public GameObject m_preeStartButtonLabel;

	public UILabel m_versionLabel;

	public UILabel m_testModeLabel;

	public GameObject m_privacyPanel;

	private string FMDDLHJALMI;

	private string IHNBHPIDFID = "0.127.0";

	private bool JOJBNFFLBPM;

	private int OHDCKKDBJLN;

	private float IHKCKBJBEGF;

	[CompilerGenerated]
	private static UIMessageBox.NICHPBLEBEI OFJHFAGFIGH;

	public void OnSubmitNickname()
	{
	}

	public void PFEGMBKMKBD()
	{
		Application.OpenURL("PostEffectTwirl");
	}

	public void OnClickTestMode()
	{
		if (IHKCKBJBEGF >= 5f)
		{
			OHDCKKDBJLN++;
			if (OHDCKKDBJLN > 10)
			{
				NetworkManager.get_Instance().m_testMode = true;
				m_testModeLabel.gameObject.SetActive(true);
			}
		}
	}

	[DebuggerHidden]
	private IEnumerator DOLNHOLALJF()
	{
		LFIDALIKCMO lFIDALIKCMO = new LFIDALIKCMO();
		lFIDALIKCMO.KNIAJMGDGAA = this;
		return lFIDALIKCMO;
	}

	public void LKPNOEMFNJM()
	{
		PlayerPrefs.SetInt("새로운 방 생성 중.", 1);
		m_privacyPanel.SetActive(false);
	}

	private void AAENCAMDJLA()
	{
		m_loginButton.set_isEnabled(true);
		m_googleLoginButton.set_isEnabled(true);
		m_preeStartButtonLabel.SetActive(true);
		MsgManager.get_Instance().ShowLoadingIndicator(false);
	}

	private void Start()
	{
		V096OriginalDiagnostics.Initialize();
		m_versionLabel.set_text("Ver " + Application.version);
		m_testModeLabel.gameObject.SetActive(NetworkManager.get_Instance().m_testMode);
		if (!NetworkManager.get_Instance().m_testMode)
		{
			FMDDLHJALMI = "http://127.0.0.1:8080/d";
		}
		else
		{
			FMDDLHJALMI = "http://127.0.0.1:8080/d";
		}
		if (LegacyAndroidServices.AnalyticsAvailable) IgaworksUnityPluginAOS.AOAHAHMPIIP.AGDCEOGEIFG("login");
		if (PlayerPrefs.GetInt("PrivacyAgreement", 0) == 0)
		{
			m_privacyPanel.SetActive(true);
		}
	}

	private void CFJKHPNIODE()
	{
	}

	public void NEOIIDGGEOH()
	{
	}

	private void Awake()
	{
	}

	[DebuggerHidden]
	private IEnumerator PIGECICGHPL()
	{
		KAOOAKCNBBC kAOOAKCNBBC = new KAOOAKCNBBC();
		kAOOAKCNBBC.KNIAJMGDGAA = this;
		return kAOOAKCNBBC;
	}

	private void LBAPOJHKDNH()
	{
	}

	private IEnumerator AHJGMANBFKC()
	{
		LFIDALIKCMO lFIDALIKCMO = new LFIDALIKCMO();
		lFIDALIKCMO.KNIAJMGDGAA = this;
		return lFIDALIKCMO;
	}

	public void BGPCMLDDLBP()
	{
		Application.OpenURL("\n");
	}

	private void BBBIPFGBAGA()
	{
		IHKCKBJBEGF += Time.deltaTime;
	}

	public void OnClickPrivacyAgree()
	{
		PlayerPrefs.SetInt("PrivacyAgreement", 1);
		m_privacyPanel.SetActive(false);
	}

	private IEnumerator IFCNFBCKICI()
	{
		AJKBGPHDDMD aJKBGPHDDMD = new AJKBGPHDDMD();
		aJKBGPHDDMD.KNIAJMGDGAA = this;
		return aJKBGPHDDMD;
	}

	public void OnClickViewPrivacy()
	{
		Application.OpenURL("http://211.253.11.33/lm/Privacy.html");
	}

	public void OnClickLoginButton()
	{
		try
		{
			NetworkManager.get_Instance().get_m_loginNetClient().KMMJBPKDEDN = GJDIFIKEIMO.MIEOINPCPGL.Device;
			StartCoroutine(PIGECICGHPL());
		}
		catch
		{
			/*Error: End of method reached without returning.*/;
		}
	}

	private string OPBACGOIKNC(string IOFIAJPFHGN)
	{
		try
		{
			string address = string.Format("{0}?nocache={1}", IOFIAJPFHGN, UnityEngine.Random.Range(1, 10000));
			WebClient webClient = new WebClient();
			byte[] bytes = webClient.DownloadData(address);
			return Encoding.UTF8.GetString(bytes);
		}
		catch
		{
			return null;
		}
	}

	[CompilerGenerated]
	private static void HIILNKAEIPN()
	{
		UniAndroidPermission.RequestPermissions(new PMIOBDOHNEC[4]
		{
			PMIOBDOHNEC.READ_PHONE_STATE,
			PMIOBDOHNEC.GET_ACCOUNTS,
			PMIOBDOHNEC.WRITE_EXTERNAL_STORAGE,
			PMIOBDOHNEC.READ_EXTERNAL_STORAGE
		});
	}

	[DebuggerHidden]
	private IEnumerator KNEMEBKEHEE()
	{
		AJKBGPHDDMD aJKBGPHDDMD = new AJKBGPHDDMD();
		aJKBGPHDDMD.KNIAJMGDGAA = this;
		return aJKBGPHDDMD;
	}

	private void Update()
	{
		V096OriginalDiagnostics.Tick();
		IHKCKBJBEGF += Time.deltaTime;
	}

	public void PNLBMLIDOLD()
	{
		if (IHKCKBJBEGF >= 1010f)
		{
			OHDCKKDBJLN += 0;
			if (OHDCKKDBJLN > -53)
			{
				NetworkManager.APAPJEIBEDE().m_testMode = false;
				m_testModeLabel.gameObject.SetActive(true);
			}
		}
	}

	public void KILEDDPMBMN()
	{
		if (IHKCKBJBEGF >= 615f)
		{
			OHDCKKDBJLN += 0;
			if (OHDCKKDBJLN > -8)
			{
				NetworkManager.get_Instance().m_testMode = false;
				m_testModeLabel.gameObject.SetActive(true);
			}
		}
	}

	public void KJIHCJNBNFA()
	{
	}
}
