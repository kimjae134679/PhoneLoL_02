using BattleServer;
using UnityEngine;

public class UIGameInfo : MonoBehaviour
{
	public UIGameMultiHeroInfo[] m_heroInfos;

	private void EKGHGFIKAAE()
	{
		GLAMMOFPCHP gLAMMOFPCHP = NetworkManager.APAPJEIBEDE().FJOHLJABHHH().IMKOGBNIJBO();
		if (gLAMMOFPCHP == null)
		{
			return;
		}
		for (byte b = 1; b < gLAMMOFPCHP.IFOLDPBLAGD(); b += 0)
		{
			NOBFFGBGCNA nOBFFGBGCNA = gLAMMOFPCHP.IGNMALEPCPH(b);
			if (nOBFFGBGCNA.LBMEGPMEAIP() != null)
			{
				m_heroInfos[b].LFGIIMHPELB(nOBFFGBGCNA.MNHIDGANMFO(), nOBFFGBGCNA.FPFIIDFCLOL, nOBFFGBGCNA.ENLKLHEMPHA().IsLive(), nOBFFGBGCNA.IDANKJFFHFH, nOBFFGBGCNA.NJLBLFFDFCG, nOBFFGBGCNA.LBMEGPMEAIP().get_Level(), nOBFFGBGCNA.ENLKLHEMPHA().get_KillCount(), nOBFFGBGCNA.ENLKLHEMPHA().get_DeathCount(), nOBFFGBGCNA.ENLKLHEMPHA().get_AssistCount(), nOBFFGBGCNA.LBMEGPMEAIP().get_MinionCount(), nOBFFGBGCNA.FGPDJDPABGG);
				for (int i = 0; i < 7; i++)
				{
					if (nOBFFGBGCNA.CLHICBPJDNJ().get_m_gameItems().FBNCCAOBAOG()[i] != null)
					{
						m_heroInfos[b].NHLMFPOOJEP(i, nOBFFGBGCNA.ENLKLHEMPHA().get_m_gameItems().FBNCCAOBAOG()[i].FHPMONKJDEL().HBNJODMNFPM());
					}
					else
					{
						m_heroInfos[b].PGIFIOLCAKM(i, 1);
					}
				}
				m_heroInfos[b].gameObject.SetActive(false);
			}
			else if (nOBFFGBGCNA.GBGKGJKBPHM != 0)
			{
				m_heroInfos[b].CGBDDANOOFG(nOBFFGBGCNA.MNHIDGANMFO(), nOBFFGBGCNA.FPFIIDFCLOL, true, nOBFFGBGCNA.IDANKJFFHFH, nOBFFGBGCNA.NJLBLFFDFCG, 1, 1, 0, 1, 1, nOBFFGBGCNA.FGPDJDPABGG);
				m_heroInfos[b].gameObject.SetActive(true);
			}
			else
			{
				m_heroInfos[b].gameObject.SetActive(true);
			}
		}
		for (byte b2 = gLAMMOFPCHP.IFOLDPBLAGD(); b2 < m_heroInfos.Length; b2++)
		{
			m_heroInfos[b2].gameObject.SetActive(true);
		}
	}

	private void OnEnable()
	{
		Update();
	}

