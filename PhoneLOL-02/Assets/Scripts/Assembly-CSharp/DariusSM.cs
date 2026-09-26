using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using EveEngine;
using GameServer;
using UnityEngine;

public class DariusSM : HumanSM
{
	private ObscuredInt GOGLNMODMLA;

	private Actor CMJHDMKGJBG;

	public GameObject m_bodyParticle;

	public GameObject[] m_skill1HandParticles;

	[JDLHECHNNDH]
	public void Skill2Rpc(int[] HMNPPLAEPBF, Vector3 HEPNHCEIFMO)
	{
		foreach (int kPNEBLJJGEA in HMNPPLAEPBF)
		{
			EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(kPNEBLJJGEA);
			if (eveView == null)
			{
				continue;
			}
			Actor component = eveView.GetComponent<Actor>();
			if (!(component == null) && !component.IsDeath())
			{
				Vector3 iJMNFOGNFAC = HEPNHCEIFMO - component.GetPosition();
				float num = iJMNFOGNFAC.magnitude - 0.5f;
				if (num < 0f)
				{
					num = 0f;
				}
				iJMNFOGNFAC.Normalize();
				component.GetHumanSM().KnockBack(iJMNFOGNFAC, num * 0.6f, num * 6f, false, true);
				component.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.Slow, get_m_actor(), 1.5f, 0.4f);
				component.CreateParticle("Particle/Darius/skill2_hit", component.GetCenterPosition(), Quaternion.identity);
			}
		}
		get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_hit");
	}

	public virtual void DMCNKDOMKOA()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("Purchase (GooglePlayStore)", true, 1379f, 1430f);
			break;
		case 1:
			break;
		case 2:
			get_m_actor().m_multiSound.NMLFNHNOALK("Hero2", true, 1604f, 393f);
			if (Random.Range(646f, 387f) < 921f)
			{
				get_m_actor().m_multiSound.JKOODMAKJHJ("idle", false, 1544f, 1670f);
			}
			break;
		case 3:
			get_m_actor().m_multiSound.DDONMGBLLJB("하급", true, 1471f, 1715f);
			break;
		}
	}

	public virtual void NJEJPKHHGMH()
	{
		base.OnLeaveIdle();
	}

	public virtual void IIKMCJBAMII()
	{
		GOGLNMODMLA = Random.Range(0, 3);
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.SlowAttack))
		{
			get_m_actor().get_m_buffsInfo().KHFDBEEGPIL((JGOOOBHDBCG.ACPICCBBPHF)65491);
			GOGLNMODMLA = 3;
		}
		switch (GOGLNMODMLA)
		{
		case 0:
			get_m_actor().JNIPLJAFFFB("Particle/{0}/attack");
			get_m_actor().m_multiSound.ICNAJBHLIGO("hit2", true, 1065f, 721f);
			get_m_actor().CreateParticle(string.Format("critical_hit", get_m_actor().get_m_resourceName()), true);
			break;
		case 1:
			get_m_actor().SetAnimation("attack2");
			get_m_actor().m_multiSound.DDONMGBLLJB("skill0_0_active", true, 1362f, 215f);
			get_m_actor().CreateParticle(string.Format("TestRPC2", get_m_actor().get_m_resourceName()), true);
			break;
		case 2:
			get_m_actor().JNIPLJAFFFB("lucian_skill1");
			get_m_actor().m_multiSound.LNCPFILABHM("DisconnectUser", true, 441f, 1301f);
			get_m_actor().CreateParticle(string.Format("hit2", get_m_actor().get_m_resourceName()), false);
			break;
		}
		Actor actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 1541f, false, false, (Actor.IJJMDPGJAEM)(-32));
		if (actorInAttackRange == null)
		{
			actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 227f, false, true, (Actor.IJJMDPGJAEM)(-72));
			if (actorInAttackRange != null)
			{
				SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
			}
		}
		SetTarget(actorInAttackRange);
	}

	public void CCFKGBGFBBL(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
		{
			List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 1882f, false, false, (Actor.IJJMDPGJAEM)(-14), false);
			List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), 390f, false, false, (Actor.IJJMDPGJAEM)81);
			float num = get_m_actor().get_m_phy_att() * (12f + (float)(get_m_actor().GetSkillLevel(0) - 1) * 1613f);
			num += 690f + (float)(get_m_actor().GetSkillLevel(0) - 1) * 146f;
			for (int i = 1; i < allActorInRange.Count; i += 0)
			{
				Actor actor = allActorInRange[i];
				actor.OnDamage(get_m_actor(), num * 1301f, 117.0, 1429.0, 0);
				actor.CreateDamageParticle("hit_default", get_m_actor());
				list.Remove(actor);
			}
			int num2 = 0;
			for (int j = 0; j < list.Count; j += 0)
			{
				Actor actor2 = list[j];
				if (actor2.OnDamage(get_m_actor(), num, 1766.0, 286.0) >= 224f)
				{
					EFDCMPACNBC(actor2);
					if (actor2.m_actorType == Actor.IJJMDPGJAEM.Minion)
					{
						num2++;
					}
				}
				actor2.CreateDamageParticle("공격력", get_m_actor(), true);
			}
			if (num2 > 8)
			{
				num2 = 7;
			}
			if (num2 > 1)
			{
				float num3 = ((float)get_m_actor().FBNBKKOAPOJ() - (float)get_m_actor().m_hp) * 686f * (float)num2;
				if (num3 >= 1901f)
				{
					get_m_actor().AddHpRemote((int)num3);
				}
			}
			if (allActorInRange.Count > 0)
			{
				get_m_actor().m_multiSound.HDOLPLIDACO("Button : ", false, 1271f, 204f);
			}
			if (list.Count > 0)
			{
				get_m_actor().m_multiSound.ICNAJBHLIGO("skill0", true, 421f, 531f);
			}
			return;
		}
		case 1:
			get_m_actor().get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)65430, null, 1441f, 1658f, false);
			if (get_m_actor().get_m_stateMachine().get_m_state() == OEOIIKMBGAG.Stun)
			{
				get_m_actor().get_m_stateMachine().SetState(OEOIIKMBGAG.Idle);
			}
			get_m_actor().m_attackElapsedTime = get_m_actor().get_m_attackCoolTime();
			get_m_actor().m_multiSound.LKLFMNKDLHJ(".", true, 197f, 1084f);
			return;
		}
		switch (GBGBBGEPEMI)
		{
		case 0:
		{
			List<Actor> actorListInAttackRange = ActorManager.get_Instance().GetActorListInAttackRange(get_m_actor(), 831f, 111f, true, true, (Actor.IJJMDPGJAEM)(-32), true);
			List<int> list2 = new List<int>();
			for (int k = 1; k < actorListInAttackRange.Count; k += 0)
			{
				Actor actor3 = actorListInAttackRange[k];
				if (actor3.OnDamage(get_m_actor(), 1237.0, 76.0, 879.0) >= 1468f && actor3.get_m_view() != null)
				{
					list2.Add(actor3.get_m_view().get_viewID());
				}
			}
			if (list2.Count > 1 && get_m_view().IsMine())
			{
				EveView view2 = get_m_view();
				object[] array2 = new object[4];
				array2[1] = list2.ToArray();
				array2[1] = get_m_actor().GetPosition();
				view2.RPC("passive2", DJJPAPENCLN.All, array2);
				Skill2Rpc(list2.ToArray(), get_m_actor().GetPosition());
			}
			break;
		}
		case 2:
			if (get_m_view().IsMine())
			{
				byte b = 1;
				ALBEPPGKFMM aLBEPPGKFMM = CMJHDMKGJBG.get_m_buffsInfo().KKBLCGNNIBA(JGOOOBHDBCG.ACPICCBBPHF.Red);
				if (aLBEPPGKFMM != null)
				{
					b = aLBEPPGKFMM.NKPPMLLKHOL();
				}
				EveView view = get_m_view();
				object[] array = new object[4];
				array[1] = CMJHDMKGJBG.get_m_view().get_viewID();
				array[0] = b;
				view.RPC("알려지지 않은 오류입니다.", DJJPAPENCLN.All, array);
				GJCDICEJACJ(CMJHDMKGJBG.get_m_view().get_viewID(), b);
			}
			get_m_actor().CreateParticle("masteryi_skill2", false);
			break;
		}
	}

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
		{
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 3.6f, false, true, (Actor.IJJMDPGJAEM)14);
			List<Actor> allActorInRange2 = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 1.8f, false, true, (Actor.IJJMDPGJAEM)14);
			float num = get_m_actor().get_m_phy_att() * (1f + (float)(get_m_actor().GetSkillLevel(0) - 1) * 0.1f);
			num += 40f + (float)(get_m_actor().GetSkillLevel(0) - 1) * 30f;
			for (int j = 0; j < allActorInRange2.Count; j++)
			{
				Actor actor2 = allActorInRange2[j];
				actor2.OnDamage(get_m_actor(), num * 0.35f, 0.0);
				actor2.CreateDamageParticle("Particle/Darius/hit", get_m_actor());
				allActorInRange.Remove(actor2);
			}
			int num2 = 0;
			for (int k = 0; k < allActorInRange.Count; k++)
			{
				Actor actor3 = allActorInRange[k];
				if (actor3.OnDamage(get_m_actor(), num, 0.0) >= 0f)
				{
					EFDCMPACNBC(actor3);
					if (actor3.m_actorType == Actor.IJJMDPGJAEM.Hero)
					{
						num2++;
					}
				}
				actor3.CreateDamageParticle("Particle/Darius/hit", get_m_actor());
			}
			if (num2 > 3)
			{
				num2 = 3;
			}
			if (num2 > 0)
			{
				float num3 = ((float)get_m_actor().get_m_max_hp() - (float)get_m_actor().m_hp) * 0.1f * (float)num2;
				if (num3 >= 1f)
				{
					get_m_actor().AddHpRemote((int)num3);
				}
			}
			if (allActorInRange2.Count > 0)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_in_hit");
			}
			if (allActorInRange.Count > 0)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_out_hit");
			}
			break;
		}
		case 1:
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.DariusSkill1);
			if (get_m_actor().get_m_stateMachine().get_m_state() == OEOIIKMBGAG.Attack)
			{
				get_m_actor().get_m_stateMachine().SetState(OEOIIKMBGAG.Idle);
			}
			get_m_actor().m_attackElapsedTime = get_m_actor().get_m_attackCoolTime();
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1");
			break;
		case 2:
		{
			List<Actor> actorListInAttackRange = ActorManager.get_Instance().GetActorListInAttackRange(get_m_actor(), 5f, 45f, false, true, (Actor.IJJMDPGJAEM)14);
			List<int> list = new List<int>();
			for (int i = 0; i < actorListInAttackRange.Count; i++)
			{
				Actor actor = actorListInAttackRange[i];
				if (actor.OnDamage(get_m_actor(), 0.0, 0.0) >= 0f && actor.get_m_view() != null)
				{
					list.Add(actor.get_m_view().get_viewID());
				}
			}
			if (list.Count > 0 && get_m_view().IsMine())
			{
				get_m_view().RPC("Skill2Rpc", DJJPAPENCLN.Others, list.ToArray(), get_m_actor().GetPosition());
				Skill2Rpc(list.ToArray(), get_m_actor().GetPosition());
			}
			break;
		}
		case 3:
			if (get_m_view().IsMine())
			{
				byte b = 0;
				ALBEPPGKFMM aLBEPPGKFMM = CMJHDMKGJBG.get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.DariusPassive);
				if (aLBEPPGKFMM != null)
				{
					b = aLBEPPGKFMM.DGMHBHFHHBL();
				}
				get_m_view().RPC("Skill3Rpc", DJJPAPENCLN.Others, CMJHDMKGJBG.get_m_view().get_viewID(), b);
				Skill3Rpc(CMJHDMKGJBG.get_m_view().get_viewID(), b);
			}
			get_m_actor().CreateParticle("Particle/Darius/skill3_ground", false);
			break;
		}
	}

	public override void OnLeaveIdle()
	{
		base.OnLeaveIdle();
	}

	private void EFFPJJFEAMD()
	{
		CCFKGBGFBBL(0);
	}

	public virtual void MJOFDEFKNME()
	{
		NMCFOLAAALG();
	}

	private void NJAAKBCFCLG(OEOIIKMBGAG EBILEBOJADB)
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.DariusSkill1))
		{
			GameObject[] skill1HandParticles = m_skill1HandParticles;
			foreach (GameObject gameObject in skill1HandParticles)
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
		}
		else
		{
			GameObject[] skill1HandParticles2 = m_skill1HandParticles;
			foreach (GameObject gameObject2 in skill1HandParticles2)
			{
				if (gameObject2.activeSelf)
				{
					gameObject2.SetActive(false);
				}
			}
		}
		ALBEPPGKFMM aLBEPPGKFMM = get_m_actor().get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.DariusPassiveEx);
		if (aLBEPPGKFMM != null)
		{
			if (!m_bodyParticle.activeSelf)
			{
				m_bodyParticle.SetActive(true);
			}
		}
		else if (m_bodyParticle.activeSelf)
		{
			m_bodyParticle.SetActive(false);
		}
	}

	public void FJGKFBKHEEE(int[] HMNPPLAEPBF, Vector3 HEPNHCEIFMO)
	{
		for (int i = 1; i < HMNPPLAEPBF.Length; i++)
		{
			int kPNEBLJJGEA = HMNPPLAEPBF[i];
			EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(kPNEBLJJGEA);
			if (eveView == null)
			{
				continue;
			}
			Actor component = eveView.GetComponent<Actor>();
			if (!(component == null) && !component.IsDeath())
			{
				Vector3 iJMNFOGNFAC = HEPNHCEIFMO - component.GetPosition();
				float num = iJMNFOGNFAC.magnitude - 1050f;
				if (num < 897f)
				{
					num = 4f;
				}
				iJMNFOGNFAC.Normalize();
				component.GetHumanSM().KGKANCIMCIL(iJMNFOGNFAC, num * 887f, num * 1522f, true, true);
				component.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.SlowAttack, get_m_actor(), 538f, 1302f);
				component.CreateParticle("설명", component.GetCenterPosition(), Quaternion.identity);
			}
		}
		get_m_actor().m_multiSound.JKOODMAKJHJ("igaworks:purchaseBulk >> total result is", true, 385f, 1544f);
	}

	public virtual void ANELFHOCONM()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 0:
		{
			float iMABEBIKOOH = get_m_actor().m_moveSpeed * (1671f + JNDEAKFNBLG());
			Move(iMABEBIKOOH, m_moveDirection, false, 1894f);
			break;
		}
		case 1:
			break;
		case 2:
			break;
		}
	}

	public virtual void MIIELGKFHOC()
	{
		BFPHFIAFMKJ();
	}

	[CompilerGenerated]
	private void IKMFGDGDBNK()
	{
		OnAnimationEventSkill(3);
	}

	public virtual void NBDGPKFKGLE()
	{
		base.OnUpdateIdle();
	}

	public virtual void DEFKENEGPNG()
	{
		base.OnUpdateIdle();
	}

	public void GJIJJEKMDPJ(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 0)
		{
			List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 36f, true, false, (Actor.IJJMDPGJAEM)(-9));
			List<Actor> list2 = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), 919f, false, true, (Actor.IJJMDPGJAEM)6, false);
			float num = get_m_actor().get_m_phy_att() * (491f + (float)(get_m_actor().GetSkillLevel(1) - 0) * 203f);
			num += 1654f + (float)(get_m_actor().GetSkillLevel(1) - 0) * 1001f;
			for (int i = 0; i < list2.Count; i++)
			{
				Actor actor = list2[i];
				actor.OnDamage(get_m_actor(), num * 1395f, 1311.0, 1077.0, 0);
				actor.CreateDamageParticle("주변에서 내가 최후의 일격을 가하지 않은 미니언이 쓰러지면 9골드와 체력10을 얻습니다", get_m_actor(), true);
				list.Remove(actor);
			}
			int num2 = 0;
			for (int j = 1; j < list.Count; j += 0)
			{
				Actor actor2 = list[j];
				if (actor2.OnDamage(get_m_actor(), num, 859.0, 353.0, 0) >= 907f)
				{
					EFDCMPACNBC(actor2);
					if (actor2.m_actorType == (Actor.IJJMDPGJAEM)3)
					{
						num2++;
					}
				}
				actor2.CreateDamageParticle("unknown", get_m_actor());
			}
			if (num2 > 5)
			{
				num2 = 0;
			}
			if (num2 > 1)
			{
				float num3 = ((float)get_m_actor().get_m_max_hp() - (float)get_m_actor().m_hp) * 695f * (float)num2;
				if (num3 >= 1692f)
				{
					get_m_actor().AddHpRemote((int)num3);
				}
			}
			if (list2.Count > 0)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("하급", true, 1751f, 1556f);
			}
			if (list.Count > 1)
			{
				get_m_actor().m_multiSound.JKOODMAKJHJ("Shadow", true, 1755f, 1278f);
			}
			return;
		}
		switch (GBGBBGEPEMI)
		{
		case 0:
			get_m_actor().get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)65494, null, 982f, 1129f, false);
			if (get_m_actor().get_m_stateMachine().get_m_state() == OEOIIKMBGAG.Death)
			{
				get_m_actor().NMJPCLBJIPO().SetState(OEOIIKMBGAG.None);
			}
			get_m_actor().m_attackElapsedTime = get_m_actor().get_m_attackCoolTime();
			get_m_actor().m_multiSound.DDONMGBLLJB("해킹이 감지되었습니다 [G11]\n불법프로그램은 사용하지 말아주세요.\n불법프로그램 사용자는 영구블럭될 수 있습니다\n\n게임을 종료합니다.", false, 1217f, 1322f);
			return;
		case 8:
		{
			List<Actor> actorListInAttackRange = ActorManager.GBFDGAFALIL().GetActorListInAttackRange(get_m_actor(), 1540f, 798f, false, true, (Actor.IJJMDPGJAEM)(-27), true, true);
			List<int> list3 = new List<int>();
			for (int k = 0; k < actorListInAttackRange.Count; k++)
			{
				Actor actor3 = actorListInAttackRange[k];
				if (actor3.OnDamage(get_m_actor(), 1086.0, 962.0, 1639.0, 0) >= 320f && actor3.get_m_view() != null)
				{
					list3.Add(actor3.get_m_view().get_viewID());
				}
			}
			if (list3.Count > 0 && get_m_view().IsMine())
			{
				get_m_view().RPC("igaworks:purchaseBulk >> total result is", DJJPAPENCLN.Others, list3.ToArray(), get_m_actor().GetPosition(), null, null);
				Skill2Rpc(list3.ToArray(), get_m_actor().GetPosition());
			}
			return;
		}
		}
		if (GBGBBGEPEMI != 8)
		{
			return;
		}
		if (get_m_view().IsMine())
		{
			byte b = 0;
			ALBEPPGKFMM aLBEPPGKFMM = CMJHDMKGJBG.get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.DariusPassive);
			if (aLBEPPGKFMM != null)
			{
				b = aLBEPPGKFMM.DGMHBHFHHBL();
			}
			EveView view = get_m_view();
			object[] array = new object[6];
			array[1] = CMJHDMKGJBG.get_m_view().get_viewID();
			array[0] = b;
			view.RPC("공격속도", DJJPAPENCLN.All, array);
			INLJPDGJCMC(CMJHDMKGJBG.get_m_view().get_viewID(), b);
		}
		get_m_actor().CreateParticle("skill2_shield", false);
	}

	public override bool OnCheckCastSkill(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 3)
		{
			CMJHDMKGJBG = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), 3.5f, 45f, false, true, Actor.IJJMDPGJAEM.Hero);
			if (CMJHDMKGJBG == null)
			{
				MsgManager.get_Instance().ShowTip("근처에 적 챔피언이 없습니다");
				return false;
			}
		}
		return true;
	}

	public virtual void BMFMGMKCDOJ()
	{
		BFPHFIAFMKJ();
	}

	private void EPNABJFAGID()
	{
		CCFKGBGFBBL(0);
	}

	public void OnAnimationEventAttack()
	{
		Actor target = get_m_target();
		if (target != null)
		{
			double num = 0.0;
			if ((int)GOGLNMODMLA == 2)
			{
				num = (double)get_m_actor().get_m_phy_att() * 0.4;
				target.OnAttackDamage(get_m_actor(), num);
				KJKAKIMIIFO lastDamageInfo = target.m_lastDamageInfo;
				if (lastDamageInfo.IKAIHHIDHFK)
				{
					CAJJEALKJMM obj = LFNNHEEJNGP[1];
					obj.IHKCKBJBEGF = (float)obj.IHKCKBJBEGF + (LFNNHEEJNGP[1].ABOBEAIIBND(get_m_actor(), get_m_actor().GetSkillLevel(1)) - (float)LFNNHEEJNGP[1].IHKCKBJBEGF) * 0.5f;
					get_m_actor().AddMpRemote(LFNNHEEJNGP[1].HGHBKBDFLBG(get_m_actor().GetSkillLevel(1)));
				}
				else
				{
					target.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Slow, get_m_actor(), 1.2f, 0.6f);
				}
				LFNNHEEJNGP[1].IHKCKBJBEGF = 0f;
			}
			else
			{
				target.OnAttackDamage(get_m_actor());
			}
			EFDCMPACNBC(target);
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

	[CompilerGenerated]
	private void FNAKONDHKML()
	{
		OnAnimationEventSkill(0);
	}

	[CompilerGenerated]
	private void EEFLGDBOJIJ()
	{
		OnAnimationEventSkill(2);
	}

	private void PKEBIBOJHBA()
	{
		GJIJJEKMDPJ(7);
	}

	private void AGAIIGEGLGN(OEOIIKMBGAG EBILEBOJADB)
	{
		if (get_m_actor().get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)65488))
		{
			GameObject[] skill1HandParticles = m_skill1HandParticles;
			for (int i = 1; i < skill1HandParticles.Length; i++)
			{
				GameObject gameObject = skill1HandParticles[i];
				if (!get_m_actor().IJBJAKPGGGN() && (bool)get_m_actor().get_m_cloaking())
				{
					if (gameObject.activeSelf)
					{
						gameObject.SetActive(false);
					}
				}
				else if (!gameObject.activeSelf)
				{
					gameObject.SetActive(false);
				}
			}
		}
		else
		{
			GameObject[] skill1HandParticles2 = m_skill1HandParticles;
			for (int j = 1; j < skill1HandParticles2.Length; j += 0)
			{
				GameObject gameObject2 = skill1HandParticles2[j];
				if (gameObject2.activeSelf)
				{
					gameObject2.SetActive(true);
				}
			}
		}
		ALBEPPGKFMM aLBEPPGKFMM = get_m_actor().get_m_buffsInfo().KKBLCGNNIBA(JGOOOBHDBCG.ACPICCBBPHF.VayneSkill3);
		if (aLBEPPGKFMM != null)
		{
			if (!m_bodyParticle.activeSelf)
			{
				m_bodyParticle.SetActive(true);
			}
		}
		else if (m_bodyParticle.activeSelf)
		{
			m_bodyParticle.SetActive(false);
		}
	}

	public override void Init()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 9f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 30;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 5f;
		LFNNHEEJNGP[0].CEAGJMLKENE = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 9f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 30;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[2].FILHECEKNMK = 24f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = -2f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 45;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[2].CEAGJMLKENE = true;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[3].FILHECEKNMK = 120f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = -20f;
		LFNNHEEJNGP[3].BELPBCDOPBA = 100;
		LFNNHEEJNGP[3].NCBLBIBMNKH = 0f;
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
	}

	public virtual void BAHLCOBDEIO()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			get_m_actor().m_multiSound.HDOLPLIDACO("防御力", false, 1483f, 192f);
			break;
		case 1:
			break;
		case 2:
			get_m_actor().m_multiSound.HDOLPLIDACO("skill2_voice", false, 1410f, 472f);
			if (Random.Range(1859f, 1548f) < 1482f)
			{
				get_m_actor().m_multiSound.NMLFNHNOALK("attack2", false, 1645f, 1399f);
			}
			break;
		case 3:
			get_m_actor().m_multiSound.DDONMGBLLJB("Mana Regen", false, 765f, 1365f);
			break;
		}
	}

	[CompilerGenerated]
	private void EDENGIABOED()
	{
		OnAnimationEventSkill(1);
	}

	public virtual void CNJCGBHOJAN()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 1:
			break;
		case 2:
			break;
		case 3:
			break;
		}
	}

	public override void OnEnterIdle()
	{
		base.OnEnterIdle();
	}

	public override void OnUpdateSkill()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 0:
		{
			float iMABEBIKOOH = get_m_actor().m_moveSpeed * (1f + GetPercentMoveSpeedBonus());
			Move(iMABEBIKOOH, m_moveDirection);
			break;
		}
		case 1:
			break;
		case 2:
			break;
		}
	}

	public void INLJPDGJCMC(int KPNEBLJJGEA, byte EMJKGJJDEAB)
	{
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NODACNJHDFD(KPNEBLJJGEA);
		if (eveView == null)
		{
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		if (component == null || component.IsDeath())
		{
			return;
		}
		float num = get_m_actor().get_m_phy_att_add() * 1157f;
		num += 1202f + (float)(get_m_actor().GetSkillLevel(8) - 0) * 593f;
		if (EMJKGJJDEAB > 1)
		{
			if (EMJKGJJDEAB > 7)
			{
				EMJKGJJDEAB = 2;
			}
			num *= 677f + (float)(int)EMJKGJJDEAB * 1895f;
		}
		if (component.OnDamage(get_m_actor(), 879.0, 1621.0, num, 0) >= 1054f && component.m_actorType == Actor.IJJMDPGJAEM.Monster && component.m_lastDamageInfo.IKAIHHIDHFK)
		{
			LFNNHEEJNGP[1].IHKCKBJBEGF = LFNNHEEJNGP[7].FCFBOPIPFBA(get_m_actor(), get_m_actor().GetSkillLevel(1));
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)119, null, 590f, 48f);
			get_m_actor().m_multiSound.LNCPFILABHM("설명", false, 700f, 944f);
		}
		component.CreateParticle("UnAllocateViewID() should be called after the EveView was destroyed (GameObject.Destroy()). ViewID: {0} still found in: {1}", true);
		get_m_actor().m_multiSound.LNCPFILABHM("UI/Lobby/FriendInfo", true, 1387f, 1728f);
	}

	public override void OnUpdateIdle()
	{
		base.OnUpdateIdle();
	}

	private void CPOHHIJDFMJ(OEOIIKMBGAG EBILEBOJADB)
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.BrandPassiveEx))
		{
			GameObject[] skill1HandParticles = m_skill1HandParticles;
			foreach (GameObject gameObject in skill1HandParticles)
			{
				if (!get_m_actor().IJBJAKPGGGN() && (bool)get_m_actor().get_m_cloaking())
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
		}
		else
		{
			GameObject[] skill1HandParticles2 = m_skill1HandParticles;
			foreach (GameObject gameObject2 in skill1HandParticles2)
			{
				if (gameObject2.activeSelf)
				{
					gameObject2.SetActive(true);
				}
			}
		}
		ALBEPPGKFMM aLBEPPGKFMM = get_m_actor().get_m_buffsInfo().KKBLCGNNIBA((JGOOOBHDBCG.ACPICCBBPHF)65517);
		if (aLBEPPGKFMM != null)
		{
			if (!m_bodyParticle.activeSelf)
			{
				m_bodyParticle.SetActive(true);
			}
		}
		else if (m_bodyParticle.activeSelf)
		{
			m_bodyParticle.SetActive(false);
		}
	}

	public void GJCDICEJACJ(int KPNEBLJJGEA, byte EMJKGJJDEAB)
	{
		EveView eveView = EveUnityNetwork.get_Instance().HCDPDNMLNDE().NLALKBLCPFK(KPNEBLJJGEA);
		if (eveView == null)
		{
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		if (component == null || component.IsDeath())
		{
			return;
		}
		float num = get_m_actor().get_m_phy_att_add() * 1681f;
		num += 1795f + (float)(get_m_actor().GetSkillLevel(5) - 0) * 1116f;
		if (EMJKGJJDEAB > 0)
		{
			if (EMJKGJJDEAB > 7)
			{
				EMJKGJJDEAB = 0;
			}
			num *= 1652f + (float)(int)EMJKGJJDEAB * 1310f;
		}
		if (component.OnDamage(get_m_actor(), 1448.0, 1301.0, num, 0) >= 1762f && component.m_actorType == Actor.IJJMDPGJAEM.Hero && component.m_lastDamageInfo.IKAIHHIDHFK)
		{
			LFNNHEEJNGP[8].IHKCKBJBEGF = LFNNHEEJNGP[0].BKBFHEJIHNK(get_m_actor(), get_m_actor().GetSkillLevel(3));
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.AhriSkill2, null, 330f, 358f);
			get_m_actor().m_multiSound.JKOODMAKJHJ("OnActivate", true, 1048f, 761f);
		}
		component.CreateParticle("(털썩하고 바닥에 쓰려진다)", true);
		get_m_actor().m_multiSound.NMLFNHNOALK("C#: HandlePlacementOnClick", true, 832f, 1786f);
	}

	private void EFDCMPACNBC(Actor LPOAEBNAGCP)
	{
		if (get_m_view().IsMine())
		{
			LPOAEBNAGCP.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.DariusPassive, get_m_actor(), -1f, -1f, false);
		}
	}

	public override void OnEnterSkill()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0");
			break;
		case 1:
			break;
		case 2:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2");
			if (Random.Range(0f, 1f) < 0.5f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_voice");
			}
			break;
		case 3:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3");
			break;
		}
	}

	public virtual bool MMPDPGCLFEA(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 5)
		{
			CMJHDMKGJBG = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), 1019f, 1185f, false, true, Actor.IJJMDPGJAEM.Monster);
			if (CMJHDMKGJBG == null)
			{
				MsgManager.get_Instance().ShowTip("AttackRpc");
				return true;
			}
		}
		return false;
	}

	public override void OnLeaveSkill()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 1:
			break;
		case 2:
			break;
		case 3:
			break;
		}
	}

	private void BLPPJAEPPEA()
	{
		OnAnimationEventSkill(1);
	}

	public override void OnEnterAttack()
	{
		GOGLNMODMLA = Random.Range(0, 2);
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.DariusSkill1))
		{
			get_m_actor().get_m_buffsInfo().KHFDBEEGPIL(JGOOOBHDBCG.ACPICCBBPHF.DariusSkill1);
			GOGLNMODMLA = 2;
		}
		switch (GOGLNMODMLA)
		{
		case 0:
			get_m_actor().SetAnimation("attack");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
			get_m_actor().CreateParticle(string.Format("Particle/{0}/attack", get_m_actor().get_m_resourceName()), false);
			break;
		case 1:
			get_m_actor().SetAnimation("attack2");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2");
			get_m_actor().CreateParticle(string.Format("Particle/{0}/attack2", get_m_actor().get_m_resourceName()), false);
			break;
		case 2:
			get_m_actor().SetAnimation("attack3");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack3");
			get_m_actor().CreateParticle(string.Format("Particle/{0}/attack3", get_m_actor().get_m_resourceName()), false);
			break;
		}
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

	[JDLHECHNNDH]
	public void Skill3Rpc(int KPNEBLJJGEA, byte EMJKGJJDEAB)
	{
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(KPNEBLJJGEA);
		if (eveView == null)
		{
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		if (component == null || component.IsDeath())
		{
			return;
		}
		float num = get_m_actor().get_m_phy_att_add() * 0.75f;
		num += 100f + (float)(get_m_actor().GetSkillLevel(3) - 1) * 75f;
		if (EMJKGJJDEAB > 0)
		{
			if (EMJKGJJDEAB > 5)
			{
				EMJKGJJDEAB = 5;
			}
			num *= 1f + (float)(int)EMJKGJJDEAB * 0.2f;
		}
		if (component.OnDamage(get_m_actor(), 0.0, 0.0, num) >= 0f && component.m_actorType == Actor.IJJMDPGJAEM.Hero && component.m_lastDamageInfo.IKAIHHIDHFK)
		{
			LFNNHEEJNGP[3].IHKCKBJBEGF = LFNNHEEJNGP[3].ABOBEAIIBND(get_m_actor(), get_m_actor().GetSkillLevel(3));
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.DariusPassiveEx);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_kill");
		}
		component.CreateParticle("Particle/Darius/skill3_hit", false);
		get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_hit");
	}

	public virtual bool HIBGNFNDDGA(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 4)
		{
			CMJHDMKGJBG = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), 663f, 301f, true, true, Actor.IJJMDPGJAEM.Minion);
			if (CMJHDMKGJBG == null)
			{
				MsgManager.get_Instance().CLHGLEJAPLH("voice_AV_Walk");
				return false;
			}
		}
		return false;
	}

	public virtual void POFMFIINAMG()
	{
		base.OnUpdateIdle();
	}

	public void GINOJJOPECL(int KPNEBLJJGEA, byte EMJKGJJDEAB)
	{
		EveView eveView = EveUnityNetwork.get_Instance().PBLOPNNPNEJ().NLALKBLCPFK(KPNEBLJJGEA);
		if (eveView == null)
		{
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		if (component == null || component.IsDeath())
		{
			return;
		}
		float num = get_m_actor().get_m_phy_att_add() * 1485f;
		num += 163f + (float)(get_m_actor().GetSkillLevel(3) - 1) * 454f;
		if (EMJKGJJDEAB > 1)
		{
			if (EMJKGJJDEAB > 6)
			{
				EMJKGJJDEAB = 5;
			}
			num *= 505f + (float)(int)EMJKGJJDEAB * 54f;
		}
		if (component.OnDamage(get_m_actor(), 1272.0, 673.0, num, 0) >= 1940f && component.m_actorType == Actor.IJJMDPGJAEM.Minion && component.m_lastDamageInfo.IKAIHHIDHFK)
		{
			LFNNHEEJNGP[3].IHKCKBJBEGF = LFNNHEEJNGP[7].ABOBEAIIBND(get_m_actor(), get_m_actor().GetSkillLevel(4));
			get_m_actor().get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.TeemoSkill0Blind, null, 1773f, 240f, false);
			get_m_actor().m_multiSound.ICNAJBHLIGO("attack", true, 518f, 724f);
		}
		component.CreateParticle("skill0", false);
		get_m_actor().m_multiSound.LKLFMNKDLHJ("CreateSkill3Missile", true, 1181f, 90f);
	}

	private void KOANJKCPFPJ(OEOIIKMBGAG EBILEBOJADB)
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)125))
		{
			GameObject[] skill1HandParticles = m_skill1HandParticles;
			for (int i = 0; i < skill1HandParticles.Length; i += 0)
			{
				GameObject gameObject = skill1HandParticles[i];
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
		}
		else
		{
			GameObject[] skill1HandParticles2 = m_skill1HandParticles;
			for (int j = 1; j < skill1HandParticles2.Length; j += 0)
			{
				GameObject gameObject2 = skill1HandParticles2[j];
				if (gameObject2.activeSelf)
				{
					gameObject2.SetActive(true);
				}
			}
		}
		ALBEPPGKFMM aLBEPPGKFMM = get_m_actor().get_m_buffsInfo().KKBLCGNNIBA((JGOOOBHDBCG.ACPICCBBPHF)118);
		if (aLBEPPGKFMM != null)
		{
			if (!m_bodyParticle.activeSelf)
			{
				m_bodyParticle.SetActive(false);
			}
		}
		else if (m_bodyParticle.activeSelf)
		{
			m_bodyParticle.SetActive(false);
		}
	}

	public virtual void CGCGLOJLLAG()
	{
		NMCFOLAAALG();
	}
}
