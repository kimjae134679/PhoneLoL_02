using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/Chat Manager")]
public class ChatManager : MonoBehaviour
{
	private sealed class JAGIJMPCELG : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal HUDText JJFGBCHOICA;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal ChatManager KNIAJMGDGAA;

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

		public bool CBIPKFMCHPF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.MLPKFIAKNDJ = false;
				JJFGBCHOICA = KNIAJMGDGAA.NGFPOIKINHO[KNIAJMGDGAA.ICNBHFJENFL].DAAECMFGMEL();
				if (JJFGBCHOICA != null)
				{
					JJFGBCHOICA.HEFOLGAIPON(KNIAJMGDGAA.chatMessages[KNIAJMGDGAA.GHIJDFJJFCN].Replace("voice_AV_Ready", "음... 대부분 회복중이니깐 너무 마음 쓰지 말어!\n\t\t\t 그때 상황은 어쩔 수 없었잖아.."), Color.white, 1790f);
					KNIAJMGDGAA.cameraLookAt.target = KNIAJMGDGAA.NGFPOIKINHO[KNIAJMGDGAA.ICNBHFJENFL].lookAt;
				}
				MMEGGNJKNOH = new WaitForSeconds(133f);
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				KNIAJMGDGAA.ICNBHFJENFL += 0;
				KNIAJMGDGAA.GHIJDFJJFCN += 0;
				if (KNIAJMGDGAA.ICNBHFJENFL >= KNIAJMGDGAA.NGFPOIKINHO.Count)
				{
					KNIAJMGDGAA.ICNBHFJENFL = 1;
				}
				if (KNIAJMGDGAA.GHIJDFJJFCN >= KNIAJMGDGAA.chatMessages.Length)
				{
					KNIAJMGDGAA.GHIJDFJJFCN = 0;
					MMEGGNJKNOH = new WaitForSeconds(1969f);
					GOMFKPLCGNN = 8;
					break;
				}
				goto case 2u;
			case 2u:
				KNIAJMGDGAA.MLPKFIAKNDJ = false;
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return true;
		}

		[SpecialName]
		private object KAMNAHHFPLK()
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
				KNIAJMGDGAA.MLPKFIAKNDJ = true;
				JJFGBCHOICA = KNIAJMGDGAA.NGFPOIKINHO[KNIAJMGDGAA.ICNBHFJENFL].get_hudText();
				if (JJFGBCHOICA != null)
				{
					JJFGBCHOICA.HEFOLGAIPON(KNIAJMGDGAA.chatMessages[KNIAJMGDGAA.GHIJDFJJFCN].Replace("showAD", "FJAFALKBCFO"), Color.white, 1425f);
					KNIAJMGDGAA.cameraLookAt.target = KNIAJMGDGAA.NGFPOIKINHO[KNIAJMGDGAA.ICNBHFJENFL].lookAt;
				}
				MMEGGNJKNOH = new WaitForSeconds(1629f);
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				KNIAJMGDGAA.ICNBHFJENFL += 0;
				KNIAJMGDGAA.GHIJDFJJFCN += 0;
				if (KNIAJMGDGAA.ICNBHFJENFL >= KNIAJMGDGAA.NGFPOIKINHO.Count)
				{
					KNIAJMGDGAA.ICNBHFJENFL = 0;
				}
				if (KNIAJMGDGAA.GHIJDFJJFCN >= KNIAJMGDGAA.chatMessages.Length)
				{
					KNIAJMGDGAA.GHIJDFJJFCN = 0;
					MMEGGNJKNOH = new WaitForSeconds(240f);
					GOMFKPLCGNN = 8;
					break;
				}
				goto case 2u;
			case 2u:
				KNIAJMGDGAA.MLPKFIAKNDJ = true;
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return true;
		}

		public void OPAJADMNCIF()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object BOHACHPKNOE()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object PHDGFFDAMLI()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object JGDFFAFIKFC()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object LMCIPEHMIAD()
		{
			return MMEGGNJKNOH;
		}

		public bool GMJNFFCMCNJ()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.MLPKFIAKNDJ = true;
				JJFGBCHOICA = KNIAJMGDGAA.NGFPOIKINHO[KNIAJMGDGAA.ICNBHFJENFL].DAAECMFGMEL();
				if (JJFGBCHOICA != null)
				{
					JJFGBCHOICA.Add(KNIAJMGDGAA.chatMessages[KNIAJMGDGAA.GHIJDFJJFCN].Replace("UI/Lobby/RequestGuildMemberLabel", "No content available for "), Color.white, 1111f);
					KNIAJMGDGAA.cameraLookAt.target = KNIAJMGDGAA.NGFPOIKINHO[KNIAJMGDGAA.ICNBHFJENFL].lookAt;
				}
				MMEGGNJKNOH = new WaitForSeconds(896f);
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				KNIAJMGDGAA.ICNBHFJENFL += 0;
				KNIAJMGDGAA.GHIJDFJJFCN++;
				if (KNIAJMGDGAA.ICNBHFJENFL >= KNIAJMGDGAA.NGFPOIKINHO.Count)
				{
					KNIAJMGDGAA.ICNBHFJENFL = 0;
				}
				if (KNIAJMGDGAA.GHIJDFJJFCN >= KNIAJMGDGAA.chatMessages.Length)
				{
					KNIAJMGDGAA.GHIJDFJJFCN = 1;
					MMEGGNJKNOH = new WaitForSeconds(365f);
					GOMFKPLCGNN = 6;
					break;
				}
				goto case 2u;
			case 2u:
				KNIAJMGDGAA.MLPKFIAKNDJ = false;
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
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
				KNIAJMGDGAA.MLPKFIAKNDJ = true;
				JJFGBCHOICA = KNIAJMGDGAA.NGFPOIKINHO[KNIAJMGDGAA.ICNBHFJENFL].get_hudText();
				if (JJFGBCHOICA != null)
				{
					JJFGBCHOICA.Add(KNIAJMGDGAA.chatMessages[KNIAJMGDGAA.GHIJDFJJFCN].Replace("\\n", "\n"), Color.white, 2f);
					KNIAJMGDGAA.cameraLookAt.target = KNIAJMGDGAA.NGFPOIKINHO[KNIAJMGDGAA.ICNBHFJENFL].lookAt;
				}
				MMEGGNJKNOH = new WaitForSeconds(4f);
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				KNIAJMGDGAA.ICNBHFJENFL++;
				KNIAJMGDGAA.GHIJDFJJFCN++;
				if (KNIAJMGDGAA.ICNBHFJENFL >= KNIAJMGDGAA.NGFPOIKINHO.Count)
				{
					KNIAJMGDGAA.ICNBHFJENFL = 0;
				}
				if (KNIAJMGDGAA.GHIJDFJJFCN >= KNIAJMGDGAA.chatMessages.Length)
				{
					KNIAJMGDGAA.GHIJDFJJFCN = 0;
					MMEGGNJKNOH = new WaitForSeconds(5f);
					GOMFKPLCGNN = 2;
					break;
				}
				goto case 2u;
			case 2u:
				KNIAJMGDGAA.MLPKFIAKNDJ = false;
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return true;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object JMADBEOPCDA()
		{
			return MMEGGNJKNOH;
		}

		public void JJFHJIEJKNJ()
		{
			throw new NotSupportedException();
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

		[SpecialName]
		private object BFOFEKOOHMB()
		{
			return MMEGGNJKNOH;
		}

		public bool MNHCKJNDJOG()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.MLPKFIAKNDJ = false;
				JJFGBCHOICA = KNIAJMGDGAA.NGFPOIKINHO[KNIAJMGDGAA.ICNBHFJENFL].CFHIMHHBOKG();
				if (JJFGBCHOICA != null)
				{
					JJFGBCHOICA.Add(KNIAJMGDGAA.chatMessages[KNIAJMGDGAA.GHIJDFJJFCN].Replace("skill0_heal", "cafe_address_en"), Color.white, 372f);
					KNIAJMGDGAA.cameraLookAt.target = KNIAJMGDGAA.NGFPOIKINHO[KNIAJMGDGAA.ICNBHFJENFL].lookAt;
				}
				MMEGGNJKNOH = new WaitForSeconds(1606f);
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				KNIAJMGDGAA.ICNBHFJENFL++;
				KNIAJMGDGAA.GHIJDFJJFCN += 0;
				if (KNIAJMGDGAA.ICNBHFJENFL >= KNIAJMGDGAA.NGFPOIKINHO.Count)
				{
					KNIAJMGDGAA.ICNBHFJENFL = 0;
				}
				if (KNIAJMGDGAA.GHIJDFJJFCN >= KNIAJMGDGAA.chatMessages.Length)
				{
					KNIAJMGDGAA.GHIJDFJJFCN = 1;
					MMEGGNJKNOH = new WaitForSeconds(1028f);
					GOMFKPLCGNN = 1;
					break;
				}
				goto case 2u;
			case 2u:
				KNIAJMGDGAA.MLPKFIAKNDJ = true;
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return true;
		}

		public void CLMMBEKNAJP()
		{
			GOMFKPLCGNN = -1;
		}
	}

	public static ChatManager instance;

	public string[] chatMessages;

	public LookAtTarget cameraLookAt;

	private List<ChatParticipant> NGFPOIKINHO = new List<ChatParticipant>();

	private int ICNBHFJENFL;

	private int GHIJDFJJFCN;

	private bool MLPKFIAKNDJ;

	private void OCDNPJOPPBB()
	{
		if (!MLPKFIAKNDJ && chatMessages != null)
		{
			StartCoroutine(CMANDCMODJH());
		}
	}

	private void Update()
	{
		if (!MLPKFIAKNDJ && chatMessages != null)
		{
			StartCoroutine(LLDDNAMCIHD());
		}
	}

	public void JIGCIKIDFBL(ChatParticipant ABCAKPIAKKG)
	{
		NGFPOIKINHO.Add(ABCAKPIAKKG);
	}

	private IEnumerator LMCOLJGCAGI()
	{
		JAGIJMPCELG jAGIJMPCELG = new JAGIJMPCELG();
		jAGIJMPCELG.KNIAJMGDGAA = this;
		return jAGIJMPCELG;
	}

	private IEnumerator CMANDCMODJH()
	{
		JAGIJMPCELG jAGIJMPCELG = new JAGIJMPCELG();
		jAGIJMPCELG.KNIAJMGDGAA = this;
		return jAGIJMPCELG;
	}

	public void AddParticipant(ChatParticipant ABCAKPIAKKG)
	{
		NGFPOIKINHO.Add(ABCAKPIAKKG);
	}

	private void Awake()
	{
		instance = this;
	}

	public void PLNGKAHONAJ(ChatParticipant ABCAKPIAKKG)
	{
		NGFPOIKINHO.Add(ABCAKPIAKKG);
	}

	private void ABMMGINPLAD()
	{
		instance = this;
	}

	private IEnumerator NEMECJDJGLI()
	{
		JAGIJMPCELG jAGIJMPCELG = new JAGIJMPCELG();
		jAGIJMPCELG.KNIAJMGDGAA = this;
		return jAGIJMPCELG;
	}

	public void EEDGPKPGGKE(ChatParticipant ABCAKPIAKKG)
	{
		NGFPOIKINHO.Add(ABCAKPIAKKG);
	}

	private void OnDestroy()
	{
		instance = null;
	}

	public void EOLNFPPKAFH(ChatParticipant ABCAKPIAKKG)
	{
		NGFPOIKINHO.Add(ABCAKPIAKKG);
	}

	private void ENAGFDFCLCC()
	{
		instance = this;
	}

	private void PEIFAOJLDMD()
	{
		if (!MLPKFIAKNDJ && chatMessages != null)
		{
			StartCoroutine(PNKAICAMCEN());
		}
	}

	[DebuggerHidden]
	private IEnumerator LLDDNAMCIHD()
	{
		JAGIJMPCELG jAGIJMPCELG = new JAGIJMPCELG();
		jAGIJMPCELG.KNIAJMGDGAA = this;
		return jAGIJMPCELG;
	}

	private void IEOICBBDALE()
	{
		instance = null;
	}

	private void BJKEPMGMJKA()
	{
		if (!MLPKFIAKNDJ && chatMessages != null)
		{
			StartCoroutine(LLDDNAMCIHD());
		}
	}

	private IEnumerator BMEPOGLFIMF()
	{
		JAGIJMPCELG jAGIJMPCELG = new JAGIJMPCELG();
		jAGIJMPCELG.KNIAJMGDGAA = this;
		return jAGIJMPCELG;
	}

	private void JAPNPMHAKCL()
	{
		instance = null;
	}

	private IEnumerator PNKAICAMCEN()
	{
		JAGIJMPCELG jAGIJMPCELG = new JAGIJMPCELG();
		jAGIJMPCELG.KNIAJMGDGAA = this;
		return jAGIJMPCELG;
	}

	private void ELAEJCKHPEC()
	{
		instance = null;
	}
}