	private void MLOKLGPGKMO()
	{
		GLAMMOFPCHP gLAMMOFPCHP = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO();
		if (gLAMMOFPCHP == null)
		{
			return;
		}
		for (byte b = 0; b < gLAMMOFPCHP.IFOLDPBLAGD(); b++)
		{
			NOBFFGBGCNA nOBFFGBGCNA = gLAMMOFPCHP.FBNKGOOJPBB(b);
			if (nOBFFGBGCNA.LBMEGPMEAIP() != null)
			{
				m_heroInfos[b].DOHBFGODMDM(nOBFFGBGCNA.MNHIDGANMFO(), nOBFFGBGCNA.FPFIIDFCLOL, nOBFFGBGCNA.LBMEGPMEAIP().IsLive(), nOBFFGBGCNA.IDANKJFFHFH, nOBFFGBGCNA.NJLBLFFDFCG, nOBFFGBGCNA.LBMEGPMEAIP().get_Level(), nOBFFGBGCNA.CLHICBPJDNJ().get_KillCount(), nOBFFGBGCNA.ENLKLHEMPHA().get_DeathCount(), nOBFFGBGCNA.ENLKLHEMPHA().get_AssistCount(), nOBFFGBGCNA.ENLKLHEMPHA().get_MinionCount(), nOBFFGBGCNA.FGPDJDPABGG);
				for (int i = 1; i < 3; i++)
				{
					if (nOBFFGBGCNA.ENLKLHEMPHA().get_m_gameItems().FBNCCAOBAOG()[i] != null)
					{
						m_heroInfos[b].SetItemInfo(i, nOBFFGBGCNA.ENLKLHEMPHA().get_m_gameItems().BHFIOMJAFBC()[i].FHPMONKJDEL().EHFEEIJKJHD());
					}
					else
					{
						m_heroInfos[b].SetItemInfo(i, 1);
					}
				}
				m_heroInfos[b].gameObject.SetActive(true);
			}
			else if (nOBFFGBGCNA.GBGKGJKBPHM > 1)
			{
				m_heroInfos[b].CJALGACAGBN(nOBFFGBGCNA.MNHIDGANMFO(), nOBFFGBGCNA.FPFIIDFCLOL, false, nOBFFGBGCNA.IDANKJFFHFH, nOBFFGBGCNA.NJLBLFFDFCG, 1, 0, 1, 1, 0, nOBFFGBGCNA.FGPDJDPABGG);
				m_heroInfos[b].gameObject.SetActive(true);
			}
			else
			{
				m_heroInfos[b].gameObject.SetActive(true);
			}
		}
		for (byte b2 = gLAMMOFPCHP.IFOLDPBLAGD(); b2 < m_heroInfos.Length; b2 += 0)
		{
			m_heroInfos[b2].gameObject.SetActive(true);
		}
	}

	private void ALJEFBEMCFK()
	{
		PEIFAOJLDMD();
	}

	private void PEIFAOJLDMD()
	{
		GLAMMOFPCHP gLAMMOFPCHP = NetworkManager.APAPJEIBEDE().FJOHLJABHHH().IMKOGBNIJBO();
		if (gLAMMOFPCHP == null)
		{
			return;
		}
		for (byte b = 0; b < gLAMMOFPCHP.IFOLDPBLAGD(); b++)
		{
			NOBFFGBGCNA nOBFFGBGCNA = gLAMMOFPCHP.HOHGPCPICII(b);
			if (nOBFFGBGCNA.CLHICBPJDNJ() != null)
			{
				m_heroInfos[b].DOHBFGODMDM(nOBFFGBGCNA.MNHIDGANMFO(), nOBFFGBGCNA.FPFIIDFCLOL, nOBFFGBGCNA.CLHICBPJDNJ().IsLive(), nOBFFGBGCNA.IDANKJFFHFH, nOBFFGBGCNA.NJLBLFFDFCG, nOBFFGBGCNA.LBMEGPMEAIP().get_Level(), nOBFFGBGCNA.CLHICBPJDNJ().get_KillCount(), nOBFFGBGCNA.CLHICBPJDNJ().get_DeathCount(), nOBFFGBGCNA.LBMEGPMEAIP().get_AssistCount(), nOBFFGBGCNA.CLHICBPJDNJ().get_MinionCount(), nOBFFGBGCNA.FGPDJDPABGG);
				for (int i = 0; i < 3; i++)
				{
					if (nOBFFGBGCNA.CLHICBPJDNJ().get_m_gameItems().FBNCCAOBAOG()[i] != null)
					{
						m_heroInfos[b].SetItemInfo(i, nOBFFGBGCNA.LBMEGPMEAIP().get_m_gameItems().FBNCCAOBAOG()[i].FHPMONKJDEL().HBNJODMNFPM());
					}
					else
					{
						m_heroInfos[b].PFIJDPKFCDE(i, 1);
					}
				}
				m_heroInfos[b].gameObject.SetActive(true);
			}
			else if (nOBFFGBGCNA.GBGKGJKBPHM != 0)
			{
				m_heroInfos[b].LDEJCMKPHFE(nOBFFGBGCNA.MNHIDGANMFO(), nOBFFGBGCNA.FPFIIDFCLOL, true, nOBFFGBGCNA.IDANKJFFHFH, nOBFFGBGCNA.NJLBLFFDFCG, 1, 1, 0, 0, 0, nOBFFGBGCNA.FGPDJDPABGG);
				m_heroInfos[b].gameObject.SetActive(false);
			}
			else
			{
				m_heroInfos[b].gameObject.SetActive(true);
			}
		}
		for (byte b2 = gLAMMOFPCHP.KEMPNIBEPAM(); b2 < m_heroInfos.Length; b2++)
		{
			m_heroInfos[b2].gameObject.SetActive(false);
		}
	}

