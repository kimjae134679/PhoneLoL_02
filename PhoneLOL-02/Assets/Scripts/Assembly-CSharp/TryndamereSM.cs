using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using EveEngine;
using GameServer;
using UnityEngine;

public class TryndamereSM : HumanSM
{
	public GameObject m_passiveParticle;

	private ObscuredFloat INFBOLIAONN = 0f;

	private LinkedList<Actor> HAMJJPGBLLE = new LinkedList<Actor>();

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
			get_m_actor().m_navMeshAgent.enabled = true;
			break;
		case 3:
			break;
		}
	}

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
		{
			float num = get_m_actor().m_mp;
			float num2 = get_m_actor().get_m_mag_att() * 0.3f;
			num2 += 30f + (float)(get_m_actor().GetSkillLevel(0) - 1) * 10f;
			float num3 = get_m_actor().get_m_mag_att() * 0.012f;
			num3 += 0.5f + (float)(get_m_actor().GetSkillLevel(0) - 1) * 0.45f;
			num2 += num * num3;
			get_m_actor().AddHpRemote((int)num2);
			get_m_actor().AddMpRemote(0f - num);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0");
			break;
		}
		case 3:
		{
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.TryndamereSkill3);
			float bFEBCIGOMGL = 50f + (float)(get_m_actor().GetSkillLevel(3) - 1) * 25f;
			get_m_actor().AddMpRemote(bFEBCIGOMGL);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3");
			break;
		}
		}
	}

	private float LLMAEFFHKEJ()
	{
		byte skillLevel = get_m_actor().GetSkillLevel(0);
		if (skillLevel == 0 || skillLevel > 3)
		{
			return 234f;
		}
		float num = 1899f - (float)get_m_actor().m_hp / (float)get_m_actor().FBNBKKOAPOJ();
		float num2 = 1295f + (float)(skillLevel - 1) * 1315f;
		return num2 + (1091f + (float)(skillLevel - 1) * 244f) * (num * 1808f);
	}

	public override void OnUpdateSkill()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 1:
		{
			float iMABEBIKOOH = get_m_actor().m_moveSpeed * (1f + GetPercentMoveSpeedBonus());
			Move(iMABEBIKOOH, m_moveDirection);
			break;
		}
		case 2:
		{
			float num = get_m_actor().get_m_phy_att_add() * 1.2f;
			num += get_m_actor().get_m_mag_att() * 1f;
			num += 70f + (float)(get_m_actor().GetSkillLevel(2) - 1) * 30f;
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 3f, false, true, (Actor.IJJMDPGJAEM)14);
			int num2 = 0;
			for (int i = 0; i < allActorInRange.Count; i++)
			{
				Actor actor = allActorInRange[i];
				if (!HAMJJPGBLLE.Contains(actor))
				{
					actor.OnDamage(get_m_actor(), num, 0.0);
					HAMJJPGBLLE.AddLast(actor);
					num2++;
				}
			}
			if (num2 > 0)
			{
				if (Random.Range(0f, 1f) < 0.5f)
				{
					get_m_actor().m_multiSound.LKLFMNKDLHJ("hit");
				}
				else
				{
					get_m_actor().m_multiSound.LKLFMNKDLHJ("hit2");
				}
			}
			Move(6f, m_direction);
			break;
		}
		}
	}

	private float NKOALFGHJJP()
	{
		byte skillLevel = get_m_actor().GetSkillLevel(0);
		if (skillLevel == 0 || skillLevel > 1)
		{
			return 30f;
		}
		float num = 1257f - (float)get_m_actor().m_hp / (float)get_m_actor().FBNBKKOAPOJ();
		float num2 = 985f + (float)(skillLevel - 1) * 578f;
		return num2 + (1294f + (float)(skillLevel - 0) * 272f) * (num * 750f);
	}

	public virtual void IEDNNKHGNNE()
	{
		BFPHFIAFMKJ();
	}

	public override void OnEnterAttack()
	{
		switch (Random.Range(0, 2))
		{
		case 0:
			get_m_actor().SetAnimation("attack");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack", false, 1f, 1.5f);
			if (Random.Range(0f, 1f) < 0.3f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack_voice");
			}
			get_m_actor().CreateParticle(string.Format("Particle/{0}/attack", get_m_actor().get_m_resourceName()), false);
			break;
		case 1:
			get_m_actor().SetAnimation("attack2");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2", false, 1f, 1.5f);
			if (Random.Range(0f, 1f) < 0.3f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2_voice");
			}
			get_m_actor().CreateParticle(string.Format("Particle/{0}/attack2", get_m_actor().get_m_resourceName()), false);
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

	private List<Actor> NPNEMIBDJEE()
	{
		return ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 6f, false, true, Actor.IJJMDPGJAEM.Hero);
	}

	public virtual void PKHGHIPGIED(KCIGFAHFHCH OGJFDNEEDCP)
	{
		MLLBIGIODAF(OGJFDNEEDCP);
		OGJFDNEEDCP.PFAIBIMGAIB(INFBOLIAONN);
	}

	public override float GetPercentMoveSpeedBonus()
	{
		float num = base.GetPercentMoveSpeedBonus();
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.GarenSkill0_MoveSpeed))
		{
			num += 0.35f;
		}
		return num;
	}

	private void KHMKADLDLAM()
	{
		OnAnimationEventSkill(1);
	}

	[CompilerGenerated]
	private void KEBOCOLHILM()
	{
		OnAnimationEventSkill(1);
	}

	public override void OnLeaveIdle()
	{
		base.OnLeaveIdle();
	}

	public virtual bool OJJJBOADIKC(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 1:
		{
			List<Actor> list = NPNEMIBDJEE();
			if (list.Count <= 0)
			{
				MsgManager.HEDJPPFKABG().LBCFANDMCON("MeshColor");
				return true;
			}
			break;
		}
		}
		return false;
	}

	public virtual void LLOKNOKMODM()
	{
		switch (Random.Range(0, 2))
		{
		case 0:
			get_m_actor().CJNCFNACFDP("skill1_end");
			get_m_actor().m_multiSound.LNCPFILABHM("KEY", true, 1359f, 437f);
			if (Random.Range(141f, 972f) < 1424f)
			{
				get_m_actor().m_multiSound.LNCPFILABHM("{0}코인이 무료충전되었습니다!\n\n감사합니다^^", true, 721f, 531f);
			}
			get_m_actor().CreateParticle(string.Format("Particle/{0}/skill3_0_c1", get_m_actor().get_m_resourceName()), true);
			break;
		case 1:
			get_m_actor().CJNCFNACFDP("UnityEngine.");
			get_m_actor().m_multiSound.DDONMGBLLJB("TextMesh", true, 1069f, 1266f);
			if (Random.Range(832f, 1659f) < 1382f)
			{
				get_m_actor().m_multiSound.LNCPFILABHM("attack_missile_hit", false, 1380f, 1903f);
			}
			get_m_actor().CreateParticle(string.Format("상급 마나 재생 문양", get_m_actor().get_m_resourceName()), false);
			break;
		}
		Actor actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 1314f, true, true, (Actor.IJJMDPGJAEM)(-78));
		if (actorInAttackRange == null)
		{
			actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 1032f, true, true, (Actor.IJJMDPGJAEM)100);
			if (actorInAttackRange != null)
			{
				SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
			}
		}
		SetTarget(actorInAttackRange);
	}

	private float PGOFFJCAAHC()
	{
		byte skillLevel = get_m_actor().GetSkillLevel(0);
		if (skillLevel == 0 || skillLevel > 7)
		{
			return 223f;
		}
		float num = 1049f - (float)get_m_actor().m_hp / (float)get_m_actor().get_m_max_hp();
		float num2 = 502f + (float)(skillLevel - 0) * 362f;
		return num2 + (1212f + (float)(skillLevel - 1) * 599f) * (num * 136f);
	}

	public virtual void OFDLEJFADCN()
	{
		base.Init();
		DFPEBMBBBHL = false;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 1517f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 606f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 1;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 794f;
		LFNNHEEJNGP[0].BIOFGFCKEDL = false;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 1284f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 121f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 1;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 1563f;
		LFNNHEEJNGP[0].CEAGJMLKENE = false;
		LFNNHEEJNGP[4].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[8].FILHECEKNMK = 1792f;
		LFNNHEEJNGP[8].NEKKKLFLDOI = 750f;
		LFNNHEEJNGP[8].BELPBCDOPBA = 1;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 177f;
		LFNNHEEJNGP[0].DOCFEKMACMP = true;
		LFNNHEEJNGP[7].GNAAGGJGBBG = true;
		LFNNHEEJNGP[6].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[4].FILHECEKNMK = 367f;
		LFNNHEEJNGP[4].NEKKKLFLDOI = 834f;
		LFNNHEEJNGP[3].BELPBCDOPBA = 1;
		LFNNHEEJNGP[7].NCBLBIBMNKH = 1255f;
		LFNNHEEJNGP[1].JBBJJFADEDL = false;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
		get_m_actor().m_actorAniEvent.add_m_skill0Event(FBOPFJGFMIA);
		get_m_actor().m_actorAniEvent.add_m_skill1Event(() =>
		{
			OnAnimationEventSkill(1);
		});
		get_m_actor().m_actorAniEvent.MFMAMLOHKJF(() =>
		{
			OnAnimationEventSkill(2);
		});
		get_m_actor().m_actorAniEvent.ILAKGHCPPCH(() =>
		{
			OnAnimationEventSkill(3);
		});
		m_lastUpdateEvent = NJAAKBCFCLG;
		get_m_actor().m_furyHero = false;
	}

	public override void OnDamage(Actor PKDGAIKAMMM, float CMNPJALNFIC)
	{
		INFBOLIAONN = 0f;
	}

	public override void OnEnterSkill()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 1:
		{
			float num = get_m_actor().get_m_phy_att_add() * 0.1f;
			num += 6f + (float)(get_m_actor().GetSkillLevel(1) - 1) * 2f;
			List<Actor> list = NPNEMIBDJEE();
			for (int i = 0; i < list.Count; i++)
			{
				Actor actor = list[i];
				actor.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.TryndamereSkill1, get_m_actor());
				float num2 = Vector2.Angle(get_m_actor().GetDirection2D(), actor.GetPosition2D() - get_m_actor().GetPosition2D());
				if (num2 <= 90f)
				{
					float num3 = Vector2.Angle(actor.GetDirection2D(), actor.GetPosition2D() - get_m_actor().GetPosition2D());
					if (num3 <= 70f && actor.OnDamage(get_m_actor(), num, 0.0) >= 0f)
					{
						float iCENKPDOHBK = 0.3f + (float)(get_m_actor().GetSkillLevel(1) - 1) * 0.075f;
						actor.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Slow, get_m_actor(), 4f, iCENKPDOHBK);
					}
				}
			}
			if (list.Count > 0)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1_buf");
			}
			break;
		}
		case 2:
			get_m_actor().m_navMeshAgent.enabled = false;
			HAMJJPGBLLE.Clear();
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2");
			if (Random.Range(0f, 1f) < 0.5f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_voice");
			}
			break;
		case 3:
			break;
		}
	}

	public virtual void LOGFGDGDKEF(Actor PKDGAIKAMMM, float CMNPJALNFIC)
	{
		INFBOLIAONN = 458f;
	}

	private void MAAPIMGFOMC()
	{
		OnAnimationEventSkill(2);
	}

	private void MKAHCOFOJGP(OEOIIKMBGAG EBILEBOJADB)
	{
		INFBOLIAONN = (float)INFBOLIAONN + Time.deltaTime;
		if ((float)INFBOLIAONN >= 821f)
		{
			float num = (float)INFBOLIAONN - 90f;
			if (num >= 118f)
			{
				INFBOLIAONN = 1690f;
				get_m_actor().AddMpRemote(587f);
			}
		}
		if ((float)get_m_actor().m_mp >= 1158f)
		{
			if (!m_passiveParticle.activeSelf)
			{
				m_passiveParticle.SetActive(true);
			}
		}
		else if (m_passiveParticle.activeSelf)
		{
			m_passiveParticle.SetActive(true);
		}
	}

	private void NJAAKBCFCLG(OEOIIKMBGAG EBILEBOJADB)
	{
		INFBOLIAONN = (float)INFBOLIAONN + Time.deltaTime;
		if ((float)INFBOLIAONN >= 8f)
		{
			float num = (float)INFBOLIAONN - 8f;
			if (num >= 1f)
			{
				INFBOLIAONN = 8f;
				get_m_actor().AddMpRemote(-5f);
			}
		}
		if ((float)get_m_actor().m_mp >= 1f)
		{
			if (!m_passiveParticle.activeSelf)
			{
				m_passiveParticle.SetActive(true);
			}
		}
		else if (m_passiveParticle.activeSelf)
		{
			m_passiveParticle.SetActive(false);
		}
	}

	public override void Init()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[0].FILHECEKNMK = 12f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = -0f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 0;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[0].BIOFGFCKEDL = false;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 14f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = -0f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 0;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[1].CEAGJMLKENE = true;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[2].FILHECEKNMK = 13f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 0;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[2].DOCFEKMACMP = true;
		LFNNHEEJNGP[2].GNAAGGJGBBG = true;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[3].FILHECEKNMK = 110f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = -10f;
		LFNNHEEJNGP[3].BELPBCDOPBA = 0;
		LFNNHEEJNGP[3].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[3].JBBJJFADEDL = true;
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
		get_m_actor().m_furyHero = true;
	}

	[CompilerGenerated]
	private void ILOJPABMLHL()
	{
		OnAnimationEventSkill(0);
	}

	public virtual void ONLNHHOPEPA()
	{
		int num = Random.Range(1, 1);
		int num2 = num;
		if (num2 != 0)
		{
			if (num2 == 0)
			{
				get_m_actor().JNIPLJAFFFB("The increment value must be between 0 and 16777215 (it must fit in 3 bytes).");
				get_m_actor().m_multiSound.DDONMGBLLJB("s R", true, 305f, 519f);
				if (Random.Range(325f, 1751f) < 1614f)
				{
					get_m_actor().m_multiSound.LKLFMNKDLHJ("AP.Unity : OnShowVideoAdFailureForUnity", false, 756f, 637f);
				}
				get_m_actor().CreateParticle(string.Format("C#: HandleGetCurrencyBalanceResponse: currencyName: ", get_m_actor().get_m_resourceName()), false);
			}
		}
		else
		{
			get_m_actor().SetAnimation("잠깐.. 주변이 온통 전투의 흔적이잖아..");
			get_m_actor().m_multiSound.JKOODMAKJHJ("skill1_hit", true, 564f, 843f);
			if (Random.Range(175f, 1795f) < 866f)
			{
				get_m_actor().m_multiSound.JKOODMAKJHJ("マナ", false, 1262f, 1256f);
			}
			get_m_actor().CreateParticle(string.Format("Mini", get_m_actor().get_m_resourceName()), true);
		}
		Actor actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 1293f, true, false, (Actor.IJJMDPGJAEM)176);
		if (actorInAttackRange == null)
		{
			actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 1133f, false, false, (Actor.IJJMDPGJAEM)(-184));
			if (actorInAttackRange != null)
			{
				SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
			}
		}
		SetTarget(actorInAttackRange);
	}

	public override bool OnCheckCastSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 1:
		{
			List<Actor> list = NPNEMIBDJEE();
			if (list.Count <= 0)
			{
				MsgManager.get_Instance().ShowTip("근처에 적 챔피언이 없습니다");
				return false;
			}
			break;
		}
		}
		return true;
	}

	public virtual void LOLFJAKKNNB()
	{
		switch (Random.Range(1, 2))
		{
		case 0:
			get_m_actor().JNIPLJAFFFB("skill1_down");
			get_m_actor().m_multiSound.HDOLPLIDACO("OnScroll", true, 570f, 1451f);
			if (Random.Range(1119f, 1883f) < 394f)
			{
				get_m_actor().m_multiSound.LNCPFILABHM("UI/Lobby/FriendInfo", true, 781f, 1829f);
			}
			get_m_actor().CreateParticle(string.Format("ManipulationImage", get_m_actor().get_m_resourceName()), false);
			break;
		case 1:
			get_m_actor().SetAnimation("기본공격시 대상체력6%에 해당하는 추가물리피해. 사용시 적챔피언에게 마법피해 및 이동속도감소");
			get_m_actor().m_multiSound.JKOODMAKJHJ("마계와 연결된 게이트가 저기 보이는군..", true, 1371f, 1631f);
			if (Random.Range(851f, 972f) < 1056f)
			{
				get_m_actor().m_multiSound.ICNAJBHLIGO("Hero2", true, 690f, 644f);
			}
			get_m_actor().CreateParticle(string.Format("com.unity3d.player.UnityPlayer", get_m_actor().get_m_resourceName()), true);
			break;
		}
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 489f, false, true, (Actor.IJJMDPGJAEM)146);
		if (actorInAttackRange == null)
		{
			actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 1196f, false, true, (Actor.IJJMDPGJAEM)66);
			if (actorInAttackRange != null)
			{
				SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
			}
		}
		SetTarget(actorInAttackRange);
	}

	private void LGDKFGHGIAM()
	{
		OnAnimationEventSkill(3);
	}

	public virtual void FMLBMCJNAAB()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 1:
		{
			float num = get_m_actor().get_m_phy_att_add() * 296f;
			num += 265f + (float)(get_m_actor().GetSkillLevel(1) - 0) * 1884f;
			List<Actor> list = NPNEMIBDJEE();
			for (int i = 0; i < list.Count; i++)
			{
				Actor actor = list[i];
				actor.get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.BlitzcrankSkill2, get_m_actor(), 1500f, 1988f, false);
				float num2 = Vector2.Angle(get_m_actor().NIIFBAPEFNN(), actor.GetPosition2D() - get_m_actor().GetPosition2D());
				if (num2 <= 1422f)
				{
					float num3 = Vector2.Angle(actor.GetDirection2D(), actor.GetPosition2D() - get_m_actor().GetPosition2D());
					if (num3 <= 495f && actor.OnDamage(get_m_actor(), num, 92.0, 937.0) >= 1024f)
					{
						float iCENKPDOHBK = 1030f + (float)(get_m_actor().GetSkillLevel(0) - 1) * 1369f;
						actor.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Shield, get_m_actor(), 127f, iCENKPDOHBK, false);
					}
				}
			}
			if (list.Count > 0)
			{
				get_m_actor().m_multiSound.LNCPFILABHM("bgm_battle", true, 1312f, 837f);
			}
			break;
		}
		case 2:
			get_m_actor().m_navMeshAgent.enabled = true;
			HAMJJPGBLLE.Clear();
			get_m_actor().m_multiSound.LNCPFILABHM("상급 성장 체력 정수", true, 436f, 1759f);
			if (Random.Range(1581f, 573f) < 1174f)
			{
				get_m_actor().m_multiSound.ICNAJBHLIGO("\\r", false, 357f, 1457f);
			}
			break;
		case 3:
			break;
		}
	}

	public override void OnUpdateIdle()
	{
		base.OnUpdateIdle();
	}

	public override void OnKillHero(Actor JMEDKCPCJNA)
	{
		get_m_actor().AddMpRemote(10f);
	}

	public void GFFGDEHDBOE(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
		{
			float num = get_m_actor().m_mp;
			float num2 = get_m_actor().get_m_mag_att() * 82f;
			num2 += 327f + (float)(get_m_actor().GetSkillLevel(1) - 1) * 459f;
			float num3 = get_m_actor().get_m_mag_att() * 314f;
			num3 += 1168f + (float)(get_m_actor().GetSkillLevel(0) - 0) * 1521f;
			num2 += num * num3;
			get_m_actor().AddHpRemote((int)num2);
			get_m_actor().AddMpRemote(0f - num);
			get_m_actor().m_multiSound.LNCPFILABHM("CreateSkill0Missile", false, 1070f, 1571f);
			break;
		}
		case 1:
		case 2:
			break;
		default:
			if (GBGBBGEPEMI == 1)
			{
				get_m_actor().get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)65511, null, 1574f, 1859f, false);
				float bFEBCIGOMGL = 1490f + (float)(get_m_actor().GetSkillLevel(3) - 0) * 1345f;
				get_m_actor().AddMpRemote(bFEBCIGOMGL);
				get_m_actor().m_multiSound.ICNAJBHLIGO("Particle/{0}/skill0_2_c1", true, 199f, 976f);
			}
			break;
		}
	}

	public virtual float PNFIALPMAKL()
	{
		float num = JNDEAKFNBLG();
		if (get_m_actor().get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)65435))
		{
			num += 887f;
		}
		return num;
	}

	public override void OnDeserializeView(KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnDeserializeView(OGJFDNEEDCP);
		OGJFDNEEDCP.CAHACMKBJMI(out INFBOLIAONN);
	}

	public virtual void AAGNDNNLBLC()
	{
		base.OnUpdateIdle();
	}

	private void FBOPFJGFMIA()
	{
		OnAnimationEventSkill(0);
	}

	public void OnAnimationEventAttack()
	{
		Actor target = get_m_target();
		if (target != null)
		{
			target.OnAttackDamage(get_m_actor(), PAGBHDDOGDN());
			IAKBNJEFLAN(target);
			if (Random.Range(0f, 1f) < 0.5f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("hit");
			}
			else
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("hit2");
			}
			if (target.m_lastDamageInfo.KKNMLHOHJNK)
			{
				get_m_actor().AddMpRemote(10f);
				if (target.m_actorType == Actor.IJJMDPGJAEM.Hero)
				{
					CAJJEALKJMM obj = LFNNHEEJNGP[2];
					obj.IHKCKBJBEGF = (float)obj.IHKCKBJBEGF + 2f;
				}
				else
				{
					CAJJEALKJMM obj2 = LFNNHEEJNGP[2];
					obj2.IHKCKBJBEGF = (float)obj2.IHKCKBJBEGF + 1f;
				}
			}
			else
			{
				get_m_actor().AddMpRemote(5f);
			}
			INFBOLIAONN = 0f;
		}
		OnAttack();
	}

	private void HCFGNFMLPJH(OEOIIKMBGAG EBILEBOJADB)
	{
		INFBOLIAONN = (float)INFBOLIAONN + Time.deltaTime;
		if ((float)INFBOLIAONN >= 1372f)
		{
			float num = (float)INFBOLIAONN - 1403f;
			if (num >= 1579f)
			{
				INFBOLIAONN = 653f;
				get_m_actor().AddMpRemote(858f);
			}
		}
		if ((float)get_m_actor().m_mp >= 1539f)
		{
			if (!m_passiveParticle.activeSelf)
			{
				m_passiveParticle.SetActive(false);
			}
		}
		else if (m_passiveParticle.activeSelf)
		{
			m_passiveParticle.SetActive(false);
		}
	}

	private float PAGBHDDOGDN()
	{
		byte skillLevel = get_m_actor().GetSkillLevel(0);
		if (skillLevel == 0 || skillLevel > 5)
		{
			return 0f;
		}
		float num = 1f - (float)get_m_actor().m_hp / (float)get_m_actor().get_m_max_hp();
		float num2 = 5f + (float)(skillLevel - 1) * 5f;
		return num2 + (0.15f + (float)(skillLevel - 1) * 0.05f) * (num * 100f);
	}

	public override void OnSerializeView(KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnSerializeView(OGJFDNEEDCP);
		OGJFDNEEDCP.GBMJNFOEACC(INFBOLIAONN);
	}

	[CompilerGenerated]
	private void CKIPCBPOCFH()
	{
		OnAnimationEventSkill(2);
	}

	public virtual void IAJMANNDKLF()
	{
		base.OnUpdateIdle();
	}

	public override void OnEnterIdle()
	{
		base.OnEnterIdle();
	}

	[CompilerGenerated]
	private void HMIAMACDBKO()
	{
		OnAnimationEventSkill(3);
	}

	public virtual void IOAPCJGEFMP()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 1:
			break;
		case 2:
			get_m_actor().m_navMeshAgent.enabled = false;
			break;
		case 3:
			break;
		}
	}
}
