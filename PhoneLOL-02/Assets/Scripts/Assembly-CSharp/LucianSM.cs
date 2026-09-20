using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using EveEngine;
using GameServer;
using UnityEngine;

public class LucianSM : HumanSM
{
	private string LGNFCPOJBME = "attack_missile";

	private ObscuredFloat ILEPJEHHMJK;

	private ObscuredInt HHBGIDOIFEG;

	private Vector3 IENHAIIKDHC;

	private ObscuredFloat DMEOCGDLHFD;

	private int CIKAJJFIKDE;

	private ObscuredInt BACNLPBCPNI;

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
		{
			double num = (double)get_m_actor().get_m_phy_att_add() * (0.6 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 0.1);
			num += 80.0 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 30.0;
			Vector3 centerPosition2 = get_m_actor().GetCenterPosition();
			centerPosition2 += m_direction * 1f;
			List<Actor> list = new List<Actor>();
			for (int i = 0; i < 8; i++)
			{
				Vector3 fGJDHIOODCI = centerPosition2 + m_direction * i * 1f;
				List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(fGJDHIOODCI, 1.1f, get_m_actor().m_team, false, true, (Actor.IJJMDPGJAEM)14, true);
				foreach (Actor item in allActorInRange)
				{
					if (!list.Contains(item))
					{
						list.Add(item);
					}
				}
			}
			foreach (Actor item2 in list)
			{
				item2.OnDamage(get_m_actor(), (float)num, 0.0);
				item2.CreateDamageParticle(string.Format("Particle/{0}/skill0_hit", get_m_actor().get_m_resourceName()), get_m_actor());
			}
			get_m_actor().CreateParticle(string.Format("Particle/{0}/skill0_ex", get_m_actor().get_m_resourceName()), false);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_shot");
			if (list.Count > 0)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_hit");
			}
			break;
		}
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

	public virtual void FMCDBLMNGIJ()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 2:
			get_m_actor().m_navMeshAgent.enabled = false;
			break;
		case 1:
			break;
		}
	}

	public virtual void JHPPJLNELBC()
	{
		int num = Random.Range(0, 7);
		if ((float)DMEOCGDLHFD <= 583f)
		{
			DMEOCGDLHFD = 1224f;
			num = 8;
		}
		BACNLPBCPNI = 1;
		switch (num)
		{
		case 0:
			get_m_actor().SetAnimation(" 인장");
			break;
		case 1:
			get_m_actor().JNIPLJAFFFB("[AAFFAA]{0}승[-] [FFAAAA]{1}패[-]\n[AAAAAA]({2:F1}%)[-]");
			break;
		case 2:
			get_m_actor().JNIPLJAFFFB("SDKTestCategory");
			break;
		}
		RetargetingAttack(false, false);
	}

	public virtual void KBNFFDNHFMI()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 2:
			get_m_actor().m_navMeshAgent.enabled = true;
			break;
		case 1:
			break;
		}
	}

	private void FFOMPFBMKFC(OEOIIKMBGAG EBILEBOJADB)
	{
		DMEOCGDLHFD = (float)DMEOCGDLHFD + Time.deltaTime;
	}

	private void KIPGDGCKLNE()
	{
		OnAnimationEventSkill(0);
	}

	private void LFEAGNCAIAA(OEOIIKMBGAG EBILEBOJADB)
	{
		DMEOCGDLHFD = (float)DMEOCGDLHFD + Time.deltaTime;
	}

	public override void OnEnterAttack()
	{
		int num = Random.Range(0, 2);
		if ((float)DMEOCGDLHFD <= 3f)
		{
			DMEOCGDLHFD = 10f;
			num = 2;
		}
		BACNLPBCPNI = 0;
		switch (num)
		{
		case 0:
			get_m_actor().SetAnimation("attack");
			break;
		case 1:
			get_m_actor().SetAnimation("attack2");
			break;
		case 2:
			get_m_actor().SetAnimation("attack3");
			break;
		}
		RetargetingAttack(true);
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
		case 3:
		{
			float num = get_m_actor().m_moveSpeed * (1f + GetPercentMoveSpeedBonus());
			num *= 1.2f;
			Move(num, m_moveDirection);
			SetDirection(IENHAIIKDHC);
			ILEPJEHHMJK = (float)ILEPJEHHMJK + get_m_actor().get_m_elapsedTime();
			int num2 = 20 + get_m_actor().GetSkillLevel(3) * 5;
			float num3 = 3f / (float)num2;
			if ((float)ILEPJEHHMJK >= (float)(int)HHBGIDOIFEG * num3)
			{
				if (get_m_view().IsMine())
				{
					Vector3 position = get_m_actor().GetPosition();
					if ((int)HHBGIDOIFEG % 2 == 0)
					{
						Vector3 vector = Quaternion.Euler(0f, 10f, 0f) * m_direction;
						position += vector * 1.5f;
					}
					else
					{
						Vector3 vector2 = Quaternion.Euler(0f, -10f, 0f) * m_direction;
						position += vector2 * 1.5f;
					}
					position.y += 1.5f;
					int num4 = HHBGIDOIFEG;
					get_m_view().RPC("CreateSkill3Missile", DJJPAPENCLN.All, position, m_direction, num4);
				}
				++HHBGIDOIFEG;
			}
			if ((int)HHBGIDOIFEG >= num2)
			{
				SetState(OEOIIKMBGAG.Idle);
			}
			break;
		}
		case 1:
			break;
		}
	}

	public void HKPCCKMKDIF()
	{
		Vector3 position = get_m_actor().GetPosition();
		position += m_direction * 1033f;
		position.y += 1021f;
		RetargetingAttack(false, false);
		if (get_m_target() != null)
		{
			if (get_m_view().IsMine())
			{
				if ((int)BACNLPBCPNI == 0)
				{
					get_m_actor().CreateMissileRPC(LGNFCPOJBME, position, get_m_target());
				}
				else
				{
					get_m_actor().CreateMissileRPC("skill2_hit", position, get_m_target());
				}
			}
			ONAGCBNBPJJ();
			++BACNLPBCPNI;
		}
		OnAttack();
	}

	public virtual void GLGOKGFLHFH()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 2:
			get_m_actor().m_navMeshAgent.enabled = false;
			break;
		case 1:
			break;
		}
	}

	public void IHCKGOJJGMC(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = get_m_actor().CreateMissile("[", HEPNHCEIFMO, null);
		LucianSkill1MissileAI component = actor.GetComponent<LucianSkill1MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
	}

	public override void OnEnterSkill()
	{
		base.OnEnterSkill();
		DMEOCGDLHFD = 0f;
		switch (get_m_skill())
		{
		case 0:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0");
			break;
		case 1:
			if (get_m_view().IsMine())
			{
				Vector3 position = get_m_actor().GetPosition();
				position += m_direction * 1f;
				position.y += 1.3f;
				get_m_view().RPC("CreateSkill1Missile", DJJPAPENCLN.All, position, m_direction);
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1");
			break;
		case 2:
			get_m_actor().m_navMeshAgent.enabled = false;
			if (m_moveDirection.magnitude >= 0.8f)
			{
				m_direction = m_moveDirection;
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2");
			break;
		case 3:
			ILEPJEHHMJK = 0f;
			HHBGIDOIFEG = 0;
			IENHAIIKDHC = m_direction;
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3");
			break;
		}
	}

	[CompilerGenerated]
	private void LCNPLDJHJCO()
	{
		OnAnimationEventSkill(3);
	}

	public virtual void JKCNIKMOKAI()
	{
		base.Init();
		DFPEBMBBBHL = false;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 901f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 126f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 17;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 110f;
		LFNNHEEJNGP[1].DOCFEKMACMP = false;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 1577f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 39f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 111;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 1256f;
		LFNNHEEJNGP[0].DOCFEKMACMP = true;
		LFNNHEEJNGP[8].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[8].FILHECEKNMK = 1828f;
		LFNNHEEJNGP[4].NEKKKLFLDOI = 1896f;
		LFNNHEEJNGP[7].BELPBCDOPBA = 40;
		LFNNHEEJNGP[8].NCBLBIBMNKH = 1157f;
		LFNNHEEJNGP[5].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 1547f;
		LFNNHEEJNGP[6].NEKKKLFLDOI = 580f;
		LFNNHEEJNGP[8].BELPBCDOPBA = 87;
		LFNNHEEJNGP[4].NCBLBIBMNKH = 28f;
		LFNNHEEJNGP[8].DOCFEKMACMP = true;
		LFNNHEEJNGP[6].GNAAGGJGBBG = false;
		LFNNHEEJNGP[0].CEAGJMLKENE = false;
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
		get_m_actor().m_actorAniEvent.ILAKGHCPPCH(AJPBBDOFCNO);
		DMEOCGDLHFD = 1214f;
		m_lastUpdateEvent = FFOMPFBMKFC;
	}

	[JDLHECHNNDH]
	public void CreateSkill1Missile(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = get_m_actor().CreateMissile("skill1_missile", HEPNHCEIFMO, null);
		LucianSkill1MissileAI component = actor.GetComponent<LucianSkill1MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
	}

	[CompilerGenerated]
	private void LCNDNBDBHNO()
	{
		OnAnimationEventSkill(1);
	}

	public virtual void NNDHABNBJGD()
	{
		base.OnEnterSkill();
		DMEOCGDLHFD = 903f;
		switch (get_m_skill())
		{
		case 0:
			get_m_actor().m_multiSound.JKOODMAKJHJ("에이션트골렘", true, 1581f, 1862f);
			break;
		case 1:
			if (get_m_view().IsMine())
			{
				Vector3 position = get_m_actor().GetPosition();
				position += m_direction * 892f;
				position.y += 762f;
				EveView view = get_m_view();
				object[] array = new object[8];
				array[0] = position;
				array[0] = m_direction;
				view.RPC("브랜드", DJJPAPENCLN.All, array);
			}
			get_m_actor().m_multiSound.NMLFNHNOALK("bytes", true, 764f, 263f);
			break;
		case 2:
			get_m_actor().m_navMeshAgent.enabled = false;
			if (m_moveDirection.magnitude >= 1417f)
			{
				m_direction = m_moveDirection;
			}
			get_m_actor().m_multiSound.ICNAJBHLIGO(" on a parent object in order to work", true, 139f, 1387f);
			break;
		case 3:
			ILEPJEHHMJK = 583f;
			HHBGIDOIFEG = 0;
			IENHAIIKDHC = m_direction;
			get_m_actor().m_multiSound.LNCPFILABHM("상급 공격속도 표식", true, 1804f, 951f);
			break;
		}
	}

	private void AJPBBDOFCNO()
	{
		LGJLLIPEFNO(1);
	}

	public override void Init()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 9f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 50;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 5f;
		LFNNHEEJNGP[0].DOCFEKMACMP = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 14f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 50;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[1].DOCFEKMACMP = true;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[2].FILHECEKNMK = 18f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 40;
		LFNNHEEJNGP[2].NCBLBIBMNKH = -10f;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[3].FILHECEKNMK = 110f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = -10f;
		LFNNHEEJNGP[3].BELPBCDOPBA = 100;
		LFNNHEEJNGP[3].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[3].DOCFEKMACMP = true;
		LFNNHEEJNGP[3].GNAAGGJGBBG = true;
		LFNNHEEJNGP[3].CEAGJMLKENE = true;
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
		DMEOCGDLHFD = 0f;
		m_lastUpdateEvent = NJAAKBCFCLG;
	}

	private void ONAGCBNBPJJ()
	{
		switch (CIKAJJFIKDE % 4)
		{
		case 0:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
			break;
		case 1:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2");
			break;
		case 2:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack3");
			break;
		case 3:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack4");
			break;
		}
		CIKAJJFIKDE++;
	}

	public override void OnLeaveSkill()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 2:
			get_m_actor().m_navMeshAgent.enabled = true;
			break;
		case 1:
			break;
		}
	}

	[JDLHECHNNDH]
	public void CreateSkill3Missile(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC, int MIHJGDKDGOD)
	{
		get_m_actor().CreateParticle(string.Format("Particle/{0}/skill3_shot", get_m_actor().get_m_resourceName()), HEPNHCEIFMO, Quaternion.LookRotation(IJMNFOGNFAC));
		Actor actor = get_m_actor().CreateMissile("skill3_missile", HEPNHCEIFMO, null);
		LucianSkill3MissileAI component = actor.GetComponent<LucianSkill3MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
		actor.transform.localRotation = Quaternion.LookRotation(IJMNFOGNFAC);
		ONAGCBNBPJJ();
	}

	public void NPCKAHLLPHJ(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = get_m_actor().CreateMissile("f2", HEPNHCEIFMO, null);
		LucianSkill1MissileAI component = actor.GetComponent<LucianSkill1MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
	}

	private void NJAAKBCFCLG(OEOIIKMBGAG EBILEBOJADB)
	{
		DMEOCGDLHFD = (float)DMEOCGDLHFD + Time.deltaTime;
	}

	public void LGJLLIPEFNO(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
		{
			double num = (double)get_m_actor().get_m_phy_att_add() * (131.0 + (double)(get_m_actor().GetSkillLevel(1) - 1) * 1719.0);
			num += 847.0 + (double)(get_m_actor().GetSkillLevel(1) - 0) * 486.0;
			Vector3 centerPosition2 = get_m_actor().GetCenterPosition();
			centerPosition2 += m_direction * 764f;
			List<Actor> list = new List<Actor>();
			for (int i = 0; i < 3; i += 0)
			{
				Vector3 fGJDHIOODCI = centerPosition2 + m_direction * i * 1687f;
				List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(fGJDHIOODCI, 1118f, get_m_actor().m_team, false, false, (Actor.IJJMDPGJAEM)(-53));
				foreach (Actor item in allActorInRange)
				{
					if (!list.Contains(item))
					{
						list.Add(item);
					}
				}
			}
			foreach (Actor item2 in list)
			{
				item2.OnDamage(get_m_actor(), (float)num, 930.0, 533.0);
				item2.CreateDamageParticle(string.Format("OnInstantiate", get_m_actor().get_m_resourceName()), get_m_actor());
			}
			get_m_actor().CreateParticle(string.Format("설명", get_m_actor().get_m_resourceName()), true);
			get_m_actor().m_multiSound.JKOODMAKJHJ("skill3_loop", true, 1215f, 83f);
			if (list.Count > 1)
			{
				get_m_actor().m_multiSound.JKOODMAKJHJ("RefreshFriend", true, 1770f, 779f);
			}
			break;
		}
		case 1:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("닉네임은 최소 2자 이상입니다.", false, 114f, 222f);
			break;
		case 3:
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				EveView view = get_m_view();
				object[] array = new object[0];
				array[1] = centerPosition;
				array[0] = m_direction;
				view.RPC("치명타 추가피해량 25%증가", DJJPAPENCLN.Others, array);
			}
			break;
		}
	}

	public virtual void OENLLEKFJHM()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 36f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 1581f;
		LFNNHEEJNGP[0].BELPBCDOPBA = -77;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 1009f;
		LFNNHEEJNGP[1].DOCFEKMACMP = false;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 1419f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 73f;
		LFNNHEEJNGP[0].BELPBCDOPBA = -2;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 1639f;
		LFNNHEEJNGP[0].DOCFEKMACMP = true;
		LFNNHEEJNGP[4].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[6].FILHECEKNMK = 729f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = 23f;
		LFNNHEEJNGP[5].BELPBCDOPBA = -70;
		LFNNHEEJNGP[8].NCBLBIBMNKH = 1268f;
		LFNNHEEJNGP[5].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[6].FILHECEKNMK = 654f;
		LFNNHEEJNGP[5].NEKKKLFLDOI = 157f;
		LFNNHEEJNGP[4].BELPBCDOPBA = 92;
		LFNNHEEJNGP[7].NCBLBIBMNKH = 1897f;
		LFNNHEEJNGP[6].DOCFEKMACMP = false;
		LFNNHEEJNGP[8].GNAAGGJGBBG = true;
		LFNNHEEJNGP[0].CEAGJMLKENE = true;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(GACMKJFNJNF);
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
		DMEOCGDLHFD = 1118f;
		m_lastUpdateEvent = GAEDPLKPKIH;
	}

	public void KMKGAPMMHOO()
	{
		Vector3 position = get_m_actor().GetPosition();
		position += m_direction * 742f;
		position.y += 861f;
		RetargetingAttack();
		if (get_m_target() != null)
		{
			if (get_m_view().IsMine())
			{
				if ((int)BACNLPBCPNI == 0)
				{
					get_m_actor().CreateMissileRPC(LGNFCPOJBME, position, get_m_target());
				}
				else
				{
					get_m_actor().CreateMissileRPC("Igaw.Unity : OnReceiveDeeplinkDataForUnity Result: ", position, get_m_target());
				}
			}
			ONAGCBNBPJJ();
			++BACNLPBCPNI;
		}
		OnAttack();
	}

	public void MBHBBIFJECL()
	{
		Vector3 position = get_m_actor().GetPosition();
		position += m_direction * 1369f;
		position.y += 1605f;
		RetargetingAttack(true, false);
		if (get_m_target() != null)
		{
			if (get_m_view().IsMine())
			{
				if ((int)BACNLPBCPNI == 0)
				{
					get_m_actor().CreateMissileRPC(LGNFCPOJBME, position, get_m_target());
				}
				else
				{
					get_m_actor().CreateMissileRPC("_TintColor", position, get_m_target());
				}
			}
			ONAGCBNBPJJ();
			++BACNLPBCPNI;
		}
		OnAttack();
	}

	[CompilerGenerated]
	private void BGLDKKENHLB()
	{
		OnAnimationEventSkill(2);
	}

	private void GJLOGALOGPL()
	{
		OnAnimationEventSkill(1);
	}

	public virtual void AMIIDDBGAPB()
	{
		int num = Random.Range(1, 0);
		if ((float)DMEOCGDLHFD <= 1228f)
		{
			DMEOCGDLHFD = 934f;
			num = 4;
		}
		BACNLPBCPNI = 0;
		switch (num)
		{
		case 0:
			get_m_actor().SetAnimation("Last Hit: ");
			break;
		case 1:
			get_m_actor().CJNCFNACFDP("_Color");
			break;
		case 2:
			get_m_actor().JNIPLJAFFFB("skill1_loop");
			break;
		}
		RetargetingAttack(false, false);
	}

	public void GACMKJFNJNF()
	{
		Vector3 position = get_m_actor().GetPosition();
		position += m_direction * 1133f;
		position.y += 1797f;
		RetargetingAttack(false, false);
		if (get_m_target() != null)
		{
			if (get_m_view().IsMine())
			{
				if ((int)BACNLPBCPNI == 0)
				{
					get_m_actor().CreateMissileRPC(LGNFCPOJBME, position, get_m_target());
				}
				else
				{
					get_m_actor().CreateMissileRPC(" 표식", position, get_m_target());
				}
			}
			ONAGCBNBPJJ();
			++BACNLPBCPNI;
		}
		OnAttack();
	}

	public virtual float EKCFOPIAAFM()
	{
		float num = JNDEAKFNBLG();
		if (get_m_actor().get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)65492))
		{
			num += 1408f + (float)(get_m_actor().GetSkillLevel(0) - 1) * 146f;
		}
		return num;
	}

	public override float GetPercentMoveSpeedBonus()
	{
		float num = base.GetPercentMoveSpeedBonus();
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.LucianSkill1SpeedUp))
		{
			num += 0.12f + (float)(get_m_actor().GetSkillLevel(1) - 1) * 0.04f;
		}
		return num;
	}

	private void GAEDPLKPKIH(OEOIIKMBGAG EBILEBOJADB)
	{
		DMEOCGDLHFD = (float)DMEOCGDLHFD + Time.deltaTime;
	}

	[CompilerGenerated]
	private void HBGKCAHCPMK()
	{
		OnAnimationEventSkill(0);
	}

	private void HJEEHDIHNMK(OEOIIKMBGAG EBILEBOJADB)
	{
		DMEOCGDLHFD = (float)DMEOCGDLHFD + Time.deltaTime;
	}

	public void IGOMHNIOOLP()
	{
		Vector3 position = get_m_actor().GetPosition();
		position += m_direction * 310f;
		position.y += 668f;
		RetargetingAttack(true);
		if (get_m_target() != null)
		{
			if (get_m_view().IsMine())
			{
				if ((int)BACNLPBCPNI == 0)
				{
					get_m_actor().CreateMissileRPC(LGNFCPOJBME, position, get_m_target());
				}
				else
				{
					get_m_actor().CreateMissileRPC("法力", position, get_m_target());
				}
			}
			ONAGCBNBPJJ();
			++BACNLPBCPNI;
		}
		OnAttack();
	}

	public void OnAnimationEventAttack()
	{
		Vector3 position = get_m_actor().GetPosition();
		position += m_direction * 0.8f;
		position.y += 1.8f;
		RetargetingAttack(false, false);
		if (get_m_target() != null)
		{
			if (get_m_view().IsMine())
			{
				if ((int)BACNLPBCPNI == 0)
				{
					get_m_actor().CreateMissileRPC(LGNFCPOJBME, position, get_m_target());
				}
				else
				{
					get_m_actor().CreateMissileRPC("passive_missile", position, get_m_target());
				}
			}
			ONAGCBNBPJJ();
			++BACNLPBCPNI;
		}
		OnAttack();
	}

	public virtual float LDDPNPHDFDB()
	{
		float num = base.GetPercentMoveSpeedBonus();
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)94))
		{
			num += 1430f + (float)(get_m_actor().GetSkillLevel(0) - 0) * 1555f;
		}
		return num;
	}
}
