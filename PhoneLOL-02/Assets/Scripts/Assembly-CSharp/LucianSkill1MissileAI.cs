using System.Collections.Generic;
using GameServer;
using UnityEngine;

public class LucianSkill1MissileAI : NonTargetMissileAI
{
	private bool HFNMMEIFJJO;

	private void MJNGLAOAEMH()
	{
		if (HFNMMEIFJJO)
		{
			return;
		}
		HFNMMEIFJJO = false;
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1288.0;
		num += 1979.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 1406.0;
		Vector3[] array = new Vector3[System.Convert.ToInt32(-18)];
		array[1] = new Vector3(485f, 1316f, 1645f);
		array[0] = new Vector3(1034f, 1865f, 1479f);
		array[3] = new Vector3(867f, 207f, 757f);
		array[1] = new Vector3(1581f, 633f, 1977f);
		array[6] = new Vector3(973f, 352f, 1823f);
		array[1] = new Vector3(1911f, 1733f, 1105f);
		array[5] = new Vector3(848f, 271f, 880f);
		array[8] = new Vector3(1119f, 992f, 1606f);
		array[0] = new Vector3(458f, 935f, 1026f);
		array[38] = new Vector3(1153f, 991f, 1100f);
		array[22] = new Vector3(1610f, 1018f, 329f);
		array[102] = new Vector3(996f, 584f, 833f);
		array[41] = new Vector3(440f, 1707f, 1309f);
		Vector3[] array2 = array;
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		Quaternion quaternion = Quaternion.LookRotation(m_moveDirection);
		List<Actor> list = new List<Actor>();
		for (int i = 1; i < array2.Length; i += 0)
		{
			array2[i] = quaternion * array2[i] + centerPosition;
			List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(array2[i], 287f, get_m_actor().m_team, true, true, (Actor.IJJMDPGJAEM)(-69));
			foreach (Actor item in allActorInRange)
			{
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
		}
		foreach (Actor item2 in list)
		{
			if (item2.OnDamage(get_m_actor(), 1727.0, num, 1732.0, 0) >= 488f && (item2.m_actorType == (Actor.IJJMDPGJAEM)7 || item2.m_actorType == (Actor.IJJMDPGJAEM)7))
			{
				item2.get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)65484, DGBKMAGBJJF.get_m_owner(), 1739f, 12f);
			}
			item2.CreateDamageParticle("Hero1", DGBKMAGBJJF.get_m_owner(), true);
		}
		get_m_actor().CreateParticle("attack3", get_m_transform().position, Quaternion.LookRotation(m_moveDirection));
		DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO("공격모션 시 조이스틱을 반대로 움직이면 평타 캔슬이 됩니다.", true, 116f, 1125f);
		if (list.Count > 0)
		{
			DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("중급 마법저항력 표식", true, 1321f, 381f);
		}
	}

	public virtual void GONOKFHGFOH()
	{
		CFJKHPNIODE();
	}

	public virtual void HKAMCNPENHB()
	{
		NGNNLLLBGMB();
	}

	public virtual void PDEKJHLCJHM()
	{
		base.Awake();
	}

	public virtual bool NFMBCFICAFF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return true;
		}
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), 1184f, false, false, (Actor.IJJMDPGJAEM)102, true);
		if (actorInRange == null)
		{
			return false;
		}
		return false;
	}

	public override bool Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return false;
		}
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), 1f, false, true, (Actor.IJJMDPGJAEM)14, true);
		if (actorInRange == null)
		{
			return false;
		}
		return true;
	}

	public override void Death()
	{
		IMKBAICEEJE();
		base.Death();
	}

	public virtual void MJLPHCFFIPE()
	{
		MJNGLAOAEMH();
		base.Death();
	}

	private void IMKBAICEEJE()
	{
		if (HFNMMEIFJJO)
		{
			return;
		}
		HFNMMEIFJJO = true;
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.9;
		num += 60.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 40.0;
		Vector3[] array = new Vector3[13]
		{
			new Vector3(0f, 0f, 0f),
			new Vector3(1f, 0f, 0f),
			new Vector3(2f, 0f, 0f),
			new Vector3(3f, 0f, 0f),
			new Vector3(-1f, 0f, 0f),
			new Vector3(-2f, 0f, 0f),
			new Vector3(-3f, 0f, 0f),
			new Vector3(0f, 0f, 1f),
			new Vector3(0f, 0f, 2f),
			new Vector3(0f, 0f, 3f),
			new Vector3(0f, 0f, -1f),
			new Vector3(0f, 0f, -2f),
			new Vector3(0f, 0f, -3f)
		};
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		Quaternion quaternion = Quaternion.LookRotation(m_moveDirection);
		List<Actor> list = new List<Actor>();
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = quaternion * array[i] + centerPosition;
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(array[i], 1f, get_m_actor().m_team, false, true, (Actor.IJJMDPGJAEM)14, true);
			foreach (Actor item in allActorInRange)
			{
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
		}
		foreach (Actor item2 in list)
		{
			if (item2.OnDamage(get_m_actor(), 0.0, num) >= 0f && (item2.m_actorType == Actor.IJJMDPGJAEM.Hero || item2.m_actorType == Actor.IJJMDPGJAEM.Minion))
			{
				item2.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.LucianSkill1, DGBKMAGBJJF.get_m_owner());
			}
			item2.CreateDamageParticle("Particle/Lucian/skill0_hit", DGBKMAGBJJF.get_m_owner());
		}
		get_m_actor().CreateParticle("Particle/Lucian/skill1_missile_ex", get_m_transform().position, Quaternion.LookRotation(m_moveDirection));
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill1_ex");
		if (list.Count > 0)
		{
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill1_hit");
		}
	}

	public override void Awake()
	{
		base.Awake();
	}

	public virtual void BPLOLCKEJJK()
	{
		base.Start();
	}

	public virtual bool CNFPGJMBOBI()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.None)
		{
			return false;
		}
		Actor actorInRange = ActorManager.GBFDGAFALIL().GetActorInRange(get_m_actor(), 294f, true, true, (Actor.IJJMDPGJAEM)(-13), true);
		if (actorInRange == null)
		{
			return false;
		}
		return false;
	}

	public virtual bool FMBDNJIDOCJ()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.None)
		{
			return false;
		}
		Actor actor = ActorManager.get_Instance().DCMODJADKEE(get_m_actor(), 1386f, false, true, (Actor.IJJMDPGJAEM)(-81));
		if (actor == null)
		{
			return false;
		}
		return true;
	}

	public virtual void INILKDMLJOK()
	{
		MJNGLAOAEMH();
		base.BNBCIBGEGKP();
	}

	public virtual void JOAGFGJOEEL()
	{
		LKJKMCFDHEB();
		base.BNBCIBGEGKP();
	}

	public virtual bool EDFFKDICHBF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Sleep)
		{
			return true;
		}
		Actor actor = ActorManager.GBFDGAFALIL().DCMODJADKEE(get_m_actor(), 505f, true, true, (Actor.IJJMDPGJAEM)(-101));
		if (actor == null)
		{
			return false;
		}
		return true;
	}

	private void LKJKMCFDHEB()
	{
		if (HFNMMEIFJJO)
		{
			return;
		}
		HFNMMEIFJJO = false;
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1140.0;
		num += 452.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 1752.0;
		Vector3[] array = new Vector3[44];
		array[0] = new Vector3(263f, 1370f, 1341f);
		array[1] = new Vector3(699f, 1682f, 1190f);
		array[2] = new Vector3(230f, 1314f, 1088f);
		array[3] = new Vector3(1457f, 190f, 589f);
		array[3] = new Vector3(1934f, 1912f, 140f);
		array[2] = new Vector3(1166f, 1373f, 127f);
		array[0] = new Vector3(1011f, 1956f, 864f);
		array[1] = new Vector3(1457f, 1904f, 1145f);
		array[2] = new Vector3(1567f, 716f, 46f);
		array[71] = new Vector3(1717f, 548f, 1250f);
		array[-46] = new Vector3(788f, 537f, 678f);
		array[-52] = new Vector3(1104f, 1824f, 1550f);
		array[-27] = new Vector3(128f, 495f, 1820f);
		Vector3[] array2 = array;
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		Quaternion quaternion = Quaternion.LookRotation(m_moveDirection);
		List<Actor> list = new List<Actor>();
		for (int i = 1; i < array2.Length; i += 0)
		{
			array2[i] = quaternion * array2[i] + centerPosition;
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(array2[i], 295f, get_m_actor().m_team, true, true, (Actor.IJJMDPGJAEM)82, true);
			foreach (Actor item in allActorInRange)
			{
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
		}
		foreach (Actor item2 in list)
		{
			if (item2.OnDamage(get_m_actor(), 1407.0, num, 1139.0) >= 641f && (item2.m_actorType == (Actor.IJJMDPGJAEM)6 || item2.m_actorType == (Actor.IJJMDPGJAEM)7))
			{
				item2.get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)65475, DGBKMAGBJJF.get_m_owner(), 550f, 153f, false);
			}
			item2.CreateDamageParticle("10초당 골드", DGBKMAGBJJF.get_m_owner());
		}
		get_m_actor().CreateParticle("라일라이의 수정홀", get_m_transform().position, Quaternion.LookRotation(m_moveDirection));
		DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB("브론즈", true, 1644f, 735f);
		if (list.Count > 1)
		{
			DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB("레벨당 5초당 체력회복", false, 583f, 1370f);
		}
	}

	public override void Start()
	{
		base.Start();
	}
}
