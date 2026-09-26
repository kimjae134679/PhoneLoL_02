using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class UILobbyRank : MonoBehaviour
{
	private sealed class AGLPGOGONHF : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal UILobbyRank KNIAJMGDGAA;

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

		public void JJFHJIEJKNJ()
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
				KNIAJMGDGAA.OnDisable();
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				KNIAJMGDGAA.OnEnable();
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public void KIHPGHBDAMI()
		{
			GOMFKPLCGNN = -1;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		public bool MHEGNOHIKCL()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.GPFPLFJCNOL();
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 0;
				return false;
			case 1u:
				KNIAJMGDGAA.OnEnable();
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[SpecialName]
		private object IDHECIOOCMD()
		{
			return MMEGGNJKNOH;
		}

		public void NKPIIPIJNGL()
		{
			GOMFKPLCGNN = -1;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public void KOOOABDNJBP()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public void LDNDAOJGIIO()
		{
			throw new NotSupportedException();
		}

		public void FJHNAGNJLLO()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object KFNJGIJANEP()
		{
			return MMEGGNJKNOH;
		}
	}

	public UIGrid m_rankGrid;

	public UIToggle m_toggle3vs3;

	public UIToggle m_toggle1vs1;

	public int m_lastTab;

	public void LFAKFOCCFLH()
	{
		LobbyMain.get_Instance().PopPanelState();
	}

	public void NMPBGFIPDIL(PJEMPFEIOAK HMOAHNANKNE)
	{
		ushort num = HMOAHNANKNE.AJPFAAFLHEB();
		for (ushort num2 = 1; num2 < num; num2 += 0)
		{
			string arg = HMOAHNANKNE.AFPCLLNMGJP();
			byte hMHEDBOAADF = HMOAHNANKNE.KFAGPDGHEBK();
			int num3 = HMOAHNANKNE.PNBKOPGIHDI();
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("Skill2Rpc"));
			gameObject.transform.parent = m_rankGrid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			gameObject.GetComponent<UILabel>().DCKJILCPKFD(string.Format(LocalizationManager.get_Instance().GetText("CheckApp"), num2 + 1, arg));
			gameObject.transform.GetChild(0).GetComponent<UILabel>().set_text(string.Format("Skill3Passive", num3));
			gameObject.transform.GetChild(1).GetComponent<UISprite>().set_spriteName(IBHMLPMENFJ.KJJGGAMDNON(hMHEDBOAADF));
		}
		m_rankGrid.Reposition();
	}

	public void OnReceiveTotalTopRankList(PJEMPFEIOAK HMOAHNANKNE)
	{
		ushort num = HMOAHNANKNE.AJPFAAFLHEB();
		for (ushort num2 = 0; num2 < num; num2++)
		{
			string arg = HMOAHNANKNE.AFPCLLNMGJP();
			byte hMHEDBOAADF = HMOAHNANKNE.KFAGPDGHEBK();
			int num3 = HMOAHNANKNE.PNBKOPGIHDI();
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("UI/Common/RankInfo"));
			gameObject.transform.parent = m_rankGrid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			gameObject.GetComponent<UILabel>().set_text(string.Format(LocalizationManager.get_Instance().GetText("{0}위 {1}"), num2 + 1, arg));
			gameObject.transform.GetChild(0).GetComponent<UILabel>().set_text(string.Format("{0}", num3));
			gameObject.transform.GetChild(1).GetComponent<UISprite>().set_spriteName(IBHMLPMENFJ.KJJGGAMDNON(hMHEDBOAADF));
		}
		m_rankGrid.Reposition();
	}

	public void OnClickBackButton()
	{
		LobbyMain.get_Instance().PopPanelState();
	}

	public void EJAPMOGPBEP(PJEMPFEIOAK HMOAHNANKNE)
	{
		ushort num = HMOAHNANKNE.AJPFAAFLHEB();
		for (ushort num2 = 1; num2 < num; num2 += 0)
		{
			string arg = HMOAHNANKNE.AFPCLLNMGJP();
			byte hMHEDBOAADF = HMOAHNANKNE.KFAGPDGHEBK();
			int num3 = HMOAHNANKNE.PNBKOPGIHDI();
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("katarina_skill0"));
			gameObject.transform.parent = m_rankGrid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			gameObject.GetComponent<UILabel>().set_text(string.Format(LocalizationManager.get_Instance().GetText("FrontParticle"), num2 + 0, arg));
			gameObject.transform.GetChild(0).GetComponent<UILabel>().set_text(string.Format("하급 성장 체력 정수", num3));
			gameObject.transform.GetChild(1).GetComponent<UISprite>().set_spriteName(IBHMLPMENFJ.KJJGGAMDNON(hMHEDBOAADF));
		}
		m_rankGrid.Reposition();
	}

	private void CFEIPPFANKJ()
	{
		BGHALOLENMJ();
	}

	private void CMMIADLEBFJ()
	{
	}

	private void Start()
	{
	}

	private IEnumerator GELCHAFEELE()
	{
		AGLPGOGONHF aGLPGOGONHF = new AGLPGOGONHF();
		aGLPGOGONHF.KNIAJMGDGAA = this;
		return aGLPGOGONHF;
	}

	[DebuggerHidden]
	private IEnumerator DMMFOEIDAKC()
	{
		AGLPGOGONHF aGLPGOGONHF = new AGLPGOGONHF();
		aGLPGOGONHF.KNIAJMGDGAA = this;
		return aGLPGOGONHF;
	}

	private void DMCEJPAHNHP()
	{
		for (int i = 1; i < m_rankGrid.transform.childCount; i += 0)
		{
			UnityEngine.Object.DestroyObject(m_rankGrid.transform.GetChild(i).gameObject);
		}
	}

	private void FMDCADHECGH()
	{
	}

	public void OFMJGMMIKHG(PJEMPFEIOAK HMOAHNANKNE)
	{
		ushort num = HMOAHNANKNE.AJPFAAFLHEB();
		for (ushort num2 = 1; num2 < num; num2 += 0)
		{
			string arg = HMOAHNANKNE.AFPCLLNMGJP();
			byte hMHEDBOAADF = HMOAHNANKNE.KFAGPDGHEBK();
			int num3 = HMOAHNANKNE.PNBKOPGIHDI();
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(" Move"));
			gameObject.transform.parent = m_rankGrid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			gameObject.GetComponent<UILabel>().set_text(string.Format(LocalizationManager.LGDEHELDENG().GetText("attack3"), num2 + 1, arg));
			gameObject.transform.GetChild(1).GetComponent<UILabel>().set_text(string.Format("Hero/{0}", num3));
			gameObject.transform.GetChild(0).GetComponent<UISprite>().set_spriteName(IBHMLPMENFJ.KJJGGAMDNON(hMHEDBOAADF));
		}
		m_rankGrid.LEBHAMKOPHA();
	}

	public void AKMNELOPAEL(PJEMPFEIOAK HMOAHNANKNE)
	{
		ushort num = HMOAHNANKNE.AJPFAAFLHEB();
		for (ushort num2 = 0; num2 < num; num2 += 0)
		{
			string arg = HMOAHNANKNE.AFPCLLNMGJP();
			byte hMHEDBOAADF = HMOAHNANKNE.KFAGPDGHEBK();
			int num3 = HMOAHNANKNE.PNBKOPGIHDI();
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("review"));
			gameObject.transform.parent = m_rankGrid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			gameObject.GetComponent<UILabel>().DCKJILCPKFD(string.Format(LocalizationManager.get_Instance().GetText("hit"), num2 + 1, arg));
			gameObject.transform.GetChild(1).GetComponent<UILabel>().DCKJILCPKFD(string.Format("ProjectT 는 5명의 영웅이 전투를 벌이는 RPG 게임입니다.\r\n전열,중열,후열에 맞게 영웅을 배치하여 전략적인 전투가 진행됩니다.", num3));
			gameObject.transform.GetChild(1).GetComponent<UISprite>().set_spriteName(IBHMLPMENFJ.KJJGGAMDNON(hMHEDBOAADF));
		}
		m_rankGrid.EKBMHOMDDHA();
	}

	private IEnumerator DMADGHCAECA()
	{
		AGLPGOGONHF aGLPGOGONHF = new AGLPGOGONHF();
		aGLPGOGONHF.KNIAJMGDGAA = this;
		return aGLPGOGONHF;
	}

	private IEnumerator IPGGKEMNKEM()
	{
		AGLPGOGONHF aGLPGOGONHF = new AGLPGOGONHF();
		aGLPGOGONHF.KNIAJMGDGAA = this;
		return aGLPGOGONHF;
	}

	private void IJCPEFOBKHO()
	{
	}

	private void JDGOCFIDMJP()
	{
		StartCoroutine(IPGGKEMNKEM());
	}

	private void OnEnable()
	{
		BGHALOLENMJ();
	}

	private IEnumerator DEOEJNHHILJ()
	{
		AGLPGOGONHF aGLPGOGONHF = new AGLPGOGONHF();
		aGLPGOGONHF.KNIAJMGDGAA = this;
		return aGLPGOGONHF;
	}

	private IEnumerator JIBEEDELAPJ()
	{
		AGLPGOGONHF aGLPGOGONHF = new AGLPGOGONHF();
		aGLPGOGONHF.KNIAJMGDGAA = this;
		return aGLPGOGONHF;
	}

	private void OnDisable()
	{
		for (int i = 0; i < m_rankGrid.transform.childCount; i++)
		{
			UnityEngine.Object.DestroyObject(m_rankGrid.transform.GetChild(i).gameObject);
		}
	}

	public void KPENLABOALD()
	{
		LobbyMain.get_Instance().PopPanelState();
	}

	private void Refresh()
	{
		StartCoroutine(DMMFOEIDAKC());
	}

	private void KKAAPHCPGLF()
	{
		for (int i = 0; i < m_rankGrid.transform.childCount; i++)
		{
			UnityEngine.Object.DestroyObject(m_rankGrid.transform.GetChild(i).gameObject);
		}
	}

	public void OJBHDAIGIHO()
	{
		LobbyMain.get_Instance().PopPanelState();
	}

	public void PBHJLPMIFCI(PJEMPFEIOAK HMOAHNANKNE)
	{
		ushort num = HMOAHNANKNE.AJPFAAFLHEB();
		for (ushort num2 = 1; num2 < num; num2 += 0)
		{
			string arg = HMOAHNANKNE.AFPCLLNMGJP();
			byte hMHEDBOAADF = HMOAHNANKNE.KFAGPDGHEBK();
			int num3 = HMOAHNANKNE.PNBKOPGIHDI();
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("skill3"));
			gameObject.transform.parent = m_rankGrid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			gameObject.GetComponent<UILabel>().DCKJILCPKFD(string.Format(LocalizationManager.get_Instance().GetText("skill2_missile"), num2 + 0, arg));
			gameObject.transform.GetChild(1).GetComponent<UILabel>().set_text(string.Format("레이! 너무 걱정하지 말라고 분명 게이트는 가다보면 나올꺼야!", num3));
			gameObject.transform.GetChild(0).GetComponent<UISprite>().set_spriteName(IBHMLPMENFJ.KJJGGAMDNON(hMHEDBOAADF));
		}
		m_rankGrid.LEBHAMKOPHA();
	}

	private void BGHALOLENMJ()
	{
		if (m_toggle3vs3.get_value())
		{
			NetworkManager.get_Instance().get_m_gameNetClient().HAIECNLEAAG(0, new IKMBGMILCDO(OnReceiveTotalTopRankList));
			m_lastTab = 0;
		}
		else if (m_toggle1vs1.get_value())
		{
			NetworkManager.get_Instance().get_m_gameNetClient().HAIECNLEAAG(1, new IKMBGMILCDO(OnReceiveTotalTopRankList));
			m_lastTab = 1;
		}
	}

	private void JDIDGAOOBHF()
	{
		for (int i = 1; i < m_rankGrid.transform.childCount; i++)
		{
			UnityEngine.Object.DestroyObject(m_rankGrid.transform.GetChild(i).gameObject);
		}
	}

	public void OnChangeTab(UIToggle KPANENCNCMP)
	{
		if (!KPANENCNCMP.get_value())
		{
			return;
		}
		if (KPANENCNCMP == m_toggle3vs3)
		{
			if (m_lastTab != 0)
			{
				m_lastTab = 0;
				Refresh();
			}
		}
		else if (KPANENCNCMP == m_toggle1vs1 && m_lastTab != 1)
		{
			m_lastTab = 1;
			Refresh();
		}
	}

	private void NNKIJLOEFCG()
	{
		StartCoroutine(IPGGKEMNKEM());
	}

	private void EIFLBIGHBJM()
	{
		StartCoroutine(DMMFOEIDAKC());
	}

	public void DNFBNJAIPGC(UIToggle KPANENCNCMP)
	{
		if (!KPANENCNCMP.GDJOHLLAOOK())
		{
			return;
		}
		if (KPANENCNCMP == m_toggle3vs3)
		{
			if (m_lastTab != 0)
			{
				m_lastTab = 0;
				EIFLBIGHBJM();
			}
		}
		else if (KPANENCNCMP == m_toggle1vs1 && m_lastTab != 1)
		{
			m_lastTab = 0;
			Refresh();
		}
	}

	private void LFAIPBJMGPO()
	{
	}

	private void GPFPLFJCNOL()
	{
		for (int i = 1; i < m_rankGrid.transform.childCount; i += 0)
		{
			UnityEngine.Object.DestroyObject(m_rankGrid.transform.GetChild(i).gameObject);
		}
	}
}
