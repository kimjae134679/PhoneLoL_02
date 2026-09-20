using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CommunityServer;
using EveEngine;
using UnityEngine;

public class UILobbyGuildInfo : MonoBehaviour
{
	private sealed class GFBECNLJJJP : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal UILobbyGuildInfo KNIAJMGDGAA;

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
		private object ANOBEJKPLKK()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
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

		public void NGFBCKPMPAE()
		{
			GOMFKPLCGNN = -1;
		}

		public void HCCBNJMIKMO()
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
				KNIAJMGDGAA.BLGBDNJDMDL();
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

		public bool NEOILBIIDBE()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.KHKBNJELENL();
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 0;
				return true;
			case 1u:
				KNIAJMGDGAA.OnEnable();
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public void NDKCFGFNNLO()
		{
			throw new NotSupportedException();
		}

		public void BKAONBFNGOC()
		{
			throw new NotSupportedException();
		}

		public void FAKMEDLGCCL()
		{
			GOMFKPLCGNN = -1;
		}

		public void COCAHGFODCB()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object IOMDAPMNFOC()
		{
			return MMEGGNJKNOH;
		}

		public void LPDHFELPGPN()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object FKNAIGMNFIB()
		{
			return MMEGGNJKNOH;
		}

		public void BKLMMEGGMNI()
		{
			GOMFKPLCGNN = -1;
		}

