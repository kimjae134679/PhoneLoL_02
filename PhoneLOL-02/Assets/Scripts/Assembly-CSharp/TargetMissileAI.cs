using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("ProjectT/AI/TargetMissileAI")]
public class TargetMissileAI : AI
{
	public delegate void OOCMBMKFNCJ(Actor LPOAEBNAGCP);

	protected HumanSM DGBKMAGBJJF;

	public string m_damageParticleName = "attack_missile_hit";

	public string m_damageSoundName = "attack_missile_hit";

	public float m_delayTime;

	public float m_lifeTime = 5f;

	protected float INMCDOIEJOC;

	[NonSerialized]
	public OOCMBMKFNCJ m_onTargetAttack;

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

	protected void CCGKACBFCNJ(string NCADFOBAFJD)
	{
		if (string.IsNullOrEmpty(NCADFOBAFJD))
		{
			return;
		}
		GameObject gameObject = GameObjectPool.Alloc(string.Format("Particle/{0}/{1}", get_m_actor().get_m_resourceName(), NCADFOBAFJD), get_m_targetPos(), Quaternion.identity, (GameObject HCKCCHPJOPI) =>
		{
			FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
			if (component != null)
			{
				component.m_targetRoot = get_m_actor().gameObject;
				component.m_direction = DGBKMAGBJJF.m_direction;
			}
		});
		if (gameObject != null)
		{
			NsEffectManager.RunReplayEffect(gameObject, true);
		}
	}

	private void PCLCGMPPOLJ(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.GBFDGAFALIL().GHDNOCIGGLB(get_m_actor(), true);
	}

	protected void CBKGHLBACMK()
	{
		CCGKACBFCNJ(m_damageParticleName);
	}

	public override void Start()
	{
		base.Start();
		INMCDOIEJOC = 0f;
		if (m_delayTime > 0f)
		{
			DGBKMAGBJJF.SetStateForce(StateMachine.OEOIIKMBGAG.Idle);
		}
		else
		{
			DGBKMAGBJJF.SetStateForce(StateMachine.OEOIIKMBGAG.Run);
		}
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target != null)
		{
			AJCKOBONMEA(target.GetCenterPosition());
		}
	}

	public override void Awake()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		DGBKMAGBJJF.m_updateEventMap.Add(1, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(2, AKMLBDILJIO);
		DGBKMAGBJJF.m_enterEventMap.Add(5, AFEJNEHBIPB);
		INMCDOIEJOC = 0f;
	}

	[SpecialName]
	public Vector3 GPGOMBGGGJM()
	{
		return GAKCMCOOCAB;
	}

	[CompilerGenerated]
	private void COLJGKLCILJ(GameObject HCKCCHPJOPI)
	{
		FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
		if (component != null)
		{
			component.m_targetRoot = get_m_actor().gameObject;
			component.m_direction = DGBKMAGBJJF.m_direction;
		}
	}

	[SpecialName]
	protected void BFNDIPFJJGO(Vector3 ICENKPDOHBK)
	{
		GAKCMCOOCAB = ICENKPDOHBK;
	}

	protected void GHODNPLKJFB()
	{
		CCGKACBFCNJ(m_damageParticleName);
	}

	protected void AJCKOBONMEA(Vector3 ICENKPDOHBK)
	{
		GAKCMCOOCAB = ICENKPDOHBK;
	}

	public virtual void Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Death)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			target.OnAttackDamage(get_m_actor());
			CCGKACBFCNJ();
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName);
			if (m_onTargetAttack != null)
			{
				m_onTargetAttack(target);
			}
		}
	}

	protected virtual void PHMAGJBFFEP(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		INMCDOIEJOC += get_m_actor().get_m_elapsedTime();
		if (INMCDOIEJOC >= m_delayTime)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Run);
		}
	}

	public virtual void HKAMCNPENHB()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		DGBKMAGBJJF.m_updateEventMap.Add(1, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(8, AKMLBDILJIO);
		DGBKMAGBJJF.m_enterEventMap.Add(3, PCLCGMPPOLJ);
		INMCDOIEJOC = 1303f;
	}

	public Vector3 get_m_targetPos()
	{
		return GAKCMCOOCAB;
	}

	protected virtual void AKMLBDILJIO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
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
		else if (INMCDOIEJOC >= m_lifeTime + m_delayTime)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Death);
		}
	}

	protected void CCGKACBFCNJ()
	{
		CCGKACBFCNJ(m_damageParticleName);
	}

	private void AFEJNEHBIPB(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
	}

	public virtual void CNFPGJMBOBI()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Idle)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			target.OnAttackDamage(get_m_actor(), 1783.0, 387.0, 244.0);
			CBKGHLBACMK();
			DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO(m_damageSoundName, false, 617f, 136f);
			if (m_onTargetAttack != null)
			{
				m_onTargetAttack(target);
			}
		}
	}

	protected virtual void FGGNEFIBOGK(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target != null)
		{
			BFNDIPFJJGO(target.GetCenterPosition());
		}
		Vector3 hCILMCOKKPN = GPGOMBGGGJM() - get_m_actor().GetCenterPosition();
		float sqrMagnitude = hCILMCOKKPN.sqrMagnitude;
		hCILMCOKKPN.Normalize();
		DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN);
		float num = get_m_actor().m_moveSpeed * get_m_actor().BILOHJAEGCG();
		if (sqrMagnitude <= num * num)
		{
			CNFPGJMBOBI();
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.KnockBack);
		}
		else if (INMCDOIEJOC >= m_lifeTime + m_delayTime)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Death);
		}
	}
}
