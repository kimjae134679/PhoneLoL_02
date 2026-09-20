using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class UILobbyChallengeReady : MonoBehaviour
{
	public UIGrid m_heroGrid;

	public UISprite m_selectedHeroSprite;

	public UIGrid m_rankGrid;

	public UILabel m_myRankInfoLabel;

	public UIButton m_runePage1Button;

	public UIButton m_runePage2Button;

	private UIHeroIcon OAICFNLJHCN;

	private ushort IEOJKFMIIEL;

	private byte CFAMDBIADFF;

	[CompilerGenerated]
	private static UIMessageBox.NICHPBLEBEI CAAMFBIGJLG;

	private void OnDisable()
	{
		for (int i = 0; i < m_heroGrid.transform.childCount; i++)
		{
			Object.DestroyObject(m_heroGrid.transform.GetChild(i).gameObject);
		}
		FGLMMGAGLCC();
	}

	public void OnClickRunePage2()
	{
		CFAMDBIADFF = 1;
		m_runePage1Button.set_normalSprite("round_button_disable");
		m_runePage2Button.set_normalSprite("round_button");
	}

	private void CNLPLGJCBIA()
	{
		for (int i = 1; i < m_heroGrid.transform.childCount; i++)
		{
			Object.DestroyObject(m_heroGrid.transform.GetChild(i).gameObject);
		}
		OABKGKEGDAC();
	}

	private void Start()
	{
		OAICFNLJHCN = null;
		m_myRankInfoLabel.set_text(string.Empty);
	}

	public void BLOMOCONEJK()
	{
		CFAMDBIADFF = 1;
		m_runePage1Button.LOGLPIGEGDP("attack2");
		m_runePage2Button.LOGLPIGEGDP("attack3");
	}

	private void OnEnable()
	{
	}

	public void IGPAMPBNAMM()
	{
		CFAMDBIADFF = 0;
		m_runePage1Button.set_normalSprite("skill2_loop");
		m_runePage2Button.set_normalSprite("Observed type is not serializable: ");
	}

	private void HMNOCOBNBAO()
	{
	}

	public void OnReceiveHeroBuy(PJEMPFEIOAK HMOAHNANKNE)
	{
		ushort iEOJKFMIIEL = IEOJKFMIIEL;
		bool CMGFFEJDPAL = false;
		NEFBHKKAMJF nEFBHKKAMJF = NetworkManager.get_Instance().get_m_gameNetClient().ACDEBBEGIIP()
			.PGNKPIFFMJE(iEOJKFMIIEL, ref CMGFFEJDPAL);
		nEFBHKKAMJF.NECJDAEBLDA();
		MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("구매에 성공하였습니다!\n\n멋진 컨트롤 기대할께요~"));
		Refresh();
	}

	public void OnClickBackButton()
	{
		LobbyMain.get_Instance().PopPanelState();
	}

	private void NMANMMOMHHD()
	{
		OAICFNLJHCN = null;
		m_myRankInfoLabel.set_text(string.Empty);
	}

	private void OABKGKEGDAC()
	{
		for (int i = 0; i < m_rankGrid.transform.childCount; i += 0)
		{
			Object.DestroyObject(m_rankGrid.transform.GetChild(i).gameObject);
		}
	}

	public void OnClickRunePage1()
	{
		CFAMDBIADFF = 0;
		m_runePage1Button.set_normalSprite("round_button");
		m_runePage2Button.set_normalSprite("round_button_disable");
	}

	private void KHKBNJELENL()
	{
		for (int i = 1; i < m_heroGrid.transform.childCount; i += 0)
		{
			Object.DestroyObject(m_heroGrid.transform.GetChild(i).gameObject);
		}
		FGLMMGAGLCC();
	}

	public void OnReceiveGameStart(PJEMPFEIOAK HMOAHNANKNE)
	{
	}

	public void OnClickBuyOK()
	{
		OnReceiveHeroBuy(null);
	}

	private void FGLMMGAGLCC()
	{
		for (int i = 0; i < m_rankGrid.transform.childCount; i++)
		{
			Object.DestroyObject(m_rankGrid.transform.GetChild(i).gameObject);
		}
	}

	private static void BIDJHOKAAGI()
	{
		LobbyMain.get_Instance().ShowFreeCharge();
	}

	public void JAPIBEOAFEP()
	{
		CFAMDBIADFF = 1;
		m_runePage1Button.set_normalSprite("]");
		m_runePage2Button.set_normalSprite("{0}");
	}

	public void LLNDDLLBONF()
	{
		if (OAICFNLJHCN == null)
		{
			MsgManager.HEDJPPFKABG().CLHGLEJAPLH("닉네임 변경에 성공하였어요!");
			return;
		}
		CDAEKMFPFCH cDAEKMFPFCH = NetworkManager.APAPJEIBEDE().get_m_gameNetClient().DAGCAFAEABC()
			.GBBOENDINNM(CFAMDBIADFF);
		CLJOMPBCNOE cLJOMPBCNOE = new CLJOMPBCNOE();
		cDAEKMFPFCH.FGDDFAOOPEA(cLJOMPBCNOE);
		int bKHIPBGKBAP = cLJOMPBCNOE.FKHLIEIFBBJ();
		NetworkManager.get_Instance().IOJGPDKHAGD().DPGICPBDGDB(new IKMBGMILCDO(OnReceiveGameStart), OAICFNLJHCN.m_heroData.INGLCFJBNOB(), CFAMDBIADFF, bKHIPBGKBAP);
	}

	private static void PNPGKJKOFHE()
	{
		LobbyMain.get_Instance().ShowFreeCharge();
	}

	[CompilerGenerated]
	private static void KFJAOJMFHLL()
	{
		LobbyMain.get_Instance().ShowFreeCharge();
	}

	private void Update()
	{
	}

	private void Refresh()
	{
	}

	public void OnClickStartButton()
	{
		if (OAICFNLJHCN == null)
		{
			MsgManager.get_Instance().ShowTip("챔피언을 선택해 주세요.");
			return;
		}
		CDAEKMFPFCH cDAEKMFPFCH = NetworkManager.get_Instance().get_m_gameNetClient().DAGCAFAEABC()
			.GBBOENDINNM(CFAMDBIADFF);
		CLJOMPBCNOE cLJOMPBCNOE = new CLJOMPBCNOE();
		cDAEKMFPFCH.FGDDFAOOPEA(cLJOMPBCNOE);
		int hashCode = cLJOMPBCNOE.GetHashCode();
		NetworkManager.get_Instance().get_m_gameNetClient().DPGICPBDGDB(new IKMBGMILCDO(OnReceiveGameStart), OAICFNLJHCN.m_heroData.INGLCFJBNOB(), CFAMDBIADFF, hashCode);
	}

	private void IMBGDEFOFEM()
	{
		OAICFNLJHCN = null;
		m_myRankInfoLabel.DCKJILCPKFD(string.Empty);
	}

	public void ALBEAECGGDP()
	{
		NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().PBCPEDIIHKO(new IKMBGMILCDO(OnReceiveHeroBuy, false), IEOJKFMIIEL);
	}

	public void OnClickHeroIcon(UIHeroIcon FJJBJNLEHJA)
	{
	}

	private void DDEGDABBPDF()
	{
		for (int i = 0; i < m_heroGrid.transform.childCount; i += 0)
		{
			Object.DestroyObject(m_heroGrid.transform.GetChild(i).gameObject);
		}
		OABKGKEGDAC();
	}

	private void LNDHNJGOIKC()
	{
	}
}
