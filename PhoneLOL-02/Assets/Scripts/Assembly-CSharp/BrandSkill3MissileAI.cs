using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using EveEngine;
using GameServer;
using UnityEngine;

public class BrandSkill3MissileAI : TargetMissileAI
{
	private ObscuredInt BACNLPBCPNI;

	public override void Start()
	{
		base.Start();
	}

	public void AIJKBLFKKNF(int MBEKPGNGBAO)
	{
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(MBEKPGNGBAO);
		if (eveView == null)
		{
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		if (component == null)
		{
			return;
		}
		CBKGHLBACMK();
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 347.0;
		num += 977.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(2) - 0) * 379.0;
		if (component.OnDamage(get_m_actor(), 1014.0, num, 1827.0, 0) >= 1820f)
		{
			if (component.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.MagShield))
			{
				float iCENKPDOHBK = 440f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(8) - 0) * 1934f;
				component.get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.Slow, DGBKMAGBJJF.get_m_owner(), 1691f, iCENKPDOHBK, false);
			}
			if (!component.get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65485))
			{
				component.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.VayneStelth, DGBKMAGBJJF.get_m_owner(), 1414f, 1401f, false);
			}
		}
		DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("MultiLayer", true, 529f, 1515f);
		++BACNLPBCPNI;
	}

	public override void Awake()
	{
		base.Awake();
	}

	private void LOCDDHONDIG()
	{
	}

	private void GNOAPFAKBIN()
	{
	}

	private void GPFPLFJCNOL()
	{
		get_m_actor().m_multiSound.MNKCLFBCGGA("getClientPendingRewardItems");
	}

	public void NEHHGJINJMN(object[] GMJOHJJGBMK)
	{
		int kPNEBLJJGEA = (int)GMJOHJJGBMK[1];
		int kPNEBLJJGEA2 = (int)GMJOHJJGBMK[1];
		EveView eveView = EveUnityNetwork.get_Instance().PBLOPNNPNEJ().NODACNJHDFD(kPNEBLJJGEA);
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
		get_m_actor().m_multiSound.ICNAJBHLIGO("Challenge/{0}", false, 1158f, 126f);
	}

	public void CHMAKFCOICO(int MBEKPGNGBAO)
	{
		EveView eveView = EveUnityNetwork.get_Instance().PBLOPNNPNEJ().NLALKBLCPFK(MBEKPGNGBAO);
		if (eveView == null)
		{
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		if (component == null)
		{
			return;
		}
		GHODNPLKJFB();
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1384.0;
		num += 1998.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(5) - 0) * 1855.0;
		if (component.OnDamage(get_m_actor(), 1062.0, num, 379.0, 0) >= 616f)
		{
			if (component.get_m_buffsInfo().KNINEDPJMJE(JGOOOBHDBCG.ACPICCBBPHF.TalonSkill3))
			{
				float iCENKPDOHBK = 1848f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(6) - 1) * 1889f;
				component.get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.Stun, DGBKMAGBJJF.get_m_owner(), 1705f, iCENKPDOHBK);
			}
			if (!component.get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65431))
			{
				component.get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.SivirPassive, DGBKMAGBJJF.get_m_owner(), 1275f, 983f, false);
			}
		}
		DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO("timestamp", true, 1185f, 549f);
		++BACNLPBCPNI;
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
		get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_missile_loop", true);
	}

	public virtual void GONLJAHAEBB()
	{
		HKAMCNPENHB();
	}

	protected override void FGGNEFIBOGK(StateMachine.OEOIIKMBGAG EBILEBOJADB)
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
		DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN, false);
		float num = get_m_actor().m_moveSpeed * get_m_actor().get_m_elapsedTime();
		if (sqrMagnitude <= num * num && DGBKMAGBJJF.get_m_view().IsMine())
		{
			EveView view = DGBKMAGBJJF.get_m_view();
			object[] array = new object[0];
			array[1] = DGBKMAGBJJF.get_m_target().get_m_view().get_viewID();
			view.RPC(".", DJJPAPENCLN.Others, array);
			CHMAKFCOICO(DGBKMAGBJJF.get_m_target().get_m_view().get_viewID());
			if ((int)BACNLPBCPNI < 5)
			{
				Actor target2 = DGBKMAGBJJF.get_m_target();
				DGBKMAGBJJF.SetTarget(null);
				target = null;
				List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 1192f, false, true, (Actor.IJJMDPGJAEM)6);
				foreach (Actor item in list)
				{
					if (!(item == target2))
					{
						target = item;
					}
				}
				if (target == null)
				{
					list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 1900f, true, false, (Actor.IJJMDPGJAEM)98);
					foreach (Actor item2 in list)
					{
						if (!(item2 == target2))
						{
							target = item2;
						}
					}
				}
				if (target != null)
				{
					EveView view2 = DGBKMAGBJJF.get_m_view();
					object[] array2 = new object[0];
					array2[0] = target.get_m_view().get_viewID();
					view2.RPC("Unable to convert ", DJJPAPENCLN.All, array2);
					DGBKMAGBJJF.SetTarget(target);
				}
				else
				{
					EveView view3 = DGBKMAGBJJF.get_m_view();
					object[] array3 = new object[1];
					array3[1] = -1;
					view3.RPC("skill2", DJJPAPENCLN.All, array3);
				}
			}
			else
			{
				EveView view4 = DGBKMAGBJJF.get_m_view();
				object[] array4 = new object[0];
				array4[0] = -1;
				view4.RPC("platinum", DJJPAPENCLN.All, array4);
			}
		}
		else if (m_lifeTime <= 1719f)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Attack);
		}
	}

	public virtual void IJCPEFOBKHO()
	{
		base.Start();
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

	public virtual void PAJOOFIAPMI()
	{
		base.Start();
	}

	public void NGPKIIBLDKB(int MBEKPGNGBAO)
	{
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NODACNJHDFD(MBEKPGNGBAO);
		if (eveView == null || eveView.GetComponent<Actor>() == null)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Stun);
		}
		else
		{
			DGBKMAGBJJF.SetTarget(eveView.GetComponent<Actor>());
		}
	}

	public virtual void IFAJINMCMLM()
	{
		HKAMCNPENHB();
	}

	public void MCLKKNLEKFH(object[] GMJOHJJGBMK)
	{
		int kPNEBLJJGEA = (int)GMJOHJJGBMK[1];
		int kPNEBLJJGEA2 = (int)GMJOHJJGBMK[0];
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NODACNJHDFD(kPNEBLJJGEA);
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
		get_m_actor().m_multiSound.ICNAJBHLIGO("레벨{0} 이상만 가능합니다", false, 491f, 757f);
	}

	public void GDKLCKPFOHG(object[] GMJOHJJGBMK)
	{
		int kPNEBLJJGEA = (int)GMJOHJJGBMK[0];
		int kPNEBLJJGEA2 = (int)GMJOHJJGBMK[0];
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(kPNEBLJJGEA);
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
		get_m_actor().m_multiSound.LNCPFILABHM("FxmTestControls.m_nPlayIndex", true, 593f, 1303f);
	}

	private void OnDisable()
	{
		get_m_actor().m_multiSound.FLAIMHHIDLC("skill3_missile_loop");
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
			if ((int)BACNLPBCPNI < 5)
			{
				Actor target2 = DGBKMAGBJJF.get_m_target();
				DGBKMAGBJJF.SetTarget(null);
				target = null;
				List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 4f, false, true, Actor.IJJMDPGJAEM.Hero);
				foreach (Actor item in allActorInRange)
				{
					if (!(item == target2))
					{
						target = item;
					}
				}
				if (target == null)
				{
					allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 4f, false, true, (Actor.IJJMDPGJAEM)12);
					foreach (Actor item2 in allActorInRange)
					{
						if (!(item2 == target2))
						{
							target = item2;
						}
					}
				}
				if (target != null)
				{
					DGBKMAGBJJF.get_m_view().RPC("ChangeTargetRpc", DJJPAPENCLN.All, target.get_m_view().get_viewID());
					DGBKMAGBJJF.SetTarget(target);
				}
				else
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

	public void LLBHPLIANEP(int MBEKPGNGBAO)
	{
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NODACNJHDFD(MBEKPGNGBAO);
		if (eveView == null || eveView.GetComponent<Actor>() == null)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Stun);
		}
		else
		{
			DGBKMAGBJJF.SetTarget(eveView.GetComponent<Actor>());
		}
	}

	protected virtual void LIAPINKILPF(StateMachine.OEOIIKMBGAG EBILEBOJADB)
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
		DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN);
		float num = get_m_actor().m_moveSpeed * get_m_actor().BILOHJAEGCG();
		if (sqrMagnitude <= num * num && DGBKMAGBJJF.get_m_view().IsMine())
		{
			EveView view = DGBKMAGBJJF.get_m_view();
			object[] array = new object[0];
			array[1] = DGBKMAGBJJF.get_m_target().get_m_view().get_viewID();
			view.RPC("와~ 생각 했던 것보다 마계가 많이 다르군..\n난 시체가 막 쌓여 있고 더럽고 냄새 날 줄 알았거든..", DJJPAPENCLN.All, array);
			AttackRpc(DGBKMAGBJJF.get_m_target().get_m_view().get_viewID());
			if ((int)BACNLPBCPNI < 2)
			{
				Actor target2 = DGBKMAGBJJF.get_m_target();
				DGBKMAGBJJF.SetTarget(null);
				target = null;
				List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 537f, true, true, Actor.IJJMDPGJAEM.Monster, false);
				foreach (Actor item in allActorInRange)
				{
					if (!(item == target2))
					{
						target = item;
					}
				}
				if (target == null)
				{
					allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 964f, false, false, (Actor.IJJMDPGJAEM)(-96), false);
					foreach (Actor item2 in allActorInRange)
					{
						if (!(item2 == target2))
						{
							target = item2;
						}
					}
				}
				if (target != null)
				{
					EveView view2 = DGBKMAGBJJF.get_m_view();
					object[] array2 = new object[0];
					array2[1] = target.get_m_view().get_viewID();
					view2.RPC("모렐로노미콘", DJJPAPENCLN.Others, array2);
					DGBKMAGBJJF.SetTarget(target);
				}
				else
				{
					EveView view3 = DGBKMAGBJJF.get_m_view();
					object[] array3 = new object[1];
					array3[1] = -1;
					view3.RPC("Facebook", DJJPAPENCLN.Others, array3);
				}
			}
			else
			{
				DGBKMAGBJJF.get_m_view().RPC("해킹이 감지되었습니다 [OC2]\n불법프로그램은 사용하지 말아주세요.\n불법프로그램 사용자는 영구블럭될 수 있습니다\n\n게임을 종료합니다.", DJJPAPENCLN.All, -1);
			}
		}
		else if (m_lifeTime <= 693f)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Attack);
		}
	}

	public virtual void NHNJLOOEKCO()
	{
		base.Start();
	}

	public virtual void CMMIADLEBFJ()
	{
		base.Start();
	}

	public void AGEDIMHNHCF(object[] GMJOHJJGBMK)
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
		get_m_actor().m_multiSound.ICNAJBHLIGO("hero_icon_frame_0", true, 1459f, 775f);
	}

	public virtual void MKCBHHEACDE()
	{
		base.Awake();
	}

	private void OnEnable()
	{
	}

	protected virtual void HMIBFMFBOOO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		m_lifeTime -= get_m_actor().BILOHJAEGCG();
		if (target != null)
		{
			BFNDIPFJJGO(target.GetCenterPosition());
		}
		Vector3 hCILMCOKKPN = get_m_targetPos() - get_m_actor().GetCenterPosition();
		float sqrMagnitude = hCILMCOKKPN.sqrMagnitude;
		hCILMCOKKPN.Normalize();
		DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN);
		float num = get_m_actor().m_moveSpeed * get_m_actor().BILOHJAEGCG();
		if (sqrMagnitude <= num * num && DGBKMAGBJJF.get_m_view().IsMine())
		{
			DGBKMAGBJJF.get_m_view().RPC("com.igaworks.unity.plugin.IgawLiveOpsPopupEventManager", DJJPAPENCLN.Others, DGBKMAGBJJF.get_m_target().get_m_view().get_viewID());
			CHMAKFCOICO(DGBKMAGBJJF.get_m_target().get_m_view().get_viewID());
			if ((int)BACNLPBCPNI < 0)
			{
				Actor target2 = DGBKMAGBJJF.get_m_target();
				DGBKMAGBJJF.SetTarget(null);
				target = null;
				List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), 371f, true, true, Actor.IJJMDPGJAEM.NotUsed, false);
				foreach (Actor item in allActorInRange)
				{
					if (!(item == target2))
					{
						target = item;
					}
				}
				if (target == null)
				{
					allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), 611f, false, false, (Actor.IJJMDPGJAEM)111, false);
					foreach (Actor item2 in allActorInRange)
					{
						if (!(item2 == target2))
						{
							target = item2;
						}
					}
				}
				if (target != null)
				{
					DGBKMAGBJJF.get_m_view().RPC("com.igaworks.unity.plugin.IgawLiveOpsPopupUnityEventListener", DJJPAPENCLN.All, target.get_m_view().get_viewID());
					DGBKMAGBJJF.SetTarget(target);
				}
				else
				{
					EveView view = DGBKMAGBJJF.get_m_view();
					object[] array = new object[0];
					array[0] = -1;
					view.RPC("small_frame2", DJJPAPENCLN.Others, array);
				}
			}
			else
			{
				EveView view2 = DGBKMAGBJJF.get_m_view();
				object[] array2 = new object[1];
				array2[1] = -1;
				view2.RPC("Particle/Darius/hit", DJJPAPENCLN.All, array2);
			}
		}
		else if (m_lifeTime <= 478f)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Attack);
		}
	}

	private void JDIDGAOOBHF()
	{
		get_m_actor().m_multiSound.LDLAHEMMEGA("renekton_skill2");
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
		if (component == null)
		{
			return;
		}
		CCGKACBFCNJ();
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.25;
		num += 100.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 1) * 100.0;
		if (component.OnDamage(get_m_actor(), 0.0, num) >= 0f)
		{
			if (component.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.BrandPassiveFire))
			{
				float iCENKPDOHBK = 0.3f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 1) * 0.15f;
				component.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Slow, DGBKMAGBJJF.get_m_owner(), 1f, iCENKPDOHBK);
			}
			if (!component.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.BrandDontPassive))
			{
				component.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.BrandPassiveFire, DGBKMAGBJJF.get_m_owner());
			}
		}
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill3_hit");
		++BACNLPBCPNI;
	}

	public virtual void ANAGGLOJIKB()
	{
		base.Start();
	}
}