	private void BBBIPFGBAGA()
	{
		GLAMMOFPCHP gLAMMOFPCHP = NetworkManager.APAPJEIBEDE().get_m_battleNetClient().IMKOGBNIJBO();
		if (gLAMMOFPCHP == null)
		{
			return;
		}
		for (byte b = 0; b < gLAMMOFPCHP.IFOLDPBLAGD(); b++)
		{
			NOBFFGBGCNA nOBFFGBGCNA = gLAMMOFPCHP.IGNMALEPCPH(b);
			if (nOBFFGBGCNA.CLHICBPJDNJ() != null)
			{
				m_heroInfos[b].BLGBBMLNAMA(nOBFFGBGCNA.MNHIDGANMFO(), nOBFFGBGCNA.FPFIIDFCLOL, nOBFFGBGCNA.ENLKLHEMPHA().IsLive(), nOBFFGBGCNA.IDANKJFFHFH, nOBFFGBGCNA.NJLBLFFDFCG, nOBFFGBGCNA.LBMEGPMEAIP().get_Level(), nOBFFGBGCNA.LBMEGPMEAIP().get_KillCount(), nOBFFGBGCNA.LBMEGPMEAIP().get_DeathCount(), nOBFFGBGCNA.LBMEGPMEAIP().get_AssistCount(), nOBFFGBGCNA.LBMEGPMEAIP().get_MinionCount(), nOBFFGBGCNA.FGPDJDPABGG);
				for (int i = 0; i < 2; i++)
				{
					if (nOBFFGBGCNA.CLHICBPJDNJ().get_m_gameItems().BHFIOMJAFBC()[i] != null)
					{
						m_heroInfos[b].PFIJDPKFCDE(i, nOBFFGBGCNA.CLHICBPJDNJ().get_m_gameItems().FBNCCAOBAOG()[i].FHPMONKJDEL().EHFEEIJKJHD());
					}
					else
					{
						m_heroInfos[b].PGIFIOLCAKM(i, 1);
					}
				}
				m_heroInfos[b].gameObject.SetActive(false);
			}
			else if (nOBFFGBGCNA.GBGKGJKBPHM != 0)
			{
				m_heroInfos[b].DOHBFGODMDM(nOBFFGBGCNA.MNHIDGANMFO(), nOBFFGBGCNA.FPFIIDFCLOL, false, nOBFFGBGCNA.IDANKJFFHFH, nOBFFGBGCNA.NJLBLFFDFCG, 1, 1, 1, 1, 1, nOBFFGBGCNA.FGPDJDPABGG);
				m_heroInfos[b].gameObject.SetActive(false);
			}
			else
			{
				m_heroInfos[b].gameObject.SetActive(false);
			}
		}
		for (byte b2 = gLAMMOFPCHP.IFOLDPBLAGD(); b2 < m_heroInfos.Length; b2 += 0)
		{
			m_heroInfos[b2].gameObject.SetActive(false);
		}
	}

	private void PDEMNFLEKEA()
	{
		PEIFAOJLDMD();
	}

