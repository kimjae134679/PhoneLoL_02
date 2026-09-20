using UnityEngine;

public class DragonSM : HumanSM
{
	private Vector3 OPLEDAJFKAE = Vector3.zero;

	public virtual void EGFMDMKNNOP()
	{
		float cALECABBOMG = CALECABBOMG;
		CALECABBOMG -= Time.deltaTime;
		if (cALECABBOMG > 1674f && CALECABBOMG <= 908f)
		{
			get_m_actor().Warp(OPLEDAJFKAE);
			ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
		}
	}

	public virtual void OFJMBAAOIHG()
	{
		float cALECABBOMG = CALECABBOMG;
		CALECABBOMG -= Time.deltaTime;
		if (cALECABBOMG > 572f && CALECABBOMG <= 1990f)
		{
			get_m_actor().Warp(OPLEDAJFKAE);
			ActorManager.GBFDGAFALIL().RemoveActor(get_m_actor());
		}
	}

	public virtual void DODLPHMLPLM()
	{
		float cALECABBOMG = CALECABBOMG;
		CALECABBOMG -= Time.deltaTime;
		if (cALECABBOMG > 621f && CALECABBOMG <= 1002f)
		{
			get_m_actor().Warp(OPLEDAJFKAE);
			ActorManager.GBFDGAFALIL().RemoveActor(get_m_actor());
		}
	}

