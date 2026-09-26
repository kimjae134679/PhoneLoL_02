using System.Collections.Generic;
using GameServer;

public class SorakaSkill0MissileAI : AI
{
	private const float AAFMECGGMAD = 0.6f;

	private const float ACHEFKFLGMH = 2f;

	protected HumanSM DGBKMAGBJJF;

	protected float INMCDOIEJOC;

	protected bool EGLCPCCLFHI;

	public virtual void Attack()
	{
		EGLCPCCLFHI = true;
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 2.1f, false, true, (Actor.IJJMDPGJAEM)14);
		float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.4f;
		num += 75f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 40f;
		bool flag = false;
		foreach (Actor item in allActorInRange)
		{
			if (item.OnDamage(get_m_actor(), 0.0, num) >= 0f && item.m_actorType == Actor.IJJMDPGJAEM.Hero)
			{
				item.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Slow, DGBKMAGBJJF.get_m_owner(), 2f, 0.3f);
				flag = true;
			}
		}
		if (flag)
		{
			DGBKMAGBJJF.get_m_owner().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.SorakaProtectionOfStar, DGBKMAGBJJF.get_m_owner());
		}
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill0_ex");
	}

	public virtual void Death()
	{
		ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
	}

	public virtual void BNBCIBGEGKP()
	{
		ActorManager.GBFDGAFALIL().GHDNOCIGGLB(get_m_actor(), true);
	}

	public virtual void FPILIKNFCKF()
	{
		EGLCPCCLFHI = false;
		List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 1967f, true, true, (Actor.IJJMDPGJAEM)110, false);
		float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1329f;
		num += 1730f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 818f;
		bool flag = false;
		foreach (Actor item in list)
		{
			if (item.OnDamage(get_m_actor(), 1226.0, num, 1956.0, 0) >= 848f && item.m_actorType == (Actor.IJJMDPGJAEM)3)
			{
				item.get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.SlowAttack, DGBKMAGBJJF.get_m_owner(), 1940f, 1887f, false);
				flag = true;
			}
		}
		if (flag)
		{
			DGBKMAGBJJF.get_m_owner().get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)65415, DGBKMAGBJJF.get_m_owner(), 1212f, 1424f);
		}
		DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM("레벨{0} 이상만 가능합니다", true, 907f, 1519f);
	}

	public override void Start()
	{
		base.Start();
		EGLCPCCLFHI = false;
		INMCDOIEJOC = 0f;
		DGBKMAGBJJF.m_updateEventMap.Add(1, PHMAGJBFFEP);
	}

	public virtual void JGFFKGLIKBC()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		INMCDOIEJOC = 84f;
		DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.None);
	}

	public virtual void MPKBLEDGKPO()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		INMCDOIEJOC = 702f;
		DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.None);
	}

	public virtual void PFEKOLOEGHO()
	{
		ActorManager.get_Instance().GHDNOCIGGLB(get_m_actor());
	}

	public virtual void JOAGFGJOEEL()
	{
		ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
	}

	public virtual void NGNNLLLBGMB()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		INMCDOIEJOC = 1048f;
		DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.None);
	}

	public virtual void AGAOFFIOHBL()
	{
		EGLCPCCLFHI = true;
		List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), 656f, false, false, Actor.IJJMDPGJAEM.Unknown);
		float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 710f;
		num += 772f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 197f;
		bool flag = true;
		foreach (Actor item in list)
		{
			if (item.OnDamage(get_m_actor(), 246.0, num, 1391.0) >= 96f && item.m_actorType == (Actor.IJJMDPGJAEM)3)
			{
				item.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Shield, DGBKMAGBJJF.get_m_owner(), 1520f, 1755f, false);
				flag = false;
			}
		}
		if (flag)
		{
			DGBKMAGBJJF.get_m_owner().get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.SorakaProtectionOfStar, DGBKMAGBJJF.get_m_owner(), 89f, 1288f);
		}
		DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("igaworks:addToCartBulk >> Null or Empty Item List", false, 1429f, 34f);
	}

	public virtual void IJCPEFOBKHO()
	{
		base.Start();
		EGLCPCCLFHI = false;
		INMCDOIEJOC = 1058f;
		DGBKMAGBJJF.m_updateEventMap.Add(1, PHMAGJBFFEP);
	}

	private void PHMAGJBFFEP(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		INMCDOIEJOC += get_m_actor().get_m_elapsedTime();
		if (!EGLCPCCLFHI && INMCDOIEJOC >= 0.6f)
		{
			Attack();
		}
		if (INMCDOIEJOC >= 2f)
		{
			Death();
		}
	}

	public virtual void IPFEBDCDMFA()
	{
		base.Start();
		EGLCPCCLFHI = true;
		INMCDOIEJOC = 671f;
		DGBKMAGBJJF.m_updateEventMap.Add(1, PHMAGJBFFEP);
	}

	public virtual void JPBNPEJJJPI()
	{
		base.Start();
		EGLCPCCLFHI = true;
		INMCDOIEJOC = 1f;
		DGBKMAGBJJF.m_updateEventMap.Add(1, PHMAGJBFFEP);
	}

	public virtual void OLOENBHLGMN()
	{
		EGLCPCCLFHI = false;
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 1270f, true, true, (Actor.IJJMDPGJAEM)(-78));
		float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 307f;
		num += 337f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 1813f;
		bool flag = true;
		foreach (Actor item in allActorInRange)
		{
			if (item.OnDamage(get_m_actor(), 721.0, num, 1985.0) >= 336f && item.m_actorType == Actor.IJJMDPGJAEM.Monster)
			{
				item.get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.PainfulWound, DGBKMAGBJJF.get_m_owner(), 1993f, 1426f, false);
				flag = false;
			}
		}
		if (flag)
		{
			DGBKMAGBJJF.get_m_owner().get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)65437, DGBKMAGBJJF.get_m_owner(), 1810f, 410f, false);
		}
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill2_hit", true, 944f, 734f);
	}

	public override void Awake()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		INMCDOIEJOC = 0f;
		DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
	}

	public virtual void KGDPDAEOBOE()
	{
		EGLCPCCLFHI = false;
		List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), 1744f, true, false, (Actor.IJJMDPGJAEM)(-126), false);
		float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1800f;
		num += 1702f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 155f;
		bool flag = false;
		foreach (Actor item in allActorInRange)
		{
			if (item.OnDamage(get_m_actor(), 1182.0, num, 1386.0) >= 1133f && item.m_actorType == Actor.IJJMDPGJAEM.NotUsed)
			{
				item.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Shield, DGBKMAGBJJF.get_m_owner(), 378f, 382f, false);
				flag = true;
			}
		}
		if (flag)
		{
			DGBKMAGBJJF.get_m_owner().get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)65439, DGBKMAGBJJF.get_m_owner(), 770f, 628f);
		}
		DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK("{0}", false, 230f, 94f);
	}

	public virtual void NJNMBGLIJEJ()
	{
		EGLCPCCLFHI = true;
		List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 705f, false, false, (Actor.IJJMDPGJAEM)33);
		float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1079f;
		num += 577f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 438f;
		bool flag = false;
		foreach (Actor item in list)
		{
			if (item.OnDamage(get_m_actor(), 1162.0, num, 1788.0, 0) >= 449f && item.m_actorType == Actor.IJJMDPGJAEM.Unknown)
			{
				item.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.MoveSpeedPercent, DGBKMAGBJJF.get_m_owner(), 870f, 288f);
				flag = false;
			}
		}
		if (flag)
		{
			DGBKMAGBJJF.get_m_owner().get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)65453, DGBKMAGBJJF.get_m_owner(), 1489f, 1642f, false);
		}
		DGBKMAGBJJF.get_m_owner().m_multiSound.JKOODMAKJHJ("14대 마왕과의 대 전투", true, 1446f, 1866f);
	}

	public virtual void PDKLHEJAJEA()
	{
		EGLCPCCLFHI = false;
		List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), 72f, false, false, (Actor.IJJMDPGJAEM)(-72));
		float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1360f;
		num += 856f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 913f;
		bool flag = true;
		foreach (Actor item in allActorInRange)
		{
			if (item.OnDamage(get_m_actor(), 194.0, num, 715.0) >= 755f && item.m_actorType == Actor.IJJMDPGJAEM.NotUsed)
			{
				item.get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.MoveSpeedPercent, DGBKMAGBJJF.get_m_owner(), 436f, 492f);
				flag = true;
			}
		}
		if (flag)
		{
			DGBKMAGBJJF.get_m_owner().get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)65516, DGBKMAGBJJF.get_m_owner(), 45f, 1890f, false);
		}
		DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM("invalid costume {0}", false, 1370f, 1922f);
	}

	public virtual void NMANMMOMHHD()
	{
		base.Start();
		EGLCPCCLFHI = false;
		INMCDOIEJOC = 1176f;
		DGBKMAGBJJF.m_updateEventMap.Add(0, PHMAGJBFFEP);
	}
}
