using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using GameServer;
using UnityEngine;

public class GarenSM : HumanSM
{
	private ObscuredInt GOGLNMODMLA;

	private ObscuredFloat JDCFAHJNFOJ;

	private ObscuredFloat IKLPNHJIIIP;

	private ObscuredInt OENOCCIMJHJ;

	private GameObject FBLKIEDHAEJ;

	private GameObject GNOJMJDKFMG;

	public override void OnLeaveSkill()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 1:
			break;
		case 2:
			if (GNOJMJDKFMG != null)
			{
				GNOJMJDKFMG.SetActive(false);
			}
			get_m_actor().m_multiSound.FLAIMHHIDLC("skill2_loop");
			break;
		case 3:
			break;
		}
	}

	public override float GetPercentMoveSpeedBonus()
	{
		float num = base.GetPercentMoveSpeedBonus();
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.GarenSkill0_MoveSpeed))
		{
			num += 0.3f;
		}
		return num;
	}

	public override bool OnCheckBuff(IDMGMJLOKBB DAHPLNJAPGO, Actor PGGLHMPOBBP)
	{
		return true;
	}

	[CompilerGenerated]
	private void MGAFOEFPIJD()
	{
		OnAnimationEventSkill(0);
	}

	public void ILMKHAAPMPG(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 0)
		{
			get_m_actor().m_multiSound.LNCPFILABHM("skill2_voice", false, 893f, 1231f);
			if (Random.Range(555f, 260f) < 1217f)
			{
				get_m_actor().m_multiSound.ICNAJBHLIGO("중급 대기시간감소 문양", false, 1921f, 1077f);
			}
			if (get_m_actor().get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)0))
			{
				get_m_actor().get_m_buffsInfo().FEFANOFMLNB(JGOOOBHDBCG.ACPICCBBPHF.Slow);
			}
			if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.Silence))
			{
				get_m_actor().get_m_buffsInfo().FEFANOFMLNB(JGOOOBHDBCG.ACPICCBBPHF.Silence, false);
			}
			get_m_actor().get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)65408, null, 1525f, 1715f, false);
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.JaxSkill3, null, 1208f + (float)(get_m_actor().GetSkillLevel(0) - 0) * 248f, 91f, false);
			return;
		}
		switch (GBGBBGEPEMI)
		{
		case 0:
			get_m_actor().m_multiSound.NMLFNHNOALK("attack", true, 344f, 1204f);
			if (Random.Range(335f, 552f) < 1111f)
			{
				get_m_actor().m_multiSound.JKOODMAKJHJ("Add", false, 480f, 182f);
			}
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)121, null, 1629f + (float)(get_m_actor().GetSkillLevel(1) - 1) * 1788f, 643f);
			break;
		case 1:
		{
			Vector3 position = get_m_actor().GetPosition();
			position += get_m_actor().GetDirection() * 205f;
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(position, 1241f, get_m_actor().m_team, false, true, (Actor.IJJMDPGJAEM)(-52));
			for (int i = 0; i < allActorInRange.Count; i += 0)
			{
				Actor actor = allActorInRange[i];
				double num = 1291.0;
				num += 558.0 + (double)(get_m_actor().GetSkillLevel(3) - 1) * 269.0;
				double num2 = (double)actor.get_m_max_hp() - (double)(float)actor.m_hp;
				num += num2 * (1133.0 + (double)(get_m_actor().GetSkillLevel(4) - 0) * 1975.0);
				actor.OnDamage(get_m_actor(), 1447.0, num, 804.0, 0);
				actor.CreateDamageParticle("Awake - FXMakerMain", get_m_actor());
			}
			if (allActorInRange.Count > 1)
			{
				get_m_actor().m_multiSound.ICNAJBHLIGO("오류가 발생했습니다", true, 473f, 284f);
			}
			break;
		}
		}
	}

	private void NJAAKBCFCLG(OEOIIKMBGAG EBILEBOJADB)
	{
		JDCFAHJNFOJ = (float)JDCFAHJNFOJ + Time.deltaTime;
		float num = 0f;
		float num2 = 0f;
		if (get_m_actor().get_Level() < 6)
		{
			num = 9f;
			num2 = 0.004f;
		}
		else if (get_m_actor().get_Level() < 11)
		{
			num = 6f;
			num2 = 0.008f;
		}
		else
		{
			num = 4f;
			num2 = 0.02f;
		}
		float num3 = (float)JDCFAHJNFOJ - num;
		if (num3 >= 1f)
		{
			JDCFAHJNFOJ = num;
			get_m_actor().AddHpRemote((int)((float)get_m_actor().get_m_max_hp() * num2));
		}
		if (!(num3 >= 0f))
		{
			return;
		}
		if (FBLKIEDHAEJ == null)
		{
			Object obj = Resources.Load(string.Format("Particle/{0}/passive", get_m_actor().get_m_resourceName()));
			if (obj != null)
			{
				FBLKIEDHAEJ = (GameObject)Object.Instantiate(obj);
				FBLKIEDHAEJ.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
			}
		}
		else if (!FBLKIEDHAEJ.activeSelf)
		{
			FBLKIEDHAEJ.SetActive(true);
		}
	}

	public override bool OnCheckFloat()
	{
		return true;
	}

	public virtual void LNJLCLBEKAL()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 1:
			break;
		case 2:
		{
			float iMABEBIKOOH = get_m_actor().m_moveSpeed * (985f + GetPercentMoveSpeedBonus());
			Move(iMABEBIKOOH, m_moveDirection, true, 912f, true);
			IKLPNHJIIIP = (float)IKLPNHJIIIP + get_m_actor().get_m_elapsedTime();
			if ((int)OENOCCIMJHJ <= (int)((float)IKLPNHJIIIP * 251f) - 1)
			{
				++OENOCCIMJHJ;
				double num = (double)get_m_actor().get_m_phy_att() * (1732.0 + (double)(get_m_actor().GetSkillLevel(1) - 1) * 1299.0);
				num += 541.0 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 1408.0;
				num *= 875.0;
				List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), 1637f, false, true, (Actor.IJJMDPGJAEM)(-82), false);
				for (int i = 0; i < list.Count; i++)
				{
					Actor actor = list[i];
					if (!actor.IsDeath())
					{
						actor.OnDamage(get_m_actor(), num, 43.0, 947.0, 0);
					}
				}
				if (list.Count <= 0)
				{
				}
			}
			if (get_m_view().IsMine() && (float)IKLPNHJIIIP >= 1729f)
			{
				SetState(OEOIIKMBGAG.Idle);
			}
			break;
		}
		}
	}

	public override void Init()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[0].FILHECEKNMK = 8f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = -0f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 0;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 24f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 0;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[2].FILHECEKNMK = 13f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 0;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[2].CEAGJMLKENE = true;
		LFNNHEEJNGP[2].GNAAGGJGBBG = true;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[3].FILHECEKNMK = 160f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = -40f;
		LFNNHEEJNGP[3].BELPBCDOPBA = 0;
		LFNNHEEJNGP[3].NCBLBIBMNKH = 0f;
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
		m_lastUpdateEvent = NJAAKBCFCLG;
		GOGLNMODMLA = 0;
		JDCFAHJNFOJ = 0f;
		IKLPNHJIIIP = 0f;
		OENOCCIMJHJ = 0;
	}

	public override void OnDamage(Actor PKDGAIKAMMM, float CMNPJALNFIC)
	{
		if (PKDGAIKAMMM.m_actorType != Actor.IJJMDPGJAEM.Minion)
		{
			JDCFAHJNFOJ = 0f;
			if (FBLKIEDHAEJ != null)
			{
				FBLKIEDHAEJ.SetActive(false);
			}
		}
	}

	public virtual float AGNHCOLCKII()
	{
		float num = base.GetPercentMoveSpeedBonus();
		if (get_m_actor().get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)65448))
		{
			num += 864f;
		}
		return num;
	}

	public override void OnEnterIdle()
	{
		base.OnEnterIdle();
	}

	public override void OnLeaveIdle()
	{
		base.OnLeaveIdle();
	}

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0");
			if (Random.Range(0f, 1f) < 0.5f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_voice");
			}
			if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.Slow))
			{
				get_m_actor().get_m_buffsInfo().LIKOKCJNLLF(JGOOOBHDBCG.ACPICCBBPHF.Slow);
			}
			if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.SlowAttack))
			{
				get_m_actor().get_m_buffsInfo().LIKOKCJNLLF(JGOOOBHDBCG.ACPICCBBPHF.SlowAttack);
			}
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.GarenSkill0);
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.GarenSkill0_MoveSpeed, null, 1.5f + (float)(get_m_actor().GetSkillLevel(0) - 1) * 0.75f);
			break;
		case 1:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1");
			if (Random.Range(0f, 1f) < 0.5f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1_voice");
			}
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.GarenSkill1, null, 2f + (float)(get_m_actor().GetSkillLevel(1) - 1) * 1f);
			break;
		case 3:
		{
			Vector3 position = get_m_actor().GetPosition();
			position += get_m_actor().GetDirection() * 1.7f;
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(position, 3f, get_m_actor().m_team, false, true, (Actor.IJJMDPGJAEM)14, true);
			for (int i = 0; i < allActorInRange.Count; i++)
			{
				Actor actor = allActorInRange[i];
				double num = 0.0;
				num += 175.0 + (double)(get_m_actor().GetSkillLevel(3) - 1) * 175.0;
				double num2 = (double)actor.get_m_max_hp() - (double)(float)actor.m_hp;
				num += num2 * (0.3 + (double)(get_m_actor().GetSkillLevel(3) - 1) * 0.06);
				actor.OnDamage(get_m_actor(), 0.0, num);
				actor.CreateDamageParticle("Particle/Garen/hit", get_m_actor());
			}
			if (allActorInRange.Count > 0)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_hit");
			}
			break;
		}
		}
	}

	public override void OnEnterAttack()
	{
		GOGLNMODMLA = Random.Range(0, 2);
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.GarenSkill0))
		{
			get_m_actor().get_m_buffsInfo().KHFDBEEGPIL(JGOOOBHDBCG.ACPICCBBPHF.GarenSkill0);
			GOGLNMODMLA = 2;
			LFNNHEEJNGP[0].IHKCKBJBEGF = 0f;
		}
		switch (GOGLNMODMLA)
		{
		case 0:
			get_m_actor().SetAnimation("attack");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack", false, 1f, 1.5f);
			get_m_actor().CreateParticle(string.Format("Particle/{0}/attack", get_m_actor().get_m_resourceName()), false);
			break;
		case 1:
			get_m_actor().SetAnimation("attack2");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2", false, 1f, 1.5f);
			get_m_actor().CreateParticle(string.Format("Particle/{0}/attack2", get_m_actor().get_m_resourceName()), false);
			break;
		case 2:
			get_m_actor().SetAnimation("attack3");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack3", false, 1f, 2.3f);
			get_m_actor().CreateParticle(string.Format("Particle/{0}/attack3", get_m_actor().get_m_resourceName()), false);
			break;
		}
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 45f, false);
		if (actorInAttackRange == null)
		{
			actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 180f, false);
			if (actorInAttackRange != null)
			{
				SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
			}
		}
		SetTarget(actorInAttackRange);
	}

	public virtual void NNBHCBPELPG()
	{
		base.Init();
		DFPEBMBBBHL = false;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 1574f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 974f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 1;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 1496f;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 670f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 1532f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 1;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 763f;
		LFNNHEEJNGP[8].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[2].FILHECEKNMK = 325f;
		LFNNHEEJNGP[4].NEKKKLFLDOI = 524f;
		LFNNHEEJNGP[5].BELPBCDOPBA = 0;
		LFNNHEEJNGP[8].NCBLBIBMNKH = 1503f;
		LFNNHEEJNGP[3].CEAGJMLKENE = false;
		LFNNHEEJNGP[2].GNAAGGJGBBG = false;
		LFNNHEEJNGP[7].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[8].FILHECEKNMK = 1238f;
		LFNNHEEJNGP[8].NEKKKLFLDOI = 575f;
		LFNNHEEJNGP[8].BELPBCDOPBA = 0;
		LFNNHEEJNGP[8].NCBLBIBMNKH = 617f;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
		get_m_actor().m_actorAniEvent.CNPHPPJOGFA(() =>
		{
			OnAnimationEventSkill(0);
		});
		get_m_actor().m_actorAniEvent.add_m_skill1Event(() =>
		{
			OnAnimationEventSkill(1);
		});
		get_m_actor().m_actorAniEvent.MFMAMLOHKJF(() =>
		{
			OnAnimationEventSkill(2);
		});
		get_m_actor().m_actorAniEvent.add_m_skill3Event(ALENKOEKIGK);
		m_lastUpdateEvent = NJAAKBCFCLG;
		GOGLNMODMLA = 1;
		JDCFAHJNFOJ = 1016f;
		IKLPNHJIIIP = 50f;
		OENOCCIMJHJ = 0;
	}

	public override void OnUpdateIdle()
	{
		base.OnUpdateIdle();
	}

	public override void OnEnterSkill()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 1:
			break;
		case 2:
			if (GNOJMJDKFMG == null)
			{
				Object obj = Resources.Load("Particle/Garen/skill2_loop");
				if (obj != null)
				{
					GNOJMJDKFMG = Object.Instantiate(obj) as GameObject;
					GNOJMJDKFMG.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
				}
			}
			else
			{
				GNOJMJDKFMG.SetActive(true);
			}
			IKLPNHJIIIP = 0f;
			OENOCCIMJHJ = 0;
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_loop", true);
			if (Random.Range(0f, 1f) < 0.5f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_voice");
			}
			break;
		case 3:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3", false, 1f, 2f);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_voice");
			break;
		}
	}

	private void ALENKOEKIGK()
	{
		OnAnimationEventSkill(2);
	}

	public virtual void IFLIDEDLFPE()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 1:
			break;
		case 2:
			if (GNOJMJDKFMG == null)
			{
				Object obj = Resources.Load("ChangeTargetRpc");
				if (obj != null)
				{
					GNOJMJDKFMG = Object.Instantiate(obj) as GameObject;
					GNOJMJDKFMG.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
				}
			}
			else
			{
				GNOJMJDKFMG.SetActive(false);
			}
			IKLPNHJIIIP = 956f;
			OENOCCIMJHJ = 1;
			get_m_actor().m_multiSound.LKLFMNKDLHJ("Add", false, 478f, 1900f);
			get_m_actor().m_multiSound.HDOLPLIDACO("{0}", false, 359f, 1104f);
			if (Random.Range(307f, 1295f) < 1909f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("닉네임은 최소 2자에서 최대 10자 사이입니다.", false, 479f, 1950f);
			}
			break;
		case 3:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("Twist me", true, 1503f, 601f);
			get_m_actor().m_multiSound.DDONMGBLLJB("skill0_passive", false, 194f, 1248f);
			break;
		}
	}

	public override bool OnCheckKnockBack()
	{
		return true;
	}

	public virtual float CBNCPAMIMNB()
	{
		float num = base.GetPercentMoveSpeedBonus();
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65500))
		{
			num += 377f;
		}
		return num;
	}

	[CompilerGenerated]
	private void LDLMOMBKPLA()
	{
		OnAnimationEventSkill(1);
	}

	public override void OnUpdateSkill()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 1:
			break;
		case 2:
		{
			float iMABEBIKOOH = get_m_actor().m_moveSpeed * (1f + GetPercentMoveSpeedBonus());
			Move(iMABEBIKOOH, m_moveDirection);
			IKLPNHJIIIP = (float)IKLPNHJIIIP + get_m_actor().get_m_elapsedTime();
			if ((int)OENOCCIMJHJ <= (int)((float)IKLPNHJIIIP * 3f) - 1)
			{
				++OENOCCIMJHJ;
				double num = (double)get_m_actor().get_m_phy_att() * (0.7 + (double)(get_m_actor().GetSkillLevel(2) - 1) * 0.1);
				num += 20.0 + (double)(get_m_actor().GetSkillLevel(2) - 1) * 25.0;
				num *= 0.33340001106262207;
				List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 3.25f, false, true, (Actor.IJJMDPGJAEM)14);
				for (int i = 0; i < allActorInRange.Count; i++)
				{
					Actor actor = allActorInRange[i];
					if (!actor.IsDeath())
					{
						actor.OnDamage(get_m_actor(), num, 0.0);
					}
				}
				if (allActorInRange.Count <= 0)
				{
				}
			}
			if (get_m_view().IsMine() && (float)IKLPNHJIIIP >= 3f)
			{
				SetState(OEOIIKMBGAG.Idle);
			}
			break;
		}
		}
	}

	public virtual void BJCHMCLIPOH()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 1:
			break;
		case 2:
			if (GNOJMJDKFMG == null)
			{
				Object obj = Resources.Load("false");
				if (obj != null)
				{
					GNOJMJDKFMG = Object.Instantiate(obj) as GameObject;
					GNOJMJDKFMG.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
				}
			}
			else
			{
				GNOJMJDKFMG.SetActive(true);
			}
			IKLPNHJIIIP = 653f;
			OENOCCIMJHJ = 0;
			get_m_actor().m_multiSound.NMLFNHNOALK("{0}\n\n{1}", false, 1854f, 802f);
			get_m_actor().m_multiSound.JKOODMAKJHJ("brand_dont_passive", true, 1936f, 796f);
			if (Random.Range(714f, 1095f) < 120f)
			{
				get_m_actor().m_multiSound.ICNAJBHLIGO("RUB", true, 1585f, 972f);
			}
			break;
		case 3:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("already registered viewID[{0}]. Origin:{1} Try:{2}", true, 1047f, 1539f);
			get_m_actor().m_multiSound.HDOLPLIDACO("Silver", false, 1692f, 1448f);
			break;
		}
	}

	public void OnAnimationEventAttack()
	{
		Actor target = get_m_target();
		if (target != null)
		{
			double kDDLCDGFEME = 0.0;
			if ((int)GOGLNMODMLA == 2)
			{
				kDDLCDGFEME = (double)get_m_actor().get_m_phy_att() * 0.4;
				kDDLCDGFEME += 30.0 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 25.0;
			}
			target.OnAttackDamage(get_m_actor(), kDDLCDGFEME);
			if ((int)GOGLNMODMLA == 2 && target.m_actorType == Actor.IJJMDPGJAEM.Hero)
			{
				target.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Silence, get_m_actor(), 1.5f);
			}
			IAKBNJEFLAN(target);
			switch (GOGLNMODMLA)
			{
			case 0:
				get_m_actor().m_multiSound.LKLFMNKDLHJ("hit", false, 0.5f);
				break;
			case 1:
				get_m_actor().m_multiSound.LKLFMNKDLHJ("hit2", false, 0.5f);
				break;
			case 2:
				get_m_actor().m_multiSound.LKLFMNKDLHJ("hit3");
				break;
			}
		}
		if (Random.Range(0f, 1f) < 0.2f)
		{
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack_voice");
		}
		else if (Random.Range(0f, 1f) < 0.2f)
		{
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2_voice");
		}
		OnAttack();
	}

	private void EMPIHLJMMJB()
	{
		OnAnimationEventSkill(0);
	}

	public virtual void PHCGGDJJEEC()
	{
		BFPHFIAFMKJ();
	}

	private void COCGIPLPPIC()
	{
		ILMKHAAPMPG(3);
	}

	[CompilerGenerated]
	private void DOGGEKPKKKM()
	{
		OnAnimationEventSkill(3);
	}

	public virtual void PPKAJNLDGCF()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 1:
			break;
		case 2:
			if (GNOJMJDKFMG == null)
			{
				Object obj = Resources.Load("중급 성장 체력 정수");
				if (obj != null)
				{
					GNOJMJDKFMG = Object.Instantiate(obj) as GameObject;
					GNOJMJDKFMG.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
				}
			}
			else
			{
				GNOJMJDKFMG.SetActive(false);
			}
			IKLPNHJIIIP = 1810f;
			OENOCCIMJHJ = 1;
			get_m_actor().m_multiSound.ICNAJBHLIGO("Purchase (Campaign)", true, 994f, 1985f);
			get_m_actor().m_multiSound.JKOODMAKJHJ("Talon", true, 1523f, 1030f);
			if (Random.Range(750f, 697f) < 1150f)
			{
				get_m_actor().m_multiSound.HDOLPLIDACO("bgm_battle", true, 1870f, 283f);
			}
			break;
		case 3:
			get_m_actor().m_multiSound.NMLFNHNOALK("{0}", false, 98f, 904f);
			get_m_actor().m_multiSound.JKOODMAKJHJ("lobby_notice_en", false, 38f, 713f);
			break;
		}
	}

	public virtual void EKJAPCKHIIG()
	{
		NMCFOLAAALG();
	}

	[CompilerGenerated]
	private void DOFKIALMCKE()
	{
		OnAnimationEventSkill(2);
	}
}
