using System.Collections.Generic;

public class GravesSkill0MissileAI : ThruMissileAI
{
	private List<GravesSkill0MissileAI> COLGCANJCGB;

	public override void Start()
	{
		base.Start();
	}

	public virtual void HKAMCNPENHB()
	{
		MADPEEGGCLD();
		COLGCANJCGB = new List<GravesSkill0MissileAI>(3);
	}

	public virtual void NMANMMOMHHD()
	{
		PAJOOFIAPMI();
	}

	public void InsertOtherMissile(GravesSkill0MissileAI BKBNNNIGANP)
	{
		COLGCANJCGB.Add(BKBNNNIGANP);
	}

	public virtual void CFJKHPNIODE()
	{
		MADPEEGGCLD();
		COLGCANJCGB = new List<GravesSkill0MissileAI>(2);
	}

	public virtual void EICMMILMBPA()
	{
		GNGJFGMJLHA();
		COLGCANJCGB = new List<GravesSkill0MissileAI>(2);
	}

	public virtual void IMBGDEFOFEM()
	{
		PAKIFAGJDEO();
	}

	public override void Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 0.76;
		num += 60.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 38.0;
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)14);
		foreach (Actor item in allActorInRange)
		{
			if (MIGJCNCIEHN.Contains(item))
			{
				continue;
			}
			bool flag = false;
			foreach (GravesSkill0MissileAI item2 in COLGCANJCGB)
			{
				if (item2.IsAttacked(item))
				{
					flag = true;
				}
			}
			if (!flag)
			{
				item.OnDamage(get_m_actor(), num, 0.0);
				MIGJCNCIEHN.AddFirst(item);
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName);
			}
		}
	}

	public virtual void DEFLIOMCCMA()
	{
		base.Awake();
		COLGCANJCGB = new List<GravesSkill0MissileAI>(8);
	}

	public virtual void FPILIKNFCKF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Skill)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 692.0;
		num += 613.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 174.0;
		List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), m_attackRange, false, false, (Actor.IJJMDPGJAEM)70);
		foreach (Actor item in allActorInRange)
		{
			if (MIGJCNCIEHN.Contains(item))
			{
				continue;
			}
			bool flag = false;
			foreach (GravesSkill0MissileAI item2 in COLGCANJCGB)
			{
				if (item2.IsAttacked(item))
				{
					flag = false;
				}
			}
			if (!flag)
			{
				item.OnDamage(get_m_actor(), num, 327.0, 1885.0, 0);
				MIGJCNCIEHN.AddFirst(item);
				PHDAPEOBFIN(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB(m_damageSoundName, true, 1167f, 762f);
			}
		}
	}

	public override void Awake()
	{
		base.Awake();
		COLGCANJCGB = new List<GravesSkill0MissileAI>(2);
	}

	public virtual void GKNMGIONEKK()
	{
		base.Start();
	}
}
