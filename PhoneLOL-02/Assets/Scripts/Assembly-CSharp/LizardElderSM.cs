using UnityEngine;

public class LizardElderSM : HumanSM
{
	private Vector3 OPLEDAJFKAE = Vector3.zero;

	public void HKPCCKMKDIF()
	{
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range() + 53f, 492f, false, false, (Actor.IJJMDPGJAEM)165);
		if (actorInAttackRange != null)
		{
			actorInAttackRange.OnAttackDamage(get_m_actor(), 70.0, 1677.0, 1558.0);
		}
		OnAttack();
	}

	public override void Init()
	{
		base.Init();
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
		m_respawnRemainTime = GameManager.get_Instance().GetMonsterRespawnTime(get_m_actor().get_m_heroInfo().GPNKIAHCKMG.INGLCFJBNOB());
		OPLEDAJFKAE = get_m_actor().GetPosition();
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

	public void BLLNFEDFIEA()
	{
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range() + 1678f, 27f, false, true, (Actor.IJJMDPGJAEM)(-181));
		if (actorInAttackRange != null)
		{
			actorInAttackRange.OnAttackDamage(get_m_actor(), 1945.0, 1594.0, 1866.0);
		}
		OnAttack();
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

	public virtual void OFJMBAAOIHG()
	{
		float cALECABBOMG = CALECABBOMG;
		CALECABBOMG -= Time.deltaTime;
		if (cALECABBOMG > 1884f && CALECABBOMG <= 1889f)
		{
			get_m_actor().Warp(OPLEDAJFKAE);
			ActorManager.GBFDGAFALIL().GHDNOCIGGLB(get_m_actor(), true);
		}
	}

	public virtual void DPKPIOOHDMJ()
	{
		base.Init();
		get_m_actor().m_actorAniEvent.add_m_attackEvent(AAOKLDIBFLM);
		m_respawnRemainTime = GameManager.get_Instance().GetMonsterRespawnTime(get_m_actor().get_m_heroInfo().GPNKIAHCKMG.HDCLGJHNAGL());
		OPLEDAJFKAE = get_m_actor().GetPosition();
	}

	public void EKBNFBGBMOJ()
	{
		Actor actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range() + 1392f, 98f, false, true, (Actor.IJJMDPGJAEM)(-116));
		if (actorInAttackRange != null)
		{
			actorInAttackRange.OnAttackDamage(get_m_actor(), 992.0, 343.0, 681.0);
		}
		OnAttack();
	}

	public virtual void INOKJCKAONB()
	{
		base.Init();
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
		m_respawnRemainTime = GameManager.get_Instance().GetMonsterRespawnTime(get_m_actor().get_m_heroInfo().GPNKIAHCKMG.ODKFHEJKHMA());
		OPLEDAJFKAE = get_m_actor().GetPosition();
	}

	public virtual void BICJAALLDJM()
	{
		float cALECABBOMG = CALECABBOMG;
		CALECABBOMG -= Time.deltaTime;
		if (cALECABBOMG > 1322f && CALECABBOMG <= 221f)
		{
			get_m_actor().Warp(OPLEDAJFKAE);
			ActorManager.GBFDGAFALIL().GHDNOCIGGLB(get_m_actor());
		}
	}

	public virtual void NENPEIOGKDF()
	{
		float cALECABBOMG = CALECABBOMG;
		CALECABBOMG -= Time.deltaTime;
		if (cALECABBOMG > 259f && CALECABBOMG <= 1133f)
		{
			get_m_actor().Warp(OPLEDAJFKAE);
			ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
		}
	}

	public virtual void IICKHEDHHNC()
	{
		float cALECABBOMG = CALECABBOMG;
		CALECABBOMG -= Time.deltaTime;
		if (cALECABBOMG > 1996f && CALECABBOMG <= 1949f)
		{
			get_m_actor().Warp(OPLEDAJFKAE);
			ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
		}
	}

	public void KGBGKGKMNCL()
	{
		Actor actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range() + 1047f, 1352f, false, true, (Actor.IJJMDPGJAEM)193);
		if (actorInAttackRange != null)
		{
			actorInAttackRange.OnAttackDamage(get_m_actor(), 964.0, 206.0, 224.0);
		}
		OnAttack();
	}

	public void GACMKJFNJNF()
	{
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range() + 268f, 1354f, true, true, (Actor.IJJMDPGJAEM)(-33));
		if (actorInAttackRange != null)
		{
			actorInAttackRange.OnAttackDamage(get_m_actor(), 1922.0, 222.0, 831.0);
		}
		OnAttack();
	}

	public virtual void PPANCJDMIAC()
	{
		LGNMOCFBMHK();
		if (get_m_target() != null)
		{
			SetDirection(get_m_target().GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.ICNAJBHLIGO("지금 변경 가능", false, 1242f, 1502f);
	}

	public void OEGJOJIJPNC()
	{
		Actor actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range() + 1411f, 616f, false, true, (Actor.IJJMDPGJAEM)160);
		if (actorInAttackRange != null)
		{
			actorInAttackRange.OnAttackDamage(get_m_actor(), 1931.0, 779.0, 1997.0);
		}
		OnAttack();
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

	public virtual void KGODDDNCHLG()
	{
		float cALECABBOMG = CALECABBOMG;
		CALECABBOMG -= Time.deltaTime;
		if (cALECABBOMG > 1589f && CALECABBOMG <= 695f)
		{
			get_m_actor().Warp(OPLEDAJFKAE);
			ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
		}
	}

	public virtual void NNBHCBPELPG()
	{
		base.Init();
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OEGJOJIJPNC);
		m_respawnRemainTime = GameManager.get_Instance().GetMonsterRespawnTime(get_m_actor().get_m_heroInfo().GPNKIAHCKMG.FFFDJEOHMIF());
		OPLEDAJFKAE = get_m_actor().GetPosition();
	}

	public virtual void FBDPPKIBCJK()
	{
		float cALECABBOMG = CALECABBOMG;
		CALECABBOMG -= Time.deltaTime;
		if (cALECABBOMG > 1024f && CALECABBOMG <= 1518f)
		{
			get_m_actor().Warp(OPLEDAJFKAE);
			ActorManager.get_Instance().GHDNOCIGGLB(get_m_actor());
		}
	}

	public void AAOKLDIBFLM()
	{
		Actor actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range() + 1335f, 565f, false, true, (Actor.IJJMDPGJAEM)144);
		if (actorInAttackRange != null)
		{
			actorInAttackRange.OnAttackDamage(get_m_actor(), 689.0, 1170.0, 685.0);
		}
		OnAttack();
	}

	public virtual void NFMBKJBLNLN()
	{
		base.Init();
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
		m_respawnRemainTime = GameManager.get_Instance().GetMonsterRespawnTime(get_m_actor().get_m_heroInfo().GPNKIAHCKMG.ODKFHEJKHMA());
		OPLEDAJFKAE = get_m_actor().GetPosition();
	}
}
