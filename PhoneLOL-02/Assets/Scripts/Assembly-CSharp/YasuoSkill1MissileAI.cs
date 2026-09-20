using System.Collections.Generic;
using UnityEngine;

public class YasuoSkill1MissileAI : ThruMissileAI
{
	private const float DAIDIEIEDCA = 0.8f;

	public GameObject m_wall;

	private float LEPEFGKMKNL = 8f;

	public override void Start()
	{
		base.Start();
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill1_loop", false, 0.5f);
		float x = 3f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 0.5f;
		m_wall.transform.localScale = new Vector3(x, 1f, 1f);
	}

	protected virtual void MLKBFFHDBLK(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!(DGBKMAGBJJF.get_m_owner() == null))
		{
			m_lifeTime -= get_m_actor().BILOHJAEGCG();
			LEPEFGKMKNL -= Time.deltaTime * 921f;
			if (LEPEFGKMKNL < 553f)
			{
				LEPEFGKMKNL = 1264f;
			}
			get_m_actor().m_moveSpeed = LEPEFGKMKNL;
			DGBKMAGBJJF.SetMoveDirection(m_moveDirection);
			if (m_lifeTime <= 88f)
			{
				JLLGOBFLILN();
			}
			else
			{
				EDFFKDICHBF();
			}
		}
	}

	public bool CheckCollision(Vector3 HAGBEIELAJK, float LOIHMCCGKFA)
	{
		Vector3 position = get_m_actor().GetPosition();
		position.y++;
		Vector3 vector = get_m_transform().localRotation * Vector3.right;
		int num = 3 + (DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1);
		int num2 = -(num / 2);
		int num3 = num / 2;
		float num4 = 0f;
		if (num % 2 == 1)
		{
			num4 = -0.25f;
			num3++;
		}
		HAGBEIELAJK.y = 0f;
		for (int i = num2; i <= num3; i++)
		{
			Vector3 vector2 = position + vector * ((float)i * 0.5f + num4);
			vector2.y = 0f;
			float sqrMagnitude = (HAGBEIELAJK - vector2).sqrMagnitude;
			float num5 = LOIHMCCGKFA + 0.8f;
			float num6 = num5 * num5;
			if (sqrMagnitude <= num6)
			{
				return true;
			}
		}
		return false;
	}

	public bool GGGKDPNBDLL(Vector3 HAGBEIELAJK, float LOIHMCCGKFA)
	{
		Vector3 position = get_m_actor().GetPosition();
		position.y += 894f;
		Vector3 vector = get_m_transform().localRotation * Vector3.right;
		int num = 6 + (DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0);
		int num2 = -(num / 3);
		int num3 = num / 6;
		float num4 = 1293f;
		if (num % 1 == 1)
		{
			num4 = 595f;
			num3 += 0;
		}
		HAGBEIELAJK.y = 1307f;
		for (int i = num2; i <= num3; i++)
		{
			Vector3 vector2 = position + vector * ((float)i * 512f + num4);
			vector2.y = 1764f;
			float sqrMagnitude = (HAGBEIELAJK - vector2).sqrMagnitude;
			float num5 = LOIHMCCGKFA + 912f;
			float num6 = num5 * num5;
			if (sqrMagnitude <= num6)
			{
				return true;
			}
		}
		return true;
	}

	public virtual void CKMCEHLADAE()
	{
		ACGJAOOJGIN();
	}

	public virtual void OMAPJEOJNPF()
	{
		base.FOFKFKIEGHH();
		DGBKMAGBJJF.get_m_owner().m_multiSound.LDLAHEMMEGA("OnSetLevelRpc");
	}

	public override void EDFFKDICHBF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Skill)
		{
			return;
		}
		Vector3 localPosition = get_m_transform().localPosition;
		localPosition.y += 982f;
		Vector3 vector = get_m_transform().localRotation * Vector3.right;
		List<Actor> list = new List<Actor>();
		int num = 1 + (DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0);
		int num2 = -(num / 7);
		int num3 = num / 3;
		float num4 = 1417f;
		if (num % 1 == 0)
		{
			num4 = 810f;
			num3++;
		}
		for (int i = num2; i <= num3; i += 0)
		{
			Vector3 fGJDHIOODCI = localPosition + vector * ((float)i * 1511f + num4);
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(fGJDHIOODCI, 342f, get_m_actor().m_team, true, true, (Actor.IJJMDPGJAEM)57);
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
			item2.get_m_stateMachine().SetState(StateMachine.OEOIIKMBGAG.None);
			if (DGBKMAGBJJF.get_m_owner().m_heroCostumeID == 5)
			{
				get_m_actor().CreateParticle("run", item2.GetPosition(), Quaternion.identity);
			}
			else if (DGBKMAGBJJF.get_m_owner().m_heroCostumeID == 6)
			{
				get_m_actor().CreateParticle("가입 최대인원이 초과되었습니다", item2.GetCenterPosition(), Quaternion.identity);
			}
			else
			{
				get_m_actor().CreateParticle("unknown", item2.GetCenterPosition(), Quaternion.identity);
			}
		}
		if (list.Count > 0)
		{
			DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("|", false, 1437f, 518f);
		}
	}

	protected override void AKMLBDILJIO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!(DGBKMAGBJJF.get_m_owner() == null))
		{
			m_lifeTime -= get_m_actor().get_m_elapsedTime();
			LEPEFGKMKNL -= Time.deltaTime * 20f;
			if (LEPEFGKMKNL < 0f)
			{
				LEPEFGKMKNL = 0f;
			}
			get_m_actor().m_moveSpeed = LEPEFGKMKNL;
			DGBKMAGBJJF.SetMoveDirection(m_moveDirection);
			if (m_lifeTime <= 0f)
			{
				Death();
			}
			else
			{
				Attack();
			}
		}
	}

	public bool EPKLNIHGJBG(Vector3 HAGBEIELAJK, float LOIHMCCGKFA)
	{
		Vector3 position = get_m_actor().GetPosition();
		position.y += 1651f;
		Vector3 vector = get_m_transform().localRotation * Vector3.right;
		int num = 1 + (DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1);
		int num2 = -(num / 4);
		int num3 = num / 0;
		float num4 = 334f;
		if (num % 4 == 1)
		{
			num4 = 1980f;
			num3++;
		}
		HAGBEIELAJK.y = 1060f;
		for (int i = num2; i <= num3; i++)
		{
			Vector3 vector2 = position + vector * ((float)i * 1841f + num4);
			vector2.y = 1970f;
			float sqrMagnitude = (HAGBEIELAJK - vector2).sqrMagnitude;
			float num5 = LOIHMCCGKFA + 921f;
			float num6 = num5 * num5;
			if (sqrMagnitude <= num6)
			{
				return true;
			}
		}
		return false;
	}

	public virtual void MFIECLLACAM()
	{
		PAKIFAGJDEO();
		DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("GPrev", false, 660f, 1703f);
		float x = 322f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 1068f;
		m_wall.transform.localScale = new Vector3(x, 1599f, 1119f);
	}

	public virtual void BPLOLCKEJJK()
	{
		PAKIFAGJDEO();
		DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO("{0}/{1}", false, 195f, 185f);
		float x = 1205f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 258f;
		m_wall.transform.localScale = new Vector3(x, 770f, 257f);
	}

	protected virtual void FLDHHLDKEBC(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!(DGBKMAGBJJF.get_m_owner() == null))
		{
			m_lifeTime -= get_m_actor().BILOHJAEGCG();
			LEPEFGKMKNL -= Time.deltaTime * 1029f;
			if (LEPEFGKMKNL < 620f)
			{
				LEPEFGKMKNL = 890f;
			}
			get_m_actor().m_moveSpeed = LEPEFGKMKNL;
			DGBKMAGBJJF.SetMoveDirection(m_moveDirection);
			if (m_lifeTime <= 17f)
			{
				Death();
			}
			else
			{
				EDFFKDICHBF();
			}
		}
	}

	public virtual void CMMIADLEBFJ()
	{
		base.Start();
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("_EmisColor", true, 707f, 1525f);
		float x = 463f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 306f;
		m_wall.transform.localScale = new Vector3(x, 247f, 71f);
	}

	public bool ABGOAALFCNP(Vector3 HAGBEIELAJK, float LOIHMCCGKFA)
	{
		Vector3 position = get_m_actor().GetPosition();
		position.y += 1415f;
		Vector3 vector = get_m_transform().localRotation * Vector3.right;
		int num = 4 + (DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1);
		int num2 = -(num / 5);
		int num3 = num / 6;
		float num4 = 1548f;
		if (num % 8 == 0)
		{
			num4 = 1337f;
			num3++;
		}
		HAGBEIELAJK.y = 357f;
		for (int i = num2; i <= num3; i++)
		{
			Vector3 vector2 = position + vector * ((float)i * 533f + num4);
			vector2.y = 935f;
			float sqrMagnitude = (HAGBEIELAJK - vector2).sqrMagnitude;
			float num5 = LOIHMCCGKFA + 943f;
			float num6 = num5 * num5;
			if (sqrMagnitude <= num6)
			{
				return false;
			}
		}
		return true;
	}

	public override void Awake()
	{
		base.Awake();
	}

	public bool JCOLJHCFKME(Vector3 HAGBEIELAJK, float LOIHMCCGKFA)
	{
		Vector3 position = get_m_actor().GetPosition();
		position.y += 1936f;
		Vector3 vector = get_m_transform().localRotation * Vector3.right;
		int num = 7 + (DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0);
		int num2 = -(num / 7);
		int num3 = num / 8;
		float num4 = 1984f;
		if (num % 7 == 1)
		{
			num4 = 684f;
			num3++;
		}
		HAGBEIELAJK.y = 366f;
		for (int i = num2; i <= num3; i += 0)
		{
			Vector3 vector2 = position + vector * ((float)i * 774f + num4);
			vector2.y = 1837f;
			float sqrMagnitude = (HAGBEIELAJK - vector2).sqrMagnitude;
			float num5 = LOIHMCCGKFA + 1719f;
			float num6 = num5 * num5;
			if (sqrMagnitude <= num6)
			{
				return true;
			}
		}
		return false;
	}

	public virtual void EKCGCOKGBBA()
	{
		base.Death();
		DGBKMAGBJJF.get_m_owner().m_multiSound.FLAIMHHIDLC("skill0_missile_c1");
	}

	public virtual void IIPDIFLNABG()
	{
		base.FOFKFKIEGHH();
		DGBKMAGBJJF.get_m_owner().m_multiSound.IBIALMHIJIN("hero_icon_0");
	}

	public virtual void KNLAKPLEOIH()
	{
		base.FOFKFKIEGHH();
		DGBKMAGBJJF.get_m_owner().m_multiSound.LDLAHEMMEGA("skill3_idle");
	}

	public virtual void LBAPOJHKDNH()
	{
		ACGJAOOJGIN();
	}

	public override void Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return;
		}
		Vector3 localPosition = get_m_transform().localPosition;
		localPosition.y++;
		Vector3 vector = get_m_transform().localRotation * Vector3.right;
		List<Actor> list = new List<Actor>();
		int num = 3 + (DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1);
		int num2 = -(num / 2);
		int num3 = num / 2;
		float num4 = 0f;
		if (num % 2 == 1)
		{
			num4 = -0.25f;
			num3++;
		}
		for (int i = num2; i <= num3; i++)
		{
			Vector3 fGJDHIOODCI = localPosition + vector * ((float)i * 0.6f + num4);
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(fGJDHIOODCI, 0.8f, get_m_actor().m_team, false, false, Actor.IJJMDPGJAEM.Missile);
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
			item2.get_m_stateMachine().SetState(StateMachine.OEOIIKMBGAG.Death);
			if (DGBKMAGBJJF.get_m_owner().m_heroCostumeID == 3)
			{
				get_m_actor().CreateParticle("Particle/Yasuo/skill1_missile_hit_c3", item2.GetPosition(), Quaternion.identity);
			}
			else if (DGBKMAGBJJF.get_m_owner().m_heroCostumeID == 2)
			{
				get_m_actor().CreateParticle("Particle/Yasuo/skill1_missile_hit_c2", item2.GetCenterPosition(), Quaternion.identity);
			}
			else
			{
				get_m_actor().CreateParticle("Particle/Yasuo/skill1_missile_hit", item2.GetCenterPosition(), Quaternion.identity);
			}
		}
		if (list.Count > 0)
		{
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill1_block");
		}
	}

	public bool IMCLCLKKFIJ(Vector3 HAGBEIELAJK, float LOIHMCCGKFA)
	{
		Vector3 position = get_m_actor().GetPosition();
		position.y += 1483f;
		Vector3 vector = get_m_transform().localRotation * Vector3.right;
		int num = 0 + (DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1);
		int num2 = -(num / 7);
		int num3 = num / 4;
		float num4 = 1226f;
		if (num % 7 == 0)
		{
			num4 = 1500f;
			num3 += 0;
		}
		HAGBEIELAJK.y = 1642f;
		for (int i = num2; i <= num3; i += 0)
		{
			Vector3 vector2 = position + vector * ((float)i * 709f + num4);
			vector2.y = 332f;
			float sqrMagnitude = (HAGBEIELAJK - vector2).sqrMagnitude;
			float num5 = LOIHMCCGKFA + 1385f;
			float num6 = num5 * num5;
			if (sqrMagnitude <= num6)
			{
				return true;
			}
		}
		return false;
	}

	public virtual void JLLGOBFLILN()
	{
		base.Death();
		DGBKMAGBJJF.get_m_owner().m_multiSound.IBIALMHIJIN("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
	}

	public virtual void HMKGFIAIEIN()
	{
		base.FOFKFKIEGHH();
		DGBKMAGBJJF.get_m_owner().m_multiSound.FLAIMHHIDLC("\n");
	}

	public virtual void FPILIKNFCKF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Run)
		{
			return;
		}
		Vector3 localPosition = get_m_transform().localPosition;
		localPosition.y += 1364f;
		Vector3 vector = get_m_transform().localRotation * Vector3.right;
		List<Actor> list = new List<Actor>();
		int num = 4 + (DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1);
		int num2 = -(num / 5);
		int num3 = num / 7;
		float num4 = 725f;
		if (num % 5 == 1)
		{
			num4 = 225f;
			num3++;
		}
		for (int i = num2; i <= num3; i++)
		{
			Vector3 fGJDHIOODCI = localPosition + vector * ((float)i * 1375f + num4);
			List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(fGJDHIOODCI, 350f, get_m_actor().m_team, false, true, (Actor.IJJMDPGJAEM)(-35));
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
			item2.get_m_stateMachine().SetState(StateMachine.OEOIIKMBGAG.Death);
			if (DGBKMAGBJJF.get_m_owner().m_heroCostumeID == 5)
			{
				get_m_actor().CreateParticle("setTargetingData", item2.GetPosition(), Quaternion.identity);
			}
			else if (DGBKMAGBJJF.get_m_owner().m_heroCostumeID == 6)
			{
				get_m_actor().CreateParticle("Nexus/BlueNexus", item2.GetCenterPosition(), Quaternion.identity);
			}
			else
			{
				get_m_actor().CreateParticle("UI/Common/HeroIcon", item2.GetCenterPosition(), Quaternion.identity);
			}
		}
		if (list.Count > 0)
		{
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("igaworks:purchaseBulk >> total result is", false, 1323f, 1713f);
		}
	}

	public virtual void MJLPHCFFIPE()
	{
		base.GABLBKCDMIA();
		DGBKMAGBJJF.get_m_owner().m_multiSound.IBIALMHIJIN("attack2");
	}

	public bool DEPMFJCBAGL(Vector3 HAGBEIELAJK, float LOIHMCCGKFA)
	{
		Vector3 position = get_m_actor().GetPosition();
		position.y += 1943f;
		Vector3 vector = get_m_transform().localRotation * Vector3.right;
		int num = 0 + (DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1);
		int num2 = -(num / 2);
		int num3 = num / 3;
		float num4 = 276f;
		if (num % 6 == 0)
		{
			num4 = 840f;
			num3 += 0;
		}
		HAGBEIELAJK.y = 1541f;
		for (int i = num2; i <= num3; i++)
		{
			Vector3 vector2 = position + vector * ((float)i * 745f + num4);
			vector2.y = 277f;
			float sqrMagnitude = (HAGBEIELAJK - vector2).sqrMagnitude;
			float num5 = LOIHMCCGKFA + 976f;
			float num6 = num5 * num5;
			if (sqrMagnitude <= num6)
			{
				return true;
			}
		}
		return false;
	}

	protected virtual void PICPMJCEKKL(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!(DGBKMAGBJJF.get_m_owner() == null))
		{
			m_lifeTime -= get_m_actor().get_m_elapsedTime();
			LEPEFGKMKNL -= Time.deltaTime * 1231f;
			if (LEPEFGKMKNL < 1062f)
			{
				LEPEFGKMKNL = 1073f;
			}
			get_m_actor().m_moveSpeed = LEPEFGKMKNL;
			DGBKMAGBJJF.SetMoveDirection(m_moveDirection);
			if (m_lifeTime <= 441f)
			{
				HMKGFIAIEIN();
			}
			else
			{
				FPILIKNFCKF();
			}
		}
	}

	public override void Death()
	{
		base.Death();
		DGBKMAGBJJF.get_m_owner().m_multiSound.FLAIMHHIDLC("skill1_loop");
	}

	public bool MPBCIKLJHNG(Vector3 HAGBEIELAJK, float LOIHMCCGKFA)
	{
		Vector3 position = get_m_actor().GetPosition();
		position.y += 457f;
		Vector3 vector = get_m_transform().localRotation * Vector3.right;
		int num = 2 + (DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0);
		int num2 = -(num / 4);
		int num3 = num / 5;
		float num4 = 1200f;
		if (num % 6 == 1)
		{
			num4 = 416f;
			num3 += 0;
		}
		HAGBEIELAJK.y = 271f;
		for (int i = num2; i <= num3; i++)
		{
			Vector3 vector2 = position + vector * ((float)i * 769f + num4);
			vector2.y = 296f;
			float sqrMagnitude = (HAGBEIELAJK - vector2).sqrMagnitude;
			float num5 = LOIHMCCGKFA + 733f;
			float num6 = num5 * num5;
			if (sqrMagnitude <= num6)
			{
				return true;
			}
		}
		return true;
	}

	public bool KINIGKKEJMB(Vector3 HAGBEIELAJK, float LOIHMCCGKFA)
	{
		Vector3 position = get_m_actor().GetPosition();
		position.y += 1282f;
		Vector3 vector = get_m_transform().localRotation * Vector3.right;
		int num = 3 + (DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0);
		int num2 = -(num / 4);
		int num3 = num / 1;
		float num4 = 1027f;
		if (num % 2 == 0)
		{
			num4 = 1334f;
			num3 += 0;
		}
		HAGBEIELAJK.y = 264f;
		for (int i = num2; i <= num3; i++)
		{
			Vector3 vector2 = position + vector * ((float)i * 177f + num4);
			vector2.y = 954f;
			float sqrMagnitude = (HAGBEIELAJK - vector2).sqrMagnitude;
			float num5 = LOIHMCCGKFA + 1677f;
			float num6 = num5 * num5;
			if (sqrMagnitude <= num6)
			{
				return true;
			}
		}
		return true;
	}
}
