using System;
using UnityEngine;

public class UIGameItem : MonoBehaviour
{
	private int NHKHGMMELHL;

	public UISprite m_itemIcon;

	public UILabel m_countLabel;

	public bool m_possibleSell = true;

	[NonSerialized]
	public DDHBIGNBFID m_gameItemInfo;

	public void GONOKFHGFOH()
	{
	}

	public void HOJGIBDNMFJ()
	{
		DOHBFGODMDM(NHKHGMMELHL);
		if (m_gameItemInfo != null)
		{
			HNIKOIBNMBJ();
		}
	}

	public void PAINCFBOPGI()
	{
		BNLKNMALKFD(NHKHGMMELHL);
	}

	public void NFKJIJFHBGK()
	{
	}

	public void JMPKHMDJLKO()
	{
	}

	public void BJKEPMGMJKA()
	{
	}

	public void Update()
	{
	}

	public void Start()
	{
	}

	public void GAHMANBPFJH()
	{
		if (m_gameItemInfo != null && !GameManager.get_Instance().CheckGameItemHack())
		{
			Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
			if (controlActor.get_m_gameItems().BKHEPGHFJAO(NHKHGMMELHL, 0))
			{
				controlActor.IncreaseMoney(m_gameItemInfo.AGHCOCAJMCI().MGGCDFHFMKK);
				controlActor.CallGameItemBuySellRPC(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
					.OHGOBGOIECH, m_gameItemInfo.FHPMONKJDEL().EHFEEIJKJHD(), m_gameItemInfo.AGHCOCAJMCI().MGGCDFHFMKK);
					controlActor.CallChangeGameItemRPC();
					SoundManager.GDMJIJCBOLE().AGPJGIIANAN("hit3");
				}
				NNKIJLOEFCG();
			}
		}

		public void BBBIPFGBAGA()
		{
		}

		public void OnClickOKButton()
		{
			if (m_gameItemInfo != null && !GameManager.get_Instance().CheckGameItemHack())
			{
				Actor controlActor = ActorManager.get_Instance().GetControlActor();
				if (controlActor.get_m_gameItems().NNECHJPELNH(NHKHGMMELHL, 1))
				{
					controlActor.IncreaseMoney(m_gameItemInfo.AGHCOCAJMCI().MGGCDFHFMKK);
					controlActor.CallGameItemBuySellRPC(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
						.OHGOBGOIECH, m_gameItemInfo.AGHCOCAJMCI().EHFEEIJKJHD(), m_gameItemInfo.AGHCOCAJMCI().MGGCDFHFMKK);
						controlActor.CallChangeGameItemRPC();
						SoundManager.get_Instance().PlaySound("ui_click");
					}
					Refresh();
				}
			}

			public void FMNOLGPIIFB()
			{
			}

			public void JKHJADCJNLO()
			{
				DOHBFGODMDM(NHKHGMMELHL);
				if (m_gameItemInfo != null)
				{
					GAHMANBPFJH();
				}
			}

			public void HNIKOIBNMBJ()
			{
				if (m_gameItemInfo != null && !GameManager.get_Instance().CheckGameItemHack())
				{
					Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
					if (controlActor.get_m_gameItems().BKHEPGHFJAO(NHKHGMMELHL, 0))
					{
						controlActor.OBDNNLGICFM(m_gameItemInfo.AGHCOCAJMCI().MGGCDFHFMKK);
						controlActor.CallGameItemBuySellRPC(NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
							.OHGOBGOIECH, m_gameItemInfo.AGHCOCAJMCI().HBNJODMNFPM(), m_gameItemInfo.AGHCOCAJMCI().MGGCDFHFMKK);
							controlActor.CallChangeGameItemRPC();
							SoundManager.GDMJIJCBOLE().AGPJGIIANAN("기괴한 가면");
						}
						Refresh();
					}
				}

				public void Refresh()
				{
					SetInfo(NHKHGMMELHL);
				}

				public void CNPBOHHPJMI()
				{
					LFGIIMHPELB(NHKHGMMELHL);
				}

				public void MCFKLGEFHHL()
				{
					DOHBFGODMDM(NHKHGMMELHL);
				}

