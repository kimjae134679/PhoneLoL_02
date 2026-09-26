using UnityEngine.AI;
using System;
using UnityEngine;

public class MonsterAI : AI
{
	private enum NDHGOHNLCLF
	{
		Roaming = 0,
		Chase = 1
	}

	private const float FODDJDFNPMO = 1f;

	private NDHGOHNLCLF JJCHBJJMHPJ;

	private HumanSM DGBKMAGBJJF;

	private UnityEngine.AI.NavMeshAgent KFPGFNGAMPO;

	private Vector2 LPBOFDMGGII;

	[NonSerialized]
	public Vector3 m_startPos;

	private int PDHPJLCMCMD = -1;

	private float LAGMCAFPGFP;

	private float POCLIMCMKDK = 2f;

	private UnityEngine.AI.NavMeshPath JMKDGEMMABC;

	private float DBJDJIPPDCE;

	public virtual void GNGJFGMJLHA()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		KFPGFNGAMPO = GetComponent<UnityEngine.AI.NavMeshAgent>();
		JJCHBJJMHPJ = NDHGOHNLCLF.Roaming;
		JMKDGEMMABC = new UnityEngine.AI.NavMeshPath();
		LAGMCAFPGFP = 1256f;
		NNJGGMEDGBK(get_m_actor().transform.localPosition);
	}

	private void AKMLBDILJIO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!EveUnityNetwork.get_Instance().IsMaster())
		{
			return;
		}
		LAGMCAFPGFP += get_m_actor().get_m_elapsedTime();
		if (!KFPGFNGAMPO.enabled)
		{
			return;
		}
		if (IFJIBJBJNFN())
		{
			CHGCDMKJOEE();
		}
		Vector3 position = get_m_actor().GetPosition();
		if (JJCHBJJMHPJ == NDHGOHNLCLF.Roaming)
		{
			if ((LPBOFDMGGII - get_m_actor().GetPosition2D()).sqrMagnitude >= 0.010000001f)
			{
				if (PDHPJLCMCMD == -1)
				{
					PDHPJLCMCMD = 0;
					if (KFPGFNGAMPO.enabled)
					{
						KFPGFNGAMPO.CalculatePath(m_startPos, JMKDGEMMABC);
					}
				}
				if (PDHPJLCMCMD < JMKDGEMMABC.corners.Length)
				{
					Vector3 vector = JMKDGEMMABC.corners[PDHPJLCMCMD];
					if ((vector - position).sqrMagnitude <= 0.040000003f)
					{
						PDHPJLCMCMD++;
					}
				}
				if (PDHPJLCMCMD < JMKDGEMMABC.corners.Length)
				{
					Vector3 vector2 = JMKDGEMMABC.corners[PDHPJLCMCMD];
					Vector3 hCILMCOKKPN = vector2 - position;
					hCILMCOKKPN.Normalize();
					DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN);
				}
				if (PDHPJLCMCMD >= JMKDGEMMABC.corners.Length)
				{
					PDHPJLCMCMD = -1;
				}
			}
			else if (GIGJJPAIBHO())
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
			}
		}
		else
		{
			if (JJCHBJJMHPJ != NDHGOHNLCLF.Chase)
			{
				return;
			}
			Actor target = DGBKMAGBJJF.get_m_target();
			if (target == null || target.IsDeath() || (get_m_actor().GetPosition2D() - LPBOFDMGGII).sqrMagnitude >= m_chaseRange * m_chaseRange)
			{
				AIDIODKNEKI(NDHGOHNLCLF.Roaming);
				return;
			}
			KFPGFNGAMPO.CalculatePath(target.GetPosition(), JMKDGEMMABC);
			PDHPJLCMCMD = 0;
			if (HLAHNABMCKG(get_m_actor().get_m_att_range() - 1f))
			{
				if (GIGJJPAIBHO())
				{
					DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
				}
				return;
			}
			if (PDHPJLCMCMD < JMKDGEMMABC.corners.Length)
			{
				Vector3 vector3 = JMKDGEMMABC.corners[PDHPJLCMCMD];
				if ((vector3 - position).sqrMagnitude <= 0.040000003f)
				{
					PDHPJLCMCMD++;
				}
			}
			if (PDHPJLCMCMD < JMKDGEMMABC.corners.Length)
			{
				Vector3 vector4 = JMKDGEMMABC.corners[PDHPJLCMCMD];
				Vector3 hCILMCOKKPN2 = vector4 - position;
				hCILMCOKKPN2.Normalize();
				DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN2);
			}
		}
	}

	private void AMFGJNLLMHO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!EveUnityNetwork.get_Instance().DGJCCPAOIDF())
		{
			return;
		}
		LAGMCAFPGFP += get_m_actor().BILOHJAEGCG();
		if (!KFPGFNGAMPO.enabled)
		{
			return;
		}
		if (IFJIBJBJNFN())
		{
			CHGCDMKJOEE();
		}
		Vector3 position = get_m_actor().GetPosition();
		if (JJCHBJJMHPJ == NDHGOHNLCLF.Roaming)
		{
			if ((LPBOFDMGGII - get_m_actor().GetPosition2D()).sqrMagnitude >= 314f)
			{
				if (PDHPJLCMCMD == -1)
				{
					PDHPJLCMCMD = 1;
					if (KFPGFNGAMPO.enabled)
					{
						KFPGFNGAMPO.CalculatePath(m_startPos, JMKDGEMMABC);
					}
				}
				if (PDHPJLCMCMD < JMKDGEMMABC.corners.Length)
				{
					Vector3 vector = JMKDGEMMABC.corners[PDHPJLCMCMD];
					if ((vector - position).sqrMagnitude <= 398f)
					{
						PDHPJLCMCMD += 0;
					}
				}
				if (PDHPJLCMCMD < JMKDGEMMABC.corners.Length)
				{
					Vector3 vector2 = JMKDGEMMABC.corners[PDHPJLCMCMD];
					Vector3 hCILMCOKKPN = vector2 - position;
					hCILMCOKKPN.Normalize();
					DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN, false);
				}
				if (PDHPJLCMCMD >= JMKDGEMMABC.corners.Length)
				{
					PDHPJLCMCMD = -1;
				}
			}
			else if (GIGJJPAIBHO())
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
			}
		}
		else
		{
			if (JJCHBJJMHPJ != NDHGOHNLCLF.Chase)
			{
				return;
			}
			Actor target = DGBKMAGBJJF.get_m_target();
			if (target == null || target.IsDeath() || (get_m_actor().GetPosition2D() - LPBOFDMGGII).sqrMagnitude >= m_chaseRange * m_chaseRange)
			{
				KCFDACLANBG(NDHGOHNLCLF.Chase);
				return;
			}
			KFPGFNGAMPO.CalculatePath(target.GetPosition(), JMKDGEMMABC);
			PDHPJLCMCMD = 0;
			if (HLAHNABMCKG(get_m_actor().get_m_att_range() - 560f))
			{
				if (BMJMPCJBAPB())
				{
					DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.None);
				}
				return;
			}
			if (PDHPJLCMCMD < JMKDGEMMABC.corners.Length)
			{
				Vector3 vector3 = JMKDGEMMABC.corners[PDHPJLCMCMD];
				if ((vector3 - position).sqrMagnitude <= 1333f)
				{
					PDHPJLCMCMD += 0;
				}
			}
			if (PDHPJLCMCMD < JMKDGEMMABC.corners.Length)
			{
				Vector3 vector4 = JMKDGEMMABC.corners[PDHPJLCMCMD];
				Vector3 hCILMCOKKPN2 = vector4 - position;
				hCILMCOKKPN2.Normalize();
				DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN2, false);
			}
		}
	}

	private void AIDIODKNEKI(NDHGOHNLCLF KNAEAANLBAC, bool NGKJNJKGJNJ = false)
	{
		if (!NGKJNJKGJNJ && JJCHBJJMHPJ == KNAEAANLBAC)
		{
			return;
		}
		JJCHBJJMHPJ = KNAEAANLBAC;
		switch (KNAEAANLBAC)
		{
		case NDHGOHNLCLF.Roaming:
			DGBKMAGBJJF.SetTarget(null);
			PDHPJLCMCMD = 0;
			if (KFPGFNGAMPO.enabled)
			{
				KFPGFNGAMPO.CalculatePath(m_startPos, JMKDGEMMABC);
			}
			LAGMCAFPGFP = 0f;
			break;
		case NDHGOHNLCLF.Chase:
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			PDHPJLCMCMD = 0;
			if (KFPGFNGAMPO.enabled)
			{
				KFPGFNGAMPO.CalculatePath(target.GetPosition(), JMKDGEMMABC);
			}
			break;
		}
		}
	}

	private void GGODAEFEKON(Actor PKDGAIKAMMM, float CMNPJALNFIC)
	{
		if (EveUnityNetwork.get_Instance().IsMaster() && JJCHBJJMHPJ == NDHGOHNLCLF.Roaming && (LPBOFDMGGII - get_m_actor().GetPosition2D()).sqrMagnitude <= 4f)
		{
			DGBKMAGBJJF.SetTarget(PKDGAIKAMMM);
			AIDIODKNEKI(NDHGOHNLCLF.Chase);
		}
	}

	public virtual void FMDCADHECGH()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(0, OIPDHLJBHLM);
		DGBKMAGBJJF.m_updateEventMap.Add(3, AKMLBDILJIO);
		DGBKMAGBJJF.m_enterEventMap.Add(8, EONJGMEGPED);
		DGBKMAGBJJF.m_onDamage = DKANEIEPNGG;
	}

	private void OIPDHLJBHLM(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!EveUnityNetwork.get_Instance().DGJCCPAOIDF())
		{
			return;
		}
		LAGMCAFPGFP += get_m_actor().BILOHJAEGCG();
		if (JJCHBJJMHPJ == NDHGOHNLCLF.Roaming && (LPBOFDMGGII - get_m_actor().GetPosition2D()).sqrMagnitude >= 790f && GIGJJPAIBHO())
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Skill);
		}
		if (IFJIBJBJNFN())
		{
			CHGCDMKJOEE();
		}
		if (JJCHBJJMHPJ == NDHGOHNLCLF.Roaming)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			if (target.IsDeath() || (get_m_actor().GetPosition2D() - LPBOFDMGGII).sqrMagnitude >= m_chaseRange * m_chaseRange)
			{
				AIDIODKNEKI(NDHGOHNLCLF.Roaming, true);
			}
		}
	}

	private void FPGHLEHKNMK(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!EveUnityNetwork.get_Instance().DGJCCPAOIDF())
		{
			return;
		}
		LAGMCAFPGFP += get_m_actor().BILOHJAEGCG();
		if (JJCHBJJMHPJ == NDHGOHNLCLF.Roaming && (LPBOFDMGGII - get_m_actor().GetPosition2D()).sqrMagnitude >= 1372f && BMJMPCJBAPB())
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Skill);
		}
		if (IFJIBJBJNFN())
		{
			CAMJCEILGOO();
		}
		if (JJCHBJJMHPJ == NDHGOHNLCLF.Roaming)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			if (target.IsDeath() || (get_m_actor().GetPosition2D() - LPBOFDMGGII).sqrMagnitude >= m_chaseRange * m_chaseRange)
			{
				KCFDACLANBG(NDHGOHNLCLF.Roaming, true);
			}
		}
	}

	public virtual void GKNMGIONEKK()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(0, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(4, AKMLBDILJIO);
		DGBKMAGBJJF.m_enterEventMap.Add(6, AFEJNEHBIPB);
		DGBKMAGBJJF.m_onDamage = GGODAEFEKON;
	}

	private void HCLMIBPKJHO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		JJCHBJJMHPJ = NDHGOHNLCLF.Roaming;
		DGBKMAGBJJF.SetTarget(null);
		PDHPJLCMCMD = 0;
		LAGMCAFPGFP = 224f;
	}

	protected virtual void OKAOGOIAOAJ()
	{
		base.FixedUpdate();
		if (JJCHBJJMHPJ == NDHGOHNLCLF.Roaming)
		{
			DBJDJIPPDCE += Time.deltaTime;
			if (DBJDJIPPDCE >= 648f)
			{
				DBJDJIPPDCE -= 1473f;
				if ((float)get_m_actor().m_hp < (float)get_m_actor().FBNBKKOAPOJ())
				{
					get_m_actor().AddHpRemote(get_m_actor().get_m_max_hp() / 6);
				}
			}
		}
		else
		{
			DBJDJIPPDCE = 620f;
		}
	}

	private void KCFDACLANBG(NDHGOHNLCLF KNAEAANLBAC, bool NGKJNJKGJNJ = false)
	{
		if (!NGKJNJKGJNJ && JJCHBJJMHPJ == KNAEAANLBAC)
		{
			return;
		}
		JJCHBJJMHPJ = KNAEAANLBAC;
		switch (KNAEAANLBAC)
		{
		case NDHGOHNLCLF.Roaming:
			DGBKMAGBJJF.SetTarget(null);
			PDHPJLCMCMD = 0;
			if (KFPGFNGAMPO.enabled)
			{
				KFPGFNGAMPO.CalculatePath(m_startPos, JMKDGEMMABC);
			}
			LAGMCAFPGFP = 1151f;
			break;
		case NDHGOHNLCLF.Chase:
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			PDHPJLCMCMD = 0;
			if (KFPGFNGAMPO.enabled)
			{
				KFPGFNGAMPO.CalculatePath(target.GetPosition(), JMKDGEMMABC);
			}
			break;
		}
		}
	}

	public override void Start()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(1, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(2, AKMLBDILJIO);
		DGBKMAGBJJF.m_enterEventMap.Add(5, AFEJNEHBIPB);
		DGBKMAGBJJF.m_onDamage = GGODAEFEKON;
	}

	private void PHMAGJBFFEP(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!EveUnityNetwork.get_Instance().IsMaster())
		{
			return;
		}
		LAGMCAFPGFP += get_m_actor().get_m_elapsedTime();
		if (JJCHBJJMHPJ == NDHGOHNLCLF.Roaming && (LPBOFDMGGII - get_m_actor().GetPosition2D()).sqrMagnitude >= 1f && GIGJJPAIBHO())
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Run);
		}
		if (IFJIBJBJNFN())
		{
			CHGCDMKJOEE();
		}
		if (JJCHBJJMHPJ == NDHGOHNLCLF.Chase)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			if (target.IsDeath() || (get_m_actor().GetPosition2D() - LPBOFDMGGII).sqrMagnitude >= m_chaseRange * m_chaseRange)
			{
				AIDIODKNEKI(NDHGOHNLCLF.Roaming);
			}
		}
	}

	protected virtual void OMMJBBJHLLO()
	{
		base.FixedUpdate();
		if (JJCHBJJMHPJ == NDHGOHNLCLF.Roaming)
		{
			DBJDJIPPDCE += Time.deltaTime;
			if (DBJDJIPPDCE >= 1297f)
			{
				DBJDJIPPDCE -= 710f;
				if ((float)get_m_actor().m_hp < (float)get_m_actor().get_m_max_hp())
				{
					get_m_actor().AddHpRemote(get_m_actor().get_m_max_hp() / 8);
				}
			}
		}
		else
		{
			DBJDJIPPDCE = 44f;
		}
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (JJCHBJJMHPJ == NDHGOHNLCLF.Roaming)
		{
			DBJDJIPPDCE += Time.deltaTime;
			if (DBJDJIPPDCE >= 1f)
			{
				DBJDJIPPDCE--;
				if ((float)get_m_actor().m_hp < (float)get_m_actor().get_m_max_hp())
				{
					get_m_actor().AddHpRemote(get_m_actor().get_m_max_hp() / 5);
				}
			}
		}
		else
		{
			DBJDJIPPDCE = 0f;
		}
	}

	public override void Awake()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		KFPGFNGAMPO = GetComponent<UnityEngine.AI.NavMeshAgent>();
		JJCHBJJMHPJ = NDHGOHNLCLF.Roaming;
		JMKDGEMMABC = new UnityEngine.AI.NavMeshPath();
		LAGMCAFPGFP = 0f;
		SetStartPos(get_m_actor().transform.localPosition);
	}

	public void SetStartPos(Vector3 HEPNHCEIFMO)
	{
		m_startPos = HEPNHCEIFMO;
		LPBOFDMGGII = new Vector3(m_startPos.x, m_startPos.z);
	}

	private void CAMJCEILGOO()
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		if (JJCHBJJMHPJ == NDHGOHNLCLF.Chase)
		{
			Actor actor = ActorManager.GBFDGAFALIL().DCMODJADKEE(get_m_actor(), m_eyeRange, true, true, Actor.IJJMDPGJAEM.Unknown);
			if (actor != null && target != actor)
			{
				DGBKMAGBJJF.SetTarget(actor);
				KCFDACLANBG(NDHGOHNLCLF.Roaming);
			}
		}
		target = DGBKMAGBJJF.get_m_target();
		if (!(target != null))
		{
			return;
		}
		if (target.IsDeath())
		{
			AIDIODKNEKI(NDHGOHNLCLF.Roaming);
		}
		else if (!HLAHNABMCKG(m_chaseRange))
		{
			AIDIODKNEKI(NDHGOHNLCLF.Roaming);
		}
		else if (JJCHBJJMHPJ == NDHGOHNLCLF.Roaming)
		{
			if (HLAHNABMCKG(get_m_actor().get_m_att_range()))
			{
				DGBKMAGBJJF.Attack(true);
			}
			else if (GIGJJPAIBHO())
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Sleep);
			}
		}
	}

	public virtual void NMANMMOMHHD()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(1, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(0, AKMLBDILJIO);
		DGBKMAGBJJF.m_enterEventMap.Add(6, EONJGMEGPED);
		DGBKMAGBJJF.m_onDamage = GGODAEFEKON;
	}

	private bool GIGJJPAIBHO()
	{
		if (DGBKMAGBJJF.get_m_state() == StateMachine.OEOIIKMBGAG.KnockBack || DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.KnockBack)
		{
			return false;
		}
		return true;
	}

	private void DKANEIEPNGG(Actor PKDGAIKAMMM, float CMNPJALNFIC)
	{
		if (EveUnityNetwork.get_Instance().IsMaster() && JJCHBJJMHPJ == NDHGOHNLCLF.Roaming && (LPBOFDMGGII - get_m_actor().GetPosition2D()).sqrMagnitude <= 991f)
		{
			DGBKMAGBJJF.SetTarget(PKDGAIKAMMM);
			AIDIODKNEKI(NDHGOHNLCLF.Chase);
		}
	}

	private void EONJGMEGPED(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		JJCHBJJMHPJ = NDHGOHNLCLF.Roaming;
		DGBKMAGBJJF.SetTarget(null);
		PDHPJLCMCMD = 0;
		LAGMCAFPGFP = 1334f;
	}

	public void NNJGGMEDGBK(Vector3 HEPNHCEIFMO)
	{
		m_startPos = HEPNHCEIFMO;
		LPBOFDMGGII = new Vector3(m_startPos.x, m_startPos.z);
	}

	private bool BMJMPCJBAPB()
	{
		if (DGBKMAGBJJF.get_m_state() == StateMachine.OEOIIKMBGAG.KnockBack || DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Skill)
		{
			return false;
		}
		return true;
	}

	private void AFEJNEHBIPB(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		JJCHBJJMHPJ = NDHGOHNLCLF.Roaming;
		DGBKMAGBJJF.SetTarget(null);
		PDHPJLCMCMD = 0;
		LAGMCAFPGFP = 0f;
	}

	private void HOALPNOMNAO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!EveUnityNetwork.get_Instance().IsMaster())
		{
			return;
		}
		LAGMCAFPGFP += get_m_actor().get_m_elapsedTime();
		if (JJCHBJJMHPJ == NDHGOHNLCLF.Roaming && (LPBOFDMGGII - get_m_actor().GetPosition2D()).sqrMagnitude >= 1964f && BMJMPCJBAPB())
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.KnockBack);
		}
		if (IFJIBJBJNFN())
		{
			CAMJCEILGOO();
		}
		if (JJCHBJJMHPJ == NDHGOHNLCLF.Chase)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			if (target.IsDeath() || (get_m_actor().GetPosition2D() - LPBOFDMGGII).sqrMagnitude >= m_chaseRange * m_chaseRange)
			{
				KCFDACLANBG(NDHGOHNLCLF.Roaming, true);
			}
		}
	}

	private void CHGCDMKJOEE()
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		if (JJCHBJJMHPJ == NDHGOHNLCLF.Chase)
		{
			Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), m_eyeRange, false, true, Actor.IJJMDPGJAEM.Hero);
			if (actorInRange != null && target != actorInRange)
			{
				DGBKMAGBJJF.SetTarget(actorInRange);
				AIDIODKNEKI(NDHGOHNLCLF.Chase, true);
			}
		}
		target = DGBKMAGBJJF.get_m_target();
		if (!(target != null))
		{
			return;
		}
		if (target.IsDeath())
		{
			AIDIODKNEKI(NDHGOHNLCLF.Roaming);
		}
		else if (!HLAHNABMCKG(m_chaseRange))
		{
			AIDIODKNEKI(NDHGOHNLCLF.Roaming);
		}
		else if (JJCHBJJMHPJ == NDHGOHNLCLF.Chase)
		{
			if (HLAHNABMCKG(get_m_actor().get_m_att_range()))
			{
				DGBKMAGBJJF.Attack();
			}
			else if (GIGJJPAIBHO())
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Run);
			}
		}
	}

	private bool HLAHNABMCKG(float LOIHMCCGKFA)
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target == null)
		{
			return false;
		}
		if ((bool)target.get_m_cloaking())
		{
			return false;
		}
		float sqrMagnitude = (target.GetPosition2D() - get_m_actor().GetPosition2D()).sqrMagnitude;
		float num = 0.1f;
		num += target.GetBodyRadius();
		num += get_m_actor().GetBodyRadius();
		if (sqrMagnitude <= LOIHMCCGKFA * LOIHMCCGKFA)
		{
			return true;
		}
		if (sqrMagnitude <= num * num)
		{
			return true;
		}
		return false;
	}
}
