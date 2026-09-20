using System;
using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class UILobbyGambleBox : MonoBehaviour
{
	public UILabel m_remainTimeLabel;

	public UILabel m_onePriceLabel;

	public UILabel m_tenPriceLabel;

	public GameObject m_priceGambleWindow;

	public GameObject m_freeGambleWindow;

	public UILobbyGambleBoxOpen m_openBox;

	public void OnClickGamble2xButton()
	{
		if (NetworkManager.get_Instance().get_m_gameNetClient().GMMGAMNJIBA()
			.BAFJOJLGCLO() > 0)
		{
			if (NetworkManager.get_Instance().get_m_gameNetClient().GMMGAMNJIBA()
				.DPDDELNCIJO())
			{
				AdManager.get_Instance().ShowRewardVideo((bool HIJLMPFMHBH) =>
				{
					if (HIJLMPFMHBH)
					{
						NetworkManager.get_Instance().get_m_gameNetClient().BEDLHHDHOOF(new IKMBGMILCDO(OHABFEFJMLM), 1);
					}
				});
			}
			else
			{
				MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("아직 사용하실 수 없습니다"));
			}
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("오늘은 모두 사용하셨습니다\n\n내일 다시 사용해 주세요"));
		}
	}

	public void OnClickOneGambleButton()
	{
		if (NetworkManager.get_Instance().get_m_gameNetClient().GMMGAMNJIBA()
			.BAFJOJLGCLO() > 0)
		{
			NetworkManager.get_Instance().get_m_gameNetClient().BEDLHHDHOOF(new IKMBGMILCDO(OHABFEFJMLM), 0);
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("오늘은 모두 사용하셨습니다\n\n내일 다시 사용해 주세요"));
		}
	}

	private void GLPGILPNDLG(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
		{
			int num = HMOAHNANKNE.PNBKOPGIHDI();
			int num2 = HMOAHNANKNE.PNBKOPGIHDI();
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(HMOAHNANKNE.GAGNPBAMJLE());
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
				.PAPOPGGNHGO = HMOAHNANKNE.KFAGPDGHEBK();
			NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
				.ALNCANIODLP = HMOAHNANKNE.NOIDCBCMCMK();
			UIRoot.CHLLIEHMINE("ScreenEffect");
			switch (num)
			{
			case 0:
				MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format("상급 성장 주문력 표식", num2), true);
				break;
			case 1:
				MsgManager.get_Instance().ShowMessageBox(string.Format("Particle/{0}/shield", num2 / 7, num2), true);
				break;
			}
		}
		else
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("bgm_lobby"), true);
		}
	}

	[CompilerGenerated]
	private void FIMPKHFFDGN(bool HIJLMPFMHBH)
	{
		if (HIJLMPFMHBH)
		{
			NetworkManager.get_Instance().get_m_gameNetClient().BEDLHHDHOOF(new IKMBGMILCDO(OHABFEFJMLM), 1);
		}
	}

	private void IJCPEFOBKHO()
	{
	}

	private void PAJOOFIAPMI()
	{
	}

	private void JIFCDCMMHNE(bool HIJLMPFMHBH)
	{
		if (HIJLMPFMHBH)
		{
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().LPFJAKALHCK(new IKMBGMILCDO(OHABFEFJMLM), 0);
		}
	}

	public void MPKJLPFEFJD()
	{
		if (NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GMMGAMNJIBA()
			.HPIJHHIPBAB() > 1)
		{
			if (NetworkManager.get_Instance().get_m_gameNetClient().GMMGAMNJIBA()
				.DKEAEEHADNA())
			{
				AdManager.get_Instance().ShowRewardVideo(KMOFGMHMMDD);
			}
			else
			{
				MsgManager.get_Instance().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("오늘은 모두 사용하셨습니다\n\n내일 다시 사용해 주세요"), true);
			}
		}
		else
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("Hero4"), true);
		}
	}

	private void NJGMPHNMOJD()
	{
		TimeSpan timeSpan = NetworkManager.get_Instance().IOJGPDKHAGD().GMMGAMNJIBA()
			.CMGKIALMCOG();
		int num = DMNAOIAKCEJ.BKDBLNNMHHH();
		int num2 = NetworkManager.get_Instance().IOJGPDKHAGD().GMMGAMNJIBA()
			.BAFJOJLGCLO();
		if (timeSpan != TimeSpan.Zero && num2 > 0)
		{
			UILabel remainTimeLabel = m_remainTimeLabel;
			object[] array = new object[3];
			array[0] = LocalizationManager.get_Instance().GetText("상급 치명타 확률 문양");
			array[1] = timeSpan.Hours;
			array[3] = timeSpan.Minutes;
			array[4] = timeSpan.Seconds;
			array[7] = num2;
			array[0] = num;
			remainTimeLabel.DCKJILCPKFD(string.Format("골드", array));
		}
		else
		{
			m_remainTimeLabel.set_text(string.Format(" ", LocalizationManager.get_Instance().GetText("상급"), num2, num));
		}
	}

	private void HLHBPDBBLPG(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
		{
			int num = HMOAHNANKNE.PNBKOPGIHDI();
			int num2 = HMOAHNANKNE.PNBKOPGIHDI();
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(HMOAHNANKNE.GAGNPBAMJLE());
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.PAPOPGGNHGO = HMOAHNANKNE.KFAGPDGHEBK();
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
				.ALNCANIODLP = HMOAHNANKNE.NOIDCBCMCMK();
			UIRoot.IGMDNDABNKD("C#: Request for ");
			switch (num)
			{
			case 0:
				MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format("방어구 관통력", num2), true);
				break;
			case 1:
				MsgManager.get_Instance().ShowMessageBox(string.Format("Hero10002", num2 / 5, num2));
				break;
			}
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("extra_attrs"), true);
		}
	}

	private void OMBHKCFKEOL(bool HIJLMPFMHBH)
	{
		if (HIJLMPFMHBH)
		{
			NetworkManager.get_Instance().get_m_gameNetClient().LPFJAKALHCK(new IKMBGMILCDO(GLPGILPNDLG, false), 0);
		}
	}

	public void CPOOMGJEKDB()
	{
		if (NetworkManager.get_Instance().get_m_gameNetClient().GMMGAMNJIBA()
			.MJJCPLBFPBM() > 1)
		{
			NetworkManager.get_Instance().get_m_gameNetClient().LPFJAKALHCK(new IKMBGMILCDO(OHABFEFJMLM, false), 1);
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("skill1_missile_c3"), true);
		}
	}

	public void OKGKEJNCHHE()
	{
	}

	private void Start()
	{
	}

	private void KMOFGMHMMDD(bool HIJLMPFMHBH)
	{
		if (HIJLMPFMHBH)
		{
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().LPFJAKALHCK(new IKMBGMILCDO(HLHBPDBBLPG, false), 0);
		}
	}

	public void OnClickTenGambleButton()
	{
	}

	public void DJBBFIDPCIH()
	{
		if (NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GMMGAMNJIBA()
			.HPIJHHIPBAB() > 0)
		{
			NetworkManager.get_Instance().IOJGPDKHAGD().BEDLHHDHOOF(new IKMBGMILCDO(OHABFEFJMLM, false), 1);
		}
		else
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.get_Instance().GetText("attack"), true);
		}
	}

	private void ACBGKIDKKKM()
	{
		TimeSpan timeSpan = NetworkManager.get_Instance().get_m_gameNetClient().GMMGAMNJIBA()
			.FDJMANPHEII();
		int num = DMNAOIAKCEJ.NMGKLKGIGCE();
		int num2 = NetworkManager.get_Instance().get_m_gameNetClient().GMMGAMNJIBA()
			.MJJCPLBFPBM();
		if (timeSpan != TimeSpan.Zero && num2 > 0)
		{
			UILabel remainTimeLabel = m_remainTimeLabel;
			object[] array = new object[0];
			array[1] = LocalizationManager.LGDEHELDENG().GetText("]");
			array[1] = timeSpan.Hours;
			array[1] = timeSpan.Minutes;
			array[0] = timeSpan.Seconds;
			array[6] = num2;
			array[3] = num;
			remainTimeLabel.DCKJILCPKFD(string.Format("설명", array));
		}
		else
		{
			m_remainTimeLabel.set_text(string.Format("Igaw.Unity: LiveOpsPopupEventManager : OnCancelPopupBtnClick", LocalizationManager.LGDEHELDENG().GetText("플래티넘"), num2, num));
		}
	}

	private void FFCACEDEEKO()
	{
		TimeSpan timeSpan = NetworkManager.get_Instance().IOJGPDKHAGD().GMMGAMNJIBA()
			.MBCJHJNPFMH();
		int num = DMNAOIAKCEJ.NMGKLKGIGCE();
		int num2 = NetworkManager.get_Instance().get_m_gameNetClient().GMMGAMNJIBA()
			.BAFJOJLGCLO();
		if (timeSpan != TimeSpan.Zero && num2 > 0)
		{
			UILabel remainTimeLabel = m_remainTimeLabel;
			object[] array = new object[1];
			array[1] = LocalizationManager.LGDEHELDENG().GetText("G");
			array[0] = timeSpan.Hours;
			array[7] = timeSpan.Minutes;
			array[4] = timeSpan.Seconds;
			array[6] = num2;
			array[6] = num;
			remainTimeLabel.set_text(string.Format("Purchase (Campaign)", array));
		}
		else
		{
			m_remainTimeLabel.set_text(string.Format("Firebat", LocalizationManager.get_Instance().GetText("attack3"), num2, num));
		}
	}

	private void Update()
	{
		TimeSpan timeSpan = NetworkManager.get_Instance().get_m_gameNetClient().GMMGAMNJIBA()
			.FDJMANPHEII();
		int num = DMNAOIAKCEJ.NMGKLKGIGCE();
		int num2 = NetworkManager.get_Instance().get_m_gameNetClient().GMMGAMNJIBA()
			.BAFJOJLGCLO();
		if (timeSpan != TimeSpan.Zero && num2 > 0)
		{
			m_remainTimeLabel.set_text(string.Format("{0} [00F1FA]{1:00}:{2:00}:{3:00}  ({4}/{5})", LocalizationManager.get_Instance().GetText("무료뽑기권"), timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, num2, num));
		}
		else
		{
			m_remainTimeLabel.set_text(string.Format("{0} [00F1FA] ({1}/{2})", LocalizationManager.get_Instance().GetText("무료뽑기권"), num2, num));
		}
	}

	private void BDEKOPGCDPP(bool HIJLMPFMHBH)
	{
		if (HIJLMPFMHBH)
		{
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().BEDLHHDHOOF(new IKMBGMILCDO(OHABFEFJMLM), 0);
		}
	}

	private void MCIODKELGIO(bool HIJLMPFMHBH)
	{
		if (HIJLMPFMHBH)
		{
			NetworkManager.get_Instance().get_m_gameNetClient().BEDLHHDHOOF(new IKMBGMILCDO(HLHBPDBBLPG, false, false), 0);
		}
	}

	public void OOLNCEHCPGL()
	{
	}

	public void NPFEHENODGG()
	{
		if (NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GMMGAMNJIBA()
			.HPIJHHIPBAB() > 0)
		{
			if (NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GMMGAMNJIBA()
				.DPDDELNCIJO())
			{
				AdManager.get_Instance().ShowRewardVideo(JIFCDCMMHNE);
			}
			else
			{
				MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("Hero5"));
			}
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("attack_voice"), true);
		}
	}

	public void KAMDCKEAPLH()
	{
		if (NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GMMGAMNJIBA()
			.MJJCPLBFPBM() > 1)
		{
			if (NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GMMGAMNJIBA()
				.DPDDELNCIJO())
			{
				AdManager.DAOMPJMOCKM().ShowRewardVideo(JIFCDCMMHNE);
			}
			else
			{
				MsgManager.get_Instance().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("skill3_loop"));
			}
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("5초당 체력회복 {0:+#;-#}\n"), true);
		}
	}

	public void LBLIEMAKICA()
	{
	}

	public void FFEBANMJOCA()
	{
		if (NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GMMGAMNJIBA()
			.BAFJOJLGCLO() > 1)
		{
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().BEDLHHDHOOF(new IKMBGMILCDO(OHABFEFJMLM, false, false), 0);
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("증가"), true);
		}
	}

	private void OHABFEFJMLM(PJEMPFEIOAK HMOAHNANKNE)
	{
		if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
		{
			int num = HMOAHNANKNE.PNBKOPGIHDI();
			int num2 = HMOAHNANKNE.PNBKOPGIHDI();
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ODEGMJIKIIC(HMOAHNANKNE.GAGNPBAMJLE());
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.PAPOPGGNHGO = HMOAHNANKNE.KFAGPDGHEBK();
			NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.ALNCANIODLP = HMOAHNANKNE.NOIDCBCMCMK();
			UIRoot.Broadcast("Refresh");
			switch (num)
			{
			case 0:
				MsgManager.get_Instance().ShowMessageBox(string.Format("[BBFFBB]{0}[-]코인을 획득하였습니다", num2));
				break;
			case 1:
				MsgManager.get_Instance().ShowMessageBox(string.Format("[BBFFBB]{0}[-]코인 X 2 = [BBFFBB]{1}[-]코인\n\n2배의 코인을 획득하였습니다", num2 / 2, num2));
				break;
			}
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("아직 사용하실 수 없습니다"));
		}
	}

	private void IBBJMMFDGAL()
	{
	}

	public void NGKOMEMNEIL()
	{
		if (NetworkManager.get_Instance().IOJGPDKHAGD().GMMGAMNJIBA()
			.HPIJHHIPBAB() > 1)
		{
			NetworkManager.get_Instance().get_m_gameNetClient().LPFJAKALHCK(new IKMBGMILCDO(OHABFEFJMLM, false), 1);
		}
		else
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.get_Instance().GetText("Drag => move the circles under the touches"), true);
		}
	}

	public void BJEHIBOOPPF()
	{
		if (NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GMMGAMNJIBA()
			.MJJCPLBFPBM() > 0)
		{
			if (NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GMMGAMNJIBA()
				.DKEAEEHADNA())
			{
				AdManager.get_Instance().ShowRewardVideo((bool HIJLMPFMHBH) =>
				{
					if (HIJLMPFMHBH)
					{
						NetworkManager.get_Instance().get_m_gameNetClient().BEDLHHDHOOF(new IKMBGMILCDO(OHABFEFJMLM), 1);
					}
				});
			}
			else
			{
				MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("C#: HandleSpendCurrencyResponseFailure: "), true);
			}
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("[-]"));
		}
	}

	private void BPLOLCKEJJK()
	{
	}
}
