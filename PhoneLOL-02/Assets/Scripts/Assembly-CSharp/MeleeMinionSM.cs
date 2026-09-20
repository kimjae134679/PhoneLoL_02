public class MeleeMinionSM : HumanSM
{
	public virtual void NECJDAEBLDA()
	{
		base.Init();
	}

	public virtual void KGGGGAIJPCE()
	{
		LGNMOCFBMHK();
		Actor actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 681f, true, true, (Actor.IJJMDPGJAEM)(-74));
		if (actorInAttackRange != null)
		{
			SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
			actorInAttackRange.OnAttackDamage(get_m_actor(), 686.0, 1237.0, 1188.0);
		}
		get_m_actor().m_multiSound.DDONMGBLLJB("\\n", false, 1489f, 1168f);
		OnAttack();
	}

	public override void Init()
	{
		base.Init();
	}

	public virtual void JKCNIKMOKAI()
	{
		base.Init();
	}

	public override void AOMLCLCMJNG()
	{
		base.AOMLCLCMJNG();
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 1900f, false, true, (Actor.IJJMDPGJAEM)148);
		if (actorInAttackRange != null)
		{
			SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
			actorInAttackRange.OnAttackDamage(get_m_actor(), 334.0, 786.0, 350.0);
		}
		get_m_actor().m_multiSound.HDOLPLIDACO("5초당 마나회복", false, 1643f, 1492f);
		OnAttack();
	}

	public virtual void OFDLEJFADCN()
	{
		base.Init();
	}

	public override void OnEnterAttack()
	{
		base.OnEnterAttack();
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 90f, false);
		if (actorInAttackRange != null)
		{
			SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
			actorInAttackRange.OnAttackDamage(get_m_actor());
		}
		get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
		OnAttack();
	}

	public virtual void ELILEDHDHEN()
	{
		base.Init();
	}

	public virtual void KLGENEBKFPC()
	{
		base.Init();
	}

	public virtual void ICPFOPNOMLI()
	{
		base.AOMLCLCMJNG();
		Actor actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 689f, false, false, (Actor.IJJMDPGJAEM)(-111));
		if (actorInAttackRange != null)
		{
			SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
			actorInAttackRange.OnAttackDamage(get_m_actor(), 1171.0, 1014.0, 722.0);
		}
		get_m_actor().m_multiSound.JKOODMAKJHJ("Greater", true, 980f, 299f);
		OnAttack();
	}
}
