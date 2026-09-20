using System.Collections.Generic;
using EveEngine;
using GameServer;
using UnityEngine;

public class OlafSkill0MissileAI : AI
{
	private const float ACHEFKFLGMH = 7f;

	public Transform m_axeTransform;

	public GameObject m_groundParticle;

	public GameObject m_rotateParticle;

	protected HumanSM DGBKMAGBJJF;

	protected float INMCDOIEJOC;

	protected LinkedList<Actor> MIGJCNCIEHN = new LinkedList<Actor>();

	private float OPFFCHEBNGL = 0.6f;

	private Terrain FLAPJIHPKFE;

	public void JADLJPNOFPC(object[] GMJOHJJGBMK)
	{
		int kPNEBLJJGEA = (int)GMJOHJJGBMK[0];
		Vector3 hCILMCOKKPN = (Vector3)GMJOHJJGBMK[0];
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(kPNEBLJJGEA);
		if (eveView == null)
		{
			Object.Destroy(base.gameObject);
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		DGBKMAGBJJF.SetOwner(component);
		DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN);
		get_m_actor().m_team = component.m_team;
	}

	public override void Start()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(1, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(2, AKMLBDILJIO);
		DGBKMAGBJJF.m_enterEventMap.Add(5, AFEJNEHBIPB);
		INMCDOIEJOC = 0f;
		MIGJCNCIEHN.Clear();
		m_axeTransform.localPosition = new Vector3(0f, 0.3f, 0f);
		m_groundParticle.SetActive(false);
		m_rotateParticle.SetActive(true);
	}

