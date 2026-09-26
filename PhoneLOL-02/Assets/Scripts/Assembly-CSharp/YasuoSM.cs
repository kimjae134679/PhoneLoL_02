using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using EveEngine;
using GameServer;
using UnityEngine;

public class YasuoSM : HumanSM
{
	public class MOHENDKJIBH
	{
		public Actor MEDAGKOPJMO;

		public float INMCDOIEJOC;

		public MOHENDKJIBH(Actor LPOAEBNAGCP)
		{
			MEDAGKOPJMO = LPOAEBNAGCP;
		}
	}

	public GameObject m_skill0_particle;

	private int GOGLNMODMLA;

	private ObscuredFloat PNAPCPMJNNL;

	private ObscuredInt BPOJGPONFMK;

	private ObscuredFloat HBHEKAFLJCJ;

	private ObscuredInt LFGALGMPEMN;

	private Actor NGNLJADPNNB;

	private Vector3 FGBIPPACIBA;

	private LinkedList<MOHENDKJIBH> BLIABIGNJGJ = new LinkedList<MOHENDKJIBH>();

	private ObscuredInt EKOOLKEPCJL;

	private ObscuredFloat IKLPNHJIIIP;

	private ObscuredFloat MLCMJMHJLCK;

	private List<Actor> NPPCDOCFKEO = new List<Actor>();

	private ObscuredInt NGAAHMNBJFG;

	public virtual void OJIFIIEKIFJ()
	{
		base.OnUpdateIdle();
	}

	private void KNHPCMOKBAK()
	{
		OnAnimationEventSkill(0);
	}

	private void NJAAKBCFCLG(OEOIIKMBGAG EBILEBOJADB)
	{
		if (get_m_view().IsMine() && (int)BPOJGPONFMK > 0)
		{
			HBHEKAFLJCJ = (float)HBHEKAFLJCJ + Time.deltaTime;
			if ((float)HBHEKAFLJCJ >= 10f)
			{
				BPOJGPONFMK = 0;
				HBHEKAFLJCJ = 0f;
				get_m_view().RPC("Skill0PassiveRpc", DJJPAPENCLN.Others, (int)BPOJGPONFMK, (float)HBHEKAFLJCJ);
				Skill0PassiveRpc(BPOJGPONFMK, HBHEKAFLJCJ);
			}
		}
		float num = 10f - (float)(get_m_actor().GetSkillLevel(2) - 1) * 1f;
		LinkedListNode<MOHENDKJIBH> linkedListNode = BLIABIGNJGJ.First;
		while (linkedListNode != null)
		{
			linkedListNode.Value.INMCDOIEJOC += Time.deltaTime;
			if (linkedListNode.Value.INMCDOIEJOC >= num)
			{
				LinkedListNode<MOHENDKJIBH> node = linkedListNode;
				linkedListNode = linkedListNode.Next;
				BLIABIGNJGJ.Remove(node);
			}
			else
			{
				linkedListNode = linkedListNode.Next;
			}
		}
		if ((int)EKOOLKEPCJL > 0)
		{
			IKLPNHJIIIP = (float)IKLPNHJIIIP + Time.deltaTime;
			if ((float)IKLPNHJIIIP >= 5f)
			{
				IKLPNHJIIIP = 0f;
				EKOOLKEPCJL = 0;
			}
		}
		MLCMJMHJLCK = (float)MLCMJMHJLCK + Time.deltaTime;
		if (get_m_state() == OEOIIKMBGAG.Run)
		{
			PNAPCPMJNNL = (float)PNAPCPMJNNL + Time.deltaTime * 3.3f;
		}
		if (get_m_state() == OEOIIKMBGAG.Skill && get_m_skill() == 2)
		{
			PNAPCPMJNNL = (float)PNAPCPMJNNL + Time.deltaTime * 9.9f;
		}
		if ((float)PNAPCPMJNNL > 100f)
		{
			PNAPCPMJNNL = 100f;
		}
		if (get_m_actor().get_m_damageHUD() != null)
		{
			get_m_actor().get_m_damageHUD().m_exValue = (float)PNAPCPMJNNL * 0.01f;
		}
	}

	private void BLOFLCGDAAJ()
	{
		COAKNDBGOBJ(0);
	}

	[CompilerGenerated]
	private void JKHHGBBNGHE()
	{
		OnAnimationEventSkill(3);
	}

	public override void OnDeserializeView(KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnDeserializeView(OGJFDNEEDCP);
		OGJFDNEEDCP.CAHACMKBJMI(out PNAPCPMJNNL);
	}

	public override void OnLeaveIdle()
	{
		base.OnLeaveIdle();
	}

