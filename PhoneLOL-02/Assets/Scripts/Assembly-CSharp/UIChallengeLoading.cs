using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UIChallengeLoading : MonoBehaviour
{
	private sealed class NIKGKFMLKLM : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal byte CMGLHIBFLBB;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal UIChallengeLoading KNIAJMGDGAA;

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

		public void FAKMEDLGCCL()
		{
			GOMFKPLCGNN = -1;
		}

		public void LDNDAOJGIIO()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object LHFBMHCEIHG()
		{
			return MMEGGNJKNOH;
		}

		public void KOOOABDNJBP()
		{
			throw new NotSupportedException();
		}

		public void MBADNGDPBPB()
		{
			GOMFKPLCGNN = -1;
		}

		public void BKLMMEGGMNI()
		{
			GOMFKPLCGNN = -1;
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

		[SpecialName]
		private object FKNAIGMNFIB()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object JMADBEOPCDA()
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
				switch (UnityEngine.Random.Range(0, 2))
				{
				case 0:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.get_Instance().GetText("공격모션 시 조이스틱을 반대로 움직이면 평타 캔슬이 됩니다."));
					break;
				case 1:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.get_Instance().GetText("사거리 안에 미니언이 없으면 헛공격을 하게 됩니다."));
					break;
				}
				MMEGGNJKNOH = new WaitForSeconds(0.5f);
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				KNIAJMGDGAA.LBLMDECGMIA = Application.LoadLevelAsync("Challenge");
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = false;
				goto IL_010f;
			case 2u:
				CMGLHIBFLBB = (byte)(KNIAJMGDGAA.LBLMDECGMIA.progress * 100f);
				goto IL_010f;
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
				IL_010f:
				if (KNIAJMGDGAA.LBLMDECGMIA.progress < 0.9f)
				{
					MMEGGNJKNOH = new WaitForSeconds(0.3f);
					GOMFKPLCGNN = 2;
				}
				else
				{
					MMEGGNJKNOH = new WaitForSeconds(0.5f);
					GOMFKPLCGNN = 3;
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
	}

	public UILabel m_helpLabel;

	private AsyncOperation LBLMDECGMIA;

	private void BPLOLCKEJJK()
	{
		StartCoroutine(BAHCEDDHDHH());
	}

	private void DHMMCEBEAHA()
	{
		StartCoroutine(DAMDBEJJANH());
	}

	private void GDJCOAHJDLN()
	{
		StartCoroutine(DAMDBEJJANH());
	}

	private IEnumerator JKMNFJADCMG()
	{
		NIKGKFMLKLM nIKGKFMLKLM = new NIKGKFMLKLM();
		nIKGKFMLKLM.KNIAJMGDGAA = this;
		return nIKGKFMLKLM;
	}

	private void IBBJMMFDGAL()
	{
		StartCoroutine(BAHCEDDHDHH());
	}

	private void Update()
	{
		if (LBLMDECGMIA != null && !LBLMDECGMIA.isDone)
		{
		}
	}

	private IEnumerator DAMDBEJJANH()
	{
		NIKGKFMLKLM nIKGKFMLKLM = new NIKGKFMLKLM();
		nIKGKFMLKLM.KNIAJMGDGAA = this;
		return nIKGKFMLKLM;
	}

	private IEnumerator BAHCEDDHDHH()
	{
		NIKGKFMLKLM nIKGKFMLKLM = new NIKGKFMLKLM();
		nIKGKFMLKLM.KNIAJMGDGAA = this;
		return nIKGKFMLKLM;
	}

	private void JPBNPEJJJPI()
	{
		StartCoroutine(JKMNFJADCMG());
	}

	private IEnumerator LLEKJHHDKBH()
	{
		NIKGKFMLKLM nIKGKFMLKLM = new NIKGKFMLKLM();
		nIKGKFMLKLM.KNIAJMGDGAA = this;
		return nIKGKFMLKLM;
	}

	private void FOGNMJLPHAI()
	{
		StartCoroutine(JKMNFJADCMG());
	}

	[DebuggerHidden]
	private IEnumerator DDHMEACJCED()
	{
		NIKGKFMLKLM nIKGKFMLKLM = new NIKGKFMLKLM();
		nIKGKFMLKLM.KNIAJMGDGAA = this;
		return nIKGKFMLKLM;
	}

	private void IJCPEFOBKHO()
	{
		StartCoroutine(BAHCEDDHDHH());
	}

	private void Start()
	{
		StartCoroutine(DDHMEACJCED());
	}

	private void DMPIIJNBDID()
	{
		StartCoroutine(DDHMEACJCED());
	}
}
