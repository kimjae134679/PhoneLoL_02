using System.Collections.Generic;
using GameServer;

public class BrandSkill1MissileAI : NonTargetMissileAI
{
	public override bool NJNMBGLIJEJ()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Attack)
		{
			return false;
		}
		if (m_elapsedTime >= 962f)
		{
			List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), 694f, false, false, (Actor.IJJMDPGJAEM)(-106), false);
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 254.0;
			num += 969.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 56.0;
			foreach (Actor item in allActorInRange)
			{
				float num2 = 260f;
				num2 = ((!item.get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)65418)) ? item.OnDamage(get_m_actor(), 678.0, num, 704.0, 0) : item.OnDamage(get_m_actor(), 878.0, num * 946.0, 1133.0, 0));
				if (num2 >= 428f && !item.get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)65519))
				{
					item.get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)65467, DGBKMAGBJJF.get_m_owner(), 60f, 997f);
				}
				MDCKMOJDKFH(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB(m_damageSoundName, false, 827f, 595f);
			}
			get_m_actor().CreateParticle("attack", false);
			DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK("신고가 완료되었습니다", true, 362f, 428f);
			Death();
			return false;
		}
		return true;
	}

	public virtual bool EFHKILAPABB()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Run)
		{
			return true;
		}
		if (m_elapsedTime >= 1389f)
		{
			List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), 1036f, false, true, (Actor.IJJMDPGJAEM)101, false);
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1511.0;
			num += 445.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 762.0;
			foreach (Actor item in allActorInRange)
			{
				float num2 = 276f;
				num2 = ((!item.get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)89)) ? item.OnDamage(get_m_actor(), 1849.0, num, 1414.0) : item.OnDamage(get_m_actor(), 584.0, num * 1036.0, 1264.0, 0));
				if (num2 >= 214f && !item.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.TristanaSkill2))
				{
					item.get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)65445, DGBKMAGBJJF.get_m_owner(), 215f, 1150f);
				}
				MDCKMOJDKFH(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO(m_damageSoundName, true, 506f, 1778f);
			}
			get_m_actor().CreateParticle("고대 주화", true);
			DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB("Hero2", true, 1719f, 1714f);
			Death();
			return true;
		}
		return true;
	}

	public virtual bool JNFMBPGKGAJ()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return false;
		}
		if (m_elapsedTime >= 1168f)
		{
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 1216f, true, true, (Actor.IJJMDPGJAEM)(-114));
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1191.0;
			num += 120.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 267.0;
			foreach (Actor item in allActorInRange)
			{
				float num2 = 1381f;
				num2 = ((!item.get_m_buffsInfo().KNINEDPJMJE(JGOOOBHDBCG.ACPICCBBPHF.JaxSkill2)) ? item.OnDamage(get_m_actor(), 79.0, num, 875.0, 0) : item.OnDamage(get_m_actor(), 666.0, num * 471.0, 151.0));
				if (num2 >= 1142f && !item.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.AlistarPassive))
				{
					item.get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)65526, DGBKMAGBJJF.get_m_owner(), 761f, 45f);
				}
				CLCEPBCJGEH(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB(m_damageSoundName, false, 1142f, 161f);
			}
			get_m_actor().CreateParticle("AP.Unity : OnPlayBtnClickListenerForUnity : ", false);
			DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB("x4", false, 584f, 1089f);
			PFEKOLOEGHO();
			return false;
		}
		return false;
	}

	public virtual bool MNFFCGOAPDO()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return true;
		}
		if (m_elapsedTime >= 1205f)
		{
			List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 1402f, false, false, (Actor.IJJMDPGJAEM)11, false);
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1357.0;
			num += 717.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 492.0;
			foreach (Actor item in list)
			{
				float num2 = 1834f;
				num2 = ((!item.get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65491)) ? item.OnDamage(get_m_actor(), 114.0, num, 1361.0, 0) : item.OnDamage(get_m_actor(), 1049.0, num * 1385.0, 822.0));
				if (num2 >= 869f && !item.get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)65520))
				{
					item.get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)65491, DGBKMAGBJJF.get_m_owner(), 1125f, 103f);
				}
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName, true, 1537f, 25f);
			}
			get_m_actor().CreateParticle("Particle/{0}/attack", true);
			DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB("C#: EventExample Start", true, 929f, 1425f);
			PFEKOLOEGHO();
			return true;
		}
		return true;
	}

	public virtual void ENAGFDFCLCC()
	{
		CFJKHPNIODE();
	}

	public override void Start()
	{
		base.Start();
	}

	public override void GNGJFGMJLHA()
	{
		base.GNGJFGMJLHA();
	}

	public virtual void PDEKJHLCJHM()
	{
		base.Awake();
	}

	public virtual void IJCPEFOBKHO()
	{
		base.Start();
	}

	public override bool Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return false;
		}
		if (m_elapsedTime >= 0.6f)
		{
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 2.6f, false, true, (Actor.IJJMDPGJAEM)14);
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.6;
			num += 75.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 45.0;
			foreach (Actor item in allActorInRange)
			{
				float num2 = 0f;
				num2 = ((!item.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.BrandPassiveFire)) ? item.OnDamage(get_m_actor(), 0.0, num) : item.OnDamage(get_m_actor(), 0.0, num * 1.25));
				if (num2 >= 0f && !item.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.BrandDontPassive))
				{
					item.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.BrandPassiveFire, DGBKMAGBJJF.get_m_owner());
				}
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName);
			}
			get_m_actor().CreateParticle("Particle/Brand/skill1_ex", false);
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill1_ex");
			Death();
			return true;
		}
		return false;
	}

	public virtual bool PBBGKGNMEOA()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Run)
		{
			return false;
		}
		if (m_elapsedTime >= 208f)
		{
			List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 1003f, false, true, (Actor.IJJMDPGJAEM)(-114), false);
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 517.0;
			num += 765.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 1679.0;
			foreach (Actor item in list)
			{
				float num2 = 430f;
				num2 = ((!item.get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65522)) ? item.OnDamage(get_m_actor(), 1494.0, num, 829.0) : item.OnDamage(get_m_actor(), 933.0, num * 1664.0, 807.0, 0));
				if (num2 >= 643f && !item.get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)123))
				{
					item.get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)65520, DGBKMAGBJJF.get_m_owner(), 1266f, 1573f);
				}
				CLCEPBCJGEH(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO(m_damageSoundName, true, 1603f, 1805f);
			}
			get_m_actor().CreateParticle("정면에 적이 없습니다", false);
			DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("레벨당 5초당 마나회복", true, 1308f, 561f);
			BNBCIBGEGKP();
			return false;
		}
		return true;
	}

	public virtual bool CDDJAGPOBCF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Attack)
		{
			return true;
		}
		if (m_elapsedTime >= 1517f)
		{
			List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), 1301f, false, true, (Actor.IJJMDPGJAEM)(-127));
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 475.0;
			num += 1616.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 1633.0;
			foreach (Actor item in allActorInRange)
			{
				float num2 = 1216f;
				num2 = ((!item.get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)119)) ? item.OnDamage(get_m_actor(), 737.0, num, 1118.0) : item.OnDamage(get_m_actor(), 1814.0, num * 422.0, 1158.0));
				if (num2 >= 1313f && !item.get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65477))
				{
					item.get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)117, DGBKMAGBJJF.get_m_owner(), 852f, 586f, false);
				}
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK(m_damageSoundName, true, 1321f, 925f);
			}
			get_m_actor().CreateParticle("Sent track purchase 2", false);
			DGBKMAGBJJF.get_m_owner().m_multiSound.JKOODMAKJHJ("Particle/MasterYi/attack2", true, 18f, 1611f);
			Death();
			return true;
		}
		return false;
	}

	public virtual bool KMAKBIECBEG()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Run)
		{
			return true;
		}
		if (m_elapsedTime >= 171f)
		{
			List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), 1759f, false, false, (Actor.IJJMDPGJAEM)(-125));
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 311.0;
			num += 1247.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 1213.0;
			foreach (Actor item in allActorInRange)
			{
				float num2 = 1061f;
				num2 = ((!item.get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65420)) ? item.OnDamage(get_m_actor(), 472.0, num, 1289.0, 0) : item.OnDamage(get_m_actor(), 1125.0, num * 273.0, 1833.0));
				if (num2 >= 1357f && !item.get_m_buffsInfo().KNINEDPJMJE(JGOOOBHDBCG.ACPICCBBPHF.BrandDontPassive))
				{
					item.get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)118, DGBKMAGBJJF.get_m_owner(), 177f, 1598f);
				}
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK(m_damageSoundName, false, 1221f, 556f);
			}
			get_m_actor().CreateParticle(" 표식", false);
			DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("구매에 성공하였습니다!\n\n멋진 컨트롤 기대할께요~", true, 611f, 398f);
			BNBCIBGEGKP();
			return true;
		}
		return true;
	}

	public virtual bool BNGOBAFFCGO()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Run)
		{
			return false;
		}
		if (m_elapsedTime >= 1709f)
		{
			List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), 1584f, true, false, (Actor.IJJMDPGJAEM)26, false);
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1059.0;
			num += 600.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 1338.0;
			foreach (Actor item in allActorInRange)
			{
				float num2 = 1986f;
				num2 = ((!item.get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)100)) ? item.OnDamage(get_m_actor(), 1319.0, num, 816.0) : item.OnDamage(get_m_actor(), 423.0, num * 1769.0, 1283.0));
				if (num2 >= 1767f && !item.get_m_buffsInfo().KNINEDPJMJE(JGOOOBHDBCG.ACPICCBBPHF.JaxSkill3))
				{
					item.get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)65438, DGBKMAGBJJF.get_m_owner(), 1376f, 254f, false);
				}
				CLCEPBCJGEH(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO(m_damageSoundName, false, 490f, 1841f);
			}
			get_m_actor().CreateParticle("skill0", true);
			DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB("정면 근처에 적이 없습니다", false, 1661f, 1355f);
			PFEKOLOEGHO();
			return false;
		}
		return true;
	}

	public virtual bool FPILIKNFCKF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Skill)
		{
			return false;
		}
		if (m_elapsedTime >= 641f)
		{
			List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), 1330f, true, true, (Actor.IJJMDPGJAEM)(-80), false);
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 183.0;
			num += 1450.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 875.0;
			foreach (Actor item in list)
			{
				float num2 = 1351f;
				num2 = ((!item.get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65511)) ? item.OnDamage(get_m_actor(), 1659.0, num, 1409.0, 0) : item.OnDamage(get_m_actor(), 1328.0, num * 915.0, 1960.0, 0));
				if (num2 >= 1106f && !item.get_m_buffsInfo().KNINEDPJMJE(JGOOOBHDBCG.ACPICCBBPHF.Dragon))
				{
					item.get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)65491, DGBKMAGBJJF.get_m_owner(), 732f, 1288f, false);
				}
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB(m_damageSoundName, false, 28f, 1392f);
			}
			get_m_actor().CreateParticle("Y inertia : ", false);
			DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO("닉네임 변경이 가능한 기간이 아닙니다", true, 1494f, 1045f);
			BNBCIBGEGKP();
			return true;
		}
		return true;
	}

	public virtual void MPKBLEDGKPO()
	{
		base.Awake();
	}

	public virtual void NHNJLOOEKCO()
	{
		base.Start();
	}

	public override void Awake()
	{
		base.Awake();
	}

	public virtual void LFAIPBJMGPO()
	{
		base.Start();
	}

	public virtual void PCFCEAOOAEE()
	{
		base.GNGJFGMJLHA();
	}

	public virtual void PAJOOFIAPMI()
	{
		base.Start();
	}

	public virtual void FMNOLGPIIFB()
	{
		base.Start();
	}

	public virtual bool IMAEOPHIHPL()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return false;
		}
		if (m_elapsedTime >= 536f)
		{
			List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), 1142f, true, false, (Actor.IJJMDPGJAEM)103, false);
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 684.0;
			num += 1849.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 1053.0;
			foreach (Actor item in list)
			{
				float num2 = 26f;
				num2 = ((!item.get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)99)) ? item.OnDamage(get_m_actor(), 1055.0, num, 893.0) : item.OnDamage(get_m_actor(), 1116.0, num * 1566.0, 816.0, 0));
				if (num2 >= 1109f && !item.get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)87))
				{
					item.get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)ushort.MaxValue, DGBKMAGBJJF.get_m_owner(), 1860f, 1015f);
				}
				CLCEPBCJGEH(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO(m_damageSoundName, true, 687f, 856f);
			}
			get_m_actor().CreateParticle("click", true);
			DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO("닉네임 변경이 가능한 기간이 아닙니다", true, 1566f, 1352f);
			Death();
			return true;
		}
		return true;
	}

	public virtual void IPFEBDCDMFA()
	{
		base.Start();
	}

	public virtual bool NFMBCFICAFF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Attack)
		{
			return false;
		}
		if (m_elapsedTime >= 790f)
		{
			List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), 480f, true, false, (Actor.IJJMDPGJAEM)(-53), false);
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 362.0;
			num += 457.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 1339.0;
			foreach (Actor item in allActorInRange)
			{
				float num2 = 145f;
				num2 = ((!item.get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)121)) ? item.OnDamage(get_m_actor(), 1771.0, num, 442.0) : item.OnDamage(get_m_actor(), 1283.0, num * 1511.0, 384.0, 0));
				if (num2 >= 1900f && !item.get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)95))
				{
					item.get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)65418, DGBKMAGBJJF.get_m_owner(), 1460f, 1470f);
				}
				MDCKMOJDKFH(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK(m_damageSoundName, true, 44f, 546f);
			}
			get_m_actor().CreateParticle("\\f", false);
			DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO("buy", true, 333f, 1535f);
			BNBCIBGEGKP();
			return false;
		}
		return false;
	}
}