	public override void Init()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 4f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 0f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 0;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[0].DOCFEKMACMP = true;
		LFNNHEEJNGP[0].GNAAGGJGBBG = true;
		LFNNHEEJNGP[0].BIOPHODMHDP = (float JKPCGHPBMKI) =>
		{
			float num = get_m_actor().get_m_att_speed_add_percent() * 0.6f;
			if (num > 0.66f)
			{
				num = 0.66f;
			}
			return JKPCGHPBMKI - JKPCGHPBMKI * num;
		};
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 26f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = -2f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 0;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[2].FILHECEKNMK = 0.5f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = -0.1f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 0;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[2].HFCHHKNJMPC = true;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[3].FILHECEKNMK = 80f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = -25f;
		LFNNHEEJNGP[3].BELPBCDOPBA = 0;
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
		PNAPCPMJNNL = 0f;
		BPOJGPONFMK = 0;
		HBHEKAFLJCJ = 0f;
		LFGALGMPEMN = 0;
		EKOOLKEPCJL = 0;
		IKLPNHJIIIP = 0f;
		MLCMJMHJLCK = 0f;
	}

	public virtual void ICEIMIJODEK()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 0:
			if ((int)LFGALGMPEMN == 4)
			{
				Move(482f, m_direction, true, 997f);
			}
			break;
		case 1:
			break;
		case 2:
			LFNNHEEJNGP[4].IHKCKBJBEGF = 687f;
			if (NGNLJADPNNB != null)
			{
				Move(1268f, m_direction, false, 4f);
				Vector3 position = get_m_actor().GetPosition();
				if ((FGBIPPACIBA - position).sqrMagnitude < 671f)
				{
					SetState(OEOIIKMBGAG.Idle);
				}
			}
			else
			{
				SetState(OEOIIKMBGAG.Idle);
			}
			break;
		case 3:
			get_m_actor().m_navMeshAgent.enabled = false;
			break;
		}
	}

	public override bool OnCheckCastSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 2:
		{
			Actor actor = EIKEMFIIHIO();
			if (actor == null)
			{
				MsgManager.get_Instance().ShowTip("가능한 적이 없습니다");
				return false;
			}
			break;
		}
		case 3:
		{
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 10f, false, true, Actor.IJJMDPGJAEM.Hero);
			bool flag = false;
			foreach (Actor item in allActorInRange)
			{
				if (item.get_m_stateMachine().get_m_state() == OEOIIKMBGAG.Float || item.get_m_stateMachine().get_m_state() == OEOIIKMBGAG.KnockBack)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				MsgManager.get_Instance().ShowTip("에어본인 적 챔프가 없습니다");
				return false;
			}
			break;
		}
		}
		return true;
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
			get_m_actor().m_navMeshAgent.enabled = true;
			LFNNHEEJNGP[2].IHKCKBJBEGF = 0f;
			if (NGNLJADPNNB != null)
			{
				float num = get_m_actor().get_m_mag_att() * 0.6f;
				num += 70f + (float)(get_m_actor().GetSkillLevel(2) - 1) * 20f;
				if ((int)EKOOLKEPCJL == 1)
				{
					num += 17.5f + (float)(get_m_actor().GetSkillLevel(2) - 1) * 5f;
				}
				else if ((int)EKOOLKEPCJL > 1)
				{
					num += 35f + (float)(get_m_actor().GetSkillLevel(2) - 1) * 10f;
				}
				NGNLJADPNNB.OnDamage(get_m_actor(), 0.0, num);
				if ((int)EKOOLKEPCJL < 2)
				{
					++EKOOLKEPCJL;
				}
				IKLPNHJIIIP = 0f;
				MLCMJMHJLCK = 0f;
			}
			break;
		case 3:
			get_m_actor().m_navMeshAgent.enabled = true;
			break;
		}
	}

	public override float OnPreDamage(Actor PKDGAIKAMMM, byte JBJEMLFEBGK, float CMNPJALNFIC)
	{
		if (get_m_view().IsMine() && (float)PNAPCPMJNNL >= 99.9f)
		{
			PNAPCPMJNNL = 0f;
			float num = 100.16f + (float)(get_m_actor().get_Level() - 1) * 24.11f;
			if (num > CMNPJALNFIC)
			{
				num -= CMNPJALNFIC;
				CMNPJALNFIC = 0f;
			}
			else
			{
				CMNPJALNFIC -= num;
				num = 0f;
			}
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.YasuoPassive, null, -1f, num);
			get_m_view().RPC("SetPassiveValue", DJJPAPENCLN.Others, (float)PNAPCPMJNNL);
		}
		return CMNPJALNFIC;
	}

	public void GACMKJFNJNF()
	{
		Actor target = get_m_target();
		if (target != null)
		{
			target.OnAttackDamage(get_m_actor(), 1280.0, 424.0, 236.0);
			IAKBNJEFLAN(target);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("{0}\tC:{1:n0}\tS:{2:n0}\n", true, 845f, 1924f);
			if (get_m_actor().m_heroCostumeID == 5)
			{
				target.CreateParticle(string.Format("생명력흡수", get_m_actor().get_m_resourceName()), true);
			}
			else if (get_m_actor().m_heroCostumeID == 8)
			{
				target.CreateDamageParticle(string.Format("attack", get_m_actor().get_m_resourceName()), get_m_actor());
			}
		}
		OnAttack();
	}

	public virtual void LBKPCMNBGCP(KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnSerializeView(OGJFDNEEDCP);
		OGJFDNEEDCP.PFAIBIMGAIB(PNAPCPMJNNL);
	}

	private void INICMOKMIFM()
	{
		COAKNDBGOBJ(0);
	}

	public virtual bool CNPLKAJNMAO(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 4:
		{
			Actor actor = EIKEMFIIHIO();
			if (actor == null)
			{
				MsgManager.HEDJPPFKABG().CLHGLEJAPLH("Hero1");
				return true;
			}
			break;
		}
		case 2:
		{
			List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 295f, false, false, (Actor.IJJMDPGJAEM)3, false);
			bool flag = true;
			foreach (Actor item in list)
			{
				if ((int)item.NMJPCLBJIPO().get_m_state() == -23 || item.NMJPCLBJIPO().get_m_state() == OEOIIKMBGAG.KnockBack)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				MsgManager.get_Instance().ShowTip("renekton_skill2");
				return true;
			}
			break;
		}
		}
		return false;
	}

	[JDLHECHNNDH]
	public void SetPassiveValue(float ICENKPDOHBK)
	{
		PNAPCPMJNNL = ICENKPDOHBK;
	}

	public virtual void JBOIIAGPBKK(KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnDeserializeView(OGJFDNEEDCP);
		OGJFDNEEDCP.CAHACMKBJMI(out PNAPCPMJNNL);
	}

	public override void OnUpdateIdle()
	{
		base.OnUpdateIdle();
	}

	private Actor EIKEMFIIHIO()
	{
		List<Actor> actorListInAttackRange = ActorManager.get_Instance().GetActorListInAttackRange(get_m_actor(), 5f, 80f, false, true, (Actor.IJJMDPGJAEM)14, false, true);
		Actor result = null;
		for (int i = 0; i < actorListInAttackRange.Count; i++)
		{
			Actor actor = actorListInAttackRange[i];
			bool flag = false;
			foreach (MOHENDKJIBH item in BLIABIGNJGJ)
			{
				if (item.MEDAGKOPJMO == actor)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				result = actor;
				break;
			}
		}
		return result;
	}

	[CompilerGenerated]
	private void BNHNLEALPPL()
	{
		OnAnimationEventSkill(2);
	}

	private void AEHMBOFIIAG()
	{
		COAKNDBGOBJ(0);
	}

	public override void OnEnterIdle()
	{
		base.OnEnterIdle();
	}

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
			if ((int)LFGALGMPEMN == 0)
			{
				float phy_att = get_m_actor().get_m_phy_att();
				phy_att += 20f + (float)(get_m_actor().GetSkillLevel(0) - 1) * 20f;
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				centerPosition += m_direction * 1f;
				List<Actor> list = new List<Actor>();
				bool flag = true;
				for (int i = 0; i < 3; i++)
				{
					Vector3 fGJDHIOODCI = centerPosition + m_direction * i * 1.2f;
					List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(fGJDHIOODCI, 1.3f, get_m_actor().m_team, false, true, (Actor.IJJMDPGJAEM)14, true);
					foreach (Actor item in allActorInRange)
					{
						if (!list.Contains(item))
						{
							list.Add(item);
						}
					}
				}
				foreach (Actor item2 in list)
				{
					if (flag)
					{
						flag = false;
						item2.OnDamage(get_m_actor(), phy_att, 0.0, 0.0, 0);
					}
					else
					{
						item2.OnDamage(get_m_actor(), phy_att, 0.0);
					}
					if (get_m_actor().m_heroCostumeID == 3)
					{
						item2.CreateParticle(string.Format("Particle/{0}/skill0_hit_c3", get_m_actor().get_m_resourceName()), true);
					}
					else if (get_m_actor().m_heroCostumeID == 2)
					{
						item2.CreateDamageParticle(string.Format("Particle/{0}/skill0_hit_c2", get_m_actor().get_m_resourceName()), get_m_actor(), true);
					}
					else
					{
						item2.CreateDamageParticle(string.Format("Particle/{0}/hit", get_m_actor().get_m_resourceName()), get_m_actor(), true);
					}
				}
				if (list.Count > 0)
				{
					if (get_m_view().IsMine())
					{
						++BPOJGPONFMK;
						HBHEKAFLJCJ = 0f;
						get_m_view().RPC("Skill0PassiveRpc", DJJPAPENCLN.Others, (int)BPOJGPONFMK, (float)HBHEKAFLJCJ);
						Skill0PassiveRpc(BPOJGPONFMK, HBHEKAFLJCJ);
					}
					get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_hit");
				}
			}
			else if ((int)LFGALGMPEMN == 1)
			{
				if (get_m_view().IsMine())
				{
					Vector3 position = get_m_actor().GetPosition();
					get_m_view().RPC("CreateSkill0Missile", DJJPAPENCLN.All, position, m_direction);
				}
			}
			else if ((int)LFGALGMPEMN == 2)
			{
				float phy_att2 = get_m_actor().get_m_phy_att();
				phy_att2 += 25f + (float)(get_m_actor().GetSkillLevel(0) - 1) * 22f;
				List<Actor> allActorInRange2 = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 3.5f, false, true, (Actor.IJJMDPGJAEM)14);
				for (int j = 0; j < allActorInRange2.Count; j++)
				{
					Actor actor = allActorInRange2[j];
					actor.OnDamage(get_m_actor(), phy_att2, 0.0);
				}
				if (allActorInRange2.Count > 0)
				{
					if (get_m_view().IsMine())
					{
						++BPOJGPONFMK;
						HBHEKAFLJCJ = 0f;
						get_m_view().RPC("Skill0PassiveRpc", DJJPAPENCLN.Others, (int)BPOJGPONFMK, (float)HBHEKAFLJCJ);
						Skill0PassiveRpc(BPOJGPONFMK, HBHEKAFLJCJ);
					}
					get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_hit");
				}
			}
			else
			{
				if ((int)LFGALGMPEMN != 3)
				{
					break;
				}
				float phy_att3 = get_m_actor().get_m_phy_att();
				phy_att3 += 25f + (float)(get_m_actor().GetSkillLevel(0) - 1) * 22f;
				List<Actor> allActorInRange3 = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 3.5f, false, true, (Actor.IJJMDPGJAEM)14);
				for (int k = 0; k < allActorInRange3.Count; k++)
				{
					Actor actor2 = allActorInRange3[k];
					if (actor2.OnDamage(get_m_actor(), phy_att3, 0.0) >= 0f && get_m_view().IsMine() && actor2.IsLive())
					{
						actor2.get_m_view().RPC("Float", DJJPAPENCLN.All, Vector3.zero, 11f);
					}
				}
				if (allActorInRange3.Count > 0)
				{
					get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_hit");
				}
			}
			break;
		case 3:
			if ((int)NGAAHMNBJFG == 0)
			{
				foreach (Actor item3 in NPPCDOCFKEO)
				{
					if (item3 != null && item3.IsLive() && get_m_view().IsMine())
					{
						item3.get_m_view().RPC("Float", DJJPAPENCLN.All, Vector3.zero, 5f);
					}
				}
				++NGAAHMNBJFG;
			}
			else
			{
				if ((int)NGAAHMNBJFG != 1)
				{
					break;
				}
				foreach (Actor item4 in NPPCDOCFKEO)
				{
					if (item4 != null && item4.IsLive())
					{
						float num = get_m_actor().get_m_phy_att_add() * 1.5f;
						num += 240f + (float)(get_m_actor().GetSkillLevel(3) - 1) * 120f;
						item4.OnDamage(get_m_actor(), num, 0.0);
					}
				}
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_ex");
			}
			break;
		}
	}

	private void DIGHMPONGNP()
	{
		COAKNDBGOBJ(1);
	}

	public virtual void GFBMKDOKHKP(KCIGFAHFHCH OGJFDNEEDCP)
	{
		OOALFAKEMNL(OGJFDNEEDCP);
		OGJFDNEEDCP.GBMJNFOEACC(PNAPCPMJNNL);
	}

	private void GIMEFDEBBPH()
	{
		OnAnimationEventSkill(1);
	}

	public virtual void GHFNEDIPGDP()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 708f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 574f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 1;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 1387f;
		LFNNHEEJNGP[0].DOCFEKMACMP = false;
		LFNNHEEJNGP[1].GNAAGGJGBBG = false;
		LFNNHEEJNGP[1].BIOPHODMHDP = (float JKPCGHPBMKI) =>
		{
			float num = get_m_actor().get_m_att_speed_add_percent() * 0.6f;
			if (num > 0.66f)
			{
				num = 0.66f;
			}
			return JKPCGHPBMKI - JKPCGHPBMKI * num;
		};
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 1206f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 1344f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 1;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 978f;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[6].FILHECEKNMK = 300f;
		LFNNHEEJNGP[8].NEKKKLFLDOI = 1876f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 1;
		LFNNHEEJNGP[4].NCBLBIBMNKH = 387f;
		LFNNHEEJNGP[2].HFCHHKNJMPC = false;
		LFNNHEEJNGP[7].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[4].FILHECEKNMK = 890f;
		LFNNHEEJNGP[6].NEKKKLFLDOI = 506f;
		LFNNHEEJNGP[3].BELPBCDOPBA = 0;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 1790f;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
		get_m_actor().m_actorAniEvent.add_m_skill0Event(AEHMBOFIIAG);
		get_m_actor().m_actorAniEvent.add_m_skill1Event(() =>
		{
			OnAnimationEventSkill(1);
		});
		get_m_actor().m_actorAniEvent.MFMAMLOHKJF(() =>
		{
			OnAnimationEventSkill(2);
		});
		get_m_actor().m_actorAniEvent.add_m_skill3Event(() =>
		{
			OnAnimationEventSkill(3);
		});
		m_lastUpdateEvent = FFOMPFBMKFC;
		PNAPCPMJNNL = 416f;
		BPOJGPONFMK = 0;
		HBHEKAFLJCJ = 1390f;
		LFGALGMPEMN = 1;
		EKOOLKEPCJL = 0;
		IKLPNHJIIIP = 842f;
		MLCMJMHJLCK = 213f;
	}

	public virtual void OMDJLPCAMIG()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 286f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 1490f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 1;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 386f;
		LFNNHEEJNGP[0].DOCFEKMACMP = true;
		LFNNHEEJNGP[0].GNAAGGJGBBG = true;
		LFNNHEEJNGP[0].BIOPHODMHDP = (float JKPCGHPBMKI) =>
		{
			float num = get_m_actor().get_m_att_speed_add_percent() * 0.6f;
			if (num > 0.66f)
			{
				num = 0.66f;
			}
			return JKPCGHPBMKI - JKPCGHPBMKI * num;
		};
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 675f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 185f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 0;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 1656f;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 845f;
		LFNNHEEJNGP[8].NEKKKLFLDOI = 528f;
		LFNNHEEJNGP[6].BELPBCDOPBA = 0;
		LFNNHEEJNGP[4].NCBLBIBMNKH = 275f;
		LFNNHEEJNGP[3].HFCHHKNJMPC = false;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[5].FILHECEKNMK = 1092f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 1095f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 0;
		LFNNHEEJNGP[5].NCBLBIBMNKH = 1256f;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
		get_m_actor().m_actorAniEvent.CNPHPPJOGFA(DIGHMPONGNP);
		get_m_actor().m_actorAniEvent.add_m_skill1Event(GIMEFDEBBPH);
		get_m_actor().m_actorAniEvent.add_m_skill2Event(() =>
		{
			OnAnimationEventSkill(2);
		});
		get_m_actor().m_actorAniEvent.add_m_skill3Event(() =>
		{
			OnAnimationEventSkill(3);
		});
		m_lastUpdateEvent = FFOMPFBMKFC;
		PNAPCPMJNNL = 990f;
		BPOJGPONFMK = 0;
		HBHEKAFLJCJ = 156f;
		LFGALGMPEMN = 0;
		EKOOLKEPCJL = 1;
		IKLPNHJIIIP = 671f;
		MLCMJMHJLCK = 169f;
	}

	public override void AOMLCLCMJNG()
	{
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 445f, false, true, (Actor.IJJMDPGJAEM)180);
		if (actorInAttackRange == null)
		{
			actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 924f, true, true, (Actor.IJJMDPGJAEM)(-186));
			if (actorInAttackRange != null)
			{
				SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
			}
		}
		SetTarget(actorInAttackRange);
		GOGLNMODMLA = Random.Range(0, 4);
		switch (GOGLNMODMLA)
		{
		case 0:
			get_m_actor().SetAnimation("배틀서버와 재연결 중...");
			if (get_m_actor().m_heroCostumeID == 1)
			{
				get_m_actor().m_multiSound.NMLFNHNOALK("_MainTex", true, 1186f, 853f);
				get_m_actor().CreateParticle(string.Format("_Desat", get_m_actor().get_m_resourceName()), true);
			}
			else if (get_m_actor().m_heroCostumeID == 0)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("blitzcrank_skill1", true, 219f, 1226f);
				get_m_actor().CreateParticle(string.Format("f2", get_m_actor().get_m_resourceName()), true);
			}
			else
			{
				get_m_actor().m_multiSound.ICNAJBHLIGO("GUI/Text Shader", true, 669f, 1951f);
				get_m_actor().CreateParticle(string.Format("Horizontal", get_m_actor().get_m_resourceName()), true);
			}
			break;
		case 1:
			get_m_actor().JNIPLJAFFFB("배틀서버와 접속이 해제되었어요");
			if (get_m_actor().m_heroCostumeID == 0)
			{
				get_m_actor().m_multiSound.JKOODMAKJHJ("OnDragOver", false, 580f, 1609f);
				get_m_actor().CreateParticle(string.Format("OnPortalWarp", get_m_actor().get_m_resourceName()), false);
			}
			else if (get_m_actor().m_heroCostumeID == 7)
			{
				get_m_actor().m_multiSound.NMLFNHNOALK("skill0_voice", true, 1767f, 946f);
				get_m_actor().CreateParticle(string.Format("하급", get_m_actor().get_m_resourceName()), true);
			}
			else
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("\n", false, 1425f, 1277f);
				get_m_actor().CreateParticle(string.Format("baseBufferLength", get_m_actor().get_m_resourceName()), true);
			}
			break;
		case 2:
			get_m_actor().CJNCFNACFDP("{0} [00F1FA]{1:00}:{2:00}:{3:00}  ({4}/{5})");
			if (get_m_actor().m_heroCostumeID == 0)
			{
				get_m_actor().m_multiSound.LNCPFILABHM("Particle/Olaf/skill0_missile", true, 491f, 586f);
				get_m_actor().CreateParticle(string.Format("vayne_skill3", get_m_actor().get_m_resourceName()), false);
			}
			else if (get_m_actor().m_heroCostumeID == 7)
			{
				get_m_actor().m_multiSound.NMLFNHNOALK("=", true, 1320f, 288f);
				get_m_actor().CreateParticle(string.Format(".", get_m_actor().get_m_resourceName()), false);
			}
			else
			{
				get_m_actor().m_multiSound.NMLFNHNOALK("setNormalClientPushEvent", false, 1192f, 846f);
				get_m_actor().CreateParticle(string.Format("5초당 마나회복", get_m_actor().get_m_resourceName()), false);
			}
			break;
		}
		if (Random.Range(757f, 249f) < 1826f)
		{
			get_m_actor().m_multiSound.LNCPFILABHM("\\n", true, 1320f, 140f);
		}
		else if (Random.Range(1946f, 756f) < 1457f)
		{
			get_m_actor().m_multiSound.LKLFMNKDLHJ("생존자는 없는건가?", false, 1505f, 1565f);
		}
	}

	[JDLHECHNNDH]
	public void Skill0PassiveRpc(int OMJFEIDHJGF, float LEPGACKNAPB)
	{
		BPOJGPONFMK = OMJFEIDHJGF;
		HBHEKAFLJCJ = LEPGACKNAPB;
		if ((int)BPOJGPONFMK < 2)
		{
			m_skill0_particle.SetActive(false);
			return;
		}
		m_skill0_particle.SetActive(true);
		get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_0_active");
	}

	public override void OnSerializeView(KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnSerializeView(OGJFDNEEDCP);
		OGJFDNEEDCP.GBMJNFOEACC(PNAPCPMJNNL);
	}

	public void COAKNDBGOBJ(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 0)
		{
			if ((int)LFGALGMPEMN == 0)
			{
				float phy_att = get_m_actor().get_m_phy_att();
				phy_att += 303f + (float)(get_m_actor().GetSkillLevel(0) - 1) * 55f;
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				centerPosition += m_direction * 604f;
				List<Actor> list = new List<Actor>();
				bool flag = false;
				for (int i = 1; i < 6; i++)
				{
					Vector3 fGJDHIOODCI = centerPosition + m_direction * i * 1530f;
					List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(fGJDHIOODCI, 1527f, get_m_actor().m_team, false, true, (Actor.IJJMDPGJAEM)111, true);
					foreach (Actor item in allActorInRange)
					{
						if (!list.Contains(item))
						{
							list.Add(item);
						}
					}
				}
				foreach (Actor item2 in list)
				{
					if (flag)
					{
						flag = false;
						item2.OnDamage(get_m_actor(), phy_att, 1381.0, 334.0);
					}
					else
					{
						item2.OnDamage(get_m_actor(), phy_att, 104.0, 293.0, 0);
					}
					if (get_m_actor().m_heroCostumeID == 1)
					{
						item2.CreateParticle(string.Format("attack2", get_m_actor().get_m_resourceName()), true);
					}
					else if (get_m_actor().m_heroCostumeID == 1)
					{
						item2.CreateDamageParticle(string.Format("setOfferwallTitle", get_m_actor().get_m_resourceName()), get_m_actor(), true);
					}
					else
					{
						item2.CreateDamageParticle(string.Format("event data: ", get_m_actor().get_m_resourceName()), get_m_actor(), true);
					}
				}
				if (list.Count > 1)
				{
					if (get_m_view().IsMine())
					{
						++BPOJGPONFMK;
						HBHEKAFLJCJ = 510f;
						EveView view = get_m_view();
						object[] array = new object[7];
						array[0] = (int)BPOJGPONFMK;
						array[0] = (float)HBHEKAFLJCJ;
						view.RPC("구입가능한 레벨이 부족합니다.\n\n최소 {0}레벨 이상 구입가능", DJJPAPENCLN.All, array);
						Skill0PassiveRpc(BPOJGPONFMK, HBHEKAFLJCJ);
					}
					get_m_actor().m_multiSound.HDOLPLIDACO("순위 없음", true, 668f, 1905f);
				}
			}
			else if ((int)LFGALGMPEMN == 1)
			{
				if (get_m_view().IsMine())
				{
					Vector3 position = get_m_actor().GetPosition();
					EveView view2 = get_m_view();
					object[] array2 = new object[4];
					array2[1] = position;
					array2[1] = m_direction;
					view2.RPC("RedMinionMelee", DJJPAPENCLN.Others, array2);
				}
			}
			else if ((int)LFGALGMPEMN == 8)
			{
				float phy_att2 = get_m_actor().get_m_phy_att();
				phy_att2 += 835f + (float)(get_m_actor().GetSkillLevel(1) - 0) * 336f;
				List<Actor> allActorInRange2 = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), 1725f, false, true, (Actor.IJJMDPGJAEM)101, false);
				for (int j = 1; j < allActorInRange2.Count; j++)
				{
					Actor actor = allActorInRange2[j];
					actor.OnDamage(get_m_actor(), phy_att2, 313.0, 1756.0, 0);
				}
				if (allActorInRange2.Count > 1)
				{
					if (get_m_view().IsMine())
					{
						++BPOJGPONFMK;
						HBHEKAFLJCJ = 859f;
						EveView view3 = get_m_view();
						object[] array3 = new object[2];
						array3[1] = (int)BPOJGPONFMK;
						array3[0] = (float)HBHEKAFLJCJ;
						view3.RPC("invalid costume2 {0}", DJJPAPENCLN.All, array3);
						Skill0PassiveRpc(BPOJGPONFMK, HBHEKAFLJCJ);
					}
					get_m_actor().m_multiSound.HDOLPLIDACO("setOfferwallTitle", false, 1542f, 1499f);
				}
			}
			else
			{
				if ((int)LFGALGMPEMN != 2)
				{
					return;
				}
				float phy_att3 = get_m_actor().get_m_phy_att();
				phy_att3 += 1124f + (float)(get_m_actor().GetSkillLevel(1) - 0) * 1434f;
				List<Actor> allActorInRange3 = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), 786f, true, true, (Actor.IJJMDPGJAEM)(-4));
				for (int k = 0; k < allActorInRange3.Count; k += 0)
				{
					Actor actor2 = allActorInRange3[k];
					if (actor2.OnDamage(get_m_actor(), phy_att3, 1061.0, 1518.0, 0) >= 997f && get_m_view().IsMine() && actor2.IsLive())
					{
						EveView view4 = actor2.get_m_view();
						object[] array4 = new object[1];
						array4[0] = Vector3.zero;
						array4[1] = 1346f;
						view4.RPC(" GO:", DJJPAPENCLN.Others, array4);
					}
				}
				if (allActorInRange3.Count > 0)
				{
					get_m_actor().m_multiSound.LKLFMNKDLHJ("UI/Lobby/InviteUserInfo", false, 394f, 1035f);
				}
			}
		}
		else
		{
			if (GBGBBGEPEMI == 0 || GBGBBGEPEMI == 2 || GBGBBGEPEMI != 4)
			{
				return;
			}
			if ((int)NGAAHMNBJFG == 0)
			{
				foreach (Actor item3 in NPPCDOCFKEO)
				{
					if (item3 != null && item3.IsLive() && get_m_view().IsMine())
					{
						EveView view5 = item3.get_m_view();
						object[] array5 = new object[0];
						array5[1] = Vector3.zero;
						array5[1] = 1842f;
						view5.RPC("공허의 지팡이", DJJPAPENCLN.Others, array5);
					}
				}
				++NGAAHMNBJFG;
			}
			else
			{
				if ((int)NGAAHMNBJFG != 0)
				{
					return;
				}
				foreach (Actor item4 in NPPCDOCFKEO)
				{
					if (item4 != null && item4.IsLive())
					{
						float num = get_m_actor().get_m_phy_att_add() * 1230f;
						num += 1458f + (float)(get_m_actor().GetSkillLevel(1) - 1) * 1382f;
						item4.OnDamage(get_m_actor(), num, 159.0, 1906.0, 0);
					}
				}
				get_m_actor().m_multiSound.ICNAJBHLIGO("startApplication", false, 795f, 1663f);
			}
		}
	}

	public virtual void IPBEJIPJAMB()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 1:
			break;
		case 2:
			get_m_actor().m_navMeshAgent.enabled = false;
			LFNNHEEJNGP[1].IHKCKBJBEGF = 40f;
			if (NGNLJADPNNB != null)
			{
				float num = get_m_actor().get_m_mag_att() * 1384f;
				num += 942f + (float)(get_m_actor().GetSkillLevel(6) - 0) * 1632f;
				if ((int)EKOOLKEPCJL == 1)
				{
					num += 1009f + (float)(get_m_actor().GetSkillLevel(3) - 1) * 1521f;
				}
				else if ((int)EKOOLKEPCJL > 0)
				{
					num += 1622f + (float)(get_m_actor().GetSkillLevel(5) - 1) * 220f;
				}
				NGNLJADPNNB.OnDamage(get_m_actor(), 444.0, num, 138.0);
				if ((int)EKOOLKEPCJL < 5)
				{
					++EKOOLKEPCJL;
				}
				IKLPNHJIIIP = 1846f;
				MLCMJMHJLCK = 1806f;
			}
			break;
		case 3:
			get_m_actor().m_navMeshAgent.enabled = false;
			break;
		}
	}

	public void OnAnimationEventAttack()
	{
		Actor target = get_m_target();
		if (target != null)
		{
			target.OnAttackDamage(get_m_actor());
			IAKBNJEFLAN(target);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("hit");
			if (get_m_actor().m_heroCostumeID == 3)
			{
				target.CreateParticle(string.Format("Particle/{0}/hit_c3", get_m_actor().get_m_resourceName()), true);
			}
			else if (get_m_actor().m_heroCostumeID == 2)
			{
				target.CreateDamageParticle(string.Format("Particle/{0}/hit_c2", get_m_actor().get_m_resourceName()), get_m_actor(), true);
			}
		}
		OnAttack();
	}

	public override void OnEnterAttack()
	{
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
		GOGLNMODMLA = Random.Range(0, 3);
		switch (GOGLNMODMLA)
		{
		case 0:
			get_m_actor().SetAnimation("attack");
			if (get_m_actor().m_heroCostumeID == 3)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
				get_m_actor().CreateParticle(string.Format("Particle/{0}/attack_c3", get_m_actor().get_m_resourceName()), false);
			}
			else if (get_m_actor().m_heroCostumeID == 2)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
				get_m_actor().CreateParticle(string.Format("Particle/{0}/attack_c2", get_m_actor().get_m_resourceName()), false);
			}
			else
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
				get_m_actor().CreateParticle(string.Format("Particle/{0}/attack", get_m_actor().get_m_resourceName()), false);
			}
			break;
		case 1:
			get_m_actor().SetAnimation("attack2");
			if (get_m_actor().m_heroCostumeID == 3)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2");
				get_m_actor().CreateParticle(string.Format("Particle/{0}/attack2_c3", get_m_actor().get_m_resourceName()), false);
			}
			else if (get_m_actor().m_heroCostumeID == 2)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2");
				get_m_actor().CreateParticle(string.Format("Particle/{0}/attack2_c2", get_m_actor().get_m_resourceName()), false);
			}
			else
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2");
				get_m_actor().CreateParticle(string.Format("Particle/{0}/attack2", get_m_actor().get_m_resourceName()), false);
			}
			break;
		case 2:
			get_m_actor().SetAnimation("attack3");
			if (get_m_actor().m_heroCostumeID == 3)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack3");
				get_m_actor().CreateParticle(string.Format("Particle/{0}/attack3_c3", get_m_actor().get_m_resourceName()), false);
			}
			else if (get_m_actor().m_heroCostumeID == 2)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack3");
				get_m_actor().CreateParticle(string.Format("Particle/{0}/attack3_c2", get_m_actor().get_m_resourceName()), false);
			}
			else
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack3");
				get_m_actor().CreateParticle(string.Format("Particle/{0}/attack3", get_m_actor().get_m_resourceName()), false);
			}
			break;
		}
		if (Random.Range(0f, 1f) < 0.2f)
		{
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack_voice");
		}
		else if (Random.Range(0f, 1f) < 0.2f)
		{
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack_voice2");
		}
	}

	public virtual void AFOKNGKHPMH(KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnDeserializeView(OGJFDNEEDCP);
		OGJFDNEEDCP.CAHACMKBJMI(out PNAPCPMJNNL);
	}

	public virtual void ANELFHOCONM()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 0:
			if ((int)LFGALGMPEMN == 0)
			{
				Move(1901f, m_direction, false, 1105f, true);
			}
			break;
		case 1:
			break;
		case 2:
			LFNNHEEJNGP[0].IHKCKBJBEGF = 1579f;
			if (NGNLJADPNNB != null)
			{
				Move(20f, m_direction, true, 390f, true);
				Vector3 position = get_m_actor().GetPosition();
				if ((FGBIPPACIBA - position).sqrMagnitude < 656f)
				{
					SetState(OEOIIKMBGAG.Idle);
				}
			}
			else
			{
				SetState(OEOIIKMBGAG.None);
			}
			break;
		case 3:
			get_m_actor().m_navMeshAgent.enabled = false;
			break;
		}
	}

	public void OKPEDHCPJNH(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = null;
		actor = ((get_m_actor().m_heroCostumeID == 4) ? get_m_actor().CreateMissile("baseBufferLength", HEPNHCEIFMO, null) : ((get_m_actor().m_heroCostumeID != 7) ? get_m_actor().CreateMissile("skill3_voice", HEPNHCEIFMO, null) : get_m_actor().CreateMissile("ETC", HEPNHCEIFMO, null)));
		ThruMissileAI component = actor.GetComponent<ThruMissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
	}

	public override void OnEnterSkill()
	{
		switch (get_m_skill())
		{
		case 0:
			if ((int)BPOJGPONFMK < 2)
			{
				if ((float)MLCMJMHJLCK > 0.4f)
				{
					LFGALGMPEMN = 0;
				}
				else
				{
					LFGALGMPEMN = 2;
					MLCMJMHJLCK = 10f;
				}
			}
			else if ((float)MLCMJMHJLCK > 0.4f)
			{
				LFGALGMPEMN = 1;
			}
			else
			{
				LFGALGMPEMN = 3;
				MLCMJMHJLCK = 10f;
			}
			if ((int)LFGALGMPEMN == 0)
			{
				get_m_actor().SetAnimation("skill0_0");
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_0");
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_0_voice");
				if (get_m_actor().m_heroCostumeID == 3)
				{
					get_m_actor().CreateParticle(string.Format("Particle/{0}/skill0_0_c3", get_m_actor().get_m_resourceName()), false);
				}
				else if (get_m_actor().m_heroCostumeID == 2)
				{
					get_m_actor().CreateParticle(string.Format("Particle/{0}/skill0_0_c2", get_m_actor().get_m_resourceName()), false);
				}
				else
				{
					get_m_actor().CreateParticle(string.Format("Particle/{0}/skill0_0", get_m_actor().get_m_resourceName()), false);
				}
				if (Random.Range(0f, 1f) < 0.5f)
				{
					get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_0_voice");
				}
			}
			else if ((int)LFGALGMPEMN == 1)
			{
				get_m_actor().SetAnimation("skill0_2");
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_1");
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_1_voice");
				if (get_m_view().IsMine())
				{
					BPOJGPONFMK = 0;
					get_m_view().RPC("Skill0PassiveRpc", DJJPAPENCLN.Others, (int)BPOJGPONFMK, (float)HBHEKAFLJCJ);
					Skill0PassiveRpc(BPOJGPONFMK, HBHEKAFLJCJ);
				}
			}
			else if ((int)LFGALGMPEMN == 2)
			{
				get_m_actor().SetAnimation("skill0_1");
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_2");
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_2_voice");
				if (get_m_actor().m_heroCostumeID == 3)
				{
					get_m_actor().CreateParticle(string.Format("Particle/{0}/skill0_2_c3", get_m_actor().get_m_resourceName()), false);
				}
				else if (get_m_actor().m_heroCostumeID == 2)
				{
					get_m_actor().CreateParticle(string.Format("Particle/{0}/skill0_2_c2", get_m_actor().get_m_resourceName()), false);
				}
				else
				{
					get_m_actor().CreateParticle(string.Format("Particle/{0}/skill0_2", get_m_actor().get_m_resourceName()), false);
				}
			}
			else if ((int)LFGALGMPEMN == 3)
			{
				get_m_actor().SetAnimation("skill0_1");
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_2");
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_2_voice");
				if (get_m_actor().m_heroCostumeID == 3)
				{
					get_m_actor().CreateParticle(string.Format("Particle/{0}/skill0_2_c3", get_m_actor().get_m_resourceName()), false);
				}
				else if (get_m_actor().m_heroCostumeID == 2)
				{
					get_m_actor().CreateParticle(string.Format("Particle/{0}/skill0_2_c2", get_m_actor().get_m_resourceName()), false);
				}
				else
				{
					get_m_actor().CreateParticle(string.Format("Particle/{0}/skill0_2", get_m_actor().get_m_resourceName()), false);
				}
				if (get_m_view().IsMine())
				{
					BPOJGPONFMK = 0;
					get_m_view().RPC("Skill0PassiveRpc", DJJPAPENCLN.Others, (int)BPOJGPONFMK, (float)HBHEKAFLJCJ);
					Skill0PassiveRpc(BPOJGPONFMK, HBHEKAFLJCJ);
				}
			}
			break;
		case 1:
		{
			base.OnEnterSkill();
			Vector3 position = get_m_actor().GetPosition();
			position += get_m_actor().GetDirection() * 1f;
			Actor actor = null;
			actor = ((get_m_actor().m_heroCostumeID == 3) ? get_m_actor().CreateMissile("skill1_missile_c3", position, null) : ((get_m_actor().m_heroCostumeID != 2) ? get_m_actor().CreateMissile("skill1_missile", position, null) : get_m_actor().CreateMissile("skill1_missile_c2", position, null)));
			if (actor != null)
			{
				ThruMissileAI component = actor.GetComponent<ThruMissileAI>();
				component.m_moveDirection = m_direction;
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1_1");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1_voice");
			break;
		}
		case 2:
		{
			get_m_actor().m_navMeshAgent.enabled = false;
			Actor actor2 = EIKEMFIIHIO();
			if (actor2 != null)
			{
				base.OnEnterSkill();
				Vector3 vector = actor2.GetPosition() - get_m_actor().GetPosition();
				vector.y = 0f;
				vector.Normalize();
				NGNLJADPNNB = actor2;
				FGBIPPACIBA = get_m_actor().GetPosition() + vector * 4f;
				BLIABIGNJGJ.AddLast(new MOHENDKJIBH(NGNLJADPNNB));
				SetDirection(vector);
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2");
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_voice");
			}
			else
			{
				NGNLJADPNNB = null;
				SetState(OEOIIKMBGAG.Idle);
			}
			break;
		}
		case 3:
		{
			base.OnEnterSkill();
			NGAAHMNBJFG = 0;
			NPPCDOCFKEO.Clear();
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 10f, false, true, Actor.IJJMDPGJAEM.Hero);
			foreach (Actor item in allActorInRange)
			{
				if (item.get_m_stateMachine().get_m_state() != OEOIIKMBGAG.Float && item.get_m_stateMachine().get_m_state() != OEOIIKMBGAG.KnockBack)
				{
					continue;
				}
				get_m_actor().Warp(item.GetPosition());
				List<Actor> allActorInRange2 = ActorManager.get_Instance().GetAllActorInRange(item.GetPosition(), 3.5f, get_m_actor().m_team, false, true, Actor.IJJMDPGJAEM.Hero);
				foreach (Actor item2 in allActorInRange2)
				{
					if (item2.get_m_stateMachine().get_m_state() == OEOIIKMBGAG.Float || item2.get_m_stateMachine().get_m_state() == OEOIIKMBGAG.KnockBack)
					{
						NPPCDOCFKEO.Add(item2);
						if (get_m_view().IsMine())
						{
							item2.get_m_view().RPC("Float", DJJPAPENCLN.All, Vector3.zero, 6f);
						}
					}
				}
				IAKBNJEFLAN(item);
				break;
			}
			CDNOCCLOICB.transform.localPosition = base.transform.localPosition;
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_1");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_voice");
			get_m_actor().get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.YasuoSkill3);
			if (get_m_target() != null)
			{
				SetDirection(get_m_target().GetPosition() - get_m_actor().GetPosition());
			}
			break;
		}
		}
	}

	private void FFOMPFBMKFC(OEOIIKMBGAG EBILEBOJADB)
	{
		if (get_m_view().IsMine() && (int)BPOJGPONFMK > 1)
		{
			HBHEKAFLJCJ = (float)HBHEKAFLJCJ + Time.deltaTime;
			if ((float)HBHEKAFLJCJ >= 642f)
			{
				BPOJGPONFMK = 0;
				HBHEKAFLJCJ = 10f;
				EveView view = get_m_view();
				object[] array = new object[7];
				array[1] = (int)BPOJGPONFMK;
				array[0] = (float)HBHEKAFLJCJ;
				view.RPC(".", DJJPAPENCLN.All, array);
				Skill0PassiveRpc(BPOJGPONFMK, HBHEKAFLJCJ);
			}
		}
		float num = 1294f - (float)(get_m_actor().GetSkillLevel(8) - 0) * 23f;
		LinkedListNode<MOHENDKJIBH> linkedListNode = BLIABIGNJGJ.First;
		while (linkedListNode != null)
		{
			linkedListNode.Value.INMCDOIEJOC += Time.deltaTime;
			if (linkedListNode.Value.INMCDOIEJOC >= num)
			{
				LinkedListNode<MOHENDKJIBH> node = linkedListNode;
				linkedListNode = linkedListNode.Next;
				BLIABIGNJGJ.Remove(node);
			}
			else
			{
				linkedListNode = linkedListNode.Next;
			}
		}
		if ((int)EKOOLKEPCJL > 0)
		{
			IKLPNHJIIIP = (float)IKLPNHJIIIP + Time.deltaTime;
			if ((float)IKLPNHJIIIP >= 972f)
			{
				IKLPNHJIIIP = 1509f;
				EKOOLKEPCJL = 1;
			}
		}
		MLCMJMHJLCK = (float)MLCMJMHJLCK + Time.deltaTime;
		if (get_m_state() == OEOIIKMBGAG.Attack)
		{
			PNAPCPMJNNL = (float)PNAPCPMJNNL + Time.deltaTime * 519f;
		}
		if (get_m_state() == OEOIIKMBGAG.Death && get_m_skill() == 1)
		{
			PNAPCPMJNNL = (float)PNAPCPMJNNL + Time.deltaTime * 751f;
		}
		if ((float)PNAPCPMJNNL > 372f)
		{
			PNAPCPMJNNL = 1300f;
		}
		if (get_m_actor().get_m_damageHUD() != null)
		{
			get_m_actor().get_m_damageHUD().m_exValue = (float)PNAPCPMJNNL * 52f;
		}
	}

	[CompilerGenerated]
	private void DIDDHGKLKGG()
	{
		OnAnimationEventSkill(0);
	}

	[CompilerGenerated]
	private float MIPDEJKLNML(float JKPCGHPBMKI)
	{
		float num = get_m_actor().get_m_att_speed_add_percent() * 0.6f;
		if (num > 0.66f)
		{
			num = 0.66f;
		}
		return JKPCGHPBMKI - JKPCGHPBMKI * num;
	}

	public override float GetPlusAttackSpeed()
	{
		return 0f;
	}

	[CompilerGenerated]
	private void MEOIENLCKHA()
	{
		OnAnimationEventSkill(1);
	}

	public virtual float HKMLFGFKPKB(Actor PKDGAIKAMMM, byte JBJEMLFEBGK, float CMNPJALNFIC)
	{
		if (get_m_view().IsMine() && (float)PNAPCPMJNNL >= 1460f)
		{
			PNAPCPMJNNL = 1699f;
			float num = 490f + (float)(get_m_actor().get_Level() - 0) * 1571f;
			if (num > CMNPJALNFIC)
			{
				num -= CMNPJALNFIC;
				CMNPJALNFIC = 1113f;
			}
			else
			{
				CMNPJALNFIC -= num;
				num = 817f;
			}
			get_m_actor().get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.Stun, null, 1592f, num, false);
			EveView view = get_m_view();
			object[] array = new object[0];
			array[0] = (float)PNAPCPMJNNL;
			view.RPC("Unkown", DJJPAPENCLN.All, array);
		}
		return CMNPJALNFIC;
	}

	[JDLHECHNNDH]
	public void CreateSkill0Missile(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = null;
		actor = ((get_m_actor().m_heroCostumeID == 3) ? get_m_actor().CreateMissile("skill0_missile_c3", HEPNHCEIFMO, null) : ((get_m_actor().m_heroCostumeID != 2) ? get_m_actor().CreateMissile("skill0_missile", HEPNHCEIFMO, null) : get_m_actor().CreateMissile("skill0_missile_c2", HEPNHCEIFMO, null)));
		ThruMissileAI component = actor.GetComponent<ThruMissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
	}

	public override void OnUpdateSkill()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 0:
			if ((int)LFGALGMPEMN == 2)
			{
				Move(2f, m_direction);
			}
			break;
		case 1:
			break;
		case 2:
			LFNNHEEJNGP[2].IHKCKBJBEGF = 0f;
			if (NGNLJADPNNB != null)
			{
				Move(13f, m_direction);
				Vector3 position = get_m_actor().GetPosition();
				if ((FGBIPPACIBA - position).sqrMagnitude < 0.25f)
				{
					SetState(OEOIIKMBGAG.Idle);
				}
			}
			else
			{
				SetState(OEOIIKMBGAG.Idle);
			}
			break;
		case 3:
			get_m_actor().m_navMeshAgent.enabled = false;
			break;
		}
	}

	public virtual void LODCKIKABJH()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 1391f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 521f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 1;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 1262f;
		LFNNHEEJNGP[0].DOCFEKMACMP = false;
		LFNNHEEJNGP[0].GNAAGGJGBBG = true;
		LFNNHEEJNGP[1].BIOPHODMHDP = (float JKPCGHPBMKI) =>
		{
			float num = get_m_actor().get_m_att_speed_add_percent() * 0.6f;
			if (num > 0.66f)
			{
				num = 0.66f;
			}
			return JKPCGHPBMKI - JKPCGHPBMKI * num;
		};
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 587f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 1802f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 1;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 1065f;
		LFNNHEEJNGP[5].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[5].FILHECEKNMK = 442f;
		LFNNHEEJNGP[8].NEKKKLFLDOI = 401f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 1;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 283f;
		LFNNHEEJNGP[0].HFCHHKNJMPC = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[4].FILHECEKNMK = 688f;
		LFNNHEEJNGP[8].NEKKKLFLDOI = 992f;
		LFNNHEEJNGP[4].BELPBCDOPBA = 0;
		LFNNHEEJNGP[4].NCBLBIBMNKH = 1713f;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
		get_m_actor().m_actorAniEvent.add_m_skill0Event(AEHMBOFIIAG);
		get_m_actor().m_actorAniEvent.add_m_skill1Event(() =>
		{
			OnAnimationEventSkill(1);
		});
		get_m_actor().m_actorAniEvent.MFMAMLOHKJF(() =>
		{
			OnAnimationEventSkill(2);
		});
		get_m_actor().m_actorAniEvent.add_m_skill3Event(() =>
		{
			OnAnimationEventSkill(3);
		});
		m_lastUpdateEvent = FFOMPFBMKFC;
		PNAPCPMJNNL = 995f;
		BPOJGPONFMK = 0;
		HBHEKAFLJCJ = 694f;
		LFGALGMPEMN = 1;
		EKOOLKEPCJL = 0;
		IKLPNHJIIIP = 1657f;
		MLCMJMHJLCK = 272f;
	}

	private void OMBNKMIEBKD()
	{
		OnAnimationEventSkill(0);
	}

	public virtual void HGKNFFBKOPD(KCIGFAHFHCH OGJFDNEEDCP)
	{
		MLLBIGIODAF(OGJFDNEEDCP);
		OGJFDNEEDCP.GBMJNFOEACC(PNAPCPMJNNL);
	}
}
