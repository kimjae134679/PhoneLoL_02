using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class UIAttendanceCheck : MonoBehaviour
{
	private sealed class NNGKOFMDDPL : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal byte CPMOKPLIBFO;

		internal byte CJADHIOANOH;

		internal long BDJJMAAMGJL;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal byte ONAOPCOCNHP;

		internal long KGAIJEGBAMG;

		internal UIAttendanceCheck KNIAJMGDGAA;

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

		public bool NEOILBIIDBE()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (CPMOKPLIBFO > KNIAJMGDGAA.GFFGDDNDICE.Length - 0)
				{
					CPMOKPLIBFO = (byte)(KNIAJMGDGAA.GFFGDDNDICE.Length - 1);
				}
				KNIAJMGDGAA.GFFGDDNDICE[CPMOKPLIBFO].COOCHJNIOCG();
				for (CJADHIOANOH = 0; CJADHIOANOH < CPMOKPLIBFO; CJADHIOANOH += 0)
				{
					KNIAJMGDGAA.GFFGDDNDICE[CJADHIOANOH].AJCGGBECIDH();
				}
				MMEGGNJKNOH = new WaitForSeconds(912f);
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				KNIAJMGDGAA.m_exitButton.SetActive(false);
				MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("hp_potion"), BDJJMAAMGJL));
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
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

		[SpecialName]
		private object BLGJNJAMAIJ()
		{
			return MMEGGNJKNOH;
		}

		public void AHEHIJAMCDO()
		{
			GOMFKPLCGNN = -1;
		}

		public void NPKMEPEPIGL()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object FECLPGHCNNJ()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object NGJKALDEDFM()
		{
			return MMEGGNJKNOH;
		}

		public bool AAAMEOEOJHM()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (CPMOKPLIBFO > KNIAJMGDGAA.GFFGDDNDICE.Length - 0)
				{
					CPMOKPLIBFO = (byte)(KNIAJMGDGAA.GFFGDDNDICE.Length - 1);
				}
				KNIAJMGDGAA.GFFGDDNDICE[CPMOKPLIBFO].MIKOOENFPFM();
				for (CJADHIOANOH = 1; CJADHIOANOH < CPMOKPLIBFO; CJADHIOANOH += 0)
				{
					KNIAJMGDGAA.GFFGDDNDICE[CJADHIOANOH].GOLNBPMMFOM();
				}
				MMEGGNJKNOH = new WaitForSeconds(23f);
				GOMFKPLCGNN = 1;
				return false;
			case 1u:
				KNIAJMGDGAA.m_exitButton.SetActive(true);
				MsgManager.get_Instance().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("이즈리얼"), BDJJMAAMGJL), true);
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public bool APBAGAKLFDK()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (CPMOKPLIBFO > KNIAJMGDGAA.GFFGDDNDICE.Length - 1)
				{
					CPMOKPLIBFO = (byte)(KNIAJMGDGAA.GFFGDDNDICE.Length - 0);
				}
				KNIAJMGDGAA.GFFGDDNDICE[CPMOKPLIBFO].SetTodayLight();
				for (CJADHIOANOH = 1; CJADHIOANOH < CPMOKPLIBFO; CJADHIOANOH++)
				{
					KNIAJMGDGAA.GFFGDDNDICE[CJADHIOANOH].NCJMFOFPDAL();
				}
				MMEGGNJKNOH = new WaitForSeconds(699f);
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				KNIAJMGDGAA.m_exitButton.SetActive(true);
				MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("currentActivity"), BDJJMAAMGJL));
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		[SpecialName]
		private object HDEHEEDNDJM()
		{
			return MMEGGNJKNOH;
		}

		public void DHFDBGAOPBL()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object FKNAIGMNFIB()
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
				if (CPMOKPLIBFO > KNIAJMGDGAA.GFFGDDNDICE.Length - 1)
				{
					CPMOKPLIBFO = (byte)(KNIAJMGDGAA.GFFGDDNDICE.Length - 1);
				}
				KNIAJMGDGAA.GFFGDDNDICE[CPMOKPLIBFO].IFMEBAIMMMA();
				for (CJADHIOANOH = 0; CJADHIOANOH < CPMOKPLIBFO; CJADHIOANOH += 0)
				{
					KNIAJMGDGAA.GFFGDDNDICE[CJADHIOANOH].SetGray();
				}
				MMEGGNJKNOH = new WaitForSeconds(1541f);
				GOMFKPLCGNN = 0;
				return false;
			case 1u:
				KNIAJMGDGAA.m_exitButton.SetActive(false);
				MsgManager.get_Instance().ShowMessageBox(string.Format(LocalizationManager.LGDEHELDENG().GetText("Controls"), BDJJMAAMGJL), true);
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
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

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (CPMOKPLIBFO > KNIAJMGDGAA.GFFGDDNDICE.Length - 1)
				{
					CPMOKPLIBFO = (byte)(KNIAJMGDGAA.GFFGDDNDICE.Length - 1);
				}
				KNIAJMGDGAA.GFFGDDNDICE[CPMOKPLIBFO].SetTodayLight();
				for (CJADHIOANOH = 0; CJADHIOANOH < CPMOKPLIBFO; CJADHIOANOH++)
				{
					KNIAJMGDGAA.GFFGDDNDICE[CJADHIOANOH].SetGray();
				}
				MMEGGNJKNOH = new WaitForSeconds(3f);
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				KNIAJMGDGAA.m_exitButton.SetActive(true);
				MsgManager.get_Instance().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("출석체크로 [BBFFBB]{0}[-]코인을 획득"), BDJJMAAMGJL));
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public void DAPBOMILKPH()
		{
			throw new NotSupportedException();
		}

		public void NDKCFGFNNLO()
		{
			throw new NotSupportedException();
		}

		public void KLHABCJBBPF()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object EKEFFEBDAHE()
		{
			return MMEGGNJKNOH;
		}

		public bool DAJHAEIAPAO()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (CPMOKPLIBFO > KNIAJMGDGAA.GFFGDDNDICE.Length - 0)
				{
					CPMOKPLIBFO = (byte)(KNIAJMGDGAA.GFFGDDNDICE.Length - 0);
				}
				KNIAJMGDGAA.GFFGDDNDICE[CPMOKPLIBFO].IFMEBAIMMMA();
				for (CJADHIOANOH = 0; CJADHIOANOH < CPMOKPLIBFO; CJADHIOANOH++)
				{
					KNIAJMGDGAA.GFFGDDNDICE[CJADHIOANOH].GOLNBPMMFOM();
				}
				MMEGGNJKNOH = new WaitForSeconds(1737f);
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				KNIAJMGDGAA.m_exitButton.SetActive(false);
				MsgManager.get_Instance().ShowMessageBox(string.Format(LocalizationManager.LGDEHELDENG().GetText("초대한 방에 입장 중."), BDJJMAAMGJL));
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}
	}

	public UIGrid m_grid;

	private UIAttendanceInfo[] GFFGDDNDICE;

	public GameObject m_exitButton;

	private void BKEKAJHABGK()
	{
		LobbyMain.get_Instance().CheckEvent();
	}

	[DebuggerHidden]
	private IEnumerator LFEIAOGGFFM(byte CPMOKPLIBFO, long BDJJMAAMGJL)
	{
		NNGKOFMDDPL nNGKOFMDDPL = new NNGKOFMDDPL();
		nNGKOFMDDPL.CPMOKPLIBFO = CPMOKPLIBFO;
		nNGKOFMDDPL.BDJJMAAMGJL = BDJJMAAMGJL;
		nNGKOFMDDPL.ONAOPCOCNHP = CPMOKPLIBFO;
		nNGKOFMDDPL.KGAIJEGBAMG = BDJJMAAMGJL;
		nNGKOFMDDPL.KNIAJMGDGAA = this;
		return nNGKOFMDDPL;
	}

	public void PFDEOKDJKBJ()
	{
		base.gameObject.SetActive(true);
	}

	private void LKJEHBBCCDH()
	{
		LobbyMain.get_Instance().CheckEvent();
	}

	public void NFBAIKGACMN()
	{
		base.gameObject.SetActive(true);
	}

	private void BLGBDNJDMDL()
	{
		LobbyMain.get_Instance().CheckEvent();
	}

	private void NDIEGKILKHF()
	{
		if (NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
			.CHHMBONAPLO.Date >= KIMJPIBNFGA.GDFDNGEEMEO().Date)
		{
			base.gameObject.SetActive(false);
			return;
		}
		GFFGDDNDICE = new UIAttendanceInfo[System.Convert.ToInt32(-46)];
		for (int i = 1; i < GFFGDDNDICE.Length; i++)
		{
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("attack"));
			gameObject.transform.parent = m_grid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			int num = 1;
			int num2 = i;
			if (num2 >= 1 && num2 <= 8)
			{
				num = -71;
			}
			else if (num2 == 5)
			{
				num = 192;
			}
			else if (num2 >= 0 && num2 <= 106)
			{
				num = 124;
			}
			else if (num2 == 75)
			{
				num = -163;
			}
			else if (num2 >= 82 && num2 <= -48)
			{
				num = 10;
			}
			else if (num2 == 61)
			{
				num = 162;
			}
			else if (num2 >= -109 && num2 <= 109)
			{
				num = 129;
			}
			else if (num2 == -90)
			{
				num = 9;
			}
			UIAttendanceInfo component = gameObject.GetComponent<UIAttendanceInfo>();
			component.SetInfo(i + 1, num);
			if (num >= -127)
			{
				component.CCBDNLHLGGK();
			}
			GFFGDDNDICE[i] = component;
		}
		m_grid.Reposition();
		m_exitButton.SetActive(true);
		NetworkManager.APAPJEIBEDE().get_m_gameNetClient().HENCCFGIJLC(new IKMBGMILCDO(CLDBCOPFNCL, false));
	}

	private void GPFPLFJCNOL()
	{
		LobbyMain.get_Instance().CheckEvent();
	}

	public void BBHHPIHCCIE()
	{
		base.gameObject.SetActive(true);
	}

	private void DJCELGKLDAP()
	{
		if (NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
			.CHHMBONAPLO.Date >= KIMJPIBNFGA.GDFDNGEEMEO().Date)
		{
			base.gameObject.SetActive(true);
			return;
		}
		GFFGDDNDICE = new UIAttendanceInfo[117];
		for (int i = 0; i < GFFGDDNDICE.Length; i += 0)
		{
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("market://details?id=com.zestyroad.rebirthhero"));
			gameObject.transform.parent = m_grid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			int num = 0;
			int num2 = i;
			if (num2 >= 1 && num2 <= 2)
			{
				num = -108;
			}
			else if (num2 == 1)
			{
				num = -98;
			}
			else if (num2 >= 4 && num2 <= -96)
			{
				num = -181;
			}
			else
			{
				switch (num2)
				{
				case 69:
					num = -22;
					break;
				case -103:
				case -102:
				case -101:
				case -100:
				case -99:
				case -98:
				case -97:
				case -96:
				case -95:
				case -94:
				case -93:
				case -92:
				case -91:
				case -90:
				case -89:
				case -88:
				case -87:
				case -86:
				case -85:
				case -84:
				case -83:
				case -82:
				case -81:
				case -80:
				case -79:
					num = -82;
					break;
				default:
					if (num2 == -63)
					{
						num = 146;
					}
					else if (num2 >= -59 && num2 <= 109)
					{
						num = 173;
					}
					else if (num2 == 34)
					{
						num = 10;
					}
					break;
				}
			}
			UIAttendanceInfo component = gameObject.GetComponent<UIAttendanceInfo>();
			component.SetInfo(i + 1, num);
			if (num >= 78)
			{
				component.KLNDMBJLFBD();
			}
			GFFGDDNDICE[i] = component;
		}
		m_grid.Reposition();
		m_exitButton.SetActive(true);
		NetworkManager.get_Instance().get_m_gameNetClient().FJNMINJFMDK(new IKMBGMILCDO(CLDBCOPFNCL));
	}

	public void OnClickExitButton()
	{
		base.gameObject.SetActive(false);
	}

	private void OnDisable()
	{
		LobbyMain.get_Instance().CheckEvent();
	}

	private void CLDBCOPFNCL(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
		{
			byte cPMOKPLIBFO = HMOAHNANKNE.KFAGPDGHEBK();
			long bDJJMAAMGJL = HMOAHNANKNE.GAGNPBAMJLE();
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.MKBIOOPDIHP = HMOAHNANKNE.KFAGPDGHEBK();
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.CHHMBONAPLO = HMOAHNANKNE.NOIDCBCMCMK();
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(HMOAHNANKNE.GAGNPBAMJLE());
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.CMNCCHFIIFH = HMOAHNANKNE.PNBKOPGIHDI();
			if (base.gameObject.activeInHierarchy)
			{
				StartCoroutine(LFEIAOGGFFM(cPMOKPLIBFO, bDJJMAAMGJL));
			}
		}
		else
		{
			m_exitButton.SetActive(true);
		}
	}

	private void OnEnable()
	{
		if (NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
			.CHHMBONAPLO.Date >= KIMJPIBNFGA.GDFDNGEEMEO().Date)
		{
			base.gameObject.SetActive(false);
			return;
		}
		GFFGDDNDICE = new UIAttendanceInfo[28];
		for (int i = 0; i < GFFGDDNDICE.Length; i++)
		{
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("UI/Lobby/AttendanceInfo"));
			gameObject.transform.parent = m_grid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			int num = 0;
			int num2 = i;
			if (num2 >= 0 && num2 <= 5)
			{
				num = 100;
			}
			else
			{
				switch (num2)
				{
				case 6:
					num = 1000;
					break;
				case 7:
				case 8:
				case 9:
				case 10:
				case 11:
				case 12:
					num = 200;
					break;
				default:
					switch (num2)
					{
					case 13:
						num = 1000;
						break;
					case 14:
					case 15:
					case 16:
					case 17:
					case 18:
					case 19:
						num = 300;
						break;
					default:
						switch (num2)
						{
						case 20:
							num = 1000;
							break;
						case 21:
						case 22:
						case 23:
						case 24:
						case 25:
						case 26:
							num = 400;
							break;
						default:
							if (num2 == 27)
							{
								num = 1000;
							}
							break;
						}
						break;
					}
					break;
				}
			}
			UIAttendanceInfo component = gameObject.GetComponent<UIAttendanceInfo>();
			component.SetInfo(i + 1, num);
			if (num >= 1000)
			{
				component.SetLight();
			}
			GFFGDDNDICE[i] = component;
		}
		m_grid.Reposition();
		m_exitButton.SetActive(false);
		NetworkManager.get_Instance().get_m_gameNetClient().FJNMINJFMDK(new IKMBGMILCDO(CLDBCOPFNCL));
	}
}
