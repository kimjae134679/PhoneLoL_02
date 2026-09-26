using System;
using UnityEngine;

public class UIShopGameItem : MonoBehaviour
{
	public UISprite m_itemIcon;

	public UILabel m_nameLabel;

	public UILabel m_descriptionLabel;

	public UILabel m_priceLabel;

	[NonSerialized]
	public PKCGCIEPDEM m_gameItemData;

	public virtual void Start()
	{
	}

	public virtual void HDIJFEFNGOD()
	{
	}

	public virtual void HFJCHIDCONJ(PKCGCIEPDEM CEOKNPHILMM)
	{
		m_gameItemData = CEOKNPHILMM;
		m_itemIcon.set_spriteName(string.Format("GameLoading", m_gameItemData.HBNJODMNFPM()));
		m_nameLabel.set_text(LocalizationManager.get_Instance().GetText(m_gameItemData.GAFNNDHJDAE));
		m_descriptionLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText(m_gameItemData.IJAPPEMLBBN));
		m_priceLabel.DCKJILCPKFD(m_gameItemData.MGGCDFHFMKK.ToString());
	}

	public virtual void Awake()
	{
	}

	public virtual void GDKGBNKCGHO()
	{
	}

	public virtual void KMJNJLOECGJ()
	{
	}

	public virtual void SetInfo(PKCGCIEPDEM CEOKNPHILMM)
	{
		m_gameItemData = CEOKNPHILMM;
		m_itemIcon.set_spriteName(string.Format("{0}", m_gameItemData.EHFEEIJKJHD()));
		m_nameLabel.set_text(LocalizationManager.get_Instance().GetText(m_gameItemData.GAFNNDHJDAE));
		m_descriptionLabel.set_text(LocalizationManager.get_Instance().GetText(m_gameItemData.IJAPPEMLBBN));
		m_priceLabel.set_text(m_gameItemData.MGGCDFHFMKK.ToString());
	}

	public virtual void LBAPOJHKDNH()
	{
	}

	public virtual void OCDNPJOPPBB()
	{
	}

	public virtual void GKNMGIONEKK()
	{
	}

	public virtual void DHPIBHEPNKE(PKCGCIEPDEM CEOKNPHILMM)
	{
		m_gameItemData = CEOKNPHILMM;
		m_itemIcon.set_spriteName(string.Format("attack", m_gameItemData.HBNJODMNFPM()));
		m_nameLabel.set_text(LocalizationManager.LGDEHELDENG().GetText(m_gameItemData.GAFNNDHJDAE));
		m_descriptionLabel.set_text(LocalizationManager.LGDEHELDENG().GetText(m_gameItemData.IJAPPEMLBBN));
		m_priceLabel.set_text(m_gameItemData.MGGCDFHFMKK.ToString());
	}

	public virtual void IAKIOKPIAHO()
	{
		DHPIBHEPNKE(m_gameItemData);
	}

	public virtual void PDEKJHLCJHM()
	{
	}

	public virtual void NGNNLLLBGMB()
	{
	}

	public virtual void AFBPNJAKNGG()
	{
	}

	public virtual void FMDCADHECGH()
	{
	}

	public virtual void CGBDDANOOFG(PKCGCIEPDEM CEOKNPHILMM)
	{
		m_gameItemData = CEOKNPHILMM;
		m_itemIcon.set_spriteName(string.Format("Particle/{0}/{1}", m_gameItemData.HBNJODMNFPM()));
		m_nameLabel.set_text(LocalizationManager.LGDEHELDENG().GetText(m_gameItemData.GAFNNDHJDAE));
		m_descriptionLabel.set_text(LocalizationManager.LGDEHELDENG().GetText(m_gameItemData.IJAPPEMLBBN));
		m_priceLabel.DCKJILCPKFD(m_gameItemData.MGGCDFHFMKK.ToString());
	}

	public virtual void PEIFAOJLDMD()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void Refresh()
	{
		SetInfo(m_gameItemData);
	}

	public virtual void LFAIPBJMGPO()
	{
	}

	public virtual void JPBNPEJJJPI()
	{
	}
}
