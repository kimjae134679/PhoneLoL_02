using System.Collections.Generic;

public class EzrealSkill1MissileAI : ThruMissileAI
{
	public virtual void PCFCEAOOAEE()
	{
		MADPEEGGCLD();
	}

	public virtual void PBBGKGNMEOA()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Skill)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 580.0;
		num += 577.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 1777.0;
		List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), m_attackRange, false, true, Actor.IJJMDPGJAEM.Monster, false);
		foreach (Actor item in list)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				MIGJCNCIEHN.AddFirst(item);
				if (item.OnDamage(get_m_actor(), 1445.0, num, 1793.0) >= 1048f)
				{
					((EzrealSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine()).BCCNAIIGEAD();
				}
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB(m_damageSoundName, false, 1875f, 952f);
			}
		}
	}

	public virtual void CMMIADLEBFJ()
	{
		base.PAKIFAGJDEO();
	}

	public virtual void PILOBHCDHIK()
	{
		base.Start();
	}

	public virtual void FPFNIFKNOIF()
	{
		base.ACGJAOOJGIN();
	}

	public virtual void JGFFKGLIKBC()
	{
		base.Awake();
	}

	public override void EDFFKDICHBF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Run)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 665.0;
		num += 1620.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 1882.0;
		List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)7, false);
		foreach (Actor item in list)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				MIGJCNCIEHN.AddFirst(item);
				if (item.OnDamage(get_m_actor(), 755.0, num, 766.0, 0) >= 344f)
				{
					((EzrealSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO()).NAIOBLNGLJN();
				}
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName, true, 1248f, 856f);
			}
		}
	}

	public override void Start()
	{
		base.Start();
	}

	public virtual void GONLJAHAEBB()
	{
		GNGJFGMJLHA();
	}

	public virtual void BDINBMIICCA()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.None)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1016.0;
		num += 175.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 453.0;
		List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)6, false);
		foreach (Actor item in allActorInRange)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				MIGJCNCIEHN.AddFirst(item);
				if (item.OnDamage(get_m_actor(), 132.0, num, 1127.0, 0) >= 1101f)
				{
					((EzrealSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO()).HADLKJCHIED();
				}
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.JKOODMAKJHJ(m_damageSoundName, true, 1546f, 297f);
			}
		}
	}

	public override void Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.8;
		num += 70.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 45.0;
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), m_attackRange, false, true, Actor.IJJMDPGJAEM.Hero);
		foreach (Actor item in allActorInRange)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				MIGJCNCIEHN.AddFirst(item);
				if (item.OnDamage(get_m_actor(), 0.0, num) >= 0f)
				{
					((EzrealSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine()).TurnOnPassive();
				}
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName);
			}
		}
	}

	public virtual void BJJDAEPBEPK()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.None)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1158.0;
		num += 1326.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 1256.0;
		List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), m_attackRange, true, true, (Actor.IJJMDPGJAEM)6);
		foreach (Actor item in list)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				MIGJCNCIEHN.AddFirst(item);
				if (item.OnDamage(get_m_actor(), 886.0, num, 350.0) >= 1106f)
				{
					((EzrealSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO()).BCCNAIIGEAD();
				}
				PHDAPEOBFIN(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM(m_damageSoundName, true, 575f, 622f);
			}
		}
	}

	public virtual void ANAGGLOJIKB()
	{
		base.Start();
	}

	public override void PAKIFAGJDEO()
	{
		PAJOOFIAPMI();
	}

	public virtual void BJFPJALLFFL()
	{
		base.Start();
	}

	public virtual void BDHECMKLOPD()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.None)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 361.0;
		num += 641.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 543.0;
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), m_attackRange, true, false, Actor.IJJMDPGJAEM.NotUsed, false);
		foreach (Actor item in allActorInRange)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				MIGJCNCIEHN.AddFirst(item);
				if (item.OnDamage(get_m_actor(), 1408.0, num, 308.0) >= 1459f)
				{
					((EzrealSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO()).BCCNAIIGEAD();
				}
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB(m_damageSoundName, true, 276f, 1209f);
			}
		}
	}

	public virtual void JPBNPEJJJPI()
	{
		base.PAKIFAGJDEO();
	}

	public virtual void CLLECEEEJAI()
	{
		PAJOOFIAPMI();
	}

	public virtual void IBBJMMFDGAL()
	{
		base.Start();
	}

	public override void Awake()
	{
		base.Awake();
	}

	public virtual void IPNINMFDLNN()
	{
		base.Start();
	}

	public virtual void LFAIPBJMGPO()
	{
		PAJOOFIAPMI();
	}

	public override void ACGJAOOJGIN()
	{
		GNGJFGMJLHA();
	}

	public virtual void CKMCEHLADAE()
	{
		GNGJFGMJLHA();
	}
}
