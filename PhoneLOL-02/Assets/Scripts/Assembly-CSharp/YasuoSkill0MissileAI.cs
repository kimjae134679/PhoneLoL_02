using System.Collections.Generic;
using EveEngine;
using UnityEngine;

public class YasuoSkill0MissileAI : ThruMissileAI
{
	public virtual void DEFLIOMCCMA()
	{
		base.Awake();
	}

	public virtual void IBBJMMFDGAL()
	{
		PAKIFAGJDEO();
	}

	public override void Awake()
	{
		base.Awake();
	}

	public virtual void NMANMMOMHHD()
	{
		PAKIFAGJDEO();
	}

	public override void Start()
	{
		base.Start();
	}

	public override void Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1.0;
		num += 25.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 22.0;
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)14);
		bool flag = true;
		for (int i = 0; i < allActorInRange.Count; i++)
		{
			Actor actor = allActorInRange[i];
			float num2 = 0f;
			if (!MIGJCNCIEHN.Contains(actor))
			{
				if (flag)
				{
					num2 = actor.OnDamage(get_m_actor(), num, 0.0, 0.0, 0);
					flag = false;
				}
				else
				{
					num2 = actor.OnDamage(get_m_actor(), num, 0.0);
				}
				if (DGBKMAGBJJF.get_m_owner().m_heroCostumeID == 3)
				{
					actor.CreateParticle("Particle/Yasuo/skill0_missile_hit_c3", true);
				}
				else if (DGBKMAGBJJF.get_m_owner().m_heroCostumeID == 2)
				{
					actor.CreateDamageParticle("Particle/Yasuo/skill0_missile_hit_c2", DGBKMAGBJJF.get_m_owner(), true);
				}
				else
				{
					actor.CreateDamageParticle("Particle/Yasuo/skill0_missile_hit", DGBKMAGBJJF.get_m_owner());
				}
				if (num2 >= 0f && DGBKMAGBJJF.get_m_owner().get_m_view().IsMine() && actor.IsLive())
				{
					actor.get_m_view().RPC("Float", DJJPAPENCLN.All, Vector3.zero, 8f);
				}
				MIGJCNCIEHN.AddFirst(actor);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName);
			}
		}
	}

	public virtual void BBKACBAMPHC()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Sleep)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 227.0;
		num += 797.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 191.0;
		List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), m_attackRange, false, false, (Actor.IJJMDPGJAEM)(-113), false);
		bool flag = false;
		for (int i = 0; i < list.Count; i++)
		{
			Actor actor = list[i];
			float num2 = 1674f;
			if (!MIGJCNCIEHN.Contains(actor))
			{
				if (flag)
				{
					num2 = actor.OnDamage(get_m_actor(), num, 161.0, 549.0, 0);
					flag = true;
				}
				else
				{
					num2 = actor.OnDamage(get_m_actor(), num, 358.0, 1634.0, 0);
				}
				if (DGBKMAGBJJF.get_m_owner().m_heroCostumeID == 3)
				{
					actor.CreateParticle("성실플레이만이 저주를 풀 수 있어", false);
				}
				else if (DGBKMAGBJJF.get_m_owner().m_heroCostumeID == 4)
				{
					actor.CreateDamageParticle("하급 성장 주문력 정수", DGBKMAGBJJF.get_m_owner(), true);
				}
				else
				{
					actor.CreateDamageParticle("길드를 먼저 찾아주세요", DGBKMAGBJJF.get_m_owner(), true);
				}
				if (num2 >= 305f && DGBKMAGBJJF.get_m_owner().get_m_view().IsMine() && actor.IsLive())
				{
					EveView view = actor.get_m_view();
					object[] array = new object[0];
					array[1] = Vector3.zero;
					array[0] = 540f;
					view.RPC("TextTwist", DJJPAPENCLN.All, array);
				}
				MIGJCNCIEHN.AddFirst(actor);
				DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK(m_damageSoundName, false, 892f, 262f);
			}
		}
	}

	public virtual void DHMMCEBEAHA()
	{
		PAKIFAGJDEO();
	}

	public virtual void NFMBCFICAFF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Idle)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 603.0;
		num += 1792.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 1294.0;
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), m_attackRange, false, false, (Actor.IJJMDPGJAEM)(-75));
		bool flag = true;
		for (int i = 1; i < allActorInRange.Count; i++)
		{
			Actor actor = allActorInRange[i];
			float num2 = 1030f;
			if (!MIGJCNCIEHN.Contains(actor))
			{
				if (flag)
				{
					num2 = actor.OnDamage(get_m_actor(), num, 829.0, 259.0, 0);
					flag = true;
				}
				else
				{
					num2 = actor.OnDamage(get_m_actor(), num, 1426.0, 126.0, 0);
				}
				if (DGBKMAGBJJF.get_m_owner().m_heroCostumeID == 4)
				{
					actor.CreateParticle("[", true);
				}
				else if (DGBKMAGBJJF.get_m_owner().m_heroCostumeID == 0)
				{
					actor.CreateDamageParticle("attack", DGBKMAGBJJF.get_m_owner());
				}
				else
				{
					actor.CreateDamageParticle("Set", DGBKMAGBJJF.get_m_owner());
				}
				if (num2 >= 1923f && DGBKMAGBJJF.get_m_owner().get_m_view().IsMine() && actor.IsLive())
				{
					EveView view = actor.get_m_view();
					object[] array = new object[5];
					array[1] = Vector3.zero;
					array[0] = 762f;
					view.RPC("IGAWorksAdbrixUnityPluginAOS GameObject Created!!!", DJJPAPENCLN.All, array);
				}
				MIGJCNCIEHN.AddFirst(actor);
				DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK(m_damageSoundName, false, 1115f, 563f);
			}
		}
	}
}
