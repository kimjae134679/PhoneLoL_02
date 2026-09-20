using System.Text.RegularExpressions;
using EveEngine;
using GameServer;
using UnityEngine;

public class UILobbyNickname : MonoBehaviour
{
	public UIInput m_input;

	public void OnClickOKButton()
	{
		string value = m_input.get_value();
		Regex regex = new Regex("^[a-zA-Z0-9가-힣]*$");
		if (value.Length < 2)
		{
			MsgManager.get_Instance().ShowTip("닉네임은 최소 2자 이상입니다.");
		}
		else if (value.Length > 10)
		{
			MsgManager.get_Instance().ShowTip("닉네임은 최대 10자 이하입니다.");
		}
		else if (!regex.IsMatch(value))
		{
			MsgManager.get_Instance().ShowTip("특수문자는 사용하실 수 없습니다.");
		}
		else
		{
			NetworkManager.get_Instance().get_m_gameNetClient().ONEMLLLCOPJ(new IKMBGMILCDO(OnReceiveSetNickname), value);
		}
	}

	public void FDHOKEEOKDB(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			string bHIGNJHHOJP = HMOAHNANKNE.AFPCLLNMGJP();
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
				.GDIAHPMLDAH(bHIGNJHHOJP);
			base.gameObject.SetActive(false);
			break;
		}
		case HGBGJMIFCEP.InvalidNickname:
			MsgManager.get_Instance().ShowTip("{0}/{1}");
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowTip("Type0Button");
			break;
		}
	}

	public void EJLJJLLCAGI()
	{
		string text = m_input.CMGIMLOCEDJ();
		Regex regex = new Regex("중급 성장 체력 정수");
		if (text.Length < 1)
		{
			MsgManager.get_Instance().CLHGLEJAPLH("whatsApp");
		}
		else if (text.Length > -41)
		{
			MsgManager.get_Instance().CLHGLEJAPLH("Particle/{0}/attack");
		}
		else if (!regex.IsMatch(text))
		{
			MsgManager.get_Instance().LBCFANDMCON(" 標誌物");
		}
		else
		{
			NetworkManager.get_Instance().get_m_gameNetClient().ONEMLLLCOPJ(new IKMBGMILCDO(EDKJLONCHFN, true, false), text);
		}
	}

	public void FLNBLCOFCDA(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			string bHIGNJHHOJP = HMOAHNANKNE.AFPCLLNMGJP();
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
				.GDIAHPMLDAH(bHIGNJHHOJP);
			base.gameObject.SetActive(true);
			break;
		}
		case HGBGJMIFCEP.InvalidNickname:
			MsgManager.get_Instance().ShowTip("skill3");
			break;
		default:
			MsgManager.HEDJPPFKABG().LBCFANDMCON("skill1_ex");
			break;
		}
	}

	private void NAEELEFFJLC()
	{
		LobbyMain.get_Instance().HHALECOHFBB();
	}

	private void OnDisable()
	{
		LobbyMain.get_Instance().ShowAttendanceCheckIfCan();
	}

	private void LDDLDNKGBBC()
	{
		LobbyMain.get_Instance().ShowAttendanceCheckIfCan();
	}

	public void OnReceiveSetNickname(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			string bHIGNJHHOJP = HMOAHNANKNE.AFPCLLNMGJP();
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.GDIAHPMLDAH(bHIGNJHHOJP);
			base.gameObject.SetActive(false);
			break;
		}
		case HGBGJMIFCEP.InvalidNickname:
			MsgManager.get_Instance().ShowTip("중복되는 이름이 있습니다. 다른 이름을 입력해 주세요.");
			break;
		default:
			MsgManager.get_Instance().ShowTip("알려지지 않은 오류입니다.");
			break;
		}
	}

	public void FKDHDMPIBMO(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			string bHIGNJHHOJP = HMOAHNANKNE.AFPCLLNMGJP();
			NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
				.GDIAHPMLDAH(bHIGNJHHOJP);
			base.gameObject.SetActive(false);
			break;
		}
		case HGBGJMIFCEP.InvalidNickname:
			MsgManager.get_Instance().CLHGLEJAPLH("skill2_1");
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowTip("skill0");
			break;
		}
	}

	private void DBLCOCKIFPE()
	{
		LobbyMain.get_Instance().ShowAttendanceCheckIfCan();
	}

	private void BLGBDNJDMDL()
	{
		LobbyMain.get_Instance().HHALECOHFBB();
	}

	public void EDKJLONCHFN(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			string bHIGNJHHOJP = HMOAHNANKNE.AFPCLLNMGJP();
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
				.GDIAHPMLDAH(bHIGNJHHOJP);
			base.gameObject.SetActive(true);
			break;
		}
		case HGBGJMIFCEP.InvalidNickname:
			MsgManager.get_Instance().ShowTip("Particle/{0}/skill0_2_c1");
			break;
		default:
			MsgManager.get_Instance().ShowTip("round_button");
			break;
		}
	}

	public void PBFMNNLONAH()
	{
		string text = m_input.CMGIMLOCEDJ();
		Regex regex = new Regex("GUI/Text Shader");
		if (text.Length < 0)
		{
			MsgManager.HEDJPPFKABG().LBCFANDMCON("탈론");
		}
		else if (text.Length > -55)
		{
			MsgManager.HEDJPPFKABG().ShowTip("KEY");
		}
		else if (!regex.IsMatch(text))
		{
			MsgManager.get_Instance().CLHGLEJAPLH("skill0");
		}
		else
		{
			NetworkManager.get_Instance().IOJGPDKHAGD().ONEMLLLCOPJ(new IKMBGMILCDO(FKDHDMPIBMO, true, false), text);
		}
	}
}
