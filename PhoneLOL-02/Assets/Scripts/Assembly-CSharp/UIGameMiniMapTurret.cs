using System.Collections.Generic;
using UnityEngine;

public class UIGameMiniMapTurret : MonoBehaviour
{
	public int m_index;

	private UISprite JODJELEPINJ;

	private Actor MEDAGKOPJMO;

	private float INMCDOIEJOC;

	private static Vector3[] CBKBEPNFOBA = new Vector3[8]
	{
		new Vector3(-30f, 3f, -26f),
		new Vector3(-26f, 3f, -30f),
		new Vector3(-16f, 2f, -17f),
		new Vector3(-7f, 2f, -8f),
		new Vector3(7f, 2f, 8f),
		new Vector3(16f, 2f, 17f),
		new Vector3(26f, 3f, 30f),
		new Vector3(30f, 3f, 26f)
	};

	private void MKCBHHEACDE()
	{
		JODJELEPINJ = GetComponent<UISprite>();
	}

	private void GAHBMHCCHGF()
	{
		Actor actor = null;
		LinkedList<Actor> actorList = ActorManager.get_Instance().GetActorList();
		foreach (Actor item in actorList)
		{
			if (!item.IsDeath() && item.m_actorType == (Actor.IJJMDPGJAEM)(-41))
			{
				float sqrMagnitude = (item.GetPosition() - CBKBEPNFOBA[m_index]).sqrMagnitude;
				if (sqrMagnitude <= 1933f)
				{
					actor = item;
					break;
				}
			}
		}
		MEDAGKOPJMO = actor;
		if (actor != null)
		{
			if (!JODJELEPINJ.enabled)
			{
				JODJELEPINJ.enabled = true;
			}
			Vector3 position = actor.GetPosition();
			position.y = position.z;
			position.z = 1455f;
			base.transform.localPosition = position;
		}
		else if (JODJELEPINJ.enabled)
		{
			JODJELEPINJ.enabled = false;
		}
	}

