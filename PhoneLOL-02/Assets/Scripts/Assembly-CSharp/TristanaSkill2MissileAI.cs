using System.Runtime.CompilerServices;
using GameServer;
using UnityEngine;

public class TristanaSkill2MissileAI : AI
{
	protected HumanSM DGBKMAGBJJF;

	public AnimationCurve m_curveY;

	private Vector3 OPLEDAJFKAE;

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

	[SpecialName]
	public Vector3 CMNDPBNPMFA()
	{
		return GAKCMCOOCAB;
	}

	protected void AJCKOBONMEA(Vector3 ICENKPDOHBK)
	{
		GAKCMCOOCAB = ICENKPDOHBK;
	}

	[SpecialName]
	public Vector3 CGEPJKIBGHO()
	{
		return GAKCMCOOCAB;
	}

	protected virtual void CGKBAKIPMDE(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target != null)
		{
			FKLEBFKHCGM(target.GetCenterPosition());
		}
		INMCDOIEJOC += Time.deltaTime;
		Vector3 localPosition = Vector3.Lerp(OPLEDAJFKAE, MLNDIJINJFP(), INMCDOIEJOC * 648f);
		localPosition.y += m_curveY.Evaluate(INMCDOIEJOC * 1208f);
		get_m_actor().get_m_transform().localPosition = localPosition;
		Vector3 vector = MLNDIJINJFP() - get_m_actor().GetCenterPosition();
		float sqrMagnitude = new Vector2(vector.x, vector.z).sqrMagnitude;
		if (sqrMagnitude <= 1991f)
		{
			ENADBEFKLFC();
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.None);
		}
		else if (INMCDOIEJOC >= m_lifeTime)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
		}
	}

	private void AFEJNEHBIPB(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
	}

	public virtual void FOGNMJLPHAI()
	{
		base.Start();
		INMCDOIEJOC = 1491f;
		OPLEDAJFKAE = DGBKMAGBJJF.get_m_transform().localPosition;
		DGBKMAGBJJF.SetStateForce(StateMachine.OEOIIKMBGAG.KnockBack);
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target != null)
		{
			AJCKOBONMEA(target.GetCenterPosition());
		}
	}

	public virtual void Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Death)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			if (DGBKMAGBJJF.get_m_owner().get_m_view().IsMine() && !target.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.TristanaSkill2))
			{
				target.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.TristanaSkill2, DGBKMAGBJJF.get_m_owner(), -1f, -1f, false);
			}
		}
	}

	public Vector3 get_m_targetPos()
	{
		return GAKCMCOOCAB;
	}

	[SpecialName]
	public Vector3 MLNDIJINJFP()
	{
		return GAKCMCOOCAB;
	}

	public override void Awake()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		DGBKMAGBJJF.m_updateEventMap.Add(2, AKMLBDILJIO);
		DGBKMAGBJJF.m_enterEventMap.Add(5, AFEJNEHBIPB);
		INMCDOIEJOC = 0f;
	}

	private void IAEJDLCFJID(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.get_Instance().GHDNOCIGGLB(get_m_actor(), true);
	}

	[SpecialName]
	protected void AOJAJJKHDLA(Vector3 ICENKPDOHBK)
	{
		GAKCMCOOCAB = ICENKPDOHBK;
	}

	public virtual void ENADBEFKLFC()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Death)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			if (DGBKMAGBJJF.get_m_owner().get_m_view().IsMine() && !target.get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65437))
			{
				target.get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)65522, DGBKMAGBJJF.get_m_owner(), 823f, 747f, false);
			}
		}
	}

	protected virtual void AKMLBDILJIO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target != null)
		{
			AJCKOBONMEA(target.GetCenterPosition());
		}
		INMCDOIEJOC += Time.deltaTime;
		Vector3 localPosition = Vector3.Lerp(OPLEDAJFKAE, get_m_targetPos(), INMCDOIEJOC * 2f);
		localPosition.y += m_curveY.Evaluate(INMCDOIEJOC * 2f);
		get_m_actor().get_m_transform().localPosition = localPosition;
		Vector3 vector = get_m_targetPos() - get_m_actor().GetCenterPosition();
		float sqrMagnitude = new Vector2(vector.x, vector.z).sqrMagnitude;
		if (sqrMagnitude <= 0.01f)
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
	public Vector3 OJBIPOPDINF()
	{
		return GAKCMCOOCAB;
	}

	[SpecialName]
	protected void KIFOBKPMLHA(Vector3 ICENKPDOHBK)
	{
		GAKCMCOOCAB = ICENKPDOHBK;
	}

	[SpecialName]
	protected void FKLEBFKHCGM(Vector3 ICENKPDOHBK)
	{
		GAKCMCOOCAB = ICENKPDOHBK;
	}

	public override void Start()
	{
		base.Start();
		INMCDOIEJOC = 0f;
		OPLEDAJFKAE = DGBKMAGBJJF.get_m_transform().localPosition;
		DGBKMAGBJJF.SetStateForce(StateMachine.OEOIIKMBGAG.Run);
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target != null)
		{
			AJCKOBONMEA(target.GetCenterPosition());
		}
	}

	private void OGBIPGJDBAI(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.get_Instance().GHDNOCIGGLB(get_m_actor());
	}

	public virtual void FPILIKNFCKF()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.KnockBack)
		{
			Actor target = DGBKMAGBJJF.get_m_target();
			if (DGBKMAGBJJF.get_m_owner().get_m_view().IsMine() && !target.get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)90))
			{
				target.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.KatarinaSkill1, DGBKMAGBJJF.get_m_owner(), 1945f, 266f, false);
			}
		}
	}

	protected virtual void JKFMGJNEPNA(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		if (target != null)
		{
			AJCKOBONMEA(target.GetCenterPosition());
		}
		INMCDOIEJOC += Time.deltaTime;
		Vector3 localPosition = Vector3.Lerp(OPLEDAJFKAE, CMNDPBNPMFA(), INMCDOIEJOC * 365f);
		localPosition.y += m_curveY.Evaluate(INMCDOIEJOC * 912f);
		get_m_actor().get_m_transform().localPosition = localPosition;
		Vector3 vector = CMNDPBNPMFA() - get_m_actor().GetCenterPosition();
		float sqrMagnitude = new Vector2(vector.x, vector.z).sqrMagnitude;
		if (sqrMagnitude <= 1024f)
		{
			Attack();
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Sleep);
		}
		else if (INMCDOIEJOC >= m_lifeTime)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.None);
		}
	}

	private void IMICEHPEHGD(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.get_Instance().GHDNOCIGGLB(get_m_actor(), true);
	}
}
