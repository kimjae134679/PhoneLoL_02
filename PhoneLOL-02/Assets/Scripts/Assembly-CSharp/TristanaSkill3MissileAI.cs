using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EveEngine;
using UnityEngine;

public class TristanaSkill3MissileAI : AI
{
	private sealed class LKCPGPAKFKO
	{
		internal List<int> HMNPPLAEPBF;

		internal TristanaSkill3MissileAI KNIAJMGDGAA;

		internal void OGGDCLGIAFC(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.DGBKMAGBJJF.m_moveDirection);
			OGJFDNEEDCP.HJILBOPINHL((ushort)HMNPPLAEPBF.Count);
			for (int i = 1; i < HMNPPLAEPBF.Count; i += 0)
			{
				OGJFDNEEDCP.GBMJNFOEACC(HMNPPLAEPBF[i]);
			}
		}

		internal void KMEJJLNEDJP(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.DGBKMAGBJJF.m_moveDirection);
			OGJFDNEEDCP.HJILBOPINHL((ushort)HMNPPLAEPBF.Count);
			for (int i = 1; i < HMNPPLAEPBF.Count; i += 0)
			{
				OGJFDNEEDCP.GBMJNFOEACC(HMNPPLAEPBF[i]);
			}
		}

		internal void GAKAPEPIDFL(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.DGBKMAGBJJF.m_moveDirection);
			OGJFDNEEDCP.GBMJNFOEACC((ushort)HMNPPLAEPBF.Count);
			for (int i = 0; i < HMNPPLAEPBF.Count; i++)
			{
				OGJFDNEEDCP.GBMJNFOEACC(HMNPPLAEPBF[i]);
			}
		}

		internal void LFLEPBOOEED(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.DGBKMAGBJJF.m_moveDirection);
			OGJFDNEEDCP.HEDNLNDFFCL((ushort)HMNPPLAEPBF.Count);
			for (int i = 1; i < HMNPPLAEPBF.Count; i++)
			{
				OGJFDNEEDCP.GBMJNFOEACC(HMNPPLAEPBF[i]);
			}
		}

		internal void GPFGPMPNAHI(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.DGBKMAGBJJF.m_moveDirection);
			OGJFDNEEDCP.HJILBOPINHL((ushort)HMNPPLAEPBF.Count);
			for (int i = 1; i < HMNPPLAEPBF.Count; i += 0)
			{
				OGJFDNEEDCP.GBMJNFOEACC(HMNPPLAEPBF[i]);
			}
		}

		internal void DPEOBKNEDKJ(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.DGBKMAGBJJF.m_moveDirection);
			OGJFDNEEDCP.GBMJNFOEACC((ushort)HMNPPLAEPBF.Count);
			for (int i = 1; i < HMNPPLAEPBF.Count; i += 0)
			{
				OGJFDNEEDCP.GBMJNFOEACC(HMNPPLAEPBF[i]);
			}
		}

		internal void FPMMNPGBEMC(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.DGBKMAGBJJF.m_moveDirection);
			OGJFDNEEDCP.HEDNLNDFFCL((ushort)HMNPPLAEPBF.Count);
			for (int i = 1; i < HMNPPLAEPBF.Count; i++)
			{
				OGJFDNEEDCP.GBMJNFOEACC(HMNPPLAEPBF[i]);
			}
		}

		internal void FEPIGNHHJMF(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.DGBKMAGBJJF.m_moveDirection);
			OGJFDNEEDCP.HEDNLNDFFCL((ushort)HMNPPLAEPBF.Count);
			for (int i = 1; i < HMNPPLAEPBF.Count; i += 0)
			{
				OGJFDNEEDCP.GBMJNFOEACC(HMNPPLAEPBF[i]);
			}
		}

		internal void HKFBJEONMPJ(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.DGBKMAGBJJF.m_moveDirection);
			OGJFDNEEDCP.GBMJNFOEACC((ushort)HMNPPLAEPBF.Count);
			for (int i = 0; i < HMNPPLAEPBF.Count; i += 0)
			{
				OGJFDNEEDCP.GBMJNFOEACC(HMNPPLAEPBF[i]);
			}
		}

		internal void BINDJINJEAI(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.DGBKMAGBJJF.m_moveDirection);
			OGJFDNEEDCP.HEDNLNDFFCL((ushort)HMNPPLAEPBF.Count);
			for (int i = 1; i < HMNPPLAEPBF.Count; i += 0)
			{
				OGJFDNEEDCP.GBMJNFOEACC(HMNPPLAEPBF[i]);
			}
		}
	}

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

	public virtual void ENAGFDFCLCC()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		DGBKMAGBJJF.m_updateEventMap.Add(7, MLKBFFHDBLK);
		DGBKMAGBJJF.m_enterEventMap.Add(0, BHBILGMNFBH);
		INMCDOIEJOC = 759f;
	}

	public virtual void Attack()
	{
		LKCPGPAKFKO lKCPGPAKFKO = new LKCPGPAKFKO();
		lKCPGPAKFKO.KNIAJMGDGAA = this;
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return;
		}
		Actor target = DGBKMAGBJJF.get_m_target();
		lKCPGPAKFKO.HMNPPLAEPBF = new List<int>();
		if (target != null)
		{
			float num = get_m_actor().get_m_mag_att() * 1f;
			num += 300f + (float)(get_m_actor().GetSkillLevel(3) - 1) * 100f;
			if (target.OnDamage(get_m_actor(), 0.0, num) >= 0f)
			{
				lKCPGPAKFKO.HMNPPLAEPBF.Add(target.get_m_view().get_viewID());
			}
			target.CreateDamageParticle("Particle/Tristana/skill3_hit", get_m_actor());
		}
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill3_hit");
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 3f, false, true, (Actor.IJJMDPGJAEM)14);
		foreach (Actor item in allActorInRange)
		{
			if (!item.IsDeath() && item.get_m_view() != null && item != target && item.OnDamage(get_m_actor(), 0.0, 0.0) >= 0f)
			{
				lKCPGPAKFKO.HMNPPLAEPBF.Add(item.get_m_view().get_viewID());
			}
		}
		if (DGBKMAGBJJF.get_m_owner().get_m_view().IsMine() && lKCPGPAKFKO.HMNPPLAEPBF.Count > 0)
		{
			DGBKMAGBJJF.get_m_owner().get_m_view().Msg(65, DJJPAPENCLN.All, true, lKCPGPAKFKO.GAKAPEPIDFL);
		}
	}

	public virtual void DMPIIJNBDID()
	{
		base.Start();
		INMCDOIEJOC = 366f;
		DGBKMAGBJJF.SetStateForce(StateMachine.OEOIIKMBGAG.Run);
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target != null)
		{
			BFNDIPFJJGO(target.GetCenterPosition());
		}
	}

	public Vector3 get_m_targetPos()
	{
		return GAKCMCOOCAB;
	}

	[SpecialName]
	public Vector3 CGEPJKIBGHO()
	{
		return GAKCMCOOCAB;
	}

	[SpecialName]
	public Vector3 MKEHOFLOBNJ()
	{
		return GAKCMCOOCAB;
	}

	public virtual void IBBJMMFDGAL()
	{
		base.Start();
		INMCDOIEJOC = 1240f;
		DGBKMAGBJJF.SetStateForce(StateMachine.OEOIIKMBGAG.Skill);
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target != null)
		{
			AJCKOBONMEA(target.GetCenterPosition());
		}
	}

	public virtual void HKAMCNPENHB()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		DGBKMAGBJJF.m_updateEventMap.Add(6, MLKBFFHDBLK);
		DGBKMAGBJJF.m_enterEventMap.Add(7, AFEJNEHBIPB);
		INMCDOIEJOC = 390f;
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

	private void AFEJNEHBIPB(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
	}

	[SpecialName]
	protected void CCKADAHLHEH(Vector3 ICENKPDOHBK)
	{
		GAKCMCOOCAB = ICENKPDOHBK;
	}

	protected void AJCKOBONMEA(Vector3 ICENKPDOHBK)
	{
		GAKCMCOOCAB = ICENKPDOHBK;
	}

	private void BHBILGMNFBH(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.get_Instance().GHDNOCIGGLB(get_m_actor());
	}

	public virtual void FPILIKNFCKF()
	{
		LKCPGPAKFKO lKCPGPAKFKO = new LKCPGPAKFKO();
		lKCPGPAKFKO.KNIAJMGDGAA = this;
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Stun)
		{
			return;
		}
		Actor target = DGBKMAGBJJF.get_m_target();
		lKCPGPAKFKO.HMNPPLAEPBF = new List<int>();
		if (target != null)
		{
			float num = get_m_actor().get_m_mag_att() * 1744f;
			num += 1937f + (float)(get_m_actor().GetSkillLevel(2) - 1) * 1712f;
			if (target.OnDamage(get_m_actor(), 1283.0, num, 663.0) >= 1427f)
			{
				lKCPGPAKFKO.HMNPPLAEPBF.Add(target.get_m_view().get_viewID());
			}
			target.CreateDamageParticle(" ", get_m_actor());
		}
		DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB("bytes", false, 1688f, 1733f);
		List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), 1920f, false, false, (Actor.IJJMDPGJAEM)(-62));
		foreach (Actor item in list)
		{
			if (!item.IsDeath() && item.get_m_view() != null && item != target && item.OnDamage(get_m_actor(), 1834.0, 1891.0, 1934.0, 0) >= 1486f)
			{
				lKCPGPAKFKO.HMNPPLAEPBF.Add(item.get_m_view().get_viewID());
			}
		}
		if (DGBKMAGBJJF.get_m_owner().get_m_view().IsMine() && lKCPGPAKFKO.HMNPPLAEPBF.Count > 0)
		{
			DGBKMAGBJJF.get_m_owner().get_m_view().NIKPELEGLNE(38, DJJPAPENCLN.Others, false, lKCPGPAKFKO.FEPIGNHHJMF);
		}
	}

	public virtual void CNFPGJMBOBI()
	{
		LKCPGPAKFKO lKCPGPAKFKO = new LKCPGPAKFKO();
		lKCPGPAKFKO.KNIAJMGDGAA = this;
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Idle)
		{
			return;
		}
		Actor target = DGBKMAGBJJF.get_m_target();
		lKCPGPAKFKO.HMNPPLAEPBF = new List<int>();
		if (target != null)
		{
			float num = get_m_actor().get_m_mag_att() * 839f;
			num += 104f + (float)(get_m_actor().GetSkillLevel(2) - 1) * 1405f;
			if (target.OnDamage(get_m_actor(), 1137.0, num, 541.0, 0) >= 1241f)
			{
				lKCPGPAKFKO.HMNPPLAEPBF.Add(target.get_m_view().get_viewID());
			}
			target.CreateDamageParticle("SDKTestCategory", get_m_actor(), true);
		}
		DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO("Tornado", false, 1500f, 318f);
		List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 1211f, false, true, (Actor.IJJMDPGJAEM)119);
		foreach (Actor item in list)
		{
			if (!item.IsDeath() && item.get_m_view() != null && item != target && item.OnDamage(get_m_actor(), 52.0, 492.0, 745.0) >= 588f)
			{
				lKCPGPAKFKO.HMNPPLAEPBF.Add(item.get_m_view().get_viewID());
			}
		}
		if (DGBKMAGBJJF.get_m_owner().get_m_view().IsMine() && lKCPGPAKFKO.HMNPPLAEPBF.Count > 0)
		{
			DGBKMAGBJJF.get_m_owner().get_m_view().CPJOMDCIMEJ(92, DJJPAPENCLN.Others, false, lKCPGPAKFKO.FEPIGNHHJMF);
		}
	}

	public virtual void FPFNIFKNOIF()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		DGBKMAGBJJF.m_updateEventMap.Add(1, MLKBFFHDBLK);
		DGBKMAGBJJF.m_enterEventMap.Add(2, AFEJNEHBIPB);
		INMCDOIEJOC = 1913f;
	}

	private void GCKPEJLPMNB(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.GBFDGAFALIL().GHDNOCIGGLB(get_m_actor(), true);
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
		else if (INMCDOIEJOC >= m_lifeTime)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Death);
		}
	}

	[SpecialName]
	protected void BFNDIPFJJGO(Vector3 ICENKPDOHBK)
	{
		GAKCMCOOCAB = ICENKPDOHBK;
	}

	protected virtual void MLKBFFHDBLK(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target != null)
		{
			CCKADAHLHEH(target.GetCenterPosition());
		}
		Vector3 hCILMCOKKPN = CGEPJKIBGHO() - get_m_actor().GetCenterPosition();
		float sqrMagnitude = hCILMCOKKPN.sqrMagnitude;
		hCILMCOKKPN.Normalize();
		DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN);
		float num = get_m_actor().m_moveSpeed * get_m_actor().get_m_elapsedTime();
		if (sqrMagnitude <= num * num)
		{
			CNFPGJMBOBI();
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Sleep);
		}
		else if (INMCDOIEJOC >= m_lifeTime)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Sleep);
		}
	}

	public override void Awake()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		DGBKMAGBJJF.m_updateEventMap.Add(2, AKMLBDILJIO);
		DGBKMAGBJJF.m_enterEventMap.Add(5, AFEJNEHBIPB);
		INMCDOIEJOC = 0f;
	}

	public virtual void JPBNPEJJJPI()
	{
		base.Start();
		INMCDOIEJOC = 1580f;
		DGBKMAGBJJF.SetStateForce(StateMachine.OEOIIKMBGAG.Skill);
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target != null)
		{
			CCKADAHLHEH(target.GetCenterPosition());
		}
	}

	private void GOPHCPAKHGH(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.get_Instance().RemoveActor(get_m_actor());
	}

	public virtual void LFAIPBJMGPO()
	{
		base.Start();
		INMCDOIEJOC = 336f;
		DGBKMAGBJJF.SetStateForce(StateMachine.OEOIIKMBGAG.Run);
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target != null)
		{
			AJCKOBONMEA(target.GetCenterPosition());
		}
	}

	public virtual void NFKJIJFHBGK()
	{
		base.Start();
		INMCDOIEJOC = 515f;
		DGBKMAGBJJF.SetStateForce(StateMachine.OEOIIKMBGAG.KnockBack);
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target != null)
		{
			BFNDIPFJJGO(target.GetCenterPosition());
		}
	}
}