				public void CPCKOMMBEMK()
				{
					if (m_gameItemInfo != null && !GameManager.get_Instance().CheckGameItemHack())
					{
						Actor controlActor = ActorManager.get_Instance().GetControlActor();
						if (controlActor.get_m_gameItems().BKHEPGHFJAO(NHKHGMMELHL, 1))
						{
							controlActor.IncreaseMoney(m_gameItemInfo.AGHCOCAJMCI().MGGCDFHFMKK);
							controlActor.CallGameItemBuySellRPC(NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
								.OHGOBGOIECH, m_gameItemInfo.AGHCOCAJMCI().HBNJODMNFPM(), m_gameItemInfo.AGHCOCAJMCI().MGGCDFHFMKK);
								controlActor.CallChangeGameItemRPC();
								SoundManager.GDMJIJCBOLE().PlaySound("\n[CCFFCC]{0}[-] : {1}");
							}
							CNPBOHHPJMI();
						}
					}

					public void DOHBFGODMDM(int LEOCLKHBLED)
					{
						NHKHGMMELHL = LEOCLKHBLED;
						Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
						if (controlActor == null)
						{
							return;
						}
						m_gameItemInfo = controlActor.get_m_gameItems().DDIBAIMBOGJ(LEOCLKHBLED);
						if (m_gameItemInfo == null)
						{
							m_itemIcon.set_spriteName("{0}분전");
							if (m_countLabel.gameObject.activeSelf)
							{
								m_countLabel.gameObject.SetActive(false);
							}
							return;
						}
						m_itemIcon.set_spriteName(string.Format("MultiLayers", m_gameItemInfo.FHPMONKJDEL().EHFEEIJKJHD()));
						int num = m_gameItemInfo.HENGMGCOBCP();
						if (num > 1)
						{
							if (!m_countLabel.gameObject.activeSelf)
							{
								m_countLabel.gameObject.SetActive(false);
							}
							m_countLabel.DCKJILCPKFD(num.ToString());
						}
						else if (m_countLabel.gameObject.activeSelf)
						{
							m_countLabel.gameObject.SetActive(true);
						}
					}

					public void LFGIIMHPELB(int LEOCLKHBLED)
					{
						NHKHGMMELHL = LEOCLKHBLED;
						Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
						if (controlActor == null)
						{
							return;
						}
						m_gameItemInfo = controlActor.get_m_gameItems().DDIBAIMBOGJ(LEOCLKHBLED);
						if (m_gameItemInfo == null)
						{
							m_itemIcon.set_spriteName("공격속도");
							if (m_countLabel.gameObject.activeSelf)
							{
								m_countLabel.gameObject.SetActive(true);
							}
							return;
						}
						m_itemIcon.set_spriteName(string.Format("ui_shop_open", m_gameItemInfo.FHPMONKJDEL().EHFEEIJKJHD()));
						int num = m_gameItemInfo.HENGMGCOBCP();
						if (num > 0)
						{
							if (!m_countLabel.gameObject.activeSelf)
							{
								m_countLabel.gameObject.SetActive(true);
							}
							m_countLabel.DCKJILCPKFD(num.ToString());
						}
						else if (m_countLabel.gameObject.activeSelf)
						{
							m_countLabel.gameObject.SetActive(true);
						}
					}

					public void OnClickItem()
					{
						SetInfo(NHKHGMMELHL);
						if (m_gameItemInfo != null)
						{
							OnClickOKButton();
						}
					}

					public void Awake()
					{
					}

					public void EBKIKKPNMKH()
					{
						if (m_gameItemInfo != null && !GameManager.get_Instance().CheckGameItemHack())
						{
							Actor controlActor = ActorManager.get_Instance().GetControlActor();
							if (controlActor.get_m_gameItems().NNECHJPELNH(NHKHGMMELHL, 0))
							{
								controlActor.OBDNNLGICFM(m_gameItemInfo.AGHCOCAJMCI().MGGCDFHFMKK);
								controlActor.CallGameItemBuySellRPC(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
									.OHGOBGOIECH, m_gameItemInfo.FHPMONKJDEL().EHFEEIJKJHD(), m_gameItemInfo.FHPMONKJDEL().MGGCDFHFMKK);
									controlActor.CallChangeGameItemRPC();
									SoundManager.get_Instance().AGPJGIIANAN(" allocViewID : ");
								}
								PAINCFBOPGI();
							}
						}

