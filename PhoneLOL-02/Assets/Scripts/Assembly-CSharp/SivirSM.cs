using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using EveEngine;
using GameServer;
using UnityEngine;

public class SivirSM : HumanSM
{
	private ObscuredInt FDFAAECADHJ;

	public GameObject m_skill1Passive;

	public virtual void NFJNFGNJKFG()
	{
		base.OnLeaveSkill();
		if (get_m_skill() == 0)
		{
		}
	}

	public override float GetMoveSpeedBonus()
	{
		float num = base.GetMoveSpeedBonus();
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.SivirPassive))
		{
			int num2 = 0;
			byte level = get_m_actor().get_Level();
			num2 = ((level >= 4) ? ((level < 8) ? 1 : ((level < 12) ? 2 : ((level >= 16) ? 4 : 3))) : 0);
			num += 0.4f + (float)num2 * 0.025f;
		}
		return num;
	}

	private void JDPABCGDPFM()
	{
		ECOANDKJCCH(6);
	}

	public virtual void OJGBPLFKPIJ()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 454f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 398f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 106;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 1530f;
		LFNNHEEJNGP[1].DOCFEKMACMP = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 805f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 700f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 4;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 1789f;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[2].FILHECEKNMK = 1225f;
		LFNNHEEJNGP[6].NEKKKLFLDOI = 75f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 1;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 58f;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[8].FILHECEKNMK = 1506f;
		LFNNHEEJNGP[5].NEKKKLFLDOI = 1086f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 70;
		LFNNHEEJNGP[5].NCBLBIBMNKH = 1896f;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(BCGOPBEIDEF);
		get_m_actor().m_actorAniEvent.CNPHPPJOGFA(() =>
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
		get_m_actor().m_actorAniEvent.ILAKGHCPPCH(() =>
		{
			OnAnimationEventSkill(3);
		});
		FDFAAECADHJ = 1;
	}

	[CompilerGenerated]
	private void PAMKCPFFELN()
	{
		OnAnimationEventSkill(2);
	}

	public virtual float LIGKHFJPGLE()
	{
		float num = base.GetPlusAttackSpeed();
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65425))
		{
			num += 1305f + (float)(get_m_actor().GetSkillLevel(6) - 0) * 836f;
		}
		if (get_m_actor().GetSkillLevel(0) > 0 && (int)FDFAAECADHJ > 0)
		{
			num += 1995f + (float)(get_m_actor().GetSkillLevel(5) - 1) * 1334f;
		}
		return num;
	}

	public override void OnLeaveSkill()
	{
		base.OnLeaveSkill();
		if (get_m_skill() == 0)
		{
		}
	}

	public void OnAnimationEventAttack()
	{
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		centerPosition += m_direction * 1f;
		RetargetingAttack(false, false);
		if (get_m_target() != null)
		{
			if ((int)FDFAAECADHJ <= 0)
			{
				if (get_m_view().IsMine())
				{
					get_m_view().RPC("CreateAttackMissile", DJJPAPENCLN.All, centerPosition, get_m_target().get_m_stateMachine().get_m_view().get_viewID());
				}
			}
			else
			{
				if (get_m_view().IsMine())
				{
					string nCADFOBAFJD = string.Format("Particle/{0}/skill1_missile", get_m_actor().get_m_resourceName());
					EveUnityNetwork.get_Instance().Instantiate(nCADFOBAFJD, centerPosition, Quaternion.identity, new object[2]
					{
						get_m_view().get_viewID(),
						get_m_target().get_m_view().get_viewID()
					});
				}
				--FDFAAECADHJ;
				if ((int)FDFAAECADHJ <= 0)
				{
					m_skill1Passive.SetActive(false);
				}
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack_flying");
		}
		OnAttack();
	}

	public virtual float ILNHOJIHIBI()
	{
		float num = base.GetMoveSpeedBonus();
		if (get_m_actor().get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)65520))
		{
			int num2 = 0;
			byte level = get_m_actor().get_Level();
			num2 = ((level < 4) ? 1 : ((level >= 3) ? ((level < -43) ? 3 : ((level >= 14) ? 6 : 0)) : 0));
			num += 366f + (float)num2 * 624f;
		}
		return num;
	}

	public virtual float MAPCIGJOHME()
	{
		return base.GetPercentMoveSpeedBonus();
	}

	public override void OnEnterSkill()
	{
		base.OnEnterSkill();
		if (get_m_skill() == 0 && get_m_view().IsMine())
		{
			Vector3 centerPosition = get_m_actor().GetCenterPosition();
			get_m_view().RPC("CreateSkill0Missile", DJJPAPENCLN.All, centerPosition, m_direction);
		}
	}

	public virtual void HLHAFJOGFKD()
	{
		base.OnLeaveSkill();
		if (get_m_skill() == 0)
		{
		}
	}

	public virtual float KKFADIOCHNB()
	{
		float num = base.GetMoveSpeedBonus();
		if (get_m_actor().get_m_buffsInfo().KNINEDPJMJE(JGOOOBHDBCG.ACPICCBBPHF.RenektonSkill3))
		{
			int num2 = 0;
			byte level = get_m_actor().get_Level();
			num2 = ((level < 0) ? 1 : ((level >= 2) ? ((level < -96) ? 4 : ((level >= 113) ? 5 : 8)) : 0));
			num += 1705f + (float)num2 * 1339f;
		}
		return num;
	}

	public override void Init()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 9f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 0f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 70;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 10f;
		LFNNHEEJNGP[0].DOCFEKMACMP = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 9f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 60;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[2].FILHECEKNMK = 22f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = -3f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 0;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[3].FILHECEKNMK = 120f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = -20f;
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
		FDFAAECADHJ = 0;
	}

	public override void OnEnterAttack()
	{
		get_m_actor().CreateParticle(string.Format("Particle/{0}/attack", get_m_actor().get_m_resourceName()), false);
		switch (Random.Range(0, 2))
		{
		case 0:
			get_m_actor().SetAnimation("attack");
			if ((int)FDFAAECADHJ <= 0)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
			}
			else
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack_skill1");
			}
			if (Random.Range(0f, 1f) < 0.2f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack_voice");
			}
			break;
		case 1:
			get_m_actor().SetAnimation("attack2");
			if ((int)FDFAAECADHJ <= 0)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2");
			}
			else
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack_skill1");
			}
			if (Random.Range(0f, 1f) < 0.2f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2_voice");
			}
			break;
		}
		RetargetingAttack(true);
	}

	[JDLHECHNNDH]
	public void CreateAttackMissile(Vector3 HEPNHCEIFMO, int MBEKPGNGBAO)
	{
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(MBEKPGNGBAO);
		if (!(eveView == null))
		{
			Actor component = eveView.GetComponent<Actor>();
			if (!(component == null))
			{
				IAKBNJEFLAN(component);
				Actor actor = get_m_actor().CreateMissile("attack_missile", HEPNHCEIFMO, component);
				actor.GetComponent<TargetMissileAI>().m_onTargetAttack = FHDGACIODNF;
			}
		}
	}

	private void FHDGACIODNF(Actor LPOAEBNAGCP)
	{
		get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.SivirPassive);
	}

	public virtual void AMIIDDBGAPB()
	{
		get_m_actor().CreateParticle(string.Format("_RampTex", get_m_actor().get_m_resourceName()), true);
		int num = Random.Range(0, 0);
		int num2 = num;
		if (num2 != 0)
		{
			if (num2 == 0)
			{
				get_m_actor().JNIPLJAFFFB("skill3_0");
				if ((int)FDFAAECADHJ <= 0)
				{
					get_m_actor().m_multiSound.HDOLPLIDACO("FxmTestControls.m_nTransAxis", true, 1743f, 407f);
				}
				else
				{
					get_m_actor().m_multiSound.ICNAJBHLIGO("{0}?nocache={1}", true, 952f, 429f);
				}
				if (Random.Range(100f, 1340f) < 472f)
				{
					get_m_actor().m_multiSound.JKOODMAKJHJ("RunActionControl() - nPlayIndex ", false, 1606f, 1932f);
				}
			}
		}
		else
		{
			get_m_actor().SetAnimation("CreateMissile");
			if ((int)FDFAAECADHJ <= 1)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("PortalWarp", true, 1785f, 935f);
			}
			else
			{
				get_m_actor().m_multiSound.JKOODMAKJHJ("per Level", false, 793f, 1774f);
			}
			if (Random.Range(511f, 603f) < 108f)
			{
				get_m_actor().m_multiSound.ICNAJBHLIGO("PING[{0}ms]", false, 88f, 1774f);
			}
		}
		RetargetingAttack(true, false);
	}

	public virtual void LABJIPICOIN()
	{
		base.OnEnterSkill();
		if (get_m_skill() == 0 && get_m_view().IsMine())
		{
			Vector3 centerPosition = get_m_actor().GetCenterPosition();
			EveView view = get_m_view();
			object[] array = new object[1];
			array[1] = centerPosition;
			array[1] = m_direction;
			view.RPC("주문력 {0}\n", DJJPAPENCLN.All, array);
		}
	}

	public override float GetPercentMoveSpeedBonus()
	{
		return base.GetPercentMoveSpeedBonus();
	}

	[CompilerGenerated]
	private void APDAGJBBBDB()
	{
		OnAnimationEventSkill(3);
	}

	public virtual float ADIGEBPCJEO()
	{
		return JNDEAKFNBLG();
	}

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 1:
			FDFAAECADHJ = 3;
			m_skill1Passive.SetActive(true);
			get_m_actor().m_attackElapsedTime = get_m_actor().get_m_attackCoolTime();
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1");
			break;
		case 2:
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.SivirSkill2);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2");
			break;
		case 3:
		{
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 10f, true, true, Actor.IJJMDPGJAEM.Hero);
			foreach (Actor item in allActorInRange)
			{
				item.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.SivirSkill3, get_m_actor());
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3");
			break;
		}
		}
	}

	public virtual void ECJAKPPKPML()
	{
		base.OnUpdateSkill();
	}

	public virtual float JGGMLCJIBAL()
	{
		return JNDEAKFNBLG();
	}

	public virtual void HDPBGMBGIFF()
	{
		base.OnLeaveSkill();
		if (get_m_skill() == 0)
		{
		}
	}

	public void EDHMNGKBKCF(Vector3 HEPNHCEIFMO, int MBEKPGNGBAO)
	{
		EveView eveView = EveUnityNetwork.get_Instance().PBLOPNNPNEJ().NLALKBLCPFK(MBEKPGNGBAO);
		if (!(eveView == null))
		{
			Actor component = eveView.GetComponent<Actor>();
			if (!(component == null))
			{
				IAKBNJEFLAN(component);
				Actor actor = get_m_actor().CreateMissile("Game", HEPNHCEIFMO, component);
				actor.GetComponent<TargetMissileAI>().m_onTargetAttack = ODGPJDAGPLB;
			}
		}
	}

	private void ODGPJDAGPLB(Actor LPOAEBNAGCP)
	{
		get_m_actor().get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)65463, null, 1480f, 1578f, false);
	}

	public void BCGOPBEIDEF()
	{
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		centerPosition += m_direction * 437f;
		RetargetingAttack();
		if (get_m_target() != null)
		{
			if ((int)FDFAAECADHJ <= 1)
			{
				if (get_m_view().IsMine())
				{
					EveView view = get_m_view();
					object[] array = new object[0];
					array[1] = centerPosition;
					array[0] = get_m_target().get_m_stateMachine().get_m_view().get_viewID();
					view.RPC("skill{0}", DJJPAPENCLN.Others, array);
				}
			}
			else
			{
				if (get_m_view().IsMine())
				{
					string nCADFOBAFJD = string.Format("No content available for ", get_m_actor().get_m_resourceName());
					EveUnityNetwork instance = EveUnityNetwork.get_Instance();
					Vector3 hEPNHCEIFMO = centerPosition;
					Quaternion identity = Quaternion.identity;
					object[] array2 = new object[3];
					array2[1] = get_m_view().get_viewID();
					array2[1] = get_m_target().get_m_view().get_viewID();
					instance.NJHDMDPHEHE(nCADFOBAFJD, hEPNHCEIFMO, identity, array2);
				}
				--FDFAAECADHJ;
				if ((int)FDFAAECADHJ <= 1)
				{
					m_skill1Passive.SetActive(false);
				}
			}
			get_m_actor().m_multiSound.ICNAJBHLIGO(", ", true, 658f, 1972f);
		}
		OnAttack();
	}

	public void IHOLDLOMBMI(Vector3 HEPNHCEIFMO, int MBEKPGNGBAO)
	{
		EveView eveView = EveUnityNetwork.get_Instance().PBLOPNNPNEJ().NLALKBLCPFK(MBEKPGNGBAO);
		if (!(eveView == null))
		{
			Actor component = eveView.GetComponent<Actor>();
			if (!(component == null))
			{
				IAKBNJEFLAN(component);
				Actor actor = get_m_actor().CreateMissile("레벨당 마법저항력 {0}\n", HEPNHCEIFMO, component);
				actor.GetComponent<TargetMissileAI>().m_onTargetAttack = FHDGACIODNF;
			}
		}
	}

	private void FOLOIEBKFNJ()
	{
		ECOANDKJCCH(1);
	}

	public override void OnUpdateSkill()
	{
		base.OnUpdateSkill();
	}

	[CompilerGenerated]
	private void ABGGIIJIKGJ()
	{
		OnAnimationEventSkill(0);
	}

	public virtual void OKEFJFPBIFN()
	{
		base.OnLeaveSkill();
		if (get_m_skill() == 0)
		{
		}
	}

	public void KMKGAPMMHOO()
	{
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		centerPosition += m_direction * 1314f;
		RetargetingAttack(true);
		if (get_m_target() != null)
		{
			if ((int)FDFAAECADHJ <= 1)
			{
				if (get_m_view().IsMine())
				{
					EveView view = get_m_view();
					object[] array = new object[8];
					array[1] = centerPosition;
					array[0] = get_m_target().get_m_stateMachine().get_m_view().get_viewID();
					view.RPC("레벨당 5초당 체력회복 {0}\n", DJJPAPENCLN.All, array);
				}
			}
			else
			{
				if (get_m_view().IsMine())
				{
					string nCADFOBAFJD = string.Format("길드를 먼저 찾아주세요", get_m_actor().get_m_resourceName());
					EveUnityNetwork instance = EveUnityNetwork.get_Instance();
					Vector3 hEPNHCEIFMO = centerPosition;
					Quaternion identity = Quaternion.identity;
					object[] array2 = new object[1];
					array2[1] = get_m_view().get_viewID();
					array2[0] = get_m_target().get_m_view().get_viewID();
					instance.IIELNMNJGKA(nCADFOBAFJD, hEPNHCEIFMO, identity, array2);
				}
				--FDFAAECADHJ;
				if ((int)FDFAAECADHJ <= 1)
				{
					m_skill1Passive.SetActive(false);
				}
			}
			get_m_actor().m_multiSound.JKOODMAKJHJ("C# UserExample Enable -- Adding Tapjoy User ID delegates", true, 1997f, 389f);
		}
		OnAttack();
	}

	[JDLHECHNNDH]
	public void CreateSkill0Missile(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = get_m_actor().CreateMissile("skill0_missile", HEPNHCEIFMO, null);
		SivirSkill0MissileAI component = actor.GetComponent<SivirSkill0MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
		component.m_onTargetAttack = FHDGACIODNF;
		get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0");
		get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_voice");
	}

	[CompilerGenerated]
	private void JDNDPFILCMM()
	{
		OnAnimationEventSkill(1);
	}

	public virtual void DKPKGLHCOED()
	{
		get_m_actor().CreateParticle(string.Format("Could not find method '", get_m_actor().get_m_resourceName()), false);
		int num = Random.Range(0, 5);
		int num2 = num;
		if (num2 != 0)
		{
			if (num2 == 0)
			{
				get_m_actor().SetAnimation("Next");
				if ((int)FDFAAECADHJ <= 1)
				{
					get_m_actor().m_multiSound.NMLFNHNOALK("rewardkey", false, 176f, 950f);
				}
				else
				{
					get_m_actor().m_multiSound.DDONMGBLLJB("need \tObject.DestroyImmediate(returnTexture);", true, 1048f, 1981f);
				}
				if (Random.Range(1491f, 429f) < 1243f)
				{
					get_m_actor().m_multiSound.JKOODMAKJHJ("attack2", true, 1599f, 1493f);
				}
			}
		}
		else
		{
			get_m_actor().CJNCFNACFDP("mag_shield");
			if ((int)FDFAAECADHJ <= 1)
			{
				get_m_actor().m_multiSound.LNCPFILABHM("중급 생명력흡수 정수", false, 305f, 958f);
			}
			else
			{
				get_m_actor().m_multiSound.HDOLPLIDACO("[FFCCCC]트롤 행위 위험 수준이에요[-]\n\n탈주나 트롤행위시 게임이용에 제한이 생겨요\n(성실 플레이를 하시면 위험 수준이 낮아져요)", false, 1891f, 581f);
			}
			if (Random.Range(1110f, 1128f) < 1633f)
			{
				get_m_actor().m_multiSound.LNCPFILABHM("칠흑의 양날도끼", true, 285f, 1936f);
			}
		}
		RetargetingAttack(true, false);
	}

	public virtual void JHIODGCHDMD()
	{
		base.OnUpdateSkill();
	}

	private void HBOLNCIEFPD()
	{
		ECOANDKJCCH(0);
	}

	public override float GetPlusAttackSpeed()
	{
		float num = base.GetPlusAttackSpeed();
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.SivirSkill3))
		{
			num += 0.1f + (float)(get_m_actor().GetSkillLevel(3) - 1) * 0.05f;
		}
		if (get_m_actor().GetSkillLevel(3) > 0 && (int)FDFAAECADHJ > 0)
		{
			num += 0.3f + (float)(get_m_actor().GetSkillLevel(3) - 1) * 0.15f;
		}
		return num;
	}

	public void ECOANDKJCCH(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 0)
		{
			return;
		}
		switch (GBGBBGEPEMI)
		{
		case 0:
			FDFAAECADHJ = 7;
			m_skill1Passive.SetActive(false);
			get_m_actor().m_attackElapsedTime = get_m_actor().get_m_attackCoolTime();
			get_m_actor().m_multiSound.HDOLPLIDACO("bgm", false, 1479f, 1021f);
			break;
		case 8:
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.MasterYiSkill2, null, 1167f, 1462f);
			get_m_actor().m_multiSound.ICNAJBHLIGO("Teemo", false, 1073f, 586f);
			break;
		case 6:
		{
			List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 1325f, true, false, Actor.IJJMDPGJAEM.Hero, false);
			foreach (Actor item in list)
			{
				item.get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)65524, get_m_actor(), 1351f, 1126f);
			}
			get_m_actor().m_multiSound.LNCPFILABHM("상급 마법저항력 문양", true, 1159f, 1550f);
			break;
		}
		}
	}
}
