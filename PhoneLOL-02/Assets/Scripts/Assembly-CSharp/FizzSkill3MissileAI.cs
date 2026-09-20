using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class FizzSkill3MissileAI : AI, OEKJBKLGNCE
{
	private sealed class AOOLHCPMKFL
	{
		internal Actor LPOAEBNAGCP;

		internal FizzSkill3MissileAI KNIAJMGDGAA;

		internal void FMMPKMAHHOH(KCIGFAHFHCH OGJFDNEEDCP)
		{
			if (LPOAEBNAGCP != null)
			{
				OGJFDNEEDCP.GBMJNFOEACC(LPOAEBNAGCP.get_m_view().get_viewID());
			}
			else
			{
				OGJFDNEEDCP.GBMJNFOEACC(0);
			}
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.transform.position);
		}

		internal void IDFPAGEBKLC(KCIGFAHFHCH OGJFDNEEDCP)
		{
			if (LPOAEBNAGCP != null)
			{
				OGJFDNEEDCP.GBMJNFOEACC(LPOAEBNAGCP.get_m_view().get_viewID());
			}
			else
			{
				OGJFDNEEDCP.GBMJNFOEACC(1);
			}
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.transform.position);
		}

		internal void OLBDCJLNKFP(KCIGFAHFHCH OGJFDNEEDCP)
		{
			if (LPOAEBNAGCP != null)
			{
				OGJFDNEEDCP.GBMJNFOEACC(LPOAEBNAGCP.get_m_view().get_viewID());
			}
			else
			{
				OGJFDNEEDCP.GBMJNFOEACC(0);
			}
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.transform.position);
		}

		internal void PICJOBMDOOD(KCIGFAHFHCH OGJFDNEEDCP)
		{
			if (LPOAEBNAGCP != null)
			{
				OGJFDNEEDCP.GBMJNFOEACC(LPOAEBNAGCP.get_m_view().get_viewID());
			}
			else
			{
				OGJFDNEEDCP.GBMJNFOEACC(1);
			}
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.transform.position);
		}

		internal void NNOLNLJINKG(KCIGFAHFHCH OGJFDNEEDCP)
		{
			if (LPOAEBNAGCP != null)
			{
				OGJFDNEEDCP.GBMJNFOEACC(LPOAEBNAGCP.get_m_view().get_viewID());
			}
			else
			{
				OGJFDNEEDCP.GBMJNFOEACC(0);
			}
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.transform.position);
		}

		internal void GMDCMEOMEJA(KCIGFAHFHCH OGJFDNEEDCP)
		{
			if (LPOAEBNAGCP != null)
			{
				OGJFDNEEDCP.GBMJNFOEACC(LPOAEBNAGCP.get_m_view().get_viewID());
			}
			else
			{
				OGJFDNEEDCP.GBMJNFOEACC(0);
			}
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.transform.position);
		}

		internal void BEKOJMNONGG(KCIGFAHFHCH OGJFDNEEDCP)
		{
			if (LPOAEBNAGCP != null)
			{
				OGJFDNEEDCP.GBMJNFOEACC(LPOAEBNAGCP.get_m_view().get_viewID());
			}
			else
			{
				OGJFDNEEDCP.GBMJNFOEACC(1);
			}
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.transform.position);
		}

		internal void BJJIJAAAHCL(KCIGFAHFHCH OGJFDNEEDCP)
		{
			if (LPOAEBNAGCP != null)
			{
				OGJFDNEEDCP.GBMJNFOEACC(LPOAEBNAGCP.get_m_view().get_viewID());
			}
			else
			{
				OGJFDNEEDCP.GBMJNFOEACC(1);
			}
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.transform.position);
		}
	}

	private const float ACHEFKFLGMH = 2f;

	public GameObject m_runObject;

	public GameObject m_idleObject;

	protected HumanSM DGBKMAGBJJF;

	protected float INMCDOIEJOC;

	protected Actor PBPBLCMDFLC;

	private float OPFFCHEBNGL = 0.83f;

	private Terrain FLAPJIHPKFE;

	private bool POKEAECEEHH;

	private bool OPNBLPMKGED;

	public override void Awake()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		FLAPJIHPKFE = Object.FindObjectOfType<Terrain>();
		INMCDOIEJOC = 0f;
		DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Run);
		m_runObject.SetActive(true);
		m_idleObject.SetActive(false);
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

	public virtual void Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Death && !(PBPBLCMDFLC != null))
		{
			PBPBLCMDFLC = ActorManager.get_Instance().GetActorInRange(get_m_actor(), 1.5f, false, true, Actor.IJJMDPGJAEM.Hero);
			if (PBPBLCMDFLC != null)
			{
				GHNBKBJMJKJ(PBPBLCMDFLC);
			}
		}
	}

	public void ABIOBEJLBLA()
	{
		if (!OPNBLPMKGED)
		{
			OPNBLPMKGED = true;
			if (get_m_actor().get_m_view().IsMine())
			{
				get_m_actor().get_m_view().NIKPELEGLNE(236, DJJPAPENCLN.All, false, DFEJAJJJIBL);
			}
		}
	}

	private void LHGOBKHELID(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.GBFDGAFALIL().GHDNOCIGGLB(get_m_actor(), true);
	}

	private void DFEJAJJJIBL(KCIGFAHFHCH OGJFDNEEDCP)
	{
		OGJFDNEEDCP.GBMJNFOEACC(base.transform.position);
	}

	[CompilerGenerated]
	private void OBLJOGFFEDL(KCIGFAHFHCH OGJFDNEEDCP)
	{
		OGJFDNEEDCP.GBMJNFOEACC(base.transform.position);
	}

	private void OGBIPGJDBAI(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.GBFDGAFALIL().RemoveActor(get_m_actor());
	}

	private void AFEJNEHBIPB(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
	}

	public virtual void MKCBHHEACDE()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		FLAPJIHPKFE = Object.FindObjectOfType<Terrain>();
		INMCDOIEJOC = 518f;
		DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Death);
		m_runObject.SetActive(false);
		m_idleObject.SetActive(false);
	}

	public virtual void IPFEBDCDMFA()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(1, HCPFIGGGGCK);
		DGBKMAGBJJF.m_updateEventMap.Add(3, AKMLBDILJIO);
		DGBKMAGBJJF.m_enterEventMap.Add(3, LHGOBKHELID);
		INMCDOIEJOC = 143f;
	}

	public virtual void MPKBLEDGKPO()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		FLAPJIHPKFE = Object.FindObjectOfType<Terrain>();
		INMCDOIEJOC = 510f;
		DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Death);
		m_runObject.SetActive(false);
		m_idleObject.SetActive(true);
	}

	public void OnMsgView(byte IKKFLANGAEA, KCIGFAHFHCH OGJFDNEEDCP)
	{
		switch ((ICOGNNKEKHJ)IKKFLANGAEA)
		{
		case ICOGNNKEKHJ.FizzSkill3SetIdle:
		{
			int ICENKPDOHBK2;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK2);
			Vector3 ICENKPDOHBK3;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK3);
			if (ICENKPDOHBK2 != 0)
			{
				EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(ICENKPDOHBK2);
				if (eveView == null)
				{
					break;
				}
				PBPBLCMDFLC = eveView.GetComponent<Actor>();
			}
			if (PBPBLCMDFLC != null)
			{
				PBPBLCMDFLC.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.Slow, DGBKMAGBJJF.get_m_owner(), 2f, 0.7f);
				if (DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) > 0 && !PBPBLCMDFLC.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.FizzSkill1Passive))
				{
					PBPBLCMDFLC.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.FizzSkill1Passive, DGBKMAGBJJF.get_m_owner());
				}
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill3_hit");
			}
			INMCDOIEJOC = 0f;
			DGBKMAGBJJF.ChangeState(StateMachine.OEOIIKMBGAG.Idle, ICENKPDOHBK3);
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill3_idle");
			m_runObject.SetActive(false);
			m_idleObject.SetActive(true);
			break;
		}
		case ICOGNNKEKHJ.FizzSkill3SetShark:
		{
			Vector3 ICENKPDOHBK;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK);
			base.transform.position = ICENKPDOHBK;
			if (DGBKMAGBJJF.get_m_owner().m_heroCostumeID == 1)
			{
				get_m_actor().CreateParticle("Particle/Fizz/skill3_shark_c1", base.transform.localPosition, Quaternion.identity);
			}
			else
			{
				get_m_actor().CreateParticle("Particle/Fizz/skill3_shark", base.transform.localPosition, Quaternion.identity);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill3_shark");
			float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1.2f;
			num += 300f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 1) * 100f;
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 2.5f, false, true, (Actor.IJJMDPGJAEM)14);
			foreach (Actor item in allActorInRange)
			{
				item.OnDamage(DGBKMAGBJJF.get_m_owner(), 0.0, num);
				if (item.m_lastDamageInfo.IKAIHHIDHFK)
				{
					continue;
				}
				if (PBPBLCMDFLC != null && item == PBPBLCMDFLC)
				{
					item.GetHumanSM().FloatRemote(Vector3.zero, 5f);
					continue;
				}
				Vector3 normalized = (item.transform.localPosition - get_m_actor().transform.localPosition).normalized;
				normalized *= 8f;
				normalized.y = 0f;
				item.GetHumanSM().FloatRemote(normalized, 1f);
				if (DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) > 0 && !item.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.FizzSkill1Passive))
				{
					item.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.FizzSkill1Passive, DGBKMAGBJJF.get_m_owner());
				}
				item.CreateParticle("Particle/Fizz/skill3_hit", false);
			}
			ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
			break;
		}
		}
	}

	public void GDKLCKPFOHG(object[] GMJOHJJGBMK)
	{
		int kPNEBLJJGEA = (int)GMJOHJJGBMK[0];
		Vector3 hCILMCOKKPN = (Vector3)GMJOHJJGBMK[1];
		EveView eveView = EveUnityNetwork.get_Instance().HCDPDNMLNDE().NODACNJHDFD(kPNEBLJJGEA);
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

	private void GHNBKBJMJKJ(Actor LPOAEBNAGCP)
	{
		AOOLHCPMKFL aOOLHCPMKFL = new AOOLHCPMKFL();
		aOOLHCPMKFL.LPOAEBNAGCP = LPOAEBNAGCP;
		aOOLHCPMKFL.KNIAJMGDGAA = this;
		if (!POKEAECEEHH)
		{
			POKEAECEEHH = true;
			if (get_m_actor().get_m_view().IsMine())
			{
				get_m_actor().get_m_view().Msg(71, DJJPAPENCLN.All, true, aOOLHCPMKFL.GMDCMEOMEJA);
			}
		}
	}

	public void SetShark()
	{
		if (OPNBLPMKGED)
		{
			return;
		}
		OPNBLPMKGED = true;
		if (get_m_actor().get_m_view().IsMine())
		{
			get_m_actor().get_m_view().Msg(72, DJJPAPENCLN.All, true, (KCIGFAHFHCH OGJFDNEEDCP) =>
			{
				OGJFDNEEDCP.GBMJNFOEACC(base.transform.position);
			});
		}
	}

	public override void Start()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(1, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(2, AKMLBDILJIO);
		DGBKMAGBJJF.m_enterEventMap.Add(5, AFEJNEHBIPB);
		INMCDOIEJOC = 0f;
	}

	public virtual void NJNMBGLIJEJ()
	{
		if (DGBKMAGBJJF.get_m_nextState() != StateMachine.OEOIIKMBGAG.Run && !(PBPBLCMDFLC != null))
		{
			PBPBLCMDFLC = ActorManager.GBFDGAFALIL().DCMODJADKEE(get_m_actor(), 450f, false, true, Actor.IJJMDPGJAEM.Unknown, true);
			if (PBPBLCMDFLC != null)
			{
				GHNBKBJMJKJ(PBPBLCMDFLC);
			}
		}
	}

	private void PHMAGJBFFEP(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		INMCDOIEJOC += Time.deltaTime;
		if (INMCDOIEJOC >= 2f)
		{
			SetShark();
		}
		else if (PBPBLCMDFLC != null)
		{
			base.transform.localPosition = PBPBLCMDFLC.transform.localPosition;
		}
	}

	private void HCPFIGGGGCK(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		INMCDOIEJOC += Time.deltaTime;
		if (INMCDOIEJOC >= 1415f)
		{
			ABIOBEJLBLA();
		}
		else if (PBPBLCMDFLC != null)
		{
			base.transform.localPosition = PBPBLCMDFLC.transform.localPosition;
		}
	}

	public void GNBFGPBENDD(byte IKKFLANGAEA, KCIGFAHFHCH OGJFDNEEDCP)
	{
		switch ((int)IKKFLANGAEA)
		{
		case -41:
		{
			int ICENKPDOHBK2;
			OGJFDNEEDCP.GALCFOLBAAK(out ICENKPDOHBK2);
			Vector3 ICENKPDOHBK3;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK3);
			if (ICENKPDOHBK2 != 0)
			{
				EveView eveView = EveUnityNetwork.get_Instance().HCDPDNMLNDE().NODACNJHDFD(ICENKPDOHBK2);
				if (eveView == null)
				{
					break;
				}
				PBPBLCMDFLC = eveView.GetComponent<Actor>();
			}
			if (PBPBLCMDFLC != null)
			{
				PBPBLCMDFLC.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.Slow, DGBKMAGBJJF.get_m_owner(), 285f, 563f);
				if (DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) > 1 && !PBPBLCMDFLC.get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)86))
				{
					PBPBLCMDFLC.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.AhriSkill2, DGBKMAGBJJF.get_m_owner(), 239f, 475f);
				}
				DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK("TestCampaignID", false, 1487f, 916f);
			}
			INMCDOIEJOC = 817f;
			DGBKMAGBJJF.ChangeState(StateMachine.OEOIIKMBGAG.None, ICENKPDOHBK3);
			DGBKMAGBJJF.get_m_owner().m_multiSound.DDONMGBLLJB("Skill0FailRpc", false, 1113f, 576f);
			m_runObject.SetActive(false);
			m_idleObject.SetActive(false);
			break;
		}
		case -11:
		{
			Vector3 ICENKPDOHBK;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK);
			base.transform.position = ICENKPDOHBK;
			if (DGBKMAGBJJF.get_m_owner().m_heroCostumeID == 1)
			{
				get_m_actor().CreateParticle("AutoChange", base.transform.localPosition, Quaternion.identity);
			}
			else
			{
				get_m_actor().CreateParticle(" FPS", base.transform.localPosition, Quaternion.identity);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("baseBufferCount", true, 503f, 1761f);
			float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1380f;
			num += 1004f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(5) - 0) * 270f;
			List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), 445f, false, false, (Actor.IJJMDPGJAEM)77, false);
			foreach (Actor item in list)
			{
				item.OnDamage(DGBKMAGBJJF.get_m_owner(), 65.0, num, 1964.0, 0);
				if (item.m_lastDamageInfo.IKAIHHIDHFK)
				{
					continue;
				}
				if (PBPBLCMDFLC != null && item == PBPBLCMDFLC)
				{
					item.GetHumanSM().FloatRemote(Vector3.zero, 14f);
					continue;
				}
				Vector3 normalized = (item.transform.localPosition - get_m_actor().transform.localPosition).normalized;
				normalized *= 568f;
				normalized.y = 916f;
				item.GetHumanSM().OJPMFBHELBI(normalized, 1661f);
				if (DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) > 1 && !item.get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)111))
				{
					item.get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.SivirPassive, DGBKMAGBJJF.get_m_owner(), 1f, 413f);
				}
				item.CreateParticle("GameWin", false);
			}
			ActorManager.get_Instance().GHDNOCIGGLB(get_m_actor());
			break;
		}
		}
	}

	private void IAEJDLCFJID(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		ActorManager.get_Instance().GHDNOCIGGLB(get_m_actor(), true);
	}

	public virtual void GDJCOAHJDLN()
	{
		base.Start();
		DGBKMAGBJJF.m_updateEventMap.Add(0, PHMAGJBFFEP);
		DGBKMAGBJJF.m_updateEventMap.Add(3, AKMLBDILJIO);
		DGBKMAGBJJF.m_enterEventMap.Add(1, IAEJDLCFJID);
		INMCDOIEJOC = 1132f;
	}

	public void LAFCAMKKDKF(byte IKKFLANGAEA, KCIGFAHFHCH OGJFDNEEDCP)
	{
		switch ((int)IKKFLANGAEA)
		{
		case -10:
		{
			int ICENKPDOHBK2;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK2);
			Vector3 ICENKPDOHBK3;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK3);
			if (ICENKPDOHBK2 != 0)
			{
				EveView eveView = EveUnityNetwork.get_Instance().PBLOPNNPNEJ().NODACNJHDFD(ICENKPDOHBK2);
				if (eveView == null)
				{
					break;
				}
				PBPBLCMDFLC = eveView.GetComponent<Actor>();
			}
			if (PBPBLCMDFLC != null)
			{
				PBPBLCMDFLC.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.Slow, DGBKMAGBJJF.get_m_owner(), 1282f, 1282f);
				if (DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) > 0 && !PBPBLCMDFLC.get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65530))
				{
					PBPBLCMDFLC.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.Blue, DGBKMAGBJJF.get_m_owner(), 760f, 486f);
				}
				DGBKMAGBJJF.get_m_owner().m_multiSound.JKOODMAKJHJ("하급 주문력 정수", true, 231f, 561f);
			}
			INMCDOIEJOC = 985f;
			DGBKMAGBJJF.ChangeState(StateMachine.OEOIIKMBGAG.None, ICENKPDOHBK3);
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("설명", false, 1125f, 1645f);
			m_runObject.SetActive(false);
			m_idleObject.SetActive(false);
			break;
		}
		case 32:
		{
			Vector3 ICENKPDOHBK;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK);
			base.transform.position = ICENKPDOHBK;
			if (DGBKMAGBJJF.get_m_owner().m_heroCostumeID == 0)
			{
				get_m_actor().CreateParticle("5초당 체력회복 {0}\n", base.transform.localPosition, Quaternion.identity);
			}
			else
			{
				get_m_actor().CreateParticle("attack", base.transform.localPosition, Quaternion.identity);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK("Down since :", false, 1228f, 572f);
			float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 580f;
			num += 874f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(5) - 1) * 296f;
			List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), 1191f, false, true, (Actor.IJJMDPGJAEM)(-110), false);
			foreach (Actor item in list)
			{
				item.OnDamage(DGBKMAGBJJF.get_m_owner(), 1254.0, num, 1788.0);
				if (item.m_lastDamageInfo.IKAIHHIDHFK)
				{
					continue;
				}
				if (PBPBLCMDFLC != null && item == PBPBLCMDFLC)
				{
					item.GetHumanSM().OJPMFBHELBI(Vector3.zero, 1325f);
					continue;
				}
				Vector3 normalized = (item.transform.localPosition - get_m_actor().transform.localPosition).normalized;
				normalized *= 1054f;
				normalized.y = 1515f;
				item.GetHumanSM().FloatRemote(normalized, 178f);
				if (DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) > 0 && !item.get_m_buffsInfo().KNINEDPJMJE(JGOOOBHDBCG.ACPICCBBPHF.YasuoPassive))
				{
					item.get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)65476, DGBKMAGBJJF.get_m_owner(), 674f, 1158f, false);
				}
				item.CreateParticle("TextTwist", true);
			}
			ActorManager.GBFDGAFALIL().RemoveActor(get_m_actor());
			break;
		}
		}
	}

	public virtual void FPFNIFKNOIF()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		FLAPJIHPKFE = Object.FindObjectOfType<Terrain>();
		INMCDOIEJOC = 1356f;
		DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Skill);
		m_runObject.SetActive(true);
		m_idleObject.SetActive(false);
	}

	private void AKMLBDILJIO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		INMCDOIEJOC += Time.deltaTime;
		float num = FLAPJIHPKFE.SampleHeight(base.transform.position);
		if (num >= -5f && num <= 5f)
		{
			base.transform.localPosition = new Vector3(base.transform.localPosition.x, num, base.transform.localPosition.z);
		}
		if (INMCDOIEJOC >= OPFFCHEBNGL)
		{
			GHNBKBJMJKJ(null);
		}
		else
		{
			Attack();
		}
	}

	public virtual void GNGJFGMJLHA()
	{
		base.Awake();
		DGBKMAGBJJF = GetComponent<HumanSM>();
		FLAPJIHPKFE = Object.FindObjectOfType<Terrain>();
		INMCDOIEJOC = 186f;
		DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Death);
		m_runObject.SetActive(true);
		m_idleObject.SetActive(true);
	}

	public void AHMANJHBOLB(object[] GMJOHJJGBMK)
	{
		int kPNEBLJJGEA = (int)GMJOHJJGBMK[0];
		Vector3 hCILMCOKKPN = (Vector3)GMJOHJJGBMK[0];
		EveView eveView = EveUnityNetwork.get_Instance().PBLOPNNPNEJ().NLALKBLCPFK(kPNEBLJJGEA);
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
}
