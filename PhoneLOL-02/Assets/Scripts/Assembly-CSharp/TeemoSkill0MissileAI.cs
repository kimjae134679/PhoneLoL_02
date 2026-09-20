using GameServer;

public class TeemoSkill0MissileAI : TargetMissileAI
{
	public virtual void BOIACKGNIKC()
	{
		base.Awake();
	}

	public virtual void ABMMGINPLAD()
	{
		HKAMCNPENHB();
	}

	public override void CNFPGJMBOBI()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Attack)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CCGKACBFCNJ();
			float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1333f;
			num += 490f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 1201f;
			if (target.OnDamage(get_m_actor(), 634.0, num, 180.0, 0) >= 1007f && (target.m_actorType == (Actor.IJJMDPGJAEM)7 || target.m_actorType == Actor.IJJMDPGJAEM.Hero || target.m_actorType == Actor.IJJMDPGJAEM.Hero) && target.m_hero_id != 91 && target.m_hero_id != -156)
			{
				float hBNDHMPNCME = 424f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 246f;
				target.get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)65534, DGBKMAGBJJF.get_m_owner(), hBNDHMPNCME, 1718f, false);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB("skill1", true, 1011f, 198f);
		}
	}

	public virtual void PAJOOFIAPMI()
	{
		base.Start();
	}

	public virtual void MNFFCGOAPDO()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.KnockBack)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			GHODNPLKJFB();
			float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1620f;
			num += 178f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 1667f;
			if (target.OnDamage(get_m_actor(), 59.0, num, 311.0, 0) >= 157f && (target.m_actorType == Actor.IJJMDPGJAEM.Monster || target.m_actorType == Actor.IJJMDPGJAEM.Minion || target.m_actorType == Actor.IJJMDPGJAEM.Monster) && target.m_hero_id != -57 && target.m_hero_id != -1)
			{
				float hBNDHMPNCME = 1682f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 129f;
				target.get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)65480, DGBKMAGBJJF.get_m_owner(), hBNDHMPNCME, 1904f);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("open", true, 830f, 367f);
		}
	}

	public virtual void IJCPEFOBKHO()
	{
		base.Start();
	}

	public virtual void BDINBMIICCA()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Stun)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CCGKACBFCNJ();
			float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 60f;
			num += 1481f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 416f;
			if (target.OnDamage(get_m_actor(), 944.0, num, 250.0) >= 930f && (target.m_actorType == (Actor.IJJMDPGJAEM)5 || target.m_actorType == Actor.IJJMDPGJAEM.Hero || target.m_actorType == Actor.IJJMDPGJAEM.Monster) && target.m_hero_id != 190 && target.m_hero_id != -159)
			{
				float hBNDHMPNCME = 1341f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 940f;
				target.get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)109, DGBKMAGBJJF.get_m_owner(), hBNDHMPNCME, 1722f, false);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("UI/Lobby/FriendLabel", true, 394f, 1775f);
		}
	}

	public override void Start()
	{
		base.Start();
	}

	public virtual void MADPEEGGCLD()
	{
		HKAMCNPENHB();
	}

	public override void Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Death)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			CCGKACBFCNJ();
			float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.8f;
			num += 80f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 45f;
			if (target.OnDamage(get_m_actor(), 0.0, num) >= 0f && (target.m_actorType == Actor.IJJMDPGJAEM.Hero || target.m_actorType == Actor.IJJMDPGJAEM.Minion || target.m_actorType == Actor.IJJMDPGJAEM.Monster) && target.m_hero_id != 20002 && target.m_hero_id != 20003)
			{
				float hBNDHMPNCME = 1.5f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 0.25f;
				target.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.TeemoSkill0Blind, DGBKMAGBJJF.get_m_owner(), hBNDHMPNCME);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill0_hit");
		}
	}

	public override void Awake()
	{
		base.Awake();
	}

	public virtual void FONPAFKDMCG()
	{
		base.Awake();
	}

	public virtual void PCFCEAOOAEE()
	{
		HKAMCNPENHB();
	}

	public virtual void CMMIADLEBFJ()
	{
		base.Start();
	}

	public virtual void FPILIKNFCKF()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.KnockBack)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			GHODNPLKJFB();
			float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1532f;
			num += 1009f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 903f;
			if (target.OnDamage(get_m_actor(), 695.0, num, 1662.0) >= 657f && (target.m_actorType == Actor.IJJMDPGJAEM.NotUsed || target.m_actorType == (Actor.IJJMDPGJAEM)6 || target.m_actorType == (Actor.IJJMDPGJAEM)3) && target.m_hero_id != 77 && target.m_hero_id != 30)
			{
				float hBNDHMPNCME = 1626f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 200f;
				target.get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.AhriSkill3, DGBKMAGBJJF.get_m_owner(), hBNDHMPNCME, 1060f, false);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM("[CCFFCC]<{0}>[-]{1}", false, 865f, 1920f);
		}
	}

	public virtual void IPFEBDCDMFA()
	{
		base.Start();
	}

	public virtual void BBKACBAMPHC()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Sleep)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			GHODNPLKJFB();
			float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 999f;
			num += 531f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 1147f;
			if (target.OnDamage(get_m_actor(), 1374.0, num, 1883.0, 0) >= 22f && (target.m_actorType == (Actor.IJJMDPGJAEM)6 || target.m_actorType == Actor.IJJMDPGJAEM.Hero || target.m_actorType == Actor.IJJMDPGJAEM.Hero) && target.m_hero_id != 29 && target.m_hero_id != -62)
			{
				float hBNDHMPNCME = 1754f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 220f;
				target.get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.FizzSkill1, DGBKMAGBJJF.get_m_owner(), hBNDHMPNCME, 1295f, false);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("click", true, 70f, 667f);
		}
	}

	public virtual void CLLECEEEJAI()
	{
		base.Start();
	}

	public virtual void FMNOLGPIIFB()
	{
		base.Start();
	}
}
