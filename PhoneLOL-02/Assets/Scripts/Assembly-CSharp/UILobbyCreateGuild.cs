using System.Text.RegularExpressions;
using CommunityServer;
using EveEngine;
using UnityEngine;

public class UILobbyCreateGuild : MonoBehaviour
{
	private sealed class DKIFPMFNABO
	{
		internal string FBOMDFACEDB;

		internal UILobbyCreateGuild KNIAJMGDGAA;

		internal void ILLNODKDECL()
		{
			KNIAJMGDGAA.HDAPPONCAGE(FBOMDFACEDB);
		}

		internal void PFNMIDPFCBH()
		{
			KNIAJMGDGAA.KNJBIBKDPGJ(FBOMDFACEDB);
		}

		internal void MCAKDLGBJPM()
		{
			KNIAJMGDGAA.HDAPPONCAGE(FBOMDFACEDB);
		}

		internal void DMCBDGAPMFN()
		{
			KNIAJMGDGAA.IEFHHJAJHIJ(FBOMDFACEDB);
		}

		internal void APPIHFPKADP()
		{
			KNIAJMGDGAA.HDAPPONCAGE(FBOMDFACEDB);
		}

		internal void AHNACIAGJEL()
		{
			KNIAJMGDGAA.IEFHHJAJHIJ(FBOMDFACEDB);
		}

		internal void PJNECGAMBPJ()
		{
			KNIAJMGDGAA.HDAPPONCAGE(FBOMDFACEDB);
		}

		internal void IIPNNFFCGMD()
		{
			KNIAJMGDGAA.PDEMCDENAJF(FBOMDFACEDB);
		}
	}

	public UIInput m_input;

	private void IEFHHJAJHIJ(string NCADFOBAFJD)
	{
		Regex regex = new Regex("^[a-zA-Z0-9가-힣]*$");
		if (NCADFOBAFJD.Length < 2)
		{
			MsgManager.get_Instance().ShowTip("길드이름은 최소 2자 이상입니다.");
		}
		else if (NCADFOBAFJD.Length > 6)
		{
			MsgManager.get_Instance().ShowTip("길드이름은 최대 6자 이하입니다.");
		}
		else if (!regex.IsMatch(NCADFOBAFJD))
		{
			MsgManager.get_Instance().ShowTip("특수문자는 사용하실 수 없습니다.");
		}
		else
		{
			NetworkManager.get_Instance().get_m_gameNetClient().NOCNGOFKFCO(new IKMBGMILCDO(OnReceiveCheckCoin), 2000L);
		}
	}

