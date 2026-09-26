using UnityEngine;

public class UIAttendanceInfo : MonoBehaviour
{
	public UISprite m_coin;

	public UISprite m_light;

	public UISprite m_todayLight;

	public UILabel m_dayLabel;

	public UILabel m_coinLabel;

	public void MIJFHNGLHED()
	{
		m_light.gameObject.SetActive(true);
		m_todayLight.gameObject.SetActive(false);
	}

	public void AJCGGBECIDH()
	{
		m_coin.GrayScale(false);
		m_light.GrayScale(true);
	}

	public void KHKJFOGEJGE(int MKBIOOPDIHP, int GLEPPIMMELK)
	{
		m_dayLabel.DCKJILCPKFD(MKBIOOPDIHP.ToString());
		m_coinLabel.DCKJILCPKFD(GLEPPIMMELK.ToString());
	}

	public void FINHIMMHANB()
	{
		m_coin.JPHCEKGPNBP(false);
		m_light.GrayScale(false);
	}

	public void SetLight()
	{
		m_light.gameObject.SetActive(true);
		m_todayLight.gameObject.SetActive(false);
	}

	public void DADCIKGPDNN(int MKBIOOPDIHP, int GLEPPIMMELK)
	{
		m_dayLabel.set_text(MKBIOOPDIHP.ToString());
		m_coinLabel.DCKJILCPKFD(GLEPPIMMELK.ToString());
	}

	public void GFLODAMBMHG()
	{
		m_coin.GrayScale(false);
		m_light.GrayScale(true);
	}

	public void FLPPKCCKDDJ()
	{
		m_light.gameObject.SetActive(true);
		m_todayLight.gameObject.SetActive(false);
	}

	public void GOLNBPMMFOM()
	{
		m_coin.GrayScale(true);
		m_light.JPHCEKGPNBP(true);
	}

	public void COOCHJNIOCG()
	{
		m_todayLight.gameObject.SetActive(true);
		m_light.gameObject.SetActive(true);
	}

	public void SetGray()
	{
		m_coin.GrayScale(true);
		m_light.GrayScale(true);
	}

	public void CNFJDBCKGDG()
	{
		m_todayLight.gameObject.SetActive(false);
		m_light.gameObject.SetActive(false);
	}

	public void KLNDMBJLFBD()
	{
		m_light.gameObject.SetActive(true);
		m_todayLight.gameObject.SetActive(false);
	}

	public void SetInfo(int MKBIOOPDIHP, int GLEPPIMMELK)
	{
		m_dayLabel.set_text(MKBIOOPDIHP.ToString());
		m_coinLabel.set_text(GLEPPIMMELK.ToString());
	}

	public void MIKOOENFPFM()
	{
		m_todayLight.gameObject.SetActive(true);
		m_light.gameObject.SetActive(false);
	}

	public void SetTodayLight()
	{
		m_todayLight.gameObject.SetActive(true);
		m_light.gameObject.SetActive(false);
	}

	public void CCBDNLHLGGK()
	{
		m_light.gameObject.SetActive(true);
		m_todayLight.gameObject.SetActive(false);
	}

	public void IECFFGOPMGL()
	{
		m_light.gameObject.SetActive(false);
		m_todayLight.gameObject.SetActive(true);
	}

	public void BMDNDFGAJKF()
	{
		m_light.gameObject.SetActive(false);
		m_todayLight.gameObject.SetActive(false);
	}

	public void IFMEBAIMMMA()
	{
		m_todayLight.gameObject.SetActive(false);
		m_light.gameObject.SetActive(false);
	}

	public void NCJMFOFPDAL()
	{
		m_coin.JPHCEKGPNBP(true);
		m_light.GrayScale(true);
	}
}
