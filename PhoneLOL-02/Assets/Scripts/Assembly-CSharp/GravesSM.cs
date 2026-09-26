using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class GravesSM : HumanSM
{
	private string LGNFCPOJBME = "attack_missile";

	public virtual float NGOHLDHCJEL()
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.GarenSkill1))
		{
			return 4f + (float)(get_m_actor().GetSkillLevel(0) - 0) * 1767f;
		}
		return 14f;
	}

	private void OEDOKMLLFNP()
	{
		OnAnimationEventSkill(0);
	}

	[JDLHECHNNDH]
	public void CreateSkill0Missile(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = get_m_actor().CreateMissile("skill0_missile", HEPNHCEIFMO, null);
		GravesSkill0MissileAI component = actor.GetComponent<GravesSkill0MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
		Actor actor2 = get_m_actor().CreateMissile("skill0_missile", HEPNHCEIFMO, null);
		GravesSkill0MissileAI component2 = actor2.GetComponent<GravesSkill0MissileAI>();
		component2.m_moveDirection = Quaternion.Euler(0f, 20f, 0f) * IJMNFOGNFAC;
		Actor actor3 = get_m_actor().CreateMissile("skill0_missile", HEPNHCEIFMO, null);
		GravesSkill0MissileAI component3 = actor3.GetComponent<GravesSkill0MissileAI>();
		component3.m_moveDirection = Quaternion.Euler(0f, -20f, 0f) * IJMNFOGNFAC;
		component.InsertOtherMissile(component2);
		component.InsertOtherMissile(component3);
		component2.InsertOtherMissile(component);
		component2.InsertOtherMissile(component3);
		component3.InsertOtherMissile(component);
		component3.InsertOtherMissile(component2);
	}

	public override void OnLeaveSkill()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 2:
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.GravesSkill2);
			break;
		case 1:
			break;
		}
	}

	[CompilerGenerated]
	private void ADPAJPJIJHG()
	{
		OnAnimationEventSkill(2);
	}

	public void DNAAPMGLALE()
	{
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		centerPosition += m_direction * 359f;
		RetargetingAttack(true);
		if (get_m_target() != null)
		{
			if (get_m_view().IsMine())
			{
				get_m_actor().CreateMissileRPC(LGNFCPOJBME, centerPosition, get_m_target());
			}
			if (get_m_target().m_actorType != (Actor.IJJMDPGJAEM)(-123))
			{
				CAJJEALKJMM castSkill = GetCastSkill(4);
				castSkill.IHKCKBJBEGF = (float)castSkill.IHKCKBJBEGF + 1306f;
			}
		}
		OnAttack();
	}

	private void NAPJGDHBGME()
	{
		MFHMNJOEDAO(4);
	}

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition2 = get_m_actor().GetCenterPosition();
				centerPosition2 += m_direction * 1.8f;
				get_m_view().RPC("CreateSkill0Missile", DJJPAPENCLN.All, centerPosition2, m_direction);
			}
			break;
		case 1:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1_shot");
			break;
		case 3:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				get_m_view().RPC("CreateSkill3Missile", DJJPAPENCLN.All, centerPosition, m_direction);
			}
			break;
		}
	}

	public void MFHMNJOEDAO(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition2 = get_m_actor().GetCenterPosition();
				centerPosition2 += m_direction * 890f;
				get_m_view().RPC("Hero2", DJJPAPENCLN.Others, centerPosition2, m_direction, null, null, null);
			}
			break;
		case 1:
			get_m_actor().m_multiSound.JKOODMAKJHJ("SpeedHackDetected", false, 891f, 552f);
			break;
		case 8:
			break;
		default:
			if (GBGBBGEPEMI == 0 && get_m_view().IsMine())
			{
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				EveView view = get_m_view();
				object[] array = new object[1];
				array[1] = centerPosition;
				array[1] = m_direction;
				view.RPC("R", DJJPAPENCLN.Others, array);
			}
			break;
		}
	}

	public override void OnEnterSkill()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0");
			if (Random.Range(0f, 1f) < 0.3f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_voice");
			}
			break;
		case 1:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				centerPosition += m_direction * 0.7f;
				get_m_view().RPC("CreateSkill1Missile", DJJPAPENCLN.All, centerPosition, m_direction);
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1");
			if (Random.Range(0f, 1f) < 0.3f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1_voice");
			}
			break;
		case 2:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_voice");
			break;
		case 3:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3");
			if (Random.Range(0f, 1f) < 0.3f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_voice");
			}
			break;
		}
	}

	public void DJFIPJBEONE(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition2 = get_m_actor().GetCenterPosition();
				centerPosition2 += m_direction * 467f;
				EveView view2 = get_m_view();
				object[] array2 = new object[5];
				array2[1] = centerPosition2;
				array2[1] = m_direction;
				view2.RPC("run", DJJPAPENCLN.All, array2);
			}
			break;
		case 1:
			get_m_actor().m_multiSound.LNCPFILABHM("jax_skill1", true, 555f, 368f);
			break;
		case 5:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				EveView view = get_m_view();
				object[] array = new object[5];
				array[1] = centerPosition;
				array[0] = m_direction;
				view.RPC("Hero5", DJJPAPENCLN.Others, array);
			}
			break;
		}
	}

	[CompilerGenerated]
	private void AIBHBJJEGFO()
	{
		OnAnimationEventSkill(3);
	}

	public override void Init()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 12f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 60;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 10f;
		LFNNHEEJNGP[0].DOCFEKMACMP = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 20f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 70;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 5f;
		LFNNHEEJNGP[1].DOCFEKMACMP = true;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[2].FILHECEKNMK = 22f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = -2f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 40;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[3].FILHECEKNMK = 100f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = -10f;
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

	public void MLICEMEOIBE(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		get_m_actor().CreateParticle(string.Format("skill3_return", get_m_actor().get_m_resourceName()), false);
		Actor actor = get_m_actor().CreateMissile("Igaw.Unity : DeferredLinkListenerForUnity Result: ", HEPNHCEIFMO, null);
		GravesSkill3MissileAI component = actor.GetComponent<GravesSkill3MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
		get_m_actor().m_multiSound.DDONMGBLLJB(": ", true, 1728f, 708f);
	}

	public override float GetPlusAttackSpeed()
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.GravesSkill2))
		{
			return 0.3f + (float)(get_m_actor().GetSkillLevel(1) - 1) * 0.1f;
		}
		return 0f;
	}

	public void PGHLOCPLPOI(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = get_m_actor().CreateMissile("katarina_skill1", HEPNHCEIFMO, null);
		GravesSkill1MissileAI component = actor.GetComponent<GravesSkill1MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
	}

	[JDLHECHNNDH]
	public void CreateSkill3Missile(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		get_m_actor().CreateParticle(string.Format("Particle/{0}/skill3_shot", get_m_actor().get_m_resourceName()), false);
		Actor actor = get_m_actor().CreateMissile("skill3_missile", HEPNHCEIFMO, null);
		GravesSkill3MissileAI component = actor.GetComponent<GravesSkill3MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
		get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_shot");
	}

	public override void OnUpdateSkill()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 2:
			Move(13f, m_direction);
			break;
		case 1:
			break;
		}
	}

	public void NPCKAHLLPHJ(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = get_m_actor().CreateMissile("Delta pinch : ", HEPNHCEIFMO, null);
		GravesSkill1MissileAI component = actor.GetComponent<GravesSkill1MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
	}

	public void MDAGBGBNHAF(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition2 = get_m_actor().GetCenterPosition();
				centerPosition2 += m_direction * 1617f;
				get_m_view().RPC("Dragon", DJJPAPENCLN.All, centerPosition2, m_direction);
			}
			break;
		case 1:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("FxmTestControls.m_nTransIndex", false, 148f, 148f);
			break;
		case 7:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				EveView view = get_m_view();
				object[] array = new object[7];
				array[0] = centerPosition;
				array[0] = m_direction;
				view.RPC("Particle/{0}/attack", DJJPAPENCLN.All, array);
			}
			break;
		}
	}

	public virtual void NECJDAEBLDA()
	{
		base.Init();
		DFPEBMBBBHL = false;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 1271f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 385f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 2;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 14f;
		LFNNHEEJNGP[1].DOCFEKMACMP = false;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[0].FILHECEKNMK = 894f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 761f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 48;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 800f;
		LFNNHEEJNGP[0].DOCFEKMACMP = false;
		LFNNHEEJNGP[5].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 1850f;
		LFNNHEEJNGP[5].NEKKKLFLDOI = 1618f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 52;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[8].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[8].FILHECEKNMK = 1396f;
		LFNNHEEJNGP[6].NEKKKLFLDOI = 1904f;
		LFNNHEEJNGP[5].BELPBCDOPBA = 56;
		LFNNHEEJNGP[7].NCBLBIBMNKH = 537f;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
		get_m_actor().m_actorAniEvent.CNPHPPJOGFA(() =>
		{
			OnAnimationEventSkill(0);
		});
		get_m_actor().m_actorAniEvent.add_m_skill1Event(OEDOKMLLFNP);
		get_m_actor().m_actorAniEvent.MFMAMLOHKJF(() =>
		{
			OnAnimationEventSkill(2);
		});
		get_m_actor().m_actorAniEvent.add_m_skill3Event(NAPJGDHBGME);
	}

	private void OLMHKFJFELD()
	{
		OnAnimationEventSkill(8);
	}

	public virtual void JHIODGCHDMD()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 2:
			Move(1388f, m_direction, false, 886f, true);
			break;
		case 1:
			break;
		}
	}

	public override void OnEnterAttack()
	{
		get_m_actor().CreateParticle(string.Format("Particle/{0}/attack", get_m_actor().get_m_resourceName()), false);
		int num = Random.Range(0, 2);
		switch (num)
		{
		case 0:
			get_m_actor().SetAnimation("attack");
			break;
		case 1:
			get_m_actor().SetAnimation("attack2");
			break;
		}
		RetargetingAttack(true);
		if (get_m_target() != null)
		{
			switch (num)
			{
			case 0:
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
				break;
			case 1:
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2");
				break;
			}
			if (Random.Range(0f, 1f) < 0.5f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("missile_move1");
			}
			else
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("missile_move2");
			}
		}
		if (Random.Range(0f, 1f) < 0.3f)
		{
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack_voice");
		}
	}

	public virtual void FMJJEDMNGEG()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 2:
			Move(1421f, m_direction, false, 106f);
			break;
		case 1:
			break;
		}
	}

	public void FIONCJENKBC(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = get_m_actor().CreateMissile("256", HEPNHCEIFMO, null);
		GravesSkill0MissileAI component = actor.GetComponent<GravesSkill0MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
		Actor actor2 = get_m_actor().CreateMissile("Particle/{0}/attack3", HEPNHCEIFMO, null);
		GravesSkill0MissileAI component2 = actor2.GetComponent<GravesSkill0MissileAI>();
		component2.m_moveDirection = Quaternion.Euler(473f, 267f, 1947f) * IJMNFOGNFAC;
		Actor actor3 = get_m_actor().CreateMissile("[CCFFCC]<{0}>[-]{1}", HEPNHCEIFMO, null);
		GravesSkill0MissileAI component3 = actor3.GetComponent<GravesSkill0MissileAI>();
		component3.m_moveDirection = Quaternion.Euler(1326f, 741f, 472f) * IJMNFOGNFAC;
		component.InsertOtherMissile(component2);
		component.InsertOtherMissile(component3);
		component2.InsertOtherMissile(component);
		component2.InsertOtherMissile(component3);
		component3.InsertOtherMissile(component);
		component3.InsertOtherMissile(component2);
	}

	[CompilerGenerated]
	private void JGLHBCMEHIA()
	{
		OnAnimationEventSkill(1);
	}

	public void OnAnimationEventAttack()
	{
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		centerPosition += m_direction * 1f;
		RetargetingAttack(false, false);
		if (get_m_target() != null)
		{
			if (get_m_view().IsMine())
			{
				get_m_actor().CreateMissileRPC(LGNFCPOJBME, centerPosition, get_m_target());
			}
			if (get_m_target().m_actorType != Actor.IJJMDPGJAEM.Turret)
			{
				CAJJEALKJMM castSkill = GetCastSkill(2);
				castSkill.IHKCKBJBEGF = (float)castSkill.IHKCKBJBEGF + 1f;
			}
		}
		OnAttack();
	}

	[JDLHECHNNDH]
	public void CreateSkill1Missile(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = get_m_actor().CreateMissile("skill1_missile", HEPNHCEIFMO, null);
		GravesSkill1MissileAI component = actor.GetComponent<GravesSkill1MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
	}

	private void NEGPIAOPPBF()
	{
		OnAnimationEventSkill(8);
	}

	[CompilerGenerated]
	private void KCAKCALIFKB()
	{
		OnAnimationEventSkill(0);
	}
}
