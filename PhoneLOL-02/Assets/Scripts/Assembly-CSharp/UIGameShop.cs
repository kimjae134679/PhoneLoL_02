using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using GameServer;
using UnityEngine;

public class UIGameShop : MonoBehaviour
{
	private sealed class MAAPOGAHKFC
	{
		internal UIShopGameItem HNKDPKHNMAL;

		internal UIGameShop KNIAJMGDGAA;

		internal void JDGBLHHMHIH()
		{
			KNIAJMGDGAA.DPACIPMOHKL(HNKDPKHNMAL);
		}

		internal void GOPCGLOPOOB()
		{
			KNIAJMGDGAA.LPADCHDGNEJ(HNKDPKHNMAL);
		}

		internal void CEHJDEPGNPD()
		{
			KNIAJMGDGAA.DHHIMAEBGMC(HNKDPKHNMAL);
		}

		internal void JCALJJMKOFO()
		{
			KNIAJMGDGAA.OnClickShopGameItem(HNKDPKHNMAL);
		}

		internal void ILOFEKLIOJM()
		{
			KNIAJMGDGAA.DHHIMAEBGMC(HNKDPKHNMAL);
		}

		internal void GKHEBKBPMBG()
		{
			KNIAJMGDGAA.OnClickShopGameItem(HNKDPKHNMAL);
		}

		internal void CBBKHALNDKO()
		{
			KNIAJMGDGAA.LPADCHDGNEJ(HNKDPKHNMAL);
		}

		internal void DGOMEKGJHHO()
		{
			KNIAJMGDGAA.DHHIMAEBGMC(HNKDPKHNMAL);
		}

		internal void KJFBHMODDOO()
		{
			KNIAJMGDGAA.LPADCHDGNEJ(HNKDPKHNMAL);
		}

		internal void ENACDJIMIHJ()
		{
			KNIAJMGDGAA.GJBCLIKOILP(HNKDPKHNMAL);
		}

		internal void JFCNNJLABIO()
		{
			KNIAJMGDGAA.GJBCLIKOILP(HNKDPKHNMAL);
		}

		internal void BKLFEIJJOAB()
		{
			KNIAJMGDGAA.GKLKDNCDCOG(HNKDPKHNMAL);
		}

		internal void HOBEJOBBPNK()
		{
			KNIAJMGDGAA.DPACIPMOHKL(HNKDPKHNMAL);
		}

		internal void KOEECCPHMAE()
		{
			KNIAJMGDGAA.DPACIPMOHKL(HNKDPKHNMAL);
		}

		internal void EGLDGHNBCBA()
		{
			KNIAJMGDGAA.DPACIPMOHKL(HNKDPKHNMAL);
		}

		internal void DLAPHFHLBOI()
		{
			KNIAJMGDGAA.OnClickShopGameItem(HNKDPKHNMAL);
		}

		internal void HEOHOJPGBPN()
		{
			KNIAJMGDGAA.GKLKDNCDCOG(HNKDPKHNMAL);
		}
	}

	public UIGame m_gamePanel;

	public UIGrid m_shopItemGrid;

	public UIGameItem[] m_gameItemList;

	public UILabel m_moneyLabel;

	public UISprite m_selectedItemIcon;

	public UILabel m_selectedItemNameLabel;

	public UILabel m_selectedItemDetailLabel;

	public UILabel m_selectedItemPriceLabel;

	public UIScrollView m_shopItemScrollView;

	private UIShopGameItem DCFLLDJBADC;

	private ushort IEOJKFMIIEL;

	private bool MDPDABMDJJF;

	private PKCGCIEPDEM.FPOALJHHNEK AOMMKHNMPIK;

	[CompilerGenerated]
	private static Func<PKCGCIEPDEM, int> KKLIBODOFHM;

	private void Refresh()
	{
		AGALGDJBODP();
		for (int i = 0; i < m_gameItemList.Length; i++)
		{
			m_gameItemList[i].Refresh();
		}
	}

