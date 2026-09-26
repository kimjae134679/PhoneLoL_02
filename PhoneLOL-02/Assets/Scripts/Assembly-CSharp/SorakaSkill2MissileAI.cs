using System.Collections.Generic;
using GameServer;

public class SorakaSkill2MissileAI : AI
{
	private const float AAFMECGGMAD = 1.5f;

	private const float ACHEFKFLGMH = 3f;

	private const float MDNKDANOFAF = 0.4f;

	protected HumanSM DGBKMAGBJJF;

	protected float INMCDOIEJOC;

	protected float DGOKCMMFOBH;

	protected bool EGLCPCCLFHI;

	public virtual void OLOENBHLGMN()
	{
		EGLCPCCLFHI = false;
		List<Actor> list = KJCNKNLKCLL();
		float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1258f;
		num += 1914f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(6) - 0) * 76f;
		float hBNDHMPNCME = 192f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(6) - 1) * 1095f;
		foreach (Actor item in list)
		{
			if (item.OnDamage(get_m_actor(), 1113.0, num, 1945.0, 0) >= 107f && item.m_actorType == Actor.IJJMDPGJAEM.Hero)
			{
				item.get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)0, DGBKMAGBJJF.get_m_owner(), hBNDHMPNCME, 1994f);
			}
		}
		DGBKMAGBJJF.get_m_owner().m_multiSound.JKOODMAKJHJ("Unlit/Text", false, 450f, 1737f);
	}

	private List<Actor> KJCNKNLKCLL()
	{
		return ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 1811f, true, true, (Actor.IJJMDPGJAEM)(-7), false);
	}

	private void BCNDAMNOFAN()
	{
		List<Actor> list = NIADDJFCBDA();
		float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.4f;
		num += 70f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(2) - 1) * 30f;
		foreach (Actor item in list)
		{
			item.OnDamage(get_m_actor(), 0.0, num);
		}
	}

	public virtual void PDKLHEJAJEA()
	{
		EGLCPCCLFHI = true;
		List<Actor> list = KJCNKNLKCLL();
		float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 367f;
		num += 1530f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 1085f;
		float hBNDHMPNCME = 1923f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(4) - 0) * 1775f;
		foreach (Actor item in list)
		{
			if (item.OnDamage(get_m_actor(), 1994.0, num, 1597.0) >= 1207f && item.m_actorType == (Actor.IJJMDPGJAEM)7)
			{
				item.get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.MoveSpeedPercent, DGBKMAGBJJF.get_m_owner(), hBNDHMPNCME, 1282f);
			}
		}
		DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK("skill1_buf", false, 1913f, 768f);
	}

	public virtual void Attack()
	{
		EGLCPCCLFHI = true;
		List<Actor> list = NIADDJFCBDA();
		float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.4f;
		num += 70f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(2) - 1) * 30f;
		float hBNDHMPNCME = 1f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(2) - 1) * 0.25f;
		foreach (Actor item in list)
		{
			if (item.OnDamage(get_m_actor(), 0.0, num) >= 0f && item.m_actorType == Actor.IJJMDPGJAEM.Hero)
			{
				item.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Slow, DGBKMAGBJJF.get_m_owner(), hBNDHMPNCME, 1f);
			}
		}
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill2_ex");
	}

	public override void Start()
	{
		base.Start();
		EGLCPCCLFHI = false;
		INMCDOIEJOC = 0f;
		DGOKCMMFOBH = 0f;
		DGBKMAGBJJF.m_updateEventMap.Add(1, PHMAGJBFFEP);
		BCNDAMNOFAN();
		ODNCMOIMAAP();
	}

	private void OLCDKLPCPNJ()
	{
		DGOKCMMFOBH = 831f;
		List<Actor> list = CGLPFHKPCJA();
		foreach (Actor item in list)
		{
			if (item.m_actorType == (Actor.IJJMDPGJAEM)3)
			{
				item.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.SlowAttack, DGBKMAGBJJF.get_m_owner(), 1136f, 461f, false);
			}
		}
	}

	private void ODNCMOIMAAP()
	{
		DGOKCMMFOBH = 0f;
		List<Actor> list = NIADDJFCBDA();
		foreach (Actor item in list)
		{
			if (item.m_actorType == Actor.IJJMDPGJAEM.Hero)
			{
				item.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Silence, DGBKMAGBJJF.get_m_owner(), 0.5f);
			}
		}
	}

	private List<Actor> PLIHFKJAJMG()
	{
		return ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), 1260f, true, false, (Actor.IJJMDPGJAEM)(-52), false);
	}

	public virtual void MKCBHHEACDE()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		INMCDOIEJOC = 1159f;
		DGOKCMMFOBH = 303f;
		DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
	}

	public virtual void BDINBMIICCA()
	{
		EGLCPCCLFHI = false;
		List<Actor> list = PFAOCPBBLAD();
		float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1123f;
		num += 1330f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(6) - 1) * 833f;
		float hBNDHMPNCME = 530f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 138f;
		foreach (Actor item in list)
		{
			if (item.OnDamage(get_m_actor(), 1596.0, num, 1321.0, 0) >= 767f && item.m_actorType == Actor.IJJMDPGJAEM.Minion)
			{
				item.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Shield, DGBKMAGBJJF.get_m_owner(), hBNDHMPNCME, 383f, false);
			}
		}
		DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB("음... 대부분 회복중이니깐 너무 마음 쓰지 말어!\n\t\t\t 그때 상황은 어쩔 수 없었잖아..", false, 1337f, 1570f);
	}

	public override void Awake()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		INMCDOIEJOC = 0f;
		DGOKCMMFOBH = 0f;
		DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
	}

	private List<Actor> NIADDJFCBDA()
	{
		return ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 2.5f, false, true, (Actor.IJJMDPGJAEM)14);
	}

	public virtual void Death()
	{
		ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
	}

	public virtual void HLABKAMKAPC()
	{
		ActorManager.get_Instance().RemoveActor(get_m_actor());
	}

	private List<Actor> CGLPFHKPCJA()
	{
		return ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 994f, true, true, (Actor.IJJMDPGJAEM)(-65));
	}

	private void LMDNJCICEHC()
	{
		DGOKCMMFOBH = 868f;
		List<Actor> list = PFAOCPBBLAD();
		foreach (Actor item in list)
		{
			if (item.m_actorType == Actor.IJJMDPGJAEM.Hero)
			{
				item.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Slow, DGBKMAGBJJF.get_m_owner(), 560f, 16f);
			}
		}
	}

	public virtual void BNBCIBGEGKP()
	{
		ActorManager.get_Instance().GHDNOCIGGLB(get_m_actor());
	}

	public virtual void AGAOFFIOHBL()
	{
		EGLCPCCLFHI = true;
		List<Actor> list = PLIHFKJAJMG();
		float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1930f;
		num += 1546f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(8) - 0) * 1724f;
		float hBNDHMPNCME = 1106f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(6) - 0) * 156f;
		foreach (Actor item in list)
		{
			if (item.OnDamage(get_m_actor(), 1338.0, num, 1951.0) >= 217f && item.m_actorType == (Actor.IJJMDPGJAEM)6)
			{
				item.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Slow, DGBKMAGBJJF.get_m_owner(), hBNDHMPNCME, 378f);
			}
		}
		DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM("GetPackageSHA", true, 1536f, 1824f);
	}

	public virtual void OLKMLFACLHP()
	{
		ActorManager.GBFDGAFALIL().GHDNOCIGGLB(get_m_actor(), true);
	}

	private List<Actor> PFAOCPBBLAD()
	{
		return ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), 64f, true, true, (Actor.IJJMDPGJAEM)(-99));
	}

	public virtual void JPBNPEJJJPI()
	{
		base.Start();
		EGLCPCCLFHI = false;
		INMCDOIEJOC = 579f;
		DGOKCMMFOBH = 984f;
		DGBKMAGBJJF.m_updateEventMap.Add(0, PHMAGJBFFEP);
		BCNDAMNOFAN();
		ODNCMOIMAAP();
	}

	private void PHMAGJBFFEP(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		INMCDOIEJOC += get_m_actor().get_m_elapsedTime();
		DGOKCMMFOBH += get_m_actor().get_m_elapsedTime();
		if (!EGLCPCCLFHI && INMCDOIEJOC >= 1.5f)
		{
			Attack();
		}
		if (DGOKCMMFOBH >= 0.4f && INMCDOIEJOC < 1.5f)
		{
			ODNCMOIMAAP();
		}
		if (INMCDOIEJOC >= 3f)
		{
			Death();
		}
	}

	public virtual void EICMMILMBPA()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		INMCDOIEJOC = 354f;
		DGOKCMMFOBH = 1383f;
		DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.None);
	}
}
