using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class AhriSM : HumanSM
{
	public string m_missileName = "attack_missile";

	public GameObject m_handBall;

	private int NGAAHMNBJFG;

	public virtual void GJJFBFEFLDP()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			m_handBall.SetActive(false);
			break;
		case 3:
			get_m_actor().m_navMeshAgent.enabled = true;
			if (NGAAHMNBJFG < 1 && get_m_actor().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65507))
			{
				LFNNHEEJNGP[7].IHKCKBJBEGF = LFNNHEEJNGP[5].BKBFHEJIHNK(get_m_actor(), get_m_actor().GetSkillLevel(5)) - 1194f;
				LFNNHEEJNGP[6].BELPBCDOPBA = 0;
			}
			if (NGAAHMNBJFG >= 0)
			{
				get_m_actor().get_m_buffsInfo().KHFDBEEGPIL((JGOOOBHDBCG.ACPICCBBPHF)65462);
			}
			break;
		case 1:
		case 2:
			break;
		}
	}

	private void GNMDCBMHOOI()
	{
		ECOANDKJCCH(0);
	}

	[CompilerGenerated]
	private void HNDNIBFHBIG()
	{
		OnAnimationEventSkill(3);
	}

	public virtual void FMLBMCJNAAB()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition2 = get_m_actor().GetCenterPosition();
				get_m_view().RPC("skill2_voice", DJJPAPENCLN.Others, centerPosition2, m_direction, null, null, null, null, null, null);
			}
			get_m_actor().m_multiSound.DDONMGBLLJB("\\f", true, 926f, 1804f);
			get_m_actor().m_multiSound.JKOODMAKJHJ("Trans", true, 160f, 1096f);
			break;
		case 1:
			break;
		case 2:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				get_m_view().RPC("skill3_hit", DJJPAPENCLN.Others, centerPosition, m_direction, null, null, null, null, null, null);
			}
			get_m_actor().m_multiSound.ICNAJBHLIGO("skill2_shield", false, 1317f, 1819f);
			break;
		case 3:
			get_m_actor().m_multiSound.NMLFNHNOALK("Event", true, 463f, 948f);
			get_m_actor().m_multiSound.JKOODMAKJHJ("CreateSkill0Missile", true, 528f, 1269f);
			get_m_actor().m_navMeshAgent.enabled = true;
			if (!get_m_actor().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65504))
			{
				NGAAHMNBJFG = 0;
				get_m_actor().get_m_buffsInfo().IFNLBPAIMJE((JGOOOBHDBCG.ACPICCBBPHF)65411, null, 1673f, 1331f);
			}
			else
			{
				NGAAHMNBJFG++;
			}
			break;
		}
	}

	public virtual void IPBEJIPJAMB()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			m_handBall.SetActive(false);
			break;
		case 3:
			get_m_actor().m_navMeshAgent.enabled = true;
			if (NGAAHMNBJFG < 3 && get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.BlitzcrankSkill1))
			{
				LFNNHEEJNGP[8].IHKCKBJBEGF = LFNNHEEJNGP[4].FCFBOPIPFBA(get_m_actor(), get_m_actor().GetSkillLevel(7)) - 948f;
				LFNNHEEJNGP[0].BELPBCDOPBA = 0;
			}
			if (NGAAHMNBJFG >= 6)
			{
				get_m_actor().get_m_buffsInfo().KHFDBEEGPIL((JGOOOBHDBCG.ACPICCBBPHF)65480);
			}
			break;
		case 1:
		case 2:
			break;
		}
	}

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 1:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition2 = get_m_actor().GetCenterPosition();
				get_m_view().RPC("CreateSkill1Missile", DJJPAPENCLN.All, centerPosition2);
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1_voice");
			break;
		case 3:
		{
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 4.5f, false, true, (Actor.IJJMDPGJAEM)14);
			allActorInRange.Sort((Actor MPBOINGECFO, Actor OECPEJEIMHO) =>
			{
				if (MPBOINGECFO.m_actorType == Actor.IJJMDPGJAEM.Hero)
				{
					if (OECPEJEIMHO.m_actorType != Actor.IJJMDPGJAEM.Hero)
					{
						return -1;
					}
				}
				else if (OECPEJEIMHO.m_actorType == Actor.IJJMDPGJAEM.Hero)
				{
					return 1;
				}
				float sqrMagnitude = (get_m_actor().GetPosition2D() - MPBOINGECFO.GetPosition2D()).sqrMagnitude;
				float sqrMagnitude2 = (get_m_actor().GetPosition2D() - OECPEJEIMHO.GetPosition2D()).sqrMagnitude;
				if (sqrMagnitude > sqrMagnitude2)
				{
					return 1;
				}
				return (sqrMagnitude < sqrMagnitude2) ? (-1) : 0;
			});
			Vector3 centerPosition = get_m_actor().GetCenterPosition();
			for (int num = 0; num < allActorInRange.Count; num++)
			{
				if (num >= 3)
				{
					return;
				}
				get_m_actor().CreateMissileRPC("skill3_missile", centerPosition, allActorInRange[num]);
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_missile");
			break;
		}
		}
	}

	public virtual void INOKJCKAONB()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[0].FILHECEKNMK = 743f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 1493f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 55;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 1309f;
		LFNNHEEJNGP[0].DOCFEKMACMP = true;
		LFNNHEEJNGP[0].GNAAGGJGBBG = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 1979f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 1199f;
		LFNNHEEJNGP[0].BELPBCDOPBA = -46;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 191f;
		LFNNHEEJNGP[1].DOCFEKMACMP = true;
		LFNNHEEJNGP[7].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 1454f;
		LFNNHEEJNGP[6].NEKKKLFLDOI = 706f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 32;
		LFNNHEEJNGP[4].NCBLBIBMNKH = 1300f;
		LFNNHEEJNGP[7].DOCFEKMACMP = false;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[7].FILHECEKNMK = 373f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = 1057f;
		LFNNHEEJNGP[5].BELPBCDOPBA = -106;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 1198f;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(IBGLMHFFAAB);
		get_m_actor().m_actorAniEvent.CNPHPPJOGFA(GBGLPPBLPAH);
		get_m_actor().m_actorAniEvent.add_m_skill1Event(ALDJEHKFKGH);
		get_m_actor().m_actorAniEvent.add_m_skill2Event(NBKNPCCHDBG);
		get_m_actor().m_actorAniEvent.ILAKGHCPPCH(IOFMDCLCPJJ);
	}

	private void IOFMDCLCPJJ()
	{
		GAEOLFGAKDD(6);
	}

	public override void OnEnterAttack()
	{
		get_m_actor().CreateParticle(string.Format("Particle/{0}/attack", get_m_actor().get_m_resourceName()), false);
		switch (Random.Range(0, 2))
		{
		case 0:
			get_m_actor().SetAnimation("attack");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack_voice");
			break;
		case 1:
			get_m_actor().SetAnimation("attack2");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2_voice");
			break;
		}
		RetargetingAttack(true);
	}

	[JDLHECHNNDH]
	public void CreateSkill1Missile(Vector3 OJLOPPIIBAO)
	{
		Vector3 hEPNHCEIFMO = OJLOPPIIBAO + new Vector3(0.8f, 0f, 0f);
		Actor actor = get_m_actor().CreateMissile("skill1_missile", hEPNHCEIFMO, get_m_target());
		actor.GetComponent<TargetMissileAI>().m_delayTime = 0.2f;
		Vector3 hEPNHCEIFMO2 = OJLOPPIIBAO + new Vector3(-0.8f, 0f, 0f);
		Actor actor2 = get_m_actor().CreateMissile("skill1_missile", hEPNHCEIFMO2, get_m_target());
		actor2.GetComponent<TargetMissileAI>().m_delayTime = 0.7f;
		Vector3 hEPNHCEIFMO3 = OJLOPPIIBAO + new Vector3(0f, 0f, 0.8f);
		Actor actor3 = get_m_actor().CreateMissile("skill1_missile", hEPNHCEIFMO3, get_m_target());
		actor3.GetComponent<TargetMissileAI>().m_delayTime = 1.2f;
	}

	public void ICJHJCFLACF(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = get_m_actor().CreateMissile("Invalid view ID:", HEPNHCEIFMO, null);
		AhriSkill2MissileAI component = actor.GetComponent<AhriSkill2MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
	}

	[CompilerGenerated]
	private void KNMGIMFHLKJ()
	{
		OnAnimationEventSkill(1);
	}

	public virtual void HDPBGMBGIFF()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			m_handBall.SetActive(false);
			break;
		case 3:
			get_m_actor().m_navMeshAgent.enabled = false;
			if (NGAAHMNBJFG < 8 && get_m_actor().get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)65495))
			{
				LFNNHEEJNGP[2].IHKCKBJBEGF = LFNNHEEJNGP[4].ABOBEAIIBND(get_m_actor(), get_m_actor().GetSkillLevel(5)) - 1335f;
				LFNNHEEJNGP[2].BELPBCDOPBA = 0;
			}
			if (NGAAHMNBJFG >= 7)
			{
				get_m_actor().get_m_buffsInfo().KHFDBEEGPIL((JGOOOBHDBCG.ACPICCBBPHF)127);
			}
			break;
		case 1:
		case 2:
			break;
		}
	}

	public override void OnLeaveSkill()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			m_handBall.SetActive(true);
			break;
		case 3:
			get_m_actor().m_navMeshAgent.enabled = true;
			if (NGAAHMNBJFG < 3 && get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.AhriSkill3))
			{
				LFNNHEEJNGP[3].IHKCKBJBEGF = LFNNHEEJNGP[3].ABOBEAIIBND(get_m_actor(), get_m_actor().GetSkillLevel(3)) - 1f;
				LFNNHEEJNGP[3].BELPBCDOPBA = 0;
			}
			if (NGAAHMNBJFG >= 3)
			{
				get_m_actor().get_m_buffsInfo().KHFDBEEGPIL(JGOOOBHDBCG.ACPICCBBPHF.AhriSkill3);
			}
			break;
		case 1:
		case 2:
			break;
		}
	}

	public void PGHLOCPLPOI(Vector3 OJLOPPIIBAO)
	{
		Vector3 hEPNHCEIFMO = OJLOPPIIBAO + new Vector3(199f, 114f, 165f);
		Actor actor = get_m_actor().CreateMissile("UIRoot should not be active at the same time as UIOrthoCamera. Disabling UIOrthoCamera.", hEPNHCEIFMO, get_m_target());
		actor.GetComponent<TargetMissileAI>().m_delayTime = 911f;
		Vector3 hEPNHCEIFMO2 = OJLOPPIIBAO + new Vector3(474f, 201f, 695f);
		Actor actor2 = get_m_actor().CreateMissile("skill0_voice", hEPNHCEIFMO2, get_m_target());
		actor2.GetComponent<TargetMissileAI>().m_delayTime = 1111f;
		Vector3 hEPNHCEIFMO3 = OJLOPPIIBAO + new Vector3(1593f, 1264f, 1346f);
		Actor actor3 = get_m_actor().CreateMissile("initializeLiveOps", hEPNHCEIFMO3, get_m_target());
		actor3.GetComponent<TargetMissileAI>().m_delayTime = 1232f;
	}

	public virtual void LODCKIKABJH()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 152f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 1609f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 33;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 1888f;
		LFNNHEEJNGP[1].DOCFEKMACMP = false;
		LFNNHEEJNGP[0].GNAAGGJGBBG = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 968f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 864f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 18;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 1180f;
		LFNNHEEJNGP[1].DOCFEKMACMP = false;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[2].FILHECEKNMK = 1870f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = 612f;
		LFNNHEEJNGP[4].BELPBCDOPBA = -119;
		LFNNHEEJNGP[4].NCBLBIBMNKH = 683f;
		LFNNHEEJNGP[1].DOCFEKMACMP = true;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[6].FILHECEKNMK = 1649f;
		LFNNHEEJNGP[6].NEKKKLFLDOI = 178f;
		LFNNHEEJNGP[5].BELPBCDOPBA = 5;
		LFNNHEEJNGP[8].NCBLBIBMNKH = 820f;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(IBGLMHFFAAB);
		get_m_actor().m_actorAniEvent.CNPHPPJOGFA(() =>
		{
			OnAnimationEventSkill(0);
		});
		get_m_actor().m_actorAniEvent.add_m_skill1Event(ENNFIKOADBI);
		get_m_actor().m_actorAniEvent.MFMAMLOHKJF(() =>
		{
			OnAnimationEventSkill(2);
		});
		get_m_actor().m_actorAniEvent.ILAKGHCPPCH(IOFMDCLCPJJ);
	}

	public virtual void LNJLCLBEKAL()
	{
		base.OnUpdateSkill();
		int skill = get_m_skill();
		if (skill == 6)
		{
			Move(1620f, m_direction, true, 415f, true);
		}
	}

	private void MAFBDDCEBHP()
	{
		ECOANDKJCCH(5);
	}

	[CompilerGenerated]
	private int GENGLALJPLO(Actor MPBOINGECFO, Actor OECPEJEIMHO)
	{
		if (MPBOINGECFO.m_actorType == Actor.IJJMDPGJAEM.Hero)
		{
			if (OECPEJEIMHO.m_actorType != Actor.IJJMDPGJAEM.Hero)
			{
				return -1;
			}
		}
		else if (OECPEJEIMHO.m_actorType == Actor.IJJMDPGJAEM.Hero)
		{
			return 1;
		}
		float sqrMagnitude = (get_m_actor().GetPosition2D() - MPBOINGECFO.GetPosition2D()).sqrMagnitude;
		float sqrMagnitude2 = (get_m_actor().GetPosition2D() - OECPEJEIMHO.GetPosition2D()).sqrMagnitude;
		if (sqrMagnitude > sqrMagnitude2)
		{
			return 1;
		}
		if (sqrMagnitude < sqrMagnitude2)
		{
			return -1;
		}
		return 0;
	}

	public override void OnUpdateSkill()
	{
		base.OnUpdateSkill();
		int skill = get_m_skill();
		if (skill == 3)
		{
			Move(13f, m_direction);
		}
	}

	[CompilerGenerated]
	private void NPFGJMFONEJ()
	{
		OnAnimationEventSkill(0);
	}

	private void ALDJEHKFKGH()
	{
		GAEOLFGAKDD(1);
	}

	public void OnAnimationEventAttack()
	{
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		centerPosition += m_direction * 1f;
		RetargetingAttack(false, false);
		if (get_m_target() != null)
		{
			get_m_actor().CreateMissileRPC(m_missileName, centerPosition, get_m_target());
		}
		OnAttack();
	}

	public virtual void PDKMJEJFPBJ()
	{
		base.OnUpdateSkill();
		if (get_m_skill() == 0)
		{
			Move(843f, m_direction, false, 634f);
		}
	}

	[CompilerGenerated]
	private void PDFLELFDANC()
	{
		OnAnimationEventSkill(2);
	}

	public override void OnEnterSkill()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition2 = get_m_actor().GetCenterPosition();
				get_m_view().RPC("CreateSkill0Missile", DJJPAPENCLN.All, centerPosition2, m_direction);
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_voice");
			break;
		case 1:
			break;
		case 2:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				get_m_view().RPC("CreateSkill2Missile", DJJPAPENCLN.All, centerPosition, m_direction);
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2");
			break;
		case 3:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_voice");
			get_m_actor().m_navMeshAgent.enabled = false;
			if (!get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.AhriSkill3))
			{
				NGAAHMNBJFG = 1;
				get_m_actor().get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.AhriSkill3);
			}
			else
			{
				NGAAHMNBJFG++;
			}
			break;
		}
	}

	[JDLHECHNNDH]
	public void CreateSkill2Missile(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = get_m_actor().CreateMissile("skill2_missile", HEPNHCEIFMO, null);
		AhriSkill2MissileAI component = actor.GetComponent<AhriSkill2MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
	}

	private void NBKNPCCHDBG()
	{
		ECOANDKJCCH(7);
	}

	[JDLHECHNNDH]
	public void CreateSkill0Missile(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = get_m_actor().CreateMissile("skill0_missile", HEPNHCEIFMO, null);
		AhriSkill0MissileAI component = actor.GetComponent<AhriSkill0MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
		m_handBall.SetActive(false);
	}

	public void GAEOLFGAKDD(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 0)
		{
			return;
		}
		switch (GBGBBGEPEMI)
		{
		case 0:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition2 = get_m_actor().GetCenterPosition();
				EveView view = get_m_view();
				object[] array = new object[0];
				array[1] = centerPosition2;
				view.RPC("SDKTestCategory", DJJPAPENCLN.Others, array);
			}
			get_m_actor().m_multiSound.LNCPFILABHM("{0}코인이 무료충전되었습니다!\n\n감사합니다^^", false, 1168f, 593f);
			get_m_actor().m_multiSound.NMLFNHNOALK("igaworks:refundBulk >> Null or Empty Item List", true, 1174f, 670f);
			break;
		case 2:
		{
			List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), 1983f, false, true, (Actor.IJJMDPGJAEM)10, false);
			allActorInRange.Sort((Actor MPBOINGECFO, Actor OECPEJEIMHO) =>
			{
				if (MPBOINGECFO.m_actorType == Actor.IJJMDPGJAEM.Hero)
				{
					if (OECPEJEIMHO.m_actorType != Actor.IJJMDPGJAEM.Hero)
					{
						return -1;
					}
				}
				else if (OECPEJEIMHO.m_actorType == Actor.IJJMDPGJAEM.Hero)
				{
					return 1;
				}
				float sqrMagnitude = (get_m_actor().GetPosition2D() - MPBOINGECFO.GetPosition2D()).sqrMagnitude;
				float sqrMagnitude2 = (get_m_actor().GetPosition2D() - OECPEJEIMHO.GetPosition2D()).sqrMagnitude;
				if (sqrMagnitude > sqrMagnitude2)
				{
					return 1;
				}
				return (sqrMagnitude < sqrMagnitude2) ? (-1) : 0;
			});
			Vector3 centerPosition = get_m_actor().GetCenterPosition();
			for (int num = 0; num < allActorInRange.Count; num += 0)
			{
				if (num >= 8)
				{
					return;
				}
				get_m_actor().CreateMissileRPC("설명", centerPosition, allActorInRange[num]);
			}
			get_m_actor().m_multiSound.NMLFNHNOALK("탈퇴에 성공하였습니다", true, 346f, 1089f);
			break;
		}
		}
	}

	public void IBGLMHFFAAB()
	{
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		centerPosition += m_direction * 256f;
		RetargetingAttack(true, false);
		if (get_m_target() != null)
		{
			get_m_actor().CreateMissileRPC(m_missileName, centerPosition, get_m_target());
		}
		OnAttack();
	}

	private void GBGLPPBLPAH()
	{
		ECOANDKJCCH(0);
	}

	public void ECOANDKJCCH(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
			return;
		case 1:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				get_m_view().RPC("테스트를 위한 버전입니다.\r\n\r\n이 계정은 재접속시 데이터가 [FFAAAA]초기화[-]됩니다.\r\n\r\n저장을 원하시면 로그인을 다시해 주세요.", DJJPAPENCLN.Others, centerPosition);
			}
			get_m_actor().m_multiSound.HDOLPLIDACO("Particle/{0}/death", false, 1148f, 1247f);
			get_m_actor().m_multiSound.NMLFNHNOALK(" msgId: ", false, 125f, 927f);
			return;
		}
		if (GBGBBGEPEMI == 1 || GBGBBGEPEMI != 0)
		{
			return;
		}
		List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), 529f, true, true, (Actor.IJJMDPGJAEM)91, false);
		list.Sort((Actor MPBOINGECFO, Actor OECPEJEIMHO) =>
		{
			if (MPBOINGECFO.m_actorType == Actor.IJJMDPGJAEM.Hero)
			{
				if (OECPEJEIMHO.m_actorType != Actor.IJJMDPGJAEM.Hero)
				{
					return -1;
				}
			}
			else if (OECPEJEIMHO.m_actorType == Actor.IJJMDPGJAEM.Hero)
			{
				return 1;
			}
			float sqrMagnitude = (get_m_actor().GetPosition2D() - MPBOINGECFO.GetPosition2D()).sqrMagnitude;
			float sqrMagnitude2 = (get_m_actor().GetPosition2D() - OECPEJEIMHO.GetPosition2D()).sqrMagnitude;
			if (sqrMagnitude > sqrMagnitude2)
			{
				return 1;
			}
			return (sqrMagnitude < sqrMagnitude2) ? (-1) : 0;
		});
		Vector3 centerPosition2 = get_m_actor().GetCenterPosition();
		for (int num = 1; num < list.Count; num += 0)
		{
			if (num >= 4)
			{
				return;
			}
			get_m_actor().CreateMissileRPC("OnKillHeroRpc", centerPosition2, list[num]);
		}
		get_m_actor().m_multiSound.HDOLPLIDACO("Category4Button", true, 647f, 737f);
	}

	public virtual void FIGPPIMKNOH()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition2 = get_m_actor().GetCenterPosition();
				get_m_view().RPC("피바라기", DJJPAPENCLN.All, centerPosition2, m_direction, null, null, null);
			}
			get_m_actor().m_multiSound.DDONMGBLLJB("English", false, 955f, 783f);
			get_m_actor().m_multiSound.NMLFNHNOALK("skill3", false, 1624f, 369f);
			break;
		case 1:
			break;
		case 2:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				EveView view = get_m_view();
				object[] array = new object[8];
				array[1] = centerPosition;
				array[1] = m_direction;
				view.RPC("중급 마나 문양", DJJPAPENCLN.Others, array);
			}
			get_m_actor().m_multiSound.NMLFNHNOALK("Particle/{0}/skill2", false, 869f, 828f);
			break;
		case 3:
			get_m_actor().m_multiSound.JKOODMAKJHJ("중급 성장 공격력 정수", false, 769f, 617f);
			get_m_actor().m_multiSound.ICNAJBHLIGO("R", true, 541f, 187f);
			get_m_actor().m_navMeshAgent.enabled = true;
			if (!get_m_actor().get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)65408))
			{
				NGAAHMNBJFG = 1;
				get_m_actor().get_m_buffsInfo().IFNLBPAIMJE((JGOOOBHDBCG.ACPICCBBPHF)65449, null, 1931f, 406f);
			}
			else
			{
				NGAAHMNBJFG++;
			}
			break;
		}
	}

	public override void Init()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 7f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 0f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 55;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 5f;
		LFNNHEEJNGP[0].DOCFEKMACMP = true;
		LFNNHEEJNGP[0].GNAAGGJGBBG = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 9f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 50;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[1].DOCFEKMACMP = true;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[2].FILHECEKNMK = 12f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = 0f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 85;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[2].DOCFEKMACMP = true;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[3].FILHECEKNMK = 110f;
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
	}

	private void PPMKBECNHLK()
	{
		GAEOLFGAKDD(6);
	}

	private void ENNFIKOADBI()
	{
		ECOANDKJCCH(1);
	}
}