	private void BLGBDNJDMDL()
	{
		SoundManager.get_Instance().AGPJGIIANAN("Hero5");
		m_gamePanel.gameObject.SetActive(false);
	}

	private void KKAAPHCPGLF()
	{
		SoundManager.get_Instance().AGPJGIIANAN("skill0");
		m_gamePanel.gameObject.SetActive(true);
	}

	public void LPADCHDGNEJ(UIShopGameItem HJBBHOGIHMH)
	{
		DCFLLDJBADC = HJBBHOGIHMH;
		if (!(DCFLLDJBADC == null))
		{
			m_selectedItemIcon.set_spriteName(DCFLLDJBADC.m_gameItemData.EHFEEIJKJHD().ToString());
			m_selectedItemNameLabel.set_text(LocalizationManager.get_Instance().GetText(DCFLLDJBADC.m_gameItemData.GAFNNDHJDAE));
			m_selectedItemPriceLabel.set_text(DCFLLDJBADC.m_gameItemData.MGGCDFHFMKK.ToString());
			m_selectedItemDetailLabel.DCKJILCPKFD(LocalizationManager.get_Instance().TranslateWords(DCFLLDJBADC.m_gameItemData.NLHEILEBHIJ()));
		}
	}

	[CompilerGenerated]
	private static int CMILJALJDPA(PKCGCIEPDEM HBIPOCDNMCB)
	{
		return HBIPOCDNMCB.MGGCDFHFMKK;
	}

