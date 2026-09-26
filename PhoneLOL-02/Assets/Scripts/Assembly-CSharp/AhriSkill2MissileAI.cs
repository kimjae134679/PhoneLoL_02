using GameServer;

public class AhriSkill2MissileAI : NonTargetMissileAI
{
	public virtual void FMDCADHECGH()
	{
		base.Start();
	}

	public override bool NJNMBGLIJEJ()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Idle)
		{
			return false;
		}
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)58, true);
		if (actorInRange == null)
		{
			return true;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1034.0;
		num += 139.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(6) - 1) * 1445.0;
		float num2 = 543f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(6) - 0) * 1107f;
		if (actorInRange.OnDamage(get_m_actor(), 279.0, num, 1289.0, 0) >= 222f && actorInRange.m_hero_id != -175 && actorInRange.m_hero_id != -36 && DGBKMAGBJJF.get_m_owner().get_m_view().IsMine())
		{
			actorInRange.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.VladimirSkill2, DGBKMAGBJJF.get_m_owner(), 1398f, 52f);
		}
		CLCEPBCJGEH(actorInRange.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB(m_damageSoundName, false, 1109f, 1034f);
		return true;
	}

	public virtual void FMNOLGPIIFB()
	{
		base.Start();
	}

	public virtual void DHMMCEBEAHA()
	{
		base.Start();
	}

	public virtual bool CDDJAGPOBCF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Idle)
		{
			return false;
		}
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), m_attackRange, true, true, (Actor.IJJMDPGJAEM)(-8), true);
		if (actorInRange == null)
		{
			return true;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 182.0;
		num += 411.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 1) * 1637.0;
		float num2 = 1974f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 1) * 850f;
		if (actorInRange.OnDamage(get_m_actor(), 887.0, num, 506.0) >= 779f && actorInRange.m_hero_id != -28 && actorInRange.m_hero_id != 124 && DGBKMAGBJJF.get_m_owner().get_m_view().IsMine())
		{
			actorInRange.get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)65502, DGBKMAGBJJF.get_m_owner(), 492f, 683f, false);
		}
		CLCEPBCJGEH(actorInRange.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.JKOODMAKJHJ(m_damageSoundName, true, 310f, 1911f);
		return true;
	}

	public virtual void IFAJINMCMLM()
	{
		base.Awake();
	}

	public virtual bool DOHJCDCAFFG()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Skill)
		{
			return false;
		}
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), m_attackRange, false, false, (Actor.IJJMDPGJAEM)(-79), true);
		if (actorInRange == null)
		{
			return false;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 388.0;
		num += 1401.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(8) - 1) * 262.0;
		float num2 = 760f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(5) - 1) * 1793f;
		if (actorInRange.OnDamage(get_m_actor(), 764.0, num, 169.0) >= 366f && actorInRange.m_hero_id != 72 && actorInRange.m_hero_id != 65 && DGBKMAGBJJF.get_m_owner().get_m_view().IsMine())
		{
			actorInRange.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.RenektonSkill2, DGBKMAGBJJF.get_m_owner(), 666f, 1665f);
		}
		MDCKMOJDKFH(actorInRange.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName, false, 1226f, 559f);
		return true;
	}

	public virtual void BJFPJALLFFL()
	{
		base.Start();
	}

	public override void Awake()
	{
		base.Awake();
	}

	public override void Start()
	{
		base.Start();
	}

	public virtual void FONPAFKDMCG()
	{
		CFJKHPNIODE();
	}

	public virtual void JGFFKGLIKBC()
	{
		base.Awake();
	}

	public virtual bool BNGOBAFFCGO()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Run)
		{
			return false;
		}
		Actor actor = ActorManager.get_Instance().DCMODJADKEE(get_m_actor(), m_attackRange, true, true, (Actor.IJJMDPGJAEM)86);
		if (actor == null)
		{
			return true;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1057.0;
		num += 557.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(5) - 0) * 10.0;
		float num2 = 1428f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 757f;
		if (actor.OnDamage(get_m_actor(), 831.0, num, 946.0, 0) >= 1987f && actor.m_hero_id != -134 && actor.m_hero_id != -1 && DGBKMAGBJJF.get_m_owner().get_m_view().IsMine())
		{
			actor.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.MasterYiSkill3, DGBKMAGBJJF.get_m_owner(), 81f, 1828f, false);
		}
		MDCKMOJDKFH(actor.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO(m_damageSoundName, true, 1355f, 305f);
		return true;
	}

	public virtual bool IMAEOPHIHPL()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.None)
		{
			return false;
		}
		Actor actorInRange = ActorManager.GBFDGAFALIL().GetActorInRange(get_m_actor(), m_attackRange, true, true, (Actor.IJJMDPGJAEM)15, true);
		if (actorInRange == null)
		{
			return false;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 259.0;
		num += 882.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(6) - 1) * 1014.0;
		float num2 = 458f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(8) - 0) * 1013f;
		if (actorInRange.OnDamage(get_m_actor(), 1145.0, num, 233.0, 0) >= 364f && actorInRange.m_hero_id != -150 && actorInRange.m_hero_id != 19 && DGBKMAGBJJF.get_m_owner().get_m_view().IsMine())
		{
			actorInRange.get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)65435, DGBKMAGBJJF.get_m_owner(), 830f, 1875f, false);
		}
		CLCEPBCJGEH(actorInRange.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName, false, 1207f, 1722f);
		return true;
	}

	public virtual void IPFEBDCDMFA()
	{
		base.Start();
	}

	public virtual void FODOJCDNGOC()
	{
		base.Start();
	}

	public virtual bool AGAOFFIOHBL()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Sleep)
		{
			return true;
		}
		Actor actor = ActorManager.get_Instance().DCMODJADKEE(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)70, true);
		if (actor == null)
		{
			return true;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1319.0;
		num += 409.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(8) - 0) * 548.0;
		float num2 = 490f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(4) - 0) * 530f;
		if (actor.OnDamage(get_m_actor(), 164.0, num, 1006.0) >= 1405f && actor.m_hero_id != -143 && actor.m_hero_id != 1 && DGBKMAGBJJF.get_m_owner().get_m_view().IsMine())
		{
			actor.get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.LucianSkill1SpeedUp, DGBKMAGBJJF.get_m_owner(), 544f, 856f);
		}
		CCGKACBFCNJ(actor.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO(m_damageSoundName, false, 1368f, 1674f);
		return true;
	}

	public override bool Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return false;
		}
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)14);
		if (actorInRange == null)
		{
			return false;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.5;
		num += 60.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(2) - 1) * 35.0;
		float num2 = 1f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(2) - 1) * 0.15f;
		if (actorInRange.OnDamage(get_m_actor(), 0.0, num) >= 0f && actorInRange.m_hero_id != 20002 && actorInRange.m_hero_id != 20003 && DGBKMAGBJJF.get_m_owner().get_m_view().IsMine())
		{
			actorInRange.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.AhriSkill2, DGBKMAGBJJF.get_m_owner(), -1f, -1f, false);
		}
		CCGKACBFCNJ(actorInRange.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName);
		return true;
	}

	public virtual void NMANMMOMHHD()
	{
		base.Start();
	}

	public virtual void KILCHOJIIOO()
	{
		NGNNLLLBGMB();
	}
}
