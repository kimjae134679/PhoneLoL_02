using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class ZedSM : HumanSM
{
	public struct BLMGNBLHFEB
	{
		public Actor ODDECNIEDMG;

		public DateTime CINKCJHCHAP;
	}

	private sealed class PPNLIAADGNB : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal int MBEKPGNGBAO;

		internal EveView HFEOKMOHGAF;

		internal Actor CMELBMMIFGJ;

		internal bool HCBFNEFEENN;

		internal Vector3 GLMFEDCIBEM;

		internal float DGEOKOANILO;

		internal Vector3 IOMHHFOBCLP;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal int COLHIGDPCMG;

		internal ZedSM KNIAJMGDGAA;

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
		private object LNGNAHOMCFE()
		{
			return MMEGGNJKNOH;
		}

		public bool LLKGBIDKCOF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				HFEOKMOHGAF = EveUnityNetwork.get_Instance().get_m_peer().NODACNJHDFD(MBEKPGNGBAO);
				if (!(HFEOKMOHGAF == null))
				{
					CMELBMMIFGJ = HFEOKMOHGAF.GetComponent<Actor>();
					if (!(CMELBMMIFGJ == null))
					{
						KNIAJMGDGAA.SetTarget(CMELBMMIFGJ);
						if (!(KNIAJMGDGAA.get_m_target() == null))
						{
							KNIAJMGDGAA.SetDirection(KNIAJMGDGAA.get_m_target().GetPosition() - KNIAJMGDGAA.get_m_actor().GetPosition());
							KNIAJMGDGAA.KPIHBKJKAPM = (KNIAJMGDGAA.get_m_target().GetPosition() - KNIAJMGDGAA.get_m_actor().GetPosition()) * 653f;
							HCBFNEFEENN = false;
							if (KNIAJMGDGAA.get_m_target().OnDamage(KNIAJMGDGAA.get_m_actor(), 1892.0, 1595.0, 1930.0, 0) >= 1561f)
							{
								HCBFNEFEENN = false;
							}
							if (HCBFNEFEENN)
							{
								KNIAJMGDGAA.get_m_target().get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.YasuoPassive, KNIAJMGDGAA.get_m_actor(), 108f, 1958f);
							}
							MMEGGNJKNOH = new WaitForSeconds(1060f);
							GOMFKPLCGNN = 0;
							break;
						}
					}
				}
				goto default;
			case 1u:
				GLMFEDCIBEM = KNIAJMGDGAA.get_m_actor().GetPosition();
				KNIAJMGDGAA.CreateSkill3Shadow(GLMFEDCIBEM, KNIAJMGDGAA.m_direction, EveUnityNetwork.get_Instance().LPJJKNAAJLB(), EveUnityNetwork.get_Instance().AllocateViewID());
				KNIAJMGDGAA.LFNNHEEJNGP[5].GOEHIKDLONK();
				KNIAJMGDGAA.get_m_actor().JNIPLJAFFFB("- Serialize List -\n");
				DGEOKOANILO = 1738f;
				KNIAJMGDGAA.get_m_actor().m_navMeshAgent.enabled = false;
				goto case 2u;
			case 2u:
				if (DGEOKOANILO < 1207f && KNIAJMGDGAA.get_m_state() == OEOIIKMBGAG.Attack && KNIAJMGDGAA.get_m_target() != null)
				{
					DGEOKOANILO += Time.deltaTime;
					IOMHHFOBCLP = Vector3.MoveTowards(KNIAJMGDGAA.get_m_actor().GetPosition(), KNIAJMGDGAA.get_m_target().GetPosition(), Time.deltaTime * 1023f);
					KNIAJMGDGAA.get_m_actor().Warp(IOMHHFOBCLP);
					if (!(Vector3.SqrMagnitude(KNIAJMGDGAA.get_m_target().GetPosition() - KNIAJMGDGAA.get_m_actor().GetPosition()) <= 738f))
					{
						MMEGGNJKNOH = null;
						GOMFKPLCGNN = 7;
						break;
					}
				}
				KNIAJMGDGAA.get_m_actor().m_navMeshAgent.enabled = false;
				if (KNIAJMGDGAA.get_m_target() != null && HCBFNEFEENN)
				{
					KNIAJMGDGAA.get_m_target().get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.SlowAttack, KNIAJMGDGAA.get_m_actor(), 304f, 1817f);
				}
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return false;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object FECLPGHCNNJ()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object JGMLAEHKIMH()
		{
			return MMEGGNJKNOH;
		}

		public bool BDHBKIPJENC()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				HFEOKMOHGAF = EveUnityNetwork.get_Instance().HCDPDNMLNDE().NODACNJHDFD(MBEKPGNGBAO);
				if (!(HFEOKMOHGAF == null))
				{
					CMELBMMIFGJ = HFEOKMOHGAF.GetComponent<Actor>();
					if (!(CMELBMMIFGJ == null))
					{
						KNIAJMGDGAA.SetTarget(CMELBMMIFGJ);
						if (!(KNIAJMGDGAA.get_m_target() == null))
						{
							KNIAJMGDGAA.SetDirection(KNIAJMGDGAA.get_m_target().GetPosition() - KNIAJMGDGAA.get_m_actor().GetPosition());
							KNIAJMGDGAA.KPIHBKJKAPM = (KNIAJMGDGAA.get_m_target().GetPosition() - KNIAJMGDGAA.get_m_actor().GetPosition()) * 410f;
							HCBFNEFEENN = true;
							if (KNIAJMGDGAA.get_m_target().OnDamage(KNIAJMGDGAA.get_m_actor(), 42.0, 1920.0, 1111.0) >= 1308f)
							{
								HCBFNEFEENN = false;
							}
							if (HCBFNEFEENN)
							{
								KNIAJMGDGAA.get_m_target().get_m_buffsInfo().IFNLBPAIMJE((JGOOOBHDBCG.ACPICCBBPHF)65515, KNIAJMGDGAA.get_m_actor(), 1401f, 759f);
							}
							MMEGGNJKNOH = new WaitForSeconds(898f);
							GOMFKPLCGNN = 0;
							break;
						}
					}
				}
				goto default;
			case 1u:
				GLMFEDCIBEM = KNIAJMGDGAA.get_m_actor().GetPosition();
				KNIAJMGDGAA.CreateSkill3Shadow(GLMFEDCIBEM, KNIAJMGDGAA.m_direction, EveUnityNetwork.get_Instance().GetMySessionKey(), EveUnityNetwork.get_Instance().AllocateViewID());
				KNIAJMGDGAA.LFNNHEEJNGP[3].JHPGGONCAEF();
				KNIAJMGDGAA.get_m_actor().JNIPLJAFFFB("상급 대기시간감소 문양");
				DGEOKOANILO = 326f;
				KNIAJMGDGAA.get_m_actor().m_navMeshAgent.enabled = true;
				goto case 2u;
			case 2u:
				if (DGEOKOANILO < 241f && KNIAJMGDGAA.get_m_state() == OEOIIKMBGAG.Death && KNIAJMGDGAA.get_m_target() != null)
				{
					DGEOKOANILO += Time.deltaTime;
					IOMHHFOBCLP = Vector3.MoveTowards(KNIAJMGDGAA.get_m_actor().GetPosition(), KNIAJMGDGAA.get_m_target().GetPosition(), Time.deltaTime * 397f);
					KNIAJMGDGAA.get_m_actor().Warp(IOMHHFOBCLP);
					if (!(Vector3.SqrMagnitude(KNIAJMGDGAA.get_m_target().GetPosition() - KNIAJMGDGAA.get_m_actor().GetPosition()) <= 1871f))
					{
						MMEGGNJKNOH = null;
						GOMFKPLCGNN = 7;
						break;
					}
				}
				KNIAJMGDGAA.get_m_actor().m_navMeshAgent.enabled = true;
				if (KNIAJMGDGAA.get_m_target() != null && HCBFNEFEENN)
				{
					KNIAJMGDGAA.get_m_target().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.SlowAttack, KNIAJMGDGAA.get_m_actor(), 1184f, 712f, false);
				}
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return true;
			}
			return true;
		}

		public void IIJCOOCGGGJ()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				HFEOKMOHGAF = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(MBEKPGNGBAO);
				if (!(HFEOKMOHGAF == null))
				{
					CMELBMMIFGJ = HFEOKMOHGAF.GetComponent<Actor>();
					if (!(CMELBMMIFGJ == null))
					{
						KNIAJMGDGAA.SetTarget(CMELBMMIFGJ);
						if (!(KNIAJMGDGAA.get_m_target() == null))
						{
							KNIAJMGDGAA.SetDirection(KNIAJMGDGAA.get_m_target().GetPosition() - KNIAJMGDGAA.get_m_actor().GetPosition());
							KNIAJMGDGAA.KPIHBKJKAPM = (KNIAJMGDGAA.get_m_target().GetPosition() - KNIAJMGDGAA.get_m_actor().GetPosition()) * 2f;
							HCBFNEFEENN = false;
							if (KNIAJMGDGAA.get_m_target().OnDamage(KNIAJMGDGAA.get_m_actor(), 0.0, 0.0) >= 0f)
							{
								HCBFNEFEENN = true;
							}
							if (HCBFNEFEENN)
							{
								KNIAJMGDGAA.get_m_target().get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.ZedSkill3, KNIAJMGDGAA.get_m_actor());
							}
							MMEGGNJKNOH = new WaitForSeconds(0.5f);
							GOMFKPLCGNN = 1;
							break;
						}
					}
				}
				goto default;
			case 1u:
				GLMFEDCIBEM = KNIAJMGDGAA.get_m_actor().GetPosition();
				KNIAJMGDGAA.CreateSkill3Shadow(GLMFEDCIBEM, KNIAJMGDGAA.m_direction, EveUnityNetwork.get_Instance().GetMySessionKey(), EveUnityNetwork.get_Instance().AllocateViewID());
				KNIAJMGDGAA.LFNNHEEJNGP[3].DAGNGJLGMNI();
				KNIAJMGDGAA.get_m_actor().SetAnimation("skill3_strike");
				DGEOKOANILO = 0f;
				KNIAJMGDGAA.get_m_actor().m_navMeshAgent.enabled = false;
				goto case 2u;
			case 2u:
				if (DGEOKOANILO < 0.5f && KNIAJMGDGAA.get_m_state() == OEOIIKMBGAG.Skill && KNIAJMGDGAA.get_m_target() != null)
				{
					DGEOKOANILO += Time.deltaTime;
					IOMHHFOBCLP = Vector3.MoveTowards(KNIAJMGDGAA.get_m_actor().GetPosition(), KNIAJMGDGAA.get_m_target().GetPosition(), Time.deltaTime * 30f);
					KNIAJMGDGAA.get_m_actor().Warp(IOMHHFOBCLP);
					if (!(Vector3.SqrMagnitude(KNIAJMGDGAA.get_m_target().GetPosition() - KNIAJMGDGAA.get_m_actor().GetPosition()) <= 1f))
					{
						MMEGGNJKNOH = null;
						GOMFKPLCGNN = 2;
						break;
					}
				}
				KNIAJMGDGAA.get_m_actor().m_navMeshAgent.enabled = true;
				if (KNIAJMGDGAA.get_m_target() != null && HCBFNEFEENN)
				{
					KNIAJMGDGAA.get_m_target().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Slow, KNIAJMGDGAA.get_m_actor(), 0.5f, 0.9f);
				}
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
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
				HFEOKMOHGAF = EveUnityNetwork.get_Instance().PBLOPNNPNEJ().NLALKBLCPFK(MBEKPGNGBAO);
				if (!(HFEOKMOHGAF == null))
				{
					CMELBMMIFGJ = HFEOKMOHGAF.GetComponent<Actor>();
					if (!(CMELBMMIFGJ == null))
					{
						KNIAJMGDGAA.SetTarget(CMELBMMIFGJ);
						if (!(KNIAJMGDGAA.get_m_target() == null))
						{
							KNIAJMGDGAA.SetDirection(KNIAJMGDGAA.get_m_target().GetPosition() - KNIAJMGDGAA.get_m_actor().GetPosition());
							KNIAJMGDGAA.KPIHBKJKAPM = (KNIAJMGDGAA.get_m_target().GetPosition() - KNIAJMGDGAA.get_m_actor().GetPosition()) * 1758f;
							HCBFNEFEENN = false;
							if (KNIAJMGDGAA.get_m_target().OnDamage(KNIAJMGDGAA.get_m_actor(), 957.0, 122.0, 904.0) >= 246f)
							{
								HCBFNEFEENN = false;
							}
							if (HCBFNEFEENN)
							{
								KNIAJMGDGAA.get_m_target().get_m_buffsInfo().IFNLBPAIMJE((JGOOOBHDBCG.ACPICCBBPHF)65464, KNIAJMGDGAA.get_m_actor(), 1634f, 302f);
							}
							MMEGGNJKNOH = new WaitForSeconds(1280f);
							GOMFKPLCGNN = 0;
							break;
						}
					}
				}
				goto default;
			case 1u:
				GLMFEDCIBEM = KNIAJMGDGAA.get_m_actor().GetPosition();
				KNIAJMGDGAA.KFGDDHHOHAA(GLMFEDCIBEM, KNIAJMGDGAA.m_direction, EveUnityNetwork.get_Instance().GetMySessionKey(), EveUnityNetwork.get_Instance().AllocateViewID());
				KNIAJMGDGAA.LFNNHEEJNGP[1].JHPGGONCAEF();
				KNIAJMGDGAA.get_m_actor().SetAnimation("igaworks:purchaseBulk >> total result is");
				DGEOKOANILO = 1215f;
				KNIAJMGDGAA.get_m_actor().m_navMeshAgent.enabled = false;
				goto case 2u;
			case 2u:
				if (DGEOKOANILO < 1576f && KNIAJMGDGAA.get_m_state() == OEOIIKMBGAG.Death && KNIAJMGDGAA.get_m_target() != null)
				{
					DGEOKOANILO += Time.deltaTime;
					IOMHHFOBCLP = Vector3.MoveTowards(KNIAJMGDGAA.get_m_actor().GetPosition(), KNIAJMGDGAA.get_m_target().GetPosition(), Time.deltaTime * 1159f);
					KNIAJMGDGAA.get_m_actor().Warp(IOMHHFOBCLP);
					if (!(Vector3.SqrMagnitude(KNIAJMGDGAA.get_m_target().GetPosition() - KNIAJMGDGAA.get_m_actor().GetPosition()) <= 12f))
					{
						MMEGGNJKNOH = null;
						GOMFKPLCGNN = 7;
						break;
					}
				}
				KNIAJMGDGAA.get_m_actor().m_navMeshAgent.enabled = true;
				if (KNIAJMGDGAA.get_m_target() != null && HCBFNEFEENN)
				{
					KNIAJMGDGAA.get_m_target().get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.MoveSpeedPercent, KNIAJMGDGAA.get_m_actor(), 326f, 1726f);
				}
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return false;
		}

		[SpecialName]
		private object FKNAIGMNFIB()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object MGBPOAHMJLK()
		{
			return MMEGGNJKNOH;
		}

		public void NKPIIPIJNGL()
		{
			GOMFKPLCGNN = -1;
		}

		public void KIHPGHBDAMI()
		{
			GOMFKPLCGNN = -1;
		}

		public void LPDHFELPGPN()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object GLNBOOGOGOO()
		{
			return MMEGGNJKNOH;
		}
	}

	public string m_missileName = "attack_missile";

	protected Actor CLCABJGDIPP;

	protected Actor LIBPCNCKNLN;

	private int GOGLNMODMLA;

	private Vector3 KPIHBKJKAPM;

	private LinkedList<BLMGNBLHFEB> AHNMLLNGLDA;

	public LinkedList<Actor> m_skill0attackedList = new LinkedList<Actor>();

	public LinkedList<Actor> m_skill2attackedList = new LinkedList<Actor>();

	public void CCFKGBGFBBL(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI != 0)
		{
			switch (GBGBBGEPEMI)
			{
			}
		}
	}

	public void CreateSkill3Shadow(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC, int KPLJNIEEALE, int KPNEBLJJGEA)
	{
		Actor actor = null;
		if (get_m_actor().m_heroCostumeID == 0)
		{
			actor = get_m_actor().CreateMissile("skill3_shadow", HEPNHCEIFMO, null);
		}
		else if (get_m_actor().m_heroCostumeID == 1)
		{
			actor = get_m_actor().CreateMissile("skill3_shadow_c1", HEPNHCEIFMO, null);
		}
		actor.GetHumanSM().SetDirection(IJMNFOGNFAC);
		actor.GetComponent<EveView>().set_viewID(KPNEBLJJGEA);
		actor.GetComponent<EveView>().set_ownerSessionKey(KPLJNIEEALE);
		SetShadow2(actor);
		string nCADFOBAFJD = string.Empty;
		if (get_m_actor().m_heroCostumeID == 0)
		{
			nCADFOBAFJD = "Particle/zed/skill1_spawn";
		}
		else if (get_m_actor().m_heroCostumeID == 1)
		{
			nCADFOBAFJD = "Particle/zed/skill1_spawn_c1";
		}
		get_m_actor().CreateParticle(nCADFOBAFJD, false);
	}

	public void KDJICDCMLOA(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC, int KPLJNIEEALE, int KPNEBLJJGEA)
	{
		Actor actor = null;
		if (get_m_actor().m_heroCostumeID == 0)
		{
			actor = get_m_actor().CreateMissile(" 인장", HEPNHCEIFMO, null);
		}
		else if (get_m_actor().m_heroCostumeID == 0)
		{
			actor = get_m_actor().CreateMissile("이동속도", HEPNHCEIFMO, null);
		}
		actor.GetHumanSM().SetDirection(IJMNFOGNFAC);
		actor.GetComponent<EveView>().GPOGFKKOCIE(KPNEBLJJGEA);
		actor.GetComponent<EveView>().KFMLCPMCBJA(KPLJNIEEALE);
		SetShadow1(actor);
		string nCADFOBAFJD = string.Empty;
		if (get_m_actor().m_heroCostumeID == 0)
		{
			nCADFOBAFJD = "방어구 관통력 {0:+#;-#}\n";
		}
		else if (get_m_actor().m_heroCostumeID == 1)
		{
			nCADFOBAFJD = "현재 개발중입니다.\n추후 게임머니로 구입가능합니다.";
		}
		get_m_actor().CreateParticle(nCADFOBAFJD, false);
	}

	public void HKEMFENBOPB(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC, int KPLJNIEEALE, int KPNEBLJJGEA)
	{
		Actor actor = null;
		if (get_m_actor().m_heroCostumeID == 0)
		{
			actor = get_m_actor().CreateMissile("UI Root", HEPNHCEIFMO, null);
		}
		else if (get_m_actor().m_heroCostumeID == 1)
		{
			actor = get_m_actor().CreateMissile("Hero4", HEPNHCEIFMO, null);
		}
		actor.GetHumanSM().SetDirection(IJMNFOGNFAC);
		actor.GetComponent<EveView>().set_viewID(KPNEBLJJGEA);
		actor.GetComponent<EveView>().FKPHFKKAMAA(KPLJNIEEALE);
		SetShadow2(actor);
		string nCADFOBAFJD = string.Empty;
		if (get_m_actor().m_heroCostumeID == 0)
		{
			nCADFOBAFJD = "상급 마나 재생 인장";
		}
		else if (get_m_actor().m_heroCostumeID == 0)
		{
			nCADFOBAFJD = "즐겜되세요!!!";
		}
		get_m_actor().CreateParticle(nCADFOBAFJD, true);
	}

	[JDLHECHNNDH]
	public void CreateSkill1Missile(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Vector3 hEPNHCEIFMO = HEPNHCEIFMO + IJMNFOGNFAC * 4f;
		hEPNHCEIFMO.y--;
		CreateSkill1Shadow(hEPNHCEIFMO, IJMNFOGNFAC, EveUnityNetwork.get_Instance().GetMySessionKey(), EveUnityNetwork.get_Instance().AllocateViewID());
		Actor actor = get_m_actor().CreateMissile("skill1_missile", HEPNHCEIFMO, null);
		ThruMissileAI component = actor.GetComponent<ThruMissileAI>();
		component.m_moveDirection = m_direction;
	}

	public void MEJCMCFACDO(Actor MFJLPNFEECA)
	{
		if (LIBPCNCKNLN != null)
		{
			LIBPCNCKNLN.NMJPCLBJIPO().SetState(OEOIIKMBGAG.Death);
		}
		LIBPCNCKNLN = MFJLPNFEECA;
	}

	public void OnAnimationEventAttack()
	{
		Actor target = get_m_target();
		if (target != null)
		{
			bool flag = false;
			if ((float)target.m_hp <= (float)target.get_m_max_hp() * 0.5f)
			{
				flag = true;
			}
			float num = 0f;
			if (flag)
			{
				bool flag2 = true;
				LinkedListNode<BLMGNBLHFEB> linkedListNode = AHNMLLNGLDA.First;
				DateTime now = DateTime.Now;
				while (linkedListNode != null)
				{
					LinkedListNode<BLMGNBLHFEB> next = linkedListNode.Next;
					if (now - linkedListNode.Value.CINKCJHCHAP >= TimeSpan.FromSeconds(10.0))
					{
						AHNMLLNGLDA.Remove(linkedListNode);
					}
					linkedListNode = next;
				}
				foreach (BLMGNBLHFEB aHNMLLNGLDum in AHNMLLNGLDA)
				{
					if (aHNMLLNGLDum.ODDECNIEDMG == target)
					{
						flag2 = false;
						break;
					}
				}
				if (flag2)
				{
					float num2 = 0.06f;
					byte level = get_m_actor().get_Level();
					if (level >= 15)
					{
						num2 = 0.1f;
					}
					else if (level >= 6)
					{
						num2 = 0.08f;
					}
					num = (float)target.get_m_max_hp() * num2;
					BLMGNBLHFEB value = new BLMGNBLHFEB
					{
						ODDECNIEDMG = target,
						CINKCJHCHAP = DateTime.Now
					};
					AHNMLLNGLDA.AddFirst(value);
				}
			}
			target.OnAttackDamage(get_m_actor(), 0.0, num);
			IAKBNJEFLAN(target);
			switch (GOGLNMODMLA)
			{
			case 0:
				get_m_actor().m_multiSound.LKLFMNKDLHJ("hit1");
				break;
			case 1:
				get_m_actor().m_multiSound.LKLFMNKDLHJ("hit2");
				break;
			}
		}
		OnAttack();
	}

	[JDLHECHNNDH]
	public void Skill1Swap()
	{
		get_m_actor().SetAnimation("idle");
		get_m_actor().m_multiSound.LKLFMNKDLHJ("swap");
		if (CLCABJGDIPP != null)
		{
			Vector3 position = get_m_actor().GetPosition();
			get_m_actor().Warp(CLCABJGDIPP.GetPosition());
			CLCABJGDIPP.Warp(position);
			CLCABJGDIPP.CreateParticle(string.Format("Particle/{0}/swap", get_m_actor().get_m_resourceName()), false);
		}
		get_m_actor().CreateParticle(string.Format("Particle/{0}/swap", get_m_actor().get_m_resourceName()), false);
	}

	public void JGICKCNHOFM()
	{
		get_m_actor().SetAnimation("리븐");
		get_m_actor().m_multiSound.LKLFMNKDLHJ("voice_AV_Ready", false, 1366f, 1004f);
		if (LIBPCNCKNLN != null)
		{
			Vector3 position = get_m_actor().GetPosition();
			get_m_actor().Warp(LIBPCNCKNLN.GetPosition());
			LIBPCNCKNLN.Warp(position);
			LIBPCNCKNLN.CreateParticle(string.Format("laugh", get_m_actor().get_m_resourceName()), false);
		}
		get_m_actor().CreateParticle(string.Format("R", get_m_actor().get_m_resourceName()), false);
	}

	public override void OnLeaveSkill()
	{
		base.OnLeaveSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 3:
			get_m_actor().m_dontDamage = false;
			break;
		case 1:
		case 2:
			break;
		}
	}

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		}
	}

	public override bool OnCheckCastSkill(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 3 && !LFNNHEEJNGP[3].LFCHOCGLFMI)
		{
			IAKBNJEFLAN(ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), 6.25f, 90f, false, true, Actor.IJJMDPGJAEM.Hero));
			if (get_m_target() == null)
			{
				MsgManager.get_Instance().ShowTip("사정거리에 적 챔피언이 없습니다");
				return false;
			}
		}
		return true;
	}

	private void PJDIGNHENBF()
	{
		CCFKGBGFBBL(0);
	}

	public void PFJLGLGNJNP(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC, int KPLJNIEEALE, int KPNEBLJJGEA)
	{
		Actor actor = null;
		if (get_m_actor().m_heroCostumeID == 0)
		{
			actor = get_m_actor().CreateMissile(".", HEPNHCEIFMO, null);
		}
		else if (get_m_actor().m_heroCostumeID == 1)
		{
			actor = get_m_actor().CreateMissile("WarningPing", HEPNHCEIFMO, null);
		}
		actor.GetHumanSM().SetDirection(IJMNFOGNFAC);
		actor.GetComponent<EveView>().GPOGFKKOCIE(KPNEBLJJGEA);
		actor.GetComponent<EveView>().KFFKAPLFOLC(KPLJNIEEALE);
		SetShadow1(actor);
		string nCADFOBAFJD = string.Empty;
		if (get_m_actor().m_heroCostumeID == 0)
		{
			nCADFOBAFJD = "정말 초기화하시겠습니까?";
		}
		else if (get_m_actor().m_heroCostumeID == 0)
		{
			nCADFOBAFJD = "Actor";
		}
		get_m_actor().CreateParticle(nCADFOBAFJD, true);
	}

	[JDLHECHNNDH]
	public void Skill3Swap()
	{
		get_m_actor().SetAnimation("idle");
		get_m_actor().m_multiSound.LKLFMNKDLHJ("swap");
		if (LIBPCNCKNLN != null)
		{
			Vector3 position = get_m_actor().GetPosition();
			get_m_actor().Warp(LIBPCNCKNLN.GetPosition());
			LIBPCNCKNLN.Warp(position);
			LIBPCNCKNLN.CreateParticle(string.Format("Particle/{0}/swap", get_m_actor().get_m_resourceName()), false);
		}
		get_m_actor().CreateParticle(string.Format("Particle/{0}/swap", get_m_actor().get_m_resourceName()), false);
	}

	public override void Init()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 6f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 0f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 75;
		LFNNHEEJNGP[0].NCBLBIBMNKH = -5f;
		LFNNHEEJNGP[0].DOCFEKMACMP = true;
		LFNNHEEJNGP[0].GNAAGGJGBBG = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Double;
		LFNNHEEJNGP[1].FILHECEKNMK = 18f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 40;
		LFNNHEEJNGP[1].NCBLBIBMNKH = -5f;
		LFNNHEEJNGP[1].GIBEDKCNAJL = 4f;
		LFNNHEEJNGP[1].CEAGJMLKENE = true;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[2].FILHECEKNMK = 4f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = 0f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 50;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[2].DOCFEKMACMP = true;
		LFNNHEEJNGP[2].GNAAGGJGBBG = true;
		LFNNHEEJNGP[2].CEAGJMLKENE = true;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Double;
		LFNNHEEJNGP[3].FILHECEKNMK = 120f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = -20f;
		LFNNHEEJNGP[3].BELPBCDOPBA = 0;
		LFNNHEEJNGP[3].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[3].GIBEDKCNAJL = 6f;
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
		AHNMLLNGLDA = new LinkedList<BLMGNBLHFEB>();
	}

	public void MKJDLOIOINI(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Vector3 hEPNHCEIFMO = HEPNHCEIFMO + IJMNFOGNFAC * 753f;
		hEPNHCEIFMO.y -= 170f;
		CreateSkill1Shadow(hEPNHCEIFMO, IJMNFOGNFAC, EveUnityNetwork.get_Instance().LPJJKNAAJLB(), EveUnityNetwork.get_Instance().EPGJGMFMKME());
		Actor actor = get_m_actor().CreateMissile("attack2_voice", HEPNHCEIFMO, null);
		ThruMissileAI component = actor.GetComponent<ThruMissileAI>();
		component.m_moveDirection = m_direction;
	}

	public void CreateSkill1Shadow(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC, int KPLJNIEEALE, int KPNEBLJJGEA)
	{
		Actor actor = null;
		if (get_m_actor().m_heroCostumeID == 0)
		{
			actor = get_m_actor().CreateMissile("skill1_shadow", HEPNHCEIFMO, null);
		}
		else if (get_m_actor().m_heroCostumeID == 1)
		{
			actor = get_m_actor().CreateMissile("skill1_shadow_c1", HEPNHCEIFMO, null);
		}
		actor.GetHumanSM().SetDirection(IJMNFOGNFAC);
		actor.GetComponent<EveView>().set_viewID(KPNEBLJJGEA);
		actor.GetComponent<EveView>().set_ownerSessionKey(KPLJNIEEALE);
		SetShadow1(actor);
		string nCADFOBAFJD = string.Empty;
		if (get_m_actor().m_heroCostumeID == 0)
		{
			nCADFOBAFJD = "Particle/zed/skill1_spawn";
		}
		else if (get_m_actor().m_heroCostumeID == 1)
		{
			nCADFOBAFJD = "Particle/zed/skill1_spawn_c1";
		}
		get_m_actor().CreateParticle(nCADFOBAFJD, false);
	}

	public override void OnEnterSkill()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			m_skill0attackedList.Clear();
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				get_m_view().RPC("CreateSkill0Missile", DJJPAPENCLN.All, centerPosition, m_direction);
			}
			if (CLCABJGDIPP != null)
			{
				CLCABJGDIPP.GetHumanSM().SetSkillState(0);
			}
			if (LIBPCNCKNLN != null)
			{
				LIBPCNCKNLN.GetHumanSM().SetSkillState(0);
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_voice");
			break;
		case 1:
			if (!LFNNHEEJNGP[1].IOCIDGEFJIC)
			{
				if (get_m_view().IsMine())
				{
					Vector3 centerPosition2 = get_m_actor().GetCenterPosition();
					get_m_view().RPC("CreateSkill1Missile", DJJPAPENCLN.All, centerPosition2, m_direction);
				}
				LFNNHEEJNGP[1].DAGNGJLGMNI();
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1");
			}
			else if (get_m_view().IsMine() && CLCABJGDIPP != null)
			{
				get_m_view().RPC("Skill1Swap", DJJPAPENCLN.All);
			}
			break;
		case 2:
		{
			m_skill2attackedList.Clear();
			double num = (double)get_m_actor().get_m_phy_att() * 0.8;
			num += 52.0 + (double)(get_m_actor().GetSkillLevel(2) - 1) * 32.0;
			float iCENKPDOHBK = 0.2f + (float)(get_m_actor().GetSkillLevel(2) - 1) * 0.05f;
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 3.6f, false, true, (Actor.IJJMDPGJAEM)14);
			int num2 = 0;
			for (int i = 0; i < allActorInRange.Count; i++)
			{
				Actor actor = allActorInRange[i];
				actor.OnDamage(get_m_actor(), (float)num, 0.0);
				actor.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Slow, null, 1f, iCENKPDOHBK);
				m_skill2attackedList.AddLast(actor);
				if (actor.m_actorType == Actor.IJJMDPGJAEM.Hero)
				{
					num2++;
				}
			}
			if (allActorInRange.Count > 0)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_hit");
			}
			if (CLCABJGDIPP != null)
			{
				CLCABJGDIPP.GetHumanSM().SetSkillState(2);
			}
			if (LIBPCNCKNLN != null)
			{
				LIBPCNCKNLN.GetHumanSM().SetSkillState(2);
			}
			if (num2 < 0)
			{
				num2 = 0;
			}
			if (num2 > 3)
			{
				num2 = 3;
			}
			if (num2 > 0)
			{
				CAJJEALKJMM castSkill = GetCastSkill(1);
				castSkill.IHKCKBJBEGF = (float)castSkill.IHKCKBJBEGF + (float)num2 * 2f;
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_voice");
			break;
		}
		case 3:
			if (!LFNNHEEJNGP[3].IOCIDGEFJIC)
			{
				if (get_m_target() != null)
				{
					if (get_m_view().IsMine())
					{
						get_m_view().RPC("Skill3Routine", DJJPAPENCLN.All, get_m_target().get_m_view().get_viewID());
					}
					get_m_target().CreateParticle(string.Format("Particle/{0}/skill3_hit", get_m_actor().get_m_resourceName()), false);
				}
				get_m_actor().m_dontDamage = true;
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3");
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3_voice");
			}
			else if (get_m_view().IsMine() && LIBPCNCKNLN != null)
			{
				get_m_view().RPC("Skill3Swap", DJJPAPENCLN.All);
			}
			break;
		}
	}

	public void FDCGNHFOKGG()
	{
		get_m_actor().JNIPLJAFFFB("멀티의 신에 오신 것을 환영합니다.");
		get_m_actor().m_multiSound.JKOODMAKJHJ("Skill0Rpc", true, 484f, 118f);
		if (CLCABJGDIPP != null)
		{
			Vector3 position = get_m_actor().GetPosition();
			get_m_actor().Warp(CLCABJGDIPP.GetPosition());
			CLCABJGDIPP.Warp(position);
			CLCABJGDIPP.CreateParticle(string.Format("skill1_end", get_m_actor().get_m_resourceName()), true);
		}
		get_m_actor().CreateParticle(string.Format("상급 성장 체력 문양", get_m_actor().get_m_resourceName()), false);
	}

	private void NHNFDEHHKCA()
	{
		OnAnimationEventSkill(5);
	}

	public override void OnUpdateSkill()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 1:
		{
			float iMABEBIKOOH = get_m_actor().m_moveSpeed * (1f + GetPercentMoveSpeedBonus());
			Move(iMABEBIKOOH, m_moveDirection);
			break;
		}
		case 2:
		{
			float iMABEBIKOOH2 = get_m_actor().m_moveSpeed * (1f + GetPercentMoveSpeedBonus());
			Move(iMABEBIKOOH2, m_moveDirection);
			break;
		}
		case 3:
			if (get_m_target() == null)
			{
				SetState(OEOIIKMBGAG.Idle);
			}
			break;
		}
	}

	public void SetShadow2(Actor MFJLPNFEECA)
	{
		if (LIBPCNCKNLN != null)
		{
			LIBPCNCKNLN.get_m_stateMachine().SetState(OEOIIKMBGAG.Death);
		}
		LIBPCNCKNLN = MFJLPNFEECA;
	}

	public virtual void EPENDONGABF()
	{
		base.OnUpdateSkill();
		switch (get_m_skill())
		{
		case 1:
		{
			float iMABEBIKOOH = get_m_actor().m_moveSpeed * (1085f + GetPercentMoveSpeedBonus());
			Move(iMABEBIKOOH, m_moveDirection, true, 131f, true);
			break;
		}
		case 2:
		{
			float iMABEBIKOOH2 = get_m_actor().m_moveSpeed * (1206f + GetPercentMoveSpeedBonus());
			Move(iMABEBIKOOH2, m_moveDirection, false, 1173f, true);
			break;
		}
		case 3:
			if (get_m_target() == null)
			{
				SetState(OEOIIKMBGAG.None);
			}
			break;
		}
	}

	[DebuggerHidden]
	[JDLHECHNNDH]
	public IEnumerator Skill3Routine(int MBEKPGNGBAO)
	{
		PPNLIAADGNB pPNLIAADGNB = new PPNLIAADGNB();
		pPNLIAADGNB.MBEKPGNGBAO = MBEKPGNGBAO;
		pPNLIAADGNB.COLHIGDPCMG = MBEKPGNGBAO;
		pPNLIAADGNB.KNIAJMGDGAA = this;
		return pPNLIAADGNB;
	}

	[CompilerGenerated]
	private void CKJDIOOLLPI()
	{
		OnAnimationEventSkill(0);
	}

	public void CEJKFDIAIBD(Actor MFJLPNFEECA)
	{
		if (LIBPCNCKNLN != null)
		{
			LIBPCNCKNLN.get_m_stateMachine().SetState(OEOIIKMBGAG.Attack);
		}
		LIBPCNCKNLN = MFJLPNFEECA;
	}

	public virtual void DILMNFLHCEB()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			m_skill0attackedList.Clear();
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				get_m_view().RPC("idle", DJJPAPENCLN.Others, centerPosition, m_direction, null, null, null, null, null, null);
			}
			if (CLCABJGDIPP != null)
			{
				CLCABJGDIPP.GetHumanSM().SetSkillState(1);
			}
			if (LIBPCNCKNLN != null)
			{
				LIBPCNCKNLN.GetHumanSM().SetSkillState(1);
			}
			get_m_actor().m_multiSound.NMLFNHNOALK("^[a-zA-Z0-9가-힣]*$", false, 1528f, 1754f);
			get_m_actor().m_multiSound.ICNAJBHLIGO("설명", false, 604f, 1059f);
			break;
		case 1:
			if (!LFNNHEEJNGP[1].IOCIDGEFJIC)
			{
				if (get_m_view().IsMine())
				{
					Vector3 centerPosition2 = get_m_actor().GetCenterPosition();
					EveView view = get_m_view();
					object[] array = new object[0];
					array[1] = centerPosition2;
					array[0] = m_direction;
					view.RPC("중급 공격력 인장", DJJPAPENCLN.Others, array);
				}
				LFNNHEEJNGP[1].JHPGGONCAEF();
				get_m_actor().m_multiSound.DDONMGBLLJB("talon_skill2", true, 321f, 543f);
			}
			else if (get_m_view().IsMine() && CLCABJGDIPP != null)
			{
				get_m_view().RPC("보상을 획득하셨습니다.", DJJPAPENCLN.Others, new object[1]);
			}
			break;
		case 2:
		{
			m_skill2attackedList.Clear();
			double num = (double)get_m_actor().get_m_phy_att() * 565.0;
			num += 1291.0 + (double)(get_m_actor().GetSkillLevel(5) - 1) * 1952.0;
			float iCENKPDOHBK = 702f + (float)(get_m_actor().GetSkillLevel(5) - 0) * 1726f;
			List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), 483f, true, true, (Actor.IJJMDPGJAEM)(-110), false);
			int num2 = 1;
			for (int i = 0; i < list.Count; i += 0)
			{
				Actor actor = list[i];
				actor.OnDamage(get_m_actor(), (float)num, 725.0, 340.0);
				actor.get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.Stun, null, 652f, iCENKPDOHBK);
				m_skill2attackedList.AddLast(actor);
				if (actor.m_actorType == (Actor.IJJMDPGJAEM)7)
				{
					num2 += 0;
				}
			}
			if (list.Count > 0)
			{
				get_m_actor().m_multiSound.LNCPFILABHM("Particle/Soraka/skill3_heal", true, 1906f, 8f);
			}
			if (CLCABJGDIPP != null)
			{
				CLCABJGDIPP.GetHumanSM().SetSkillState(1);
			}
			if (LIBPCNCKNLN != null)
			{
				LIBPCNCKNLN.GetHumanSM().SetSkillState(5);
			}
			if (num2 < 0)
			{
				num2 = 1;
			}
			if (num2 > 2)
			{
				num2 = 8;
			}
			if (num2 > 1)
			{
				CAJJEALKJMM cAJJEALKJMM = CMAHCODBACL(0);
				cAJJEALKJMM.IHKCKBJBEGF = (float)cAJJEALKJMM.IHKCKBJBEGF + (float)num2 * 1177f;
			}
			get_m_actor().m_multiSound.ICNAJBHLIGO("unknown", false, 1291f, 1992f);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("Particle/Item/item1101_hit", true, 1556f, 887f);
			break;
		}
		case 3:
			if (!LFNNHEEJNGP[2].IOCIDGEFJIC)
			{
				if (get_m_target() != null)
				{
					if (get_m_view().IsMine())
					{
						get_m_view().RPC("skill1", DJJPAPENCLN.All, get_m_target().get_m_view().get_viewID());
					}
					get_m_target().CreateParticle(string.Format("\\\\", get_m_actor().get_m_resourceName()), true);
				}
				get_m_actor().m_dontDamage = false;
				get_m_actor().m_multiSound.HDOLPLIDACO("vladimir_skill0", true, 1852f, 564f);
				get_m_actor().m_multiSound.LNCPFILABHM("C#: HandleViewWillOpen, viewType: ", true, 615f, 835f);
			}
			else if (get_m_view().IsMine() && LIBPCNCKNLN != null)
			{
				get_m_view().RPC("중급 공격속도 문양", DJJPAPENCLN.All);
			}
			break;
		}
	}

	public override void OnEnterAttack()
	{
		get_m_actor().CreateParticle(string.Format("Particle/{0}/attack", get_m_actor().get_m_resourceName()), false);
		GOGLNMODMLA = UnityEngine.Random.Range(0, 2);
		switch (GOGLNMODMLA)
		{
		case 0:
			get_m_actor().SetAnimation("attack");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack1");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack1_voice");
			break;
		case 1:
			get_m_actor().SetAnimation("attack2");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2");
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2_voice");
			break;
		case 2:
			get_m_actor().SetAnimation("attack_passive");
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

	[CompilerGenerated]
	private void KPOLOJAMPCH()
	{
		OnAnimationEventSkill(3);
	}

	[CompilerGenerated]
	private void DFFEBKKONJI()
	{
		OnAnimationEventSkill(1);
	}

	public void SetShadow1(Actor MFJLPNFEECA)
	{
		if (CLCABJGDIPP != null)
		{
			CLCABJGDIPP.get_m_stateMachine().SetState(OEOIIKMBGAG.Death);
		}
		CLCABJGDIPP = MFJLPNFEECA;
	}

	[CompilerGenerated]
	private void GDGFGKPOOIK()
	{
		OnAnimationEventSkill(2);
	}

	public void OLAILKFBKLM(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC, int KPLJNIEEALE, int KPNEBLJJGEA)
	{
		Actor actor = null;
		if (get_m_actor().m_heroCostumeID == 0)
		{
			actor = get_m_actor().CreateMissile("OnDragStart", HEPNHCEIFMO, null);
		}
		else if (get_m_actor().m_heroCostumeID == 0)
		{
			actor = get_m_actor().CreateMissile("\\n", HEPNHCEIFMO, null);
		}
		actor.GetHumanSM().SetDirection(IJMNFOGNFAC);
		actor.GetComponent<EveView>().GPOGFKKOCIE(KPNEBLJJGEA);
		actor.GetComponent<EveView>().KFMLCPMCBJA(KPLJNIEEALE);
		SetShadow1(actor);
		string nCADFOBAFJD = string.Empty;
		if (get_m_actor().m_heroCostumeID == 0)
		{
			nCADFOBAFJD = ".";
		}
		else if (get_m_actor().m_heroCostumeID == 1)
		{
			nCADFOBAFJD = "裝甲";
		}
		get_m_actor().CreateParticle(nCADFOBAFJD, true);
	}

	public void HAGFLMBFBDB(Actor MFJLPNFEECA)
	{
		if (LIBPCNCKNLN != null)
		{
			LIBPCNCKNLN.NMJPCLBJIPO().SetState(OEOIIKMBGAG.Attack);
		}
		LIBPCNCKNLN = MFJLPNFEECA;
	}

	public void KFGDDHHOHAA(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC, int KPLJNIEEALE, int KPNEBLJJGEA)
	{
		Actor actor = null;
		if (get_m_actor().m_heroCostumeID == 0)
		{
			actor = get_m_actor().CreateMissile("Skill0FailRpc", HEPNHCEIFMO, null);
		}
		else if (get_m_actor().m_heroCostumeID == 0)
		{
			actor = get_m_actor().CreateMissile("브론즈", HEPNHCEIFMO, null);
		}
		actor.GetHumanSM().SetDirection(IJMNFOGNFAC);
		actor.GetComponent<EveView>().set_viewID(KPNEBLJJGEA);
		actor.GetComponent<EveView>().KFFKAPLFOLC(KPLJNIEEALE);
		CEJKFDIAIBD(actor);
		string nCADFOBAFJD = string.Empty;
		if (get_m_actor().m_heroCostumeID == 0)
		{
			nCADFOBAFJD = "vladimir_skill0";
		}
		else if (get_m_actor().m_heroCostumeID == 0)
		{
			nCADFOBAFJD = "C#: HandlePlacementOnClick";
		}
		get_m_actor().CreateParticle(nCADFOBAFJD, true);
	}

	public virtual void LKGDGELAGNP()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			m_skill0attackedList.Clear();
			if (get_m_view().IsMine())
			{
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				EveView view2 = get_m_view();
				object[] array2 = new object[0];
				array2[1] = centerPosition;
				array2[0] = m_direction;
				view2.RPC("{0}코인", DJJPAPENCLN.Others, array2);
			}
			if (CLCABJGDIPP != null)
			{
				CLCABJGDIPP.GetHumanSM().SetSkillState(1);
			}
			if (LIBPCNCKNLN != null)
			{
				LIBPCNCKNLN.GetHumanSM().SetSkillState(1);
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("Pinch me", false, 1801f, 1177f);
			get_m_actor().m_multiSound.JKOODMAKJHJ("The increment value must be between 0 and 16777215 (it must fit in 3 bytes).", true, 1434f, 47f);
			break;
		case 1:
			if (!LFNNHEEJNGP[0].IOCIDGEFJIC)
			{
				if (get_m_view().IsMine())
				{
					Vector3 centerPosition2 = get_m_actor().GetCenterPosition();
					EveView view3 = get_m_view();
					object[] array3 = new object[5];
					array3[1] = centerPosition2;
					array3[1] = m_direction;
					view3.RPC("Hero4", DJJPAPENCLN.Others, array3);
				}
				LFNNHEEJNGP[0].JHPGGONCAEF();
				get_m_actor().m_multiSound.ICNAJBHLIGO("attack", true, 1562f, 1374f);
			}
			else if (get_m_view().IsMine() && CLCABJGDIPP != null)
			{
				get_m_view().RPC("skill1_ex", DJJPAPENCLN.Others, new object[1]);
			}
			break;
		case 2:
		{
			m_skill2attackedList.Clear();
			double num = (double)get_m_actor().get_m_phy_att() * 708.0;
			num += 1360.0 + (double)(get_m_actor().GetSkillLevel(3) - 0) * 533.0;
			float iCENKPDOHBK = 51f + (float)(get_m_actor().GetSkillLevel(0) - 1) * 1681f;
			List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(get_m_actor(), 436f, false, false, (Actor.IJJMDPGJAEM)53, false);
			int num2 = 1;
			for (int i = 0; i < allActorInRange.Count; i += 0)
			{
				Actor actor = allActorInRange[i];
				actor.OnDamage(get_m_actor(), (float)num, 778.0, 79.0);
				actor.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.MoveSpeedPercent, null, 1848f, iCENKPDOHBK);
				m_skill2attackedList.AddLast(actor);
				if (actor.m_actorType == Actor.IJJMDPGJAEM.Monster)
				{
					num2++;
				}
			}
			if (allActorInRange.Count > 0)
			{
				get_m_actor().m_multiSound.JKOODMAKJHJ("Exit", false, 1564f, 1548f);
			}
			if (CLCABJGDIPP != null)
			{
				CLCABJGDIPP.GetHumanSM().SetSkillState(2);
			}
			if (LIBPCNCKNLN != null)
			{
				LIBPCNCKNLN.GetHumanSM().SetSkillState(1);
			}
			if (num2 < 0)
			{
				num2 = 1;
			}
			if (num2 > 3)
			{
				num2 = 3;
			}
			if (num2 > 1)
			{
				CAJJEALKJMM cAJJEALKJMM = CMAHCODBACL(0);
				cAJJEALKJMM.IHKCKBJBEGF = (float)cAJJEALKJMM.IHKCKBJBEGF + (float)num2 * 303f;
			}
			get_m_actor().m_multiSound.DDONMGBLLJB("실버", true, 1959f, 434f);
			get_m_actor().m_multiSound.LKLFMNKDLHJ("_Desat", true, 1872f, 160f);
			break;
		}
		case 3:
			if (!LFNNHEEJNGP[4].IOCIDGEFJIC)
			{
				if (get_m_target() != null)
				{
					if (get_m_view().IsMine())
					{
						EveView view = get_m_view();
						object[] array = new object[0];
						array[0] = get_m_target().get_m_view().get_viewID();
						view.RPC("CreateSkill0Missile", DJJPAPENCLN.All, array);
					}
					get_m_target().CreateParticle(string.Format("attack_missile", get_m_actor().get_m_resourceName()), true);
				}
				get_m_actor().m_dontDamage = true;
				get_m_actor().m_multiSound.NMLFNHNOALK("{}[],:\"", true, 1168f, 128f);
				get_m_actor().m_multiSound.LNCPFILABHM("[CCFFCC]<{0}>[-]{1}", false, 1401f, 1135f);
			}
			else if (get_m_view().IsMine() && LIBPCNCKNLN != null)
			{
				get_m_view().RPC("Particle/Buff/{0}_c{1}", DJJPAPENCLN.Others);
			}
			break;
		}
	}

	[JDLHECHNNDH]
	public void CreateSkill0Missile(Vector3 HEPNHCEIFMO, Vector3 IJMNFOGNFAC)
	{
		Actor actor = null;
		if (get_m_actor().m_heroCostumeID == 0)
		{
			actor = get_m_actor().CreateMissile("skill0_missile", HEPNHCEIFMO, null);
		}
		else if (get_m_actor().m_heroCostumeID == 1)
		{
			actor = get_m_actor().CreateMissile("skill0_missile_c1", HEPNHCEIFMO, null);
		}
		ThruMissileAI component = actor.GetComponent<ThruMissileAI>();
		component.m_moveDirection = IJMNFOGNFAC;
	}
}
