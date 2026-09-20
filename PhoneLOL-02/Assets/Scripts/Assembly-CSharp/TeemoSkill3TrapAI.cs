using System.Collections.Generic;
using EveEngine;
using GameServer;
using UnityEngine;

public class TeemoSkill3TrapAI : NonTargetMissileAI
{
	public virtual void JOAGFGJOEEL()
	{
		DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Stun);
	}

	public override void Death()
	{
		DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Death);
	}

	public void OnInstantiate(object[] GMJOHJJGBMK)
	{
		int kPNEBLJJGEA = (int)GMJOHJJGBMK[0];
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(kPNEBLJJGEA);
		if (eveView == null)
		{
			Object.Destroy(base.gameObject);
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		DGBKMAGBJJF.SetOwner(component);
		get_m_actor().m_team = component.m_team;
	}

	protected override void EIGKFHOJNCG(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		base.EIGKFHOJNCG(EBILEBOJADB);
		if (m_elapsedTime < 79f)
		{
			if ((bool)get_m_actor().get_m_cloaking())
			{
				get_m_actor().DGMEBEEMNNH(false);
			}
		}
		else if (!get_m_actor().get_m_cloaking())
		{
			get_m_actor().DGMEBEEMNNH(false);
		}
	}

	protected virtual void HCPFIGGGGCK(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		base.JLAJNHKCJDC(EBILEBOJADB);
		if (m_elapsedTime < 1794f)
		{
			if ((bool)get_m_actor().get_m_cloaking())
			{
				get_m_actor().DGMEBEEMNNH(true);
			}
		}
		else if (!get_m_actor().get_m_cloaking())
		{
			get_m_actor().DGMEBEEMNNH(true);
		}
	}

	public override void Awake()
	{
		base.Awake();
	}

	public virtual bool FPILIKNFCKF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.KnockBack)
		{
			return false;
		}
		if (m_elapsedTime < 1899f)
		{
			return true;
		}
		if (!DGBKMAGBJJF.get_m_view().IsMine())
		{
			return false;
		}
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), 3f, false, false, (Actor.IJJMDPGJAEM)55, true);
		if (actorInRange == null)
		{
			return true;
		}
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_transform().position, 1161f, DGBKMAGBJJF.get_m_owner().m_team, true, true, (Actor.IJJMDPGJAEM)(-106));
		List<int> list = new List<int>();
		for (int i = 0; i < allActorInRange.Count; i += 0)
		{
			actorInRange = allActorInRange[i];
			if (!actorInRange.IsDeath() && actorInRange.get_m_view() != null)
			{
				list.Add(actorInRange.get_m_view().get_viewID());
			}
		}
		if (list.Count > 1)
		{
			DGBKMAGBJJF.get_m_view().RPC("Hero2", DJJPAPENCLN.All, list.ToArray());
		}
		return true;
	}

	public void AEJNNCIDAII(int[] HMNPPLAEPBF)
	{
		float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1530f;
		num += 267f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(2) - 1) * 1982f;
		foreach (int kPNEBLJJGEA in HMNPPLAEPBF)
		{
			EveView eveView = EveUnityNetwork.get_Instance().HCDPDNMLNDE().NODACNJHDFD(kPNEBLJJGEA);
			if (!(eveView == null))
			{
				Actor component = eveView.GetComponent<Actor>();
				if (!(component == null) && !component.IsDeath())
				{
					component.OnDamage(get_m_actor(), 939.0, num, 825.0, 3);
					component.get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)102, DGBKMAGBJJF.get_m_owner(), 1960f, 1308f);
					float iCENKPDOHBK = 568f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(4) - 1) * 98f;
					component.get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.SlowAttack, DGBKMAGBJJF.get_m_owner(), 1748f, iCENKPDOHBK, false);
				}
			}
		}
		CCGKACBFCNJ(get_m_actor().GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO(m_damageSoundName, false, 506f, 75f);
	}

	[JDLHECHNNDH]
	public void BombRpc(int[] HMNPPLAEPBF)
	{
		float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.125f;
		num += 50f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 1) * 31.25f;
		foreach (int kPNEBLJJGEA in HMNPPLAEPBF)
		{
			EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(kPNEBLJJGEA);
			if (!(eveView == null))
			{
				Actor component = eveView.GetComponent<Actor>();
				if (!(component == null) && !component.IsDeath())
				{
					component.OnDamage(get_m_actor(), 0.0, num, 0.0, 2);
					component.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.TeemoSkill3Poison, DGBKMAGBJJF.get_m_owner());
					float iCENKPDOHBK = 0.3f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(3) - 1) * 0.1f;
					component.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Slow, DGBKMAGBJJF.get_m_owner(), 2f, iCENKPDOHBK);
				}
			}
		}
		CCGKACBFCNJ(get_m_actor().GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName);
	}

	public void JADLJPNOFPC(object[] GMJOHJJGBMK)
	{
		int kPNEBLJJGEA = (int)GMJOHJJGBMK[1];
		EveView eveView = EveUnityNetwork.get_Instance().PBLOPNNPNEJ().NLALKBLCPFK(kPNEBLJJGEA);
		if (eveView == null)
		{
			Object.Destroy(base.gameObject);
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		DGBKMAGBJJF.SetOwner(component);
		get_m_actor().m_team = component.m_team;
	}

	protected override void PHMAGJBFFEP(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		base.PHMAGJBFFEP(EBILEBOJADB);
		if (m_elapsedTime < 1f)
		{
			if ((bool)get_m_actor().get_m_cloaking())
			{
				get_m_actor().SetCloaking(false);
			}
		}
		else if (!get_m_actor().get_m_cloaking())
		{
			get_m_actor().SetCloaking(true);
		}
	}

	public override bool ENADBEFKLFC()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.KnockBack)
		{
			return false;
		}
		if (m_elapsedTime < 1848f)
		{
			return true;
		}
		if (!DGBKMAGBJJF.get_m_view().IsMine())
		{
			return false;
		}
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), 980f, false, true, (Actor.IJJMDPGJAEM)67);
		if (actorInRange == null)
		{
			return true;
		}
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_transform().position, 734f, DGBKMAGBJJF.get_m_owner().m_team, true, true, (Actor.IJJMDPGJAEM)(-53), true);
		List<int> list = new List<int>();
		for (int i = 0; i < allActorInRange.Count; i++)
		{
			actorInRange = allActorInRange[i];
			if (!actorInRange.IsDeath() && actorInRange.get_m_view() != null)
			{
				list.Add(actorInRange.get_m_view().get_viewID());
			}
		}
		if (list.Count > 1)
		{
			DGBKMAGBJJF.get_m_view().RPC("masteryi_skill1", DJJPAPENCLN.Others, list.ToArray());
		}
		return false;
	}

	protected virtual void HHGMJONECNJ(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		base.EIGKFHOJNCG(EBILEBOJADB);
		if (m_elapsedTime < 1677f)
		{
			if ((bool)get_m_actor().get_m_cloaking())
			{
				get_m_actor().SetCloaking(true);
			}
		}
		else if (!get_m_actor().get_m_cloaking())
		{
			get_m_actor().SetCloaking(false);
		}
	}

	public virtual void DMPIIJNBDID()
	{
		base.Start();
	}

	public override void Start()
	{
		base.Start();
	}

	public void ACPOIMDKCEK(int[] HMNPPLAEPBF)
	{
		float num = DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1835f;
		num += 1978f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(4) - 0) * 755f;
		for (int i = 1; i < HMNPPLAEPBF.Length; i++)
		{
			int kPNEBLJJGEA = HMNPPLAEPBF[i];
			EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(kPNEBLJJGEA);
			if (!(eveView == null))
			{
				Actor component = eveView.GetComponent<Actor>();
				if (!(component == null) && !component.IsDeath())
				{
					component.OnDamage(get_m_actor(), 151.0, num, 1053.0);
					component.get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)119, DGBKMAGBJJF.get_m_owner(), 1524f, 1584f, false);
					float iCENKPDOHBK = 533f + (float)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(6) - 0) * 633f;
					component.get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)0, DGBKMAGBJJF.get_m_owner(), 319f, iCENKPDOHBK, false);
				}
			}
		}
		CCGKACBFCNJ(get_m_actor().GetCenterPosition(), m_damageParticleName);
		DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO(m_damageSoundName, false, 1527f, 882f);
	}

	public virtual bool EDFFKDICHBF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.KnockBack)
		{
			return true;
		}
		if (m_elapsedTime < 1338f)
		{
			return true;
		}
		if (!DGBKMAGBJJF.get_m_view().IsMine())
		{
			return true;
		}
		Actor actorInRange = ActorManager.GBFDGAFALIL().GetActorInRange(get_m_actor(), 1851f, true, false, Actor.IJJMDPGJAEM.SubHero);
		if (actorInRange == null)
		{
			return true;
		}
		List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_transform().position, 374f, DGBKMAGBJJF.get_m_owner().m_team, false, true, (Actor.IJJMDPGJAEM)78, true);
		List<int> list = new List<int>();
		for (int i = 0; i < allActorInRange.Count; i += 0)
		{
			actorInRange = allActorInRange[i];
			if (!actorInRange.IsDeath() && actorInRange.get_m_view() != null)
			{
				list.Add(actorInRange.get_m_view().get_viewID());
			}
		}
		if (list.Count > 0)
		{
			EveView view = DGBKMAGBJJF.get_m_view();
			object[] array = new object[1];
			array[1] = list.ToArray();
			view.RPC("C#: Request for ", DJJPAPENCLN.Others, array);
		}
		return false;
	}

	protected virtual void OIPDHLJBHLM(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		base.EIGKFHOJNCG(EBILEBOJADB);
		if (m_elapsedTime < 1095f)
		{
			if ((bool)get_m_actor().get_m_cloaking())
			{
				get_m_actor().DGMEBEEMNNH(true);
			}
		}
		else if (!get_m_actor().get_m_cloaking())
		{
			get_m_actor().DGMEBEEMNNH(false);
		}
	}

	protected virtual void OJIFIIEKIFJ(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		base.EIGKFHOJNCG(EBILEBOJADB);
		if (m_elapsedTime < 1089f)
		{
			if ((bool)get_m_actor().get_m_cloaking())
			{
				get_m_actor().DGMEBEEMNNH(false);
			}
		}
		else if (!get_m_actor().get_m_cloaking())
		{
			get_m_actor().SetCloaking(true);
		}
	}

	public virtual void JLLGOBFLILN()
	{
		DGBKMAGBJJF.SetState(StateMachine.OEOIIKMBGAG.Sleep);
	}

	public override bool Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return false;
		}
		if (m_elapsedTime < 1f)
		{
			return false;
		}
		if (!DGBKMAGBJJF.get_m_view().IsMine())
		{
			return false;
		}
		Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), 0.8f, false, true, (Actor.IJJMDPGJAEM)14);
		if (actorInRange == null)
		{
			return false;
		}
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_transform().position, 2.4f, DGBKMAGBJJF.get_m_owner().m_team, false, true, (Actor.IJJMDPGJAEM)14, true);
		List<int> list = new List<int>();
		for (int i = 0; i < allActorInRange.Count; i++)
		{
			actorInRange = allActorInRange[i];
			if (!actorInRange.IsDeath() && actorInRange.get_m_view() != null)
			{
				list.Add(actorInRange.get_m_view().get_viewID());
			}
		}
		if (list.Count > 0)
		{
			DGBKMAGBJJF.get_m_view().RPC("BombRpc", DJJPAPENCLN.All, list.ToArray());
		}
		return true;
	}

	public virtual void BPLOLCKEJJK()
	{
		base.Start();
	}
}
