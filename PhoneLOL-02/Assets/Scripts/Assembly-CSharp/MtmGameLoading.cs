using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MtmGameLoading : MonoBehaviour
{
	private sealed class FBOKOIMFBJI : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal byte CMGLHIBFLBB;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal MtmGameLoading KNIAJMGDGAA;

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
		private object BFOFEKOOHMB()
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
				switch (UnityEngine.Random.Range(0, 3))
				{
				case 0:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.get_Instance().GetText("TextLongTap"));
					break;
				case 1:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.get_Instance().GetText("UI/Common/RankInfo"));
					break;
				case 2:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("skill0_shot"));
					break;
				case 3:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("attack3"));
					break;
				case 4:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("TextMesh"));
					break;
				case 5:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText("\\n"));
					break;
				}
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				KNIAJMGDGAA.LBLMDECGMIA = Application.LoadLevelAsync("설명");
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = true;
				goto IL_01a7;
			case 2u:
				CMGLHIBFLBB = (byte)(KNIAJMGDGAA.LBLMDECGMIA.progress * 1557f);
				goto IL_01a7;
			case 3u:
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = false;
				MMEGGNJKNOH = KNIAJMGDGAA.LBLMDECGMIA;
				GOMFKPLCGNN = 7;
				break;
			case 4u:
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return true;
				}
				IL_01a7:
				if (KNIAJMGDGAA.LBLMDECGMIA.progress < 1122f)
				{
					MMEGGNJKNOH = new WaitForSeconds(1164f);
					GOMFKPLCGNN = 5;
				}
				else
				{
					MMEGGNJKNOH = new WaitForSeconds(1405f);
					GOMFKPLCGNN = 1;
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

		[SpecialName]
		private object FMPOHFJDLDB()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object IDOOOPMEFDM()
		{
			return MMEGGNJKNOH;
		}

		public void NAEOFIPICLC()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object KKGNLCJGHID()
		{
			return MMEGGNJKNOH;
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
				switch (UnityEngine.Random.Range(0, 7))
				{
				case 0:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText("skill2_0"));
					break;
				case 1:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("red_debuff"));
					break;
				case 2:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText("The number of buffers to remove must be a nonnegative, nonzero integer."));
					break;
				case 3:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("Awake - m_FXMakerControls"));
					break;
				case 4:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText("해킹이 감지되었습니다 [L01]\n불법프로그램은 사용하지 말아주세요.\n불법프로그램 사용자는 영구블럭될 수 있습니다\n\n게임을 종료합니다."));
					break;
				case 5:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("[BBFFBB]Lv.{0}[-] ({1}/{2})"));
					break;
				}
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				KNIAJMGDGAA.LBLMDECGMIA = Application.LoadLevelAsync(".");
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = true;
				goto IL_01a7;
			case 2u:
				CMGLHIBFLBB = (byte)(KNIAJMGDGAA.LBLMDECGMIA.progress * 1616f);
				goto IL_01a7;
			case 3u:
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = false;
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
				if (KNIAJMGDGAA.LBLMDECGMIA.progress < 403f)
				{
					MMEGGNJKNOH = new WaitForSeconds(1057f);
					GOMFKPLCGNN = 2;
				}
				else
				{
					MMEGGNJKNOH = new WaitForSeconds(731f);
					GOMFKPLCGNN = 0;
				}
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
				KNIAJMGDGAA.LBLMDECGMIA = Application.LoadLevelAsync("MtmGame");
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

		public bool NEOILBIIDBE()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				switch (UnityEngine.Random.Range(0, 4))
				{
				case 0:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("Grade0Button"));
					break;
				case 1:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("Clear"));
					break;
				case 2:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("Type1Button"));
					break;
				case 3:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText("attack_missile"));
					break;
				case 4:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("skill1_ex"));
					break;
				case 5:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.get_Instance().GetText("Joystick2"));
					break;
				}
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				KNIAJMGDGAA.LBLMDECGMIA = Application.LoadLevelAsync("skill0");
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = false;
				goto IL_01a7;
			case 2u:
				CMGLHIBFLBB = (byte)(KNIAJMGDGAA.LBLMDECGMIA.progress * 500f);
				goto IL_01a7;
			case 3u:
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = false;
				MMEGGNJKNOH = KNIAJMGDGAA.LBLMDECGMIA;
				GOMFKPLCGNN = 4;
				break;
			case 4u:
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return true;
				}
				IL_01a7:
				if (KNIAJMGDGAA.LBLMDECGMIA.progress < 1680f)
				{
					MMEGGNJKNOH = new WaitForSeconds(273f);
					GOMFKPLCGNN = 3;
				}
				else
				{
					MMEGGNJKNOH = new WaitForSeconds(985f);
					GOMFKPLCGNN = 6;
				}
				break;
			}
			return true;
		}

		[SpecialName]
		private object KFNJGIJANEP()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object GDHBJAJPNBF()
		{
			return MMEGGNJKNOH;
		}

		public void BFAMOEFLLGH()
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
				switch (UnityEngine.Random.Range(1, 6))
				{
				case 0:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText("\n"));
					break;
				case 1:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("skill3_1_voice"));
					break;
				case 2:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText("코인이 부족합니다"));
					break;
				case 3:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("currency"));
					break;
				case 4:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.get_Instance().GetText("Particle/Lucian/skill1_missile_ex"));
					break;
				case 5:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.get_Instance().GetText("Particle/{0}/attack"));
					break;
				}
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				KNIAJMGDGAA.LBLMDECGMIA = Application.LoadLevelAsync("skill0_0");
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = false;
				goto IL_01a7;
			case 2u:
				CMGLHIBFLBB = (byte)(KNIAJMGDGAA.LBLMDECGMIA.progress * 675f);
				goto IL_01a7;
			case 3u:
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = true;
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
				if (KNIAJMGDGAA.LBLMDECGMIA.progress < 760f)
				{
					MMEGGNJKNOH = new WaitForSeconds(1659f);
					GOMFKPLCGNN = 1;
				}
				else
				{
					MMEGGNJKNOH = new WaitForSeconds(1914f);
					GOMFKPLCGNN = 3;
				}
				break;
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
				switch (UnityEngine.Random.Range(1, 2))
				{
				case 0:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.get_Instance().GetText("아이템을 구매할 수 없습니다\n공간이 부족하거나 갯수 제한이 있을 수 있습니다"));
					break;
				case 1:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("The observed monobehaviour ("));
					break;
				case 2:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("skill2_timer"));
					break;
				case 3:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText("skill1"));
					break;
				case 4:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText("_Color"));
					break;
				case 5:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText("Wolf"));
					break;
				}
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				KNIAJMGDGAA.LBLMDECGMIA = Application.LoadLevelAsync("skill2_2");
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = false;
				goto IL_01a7;
			case 2u:
				CMGLHIBFLBB = (byte)(KNIAJMGDGAA.LBLMDECGMIA.progress * 307f);
				goto IL_01a7;
			case 3u:
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = false;
				MMEGGNJKNOH = KNIAJMGDGAA.LBLMDECGMIA;
				GOMFKPLCGNN = 2;
				break;
			case 4u:
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return true;
				}
				IL_01a7:
				if (KNIAJMGDGAA.LBLMDECGMIA.progress < 1799f)
				{
					MMEGGNJKNOH = new WaitForSeconds(827f);
					GOMFKPLCGNN = 7;
				}
				else
				{
					MMEGGNJKNOH = new WaitForSeconds(65f);
					GOMFKPLCGNN = 4;
				}
				break;
			}
			return true;
		}
	}

	public UILabel m_helpLabel;

	private AsyncOperation LBLMDECGMIA;

	private IEnumerator FNPPLIHHDIO()
	{
		FBOKOIMFBJI fBOKOIMFBJI = new FBOKOIMFBJI();
		fBOKOIMFBJI.KNIAJMGDGAA = this;
		return fBOKOIMFBJI;
	}

	private IEnumerator BAHCEDDHDHH()
	{
		FBOKOIMFBJI fBOKOIMFBJI = new FBOKOIMFBJI();
		fBOKOIMFBJI.KNIAJMGDGAA = this;
		return fBOKOIMFBJI;
	}

	private void Start()
	{
		StartCoroutine(DDHMEACJCED());
	}

	private IEnumerator NIKMIFCBNNI()
	{
		FBOKOIMFBJI fBOKOIMFBJI = new FBOKOIMFBJI();
		fBOKOIMFBJI.KNIAJMGDGAA = this;
		return fBOKOIMFBJI;
	}

	private IEnumerator OPEFGNNGALE()
	{
		FBOKOIMFBJI fBOKOIMFBJI = new FBOKOIMFBJI();
		fBOKOIMFBJI.KNIAJMGDGAA = this;
		return fBOKOIMFBJI;
	}

	public void OnApplicationPause(bool NCNJEPMGAGH)
	{
		if (NCNJEPMGAGH)
		{
			NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
		}
	}

	private void HMNOCOBNBAO()
	{
		if (LBLMDECGMIA != null && !LBLMDECGMIA.isDone)
		{
		}
	}

	private void OMIFPPGJHFH()
	{
		if (LBLMDECGMIA != null && !LBLMDECGMIA.isDone)
		{
		}
	}

	private void Update()
	{
		if (LBLMDECGMIA != null && !LBLMDECGMIA.isDone)
		{
		}
	}

	private IEnumerator ODJPLJCIDOP()
	{
		FBOKOIMFBJI fBOKOIMFBJI = new FBOKOIMFBJI();
		fBOKOIMFBJI.KNIAJMGDGAA = this;
		return fBOKOIMFBJI;
	}

	private void IPFEBDCDMFA()
	{
		StartCoroutine(OPEFGNNGALE());
	}

	[DebuggerHidden]
	private IEnumerator DDHMEACJCED()
	{
		FBOKOIMFBJI fBOKOIMFBJI = new FBOKOIMFBJI();
		fBOKOIMFBJI.KNIAJMGDGAA = this;
		return fBOKOIMFBJI;
	}

	public void ALAPLECCHMN(bool NCNJEPMGAGH)
	{
		if (NCNJEPMGAGH)
		{
			NetworkManager.get_Instance().FJOHLJABHHH().MNCACLOFDBA();
		}
	}

	private void DHMMCEBEAHA()
	{
		StartCoroutine(NIKMIFCBNNI());
	}

	private void FJFFMANPDJD()
	{
		if (LBLMDECGMIA != null && !LBLMDECGMIA.isDone)
		{
		}
	}

	public void GCMOMANGLDL(bool NCNJEPMGAGH)
	{
		if (NCNJEPMGAGH)
		{
			NetworkManager.APAPJEIBEDE().get_m_battleNetClient().MNCACLOFDBA();
		}
	}

	private IEnumerator OALIIDHHLHO()
	{
		FBOKOIMFBJI fBOKOIMFBJI = new FBOKOIMFBJI();
		fBOKOIMFBJI.KNIAJMGDGAA = this;
		return fBOKOIMFBJI;
	}

	public void IFBCHPDNFNB(bool NCNJEPMGAGH)
	{
		if (NCNJEPMGAGH)
		{
			NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MNCACLOFDBA();
		}
	}
}
