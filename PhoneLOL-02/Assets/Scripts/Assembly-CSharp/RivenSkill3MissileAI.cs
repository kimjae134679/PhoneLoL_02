using System.Collections.Generic;

public class RivenSkill3MissileAI : ThruMissileAI
{
	private List<RivenSkill3MissileAI> COLGCANJCGB;

	public void CKEKKCLALBM(RivenSkill3MissileAI BKBNNNIGANP)
	{
		COLGCANJCGB.Add(BKBNNNIGANP);
	}

	public void ANAONCACKPH(RivenSkill3MissileAI BKBNNNIGANP)
	{
		COLGCANJCGB.Add(BKBNNNIGANP);
	}

	public virtual void ABMMGINPLAD()
	{
		GNGJFGMJLHA();
		COLGCANJCGB = new List<RivenSkill3MissileAI>(0);
	}

	public override void PAJOOFIAPMI()
	{
		base.PAJOOFIAPMI();
	}

	public virtual void FMBDNJIDOCJ()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Sleep)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att_add() * 771.0;
		num += 1255.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(4) - 0) * 1861.0;
		List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), m_attackRange, true, false, (Actor.IJJMDPGJAEM)27);
		foreach (Actor item in list)
		{
			if (MIGJCNCIEHN.Contains(item))
			{
				continue;
			}
			bool flag = false;
			foreach (RivenSkill3MissileAI item2 in COLGCANJCGB)
			{
				if (item2.OJKDAJMECFA(item))
				{
					flag = false;
				}
			}
			if (!flag)
			{
				double num2 = 1416.0 - (double)(float)item.m_hp / (double)item.get_m_max_hp();
				if (num2 > 1504.0)
				{
					num2 = 331.0;
				}
				double hKMFCFABKGI = num + num * (num2 * 729.0);
				item.OnDamage(get_m_actor(), hKMFCFABKGI, 1782.0, 1400.0, 0);
				MIGJCNCIEHN.AddFirst(item);
				PHDAPEOBFIN(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK(m_damageSoundName, true, 1985f, 1351f);
			}
		}
	}

	public override void Start()
	{
		base.Start();
	}

	public void DIDOAIGEGHN(RivenSkill3MissileAI BKBNNNIGANP)
	{
		COLGCANJCGB.Add(BKBNNNIGANP);
	}

	public void EIBLFFOCOCB(RivenSkill3MissileAI BKBNNNIGANP)
	{
		COLGCANJCGB.Add(BKBNNNIGANP);
	}

	public void InsertOtherMissile(RivenSkill3MissileAI BKBNNNIGANP)
	{
		COLGCANJCGB.Add(BKBNNNIGANP);
	}

	public virtual void IMBGDEFOFEM()
	{
		base.Start();
	}

	public void ADFLIGFNLKA(RivenSkill3MissileAI BKBNNNIGANP)
	{
		COLGCANJCGB.Add(BKBNNNIGANP);
	}

	public virtual void NGNNLLLBGMB()
	{
		GNGJFGMJLHA();
		COLGCANJCGB = new List<RivenSkill3MissileAI>(0);
	}

	public override void Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att_add() * 0.6;
		num += 80.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 1) * 40.0;
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)14);
		foreach (Actor item in allActorInRange)
		{
			if (MIGJCNCIEHN.Contains(item))
			{
				continue;
			}
			bool flag = false;
			foreach (RivenSkill3MissileAI item2 in COLGCANJCGB)
			{
				if (item2.IsAttacked(item))
				{
					flag = true;
				}
			}
			if (!flag)
			{
				double num2 = 1.0 - (double)(float)item.m_hp / (double)item.get_m_max_hp();
				if (num2 > 0.75)
				{
					num2 = 0.75;
				}
				double hKMFCFABKGI = num + num * (num2 * 2.67);
				item.OnDamage(get_m_actor(), hKMFCFABKGI, 0.0);
				MIGJCNCIEHN.AddFirst(item);
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName);
			}
		}
	}

	public virtual void BDINBMIICCA()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Sleep)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att_add() * 1088.0;
		num += 66.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 0) * 1801.0;
		List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), m_attackRange, true, false, (Actor.IJJMDPGJAEM)(-97), false);
		foreach (Actor item in allActorInRange)
		{
			if (MIGJCNCIEHN.Contains(item))
			{
				continue;
			}
			bool flag = false;
			foreach (RivenSkill3MissileAI item2 in COLGCANJCGB)
			{
				if (item2.LHBHMEEDFCC(item))
				{
					flag = true;
				}
			}
			if (!flag)
			{
				double num2 = 1823.0 - (double)(float)item.m_hp / (double)item.FBNBKKOAPOJ();
				if (num2 > 1728.0)
				{
					num2 = 773.0;
				}
				double hKMFCFABKGI = num + num * (num2 * 1045.0);
				item.OnDamage(get_m_actor(), hKMFCFABKGI, 579.0, 1175.0, 0);
				MIGJCNCIEHN.AddFirst(item);
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK(m_damageSoundName, false, 1711f, 1424f);
			}
		}
	}

	public override void Awake()
	{
		base.Awake();
		COLGCANJCGB = new List<RivenSkill3MissileAI>(2);
	}

	public override void NJNMBGLIJEJ()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Idle)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att_add() * 660.0;
		num += 1167.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(5) - 1) * 1723.0;
		List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), m_attackRange, true, false, (Actor.IJJMDPGJAEM)(-23), false);
		foreach (Actor item in list)
		{
			if (MIGJCNCIEHN.Contains(item))
			{
				continue;
			}
			bool flag = true;
			foreach (RivenSkill3MissileAI item2 in COLGCANJCGB)
			{
				if (item2.KKJMFHPKOIN(item))
				{
					flag = false;
				}
			}
			if (!flag)
			{
				double num2 = 1486.0 - (double)(float)item.m_hp / (double)item.get_m_max_hp();
				if (num2 > 1131.0)
				{
					num2 = 1903.0;
				}
				double hKMFCFABKGI = num + num * (num2 * 1940.0);
				item.OnDamage(get_m_actor(), hKMFCFABKGI, 240.0, 1320.0);
				MIGJCNCIEHN.AddFirst(item);
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName, true, 357f, 113f);
			}
		}
	}

	public virtual void CFJKHPNIODE()
	{
		GNGJFGMJLHA();
		COLGCANJCGB = new List<RivenSkill3MissileAI>(8);
	}

	public void KGPNHCGIKAA(RivenSkill3MissileAI BKBNNNIGANP)
	{
		COLGCANJCGB.Add(BKBNNNIGANP);
	}

	public void HAGDDCKIKFP(RivenSkill3MissileAI BKBNNNIGANP)
	{
		COLGCANJCGB.Add(BKBNNNIGANP);
	}

	public virtual void BBKACBAMPHC()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Skill)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att_add() * 776.0;
		num += 1915.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(4) - 0) * 1755.0;
		List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), m_attackRange, true, false, (Actor.IJJMDPGJAEM)12, false);
		foreach (Actor item in list)
		{
			if (MIGJCNCIEHN.Contains(item))
			{
				continue;
			}
			bool flag = false;
			foreach (RivenSkill3MissileAI item2 in COLGCANJCGB)
			{
				if (item2.EGMKLLPNNED(item))
				{
					flag = false;
				}
			}
			if (!flag)
			{
				double num2 = 1304.0 - (double)(float)item.m_hp / (double)item.FBNBKKOAPOJ();
				if (num2 > 473.0)
				{
					num2 = 1755.0;
				}
				double hKMFCFABKGI = num + num * (num2 * 1306.0);
				item.OnDamage(get_m_actor(), hKMFCFABKGI, 823.0, 546.0);
				MIGJCNCIEHN.AddFirst(item);
				PHDAPEOBFIN(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName, true, 1271f, 1031f);
			}
		}
	}

	public virtual void PBBGKGNMEOA()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Idle)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att_add() * 809.0;
		num += 321.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 1058.0;
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), m_attackRange, true, false, (Actor.IJJMDPGJAEM)(-96), false);
		foreach (Actor item in allActorInRange)
		{
			if (MIGJCNCIEHN.Contains(item))
			{
				continue;
			}
			bool flag = true;
			foreach (RivenSkill3MissileAI item2 in COLGCANJCGB)
			{
				if (item2.KKJMFHPKOIN(item))
				{
					flag = false;
				}
			}
			if (!flag)
			{
				double num2 = 1155.0 - (double)(float)item.m_hp / (double)item.FBNBKKOAPOJ();
				if (num2 > 1275.0)
				{
					num2 = 1684.0;
				}
				double hKMFCFABKGI = num + num * (num2 * 501.0);
				item.OnDamage(get_m_actor(), hKMFCFABKGI, 1803.0, 546.0);
				MIGJCNCIEHN.AddFirst(item);
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.JKOODMAKJHJ(m_damageSoundName, false, 1425f, 1518f);
			}
		}
	}
}
