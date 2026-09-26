public class MeleeMonsterSM : HumanSM
{
	public virtual void ICPFOPNOMLI()
	{
		LGNMOCFBMHK();
		Actor actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 283f, false, false, (Actor.IJJMDPGJAEM)(-188));
		if (actorInAttackRange != null)
		{
			SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.LKLFMNKDLHJ("DGHCKMGOOGK", true, 1949f, 1303f);
	}

	public virtual void EHJDBEKDBGD()
	{
		LGNMOCFBMHK();
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 731f, true, false, (Actor.IJJMDPGJAEM)110);
		if (actorInAttackRange != null)
		{
			SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.LNCPFILABHM("destination", false, 616f, 618f);
	}

	public virtual void OPJNHNGAGJJ()
	{
		base.AOMLCLCMJNG();
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 929f, false, false, (Actor.IJJMDPGJAEM)66);
		if (actorInAttackRange != null)
		{
			SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.JKOODMAKJHJ("skill1", true, 601f, 1502f);
	}

	public void JJHLPKFENFG()
	{
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 97f, false, true, (Actor.IJJMDPGJAEM)(-33));
		if (actorInAttackRange != null)
		{
			actorInAttackRange.OnAttackDamage(get_m_actor(), 599.0, 917.0, 1418.0);
		}
		OnAttack();
	}

	public virtual void LFLNAECMCEK()
	{
		base.OnEnterAttack();
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 1064f, true, false, (Actor.IJJMDPGJAEM)(-107));
		if (actorInAttackRange != null)
		{
			SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.LKLFMNKDLHJ("SDKTestCategory", false, 1042f, 18f);
	}

	public void OnAnimationEventAttack()
	{
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 90f, false);
		if (actorInAttackRange != null)
		{
			actorInAttackRange.OnAttackDamage(get_m_actor());
		}
		OnAttack();
	}

	public override void OnEnterAttack()
	{
		base.OnEnterAttack();
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 90f, false);
		if (actorInAttackRange != null)
		{
			SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
	}

	public virtual void HONPBAMBKOG()
	{
		base.Init();
		get_m_actor().m_actorAniEvent.add_m_attackEvent(GACMKJFNJNF);
	}

	public void GACMKJFNJNF()
	{
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 260f, false, true, (Actor.IJJMDPGJAEM)(-103));
		if (actorInAttackRange != null)
		{
			actorInAttackRange.OnAttackDamage(get_m_actor(), 1169.0, 249.0, 468.0);
		}
		OnAttack();
	}

	public virtual void DCDGLIPMNAL()
	{
		base.AOMLCLCMJNG();
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 1344f, false, false, (Actor.IJJMDPGJAEM)99);
		if (actorInAttackRange != null)
		{
			SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.JKOODMAKJHJ("길드 없음", true, 1819f, 1864f);
	}

	public virtual void LLOKNOKMODM()
	{
		base.OnEnterAttack();
		Actor actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 947f, false, true, (Actor.IJJMDPGJAEM)111);
		if (actorInAttackRange != null)
		{
			SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.LKLFMNKDLHJ("attack", true, 1987f, 1909f);
	}

	public void IOEGBNAFGBK()
	{
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 844f, true, false, (Actor.IJJMDPGJAEM)196);
		if (actorInAttackRange != null)
		{
			actorInAttackRange.OnAttackDamage(get_m_actor(), 980.0, 272.0, 372.0);
		}
		OnAttack();
	}

	public virtual void FAHKJKDPHCA()
	{
		base.AOMLCLCMJNG();
		Actor actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 705f, true, true, (Actor.IJJMDPGJAEM)(-117));
		if (actorInAttackRange != null)
		{
			SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.JKOODMAKJHJ("도란의 링", false, 582f, 518f);
	}

	public override void AOMLCLCMJNG()
	{
		base.AOMLCLCMJNG();
		Actor actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 773f, true, true, (Actor.IJJMDPGJAEM)(-175));
		if (actorInAttackRange != null)
		{
			SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.LKLFMNKDLHJ("体力", true, 738f, 233f);
	}

	public override void Init()
	{
		base.Init();
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
	}
}
