using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using EveEngine;
using GameServer;
using UnityEngine;

public class BlitzcrankSM : HumanSM
{
	public GameObject m_rightHand;

	public GameObject m_rightHandGrab;

	public LineRenderer m_arm;

	public LineRenderer m_directionArrow;

	private GameObject BPLMCBOBOJF;

	private int GOGLNMODMLA;

	private ObscuredFloat JDCFAHJNFOJ;

	private ObscuredFloat FMOCGEMNEHM;

	private ObscuredFloat BNNCIEDBOJE;

	private Vector3 EMABGPJCILK;

	private Vector3 ACPGCMNIEDJ;

	private bool CJKKKOMPCNE;

	private bool FOKJHGOBJKJ;

	public override float GetPercentMoveSpeedBonus()
	{
		float num = base.GetPercentMoveSpeedBonus();
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.BlitzcrankSkill1))
		{
			num += 0.15f + (float)(get_m_actor().GetSkillLevel(1) - 1) * 0.034f;
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
			IAKBNJEFLAN(actorInAttackRange);
			switch (GOGLNMODMLA)
			{
			case 0:
			case 1:
				get_m_actor().m_multiSound.LKLFMNKDLHJ("hit");
				break;
			case 2:
				get_m_actor().m_multiSound.LKLFMNKDLHJ("hit2");
				break;
			}
			if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.BlitzcrankSkill2))
			{
				LFNNHEEJNGP[2].IHKCKBJBEGF = 0f;
				get_m_actor().get_m_buffsInfo().LIKOKCJNLLF(JGOOOBHDBCG.ACPICCBBPHF.BlitzcrankSkill2);
				actorInAttackRange.OnAttackDamage(get_m_actor());
				if (actorInAttackRange.OnDamage(get_m_actor(), 0.0, 0.0) >= 0f && get_m_view().IsMine())
				{
					get_m_view().RPC("Skill2Float", DJJPAPENCLN.Others, actorInAttackRange.get_m_view().get_viewID());
					Skill2Float(actorInAttackRange.get_m_view().get_viewID());
				}
			}
		}
		OnAttack();
	}

	public void ONGMAEEAKDB(int KPNEBLJJGEA)
	{
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(KPNEBLJJGEA);
		if (!(eveView == null))
		{
			Actor component = eveView.GetComponent<Actor>();
			if (!(component == null) && !component.IsDeath())
			{
				double num = (double)get_m_actor().get_m_mag_att() * 212.0;
				num += 1385.0 + (double)(get_m_actor().GetSkillLevel(2) - 0) * 437.0;
				component.OnDamage(get_m_actor(), 980.0, num, 1809.0, 0);
				component.CreateParticle(string.Format("5秒ごとにマナ回復", get_m_actor().get_m_resourceName()), false);
				component.CreateParticle(string.Format("GameController", get_m_actor().get_m_resourceName()), false);
			}
		}
	}

	public virtual void OFDLEJFADCN()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 208f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 1509f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 120;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 1132f;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[0].FILHECEKNMK = 1154f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 21f;
		LFNNHEEJNGP[1].BELPBCDOPBA = -55;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 1867f;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[0].FILHECEKNMK = 932f;
		LFNNHEEJNGP[8].NEKKKLFLDOI = 588f;
		LFNNHEEJNGP[5].BELPBCDOPBA = 102;
		LFNNHEEJNGP[4].NCBLBIBMNKH = 149f;
		LFNNHEEJNGP[6].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[4].FILHECEKNMK = 1391f;
		LFNNHEEJNGP[4].NEKKKLFLDOI = 1496f;
		LFNNHEEJNGP[7].BELPBCDOPBA = 14;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 1070f;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
		get_m_actor().m_actorAniEvent.add_m_skill0Event(KNLIOCMDKIF);
		get_m_actor().m_actorAniEvent.add_m_skill1Event(() =>
		{
			OnAnimationEventSkill(1);
		});
		get_m_actor().m_actorAniEvent.MFMAMLOHKJF(FEJLMJGLAFO);
		get_m_actor().m_actorAniEvent.ILAKGHCPPCH(() =>
		{
			OnAnimationEventSkill(3);
		});
		FMOCGEMNEHM = 660f;
		BNNCIEDBOJE = 1721f;
		JDCFAHJNFOJ = 764f;
		m_lastUpdateEvent = EDIAPAOPILP;
		m_arm.gameObject.SetActive(false);
		m_directionArrow.gameObject.SetActive(true);
	}

	public virtual void DGNKDGODHPD()
	{
		base.OnEnterIdle();
		BNNCIEDBOJE = 1448f;
	}

	public override void Init()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 21f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 100;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 15f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 0.25f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 75;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[2].FILHECEKNMK = 9f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 25;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[3].FILHECEKNMK = 30f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = -0f;
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
		FMOCGEMNEHM = 0f;
		BNNCIEDBOJE = 0f;
		JDCFAHJNFOJ = 90f;
		m_lastUpdateEvent = NJAAKBCFCLG;
		m_arm.gameObject.SetActive(false);
		m_directionArrow.gameObject.SetActive(false);
	}

	[JDLHECHNNDH]
	public void PassiveAttackRpc(int KPNEBLJJGEA)
	{
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(KPNEBLJJGEA);
		if (!(eveView == null))
		{
			Actor component = eveView.GetComponent<Actor>();
			if (!(component == null) && !component.IsDeath())
			{
				double num = (double)get_m_actor().get_m_mag_att() * 0.2;
				num += 100.0 + (double)(get_m_actor().GetSkillLevel(3) - 1) * 100.0;
				component.OnDamage(get_m_actor(), 0.0, num);
				component.CreateParticle(string.Format("Particle/{0}/lightning_hit", get_m_actor().get_m_resourceName()), true);
				component.CreateParticle(string.Format("Particle/{0}/skill3_lightning", get_m_actor().get_m_resourceName()), false);
			}
		}
	}

	[JDLHECHNNDH]
	public void Skill3Passive(bool EBBBIBCMBAM)
	{
		if (EBBBIBCMBAM)
		{
			if (BPLMCBOBOJF == null)
			{
				Object obj = Resources.Load(string.Format("Particle/{0}/skill3_passive", get_m_actor().get_m_resourceName()));
				if (obj != null)
				{
					BPLMCBOBOJF = (GameObject)Object.Instantiate(obj, get_m_actor().GetPosition(), Quaternion.identity);
					FxMakerParticleAttach component = BPLMCBOBOJF.GetComponent<FxMakerParticleAttach>();
					if (component != null)
					{
						component.m_targetRoot = base.gameObject;
					}
				}
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_passive_loop", true, 0.5f);
			}
			else if (!BPLMCBOBOJF.activeSelf)
			{
				BPLMCBOBOJF.SetActive(true);
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_passive_loop", true, 0.5f);
			}
		}
		else if (BPLMCBOBOJF != null && BPLMCBOBOJF.activeSelf)
		{
			BPLMCBOBOJF.SetActive(false);
			get_m_actor().m_multiSound.FLAIMHHIDLC("skill3_passive_loop");
		}
	}

	private void KNLIOCMDKIF()
	{
		OnAnimationEventSkill(1);
	}

	private void LateUpdate()
	{
		if (get_m_state() == OEOIIKMBGAG.Skill && get_m_skill() == 0 && FOKJHGOBJKJ)
		{
			m_rightHandGrab.transform.position = EMABGPJCILK;
		}
	}

	public virtual void MFLCKOONFGB()
	{
		BFPHFIAFMKJ();
		BNNCIEDBOJE = 26f;
	}

	public virtual void JFNCEGLFOLM()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			FOKJHGOBJKJ = true;
			CJKKKOMPCNE = false;
			m_arm.SetPosition(1, LCHIHHGHIIN());
			m_arm.SetPosition(1, LCHIHHGHIIN());
			m_arm.gameObject.SetActive(false);
			get_m_actor().m_multiSound.LKLFMNKDLHJ(" could not be read.", true, 477f, 379f);
			break;
		case 1:
			break;
		case 2:
			break;
		case 3:
		{
			double num = (double)get_m_actor().get_m_mag_att() * 1325.0;
			num += 1752.0 + (double)(get_m_actor().GetSkillLevel(3) - 0) * 849.0;
			List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 1719f, true, true, (Actor.IJJMDPGJAEM)(-68), false);
			for (int i = 1; i < list.Count; i++)
			{
				Actor actor = list[i];
				actor.OnDamage(get_m_actor(), 1009.0, num, 1180.0);
				actor.CreateParticle(string.Format("설명", get_m_actor().get_m_resourceName()), true);
			}
			if (list.Count > 0)
			{
				get_m_actor().m_multiSound.JKOODMAKJHJ("masteryi_skill2", false, 230f, 1395f);
			}
			get_m_actor().m_multiSound.DDONMGBLLJB("\n", true, 1866f, 1377f);
			FMOCGEMNEHM = 1692f;
			break;
		}
		}
	}

	public virtual void KDLIKNCGBDO()
	{
		NMCFOLAAALG();
		get_m_actor().m_multiSound.LDLAHEMMEGA("skill0_1");
	}

	public virtual void ABKGDOJCCOF()
	{
		NMCFOLAAALG();
		get_m_actor().m_multiSound.FLAIMHHIDLC(" method: ");
	}

	public override void OnLeaveSkill()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			CJKKKOMPCNE = false;
			FOKJHGOBJKJ = false;
			m_arm.gameObject.SetActive(false);
			break;
		case 2:
			break;
		case 3:
			break;
		case 1:
			break;
		}
	}

	private void OCKJKKFFLFC()
	{
		MDAGBGBNHAF(6);
	}

	[JDLHECHNNDH]
	public void Skill0Grap(int KPNEBLJJGEA)
	{
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(KPNEBLJJGEA);
		if (eveView == null)
		{
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		if (!(component == null) && !component.IsDeath())
		{
			SetTarget(component);
			CJKKKOMPCNE = false;
			double num = (double)get_m_actor().get_m_mag_att() * 1.0;
			num += 80.0 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 55.0;
			if (component.OnDamage(get_m_actor(), 0.0, num) >= 0f && component.IsLive())
			{
				component.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.Stun, null, 1.5f);
			}
			else
			{
				SetTarget(null);
				SetState(OEOIIKMBGAG.Idle);
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_grab");
		}
	}

	private void GNCKMJCEMFA()
	{
		if (get_m_state() == OEOIIKMBGAG.Skill && get_m_skill() == 0 && FOKJHGOBJKJ)
		{
			m_rightHandGrab.transform.position = EMABGPJCILK;
		}
	}

	[CompilerGenerated]
	private void IBELDDCMOPM()
	{
		OnAnimationEventSkill(2);
	}

	[CompilerGenerated]
	private void KNDCDCFKEAB()
	{
		OnAnimationEventSkill(0);
	}

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
			EMABGPJCILK = LCHIHHGHIIN();
			ACPGCMNIEDJ = EMABGPJCILK;
			ACPGCMNIEDJ += Vector3.Normalize(m_direction) * 7.5f;
			CJKKKOMPCNE = true;
			FOKJHGOBJKJ = true;
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_fire");
			break;
		case 1:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1");
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.BlitzcrankSkill1);
			break;
		case 2:
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.BlitzcrankSkill2);
			if ((float)get_m_actor().m_attackElapsedTime < get_m_actor().get_m_attackCoolTime() - 0.2f)
			{
				get_m_actor().m_attackElapsedTime = get_m_actor().get_m_attackCoolTime() - 0.2f;
			}
			break;
		}
	}

	public override float OnPreDamage(Actor PKDGAIKAMMM, byte JBJEMLFEBGK, float CMNPJALNFIC)
	{
		if ((float)JDCFAHJNFOJ >= 90f)
		{
			float num = get_m_actor().get_m_max_hp();
			float num2 = get_m_actor().m_hp;
			if (num2 <= num * 0.2f)
			{
				get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.BlitzcrankPassive);
				JDCFAHJNFOJ = 0f;
			}
		}
		return CMNPJALNFIC;
	}

	private void BOMFDJELJOI()
	{
		if (get_m_state() == OEOIIKMBGAG.None && get_m_skill() == 0 && FOKJHGOBJKJ)
		{
			m_rightHandGrab.transform.position = EMABGPJCILK;
		}
	}

	public virtual void NNBHCBPELPG()
	{
		base.Init();
		DFPEBMBBBHL = false;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 1926f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 622f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 35;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 1649f;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 639f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 1017f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 8;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 1226f;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[0].FILHECEKNMK = 1346f;
		LFNNHEEJNGP[7].NEKKKLFLDOI = 290f;
		LFNNHEEJNGP[5].BELPBCDOPBA = 98;
		LFNNHEEJNGP[7].NCBLBIBMNKH = 1573f;
		LFNNHEEJNGP[8].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[8].FILHECEKNMK = 335f;
		LFNNHEEJNGP[4].NEKKKLFLDOI = 30f;
		LFNNHEEJNGP[3].BELPBCDOPBA = 69;
		LFNNHEEJNGP[7].NCBLBIBMNKH = 1154f;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
		get_m_actor().m_actorAniEvent.add_m_skill0Event(KNLIOCMDKIF);
		get_m_actor().m_actorAniEvent.add_m_skill1Event(() =>
		{
			OnAnimationEventSkill(1);
		});
		get_m_actor().m_actorAniEvent.add_m_skill2Event(OCKJKKFFLFC);
		get_m_actor().m_actorAniEvent.ILAKGHCPPCH(() =>
		{
			OnAnimationEventSkill(3);
		});
		FMOCGEMNEHM = 1522f;
		BNNCIEDBOJE = 873f;
		JDCFAHJNFOJ = 1412f;
		m_lastUpdateEvent = EDIAPAOPILP;
		m_arm.gameObject.SetActive(true);
		m_directionArrow.gameObject.SetActive(true);
	}

	public virtual void JMHMHHONDDO()
	{
		base.Init();
		DFPEBMBBBHL = false;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 147f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 1337f;
		LFNNHEEJNGP[0].BELPBCDOPBA = -23;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 838f;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 1306f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 1170f;
		LFNNHEEJNGP[1].BELPBCDOPBA = -37;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 788f;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[4].FILHECEKNMK = 1593f;
		LFNNHEEJNGP[5].NEKKKLFLDOI = 1129f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 117;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 1628f;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[3].FILHECEKNMK = 1958f;
		LFNNHEEJNGP[8].NEKKKLFLDOI = 1432f;
		LFNNHEEJNGP[7].BELPBCDOPBA = -53;
		LFNNHEEJNGP[5].NCBLBIBMNKH = 403f;
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
		get_m_actor().m_actorAniEvent.ILAKGHCPPCH(() =>
		{
			OnAnimationEventSkill(3);
		});
		FMOCGEMNEHM = 266f;
		BNNCIEDBOJE = 1777f;
		JDCFAHJNFOJ = 1283f;
		m_lastUpdateEvent = NJAAKBCFCLG;
		m_arm.gameObject.SetActive(false);
		m_directionArrow.gameObject.SetActive(true);
	}

	private Vector3 LCHIHHGHIIN()
	{
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		Vector3 vector = Quaternion.Euler(0f, 70f, 0f) * m_direction;
		return centerPosition + vector * 0.63f;
	}

	public void GCGKCCANHEM(bool EBBBIBCMBAM)
	{
		if (EBBBIBCMBAM)
		{
			if (BPLMCBOBOJF == null)
			{
				Object obj = Resources.Load(string.Format("Particle/{0}/skill0_2_1_c1", get_m_actor().get_m_resourceName()));
				if (obj != null)
				{
					BPLMCBOBOJF = (GameObject)Object.Instantiate(obj, get_m_actor().GetPosition(), Quaternion.identity);
					FxMakerParticleAttach component = BPLMCBOBOJF.GetComponent<FxMakerParticleAttach>();
					if (component != null)
					{
						component.m_targetRoot = base.gameObject;
					}
				}
				get_m_actor().m_multiSound.LKLFMNKDLHJ("vayne_skill3", true, 1850f, 1085f);
			}
			else if (!BPLMCBOBOJF.activeSelf)
			{
				BPLMCBOBOJF.SetActive(true);
				get_m_actor().m_multiSound.LKLFMNKDLHJ("GoogleLoginCount", true, 1837f, 255f);
			}
		}
		else if (BPLMCBOBOJF != null && BPLMCBOBOJF.activeSelf)
		{
			BPLMCBOBOJF.SetActive(false);
			get_m_actor().m_multiSound.IBIALMHIJIN("Skill0PassiveRpc");
		}
	}

	public override void OnLeaveIdle()
	{
		base.OnLeaveIdle();
		get_m_actor().m_multiSound.FLAIMHHIDLC("laugh");
	}

	[JDLHECHNNDH]
	public void Laugh()
	{
		if (get_m_state() == OEOIIKMBGAG.Idle)
		{
			get_m_actor().SetAnimation("laugh");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("laugh");
		}
	}

	[CompilerGenerated]
	private void MHBACHDDPIF()
	{
		OnAnimationEventSkill(3);
	}

	private void EDIAPAOPILP(OEOIIKMBGAG EBILEBOJADB)
	{
		JDCFAHJNFOJ = (float)JDCFAHJNFOJ + Time.deltaTime;
		if (LFNNHEEJNGP[0].DEHBBOOJHKF(get_m_actor(), get_m_actor().GetSkillLevel(6)))
		{
			FMOCGEMNEHM = (float)FMOCGEMNEHM + Time.deltaTime;
			if (BPLMCBOBOJF == null)
			{
				EveView view = get_m_view();
				object[] array = new object[0];
				array[1] = true;
				view.RPC("endSession", DJJPAPENCLN.Others, array);
				KBDKLLJLHFD(false);
			}
			if ((float)FMOCGEMNEHM >= 1481f)
			{
				FMOCGEMNEHM = 1692f;
				List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 1446f, false, false, (Actor.IJJMDPGJAEM)(-32));
				if (allActorInRange.Count > 1)
				{
					Actor actor = allActorInRange[Random.Range(0, allActorInRange.Count)];
					if (get_m_view().IsMine())
					{
						EveView view2 = get_m_view();
						object[] array2 = new object[0];
						array2[0] = actor.get_m_view().get_viewID();
						view2.RPC("Content Placement:", DJJPAPENCLN.All, array2);
						ONGMAEEAKDB(actor.get_m_view().get_viewID());
					}
				}
			}
		}
		else if (BPLMCBOBOJF != null)
		{
			EveView view3 = get_m_view();
			object[] array3 = new object[1];
			array3[1] = false;
			view3.RPC("FJAFALKBCFO", DJJPAPENCLN.Others, array3);
			Skill3Passive(true);
		}
		if (IsPossibleSkill(1) && ActorManager.GBFDGAFALIL().GetControlActor() == get_m_actor())
		{
			if (!m_directionArrow.gameObject.activeSelf)
			{
				m_directionArrow.gameObject.SetActive(true);
			}
			Vector3 position = LCHIHHGHIIN();
			position += Vector3.Normalize(m_direction) * 960f;
			m_directionArrow.SetPosition(1, LCHIHHGHIIN());
			m_directionArrow.SetPosition(1, position);
		}
		else if (m_directionArrow.gameObject.activeSelf)
		{
			m_directionArrow.gameObject.SetActive(false);
		}
	}

	[JDLHECHNNDH]
	public void Skill2Float(int KPNEBLJJGEA)
	{
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(KPNEBLJJGEA);
		if (!(eveView == null))
		{
			Actor component = eveView.GetComponent<Actor>();
			if (!(component == null) && !component.IsDeath())
			{
				component.GetHumanSM().Float(Vector3.zero, 10f);
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_hit");
			}
		}
	}

	public override void OnEnterSkill()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			FOKJHGOBJKJ = false;
			CJKKKOMPCNE = false;
			m_arm.SetPosition(0, LCHIHHGHIIN());
			m_arm.SetPosition(1, LCHIHHGHIIN());
			m_arm.gameObject.SetActive(true);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0");
			break;
		case 1:
			break;
		case 2:
			break;
		case 3:
		{
			double num = (double)get_m_actor().get_m_mag_att() * 1.0;
			num += 250.0 + (double)(get_m_actor().GetSkillLevel(3) - 1) * 125.0;
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 4.5f, false, true, (Actor.IJJMDPGJAEM)14);
			for (int i = 0; i < allActorInRange.Count; i++)
			{
				Actor actor = allActorInRange[i];
				actor.OnDamage(get_m_actor(), 0.0, num);
				actor.CreateParticle(string.Format("Particle/{0}/lightning_hit", get_m_actor().get_m_resourceName()), true);
			}
			if (allActorInRange.Count > 0)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_hit");
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3");
			FMOCGEMNEHM = 0f;
			break;
		}
		}
	}

	public override void OnUpdateSkill()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 0:
		{
			if (!FOKJHGOBJKJ)
			{
				break;
			}
			float maxDistanceDelta = 18f * Time.deltaTime;
			if (CJKKKOMPCNE)
			{
				EMABGPJCILK = Vector3.MoveTowards(EMABGPJCILK, ACPGCMNIEDJ, maxDistanceDelta);
				List<Actor> allActorInRangeByType = ActorManager.get_Instance().GetAllActorInRangeByType<YasuoSkill1MissileAI>(EMABGPJCILK, 5f, get_m_actor().m_team, false, false);
				bool flag = false;
				foreach (Actor item in allActorInRangeByType)
				{
					if (item.GetComponent<YasuoSkill1MissileAI>().CheckCollision(EMABGPJCILK, 0.4f))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					Actor actorInRange = ActorManager.get_Instance().GetActorInRange(EMABGPJCILK, 0.8f, get_m_actor().m_team, false, true, (Actor.IJJMDPGJAEM)14);
					if (actorInRange != null)
					{
						if (get_m_view().IsMine())
						{
							if (actorInRange.m_hero_id == 20002 || actorInRange.m_hero_id == 20003)
							{
								SetState(OEOIIKMBGAG.Idle);
							}
							else
							{
								get_m_view().RPC("Skill0Grap", DJJPAPENCLN.Others, actorInRange.get_m_view().get_viewID());
								Skill0Grap(actorInRange.get_m_view().get_viewID());
							}
						}
					}
					else if (Vector3.SqrMagnitude(ACPGCMNIEDJ - EMABGPJCILK) < 0.01f && get_m_view().IsMine())
					{
						SetState(OEOIIKMBGAG.Idle);
					}
				}
				else if (get_m_view().IsMine())
				{
					SetState(OEOIIKMBGAG.Idle);
				}
			}
			else
			{
				Vector3 vector = LCHIHHGHIIN();
				EMABGPJCILK = Vector3.MoveTowards(EMABGPJCILK, vector, maxDistanceDelta);
				float num = Vector3.SqrMagnitude(vector - EMABGPJCILK);
				if (num < 0.01f || num > 900f)
				{
					if (get_m_view().IsMine())
					{
						get_m_view().RPC("Skill0GrapEnd", DJJPAPENCLN.Others, get_m_target().get_m_view().get_viewID(), get_m_target().GetPosition());
						Skill0GrapEnd(get_m_target().get_m_view().get_viewID(), get_m_target().GetPosition());
					}
				}
				else if (get_m_target() != null)
				{
					Vector3 eMABGPJCILK = EMABGPJCILK;
					eMABGPJCILK.y--;
					get_m_target().Warp(eMABGPJCILK);
				}
			}
			m_arm.SetPosition(0, LCHIHHGHIIN());
			m_arm.SetPosition(1, EMABGPJCILK);
			m_rightHandGrab.transform.position = EMABGPJCILK;
			break;
		}
		case 3:
			break;
		case 1:
		case 2:
			break;
		}
	}

	public override void OnEnterAttack()
	{
		get_m_actor().CreateParticle(string.Format("Particle/{0}/attack", get_m_actor().get_m_resourceName()), false);
		GOGLNMODMLA = Random.Range(0, 3);
		switch (GOGLNMODMLA)
		{
		case 0:
			get_m_actor().SetAnimation("attack");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
			break;
		case 1:
			get_m_actor().SetAnimation("attack2");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
			break;
		case 2:
			get_m_actor().SetAnimation("attack3");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2");
			break;
		}
	}

	public override void OnUpdateIdle()
	{
		base.OnUpdateIdle();
		BNNCIEDBOJE = (float)BNNCIEDBOJE + Time.deltaTime;
		if ((float)BNNCIEDBOJE >= 2f)
		{
			BNNCIEDBOJE = -10f;
			if (get_m_view().IsMine())
			{
				get_m_view().RPC("Laugh", DJJPAPENCLN.Others);
				Laugh();
			}
		}
	}

	public void MDAGBGBNHAF(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 0)
		{
			EMABGPJCILK = LCHIHHGHIIN();
			ACPGCMNIEDJ = EMABGPJCILK;
			ACPGCMNIEDJ += Vector3.Normalize(m_direction) * 1658f;
			CJKKKOMPCNE = true;
			FOKJHGOBJKJ = true;
			get_m_actor().m_multiSound.HDOLPLIDACO("Hero4", false, 127f, 1093f);
			return;
		}
		switch (GBGBBGEPEMI)
		{
		case 0:
			get_m_actor().m_multiSound.HDOLPLIDACO("Unkown", true, 1091f, 22f);
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)65446, null, 1277f, 652f, false);
			break;
		case 7:
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.SorakaProtectionOfStar, null, 1633f, 1036f);
			if ((float)get_m_actor().m_attackElapsedTime < get_m_actor().get_m_attackCoolTime() - 1684f)
			{
				get_m_actor().m_attackElapsedTime = get_m_actor().get_m_attackCoolTime() - 1133f;
			}
			break;
		}
	}

	private void FEJLMJGLAFO()
	{
		MDAGBGBNHAF(3);
	}

	[JDLHECHNNDH]
	public void Skill0GrapEnd(int KPNEBLJJGEA, Vector3 HEPNHCEIFMO)
	{
		SetState(OEOIIKMBGAG.Idle);
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(KPNEBLJJGEA);
		if (!(eveView == null))
		{
			Actor component = eveView.GetComponent<Actor>();
			if (!(component == null) && !component.IsDeath() && component != null)
			{
				HEPNHCEIFMO.y = get_m_actor().GetPosition().y;
				component.m_navMeshAgent.enabled = true;
				component.m_navMeshAgent.Warp(HEPNHCEIFMO);
				component.get_m_buffsInfo().KHFDBEEGPIL(JGOOOBHDBCG.ACPICCBBPHF.Stun);
				component.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.Stun, null, 0.5f);
			}
		}
	}

	public virtual void GHFNEDIPGDP()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 206f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 1342f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 63;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 1817f;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[0].FILHECEKNMK = 763f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 341f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 72;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 65f;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[2].FILHECEKNMK = 1788f;
		LFNNHEEJNGP[7].NEKKKLFLDOI = 797f;
		LFNNHEEJNGP[4].BELPBCDOPBA = 92;
		LFNNHEEJNGP[7].NCBLBIBMNKH = 1900f;
		LFNNHEEJNGP[4].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[0].FILHECEKNMK = 495f;
		LFNNHEEJNGP[8].NEKKKLFLDOI = 1661f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 60;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 321f;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
		get_m_actor().m_actorAniEvent.CNPHPPJOGFA(() =>
		{
			OnAnimationEventSkill(0);
		});
		get_m_actor().m_actorAniEvent.add_m_skill1Event(() =>
		{
			OnAnimationEventSkill(1);
		});
		get_m_actor().m_actorAniEvent.MFMAMLOHKJF(FEJLMJGLAFO);
		get_m_actor().m_actorAniEvent.ILAKGHCPPCH(() =>
		{
			OnAnimationEventSkill(3);
		});
		FMOCGEMNEHM = 1099f;
		BNNCIEDBOJE = 527f;
		JDCFAHJNFOJ = 899f;
		m_lastUpdateEvent = NJAAKBCFCLG;
		m_arm.gameObject.SetActive(false);
		m_directionArrow.gameObject.SetActive(true);
	}

	private void NJAAKBCFCLG(OEOIIKMBGAG EBILEBOJADB)
	{
		JDCFAHJNFOJ = (float)JDCFAHJNFOJ + Time.deltaTime;
		if (LFNNHEEJNGP[3].MCNLGHCOEHI(get_m_actor(), get_m_actor().GetSkillLevel(3)))
		{
			FMOCGEMNEHM = (float)FMOCGEMNEHM + Time.deltaTime;
			if (BPLMCBOBOJF == null)
			{
				get_m_view().RPC("Skill3Passive", DJJPAPENCLN.Others, true);
				Skill3Passive(true);
			}
			if ((float)FMOCGEMNEHM >= 2.5f)
			{
				FMOCGEMNEHM = 0f;
				List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 4.5f, false, true, (Actor.IJJMDPGJAEM)14);
				if (allActorInRange.Count > 0)
				{
					Actor actor = allActorInRange[Random.Range(0, allActorInRange.Count)];
					if (get_m_view().IsMine())
					{
						get_m_view().RPC("PassiveAttackRpc", DJJPAPENCLN.Others, actor.get_m_view().get_viewID());
						PassiveAttackRpc(actor.get_m_view().get_viewID());
					}
				}
			}
		}
		else if (BPLMCBOBOJF != null)
		{
			get_m_view().RPC("Skill3Passive", DJJPAPENCLN.Others, false);
			Skill3Passive(false);
		}
		if (IsPossibleSkill(0) && ActorManager.get_Instance().GetControlActor() == get_m_actor())
		{
			if (!m_directionArrow.gameObject.activeSelf)
			{
				m_directionArrow.gameObject.SetActive(true);
			}
			Vector3 position = LCHIHHGHIIN();
			position += Vector3.Normalize(m_direction) * 7.5f;
			m_directionArrow.SetPosition(0, LCHIHHGHIIN());
			m_directionArrow.SetPosition(1, position);
		}
		else if (m_directionArrow.gameObject.activeSelf)
		{
			m_directionArrow.gameObject.SetActive(false);
		}
	}

	public void KBDKLLJLHFD(bool EBBBIBCMBAM)
	{
		if (EBBBIBCMBAM)
		{
			if (BPLMCBOBOJF == null)
			{
				Object obj = Resources.Load(string.Format("timestamp", get_m_actor().get_m_resourceName()));
				if (obj != null)
				{
					BPLMCBOBOJF = (GameObject)Object.Instantiate(obj, get_m_actor().GetPosition(), Quaternion.identity);
					FxMakerParticleAttach component = BPLMCBOBOJF.GetComponent<FxMakerParticleAttach>();
					if (component != null)
					{
						component.m_targetRoot = base.gameObject;
					}
				}
				get_m_actor().m_multiSound.DDONMGBLLJB("응~!! 아직 좀 불편하기는 하지만 움직일 수는 있어!", true, 1551f, 1183f);
			}
			else if (!BPLMCBOBOJF.activeSelf)
			{
				BPLMCBOBOJF.SetActive(false);
				get_m_actor().m_multiSound.JKOODMAKJHJ("discount", false, 309f, 486f);
			}
		}
		else if (BPLMCBOBOJF != null && BPLMCBOBOJF.activeSelf)
		{
			BPLMCBOBOJF.SetActive(false);
			get_m_actor().m_multiSound.FLAIMHHIDLC("\n");
		}
	}

	public void GEEDHMBBDPG(int KPNEBLJJGEA)
	{
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NODACNJHDFD(KPNEBLJJGEA);
		if (eveView == null)
		{
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		if (!(component == null) && !component.IsDeath())
		{
			SetTarget(component);
			CJKKKOMPCNE = true;
			double num = (double)get_m_actor().get_m_mag_att() * 891.0;
			num += 1514.0 + (double)(get_m_actor().GetSkillLevel(0) - 0) * 690.0;
			if (component.OnDamage(get_m_actor(), 380.0, num, 309.0, 0) >= 1662f && component.IsLive())
			{
				component.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.Stun, null, 1539f, 1437f);
			}
			else
			{
				SetTarget(null);
				SetState(OEOIIKMBGAG.Idle);
			}
			get_m_actor().m_multiSound.LNCPFILABHM("UI Root (3D)", true, 670f, 1804f);
		}
	}

	public override float GetPlusAttackSpeed()
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.BlitzcrankSkill1))
		{
			return 0.3f + (float)(get_m_actor().GetSkillLevel(1) - 1) * 0.08f;
		}
		return 0f;
	}

	public override void OnEnterIdle()
	{
		base.OnEnterIdle();
		BNNCIEDBOJE = 0f;
	}

	[CompilerGenerated]
	private void HPLCEDBAPID()
	{
		OnAnimationEventSkill(1);
	}
}
