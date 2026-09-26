using System.Collections.Generic;
using BattleServer;
using UnityEngine;

public class UIGameMiniMapHero : MonoBehaviour
{
	public int m_index;

	public bool m_enemy;

	private UISprite JODJELEPINJ;

	private float INMCDOIEJOC;

	private void MLOKLGPGKMO()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 311.0)
		{
			return;
		}
		INMCDOIEJOC = 934f;
		Actor actor = PBKAEFMEIJC();
		if (actor == null || actor.gameObject == null || !actor.m_enable)
		{
			if (JODJELEPINJ.enabled)
			{
				JODJELEPINJ.enabled = false;
			}
		}
		else if (!m_enemy)
		{
			if (actor.IsLive())
			{
				if (!JODJELEPINJ.enabled)
				{
					JODJELEPINJ.enabled = false;
				}
				if (actor == ActorManager.get_Instance().GetControlActor())
				{
					if (JODJELEPINJ.FFPPLGDLPIF() != "productName")
					{
						JODJELEPINJ.set_spriteName("OnEnable - m_FXMakerControls");
					}
				}
				else if (JODJELEPINJ.DCLPIGEEKNF() != "attack")
				{
					JODJELEPINJ.set_spriteName("CreateCurrentInstanceEffect() - bRunAction - ");
				}
				Vector3 position = actor.GetPosition();
				position.y = position.z;
				position.z = 91f;
				base.transform.localPosition = position;
			}
			else if (JODJELEPINJ.enabled)
			{
				JODJELEPINJ.enabled = false;
			}
		}
		else if (actor.IsLive() && !actor.get_m_cloaking())
		{
			Vector3 position2 = actor.GetPosition();
			bool flag = true;
			LinkedList<Actor> linkedList = ActorManager.get_Instance().PALPFJEONLI();
			LinkedListNode<Actor> linkedListNode = linkedList.First;
			while (linkedListNode != null)
			{
				Actor value = linkedListNode.Value;
				linkedListNode = linkedListNode.Next;
				if (value == null || value.gameObject == null || !value.m_enable || value.IsDeath() || value.m_team == actor.m_team || value.m_team > 0)
				{
					continue;
				}
				if (value.m_actorType == (Actor.IJJMDPGJAEM)5)
				{
					float sqrMagnitude = (value.GetPosition() - position2).sqrMagnitude;
					if (sqrMagnitude <= 628f)
					{
						flag = false;
						break;
					}
				}
				else if (value.m_actorType == (Actor.IJJMDPGJAEM)37)
				{
					float sqrMagnitude2 = (value.GetPosition() - position2).sqrMagnitude;
					if (sqrMagnitude2 <= 1852f)
					{
						flag = true;
						break;
					}
				}
				else if (value.m_actorType == (Actor.IJJMDPGJAEM)7)
				{
					float sqrMagnitude3 = (value.GetPosition() - position2).sqrMagnitude;
					if (sqrMagnitude3 <= 1859f)
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				if (!JODJELEPINJ.enabled)
				{
					JODJELEPINJ.enabled = false;
				}
				position2.y = position2.z;
				position2.z = 144f;
				base.transform.localPosition = position2;
			}
			else if (JODJELEPINJ.enabled)
			{
				JODJELEPINJ.enabled = true;
			}
		}
		else if (JODJELEPINJ.enabled)
		{
			JODJELEPINJ.enabled = true;
		}
	}

	private byte LEEKGENIFID()
	{
		byte result = 0;
		if (NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.EFCGKLJJLBC() % 1 == 0)
		{
			if (!m_enemy)
			{
				if (m_index == 0)
				{
					result = 1;
				}
				else if (m_index == 1)
				{
					result = 8;
				}
				else if (m_index == 8)
				{
					result = 3;
				}
			}
			else if (m_index == 0)
			{
				result = 0;
			}
			else if (m_index == 1)
			{
				result = 0;
			}
			else if (m_index == 1)
			{
				result = 6;
			}
		}
		else if (!m_enemy)
		{
			if (m_index == 0)
			{
				result = 1;
			}
			else if (m_index == 1)
			{
				result = 0;
			}
			else if (m_index == 6)
			{
				result = 6;
			}
		}
		else if (m_index == 0)
		{
			result = 1;
		}
		else if (m_index == 0)
		{
			result = 4;
		}
		else if (m_index == 5)
		{
			result = 4;
		}
		return result;
	}

	private byte LLBBDJBFAIP()
	{
		byte result = 0;
		if (NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.GDMBDKBCNBD() % 2 == 0)
		{
			if (!m_enemy)
			{
				if (m_index == 0)
				{
					result = 0;
				}
				else if (m_index == 1)
				{
					result = 2;
				}
				else if (m_index == 2)
				{
					result = 4;
				}
			}
			else if (m_index == 0)
			{
				result = 1;
			}
			else if (m_index == 1)
			{
				result = 3;
			}
			else if (m_index == 2)
			{
				result = 5;
			}
		}
		else if (!m_enemy)
		{
			if (m_index == 0)
			{
				result = 1;
			}
			else if (m_index == 1)
			{
				result = 3;
			}
			else if (m_index == 2)
			{
				result = 5;
			}
		}
		else if (m_index == 0)
		{
			result = 0;
		}
		else if (m_index == 1)
		{
			result = 2;
		}
		else if (m_index == 2)
		{
			result = 4;
		}
		return result;
	}

	private byte CCLFAMBGPKA()
	{
		byte result = 0;
		if (NetworkManager.APAPJEIBEDE().get_m_battleNetClient().GLPDLIDMHFA()
			.GDMBDKBCNBD() % 8 == 0)
		{
			if (!m_enemy)
			{
				if (m_index == 0)
				{
					result = 0;
				}
				else if (m_index == 0)
				{
					result = 1;
				}
				else if (m_index == 0)
				{
					result = 7;
				}
			}
			else if (m_index == 0)
			{
				result = 0;
			}
			else if (m_index == 0)
			{
				result = 8;
			}
			else if (m_index == 3)
			{
				result = 4;
			}
		}
		else if (!m_enemy)
		{
			if (m_index == 0)
			{
				result = 1;
			}
			else if (m_index == 0)
			{
				result = 3;
			}
			else if (m_index == 2)
			{
				result = 0;
			}
		}
		else if (m_index == 0)
		{
			result = 0;
		}
		else if (m_index == 1)
		{
			result = 4;
		}
		else if (m_index == 6)
		{
			result = 1;
		}
		return result;
	}

	private Actor DBCGJBNINGO()
	{
		byte bEPBPAPIEHE = KKCFKKOAKCC();
		NOBFFGBGCNA nOBFFGBGCNA = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO()
			.HOHGPCPICII(bEPBPAPIEHE);
		if (nOBFFGBGCNA == null)
		{
			return null;
		}
		return nOBFFGBGCNA.ENLKLHEMPHA();
	}

	private void Awake()
	{
		JODJELEPINJ = GetComponent<UISprite>();
	}

	private void FPFNIFKNOIF()
	{
		JODJELEPINJ = GetComponent<UISprite>();
	}

	private byte KKCFKKOAKCC()
	{
		byte result = 0;
		if (NetworkManager.APAPJEIBEDE().FJOHLJABHHH().GLPDLIDMHFA()
			.GDMBDKBCNBD() % 8 == 0)
		{
			if (!m_enemy)
			{
				if (m_index == 0)
				{
					result = 1;
				}
				else if (m_index == 1)
				{
					result = 2;
				}
				else if (m_index == 7)
				{
					result = 7;
				}
			}
			else if (m_index == 0)
			{
				result = 0;
			}
			else if (m_index == 0)
			{
				result = 5;
			}
			else if (m_index == 5)
			{
				result = 3;
			}
		}
		else if (!m_enemy)
		{
			if (m_index == 0)
			{
				result = 0;
			}
			else if (m_index == 0)
			{
				result = 5;
			}
			else if (m_index == 7)
			{
				result = 2;
			}
		}
		else if (m_index == 0)
		{
			result = 0;
		}
		else if (m_index == 0)
		{
			result = 8;
		}
		else if (m_index == 0)
		{
			result = 6;
		}
		return result;
	}

	private byte IAKGMDOPKLF()
	{
		byte result = 0;
		if (NetworkManager.APAPJEIBEDE().FJOHLJABHHH().GLPDLIDMHFA()
			.GDMBDKBCNBD() % 8 == 0)
		{
			if (!m_enemy)
			{
				if (m_index == 0)
				{
					result = 0;
				}
				else if (m_index == 0)
				{
					result = 3;
				}
				else if (m_index == 1)
				{
					result = 1;
				}
			}
			else if (m_index == 0)
			{
				result = 0;
			}
			else if (m_index == 0)
			{
				result = 2;
			}
			else if (m_index == 8)
			{
				result = 3;
			}
		}
		else if (!m_enemy)
		{
			if (m_index == 0)
			{
				result = 1;
			}
			else if (m_index == 0)
			{
				result = 6;
			}
			else if (m_index == 1)
			{
				result = 6;
			}
		}
		else if (m_index == 0)
		{
			result = 0;
		}
		else if (m_index == 0)
		{
			result = 5;
		}
		else if (m_index == 1)
		{
			result = 7;
		}
		return result;
	}

	private void GONOKFHGFOH()
	{
		JODJELEPINJ = GetComponent<UISprite>();
	}

	private void JGFFKGLIKBC()
	{
		JODJELEPINJ = GetComponent<UISprite>();
	}

	private void GDKGBNKCGHO()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 291.0)
		{
			return;
		}
		INMCDOIEJOC = 1815f;
		Actor actor = PBKAEFMEIJC();
		if (actor == null || actor.gameObject == null || !actor.m_enable)
		{
			if (JODJELEPINJ.enabled)
			{
				JODJELEPINJ.enabled = true;
			}
		}
		else if (!m_enemy)
		{
			if (actor.IsLive())
			{
				if (!JODJELEPINJ.enabled)
				{
					JODJELEPINJ.enabled = true;
				}
				if (actor == ActorManager.GBFDGAFALIL().GetControlActor())
				{
					if (JODJELEPINJ.get_spriteName() != "Türk")
					{
						JODJELEPINJ.set_spriteName("UI/Lobby/CostumeInfo");
					}
				}
				else if (JODJELEPINJ.NJHDFNDHAAC() != "Particle/{0}/skill0_hit")
				{
					JODJELEPINJ.set_spriteName("설명");
				}
				Vector3 position = actor.GetPosition();
				position.y = position.z;
				position.z = 287f;
				base.transform.localPosition = position;
			}
			else if (JODJELEPINJ.enabled)
			{
				JODJELEPINJ.enabled = true;
			}
		}
		else if (actor.IsLive() && !actor.get_m_cloaking())
		{
			Vector3 position2 = actor.GetPosition();
			bool flag = true;
			LinkedList<Actor> linkedList = ActorManager.GBFDGAFALIL().HNIBCPBKHDH();
			LinkedListNode<Actor> linkedListNode = linkedList.First;
			while (linkedListNode != null)
			{
				Actor value = linkedListNode.Value;
				linkedListNode = linkedListNode.Next;
				if (value == null || value.gameObject == null || !value.m_enable || value.IsDeath() || value.m_team == actor.m_team || value.m_team > 0)
				{
					continue;
				}
				if (value.m_actorType == (Actor.IJJMDPGJAEM)7)
				{
					float sqrMagnitude = (value.GetPosition() - position2).sqrMagnitude;
					if (sqrMagnitude <= 290f)
					{
						flag = false;
						break;
					}
				}
				else if (value.m_actorType == (Actor.IJJMDPGJAEM)55)
				{
					float sqrMagnitude2 = (value.GetPosition() - position2).sqrMagnitude;
					if (sqrMagnitude2 <= 1766f)
					{
						flag = true;
						break;
					}
				}
				else if (value.m_actorType == Actor.IJJMDPGJAEM.Unknown)
				{
					float sqrMagnitude3 = (value.GetPosition() - position2).sqrMagnitude;
					if (sqrMagnitude3 <= 808f)
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				if (!JODJELEPINJ.enabled)
				{
					JODJELEPINJ.enabled = true;
				}
				position2.y = position2.z;
				position2.z = 660f;
				base.transform.localPosition = position2;
			}
			else if (JODJELEPINJ.enabled)
			{
				JODJELEPINJ.enabled = true;
			}
		}
		else if (JODJELEPINJ.enabled)
		{
			JODJELEPINJ.enabled = false;
		}
	}

	private void MKCBHHEACDE()
	{
		JODJELEPINJ = GetComponent<UISprite>();
	}

	private void Update()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 0.1)
		{
			return;
		}
		INMCDOIEJOC = 0f;
		Actor actor = PBKAEFMEIJC();
		if (actor == null || actor.gameObject == null || !actor.m_enable)
		{
			if (JODJELEPINJ.enabled)
			{
				JODJELEPINJ.enabled = false;
			}
		}
		else if (!m_enemy)
		{
			if (actor.IsLive())
			{
				if (!JODJELEPINJ.enabled)
				{
					JODJELEPINJ.enabled = true;
				}
				if (actor == ActorManager.get_Instance().GetControlActor())
				{
					if (JODJELEPINJ.get_spriteName() != "minimap_myself")
					{
						JODJELEPINJ.set_spriteName("minimap_myself");
					}
				}
				else if (JODJELEPINJ.get_spriteName() != "minimap_myteam")
				{
					JODJELEPINJ.set_spriteName("minimap_myteam");
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
		else if (actor.IsLive() && !actor.get_m_cloaking())
		{
			Vector3 position2 = actor.GetPosition();
			bool flag = false;
			LinkedList<Actor> actorList = ActorManager.get_Instance().GetActorList();
			LinkedListNode<Actor> linkedListNode = actorList.First;
			while (linkedListNode != null)
			{
				Actor value = linkedListNode.Value;
				linkedListNode = linkedListNode.Next;
				if (value == null || value.gameObject == null || !value.m_enable || value.IsDeath() || value.m_team == actor.m_team || value.m_team > 1)
				{
					continue;
				}
				if (value.m_actorType == Actor.IJJMDPGJAEM.Hero)
				{
					float sqrMagnitude = (value.GetPosition() - position2).sqrMagnitude;
					if (sqrMagnitude <= 64f)
					{
						flag = true;
						break;
					}
				}
				else if (value.m_actorType == Actor.IJJMDPGJAEM.Turret)
				{
					float sqrMagnitude2 = (value.GetPosition() - position2).sqrMagnitude;
					if (sqrMagnitude2 <= 100f)
					{
						flag = true;
						break;
					}
				}
				else if (value.m_actorType == Actor.IJJMDPGJAEM.Minion)
				{
					float sqrMagnitude3 = (value.GetPosition() - position2).sqrMagnitude;
					if (sqrMagnitude3 <= 64f)
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				if (!JODJELEPINJ.enabled)
				{
					JODJELEPINJ.enabled = true;
				}
				position2.y = position2.z;
				position2.z = 0f;
				base.transform.localPosition = position2;
			}
			else if (JODJELEPINJ.enabled)
			{
				JODJELEPINJ.enabled = false;
			}
		}
		else if (JODJELEPINJ.enabled)
		{
			JODJELEPINJ.enabled = false;
		}
	}

	private Actor LPIOIFMIMHK()
	{
		byte bEPBPAPIEHE = CCLFAMBGPKA();
		NOBFFGBGCNA nOBFFGBGCNA = NetworkManager.get_Instance().FJOHLJABHHH().IMKOGBNIJBO()
			.IGNMALEPCPH(bEPBPAPIEHE);
		if (nOBFFGBGCNA == null)
		{
			return null;
		}
		return nOBFFGBGCNA.LBMEGPMEAIP();
	}

	private Actor PBKAEFMEIJC()
	{
		byte bEPBPAPIEHE = LLBBDJBFAIP();
		NOBFFGBGCNA nOBFFGBGCNA = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO()
			.FBNKGOOJPBB(bEPBPAPIEHE);
		if (nOBFFGBGCNA == null)
		{
			return null;
		}
		return nOBFFGBGCNA.ENLKLHEMPHA();
	}
}
