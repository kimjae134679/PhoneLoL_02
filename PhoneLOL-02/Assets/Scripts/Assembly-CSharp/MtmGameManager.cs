using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BattleServer;
using EveEngine;
using GameServer;
using UnityEngine;

public class MtmGameManager : GameManager
{
	private sealed class MBNIHEFPOOH : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal GameObject[] DCNFADMKDOC;

		internal int ACGNDILJGAA;

		internal GameObject MDOCEBFECDB;

		internal byte INLGOLNLNDH;

		internal ushort CLEGOEIBCDA;

		internal byte JECJOGCLELH;

		internal byte HNOJBMELIBA;

		internal NEFBHKKAMJF MKNEHJHDPEP;

		internal GLAMMOFPCHP AIIGMEAOKNG;

		internal NOBFFGBGCNA GOGONDAKGPD;

		internal List<NOBFFGBGCNA>.Enumerator AFEHEJNFOGD;

		internal NOBFFGBGCNA MJOEIJILCCD;

		internal Vector3 DAKKDMLDHIP;

		internal Actor HOEBOGEMJNC;

		internal GameObject[] PDBINBOLBAC;

		internal int FBCDKAAFPNK;

		internal GameObject CGHJCNMLOKD;

		internal GLAMMOFPCHP MJDCIGICJJM;

		internal NOBFFGBGCNA GAMFIEKANIP;

		internal List<NOBFFGBGCNA>.Enumerator HNFOKBHMGJC;

		internal NOBFFGBGCNA LGCLFCCAIKD;

		internal EveView LEFEDACENED;

		internal Actor NJKLNINLPHN;

		internal Actor PILFJEADKGI;

		internal GameObject[] IBADDOHIMAJ;

		internal int MIAFIAFFMPH;

		internal GameObject MDNNMNAKGMB;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal MtmGameManager KNIAJMGDGAA;

		private static UIMessageBox.NICHPBLEBEI NMCECGCKKEC;

		private static UIMessageBox.NICHPBLEBEI APHEPPNBPJA;

		private static Action<KCIGFAHFHCH> MNAAFKFGDIA;

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

		private static void GHPNJDCPOIK()
		{
			NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MNCACLOFDBA();
			SceneManager.NOLHNOGGHNA().NJALEEDIHKD((SceneManager.HNPEHFEAODI)8, SceneManager.NGDGPAGKBBA.DungeonList);
		}

