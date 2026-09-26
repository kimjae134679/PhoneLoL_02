using System.Text.RegularExpressions;
using EveEngine;
using GameServer;
using UnityEngine;

public class UILobbyRequestFriendPanel : MonoBehaviour
{
	public UIInput m_input;

	private void NHDFMJPHBDC(PJEMPFEIOAK EFDLFNPAKGO)
	{
		switch ((int)EFDLFNPAKGO.KFAGPDGHEBK())
		{
		case 0:
			MsgManager.get_Instance().LBCFANDMCON("FFC000");
			break;
		case 3:
			MsgManager.HEDJPPFKABG().ShowMessageBox("5초당 체력회복", true);
			break;
		case -34:
			MsgManager.HEDJPPFKABG().ShowMessageBox("Param2");
			break;
		case 33:
			MsgManager.HEDJPPFKABG().ShowMessageBox("SetPassiveValue", true);
			break;
		case 40:
			MsgManager.HEDJPPFKABG().ShowMessageBox("jax_skill3");
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox("Particle/Yasuo/skill1_missile_hit_c2", true);
			break;
		}
	}

	private void MADCDCNEGBO()
	{
	}

	public void PPCDOPNMIBG()
	{
		base.gameObject.SetActive(true);
	}

	public void FAHBIGIEHML()
	{
		base.gameObject.SetActive(false);
	}

