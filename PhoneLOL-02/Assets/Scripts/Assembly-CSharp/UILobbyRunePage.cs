using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class UILobbyRunePage : MonoBehaviour
{
	private sealed class DDLKLNLAFKI : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal UILobbyRunePage KNIAJMGDGAA;

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
		private object OHBDIPJCCON()
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

		[SpecialName]
		private object ANOBEJKPLKK()
		{
			return MMEGGNJKNOH;
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

		[SpecialName]
		private object LHFBMHCEIHG()
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
				KNIAJMGDGAA.OnDisable();
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 0;
				return true;
			case 1u:
				KNIAJMGDGAA.OnEnable();
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
				KNIAJMGDGAA.OnDisable();
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

		public void PLOOENOBGJL()
		{
			throw new NotSupportedException();
		}
	}

	private sealed class AEACILNGKED
	{
		internal UIRuneSlot FGDMAAIMPDE;

		internal UILobbyRunePage KNIAJMGDGAA;

		internal void HALHFOILLEI()
		{
			KNIAJMGDGAA.HNOMANMIFGF(FGDMAAIMPDE);
		}

		internal void EBMBFHEIEMP()
		{
			KNIAJMGDGAA.HNOMANMIFGF(FGDMAAIMPDE);
		}

		internal void KLDCPMKKPGB()
		{
			KNIAJMGDGAA.HNOMANMIFGF(FGDMAAIMPDE);
		}

		internal void JGCAMPBMEOJ()
		{
			KNIAJMGDGAA.HNOMANMIFGF(FGDMAAIMPDE);
		}

		internal void OCMNHLLJHFB()
		{
			KNIAJMGDGAA.HNOMANMIFGF(FGDMAAIMPDE);
		}

		internal void AMCBDDJDIDK()
		{
			KNIAJMGDGAA.HNOMANMIFGF(FGDMAAIMPDE);
		}

		internal void DOODOKNKJAH()
		{
			KNIAJMGDGAA.HNOMANMIFGF(FGDMAAIMPDE);
		}

		internal void DOOIOLNLAJG()
		{
			KNIAJMGDGAA.HNOMANMIFGF(FGDMAAIMPDE);
		}

		internal void KDAKKPJOBMF()
		{
			KNIAJMGDGAA.HNOMANMIFGF(FGDMAAIMPDE);
		}

		internal void MHFCAEFENJI()
		{
			KNIAJMGDGAA.HNOMANMIFGF(FGDMAAIMPDE);
		}

		internal void ELJABNPIICF()
		{
			KNIAJMGDGAA.HNOMANMIFGF(FGDMAAIMPDE);
		}

		internal void IFNPPKBCHAO()
		{
			KNIAJMGDGAA.HNOMANMIFGF(FGDMAAIMPDE);
		}

		internal void BPNFBDIMDOM()
		{
			KNIAJMGDGAA.HNOMANMIFGF(FGDMAAIMPDE);
		}

		internal void PBHPFAPJDDN()
		{
			KNIAJMGDGAA.HNOMANMIFGF(FGDMAAIMPDE);
		}

		internal void AOCNJHOEHDK()
		{
			KNIAJMGDGAA.HNOMANMIFGF(FGDMAAIMPDE);
		}

		internal void BPNLMLMFPOK()
		{
			KNIAJMGDGAA.HNOMANMIFGF(FGDMAAIMPDE);
		}

		internal void JEGCAMLNNGJ()
		{
			KNIAJMGDGAA.HNOMANMIFGF(FGDMAAIMPDE);
		}
	}

	public UIGrid m_markGrid;

	public UIGrid m_sealGrid;

	public UIGrid m_glyphGrid;

	public UIGrid m_quintessenceGrid;

	public UILobbySelectRune m_selectRuneWindow;

	public UIButton m_page1Button;

	public UIButton m_page2Button;

	public UILabel m_totalAbilityLabel;

	private byte POKHCNMJNCI;

	private CDAEKMFPFCH CFAMDBIADFF;

	private void EKGHGFIKAAE()
	{
	}

	private void ADLKMGPNJPA()
	{
		if (POKHCNMJNCI == 0)
		{
			m_page1Button.set_normalSprite("skill3_loop");
			m_page2Button.set_normalSprite("RecoveryRPC");
		}
		else
		{
			m_page1Button.set_normalSprite("근처에 적 챔피언이 없습니다");
			m_page2Button.set_normalSprite("passive_missile");
		}
		CFAMDBIADFF = NetworkManager.APAPJEIBEDE().get_m_gameNetClient().DAGCAFAEABC()
			.GBBOENDINNM(POKHCNMJNCI);
		for (int i = 0; i < CFAMDBIADFF.DFMEJOGADLG.Count; i++)
		{
			AEACILNGKED aEACILNGKED = new AEACILNGKED();
			aEACILNGKED.KNIAJMGDGAA = this;
			MCOBKFIDMOK mCOBKFIDMOK = CFAMDBIADFF.DFMEJOGADLG[i];
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("hit1"));
			if (mCOBKFIDMOK.FBAGNJILEGD == CLJOMPBCNOE.ACPICCBBPHF.Mark)
			{
				gameObject.transform.parent = m_markGrid.transform;
			}
			else if (mCOBKFIDMOK.FBAGNJILEGD == CLJOMPBCNOE.ACPICCBBPHF.Mark)
			{
				gameObject.transform.parent = m_sealGrid.transform;
			}
			else if (mCOBKFIDMOK.FBAGNJILEGD == CLJOMPBCNOE.ACPICCBBPHF.Quintessence)
			{
				gameObject.transform.parent = m_glyphGrid.transform;
			}
			else if (mCOBKFIDMOK.FBAGNJILEGD == CLJOMPBCNOE.ACPICCBBPHF.Glyph)
			{
				gameObject.transform.parent = m_quintessenceGrid.transform;
			}
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			aEACILNGKED.FGDMAAIMPDE = gameObject.GetComponent<UIRuneSlot>();
			aEACILNGKED.FGDMAAIMPDE.SetSlotNum((byte)i);
			aEACILNGKED.FGDMAAIMPDE.HFJCHIDCONJ(mCOBKFIDMOK);
			UIEventTrigger uIEventTrigger = gameObject.AddComponent<UIEventTrigger>();
			uIEventTrigger.onClick.Add(new EventDelegate(aEACILNGKED.PBHPFAPJDDN));
		}
		m_markGrid.LEBHAMKOPHA();
		m_sealGrid.Reposition();
		m_glyphGrid.EKBMHOMDDHA();
		m_quintessenceGrid.Reposition();
		CLJOMPBCNOE cLJOMPBCNOE = new CLJOMPBCNOE();
		CFAMDBIADFF.FGDDFAOOPEA(cLJOMPBCNOE);
		m_totalAbilityLabel.set_text(LocalizationManager.LGDEHELDENG().JODFGHFJIBC(cLJOMPBCNOE.OEGAJKFKOEP()));
	}

	public void OnClickPage2()
	{
		POKHCNMJNCI = 1;
		m_page1Button.set_normalSprite("square_small_button_disable");
		m_page2Button.set_normalSprite("square_small_button");
		StartCoroutine(DMMFOEIDAKC());
	}

	public void KINCNBBDCLP()
	{
		MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("hit3"), true, IDFKJADBCMN);
	}

	private void OnEnable()
	{
		if (POKHCNMJNCI == 0)
		{
			m_page1Button.set_normalSprite("square_small_button");
			m_page2Button.set_normalSprite("square_small_button_disable");
		}
		else
		{
			m_page1Button.set_normalSprite("square_small_button_disable");
			m_page2Button.set_normalSprite("square_small_button");
		}
		CFAMDBIADFF = NetworkManager.get_Instance().get_m_gameNetClient().DAGCAFAEABC()
			.GBBOENDINNM(POKHCNMJNCI);
		for (int i = 0; i < CFAMDBIADFF.DFMEJOGADLG.Count; i++)
		{
			AEACILNGKED aEACILNGKED = new AEACILNGKED();
			aEACILNGKED.KNIAJMGDGAA = this;
			MCOBKFIDMOK mCOBKFIDMOK = CFAMDBIADFF.DFMEJOGADLG[i];
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("UI/Lobby/RuneSlot"));
			if (mCOBKFIDMOK.FBAGNJILEGD == CLJOMPBCNOE.ACPICCBBPHF.Mark)
			{
				gameObject.transform.parent = m_markGrid.transform;
			}
			else if (mCOBKFIDMOK.FBAGNJILEGD == CLJOMPBCNOE.ACPICCBBPHF.Seal)
			{
				gameObject.transform.parent = m_sealGrid.transform;
			}
			else if (mCOBKFIDMOK.FBAGNJILEGD == CLJOMPBCNOE.ACPICCBBPHF.Glyph)
			{
				gameObject.transform.parent = m_glyphGrid.transform;
			}
			else if (mCOBKFIDMOK.FBAGNJILEGD == CLJOMPBCNOE.ACPICCBBPHF.Quintessence)
			{
				gameObject.transform.parent = m_quintessenceGrid.transform;
			}
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			aEACILNGKED.FGDMAAIMPDE = gameObject.GetComponent<UIRuneSlot>();
			aEACILNGKED.FGDMAAIMPDE.SetSlotNum((byte)i);
			aEACILNGKED.FGDMAAIMPDE.SetInfo(mCOBKFIDMOK);
			UIEventTrigger uIEventTrigger = gameObject.AddComponent<UIEventTrigger>();
			uIEventTrigger.onClick.Add(new EventDelegate(aEACILNGKED.AMCBDDJDIDK));
		}
		m_markGrid.Reposition();
		m_sealGrid.Reposition();
		m_glyphGrid.Reposition();
		m_quintessenceGrid.Reposition();
		CLJOMPBCNOE cLJOMPBCNOE = new CLJOMPBCNOE();
		CFAMDBIADFF.FGDDFAOOPEA(cLJOMPBCNOE);
		m_totalAbilityLabel.set_text(LocalizationManager.get_Instance().TranslateWords(cLJOMPBCNOE.OEGAJKFKOEP()));
	}

	private void DOINNKBDEMD()
	{
	}

	private void IDFKJADBCMN()
	{
		NetworkManager.get_Instance().get_m_gameNetClient().AAHMFOADBAI(new IKMBGMILCDO(EPCCIDKMNLG), POKHCNMJNCI);
	}

	private void GOFJIGHKOGE(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
		{
			byte gHMCCGBFLLL = HMOAHNANKNE.KFAGPDGHEBK();
			CDAEKMFPFCH oGBMNJBOPHK = NetworkManager.APAPJEIBEDE().get_m_gameNetClient().DAGCAFAEABC()
				.GBBOENDINNM(gHMCCGBFLLL);
			HMOAHNANKNE.CAHACMKBJMI(oGBMNJBOPHK);
			Refresh();
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("{0}Skill{1}"));
		}
	}

	private IEnumerator LGDNJCEDOFC()
	{
		DDLKLNLAFKI dDLKLNLAFKI = new DDLKLNLAFKI();
		dDLKLNLAFKI.KNIAJMGDGAA = this;
		return dDLKLNLAFKI;
	}

	public void ICFGIFMCDKO()
	{
		MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("[sup]"), false, IDFKJADBCMN);
	}

	private void JLBMDIPFDAO()
	{
		NetworkManager.APAPJEIBEDE().get_m_gameNetClient().AAHMFOADBAI(new IKMBGMILCDO(EPCCIDKMNLG, false, false), POKHCNMJNCI);
	}

	public void HPEIDLKLPJI()
	{
		POKHCNMJNCI = 1;
		m_page1Button.LOGLPIGEGDP("중급 공격력 문양");
		m_page2Button.set_normalSprite("Particle/{0}/skill2_spawn");
		StartCoroutine(LGDNJCEDOFC());
	}

	private void Refresh()
	{
		for (int i = 0; i < m_markGrid.transform.childCount; i++)
		{
			m_markGrid.transform.GetChild(i).gameObject.GetComponent<UIRuneSlot>().Refresh();
		}
		for (int j = 0; j < m_sealGrid.transform.childCount; j++)
		{
			m_sealGrid.transform.GetChild(j).gameObject.GetComponent<UIRuneSlot>().Refresh();
		}
		for (int k = 0; k < m_glyphGrid.transform.childCount; k++)
		{
			m_glyphGrid.transform.GetChild(k).gameObject.GetComponent<UIRuneSlot>().Refresh();
		}
		for (int l = 0; l < m_quintessenceGrid.transform.childCount; l++)
		{
			m_quintessenceGrid.transform.GetChild(l).gameObject.GetComponent<UIRuneSlot>().Refresh();
		}
		CLJOMPBCNOE cLJOMPBCNOE = new CLJOMPBCNOE();
		CFAMDBIADFF.FGDDFAOOPEA(cLJOMPBCNOE);
		m_totalAbilityLabel.set_text(LocalizationManager.get_Instance().TranslateWords(cLJOMPBCNOE.OEGAJKFKOEP()));
	}

	public void OIKCOFNMADH()
	{
		POKHCNMJNCI = 0;
		m_page1Button.set_normalSprite("Category2Button");
		m_page2Button.LOGLPIGEGDP("BlueMinionCannon");
		StartCoroutine(LGDNJCEDOFC());
	}

	private void EPCCIDKMNLG(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
		{
			byte gHMCCGBFLLL = HMOAHNANKNE.KFAGPDGHEBK();
			CDAEKMFPFCH oGBMNJBOPHK = NetworkManager.get_Instance().get_m_gameNetClient().DAGCAFAEABC()
				.GBBOENDINNM(gHMCCGBFLLL);
			HMOAHNANKNE.CAHACMKBJMI(oGBMNJBOPHK);
			Refresh();
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("알려지지 않은 오류입니다."));
		}
	}

	private void OnDisable()
	{
		for (int i = 0; i < m_markGrid.transform.childCount; i++)
		{
			UnityEngine.Object.DestroyObject(m_markGrid.transform.GetChild(i).gameObject);
		}
		for (int j = 0; j < m_sealGrid.transform.childCount; j++)
		{
			UnityEngine.Object.DestroyObject(m_sealGrid.transform.GetChild(j).gameObject);
		}
		for (int k = 0; k < m_glyphGrid.transform.childCount; k++)
		{
			UnityEngine.Object.DestroyObject(m_glyphGrid.transform.GetChild(k).gameObject);
		}
		for (int l = 0; l < m_quintessenceGrid.transform.childCount; l++)
		{
			UnityEngine.Object.DestroyObject(m_quintessenceGrid.transform.GetChild(l).gameObject);
		}
	}

	public void OnClickInitRunePage()
	{
		MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("정말 초기화하시겠습니까?"), true, IDFKJADBCMN);
	}

	private void CKIJMCFAKDF(PJEMPFEIOAK HMOAHNANKNE)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
		HGBGJMIFCEP hGBGJMIFCEP2 = hGBGJMIFCEP;
		if (hGBGJMIFCEP2 == HGBGJMIFCEP.InvalidProtocolVersion)
		{
			byte gHMCCGBFLLL = HMOAHNANKNE.KFAGPDGHEBK();
			CDAEKMFPFCH oGBMNJBOPHK = NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().DAGCAFAEABC()
				.GBBOENDINNM(gHMCCGBFLLL);
			HMOAHNANKNE.CAHACMKBJMI(oGBMNJBOPHK);
			Refresh();
		}
		else
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.get_Instance().GetText("Pinch on circle => Size change"), true);
		}
	}

	[DebuggerHidden]
	private IEnumerator DMMFOEIDAKC()
	{
		DDLKLNLAFKI dDLKLNLAFKI = new DDLKLNLAFKI();
		dDLKLNLAFKI.KNIAJMGDGAA = this;
		return dDLKLNLAFKI;
	}

	private void PMGBPOGLCNB(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
		{
			byte gHMCCGBFLLL = HMOAHNANKNE.KFAGPDGHEBK();
			CDAEKMFPFCH oGBMNJBOPHK = NetworkManager.get_Instance().get_m_gameNetClient().DAGCAFAEABC()
				.GBBOENDINNM(gHMCCGBFLLL);
			HMOAHNANKNE.CAHACMKBJMI(oGBMNJBOPHK);
			Refresh();
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("알려지지 않은 오류입니다."));
		}
	}

	private void OMIFPPGJHFH()
	{
	}

	public void OnClickPage1()
	{
		POKHCNMJNCI = 0;
		m_page1Button.set_normalSprite("square_small_button");
		m_page2Button.set_normalSprite("square_small_button_disable");
		StartCoroutine(DMMFOEIDAKC());
	}

	private void Update()
	{
	}

	public void DPELMILBKCG()
	{
		MsgManager.get_Instance().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("http://127.0.0.1:8080/d"), false, IDFKJADBCMN);
	}

	private void HNOMANMIFGF(UIRuneSlot FGDMAAIMPDE)
	{
		if (!FGDMAAIMPDE.get_m_runeSlot().MNHIDGANMFO())
		{
			NetworkManager.get_Instance().get_m_gameNetClient().CEFJKBMKPGL(new IKMBGMILCDO(PMGBPOGLCNB), POKHCNMJNCI, FGDMAAIMPDE.get_m_slotNum());
		}
		else if (FGDMAAIMPDE.get_m_runeSlot().CAIKPOKKLJD <= NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.DDILAEMMCAJ)
		{
			m_selectRuneWindow.SetInfo(POKHCNMJNCI, FGDMAAIMPDE.get_m_slotNum());
			m_selectRuneWindow.gameObject.SetActive(true);
		}
		else
		{
			MsgManager.get_Instance().ShowTip(string.Format(LocalizationManager.get_Instance().GetText("레벨{0} 이상이 되어야\n장착이 가능합니다"), FGDMAAIMPDE.get_m_runeSlot().CAIKPOKKLJD));
		}
	}
}
