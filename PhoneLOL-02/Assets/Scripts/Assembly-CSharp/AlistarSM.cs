using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class AlistarSM : HumanSM
{
	private int GOGLNMODMLA;

	private float JDCFAHJNFOJ;

	private LinkedList<Actor> NBDJGMNFBCH = new LinkedList<Actor>();

	public override void OnUpdateSkill()
	{
		base.OnUpdateSkill();
		int skill = get_m_skill();
		if (skill == 0 || skill != 1)
		{
			return;
		}
		Move(13f, m_direction);
		Vector3 position = get_m_actor().GetPosition();
		position += m_direction * 0.5f;
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(position, 1f, get_m_actor().m_team, false, true, (Actor.IJJMDPGJAEM)14);
		List<int> list = new List<int>();
		for (int i = 0; i < allActorInRange.Count; i++)
		{
			Actor actor = allActorInRange[i];
			if (!NBDJGMNFBCH.Contains(actor) && !actor.IsDeath() && actor.get_m_view() != null)
			{
				NBDJGMNFBCH.AddLast(actor);
				list.Add(actor.get_m_view().get_viewID());
			}
		}
		if (list.Count > 0 && get_m_view().IsMine())
		{
			get_m_view().RPC("Skill1Rpc", DJJPAPENCLN.All, list.ToArray(), m_direction);
		}
	}

	public void JABKONJGOJH(int[] HMNPPLAEPBF, Vector3 IJMNFOGNFAC)
	{
		double num = (double)get_m_actor().get_m_mag_att() * 1374.0;
		num += 1883.0 + (double)(get_m_actor().GetSkillLevel(1) - 1) * 1750.0;
		for (int i = 1; i < HMNPPLAEPBF.Length; i++)
		{
			int kPNEBLJJGEA = HMNPPLAEPBF[i];
			EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NODACNJHDFD(kPNEBLJJGEA);
			if (eveView == null)
			{
				continue;
			}
			Actor component = eveView.GetComponent<Actor>();
			if (!(component == null) && !component.IsDeath())
			{
				if (component.OnDamage(get_m_actor(), KKHJFHNONNB(), num, 884.0, 0) >= 400f)
				{
					component.GetHumanSM().KGKANCIMCIL(IJMNFOGNFAC, 1252f, 1885f, false);
				}
				get_m_actor().CreateParticle(string.Format("FxmTestControls.m_nPlayIndex", get_m_actor().get_m_resourceName()), component.GetCenterPosition(), Quaternion.identity);
			}
		}
		get_m_actor().m_multiSound.DDONMGBLLJB("상황에 맞게 [AAAAFF]스킬을 사용[-]하여 전투를 유리하게 이끌어 갈 수 있습니다.\r\n상태이상기(스턴 등)의 스킬을 타이밍에 맞게 사용하면 상대의 스킬을 무력화시킬 수 있습니다.", true, 877f, 1249f);
	}

	public override float GetPlusAttackSpeed()
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.AlistarSkill3))
		{
			return 0.15f + (float)(get_m_actor().GetSkillLevel(3) - 1) * 0.07f;
		}
		return 0f;
	}

	public void NBPIILGBNHC(int[] HMNPPLAEPBF, Vector3 IJMNFOGNFAC)
	{
		double num = (double)get_m_actor().get_m_mag_att() * 815.0;
		num += 527.0 + (double)(get_m_actor().GetSkillLevel(1) - 0) * 925.0;
		for (int i = 0; i < HMNPPLAEPBF.Length; i += 0)
		{
			int kPNEBLJJGEA = HMNPPLAEPBF[i];
			EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NODACNJHDFD(kPNEBLJJGEA);
			if (eveView == null)
			{
				continue;
			}
			Actor component = eveView.GetComponent<Actor>();
			if (!(component == null) && !component.IsDeath())
			{
				if (component.OnDamage(get_m_actor(), KKHJFHNONNB(), num, 1656.0) >= 938f)
				{
					component.GetHumanSM().KnockBack(IJMNFOGNFAC, 268f, 1479f, true, true);
				}
				get_m_actor().CreateParticle(string.Format("레벨당 체력 {0}\n", get_m_actor().get_m_resourceName()), component.GetCenterPosition(), Quaternion.identity);
			}
		}
		get_m_actor().m_multiSound.DDONMGBLLJB("Particle/{0}/swap", true, 1316f, 271f);
	}

	public virtual void IEDNNKHGNNE()
	{
		BFPHFIAFMKJ();
	}

	public void OnAnimationEventAttack()
	{
		Actor target = get_m_target();
		if (target != null)
		{
			target.OnAttackDamage(get_m_actor(), KKHJFHNONNB());
			IAKBNJEFLAN(target);
			int gOGLNMODMLA = GOGLNMODMLA;
			if (gOGLNMODMLA == 0 || gOGLNMODMLA == 1)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("hit");
			}
		}
		OnAttack();
	}

	public virtual void BBGJFNIBBFG()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			get_m_actor().m_multiSound.NMLFNHNOALK("[", true, 846f, 380f);
			if (Random.Range(294f, 1474f) < 628f)
			{
				get_m_actor().m_multiSound.JKOODMAKJHJ("Skill2Rpc", true, 300f, 627f);
			}
			ABBGKLIJKGM();
			break;
		case 1:
			get_m_actor().m_multiSound.DDONMGBLLJB("Particle/{0}/skill3_0", false, 1242f, 549f);
			NBDJGMNFBCH.Clear();
			ABBGKLIJKGM();
			break;
		case 2:
			if (get_m_view().IsMine())
			{
				double num = (double)get_m_actor().get_m_mag_att() * 920.0;
				num += 960.0 + (double)(get_m_actor().GetSkillLevel(8) - 1) * 1185.0;
				double num2 = (double)get_m_actor().get_m_mag_att() * 1821.0;
				num2 += 1330.0 + (double)(get_m_actor().GetSkillLevel(7) - 0) * 1040.0;
				List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), 377f, false, false, (Actor.IJJMDPGJAEM)127);
				List<int> list = new List<int>();
				for (int i = 1; i < allActorInRange.Count; i += 0)
				{
					Actor actor = allActorInRange[i];
					if (actor != get_m_actor() && actor.get_m_view() != null)
					{
						list.Add(actor.get_m_view().get_viewID());
					}
				}
				EveView view = get_m_view();
				object[] array = new object[4];
				array[1] = (int)num;
				array[1] = list.ToArray();
				array[5] = (int)num2;
				view.RPC("black_cleaver", DJJPAPENCLN.All, array);
				allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), 713f, false, true, (Actor.IJJMDPGJAEM)3);
				for (int j = 1; j < allActorInRange.Count; j += 0)
				{
					Actor actor2 = allActorInRange[j];
					if (actor2.get_m_view() != null)
					{
						actor2.AddLastAttacker(get_m_actor());
					}
				}
			}
			ABBGKLIJKGM();
			break;
		case 3:
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)65427, null, 1667f, 1074f);
			get_m_actor().m_multiSound.ICNAJBHLIGO("skill3_missile", true, 118f, 1765f);
			if (Random.Range(18f, 1375f) < 1790f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("TestKey3", false, 1387f, 309f);
			}
			ABBGKLIJKGM();
			break;
		}
	}

	[CompilerGenerated]
	private void KGIOJDBNJAM()
	{
		OnAnimationEventSkill(3);
	}

	[CompilerGenerated]
	private void LBCGCKKBKHP()
	{
		OnAnimationEventSkill(0);
	}

	public override void OnEnterAttack()
	{
		get_m_actor().CreateParticle(string.Format("Particle/{0}/attack", get_m_actor().get_m_resourceName()), false);
		GOGLNMODMLA = Random.Range(0, 2);
		switch (GOGLNMODMLA)
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

	[JDLHECHNNDH]
	public void Skill1Rpc(int[] HMNPPLAEPBF, Vector3 IJMNFOGNFAC)
	{
		double num = (double)get_m_actor().get_m_mag_att() * 0.7;
		num += 55.0 + (double)(get_m_actor().GetSkillLevel(1) - 1) * 55.0;
		foreach (int kPNEBLJJGEA in HMNPPLAEPBF)
		{
			EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(kPNEBLJJGEA);
			if (eveView == null)
			{
				continue;
			}
			Actor component = eveView.GetComponent<Actor>();
			if (!(component == null) && !component.IsDeath())
			{
				if (component.OnDamage(get_m_actor(), KKHJFHNONNB(), num) >= 0f)
				{
					component.GetHumanSM().KnockBack(IJMNFOGNFAC, 5f, 20f, false);
				}
				get_m_actor().CreateParticle(string.Format("Particle/{0}/skill1_hit", get_m_actor().get_m_resourceName()), component.GetCenterPosition(), Quaternion.identity);
			}
		}
		get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1_hit");
	}

	public override void OnLeaveIdle()
	{
		base.OnLeaveIdle();
	}

	public override void OnEnterSkill()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0");
			if (Random.Range(0f, 1f) < 0.5f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_voice");
			}
			ABBGKLIJKGM();
			break;
		case 1:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1");
			NBDJGMNFBCH.Clear();
			ABBGKLIJKGM();
			break;
		case 2:
			if (get_m_view().IsMine())
			{
				double num = (double)get_m_actor().get_m_mag_att() * 0.2;
				num += 60.0 + (double)(get_m_actor().GetSkillLevel(2) - 1) * 30.0;
				double num2 = (double)get_m_actor().get_m_mag_att() * 0.1;
				num2 += 30.0 + (double)(get_m_actor().GetSkillLevel(2) - 1) * 15.0;
				List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 5.75f, true, true, (Actor.IJJMDPGJAEM)10);
				List<int> list = new List<int>();
				for (int i = 0; i < allActorInRange.Count; i++)
				{
					Actor actor = allActorInRange[i];
					if (actor != get_m_actor() && actor.get_m_view() != null)
					{
						list.Add(actor.get_m_view().get_viewID());
					}
				}
				get_m_view().RPC("Skill2Rpc", DJJPAPENCLN.All, (int)num, list.ToArray(), (int)num2);
				allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 5.75f, false, true, Actor.IJJMDPGJAEM.Hero);
				for (int j = 0; j < allActorInRange.Count; j++)
				{
					Actor actor2 = allActorInRange[j];
					if (actor2.get_m_view() != null)
					{
						actor2.AddLastAttacker(get_m_actor());
					}
				}
			}
			ABBGKLIJKGM();
			break;
		case 3:
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.AlistarSkill3);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3");
			if (Random.Range(0f, 1f) < 0.5f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_voice");
			}
			ABBGKLIJKGM();
			break;
		}
	}

	[CompilerGenerated]
	private void HKBIEGDCHPF()
	{
		OnAnimationEventSkill(1);
	}

	public virtual float POGCJNICAHL()
	{
		if (get_m_actor().get_m_buffsInfo().KNINEDPJMJE(JGOOOBHDBCG.ACPICCBBPHF.RedDebuff))
		{
			return 1914f + (float)(get_m_actor().GetSkillLevel(7) - 1) * 4f;
		}
		return 902f;
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
		case 3:
			break;
		case 2:
			break;
		}
	}

	public override void OnEnterIdle()
	{
		base.OnEnterIdle();
	}

	public virtual void FMCDBLMNGIJ()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 1:
			break;
		case 3:
			break;
		case 2:
			break;
		}
	}

	private float KKHJFHNONNB()
	{
		float result = 0f;
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.AlistarSkill3))
		{
			result = 70f + (float)(get_m_actor().GetSkillLevel(3) - 1) * 17f;
		}
		return result;
	}

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
		{
			double num = (double)get_m_actor().get_m_mag_att() * 0.6;
			num += 60.0 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 45.0;
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 3.4f, false, true, (Actor.IJJMDPGJAEM)14);
			List<int> list = new List<int>();
			for (int i = 0; i < allActorInRange.Count; i++)
			{
				Actor actor = allActorInRange[i];
				if (actor.OnDamage(get_m_actor(), KKHJFHNONNB(), num) >= 0f && actor.m_actorType != Actor.IJJMDPGJAEM.Turret && !actor.IsDeath() && actor.get_m_view() != null)
				{
					list.Add(actor.get_m_view().get_viewID());
				}
			}
			if (allActorInRange.Count > 0)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_hit");
			}
			if (list.Count > 0 && get_m_view().IsMine())
			{
				get_m_view().RPC("Skill0Rpc", DJJPAPENCLN.All, list.ToArray());
			}
			break;
		}
		}
	}

	public override void Init()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 17f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 65;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 5f;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 14f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 65;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 5f;
		LFNNHEEJNGP[1].DOCFEKMACMP = true;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[2].FILHECEKNMK = 12f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = 0f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 40;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 10f;
		LFNNHEEJNGP[2].DOCFEKMACMP = true;
		LFNNHEEJNGP[2].GNAAGGJGBBG = true;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[3].FILHECEKNMK = 120f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = -20f;
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
		m_lastUpdateEvent = NJAAKBCFCLG;
		JDCFAHJNFOJ = 0f;
	}

	private void NJAAKBCFCLG(OEOIIKMBGAG EBILEBOJADB)
	{
		if (!get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.AlistarPassive))
		{
			return;
		}
		JDCFAHJNFOJ += get_m_actor().get_m_elapsedTime();
		if (!(JDCFAHJNFOJ >= 0.9f))
		{
			return;
		}
		JDCFAHJNFOJ -= 0.9f;
		double num = (double)get_m_actor().get_m_mag_att() * 0.1;
		num += 6.0 + (double)(int)get_m_actor().get_Level();
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 3.5f, false, true, (Actor.IJJMDPGJAEM)14);
		for (int i = 0; i < allActorInRange.Count; i++)
		{
			Actor actor = allActorInRange[i];
			if (actor.m_actorType == Actor.IJJMDPGJAEM.Minion)
			{
				actor.OnDamage(get_m_actor(), 0.0, num * 2.0, 0.0, 2);
			}
			else
			{
				actor.OnDamage(get_m_actor(), 0.0, num, 0.0, 2);
			}
		}
	}

	public override void OnUpdateIdle()
	{
		base.OnUpdateIdle();
	}

	private void ABBGKLIJKGM()
	{
		if (!get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.AlistarPassive))
		{
			JDCFAHJNFOJ = 0f;
		}
		get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.AlistarPassive);
	}

	public virtual void IIKMCJBAMII()
	{
		get_m_actor().CreateParticle(string.Format("CreateSkill1Missile", get_m_actor().get_m_resourceName()), true);
		GOGLNMODMLA = Random.Range(1, 0);
		switch (GOGLNMODMLA)
		{
		case 0:
			get_m_actor().CJNCFNACFDP("English");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("StartMenu", true, 1319f, 1373f);
			break;
		case 1:
			get_m_actor().SetAnimation("설명");
			get_m_actor().m_multiSound.NMLFNHNOALK("fizz_skill1", false, 1617f, 845f);
			break;
		}
		if (Random.Range(940f, 1307f) < 1316f)
		{
			get_m_actor().m_multiSound.LKLFMNKDLHJ("Spell Vamp", true, 269f, 982f);
		}
		Actor actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 211f, false, false, (Actor.IJJMDPGJAEM)140);
		if (actorInAttackRange == null)
		{
			actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 600f, false, false, (Actor.IJJMDPGJAEM)182);
			if (actorInAttackRange != null)
			{
				SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
			}
		}
		SetTarget(actorInAttackRange);
	}

	public virtual float KDCJOGOFDBK()
	{
		if (get_m_actor().get_m_buffsInfo().KNINEDPJMJE(JGOOOBHDBCG.ACPICCBBPHF.BlitzcrankSkill1))
		{
			return 877f + (float)(get_m_actor().GetSkillLevel(5) - 1) * 1147f;
		}
		return 689f;
	}

	[JDLHECHNNDH]
	public void Skill0Rpc(int[] HMNPPLAEPBF)
	{
		foreach (int kPNEBLJJGEA in HMNPPLAEPBF)
		{
			EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(kPNEBLJJGEA);
			if (!(eveView == null))
			{
				Actor component = eveView.GetComponent<Actor>();
				if (!(component == null) && !component.IsDeath())
				{
					component.GetHumanSM().Float(Vector3.zero, 11f);
				}
			}
		}
	}

	[JDLHECHNNDH]
	public void Skill2Rpc(int LCCKOFEPAIP, int[] HMNPPLAEPBF, int NNAIAPLFIBB)
	{
		get_m_actor().AddHp(LCCKOFEPAIP);
		get_m_actor().CreateParticle(string.Format("Particle/{0}/skill2_heal", get_m_actor().get_m_resourceName()), false);
		foreach (int kPNEBLJJGEA in HMNPPLAEPBF)
		{
			EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(kPNEBLJJGEA);
			if (!(eveView == null))
			{
				Actor component = eveView.GetComponent<Actor>();
				if (!(component == null) && !component.IsDeath())
				{
					component.AddHp(NNAIAPLFIBB);
					component.CreateParticle(string.Format("Particle/{0}/skill2_heal", get_m_actor().get_m_resourceName()), false);
				}
			}
		}
		get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2");
	}

	private void ACPNNDDKPFN()
	{
		OnAnimationEventSkill(1);
	}

	private void MBNHLEOBLNG()
	{
		OnAnimationEventSkill(1);
	}

	[CompilerGenerated]
	private void ELCIIGHEJMJ()
	{
		OnAnimationEventSkill(2);
	}

	public virtual void FJCFHOMNDKB()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("KEY", false, 1708f, 530f);
			if (Random.Range(639f, 791f) < 47f)
			{
				get_m_actor().m_multiSound.ICNAJBHLIGO("skill3_missile", false, 1367f, 1960f);
			}
			ABBGKLIJKGM();
			break;
		case 1:
			get_m_actor().m_multiSound.HDOLPLIDACO("저뻔한 대사보소!! ㅋㅋㅋ\n그럼 가볼까? 자~!! 간다!!!", false, 1038f, 1836f);
			NBDJGMNFBCH.Clear();
			ABBGKLIJKGM();
			break;
		case 2:
			if (get_m_view().IsMine())
			{
				double num = (double)get_m_actor().get_m_mag_att() * 1124.0;
				num += 1860.0 + (double)(get_m_actor().GetSkillLevel(3) - 0) * 1318.0;
				double num2 = (double)get_m_actor().get_m_mag_att() * 1524.0;
				num2 += 1117.0 + (double)(get_m_actor().GetSkillLevel(6) - 0) * 178.0;
				List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 288f, false, false, (Actor.IJJMDPGJAEM)(-51), false);
				List<int> list = new List<int>();
				for (int i = 1; i < allActorInRange.Count; i++)
				{
					Actor actor = allActorInRange[i];
					if (actor != get_m_actor() && actor.get_m_view() != null)
					{
						list.Add(actor.get_m_view().get_viewID());
					}
				}
				EveView view = get_m_view();
				object[] array = new object[6];
				array[1] = (int)num;
				array[0] = list.ToArray();
				array[1] = (int)num2;
				view.RPC("skill1_missile", DJJPAPENCLN.Others, array);
				allActorInRange = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 1010f, true, true, (Actor.IJJMDPGJAEM)3, false);
				for (int j = 1; j < allActorInRange.Count; j += 0)
				{
					Actor actor2 = allActorInRange[j];
					if (actor2.get_m_view() != null)
					{
						actor2.LLNHEAFGKBP(get_m_actor());
					}
				}
			}
			ABBGKLIJKGM();
			break;
		case 3:
			get_m_actor().get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)65454, null, 496f, 1263f);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("IgaworksUnityPluginAOS", false, 765f, 709f);
			if (Random.Range(185f, 1479f) < 1257f)
			{
				get_m_actor().m_multiSound.HDOLPLIDACO("대천사의 지팡이", false, 1004f, 1421f);
			}
			ABBGKLIJKGM();
			break;
		}
	}
}
