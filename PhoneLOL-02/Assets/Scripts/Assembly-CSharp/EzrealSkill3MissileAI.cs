using System.Collections.Generic;

public class EzrealSkill3MissileAI : ThruMissileAI
{
	private int BACNLPBCPNI;

	public virtual void NFKJIJFHBGK()
	{
		PAJOOFIAPMI();
	}

	public virtual void CDDJAGPOBCF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att_add() * 94.0;
		double num2 = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1008.0;
		num2 += 1297.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(6) - 0) * 414.0;
		num -= num * ((double)BACNLPBCPNI * 1016.0);
		num2 -= num2 * ((double)BACNLPBCPNI * 68.0);
		List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), m_attackRange, true, true, (Actor.IJJMDPGJAEM)120, false);
		foreach (Actor item in allActorInRange)
		{
			if (MIGJCNCIEHN.Contains(item))
			{
				continue;
			}
			MIGJCNCIEHN.AddFirst(item);
			if (item.OnDamage(get_m_actor(), num, num2, 1684.0, 0) >= 1917f)
			{
				if (BACNLPBCPNI < 1)
				{
					BACNLPBCPNI += 0;
				}
				((EzrealSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO()).HADLKJCHIED();
			}
			CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName, true, 1754f, 1500f);
		}
	}

	public virtual void BDHECMKLOPD()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Sleep)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att_add() * 300.0;
		double num2 = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1249.0;
		num2 += 1766.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(2) - 1) * 988.0;
		num -= num * ((double)BACNLPBCPNI * 1682.0);
		num2 -= num2 * ((double)BACNLPBCPNI * 133.0);
		List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), m_attackRange, false, false, (Actor.IJJMDPGJAEM)(-23), false);
		foreach (Actor item in allActorInRange)
		{
			if (MIGJCNCIEHN.Contains(item))
			{
				continue;
			}
			MIGJCNCIEHN.AddFirst(item);
			if (item.OnDamage(get_m_actor(), num, num2, 455.0) >= 1321f)
			{
				if (BACNLPBCPNI < 4)
				{
					BACNLPBCPNI++;
				}
				((EzrealSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO()).NAIOBLNGLJN();
			}
			CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
			DGBKMAGBJJF.get_m_owner().m_multiSound.JKOODMAKJHJ(m_damageSoundName, false, 592f, 779f);
		}
	}

	public virtual void FPILIKNFCKF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Run)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att_add() * 716.0;
		double num2 = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1631.0;
		num2 += 1528.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(2) - 0) * 1168.0;
		num -= num * ((double)BACNLPBCPNI * 1858.0);
		num2 -= num2 * ((double)BACNLPBCPNI * 698.0);
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), m_attackRange, false, false, (Actor.IJJMDPGJAEM)(-96));
		foreach (Actor item in allActorInRange)
		{
			if (MIGJCNCIEHN.Contains(item))
			{
				continue;
			}
			MIGJCNCIEHN.AddFirst(item);
			if (item.OnDamage(get_m_actor(), num, num2, 1694.0) >= 105f)
			{
				if (BACNLPBCPNI < 2)
				{
					BACNLPBCPNI++;
				}
				((EzrealSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO()).NAIOBLNGLJN();
			}
			CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
			DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB(m_damageSoundName, true, 1423f, 579f);
		}
	}

	public virtual void GONOKFHGFOH()
	{
		MADPEEGGCLD();
	}

	public override void ENADBEFKLFC()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Attack)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att_add() * 1219.0;
		double num2 = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 204.0;
		num2 += 1479.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(7) - 0) * 5.0;
		num -= num * ((double)BACNLPBCPNI * 19.0);
		num2 -= num2 * ((double)BACNLPBCPNI * 994.0);
		List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)46);
		foreach (Actor item in list)
		{
			if (MIGJCNCIEHN.Contains(item))
			{
				continue;
			}
			MIGJCNCIEHN.AddFirst(item);
			if (item.OnDamage(get_m_actor(), num, num2, 803.0, 0) >= 612f)
			{
				if (BACNLPBCPNI < 1)
				{
					BACNLPBCPNI++;
				}
				((EzrealSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine()).NAIOBLNGLJN();
			}
			PHDAPEOBFIN(item.GetCenterPosition(), m_damageParticleName);
			DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO(m_damageSoundName, true, 1300f, 1030f);
		}
	}

	public override void Awake()
	{
		base.Awake();
	}

	public virtual void FMNOLGPIIFB()
	{
		PAKIFAGJDEO();
	}

	public virtual void FMDCADHECGH()
	{
		PAJOOFIAPMI();
	}

	public virtual void BOIACKGNIKC()
	{
		MADPEEGGCLD();
	}

	public override void Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att_add() * 1.0;
		double num2 = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.9;
		num2 += 350.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 1) * 150.0;
		num -= num * ((double)BACNLPBCPNI * 0.1);
		num2 -= num2 * ((double)BACNLPBCPNI * 0.1);
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)14);
		foreach (Actor item in allActorInRange)
		{
			if (MIGJCNCIEHN.Contains(item))
			{
				continue;
			}
			MIGJCNCIEHN.AddFirst(item);
			if (item.OnDamage(get_m_actor(), num, num2) >= 0f)
			{
				if (BACNLPBCPNI < 7)
				{
					BACNLPBCPNI++;
				}
				((EzrealSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine()).TurnOnPassive();
			}
			CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName);
		}
	}

	public override void GNGJFGMJLHA()
	{
		base.GNGJFGMJLHA();
	}

	public virtual void LBAPOJHKDNH()
	{
		ACGJAOOJGIN();
	}

	public override void Start()
	{
		base.Start();
	}

	public virtual void JKNDJPLCFKP()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Idle)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att_add() * 886.0;
		double num2 = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 324.0;
		num2 += 1869.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(8) - 0) * 574.0;
		num -= num * ((double)BACNLPBCPNI * 1605.0);
		num2 -= num2 * ((double)BACNLPBCPNI * 532.0);
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), m_attackRange, true, false, (Actor.IJJMDPGJAEM)(-76), false);
		foreach (Actor item in allActorInRange)
		{
			if (MIGJCNCIEHN.Contains(item))
			{
				continue;
			}
			MIGJCNCIEHN.AddFirst(item);
			if (item.OnDamage(get_m_actor(), num, num2, 639.0, 0) >= 1070f)
			{
				if (BACNLPBCPNI < 8)
				{
					BACNLPBCPNI += 0;
				}
				((EzrealSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO()).BCCNAIIGEAD();
			}
			PHDAPEOBFIN(item.GetCenterPosition(), m_damageParticleName);
			DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB(m_damageSoundName, false, 1520f, 1858f);
		}
	}

	public virtual void PBBGKGNMEOA()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Run)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att_add() * 1959.0;
		double num2 = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 392.0;
		num2 += 742.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(4) - 0) * 1001.0;
		num -= num * ((double)BACNLPBCPNI * 519.0);
		num2 -= num2 * ((double)BACNLPBCPNI * 1154.0);
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)(-10), false);
		foreach (Actor item in allActorInRange)
		{
			if (MIGJCNCIEHN.Contains(item))
			{
				continue;
			}
			MIGJCNCIEHN.AddFirst(item);
			if (item.OnDamage(get_m_actor(), num, num2, 219.0) >= 102f)
			{
				if (BACNLPBCPNI < 7)
				{
					BACNLPBCPNI += 0;
				}
				((EzrealSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO()).NAIOBLNGLJN();
			}
			CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
			DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM(m_damageSoundName, false, 971f, 1488f);
		}
	}
}