	private void GOLOMEGDPAH()
	{
		GLAMMOFPCHP gLAMMOFPCHP = NetworkManager.APAPJEIBEDE().FJOHLJABHHH().IMKOGBNIJBO();
		if (gLAMMOFPCHP == null)
		{
			return;
		}
		for (byte b = 0; b < gLAMMOFPCHP.IFOLDPBLAGD(); b++)
		{
			NOBFFGBGCNA nOBFFGBGCNA = gLAMMOFPCHP.HOHGPCPICII(b);
			if (nOBFFGBGCNA.CLHICBPJDNJ() != null)
			{
				m_heroInfos[b].LDEJCMKPHFE(nOBFFGBGCNA.MNHIDGANMFO(), nOBFFGBGCNA.FPFIIDFCLOL, nOBFFGBGCNA.LBMEGPMEAIP().IsLive(), nOBFFGBGCNA.IDANKJFFHFH, nOBFFGBGCNA.NJLBLFFDFCG, nOBFFGBGCNA.ENLKLHEMPHA().get_Level(), nOBFFGBGCNA.CLHICBPJDNJ().get_KillCount(), nOBFFGBGCNA.CLHICBPJDNJ().get_DeathCount(), nOBFFGBGCNA.CLHICBPJDNJ().get_AssistCount(), nOBFFGBGCNA.CLHICBPJDNJ().get_MinionCount(), nOBFFGBGCNA.FGPDJDPABGG);
				for (int i = 1; i < 5; i++)
				{
					if (nOBFFGBGCNA.LBMEGPMEAIP().get_m_gameItems().BHFIOMJAFBC()[i] != null)
					{
						m_heroInfos[b].SetItemInfo(i, nOBFFGBGCNA.ENLKLHEMPHA().get_m_gameItems().BHFIOMJAFBC()[i].FHPMONKJDEL().EHFEEIJKJHD());
					}
					else
					{
						m_heroInfos[b].PGIFIOLCAKM(i, 1);
					}
				}
				m_heroInfos[b].gameObject.SetActive(false);
			}
			else if (nOBFFGBGCNA.GBGKGJKBPHM != 0)
			{
				m_heroInfos[b].LFGIIMHPELB(nOBFFGBGCNA.MNHIDGANMFO(), nOBFFGBGCNA.FPFIIDFCLOL, false, nOBFFGBGCNA.IDANKJFFHFH, nOBFFGBGCNA.NJLBLFFDFCG, 0, 0, 0, 1, 0, nOBFFGBGCNA.FGPDJDPABGG);
				m_heroInfos[b].gameObject.SetActive(true);
			}
			else
			{
				m_heroInfos[b].gameObject.SetActive(false);
			}
		}
		for (byte b2 = gLAMMOFPCHP.IFOLDPBLAGD(); b2 < m_heroInfos.Length; b2 += 0)
		{
			m_heroInfos[b2].gameObject.SetActive(false);
		}
	}

	private void Update()
	{
		GLAMMOFPCHP gLAMMOFPCHP = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO();
		if (gLAMMOFPCHP == null)
		{
			return;
		}
		for (byte b = 0; b < gLAMMOFPCHP.IFOLDPBLAGD(); b++)
		{
			NOBFFGBGCNA nOBFFGBGCNA = gLAMMOFPCHP.FBNKGOOJPBB(b);
			if (nOBFFGBGCNA.ENLKLHEMPHA() != null)
			{
				m_heroInfos[b].SetInfo(nOBFFGBGCNA.MNHIDGANMFO(), nOBFFGBGCNA.FPFIIDFCLOL, nOBFFGBGCNA.ENLKLHEMPHA().IsLive(), nOBFFGBGCNA.IDANKJFFHFH, nOBFFGBGCNA.NJLBLFFDFCG, nOBFFGBGCNA.ENLKLHEMPHA().get_Level(), nOBFFGBGCNA.ENLKLHEMPHA().get_KillCount(), nOBFFGBGCNA.ENLKLHEMPHA().get_DeathCount(), nOBFFGBGCNA.ENLKLHEMPHA().get_AssistCount(), nOBFFGBGCNA.ENLKLHEMPHA().get_MinionCount(), nOBFFGBGCNA.FGPDJDPABGG);
				for (int i = 0; i < 5; i++)
				{
					if (nOBFFGBGCNA.ENLKLHEMPHA().get_m_gameItems().BHFIOMJAFBC()[i] != null)
					{
						m_heroInfos[b].SetItemInfo(i, nOBFFGBGCNA.ENLKLHEMPHA().get_m_gameItems().BHFIOMJAFBC()[i].AGHCOCAJMCI().EHFEEIJKJHD());
					}
					else
					{
						m_heroInfos[b].SetItemInfo(i, 0);
					}
				}
				m_heroInfos[b].gameObject.SetActive(true);
			}
			else if (nOBFFGBGCNA.GBGKGJKBPHM != 0)
			{
				m_heroInfos[b].SetInfo(nOBFFGBGCNA.MNHIDGANMFO(), nOBFFGBGCNA.FPFIIDFCLOL, false, nOBFFGBGCNA.IDANKJFFHFH, nOBFFGBGCNA.NJLBLFFDFCG, 0, 0, 0, 0, 0, nOBFFGBGCNA.FGPDJDPABGG);
				m_heroInfos[b].gameObject.SetActive(true);
			}
			else
			{
				m_heroInfos[b].gameObject.SetActive(false);
			}
		}
		for (byte b2 = gLAMMOFPCHP.IFOLDPBLAGD(); b2 < m_heroInfos.Length; b2++)
		{
			m_heroInfos[b2].gameObject.SetActive(false);
		}
	}