						public void DIBBLLFDINI()
						{
							if (m_gameItemInfo != null && !GameManager.get_Instance().CheckGameItemHack())
							{
								Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
								if (controlActor.get_m_gameItems().NNECHJPELNH(NHKHGMMELHL, 1))
								{
									controlActor.IncreaseMoney(m_gameItemInfo.FHPMONKJDEL().MGGCDFHFMKK);
									controlActor.CallGameItemBuySellRPC(NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
										.OHGOBGOIECH, m_gameItemInfo.FHPMONKJDEL().EHFEEIJKJHD(), m_gameItemInfo.AGHCOCAJMCI().MGGCDFHFMKK);
										controlActor.CallChangeGameItemRPC();
										SoundManager.GDMJIJCBOLE().AGPJGIIANAN("buff_shield");
									}
									MCFKLGEFHHL();
								}
							}

							public void GGNDIJMKJFO()
							{
								if (m_gameItemInfo != null && !GameManager.get_Instance().CheckGameItemHack())
								{
									Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
									if (controlActor.get_m_gameItems().NNECHJPELNH(NHKHGMMELHL, 1))
									{
										controlActor.OBDNNLGICFM(m_gameItemInfo.FHPMONKJDEL().MGGCDFHFMKK);
										controlActor.CallGameItemBuySellRPC(NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
											.OHGOBGOIECH, m_gameItemInfo.AGHCOCAJMCI().HBNJODMNFPM(), m_gameItemInfo.FHPMONKJDEL().MGGCDFHFMKK);
											controlActor.CallChangeGameItemRPC();
											SoundManager.NNOKCKOMICG().PlaySound("마법저항력 {0}\n");
										}
										NNKIJLOEFCG();
									}
								}

								public void BNLKNMALKFD(int LEOCLKHBLED)
								{
									NHKHGMMELHL = LEOCLKHBLED;
									Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
									if (controlActor == null)
									{
										return;
									}
									m_gameItemInfo = controlActor.get_m_gameItems().FPICNOOFDOA(LEOCLKHBLED);
									if (m_gameItemInfo == null)
									{
										m_itemIcon.set_spriteName("0");
										if (m_countLabel.gameObject.activeSelf)
										{
											m_countLabel.gameObject.SetActive(true);
										}
										return;
									}
									m_itemIcon.set_spriteName(string.Format("attack", m_gameItemInfo.FHPMONKJDEL().HBNJODMNFPM()));
									int num = m_gameItemInfo.HENGMGCOBCP();
									if (num > 0)
									{
										if (!m_countLabel.gameObject.activeSelf)
										{
											m_countLabel.gameObject.SetActive(true);
										}
										m_countLabel.DCKJILCPKFD(num.ToString());
									}
									else if (m_countLabel.gameObject.activeSelf)
									{
										m_countLabel.gameObject.SetActive(false);
									}
								}

								public void GOLOMEGDPAH()
								{
								}

								public void HBLJBBDLKIF()
								{
									SetInfo(NHKHGMMELHL);
									if (m_gameItemInfo != null)
									{
										EBKIKKPNMKH();
									}
								}

								public void SetInfo(int LEOCLKHBLED)
								{
									NHKHGMMELHL = LEOCLKHBLED;
									Actor controlActor = ActorManager.get_Instance().GetControlActor();
									if (controlActor == null)
									{
										return;
									}
									m_gameItemInfo = controlActor.get_m_gameItems().FPICNOOFDOA(LEOCLKHBLED);
									if (m_gameItemInfo == null)
									{
										m_itemIcon.set_spriteName("0");
										if (m_countLabel.gameObject.activeSelf)
										{
											m_countLabel.gameObject.SetActive(false);
										}
										return;
									}
									m_itemIcon.set_spriteName(string.Format("{0}", m_gameItemInfo.AGHCOCAJMCI().EHFEEIJKJHD()));
									int num = m_gameItemInfo.HENGMGCOBCP();
									if (num > 1)
									{
										if (!m_countLabel.gameObject.activeSelf)
										{
											m_countLabel.gameObject.SetActive(true);
										}
										m_countLabel.set_text(num.ToString());
									}
									else if (m_countLabel.gameObject.activeSelf)
									{
										m_countLabel.gameObject.SetActive(false);
									}
								}

								public void OOLEODIPDND()
								{
								}

								public void OKJEFNFAMOG()
								{
									DOHBFGODMDM(NHKHGMMELHL);
									if (m_gameItemInfo != null)
									{
										CPCKOMMBEMK();
									}
								}

								public void IJCPEFOBKHO()
								{
								}

								public void ICKGFCCICMI()
								{
									DOHBFGODMDM(NHKHGMMELHL);
								}

								public void NNKIJLOEFCG()
								{
									LFGIIMHPELB(NHKHGMMELHL);
								}
							}
