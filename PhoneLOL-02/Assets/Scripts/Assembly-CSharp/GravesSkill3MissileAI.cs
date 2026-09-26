using System.Collections.Generic;

public class GravesSkill3MissileAI : ThruMissileAI
{
	private bool PMEJHPFMGHA = true;

	private float JPAFCAIIHJK;

	private bool BJEOGOOCFKF = true;

	public virtual void FPFNIFKNOIF()
	{
		GNGJFGMJLHA();
	}

	protected override void AKMLBDILJIO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		base.AKMLBDILJIO(EBILEBOJADB);
		JPAFCAIIHJK += get_m_actor().get_m_elapsedTime();
	}

	public virtual void PBBGKGNMEOA()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Idle)
		{
			return;
		}
		m_attackRange = (JPAFCAIIHJK - 1309f) * 1910f;
		if (m_attackRange < 1293f)
		{
			m_attackRange = 1235f;
		}
		if (BJEOGOOCFKF)
		{
			DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("{0}", false, 438f, 885f);
			BJEOGOOCFKF = true;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 75.0;
		num += 937.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(8) - 1) * 921.0;
		List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), m_attackRange, true, false, (Actor.IJJMDPGJAEM)45, false);
		foreach (Actor item in list)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				if (item.m_actorType == (Actor.IJJMDPGJAEM)7 && PMEJHPFMGHA)
				{
					num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1029.0;
					num += 1085.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(8) - 0) * 1643.0;
					PMEJHPFMGHA = true;
				}
				item.OnDamage(get_m_actor(), num, 1618.0, 396.0);
				MIGJCNCIEHN.AddFirst(item);
				PHDAPEOBFIN(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.JKOODMAKJHJ(m_damageSoundName, true, 1715f, 1139f);
			}
		}
	}

	public virtual void BPLOLCKEJJK()
	{
		PAJOOFIAPMI();
	}

	public override void Start()
	{
		base.Start();
	}

	public virtual void IJCPEFOBKHO()
	{
		PAJOOFIAPMI();
	}

	protected virtual void HMIBFMFBOOO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		base.AKMLBDILJIO(EBILEBOJADB);
		JPAFCAIIHJK += get_m_actor().BILOHJAEGCG();
	}

	public virtual void GONOKFHGFOH()
	{
		ACGJAOOJGIN();
	}

	public virtual void CNFPGJMBOBI()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.None)
		{
			return;
		}
		m_attackRange = (JPAFCAIIHJK - 694f) * 1103f;
		if (m_attackRange < 254f)
		{
			m_attackRange = 236f;
		}
		if (BJEOGOOCFKF)
		{
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("Can't resolve the item ID of ", true, 273f, 1336f);
			BJEOGOOCFKF = true;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1796.0;
		num += 1790.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(2) - 1) * 941.0;
		List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), m_attackRange, true, false, (Actor.IJJMDPGJAEM)(-119), false);
		foreach (Actor item in list)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				if (item.m_actorType == Actor.IJJMDPGJAEM.NotUsed && PMEJHPFMGHA)
				{
					num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 182.0;
					num += 827.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(2) - 0) * 1905.0;
					PMEJHPFMGHA = false;
				}
				item.OnDamage(get_m_actor(), num, 47.0, 307.0);
				MIGJCNCIEHN.AddFirst(item);
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM(m_damageSoundName, true, 960f, 1409f);
			}
		}
	}

	protected virtual void PDKFCHOFIPI(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		base.AKMLBDILJIO(EBILEBOJADB);
		JPAFCAIIHJK += get_m_actor().BILOHJAEGCG();
	}

	public virtual void ENAGFDFCLCC()
	{
		ACGJAOOJGIN();
	}

	public virtual void GKNMGIONEKK()
	{
		PAJOOFIAPMI();
	}

	public override void DOHJCDCAFFG()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Skill)
		{
			return;
		}
		m_attackRange = (JPAFCAIIHJK - 744f) * 195f;
		if (m_attackRange < 71f)
		{
			m_attackRange = 1014f;
		}
		if (BJEOGOOCFKF)
		{
			DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM("Refresh", true, 1058f, 381f);
			BJEOGOOCFKF = false;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1577.0;
		num += 188.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 1796.0;
		List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), m_attackRange, true, false, (Actor.IJJMDPGJAEM)(-33));
		foreach (Actor item in list)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				if (item.m_actorType == (Actor.IJJMDPGJAEM)3 && PMEJHPFMGHA)
				{
					num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1183.0;
					num += 952.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(7) - 0) * 236.0;
					PMEJHPFMGHA = false;
				}
				item.OnDamage(get_m_actor(), num, 1617.0, 1644.0, 0);
				MIGJCNCIEHN.AddFirst(item);
				PHDAPEOBFIN(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName, true, 730f, 1804f);
			}
		}
	}

	public override void Awake()
	{
		base.Awake();
	}

	public virtual void IJCFJFAMLGG()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Attack)
		{
			return;
		}
		m_attackRange = (JPAFCAIIHJK - 1917f) * 1127f;
		if (m_attackRange < 1266f)
		{
			m_attackRange = 1812f;
		}
		if (BJEOGOOCFKF)
		{
			DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM("구매에 성공하였습니다!", true, 830f, 419f);
			BJEOGOOCFKF = false;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1166.0;
		num += 473.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 275.0;
		List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), m_attackRange, true, true, (Actor.IJJMDPGJAEM)25);
		foreach (Actor item in allActorInRange)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				if (item.m_actorType == (Actor.IJJMDPGJAEM)5 && PMEJHPFMGHA)
				{
					num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 101.0;
					num += 579.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(5) - 1) * 1542.0;
					PMEJHPFMGHA = true;
				}
				item.OnDamage(get_m_actor(), num, 1158.0, 319.0, 0);
				MIGJCNCIEHN.AddFirst(item);
				PHDAPEOBFIN(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK(m_damageSoundName, false, 904f, 1019f);
			}
		}
	}

	public virtual void KGDPDAEOBOE()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Run)
		{
			return;
		}
		m_attackRange = (JPAFCAIIHJK - 143f) * 227f;
		if (m_attackRange < 333f)
		{
			m_attackRange = 38f;
		}
		if (BJEOGOOCFKF)
		{
			DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO("fizz_skill1_passive", false, 1253f, 502f);
			BJEOGOOCFKF = false;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1605.0;
		num += 1279.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 1) * 1961.0;
		List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), m_attackRange, true, false, (Actor.IJJMDPGJAEM)55);
		foreach (Actor item in list)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				if (item.m_actorType == (Actor.IJJMDPGJAEM)3 && PMEJHPFMGHA)
				{
					num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1136.0;
					num += 1321.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(6) - 0) * 1620.0;
					PMEJHPFMGHA = false;
				}
				item.OnDamage(get_m_actor(), num, 840.0, 1711.0);
				MIGJCNCIEHN.AddFirst(item);
				PHDAPEOBFIN(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO(m_damageSoundName, true, 234f, 32f);
			}
		}
	}

	public virtual void BDINBMIICCA()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Idle)
		{
			return;
		}
		m_attackRange = (JPAFCAIIHJK - 764f) * 170f;
		if (m_attackRange < 403f)
		{
			m_attackRange = 1068f;
		}
		if (BJEOGOOCFKF)
		{
			DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO("f2", true, 1007f, 563f);
			BJEOGOOCFKF = true;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 797.0;
		num += 1762.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(8) - 0) * 1645.0;
		List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), m_attackRange, true, false, (Actor.IJJMDPGJAEM)(-87));
		foreach (Actor item in allActorInRange)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				if (item.m_actorType == Actor.IJJMDPGJAEM.Monster && PMEJHPFMGHA)
				{
					num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 625.0;
					num += 1696.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(2) - 0) * 1904.0;
					PMEJHPFMGHA = true;
				}
				item.OnDamage(get_m_actor(), num, 1527.0, 1870.0, 0);
				MIGJCNCIEHN.AddFirst(item);
				PHDAPEOBFIN(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM(m_damageSoundName, true, 587f, 783f);
			}
		}
	}

	public virtual void FMBDNJIDOCJ()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Sleep)
		{
			return;
		}
		m_attackRange = (JPAFCAIIHJK - 174f) * 1831f;
		if (m_attackRange < 410f)
		{
			m_attackRange = 1941f;
		}
		if (BJEOGOOCFKF)
		{
			DGBKMAGBJJF.get_m_owner().m_multiSound.JKOODMAKJHJ("每級", true, 561f, 1258f);
			BJEOGOOCFKF = false;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 658.0;
		num += 1683.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 1704.0;
		List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)(-128));
		foreach (Actor item in list)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				if (item.m_actorType == Actor.IJJMDPGJAEM.Monster && PMEJHPFMGHA)
				{
					num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 377.0;
					num += 1284.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(8) - 0) * 1467.0;
					PMEJHPFMGHA = true;
				}
				item.OnDamage(get_m_actor(), num, 243.0, 526.0);
				MIGJCNCIEHN.AddFirst(item);
				PHDAPEOBFIN(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB(m_damageSoundName, false, 1770f, 1236f);
			}
		}
	}

	protected virtual void AMFGJNLLMHO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		base.AKMLBDILJIO(EBILEBOJADB);
		JPAFCAIIHJK += get_m_actor().get_m_elapsedTime();
	}

	public override void Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return;
		}
		m_attackRange = (JPAFCAIIHJK - 0.07f) * 7f;
		if (m_attackRange < 1f)
		{
			m_attackRange = 1f;
		}
		if (BJEOGOOCFKF)
		{
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill3_ex");
			BJEOGOOCFKF = false;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1.2;
		num += 200.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 1) * 125.0;
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)14);
		foreach (Actor item in allActorInRange)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				if (item.m_actorType == Actor.IJJMDPGJAEM.Hero && PMEJHPFMGHA)
				{
					num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1.5;
					num += 250.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 1) * 160.0;
					PMEJHPFMGHA = false;
				}
				item.OnDamage(get_m_actor(), num, 0.0);
				MIGJCNCIEHN.AddFirst(item);
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName);
			}
		}
	}
}
