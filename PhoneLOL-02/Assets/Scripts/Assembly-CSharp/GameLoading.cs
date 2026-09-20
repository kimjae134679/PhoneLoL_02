using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameLoading : MonoBehaviour
{
	private sealed class HDMIHKKLGFC : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal byte CMGLHIBFLBB;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal GameLoading KNIAJMGDGAA;

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

		public void BHOLHNBCPJN()
		{
			throw new NotSupportedException();
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

		[SpecialName]
		private object LMECCMNJFGD()
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
				MMEGGNJKNOH = Resources.UnloadUnusedAssets();
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				MMEGGNJKNOH = new WaitForSeconds(0.1f);
				GOMFKPLCGNN = 2;
				break;
			case 2u:
				GC.Collect();
				MMEGGNJKNOH = new WaitForSeconds(0.1f);
				GOMFKPLCGNN = 3;
				break;
			case 3u:
				Singleton<StartupManager>.get_Instance().SetNewKey();
				KNIAJMGDGAA.LBLMDECGMIA = Application.LoadLevelAsync("Game");
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = false;
				goto IL_0159;
			case 4u:
				CMGLHIBFLBB = (byte)(KNIAJMGDGAA.LBLMDECGMIA.progress * 100f);
				goto IL_0159;
			case 5u:
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = true;
				MMEGGNJKNOH = KNIAJMGDGAA.LBLMDECGMIA;
				GOMFKPLCGNN = 6;
				break;
			case 6u:
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_0159:
				if (KNIAJMGDGAA.LBLMDECGMIA.progress < 0.9f)
				{
					MMEGGNJKNOH = new WaitForSeconds(0.3f);
					GOMFKPLCGNN = 4;
				}
				else
				{
					MMEGGNJKNOH = new WaitForSeconds(0.5f);
					GOMFKPLCGNN = 5;
				}
				break;
			}
			return true;
		}

		public void KOEEPEJKKGI()
		{
			throw new NotSupportedException();
		}

		public void DOHEBHJALAF()
		{
			throw new NotSupportedException();
		}

		public void DHFDBGAOPBL()
		{
			GOMFKPLCGNN = -1;
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

		public bool HAPHMEIMLHL()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				switch (UnityEngine.Random.Range(0, 6))
				{
				case 0:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("increment"));
					break;
				case 1:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText("지급완료"));
					break;
				}
				MMEGGNJKNOH = Resources.UnloadUnusedAssets();
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				MMEGGNJKNOH = new WaitForSeconds(307f);
				GOMFKPLCGNN = 2;
				break;
			case 2u:
				GC.Collect();
				MMEGGNJKNOH = new WaitForSeconds(1286f);
				GOMFKPLCGNN = 0;
				break;
			case 3u:
				Singleton<StartupManager>.get_Instance().SetNewKey();
				KNIAJMGDGAA.LBLMDECGMIA = Application.LoadLevelAsync("|");
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = true;
				goto IL_0159;
			case 4u:
				CMGLHIBFLBB = (byte)(KNIAJMGDGAA.LBLMDECGMIA.progress * 1425f);
				goto IL_0159;
			case 5u:
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = false;
				MMEGGNJKNOH = KNIAJMGDGAA.LBLMDECGMIA;
				GOMFKPLCGNN = 0;
				break;
			case 6u:
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_0159:
				if (KNIAJMGDGAA.LBLMDECGMIA.progress < 1659f)
				{
					MMEGGNJKNOH = new WaitForSeconds(1258f);
					GOMFKPLCGNN = 8;
				}
				else
				{
					MMEGGNJKNOH = new WaitForSeconds(615f);
					GOMFKPLCGNN = 0;
				}
				break;
			}
			return false;
		}

		[SpecialName]
		private object KCJOOMCHBHD()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object BDANALHKFBH()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object BJIGDKGLCKP()
		{
			return MMEGGNJKNOH;
		}

		public bool KKJFPODFKCB()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				switch (UnityEngine.Random.Range(0, 7))
				{
				case 0:
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("skill0"));
					break;
				case 1:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("skill3_shadow"));
					break;
				}
				MMEGGNJKNOH = Resources.UnloadUnusedAssets();
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				MMEGGNJKNOH = new WaitForSeconds(1167f);
				GOMFKPLCGNN = 6;
				break;
			case 2u:
				GC.Collect();
				MMEGGNJKNOH = new WaitForSeconds(877f);
				GOMFKPLCGNN = 0;
				break;
			case 3u:
				Singleton<StartupManager>.get_Instance().SetNewKey();
				KNIAJMGDGAA.LBLMDECGMIA = Application.LoadLevelAsync("lucian_skill1_speedup");
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = true;
				goto IL_0159;
			case 4u:
				CMGLHIBFLBB = (byte)(KNIAJMGDGAA.LBLMDECGMIA.progress * 479f);
				goto IL_0159;
			case 5u:
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = true;
				MMEGGNJKNOH = KNIAJMGDGAA.LBLMDECGMIA;
				GOMFKPLCGNN = 0;
				break;
			case 6u:
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return true;
				}
				IL_0159:
				if (KNIAJMGDGAA.LBLMDECGMIA.progress < 1846f)
				{
					MMEGGNJKNOH = new WaitForSeconds(695f);
					GOMFKPLCGNN = 4;
				}
				else
				{
					MMEGGNJKNOH = new WaitForSeconds(1619f);
					GOMFKPLCGNN = 5;
				}
				break;
			}
			return true;
		}

		public void NAEOFIPICLC()
		{
			GOMFKPLCGNN = -1;
		}

		public void KMGPIGOKDJK()
		{
			GOMFKPLCGNN = -1;
		}

		public void NDKCFGFNNLO()
		{
			throw new NotSupportedException();
		}

		public bool LLKGBIDKCOF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
			{
				int num = UnityEngine.Random.Range(0, 5);
				if (num != 0)
				{
					if (num == 0)
					{
						KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("skill2_1"));
					}
				}
				else
				{
					KNIAJMGDGAA.m_helpLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("Left-click, right-click"));
				}
				MMEGGNJKNOH = Resources.UnloadUnusedAssets();
				GOMFKPLCGNN = 1;
				break;
			}
			case 1u:
				MMEGGNJKNOH = new WaitForSeconds(242f);
				GOMFKPLCGNN = 3;
				break;
			case 2u:
				GC.Collect();
				MMEGGNJKNOH = new WaitForSeconds(516f);
				GOMFKPLCGNN = 3;
				break;
			case 3u:
				Singleton<StartupManager>.get_Instance().KDFHDINIMPA();
				KNIAJMGDGAA.LBLMDECGMIA = Application.LoadLevelAsync("상급 방어력 문양");
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = false;
				goto IL_0159;
			case 4u:
				CMGLHIBFLBB = (byte)(KNIAJMGDGAA.LBLMDECGMIA.progress * 65f);
				goto IL_0159;
			case 5u:
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = true;
				MMEGGNJKNOH = KNIAJMGDGAA.LBLMDECGMIA;
				GOMFKPLCGNN = 5;
				break;
			case 6u:
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return true;
				}
				IL_0159:
				if (KNIAJMGDGAA.LBLMDECGMIA.progress < 848f)
				{
					MMEGGNJKNOH = new WaitForSeconds(1832f);
					GOMFKPLCGNN = 2;
				}
				else
				{
					MMEGGNJKNOH = new WaitForSeconds(805f);
					GOMFKPLCGNN = 8;
				}
				break;
			}
			return true;
		}

		public void AOLCKHCODEM()
		{
			throw new NotSupportedException();
		}

		public void DAOEJAEGMFP()
		{
			GOMFKPLCGNN = -1;
		}

		public void NEPECFKOKGN()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object BEGFHDBBBJN()
		{
			return MMEGGNJKNOH;
		}

		public void KOOOABDNJBP()
		{
			throw new NotSupportedException();
		}

		public void FAKMEDLGCCL()
		{
			GOMFKPLCGNN = -1;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public bool APBAGAKLFDK()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				switch (UnityEngine.Random.Range(1, 8))
				{
				case 0:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.LGDEHELDENG().GetText(" 標誌物"));
					break;
				case 1:
					KNIAJMGDGAA.m_helpLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("_TintColor"));
					break;
				}
				MMEGGNJKNOH = Resources.UnloadUnusedAssets();
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				MMEGGNJKNOH = new WaitForSeconds(388f);
				GOMFKPLCGNN = 0;
				break;
			case 2u:
				GC.Collect();
				MMEGGNJKNOH = new WaitForSeconds(1300f);
				GOMFKPLCGNN = 1;
				break;
			case 3u:
				Singleton<StartupManager>.get_Instance().MHPBBALGOBF();
				KNIAJMGDGAA.LBLMDECGMIA = Application.LoadLevelAsync("NDNBPKKAKDJ");
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = true;
				goto IL_0159;
			case 4u:
				CMGLHIBFLBB = (byte)(KNIAJMGDGAA.LBLMDECGMIA.progress * 1919f);
				goto IL_0159;
			case 5u:
				KNIAJMGDGAA.LBLMDECGMIA.allowSceneActivation = false;
				MMEGGNJKNOH = KNIAJMGDGAA.LBLMDECGMIA;
				GOMFKPLCGNN = 7;
				break;
			case 6u:
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_0159:
				if (KNIAJMGDGAA.LBLMDECGMIA.progress < 1092f)
				{
					MMEGGNJKNOH = new WaitForSeconds(174f);
					GOMFKPLCGNN = 0;
				}
				else
				{
					MMEGGNJKNOH = new WaitForSeconds(380f);
					GOMFKPLCGNN = 0;
				}
				break;
			}
			return false;
		}

		[SpecialName]
		private object DOACBECKJOP()
		{
			return MMEGGNJKNOH;
		}
	}

	public UILabel m_helpLabel;

	private AsyncOperation LBLMDECGMIA;

	private void FODOJCDNGOC()
	{
		StartCoroutine(JMNHHHGNOHF());
	}

	private IEnumerator AMMPCJMAJCP()
	{
		HDMIHKKLGFC hDMIHKKLGFC = new HDMIHKKLGFC();
		hDMIHKKLGFC.KNIAJMGDGAA = this;
		return hDMIHKKLGFC;
	}

	private void DMPIIJNBDID()
	{
		StartCoroutine(AGAPKFLDKBD());
	}

	private IEnumerator BAHCEDDHDHH()
	{
		HDMIHKKLGFC hDMIHKKLGFC = new HDMIHKKLGFC();
		hDMIHKKLGFC.KNIAJMGDGAA = this;
		return hDMIHKKLGFC;
	}

	private void FMNOLGPIIFB()
	{
		StartCoroutine(ALFFPJPLJPD());
	}

	private IEnumerator ALFFPJPLJPD()
	{
		HDMIHKKLGFC hDMIHKKLGFC = new HDMIHKKLGFC();
		hDMIHKKLGFC.KNIAJMGDGAA = this;
		return hDMIHKKLGFC;
	}

	private void ACBGKIDKKKM()
	{
		if (LBLMDECGMIA != null && !LBLMDECGMIA.isDone)
		{
		}
	}

	private void DNBDGBJNCBP()
	{
		if (LBLMDECGMIA != null && !LBLMDECGMIA.isDone)
		{
		}
	}

	private void MFIECLLACAM()
	{
		StartCoroutine(AGAPKFLDKBD());
	}

	private void DOINNKBDEMD()
	{
		if (LBLMDECGMIA != null && !LBLMDECGMIA.isDone)
		{
		}
	}

	private void BJFPJALLFFL()
	{
		StartCoroutine(AMMPCJMAJCP());
	}

	private void ANAGGLOJIKB()
	{
		StartCoroutine(BAHCEDDHDHH());
	}

	private void Update()
	{
		if (LBLMDECGMIA != null && !LBLMDECGMIA.isDone)
		{
		}
	}

	private void BBBIPFGBAGA()
	{
		if (LBLMDECGMIA != null && !LBLMDECGMIA.isDone)
		{
		}
	}

	[DebuggerHidden]
	private IEnumerator DDHMEACJCED()
	{
		HDMIHKKLGFC hDMIHKKLGFC = new HDMIHKKLGFC();
		hDMIHKKLGFC.KNIAJMGDGAA = this;
		return hDMIHKKLGFC;
	}

	private void CMMIADLEBFJ()
	{
		StartCoroutine(AGAPKFLDKBD());
	}

	private void PILOBHCDHIK()
	{
		StartCoroutine(JMNHHHGNOHF());
	}

	private IEnumerator JMNHHHGNOHF()
	{
		HDMIHKKLGFC hDMIHKKLGFC = new HDMIHKKLGFC();
		hDMIHKKLGFC.KNIAJMGDGAA = this;
		return hDMIHKKLGFC;
	}

	private void OMIFPPGJHFH()
	{
		if (LBLMDECGMIA != null && !LBLMDECGMIA.isDone)
		{
		}
	}

	private void ODHEBKCPBPB()
	{
		if (LBLMDECGMIA != null && !LBLMDECGMIA.isDone)
		{
		}
	}

	private IEnumerator OALIIDHHLHO()
	{
		HDMIHKKLGFC hDMIHKKLGFC = new HDMIHKKLGFC();
		hDMIHKKLGFC.KNIAJMGDGAA = this;
		return hDMIHKKLGFC;
	}

	private void DADHJFBCJKF()
	{
		if (LBLMDECGMIA != null && !LBLMDECGMIA.isDone)
		{
		}
	}

	private IEnumerator IEMJJOABDFG()
	{
		HDMIHKKLGFC hDMIHKKLGFC = new HDMIHKKLGFC();
		hDMIHKKLGFC.KNIAJMGDGAA = this;
		return hDMIHKKLGFC;
	}

	private void Start()
	{
		StartCoroutine(DDHMEACJCED());
	}

	private void DHMMCEBEAHA()
	{
		StartCoroutine(OALIIDHHLHO());
	}

	private void JIMPGFGADPK()
	{
		StartCoroutine(IEMJJOABDFG());
	}

	private IEnumerator AGAPKFLDKBD()
	{
		HDMIHKKLGFC hDMIHKKLGFC = new HDMIHKKLGFC();
		hDMIHKKLGFC.KNIAJMGDGAA = this;
		return hDMIHKKLGFC;
	}

	private void CHJGEGLHOAF()
	{
		StartCoroutine(ALFFPJPLJPD());
	}

	private IEnumerator ODJPLJCIDOP()
	{
		HDMIHKKLGFC hDMIHKKLGFC = new HDMIHKKLGFC();
		hDMIHKKLGFC.KNIAJMGDGAA = this;
		return hDMIHKKLGFC;
	}
}