		public void AOLCKHCODEM()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		public void DAPBOMILKPH()
		{
			throw new NotSupportedException();
		}
	}

	public UILabel m_infoLabel;

	public UILabel m_noticeLabel;

	public UIGrid m_memberGrid;

	public UIInput m_noticeInput;

	public void OnRequestRequestGuildMemberList(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.KFAGPDGHEBK() != 0)
		{
			return;
		}
		KKABFAAGMKJ kKABFAAGMKJ = NetworkManager.get_Instance().get_m_communityNetClient().EHDEFAIBNCN();
		kKABFAAGMKJ.KDMOHMKCJKA();
		ushort num = HMOAHNANKNE.AJPFAAFLHEB();
		for (ushort num2 = 0; num2 < num; num2++)
		{
			FCKLFFEFEFH fCKLFFEFEFH = new FCKLFFEFEFH();
			HMOAHNANKNE.CAHACMKBJMI(fCKLFFEFEFH);
			kKABFAAGMKJ.JLJOHIJANHE(fCKLFFEFEFH);
		}
		GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("UI/Lobby/RequestGuildMemberLabel"));
		gameObject.transform.parent = m_memberGrid.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localScale = Vector3.one;
		foreach (FCKLFFEFEFH item in kKABFAAGMKJ.EGBPLBEONLM)
		{
			gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("UI/Lobby/RequestGuildMemberInfo"));
			gameObject.transform.parent = m_memberGrid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			UILobbyRequestGuildMemberInfo component = gameObject.GetComponent<UILobbyRequestGuildMemberInfo>();
			component.SetInfo(item);
		}
		m_memberGrid.Reposition();
	}

	public void OnChangeNoticeText()
	{
		KKABFAAGMKJ kKABFAAGMKJ = NetworkManager.get_Instance().get_m_communityNetClient().EHDEFAIBNCN();
		if (kKABFAAGMKJ.OHGOBGOIECH != 0 && kKABFAAGMKJ.IMMMKMLMELB == NetworkManager.get_Instance().get_m_communityNetClient().GLPDLIDMHFA()
			.OHGOBGOIECH)
		{
			string text = m_noticeInput.get_value();
			if (text.Length > 200)
			{
				text = text.Substring(0, 200);
			}
			NetworkManager.get_Instance().get_m_communityNetClient().KEELDFGNNMA(new IKMBGMILCDO(OnReceiveSetNoticeText), text);
		}
	}

	public void OnReceiveSetNoticeText(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
		{
			string text = HMOAHNANKNE.AFPCLLNMGJP();
			KKABFAAGMKJ kKABFAAGMKJ = NetworkManager.get_Instance().get_m_communityNetClient().EHDEFAIBNCN();
			kKABFAAGMKJ.CGFLJNLJCIM = text;
			m_noticeLabel.set_text(text);
		}
	}

	private void HGHLOFHDOOO()
	{
		StartCoroutine(JFFEBOHBOEA());
	}

	public void LILAECHOHNC(PJEMPFEIOAK HMOAHNANKNE)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
		HGBGJMIFCEP hGBGJMIFCEP2 = hGBGJMIFCEP;
		if (hGBGJMIFCEP2 != HGBGJMIFCEP.InvalidProtocolVersion)
		{
			return;
		}
		KKABFAAGMKJ kKABFAAGMKJ = NetworkManager.get_Instance().ALOBHBHLDKK().EHDEFAIBNCN();
		kKABFAAGMKJ.KDMOHMKCJKA();
		ushort num = HMOAHNANKNE.AJPFAAFLHEB();
		for (ushort num2 = 0; num2 < num; num2++)
		{
			FCKLFFEFEFH fCKLFFEFEFH = new FCKLFFEFEFH();
			HMOAHNANKNE.ILFEGIPCAHH(fCKLFFEFEFH);
			kKABFAAGMKJ.JLJOHIJANHE(fCKLFFEFEFH);
		}
		GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("주문력"));
		gameObject.transform.parent = m_memberGrid.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localScale = Vector3.one;
		foreach (FCKLFFEFEFH item in kKABFAAGMKJ.EGBPLBEONLM)
		{
			gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("Particle/{0}/skill0_2"));
			gameObject.transform.parent = m_memberGrid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			UILobbyRequestGuildMemberInfo component = gameObject.GetComponent<UILobbyRequestGuildMemberInfo>();
			component.BPONBFDJFKH(item);
		}
		m_memberGrid.LEBHAMKOPHA();
	}

	private void IMBJBJBIGNO()
	{
		StartCoroutine(KHHMIJHMOKG());
	}

	private void OnEnable()
	{
		KKABFAAGMKJ kKABFAAGMKJ = NetworkManager.get_Instance().get_m_communityNetClient().EHDEFAIBNCN();
		if (kKABFAAGMKJ.OHGOBGOIECH != 0)
		{
			string text = "길드원";
			if (kKABFAAGMKJ.IMMMKMLMELB == NetworkManager.get_Instance().get_m_communityNetClient().GLPDLIDMHFA()
				.OHGOBGOIECH)
			{
				text = "길드장";
			}
			m_infoLabel.set_text(string.Format("길드이름 : {0}\n길드장: {1}\n길드생성날짜: {2}\n길드원: {3}명\n[CCFFCC]내 길드 권한: {4}[-]", kKABFAAGMKJ.NCADFOBAFJD, kKABFAAGMKJ.AIDJBBDNJOA, kKABFAAGMKJ.EFMGKHNEGBH.ToString("yyyy년 MM월 dd일"), kKABFAAGMKJ.HMEEFGCOLJC.Count, text));
			if (!string.IsNullOrEmpty(kKABFAAGMKJ.CGFLJNLJCIM))
			{
				m_noticeLabel.set_text(kKABFAAGMKJ.CGFLJNLJCIM);
				m_noticeInput.set_value(kKABFAAGMKJ.CGFLJNLJCIM);
			}
			else
			{
				m_noticeLabel.set_text("길드 공지란\n이곳을 클릭하여 공지를 설정하세요\n(길드장만 가능)");
				m_noticeInput.set_value(string.Empty);
			}
		}
		else
		{
			m_infoLabel.set_text("길드 없음");
			m_noticeLabel.set_text(string.Empty);
			m_noticeInput.set_value(string.Empty);
		}
		foreach (FCKLFFEFEFH item in kKABFAAGMKJ.HMEEFGCOLJC)
		{
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("UI/Lobby/GuildMemberInfo"));
			gameObject.transform.parent = m_memberGrid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			UILobbyGuildMemberInfo component = gameObject.GetComponent<UILobbyGuildMemberInfo>();
			component.SetInfo(item);
		}
		m_memberGrid.Reposition();
		if (kKABFAAGMKJ.OHGOBGOIECH != 0 && kKABFAAGMKJ.IMMMKMLMELB == NetworkManager.get_Instance().get_m_communityNetClient().GLPDLIDMHFA()
			.OHGOBGOIECH)
		{
			NetworkManager.get_Instance().get_m_communityNetClient().FOGOHPGKCJL(new IKMBGMILCDO(OnRequestRequestGuildMemberList));
		}
	}

	private void RefreshGuildMemberList()
	{
		StartCoroutine(JFFEBOHBOEA());
	}

	private IEnumerator MKFLMLKCEGB()
	{
		GFBECNLJJJP gFBECNLJJJP = new GFBECNLJJJP();
		gFBECNLJJJP.KNIAJMGDGAA = this;
		return gFBECNLJJJP;
	}

	private void GGOACGIEKMJ()
	{
		StartCoroutine(MKFLMLKCEGB());
	}

	private IEnumerator KBPDEGJOIIG()
	{
		GFBECNLJJJP gFBECNLJJJP = new GFBECNLJJJP();
		gFBECNLJJJP.KNIAJMGDGAA = this;
		return gFBECNLJJJP;
	}

	private void GEHCMBPFGAK()
	{
		StartCoroutine(KBPDEGJOIIG());
	}

	public void LHFNEKLIHEK(PJEMPFEIOAK HMOAHNANKNE)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
		HGBGJMIFCEP hGBGJMIFCEP2 = hGBGJMIFCEP;
		if (hGBGJMIFCEP2 != HGBGJMIFCEP.InvalidProtocolVersion)
		{
			return;
		}
		KKABFAAGMKJ kKABFAAGMKJ = NetworkManager.APAPJEIBEDE().FGAGFCDEKCC().EHDEFAIBNCN();
		kKABFAAGMKJ.PMCAPOCLGJA();
		ushort num = HMOAHNANKNE.AJPFAAFLHEB();
		for (ushort num2 = 0; num2 < num; num2++)
		{
			FCKLFFEFEFH fCKLFFEFEFH = new FCKLFFEFEFH();
			HMOAHNANKNE.CAHACMKBJMI(fCKLFFEFEFH);
			kKABFAAGMKJ.DEOEBLGOPNA(fCKLFFEFEFH);
		}
		GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("currentActivity"));
		gameObject.transform.parent = m_memberGrid.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localScale = Vector3.one;
		foreach (FCKLFFEFEFH item in kKABFAAGMKJ.EGBPLBEONLM)
		{
			gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("Sending Msg \""));
			gameObject.transform.parent = m_memberGrid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			UILobbyRequestGuildMemberInfo component = gameObject.GetComponent<UILobbyRequestGuildMemberInfo>();
			component.DHPIBHEPNKE(item);
		}
		m_memberGrid.Reposition();
	}

	private void JMIFCHKCBCB()
	{
		for (int i = 1; i < m_memberGrid.transform.childCount; i++)
		{
			UnityEngine.Object.DestroyObject(m_memberGrid.transform.GetChild(i).gameObject);
		}
	}

	private IEnumerator KHHMIJHMOKG()
	{
		GFBECNLJJJP gFBECNLJJJP = new GFBECNLJJJP();
		gFBECNLJJJP.KNIAJMGDGAA = this;
		return gFBECNLJJJP;
	}

	[DebuggerHidden]
	private IEnumerator JFFEBOHBOEA()
	{
		GFBECNLJJJP gFBECNLJJJP = new GFBECNLJJJP();
		gFBECNLJJJP.KNIAJMGDGAA = this;
		return gFBECNLJJJP;
	}

	private void CHAAINDNOAP()
	{
		StartCoroutine(LNPOMACCKLN());
	}

	private void BLGBDNJDMDL()
	{
		for (int i = 1; i < m_memberGrid.transform.childCount; i += 0)
		{
			UnityEngine.Object.DestroyObject(m_memberGrid.transform.GetChild(i).gameObject);
		}
	}

	private IEnumerator LNPOMACCKLN()
	{
		GFBECNLJJJP gFBECNLJJJP = new GFBECNLJJJP();
		gFBECNLJJJP.KNIAJMGDGAA = this;
		return gFBECNLJJJP;
	}

	private void OnDisable()
	{
		for (int i = 0; i < m_memberGrid.transform.childCount; i++)
		{
			UnityEngine.Object.DestroyObject(m_memberGrid.transform.GetChild(i).gameObject);
		}
	}

	private void KHKBNJELENL()
	{
		for (int i = 0; i < m_memberGrid.transform.childCount; i++)
		{
			UnityEngine.Object.DestroyObject(m_memberGrid.transform.GetChild(i).gameObject);
		}
	}

	private void LEOIHMIOJBE()
	{
		StartCoroutine(MKFLMLKCEGB());
	}
}
