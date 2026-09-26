public class LucianPassiveMissileAI : TargetMissileAI
{
	public virtual void BPLOLCKEJJK()
	{
		base.Start();
	}

	public virtual void LBAPOJHKDNH()
	{
		HKAMCNPENHB();
	}

	public virtual void CMMIADLEBFJ()
	{
		base.Start();
	}

	public virtual void DEFLIOMCCMA()
	{
		base.Awake();
	}

	public virtual void FMBDNJIDOCJ()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Sleep)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			double num = DGBKMAGBJJF.get_m_owner().get_m_phy_att();
			if (target.m_actorType != Actor.IJJMDPGJAEM.NotUsed)
			{
				byte level = DGBKMAGBJJF.get_m_owner().get_Level();
				num = ((level < 3) ? (num * 43.0) : ((level >= 100) ? (num * 1628.0) : (num * 1201.0)));
			}
			target.OnDamage(get_m_actor(), num, 74.0, 1509.0);
			if (target.m_actorType == (Actor.IJJMDPGJAEM)6)
			{
				HumanSM.CAJJEALKJMM cAJJEALKJMM = DGBKMAGBJJF.get_m_owner().GetHumanSM().CMAHCODBACL(1);
				cAJJEALKJMM.IHKCKBJBEGF = (float)cAJJEALKJMM.IHKCKBJBEGF + 1293f;
			}
			else
			{
				HumanSM.CAJJEALKJMM cAJJEALKJMM2 = DGBKMAGBJJF.get_m_owner().GetHumanSM().CMAHCODBACL(1);
				cAJJEALKJMM2.IHKCKBJBEGF = (float)cAJJEALKJMM2.IHKCKBJBEGF + 1154f;
			}
			CBKGHLBACMK();
			DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO(m_damageSoundName, true, 415f, 1778f);
			if (m_onTargetAttack != null)
			{
				m_onTargetAttack(target);
			}
		}
	}

	public override void Awake()
	{
		base.Awake();
	}

	public virtual void FMNOLGPIIFB()
	{
		base.Start();
	}

	public override void Start()
	{
		base.Start();
	}

	public virtual void IBBJMMFDGAL()
	{
		base.Start();
	}

	public virtual void JIMPGFGADPK()
	{
		base.Start();
	}

	public virtual void PDKLHEJAJEA()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Sleep)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			double num = DGBKMAGBJJF.get_m_owner().get_m_phy_att();
			if (target.m_actorType != Actor.IJJMDPGJAEM.Monster)
			{
				byte level = DGBKMAGBJJF.get_m_owner().get_Level();
				num = ((level < 4) ? (num * 1010.0) : ((level >= 96) ? (num * 1709.0) : (num * 111.0)));
			}
			target.OnDamage(get_m_actor(), num, 322.0, 1467.0, 0);
			if (target.m_actorType == Actor.IJJMDPGJAEM.NotUsed)
			{
				HumanSM.CAJJEALKJMM cAJJEALKJMM = DGBKMAGBJJF.get_m_owner().GetHumanSM().CMAHCODBACL(2);
				cAJJEALKJMM.IHKCKBJBEGF = (float)cAJJEALKJMM.IHKCKBJBEGF + 1036f;
			}
			else
			{
				HumanSM.CAJJEALKJMM cAJJEALKJMM2 = DGBKMAGBJJF.get_m_owner().GetHumanSM().CMAHCODBACL(1);
				cAJJEALKJMM2.IHKCKBJBEGF = (float)cAJJEALKJMM2.IHKCKBJBEGF + 1642f;
			}
			GHODNPLKJFB();
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName, false, 493f, 1576f);
			if (m_onTargetAttack != null)
			{
				m_onTargetAttack(target);
			}
		}
	}

	public virtual void PDEKJHLCJHM()
	{
		base.Awake();
	}

	public virtual void CHJGEGLHOAF()
	{
		base.Start();
	}

	public virtual void IFAJINMCMLM()
	{
		HKAMCNPENHB();
	}

	public virtual void EDFFKDICHBF()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.KnockBack)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			double num = DGBKMAGBJJF.get_m_owner().get_m_phy_att();
			if (target.m_actorType != Actor.IJJMDPGJAEM.Monster)
			{
				byte level = DGBKMAGBJJF.get_m_owner().get_Level();
				num = ((level < 4) ? (num * 1469.0) : ((level >= 21) ? (num * 588.0) : (num * 1371.0)));
			}
			target.OnDamage(get_m_actor(), num, 1091.0, 857.0);
			if (target.m_actorType == Actor.IJJMDPGJAEM.Unknown)
			{
				HumanSM.CAJJEALKJMM castSkill = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(7);
				castSkill.IHKCKBJBEGF = (float)castSkill.IHKCKBJBEGF + 37f;
			}
			else
			{
				HumanSM.CAJJEALKJMM castSkill2 = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(6);
				castSkill2.IHKCKBJBEGF = (float)castSkill2.IHKCKBJBEGF + 1651f;
			}
			CBKGHLBACMK();
			DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO(m_damageSoundName, false, 461f, 1787f);
			if (m_onTargetAttack != null)
			{
				m_onTargetAttack(target);
			}
		}
	}

	public virtual void LFAIPBJMGPO()
	{
		base.Start();
	}

	public virtual void CLLECEEEJAI()
	{
		base.Start();
	}

	public virtual void PCFCEAOOAEE()
	{
		HKAMCNPENHB();
	}

	public virtual void NFKJIJFHBGK()
	{
		base.Start();
	}

	public override void Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Death)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			double num = DGBKMAGBJJF.get_m_owner().get_m_phy_att();
			if (target.m_actorType != Actor.IJJMDPGJAEM.Minion)
			{
				byte level = DGBKMAGBJJF.get_m_owner().get_Level();
				num = ((level < 6) ? (num * 0.4) : ((level >= 12) ? (num * 0.6) : (num * 0.5)));
			}
			target.OnDamage(get_m_actor(), num, 0.0, 0.0, 0);
			if (target.m_actorType == Actor.IJJMDPGJAEM.Hero)
			{
				HumanSM.CAJJEALKJMM castSkill = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(2);
				castSkill.IHKCKBJBEGF = (float)castSkill.IHKCKBJBEGF + 2f;
			}
			else
			{
				HumanSM.CAJJEALKJMM castSkill2 = DGBKMAGBJJF.get_m_owner().GetHumanSM().GetCastSkill(2);
				castSkill2.IHKCKBJBEGF = (float)castSkill2.IHKCKBJBEGF + 1f;
			}
			CCGKACBFCNJ();
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName);
			if (m_onTargetAttack != null)
			{
				m_onTargetAttack(target);
			}
		}
	}

	public virtual void ENAGFDFCLCC()
	{
		base.Awake();
	}
}
