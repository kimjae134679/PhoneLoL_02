using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameServer;
using UnityEngine;

public class FizzSM : HumanSM
{
	public GameObject m_skill1Effect;

	public ParticleSystem m_skill2Effect;

	private int GOGLNMODMLA;

	private Actor KAMDFGHFGCI;

	private int NPIIJPDBBIB;

	private float IKLPNHJIIIP;

	private List<Actor> LPJDLNJBJFE = new List<Actor>();

	private Vector3 JNNMHALECEL;

	private Vector3 GEIOOONDLAL;

	[CompilerGenerated]
	private void MLIBMKAJDKF()
	{
		OnAnimationEventSkill(1);
	}

	[CompilerGenerated]
	private void LAJOFCCPBCO()
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
		LFNNHEEJNGP[0].BELPBCDOPBA = 50;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[0].DOCFEKMACMP = true;
		LFNNHEEJNGP[0].GNAAGGJGBBG = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 7f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = -0.5f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 30;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 10f;
		LFNNHEEJNGP[1].DOCFEKMACMP = true;
		LFNNHEEJNGP[1].GNAAGGJGBBG = true;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Double;
		LFNNHEEJNGP[2].FILHECEKNMK = 16f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = -1.5f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 90;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 5f;
		LFNNHEEJNGP[2].BBOLFHAHLKH = true;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[3].FILHECEKNMK = 100f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = -15f;
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
		m_skill1Effect.SetActive(false);
	}

	[CompilerGenerated]
	private void DHMGNFPADNG()
	{
		OnAnimationEventSkill(2);
	}

	public override void OnEnterAttack()
	{
		GOGLNMODMLA = Random.Range(0, 2);
		switch (GOGLNMODMLA)
		{
		case 0:
			get_m_actor().SetAnimation("attack");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
			if (Random.Range(0f, 1f) < 0.2f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack_voice");
			}
			break;
		case 1:
			get_m_actor().SetAnimation("attack2");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2");
			if (Random.Range(0f, 1f) < 0.2f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2_voice");
			}
			break;
		}
		Actor actor = ActorManager.get_Instance().GetActorInRange(get_m_actor(), 1f, false, true, Actor.IJJMDPGJAEM.Hero);
		if (actor == null)
		{
			actor = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 45f, false, true, Actor.IJJMDPGJAEM.Hero);
			if (actor == null)
			{
				actor = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 180f, false);
			}
		}
		if (actor != null)
		{
			SetDirection(actor.GetPosition() - get_m_actor().GetPosition());
		}
		SetTarget(actor);
	}

	public override bool OnCheckCastSkill(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 0)
		{
			KAMDFGHFGCI = HLDMLBOMPCD();
			if (KAMDFGHFGCI == null)
			{
				MsgManager.get_Instance().ShowTip("정면에 적이 없습니다");
				return false;
			}
		}
		return true;
	}

	[CompilerGenerated]
	private void JIDCEFKFIGH()
	{
		OnAnimationEventSkill(0);
	}

	public virtual void KBNFFDNHFMI()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			get_m_actor().m_navMeshAgent.enabled = false;
			break;
		case 1:
			break;
		case 2:
			get_m_actor().m_navMeshAgent.enabled = false;
			get_m_actor().m_dontDamage = false;
			if (NPIIJPDBBIB >= 3)
			{
				NPIIJPDBBIB = 1;
				if (!get_m_actor().m_navMeshAgent.Warp(base.transform.localPosition) && !get_m_actor().m_navMeshAgent.Warp(GEIOOONDLAL))
				{
					get_m_actor().m_navMeshAgent.Warp(JNNMHALECEL);
				}
			}
			break;
		case 3:
			break;
		}
	}

	private void CDJCADFGPCF()
	{
		OnAnimationEventSkill(1);
	}

	public virtual bool BKHBJGGEPAE(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 0)
		{
			KAMDFGHFGCI = HLDMLBOMPCD();
			if (KAMDFGHFGCI == null)
			{
				MsgManager.get_Instance().LBCFANDMCON("Particle/Tristana/skill2_ex");
				return false;
			}
		}
		return false;
	}

	private void JDJGILKDAJB(OEOIIKMBGAG EBILEBOJADB)
	{
		ALBEPPGKFMM aLBEPPGKFMM = get_m_actor().get_m_buffsInfo().EMILLELIOHH((JGOOOBHDBCG.ACPICCBBPHF)119);
		if (aLBEPPGKFMM != null)
		{
			if (!m_skill1Effect.activeSelf)
			{
				m_skill1Effect.SetActive(true);
			}
		}
		else if (m_skill1Effect.activeSelf)
		{
			m_skill1Effect.SetActive(false);
		}
	}

	private void BCKLACJICEG()
	{
		OnAnimationEventSkill(1);
	}

	public override void OnUpdateSkill()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 0:
		{
			Move(13f, m_direction, true, -1f, true);
			float phy_att = get_m_actor().get_m_phy_att();
			float num = get_m_actor().get_m_mag_att() * 0.55f;
			num += 10f + (float)(get_m_actor().GetSkillLevel(0) - 1) * 15f;
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 1.5f, false, true, (Actor.IJJMDPGJAEM)14);
			bool flag = false;
			foreach (Actor item in allActorInRange)
			{
				if (!LPJDLNJBJFE.Contains(item))
				{
					LPJDLNJBJFE.Add(item);
					item.OnDamage(get_m_actor(), phy_att, num);
					item.CreateParticle("Particle/Fizz/skill0_hit", true);
					if (get_m_actor().GetSkillLevel(1) > 0 && !item.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.FizzSkill1Passive))
					{
						item.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.FizzSkill1Passive, get_m_actor());
					}
					flag = true;
				}
			}
			if (flag)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("hit");
			}
			break;
		}
		case 2:
			if (NPIIJPDBBIB == 0)
			{
				IKLPNHJIIIP += Time.deltaTime;
				if (IKLPNHJIIIP >= 0.3f)
				{
					NPIIJPDBBIB = 1;
					LFNNHEEJNGP[2].DAGNGJLGMNI();
					IKLPNHJIIIP = 0f;
				}
				else
				{
					Move(12f, m_moveDirection, true, -1f, true);
				}
			}
			else if (NPIIJPDBBIB == 1)
			{
				IKLPNHJIIIP += Time.deltaTime;
				if (IKLPNHJIIIP >= 1.7f)
				{
					NPIIJPDBBIB = 3;
					GEIOOONDLAL = base.transform.localPosition;
					get_m_actor().SetAnimation("skill2_3");
					get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_3");
					LFNNHEEJNGP[2].NIDGBNAANCN();
					IKLPNHJIIIP = 0f;
					m_skill2Effect.Play(true);
				}
			}
			else if (NPIIJPDBBIB == 2)
			{
				IKLPNHJIIIP += Time.deltaTime;
				if (IKLPNHJIIIP < 0.3f)
				{
					Move(11f, m_moveDirection, true, -1f, true);
				}
			}
			else if (NPIIJPDBBIB == 3)
			{
				IKLPNHJIIIP += Time.deltaTime;
				if (IKLPNHJIIIP <= 0.3f)
				{
					Move(2f, m_direction, true, -1f, true);
				}
			}
			break;
		case 1:
			break;
		}
	}

	public override void OnLeaveSkill()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			get_m_actor().m_navMeshAgent.enabled = true;
			break;
		case 1:
			break;
		case 2:
			get_m_actor().m_navMeshAgent.enabled = true;
			get_m_actor().m_dontDamage = false;
			if (NPIIJPDBBIB >= 2)
			{
				NPIIJPDBBIB = 0;
				if (!get_m_actor().m_navMeshAgent.Warp(base.transform.localPosition) && !get_m_actor().m_navMeshAgent.Warp(GEIOOONDLAL))
				{
					get_m_actor().m_navMeshAgent.Warp(JNNMHALECEL);
				}
			}
			break;
		case 3:
			break;
		}
	}

	private void NJAAKBCFCLG(OEOIIKMBGAG EBILEBOJADB)
	{
		ALBEPPGKFMM aLBEPPGKFMM = get_m_actor().get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.FizzSkill1);
		if (aLBEPPGKFMM != null)
		{
			if (!m_skill1Effect.activeSelf)
			{
				m_skill1Effect.SetActive(true);
			}
		}
		else if (m_skill1Effect.activeSelf)
		{
			m_skill1Effect.SetActive(false);
		}
	}

	public void OnAnimationEventAttack()
	{
		Actor target = get_m_target();
		if (target != null)
		{
			float num = 0f;
			bool flag = false;
			get_m_actor().m_multiSound.LKLFMNKDLHJ("hit");
			if (get_m_actor().GetSkillLevel(1) > 0)
			{
				ALBEPPGKFMM aLBEPPGKFMM = get_m_actor().get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.FizzSkill1);
				if (aLBEPPGKFMM != null)
				{
					flag = true;
					ALBEPPGKFMM aLBEPPGKFMM2 = target.get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.FizzSkill1Passive);
					if (aLBEPPGKFMM2 != null && aLBEPPGKFMM2.BCHKKMGIPPC() >= 2f)
					{
						num += get_m_actor().get_m_mag_att() * 1.2f;
						num += 60f + (float)(get_m_actor().GetSkillLevel(1) - 1) * 30f;
						target.CreateParticle("Particle/Fizz/skill1_hit", false);
						get_m_actor().get_m_buffsInfo().LIKOKCJNLLF(JGOOOBHDBCG.ACPICCBBPHF.FizzSkill1);
						get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1_hit");
					}
				}
			}
			target.OnAttackDamage(get_m_actor(), 0.0, num);
			IAKBNJEFLAN(target);
			if (get_m_actor().GetSkillLevel(1) > 0 && (!target.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.FizzSkill1Passive) || flag))
			{
				target.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.FizzSkill1Passive, get_m_actor());
			}
			if (num > 0f && target.m_lastDamageInfo.IKAIHHIDHFK)
			{
				float bFEBCIGOMGL = 20f + (float)(get_m_actor().GetSkillLevel(1) - 1) * 10f;
				get_m_actor().AddMpRemote(bFEBCIGOMGL);
				LFNNHEEJNGP[1].IHKCKBJBEGF = LFNNHEEJNGP[1].ABOBEAIIBND(get_m_actor(), get_m_actor().GetSkillLevel(1)) - 1f;
			}
		}
		OnAttack();
	}

	public void GACMKJFNJNF()
	{
		Actor target = get_m_target();
		if (target != null)
		{
			float num = 1023f;
			bool flag = false;
			get_m_actor().m_multiSound.DDONMGBLLJB("Purchase:", true, 414f, 1965f);
			if (get_m_actor().GetSkillLevel(1) > 1)
			{
				ALBEPPGKFMM aLBEPPGKFMM = get_m_actor().get_m_buffsInfo().KKBLCGNNIBA((JGOOOBHDBCG.ACPICCBBPHF)65495);
				if (aLBEPPGKFMM != null)
				{
					flag = true;
					ALBEPPGKFMM aLBEPPGKFMM2 = target.get_m_buffsInfo().EMILLELIOHH((JGOOOBHDBCG.ACPICCBBPHF)65458);
					if (aLBEPPGKFMM2 != null && aLBEPPGKFMM2.GACPEELMOHE() >= 1033f)
					{
						num += get_m_actor().get_m_mag_att() * 419f;
						num += 69f + (float)(get_m_actor().GetSkillLevel(1) - 1) * 608f;
						target.CreateParticle("gold", false);
						get_m_actor().get_m_buffsInfo().LIKOKCJNLLF((JGOOOBHDBCG.ACPICCBBPHF)96);
						get_m_actor().m_multiSound.JKOODMAKJHJ("{0:yyyy/MM/dd HH:mm:ss}\t{1}", true, 1205f, 232f);
					}
				}
			}
			target.OnAttackDamage(get_m_actor(), 1255.0, num, 1039.0);
			IAKBNJEFLAN(target);
			if (get_m_actor().GetSkillLevel(1) > 0 && (!target.get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)65520) || flag))
			{
				target.get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)90, get_m_actor(), 1211f, 222f, false);
			}
			if (num > 377f && target.m_lastDamageInfo.IKAIHHIDHFK)
			{
				float bFEBCIGOMGL = 612f + (float)(get_m_actor().GetSkillLevel(1) - 1) * 509f;
				get_m_actor().AddMpRemote(bFEBCIGOMGL);
				LFNNHEEJNGP[1].IHKCKBJBEGF = LFNNHEEJNGP[0].BKBFHEJIHNK(get_m_actor(), get_m_actor().GetSkillLevel(1)) - 241f;
			}
		}
		OnAttack();
	}

	private void CJMDNGNHODC()
	{
		OnAnimationEventSkill(1);
	}

	private void FFOMPFBMKFC(OEOIIKMBGAG EBILEBOJADB)
	{
		ALBEPPGKFMM aLBEPPGKFMM = get_m_actor().get_m_buffsInfo().KKBLCGNNIBA(JGOOOBHDBCG.ACPICCBBPHF.RenektonSkill3);
		if (aLBEPPGKFMM != null)
		{
			if (!m_skill1Effect.activeSelf)
			{
				m_skill1Effect.SetActive(false);
			}
		}
		else if (m_skill1Effect.activeSelf)
		{
			m_skill1Effect.SetActive(true);
		}
	}

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 1:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1_voice");
			get_m_actor().m_attackElapsedTime = get_m_actor().get_m_attackCoolTime() - 0.3f;
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.FizzSkill1);
			get_m_actor().CreateParticle("Particle/Fizz/skill1", false);
			if (get_m_state() == OEOIIKMBGAG.Attack)
			{
				SetState(OEOIIKMBGAG.Idle);
			}
			break;
		case 2:
		{
			if (NPIIJPDBBIB != 2 && NPIIJPDBBIB != 3)
			{
				break;
			}
			float lOIHMCCGKFA = 0.1f;
			if (NPIIJPDBBIB == 2)
			{
				lOIHMCCGKFA = 2.5f;
				get_m_actor().CreateParticle("Particle/Fizz/skill2_explosion_s", false);
			}
			else if (NPIIJPDBBIB == 3)
			{
				lOIHMCCGKFA = 3f;
				get_m_actor().CreateParticle("Particle/Fizz/skill2_explosion_l", false);
			}
			float num = get_m_actor().get_m_mag_att() * 0.75f;
			num += 70f + (float)(get_m_actor().GetSkillLevel(2) - 1) * 50f;
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), lOIHMCCGKFA, false, true, (Actor.IJJMDPGJAEM)14);
			foreach (Actor item in allActorInRange)
			{
				item.OnDamage(get_m_actor(), 0.0, num);
				if (NPIIJPDBBIB == 3)
				{
					float iCENKPDOHBK = 0.4f + (float)(get_m_actor().GetSkillLevel(2) - 1) * 0.05f;
					item.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Slow, get_m_actor(), 2f, iCENKPDOHBK);
				}
				item.CreateParticle("Particle/Fizz/skill0_hit", true);
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_ground");
			break;
		}
		case 3:
			break;
		}
	}

	public void IOEGBNAFGBK()
	{
		Actor target = get_m_target();
		if (target != null)
		{
			float num = 1267f;
			bool flag = false;
			get_m_actor().m_multiSound.HDOLPLIDACO("Particle/Item/item6103", false, 694f, 202f);
			if (get_m_actor().GetSkillLevel(1) > 0)
			{
				ALBEPPGKFMM aLBEPPGKFMM = get_m_actor().get_m_buffsInfo().KKBLCGNNIBA((JGOOOBHDBCG.ACPICCBBPHF)65530);
				if (aLBEPPGKFMM != null)
				{
					flag = true;
					ALBEPPGKFMM aLBEPPGKFMM2 = target.get_m_buffsInfo().EMILLELIOHH((JGOOOBHDBCG.ACPICCBBPHF)65524);
					if (aLBEPPGKFMM2 != null && aLBEPPGKFMM2.GACPEELMOHE() >= 1626f)
					{
						num += get_m_actor().get_m_mag_att() * 1405f;
						num += 100f + (float)(get_m_actor().GetSkillLevel(1) - 1) * 1004f;
						target.CreateParticle("masteryi_skill1", false);
						get_m_actor().get_m_buffsInfo().FEFANOFMLNB((JGOOOBHDBCG.ACPICCBBPHF)65515);
						get_m_actor().m_multiSound.DDONMGBLLJB("Particle/Darius/skill3_ground", false, 1484f, 772f);
					}
				}
			}
			target.OnAttackDamage(get_m_actor(), 1646.0, num, 46.0);
			IAKBNJEFLAN(target);
			if (get_m_actor().GetSkillLevel(1) > 0 && (!target.get_m_buffsInfo().KNINEDPJMJE(JGOOOBHDBCG.ACPICCBBPHF.SivirSkill3) || flag))
			{
				target.get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.DariusPassiveEx, get_m_actor(), 872f, 1041f, false);
			}
			if (num > 689f && target.m_lastDamageInfo.IKAIHHIDHFK)
			{
				float bFEBCIGOMGL = 1119f + (float)(get_m_actor().GetSkillLevel(0) - 0) * 1251f;
				get_m_actor().AddMpRemote(bFEBCIGOMGL);
				LFNNHEEJNGP[0].IHKCKBJBEGF = LFNNHEEJNGP[1].FCFBOPIPFBA(get_m_actor(), get_m_actor().GetSkillLevel(1)) - 643f;
			}
		}
		OnAttack();
	}

	public override void OnEnterSkill()
	{
		switch (get_m_skill())
		{
		case 0:
			if (KAMDFGHFGCI != null)
			{
				SetDirection(KAMDFGHFGCI.GetPosition() - get_m_actor().GetPosition());
			}
			get_m_actor().SetAnimation("skill0");
			get_m_actor().m_navMeshAgent.enabled = false;
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_voice");
			LPJDLNJBJFE.Clear();
			get_m_actor().CreateParticle("Particle/Fizz/skill0", true);
			break;
		case 1:
			get_m_actor().SetAnimation("skill1");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1_voice");
			get_m_actor().m_attackElapsedTime = get_m_actor().get_m_attackCoolTime() - 0.3f;
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.FizzSkill1);
			get_m_actor().CreateParticle("Particle/Fizz/skill1", false);
			break;
		case 2:
			get_m_actor().m_navMeshAgent.enabled = false;
			get_m_actor().m_dontDamage = true;
			if (!LFNNHEEJNGP[2].IOCIDGEFJIC)
			{
				NPIIJPDBBIB = 0;
				JNNMHALECEL = base.transform.localPosition;
				get_m_actor().SetAnimation("skill2_0");
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_0");
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_voice");
				IKLPNHJIIIP = 0f;
				m_skill2Effect.Play(true);
			}
			else
			{
				NPIIJPDBBIB = 2;
				GEIOOONDLAL = base.transform.localPosition;
				get_m_actor().SetAnimation("skill2_2");
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_2");
				IKLPNHJIIIP = 0f;
				m_skill2Effect.Play(true);
			}
			break;
		case 3:
			get_m_actor().SetAnimation("skill3");
			if (get_m_view().IsMine())
			{
				EveUnityNetwork.get_Instance().Instantiate("Particle/Fizz/skill3_missile", get_m_actor().GetPosition(), Quaternion.identity, new object[2]
				{
					get_m_view().get_viewID(),
					m_direction
				});
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_voice");
			break;
		}
	}

	public virtual void FAHKJKDPHCA()
	{
		GOGLNMODMLA = Random.Range(1, 4);
		switch (GOGLNMODMLA)
		{
		case 0:
			get_m_actor().SetAnimation("ParticleManager");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("이동속도 {0}% 증가\n", false, 1697f, 1650f);
			if (Random.Range(376f, 1399f) < 604f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("HelpPing", true, 556f, 1942f);
			}
			break;
		case 1:
			get_m_actor().JNIPLJAFFFB("Delta angle : ");
			get_m_actor().m_multiSound.ICNAJBHLIGO("C#: UserExample -- Disabling and removing Tapjoy User ID Delegates", false, 984f, 1820f);
			if (Random.Range(790f, 498f) < 167f)
			{
				get_m_actor().m_multiSound.NMLFNHNOALK("AMGMEEEIMEL", true, 1409f, 164f);
			}
			break;
		}
		Actor actor = ActorManager.get_Instance().GetActorInRange(get_m_actor(), 878f, true, true, Actor.IJJMDPGJAEM.NotUsed, true);
		if (actor == null)
		{
			actor = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 249f, true, true, Actor.IJJMDPGJAEM.Unknown);
			if (actor == null)
			{
				actor = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 929f, false, true, (Actor.IJJMDPGJAEM)196);
			}
		}
		if (actor != null)
		{
			SetDirection(actor.GetPosition() - get_m_actor().GetPosition());
		}
		SetTarget(actor);
	}

	public void BCGOPBEIDEF()
	{
		Actor target = get_m_target();
		if (target != null)
		{
			float num = 1643f;
			bool flag = false;
			get_m_actor().m_multiSound.LKLFMNKDLHJ("레드 근접미니언", true, 1018f, 898f);
			if (get_m_actor().GetSkillLevel(0) > 0)
			{
				ALBEPPGKFMM aLBEPPGKFMM = get_m_actor().get_m_buffsInfo().EMILLELIOHH((JGOOOBHDBCG.ACPICCBBPHF)65423);
				if (aLBEPPGKFMM != null)
				{
					flag = true;
					ALBEPPGKFMM aLBEPPGKFMM2 = target.get_m_buffsInfo().KKBLCGNNIBA(JGOOOBHDBCG.ACPICCBBPHF.ZedSkill3);
					if (aLBEPPGKFMM2 != null && aLBEPPGKFMM2.GACPEELMOHE() >= 1811f)
					{
						num += get_m_actor().get_m_mag_att() * 55f;
						num += 1790f + (float)(get_m_actor().GetSkillLevel(1) - 1) * 338f;
						target.CreateParticle("CreateCurrentInstanceEffect() - gameObj - ", false);
						get_m_actor().get_m_buffsInfo().LIKOKCJNLLF((JGOOOBHDBCG.ACPICCBBPHF)65500, false);
						get_m_actor().m_multiSound.HDOLPLIDACO("invalid costume2 {0}", false, 1595f, 426f);
					}
				}
			}
			target.OnAttackDamage(get_m_actor(), 1438.0, num, 29.0);
			IAKBNJEFLAN(target);
			if (get_m_actor().GetSkillLevel(1) > 0 && (!target.get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)115) || flag))
			{
				target.get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)65517, get_m_actor(), 626f, 862f, false);
			}
			if (num > 18f && target.m_lastDamageInfo.IKAIHHIDHFK)
			{
				float bFEBCIGOMGL = 421f + (float)(get_m_actor().GetSkillLevel(1) - 1) * 43f;
				get_m_actor().AddMpRemote(bFEBCIGOMGL);
				LFNNHEEJNGP[0].IHKCKBJBEGF = LFNNHEEJNGP[0].BKBFHEJIHNK(get_m_actor(), get_m_actor().GetSkillLevel(1)) - 319f;
			}
		}
		OnAttack();
	}

	private Actor HLDMLBOMPCD()
	{
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), 4.8f, 15f, false, true, Actor.IJJMDPGJAEM.Hero);
		if (actorInAttackRange == null)
		{
			actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), 4.8f, 90f, false, true, (Actor.IJJMDPGJAEM)14);
		}
		return actorInAttackRange;
	}

	public virtual bool FKPHLJDLNBM(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 0)
		{
			KAMDFGHFGCI = HLDMLBOMPCD();
			if (KAMDFGHFGCI == null)
			{
				MsgManager.HEDJPPFKABG().LBCFANDMCON("실패하였습니다");
				return false;
			}
		}
		return true;
	}
}
