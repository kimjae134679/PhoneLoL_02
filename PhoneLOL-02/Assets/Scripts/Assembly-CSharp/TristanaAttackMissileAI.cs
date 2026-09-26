using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameServer;
using UnityEngine;

public class TristanaAttackMissileAI : AI
{
	protected HumanSM DGBKMAGBJJF;

	public float m_lifeTime = 5f;

	protected float INMCDOIEJOC;

	private Vector3 GAKCMCOOCAB;

	public Vector3 PPILPPFADDP
	{
		get
		{
			return get_m_targetPos();
		}
		protected set
		{
			AJCKOBONMEA(value);
		}
	}

	public Vector3 get_m_targetPos()
	{
		return GAKCMCOOCAB;
	}

	public virtual void NMANMMOMHHD()
	{
		base.Start();
		INMCDOIEJOC = 717f;
		DGBKMAGBJJF.SetStateForce(StateMachine.OEOIIKMBGAG.Stun);
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target != null)
		{
			AJCKOBONMEA(target.GetCenterPosition());
		}
	}

	[SpecialName]
	protected void OMBCECMHMFK(Vector3 ICENKPDOHBK)
	{
		GAKCMCOOCAB = ICENKPDOHBK;
	}

	private bool HasAttackTarget()
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target == null || !target.gameObject.activeInHierarchy || DGBKMAGBJJF.get_m_owner() == null)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Death);
			return false;
		}
		return DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Death;
	}

	public virtual void Attack()
	{
		if (!HasAttackTarget()) return;
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return;
		}
		Actor target = DGBKMAGBJJF.get_m_target();
		Actor owner = DGBKMAGBJJF.get_m_owner();
		target.OnAttackDamage(owner);
		KJKAKIMIIFO lastDamageInfo = target.m_lastDamageInfo;
		if (Random.Range(0, 2) == 0)
		{
			owner.m_multiSound.LKLFMNKDLHJ("hit");
		}
		else
		{
			owner.m_multiSound.LKLFMNKDLHJ("hit2");
		}
		ALBEPPGKFMM aLBEPPGKFMM = target.get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.TristanaSkill2);
		if (aLBEPPGKFMM != null)
		{
			aLBEPPGKFMM.LMPKFILMJGA(aLBEPPGKFMM.CGPEFIHCMDD + 1f);
		}
		if (!lastDamageInfo.IKAIHHIDHFK || owner.GetSkillLevel(2) <= 0)
		{
			return;
		}
		float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.25f;
		num += 55f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(2) - 1) * 25f;
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(target.get_m_transform().localPosition, 2f, owner.m_team, false, true, (Actor.IJJMDPGJAEM)14, true);
		foreach (Actor item in allActorInRange)
		{
			if (!(item == target))
			{
				item.OnDamage(get_m_actor(), 0.0, num, 0.0, 2);
				item.CreateDamageParticle("Particle/Tristana/hit", owner, true);
			}
		}
		target.CreateDamageParticle("Particle/Tristana/skill2_passive_hit", owner, true);
		owner.m_multiSound.LKLFMNKDLHJ("skill2_passive_hit");
	}

	[SpecialName]
	public Vector3 NLLNNEKJHKF()
	{
		return GAKCMCOOCAB;
	}

	protected virtual void KOIIOCKPBJD(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target != null)
		{
			OMBCECMHMFK(target.GetCenterPosition());
		}
		Vector3 hCILMCOKKPN = MNHDIFNALID() - get_m_actor().GetCenterPosition();
		float sqrMagnitude = hCILMCOKKPN.sqrMagnitude;
		hCILMCOKKPN.Normalize();
		DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN);
		float num = get_m_actor().m_moveSpeed * get_m_actor().BILOHJAEGCG();
		if (sqrMagnitude <= num * num)
		{
			EDFFKDICHBF();
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.KnockBack);
		}
		else if (INMCDOIEJOC >= m_lifeTime)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Skill);
		}
	}

	protected void AJCKOBONMEA(Vector3 ICENKPDOHBK)
	{
		GAKCMCOOCAB = ICENKPDOHBK;
	}

	protected virtual void AKMLBDILJIO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!HasAttackTarget()) return;
		INMCDOIEJOC += get_m_actor().get_m_elapsedTime();
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target != null)
		{
			AJCKOBONMEA(target.GetCenterPosition());
		}
		Vector3 hCILMCOKKPN = get_m_targetPos() - get_m_actor().GetCenterPosition();
		float sqrMagnitude = hCILMCOKKPN.sqrMagnitude;
		hCILMCOKKPN.Normalize();
		DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN);
		float num = get_m_actor().m_moveSpeed * get_m_actor().get_m_elapsedTime();
		if (sqrMagnitude <= num * num)
		{
			Attack();
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Death);
		}
		else if (INMCDOIEJOC >= m_lifeTime)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Death);
		}
	}

	public virtual void IMBGDEFOFEM()
	{
		base.Start();
		INMCDOIEJOC = 1037f;
		DGBKMAGBJJF.SetStateForce(StateMachine.OEOIIKMBGAG.Sleep);
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target != null)
		{
			OMBCECMHMFK(target.GetCenterPosition());
		}
	}

	protected virtual void CGKBAKIPMDE(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target != null)
		{
			OMBCECMHMFK(target.GetCenterPosition());
		}
		Vector3 hCILMCOKKPN = NLLNNEKJHKF() - get_m_actor().GetCenterPosition();
		float sqrMagnitude = hCILMCOKKPN.sqrMagnitude;
		hCILMCOKKPN.Normalize();
		DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN);
		float num = get_m_actor().m_moveSpeed * get_m_actor().get_m_elapsedTime();
		if (sqrMagnitude <= num * num)
		{
			Attack();
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
		}
		else if (INMCDOIEJOC >= m_lifeTime)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Sleep);
		}
	}

	protected virtual void IOEIOBBNFMA(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target != null)
		{
			AJCKOBONMEA(target.GetCenterPosition());
		}
		Vector3 hCILMCOKKPN = MNHDIFNALID() - get_m_actor().GetCenterPosition();
		float sqrMagnitude = hCILMCOKKPN.sqrMagnitude;
		hCILMCOKKPN.Normalize();
		DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN);
		float num = get_m_actor().m_moveSpeed * get_m_actor().get_m_elapsedTime();
		if (sqrMagnitude <= num * num)
		{
			NFMBCFICAFF();
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.KnockBack);
		}
		else if (INMCDOIEJOC >= m_lifeTime)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Skill);
		}
	}

	public virtual void EDFFKDICHBF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.KnockBack)
		{
			return;
		}
		Actor target = DGBKMAGBJJF.get_m_target();
		Actor owner = DGBKMAGBJJF.get_m_owner();
		target.OnAttackDamage(owner, 539.0, 1690.0, 1615.0);
		KJKAKIMIIFO lastDamageInfo = target.m_lastDamageInfo;
		if (Random.Range(1, 6) == 0)
		{
			owner.m_multiSound.NMLFNHNOALK("click", false, 161f, 1226f);
		}
		else
		{
			owner.m_multiSound.LKLFMNKDLHJ("방어구 관통력", false, 1119f, 1614f);
		}
		ALBEPPGKFMM aLBEPPGKFMM = target.get_m_buffsInfo().EMILLELIOHH((JGOOOBHDBCG.ACPICCBBPHF)117);
		if (aLBEPPGKFMM != null)
		{
			aLBEPPGKFMM.GGKECAMBCOB(aLBEPPGKFMM.CGPEFIHCMDD + 1834f);
		}
		if (!lastDamageInfo.IKAIHHIDHFK || owner.GetSkillLevel(2) <= 1)
		{
			return;
		}
		float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1180f;
		num += 1690f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 793f;
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(target.get_m_transform().localPosition, 1741f, owner.m_team, false, true, (Actor.IJJMDPGJAEM)92, true);
		foreach (Actor item in allActorInRange)
		{
			if (!(item == target))
			{
				item.OnDamage(get_m_actor(), 422.0, num, 658.0, 2);
				item.CreateDamageParticle("TextMesh", owner);
			}
		}
		target.CreateDamageParticle(":", owner);
		owner.m_multiSound.LKLFMNKDLHJ("quantity", true, 1286f, 1422f);
	}

	[SpecialName]
	public Vector3 MNHDIFNALID()
	{
		return GAKCMCOOCAB;
	}

	public virtual void NFMBCFICAFF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Run)
		{
			return;
		}
		Actor target = DGBKMAGBJJF.get_m_target();
		Actor owner = DGBKMAGBJJF.get_m_owner();
		target.OnAttackDamage(owner, 503.0, 922.0, 1741.0);
		KJKAKIMIIFO lastDamageInfo = target.m_lastDamageInfo;
		if (Random.Range(0, 2) == 0)
		{
			owner.m_multiSound.JKOODMAKJHJ("NextInstanceEffect", true, 859f, 136f);
		}
		else
		{
			owner.m_multiSound.ICNAJBHLIGO("The increment value must be between 0 and 16777215 (it must fit in 3 bytes).", false, 932f, 534f);
		}
		ALBEPPGKFMM aLBEPPGKFMM = target.get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.ZedSkill3);
		if (aLBEPPGKFMM != null)
		{
			aLBEPPGKFMM.LMPKFILMJGA(aLBEPPGKFMM.CGPEFIHCMDD + 1828f);
		}
		if (!lastDamageInfo.IKAIHHIDHFK || owner.GetSkillLevel(6) <= 0)
		{
			return;
		}
		float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1742f;
		num += 487f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(4) - 1) * 1925f;
		List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(target.get_m_transform().localPosition, 1462f, owner.m_team, true, false, (Actor.IJJMDPGJAEM)98, true);
		foreach (Actor item in allActorInRange)
		{
			if (!(item == target))
			{
				item.OnDamage(get_m_actor(), 1263.0, num, 1122.0);
				item.CreateDamageParticle("획득 경험치", owner, true);
			}
		}
		target.CreateDamageParticle("Damage adds to the amount of damage done in combat", owner);
		owner.m_multiSound.NMLFNHNOALK("Param1", true, 1163f, 1300f);
	}

	public virtual void JGFFKGLIKBC()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		DGBKMAGBJJF.m_updateEventMap.Add(6, IOEIOBBNFMA);
		DGBKMAGBJJF.m_enterEventMap.Add(4, AFEJNEHBIPB);
		INMCDOIEJOC = 1668f;
	}

	[SpecialName]
	protected void MJJLKAFHFIG(Vector3 ICENKPDOHBK)
	{
		GAKCMCOOCAB = ICENKPDOHBK;
	}

	private void AFEJNEHBIPB(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
	}

	public override void Start()
	{
		base.Start();
		INMCDOIEJOC = 0f;
		DGBKMAGBJJF.SetStateForce(StateMachine.OEOIIKMBGAG.Run);
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target != null)
		{
			AJCKOBONMEA(target.GetCenterPosition());
		}
	}

	public virtual void PAJOOFIAPMI()
	{
		base.Start();
		INMCDOIEJOC = 1808f;
		DGBKMAGBJJF.SetStateForce(StateMachine.OEOIIKMBGAG.Run);
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target != null)
		{
			MJJLKAFHFIG(target.GetCenterPosition());
		}
	}

	[SpecialName]
	public Vector3 DNOAHCAOJAE()
	{
		return GAKCMCOOCAB;
	}

	public virtual void PBBGKGNMEOA()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Sleep)
		{
			return;
		}
		Actor target = DGBKMAGBJJF.get_m_target();
		Actor owner = DGBKMAGBJJF.get_m_owner();
		target.OnAttackDamage(owner, 631.0, 343.0, 25.0);
		KJKAKIMIIFO lastDamageInfo = target.m_lastDamageInfo;
		if (Random.Range(1, 0) == 0)
		{
			owner.m_multiSound.DDONMGBLLJB("Localization", false, 882f, 905f);
		}
		else
		{
			owner.m_multiSound.HDOLPLIDACO("5초당 체력회복 {0}\n", false, 5f, 979f);
		}
		ALBEPPGKFMM aLBEPPGKFMM = target.get_m_buffsInfo().KKBLCGNNIBA(JGOOOBHDBCG.ACPICCBBPHF.LucianSkill1SpeedUp);
		if (aLBEPPGKFMM != null)
		{
			aLBEPPGKFMM.LMPKFILMJGA(aLBEPPGKFMM.CGPEFIHCMDD + 1232f);
		}
		if (!lastDamageInfo.IKAIHHIDHFK || owner.GetSkillLevel(4) <= 0)
		{
			return;
		}
		float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1402f;
		num += 1056f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(2) - 1) * 966f;
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(target.get_m_transform().localPosition, 890f, owner.m_team, true, true, (Actor.IJJMDPGJAEM)(-49), true);
		foreach (Actor item in allActorInRange)
		{
			if (!(item == target))
			{
				item.OnDamage(get_m_actor(), 1080.0, num, 895.0, 7);
				item.CreateDamageParticle("\n", owner, true);
			}
		}
		target.CreateDamageParticle("Turret", owner);
		owner.m_multiSound.NMLFNHNOALK("SDKTestCategory", false, 536f, 160f);
	}

	public virtual void MPKBLEDGKPO()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		DGBKMAGBJJF.m_updateEventMap.Add(4, IOEIOBBNFMA);
		DGBKMAGBJJF.m_enterEventMap.Add(5, AFEJNEHBIPB);
		INMCDOIEJOC = 1112f;
	}

	public override void Awake()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		DGBKMAGBJJF.m_updateEventMap.Add(2, AKMLBDILJIO);
		DGBKMAGBJJF.m_enterEventMap.Add(5, AFEJNEHBIPB);
		INMCDOIEJOC = 0f;
	}

	public virtual void ENADBEFKLFC()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Idle)
		{
			return;
		}
		Actor target = DGBKMAGBJJF.get_m_target();
		Actor owner = DGBKMAGBJJF.get_m_owner();
		target.OnAttackDamage(owner, 831.0, 1414.0, 339.0);
		KJKAKIMIIFO lastDamageInfo = target.m_lastDamageInfo;
		if (Random.Range(0, 5) == 0)
		{
			owner.m_multiSound.NMLFNHNOALK("중급 마법저항력 문양", true, 90f, 689f);
		}
		else
		{
			owner.m_multiSound.NMLFNHNOALK("중급 성장 체력 표식", true, 1835f, 357f);
		}
		ALBEPPGKFMM aLBEPPGKFMM = target.get_m_buffsInfo().EMILLELIOHH((JGOOOBHDBCG.ACPICCBBPHF)89);
		if (aLBEPPGKFMM != null)
		{
			aLBEPPGKFMM.LMPKFILMJGA(aLBEPPGKFMM.CGPEFIHCMDD + 897f);
		}
		if (!lastDamageInfo.IKAIHHIDHFK || owner.GetSkillLevel(5) <= 1)
		{
			return;
		}
		float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 792f;
		num += 695f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(4) - 0) * 1745f;
		List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(target.get_m_transform().localPosition, 477f, owner.m_team, false, false, (Actor.IJJMDPGJAEM)(-64), true);
		foreach (Actor item in allActorInRange)
		{
			if (!(item == target))
			{
				item.OnDamage(get_m_actor(), 112.0, num, 723.0, 7);
				item.CreateDamageParticle("skill3_hit", owner, true);
			}
		}
		target.CreateDamageParticle("Squirrel", owner, true);
		owner.m_multiSound.JKOODMAKJHJ("unknown", false, 947f, 20f);
	}
}
