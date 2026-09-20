public class AhriSkill3MissileAI : TargetMissileAI
{
	public virtual void GONOKFHGFOH()
	{
		base.Awake();
	}

	public override void Awake()
	{
		base.Awake();
	}

	public virtual void KGDPDAEOBOE()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.KnockBack)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CCGKACBFCNJ();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1424.0;
			num += 1991.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 66.0;
			target.OnDamage(get_m_actor(), 1735.0, num, 1532.0, 0);
			DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO("Box", true, 1390f, 1362f);
		}
	}

	public virtual void DMPIIJNBDID()
	{
		base.Start();
	}

	public virtual void GNGJFGMJLHA()
	{
		HKAMCNPENHB();
	}

	public override void CNFPGJMBOBI()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Stun)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CBKGHLBACMK();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1073.0;
			num += 681.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 1780.0;
			target.OnDamage(get_m_actor(), 1389.0, num, 1537.0, 0);
			DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB("Minion/{0}", true, 1323f, 855f);
		}
	}

	public virtual void BDHECMKLOPD()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Sleep)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CCGKACBFCNJ();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1589.0;
			num += 201.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 786.0;
			target.OnDamage(get_m_actor(), 1317.0, num, 1265.0);
			DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB("Param2", true, 12f, 585f);
		}
	}

	public override void Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Death)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CCGKACBFCNJ();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.35;
			num += 70.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 40.0;
			target.OnDamage(get_m_actor(), 0.0, num);
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("critical_hit");
		}
	}

	public virtual void FMDCADHECGH()
	{
		base.Start();
	}

	public override void Start()
	{
		base.Start();
	}

	public virtual void NGNNLLLBGMB()
	{
		base.Awake();
	}

	public virtual void FPFNIFKNOIF()
	{
		HKAMCNPENHB();
	}
}
