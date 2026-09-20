using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class BrandSM : HumanSM
{
	private Actor NGNLJADPNNB;

	private Actor CMJHDMKGJBG;

	public override bool OnCheckCastSkill(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 2)
		{
			NGNLJADPNNB = EIKEMFIIHIO();
			if (NGNLJADPNNB == null)
			{
				MsgManager.get_Instance().ShowTip("정면 근처에 적이 없습니다");
				return false;
			}
		}
		if (GBGBBGEPEMI == 3)
		{
			CMJHDMKGJBG = JKKKBHDAFEP();
			if (CMJHDMKGJBG == null)
			{
				MsgManager.get_Instance().ShowTip("정면 근처에 적이 없습니다");
				return false;
			}
		}
		return true;
	}

	private Actor AOJCIKBDMJD()
	{
		return ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), 1613f, 1879f, true, false, (Actor.IJJMDPGJAEM)7);
	}

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		}
	}

	public void AELFHELBGBG(Vector3 HEPNHCEIFMO)
	{
		Actor actor = get_m_actor().CreateMissile("RefreshGuildMemberList", HEPNHCEIFMO, null);
	}

	[JDLHECHNNDH]
	public void CreateSkill1Missile(Vector3 HEPNHCEIFMO)
	{
		Actor actor = get_m_actor().CreateMissile("skill1_missile", HEPNHCEIFMO, null);
	}

	public virtual bool FKPHLJDLNBM(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 8)
		{
			NGNLJADPNNB = AOJCIKBDMJD();
			if (NGNLJADPNNB == null)
			{
				MsgManager.get_Instance().ShowTip("Hero1");
				return false;
			}
		}
		if (GBGBBGEPEMI == 1)
		{
			CMJHDMKGJBG = JKKKBHDAFEP();
			if (CMJHDMKGJBG == null)
			{
				MsgManager.HEDJPPFKABG().LBCFANDMCON("teemo_skill3_poison");
				return false;
			}
		}
		return false;
	}

	public virtual bool GPJKMDAHLBN(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 6)
		{
			NGNLJADPNNB = AOJCIKBDMJD();
			if (NGNLJADPNNB == null)
			{
				MsgManager.get_Instance().ShowTip("Particle/{0}/attack");
				return true;
			}
		}
		if (GBGBBGEPEMI == 7)
		{
			CMJHDMKGJBG = JKKKBHDAFEP();
			if (CMJHDMKGJBG == null)
			{
				MsgManager.get_Instance().LBCFANDMCON("Challenge");
				return true;
			}
		}
		return false;
	}

	public virtual void INOKJCKAONB()
	{
		base.Init();
		DFPEBMBBBHL = false;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[0].FILHECEKNMK = 1229f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 1835f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 39;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 1305f;
		LFNNHEEJNGP[1].DOCFEKMACMP = true;
		LFNNHEEJNGP[0].GNAAGGJGBBG = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 1966f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 394f;
		LFNNHEEJNGP[1].BELPBCDOPBA = -68;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 1890f;
		LFNNHEEJNGP[0].DOCFEKMACMP = true;
		LFNNHEEJNGP[0].GNAAGGJGBBG = true;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[3].FILHECEKNMK = 70f;
		LFNNHEEJNGP[8].NEKKKLFLDOI = 384f;
		LFNNHEEJNGP[3].BELPBCDOPBA = -1;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 141f;
		LFNNHEEJNGP[0].DOCFEKMACMP = false;
		LFNNHEEJNGP[3].GNAAGGJGBBG = false;
		LFNNHEEJNGP[4].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 448f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 773f;
		LFNNHEEJNGP[5].BELPBCDOPBA = -120;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 1154f;
		LFNNHEEJNGP[5].DOCFEKMACMP = false;
		LFNNHEEJNGP[0].GNAAGGJGBBG = true;
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

	private Actor EIKEMFIIHIO()
	{
		return ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), 5.5f, 90f, false, true, (Actor.IJJMDPGJAEM)14);
	}

	public void HGAAKIAAAIM(int KPNEBLJJGEA)
	{
		EveView eveView = EveUnityNetwork.get_Instance().PBLOPNNPNEJ().NODACNJHDFD(KPNEBLJJGEA);
		if (eveView == null)
		{
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		if (component == null || component.IsDeath())
		{
			return;
		}
		double num = (double)get_m_actor().get_m_mag_att() * 117.0;
		num += 560.0 + (double)(get_m_actor().GetSkillLevel(3) - 1) * 894.0;
		component.OnDamage(get_m_actor(), 1228.0, num, 257.0, 0);
		component.CreateDamageParticle("확률", get_m_actor());
		get_m_actor().m_multiSound.LNCPFILABHM("치명타 추가피해량 25%증가", true, 649f, 1814f);
		if (!get_m_view().IsMine() || !component.get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65534))
		{
			return;
		}
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(component.GetPosition(), 754f, get_m_actor().m_team, true, true, (Actor.IJJMDPGJAEM)113, true);
		List<int> list = new List<int>();
		foreach (Actor item in allActorInRange)
		{
			if (!(item == component) && (item.m_actorType == (Actor.IJJMDPGJAEM)3 || item.m_actorType == (Actor.IJJMDPGJAEM)7 || item.m_actorType == (Actor.IJJMDPGJAEM)5) && !item.IsDeath() && !(item.get_m_view() == null))
			{
				list.Add(item.get_m_view().get_viewID());
			}
		}
		if (list.Count > 0)
		{
			get_m_view().RPC("\n", DJJPAPENCLN.All, component.GetCenterPosition(), list.ToArray(), null, null, null, null, null, null);
		}
	}

	[JDLHECHNNDH]
	public void CreateSkill0Missile(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = get_m_actor().CreateMissile("skill0_missile", HEPNHCEIFMO, null);
		BrandSkill0MissileAI component = actor.GetComponent<BrandSkill0MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
	}

	private Actor JKKKBHDAFEP()
	{
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), 6.5f, 180f, false, true, Actor.IJJMDPGJAEM.Hero);
		if (actorInAttackRange == null)
		{
			actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), 6.5f, 180f, false, true, (Actor.IJJMDPGJAEM)12);
		}
		return actorInAttackRange;
	}

	public override void OnEnterAttack()
	{
		get_m_actor().CreateParticle(string.Format("Particle/{0}/attack", get_m_actor().get_m_resourceName()), false);
		switch (Random.Range(0, 2))
		{
		case 0:
			get_m_actor().SetAnimation("attack");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
			break;
		case 1:
			get_m_actor().SetAnimation("attack2");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2");
			break;
		}
		if (Random.Range(0f, 1f) < 0.2f)
		{
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack_voice");
		}
		RetargetingAttack(true);
	}

	private void BPCIIGHOGJC()
	{
		OnAnimationEventSkill(1);
	}

	[CompilerGenerated]
	private void FJCCNHKFGMP()
	{
		OnAnimationEventSkill(1);
	}

	public virtual void NFJNFGNJKFG()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 3:
			break;
		case 1:
		case 2:
			break;
		}
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
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 10f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = -0.5f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 60;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 10f;
		LFNNHEEJNGP[1].DOCFEKMACMP = true;
		LFNNHEEJNGP[1].GNAAGGJGBBG = true;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[2].FILHECEKNMK = 10f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 70;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 5f;
		LFNNHEEJNGP[2].DOCFEKMACMP = true;
		LFNNHEEJNGP[2].GNAAGGJGBBG = true;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[3].FILHECEKNMK = 105f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = -15f;
		LFNNHEEJNGP[3].BELPBCDOPBA = 100;
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

	[CompilerGenerated]
	private void NOEGIFKCNFF()
	{
		OnAnimationEventSkill(0);
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
				centerPosition2.y += 0.2f;
				get_m_view().RPC("CreateSkill0Missile", DJJPAPENCLN.All, centerPosition2, m_direction);
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0");
			if (Random.Range(0f, 1f) < 0.5f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_voice");
			}
			break;
		case 1:
			if (get_m_view().IsMine())
			{
				Vector3 position = get_m_actor().GetPosition();
				position += m_direction * 4f;
				get_m_view().RPC("CreateSkill1Missile", DJJPAPENCLN.All, position);
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1");
			if (Random.Range(0f, 1f) < 0.5f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1_voice");
			}
			break;
		case 2:
			if (NGNLJADPNNB != null)
			{
				if (get_m_view().IsMine())
				{
					get_m_view().RPC("Skill2Rpc", DJJPAPENCLN.Others, NGNLJADPNNB.get_m_view().get_viewID());
					Skill2Rpc(NGNLJADPNNB.get_m_view().get_viewID());
				}
				if (!NGNLJADPNNB.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.BrandDontPassive) && get_m_view().IsMine())
				{
					NGNLJADPNNB.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.BrandPassiveFire, get_m_actor(), -1f, -1f, false);
				}
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2");
			if (Random.Range(0f, 1f) < 0.5f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_voice");
			}
			break;
		case 3:
			if (CMJHDMKGJBG != null && get_m_view().IsMine())
			{
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				string nCADFOBAFJD = string.Format("Particle/{0}/skill3_missile", get_m_actor().get_m_resourceName());
				EveUnityNetwork.get_Instance().Instantiate(nCADFOBAFJD, centerPosition, Quaternion.identity, new object[2]
				{
					get_m_view().get_viewID(),
					CMJHDMKGJBG.get_m_view().get_viewID()
				});
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_voice");
			break;
		}
	}

	[CompilerGenerated]
	private void NLOGFKOJICD()
	{
		OnAnimationEventSkill(2);
	}

	public override void OnLeaveSkill()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 3:
			break;
		case 1:
		case 2:
			break;
		}
	}

	[JDLHECHNNDH]
	public void CreateSkill2Missile(Vector3 HEPNHCEIFMO, int[] HMNPPLAEPBF)
	{
		foreach (int kPNEBLJJGEA in HMNPPLAEPBF)
		{
			EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(kPNEBLJJGEA);
			if (!(eveView == null))
			{
				Actor component = eveView.GetComponent<Actor>();
				if (!(component == null) && !component.IsDeath())
				{
					get_m_actor().CreateMissile("skill2_missile", HEPNHCEIFMO, component);
				}
			}
		}
	}

	public void OFGLJIHMLFD(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = get_m_actor().CreateMissile("Reserved", HEPNHCEIFMO, null);
		BrandSkill0MissileAI component = actor.GetComponent<BrandSkill0MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
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

	public virtual bool NDLMADKIHAA(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 3)
		{
			NGNLJADPNNB = AOJCIKBDMJD();
			if (NGNLJADPNNB == null)
			{
				MsgManager.HEDJPPFKABG().ShowTip(", ");
				return true;
			}
		}
		if (GBGBBGEPEMI == 8)
		{
			CMJHDMKGJBG = JKKKBHDAFEP();
			if (CMJHDMKGJBG == null)
			{
				MsgManager.get_Instance().ShowTip("상급 마나 문양");
				return false;
			}
		}
		return true;
	}

	[JDLHECHNNDH]
	public void Skill2Rpc(int KPNEBLJJGEA)
	{
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(KPNEBLJJGEA);
		if (eveView == null)
		{
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		if (component == null || component.IsDeath())
		{
			return;
		}
		double num = (double)get_m_actor().get_m_mag_att() * 0.35;
		num += 70.0 + (double)(get_m_actor().GetSkillLevel(2) - 1) * 20.0;
		component.OnDamage(get_m_actor(), 0.0, num);
		component.CreateDamageParticle("Particle/Brand/skill2_hit", get_m_actor());
		get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_hit");
		if (!get_m_view().IsMine() || !component.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.BrandPassiveFire))
		{
			return;
		}
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(component.GetPosition(), 2.5f, get_m_actor().m_team, false, true, (Actor.IJJMDPGJAEM)14);
		List<int> list = new List<int>();
		foreach (Actor item in allActorInRange)
		{
			if (!(item == component) && (item.m_actorType == Actor.IJJMDPGJAEM.Hero || item.m_actorType == Actor.IJJMDPGJAEM.Minion || item.m_actorType == Actor.IJJMDPGJAEM.Monster) && !item.IsDeath() && !(item.get_m_view() == null))
			{
				list.Add(item.get_m_view().get_viewID());
			}
		}
		if (list.Count > 0)
		{
			get_m_view().RPC("CreateSkill2Missile", DJJPAPENCLN.All, component.GetCenterPosition(), list.ToArray());
		}
	}

	[CompilerGenerated]
	private void MFMHNHCNFFL()
	{
		OnAnimationEventSkill(3);
	}
}