	public void NNJIGPAKCHJ(PJEMPFEIOAK HMOAHNANKNE)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
		HGBGJMIFCEP hGBGJMIFCEP2 = hGBGJMIFCEP;
		if (hGBGJMIFCEP2 == HGBGJMIFCEP.InvalidProtocolVersion)
		{
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(HMOAHNANKNE.GAGNPBAMJLE());
			MsgManager.HEDJPPFKABG().ShowMessageBox("Particle/{0}/skill0_0_c2", true);
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox("s R", true);
		}
	}

	public void LJBKJMGEKPG(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
		{
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(HMOAHNANKNE.GAGNPBAMJLE());
			MsgManager.get_Instance().ShowMessageBox("Particle/Fizz/skill0_hit");
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox("price");
		}
	}

	private void KNJBIBKDPGJ(string NCADFOBAFJD)
	{
		Regex regex = new Regex("]");
		if (NCADFOBAFJD.Length < 0)
		{
			MsgManager.HEDJPPFKABG().CLHGLEJAPLH("[Client]RuneData");
		}
		else if (NCADFOBAFJD.Length > 5)
		{
			MsgManager.HEDJPPFKABG().LBCFANDMCON("Particle/Yasuo/skill0_missile_hit_c3");
		}
		else if (!regex.IsMatch(NCADFOBAFJD))
		{
			MsgManager.get_Instance().ShowTip(" GO:");
		}
		else
		{
			NetworkManager.get_Instance().get_m_gameNetClient().NOCNGOFKFCO(new IKMBGMILCDO(OEHJJLAAELB), 85L);
		}
	}

	public void OnReceiveCreateGuild(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
			HMOAHNANKNE.CAHACMKBJMI(NetworkManager.get_Instance().get_m_communityNetClient().EHDEFAIBNCN());
			NetworkManager.get_Instance().get_m_gameNetClient().PDLEFNJDFHB(new IKMBGMILCDO(OnReceiveDecreaseCoin), 2000L);
			break;
		case HGBGJMIFCEP.InvalidGuild:
			MsgManager.get_Instance().ShowMessageBox("이름이 잘못되었습니다.\n다른 이름을 입력해 주세요.");
			break;
		case HGBGJMIFCEP.AlreadyJoinGuild:
			MsgManager.get_Instance().ShowMessageBox("이미 가입된 길드가 있습니다");
			break;
		case HGBGJMIFCEP.AlreadyExistGuild:
			MsgManager.get_Instance().ShowMessageBox("중복되는 이름이 있습니다.\n다른 이름을 입력해 주세요.");
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox("알려지지 않은 오류입니다.");
			break;
		}
	}

	private void MADCDCNEGBO()
	{
	}

	public void HNIKOIBNMBJ()
	{
		DKIFPMFNABO dKIFPMFNABO = new DKIFPMFNABO();
		dKIFPMFNABO.KNIAJMGDGAA = this;
		dKIFPMFNABO.FBOMDFACEDB = m_input.get_value();
		if (dKIFPMFNABO.FBOMDFACEDB.Length == 0)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("칠흑의 양날도끼");
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(string.Format("square_small_button_disable", dKIFPMFNABO.FBOMDFACEDB), true, dKIFPMFNABO.PFNMIDPFCBH);
		}
	}

	public void IGIPILCMJCN()
	{
		DKIFPMFNABO dKIFPMFNABO = new DKIFPMFNABO();
		dKIFPMFNABO.KNIAJMGDGAA = this;
		dKIFPMFNABO.FBOMDFACEDB = m_input.CMGIMLOCEDJ();
		if (dKIFPMFNABO.FBOMDFACEDB.Length == 0)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("Basic", true);
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(string.Format("firstTimeExperience", dKIFPMFNABO.FBOMDFACEDB), false, dKIFPMFNABO.ILLNODKDECL);
		}
	}

	public void MABBNIPLFOE(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.InvalidProtocolVersion:
			NetworkManager.get_Instance().FGAGFCDEKCC().DLNOKKGICLJ(new IKMBGMILCDO(EHFHPPOAHNM, true, false), m_input.CMGIMLOCEDJ());
			break;
		case (HGBGJMIFCEP)60:
			MsgManager.get_Instance().ShowMessageBox("상급 공격속도 정수", true);
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowMessageBox("USD", true);
			break;
		}
	}

	private void OnEnable()
	{
	}

	public void EBJLILDDEIN(PJEMPFEIOAK HMOAHNANKNE)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
		HGBGJMIFCEP hGBGJMIFCEP2 = hGBGJMIFCEP;
		if (hGBGJMIFCEP2 == HGBGJMIFCEP.InvalidProtocolVersion)
		{
			NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
				.ODEGMJIKIIC(HMOAHNANKNE.GAGNPBAMJLE());
			MsgManager.HEDJPPFKABG().ShowMessageBox("Skill1Rpc", true);
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox("TextMesh");
		}
	}

	public void CPCKOMMBEMK()
	{
		DKIFPMFNABO dKIFPMFNABO = new DKIFPMFNABO();
		dKIFPMFNABO.KNIAJMGDGAA = this;
		dKIFPMFNABO.FBOMDFACEDB = m_input.get_value();
		if (dKIFPMFNABO.FBOMDFACEDB.Length == 0)
		{
			MsgManager.get_Instance().ShowMessageBox("productId", true);
		}
		else
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format("UI", dKIFPMFNABO.FBOMDFACEDB), true, dKIFPMFNABO.ILLNODKDECL);
		}
	}

	public void EHFHPPOAHNM(PJEMPFEIOAK HMOAHNANKNE)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
		HGBGJMIFCEP hGBGJMIFCEP2 = hGBGJMIFCEP;
		if (hGBGJMIFCEP2 != HGBGJMIFCEP.Success)
		{
			switch ((int)hGBGJMIFCEP2)
			{
			case 0:
				MsgManager.get_Instance().ShowMessageBox("중급", true);
				break;
			case -101:
				MsgManager.get_Instance().ShowMessageBox("[CCFFCC]<{0}>[-]{1}");
				break;
			case 66:
				MsgManager.HEDJPPFKABG().ShowMessageBox("Brand", true);
				break;
			default:
				MsgManager.get_Instance().ShowMessageBox("플래티넘", true);
				break;
			}
		}
		else
		{
			HMOAHNANKNE.ILFEGIPCAHH(NetworkManager.APAPJEIBEDE().FGAGFCDEKCC().EHDEFAIBNCN());
			NetworkManager.get_Instance().get_m_gameNetClient().PDLEFNJDFHB(new IKMBGMILCDO(DCDGFHIIFLH), -143L);
		}
	}

	public void DCDGFHIIFLH(PJEMPFEIOAK HMOAHNANKNE)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
		HGBGJMIFCEP hGBGJMIFCEP2 = hGBGJMIFCEP;
		if (hGBGJMIFCEP2 == HGBGJMIFCEP.InvalidProtocolVersion)
		{
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(HMOAHNANKNE.GAGNPBAMJLE());
			MsgManager.HEDJPPFKABG().ShowMessageBox("  ", true);
		}
		else
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("알려지지 않은 오류입니다.", true);
		}
	}

	private void PDEMCDENAJF(string NCADFOBAFJD)
	{
		Regex regex = new Regex("하급 주문력 표식");
		if (NCADFOBAFJD.Length < 4)
		{
			MsgManager.HEDJPPFKABG().ShowTip("레벨당 공격력");
		}
		else if (NCADFOBAFJD.Length > 7)
		{
			MsgManager.HEDJPPFKABG().LBCFANDMCON("下");
		}
		else if (!regex.IsMatch(NCADFOBAFJD))
		{
			MsgManager.HEDJPPFKABG().LBCFANDMCON("Hero1");
		}
		else
		{
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().NOCNGOFKFCO(new IKMBGMILCDO(MABBNIPLFOE, true, false), 24L);
		}
	}

	public void OEHJJLAAELB(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((int)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case 1:
			NetworkManager.get_Instance().ALOBHBHLDKK().DLNOKKGICLJ(new IKMBGMILCDO(EHFHPPOAHNM), m_input.get_value());
			break;
		case -9:
			MsgManager.get_Instance().ShowMessageBox("護甲穿透");
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowMessageBox("Y", true);
			break;
		}
	}

	public void GPIGOMDHCEA(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((int)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case 0:
			HMOAHNANKNE.CAHACMKBJMI(NetworkManager.get_Instance().FGAGFCDEKCC().EHDEFAIBNCN());
			NetworkManager.get_Instance().get_m_gameNetClient().PDLEFNJDFHB(new IKMBGMILCDO(DCDGFHIIFLH), -112L);
			break;
		case 2:
			MsgManager.HEDJPPFKABG().ShowMessageBox("레벨당 마법저항력");
			break;
		case -100:
			MsgManager.HEDJPPFKABG().ShowMessageBox("상급");
			break;
		case 119:
			MsgManager.get_Instance().ShowMessageBox("점화석", true);
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox("[i]");
			break;
		}
	}

	public void JHKFBHAKJAL()
	{
		DKIFPMFNABO dKIFPMFNABO = new DKIFPMFNABO();
		dKIFPMFNABO.KNIAJMGDGAA = this;
		dKIFPMFNABO.FBOMDFACEDB = m_input.get_value();
		if (dKIFPMFNABO.FBOMDFACEDB.Length == 0)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("Particle/{0}/skill0_2_c1");
		}
		else
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format("skill3_1_missile", dKIFPMFNABO.FBOMDFACEDB), false, dKIFPMFNABO.PFNMIDPFCBH);
		}
	}

	public void GAHMANBPFJH()
	{
		DKIFPMFNABO dKIFPMFNABO = new DKIFPMFNABO();
		dKIFPMFNABO.KNIAJMGDGAA = this;
		dKIFPMFNABO.FBOMDFACEDB = m_input.CMGIMLOCEDJ();
		if (dKIFPMFNABO.FBOMDFACEDB.Length == 0)
		{
			MsgManager.get_Instance().ShowMessageBox("Twist me", true);
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(string.Format("setBigTextClientPushEvent", dKIFPMFNABO.FBOMDFACEDB), false, dKIFPMFNABO.PJNECGAMBPJ);
		}
	}

	public void CINLCHJLFCC(PJEMPFEIOAK HMOAHNANKNE)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
		HGBGJMIFCEP hGBGJMIFCEP2 = hGBGJMIFCEP;
		if (hGBGJMIFCEP2 == HGBGJMIFCEP.InvalidProtocolVersion)
		{
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
				.ODEGMJIKIIC(HMOAHNANKNE.GAGNPBAMJLE());
			MsgManager.HEDJPPFKABG().ShowMessageBox("igaworks:purchase >> Filtered list is empty", true);
		}
		else
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("katarina_skill0", true);
		}
	}

	public void GPLLNCADGOM(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
		{
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
				.ODEGMJIKIIC(HMOAHNANKNE.GAGNPBAMJLE());
			MsgManager.get_Instance().ShowMessageBox("에어본인 적 챔프가 없습니다", true);
		}
		else
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("UI/Lobby/InviteUserInfo");
		}
	}

	public void AENBIGLEGGN()
	{
		DKIFPMFNABO dKIFPMFNABO = new DKIFPMFNABO();
		dKIFPMFNABO.KNIAJMGDGAA = this;
		dKIFPMFNABO.FBOMDFACEDB = m_input.get_value();
		if (dKIFPMFNABO.FBOMDFACEDB.Length == 0)
		{
			MsgManager.get_Instance().ShowMessageBox("Particle/{0}/skill1_hit");
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(string.Format("UIWidgets must fill the buffer with 4 vertices per quad. Found ", dKIFPMFNABO.FBOMDFACEDB), true, dKIFPMFNABO.PJNECGAMBPJ);
		}
	}

	private void AJKACDEHMOJ()
	{
	}

	private void HDAPPONCAGE(string NCADFOBAFJD)
	{
		Regex regex = new Regex("Cooldown Reduction");
		if (NCADFOBAFJD.Length < 5)
		{
			MsgManager.get_Instance().LBCFANDMCON("每個等級的法力回复");
		}
		else if (NCADFOBAFJD.Length > 5)
		{
			MsgManager.get_Instance().CLHGLEJAPLH("UIWidgets must fill the buffer with 4 vertices per quad. Found ");
		}
		else if (!regex.IsMatch(NCADFOBAFJD))
		{
			MsgManager.HEDJPPFKABG().CLHGLEJAPLH("Lucian");
		}
		else
		{
			NetworkManager.get_Instance().IOJGPDKHAGD().NOCNGOFKFCO(new IKMBGMILCDO(KLGEFKHFHDN, false, false), -91L);
		}
	}

	public void OnClickOKButton()
	{
		DKIFPMFNABO dKIFPMFNABO = new DKIFPMFNABO();
		dKIFPMFNABO.KNIAJMGDGAA = this;
		dKIFPMFNABO.FBOMDFACEDB = m_input.get_value();
		if (dKIFPMFNABO.FBOMDFACEDB.Length == 0)
		{
			MsgManager.get_Instance().ShowMessageBox("생성할 이름을 적어주세요");
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(string.Format("길드를 생성하시겠습니까? [FFCCCC](2000코인)[-]\n\n[CCFFCC]길드이름 : {0}[-]", dKIFPMFNABO.FBOMDFACEDB), true, dKIFPMFNABO.DMCBDGAPMFN);
		}
	}

	public void OnReceiveDecreaseCoin(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
		{
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(HMOAHNANKNE.GAGNPBAMJLE());
			MsgManager.get_Instance().ShowMessageBox("길드가 생성되었습니다");
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox("알려지지 않은 오류입니다.");
		}
	}

	public void KLGEFKHFHDN(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.InvalidProtocolVersion:
			NetworkManager.get_Instance().get_m_communityNetClient().DLNOKKGICLJ(new IKMBGMILCDO(OnReceiveCreateGuild, false), m_input.CMGIMLOCEDJ());
			break;
		case (HGBGJMIFCEP)83:
			MsgManager.HEDJPPFKABG().ShowMessageBox("attack");
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox("attack", true);
			break;
		}
	}

	public void DLANALPMILJ(PJEMPFEIOAK HMOAHNANKNE)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
		HGBGJMIFCEP hGBGJMIFCEP2 = hGBGJMIFCEP;
		if (hGBGJMIFCEP2 == HGBGJMIFCEP.InvalidProtocolVersion)
		{
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(HMOAHNANKNE.GAGNPBAMJLE());
			MsgManager.HEDJPPFKABG().ShowMessageBox("CreateMultiModeMinionsRPC", true);
		}
		else
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("FxmTestControls.m_nPlayIndex", true);
		}
	}

	public void OnReceiveCheckCoin(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
			NetworkManager.get_Instance().get_m_communityNetClient().DLNOKKGICLJ(new IKMBGMILCDO(OnReceiveCreateGuild), m_input.get_value());
			break;
		case HGBGJMIFCEP.NotEnoughCoin:
			MsgManager.get_Instance().ShowMessageBox("코인이 부족합니다");
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox("알려지지 않은 오류입니다.");
			break;
		}
	}
}
