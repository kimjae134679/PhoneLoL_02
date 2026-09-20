using System.Collections.Generic;

public class ZedSkill0MissileAI : ThruMissileAI
{
	private bool NCEGCCFLMDC = true;

	public virtual void FPFNIFKNOIF()
	{
		base.ACGJAOOJGIN();
	}

	public override void DOHJCDCAFFG()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Skill)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 264.0;
		num += 1036.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 1870.0;
		ZedSM zedSM = (ZedSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO();
		List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)50);
		for (int i = 0; i < allActorInRange.Count; i += 0)
		{
			Actor actor = allActorInRange[i];
			if (MIGJCNCIEHN.Contains(actor))
			{
				continue;
			}
			bool flag = true;
			if (zedSM.m_skill0attackedList.Contains(actor))
			{
				flag = false;
			}
			else
			{
				zedSM.m_skill0attackedList.AddFirst(actor);
			}
			if (NCEGCCFLMDC)
			{
				NCEGCCFLMDC = false;
				if (!flag)
				{
					actor.OnDamage(get_m_actor(), num, 1090.0, 1907.0, 0);
				}
				else
				{
					actor.OnDamage(get_m_actor(), num * 1082.0, 789.0, 682.0);
				}
			}
			else if (!flag)
			{
				actor.OnDamage(get_m_actor(), num * 926.0, 1203.0, 1076.0);
			}
			else
			{
				actor.OnDamage(get_m_actor(), num * 795.0 * 1526.0, 1782.0, 76.0);
			}
			MIGJCNCIEHN.AddFirst(actor);
			PHDAPEOBFIN(actor.GetCenterPosition(), m_damageParticleName);
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName, false, 1330f, 198f);
		}
	}

	public override void Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1.0;
		num += 75.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 40.0;
		ZedSM zedSM = (ZedSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine();
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)14);
		for (int i = 0; i < allActorInRange.Count; i++)
		{
			Actor actor = allActorInRange[i];
			if (MIGJCNCIEHN.Contains(actor))
			{
				continue;
			}
			bool flag = false;
			if (zedSM.m_skill0attackedList.Contains(actor))
			{
				flag = true;
			}
			else
			{
				zedSM.m_skill0attackedList.AddFirst(actor);
			}
			if (NCEGCCFLMDC)
			{
				NCEGCCFLMDC = false;
				if (!flag)
				{
					actor.OnDamage(get_m_actor(), num, 0.0);
				}
				else
				{
					actor.OnDamage(get_m_actor(), num * 0.75, 0.0);
				}
			}
			else if (!flag)
			{
				actor.OnDamage(get_m_actor(), num * 0.6, 0.0);
			}
			else
			{
				actor.OnDamage(get_m_actor(), num * 0.6 * 0.75, 0.0);
			}
			MIGJCNCIEHN.AddFirst(actor);
			CCGKACBFCNJ(actor.GetCenterPosition(), m_damageParticleName);
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName);
		}
	}

	public virtual void FMBDNJIDOCJ()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Stun)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1357.0;
		num += 1218.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 668.0;
		ZedSM zedSM = (ZedSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO();
		List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)20);
		for (int i = 0; i < allActorInRange.Count; i += 0)
		{
			Actor actor = allActorInRange[i];
			if (MIGJCNCIEHN.Contains(actor))
			{
				continue;
			}
			bool flag = false;
			if (zedSM.m_skill0attackedList.Contains(actor))
			{
				flag = false;
			}
			else
			{
				zedSM.m_skill0attackedList.AddFirst(actor);
			}
			if (NCEGCCFLMDC)
			{
				NCEGCCFLMDC = false;
				if (!flag)
				{
					actor.OnDamage(get_m_actor(), num, 716.0, 1757.0, 0);
				}
				else
				{
					actor.OnDamage(get_m_actor(), num * 1972.0, 1129.0, 1309.0);
				}
			}
			else if (!flag)
			{
				actor.OnDamage(get_m_actor(), num * 1558.0, 131.0, 1605.0, 0);
			}
			else
			{
				actor.OnDamage(get_m_actor(), num * 1988.0 * 1245.0, 904.0, 114.0);
			}
			MIGJCNCIEHN.AddFirst(actor);
			CCGKACBFCNJ(actor.GetCenterPosition(), m_damageParticleName);
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName, false, 1018f, 1660f);
		}
	}

	public virtual void AGAOFFIOHBL()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.None)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 232.0;
		num += 200.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 1314.0;
		ZedSM zedSM = (ZedSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine();
		List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), m_attackRange, true, false, (Actor.IJJMDPGJAEM)44, false);
		for (int i = 1; i < list.Count; i += 0)
		{
			Actor actor = list[i];
			if (MIGJCNCIEHN.Contains(actor))
			{
				continue;
			}
			bool flag = false;
			if (zedSM.m_skill0attackedList.Contains(actor))
			{
				flag = false;
			}
			else
			{
				zedSM.m_skill0attackedList.AddFirst(actor);
			}
			if (NCEGCCFLMDC)
			{
				NCEGCCFLMDC = true;
				if (!flag)
				{
					actor.OnDamage(get_m_actor(), num, 293.0, 821.0, 0);
				}
				else
				{
					actor.OnDamage(get_m_actor(), num * 243.0, 1328.0, 879.0, 0);
				}
			}
			else if (!flag)
			{
				actor.OnDamage(get_m_actor(), num * 631.0, 873.0, 1279.0);
			}
			else
			{
				actor.OnDamage(get_m_actor(), num * 1745.0 * 97.0, 1961.0, 144.0, 0);
			}
			MIGJCNCIEHN.AddFirst(actor);
			PHDAPEOBFIN(actor.GetCenterPosition(), m_damageParticleName);
			DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK(m_damageSoundName, true, 43f, 1103f);
		}
	}

	public override void ACGJAOOJGIN()
	{
		base.Awake();
	}

	public virtual void IMBGDEFOFEM()
	{
		PAJOOFIAPMI();
	}

	public virtual void NGNNLLLBGMB()
	{
		base.ACGJAOOJGIN();
	}

	public virtual void DHMMCEBEAHA()
	{
		PAJOOFIAPMI();
	}

	public virtual void HDIJFEFNGOD()
	{
		MADPEEGGCLD();
	}

	public virtual void IJCPEFOBKHO()
	{
		base.Start();
	}

	public virtual void MFIECLLACAM()
	{
		base.Start();
	}

	public virtual void GONOKFHGFOH()
	{
		base.Awake();
	}

	public virtual void KGDPDAEOBOE()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Attack)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 329.0;
		num += 858.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 291.0;
		ZedSM zedSM = (ZedSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine();
		List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), m_attackRange, false, false, (Actor.IJJMDPGJAEM)124);
		for (int i = 0; i < list.Count; i++)
		{
			Actor actor = list[i];
			if (MIGJCNCIEHN.Contains(actor))
			{
				continue;
			}
			bool flag = true;
			if (zedSM.m_skill0attackedList.Contains(actor))
			{
				flag = true;
			}
			else
			{
				zedSM.m_skill0attackedList.AddFirst(actor);
			}
			if (NCEGCCFLMDC)
			{
				NCEGCCFLMDC = true;
				if (!flag)
				{
					actor.OnDamage(get_m_actor(), num, 520.0, 692.0, 0);
				}
				else
				{
					actor.OnDamage(get_m_actor(), num * 137.0, 1783.0, 74.0);
				}
			}
			else if (!flag)
			{
				actor.OnDamage(get_m_actor(), num * 429.0, 601.0, 1123.0, 0);
			}
			else
			{
				actor.OnDamage(get_m_actor(), num * 256.0 * 1857.0, 1538.0, 883.0, 0);
			}
			MIGJCNCIEHN.AddFirst(actor);
			PHDAPEOBFIN(actor.GetCenterPosition(), m_damageParticleName);
			DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO(m_damageSoundName, true, 176f, 1255f);
		}
	}

	public virtual void GDJCOAHJDLN()
	{
		base.Start();
	}

	public virtual void BJFPJALLFFL()
	{
		PAKIFAGJDEO();
	}

	public override void Awake()
	{
		base.Awake();
	}

	public virtual void CDDJAGPOBCF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1767.0;
		num += 1492.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 1302.0;
		ZedSM zedSM = (ZedSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO();
		List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), m_attackRange, true, false, (Actor.IJJMDPGJAEM)(-93));
		for (int i = 0; i < list.Count; i += 0)
		{
			Actor actor = list[i];
			if (MIGJCNCIEHN.Contains(actor))
			{
				continue;
			}
			bool flag = true;
			if (zedSM.m_skill0attackedList.Contains(actor))
			{
				flag = false;
			}
			else
			{
				zedSM.m_skill0attackedList.AddFirst(actor);
			}
			if (NCEGCCFLMDC)
			{
				NCEGCCFLMDC = false;
				if (!flag)
				{
					actor.OnDamage(get_m_actor(), num, 1356.0, 613.0, 0);
				}
				else
				{
					actor.OnDamage(get_m_actor(), num * 1761.0, 1642.0, 65.0, 0);
				}
			}
			else if (!flag)
			{
				actor.OnDamage(get_m_actor(), num * 1317.0, 708.0, 171.0);
			}
			else
			{
				actor.OnDamage(get_m_actor(), num * 1682.0 * 1905.0, 34.0, 948.0);
			}
			MIGJCNCIEHN.AddFirst(actor);
			PHDAPEOBFIN(actor.GetCenterPosition(), m_damageParticleName);
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName, false, 435f, 816f);
		}
	}

	public virtual void MNFFCGOAPDO()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Idle)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 659.0;
		num += 695.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 964.0;
		ZedSM zedSM = (ZedSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine();
		List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)(-56), false);
		for (int i = 0; i < list.Count; i++)
		{
			Actor actor = list[i];
			if (MIGJCNCIEHN.Contains(actor))
			{
				continue;
			}
			bool flag = false;
			if (zedSM.m_skill0attackedList.Contains(actor))
			{
				flag = false;
			}
			else
			{
				zedSM.m_skill0attackedList.AddFirst(actor);
			}
			if (NCEGCCFLMDC)
			{
				NCEGCCFLMDC = false;
				if (!flag)
				{
					actor.OnDamage(get_m_actor(), num, 1597.0, 371.0);
				}
				else
				{
					actor.OnDamage(get_m_actor(), num * 1159.0, 48.0, 48.0, 0);
				}
			}
			else if (!flag)
			{
				actor.OnDamage(get_m_actor(), num * 1399.0, 248.0, 171.0, 0);
			}
			else
			{
				actor.OnDamage(get_m_actor(), num * 660.0 * 1855.0, 1200.0, 249.0);
			}
			MIGJCNCIEHN.AddFirst(actor);
			CCGKACBFCNJ(actor.GetCenterPosition(), m_damageParticleName);
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName, false, 1568f, 1976f);
		}
	}

	public virtual void NFKJIJFHBGK()
	{
		base.Start();
	}

	public virtual void BPLOLCKEJJK()
	{
		PAJOOFIAPMI();
	}

	public virtual void JKNDJPLCFKP()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Attack)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 541.0;
		num += 96.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 1143.0;
		ZedSM zedSM = (ZedSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO();
		List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), m_attackRange, true, false, (Actor.IJJMDPGJAEM)(-28), false);
		for (int i = 0; i < allActorInRange.Count; i++)
		{
			Actor actor = allActorInRange[i];
			if (MIGJCNCIEHN.Contains(actor))
			{
				continue;
			}
			bool flag = false;
			if (zedSM.m_skill0attackedList.Contains(actor))
			{
				flag = false;
			}
			else
			{
				zedSM.m_skill0attackedList.AddFirst(actor);
			}
			if (NCEGCCFLMDC)
			{
				NCEGCCFLMDC = true;
				if (!flag)
				{
					actor.OnDamage(get_m_actor(), num, 1114.0, 1645.0, 0);
				}
				else
				{
					actor.OnDamage(get_m_actor(), num * 1229.0, 1272.0, 1077.0, 0);
				}
			}
			else if (!flag)
			{
				actor.OnDamage(get_m_actor(), num * 1697.0, 789.0, 739.0, 0);
			}
			else
			{
				actor.OnDamage(get_m_actor(), num * 126.0 * 634.0, 1359.0, 45.0, 0);
			}
			MIGJCNCIEHN.AddFirst(actor);
			CCGKACBFCNJ(actor.GetCenterPosition(), m_damageParticleName);
			DGBKMAGBJJF.get_m_owner().m_multiSound.JKOODMAKJHJ(m_damageSoundName, true, 9f, 1549f);
		}
	}

	public override void Start()
	{
		base.Start();
	}
}