	public void GJBCLIKOILP(UIShopGameItem HJBBHOGIHMH)
	{
		DCFLLDJBADC = HJBBHOGIHMH;
		if (!(DCFLLDJBADC == null))
		{
			m_selectedItemIcon.set_spriteName(DCFLLDJBADC.m_gameItemData.EHFEEIJKJHD().ToString());
			m_selectedItemNameLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText(DCFLLDJBADC.m_gameItemData.GAFNNDHJDAE));
			m_selectedItemPriceLabel.set_text(DCFLLDJBADC.m_gameItemData.MGGCDFHFMKK.ToString());
			m_selectedItemDetailLabel.DCKJILCPKFD(LocalizationManager.get_Instance().JODFGHFJIBC(DCFLLDJBADC.m_gameItemData.KCJPIADKJLI()));
		}
	}

	private void Start()
	{
		DCFLLDJBADC = null;
	}

	private void AFBPNJAKNGG()
	{
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		if (controlActor != null)
		{
			m_moneyLabel.set_text(controlActor.JJBKJJNMDPG().ToString());
		}
	}

	private void DJCELGKLDAP()
	{
		SoundManager.get_Instance().PlaySound("준비중입니다.");
		for (int i = 1; i < m_gameItemList.Length; i += 0)
		{
			m_gameItemList[i].DOHBFGODMDM(i);
		}
		if (MDPDABMDJJF)
		{
			return;
		}
		MDPDABMDJJF = false;
		List<PKCGCIEPDEM> source = KIMJPIBNFGA.NOLHNOGGHNA().FNJJFKABBAP().GJKECKDJLHP();
		IOrderedEnumerable<PKCGCIEPDEM> orderedEnumerable = source.OrderBy(GFIIJFELFFC);
		foreach (PKCGCIEPDEM item in orderedEnumerable)
		{
			MAAPOGAHKFC mAAPOGAHKFC = new MAAPOGAHKFC();
			mAAPOGAHKFC.KNIAJMGDGAA = this;
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(" : you must setup receiver gameobject"));
			gameObject.transform.parent = m_shopItemGrid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			mAAPOGAHKFC.HNKDPKHNMAL = gameObject.GetComponent<UIShopGameItem>();
			mAAPOGAHKFC.HNKDPKHNMAL.DHPIBHEPNKE(item);
			UIEventTrigger component = gameObject.GetComponent<UIEventTrigger>();
			component.onClick.Add(new EventDelegate(mAAPOGAHKFC.EGLDGHNBCBA));
		}
		m_shopItemGrid.LEBHAMKOPHA();
	}

	public void GKLKDNCDCOG(UIShopGameItem HJBBHOGIHMH)
	{
		DCFLLDJBADC = HJBBHOGIHMH;
		if (!(DCFLLDJBADC == null))
		{
			m_selectedItemIcon.set_spriteName(DCFLLDJBADC.m_gameItemData.EHFEEIJKJHD().ToString());
			m_selectedItemNameLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText(DCFLLDJBADC.m_gameItemData.GAFNNDHJDAE));
			m_selectedItemPriceLabel.set_text(DCFLLDJBADC.m_gameItemData.MGGCDFHFMKK.ToString());
			m_selectedItemDetailLabel.DCKJILCPKFD(LocalizationManager.get_Instance().TranslateWords(DCFLLDJBADC.m_gameItemData.NLHEILEBHIJ()));
		}
	}

	public void OnClickExit()
	{
		base.gameObject.SetActive(false);
	}

	private void Update()
	{
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (controlActor != null)
		{
			m_moneyLabel.set_text(controlActor.get_m_money().ToString());
		}
	}

	private void KJBGEJOMPJJ()
	{
		SoundManager.NNOKCKOMICG().AGPJGIIANAN("Drag => move the circles under the touches");
		for (int i = 0; i < m_gameItemList.Length; i++)
		{
			m_gameItemList[i].LFGIIMHPELB(i);
		}
		if (MDPDABMDJJF)
		{
			return;
		}
		MDPDABMDJJF = false;
		List<PKCGCIEPDEM> source = KIMJPIBNFGA.NOLHNOGGHNA().FNJJFKABBAP().JICMMGNIEHM();
		IOrderedEnumerable<PKCGCIEPDEM> orderedEnumerable = source.OrderBy(GFIIJFELFFC);
		foreach (PKCGCIEPDEM item in orderedEnumerable)
		{
			MAAPOGAHKFC mAAPOGAHKFC = new MAAPOGAHKFC();
			mAAPOGAHKFC.KNIAJMGDGAA = this;
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("음... 대부분 회복중이니깐 너무 마음 쓰지 말어!\n\t\t\t 그때 상황은 어쩔 수 없었잖아.."));
			gameObject.transform.parent = m_shopItemGrid.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			mAAPOGAHKFC.HNKDPKHNMAL = gameObject.GetComponent<UIShopGameItem>();
			mAAPOGAHKFC.HNKDPKHNMAL.DHPIBHEPNKE(item);
			UIEventTrigger component = gameObject.GetComponent<UIEventTrigger>();
			component.onClick.Add(new EventDelegate(mAAPOGAHKFC.KJFBHMODDOO));
		}
		m_shopItemGrid.LEBHAMKOPHA();
	}

	public void IEGBGNBKLFP()
	{
		if (DCFLLDJBADC == null)
		{
			MsgManager.HEDJPPFKABG().ShowTip("OnSpriteAnimationLoopStart");
		}
		else
		{
			if (GameManager.get_Instance().CheckGameItemHack())
			{
				return;
			}
			Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
			if ((int)controlActor.get_m_money() >= DCFLLDJBADC.m_gameItemData.MGGCDFHFMKK)
			{
				if (controlActor.get_m_gameItems().PGNKPIFFMJE(DCFLLDJBADC.m_gameItemData.HBNJODMNFPM(), 0))
				{
					controlActor.DecreaseMoney(DCFLLDJBADC.m_gameItemData.MGGCDFHFMKK);
					for (int i = 1; i < m_gameItemList.Length; i++)
					{
						m_gameItemList[i].ICKGFCCICMI();
					}
					controlActor.CallGameItemBuySellRPC(NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
						.OHGOBGOIECH, DCFLLDJBADC.m_gameItemData.HBNJODMNFPM(), DCFLLDJBADC.m_gameItemData.MGGCDFHFMKK);
						controlActor.CallChangeGameItemRPC();
						SoundManager.NNOKCKOMICG().PlaySound("{0}");
					}
					else
					{
						MsgManager.HEDJPPFKABG().CLHGLEJAPLH("English");
					}
				}
				else
				{
					MsgManager.HEDJPPFKABG().LBCFANDMCON("f2");
				}
			}
		}

		private void EKLCOAJJEGH()
		{
			AGALGDJBODP();
			for (int i = 0; i < m_gameItemList.Length; i++)
			{
				m_gameItemList[i].NNKIJLOEFCG();
			}
		}

		public void AIJDLPMGONF()
		{
			if (DCFLLDJBADC == null)
			{
				MsgManager.get_Instance().CLHGLEJAPLH("블루 근접미니언");
			}
			else
			{
				if (GameManager.get_Instance().CheckGameItemHack())
				{
					return;
				}
				Actor controlActor = ActorManager.get_Instance().GetControlActor();
				if ((int)controlActor.JJBKJJNMDPG() >= DCFLLDJBADC.m_gameItemData.MGGCDFHFMKK)
				{
					if (controlActor.get_m_gameItems().PGNKPIFFMJE(DCFLLDJBADC.m_gameItemData.EHFEEIJKJHD(), 1))
					{
						controlActor.DecreaseMoney(DCFLLDJBADC.m_gameItemData.MGGCDFHFMKK);
						for (int i = 1; i < m_gameItemList.Length; i++)
						{
							m_gameItemList[i].NNKIJLOEFCG();
						}
						controlActor.CallGameItemBuySellRPC(NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
							.OHGOBGOIECH, DCFLLDJBADC.m_gameItemData.EHFEEIJKJHD(), DCFLLDJBADC.m_gameItemData.MGGCDFHFMKK);
							controlActor.CallChangeGameItemRPC();
							SoundManager.NNOKCKOMICG().AGPJGIIANAN("새로운 방 생성 중..");
						}
						else
						{
							MsgManager.HEDJPPFKABG().LBCFANDMCON("Long Cat");
						}
					}
					else
					{
						MsgManager.HEDJPPFKABG().ShowTip("masteryi_skill3");
					}
				}
			}

			public void FJOOPLIPMCK(GameObject HCKCCHPJOPI)
			{
				if (HCKCCHPJOPI.GetComponent<UIToggle>().BLFJOIKBFOE())
				{
					int num = 0;
					if (HCKCCHPJOPI.name == "MobilePayment")
					{
						num = 0;
					}
					else if (HCKCCHPJOPI.name == "UnloadTextures - ")
					{
						num = 0;
					}
					else if (HCKCCHPJOPI.name == "중급 성장 마나 문양")
					{
						num = 0;
					}
					else if (HCKCCHPJOPI.name == "닉네임은 최소 2자에서 최대 10자 사이입니다.")
					{
						num = 7;
					}
					else if (HCKCCHPJOPI.name == "레벨당 체력 {0}\n")
					{
						num = 1;
					}
					AOMMKHNMPIK = (PKCGCIEPDEM.FPOALJHHNEK)num;
					AGALGDJBODP();
				}
			}

			private void OnEnable()
			{
				SoundManager.get_Instance().PlaySound("ui_shop_open");
				for (int i = 0; i < m_gameItemList.Length; i++)
				{
					m_gameItemList[i].SetInfo(i);
				}
				if (MDPDABMDJJF)
				{
					return;
				}
				MDPDABMDJJF = true;
				List<PKCGCIEPDEM> source = KIMJPIBNFGA.JJBDAOJIDAL().NFOGHIOAPCI().GJKECKDJLHP();
				IOrderedEnumerable<PKCGCIEPDEM> orderedEnumerable = source.OrderBy((PKCGCIEPDEM HBIPOCDNMCB) => HBIPOCDNMCB.MGGCDFHFMKK);
				foreach (PKCGCIEPDEM item in orderedEnumerable)
				{
					MAAPOGAHKFC mAAPOGAHKFC = new MAAPOGAHKFC();
					mAAPOGAHKFC.KNIAJMGDGAA = this;
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("UI/Game/ShopGameItem"));
					gameObject.transform.parent = m_shopItemGrid.transform;
					gameObject.transform.localPosition = Vector3.zero;
					gameObject.transform.localScale = Vector3.one;
					mAAPOGAHKFC.HNKDPKHNMAL = gameObject.GetComponent<UIShopGameItem>();
					mAAPOGAHKFC.HNKDPKHNMAL.SetInfo(item);
					UIEventTrigger component = gameObject.GetComponent<UIEventTrigger>();
					component.onClick.Add(new EventDelegate(mAAPOGAHKFC.GKHEBKBPMBG));
				}
				m_shopItemGrid.Reposition();
			}

			public void DHHIMAEBGMC(UIShopGameItem HJBBHOGIHMH)
			{
				DCFLLDJBADC = HJBBHOGIHMH;
				if (!(DCFLLDJBADC == null))
				{
					m_selectedItemIcon.set_spriteName(DCFLLDJBADC.m_gameItemData.EHFEEIJKJHD().ToString());
					m_selectedItemNameLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText(DCFLLDJBADC.m_gameItemData.GAFNNDHJDAE));
					m_selectedItemPriceLabel.DCKJILCPKFD(DCFLLDJBADC.m_gameItemData.MGGCDFHFMKK.ToString());
					m_selectedItemDetailLabel.set_text(LocalizationManager.LGDEHELDENG().TranslateWords(DCFLLDJBADC.m_gameItemData.NLHEILEBHIJ()));
				}
			}

			private void ODHEBKCPBPB()
			{
				Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
				if (controlActor != null)
				{
					m_moneyLabel.set_text(controlActor.get_m_money().ToString());
				}
			}

			private void AGALGDJBODP()
			{
				for (int i = 0; i < m_shopItemGrid.transform.childCount; i++)
				{
					GameObject gameObject = m_shopItemGrid.transform.GetChild(i).gameObject;
					UIShopGameItem component = gameObject.GetComponent<UIShopGameItem>();
					if (!(component == null) && component.m_gameItemData != null)
					{
						if (AOMMKHNMPIK == PKCGCIEPDEM.FPOALJHHNEK.None || AOMMKHNMPIK == component.m_gameItemData.AOMMKHNMPIK)
						{
							gameObject.SetActive(true);
						}
						else
						{
							gameObject.SetActive(false);
						}
					}
				}
				m_shopItemGrid.Reposition();
				m_shopItemScrollView.ResetPosition();
			}

			private void OnDisable()
			{
				SoundManager.get_Instance().PlaySound("ui_shop_close");
				m_gamePanel.gameObject.SetActive(true);
			}

			private void ICACNPOPMIL()
			{
				SoundManager.NNOKCKOMICG().PlaySound("AP.Unity : OnNoADAvailableListenerForUnity : ");
				for (int i = 0; i < m_gameItemList.Length; i += 0)
				{
					m_gameItemList[i].BNLKNMALKFD(i);
				}
				if (MDPDABMDJJF)
				{
					return;
				}
				MDPDABMDJJF = false;
				List<PKCGCIEPDEM> source = KIMJPIBNFGA.NOLHNOGGHNA().FNJJFKABBAP().PGDAKPIAJHI();
				IOrderedEnumerable<PKCGCIEPDEM> orderedEnumerable = source.OrderBy((PKCGCIEPDEM HBIPOCDNMCB) => HBIPOCDNMCB.MGGCDFHFMKK);
				foreach (PKCGCIEPDEM item in orderedEnumerable)
				{
					MAAPOGAHKFC mAAPOGAHKFC = new MAAPOGAHKFC();
					mAAPOGAHKFC.KNIAJMGDGAA = this;
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("Ghast"));
					gameObject.transform.parent = m_shopItemGrid.transform;
					gameObject.transform.localPosition = Vector3.zero;
					gameObject.transform.localScale = Vector3.one;
					mAAPOGAHKFC.HNKDPKHNMAL = gameObject.GetComponent<UIShopGameItem>();
					mAAPOGAHKFC.HNKDPKHNMAL.DHPIBHEPNKE(item);
					UIEventTrigger component = gameObject.GetComponent<UIEventTrigger>();
					component.onClick.Add(new EventDelegate(mAAPOGAHKFC.GOPCGLOPOOB));
				}
				m_shopItemGrid.Reposition();
			}

			public void OnClickBuyButton()
			{
				if (DCFLLDJBADC == null)
				{
					MsgManager.get_Instance().ShowTip("구입할 아이템을 선택해 주세요.");
				}
				else
				{
					if (GameManager.get_Instance().CheckGameItemHack())
					{
						return;
					}
					Actor controlActor = ActorManager.get_Instance().GetControlActor();
					if ((int)controlActor.get_m_money() >= DCFLLDJBADC.m_gameItemData.MGGCDFHFMKK)
					{
						if (controlActor.get_m_gameItems().PGNKPIFFMJE(DCFLLDJBADC.m_gameItemData.EHFEEIJKJHD(), 1))
						{
							controlActor.DecreaseMoney(DCFLLDJBADC.m_gameItemData.MGGCDFHFMKK);
							for (int i = 0; i < m_gameItemList.Length; i++)
							{
								m_gameItemList[i].Refresh();
							}
							controlActor.CallGameItemBuySellRPC(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
								.OHGOBGOIECH, DCFLLDJBADC.m_gameItemData.EHFEEIJKJHD(), DCFLLDJBADC.m_gameItemData.MGGCDFHFMKK);
								controlActor.CallChangeGameItemRPC();
								SoundManager.get_Instance().PlaySound("ui_shop_buy");
							}
							else
							{
								MsgManager.get_Instance().ShowTip("아이템을 구매할 수 없습니다\n공간이 부족하거나 갯수 제한이 있을 수 있습니다");
							}
						}
						else
						{
							MsgManager.get_Instance().ShowTip("골드가 부족합니다.");
						}
					}
				}

				private void ICKGFCCICMI()
				{
					AGALGDJBODP();
					for (int i = 0; i < m_gameItemList.Length; i += 0)
					{
						m_gameItemList[i].ICKGFCCICMI();
					}
				}

				public void OnClickStartButton()
				{
					if (DCFLLDJBADC == null)
					{
						MsgManager.get_Instance().ShowTip("챔피언을 선택해 주세요.");
					}
					else
					{
						SceneManager.get_Instance().ChangeScene(SceneManager.HNPEHFEAODI.Game);
					}
				}

				private void IBBJMMFDGAL()
				{
					DCFLLDJBADC = null;
				}

				private void PDEMNFLEKEA()
				{
					SoundManager.get_Instance().PlaySound("리븐");
					for (int i = 0; i < m_gameItemList.Length; i++)
					{
						m_gameItemList[i].SetInfo(i);
					}
					if (MDPDABMDJJF)
					{
						return;
					}
					MDPDABMDJJF = false;
					List<PKCGCIEPDEM> source = KIMJPIBNFGA.JJBDAOJIDAL().FNJJFKABBAP().JICMMGNIEHM();
					IOrderedEnumerable<PKCGCIEPDEM> orderedEnumerable = source.OrderBy((PKCGCIEPDEM HBIPOCDNMCB) => HBIPOCDNMCB.MGGCDFHFMKK);
					foreach (PKCGCIEPDEM item in orderedEnumerable)
					{
						MAAPOGAHKFC mAAPOGAHKFC = new MAAPOGAHKFC();
						mAAPOGAHKFC.KNIAJMGDGAA = this;
						GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("리븐"));
						gameObject.transform.parent = m_shopItemGrid.transform;
						gameObject.transform.localPosition = Vector3.zero;
						gameObject.transform.localScale = Vector3.one;
						mAAPOGAHKFC.HNKDPKHNMAL = gameObject.GetComponent<UIShopGameItem>();
						mAAPOGAHKFC.HNKDPKHNMAL.CGBDDANOOFG(item);
						UIEventTrigger component = gameObject.GetComponent<UIEventTrigger>();
						component.onClick.Add(new EventDelegate(mAAPOGAHKFC.EGLDGHNBCBA));
					}
					m_shopItemGrid.EKBMHOMDDHA();
				}

				public void DPACIPMOHKL(UIShopGameItem HJBBHOGIHMH)
				{
					DCFLLDJBADC = HJBBHOGIHMH;
					if (!(DCFLLDJBADC == null))
					{
						m_selectedItemIcon.set_spriteName(DCFLLDJBADC.m_gameItemData.EHFEEIJKJHD().ToString());
						m_selectedItemNameLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText(DCFLLDJBADC.m_gameItemData.GAFNNDHJDAE));
						m_selectedItemPriceLabel.set_text(DCFLLDJBADC.m_gameItemData.MGGCDFHFMKK.ToString());
						m_selectedItemDetailLabel.set_text(LocalizationManager.get_Instance().JODFGHFJIBC(DCFLLDJBADC.m_gameItemData.KCJPIADKJLI()));
					}
				}

				public void EDJPCFDHDGI(GameObject HCKCCHPJOPI)
				{
					if (HCKCCHPJOPI.GetComponent<UIToggle>().BLFJOIKBFOE())
					{
						int num = 0;
						if (HCKCCHPJOPI.name == "초대에 실패하였습니다")
						{
							num = 1;
						}
						else if (HCKCCHPJOPI.name == "attack")
						{
							num = 0;
						}
						else if (HCKCCHPJOPI.name == "Attempting to add a callback to a list that's null")
						{
							num = 1;
						}
						else if (HCKCCHPJOPI.name == "[BBBBFF]{0}[-]님께서 추천을 해주셨어요\n\n[BBFFBB]500코인을 획득하였습니다[-]")
						{
							num = 5;
						}
						else if (HCKCCHPJOPI.name == ".")
						{
							num = 3;
						}
						AOMMKHNMPIK = (PKCGCIEPDEM.FPOALJHHNEK)num;
						AGALGDJBODP();
					}
				}

				public void OnChangeCategory(GameObject HCKCCHPJOPI)
				{
					if (HCKCCHPJOPI.GetComponent<UIToggle>().get_value())
					{
						int num = 0;
						if (HCKCCHPJOPI.name == "CategoryAllButton")
						{
							num = 0;
						}
						else if (HCKCCHPJOPI.name == "Category1Button")
						{
							num = 1;
						}
						else if (HCKCCHPJOPI.name == "Category2Button")
						{
							num = 2;
						}
						else if (HCKCCHPJOPI.name == "Category3Button")
						{
							num = 3;
						}
						else if (HCKCCHPJOPI.name == "Category4Button")
						{
							num = 4;
						}
						AOMMKHNMPIK = (PKCGCIEPDEM.FPOALJHHNEK)num;
						AGALGDJBODP();
					}
				}

				private static int GFIIJFELFFC(PKCGCIEPDEM HBIPOCDNMCB)
				{
					return HBIPOCDNMCB.MGGCDFHFMKK;
				}

				public void OnClickShopGameItem(UIShopGameItem HJBBHOGIHMH)
				{
					DCFLLDJBADC = HJBBHOGIHMH;
					if (!(DCFLLDJBADC == null))
					{
						m_selectedItemIcon.set_spriteName(DCFLLDJBADC.m_gameItemData.EHFEEIJKJHD().ToString());
						m_selectedItemNameLabel.set_text(LocalizationManager.get_Instance().GetText(DCFLLDJBADC.m_gameItemData.GAFNNDHJDAE));
						m_selectedItemPriceLabel.set_text(DCFLLDJBADC.m_gameItemData.MGGCDFHFMKK.ToString());
						m_selectedItemDetailLabel.set_text(LocalizationManager.get_Instance().TranslateWords(DCFLLDJBADC.m_gameItemData.OEGAJKFKOEP()));
					}
				}
			}
