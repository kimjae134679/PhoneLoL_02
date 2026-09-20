using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class TalonSM : HumanSM
{
	private sealed class JMIIKIOJHNF : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal TalonSM KNIAJMGDGAA;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return MMEGGNJKNOH;
			}
		}

		[SpecialName]
		private object PHDGFFDAMLI()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object BJIGDKGLCKP()
		{
			return MMEGGNJKNOH;
		}

		public void CDNEMMAGDGN()
		{
			throw new NotSupportedException();
		}

		public void KIHPGHBDAMI()
		{
			GOMFKPLCGNN = -1;
		}

		public void LDNDAOJGIIO()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public bool KAHALICNEBF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForSeconds(289f);
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				KNIAJMGDGAA.get_m_actor().m_multiSound.ICNAJBHLIGO("획득 경험치", false, 767f, 222f);
				MMEGGNJKNOH = new WaitForSeconds(583f);
				GOMFKPLCGNN = 1;
				break;
			case 2u:
				KNIAJMGDGAA.get_m_actor().m_multiSound.NMLFNHNOALK("근처에 적 챔피언이 없습니다", true, 1696f, 1509f);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return false;
		}

		public void MBADNGDPBPB()
		{
			GOMFKPLCGNN = -1;
		}

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForSeconds(0.4f);
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				KNIAJMGDGAA.get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_1");
				MMEGGNJKNOH = new WaitForSeconds(0.1f);
				GOMFKPLCGNN = 2;
				break;
			case 2u:
				KNIAJMGDGAA.get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_voice");
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return true;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		public void CHFDNLJNKBN()
		{
			GOMFKPLCGNN = -1;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object KCJOOMCHBHD()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object JMADBEOPCDA()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object MEHLLKBMILP()
		{
			return MMEGGNJKNOH;
		}

		public void PLOOENOBGJL()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object BDANALHKFBH()
		{
			return MMEGGNJKNOH;
		}

		public bool CBIPKFMCHPF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForSeconds(485f);
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				KNIAJMGDGAA.get_m_actor().m_multiSound.DDONMGBLLJB("blitzcrank_passive", false, 1631f, 768f);
				MMEGGNJKNOH = new WaitForSeconds(1515f);
				GOMFKPLCGNN = 2;
				break;
			case 2u:
				KNIAJMGDGAA.get_m_actor().m_multiSound.LNCPFILABHM("每個級別攻擊力", true, 26f, 1707f);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return true;
			}
			return true;
		}

		public bool GMJNFFCMCNJ()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForSeconds(1761f);
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				KNIAJMGDGAA.get_m_actor().m_multiSound.ICNAJBHLIGO("EventDelegate", false, 1412f, 1975f);
				MMEGGNJKNOH = new WaitForSeconds(1515f);
				GOMFKPLCGNN = 4;
				break;
			case 2u:
				KNIAJMGDGAA.get_m_actor().m_multiSound.NMLFNHNOALK("ui_battle_start", true, 267f, 195f);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return false;
		}

		[SpecialName]
		private object FECLPGHCNNJ()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object IFFDBIJPACH()
		{
			return MMEGGNJKNOH;
		}

		public bool AAAMEOEOJHM()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForSeconds(1111f);
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				KNIAJMGDGAA.get_m_actor().m_multiSound.LNCPFILABHM("[", false, 1193f, 1222f);
				MMEGGNJKNOH = new WaitForSeconds(1347f);
				GOMFKPLCGNN = 2;
				break;
			case 2u:
				KNIAJMGDGAA.get_m_actor().m_multiSound.NMLFNHNOALK("이미 추천하셨습니다.\n\n추천은 한번만 가능합니다.", true, 498f, 1840f);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return false;
		}

		public void DAPBOMILKPH()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object BLGJNJAMAIJ()
		{
			return MMEGGNJKNOH;
		}
	}

	public GameObject[] m_skill0HandParticles;

	private int GOGLNMODMLA;

	private LinkedList<Actor> OMKCCEDPILG;

	private LinkedList<Actor> NMOPIIBAHLM;

	private LinkedList<TalonSkill3MissileAI> JNCFIIIFHCH;

	private LinkedList<Actor> KIFBOLJKKBA;

	private LinkedList<Actor> PBOGNOFFDDI;

	private Actor NGNLJADPNNB;

	private void CKOCPCLMJMG()
	{
		OnAnimationEventSkill(6);
	}

	private IEnumerator IOJJEOMLKAG()
	{
		JMIIKIOJHNF jMIIKIOJHNF = new JMIIKIOJHNF();
		jMIIKIOJHNF.KNIAJMGDGAA = this;
		return jMIIKIOJHNF;
	}

	private void NJAAKBCFCLG(OEOIIKMBGAG EBILEBOJADB)
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.TalonSkill0))
		{
			GameObject[] skill0HandParticles = m_skill0HandParticles;
			foreach (GameObject gameObject in skill0HandParticles)
			{
				if (!get_m_actor().IsMyTeam() && (bool)get_m_actor().get_m_cloaking())
				{
					if (gameObject.activeSelf)
					{
						gameObject.SetActive(false);
					}
				}
				else if (!gameObject.activeSelf)
				{
					gameObject.SetActive(true);
				}
			}
			return;
		}
		GameObject[] skill0HandParticles2 = m_skill0HandParticles;
		foreach (GameObject gameObject2 in skill0HandParticles2)
		{
			if (gameObject2.activeSelf)
			{
				gameObject2.SetActive(false);
			}
		}
	}

	[JDLHECHNNDH]
	public void CreateSkill0Missile(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = get_m_actor().CreateMissile("skill1_missile", HEPNHCEIFMO, null);
		TalonSkill1MissileAI component = actor.GetComponent<TalonSkill1MissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
		Actor actor2 = get_m_actor().CreateMissile("skill1_missile", HEPNHCEIFMO, null);
		TalonSkill1MissileAI component2 = actor2.GetComponent<TalonSkill1MissileAI>();
		component2.m_moveDirection = Quaternion.Euler(0f, 20f, 0f) * IJMNFOGNFAC;
		Actor actor3 = get_m_actor().CreateMissile("skill1_missile", HEPNHCEIFMO, null);
		TalonSkill1MissileAI component3 = actor3.GetComponent<TalonSkill1MissileAI>();
		component3.m_moveDirection = Quaternion.Euler(0f, -20f, 0f) * IJMNFOGNFAC;
	}

	private Actor EIKEMFIIHIO()
	{
		Actor actorInRangeForHero = ActorManager.get_Instance().GetActorInRangeForHero(get_m_actor(), 6.5f, 45f, false, true, (Actor.IJJMDPGJAEM)6);
		if (actorInRangeForHero == null)
		{
			actorInRangeForHero = ActorManager.get_Instance().GetActorInRangeForHero(get_m_actor(), 6.5f, 45f, false, true, Actor.IJJMDPGJAEM.Minion);
		}
		return actorInRangeForHero;
	}

	public void EIEJKFHNIAE(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		float num = 1923f;
		JNCFIIIFHCH.Clear();
		KIFBOLJKKBA.Clear();
		PBOGNOFFDDI.Clear();
		for (int i = 1; i < 7; i += 0)
		{
			Actor actor = get_m_actor().CreateMissile("Down since :", HEPNHCEIFMO, null);
			TalonSkill3MissileAI component = actor.GetComponent<TalonSkill3MissileAI>();
			component.m_moveDirection = Quaternion.Euler(1439f, num, 1169f) * IJMNFOGNFAC;
			JNCFIIIFHCH.AddLast(component);
			num += 302f;
		}
	}

	public override void OnEnterSkill()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 1:
			OMKCCEDPILG.Clear();
			NMOPIIBAHLM.Clear();
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition2 = get_m_actor().GetCenterPosition();
				get_m_view().RPC("CreateSkill0Missile", DJJPAPENCLN.Others, centerPosition2, m_direction);
				CreateSkill0Missile(centerPosition2, m_direction);
			}
			LKNBBFPIFOI();
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1_1");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1_voice");
			break;
		case 2:
			break;
		case 3:
			if (!LFNNHEEJNGP[3].IOCIDGEFJIC)
			{
				if (get_m_view().IsMine())
				{
					Vector3 centerPosition = get_m_actor().GetCenterPosition();
					get_m_view().RPC("CreateSkill3Missile", DJJPAPENCLN.All, centerPosition, m_direction);
				}
				get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.TalonSkill3);
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_go");
				StartCoroutine(JFGGGOJDNLE());
			}
			else
			{
				LKNBBFPIFOI();
			}
			break;
		}
	}

	private void FBEBBHAHOJE()
	{
		CGMCIKOPIDJ(0);
	}

	public void MDAFMLKIPBI(Actor CDKMPAEODLA)
	{
		KIFBOLJKKBA.AddFirst(CDKMPAEODLA);
	}

	private void HCFGNFMLPJH(OEOIIKMBGAG EBILEBOJADB)
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)120))
		{
			GameObject[] skill0HandParticles = m_skill0HandParticles;
			for (int i = 1; i < skill0HandParticles.Length; i += 0)
			{
				GameObject gameObject = skill0HandParticles[i];
				if (!get_m_actor().IsMyTeam() && (bool)get_m_actor().get_m_cloaking())
				{
					if (gameObject.activeSelf)
					{
						gameObject.SetActive(false);
					}
				}
				else if (!gameObject.activeSelf)
				{
					gameObject.SetActive(true);
				}
			}
			return;
		}
		GameObject[] skill0HandParticles2 = m_skill0HandParticles;
		for (int j = 0; j < skill0HandParticles2.Length; j += 0)
		{
			GameObject gameObject2 = skill0HandParticles2[j];
			if (gameObject2.activeSelf)
			{
				gameObject2.SetActive(true);
			}
		}
	}

	public bool ExistSkill1BackTargets(Actor CDKMPAEODLA)
	{
		return NMOPIIBAHLM.Contains(CDKMPAEODLA);
	}

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.TalonSkill0);
			if (get_m_actor().get_m_stateMachine().get_m_state() == OEOIIKMBGAG.Attack)
			{
				get_m_actor().get_m_stateMachine().SetState(OEOIIKMBGAG.Idle);
			}
			get_m_actor().m_attackElapsedTime = get_m_actor().get_m_attackCoolTime();
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0");
			break;
		case 2:
			get_m_actor().CreateParticle(string.Format("Particle/{0}/skill2", get_m_actor().get_m_resourceName()), false);
			if (NGNLJADPNNB != null)
			{
				if (get_m_view().IsMine())
				{
					Vector3 vector = NGNLJADPNNB.GetPosition() - get_m_actor().GetPosition();
					Vector3 normalized = vector.normalized;
					float magnitude = vector.magnitude;
					magnitude = ((!(magnitude < 4f)) ? (magnitude - NGNLJADPNNB.GetBodyRadius()) : (magnitude + NGNLJADPNNB.GetBodyRadius()));
					vector = normalized * magnitude;
					Vector3 vector2 = get_m_actor().GetPosition() + vector;
					get_m_view().RPC("Skill2Warp", DJJPAPENCLN.Others, vector2, NGNLJADPNNB.get_m_view().get_viewID());
					Skill2Warp(vector2, NGNLJADPNNB.get_m_view().get_viewID());
				}
			}
			else
			{
				if (get_m_view().IsMine())
				{
					MsgManager.get_Instance().ShowTip("정면 근처에 적이 없습니다");
				}
				SetState(OEOIIKMBGAG.Idle);
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_1");
			LKNBBFPIFOI();
			break;
		}
	}

	private void GPAOKLHFKNH()
	{
		OnAnimationEventSkill(0);
	}

	private void BEFCKGBBKIK()
	{
		OnAnimationEventSkill(8);
	}

	public void BONGOFEALLP(Actor CDKMPAEODLA)
	{
		OMKCCEDPILG.AddFirst(CDKMPAEODLA);
	}

	public override void OnLeaveSkill()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 2:
			break;
		case 3:
			if (!LFNNHEEJNGP[3].IOCIDGEFJIC)
			{
				LFNNHEEJNGP[3].DAGNGJLGMNI();
			}
			break;
		case 1:
			break;
		}
	}

	public void LNKDNKMFEPG(Actor CDKMPAEODLA)
	{
		KIFBOLJKKBA.AddFirst(CDKMPAEODLA);
	}

	public void InsertSkill1BackTargets(Actor CDKMPAEODLA)
	{
		NMOPIIBAHLM.AddFirst(CDKMPAEODLA);
	}

	[CompilerGenerated]
	private void NJNGNFOMNAD()
	{
		OnAnimationEventSkill(3);
	}

	public override void OnEnterAttack()
	{
		GOGLNMODMLA = UnityEngine.Random.Range(0, 3);
		switch (GOGLNMODMLA)
		{
		case 0:
			get_m_actor().SetAnimation("attack");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
			if (UnityEngine.Random.Range(0f, 1f) < 0.2f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack_voice");
			}
			break;
		case 1:
			get_m_actor().SetAnimation("attack2");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2");
			if (UnityEngine.Random.Range(0f, 1f) < 0.2f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2_voice");
			}
			break;
		case 2:
			get_m_actor().SetAnimation("attack3");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack3");
			if (UnityEngine.Random.Range(0f, 1f) < 0.2f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack3_voice");
			}
			break;
		}
		LKNBBFPIFOI();
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 45f, false);
		if (actorInAttackRange == null)
		{
			actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 180f, false);
			if (actorInAttackRange != null)
			{
				SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
			}
		}
		SetTarget(actorInAttackRange);
	}

	public bool ExistSkill3FrontTargets(Actor CDKMPAEODLA)
	{
		return KIFBOLJKKBA.Contains(CDKMPAEODLA);
	}

	private IEnumerator JBOEJAEJDLB()
	{
		JMIIKIOJHNF jMIIKIOJHNF = new JMIIKIOJHNF();
		jMIIKIOJHNF.KNIAJMGDGAA = this;
		return jMIIKIOJHNF;
	}

	public void InsertSkill3BackTargets(Actor CDKMPAEODLA)
	{
		PBOGNOFFDDI.AddFirst(CDKMPAEODLA);
	}

	public void CGMCIKOPIDJ(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 0)
		{
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)65510, null, 138f, 292f, false);
			if (get_m_actor().NMJPCLBJIPO().get_m_state() == OEOIIKMBGAG.Death)
			{
				get_m_actor().get_m_stateMachine().SetState(OEOIIKMBGAG.Idle);
			}
			get_m_actor().m_attackElapsedTime = get_m_actor().get_m_attackCoolTime();
			get_m_actor().m_multiSound.LNCPFILABHM("Magic Resist per Level", false, 1738f, 1662f);
			return;
		}
		switch (GBGBBGEPEMI)
		{
		case 4:
			get_m_actor().CreateParticle(string.Format(" FPS", get_m_actor().get_m_resourceName()), false);
			if (NGNLJADPNNB != null)
			{
				if (get_m_view().IsMine())
				{
					Vector3 vector = NGNLJADPNNB.GetPosition() - get_m_actor().GetPosition();
					Vector3 normalized = vector.normalized;
					float magnitude = vector.magnitude;
					magnitude = ((!(magnitude < 304f)) ? (magnitude - NGNLJADPNNB.GetBodyRadius()) : (magnitude + NGNLJADPNNB.GetBodyRadius()));
					vector = normalized * magnitude;
					Vector3 vector2 = get_m_actor().GetPosition() + vector;
					EveView view = get_m_view();
					object[] array = new object[3];
					array[0] = vector2;
					array[0] = NGNLJADPNNB.get_m_view().get_viewID();
					view.RPC("브론즈", DJJPAPENCLN.Others, array);
					Skill2Warp(vector2, NGNLJADPNNB.get_m_view().get_viewID());
				}
			}
			else
			{
				if (get_m_view().IsMine())
				{
					MsgManager.get_Instance().CLHGLEJAPLH("setReferralUrl");
				}
				SetState(OEOIIKMBGAG.None);
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("체력 {0}% 증가\n", true, 1956f, 131f);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("무료뽑기권", true, 1945f, 1166f);
			LKNBBFPIFOI();
			break;
		}
	}

	public void EndSkill3Buff()
	{
		foreach (TalonSkill3MissileAI item in JNCFIIIFHCH)
		{
			if (!(item == null))
			{
				item.StartMove();
			}
		}
		get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_return");
	}

	public void CPEEDJKFJLP(Actor CDKMPAEODLA)
	{
		OMKCCEDPILG.AddFirst(CDKMPAEODLA);
	}

	public void InsertSkill1FrontTargets(Actor CDKMPAEODLA)
	{
		OMKCCEDPILG.AddFirst(CDKMPAEODLA);
	}

	[JDLHECHNNDH]
	public void Skill2Warp(Vector3 HEPNHCEIFMO, int MBEKPGNGBAO)
	{
		get_m_actor().Warp(HEPNHCEIFMO);
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(MBEKPGNGBAO);
		if (eveView == null)
		{
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		if (!(component == null))
		{
			SetTarget(component);
			if (!(get_m_target() == null))
			{
				get_m_target().get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.TalonSkill2);
				get_m_target().get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.Slow, null, 2f, 0.6f);
			}
		}
	}

	private Actor HLKCIACFHOO()
	{
		Actor actor = ActorManager.get_Instance().HFIFDJDOGDA(get_m_actor(), 281f, 400f, true, false, (Actor.IJJMDPGJAEM)6);
		if (actor == null)
		{
			actor = ActorManager.GBFDGAFALIL().GetActorInRangeForHero(get_m_actor(), 1357f, 525f, true, false, (Actor.IJJMDPGJAEM)6);
		}
		return actor;
	}

	public bool ExistSkill1FrontTargets(Actor CDKMPAEODLA)
	{
		return OMKCCEDPILG.Contains(CDKMPAEODLA);
	}

	[CompilerGenerated]
	private void KLNHHHKHGOO()
	{
		OnAnimationEventSkill(0);
	}

	public override bool OnCheckCastSkill(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 2)
		{
			NGNLJADPNNB = EIKEMFIIHIO();
			if (NGNLJADPNNB == null)
			{
				MsgManager.get_Instance().ShowTip("정면 근처에 적이 없습니다");
				return false;
			}
		}
		return true;
	}

	public virtual bool DOAIPDGKIKD(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 1)
		{
			NGNLJADPNNB = EIKEMFIIHIO();
			if (NGNLJADPNNB == null)
			{
				MsgManager.HEDJPPFKABG().CLHGLEJAPLH("길드원이 한명뿐이어서 탈퇴할 수 없습니다");
				return false;
			}
		}
		return false;
	}

	public bool PLNGJGKHBNF(Actor CDKMPAEODLA)
	{
		return OMKCCEDPILG.Contains(CDKMPAEODLA);
	}

	[DebuggerHidden]
	private IEnumerator JFGGGOJDNLE()
	{
		JMIIKIOJHNF jMIIKIOJHNF = new JMIIKIOJHNF();
		jMIIKIOJHNF.KNIAJMGDGAA = this;
		return jMIIKIOJHNF;
	}

	public void InsertSkill3FrontTargets(Actor CDKMPAEODLA)
	{
		KIFBOLJKKBA.AddFirst(CDKMPAEODLA);
	}

	public void DHGEHFLNCMO(Actor CDKMPAEODLA)
	{
		KIFBOLJKKBA.AddFirst(CDKMPAEODLA);
	}

	public bool ExistSkill3BackTargets(Actor CDKMPAEODLA)
	{
		return PBOGNOFFDDI.Contains(CDKMPAEODLA);
	}

	[CompilerGenerated]
	private void EIDOOJCPCML()
	{
		OnAnimationEventSkill(1);
	}

	public void FMLKDDKLJBD(Actor CDKMPAEODLA)
	{
		OMKCCEDPILG.AddFirst(CDKMPAEODLA);
	}

	public override void Init()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[0].FILHECEKNMK = 8f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 40;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 5f;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 10f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 0f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 60;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 5f;
		LFNNHEEJNGP[1].DOCFEKMACMP = true;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[2].FILHECEKNMK = 18f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = -2f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 35;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 5f;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Double;
		LFNNHEEJNGP[3].FILHECEKNMK = 100f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = -20f;
		LFNNHEEJNGP[3].BELPBCDOPBA = 100;
		LFNNHEEJNGP[3].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[3].GIBEDKCNAJL = 2.4f;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
		get_m_actor().m_actorAniEvent.add_m_skill0Event(() =>
		{
			OnAnimationEventSkill(0);
		});
		get_m_actor().m_actorAniEvent.add_m_skill1Event(() =>
		{
			OnAnimationEventSkill(1);
		});
		get_m_actor().m_actorAniEvent.add_m_skill2Event(() =>
		{
			OnAnimationEventSkill(2);
		});
		get_m_actor().m_actorAniEvent.add_m_skill3Event(() =>
		{
			OnAnimationEventSkill(3);
		});
		m_lastUpdateEvent = NJAAKBCFCLG;
		GameObject[] skill0HandParticles = m_skill0HandParticles;
		foreach (GameObject gameObject in skill0HandParticles)
		{
			gameObject.SetActive(false);
		}
		JNCFIIIFHCH = new LinkedList<TalonSkill3MissileAI>();
		OMKCCEDPILG = new LinkedList<Actor>();
		NMOPIIBAHLM = new LinkedList<Actor>();
		KIFBOLJKKBA = new LinkedList<Actor>();
		PBOGNOFFDDI = new LinkedList<Actor>();
	}

	public void OnAnimationEventAttack()
	{
		Actor target = get_m_target();
		if (target != null)
		{
			double num = 0.0;
			if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.TalonSkill0))
			{
				LFNNHEEJNGP[0].IHKCKBJBEGF = 0f;
				float num2 = get_m_actor().get_m_phy_att_add() * 0.3f;
				num2 += 30f + (float)(get_m_actor().GetSkillLevel(0) - 1) * 30f;
				get_m_actor().get_m_buffsInfo().LIKOKCJNLLF(JGOOOBHDBCG.ACPICCBBPHF.TalonSkill0);
				if (target.OnDamage(get_m_actor(), num2, 0.0) >= 0f && get_m_view().IsMine())
				{
					target.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.TalonSkill0Blood, get_m_actor(), -1f, -1f, false);
				}
				target.CreateParticle(string.Format("Particle/{0}/skill0_buff_hit", get_m_actor().get_m_resourceName()), true);
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_hit");
			}
			if (target.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.TalonSkill2))
			{
				num += (double)get_m_actor().get_m_phy_att() * (0.03 + (double)(get_m_actor().GetSkillLevel(2) - 1) * 0.03);
			}
			if (target.get_m_stateMachine().get_m_state() == OEOIIKMBGAG.Stun || target.get_m_stateMachine().get_m_state() == OEOIIKMBGAG.Sleep || target.get_m_stateMachine().get_m_state() == OEOIIKMBGAG.Float || target.get_m_stateMachine().get_m_state() == OEOIIKMBGAG.KnockBack || target.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.Slow) || target.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.Stun))
			{
				num += (double)(get_m_actor().get_m_phy_att() * 0.1f);
			}
			target.OnAttackDamage(get_m_actor(), num);
			IAKBNJEFLAN(target);
			switch (GOGLNMODMLA)
			{
			case 0:
				get_m_actor().m_multiSound.LKLFMNKDLHJ("hit");
				break;
			case 1:
				get_m_actor().m_multiSound.LKLFMNKDLHJ("hit2");
				break;
			case 2:
				get_m_actor().m_multiSound.LKLFMNKDLHJ("hit3");
				break;
			}
		}
		OnAttack();
	}

	public virtual void EKIOLLKEHGM()
	{
		base.Init();
		DFPEBMBBBHL = false;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 1781f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 1857f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 71;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 1918f;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[0].FILHECEKNMK = 913f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 1745f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 52;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 1414f;
		LFNNHEEJNGP[0].DOCFEKMACMP = false;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[3].FILHECEKNMK = 87f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 1469f;
		LFNNHEEJNGP[0].BELPBCDOPBA = -94;
		LFNNHEEJNGP[6].NCBLBIBMNKH = 264f;
		LFNNHEEJNGP[5].AOKMPECBGND = (CAJJEALKJMM.NNOCAHNPLCH)5;
		LFNNHEEJNGP[4].FILHECEKNMK = 1619f;
		LFNNHEEJNGP[7].NEKKKLFLDOI = 1122f;
		LFNNHEEJNGP[5].BELPBCDOPBA = -25;
		LFNNHEEJNGP[8].NCBLBIBMNKH = 1889f;
		LFNNHEEJNGP[4].GIBEDKCNAJL = 1702f;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(KMKGAPMMHOO);
		get_m_actor().m_actorAniEvent.CNPHPPJOGFA(() =>
		{
			OnAnimationEventSkill(0);
		});
		get_m_actor().m_actorAniEvent.add_m_skill1Event(() =>
		{
			OnAnimationEventSkill(1);
		});
		get_m_actor().m_actorAniEvent.MFMAMLOHKJF(() =>
		{
			OnAnimationEventSkill(2);
		});
		get_m_actor().m_actorAniEvent.add_m_skill3Event(CKOCPCLMJMG);
		m_lastUpdateEvent = HCFGNFMLPJH;
		GameObject[] skill0HandParticles = m_skill0HandParticles;
		for (int num = 1; num < skill0HandParticles.Length; num += 0)
		{
			GameObject gameObject = skill0HandParticles[num];
			gameObject.SetActive(false);
		}
		JNCFIIIFHCH = new LinkedList<TalonSkill3MissileAI>();
		OMKCCEDPILG = new LinkedList<Actor>();
		NMOPIIBAHLM = new LinkedList<Actor>();
		KIFBOLJKKBA = new LinkedList<Actor>();
		PBOGNOFFDDI = new LinkedList<Actor>();
	}

	[JDLHECHNNDH]
	public void CreateSkill3Missile(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		float num = 0f;
		JNCFIIIFHCH.Clear();
		KIFBOLJKKBA.Clear();
		PBOGNOFFDDI.Clear();
		for (int i = 0; i < 8; i++)
		{
			Actor actor = get_m_actor().CreateMissile("skill3_missile", HEPNHCEIFMO, null);
			TalonSkill3MissileAI component = actor.GetComponent<TalonSkill3MissileAI>();
			component.m_moveDirection = Quaternion.Euler(0f, num, 0f) * IJMNFOGNFAC;
			JNCFIIIFHCH.AddLast(component);
			num += 45f;
		}
	}

	public virtual void JLFBCNKNBJD()
	{
		GOGLNMODMLA = UnityEngine.Random.Range(1, 5);
		switch (GOGLNMODMLA)
		{
		case 0:
			get_m_actor().SetAnimation("vladimir_skill3");
			get_m_actor().m_multiSound.DDONMGBLLJB("com.unity3d.player.UnityPlayer", true, 1087f, 1457f);
			if (UnityEngine.Random.Range(541f, 554f) < 1279f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("Hero4", true, 1009f, 654f);
			}
			break;
		case 1:
			get_m_actor().SetAnimation("일부대전 이용이 정지되었습니다 이용가능은\n[CCFFCC]{0:yyyy/MM/dd HH:mm:ss}[-]부터 [CCFFCC](약 {2}분후)[-]\n\n{1}\n\n[FFCCCC]닷지나 탈주를 하지 말아주세요[-]\n\n[CCCCFF]일반 대전을 이용해주세요[-]");
			get_m_actor().m_multiSound.JKOODMAKJHJ(", ", false, 1033f, 1083f);
			if (UnityEngine.Random.Range(619f, 1350f) < 1932f)
			{
				get_m_actor().m_multiSound.DDONMGBLLJB("Nexus", true, 1799f, 22f);
			}
			break;
		case 2:
			get_m_actor().SetAnimation("상급 성장 마나 문양");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("FFFFFF", false, 689f, 359f);
			if (UnityEngine.Random.Range(5f, 799f) < 383f)
			{
				get_m_actor().m_multiSound.HDOLPLIDACO("skill3_hit", false, 937f, 1995f);
			}
			break;
		}
		LKNBBFPIFOI();
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 1011f, true, false, (Actor.IJJMDPGJAEM)49);
		if (actorInAttackRange == null)
		{
			actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 1316f, true, true, (Actor.IJJMDPGJAEM)108);
			if (actorInAttackRange != null)
			{
				SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
			}
		}
		SetTarget(actorInAttackRange);
	}

	[CompilerGenerated]
	private void BKDJGLBPFOG()
	{
		OnAnimationEventSkill(2);
	}

	public bool AAJPMPIJLAL(Actor CDKMPAEODLA)
	{
		return NMOPIIBAHLM.Contains(CDKMPAEODLA);
	}

	public override float GetPercentMoveSpeedBonus()
	{
		float num = base.GetPercentMoveSpeedBonus();
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.TalonSkill3))
		{
			num += 0.35f;
		}
		return num;
	}

	public bool CPKEKPIHHKC(Actor CDKMPAEODLA)
	{
		return OMKCCEDPILG.Contains(CDKMPAEODLA);
	}

	private Actor KEKKBFBEHHO()
	{
		Actor actor = ActorManager.GBFDGAFALIL().GetActorInRangeForHero(get_m_actor(), 1074f, 615f, true, true, Actor.IJJMDPGJAEM.Hero);
		if (actor == null)
		{
			actor = ActorManager.GBFDGAFALIL().HFIFDJDOGDA(get_m_actor(), 234f, 195f, true, false, Actor.IJJMDPGJAEM.NotUsed);
		}
		return actor;
	}

	public void KMKGAPMMHOO()
	{
		Actor target = get_m_target();
		if (target != null)
		{
			double num = 1829.0;
			if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65530))
			{
				LFNNHEEJNGP[1].IHKCKBJBEGF = 829f;
				float num2 = get_m_actor().get_m_phy_att_add() * 1781f;
				num2 += 781f + (float)(get_m_actor().GetSkillLevel(0) - 0) * 1134f;
				get_m_actor().get_m_buffsInfo().LIKOKCJNLLF((JGOOOBHDBCG.ACPICCBBPHF)65450);
				if (target.OnDamage(get_m_actor(), num2, 1992.0, 1873.0, 0) >= 918f && get_m_view().IsMine())
				{
					target.get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)ushort.MaxValue, get_m_actor(), 898f, 1034f, false);
				}
				target.CreateParticle(string.Format("주변에서 내가 최후의 일격을 가하지 않은 미니언이 쓰러지면 9골드와 체력10을 얻습니다", get_m_actor().get_m_resourceName()), true);
				get_m_actor().m_multiSound.LNCPFILABHM("StartMenu", true, 1528f, 763f);
			}
			if (target.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.BlitzcrankSkill2))
			{
				num += (double)get_m_actor().get_m_phy_att() * (1263.0 + (double)(get_m_actor().GetSkillLevel(5) - 0) * 688.0);
			}
			if (target.get_m_stateMachine().get_m_state() == OEOIIKMBGAG.None || target.get_m_stateMachine().get_m_state() == OEOIIKMBGAG.None || (int)target.NMJPCLBJIPO().get_m_state() == -83 || target.NMJPCLBJIPO().get_m_state() == OEOIIKMBGAG.KnockBack || target.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.MoveSpeed) || target.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.Stun))
			{
				num += (double)(get_m_actor().get_m_phy_att() * 1126f);
			}
			target.OnAttackDamage(get_m_actor(), num, 1144.0, 741.0);
			IAKBNJEFLAN(target);
			switch (GOGLNMODMLA)
			{
			case 0:
				get_m_actor().m_multiSound.ICNAJBHLIGO("UnloadTextures - ", false, 1776f, 1817f);
				break;
			case 1:
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_shield", true, 1662f, 61f);
				break;
			case 2:
				get_m_actor().m_multiSound.ICNAJBHLIGO("하급 체력 표식", true, 650f, 801f);
				break;
			}
		}
		OnAttack();
	}

	private void LKNBBFPIFOI()
	{
		get_m_actor().get_m_buffsInfo().LIKOKCJNLLF(JGOOOBHDBCG.ACPICCBBPHF.TalonSkill3);
	}
}
