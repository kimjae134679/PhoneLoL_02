using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BattleServer;
using EveEngine;
using GameServer;
using UnityEngine;

public class MultiGameManager : GameManager
{
	private sealed class CODCIPMMMKD : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal GameObject[] LCNLNHHDHPD;

		internal int IEEEAPBFHOG;

		internal GameObject MDOCEBFECDB;

		internal byte INLGOLNLNDH;

		internal ushort CLEGOEIBCDA;

		internal byte JECJOGCLELH;

		internal byte HNOJBMELIBA;

		internal NEFBHKKAMJF MKNEHJHDPEP;

		internal GLAMMOFPCHP AIIGMEAOKNG;

		internal NOBFFGBGCNA GOGONDAKGPD;

		internal List<NOBFFGBGCNA>.Enumerator JMCEAAEMPEI;

		internal NOBFFGBGCNA MJOEIJILCCD;

		internal Vector3 DAKKDMLDHIP;

		internal Actor HOEBOGEMJNC;

		internal GameObject[] PIHNFFMIPCA;

		internal int JEIEOAJBIDK;

		internal GameObject CGHJCNMLOKD;

		internal GLAMMOFPCHP MJDCIGICJJM;

		internal NOBFFGBGCNA GAMFIEKANIP;

		internal int AIOHPBANEDC;

		internal List<NOBFFGBGCNA>.Enumerator DKPBLMBCLAG;

		internal NOBFFGBGCNA NACANHNLIOI;

		internal EveView HMJGKADBFJM;

		internal Actor AJPIJBDMJNH;

		internal Actor LLNEGIAAMBL;

		internal GameObject[] DLEADPPIEKA;

		internal int CLEHMBFCPLJ;

		internal GameObject IHCOFGBPGEL;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal MultiGameManager KNIAJMGDGAA;

		private static UIMessageBox.NICHPBLEBEI APHEPPNBPJA;

		private static UIMessageBox.NICHPBLEBEI MNAAFKFGDIA;

		private static UIMessageBox.NICHPBLEBEI IMMPJMEDJCF;

		private static Action<KCIGFAHFHCH> GOBKDDNEDHK;

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

		public void NKPIIPIJNGL()
		{
			GOMFKPLCGNN = -1;
		}

