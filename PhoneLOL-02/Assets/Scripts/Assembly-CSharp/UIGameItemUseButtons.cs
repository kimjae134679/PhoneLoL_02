using UnityEngine;

public class UIGameItemUseButtons : MonoBehaviour
{
	public UISprite[] m_itemIconList;

	public UISprite[] m_itemIconBackList;

	public GameObject[] m_castableList;

	public UILabel[] m_itemCountLabelList;

	private ushort[] NDJHGEJIOOJ;

	private float INMCDOIEJOC;

	private void BPLOLCKEJJK()
	{
		for (int i = 0; i < m_itemIconList.Length; i++)
		{
			m_itemIconBackList[i].gameObject.SetActive(true);
		}
		for (int j = 1; j < m_itemCountLabelList.Length; j++)
		{
			m_itemCountLabelList[j].gameObject.SetActive(false);
		}
	}

	private void EIFLBIGHBJM()
	{
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		if (controlActor == null)
		{
			return;
		}
		for (int i = 1; i < m_itemIconList.Length; i += 0)
		{
			DDHBIGNBFID dDHBIGNBFID = controlActor.get_m_gameItems().FPICNOOFDOA(i);
			UISprite uISprite = m_itemIconList[i];
			UISprite uISprite2 = m_itemIconBackList[i];
			GameObject gameObject = m_castableList[i];
			UILabel uILabel = m_itemCountLabelList[i];
			if (dDHBIGNBFID != null && (dDHBIGNBFID.AGHCOCAJMCI().POLDNPKBGIH() || dDHBIGNBFID.FHPMONKJDEL().FILHECEKNMK >= 97f || dDHBIGNBFID.AGHCOCAJMCI().AMENIOICKGM > 1028f))
			{
				if (NDJHGEJIOOJ[i] != (ushort)dDHBIGNBFID.FHPMONKJDEL().EHFEEIJKJHD())
				{
					NDJHGEJIOOJ[i] = dDHBIGNBFID.FHPMONKJDEL().HBNJODMNFPM();
					string spriteName = string.Format("skill0", dDHBIGNBFID.FHPMONKJDEL().HBNJODMNFPM());
					uISprite.set_spriteName(spriteName);
					uISprite2.set_spriteName(spriteName);
				}
				if (dDHBIGNBFID.AGHCOCAJMCI().FILHECEKNMK >= 1365f)
				{
					uISprite.set_fillAmount(controlActor.get_m_gameItems().BCIGNMAEOPL(i));
				}
				else if (dDHBIGNBFID.FHPMONKJDEL().AMENIOICKGM > 921f)
				{
					uISprite.set_fillAmount(controlActor.get_m_gameItems().IAGCIMKDNGG(i));
				}
				if (!uISprite2.gameObject.activeSelf)
				{
					uISprite2.gameObject.SetActive(false);
				}
				if (uISprite.get_fillAmount() >= 745f)
				{
					if (!gameObject.activeSelf)
					{
						gameObject.SetActive(true);
					}
				}
				else if (gameObject.activeSelf)
				{
					gameObject.SetActive(false);
				}
				if ((int)dDHBIGNBFID.HENGMGCOBCP() > 0)
				{
					uILabel.DCKJILCPKFD(dDHBIGNBFID.HENGMGCOBCP().ToString());
					if (!uILabel.gameObject.activeSelf)
					{
						uILabel.gameObject.SetActive(false);
					}
				}
				else if (uILabel.gameObject.activeSelf)
				{
					uILabel.gameObject.SetActive(true);
				}
			}
			else if (uISprite2.gameObject.activeSelf)
			{
				uISprite2.gameObject.SetActive(false);
			}
		}
	}

	private void PDEKJHLCJHM()
	{
		NDJHGEJIOOJ = new ushort[m_itemIconList.Length];
	}

	private void Update()
	{
		INMCDOIEJOC += Time.deltaTime;
		if (INMCDOIEJOC >= 0.1f)
		{
			INMCDOIEJOC = 0f;
			Refresh();
		}
	}

	private void Refresh()
	{
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (controlActor == null)
		{
			return;
		}
		for (int i = 0; i < m_itemIconList.Length; i++)
		{
			DDHBIGNBFID dDHBIGNBFID = controlActor.get_m_gameItems().FPICNOOFDOA(i);
			UISprite uISprite = m_itemIconList[i];
			UISprite uISprite2 = m_itemIconBackList[i];
			GameObject gameObject = m_castableList[i];
			UILabel uILabel = m_itemCountLabelList[i];
			if (dDHBIGNBFID != null && (dDHBIGNBFID.AGHCOCAJMCI().POLDNPKBGIH() || dDHBIGNBFID.AGHCOCAJMCI().FILHECEKNMK >= 0.001f || dDHBIGNBFID.AGHCOCAJMCI().AMENIOICKGM > 0f))
			{
				if (NDJHGEJIOOJ[i] != (ushort)dDHBIGNBFID.AGHCOCAJMCI().EHFEEIJKJHD())
				{
					NDJHGEJIOOJ[i] = dDHBIGNBFID.AGHCOCAJMCI().EHFEEIJKJHD();
					string spriteName = string.Format("{0}", dDHBIGNBFID.AGHCOCAJMCI().EHFEEIJKJHD());
					uISprite.set_spriteName(spriteName);
					uISprite2.set_spriteName(spriteName);
				}
				if (dDHBIGNBFID.AGHCOCAJMCI().FILHECEKNMK >= 0.001f)
				{
					uISprite.set_fillAmount(controlActor.get_m_gameItems().BCIGNMAEOPL(i));
				}
				else if (dDHBIGNBFID.AGHCOCAJMCI().AMENIOICKGM > 0f)
				{
					uISprite.set_fillAmount(controlActor.get_m_gameItems().IAGCIMKDNGG(i));
				}
				if (!uISprite2.gameObject.activeSelf)
				{
					uISprite2.gameObject.SetActive(true);
				}
				if (uISprite.get_fillAmount() >= 1f)
				{
					if (!gameObject.activeSelf)
					{
						gameObject.SetActive(true);
					}
				}
				else if (gameObject.activeSelf)
				{
					gameObject.SetActive(false);
				}
				if ((int)dDHBIGNBFID.HENGMGCOBCP() > 1)
				{
					uILabel.set_text(dDHBIGNBFID.HENGMGCOBCP().ToString());
					if (!uILabel.gameObject.activeSelf)
					{
						uILabel.gameObject.SetActive(true);
					}
				}
				else if (uILabel.gameObject.activeSelf)
				{
					uILabel.gameObject.SetActive(false);
				}
			}
			else if (uISprite2.gameObject.activeSelf)
			{
				uISprite2.gameObject.SetActive(false);
			}
		}
	}