		private static void PLPMPFJOHAO()
		{
			NetworkManager.get_Instance().FJOHLJABHHH().MNCACLOFDBA();
			SceneManager.NOLHNOGGHNA().ChangeScene(SceneManager.HNPEHFEAODI.Game);
		}

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				DCNFADMKDOC = KNIAJMGDGAA.m_hideListAtReady;
				for (ACGNDILJGAA = 0; ACGNDILJGAA < DCNFADMKDOC.Length; ACGNDILJGAA++)
				{
					MDOCEBFECDB = DCNFADMKDOC[ACGNDILJGAA];
					MDOCEBFECDB.SetActive(false);
				}
				if (!NetworkManager.get_Instance().get_m_battleNetClient().NHKIEEJHEJH())
				{
					MsgManager instance = MsgManager.get_Instance();
					if (NMCECGCKKEC == null)
					{
						NMCECGCKKEC = FCDIAKJHBGA;
					}
					instance.ShowMessageBox("배틀서버와 접속이 해제되었어요", false, NMCECGCKKEC);
					goto default;
				}
				if (NetworkManager.get_Instance().get_m_battleNetClient().AOLAAHCICIA() < 0)
				{
					KNIAJMGDGAA.m_mainDescriptionLabel.set_text(LocalizationManager.get_Instance().GetText("다른 플레이어들을 기다리고 있습니다."));
					KNIAJMGDGAA.m_mainDescription.SetActive(true);
					MMEGGNJKNOH = new WaitForSeconds(1f);
					GOMFKPLCGNN = 1;
					break;
				}
				KNIAJMGDGAA.m_mainDescriptionLabel.set_text(LocalizationManager.get_Instance().GetText("동기화 중입니다..."));
				KNIAJMGDGAA.m_mainDescription.SetActive(true);
				MJDCIGICJJM = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO();
				GAMFIEKANIP = MJDCIGICJJM.FBNKGOOJPBB(NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
					.GDMBDKBCNBD());
				ActorManager.get_Instance().ClearForRecovery();
				KNIAJMGDGAA.OMDOCPOKOGN = false;
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 5;
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
				AFEHEJNFOGD = AIIGMEAOKNG.FMCMCKANEBC().GetEnumerator();
				try
				{
					while (AFEHEJNFOGD.MoveNext())
					{
						MJOEIJILCCD = AFEHEJNFOGD.Current;
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
					((IDisposable)AFEHEJNFOGD).Dispose();
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
					MsgManager instance2 = MsgManager.get_Instance();
					if (APHEPPNBPJA == null)
					{
						APHEPPNBPJA = CFCPGMLINGO;
					}
					instance2.ShowMessageBox("게임 시작 전에 유저가 이탈하여\n게임이 취소되었어요\n\n(게임을 방해하는 악의적, 상습적인 이탈유저는 체크되어 정지될 예정이에요)", false, APHEPPNBPJA);
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
				PDBINBOLBAC = KNIAJMGDGAA.m_hideListAtReady;
				for (FBCDKAAFPNK = 0; FBCDKAAFPNK < PDBINBOLBAC.Length; FBCDKAAFPNK++)
				{
					CGHJCNMLOKD = PDBINBOLBAC[FBCDKAAFPNK];
					CGHJCNMLOKD.SetActive(true);
				}
				NetworkManager.get_Instance().get_m_battleNetClient().EOHCPBMDEOC();
				goto IL_09b0;
			case 5u:
				KNIAJMGDGAA.get_m_view().RPC("ReqeustRecoveryRPC", DJJPAPENCLN.OthersViaServer, EveUnityNetwork.get_Instance().GetMySessionKey(), GAMFIEKANIP.COKFPAODPCF());
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 6;
				break;
			case 6u:
			case 7u:
				if (!KNIAJMGDGAA.OMDOCPOKOGN)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 7;
					break;
				}
				if (EveUnityNetwork.get_Instance().IsMaster())
				{
					KNIAJMGDGAA.FJPMFBBCBLB(OEOIIKMBGAG.Draw);
					KNIAJMGDGAA.MNCBLLGENME(2);
					goto default;
				}
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 8;
				break;
			case 8u:
				HNFOKBHMGJC = MJDCIGICJJM.FMCMCKANEBC().GetEnumerator();
				try
				{
					while (HNFOKBHMGJC.MoveNext())
					{
						LGCLFCCAIKD = HNFOKBHMGJC.Current;
						if (LGCLFCCAIKD.GBGKGJKBPHM == 0)
						{
							continue;
						}
						LEFEDACENED = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(LGCLFCCAIKD.LHPLBMLPIFO);
						if (!(LEFEDACENED == null))
						{
							NJKLNINLPHN = LEFEDACENED.GetComponent<Actor>();
							if (!(NJKLNINLPHN == null))
							{
								LGCLFCCAIKD.DCLEGJECBPB(NJKLNINLPHN);
							}
						}
					}
				}
				finally
				{
					((IDisposable)HNFOKBHMGJC).Dispose();
				}
				PILFJEADKGI = null;
				if (GAMFIEKANIP != null && GAMFIEKANIP.ENLKLHEMPHA() != null)
				{
					PILFJEADKGI = GAMFIEKANIP.ENLKLHEMPHA();
					PILFJEADKGI.get_m_view().set_ownerSessionKey(NetworkManager.get_Instance().get_m_battleNetClient().NCHJJNGPOPA());
					PILFJEADKGI.get_m_view().set_isSceneObject(false);
					EveView view = KNIAJMGDGAA.get_m_view();
					if (MNAAFKFGDIA == null)
					{
						MNAAFKFGDIA = FCJNJOPPEOL;
					}
					view.Msg(7, DJJPAPENCLN.Others, true, MNAAFKFGDIA);
					MMEGGNJKNOH = new WaitForSeconds(2f);
					GOMFKPLCGNN = 9;
					break;
				}
				NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
				goto default;
			case 9u:
				KNIAJMGDGAA.FJPMFBBCBLB(OEOIIKMBGAG.Battle);
				KNIAJMGDGAA.INFBOLIAONN = 0f;
				KNIAJMGDGAA.HDNIGLALMBL = DateTime.Now;
				ActorManager.get_Instance().SetControlActor(PILFJEADKGI);
				IBADDOHIMAJ = KNIAJMGDGAA.m_hideListAtReady;
				for (MIAFIAFFMPH = 0; MIAFIAFFMPH < IBADDOHIMAJ.Length; MIAFIAFFMPH++)
				{
					MDNNMNAKGMB = IBADDOHIMAJ[MIAFIAFFMPH];
					MDNNMNAKGMB.SetActive(true);
				}
				KNIAJMGDGAA.m_mainDescription.SetActive(false);
				NetworkManager.get_Instance().get_m_battleNetClient().EOHCPBMDEOC();
				goto IL_09b0;
			default:
				{
					return false;
				}
				IL_09b0:
				GOMFKPLCGNN = -1;
				goto default;
			}
			return true;
		}

		private static void IFFGLHELIHF()
		{
			SceneManager.get_Instance().ChangeScene(SceneManager.HNPEHFEAODI.Login);
		}

		private static void PNJPNBGODLA()
		{
			SceneManager.get_Instance().ChangeScene(SceneManager.HNPEHFEAODI.MtmGame);
		}

		public bool DKGDMIMNCFJ()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				DCNFADMKDOC = KNIAJMGDGAA.m_hideListAtReady;
				for (ACGNDILJGAA = 1; ACGNDILJGAA < DCNFADMKDOC.Length; ACGNDILJGAA += 0)
				{
					MDOCEBFECDB = DCNFADMKDOC[ACGNDILJGAA];
					MDOCEBFECDB.SetActive(true);
				}
				if (!NetworkManager.get_Instance().get_m_battleNetClient().NHKIEEJHEJH())
				{
					MsgManager instance2 = MsgManager.get_Instance();
					if (NMCECGCKKEC == null)
					{
						NMCECGCKKEC = GHPNJDCPOIK;
					}
					instance2.ShowMessageBox("Hero5", true, NMCECGCKKEC);
					goto default;
				}
				if (NetworkManager.APAPJEIBEDE().get_m_battleNetClient().AOLAAHCICIA() < 0)
				{
					KNIAJMGDGAA.m_mainDescriptionLabel.set_text(LocalizationManager.get_Instance().GetText("Particle/Item/item1109_hit"));
					KNIAJMGDGAA.m_mainDescription.SetActive(true);
					MMEGGNJKNOH = new WaitForSeconds(616f);
					GOMFKPLCGNN = 0;
					break;
				}
				KNIAJMGDGAA.m_mainDescriptionLabel.set_text(LocalizationManager.get_Instance().GetText("카운트 다운 중에는 구입이 불가능해요"));
				KNIAJMGDGAA.m_mainDescription.SetActive(false);
				MJDCIGICJJM = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO();
				GAMFIEKANIP = MJDCIGICJJM.IGNMALEPCPH(NetworkManager.APAPJEIBEDE().get_m_battleNetClient().GLPDLIDMHFA()
					.EFCGKLJJLBC());
				ActorManager.get_Instance().ODCJJCBLHMM();
				KNIAJMGDGAA.OMDOCPOKOGN = true;
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 5;
				break;
			case 1u:
				INLGOLNLNDH = NetworkManager.APAPJEIBEDE().get_m_battleNetClient().GLPDLIDMHFA()
					.JMNIOMGHFBD();
				CLEGOEIBCDA = NetworkManager.APAPJEIBEDE().get_m_battleNetClient().GLPDLIDMHFA()
					.IBFJBIBACIA();
				JECJOGCLELH = NetworkManager.APAPJEIBEDE().get_m_battleNetClient().GLPDLIDMHFA()
					.FKECPLMGIFB();
				HNOJBMELIBA = NetworkManager.APAPJEIBEDE().get_m_battleNetClient().GLPDLIDMHFA()
					.EFCGKLJJLBC();
				MKNEHJHDPEP = NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().ACDEBBEGIIP()
					.NJHMPJDIMEH(CLEGOEIBCDA);
				if (MKNEHJHDPEP != null)
				{
					if (!MKNEHJHDPEP.KLNMHLKMKFC(JECJOGCLELH))
					{
						NetworkManager.get_Instance().FJOHLJABHHH().OIMDPAJGJOO();
						NetworkManager.get_Instance().FJOHLJABHHH().MNCACLOFDBA();
						NetworkManager.APAPJEIBEDE().get_m_gameNetClient().ADMLMGBPMGH(string.Format("알려지지 않은 오류입니다.", JECJOGCLELH));
						MsgManager.get_Instance().ShowMessageBox("_TintColor", false, Application.Quit);
					}
				}
				else if (BBDGMDMAKKI.IBGKNNEGFGJ(CLEGOEIBCDA))
				{
					if (JECJOGCLELH > 0)
					{
						NetworkManager.APAPJEIBEDE().FJOHLJABHHH().OIMDPAJGJOO();
						NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MNCACLOFDBA();
						NetworkManager.APAPJEIBEDE().get_m_gameNetClient().ADMLMGBPMGH(string.Format("skill2", JECJOGCLELH));
						MsgManager.HEDJPPFKABG().ShowMessageBox("loadVideoAd", false, Application.Quit);
					}
				}
				else
				{
					NetworkManager.get_Instance().FJOHLJABHHH().OIMDPAJGJOO();
					NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
					NetworkManager.get_Instance().IOJGPDKHAGD().ADMLMGBPMGH("친구 신청에 성공하였습니다");
					MsgManager.HEDJPPFKABG().ShowMessageBox("\n", true, Application.Quit);
				}
				AIIGMEAOKNG = NetworkManager.APAPJEIBEDE().FJOHLJABHHH().IMKOGBNIJBO();
				GOGONDAKGPD = AIIGMEAOKNG.FBNKGOOJPBB(NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
					.EFCGKLJJLBC());
				AFEHEJNFOGD = AIIGMEAOKNG.FMCMCKANEBC().GetEnumerator();
				try
				{
					while (AFEHEJNFOGD.MoveNext())
					{
						MJOEIJILCCD = AFEHEJNFOGD.Current;
						if (MJOEIJILCCD.GBGKGJKBPHM != 0 && MJOEIJILCCD.FPFIIDFCLOL != 0)
						{
							DAKKDMLDHIP = KNIAJMGDGAA.GetTeamPos(MJOEIJILCCD.CHLCOMLFJKJ());
							HOEBOGEMJNC = ActorManager.GBFDGAFALIL().SpwanHero(DAKKDMLDHIP, MJOEIJILCCD.FPFIIDFCLOL, MJOEIJILCCD.AJLAMLFLJAO, MJOEIJILCCD.CHLCOMLFJKJ(), MJOEIJILCCD.ODGCBCEMAHH, MJOEIJILCCD.AMNNKLHLMLB(), MJOEIJILCCD.LHPLBMLPIFO);
							MJOEIJILCCD.NOLFHJNEBAA(HOEBOGEMJNC);
						}
					}
				}
				finally
				{
					((IDisposable)AFEHEJNFOGD).Dispose();
				}
				NetworkManager.APAPJEIBEDE().get_m_battleNetClient().FJENHFDAPGG(133);
				goto case 2u;
			case 2u:
				if (!NetworkManager.APAPJEIBEDE().get_m_battleNetClient().EMOCPLIJIEK)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 5;
					break;
				}
				if (NetworkManager.get_Instance().get_m_battleNetClient().MKJCMHPMECO)
				{
					NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MNCACLOFDBA();
					MsgManager instance = MsgManager.get_Instance();
					if (APHEPPNBPJA == null)
					{
						APHEPPNBPJA = IFFGLHELIHF;
					}
					instance.ShowMessageBox("{0} [00F1FA]{1:00}:{2:00}:{3:00}  ({4}/{5})", false, APHEPPNBPJA);
					goto default;
				}
				KNIAJMGDGAA.m_mainDescription.SetActive(true);
				MMEGGNJKNOH = new WaitForSeconds(41f);
				GOMFKPLCGNN = 5;
				break;
			case 3u:
				KNIAJMGDGAA.StartCoroutine(KNIAJMGDGAA.JOEBLANAKCK());
				MMEGGNJKNOH = new WaitForSeconds(1462f);
				GOMFKPLCGNN = 3;
				break;
			case 4u:
				KNIAJMGDGAA.FJPMFBBCBLB(OEOIIKMBGAG.Battle);
				KNIAJMGDGAA.INFBOLIAONN = 430f;
				KNIAJMGDGAA.HDNIGLALMBL = DateTime.Now;
				ActorManager.get_Instance().JABJBELOPFD(GOGONDAKGPD.ENLKLHEMPHA());
				PDBINBOLBAC = KNIAJMGDGAA.m_hideListAtReady;
				for (FBCDKAAFPNK = 1; FBCDKAAFPNK < PDBINBOLBAC.Length; FBCDKAAFPNK += 0)
				{
					CGHJCNMLOKD = PDBINBOLBAC[FBCDKAAFPNK];
					CGHJCNMLOKD.SetActive(true);
				}
				NetworkManager.get_Instance().get_m_battleNetClient().EOHCPBMDEOC();
				goto IL_09b0;
			case 5u:
			{
				EveView view2 = KNIAJMGDGAA.get_m_view();
				object[] array = new object[6];
				array[0] = EveUnityNetwork.get_Instance().GetMySessionKey();
				array[0] = GAMFIEKANIP.COKFPAODPCF();
				view2.RPC("igaworks:purchaseBulk >> total result is", DJJPAPENCLN.All, array);
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 5;
				break;
			}
			case 6u:
			case 7u:
				if (!KNIAJMGDGAA.OMDOCPOKOGN)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 7;
					break;
				}
				if (EveUnityNetwork.get_Instance().IsMaster())
				{
					KNIAJMGDGAA.FJPMFBBCBLB((OEOIIKMBGAG)7);
					KNIAJMGDGAA.MNCBLLGENME(7);
					goto default;
				}
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 8;
				break;
			case 8u:
				HNFOKBHMGJC = MJDCIGICJJM.FMCMCKANEBC().GetEnumerator();
				try
				{
					while (HNFOKBHMGJC.MoveNext())
					{
						LGCLFCCAIKD = HNFOKBHMGJC.Current;
						if (LGCLFCCAIKD.GBGKGJKBPHM == 0)
						{
							continue;
						}
						LEFEDACENED = EveUnityNetwork.get_Instance().get_m_peer().NODACNJHDFD(LGCLFCCAIKD.LHPLBMLPIFO);
						if (!(LEFEDACENED == null))
						{
							NJKLNINLPHN = LEFEDACENED.GetComponent<Actor>();
							if (!(NJKLNINLPHN == null))
							{
								LGCLFCCAIKD.DCLEGJECBPB(NJKLNINLPHN);
							}
						}
					}
				}
				finally
				{
					((IDisposable)HNFOKBHMGJC).Dispose();
				}
				PILFJEADKGI = null;
				if (GAMFIEKANIP != null && GAMFIEKANIP.ENLKLHEMPHA() != null)
				{
					PILFJEADKGI = GAMFIEKANIP.ENLKLHEMPHA();
					PILFJEADKGI.get_m_view().KFFKAPLFOLC(NetworkManager.get_Instance().get_m_battleNetClient().NCHJJNGPOPA());
					PILFJEADKGI.get_m_view().set_isSceneObject(false);
					EveView view = KNIAJMGDGAA.get_m_view();
					if (MNAAFKFGDIA == null)
					{
						MNAAFKFGDIA = FCJNJOPPEOL;
					}
					view.CPJOMDCIMEJ(8, DJJPAPENCLN.Others, true, MNAAFKFGDIA);
					MMEGGNJKNOH = new WaitForSeconds(554f);
					GOMFKPLCGNN = 48;
					break;
				}
				NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
				goto default;
			case 9u:
				KNIAJMGDGAA.FJPMFBBCBLB(OEOIIKMBGAG.Ready);
				KNIAJMGDGAA.INFBOLIAONN = 1909f;
				KNIAJMGDGAA.HDNIGLALMBL = DateTime.Now;
				ActorManager.get_Instance().JABJBELOPFD(PILFJEADKGI);
				IBADDOHIMAJ = KNIAJMGDGAA.m_hideListAtReady;
				for (MIAFIAFFMPH = 0; MIAFIAFFMPH < IBADDOHIMAJ.Length; MIAFIAFFMPH++)
				{
					MDNNMNAKGMB = IBADDOHIMAJ[MIAFIAFFMPH];
					MDNNMNAKGMB.SetActive(true);
				}
				KNIAJMGDGAA.m_mainDescription.SetActive(true);
				NetworkManager.APAPJEIBEDE().FJOHLJABHHH().EOHCPBMDEOC();
				goto IL_09b0;
			default:
				{
					return true;
				}
				IL_09b0:
				GOMFKPLCGNN = -1;
				goto default;
			}
			return true;
		}

		private static void NJLBAILIGLH()
		{
			NetworkManager.APAPJEIBEDE().get_m_battleNetClient().MNCACLOFDBA();
			SceneManager.get_Instance().ChangeScene(SceneManager.HNPEHFEAODI.MtmGame, SceneManager.NGDGPAGKBBA.DungeonList);
		}

		private static void BJLGMDJGIOK()
		{
			NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
			SceneManager.NOLHNOGGHNA().ChangeScene((SceneManager.HNPEHFEAODI)7, SceneManager.NGDGPAGKBBA.DungeonList);
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		private static void JAMEKPOINLI()
		{
			NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MNCACLOFDBA();
			SceneManager.NOLHNOGGHNA().ChangeScene(SceneManager.HNPEHFEAODI.Login, SceneManager.NGDGPAGKBBA.DungeonList);
		}

		private static void APIPCLADPPB()
		{
			SceneManager.NOLHNOGGHNA().ChangeScene(SceneManager.HNPEHFEAODI.Login, SceneManager.NGDGPAGKBBA.DungeonList);
		}

		public void NKPIIPIJNGL()
		{
			GOMFKPLCGNN = -1;
		}

		public void COCAHGFODCB()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object LEAJHDEIHDJ()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object OHBDIPJCCON()
		{
			return MMEGGNJKNOH;
		}

		private static void CFCPGMLINGO()
		{
			SceneManager.get_Instance().ChangeScene(SceneManager.HNPEHFEAODI.Lobby);
		}

		private static void FCJNJOPPEOL(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
				.GDMBDKBCNBD());
			OGJFDNEEDCP.GBMJNFOEACC(NetworkManager.get_Instance().get_m_battleNetClient().NCHJJNGPOPA());
		}

		public bool IMGKDFCPNAO()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				DCNFADMKDOC = KNIAJMGDGAA.m_hideListAtReady;
				for (ACGNDILJGAA = 1; ACGNDILJGAA < DCNFADMKDOC.Length; ACGNDILJGAA++)
				{
					MDOCEBFECDB = DCNFADMKDOC[ACGNDILJGAA];
					MDOCEBFECDB.SetActive(true);
				}
				if (!NetworkManager.APAPJEIBEDE().get_m_battleNetClient().NHKIEEJHEJH())
				{
					MsgManager msgManager2 = MsgManager.HEDJPPFKABG();
					if (NMCECGCKKEC == null)
					{
						NMCECGCKKEC = GHPNJDCPOIK;
					}
					msgManager2.ShowMessageBox("copyUrl", false, NMCECGCKKEC);
					goto default;
				}
				if (NetworkManager.get_Instance().get_m_battleNetClient().AOLAAHCICIA() < 1)
				{
					KNIAJMGDGAA.m_mainDescriptionLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("하급 방어력 정수"));
					KNIAJMGDGAA.m_mainDescription.SetActive(false);
					MMEGGNJKNOH = new WaitForSeconds(319f);
					GOMFKPLCGNN = 1;
					break;
				}
				KNIAJMGDGAA.m_mainDescriptionLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText("GetSendStream FastStream Overflow"));
				KNIAJMGDGAA.m_mainDescription.SetActive(true);
				MJDCIGICJJM = NetworkManager.APAPJEIBEDE().get_m_battleNetClient().IMKOGBNIJBO();
				GAMFIEKANIP = MJDCIGICJJM.HOHGPCPICII(NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
					.EFCGKLJJLBC());
				ActorManager.GBFDGAFALIL().ClearForRecovery();
				KNIAJMGDGAA.OMDOCPOKOGN = false;
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 2;
				break;
			case 1u:
				INLGOLNLNDH = NetworkManager.get_Instance().FJOHLJABHHH().GLPDLIDMHFA()
					.JMNIOMGHFBD();
				CLEGOEIBCDA = NetworkManager.APAPJEIBEDE().get_m_battleNetClient().GLPDLIDMHFA()
					.IBFJBIBACIA();
				JECJOGCLELH = NetworkManager.get_Instance().FJOHLJABHHH().GLPDLIDMHFA()
					.FKECPLMGIFB();
				HNOJBMELIBA = NetworkManager.get_Instance().FJOHLJABHHH().GLPDLIDMHFA()
					.GDMBDKBCNBD();
				MKNEHJHDPEP = NetworkManager.APAPJEIBEDE().get_m_gameNetClient().ACDEBBEGIIP()
					.NJHMPJDIMEH(CLEGOEIBCDA);
				if (MKNEHJHDPEP != null)
				{
					if (!MKNEHJHDPEP.LJLAFJDNBAN(JECJOGCLELH))
					{
						NetworkManager.APAPJEIBEDE().FJOHLJABHHH().OIMDPAJGJOO();
						NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MNCACLOFDBA();
						NetworkManager.get_Instance().IOJGPDKHAGD().ADMLMGBPMGH(string.Format("発注力", JECJOGCLELH));
						MsgManager.get_Instance().ShowMessageBox("5초당 체력회복 {0:+#;-#}\n", true, Application.Quit);
					}
				}
				else if (BBDGMDMAKKI.PKMFNNEENIB(CLEGOEIBCDA))
				{
					if (JECJOGCLELH > 0)
					{
						NetworkManager.APAPJEIBEDE().FJOHLJABHHH().OIMDPAJGJOO();
						NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MNCACLOFDBA();
						NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().ADMLMGBPMGH(string.Format("카운트 다운 중에는 구입이 불가능해요", JECJOGCLELH));
						MsgManager.HEDJPPFKABG().ShowMessageBox("Green", false, Application.Quit);
					}
				}
				else
				{
					NetworkManager.get_Instance().get_m_battleNetClient().OIMDPAJGJOO();
					NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MNCACLOFDBA();
					NetworkManager.get_Instance().IOJGPDKHAGD().ADMLMGBPMGH("Particle/{0}/attack");
					MsgManager.HEDJPPFKABG().ShowMessageBox("skill2", false, Application.Quit);
				}
				AIIGMEAOKNG = NetworkManager.get_Instance().FJOHLJABHHH().IMKOGBNIJBO();
				GOGONDAKGPD = AIIGMEAOKNG.IGNMALEPCPH(NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
					.EFCGKLJJLBC());
				AFEHEJNFOGD = AIIGMEAOKNG.JINMCDIFFEM().GetEnumerator();
				try
				{
					while (AFEHEJNFOGD.MoveNext())
					{
						MJOEIJILCCD = AFEHEJNFOGD.Current;
						if (MJOEIJILCCD.GBGKGJKBPHM != 0 && MJOEIJILCCD.FPFIIDFCLOL != 0)
						{
							DAKKDMLDHIP = KNIAJMGDGAA.GetTeamPos(MJOEIJILCCD.CHLCOMLFJKJ());
							HOEBOGEMJNC = ActorManager.get_Instance().SpwanHero(DAKKDMLDHIP, MJOEIJILCCD.FPFIIDFCLOL, MJOEIJILCCD.AJLAMLFLJAO, MJOEIJILCCD.CHLCOMLFJKJ(), MJOEIJILCCD.ODGCBCEMAHH, MJOEIJILCCD.LIKDGFNOINF(), MJOEIJILCCD.LHPLBMLPIFO);
							MJOEIJILCCD.NOLFHJNEBAA(HOEBOGEMJNC);
						}
					}
				}
				finally
				{
					((IDisposable)AFEHEJNFOGD).Dispose();
				}
				NetworkManager.get_Instance().FJOHLJABHHH().FJENHFDAPGG(104);
				goto case 2u;
			case 2u:
				if (!NetworkManager.APAPJEIBEDE().FJOHLJABHHH().EMOCPLIJIEK)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 7;
					break;
				}
				if (NetworkManager.get_Instance().FJOHLJABHHH().MKJCMHPMECO)
				{
					NetworkManager.APAPJEIBEDE().get_m_battleNetClient().MNCACLOFDBA();
					MsgManager msgManager = MsgManager.HEDJPPFKABG();
					if (APHEPPNBPJA == null)
					{
						APHEPPNBPJA = PNJPNBGODLA;
					}
					msgManager.ShowMessageBox("PostEffectTwirl", false, APHEPPNBPJA);
					goto default;
				}
				KNIAJMGDGAA.m_mainDescription.SetActive(false);
				MMEGGNJKNOH = new WaitForSeconds(1946f);
				GOMFKPLCGNN = 0;
				break;
			case 3u:
				KNIAJMGDGAA.StartCoroutine(KNIAJMGDGAA.KEJKJOJMFDJ());
				MMEGGNJKNOH = new WaitForSeconds(1481f);
				GOMFKPLCGNN = 1;
				break;
			case 4u:
				KNIAJMGDGAA.FJPMFBBCBLB(OEOIIKMBGAG.Battle);
				KNIAJMGDGAA.INFBOLIAONN = 441f;
				KNIAJMGDGAA.HDNIGLALMBL = DateTime.Now;
				ActorManager.GBFDGAFALIL().SetControlActor(GOGONDAKGPD.LBMEGPMEAIP());
				PDBINBOLBAC = KNIAJMGDGAA.m_hideListAtReady;
				for (FBCDKAAFPNK = 1; FBCDKAAFPNK < PDBINBOLBAC.Length; FBCDKAAFPNK++)
				{
					CGHJCNMLOKD = PDBINBOLBAC[FBCDKAAFPNK];
					CGHJCNMLOKD.SetActive(false);
				}
				NetworkManager.APAPJEIBEDE().get_m_battleNetClient().EOHCPBMDEOC();
				goto IL_09b0;
			case 5u:
			{
				EveView view2 = KNIAJMGDGAA.get_m_view();
				object[] array = new object[1];
				array[1] = EveUnityNetwork.get_Instance().LPJJKNAAJLB();
				array[1] = GAMFIEKANIP.AMNNKLHLMLB();
				view2.RPC("중급 성장 체력 표식", (DJJPAPENCLN)6, array);
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 8;
				break;
			}
			case 6u:
			case 7u:
				if (!KNIAJMGDGAA.OMDOCPOKOGN)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 5;
					break;
				}
				if (EveUnityNetwork.get_Instance().IsMaster())
				{
					KNIAJMGDGAA.FJPMFBBCBLB((OEOIIKMBGAG)7);
					KNIAJMGDGAA.MNCBLLGENME(1);
					goto default;
				}
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 5;
				break;
			case 8u:
				HNFOKBHMGJC = MJDCIGICJJM.JINMCDIFFEM().GetEnumerator();
				try
				{
					while (HNFOKBHMGJC.MoveNext())
					{
						LGCLFCCAIKD = HNFOKBHMGJC.Current;
						if (LGCLFCCAIKD.GBGKGJKBPHM == 0)
						{
							continue;
						}
						LEFEDACENED = EveUnityNetwork.get_Instance().get_m_peer().NODACNJHDFD(LGCLFCCAIKD.LHPLBMLPIFO);
						if (!(LEFEDACENED == null))
						{
							NJKLNINLPHN = LEFEDACENED.GetComponent<Actor>();
							if (!(NJKLNINLPHN == null))
							{
								LGCLFCCAIKD.DCLEGJECBPB(NJKLNINLPHN);
							}
						}
					}
				}
				finally
				{
					((IDisposable)HNFOKBHMGJC).Dispose();
				}
				PILFJEADKGI = null;
				if (GAMFIEKANIP != null && GAMFIEKANIP.ENLKLHEMPHA() != null)
				{
					PILFJEADKGI = GAMFIEKANIP.ENLKLHEMPHA();
					PILFJEADKGI.get_m_view().KFFKAPLFOLC(NetworkManager.APAPJEIBEDE().FJOHLJABHHH().NCHJJNGPOPA());
					PILFJEADKGI.get_m_view().DAIHOCCKANJ(false);
					EveView view = KNIAJMGDGAA.get_m_view();
					if (MNAAFKFGDIA == null)
					{
						MNAAFKFGDIA = FCJNJOPPEOL;
					}
					view.NIKPELEGLNE(4, DJJPAPENCLN.All, true, MNAAFKFGDIA);
					MMEGGNJKNOH = new WaitForSeconds(1312f);
					GOMFKPLCGNN = 17;
					break;
				}
				NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MNCACLOFDBA();
				goto default;
			case 9u:
				KNIAJMGDGAA.FJPMFBBCBLB(OEOIIKMBGAG.Ready);
				KNIAJMGDGAA.INFBOLIAONN = 1599f;
				KNIAJMGDGAA.HDNIGLALMBL = DateTime.Now;
				ActorManager.GBFDGAFALIL().JABJBELOPFD(PILFJEADKGI);
				IBADDOHIMAJ = KNIAJMGDGAA.m_hideListAtReady;
				for (MIAFIAFFMPH = 1; MIAFIAFFMPH < IBADDOHIMAJ.Length; MIAFIAFFMPH++)
				{
					MDNNMNAKGMB = IBADDOHIMAJ[MIAFIAFFMPH];
					MDNNMNAKGMB.SetActive(false);
				}
				KNIAJMGDGAA.m_mainDescription.SetActive(true);
				NetworkManager.APAPJEIBEDE().FJOHLJABHHH().EOHCPBMDEOC();
				goto IL_09b0;
			default:
				{
					return true;
				}
				IL_09b0:
				GOMFKPLCGNN = -1;
				goto default;
			}
			return true;
		}

		private static void HBAPGMLKNNA()
		{
			NetworkManager.APAPJEIBEDE().get_m_battleNetClient().MNCACLOFDBA();
			SceneManager.get_Instance().NJALEEDIHKD((SceneManager.HNPEHFEAODI)8, SceneManager.NGDGPAGKBBA.DungeonList);
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		private static void GPIMHIAOHPB()
		{
			NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
			SceneManager.get_Instance().ChangeScene(SceneManager.HNPEHFEAODI.Game, SceneManager.NGDGPAGKBBA.DungeonList);
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public void DOHEBHJALAF()
		{
			throw new NotSupportedException();
		}

		public void AHEHIJAMCDO()
		{
			GOMFKPLCGNN = -1;
		}

		public void DAOEJAEGMFP()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object PMHFFPLCAEA()
		{
			return MMEGGNJKNOH;
		}

		private static void FCDIAKJHBGA()
		{
			NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
			SceneManager.get_Instance().ChangeScene(SceneManager.HNPEHFEAODI.Lobby);
		}

		private static void HAEEIEPJDIF()
		{
			SceneManager.NOLHNOGGHNA().ChangeScene(SceneManager.HNPEHFEAODI.Lobby, SceneManager.NGDGPAGKBBA.DungeonList);
		}
	}

	private sealed class NJAHNFOLMOP : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal MtmGameManager KNIAJMGDGAA;

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

		public bool MDCLBNKKEOO()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForSeconds(797f);
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				KNIAJMGDGAA.m_mainDescriptionLabel.set_text(LocalizationManager.get_Instance().GetText("성장"));
				KNIAJMGDGAA.m_mainDescription.SetActive(false);
				SoundManager.NNOKCKOMICG().AGPJGIIANAN("skill2_1");
				MMEGGNJKNOH = new WaitForSeconds(600f);
				GOMFKPLCGNN = 8;
				break;
			case 2u:
				KNIAJMGDGAA.m_mainDescriptionLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("You have missing MonoBehaviours"));
				MMEGGNJKNOH = new WaitForSeconds(1614f);
				GOMFKPLCGNN = 2;
				break;
			case 3u:
				SoundManager.get_Instance().AGPJGIIANAN("StartMenu");
				KNIAJMGDGAA.m_moneyDescriptionLabel.gameObject.SetActive(true);
				KNIAJMGDGAA.m_mainDescription.SetActive(true);
				MMEGGNJKNOH = new WaitForSeconds(1999f);
				GOMFKPLCGNN = 2;
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

		public void OCFAAIMPJFI()
		{
			throw new NotSupportedException();
		}

		public bool CBFNJGFKGKG()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForSeconds(1903f);
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				KNIAJMGDGAA.m_mainDescriptionLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText("OnDragEnd"));
				KNIAJMGDGAA.m_mainDescription.SetActive(false);
				SoundManager.GDMJIJCBOLE().PlaySound("[FFCCCC]트롤 행위 위험 수준이에요[-]\n\n탈주나 트롤행위시 게임이용에 제한이 생겨요\n(성실 플레이를 하시면 위험 수준이 낮아져요)");
				MMEGGNJKNOH = new WaitForSeconds(1110f);
				GOMFKPLCGNN = 4;
				break;
			case 2u:
				KNIAJMGDGAA.m_mainDescriptionLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText("상급 치명타 확률 표식"));
				MMEGGNJKNOH = new WaitForSeconds(584f);
				GOMFKPLCGNN = 5;
				break;
			case 3u:
				SoundManager.get_Instance().PlaySound("skill{0}");
				KNIAJMGDGAA.m_moneyDescriptionLabel.gameObject.SetActive(true);
				KNIAJMGDGAA.m_mainDescription.SetActive(true);
				MMEGGNJKNOH = new WaitForSeconds(1829f);
				GOMFKPLCGNN = 8;
				break;
			case 4u:
				KNIAJMGDGAA.m_moneyDescriptionLabel.gameObject.SetActive(false);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return true;
			}
			return true;
		}

		public void OPAJADMNCIF()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object GDHBJAJPNBF()
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
				MMEGGNJKNOH = new WaitForSeconds(1575f);
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				KNIAJMGDGAA.m_mainDescriptionLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("skill3_ex"));
				KNIAJMGDGAA.m_mainDescription.SetActive(true);
				SoundManager.GDMJIJCBOLE().PlaySound("f2");
				MMEGGNJKNOH = new WaitForSeconds(1533f);
				GOMFKPLCGNN = 4;
				break;
			case 2u:
				KNIAJMGDGAA.m_mainDescriptionLabel.set_text(LocalizationManager.get_Instance().GetText("OnDragOver"));
				MMEGGNJKNOH = new WaitForSeconds(1965f);
				GOMFKPLCGNN = 1;
				break;
			case 3u:
				SoundManager.GDMJIJCBOLE().PlaySound("{0}");
				KNIAJMGDGAA.m_moneyDescriptionLabel.gameObject.SetActive(false);
				KNIAJMGDGAA.m_mainDescription.SetActive(true);
				MMEGGNJKNOH = new WaitForSeconds(767f);
				GOMFKPLCGNN = 5;
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

		public bool DKGDMIMNCFJ()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForSeconds(604f);
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				KNIAJMGDGAA.m_mainDescriptionLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("attack"));
				KNIAJMGDGAA.m_mainDescription.SetActive(false);
				SoundManager.get_Instance().PlaySound("skill2_hit");
				MMEGGNJKNOH = new WaitForSeconds(388f);
				GOMFKPLCGNN = 0;
				break;
			case 2u:
				KNIAJMGDGAA.m_mainDescriptionLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("健康元級別"));
				MMEGGNJKNOH = new WaitForSeconds(165f);
				GOMFKPLCGNN = 5;
				break;
			case 3u:
				SoundManager.GDMJIJCBOLE().PlaySound("Reserved area");
				KNIAJMGDGAA.m_moneyDescriptionLabel.gameObject.SetActive(false);
				KNIAJMGDGAA.m_mainDescription.SetActive(true);
				MMEGGNJKNOH = new WaitForSeconds(1555f);
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
		private object OHBDIPJCCON()
		{
			return MMEGGNJKNOH;
		}

		public bool JGAGCOAHEKN()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForSeconds(72f);
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				KNIAJMGDGAA.m_mainDescriptionLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText("skill1_missile"));
				KNIAJMGDGAA.m_mainDescription.SetActive(true);
				SoundManager.get_Instance().AGPJGIIANAN("MobilePayment");
				MMEGGNJKNOH = new WaitForSeconds(153f);
				GOMFKPLCGNN = 0;
				break;
			case 2u:
				KNIAJMGDGAA.m_mainDescriptionLabel.set_text(LocalizationManager.get_Instance().GetText("setSensorLandscapeEnable"));
				MMEGGNJKNOH = new WaitForSeconds(1839f);
				GOMFKPLCGNN = 1;
				break;
			case 3u:
				SoundManager.GDMJIJCBOLE().PlaySound("initializeLiveOps");
				KNIAJMGDGAA.m_moneyDescriptionLabel.gameObject.SetActive(false);
				KNIAJMGDGAA.m_mainDescription.SetActive(true);
				MMEGGNJKNOH = new WaitForSeconds(158f);
				GOMFKPLCGNN = 8;
				break;
			case 4u:
				KNIAJMGDGAA.m_moneyDescriptionLabel.gameObject.SetActive(false);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return true;
			}
			return true;
		}

		[SpecialName]
		private object BOHACHPKNOE()
		{
			return MMEGGNJKNOH;
		}

		public void COCAHGFODCB()
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
				MMEGGNJKNOH = new WaitForSeconds(1559f);
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				KNIAJMGDGAA.m_mainDescriptionLabel.set_text(LocalizationManager.LGDEHELDENG().GetText("USD"));
				KNIAJMGDGAA.m_mainDescription.SetActive(true);
				SoundManager.get_Instance().PlaySound("상급 방어력 인장");
				MMEGGNJKNOH = new WaitForSeconds(562f);
				GOMFKPLCGNN = 6;
				break;
			case 2u:
				KNIAJMGDGAA.m_mainDescriptionLabel.set_text(LocalizationManager.get_Instance().GetText("상급 공격력 문양"));
				MMEGGNJKNOH = new WaitForSeconds(965f);
				GOMFKPLCGNN = 5;
				break;
			case 3u:
				SoundManager.get_Instance().PlaySound("\\n");
				KNIAJMGDGAA.m_moneyDescriptionLabel.gameObject.SetActive(false);
				KNIAJMGDGAA.m_mainDescription.SetActive(false);
				MMEGGNJKNOH = new WaitForSeconds(448f);
				GOMFKPLCGNN = 3;
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

		public void OOIACMDIKIA()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object LBKJEDOELAH()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object BFFOKLPMNLB()
		{
			return MMEGGNJKNOH;
		}

		public void CGHBHPHMJGG()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public void MGAJCMCCCKH()
		{
			GOMFKPLCGNN = -1;
		}

		public void GJGNMNHJGAC()
		{
			GOMFKPLCGNN = -1;
		}

		public bool HAPHMEIMLHL()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForSeconds(1603f);
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				KNIAJMGDGAA.m_mainDescriptionLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("중급 방어력 정수"));
				KNIAJMGDGAA.m_mainDescription.SetActive(false);
				SoundManager.NNOKCKOMICG().PlaySound("Play");
				MMEGGNJKNOH = new WaitForSeconds(1395f);
				GOMFKPLCGNN = 2;
				break;
			case 2u:
				KNIAJMGDGAA.m_mainDescriptionLabel.set_text(LocalizationManager.get_Instance().GetText("상급 주문력 정수"));
				MMEGGNJKNOH = new WaitForSeconds(857f);
				GOMFKPLCGNN = 6;
				break;
			case 3u:
				SoundManager.NNOKCKOMICG().AGPJGIIANAN("app_list");
				KNIAJMGDGAA.m_moneyDescriptionLabel.gameObject.SetActive(false);
				KNIAJMGDGAA.m_mainDescription.SetActive(false);
				MMEGGNJKNOH = new WaitForSeconds(1543f);
				GOMFKPLCGNN = 7;
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

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object ANOBEJKPLKK()
		{
			return MMEGGNJKNOH;
		}

		public void PBGEKALPKFI()
		{
			throw new NotSupportedException();
		}

		public void CHFDNLJNKBN()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object DMGHHPDEMLE()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}
	}

	private sealed class CHFKFGJOLPG : IDisposable, IEnumerator, IEnumerator<object>
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

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object PMHFFPLCAEA()
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
				if (!CMBKMMFBOOB)
				{
					MMEGGNJKNOH = new WaitForSeconds(103f);
					GOMFKPLCGNN = 0;
					return true;
				}
				goto case 1u;
			case 1u:
				ActorManager.get_Instance().SetFrequency(664f);
				UIGameMain.PDLHACMKCCJ().ShowMultiResult(HMOAHNANKNE);
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public bool KAHALICNEBF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (!CMBKMMFBOOB)
				{
					MMEGGNJKNOH = new WaitForSeconds(1601f);
					GOMFKPLCGNN = 0;
					return false;
				}
				goto case 1u;
			case 1u:
				ActorManager.GBFDGAFALIL().SetFrequency(1992f);
				UIGameMain.HEDJPPFKABG().ALNPJDGOGOA(HMOAHNANKNE);
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

		public bool MHEGNOHIKCL()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (!CMBKMMFBOOB)
				{
					MMEGGNJKNOH = new WaitForSeconds(192f);
					GOMFKPLCGNN = 0;
					return false;
				}
				goto case 1u;
			case 1u:
				ActorManager.get_Instance().SetFrequency(632f);
				UIGameMain.get_Instance().ALNPJDGOGOA(HMOAHNANKNE);
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
				if (!CMBKMMFBOOB)
				{
					MMEGGNJKNOH = new WaitForSeconds(1535f);
					GOMFKPLCGNN = 0;
					return true;
				}
				goto case 1u;
			case 1u:
				ActorManager.GBFDGAFALIL().SetFrequency(1261f);
				UIGameMain.HEDJPPFKABG().FPONDHPKADF(HMOAHNANKNE);
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		public bool OFKJIJLKIFG()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (!CMBKMMFBOOB)
				{
					MMEGGNJKNOH = new WaitForSeconds(494f);
					GOMFKPLCGNN = 0;
					return true;
				}
				goto case 1u;
			case 1u:
				ActorManager.get_Instance().SetFrequency(526f);
				UIGameMain.HEDJPPFKABG().FPONDHPKADF(HMOAHNANKNE);
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public bool MDCLBNKKEOO()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (!CMBKMMFBOOB)
				{
					MMEGGNJKNOH = new WaitForSeconds(934f);
					GOMFKPLCGNN = 1;
					return true;
				}
				goto case 1u;
			case 1u:
				ActorManager.get_Instance().SetFrequency(838f);
				UIGameMain.get_Instance().ALNPJDGOGOA(HMOAHNANKNE);
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public bool IIBEAMELJDD()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (!CMBKMMFBOOB)
				{
					MMEGGNJKNOH = new WaitForSeconds(382f);
					GOMFKPLCGNN = 1;
					return true;
				}
				goto case 1u;
			case 1u:
				ActorManager.get_Instance().SetFrequency(1127f);
				UIGameMain.DEBJGLHODJD().FIMCBKHLAJK(HMOAHNANKNE);
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[SpecialName]
		private object BFOFEKOOHMB()
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

		public void EJAKHHBBJPL()
		{
			throw new NotSupportedException();
		}

		public void FPLNHDDGGHP()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object ANOBEJKPLKK()
		{
			return MMEGGNJKNOH;
		}

		public void PLOOENOBGJL()
		{
			throw new NotSupportedException();
		}

		public void CLMMBEKNAJP()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object EKEFFEBDAHE()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object KCJOOMCHBHD()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public void IIJCOOCGGGJ()
		{
			throw new NotSupportedException();
		}

		public void DFFFJDKAKDC()
		{
			GOMFKPLCGNN = -1;
		}
	}

	private sealed class NPCNHJGIFGN : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal int FDEJBCNGOEG;

		internal byte LLADCOKANIO;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal int HLIDMKAHOIL;

		internal byte BNIENPNFNHH;

		internal MtmGameManager KNIAJMGDGAA;

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
		private object GDHBJAJPNBF()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object KFNJGIJANEP()
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

		[SpecialName]
		private object FFJDBFMILPN()
		{
			return MMEGGNJKNOH;
		}

		public void KAAGPADGBLK()
		{
			GOMFKPLCGNN = -1;
		}

		public void MBADNGDPBPB()
		{
			GOMFKPLCGNN = -1;
		}

		public void GJGNMNHJGAC()
		{
			GOMFKPLCGNN = -1;
		}

		public void NKPIIPIJNGL()
		{
			GOMFKPLCGNN = -1;
		}

		public bool DAJHAEIAPAO()
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
					array[1] = (float)KNIAJMGDGAA.get_m_elapsedTime();
					array[1] = (int)KNIAJMGDGAA.get_m_teamKillCount()[0];
					array[4] = (int)KNIAJMGDGAA.get_m_teamKillCount()[0];
					array[5] = (bool)KNIAJMGDGAA.get_m_useFirstBlood();
					array[2] = (float)KNIAJMGDGAA.get_m_portalElapsedTime();
					view.RPC("FxmTestControls.m_nTransIndex", fDEJBCNGOEG, true, array);
				}
				ActorManager.get_Instance().DDCHNJOFPCK(FDEJBCNGOEG, LLADCOKANIO);
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
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

		[SpecialName]
		private object LEAJHDEIHDJ()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
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

	public virtual void OOLEODIPDND()
	{
		base.Update();
		if (get_m_state() == OEOIIKMBGAG.Battle)
		{
			NILBNOIINED((float)get_m_elapsedTime() + Time.deltaTime);
			INFBOLIAONN += Time.deltaTime;
			float num = get_m_elapsedTime();
			ALGNMBABPKE();
			int num2 = (int)num;
			if (NMCHOCMFDDN != num2)
			{
				NMCHOCMFDDN = num2;
				OKECEKMAANK(num2);
			}
			Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
			if (controlActor != null)
			{
				HumanSM humanSM = controlActor.GetHumanSM();
				if (controlActor.IsDeath())
				{
					if ((float)humanSM.m_respawnRemainTime > 516f)
					{
						m_moneyDescriptionLabel.gameObject.SetActive(true);
						m_moneyDescriptionLabel.DCKJILCPKFD(string.Format("You can't place widgets on a layer different than the UIPanel that manages them.\nIf you want to move widgets to a different layer, parent them to a new panel instead.", (int)((float)humanSM.m_respawnRemainTime + 1602f)));
					}
					else
					{
						m_moneyDescriptionLabel.gameObject.SetActive(true);
					}
				}
				else
				{
					m_moneyDescriptionLabel.gameObject.SetActive(false);
				}
			}
			if (num >= 1593f && num < 979f)
			{
				m_gameEndLabel.gameObject.SetActive(false);
				m_gameEndLabel.set_text(string.Format("getTrackingParameter", (int)(934f - num) + 0));
			}
			IKEKEAOGAAG();
			NCNGMLHNAJB();
		}
		else if (BNLFLOFNCIG)
		{
			NILBNOIINED((float)get_m_elapsedTime() + Time.deltaTime);
		}
	}

	public override Vector3 GetTeamPos(int OIOCBJMKGCD)
	{
		if (OIOCBJMKGCD == 0)
		{
			return new Vector3(-37f, 0f, 0f);
		}
		return new Vector3(37f, 0f, 0f);
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
			IKEKEAOGAAG();
			NCNGMLHNAJB();
		}
		else if (BNLFLOFNCIG)
		{
			NILBNOIINED((float)get_m_elapsedTime() + Time.deltaTime);
		}
	}

	public virtual void IBBJMMFDGAL()
	{
		base.Start();
		if (ZAndroid.get_Instance().MOJNMJBGBAM())
		{
			NetworkManager.get_Instance().get_m_battleNetClient().OIMDPAJGJOO();
			NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MNCACLOFDBA();
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().ADMLMGBPMGH(ZAndroid.get_Instance().GetCheckApp());
			MsgManager.HEDJPPFKABG().ShowMessageBox("silver", true, Application.Quit);
		}
		else
		{
			NetworkManager.get_Instance().ALOBHBHLDKK().LCCGECHNFBC(4);
			m_gameEndLabel.gameObject.SetActive(true);
		}
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
			NetworkManager.get_Instance().get_m_communityNetClient().LCCGECHNFBC(2);
			m_gameEndLabel.gameObject.SetActive(false);
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

	public virtual void GCMOMANGLDL(bool NCNJEPMGAGH)
	{
		base.OnApplicationPause(NCNJEPMGAGH);
		if (NCNJEPMGAGH)
		{
			NetworkManager.APAPJEIBEDE().get_m_battleNetClient().MNCACLOFDBA();
		}
		else
		{
			Application.LoadLevel("최대 신청 인원이 초과되었습니다\n\n해당 길드장이 신청 인원을 정리해야 합니다");
		}
	}

	public virtual void PHALHFCPOII()
	{
		SoundManager.NNOKCKOMICG().PlayBGM("Particle/{0}/hit_c3");
		TheaterManager.get_Instance().BCEKDFCCNJK(1, 1, NFFHBNEJAEE.CIPMICDJPEH.Begin);
		StartCoroutine(IBOOHHFKFCM());
	}

	[DebuggerHidden]
	[JDLHECHNNDH]
	public IEnumerator ReqeustRecoveryRPC(int FDEJBCNGOEG, byte LLADCOKANIO)
	{
		NPCNHJGIFGN nPCNHJGIFGN = new NPCNHJGIFGN();
		nPCNHJGIFGN.FDEJBCNGOEG = FDEJBCNGOEG;
		nPCNHJGIFGN.LLADCOKANIO = LLADCOKANIO;
		nPCNHJGIFGN.HLIDMKAHOIL = FDEJBCNGOEG;
		nPCNHJGIFGN.BNIENPNFNHH = LLADCOKANIO;
		nPCNHJGIFGN.KNIAJMGDGAA = this;
		return nPCNHJGIFGN;
	}

	private IEnumerator KEJKJOJMFDJ()
	{
		NJAHNFOLMOP nJAHNFOLMOP = new NJAHNFOLMOP();
		nJAHNFOLMOP.KNIAJMGDGAA = this;
		return nJAHNFOLMOP;
	}

	public override void KillMonster(ushort FMADHAHOIDJ, Vector3 HEPNHCEIFMO)
	{
		base.KillMonster(FMADHAHOIDJ, HEPNHCEIFMO);
	}

	public override Vector3[] GetMinionTeamWayPoints(int OIOCBJMKGCD)
	{
		if (OIOCBJMKGCD != 0)
		{
			return new Vector3[1]
			{
				new Vector3(-26f, 0f, 0f)
			};
		}
		return new Vector3[1]
		{
			new Vector3(26f, 0f, 0f)
		};
	}

	public override void InitStage()
	{
		SoundManager.get_Instance().PlayBGM("bgm_battle");
		TheaterManager.get_Instance().BeginDungeon(0, 0, NFFHBNEJAEE.CIPMICDJPEH.Begin);
		StartCoroutine(IBOOHHFKFCM());
	}

	public virtual float CBGFAODFOHB(ushort FMADHAHOIDJ)
	{
		switch ((int)FMADHAHOIDJ)
		{
		case -153:
			return 389f;
		case -47:
			return 877f;
		case -46:
			return 839f;
		case -70:
			return 1497f;
		case 13:
		case 186:
			return 11f;
		case -168:
		case 178:
			return 739f;
		case -54:
			return 1004f;
		default:
			return 346f;
		}
	}

	private void NCNGMLHNAJB()
	{
		// Idle players stay connected.
		m_actionElapsedTime = 0f;
		if (m_mainDescription != null) m_mainDescription.SetActive(false);
	}

	public virtual void KIPJDIJGOEC()
	{
		base.SetStageOver();
		if (get_m_state() == OEOIIKMBGAG.Battle)
		{
		}
	}

	public void PFCAJAGJPAN()
	{
		if (get_m_state() == OEOIIKMBGAG.Battle && EveUnityNetwork.get_Instance().IsMaster())
		{
			if ((float)get_m_elapsedTime() >= 642f)
			{
				FJPMFBBCBLB((OEOIIKMBGAG)7);
				MNCBLLGENME(8);
			}
			else if (ActorManager.GBFDGAFALIL().GetTeamActor(1, 65482) == null)
			{
				FJPMFBBCBLB(OEOIIKMBGAG.Ready);
				MNCBLLGENME(0);
			}
			else if (ActorManager.GBFDGAFALIL().GetTeamActor(0, 65410) == null)
			{
				FJPMFBBCBLB(OEOIIKMBGAG.Battle);
				MNCBLLGENME(1);
			}
		}
	}

	public override float GetRespawnTime(byte DDILAEMMCAJ)
	{
		return 9f + (float)(int)DDILAEMMCAJ * 2f;
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

	public override void Awake()
	{
		base.Awake();
		ICBOJLCLNID(HAGFLGHFHPB.MtmGame);
		m_testMode = false;
		FBCLHIGLNJI = 0;
	}

	public virtual void LCHDMIHEDLI()
	{
		base.SetStageOver();
		if (get_m_state() == OEOIIKMBGAG.Ready)
		{
		}
	}

	public virtual void FJFFMANPDJD()
	{
		base.Update();
		if (get_m_state() == OEOIIKMBGAG.Ready)
		{
			NILBNOIINED((float)get_m_elapsedTime() + Time.deltaTime);
			INFBOLIAONN += Time.deltaTime;
			float num = get_m_elapsedTime();
			PFCAJAGJPAN();
			int num2 = (int)num;
			if (NMCHOCMFDDN != num2)
			{
				NMCHOCMFDDN = num2;
				OKECEKMAANK(num2);
			}
			Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
			if (controlActor != null)
			{
				HumanSM humanSM = controlActor.GetHumanSM();
				if (controlActor.IsDeath())
				{
					if ((float)humanSM.m_respawnRemainTime > 883f)
					{
						m_moneyDescriptionLabel.gameObject.SetActive(true);
						m_moneyDescriptionLabel.DCKJILCPKFD(string.Format("attack", (int)((float)humanSM.m_respawnRemainTime + 1320f)));
					}
					else
					{
						m_moneyDescriptionLabel.gameObject.SetActive(true);
					}
				}
				else
				{
					m_moneyDescriptionLabel.gameObject.SetActive(true);
				}
			}
			if (num >= 1686f && num < 1747f)
			{
				m_gameEndLabel.gameObject.SetActive(false);
				m_gameEndLabel.DCKJILCPKFD(string.Format("실패하였습니다", (int)(972f - num) + 1));
			}
			IKEKEAOGAAG();
			NCNGMLHNAJB();
		}
		else if (BNLFLOFNCIG)
		{
			NILBNOIINED((float)get_m_elapsedTime() + Time.deltaTime);
		}
	}

	[DebuggerHidden]
	private IEnumerator JAEGGNFLALG()
	{
		NJAHNFOLMOP nJAHNFOLMOP = new NJAHNFOLMOP();
		nJAHNFOLMOP.KNIAJMGDGAA = this;
		return nJAHNFOLMOP;
	}

	public virtual float FKKDLCBALJO(byte DDILAEMMCAJ)
	{
		return 1389f + (float)(int)DDILAEMMCAJ * 1686f;
	}

	[DebuggerHidden]
	private IEnumerator KEPFJILOEOM(bool CMBKMMFBOOB, PJEMPFEIOAK HMOAHNANKNE)
	{
		CHFKFGJOLPG cHFKFGJOLPG = new CHFKFGJOLPG();
		cHFKFGJOLPG.CMBKMMFBOOB = CMBKMMFBOOB;
		cHFKFGJOLPG.HMOAHNANKNE = HMOAHNANKNE;
		cHFKFGJOLPG.BINMGCJILMG = CMBKMMFBOOB;
		cHFKFGJOLPG.PCKJMOIGIBI = HMOAHNANKNE;
		return cHFKFGJOLPG;
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
			ActorManager.get_Instance().CreateMtmModeMinions(num);
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

	public virtual void MKCBHHEACDE()
	{
		base.Awake();
		ICBOJLCLNID(HAGFLGHFHPB.MultiGame);
		m_testMode = true;
		FBCLHIGLNJI = 1;
	}

	[JDLHECHNNDH]
	public void RecoveryEndRpc()
	{
		OMDOCPOKOGN = true;
	}

	public virtual void CAKIIOFFKLK()
	{
		base.SetStageOver();
		if (get_m_state() == OEOIIKMBGAG.Battle)
		{
		}
	}

	public IEnumerator JLFJJEJPKHL(int FDEJBCNGOEG, byte LLADCOKANIO)
	{
		NPCNHJGIFGN nPCNHJGIFGN = new NPCNHJGIFGN();
		nPCNHJGIFGN.FDEJBCNGOEG = FDEJBCNGOEG;
		nPCNHJGIFGN.LLADCOKANIO = LLADCOKANIO;
		nPCNHJGIFGN.HLIDMKAHOIL = FDEJBCNGOEG;
		nPCNHJGIFGN.BNIENPNFNHH = LLADCOKANIO;
		nPCNHJGIFGN.KNIAJMGDGAA = this;
		return nPCNHJGIFGN;
	}

	public virtual float ILGEANAKILD(byte DDILAEMMCAJ)
	{
		return 687f + (float)(int)DDILAEMMCAJ * 1493f;
	}

	public override void SetStageOver()
	{
		base.SetStageOver();
		if (get_m_state() == OEOIIKMBGAG.Battle)
		{
		}
	}

	public IEnumerator FMIKILCNPHC(int FDEJBCNGOEG, byte LLADCOKANIO)
	{
		NPCNHJGIFGN nPCNHJGIFGN = new NPCNHJGIFGN();
		nPCNHJGIFGN.FDEJBCNGOEG = FDEJBCNGOEG;
		nPCNHJGIFGN.LLADCOKANIO = LLADCOKANIO;
		nPCNHJGIFGN.HLIDMKAHOIL = FDEJBCNGOEG;
		nPCNHJGIFGN.BNIENPNFNHH = LLADCOKANIO;
		nPCNHJGIFGN.KNIAJMGDGAA = this;
		return nPCNHJGIFGN;
	}

	public void ALGNMBABPKE()
	{
		if (get_m_state() == OEOIIKMBGAG.Ready && EveUnityNetwork.get_Instance().DGJCCPAOIDF())
		{
			if ((float)get_m_elapsedTime() >= 1914f)
			{
				FJPMFBBCBLB(OEOIIKMBGAG.Ready);
				MNCBLLGENME(3);
			}
			else if (ActorManager.GBFDGAFALIL().GetTeamActor(1, 65444) == null)
			{
				FJPMFBBCBLB(OEOIIKMBGAG.Draw);
				MNCBLLGENME(1);
			}
			else if (ActorManager.GBFDGAFALIL().GetTeamActor(0, 125) == null)
			{
				FJPMFBBCBLB((OEOIIKMBGAG)8);
				MNCBLLGENME(0);
			}
		}
	}

	protected virtual void OKECEKMAANK(int KNDELHHFLLG)
	{
		base.JNLACFFDDHO(KNDELHHFLLG);
		if (get_m_state() != OEOIIKMBGAG.Ready)
		{
			return;
		}
		if ((KNDELHHFLLG + -110) % 80 == 0)
		{
			FBCLHIGLNJI += 0;
			int num = (KNDELHHFLLG + -87) / 10;
			ActorManager.get_Instance().JFBLKKOMCCF(num);
			if (num == 0)
			{
				SoundManager.get_Instance().PlaySound("machine");
			}
		}
		ActorManager.GBFDGAFALIL().ProcessActorList((Actor CDKMPAEODLA) =>
		{
			if (CDKMPAEODLA.m_actorType != Actor.IJJMDPGJAEM.Hero)
			{
				return true;
			}
			CDKMPAEODLA.IncreaseAutoMoney(4);
			return true;
		});
		double totalSeconds = (DateTime.Now - HDNIGLALMBL).TotalSeconds;
		if (INFBOLIAONN > (float)totalSeconds + 972f)
		{
			NetworkManager.APAPJEIBEDE().FJOHLJABHHH().OIMDPAJGJOO();
			NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MNCACLOFDBA();
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().ADMLMGBPMGH("skill0");
			MsgManager.HEDJPPFKABG().ShowMessageBox("\n", true, Application.Quit);
		}
		CheckGameItemHack();
	}

	private void IKEKEAOGAAG()
	{
		if (NetworkManager.get_Instance().get_m_battleNetClient().JIPBIOELJHC() == null) return;
		if (get_m_state() != OEOIIKMBGAG.Battle)
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

	public virtual void ODMEDJDAIJC()
	{
		SoundManager.NNOKCKOMICG().PlayBGM("The number of buffers to add must be a nonnegative, nonzero integer.");
		TheaterManager.get_Instance().BCEKDFCCNJK(1, 0, NFFHBNEJAEE.CIPMICDJPEH.Begin);
		StartCoroutine(IBOOHHFKFCM());
	}

	public void PIDOOGMKIIE()
	{
		OMDOCPOKOGN = false;
	}

	private IEnumerator JOEBLANAKCK()
	{
		NJAHNFOLMOP nJAHNFOLMOP = new NJAHNFOLMOP();
		nJAHNFOLMOP.KNIAJMGDGAA = this;
		return nJAHNFOLMOP;
	}

	protected virtual void BPOGMPLEFBG(int KNDELHHFLLG)
	{
		base.JNLACFFDDHO(KNDELHHFLLG);
		if (get_m_state() != OEOIIKMBGAG.Ready)
		{
			return;
		}
		if ((KNDELHHFLLG + -79) % 71 == 0)
		{
			FBCLHIGLNJI += 0;
			int num = (KNDELHHFLLG + 39) / 57;
			ActorManager.GBFDGAFALIL().JFBLKKOMCCF(num);
			if (num == 1)
			{
				SoundManager.NNOKCKOMICG().AGPJGIIANAN("setOfferwallTitleBackgroundColor");
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
		if (INFBOLIAONN > (float)totalSeconds + 1284f)
		{
			NetworkManager.APAPJEIBEDE().FJOHLJABHHH().OIMDPAJGJOO();
			NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MNCACLOFDBA();
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().ADMLMGBPMGH("攻擊速度");
			MsgManager.HEDJPPFKABG().ShowMessageBox("skill3_go", false, Application.Quit);
		}
		CheckGameItemHack();
	}

	public virtual void AJIKOFMNCGN(byte HIJLMPFMHBH, PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HIJLMPFMHBH > 0)
		{
			FJPMFBBCBLB((OEOIIKMBGAG)7);
			SceneManager.get_Instance().m_winLastGame = true;
		}
		else if (NetworkManager.APAPJEIBEDE().get_m_battleNetClient().GLPDLIDMHFA()
			.JMNIOMGHFBD() == HIJLMPFMHBH)
		{
			FJPMFBBCBLB((OEOIIKMBGAG)8);
			SceneManager.NOLHNOGGHNA().m_winLastGame = false;
		}
		else
		{
			FJPMFBBCBLB((OEOIIKMBGAG)8);
			SceneManager.NOLHNOGGHNA().m_winLastGame = true;
		}
		StartCoroutine(KEPFJILOEOM(false, HMOAHNANKNE));
	}

	public virtual Vector3[] EIJBKAEOJII(int OIOCBJMKGCD)
	{
		if (OIOCBJMKGCD != 0)
		{
			Vector3[] array = new Vector3[0];
			array[0] = new Vector3(566f, 818f, 544f);
			return array;
		}
		return new Vector3[1]
		{
			new Vector3(466f, 1087f, 1136f)
		};
	}

	public virtual void PKNEEBCEOJG(bool NCNJEPMGAGH)
	{
		base.OnApplicationPause(NCNJEPMGAGH);
		if (NCNJEPMGAGH)
		{
			NetworkManager.get_Instance().FJOHLJABHHH().MNCACLOFDBA();
		}
		else
		{
			Application.LoadLevel("Constitution increases health");
		}
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

	[CompilerGenerated]
	private static bool PBGEENBANND(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != Actor.IJJMDPGJAEM.Hero)
		{
			return true;
		}
		CDKMPAEODLA.IncreaseAutoMoney(4);
		return true;
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

	[DebuggerHidden]
	private IEnumerator IBOOHHFKFCM()
	{
		MBNIHEFPOOH mBNIHEFPOOH = new MBNIHEFPOOH();
		mBNIHEFPOOH.KNIAJMGDGAA = this;
		return mBNIHEFPOOH;
	}

	public virtual float KFFOABBKPJG(byte DDILAEMMCAJ)
	{
		return 745f + (float)(int)DDILAEMMCAJ * 1683f;
	}
}