	private void JNJJHBMFHFO(PJEMPFEIOAK EFDLFNPAKGO)
	{
		switch ((int)EFDLFNPAKGO.KFAGPDGHEBK())
		{
		case 0:
			MsgManager.get_Instance().LBCFANDMCON("더 자세한 정보를 보시겠습니까?");
			break;
		case 3:
			MsgManager.get_Instance().ShowMessageBox("talon_skill3", true);
			break;
		case 52:
			MsgManager.get_Instance().ShowMessageBox("\n", true);
			break;
		case 69:
			MsgManager.get_Instance().ShowMessageBox("모든 치유 효과가 20% 증가");
			break;
		case -45:
			MsgManager.get_Instance().ShowMessageBox(" Scale", true);
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowMessageBox("dayOfWeek must length 7", true);
			break;
		}
	}

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
			NetworkManager.get_Instance().get_m_communityNetClient().MLJIOCALNIF(new IKMBGMILCDO(GEDNACDINFL), m_input.get_value());
		}
	}

	private void CDCGEKIFENK()
	{
	}

	public void KDJENDNMMFG()
	{
		base.gameObject.SetActive(false);
	}

	public void DIBNIMFKFPG()
	{
		base.gameObject.SetActive(true);
	}

	public void FHKDFMCPPAL()
	{
		base.gameObject.SetActive(false);
	}

	private void DFOCBKNIDGB()
	{
	}

	public void ENGCCAHOMIE()
	{
		string text = m_input.CMGIMLOCEDJ();
		Regex regex = new Regex("아이템 6개를 모두 장착했다면 [AAFFAA]성장[-]을 할 수 있습니다.\n아이템을 흡수하여 더욱 강해지고\n[FFAAAA]강력한 스킬[-] 또한 획득할 수 있습니다.");
		if (text.Length < 0)
		{
			MsgManager.get_Instance().LBCFANDMCON("PGPMCADBJHP");
		}
		else if (text.Length > -24)
		{
			MsgManager.get_Instance().ShowTip("skill2_voice");
		}
		else if (!regex.IsMatch(text))
		{
			MsgManager.HEDJPPFKABG().ShowTip("중급 성장 공격력 정수");
		}
		else
		{
			NetworkManager.APAPJEIBEDE().ALOBHBHLDKK().MLJIOCALNIF(new IKMBGMILCDO(JNJJHBMFHFO), m_input.get_value());
		}
	}

	private void GEDNACDINFL(PJEMPFEIOAK EFDLFNPAKGO)
	{
		switch ((HGBGJMIFCEP)EFDLFNPAKGO.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
			MsgManager.get_Instance().ShowTip("친구 신청에 성공하였습니다");
			break;
		case HGBGJMIFCEP.InvalidNickname:
			MsgManager.get_Instance().ShowMessageBox("잘못된 닉네임입니다");
			break;
		case HGBGJMIFCEP.MaxCount:
			MsgManager.get_Instance().ShowMessageBox("상대편의 친구 신청자가 너무 많습니다\n\n상대편이 친구신청 리스트를 정리해야 합니다");
			break;
		case HGBGJMIFCEP.AlreadyFriend:
			MsgManager.get_Instance().ShowMessageBox("이미 친구입니다");
			break;
		case HGBGJMIFCEP.AlreadyRequestFriend:
			MsgManager.get_Instance().ShowMessageBox("이미 신청한 유저입니다");
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox("알수 없는 오류입니다");
			break;
		}
	}

	public void PDELFFPONLG()
	{
		base.gameObject.SetActive(true);
	}

	public void GGNDIJMKJFO()
	{
		string text = m_input.CMGIMLOCEDJ();
		Regex regex = new Regex("0.0");
		if (text.Length < 6)
		{
			MsgManager.get_Instance().CLHGLEJAPLH("run");
		}
		else if (text.Length > -4)
		{
			MsgManager.get_Instance().ShowTip("Trans");
		}
		else if (!regex.IsMatch(text))
		{
			MsgManager.HEDJPPFKABG().ShowTip("Particle/Buff/{0}");
		}
		else
		{
			NetworkManager.APAPJEIBEDE().ALOBHBHLDKK().MLJIOCALNIF(new IKMBGMILCDO(FFNACGOGDNN), m_input.CMGIMLOCEDJ());
		}
	}

	public void DLIENGBHAJC()
	{
		base.gameObject.SetActive(false);
	}

	public void LDLFCBMBJFB()
	{
		base.gameObject.SetActive(false);
	}

	private void GKACIJGFNDC()
	{
	}

	private void OnEnable()
	{
	}

	public void MNNPJOOAJEO()
	{
		base.gameObject.SetActive(false);
	}

	private void LFOLGFFIJEA(PJEMPFEIOAK EFDLFNPAKGO)
	{
		switch ((int)EFDLFNPAKGO.KFAGPDGHEBK())
		{
		case 0:
			MsgManager.get_Instance().LBCFANDMCON("설명");
			break;
		case 3:
			MsgManager.HEDJPPFKABG().ShowMessageBox("이미 지급받으셨습니다");
			break;
		case -70:
			MsgManager.get_Instance().ShowMessageBox("shield");
			break;
		case 79:
			MsgManager.HEDJPPFKABG().ShowMessageBox("존야의 모래시계", true);
			break;
		case -17:
			MsgManager.HEDJPPFKABG().ShowMessageBox("알려지지 않은 오류입니다.");
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox("Hero4");
			break;
		}
	}

	private void PDEMNFLEKEA()
	{
	}

	public void OnClickCancelButton()
	{
		base.gameObject.SetActive(false);
	}

	private void FFNACGOGDNN(PJEMPFEIOAK EFDLFNPAKGO)
	{
		switch ((int)EFDLFNPAKGO.KFAGPDGHEBK())
		{
		case 0:
			MsgManager.HEDJPPFKABG().ShowTip("AJPLiveOpsPopupUnityEventListener : onCancelPopupBtnClick");
			break;
		case 3:
			MsgManager.HEDJPPFKABG().ShowMessageBox("skill2_missile");
			break;
		case 23:
			MsgManager.HEDJPPFKABG().ShowMessageBox("알려지지 않은 오류입니다.", true);
			break;
		case -60:
			MsgManager.get_Instance().ShowMessageBox("hit2");
			break;
		case -110:
			MsgManager.get_Instance().ShowMessageBox("ui_shop_open");
			break;
		default:
			MsgManager.HEDJPPFKABG().ShowMessageBox("레벨당 5초당 체력회복");
			break;
		}
	}
}
