using System;
using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class UIGameUserReport : MonoBehaviour
{
	public UILabel m_title;

	public UILabel m_detail;

	public UIInput m_input;

	public UIToggle m_select0;

	public UIToggle m_select1;

	public UIToggle m_select2;

	[NonSerialized]
	public uint m_targetUserId;

	[NonSerialized]
	public string m_targetUserNickname;

	public void GIIPNGDMFDG()
	{
		base.gameObject.SetActive(true);
	}

	private void KHCJLBGPAGN()
	{
		base.gameObject.SetActive(true);
	}

	public void OnUserReport(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
		{
			MsgManager.get_Instance().ShowMessageBox("신고가 완료되었습니다", false, () =>
			{
				base.gameObject.SetActive(false);
			});
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox("오류가 발생했습니다", false, () =>
			{
				base.gameObject.SetActive(false);
			});
		}
	}

	[CompilerGenerated]
	private void NNJKKCFPOHB()
	{
		base.gameObject.SetActive(false);
	}

	public void JDPGDMFCPFC()
	{
		base.gameObject.SetActive(true);
	}

	public void MBKMNABBLIA(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("no arguments", false, () =>
			{
				base.gameObject.SetActive(false);
			});
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox("정면 근처에 적이 없습니다", false, PCJBHEFIFHD);
		}
	}

	public void JHFOKPMHJPH(PJEMPFEIOAK HMOAHNANKNE)
	{
		HGBGJMIFCEP hGBGJMIFCEP = (HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK();
		HGBGJMIFCEP hGBGJMIFCEP2 = hGBGJMIFCEP;
		if (hGBGJMIFCEP2 == HGBGJMIFCEP.InvalidProtocolVersion)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("renekton_skill2", true, BJOEKGIHFEG);
		}
		else
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("Igaw.Unity: LiveOpsPopupEventManager : OnPopupClick", true, ODBINAKIGIM);
		}
	}

	private void ODBINAKIGIM()
	{
		base.gameObject.SetActive(true);
	}

	[CompilerGenerated]
	private void AKPDLGLGJIB()
	{
		base.gameObject.SetActive(false);
	}

	private void BJOEKGIHFEG()
	{
		base.gameObject.SetActive(false);
	}

	private void OnEnable()
	{
		m_title.set_text(string.Format("[FFCCCC]{0}[-] 님을 다음의 이유로 신고합니다", m_targetUserNickname));
	}

	public void OnClickExit()
	{
		base.gameObject.SetActive(false);
	}

	public void OnClickReport()
	{
		string value = m_input.get_value();
		string dJMOKDFPICO = string.Empty;
		if (m_select0.get_value())
		{
			dJMOKDFPICO = "탈주";
		}
		else if (m_select1.get_value())
		{
			dJMOKDFPICO = "트롤";
		}
		else if (m_select2.get_value())
		{
			dJMOKDFPICO = "비매너";
		}
		NetworkManager.get_Instance().get_m_battleNetClient().AKEINGFKEEM(m_targetUserId);
		NetworkManager.get_Instance().get_m_gameNetClient().OECECNMEILE(new IKMBGMILCDO(OnUserReport), m_targetUserId, dJMOKDFPICO, value);
	}

	public void PCLLCMEDNOA(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("skill3", false, KHCJLBGPAGN);
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox("buff_shield_loop", true, ODBINAKIGIM);
		}
	}

	public void OMNKODABJKB(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
		{
			MsgManager.get_Instance().ShowMessageBox("하급 공격력 문양", false, AEOLICLENGE);
			return;
		}
		MsgManager.HEDJPPFKABG().ShowMessageBox("currency", false, () =>
		{
			base.gameObject.SetActive(false);
		});
	}

	private void AEOLICLENGE()
	{
		base.gameObject.SetActive(false);
	}

	public void OLEDJKKLJNF()
	{
		base.gameObject.SetActive(false);
	}

	private void CIMCJMCCIJO()
	{
		base.gameObject.SetActive(true);
	}

	private void DJCELGKLDAP()
	{
		m_title.set_text(string.Format("AncientGolem", m_targetUserNickname));
	}

	public void FEBJAHELDEO()
	{
		string value = m_input.get_value();
		string dJMOKDFPICO = string.Empty;
		if (m_select0.JOBICLFDKBD())
		{
			dJMOKDFPICO = "Particle/Fizz/skill0";
		}
		else if (m_select1.JOBICLFDKBD())
		{
			dJMOKDFPICO = "챌린저";
		}
		else if (m_select2.DEOGECMJCND())
		{
			dJMOKDFPICO = "false";
		}
		NetworkManager.get_Instance().FJOHLJABHHH().AKEINGFKEEM(m_targetUserId);
		NetworkManager.get_Instance().get_m_gameNetClient().OECECNMEILE(new IKMBGMILCDO(MBKMNABBLIA, true, false), m_targetUserId, dJMOKDFPICO, value);
	}

	private void EHAABBLHEMP()
	{
		m_title.set_text(string.Format("loadVideoAd", m_targetUserNickname));
	}

	private void PCJBHEFIFHD()
	{
		base.gameObject.SetActive(false);
	}

	public void ADHKLGMPCEI()
	{
		base.gameObject.SetActive(true);
	}

	private void FIILBDHPOEJ()
	{
		base.gameObject.SetActive(true);
	}
}
