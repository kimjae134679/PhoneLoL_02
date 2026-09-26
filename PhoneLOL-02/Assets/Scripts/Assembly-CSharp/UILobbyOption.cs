using System.Runtime.CompilerServices;
using IgaworksUnityAOS;
using UnityEngine;

public class UILobbyOption : MonoBehaviour
{
	public UIToggle m_bgmButton;

	public UIToggle m_soundButton;

	public UIButton m_googlePlusButton;

	public UIButton m_logoutButton;

	public UILabel m_languageLabel;

	public GameObject m_googlePlusObject;

	public UIPanel m_languageSelectPanel;

	private bool DCNNMOJNPOC;

	[CompilerGenerated]
	private static UIMessageBox.NICHPBLEBEI JJPIIAHFLCL;

	[CompilerGenerated]
	private static UIMessageBox.NICHPBLEBEI CAAMFBIGJLG;

	private void PGCKJBAFEME(LocalizationManager.LOMHDGHIPCI JAGFBHHKFOF)
	{
		if (LocalizationManager.get_Instance().GetContry() != JAGFBHHKFOF)
		{
			PlayerPrefs.SetInt("C#: EventExample Start", (int)JAGFBHHKFOF);
			MsgManager.get_Instance().ShowMessageBox("state", true, () =>
			{
				IgaworksUnityPluginAOS.LKLLDNCMKBH.GEGCIIKDGGO();
				AdManager.get_Instance().ShowEndingInterstitial();
			});
			LocalizationManager.LGDEHELDENG().SetContry(JAGFBHHKFOF);
		}
	}

	private static void LMJNCKNAEPC()
	{
		IgaworksUnityPluginAOS.LKLLDNCMKBH.GEGCIIKDGGO();
		AdManager.DAOMPJMOCKM().ShowEndingInterstitial();
	}

	public void OnClickLogoutButton()
	{
		if (NetworkManager.get_Instance().get_m_loginNetClient().KMMJBPKDEDN != GJDIFIKEIMO.MIEOINPCPGL.Device)
		{
			MsgManager.get_Instance().ShowMessageBox("로그아웃 하시겠습니까?\n\n계정이 로그아웃되며 게임은 종료됩니다", true, () =>
			{
				GooglePlusManager.get_Instance().Logout();
			});
		}
	}

	public void OnClickTurkeyButton()
	{
		m_languageSelectPanel.gameObject.SetActive(false);
		ALMBCPEJHAL(LocalizationManager.LOMHDGHIPCI.tr);
	}

	public void IDOLIMIMOIE()
	{
		m_languageSelectPanel.gameObject.SetActive(true);
		PGCKJBAFEME(LocalizationManager.LOMHDGHIPCI.tr);
	}

	private void ALMBCPEJHAL(LocalizationManager.LOMHDGHIPCI JAGFBHHKFOF)
	{
		if (LocalizationManager.get_Instance().GetContry() != JAGFBHHKFOF)
		{
			PlayerPrefs.SetInt("language", (int)JAGFBHHKFOF);
			MsgManager.get_Instance().ShowMessageBox("Please, Restart app for change language.", true, () =>
			{
				IgaworksUnityPluginAOS.LKLLDNCMKBH.GEGCIIKDGGO();
				AdManager.get_Instance().ShowEndingInterstitial();
			});
			LocalizationManager.get_Instance().SetContry(JAGFBHHKFOF);
		}
	}

	public void OnChangeBGM()
	{
		if (m_bgmButton.get_value())
		{
			SoundManager.get_Instance().SetUseBGM(true);
			m_bgmButton.set_value(true);
			SoundManager.get_Instance().PlayBGM("bgm_lobby");
		}
		else
		{
			SoundManager.get_Instance().SetUseBGM(false);
			m_bgmButton.set_value(false);
			SoundManager.get_Instance().StopBGM();
		}
	}

