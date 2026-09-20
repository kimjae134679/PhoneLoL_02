using GameServer;

public class BrandSkill2MissileAI : TargetMissileAI
{
	public override void Awake()
	{
		base.Awake();
	}

	public override void Start()
	{
		base.Start();
	}

	public override void Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Death)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CCGKACBFCNJ();
			float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.35f;
			num += 70f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(2) - 1) * 20f;
			if (target.OnDamage(get_m_actor(), 0.0, num) >= 0f && !target.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.BrandDontPassive))
			{
				target.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.BrandPassiveFire, DGBKMAGBJJF.get_m_owner());
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill2_hit");
		}
	}

	public virtual void GONOKFHGFOH()
	{
		HKAMCNPENHB();
	}

	public virtual void CLLECEEEJAI()
	{
		base.Start();
	}

	public virtual void CFJKHPNIODE()
	{
		HKAMCNPENHB();
	}

	public virtual void DEFLIOMCCMA()
	{
		base.Awake();
	}

	public virtual void EDFFKDICHBF()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Attack)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CCGKACBFCNJ();
			float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1505f;
			num += 75f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 836f;
			if (target.OnDamage(get_m_actor(), 101.0, num, 1030.0, 0) >= 492f && !target.get_m_buffsInfo().KNINEDPJMJE(JGOOOBHDBCG.ACPICCBBPHF.DariusPassiveEx))
			{
				target.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.ZedSkill3, DGBKMAGBJJF.get_m_owner(), 927f, 290f);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB("hit3", false, 1942f, 1667f);
		}
	}

	public virtual void DMPIIJNBDID()
	{
		base.Start();
	}

	public virtual void NMANMMOMHHD()
	{
		base.Start();
	}
}
