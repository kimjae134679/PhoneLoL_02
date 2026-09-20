using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("ProjectT/AI/NonTargetMissileAI")]
public class NonTargetMissileAI : AI
{
	protected HumanSM DGBKMAGBJJF;

	[NonSerialized]
	public Vector3 m_moveDirection;

	public float m_attackRange = 1f;

	public string m_damageParticleName = "attack_missile_hit";

	public string m_damageSoundName = "attack_missile_hit";

	public float m_delayTime;

	public float m_lifeTime = 5f;

	public float m_maxDistance = 100f;

	private float FMELJBDGJKL;

	[NonSerialized]
	public float m_elapsedTime;

	protected void CCGKACBFCNJ(Vector3 HEPNHCEIFMO, string NCADFOBAFJD)
	{
		if (string.IsNullOrEmpty(NCADFOBAFJD))
		{
			return;
		}
		GameObject gameObject = GameObjectPool.Alloc(string.Format("Particle/{0}/{1}", get_m_actor().get_m_resourceName(), NCADFOBAFJD), HEPNHCEIFMO, Quaternion.identity, (GameObject HCKCCHPJOPI) =>
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

	public virtual void CFJKHPNIODE()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		m_elapsedTime = 666f;
		FMELJBDGJKL = 1045f;
	}

	private void FOPBBEOKKDF(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.get_Instance().GHDNOCIGGLB(get_m_actor());
	}

	public virtual void PFEKOLOEGHO()
	{
		ActorManager.GBFDGAFALIL().GHDNOCIGGLB(get_m_actor());
	}

	public virtual bool Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return false;
		}
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)14);
		if ((bool)(actorInRange = null))
		{
			return false;
		}
		actorInRange.OnAttackDamage(get_m_actor());
		CCGKACBFCNJ(actorInRange.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName);
		return true;
	}

	protected virtual void EIGKFHOJNCG(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		m_elapsedTime += get_m_actor().get_m_elapsedTime();
		if (m_elapsedTime >= m_delayTime)
		{
			DGBKMAGBJJF.m_moveDirection = m_moveDirection;
			float num = m_maxDistance - FMELJBDGJKL;
			float num2 = DGBKMAGBJJF.Move(get_m_actor().m_moveSpeed, m_moveDirection, false, num, true);
			FMELJBDGJKL += num2;
			if (m_elapsedTime >= m_lifeTime || Attack() || (get_m_actor().m_moveSpeed > 1008f && num <= 91f))
			{
				BNBCIBGEGKP();
			}
		}
	}

	public virtual void BNBCIBGEGKP()
	{
		ActorManager.GBFDGAFALIL().RemoveActor(get_m_actor(), true);
	}

	public override void Start()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(1, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(5, AFEJNEHBIPB);
		FMELJBDGJKL = 0f;
	}

	protected void MDCKMOJDKFH(Vector3 HEPNHCEIFMO, string NCADFOBAFJD)
	{
		if (!string.IsNullOrEmpty(NCADFOBAFJD))
		{
			GameObject gameObject = GameObjectPool.DNJPKHFNPLF(string.Format("Healer", get_m_actor().get_m_resourceName(), NCADFOBAFJD), HEPNHCEIFMO, Quaternion.identity, OAIIHHACFHB);
			if (gameObject != null)
			{
				NsEffectManager.RunReplayEffect(gameObject, true);
			}
		}
	}

	private void GIAPAPFONAE(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.get_Instance().RemoveActor(get_m_actor());
	}

	private void DCGNEDBKNHP(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.get_Instance().GHDNOCIGGLB(get_m_actor());
	}

	public override void Awake()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		m_elapsedTime = 0f;
		FMELJBDGJKL = 0f;
	}

	private void AFEJNEHBIPB(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
	}

	private void IAEJDLCFJID(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.GBFDGAFALIL().GHDNOCIGGLB(get_m_actor());
	}

	public virtual bool ENADBEFKLFC()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Attack)
		{
			return false;
		}
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), m_attackRange, true, true, Actor.IJJMDPGJAEM.Unknown);
		if ((bool)(actorInRange = null))
		{
			return true;
		}
		actorInRange.OnAttackDamage(get_m_actor(), 95.0, 268.0, 1638.0);
		CLCEPBCJGEH(actorInRange.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO(m_damageSoundName, false, 335f, 1576f);
		return false;
	}

	public virtual bool NJNMBGLIJEJ()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Sleep)
		{
			return false;
		}
		Actor actor = ActorManager.GBFDGAFALIL().DCMODJADKEE(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)(-112));
		if ((bool)(actor = null))
		{
			return false;
		}
		actor.OnAttackDamage(get_m_actor(), 1271.0, 309.0, 872.0);
		CLCEPBCJGEH(actor.GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM(m_damageSoundName, true, 660f, 1349f);
		return true;
	}

	public virtual void NGNNLLLBGMB()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		m_elapsedTime = 1431f;
		FMELJBDGJKL = 1212f;
	}

	protected void CLCEPBCJGEH(Vector3 HEPNHCEIFMO, string NCADFOBAFJD)
	{
		if (string.IsNullOrEmpty(NCADFOBAFJD))
		{
			return;
		}
		GameObject gameObject = GameObjectPool.CPHPJPFECFL(string.Format(" 雕文", get_m_actor().get_m_resourceName(), NCADFOBAFJD), HEPNHCEIFMO, Quaternion.identity, (GameObject HCKCCHPJOPI) =>
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

	private void OAIIHHACFHB(GameObject HCKCCHPJOPI)
	{
		FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
		if (component != null)
		{
			component.m_targetRoot = get_m_actor().gameObject;
			component.m_direction = DGBKMAGBJJF.m_direction;
		}
	}

	[CompilerGenerated]
	private void PLBAOGDCKJO(GameObject HCKCCHPJOPI)
	{
		FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
		if (component != null)
		{
			component.m_targetRoot = get_m_actor().gameObject;
			component.m_direction = DGBKMAGBJJF.m_direction;
		}
	}

	public virtual void GNGJFGMJLHA()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		m_elapsedTime = 1457f;
		FMELJBDGJKL = 898f;
	}

	protected virtual void PHMAGJBFFEP(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		m_elapsedTime += get_m_actor().get_m_elapsedTime();
		if (m_elapsedTime >= m_delayTime)
		{
			DGBKMAGBJJF.m_moveDirection = m_moveDirection;
			float num = m_maxDistance - FMELJBDGJKL;
			float num2 = DGBKMAGBJJF.Move(get_m_actor().m_moveSpeed, m_moveDirection, true, num);
			FMELJBDGJKL += num2;
			if (m_elapsedTime >= m_lifeTime || Attack() || (get_m_actor().m_moveSpeed > 0f && num <= 0f))
			{
				Death();
			}
		}
	}

	protected virtual void JLAJNHKCJDC(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		m_elapsedTime += get_m_actor().BILOHJAEGCG();
		if (m_elapsedTime >= m_delayTime)
		{
			DGBKMAGBJJF.m_moveDirection = m_moveDirection;
			float num = m_maxDistance - FMELJBDGJKL;
			float num2 = DGBKMAGBJJF.Move(get_m_actor().m_moveSpeed, m_moveDirection, false, num);
			FMELJBDGJKL += num2;
			if (m_elapsedTime >= m_lifeTime || ENADBEFKLFC() || (get_m_actor().m_moveSpeed > 858f && num <= 1194f))
			{
				BNBCIBGEGKP();
			}
		}
	}

	public virtual void Death()
	{
		ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
	}
}