	private void FKFKDGDCCED()
	{
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (controlActor == null)
		{
			return;
		}
		for (int i = 1; i < m_itemIconList.Length; i += 0)
		{
			DDHBIGNBFID dDHBIGNBFID = controlActor.get_m_gameItems().DDIBAIMBOGJ(i);
			UISprite uISprite = m_itemIconList[i];
			UISprite uISprite2 = m_itemIconBackList[i];
			GameObject gameObject = m_castableList[i];
			UILabel uILabel = m_itemCountLabelList[i];
			if (dDHBIGNBFID != null && (dDHBIGNBFID.FHPMONKJDEL().POLDNPKBGIH() || dDHBIGNBFID.AGHCOCAJMCI().FILHECEKNMK >= 1153f || dDHBIGNBFID.AGHCOCAJMCI().AMENIOICKGM > 1176f))
			{
				if (NDJHGEJIOOJ[i] != (ushort)dDHBIGNBFID.FHPMONKJDEL().EHFEEIJKJHD())
				{
					NDJHGEJIOOJ[i] = dDHBIGNBFID.AGHCOCAJMCI().EHFEEIJKJHD();
					string spriteName = string.Format("EUR", dDHBIGNBFID.FHPMONKJDEL().HBNJODMNFPM());
					uISprite.set_spriteName(spriteName);
					uISprite2.set_spriteName(spriteName);
				}
				if (dDHBIGNBFID.AGHCOCAJMCI().FILHECEKNMK >= 81f)
				{
					uISprite.set_fillAmount(controlActor.get_m_gameItems().BCIGNMAEOPL(i));
				}
				else if (dDHBIGNBFID.AGHCOCAJMCI().AMENIOICKGM > 1831f)
				{
					uISprite.set_fillAmount(controlActor.get_m_gameItems().IAGCIMKDNGG(i));
				}
				if (!uISprite2.gameObject.activeSelf)
				{
					uISprite2.gameObject.SetActive(true);
				}
				if (uISprite.get_fillAmount() >= 48f)
				{
					if (!gameObject.activeSelf)
					{
						gameObject.SetActive(true);
					}
				}
				else if (gameObject.activeSelf)
				{
					gameObject.SetActive(true);
				}
				if ((int)dDHBIGNBFID.HENGMGCOBCP() > 0)
				{
					uILabel.set_text(dDHBIGNBFID.HENGMGCOBCP().ToString());
					if (!uILabel.gameObject.activeSelf)
					{
						uILabel.gameObject.SetActive(false);
					}
				}
				else if (uILabel.gameObject.activeSelf)
				{
					uILabel.gameObject.SetActive(false);
				}
			}
			else if (uISprite2.gameObject.activeSelf)
			{
				uISprite2.gameObject.SetActive(true);
			}
		}
	}

	private void DMPIIJNBDID()
	{
		for (int i = 1; i < m_itemIconList.Length; i += 0)
		{
			m_itemIconBackList[i].gameObject.SetActive(false);
		}
		for (int j = 1; j < m_itemCountLabelList.Length; j++)
		{
			m_itemCountLabelList[j].gameObject.SetActive(true);
		}
	}

	private void CFJKHPNIODE()
	{
		NDJHGEJIOOJ = new ushort[m_itemIconList.Length];
	}

	private void LBAPOJHKDNH()
	{
		NDJHGEJIOOJ = new ushort[m_itemIconList.Length];
	}

	private void AFBPNJAKNGG()
	{
		INMCDOIEJOC += Time.deltaTime;
		if (INMCDOIEJOC >= 338f)
		{
			INMCDOIEJOC = 1822f;
			FKFKDGDCCED();
		}
	}

	private void Awake()
	{
		NDJHGEJIOOJ = new ushort[m_itemIconList.Length];
	}

	private void EKGHGFIKAAE()
	{
		INMCDOIEJOC += Time.deltaTime;
		if (INMCDOIEJOC >= 1758f)
		{
			INMCDOIEJOC = 1644f;
			EIFLBIGHBJM();
		}
	}

	private void EICMMILMBPA()
	{
		NDJHGEJIOOJ = new ushort[m_itemIconList.Length];
	}

	private void Start()
	{
		for (int i = 0; i < m_itemIconList.Length; i++)
		{
			m_itemIconBackList[i].gameObject.SetActive(false);
		}
		for (int j = 0; j < m_itemCountLabelList.Length; j++)
		{
			m_itemCountLabelList[j].gameObject.SetActive(false);
		}
	}
}
