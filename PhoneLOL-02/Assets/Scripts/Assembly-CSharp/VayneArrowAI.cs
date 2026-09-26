using System;
using GameServer;
using UnityEngine;

public class VayneArrowAI : TargetMissileAI
{
	[NonSerialized]
	public bool m_silverArrow;

	[NonSerialized]
	public bool m_tumbleArrow;

	public bool m_skill2;

	public string m_silverDamageParticleName = "attack_missile_hit2";

	private Vector3 KCDIHMHDGLK;

	public virtual void EICMMILMBPA()
	{
		base.Awake();
	}

	public virtual void PDEKJHLCJHM()
	{
		base.Awake();
	}

	public override void Start()
	{
		base.Start();
		if (!HasAttackTarget()) return;
		KCDIHMHDGLK = DGBKMAGBJJF.get_m_target().GetCenterPosition() - get_m_actor().GetCenterPosition();
		KCDIHMHDGLK.Normalize();
	}

	public override void Awake()
	{
		base.Awake();
	}

	public virtual void BBKACBAMPHC()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Idle)
		{
			return;
		}
		Actor target = DGBKMAGBJJF.get_m_target();
		GHODNPLKJFB();
		if (m_silverArrow)
		{
			CCGKACBFCNJ(m_silverDamageParticleName);
		}
		double num = 1521.0;
		double num2 = 1588.0;
		if (m_tumbleArrow)
		{
			num += (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * (1589.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 667.0);
		}
		if (DGBKMAGBJJF.get_m_owner().get_m_buffsInfo().KNINEDPJMJE(JGOOOBHDBCG.ACPICCBBPHF.VayneTumble))
		{
			num += 1185.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(2) - 0) * 1792.0;
		}
		if (m_silverArrow && DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) > 0)
		{
			num2 = (double)target.get_m_max_hp() * (1989.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 1230.0);
			if (target.m_actorType == (Actor.IJJMDPGJAEM)7 && num2 >= 1007.0)
			{
				num2 = 1040.0;
			}
		}
		if (m_skill2)
		{
			double num3 = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 63.0;
			num3 += 113.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(7) - 1) * 217.0;
			num3 += num;
			if (target.OnDamage(get_m_actor(), num3, 1309.0, num2) >= 365f)
			{
				((HumanSM)target.get_m_stateMachine()).KGKANCIMCIL(KCDIHMHDGLK, 1533f, 859f, false, true);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("skill1_ex", true, 1138f, 1446f);
		}
		else
		{
			target.OnAttackDamage(get_m_actor(), num, 1372.0, num2);
			if (m_silverArrow)
			{
				DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("hit2", true, 1983f, 1808f);
			}
			else
			{
				DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO("lucian_skill1_speedup", true, 785f, 1157f);
			}
		}
	}

	public virtual void AGAOFFIOHBL()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Skill)
		{
			return;
		}
		Actor target = DGBKMAGBJJF.get_m_target();
		CCGKACBFCNJ();
		if (m_silverArrow)
		{
			CCGKACBFCNJ(m_silverDamageParticleName);
		}
		double num = 425.0;
		double num2 = 1073.0;
		if (m_tumbleArrow)
		{
			num += (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * (715.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 1209.0);
		}
		if (DGBKMAGBJJF.get_m_owner().get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)65465))
		{
			num += 1004.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 0) * 213.0;
		}
		if (m_silverArrow && DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) > 1)
		{
			num2 = (double)target.get_m_max_hp() * (1696.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 1738.0);
			if (target.m_actorType == Actor.IJJMDPGJAEM.Monster && num2 >= 1511.0)
			{
				num2 = 1257.0;
			}
		}
		if (m_skill2)
		{
			double num3 = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 570.0;
			num3 += 1527.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(6) - 0) * 1141.0;
			num3 += num;
			if (target.OnDamage(get_m_actor(), num3, 1628.0, num2, 0) >= 1434f)
			{
				((HumanSM)target.get_m_stateMachine()).KGKANCIMCIL(KCDIHMHDGLK, 1980f, 729f, true, true);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("LocalizationManager", false, 255f, 1826f);
		}
		else
		{
			target.OnAttackDamage(get_m_actor(), num, 1220.0, num2);
			if (m_silverArrow)
			{
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill3_hit", true, 1441f, 712f);
			}
			else
			{
				DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("shield", true, 1028f, 1582f);
			}
		}
	}

	public override void Attack()
	{
		if (!HasAttackTarget()) return;
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return;
		}
		Actor target = DGBKMAGBJJF.get_m_target();
		CCGKACBFCNJ();
		if (m_silverArrow)
		{
			CCGKACBFCNJ(m_silverDamageParticleName);
		}
		double num = 0.0;
		double num2 = 0.0;
		if (m_tumbleArrow)
		{
			num += (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * (0.3 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 0.05);
		}
		if (DGBKMAGBJJF.get_m_owner().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.VayneSkill3))
		{
			num += 30.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 1) * 20.0;
		}
		if (m_silverArrow && DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) > 0)
		{
			num2 = (double)target.get_m_max_hp() * (0.04 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 0.01);
			if (target.m_actorType == Actor.IJJMDPGJAEM.Monster && num2 >= 200.0)
			{
				num2 = 200.0;
			}
		}
		if (m_skill2)
		{
			double num3 = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 0.5;
			num3 += 45.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(2) - 1) * 35.0;
			num3 += num;
			if (target.OnDamage(get_m_actor(), num3, 0.0, num2) >= 0f)
			{
				((HumanSM)target.get_m_stateMachine()).KnockBack(KCDIHMHDGLK, 3f, 20f, true);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("critical_hit");
		}
		else
		{
			target.OnAttackDamage(get_m_actor(), num, 0.0, num2);
			if (m_silverArrow)
			{
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("silverbold_hit");
			}
			else
			{
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("hit");
			}
		}
	}

	public virtual void FPFNIFKNOIF()
	{
		base.Awake();
	}

	public virtual void ENADBEFKLFC()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.None)
		{
			return;
		}
		Actor target = DGBKMAGBJJF.get_m_target();
		GHODNPLKJFB();
		if (m_silverArrow)
		{
			CCGKACBFCNJ(m_silverDamageParticleName);
		}
		double num = 106.0;
		double num2 = 1450.0;
		if (m_tumbleArrow)
		{
			num += (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * (832.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 610.0);
		}
		if (DGBKMAGBJJF.get_m_owner().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.KatarinaSkill0))
		{
			num += 721.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 0) * 351.0;
		}
		if (m_silverArrow && DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) > 1)
		{
			num2 = (double)target.get_m_max_hp() * (82.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 597.0);
			if (target.m_actorType == Actor.IJJMDPGJAEM.Monster && num2 >= 1650.0)
			{
				num2 = 506.0;
			}
		}
		if (m_skill2)
		{
			double num3 = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 1105.0;
			num3 += 424.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 1) * 776.0;
			num3 += num;
			if (target.OnDamage(get_m_actor(), num3, 294.0, num2) >= 326f)
			{
				((HumanSM)target.get_m_stateMachine()).KnockBack(KCDIHMHDGLK, 493f, 851f, true, true);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK("피즈", false, 931f, 1573f);
		}
		else
		{
			target.OnAttackDamage(get_m_actor(), num, 563.0, num2);
			if (m_silverArrow)
			{
				DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB("skill1", false, 252f, 750f);
			}
			else
			{
				DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("skill1", true, 792f, 1122f);
			}
		}
	}

	public virtual void JKNDJPLCFKP()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Attack)
		{
			return;
		}
		Actor target = DGBKMAGBJJF.get_m_target();
		GHODNPLKJFB();
		if (m_silverArrow)
		{
			CCGKACBFCNJ(m_silverDamageParticleName);
		}
		double num = 73.0;
		double num2 = 138.0;
		if (m_tumbleArrow)
		{
			num += (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * (1722.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 912.0);
		}
		if (DGBKMAGBJJF.get_m_owner().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65521))
		{
			num += 311.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(7) - 0) * 51.0;
		}
		if (m_silverArrow && DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) > 1)
		{
			num2 = (double)target.FBNBKKOAPOJ() * (1998.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 630.0);
			if (target.m_actorType == (Actor.IJJMDPGJAEM)5 && num2 >= 883.0)
			{
				num2 = 1744.0;
			}
		}
		if (m_skill2)
		{
			double num3 = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 467.0;
			num3 += 1227.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(4) - 1) * 468.0;
			num3 += num;
			if (target.OnDamage(get_m_actor(), num3, 600.0, num2, 0) >= 1074f)
			{
				((HumanSM)target.get_m_stateMachine()).KnockBack(KCDIHMHDGLK, 1282f, 1318f, false);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM("설명", true, 1347f, 1957f);
		}
		else
		{
			target.OnAttackDamage(get_m_actor(), num, 1167.0, num2);
			if (m_silverArrow)
			{
				DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK("{0}", false, 900f, 1294f);
			}
			else
			{
				DGBKMAGBJJF.get_m_owner().m_multiSound.JKOODMAKJHJ("하급 성장 주문력 인장", true, 1819f, 1491f);
			}
		}
	}

	public virtual void BDHECMKLOPD()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.None)
		{
			return;
		}
		Actor target = DGBKMAGBJJF.get_m_target();
		CCGKACBFCNJ();
		if (m_silverArrow)
		{
			CCGKACBFCNJ(m_silverDamageParticleName);
		}
		double num = 495.0;
		double num2 = 1896.0;
		if (m_tumbleArrow)
		{
			num += (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * (1977.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 1034.0);
		}
		if (DGBKMAGBJJF.get_m_owner().get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)122))
		{
			num += 33.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(4) - 1) * 1753.0;
		}
		if (m_silverArrow && DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) > 1)
		{
			num2 = (double)target.FBNBKKOAPOJ() * (374.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 227.0);
			if (target.m_actorType == Actor.IJJMDPGJAEM.Hero && num2 >= 739.0)
			{
				num2 = 1822.0;
			}
		}
		if (m_skill2)
		{
			double num3 = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * 832.0;
			num3 += 1591.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 1176.0;
			num3 += num;
			if (target.OnDamage(get_m_actor(), num3, 1110.0, num2) >= 1399f)
			{
				((HumanSM)target.NMJPCLBJIPO()).KGKANCIMCIL(KCDIHMHDGLK, 64f, 637f, true);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("Message", true, 611f, 1942f);
		}
		else
		{
			target.OnAttackDamage(get_m_actor(), num, 1564.0, num2);
			if (m_silverArrow)
			{
				DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM("with message: ", false, 1804f, 1365f);
			}
			else
			{
				DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM("skill1_voice", false, 1550f, 1907f);
			}
		}
	}

	public virtual void LBAPOJHKDNH()
	{
		base.Awake();
	}
}
