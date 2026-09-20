using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using EveEngine;
using GameServer;
using UnityEngine;

public class RivenSM : HumanSM
{
	public GameObject m_swordObject;

	private int GOGLNMODMLA;

	private int BPOJGPONFMK;

	private float HBHEKAFLJCJ;

	private ObscuredInt EEDJONAHNBL;

	private ObscuredBool BJJPALOBBGD = false;

	[CompilerGenerated]
	private void ECICOJHGLLB()
	{
		OnAnimationEventSkill(3);
	}

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
		{
			double num = (double)get_m_actor().get_m_phy_att() * (0.4 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 0.05);
			num += 10.0 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 20.0;
			if (BPOJGPONFMK < 3)
			{
				List<Actor> actorListInAttackRange = ActorManager.get_Instance().GetActorListInAttackRange(get_m_actor(), 2.25f, 90f, false, true, (Actor.IJJMDPGJAEM)14, true);
				for (int i = 0; i < actorListInAttackRange.Count; i++)
				{
					Actor actor = actorListInAttackRange[i];
					actor.OnDamage(get_m_actor(), num, 0.0);
					IAKBNJEFLAN(actor);
					actor.CreateDamageParticle("Particle/Riven/skill_hit", get_m_actor());
				}
				if (actorListInAttackRange.Count > 0)
				{
					get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_hit");
					ONLBEFEBEBG();
				}
			}
			else if (BPOJGPONFMK == 3)
			{
				List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 3f, false, true, (Actor.IJJMDPGJAEM)14);
				List<int> list = new List<int>();
				for (int j = 0; j < allActorInRange.Count; j++)
				{
					Actor actor2 = allActorInRange[j];
					if (actor2.OnDamage(get_m_actor(), num, 0.0) >= 0f && actor2.m_actorType != Actor.IJJMDPGJAEM.Turret && !actor2.IsDeath() && actor2.get_m_view() != null)
					{
						list.Add(actor2.get_m_view().get_viewID());
					}
					actor2.CreateDamageParticle("Particle/Riven/skill_hit", get_m_actor());
				}
				if (allActorInRange.Count > 0)
				{
					get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_hit");
					ONLBEFEBEBG();
				}
				if (list.Count > 0 && get_m_view().IsMine())
				{
					get_m_view().RPC("Skill0_3Rpc", DJJPAPENCLN.All, list.ToArray());
				}
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_2_ground");
			}
			string nCADFOBAFJD = string.Empty;
			if (get_m_actor().m_heroCostumeID == 0)
			{
				if (BPOJGPONFMK == 1)
				{
					nCADFOBAFJD = string.Format("Particle/{0}/skill0_0_1", get_m_actor().get_m_resourceName());
				}
				else if (BPOJGPONFMK == 2)
				{
					nCADFOBAFJD = string.Format("Particle/{0}/skill0_1_1", get_m_actor().get_m_resourceName());
				}
				else if (BPOJGPONFMK == 3)
				{
					nCADFOBAFJD = string.Format("Particle/{0}/skill0_2_1", get_m_actor().get_m_resourceName());
				}
			}
			else if (get_m_actor().m_heroCostumeID == 1)
			{
				if (BPOJGPONFMK == 1)
				{
					nCADFOBAFJD = string.Format("Particle/{0}/skill0_0_1_c1", get_m_actor().get_m_resourceName());
				}
				else if (BPOJGPONFMK == 2)
				{
					nCADFOBAFJD = string.Format("Particle/{0}/skill0_1_1_c1", get_m_actor().get_m_resourceName());
				}
				else if (BPOJGPONFMK == 3)
				{
					nCADFOBAFJD = string.Format("Particle/{0}/skill0_2_1_c1", get_m_actor().get_m_resourceName());
				}
			}
			get_m_actor().CreateParticle(nCADFOBAFJD, false);
			break;
		}
		case 3:
		{
			Vector3 centerPosition = get_m_actor().GetCenterPosition();
			centerPosition += m_direction * 1.8f;
			if (get_m_view().IsMine())
			{
				get_m_view().RPC("CreateSkill3Missile", DJJPAPENCLN.All, centerPosition, m_direction);
			}
			break;
		}
		}
	}

	public void OnDisableSkill0()
	{
		GetCastSkill(0).IHKCKBJBEGF = 0f;
	}

	public void OnAnimationEventAttack()
	{
		Actor target = get_m_target();
		if (target != null)
		{
			target.OnAttackDamage(get_m_actor());
			if (target.m_actorType != Actor.IJJMDPGJAEM.Turret)
			{
				int num = EEDJONAHNBL;
				if (num > 0)
				{
					EEDJONAHNBL = num - 1;
					int num2 = get_m_actor().get_Level() / 3;
					double hKMFCFABKGI = (double)get_m_actor().get_m_phy_att() * (0.2 + (double)num2 * 0.05);
					target.OnDamage(get_m_actor(), hKMFCFABKGI, 0.0);
					target.CreateDamageParticle("Particle/Riven/skill_hit", get_m_actor());
				}
			}
			if (get_m_actor().m_heroCostumeID == 0)
			{
				target.CreateDamageParticle("Particle/Riven/hit", get_m_actor());
			}
			else if (get_m_actor().m_heroCostumeID == 1)
			{
				target.CreateDamageParticle("Particle/Riven/hit_c1", get_m_actor());
			}
			IAKBNJEFLAN(target);
			switch (GOGLNMODMLA)
			{
			case 0:
				get_m_actor().m_multiSound.LKLFMNKDLHJ("hit");
				break;
			case 1:
				get_m_actor().m_multiSound.LKLFMNKDLHJ("hit2");
				break;
			case 2:
				get_m_actor().m_multiSound.LKLFMNKDLHJ("hit3");
				break;
			}
		}
		OnAttack();
	}

	public override void OnUpdateSkill()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 0:
			HBHEKAFLJCJ += get_m_actor().get_m_elapsedTime();
			if (HBHEKAFLJCJ < 0.28f)
			{
				Move(9f, m_direction);
			}
			break;
		case 2:
			Move(10f, m_direction);
			break;
		case 1:
			break;
		}
	}

	public void PFEHLFDNHGP()
	{
		m_swordObject.SetActive(true);
		CMAHCODBACL(8).IHKCKBJBEGF = 277f;
	}

	private void MGPGBCCDLLG()
	{
		OnAnimationEventSkill(8);
	}

	[CompilerGenerated]
	private void CFMPENLLFDP()
	{
		OnAnimationEventSkill(0);
	}

	public override void OnEnterSkill()
	{
		string nCADFOBAFJD = string.Empty;
		IDBJEMGIJEM = 0f;
		switch (get_m_skill())
		{
		case 0:
			if (!get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.RivenSkill0))
			{
				BPOJGPONFMK = 1;
				get_m_actor().get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.RivenSkill0);
			}
			else
			{
				get_m_actor().get_m_buffsInfo().KHFDBEEGPIL(JGOOOBHDBCG.ACPICCBBPHF.RivenSkill0);
				get_m_actor().get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.RivenSkill0);
				BPOJGPONFMK++;
			}
			if (BPOJGPONFMK == 1)
			{
				get_m_actor().SetAnimation("skill0_0");
				if (get_m_actor().m_heroCostumeID == 0)
				{
					nCADFOBAFJD = string.Format("Particle/{0}/skill0_0", get_m_actor().get_m_resourceName());
				}
				else if (get_m_actor().m_heroCostumeID == 1)
				{
					nCADFOBAFJD = string.Format("Particle/{0}/skill0_0_c1", get_m_actor().get_m_resourceName());
				}
			}
			else if (BPOJGPONFMK == 2)
			{
				get_m_actor().SetAnimation("skill0_1");
				if (get_m_actor().m_heroCostumeID == 0)
				{
					nCADFOBAFJD = string.Format("Particle/{0}/skill0_1", get_m_actor().get_m_resourceName());
				}
				else if (get_m_actor().m_heroCostumeID == 0)
				{
					nCADFOBAFJD = string.Format("Particle/{0}/skill0_1_c1", get_m_actor().get_m_resourceName());
				}
			}
			else if (BPOJGPONFMK == 3)
			{
				get_m_actor().SetAnimation("skill0_2");
				if (get_m_actor().m_heroCostumeID == 0)
				{
					nCADFOBAFJD = string.Format("Particle/{0}/skill0_2", get_m_actor().get_m_resourceName());
				}
				else if (get_m_actor().m_heroCostumeID == 1)
				{
					nCADFOBAFJD = string.Format("Particle/{0}/skill0_2_c1", get_m_actor().get_m_resourceName());
				}
				get_m_actor().m_navMeshAgent.enabled = false;
			}
			HBHEKAFLJCJ = 0f;
			get_m_actor().m_attackElapsedTime = get_m_actor().get_m_attackCoolTime() - 0.3f;
			get_m_actor().CreateParticle(nCADFOBAFJD, false);
			get_m_actor().m_multiSound.LKLFMNKDLHJ(string.Format("skill0_{0}", BPOJGPONFMK - 1));
			if (Random.Range(0f, 1f) < 0.3f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_voice");
			}
			break;
		case 1:
		{
			get_m_actor().SetAnimation(string.Format("skill{0}", get_m_skill()));
			double num = (double)get_m_actor().get_m_phy_att_add() * 1.0;
			num += 50.0 + (double)(get_m_actor().GetSkillLevel(1) - 1) * 30.0;
			float num2 = 0f;
			if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.RivenSkill3))
			{
				num2 = 0.75f;
			}
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 3f + num2, false, true, (Actor.IJJMDPGJAEM)14);
			for (int i = 0; i < allActorInRange.Count; i++)
			{
				Actor actor = allActorInRange[i];
				if (actor.OnDamage(get_m_actor(), num, 0.0) >= 0f && !actor.IsDeath())
				{
					actor.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Stun, null, 0.75f);
				}
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1");
			if (allActorInRange.Count > 0)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_hit");
				ONLBEFEBEBG();
			}
			if (get_m_actor().m_heroCostumeID == 0)
			{
				nCADFOBAFJD = string.Format("Particle/{0}/skill{1}", get_m_actor().get_m_resourceName(), get_m_skill());
			}
			else if (get_m_actor().m_heroCostumeID == 1)
			{
				nCADFOBAFJD = string.Format("Particle/{0}/skill{1}_c1", get_m_actor().get_m_resourceName(), get_m_skill());
			}
			get_m_actor().CreateParticle(nCADFOBAFJD, false);
			break;
		}
		case 2:
			get_m_actor().SetAnimation(string.Format("skill{0}", get_m_skill()));
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_voice");
			break;
		case 3:
			if (!LFNNHEEJNGP[3].IOCIDGEFJIC)
			{
				get_m_actor().SetAnimation("skill3_0");
				get_m_actor().get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.RivenSkill3);
				m_swordObject.SetActive(true);
				if (get_m_actor().m_heroCostumeID == 0)
				{
					nCADFOBAFJD = string.Format("Particle/{0}/skill3_0", get_m_actor().get_m_resourceName());
				}
				else if (get_m_actor().m_heroCostumeID == 1)
				{
					nCADFOBAFJD = string.Format("Particle/{0}/skill3_0_c1", get_m_actor().get_m_resourceName());
				}
				get_m_actor().CreateParticle(nCADFOBAFJD, false);
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_0");
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_0_voice");
				LFNNHEEJNGP[3].DAGNGJLGMNI();
			}
			else
			{
				get_m_actor().SetAnimation("skill3_1");
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_1");
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_1_voice");
			}
			break;
		}
	}

	private void NHBNCHDMBLD()
	{
		OnAnimationEventSkill(2);
	}

	public override void OnLeaveSkill()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			if (BPOJGPONFMK < 3 && get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.RivenSkill0))
			{
				LFNNHEEJNGP[0].IHKCKBJBEGF = LFNNHEEJNGP[0].ABOBEAIIBND(get_m_actor(), get_m_actor().GetSkillLevel(0));
				LFNNHEEJNGP[0].BELPBCDOPBA = 0;
			}
			if (BPOJGPONFMK >= 3)
			{
				get_m_actor().get_m_buffsInfo().KHFDBEEGPIL(JGOOOBHDBCG.ACPICCBBPHF.RivenSkill0);
				BPOJGPONFMK = 0;
			}
			get_m_actor().m_navMeshAgent.enabled = true;
			break;
		case 2:
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.RivenSkill2);
			break;
		case 3:
			break;
		case 1:
			break;
		}
	}

	public void OnDisableSkill3_0()
	{
		m_swordObject.SetActive(false);
		GetCastSkill(3).IHKCKBJBEGF = 0f;
	}

	public override void Init()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 12f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = -0.25f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 0;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[0].GNAAGGJGBBG = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 11f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 0;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[2].FILHECEKNMK = 10f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 0;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Double;
		LFNNHEEJNGP[3].FILHECEKNMK = 110f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = -30f;
		LFNNHEEJNGP[3].BELPBCDOPBA = 0;
		LFNNHEEJNGP[3].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[3].GIBEDKCNAJL = 15f;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
		get_m_actor().m_actorAniEvent.add_m_skill0Event(() =>
		{
			OnAnimationEventSkill(0);
		});
		get_m_actor().m_actorAniEvent.add_m_skill1Event(() =>
		{
			OnAnimationEventSkill(1);
		});
		get_m_actor().m_actorAniEvent.add_m_skill2Event(() =>
		{
			OnAnimationEventSkill(2);
		});
		get_m_actor().m_actorAniEvent.add_m_skill3Event(() =>
		{
			OnAnimationEventSkill(3);
		});
		EEDJONAHNBL = 0;
		m_swordObject.SetActive(false);
	}

	public void FJDGLMALLDN()
	{
		m_swordObject.SetActive(true);
		GetCastSkill(1).IHKCKBJBEGF = 92f;
	}

	public virtual void FAHKJKDPHCA()
	{
		get_m_actor().CreateParticle(string.Format("orderId", get_m_actor().get_m_resourceName()), false);
		GOGLNMODMLA = Random.Range(1, 4);
		if ((int)EEDJONAHNBL > 1)
		{
			GOGLNMODMLA = 5;
		}
		switch (GOGLNMODMLA)
		{
		case 0:
			get_m_actor().SetAnimation("igaworks:addToCartBulk >> total result is");
			get_m_actor().m_multiSound.DDONMGBLLJB("SlowRotate", true, 544f, 1991f);
			break;
		case 1:
			get_m_actor().CJNCFNACFDP("attack3");
			get_m_actor().m_multiSound.DDONMGBLLJB("\n\n", false, 1750f, 1968f);
			break;
		case 2:
			get_m_actor().CJNCFNACFDP("Particle/{0}/skill0_2_c1");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("닉네임 변경에 성공하였어요!", false, 1848f, 929f);
			break;
		}
		if (Random.Range(1149f, 985f) < 346f)
		{
			get_m_actor().m_multiSound.ICNAJBHLIGO("UnityEngine.", true, 1828f, 1287f);
		}
		float num = 203f;
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.BlackCleaver))
		{
			num = 858f;
		}
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range() + num, 1810f, true, true, (Actor.IJJMDPGJAEM)(-10));
		if (actorInAttackRange == null)
		{
			actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range() + num, 1428f, false, false, (Actor.IJJMDPGJAEM)(-19));
			if (actorInAttackRange != null)
			{
				SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
			}
		}
		SetTarget(actorInAttackRange);
	}

	[JDLHECHNNDH]
	public void CreateSkill3Missile(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		string nCADFOBAFJD = "skill3_1_missile";
		if (get_m_actor().m_heroCostumeID == 1)
		{
			nCADFOBAFJD = "skill3_1_missile_c1";
		}
		Actor actor = get_m_actor().CreateMissile(nCADFOBAFJD, HEPNHCEIFMO, null);
		RivenSkill3MissileAI component = actor.GetComponent<RivenSkill3MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
		Actor actor2 = get_m_actor().CreateMissile(nCADFOBAFJD, HEPNHCEIFMO, null);
		RivenSkill3MissileAI component2 = actor2.GetComponent<RivenSkill3MissileAI>();
		component2.m_moveDirection = Quaternion.Euler(0f, 25f, 0f) * IJMNFOGNFAC;
		Actor actor3 = get_m_actor().CreateMissile(nCADFOBAFJD, HEPNHCEIFMO, null);
		RivenSkill3MissileAI component3 = actor3.GetComponent<RivenSkill3MissileAI>();
		component3.m_moveDirection = Quaternion.Euler(0f, -25f, 0f) * IJMNFOGNFAC;
		component.InsertOtherMissile(component2);
		component.InsertOtherMissile(component3);
		component2.InsertOtherMissile(component);
		component2.InsertOtherMissile(component3);
		component3.InsertOtherMissile(component);
		component3.InsertOtherMissile(component2);
	}

	[CompilerGenerated]
	private void DJDBAIIPJFM()
	{
		OnAnimationEventSkill(2);
	}

	[CompilerGenerated]
	private void BPGMFJMMOCL()
	{
		OnAnimationEventSkill(1);
	}

	private void GNMODMNCDME()
	{
		int num = EEDJONAHNBL;
		if (num < 3)
		{
			EEDJONAHNBL = num + 1;
		}
	}

	[JDLHECHNNDH]
	public void Skill0_3Rpc(int[] HMNPPLAEPBF)
	{
		foreach (int kPNEBLJJGEA in HMNPPLAEPBF)
		{
			EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(kPNEBLJJGEA);
			if (!(eveView == null))
			{
				Actor component = eveView.GetComponent<Actor>();
				if (!(component == null) && !component.IsDeath())
				{
					component.GetHumanSM().Float(Vector3.zero, 8f);
				}
			}
		}
	}

	public override void OnEnterAttack()
	{
		get_m_actor().CreateParticle(string.Format("Particle/{0}/attack", get_m_actor().get_m_resourceName()), false);
		GOGLNMODMLA = Random.Range(0, 2);
		if ((int)EEDJONAHNBL > 0)
		{
			GOGLNMODMLA = 2;
		}
		switch (GOGLNMODMLA)
		{
		case 0:
			get_m_actor().SetAnimation("attack");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
			break;
		case 1:
			get_m_actor().SetAnimation("attack2");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2");
			break;
		case 2:
			get_m_actor().SetAnimation("attack3");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack3");
			break;
		}
		if (Random.Range(0f, 1f) < 0.3f)
		{
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack_voice");
		}
		float num = 0f;
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.RivenSkill3))
		{
			num = 0.75f;
		}
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range() + num, 45f, false);
		if (actorInAttackRange == null)
		{
			actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range() + num, 180f, false);
			if (actorInAttackRange != null)
			{
				SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
			}
		}
		SetTarget(actorInAttackRange);
	}

	private void ONLBEFEBEBG()
	{
		int num = EEDJONAHNBL;
		if (num < 3)
		{
			EEDJONAHNBL = num + 1;
		}
	}

	public void JCNICMLKOED(int[] HMNPPLAEPBF)
	{
		for (int i = 1; i < HMNPPLAEPBF.Length; i++)
		{
			int kPNEBLJJGEA = HMNPPLAEPBF[i];
			EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(kPNEBLJJGEA);
			if (!(eveView == null))
			{
				Actor component = eveView.GetComponent<Actor>();
				if (!(component == null) && !component.IsDeath())
				{
					component.GetHumanSM().Float(Vector3.zero, 1328f);
				}
			}
		}
	}
}
