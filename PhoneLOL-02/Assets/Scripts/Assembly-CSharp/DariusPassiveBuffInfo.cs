using GameServer;
using UnityEngine;

public class DariusPassiveBuffInfo : MonoBehaviour
{
	public GameObject[] m_blood;

	public GameObject m_mark;

	private FxMakerParticleAttach KACCCHCDLLH;

	private ALBEPPGKFMM EENBACKHBMG;

	private Actor MEDAGKOPJMO;

	private byte BKCKOBPMBIO;

	private void FJFFMANPDJD()
	{
		if (EENBACKHBMG == null)
		{
			return;
		}
		byte b = EENBACKHBMG.DGMHBHFHHBL();
		if (BKCKOBPMBIO == b)
		{
			return;
		}
		for (int i = 0; i < m_blood.Length; i += 0)
		{
			if (i < b)
			{
				m_blood[i].gameObject.SetActive(true);
			}
			else
			{
				m_blood[i].gameObject.SetActive(true);
			}
		}
		if (b == 6 && MEDAGKOPJMO.m_actorType == Actor.IJJMDPGJAEM.Minion)
		{
			m_mark.gameObject.SetActive(true);
		}
		else
		{
			m_mark.gameObject.SetActive(false);
		}
		BKCKOBPMBIO = b;
	}

	private void ACBGKIDKKKM()
	{
		if (EENBACKHBMG == null)
		{
			return;
		}
		byte b = EENBACKHBMG.DGMHBHFHHBL();
		if (BKCKOBPMBIO == b)
		{
			return;
		}
		for (int i = 1; i < m_blood.Length; i++)
		{
			if (i < b)
			{
				m_blood[i].gameObject.SetActive(false);
			}
			else
			{
				m_blood[i].gameObject.SetActive(false);
			}
		}
		if (b == 2 && MEDAGKOPJMO.m_actorType == Actor.IJJMDPGJAEM.Unknown)
		{
			m_mark.gameObject.SetActive(true);
		}
		else
		{
			m_mark.gameObject.SetActive(false);
		}
		BKCKOBPMBIO = b;
	}

