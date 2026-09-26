using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("ProjectT/AI/ThruMissileAI")]
public class ThruMissileAI : AI
{
	public delegate void OOCMBMKFNCJ(Actor LPOAEBNAGCP);

	protected HumanSM DGBKMAGBJJF;

	[NonSerialized]
	public Vector3 m_moveDirection;

	public float m_attackRange = 1f;

	public string m_damageParticleName = "attack_missile_hit";

	public string m_damageSoundName = "attack_missile_hit";

	public float m_delayTime;

	public float m_lifeTime = 5f;

	protected float INMCDOIEJOC;

	protected LinkedList<Actor> MIGJCNCIEHN = new LinkedList<Actor>();

	[NonSerialized]
	public OOCMBMKFNCJ m_onTargetAttack;

	private void HHGMJONECNJ(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		INMCDOIEJOC += get_m_actor().get_m_elapsedTime();
		if (INMCDOIEJOC >= m_delayTime)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Skill);
		}
	}

	private void JLAJNHKCJDC(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		INMCDOIEJOC += get_m_actor().BILOHJAEGCG();
		if (INMCDOIEJOC >= m_delayTime)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.None);
		}
	}

	public virtual void PAKIFAGJDEO()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(0, HHGMJONECNJ);
		DGBKMAGBJJF.m_updateEventMap.Add(3, AKMLBDILJIO);
		DGBKMAGBJJF.m_updateEventMap.Add(5, AFEJNEHBIPB);
		MIGJCNCIEHN.Clear();
	}

	public virtual void Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return;
		}
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)14);
		foreach (Actor item in allActorInRange)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				item.OnAttackDamage(get_m_actor());
				MIGJCNCIEHN.AddFirst(item);
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName);
				if (m_onTargetAttack != null)
				{
					m_onTargetAttack(item);
				}
			}
		}
	}

	public virtual void EDFFKDICHBF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return;
		}
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), m_attackRange, true, true, (Actor.IJJMDPGJAEM)23);
		foreach (Actor item in allActorInRange)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				item.OnAttackDamage(get_m_actor(), 1818.0, 184.0, 1730.0);
				MIGJCNCIEHN.AddFirst(item);
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName, true, 1707f, 845f);
				if (m_onTargetAttack != null)
				{
					m_onTargetAttack(item);
				}
			}
		}
	}

	public bool OJKDAJMECFA(Actor CDKMPAEODLA)
	{
		return MIGJCNCIEHN.Contains(CDKMPAEODLA);
	}

	public virtual void ENADBEFKLFC()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Idle)
		{
			return;
		}
		List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), m_attackRange, true, false, (Actor.IJJMDPGJAEM)(-78));
		foreach (Actor item in list)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				item.OnAttackDamage(get_m_actor(), 1316.0, 1261.0, 1620.0);
				MIGJCNCIEHN.AddFirst(item);
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM(m_damageSoundName, true, 1544f, 588f);
				if (m_onTargetAttack != null)
				{
					m_onTargetAttack(item);
				}
			}
		}
	}

	public virtual void MADPEEGGCLD()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		INMCDOIEJOC = 1146f;
		if (m_delayTime > 334f)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
		}
		else
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Run);
		}
	}

	public virtual void ACGJAOOJGIN()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		INMCDOIEJOC = 1366f;
		if (m_delayTime > 160f)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.None);
		}
		else
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
		}
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

	public bool IsAttacked(Actor CDKMPAEODLA)
	{
		return MIGJCNCIEHN.Contains(CDKMPAEODLA);
	}

	public virtual void FOFKFKIEGHH()
	{
		ActorManager.get_Instance().GHDNOCIGGLB(get_m_actor(), true);
	}

	public virtual void GNGJFGMJLHA()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		INMCDOIEJOC = 42f;
		if (m_delayTime > 1132f)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.None);
		}
		else
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
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

	public virtual void GABLBKCDMIA()
	{
		ActorManager.GBFDGAFALIL().RemoveActor(get_m_actor(), true);
	}

	public override void Start()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(1, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(2, AKMLBDILJIO);
		DGBKMAGBJJF.m_updateEventMap.Add(5, AFEJNEHBIPB);
		MIGJCNCIEHN.Clear();
	}

	private void POFMFIINAMG(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		INMCDOIEJOC += get_m_actor().BILOHJAEGCG();
		if (INMCDOIEJOC >= m_delayTime)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
		}
	}

	private void AFEJNEHBIPB(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
	}

	protected virtual void AKMLBDILJIO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		m_lifeTime -= get_m_actor().get_m_elapsedTime();
		DGBKMAGBJJF.SetMoveDirection(m_moveDirection);
		if (m_lifeTime <= 0f)
		{
			Death();
		}
		else
		{
			Attack();
		}
	}

	private void PHMAGJBFFEP(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		INMCDOIEJOC += get_m_actor().get_m_elapsedTime();
		if (INMCDOIEJOC >= m_delayTime)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Run);
		}
	}

	public virtual void Death()
	{
		ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
	}

	public bool KKJMFHPKOIN(Actor CDKMPAEODLA)
	{
		return MIGJCNCIEHN.Contains(CDKMPAEODLA);
	}

	public virtual void NJNMBGLIJEJ()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.KnockBack)
		{
			return;
		}
		List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), m_attackRange, true, true, (Actor.IJJMDPGJAEM)(-44), false);
		foreach (Actor item in allActorInRange)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				item.OnAttackDamage(get_m_actor(), 1095.0, 249.0, 1916.0);
				MIGJCNCIEHN.AddFirst(item);
				PHDAPEOBFIN(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB(m_damageSoundName, true, 458f, 1014f);
				if (m_onTargetAttack != null)
				{
					m_onTargetAttack(item);
				}
			}
		}
	}

	public bool LHBHMEEDFCC(Actor CDKMPAEODLA)
	{
		return MIGJCNCIEHN.Contains(CDKMPAEODLA);
	}

	[CompilerGenerated]
	private void FEDKAAMAEEF(GameObject HCKCCHPJOPI)
	{
		FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
		if (component != null)
		{
			component.m_targetRoot = get_m_actor().gameObject;
			component.m_direction = DGBKMAGBJJF.m_direction;
		}
	}

	public virtual void DHPBFHNFBCN()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Run)
		{
			return;
		}
		List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), m_attackRange, true, true, (Actor.IJJMDPGJAEM)(-64));
		foreach (Actor item in list)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				item.OnAttackDamage(get_m_actor(), 1745.0, 1061.0, 488.0);
				MIGJCNCIEHN.AddFirst(item);
				PHDAPEOBFIN(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName, true, 618f, 754f);
				if (m_onTargetAttack != null)
				{
					m_onTargetAttack(item);
				}
			}
		}
	}

	private void ALFDDELAIEJ(GameObject HCKCCHPJOPI)
	{
		FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
		if (component != null)
		{
			component.m_targetRoot = get_m_actor().gameObject;
			component.m_direction = DGBKMAGBJJF.m_direction;
		}
	}

	public bool EGMKLLPNNED(Actor CDKMPAEODLA)
	{
		return MIGJCNCIEHN.Contains(CDKMPAEODLA);
	}

	public bool IOGGKJGCMIH(Actor CDKMPAEODLA)
	{
		return MIGJCNCIEHN.Contains(CDKMPAEODLA);
	}

	private void HOALPNOMNAO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		INMCDOIEJOC += get_m_actor().get_m_elapsedTime();
		if (INMCDOIEJOC >= m_delayTime)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Attack);
		}
	}

	public virtual void DOHJCDCAFFG()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Skill)
		{
			return;
		}
		List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), m_attackRange, true, false, (Actor.IJJMDPGJAEM)101);
		foreach (Actor item in list)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				item.OnAttackDamage(get_m_actor(), 542.0, 1996.0, 43.0);
				MIGJCNCIEHN.AddFirst(item);
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName, true, 1980f, 1821f);
				if (m_onTargetAttack != null)
				{
					m_onTargetAttack(item);
				}
			}
		}
	}

	public virtual void PAJOOFIAPMI()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(0, JLAJNHKCJDC);
		DGBKMAGBJJF.m_updateEventMap.Add(1, AKMLBDILJIO);
		DGBKMAGBJJF.m_updateEventMap.Add(3, AFEJNEHBIPB);
		MIGJCNCIEHN.Clear();
	}

	private void BPHMHKMHBDI(GameObject HCKCCHPJOPI)
	{
		FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
		if (component != null)
		{
			component.m_targetRoot = get_m_actor().gameObject;
			component.m_direction = DGBKMAGBJJF.m_direction;
		}
	}

	protected void PHDAPEOBFIN(Vector3 HEPNHCEIFMO, string NCADFOBAFJD)
	{
		if (!string.IsNullOrEmpty(NCADFOBAFJD))
		{
			GameObject gameObject = GameObjectPool.DNJPKHFNPLF(string.Format("\"", get_m_actor().get_m_resourceName(), NCADFOBAFJD), HEPNHCEIFMO, Quaternion.identity, ALFDDELAIEJ);
			if (gameObject != null)
			{
				NsEffectManager.RunReplayEffect(gameObject, false);
			}
		}
	}
}
