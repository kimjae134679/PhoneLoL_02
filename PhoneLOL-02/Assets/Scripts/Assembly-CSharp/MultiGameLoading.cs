using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MultiGameLoading : MonoBehaviour
{
	private sealed class KJDGKCCEGDA : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal byte CMGLHIBFLBB;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal MultiGameLoading KNIAJMGDGAA;

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

		public bool MNHCKJNDJOG()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				switch (UnityEngine.Random.Range(1, 6))
				{
				case 0:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText("GoogleLoginCount"));
					break;
				case 1:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.get_Instance().GetText("increment"));
					break;
				case 2:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("64"));
					break;
				case 3:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("'{0}' is not a valid 24 digit hex string."));
					break;
				case 4:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.get_Instance().GetText("skill0_hit"));
					break;
				case 5:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText("/"));
					break;
				}
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				KNIAJMGDGAA.LBLMDECGMIA = Application.LoadLevelAsync("코인");
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = true;
				goto IL_01a7;
			case 2u:
				CMGLHIBFLBB = (byte)(KNIAJMGDGAA.LBLMDECGMIA.progress * 188f);
				goto IL_01a7;
			case 3u:
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = true;
				MMEGGNJKNOH = KNIAJMGDGAA.LBLMDECGMIA;
				GOMFKPLCGNN = 2;
				break;
			case 4u:
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_01a7:
				if (KNIAJMGDGAA.LBLMDECGMIA.progress < 1039f)
				{
					MMEGGNJKNOH = new WaitForSeconds(721f);
					GOMFKPLCGNN = 1;
				}
				else
				{
					MMEGGNJKNOH = new WaitForSeconds(585f);
					GOMFKPLCGNN = 3;
				}
				break;
			}
			return true;
		}

		public void OCFAAIMPJFI()
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
				switch (UnityEngine.Random.Range(0, 6))
				{
				case 0:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.get_Instance().GetText("공격모션 시 조이스틱을 반대로 움직이면 평타 캔슬이 됩니다."));
					break;
				case 1:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.get_Instance().GetText("사거리 안에 미니언이 없으면 헛공격을 하게 됩니다."));
					break;
				case 2:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.get_Instance().GetText("게임 테두리는 기존시즌 티어이며, 현재시즌 티어는 아니에요."));
					break;
				case 3:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.get_Instance().GetText("랭크대전은 자신의 티어 +-1 의 티어와 매칭되요"));
					break;
				case 4:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.get_Instance().GetText("랭크대전에서 골드 이상과 브실은 따로 매칭되며, 만날 수 없어요"));
					break;
				case 5:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.get_Instance().GetText("탈주나 트롤을 하면 게임정지, 트롤러와 같은 편이 될 수 있어요"));
					break;
				}
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				KNIAJMGDGAA.LBLMDECGMIA = Application.LoadLevelAsync("MultiGame");
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = false;
				goto IL_01a7;
			case 2u:
				CMGLHIBFLBB = (byte)(KNIAJMGDGAA.LBLMDECGMIA.progress * 100f);
				goto IL_01a7;
			case 3u:
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = true;
				MMEGGNJKNOH = KNIAJMGDGAA.LBLMDECGMIA;
				GOMFKPLCGNN = 4;
				break;
			case 4u:
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_01a7:
				if (KNIAJMGDGAA.LBLMDECGMIA.progress < 0.9f)
				{
					MMEGGNJKNOH = new WaitForSeconds(0.3f);
					GOMFKPLCGNN = 2;
				}
				else
				{
					MMEGGNJKNOH = new WaitForSeconds(1f);
					GOMFKPLCGNN = 3;
				}
				break;
			}
			return true;
		}

		[SpecialName]
		private object BLGJNJAMAIJ()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object KAMNAHHFPLK()
		{
			return MMEGGNJKNOH;
		}

		public void NGFBCKPMPAE()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object PCGKBCDEONE()
		{
			return MMEGGNJKNOH;
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

		public void FPLNHDDGGHP()
		{
			GOMFKPLCGNN = -1;
		}

		public void LDNDAOJGIIO()
		{
			throw new NotSupportedException();
		}

		public void KIHPGHBDAMI()
		{
			GOMFKPLCGNN = -1;
		}

		public void KOOOABDNJBP()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object ANOBEJKPLKK()
		{
			return MMEGGNJKNOH;
		}

		public bool KAHALICNEBF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				switch (UnityEngine.Random.Range(0, 3))
				{
				case 0:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("알려지지 않은 오류입니다."));
					break;
				case 1:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("1"));
					break;
				case 2:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("attack2_voice"));
					break;
				case 3:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("hit"));
					break;
				case 4:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("+.05"));
					break;
				case 5:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("bytes"));
					break;
				}
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				KNIAJMGDGAA.LBLMDECGMIA = Application.LoadLevelAsync("[CCFFCC]<{0}>[-]{1}");
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = true;
				goto IL_01a7;
			case 2u:
				CMGLHIBFLBB = (byte)(KNIAJMGDGAA.LBLMDECGMIA.progress * 167f);
				goto IL_01a7;
			case 3u:
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = false;
				MMEGGNJKNOH = KNIAJMGDGAA.LBLMDECGMIA;
				GOMFKPLCGNN = 3;
				break;
			case 4u:
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_01a7:
				if (KNIAJMGDGAA.LBLMDECGMIA.progress < 1103f)
				{
					MMEGGNJKNOH = new WaitForSeconds(132f);
					GOMFKPLCGNN = 5;
				}
				else
				{
					MMEGGNJKNOH = new WaitForSeconds(233f);
					GOMFKPLCGNN = 2;
				}
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
				switch (UnityEngine.Random.Range(1, 2))
				{
				case 0:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("skill3_loop"));
					break;
				case 1:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("레벨당 주문력"));
					break;
				case 2:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("attack"));
					break;
				case 3:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("AP per Level"));
					break;
				case 4:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("대기시간감소 {0}%\n"));
					break;
				case 5:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.get_Instance().GetText("Refresh"));
					break;
				}
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				KNIAJMGDGAA.LBLMDECGMIA = Application.LoadLevelAsync("skill3_shot");
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = false;
				goto IL_01a7;
			case 2u:
				CMGLHIBFLBB = (byte)(KNIAJMGDGAA.LBLMDECGMIA.progress * 580f);
				goto IL_01a7;
			case 3u:
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = true;
				MMEGGNJKNOH = KNIAJMGDGAA.LBLMDECGMIA;
				GOMFKPLCGNN = 6;
				break;
			case 4u:
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return true;
				}
				IL_01a7:
				if (KNIAJMGDGAA.LBLMDECGMIA.progress < 317f)
				{
					MMEGGNJKNOH = new WaitForSeconds(1152f);
					GOMFKPLCGNN = 1;
				}
				else
				{
					MMEGGNJKNOH = new WaitForSeconds(1084f);
					GOMFKPLCGNN = 6;
				}
				break;
			}
			return false;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public void CGHBHPHMJGG()
		{
			throw new NotSupportedException();
		}

		public void DAPBOMILKPH()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object JNKGFHPIOPG()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object BDANALHKFBH()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}
	}

	public UILabel m_helpLabel;

	private AsyncOperation LBLMDECGMIA;

	private void DHMMCEBEAHA()
	{
		StartCoroutine(DDHMEACJCED());
	}

	private void Update()
	{
		V096OriginalDiagnostics.Tick();
		if (LBLMDECGMIA != null && !LBLMDECGMIA.isDone)
		{
		}
	}

	private void PEIFAOJLDMD()
	{
		if (LBLMDECGMIA != null && !LBLMDECGMIA.isDone)
		{
		}
	}

	[DebuggerHidden]
	private IEnumerator DDHMEACJCED()
	{
		KJDGKCCEGDA kJDGKCCEGDA = new KJDGKCCEGDA();
		kJDGKCCEGDA.KNIAJMGDGAA = this;
		return kJDGKCCEGDA;
	}

	private void Start()
	{
		V096OriginalDiagnostics.BattleLoadingStart();
		StartCoroutine(DDHMEACJCED());
	}

	private void NMANMMOMHHD()
	{
		StartCoroutine(MHHKCONNHGN());
	}

	private void CLLECEEEJAI()
	{
		StartCoroutine(MHHKCONNHGN());
	}

	private void FJFFMANPDJD()
	{
		if (LBLMDECGMIA != null && !LBLMDECGMIA.isDone)
		{
		}
	}

	private IEnumerator FNPPLIHHDIO()
	{
		KJDGKCCEGDA kJDGKCCEGDA = new KJDGKCCEGDA();
		kJDGKCCEGDA.KNIAJMGDGAA = this;
		return kJDGKCCEGDA;
	}

	public void DMENDMLGGLD(bool NCNJEPMGAGH)
	{
		if (NCNJEPMGAGH)
		{
			NetworkManager.APAPJEIBEDE().get_m_battleNetClient().MNCACLOFDBA();
		}
	}

	private IEnumerator MHHKCONNHGN()
	{
		KJDGKCCEGDA kJDGKCCEGDA = new KJDGKCCEGDA();
		kJDGKCCEGDA.KNIAJMGDGAA = this;
		return kJDGKCCEGDA;
	}

	private void FMDCADHECGH()
	{
		StartCoroutine(MHHKCONNHGN());
	}

	public void IFBCHPDNFNB(bool NCNJEPMGAGH)
	{
		if (NCNJEPMGAGH)
		{
			NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MNCACLOFDBA();
		}
	}

	private void IPFEBDCDMFA()
	{
		StartCoroutine(DDHMEACJCED());
	}

	public void OnApplicationPause(bool NCNJEPMGAGH)
	{
		if (NCNJEPMGAGH)
		{
			NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
		}
	}

	private void OnDisable()
	{
		V096OriginalDiagnostics.BattleLoadingExit();
	}
}
