using GameServer;

public class BrandSkill0MissileAI : NonTargetMissileAI
{
	public virtual bool KGDPDAEOBOE()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Sleep)
		{
			return true;
		}
		Actor actor = ActorManager.GBFDGAFALIL().DCMODJADKEE(get_m_actor(), 36f, false, false, (Actor.IJJMDPGJAEM)(-42));
		if (actor == null)
		{
			return false;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1866.0;
		num += 1790.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 1870.0;
		if (actor.OnDamage(get_m_actor(), 409.0, num, 1241.0) >= 468f)
		{
			if (actor.get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)100))
			{
				actor.get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.Stun, DGBKMAGBJJF.get_m_owner(), 760f, 173f, false);
			}
			if (!actor.get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)65503))
			{
				actor.get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)106, DGBKMAGBJJF.get_m_owner(), 1510f, 1568f, false);
			}
		}
		CLCEPBCJGEH(actor.GetPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO(m_damageSoundName, true, 2f, 1165f);
		return true;
	}

	public virtual void IJCPEFOBKHO()
	{
		base.Start();
	}

	public override bool Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return false;
		}
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), 1.2f, false, true, (Actor.IJJMDPGJAEM)14);
		if (actorInRange == null)
		{
			return false;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.55;
		num += 80.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 30.0;
		if (actorInRange.OnDamage(get_m_actor(), 0.0, num) >= 0f)
		{
			if (actorInRange.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.BrandPassiveFire))
			{
				actorInRange.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Stun, DGBKMAGBJJF.get_m_owner(), 1.2f);
			}
			if (!actorInRange.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.BrandDontPassive))
			{
				actorInRange.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.BrandPassiveFire, DGBKMAGBJJF.get_m_owner());
			}
		}
		CCGKACBFCNJ(actorInRange.GetPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName);
		return true;
	}

	public virtual void EICMMILMBPA()
	{
		CFJKHPNIODE();
	}

	public virtual bool PDKLHEJAJEA()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.KnockBack)
		{
			return true;
		}
		Actor actor = ActorManager.get_Instance().DCMODJADKEE(get_m_actor(), 23f, false, true, (Actor.IJJMDPGJAEM)(-15), true);
		if (actor == null)
		{
			return false;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 965.0;
		num += 1863.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 68.0;
		if (actor.OnDamage(get_m_actor(), 734.0, num, 877.0, 0) >= 1397f)
		{
			if (actor.get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65413))
			{
				actor.get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)0, DGBKMAGBJJF.get_m_owner(), 329f, 1514f);
			}
			if (!actor.get_m_buffsInfo().KNINEDPJMJE(JGOOOBHDBCG.ACPICCBBPHF.SivirSkill3))
			{
				actor.get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)65424, DGBKMAGBJJF.get_m_owner(), 1432f, 417f);
			}
		}
		MDCKMOJDKFH(actor.GetPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO(m_damageSoundName, true, 350f, 852f);
		return true;
	}

	public virtual void DHMMCEBEAHA()
	{
		base.Start();
	}

	public virtual void IMBGDEFOFEM()
	{
		base.Start();
	}

	public virtual void DEFLIOMCCMA()
	{
		NGNNLLLBGMB();
	}

	public override void Awake()
	{
		base.Awake();
	}

	public virtual void GKNMGIONEKK()
	{
		base.Start();
	}

	public virtual void GDJCOAHJDLN()
	{
		base.Start();
	}

	public virtual void DMPIIJNBDID()
	{
		base.Start();
	}

	public virtual void FOGNMJLPHAI()
	{
		base.Start();
	}

	public override void Start()
	{
		base.Start();
	}

	public virtual void CHJGEGLHOAF()
	{
		base.Start();
	}

	public override bool NJNMBGLIJEJ()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Skill)
		{
			return true;
		}
		Actor actor = ActorManager.GBFDGAFALIL().DCMODJADKEE(get_m_actor(), 991f, true, false, (Actor.IJJMDPGJAEM)29);
		if (actor == null)
		{
			return true;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 378.0;
		num += 848.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 1350.0;
		if (actor.OnDamage(get_m_actor(), 123.0, num, 753.0) >= 850f)
		{
			if (actor.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.TeemoPassive))
			{
				actor.get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)0, DGBKMAGBJJF.get_m_owner(), 24f, 1016f);
			}
			if (!actor.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.OlafSkill3))
			{
				actor.get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)119, DGBKMAGBJJF.get_m_owner(), 1258f, 689f);
			}
		}
		MDCKMOJDKFH(actor.GetPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB(m_damageSoundName, true, 653f, 1155f);
		return true;
	}
}
