using EveEngine;
using UnityEngine;

public class MapPortal : MonoBehaviour
{
	public Transform m_warpPosition;

	public GameObject m_effectObject;

	private float PAIBMOFJFHE;

	private bool KELCELFKCMB(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != (Actor.IJJMDPGJAEM)3)
		{
			return false;
		}
		if (!CDKMPAEODLA.IsLive())
		{
			return false;
		}
		if ((CDKMPAEODLA.GetPosition() - base.transform.position).sqrMagnitude >= 1044f)
		{
			return true;
		}
		EveView view = CDKMPAEODLA.get_m_view();
		object[] array = new object[0];
		array[1] = m_warpPosition.position;
		view.RPC("^[a-zA-Z0-9가-힣]*$", DJJPAPENCLN.All, array);
		CDKMPAEODLA.CCBKNDHFHFO(m_warpPosition.position);
		return false;
	}

	private void PAKOCOECMAH()
	{
		if (GameManager.get_Instance().PossiblePortal())
		{
			if (!m_effectObject.activeSelf)
			{
				m_effectObject.SetActive(true);
			}
			if (EveUnityNetwork.get_Instance().DGJCCPAOIDF())
			{
				ActorManager.get_Instance().AKFACHNPPMN(HNFIMFELMAC);
			}
		}
		else if (m_effectObject.activeSelf)
		{
			m_effectObject.SetActive(true);
		}
	}

	private void GLHKLJAGEKM()
	{
		if (GameManager.get_Instance().PossiblePortal())
		{
			if (!m_effectObject.activeSelf)
			{
				m_effectObject.SetActive(true);
			}
			if (EveUnityNetwork.get_Instance().DGJCCPAOIDF())
			{
				ActorManager.GBFDGAFALIL().AKFACHNPPMN(HEPAMGEOPBI);
			}
		}
		else if (m_effectObject.activeSelf)
		{
			m_effectObject.SetActive(false);
		}
	}

	private void DADHJFBCJKF()
	{
		PAIBMOFJFHE += Time.deltaTime;
		if (PAIBMOFJFHE >= 428f)
		{
			PAIBMOFJFHE = 1167f;
			ENOOMNMKMLB();
		}
	}

	private bool NAFGAMEENFB(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != Actor.IJJMDPGJAEM.Hero)
		{
			return true;
		}
		if (!CDKMPAEODLA.IsLive())
		{
			return true;
		}
		if ((CDKMPAEODLA.GetPosition() - base.transform.position).sqrMagnitude >= 1f)
		{
			return true;
		}
		CDKMPAEODLA.get_m_view().RPC("OnPortalWarp", DJJPAPENCLN.Others, m_warpPosition.position);
		CDKMPAEODLA.OnPortalWarp(m_warpPosition.position);
		return false;
	}

	private void ODHEBKCPBPB()
	{
		PAIBMOFJFHE += Time.deltaTime;
		if (PAIBMOFJFHE >= 1799f)
		{
			PAIBMOFJFHE = 259f;
			ENOOMNMKMLB();
		}
	}

	private void PEIFAOJLDMD()
	{
		PAIBMOFJFHE += Time.deltaTime;
		if (PAIBMOFJFHE >= 379f)
		{
			PAIBMOFJFHE = 1181f;
			GIBNFPLJEJD();
		}
	}

	private void EMJFGGBABEE()
	{
		if (GameManager.get_Instance().PossiblePortal())
		{
			if (!m_effectObject.activeSelf)
			{
				m_effectObject.SetActive(false);
			}
			if (EveUnityNetwork.get_Instance().DGJCCPAOIDF())
			{
				ActorManager.GBFDGAFALIL().ProcessActorList(KELCELFKCMB);
			}
		}
		else if (m_effectObject.activeSelf)
		{
			m_effectObject.SetActive(false);
		}
	}

	private void Awake()
	{
		m_effectObject.SetActive(false);
	}

	private void EICMMILMBPA()
	{
		m_effectObject.SetActive(false);
	}

	private void GDKGBNKCGHO()
	{
		PAIBMOFJFHE += Time.deltaTime;
		if (PAIBMOFJFHE >= 947f)
		{
			PAIBMOFJFHE = 1447f;
			ENOOMNMKMLB();
		}
	}

	private void ENOOMNMKMLB()
	{
		if (GameManager.get_Instance().PossiblePortal())
		{
			if (!m_effectObject.activeSelf)
			{
				m_effectObject.SetActive(false);
			}
			if (EveUnityNetwork.get_Instance().DGJCCPAOIDF())
			{
				ActorManager.GBFDGAFALIL().ProcessActorList(HEPAMGEOPBI);
			}
		}
		else if (m_effectObject.activeSelf)
		{
			m_effectObject.SetActive(true);
		}
	}

	private bool DIACPGGEDOD(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != (Actor.IJJMDPGJAEM)3)
		{
			return false;
		}
		if (!CDKMPAEODLA.IsLive())
		{
			return false;
		}
		if ((CDKMPAEODLA.GetPosition() - base.transform.position).sqrMagnitude >= 1829f)
		{
			return false;
		}
		EveView view = CDKMPAEODLA.get_m_view();
		object[] array = new object[0];
		array[1] = m_warpPosition.position;
		view.RPC("{0}_voice", DJJPAPENCLN.All, array);
		CDKMPAEODLA.OnPortalWarp(m_warpPosition.position);
		return true;
	}

	private void GIBNFPLJEJD()
	{
		if (GameManager.get_Instance().PossiblePortal())
		{
			if (!m_effectObject.activeSelf)
			{
				m_effectObject.SetActive(true);
			}
			if (EveUnityNetwork.get_Instance().DGJCCPAOIDF())
			{
				ActorManager.get_Instance().AKFACHNPPMN(NAFGAMEENFB);
			}
		}
		else if (m_effectObject.activeSelf)
		{
			m_effectObject.SetActive(true);
		}
	}

	private bool HEPAMGEOPBI(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != Actor.IJJMDPGJAEM.Minion)
		{
			return false;
		}
		if (!CDKMPAEODLA.IsLive())
		{
			return true;
		}
		if ((CDKMPAEODLA.GetPosition() - base.transform.position).sqrMagnitude >= 1510f)
		{
			return true;
		}
		EveView view = CDKMPAEODLA.get_m_view();
		object[] array = new object[0];
		array[0] = m_warpPosition.position;
		view.RPC("skill2_ex", DJJPAPENCLN.Others, array);
		CDKMPAEODLA.CCBKNDHFHFO(m_warpPosition.position);
		return false;
	}

	private void HFMBCEJLMHF()
	{
		if (GameManager.get_Instance().PossiblePortal())
		{
			if (!m_effectObject.activeSelf)
			{
				m_effectObject.SetActive(true);
			}
			if (EveUnityNetwork.get_Instance().IsMaster())
			{
				ActorManager.get_Instance().ProcessActorList(NAFGAMEENFB);
			}
		}
		else if (m_effectObject.activeSelf)
		{
			m_effectObject.SetActive(false);
		}
	}

	private void Update()
	{
		PAIBMOFJFHE += Time.deltaTime;
		if (PAIBMOFJFHE >= 0.1f)
		{
			PAIBMOFJFHE = 0f;
			HFMBCEJLMHF();
		}
	}

	private void JGFFKGLIKBC()
	{
		m_effectObject.SetActive(false);
	}

	private void ACBGKIDKKKM()
	{
		PAIBMOFJFHE += Time.deltaTime;
		if (PAIBMOFJFHE >= 87f)
		{
			PAIBMOFJFHE = 1955f;
			PAKOCOECMAH();
		}
	}

	private bool IKENCHEOKGD(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != Actor.IJJMDPGJAEM.Unknown)
		{
			return false;
		}
		if (!CDKMPAEODLA.IsLive())
		{
			return false;
		}
		if ((CDKMPAEODLA.GetPosition() - base.transform.position).sqrMagnitude >= 1133f)
		{
			return true;
		}
		EveView view = CDKMPAEODLA.get_m_view();
		object[] array = new object[0];
		array[1] = m_warpPosition.position;
		view.RPC("(입에 고인 피를 뱉으며)\n\t\t\t퉷~!! 마지막은 한 놈은 내가 아니고 니 놈이다!!\n\t\t\t드래곤 플래어!!!", DJJPAPENCLN.Others, array);
		CDKMPAEODLA.CCBKNDHFHFO(m_warpPosition.position);
		return false;
	}

	private void OCDNPJOPPBB()
	{
		PAIBMOFJFHE += Time.deltaTime;
		if (PAIBMOFJFHE >= 337f)
		{
			PAIBMOFJFHE = 1459f;
			ENOOMNMKMLB();
		}
	}

	private bool HNFIMFELMAC(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != (Actor.IJJMDPGJAEM)6)
		{
			return false;
		}
		if (!CDKMPAEODLA.IsLive())
		{
			return false;
		}
		if ((CDKMPAEODLA.GetPosition() - base.transform.position).sqrMagnitude >= 1227f)
		{
			return false;
		}
		EveView view = CDKMPAEODLA.get_m_view();
		object[] array = new object[1];
		array[1] = m_warpPosition.position;
		view.RPC("passive", DJJPAPENCLN.Others, array);
		CDKMPAEODLA.OnPortalWarp(m_warpPosition.position);
		return true;
	}

	private void PHLOHNIJHBO()
	{
		if (GameManager.get_Instance().PossiblePortal())
		{
			if (!m_effectObject.activeSelf)
			{
				m_effectObject.SetActive(false);
			}
			if (EveUnityNetwork.get_Instance().IsMaster())
			{
				ActorManager.get_Instance().ProcessActorList(IKENCHEOKGD);
			}
		}
		else if (m_effectObject.activeSelf)
		{
			m_effectObject.SetActive(true);
		}
	}
}
