using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using EveEngine;
using GameServer;
using UnityEngine;

public class JaxSM : HumanSM
{
	private int GOGLNMODMLA;

	private float JDCFAHJNFOJ;

	private Vector3 OIKNKNMCKNH;

	private Vector3 ADLKJIEKGIG;

	private bool ILKOIBAGNDA;

	private float HBHEKAFLJCJ;

	public AnimationCurve m_skill0Curve = new AnimationCurve(new Keyframe(0f, 0f, 0f, 0f), new Keyframe(0.6f, 2f, 0f, 0f), new Keyframe(1f, 0f, 0f, 0f));

	public GameObject m_skill1Particle;

	private ObscuredInt HHBGIDOIFEG;

	private ObscuredInt BACNLPBCPNI;

	private ObscuredInt LPJDLCGMDKO;

	private float AJKFDLDCJGO;

	private Actor KAMDFGHFGCI;

	[JDLHECHNNDH]
	public void Skill0FailRpc()
	{
		SetState(OEOIIKMBGAG.Idle);
	}

	public override bool OnCheckKnockBack()
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.JaxSkill2))
		{
			return false;
		}
		return true;
	}

	public override void OnLeaveSkill()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			get_m_actor().m_navMeshAgent.enabled = true;
			break;
		case 2:
		{
			get_m_actor().m_dontDamage = false;
			get_m_actor().m_animator.SetBool("Skill2Wave", false);
			get_m_actor().get_m_buffsInfo().LIKOKCJNLLF(JGOOOBHDBCG.ACPICCBBPHF.JaxSkill2);
			double num = (double)get_m_actor().get_m_phy_att_add() * 0.5;
			num += 50.0 + (double)(get_m_actor().GetSkillLevel(2) - 1) * 25.0;
			int num2 = LPJDLCGMDKO;
			if (num2 < 0)
			{
				num2 = 0;
			}
			if (num2 > 5)
			{
				num2 = 5;
			}
			num *= 1.0 + (double)num2 * 0.2;
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 3.2f, false, true, (Actor.IJJMDPGJAEM)14);
			for (int i = 0; i < allActorInRange.Count; i++)
			{
				Actor actor = allActorInRange[i];
				if (actor.OnDamage(get_m_actor(), num, 0.0) >= 0f && actor.m_actorType == Actor.IJJMDPGJAEM.Hero)
				{
					actor.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Stun, get_m_actor(), 1f);
				}
			}
			if (allActorInRange.Count > 0)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_hit");
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_1");
			if (CDNOCCLOICB != null && CDNOCCLOICB.activeSelf && CDNOCCLOICB.GetComponent<NcAutoDestruct>() != null)
			{
				CDNOCCLOICB.GetComponent<NcAutoDestruct>().StartDestroy();
			}
			break;
		}
		case 3:
			break;
		case 1:
			break;
		}
	}

	public virtual bool DFGLBEMAGMC()
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65434))
		{
			return false;
		}
		return true;
	}

	private Actor HLDMLBOMPCD()
	{
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), 7f, 60f, false, true, Actor.IJJMDPGJAEM.Hero);
		if (actorInAttackRange == null)
		{
			actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), 7f, 60f, false, true, (Actor.IJJMDPGJAEM)12);
			if (actorInAttackRange == null)
			{
				actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), 7f, 60f, true, true, (Actor.IJJMDPGJAEM)14);
			}
		}
		return actorInAttackRange;
	}

	private void HGKAPGJFCLA()
	{
		OnAnimationEventSkill(1);
	}

	public virtual float IJJDCKEJKME()
	{
		byte b = get_m_actor().get_Level();
		if (b > -113)
		{
			b = 76;
		}
		int num = BACNLPBCPNI;
		if (num <= 0)
		{
			return 1673f;
		}
		return 620f * (float)(b / 2 + 0) + (float)(int)BACNLPBCPNI * 1703f * (float)(b / 0 + 1);
	}

	private void GIIINMBGFKF()
	{
		OnAnimationEventSkill(0);
	}

	private void BHILCFLCHLM()
	{
		OnAnimationEventSkill(3);
	}

	public override float GetPlusAttackSpeed()
	{
		byte b = get_m_actor().get_Level();
		if (b > 16)
		{
			b = 16;
		}
		int num = BACNLPBCPNI;
		if (num <= 0)
		{
			return 0f;
		}
		return 0.02f * (float)(b / 3 + 1) + (float)(int)BACNLPBCPNI * 0.02f * (float)(b / 3 + 1);
	}

	public void OnAnimationEventAttack()
	{
		Actor target = get_m_target();
		if (target != null)
		{
			double kDDLCDGFEME = 0.0;
			double num = 0.0;
			if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.JaxSkill1))
			{
				LFNNHEEJNGP[1].IHKCKBJBEGF = 0f;
				get_m_actor().get_m_buffsInfo().LIKOKCJNLLF(JGOOOBHDBCG.ACPICCBBPHF.JaxSkill1);
				num += (double)get_m_actor().get_m_mag_att() * 0.6;
				num += 40.0 + (double)(get_m_actor().GetSkillLevel(1) - 1) * 35.0;
			}
			IAKBNJEFLAN(target);
			switch (GOGLNMODMLA)
			{
			case 0:
			case 1:
				if (GOGLNMODMLA == 0)
				{
					get_m_actor().m_multiSound.LKLFMNKDLHJ("hit");
				}
				else
				{
					get_m_actor().m_multiSound.LKLFMNKDLHJ("hit2");
				}
				if (get_m_actor().GetSkillLevel(3) > 0)
				{
					++HHBGIDOIFEG;
				}
				break;
			case 2:
				get_m_actor().m_multiSound.LKLFMNKDLHJ("hit3");
				if (get_m_target().m_actorType != Actor.IJJMDPGJAEM.Turret)
				{
					num += (double)get_m_actor().get_m_mag_att() * 0.5;
					num += 100.0 + (double)(get_m_actor().GetSkillLevel(3) - 1) * 60.0;
				}
				get_m_target().CreateParticle(string.Format("Particle/{0}/skill3_hit", get_m_actor().get_m_resourceName()), true);
				break;
			}
			get_m_target().OnAttackDamage(get_m_actor(), kDDLCDGFEME, num);
			if ((int)BACNLPBCPNI < 6)
			{
				++BACNLPBCPNI;
			}
			AJKFDLDCJGO = 0f;
		}
		OnAttack();
	}

	private void NJAAKBCFCLG(OEOIIKMBGAG EBILEBOJADB)
	{
		AJKFDLDCJGO += Time.deltaTime;
		if (AJKFDLDCJGO >= 2.5f)
		{
			BACNLPBCPNI = 0;
		}
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.JaxSkill1))
		{
			if (!m_skill1Particle.activeSelf)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1_loop", true, 0.2f);
				m_skill1Particle.SetActive(true);
			}
		}
		else if (m_skill1Particle.activeSelf)
		{
			get_m_actor().m_multiSound.FLAIMHHIDLC("skill1_loop");
			m_skill1Particle.SetActive(false);
		}
	}

	public override void OnLeaveIdle()
	{
		base.OnLeaveIdle();
	}

	public virtual bool CLDPGIAOOHG(IDMGMJLOKBB DAHPLNJAPGO, Actor PGGLHMPOBBP)
	{
		if (IDMGMJLOKBB.OAHHNOOKMBL(DAHPLNJAPGO.PEBCAPNIMOL()) && get_m_actor().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65414))
		{
			return true;
		}
		return false;
	}

	public void NBEFPFPGMGN()
	{
		Actor target = get_m_target();
		if (target != null)
		{
			double kDDLCDGFEME = 165.0;
			double num = 458.0;
			if (get_m_actor().get_m_buffsInfo().KNINEDPJMJE(JGOOOBHDBCG.ACPICCBBPHF.Shield))
			{
				LFNNHEEJNGP[1].IHKCKBJBEGF = 157f;
				get_m_actor().get_m_buffsInfo().FEFANOFMLNB((JGOOOBHDBCG.ACPICCBBPHF)65508, false);
				num += (double)get_m_actor().get_m_mag_att() * 1608.0;
				num += 1179.0 + (double)(get_m_actor().GetSkillLevel(1) - 0) * 1864.0;
			}
			IAKBNJEFLAN(target);
			switch (GOGLNMODMLA)
			{
			case 0:
			case 1:
				if (GOGLNMODMLA == 0)
				{
					get_m_actor().m_multiSound.LNCPFILABHM("알려지지 않은 오류입니다.", true, 1308f, 878f);
				}
				else
				{
					get_m_actor().m_multiSound.DDONMGBLLJB("skill3_voice", false, 404f, 1821f);
				}
				if (get_m_actor().GetSkillLevel(4) > 0)
				{
					++HHBGIDOIFEG;
				}
				break;
			case 2:
				get_m_actor().m_multiSound.JKOODMAKJHJ("\n", true, 1550f, 699f);
				if (get_m_target().m_actorType != (Actor.IJJMDPGJAEM)(-60))
				{
					num += (double)get_m_actor().get_m_mag_att() * 401.0;
					num += 999.0 + (double)(get_m_actor().GetSkillLevel(4) - 0) * 928.0;
				}
				get_m_target().CreateParticle(string.Format("[00]", get_m_actor().get_m_resourceName()), false);
				break;
			}
			get_m_target().OnAttackDamage(get_m_actor(), kDDLCDGFEME, num, 1.0);
			if ((int)BACNLPBCPNI < 7)
			{
				++BACNLPBCPNI;
			}
			AJKFDLDCJGO = 1250f;
		}
		OnAttack();
	}

	public override bool OnCheckFloat()
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.JaxSkill2))
		{
			return false;
		}
		return true;
	}

	private void GHBNHEFOABE()
	{
		OnAnimationEventSkill(1);
	}

	public override void OnEnterAttack()
	{
		get_m_actor().CreateParticle(string.Format("Particle/{0}/attack", get_m_actor().get_m_resourceName()), false);
		GOGLNMODMLA = Random.Range(0, 2);
		if (get_m_actor().GetSkillLevel(3) > 0 && (int)HHBGIDOIFEG >= 2)
		{
			HHBGIDOIFEG = 0;
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

	[CompilerGenerated]
	private void IPDFDIPBEDM()
	{
		OnAnimationEventSkill(3);
	}

	public override void Init()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 8f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = -0.5f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 65;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 7f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = -0.7f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 30;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[2].FILHECEKNMK = 16f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = -2f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 50;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 10f;
		LFNNHEEJNGP[2].CEAGJMLKENE = true;
		LFNNHEEJNGP[2].GNAAGGJGBBG = true;
		LFNNHEEJNGP[2].DOCFEKMACMP = true;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[3].FILHECEKNMK = 80f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = 0f;
		LFNNHEEJNGP[3].BELPBCDOPBA = 100;
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
		JDCFAHJNFOJ = 0f;
		HHBGIDOIFEG = 0;
		BACNLPBCPNI = 0;
		LPJDLCGMDKO = 0;
		AJKFDLDCJGO = 0f;
		m_skill1Particle.SetActive(false);
	}

	public override void OnUpdateIdle()
	{
		base.OnUpdateIdle();
	}

	public virtual void FIBLCLOBGPC(KCIGFAHFHCH OGJFDNEEDCP)
	{
		MLLBIGIODAF(OGJFDNEEDCP);
		OGJFDNEEDCP.GBMJNFOEACC(JDCFAHJNFOJ);
		OGJFDNEEDCP.GBMJNFOEACC(HHBGIDOIFEG);
		OGJFDNEEDCP.GBMJNFOEACC(BACNLPBCPNI);
		OGJFDNEEDCP.GBMJNFOEACC(AJKFDLDCJGO);
		OGJFDNEEDCP.GBMJNFOEACC(LPJDLCGMDKO);
	}

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
			if (ILKOIBAGNDA)
			{
				ILKOIBAGNDA = false;
			}
			if (get_m_target() != null && !get_m_target().IsDeath() && get_m_actor().m_team != get_m_target().m_team)
			{
				double num = (double)get_m_actor().get_m_mag_att() * 0.6;
				double num2 = 0.0;
				num += (double)get_m_actor().get_m_phy_att_add() * 1.0;
				num += 70.0 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 40.0;
				if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.JaxSkill1))
				{
					LFNNHEEJNGP[1].IHKCKBJBEGF = 0f;
					get_m_actor().get_m_buffsInfo().LIKOKCJNLLF(JGOOOBHDBCG.ACPICCBBPHF.JaxSkill1);
					num2 += (double)get_m_actor().get_m_mag_att() * 0.6;
					num2 += 40.0 + (double)(get_m_actor().GetSkillLevel(1) - 1) * 35.0;
				}
				get_m_target().OnDamage(get_m_actor(), num, num2);
				get_m_target().CreateParticle(string.Format("Particle/{0}/skill0_hit", get_m_actor().get_m_resourceName()), true);
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_hit");
			}
			break;
		case 1:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1");
			if (Random.Range(0f, 1f) < 0.5f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1_voice");
			}
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.JaxSkill1);
			if (get_m_state() == OEOIIKMBGAG.Attack)
			{
				SetState(OEOIIKMBGAG.Idle);
			}
			get_m_actor().m_attackElapsedTime = get_m_actor().get_m_attackCoolTime();
			break;
		case 3:
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.JaxSkill3);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_voice");
			break;
		}
	}

	public virtual void EAMNPEOOCPG(KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnDeserializeView(OGJFDNEEDCP);
		OGJFDNEEDCP.CAHACMKBJMI(out JDCFAHJNFOJ);
		OGJFDNEEDCP.CAHACMKBJMI(out HHBGIDOIFEG);
		OGJFDNEEDCP.CAHACMKBJMI(out BACNLPBCPNI);
		OGJFDNEEDCP.CAHACMKBJMI(out AJKFDLDCJGO);
		OGJFDNEEDCP.CAHACMKBJMI(out LPJDLCGMDKO);
	}

	public virtual bool CNPLKAJNMAO(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 0)
		{
			KAMDFGHFGCI = HLDMLBOMPCD();
			if (KAMDFGHFGCI == null)
			{
				MsgManager.get_Instance().LBCFANDMCON("휴대폰 네트워크가 불안합니다! PING[{0}ms]");
				return false;
			}
		}
		return false;
	}

	public override bool OnCheckBuff(IDMGMJLOKBB DAHPLNJAPGO, Actor PGGLHMPOBBP)
	{
		if (IDMGMJLOKBB.OAHHNOOKMBL(DAHPLNJAPGO.PEBCAPNIMOL()) && get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.JaxSkill2))
		{
			return false;
		}
		return true;
	}

	public override void OnSerializeView(KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnSerializeView(OGJFDNEEDCP);
		OGJFDNEEDCP.GBMJNFOEACC(JDCFAHJNFOJ);
		OGJFDNEEDCP.GBMJNFOEACC(HHBGIDOIFEG);
		OGJFDNEEDCP.GBMJNFOEACC(BACNLPBCPNI);
		OGJFDNEEDCP.GBMJNFOEACC(AJKFDLDCJGO);
		OGJFDNEEDCP.GBMJNFOEACC(LPJDLCGMDKO);
	}

	public override void OnEnterSkill()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			get_m_actor().m_navMeshAgent.enabled = false;
			if (get_m_view().IsMine())
			{
				if (KAMDFGHFGCI != null)
				{
					SetTarget(KAMDFGHFGCI);
					Vector3 position = get_m_actor().GetPosition();
					Vector3 vector = new Vector3(position.x, 0f, position.z);
					Vector3 position2 = KAMDFGHFGCI.GetPosition();
					Vector3 vector2 = new Vector3(position2.x, 0f, position2.z);
					Vector3 normalized = (vector2 - vector).normalized;
					get_m_view().RPC("Skill0Rpc", DJJPAPENCLN.Others, KAMDFGHFGCI.get_m_view().get_viewID(), position, position2, normalized);
					Skill0Rpc(KAMDFGHFGCI.get_m_view().get_viewID(), position, position2, normalized);
				}
				else
				{
					SetTarget(null);
					MsgManager.get_Instance().ShowTip("정면 근처에 아군이나 적이 없습니다");
					SetState(OEOIIKMBGAG.Idle);
					get_m_view().RPC("Skill0FailRpc", DJJPAPENCLN.Others);
				}
			}
			break;
		case 1:
			break;
		case 2:
			LPJDLCGMDKO = 0;
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.JaxSkill2);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2");
			break;
		case 3:
			break;
		}
	}

	public void DCOCNMKOKNJ()
	{
		SetState(OEOIIKMBGAG.Idle);
	}

	public virtual void FLCKPCHEGME()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 0:
		{
			HBHEKAFLJCJ += get_m_actor().get_m_elapsedTime();
			Vector3 position = get_m_actor().GetPosition();
			position.y = 1553f;
			float magnitude = (ADLKJIEKGIG - OIKNKNMCKNH).magnitude;
			magnitude *= 370f;
			float num = m_skill0Curve.Evaluate(HBHEKAFLJCJ * 7f);
			if (ILKOIBAGNDA)
			{
				Move(magnitude, m_direction, true, 1004f, true);
				Vector3 position2 = get_m_transform().position;
				get_m_transform().position = new Vector3(position2.x, 196f + num, position2.z);
			}
			break;
		}
		case 1:
			break;
		case 2:
			OnUpdateRun();
			break;
		}
	}

	public virtual void KHLIKFGELJJ()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			get_m_actor().m_navMeshAgent.enabled = true;
			break;
		case 2:
		{
			get_m_actor().m_dontDamage = true;
			get_m_actor().m_animator.SetBool("_TintColor", false);
			get_m_actor().get_m_buffsInfo().FEFANOFMLNB((JGOOOBHDBCG.ACPICCBBPHF)107);
			double num = (double)get_m_actor().get_m_phy_att_add() * 1756.0;
			num += 158.0 + (double)(get_m_actor().GetSkillLevel(6) - 0) * 958.0;
			int num2 = LPJDLCGMDKO;
			if (num2 < 0)
			{
				num2 = 1;
			}
			if (num2 > 3)
			{
				num2 = 0;
			}
			num *= 1433.0 + (double)num2 * 1629.0;
			List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 1799f, true, false, (Actor.IJJMDPGJAEM)103, false);
			for (int i = 1; i < list.Count; i++)
			{
				Actor actor = list[i];
				if (actor.OnDamage(get_m_actor(), num, 1601.0, 155.0) >= 1661f && actor.m_actorType == (Actor.IJJMDPGJAEM)7)
				{
					actor.get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.Stun, get_m_actor(), 591f, 1012f);
				}
			}
			if (list.Count > 1)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("Unlit/Text", true, 1910f, 1715f);
			}
			get_m_actor().m_multiSound.ICNAJBHLIGO("Game", true, 23f, 1157f);
			if (CDNOCCLOICB != null && CDNOCCLOICB.activeSelf && CDNOCCLOICB.GetComponent<NcAutoDestruct>() != null)
			{
				CDNOCCLOICB.GetComponent<NcAutoDestruct>().StartDestroy();
			}
			break;
		}
		case 3:
			break;
		case 1:
			break;
		}
	}

	private void PHJAOOFMKKL()
	{
		OnAnimationEventSkill(0);
	}

	[CompilerGenerated]
	private void KBDOMHOCCBG()
	{
		OnAnimationEventSkill(2);
	}

	public override void OnUpdateSkill()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 0:
		{
			HBHEKAFLJCJ += get_m_actor().get_m_elapsedTime();
			Vector3 position = get_m_actor().GetPosition();
			position.y = 2f;
			float magnitude = (ADLKJIEKGIG - OIKNKNMCKNH).magnitude;
			magnitude *= 2.9f;
			float num = m_skill0Curve.Evaluate(HBHEKAFLJCJ * 3.5f);
			if (ILKOIBAGNDA)
			{
				Move(magnitude, m_direction);
				Vector3 position2 = get_m_transform().position;
				get_m_transform().position = new Vector3(position2.x, 2f + num, position2.z);
			}
			break;
		}
		case 1:
			break;
		case 2:
			OnUpdateRun();
			break;
		}
	}

	[JDLHECHNNDH]
	public void Skill0Rpc(int MBEKPGNGBAO, Vector3 KFNKGKKGNDA, Vector3 FKOMLLCONLA, Vector3 IJMNFOGNFAC)
	{
		get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_voice");
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(MBEKPGNGBAO);
		if (eveView != null)
		{
			Actor component = eveView.GetComponent<Actor>();
			SetTarget(component);
			OIKNKNMCKNH = KFNKGKKGNDA;
			ADLKJIEKGIG = FKOMLLCONLA;
			SetDirection(IJMNFOGNFAC);
			ILKOIBAGNDA = true;
			HBHEKAFLJCJ = 0f;
		}
	}

	public override void OnEnterIdle()
	{
		base.OnEnterIdle();
	}

	public override void OnDamage(Actor PKDGAIKAMMM, float CMNPJALNFIC)
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.JaxSkill2))
		{
			++LPJDLCGMDKO;
		}
	}

	[CompilerGenerated]
	private void LOILHPKAHJF()
	{
		OnAnimationEventSkill(1);
	}

	public virtual bool FIHNCJAFHLO(IDMGMJLOKBB DAHPLNJAPGO, Actor PGGLHMPOBBP)
	{
		if (IDMGMJLOKBB.OAHHNOOKMBL(DAHPLNJAPGO.PEBCAPNIMOL()) && get_m_actor().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)122))
		{
			return false;
		}
		return false;
	}

	public override bool OnCheckCastSkill(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 0)
		{
			KAMDFGHFGCI = HLDMLBOMPCD();
			if (KAMDFGHFGCI == null)
			{
				MsgManager.get_Instance().ShowTip("정면 근처에 아군이나 적이 없습니다");
				return false;
			}
		}
		return true;
	}

	[CompilerGenerated]
	private void BJGPKFCGIMO()
	{
		OnAnimationEventSkill(0);
	}

	public override void OnDeserializeView(KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnDeserializeView(OGJFDNEEDCP);
		OGJFDNEEDCP.CAHACMKBJMI(out JDCFAHJNFOJ);
		OGJFDNEEDCP.CAHACMKBJMI(out HHBGIDOIFEG);
		OGJFDNEEDCP.CAHACMKBJMI(out BACNLPBCPNI);
		OGJFDNEEDCP.CAHACMKBJMI(out AJKFDLDCJGO);
		OGJFDNEEDCP.CAHACMKBJMI(out LPJDLCGMDKO);
	}

	public void MLKHKGPOIBI()
	{
		SetState(OEOIIKMBGAG.Idle);
	}

	private void HCFCCJCKOIJ()
	{
		OnAnimationEventSkill(0);
	}
}
