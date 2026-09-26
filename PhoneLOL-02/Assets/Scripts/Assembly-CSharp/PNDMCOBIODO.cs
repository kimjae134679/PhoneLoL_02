using System;
using System.Net;
using System.Runtime.CompilerServices;
using BattleServer;
using EveEngine;
using UnityEngine;

public class PNDMCOBIODO : EKACODPEIIO
{
	public enum OEOIIKMBGAG
	{
		ERROR = -1,
		WAIT = 0,
		CONNECTING = 1,
		GETINFO = 2,
		COMPLETE = 3
	}

	public enum HGMJFFOIICM
	{
		QUICK_MATCH = 0,
		PASSIVE_CREATE_ROOM = 1,
		INVITE_ENTER_ROOM = 2,
		FRIENDSHIP_CREATE_ROOM = 3
	}

	private bool BPGJMMCMFHD;

	private KPDFMPKNAPI MOCAOKBGPPI;

	private bool HHEGKOBEILC;

	public bool BJCJNMOKGLJ;

	private bool KDJAGLDNOOH = true;

	public bool PBEHBBJECAB;

	private DateTime PBMIEAAEDGB = DateTime.Now;

	public bool MKJCMHPMECO;

	public bool EMOCPLIJIEK;

	public bool DAPNLCKJDPB;

	public int OMNNOMFCOEM;

	public int FECKDFFPCDE;

	public byte EHCPMLKEBME;

	public HGMJFFOIICM CDHKLJKKLFC;

	public int GGCAKMBKKAL;

	public IPEndPoint CGLHIOBLJJG;

	public byte CMBNDOKDBEH;

	public bool IDJDLMOGDMN;

	public IPEndPoint KCIEMNKINII;

	private OEOIIKMBGAG BBEEPJNEHBI;

	private PBOOPPEPAIK CFPANPNKOPM;

	private GLAMMOFPCHP IGGBGLPOMAA;

	private int NEDJIAIPBBL;

	[CompilerGenerated]
	private static UIMessageBox.NICHPBLEBEI FCEPMOHHFPO;

	public OEOIIKMBGAG GFKDNKFPPAM
	{
		get
		{
			return OOHFDEPKKFN();
		}
		protected set
		{
			FJPMFBBCBLB(value);
		}
	}

	public PBOOPPEPAIK FGADIHIAJIH
	{
		get
		{
			return GLPDLIDMHFA();
		}
		protected set
		{
			PCCKECEKJMC(value);
		}
	}

	public GLAMMOFPCHP KLDEHFCIMDN
	{
		get
		{
			return IMKOGBNIJBO();
		}
		protected set
		{
			DJLGMHMNADE(value);
		}
	}

	public int CILIBJMDKPP
	{
		get
		{
			return AOLAAHCICIA();
		}
		protected set
		{
			LNBBFAONDDL(value);
		}
	}

