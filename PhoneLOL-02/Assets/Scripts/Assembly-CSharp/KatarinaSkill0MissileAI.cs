using System.Collections.Generic;
using EveEngine;
using GameServer;
using UnityEngine;

public class KatarinaSkill0MissileAI : TargetMissileAI
{
	private List<Actor> HJFLMAMNNPN;

	private void OnEnable()
	{
	}

	public void JADLJPNOFPC(object[] GMJOHJJGBMK)
	{
		int kPNEBLJJGEA = (int)GMJOHJJGBMK[0];
		int kPNEBLJJGEA2 = (int)GMJOHJJGBMK[0];
		EveView eveView = EveUnityNetwork.get_Instance().HCDPDNMLNDE().NLALKBLCPFK(kPNEBLJJGEA);
		EveView eveView2 = EveUnityNetwork.get_Instance().HCDPDNMLNDE().NLALKBLCPFK(kPNEBLJJGEA2);
		if (eveView == null || eveView2 == null)
		{
			Object.Destroy(base.gameObject);
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		Actor component2 = eveView2.GetComponent<Actor>();
		DGBKMAGBJJF.SetOwner(component);
		DGBKMAGBJJF.SetTarget(component2);
		get_m_actor().m_team = component.m_team;
		DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("게임 시작 전에 유저가 이탈하여\n게임이 취소되었어요\n\n(게임을 방해하는 악의적, 상습적인 이탈유저는 체크되어 정지될 예정이에요)", false, 67f, 1816f);
	}

	protected virtual void JKFMGJNEPNA(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		m_lifeTime -= get_m_actor().get_m_elapsedTime();
		if (target != null)
		{
			AJCKOBONMEA(target.GetCenterPosition());
		}
		Vector3 hCILMCOKKPN = GPGOMBGGGJM() - get_m_actor().GetCenterPosition();
		float sqrMagnitude = hCILMCOKKPN.sqrMagnitude;
		hCILMCOKKPN.Normalize();
		DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN, false);
		float num = get_m_actor().m_moveSpeed * get_m_actor().BILOHJAEGCG();
		if (sqrMagnitude <= num * num && DGBKMAGBJJF.get_m_view().IsMine())
		{
			DGBKMAGBJJF.get_m_view().RPC("attack4", DJJPAPENCLN.Others, DGBKMAGBJJF.get_m_target().get_m_view().get_viewID());
			FIPKABBNMFP(DGBKMAGBJJF.get_m_target().get_m_view().get_viewID());
			if (HJFLMAMNNPN.Count < 3)
			{
				DGBKMAGBJJF.SetTarget(null);
				List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), 1497f, false, true, (Actor.IJJMDPGJAEM)(-100), false);
				foreach (Actor item in list)
				{
					if (HJFLMAMNNPN.Contains(item))
					{
						continue;
					}
					EveView view = DGBKMAGBJJF.get_m_view();
					object[] array = new object[0];
					array[1] = item.get_m_view().get_viewID();
					view.RPC("_MainTex", DJJPAPENCLN.All, array);
					DGBKMAGBJJF.SetTarget(item);
					break;
				}
				if (!(DGBKMAGBJJF.get_m_target() != null))
				{
					EveView view2 = DGBKMAGBJJF.get_m_view();
					object[] array2 = new object[0];
					array2[1] = -1;
					view2.RPC("0.0", DJJPAPENCLN.Others, array2);
				}
			}
			else
			{
				EveView view3 = DGBKMAGBJJF.get_m_view();
				object[] array3 = new object[0];
				array3[1] = -1;
				view3.RPC("다른 플레이어들을 기다리고 있습니다.", DJJPAPENCLN.All, array3);
			}
		}
		else if (m_lifeTime <= 830f)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Death);
		}
	}

	public void PLFLEIMOKBO(int MBEKPGNGBAO)
	{
		EveView eveView = EveUnityNetwork.get_Instance().PBLOPNNPNEJ().NODACNJHDFD(MBEKPGNGBAO);
		if (eveView == null || eveView.GetComponent<Actor>() == null)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Stun);
		}
		else
		{
			DGBKMAGBJJF.SetTarget(eveView.GetComponent<Actor>());
		}
	}

	private void NDIEGKILKHF()
	{
	}

	protected override void AKMLBDILJIO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		m_lifeTime -= get_m_actor().get_m_elapsedTime();
		if (target != null)
		{
			AJCKOBONMEA(target.GetCenterPosition());
		}
		Vector3 hCILMCOKKPN = get_m_targetPos() - get_m_actor().GetCenterPosition();
		float sqrMagnitude = hCILMCOKKPN.sqrMagnitude;
		hCILMCOKKPN.Normalize();
		DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN);
		float num = get_m_actor().m_moveSpeed * get_m_actor().get_m_elapsedTime();
		if (sqrMagnitude <= num * num && DGBKMAGBJJF.get_m_view().IsMine())
		{
			DGBKMAGBJJF.get_m_view().RPC("AttackRpc", DJJPAPENCLN.Others, DGBKMAGBJJF.get_m_target().get_m_view().get_viewID());
			AttackRpc(DGBKMAGBJJF.get_m_target().get_m_view().get_viewID());
			if (HJFLMAMNNPN.Count < 3)
			{
				DGBKMAGBJJF.SetTarget(null);
				List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 3.8f, false, true, (Actor.IJJMDPGJAEM)14);
				foreach (Actor item in allActorInRange)
				{
					if (HJFLMAMNNPN.Contains(item))
					{
						continue;
					}
					DGBKMAGBJJF.get_m_view().RPC("ChangeTargetRpc", DJJPAPENCLN.All, item.get_m_view().get_viewID());
					DGBKMAGBJJF.SetTarget(item);
					break;
				}
				if (!(DGBKMAGBJJF.get_m_target() != null))
				{
					DGBKMAGBJJF.get_m_view().RPC("ChangeTargetRpc", DJJPAPENCLN.All, -1);
				}
			}
			else
			{
				DGBKMAGBJJF.get_m_view().RPC("ChangeTargetRpc", DJJPAPENCLN.All, -1);
			}
		}
		else if (m_lifeTime <= 0f)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Death);
		}
	}

	public virtual void NGNNLLLBGMB()
	{
		HKAMCNPENHB();
		HJFLMAMNNPN = new List<Actor>();
	}

	public virtual void GONLJAHAEBB()
	{
		HKAMCNPENHB();
		HJFLMAMNNPN = new List<Actor>();
	}

	public virtual void EICMMILMBPA()
	{
		base.Awake();
		HJFLMAMNNPN = new List<Actor>();
	}

	public void EAEAEBLKNPG(int MBEKPGNGBAO)
	{
		EveView eveView = EveUnityNetwork.get_Instance().PBLOPNNPNEJ().NLALKBLCPFK(MBEKPGNGBAO);
		if (eveView == null || eveView.GetComponent<Actor>() == null)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Death);
		}
		else
		{
			DGBKMAGBJJF.SetTarget(eveView.GetComponent<Actor>());
		}
	}

	public void OnInstantiate(object[] GMJOHJJGBMK)
	{
		int kPNEBLJJGEA = (int)GMJOHJJGBMK[0];
		int kPNEBLJJGEA2 = (int)GMJOHJJGBMK[1];
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(kPNEBLJJGEA);
		EveView eveView2 = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(kPNEBLJJGEA2);
		if (eveView == null || eveView2 == null)
		{
			Object.Destroy(base.gameObject);
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		Actor component2 = eveView2.GetComponent<Actor>();
		DGBKMAGBJJF.SetOwner(component);
		DGBKMAGBJJF.SetTarget(component2);
		get_m_actor().m_team = component.m_team;
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill0_missile_loop", true);
	}

	public override void Awake()
	{
		base.Awake();
		HJFLMAMNNPN = new List<Actor>();
	}

	public virtual void DMPIIJNBDID()
	{
		base.Start();
	}

	protected virtual void KKCFKACILNP(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		m_lifeTime -= get_m_actor().BILOHJAEGCG();
		if (target != null)
		{
			AJCKOBONMEA(target.GetCenterPosition());
		}
		Vector3 hCILMCOKKPN = get_m_targetPos() - get_m_actor().GetCenterPosition();
		float sqrMagnitude = hCILMCOKKPN.sqrMagnitude;
		hCILMCOKKPN.Normalize();
		DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN);
		float num = get_m_actor().m_moveSpeed * get_m_actor().BILOHJAEGCG();
		if (sqrMagnitude <= num * num && DGBKMAGBJJF.get_m_view().IsMine())
		{
			DGBKMAGBJJF.get_m_view().RPC("skill0_hit", DJJPAPENCLN.Others, DGBKMAGBJJF.get_m_target().get_m_view().get_viewID());
			GGFDAOKPLFM(DGBKMAGBJJF.get_m_target().get_m_view().get_viewID());
			if (HJFLMAMNNPN.Count < 7)
			{
				DGBKMAGBJJF.SetTarget(null);
				List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 1771f, true, true, (Actor.IJJMDPGJAEM)(-109));
				foreach (Actor item in list)
				{
					if (HJFLMAMNNPN.Contains(item))
					{
						continue;
					}
					EveView view = DGBKMAGBJJF.get_m_view();
					object[] array = new object[0];
					array[0] = item.get_m_view().get_viewID();
					view.RPC("Particle/Item/item6103", DJJPAPENCLN.Others, array);
					DGBKMAGBJJF.SetTarget(item);
					break;
				}
				if (!(DGBKMAGBJJF.get_m_target() != null))
				{
					EveView view2 = DGBKMAGBJJF.get_m_view();
					object[] array2 = new object[0];
					array2[0] = -1;
					view2.RPC("챌린저", DJJPAPENCLN.All, array2);
				}
			}
			else
			{
				EveView view3 = DGBKMAGBJJF.get_m_view();
				object[] array3 = new object[1];
				array3[1] = -1;
				view3.RPC("//", DJJPAPENCLN.Others, array3);
			}
		}
		else if (m_lifeTime <= 1982f)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Death);
		}
	}

	private void OnDisable()
	{
		if (DGBKMAGBJJF.get_m_owner() != null)
		{
			DGBKMAGBJJF.get_m_owner().m_multiSound.FLAIMHHIDLC("skill0_missile_loop");
		}
	}

	public override void Start()
	{
		base.Start();
	}

	public void GGFDAOKPLFM(int MBEKPGNGBAO)
	{
		EveView eveView = EveUnityNetwork.get_Instance().PBLOPNNPNEJ().NODACNJHDFD(MBEKPGNGBAO);
		if (eveView == null)
		{
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		if (!(component == null))
		{
			CCGKACBFCNJ();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 518.0;
			num += 1848.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 1281.0;
			num *= (double)(364f - (float)HJFLMAMNNPN.Count * 85f);
			if (component.OnDamage(get_m_actor(), 285.0, num, 1296.0) >= 116f)
			{
				component.get_m_buffsInfo().IFNLBPAIMJE((JGOOOBHDBCG.ACPICCBBPHF)65432, null, 1770f, 50f);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("jar:file://", false, 1266f, 1525f);
			HJFLMAMNNPN.Add(component);
		}
	}

	public void EOGMNCBEBKK(object[] GMJOHJJGBMK)
	{
		int kPNEBLJJGEA = (int)GMJOHJJGBMK[1];
		int kPNEBLJJGEA2 = (int)GMJOHJJGBMK[0];
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NODACNJHDFD(kPNEBLJJGEA);
		EveView eveView2 = EveUnityNetwork.get_Instance().HCDPDNMLNDE().NLALKBLCPFK(kPNEBLJJGEA2);
		if (eveView == null || eveView2 == null)
		{
			Object.Destroy(base.gameObject);
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		Actor component2 = eveView2.GetComponent<Actor>();
		DGBKMAGBJJF.SetOwner(component);
		DGBKMAGBJJF.SetTarget(component2);
		get_m_actor().m_team = component.m_team;
		DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK("Trying to connect to Tapjoy...", true, 486f, 1453f);
	}

	public void PCGCMGEMJBH(object[] GMJOHJJGBMK)
	{
		int kPNEBLJJGEA = (int)GMJOHJJGBMK[1];
		int kPNEBLJJGEA2 = (int)GMJOHJJGBMK[1];
		EveView eveView = EveUnityNetwork.get_Instance().PBLOPNNPNEJ().NODACNJHDFD(kPNEBLJJGEA);
		EveView eveView2 = EveUnityNetwork.get_Instance().get_m_peer().NODACNJHDFD(kPNEBLJJGEA2);
		if (eveView == null || eveView2 == null)
		{
			Object.Destroy(base.gameObject);
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		Actor component2 = eveView2.GetComponent<Actor>();
		DGBKMAGBJJF.SetOwner(component);
		DGBKMAGBJJF.SetTarget(component2);
		get_m_actor().m_team = component.m_team;
		DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("death", true, 510f, 1137f);
	}

	private void ALJEFBEMCFK()
	{
	}

	public virtual void ABMMGINPLAD()
	{
		HKAMCNPENHB();
		HJFLMAMNNPN = new List<Actor>();
	}

	public void AGEDIMHNHCF(object[] GMJOHJJGBMK)
	{
		int kPNEBLJJGEA = (int)GMJOHJJGBMK[1];
		int kPNEBLJJGEA2 = (int)GMJOHJJGBMK[1];
		EveView eveView = EveUnityNetwork.get_Instance().HCDPDNMLNDE().NLALKBLCPFK(kPNEBLJJGEA);
		EveView eveView2 = EveUnityNetwork.get_Instance().PBLOPNNPNEJ().NODACNJHDFD(kPNEBLJJGEA2);
		if (eveView == null || eveView2 == null)
		{
			Object.Destroy(base.gameObject);
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		Actor component2 = eveView2.GetComponent<Actor>();
		DGBKMAGBJJF.SetOwner(component);
		DGBKMAGBJJF.SetTarget(component2);
		get_m_actor().m_team = component.m_team;
		DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM("Background", true, 1678f, 1578f);
	}

	public void JOOAAELMGII(object[] GMJOHJJGBMK)
	{
		int kPNEBLJJGEA = (int)GMJOHJJGBMK[0];
		int kPNEBLJJGEA2 = (int)GMJOHJJGBMK[1];
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(kPNEBLJJGEA);
		EveView eveView2 = EveUnityNetwork.get_Instance().PBLOPNNPNEJ().NODACNJHDFD(kPNEBLJJGEA2);
		if (eveView == null || eveView2 == null)
		{
			Object.Destroy(base.gameObject);
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		Actor component2 = eveView2.GetComponent<Actor>();
		DGBKMAGBJJF.SetOwner(component);
		DGBKMAGBJJF.SetTarget(component2);
		get_m_actor().m_team = component.m_team;
		DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK("구입할 아이템을 선택해 주세요.", false, 1226f, 1893f);
	}

	public void FIPKABBNMFP(int MBEKPGNGBAO)
	{
		EveView eveView = EveUnityNetwork.get_Instance().PBLOPNNPNEJ().NODACNJHDFD(MBEKPGNGBAO);
		if (eveView == null)
		{
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		if (!(component == null))
		{
			GHODNPLKJFB();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1491.0;
			num += 996.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 733.0;
			num *= (double)(715f - (float)HJFLMAMNNPN.Count * 1749f);
			if (component.OnDamage(get_m_actor(), 40.0, num, 1422.0, 0) >= 1646f)
			{
				component.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.BlitzcrankSkill1, null, 374f, 1584f);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill0_heal", true, 1863f, 1050f);
			HJFLMAMNNPN.Add(component);
		}
	}

	[JDLHECHNNDH]
	public void ChangeTargetRpc(int MBEKPGNGBAO)
	{
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(MBEKPGNGBAO);
		if (eveView == null || eveView.GetComponent<Actor>() == null)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Death);
		}
		else
		{
			DGBKMAGBJJF.SetTarget(eveView.GetComponent<Actor>());
		}
	}

	public void FBCIHOFBFBM(object[] GMJOHJJGBMK)
	{
		int kPNEBLJJGEA = (int)GMJOHJJGBMK[1];
		int kPNEBLJJGEA2 = (int)GMJOHJJGBMK[0];
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NODACNJHDFD(kPNEBLJJGEA);
		EveView eveView2 = EveUnityNetwork.get_Instance().PBLOPNNPNEJ().NODACNJHDFD(kPNEBLJJGEA2);
		if (eveView == null || eveView2 == null)
		{
			Object.Destroy(base.gameObject);
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		Actor component2 = eveView2.GetComponent<Actor>();
		DGBKMAGBJJF.SetOwner(component);
		DGBKMAGBJJF.SetTarget(component2);
		get_m_actor().m_team = component.m_team;
		DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("[url=", true, 1607f, 1810f);
	}

	[JDLHECHNNDH]
	public void AttackRpc(int MBEKPGNGBAO)
	{
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(MBEKPGNGBAO);
		if (eveView == null)
		{
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		if (!(component == null))
		{
			CCGKACBFCNJ();
			double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.45;
			num += 60.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 25.0;
			num *= (double)(1f - (float)HJFLMAMNNPN.Count * 0.1f);
			if (component.OnDamage(get_m_actor(), 0.0, num) >= 0f)
			{
				component.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.KatarinaSkill0);
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill0_missile_hit");
			HJFLMAMNNPN.Add(component);
		}
	}

	protected virtual void KJGBBILLEFH(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		m_lifeTime -= get_m_actor().BILOHJAEGCG();
		if (target != null)
		{
			AJCKOBONMEA(target.GetCenterPosition());
		}
		Vector3 hCILMCOKKPN = get_m_targetPos() - get_m_actor().GetCenterPosition();
		float sqrMagnitude = hCILMCOKKPN.sqrMagnitude;
		hCILMCOKKPN.Normalize();
		DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN);
		float num = get_m_actor().m_moveSpeed * get_m_actor().BILOHJAEGCG();
		if (sqrMagnitude <= num * num && DGBKMAGBJJF.get_m_view().IsMine())
		{
			EveView view = DGBKMAGBJJF.get_m_view();
			object[] array = new object[0];
			array[1] = DGBKMAGBJJF.get_m_target().get_m_view().get_viewID();
			view.RPC("UFO", DJJPAPENCLN.All, array);
			AttackRpc(DGBKMAGBJJF.get_m_target().get_m_view().get_viewID());
			if (HJFLMAMNNPN.Count < 5)
			{
				DGBKMAGBJJF.SetTarget(null);
				List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 193f, true, false, (Actor.IJJMDPGJAEM)39);
				foreach (Actor item in allActorInRange)
				{
					if (HJFLMAMNNPN.Contains(item))
					{
						continue;
					}
					EveView view2 = DGBKMAGBJJF.get_m_view();
					object[] array2 = new object[1];
					array2[1] = item.get_m_view().get_viewID();
					view2.RPC("skill1", DJJPAPENCLN.All, array2);
					DGBKMAGBJJF.SetTarget(item);
					break;
				}
				if (!(DGBKMAGBJJF.get_m_target() != null))
				{
					DGBKMAGBJJF.get_m_view().RPC("每級法力", DJJPAPENCLN.Others, -1);
				}
			}
			else
			{
				DGBKMAGBJJF.get_m_view().RPC("주문력", DJJPAPENCLN.Others, -1);
			}
		}
		else if (m_lifeTime <= 1286f)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.None);
		}
	}
}
