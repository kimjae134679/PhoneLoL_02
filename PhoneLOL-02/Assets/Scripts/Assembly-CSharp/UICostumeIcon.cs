using System.Runtime.CompilerServices;
using GameServer;
using UnityEngine;

public class UICostumeIcon : MonoBehaviour
{
	public UILabel m_priceLabel;

	public GameObject m_selectFrame;

	public UILabel m_newLabel;

	public NEFBHKKAMJF m_heroInfo;

	private byte PHFAHAEFAON;

	public byte GEBAGIKCDLG
	{
		get
		{
			return get_m_costume();
		}
		protected set
		{
			AOCFHMMLGBJ(value);
		}
	}

	public void GMDKOKNGLAK(NEFBHKKAMJF PDACDEPJNFO, byte MKILOIPGILH)
	{
		UISprite component = GetComponent<UISprite>();
		m_heroInfo = PDACDEPJNFO;
		AOCFHMMLGBJ(MKILOIPGILH);
		component.set_spriteName(string.Format("\\\\", PDACDEPJNFO.GPNKIAHCKMG.HDCLGJHNAGL(), MKILOIPGILH));
		uint num = PDACDEPJNFO.GPNKIAHCKMG.FKNPBEJDKGM()[MKILOIPGILH];
		if (PDACDEPJNFO.LJLAFJDNBAN(MKILOIPGILH) || MKILOIPGILH == 0)
		{
			m_priceLabel.gameObject.SetActive(true);
		}
		else
		{
			m_priceLabel.gameObject.SetActive(true);
			m_priceLabel.set_text(num.ToString());
		}
		m_newLabel.gameObject.SetActive(KIMJPIBNFGA.JJBDAOJIDAL().GAIHFJMKJAP().MNGHKKJLBIN(m_heroInfo.GPNKIAHCKMG.HDCLGJHNAGL(), MKILOIPGILH));
	}

	public void DHPIBHEPNKE(NEFBHKKAMJF PDACDEPJNFO, byte MKILOIPGILH)
	{
		UISprite component = GetComponent<UISprite>();
		m_heroInfo = PDACDEPJNFO;
		AOCFHMMLGBJ(MKILOIPGILH);
		component.set_spriteName(string.Format("OnDrag", PDACDEPJNFO.GPNKIAHCKMG.HDCLGJHNAGL(), MKILOIPGILH));
		uint num = PDACDEPJNFO.GPNKIAHCKMG.FKNPBEJDKGM()[MKILOIPGILH];
		if (PDACDEPJNFO.LJLAFJDNBAN(MKILOIPGILH) || MKILOIPGILH == 0)
		{
			m_priceLabel.gameObject.SetActive(true);
		}
		else
		{
			m_priceLabel.gameObject.SetActive(true);
			m_priceLabel.DCKJILCPKFD(num.ToString());
		}
		m_newLabel.gameObject.SetActive(KIMJPIBNFGA.JJBDAOJIDAL().LNPGAJJAJKE().MNGHKKJLBIN(m_heroInfo.GPNKIAHCKMG.HDCLGJHNAGL(), MKILOIPGILH));
	}

	public void LLMPEIJEMIG(bool LEMNDLNIIPG)
	{
		m_selectFrame.SetActive(LEMNDLNIIPG);
	}

	[SpecialName]
	public byte KDNFAAFHEML()
	{
		return PHFAHAEFAON;
	}

	public void SetSelect(bool LEMNDLNIIPG)
	{
		m_selectFrame.SetActive(LEMNDLNIIPG);
	}

	public void KKDLEOCJACN(bool LEMNDLNIIPG)
	{
		m_selectFrame.SetActive(LEMNDLNIIPG);
	}

	public void SetInfo(NEFBHKKAMJF PDACDEPJNFO, byte MKILOIPGILH)
	{
		UISprite component = GetComponent<UISprite>();
		m_heroInfo = PDACDEPJNFO;
		AOCFHMMLGBJ(MKILOIPGILH);
		component.set_spriteName(string.Format("{0}_{1}", PDACDEPJNFO.GPNKIAHCKMG.INGLCFJBNOB(), MKILOIPGILH));
		uint num = PDACDEPJNFO.GPNKIAHCKMG.FKNPBEJDKGM()[MKILOIPGILH];
		if (true || MKILOIPGILH == 0)
		{
			m_priceLabel.gameObject.SetActive(false);
		}
		else
		{
			m_priceLabel.gameObject.SetActive(true);
			m_priceLabel.set_text(num.ToString());
		}
		m_newLabel.gameObject.SetActive(KIMJPIBNFGA.JJBDAOJIDAL().LNPGAJJAJKE().GOKPCMLKBHN(m_heroInfo.GPNKIAHCKMG.INGLCFJBNOB(), MKILOIPGILH));
	}

	private void FMDCADHECGH()
	{
	}

	public void ODEBOGMMION(bool LEMNDLNIIPG)
	{
		m_selectFrame.SetActive(LEMNDLNIIPG);
	}

	[SpecialName]
	public byte NNKOLMBELNI()
	{
		return PHFAHAEFAON;
	}

	private void FOGNMJLPHAI()
	{
	}

	private void CLLECEEEJAI()
	{
	}

	public void MMHJCFKMDNI(bool LEMNDLNIIPG)
	{
		m_selectFrame.SetActive(LEMNDLNIIPG);
	}

	private void Start()
	{
	}

	[SpecialName]
	protected void DKIGMOEELCC(byte ICENKPDOHBK)
	{
		PHFAHAEFAON = ICENKPDOHBK;
	}

	private void DHMMCEBEAHA()
	{
	}

	public void EINNCAEHIFE(NEFBHKKAMJF PDACDEPJNFO, byte MKILOIPGILH)
	{
		UISprite component = GetComponent<UISprite>();
		m_heroInfo = PDACDEPJNFO;
		AOCFHMMLGBJ(MKILOIPGILH);
		component.set_spriteName(string.Format("Hero2", PDACDEPJNFO.GPNKIAHCKMG.ODKFHEJKHMA(), MKILOIPGILH));
		uint num = PDACDEPJNFO.GPNKIAHCKMG.FKNPBEJDKGM()[MKILOIPGILH];
		if (PDACDEPJNFO.LJLAFJDNBAN(MKILOIPGILH) || MKILOIPGILH == 0)
		{
			m_priceLabel.gameObject.SetActive(true);
		}
		else
		{
			m_priceLabel.gameObject.SetActive(true);
			m_priceLabel.DCKJILCPKFD(num.ToString());
		}
		m_newLabel.gameObject.SetActive(KIMJPIBNFGA.NOLHNOGGHNA().LNPGAJJAJKE().GOKPCMLKBHN(m_heroInfo.GPNKIAHCKMG.INGLCFJBNOB(), MKILOIPGILH));
	}

	protected void AOCFHMMLGBJ(byte ICENKPDOHBK)
	{
		PHFAHAEFAON = ICENKPDOHBK;
	}

	public byte get_m_costume()
	{
		return PHFAHAEFAON;
	}
}
