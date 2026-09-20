using System.Runtime.CompilerServices;
using EveEngine;
using UnityEngine;

public class UIGameMain : MonoBehaviour
{
	private static UIGameMain MLDPFDAHKHA;

	public UIGame m_gamePanel;

	public UIMultiGameResult m_multiResultPanel;

	public UIGameShop m_gameShopPanel;

	public static UIGameMain CJFCFLEHJKI
	{
		get
		{
			return get_Instance();
		}
	}

	public void ALNPJDGOGOA(PJEMPFEIOAK HMOAHNANKNE)
	{
		m_gameShopPanel.gameObject.SetActive(false);
		m_gamePanel.gameObject.SetActive(false);
		m_multiResultPanel.gameObject.SetActive(false);
		m_multiResultPanel.SetInfo(HMOAHNANKNE);
	}

	[SpecialName]
	public static UIGameMain DEBJGLHODJD()
	{
		return MLDPFDAHKHA;
	}

	private void OMIFPPGJHFH()
	{
	}

	private void DNBDGBJNCBP()
	{
	}

	public void FPONDHPKADF(PJEMPFEIOAK HMOAHNANKNE)
	{
		m_gameShopPanel.gameObject.SetActive(false);
		m_gamePanel.gameObject.SetActive(true);
		m_multiResultPanel.gameObject.SetActive(true);
		m_multiResultPanel.BPONBFDJFKH(HMOAHNANKNE);
	}

	[SpecialName]
	public static UIGameMain BBHIJCMCLNL()
	{
		return MLDPFDAHKHA;
	}

	[SpecialName]
	public static UIGameMain PDLHACMKCCJ()
	{
		return MLDPFDAHKHA;
	}

	private void DHMMCEBEAHA()
	{
	}

	private void Update()
	{
	}

	private void JGFFKGLIKBC()
	{
		MLDPFDAHKHA = this;
	}

	private void MFIECLLACAM()
	{
	}

	public void GKKNDBPHNOE(PJEMPFEIOAK HMOAHNANKNE)
	{
		m_gameShopPanel.gameObject.SetActive(false);
		m_gamePanel.gameObject.SetActive(false);
		m_multiResultPanel.gameObject.SetActive(false);
		m_multiResultPanel.SetInfo(HMOAHNANKNE);
	}

	private void CFJKHPNIODE()
	{
		MLDPFDAHKHA = this;
	}

	private void PDEKJHLCJHM()
	{
		MLDPFDAHKHA = this;
	}

	private void IMBGDEFOFEM()
	{
	}

	private void JMPKHMDJLKO()
	{
		MLDPFDAHKHA = this;
	}

	private void ODHEBKCPBPB()
	{
	}

	private void FOGNMJLPHAI()
	{
	}

	private void Awake()
	{
		MLDPFDAHKHA = this;
	}

	[SpecialName]
	public static UIGameMain HEDJPPFKABG()
	{
		return MLDPFDAHKHA;
	}

	private void CLLECEEEJAI()
	{
	}

	private void OOLEODIPDND()
	{
	}

	private void KMJNJLOECGJ()
	{
	}

	private void EICMMILMBPA()
	{
		MLDPFDAHKHA = this;
	}

	public static UIGameMain get_Instance()
	{
		return MLDPFDAHKHA;
	}

	private void CHJGEGLHOAF()
	{
	}

	public void ShowMultiResult(PJEMPFEIOAK HMOAHNANKNE)
	{
		m_gameShopPanel.gameObject.SetActive(false);
		m_gamePanel.gameObject.SetActive(false);
		m_multiResultPanel.gameObject.SetActive(true);
		m_multiResultPanel.SetInfo(HMOAHNANKNE);
	}

	private void Start()
	{
	}

	public void FIMCBKHLAJK(PJEMPFEIOAK HMOAHNANKNE)
	{
		m_gameShopPanel.gameObject.SetActive(false);
		m_gamePanel.gameObject.SetActive(true);
		m_multiResultPanel.gameObject.SetActive(true);
		m_multiResultPanel.DADCIKGPDNN(HMOAHNANKNE);
	}
}