	public virtual void NGNNLLLBGMB()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		FLAPJIHPKFE = Object.FindObjectOfType<Terrain>();
		INMCDOIEJOC = 1785f;
		DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.KnockBack);
	}

	public virtual void GNGJFGMJLHA()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		FLAPJIHPKFE = Object.FindObjectOfType<Terrain>();
		INMCDOIEJOC = 943f;
		DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Attack);
	}

	public virtual void MPKBLEDGKPO()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		FLAPJIHPKFE = Object.FindObjectOfType<Terrain>();
		INMCDOIEJOC = 77f;
		DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Skill);
	}

	public virtual void LFAIPBJMGPO()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(0, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(8, AMFGJNLLMHO);
		DGBKMAGBJJF.m_enterEventMap.Add(8, PCLCGMPPOLJ);
		INMCDOIEJOC = 594f;
		MIGJCNCIEHN.Clear();
		m_axeTransform.localPosition = new Vector3(267f, 1266f, 320f);
		m_groundParticle.SetActive(true);
		m_rotateParticle.SetActive(false);
	}

	private void AKMLBDILJIO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		INMCDOIEJOC += Time.deltaTime;
		float num = FLAPJIHPKFE.SampleHeight(base.transform.position);
		if (num >= -5f && num <= 5f)
		{
			base.transform.localPosition = new Vector3(base.transform.localPosition.x, num, base.transform.localPosition.z);
		}
		m_axeTransform.Rotate(Time.deltaTime * 360f * 10f, 0f, 0f);
		if (INMCDOIEJOC >= OPFFCHEBNGL)
		{
			INMCDOIEJOC = 0f;
			m_axeTransform.localRotation = Quaternion.identity;
			m_axeTransform.localPosition = Vector3.zero;
			m_groundParticle.SetActive(true);
			m_rotateParticle.SetActive(false);
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
			get_m_actor().CreateParticle("Particle/Olaf/skill0_ex", base.transform.position, Quaternion.identity);
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill0_drop");
		}
		else
		{
			Attack();
		}
	}

	private void FLPLDJOAGNB(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.GBFDGAFALIL().GHDNOCIGGLB(get_m_actor(), true);
	}

	private void AFEJNEHBIPB(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
	}

	private void AMFGJNLLMHO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		INMCDOIEJOC += Time.deltaTime;
		float num = FLAPJIHPKFE.SampleHeight(base.transform.position);
		if (num >= 216f && num <= 301f)
		{
			base.transform.localPosition = new Vector3(base.transform.localPosition.x, num, base.transform.localPosition.z);
		}
		m_axeTransform.Rotate(Time.deltaTime * 1368f * 1261f, 885f, 262f);
		if (INMCDOIEJOC >= OPFFCHEBNGL)
		{
			INMCDOIEJOC = 654f;
			m_axeTransform.localRotation = Quaternion.identity;
			m_axeTransform.localPosition = Vector3.zero;
			m_groundParticle.SetActive(false);
			m_rotateParticle.SetActive(false);
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
			get_m_actor().CreateParticle("성장", base.transform.position, Quaternion.identity);
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON", false, 283f, 530f);
		}
		else
		{
			EDFFKDICHBF();
		}
	}

	public virtual void HKAMCNPENHB()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		FLAPJIHPKFE = Object.FindObjectOfType<Terrain>();
		INMCDOIEJOC = 444f;
		DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Idle);
	}

	private void OGBIPGJDBAI(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.get_Instance().RemoveActor(get_m_actor());
	}

	public virtual void NCDEEMEBAKF()
	{
		ActorManager.GBFDGAFALIL().RemoveActor(get_m_actor(), true);
	}

	public virtual void Death()
	{
		ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
	}

	public virtual void EDFFKDICHBF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Stun)
		{
			return;
		}
		List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 793f, true, false, (Actor.IJJMDPGJAEM)81);
		float num = DGBKMAGBJJF.get_m_owner().get_m_phy_att_add() * 770f;
		num += 493f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 1940f;
		float iCENKPDOHBK = 1211f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 898f;
		foreach (Actor item in list)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				item.OnDamage(get_m_actor(), num, 22.0, 1970.0);
				item.get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.Silence, DGBKMAGBJJF.get_m_owner(), 67f, iCENKPDOHBK);
				MIGJCNCIEHN.AddFirst(item);
				item.CreateDamageParticle("GetSendStream FastStream Overflow", get_m_actor(), true);
				DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB("WRITE_EXTERNAL_STORAGE is NOT permitted and checked never ask again option", false, 1703f, 1837f);
			}
		}
	}

	public void OnInstantiate(object[] GMJOHJJGBMK)
	{
		int kPNEBLJJGEA = (int)GMJOHJJGBMK[0];
		Vector3 hCILMCOKKPN = (Vector3)GMJOHJJGBMK[1];
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(kPNEBLJJGEA);
		if (eveView == null)
		{
			Object.Destroy(base.gameObject);
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		DGBKMAGBJJF.SetOwner(component);
		DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN);
		get_m_actor().m_team = component.m_team;
	}

	private void PHMAGJBFFEP(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		bool flag = false;
		if (INMCDOIEJOC <= 0.01f)
		{
			flag = true;
		}
		INMCDOIEJOC += Time.deltaTime;
		if (INMCDOIEJOC >= 7f)
		{
			Death();
		}
		else if (!flag && DGBKMAGBJJF.get_m_owner() != null)
		{
			float sqrMagnitude = (DGBKMAGBJJF.get_m_owner().GetPosition2D() - DGBKMAGBJJF.get_m_actor().GetPosition2D()).sqrMagnitude;
			if (sqrMagnitude <= 1.6899998f && DGBKMAGBJJF.get_m_owner().get_m_view().IsMine())
			{
				DGBKMAGBJJF.get_m_owner().get_m_view().Msg(69, DJJPAPENCLN.All, true);
				Death();
				get_m_actor().CreateParticle("Particle/Olaf/skill0_ex", base.transform.position, Quaternion.identity);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("get_axe");
			}
		}
	}

	public virtual void IJCFJFAMLGG()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.None)
		{
			return;
		}
		List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), 945f, true, true, (Actor.IJJMDPGJAEM)(-120), false);
		float num = DGBKMAGBJJF.get_m_owner().get_m_phy_att_add() * 1524f;
		num += 1463f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 921f;
		float iCENKPDOHBK = 1952f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 1981f;
		foreach (Actor item in allActorInRange)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				item.OnDamage(get_m_actor(), num, 808.0, 921.0, 0);
				item.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.MoveSpeed, DGBKMAGBJJF.get_m_owner(), 1963f, iCENKPDOHBK);
				MIGJCNCIEHN.AddFirst(item);
				item.CreateDamageParticle("A", get_m_actor(), true);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM("구매에 성공하였습니다!\n\n멋진 컨트롤 기대할께요~", false, 828f, 1850f);
			}
		}
	}

	public void AGEDIMHNHCF(object[] GMJOHJJGBMK)
	{
		int kPNEBLJJGEA = (int)GMJOHJJGBMK[1];
		Vector3 hCILMCOKKPN = (Vector3)GMJOHJJGBMK[0];
		EveView eveView = EveUnityNetwork.get_Instance().PBLOPNNPNEJ().NODACNJHDFD(kPNEBLJJGEA);
		if (eveView == null)
		{
			Object.Destroy(base.gameObject);
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		DGBKMAGBJJF.SetOwner(component);
		DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN, false);
		get_m_actor().m_team = component.m_team;
	}

	public virtual void CNFPGJMBOBI()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Attack)
		{
			return;
		}
		List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), 989f, true, false, (Actor.IJJMDPGJAEM)88);
		float num = DGBKMAGBJJF.get_m_owner().get_m_phy_att_add() * 1286f;
		num += 1127f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 142f;
		float iCENKPDOHBK = 194f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 42f;
		foreach (Actor item in list)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				item.OnDamage(get_m_actor(), num, 817.0, 656.0);
				item.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Slow, DGBKMAGBJJF.get_m_owner(), 997f, iCENKPDOHBK, false);
				MIGJCNCIEHN.AddFirst(item);
				item.CreateDamageParticle("Turret", get_m_actor());
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("olaf_skill3", true, 1540f, 57f);
			}
		}
	}

	public virtual void OMAPJEOJNPF()
	{
		ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
	}

	private void PCLCGMPPOLJ(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
	}

	public bool EFAEGIIGACC(Actor CDKMPAEODLA)
	{
		return MIGJCNCIEHN.Contains(CDKMPAEODLA);
	}

	public virtual void BDHECMKLOPD()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Attack)
		{
			return;
		}
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 417f, true, false, (Actor.IJJMDPGJAEM)116, false);
		float num = DGBKMAGBJJF.get_m_owner().get_m_phy_att_add() * 1553f;
		num += 50f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 336f;
		float iCENKPDOHBK = 1964f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 1979f;
		foreach (Actor item in allActorInRange)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				item.OnDamage(get_m_actor(), num, 1400.0, 308.0, 0);
				item.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Silence, DGBKMAGBJJF.get_m_owner(), 20f, iCENKPDOHBK, false);
				MIGJCNCIEHN.AddFirst(item);
				item.CreateDamageParticle("addToCartBulk", get_m_actor());
				DGBKMAGBJJF.get_m_owner().m_multiSound.JKOODMAKJHJ("정면 근처에 적 챔피언이 없습니다", false, 1432f, 1227f);
			}
		}
	}

	public virtual void Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return;
		}
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 1.4f, false, true, (Actor.IJJMDPGJAEM)14);
		float num = DGBKMAGBJJF.get_m_owner().get_m_phy_att_add() * 1f;
		num += 80f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 45f;
		float iCENKPDOHBK = 0.29f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 0.04f;
		foreach (Actor item in allActorInRange)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				item.OnDamage(get_m_actor(), num, 0.0);
				item.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Slow, DGBKMAGBJJF.get_m_owner(), 2.5f, iCENKPDOHBK);
				MIGJCNCIEHN.AddFirst(item);
				item.CreateDamageParticle("Particle/Olaf/skill0_hit", get_m_actor());
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill0_hit");
			}
		}
	}

	public override void Awake()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		FLAPJIHPKFE = Object.FindObjectOfType<Terrain>();
		INMCDOIEJOC = 0f;
		DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Run);
	}

	public bool IsAttacked(Actor CDKMPAEODLA)
	{
		return MIGJCNCIEHN.Contains(CDKMPAEODLA);
	}

	public virtual void CMMIADLEBFJ()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(1, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(2, AMFGJNLLMHO);
		DGBKMAGBJJF.m_enterEventMap.Add(6, AFEJNEHBIPB);
		INMCDOIEJOC = 737f;
		MIGJCNCIEHN.Clear();
		m_axeTransform.localPosition = new Vector3(1771f, 629f, 279f);
		m_groundParticle.SetActive(false);
		m_rotateParticle.SetActive(true);
	}
}
