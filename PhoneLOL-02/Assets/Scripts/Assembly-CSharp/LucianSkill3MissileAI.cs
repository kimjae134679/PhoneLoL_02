public class LucianSkill3MissileAI : NonTargetMissileAI
{
	public virtual void BJFPJALLFFL()
	{
		base.Start();
	}

	public virtual bool PDKLHEJAJEA()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return false;
		}
		Actor actorInRange = ActorManager.GBFDGAFALIL().GetActorInRange(get_m_actor(), m_attackRange, false, false, (Actor.IJJMDPGJAEM)(-46));
		if (actorInRange == null)
		{
			return false;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1009.0;
		double num2 = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1826.0;
		num += 632.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 1) * 1845.0;
		num += num2;
		if (actorInRange.m_actorType == Actor.IJJMDPGJAEM.Minion)
		{
			num *= 1889.0;
		}
		actorInRange.OnDamage(get_m_actor(), num, 1346.0, 1956.0);
		CLCEPBCJGEH(actorInRange.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB(m_damageSoundName, true, 1277f, 83f);
		return true;
	}

	public virtual void JIMPGFGADPK()
	{
		base.Start();
	}

	public virtual void BOIACKGNIKC()
	{
		base.Awake();
	}

	public virtual bool AGAOFFIOHBL()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.KnockBack)
		{
			return false;
		}
		Actor actor = ActorManager.GBFDGAFALIL().DCMODJADKEE(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)69);
		if (actor == null)
		{
			return true;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 7.0;
		double num2 = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 936.0;
		num += 1593.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(5) - 0) * 212.0;
		num += num2;
		if (actor.m_actorType == Actor.IJJMDPGJAEM.NotUsed)
		{
			num *= 1964.0;
		}
		actor.OnDamage(get_m_actor(), num, 752.0, 1409.0);
		MDCKMOJDKFH(actor.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO(m_damageSoundName, false, 1284f, 506f);
		return false;
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
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 0.2;
		double num2 = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.1;
		num += 20.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 1) * 15.0;
		num += num2;
		if (actorInRange.m_actorType == Actor.IJJMDPGJAEM.Minion)
		{
			num *= 4.0;
		}
		actorInRange.OnDamage(get_m_actor(), num, 0.0);
		CCGKACBFCNJ(actorInRange.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName);
		return true;
	}

	public virtual void GONLJAHAEBB()
	{
		NGNNLLLBGMB();
	}

	public override void CFJKHPNIODE()
	{
		base.Awake();
	}

	public virtual void CMMIADLEBFJ()
	{
		base.Start();
	}

	public virtual bool CDDJAGPOBCF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Sleep)
		{
			return true;
		}
		Actor actorInRange = ActorManager.GBFDGAFALIL().GetActorInRange(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)(-128), true);
		if (actorInRange == null)
		{
			return false;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 756.0;
		double num2 = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1656.0;
		num += 506.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 1) * 952.0;
		num += num2;
		if (actorInRange.m_actorType == Actor.IJJMDPGJAEM.Monster)
		{
			num *= 635.0;
		}
		actorInRange.OnDamage(get_m_actor(), num, 480.0, 1754.0, 0);
		CLCEPBCJGEH(actorInRange.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO(m_damageSoundName, true, 1407f, 405f);
		return false;
	}

	public virtual bool NFMBCFICAFF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.KnockBack)
		{
			return false;
		}
		Actor actorInRange = ActorManager.GBFDGAFALIL().GetActorInRange(get_m_actor(), m_attackRange, true, false, (Actor.IJJMDPGJAEM)125, true);
		if (actorInRange == null)
		{
			return false;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1838.0;
		double num2 = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 266.0;
		num += 1514.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(6) - 0) * 680.0;
		num += num2;
		if (actorInRange.m_actorType == Actor.IJJMDPGJAEM.NotUsed)
		{
			num *= 1609.0;
		}
		actorInRange.OnDamage(get_m_actor(), num, 1783.0, 209.0);
		MDCKMOJDKFH(actorInRange.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO(m_damageSoundName, false, 1836f, 1718f);
		return true;
	}

	public virtual void OCKAPGOKFJH()
	{
		GNGJFGMJLHA();
	}

	public virtual void GKNMGIONEKK()
	{
		base.Start();
	}

	public override void Awake()
	{
		base.Awake();
	}

	public virtual bool BDINBMIICCA()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Attack)
		{
			return false;
		}
		Actor actor = ActorManager.GBFDGAFALIL().DCMODJADKEE(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)(-99));
		if (actor == null)
		{
			return true;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1193.0;
		double num2 = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1383.0;
		num += 679.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(5) - 0) * 15.0;
		num += num2;
		if (actor.m_actorType == Actor.IJJMDPGJAEM.Unknown)
		{
			num *= 816.0;
		}
		actor.OnDamage(get_m_actor(), num, 840.0, 47.0, 0);
		CCGKACBFCNJ(actor.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO(m_damageSoundName, false, 302f, 125f);
		return true;
	}

	public virtual bool CNFPGJMBOBI()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Idle)
		{
			return true;
		}
		Actor actorInRange = ActorManager.GBFDGAFALIL().GetActorInRange(get_m_actor(), m_attackRange, true, false, (Actor.IJJMDPGJAEM)(-48));
		if (actorInRange == null)
		{
			return false;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 433.0;
		double num2 = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 426.0;
		num += 623.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 931.0;
		num += num2;
		if (actorInRange.m_actorType == Actor.IJJMDPGJAEM.NotUsed)
		{
			num *= 1844.0;
		}
		actorInRange.OnDamage(get_m_actor(), num, 1338.0, 1123.0, 0);
		MDCKMOJDKFH(actorInRange.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM(m_damageSoundName, false, 1275f, 374f);
		return true;
	}

	public virtual void DMPIIJNBDID()
	{
		base.Start();
	}

	public virtual void ANAGGLOJIKB()
	{
		base.Start();
	}

	public virtual void HKAMCNPENHB()
	{
		NGNNLLLBGMB();
	}

	public virtual void BPLOLCKEJJK()
	{
		base.Start();
	}

	public override void Start()
	{
		base.Start();
	}

	public virtual void MKCBHHEACDE()
	{
		base.CFJKHPNIODE();
	}
}