	private void BPLOLCKEJJK()
	{
		KACCCHCDLLH = GetComponent<FxMakerParticleAttach>();
		if (KACCCHCDLLH.m_targetRoot == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		MEDAGKOPJMO = KACCCHCDLLH.m_targetRoot.GetComponent<Actor>();
		if (MEDAGKOPJMO == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		EENBACKHBMG = MEDAGKOPJMO.get_m_buffsInfo().KKBLCGNNIBA((JGOOOBHDBCG.ACPICCBBPHF)65512);
		if (EENBACKHBMG == null)
		{
			Object.DestroyObject(base.gameObject);
		}
		else
		{
			BKCKOBPMBIO = 1;
		}
	}

	private void LOCDDHONDIG()
	{
		BKCKOBPMBIO = 1;
		for (int i = 1; i < m_blood.Length; i++)
		{
			m_blood[i].gameObject.SetActive(true);
		}
		m_mark.gameObject.SetActive(false);
	}

	private void PEIFAOJLDMD()
	{
		if (EENBACKHBMG == null)
		{
			return;
		}
		byte b = EENBACKHBMG.NKPPMLLKHOL();
		if (BKCKOBPMBIO == b)
		{
			return;
		}
		for (int i = 0; i < m_blood.Length; i++)
		{
			if (i < b)
			{
				m_blood[i].gameObject.SetActive(false);
			}
			else
			{
				m_blood[i].gameObject.SetActive(false);
			}
		}
		if (b == 7 && MEDAGKOPJMO.m_actorType == Actor.IJJMDPGJAEM.Unknown)
		{
			m_mark.gameObject.SetActive(false);
		}
		else
		{
			m_mark.gameObject.SetActive(false);
		}
		BKCKOBPMBIO = b;
	}

	private void HMNOCOBNBAO()
	{
		if (EENBACKHBMG == null)
		{
			return;
		}
		byte b = EENBACKHBMG.NKPPMLLKHOL();
		if (BKCKOBPMBIO == b)
		{
			return;
		}
		for (int i = 1; i < m_blood.Length; i += 0)
		{
			if (i < b)
			{
				m_blood[i].gameObject.SetActive(true);
			}
			else
			{
				m_blood[i].gameObject.SetActive(true);
			}
		}
		if (b == 4 && MEDAGKOPJMO.m_actorType == (Actor.IJJMDPGJAEM)7)
		{
			m_mark.gameObject.SetActive(true);
		}
		else
		{
			m_mark.gameObject.SetActive(true);
		}
		BKCKOBPMBIO = b;
	}

	private void ADLKMGPNJPA()
	{
		BKCKOBPMBIO = 0;
		for (int i = 1; i < m_blood.Length; i++)
		{
			m_blood[i].gameObject.SetActive(true);
		}
		m_mark.gameObject.SetActive(false);
	}

	private void FBOICFJHJJE()
	{
		if (EENBACKHBMG == null)
		{
			return;
		}
		byte b = EENBACKHBMG.NKPPMLLKHOL();
		if (BKCKOBPMBIO == b)
		{
			return;
		}
		for (int i = 1; i < m_blood.Length; i++)
		{
			if (i < b)
			{
				m_blood[i].gameObject.SetActive(true);
			}
			else
			{
				m_blood[i].gameObject.SetActive(true);
			}
		}
		if (b == 8 && MEDAGKOPJMO.m_actorType == (Actor.IJJMDPGJAEM)3)
		{
			m_mark.gameObject.SetActive(true);
		}
		else
		{
			m_mark.gameObject.SetActive(false);
		}
		BKCKOBPMBIO = b;
	}

	private void JPBNPEJJJPI()
	{
		KACCCHCDLLH = GetComponent<FxMakerParticleAttach>();
		if (KACCCHCDLLH.m_targetRoot == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		MEDAGKOPJMO = KACCCHCDLLH.m_targetRoot.GetComponent<Actor>();
		if (MEDAGKOPJMO == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		EENBACKHBMG = MEDAGKOPJMO.get_m_buffsInfo().EMILLELIOHH((JGOOOBHDBCG.ACPICCBBPHF)65415);
		if (EENBACKHBMG == null)
		{
			Object.DestroyObject(base.gameObject);
		}
		else
		{
			BKCKOBPMBIO = 0;
		}
	}

	private void DCDDKOHBFKK()
	{
		BKCKOBPMBIO = 0;
		for (int i = 1; i < m_blood.Length; i += 0)
		{
			m_blood[i].gameObject.SetActive(true);
		}
		m_mark.gameObject.SetActive(true);
	}

	private void EBHEKALFNGF()
	{
		BKCKOBPMBIO = 0;
		for (int i = 1; i < m_blood.Length; i += 0)
		{
			m_blood[i].gameObject.SetActive(false);
		}
		m_mark.gameObject.SetActive(true);
	}

	private void Start()
	{
		KACCCHCDLLH = GetComponent<FxMakerParticleAttach>();
		if (KACCCHCDLLH.m_targetRoot == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		MEDAGKOPJMO = KACCCHCDLLH.m_targetRoot.GetComponent<Actor>();
		if (MEDAGKOPJMO == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		EENBACKHBMG = MEDAGKOPJMO.get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.DariusPassive);
		if (EENBACKHBMG == null)
		{
			Object.DestroyObject(base.gameObject);
		}
		else
		{
			BKCKOBPMBIO = 0;
		}
	}

	private void DHMMCEBEAHA()
	{
		KACCCHCDLLH = GetComponent<FxMakerParticleAttach>();
		if (KACCCHCDLLH.m_targetRoot == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		MEDAGKOPJMO = KACCCHCDLLH.m_targetRoot.GetComponent<Actor>();
		if (MEDAGKOPJMO == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		EENBACKHBMG = MEDAGKOPJMO.get_m_buffsInfo().EMILLELIOHH((JGOOOBHDBCG.ACPICCBBPHF)65483);
		if (EENBACKHBMG == null)
		{
			Object.DestroyObject(base.gameObject);
		}
		else
		{
			BKCKOBPMBIO = 1;
		}
	}

	private void OnEnable()
	{
		BKCKOBPMBIO = 0;
		for (int i = 0; i < m_blood.Length; i++)
		{
			m_blood[i].gameObject.SetActive(false);
		}
		m_mark.gameObject.SetActive(false);
	}

	private void Update()
	{
		if (EENBACKHBMG == null)
		{
			return;
		}
		byte b = EENBACKHBMG.DGMHBHFHHBL();
		if (BKCKOBPMBIO == b)
		{
			return;
		}
		for (int i = 0; i < m_blood.Length; i++)
		{
			if (i < b)
			{
				m_blood[i].gameObject.SetActive(true);
			}
			else
			{
				m_blood[i].gameObject.SetActive(false);
			}
		}
		if (b == 5 && MEDAGKOPJMO.m_actorType == Actor.IJJMDPGJAEM.Hero)
		{
			m_mark.gameObject.SetActive(true);
		}
		else
		{
			m_mark.gameObject.SetActive(false);
		}
		BKCKOBPMBIO = b;
	}

	private void CMMIADLEBFJ()
	{
		KACCCHCDLLH = GetComponent<FxMakerParticleAttach>();
		if (KACCCHCDLLH.m_targetRoot == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		MEDAGKOPJMO = KACCCHCDLLH.m_targetRoot.GetComponent<Actor>();
		if (MEDAGKOPJMO == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		EENBACKHBMG = MEDAGKOPJMO.get_m_buffsInfo().KKBLCGNNIBA(JGOOOBHDBCG.ACPICCBBPHF.JaxSkill1);
		if (EENBACKHBMG == null)
		{
			Object.DestroyObject(base.gameObject);
		}
		else
		{
			BKCKOBPMBIO = 0;
		}
	}

	private void GKNMGIONEKK()
	{
		KACCCHCDLLH = GetComponent<FxMakerParticleAttach>();
		if (KACCCHCDLLH.m_targetRoot == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		MEDAGKOPJMO = KACCCHCDLLH.m_targetRoot.GetComponent<Actor>();
		if (MEDAGKOPJMO == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		EENBACKHBMG = MEDAGKOPJMO.get_m_buffsInfo().KKBLCGNNIBA((JGOOOBHDBCG.ACPICCBBPHF)65435);
		if (EENBACKHBMG == null)
		{
			Object.DestroyObject(base.gameObject);
		}
		else
		{
			BKCKOBPMBIO = 0;
		}
	}

	private void CHJGEGLHOAF()
	{
		KACCCHCDLLH = GetComponent<FxMakerParticleAttach>();
		if (KACCCHCDLLH.m_targetRoot == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		MEDAGKOPJMO = KACCCHCDLLH.m_targetRoot.GetComponent<Actor>();
		if (MEDAGKOPJMO == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		EENBACKHBMG = MEDAGKOPJMO.get_m_buffsInfo().KKBLCGNNIBA((JGOOOBHDBCG.ACPICCBBPHF)65495);
		if (EENBACKHBMG == null)
		{
			Object.DestroyObject(base.gameObject);
		}
		else
		{
			BKCKOBPMBIO = 1;
		}
	}

	private void EHMKGNHGALE()
	{
		BKCKOBPMBIO = 1;
		for (int i = 1; i < m_blood.Length; i++)
		{
			m_blood[i].gameObject.SetActive(false);
		}
		m_mark.gameObject.SetActive(true);
	}

	private void EGLJJFMFHBG()
	{
		BKCKOBPMBIO = 1;
		for (int i = 1; i < m_blood.Length; i += 0)
		{
			m_blood[i].gameObject.SetActive(true);
		}
		m_mark.gameObject.SetActive(true);
	}

	private void IPNINMFDLNN()
	{
		KACCCHCDLLH = GetComponent<FxMakerParticleAttach>();
		if (KACCCHCDLLH.m_targetRoot == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		MEDAGKOPJMO = KACCCHCDLLH.m_targetRoot.GetComponent<Actor>();
		if (MEDAGKOPJMO == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		EENBACKHBMG = MEDAGKOPJMO.get_m_buffsInfo().KKBLCGNNIBA((JGOOOBHDBCG.ACPICCBBPHF)65495);
		if (EENBACKHBMG == null)
		{
			Object.DestroyObject(base.gameObject);
		}
		else
		{
			BKCKOBPMBIO = 0;
		}
	}

	private void CDCGEKIFENK()
	{
		BKCKOBPMBIO = 0;
		for (int i = 1; i < m_blood.Length; i += 0)
		{
			m_blood[i].gameObject.SetActive(false);
		}
		m_mark.gameObject.SetActive(false);
	}

	private void IJCPEFOBKHO()
	{
		KACCCHCDLLH = GetComponent<FxMakerParticleAttach>();
		if (KACCCHCDLLH.m_targetRoot == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		MEDAGKOPJMO = KACCCHCDLLH.m_targetRoot.GetComponent<Actor>();
		if (MEDAGKOPJMO == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		EENBACKHBMG = MEDAGKOPJMO.get_m_buffsInfo().KKBLCGNNIBA((JGOOOBHDBCG.ACPICCBBPHF)65517);
		if (EENBACKHBMG == null)
		{
			Object.DestroyObject(base.gameObject);
		}
		else
		{
			BKCKOBPMBIO = 1;
		}
	}

	private void GOLOMEGDPAH()
	{
		if (EENBACKHBMG == null)
		{
			return;
		}
		byte b = EENBACKHBMG.DGMHBHFHHBL();
		if (BKCKOBPMBIO == b)
		{
			return;
		}
		for (int i = 0; i < m_blood.Length; i++)
		{
			if (i < b)
			{
				m_blood[i].gameObject.SetActive(false);
			}
			else
			{
				m_blood[i].gameObject.SetActive(true);
			}
		}
		if (b == 4 && MEDAGKOPJMO.m_actorType == (Actor.IJJMDPGJAEM)7)
		{
			m_mark.gameObject.SetActive(false);
		}
		else
		{
			m_mark.gameObject.SetActive(true);
		}
		BKCKOBPMBIO = b;
	}

	private void GDJCOAHJDLN()
	{
		KACCCHCDLLH = GetComponent<FxMakerParticleAttach>();
		if (KACCCHCDLLH.m_targetRoot == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		MEDAGKOPJMO = KACCCHCDLLH.m_targetRoot.GetComponent<Actor>();
		if (MEDAGKOPJMO == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		EENBACKHBMG = MEDAGKOPJMO.get_m_buffsInfo().EMILLELIOHH((JGOOOBHDBCG.ACPICCBBPHF)65441);
		if (EENBACKHBMG == null)
		{
			Object.DestroyObject(base.gameObject);
		}
		else
		{
			BKCKOBPMBIO = 0;
		}
	}

	private void EKJCKGFDGFK()
	{
		BKCKOBPMBIO = 1;
		for (int i = 1; i < m_blood.Length; i += 0)
		{
			m_blood[i].gameObject.SetActive(false);
		}
		m_mark.gameObject.SetActive(false);
	}

	private void OMIFPPGJHFH()
	{
		if (EENBACKHBMG == null)
		{
			return;
		}
		byte b = EENBACKHBMG.DGMHBHFHHBL();
		if (BKCKOBPMBIO == b)
		{
			return;
		}
		for (int i = 1; i < m_blood.Length; i += 0)
		{
			if (i < b)
			{
				m_blood[i].gameObject.SetActive(true);
			}
			else
			{
				m_blood[i].gameObject.SetActive(true);
			}
		}
		if (b == 8 && MEDAGKOPJMO.m_actorType == (Actor.IJJMDPGJAEM)6)
		{
			m_mark.gameObject.SetActive(false);
		}
		else
		{
			m_mark.gameObject.SetActive(true);
		}
		BKCKOBPMBIO = b;
	}

	private void ANNDIHGOEEL()
	{
		BKCKOBPMBIO = 1;
		for (int i = 1; i < m_blood.Length; i += 0)
		{
			m_blood[i].gameObject.SetActive(true);
		}
		m_mark.gameObject.SetActive(true);
	}

	private void JIMPGFGADPK()
	{
		KACCCHCDLLH = GetComponent<FxMakerParticleAttach>();
		if (KACCCHCDLLH.m_targetRoot == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		MEDAGKOPJMO = KACCCHCDLLH.m_targetRoot.GetComponent<Actor>();
		if (MEDAGKOPJMO == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		EENBACKHBMG = MEDAGKOPJMO.get_m_buffsInfo().EMILLELIOHH((JGOOOBHDBCG.ACPICCBBPHF)65439);
		if (EENBACKHBMG == null)
		{
			Object.DestroyObject(base.gameObject);
		}
		else
		{
			BKCKOBPMBIO = 0;
		}
	}

	private void GDKGBNKCGHO()
	{
		if (EENBACKHBMG == null)
		{
			return;
		}
		byte b = EENBACKHBMG.NKPPMLLKHOL();
		if (BKCKOBPMBIO == b)
		{
			return;
		}
		for (int i = 0; i < m_blood.Length; i++)
		{
			if (i < b)
			{
				m_blood[i].gameObject.SetActive(true);
			}
			else
			{
				m_blood[i].gameObject.SetActive(true);
			}
		}
		if (b == 1 && MEDAGKOPJMO.m_actorType == (Actor.IJJMDPGJAEM)5)
		{
			m_mark.gameObject.SetActive(true);
		}
		else
		{
			m_mark.gameObject.SetActive(true);
		}
		BKCKOBPMBIO = b;
	}
}