	public void MEFOOGMOJKD(byte HCDOLDFHKKB)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(15);
		cMNIABEFLBJ.GBMJNFOEACC(HCDOLDFHKKB);
		FBAFKOCPFPG(cMNIABEFLBJ);
	}

	public void GKNADKPJFHO(int ODPCCOLDAJC)
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(11);
		cMNIABEFLBJ.GBMJNFOEACC(ODPCCOLDAJC);
		FBAFKOCPFPG(cMNIABEFLBJ);
	}

	public void GEHALJAKDFO(int CMBJDEOAJPD)
	{
		PhoneLOLMultiplayerBridge.BeginLoad(this, CMBJDEOAJPD);
	}

	public void MLGEHIDCKIA()
	{
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(10);
		FBAFKOCPFPG(cMNIABEFLBJ);
	}

	[CompilerGenerated]
	private static void OFAPDDNJFPG()
	{
	}

	public void HNAHMNAPEGB()
	{
		FJPMFBBCBLB(OEOIIKMBGAG.CONNECTING);
		IOMHAEMKIHM(KCIEMNKINII);
	}

	public void ONLKEFOOKML(int IAEFPLFFKHC, long FGBKCJDHNID)
	{
		FJPMFBBCBLB(OEOIIKMBGAG.GETINFO);
		PBEHBBJECAB = false;
		LNBBFAONDDL(-1);
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(1);
		cMNIABEFLBJ.GBMJNFOEACC(79);
		cMNIABEFLBJ.GBMJNFOEACC(IAEFPLFFKHC);
		cMNIABEFLBJ.GBMJNFOEACC(FGBKCJDHNID);
		cMNIABEFLBJ.GBMJNFOEACC(NetworkManager.get_Instance().get_m_communityNetClient().EHDEFAIBNCN()
			.OHGOBGOIECH);
			cMNIABEFLBJ.GBMJNFOEACC(OMNNOMFCOEM);
			cMNIABEFLBJ.GBMJNFOEACC(FECKDFFPCDE);
			cMNIABEFLBJ.GBMJNFOEACC(SystemInfo.deviceUniqueIdentifier);
			FBAFKOCPFPG(cMNIABEFLBJ);
		}

		public void OIMDPAJGJOO()
		{
			KDJAGLDNOOH = false;
			IDJDLMOGDMN = true;
		}

		private void FIDLFFHBHIK(PJEMPFEIOAK HMOAHNANKNE)
		{
			IMKOGBNIJBO().AJJGLNHAPPF((OCPEALOGAIP.OEOIIKMBGAG)7);
		}

		private void PHLKALHMHHG(PJEMPFEIOAK HMOAHNANKNE)
		{
			uint iAEFPLFFKHC = HMOAHNANKNE.BMKOKHGAHEC();
			ushort num = HMOAHNANKNE.AJPFAAFLHEB();
			byte b = HMOAHNANKNE.KFAGPDGHEBK();
			NOBFFGBGCNA nOBFFGBGCNA = IMKOGBNIJBO().FBNKGOOJPBB(iAEFPLFFKHC);
			if (nOBFFGBGCNA != null && !nOBFFGBGCNA.MNHIDGANMFO())
			{
				nOBFFGBGCNA.FPFIIDFCLOL = num;
				nOBFFGBGCNA.AJLAMLFLJAO = b;
				nOBFFGBGCNA.CJENLAELLAO().AMKAFEJHILD(num);
				nOBFFGBGCNA.CJENLAELLAO().DHGDPAGDFIK(b);
				UIRoot.Broadcast("Refresh");
			}
		}

		public void HHGEILEHNHO(byte CNCAAJCKNKB)
		{
			DAPNLCKJDPB = false;
			CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
			cMNIABEFLBJ.DGFDHOLDCDL(4);
			cMNIABEFLBJ.GBMJNFOEACC(EHCPMLKEBME);
			cMNIABEFLBJ.GBMJNFOEACC(CNCAAJCKNKB);
			FBAFKOCPFPG(cMNIABEFLBJ);
			V096OriginalDiagnostics.ShareReport();
			V096OriginalDiagnostics.QueueAutomaticReportImmediate("대전상대를 찾는 중 (매칭)");
		}

		private void LDHPMPJMFBJ(PJEMPFEIOAK HMOAHNANKNE)
		{
			if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
			{
				byte oIOCBJMKGCD = HMOAHNANKNE.KFAGPDGHEBK();
				GLPDLIDMHFA().IMGGPGFOCFM(oIOCBJMKGCD);
				byte lLADCOKANIO = HMOAHNANKNE.KFAGPDGHEBK();
				GLPDLIDMHFA().ABNABOGNJPI(lLADCOKANIO);
				HMOAHNANKNE.CAHACMKBJMI(IMKOGBNIJBO());
				if (IMKOGBNIJBO().EHCPMLKEBME == 20)
				{
					SceneManager.get_Instance().ChangeScene(SceneManager.HNPEHFEAODI.MtmGame);
				}
				else
				{
					SceneManager.get_Instance().ChangeScene(SceneManager.HNPEHFEAODI.MultiGame);
				}
			}
		}

		private void BOOGAECEOHJ(PJEMPFEIOAK HMOAHNANKNE)
		{
		}

		public void MJPDBPDNIFC(byte CMGMOJAFLFL)
		{
			GLPDLIDMHFA().KPEICIEOIMF(CMGMOJAFLFL);
			UIRoot.Broadcast("Refresh");
			CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
			cMNIABEFLBJ.DGFDHOLDCDL(14);
			cMNIABEFLBJ.GBMJNFOEACC(CMGMOJAFLFL);
			FBAFKOCPFPG(cMNIABEFLBJ);
		}

        private void OnManagedDeparture(PJEMPFEIOAK packet)
        {
            uint device = packet.BMKOKHGAHEC();
            byte slot = packet.KFAGPDGHEBK();
            int masterSession = packet.PNBKOPGIHDI();
            var room = IMKOGBNIJBO();
            if (room == null || slot >= room.FMCMCKANEBC().Count) return;
            var member = room.FMCMCKANEBC()[slot];
            if (member.GBGKGJKBPHM != device) return;
            member.MarkDisconnected();
            var actor = member.ENLKLHEMPHA();
            if (actor != null && actor.get_m_view() != null) actor.get_m_view().set_isSceneObject(true);
            var group = EveUnityNetwork.get_Instance().GetDefaultGroup();
            if (group != null && masterSession > 0) group.LNOAKEKHCGF(masterSession);
            PhoneLOLRealtimeLog.Record("PLAYER_LEFT", "device=" + device + " slot=" + slot + " master=" + masterSession);
            UIRoot.Broadcast("Refresh");
        }
		private void BAKOMJJIHMK(PJEMPFEIOAK HMOAHNANKNE)
        {
            if (HMOAHNANKNE.FFINCCFLMEL() < 25 || HMOAHNANKNE.EIMBOIKCJPE()[16] > 2) {
                PhoneLOLRuntimeServices.CriticalError("서버가 전투 결과를 승인하지 못했습니다. 무승부로 처리하지 않습니다. [RESULT_REJECTED]");
                return;
            }
			byte hIJLMPFMHBH = HMOAHNANKNE.KFAGPDGHEBK();
			HMOAHNANKNE.KDOJNBAJJEO(16);
			if (GameManager.get_Instance() != null)
			{
				GameManager.get_Instance().SetResult(hIJLMPFMHBH, HMOAHNANKNE);
			}
		}

		public void KLGLGPDBODG(int ODPCCOLDAJC, byte OIOCBJMKGCD)
		{
			DAPNLCKJDPB = false;
			CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
			cMNIABEFLBJ.DGFDHOLDCDL(8);
			cMNIABEFLBJ.GBMJNFOEACC(ODPCCOLDAJC);
			cMNIABEFLBJ.GBMJNFOEACC(OIOCBJMKGCD);
			FBAFKOCPFPG(cMNIABEFLBJ);
			V096OriginalDiagnostics.ShareReport();
			V096OriginalDiagnostics.QueueAutomaticReportImmediate("대전상대를 찾는 중 (매칭)");
		}

		public void DDHEDOLCFHN(ushort FMADHAHOIDJ)
		{
			CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
			cMNIABEFLBJ.DGFDHOLDCDL(12);
			cMNIABEFLBJ.GBMJNFOEACC(FMADHAHOIDJ);
			FBAFKOCPFPG(cMNIABEFLBJ);
			if (GLPDLIDMHFA() != null)
			{
				GLPDLIDMHFA().AMKAFEJHILD(FMADHAHOIDJ);
				GLPDLIDMHFA().DHGDPAGDFIK(0);
				UIRoot.Broadcast("Refresh");
			}
		}

		public void DDOIBLFBGNG(byte GBOELKENGEK)
		{
			DAPNLCKJDPB = true;
			CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
			cMNIABEFLBJ.DGFDHOLDCDL(5);
			cMNIABEFLBJ.GBMJNFOEACC(GBOELKENGEK);
			FBAFKOCPFPG(cMNIABEFLBJ);
		}

		protected void DJLGMHMNADE(GLAMMOFPCHP ICENKPDOHBK)
		{
			IGGBGLPOMAA = ICENKPDOHBK;
		}

		public override void DPILNPAPPKI(float DMLKFKGBHKJ)
		{
			MOCAOKBGPPI.LPBLGFCPADD();
			if (NHKIEEJHEJH() && OOHFDEPKKFN() == OEOIIKMBGAG.COMPLETE)
			{
				DateTime now = DateTime.Now;
				if ((now - PBMIEAAEDGB).TotalSeconds >= 5.0)
				{
					IACGLKCILJD();
					PBMIEAAEDGB = now;
				}
			}
		}

		public int AOLAAHCICIA()
		{
			return NEDJIAIPBBL;
		}

		public PBOOPPEPAIK GLPDLIDMHFA()
		{
			return CFPANPNKOPM;
		}

		private void JEFGNINDBAA(PJEMPFEIOAK HMOAHNANKNE)
		{
			if (HMOAHNANKNE.JCGKFEPEJPO())
			{
				KDJAGLDNOOH = false;
				IDJDLMOGDMN = true;
				MsgManager.get_Instance().ShowMessageBox("해킹이 감지되었습니다 [BS1]\n불법프로그램은 사용하지 말아주세요.\n불법프로그램 사용자는 영구블럭될 수 있습니다\n\n게임을 종료합니다.", false, Application.Quit);
				MNCACLOFDBA();
			}
		}

		private void AGJFFLMLOKD(PJEMPFEIOAK HMOAHNANKNE)
		{
			byte hIJLMPFMHBH = HMOAHNANKNE.KFAGPDGHEBK();
			HMOAHNANKNE.KDOJNBAJJEO(-101);
			if (GameManager.get_Instance() != null)
			{
				GameManager.get_Instance().SetResult(hIJLMPFMHBH, HMOAHNANKNE);
			}
		}

		public void IOMHAEMKIHM()
		{
			FJPMFBBCBLB(OEOIIKMBGAG.CONNECTING);
			IOMHAEMKIHM(KCIEMNKINII);
		}

		public void FJENHFDAPGG(int CMBJDEOAJPD)
		{
			CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
			cMNIABEFLBJ.DGFDHOLDCDL(65489);
			cMNIABEFLBJ.GBMJNFOEACC(CMBJDEOAJPD);
			FBAFKOCPFPG(cMNIABEFLBJ);
		}

		public void AKEINGFKEEM(uint MNOGGLAOGBN)
		{
			CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
			cMNIABEFLBJ.DGFDHOLDCDL(23);
			cMNIABEFLBJ.GBMJNFOEACC(MNOGGLAOGBN);
			FBAFKOCPFPG(cMNIABEFLBJ);
		}

		private void KNDGHIIILKE(PJEMPFEIOAK HMOAHNANKNE)
		{
			IMKOGBNIJBO().AJJGLNHAPPF(OCPEALOGAIP.OEOIIKMBGAG.CountDown);
		}

		public override void CPILEHGNHGE()
		{
			ONLKEFOOKML(NetworkManager.get_Instance().get_m_userIndex(), NetworkManager.get_Instance().get_m_authCode());
		}

		private void BBPHOHDBENN(PJEMPFEIOAK HMOAHNANKNE)
		{
			PBOOPPEPAIK pBOOPPEPAIK = new PBOOPPEPAIK();
			HMOAHNANKNE.ILFEGIPCAHH(pBOOPPEPAIK);
			IMKOGBNIJBO().FLAEICDGBHO(pBOOPPEPAIK.EFCGKLJJLBC(), pBOOPPEPAIK);
			HMOAHNANKNE.CAHACMKBJMI(IMKOGBNIJBO().HOHGPCPICII(pBOOPPEPAIK.EFCGKLJJLBC()).EAABMAPNFMN());
			IMKOGBNIJBO().HOHGPCPICII(pBOOPPEPAIK.EFCGKLJJLBC()).IJOPKHDANIO = HMOAHNANKNE.PNBKOPGIHDI();
			if (GameManager.get_Instance() != null)
			{
				SoundManager.GDMJIJCBOLE().PlaySound("skill0_voice");
			}
			UIRoot.CHLLIEHMINE("skill0_missile_go");
		}

		private void HBMMIIBAKGO(PJEMPFEIOAK HMOAHNANKNE)
		{
			V093CompatibilityFix.ReceiveRoleOrTeamMove(this, HMOAHNANKNE);
		}

		public void NELLNJJNBDO(CMNIABEFLBJ LCNMDBEHKIP)
		{
			FBAFKOCPFPG(LCNMDBEHKIP);
		}

		public void OOOFLNNNKHO()
		{
		}

		public bool GBBHELGEFFN()
		{
			if (!NHKIEEJHEJH())
			{
				return false;
			}
			if (OOHFDEPKKFN() == OEOIIKMBGAG.COMPLETE)
			{
				return true;
			}
			return false;
		}

		private void LPGDFOOPLEP(PJEMPFEIOAK HMOAHNANKNE)
		{
			uint iAEFPLFFKHC = HMOAHNANKNE.BMKOKHGAHEC();
			int cMBJDEOAJPD = HMOAHNANKNE.PNBKOPGIHDI();
			IMKOGBNIJBO().LFGEKLEKDKJ(iAEFPLFFKHC, cMBJDEOAJPD);
		}

		public OEOIIKMBGAG OOHFDEPKKFN()
		{
			return BBEEPJNEHBI;
		}

		private void EMJHFAMDOGC(PJEMPFEIOAK HMOAHNANKNE)
		{
			HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
			uint num = HMOAHNANKNE.BMKOKHGAHEC();
			bool flag = HMOAHNANKNE.JCGKFEPEJPO();
			switch (hGBGJMIFCEP)
			{
			case HGBGJMIFCEP.Success:
			{
				if (num == GLPDLIDMHFA().OHGOBGOIECH)
				{
					LobbyMain.get_Instance().PopPanelState();
					break;
				}
				byte bEPBPAPIEHE = HMOAHNANKNE.KFAGPDGHEBK();
				HMOAHNANKNE.CAHACMKBJMI(IMKOGBNIJBO());
				NOBFFGBGCNA nOBFFGBGCNA = IMKOGBNIJBO().FBNKGOOJPBB(bEPBPAPIEHE);
				if (nOBFFGBGCNA != null && nOBFFGBGCNA.ENLKLHEMPHA() != null)
				{
					nOBFFGBGCNA.ENLKLHEMPHA().get_m_view().set_isSceneObject(true);
					Actor actor = nOBFFGBGCNA.ENLKLHEMPHA();
					Actor.NDCNGDGAAIN lastAttacker = actor.GetLastAttacker();
					if (lastAttacker != null && lastAttacker.IEHGFJKIDHI(10f))
					{
						actor.OnDamage(lastAttacker.MEDAGKOPJMO, 100000.0, 100000.0, 100000.0, 3);
					}
				}
				if (GameManager.get_Instance() != null)
				{
					SoundManager.get_Instance().PlaySound("DisconnectUser");
				}
				UIRoot.Broadcast("Refresh");
				break;
			}
			}
		}

		protected void LNBBFAONDDL(int ICENKPDOHBK)
		{
			NEDJIAIPBBL = ICENKPDOHBK;
		}

		private void DNPHNCNMDGH(PJEMPFEIOAK HMOAHNANKNE)
		{
			V096OriginalDiagnostics.Write("Lobby");
			V096OriginalDiagnostics.QueueAutomaticReportImmediate("Lobby");
			if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
			{
				byte oIOCBJMKGCD = HMOAHNANKNE.KFAGPDGHEBK();
				GLPDLIDMHFA().IMGGPGFOCFM(oIOCBJMKGCD);
				byte lLADCOKANIO = HMOAHNANKNE.KFAGPDGHEBK();
				GLPDLIDMHFA().ABNABOGNJPI(lLADCOKANIO);
				HMOAHNANKNE.CAHACMKBJMI(IMKOGBNIJBO());
				LobbyMain.get_Instance().HideQuickSearch();
				LobbyMain.get_Instance().ShowBattleReadyPanel();
				UIRoot.Broadcast("Refresh");
			}
			else
			{
				DAPNLCKJDPB = true;
				UIRoot.Broadcast("OnFailToEnterRoom");
			}
		}

		private void NIACCHEMOMH(PJEMPFEIOAK HMOAHNANKNE)
		{
			uint iAEFPLFFKHC = HMOAHNANKNE.BMKOKHGAHEC();
			NOBFFGBGCNA nOBFFGBGCNA = IMKOGBNIJBO().FBNKGOOJPBB(iAEFPLFFKHC);
			if (nOBFFGBGCNA != null && !nOBFFGBGCNA.MNHIDGANMFO())
			{
				nOBFFGBGCNA.CJENLAELLAO().DFMPKCNABDJ(true);
				UIRoot.Broadcast("Refresh");
			}
		}

		public void KHFONJGOBEB(byte FCBHKNNLDLK)
		{
			CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
			cMNIABEFLBJ.DGFDHOLDCDL(13);
			cMNIABEFLBJ.GBMJNFOEACC(FCBHKNNLDLK);
			FBAFKOCPFPG(cMNIABEFLBJ);
		}

		private void BABAPIJOIMD(PJEMPFEIOAK HMOAHNANKNE)
		{
			PBOOPPEPAIK pBOOPPEPAIK = new PBOOPPEPAIK();
			HMOAHNANKNE.CAHACMKBJMI(pBOOPPEPAIK);
			IMKOGBNIJBO().KHGJNNIEADN(pBOOPPEPAIK.GDMBDKBCNBD(), pBOOPPEPAIK);
			HMOAHNANKNE.CAHACMKBJMI(IMKOGBNIJBO().FBNKGOOJPBB(pBOOPPEPAIK.GDMBDKBCNBD()).IDPBOIOHIDJ());
			IMKOGBNIJBO().FBNKGOOJPBB(pBOOPPEPAIK.GDMBDKBCNBD()).IJOPKHDANIO = HMOAHNANKNE.PNBKOPGIHDI();
			if (GameManager.get_Instance() != null)
			{
				SoundManager.get_Instance().PlaySound("ReconnectUser");
			}
			UIRoot.Broadcast("Refresh");
		}

		protected void PCCKECEKJMC(PBOOPPEPAIK ICENKPDOHBK)
		{
			CFPANPNKOPM = ICENKPDOHBK;
		}

		public bool LAOADHLLFAK()
		{
			if (IMKOGBNIJBO() == null || GLPDLIDMHFA() == null)
			{
				return false;
			}
			return IMKOGBNIJBO().JFADMKIAJBM(GLPDLIDMHFA().OHGOBGOIECH);
		}

		protected void FJPMFBBCBLB(OEOIIKMBGAG ICENKPDOHBK)
		{
			BBEEPJNEHBI = ICENKPDOHBK;
		}

		private void DMNLNENDAII(Exception PAANPLECGAP)
		{
		}

		public void IACGLKCILJD()
		{
			CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
			if (cMNIABEFLBJ == null)
			{
				return;
			}
			cMNIABEFLBJ.DGFDHOLDCDL(3);
			sbyte iCENKPDOHBK = 0;
			GameManager instance = GameManager.get_Instance();
			if (instance != null && instance.get_m_state() == GameManager.OEOIIKMBGAG.Battle && !((float)instance.get_m_elapsedTime() < 5f))
			{
				KJGALEFHHOA kJGALEFHHOA = JIPBIOELJHC();
				if (kJGALEFHHOA != null)
				{
					int num = (int)(kJGALEFHHOA.EJNOJPCPLEB() * 1000f);
					iCENKPDOHBK = (sbyte)((instance.get_Fps() >= 55 && num <= 60) ? 4 : ((instance.get_Fps() >= 50 && num <= 80) ? 3 : ((instance.get_Fps() >= 40 && num <= 100) ? 2 : ((instance.get_Fps() >= 30 && num <= 120) ? 1 : 0))));
				}
			}
			cMNIABEFLBJ.GBMJNFOEACC(iCENKPDOHBK);
			ActorManager instance2 = ActorManager.get_Instance();
			Actor controlActor = default(Actor);
			if ((object)instance2 != null)
			{
				controlActor = instance2.GetControlActor();
			}
			if (instance != null && instance.get_m_state() == GameManager.OEOIIKMBGAG.Battle && controlActor != null)
			{
				cMNIABEFLBJ.GBMJNFOEACC(true);
				cMNIABEFLBJ.GBMJNFOEACC(controlActor.get_m_autoMoney());
			}
			else
			{
				cMNIABEFLBJ.GBMJNFOEACC(false);
			}
			cMNIABEFLBJ.GBMJNFOEACC(iCENKPDOHBK);
			cMNIABEFLBJ.GBMJNFOEACC(false);
			FBAFKOCPFPG(cMNIABEFLBJ);
		}

		public GLAMMOFPCHP IMKOGBNIJBO()
		{
			return IGGBGLPOMAA;
		}

		public virtual void IEKBCFJBABI()
		{
			ONLKEFOOKML(NetworkManager.get_Instance().MAOBBILCJHC(), NetworkManager.APAPJEIBEDE().get_m_authCode());
		}

		public void CNHPIJKKCDI(byte GBOELKENGEK)
		{
			DAPNLCKJDPB = false;
			CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
			cMNIABEFLBJ.DGFDHOLDCDL(5);
			cMNIABEFLBJ.GBMJNFOEACC(GBOELKENGEK);
			FBAFKOCPFPG(cMNIABEFLBJ);
		}

		public void DFPELPCDPGK()
		{
			CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
			cMNIABEFLBJ.DGFDHOLDCDL(16);
			FBAFKOCPFPG(cMNIABEFLBJ);
		}

		private void HHAFFCNECJI(PJEMPFEIOAK HMOAHNANKNE)
		{
			if (IMKOGBNIJBO() != null)
			{
				IMKOGBNIJBO().CEIBEFFEKEM(HMOAHNANKNE.JCGKFEPEJPO());
				UIRoot.CHLLIEHMINE("상급 성장 마나 인장");
			}
		}

		private void KGFHHIFGLCH(PJEMPFEIOAK HMOAHNANKNE)
		{
			HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
			switch (hGBGJMIFCEP)
			{
			case HGBGJMIFCEP.Success:
				HMOAHNANKNE.CAHACMKBJMI(GLPDLIDMHFA());
                SetBattleSession(GLPDLIDMHFA().NCHJJNGPOPA());
				LNBBFAONDDL(HMOAHNANKNE.PNBKOPGIHDI());
				FJPMFBBCBLB(OEOIIKMBGAG.COMPLETE);
				break;
			case HGBGJMIFCEP.InvalidProtocolVersion:
				MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("[VNET ] 버전 오류\n게임 인증 응답 경로          "));
				break;
			case HGBGJMIFCEP.InvalidUserID:
				MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("정상적이지 않은 아이디입니다."));
				break;
			case HGBGJMIFCEP.AlreadyConnect:
				PBEHBBJECAB = true;
				if (Application.loadedLevelName == "Login")
				{
					MsgManager.get_Instance().ShowMessageBox("이미 접속중입니다.\n\n기존 접속을 끊거나\n잠시후에 다시 시도해 주세요.");
				}
				break;
			case HGBGJMIFCEP.BlockUser:
				MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("이 계정은 정지되었습니다."), false, Application.Quit);
				break;
			case HGBGJMIFCEP.MaxCount:
				MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("최대 접속자를 초과하였습니다.\n\n나중에 접속을 시도해 주세요."));
				break;
			default:
				MsgManager.get_Instance().ShowMessageBox(string.Format("알 수 없는 오류가 발생했습니다 {0}", (int)hGBGJMIFCEP));
				break;
			}
			if (hGBGJMIFCEP != HGBGJMIFCEP.Success)
			{
				FJPMFBBCBLB(OEOIIKMBGAG.ERROR);
			}
		}

		public void IOCKJFGFGFD()
		{
			CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
			cMNIABEFLBJ.DGFDHOLDCDL(6);
			FBAFKOCPFPG(cMNIABEFLBJ);
		}

		private void DLLOHDDNHOH(PJEMPFEIOAK HMOAHNANKNE)
		{
			uint iAEFPLFFKHC = HMOAHNANKNE.BMKOKHGAHEC();
			NOBFFGBGCNA nOBFFGBGCNA = IMKOGBNIJBO().FBNKGOOJPBB(iAEFPLFFKHC);
			if (nOBFFGBGCNA != null && !nOBFFGBGCNA.MNHIDGANMFO())
			{
				HMOAHNANKNE.CAHACMKBJMI(nOBFFGBGCNA.IDPBOIOHIDJ());
				nOBFFGBGCNA.IJOPKHDANIO = HMOAHNANKNE.PNBKOPGIHDI();
			}
		}

		private void KAHCHIJOFBG(PJEMPFEIOAK HMOAHNANKNE)
		{
			V096OriginalDiagnostics.Write("BATTLE_PID20_RX|START_READY_OK");
			bool flag = HMOAHNANKNE.JCGKFEPEJPO();
			IMKOGBNIJBO().DCHDPGPBJGC = HMOAHNANKNE.ODFEGIDCMPH();
			if (flag)
			{
				MKJCMHPMECO = false;
			}
			else
			{
				MKJCMHPMECO = true;
			}
			EMOCPLIJIEK = true;
			if (flag && IMKOGBNIJBO().DCHDPGPBJGC != 0)
			{
				EveUnityNetwork.get_Instance().IsLocalMode = false;
			}
			PhoneLOLMultiplayerBridge.OnStart(this);
		}

		public PNDMCOBIODO()
		{
			FJPMFBBCBLB(OEOIIKMBGAG.WAIT);
			MOCAOKBGPPI = new KPDFMPKNAPI();
			PCCKECEKJMC(new PBOOPPEPAIK());
			DJLGMHMNADE(new GLAMMOFPCHP());
			CGLHIOBLJJG = new IPEndPoint(0L, 0);
			MAJJNANHNDF = DMNLNENDAII;
			HADMKAKPDDO(1, KGFHHIFGLCH);
			HADMKAKPDDO(2, BOOGAECEOHJ);
			HADMKAKPDDO(3, JEFGNINDBAA);
			HADMKAKPDDO(7, DNPHNCNMDGH);
			HADMKAKPDDO(9, BABAPIJOIMD);
			HADMKAKPDDO(11, LDHPMPJMFBJ);
			HADMKAKPDDO(10, EMJHFAMDOGC);
			HADMKAKPDDO(6, AMHBJPOKMFI);
			HADMKAKPDDO(12, DIGOFDHOIJI);
			HADMKAKPDDO(13, PHLKALHMHHG);
			HADMKAKPDDO(14, HBMMIIBAKGO);
			HADMKAKPDDO(15, DLLOHDDNHOH);
			HADMKAKPDDO(16, NIACCHEMOMH);
			HADMKAKPDDO(17, KNDGHIIILKE);
			HADMKAKPDDO(18, NKGEGAKJHLP);
			HADMKAKPDDO(19, LPGDFOOPLEP);
			HADMKAKPDDO(20, KAHCHIJOFBG);
            HADMKAKPDDO(61002, OnManagedDeparture);
			HADMKAKPDDO(22, BAKOMJJIHMK);
            HADMKAKPDDO(24, ReceiveManagedRoomSnapshot);
			EveUnityNetwork.get_Instance().SetNetClient(this);
		}

		public void HIHDKMNFGIK()
		{
			SceneManager.get_Instance().ChangeScene(SceneManager.HNPEHFEAODI.MultiGame);
		}

		public void EOHCPBMDEOC()
		{
			CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
			cMNIABEFLBJ.DGFDHOLDCDL(21);
			FBAFKOCPFPG(cMNIABEFLBJ);
		}

		private void DIGOFDHOIJI(PJEMPFEIOAK HMOAHNANKNE)
		{
			uint num = HMOAHNANKNE.BMKOKHGAHEC();
			ushort num2 = HMOAHNANKNE.AJPFAAFLHEB();
			byte b = HMOAHNANKNE.KFAGPDGHEBK();
			NOBFFGBGCNA nOBFFGBGCNA = IMKOGBNIJBO().FBNKGOOJPBB(num);
			if (nOBFFGBGCNA != null && !nOBFFGBGCNA.MNHIDGANMFO())
			{
				nOBFFGBGCNA.FPFIIDFCLOL = num2;
				nOBFFGBGCNA.AJLAMLFLJAO = b;
				nOBFFGBGCNA.CJENLAELLAO().AMKAFEJHILD(num2);
				nOBFFGBGCNA.CJENLAELLAO().DHGDPAGDFIK(b);
				if (num == GLPDLIDMHFA().OHGOBGOIECH)
				{
					GLPDLIDMHFA().AMKAFEJHILD(num2);
				}
				UIRoot.Broadcast("Refresh");
			}
		}

		private void NKGEGAKJHLP(PJEMPFEIOAK HMOAHNANKNE)
		{
			if (HMOAHNANKNE.JCGKFEPEJPO())
			{
				for (int i = 0; i < IMKOGBNIJBO().FMCMCKANEBC().Count; i++)
				{
					IMKOGBNIJBO().FMCMCKANEBC()[i].FPFIIDFCLOL = HMOAHNANKNE.AJPFAAFLHEB();
					IMKOGBNIJBO().FMCMCKANEBC()[i].AJLAMLFLJAO = HMOAHNANKNE.KFAGPDGHEBK();
					IMKOGBNIJBO().FMCMCKANEBC()[i].LHPLBMLPIFO = HMOAHNANKNE.PNBKOPGIHDI();
					IMKOGBNIJBO().FMCMCKANEBC()[i].ODGCBCEMAHH = HMOAHNANKNE.PNBKOPGIHDI();
				}
				MKJCMHPMECO = false;
				EMOCPLIJIEK = false;
				IMKOGBNIJBO().AJJGLNHAPPF(OCPEALOGAIP.OEOIIKMBGAG.CountDown);
				NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
					.DFMPKCNABDJ(true);
				UIRoot.Broadcast("Refresh");
				PhoneLOLMultiplayerBridge.OnRoster(this);
			}
			else
			{
				IMKOGBNIJBO().AJJGLNHAPPF(OCPEALOGAIP.OEOIIKMBGAG.Ready);
				PhoneLOLMultiplayerBridge.OnRoster(this);
			}
		}

		public override void OIHIOEMEAKF()
        {
            var game = GameManager.get_Instance();
            if (!IDJDLMOGDMN && game != null && game.get_m_state() == GameManager.OEOIIKMBGAG.Battle)
                PhoneLOLRuntimeServices.CriticalError("서버 연결이 끊겼습니다. 전투 동기화가 중단되었습니다. [BATTLE_DISCONNECTED]");
			if (OOHFDEPKKFN() == OEOIIKMBGAG.CONNECTING || OOHFDEPKKFN() == OEOIIKMBGAG.GETINFO)
			{
				FJPMFBBCBLB(OEOIIKMBGAG.ERROR);
			}
			else
			{
				FJPMFBBCBLB(OEOIIKMBGAG.WAIT);
			}
			if (GameManager.get_Instance() != null && !IDJDLMOGDMN && GameManager.get_Instance().get_m_state() != GameManager.OEOIIKMBGAG.Ready && GameManager.get_Instance().get_m_state() != GameManager.OEOIIKMBGAG.Battle)
			{
			}
		}

		private void AMHBJPOKMFI(PJEMPFEIOAK HMOAHNANKNE)
		{
			V096OriginalDiagnostics.Write("OnChangeAutoEnterRoom");
			V096OriginalDiagnostics.QueueAutomaticReportImmediate("OnChangeAutoEnterRoom");
			if (IMKOGBNIJBO() != null)
			{
				IMKOGBNIJBO().CEIBEFFEKEM(HMOAHNANKNE.JCGKFEPEJPO());
				UIRoot.Broadcast("OnChangeAutoEnterRoom");
			}
		}

		private void JFLMOBCLEIC(PJEMPFEIOAK HMOAHNANKNE)
		{
			if (HMOAHNANKNE.JCGKFEPEJPO())
			{
				for (int i = 0; i < IMKOGBNIJBO().FMCMCKANEBC().Count; i += 0)
				{
					IMKOGBNIJBO().JINMCDIFFEM()[i].FPFIIDFCLOL = HMOAHNANKNE.AJPFAAFLHEB();
					IMKOGBNIJBO().FMCMCKANEBC()[i].AJLAMLFLJAO = HMOAHNANKNE.KFAGPDGHEBK();
					IMKOGBNIJBO().FMCMCKANEBC()[i].LHPLBMLPIFO = HMOAHNANKNE.PNBKOPGIHDI();
					IMKOGBNIJBO().FMCMCKANEBC()[i].ODGCBCEMAHH = HMOAHNANKNE.PNBKOPGIHDI();
				}
				MKJCMHPMECO = true;
				EMOCPLIJIEK = true;
				IMKOGBNIJBO().AJJGLNHAPPF(OCPEALOGAIP.OEOIIKMBGAG.Result);
				if (IMKOGBNIJBO().EHCPMLKEBME == -78)
				{
					SceneManager.get_Instance().ChangeScene(SceneManager.HNPEHFEAODI.Game);
				}
				else
				{
					SceneManager.NOLHNOGGHNA().NJALEEDIHKD(SceneManager.HNPEHFEAODI.Login);
				}
			}
			else
			{
				IMKOGBNIJBO().AJJGLNHAPPF(OCPEALOGAIP.OEOIIKMBGAG.Blank);
			}
		}
		private void ReceiveManagedRoomSnapshot(PJEMPFEIOAK packet)
		{
			packet.CAHACMKBJMI(GLPDLIDMHFA());
			packet.CAHACMKBJMI(IMKOGBNIJBO());
			UIRoot.Broadcast("Refresh");
		}
}