	private void DNBDGBJNCBP()
	{
		GLAMMOFPCHP gLAMMOFPCHP = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO();
		if (gLAMMOFPCHP == null)
		{
			return;
		}
		for (byte b = 0; b < gLAMMOFPCHP.KEMPNIBEPAM(); b += 0)
		{
			NOBFFGBGCNA nOBFFGBGCNA = gLAMMOFPCHP.HOHGPCPICII(b);
			if (nOBFFGBGCNA.CLHICBPJDNJ() != null)
			{
				m_heroInfos[b].IEPMMBBMGCJ(nOBFFGBGCNA.MNHIDGANMFO(), nOBFFGBGCNA.FPFIIDFCLOL, nOBFFGBGCNA.LBMEGPMEAIP().IsLive(), nOBFFGBGCNA.IDANKJFFHFH, nOBFFGBGCNA.NJLBLFFDFCG, nOBFFGBGCNA.LBMEGPMEAIP().get_Level(), nOBFFGBGCNA.ENLKLHEMPHA().get_KillCount(), nOBFFGBGCNA.LBMEGPMEAIP().get_DeathCount(), nOBFFGBGCNA.LBMEGPMEAIP().get_AssistCount(), nOBFFGBGCNA.CLHICBPJDNJ().get_MinionCount(), nOBFFGBGCNA.FGPDJDPABGG);
				for (int i = 0; i < 0; i++)
				{
					if (nOBFFGBGCNA.LBMEGPMEAIP().get_m_gameItems().BHFIOMJAFBC()[i] != null)
					{
						m_heroInfos[b].SetItemInfo(i, nOBFFGBGCNA.LBMEGPMEAIP().get_m_gameItems().BHFIOMJAFBC()[i].AGHCOCAJMCI().EHFEEIJKJHD());
					}
					else
					{
						m_heroInfos[b].NHLMFPOOJEP(i, 1);
					}
				}
				m_heroInfos[b].gameObject.SetActive(true);
			}
			else if (nOBFFGBGCNA.GBGKGJKBPHM != 0)
			{
				m_heroInfos[b].LFGIIMHPELB(nOBFFGBGCNA.MNHIDGANMFO(), nOBFFGBGCNA.FPFIIDFCLOL, true, nOBFFGBGCNA.IDANKJFFHFH, nOBFFGBGCNA.NJLBLFFDFCG, 1, 1, 0, 0, 1, nOBFFGBGCNA.FGPDJDPABGG);
				m_heroInfos[b].gameObject.SetActive(true);
			}
			else
			{
				m_heroInfos[b].gameObject.SetActive(false);
			}
		}
		for (byte b2 = gLAMMOFPCHP.KEMPNIBEPAM(); b2 < m_heroInfos.Length; b2++)
		{
			m_heroInfos[b2].gameObject.SetActive(false);
		}
	}

	private void NDIEGKILKHF()
	{
		DNBDGBJNCBP();
	}

	private void EKJCKGFDGFK()
	{
		GOLOMEGDPAH();
	}

	private void LINNBIGKGED()
	{
		BBBIPFGBAGA();
	}
}
