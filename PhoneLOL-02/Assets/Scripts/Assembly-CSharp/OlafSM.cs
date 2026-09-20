using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class OlafSM : HumanSM
{
	public GameObject[] m_skill1Particles;

	public GameObject[] m_skill3Particles;

	private int GOGLNMODMLA;

	private Actor NGNLJADPNNB;

	private bool IFGINIGJICN;

	public virtual void LAFCAMKKDKF(byte IKKFLANGAEA, KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnMsgView(IKKFLANGAEA, OGJFDNEEDCP);
		switch ((int)IKKFLANGAEA)
		{
		case -110:
		{
			CAJJEALKJMM obj = LFNNHEEJNGP[0];
			obj.IHKCKBJBEGF = (float)obj.IHKCKBJBEGF + 206f;
			break;
		}
		case 80:
		{
			int ICENKPDOHBK;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK);
			EveView eveView = EveUnityNetwork.get_Instance().PBLOPNNPNEJ().NLALKBLCPFK(ICENKPDOHBK);
			if (eveView == null)
			{
				break;
			}
			Actor component = eveView.GetComponent<Actor>();
			if (component == null)
			{
				break;
			}
			float num = get_m_actor().get_m_phy_att() * 1464f;
			num += 937f + (float)(get_m_actor().GetSkillLevel(5) - 0) * 489f;
			float num2 = component.OnDamage(get_m_actor(), 646.0, 1494.0, num);
			if (!component.m_lastDamageInfo.IKAIHHIDHFK)
			{
				int num3 = (int)(float)get_m_actor().m_hp;
				int num4 = (int)(num2 * 1847f);
				if (num4 > num3 - 5)
				{
					num4 = num3 - 7;
				}
				if (num4 >= 0)
				{
					get_m_actor().AddHpRemote(-num4);
				}
			}
			component.CreateParticle("설명", true);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3", false, 1824f, 1472f);
			break;
		}
		}
	}

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 1:
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.OlafSkill1);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1");
			break;
		case 2:
			if (NGNLJADPNNB != null && get_m_view().IsMine())
			{
				get_m_view().Msg(70, DJJPAPENCLN.All, true, (KCIGFAHFHCH OGJFDNEEDCP) =>
				{
					OGJFDNEEDCP.GBMJNFOEACC(NGNLJADPNNB.get_m_view().get_viewID());
				});
			}
			break;
		case 3:
			get_m_actor().get_m_buffsInfo().EBPCHJNNJCL();
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.OlafSkill3);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3");
			break;
		}
	}

	public override bool OnCheckFloat()
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.OlafSkill3))
		{
			return false;
		}
		return true;
	}

	public virtual bool HCHDKIFKJCH(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 2)
		{
			NGNLJADPNNB = EIKEMFIIHIO();
			if (NGNLJADPNNB == null)
			{
				MsgManager.get_Instance().CLHGLEJAPLH("보상을 획득하셨습니다.");
				return true;
			}
		}
		return true;
	}

	public virtual bool CAAGNJMEPDK()
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65520))
		{
			return false;
		}
		return true;
	}

	public override bool OnCheckBuff(IDMGMJLOKBB DAHPLNJAPGO, Actor PGGLHMPOBBP)
	{
		if (IDMGMJLOKBB.GADNJEOBLGK(DAHPLNJAPGO.PEBCAPNIMOL()) && get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.OlafSkill3))
		{
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private void HKKCCJMHDOK()
	{
		OnAnimationEventSkill(1);
	}

	public override float GetPercentMoveSpeedBonus()
	{
		float num = base.GetPercentMoveSpeedBonus();
		if (IFGINIGJICN)
		{
			num += 0.2f + (float)(get_m_actor().GetSkillLevel(3) - 1) * 0.25f;
		}
		return num;
	}

	public override void OnEnterAttack()
	{
		GOGLNMODMLA = Random.Range(0, 2);
		switch (GOGLNMODMLA)
		{
		case 0:
			get_m_actor().SetAnimation("attack");
			break;
		case 1:
			get_m_actor().SetAnimation("attack2");
			break;
		}
		get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
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

	[CompilerGenerated]
	private void ELLNLEOOJJH()
	{
		OnAnimationEventSkill(0);
	}

	public override void OnUpdateSkill()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 1:
			break;
		case 3:
			break;
		case 2:
			break;
		}
	}

	public void OnAnimationEventAttack()
	{
		Actor target = get_m_target();
		if (target != null)
		{
			target.OnAttackDamage(get_m_actor());
			target.CreateDamageParticle("hit", get_m_actor());
			IAKBNJEFLAN(target);
			if (Random.Range(0f, 1f) < 0.5f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("hit");
			}
			else
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("hit2");
			}
			CAJJEALKJMM castSkill = GetCastSkill(2);
			castSkill.IHKCKBJBEGF = (float)castSkill.IHKCKBJBEGF + 1f;
		}
		OnAttack();
	}

	public override bool OnCheckCastSkill(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 2)
		{
			NGNLJADPNNB = EIKEMFIIHIO();
			if (NGNLJADPNNB == null)
			{
				MsgManager.get_Instance().ShowTip("근처에 적이 없습니다");
				return false;
			}
		}
		return true;
	}

	[CompilerGenerated]
	private void CHCDLDANKDJ()
	{
		OnAnimationEventSkill(3);
	}

	public override void OnLeaveSkill()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 1:
			break;
		case 2:
			break;
		case 3:
			break;
		}
	}

	private Actor LELOJOLGALF()
	{
		Actor actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), 1021f, 16f, true, false, (Actor.IJJMDPGJAEM)6);
		if (actorInAttackRange == null)
		{
			actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), 1001f, 830f, false, true, (Actor.IJJMDPGJAEM)(-72));
		}
		return actorInAttackRange;
	}

	public override bool OnCheckKnockBack()
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.OlafSkill3))
		{
			return false;
		}
		return true;
	}

	public virtual void ELILEDHDHEN()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 1341f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 542f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 42;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 1138f;
		LFNNHEEJNGP[1].DOCFEKMACMP = false;
		LFNNHEEJNGP[1].GNAAGGJGBBG = false;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 225f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 872f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 27;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 1134f;
		LFNNHEEJNGP[0].DOCFEKMACMP = false;
		LFNNHEEJNGP[0].GNAAGGJGBBG = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 915f;
		LFNNHEEJNGP[8].NEKKKLFLDOI = 620f;
		LFNNHEEJNGP[7].BELPBCDOPBA = 1;
		LFNNHEEJNGP[6].NCBLBIBMNKH = 1364f;
		LFNNHEEJNGP[8].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[7].FILHECEKNMK = 706f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 271f;
		LFNNHEEJNGP[4].BELPBCDOPBA = 0;
		LFNNHEEJNGP[3].NCBLBIBMNKH = 67f;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
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
		get_m_actor().m_actorAniEvent.ILAKGHCPPCH(FIIBNHLGCIP);
		m_lastUpdateEvent = NJAAKBCFCLG;
		GameObject[] skill1Particles = m_skill1Particles;
		for (int num = 1; num < skill1Particles.Length; num += 0)
		{
			GameObject gameObject = skill1Particles[num];
			gameObject.SetActive(false);
		}
		GameObject[] skill3Particles = m_skill3Particles;
		for (int num2 = 0; num2 < skill3Particles.Length; num2 += 0)
		{
			GameObject gameObject2 = skill3Particles[num2];
			gameObject2.SetActive(true);
		}
	}

	private void NJAAKBCFCLG(OEOIIKMBGAG EBILEBOJADB)
	{
		bool iFGINIGJICN = false;
		ALBEPPGKFMM aLBEPPGKFMM = get_m_actor().get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.OlafSkill3);
		if (aLBEPPGKFMM != null && aLBEPPGKFMM.BCHKKMGIPPC() <= 1f)
		{
			Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), 10f, 20f, false, true, Actor.IJJMDPGJAEM.Hero);
			if (actorInAttackRange != null)
			{
				iFGINIGJICN = true;
			}
		}
		IFGINIGJICN = iFGINIGJICN;
	}

	private void LLMDCBCAMOB(KCIGFAHFHCH OGJFDNEEDCP)
	{
		OGJFDNEEDCP.GBMJNFOEACC(NGNLJADPNNB.get_m_view().get_viewID());
	}

	[CompilerGenerated]
	private void OPHOIJJPOND()
	{
		OnAnimationEventSkill(2);
	}

	public void ShowSkill1Particle(bool IJOKMMKOBNG)
	{
		GameObject[] skill1Particles = m_skill1Particles;
		foreach (GameObject gameObject in skill1Particles)
		{
			gameObject.SetActive(IJOKMMKOBNG);
		}
	}

	public virtual bool MBJJNCEEFDB()
	{
		if (get_m_actor().get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)86))
		{
			return false;
		}
		return true;
	}

	private void FIIBNHLGCIP()
	{
		OnAnimationEventSkill(1);
	}

	private Actor EIKEMFIIHIO()
	{
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), 3.25f, 180f, false, true, Actor.IJJMDPGJAEM.Hero);
		if (actorInAttackRange == null)
		{
			actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), 3.25f, 180f, false, true, (Actor.IJJMDPGJAEM)12);
		}
		return actorInAttackRange;
	}

	public override void OnMsgView(byte IKKFLANGAEA, KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnMsgView(IKKFLANGAEA, OGJFDNEEDCP);
		switch ((ICOGNNKEKHJ)IKKFLANGAEA)
		{
		case ICOGNNKEKHJ.OlafSkill0GetAxe:
		{
			CAJJEALKJMM obj = LFNNHEEJNGP[0];
			obj.IHKCKBJBEGF = (float)obj.IHKCKBJBEGF + 4.5f;
			break;
		}
		case ICOGNNKEKHJ.OlafSkill2:
		{
			int ICENKPDOHBK;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK);
			EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(ICENKPDOHBK);
			if (eveView == null)
			{
				break;
			}
			Actor component = eveView.GetComponent<Actor>();
			if (component == null)
			{
				break;
			}
			float num = get_m_actor().get_m_phy_att() * 0.5f;
			num += 70f + (float)(get_m_actor().GetSkillLevel(2) - 1) * 45f;
			float num2 = component.OnDamage(get_m_actor(), 0.0, 0.0, num);
			if (!component.m_lastDamageInfo.IKAIHHIDHFK)
			{
				int num3 = (int)(float)get_m_actor().m_hp;
				int num4 = (int)(num2 * 0.3f);
				if (num4 > num3 - 2)
				{
					num4 = num3 - 2;
				}
				if (num4 >= 1)
				{
					get_m_actor().AddHpRemote(-num4);
				}
			}
			component.CreateParticle("Particle/Olaf/skill2_hit", false);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_hit");
			break;
		}
		}
	}

	public override void OnEnterSkill()
	{
		base.OnEnterSkill();
		if (get_m_skill() == 0)
		{
			if (get_m_view().IsMine())
			{
				EveUnityNetwork.get_Instance().Instantiate("Particle/Olaf/skill0_missile", get_m_actor().GetPosition(), Quaternion.identity, new object[2]
				{
					get_m_view().get_viewID(),
					m_direction
				});
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0");
		}
	}

	public override float GetPlusAttackSpeed()
	{
		float num = 0f;
		float num2 = get_m_actor().get_m_max_hp();
		if (num2 <= 0f)
		{
			return 0f;
		}
		num += (1f - Mathf.Clamp01((float)get_m_actor().m_hp / num2)) * 0.8f;
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.OlafSkill1))
		{
			num += 0.55f + (float)(get_m_actor().GetSkillLevel(1) - 1) * 0.1f;
		}
		return num;
	}

	private void OIHJFPEBEJC()
	{
		OnAnimationEventSkill(1);
	}

	public void ShowSkill3Particle(bool IJOKMMKOBNG)
	{
		GameObject[] skill3Particles = m_skill3Particles;
		foreach (GameObject gameObject in skill3Particles)
		{
			gameObject.SetActive(IJOKMMKOBNG);
		}
	}

	private void CPPOALEOJHK()
	{
		OnAnimationEventSkill(0);
	}

	public virtual void LKGDGELAGNP()
	{
		base.OnEnterSkill();
		if (get_m_skill() == 0)
		{
			if (get_m_view().IsMine())
			{
				EveUnityNetwork instance = EveUnityNetwork.get_Instance();
				Vector3 position = get_m_actor().GetPosition();
				Quaternion identity = Quaternion.identity;
				object[] array = new object[7];
				array[0] = get_m_view().get_viewID();
				array[0] = m_direction;
				instance.Instantiate("unknown", position, identity, array);
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("PostProcessManager", false, 319f, 1602f);
		}
	}

	public virtual void BJCHMCLIPOH()
	{
		base.OnEnterSkill();
		if (get_m_skill() == 0)
		{
			if (get_m_view().IsMine())
			{
				EveUnityNetwork instance = EveUnityNetwork.get_Instance();
				Vector3 position = get_m_actor().GetPosition();
				Quaternion identity = Quaternion.identity;
				object[] array = new object[7];
				array[1] = get_m_view().get_viewID();
				array[1] = m_direction;
				instance.IIELNMNJGKA("buffersToAdd", position, identity, array);
			}
			get_m_actor().m_multiSound.ICNAJBHLIGO("중급 성장 체력 정수", true, 937f, 845f);
		}
	}

	public virtual void ONLNHHOPEPA()
	{
		GOGLNMODMLA = Random.Range(0, 7);
		switch (GOGLNMODMLA)
		{
		case 0:
			get_m_actor().SetAnimation("currency");
			break;
		case 1:
			get_m_actor().JNIPLJAFFFB("CreateSkill3Missile");
			break;
		}
		get_m_actor().m_multiSound.ICNAJBHLIGO(",", false, 385f, 93f);
		Actor actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 932f, false, true, (Actor.IJJMDPGJAEM)70);
		if (actorInAttackRange == null)
		{
			actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 1876f, true, true, Actor.IJJMDPGJAEM.SubHero);
			if (actorInAttackRange != null)
			{
				SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
			}
		}
		SetTarget(actorInAttackRange);
	}

	public override void Init()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 7f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = -0f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 60;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[0].DOCFEKMACMP = true;
		LFNNHEEJNGP[0].GNAAGGJGBBG = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 16f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = -0f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 30;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[1].DOCFEKMACMP = true;
		LFNNHEEJNGP[1].GNAAGGJGBBG = true;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[2].FILHECEKNMK = 11f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 0;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[3].FILHECEKNMK = 100f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = -10f;
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
		GameObject[] skill1Particles = m_skill1Particles;
		foreach (GameObject gameObject in skill1Particles)
		{
			gameObject.SetActive(false);
		}
		GameObject[] skill3Particles = m_skill3Particles;
		foreach (GameObject gameObject2 in skill3Particles)
		{
			gameObject2.SetActive(false);
		}
	}

	[CompilerGenerated]
	private void MALLMFOEHMF(KCIGFAHFHCH OGJFDNEEDCP)
	{
		OGJFDNEEDCP.GBMJNFOEACC(NGNLJADPNNB.get_m_view().get_viewID());
	}
}
