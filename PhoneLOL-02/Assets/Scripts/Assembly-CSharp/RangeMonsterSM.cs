using UnityEngine;

public class RangeMonsterSM : HumanSM
{
	public string m_missileName = "attack_missile";

	public bool m_attackRotation = true;

	public void KMKGAPMMHOO()
	{
		if (get_m_target() != null && get_m_target().IsLive())
		{
			Vector3 centerPosition = get_m_actor().GetCenterPosition();
			get_m_actor().CreateMissileRPC(m_missileName, centerPosition, get_m_target());
			if (m_attackRotation)
			{
				SetDirection(get_m_target().GetPosition() - get_m_actor().GetPosition());
			}
		}
		else
		{
			Actor actor = ActorManager.GBFDGAFALIL().DCMODJADKEE(get_m_actor(), get_m_actor().get_m_att_range(), false, false, Actor.IJJMDPGJAEM.Minion, true);
			if (actor == null)
			{
				actor = ActorManager.GBFDGAFALIL().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), true, true, (Actor.IJJMDPGJAEM)(-86), true);
			}
			if (actor != null)
			{
				Vector3 centerPosition2 = get_m_actor().GetCenterPosition();
				get_m_actor().CreateMissileRPC(m_missileName, centerPosition2, actor);
				if (m_attackRotation)
				{
					SetDirection(actor.GetPosition() - get_m_actor().GetPosition());
				}
			}
		}
		OnAttack();
	}

	public virtual void GEMKIOPFNKD()
	{
		LGNMOCFBMHK();
		get_m_actor().m_multiSound.NMLFNHNOALK("알려지지 않은 오류입니다.", true, 1136f, 52f);
	}

	public override void Init()
	{
		base.Init();
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
	}

	public virtual void LFLNAECMCEK()
	{
		base.OnEnterAttack();
		get_m_actor().m_multiSound.LKLFMNKDLHJ("잠깐.. 주변이 온통 전투의 흔적이잖아..", false, 734f, 1571f);
	}

	public void GACMKJFNJNF()
	{
		if (get_m_target() != null && get_m_target().IsLive())
		{
			Vector3 centerPosition = get_m_actor().GetCenterPosition();
			get_m_actor().CreateMissileRPC(m_missileName, centerPosition, get_m_target());
			if (m_attackRotation)
			{
				SetDirection(get_m_target().GetPosition() - get_m_actor().GetPosition());
			}
		}
		else
		{
			Actor actor = ActorManager.get_Instance().DCMODJADKEE(get_m_actor(), get_m_actor().get_m_att_range(), true, false, Actor.IJJMDPGJAEM.Monster, true);
			if (actor == null)
			{
				actor = ActorManager.get_Instance().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), false, true, (Actor.IJJMDPGJAEM)(-74), true);
			}
			if (actor != null)
			{
				Vector3 centerPosition2 = get_m_actor().GetCenterPosition();
				get_m_actor().CreateMissileRPC(m_missileName, centerPosition2, actor);
				if (m_attackRotation)
				{
					SetDirection(actor.GetPosition() - get_m_actor().GetPosition());
				}
			}
		}
		OnAttack();
	}

	public virtual void INOKJCKAONB()
	{
		base.Init();
		get_m_actor().m_actorAniEvent.add_m_attackEvent(GACMKJFNJNF);
	}

	public virtual void LOLFJAKKNNB()
	{
		base.OnEnterAttack();
		get_m_actor().m_multiSound.ICNAJBHLIGO("Hero1", false, 672f, 1121f);
	}

	public void IBGLMHFFAAB()
	{
		if (get_m_target() != null && get_m_target().IsLive())
		{
			Vector3 centerPosition = get_m_actor().GetCenterPosition();
			get_m_actor().CreateMissileRPC(m_missileName, centerPosition, get_m_target());
			if (m_attackRotation)
			{
				SetDirection(get_m_target().GetPosition() - get_m_actor().GetPosition());
			}
		}
		else
		{
			Actor actor = ActorManager.get_Instance().DCMODJADKEE(get_m_actor(), get_m_actor().get_m_att_range(), true, true, (Actor.IJJMDPGJAEM)3);
			if (actor == null)
			{
				actor = ActorManager.get_Instance().DCMODJADKEE(get_m_actor(), get_m_actor().get_m_att_range(), false, true, (Actor.IJJMDPGJAEM)73, true);
			}
			if (actor != null)
			{
				Vector3 centerPosition2 = get_m_actor().GetCenterPosition();
				get_m_actor().CreateMissileRPC(m_missileName, centerPosition2, actor);
				if (m_attackRotation)
				{
					SetDirection(actor.GetPosition() - get_m_actor().GetPosition());
				}
			}
		}
		OnAttack();
	}

	public virtual void FAHKJKDPHCA()
	{
		LGNMOCFBMHK();
		get_m_actor().m_multiSound.LKLFMNKDLHJ("획득 경험치", true, 1014f, 1613f);
	}

	public override void OnEnterAttack()
	{
		base.OnEnterAttack();
		get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
	}

	public virtual void JLFBCNKNBJD()
	{
		base.OnEnterAttack();
		get_m_actor().m_multiSound.HDOLPLIDACO("魔法抗性", false, 1743f, 1304f);
	}

	public void OnAnimationEventAttack()
	{
		if (get_m_target() != null && get_m_target().IsLive())
		{
			Vector3 centerPosition = get_m_actor().GetCenterPosition();
			get_m_actor().CreateMissileRPC(m_missileName, centerPosition, get_m_target());
			if (m_attackRotation)
			{
				SetDirection(get_m_target().GetPosition() - get_m_actor().GetPosition());
			}
		}
		else
		{
			Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), false, true, Actor.IJJMDPGJAEM.Minion);
			if (actorInRange == null)
			{
				actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), false, true, (Actor.IJJMDPGJAEM)18);
			}
			if (actorInRange != null)
			{
				Vector3 centerPosition2 = get_m_actor().GetCenterPosition();
				get_m_actor().CreateMissileRPC(m_missileName, centerPosition2, actorInRange);
				if (m_attackRotation)
				{
					SetDirection(actorInRange.GetPosition() - get_m_actor().GetPosition());
				}
			}
		}
		OnAttack();
	}

	public virtual void OPJNHNGAGJJ()
	{
		LGNMOCFBMHK();
		get_m_actor().m_multiSound.NMLFNHNOALK("Nexus/RedNexus", true, 1034f, 1197f);
	}
}
