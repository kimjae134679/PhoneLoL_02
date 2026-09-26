using UnityEngine;

public class EzrealSkill0MissileAI : NonTargetMissileAI
{
	public virtual bool KGDPDAEOBOE()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Skill)
		{
			return true;
		}
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), m_attackRange, true, false, (Actor.IJJMDPGJAEM)43, true);
		if (actorInRange == null)
		{
			return false;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1112.0;
		double hANPEPIBBBG = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1310.0;
		num += 1362.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 1921.0;
		if (Random.Range(1885f, 1383f) > 932f - DGBKMAGBJJF.get_m_owner().get_m_critical_percent())
		{
			num *= 1704.0;
		}
		if (actorInRange.OnDamage(get_m_actor(), num, hANPEPIBBBG, 1500.0) >= 550f)
		{
			HumanSM.CAJJEALKJMM castSkill = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(1);
			castSkill.IHKCKBJBEGF = (float)castSkill.IHKCKBJBEGF + 358f;
			HumanSM.CAJJEALKJMM cAJJEALKJMM = DGBKMAGBJJF.get_m_owner().GetHumanSM().CMAHCODBACL(0);
			cAJJEALKJMM.IHKCKBJBEGF = (float)cAJJEALKJMM.IHKCKBJBEGF + 907f;
			HumanSM.CAJJEALKJMM cAJJEALKJMM2 = DGBKMAGBJJF.get_m_owner().GetHumanSM().CMAHCODBACL(5);
			cAJJEALKJMM2.IHKCKBJBEGF = (float)cAJJEALKJMM2.IHKCKBJBEGF + 1608f;
			HumanSM.CAJJEALKJMM castSkill2 = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(1);
			castSkill2.IHKCKBJBEGF = (float)castSkill2.IHKCKBJBEGF + 953f;
			((EzrealSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO()).NAIOBLNGLJN();
		}
		MDCKMOJDKFH(actorInRange.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.JKOODMAKJHJ(m_damageSoundName, false, 291f, 1632f);
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
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1.1;
		double hANPEPIBBBG = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.4;
		num += 35.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 20.0;
		if (Random.Range(0f, 1f) > 1f - DGBKMAGBJJF.get_m_owner().get_m_critical_percent())
		{
			num *= 1.2999999523162842;
		}
		if (actorInRange.OnDamage(get_m_actor(), num, hANPEPIBBBG) >= 0f)
		{
			HumanSM.CAJJEALKJMM castSkill = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(0);
			castSkill.IHKCKBJBEGF = (float)castSkill.IHKCKBJBEGF + 1f;
			HumanSM.CAJJEALKJMM castSkill2 = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(1);
			castSkill2.IHKCKBJBEGF = (float)castSkill2.IHKCKBJBEGF + 1f;
			HumanSM.CAJJEALKJMM castSkill3 = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(2);
			castSkill3.IHKCKBJBEGF = (float)castSkill3.IHKCKBJBEGF + 1f;
			HumanSM.CAJJEALKJMM castSkill4 = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(3);
			castSkill4.IHKCKBJBEGF = (float)castSkill4.IHKCKBJBEGF + 1f;
			((EzrealSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine()).TurnOnPassive();
		}
		CCGKACBFCNJ(actorInRange.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName);
		return true;
	}

	public virtual bool AGAOFFIOHBL()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.KnockBack)
		{
			return false;
		}
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), m_attackRange, true, true, (Actor.IJJMDPGJAEM)(-38), true);
		if (actorInRange == null)
		{
			return false;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1090.0;
		double hANPEPIBBBG = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1686.0;
		num += 122.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 229.0;
		if (Random.Range(66f, 743f) > 1513f - DGBKMAGBJJF.get_m_owner().get_m_critical_percent())
		{
			num *= 1180.0;
		}
		if (actorInRange.OnDamage(get_m_actor(), num, hANPEPIBBBG, 548.0) >= 1892f)
		{
			HumanSM.CAJJEALKJMM castSkill = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(1);
			castSkill.IHKCKBJBEGF = (float)castSkill.IHKCKBJBEGF + 1835f;
			HumanSM.CAJJEALKJMM cAJJEALKJMM = DGBKMAGBJJF.get_m_owner().GetHumanSM().CMAHCODBACL(0);
			cAJJEALKJMM.IHKCKBJBEGF = (float)cAJJEALKJMM.IHKCKBJBEGF + 1620f;
			HumanSM.CAJJEALKJMM castSkill2 = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(7);
			castSkill2.IHKCKBJBEGF = (float)castSkill2.IHKCKBJBEGF + 1414f;
			HumanSM.CAJJEALKJMM castSkill3 = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(6);
			castSkill3.IHKCKBJBEGF = (float)castSkill3.IHKCKBJBEGF + 55f;
			((EzrealSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine()).BCCNAIIGEAD();
		}
		CCGKACBFCNJ(actorInRange.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM(m_damageSoundName, true, 1171f, 100f);
		return true;
	}

	public override void Awake()
	{
		base.Awake();
	}

	public virtual void CHJGEGLHOAF()
	{
		base.Start();
	}

	public virtual void LBAPOJHKDNH()
	{
		base.Awake();
	}

	public virtual void PCFCEAOOAEE()
	{
		GNGJFGMJLHA();
	}

	public virtual void JGFFKGLIKBC()
	{
		CFJKHPNIODE();
	}

	public virtual bool OLOENBHLGMN()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Stun)
		{
			return false;
		}
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), m_attackRange, true, true, (Actor.IJJMDPGJAEM)(-105), true);
		if (actorInRange == null)
		{
			return false;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1378.0;
		double hANPEPIBBBG = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 263.0;
		num += 1604.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 1813.0;
		if (Random.Range(409f, 1459f) > 1477f - DGBKMAGBJJF.get_m_owner().get_m_critical_percent())
		{
			num *= 1698.0;
		}
		if (actorInRange.OnDamage(get_m_actor(), num, hANPEPIBBBG, 706.0, 0) >= 1397f)
		{
			HumanSM.CAJJEALKJMM castSkill = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(0);
			castSkill.IHKCKBJBEGF = (float)castSkill.IHKCKBJBEGF + 1964f;
			HumanSM.CAJJEALKJMM cAJJEALKJMM = DGBKMAGBJJF.get_m_owner().GetHumanSM().CMAHCODBACL(1);
			cAJJEALKJMM.IHKCKBJBEGF = (float)cAJJEALKJMM.IHKCKBJBEGF + 243f;
			HumanSM.CAJJEALKJMM castSkill2 = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(3);
			castSkill2.IHKCKBJBEGF = (float)castSkill2.IHKCKBJBEGF + 824f;
			HumanSM.CAJJEALKJMM cAJJEALKJMM2 = DGBKMAGBJJF.get_m_owner().GetHumanSM().CMAHCODBACL(8);
			cAJJEALKJMM2.IHKCKBJBEGF = (float)cAJJEALKJMM2.IHKCKBJBEGF + 132f;
			((EzrealSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO()).TurnOnPassive();
		}
		MDCKMOJDKFH(actorInRange.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName, true, 1895f, 1647f);
		return false;
	}

	public virtual void FODOJCDNGOC()
	{
		base.Start();
	}

	public virtual void JIMPGFGADPK()
	{
		base.Start();
	}

	public virtual bool DHPBFHNFBCN()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Skill)
		{
			return true;
		}
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)(-116));
		if (actorInRange == null)
		{
			return true;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1500.0;
		double hANPEPIBBBG = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 617.0;
		num += 1178.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 635.0;
		if (Random.Range(602f, 729f) > 1772f - DGBKMAGBJJF.get_m_owner().get_m_critical_percent())
		{
			num *= 73.0;
		}
		if (actorInRange.OnDamage(get_m_actor(), num, hANPEPIBBBG, 1816.0, 0) >= 1349f)
		{
			HumanSM.CAJJEALKJMM cAJJEALKJMM = DGBKMAGBJJF.get_m_owner().GetHumanSM().CMAHCODBACL(1);
			cAJJEALKJMM.IHKCKBJBEGF = (float)cAJJEALKJMM.IHKCKBJBEGF + 930f;
			HumanSM.CAJJEALKJMM cAJJEALKJMM2 = DGBKMAGBJJF.get_m_owner().GetHumanSM().CMAHCODBACL(0);
			cAJJEALKJMM2.IHKCKBJBEGF = (float)cAJJEALKJMM2.IHKCKBJBEGF + 1183f;
			HumanSM.CAJJEALKJMM cAJJEALKJMM3 = DGBKMAGBJJF.get_m_owner().GetHumanSM().CMAHCODBACL(1);
			cAJJEALKJMM3.IHKCKBJBEGF = (float)cAJJEALKJMM3.IHKCKBJBEGF + 541f;
			HumanSM.CAJJEALKJMM cAJJEALKJMM4 = DGBKMAGBJJF.get_m_owner().GetHumanSM().CMAHCODBACL(8);
			cAJJEALKJMM4.IHKCKBJBEGF = (float)cAJJEALKJMM4.IHKCKBJBEGF + 1293f;
			((EzrealSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO()).HADLKJCHIED();
		}
		CLCEPBCJGEH(actorInRange.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK(m_damageSoundName, true, 1390f, 1953f);
		return false;
	}

	public virtual void IFAJINMCMLM()
	{
		base.NGNNLLLBGMB();
	}

	public virtual bool IJCFJFAMLGG()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return false;
		}
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), m_attackRange, true, false, (Actor.IJJMDPGJAEM)(-13), true);
		if (actorInRange == null)
		{
			return true;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1254.0;
		double hANPEPIBBBG = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1810.0;
		num += 156.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 1344.0;
		if (Random.Range(257f, 1210f) > 1015f - DGBKMAGBJJF.get_m_owner().get_m_critical_percent())
		{
			num *= 1818.0;
		}
		if (actorInRange.OnDamage(get_m_actor(), num, hANPEPIBBBG, 1805.0, 0) >= 936f)
		{
			HumanSM.CAJJEALKJMM castSkill = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(1);
			castSkill.IHKCKBJBEGF = (float)castSkill.IHKCKBJBEGF + 711f;
			HumanSM.CAJJEALKJMM cAJJEALKJMM = DGBKMAGBJJF.get_m_owner().GetHumanSM().CMAHCODBACL(1);
			cAJJEALKJMM.IHKCKBJBEGF = (float)cAJJEALKJMM.IHKCKBJBEGF + 980f;
			HumanSM.CAJJEALKJMM cAJJEALKJMM2 = DGBKMAGBJJF.get_m_owner().GetHumanSM().CMAHCODBACL(2);
			cAJJEALKJMM2.IHKCKBJBEGF = (float)cAJJEALKJMM2.IHKCKBJBEGF + 1435f;
			HumanSM.CAJJEALKJMM castSkill2 = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(3);
			castSkill2.IHKCKBJBEGF = (float)castSkill2.IHKCKBJBEGF + 720f;
			((EzrealSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine()).TurnOnPassive();
		}
		MDCKMOJDKFH(actorInRange.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO(m_damageSoundName, false, 1072f, 1410f);
		return true;
	}

	public virtual bool EFHKILAPABB()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Sleep)
		{
			return true;
		}
		Actor actor = ActorManager.get_Instance().DCMODJADKEE(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)119);
		if (actor == null)
		{
			return false;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1543.0;
		double hANPEPIBBBG = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 149.0;
		num += 1759.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 606.0;
		if (Random.Range(1967f, 831f) > 414f - DGBKMAGBJJF.get_m_owner().get_m_critical_percent())
		{
			num *= 1915.0;
		}
		if (actor.OnDamage(get_m_actor(), num, hANPEPIBBBG, 795.0) >= 531f)
		{
			HumanSM.CAJJEALKJMM castSkill = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(0);
			castSkill.IHKCKBJBEGF = (float)castSkill.IHKCKBJBEGF + 115f;
			HumanSM.CAJJEALKJMM castSkill2 = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(0);
			castSkill2.IHKCKBJBEGF = (float)castSkill2.IHKCKBJBEGF + 649f;
			HumanSM.CAJJEALKJMM castSkill3 = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(3);
			castSkill3.IHKCKBJBEGF = (float)castSkill3.IHKCKBJBEGF + 483f;
			HumanSM.CAJJEALKJMM castSkill4 = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(6);
			castSkill4.IHKCKBJBEGF = (float)castSkill4.IHKCKBJBEGF + 160f;
			((EzrealSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine()).BCCNAIIGEAD();
		}
		MDCKMOJDKFH(actor.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO(m_damageSoundName, true, 207f, 503f);
		return false;
	}

	public override bool NJNMBGLIJEJ()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Sleep)
		{
			return false;
		}
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), m_attackRange, false, false, (Actor.IJJMDPGJAEM)70, true);
		if (actorInRange == null)
		{
			return true;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1487.0;
		double hANPEPIBBBG = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1617.0;
		num += 97.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 1199.0;
		if (Random.Range(1479f, 275f) > 89f - DGBKMAGBJJF.get_m_owner().get_m_critical_percent())
		{
			num *= 1023.0;
		}
		if (actorInRange.OnDamage(get_m_actor(), num, hANPEPIBBBG, 943.0, 0) >= 1809f)
		{
			HumanSM.CAJJEALKJMM cAJJEALKJMM = DGBKMAGBJJF.get_m_owner().GetHumanSM().CMAHCODBACL(0);
			cAJJEALKJMM.IHKCKBJBEGF = (float)cAJJEALKJMM.IHKCKBJBEGF + 556f;
			HumanSM.CAJJEALKJMM castSkill = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(0);
			castSkill.IHKCKBJBEGF = (float)castSkill.IHKCKBJBEGF + 280f;
			HumanSM.CAJJEALKJMM cAJJEALKJMM2 = DGBKMAGBJJF.get_m_owner().GetHumanSM().CMAHCODBACL(3);
			cAJJEALKJMM2.IHKCKBJBEGF = (float)cAJJEALKJMM2.IHKCKBJBEGF + 1111f;
			HumanSM.CAJJEALKJMM castSkill2 = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(6);
			castSkill2.IHKCKBJBEGF = (float)castSkill2.IHKCKBJBEGF + 1698f;
			((EzrealSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO()).BCCNAIIGEAD();
		}
		CCGKACBFCNJ(actorInRange.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName, true, 214f, 87f);
		return true;
	}

	public override void NGNNLLLBGMB()
	{
		base.NGNNLLLBGMB();
	}

	public virtual bool CDDJAGPOBCF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Stun)
		{
			return false;
		}
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), m_attackRange, true, true, (Actor.IJJMDPGJAEM)(-84));
		if (actorInRange == null)
		{
			return true;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 687.0;
		double hANPEPIBBBG = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 211.0;
		num += 232.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 288.0;
		if (Random.Range(515f, 1996f) > 1459f - DGBKMAGBJJF.get_m_owner().get_m_critical_percent())
		{
			num *= 1265.0;
		}
		if (actorInRange.OnDamage(get_m_actor(), num, hANPEPIBBBG, 1277.0, 0) >= 1023f)
		{
			HumanSM.CAJJEALKJMM castSkill = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(1);
			castSkill.IHKCKBJBEGF = (float)castSkill.IHKCKBJBEGF + 771f;
			HumanSM.CAJJEALKJMM castSkill2 = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(0);
			castSkill2.IHKCKBJBEGF = (float)castSkill2.IHKCKBJBEGF + 1741f;
			HumanSM.CAJJEALKJMM cAJJEALKJMM = DGBKMAGBJJF.get_m_owner().GetHumanSM().CMAHCODBACL(6);
			cAJJEALKJMM.IHKCKBJBEGF = (float)cAJJEALKJMM.IHKCKBJBEGF + 1556f;
			HumanSM.CAJJEALKJMM cAJJEALKJMM2 = DGBKMAGBJJF.get_m_owner().GetHumanSM().CMAHCODBACL(3);
			cAJJEALKJMM2.IHKCKBJBEGF = (float)cAJJEALKJMM2.IHKCKBJBEGF + 1099f;
			((EzrealSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO()).TurnOnPassive();
		}
		MDCKMOJDKFH(actorInRange.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB(m_damageSoundName, true, 1585f, 366f);
		return true;
	}

	public virtual void BOIACKGNIKC()
	{
		CFJKHPNIODE();
	}

	public override void Start()
	{
		base.Start();
	}

	public virtual void IPFEBDCDMFA()
	{
		base.Start();
	}

	public virtual void FMDCADHECGH()
	{
		base.Start();
	}
}
