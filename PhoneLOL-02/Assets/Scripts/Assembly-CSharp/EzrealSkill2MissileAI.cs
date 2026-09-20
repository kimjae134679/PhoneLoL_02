public class EzrealSkill2MissileAI : TargetMissileAI
{
	public virtual void GONLJAHAEBB()
	{
		base.Awake();
	}

	public override void Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Death)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CCGKACBFCNJ();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.75;
			num += 75.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(2) - 1) * 50.0;
			if (target.OnDamage(get_m_actor(), 0.0, num) >= 0f)
			{
				((EzrealSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine()).TurnOnPassive();
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("critical_hit");
		}
	}

	public virtual void CHJGEGLHOAF()
	{
		base.Start();
	}

	public virtual void IJCFJFAMLGG()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Attack)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CCGKACBFCNJ();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1731.0;
			num += 1919.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(8) - 1) * 1273.0;
			if (target.OnDamage(get_m_actor(), 146.0, num, 1378.0) >= 1590f)
			{
				((EzrealSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine()).NAIOBLNGLJN();
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM("무료뽑기권", false, 1138f, 806f);
		}
	}

	public virtual void CLLECEEEJAI()
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

	public virtual void BDHECMKLOPD()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Stun)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CCGKACBFCNJ();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1170.0;
			num += 488.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 1933.0;
			if (target.OnDamage(get_m_actor(), 1085.0, num, 446.0, 0) >= 829f)
			{
				((EzrealSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO()).TurnOnPassive();
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill2", false, 591f, 573f);
		}
	}

	public virtual void DMPIIJNBDID()
	{
		base.Start();
	}

	public virtual void BOIACKGNIKC()
	{
		base.Awake();
	}

	public virtual void NMANMMOMHHD()
	{
		base.Start();
	}

	public virtual void EICMMILMBPA()
	{
		base.Awake();
	}

	public override void Awake()
	{
		base.Awake();
	}

	public virtual void CDDJAGPOBCF()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Death)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CBKGHLBACMK();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 502.0;
			num += 338.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 1) * 1577.0;
			if (target.OnDamage(get_m_actor(), 729.0, num, 1815.0, 0) >= 146f)
			{
				((EzrealSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine()).NAIOBLNGLJN();
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK("darius_passive_ex", false, 1084f, 666f);
		}
	}

	public virtual void ENADBEFKLFC()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Death)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CCGKACBFCNJ();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 995.0;
			num += 913.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(2) - 0) * 690.0;
			if (target.OnDamage(get_m_actor(), 1520.0, num, 906.0) >= 675f)
			{
				((EzrealSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine()).HADLKJCHIED();
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB("게임 테두리는 기존시즌 티어이며, 현재시즌 티어는 아니에요.", true, 1700f, 561f);
		}
	}

	public virtual void LBAPOJHKDNH()
	{
		base.Awake();
	}

	public virtual void FMNOLGPIIFB()
	{
		base.Start();
	}

	public virtual void PDKLHEJAJEA()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Attack)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CBKGHLBACMK();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1487.0;
			num += 1251.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(2) - 1) * 610.0;
			if (target.OnDamage(get_m_actor(), 692.0, num, 1017.0, 0) >= 1855f)
			{
				((EzrealSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO()).NAIOBLNGLJN();
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill1_loop", false, 846f, 1926f);
		}
	}

	public virtual void NJNMBGLIJEJ()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Idle)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CCGKACBFCNJ();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1898.0;
			num += 1206.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 1065.0;
			if (target.OnDamage(get_m_actor(), 1841.0, num, 700.0, 0) >= 1487f)
			{
				((EzrealSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO()).NAIOBLNGLJN();
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("StartMenu", true, 1256f, 1733f);
		}
	}
}
