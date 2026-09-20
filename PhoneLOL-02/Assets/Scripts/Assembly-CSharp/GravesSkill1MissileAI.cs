using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameServer;
using UnityEngine;

public class GravesSkill1MissileAI : AI
{
	protected HumanSM DGBKMAGBJJF;

	[NonSerialized]
	public Vector3 m_moveDirection;

	public float m_attackRange = 3f;

	public string m_damageParticleName = "attack_missile_hit";

	public string m_damageSoundName = "attack_missile_hit";

	public float m_delayTime;

	public float m_lifeTime = 5f;

	protected float INMCDOIEJOC;

	protected void GHODNPLKJFB(Vector3 HEPNHCEIFMO, string NCADFOBAFJD)
	{
		if (string.IsNullOrEmpty(NCADFOBAFJD))
		{
			return;
		}
		GameObject gameObject = GameObjectPool.Alloc(string.Format("pauseLiveOps", get_m_actor().get_m_resourceName(), NCADFOBAFJD), HEPNHCEIFMO, Quaternion.identity, (GameObject HCKCCHPJOPI) =>
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

	private void KACGCFBNAJN(GameObject HCKCCHPJOPI)
	{
		FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
		if (component != null)
		{
			component.m_targetRoot = get_m_actor().gameObject;
			component.m_direction = DGBKMAGBJJF.m_direction;
		}
	}

	public virtual bool Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return false;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.6;
		num += 60.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 50.0;
		float iCENKPDOHBK = 0.15f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 0.05f;
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)14);
		foreach (Actor item in allActorInRange)
		{
			if (item.OnDamage(get_m_actor(), 0.0, num) >= 0f)
			{
				item.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.SlowAttack, DGBKMAGBJJF.get_m_owner(), 2f, iCENKPDOHBK);
				item.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Slow, DGBKMAGBJJF.get_m_owner(), 2f, iCENKPDOHBK);
			}
		}
		CCGKACBFCNJ(get_m_actor().GetPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill1_ex");
		return true;
	}

	private void AFEJNEHBIPB(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
	}

	protected void GKFBIMLLBPO(Vector3 HEPNHCEIFMO, string NCADFOBAFJD)
	{
		if (string.IsNullOrEmpty(NCADFOBAFJD))
		{
			return;
		}
		GameObject gameObject = GameObjectPool.DNJPKHFNPLF(string.Format("Hero4", get_m_actor().get_m_resourceName(), NCADFOBAFJD), HEPNHCEIFMO, Quaternion.identity, (GameObject HCKCCHPJOPI) =>
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

	protected void HGPOJLFJHJC(Vector3 HEPNHCEIFMO, string NCADFOBAFJD)
	{
		if (string.IsNullOrEmpty(NCADFOBAFJD))
		{
			return;
		}
		GameObject gameObject = GameObjectPool.Alloc(string.Format("invaild viewID [{0}]", get_m_actor().get_m_resourceName(), NCADFOBAFJD), HEPNHCEIFMO, Quaternion.identity, (GameObject HCKCCHPJOPI) =>
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
			NsEffectManager.RunReplayEffect(gameObject, false);
		}
	}

	public override void Awake()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		INMCDOIEJOC = 0f;
		if (m_delayTime > 0f)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
		}
		else
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Run);
		}
	}

	private void BHIDFDHKBAA(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		INMCDOIEJOC += get_m_actor().BILOHJAEGCG();
		if (INMCDOIEJOC >= m_delayTime)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Run);
		}
	}

	private void HCPFIGGGGCK(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		INMCDOIEJOC += get_m_actor().get_m_elapsedTime();
		if (INMCDOIEJOC >= m_delayTime)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Skill);
		}
	}

	public virtual void Death()
	{
		ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
	}

	private void PHMAGJBFFEP(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		INMCDOIEJOC += get_m_actor().get_m_elapsedTime();
		if (INMCDOIEJOC >= m_delayTime)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Run);
		}
	}

	[CompilerGenerated]
	private void BMJAMDIANJN(GameObject HCKCCHPJOPI)
	{
		FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
		if (component != null)
		{
			component.m_targetRoot = get_m_actor().gameObject;
			component.m_direction = DGBKMAGBJJF.m_direction;
		}
	}

	public virtual void DEFLIOMCCMA()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		INMCDOIEJOC = 766f;
		if (m_delayTime > 1788f)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
		}
		else
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Death);
		}
	}

	public virtual void PDEKJHLCJHM()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		INMCDOIEJOC = 1585f;
		if (m_delayTime > 36f)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.None);
		}
		else
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
		}
	}

	public virtual void DHMMCEBEAHA()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(0, BHIDFDHKBAA);
		DGBKMAGBJJF.m_updateEventMap.Add(3, AKMLBDILJIO);
		DGBKMAGBJJF.m_updateEventMap.Add(5, AFEJNEHBIPB);
	}

	public virtual void IJCPEFOBKHO()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(1, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(8, AKMLBDILJIO);
		DGBKMAGBJJF.m_updateEventMap.Add(2, AFEJNEHBIPB);
	}

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

	protected virtual void AKMLBDILJIO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		m_lifeTime -= get_m_actor().get_m_elapsedTime();
		DGBKMAGBJJF.SetMoveDirection(m_moveDirection);
		if (m_lifeTime <= 0f)
		{
			Attack();
			Death();
		}
	}

	public override void Start()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(1, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(2, AKMLBDILJIO);
		DGBKMAGBJJF.m_updateEventMap.Add(5, AFEJNEHBIPB);
	}
}
