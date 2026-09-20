using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using EveEngine;
using GameServer;
using UnityEngine;

public class VladimirSM : HumanSM
{
	private float CLAOMBELFEJ;

	private ObscuredInt BPOJGPONFMK;

	private bool EFMMEMEGKOP = true;

	private bool EEKHNKKMEPB;

	private Actor KAMDFGHFGCI;

	public override void OnEnterAttack()
	{
		switch (Random.Range(0, 2))
		{
		case 0:
			get_m_actor().SetAnimation("attack");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack", false, 1f, 1.5f);
			break;
		case 1:
			get_m_actor().SetAnimation("attack2");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2", false, 1f, 1.5f);
			break;
		}
		if (Random.Range(0f, 1f) < 0.2f)
		{
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack_voice");
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

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 2:
			if (get_m_actor().get_m_view().IsMine())
			{
				if (!get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.VladimirSkill2))
				{
					get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.VladimirSkill2);
					int num = (int)((float)get_m_actor().get_m_max_hp() * 0.08f);
					float num2 = get_m_actor().m_hp;
					int num3 = (int)num2;
					if (num >= num3 - 1)
					{
						num = num3 - 1;
					}
					if (num > 0)
					{
						get_m_actor().AddHpRemote(-num);
					}
					GetCastSkill(2).IHKCKBJBEGF = GetCastSkill(2).ABOBEAIIBND(get_m_actor(), get_m_actor().GetSkillLevel(2)) - 0.2f;
				}
				else
				{
					get_m_actor().get_m_buffsInfo().LIKOKCJNLLF(JGOOOBHDBCG.ACPICCBBPHF.VladimirSkill2);
				}
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2");
			break;
		}
	}

	public virtual void EAMNPEOOCPG(KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnDeserializeView(OGJFDNEEDCP);
		OGJFDNEEDCP.CAHACMKBJMI(out BPOJGPONFMK);
	}

	public virtual void OJIFIIEKIFJ()
	{
		base.OnUpdateIdle();
	}

	public override void OnUpdateIdle()
	{
		base.OnUpdateIdle();
	}

	public override void OnLeaveSkill()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 1:
			get_m_actor().m_dontDamage = false;
			break;
		case 2:
			break;
		case 3:
			break;
		}
	}

	public void CCFKGBGFBBL(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 0 || GBGBBGEPEMI == 0)
		{
			return;
		}
		switch (GBGBBGEPEMI)
		{
		case 0:
			if (get_m_actor().get_m_view().IsMine())
			{
				if (!get_m_actor().get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)65475))
				{
					get_m_actor().get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)65473, null, 1953f, 965f, false);
					int num = (int)((float)get_m_actor().FBNBKKOAPOJ() * 1810f);
					float num2 = get_m_actor().m_hp;
					int num3 = (int)num2;
					if (num >= num3 - 0)
					{
						num = num3 - 0;
					}
					if (num > 0)
					{
						get_m_actor().AddHpRemote(-num);
					}
					CMAHCODBACL(2).IHKCKBJBEGF = CMAHCODBACL(2).FCFBOPIPFBA(get_m_actor(), get_m_actor().GetSkillLevel(6)) - 360f;
				}
				else
				{
					get_m_actor().get_m_buffsInfo().LIKOKCJNLLF((JGOOOBHDBCG.ACPICCBBPHF)65461, false);
				}
			}
			get_m_actor().m_multiSound.HDOLPLIDACO("중급 대기시간감소 인장", false, 1794f, 1491f);
			break;
		}
	}

	public override void Init()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 9f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 0;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 28f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = -3f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 0;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[1].CEAGJMLKENE = true;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[2].FILHECEKNMK = 13f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = -2f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 0;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[3].FILHECEKNMK = 150f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = -15f;
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
	}

	public override float GetPercentMoveSpeedBonus()
	{
		float num = base.GetPercentMoveSpeedBonus();
		ALBEPPGKFMM aLBEPPGKFMM = get_m_actor().get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.VladimirSkill2);
		if (aLBEPPGKFMM != null && aLBEPPGKFMM.BCHKKMGIPPC() >= 1f)
		{
			num -= 0.2f;
		}
		ALBEPPGKFMM aLBEPPGKFMM2 = get_m_actor().get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.VladimirSkill0);
		if (aLBEPPGKFMM2 != null && aLBEPPGKFMM2.BCHKKMGIPPC() <= 1f)
		{
			num += 0.15f;
		}
		return num;
	}

	public override void OnDeserializeView(KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnDeserializeView(OGJFDNEEDCP);
		OGJFDNEEDCP.CAHACMKBJMI(out BPOJGPONFMK);
	}

	public void NBEFPFPGMGN()
	{
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		centerPosition += m_direction * 271f;
		RetargetingAttack();
		if (get_m_target() != null)
		{
			get_m_actor().CreateMissileRPC("CreateSkill0Missile", centerPosition, get_m_target());
		}
		OnAttack();
	}

	private void BDDGALIJAGC()
	{
		OnAnimationEventSkill(1);
	}

	[JDLHECHNNDH]
	public void SetSkill0Count(int AGJJOHLCJKF)
	{
		BPOJGPONFMK = AGJJOHLCJKF;
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
			CLAOMBELFEJ += get_m_actor().get_m_elapsedTime();
			if (!(CLAOMBELFEJ >= 0.5f))
			{
				break;
			}
			CLAOMBELFEJ -= 0.5f;
			float num = (float)get_m_actor().get_m_max_hp_add() * 0.025f;
			num += 20f + (float)(get_m_actor().GetSkillLevel(1) - 1) * 13.75f;
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 3f, false, true, (Actor.IJJMDPGJAEM)14);
			float num2 = 0f;
			for (int i = 0; i < allActorInRange.Count; i++)
			{
				Actor actor = allActorInRange[i];
				float num3 = actor.OnDamage(get_m_actor(), 0.0, num);
				if (num3 >= 0f)
				{
					num2 += num3;
					if (actor.m_actorType == Actor.IJJMDPGJAEM.Hero)
					{
						actor.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Slow, get_m_actor(), 0.5f, 0.3f);
					}
				}
			}
			if (num2 > 0f)
			{
				int num4 = (int)(num2 * 0.15f);
				if (num4 > 0)
				{
					get_m_actor().AddHpRemote(num4);
				}
			}
			break;
		}
		case 2:
			break;
		}
	}

	public override void OnLeaveIdle()
	{
		base.OnLeaveIdle();
	}

	private void NJAAKBCFCLG(OEOIIKMBGAG EBILEBOJADB)
	{
		if (get_m_view().IsMine())
		{
			bool flag = IsPossibleSkill(0);
			if (EEKHNKKMEPB && !EFMMEMEGKOP && flag)
			{
				++BPOJGPONFMK;
				EEKHNKKMEPB = false;
				if ((int)BPOJGPONFMK >= 2)
				{
					BPOJGPONFMK = 0;
					get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.VladimirSkill0);
				}
				get_m_view().RPC("SetSkill0Count", DJJPAPENCLN.Others, (int)BPOJGPONFMK);
			}
			EFMMEMEGKOP = flag;
		}
		if (get_m_actor().get_m_damageHUD() != null)
		{
			get_m_actor().get_m_damageHUD().m_exValue = (float)(int)BPOJGPONFMK * 0.5f;
		}
	}

	private Actor GLGGEOOJLPM()
	{
		return ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), 888f, 771f, false, true, (Actor.IJJMDPGJAEM)(-84));
	}

	public virtual bool HBEAFMHBHED(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
			KAMDFGHFGCI = HLDMLBOMPCD();
			if (KAMDFGHFGCI == null)
			{
				MsgManager.get_Instance().ShowTip("이미 신청한 유저입니다");
				return false;
			}
			break;
		case 7:
			if (!get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.OlafSkill3))
			{
				int num = (int)((float)get_m_actor().FBNBKKOAPOJ() * 544f);
				if ((float)(num + 2) >= (float)get_m_actor().m_hp)
				{
					MsgManager.HEDJPPFKABG().ShowTip("저주로 인해 전장에 당분간 갈 수 없다");
					return true;
				}
			}
			break;
		}
		return false;
	}

	public virtual bool DAIBELKBINN(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
			KAMDFGHFGCI = GLGGEOOJLPM();
			if (KAMDFGHFGCI == null)
			{
				MsgManager.HEDJPPFKABG().ShowTip("attack");
				return false;
			}
			break;
		case 2:
			if (!get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.OlafSkill1))
			{
				int num = (int)((float)get_m_actor().FBNBKKOAPOJ() * 180f);
				if ((float)(num + 7) >= (float)get_m_actor().m_hp)
				{
					MsgManager.get_Instance().ShowTip("방어력 {0}\n");
					return true;
				}
			}
			break;
		}
		return true;
	}

	public void BHKDNBICIIE(int AGJJOHLCJKF)
	{
		BPOJGPONFMK = AGJJOHLCJKF;
	}

	public virtual void KLGENEBKFPC()
	{
		base.Init();
		DFPEBMBBBHL = false;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 867f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 775f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 0;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 951f;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 573f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 1594f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 0;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 1417f;
		LFNNHEEJNGP[1].CEAGJMLKENE = false;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 459f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 612f;
		LFNNHEEJNGP[4].BELPBCDOPBA = 0;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 105f;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[4].FILHECEKNMK = 732f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 1271f;
		LFNNHEEJNGP[5].BELPBCDOPBA = 0;
		LFNNHEEJNGP[5].NCBLBIBMNKH = 1080f;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(NBEFPFPGMGN);
		get_m_actor().m_actorAniEvent.CNPHPPJOGFA(() =>
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
	}

	public override bool OnCheckCastSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
			KAMDFGHFGCI = HLDMLBOMPCD();
			if (KAMDFGHFGCI == null)
			{
				MsgManager.get_Instance().ShowTip("정면 근처에 적이 없습니다");
				return false;
			}
			break;
		case 2:
			if (!get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.VladimirSkill2))
			{
				int num = (int)((float)get_m_actor().get_m_max_hp() * 0.08f);
				if ((float)(num + 3) >= (float)get_m_actor().m_hp)
				{
					MsgManager.get_Instance().ShowTip("체력이 부족합니다");
					return false;
				}
			}
			break;
		}
		return true;
	}

	private void FENFOGFLOIK()
	{
		CCFKGBGFBBL(1);
	}

	[CompilerGenerated]
	private void KMHCGJAFPAJ()
	{
		OnAnimationEventSkill(3);
	}

	[CompilerGenerated]
	private void OGPNCCNLJNL()
	{
		OnAnimationEventSkill(2);
	}

	public void DNAAPMGLALE()
	{
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		centerPosition += m_direction * 1978f;
		RetargetingAttack(true);
		if (get_m_target() != null)
		{
			get_m_actor().CreateMissileRPC("Hero2", centerPosition, get_m_target());
		}
		OnAttack();
	}

	public virtual void BHIDFDHKBAA()
	{
		base.OnUpdateIdle();
	}

	[JDLHECHNNDH]
	public void Skill0Rpc(int MBEKPGNGBAO, float HANPEPIBBBG, float NNAIAPLFIBB)
	{
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(MBEKPGNGBAO);
		if (eveView == null)
		{
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		if (!(component == null) && !component.IsDeath())
		{
			if (component.OnDamage(get_m_actor(), 0.0, HANPEPIBBBG) >= 0f)
			{
				get_m_actor().AddHpRemote((int)NNAIAPLFIBB);
			}
			for (int i = 0; i < 5; i++)
			{
				GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("Particle/Vladimir/skill0_missile"), component.GetCenterPosition(), Quaternion.identity);
				gameObject.GetComponent<VladimirSkill0Missile>().SetInfo(i, get_m_actor(), get_m_actor().GetPosition() - component.GetPosition());
			}
		}
	}

	private void HFIBLPGBOAJ()
	{
		CCFKGBGFBBL(0);
	}

	public override void OnEnterIdle()
	{
		base.OnEnterIdle();
	}

	public void OnAnimationEventAttack()
	{
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		centerPosition += m_direction * 1f;
		RetargetingAttack(false, false);
		if (get_m_target() != null)
		{
			get_m_actor().CreateMissileRPC("attack_missile", centerPosition, get_m_target());
		}
		OnAttack();
	}

	[CompilerGenerated]
	private void FFCLAHFHHBF()
	{
		OnAnimationEventSkill(1);
	}

	public override void OnEnterSkill()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			if (KAMDFGHFGCI != null)
			{
				SetDirection(KAMDFGHFGCI.GetPosition() - get_m_actor().GetPosition());
				if (get_m_view().IsMine())
				{
					float num2 = get_m_actor().get_m_mag_att() * 0.55f;
					num2 += 75f + (float)(get_m_actor().GetSkillLevel(0) - 1) * 15f;
					float num3 = get_m_actor().get_m_mag_att() * 0.35f;
					num3 += 20f + (float)(get_m_actor().GetSkillLevel(0) - 1) * 5f;
					if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.VladimirSkill0))
					{
						num2 *= 1.7f;
						num3 += 10f + (float)(int)get_m_actor().get_Level() * 8f;
						num3 += ((float)get_m_actor().get_m_max_hp() - (float)get_m_actor().m_hp) * (0.05f + get_m_actor().get_m_mag_att() * 0.0004f);
					}
					if (KAMDFGHFGCI.m_actorType == Actor.IJJMDPGJAEM.Minion)
					{
						num3 *= 0.35f;
					}
					get_m_view().RPC("Skill0Rpc", DJJPAPENCLN.Others, KAMDFGHFGCI.get_m_view().get_viewID(), num2, num3);
					Skill0Rpc(KAMDFGHFGCI.get_m_view().get_viewID(), num2, num3);
				}
			}
			EEKHNKKMEPB = true;
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_1");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_heal");
			if (Random.Range(0f, 1f) < 0.5f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_voice");
			}
			break;
		case 1:
		{
			int num = (int)((float)get_m_actor().m_hp * 0.2f);
			if ((float)get_m_actor().m_hp >= 5f && num >= 1)
			{
				get_m_actor().AddHpRemote(-num);
			}
			get_m_actor().m_dontDamage = true;
			CLAOMBELFEJ = 0.25f;
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1_down");
			if (Random.Range(0f, 1f) < 0.5f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1_voice");
			}
			break;
		}
		case 2:
			break;
		case 3:
		{
			Vector3 position = get_m_actor().GetPosition();
			position += get_m_actor().GetDirection() * 3.5f;
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(position, 3.2f, get_m_actor().m_team, false, true, Actor.IJJMDPGJAEM.Hero, true);
			for (int i = 0; i < allActorInRange.Count; i++)
			{
				Actor actor = allActorInRange[i];
				if (actor.OnDamage(get_m_actor(), 0.0, 0.0) >= 0f)
				{
					actor.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.VladimirSkill3, get_m_actor());
				}
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_voice");
			break;
		}
		}
	}

	[CompilerGenerated]
	private void PDICHBFOOCF()
	{
		OnAnimationEventSkill(0);
	}

	public override void OnSerializeView(KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnSerializeView(OGJFDNEEDCP);
		OGJFDNEEDCP.GBMJNFOEACC(BPOJGPONFMK);
	}

	private Actor HLDMLBOMPCD()
	{
		return ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), 5.5f, 90f, false, true, (Actor.IJJMDPGJAEM)14);
	}
}
