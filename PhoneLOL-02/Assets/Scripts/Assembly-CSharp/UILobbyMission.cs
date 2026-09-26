using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using EveEngine;
using GameServer;
using UnityEngine;

public class UILobbyMission : MonoBehaviour
{
	private sealed class PHHHIHGHMBM : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal UILobbyMission KNIAJMGDGAA;

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

		public bool LLKGBIDKCOF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.LKJEHBBCCDH();
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				KNIAJMGDGAA.GCFBLCKNHCG();
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public bool DAJHAEIAPAO()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.ADNBMFGKAAB();
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				KNIAJMGDGAA.LINNBIGKGED();
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

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public void JGCPFKEPPOM()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object PCGKBCDEONE()
		{
			return MMEGGNJKNOH;
		}

		public void KOOOABDNJBP()
		{
			throw new NotSupportedException();
		}

		public void NAEOFIPICLC()
		{
			GOMFKPLCGNN = -1;
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

		[SpecialName]
		private object FKNAIGMNFIB()
		{
			return MMEGGNJKNOH;
		}

		public void NDKCFGFNNLO()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}
	}

	private sealed class LBFACNIHEGC
	{
		internal UIMissionInfo FGDMAAIMPDE;

		internal UILobbyMission KNIAJMGDGAA;

		internal void JFHGCPFFCFN()
		{
			KNIAJMGDGAA.OnClickMissionInfo(FGDMAAIMPDE);
		}

		internal void CJLPIFLGBPL()
		{
			KNIAJMGDGAA.OnClickMissionInfo(FGDMAAIMPDE);
		}

		internal void PNOOBBCHCMB()
		{
			KNIAJMGDGAA.OnClickMissionInfo(FGDMAAIMPDE);
		}

		internal void JGJOJDLEKNF()
		{
			KNIAJMGDGAA.BEDBGFLJECA(FGDMAAIMPDE);
		}

		internal void EKCPFEJDJCD()
		{
			KNIAJMGDGAA.MBBMEPHFLPI(FGDMAAIMPDE);
		}
	}

	public UIGrid m_missionGrid;

	public void NNMPDCHIIJE()
	{
		LobbyMain.get_Instance().PopPanelState();
	}

	private void FMNOLGPIIFB()
	{
	}

	private void GCFBLCKNHCG()
	{
		List<NHOJAMKIJEA> list = NetworkManager.get_Instance().get_m_gameNetClient().HDIPOLKCNOL()
			.FADILLLBABG();
		foreach (NHOJAMKIJEA item in list)
		{
			LBFACNIHEGC lBFACNIHEGC = new LBFACNIHEGC();
			lBFACNIHEGC.KNIAJMGDGAA = this;
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("체력 물약"));
			gameObject.transform.parent = m_missionGrid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			lBFACNIHEGC.FGDMAAIMPDE = gameObject.GetComponent<UIMissionInfo>();
			lBFACNIHEGC.FGDMAAIMPDE.DADCIKGPDNN(item);
			UIEventTrigger component = gameObject.GetComponent<UIEventTrigger>();
			component.onClick.Add(new EventDelegate(lBFACNIHEGC.JFHGCPFFCFN));
		}
		m_missionGrid.LEBHAMKOPHA();
	}

	[DebuggerHidden]
	private IEnumerator DMMFOEIDAKC()
	{
		PHHHIHGHMBM pHHHIHGHMBM = new PHHHIHGHMBM();
		pHHHIHGHMBM.KNIAJMGDGAA = this;
		return pHHHIHGHMBM;
	}

	private void NGKACFJIJKP(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.InvalidProtocolVersion:
		{
			ushort bEKJMGOMIEO = HMOAHNANKNE.AJPFAAFLHEB();
			NHOJAMKIJEA nHOJAMKIJEA = NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().HDIPOLKCNOL()
				.JKDODFDDCKO(bEKJMGOMIEO);
			HMOAHNANKNE.ILFEGIPCAHH(nHOJAMKIJEA);
			uint num = HMOAHNANKNE.BMKOKHGAHEC();
			uint fJECKCCPAKE = HMOAHNANKNE.BMKOKHGAHEC();
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
				.HPHAGINBOKB(fJECKCCPAKE);
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(gLEPPIMMELK);
			bool flag = NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
				.NBIHGOFBDAG(nHOJAMKIJEA.GJHALGJGGPD.NLPMOHEJMJL());
			StringBuilder stringBuilder = new StringBuilder();
			if (flag)
			{
				stringBuilder.Append(LocalizationManager.get_Instance().GetText("{0}"));
				stringBuilder.Append("skill1");
			}
			stringBuilder.Append(LocalizationManager.get_Instance().GetText("igaworks:purchase >> Filtered list is empty"));
			stringBuilder.Append("FXMakerOption.m_SimulateArcCurve is null !!!!");
			if (nHOJAMKIJEA.GJHALGJGGPD.ODHJCJINDIF() != 0)
			{
			}
			if (nHOJAMKIJEA.GJHALGJGGPD.FCALADPIPCE() != 0)
			{
				stringBuilder.AppendFormat(LocalizationManager.LGDEHELDENG().GetText("CCCCFF"), nHOJAMKIJEA.GJHALGJGGPD.GABMKADDBMB());
				stringBuilder.Append("상급 마나 문양");
			}
			if (nHOJAMKIJEA.GJHALGJGGPD.NLPMOHEJMJL() != 0)
			{
				stringBuilder.AppendFormat(LocalizationManager.get_Instance().GetText("CreateSkill0Missile"), nHOJAMKIJEA.GJHALGJGGPD.NLPMOHEJMJL());
				stringBuilder.Append("중급 성장 마나 문양");
			}
			MsgManager.get_Instance().ShowMessageBox(stringBuilder.ToString(), true);
			if (nHOJAMKIJEA.GJHALGJGGPD.INGLCFJBNOB() > 0)
			{
				bool CMGFFEJDPAL = true;
				NEFBHKKAMJF oGBMNJBOPHK = NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().ACDEBBEGIIP()
					.OKHNCNJKAAD(nHOJAMKIJEA.GJHALGJGGPD.KAFKLNOCONH(), ref CMGFFEJDPAL);
				HMOAHNANKNE.CAHACMKBJMI(oGBMNJBOPHK);
			}
			UIRoot.IGMDNDABNKD("지금 변경 가능");
			break;
		}
		}
	}

	private void ALMCKIHGCDO(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			ushort bEKJMGOMIEO = HMOAHNANKNE.AJPFAAFLHEB();
			NHOJAMKIJEA nHOJAMKIJEA = NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().HDIPOLKCNOL()
				.PGPFIFIDAHO(bEKJMGOMIEO);
			HMOAHNANKNE.ILFEGIPCAHH(nHOJAMKIJEA);
			uint num = HMOAHNANKNE.BMKOKHGAHEC();
			uint fJECKCCPAKE = HMOAHNANKNE.BMKOKHGAHEC();
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.HPHAGINBOKB(fJECKCCPAKE);
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(gLEPPIMMELK);
			bool flag = NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.OALABBMKLLM(nHOJAMKIJEA.GJHALGJGGPD.NLPMOHEJMJL());
			StringBuilder stringBuilder = new StringBuilder();
			if (flag)
			{
				stringBuilder.Append(LocalizationManager.LGDEHELDENG().GetText("[/u]"));
				stringBuilder.Append("レベルごとに5秒ごとに体力回復");
			}
			stringBuilder.Append(LocalizationManager.LGDEHELDENG().GetText("silverbold_hit"));
			stringBuilder.Append("skill1_missile");
			if (nHOJAMKIJEA.GJHALGJGGPD.OJKGFIAFPCF() != 0)
			{
			}
			if (nHOJAMKIJEA.GJHALGJGGPD.FCALADPIPCE() > 1)
			{
				stringBuilder.AppendFormat(LocalizationManager.LGDEHELDENG().GetText("정면 근처에 대상이 없습니다"), nHOJAMKIJEA.GJHALGJGGPD.GABMKADDBMB());
				stringBuilder.Append("정상적이지 않은 아이디입니다.");
			}
			if (nHOJAMKIJEA.GJHALGJGGPD.NLPMOHEJMJL() != 0)
			{
				stringBuilder.AppendFormat(LocalizationManager.LGDEHELDENG().GetText("hit2"), nHOJAMKIJEA.GJHALGJGGPD.NLPMOHEJMJL());
				stringBuilder.Append("StartMenu");
			}
			MsgManager.get_Instance().ShowMessageBox(stringBuilder.ToString());
			if (nHOJAMKIJEA.GJHALGJGGPD.KAFKLNOCONH() > 1)
			{
				bool CMGFFEJDPAL = true;
				NEFBHKKAMJF oGBMNJBOPHK = NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().ACDEBBEGIIP()
					.OKHNCNJKAAD(nHOJAMKIJEA.GJHALGJGGPD.KAFKLNOCONH(), ref CMGFFEJDPAL);
				HMOAHNANKNE.ILFEGIPCAHH(oGBMNJBOPHK);
			}
			UIRoot.Broadcast("talon_skill2");
			break;
		}
		}
	}

	private void OnDisable()
	{
		for (int i = 0; i < m_missionGrid.transform.childCount; i++)
		{
			UnityEngine.Object.DestroyObject(m_missionGrid.transform.GetChild(i).gameObject);
		}
	}

	private void FOGNMJLPHAI()
	{
	}

	private void Start()
	{
	}

	private IEnumerator JIBEEDELAPJ()
	{
		PHHHIHGHMBM pHHHIHGHMBM = new PHHHIHGHMBM();
		pHHHIHGHMBM.KNIAJMGDGAA = this;
		return pHHHIHGHMBM;
	}

	public void OnClickMissionInfo(UIMissionInfo KIMBHHCEPKN)
	{
		NetworkManager.get_Instance().get_m_gameNetClient().JCEADKCKEFA(new IKMBGMILCDO(GJALKLCEMPJ), KIMBHHCEPKN.IMMABEBJFPE.GJHALGJGGPD.HFKJLHJPJFC());
	}

	public void MBBMEPHFLPI(UIMissionInfo KIMBHHCEPKN)
	{
		NetworkManager.APAPJEIBEDE().get_m_gameNetClient().JCEADKCKEFA(new IKMBGMILCDO(ALMCKIHGCDO, false, false), KIMBHHCEPKN.IMMABEBJFPE.GJHALGJGGPD.HFKJLHJPJFC());
	}

	public void DPAHAENFDLH()
	{
		LobbyMain.get_Instance().PopPanelState();
	}

	private void LFAIPBJMGPO()
	{
	}

	private void DMPIIJNBDID()
	{
	}

	public void OnClickBackButton()
	{
		LobbyMain.get_Instance().PopPanelState();
	}

	private void Update()
	{
	}

	private void CFEIPPFANKJ()
	{
		List<NHOJAMKIJEA> list = NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().HDIPOLKCNOL()
			.HPGAHPPBAAI();
		foreach (NHOJAMKIJEA item in list)
		{
			LBFACNIHEGC lBFACNIHEGC = new LBFACNIHEGC();
			lBFACNIHEGC.KNIAJMGDGAA = this;
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("Hero5"));
			gameObject.transform.parent = m_missionGrid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			lBFACNIHEGC.FGDMAAIMPDE = gameObject.GetComponent<UIMissionInfo>();
			lBFACNIHEGC.FGDMAAIMPDE.SetInfo(item);
			UIEventTrigger component = gameObject.GetComponent<UIEventTrigger>();
			component.onClick.Add(new EventDelegate(lBFACNIHEGC.EKCPFEJDJCD));
		}
		m_missionGrid.Reposition();
	}

	private void OnEnable()
	{
		List<NHOJAMKIJEA> list = NetworkManager.get_Instance().get_m_gameNetClient().HDIPOLKCNOL()
			.HPGAHPPBAAI();
		foreach (NHOJAMKIJEA item in list)
		{
			LBFACNIHEGC lBFACNIHEGC = new LBFACNIHEGC();
			lBFACNIHEGC.KNIAJMGDGAA = this;
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("UI/Lobby/MissionInfo"));
			gameObject.transform.parent = m_missionGrid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			lBFACNIHEGC.FGDMAAIMPDE = gameObject.GetComponent<UIMissionInfo>();
			lBFACNIHEGC.FGDMAAIMPDE.SetInfo(item);
			UIEventTrigger component = gameObject.GetComponent<UIEventTrigger>();
			component.onClick.Add(new EventDelegate(lBFACNIHEGC.CJLPIFLGBPL));
		}
		m_missionGrid.Reposition();
	}

	public void BNOKLCABBMG()
	{
		LobbyMain.get_Instance().PopPanelState();
	}

	private void MOCMKJMCDIL(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			ushort bEKJMGOMIEO = HMOAHNANKNE.AJPFAAFLHEB();
			NHOJAMKIJEA nHOJAMKIJEA = NetworkManager.get_Instance().get_m_gameNetClient().HDIPOLKCNOL()
				.KNMADPAJOJP(bEKJMGOMIEO);
			HMOAHNANKNE.CAHACMKBJMI(nHOJAMKIJEA);
			uint num = HMOAHNANKNE.BMKOKHGAHEC();
			uint fJECKCCPAKE = HMOAHNANKNE.BMKOKHGAHEC();
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
				.HPHAGINBOKB(fJECKCCPAKE);
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
				.ODEGMJIKIIC(gLEPPIMMELK);
			bool flag = NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
				.NBIHGOFBDAG(nHOJAMKIJEA.GJHALGJGGPD.NLPMOHEJMJL());
			StringBuilder stringBuilder = new StringBuilder();
			if (flag)
			{
				stringBuilder.Append(LocalizationManager.LGDEHELDENG().GetText("우리가 가는 루트에 트롤 마을이 있다는 것을 발견하고 우린 트롤 마을을 피해서 좀 돌아서 갔어..\n근데 그게 트롤 마을로 오게되는 결과가 되다니..\n한심하네.."));
				stringBuilder.Append("attack3");
			}
			stringBuilder.Append(LocalizationManager.get_Instance().GetText("skill2_0"));
			stringBuilder.Append("{0}{1}");
			if (nHOJAMKIJEA.GJHALGJGGPD.OJKGFIAFPCF() != 0)
			{
			}
			if (nHOJAMKIJEA.GJHALGJGGPD.FCALADPIPCE() != 0)
			{
				stringBuilder.AppendFormat(LocalizationManager.LGDEHELDENG().GetText("refundBulk"), nHOJAMKIJEA.GJHALGJGGPD.GABMKADDBMB());
				stringBuilder.Append("Particle/{0}/attack3");
			}
			if (nHOJAMKIJEA.GJHALGJGGPD.NLPMOHEJMJL() > 1)
			{
				stringBuilder.AppendFormat(LocalizationManager.get_Instance().GetText("productName"), nHOJAMKIJEA.GJHALGJGGPD.NLPMOHEJMJL());
				stringBuilder.Append("Skill0PassiveRpc");
			}
			MsgManager.HEDJPPFKABG().ShowMessageBox(stringBuilder.ToString());
			if (nHOJAMKIJEA.GJHALGJGGPD.INGLCFJBNOB() > 1)
			{
				bool CMGFFEJDPAL = false;
				NEFBHKKAMJF oGBMNJBOPHK = NetworkManager.APAPJEIBEDE().get_m_gameNetClient().ACDEBBEGIIP()
					.IIKDLMFMFBF(nHOJAMKIJEA.GJHALGJGGPD.KAFKLNOCONH(), ref CMGFFEJDPAL);
				HMOAHNANKNE.CAHACMKBJMI(oGBMNJBOPHK);
			}
			UIRoot.CHLLIEHMINE("\" : ");
			break;
		}
		}
	}

	private void Refresh()
	{
		StartCoroutine(DMMFOEIDAKC());
	}

	private void ADNBMFGKAAB()
	{
		for (int i = 0; i < m_missionGrid.transform.childCount; i++)
		{
			UnityEngine.Object.DestroyObject(m_missionGrid.transform.GetChild(i).gameObject);
		}
	}

	private void GJALKLCEMPJ(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			ushort bEKJMGOMIEO = HMOAHNANKNE.AJPFAAFLHEB();
			NHOJAMKIJEA nHOJAMKIJEA = NetworkManager.get_Instance().get_m_gameNetClient().HDIPOLKCNOL()
				.KNMADPAJOJP(bEKJMGOMIEO);
			HMOAHNANKNE.CAHACMKBJMI(nHOJAMKIJEA);
			uint num = HMOAHNANKNE.BMKOKHGAHEC();
			uint fJECKCCPAKE = HMOAHNANKNE.BMKOKHGAHEC();
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.HPHAGINBOKB(fJECKCCPAKE);
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(gLEPPIMMELK);
			bool flag = NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.NBIHGOFBDAG(nHOJAMKIJEA.GJHALGJGGPD.NLPMOHEJMJL());
			StringBuilder stringBuilder = new StringBuilder();
			if (flag)
			{
				stringBuilder.Append(LocalizationManager.get_Instance().GetText("★ 레벨업하셨습니다 ★"));
				stringBuilder.Append("\n\n");
			}
			stringBuilder.Append(LocalizationManager.get_Instance().GetText("보상을 획득하셨습니다."));
			stringBuilder.Append("\n\n");
			if (nHOJAMKIJEA.GJHALGJGGPD.MLIIOGCCNPC() != 0)
			{
			}
			if (nHOJAMKIJEA.GJHALGJGGPD.FCALADPIPCE() != 0)
			{
				stringBuilder.AppendFormat(LocalizationManager.get_Instance().GetText("{0}코인"), nHOJAMKIJEA.GJHALGJGGPD.FCALADPIPCE());
				stringBuilder.Append("\n");
			}
			if (nHOJAMKIJEA.GJHALGJGGPD.NLPMOHEJMJL() != 0)
			{
				stringBuilder.AppendFormat(LocalizationManager.get_Instance().GetText("{0}경험치"), nHOJAMKIJEA.GJHALGJGGPD.NLPMOHEJMJL());
				stringBuilder.Append("\n");
			}
			MsgManager.get_Instance().ShowMessageBox(stringBuilder.ToString());
			if (nHOJAMKIJEA.GJHALGJGGPD.INGLCFJBNOB() > 0)
			{
				bool CMGFFEJDPAL = false;
				NEFBHKKAMJF oGBMNJBOPHK = NetworkManager.get_Instance().get_m_gameNetClient().ACDEBBEGIIP()
					.PGNKPIFFMJE(nHOJAMKIJEA.GJHALGJGGPD.INGLCFJBNOB(), ref CMGFFEJDPAL);
				HMOAHNANKNE.CAHACMKBJMI(oGBMNJBOPHK);
			}
			UIRoot.Broadcast("Refresh");
			break;
		}
		}
	}

	private void DHMMCEBEAHA()
	{
	}

	private void LKJEHBBCCDH()
	{
		for (int i = 1; i < m_missionGrid.transform.childCount; i++)
		{
			UnityEngine.Object.DestroyObject(m_missionGrid.transform.GetChild(i).gameObject);
		}
	}

	private IEnumerator CDACCGPJICM()
	{
		PHHHIHGHMBM pHHHIHGHMBM = new PHHHIHGHMBM();
		pHHHIHGHMBM.KNIAJMGDGAA = this;
		return pHHHIHGHMBM;
	}

	private void FMDCADHECGH()
	{
	}

	public void BEDBGFLJECA(UIMissionInfo KIMBHHCEPKN)
	{
		NetworkManager.APAPJEIBEDE().get_m_gameNetClient().JCEADKCKEFA(new IKMBGMILCDO(GJALKLCEMPJ), KIMBHHCEPKN.IMMABEBJFPE.GJHALGJGGPD.HFKJLHJPJFC());
	}

	private void MIAPCHPDEND()
	{
		StartCoroutine(JIBEEDELAPJ());
	}

	private void LINNBIGKGED()
	{
		List<NHOJAMKIJEA> list = NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().HDIPOLKCNOL()
			.FADILLLBABG();
		foreach (NHOJAMKIJEA item in list)
		{
			LBFACNIHEGC lBFACNIHEGC = new LBFACNIHEGC();
			lBFACNIHEGC.KNIAJMGDGAA = this;
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("skill0_2"));
			gameObject.transform.parent = m_missionGrid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			lBFACNIHEGC.FGDMAAIMPDE = gameObject.GetComponent<UIMissionInfo>();
			lBFACNIHEGC.FGDMAAIMPDE.SetInfo(item);
			UIEventTrigger component = gameObject.GetComponent<UIEventTrigger>();
			component.onClick.Add(new EventDelegate(lBFACNIHEGC.PNOOBBCHCMB));
		}
		m_missionGrid.LEBHAMKOPHA();
	}
}
