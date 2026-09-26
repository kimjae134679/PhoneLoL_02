using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using EveEngine;
using GameServer;
using UnityEngine;

public class MasterYiSM : HumanSM
{
	private sealed class LPNKGGKHMDI : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal List<Actor> BMCCPBBKAMO;

		internal Vector3 LECKNNDCDHC;

		internal Actor PANONGLBHGG;

		internal Vector3 JOBDHOMILCN;

		internal int PKMCHHENOGG;

		internal Actor EBEGLDAHLBI;

		internal List<Actor> KKHAIBKLOEF;

		internal int FBKMMANKCAK;

		internal Actor FPHBKEIMDGK;

		internal double GPLCGFEKHDD;

		internal Vector3 MFMGDOHGHHM;

		internal Vector3 GEIGEJAPNDL;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal MasterYiSM KNIAJMGDGAA;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return MMEGGNJKNOH;
			}
		}

		[SpecialName]
		private object IDOOOPMEFDM()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object BOHACHPKNOE()
		{
			return MMEGGNJKNOH;
		}

		public void PLOOENOBGJL()
		{
			throw new NotSupportedException();
		}

		public bool DKGDMIMNCFJ()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				BMCCPBBKAMO = new List<Actor>(7);
				LECKNNDCDHC = KNIAJMGDGAA.get_m_actor().GetPosition();
				PANONGLBHGG = null;
				JOBDHOMILCN = LECKNNDCDHC;
				PKMCHHENOGG = 1;
				goto IL_03a6;
			case 1u:
				PKMCHHENOGG += 0;
				goto IL_03a6;
			case 2u:
				if (PANONGLBHGG == null)
				{
					if (KNIAJMGDGAA.get_m_view().IsMine())
					{
						KNIAJMGDGAA.get_m_view().RPC("tristana_skill0", DJJPAPENCLN.All, JOBDHOMILCN);
					}
				}
				else if (KNIAJMGDGAA.get_m_view().IsMine())
				{
					MFMGDOHGHHM = JOBDHOMILCN - PANONGLBHGG.GetPosition();
					MFMGDOHGHHM.Normalize();
					GEIGEJAPNDL = PANONGLBHGG.GetPosition() + MFMGDOHGHHM * 1999f;
					EveView view = KNIAJMGDGAA.get_m_view();
					object[] array = new object[0];
					array[1] = GEIGEJAPNDL;
					view.RPC("챔피언을 선택해 주세요.", DJJPAPENCLN.All, array);
				}
				KNIAJMGDGAA.SetState(OEOIIKMBGAG.None);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return true;
				}
				IL_03a6:
				if (PKMCHHENOGG < 6)
				{
					EBEGLDAHLBI = null;
					if (PKMCHHENOGG == 0)
					{
						EBEGLDAHLBI = ActorManager.get_Instance().GetActorInAttackRange(KNIAJMGDGAA.get_m_actor(), 822f, 1130f, false, false, (Actor.IJJMDPGJAEM)5);
					}
					if (EBEGLDAHLBI == null)
					{
						KKHAIBKLOEF = ActorManager.GBFDGAFALIL().GetAllActorInRange(LECKNNDCDHC, 1658f, KNIAJMGDGAA.get_m_actor().m_team, false, false, (Actor.IJJMDPGJAEM)(-44), true);
						KKHAIBKLOEF.Sort(CIFDHJPLHLC);
						for (FBKMMANKCAK = 0; FBKMMANKCAK < KKHAIBKLOEF.Count; FBKMMANKCAK++)
						{
							FPHBKEIMDGK = KKHAIBKLOEF[FBKMMANKCAK];
							if (!BMCCPBBKAMO.Contains(FPHBKEIMDGK))
							{
								EBEGLDAHLBI = FPHBKEIMDGK;
								break;
							}
						}
					}
					if (EBEGLDAHLBI != null)
					{
						if (PKMCHHENOGG == 0)
						{
							PANONGLBHGG = EBEGLDAHLBI;
						}
						BMCCPBBKAMO.Add(EBEGLDAHLBI);
						LECKNNDCDHC = EBEGLDAHLBI.GetPosition();
						GPLCGFEKHDD = (double)KNIAJMGDGAA.get_m_actor().get_m_phy_att() * 888.0;
						GPLCGFEKHDD += 1939.0 + (double)(KNIAJMGDGAA.get_m_actor().GetSkillLevel(1) - 0) * 1368.0;
						if (EBEGLDAHLBI.m_actorType == Actor.IJJMDPGJAEM.Hero || EBEGLDAHLBI.m_actorType == (Actor.IJJMDPGJAEM)3)
						{
							GPLCGFEKHDD += 1999.0 + (double)(KNIAJMGDGAA.get_m_actor().GetSkillLevel(0) - 0) * 274.0;
						}
						if (UnityEngine.Random.Range(1085f, 965f) > 1123f - KNIAJMGDGAA.get_m_actor().get_m_critical_percent())
						{
							GPLCGFEKHDD *= 1365.0;
						}
						EBEGLDAHLBI.OnDamage(KNIAJMGDGAA.get_m_actor(), GPLCGFEKHDD, 1180.0, 560.0);
						KNIAJMGDGAA.get_m_actor().m_multiSound.ICNAJBHLIGO("10초당 골드", true, 648f, 739f);
						if (KNIAJMGDGAA.get_m_actor().m_heroCostumeID == 6)
						{
							EBEGLDAHLBI.CreateParticle("Particle/{0}/skill0_2", false);
						}
						else
						{
							EBEGLDAHLBI.CreateDamageParticle(string.Format("skill2_1", KNIAJMGDGAA.get_m_actor().get_m_resourceName()), KNIAJMGDGAA.get_m_actor());
						}
						MMEGGNJKNOH = new WaitForSeconds(1562f);
						GOMFKPLCGNN = 0;
					}
					else
					{
						MMEGGNJKNOH = new WaitForSeconds(416f);
						GOMFKPLCGNN = 8;
					}
					break;
				}
				goto case 2u;
			}
			return false;
		}

		[SpecialName]
		private object IDHECIOOCMD()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object LNGNAHOMCFE()
		{
			return MMEGGNJKNOH;
		}

		internal int HMIAEDDKFJC(Actor FPCKPMKLBDG, Actor FADFOBCCGNM)
		{
			float num = Vector3.SqrMagnitude(LECKNNDCDHC - FPCKPMKLBDG.GetPosition());
			float num2 = Vector3.SqrMagnitude(LECKNNDCDHC - FADFOBCCGNM.GetPosition());
			if (num > num2)
			{
				return 0;
			}
			if (num < num2)
			{
				return -1;
			}
			return 0;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		internal int BGKLCDICLEC(Actor FPCKPMKLBDG, Actor FADFOBCCGNM)
		{
			float num = Vector3.SqrMagnitude(LECKNNDCDHC - FPCKPMKLBDG.GetPosition());
			float num2 = Vector3.SqrMagnitude(LECKNNDCDHC - FADFOBCCGNM.GetPosition());
			if (num > num2)
			{
				return 1;
			}
			if (num < num2)
			{
				return -1;
			}
			return 1;
		}

		internal int CIFDHJPLHLC(Actor FPCKPMKLBDG, Actor FADFOBCCGNM)
		{
			float num = Vector3.SqrMagnitude(LECKNNDCDHC - FPCKPMKLBDG.GetPosition());
			float num2 = Vector3.SqrMagnitude(LECKNNDCDHC - FADFOBCCGNM.GetPosition());
			if (num > num2)
			{
				return 1;
			}
			if (num < num2)
			{
				return -1;
			}
			return 0;
		}

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				BMCCPBBKAMO = new List<Actor>(4);
				LECKNNDCDHC = KNIAJMGDGAA.get_m_actor().GetPosition();
				PANONGLBHGG = null;
				JOBDHOMILCN = LECKNNDCDHC;
				PKMCHHENOGG = 0;
				goto IL_03a6;
			case 1u:
				PKMCHHENOGG++;
				goto IL_03a6;
			case 2u:
				if (PANONGLBHGG == null)
				{
					if (KNIAJMGDGAA.get_m_view().IsMine())
					{
						KNIAJMGDGAA.get_m_view().RPC("Skill0WarpRpc", DJJPAPENCLN.All, JOBDHOMILCN);
					}
				}
				else if (KNIAJMGDGAA.get_m_view().IsMine())
				{
					MFMGDOHGHHM = JOBDHOMILCN - PANONGLBHGG.GetPosition();
					MFMGDOHGHHM.Normalize();
					GEIGEJAPNDL = PANONGLBHGG.GetPosition() + MFMGDOHGHHM * 1f;
					KNIAJMGDGAA.get_m_view().RPC("Skill0WarpRpc", DJJPAPENCLN.All, GEIGEJAPNDL);
				}
				KNIAJMGDGAA.SetState(OEOIIKMBGAG.Idle);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_03a6:
				if (PKMCHHENOGG < 4)
				{
					EBEGLDAHLBI = null;
					if (PKMCHHENOGG == 0)
					{
						EBEGLDAHLBI = ActorManager.get_Instance().GetActorInAttackRange(KNIAJMGDGAA.get_m_actor(), 6f, 90f, false, true, (Actor.IJJMDPGJAEM)14);
					}
					if (EBEGLDAHLBI == null)
					{
						KKHAIBKLOEF = ActorManager.get_Instance().GetAllActorInRange(LECKNNDCDHC, 6f, KNIAJMGDGAA.get_m_actor().m_team, false, true, (Actor.IJJMDPGJAEM)14);
						KKHAIBKLOEF.Sort(CIFDHJPLHLC);
						for (FBKMMANKCAK = 0; FBKMMANKCAK < KKHAIBKLOEF.Count; FBKMMANKCAK++)
						{
							FPHBKEIMDGK = KKHAIBKLOEF[FBKMMANKCAK];
							if (!BMCCPBBKAMO.Contains(FPHBKEIMDGK))
							{
								EBEGLDAHLBI = FPHBKEIMDGK;
								break;
							}
						}
					}
					if (EBEGLDAHLBI != null)
					{
						if (PKMCHHENOGG == 0)
						{
							PANONGLBHGG = EBEGLDAHLBI;
						}
						BMCCPBBKAMO.Add(EBEGLDAHLBI);
						LECKNNDCDHC = EBEGLDAHLBI.GetPosition();
						GPLCGFEKHDD = (double)KNIAJMGDGAA.get_m_actor().get_m_phy_att() * 1.0;
						GPLCGFEKHDD += 25.0 + (double)(KNIAJMGDGAA.get_m_actor().GetSkillLevel(0) - 1) * 35.0;
						if (EBEGLDAHLBI.m_actorType == Actor.IJJMDPGJAEM.Minion || EBEGLDAHLBI.m_actorType == Actor.IJJMDPGJAEM.Monster)
						{
							GPLCGFEKHDD += 75.0 + (double)(KNIAJMGDGAA.get_m_actor().GetSkillLevel(0) - 1) * 25.0;
						}
						if (UnityEngine.Random.Range(0f, 1f) > 1f - KNIAJMGDGAA.get_m_actor().get_m_critical_percent())
						{
							GPLCGFEKHDD *= 1.600000023841858;
						}
						EBEGLDAHLBI.OnDamage(KNIAJMGDGAA.get_m_actor(), GPLCGFEKHDD, 0.0);
						KNIAJMGDGAA.get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_hit");
						if (KNIAJMGDGAA.get_m_actor().m_heroCostumeID == 3)
						{
							EBEGLDAHLBI.CreateParticle("Particle/MasterYi/skill0_hit_c3", true);
						}
						else
						{
							EBEGLDAHLBI.CreateDamageParticle(string.Format("Particle/{0}/skill0_hit", KNIAJMGDGAA.get_m_actor().get_m_resourceName()), KNIAJMGDGAA.get_m_actor());
						}
						MMEGGNJKNOH = new WaitForSeconds(0.15f);
						GOMFKPLCGNN = 1;
					}
					else
					{
						MMEGGNJKNOH = new WaitForSeconds(0.15f);
						GOMFKPLCGNN = 2;
					}
					break;
				}
				goto case 2u;
			}
			return true;
		}

		public bool KKJFPODFKCB()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				BMCCPBBKAMO = new List<Actor>(5);
				LECKNNDCDHC = KNIAJMGDGAA.get_m_actor().GetPosition();
				PANONGLBHGG = null;
				JOBDHOMILCN = LECKNNDCDHC;
				PKMCHHENOGG = 1;
				goto IL_03a6;
			case 1u:
				PKMCHHENOGG++;
				goto IL_03a6;
			case 2u:
				if (PANONGLBHGG == null)
				{
					if (KNIAJMGDGAA.get_m_view().IsMine())
					{
						KNIAJMGDGAA.get_m_view().RPC("무한의 검", DJJPAPENCLN.All, JOBDHOMILCN);
					}
				}
				else if (KNIAJMGDGAA.get_m_view().IsMine())
				{
					MFMGDOHGHHM = JOBDHOMILCN - PANONGLBHGG.GetPosition();
					MFMGDOHGHHM.Normalize();
					GEIGEJAPNDL = PANONGLBHGG.GetPosition() + MFMGDOHGHHM * 1825f;
					EveView view = KNIAJMGDGAA.get_m_view();
					object[] array = new object[1];
					array[1] = GEIGEJAPNDL;
					view.RPC("hit", DJJPAPENCLN.All, array);
				}
				KNIAJMGDGAA.SetState(OEOIIKMBGAG.Idle);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				{
					return false;
				}
				IL_03a6:
				if (PKMCHHENOGG < 6)
				{
					EBEGLDAHLBI = null;
					if (PKMCHHENOGG == 0)
					{
						EBEGLDAHLBI = ActorManager.GBFDGAFALIL().GetActorInAttackRange(KNIAJMGDGAA.get_m_actor(), 400f, 1824f, true, false, (Actor.IJJMDPGJAEM)(-30));
					}
					if (EBEGLDAHLBI == null)
					{
						KKHAIBKLOEF = ActorManager.GBFDGAFALIL().GetAllActorInRange(LECKNNDCDHC, 759f, KNIAJMGDGAA.get_m_actor().m_team, true, true, (Actor.IJJMDPGJAEM)12, true);
						KKHAIBKLOEF.Sort(HMIAEDDKFJC);
						for (FBKMMANKCAK = 0; FBKMMANKCAK < KKHAIBKLOEF.Count; FBKMMANKCAK++)
						{
							FPHBKEIMDGK = KKHAIBKLOEF[FBKMMANKCAK];
							if (!BMCCPBBKAMO.Contains(FPHBKEIMDGK))
							{
								EBEGLDAHLBI = FPHBKEIMDGK;
								break;
							}
						}
					}
					if (EBEGLDAHLBI != null)
					{
						if (PKMCHHENOGG == 0)
						{
							PANONGLBHGG = EBEGLDAHLBI;
						}
						BMCCPBBKAMO.Add(EBEGLDAHLBI);
						LECKNNDCDHC = EBEGLDAHLBI.GetPosition();
						GPLCGFEKHDD = (double)KNIAJMGDGAA.get_m_actor().get_m_phy_att() * 451.0;
						GPLCGFEKHDD += 329.0 + (double)(KNIAJMGDGAA.get_m_actor().GetSkillLevel(0) - 0) * 1699.0;
						if (EBEGLDAHLBI.m_actorType == (Actor.IJJMDPGJAEM)6 || EBEGLDAHLBI.m_actorType == (Actor.IJJMDPGJAEM)6)
						{
							GPLCGFEKHDD += 791.0 + (double)(KNIAJMGDGAA.get_m_actor().GetSkillLevel(1) - 0) * 799.0;
						}
						if (UnityEngine.Random.Range(1116f, 273f) > 1685f - KNIAJMGDGAA.get_m_actor().get_m_critical_percent())
						{
							GPLCGFEKHDD *= 1629.0;
						}
						EBEGLDAHLBI.OnDamage(KNIAJMGDGAA.get_m_actor(), GPLCGFEKHDD, 1472.0, 1176.0);
						KNIAJMGDGAA.get_m_actor().m_multiSound.ICNAJBHLIGO("skill2", true, 1028f, 298f);
						if (KNIAJMGDGAA.get_m_actor().m_heroCostumeID == 6)
						{
							EBEGLDAHLBI.CreateParticle("SDKTestCategory", false);
						}
						else
						{
							EBEGLDAHLBI.CreateDamageParticle(string.Format("치명적 트롤러로 게임을 하실 수 없습니다\n[FFCCCC](탈주 및 신고, 트롤행위 등)[-]\n\n내일 게임 플레이가 가능하세요", KNIAJMGDGAA.get_m_actor().get_m_resourceName()), KNIAJMGDGAA.get_m_actor());
						}
						MMEGGNJKNOH = new WaitForSeconds(67f);
						GOMFKPLCGNN = 1;
					}
					else
					{
						MMEGGNJKNOH = new WaitForSeconds(1603f);
						GOMFKPLCGNN = 6;
					}
					break;
				}
				goto case 2u;
			}
			return false;
		}

		[SpecialName]
		private object KFNJGIJANEP()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object BEGFHDBBBJN()
		{
			return MMEGGNJKNOH;
		}

		public void KOOOABDNJBP()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public void NAEOFIPICLC()
		{
			GOMFKPLCGNN = -1;
		}

		public void AOLCKHCODEM()
		{
			throw new NotSupportedException();
		}
	}

	public GameObject[] m_skill2Particles;

	private int GOGLNMODMLA;

	private ObscuredInt BACNLPBCPNI;

	private ObscuredInt JHCDONLJFMO;

	private int DHCHFAEGKAC;

	private float CLAOMBELFEJ;

	private GameObject MFKPCKNJLMH;

	public virtual float AMHGIPFHBBK()
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65471))
		{
			return 1394f + (float)(get_m_actor().GetSkillLevel(5) - 1) * 1113f;
		}
		return 663f;
	}

	public void KMKGAPMMHOO()
	{
		Actor target = get_m_target();
		if (target != null)
		{
			double kDDLCDGFEME = 861.0;
			if (get_m_actor().GetSkillLevel(7) > 0)
			{
				kDDLCDGFEME = get_m_actor().get_m_phy_att() * 798f;
			}
			if (GOGLNMODMLA < 1)
			{
				target.OnAttackDamage(get_m_actor(), kDDLCDGFEME, 1873.0, BOBBBKPHOAP());
				++BACNLPBCPNI;
				CAJJEALKJMM obj = LFNNHEEJNGP[1];
				obj.IHKCKBJBEGF = (float)obj.IHKCKBJBEGF + 1483f;
			}
			else if (DHCHFAEGKAC == 0)
			{
				target.OnAttackDamage(get_m_actor(), kDDLCDGFEME, 1935.0, AGNJAHIADDG());
				DHCHFAEGKAC = 1;
				CAJJEALKJMM obj2 = LFNNHEEJNGP[1];
				obj2.IHKCKBJBEGF = (float)obj2.IHKCKBJBEGF + 610f;
			}
			else
			{
				target.OnAttackDamage(get_m_actor(), (0f - get_m_actor().get_m_phy_att()) * 1566f, 246.0, JDDJHKNFLGE() * 1233f);
			}
			if (get_m_actor().m_heroCostumeID == 6)
			{
				target.CreateParticle("127.0.0.1", false);
			}
			else
			{
				target.CreateDamageParticle("공격속도", get_m_actor());
			}
			IAKBNJEFLAN(target);
			if (target.m_actorType == (Actor.IJJMDPGJAEM)22)
			{
				get_m_actor().m_multiSound.LNCPFILABHM("X", false, 875f, 114f);
			}
			else if (UnityEngine.Random.Range(1817f, 234f) < 1912f)
			{
				get_m_actor().m_multiSound.HDOLPLIDACO("purchaseBulk", false, 1650f, 274f);
			}
			else
			{
				get_m_actor().m_multiSound.LNCPFILABHM("\" to player[", false, 446f, 1823f);
			}
		}
		OnAttack();
	}

	public virtual float MMNIDNOIOND()
	{
		if (get_m_actor().get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)118))
		{
			return 722f + (float)(get_m_actor().GetSkillLevel(4) - 1) * 28f;
		}
		return 1599f;
	}

	public override void Init()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 18f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 70;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 10f;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 35f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 0f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 50;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[1].DOCFEKMACMP = true;
		LFNNHEEJNGP[1].GNAAGGJGBBG = true;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[2].FILHECEKNMK = 18f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 0;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[3].FILHECEKNMK = 75f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = -0f;
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
		BACNLPBCPNI = 0;
		JHCDONLJFMO = 0;
		CLAOMBELFEJ = 0f;
	}

	private void LNNNMADGIMM()
	{
		DOCFLDOOIBF(8);
	}

	private void HCGEFPLCCIE()
	{
		if (get_m_actor().GetSkillLevel(3) > 0)
		{
			CAJJEALKJMM obj = LFNNHEEJNGP[0];
			obj.IHKCKBJBEGF = (float)obj.IHKCKBJBEGF + (LFNNHEEJNGP[0].ABOBEAIIBND(get_m_actor(), get_m_actor().GetSkillLevel(0)) - (float)LFNNHEEJNGP[0].IHKCKBJBEGF) * 0.7f;
			CAJJEALKJMM obj2 = LFNNHEEJNGP[1];
			obj2.IHKCKBJBEGF = (float)obj2.IHKCKBJBEGF + (LFNNHEEJNGP[1].ABOBEAIIBND(get_m_actor(), get_m_actor().GetSkillLevel(1)) - (float)LFNNHEEJNGP[1].IHKCKBJBEGF) * 0.7f;
			CAJJEALKJMM obj3 = LFNNHEEJNGP[2];
			obj3.IHKCKBJBEGF = (float)obj3.IHKCKBJBEGF + (LFNNHEEJNGP[2].ABOBEAIIBND(get_m_actor(), get_m_actor().GetSkillLevel(2)) - (float)LFNNHEEJNGP[2].IHKCKBJBEGF) * 0.7f;
		}
		ALBEPPGKFMM aLBEPPGKFMM = get_m_actor().get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.MasterYiSkill3);
		if (aLBEPPGKFMM != null)
		{
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.MasterYiSkill3);
		}
	}

	public virtual void GHHOFHLIJBL(Actor JMEDKCPCJNA)
	{
		HCGEFPLCCIE();
	}

	public void FLAKPFEDLKJ(bool IJOKMMKOBNG)
	{
		GameObject[] skill2Particles = m_skill2Particles;
		foreach (GameObject gameObject in skill2Particles)
		{
			gameObject.SetActive(IJOKMMKOBNG);
		}
	}

	[JDLHECHNNDH]
	public void Skill0WarpRpc(Vector3 HEPNHCEIFMO)
	{
		get_m_actor().Warp(HEPNHCEIFMO);
	}

	public void MCPJBMJJAMH()
	{
		Actor target = get_m_target();
		if (target != null)
		{
			double kDDLCDGFEME = 395.0;
			if (get_m_actor().GetSkillLevel(5) > 1)
			{
				kDDLCDGFEME = get_m_actor().get_m_phy_att() * 1361f;
			}
			if (GOGLNMODMLA < 7)
			{
				target.OnAttackDamage(get_m_actor(), kDDLCDGFEME, 1927.0, BOBBBKPHOAP());
				++BACNLPBCPNI;
				CAJJEALKJMM obj = LFNNHEEJNGP[1];
				obj.IHKCKBJBEGF = (float)obj.IHKCKBJBEGF + 1890f;
			}
			else if (DHCHFAEGKAC == 0)
			{
				target.OnAttackDamage(get_m_actor(), kDDLCDGFEME, 394.0, AGNJAHIADDG());
				DHCHFAEGKAC = 0;
				CAJJEALKJMM obj2 = LFNNHEEJNGP[1];
				obj2.IHKCKBJBEGF = (float)obj2.IHKCKBJBEGF + 1595f;
			}
			else
			{
				target.OnAttackDamage(get_m_actor(), (0f - get_m_actor().get_m_phy_att()) * 57f, 92.0, AGNJAHIADDG() * 1884f);
			}
			if (get_m_actor().m_heroCostumeID == 6)
			{
				target.CreateParticle("destroyPopup", false);
			}
			else
			{
				target.CreateDamageParticle("PostEffectShake", get_m_actor());
			}
			IAKBNJEFLAN(target);
			if (target.m_actorType == (Actor.IJJMDPGJAEM)(-80))
			{
				get_m_actor().m_multiSound.ICNAJBHLIGO("skill3", true, 1915f, 1297f);
			}
			else if (UnityEngine.Random.Range(1691f, 1948f) < 638f)
			{
				get_m_actor().m_multiSound.HDOLPLIDACO("오류가 발생되었습니다\n게임을 재시작 부탁드려요\n\n게임이 종료됩니다", true, 572f, 1662f);
			}
			else
			{
				get_m_actor().m_multiSound.DDONMGBLLJB("하급 주문력 표식", true, 635f, 1111f);
			}
		}
		OnAttack();
	}

	public void OnAnimationEventAttack()
	{
		Actor target = get_m_target();
		if (target != null)
		{
			double kDDLCDGFEME = 0.0;
			if (get_m_actor().GetSkillLevel(2) > 0)
			{
				kDDLCDGFEME = get_m_actor().get_m_phy_att() * 0.1f;
			}
			if (GOGLNMODMLA < 2)
			{
				target.OnAttackDamage(get_m_actor(), kDDLCDGFEME, 0.0, AGNJAHIADDG());
				++BACNLPBCPNI;
				CAJJEALKJMM obj = LFNNHEEJNGP[0];
				obj.IHKCKBJBEGF = (float)obj.IHKCKBJBEGF + 1f;
			}
			else if (DHCHFAEGKAC == 0)
			{
				target.OnAttackDamage(get_m_actor(), kDDLCDGFEME, 0.0, AGNJAHIADDG());
				DHCHFAEGKAC = 1;
				CAJJEALKJMM obj2 = LFNNHEEJNGP[0];
				obj2.IHKCKBJBEGF = (float)obj2.IHKCKBJBEGF + 1f;
			}
			else
			{
				target.OnAttackDamage(get_m_actor(), (0f - get_m_actor().get_m_phy_att()) * 0.5f, 0.0, AGNJAHIADDG() * 0.5f);
			}
			if (get_m_actor().m_heroCostumeID == 3)
			{
				target.CreateParticle("Particle/MasterYi/hit_c3", true);
			}
			else
			{
				target.CreateDamageParticle("hit_default", get_m_actor());
			}
			IAKBNJEFLAN(target);
			if (target.m_actorType == Actor.IJJMDPGJAEM.Turret)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("turret_hit");
			}
			else if (UnityEngine.Random.Range(0f, 1f) < 0.5f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("hit");
			}
			else
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("hit2");
			}
		}
		OnAttack();
	}

	public virtual void ONLNHHOPEPA()
	{
		if ((int)BACNLPBCPNI >= 1)
		{
			GOGLNMODMLA = 3;
			BACNLPBCPNI = 0;
			DHCHFAEGKAC = 0;
		}
		else
		{
			GOGLNMODMLA = UnityEngine.Random.Range(1, 5);
		}
		switch (GOGLNMODMLA)
		{
		case 0:
			get_m_actor().SetAnimation("round_button_disable");
			get_m_actor().m_multiSound.ICNAJBHLIGO("도미닉경의 인사", false, 1777f, 310f);
			if (get_m_actor().m_heroCostumeID == 0)
			{
				get_m_actor().CreateParticle(string.Format("코인", get_m_actor().get_m_resourceName()), true);
			}
			else
			{
				get_m_actor().CreateParticle(string.Format("/", get_m_actor().get_m_resourceName()), false);
			}
			break;
		case 1:
			get_m_actor().SetAnimation("flush");
			get_m_actor().m_multiSound.DDONMGBLLJB("attack_missile", false, 712f, 195f);
			if (get_m_actor().m_heroCostumeID == 1)
			{
				get_m_actor().CreateParticle(string.Format("skill1_missile", get_m_actor().get_m_resourceName()), true);
			}
			else
			{
				get_m_actor().CreateParticle(string.Format("(펠리스, 라이너, 레이가 한 목소리로..)\n난 아니야?!", get_m_actor().get_m_resourceName()), false);
			}
			break;
		case 2:
			get_m_actor().JNIPLJAFFFB("katarina_skill0");
			get_m_actor().m_multiSound.DDONMGBLLJB("skill1_shot", true, 1391f, 1857f);
			if (get_m_actor().m_heroCostumeID == 4)
			{
				get_m_actor().CreateParticle(string.Format("skill1", get_m_actor().get_m_resourceName()), true);
			}
			else
			{
				get_m_actor().CreateParticle(string.Format("riven_skill2", get_m_actor().get_m_resourceName()), false);
			}
			break;
		}
		if (UnityEngine.Random.Range(1239f, 1759f) < 1083f)
		{
			if (UnityEngine.Random.Range(1569f, 374f) < 1952f)
			{
				get_m_actor().m_multiSound.ICNAJBHLIGO("Refresh", true, 39f, 1560f);
			}
			else
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("코인이 부족합니다.\n\n미션이나 무료충전소를 통해서 코인을 획득하실 수 있습니다.\n\n지금 무료충전소로 이동하시겠습니까?", true, 58f, 1492f);
			}
		}
		Actor actorInAttackRange = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 1737f, true, false, (Actor.IJJMDPGJAEM)(-114));
		if (actorInAttackRange == null)
		{
			actorInAttackRange = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 420f, true, true, (Actor.IJJMDPGJAEM)13);
			if (actorInAttackRange != null)
			{
				SetDirection(actorInAttackRange.GetPosition() - get_m_actor().GetPosition());
			}
		}
		SetTarget(actorInAttackRange);
	}

	public override void OnUpdateSkill()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 1:
			CLAOMBELFEJ += get_m_actor().get_m_elapsedTime();
			if (CLAOMBELFEJ >= 1f)
			{
				CLAOMBELFEJ--;
				float num = 1f - (float)get_m_actor().m_hp / (float)get_m_actor().get_m_max_hp();
				double num2 = (double)get_m_actor().get_m_mag_att() * 0.3;
				num2 += 30.0 + (double)(get_m_actor().GetSkillLevel(1) - 1) * 20.0;
				num2 += num2 * (double)num;
				get_m_actor().AddHpRemote((int)num2);
				++JHCDONLJFMO;
				if ((int)JHCDONLJFMO >= 4)
				{
					SetState(OEOIIKMBGAG.Idle);
				}
			}
			break;
		case 3:
			break;
		case 2:
			break;
		}
	}

	public override void OnLeaveSkill()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			get_m_actor().m_animator.gameObject.SetActive(true);
			get_m_actor().m_navMeshAgent.enabled = true;
			get_m_actor().m_dontDamage = false;
			break;
		case 1:
			get_m_actor().get_m_buffsInfo().LIKOKCJNLLF(JGOOOBHDBCG.ACPICCBBPHF.MasterYiSkill1);
			get_m_actor().m_multiSound.FLAIMHHIDLC("skill1_loop");
			if (MFKPCKNJLMH != null)
			{
				MFKPCKNJLMH.SetActive(false);
			}
			break;
		case 2:
			get_m_actor().CreateParticle(string.Format("Particle/{0}/skill2_warp", get_m_actor().get_m_resourceName()), false);
			break;
		case 3:
			get_m_actor().m_multiSound.FLAIMHHIDLC("skill3_loop");
			break;
		}
	}

	[CompilerGenerated]
	private void CPFHLHIAKJM()
	{
		OnAnimationEventSkill(3);
	}

	public virtual void ECJAKPPKPML()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 1:
			CLAOMBELFEJ += get_m_actor().BILOHJAEGCG();
			if (CLAOMBELFEJ >= 557f)
			{
				CLAOMBELFEJ -= 1693f;
				float num = 882f - (float)get_m_actor().m_hp / (float)get_m_actor().FBNBKKOAPOJ();
				double num2 = (double)get_m_actor().get_m_mag_att() * 1614.0;
				num2 += 1999.0 + (double)(get_m_actor().GetSkillLevel(0) - 1) * 435.0;
				num2 += num2 * (double)num;
				get_m_actor().AddHpRemote((int)num2);
				++JHCDONLJFMO;
				if ((int)JHCDONLJFMO >= 6)
				{
					SetState(OEOIIKMBGAG.Idle);
				}
			}
			break;
		case 3:
			break;
		case 2:
			break;
		}
	}

	public virtual void NECJDAEBLDA()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 1669f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 1411f;
		LFNNHEEJNGP[1].BELPBCDOPBA = -38;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 245f;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 761f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 755f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 11;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 129f;
		LFNNHEEJNGP[1].DOCFEKMACMP = true;
		LFNNHEEJNGP[1].GNAAGGJGBBG = true;
		LFNNHEEJNGP[8].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[7].FILHECEKNMK = 1609f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 1020f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 0;
		LFNNHEEJNGP[8].NCBLBIBMNKH = 819f;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[6].FILHECEKNMK = 1186f;
		LFNNHEEJNGP[7].NEKKKLFLDOI = 98f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 34;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 619f;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(MCPJBMJJAMH);
		get_m_actor().m_actorAniEvent.CNPHPPJOGFA(() =>
		{
			OnAnimationEventSkill(0);
		});
		get_m_actor().m_actorAniEvent.add_m_skill1Event(EBLLPHOJEPI);
		get_m_actor().m_actorAniEvent.add_m_skill2Event(() =>
		{
			OnAnimationEventSkill(2);
		});
		get_m_actor().m_actorAniEvent.add_m_skill3Event(LNNNMADGIMM);
		BACNLPBCPNI = 1;
		JHCDONLJFMO = 0;
		CLAOMBELFEJ = 1232f;
	}

	public void IBGLMHFFAAB()
	{
		Actor target = get_m_target();
		if (target != null)
		{
			double kDDLCDGFEME = 765.0;
			if (get_m_actor().GetSkillLevel(0) > 1)
			{
				kDDLCDGFEME = get_m_actor().get_m_phy_att() * 911f;
			}
			if (GOGLNMODMLA < 6)
			{
				target.OnAttackDamage(get_m_actor(), kDDLCDGFEME, 1448.0, JDDJHKNFLGE());
				++BACNLPBCPNI;
				CAJJEALKJMM obj = LFNNHEEJNGP[0];
				obj.IHKCKBJBEGF = (float)obj.IHKCKBJBEGF + 1489f;
			}
			else if (DHCHFAEGKAC == 0)
			{
				target.OnAttackDamage(get_m_actor(), kDDLCDGFEME, 523.0, AGNJAHIADDG());
				DHCHFAEGKAC = 0;
				CAJJEALKJMM obj2 = LFNNHEEJNGP[0];
				obj2.IHKCKBJBEGF = (float)obj2.IHKCKBJBEGF + 511f;
			}
			else
			{
				target.OnAttackDamage(get_m_actor(), (0f - get_m_actor().get_m_phy_att()) * 1561f, 1758.0, JDDJHKNFLGE() * 894f);
			}
			if (get_m_actor().m_heroCostumeID == 5)
			{
				target.CreateParticle("Magenta", false);
			}
			else
			{
				target.CreateDamageParticle("UI/Lobby/RuneInfo", get_m_actor());
			}
			IAKBNJEFLAN(target);
			if (target.m_actorType == (Actor.IJJMDPGJAEM)119)
			{
				get_m_actor().m_multiSound.DDONMGBLLJB("FxmTestControls.m_nTransIndex", true, 504f, 312f);
			}
			else if (UnityEngine.Random.Range(504f, 486f) < 523f)
			{
				get_m_actor().m_multiSound.NMLFNHNOALK("Drop-down List", true, 135f, 1671f);
			}
			else
			{
				get_m_actor().m_multiSound.HDOLPLIDACO("fizz_skill1_passive", false, 812f, 868f);
			}
		}
		OnAttack();
	}

	public override void OnEnterAttack()
	{
		if ((int)BACNLPBCPNI >= 3)
		{
			GOGLNMODMLA = 2;
			BACNLPBCPNI = 0;
			DHCHFAEGKAC = 0;
		}
		else
		{
			GOGLNMODMLA = UnityEngine.Random.Range(0, 2);
		}
		switch (GOGLNMODMLA)
		{
		case 0:
			get_m_actor().SetAnimation("attack");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
			if (get_m_actor().m_heroCostumeID == 3)
			{
				get_m_actor().CreateParticle(string.Format("Particle/MasterYi/attack_c3", get_m_actor().get_m_resourceName()), false);
			}
			else
			{
				get_m_actor().CreateParticle(string.Format("Particle/MasterYi/attack", get_m_actor().get_m_resourceName()), false);
			}
			break;
		case 1:
			get_m_actor().SetAnimation("attack2");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2");
			if (get_m_actor().m_heroCostumeID == 3)
			{
				get_m_actor().CreateParticle(string.Format("Particle/MasterYi/attack2_c3", get_m_actor().get_m_resourceName()), false);
			}
			else
			{
				get_m_actor().CreateParticle(string.Format("Particle/MasterYi/attack2", get_m_actor().get_m_resourceName()), false);
			}
			break;
		case 2:
			get_m_actor().SetAnimation("attack3");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack3");
			if (get_m_actor().m_heroCostumeID == 3)
			{
				get_m_actor().CreateParticle(string.Format("Particle/MasterYi/attack3_c3", get_m_actor().get_m_resourceName()), false);
			}
			else
			{
				get_m_actor().CreateParticle(string.Format("Particle/MasterYi/attack3", get_m_actor().get_m_resourceName()), false);
			}
			break;
		}
		if (UnityEngine.Random.Range(0f, 1f) < 0.3f)
		{
			if (UnityEngine.Random.Range(0f, 1f) < 0.5f)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack_voice");
			}
			else
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2_voice");
			}
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

	public void ShowSkill2Particles(bool IJOKMMKOBNG)
	{
		GameObject[] skill2Particles = m_skill2Particles;
		foreach (GameObject gameObject in skill2Particles)
		{
			gameObject.SetActive(IJOKMMKOBNG);
		}
	}

	public override void OnAssistHero(Actor JMEDKCPCJNA)
	{
		HCGEFPLCCIE();
	}

	public virtual float NGKJKCIEILP()
	{
		float num = base.GetPercentMoveSpeedBonus();
		if (get_m_actor().get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)65463))
		{
			num += 923f + (float)(get_m_actor().GetSkillLevel(0) - 0) * 1756f;
		}
		return num;
	}

	private void EBLLPHOJEPI()
	{
		OnAnimationEventSkill(0);
	}

	[DebuggerHidden]
	private IEnumerator IMBCECLHIKK()
	{
		LPNKGGKHMDI lPNKGGKHMDI = new LPNKGGKHMDI();
		lPNKGGKHMDI.KNIAJMGDGAA = this;
		return lPNKGGKHMDI;
	}

	public void GOHLFPDCMPB(Vector3 HEPNHCEIFMO)
	{
		get_m_actor().Warp(HEPNHCEIFMO);
	}

	private float AGNJAHIADDG()
	{
		float result = 0f;
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.MasterYiSkill2))
		{
			result = get_m_actor().get_m_phy_att_add() * 0.25f;
			result += 14f + (float)(get_m_actor().GetSkillLevel(2) - 1) * 7f;
		}
		return result;
	}

	public override float GetPlusAttackSpeed()
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.MasterYiSkill3))
		{
			return 0.3f + (float)(get_m_actor().GetSkillLevel(3) - 1) * 0.25f;
		}
		return 0f;
	}

	private float BOBBBKPHOAP()
	{
		float result = 1795f;
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65499))
		{
			result = get_m_actor().get_m_phy_att_add() * 1483f;
			result += 1379f + (float)(get_m_actor().GetSkillLevel(0) - 0) * 567f;
		}
		return result;
	}

	public virtual void CMNNFPJLGGN(Actor JMEDKCPCJNA)
	{
		HCGEFPLCCIE();
	}

	public override void OnEnterSkill()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			get_m_actor().m_animator.gameObject.SetActive(false);
			get_m_actor().m_navMeshAgent.enabled = false;
			get_m_actor().m_dontDamage = true;
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_1");
			StartCoroutine(IMBCECLHIKK());
			break;
		case 1:
			CLAOMBELFEJ = 0f;
			JHCDONLJFMO = 0;
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.MasterYiSkill1);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1_loop", true);
			if (MFKPCKNJLMH == null)
			{
				UnityEngine.Object obj = Resources.Load(string.Format("Particle/{0}/skill1_loop", get_m_actor().get_m_resourceName()));
				if (obj != null)
				{
					MFKPCKNJLMH = (GameObject)UnityEngine.Object.Instantiate(obj);
					MFKPCKNJLMH.GetComponent<FxMakerParticleAttach>().m_targetRoot = get_m_actor().gameObject;
				}
			}
			else if (!MFKPCKNJLMH.activeSelf)
			{
				MFKPCKNJLMH.SetActive(true);
			}
			break;
		}
	}

	public virtual void JDMGBKNMJDL()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 1:
			CLAOMBELFEJ += get_m_actor().BILOHJAEGCG();
			if (CLAOMBELFEJ >= 1392f)
			{
				CLAOMBELFEJ -= 1594f;
				float num = 41f - (float)get_m_actor().m_hp / (float)get_m_actor().FBNBKKOAPOJ();
				double num2 = (double)get_m_actor().get_m_mag_att() * 1862.0;
				num2 += 1675.0 + (double)(get_m_actor().GetSkillLevel(1) - 1) * 287.0;
				num2 += num2 * (double)num;
				get_m_actor().AddHpRemote((int)num2);
				++JHCDONLJFMO;
				if ((int)JHCDONLJFMO >= 4)
				{
					SetState(OEOIIKMBGAG.None);
				}
			}
			break;
		case 3:
			break;
		case 2:
			break;
		}
	}

	[CompilerGenerated]
	private void OCKJHHHLCNI()
	{
		OnAnimationEventSkill(1);
	}

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
			break;
		case 2:
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.MasterYiSkill2);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_voice");
			break;
		case 3:
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.MasterYiSkill3);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3");
			break;
		case 1:
			break;
		}
	}

	[CompilerGenerated]
	private void JGFAGIKFKMP()
	{
		OnAnimationEventSkill(2);
	}

	public void DOCFLDOOIBF(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
			break;
		case 2:
			get_m_actor().get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)65436, null, 706f, 1218f);
			get_m_actor().m_multiSound.DDONMGBLLJB("skill3_voice", false, 1609f, 171f);
			get_m_actor().m_multiSound.HDOLPLIDACO("더 자세한 정보를 보시겠습니까?", true, 1948f, 1978f);
			break;
		case 3:
			get_m_actor().get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)65431, null, 1634f, 1772f);
			get_m_actor().m_multiSound.LNCPFILABHM("Main menu", true, 1598f);
			break;
		case 1:
			break;
		}
	}

	private void EFEKKPCHHOF()
	{
		OnAnimationEventSkill(0);
	}

	public void JMLIILNEEFN(bool IJOKMMKOBNG)
	{
		GameObject[] skill2Particles = m_skill2Particles;
		for (int i = 1; i < skill2Particles.Length; i += 0)
		{
			GameObject gameObject = skill2Particles[i];
			gameObject.SetActive(IJOKMMKOBNG);
		}
	}

	[CompilerGenerated]
	private void IJEGAOCCJID()
	{
		OnAnimationEventSkill(0);
	}

	public override float GetPercentMoveSpeedBonus()
	{
		float num = base.GetPercentMoveSpeedBonus();
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.MasterYiSkill3))
		{
			num += 0.25f + (float)(get_m_actor().GetSkillLevel(3) - 1) * 0.1f;
		}
		return num;
	}

	public virtual void GAKBAEKBHDA(Actor JMEDKCPCJNA)
	{
		HCGEFPLCCIE();
	}

	public virtual void FMCDBLMNGIJ()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			get_m_actor().m_animator.gameObject.SetActive(false);
			get_m_actor().m_navMeshAgent.enabled = false;
			get_m_actor().m_dontDamage = false;
			break;
		case 1:
			get_m_actor().get_m_buffsInfo().LIKOKCJNLLF((JGOOOBHDBCG.ACPICCBBPHF)65512);
			get_m_actor().m_multiSound.OJBKMOKGPID("skill1_missile");
			if (MFKPCKNJLMH != null)
			{
				MFKPCKNJLMH.SetActive(true);
			}
			break;
		case 2:
			get_m_actor().CreateParticle(string.Format(" ", get_m_actor().get_m_resourceName()), false);
			break;
		case 3:
			get_m_actor().m_multiSound.MNKCLFBCGGA("Refresh");
			break;
		}
	}

	public override void OnKillHero(Actor JMEDKCPCJNA)
	{
		HCGEFPLCCIE();
	}

	private float JDDJHKNFLGE()
	{
		float result = 1470f;
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)125))
		{
			result = get_m_actor().get_m_phy_att_add() * 1948f;
			result += 229f + (float)(get_m_actor().GetSkillLevel(3) - 1) * 358f;
		}
		return result;
	}
}
