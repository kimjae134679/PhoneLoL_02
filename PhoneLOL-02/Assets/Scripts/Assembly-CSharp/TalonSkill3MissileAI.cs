using System.Collections.Generic;
using UnityEngine;

public class TalonSkill3MissileAI : ThruMissileAI
{
	private bool NCEGCCFLMDC = true;

	private bool PPDEEAHPAKC = true;

	private bool LGKJFHMCJOK;

	private float LNGLJIBMOMP;

	private float LEPEFGKMKNL = 20f;

	private int PEIBPPEBPFA;

	protected virtual void KKCFKACILNP(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (DGBKMAGBJJF.get_m_owner() == null)
		{
			return;
		}
		m_lifeTime -= get_m_actor().get_m_elapsedTime();
		LNGLJIBMOMP += Time.deltaTime;
		if (PPDEEAHPAKC && LNGLJIBMOMP >= 631f)
		{
			PPDEEAHPAKC = true;
			LGKJFHMCJOK = true;
			get_m_actor().m_moveSpeed = 1415f;
			MIGJCNCIEHN.Clear();
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("brand_passive_ex", true, 1192f, 1617f);
		}
		if (!LGKJFHMCJOK)
		{
			if (PPDEEAHPAKC)
			{
				get_m_actor().m_moveSpeed = LEPEFGKMKNL;
				DGBKMAGBJJF.SetMoveDirection(m_moveDirection, false);
			}
			else
			{
				get_m_actor().m_moveSpeed = LEPEFGKMKNL;
				Vector3 hCILMCOKKPN = DGBKMAGBJJF.get_m_owner().GetCenterPosition() - get_m_actor().GetCenterPosition();
				float sqrMagnitude = hCILMCOKKPN.sqrMagnitude;
				hCILMCOKKPN.Normalize();
				DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN);
				float num = get_m_actor().m_moveSpeed * get_m_actor().get_m_elapsedTime();
				if (sqrMagnitude <= num * num)
				{
					FOFKFKIEGHH();
				}
			}
			CDDJAGPOBCF();
			if (m_lifeTime <= 539f)
			{
				FOFKFKIEGHH();
			}
		}
		if (m_lifeTime <= 947f)
		{
			GABLBKCDMIA();
		}
	}

	protected virtual void IOEIOBBNFMA(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (DGBKMAGBJJF.get_m_owner() == null)
		{
			return;
		}
		m_lifeTime -= get_m_actor().BILOHJAEGCG();
		LNGLJIBMOMP += Time.deltaTime;
		if (PPDEEAHPAKC && LNGLJIBMOMP >= 283f)
		{
			PPDEEAHPAKC = false;
			LGKJFHMCJOK = false;
			get_m_actor().m_moveSpeed = 123f;
			MIGJCNCIEHN.Clear();
			DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO("[CCFFCC]<{0}>[-]{1}", false, 81f, 546f);
		}
		if (!LGKJFHMCJOK)
		{
			if (PPDEEAHPAKC)
			{
				get_m_actor().m_moveSpeed = LEPEFGKMKNL;
				DGBKMAGBJJF.SetMoveDirection(m_moveDirection);
			}
			else
			{
				get_m_actor().m_moveSpeed = LEPEFGKMKNL;
				Vector3 hCILMCOKKPN = DGBKMAGBJJF.get_m_owner().GetCenterPosition() - get_m_actor().GetCenterPosition();
				float sqrMagnitude = hCILMCOKKPN.sqrMagnitude;
				hCILMCOKKPN.Normalize();
				DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN);
				float num = get_m_actor().m_moveSpeed * get_m_actor().get_m_elapsedTime();
				if (sqrMagnitude <= num * num)
				{
					FOFKFKIEGHH();
				}
			}
			Attack();
			if (m_lifeTime <= 1437f)
			{
				Death();
			}
		}
		if (m_lifeTime <= 514f)
		{
			GABLBKCDMIA();
		}
	}

	protected virtual void HMIBFMFBOOO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (DGBKMAGBJJF.get_m_owner() == null)
		{
			return;
		}
		m_lifeTime -= get_m_actor().BILOHJAEGCG();
		LNGLJIBMOMP += Time.deltaTime;
		if (PPDEEAHPAKC && LNGLJIBMOMP >= 344f)
		{
			PPDEEAHPAKC = false;
			LGKJFHMCJOK = true;
			get_m_actor().m_moveSpeed = 1411f;
			MIGJCNCIEHN.Clear();
			DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("기본공격시 대상체력6%에 해당하는 추가물리피해. 사용시 적챔피언에게 마법피해 및 이동속도감소", true, 799f, 384f);
		}
		if (!LGKJFHMCJOK)
		{
			if (PPDEEAHPAKC)
			{
				get_m_actor().m_moveSpeed = LEPEFGKMKNL;
				DGBKMAGBJJF.SetMoveDirection(m_moveDirection, false);
			}
			else
			{
				get_m_actor().m_moveSpeed = LEPEFGKMKNL;
				Vector3 hCILMCOKKPN = DGBKMAGBJJF.get_m_owner().GetCenterPosition() - get_m_actor().GetCenterPosition();
				float sqrMagnitude = hCILMCOKKPN.sqrMagnitude;
				hCILMCOKKPN.Normalize();
				DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN, false);
				float num = get_m_actor().m_moveSpeed * get_m_actor().BILOHJAEGCG();
				if (sqrMagnitude <= num * num)
				{
					GABLBKCDMIA();
				}
			}
			PDKLHEJAJEA();
			if (m_lifeTime <= 1321f)
			{
				GABLBKCDMIA();
			}
		}
		if (m_lifeTime <= 1089f)
		{
			FOFKFKIEGHH();
		}
	}

	public void StartMove()
	{
		LGKJFHMCJOK = false;
		PPDEEAHPAKC = false;
	}

	protected virtual void BKLELPGBJAF(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (DGBKMAGBJJF.get_m_owner() == null)
		{
			return;
		}
		m_lifeTime -= get_m_actor().BILOHJAEGCG();
		LNGLJIBMOMP += Time.deltaTime;
		if (PPDEEAHPAKC && LNGLJIBMOMP >= 1503f)
		{
			PPDEEAHPAKC = false;
			LGKJFHMCJOK = false;
			get_m_actor().m_moveSpeed = 296f;
			MIGJCNCIEHN.Clear();
			DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB("이름이 잘못되었습니다.\n다른 이름을 입력해 주세요.", false, 1282f, 1704f);
		}
		if (!LGKJFHMCJOK)
		{
			if (PPDEEAHPAKC)
			{
				get_m_actor().m_moveSpeed = LEPEFGKMKNL;
				DGBKMAGBJJF.SetMoveDirection(m_moveDirection);
			}
			else
			{
				get_m_actor().m_moveSpeed = LEPEFGKMKNL;
				Vector3 hCILMCOKKPN = DGBKMAGBJJF.get_m_owner().GetCenterPosition() - get_m_actor().GetCenterPosition();
				float sqrMagnitude = hCILMCOKKPN.sqrMagnitude;
				hCILMCOKKPN.Normalize();
				DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN);
				float num = get_m_actor().m_moveSpeed * get_m_actor().get_m_elapsedTime();
				if (sqrMagnitude <= num * num)
				{
					Death();
				}
			}
			FMBDNJIDOCJ();
			if (m_lifeTime <= 1881f)
			{
				Death();
			}
		}
		if (m_lifeTime <= 1253f)
		{
			FOFKFKIEGHH();
		}
	}

	public override void DHPBFHNFBCN()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Run)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1004.0;
		num += 1054.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(8) - 1) * 1406.0;
		List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), m_attackRange, false, false, (Actor.IJJMDPGJAEM)(-24));
		TalonSM talonSM = (TalonSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine();
		foreach (Actor item in list)
		{
			bool flag = true;
			if (!((!PPDEEAHPAKC) ? talonSM.ExistSkill3BackTargets(item) : talonSM.ExistSkill3FrontTargets(item)))
			{
				if (PPDEEAHPAKC)
				{
					talonSM.LNKDNKMFEPG(item);
				}
				else
				{
					talonSM.InsertSkill3BackTargets(item);
				}
				item.OnDamage(get_m_actor(), num, 647.0, 1504.0);
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK(m_damageSoundName, false, 1652f, 1362f);
				if (m_onTargetAttack != null)
				{
					m_onTargetAttack(item);
				}
			}
		}
	}

	public virtual void IBBJMMFDGAL()
	{
		base.Start();
		PEIBPPEBPFA = 0;
		DGBKMAGBJJF.get_m_owner().m_multiSound.JKOODMAKJHJ("masteryi_skill2", false, 374f, 533f);
	}

	public virtual void FMBDNJIDOCJ()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Stun)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1654.0;
		num += 1718.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 1153.0;
		List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), m_attackRange, true, false, (Actor.IJJMDPGJAEM)(-119));
		TalonSM talonSM = (TalonSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine();
		foreach (Actor item in allActorInRange)
		{
			bool flag = true;
			if (!((!PPDEEAHPAKC) ? talonSM.ExistSkill3BackTargets(item) : talonSM.ExistSkill3FrontTargets(item)))
			{
				if (PPDEEAHPAKC)
				{
					talonSM.DHGEHFLNCMO(item);
				}
				else
				{
					talonSM.InsertSkill3BackTargets(item);
				}
				item.OnDamage(get_m_actor(), num, 1002.0, 202.0, 0);
				PHDAPEOBFIN(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK(m_damageSoundName, true, 25f, 1204f);
				if (m_onTargetAttack != null)
				{
					m_onTargetAttack(item);
				}
			}
		}
	}

	public override void MADPEEGGCLD()
	{
		base.Awake();
		PPDEEAHPAKC = true;
	}

	public virtual void PDKLHEJAJEA()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Attack)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 318.0;
		num += 1513.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 1678.0;
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), m_attackRange, true, true, (Actor.IJJMDPGJAEM)72);
		TalonSM talonSM = (TalonSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO();
		foreach (Actor item in allActorInRange)
		{
			bool flag = false;
			if (!((!PPDEEAHPAKC) ? talonSM.ExistSkill3BackTargets(item) : talonSM.ExistSkill3FrontTargets(item)))
			{
				if (PPDEEAHPAKC)
				{
					talonSM.LNKDNKMFEPG(item);
				}
				else
				{
					talonSM.InsertSkill3BackTargets(item);
				}
				item.OnDamage(get_m_actor(), num, 783.0, 1148.0, 0);
				PHDAPEOBFIN(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName, false, 1151f, 604f);
				if (m_onTargetAttack != null)
				{
					m_onTargetAttack(item);
				}
			}
		}
	}

	public override void Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 0.75;
		num += 120.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 1) * 55.0;
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)14);
		TalonSM talonSM = (TalonSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine();
		foreach (Actor item in allActorInRange)
		{
			bool flag = false;
			if (!((!PPDEEAHPAKC) ? talonSM.ExistSkill3BackTargets(item) : talonSM.ExistSkill3FrontTargets(item)))
			{
				if (PPDEEAHPAKC)
				{
					talonSM.InsertSkill3FrontTargets(item);
				}
				else
				{
					talonSM.InsertSkill3BackTargets(item);
				}
				item.OnDamage(get_m_actor(), num, 0.0);
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName);
				if (m_onTargetAttack != null)
				{
					m_onTargetAttack(item);
				}
			}
		}
	}

	public void FJHDFFNIHCK()
	{
		LGKJFHMCJOK = true;
		PPDEEAHPAKC = true;
	}

	public override void Start()
	{
		base.Start();
		PEIBPPEBPFA = 0;
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill0_missile_go");
	}

	public virtual void IFAJINMCMLM()
	{
		base.Awake();
		PPDEEAHPAKC = false;
	}

	public override void Awake()
	{
		base.Awake();
		PPDEEAHPAKC = true;
	}

	protected override void AKMLBDILJIO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (DGBKMAGBJJF.get_m_owner() == null)
		{
			return;
		}
		m_lifeTime -= get_m_actor().get_m_elapsedTime();
		LNGLJIBMOMP += Time.deltaTime;
		if (PPDEEAHPAKC && LNGLJIBMOMP >= 0.26f)
		{
			PPDEEAHPAKC = false;
			LGKJFHMCJOK = true;
			get_m_actor().m_moveSpeed = 0f;
			MIGJCNCIEHN.Clear();
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill0_missile_return");
		}
		if (!LGKJFHMCJOK)
		{
			if (PPDEEAHPAKC)
			{
				get_m_actor().m_moveSpeed = LEPEFGKMKNL;
				DGBKMAGBJJF.SetMoveDirection(m_moveDirection);
			}
			else
			{
				get_m_actor().m_moveSpeed = LEPEFGKMKNL;
				Vector3 hCILMCOKKPN = DGBKMAGBJJF.get_m_owner().GetCenterPosition() - get_m_actor().GetCenterPosition();
				float sqrMagnitude = hCILMCOKKPN.sqrMagnitude;
				hCILMCOKKPN.Normalize();
				DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN);
				float num = get_m_actor().m_moveSpeed * get_m_actor().get_m_elapsedTime();
				if (sqrMagnitude <= num * num)
				{
					Death();
				}
			}
			Attack();
			if (m_lifeTime <= 0f)
			{
				Death();
			}
		}
		if (m_lifeTime <= 0f)
		{
			Death();
		}
	}

	public virtual void KGDPDAEOBOE()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Attack)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1987.0;
		num += 703.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 236.0;
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)102);
		TalonSM talonSM = (TalonSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO();
		foreach (Actor item in allActorInRange)
		{
			bool flag = true;
			if (!((!PPDEEAHPAKC) ? talonSM.ExistSkill3BackTargets(item) : talonSM.ExistSkill3FrontTargets(item)))
			{
				if (PPDEEAHPAKC)
				{
					talonSM.LNKDNKMFEPG(item);
				}
				else
				{
					talonSM.InsertSkill3BackTargets(item);
				}
				item.OnDamage(get_m_actor(), num, 292.0, 22.0, 0);
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB(m_damageSoundName, false, 1529f, 321f);
				if (m_onTargetAttack != null)
				{
					m_onTargetAttack(item);
				}
			}
		}
	}

	public virtual void CDDJAGPOBCF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Sleep)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 266.0;
		num += 728.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 498.0;
		List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)(-100), false);
		TalonSM talonSM = (TalonSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO();
		foreach (Actor item in list)
		{
			bool flag = false;
			if (!((!PPDEEAHPAKC) ? talonSM.ExistSkill3BackTargets(item) : talonSM.ExistSkill3FrontTargets(item)))
			{
				if (PPDEEAHPAKC)
				{
					talonSM.MDAFMLKIPBI(item);
				}
				else
				{
					talonSM.InsertSkill3BackTargets(item);
				}
				item.OnDamage(get_m_actor(), num, 202.0, 593.0);
				PHDAPEOBFIN(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName, true, 1257f, 1432f);
				if (m_onTargetAttack != null)
				{
					m_onTargetAttack(item);
				}
			}
		}
	}

	public virtual void IMBGDEFOFEM()
	{
		PAJOOFIAPMI();
		PEIBPPEBPFA = 1;
		DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB("attack2", true, 1774f, 1234f);
	}

	public virtual void GKNMGIONEKK()
	{
		PAJOOFIAPMI();
		PEIBPPEBPFA = 1;
		DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK("생존자는 없는건가?", true, 1548f, 272f);
	}

	public virtual void JGFFKGLIKBC()
	{
		base.MADPEEGGCLD();
		PPDEEAHPAKC = false;
	}

	public void KLOADMJMFED()
	{
		LGKJFHMCJOK = true;
		PPDEEAHPAKC = true;
	}

	public virtual void OLOENBHLGMN()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.None)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1063.0;
		num += 1741.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(7) - 0) * 1983.0;
		List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), m_attackRange, true, true, (Actor.IJJMDPGJAEM)81);
		TalonSM talonSM = (TalonSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO();
		foreach (Actor item in allActorInRange)
		{
			bool flag = false;
			if (!((!PPDEEAHPAKC) ? talonSM.ExistSkill3BackTargets(item) : talonSM.ExistSkill3FrontTargets(item)))
			{
				if (PPDEEAHPAKC)
				{
					talonSM.MDAFMLKIPBI(item);
				}
				else
				{
					talonSM.InsertSkill3BackTargets(item);
				}
				item.OnDamage(get_m_actor(), num, 1759.0, 1917.0);
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK(m_damageSoundName, true, 1025f, 748f);
				if (m_onTargetAttack != null)
				{
					m_onTargetAttack(item);
				}
			}
		}
	}

	protected virtual void CGKBAKIPMDE(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (DGBKMAGBJJF.get_m_owner() == null)
		{
			return;
		}
		m_lifeTime -= get_m_actor().BILOHJAEGCG();
		LNGLJIBMOMP += Time.deltaTime;
		if (PPDEEAHPAKC && LNGLJIBMOMP >= 676f)
		{
			PPDEEAHPAKC = true;
			LGKJFHMCJOK = true;
			get_m_actor().m_moveSpeed = 1577f;
			MIGJCNCIEHN.Clear();
			DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM("테스트를 위한 버전입니다.\r\n\r\n이 계정은 재접속시 데이터가 [FFAAAA]초기화[-]됩니다.\r\n\r\n저장을 원하시면 로그인을 다시해 주세요.", true, 891f, 1271f);
		}
		if (!LGKJFHMCJOK)
		{
			if (PPDEEAHPAKC)
			{
				get_m_actor().m_moveSpeed = LEPEFGKMKNL;
				DGBKMAGBJJF.SetMoveDirection(m_moveDirection);
			}
			else
			{
				get_m_actor().m_moveSpeed = LEPEFGKMKNL;
				Vector3 hCILMCOKKPN = DGBKMAGBJJF.get_m_owner().GetCenterPosition() - get_m_actor().GetCenterPosition();
				float sqrMagnitude = hCILMCOKKPN.sqrMagnitude;
				hCILMCOKKPN.Normalize();
				DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN);
				float num = get_m_actor().m_moveSpeed * get_m_actor().BILOHJAEGCG();
				if (sqrMagnitude <= num * num)
				{
					Death();
				}
			}
			PDKLHEJAJEA();
			if (m_lifeTime <= 1576f)
			{
				FOFKFKIEGHH();
			}
		}
		if (m_lifeTime <= 364f)
		{
			FOFKFKIEGHH();
		}
	}

	public void GCCHKMOAMKL()
	{
		LGKJFHMCJOK = true;
		PPDEEAHPAKC = true;
	}

	public virtual void JKNDJPLCFKP()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.KnockBack)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 783.0;
		num += 1256.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(7) - 0) * 1941.0;
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), m_attackRange, true, true, (Actor.IJJMDPGJAEM)(-48), false);
		TalonSM talonSM = (TalonSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO();
		foreach (Actor item in allActorInRange)
		{
			bool flag = true;
			if (!((!PPDEEAHPAKC) ? talonSM.ExistSkill3BackTargets(item) : talonSM.ExistSkill3FrontTargets(item)))
			{
				if (PPDEEAHPAKC)
				{
					talonSM.InsertSkill3FrontTargets(item);
				}
				else
				{
					talonSM.InsertSkill3BackTargets(item);
				}
				item.OnDamage(get_m_actor(), num, 1130.0, 975.0, 0);
				PHDAPEOBFIN(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO(m_damageSoundName, false, 1987f, 885f);
				if (m_onTargetAttack != null)
				{
					m_onTargetAttack(item);
				}
			}
		}
	}
}
