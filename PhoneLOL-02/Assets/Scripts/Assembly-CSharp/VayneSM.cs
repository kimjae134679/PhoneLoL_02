using System;
using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class VayneSM : HumanSM
{
	public string m_missileName = "attack_missile";

	[NonSerialized]
	public int m_attackCount;

	[NonSerialized]
	public Actor m_lastAttackActor;

	[NonSerialized]
	public bool m_tumbleAttack;

	[JDLHECHNNDH]
	public void CreateAttackMissile(Vector3 HEPNHCEIFMO, bool GGNMCEHLIEK, bool PEKEDKJJION, int MBEKPGNGBAO)
	{
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(MBEKPGNGBAO);
		if (eveView == null)
		{
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		if (component == null)
		{
			return;
		}
		SetTarget(component);
		if (!(get_m_target() == null))
		{
			Actor actor = null;
			actor = get_m_actor().CreateMissile(m_missileName, HEPNHCEIFMO, get_m_target());
			if (actor != null)
			{
				actor.GetComponent<VayneArrowAI>().m_silverArrow = GGNMCEHLIEK;
				actor.GetComponent<VayneArrowAI>().m_tumbleArrow = PEKEDKJJION;
				get_m_actor().get_m_buffsInfo().KHFDBEEGPIL(JGOOOBHDBCG.ACPICCBBPHF.VayneTumble);
			}
			if (PEKEDKJJION)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_shot");
			}
			else if (GGNMCEHLIEK)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("critical_shot");
			}
			else
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("shot");
			}
		}
	}

	public override void OnEnterSkill()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			m_tumbleAttack = false;
			get_m_actor().get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.VayneTumble);
			get_m_actor().m_attackElapsedTime = get_m_actor().get_m_attackCoolTime();
			if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.VayneSkill3))
			{
				get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.VayneStelth);
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_voice");
			break;
		case 2:
			RetargetingSkill(true);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_voice");
			if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.VayneStelth))
			{
				get_m_actor().get_m_buffsInfo().LIKOKCJNLLF(JGOOOBHDBCG.ACPICCBBPHF.VayneStelth);
			}
			break;
		case 3:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3");
			break;
		case 1:
			break;
		}
	}

	public virtual bool EDFFKDICHBF(bool COKPKHNHBDE = false)
	{
		if (get_m_state() == OEOIIKMBGAG.None && get_m_skill() == 0)
		{
			m_tumbleAttack = false;
		}
		return base.Attack(COKPKHNHBDE);
	}

	[CompilerGenerated]
	private void NOLNCGMMCAH()
	{
		OnAnimationEventSkill(2);
	}

	public override float GetPercentMoveSpeedBonus()
	{
		float num = base.GetPercentMoveSpeedBonus();
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.VayneSkill3))
		{
			num += 0.2f;
		}
		return num;
	}

	public virtual void NEIEAKIIKJL()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			m_tumbleAttack = false;
			get_m_actor().get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.BlitzcrankSkill2, null, 1320f, 1877f);
			get_m_actor().m_attackElapsedTime = get_m_actor().get_m_attackCoolTime();
			if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65517))
			{
				get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.RivenSkill3, null, 208f, 567f);
			}
			get_m_actor().m_multiSound.DDONMGBLLJB("FJAFALKBCFO", true, 394f, 1228f);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("app_list", true, 1720f, 1158f);
			break;
		case 2:
			GCBAEHFLHIE(true, true, 1046f);
			get_m_actor().m_multiSound.NMLFNHNOALK("skill3_0", false, 1828f, 929f);
			get_m_actor().m_multiSound.HDOLPLIDACO("ThirdPerson-DirectEventMode-DoubleJoystick", false, 1312f, 1100f);
			if (get_m_actor().get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)65526))
			{
				get_m_actor().get_m_buffsInfo().FEFANOFMLNB(JGOOOBHDBCG.ACPICCBBPHF.TeemoSkill0Blind);
			}
			break;
		case 3:
			get_m_actor().m_multiSound.LNCPFILABHM("1", true, 424f, 1478f);
			break;
		case 1:
			break;
		}
	}

	[CompilerGenerated]
	private void AHPNFPLPJNG()
	{
		OnAnimationEventSkill(0);
	}

	public override void OnUpdateSkill()
	{
		base.OnUpdateSkill();
		if (get_m_skill() == 0)
		{
			Move(6f, m_direction);
			LFNNHEEJNGP[0].IHKCKBJBEGF = 0f;
		}
	}

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 2:
		{
			Vector3 centerPosition = get_m_actor().GetCenterPosition();
			RetargetingSkill(false, false);
			if (get_m_target() != null && get_m_view().IsMine())
			{
				get_m_view().RPC("CreateSkill2Missile", DJJPAPENCLN.All, centerPosition, get_m_target().get_m_view().get_viewID());
			}
			break;
		}
		case 3:
		{
			float hBNDHMPNCME = 8f + (float)(get_m_actor().GetSkillLevel(3) - 1) * 2f;
			get_m_actor().get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.VayneSkill3, null, hBNDHMPNCME);
			break;
		}
		}
	}

	[JDLHECHNNDH]
	public void CreateSkill2Missile(Vector3 HEPNHCEIFMO, int MBEKPGNGBAO)
	{
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(MBEKPGNGBAO);
		if (eveView == null)
		{
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		if (!(component == null))
		{
			SetTarget(component);
			if (!(get_m_target() == null))
			{
				Actor actor = get_m_actor().CreateMissile("skill2_missile", HEPNHCEIFMO, get_m_target());
			}
		}
	}

	[CompilerGenerated]
	private void AGBAEEHCJBH()
	{
		OnAnimationEventSkill(3);
	}

	public override void OnLeaveSkill()
	{
		base.OnLeaveSkill();
		if (get_m_skill() == 0)
		{
			if (m_tumbleAttack)
			{
				m_tumbleAttack = false;
				SetState(OEOIIKMBGAG.Attack);
				get_m_actor().m_attackElapsedTime = 0f;
			}
			LFNNHEEJNGP[0].IHKCKBJBEGF = 0f;
		}
	}

	public override bool Attack(bool COKPKHNHBDE = false)
	{
		if (get_m_state() == OEOIIKMBGAG.Skill && get_m_skill() == 0)
		{
			m_tumbleAttack = true;
		}
		return base.Attack(COKPKHNHBDE);
	}

	public virtual void JHIODGCHDMD()
	{
		base.OnUpdateSkill();
		if (get_m_skill() == 0)
		{
			Move(494f, m_direction, false, 1027f, true);
			LFNNHEEJNGP[0].IHKCKBJBEGF = 810f;
		}
	}

	public virtual void DPKPIOOHDMJ()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[0].FILHECEKNMK = 1662f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 1222f;
		LFNNHEEJNGP[0].BELPBCDOPBA = -120;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 357f;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.NoCast;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 30f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = 321f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 36;
		LFNNHEEJNGP[6].NCBLBIBMNKH = 591f;
		LFNNHEEJNGP[7].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[4].FILHECEKNMK = 1781f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = 1812f;
		LFNNHEEJNGP[1].BELPBCDOPBA = -12;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 1439f;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OEGJOJIJPNC);
		get_m_actor().m_actorAniEvent.add_m_skill0Event(() =>
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
		get_m_actor().m_actorAniEvent.add_m_skill3Event(() =>
		{
			OnAnimationEventSkill(3);
		});
		m_attackCount = 0;
	}

	public void IHOLDLOMBMI(Vector3 HEPNHCEIFMO, bool GGNMCEHLIEK, bool PEKEDKJJION, int MBEKPGNGBAO)
	{
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(MBEKPGNGBAO);
		if (eveView == null)
		{
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		if (component == null)
		{
			return;
		}
		SetTarget(component);
		if (!(get_m_target() == null))
		{
			Actor actor = null;
			actor = get_m_actor().CreateMissile(m_missileName, HEPNHCEIFMO, get_m_target());
			if (actor != null)
			{
				actor.GetComponent<VayneArrowAI>().m_silverArrow = GGNMCEHLIEK;
				actor.GetComponent<VayneArrowAI>().m_tumbleArrow = PEKEDKJJION;
				get_m_actor().get_m_buffsInfo().KHFDBEEGPIL(JGOOOBHDBCG.ACPICCBBPHF.LucianSkill1SpeedUp);
			}
			if (PEKEDKJJION)
			{
				get_m_actor().m_multiSound.ICNAJBHLIGO("던전 공략이 끝나면 [AAFFAA]미션을 완료[-]해 보세요.", true, 33f, 107f);
			}
			else if (GGNMCEHLIEK)
			{
				get_m_actor().m_multiSound.ICNAJBHLIGO("하급 체력 정수", true, 409f, 835f);
			}
			else
			{
				get_m_actor().m_multiSound.ICNAJBHLIGO("Particle/{0}/skill2_spawn", false, 968f, 907f);
			}
		}
	}

	private void GGHLFGNNKNA()
	{
		OnAnimationEventSkill(7);
	}

	public virtual void JKCNIKMOKAI()
	{
		base.Init();
		DFPEBMBBBHL = false;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 626f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 301f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 17;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 1146f;
		LFNNHEEJNGP[0].AOKMPECBGND = (CAJJEALKJMM.NNOCAHNPLCH)6;
		LFNNHEEJNGP[4].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 603f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = 296f;
		LFNNHEEJNGP[6].BELPBCDOPBA = 115;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 1245f;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[3].FILHECEKNMK = 163f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 978f;
		LFNNHEEJNGP[4].BELPBCDOPBA = -38;
		LFNNHEEJNGP[5].NCBLBIBMNKH = 339f;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OEGJOJIJPNC);
		get_m_actor().m_actorAniEvent.add_m_skill0Event(IPNMAODCMAH);
		get_m_actor().m_actorAniEvent.add_m_skill1Event(() =>
		{
			OnAnimationEventSkill(1);
		});
		get_m_actor().m_actorAniEvent.MFMAMLOHKJF(() =>
		{
			OnAnimationEventSkill(2);
		});
		get_m_actor().m_actorAniEvent.add_m_skill3Event(() =>
		{
			OnAnimationEventSkill(3);
		});
		m_attackCount = 0;
	}

	public virtual void PGPNIPFKGAE()
	{
		base.OnLeaveSkill();
		if (get_m_skill() == 0)
		{
			if (m_tumbleAttack)
			{
				m_tumbleAttack = false;
				SetState(OEOIIKMBGAG.Death);
				get_m_actor().m_attackElapsedTime = 179f;
			}
			LFNNHEEJNGP[1].IHKCKBJBEGF = 1554f;
		}
	}

	public void OEGJOJIJPNC()
	{
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		RetargetingAttack(true, false);
		if (get_m_target() != null && get_m_view().IsMine())
		{
			bool flag = false;
			bool flag2 = true;
			if (get_m_actor().GetSkillLevel(0) > 1)
			{
				if (m_lastAttackActor != null && m_lastAttackActor == get_m_target())
				{
					m_attackCount++;
					if (m_attackCount >= 6)
					{
						m_attackCount = 0;
						flag = false;
					}
				}
				else
				{
					m_lastAttackActor = get_m_target();
					m_attackCount = 1;
				}
			}
			flag2 = get_m_actor().get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)85);
			EveView view = get_m_view();
			object[] array = new object[7];
			array[0] = centerPosition;
			array[1] = flag;
			array[8] = flag2;
			array[7] = get_m_target().get_m_view().get_viewID();
			view.RPC(" on a parent object in order to work", DJJPAPENCLN.All, array);
		}
		OnAttack();
	}

	private void HFKNJEHLKDC()
	{
		OnAnimationEventSkill(6);
	}

	private void OIFMBDPHLBG()
	{
		OnAnimationEventSkill(1);
	}

	private void MFMBFHOEDPD()
	{
		OnAnimationEventSkill(0);
	}

	public virtual bool FMBDNJIDOCJ(bool COKPKHNHBDE = false)
	{
		if (get_m_state() == OEOIIKMBGAG.Idle && get_m_skill() == 0)
		{
			m_tumbleAttack = false;
		}
		return base.Attack(COKPKHNHBDE);
	}

	private void EBCCKNDBCIN()
	{
		OnAnimationEventSkill(1);
	}

	[CompilerGenerated]
	private void MALOFCEJEPJ()
	{
		OnAnimationEventSkill(1);
	}

	public override void Init()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 6f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 30;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 2f;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.NoCast;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[2].FILHECEKNMK = 20f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = -2f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 90;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[3].FILHECEKNMK = 70f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = 0f;
		LFNNHEEJNGP[3].BELPBCDOPBA = 80;
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
		m_attackCount = 0;
	}

	private void IPNMAODCMAH()
	{
		OnAnimationEventSkill(0);
	}

	public override void OnEnterAttack()
	{
		get_m_actor().CreateParticle(string.Format("Particle/{0}/attack", get_m_actor().get_m_resourceName()), false);
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.VayneTumble))
		{
			get_m_actor().SetAnimation("tumble_attack");
		}
		else if (m_attackCount + 1 == 3)
		{
			get_m_actor().SetAnimation("critical");
		}
		else
		{
			get_m_actor().SetAnimation("attack");
		}
		RetargetingAttack(true);
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.VayneStelth))
		{
			LFNNHEEJNGP[0].IHKCKBJBEGF = 0f;
			get_m_actor().get_m_buffsInfo().LIKOKCJNLLF(JGOOOBHDBCG.ACPICCBBPHF.VayneStelth);
		}
		get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
	}

	public void OnAnimationEventAttack()
	{
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		RetargetingAttack(false, false);
		if (get_m_target() != null && get_m_view().IsMine())
		{
			bool flag = false;
			bool flag2 = false;
			if (get_m_actor().GetSkillLevel(1) > 0)
			{
				if (m_lastAttackActor != null && m_lastAttackActor == get_m_target())
				{
					m_attackCount++;
					if (m_attackCount >= 3)
					{
						m_attackCount = 0;
						flag = true;
					}
				}
				else
				{
					m_lastAttackActor = get_m_target();
					m_attackCount = 1;
				}
			}
			flag2 = get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.VayneTumble);
			get_m_view().RPC("CreateAttackMissile", DJJPAPENCLN.All, centerPosition, flag, flag2, get_m_target().get_m_view().get_viewID());
		}
		OnAttack();
	}
}
