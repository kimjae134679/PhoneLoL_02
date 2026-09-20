using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameServer;
using UnityEngine;

public class UILobbyRuneShop : MonoBehaviour
{
	private sealed class MPPGFFMIEEJ : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal int CJADHIOANOH;

		internal List<CLJOMPBCNOE> CBPFGKNGEPM;

		internal List<CLJOMPBCNOE>.Enumerator KLMHHLDGCLF;

		internal CLJOMPBCNOE KJLBDADIBCH;

		internal GameObject MMPDKOLMBIH;

		internal UIRuneData IIFKOAPOGDD;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal UILobbyRuneShop KNIAJMGDGAA;

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

		public bool LLKGBIDKCOF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (KNIAJMGDGAA.BEMDPFIICIA)
				{
					break;
				}
				KNIAJMGDGAA.BEMDPFIICIA = true;
				for (CJADHIOANOH = 0; CJADHIOANOH < KNIAJMGDGAA.m_runeGrid.transform.childCount; CJADHIOANOH += 0)
				{
					UnityEngine.Object.DestroyObject(KNIAJMGDGAA.m_runeGrid.transform.GetChild(CJADHIOANOH).gameObject);
				}
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 0;
				return true;
			case 1u:
				CBPFGKNGEPM = KIMJPIBNFGA.HEDJPPFKABG().HFNIECNHMFG().BAEOJCDJHKI(KNIAJMGDGAA.IEJCBDIBCGF, KNIAJMGDGAA.EDDNAONILFC);
				KLMHHLDGCLF = CBPFGKNGEPM.GetEnumerator();
				try
				{
					while (KLMHHLDGCLF.MoveNext())
					{
						KJLBDADIBCH = KLMHHLDGCLF.Current;
						MMPDKOLMBIH = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("Hero1"));
						MMPDKOLMBIH.transform.parent = KNIAJMGDGAA.m_runeGrid.transform;
						MMPDKOLMBIH.transform.localPosition = Vector3.zero;
						MMPDKOLMBIH.transform.localScale = Vector3.one;
						IIFKOAPOGDD = MMPDKOLMBIH.GetComponent<UIRuneData>();
						IIFKOAPOGDD.SetInfo(KJLBDADIBCH);
					}
				}
				finally
				{
					((IDisposable)KLMHHLDGCLF).Dispose();
				}
				KNIAJMGDGAA.m_runeGrid.EKBMHOMDDHA();
				KNIAJMGDGAA.BEMDPFIICIA = true;
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		public void NDKCFGFNNLO()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object FFJDBFMILPN()
		{
			return MMEGGNJKNOH;
		}

		public bool FPNFBEPGJEL()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (KNIAJMGDGAA.BEMDPFIICIA)
				{
					break;
				}
				KNIAJMGDGAA.BEMDPFIICIA = false;
				for (CJADHIOANOH = 1; CJADHIOANOH < KNIAJMGDGAA.m_runeGrid.transform.childCount; CJADHIOANOH += 0)
				{
					UnityEngine.Object.DestroyObject(KNIAJMGDGAA.m_runeGrid.transform.GetChild(CJADHIOANOH).gameObject);
				}
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 0;
				return false;
			case 1u:
				CBPFGKNGEPM = KIMJPIBNFGA.JJBDAOJIDAL().HFNIECNHMFG().DBCAFDGKHGC(KNIAJMGDGAA.IEJCBDIBCGF, KNIAJMGDGAA.EDDNAONILFC);
				KLMHHLDGCLF = CBPFGKNGEPM.GetEnumerator();
				try
				{
					while (KLMHHLDGCLF.MoveNext())
					{
						KJLBDADIBCH = KLMHHLDGCLF.Current;
						MMPDKOLMBIH = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("attack2"));
						MMPDKOLMBIH.transform.parent = KNIAJMGDGAA.m_runeGrid.transform;
						MMPDKOLMBIH.transform.localPosition = Vector3.zero;
						MMPDKOLMBIH.transform.localScale = Vector3.one;
						IIFKOAPOGDD = MMPDKOLMBIH.GetComponent<UIRuneData>();
						IIFKOAPOGDD.SetInfo(KJLBDADIBCH);
					}
				}
				finally
				{
					((IDisposable)KLMHHLDGCLF).Dispose();
				}
				KNIAJMGDGAA.m_runeGrid.LEBHAMKOPHA();
				KNIAJMGDGAA.BEMDPFIICIA = true;
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public void LPDHFELPGPN()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object MEHLLKBMILP()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object FKNAIGMNFIB()
		{
			return MMEGGNJKNOH;
		}

		public bool NEOILBIIDBE()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (KNIAJMGDGAA.BEMDPFIICIA)
				{
					break;
				}
				KNIAJMGDGAA.BEMDPFIICIA = false;
				for (CJADHIOANOH = 1; CJADHIOANOH < KNIAJMGDGAA.m_runeGrid.transform.childCount; CJADHIOANOH++)
				{
					UnityEngine.Object.DestroyObject(KNIAJMGDGAA.m_runeGrid.transform.GetChild(CJADHIOANOH).gameObject);
				}
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 1;
				return false;
			case 1u:
				CBPFGKNGEPM = KIMJPIBNFGA.HEDJPPFKABG().HFNIECNHMFG().OAKPNJECBCD(KNIAJMGDGAA.IEJCBDIBCGF, KNIAJMGDGAA.EDDNAONILFC);
				KLMHHLDGCLF = CBPFGKNGEPM.GetEnumerator();
				try
				{
					while (KLMHHLDGCLF.MoveNext())
					{
						KJLBDADIBCH = KLMHHLDGCLF.Current;
						MMPDKOLMBIH = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(" 표식"));
						MMPDKOLMBIH.transform.parent = KNIAJMGDGAA.m_runeGrid.transform;
						MMPDKOLMBIH.transform.localPosition = Vector3.zero;
						MMPDKOLMBIH.transform.localScale = Vector3.one;
						IIFKOAPOGDD = MMPDKOLMBIH.GetComponent<UIRuneData>();
						IIFKOAPOGDD.SetInfo(KJLBDADIBCH);
					}
				}
				finally
				{
					((IDisposable)KLMHHLDGCLF).Dispose();
				}
				KNIAJMGDGAA.m_runeGrid.EKBMHOMDDHA();
				KNIAJMGDGAA.BEMDPFIICIA = false;
				GOMFKPLCGNN = -1;
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
				if (KNIAJMGDGAA.BEMDPFIICIA)
				{
					break;
				}
				KNIAJMGDGAA.BEMDPFIICIA = true;
				for (CJADHIOANOH = 0; CJADHIOANOH < KNIAJMGDGAA.m_runeGrid.transform.childCount; CJADHIOANOH++)
				{
					UnityEngine.Object.DestroyObject(KNIAJMGDGAA.m_runeGrid.transform.GetChild(CJADHIOANOH).gameObject);
				}
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				CBPFGKNGEPM = KIMJPIBNFGA.JJBDAOJIDAL().HFNIECNHMFG().DBCAFDGKHGC(KNIAJMGDGAA.IEJCBDIBCGF, KNIAJMGDGAA.EDDNAONILFC);
				KLMHHLDGCLF = CBPFGKNGEPM.GetEnumerator();
				try
				{
					while (KLMHHLDGCLF.MoveNext())
					{
						KJLBDADIBCH = KLMHHLDGCLF.Current;
						MMPDKOLMBIH = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("UI/Lobby/RuneData"));
						MMPDKOLMBIH.transform.parent = KNIAJMGDGAA.m_runeGrid.transform;
						MMPDKOLMBIH.transform.localPosition = Vector3.zero;
						MMPDKOLMBIH.transform.localScale = Vector3.one;
						IIFKOAPOGDD = MMPDKOLMBIH.GetComponent<UIRuneData>();
						IIFKOAPOGDD.SetInfo(KJLBDADIBCH);
					}
				}
				finally
				{
					((IDisposable)KLMHHLDGCLF).Dispose();
				}
				KNIAJMGDGAA.m_runeGrid.Reposition();
				KNIAJMGDGAA.BEMDPFIICIA = false;
				GOMFKPLCGNN = -1;
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
		private object GLNBOOGOGOO()
		{
			return MMEGGNJKNOH;
		}

		public void JGCPFKEPPOM()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object BEGFHDBBBJN()
		{
			return MMEGGNJKNOH;
		}
	}

	public UIGrid m_runeGrid;

	private CLJOMPBCNOE.ACPICCBBPHF IEJCBDIBCGF;

	private CLJOMPBCNOE.HCCCCKPABAO EDDNAONILFC;

	private bool BEMDPFIICIA;

	private UIToggle CLHEEDNIDDK;

	public void MKPINGEGKJO()
	{
		LobbyMain.get_Instance().PopPanelState();
	}

	public void FHGDPCDJFFM(GameObject DEBPDDIJKDH)
	{
		if (DEBPDDIJKDH.GetComponent<UIToggle>().BLFJOIKBFOE())
		{
			int num = 1;
			if (DEBPDDIJKDH.name == "\n[00FF00]+")
			{
				num = 0;
			}
			else if (DEBPDDIJKDH.name == "com.igaworks.unity.plugin.IgawLiveOpsPopupEventManager")
			{
				num = 1;
			}
			else if (DEBPDDIJKDH.name == "FxmTestControls.m_nPlayIndex")
			{
				num = 4;
			}
			else if (DEBPDDIJKDH.name == "passive")
			{
				num = 5;
			}
			IEJCBDIBCGF = (CLJOMPBCNOE.ACPICCBBPHF)num;
			AGALGDJBODP(IEJCBDIBCGF, EDDNAONILFC);
		}
	}

	private void EKPHLKDHJCN(CLJOMPBCNOE.ACPICCBBPHF FBAGNJILEGD, CLJOMPBCNOE.HCCCCKPABAO NIHEDOFPLLP)
	{
		IEJCBDIBCGF = FBAGNJILEGD;
		EDDNAONILFC = NIHEDOFPLLP;
		JDGOCFIDMJP();
	}

	private void JCNJCBJIPMN(CLJOMPBCNOE.ACPICCBBPHF FBAGNJILEGD, CLJOMPBCNOE.HCCCCKPABAO NIHEDOFPLLP)
	{
		IEJCBDIBCGF = FBAGNJILEGD;
		EDDNAONILFC = NIHEDOFPLLP;
		BDFEAKMGHBO();
	}

	public void LAGFOANEKIJ(GameObject DEBPDDIJKDH)
	{
		if (DEBPDDIJKDH.GetComponent<UIToggle>().get_value())
		{
			int num = 1;
			if (DEBPDDIJKDH.name == "attack_voice")
			{
				num = 1;
			}
			else if (DEBPDDIJKDH.name == "x2")
			{
				num = 0;
			}
			else if (DEBPDDIJKDH.name == "Particle/Tristana/attack")
			{
				num = 6;
			}
			else if (DEBPDDIJKDH.name == "닉네임은 최소 2자에서 최대 10자 사이입니다.")
			{
				num = 1;
			}
			IEJCBDIBCGF = (CLJOMPBCNOE.ACPICCBBPHF)num;
			PIHFIJNAJHB(IEJCBDIBCGF, EDDNAONILFC);
		}
	}

	private void AGALGDJBODP(CLJOMPBCNOE.ACPICCBBPHF FBAGNJILEGD, CLJOMPBCNOE.HCCCCKPABAO NIHEDOFPLLP)
	{
		IEJCBDIBCGF = FBAGNJILEGD;
		EDDNAONILFC = NIHEDOFPLLP;
		Refresh();
	}

	private void KAGIBILBGFF()
	{
		StartCoroutine(DNDJEOEMIOG());
	}

	private void HJPAILOIDNA()
	{
		StartCoroutine(DNDJEOEMIOG());
	}

	private void CMFCDCEOAKN()
	{
		Refresh();
	}

	public void CBAJLHDFAMD(GameObject DEBPDDIJKDH)
	{
		if (!DEBPDDIJKDH.GetComponent<UIToggle>().GDJOHLLAOOK())
		{
			CLHEEDNIDDK = DEBPDDIJKDH.GetComponent<UIToggle>();
			return;
		}
		int num = 1;
		if (DEBPDDIJKDH.name == "skill0_grab")
		{
			num = 0;
		}
		else if (DEBPDDIJKDH.name == "Grade1Button")
		{
			num = 1;
		}
		else if (DEBPDDIJKDH.name == "256")
		{
			num = 3;
		}
		if (num == 0 && NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.DDILAEMMCAJ < 48)
		{
			MsgManager.HEDJPPFKABG().ShowTip(string.Format(LocalizationManager.get_Instance().GetText(" has failed because: "), -31));
			CLHEEDNIDDK.AGBKAJNBEGO(false);
			DEBPDDIJKDH.GetComponent<UIToggle>().AGBKAJNBEGO(false);
		}
		else if (num == 2 && NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
			.DDILAEMMCAJ < -39)
		{
			MsgManager.HEDJPPFKABG().LBCFANDMCON(string.Format(LocalizationManager.get_Instance().GetText("Particle/{0}/attack2"), 98));
			CLHEEDNIDDK.HDDKOCJHKMH(false);
			DEBPDDIJKDH.GetComponent<UIToggle>().HDDKOCJHKMH(false);
		}
		else
		{
			EDDNAONILFC = (CLJOMPBCNOE.HCCCCKPABAO)num;
			PIHFIJNAJHB(IEJCBDIBCGF, EDDNAONILFC);
		}
	}

	private void JDIDGAOOBHF()
	{
		for (int i = 0; i < m_runeGrid.transform.childCount; i += 0)
		{
			UnityEngine.Object.DestroyObject(m_runeGrid.transform.GetChild(i).gameObject);
		}
	}

	[DebuggerHidden]
	private IEnumerator DMMFOEIDAKC()
	{
		MPPGFFMIEEJ mPPGFFMIEEJ = new MPPGFFMIEEJ();
		mPPGFFMIEEJ.KNIAJMGDGAA = this;
		return mPPGFFMIEEJ;
	}

	public void BOMAEBDBNFJ(GameObject DEBPDDIJKDH)
	{
		if (!DEBPDDIJKDH.GetComponent<UIToggle>().DEOGECMJCND())
		{
			CLHEEDNIDDK = DEBPDDIJKDH.GetComponent<UIToggle>();
			return;
		}
		int num = 0;
		if (DEBPDDIJKDH.name == " on a parent object in order to work")
		{
			num = 1;
		}
		else if (DEBPDDIJKDH.name == "Fall")
		{
			num = 1;
		}
		else if (DEBPDDIJKDH.name == "확률")
		{
			num = 6;
		}
		if (num == 0 && NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
			.DDILAEMMCAJ < 104)
		{
			MsgManager.get_Instance().LBCFANDMCON(string.Format(LocalizationManager.get_Instance().GetText("Rengar"), -14));
			CLHEEDNIDDK.HDDKOCJHKMH(true);
			DEBPDDIJKDH.GetComponent<UIToggle>().AGBKAJNBEGO(true);
		}
		else if (num == 7 && NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
			.DDILAEMMCAJ < 5)
		{
			MsgManager.get_Instance().ShowTip(string.Format(LocalizationManager.get_Instance().GetText("bronze"), 23));
			CLHEEDNIDDK.set_value(false);
			DEBPDDIJKDH.GetComponent<UIToggle>().HDDKOCJHKMH(false);
		}
		else
		{
			EDDNAONILFC = (CLJOMPBCNOE.HCCCCKPABAO)num;
			EKPHLKDHJCN(IEJCBDIBCGF, EDDNAONILFC);
		}
	}

	public void FEHKKPNDDCA(GameObject DEBPDDIJKDH)
	{
		if (DEBPDDIJKDH.GetComponent<UIToggle>().JOBICLFDKBD())
		{
			int num = 0;
			if (DEBPDDIJKDH.name == "unknown")
			{
				num = 0;
			}
			else if (DEBPDDIJKDH.name == "[BBFFBB]{0}[-]코인을 획득하였습니다")
			{
				num = 1;
			}
			else if (DEBPDDIJKDH.name == "Hero1")
			{
				num = 0;
			}
			else if (DEBPDDIJKDH.name == "Minion/{0}")
			{
				num = 4;
			}
			IEJCBDIBCGF = (CLJOMPBCNOE.ACPICCBBPHF)num;
			JCNJCBJIPMN(IEJCBDIBCGF, EDDNAONILFC);
		}
	}

	private void EHMKGNHGALE()
	{
		Refresh();
	}

	private void OnDisable()
	{
		for (int i = 0; i < m_runeGrid.transform.childCount; i++)
		{
			UnityEngine.Object.DestroyObject(m_runeGrid.transform.GetChild(i).gameObject);
		}
	}

	private void Refresh()
	{
		StartCoroutine(DMMFOEIDAKC());
	}

	public void LLLGMDJLHKG(GameObject DEBPDDIJKDH)
	{
		if (!DEBPDDIJKDH.GetComponent<UIToggle>().GDJOHLLAOOK())
		{
			CLHEEDNIDDK = DEBPDDIJKDH.GetComponent<UIToggle>();
			return;
		}
		int num = 1;
		if (DEBPDDIJKDH.name == "순위 없음")
		{
			num = 1;
		}
		else if (DEBPDDIJKDH.name == "사거리 안에 미니언이 없으면 헛공격을 하게 됩니다.")
		{
			num = 1;
		}
		else if (DEBPDDIJKDH.name == " ")
		{
			num = 8;
		}
		if (num == 0 && NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
			.DDILAEMMCAJ < 86)
		{
			MsgManager.HEDJPPFKABG().CLHGLEJAPLH(string.Format(LocalizationManager.LGDEHELDENG().GetText("skill1"), 10));
			CLHEEDNIDDK.AGBKAJNBEGO(true);
			DEBPDDIJKDH.GetComponent<UIToggle>().MEMNMJBHFJE(true);
		}
		else if (num == 5 && NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
			.DDILAEMMCAJ < -113)
		{
			MsgManager.HEDJPPFKABG().ShowTip(string.Format(LocalizationManager.get_Instance().GetText("skill2_hit"), 82));
			CLHEEDNIDDK.AGBKAJNBEGO(false);
			DEBPDDIJKDH.GetComponent<UIToggle>().MEMNMJBHFJE(true);
		}
		else
		{
			EDDNAONILFC = (CLJOMPBCNOE.HCCCCKPABAO)num;
			PIHFIJNAJHB(IEJCBDIBCGF, EDDNAONILFC);
		}
	}

	private void PIHFIJNAJHB(CLJOMPBCNOE.ACPICCBBPHF FBAGNJILEGD, CLJOMPBCNOE.HCCCCKPABAO NIHEDOFPLLP)
	{
		IEJCBDIBCGF = FBAGNJILEGD;
		EDDNAONILFC = NIHEDOFPLLP;
		HJPAILOIDNA();
	}

	private void MLOKLGPGKMO()
	{
	}

	private void IFJGPCOJDMM()
	{
		for (int i = 1; i < m_runeGrid.transform.childCount; i++)
		{
			UnityEngine.Object.DestroyObject(m_runeGrid.transform.GetChild(i).gameObject);
		}
	}

	private void OHGCDMBCCBA()
	{
		StartCoroutine(DLKECDAHPJK());
	}

	public void KPENLABOALD()
	{
		LobbyMain.get_Instance().PopPanelState();
	}

	private void Start()
	{
	}

	public void MFHANLJIDOD()
	{
		LobbyMain.get_Instance().PopPanelState();
	}

	public void MJNMNKFHEIP(GameObject DEBPDDIJKDH)
	{
		if (DEBPDDIJKDH.GetComponent<UIToggle>().get_value())
		{
			int num = 1;
			if (DEBPDDIJKDH.name == "중급 체력 표식")
			{
				num = 0;
			}
			else if (DEBPDDIJKDH.name == "openNanooFanPage")
			{
				num = 0;
			}
			else if (DEBPDDIJKDH.name == "C#: UserExample Start")
			{
				num = 4;
			}
			else if (DEBPDDIJKDH.name == "{0}   {1,-30}\r\n")
			{
				num = 3;
			}
			IEJCBDIBCGF = (CLJOMPBCNOE.ACPICCBBPHF)num;
			AGALGDJBODP(IEJCBDIBCGF, EDDNAONILFC);
		}
	}

	public void OnClickBackButton()
	{
		LobbyMain.get_Instance().PopPanelState();
	}

	private void JDGOCFIDMJP()
	{
		StartCoroutine(DNDJEOEMIOG());
	}

	public void OnChangeGrade(GameObject DEBPDDIJKDH)
	{
		if (!DEBPDDIJKDH.GetComponent<UIToggle>().get_value())
		{
			CLHEEDNIDDK = DEBPDDIJKDH.GetComponent<UIToggle>();
			return;
		}
		int num = 0;
		if (DEBPDDIJKDH.name == "Grade0Button")
		{
			num = 0;
		}
		else if (DEBPDDIJKDH.name == "Grade1Button")
		{
			num = 1;
		}
		else if (DEBPDDIJKDH.name == "Grade2Button")
		{
			num = 2;
		}
		if (num == 1 && NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.DDILAEMMCAJ < 10)
		{
			MsgManager.get_Instance().ShowTip(string.Format(LocalizationManager.get_Instance().GetText("레벨{0} 이상만 가능합니다"), 10));
			CLHEEDNIDDK.set_value(true);
			DEBPDDIJKDH.GetComponent<UIToggle>().set_value(false);
		}
		else if (num == 2 && NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.DDILAEMMCAJ < 20)
		{
			MsgManager.get_Instance().ShowTip(string.Format(LocalizationManager.get_Instance().GetText("레벨{0} 이상만 가능합니다"), 20));
			CLHEEDNIDDK.set_value(true);
			DEBPDDIJKDH.GetComponent<UIToggle>().set_value(false);
		}
		else
		{
			EDDNAONILFC = (CLJOMPBCNOE.HCCCCKPABAO)num;
			AGALGDJBODP(IEJCBDIBCGF, EDDNAONILFC);
		}
	}

	private void BDFEAKMGHBO()
	{
		StartCoroutine(DNDJEOEMIOG());
	}

	public void OnChangeType(GameObject DEBPDDIJKDH)
	{
		if (DEBPDDIJKDH.GetComponent<UIToggle>().get_value())
		{
			int num = 0;
			if (DEBPDDIJKDH.name == "Type0Button")
			{
				num = 0;
			}
			else if (DEBPDDIJKDH.name == "Type1Button")
			{
				num = 1;
			}
			else if (DEBPDDIJKDH.name == "Type2Button")
			{
				num = 2;
			}
			else if (DEBPDDIJKDH.name == "Type3Button")
			{
				num = 3;
			}
			IEJCBDIBCGF = (CLJOMPBCNOE.ACPICCBBPHF)num;
			AGALGDJBODP(IEJCBDIBCGF, EDDNAONILFC);
		}
	}

	private void CMMIADLEBFJ()
	{
	}

	private void Update()
	{
	}

	private void JPBNPEJJJPI()
	{
	}

	private IEnumerator DLKECDAHPJK()
	{
		MPPGFFMIEEJ mPPGFFMIEEJ = new MPPGFFMIEEJ();
		mPPGFFMIEEJ.KNIAJMGDGAA = this;
		return mPPGFFMIEEJ;
	}

	private IEnumerator DNDJEOEMIOG()
	{
		MPPGFFMIEEJ mPPGFFMIEEJ = new MPPGFFMIEEJ();
		mPPGFFMIEEJ.KNIAJMGDGAA = this;
		return mPPGFFMIEEJ;
	}

	private void OnEnable()
	{
		Refresh();
	}
}