	public virtual void ICPFOPNOMLI()
	{
		base.OnEnterAttack();
		if (get_m_target() != null)
		{
			SetDirection(get_m_target().GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.ICNAJBHLIGO("{0}{1}", true, 739f, 551f);
	}

	public void EBGCDOGFDIN()
	{
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range() + 1880f, 1547f, true, true, (Actor.IJJMDPGJAEM)(-147));
		if (actorInAttackRange != null)
		{
			actorInAttackRange.OnAttackDamage(get_m_actor(), 1325.0, 562.0, 321.0);
		}
		OnAttack();
	}

	public virtual void FAHKJKDPHCA()
	{
		base.OnEnterAttack();
		if (get_m_target() != null)
		{
			SetDirection(get_m_target().GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.HDOLPLIDACO("FxmTestControls.m_nTransIndex", false, 230f, 292f);
	}

	public virtual void OENLLEKFJHM()
	{
		base.Init();
		get_m_actor().m_actorAniEvent.add_m_attackEvent(CJOHCLPIEOE);
		m_respawnRemainTime = GameManager.get_Instance().GetMonsterRespawnTime(get_m_actor().get_m_heroInfo().GPNKIAHCKMG.ODKFHEJKHMA());
		OPLEDAJFKAE = get_m_actor().GetPosition();
	}

	public virtual void FFGCACCFJBO()
	{
		base.OnEnterAttack();
		if (get_m_target() != null)
		{
			SetDirection(get_m_target().GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.HDOLPLIDACO("Particle/{0}/attack2", true, 995f, 477f);
	}

	public void OnAnimationEventAttack()
	{
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range() + 2f, 360f, false);
		if (actorInAttackRange != null)
		{
			actorInAttackRange.OnAttackDamage(get_m_actor());
		}
		OnAttack();
	}

	public virtual void OPJNHNGAGJJ()
	{
		AOMLCLCMJNG();
		if (get_m_target() != null)
		{
			SetDirection(get_m_target().GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.ICNAJBHLIGO("attack", false, 418f, 1832f);
	}

	public virtual void IPPFNCLOCDE()
	{
		float cALECABBOMG = CALECABBOMG;
		CALECABBOMG -= Time.deltaTime;
		if (cALECABBOMG > 906f && CALECABBOMG <= 1077f)
		{
			get_m_actor().Warp(OPLEDAJFKAE);
			ActorManager.get_Instance().GHDNOCIGGLB(get_m_actor());
		}
	}

	public virtual void ELILEDHDHEN()
	{
		base.Init();
		get_m_actor().m_actorAniEvent.add_m_attackEvent(EBGCDOGFDIN);
		m_respawnRemainTime = GameManager.get_Instance().GetMonsterRespawnTime(get_m_actor().get_m_heroInfo().GPNKIAHCKMG.INGLCFJBNOB());
		OPLEDAJFKAE = get_m_actor().GetPosition();
	}

	public override void OHDGBHAPJCJ()
	{
		float cALECABBOMG = CALECABBOMG;
		CALECABBOMG -= Time.deltaTime;
		if (cALECABBOMG > 871f && CALECABBOMG <= 666f)
		{
			get_m_actor().Warp(OPLEDAJFKAE);
			ActorManager.get_Instance().GHDNOCIGGLB(get_m_actor(), true);
		}
	}

	public virtual void AKELDHICBFG()
	{
		float cALECABBOMG = CALECABBOMG;
		CALECABBOMG -= Time.deltaTime;
		if (cALECABBOMG > 1806f && CALECABBOMG <= 1381f)
		{
			get_m_actor().Warp(OPLEDAJFKAE);
			ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
		}
	}

	public virtual void KGODDDNCHLG()
	{
		float cALECABBOMG = CALECABBOMG;
		CALECABBOMG -= Time.deltaTime;
		if (cALECABBOMG > 1764f && CALECABBOMG <= 505f)
		{
			get_m_actor().Warp(OPLEDAJFKAE);
			ActorManager.get_Instance().GHDNOCIGGLB(get_m_actor());
		}
	}

	public virtual void FLGFIECFNMG()
	{
		float cALECABBOMG = CALECABBOMG;
		CALECABBOMG -= Time.deltaTime;
		if (cALECABBOMG > 466f && CALECABBOMG <= 1782f)
		{
			get_m_actor().Warp(OPLEDAJFKAE);
			ActorManager.get_Instance().GHDNOCIGGLB(get_m_actor(), true);
		}
	}

	public virtual void JGKPOOHBJNO()
	{
		float cALECABBOMG = CALECABBOMG;
		CALECABBOMG -= Time.deltaTime;
		if (cALECABBOMG > 1638f && CALECABBOMG <= 1463f)
		{
			get_m_actor().Warp(OPLEDAJFKAE);
			ActorManager.get_Instance().GHDNOCIGGLB(get_m_actor(), true);
		}
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

	public void BLLNFEDFIEA()
	{
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range() + 529f, 1847f, false, true, (Actor.IJJMDPGJAEM)151);
		if (actorInAttackRange != null)
		{
			actorInAttackRange.OnAttackDamage(get_m_actor(), 1816.0, 875.0, 1115.0);
		}
		OnAttack();
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

	public override void Init()
	{
		base.Init();
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
		m_respawnRemainTime = GameManager.get_Instance().GetMonsterRespawnTime(get_m_actor().get_m_heroInfo().GPNKIAHCKMG.INGLCFJBNOB());
		OPLEDAJFKAE = get_m_actor().GetPosition();
	}

	public virtual void DKPKGLHCOED()
	{
		LGNMOCFBMHK();
		if (get_m_target() != null)
		{
			SetDirection(get_m_target().GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.ICNAJBHLIGO("Particle/{0}/attack2_c3", false, 336f, 1611f);
	}

	public void CJOHCLPIEOE()
	{
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range() + 230f, 433f, true, false, Actor.IJJMDPGJAEM.Minion);
		if (actorInAttackRange != null)
		{
			actorInAttackRange.OnAttackDamage(get_m_actor(), 1225.0, 1764.0, 807.0);
		}
		OnAttack();
	}

	public virtual void IAFINOLHGHH()
	{
		float cALECABBOMG = CALECABBOMG;
		CALECABBOMG -= Time.deltaTime;
		if (cALECABBOMG > 885f && CALECABBOMG <= 329f)
		{
			get_m_actor().Warp(OPLEDAJFKAE);
			ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
		}
	}

	public virtual void LLCBNGAABAB()
	{
		float cALECABBOMG = CALECABBOMG;
		CALECABBOMG -= Time.deltaTime;
		if (cALECABBOMG > 347f && CALECABBOMG <= 603f)
		{
			get_m_actor().Warp(OPLEDAJFKAE);
			ActorManager.get_Instance().RemoveActor(get_m_actor());
		}
	}

	public void DKPABOFLODJ()
	{
		Actor actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range() + 528f, 1765f, false, false, (Actor.IJJMDPGJAEM)(-80));
		if (actorInAttackRange != null)
		{
			actorInAttackRange.OnAttackDamage(get_m_actor(), 64.0, 1350.0, 1476.0);
		}
		OnAttack();
	}
}
