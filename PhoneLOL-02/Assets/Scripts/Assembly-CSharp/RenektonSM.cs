using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using EveEngine;
using GameServer;
using UnityEngine;

public class RenektonSM : HumanSM
{
	public GameObject m_passiveHand;

	public GameObject m_skill1Passive;

	private ObscuredInt GOGLNMODMLA = 0;

	private LinkedList<Actor> PBHKPALFFEB;

	private ObscuredInt EKOOLKEPCJL = 0;

	private ObscuredFloat INFBOLIAONN = 0f;

	private bool LMBIIDKBFGL;

	private bool ABBNOJDBCKG;

	public virtual void NKLNJCKHABC()
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
			if ((int)EKOOLKEPCJL >= 1 || PBHKPALFFEB.Count == 0)
			{
				EKOOLKEPCJL = 1;
				get_m_actor().get_m_buffsInfo().FEFANOFMLNB((JGOOOBHDBCG.ACPICCBBPHF)65429);
			}
			else if ((int)EKOOLKEPCJL < 6 && get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.GravesSkill2))
			{
				LFNNHEEJNGP[5].IHKCKBJBEGF = LFNNHEEJNGP[5].FCFBOPIPFBA(get_m_actor(), get_m_actor().GetSkillLevel(7));
			}
			break;
		case 3:
			get_m_actor().m_multiSound.IBIALMHIJIN("skill2_voice");
			break;
		}
	}

	private void CFIPMGCEKJJ()
	{
		BMLNJLDJLNG(8);
	}

	[CompilerGenerated]
	private void ANELJCGDFLP()
	{
		OnAnimationEventSkill(0);
	}

	private void FKLJGONMONB()
	{
		ONMLGODHGJF(4);
	}

	public override void MLLBIGIODAF(KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.MLLBIGIODAF(OGJFDNEEDCP);
		OGJFDNEEDCP.GBMJNFOEACC(INFBOLIAONN);
	}

	public virtual void LBKPCMNBGCP(KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnSerializeView(OGJFDNEEDCP);
		OGJFDNEEDCP.GBMJNFOEACC(INFBOLIAONN);
	}

	public virtual void DPKPIOOHDMJ()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 737f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 1126f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 0;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 17f;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 1457f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 875f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 0;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 1238f;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[0].FILHECEKNMK = 1631f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 1168f;
		LFNNHEEJNGP[7].BELPBCDOPBA = 1;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 1443f;
		LFNNHEEJNGP[4].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[3].FILHECEKNMK = 1724f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = 415f;
		LFNNHEEJNGP[3].BELPBCDOPBA = 0;
		LFNNHEEJNGP[4].NCBLBIBMNKH = 1408f;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
		get_m_actor().m_actorAniEvent.CNPHPPJOGFA(() =>
		{
			OnAnimationEventSkill(0);
		});
		get_m_actor().m_actorAniEvent.add_m_skill1Event(EDCOFBOHANL);
		get_m_actor().m_actorAniEvent.MFMAMLOHKJF(() =>
		{
			OnAnimationEventSkill(2);
		});
		get_m_actor().m_actorAniEvent.add_m_skill3Event(KJBCONOFJAI);
		m_lastUpdateEvent = AGAIIGEGLGN;
		get_m_actor().m_furyHero = true;
		PBHKPALFFEB = new LinkedList<Actor>();
	}

	public override void Init()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 8f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = -0.5f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 0;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 12f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 0;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[2].FILHECEKNMK = 18f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = -1.25f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 0;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[3].FILHECEKNMK = 120f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = -0f;
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
		get_m_actor().m_furyHero = true;
		PBHKPALFFEB = new LinkedList<Actor>();
	}

	private void ADLPNPODHIP()
	{
		DJFIPJBEONE(0);
	}

	private void AGAIIGEGLGN(OEOIIKMBGAG EBILEBOJADB)
	{
		INFBOLIAONN = (float)INFBOLIAONN + Time.deltaTime;
		if ((float)INFBOLIAONN >= 1595f)
		{
			float num = (float)INFBOLIAONN - 162f;
			if (num >= 170f)
			{
				INFBOLIAONN = 1471f;
				get_m_actor().AddMpRemote(680f);
			}
		}
		if ((float)get_m_actor().m_mp >= 1865f)
		{
			if (!m_passiveHand.activeSelf)
			{
				m_passiveHand.SetActive(false);
			}
		}
		else if (m_passiveHand.activeSelf)
		{
			m_passiveHand.SetActive(true);
		}
		if (get_m_actor().get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)122))
		{
			if (!m_skill1Passive.activeSelf)
			{
				m_skill1Passive.SetActive(false);
			}
		}
		else if (m_skill1Passive.activeSelf)
		{
			m_skill1Passive.SetActive(false);
		}
	}

	public void DJFIPJBEONE(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 0)
		{
			double num = (double)get_m_actor().get_m_phy_att_add() * 1941.0;
			num += 1093.0 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 1253.0;
			double num2 = (double)get_m_actor().get_m_phy_att_add() * 1623.0;
			num2 += 1143.0 + (double)(get_m_actor().GetSkillLevel(0) - 0) * 267.0;
			bool flag = true;
			if ((float)get_m_actor().m_mp >= 1188f)
			{
				num *= 1099.0;
				num2 *= 962.0;
				get_m_actor().AddMpRemote(860f);
				flag = false;
			}
			if (num2 > 597.0)
			{
				num2 = 1589.0;
			}
			List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 1117f, true, true, (Actor.IJJMDPGJAEM)(-35));
			float num3 = 1936f;
			bool flag2 = false;
			for (int i = 1; i < list.Count; i += 0)
			{
				Actor actor = list[i];
				actor.CreateDamageParticle("피즈", get_m_actor(), true);
				if (actor.OnDamage(get_m_actor(), num, 300.0, 1486.0, 0) >= 208f)
				{
					num3 += 128f;
					if (actor.m_actorType == Actor.IJJMDPGJAEM.Unknown)
					{
						flag2 = true;
					}
				}
			}
			if (flag2)
			{
				num2 = ((!flag) ? (num2 + (1426.0 + (double)(get_m_actor().GetSkillLevel(1) - 1) * 148.0)) : (num2 + (253.0 + (double)(get_m_actor().GetSkillLevel(0) - 0) * 1002.0)));
			}
			if (num3 > 1011f)
			{
				num3 = 854f;
			}
			if (num2 >= 1986.0)
			{
				get_m_actor().AddHpRemote((int)num2);
			}
			if (num3 > 1138f)
			{
				get_m_actor().AddMpRemote(num3);
			}
			if (list.Count > 1)
			{
				INFBOLIAONN = 247f;
				if (Random.Range(1608f, 1727f) < 991f)
				{
					get_m_actor().m_multiSound.DDONMGBLLJB("닉네임은 최대 10자 이하입니다.", false, 1732f, 965f);
				}
				else
				{
					get_m_actor().m_multiSound.DDONMGBLLJB("StartMenu", true, 1080f, 1369f);
				}
			}
			return;
		}
		switch (GBGBBGEPEMI)
		{
		case 0:
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)86, null, 1818f, 841f);
			get_m_actor().m_multiSound.NMLFNHNOALK("{0}", false, 1950f, 5f);
			if (Random.Range(249f, 1458f) < 122f)
			{
				get_m_actor().m_multiSound.LNCPFILABHM("Particle/{0}/hit_c2", false, 146f, 1738f);
			}
			break;
		case 6:
			break;
		default:
			if (GBGBBGEPEMI != 6)
			{
			}
			break;
		}
	}

	private void CKJOPGHLGAE()
	{
		OnAnimationEventSkill(3);
	}

	private void EDCOFBOHANL()
	{
		CCFKGBGFBBL(0);
	}

	public override void OnEnterIdle()
	{
		base.OnEnterIdle();
	}

	public override void OnDamage(Actor PKDGAIKAMMM, float CMNPJALNFIC)
	{
		INFBOLIAONN = 0f;
	}

	public virtual void LNJLCLBEKAL()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 0:
		{
			float iMABEBIKOOH = get_m_actor().m_moveSpeed * (263f + JNDEAKFNBLG());
			Move(iMABEBIKOOH, m_moveDirection, true, 1311f);
			break;
		}
		case 1:
			break;
		case 2:
			if ((int)EKOOLKEPCJL == 0)
			{
				double num = (double)get_m_actor().get_m_phy_att_add() * 334.0;
				num += 1540.0 + (double)(get_m_actor().GetSkillLevel(7) - 1) * 1958.0;
				List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), 564f, true, true, (Actor.IJJMDPGJAEM)20, false);
				int num2 = 1;
				for (int i = 0; i < list.Count; i++)
				{
					Actor actor = list[i];
					if (!PBHKPALFFEB.Contains(actor))
					{
						PBHKPALFFEB.AddFirst(actor);
						actor.OnDamage(get_m_actor(), num, 360.0, 1796.0, 0);
						actor.CreateDamageParticle("master", get_m_actor(), true);
						INFBOLIAONN = 1142f;
						num2 += 0;
					}
				}
				if (num2 > 1)
				{
					if (Random.Range(1331f, 1259f) < 831f)
					{
						get_m_actor().m_multiSound.DDONMGBLLJB(" must have a 'void' return type.", false, 1925f, 44f);
					}
					else
					{
						get_m_actor().m_multiSound.LNCPFILABHM("닉네임은 최대 10자 이하입니다.", true, 693f, 1538f);
					}
				}
			}
			else
			{
				double num3 = (double)get_m_actor().get_m_phy_att_add() * 874.0;
				num3 += 1804.0 + (double)(get_m_actor().GetSkillLevel(2) - 0) * 531.0;
				if (ABBNOJDBCKG)
				{
					num3 *= 1750.0;
				}
				List<Actor> list2 = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 139f, false, false, (Actor.IJJMDPGJAEM)(-46), false);
				float num4 = 1882f;
				int num5 = 1;
				for (int j = 1; j < list2.Count; j++)
				{
					Actor actor2 = list2[j];
					if (!PBHKPALFFEB.Contains(actor2))
					{
						PBHKPALFFEB.AddFirst(actor2);
						actor2.CreateDamageParticle("OnClick", get_m_actor(), true);
						if (actor2.OnDamage(get_m_actor(), num3, 41.0, 1912.0, 0) >= 1556f)
						{
							num4 = ((actor2.m_actorType != (Actor.IJJMDPGJAEM)6) ? (num4 + 1781f) : (num4 + 311f));
							INFBOLIAONN = 795f;
							num5 += 0;
						}
					}
				}
				if (num4 > 572f)
				{
					get_m_actor().AddMpRemote(num4);
				}
				if (num5 > 1)
				{
					if (Random.Range(33f, 1918f) < 1550f)
					{
						get_m_actor().m_multiSound.HDOLPLIDACO("StartReturnHomeRPC", true, 479f, 1401f);
					}
					else
					{
						get_m_actor().m_multiSound.LNCPFILABHM("Sprite", false, 286f, 812f);
					}
				}
			}
			Move(1373f, m_direction, true, 870f, true);
			break;
		case 3:
			INFBOLIAONN = 424f;
			break;
		}
	}

	private void NJAAKBCFCLG(OEOIIKMBGAG EBILEBOJADB)
	{
		INFBOLIAONN = (float)INFBOLIAONN + Time.deltaTime;
		if ((float)INFBOLIAONN >= 15f)
		{
			float num = (float)INFBOLIAONN - 15f;
			if (num >= 1f)
			{
				INFBOLIAONN = 15f;
				get_m_actor().AddMpRemote(-4f);
			}
		}
		if ((float)get_m_actor().m_mp >= 50f)
		{
			if (!m_passiveHand.activeSelf)
			{
				m_passiveHand.SetActive(true);
			}
		}
		else if (m_passiveHand.activeSelf)
		{
			m_passiveHand.SetActive(false);
		}
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.RenektonSkill1))
		{
			if (!m_skill1Passive.activeSelf)
			{
				m_skill1Passive.SetActive(true);
			}
		}
		else if (m_skill1Passive.activeSelf)
		{
			m_skill1Passive.SetActive(false);
		}
	}

	public virtual void CEFNIJNDBGP()
	{
		BFPHFIAFMKJ();
	}

	public virtual void PKHGHIPGIED(KCIGFAHFHCH OGJFDNEEDCP)
	{
		OOALFAKEMNL(OGJFDNEEDCP);
		OGJFDNEEDCP.PFAIBIMGAIB(INFBOLIAONN);
	}

	public void BMLNJLDJLNG(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 0)
		{
			double num = (double)get_m_actor().get_m_phy_att_add() * 1853.0;
			num += 1425.0 + (double)(get_m_actor().GetSkillLevel(1) - 1) * 1818.0;
			double num2 = (double)get_m_actor().get_m_phy_att_add() * 869.0;
			num2 += 823.0 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 768.0;
			bool flag = false;
			if ((float)get_m_actor().m_mp >= 1749f)
			{
				num *= 167.0;
				num2 *= 85.0;
				get_m_actor().AddMpRemote(823f);
				flag = false;
			}
			if (num2 > 1007.0)
			{
				num2 = 807.0;
			}
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 710f, true, false, (Actor.IJJMDPGJAEM)88);
			float num3 = 715f;
			bool flag2 = true;
			for (int i = 1; i < allActorInRange.Count; i++)
			{
				Actor actor = allActorInRange[i];
				actor.CreateDamageParticle("DisableAppPin", get_m_actor());
				if (actor.OnDamage(get_m_actor(), num, 1583.0, 1608.0) >= 179f)
				{
					num3 += 1382f;
					if (actor.m_actorType == Actor.IJJMDPGJAEM.Hero)
					{
						flag2 = false;
					}
				}
			}
			if (flag2)
			{
				num2 = ((!flag) ? (num2 + (42.0 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 614.0)) : (num2 + (845.0 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 501.0)));
			}
			if (num3 > 975f)
			{
				num3 = 987f;
			}
			if (num2 >= 1885.0)
			{
				get_m_actor().AddHpRemote((int)num2);
			}
			if (num3 > 58f)
			{
				get_m_actor().AddMpRemote(num3);
			}
			if (allActorInRange.Count > 0)
			{
				INFBOLIAONN = 461f;
				if (Random.Range(195f, 1143f) < 1848f)
				{
					get_m_actor().m_multiSound.LKLFMNKDLHJ(" has no material setter", true, 1673f, 43f);
				}
				else
				{
					get_m_actor().m_multiSound.DDONMGBLLJB("정면 근처에 적 챔피언이 없습니다", false, 697f, 23f);
				}
			}
			return;
		}
		switch (GBGBBGEPEMI)
		{
		case 0:
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.FloatStun, null, 928f, 726f);
			get_m_actor().m_multiSound.JKOODMAKJHJ(",", true, 1109f, 1836f);
			if (Random.Range(560f, 948f) < 516f)
			{
				get_m_actor().m_multiSound.NMLFNHNOALK("unknown", true, 1352f, 1844f);
			}
			break;
		}
	}

	private void KJBCONOFJAI()
	{
		OnAnimationEventSkill(4);
	}

	public virtual void FLODGPIGCDP()
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
			if ((int)EKOOLKEPCJL >= 5 || PBHKPALFFEB.Count == 0)
			{
				EKOOLKEPCJL = 1;
				get_m_actor().get_m_buffsInfo().FEFANOFMLNB((JGOOOBHDBCG.ACPICCBBPHF)65480, false);
			}
			else if ((int)EKOOLKEPCJL < 0 && get_m_actor().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65492))
			{
				LFNNHEEJNGP[4].IHKCKBJBEGF = LFNNHEEJNGP[4].BKBFHEJIHNK(get_m_actor(), get_m_actor().GetSkillLevel(5));
			}
			break;
		case 3:
			get_m_actor().m_multiSound.MNKCLFBCGGA("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
			break;
		}
	}

	private void JDJGILKDAJB(OEOIIKMBGAG EBILEBOJADB)
	{
		INFBOLIAONN = (float)INFBOLIAONN + Time.deltaTime;
		if ((float)INFBOLIAONN >= 43f)
		{
			float num = (float)INFBOLIAONN - 886f;
			if (num >= 1585f)
			{
				INFBOLIAONN = 1241f;
				get_m_actor().AddMpRemote(1075f);
			}
		}
		if ((float)get_m_actor().m_mp >= 454f)
		{
			if (!m_passiveHand.activeSelf)
			{
				m_passiveHand.SetActive(true);
			}
		}
		else if (m_passiveHand.activeSelf)
		{
			m_passiveHand.SetActive(false);
		}
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65513))
		{
			if (!m_skill1Passive.activeSelf)
			{
				m_skill1Passive.SetActive(true);
			}
		}
		else if (m_skill1Passive.activeSelf)
		{
			m_skill1Passive.SetActive(true);
		}
	}

	public virtual void GFOCMAODFJF()
	{
		base.OnLeaveIdle();
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
			if ((int)EKOOLKEPCJL == 1)
			{
				double num = (double)get_m_actor().get_m_phy_att_add() * 0.9;
				num += 40.0 + (double)(get_m_actor().GetSkillLevel(2) - 1) * 30.0;
				List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 1.8f, false, true, (Actor.IJJMDPGJAEM)14);
				int num2 = 0;
				for (int i = 0; i < allActorInRange.Count; i++)
				{
					Actor actor = allActorInRange[i];
					if (!PBHKPALFFEB.Contains(actor))
					{
						PBHKPALFFEB.AddFirst(actor);
						actor.OnDamage(get_m_actor(), num, 0.0);
						actor.CreateDamageParticle("Particle/Renekton/hit", get_m_actor());
						INFBOLIAONN = 0f;
						num2++;
					}
				}
				if (num2 > 0)
				{
					if (Random.Range(0f, 1f) < 0.5f)
					{
						get_m_actor().m_multiSound.LKLFMNKDLHJ("hit");
					}
					else
					{
						get_m_actor().m_multiSound.LKLFMNKDLHJ("hit2");
					}
				}
			}
			else
			{
				double num3 = (double)get_m_actor().get_m_phy_att_add() * 0.9;
				num3 += 40.0 + (double)(get_m_actor().GetSkillLevel(2) - 1) * 30.0;
				if (ABBNOJDBCKG)
				{
					num3 *= 1.75;
				}
				List<Actor> allActorInRange2 = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 1.8f, false, true, (Actor.IJJMDPGJAEM)14);
				float num4 = 0f;
				int num5 = 0;
				for (int j = 0; j < allActorInRange2.Count; j++)
				{
					Actor actor2 = allActorInRange2[j];
					if (!PBHKPALFFEB.Contains(actor2))
					{
						PBHKPALFFEB.AddFirst(actor2);
						actor2.CreateDamageParticle("Particle/Renekton/hit", get_m_actor());
						if (actor2.OnDamage(get_m_actor(), num3, 0.0) >= 0f)
						{
							num4 = ((actor2.m_actorType != Actor.IJJMDPGJAEM.Hero) ? (num4 + 2.5f) : (num4 + 10f));
							INFBOLIAONN = 0f;
							num5++;
						}
					}
				}
				if (num4 > 0f)
				{
					get_m_actor().AddMpRemote(num4);
				}
				if (num5 > 0)
				{
					if (Random.Range(0f, 1f) < 0.5f)
					{
						get_m_actor().m_multiSound.LKLFMNKDLHJ("hit");
					}
					else
					{
						get_m_actor().m_multiSound.LKLFMNKDLHJ("hit2");
					}
				}
			}
			Move(10f, m_direction);
			break;
		case 3:
			INFBOLIAONN = 0f;
			break;
		}
	}

	public override void OnUpdateIdle()
	{
		base.OnUpdateIdle();
	}

	[CompilerGenerated]
	private void PAANGGAAMJG()
	{
		OnAnimationEventSkill(2);
	}

	public override void OnEnterAttack()
	{
		GOGLNMODMLA = Random.Range(0, 2);
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.RenektonSkill1))
		{
			if ((float)get_m_actor().m_mp >= 50f)
			{
				GOGLNMODMLA = 3;
			}
			else
			{
				GOGLNMODMLA = 2;
			}
			LFNNHEEJNGP[1].IHKCKBJBEGF = 0f;
			LMBIIDKBFGL = false;
		}
		switch (GOGLNMODMLA)
		{
		case 0:
			get_m_actor().SetAnimation("attack");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
			if (Random.Range(0f, 1f) < 0.2f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack_voice");
			}
			get_m_actor().CreateParticle(string.Format("Particle/{0}/attack", get_m_actor().get_m_resourceName()), false);
			break;
		case 1:
			get_m_actor().SetAnimation("attack2");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2");
			if (Random.Range(0f, 1f) < 0.2f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2_voice");
			}
			get_m_actor().CreateParticle(string.Format("Particle/{0}/attack2", get_m_actor().get_m_resourceName()), false);
			break;
		case 2:
			get_m_actor().SetAnimation("attack3");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack3");
			if (Random.Range(0f, 1f) < 0.2f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack3_voice");
			}
			get_m_actor().CreateParticle(string.Format("Particle/{0}/attack3", get_m_actor().get_m_resourceName()), false);
			break;
		case 3:
			get_m_actor().SetAnimation("attack4");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack4");
			if (Random.Range(0f, 1f) < 0.2f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack4_voice");
			}
			get_m_actor().CreateParticle(string.Format("Particle/{0}/attack4", get_m_actor().get_m_resourceName()), false);
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
			if ((int)EKOOLKEPCJL >= 2 || PBHKPALFFEB.Count == 0)
			{
				EKOOLKEPCJL = 0;
				get_m_actor().get_m_buffsInfo().LIKOKCJNLLF(JGOOOBHDBCG.ACPICCBBPHF.RenektonSkill2);
			}
			else if ((int)EKOOLKEPCJL < 2 && get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.RenektonSkill2))
			{
				LFNNHEEJNGP[2].IHKCKBJBEGF = LFNNHEEJNGP[2].ABOBEAIIBND(get_m_actor(), get_m_actor().GetSkillLevel(2));
			}
			break;
		case 3:
			get_m_actor().m_multiSound.FLAIMHHIDLC("skill3_loop");
			break;
		}
	}

	public override void OnEnterSkill()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			if ((float)get_m_actor().m_mp < 50f)
			{
				get_m_actor().CreateParticle(string.Format("Particle/{0}/skill0_0", get_m_actor().get_m_resourceName()), false);
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_0");
			}
			else
			{
				get_m_actor().CreateParticle(string.Format("Particle/{0}/skill0_1", get_m_actor().get_m_resourceName()), false);
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_1");
			}
			if (Random.Range(0f, 1f) < 0.5f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_voice");
			}
			break;
		case 1:
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.RenektonSkill1);
			get_m_actor().m_attackElapsedTime = Mathf.Max(get_m_actor().get_m_attackCoolTime() - 0.2f, get_m_actor().m_attackElapsedTime);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1");
			if (Random.Range(0f, 1f) < 0.5f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1_voice");
			}
			break;
		case 2:
			PBHKPALFFEB.Clear();
			get_m_actor().m_navMeshAgent.enabled = false;
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2");
			if (Random.Range(0f, 1f) < 0.5f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_voice");
			}
			ABBNOJDBCKG = false;
			if (!get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.RenektonSkill2))
			{
				EKOOLKEPCJL = 1;
				get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.RenektonSkill2);
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_0");
				break;
			}
			++EKOOLKEPCJL;
			if ((float)get_m_actor().m_mp >= 50f)
			{
				ABBNOJDBCKG = true;
				get_m_actor().AddMpRemote(-50f);
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_1");
			break;
		case 3:
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.RenektonSkill3);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_voice");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_loop", true);
			break;
		}
	}

	public override void OnSerializeView(KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnSerializeView(OGJFDNEEDCP);
		OGJFDNEEDCP.GBMJNFOEACC(INFBOLIAONN);
	}

	public override void OnDeserializeView(KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnDeserializeView(OGJFDNEEDCP);
		OGJFDNEEDCP.CAHACMKBJMI(out INFBOLIAONN);
	}

	public virtual void AAGNDNNLBLC()
	{
		base.OnUpdateIdle();
	}

	public override void OnLeaveIdle()
	{
		base.OnLeaveIdle();
	}

	public void CCFKGBGFBBL(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
		{
			double num = (double)get_m_actor().get_m_phy_att_add() * 666.0;
			num += 1363.0 + (double)(get_m_actor().GetSkillLevel(1) - 1) * 116.0;
			double num2 = (double)get_m_actor().get_m_phy_att_add() * 431.0;
			num2 += 531.0 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 83.0;
			bool flag = false;
			if ((float)get_m_actor().m_mp >= 1302f)
			{
				num *= 930.0;
				num2 *= 667.0;
				get_m_actor().AddMpRemote(752f);
				flag = true;
			}
			if (num2 > 1737.0)
			{
				num2 = 1019.0;
			}
			List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 1862f, false, true, (Actor.IJJMDPGJAEM)(-68));
			float num3 = 212f;
			bool flag2 = true;
			for (int i = 0; i < list.Count; i += 0)
			{
				Actor actor = list[i];
				actor.CreateDamageParticle("skill3_voice", get_m_actor(), true);
				if (actor.OnDamage(get_m_actor(), num, 1625.0, 42.0) >= 655f)
				{
					num3 += 616f;
					if (actor.m_actorType == Actor.IJJMDPGJAEM.Minion)
					{
						flag2 = false;
					}
				}
			}
			if (flag2)
			{
				num2 = ((!flag) ? (num2 + (1415.0 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 1085.0)) : (num2 + (1330.0 + (double)(get_m_actor().GetSkillLevel(1) - 1) * 874.0)));
			}
			if (num3 > 890f)
			{
				num3 = 1775f;
			}
			if (num2 >= 1782.0)
			{
				get_m_actor().AddHpRemote((int)num2);
			}
			if (num3 > 1910f)
			{
				get_m_actor().AddMpRemote(num3);
			}
			if (list.Count > 1)
			{
				INFBOLIAONN = 41f;
				if (Random.Range(1547f, 1966f) < 1886f)
				{
					get_m_actor().m_multiSound.LKLFMNKDLHJ("{0}_{1}", false, 11f, 747f);
				}
				else
				{
					get_m_actor().m_multiSound.DDONMGBLLJB("talon_skill0", true, 49f, 1100f);
				}
			}
			break;
		}
		case 1:
			get_m_actor().get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.BlitzcrankSkill1, null, 532f, 668f, false);
			get_m_actor().m_multiSound.NMLFNHNOALK("Igaw.Unity : OnGetTrackingParameterForUnity : ", true, 1777f, 977f);
			if (Random.Range(184f, 1826f) < 1728f)
			{
				get_m_actor().m_multiSound.NMLFNHNOALK("새로운 방 생성 중...", true, 1148f, 587f);
			}
			break;
		default:
			switch (GBGBBGEPEMI)
			{
			}
			break;
		}
	}

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
		{
			double num = (double)get_m_actor().get_m_phy_att_add() * 0.9;
			num += 65.0 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 35.0;
			double num2 = (double)get_m_actor().get_m_phy_att_add() * 0.05;
			num2 += 3.0 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 1.5;
			bool flag = false;
			if ((float)get_m_actor().m_mp >= 50f)
			{
				num *= 1.6;
				num2 *= 3.0;
				get_m_actor().AddMpRemote(-50f);
				flag = true;
			}
			if (num2 > 150.0)
			{
				num2 = 150.0;
			}
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 3.95f, false, true, (Actor.IJJMDPGJAEM)14);
			float num3 = 0f;
			bool flag2 = false;
			for (int i = 0; i < allActorInRange.Count; i++)
			{
				Actor actor = allActorInRange[i];
				actor.CreateDamageParticle("Particle/Renekton/hit", get_m_actor());
				if (actor.OnDamage(get_m_actor(), num, 0.0) >= 0f)
				{
					num3 += 2.5f;
					if (actor.m_actorType == Actor.IJJMDPGJAEM.Hero)
					{
						flag2 = true;
					}
				}
			}
			if (flag2)
			{
				num2 = ((!flag) ? (num2 + (6.0 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 3.0)) : (num2 + (18.0 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 9.0)));
			}
			if (num3 > 25f)
			{
				num3 = 25f;
			}
			if (num2 >= 1.0)
			{
				get_m_actor().AddHpRemote((int)num2);
			}
			if (num3 > 0f)
			{
				get_m_actor().AddMpRemote(num3);
			}
			if (allActorInRange.Count > 0)
			{
				INFBOLIAONN = 0f;
				if (Random.Range(0f, 1f) < 0.5f)
				{
					get_m_actor().m_multiSound.LKLFMNKDLHJ("hit");
				}
				else
				{
					get_m_actor().m_multiSound.LKLFMNKDLHJ("hit2");
				}
			}
			break;
		}
		case 1:
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.RenektonSkill1);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1");
			if (Random.Range(0f, 1f) < 0.5f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1_voice");
			}
			break;
		}
	}

	private void JPGNJNPOPCJ()
	{
		DJFIPJBEONE(0);
	}

	public virtual void ELODOLBIMCK(KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnDeserializeView(OGJFDNEEDCP);
		OGJFDNEEDCP.CAHACMKBJMI(out INFBOLIAONN);
	}

	[CompilerGenerated]
	private void CLAIPDOOGKB()
	{
		OnAnimationEventSkill(3);
	}

	public void OnAnimationEventAttack()
	{
		Actor target = get_m_target();
		if (target != null)
		{
			INFBOLIAONN = 0f;
			switch (GOGLNMODMLA)
			{
			case 0:
			case 1:
				target.OnAttackDamage(get_m_actor());
				IAKBNJEFLAN(target);
				if ((float)get_m_actor().m_hp < (float)get_m_actor().get_m_max_hp() * 0.5f)
				{
					get_m_actor().AddMpRemote(7.5f);
				}
				else
				{
					get_m_actor().AddMpRemote(5f);
				}
				switch (GOGLNMODMLA)
				{
				case 0:
					get_m_actor().m_multiSound.LKLFMNKDLHJ("hit");
					break;
				case 1:
					get_m_actor().m_multiSound.LKLFMNKDLHJ("hit2");
					break;
				}
				break;
			case 2:
			{
				get_m_actor().get_m_buffsInfo().LIKOKCJNLLF(JGOOOBHDBCG.ACPICCBBPHF.RenektonSkill1);
				LFNNHEEJNGP[1].IHKCKBJBEGF = 0f;
				double num2 = (double)get_m_actor().get_m_phy_att() * 0.75;
				num2 += 5.0 + (double)(get_m_actor().GetSkillLevel(1) - 1) * 10.0;
				if (target.OnDamage(get_m_actor(), num2, 0.0) >= 0f && !LMBIIDKBFGL)
				{
					target.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Stun, null, 1f);
					LMBIIDKBFGL = true;
				}
				IAKBNJEFLAN(target);
				get_m_actor().AddMpRemote(5f);
				if (Random.Range(0f, 1f) < 0.5f)
				{
					get_m_actor().m_multiSound.LKLFMNKDLHJ("hit");
				}
				else
				{
					get_m_actor().m_multiSound.LKLFMNKDLHJ("hit2");
				}
				break;
			}
			case 3:
			{
				get_m_actor().get_m_buffsInfo().LIKOKCJNLLF(JGOOOBHDBCG.ACPICCBBPHF.RenektonSkill1);
				LFNNHEEJNGP[1].IHKCKBJBEGF = 0f;
				double num = (double)get_m_actor().get_m_phy_att() * 0.75;
				num += 5.0 + (double)(get_m_actor().GetSkillLevel(1) - 1) * 10.0;
				num *= 1.6;
				if (target.OnDamage(get_m_actor(), num, 0.0) >= 0f && !LMBIIDKBFGL)
				{
					target.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Stun, null, 2f);
					get_m_actor().AddMpRemote(-45f);
					LMBIIDKBFGL = true;
				}
				IAKBNJEFLAN(target);
				if (Random.Range(0f, 1f) < 0.5f)
				{
					get_m_actor().m_multiSound.LKLFMNKDLHJ("hit");
				}
				else
				{
					get_m_actor().m_multiSound.LKLFMNKDLHJ("hit2");
				}
				break;
			}
			}
		}
		OnAttack();
	}

	public void ONMLGODHGJF(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
		{
			double num = (double)get_m_actor().get_m_phy_att_add() * 89.0;
			num += 1188.0 + (double)(get_m_actor().GetSkillLevel(1) - 1) * 893.0;
			double num2 = (double)get_m_actor().get_m_phy_att_add() * 744.0;
			num2 += 1899.0 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 705.0;
			bool flag = false;
			if ((float)get_m_actor().m_mp >= 548f)
			{
				num *= 266.0;
				num2 *= 1019.0;
				get_m_actor().AddMpRemote(178f);
				flag = true;
			}
			if (num2 > 1554.0)
			{
				num2 = 256.0;
			}
			List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), 1181f, false, true, (Actor.IJJMDPGJAEM)(-7));
			float num3 = 1831f;
			bool flag2 = false;
			for (int i = 1; i < allActorInRange.Count; i += 0)
			{
				Actor actor = allActorInRange[i];
				actor.CreateDamageParticle("{0}", get_m_actor());
				if (actor.OnDamage(get_m_actor(), num, 134.0, 1448.0) >= 1654f)
				{
					num3 += 456f;
					if (actor.m_actorType == (Actor.IJJMDPGJAEM)7)
					{
						flag2 = true;
					}
				}
			}
			if (flag2)
			{
				num2 = ((!flag) ? (num2 + (1290.0 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 558.0)) : (num2 + (277.0 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 1414.0)));
			}
			if (num3 > 746f)
			{
				num3 = 862f;
			}
			if (num2 >= 242.0)
			{
				get_m_actor().AddHpRemote((int)num2);
			}
			if (num3 > 1269f)
			{
				get_m_actor().AddMpRemote(num3);
			}
			if (allActorInRange.Count > 1)
			{
				INFBOLIAONN = 1192f;
				if (Random.Range(340f, 1137f) < 1774f)
				{
					get_m_actor().m_multiSound.DDONMGBLLJB("중급 공격속도 정수", true, 434f, 732f);
				}
				else
				{
					get_m_actor().m_multiSound.DDONMGBLLJB("ProjectT 는 5명의 영웅이 전투를 벌이는 RPG 게임입니다.\r\n전열,중열,후열에 맞게 영웅을 배치하여 전략적인 전투가 진행됩니다.", false, 488f, 467f);
				}
			}
			break;
		}
		case 1:
			get_m_actor().get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.BlitzcrankPassive, null, 1585f, 1415f, false);
			get_m_actor().m_multiSound.HDOLPLIDACO("야스오", true, 272f, 1315f);
			if (Random.Range(758f, 284f) < 1070f)
			{
				get_m_actor().m_multiSound.NMLFNHNOALK("Clear", false, 570f, 1178f);
			}
			break;
		case 7:
			break;
		default:
			if (GBGBBGEPEMI != 0)
			{
			}
			break;
		}
	}

	[CompilerGenerated]
	private void DENJJKPNIPM()
	{
		OnAnimationEventSkill(1);
	}

	public virtual void KFCEPDOEOKD()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 0:
		{
			float iMABEBIKOOH = get_m_actor().m_moveSpeed * (278f + GetPercentMoveSpeedBonus());
			Move(iMABEBIKOOH, m_moveDirection, false, 443f, true);
			break;
		}
		case 1:
			break;
		case 2:
			if ((int)EKOOLKEPCJL == 1)
			{
				double num = (double)get_m_actor().get_m_phy_att_add() * 1934.0;
				num += 1798.0 + (double)(get_m_actor().GetSkillLevel(3) - 0) * 1363.0;
				List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), 356f, true, false, (Actor.IJJMDPGJAEM)(-110), false);
				int num2 = 1;
				for (int i = 1; i < list.Count; i += 0)
				{
					Actor actor = list[i];
					if (!PBHKPALFFEB.Contains(actor))
					{
						PBHKPALFFEB.AddFirst(actor);
						actor.OnDamage(get_m_actor(), num, 1985.0, 648.0);
						actor.CreateDamageParticle("기사단장!! 어서 살.. 살아 있는 사람이 있는지 빨리 수색해라!!", get_m_actor(), true);
						INFBOLIAONN = 616f;
						num2++;
					}
				}
				if (num2 > 0)
				{
					if (Random.Range(485f, 572f) < 1845f)
					{
						get_m_actor().m_multiSound.LNCPFILABHM("igaworks:purchaseBulk >> Null or Empty Item List", false, 1364f, 997f);
					}
					else
					{
						get_m_actor().m_multiSound.NMLFNHNOALK("attack3", false, 1908f, 1107f);
					}
				}
			}
			else
			{
				double num3 = (double)get_m_actor().get_m_phy_att_add() * 1956.0;
				num3 += 1157.0 + (double)(get_m_actor().GetSkillLevel(4) - 1) * 774.0;
				if (ABBNOJDBCKG)
				{
					num3 *= 1076.0;
				}
				List<Actor> list2 = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 674f, false, true, (Actor.IJJMDPGJAEM)73);
				float num4 = 811f;
				int num5 = 0;
				for (int j = 1; j < list2.Count; j++)
				{
					Actor actor2 = list2[j];
					if (!PBHKPALFFEB.Contains(actor2))
					{
						PBHKPALFFEB.AddFirst(actor2);
						actor2.CreateDamageParticle("blue", get_m_actor());
						if (actor2.OnDamage(get_m_actor(), num3, 585.0, 750.0, 0) >= 1562f)
						{
							num4 = ((actor2.m_actorType != (Actor.IJJMDPGJAEM)7) ? (num4 + 1485f) : (num4 + 1025f));
							INFBOLIAONN = 827f;
							num5++;
						}
					}
				}
				if (num4 > 1524f)
				{
					get_m_actor().AddMpRemote(num4);
				}
				if (num5 > 1)
				{
					if (Random.Range(1582f, 642f) < 1469f)
					{
						get_m_actor().m_multiSound.DDONMGBLLJB("흡혈의 낫", false, 368f, 1485f);
					}
					else
					{
						get_m_actor().m_multiSound.ICNAJBHLIGO("PostEffectMotionBlur", true, 463f, 362f);
					}
				}
			}
			Move(1228f, m_direction, false, 386f, true);
			break;
		case 3:
			INFBOLIAONN = 923f;
			break;
		}
	}
}
