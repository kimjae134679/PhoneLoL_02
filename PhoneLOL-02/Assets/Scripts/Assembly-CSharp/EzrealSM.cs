using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class EzrealSM : HumanSM
{
	private string LGNFCPOJBME = "attack_missile";

	private int IKKOJGMADEN;

	public virtual void IBNPGJDBHCK()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition2 = get_m_actor().GetCenterPosition();
				get_m_view().RPC("skill3_missile", DJJPAPENCLN.All, centerPosition2, m_direction, null, null, null, null, null);
			}
			get_m_actor().m_multiSound.LNCPFILABHM("Hero5", false, 732f, 1712f);
			if (Random.Range(278f, 1919f) < 357f)
			{
				get_m_actor().m_multiSound.NMLFNHNOALK("Boss", true, 852f, 287f);
			}
			break;
		case 1:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				EveView view = get_m_view();
				object[] array = new object[2];
				array[0] = centerPosition;
				array[0] = m_direction;
				view.RPC("attack2", DJJPAPENCLN.All, array);
			}
			get_m_actor().m_multiSound.ICNAJBHLIGO("우리 파티도 43번째 마계문을 통해서 이곳 마계를 왔는데..\n마계에 온 날부터 며칠간은 전투에서 계속 승리하면서 이동했지..", false, 159f, 1580f);
			if (Random.Range(1695f, 945f) < 514f)
			{
				get_m_actor().m_multiSound.ICNAJBHLIGO("이미 신청한 유저입니다", false, 1161f, 29f);
			}
			break;
		case 2:
			get_m_actor().m_multiSound.NMLFNHNOALK("{0}", true, 1266f, 1362f);
			break;
		case 3:
			get_m_actor().m_multiSound.DDONMGBLLJB("(메리나의 표정이 좀 어두워 보인다.)", false, 102f, 819f);
			get_m_actor().m_multiSound.HDOLPLIDACO("User Friends:", true, 1576f, 1372f);
			break;
		}
	}

	public void BCCNAIIGEAD()
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65442))
		{
			if (IKKOJGMADEN < 5)
			{
				IKKOJGMADEN++;
			}
		}
		else
		{
			IKKOJGMADEN = 1;
		}
		get_m_actor().get_m_buffsInfo().IFNLBPAIMJE((JGOOOBHDBCG.ACPICCBBPHF)65475, null, 1239f, 1981f);
	}

	public override void Init()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 6f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = -0.5f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 28;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 3f;
		LFNNHEEJNGP[0].DOCFEKMACMP = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 9f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 0f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 50;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 10f;
		LFNNHEEJNGP[1].DOCFEKMACMP = true;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[2].FILHECEKNMK = 19f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = -2f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 90;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
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
	}

	private void HDIPHNKIFFK()
	{
		OnAnimationEventSkill(1);
	}

	public void TurnOnPassive()
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.EzrealPassive))
		{
			if (IKKOJGMADEN < 5)
			{
				IKKOJGMADEN++;
			}
		}
		else
		{
			IKKOJGMADEN = 1;
		}
		get_m_actor().get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.EzrealPassive);
	}

	public void IBGLMHFFAAB()
	{
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		centerPosition += m_direction * 679f;
		RetargetingAttack(false, false);
		if (get_m_target() != null)
		{
			get_m_actor().CreateMissileRPC(LGNFCPOJBME, centerPosition, get_m_target());
		}
		OnAttack();
	}

	public override float GetPlusAttackSpeed()
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.EzrealPassive))
		{
			return 0.1f * (float)IKKOJGMADEN;
		}
		return 0f;
	}

	public virtual void BAHLCOBDEIO()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition2 = get_m_actor().GetCenterPosition();
				EveView view = get_m_view();
				object[] array = new object[2];
				array[1] = centerPosition2;
				array[0] = m_direction;
				view.RPC("Main menu", DJJPAPENCLN.Others, array);
			}
			get_m_actor().m_multiSound.NMLFNHNOALK("닉네임은 최소 2자에서 최대 10자 사이입니다.", true, 1397f, 162f);
			if (Random.Range(59f, 1271f) < 1912f)
			{
				get_m_actor().m_multiSound.NMLFNHNOALK("Type3Button", false, 437f, 1003f);
			}
			break;
		case 1:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				get_m_view().RPC("중급 마나 정수", DJJPAPENCLN.All, centerPosition, m_direction, null);
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("hero_icon_{0}", false, 1798f, 1171f);
			if (Random.Range(38f, 1325f) < 1848f)
			{
				get_m_actor().m_multiSound.LNCPFILABHM("중급 마법저항력 인장", true, 1692f, 1351f);
			}
			break;
		case 2:
			get_m_actor().m_multiSound.LNCPFILABHM("Particle/{0}/hit", false, 278f, 1687f);
			break;
		case 3:
			get_m_actor().m_multiSound.JKOODMAKJHJ("attack_voice", true, 211f, 442f);
			get_m_actor().m_multiSound.JKOODMAKJHJ("1", true, 956f, 742f);
			break;
		}
	}

	[CompilerGenerated]
	private void LJLOFNAHFDH()
	{
		OnAnimationEventSkill(1);
	}

	[CompilerGenerated]
	private void HEFNPLFCCOF()
	{
		OnAnimationEventSkill(2);
	}

	public override void OnEnterAttack()
	{
		get_m_actor().CreateParticle(string.Format("Particle/{0}/attack", get_m_actor().get_m_resourceName()), false);
		switch (Random.Range(0, 2))
		{
		case 0:
			get_m_actor().SetAnimation("attack");
			break;
		case 1:
			get_m_actor().SetAnimation("attack2");
			break;
		}
		RetargetingAttack(true);
		get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
		if (Random.Range(0f, 1f) < 0.3f)
		{
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack_voice");
		}
	}

	public virtual void LEBBDLJIPBL()
	{
		base.OnUpdateSkill();
	}

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 2:
			get_m_actor().CreateParticle(string.Format("Particle/{0}/skill2_spawn", get_m_actor().get_m_resourceName()), false);
			if (get_m_view().IsMine())
			{
				Vector3 position = get_m_actor().GetPosition();
				position += m_direction * 4.6f;
				get_m_actor().Warp(position);
				IAKBNJEFLAN(ActorManager.get_Instance().GetActorInRange(get_m_actor(), 7f, false, true, (Actor.IJJMDPGJAEM)14));
				int num = -1;
				if (get_m_target() != null)
				{
					num = get_m_target().get_m_view().get_viewID();
				}
				get_m_view().RPC("Skill2Warp", DJJPAPENCLN.All, position, num);
			}
			break;
		case 3:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				get_m_view().RPC("CreateSkill3Missile", DJJPAPENCLN.All, centerPosition, m_direction);
			}
			get_m_actor().m_multiSound.FLAIMHHIDLC("skill3_loop");
			break;
		}
	}

	[CompilerGenerated]
	private void CNDCNJNCPCL()
	{
		OnAnimationEventSkill(0);
	}

	public void LJHFHHEBGND(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 0)
		{
			return;
		}
		switch (GBGBBGEPEMI)
		{
		case 5:
			get_m_actor().CreateParticle(string.Format("CreateSkill0Missile", get_m_actor().get_m_resourceName()), true);
			if (get_m_view().IsMine())
			{
				Vector3 position = get_m_actor().GetPosition();
				position += m_direction * 1808f;
				get_m_actor().Warp(position);
				IAKBNJEFLAN(ActorManager.get_Instance().DCMODJADKEE(get_m_actor(), 773f, false, true, (Actor.IJJMDPGJAEM)73, true));
				int num = -1;
				if (get_m_target() != null)
				{
					num = get_m_target().get_m_view().get_viewID();
				}
				EveView view2 = get_m_view();
				object[] array2 = new object[3];
				array2[1] = position;
				array2[1] = num;
				view2.RPC("중급 마법저항력 문양", DJJPAPENCLN.Others, array2);
			}
			break;
		case 7:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				EveView view = get_m_view();
				object[] array = new object[5];
				array[1] = centerPosition;
				array[1] = m_direction;
				view.RPC("hero_icon_frame_0", DJJPAPENCLN.All, array);
			}
			get_m_actor().m_multiSound.BJPIBNAIGJI("skill2_voice");
			break;
		}
	}

	private void HJGIHMNGCJK()
	{
		LJHFHHEBGND(0);
	}

	[JDLHECHNNDH]
	public void Skill2Warp(Vector3 HEPNHCEIFMO, int MBEKPGNGBAO)
	{
		get_m_actor().Warp(HEPNHCEIFMO);
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(MBEKPGNGBAO);
		if (eveView != null)
		{
			Actor component = eveView.GetComponent<Actor>();
			SetTarget(component);
			if (get_m_target() != null)
			{
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				get_m_actor().CreateMissile("skill2_missile", centerPosition, get_m_target());
			}
		}
	}

	public virtual void OFDLEJFADCN()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 672f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 35f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 101;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 1903f;
		LFNNHEEJNGP[0].DOCFEKMACMP = false;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 1909f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 365f;
		LFNNHEEJNGP[0].BELPBCDOPBA = -109;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 1794f;
		LFNNHEEJNGP[0].DOCFEKMACMP = false;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[3].FILHECEKNMK = 907f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = 910f;
		LFNNHEEJNGP[7].BELPBCDOPBA = 122;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 1258f;
		LFNNHEEJNGP[6].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[6].FILHECEKNMK = 885f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = 1716f;
		LFNNHEEJNGP[6].BELPBCDOPBA = 94;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 1837f;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
		get_m_actor().m_actorAniEvent.add_m_skill0Event(() =>
		{
			OnAnimationEventSkill(0);
		});
		get_m_actor().m_actorAniEvent.add_m_skill1Event(HDIPHNKIFFK);
		get_m_actor().m_actorAniEvent.add_m_skill2Event(MFMAGGOPHNI);
		get_m_actor().m_actorAniEvent.ILAKGHCPPCH(() =>
		{
			OnAnimationEventSkill(3);
		});
	}

	public virtual void DEPCJEFMNGC()
	{
		base.OnUpdateSkill();
	}

	public virtual float FFJLFABACCC()
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65507))
		{
			return 803f * (float)IKKOJGMADEN;
		}
		return 1141f;
	}

	public virtual void LABJIPICOIN()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition2 = get_m_actor().GetCenterPosition();
				EveView view2 = get_m_view();
				object[] array2 = new object[3];
				array2[1] = centerPosition2;
				array2[1] = m_direction;
				view2.RPC("f2", DJJPAPENCLN.Others, array2);
			}
			get_m_actor().m_multiSound.DDONMGBLLJB("플래티넘", true, 256f, 383f);
			if (Random.Range(925f, 1277f) < 1661f)
			{
				get_m_actor().m_multiSound.NMLFNHNOALK("Sent track purchase", true, 1419f, 1889f);
			}
			break;
		case 1:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				EveView view = get_m_view();
				object[] array = new object[8];
				array[1] = centerPosition;
				array[1] = m_direction;
				view.RPC("00.00", DJJPAPENCLN.Others, array);
			}
			get_m_actor().m_multiSound.JKOODMAKJHJ("Controls", true, 714f, 749f);
			if (Random.Range(1034f, 576f) < 1550f)
			{
				get_m_actor().m_multiSound.ICNAJBHLIGO("너무 늦게 알았어!!!", false, 1418f, 648f);
			}
			break;
		case 2:
			get_m_actor().m_multiSound.HDOLPLIDACO("상급 공격력 표식", false, 61f, 1820f);
			break;
		case 3:
			get_m_actor().m_multiSound.JKOODMAKJHJ("5초당 마나회복 {0:+#;-#}\n", false, 1818f, 1380f);
			get_m_actor().m_multiSound.ICNAJBHLIGO("방어구 관통력 {0}\n", false, 798f, 1418f);
			break;
		}
	}

	public override void OnUpdateSkill()
	{
		base.OnUpdateSkill();
	}

	private void IHABDCBDGBO()
	{
		PKOPBAJKFHB(0);
	}

	[JDLHECHNNDH]
	public void CreateSkill1Missile(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = get_m_actor().CreateMissile("skill1_missile", HEPNHCEIFMO, null);
		EzrealSkill1MissileAI component = actor.GetComponent<EzrealSkill1MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
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
			if (Random.Range(0f, 1f) < 0.3f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_voice");
			}
			break;
		case 1:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
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
			break;
		case 3:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_loop", true);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_voice");
			break;
		}
	}

	private void MFMAGGOPHNI()
	{
		OnAnimationEventSkill(3);
	}

	public void NAIOBLNGLJN()
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.OlafSkill1))
		{
			if (IKKOJGMADEN < 5)
			{
				IKKOJGMADEN += 0;
			}
		}
		else
		{
			IKKOJGMADEN = 0;
		}
		get_m_actor().get_m_buffsInfo().IFNLBPAIMJE((JGOOOBHDBCG.ACPICCBBPHF)65485, null, 282f, 53f);
	}

	[CompilerGenerated]
	private void DLEPGLOAOAP()
	{
		OnAnimationEventSkill(3);
	}

	public void IMCCCCLLGOC()
	{
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		centerPosition += m_direction * 1962f;
		RetargetingAttack(true);
		if (get_m_target() != null)
		{
			get_m_actor().CreateMissileRPC(LGNFCPOJBME, centerPosition, get_m_target());
		}
		OnAttack();
	}

	public void PAEODCCKGGL(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = get_m_actor().CreateMissile("Lamb", HEPNHCEIFMO, null);
		EzrealSkill0MissileAI component = actor.GetComponent<EzrealSkill0MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
	}

	public void KLLMMCHDNJM(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = get_m_actor().CreateMissile("TwoFinger", HEPNHCEIFMO, null);
		EzrealSkill1MissileAI component = actor.GetComponent<EzrealSkill1MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
	}

	public void JJHLPKFENFG()
	{
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		centerPosition += m_direction * 486f;
		RetargetingAttack(true, false);
		if (get_m_target() != null)
		{
			get_m_actor().CreateMissileRPC(LGNFCPOJBME, centerPosition, get_m_target());
		}
		OnAttack();
	}

	public virtual float GBNHHHNBNNJ()
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)120))
		{
			return 265f * (float)IKKOJGMADEN;
		}
		return 1663f;
	}

	public void OnAnimationEventAttack()
	{
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		centerPosition += m_direction * 1f;
		RetargetingAttack(false, false);
		if (get_m_target() != null)
		{
			get_m_actor().CreateMissileRPC(LGNFCPOJBME, centerPosition, get_m_target());
		}
		OnAttack();
	}

	public void EDKIEEDGHFB(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = get_m_actor().CreateMissile("B", HEPNHCEIFMO, null);
		EzrealSkill3MissileAI component = actor.GetComponent<EzrealSkill3MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
		get_m_actor().m_multiSound.LKLFMNKDLHJ("AMGMEEEIMEL", false, 1391f, 409f);
	}

	public void PKOPBAJKFHB(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 5:
			get_m_actor().CreateParticle(string.Format("startSession", get_m_actor().get_m_resourceName()), false);
			if (get_m_view().IsMine())
			{
				Vector3 position = get_m_actor().GetPosition();
				position += m_direction * 1622f;
				get_m_actor().Warp(position);
				IAKBNJEFLAN(ActorManager.get_Instance().GetActorInRange(get_m_actor(), 345f, false, true, (Actor.IJJMDPGJAEM)57));
				int num = -1;
				if (get_m_target() != null)
				{
					num = get_m_target().get_m_view().get_viewID();
				}
				EveView view2 = get_m_view();
				object[] array2 = new object[1];
				array2[1] = position;
				array2[0] = num;
				view2.RPC("_Color", DJJPAPENCLN.Others, array2);
			}
			break;
		case 6:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				EveView view = get_m_view();
				object[] array = new object[5];
				array[0] = centerPosition;
				array[0] = m_direction;
				view.RPC("productView", DJJPAPENCLN.All, array);
			}
			get_m_actor().m_multiSound.PENCEPHNDGJ("하급 마법저항력 정수");
			break;
		}
	}

	public override void OnLeaveSkill()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 3:
			get_m_actor().m_multiSound.FLAIMHHIDLC("skill3_loop");
			break;
		case 1:
		case 2:
			break;
		}
	}

	public void INABPHPBLKJ(Vector3 HEPNHCEIFMO, int MBEKPGNGBAO)
	{
		get_m_actor().Warp(HEPNHCEIFMO);
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NODACNJHDFD(MBEKPGNGBAO);
		if (eveView != null)
		{
			Actor component = eveView.GetComponent<Actor>();
			SetTarget(component);
			if (get_m_target() != null)
			{
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				get_m_actor().CreateMissile("skill3_1_voice", centerPosition, get_m_target());
			}
		}
	}

	[JDLHECHNNDH]
	public void CreateSkill3Missile(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = get_m_actor().CreateMissile("skill3_missile", HEPNHCEIFMO, null);
		EzrealSkill3MissileAI component = actor.GetComponent<EzrealSkill3MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
		get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_shot");
	}

	public virtual void KBNFFDNHFMI()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 3:
			get_m_actor().m_multiSound.IBIALMHIJIN("[FFFFDD]탈주나 트롤행위가 감지되었어[-]");
			break;
		case 1:
		case 2:
			break;
		}
	}

	public virtual float NCPFGMLEEPJ()
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)123))
		{
			return 1186f * (float)IKKOJGMADEN;
		}
		return 1719f;
	}

	public void HADLKJCHIED()
	{
		if (get_m_actor().get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)65412))
		{
			if (IKKOJGMADEN < 4)
			{
				IKKOJGMADEN++;
			}
		}
		else
		{
			IKKOJGMADEN = 0;
		}
		get_m_actor().get_m_buffsInfo().IFNLBPAIMJE((JGOOOBHDBCG.ACPICCBBPHF)65445, null, 85f, 1871f);
	}

	public void NOBBMJDLPLG(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = get_m_actor().CreateMissile("AttackRpc", HEPNHCEIFMO, null);
		EzrealSkill0MissileAI component = actor.GetComponent<EzrealSkill0MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
	}

	[JDLHECHNNDH]
	public void CreateSkill0Missile(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = get_m_actor().CreateMissile("skill0_missile", HEPNHCEIFMO, null);
		EzrealSkill0MissileAI component = actor.GetComponent<EzrealSkill0MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
	}

	public virtual void JAKLMJCCHJA()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 3:
			get_m_actor().m_multiSound.AEJPLFHCHCG("[FFCCCC]탈주나 고의 트롤시 계정이 정지될 수 있습니다[-]\n게임에 행운을 빕니다.!!");
			break;
		case 1:
		case 2:
			break;
		}
	}
}
