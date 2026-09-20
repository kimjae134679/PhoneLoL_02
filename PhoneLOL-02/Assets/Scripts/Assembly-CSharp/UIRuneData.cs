using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class UIRuneData : MonoBehaviour
{
	public UILabel m_nameLabel;

	public UILabel m_descriptionLabel;

	public UILabel m_priceLabel;

	public UILabel m_countLabel;

	public UILabel m_saleLabel;

	public UISprite m_iconSprite;

	private CLJOMPBCNOE GNPBKLPHEKD;

	public CLJOMPBCNOE MIMHEOMPECI
	{
		get
		{
			return get_m_runeData();
		}
		protected set
		{
			LCGJFOMHIPC(value);
		}
	}

	private void KNGFEBENEIL(CLJOMPBCNOE NEPGLNCIBJM)
	{
		NetworkManager.get_Instance().get_m_gameNetClient().GCPEKJEFAJH(new IKMBGMILCDO(OIPIABGNBHJ), NEPGLNCIBJM.KGHMFHDGNEO());
	}

	[SpecialName]
	protected void KAKBNOHABON(CLJOMPBCNOE ICENKPDOHBK)
	{
		GNPBKLPHEKD = ICENKPDOHBK;
	}

	private void NCPEAMGOIMB(CLJOMPBCNOE NEPGLNCIBJM)
	{
		NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GCPEKJEFAJH(new IKMBGMILCDO(OIPIABGNBHJ, true, false), NEPGLNCIBJM.KGHMFHDGNEO());
	}

	private void PNGAKJBOKOJ(CLJOMPBCNOE NEPGLNCIBJM)
	{
		NetworkManager.get_Instance().get_m_gameNetClient().GCPEKJEFAJH(new IKMBGMILCDO(BKKAMNKNOBP), NEPGLNCIBJM.KGHMFHDGNEO());
	}

	protected void LCGJFOMHIPC(CLJOMPBCNOE ICENKPDOHBK)
	{
		GNPBKLPHEKD = ICENKPDOHBK;
	}

	[CompilerGenerated]
	private void KCLIIMAJGIG()
	{
		PNGAKJBOKOJ(get_m_runeData());
	}

	[SpecialName]
	public CLJOMPBCNOE PLMELJGKNHD()
	{
		return GNPBKLPHEKD;
	}

	public void BOJEFAHLEFP()
	{
		if (KIMJPIBNFGA.JEAHGHCNKJC())
		{
			MsgManager.get_Instance().ShowMessageBox(string.Format(LocalizationManager.LGDEHELDENG().GetText("android"), LocalizationManager.LGDEHELDENG().TranslateRuneName(PLMELJGKNHD().GAFNNDHJDAE), PLMELJGKNHD().MGGCDFHFMKK / 4), false, KOGGJCAJCKA);
			return;
		}
		MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format(LocalizationManager.LGDEHELDENG().GetText("CreateSkill3Missile"), LocalizationManager.get_Instance().TranslateRuneName(PLMELJGKNHD().GAFNNDHJDAE), get_m_runeData().MGGCDFHFMKK), false, () =>
		{
			PNGAKJBOKOJ(get_m_runeData());
		});
	}

	private void BKKAMNKNOBP(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((HGBGJMIFCEP)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case HGBGJMIFCEP.Success:
		{
			ushort iKHBHNCPDLB = HMOAHNANKNE.AJPFAAFLHEB();
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(HMOAHNANKNE.GAGNPBAMJLE());
			EEEFEGCDGMO oGBMNJBOPHK = NetworkManager.get_Instance().get_m_gameNetClient().DAGCAFAEABC()
				.PGNKPIFFMJE(iKHBHNCPDLB, 1u);
			HMOAHNANKNE.CAHACMKBJMI(oGBMNJBOPHK);
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("구매에 성공하였습니다!"));
			UIRoot.Broadcast("Refresh");
			break;
		}
		case HGBGJMIFCEP.NotEnoughCoin:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("코인이 부족합니다."));
			break;
		case HGBGJMIFCEP.NotEnoughLevel:
			MsgManager.get_Instance().ShowMessageBox(string.Format("구입가능한 레벨이 부족합니다.\n\n최소 {0}레벨 이상 구입가능", get_m_runeData().FLNFNOEDLFN));
			break;
		case HGBGJMIFCEP.MaxCount:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("구입 가능한 최대 개수를 초과하였습니다."));
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("알려지지 않은 오류입니다."));
			break;
		}
	}

	private void Update()
	{
	}

	private void DIGMFKFGDJC(CLJOMPBCNOE NEPGLNCIBJM)
	{
		NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GCPEKJEFAJH(new IKMBGMILCDO(OIPIABGNBHJ), NEPGLNCIBJM.KGHMFHDGNEO());
	}

	public void OnClick()
	{
		if (KIMJPIBNFGA.JEAHGHCNKJC())
		{
			MsgManager.get_Instance().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("{0}\n{1} 코인 [CCCCFF](50%할인)[-]\n\n룬을 구입하시겠습니까?"), LocalizationManager.get_Instance().TranslateRuneName(get_m_runeData().GAFNNDHJDAE), get_m_runeData().MGGCDFHFMKK / 2), true, () =>
			{
				PNGAKJBOKOJ(get_m_runeData());
			});
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("{0}\n{1} 코인\n\n룬을 구입하시겠습니까?"), LocalizationManager.get_Instance().TranslateRuneName(get_m_runeData().GAFNNDHJDAE), get_m_runeData().MGGCDFHFMKK), true, () =>
			{
				PNGAKJBOKOJ(get_m_runeData());
			});
		}
	}

	private void GOLOMEGDPAH()
	{
	}

	public CLJOMPBCNOE get_m_runeData()
	{
		return GNPBKLPHEKD;
	}

	[CompilerGenerated]
	private void PLCOAPPPJGD()
	{
		PNGAKJBOKOJ(get_m_runeData());
	}

	private void KOGGJCAJCKA()
	{
		KNGFEBENEIL(get_m_runeData());
	}

	private void Start()
	{
		base.gameObject.AddComponent<UIEventTrigger>();
	}

	public void LBNEJJNDDNB()
	{
		if (KIMJPIBNFGA.JEAHGHCNKJC())
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format(LocalizationManager.LGDEHELDENG().GetText("attack_missile"), LocalizationManager.LGDEHELDENG().HEIPGKGOBMM(get_m_runeData().GAFNNDHJDAE), get_m_runeData().MGGCDFHFMKK / 4), true, KOGGJCAJCKA);
			return;
		}
		MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("TestKey2"), LocalizationManager.LGDEHELDENG().HEIPGKGOBMM(PLMELJGKNHD().GAFNNDHJDAE), get_m_runeData().MGGCDFHFMKK), false, () =>
		{
			PNGAKJBOKOJ(get_m_runeData());
		});
	}

	public void SetInfo(CLJOMPBCNOE NEPGLNCIBJM)
	{
		LCGJFOMHIPC(NEPGLNCIBJM);
		m_nameLabel.set_text(LocalizationManager.get_Instance().TranslateRuneName(get_m_runeData().GAFNNDHJDAE));
		m_descriptionLabel.set_text(LocalizationManager.get_Instance().TranslateWords(get_m_runeData().OEGAJKFKOEP()));
		int num = NetworkManager.get_Instance().get_m_gameNetClient().DAGCAFAEABC()
			.OAHFGIGJHHC(get_m_runeData().KGHMFHDGNEO());
		if (num > 0)
		{
			m_countLabel.set_text(num.ToString());
			m_countLabel.gameObject.SetActive(true);
		}
		else
		{
			m_countLabel.gameObject.SetActive(false);
		}
		m_iconSprite.set_spriteName(string.Format("{0}_{1}", (byte)get_m_runeData().ONJCKKLOJIA(), (byte)get_m_runeData().EAPFGGJOPEJ()));
		if (KIMJPIBNFGA.JEAHGHCNKJC())
		{
			m_priceLabel.set_text(string.Format("{0} {1}", get_m_runeData().MGGCDFHFMKK / 2, LocalizationManager.get_Instance().GetText("코인")));
			m_saleLabel.gameObject.SetActive(true);
		}
		else
		{
			m_priceLabel.set_text(string.Format("{0} {1}", get_m_runeData().MGGCDFHFMKK, LocalizationManager.get_Instance().GetText("코인")));
			m_saleLabel.gameObject.SetActive(false);
		}
	}

	private void MLOKLGPGKMO()
	{
	}

	private void OIPIABGNBHJ(PJEMPFEIOAK HMOAHNANKNE)
	{
		switch ((int)HMOAHNANKNE.KFAGPDGHEBK())
		{
		case 1:
		{
			ushort iKHBHNCPDLB = HMOAHNANKNE.AJPFAAFLHEB();
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(HMOAHNANKNE.GAGNPBAMJLE());
			EEEFEGCDGMO oGBMNJBOPHK = NetworkManager.get_Instance().IOJGPDKHAGD().DAGCAFAEABC()
				.PGNKPIFFMJE(iKHBHNCPDLB, 0u);
			HMOAHNANKNE.ILFEGIPCAHH(oGBMNJBOPHK);
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("share"), true);
			UIRoot.CHLLIEHMINE("SDKTestCategory");
			break;
		}
		case -64:
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("skill0_missile_c1"));
			break;
		case -108:
			MsgManager.get_Instance().ShowMessageBox(string.Format("round_button", get_m_runeData().FLNFNOEDLFN));
			break;
		case -25:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("sound"), true);
			break;
		default:
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("skill1"));
			break;
		}
	}
}
