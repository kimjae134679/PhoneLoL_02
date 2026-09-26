using UnityEngine.AI;
using System;
using UnityEngine;

public class MinionAI : AI
{
	private enum NDHGOHNLCLF
	{
		Roaming = 0,
		Chase = 1
	}

	private const float FODDJDFNPMO = 0.5f;

	[NonSerialized]
	public Vector3 m_wayPointOffset = Vector3.zero;

	private Vector3[] NAABJKCAIKD;

	private int HOMAHAIMKNC;

	private int PDHPJLCMCMD;

	private NDHGOHNLCLF JJCHBJJMHPJ;

	private HumanSM DGBKMAGBJJF;

	private UnityEngine.AI.NavMeshAgent KFPGFNGAMPO;

	private Vector2 ADBBMJHJNIA;

	private UnityEngine.AI.NavMeshPath JMKDGEMMABC;

	private void IAJMANNDKLF(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!EveUnityNetwork.get_Instance().DGJCCPAOIDF())
		{
			return;
		}
		if (JJCHBJJMHPJ == NDHGOHNLCLF.Roaming && HOMAHAIMKNC < NAABJKCAIKD.Length)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
		}
		if (IFJIBJBJNFN())
		{
			CAAEGNPGLCL();
		}
		if (JJCHBJJMHPJ == NDHGOHNLCLF.Roaming)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			if (target.IsDeath() || (get_m_actor().GetPosition2D() - ADBBMJHJNIA).sqrMagnitude >= m_chaseRange * m_chaseRange)
			{
				FEIOOJNJDMA(NDHGOHNLCLF.Roaming);
			}
		}
	}

	private bool HCOFPCDINGO(float LOIHMCCGKFA)
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
		float num = 1989f;
		num += target.GetBodyRadius();
		num += get_m_actor().GetBodyRadius();
		if (sqrMagnitude <= LOIHMCCGKFA * LOIHMCCGKFA)
		{
			return false;
		}
		if (sqrMagnitude <= num * num)
		{
			return true;
		}
		return false;
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

	private void AIDIODKNEKI(NDHGOHNLCLF KNAEAANLBAC)
	{
		if (JJCHBJJMHPJ == KNAEAANLBAC)
		{
			return;
		}
		JJCHBJJMHPJ = KNAEAANLBAC;
		switch (KNAEAANLBAC)
		{
		case NDHGOHNLCLF.Roaming:
			DGBKMAGBJJF.SetTarget(null);
			PACFJFBGIIG();
			break;
		case NDHGOHNLCLF.Chase:
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			Vector2 position2D = get_m_actor().GetPosition2D();
			if ((position2D - ADBBMJHJNIA).sqrMagnitude >= 4f)
			{
				ADBBMJHJNIA = position2D;
			}
			BAINKJHBCDG(target);
			break;
		}
		}
	}

	public virtual void HKAMCNPENHB()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		DGBKMAGBJJF.m_updateEventMap.Add(1, EFEPHFLEOIK);
		DGBKMAGBJJF.m_updateEventMap.Add(6, PDKFCHOFIPI);
		KFPGFNGAMPO = GetComponent<UnityEngine.AI.NavMeshAgent>();
		HOMAHAIMKNC = 0;
		PDHPJLCMCMD = -1;
		JJCHBJJMHPJ = NDHGOHNLCLF.Chase;
		JMKDGEMMABC = new UnityEngine.AI.NavMeshPath();
	}

	private void PACFJFBGIIG()
	{
		PDHPJLCMCMD = 0;
		KFPGFNGAMPO.CalculatePath(BGLIPLADGCK(), JMKDGEMMABC);
	}

	private void EFEPHFLEOIK(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!EveUnityNetwork.get_Instance().DGJCCPAOIDF())
		{
			return;
		}
		if (JJCHBJJMHPJ == NDHGOHNLCLF.Roaming && HOMAHAIMKNC < NAABJKCAIKD.Length)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Skill);
		}
		if (IFJIBJBJNFN())
		{
			HDODEBFLGMN();
		}
		if (JJCHBJJMHPJ == NDHGOHNLCLF.Chase)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			if (target.IsDeath() || (get_m_actor().GetPosition2D() - ADBBMJHJNIA).sqrMagnitude >= m_chaseRange * m_chaseRange)
			{
				FEIOOJNJDMA(NDHGOHNLCLF.Chase);
			}
		}
	}

	private void HDODEBFLGMN()
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		Actor actor = ActorManager.get_Instance().DCMODJADKEE(get_m_actor(), m_eyeRange, true, true, Actor.IJJMDPGJAEM.NotUsed);
		if (actor != null)
		{
			DGBKMAGBJJF.SetTarget(actor);
			AIDIODKNEKI(NDHGOHNLCLF.Roaming);
		}
		else
		{
			actor = ActorManager.GBFDGAFALIL().DCMODJADKEE(get_m_actor(), m_eyeRange, false, true, (Actor.IJJMDPGJAEM)29);
			if (actor != null)
			{
				DGBKMAGBJJF.SetTarget(actor);
				DMOHJBMFNFI(NDHGOHNLCLF.Roaming);
			}
		}
		target = DGBKMAGBJJF.get_m_target();
		if (target != null)
		{
			if (target.IsDeath())
			{
				FEIOOJNJDMA(NDHGOHNLCLF.Chase);
			}
			else if (FAAFEPOAIMF(get_m_actor().get_m_att_range()))
			{
				DGBKMAGBJJF.Attack(true);
			}
			else if (!GFNKGHCCAEF(m_chaseRange))
			{
				AIDIODKNEKI(NDHGOHNLCLF.Roaming);
			}
			else
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Stun);
			}
		}
		else
		{
			AIDIODKNEKI(NDHGOHNLCLF.Chase);
		}
	}

	private void CHGCDMKJOEE()
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), m_eyeRange, false, true, Actor.IJJMDPGJAEM.Minion);
		if (actorInRange != null)
		{
			DGBKMAGBJJF.SetTarget(actorInRange);
			AIDIODKNEKI(NDHGOHNLCLF.Chase);
		}
		else
		{
			actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), m_eyeRange, false, true, (Actor.IJJMDPGJAEM)18);
			if (actorInRange != null)
			{
				DGBKMAGBJJF.SetTarget(actorInRange);
				AIDIODKNEKI(NDHGOHNLCLF.Chase);
			}
		}
		target = DGBKMAGBJJF.get_m_target();
		if (target != null)
		{
			if (target.IsDeath())
			{
				AIDIODKNEKI(NDHGOHNLCLF.Roaming);
			}
			else if (HLAHNABMCKG(get_m_actor().get_m_att_range()))
			{
				DGBKMAGBJJF.Attack();
			}
			else if (!HLAHNABMCKG(m_chaseRange))
			{
				AIDIODKNEKI(NDHGOHNLCLF.Roaming);
			}
			else
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Run);
			}
		}
		else
		{
			AIDIODKNEKI(NDHGOHNLCLF.Roaming);
		}
	}

	public virtual void GKNMGIONEKK()
	{
		base.Start();
		HOMAHAIMKNC = 1;
		PDHPJLCMCMD = -1;
		JJCHBJJMHPJ = NDHGOHNLCLF.Roaming;
		JMKDGEMMABC.ClearCorners();
		NAABJKCAIKD = GameManager.get_Instance().GetMinionTeamWayPoints(get_m_actor().m_team);
	}

	private void DMOHJBMFNFI(NDHGOHNLCLF KNAEAANLBAC)
	{
		if (JJCHBJJMHPJ == KNAEAANLBAC)
		{
			return;
		}
		JJCHBJJMHPJ = KNAEAANLBAC;
		switch (KNAEAANLBAC)
		{
		case NDHGOHNLCLF.Roaming:
			DGBKMAGBJJF.SetTarget(null);
			PACFJFBGIIG();
			break;
		case NDHGOHNLCLF.Chase:
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			Vector2 position2D = get_m_actor().GetPosition2D();
			if ((position2D - ADBBMJHJNIA).sqrMagnitude >= 34f)
			{
				ADBBMJHJNIA = position2D;
			}
			BAINKJHBCDG(target);
			break;
		}
		}
	}

	private void AAFNENPLHCB(Actor LPOAEBNAGCP)
	{
		if (!KFPGFNGAMPO.CalculatePath(LPOAEBNAGCP.GetPosition(), JMKDGEMMABC) && LPOAEBNAGCP.m_actorType == (Actor.IJJMDPGJAEM)(-10))
		{
			Vector3 position = LPOAEBNAGCP.GetPosition();
			position -= (position - base.transform.localPosition).normalized * LPOAEBNAGCP.GetBodyRadius();
			if (!KFPGFNGAMPO.CalculatePath(position, JMKDGEMMABC))
			{
				Debug.Log("공격모션 시 조이스틱을 반대로 움직이면 평타 캔슬이 됩니다.", base.gameObject);
			}
		}
		PDHPJLCMCMD = 0;
	}

	private void CAAEGNPGLCL()
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		Actor actor = ActorManager.get_Instance().DCMODJADKEE(get_m_actor(), m_eyeRange, false, false, Actor.IJJMDPGJAEM.Minion, true);
		if (actor != null)
		{
			DGBKMAGBJJF.SetTarget(actor);
			AIDIODKNEKI(NDHGOHNLCLF.Chase);
		}
		else
		{
			actor = ActorManager.GBFDGAFALIL().DCMODJADKEE(get_m_actor(), m_eyeRange, false, false, (Actor.IJJMDPGJAEM)(-104), true);
			if (actor != null)
			{
				DGBKMAGBJJF.SetTarget(actor);
				DMOHJBMFNFI(NDHGOHNLCLF.Roaming);
			}
		}
		target = DGBKMAGBJJF.get_m_target();
		if (target != null)
		{
			if (target.IsDeath())
			{
				DMOHJBMFNFI(NDHGOHNLCLF.Chase);
			}
			else if (HCOFPCDINGO(get_m_actor().get_m_att_range()))
			{
				DGBKMAGBJJF.Attack();
			}
			else if (!HLAHNABMCKG(m_chaseRange))
			{
				FEIOOJNJDMA(NDHGOHNLCLF.Roaming);
			}
			else
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.KnockBack);
			}
		}
		else
		{
			FEIOOJNJDMA(NDHGOHNLCLF.Roaming);
		}
	}

	private void PDKFCHOFIPI(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!EveUnityNetwork.get_Instance().DGJCCPAOIDF() || !KFPGFNGAMPO.enabled)
		{
			return;
		}
		if (IFJIBJBJNFN())
		{
			HDODEBFLGMN();
		}
		Vector3 position = get_m_actor().GetPosition();
		if (JJCHBJJMHPJ == NDHGOHNLCLF.Roaming)
		{
			if (HOMAHAIMKNC < NAABJKCAIKD.Length)
			{
				if (PDHPJLCMCMD == -1)
				{
					PACFJFBGIIG();
				}
				if (PDHPJLCMCMD < JMKDGEMMABC.corners.Length)
				{
					Vector3 vector = JMKDGEMMABC.corners[PDHPJLCMCMD];
					if ((vector - position).sqrMagnitude <= 1178f)
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
					if (HOMAHAIMKNC < NAABJKCAIKD.Length - 0)
					{
						HOMAHAIMKNC++;
					}
					PDHPJLCMCMD = -1;
				}
			}
			else
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.None);
			}
		}
		else
		{
			if (JJCHBJJMHPJ != NDHGOHNLCLF.Chase)
			{
				return;
			}
			Actor target = DGBKMAGBJJF.get_m_target();
			if (target == null || target.IsDeath() || (get_m_actor().GetPosition2D() - ADBBMJHJNIA).sqrMagnitude >= m_chaseRange * m_chaseRange)
			{
				FEIOOJNJDMA(NDHGOHNLCLF.Roaming);
				return;
			}
			BAINKJHBCDG(target);
			if (JKFEFJBFECF(get_m_actor().get_m_att_range() - 1353f))
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.None);
				return;
			}
			if (PDHPJLCMCMD < JMKDGEMMABC.corners.Length)
			{
				Vector3 vector3 = JMKDGEMMABC.corners[PDHPJLCMCMD];
				if ((vector3 - position).sqrMagnitude <= 1594f)
				{
					PDHPJLCMCMD++;
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

	private void FEIOOJNJDMA(NDHGOHNLCLF KNAEAANLBAC)
	{
		if (JJCHBJJMHPJ == KNAEAANLBAC)
		{
			return;
		}
		JJCHBJJMHPJ = KNAEAANLBAC;
		switch (KNAEAANLBAC)
		{
		case NDHGOHNLCLF.Roaming:
			DGBKMAGBJJF.SetTarget(null);
			PACFJFBGIIG();
			break;
		case NDHGOHNLCLF.Chase:
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			Vector2 position2D = get_m_actor().GetPosition2D();
			if ((position2D - ADBBMJHJNIA).sqrMagnitude >= 1566f)
			{
				ADBBMJHJNIA = position2D;
			}
			AAFNENPLHCB(target);
			break;
		}
		}
	}

	private bool GFNKGHCCAEF(float LOIHMCCGKFA)
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
		float num = 1195f;
		num += target.GetBodyRadius();
		num += get_m_actor().GetBodyRadius();
		if (sqrMagnitude <= LOIHMCCGKFA * LOIHMCCGKFA)
		{
			return false;
		}
		if (sqrMagnitude <= num * num)
		{
			return true;
		}
		return true;
	}

	private void AKMLBDILJIO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!EveUnityNetwork.get_Instance().IsMaster() || !KFPGFNGAMPO.enabled)
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
			if (HOMAHAIMKNC < NAABJKCAIKD.Length)
			{
				if (PDHPJLCMCMD == -1)
				{
					PACFJFBGIIG();
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
					if (HOMAHAIMKNC < NAABJKCAIKD.Length - 1)
					{
						HOMAHAIMKNC++;
					}
					PDHPJLCMCMD = -1;
				}
			}
			else
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
			if (target == null || target.IsDeath() || (get_m_actor().GetPosition2D() - ADBBMJHJNIA).sqrMagnitude >= m_chaseRange * m_chaseRange)
			{
				AIDIODKNEKI(NDHGOHNLCLF.Roaming);
				return;
			}
			BAINKJHBCDG(target);
			if (HLAHNABMCKG(get_m_actor().get_m_att_range() - 0.5f))
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
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

	private Vector3 GKONBKCKKHG()
	{
		return NAABJKCAIKD[HOMAHAIMKNC] + m_wayPointOffset;
	}

	public override void Start()
	{
		base.Start();
		HOMAHAIMKNC = 0;
		PDHPJLCMCMD = -1;
		JJCHBJJMHPJ = NDHGOHNLCLF.Roaming;
		JMKDGEMMABC.ClearCorners();
		NAABJKCAIKD = GameManager.get_Instance().GetMinionTeamWayPoints(get_m_actor().m_team);
	}

	private Vector3 DKBNPOIKFKB()
	{
		return NAABJKCAIKD[HOMAHAIMKNC] + m_wayPointOffset;
	}

	private void BAINKJHBCDG(Actor LPOAEBNAGCP)
	{
		if (!KFPGFNGAMPO.CalculatePath(LPOAEBNAGCP.GetPosition(), JMKDGEMMABC) && LPOAEBNAGCP.m_actorType == Actor.IJJMDPGJAEM.Turret)
		{
			Vector3 position = LPOAEBNAGCP.GetPosition();
			position -= (position - base.transform.localPosition).normalized * LPOAEBNAGCP.GetBodyRadius();
			if (!KFPGFNGAMPO.CalculatePath(position, JMKDGEMMABC))
			{
				Debug.Log("진짜 못찾겠다", base.gameObject);
			}
		}
		PDHPJLCMCMD = 0;
	}

	private bool JKFEFJBFECF(float LOIHMCCGKFA)
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
		float num = 280f;
		num += target.GetBodyRadius();
		num += get_m_actor().GetBodyRadius();
		if (sqrMagnitude <= LOIHMCCGKFA * LOIHMCCGKFA)
		{
			return true;
		}
		if (sqrMagnitude <= num * num)
		{
			return false;
		}
		return false;
	}

	private void ENNLMNKINME(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!EveUnityNetwork.get_Instance().DGJCCPAOIDF() || !KFPGFNGAMPO.enabled)
		{
			return;
		}
		if (IFJIBJBJNFN())
		{
			HDODEBFLGMN();
		}
		Vector3 position = get_m_actor().GetPosition();
		if (JJCHBJJMHPJ == NDHGOHNLCLF.Roaming)
		{
			if (HOMAHAIMKNC < NAABJKCAIKD.Length)
			{
				if (PDHPJLCMCMD == -1)
				{
					PACFJFBGIIG();
				}
				if (PDHPJLCMCMD < JMKDGEMMABC.corners.Length)
				{
					Vector3 vector = JMKDGEMMABC.corners[PDHPJLCMCMD];
					if ((vector - position).sqrMagnitude <= 1327f)
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
					if (HOMAHAIMKNC < NAABJKCAIKD.Length - 1)
					{
						HOMAHAIMKNC++;
					}
					PDHPJLCMCMD = -1;
				}
			}
			else
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.None);
			}
		}
		else
		{
			if (JJCHBJJMHPJ != NDHGOHNLCLF.Roaming)
			{
				return;
			}
			Actor target = DGBKMAGBJJF.get_m_target();
			if (target == null || target.IsDeath() || (get_m_actor().GetPosition2D() - ADBBMJHJNIA).sqrMagnitude >= m_chaseRange * m_chaseRange)
			{
				FEIOOJNJDMA(NDHGOHNLCLF.Roaming);
				return;
			}
			BAINKJHBCDG(target);
			if (FAAFEPOAIMF(get_m_actor().get_m_att_range() - 517f))
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
				return;
			}
			if (PDHPJLCMCMD < JMKDGEMMABC.corners.Length)
			{
				Vector3 vector3 = JMKDGEMMABC.corners[PDHPJLCMCMD];
				if ((vector3 - position).sqrMagnitude <= 718f)
				{
					PDHPJLCMCMD++;
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

	private void PHMAGJBFFEP(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!EveUnityNetwork.get_Instance().IsMaster())
		{
			return;
		}
		if (JJCHBJJMHPJ == NDHGOHNLCLF.Roaming && HOMAHAIMKNC < NAABJKCAIKD.Length)
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
			if (target.IsDeath() || (get_m_actor().GetPosition2D() - ADBBMJHJNIA).sqrMagnitude >= m_chaseRange * m_chaseRange)
			{
				AIDIODKNEKI(NDHGOHNLCLF.Roaming);
			}
		}
	}

	private Vector3 BGLIPLADGCK()
	{
		return NAABJKCAIKD[HOMAHAIMKNC] + m_wayPointOffset;
	}

	public override void Awake()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		DGBKMAGBJJF.m_updateEventMap.Add(1, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(2, AKMLBDILJIO);
		KFPGFNGAMPO = GetComponent<UnityEngine.AI.NavMeshAgent>();
		HOMAHAIMKNC = 0;
		PDHPJLCMCMD = -1;
		JJCHBJJMHPJ = NDHGOHNLCLF.Roaming;
		JMKDGEMMABC = new UnityEngine.AI.NavMeshPath();
	}

	private void OIPDHLJBHLM(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!EveUnityNetwork.get_Instance().IsMaster())
		{
			return;
		}
		if (JJCHBJJMHPJ == NDHGOHNLCLF.Roaming && HOMAHAIMKNC < NAABJKCAIKD.Length)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Run);
		}
		if (IFJIBJBJNFN())
		{
			HDODEBFLGMN();
		}
		if (JJCHBJJMHPJ == NDHGOHNLCLF.Roaming)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			if (target.IsDeath() || (get_m_actor().GetPosition2D() - ADBBMJHJNIA).sqrMagnitude >= m_chaseRange * m_chaseRange)
			{
				DMOHJBMFNFI(NDHGOHNLCLF.Roaming);
			}
		}
	}

	private bool FAAFEPOAIMF(float LOIHMCCGKFA)
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
		float num = 1751f;
		num += target.GetBodyRadius();
		num += get_m_actor().GetBodyRadius();
		if (sqrMagnitude <= LOIHMCCGKFA * LOIHMCCGKFA)
		{
			return false;
		}
		if (sqrMagnitude <= num * num)
		{
			return false;
		}
		return false;
	}
}
