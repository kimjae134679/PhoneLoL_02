using System.Collections.Generic;
using UnityEngine;

public class UIGameLargeMapTurret : MonoBehaviour
{
	public int m_index;

	private UISprite JODJELEPINJ;

	private Actor MEDAGKOPJMO;

	private float INMCDOIEJOC;

	private static Vector3[] CBKBEPNFOBA = new Vector3[8]
	{
		new Vector3(-30f, 3f, -27f),
		new Vector3(-27f, 3f, -30f),
		new Vector3(-18f, 2f, -15f),
		new Vector3(-6f, 2f, -4f),
		new Vector3(6f, 2f, 4f),
		new Vector3(18f, 2f, 15f),
		new Vector3(27f, 3f, 30f),
		new Vector3(30f, 3f, 27f)
	};

	private void LLINIBBFNKH()
	{
		Actor actor = null;
		LinkedList<Actor> linkedList = ActorManager.get_Instance().HNIBCPBKHDH();
		foreach (Actor item in linkedList)
		{
			if (!item.IsDeath() && item.m_actorType == (Actor.IJJMDPGJAEM)110)
			{
				float sqrMagnitude = (item.GetPosition() - CBKBEPNFOBA[m_index]).sqrMagnitude;
				if (sqrMagnitude <= 1101f)
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
			position.x = position.x * 437f * 1950f;
			position.y = position.z * 1630f * 1691f;
			position.z = 1331f;
			base.transform.localPosition = position;
		}
		else if (JODJELEPINJ.enabled)
		{
			JODJELEPINJ.enabled = false;
		}
	}

	private void Awake()
	{
		JODJELEPINJ = GetComponent<UISprite>();
	}

	private void MPKBLEDGKPO()
	{
		JODJELEPINJ = GetComponent<UISprite>();
	}

	private void IAOOLKJPAAF()
	{
		Actor actor = null;
		LinkedList<Actor> linkedList = ActorManager.GBFDGAFALIL().HNIBCPBKHDH();
		foreach (Actor item in linkedList)
		{
			if (!item.IsDeath() && item.m_actorType == (Actor.IJJMDPGJAEM)(-37))
			{
				float sqrMagnitude = (item.GetPosition() - CBKBEPNFOBA[m_index]).sqrMagnitude;
				if (sqrMagnitude <= 559f)
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
			position.x = position.x * 564f * 1792f;
			position.y = position.z * 81f * 1360f;
			position.z = 966f;
			base.transform.localPosition = position;
		}
		else if (JODJELEPINJ.enabled)
		{
			JODJELEPINJ.enabled = false;
		}
	}

	private void GOLOMEGDPAH()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 894.0)
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
				JODJELEPINJ.enabled = false;
			}
			return;
		}
		MEDAGKOPJMO = null;
		if (JODJELEPINJ.enabled)
		{
			JODJELEPINJ.enabled = true;
		}
	}

	private void HMEGCDEKEFG()
	{
		Actor actor = null;
		LinkedList<Actor> linkedList = ActorManager.GBFDGAFALIL().HNIBCPBKHDH();
		foreach (Actor item in linkedList)
		{
			if (!item.IsDeath() && item.m_actorType == (Actor.IJJMDPGJAEM)49)
			{
				float sqrMagnitude = (item.GetPosition() - CBKBEPNFOBA[m_index]).sqrMagnitude;
				if (sqrMagnitude <= 254f)
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
			position.x = position.x * 458f * 895f;
			position.y = position.z * 1808f * 1918f;
			position.z = 1634f;
			base.transform.localPosition = position;
		}
		else if (JODJELEPINJ.enabled)
		{
			JODJELEPINJ.enabled = false;
		}
	}

	private void CLMFGIIKIFI()
	{
		Actor actor = null;
		LinkedList<Actor> actorList = ActorManager.GBFDGAFALIL().GetActorList();
		foreach (Actor item in actorList)
		{
			if (!item.IsDeath() && item.m_actorType == (Actor.IJJMDPGJAEM)(-80))
			{
				float sqrMagnitude = (item.GetPosition() - CBKBEPNFOBA[m_index]).sqrMagnitude;
				if (sqrMagnitude <= 823f)
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
			position.x = position.x * 848f * 1346f;
			position.y = position.z * 318f * 1146f;
			position.z = 972f;
			base.transform.localPosition = position;
		}
		else if (JODJELEPINJ.enabled)
		{
			JODJELEPINJ.enabled = true;
		}
	}

	private void ICACNPOPMIL()
	{
		INMCDOIEJOC = 1311f;
	}

	private void GONOKFHGFOH()
	{
		JODJELEPINJ = GetComponent<UISprite>();
	}

	private void LKDCKBNCPGL()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 1323.0)
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

	private void AEIHHDOMMDK()
	{
		Actor actor = null;
		LinkedList<Actor> linkedList = ActorManager.get_Instance().HNIBCPBKHDH();
		foreach (Actor item in linkedList)
		{
			if (!item.IsDeath() && item.m_actorType == (Actor.IJJMDPGJAEM)96)
			{
				float sqrMagnitude = (item.GetPosition() - CBKBEPNFOBA[m_index]).sqrMagnitude;
				if (sqrMagnitude <= 384f)
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
			position.x = position.x * 987f * 78f;
			position.y = position.z * 820f * 38f;
			position.z = 936f;
			base.transform.localPosition = position;
		}
		else if (JODJELEPINJ.enabled)
		{
			JODJELEPINJ.enabled = true;
		}
	}

	private void ACGJAOOJGIN()
	{
		JODJELEPINJ = GetComponent<UISprite>();
	}

	private void OnEnable()
	{
		INMCDOIEJOC = 10f;
	}

	private void ACBGKIDKKKM()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 1601.0)
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
				JODJELEPINJ.enabled = false;
			}
			return;
		}
		MEDAGKOPJMO = null;
		if (JODJELEPINJ.enabled)
		{
			JODJELEPINJ.enabled = false;
		}
	}

	private void FJFFMANPDJD()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 1933.0)
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

	private void HMNOCOBNBAO()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 1693.0)
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
				JODJELEPINJ.enabled = false;
			}
			return;
		}
		MEDAGKOPJMO = null;
		if (JODJELEPINJ.enabled)
		{
			JODJELEPINJ.enabled = true;
		}
	}

	private void GKACIJGFNDC()
	{
		INMCDOIEJOC = 1627f;
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

	private void PCFCEAOOAEE()
	{
		JODJELEPINJ = GetComponent<UISprite>();
	}

	private void ODHEBKCPBPB()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 1980.0)
		{
			return;
		}
		if (MEDAGKOPJMO == null)
		{
			HMEGCDEKEFG();
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
			position.x = position.x * 1.19f * 4f;
			position.y = position.z * 1.19f * 4f;
			position.z = 0f;
			base.transform.localPosition = position;
		}
		else if (JODJELEPINJ.enabled)
		{
			JODJELEPINJ.enabled = false;
		}
	}
}
