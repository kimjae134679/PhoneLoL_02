using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class KatarinaSM : HumanSM
{
	private int GOGLNMODMLA;

	private float ILEPJEHHMJK;

	private int HHBGIDOIFEG;

	private Actor KAMDFGHFGCI;

	private Actor NGNLJADPNNB;

	[CompilerGenerated]
	private static Comparison<Actor> HHEGEPCBALM;

	public override void OnLeaveSkill()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 2:
			get_m_actor().CreateParticle(string.Format("Particle/{0}/skill2_warp", get_m_actor().get_m_resourceName()), false);
			break;
		case 3:
			get_m_actor().m_multiSound.FLAIMHHIDLC("skill3_loop");
			break;
		case 1:
			break;
		}
	}

	private void NIEKDIHLDJP()
	{
		BMLNJLDJLNG(6);
	}

	public override void OnKillHero(Actor JMEDKCPCJNA)
	{
		CAJJEALKJMM obj = LFNNHEEJNGP[0];
		obj.IHKCKBJBEGF = (float)obj.IHKCKBJBEGF + 15f;
		CAJJEALKJMM obj2 = LFNNHEEJNGP[1];
		obj2.IHKCKBJBEGF = (float)obj2.IHKCKBJBEGF + 15f;
		CAJJEALKJMM obj3 = LFNNHEEJNGP[2];
		obj3.IHKCKBJBEGF = (float)obj3.IHKCKBJBEGF + 15f;
		CAJJEALKJMM obj4 = LFNNHEEJNGP[3];
		obj4.IHKCKBJBEGF = (float)obj4.IHKCKBJBEGF + 15f;
	}

	public override bool OnCheckCastSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
			KAMDFGHFGCI = ActorManager.get_Instance().GetActorInRangeForHero(get_m_actor(), 6.5f, false, true, (Actor.IJJMDPGJAEM)6);
			if (KAMDFGHFGCI == null)
			{
				KAMDFGHFGCI = ActorManager.get_Instance().GetActorInRangeForHero(get_m_actor(), 6.5f, false, true, Actor.IJJMDPGJAEM.Minion);
			}
			if (KAMDFGHFGCI == null)
			{
				MsgManager.get_Instance().ShowTip("정면 근처에 대상이 없습니다");
				return false;
			}
			SetDirection(KAMDFGHFGCI.GetPosition() - get_m_actor().GetPosition());
			break;
		case 2:
			NGNLJADPNNB = ActorManager.get_Instance().GetActorInRangeForHero(get_m_actor(), 7f, 45f, false, true, (Actor.IJJMDPGJAEM)14);
			if (NGNLJADPNNB == null)
			{
				NGNLJADPNNB = ActorManager.get_Instance().GetActorInRangeForHero(get_m_actor(), 7f, 45f, true, true, (Actor.IJJMDPGJAEM)14);
			}
			if (NGNLJADPNNB == null)
			{
				MsgManager.get_Instance().ShowTip("정면 근처에 대상이 없습니다");
				return false;
			}
			break;
		}
		return true;
	}

	public virtual void EJMIFKMKJOG(Actor JMEDKCPCJNA)
	{
		CAJJEALKJMM obj = LFNNHEEJNGP[1];
		obj.IHKCKBJBEGF = (float)obj.IHKCKBJBEGF + 425f;
		CAJJEALKJMM obj2 = LFNNHEEJNGP[1];
		obj2.IHKCKBJBEGF = (float)obj2.IHKCKBJBEGF + 1195f;
		CAJJEALKJMM obj3 = LFNNHEEJNGP[1];
		obj3.IHKCKBJBEGF = (float)obj3.IHKCKBJBEGF + 370f;
		CAJJEALKJMM obj4 = LFNNHEEJNGP[7];
		obj4.IHKCKBJBEGF = (float)obj4.IHKCKBJBEGF + 508f;
	}

	[CompilerGenerated]
	private void LBPLLCBJBFC()
	{
		OnAnimationEventSkill(1);
	}

	public override void OnUpdateSkill()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 1:
		{
			float iMABEBIKOOH = get_m_actor().m_moveSpeed * (1f + GetPercentMoveSpeedBonus());
			if (m_moveDirection.sqrMagnitude > 0.0001f) SetDirection(m_moveDirection);
			Move(iMABEBIKOOH, m_moveDirection);
			break;
		}
		case 3:
			ILEPJEHHMJK += get_m_actor().get_m_elapsedTime();
			if (ILEPJEHHMJK >= (float)HHBGIDOIFEG * 0.3f)
			{
				double num = (double)get_m_actor().get_m_phy_att() * 0.375;
				double num2 = (double)get_m_actor().get_m_mag_att() * 0.25;
				num2 += 35.0 + (double)(get_m_actor().GetSkillLevel(1) - 1) * 20.0;
				List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 5.4f, false, true, (Actor.IJJMDPGJAEM)14);
				allActorInRange.Sort((Actor IFGAPHGCLHF, Actor GMMDCPLBFJL) =>
				{
					if (IFGAPHGCLHF.m_actorType == Actor.IJJMDPGJAEM.Hero && GMMDCPLBFJL.m_actorType != Actor.IJJMDPGJAEM.Hero)
					{
						return -1;
					}
					return (IFGAPHGCLHF.m_actorType != Actor.IJJMDPGJAEM.Hero && GMMDCPLBFJL.m_actorType == Actor.IJJMDPGJAEM.Hero) ? 1 : 0;
				});
				int num3 = 0;
				for (int num4 = 0; num4 < allActorInRange.Count; num4++)
				{
					Actor lPOAEBNAGCP = allActorInRange[num4];
					if (get_m_view().IsMine())
					{
						Vector3 centerPosition = get_m_actor().GetCenterPosition();
						get_m_actor().CreateMissileRPC("skill3_missile", centerPosition, lPOAEBNAGCP);
					}
					num3++;
					if (num3 >= 3)
					{
						break;
					}
				}
				if (num3 > 0)
				{
					get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_missile_start");
				}
				HHBGIDOIFEG++;
			}
			if (HHBGIDOIFEG >= 9)
			{
				SetState(OEOIIKMBGAG.Idle);
			}
			break;
		case 2:
			break;
		}
	}

	public override void OnEnterAttack()
	{
		get_m_actor().CreateParticle(string.Format("Particle/{0}/attack", get_m_actor().get_m_resourceName()), false);
		GOGLNMODMLA = 0;
		get_m_actor().SetAnimation("attack");
		get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
		if (UnityEngine.Random.Range(0f, 1f) < 0.3f)
		{
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack_voice");
		}
	}

	public virtual float CBNCPAMIMNB()
	{
		float num = JNDEAKFNBLG();
		if (get_m_actor().get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)65527))
		{
			num += 1318f + (float)(get_m_actor().GetSkillLevel(0) - 0) * 754f;
		}
		return num;
	}

	public virtual void LBKCLMFMBPD()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			if (get_m_view().IsMine())
			{
				if (KAMDFGHFGCI != null)
				{
					Vector3 centerPosition = get_m_actor().GetCenterPosition();
					string nCADFOBAFJD = string.Format(" 인장", get_m_actor().get_m_resourceName());
					EveUnityNetwork instance = EveUnityNetwork.get_Instance();
					Quaternion identity = Quaternion.identity;
					object[] array3 = new object[1];
					array3[0] = get_m_view().get_viewID();
					array3[1] = KAMDFGHFGCI.get_m_view().get_viewID();
					instance.IIELNMNJGKA(nCADFOBAFJD, centerPosition, identity, array3);
				}
				else
				{
					MsgManager.HEDJPPFKABG().LBCFANDMCON("copyUrl");
				}
			}
			get_m_actor().m_multiSound.NMLFNHNOALK("{0}_{1}", false, 1028f, 1107f);
			if (UnityEngine.Random.Range(145f, 1505f) < 479f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("소드!! 그전에 저기 몰려오는 몬스터 부터 처리해야겠다.", false, 1378f, 320f);
			}
			break;
		case 1:
		{
			if (get_m_view().IsMine())
			{
				EveView view2 = get_m_view();
				object[] array2 = new object[1];
				array2[1] = m_moveDirection;
				view2.KGCPAGHLIHN("상급 공격속도 표식", DJJPAPENCLN.Others, array2);
			}
			double num = (double)get_m_actor().get_m_mag_att() * 826.0;
			num += 679.0 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 296.0;
			num += (double)get_m_actor().get_m_phy_att_add() * 266.0;
			List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 1415f, false, true, (Actor.IJJMDPGJAEM)(-67));
			bool flag = false;
			float num2 = 234f;
			for (int i = 1; i < list.Count; i++)
			{
				Actor actor = list[i];
				if (actor.OnDamage(get_m_actor(), 595.0, num, 200.0, 0) >= 1062f)
				{
					Skill0AdditionalDamage(actor);
					flag = false;
				}
				actor.CreateParticle(string.Format("TextMesh", get_m_actor().get_m_resourceName()), true);
				float num3 = Vector3.SqrMagnitude(actor.GetPosition() - get_m_actor().GetPosition());
				if (num3 < num2)
				{
					num2 = num3;
				}
			}
			if (flag)
			{
				get_m_actor().get_m_buffsInfo().IFNLBPAIMJE((JGOOOBHDBCG.ACPICCBBPHF)65410, null, 1973f, 779f);
				get_m_actor().m_multiSound.NMLFNHNOALK("_Mask", true, 688f, 536f);
			}
			get_m_actor().m_multiSound.JKOODMAKJHJ("Friend Count", false, 535f, 692f);
			if (UnityEngine.Random.Range(48f, 817f) < 531f)
			{
				get_m_actor().m_multiSound.DDONMGBLLJB(" FPS", true, 990f, 120f);
			}
			break;
		}
		case 2:
			get_m_actor().CreateParticle(string.Format("brand_passive_ex", get_m_actor().get_m_resourceName()), true);
			get_m_actor().m_multiSound.NMLFNHNOALK("invalid costume {0}", true, 708f, 224f);
			if (get_m_view().IsMine())
			{
				if (NGNLJADPNNB != null)
				{
					Vector3 vector = NGNLJADPNNB.GetPosition() - get_m_actor().GetPosition();
					Vector3 normalized = vector.normalized;
					float magnitude = vector.magnitude;
					magnitude = ((!(magnitude < 456f)) ? (magnitude - NGNLJADPNNB.GetBodyRadius()) : (magnitude + NGNLJADPNNB.GetBodyRadius()));
					vector = normalized * magnitude;
					EveView view = get_m_view();
					object[] array = new object[5];
					array[0] = get_m_actor().GetPosition() + vector;
					array[0] = NGNLJADPNNB.get_m_view().get_viewID();
					view.RPC("Challenge", DJJPAPENCLN.All, array);
				}
				else
				{
					MsgManager.HEDJPPFKABG().ShowTip("platinum");
				}
			}
			break;
		case 3:
			ILEPJEHHMJK = 1152f;
			HHBGIDOIFEG = 0;
			get_m_actor().m_multiSound.DDONMGBLLJB("igaworks:refundBulk >> Null or Empty Item List", true, 492f, 373f);
			get_m_actor().m_multiSound.JKOODMAKJHJ("찾을 이름을 적어주세요", false, 1665f, 1840f);
			break;
		}
	}

	[CompilerGenerated]
	private void BNJKIJNJNHC()
	{
		OnAnimationEventSkill(0);
	}

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		}
	}

	public override void OnEnterSkill()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			if (get_m_view().IsMine())
			{
				if (KAMDFGHFGCI != null)
				{
					Vector3 centerPosition = get_m_actor().GetCenterPosition();
					string nCADFOBAFJD = string.Format("Particle/{0}/skill0_missile", get_m_actor().get_m_resourceName());
					EveUnityNetwork.get_Instance().Instantiate(nCADFOBAFJD, centerPosition, Quaternion.identity, new object[2]
					{
						get_m_view().get_viewID(),
						KAMDFGHFGCI.get_m_view().get_viewID()
					});
				}
				else
				{
					MsgManager.get_Instance().ShowTip("정면 근처에 대상이 없습니다");
				}
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0");
			if (UnityEngine.Random.Range(0f, 1f) < 0.5f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_voice");
			}
			break;
		case 1:
		{
			if (get_m_view().IsMine())
			{
				get_m_view().RPC_Unreliable("Skill1MoveDirectionRpc", DJJPAPENCLN.Others, m_moveDirection);
			}
			double num = (double)get_m_actor().get_m_mag_att() * 0.25;
			num += 40.0 + (double)(get_m_actor().GetSkillLevel(1) - 1) * 35.0;
			num += (double)get_m_actor().get_m_phy_att_add() * 0.6;
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 3.75f, false, true, (Actor.IJJMDPGJAEM)14);
			bool flag = false;
			float num2 = 100f;
			for (int i = 0; i < allActorInRange.Count; i++)
			{
				Actor actor = allActorInRange[i];
				if (actor.OnDamage(get_m_actor(), 0.0, num) >= 0f)
				{
					Skill0AdditionalDamage(actor);
					flag = true;
				}
				actor.CreateParticle(string.Format("Particle/{0}/skill1_hit", get_m_actor().get_m_resourceName()), true);
				float num3 = Vector3.SqrMagnitude(actor.GetPosition() - get_m_actor().GetPosition());
				if (num3 < num2)
				{
					num2 = num3;
				}
			}
			if (flag)
			{
				get_m_actor().get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.KatarinaSkill1);
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1_hit");
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1");
			if (UnityEngine.Random.Range(0f, 1f) < 0.5f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1_voice");
			}
			break;
		}
		case 2:
			get_m_actor().CreateParticle(string.Format("Particle/{0}/skill2", get_m_actor().get_m_resourceName()), false);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2");
			if (get_m_view().IsMine())
			{
				if (NGNLJADPNNB != null)
				{
					Vector3 vector = NGNLJADPNNB.GetPosition() - get_m_actor().GetPosition();
					Vector3 normalized = vector.normalized;
					float magnitude = vector.magnitude;
					magnitude = ((!(magnitude < 4f)) ? (magnitude - NGNLJADPNNB.GetBodyRadius()) : (magnitude + NGNLJADPNNB.GetBodyRadius()));
					vector = normalized * magnitude;
					get_m_view().RPC("Skill2Rpc", DJJPAPENCLN.All, get_m_actor().GetPosition() + vector, NGNLJADPNNB.get_m_view().get_viewID());
				}
				else
				{
					MsgManager.get_Instance().ShowTip("정면 근처에 대상이 없습니다");
				}
			}
			break;
		case 3:
			ILEPJEHHMJK = 0f;
			HHBGIDOIFEG = 0;
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_loop", true);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_voice");
			break;
		}
	}

	[CompilerGenerated]
	private void IEOBNHCBJLH()
	{
		OnAnimationEventSkill(2);
	}

	[CompilerGenerated]
	private static int EHGNHBDMOEI(Actor IFGAPHGCLHF, Actor GMMDCPLBFJL)
	{
		if (IFGAPHGCLHF.m_actorType == Actor.IJJMDPGJAEM.Hero && GMMDCPLBFJL.m_actorType != Actor.IJJMDPGJAEM.Hero)
		{
			return -1;
		}
		if (IFGAPHGCLHF.m_actorType != Actor.IJJMDPGJAEM.Hero && GMMDCPLBFJL.m_actorType == Actor.IJJMDPGJAEM.Hero)
		{
			return 1;
		}
		return 0;
	}

	public void Skill0AdditionalDamage(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.KatarinaSkill0))
		{
			double num = (double)get_m_actor().get_m_mag_att() * 0.15;
			num += 17.0 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 17.0;
			CDKMPAEODLA.OnDamage(get_m_actor(), 0.0, num);
			CDKMPAEODLA.get_m_buffsInfo().KHFDBEEGPIL(JGOOOBHDBCG.ACPICCBBPHF.KatarinaSkill0);
			CDKMPAEODLA.CreateParticle(string.Format("Particle/{0}/skill0_buff_hit", get_m_actor().get_m_resourceName()), true);
		}
	}

	private void PKNOKHCLLNG()
	{
		LABCLHMLFGA(1);
	}

	public override void OnAssistHero(Actor JMEDKCPCJNA)
	{
		CAJJEALKJMM obj = LFNNHEEJNGP[0];
		obj.IHKCKBJBEGF = (float)obj.IHKCKBJBEGF + 5f;
		CAJJEALKJMM obj2 = LFNNHEEJNGP[1];
		obj2.IHKCKBJBEGF = (float)obj2.IHKCKBJBEGF + 5f;
		CAJJEALKJMM obj3 = LFNNHEEJNGP[2];
		obj3.IHKCKBJBEGF = (float)obj3.IHKCKBJBEGF + 5f;
		CAJJEALKJMM obj4 = LFNNHEEJNGP[3];
		obj4.IHKCKBJBEGF = (float)obj4.IHKCKBJBEGF + 5f;
	}

	public override void Init()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 10f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = -0.5f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 0;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[0].DOCFEKMACMP = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 4f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 0f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 0;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[1].DOCFEKMACMP = true;
		LFNNHEEJNGP[1].CEAGJMLKENE = true;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[2].FILHECEKNMK = 12f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = -1.5f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 0;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[3].FILHECEKNMK = 90f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = -22.5f;
		LFNNHEEJNGP[3].BELPBCDOPBA = 0;
		LFNNHEEJNGP[3].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[3].DOCFEKMACMP = true;
		LFNNHEEJNGP[3].GNAAGGJGBBG = true;
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
	}

	public void EKBNFBGBMOJ()
	{
		Actor actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 1197f, false, true, (Actor.IJJMDPGJAEM)(-65));
		if (actorInAttackRange == null)
		{
			actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 463f, false, true, (Actor.IJJMDPGJAEM)95);
			if (actorInAttackRange != null)
			{
				SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
			}
		}
		if (actorInAttackRange != null)
		{
			actorInAttackRange.OnAttackDamage(get_m_actor(), 401.0, 235.0, 158.0);
			Skill0AdditionalDamage(actorInAttackRange);
			IAKBNJEFLAN(actorInAttackRange);
			switch (GOGLNMODMLA)
			{
			case 0:
				get_m_actor().m_multiSound.DDONMGBLLJB("bgm_lobby", true, 1651f, 233f);
				break;
			case 1:
				get_m_actor().m_multiSound.ICNAJBHLIGO("PING[{0}ms]", true, 755f, 891f);
				break;
			}
		}
		OnAttack();
	}

	[CompilerGenerated]
	private void LNLEIBHPCHP()
	{
		OnAnimationEventSkill(3);
	}

	public void LABCLHMLFGA(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI != 0)
		{
			switch (GBGBBGEPEMI)
			{
			}
		}
	}

	public override float GetPercentMoveSpeedBonus()
	{
		float num = base.GetPercentMoveSpeedBonus();
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.KatarinaSkill1))
		{
			num += 0.15f + (float)(get_m_actor().GetSkillLevel(1) - 1) * 0.05f;
		}
		return num;
	}

	public void OnAnimationEventAttack()
	{
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 45f, false);
		if (actorInAttackRange == null)
		{
			actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 180f, false);
			if (actorInAttackRange != null)
			{
				SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
			}
		}
		if (actorInAttackRange != null)
		{
			actorInAttackRange.OnAttackDamage(get_m_actor());
			Skill0AdditionalDamage(actorInAttackRange);
			IAKBNJEFLAN(actorInAttackRange);
			switch (GOGLNMODMLA)
			{
			case 0:
				get_m_actor().m_multiSound.LKLFMNKDLHJ("hit");
				break;
			case 1:
				get_m_actor().m_multiSound.LKLFMNKDLHJ("critical");
				break;
			}
		}
		OnAttack();
	}

	[JDLHECHNNDH]
	public void Skill1MoveDirectionRpc(Vector3 BGNMKABPONA)
	{
		m_moveDirection = BGNMKABPONA;
	}

	public void IBGLMHFFAAB()
	{
		Actor actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 618f, true, false, (Actor.IJJMDPGJAEM)(-159));
		if (actorInAttackRange == null)
		{
			actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 1570f, false, false, (Actor.IJJMDPGJAEM)159);
			if (actorInAttackRange != null)
			{
				SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
			}
		}
		if (actorInAttackRange != null)
		{
			actorInAttackRange.OnAttackDamage(get_m_actor(), 1348.0, 1183.0, 1394.0);
			Skill0AdditionalDamage(actorInAttackRange);
			IAKBNJEFLAN(actorInAttackRange);
			int gOGLNMODMLA = GOGLNMODMLA;
			if (gOGLNMODMLA != 0)
			{
				if (gOGLNMODMLA == 0)
				{
					get_m_actor().m_multiSound.HDOLPLIDACO("null", true, 722f, 1708f);
				}
			}
			else
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_voice", false, 1783f, 1357f);
			}
		}
		OnAttack();
	}

	public virtual void LFLNAECMCEK()
	{
		get_m_actor().CreateParticle(string.Format("quantity", get_m_actor().get_m_resourceName()), true);
		GOGLNMODMLA = 0;
		get_m_actor().SetAnimation("Safe LoadLevel end");
		get_m_actor().m_multiSound.JKOODMAKJHJ("Hero5", false, 1707f, 1113f);
		if (UnityEngine.Random.Range(1668f, 444f) < 419f)
		{
			get_m_actor().m_multiSound.HDOLPLIDACO("{0}", false, 1596f, 346f);
		}
	}

	[JDLHECHNNDH]
	public void Skill2Rpc(Vector3 HEPNHCEIFMO, int MBEKPGNGBAO)
	{
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(MBEKPGNGBAO);
		get_m_actor().Warp(HEPNHCEIFMO);
		if (!(eveView != null))
		{
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		if (component != null && component.m_team != get_m_actor().m_team)
		{
			double num = (double)get_m_actor().get_m_mag_att() * 0.4;
			num += 60.0 + (double)(get_m_actor().GetSkillLevel(2) - 1) * 25.0;
			if (component.OnDamage(get_m_actor(), 0.0, num) >= 0f)
			{
				Skill0AdditionalDamage(component);
			}
		}
	}

	public virtual void FEIJADNOIKM(Actor JMEDKCPCJNA)
	{
		CAJJEALKJMM obj = LFNNHEEJNGP[0];
		obj.IHKCKBJBEGF = (float)obj.IHKCKBJBEGF + 771f;
		CAJJEALKJMM obj2 = LFNNHEEJNGP[1];
		obj2.IHKCKBJBEGF = (float)obj2.IHKCKBJBEGF + 754f;
		CAJJEALKJMM obj3 = LFNNHEEJNGP[3];
		obj3.IHKCKBJBEGF = (float)obj3.IHKCKBJBEGF + 1640f;
		CAJJEALKJMM obj4 = LFNNHEEJNGP[3];
		obj4.IHKCKBJBEGF = (float)obj4.IHKCKBJBEGF + 392f;
	}

	public void BMLNJLDJLNG(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI != 0 && GBGBBGEPEMI != 0)
		{
			switch (GBGBBGEPEMI)
			{
			}
		}
	}

	public virtual void KLGENEBKFPC()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[0].FILHECEKNMK = 413f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 1028f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 1;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 581f;
		LFNNHEEJNGP[0].DOCFEKMACMP = false;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 1240f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 544f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 1;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 632f;
		LFNNHEEJNGP[0].DOCFEKMACMP = false;
		LFNNHEEJNGP[1].CEAGJMLKENE = true;
		LFNNHEEJNGP[7].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[6].FILHECEKNMK = 1285f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 680f;
		LFNNHEEJNGP[8].BELPBCDOPBA = 0;
		LFNNHEEJNGP[6].NCBLBIBMNKH = 388f;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[5].FILHECEKNMK = 1378f;
		LFNNHEEJNGP[7].NEKKKLFLDOI = 804f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 1;
		LFNNHEEJNGP[3].NCBLBIBMNKH = 256f;
		LFNNHEEJNGP[8].DOCFEKMACMP = true;
		LFNNHEEJNGP[8].GNAAGGJGBBG = false;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
		get_m_actor().m_actorAniEvent.CNPHPPJOGFA(() =>
		{
			OnAnimationEventSkill(0);
		});
		get_m_actor().m_actorAniEvent.add_m_skill1Event(() =>
		{
			OnAnimationEventSkill(1);
		});
		get_m_actor().m_actorAniEvent.add_m_skill2Event(NIEKDIHLDJP);
		get_m_actor().m_actorAniEvent.ILAKGHCPPCH(() =>
		{
			OnAnimationEventSkill(3);
		});
	}
}
