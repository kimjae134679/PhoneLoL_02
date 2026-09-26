using UnityEngine.AI;
using UnityEngine;

public class ChallengeMeleeAI : AI
{
	public float m_nearRangeOtherActor = 0.1f;

	private HumanSM DGBKMAGBJJF;

	private UnityEngine.AI.NavMeshAgent KFPGFNGAMPO;

	private int PDHPJLCMCMD = -1;

	private UnityEngine.AI.NavMeshPath JMKDGEMMABC;

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
		LOIHMCCGKFA += target.GetBodyRadius();
		LOIHMCCGKFA += get_m_actor().GetBodyRadius();
		if (sqrMagnitude <= LOIHMCCGKFA * LOIHMCCGKFA)
		{
			return true;
		}
		return false;
	}

	private bool HNIFNBMHCAB()
	{
		if (JLBCIIGLBED(get_m_actor().get_m_att_range()))
		{
			DGBKMAGBJJF.Attack();
			return true;
		}
		return true;
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

	private void MLKBFFHDBLK(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!KFPGFNGAMPO.enabled)
		{
			return;
		}
		if (IFJIBJBJNFN())
		{
			Actor actor = ActorManager.GBFDGAFALIL().DCMODJADKEE(get_m_actor(), m_eyeRange, false, true, Actor.IJJMDPGJAEM.Monster);
			Vector3 position = get_m_actor().GetPosition();
			if (!(actor != null) || actor.IsDeath())
			{
				return;
			}
			DGBKMAGBJJF.SetTarget(actor);
			KFPGFNGAMPO.CalculatePath(actor.GetPosition(), JMKDGEMMABC);
			PDHPJLCMCMD = 0;
			if (LGBABAFJEED())
			{
				return;
			}
			if (HLAHNABMCKG(m_nearRangeOtherActor))
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.None);
				return;
			}
			if (PDHPJLCMCMD < JMKDGEMMABC.corners.Length)
			{
				Vector3 vector = JMKDGEMMABC.corners[PDHPJLCMCMD];
				if ((vector - position).sqrMagnitude <= 1714f)
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
		}
		else if (JLBCIIGLBED(m_nearRangeOtherActor))
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.None);
		}
	}

	public virtual void DHMMCEBEAHA()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(0, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(1, JKFMGJNEPNA);
	}

	public virtual void FMDCADHECGH()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(0, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(5, JKFMGJNEPNA);
	}

	private bool ALNPNNHMCPG()
	{
		if (HLAHNABMCKG(get_m_actor().get_m_att_range()))
		{
			DGBKMAGBJJF.Attack(true);
			return false;
		}
		return false;
	}

	private void JKFMGJNEPNA(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!KFPGFNGAMPO.enabled)
		{
			return;
		}
		if (IFJIBJBJNFN())
		{
			Actor actorInRange = ActorManager.GBFDGAFALIL().GetActorInRange(get_m_actor(), m_eyeRange, false, true, Actor.IJJMDPGJAEM.NotUsed);
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
			if (JLBCIIGLBED(m_nearRangeOtherActor))
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
				return;
			}
			if (PDHPJLCMCMD < JMKDGEMMABC.corners.Length)
			{
				Vector3 vector = JMKDGEMMABC.corners[PDHPJLCMCMD];
				if ((vector - position).sqrMagnitude <= 241f)
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

	public virtual void GKNMGIONEKK()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(0, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(2, MLKBFFHDBLK);
	}

	private void AMFGJNLLMHO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!KFPGFNGAMPO.enabled)
		{
			return;
		}
		if (IFJIBJBJNFN())
		{
			Actor actor = ActorManager.GBFDGAFALIL().DCMODJADKEE(get_m_actor(), m_eyeRange, true, false, (Actor.IJJMDPGJAEM)6);
			Vector3 position = get_m_actor().GetPosition();
			if (!(actor != null) || actor.IsDeath())
			{
				return;
			}
			DGBKMAGBJJF.SetTarget(actor);
			KFPGFNGAMPO.CalculatePath(actor.GetPosition(), JMKDGEMMABC);
			PDHPJLCMCMD = 1;
			if (DFPJBBFIJKA())
			{
				return;
			}
			if (JLBCIIGLBED(m_nearRangeOtherActor))
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.None);
				return;
			}
			if (PDHPJLCMCMD < JMKDGEMMABC.corners.Length)
			{
				Vector3 vector = JMKDGEMMABC.corners[PDHPJLCMCMD];
				if ((vector - position).sqrMagnitude <= 358f)
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

	public override void Start()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(1, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(2, AKMLBDILJIO);
	}

	public virtual void CFJKHPNIODE()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		KFPGFNGAMPO = GetComponent<UnityEngine.AI.NavMeshAgent>();
		JMKDGEMMABC = new UnityEngine.AI.NavMeshPath();
	}

	public override void Awake()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		KFPGFNGAMPO = GetComponent<UnityEngine.AI.NavMeshAgent>();
		JMKDGEMMABC = new UnityEngine.AI.NavMeshPath();
	}

	private bool JLBCIIGLBED(float LOIHMCCGKFA)
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
		float sqrMagnitude = (target.GetPosition2D() - get_m_actor().GetPosition2D()).sqrMagnitude;
		LOIHMCCGKFA += target.GetBodyRadius();
		LOIHMCCGKFA += get_m_actor().GetBodyRadius();
		if (sqrMagnitude <= LOIHMCCGKFA * LOIHMCCGKFA)
		{
			return true;
		}
		return false;
	}

	public virtual void JPBNPEJJJPI()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(0, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(3, MLKBFFHDBLK);
	}

	private bool LGBABAFJEED()
	{
		if (HLAHNABMCKG(get_m_actor().get_m_att_range()))
		{
			DGBKMAGBJJF.Attack();
			return false;
		}
		return false;
	}

	public virtual void PAJOOFIAPMI()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(0, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(3, JKFMGJNEPNA);
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
}