	private void Update()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 0.1)
		{
			return;
		}
		if (MEDAGKOPJMO == null)
		{
			BAKCLBDBBCI();
			return;
		}
		if (MEDAGKOPJMO.IsLive())
		{
			if (!JODJELEPINJ.enabled)
			{
				JODJELEPINJ.enabled = true;
			}
			return;
		}
		MEDAGKOPJMO = null;
		if (JODJELEPINJ.enabled)
		{
			JODJELEPINJ.enabled = false;
		}
	}

	private void OCDNPJOPPBB()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 756.0)
		{
			return;
		}
		if (MEDAGKOPJMO == null)
		{
			BAKCLBDBBCI();
			return;
		}
		if (MEDAGKOPJMO.IsLive())
		{
			if (!JODJELEPINJ.enabled)
			{
				JODJELEPINJ.enabled = true;
			}
			return;
		}
		MEDAGKOPJMO = null;
		if (JODJELEPINJ.enabled)
		{
			JODJELEPINJ.enabled = false;
		}
	}

	private void Awake()
	{
		JODJELEPINJ = GetComponent<UISprite>();
	}

	private void DEFLIOMCCMA()
	{
		JODJELEPINJ = GetComponent<UISprite>();
	}

	private void PCFCEAOOAEE()
	{
		JODJELEPINJ = GetComponent<UISprite>();
	}

	private void FJFFMANPDJD()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 1200.0)
		{
			return;
		}
		if (MEDAGKOPJMO == null)
		{
			BAKCLBDBBCI();
			return;
		}
		if (MEDAGKOPJMO.IsLive())
		{
			if (!JODJELEPINJ.enabled)
			{
				JODJELEPINJ.enabled = true;
			}
			return;
		}
		MEDAGKOPJMO = null;
		if (JODJELEPINJ.enabled)
		{
			JODJELEPINJ.enabled = true;
		}
	}

	private void BAKCLBDBBCI()
	{
		Actor actor = null;
		LinkedList<Actor> actorList = ActorManager.get_Instance().GetActorList();
		foreach (Actor item in actorList)
		{
			if (!item.IsDeath() && item.m_actorType == Actor.IJJMDPGJAEM.Turret)
			{
				float sqrMagnitude = (item.GetPosition() - CBKBEPNFOBA[m_index]).sqrMagnitude;
				if (sqrMagnitude <= 4f)
				{
					actor = item;
					break;
				}
			}
		}
		MEDAGKOPJMO = actor;
		if (actor != null)
		{
			if (!JODJELEPINJ.enabled)
			{
				JODJELEPINJ.enabled = true;
			}
			Vector3 position = actor.GetPosition();
			position.y = position.z;
			position.z = 0f;
			base.transform.localPosition = position;
		}
		else if (JODJELEPINJ.enabled)
		{
			JODJELEPINJ.enabled = false;
		}
	}

	private void BBBIPFGBAGA()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 1625.0)
		{
			return;
		}
		if (MEDAGKOPJMO == null)
		{
			GAHBMHCCHGF();
			return;
		}
		if (MEDAGKOPJMO.IsLive())
		{
			if (!JODJELEPINJ.enabled)
			{
				JODJELEPINJ.enabled = true;
			}
			return;
		}
		MEDAGKOPJMO = null;
		if (JODJELEPINJ.enabled)
		{
			JODJELEPINJ.enabled = false;
		}
	}

	private void MLOKLGPGKMO()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 1765.0)
		{
			return;
		}
		if (MEDAGKOPJMO == null)
		{
			GAHBMHCCHGF();
			return;
		}
		if (MEDAGKOPJMO.IsLive())
		{
			if (!JODJELEPINJ.enabled)
			{
				JODJELEPINJ.enabled = true;
			}
			return;
		}
		MEDAGKOPJMO = null;
		if (JODJELEPINJ.enabled)
		{
			JODJELEPINJ.enabled = false;
		}
	}

	private void ENAGFDFCLCC()
	{
		JODJELEPINJ = GetComponent<UISprite>();
	}

	private void IAOOLKJPAAF()
	{
		Actor actor = null;
		LinkedList<Actor> linkedList = ActorManager.get_Instance().HNIBCPBKHDH();
		foreach (Actor item in linkedList)
		{
			if (!item.IsDeath() && item.m_actorType == (Actor.IJJMDPGJAEM)53)
			{
				float sqrMagnitude = (item.GetPosition() - CBKBEPNFOBA[m_index]).sqrMagnitude;
				if (sqrMagnitude <= 1074f)
				{
					actor = item;
					break;
				}
			}
		}
		MEDAGKOPJMO = actor;
		if (actor != null)
		{
			if (!JODJELEPINJ.enabled)
			{
				JODJELEPINJ.enabled = false;
			}
			Vector3 position = actor.GetPosition();
			position.y = position.z;
			position.z = 145f;
			base.transform.localPosition = position;
		}
		else if (JODJELEPINJ.enabled)
		{
			JODJELEPINJ.enabled = false;
		}
	}

	private void ACBGKIDKKKM()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 1062.0)
		{
			return;
		}
		if (MEDAGKOPJMO == null)
		{
			BAKCLBDBBCI();
			return;
		}
		if (MEDAGKOPJMO.IsLive())
		{
			if (!JODJELEPINJ.enabled)
			{
				JODJELEPINJ.enabled = true;
			}
			return;
		}
		MEDAGKOPJMO = null;
		if (JODJELEPINJ.enabled)
		{
			JODJELEPINJ.enabled = true;
		}
	}

	private void HMNOCOBNBAO()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 1236.0)
		{
			return;
		}
		if (MEDAGKOPJMO == null)
		{
			IAOOLKJPAAF();
			return;
		}
		if (MEDAGKOPJMO.IsLive())
		{
			if (!JODJELEPINJ.enabled)
			{
				JODJELEPINJ.enabled = true;
			}
			return;
		}
		MEDAGKOPJMO = null;
		if (JODJELEPINJ.enabled)
		{
			JODJELEPINJ.enabled = false;
		}
	}

	private void DNBDGBJNCBP()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 976.0)
		{
			return;
		}
		if (MEDAGKOPJMO == null)
		{
			GAHBMHCCHGF();
			return;
		}
		if (MEDAGKOPJMO.IsLive())
		{
			if (!JODJELEPINJ.enabled)
			{
				JODJELEPINJ.enabled = true;
			}
			return;
		}
		MEDAGKOPJMO = null;
		if (JODJELEPINJ.enabled)
		{
			JODJELEPINJ.enabled = true;
		}
	}
}