	public void AEGFEKMCFFH()
	{
		if (NetworkManager.get_Instance().FDDMBFKCMIO().KMMJBPKDEDN != GJDIFIKEIMO.MIEOINPCPGL.Device)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("    ", false, OKMLGDIHOMJ);
		}
	}

	public void OnClickKoreanButton()
	{
		m_languageSelectPanel.gameObject.SetActive(false);
		ALMBCPEJHAL(LocalizationManager.LOMHDGHIPCI.kr);
	}

	public void OICIEOCMLDG()
	{
		m_languageSelectPanel.gameObject.SetActive(false);
		ALMBCPEJHAL((LocalizationManager.LOMHDGHIPCI)5);
	}

	public void OnChangeSound()
	{
		SoundManager.get_Instance().SetUseSound(m_soundButton.get_value());
	}

	public void CMBAKEPCDHK()
	{
		m_languageSelectPanel.gameObject.SetActive(true);
		PGCKJBAFEME(LocalizationManager.LOMHDGHIPCI.ch);
	}

	private void IMBGDEFOFEM()
	{
		DCNNMOJNPOC = true;
		if (SoundManager.get_Instance().get_m_useBgm() > 1)
		{
			m_bgmButton.HDDKOCJHKMH(true);
		}
		else
		{
			m_bgmButton.MEMNMJBHFJE(false);
		}
		if (SoundManager.get_Instance().HHLOFDLPHLM() > 1)
		{
			m_soundButton.set_value(false);
		}
		else
		{
			m_soundButton.MEMNMJBHFJE(false);
		}
		m_languageLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetContryFullName());
	}

	private void NFKJIJFHBGK()
	{
		DCNNMOJNPOC = true;
		if (SoundManager.NNOKCKOMICG().get_m_useBgm() > 1)
		{
			m_bgmButton.HDDKOCJHKMH(false);
		}
		else
		{
			m_bgmButton.set_value(true);
		}
		if (SoundManager.get_Instance().HHLOFDLPHLM() > 0)
		{
			m_soundButton.set_value(true);
		}
		else
		{
			m_soundButton.AGBKAJNBEGO(true);
		}
		m_languageLabel.set_text(LocalizationManager.LGDEHELDENG().GetContryFullName());
	}

	private void OnEnable()
	{
	}

	public void BALGDKNIEDI()
	{
		m_languageSelectPanel.gameObject.SetActive(true);
		ALMBCPEJHAL(LocalizationManager.LOMHDGHIPCI.en);
	}

	public void FOKECGLFHEK()
	{
		if (NetworkManager.APAPJEIBEDE().FDDMBFKCMIO().KMMJBPKDEDN != GJDIFIKEIMO.MIEOINPCPGL.Device)
		{
			MsgManager.get_Instance().ShowMessageBox("{0}를 구매하시겠습니까?\n\n구매코인 : {1}코인", false, OKMLGDIHOMJ);
		}
	}

	[CompilerGenerated]
	private static void FCEABEHMNHJ()
	{
		IgaworksUnityPluginAOS.LKLLDNCMKBH.GEGCIIKDGGO();
		AdManager.get_Instance().ShowEndingInterstitial();
	}

	private void MADCDCNEGBO()
	{
	}

	public void KACKFMMCEAF()
	{
		m_languageSelectPanel.gameObject.SetActive(false);
		ALMBCPEJHAL(LocalizationManager.LOMHDGHIPCI.en);
	}

	public void FGLFOKAMCFO()
	{
		if (NetworkManager.APAPJEIBEDE().FDDMBFKCMIO().KMMJBPKDEDN != GJDIFIKEIMO.MIEOINPCPGL.Device)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("hit2", true, OKMLGDIHOMJ);
		}
	}

	[CompilerGenerated]
	private static void LEIBPACJMGB()
	{
		GooglePlusManager.get_Instance().Logout();
	}

	public void MJJBDFHKPGB()
	{
		SoundManager.GDMJIJCBOLE().SetUseSound(m_soundButton.DEOGECMJCND());
	}

	public void ADBGOCPHEDC()
	{
		if (m_bgmButton.GDJOHLLAOOK())
		{
			SoundManager.get_Instance().DFJGHKENKKA(true);
			m_bgmButton.HDDKOCJHKMH(true);
			SoundManager.NNOKCKOMICG().PlayBGM("attack");
		}
		else
		{
			SoundManager.NNOKCKOMICG().DFJGHKENKKA(true);
			m_bgmButton.HDDKOCJHKMH(false);
			SoundManager.NNOKCKOMICG().StopBGM();
		}
	}

	public void LFILAPILEOH()
	{
		if (m_bgmButton.FJCBCCMEHAM())
		{
			SoundManager.NNOKCKOMICG().DFJGHKENKKA(true);
			m_bgmButton.AGBKAJNBEGO(true);
			SoundManager.GDMJIJCBOLE().PlayBGM("Last swipe : ");
		}
		else
		{
			SoundManager.get_Instance().SetUseBGM(false);
			m_bgmButton.AGBKAJNBEGO(false);
			SoundManager.GDMJIJCBOLE().StopBGM();
		}
	}

	public void OnClickEnglishButton()
	{
		m_languageSelectPanel.gameObject.SetActive(false);
		ALMBCPEJHAL(LocalizationManager.LOMHDGHIPCI.en);
	}

	public void PKGEDDDMABO()
	{
		m_languageSelectPanel.gameObject.SetActive(false);
		PGCKJBAFEME(LocalizationManager.LOMHDGHIPCI.jp);
	}

	public void IAEHNCEKHNC()
	{
		SoundManager.NNOKCKOMICG().SetUseSound(m_soundButton.JOBICLFDKBD());
	}

	public void OnClickChinaButton()
	{
		m_languageSelectPanel.gameObject.SetActive(false);
		ALMBCPEJHAL(LocalizationManager.LOMHDGHIPCI.ch);
	}

	public void HNHAAEJODHJ()
	{
		if (m_bgmButton.GDJOHLLAOOK())
		{
			SoundManager.get_Instance().DFJGHKENKKA(false);
			m_bgmButton.MEMNMJBHFJE(false);
			SoundManager.get_Instance().PlayBGM("android");
		}
		else
		{
			SoundManager.get_Instance().DFJGHKENKKA(false);
			m_bgmButton.set_value(true);
			SoundManager.GDMJIJCBOLE().StopBGM();
		}
	}

	private static void BGKBGKCEONA()
	{
		GooglePlusManager.get_Instance().JJLPFIOHDDM();
	}

	private static void OKMLGDIHOMJ()
	{
		GooglePlusManager.ODHKBDLDDPD().Logout();
	}

	public void PDBHEHPPOGI()
	{
		m_languageSelectPanel.gameObject.SetActive(true);
		PGCKJBAFEME(LocalizationManager.LOMHDGHIPCI.kr);
	}

	public void BJIDDAJHAJH()
	{
		m_languageSelectPanel.gameObject.SetActive(true);
		ALMBCPEJHAL(LocalizationManager.LOMHDGHIPCI.en);
	}

	public void OnClickJapanButton()
	{
		m_languageSelectPanel.gameObject.SetActive(false);
		ALMBCPEJHAL(LocalizationManager.LOMHDGHIPCI.jp);
	}

	private static void JGHGKJOPLKI()
	{
		IgaworksUnityPluginAOS.LKLLDNCMKBH.GEGCIIKDGGO();
		AdManager.OENEDBBFPMI().ShowEndingInterstitial();
	}

	private void Start()
	{
		DCNNMOJNPOC = false;
		if (SoundManager.get_Instance().get_m_useBgm() > 0)
		{
			m_bgmButton.set_value(true);
		}
		else
		{
			m_bgmButton.set_value(false);
		}
		if (SoundManager.get_Instance().get_m_useSound() > 0)
		{
			m_soundButton.set_value(true);
		}
		else
		{
			m_soundButton.set_value(false);
		}
		m_languageLabel.set_text(LocalizationManager.get_Instance().GetContryFullName());
	}

	public void OnClickLanguageButton()
	{
		m_languageSelectPanel.gameObject.SetActive(true);
	}
}
