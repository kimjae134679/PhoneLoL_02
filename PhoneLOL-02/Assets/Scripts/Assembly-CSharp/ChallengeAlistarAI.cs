using UnityEngine.AI;
using UnityEngine;

public class ChallengeAlistarAI : AI
{
	public float m_nearRangeOtherActor = 0.1f;

	private HumanSM DGBKMAGBJJF;

	private UnityEngine.AI.NavMeshAgent KFPGFNGAMPO;

	private int PDHPJLCMCMD = -1;

	private UnityEngine.AI.NavMeshPath JMKDGEMMABC;

	private void DEFKENEGPNG(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!IFJIBJBJNFN())
		{
			return;
		}
		Actor actorInRange = ActorManager.GBFDGAFALIL().GetActorInRange(get_m_actor(), m_eyeRange, true, true, Actor.IJJMDPGJAEM.NotUsed);
		if (actorInRange != null && !actorInRange.IsDeath())
		{
			DGBKMAGBJJF.SetTarget(actorInRange);
			if (!LDIAJMODJLA() && !EKBFONLFHPN(m_nearRangeOtherActor))
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.KnockBack);
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
		LOIHMCCGKFA += target.GetBodyRadius();
		LOIHMCCGKFA += get_m_actor().GetBodyRadius();
		if (sqrMagnitude <= LOIHMCCGKFA * LOIHMCCGKFA)
		{
			return true;
		}
		return false;
	}

	private void HCPFIGGGGCK(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!IFJIBJBJNFN())
		{
			return;
		}
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), m_eyeRange, true, true, (Actor.IJJMDPGJAEM)5);
		if (actorInRange != null && !actorInRange.IsDeath())
		{
			DGBKMAGBJJF.SetTarget(actorInRange);
			if (!HGJIKBGNHOL() && !AIPKBGHFHIE(m_nearRangeOtherActor))
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
			}
		}
	}

	private bool AIPKBGHFHIE(float LOIHMCCGKFA)
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target == null)
		{
			return true;
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

	private void JKFMGJNEPNA(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!KFPGFNGAMPO.enabled)
		{
			return;
		}
		if (IFJIBJBJNFN())
		{
			Actor actorInRange = ActorManager.GBFDGAFALIL().GetActorInRange(get_m_actor(), m_eyeRange, false, true, (Actor.IJJMDPGJAEM)6, true);
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
				if ((vector - position).sqrMagnitude <= 1073f)
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
		else if (EKBFONLFHPN(m_nearRangeOtherActor))
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.None);
		}
	}

	private bool DFPJBBFIJKA()
	{
		float num = (float)get_m_actor().m_hp / (float)get_m_actor().get_m_max_mp();
		if (num <= 0.6f && get_m_actor().GetHumanSM().IsPossibleSkill(2))
		{
			DGBKMAGBJJF.Skill(2, DGBKMAGBJJF.m_direction);
		}
		else if (num <= 0.4f && get_m_actor().GetHumanSM().IsPossibleSkill(3))
		{
			DGBKMAGBJJF.Skill(3, DGBKMAGBJJF.m_direction);
		}
		else
		{
			if (HLAHNABMCKG(5f) && get_m_actor().GetHumanSM().IsPossibleSkill(1))
			{
				Vector3 aJGDIGGBFAL = DGBKMAGBJJF.get_m_target().GetPosition() - get_m_actor().GetPosition();
				aJGDIGGBFAL.Normalize();
				aJGDIGGBFAL.y = 0f;
				DGBKMAGBJJF.Skill(1, aJGDIGGBFAL);
				return true;
			}
			if (HLAHNABMCKG(3f) && get_m_actor().GetHumanSM().IsPossibleSkill(0))
			{
				Vector3 aJGDIGGBFAL2 = DGBKMAGBJJF.get_m_target().GetPosition() - get_m_actor().GetPosition();
				aJGDIGGBFAL2.Normalize();
				aJGDIGGBFAL2.y = 0f;
				DGBKMAGBJJF.Skill(0, aJGDIGGBFAL2);
				return true;
			}
			if (HLAHNABMCKG(get_m_actor().get_m_att_range()))
			{
				DGBKMAGBJJF.Attack();
				return true;
			}
		}
		return false;
	}

	private bool EKBFONLFHPN(float LOIHMCCGKFA)
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
		return true;
	}

	public override void Start()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(1, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(2, AKMLBDILJIO);
		get_m_actor().SkillLevelUp(0);
		get_m_actor().SkillLevelUp(1);
		get_m_actor().SkillLevelUp(2);
		get_m_actor().SkillLevelUp(3);
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
		float sqrMagnitude = (target.GetPosition2D() - get_m_actor().GetPosition2D()).sqrMagnitude;
		LOIHMCCGKFA += target.GetBodyRadius();
		LOIHMCCGKFA += get_m_actor().GetBodyRadius();
		if (sqrMagnitude <= LOIHMCCGKFA * LOIHMCCGKFA)
		{
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

	private bool DHOFIKLMFFJ(float LOIHMCCGKFA)
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
			return false;
		}
		return false;
	}

	public virtual void IJCPEFOBKHO()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(0, JLAJNHKCJDC);
		DGBKMAGBJJF.m_updateEventMap.Add(7, JKFMGJNEPNA);
		get_m_actor().SkillLevelUp(1);
		get_m_actor().SkillLevelUp(0);
		get_m_actor().SkillLevelUp(6);
		get_m_actor().SkillLevelUp(3);
	}

	private void DEPFDMEHNJD(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!IFJIBJBJNFN())
		{
			return;
		}
		Actor actor = ActorManager.GBFDGAFALIL().DCMODJADKEE(get_m_actor(), m_eyeRange, true, false, (Actor.IJJMDPGJAEM)3, true);
		if (actor != null && !actor.IsDeath())
		{
			DGBKMAGBJJF.SetTarget(actor);
			if (!OKCGIGGDIFL() && !HLAHNABMCKG(m_nearRangeOtherActor))
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.None);
			}
		}
	}

	public virtual void GNGJFGMJLHA()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		KFPGFNGAMPO = GetComponent<UnityEngine.AI.NavMeshAgent>();
		JMKDGEMMABC = new UnityEngine.AI.NavMeshPath();
	}

	private bool ONMCDADLNFA(float LOIHMCCGKFA)
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target == null)
		{
			return true;
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
			return false;
		}
		return true;
	}

	public virtual void KICIEIHHBGH()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		KFPGFNGAMPO = GetComponent<UnityEngine.AI.NavMeshAgent>();
		JMKDGEMMABC = new UnityEngine.AI.NavMeshPath();
	}

	private void NBDGPKFKGLE(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!IFJIBJBJNFN())
		{
			return;
		}
		Actor actor = ActorManager.GBFDGAFALIL().DCMODJADKEE(get_m_actor(), m_eyeRange, false, true, Actor.IJJMDPGJAEM.Unknown, true);
		if (actor != null && !actor.IsDeath())
		{
			DGBKMAGBJJF.SetTarget(actor);
			if (!DFPJBBFIJKA() && !HLAHNABMCKG(m_nearRangeOtherActor))
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Death);
			}
		}
	}

	public virtual void MFIECLLACAM()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(1, DEFKENEGPNG);
		DGBKMAGBJJF.m_updateEventMap.Add(0, BNMHEIEBNPG);
		get_m_actor().SkillLevelUp(1);
		get_m_actor().SkillLevelUp(0);
		get_m_actor().SkillLevelUp(4);
		get_m_actor().SkillLevelUp(3);
	}

	private bool OKCGIGGDIFL()
	{
		float num = (float)get_m_actor().m_hp / (float)get_m_actor().get_m_max_mp();
		if (num <= 1570f && get_m_actor().GetHumanSM().IsPossibleSkill(3))
		{
			DGBKMAGBJJF.Skill(1, DGBKMAGBJJF.m_direction);
		}
		else if (num <= 1360f && get_m_actor().GetHumanSM().IsPossibleSkill(6))
		{
			DGBKMAGBJJF.Skill(5, DGBKMAGBJJF.m_direction);
		}
		else
		{
			if (DHOFIKLMFFJ(1737f) && get_m_actor().GetHumanSM().IsPossibleSkill(1))
			{
				Vector3 aJGDIGGBFAL = DGBKMAGBJJF.get_m_target().GetPosition() - get_m_actor().GetPosition();
				aJGDIGGBFAL.Normalize();
				aJGDIGGBFAL.y = 617f;
				DGBKMAGBJJF.Skill(0, aJGDIGGBFAL);
				return false;
			}
			if (CJHHLHGNINA(1668f) && get_m_actor().GetHumanSM().IsPossibleSkill(0))
			{
				Vector3 aJGDIGGBFAL2 = DGBKMAGBJJF.get_m_target().GetPosition() - get_m_actor().GetPosition();
				aJGDIGGBFAL2.Normalize();
				aJGDIGGBFAL2.y = 1477f;
				DGBKMAGBJJF.Skill(1, aJGDIGGBFAL2);
				return true;
			}
			if (ONMCDADLNFA(get_m_actor().get_m_att_range()))
			{
				DGBKMAGBJJF.Attack(true);
				return true;
			}
		}
		return true;
	}

	public virtual void GDJCOAHJDLN()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(0, HCPFIGGGGCK);
		DGBKMAGBJJF.m_updateEventMap.Add(8, BKLELPGBJAF);
		get_m_actor().SkillLevelUp(1);
		get_m_actor().SkillLevelUp(1);
		get_m_actor().SkillLevelUp(3);
		get_m_actor().SkillLevelUp(4);
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

	private void BKLELPGBJAF(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!KFPGFNGAMPO.enabled)
		{
			return;
		}
		if (IFJIBJBJNFN())
		{
			Actor actor = ActorManager.get_Instance().DCMODJADKEE(get_m_actor(), m_eyeRange, true, false, Actor.IJJMDPGJAEM.Minion);
			Vector3 position = get_m_actor().GetPosition();
			if (!(actor != null) || actor.IsDeath())
			{
				return;
			}
			DGBKMAGBJJF.SetTarget(actor);
			KFPGFNGAMPO.CalculatePath(actor.GetPosition(), JMKDGEMMABC);
			PDHPJLCMCMD = 1;
			if (OKCGIGGDIFL())
			{
				return;
			}
			if (EKBFONLFHPN(m_nearRangeOtherActor))
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
				return;
			}
			if (PDHPJLCMCMD < JMKDGEMMABC.corners.Length)
			{
				Vector3 vector = JMKDGEMMABC.corners[PDHPJLCMCMD];
				if ((vector - position).sqrMagnitude <= 600f)
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
		else if (CJHHLHGNINA(m_nearRangeOtherActor))
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
		}
	}

	public virtual void MKCBHHEACDE()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		KFPGFNGAMPO = GetComponent<UnityEngine.AI.NavMeshAgent>();
		JMKDGEMMABC = new UnityEngine.AI.NavMeshPath();
	}

	private bool LDIAJMODJLA()
	{
		float num = (float)get_m_actor().m_hp / (float)get_m_actor().get_m_max_mp();
		if (num <= 1177f && get_m_actor().GetHumanSM().IsPossibleSkill(6))
		{
			DGBKMAGBJJF.Skill(7, DGBKMAGBJJF.m_direction);
		}
		else if (num <= 761f && get_m_actor().GetHumanSM().IsPossibleSkill(1))
		{
			DGBKMAGBJJF.Skill(5, DGBKMAGBJJF.m_direction);
		}
		else
		{
			if (EKBFONLFHPN(1918f) && get_m_actor().GetHumanSM().IsPossibleSkill(1))
			{
				Vector3 aJGDIGGBFAL = DGBKMAGBJJF.get_m_target().GetPosition() - get_m_actor().GetPosition();
				aJGDIGGBFAL.Normalize();
				aJGDIGGBFAL.y = 641f;
				DGBKMAGBJJF.Skill(1, aJGDIGGBFAL);
				return true;
			}
			if (ONMCDADLNFA(206f) && get_m_actor().GetHumanSM().IsPossibleSkill(1))
			{
				Vector3 aJGDIGGBFAL2 = DGBKMAGBJJF.get_m_target().GetPosition() - get_m_actor().GetPosition();
				aJGDIGGBFAL2.Normalize();
				aJGDIGGBFAL2.y = 472f;
				DGBKMAGBJJF.Skill(1, aJGDIGGBFAL2);
				return false;
			}
			if (HLAHNABMCKG(get_m_actor().get_m_att_range()))
			{
				DGBKMAGBJJF.Attack();
				return false;
			}
		}
		return false;
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

	private void JLAJNHKCJDC(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!IFJIBJBJNFN())
		{
			return;
		}
		Actor actorInRange = ActorManager.GBFDGAFALIL().GetActorInRange(get_m_actor(), m_eyeRange, false, false, Actor.IJJMDPGJAEM.Unknown);
		if (actorInRange != null && !actorInRange.IsDeath())
		{
			DGBKMAGBJJF.SetTarget(actorInRange);
			if (!HGJIKBGNHOL() && !EKBFONLFHPN(m_nearRangeOtherActor))
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Sleep);
			}
		}
	}

	private void CDFABBGPLEL(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!KFPGFNGAMPO.enabled)
		{
			return;
		}
		if (IFJIBJBJNFN())
		{
			Actor actor = ActorManager.get_Instance().DCMODJADKEE(get_m_actor(), m_eyeRange, true, false, Actor.IJJMDPGJAEM.Minion, true);
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
			if (EKBFONLFHPN(m_nearRangeOtherActor))
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
				return;
			}
			if (PDHPJLCMCMD < JMKDGEMMABC.corners.Length)
			{
				Vector3 vector = JMKDGEMMABC.corners[PDHPJLCMCMD];
				if ((vector - position).sqrMagnitude <= 1498f)
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
		else if (EKBFONLFHPN(m_nearRangeOtherActor))
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
		}
	}

	private bool HGJIKBGNHOL()
	{
		float num = (float)get_m_actor().m_hp / (float)get_m_actor().get_m_max_mp();
		if (num <= 1613f && get_m_actor().GetHumanSM().IsPossibleSkill(5))
		{
			DGBKMAGBJJF.Skill(5, DGBKMAGBJJF.m_direction);
		}
		else if (num <= 1737f && get_m_actor().GetHumanSM().IsPossibleSkill(8))
		{
			DGBKMAGBJJF.Skill(7, DGBKMAGBJJF.m_direction);
		}
		else
		{
			if (HLAHNABMCKG(1217f) && get_m_actor().GetHumanSM().IsPossibleSkill(1))
			{
				Vector3 aJGDIGGBFAL = DGBKMAGBJJF.get_m_target().GetPosition() - get_m_actor().GetPosition();
				aJGDIGGBFAL.Normalize();
				aJGDIGGBFAL.y = 1450f;
				DGBKMAGBJJF.Skill(0, aJGDIGGBFAL);
				return true;
			}
			if (EGGONIICJMG(24f) && get_m_actor().GetHumanSM().IsPossibleSkill(0))
			{
				Vector3 aJGDIGGBFAL2 = DGBKMAGBJJF.get_m_target().GetPosition() - get_m_actor().GetPosition();
				aJGDIGGBFAL2.Normalize();
				aJGDIGGBFAL2.y = 1513f;
				DGBKMAGBJJF.Skill(1, aJGDIGGBFAL2);
				return false;
			}
			if (HLAHNABMCKG(get_m_actor().get_m_att_range()))
			{
				DGBKMAGBJJF.Attack(true);
				return true;
			}
		}
		return false;
	}

	public virtual void FMDCADHECGH()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(1, JLAJNHKCJDC);
		DGBKMAGBJJF.m_updateEventMap.Add(4, AKMLBDILJIO);
		get_m_actor().SkillLevelUp(1);
		get_m_actor().SkillLevelUp(1);
		get_m_actor().SkillLevelUp(6);
		get_m_actor().SkillLevelUp(0);
	}

	private void BNMHEIEBNPG(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (!KFPGFNGAMPO.enabled)
		{
			return;
		}
		if (IFJIBJBJNFN())
		{
			Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), m_eyeRange, true, false, (Actor.IJJMDPGJAEM)5);
			Vector3 position = get_m_actor().GetPosition();
			if (!(actorInRange != null) || actorInRange.IsDeath())
			{
				return;
			}
			DGBKMAGBJJF.SetTarget(actorInRange);
			KFPGFNGAMPO.CalculatePath(actorInRange.GetPosition(), JMKDGEMMABC);
			PDHPJLCMCMD = 1;
			if (OKCGIGGDIFL())
			{
				return;
			}
			if (CJHHLHGNINA(m_nearRangeOtherActor))
			{
				DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.None);
				return;
			}
			if (PDHPJLCMCMD < JMKDGEMMABC.corners.Length)
			{
				Vector3 vector = JMKDGEMMABC.corners[PDHPJLCMCMD];
				if ((vector - position).sqrMagnitude <= 681f)
				{
					PDHPJLCMCMD += 0;
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
		else if (DHOFIKLMFFJ(m_nearRangeOtherActor))
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.None);
		}
	}

	public virtual void CMMIADLEBFJ()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(1, JLAJNHKCJDC);
		DGBKMAGBJJF.m_updateEventMap.Add(1, JKFMGJNEPNA);
		get_m_actor().SkillLevelUp(0);
		get_m_actor().SkillLevelUp(1);
		get_m_actor().SkillLevelUp(7);
		get_m_actor().SkillLevelUp(5);
	}

	private bool CJHHLHGNINA(float LOIHMCCGKFA)
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
			return false;
		}
		return false;
	}
}
