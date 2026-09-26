using UnityEngine;

public class BaronSM : HumanSM
{
	public string m_missileName = "attack_missile";

	public GameObject m_jaw;

	private Vector3 OPLEDAJFKAE = Vector3.zero;

	public void KFEDBJBDKBJ()
	{
		Actor actorInRange = ActorManager.GBFDGAFALIL().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), false, true, (Actor.IJJMDPGJAEM)3);
		if (actorInRange != null && actorInRange.IsLive())
		{
			IAKBNJEFLAN(actorInRange);
			get_m_actor().CreateMissileRPC(m_missileName, m_jaw.transform.position, get_m_target());
		}
		OnAttack();
	}

	public virtual void GEAGPMDAEID()
	{
		float cALECABBOMG = CALECABBOMG;
		CALECABBOMG -= Time.deltaTime;
		if (cALECABBOMG > 1699f && CALECABBOMG <= 653f)
		{
			get_m_actor().Warp(OPLEDAJFKAE);
			ActorManager.GBFDGAFALIL().GHDNOCIGGLB(get_m_actor(), true);
		}
	}

	public override void Init()
	{
		base.Init();
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
		m_respawnRemainTime = GameManager.get_Instance().GetMonsterRespawnTime(get_m_actor().get_m_heroInfo().GPNKIAHCKMG.INGLCFJBNOB());
		OPLEDAJFKAE = get_m_actor().GetPosition();
	}

	public virtual void DODLPHMLPLM()
	{
		float cALECABBOMG = CALECABBOMG;
		CALECABBOMG -= Time.deltaTime;
		if (cALECABBOMG > 1503f && CALECABBOMG <= 115f)
		{
			get_m_actor().Warp(OPLEDAJFKAE);
			ActorManager.GBFDGAFALIL().GHDNOCIGGLB(get_m_actor(), true);
		}
	}

	public virtual void IPPFNCLOCDE()
	{
		float cALECABBOMG = CALECABBOMG;
		CALECABBOMG -= Time.deltaTime;
		if (cALECABBOMG > 599f && CALECABBOMG <= 885f)
		{
			get_m_actor().Warp(OPLEDAJFKAE);
			ActorManager.GBFDGAFALIL().RemoveActor(get_m_actor(), true);
		}
	}

	public void OnAnimationEventAttack()
	{
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), false, true, Actor.IJJMDPGJAEM.Hero, true);
		if (actorInRange != null && actorInRange.IsLive())
		{
			IAKBNJEFLAN(actorInRange);
			get_m_actor().CreateMissileRPC(m_missileName, m_jaw.transform.position, get_m_target());
		}
		OnAttack();
	}

	public void MCPJBMJJAMH()
	{
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), true, true, (Actor.IJJMDPGJAEM)5, true);
		if (actorInRange != null && actorInRange.IsLive())
		{
			IAKBNJEFLAN(actorInRange);
			get_m_actor().CreateMissileRPC(m_missileName, m_jaw.transform.position, get_m_target());
		}
		OnAttack();
	}

	public virtual void OLBABLDOGHJ()
	{
		LGNMOCFBMHK();
		if (get_m_target() != null)
		{
			SetDirection(get_m_target().GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.ICNAJBHLIGO("hit", true, 1132f, 1944f);
	}

	public override void OnEnterAttack()
	{
		base.OnEnterAttack();
		if (get_m_target() != null)
		{
			SetDirection(get_m_target().GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
	}

	public override void AOMLCLCMJNG()
	{
		base.AOMLCLCMJNG();
		if (get_m_target() != null)
		{
			SetDirection(get_m_target().GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.LKLFMNKDLHJ("attack_voice", false, 640f, 44f);
	}

	public override void OnUpdateDeath()
	{
		float cALECABBOMG = CALECABBOMG;
		CALECABBOMG -= Time.deltaTime;
		if (cALECABBOMG > 0f && CALECABBOMG <= 0f)
		{
			get_m_actor().Warp(OPLEDAJFKAE);
			ActorManager.get_Instance().RemoveActor(get_m_actor());
		}
	}

	public void IOEGBNAFGBK()
	{
		Actor actor = ActorManager.get_Instance().DCMODJADKEE(get_m_actor(), get_m_actor().get_m_att_range(), true, false, Actor.IJJMDPGJAEM.Hero, true);
		if (actor != null && actor.IsLive())
		{
			IAKBNJEFLAN(actor);
			get_m_actor().CreateMissileRPC(m_missileName, m_jaw.transform.position, get_m_target());
		}
		OnAttack();
	}

	public virtual void NNBHCBPELPG()
	{
		base.Init();
		get_m_actor().m_actorAniEvent.add_m_attackEvent(KFEDBJBDKBJ);
		m_respawnRemainTime = GameManager.get_Instance().GetMonsterRespawnTime(get_m_actor().get_m_heroInfo().GPNKIAHCKMG.HDCLGJHNAGL());
		OPLEDAJFKAE = get_m_actor().GetPosition();
	}

	public virtual void KLGENEBKFPC()
	{
		base.Init();
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
		m_respawnRemainTime = GameManager.get_Instance().GetMonsterRespawnTime(get_m_actor().get_m_heroInfo().GPNKIAHCKMG.INGLCFJBNOB());
		OPLEDAJFKAE = get_m_actor().GetPosition();
	}

	public virtual void PHBIONAENBI()
	{
		base.Init();
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
		m_respawnRemainTime = GameManager.get_Instance().GetMonsterRespawnTime(get_m_actor().get_m_heroInfo().GPNKIAHCKMG.ODKFHEJKHMA());
		OPLEDAJFKAE = get_m_actor().GetPosition();
	}

	public virtual void ELILEDHDHEN()
	{
		base.Init();
		get_m_actor().m_actorAniEvent.add_m_attackEvent(GACMKJFNJNF);
		m_respawnRemainTime = GameManager.get_Instance().GetMonsterRespawnTime(get_m_actor().get_m_heroInfo().GPNKIAHCKMG.ODKFHEJKHMA());
		OPLEDAJFKAE = get_m_actor().GetPosition();
	}

	public void BCGOPBEIDEF()
	{
		Actor actorInRange = ActorManager.GBFDGAFALIL().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), true, true, Actor.IJJMDPGJAEM.Hero, true);
		if (actorInRange != null && actorInRange.IsLive())
		{
			IAKBNJEFLAN(actorInRange);
			get_m_actor().CreateMissileRPC(m_missileName, m_jaw.transform.position, get_m_target());
		}
		OnAttack();
	}

	public virtual void OJGBPLFKPIJ()
	{
		base.Init();
		get_m_actor().m_actorAniEvent.add_m_attackEvent(BCGOPBEIDEF);
		m_respawnRemainTime = GameManager.get_Instance().GetMonsterRespawnTime(get_m_actor().get_m_heroInfo().GPNKIAHCKMG.INGLCFJBNOB());
		OPLEDAJFKAE = get_m_actor().GetPosition();
	}

	public void GACMKJFNJNF()
	{
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), true, true, Actor.IJJMDPGJAEM.Monster, true);
		if (actorInRange != null && actorInRange.IsLive())
		{
			IAKBNJEFLAN(actorInRange);
			get_m_actor().CreateMissileRPC(m_missileName, m_jaw.transform.position, get_m_target());
		}
		OnAttack();
	}

	public virtual void KMPNBEMPHKO()
	{
		float cALECABBOMG = CALECABBOMG;
		CALECABBOMG -= Time.deltaTime;
		if (cALECABBOMG > 1990f && CALECABBOMG <= 11f)
		{
			get_m_actor().Warp(OPLEDAJFKAE);
			ActorManager.GBFDGAFALIL().RemoveActor(get_m_actor());
		}
	}
}
