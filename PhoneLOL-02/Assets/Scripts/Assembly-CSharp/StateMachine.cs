using System;
using System.Collections.Generic;
using EveEngine;
using GameServer;
using UnityEngine;

public abstract class StateMachine : MonoBehaviour, OEKJBKLGNCE, KMDHFPLEMDD
{
	public enum OEOIIKMBGAG : byte
	{
		None = 0,
		Idle = 1,
		Run = 2,
		Attack = 3,
		Skill = 4,
		Death = 5,
		Sleep = 6,
		Stun = 7,
		KnockBack = 8,
		Float = 9,
		Temptation = 10
	}

	public delegate void EIBKGCOILIA(OEOIIKMBGAG EBILEBOJADB);

	public delegate void BDLKHOEGLNM(Actor PKDGAIKAMMM, float CMNPJALNFIC);

	private sealed class CBKIHNMDJJI
	{
		internal Vector2 HEPNHCEIFMO;

		internal float KMILPEHBBEL;

		internal StateMachine KNIAJMGDGAA;

		internal void KEPEIBDAFNL(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_nextState());
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void FMNMJPLICGL(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_nextState());
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void HPDPAGGIPHN(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_nextState());
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void DBMNPBIKGCE(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_nextState());
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void BEAKPMDCBDG(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_nextState());
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.PFAIBIMGAIB(KMILPEHBBEL);
		}

