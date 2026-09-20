using GameServer;

public class TeemoAttackMissileAI : TargetMissileAI
{
	public virtual void CLLECEEEJAI()
	{
		base.Start();
	}

	public virtual void ABMMGINPLAD()
	{
		base.Awake();
	}

	public virtual void BDHECMKLOPD()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Attack)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			float num = 1580f;
			if (DGBKMAGBJJF.get_m_owner().GetSkillLevel(5) > 1)
			{
				num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 204f;
				num += 613f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(6) - 1) * 1485f;
			}
			target.OnAttackDamage(get_m_actor(), 643.0, num, 156.0);
			if (DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) > 1 && (target.m_actorType == (Actor.IJJMDPGJAEM)5 || target.m_actorType == (Actor.IJJMDPGJAEM)5 || target.m_actorType == (Actor.IJJMDPGJAEM)7))
			{
				target.get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.KatarinaSkill0, DGBKMAGBJJF.get_m_owner(), 1005f, 530f);
			}
			CCGKACBFCNJ();
			DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO(m_damageSoundName, false, 1987f, 1453f);
			if (m_onTargetAttack != null)
			{
				m_onTargetAttack(target);
			}
		}
	}

	public override void Awake()
	{
		base.Awake();
	}

	public override void Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Death)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			float num = 0f;
			if (DGBKMAGBJJF.get_m_owner().GetSkillLevel(2) > 0)
			{
				num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.3f;
				num += 10f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(2) - 1) * 10f;
			}
			target.OnAttackDamage(get_m_actor(), 0.0, num);
			if (DGBKMAGBJJF.get_m_owner().GetSkillLevel(2) > 0 && (target.m_actorType == Actor.IJJMDPGJAEM.Hero || target.m_actorType == Actor.IJJMDPGJAEM.Minion || target.m_actorType == Actor.IJJMDPGJAEM.Monster))
			{
				target.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.TeemoSkill2Poison, DGBKMAGBJJF.get_m_owner());
			}
			CCGKACBFCNJ();
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName);
			if (m_onTargetAttack != null)
			{
				m_onTargetAttack(target);
			}
		}
	}

	public virtual void HDIJFEFNGOD()
	{
		base.HKAMCNPENHB();
	}

	public virtual void NFKJIJFHBGK()
	{
		base.Start();
	}

	public override void HKAMCNPENHB()
	{
		base.Awake();
	}

	public virtual void GNGJFGMJLHA()
	{
		base.HKAMCNPENHB();
	}

	public virtual void MNFFCGOAPDO()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Skill)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			float num = 1888f;
			if (DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) > 0)
			{
				num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1711f;
				num += 1529f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 1) * 869f;
			}
			target.OnAttackDamage(get_m_actor(), 160.0, num, 1199.0);
			if (DGBKMAGBJJF.get_m_owner().GetSkillLevel(6) > 1 && (target.m_actorType == (Actor.IJJMDPGJAEM)7 || target.m_actorType == Actor.IJJMDPGJAEM.Unknown || target.m_actorType == (Actor.IJJMDPGJAEM)7))
			{
				target.get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)88, DGBKMAGBJJF.get_m_owner(), 1203f, 165f);
			}
			CCGKACBFCNJ();
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName, false, 899f, 1055f);
			if (m_onTargetAttack != null)
			{
				m_onTargetAttack(target);
			}
		}
	}

	public virtual void IBBJMMFDGAL()
	{
		base.Start();
	}

	public virtual void GKNMGIONEKK()
	{
		base.Start();
	}

	public virtual void CHJGEGLHOAF()
	{
		base.Start();
	}

	public virtual void GDJCOAHJDLN()
	{
		base.Start();
	}

	public virtual void BPLOLCKEJJK()
	{
		base.Start();
	}

	public override void Start()
	{
		base.Start();
	}
}
