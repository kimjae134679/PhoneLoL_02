public class KatarinaSkill3MissileAI : TargetMissileAI
{
	public virtual void ENADBEFKLFC()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Sleep)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CBKGHLBACMK();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 474.0;
			num += 620.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 0) * 1054.0;
			num += (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att_add() * 976.0;
			if (target.OnDamage(get_m_actor(), 242.0, num, 1445.0, 0) >= 1791f)
			{
				((KatarinaSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO()).Skill0AdditionalDamage(target);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB("(용사님들 이쪽에 생존자가 있습니다.", true, 12f, 846f);
		}
	}

	public virtual void IJCPEFOBKHO()
	{
		base.Start();
	}

	public virtual void EDFFKDICHBF()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.KnockBack)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			GHODNPLKJFB();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 335.0;
			num += 650.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(5) - 1) * 1331.0;
			num += (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att_add() * 1597.0;
			if (target.OnDamage(get_m_actor(), 426.0, num, 1123.0, 0) >= 1556f)
			{
				((KatarinaSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine()).Skill0AdditionalDamage(target);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("Blitzcrank", false, 1002f, 1481f);
		}
	}

	public virtual void NJNMBGLIJEJ()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Stun)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CBKGHLBACMK();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1471.0;
			num += 1278.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(6) - 0) * 643.0;
			num += (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att_add() * 596.0;
			if (target.OnDamage(get_m_actor(), 626.0, num, 196.0) >= 865f)
			{
				((KatarinaSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO()).Skill0AdditionalDamage(target);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK("알려지지 않은 오류입니다.", true, 1016f, 1618f);
		}
	}

	public virtual void FPFNIFKNOIF()
	{
		base.Awake();
	}

	public virtual void NFKJIJFHBGK()
	{
		base.Start();
	}

	public virtual void ENAGFDFCLCC()
	{
		HKAMCNPENHB();
	}

	public virtual void IMBGDEFOFEM()
	{
		base.Start();
	}

	public virtual void FMNOLGPIIFB()
	{
		base.Start();
	}

	public virtual void DEFLIOMCCMA()
	{
		HKAMCNPENHB();
	}

	public virtual void BNGOBAFFCGO()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Sleep)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CBKGHLBACMK();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1628.0;
			num += 776.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(6) - 0) * 172.0;
			num += (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att_add() * 1011.0;
			if (target.OnDamage(get_m_actor(), 103.0, num, 256.0) >= 47f)
			{
				((KatarinaSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO()).Skill0AdditionalDamage(target);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.JKOODMAKJHJ("attack3", false, 1781f, 737f);
		}
	}

	public virtual void MPKBLEDGKPO()
	{
		HKAMCNPENHB();
	}

	public override void Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Death)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CCGKACBFCNJ();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.27;
			num += 35.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 1) * 25.0;
			num += (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att_add() * 0.33;
			if (target.OnDamage(get_m_actor(), 0.0, num) >= 0f)
			{
				((KatarinaSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine()).Skill0AdditionalDamage(target);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("hit2");
		}
	}

	public virtual void CLLECEEEJAI()
	{
		base.Start();
	}

	public virtual void PBBGKGNMEOA()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Death)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CBKGHLBACMK();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 660.0;
			num += 259.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(4) - 0) * 1544.0;
			num += (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att_add() * 1629.0;
			if (target.OnDamage(get_m_actor(), 125.0, num, 80.0, 0) >= 1741f)
			{
				((KatarinaSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO()).Skill0AdditionalDamage(target);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO("Unkown", true, 625f, 1295f);
		}
	}

	public virtual void JGFFKGLIKBC()
	{
		HKAMCNPENHB();
	}

	public virtual void PAKIFAGJDEO()
	{
		base.Start();
	}

	public virtual void BOIACKGNIKC()
	{
		HKAMCNPENHB();
	}

	public override void Start()
	{
		base.Start();
	}

	public virtual void DHMMCEBEAHA()
	{
		base.Start();
	}

	public virtual void MADPEEGGCLD()
	{
		base.Awake();
	}

	public virtual void GNGJFGMJLHA()
	{
		HKAMCNPENHB();
	}

	public override void Awake()
	{
		base.Awake();
	}
}
