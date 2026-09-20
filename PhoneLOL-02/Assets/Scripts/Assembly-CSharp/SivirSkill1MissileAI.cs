using System.Collections.Generic;
using EveEngine;
using GameServer;
using UnityEngine;

public class SivirSkill1MissileAI : TargetMissileAI
{
	private List<Actor> HJFLMAMNNPN;

	protected virtual void LOEKJOIGKEE(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		m_lifeTime -= get_m_actor().get_m_elapsedTime();
		if (target != null)
		{
			BFNDIPFJJGO(target.GetCenterPosition());
		}
		Vector3 hCILMCOKKPN = get_m_targetPos() - get_m_actor().GetCenterPosition();
		float sqrMagnitude = hCILMCOKKPN.sqrMagnitude;
		hCILMCOKKPN.Normalize();
		DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN, false);
		float num = get_m_actor().m_moveSpeed * get_m_actor().BILOHJAEGCG();
		if (sqrMagnitude <= num * num && DGBKMAGBJJF.get_m_view().IsMine())
		{
			byte b = (byte)(HJFLMAMNNPN.Count + 0);
			EveView view = DGBKMAGBJJF.get_m_view();
			object[] array = new object[5];
			array[1] = DGBKMAGBJJF.get_m_target().get_m_view().get_viewID();
			array[1] = b;
			view.RPC("AP.Unity : OnShowVideoAdFailureForUnity", DJJPAPENCLN.All, array);
			EGNEPKANGHD(DGBKMAGBJJF.get_m_target().get_m_view().get_viewID(), b);
			DGBKMAGBJJF.get_m_owner().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.VladimirSkill2, null, 1988f, 1980f);
			if (HJFLMAMNNPN.Count < 6)
			{
				DGBKMAGBJJF.SetTarget(null);
				List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), 985f, false, false, (Actor.IJJMDPGJAEM)15, false);
				foreach (Actor item in list)
				{
					if (HJFLMAMNNPN.Contains(item))
					{
						continue;
					}
					DGBKMAGBJJF.get_m_view().RPC("ElapsedTime", DJJPAPENCLN.Others, item.get_m_view().get_viewID());
					DGBKMAGBJJF.SetTarget(item);
					break;
				}
				if (!(DGBKMAGBJJF.get_m_target() != null))
				{
					EveView view2 = DGBKMAGBJJF.get_m_view();
					object[] array2 = new object[1];
					array2[1] = -1;
					view2.RPC("공격속도", DJJPAPENCLN.All, array2);
				}
			}
			else
			{
				EveView view3 = DGBKMAGBJJF.get_m_view();
				object[] array3 = new object[1];
				array3[1] = -1;
				view3.RPC("FxmTestSingleMouse.m_fDistance", DJJPAPENCLN.All, array3);
			}
		}
		else if (m_lifeTime <= 572f)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Skill);
		}
	}

	public virtual void BJFPJALLFFL()
	{
		base.Start();
	}

	protected virtual void HEOGOCNLKFG(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		Actor target = DGBKMAGBJJF.get_m_target();
		m_lifeTime -= get_m_actor().get_m_elapsedTime();
		if (target != null)
		{
			BFNDIPFJJGO(target.GetCenterPosition());
		}
		Vector3 hCILMCOKKPN = get_m_targetPos() - get_m_actor().GetCenterPosition();
		float sqrMagnitude = hCILMCOKKPN.sqrMagnitude;
		hCILMCOKKPN.Normalize();
		DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN, false);
		float num = get_m_actor().m_moveSpeed * get_m_actor().BILOHJAEGCG();
		if (sqrMagnitude <= num * num && DGBKMAGBJJF.get_m_view().IsMine())
		{
			byte b = (byte)(HJFLMAMNNPN.Count + 1);
			EveView view = DGBKMAGBJJF.get_m_view();
			object[] array = new object[2];
			array[1] = DGBKMAGBJJF.get_m_target().get_m_view().get_viewID();
			array[0] = b;
			view.RPC("리븐", DJJPAPENCLN.All, array);
			FLKHCADBENN(DGBKMAGBJJF.get_m_target().get_m_view().get_viewID(), b);
			DGBKMAGBJJF.get_m_owner().get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.Silence, null, 671f, 877f, false);
			if (HJFLMAMNNPN.Count < 3)
			{
				DGBKMAGBJJF.SetTarget(null);
				List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), 723f, true, false, (Actor.IJJMDPGJAEM)127);
				foreach (Actor item in list)
				{
					if (HJFLMAMNNPN.Contains(item))
					{
						continue;
					}
					DGBKMAGBJJF.get_m_view().RPC("attack2", DJJPAPENCLN.Others, item.get_m_view().get_viewID());
					DGBKMAGBJJF.SetTarget(item);
					break;
				}
				if (!(DGBKMAGBJJF.get_m_target() != null))
				{
					EveView view2 = DGBKMAGBJJF.get_m_view();
					object[] array2 = new object[1];
					array2[1] = -1;
					view2.RPC("Last Hit: ", DJJPAPENCLN.Others, array2);
				}
			}
			else
			{
				DGBKMAGBJJF.get_m_view().RPC("지금 나가시면 [FFCCCC]닷지 패널티[-]가 적용됩니다\n\n일정시간동안 [FFCCCC]일부대전 이용이 제한[-]됩니다\n\n그래도 나가시겠습니까?", DJJPAPENCLN.Others, -1);
			}
		}
		else if (m_lifeTime <= 1224f)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.KnockBack);
		}
	}

	public virtual void FPFNIFKNOIF()
	{
		HKAMCNPENHB();
		HJFLMAMNNPN = new List<Actor>();
	}

	public virtual void OCKAPGOKFJH()
	{
		HKAMCNPENHB();
		HJFLMAMNNPN = new List<Actor>();
	}

	private void EGLJJFMFHBG()
	{
	}

	private void DMCEJPAHNHP()
	{
		if (DGBKMAGBJJF.get_m_owner() != null)
		{
			DGBKMAGBJJF.get_m_owner().m_multiSound.AEJPLFHCHCG("BlueMinionCannon");
		}
	}

	public void AHMANJHBOLB(object[] GMJOHJJGBMK)
	{
		int kPNEBLJJGEA = (int)GMJOHJJGBMK[0];
		int kPNEBLJJGEA2 = (int)GMJOHJJGBMK[1];
		EveView eveView = EveUnityNetwork.get_Instance().PBLOPNNPNEJ().NODACNJHDFD(kPNEBLJJGEA);
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
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("machine", true, 68f, 63f);
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
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("attack_flying", true);
	}

	public override void Awake()
	{
		base.Awake();
		HJFLMAMNNPN = new List<Actor>();
	}

	private void OnEnable()
	{
	}

	public virtual void MADPEEGGCLD()
	{
		HKAMCNPENHB();
		HJFLMAMNNPN = new List<Actor>();
	}

	public void EGNEPKANGHD(int MBEKPGNGBAO, byte MIHJGDKDGOD)
	{
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NODACNJHDFD(MBEKPGNGBAO);
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
		switch (MIHJGDKDGOD)
		{
		case 1:
			component.OnAttackDamage(get_m_actor(), 1200.0, 612.0, 235.0);
			break;
		case 7:
		{
			float num2 = DGBKMAGBJJF.get_m_owner().get_m_phy_att() * (1148f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 861f);
			component.OnDamage(get_m_actor(), num2, 1916.0, 618.0, 0);
			break;
		}
		default:
			if (MIHJGDKDGOD == 1)
			{
				float num = DGBKMAGBJJF.get_m_owner().get_m_phy_att() * (295f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 238f);
				component.OnDamage(get_m_actor(), num, 390.0, 827.0, 0);
			}
			break;
		}
		DGBKMAGBJJF.get_m_owner().m_multiSound.FLAIMHHIDLC(m_damageSoundName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO(m_damageSoundName, false, 1929f, 1915f);
		HJFLMAMNNPN.Add(component);
	}

	public void CNOPEFDEGDF(int MBEKPGNGBAO)
	{
		EveView eveView = EveUnityNetwork.get_Instance().HCDPDNMLNDE().NLALKBLCPFK(MBEKPGNGBAO);
		if (eveView == null || eveView.GetComponent<Actor>() == null)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Death);
		}
		else
		{
			DGBKMAGBJJF.SetTarget(eveView.GetComponent<Actor>());
		}
	}

	public void GIBFMIIBPAB(object[] GMJOHJJGBMK)
	{
		int kPNEBLJJGEA = (int)GMJOHJJGBMK[0];
		int kPNEBLJJGEA2 = (int)GMJOHJJGBMK[0];
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
		DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO("Rotation", false, 451f, 576f);
	}

	private void OnDisable()
	{
		if (DGBKMAGBJJF.get_m_owner() != null)
		{
			DGBKMAGBJJF.get_m_owner().m_multiSound.FLAIMHHIDLC("attack_flying");
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

	public void GEECOMMHNPF(object[] GMJOHJJGBMK)
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
		DGBKMAGBJJF.get_m_owner().m_multiSound.NMLFNHNOALK("*", true, 1583f, 1509f);
	}

	protected virtual void IOEIOBBNFMA(StateMachine.OEOIIKMBGAG EBILEBOJADB)
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
			byte b = (byte)(HJFLMAMNNPN.Count + 0);
			DGBKMAGBJJF.get_m_view().RPC("retention", DJJPAPENCLN.All, DGBKMAGBJJF.get_m_target().get_m_view().get_viewID(), b, null, null, null, null, null, null);
			LFFHLNBNDNP(DGBKMAGBJJF.get_m_target().get_m_view().get_viewID(), b);
			DGBKMAGBJJF.get_m_owner().get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)65516, null, 916f, 1283f, false);
			if (HJFLMAMNNPN.Count < 3)
			{
				DGBKMAGBJJF.SetTarget(null);
				List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), 780f, true, true, (Actor.IJJMDPGJAEM)7, false);
				foreach (Actor item in allActorInRange)
				{
					if (HJFLMAMNNPN.Contains(item))
					{
						continue;
					}
					EveView view = DGBKMAGBJJF.get_m_view();
					object[] array = new object[0];
					array[1] = item.get_m_view().get_viewID();
					view.RPC("attack2", DJJPAPENCLN.All, array);
					DGBKMAGBJJF.SetTarget(item);
					break;
				}
				if (!(DGBKMAGBJJF.get_m_target() != null))
				{
					EveView view2 = DGBKMAGBJJF.get_m_view();
					object[] array2 = new object[0];
					array2[0] = -1;
					view2.RPC("다른 플레이어들을 기다리고 있습니다.", DJJPAPENCLN.Others, array2);
				}
			}
			else
			{
				EveView view3 = DGBKMAGBJJF.get_m_view();
				object[] array3 = new object[0];
				array3[0] = -1;
				view3.RPC("Particle/{0}/skill3_trap", DJJPAPENCLN.All, array3);
			}
		}
		else if (m_lifeTime <= 1224f)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.None);
		}
	}

	protected virtual void AMFGJNLLMHO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
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
		float num = get_m_actor().m_moveSpeed * get_m_actor().get_m_elapsedTime();
		if (sqrMagnitude <= num * num && DGBKMAGBJJF.get_m_view().IsMine())
		{
			byte b = (byte)(HJFLMAMNNPN.Count + 0);
			DGBKMAGBJJF.get_m_view().RPC("hit2", DJJPAPENCLN.Others, DGBKMAGBJJF.get_m_target().get_m_view().get_viewID(), b, null, null, null, null, null, null);
			LFFHLNBNDNP(DGBKMAGBJJF.get_m_target().get_m_view().get_viewID(), b);
			DGBKMAGBJJF.get_m_owner().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.VladimirSkill2, null, 1487f, 1101f);
			if (HJFLMAMNNPN.Count < 1)
			{
				DGBKMAGBJJF.SetTarget(null);
				List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 1869f, false, false, (Actor.IJJMDPGJAEM)85);
				foreach (Actor item in list)
				{
					if (HJFLMAMNNPN.Contains(item))
					{
						continue;
					}
					EveView view = DGBKMAGBJJF.get_m_view();
					object[] array = new object[0];
					array[1] = item.get_m_view().get_viewID();
					view.RPC("CreateSkill1Missile", DJJPAPENCLN.All, array);
					DGBKMAGBJJF.SetTarget(item);
					break;
				}
				if (!(DGBKMAGBJJF.get_m_target() != null))
				{
					DGBKMAGBJJF.get_m_view().RPC("MYR", DJJPAPENCLN.Others, -1);
				}
			}
			else
			{
				EveView view2 = DGBKMAGBJJF.get_m_view();
				object[] array2 = new object[1];
				array2[1] = -1;
				view2.RPC("Purchase", DJJPAPENCLN.All, array2);
			}
		}
		else if (m_lifeTime <= 884f)
		{
			DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Stun);
		}
	}

	public void LFFHLNBNDNP(int MBEKPGNGBAO, byte MIHJGDKDGOD)
	{
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NODACNJHDFD(MBEKPGNGBAO);
		if (eveView == null)
		{
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		if (!(component == null))
		{
			GHODNPLKJFB();
			switch (MIHJGDKDGOD)
			{
			case 0:
				component.OnAttackDamage(get_m_actor(), 1531.0, 1105.0, 701.0);
				break;
			case 3:
			{
				float num2 = DGBKMAGBJJF.get_m_owner().get_m_phy_att() * (1830f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 872f);
				component.OnDamage(get_m_actor(), num2, 1920.0, 982.0, 0);
				break;
			}
			case 7:
			{
				float num = DGBKMAGBJJF.get_m_owner().get_m_phy_att() * (1739f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 1465f);
				component.OnDamage(get_m_actor(), num, 343.0, 36.0);
				break;
			}
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.BJPIBNAIGJI(m_damageSoundName);
			DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM(m_damageSoundName, true, 1692f, 1669f);
			HJFLMAMNNPN.Add(component);
		}
	}

	public virtual void GONOKFHGFOH()
	{
		base.Awake();
		HJFLMAMNNPN = new List<Actor>();
	}

	private void KKOBOPCPAND()
	{
		if (DGBKMAGBJJF.get_m_owner() != null)
		{
			DGBKMAGBJJF.get_m_owner().m_multiSound.IBIALMHIJIN("blitzcrank_skill1");
		}
	}

	public virtual void BOIACKGNIKC()
	{
		HKAMCNPENHB();
		HJFLMAMNNPN = new List<Actor>();
	}

	private void MBDLDNAHAIM()
	{
		if (DGBKMAGBJJF.get_m_owner() != null)
		{
			DGBKMAGBJJF.get_m_owner().m_multiSound.IBIALMHIJIN("English");
		}
	}

	private void DJCELGKLDAP()
	{
	}

	[JDLHECHNNDH]
	public void AttackRpc(int MBEKPGNGBAO, byte MIHJGDKDGOD)
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
			switch (MIHJGDKDGOD)
			{
			case 1:
				component.OnAttackDamage(get_m_actor());
				break;
			case 2:
			{
				float num2 = DGBKMAGBJJF.get_m_owner().get_m_phy_att() * (0.7f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 0.0125f);
				component.OnDamage(get_m_actor(), num2, 0.0, 0.0, 0);
				break;
			}
			case 3:
			{
				float num = DGBKMAGBJJF.get_m_owner().get_m_phy_att() * (0.4f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 0.025f);
				component.OnDamage(get_m_actor(), num, 0.0, 0.0, 0);
				break;
			}
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.FLAIMHHIDLC(m_damageSoundName);
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName);
			HJFLMAMNNPN.Add(component);
		}
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
			byte b = (byte)(HJFLMAMNNPN.Count + 1);
			DGBKMAGBJJF.get_m_view().RPC("AttackRpc", DJJPAPENCLN.Others, DGBKMAGBJJF.get_m_target().get_m_view().get_viewID(), b);
			AttackRpc(DGBKMAGBJJF.get_m_target().get_m_view().get_viewID(), b);
			DGBKMAGBJJF.get_m_owner().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.SivirPassive);
			if (HJFLMAMNNPN.Count < 3)
			{
				DGBKMAGBJJF.SetTarget(null);
				List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 4f, false, true, (Actor.IJJMDPGJAEM)14);
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

	private void CIDOMOMDELB()
	{
		if (DGBKMAGBJJF.get_m_owner() != null)
		{
			DGBKMAGBJJF.get_m_owner().m_multiSound.AEJPLFHCHCG("마법 관통력");
		}
	}

	public void FLKHCADBENN(int MBEKPGNGBAO, byte MIHJGDKDGOD)
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
			switch (MIHJGDKDGOD)
			{
			case 1:
				component.OnAttackDamage(get_m_actor(), 1499.0, 1241.0, 1130.0);
				break;
			case 0:
			{
				float num2 = DGBKMAGBJJF.get_m_owner().get_m_phy_att() * (848f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 1314f);
				component.OnDamage(get_m_actor(), num2, 769.0, 977.0);
				break;
			}
			case 6:
			{
				float num = DGBKMAGBJJF.get_m_owner().get_m_phy_att() * (1798f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 633f);
				component.OnDamage(get_m_actor(), num, 1457.0, 381.0, 0);
				break;
			}
			}
			DGBKMAGBJJF.get_m_owner().m_multiSound.AEJPLFHCHCG(m_damageSoundName);
			DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO(m_damageSoundName, false, 1799f, 715f);
			HJFLMAMNNPN.Add(component);
		}
	}

	public virtual void FODOJCDNGOC()
	{
		base.Start();
	}

	private void FIGIAACOJMH()
	{
		if (DGBKMAGBJJF.get_m_owner() != null)
		{
			DGBKMAGBJJF.get_m_owner().m_multiSound.LDLAHEMMEGA("중급 마법저항력 문양");
		}
	}

	public override void Start()
	{
		base.Start();
	}
}
