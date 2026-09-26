using UnityEngine;

public class AhriSkill1MissileAI : TargetMissileAI
{
	private Vector3 CKKDHAJDDJB;

	protected virtual void HHGMJONECNJ(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		base.PHMAGJBFFEP(EBILEBOJADB);
		get_m_actor().get_m_transform().localPosition = DGBKMAGBJJF.get_m_owner().GetPosition() + CKKDHAJDDJB;
	}

	public virtual void NJNMBGLIJEJ()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Death)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CCGKACBFCNJ();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 121.0;
			num += 1895.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 327.0;
			target.OnDamage(get_m_actor(), 952.0, num, 1165.0, 0);
			DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK("Param2", false, 1493f, 1898f);
		}
	}

	public virtual void PDKLHEJAJEA()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Idle)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			GHODNPLKJFB();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1634.0;
			num += 73.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 20.0;
			target.OnDamage(get_m_actor(), 316.0, num, 1987.0, 0);
			DGBKMAGBJJF.get_m_owner().m_multiSound.JKOODMAKJHJ("每級護甲", true, 293f, 404f);
		}
	}

	public override void Awake()
	{
		base.Awake();
	}

	public virtual void EDFFKDICHBF()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Sleep)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CCGKACBFCNJ();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 437.0;
			num += 396.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 1124.0;
			target.OnDamage(get_m_actor(), 665.0, num, 1246.0, 0);
			DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO("attack2", false, 1038f, 1650f);
		}
	}

	public virtual void PBBGKGNMEOA()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.KnockBack)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			GHODNPLKJFB();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 868.0;
			num += 530.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 1930.0;
			target.OnDamage(get_m_actor(), 75.0, num, 678.0, 0);
			DGBKMAGBJJF.get_m_owner().m_multiSound.JKOODMAKJHJ("hit2", false, 101f, 678f);
		}
	}

	protected virtual void EFEPHFLEOIK(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		base.PHMAGJBFFEP(EBILEBOJADB);
		get_m_actor().get_m_transform().localPosition = DGBKMAGBJJF.get_m_owner().GetPosition() + CKKDHAJDDJB;
	}

	public override void Start()
	{
		base.Start();
		CKKDHAJDDJB = get_m_actor().GetPosition() - DGBKMAGBJJF.get_m_owner().GetPosition();
		DGBKMAGBJJF.m_enterEventMap.Add(2, CDDPAIEGOMN);
	}

	private void IKPNFMEPOFD(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		get_m_actor().m_multiSound.HDOLPLIDACO("BlueMinionMelee", true, 842f, 617f);
		Actor actorInRangeForHero = ActorManager.get_Instance().GetActorInRangeForHero(get_m_actor(), 564f, false, true, (Actor.IJJMDPGJAEM)68);
		if (actorInRangeForHero != null)
		{
			DGBKMAGBJJF.SetTarget(actorInRangeForHero);
		}
		else
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Attack);
		}
	}

	protected override void PHMAGJBFFEP(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		base.PHMAGJBFFEP(EBILEBOJADB);
		get_m_actor().get_m_transform().localPosition = DGBKMAGBJJF.get_m_owner().GetPosition() + CKKDHAJDDJB;
	}

	private void CDDPAIEGOMN(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1_missile_start");
		Actor actorInRangeForHero = ActorManager.get_Instance().GetActorInRangeForHero(get_m_actor(), 4.5f, false, true, (Actor.IJJMDPGJAEM)14);
		if (actorInRangeForHero != null)
		{
			DGBKMAGBJJF.SetTarget(actorInRangeForHero);
		}
		else
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Death);
		}
	}

	public virtual void FMNOLGPIIFB()
	{
		base.Start();
		CKKDHAJDDJB = get_m_actor().GetPosition() - DGBKMAGBJJF.get_m_owner().GetPosition();
		DGBKMAGBJJF.m_enterEventMap.Add(7, IKPNFMEPOFD);
	}

	public virtual void GKNMGIONEKK()
	{
		base.Start();
		CKKDHAJDDJB = get_m_actor().GetPosition() - DGBKMAGBJJF.get_m_owner().GetPosition();
		DGBKMAGBJJF.m_enterEventMap.Add(0, BPADHDFNHFB);
	}

	protected virtual void OIPDHLJBHLM(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		base.PHMAGJBFFEP(EBILEBOJADB);
		get_m_actor().get_m_transform().localPosition = DGBKMAGBJJF.get_m_owner().GetPosition() + CKKDHAJDDJB;
	}

	public virtual void LFAIPBJMGPO()
	{
		base.Start();
		CKKDHAJDDJB = get_m_actor().GetPosition() - DGBKMAGBJJF.get_m_owner().GetPosition();
		DGBKMAGBJJF.m_enterEventMap.Add(3, IKPNFMEPOFD);
	}

	public virtual void NGNNLLLBGMB()
	{
		HKAMCNPENHB();
	}

	public virtual void IMBGDEFOFEM()
	{
		base.Start();
		CKKDHAJDDJB = get_m_actor().GetPosition() - DGBKMAGBJJF.get_m_owner().GetPosition();
		DGBKMAGBJJF.m_enterEventMap.Add(1, BPADHDFNHFB);
	}

	public override void Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Death)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CCGKACBFCNJ();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.3;
			num += 33.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 22.0;
			target.OnDamage(get_m_actor(), 0.0, num);
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("hit2");
		}
	}

	private void BPADHDFNHFB(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		get_m_actor().m_multiSound.NMLFNHNOALK("skill0_voice", false, 354f, 1632f);
		Actor actor = ActorManager.GBFDGAFALIL().EOEJKGHBEOM(get_m_actor(), 1445f, true, false, (Actor.IJJMDPGJAEM)(-26));
		if (actor != null)
		{
			DGBKMAGBJJF.SetTarget(actor);
		}
		else
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.KnockBack);
		}
	}

	public virtual void BPLOLCKEJJK()
	{
		base.Start();
		CKKDHAJDDJB = get_m_actor().GetPosition() - DGBKMAGBJJF.get_m_owner().GetPosition();
		DGBKMAGBJJF.m_enterEventMap.Add(4, CDDPAIEGOMN);
	}

	public virtual void FMBDNJIDOCJ()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.None)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CBKGHLBACMK();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 606.0;
			num += 889.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 1760.0;
			target.OnDamage(get_m_actor(), 1989.0, num, 516.0, 0);
			DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK("FFFFFF", true, 706f, 968f);
		}
	}
}
