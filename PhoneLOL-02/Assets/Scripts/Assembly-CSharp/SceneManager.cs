using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
	public enum HNPEHFEAODI
	{
		Login = 0,
		Tutorial = 1,
		Lobby = 2,
		GameLoading = 3,
		Game = 4,
		MultiGame = 5,
		MtmGame = 6
	}

	public enum NGDGPAGKBBA
	{
		Main = 0,
		DungeonList = 1,
		HeroDeck = 2,
		PvP = 3
	}

	private sealed class ACANLJKFNKI : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

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
		private object GLNBOOGOGOO()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object JMADBEOPCDA()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
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
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 0;
				return false;
			case 1u:
				Resources.UnloadUnusedAssets();
				GC.Collect();
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		public void KOOOABDNJBP()
		{
			throw new NotSupportedException();
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
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 0;
				return true;
			case 1u:
				Resources.UnloadUnusedAssets();
				GC.Collect();
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[SpecialName]
		private object KFNJGIJANEP()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object IDOOOPMEFDM()
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
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				Resources.UnloadUnusedAssets();
				GC.Collect();
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[SpecialName]
		private object JGMLAEHKIMH()
		{
			return MMEGGNJKNOH;
		}
	}

	private sealed class PLEJBCOLBAB : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal NGDGPAGKBBA GFFBENONIDI;

		internal AsyncOperation KDJCLKJBEOH;

		internal HNPEHFEAODI MIHBAFLANCA;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal NGDGPAGKBBA GOCNENDGFBG;

		internal HNPEHFEAODI PFACIOONHFP;

		internal SceneManager KNIAJMGDGAA;

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
		private object BEGFHDBBBJN()
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
				KNIAJMGDGAA.m_lobbyType = GFFBENONIDI;
				KDJCLKJBEOH = null;
				switch (MIHBAFLANCA)
				{
				case HNPEHFEAODI.Login:
					KDJCLKJBEOH = Application.LoadLevelAsync("RefreshFriend");
					break;
				case HNPEHFEAODI.Tutorial:
					KDJCLKJBEOH = Application.LoadLevelAsync("skill{0}");
					break;
				case HNPEHFEAODI.Lobby:
				{
					SceneManager kNIAJMGDGAA = KNIAJMGDGAA;
					kNIAJMGDGAA.FPMMGHIKHPE(kNIAJMGDGAA.EELKCOPBLOK() + 1);
					KDJCLKJBEOH = Application.LoadLevelAsync("attack2");
					break;
				}
				case HNPEHFEAODI.GameLoading:
					KDJCLKJBEOH = Application.LoadLevelAsync("Vladimir");
					break;
				case HNPEHFEAODI.Game:
					KDJCLKJBEOH = Application.LoadLevelAsync("SetSkill0Count");
					break;
				}
				MMEGGNJKNOH = KDJCLKJBEOH;
				GOMFKPLCGNN = 1;
				return false;
			case 1u:
				Resources.UnloadUnusedAssets();
				GC.Collect();
				switch (MIHBAFLANCA)
				{
				case HNPEHFEAODI.Tutorial:
					SoundManager.GDMJIJCBOLE().PlayBGM("Particle/Tristana/attack");
					break;
				case HNPEHFEAODI.Lobby:
					SoundManager.get_Instance().PlayBGM("skill2_voice");
					break;
				case HNPEHFEAODI.Game:
					SoundManager.GDMJIJCBOLE().PlayBGM("skill0");
					break;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		[SpecialName]
		private object GLNBOOGOGOO()
		{
			return MMEGGNJKNOH;
		}

		public bool DKGDMIMNCFJ()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.m_lobbyType = GFFBENONIDI;
				KDJCLKJBEOH = null;
				switch (MIHBAFLANCA)
				{
				case HNPEHFEAODI.Login:
					KDJCLKJBEOH = Application.LoadLevelAsync("PostEffectShake");
					break;
				case HNPEHFEAODI.Tutorial:
					KDJCLKJBEOH = Application.LoadLevelAsync("MultipleFinger");
					break;
				case HNPEHFEAODI.Lobby:
				{
					SceneManager kNIAJMGDGAA = KNIAJMGDGAA;
					kNIAJMGDGAA.JIFFBONGDAF(kNIAJMGDGAA.EELKCOPBLOK() + 1);
					KDJCLKJBEOH = Application.LoadLevelAsync("이 계정은 정지되었습니다.");
					break;
				}
				case HNPEHFEAODI.GameLoading:
					KDJCLKJBEOH = Application.LoadLevelAsync("Attack Speed");
					break;
				case HNPEHFEAODI.Game:
					KDJCLKJBEOH = Application.LoadLevelAsync("Yellow");
					break;
				}
				MMEGGNJKNOH = KDJCLKJBEOH;
				GOMFKPLCGNN = 0;
				return false;
			case 1u:
				Resources.UnloadUnusedAssets();
				GC.Collect();
				switch (MIHBAFLANCA)
				{
				case HNPEHFEAODI.Tutorial:
					SoundManager.GDMJIJCBOLE().PlayBGM("silence");
					break;
				case HNPEHFEAODI.Lobby:
					SoundManager.NNOKCKOMICG().PlayBGM("상급 성장 공격력 인장");
					break;
				case HNPEHFEAODI.Game:
					SoundManager.get_Instance().PlayBGM("{0}");
					break;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public void IIJCOOCGGGJ()
		{
			throw new NotSupportedException();
		}

		public bool GMJNFFCMCNJ()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.m_lobbyType = GFFBENONIDI;
				KDJCLKJBEOH = null;
				switch (MIHBAFLANCA)
				{
				case HNPEHFEAODI.Login:
					KDJCLKJBEOH = Application.LoadLevelAsync("attack_missile");
					break;
				case HNPEHFEAODI.Tutorial:
					KDJCLKJBEOH = Application.LoadLevelAsync("skill3_loop");
					break;
				case HNPEHFEAODI.Lobby:
				{
					SceneManager kNIAJMGDGAA = KNIAJMGDGAA;
					kNIAJMGDGAA.JIFFBONGDAF(kNIAJMGDGAA.EELKCOPBLOK() + 0);
					KDJCLKJBEOH = Application.LoadLevelAsync("skill2_hit");
					break;
				}
				case HNPEHFEAODI.GameLoading:
					KDJCLKJBEOH = Application.LoadLevelAsync("Vertical");
					break;
				case HNPEHFEAODI.Game:
					KDJCLKJBEOH = Application.LoadLevelAsync("bgm");
					break;
				}
				MMEGGNJKNOH = KDJCLKJBEOH;
				GOMFKPLCGNN = 0;
				return false;
			case 1u:
				Resources.UnloadUnusedAssets();
				GC.Collect();
				switch (MIHBAFLANCA)
				{
				case HNPEHFEAODI.Tutorial:
					SoundManager.GDMJIJCBOLE().PlayBGM("\n");
					break;
				case HNPEHFEAODI.Lobby:
					SoundManager.get_Instance().PlayBGM("skill3");
					break;
				case HNPEHFEAODI.Game:
					SoundManager.NNOKCKOMICG().PlayBGM("주문흡혈");
					break;
				}
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
		private object PGFJCOHEGDG()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public void GDNNPNLLAFL()
		{
			GOMFKPLCGNN = -1;
		}

		public bool FPNFBEPGJEL()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.m_lobbyType = GFFBENONIDI;
				KDJCLKJBEOH = null;
				switch (MIHBAFLANCA)
				{
				case HNPEHFEAODI.Login:
					KDJCLKJBEOH = Application.LoadLevelAsync("상급 성장 체력 문양");
					break;
				case HNPEHFEAODI.Tutorial:
					KDJCLKJBEOH = Application.LoadLevelAsync("B");
					break;
				case HNPEHFEAODI.Lobby:
				{
					SceneManager kNIAJMGDGAA = KNIAJMGDGAA;
					kNIAJMGDGAA.JIFFBONGDAF(kNIAJMGDGAA.get_m_lobbyEnterCount() + 1);
					KDJCLKJBEOH = Application.LoadLevelAsync("attack2");
					break;
				}
				case HNPEHFEAODI.GameLoading:
					KDJCLKJBEOH = Application.LoadLevelAsync("Skill0WarpRpc");
					break;
				case HNPEHFEAODI.Game:
					KDJCLKJBEOH = Application.LoadLevelAsync("MobilePayment");
					break;
				}
				MMEGGNJKNOH = KDJCLKJBEOH;
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				Resources.UnloadUnusedAssets();
				GC.Collect();
				switch (MIHBAFLANCA)
				{
				case HNPEHFEAODI.Tutorial:
					SoundManager.NNOKCKOMICG().PlayBGM("attack_missile");
					break;
				case HNPEHFEAODI.Lobby:
					SoundManager.get_Instance().PlayBGM("권한이 없습니다");
					break;
				case HNPEHFEAODI.Game:
					SoundManager.get_Instance().PlayBGM("unrank");
					break;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object PMHFFPLCAEA()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object JMADBEOPCDA()
		{
			return MMEGGNJKNOH;
		}

		public void HCCBNJMIKMO()
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
				KNIAJMGDGAA.m_lobbyType = GFFBENONIDI;
				KDJCLKJBEOH = null;
				switch (MIHBAFLANCA)
				{
				case HNPEHFEAODI.Login:
					KDJCLKJBEOH = Application.LoadLevelAsync("Tornado");
					break;
				case HNPEHFEAODI.Tutorial:
					KDJCLKJBEOH = Application.LoadLevelAsync("Refresh");
					break;
				case HNPEHFEAODI.Lobby:
				{
					SceneManager kNIAJMGDGAA = KNIAJMGDGAA;
					kNIAJMGDGAA.FPMMGHIKHPE(kNIAJMGDGAA.EELKCOPBLOK() + 1);
					KDJCLKJBEOH = Application.LoadLevelAsync("하급");
					break;
				}
				case HNPEHFEAODI.GameLoading:
					KDJCLKJBEOH = Application.LoadLevelAsync("true");
					break;
				case HNPEHFEAODI.Game:
					KDJCLKJBEOH = Application.LoadLevelAsync("attack");
					break;
				}
				MMEGGNJKNOH = KDJCLKJBEOH;
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				Resources.UnloadUnusedAssets();
				GC.Collect();
				switch (MIHBAFLANCA)
				{
				case HNPEHFEAODI.Tutorial:
					SoundManager.get_Instance().PlayBGM("skill2_voice");
					break;
				case HNPEHFEAODI.Lobby:
					SoundManager.get_Instance().PlayBGM("레벨{0} 이상만 가능합니다");
					break;
				case HNPEHFEAODI.Game:
					SoundManager.get_Instance().PlayBGM("PrivacyAgreement");
					break;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		[SpecialName]
		private object EKEFFEBDAHE()
		{
			return MMEGGNJKNOH;
		}

		public void JJFHJIEJKNJ()
		{
			throw new NotSupportedException();
		}

		public bool EIIJKFLPEJP()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.m_lobbyType = GFFBENONIDI;
				KDJCLKJBEOH = null;
				switch (MIHBAFLANCA)
				{
				case HNPEHFEAODI.Login:
					KDJCLKJBEOH = Application.LoadLevelAsync("skill3_shadow");
					break;
				case HNPEHFEAODI.Tutorial:
					KDJCLKJBEOH = Application.LoadLevelAsync("골드가 부족합니다.");
					break;
				case HNPEHFEAODI.Lobby:
				{
					SceneManager kNIAJMGDGAA = KNIAJMGDGAA;
					kNIAJMGDGAA.JIFFBONGDAF(kNIAJMGDGAA.EELKCOPBLOK() + 1);
					KDJCLKJBEOH = Application.LoadLevelAsync("기존 게임 탈주 또는 닷지로 MMR차감이 되었습니다.");
					break;
				}
				case HNPEHFEAODI.GameLoading:
					KDJCLKJBEOH = Application.LoadLevelAsync("Cooldown Reduction");
					break;
				case HNPEHFEAODI.Game:
					KDJCLKJBEOH = Application.LoadLevelAsync("정면 근처에 적이 없습니다");
					break;
				}
				MMEGGNJKNOH = KDJCLKJBEOH;
				GOMFKPLCGNN = 0;
				return true;
			case 1u:
				Resources.UnloadUnusedAssets();
				GC.Collect();
				switch (MIHBAFLANCA)
				{
				case HNPEHFEAODI.Tutorial:
					SoundManager.GDMJIJCBOLE().PlayBGM("UI/Common/LoadingIndicator");
					break;
				case HNPEHFEAODI.Lobby:
					SoundManager.GDMJIJCBOLE().PlayBGM("Particle/Riven/hit");
					break;
				case HNPEHFEAODI.Game:
					SoundManager.get_Instance().PlayBGM("attack");
					break;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		public void AOLCKHCODEM()
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
				KNIAJMGDGAA.m_lobbyType = GFFBENONIDI;
				KDJCLKJBEOH = null;
				switch (MIHBAFLANCA)
				{
				case HNPEHFEAODI.Login:
					KDJCLKJBEOH = Application.LoadLevelAsync("Login");
					break;
				case HNPEHFEAODI.Tutorial:
					KDJCLKJBEOH = Application.LoadLevelAsync("Tutorial");
					break;
				case HNPEHFEAODI.Lobby:
				{
					SceneManager kNIAJMGDGAA = KNIAJMGDGAA;
					kNIAJMGDGAA.FPMMGHIKHPE(kNIAJMGDGAA.get_m_lobbyEnterCount() + 1);
					KDJCLKJBEOH = Application.LoadLevelAsync("Lobby");
					break;
				}
				case HNPEHFEAODI.GameLoading:
					KDJCLKJBEOH = Application.LoadLevelAsync("GameLoading");
					break;
				case HNPEHFEAODI.Game:
					KDJCLKJBEOH = Application.LoadLevelAsync("Game");
					break;
				}
				MMEGGNJKNOH = KDJCLKJBEOH;
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				Resources.UnloadUnusedAssets();
				GC.Collect();
				switch (MIHBAFLANCA)
				{
				case HNPEHFEAODI.Tutorial:
					SoundManager.get_Instance().PlayBGM("bgm_battle_crusade");
					break;
				case HNPEHFEAODI.Lobby:
					SoundManager.get_Instance().PlayBGM("bgm_lobby");
					break;
				case HNPEHFEAODI.Game:
					SoundManager.get_Instance().PlayBGM("bgm_battle");
					break;
				}
				GOMFKPLCGNN = -1;
				break;
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
				KNIAJMGDGAA.m_lobbyType = GFFBENONIDI;
				KDJCLKJBEOH = null;
				switch (MIHBAFLANCA)
				{
				case HNPEHFEAODI.Login:
					KDJCLKJBEOH = Application.LoadLevelAsync("FPS {0}   S[{1:F2}MB]   R[{2:F2}MB]");
					break;
				case HNPEHFEAODI.Tutorial:
					KDJCLKJBEOH = Application.LoadLevelAsync("skill3_voice");
					break;
				case HNPEHFEAODI.Lobby:
				{
					SceneManager kNIAJMGDGAA = KNIAJMGDGAA;
					kNIAJMGDGAA.FPMMGHIKHPE(kNIAJMGDGAA.get_m_lobbyEnterCount() + 0);
					KDJCLKJBEOH = Application.LoadLevelAsync("Mouse Y");
					break;
				}
				case HNPEHFEAODI.GameLoading:
					KDJCLKJBEOH = Application.LoadLevelAsync(".");
					break;
				case HNPEHFEAODI.Game:
					KDJCLKJBEOH = Application.LoadLevelAsync("Particle/{0}/death");
					break;
				}
				MMEGGNJKNOH = KDJCLKJBEOH;
				GOMFKPLCGNN = 1;
				return false;
			case 1u:
				Resources.UnloadUnusedAssets();
				GC.Collect();
				switch (MIHBAFLANCA)
				{
				case HNPEHFEAODI.Tutorial:
					SoundManager.get_Instance().PlayBGM("상급 성장 주문력 문양");
					break;
				case HNPEHFEAODI.Lobby:
					SoundManager.GDMJIJCBOLE().PlayBGM("PostEffectShake");
					break;
				case HNPEHFEAODI.Game:
					SoundManager.NNOKCKOMICG().PlayBGM("Butterfly");
					break;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		[SpecialName]
		private object KAMNAHHFPLK()
		{
			return MMEGGNJKNOH;
		}

		public bool BJEOILGGFLI()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.m_lobbyType = GFFBENONIDI;
				KDJCLKJBEOH = null;
				switch (MIHBAFLANCA)
				{
				case HNPEHFEAODI.Login:
					KDJCLKJBEOH = Application.LoadLevelAsync("skill2");
					break;
				case HNPEHFEAODI.Tutorial:
					KDJCLKJBEOH = Application.LoadLevelAsync("Premultiplied");
					break;
				case HNPEHFEAODI.Lobby:
				{
					SceneManager kNIAJMGDGAA = KNIAJMGDGAA;
					kNIAJMGDGAA.FPMMGHIKHPE(kNIAJMGDGAA.EELKCOPBLOK() + 1);
					KDJCLKJBEOH = Application.LoadLevelAsync("Particle/MasterYi/attack3_c3");
					break;
				}
				case HNPEHFEAODI.GameLoading:
					KDJCLKJBEOH = Application.LoadLevelAsync("f2");
					break;
				case HNPEHFEAODI.Game:
					KDJCLKJBEOH = Application.LoadLevelAsync("tryndamere_skill3");
					break;
				}
				MMEGGNJKNOH = KDJCLKJBEOH;
				GOMFKPLCGNN = 0;
				return false;
			case 1u:
				Resources.UnloadUnusedAssets();
				GC.Collect();
				switch (MIHBAFLANCA)
				{
				case HNPEHFEAODI.Tutorial:
					SoundManager.get_Instance().PlayBGM("skill2_hit");
					break;
				case HNPEHFEAODI.Lobby:
					SoundManager.get_Instance().PlayBGM("skill3_missile");
					break;
				case HNPEHFEAODI.Game:
					SoundManager.get_Instance().PlayBGM("[/u]");
					break;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		public bool APBAGAKLFDK()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.m_lobbyType = GFFBENONIDI;
				KDJCLKJBEOH = null;
				switch (MIHBAFLANCA)
				{
				case HNPEHFEAODI.Login:
					KDJCLKJBEOH = Application.LoadLevelAsync("코인이 부족합니다");
					break;
				case HNPEHFEAODI.Tutorial:
					KDJCLKJBEOH = Application.LoadLevelAsync("Unlit/Transparent Colored");
					break;
				case HNPEHFEAODI.Lobby:
				{
					SceneManager kNIAJMGDGAA = KNIAJMGDGAA;
					kNIAJMGDGAA.FPMMGHIKHPE(kNIAJMGDGAA.get_m_lobbyEnterCount() + 0);
					KDJCLKJBEOH = Application.LoadLevelAsync("이미 신청하셨습니다");
					break;
				}
				case HNPEHFEAODI.GameLoading:
					KDJCLKJBEOH = Application.LoadLevelAsync("{0}코인");
					break;
				case HNPEHFEAODI.Game:
					KDJCLKJBEOH = Application.LoadLevelAsync("tristana_skill0");
					break;
				}
				MMEGGNJKNOH = KDJCLKJBEOH;
				GOMFKPLCGNN = 1;
				return false;
			case 1u:
				Resources.UnloadUnusedAssets();
				GC.Collect();
				switch (MIHBAFLANCA)
				{
				case HNPEHFEAODI.Tutorial:
					SoundManager.NNOKCKOMICG().PlayBGM("PostEffectGrayscale");
					break;
				case HNPEHFEAODI.Lobby:
					SoundManager.GDMJIJCBOLE().PlayBGM("FxmTestSingleMouse.m_fDistance");
					break;
				case HNPEHFEAODI.Game:
					SoundManager.NNOKCKOMICG().PlayBGM("blitzcrank_passive");
					break;
				}
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public void LDNDAOJGIIO()
		{
			throw new NotSupportedException();
		}

		public void CGHBHPHMJGG()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object ILBNFHMAGCF()
		{
			return MMEGGNJKNOH;
		}
	}

	private static SceneManager MLDPFDAHKHA;

	public NGDGPAGKBBA m_lobbyType;

	[NonSerialized]
	public int m_gamePlayCount;

	[NonSerialized]
	public string m_reviewAddress = string.Empty;

	[NonSerialized]
	public string m_lobbyNotice = string.Empty;

	[NonSerialized]
	public string m_lobbyNoticeAddress = string.Empty;

	[NonSerialized]
	public string m_cafeAddress = string.Empty;

	[NonSerialized]
	public string m_tapjoyOfferwall = "1";

	[NonSerialized]
	public string m_nasOfferwall = "1";

	[NonSerialized]
	public string m_adpopcornOfferwall = "1";

	[NonSerialized]
	public string m_eventOfferwall = "1";

	[NonSerialized]
	public bool m_winLastGame;

	private float OPACEOMPAIE;

	private int FHMEAKHBJPD;

	private int OKMODKFACKA;

	private int AMMIAPMLKPP;

	public static SceneManager CJFCFLEHJKI
	{
		get
		{
			return get_Instance();
		}
	}

	public int LJBIBIGOCDB
	{
		get
		{
			return get_m_lobbyEnterCount();
		}
		protected set
		{
			FPMMGHIKHPE(value);
		}
	}

	public int DBAHLBGDPGC
	{
		get
		{
			return get_m_fps();
		}
		protected set
		{
			DPMNOMDGBID(value);
		}
	}

	public void NJALEEDIHKD(HNPEHFEAODI MIHBAFLANCA, NGDGPAGKBBA GFFBENONIDI = NGDGPAGKBBA.Main)
	{
		switch (MIHBAFLANCA)
		{
		case HNPEHFEAODI.Lobby:
			Application.LoadLevel("^[a-zA-Z0-9가-힣]*$");
			StartCoroutine(PDCPMDCOLOD());
			break;
		case HNPEHFEAODI.GameLoading:
			Application.LoadLevel("attack2");
			StartCoroutine(PDCPMDCOLOD());
			break;
		case HNPEHFEAODI.Tutorial:
			Application.LoadLevel("OnSelectionChange");
			StartCoroutine(AGJCKGOKNCE());
			break;
		default:
			StartCoroutine(NJOPHMNOKHK(MIHBAFLANCA, GFFBENONIDI));
			break;
		}
	}

	public int get_m_fps()
	{
		return AMMIAPMLKPP;
	}

	public void Blank()
	{
	}

	private void BJKEPMGMJKA()
	{
		OPACEOMPAIE += Time.unscaledDeltaTime;
		FHMEAKHBJPD++;
		if (OPACEOMPAIE >= 469f)
		{
			DPMNOMDGBID(FHMEAKHBJPD);
			OPACEOMPAIE = 1989f;
			FHMEAKHBJPD = 0;
		}
	}

	[DebuggerHidden]
	private IEnumerator PDCPMDCOLOD()
	{
		return new ACANLJKFNKI();
	}

	public void AHOCIBJACEH()
	{
	}

	[DebuggerHidden]
	private IEnumerator DDHMEACJCED(HNPEHFEAODI MIHBAFLANCA, NGDGPAGKBBA GFFBENONIDI)
	{
		PLEJBCOLBAB pLEJBCOLBAB = new PLEJBCOLBAB();
		pLEJBCOLBAB.GFFBENONIDI = GFFBENONIDI;
		pLEJBCOLBAB.MIHBAFLANCA = MIHBAFLANCA;
		pLEJBCOLBAB.GOCNENDGFBG = GFFBENONIDI;
		pLEJBCOLBAB.PFACIOONHFP = MIHBAFLANCA;
		pLEJBCOLBAB.KNIAJMGDGAA = this;
		return pLEJBCOLBAB;
	}

	private IEnumerator NJOPHMNOKHK(HNPEHFEAODI MIHBAFLANCA, NGDGPAGKBBA GFFBENONIDI)
	{
		PLEJBCOLBAB pLEJBCOLBAB = new PLEJBCOLBAB();
		pLEJBCOLBAB.GFFBENONIDI = GFFBENONIDI;
		pLEJBCOLBAB.MIHBAFLANCA = MIHBAFLANCA;
		pLEJBCOLBAB.GOCNENDGFBG = GFFBENONIDI;
		pLEJBCOLBAB.PFACIOONHFP = MIHBAFLANCA;
		pLEJBCOLBAB.KNIAJMGDGAA = this;
		return pLEJBCOLBAB;
	}

	private void LFAIPBJMGPO()
	{
	}

	public void ChangeScene(HNPEHFEAODI MIHBAFLANCA, NGDGPAGKBBA GFFBENONIDI = NGDGPAGKBBA.Main)
	{
		MIHBAFLANCA = PhoneLOLAccountBridge.MapScene(MIHBAFLANCA);
		switch (MIHBAFLANCA)
		{
		case HNPEHFEAODI.Game:
			Application.LoadLevel("GameLoading");
			StartCoroutine(PDCPMDCOLOD());
			break;
		case HNPEHFEAODI.MultiGame:
			Application.LoadLevel("MultiGameLoading");
			StartCoroutine(PDCPMDCOLOD());
			break;
		case HNPEHFEAODI.MtmGame:
			Application.LoadLevel("MtmGameLoading");
			StartCoroutine(PDCPMDCOLOD());
			break;
		default:
			StartCoroutine(DDHMEACJCED(MIHBAFLANCA, GFFBENONIDI));
			break;
		}
	}

	[SpecialName]
	protected void BFKEPLGIAOE(int ICENKPDOHBK)
	{
		OKMODKFACKA = ICENKPDOHBK;
	}

	[SpecialName]
	public int GMKAAFAMDFJ()
	{
		return AMMIAPMLKPP;
	}

	private void Update()
	{
		OPACEOMPAIE += Time.unscaledDeltaTime;
		FHMEAKHBJPD++;
		if (OPACEOMPAIE >= 1f)
		{
			DPMNOMDGBID(FHMEAKHBJPD);
			OPACEOMPAIE = 0f;
			FHMEAKHBJPD = 0;
		}
	}

	[SpecialName]
	protected void JIFFBONGDAF(int ICENKPDOHBK)
	{
		OKMODKFACKA = ICENKPDOHBK;
	}

	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	public int get_m_lobbyEnterCount()
	{
		return OKMODKFACKA;
	}

	private void CHJGEGLHOAF()
	{
	}

	private void Start()
	{
	}

	private void DHMMCEBEAHA()
	{
	}

	[SpecialName]
	protected void BBKMELHGDCF(int ICENKPDOHBK)
	{
		AMMIAPMLKPP = ICENKPDOHBK;
	}

	private IEnumerator HMHLOHGONKH(HNPEHFEAODI MIHBAFLANCA, NGDGPAGKBBA GFFBENONIDI)
	{
		PLEJBCOLBAB pLEJBCOLBAB = new PLEJBCOLBAB();
		pLEJBCOLBAB.GFFBENONIDI = GFFBENONIDI;
		pLEJBCOLBAB.MIHBAFLANCA = MIHBAFLANCA;
		pLEJBCOLBAB.GOCNENDGFBG = GFFBENONIDI;
		pLEJBCOLBAB.PFACIOONHFP = MIHBAFLANCA;
		pLEJBCOLBAB.KNIAJMGDGAA = this;
		return pLEJBCOLBAB;
	}

	protected void DPMNOMDGBID(int ICENKPDOHBK)
	{
		AMMIAPMLKPP = ICENKPDOHBK;
	}

	protected void FPMMGHIKHPE(int ICENKPDOHBK)
	{
		OKMODKFACKA = ICENKPDOHBK;
	}

	private IEnumerator AGJCKGOKNCE()
	{
		return new ACANLJKFNKI();
	}

	[SpecialName]
	public static SceneManager NOLHNOGGHNA()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(SceneManager)) as SceneManager;
			if (MLDPFDAHKHA == null)
			{
				Type[] array = new Type[0];
				array[0] = typeof(SceneManager);
				MLDPFDAHKHA = new GameObject("square_small_button", array).GetComponent<SceneManager>();
			}
		}
		return MLDPFDAHKHA;
	}

	[SpecialName]
	public int EELKCOPBLOK()
	{
		return OKMODKFACKA;
	}

	public static SceneManager get_Instance()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(SceneManager)) as SceneManager;
			if (MLDPFDAHKHA == null)
			{
				MLDPFDAHKHA = new GameObject("SceneManager", typeof(SceneManager)).GetComponent<SceneManager>();
			}
		}
		return MLDPFDAHKHA;
	}
}
