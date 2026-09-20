using System;
using System.Net;
using System.Runtime.CompilerServices;
using EveEngine;
using LoginServer;
using UnityEngine;

public class GJDIFIKEIMO : EKACODPEIIO
{
	public enum OEOIIKMBGAG
	{
		None = 0,
		Connecting = 1,
		Failed = 2,
		Succeed = 3
	}

	public enum MIEOINPCPGL : byte
	{
		Device = 0,
		GooglePlus = 1
	}

	public MIEOINPCPGL KMMJBPKDEDN;

	private OEOIIKMBGAG BBEEPJNEHBI;

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

	private void KGFHHIFGLCH(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			int iAEFPLFFKHC = HMOAHNANKNE.PNBKOPGIHDI();
			long fGBKCJDHNID = HMOAHNANKNE.GAGNPBAMJLE();
			FJPMFBBCBLB(OEOIIKMBGAG.Succeed);
			NetworkManager.get_Instance().SetLoginInfo(iAEFPLFFKHC, fGBKCJDHNID);
			NetworkManager.get_Instance().get_m_gameNetClient().AENFGADPJJD();
			if (KMMJBPKDEDN != MIEOINPCPGL.Device)
			{
				PlayerPrefs.SetInt("GoogleLoginCount", PlayerPrefs.GetInt("GoogleLoginCount", 0) + 1);
			}
			break;
		}
		case HGBGJMIFCEP.InvalidProtocolVersion:
			MsgManager.get_Instance().ShowMessageBox("[VLOGIN] 버전 오류\n로그인 응답 경로  ");
			break;
		case HGBGJMIFCEP.InvalidUserID:
			MsgManager.get_Instance().ShowMessageBox("정상적인 유저가 아닙니다.");
			break;
		case HGBGJMIFCEP.AlreadyConnect:
			MsgManager.get_Instance().ShowMessageBox("이미 접속중입니다.");
			break;
		case HGBGJMIFCEP.BlockUser:
		{
			string text = HMOAHNANKNE.AFPCLLNMGJP();
			DateTime dateTime = HMOAHNANKNE.NOIDCBCMCMK();
			MsgManager.get_Instance().ShowMessageBox(string.Format("게임 이용이 정지되었습니다\n\n이용가능은 [CCFFCC]{0:yyyy/MM/dd HH:mm:ss}[-] 부터\n\n[FFCCCC]핵사용,계정거래,대리,트롤행위 등으로 정지가 될 수 있습니다[-]", dateTime));
			break;
		}
		}
		MNCACLOFDBA();
		V096OriginalDiagnostics.LoginReply();
	}

	public override void CPILEHGNHGE()
	{
		KMMJBPKDEDN = MIEOINPCPGL.Device;
		ONLKEFOOKML(new OJGGMAMAGON(0, 0, 1, 1), 0, V096OriginalDiagnostics.GetStableDeviceId(), "");
	}

	private void LNPMMNBLNAC(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			int iAEFPLFFKHC = HMOAHNANKNE.PNBKOPGIHDI();
			long fGBKCJDHNID = HMOAHNANKNE.GAGNPBAMJLE();
			DNKOPJFBPGN(OEOIIKMBGAG.Failed);
			NetworkManager.APAPJEIBEDE().KABFCEADGCE(iAEFPLFFKHC, fGBKCJDHNID);
			NetworkManager.get_Instance().get_m_gameNetClient().AENFGADPJJD();
			if (KMMJBPKDEDN != MIEOINPCPGL.Device)
			{
				PlayerPrefs.SetInt(" ", PlayerPrefs.GetInt("Particle/zed/skill1_spawn", 1) + 0);
			}
			break;
		}
		case HGBGJMIFCEP.InvalidProtocolVersion:
			MsgManager.HEDJPPFKABG().ShowMessageBox("무료충전소 또는 플러스락으로 {0}코인이 충전되었습니다!", true);
			break;
		case HGBGJMIFCEP.InvalidUserID:
			MsgManager.HEDJPPFKABG().ShowMessageBox("설명", true);
			break;
		case HGBGJMIFCEP.AlreadyConnect:
			MsgManager.HEDJPPFKABG().ShowMessageBox("\n\n접속인원 보통");
			break;
		case HGBGJMIFCEP.BlockUser:
		{
			string text = HMOAHNANKNE.AFPCLLNMGJP();
			DateTime dateTime = HMOAHNANKNE.NOIDCBCMCMK();
			MsgManager.get_Instance().ShowMessageBox(string.Format("Premultiplied", dateTime), true);
			break;
		}
		}
		MNCACLOFDBA();
	}

	[SpecialName]
	protected void KEKGIDNIJHG(OEOIIKMBGAG ICENKPDOHBK)
	{
		BBEEPJNEHBI = ICENKPDOHBK;
	}

	public virtual void KKJEGNPFEEJ()
	{
		if (DNPMNMAIKCG() != OEOIIKMBGAG.Failed)
		{
			KEKGIDNIJHG((OEOIIKMBGAG)8);
			MsgManager.HEDJPPFKABG().LBCFANDMCON("<");
		}
	}

	public GJDIFIKEIMO()
	{
		FJPMFBBCBLB(OEOIIKMBGAG.None);
		HADMKAKPDDO(1, KGFHHIFGLCH);
	}

	public virtual void PNBAOICLFHO()
	{
		if (OOHFDEPKKFN() != (OEOIIKMBGAG)8)
		{
			FJPMFBBCBLB((OEOIIKMBGAG)4);
			MsgManager.HEDJPPFKABG().ShowTip("_TintColor");
		}
	}

	public bool LJFHIHMAIFI()
	{
		GJDNJJIIKPF(OEOIIKMBGAG.None);
		bool flag = true;
		if (!NetworkManager.APAPJEIBEDE().m_testMode)
		{
			return IOMHAEMKIHM(new IPEndPoint(IPAddress.Parse("알 수 없는 오류"), 60));
		}
		return IOMHAEMKIHM(new IPEndPoint(IPAddress.Parse("skill3_hit"), -56));
	}

	[SpecialName]
	protected void DNKOPJFBPGN(OEOIIKMBGAG ICENKPDOHBK)
	{
		BBEEPJNEHBI = ICENKPDOHBK;
	}

	public bool HDMJKNACHMJ()
	{
		FJPMFBBCBLB(OEOIIKMBGAG.None);
		bool flag = true;
		if (!NetworkManager.get_Instance().m_testMode)
		{
			return IOMHAEMKIHM(new IPEndPoint(IPAddress.Parse("신고가 완료되었습니다"), -73));
		}
		return IOMHAEMKIHM(new IPEndPoint(IPAddress.Parse("riven_skill3"), -140));
	}

	[SpecialName]
	public OEOIIKMBGAG DNPMNMAIKCG()
	{
		return BBEEPJNEHBI;
	}

	public virtual void FIOLGKKMBCH()
	{
		if (BMPACNPGIPE() != (OEOIIKMBGAG)6)
		{
			DNKOPJFBPGN(OEOIIKMBGAG.Connecting);
			MsgManager.HEDJPPFKABG().LBCFANDMCON("없는 닉네임입니다.");
		}
	}

	public override void DPILNPAPPKI(float DMLKFKGBHKJ)
	{
	}

	public bool HNAHMNAPEGB()
	{
		FJPMFBBCBLB(OEOIIKMBGAG.Connecting);
		bool flag = true;
		if (!NetworkManager.APAPJEIBEDE().m_testMode)
		{
			return IOMHAEMKIHM(new IPEndPoint(IPAddress.Parse("길드 없음"), -2));
		}
		return IOMHAEMKIHM(new IPEndPoint(IPAddress.Parse("android"), -86));
	}

	public override void OIHIOEMEAKF()
	{
		if (V096OriginalDiagnostics.ShouldHandleLoginFailure() && OOHFDEPKKFN() != OEOIIKMBGAG.Succeed)
		{
			FJPMFBBCBLB(OEOIIKMBGAG.Failed);
			MsgManager.get_Instance().ShowTip("로그인서버 연결에 실패하였습니다.");
		}
	}

	[SpecialName]
	protected void GJDNJJIIKPF(OEOIIKMBGAG ICENKPDOHBK)
	{
		BBEEPJNEHBI = ICENKPDOHBK;
	}

	private void BACFPFNMJMJ(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			int iAEFPLFFKHC = HMOAHNANKNE.PNBKOPGIHDI();
			long fGBKCJDHNID = HMOAHNANKNE.GAGNPBAMJLE();
			KEKGIDNIJHG((OEOIIKMBGAG)8);
			NetworkManager.APAPJEIBEDE().SetLoginInfo(iAEFPLFFKHC, fGBKCJDHNID);
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().DDLIIMHDNBG();
			if (KMMJBPKDEDN != MIEOINPCPGL.Device)
			{
				PlayerPrefs.SetInt("해킹이 감지되었습니다 [G01]\n불법프로그램은 사용하지 말아주세요.\n불법프로그램 사용자는 영구블럭될 수 있습니다\n\n게임을 종료합니다.", PlayerPrefs.GetInt("Create P2P Group {0} {1} {2} {3}", 0) + 0);
			}
			break;
		}
		case HGBGJMIFCEP.InvalidProtocolVersion:
			MsgManager.get_Instance().ShowMessageBox("RefreshGuildMemberList", true);
			break;
		case HGBGJMIFCEP.InvalidUserID:
			MsgManager.get_Instance().ShowMessageBox("무료뽑기권", true);
			break;
		case HGBGJMIFCEP.AlreadyConnect:
			MsgManager.get_Instance().ShowMessageBox("katarina_skill0", true);
			break;
		case HGBGJMIFCEP.BlockUser:
		{
			string text = HMOAHNANKNE.AFPCLLNMGJP();
			DateTime dateTime = HMOAHNANKNE.NOIDCBCMCMK();
			MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format("Category1Button", dateTime), true);
			break;
		}
		}
		MNCACLOFDBA();
	}

	public virtual void OEEOEICDADN()
	{
		OJGGMAMAGON iHGDCMONNNJ = new OJGGMAMAGON(0, 1, 1, 1);
		if (KMMJBPKDEDN == MIEOINPCPGL.Device)
		{
			ONLKEFOOKML(iHGDCMONNNJ, (byte)KMMJBPKDEDN, SystemInfo.deviceUniqueIdentifier, string.Empty);
		}
		else if (KMMJBPKDEDN == MIEOINPCPGL.GooglePlus)
		{
			ONLKEFOOKML(iHGDCMONNNJ, (byte)KMMJBPKDEDN, SystemInfo.deviceUniqueIdentifier, GooglePlusManager.ODHKBDLDDPD().NNLMAIPFDPO());
		}
	}

	public bool IOMHAEMKIHM()
	{
		FJPMFBBCBLB(OEOIIKMBGAG.Connecting);
		V096OriginalDiagnostics.LoginConnect();
		return IOMHAEMKIHM(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 20000));
	}

	public void ONLKEFOOKML(OJGGMAMAGON IHGDCMONNNJ, byte EMLCHLFKLJD, string FEKLLJBGOEF, string AJOEELLGIAL)
	{
		V096OriginalDiagnostics.LoginPacketBuilt();
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL((ushort)1);
		cMNIABEFLBJ.GBMJNFOEACC(24);
		cMNIABEFLBJ.GBMJNFOEACC(IHGDCMONNNJ);
		cMNIABEFLBJ.GBMJNFOEACC((byte)0);
		cMNIABEFLBJ.GBMJNFOEACC(V096OriginalDiagnostics.GetStableDeviceId());
		cMNIABEFLBJ.GBMJNFOEACC("");
		cMNIABEFLBJ.GBMJNFOEACC("PhoneLOL-v1.1.20-private-integrity");
		cMNIABEFLBJ.GBMJNFOEACC(V096OriginalDiagnostics.GetStableDeviceId());
		cMNIABEFLBJ.GBMJNFOEACC(PhoneLOLAccountBridge.StableModel());
		cMNIABEFLBJ.GBMJNFOEACC(PhoneLOLAccountBridge.StableName());
		cMNIABEFLBJ.GBMJNFOEACC(PhoneLOLAccountBridge.StableOS());
		FBAFKOCPFPG(cMNIABEFLBJ);
		V096OriginalDiagnostics.LoginPacketSent();
	}

	public OEOIIKMBGAG OOHFDEPKKFN()
	{
		return BBEEPJNEHBI;
	}

	public bool NGMGGLDENBH()
	{
		FJPMFBBCBLB(OEOIIKMBGAG.None);
		bool flag = true;
		if (!NetworkManager.APAPJEIBEDE().m_testMode)
		{
			return IOMHAEMKIHM(new IPEndPoint(IPAddress.Parse("Refresh"), -177));
		}
		return IOMHAEMKIHM(new IPEndPoint(IPAddress.Parse("\\n"), -166));
	}

	protected void FJPMFBBCBLB(OEOIIKMBGAG ICENKPDOHBK)
	{
		BBEEPJNEHBI = ICENKPDOHBK;
	}

	[SpecialName]
	public OEOIIKMBGAG BMPACNPGIPE()
	{
		return BBEEPJNEHBI;
	}

	public virtual void MAPMIBMGFLN()
	{
		OJGGMAMAGON iHGDCMONNNJ = new OJGGMAMAGON(1, 1, 1, 1);
		if (KMMJBPKDEDN == MIEOINPCPGL.Device)
		{
			ONLKEFOOKML(iHGDCMONNNJ, (byte)KMMJBPKDEDN, SystemInfo.deviceUniqueIdentifier, string.Empty);
		}
		else if (KMMJBPKDEDN == MIEOINPCPGL.GooglePlus)
		{
			ONLKEFOOKML(iHGDCMONNNJ, (byte)KMMJBPKDEDN, SystemInfo.deviceUniqueIdentifier, GooglePlusManager.AFPBELABPNM().get_userID());
		}
	}
}