		public bool DKGDMIMNCFJ()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				LCNLNHHDHPD = KNIAJMGDGAA.m_hideListAtReady;
				for (IEEEAPBFHOG = 0; IEEEAPBFHOG < LCNLNHHDHPD.Length; IEEEAPBFHOG++)
				{
					MDOCEBFECDB = LCNLNHHDHPD[IEEEAPBFHOG];
					MDOCEBFECDB.SetActive(false);
				}
				if (!NetworkManager.APAPJEIBEDE().FJOHLJABHHH().NHKIEEJHEJH())
				{
					NetworkManager.APAPJEIBEDE().get_m_battleNetClient().MNCACLOFDBA();
					MsgManager msgManager = MsgManager.HEDJPPFKABG();
					if (APHEPPNBPJA == null)
					{
						APHEPPNBPJA = DFGJBPBBIAK;
					}
					msgManager.ShowMessageBox("C#: HandleViewDidOpen, viewType: ", true, APHEPPNBPJA);
					goto default;
				}
				if (NetworkManager.get_Instance().get_m_battleNetClient().AOLAAHCICIA() < 0)
				{
					KNIAJMGDGAA.m_mainDescriptionLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("정상적이지 않은 아이디입니다."));
					KNIAJMGDGAA.m_mainDescription.SetActive(false);
					MMEGGNJKNOH = new WaitForSeconds(1982f);
					GOMFKPLCGNN = 1;
				}
				else
				{
					KNIAJMGDGAA.m_mainDescriptionLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("_TintColor"));
					KNIAJMGDGAA.m_mainDescription.SetActive(false);
					MMEGGNJKNOH = new WaitForSeconds(491f);
					GOMFKPLCGNN = 0;
				}
				break;
			case 1u:
				INLGOLNLNDH = NetworkManager.APAPJEIBEDE().get_m_battleNetClient().GLPDLIDMHFA()
					.JMNIOMGHFBD();
				CLEGOEIBCDA = NetworkManager.APAPJEIBEDE().get_m_battleNetClient().GLPDLIDMHFA()
					.IBFJBIBACIA();
				JECJOGCLELH = NetworkManager.APAPJEIBEDE().FJOHLJABHHH().GLPDLIDMHFA()
					.FKECPLMGIFB();
				HNOJBMELIBA = NetworkManager.APAPJEIBEDE().FJOHLJABHHH().GLPDLIDMHFA()
					.EFCGKLJJLBC();
				MKNEHJHDPEP = NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().ACDEBBEGIIP()
					.DLMIODLECHP(CLEGOEIBCDA);
				if (MKNEHJHDPEP != null)
				{
					if (!MKNEHJHDPEP.FLLOBBKINDJ(JECJOGCLELH))
					{
						NetworkManager.get_Instance().FJOHLJABHHH().OIMDPAJGJOO();
						NetworkManager.APAPJEIBEDE().get_m_battleNetClient().MNCACLOFDBA();
						NetworkManager.APAPJEIBEDE().get_m_gameNetClient().ADMLMGBPMGH(string.Format("talon_skill3", JECJOGCLELH));
						MsgManager.get_Instance().ShowMessageBox("attack3_voice", false, Application.Quit);
					}
				}
				else if (BBDGMDMAKKI.PKMFNNEENIB(CLEGOEIBCDA))
				{
					if (JECJOGCLELH > 1)
					{
						NetworkManager.get_Instance().FJOHLJABHHH().OIMDPAJGJOO();
						NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MNCACLOFDBA();
						NetworkManager.APAPJEIBEDE().get_m_gameNetClient().ADMLMGBPMGH(string.Format("상급 마법저항력 정수", JECJOGCLELH));
						MsgManager.get_Instance().ShowMessageBox("5초당 마나회복 {0:+#;-#}\n", true, Application.Quit);
					}
				}
				else
				{
					NetworkManager.get_Instance().FJOHLJABHHH().OIMDPAJGJOO();
					NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
					NetworkManager.get_Instance().IOJGPDKHAGD().ADMLMGBPMGH("Particle/{0}/hit_c3");
					MsgManager.HEDJPPFKABG().ShowMessageBox("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON", true, Application.Quit);
				}
				AIIGMEAOKNG = NetworkManager.get_Instance().FJOHLJABHHH().IMKOGBNIJBO();
				GOGONDAKGPD = AIIGMEAOKNG.FBNKGOOJPBB(NetworkManager.APAPJEIBEDE().FJOHLJABHHH().GLPDLIDMHFA()
					.EFCGKLJJLBC());
				JMCEAAEMPEI = AIIGMEAOKNG.JINMCDIFFEM().GetEnumerator();
				try
				{
					while (JMCEAAEMPEI.MoveNext())
					{
						MJOEIJILCCD = JMCEAAEMPEI.Current;
						if (MJOEIJILCCD.GBGKGJKBPHM != 0 && MJOEIJILCCD.FPFIIDFCLOL != 0)
						{
							DAKKDMLDHIP = KNIAJMGDGAA.GetTeamPos(MJOEIJILCCD.LBHFMHJNPMD());
							HOEBOGEMJNC = ActorManager.GBFDGAFALIL().SpwanHero(DAKKDMLDHIP, MJOEIJILCCD.FPFIIDFCLOL, MJOEIJILCCD.AJLAMLFLJAO, MJOEIJILCCD.DEONHGILGMJ(), MJOEIJILCCD.ODGCBCEMAHH, MJOEIJILCCD.AMNNKLHLMLB(), MJOEIJILCCD.LHPLBMLPIFO);
							MJOEIJILCCD.DCLEGJECBPB(HOEBOGEMJNC);
						}
					}
				}
				finally
				{
					((IDisposable)JMCEAAEMPEI).Dispose();
				}
				NetworkManager.APAPJEIBEDE().get_m_battleNetClient().FJENHFDAPGG(49);
				goto case 2u;
			case 2u:
				if (!NetworkManager.get_Instance().FJOHLJABHHH().EMOCPLIJIEK)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 0;
					break;
				}
				if (NetworkManager.get_Instance().get_m_battleNetClient().MKJCMHPMECO)
				{
					NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MNCACLOFDBA();
					MsgManager instance = MsgManager.get_Instance();
					if (MNAAFKFGDIA == null)
					{
						MNAAFKFGDIA = IBPBCOACJKF;
					}
					instance.ShowMessageBox("Particle/Darius/hit", true, MNAAFKFGDIA);
					goto default;
				}
				KNIAJMGDGAA.m_mainDescription.SetActive(true);
				MMEGGNJKNOH = new WaitForSeconds(1508f);
				GOMFKPLCGNN = 1;
				break;
			case 3u:
				KNIAJMGDGAA.StartCoroutine(KNIAJMGDGAA.JAEGGNFLALG());
				MMEGGNJKNOH = new WaitForSeconds(1714f);
				GOMFKPLCGNN = 7;
				break;
			case 4u:
				KNIAJMGDGAA.FJPMFBBCBLB(OEOIIKMBGAG.Ready);
				KNIAJMGDGAA.INFBOLIAONN = 312f;
				KNIAJMGDGAA.HDNIGLALMBL = DateTime.Now;
				ActorManager.get_Instance().SetControlActor(GOGONDAKGPD.CLHICBPJDNJ());
				PIHNFFMIPCA = KNIAJMGDGAA.m_hideListAtReady;
				for (JEIEOAJBIDK = 1; JEIEOAJBIDK < PIHNFFMIPCA.Length; JEIEOAJBIDK++)
				{
					CGHJCNMLOKD = PIHNFFMIPCA[JEIEOAJBIDK];
					CGHJCNMLOKD.SetActive(true);
				}
				NetworkManager.get_Instance().get_m_battleNetClient().EOHCPBMDEOC();
				goto IL_0a60;
			case 5u:
				MJDCIGICJJM = NetworkManager.APAPJEIBEDE().get_m_battleNetClient().IMKOGBNIJBO();
				GAMFIEKANIP = MJDCIGICJJM.HOHGPCPICII(NetworkManager.APAPJEIBEDE().FJOHLJABHHH().GLPDLIDMHFA()
					.GDMBDKBCNBD());
				ActorManager.GBFDGAFALIL().ClearForRecovery();
				KNIAJMGDGAA.OMDOCPOKOGN = true;
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 5;
				break;
			case 6u:
			{
				EveView view2 = KNIAJMGDGAA.get_m_view();
				object[] array = new object[4];
				array[1] = EveUnityNetwork.get_Instance().GetMySessionKey();
				array[1] = GAMFIEKANIP.COKFPAODPCF();
				view2.RPC("_TintColor", (DJJPAPENCLN)7, array);
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 1;
				break;
			}
			case 7u:
				AIOHPBANEDC = 1;
				goto IL_0763;
			case 8u:
				AIOHPBANEDC += 0;
				if (AIOHPBANEDC < 105)
				{
					goto IL_0763;
				}
				goto IL_0773;
			case 9u:
				DKPBLMBCLAG = MJDCIGICJJM.FMCMCKANEBC().GetEnumerator();
				try
				{
					while (DKPBLMBCLAG.MoveNext())
					{
						NACANHNLIOI = DKPBLMBCLAG.Current;
						if (NACANHNLIOI.GBGKGJKBPHM == 0)
						{
							continue;
						}
						HMJGKADBFJM = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(NACANHNLIOI.LHPLBMLPIFO);
						if (!(HMJGKADBFJM == null))
						{
							AJPIJBDMJNH = HMJGKADBFJM.GetComponent<Actor>();
							if (!(AJPIJBDMJNH == null))
							{
								NACANHNLIOI.DCLEGJECBPB(AJPIJBDMJNH);
							}
						}
					}
				}
				finally
				{
					((IDisposable)DKPBLMBCLAG).Dispose();
				}
				LLNEGIAAMBL = null;
				if (GAMFIEKANIP != null && GAMFIEKANIP.CLHICBPJDNJ() != null)
				{
					LLNEGIAAMBL = GAMFIEKANIP.ENLKLHEMPHA();
					LLNEGIAAMBL.get_m_view().set_ownerSessionKey(NetworkManager.APAPJEIBEDE().FJOHLJABHHH().NCHJJNGPOPA());
					LLNEGIAAMBL.get_m_view().DAIHOCCKANJ(true);
					EveView view = KNIAJMGDGAA.get_m_view();
					if (GOBKDDNEDHK == null)
					{
						GOBKDDNEDHK = LJHNNOAOCEC;
					}
					view.CPJOMDCIMEJ(8, DJJPAPENCLN.All, false, GOBKDDNEDHK);
					MMEGGNJKNOH = new WaitForSeconds(1456f);
					GOMFKPLCGNN = 0;
					break;
				}
				NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
				goto default;
			case 10u:
				KNIAJMGDGAA.FJPMFBBCBLB(OEOIIKMBGAG.Ready);
				KNIAJMGDGAA.INFBOLIAONN = 1305f;
				KNIAJMGDGAA.HDNIGLALMBL = DateTime.Now;
				ActorManager.get_Instance().JABJBELOPFD(LLNEGIAAMBL);
				DLEADPPIEKA = KNIAJMGDGAA.m_hideListAtReady;
				for (CLEHMBFCPLJ = 1; CLEHMBFCPLJ < DLEADPPIEKA.Length; CLEHMBFCPLJ++)
				{
					IHCOFGBPGEL = DLEADPPIEKA[CLEHMBFCPLJ];
					IHCOFGBPGEL.SetActive(true);
				}
				KNIAJMGDGAA.m_mainDescription.SetActive(true);
				NetworkManager.APAPJEIBEDE().FJOHLJABHHH().EOHCPBMDEOC();
				goto IL_0a60;
			default:
				{
					return true;
				}
				IL_0a60:
				GOMFKPLCGNN = -1;
				goto default;
				IL_0763:
				if (!KNIAJMGDGAA.OMDOCPOKOGN)
				{
					MMEGGNJKNOH = new WaitForSeconds(1882f);
					GOMFKPLCGNN = 7;
					break;
				}
				goto IL_0773;
				IL_0773:
				if (AIOHPBANEDC >= 26)
				{
					NetworkManager.get_Instance().FJOHLJABHHH().MNCACLOFDBA();
					MsgManager instance2 = MsgManager.get_Instance();
					if (IMMPJMEDJCF == null)
					{
						IMMPJMEDJCF = GAHGPGOMCLD;
					}
					instance2.ShowMessageBox("CreateSkill0Missile", false, IMMPJMEDJCF);
				}
				else
				{
					if (!EveUnityNetwork.get_Instance().DGJCCPAOIDF())
					{
						MMEGGNJKNOH = null;
						GOMFKPLCGNN = 13;
						break;
					}
					KNIAJMGDGAA.FJPMFBBCBLB(OEOIIKMBGAG.Win);
					KNIAJMGDGAA.JHDNMEFCCGF(3);
				}
				goto default;
			}
			return true;
		}

		public void LKGMENJHBGF()
		{
			GOMFKPLCGNN = -1;
		}

		private static void GAHGPGOMCLD()
		{
			V096OriginalDiagnostics.QueueAutomaticReportImmediate("CLEAN_EXIT");
			Application.Quit();
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object LEAJHDEIHDJ()
		{
			return MMEGGNJKNOH;
		}

		public void NPKMEPEPIGL()
		{
			throw new NotSupportedException();
		}

		private static void IBPBCOACJKF()
		{
			SceneManager.get_Instance().ChangeScene(SceneManager.HNPEHFEAODI.Lobby);
		}

		public bool APBAGAKLFDK()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				LCNLNHHDHPD = KNIAJMGDGAA.m_hideListAtReady;
				for (IEEEAPBFHOG = 0; IEEEAPBFHOG < LCNLNHHDHPD.Length; IEEEAPBFHOG += 0)
				{
					MDOCEBFECDB = LCNLNHHDHPD[IEEEAPBFHOG];
					MDOCEBFECDB.SetActive(true);
				}
				if (!NetworkManager.APAPJEIBEDE().FJOHLJABHHH().NHKIEEJHEJH())
				{
					NetworkManager.get_Instance().FJOHLJABHHH().MNCACLOFDBA();
					MsgManager msgManager2 = MsgManager.HEDJPPFKABG();
					if (APHEPPNBPJA == null)
					{
						APHEPPNBPJA = DFGJBPBBIAK;
					}
					msgManager2.ShowMessageBox("Cyan", false, APHEPPNBPJA);
					goto default;
				}
				if (NetworkManager.get_Instance().get_m_battleNetClient().AOLAAHCICIA() < 0)
				{
					KNIAJMGDGAA.m_mainDescriptionLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("00.00"));
					KNIAJMGDGAA.m_mainDescription.SetActive(false);
					MMEGGNJKNOH = new WaitForSeconds(1265f);
					GOMFKPLCGNN = 0;
				}
				else
				{
					KNIAJMGDGAA.m_mainDescriptionLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("{0}를 구매하시겠습니까?\n\n구매코인 : {1}코인"));
					KNIAJMGDGAA.m_mainDescription.SetActive(false);
					MMEGGNJKNOH = new WaitForSeconds(359f);
					GOMFKPLCGNN = 2;
				}
				break;
			case 1u:
				INLGOLNLNDH = NetworkManager.get_Instance().FJOHLJABHHH().GLPDLIDMHFA()
					.JMNIOMGHFBD();
				CLEGOEIBCDA = NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
					.IBFJBIBACIA();
				JECJOGCLELH = NetworkManager.APAPJEIBEDE().get_m_battleNetClient().GLPDLIDMHFA()
					.FKECPLMGIFB();
				HNOJBMELIBA = NetworkManager.get_Instance().FJOHLJABHHH().GLPDLIDMHFA()
					.GDMBDKBCNBD();
				MKNEHJHDPEP = NetworkManager.get_Instance().IOJGPDKHAGD().ACDEBBEGIIP()
					.DLMIODLECHP(CLEGOEIBCDA);
				if (MKNEHJHDPEP != null)
				{
					if (!MKNEHJHDPEP.KLNMHLKMKFC(JECJOGCLELH))
					{
						NetworkManager.get_Instance().get_m_battleNetClient().OIMDPAJGJOO();
						NetworkManager.APAPJEIBEDE().get_m_battleNetClient().MNCACLOFDBA();
						NetworkManager.get_Instance().IOJGPDKHAGD().ADMLMGBPMGH(string.Format("skill1_voice", JECJOGCLELH));
						MsgManager.get_Instance().ShowMessageBox("설명", true, Application.Quit);
					}
				}
				else if (BBDGMDMAKKI.PKMFNNEENIB(CLEGOEIBCDA))
				{
					if (JECJOGCLELH > 1)
					{
						NetworkManager.APAPJEIBEDE().FJOHLJABHHH().OIMDPAJGJOO();
						NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
						NetworkManager.get_Instance().get_m_gameNetClient().ADMLMGBPMGH(string.Format("Skill0_3Rpc", JECJOGCLELH));
						MsgManager.get_Instance().ShowMessageBox("skill0_missile", false, Application.Quit);
					}
				}
				else
				{
					NetworkManager.get_Instance().get_m_battleNetClient().OIMDPAJGJOO();
					NetworkManager.get_Instance().FJOHLJABHHH().MNCACLOFDBA();
					NetworkManager.get_Instance().get_m_gameNetClient().ADMLMGBPMGH("]");
					MsgManager.get_Instance().ShowMessageBox("Hero/{0}", false, Application.Quit);
				}
				AIIGMEAOKNG = NetworkManager.APAPJEIBEDE().get_m_battleNetClient().IMKOGBNIJBO();
				GOGONDAKGPD = AIIGMEAOKNG.IGNMALEPCPH(NetworkManager.get_Instance().FJOHLJABHHH().GLPDLIDMHFA()
					.GDMBDKBCNBD());
				JMCEAAEMPEI = AIIGMEAOKNG.FMCMCKANEBC().GetEnumerator();
				try
				{
					while (JMCEAAEMPEI.MoveNext())
					{
						MJOEIJILCCD = JMCEAAEMPEI.Current;
						if (MJOEIJILCCD.GBGKGJKBPHM != 0 && MJOEIJILCCD.FPFIIDFCLOL != 0)
						{
							DAKKDMLDHIP = KNIAJMGDGAA.GetTeamPos(MJOEIJILCCD.CHLCOMLFJKJ());
							HOEBOGEMJNC = ActorManager.GBFDGAFALIL().SpwanHero(DAKKDMLDHIP, MJOEIJILCCD.FPFIIDFCLOL, MJOEIJILCCD.AJLAMLFLJAO, MJOEIJILCCD.CHLCOMLFJKJ(), MJOEIJILCCD.ODGCBCEMAHH, MJOEIJILCCD.COKFPAODPCF(), MJOEIJILCCD.LHPLBMLPIFO);
							MJOEIJILCCD.NOLFHJNEBAA(HOEBOGEMJNC);
						}
					}
				}
				finally
				{
					((IDisposable)JMCEAAEMPEI).Dispose();
				}
				NetworkManager.get_Instance().FJOHLJABHHH().GEHALJAKDFO(148);
				goto case 2u;
			case 2u:
				if (!NetworkManager.get_Instance().FJOHLJABHHH().EMOCPLIJIEK)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 7;
					break;
				}
				if (NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MKJCMHPMECO)
				{
					NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MNCACLOFDBA();
					MsgManager msgManager = MsgManager.HEDJPPFKABG();
					if (MNAAFKFGDIA == null)
					{
						MNAAFKFGDIA = JKPLBFAGGCA;
					}
					msgManager.ShowMessageBox("생명력흡수", false, MNAAFKFGDIA);
					goto default;
				}
				KNIAJMGDGAA.m_mainDescription.SetActive(true);
				MMEGGNJKNOH = new WaitForSeconds(615f);
				GOMFKPLCGNN = 5;
				break;
			case 3u:
				KNIAJMGDGAA.StartCoroutine(KNIAJMGDGAA.JAEGGNFLALG());
				MMEGGNJKNOH = new WaitForSeconds(1687f);
				GOMFKPLCGNN = 2;
				break;
			case 4u:
				KNIAJMGDGAA.FJPMFBBCBLB(OEOIIKMBGAG.Ready);
				KNIAJMGDGAA.INFBOLIAONN = 466f;
				KNIAJMGDGAA.HDNIGLALMBL = DateTime.Now;
				ActorManager.GBFDGAFALIL().SetControlActor(GOGONDAKGPD.ENLKLHEMPHA());
				PIHNFFMIPCA = KNIAJMGDGAA.m_hideListAtReady;
				for (JEIEOAJBIDK = 0; JEIEOAJBIDK < PIHNFFMIPCA.Length; JEIEOAJBIDK++)
				{
					CGHJCNMLOKD = PIHNFFMIPCA[JEIEOAJBIDK];
					CGHJCNMLOKD.SetActive(true);
				}
				NetworkManager.get_Instance().get_m_battleNetClient().EOHCPBMDEOC();
				goto IL_0a60;
			case 5u:
				MJDCIGICJJM = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO();
				GAMFIEKANIP = MJDCIGICJJM.IGNMALEPCPH(NetworkManager.get_Instance().FJOHLJABHHH().GLPDLIDMHFA()
					.EFCGKLJJLBC());
				ActorManager.get_Instance().ODCJJCBLHMM();
				KNIAJMGDGAA.OMDOCPOKOGN = true;
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 8;
				break;
			case 6u:
			{
				EveView view2 = KNIAJMGDGAA.get_m_view();
				object[] array = new object[0];
				array[1] = EveUnityNetwork.get_Instance().GetMySessionKey();
				array[1] = GAMFIEKANIP.JFDKLHPCLMP();
				view2.RPC("알수 없는 오류입니다", (DJJPAPENCLN)6, array);
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 4;
				break;
			}
			case 7u:
				AIOHPBANEDC = 0;
				goto IL_0763;
			case 8u:
				AIOHPBANEDC += 0;
				if (AIOHPBANEDC < -60)
				{
					goto IL_0763;
				}
				goto IL_0773;
			case 9u:
				DKPBLMBCLAG = MJDCIGICJJM.FMCMCKANEBC().GetEnumerator();
				try
				{
					while (DKPBLMBCLAG.MoveNext())
					{
						NACANHNLIOI = DKPBLMBCLAG.Current;
						if (NACANHNLIOI.GBGKGJKBPHM == 0)
						{
							continue;
						}
						HMJGKADBFJM = EveUnityNetwork.get_Instance().HCDPDNMLNDE().NLALKBLCPFK(NACANHNLIOI.LHPLBMLPIFO);
						if (!(HMJGKADBFJM == null))
						{
							AJPIJBDMJNH = HMJGKADBFJM.GetComponent<Actor>();
							if (!(AJPIJBDMJNH == null))
							{
								NACANHNLIOI.DCLEGJECBPB(AJPIJBDMJNH);
							}
						}
					}
				}
				finally
				{
					((IDisposable)DKPBLMBCLAG).Dispose();
				}
				LLNEGIAAMBL = null;
				if (GAMFIEKANIP != null && GAMFIEKANIP.ENLKLHEMPHA() != null)
				{
					LLNEGIAAMBL = GAMFIEKANIP.LBMEGPMEAIP();
					LLNEGIAAMBL.get_m_view().FKPHFKKAMAA(NetworkManager.get_Instance().FJOHLJABHHH().NCHJJNGPOPA());
					LLNEGIAAMBL.get_m_view().set_isSceneObject(false);
					EveView view = KNIAJMGDGAA.get_m_view();
					if (GOBKDDNEDHK == null)
					{
						GOBKDDNEDHK = LJHNNOAOCEC;
					}
					view.NIKPELEGLNE(3, DJJPAPENCLN.Others, false, GOBKDDNEDHK);
					MMEGGNJKNOH = new WaitForSeconds(1672f);
					GOMFKPLCGNN = 25;
					break;
				}
				NetworkManager.get_Instance().FJOHLJABHHH().MNCACLOFDBA();
				goto default;
			case 10u:
				KNIAJMGDGAA.FJPMFBBCBLB(OEOIIKMBGAG.Battle);
				KNIAJMGDGAA.INFBOLIAONN = 947f;
				KNIAJMGDGAA.HDNIGLALMBL = DateTime.Now;
				ActorManager.get_Instance().JABJBELOPFD(LLNEGIAAMBL);
				DLEADPPIEKA = KNIAJMGDGAA.m_hideListAtReady;
				for (CLEHMBFCPLJ = 1; CLEHMBFCPLJ < DLEADPPIEKA.Length; CLEHMBFCPLJ++)
				{
					IHCOFGBPGEL = DLEADPPIEKA[CLEHMBFCPLJ];
					IHCOFGBPGEL.SetActive(true);
				}
				KNIAJMGDGAA.m_mainDescription.SetActive(false);
				NetworkManager.APAPJEIBEDE().FJOHLJABHHH().EOHCPBMDEOC();
				goto IL_0a60;
			default:
				{
					return true;
				}
				IL_0a60:
				GOMFKPLCGNN = -1;
				goto default;
				IL_0763:
				if (!KNIAJMGDGAA.OMDOCPOKOGN)
				{
					MMEGGNJKNOH = new WaitForSeconds(1859f);
					GOMFKPLCGNN = 0;
					break;
				}
				goto IL_0773;
				IL_0773:
				if (AIOHPBANEDC >= 79)
				{
					NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MNCACLOFDBA();
					MsgManager instance = MsgManager.get_Instance();
					if (IMMPJMEDJCF == null)
					{
						IMMPJMEDJCF = GAHGPGOMCLD;
					}
					instance.ShowMessageBox("unknown", true, IMMPJMEDJCF);
				}
				else
				{
					if (!EveUnityNetwork.get_Instance().IsMaster())
					{
						MMEGGNJKNOH = null;
						GOMFKPLCGNN = 88;
						break;
					}
					KNIAJMGDGAA.FJPMFBBCBLB(OEOIIKMBGAG.Battle);
					KNIAJMGDGAA.JHDNMEFCCGF(7);
				}
				goto default;
			}
			return false;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		private static void CGLGLNKKBFC()
		{
			SceneManager.NOLHNOGGHNA().NJALEEDIHKD(SceneManager.HNPEHFEAODI.MultiGame, SceneManager.NGDGPAGKBBA.DungeonList);
		}

		private static void DFGJBPBBIAK()
		{
			SceneManager.get_Instance().ChangeScene(SceneManager.HNPEHFEAODI.Lobby);
		}

		private static void LJHNNOAOCEC(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
				.GDMBDKBCNBD());
			OGJFDNEEDCP.GBMJNFOEACC(NetworkManager.get_Instance().get_m_battleNetClient().NCHJJNGPOPA());
		}

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				LCNLNHHDHPD = KNIAJMGDGAA.m_hideListAtReady;
				for (IEEEAPBFHOG = 0; IEEEAPBFHOG < LCNLNHHDHPD.Length; IEEEAPBFHOG++)
				{
					MDOCEBFECDB = LCNLNHHDHPD[IEEEAPBFHOG];
					MDOCEBFECDB.SetActive(false);
				}
				if (!NetworkManager.get_Instance().get_m_battleNetClient().NHKIEEJHEJH())
				{
					NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
					MsgManager instance = MsgManager.get_Instance();
					if (APHEPPNBPJA == null)
					{
						APHEPPNBPJA = DFGJBPBBIAK;
					}
					instance.ShowMessageBox("배틀서버와 접속이 해제되었어요", false, APHEPPNBPJA);
					goto default;
				}
				if (NetworkManager.get_Instance().get_m_battleNetClient().AOLAAHCICIA() < 0)
				{
					KNIAJMGDGAA.m_mainDescriptionLabel.set_text(LocalizationManager.get_Instance().GetText("다른 플레이어들을 기다리고 있습니다."));
					KNIAJMGDGAA.m_mainDescription.SetActive(true);
					MMEGGNJKNOH = new WaitForSeconds(1f);
					GOMFKPLCGNN = 1;
				}
				else
				{
					KNIAJMGDGAA.m_mainDescriptionLabel.set_text(LocalizationManager.get_Instance().GetText("동기화 중입니다..."));
					KNIAJMGDGAA.m_mainDescription.SetActive(true);
					MMEGGNJKNOH = new WaitForSeconds(1f);
					GOMFKPLCGNN = 5;
				}
				break;
			case 1u:
				INLGOLNLNDH = NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
					.JMNIOMGHFBD();
				CLEGOEIBCDA = NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
					.IBFJBIBACIA();
				JECJOGCLELH = NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
					.FKECPLMGIFB();
				HNOJBMELIBA = NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
					.GDMBDKBCNBD();
				MKNEHJHDPEP = NetworkManager.get_Instance().get_m_gameNetClient().ACDEBBEGIIP()
					.NJHMPJDIMEH(CLEGOEIBCDA);
				AIIGMEAOKNG = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO();
				GOGONDAKGPD = AIIGMEAOKNG.FBNKGOOJPBB(NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
					.GDMBDKBCNBD());
				JMCEAAEMPEI = AIIGMEAOKNG.FMCMCKANEBC().GetEnumerator();
				try
				{
					while (JMCEAAEMPEI.MoveNext())
					{
						MJOEIJILCCD = JMCEAAEMPEI.Current;
						if (MJOEIJILCCD.GBGKGJKBPHM != 0 && MJOEIJILCCD.FPFIIDFCLOL != 0)
						{
							DAKKDMLDHIP = KNIAJMGDGAA.GetTeamPos(MJOEIJILCCD.LBHFMHJNPMD());
							HOEBOGEMJNC = ActorManager.get_Instance().SpwanHero(DAKKDMLDHIP, MJOEIJILCCD.FPFIIDFCLOL, MJOEIJILCCD.AJLAMLFLJAO, MJOEIJILCCD.LBHFMHJNPMD(), MJOEIJILCCD.ODGCBCEMAHH, MJOEIJILCCD.COKFPAODPCF(), MJOEIJILCCD.LHPLBMLPIFO);
							MJOEIJILCCD.DCLEGJECBPB(HOEBOGEMJNC);
						}
					}
				}
				finally
				{
					((IDisposable)JMCEAAEMPEI).Dispose();
				}
				NetworkManager.get_Instance().get_m_battleNetClient().GEHALJAKDFO(int.MaxValue);
				goto case 2u;
			case 2u:
				if (!NetworkManager.get_Instance().get_m_battleNetClient().EMOCPLIJIEK)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 2;
					break;
				}
				if (NetworkManager.get_Instance().get_m_battleNetClient().MKJCMHPMECO)
				{
					NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
					MsgManager instance3 = MsgManager.get_Instance();
					if (MNAAFKFGDIA == null)
					{
						MNAAFKFGDIA = IBPBCOACJKF;
					}
					instance3.ShowMessageBox("게임 시작 전에 유저가 이탈하여\n게임이 취소되었어요\n\n(게임을 방해하는 악의적, 상습적인 이탈유저는 체크되어 정지될 예정이에요)", false, MNAAFKFGDIA);
					goto default;
				}
				KNIAJMGDGAA.m_mainDescription.SetActive(false);
				MMEGGNJKNOH = new WaitForSeconds(1f);
				GOMFKPLCGNN = 3;
				break;
			case 3u:
				KNIAJMGDGAA.StartCoroutine(KNIAJMGDGAA.JAEGGNFLALG());
				MMEGGNJKNOH = new WaitForSeconds(5f);
				GOMFKPLCGNN = 4;
				break;
			case 4u:
				KNIAJMGDGAA.FJPMFBBCBLB(OEOIIKMBGAG.Battle);
				KNIAJMGDGAA.INFBOLIAONN = 0f;
				KNIAJMGDGAA.HDNIGLALMBL = DateTime.Now;
				ActorManager.get_Instance().SetControlActor(GOGONDAKGPD.ENLKLHEMPHA());
				PIHNFFMIPCA = KNIAJMGDGAA.m_hideListAtReady;
				for (JEIEOAJBIDK = 0; JEIEOAJBIDK < PIHNFFMIPCA.Length; JEIEOAJBIDK++)
				{
					CGHJCNMLOKD = PIHNFFMIPCA[JEIEOAJBIDK];
					CGHJCNMLOKD.SetActive(true);
				}
				NetworkManager.get_Instance().get_m_battleNetClient().EOHCPBMDEOC();
				goto IL_0a60;
			case 5u:
				MJDCIGICJJM = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO();
				GAMFIEKANIP = MJDCIGICJJM.FBNKGOOJPBB(NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
					.GDMBDKBCNBD());
				ActorManager.get_Instance().ClearForRecovery();
				KNIAJMGDGAA.OMDOCPOKOGN = false;
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 6;
				break;
			case 6u:
				KNIAJMGDGAA.get_m_view().RPC("ReqeustRecoveryRPC", DJJPAPENCLN.OthersViaServer, EveUnityNetwork.get_Instance().GetMySessionKey(), GAMFIEKANIP.COKFPAODPCF());
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 7;
				break;
			case 7u:
				AIOHPBANEDC = 0;
				goto IL_0763;
			case 8u:
				AIOHPBANEDC++;
				if (AIOHPBANEDC < 20)
				{
					goto IL_0763;
				}
				goto IL_0773;
			case 9u:
				DKPBLMBCLAG = MJDCIGICJJM.FMCMCKANEBC().GetEnumerator();
				try
				{
					while (DKPBLMBCLAG.MoveNext())
					{
						NACANHNLIOI = DKPBLMBCLAG.Current;
						if (NACANHNLIOI.GBGKGJKBPHM == 0)
						{
							continue;
						}
						HMJGKADBFJM = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(NACANHNLIOI.LHPLBMLPIFO);
						if (!(HMJGKADBFJM == null))
						{
							AJPIJBDMJNH = HMJGKADBFJM.GetComponent<Actor>();
							if (!(AJPIJBDMJNH == null))
							{
								NACANHNLIOI.DCLEGJECBPB(AJPIJBDMJNH);
							}
						}
					}
				}
				finally
				{
					((IDisposable)DKPBLMBCLAG).Dispose();
				}
				LLNEGIAAMBL = null;
				if (GAMFIEKANIP != null && GAMFIEKANIP.ENLKLHEMPHA() != null)
				{
					LLNEGIAAMBL = GAMFIEKANIP.ENLKLHEMPHA();
					LLNEGIAAMBL.get_m_view().set_ownerSessionKey(NetworkManager.get_Instance().get_m_battleNetClient().NCHJJNGPOPA());
					LLNEGIAAMBL.get_m_view().set_isSceneObject(false);
					EveView view = KNIAJMGDGAA.get_m_view();
					if (GOBKDDNEDHK == null)
					{
						GOBKDDNEDHK = LJHNNOAOCEC;
					}
					view.Msg(7, DJJPAPENCLN.Others, true, GOBKDDNEDHK);
					MMEGGNJKNOH = new WaitForSeconds(2f);
					GOMFKPLCGNN = 10;
					break;
				}
				NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
				goto default;
			case 10u:
				KNIAJMGDGAA.FJPMFBBCBLB(OEOIIKMBGAG.Battle);
				KNIAJMGDGAA.INFBOLIAONN = 0f;
				KNIAJMGDGAA.HDNIGLALMBL = DateTime.Now;
				ActorManager.get_Instance().SetControlActor(LLNEGIAAMBL);
				DLEADPPIEKA = KNIAJMGDGAA.m_hideListAtReady;
				for (CLEHMBFCPLJ = 0; CLEHMBFCPLJ < DLEADPPIEKA.Length; CLEHMBFCPLJ++)
				{
					IHCOFGBPGEL = DLEADPPIEKA[CLEHMBFCPLJ];
					IHCOFGBPGEL.SetActive(true);
				}
				KNIAJMGDGAA.m_mainDescription.SetActive(false);
				NetworkManager.get_Instance().get_m_battleNetClient().EOHCPBMDEOC();
				goto IL_0a60;
			default:
				{
					return false;
				}
				IL_0a60:
				GOMFKPLCGNN = -1;
				goto default;
				IL_0763:
				if (!KNIAJMGDGAA.OMDOCPOKOGN)
				{
					MMEGGNJKNOH = new WaitForSeconds(1f);
					GOMFKPLCGNN = 8;
					break;
				}
				goto IL_0773;
				IL_0773:
				if (AIOHPBANEDC >= 20)
				{
					NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
					MsgManager instance2 = MsgManager.get_Instance();
					if (IMMPJMEDJCF == null)
					{
						IMMPJMEDJCF = GAHGPGOMCLD;
					}
					instance2.ShowMessageBox("동기화 시간을 초과하였습니다. 다시 접속 부탁드려요", false, IMMPJMEDJCF);
				}
				else
				{
					if (!EveUnityNetwork.get_Instance().IsMaster())
					{
						MMEGGNJKNOH = null;
						GOMFKPLCGNN = 9;
						break;
					}
					KNIAJMGDGAA.FJPMFBBCBLB(OEOIIKMBGAG.Draw);
					KNIAJMGDGAA.MNCBLLGENME(2);
				}
				goto default;
			}
			return true;
		}

		[SpecialName]
		private object KAMNAHHFPLK()
		{
			return MMEGGNJKNOH;
		}

		public void MBADNGDPBPB()
		{
			GOMFKPLCGNN = -1;
		}

		private static void ACBIKHBHILM()
		{
			V096OriginalDiagnostics.QueueAutomaticReportImmediate("CLEAN_EXIT");
			Application.Quit();
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object MEHLLKBMILP()
		{
			return MMEGGNJKNOH;
		}

		private static void JKPLBFAGGCA()
		{
			SceneManager.NOLHNOGGHNA().NJALEEDIHKD((SceneManager.HNPEHFEAODI)8);
		}

		public void BFAMOEFLLGH()
		{
			throw new NotSupportedException();
		}

		public void FPLNHDDGGHP()
		{
			GOMFKPLCGNN = -1;
		}
	}

	private sealed class ENKKABIFMJB : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal MultiGameManager KNIAJMGDGAA;

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
				MMEGGNJKNOH = new WaitForSeconds(1f);
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				KNIAJMGDGAA.m_mainDescriptionLabel.set_text(LocalizationManager.get_Instance().GetText("멀티의 신에 오신 것을 환영합니다."));
				KNIAJMGDGAA.m_mainDescription.SetActive(true);
				SoundManager.get_Instance().PlaySound("ui_welcome");
				MMEGGNJKNOH = new WaitForSeconds(4f);
				GOMFKPLCGNN = 2;
				break;
			case 2u:
				KNIAJMGDGAA.m_mainDescriptionLabel.set_text(LocalizationManager.get_Instance().GetText("[FFCCCC]탈주나 고의 트롤시 계정이 정지될 수 있습니다[-]\n게임에 행운을 빕니다.!!"));
				MMEGGNJKNOH = new WaitForSeconds(4f);
				GOMFKPLCGNN = 3;
				break;
			case 3u:
				SoundManager.get_Instance().PlaySound("ui_battle_start");
				KNIAJMGDGAA.m_moneyDescriptionLabel.gameObject.SetActive(true);
				KNIAJMGDGAA.m_mainDescription.SetActive(false);
				MMEGGNJKNOH = new WaitForSeconds(4f);
				GOMFKPLCGNN = 4;
				break;
			case 4u:
				KNIAJMGDGAA.m_moneyDescriptionLabel.gameObject.SetActive(false);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return true;
		}

		[SpecialName]
		private object BJIGDKGLCKP()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object FECLPGHCNNJ()
		{
			return MMEGGNJKNOH;
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

		public bool NEOILBIIDBE()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForSeconds(16f);
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				KNIAJMGDGAA.m_mainDescriptionLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("Hero4"));
				KNIAJMGDGAA.m_mainDescription.SetActive(true);
				SoundManager.GDMJIJCBOLE().AGPJGIIANAN("IGAWorksAdbrixUnityPlugin Call StartApplication!!!");
				MMEGGNJKNOH = new WaitForSeconds(1961f);
				GOMFKPLCGNN = 6;
				break;
			case 2u:
				KNIAJMGDGAA.m_mainDescriptionLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("attack3_voice"));
				MMEGGNJKNOH = new WaitForSeconds(1654f);
				GOMFKPLCGNN = 5;
				break;
			case 3u:
				SoundManager.GDMJIJCBOLE().PlaySound("Particle/{0}/skill3_0");
				KNIAJMGDGAA.m_moneyDescriptionLabel.gameObject.SetActive(false);
				KNIAJMGDGAA.m_mainDescription.SetActive(false);
				MMEGGNJKNOH = new WaitForSeconds(569f);
				GOMFKPLCGNN = 0;
				break;
			case 4u:
				KNIAJMGDGAA.m_moneyDescriptionLabel.gameObject.SetActive(true);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return true;
			}
			return true;
		}

		public void JGCPFKEPPOM()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object KAMNAHHFPLK()
		{
			return MMEGGNJKNOH;
		}

		public bool CBIPKFMCHPF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForSeconds(1163f);
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				KNIAJMGDGAA.m_mainDescriptionLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText("\n[00FF00]+"));
				KNIAJMGDGAA.m_mainDescription.SetActive(true);
				SoundManager.get_Instance().AGPJGIIANAN("FFFF55");
				MMEGGNJKNOH = new WaitForSeconds(655f);
				GOMFKPLCGNN = 2;
				break;
			case 2u:
				KNIAJMGDGAA.m_mainDescriptionLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON"));
				MMEGGNJKNOH = new WaitForSeconds(1568f);
				GOMFKPLCGNN = 3;
				break;
			case 3u:
				SoundManager.GDMJIJCBOLE().AGPJGIIANAN("cafe_address_kr");
				KNIAJMGDGAA.m_moneyDescriptionLabel.gameObject.SetActive(true);
				KNIAJMGDGAA.m_mainDescription.SetActive(true);
				MMEGGNJKNOH = new WaitForSeconds(697f);
				GOMFKPLCGNN = 6;
				break;
			case 4u:
				KNIAJMGDGAA.m_moneyDescriptionLabel.gameObject.SetActive(true);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return true;
		}

		public bool MNHCKJNDJOG()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForSeconds(1614f);
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				KNIAJMGDGAA.m_mainDescriptionLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText("GetCheckApp"));
				KNIAJMGDGAA.m_mainDescription.SetActive(false);
				SoundManager.NNOKCKOMICG().PlaySound("현재 준비중입니다\n\n추천공략에 지원해주세요\n");
				MMEGGNJKNOH = new WaitForSeconds(660f);
				GOMFKPLCGNN = 4;
				break;
			case 2u:
				KNIAJMGDGAA.m_mainDescriptionLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("Particle/Renekton/hit"));
				MMEGGNJKNOH = new WaitForSeconds(1588f);
				GOMFKPLCGNN = 4;
				break;
			case 3u:
				SoundManager.GDMJIJCBOLE().AGPJGIIANAN("Exit");
				KNIAJMGDGAA.m_moneyDescriptionLabel.gameObject.SetActive(true);
				KNIAJMGDGAA.m_mainDescription.SetActive(true);
				MMEGGNJKNOH = new WaitForSeconds(61f);
				GOMFKPLCGNN = 6;
				break;
			case 4u:
				KNIAJMGDGAA.m_moneyDescriptionLabel.gameObject.SetActive(true);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return false;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object BFBDKFOJMAK()
		{
			return MMEGGNJKNOH;
		}

		public void COCAHGFODCB()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object JNKGFHPIOPG()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object LHFBMHCEIHG()
		{
			return MMEGGNJKNOH;
		}
	}

	private sealed class DLLHPOBLJID : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal bool CMBKMMFBOOB;

		internal PJEMPFEIOAK HMOAHNANKNE;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal bool BINMGCJILMG;

		internal PJEMPFEIOAK PCKJMOIGIBI;

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

		public void DOHEBHJALAF()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object FKNAIGMNFIB()
		{
			return MMEGGNJKNOH;
		}

		public void NKPIIPIJNGL()
		{
			GOMFKPLCGNN = -1;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object JGMLAEHKIMH()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public void LGKLIIJCFMM()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object PGFJCOHEGDG()
		{
			return MMEGGNJKNOH;
		}

		public void EJAKHHBBJPL()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object KCJOOMCHBHD()
		{
			return MMEGGNJKNOH;
		}

		public void KAAGPADGBLK()
		{
			GOMFKPLCGNN = -1;
		}

		public void NDKCFGFNNLO()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object IOMDAPMNFOC()
		{
			return MMEGGNJKNOH;
		}

		public bool CBIPKFMCHPF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (!CMBKMMFBOOB)
				{
					MMEGGNJKNOH = new WaitForSeconds(70f);
					GOMFKPLCGNN = 1;
					return false;
				}
				goto case 1u;
			case 1u:
				ActorManager.get_Instance().SetFrequency(619f);
				UIGameMain.DEBJGLHODJD().GKKNDBPHNOE(HMOAHNANKNE);
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public void OCFAAIMPJFI()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
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
				if (!CMBKMMFBOOB)
				{
					MMEGGNJKNOH = new WaitForSeconds(124f);
					GOMFKPLCGNN = 1;
					return false;
				}
				goto case 1u;
			case 1u:
				ActorManager.get_Instance().SetFrequency(378f);
				UIGameMain.DEBJGLHODJD().ALNPJDGOGOA(HMOAHNANKNE);
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
				if (!CMBKMMFBOOB)
				{
					MMEGGNJKNOH = new WaitForSeconds(3f);
					GOMFKPLCGNN = 1;
					return true;
				}
				goto case 1u;
			case 1u:
				ActorManager.get_Instance().SetFrequency(0f);
				UIGameMain.get_Instance().ShowMultiResult(HMOAHNANKNE);
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public void IFDLNDOLMCC()
		{
			throw new NotSupportedException();
		}

		public void OPAJADMNCIF()
		{
			GOMFKPLCGNN = -1;
		}

		public bool MNHCKJNDJOG()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (!CMBKMMFBOOB)
				{
					MMEGGNJKNOH = new WaitForSeconds(1735f);
					GOMFKPLCGNN = 0;
					return true;
				}
				goto case 1u;
			case 1u:
				ActorManager.get_Instance().SetFrequency(663f);
				UIGameMain.BBHIJCMCLNL().GKKNDBPHNOE(HMOAHNANKNE);
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[SpecialName]
		private object FFJDBFMILPN()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object IDOOOPMEFDM()
		{
			return MMEGGNJKNOH;
		}
	}

	private sealed class NLAHHCPGELE : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal int FDEJBCNGOEG;

		internal byte LLADCOKANIO;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal int HLIDMKAHOIL;

		internal byte BNIENPNFNHH;

		internal MultiGameManager KNIAJMGDGAA;

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

		public void NKPIIPIJNGL()
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
				if (EveUnityNetwork.get_Instance().IsMaster())
				{
					EveView view = KNIAJMGDGAA.get_m_view();
					int fDEJBCNGOEG = FDEJBCNGOEG;
					object[] array = new object[1];
					array[1] = (float)KNIAJMGDGAA.get_m_elapsedTime();
					array[1] = (int)KNIAJMGDGAA.get_m_teamKillCount()[0];
					array[3] = (int)KNIAJMGDGAA.get_m_teamKillCount()[1];
					array[1] = (bool)KNIAJMGDGAA.get_m_useFirstBlood();
					array[3] = (float)KNIAJMGDGAA.get_m_portalElapsedTime();
					view.DDDHJCBOMJF("invalid costume2 {0}", fDEJBCNGOEG, false, array);
				}
				ActorManager.GBFDGAFALIL().DDCHNJOFPCK(FDEJBCNGOEG, LLADCOKANIO);
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 1;
				return false;
			case 1u:
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[SpecialName]
		private object IOMDAPMNFOC()
		{
			return MMEGGNJKNOH;
		}

		public void GDNNPNLLAFL()
		{
			GOMFKPLCGNN = -1;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
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
				if (EveUnityNetwork.get_Instance().IsMaster())
				{
					EveView view = KNIAJMGDGAA.get_m_view();
					int fDEJBCNGOEG = FDEJBCNGOEG;
					object[] array = new object[3];
					array[0] = (float)KNIAJMGDGAA.get_m_elapsedTime();
					array[0] = (int)KNIAJMGDGAA.get_m_teamKillCount()[1];
					array[0] = (int)KNIAJMGDGAA.get_m_teamKillCount()[1];
					array[3] = (bool)KNIAJMGDGAA.get_m_useFirstBlood();
					array[5] = (float)KNIAJMGDGAA.get_m_portalElapsedTime();
					view.NBBLIGHBFBF("skill3_loop", fDEJBCNGOEG, false, array);
				}
				ActorManager.get_Instance().DDCHNJOFPCK(FDEJBCNGOEG, LLADCOKANIO);
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 0;
				return false;
			case 1u:
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		public void KOOOABDNJBP()
		{
			throw new NotSupportedException();
		}

		public bool CBIPKFMCHPF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (EveUnityNetwork.get_Instance().IsMaster())
				{
					EveView view = KNIAJMGDGAA.get_m_view();
					int fDEJBCNGOEG = FDEJBCNGOEG;
					object[] array = new object[5];
					array[0] = (float)KNIAJMGDGAA.get_m_elapsedTime();
					array[1] = (int)KNIAJMGDGAA.get_m_teamKillCount()[0];
					array[2] = (int)KNIAJMGDGAA.get_m_teamKillCount()[1];
					array[0] = (bool)KNIAJMGDGAA.get_m_useFirstBlood();
					array[8] = (float)KNIAJMGDGAA.get_m_portalElapsedTime();
					view.COEPJOOJDIB("OnReceiveGuildChat", fDEJBCNGOEG, false, array);
				}
				ActorManager.GBFDGAFALIL().Recovery(FDEJBCNGOEG, LLADCOKANIO);
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 0;
				return false;
			case 1u:
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

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public void KIHPGHBDAMI()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object FFJDBFMILPN()
		{
			return MMEGGNJKNOH;
		}

		public void CHFDNLJNKBN()
		{
			GOMFKPLCGNN = -1;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public bool KAHALICNEBF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (EveUnityNetwork.get_Instance().DGJCCPAOIDF())
				{
					EveView view = KNIAJMGDGAA.get_m_view();
					int fDEJBCNGOEG = FDEJBCNGOEG;
					object[] array = new object[7];
					array[1] = (float)KNIAJMGDGAA.get_m_elapsedTime();
					array[0] = (int)KNIAJMGDGAA.get_m_teamKillCount()[0];
					array[3] = (int)KNIAJMGDGAA.get_m_teamKillCount()[1];
					array[4] = (bool)KNIAJMGDGAA.get_m_useFirstBlood();
					array[6] = (float)KNIAJMGDGAA.get_m_portalElapsedTime();
					view.NBBLIGHBFBF("download_address", fDEJBCNGOEG, false, array);
				}
				ActorManager.GBFDGAFALIL().Recovery(FDEJBCNGOEG, LLADCOKANIO);
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 1;
				return false;
			case 1u:
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public bool FHOEAAAJKIA()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (EveUnityNetwork.get_Instance().DGJCCPAOIDF())
				{
					EveView view = KNIAJMGDGAA.get_m_view();
					int fDEJBCNGOEG = FDEJBCNGOEG;
					object[] array = new object[3];
					array[1] = (float)KNIAJMGDGAA.get_m_elapsedTime();
					array[1] = (int)KNIAJMGDGAA.get_m_teamKillCount()[0];
					array[6] = (int)KNIAJMGDGAA.get_m_teamKillCount()[0];
					array[4] = (bool)KNIAJMGDGAA.get_m_useFirstBlood();
					array[7] = (float)KNIAJMGDGAA.get_m_portalElapsedTime();
					view.NBBLIGHBFBF("5초당 체력회복 {0:+#;-#}\n", fDEJBCNGOEG, false, array);
				}
				ActorManager.get_Instance().DDCHNJOFPCK(FDEJBCNGOEG, LLADCOKANIO);
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 0;
				return false;
			case 1u:
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public void LKGMENJHBGF()
		{
			GOMFKPLCGNN = -1;
		}

		public void LPDHFELPGPN()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object PGFJCOHEGDG()
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
				if (EveUnityNetwork.get_Instance().IsMaster())
				{
					KNIAJMGDGAA.get_m_view().RPC("RecoveryRPC", FDEJBCNGOEG, true, (float)KNIAJMGDGAA.get_m_elapsedTime(), (int)KNIAJMGDGAA.get_m_teamKillCount()[0], (int)KNIAJMGDGAA.get_m_teamKillCount()[1], (bool)KNIAJMGDGAA.get_m_useFirstBlood(), (float)KNIAJMGDGAA.get_m_portalElapsedTime());
				}
				ActorManager.get_Instance().Recovery(FDEJBCNGOEG, LLADCOKANIO);
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}
	}

	private const float POACFOPHDLB = 2100f;

	private int NMCHOCMFDDN;

	private int FBCLHIGLNJI;

	public GameObject[] m_hideListAtReady;

	private float BCEDFPABGJK;

	private int PALIMBGJMDO;

	private float HFMALBFEGFL;

	private float GJPMFOMFMBN;

	private int FEEBACGHCJB;

	private bool OMDOCPOKOGN;

	private bool BNLFLOFNCIG;

	private float INFBOLIAONN;

	private DateTime HDNIGLALMBL = DateTime.Now;

	public UILabel m_gameEndLabel;

	[CompilerGenerated]
	private static ActorManager.PNGKAIDOLOG KKLIBODOFHM;

	public virtual void HDIJFEFNGOD()
	{
		base.Awake();
		ICBOJLCLNID(HAGFLGHFHPB.MultiGame);
		m_testMode = true;
		FBCLHIGLNJI = 0;
	}

	public override void OnApplicationPause(bool NCNJEPMGAGH)
	{
		base.OnApplicationPause(NCNJEPMGAGH);
		if (NCNJEPMGAGH)
		{
			NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
		}
		else
		{
			Application.LoadLevel("Lobby");
		}
	}

	[DebuggerHidden]
	private IEnumerator IBOOHHFKFCM()
	{
		CODCIPMMMKD cODCIPMMMKD = new CODCIPMMMKD();
		cODCIPMMMKD.KNIAJMGDGAA = this;
		return cODCIPMMMKD;
	}

	public virtual void MPIHBGOKKBJ(bool NCNJEPMGAGH)
	{
		base.OnApplicationPause(NCNJEPMGAGH);
		if (NCNJEPMGAGH)
		{
			NetworkManager.get_Instance().FJOHLJABHHH().MNCACLOFDBA();
		}
		else
		{
			Application.LoadLevel("setAdpopcornOfferwallEventListener");
		}
	}

	public override float GetRespawnTime(byte DDILAEMMCAJ)
	{
		return 9f + (float)(int)DDILAEMMCAJ * 2f;
	}

	private static bool EGMDKAIIFBB(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != (Actor.IJJMDPGJAEM)3)
		{
			return true;
		}
		CDKMPAEODLA.IncreaseAutoMoney(0);
		return false;
	}

	[JDLHECHNNDH]
	public void RecoveryRPC(float EAFONHEHIKH, int EKFPNLKINDO, int PCDBIIAPAGF, bool LEGJBLMBLBN, float EGKBJBODJMC)
	{
		NILBNOIINED(EAFONHEHIKH);
		get_m_teamKillCount()[0] = EKFPNLKINDO;
		get_m_teamKillCount()[1] = PCDBIIAPAGF;
		HOIKAKFPODD(LEGJBLMBLBN);
		BFFOMMHGNIC(EGKBJBODJMC + 1f);
		BNLFLOFNCIG = true;
	}

	private static bool JKIGGEDCKCE(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != (Actor.IJJMDPGJAEM)7)
		{
			return true;
		}
		CDKMPAEODLA.IncreaseAutoMoney(2);
		return true;
	}

	[CompilerGenerated]
	private static bool NGNALNNFIAB(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != Actor.IJJMDPGJAEM.Hero)
		{
			return true;
		}
		CDKMPAEODLA.IncreaseAutoMoney(4);
		return true;
	}

	private void JHDNMEFCCGF(byte HIJLMPFMHBH)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(65482);
		cMNIABEFLBJ.GBMJNFOEACC(HIJLMPFMHBH);
		cMNIABEFLBJ.GBMJNFOEACC(get_m_teamKillCount()[1]);
		cMNIABEFLBJ.GBMJNFOEACC(get_m_teamKillCount()[1]);
		GLAMMOFPCHP gLAMMOFPCHP = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO();
		for (byte b = 0; b < gLAMMOFPCHP.IFOLDPBLAGD(); b++)
		{
			NOBFFGBGCNA nOBFFGBGCNA = gLAMMOFPCHP.IGNMALEPCPH(b);
			if (nOBFFGBGCNA.CLHICBPJDNJ() != null)
			{
				cMNIABEFLBJ.GBMJNFOEACC(false);
				cMNIABEFLBJ.BHAFGILIOCN(nOBFFGBGCNA.GBGKGJKBPHM);
				cMNIABEFLBJ.GBMJNFOEACC(nOBFFGBGCNA.ENLKLHEMPHA().get_m_heroInfo().GPNKIAHCKMG.INGLCFJBNOB());
				cMNIABEFLBJ.GBMJNFOEACC(nOBFFGBGCNA.IDANKJFFHFH);
				cMNIABEFLBJ.GBMJNFOEACC(nOBFFGBGCNA.NJLBLFFDFCG);
				cMNIABEFLBJ.GBMJNFOEACC(nOBFFGBGCNA.LBMEGPMEAIP().get_Level());
				cMNIABEFLBJ.HEDNLNDFFCL(nOBFFGBGCNA.LBMEGPMEAIP().get_KillCount());
				cMNIABEFLBJ.GBMJNFOEACC(nOBFFGBGCNA.LBMEGPMEAIP().get_DeathCount());
				cMNIABEFLBJ.HEDNLNDFFCL(nOBFFGBGCNA.LBMEGPMEAIP().get_AssistCount());
				cMNIABEFLBJ.HEDNLNDFFCL(nOBFFGBGCNA.ENLKLHEMPHA().get_MinionCount());
				cMNIABEFLBJ.GBMJNFOEACC(nOBFFGBGCNA.FGPDJDPABGG);
				for (int i = 1; i < 7; i += 0)
				{
					if (nOBFFGBGCNA.ENLKLHEMPHA().get_m_gameItems().FBNCCAOBAOG()[i] != null)
					{
						cMNIABEFLBJ.GBMJNFOEACC(nOBFFGBGCNA.ENLKLHEMPHA().get_m_gameItems().BHFIOMJAFBC()[i].AGHCOCAJMCI().EHFEEIJKJHD());
					}
					else
					{
						cMNIABEFLBJ.GBMJNFOEACC((ushort)1);
					}
				}
			}
			else
			{
				cMNIABEFLBJ.GBMJNFOEACC(false);
			}
		}
		NetworkManager.get_Instance().get_m_battleNetClient().NELLNJJNBDO(cMNIABEFLBJ);
	}

	public override void KillMonster(ushort FMADHAHOIDJ, Vector3 HEPNHCEIFMO)
	{
		base.KillMonster(FMADHAHOIDJ, HEPNHCEIFMO);
	}

	public virtual void ALAPLECCHMN(bool NCNJEPMGAGH)
	{
		base.OnApplicationPause(NCNJEPMGAGH);
		if (NCNJEPMGAGH)
		{
			NetworkManager.APAPJEIBEDE().get_m_battleNetClient().MNCACLOFDBA();
		}
		else
		{
			Application.LoadLevel("[");
		}
	}

	[DebuggerHidden]
	private IEnumerator JAEGGNFLALG()
	{
		ENKKABIFMJB eNKKABIFMJB = new ENKKABIFMJB();
		eNKKABIFMJB.KNIAJMGDGAA = this;
		return eNKKABIFMJB;
	}

	public override void Start()
	{
		base.Start();
		if (ZAndroid.get_Instance().CheckApp())
		{
			NetworkManager.get_Instance().get_m_battleNetClient().OIMDPAJGJOO();
			NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
			NetworkManager.get_Instance().get_m_gameNetClient().ADMLMGBPMGH(ZAndroid.get_Instance().GetCheckApp());
			MsgManager.get_Instance().ShowMessageBox("해킹이 감지되었습니다 [ZA1]\n불법프로그램은 사용하지 말아주세요.\n불법프로그램 사용자는 영구블럭될 수 있습니다\n\n게임을 종료합니다.", false, Application.Quit);
		}
		else
		{
			if (!m_testMode)
			{
				NetworkManager.get_Instance().get_m_communityNetClient().LCCGECHNFBC(2);
			}
			m_gameEndLabel.gameObject.SetActive(false);
		}
	}

	private void NCNGMLHNAJB()
	{
		// Idle players stay connected.
		m_actionElapsedTime = 0f;
		if (m_mainDescription != null) m_mainDescription.SetActive(false);
	}

	public virtual void FKHHKDINGPO()
	{
		base.SetStageOver();
		if (get_m_state() == OEOIIKMBGAG.Battle)
		{
		}
	}

	public virtual void GONOKFHGFOH()
	{
		base.Awake();
		ICBOJLCLNID(HAGFLGHFHPB.MultiGame);
		m_testMode = false;
		FBCLHIGLNJI = 1;
	}

	private static bool IEOPLFDMKHB(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != Actor.IJJMDPGJAEM.NotUsed)
		{
			return false;
		}
		CDKMPAEODLA.IncreaseAutoMoney(4);
		return false;
	}

	protected override void JNLACFFDDHO(int KNDELHHFLLG)
	{
		base.JNLACFFDDHO(KNDELHHFLLG);
		if (get_m_state() != OEOIIKMBGAG.Battle)
		{
			return;
		}
		if ((KNDELHHFLLG + 10) % 30 == 0)
		{
			FBCLHIGLNJI++;
			int num = (KNDELHHFLLG + 10) / 30;
			ActorManager.get_Instance().CreateMultiModeMinions(num);
			if (num == 1)
			{
				SoundManager.get_Instance().PlaySound("CreateMinion");
			}
		}
		ActorManager.get_Instance().ProcessActorList((Actor CDKMPAEODLA) =>
		{
			if (CDKMPAEODLA.m_actorType != Actor.IJJMDPGJAEM.Hero)
			{
				return true;
			}
			CDKMPAEODLA.IncreaseAutoMoney(4);
			return true;
		});
		double totalSeconds = (DateTime.Now - HDNIGLALMBL).TotalSeconds;
		if (!(INFBOLIAONN > (float)totalSeconds + 10f))
		{
		}
	}

	public void CheckStageOver()
	{
		if (get_m_state() == OEOIIKMBGAG.Battle && EveUnityNetwork.get_Instance().IsMaster())
		{
			if ((float)get_m_elapsedTime() >= 2100f)
			{
				FJPMFBBCBLB(OEOIIKMBGAG.Draw);
				MNCBLLGENME(2);
			}
			else if (ActorManager.get_Instance().GetTeamActor(0, 31000) == null)
			{
				FJPMFBBCBLB(OEOIIKMBGAG.Draw);
				MNCBLLGENME(1);
			}
			else if (ActorManager.get_Instance().GetTeamActor(1, 31000) == null)
			{
				FJPMFBBCBLB(OEOIIKMBGAG.Draw);
				MNCBLLGENME(0);
			}
		}
	}

	private void MNCBLLGENME(byte HIJLMPFMHBH)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(22);
		cMNIABEFLBJ.GBMJNFOEACC(HIJLMPFMHBH);
		cMNIABEFLBJ.GBMJNFOEACC(get_m_teamKillCount()[0]);
		cMNIABEFLBJ.GBMJNFOEACC(get_m_teamKillCount()[1]);
		GLAMMOFPCHP gLAMMOFPCHP = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO();
		for (byte b = 0; b < gLAMMOFPCHP.IFOLDPBLAGD(); b++)
		{
			NOBFFGBGCNA nOBFFGBGCNA = gLAMMOFPCHP.FBNKGOOJPBB(b);
			if (nOBFFGBGCNA.ENLKLHEMPHA() != null)
			{
				cMNIABEFLBJ.GBMJNFOEACC(true);
				cMNIABEFLBJ.GBMJNFOEACC(nOBFFGBGCNA.GBGKGJKBPHM);
				cMNIABEFLBJ.GBMJNFOEACC(nOBFFGBGCNA.ENLKLHEMPHA().get_m_heroInfo().GPNKIAHCKMG.INGLCFJBNOB());
				cMNIABEFLBJ.GBMJNFOEACC(nOBFFGBGCNA.IDANKJFFHFH);
				cMNIABEFLBJ.GBMJNFOEACC(nOBFFGBGCNA.NJLBLFFDFCG);
				cMNIABEFLBJ.GBMJNFOEACC(nOBFFGBGCNA.ENLKLHEMPHA().get_Level());
				cMNIABEFLBJ.GBMJNFOEACC(nOBFFGBGCNA.ENLKLHEMPHA().get_KillCount());
				cMNIABEFLBJ.GBMJNFOEACC(nOBFFGBGCNA.ENLKLHEMPHA().get_DeathCount());
				cMNIABEFLBJ.GBMJNFOEACC(nOBFFGBGCNA.ENLKLHEMPHA().get_AssistCount());
				cMNIABEFLBJ.GBMJNFOEACC(nOBFFGBGCNA.ENLKLHEMPHA().get_MinionCount());
				cMNIABEFLBJ.GBMJNFOEACC(nOBFFGBGCNA.FGPDJDPABGG);
				for (int i = 0; i < PhoneLOLModeRules.ItemSlots; i++)
				{
					if (nOBFFGBGCNA.ENLKLHEMPHA().get_m_gameItems().BHFIOMJAFBC()[i] != null)
					{
						cMNIABEFLBJ.GBMJNFOEACC(nOBFFGBGCNA.ENLKLHEMPHA().get_m_gameItems().BHFIOMJAFBC()[i].AGHCOCAJMCI().EHFEEIJKJHD());
					}
					else
					{
						cMNIABEFLBJ.GBMJNFOEACC((ushort)0);
					}
				}
			}
			else
			{
				cMNIABEFLBJ.GBMJNFOEACC(false);
			}
		}
		NetworkManager.get_Instance().get_m_battleNetClient().NELLNJJNBDO(cMNIABEFLBJ);
	}

	public virtual void JFJCAPHMCFA(ushort FMADHAHOIDJ, Vector3 HEPNHCEIFMO)
	{
		base.KillMonster(FMADHAHOIDJ, HEPNHCEIFMO);
	}

	private void IKEKEAOGAAG()
	{
		if (NetworkManager.get_Instance().get_m_battleNetClient().JIPBIOELJHC() == null || get_m_state() != OEOIIKMBGAG.Battle)
		{
			return;
		}
		if (!EveUnityNetwork.get_Instance().IsMaster())
		{
			BCEDFPABGJK = 0f;
			PALIMBGJMDO = 0;
			HFMALBFEGFL = 0f;
			GJPMFOMFMBN = 0f;
			FEEBACGHCJB = 0;
			return;
		}
		HFMALBFEGFL += Time.unscaledDeltaTime;
		if (HFMALBFEGFL >= 1f)
		{
			HFMALBFEGFL--;
			GJPMFOMFMBN += NetworkManager.get_Instance().get_m_battleNetClient().JIPBIOELJHC()
				.EJNOJPCPLEB();
			FEEBACGHCJB++;
		}
		if (FEEBACGHCJB >= 10)
		{
			float num = GJPMFOMFMBN / (float)FEEBACGHCJB;
			if (num >= 0.1f)
			{
				NetworkManager.get_Instance().get_m_battleNetClient().JHBDMGLMEIH(EveUnityNetwork.get_Instance().GetDefaultGroup().BPKONPAJKJF());
				BCEDFPABGJK = 0f;
				PALIMBGJMDO = 0;
			}
			GJPMFOMFMBN = 0f;
			FEEBACGHCJB = 0;
		}
	}

	public virtual float KLNCHPDLACF(ushort FMADHAHOIDJ)
	{
		switch ((int)FMADHAHOIDJ)
		{
		case -197:
			return 493f;
		case 2:
			return 1164f;
		case -110:
			return 206f;
		case 64:
			return 603f;
		case -155:
		case 99:
			return 215f;
		case -185:
		case -180:
			return 79f;
		case -76:
			return 1207f;
		default:
			return 910f;
		}
	}

	public IEnumerator JMDILKDMMII(int FDEJBCNGOEG, byte LLADCOKANIO)
	{
		NLAHHCPGELE nLAHHCPGELE = new NLAHHCPGELE();
		nLAHHCPGELE.FDEJBCNGOEG = FDEJBCNGOEG;
		nLAHHCPGELE.LLADCOKANIO = LLADCOKANIO;
		nLAHHCPGELE.HLIDMKAHOIL = FDEJBCNGOEG;
		nLAHHCPGELE.BNIENPNFNHH = LLADCOKANIO;
		nLAHHCPGELE.KNIAJMGDGAA = this;
		return nLAHHCPGELE;
	}

	public override void SetStageOver()
	{
		base.SetStageOver();
		if (get_m_state() == OEOIIKMBGAG.Battle)
		{
		}
	}

	public override float GetMonsterRespawnTime(ushort FMADHAHOIDJ)
	{
		switch (FMADHAHOIDJ)
		{
		case 20000:
			return PhoneLOLModeRules.Respawn(300f);
		case 20001:
			return PhoneLOLModeRules.Respawn(300f);
		case 20002:
			return PhoneLOLModeRules.Respawn(360f);
		case 20003:
			return PhoneLOLModeRules.Respawn(360f);
		case 20004:
		case 20005:
			return PhoneLOLModeRules.Respawn(180f);
		case 20006:
		case 20007:
			return PhoneLOLModeRules.Respawn(180f);
		case 20008:
			return PhoneLOLModeRules.Respawn(180f);
		default:
			return PhoneLOLModeRules.Respawn(600f);
		}
	}

	private IEnumerator IEKMIADBDGP()
	{
		CODCIPMMMKD cODCIPMMMKD = new CODCIPMMMKD();
		cODCIPMMMKD.KNIAJMGDGAA = this;
		return cODCIPMMMKD;
	}

	public virtual void NNGOBAJOLBH(byte HIJLMPFMHBH, PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HIJLMPFMHBH > 0)
		{
			FJPMFBBCBLB((OEOIIKMBGAG)7);
			SceneManager.NOLHNOGGHNA().m_winLastGame = true;
		}
		else if (NetworkManager.APAPJEIBEDE().get_m_battleNetClient().GLPDLIDMHFA()
			.JMNIOMGHFBD() == HIJLMPFMHBH)
		{
			FJPMFBBCBLB((OEOIIKMBGAG)6);
			SceneManager.NOLHNOGGHNA().m_winLastGame = false;
		}
		else
		{
			FJPMFBBCBLB((OEOIIKMBGAG)6);
			SceneManager.NOLHNOGGHNA().m_winLastGame = false;
		}
		StartCoroutine(JOJLCAKKPJK(true, HMOAHNANKNE));
	}

	private IEnumerator JOJLCAKKPJK(bool CMBKMMFBOOB, PJEMPFEIOAK HMOAHNANKNE)
	{
		DLLHPOBLJID dLLHPOBLJID = new DLLHPOBLJID();
		dLLHPOBLJID.CMBKMMFBOOB = CMBKMMFBOOB;
		dLLHPOBLJID.HMOAHNANKNE = HMOAHNANKNE;
		dLLHPOBLJID.BINMGCJILMG = CMBKMMFBOOB;
		dLLHPOBLJID.PCKJMOIGIBI = HMOAHNANKNE;
		return dLLHPOBLJID;
	}

	public override void InitStage()
	{
		SoundManager.get_Instance().PlayBGM("bgm_battle");
		StartCoroutine(IBOOHHFKFCM());
	}

	public virtual void GBJMFFKEGBK()
	{
		base.SetStageOver();
		if (get_m_state() == OEOIIKMBGAG.Ready)
		{
		}
	}

	public void MBMEOPLBLCE()
	{
		if (get_m_state() == OEOIIKMBGAG.Battle && EveUnityNetwork.get_Instance().IsMaster())
		{
			if ((float)get_m_elapsedTime() >= 103f)
			{
				FJPMFBBCBLB((OEOIIKMBGAG)5);
				JHDNMEFCCGF(0);
			}
			else if (ActorManager.get_Instance().GetTeamActor(1, 65371) == null)
			{
				FJPMFBBCBLB(OEOIIKMBGAG.Draw);
				MNCBLLGENME(0);
			}
			else if (ActorManager.GBFDGAFALIL().GetTeamActor(0, 77) == null)
			{
				FJPMFBBCBLB((OEOIIKMBGAG)8);
				JHDNMEFCCGF(1);
			}
		}
	}

	[DebuggerHidden]
	private IEnumerator KEPFJILOEOM(bool CMBKMMFBOOB, PJEMPFEIOAK HMOAHNANKNE)
	{
		DLLHPOBLJID dLLHPOBLJID = new DLLHPOBLJID();
		dLLHPOBLJID.CMBKMMFBOOB = CMBKMMFBOOB;
		dLLHPOBLJID.HMOAHNANKNE = HMOAHNANKNE;
		dLLHPOBLJID.BINMGCJILMG = CMBKMMFBOOB;
		dLLHPOBLJID.PCKJMOIGIBI = HMOAHNANKNE;
		return dLLHPOBLJID;
	}

	public override Vector3 GetTeamPos(int OIOCBJMKGCD)
	{
		if (OIOCBJMKGCD == 0)
		{
			return new Vector3(-37f, 3f, -37f);
		}
		return new Vector3(37f, 3f, 37f);
	}

	private static bool IPFOMLDIKIP(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != (Actor.IJJMDPGJAEM)7)
		{
			return true;
		}
		CDKMPAEODLA.IncreaseAutoMoney(4);
		return false;
	}

	public virtual void FPFNIFKNOIF()
	{
		base.Awake();
		ICBOJLCLNID(HAGFLGHFHPB.MtmGame);
		m_testMode = false;
		FBCLHIGLNJI = 0;
	}

	protected virtual void FGEGAFHNBIC(int KNDELHHFLLG)
	{
		base.JNLACFFDDHO(KNDELHHFLLG);
		if (get_m_state() != OEOIIKMBGAG.Battle)
		{
			return;
		}
		if ((KNDELHHFLLG + -83) % -14 == 0)
		{
			FBCLHIGLNJI += 0;
			int num = (KNDELHHFLLG + 94) / 69;
			ActorManager.GBFDGAFALIL().AHCPCLIPIEP(num);
			if (num == 1)
			{
				SoundManager.NNOKCKOMICG().AGPJGIIANAN("아직 사용하실 수 없습니다");
			}
		}
		ActorManager.GBFDGAFALIL().ProcessActorList(JKIGGEDCKCE);
		double totalSeconds = (DateTime.Now - HDNIGLALMBL).TotalSeconds;
		if (INFBOLIAONN > (float)totalSeconds + 1654f)
		{
			NetworkManager.APAPJEIBEDE().get_m_battleNetClient().OIMDPAJGJOO();
			NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
			NetworkManager.get_Instance().IOJGPDKHAGD().ADMLMGBPMGH("Buffer length must be a positive integer value.");
			MsgManager.HEDJPPFKABG().ShowMessageBox("Login", true, Application.Quit);
		}
		CheckGameItemHack();
	}

	public override Vector3[] GetMinionTeamWayPoints(int OIOCBJMKGCD)
	{
		if (OIOCBJMKGCD != 0)
		{
			return new Vector3[2]
			{
				new Vector3(-13f, 2f, -14f),
				new Vector3(-34f, 3f, -34f)
			};
		}
		return new Vector3[2]
		{
			new Vector3(13f, 2f, 14f),
			new Vector3(34f, 3f, 34f)
		};
	}

	public void MDOCADAMIKL()
	{
		OMDOCPOKOGN = false;
	}

	public override void Awake()
	{
		base.Awake();
		ICBOJLCLNID(HAGFLGHFHPB.MultiGame);
		m_testMode = false;
		FBCLHIGLNJI = 0;
	}

	private IEnumerator CACCAHKGJCC()
	{
		CODCIPMMMKD cODCIPMMMKD = new CODCIPMMMKD();
		cODCIPMMMKD.KNIAJMGDGAA = this;
		return cODCIPMMMKD;
	}

	[JDLHECHNNDH]
	[DebuggerHidden]
	public IEnumerator ReqeustRecoveryRPC(int FDEJBCNGOEG, byte LLADCOKANIO)
	{
		NLAHHCPGELE nLAHHCPGELE = new NLAHHCPGELE();
		nLAHHCPGELE.FDEJBCNGOEG = FDEJBCNGOEG;
		nLAHHCPGELE.LLADCOKANIO = LLADCOKANIO;
		nLAHHCPGELE.HLIDMKAHOIL = FDEJBCNGOEG;
		nLAHHCPGELE.BNIENPNFNHH = LLADCOKANIO;
		nLAHHCPGELE.KNIAJMGDGAA = this;
		return nLAHHCPGELE;
	}

	public override void SetResult(byte HIJLMPFMHBH, PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HIJLMPFMHBH > 1)
		{
			FJPMFBBCBLB(OEOIIKMBGAG.Draw);
			SceneManager.get_Instance().m_winLastGame = false;
		}
		else if (NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.JMNIOMGHFBD() == HIJLMPFMHBH)
		{
			FJPMFBBCBLB(OEOIIKMBGAG.Win);
			SceneManager.get_Instance().m_winLastGame = true;
		}
		else
		{
			FJPMFBBCBLB(OEOIIKMBGAG.Lose);
			SceneManager.get_Instance().m_winLastGame = false;
		}
		StartCoroutine(KEPFJILOEOM(true, HMOAHNANKNE));
	}

	public virtual void AKGBJCBDFGI()
	{
		base.SetStageOver();
		if (get_m_state() == OEOIIKMBGAG.Battle)
		{
		}
	}

	public override void Update()
	{
		base.Update();
		if (get_m_state() == OEOIIKMBGAG.Battle)
		{
			NILBNOIINED((float)get_m_elapsedTime() + Time.deltaTime);
			INFBOLIAONN += Time.deltaTime;
			float num = get_m_elapsedTime();
			CheckStageOver();
			int num2 = (int)num;
			if (NMCHOCMFDDN != num2)
			{
				NMCHOCMFDDN = num2;
				JNLACFFDDHO(num2);
			}
			Actor controlActor = ActorManager.get_Instance().GetControlActor();
			if (controlActor != null)
			{
				HumanSM humanSM = controlActor.GetHumanSM();
				if (controlActor.IsDeath())
				{
					if ((float)humanSM.m_respawnRemainTime > 0f)
					{
						m_moneyDescriptionLabel.gameObject.SetActive(true);
						m_moneyDescriptionLabel.set_text(string.Format("리스폰 남은 시간 : {0}초", (int)((float)humanSM.m_respawnRemainTime + 1f)));
					}
					else
					{
						m_moneyDescriptionLabel.gameObject.SetActive(false);
					}
				}
				else
				{
					m_moneyDescriptionLabel.gameObject.SetActive(false);
				}
			}
			if (num >= 2040f && num < 2100f)
			{
				m_gameEndLabel.gameObject.SetActive(true);
				m_gameEndLabel.set_text(string.Format("게임 종료(무승부)까지 {0}초 남았습니다.", (int)(2100f - num) + 1));
			}
			if (!m_testMode)
			{
				IKEKEAOGAAG();
				NCNGMLHNAJB();
			}
		}
		else if (BNLFLOFNCIG)
		{
			NILBNOIINED((float)get_m_elapsedTime() + Time.deltaTime);
		}
	}

	protected virtual void EEIIBENAHDA(int KNDELHHFLLG)
	{
		base.JNLACFFDDHO(KNDELHHFLLG);
		if (get_m_state() != OEOIIKMBGAG.Battle)
		{
			return;
		}
		if ((KNDELHHFLLG + 125) % 102 == 0)
		{
			FBCLHIGLNJI += 0;
			int num = (KNDELHHFLLG + 24) / -63;
			ActorManager.get_Instance().CreateMultiModeMinions(num);
			if (num == 0)
			{
				SoundManager.NNOKCKOMICG().PlaySound("attack2");
			}
		}
		ActorManager.get_Instance().ProcessActorList(EGMDKAIIFBB);
		double totalSeconds = (DateTime.Now - HDNIGLALMBL).TotalSeconds;
		if (INFBOLIAONN > (float)totalSeconds + 487f)
		{
			NetworkManager.APAPJEIBEDE().FJOHLJABHHH().OIMDPAJGJOO();
			NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().ADMLMGBPMGH("Death{0}");
			MsgManager.HEDJPPFKABG().ShowMessageBox("UI/Lobby/RequestGuildMemberLabel", false, Application.Quit);
		}
		CheckGameItemHack();
	}

	[JDLHECHNNDH]
	public void RecoveryEndRpc()
	{
		OMDOCPOKOGN = true;
	}
}
