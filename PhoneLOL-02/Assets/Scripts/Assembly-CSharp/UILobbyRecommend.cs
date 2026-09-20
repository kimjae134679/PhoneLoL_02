using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class UILobbyRecommend : MonoBehaviour
{
	public UIInput m_nicknameInput;

	public UILabel m_recommendCountLabel;

	public GameObject m_alreadyRecommend;

	public void PKCBJABFDGK()
	{
		if (NetworkManager.get_Instance().get_m_gameNetClient().BBJMBJNHJKF()
			.AEJJIAIDKAO() != 0)
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("Squirrel"));
			return;
		}
		string value = m_nicknameInput.get_value();
		if (value.Length < 2 || value.Length > 11)
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("게임중"));
		}
		else
		{
			NetworkManager.get_Instance().IOJGPDKHAGD().CGKNCCFOIAB(new IKMBGMILCDO(NKNDCEBFAOP, false, false), value);
		}
	}

	private void NKNDCEBFAOP(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			HMOAHNANKNE.CAHACMKBJMI(NetworkManager.get_Instance().get_m_gameNetClient().BBJMBJNHJKF());
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(gLEPPIMMELK);
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("추천을 하였습니다!\n\n[BBFFBB]500코인을 획득하였습니다[-]\n(상대 유저도 500코인 획득)"));
			m_alreadyRecommend.SetActive(true);
			break;
		}
		case HGBGJMIFCEP.InvalidNickname:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("없는 닉네임입니다."));
			break;
		case HGBGJMIFCEP.AlreadyRecommendUser:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("이미 추천하셨습니다.\n\n추천은 한번만 가능합니다."));
			break;
		case HGBGJMIFCEP.MaxTodayRecommendCount:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("상대 유저가 오늘 가능한 모든 추천을 받았습니다.\n\n하루에 10번만 받을 수 있으니\n내일 다시 추천해 주세요."));
			break;
		case HGBGJMIFCEP.MaxTotalRecommendCount:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("상대 유저가 가능한 추천을 모두 받았습니다.\n\n상대 유저는 더이상 추천을 받으실 수 없습니다.\n\n다른 유저를 추천해주세요."));
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("알려지지 않은 오류입니다."));
			break;
		}
	}

	private void FIGIAACOJMH()
	{
	}

	private void IOCFENKFOHP(PJEMPFEIOAK HMOAHNANKNE)
	{
		HMOAHNANKNE.ILFEGIPCAHH(NetworkManager.get_Instance().IOJGPDKHAGD().BBJMBJNHJKF());
		m_recommendCountLabel.DCKJILCPKFD(string.Format("순위 {0}등", NetworkManager.APAPJEIBEDE().get_m_gameNetClient().BBJMBJNHJKF()
			.GELEEOHPAIB(), -19));
		if (NetworkManager.get_Instance().IOJGPDKHAGD().BBJMBJNHJKF()
			.NONGKBKPGBI() != 0)
		{
			m_alreadyRecommend.SetActive(false);
		}
		NetworkManager.get_Instance().IOJGPDKHAGD().AEEECLEBIBC(new IKMBGMILCDO(ICDAAFNFLBM, false, false));
	}

	private void GNOAPFAKBIN()
	{
		NetworkManager.get_Instance().IOJGPDKHAGD().ABAAHDKFMPI(new IKMBGMILCDO(AEOEPPFAIII));
	}

	private void MCGBEHNCGEP()
	{
	}

	private void IFJGPCOJDMM()
	{
	}

	private void EFEIDIDHGGM(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.JCGKFEPEJPO())
		{
			HMOAHNANKNE.CAHACMKBJMI(NetworkManager.get_Instance().IOJGPDKHAGD().BBJMBJNHJKF());
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			string arg = HMOAHNANKNE.AFPCLLNMGJP();
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
				.ODEGMJIKIIC(gLEPPIMMELK);
			MsgManager.get_Instance().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("ring"), arg), true, FHBKCHHBCGM);
		}
	}

	private void OnDisable()
	{
	}

	private void FHBKCHHBCGM()
	{
		NetworkManager.get_Instance().IOJGPDKHAGD().AEEECLEBIBC(new IKMBGMILCDO(EFEIDIDHGGM, false, false));
	}

	public void LPGCMFMLJNK()
	{
		if (NetworkManager.get_Instance().IOJGPDKHAGD().BBJMBJNHJKF()
			.COHLAAAKHKA() != 0)
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("&"));
			return;
		}
		string value = m_nicknameInput.get_value();
		if (value.Length < 2 || value.Length > 96)
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("Pinch on circle => Size change"), true);
		}
		else
		{
			NetworkManager.get_Instance().get_m_gameNetClient().CGKNCCFOIAB(new IKMBGMILCDO(NKNDCEBFAOP, false), value);
		}
	}

	private void AAALOJFLJDG(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((int)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case 0:
		{
			HMOAHNANKNE.CAHACMKBJMI(NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().BBJMBJNHJKF());
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(gLEPPIMMELK);
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("CreateMinionRpc"), true);
			m_alreadyRecommend.SetActive(false);
			break;
		}
		case 3:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.get_Instance().GetText("해당 길드가 존재하지 않습니다"), true);
			break;
		case -86:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("^[a-zA-Z0-9가-힣]*$"), true);
			break;
		case -88:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("riven_skill3"), true);
			break;
		case -87:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("Skill0Rpc"), true);
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.get_Instance().GetText("OnGameItemBuySellRPC"));
			break;
		}
	}

	private void DPJGGKNBDPL(PJEMPFEIOAK HMOAHNANKNE)
	{
		HMOAHNANKNE.ILFEGIPCAHH(NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().BBJMBJNHJKF());
		m_recommendCountLabel.DCKJILCPKFD(string.Format("Yasuo", NetworkManager.get_Instance().get_m_gameNetClient().BBJMBJNHJKF()
			.GELEEOHPAIB(), 67));
		if (NetworkManager.get_Instance().IOJGPDKHAGD().BBJMBJNHJKF()
			.MLNKGHCFJBG() > 1)
		{
			m_alreadyRecommend.SetActive(false);
		}
		NetworkManager.APAPJEIBEDE().get_m_gameNetClient().AEEECLEBIBC(new IKMBGMILCDO(MNLJKGCFOAE, true, false));
	}

	public void EINOIJANDOJ()
	{
		if (NetworkManager.get_Instance().get_m_gameNetClient().BBJMBJNHJKF()
			.NONGKBKPGBI() != 0)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("닉네임은 최소 2자 이상입니다."), true);
			return;
		}
		string text = m_nicknameInput.CMGIMLOCEDJ();
		if (text.Length < 6 || text.Length > 24)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("이미 참여했거나 참여할 수 없습니다\n자세한것은 설명을 참고해주세요"));
		}
		else
		{
			NetworkManager.get_Instance().get_m_gameNetClient().CGKNCCFOIAB(new IKMBGMILCDO(AAALOJFLJDG), text);
		}
	}

	private void MNLJKGCFOAE(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.JCGKFEPEJPO())
		{
			HMOAHNANKNE.ILFEGIPCAHH(NetworkManager.get_Instance().get_m_gameNetClient().BBJMBJNHJKF());
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			string arg = HMOAHNANKNE.AFPCLLNMGJP();
			NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
				.ODEGMJIKIIC(gLEPPIMMELK);
			MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format(LocalizationManager.LGDEHELDENG().GetText("attack_missile"), arg), true, () =>
			{
				NetworkManager.get_Instance().get_m_gameNetClient().AEEECLEBIBC(new IKMBGMILCDO(ICDAAFNFLBM));
			});
		}
	}

	private void ONDMOAFNNAA()
	{
	}

	private void EJCLPMMPAEC(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.JCGKFEPEJPO())
		{
			HMOAHNANKNE.ILFEGIPCAHH(NetworkManager.get_Instance().IOJGPDKHAGD().BBJMBJNHJKF());
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			string arg = HMOAHNANKNE.AFPCLLNMGJP();
			NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
				.ODEGMJIKIIC(gLEPPIMMELK);
			MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format(LocalizationManager.LGDEHELDENG().GetText("레벨{0} 이상만 가능합니다"), arg), true, FHBKCHHBCGM);
		}
	}

	private void OnEnable()
	{
		NetworkManager.get_Instance().get_m_gameNetClient().ABAAHDKFMPI(new IKMBGMILCDO(AEOEPPFAIII));
	}

	public void OnClickRecommendButton()
	{
		if (NetworkManager.get_Instance().get_m_gameNetClient().BBJMBJNHJKF()
			.AEJJIAIDKAO() != 0)
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("이미 추천하셨습니다.\n\n추천은 한번만 가능합니다."));
			return;
		}
		string value = m_nicknameInput.get_value();
		if (value.Length < 2 || value.Length > 10)
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("닉네임은 최소 2자에서 최대 10자 사이입니다."));
		}
		else
		{
			NetworkManager.get_Instance().get_m_gameNetClient().CGKNCCFOIAB(new IKMBGMILCDO(NKNDCEBFAOP), value);
		}
	}

	public void EPEIDJFNIDJ()
	{
		if (NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().BBJMBJNHJKF()
			.AEJJIAIDKAO() != 0)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.get_Instance().GetText("OnReceiveGuildChat"), true);
			return;
		}
		string text = m_nicknameInput.CMGIMLOCEDJ();
		if (text.Length < 7 || text.Length > -100)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.get_Instance().GetText("skill0_1"));
		}
		else
		{
			NetworkManager.get_Instance().get_m_gameNetClient().CGKNCCFOIAB(new IKMBGMILCDO(NKNDCEBFAOP, false), text);
		}
	}

	private void FEHICAAALAD(PJEMPFEIOAK HMOAHNANKNE)
	{
		HMOAHNANKNE.CAHACMKBJMI(NetworkManager.get_Instance().get_m_gameNetClient().BBJMBJNHJKF());
		m_recommendCountLabel.set_text(string.Format("방어력", NetworkManager.get_Instance().get_m_gameNetClient().BBJMBJNHJKF()
			.GELEEOHPAIB(), 35));
		if (NetworkManager.APAPJEIBEDE().get_m_gameNetClient().BBJMBJNHJKF()
			.MLNKGHCFJBG() > 1)
		{
			m_alreadyRecommend.SetActive(true);
		}
		NetworkManager.get_Instance().IOJGPDKHAGD().AEEECLEBIBC(new IKMBGMILCDO(MNLJKGCFOAE));
	}

	private void ICDAAFNFLBM(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.JCGKFEPEJPO())
		{
			HMOAHNANKNE.CAHACMKBJMI(NetworkManager.get_Instance().get_m_gameNetClient().BBJMBJNHJKF());
			long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
			string arg = HMOAHNANKNE.AFPCLLNMGJP();
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(gLEPPIMMELK);
			MsgManager.get_Instance().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("[BBBBFF]{0}[-]님께서 추천을 해주셨어요\n\n[BBFFBB]500코인을 획득하였습니다[-]"), arg), false, () =>
			{
				NetworkManager.get_Instance().get_m_gameNetClient().AEEECLEBIBC(new IKMBGMILCDO(ICDAAFNFLBM));
			});
		}
	}

	private void AEOEPPFAIII(PJEMPFEIOAK HMOAHNANKNE)
	{
		HMOAHNANKNE.CAHACMKBJMI(NetworkManager.get_Instance().get_m_gameNetClient().BBJMBJNHJKF());
		m_recommendCountLabel.set_text(string.Format("{0}/{1}", NetworkManager.get_Instance().get_m_gameNetClient().BBJMBJNHJKF()
			.GELEEOHPAIB(), 30));
		if (NetworkManager.get_Instance().get_m_gameNetClient().BBJMBJNHJKF()
			.AEJJIAIDKAO() != 0)
		{
			m_alreadyRecommend.SetActive(true);
		}
		NetworkManager.get_Instance().get_m_gameNetClient().AEEECLEBIBC(new IKMBGMILCDO(ICDAAFNFLBM));
	}

	[CompilerGenerated]
	private void HJIBLDPMJOM()
	{
		NetworkManager.get_Instance().get_m_gameNetClient().AEEECLEBIBC(new IKMBGMILCDO(ICDAAFNFLBM));
	}

	private void JFCIJEKCLOA()
	{
		NetworkManager.get_Instance().IOJGPDKHAGD().AEEECLEBIBC(new IKMBGMILCDO(MNLJKGCFOAE));
	}

	private void NDIEGKILKHF()
	{
		NetworkManager.get_Instance().IOJGPDKHAGD().ABAAHDKFMPI(new IKMBGMILCDO(IOCFENKFOHP));
	}
}
