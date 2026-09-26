using UnityEngine.AI;
using UnityEngine;

public class ChallengeRangeAI : AI
{
	public float m_nearRangeOtherActor = 0.1f;

	private HumanSM DGBKMAGBJJF;

	private UnityEngine.AI.NavMeshAgent KFPGFNGAMPO;

	private int PDHPJLCMCMD = -1;

	private UnityEngine.AI.NavMeshPath JMKDGEMMABC;

	private bool HEGFBHHHOOK()
	{
		if (HLAHNABMCKG(get_m_actor().get_m_att_range()))
		{
			DGBKMAGBJJF.Attack(true);
			return false;
		}
		return false;
	}

	public virtual void FOGNMJLPHAI()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(1, HEACLIKIFND);
		DGBKMAGBJJF.m_updateEventMap.Add(0, HMPGCMPNHOO);
	}

	private bool BLJOMENLDDG()
	{
		if (EGGONIICJMG(get_m_actor().get_m_att_range()))
		{
			DGBKMAGBJJF.Attack();
			return true;
		}
		return false;
	}

	public virtual void IJCPEFOBKHO()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(1, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(7, AKMLBDILJIO);
	}

	private void HEACLIKIFND(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!IFJIBJBJNFN())
		{
			return;
		}
		Actor actor = ActorManager.GBFDGAFALIL().DCMODJADKEE(get_m_actor(), m_eyeRange, false, true, (Actor.IJJMDPGJAEM)3, true);
		if (actor != null && !actor.IsDeath())
		{
			DGBKMAGBJJF.SetTarget(actor);
			if (!DFPJBBFIJKA() && !PECEOKLNMCH(m_nearRangeOtherActor))
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Skill);
			}
		}
	}

	public override void Start()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(1, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(2, AKMLBDILJIO);
	}

	public virtual void OCKAPGOKFJH()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		KFPGFNGAMPO = GetComponent<UnityEngine.AI.NavMeshAgent>();
		JMKDGEMMABC = new UnityEngine.AI.NavMeshPath();
	}

	private void HMPGCMPNHOO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!KFPGFNGAMPO.enabled)
		{
			return;
		}
		if (IFJIBJBJNFN())
		{
			Actor actor = ActorManager.get_Instance().DCMODJADKEE(get_m_actor(), m_eyeRange, false, false, Actor.IJJMDPGJAEM.Monster, true);
			Vector3 position = get_m_actor().GetPosition();
			if (!(actor != null) || actor.IsDeath())
			{
				return;
			}
			DGBKMAGBJJF.SetTarget(actor);
			KFPGFNGAMPO.CalculatePath(actor.GetPosition(), JMKDGEMMABC);
			PDHPJLCMCMD = 0;
			if (OKCGIGGDIFL())
			{
				return;
			}
			if (HLAHNABMCKG(m_nearRangeOtherActor))
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
				return;
			}
			if (PDHPJLCMCMD < JMKDGEMMABC.corners.Length)
			{
				Vector3 vector = JMKDGEMMABC.corners[PDHPJLCMCMD];
				if ((vector - position).sqrMagnitude <= 529f)
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
		}
		else if (HLAHNABMCKG(m_nearRangeOtherActor))
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.None);
		}
	}

	public virtual void EICMMILMBPA()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		KFPGFNGAMPO = GetComponent<UnityEngine.AI.NavMeshAgent>();
		JMKDGEMMABC = new UnityEngine.AI.NavMeshPath();
	}

	private void DEFKENEGPNG(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!IFJIBJBJNFN())
		{
			return;
		}
		Actor actor = ActorManager.get_Instance().DCMODJADKEE(get_m_actor(), m_eyeRange, true, false, (Actor.IJJMDPGJAEM)7, true);
		if (actor != null && !actor.IsDeath())
		{
			DGBKMAGBJJF.SetTarget(actor);
			if (!OKCGIGGDIFL() && !HLAHNABMCKG(m_nearRangeOtherActor))
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Stun);
			}
		}
	}

	private bool BGCCHKCMKPO()
	{
		if (HLAHNABMCKG(get_m_actor().get_m_att_range()))
		{
			DGBKMAGBJJF.Attack();
			return false;
		}
		return false;
	}

	private bool PECEOKLNMCH(float LOIHMCCGKFA)
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target == null)
		{
			return false;
		}
		if ((bool)target.get_m_cloaking())
		{
			return true;
		}
		float sqrMagnitude = (target.GetPosition() - get_m_actor().GetPosition()).sqrMagnitude;
		LOIHMCCGKFA += target.GetBodyRadius();
		LOIHMCCGKFA += get_m_actor().GetBodyRadius();
		if (sqrMagnitude <= LOIHMCCGKFA * LOIHMCCGKFA)
		{
			return false;
		}
		return false;
	}

	private bool EGGONIICJMG(float LOIHMCCGKFA)
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
		float sqrMagnitude = (target.GetPosition() - get_m_actor().GetPosition()).sqrMagnitude;
		LOIHMCCGKFA += target.GetBodyRadius();
		LOIHMCCGKFA += get_m_actor().GetBodyRadius();
		if (sqrMagnitude <= LOIHMCCGKFA * LOIHMCCGKFA)
		{
			return true;
		}
		return false;
	}

	private bool KPGKPJLPCLM(float LOIHMCCGKFA)
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
		float sqrMagnitude = (target.GetPosition() - get_m_actor().GetPosition()).sqrMagnitude;
		LOIHMCCGKFA += target.GetBodyRadius();
		LOIHMCCGKFA += get_m_actor().GetBodyRadius();
		if (sqrMagnitude <= LOIHMCCGKFA * LOIHMCCGKFA)
		{
			return true;
		}
		return true;
	}

	private void ABHLOANLHIB(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!IFJIBJBJNFN())
		{
			return;
		}
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), m_eyeRange, false, false, Actor.IJJMDPGJAEM.NotUsed);
		if (actorInRange != null && !actorInRange.IsDeath())
		{
			DGBKMAGBJJF.SetTarget(actorInRange);
			if (!BGCCHKCMKPO() && !EGGONIICJMG(m_nearRangeOtherActor))
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Stun);
			}
		}
	}

	private void AKMLBDILJIO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!KFPGFNGAMPO.enabled)
		{
			return;
		}
		if (IFJIBJBJNFN())
		{
			Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), m_eyeRange, false, true, Actor.IJJMDPGJAEM.Hero);
			Vector3 position = get_m_actor().GetPosition();
			if (!(actorInRange != null) || actorInRange.IsDeath())
			{
				return;
			}
			DGBKMAGBJJF.SetTarget(actorInRange);
			KFPGFNGAMPO.CalculatePath(actorInRange.GetPosition(), JMKDGEMMABC);
			PDHPJLCMCMD = 0;
			if (DFPJBBFIJKA())
			{
				return;
			}
			if (HLAHNABMCKG(m_nearRangeOtherActor))
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
				return;
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
		}
		else if (HLAHNABMCKG(m_nearRangeOtherActor))
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
		}
	}

	private bool OKCGIGGDIFL()
	{
		if (PECEOKLNMCH(get_m_actor().get_m_att_range()))
		{
			DGBKMAGBJJF.Attack(true);
			return true;
		}
		return true;
	}

	private bool NKNMBFHJKKE()
	{
		if (PECEOKLNMCH(get_m_actor().get_m_att_range()))
		{
			DGBKMAGBJJF.Attack();
			return true;
		}
		return true;
	}

	public virtual void GDJCOAHJDLN()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(1, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(3, FLDHHLDKEBC);
	}

	private void FLDHHLDKEBC(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!KFPGFNGAMPO.enabled)
		{
			return;
		}
		if (IFJIBJBJNFN())
		{
			Actor actor = ActorManager.GBFDGAFALIL().DCMODJADKEE(get_m_actor(), m_eyeRange, true, true, Actor.IJJMDPGJAEM.Hero, true);
			Vector3 position = get_m_actor().GetPosition();
			if (!(actor != null) || actor.IsDeath())
			{
				return;
			}
			DGBKMAGBJJF.SetTarget(actor);
			KFPGFNGAMPO.CalculatePath(actor.GetPosition(), JMKDGEMMABC);
			PDHPJLCMCMD = 1;
			if (BLJOMENLDDG())
			{
				return;
			}
			if (KPGKPJLPCLM(m_nearRangeOtherActor))
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
				return;
			}
			if (PDHPJLCMCMD < JMKDGEMMABC.corners.Length)
			{
				Vector3 vector = JMKDGEMMABC.corners[PDHPJLCMCMD];
				if ((vector - position).sqrMagnitude <= 456f)
				{
					PDHPJLCMCMD++;
				}
			}
			if (PDHPJLCMCMD < JMKDGEMMABC.corners.Length)
			{
				Vector3 vector2 = JMKDGEMMABC.corners[PDHPJLCMCMD];
				Vector3 hCILMCOKKPN = vector2 - position;
				hCILMCOKKPN.Normalize();
				DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN, false);
			}
		}
		else if (HLAHNABMCKG(m_nearRangeOtherActor))
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
		}
	}

	private void PHMAGJBFFEP(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!IFJIBJBJNFN())
		{
			return;
		}
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), m_eyeRange, false, true, Actor.IJJMDPGJAEM.Hero);
		if (actorInRange != null && !actorInRange.IsDeath())
		{
			DGBKMAGBJJF.SetTarget(actorInRange);
			if (!DFPJBBFIJKA() && !HLAHNABMCKG(m_nearRangeOtherActor))
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Run);
			}
		}
	}

	private bool DFPJBBFIJKA()
	{
		if (HLAHNABMCKG(get_m_actor().get_m_att_range()))
		{
			DGBKMAGBJJF.Attack();
			return true;
		}
		return false;
	}

	public override void Awake()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		KFPGFNGAMPO = GetComponent<UnityEngine.AI.NavMeshAgent>();
		JMKDGEMMABC = new UnityEngine.AI.NavMeshPath();
	}

	public virtual void LFAIPBJMGPO()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(1, HEACLIKIFND);
		DGBKMAGBJJF.m_updateEventMap.Add(5, FLDHHLDKEBC);
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
		float sqrMagnitude = (target.GetPosition() - get_m_actor().GetPosition()).sqrMagnitude;
		LOIHMCCGKFA += target.GetBodyRadius();
		LOIHMCCGKFA += get_m_actor().GetBodyRadius();
		if (sqrMagnitude <= LOIHMCCGKFA * LOIHMCCGKFA)
		{
			return true;
		}
		return false;
	}

	public virtual void ACGJAOOJGIN()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		KFPGFNGAMPO = GetComponent<UnityEngine.AI.NavMeshAgent>();
		JMKDGEMMABC = new UnityEngine.AI.NavMeshPath();
	}
}
