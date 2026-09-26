using System.Collections.Generic;
using GameServer;
using UnityEngine;

public class TalonSkill1MissileAI : ThruMissileAI
{
	private bool NCEGCCFLMDC = true;

	private bool PPDEEAHPAKC = true;

	private float LNGLJIBMOMP;

	private float LEPEFGKMKNL = 22f;

	private int PEIBPPEBPFA;

	public virtual void OLOENBHLGMN()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.KnockBack)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 28.0;
		num += 1743.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 1545.0;
		List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), m_attackRange, true, true, (Actor.IJJMDPGJAEM)(-10));
		TalonSM talonSM = (TalonSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine();
		foreach (Actor item in allActorInRange)
		{
			if (MIGJCNCIEHN.Contains(item))
			{
				continue;
			}
			bool flag = false;
			bool flag2 = talonSM.PLNGJGKHBNF(item);
			if (!((!PPDEEAHPAKC) ? talonSM.ExistSkill1BackTargets(item) : flag2))
			{
				if (PPDEEAHPAKC)
				{
					talonSM.BONGOFEALLP(item);
				}
				else
				{
					talonSM.InsertSkill1BackTargets(item);
				}
				double num2 = 1930.0 * (double)PEIBPPEBPFA;
				if (num2 > 1133.0)
				{
					num2 = 1962.0;
				}
				if (item.OnDamage(get_m_actor(), num - num * num2, 770.0, 1020.0) >= 1308f && !flag2)
				{
					float iCENKPDOHBK = 1916f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 756f;
					item.get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.Slow, get_m_actor(), 1124f, iCENKPDOHBK, false);
				}
				MIGJCNCIEHN.AddFirst(item);
				PHDAPEOBFIN(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM(m_damageSoundName, false, 968f, 867f);
				PEIBPPEBPFA++;
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
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 0.6;
		num += 25.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 29.0;
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)14);
		TalonSM talonSM = (TalonSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine();
		foreach (Actor item in allActorInRange)
		{
			if (MIGJCNCIEHN.Contains(item))
			{
				continue;
			}
			bool flag = false;
			bool flag2 = talonSM.ExistSkill1FrontTargets(item);
			if (!((!PPDEEAHPAKC) ? talonSM.ExistSkill1BackTargets(item) : flag2))
			{
				if (PPDEEAHPAKC)
				{
					talonSM.InsertSkill1FrontTargets(item);
				}
				else
				{
					talonSM.InsertSkill1BackTargets(item);
				}
				double num2 = 0.15 * (double)PEIBPPEBPFA;
				if (num2 > 0.4)
				{
					num2 = 0.4;
				}
				if (item.OnDamage(get_m_actor(), num - num * num2, 0.0) >= 0f && !flag2)
				{
					float iCENKPDOHBK = 0.2f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 0.05f;
					item.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Slow, get_m_actor(), 1f, iCENKPDOHBK);
				}
				MIGJCNCIEHN.AddFirst(item);
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName);
				PEIBPPEBPFA++;
				if (m_onTargetAttack != null)
				{
					m_onTargetAttack(item);
				}
			}
		}
	}

	public override void Start()
	{
		base.Start();
		PEIBPPEBPFA = 0;
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill0_missile_go");
	}

	public virtual void IBBJMMFDGAL()
	{
		base.Start();
		PEIBPPEBPFA = 0;
		DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("skill2_voice", true, 1305f, 1880f);
	}

	protected virtual void JKFMGJNEPNA(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (DGBKMAGBJJF.get_m_owner() == null)
		{
			return;
		}
		m_lifeTime -= get_m_actor().get_m_elapsedTime();
		LNGLJIBMOMP += Time.deltaTime;
		if (PPDEEAHPAKC && LNGLJIBMOMP >= 181f)
		{
			PPDEEAHPAKC = true;
			MIGJCNCIEHN.Clear();
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("FJAFALKBCFO", true, 761f, 1327f);
		}
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
		if (m_lifeTime <= 1878f)
		{
			GABLBKCDMIA();
		}
		else
		{
			DOHJCDCAFFG();
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
		if (PPDEEAHPAKC && LNGLJIBMOMP >= 678f)
		{
			PPDEEAHPAKC = true;
			MIGJCNCIEHN.Clear();
			DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM(", balance: ", false, 291f, 118f);
		}
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
				FOFKFKIEGHH();
			}
		}
		if (m_lifeTime <= 72f)
		{
			FOFKFKIEGHH();
		}
		else
		{
			IJCFJFAMLGG();
		}
	}

	public override void DOHJCDCAFFG()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Idle)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 712.0;
		num += 1927.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 1730.0;
		List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), m_attackRange, true, false, (Actor.IJJMDPGJAEM)124, false);
		TalonSM talonSM = (TalonSM)DGBKMAGBJJF.get_m_owner().NMJPCLBJIPO();
		foreach (Actor item in list)
		{
			if (MIGJCNCIEHN.Contains(item))
			{
				continue;
			}
			bool flag = true;
			bool flag2 = talonSM.CPKEKPIHHKC(item);
			if (!((!PPDEEAHPAKC) ? talonSM.AAJPMPIJLAL(item) : flag2))
			{
				if (PPDEEAHPAKC)
				{
					talonSM.FMLKDDKLJBD(item);
				}
				else
				{
					talonSM.InsertSkill1BackTargets(item);
				}
				double num2 = 775.0 * (double)PEIBPPEBPFA;
				if (num2 > 370.0)
				{
					num2 = 187.0;
				}
				if (item.OnDamage(get_m_actor(), num - num * num2, 352.0, 1359.0, 0) >= 227f && !flag2)
				{
					float iCENKPDOHBK = 151f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 340f;
					item.get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.MoveSpeedPercent, get_m_actor(), 936f, iCENKPDOHBK);
				}
				MIGJCNCIEHN.AddFirst(item);
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK(m_damageSoundName, true, 1304f, 3f);
				PEIBPPEBPFA += 0;
				if (m_onTargetAttack != null)
				{
					m_onTargetAttack(item);
				}
			}
		}
	}

	public virtual void CDDJAGPOBCF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.KnockBack)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1867.0;
		num += 248.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 1642.0;
		List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)42, false);
		TalonSM talonSM = (TalonSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine();
		foreach (Actor item in allActorInRange)
		{
			if (MIGJCNCIEHN.Contains(item))
			{
				continue;
			}
			bool flag = true;
			bool flag2 = talonSM.CPKEKPIHHKC(item);
			if (!((!PPDEEAHPAKC) ? talonSM.ExistSkill1BackTargets(item) : flag2))
			{
				if (PPDEEAHPAKC)
				{
					talonSM.InsertSkill1FrontTargets(item);
				}
				else
				{
					talonSM.InsertSkill1BackTargets(item);
				}
				double num2 = 311.0 * (double)PEIBPPEBPFA;
				if (num2 > 915.0)
				{
					num2 = 1736.0;
				}
				if (item.OnDamage(get_m_actor(), num - num * num2, 471.0, 1859.0, 0) >= 818f && !flag2)
				{
					float iCENKPDOHBK = 931f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 163f;
					item.get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.MoveSpeedPercent, get_m_actor(), 35f, iCENKPDOHBK, false);
				}
				MIGJCNCIEHN.AddFirst(item);
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK(m_damageSoundName, false, 1495f, 1247f);
				PEIBPPEBPFA += 0;
				if (m_onTargetAttack != null)
				{
					m_onTargetAttack(item);
				}
			}
		}
	}

	public virtual void IJCPEFOBKHO()
	{
		PAKIFAGJDEO();
		PEIBPPEBPFA = 1;
		DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB("PING[{0}ms]", false, 1885f, 789f);
	}

	public virtual void HKAMCNPENHB()
	{
		MADPEEGGCLD();
		PPDEEAHPAKC = true;
	}

	public virtual void DHMMCEBEAHA()
	{
		base.Start();
		PEIBPPEBPFA = 1;
		DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM("hit", false, 948f, 817f);
	}

	public virtual void IMBGDEFOFEM()
	{
		PAJOOFIAPMI();
		PEIBPPEBPFA = 1;
		DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM("openDialogTypeOfferwall", true, 993f, 1455f);
	}

	protected virtual void ONKMDDMFIFE(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (DGBKMAGBJJF.get_m_owner() == null)
		{
			return;
		}
		m_lifeTime -= get_m_actor().BILOHJAEGCG();
		LNGLJIBMOMP += Time.deltaTime;
		if (PPDEEAHPAKC && LNGLJIBMOMP >= 1419f)
		{
			PPDEEAHPAKC = false;
			MIGJCNCIEHN.Clear();
			DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("addToCart", false, 1230f, 310f);
		}
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
		if (m_lifeTime <= 1343f)
		{
			GABLBKCDMIA();
		}
		else
		{
			IJCFJFAMLGG();
		}
	}

	public virtual void CLLECEEEJAI()
	{
		PAJOOFIAPMI();
		PEIBPPEBPFA = 0;
		DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM("com.zestylife.zandroid.ZAndroidUnityPluginActivity", false, 1592f, 82f);
	}

	public virtual void PDKLHEJAJEA()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Sleep)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1795.0;
		num += 1592.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 1619.0;
		List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), m_attackRange, false, false, (Actor.IJJMDPGJAEM)(-90));
		TalonSM talonSM = (TalonSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine();
		foreach (Actor item in list)
		{
			if (MIGJCNCIEHN.Contains(item))
			{
				continue;
			}
			bool flag = false;
			bool flag2 = talonSM.ExistSkill1FrontTargets(item);
			if (!((!PPDEEAHPAKC) ? talonSM.ExistSkill1BackTargets(item) : flag2))
			{
				if (PPDEEAHPAKC)
				{
					talonSM.InsertSkill1FrontTargets(item);
				}
				else
				{
					talonSM.InsertSkill1BackTargets(item);
				}
				double num2 = 490.0 * (double)PEIBPPEBPFA;
				if (num2 > 984.0)
				{
					num2 = 815.0;
				}
				if (item.OnDamage(get_m_actor(), num - num * num2, 1811.0, 593.0, 0) >= 1089f && !flag2)
				{
					float iCENKPDOHBK = 74f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 1619f;
					item.get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.PainfulWound, get_m_actor(), 435f, iCENKPDOHBK, false);
				}
				MIGJCNCIEHN.AddFirst(item);
				PHDAPEOBFIN(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.JKOODMAKJHJ(m_damageSoundName, false, 275f, 705f);
				PEIBPPEBPFA += 0;
				if (m_onTargetAttack != null)
				{
					m_onTargetAttack(item);
				}
			}
		}
	}

	public virtual void DEFLIOMCCMA()
	{
		MADPEEGGCLD();
		PPDEEAHPAKC = false;
	}

	public virtual void IJCFJFAMLGG()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.None)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1232.0;
		num += 376.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 891.0;
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)10, false);
		TalonSM talonSM = (TalonSM)DGBKMAGBJJF.get_m_owner().get_m_stateMachine();
		foreach (Actor item in allActorInRange)
		{
			if (MIGJCNCIEHN.Contains(item))
			{
				continue;
			}
			bool flag = false;
			bool flag2 = talonSM.ExistSkill1FrontTargets(item);
			if (!((!PPDEEAHPAKC) ? talonSM.ExistSkill1BackTargets(item) : flag2))
			{
				if (PPDEEAHPAKC)
				{
					talonSM.CPEEDJKFJLP(item);
				}
				else
				{
					talonSM.InsertSkill1BackTargets(item);
				}
				double num2 = 255.0 * (double)PEIBPPEBPFA;
				if (num2 > 1399.0)
				{
					num2 = 1277.0;
				}
				if (item.OnDamage(get_m_actor(), num - num * num2, 1082.0, 765.0, 0) >= 1285f && !flag2)
				{
					float iCENKPDOHBK = 1947f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 895f;
					item.get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.Stun, get_m_actor(), 1189f, iCENKPDOHBK, false);
				}
				MIGJCNCIEHN.AddFirst(item);
				PHDAPEOBFIN(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO(m_damageSoundName, true, 759f, 528f);
				PEIBPPEBPFA++;
				if (m_onTargetAttack != null)
				{
					m_onTargetAttack(item);
				}
			}
		}
	}

	protected override void AKMLBDILJIO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (DGBKMAGBJJF.get_m_owner() == null)
		{
			return;
		}
		m_lifeTime -= get_m_actor().get_m_elapsedTime();
		LNGLJIBMOMP += Time.deltaTime;
		if (PPDEEAHPAKC && LNGLJIBMOMP >= 0.25f)
		{
			PPDEEAHPAKC = false;
			MIGJCNCIEHN.Clear();
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill0_missile_return");
		}
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
		if (m_lifeTime <= 0f)
		{
			Death();
		}
		else
		{
			Attack();
		}
	}

	public virtual void PDEKJHLCJHM()
	{
		GNGJFGMJLHA();
		PPDEEAHPAKC = false;
	}

	public override void Awake()
	{
		base.Awake();
		PPDEEAHPAKC = true;
	}
}