		internal void DBOEKDIAMGN(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_nextState());
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void MCPFAOKCNHN(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_nextState());
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.PFAIBIMGAIB(KMILPEHBBEL);
		}

		internal void NKDONEDDLKD(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_nextState());
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.PFAIBIMGAIB(KMILPEHBBEL);
		}

		internal void KCLLFLHBDOE(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_nextState());
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void IBLDIKEAGKP(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_nextState());
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void NFEGFCNHPKA(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_nextState());
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(KMILPEHBBEL);
		}

		internal void NMCCHNJMGHO(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_nextState());
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.PFAIBIMGAIB(KMILPEHBBEL);
		}

		internal void AALCPOFPCJC(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_nextState());
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.PFAIBIMGAIB(KMILPEHBBEL);
		}
	}

	private sealed class HKEGJNLAJDB
	{
		internal bool FKKMCEDDJKJ;

		internal HumanSM BMONDKABJDP;

		internal CBKIHNMDJJI OHGHKHKFDMB;

		internal StateMachine KNIAJMGDGAA;

		internal void FPPEMNOFGCL(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_nextState());
			OGJFDNEEDCP.GBMJNFOEACC((byte)KNIAJMGDGAA.get_m_nextSkill());
			OGJFDNEEDCP.GBMJNFOEACC(FKKMCEDDJKJ);
			OGJFDNEEDCP.GBMJNFOEACC(OHGHKHKFDMB.HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(BMONDKABJDP.m_direction);
			OGJFDNEEDCP.GBMJNFOEACC(BMONDKABJDP.m_moveDirection);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_actor().m_mp);
		}

		internal void ALHDGAHJGKH(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_nextState());
			OGJFDNEEDCP.GBMJNFOEACC((byte)KNIAJMGDGAA.get_m_nextSkill());
			OGJFDNEEDCP.GBMJNFOEACC(FKKMCEDDJKJ);
			OGJFDNEEDCP.GBMJNFOEACC(OHGHKHKFDMB.HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(BMONDKABJDP.m_direction);
			OGJFDNEEDCP.GBMJNFOEACC(BMONDKABJDP.m_moveDirection);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_actor().m_mp);
		}

		internal void AKLNDGILCGG(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_nextState());
			OGJFDNEEDCP.GBMJNFOEACC((byte)KNIAJMGDGAA.get_m_nextSkill());
			OGJFDNEEDCP.GBMJNFOEACC(FKKMCEDDJKJ);
			OGJFDNEEDCP.GBMJNFOEACC(OHGHKHKFDMB.HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(BMONDKABJDP.m_direction);
			OGJFDNEEDCP.GBMJNFOEACC(BMONDKABJDP.m_moveDirection);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_actor().m_mp);
		}

		internal void KJJOOLDJBKM(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_nextState());
			OGJFDNEEDCP.GBMJNFOEACC((byte)KNIAJMGDGAA.get_m_nextSkill());
			OGJFDNEEDCP.GBMJNFOEACC(FKKMCEDDJKJ);
			OGJFDNEEDCP.GBMJNFOEACC(OHGHKHKFDMB.HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(BMONDKABJDP.m_direction);
			OGJFDNEEDCP.GBMJNFOEACC(BMONDKABJDP.m_moveDirection);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_actor().m_mp);
		}

		internal void CFGLFIOLNKI(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_nextState());
			OGJFDNEEDCP.GBMJNFOEACC((byte)KNIAJMGDGAA.get_m_nextSkill());
			OGJFDNEEDCP.GBMJNFOEACC(FKKMCEDDJKJ);
			OGJFDNEEDCP.GBMJNFOEACC(OHGHKHKFDMB.HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(BMONDKABJDP.m_direction);
			OGJFDNEEDCP.GBMJNFOEACC(BMONDKABJDP.m_moveDirection);
			OGJFDNEEDCP.PFAIBIMGAIB(KNIAJMGDGAA.get_m_actor().m_mp);
		}

		internal void CCCDNOGJHIO(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_nextState());
			OGJFDNEEDCP.GBMJNFOEACC((byte)KNIAJMGDGAA.get_m_nextSkill());
			OGJFDNEEDCP.GBMJNFOEACC(FKKMCEDDJKJ);
			OGJFDNEEDCP.GBMJNFOEACC(OHGHKHKFDMB.HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(BMONDKABJDP.m_direction);
			OGJFDNEEDCP.GBMJNFOEACC(BMONDKABJDP.m_moveDirection);
			OGJFDNEEDCP.PFAIBIMGAIB(KNIAJMGDGAA.get_m_actor().m_mp);
		}

		internal void EPFPHOGKPEJ(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_nextState());
			OGJFDNEEDCP.GBMJNFOEACC((byte)KNIAJMGDGAA.get_m_nextSkill());
			OGJFDNEEDCP.GBMJNFOEACC(FKKMCEDDJKJ);
			OGJFDNEEDCP.GBMJNFOEACC(OHGHKHKFDMB.HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(BMONDKABJDP.m_direction);
			OGJFDNEEDCP.GBMJNFOEACC(BMONDKABJDP.m_moveDirection);
			OGJFDNEEDCP.PFAIBIMGAIB(KNIAJMGDGAA.get_m_actor().m_mp);
		}

		internal void HNDKHBBKHBP(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_nextState());
			OGJFDNEEDCP.GBMJNFOEACC((byte)KNIAJMGDGAA.get_m_nextSkill());
			OGJFDNEEDCP.GBMJNFOEACC(FKKMCEDDJKJ);
			OGJFDNEEDCP.GBMJNFOEACC(OHGHKHKFDMB.HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(BMONDKABJDP.m_direction);
			OGJFDNEEDCP.GBMJNFOEACC(BMONDKABJDP.m_moveDirection);
			OGJFDNEEDCP.PFAIBIMGAIB(KNIAJMGDGAA.get_m_actor().m_mp);
		}

		internal void LOOOJJNOHNE(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_nextState());
			OGJFDNEEDCP.GBMJNFOEACC((byte)KNIAJMGDGAA.get_m_nextSkill());
			OGJFDNEEDCP.GBMJNFOEACC(FKKMCEDDJKJ);
			OGJFDNEEDCP.GBMJNFOEACC(OHGHKHKFDMB.HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(BMONDKABJDP.m_direction);
			OGJFDNEEDCP.GBMJNFOEACC(BMONDKABJDP.m_moveDirection);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.get_m_actor().m_mp);
		}
	}

	protected ActorNetwork JKLLIAHPLNJ;

	[NonSerialized]
	public Vector3 m_floatPower = Vector3.zero;

	protected bool DFPEBMBBBHL;

	[NonSerialized]
	public Dictionary<byte, EIBKGCOILIA> m_enterEventMap = new Dictionary<byte, EIBKGCOILIA>();

	[NonSerialized]
	public Dictionary<byte, EIBKGCOILIA> m_leaveEventMap = new Dictionary<byte, EIBKGCOILIA>();

	[NonSerialized]
	public Dictionary<byte, EIBKGCOILIA> m_updateEventMap = new Dictionary<byte, EIBKGCOILIA>();

	[NonSerialized]
	public EIBKGCOILIA m_lastUpdateEvent;

	[NonSerialized]
	public BDLKHOEGLNM m_onDamage;

	private int KPAEDHANLNN;

	private OEOIIKMBGAG BBEEPJNEHBI;

	private OEOIIKMBGAG EMJJAMDLCPE;

	private Actor LKENHHHFOFD;

	private EveView PFHHNPPCOED;

	private Actor LOAKCPOHPPN;

	private Actor EJNBNKDGHLJ;

	private int GBMGBJAOGHM;

	private int PFJEIDFBNEF;

	private Transform OGONHDMMABA;

	public OEOIIKMBGAG GFKDNKFPPAM
	{
		get
		{
			return get_m_state();
		}
		protected set
		{
			FJPMFBBCBLB(value);
		}
	}

	public OEOIIKMBGAG DEMLACCLEOM
	{
		get
		{
			return get_m_nextState();
		}
		protected set
		{
			DPKKJBIPGJJ(value);
		}
	}

	public Actor MEDAGKOPJMO
	{
		get
		{
			return get_m_actor();
		}
		protected set
		{
			JANLLMBFACF(value);
		}
	}

	public EveView GHLOJMDIHNE
	{
		get
		{
			return get_m_view();
		}
		protected set
		{
			NOLEMPCHIGH(value);
		}
	}

	public Actor MKKJMOOCBIE
	{
		get
		{
			return get_m_owner();
		}
		protected set
		{
			ANLLPPCLCFL(value);
		}
	}

	public Actor LDEDLKCCLMG
	{
		get
		{
			return get_m_target();
		}
		protected set
		{
			IAKBNJEFLAN(value);
		}
	}

	public int NDAFKDOHNOD
	{
		get
		{
			return get_m_skill();
		}
		protected set
		{
			KFBMEEHJFOB(value);
		}
	}

	public int HGGGLBPKCIN
	{
		get
		{
			return get_m_nextSkill();
		}
		protected set
		{
			BMLLKCKIFAO(value);
		}
	}

	public Transform NKLLEJLLNKA
	{
		get
		{
			return get_m_transform();
		}
		private set
		{
			LLGADBKNEOF(value);
		}
	}

	public OEOIIKMBGAG get_m_state()
	{
		return BBEEPJNEHBI;
	}

	protected void FJPMFBBCBLB(OEOIIKMBGAG ICENKPDOHBK)
	{
		BBEEPJNEHBI = ICENKPDOHBK;
	}

	public OEOIIKMBGAG get_m_nextState()
	{
		return EMJJAMDLCPE;
	}

	protected void DPKKJBIPGJJ(OEOIIKMBGAG ICENKPDOHBK)
	{
		EMJJAMDLCPE = ICENKPDOHBK;
	}

	public Actor get_m_actor()
	{
		return LKENHHHFOFD;
	}

	protected void JANLLMBFACF(Actor ICENKPDOHBK)
	{
		LKENHHHFOFD = ICENKPDOHBK;
	}

	public EveView get_m_view()
	{
		return PFHHNPPCOED;
	}

	protected void NOLEMPCHIGH(EveView ICENKPDOHBK)
	{
		PFHHNPPCOED = ICENKPDOHBK;
	}

	public Actor get_m_owner()
	{
		return LOAKCPOHPPN;
	}

	protected void ANLLPPCLCFL(Actor ICENKPDOHBK)
	{
		LOAKCPOHPPN = ICENKPDOHBK;
	}

	public Actor get_m_target()
	{
		return EJNBNKDGHLJ;
	}

	protected void IAKBNJEFLAN(Actor ICENKPDOHBK)
	{
		EJNBNKDGHLJ = ICENKPDOHBK;
	}

	public int get_m_skill()
	{
		return GBMGBJAOGHM;
	}

	protected void KFBMEEHJFOB(int ICENKPDOHBK)
	{
		GBMGBJAOGHM = ICENKPDOHBK;
	}

	public int get_m_nextSkill()
	{
		return PFJEIDFBNEF;
	}

	protected void BMLLKCKIFAO(int ICENKPDOHBK)
	{
		PFJEIDFBNEF = ICENKPDOHBK;
	}

	public Transform get_m_transform()
	{
		return OGONHDMMABA;
	}

	private void LLGADBKNEOF(Transform ICENKPDOHBK)
	{
		OGONHDMMABA = ICENKPDOHBK;
	}

	public virtual void Awake()
	{
		LLGADBKNEOF(base.transform);
	}

	public virtual void Init()
	{
		FJPMFBBCBLB(OEOIIKMBGAG.Idle);
		DPKKJBIPGJJ(OEOIIKMBGAG.None);
		KFBMEEHJFOB(0);
		BMLLKCKIFAO(-1);
		m_floatPower = Vector3.zero;
		JANLLMBFACF(GetComponent<Actor>());
		JKLLIAHPLNJ = GetComponent<ActorNetwork>();
		NOLEMPCHIGH(GetComponent<EveView>());
	}

	public virtual void DoUpdate()
	{
		try
		{
			switch (get_m_state())
			{
			case OEOIIKMBGAG.Idle:
				OnUpdateIdle();
				break;
			case OEOIIKMBGAG.Run:
				OnUpdateRun();
				break;
			case OEOIIKMBGAG.Attack:
				OnUpdateAttack();
				break;
			case OEOIIKMBGAG.Skill:
				OnUpdateSkill();
				break;
			case OEOIIKMBGAG.Death:
				OnUpdateDeath();
				break;
			case OEOIIKMBGAG.Sleep:
				OnUpdateSleep();
				break;
			case OEOIIKMBGAG.Stun:
				OnUpdateStun();
				break;
			case OEOIIKMBGAG.KnockBack:
				OnUpdateKnockBack();
				break;
			case OEOIIKMBGAG.Float:
				OnUpdateFloat();
				break;
			case OEOIIKMBGAG.Temptation:
				OnUpdateTemptation();
				break;
			}
			EIBKGCOILIA value = null;
			if (m_updateEventMap.TryGetValue((byte)get_m_state(), out value))
			{
				value(get_m_state());
			}
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
		}
		OEOIIKMBGAG state = get_m_state();
		if (get_m_nextState() != OEOIIKMBGAG.None && get_m_nextState() == get_m_state())
		{
			DPKKJBIPGJJ(OEOIIKMBGAG.None);
		}
		bool flag = false;
		if (get_m_nextState() != OEOIIKMBGAG.None && get_m_nextState() != get_m_state())
		{
			FJPMFBBCBLB(get_m_nextState());
			DPKKJBIPGJJ(OEOIIKMBGAG.None);
			flag = true;
		}
		if (get_m_nextSkill() >= 0)
		{
			flag = true;
		}
		if (flag)
		{
			try
			{
				switch (state)
				{
				case OEOIIKMBGAG.Idle:
					OnLeaveIdle();
					break;
				case OEOIIKMBGAG.Run:
					OnLeaveRun();
					break;
				case OEOIIKMBGAG.Attack:
					OnLeaveAttack();
					break;
				case OEOIIKMBGAG.Skill:
					OnLeaveSkill();
					break;
				case OEOIIKMBGAG.Death:
					OnLeaveDeath();
					break;
				case OEOIIKMBGAG.Sleep:
					OnLeaveSleep();
					break;
				case OEOIIKMBGAG.Stun:
					OnLeaveStun();
					break;
				case OEOIIKMBGAG.KnockBack:
					OnLeaveKnockBack();
					break;
				case OEOIIKMBGAG.Float:
					OnLeaveFloat();
					break;
				case OEOIIKMBGAG.Temptation:
					OnLeaveTemptation();
					break;
				}
				EIBKGCOILIA value2 = null;
				if (m_leaveEventMap.TryGetValue((byte)state, out value2))
				{
					value2(get_m_state());
				}
			}
			catch (Exception exception2)
			{
				Debug.LogException(exception2);
			}
			if (get_m_nextSkill() >= 0)
			{
				KFBMEEHJFOB(get_m_nextSkill());
				BMLLKCKIFAO(-1);
			}
			try
			{
				switch (get_m_state())
				{
				case OEOIIKMBGAG.Idle:
					OnEnterIdle();
					break;
				case OEOIIKMBGAG.Run:
					OnEnterRun();
					break;
				case OEOIIKMBGAG.Attack:
					OnEnterAttack();
					break;
				case OEOIIKMBGAG.Skill:
					OnEnterSkill();
					break;
				case OEOIIKMBGAG.Death:
					OnEnterDeath();
					break;
				case OEOIIKMBGAG.Sleep:
					OnEnterSleep();
					break;
				case OEOIIKMBGAG.Stun:
					OnEnterStun();
					break;
				case OEOIIKMBGAG.KnockBack:
					OnEnterKnockBack();
					break;
				case OEOIIKMBGAG.Float:
					OnEnterFloat();
					break;
				case OEOIIKMBGAG.Temptation:
					OnEnterTemptation();
					break;
				}
				EIBKGCOILIA value3 = null;
				if (m_enterEventMap.TryGetValue((byte)get_m_state(), out value3))
				{
					value3(state);
				}
			}
			catch (Exception exception3)
			{
				Debug.LogException(exception3);
			}
		}
		OnLastUpdate();
		if (m_lastUpdateEvent != null)
		{
			m_lastUpdateEvent(get_m_state());
		}
		if (get_m_actor() != null && get_m_actor().get_m_view() != null && get_m_actor().get_m_view().IsMine() && (float)get_m_actor().m_hp <= 0f && get_m_state() != OEOIIKMBGAG.Death && get_m_nextState() != OEOIIKMBGAG.Death)
		{
			SetState(OEOIIKMBGAG.Death);
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
		KPAEDHANLNN++;
	}

	private void FixedUpdate()
	{
		DoUpdate();
	}

	public void SetState(OEOIIKMBGAG EBILEBOJADB)
	{
		if (!OnTrySetState(get_m_state(), get_m_nextState(), EBILEBOJADB) || (get_m_nextState() == OEOIIKMBGAG.Float && (EBILEBOJADB == OEOIIKMBGAG.Idle || EBILEBOJADB == OEOIIKMBGAG.Run || EBILEBOJADB == OEOIIKMBGAG.Skill)) || (get_m_state() == EBILEBOJADB && get_m_nextState() == OEOIIKMBGAG.None && (get_m_state() != OEOIIKMBGAG.Skill || EBILEBOJADB != OEOIIKMBGAG.Skill || get_m_nextSkill() < 0)) || get_m_state() == OEOIIKMBGAG.Death || get_m_nextState() == OEOIIKMBGAG.Death || get_m_nextState() == OEOIIKMBGAG.Skill)
		{
			return;
		}
		DPKKJBIPGJJ(EBILEBOJADB);
		OnSetState(get_m_state(), get_m_nextState());
		if (!(get_m_view() != null) || !get_m_view().IsMine() || !(base.gameObject.GetComponent<HumanSM>() != null))
		{
			return;
		}
		CBKIHNMDJJI cBKIHNMDJJI = new CBKIHNMDJJI();
		cBKIHNMDJJI.KNIAJMGDGAA = this;
		cBKIHNMDJJI.HEPNHCEIFMO = Vector2.zero;
		cBKIHNMDJJI.HEPNHCEIFMO.x = get_m_transform().localPosition.x;
		cBKIHNMDJJI.HEPNHCEIFMO.y = get_m_transform().localPosition.z;
		cBKIHNMDJJI.KMILPEHBBEL = get_m_transform().localRotation.eulerAngles.y;
		if (DFPEBMBBBHL && EBILEBOJADB == OEOIIKMBGAG.Attack)
		{
			get_m_view().Msg(1, DJJPAPENCLN.Others, true, cBKIHNMDJJI.IBLDIKEAGKP);
			return;
		}
		switch (EBILEBOJADB)
		{
		case OEOIIKMBGAG.Skill:
		{
			HKEGJNLAJDB hKEGJNLAJDB = new HKEGJNLAJDB();
			hKEGJNLAJDB.OHGHKHKFDMB = cBKIHNMDJJI;
			hKEGJNLAJDB.KNIAJMGDGAA = this;
			hKEGJNLAJDB.FKKMCEDDJKJ = false;
			hKEGJNLAJDB.BMONDKABJDP = (HumanSM)this;
			if (hKEGJNLAJDB.BMONDKABJDP != null)
			{
				hKEGJNLAJDB.FKKMCEDDJKJ = hKEGJNLAJDB.BMONDKABJDP.GetCastSkill(get_m_nextSkill()).IOCIDGEFJIC;
				get_m_view().Msg(2, DJJPAPENCLN.Others, true, hKEGJNLAJDB.AKLNDGILCGG);
			}
			break;
		}
		case OEOIIKMBGAG.Death:
			get_m_view().Msg(1, DJJPAPENCLN.Others, true, cBKIHNMDJJI.NFEGFCNHPKA);
			break;
		default:
			get_m_view().Msg(1, DJJPAPENCLN.Others, false, cBKIHNMDJJI.HPDPAGGIPHN);
			break;
		}
	}

	public void SetStateForce(OEOIIKMBGAG EBILEBOJADB)
	{
		DPKKJBIPGJJ(OEOIIKMBGAG.None);
		FJPMFBBCBLB(EBILEBOJADB);
	}

	public void ChangeState(OEOIIKMBGAG EBILEBOJADB, Vector3 HEPNHCEIFMO)
	{
		if (get_m_state() != OEOIIKMBGAG.Death && get_m_nextState() != OEOIIKMBGAG.Death)
		{
			DPKKJBIPGJJ(EBILEBOJADB);
			get_m_transform().position = HEPNHCEIFMO;
		}
	}

	public void ChangeState(OEOIIKMBGAG EBILEBOJADB)
	{
		if (get_m_state() != OEOIIKMBGAG.Death && get_m_nextState() != OEOIIKMBGAG.Death)
		{
			DPKKJBIPGJJ(EBILEBOJADB);
		}
	}

	public void SetOwner(Actor CDKMPAEODLA)
	{
		ANLLPPCLCFL(CDKMPAEODLA);
	}

	public void SetTarget(Actor CDKMPAEODLA)
	{
		IAKBNJEFLAN(CDKMPAEODLA);
	}

	public void SetSkillState(int GBGBBGEPEMI)
	{
		BMLLKCKIFAO(GBGBBGEPEMI);
		SetState(OEOIIKMBGAG.Skill);
	}

	public virtual void OnEnterIdle()
	{
	}

	public virtual void OnUpdateIdle()
	{
	}

	public virtual void OnLeaveIdle()
	{
	}

	public abstract void OnEnterRun();

	public abstract void OnUpdateRun();

	public abstract void OnLeaveRun();

	public virtual void OnEnterAttack()
	{
	}

	public virtual void OnUpdateAttack()
	{
	}

	public virtual void OnLeaveAttack()
	{
	}

	public virtual void OnEnterSkill()
	{
	}

	public virtual void OnUpdateSkill()
	{
	}

	public virtual void OnLeaveSkill()
	{
	}

	public virtual void OnEnterDeath()
	{
	}

	public virtual void OnUpdateDeath()
	{
	}

	public virtual void OnLeaveDeath()
	{
	}

	public virtual void OnEnterSleep()
	{
	}

	public virtual void OnUpdateSleep()
	{
	}

	public virtual void OnLeaveSleep()
	{
	}

	public virtual void OnEnterStun()
	{
	}

	public virtual void OnUpdateStun()
	{
	}

	public virtual void OnLeaveStun()
	{
	}

	public virtual void OnEnterKnockBack()
	{
	}

	public virtual void OnUpdateKnockBack()
	{
	}

	public virtual void OnLeaveKnockBack()
	{
	}

	public virtual void OnEnterFloat()
	{
	}

	public virtual void OnUpdateFloat()
	{
	}

	public virtual void OnLeaveFloat()
	{
	}

	public virtual void OnEnterTemptation()
	{
	}

	public virtual void OnUpdateTemptation()
	{
	}

	public virtual void OnLeaveTemptation()
	{
	}

	public virtual void OnAttack()
	{
	}

	public virtual void OnLastUpdate()
	{
	}

	public virtual void OnStageInit()
	{
	}

	public virtual void OnSetState(OEOIIKMBGAG HMJDCBCOODN, OEOIIKMBGAG HIJLHGKJKNJ)
	{
	}

	public virtual float OnPreDamage(Actor PKDGAIKAMMM, byte JBJEMLFEBGK, float CMNPJALNFIC)
	{
		return CMNPJALNFIC;
	}

	public virtual void OnDamage(Actor PKDGAIKAMMM, float CMNPJALNFIC)
	{
		if (m_onDamage != null)
		{
			m_onDamage(PKDGAIKAMMM, CMNPJALNFIC);
		}
	}

	public virtual bool OnTrySetState(OEOIIKMBGAG HMJDCBCOODN, OEOIIKMBGAG HIJLHGKJKNJ, OEOIIKMBGAG NHADCKCLPDN)
	{
		return true;
	}

	public virtual bool OnCheckCastSkill(int GBGBBGEPEMI)
	{
		return true;
	}

	public virtual float GetPercentMoveSpeedBonus()
	{
		return 0f;
	}

	public virtual float GetMoveSpeedBonus()
	{
		return 0f;
	}

	public virtual float GetPlusAttackSpeed()
	{
		return 0f;
	}

	public virtual void OnDisable()
	{
	}

	public virtual void OnKillHero(Actor JMEDKCPCJNA)
	{
	}

	public virtual void OnAssistHero(Actor JMEDKCPCJNA)
	{
	}

	public virtual bool OnCheckBuff(IDMGMJLOKBB DAHPLNJAPGO, Actor PGGLHMPOBBP)
	{
		return true;
	}

	public virtual bool OnCheckFloat()
	{
		return true;
	}

	public virtual bool OnCheckKnockBack()
	{
		return true;
	}

	public virtual void OnSerializeRecovery(NMAHNGDIIEF OGJFDNEEDCP)
	{
	}

	public abstract void OnMsgView(byte IKKFLANGAEA, KCIGFAHFHCH OGJFDNEEDCP);

	public virtual void OnSerializeView(KCIGFAHFHCH OGJFDNEEDCP)
	{
		OGJFDNEEDCP.GBMJNFOEACC((byte)get_m_state());
		if ((bool)get_m_owner() && (bool)get_m_owner().get_m_view())
		{
			OGJFDNEEDCP.GBMJNFOEACC(get_m_owner().get_m_view().get_viewID());
		}
		else
		{
			OGJFDNEEDCP.GBMJNFOEACC(0);
		}
	}

	public virtual void OnDeserializeView(KCIGFAHFHCH OGJFDNEEDCP)
	{
		byte ICENKPDOHBK;
		OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK);
		int ICENKPDOHBK2;
		OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK2);
		FJPMFBBCBLB((OEOIIKMBGAG)ICENKPDOHBK);
		if (ICENKPDOHBK2 > 0)
		{
			EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(ICENKPDOHBK2);
			if ((bool)eveView)
			{
				ANLLPPCLCFL(eveView.GetComponent<Actor>());
			}
		}
	}
}
