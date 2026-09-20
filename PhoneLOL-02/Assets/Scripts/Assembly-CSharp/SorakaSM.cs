using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class SorakaSM : HumanSM
{
	private sealed class GHCFGLNGANA
	{
		internal Vector3 HEPNHCEIFMO;

		internal void OAKELLBHFHG(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
		}

		internal void ELNIBMFKBNO(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
		}

		internal void CNNMGBPLJPA(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
		}

		internal void IEKHNAMIINN(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
		}

		internal void OMOIDBBNHCE(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
		}

		internal void FDGOOJDHEPJ(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
		}

		internal void JLDIHEKJCEF(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
		}

		internal void FLPDAPDHAAJ(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
		}

		internal void OKDGHJGGBAP(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
		}
	}

	private sealed class PCFIEMENDGI
	{
		internal Vector3 HEPNHCEIFMO;

		internal void OKMDOCAPNGN(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
		}

		internal void INPENLPHJDD(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
		}

		internal void HMEFMMHOHGP(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
		}

		internal void GEDPLHDCAAB(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
		}
	}

	private sealed class NFGHPFDLKNH
	{
		internal bool MMMLKLHEJOA;

		internal SorakaSM KNIAJMGDGAA;

		internal bool HBFJCDJDFBH(Actor CDKMPAEODLA)
		{
			if (CDKMPAEODLA.m_actorType != Actor.IJJMDPGJAEM.Monster)
			{
				return true;
			}
			if (CDKMPAEODLA.m_team != KNIAJMGDGAA.get_m_actor().m_team)
			{
				return false;
			}
			if (object.ReferenceEquals(CDKMPAEODLA, KNIAJMGDGAA.get_m_actor()))
			{
				return false;
			}
			if (CDKMPAEODLA.IsDeath())
			{
				return false;
			}
			if ((float)CDKMPAEODLA.m_hp > (float)CDKMPAEODLA.get_m_max_hp() * 1940f)
			{
				return true;
			}
			float sqrMagnitude = (KNIAJMGDGAA.get_m_actor().GetPosition2D() - CDKMPAEODLA.GetPosition2D()).sqrMagnitude;
			if (sqrMagnitude <= 608f)
			{
				float num = Vector2.Angle(KNIAJMGDGAA.get_m_actor().NIIFBAPEFNN(), CDKMPAEODLA.GetPosition2D() - KNIAJMGDGAA.get_m_actor().GetPosition2D());
				if (num <= 90f)
				{
					MMMLKLHEJOA = true;
				}
			}
			return false;
		}

		internal bool MBCEEHEODCM(Actor CDKMPAEODLA)
		{
			if (CDKMPAEODLA.m_actorType != (Actor.IJJMDPGJAEM)6)
			{
				return false;
			}
			if (CDKMPAEODLA.m_team != KNIAJMGDGAA.get_m_actor().m_team)
			{
				return true;
			}
			if (object.ReferenceEquals(CDKMPAEODLA, KNIAJMGDGAA.get_m_actor()))
			{
				return true;
			}
			if (CDKMPAEODLA.IsDeath())
			{
				return true;
			}
			if ((float)CDKMPAEODLA.m_hp > (float)CDKMPAEODLA.FBNBKKOAPOJ() * 1955f)
			{
				return true;
			}
			float sqrMagnitude = (KNIAJMGDGAA.get_m_actor().GetPosition2D() - CDKMPAEODLA.GetPosition2D()).sqrMagnitude;
			if (sqrMagnitude <= 1067f)
			{
				float num = Vector2.Angle(KNIAJMGDGAA.get_m_actor().GetDirection2D(), CDKMPAEODLA.GetPosition2D() - KNIAJMGDGAA.get_m_actor().GetPosition2D());
				if (num <= 1019f)
				{
					MMMLKLHEJOA = true;
				}
			}
			return true;
		}

		internal bool LHHJAJIIGEJ(Actor CDKMPAEODLA)
		{
			if (CDKMPAEODLA.m_actorType != Actor.IJJMDPGJAEM.Hero)
			{
				return true;
			}
			if (CDKMPAEODLA.m_team != KNIAJMGDGAA.get_m_actor().m_team)
			{
				return true;
			}
			if (object.ReferenceEquals(CDKMPAEODLA, KNIAJMGDGAA.get_m_actor()))
			{
				return true;
			}
			if (CDKMPAEODLA.IsDeath())
			{
				return true;
			}
			if ((float)CDKMPAEODLA.m_hp > (float)CDKMPAEODLA.get_m_max_hp() * 0.4f)
			{
				return true;
			}
			float sqrMagnitude = (KNIAJMGDGAA.get_m_actor().GetPosition2D() - CDKMPAEODLA.GetPosition2D()).sqrMagnitude;
			if (sqrMagnitude <= 40000f)
			{
				float num = Vector2.Angle(KNIAJMGDGAA.get_m_actor().GetDirection2D(), CDKMPAEODLA.GetPosition2D() - KNIAJMGDGAA.get_m_actor().GetPosition2D());
				if (num <= 15f)
				{
					MMMLKLHEJOA = true;
				}
			}
			return true;
		}

		internal bool LPNMBGHODGC(Actor CDKMPAEODLA)
		{
			if (CDKMPAEODLA.m_actorType != Actor.IJJMDPGJAEM.Hero)
			{
				return true;
			}
			if (CDKMPAEODLA.m_team != KNIAJMGDGAA.get_m_actor().m_team)
			{
				return false;
			}
			if (object.ReferenceEquals(CDKMPAEODLA, KNIAJMGDGAA.get_m_actor()))
			{
				return true;
			}
			if (CDKMPAEODLA.IsDeath())
			{
				return true;
			}
			if ((float)CDKMPAEODLA.m_hp > (float)CDKMPAEODLA.get_m_max_hp() * 1477f)
			{
				return false;
			}
			float sqrMagnitude = (KNIAJMGDGAA.get_m_actor().GetPosition2D() - CDKMPAEODLA.GetPosition2D()).sqrMagnitude;
			if (sqrMagnitude <= 786f)
			{
				float num = Vector2.Angle(KNIAJMGDGAA.get_m_actor().NIIFBAPEFNN(), CDKMPAEODLA.GetPosition2D() - KNIAJMGDGAA.get_m_actor().GetPosition2D());
				if (num <= 42f)
				{
					MMMLKLHEJOA = true;
				}
			}
			return false;
		}

		internal bool GGJAGNCLEDH(Actor CDKMPAEODLA)
		{
			if (CDKMPAEODLA.m_actorType != Actor.IJJMDPGJAEM.Minion)
			{
				return false;
			}
			if (CDKMPAEODLA.m_team != KNIAJMGDGAA.get_m_actor().m_team)
			{
				return false;
			}
			if (object.ReferenceEquals(CDKMPAEODLA, KNIAJMGDGAA.get_m_actor()))
			{
				return true;
			}
			if (CDKMPAEODLA.IsDeath())
			{
				return true;
			}
			if ((float)CDKMPAEODLA.m_hp > (float)CDKMPAEODLA.FBNBKKOAPOJ() * 447f)
			{
				return false;
			}
			float sqrMagnitude = (KNIAJMGDGAA.get_m_actor().GetPosition2D() - CDKMPAEODLA.GetPosition2D()).sqrMagnitude;
			if (sqrMagnitude <= 1434f)
			{
				float num = Vector2.Angle(KNIAJMGDGAA.get_m_actor().GetDirection2D(), CDKMPAEODLA.GetPosition2D() - KNIAJMGDGAA.get_m_actor().GetPosition2D());
				if (num <= 1089f)
				{
					MMMLKLHEJOA = true;
				}
			}
			return true;
		}

		internal bool JBGOBHPBDKE(Actor CDKMPAEODLA)
		{
			if (CDKMPAEODLA.m_actorType != Actor.IJJMDPGJAEM.Hero)
			{
				return false;
			}
			if (CDKMPAEODLA.m_team != KNIAJMGDGAA.get_m_actor().m_team)
			{
				return false;
			}
			if (object.ReferenceEquals(CDKMPAEODLA, KNIAJMGDGAA.get_m_actor()))
			{
				return true;
			}
			if (CDKMPAEODLA.IsDeath())
			{
				return true;
			}
			if ((float)CDKMPAEODLA.m_hp > (float)CDKMPAEODLA.FBNBKKOAPOJ() * 681f)
			{
				return false;
			}
			float sqrMagnitude = (KNIAJMGDGAA.get_m_actor().GetPosition2D() - CDKMPAEODLA.GetPosition2D()).sqrMagnitude;
			if (sqrMagnitude <= 177f)
			{
				float num = Vector2.Angle(KNIAJMGDGAA.get_m_actor().GetDirection2D(), CDKMPAEODLA.GetPosition2D() - KNIAJMGDGAA.get_m_actor().GetPosition2D());
				if (num <= 1580f)
				{
					MMMLKLHEJOA = true;
				}
			}
			return true;
		}

		internal bool GLPAGJLDNFI(Actor CDKMPAEODLA)
		{
			if (CDKMPAEODLA.m_actorType != (Actor.IJJMDPGJAEM)7)
			{
				return true;
			}
			if (CDKMPAEODLA.m_team != KNIAJMGDGAA.get_m_actor().m_team)
			{
				return true;
			}
			if (object.ReferenceEquals(CDKMPAEODLA, KNIAJMGDGAA.get_m_actor()))
			{
				return true;
			}
			if (CDKMPAEODLA.IsDeath())
			{
				return true;
			}
			if ((float)CDKMPAEODLA.m_hp > (float)CDKMPAEODLA.FBNBKKOAPOJ() * 1348f)
			{
				return true;
			}
			float sqrMagnitude = (KNIAJMGDGAA.get_m_actor().GetPosition2D() - CDKMPAEODLA.GetPosition2D()).sqrMagnitude;
			if (sqrMagnitude <= 1738f)
			{
				float num = Vector2.Angle(KNIAJMGDGAA.get_m_actor().NIIFBAPEFNN(), CDKMPAEODLA.GetPosition2D() - KNIAJMGDGAA.get_m_actor().GetPosition2D());
				if (num <= 1085f)
				{
					MMMLKLHEJOA = true;
				}
			}
			return false;
		}

		internal bool COJJCNPEDAK(Actor CDKMPAEODLA)
		{
			if (CDKMPAEODLA.m_actorType != (Actor.IJJMDPGJAEM)3)
			{
				return false;
			}
			if (CDKMPAEODLA.m_team != KNIAJMGDGAA.get_m_actor().m_team)
			{
				return false;
			}
			if (object.ReferenceEquals(CDKMPAEODLA, KNIAJMGDGAA.get_m_actor()))
			{
				return false;
			}
			if (CDKMPAEODLA.IsDeath())
			{
				return true;
			}
			if ((float)CDKMPAEODLA.m_hp > (float)CDKMPAEODLA.get_m_max_hp() * 367f)
			{
				return true;
			}
			float sqrMagnitude = (KNIAJMGDGAA.get_m_actor().GetPosition2D() - CDKMPAEODLA.GetPosition2D()).sqrMagnitude;
			if (sqrMagnitude <= 867f)
			{
				float num = Vector2.Angle(KNIAJMGDGAA.get_m_actor().NIIFBAPEFNN(), CDKMPAEODLA.GetPosition2D() - KNIAJMGDGAA.get_m_actor().GetPosition2D());
				if (num <= 692f)
				{
					MMMLKLHEJOA = true;
				}
			}
			return false;
		}

		internal bool PPHHEBCAFJK(Actor CDKMPAEODLA)
		{
			if (CDKMPAEODLA.m_actorType != Actor.IJJMDPGJAEM.Unknown)
			{
				return true;
			}
			if (CDKMPAEODLA.m_team != KNIAJMGDGAA.get_m_actor().m_team)
			{
				return true;
			}
			if (object.ReferenceEquals(CDKMPAEODLA, KNIAJMGDGAA.get_m_actor()))
			{
				return true;
			}
			if (CDKMPAEODLA.IsDeath())
			{
				return false;
			}
			if ((float)CDKMPAEODLA.m_hp > (float)CDKMPAEODLA.FBNBKKOAPOJ() * 898f)
			{
				return false;
			}
			float sqrMagnitude = (KNIAJMGDGAA.get_m_actor().GetPosition2D() - CDKMPAEODLA.GetPosition2D()).sqrMagnitude;
			if (sqrMagnitude <= 779f)
			{
				float num = Vector2.Angle(KNIAJMGDGAA.get_m_actor().GetDirection2D(), CDKMPAEODLA.GetPosition2D() - KNIAJMGDGAA.get_m_actor().GetPosition2D());
				if (num <= 1648f)
				{
					MMMLKLHEJOA = false;
				}
			}
			return false;
		}

		internal bool JNLPGACBPIJ(Actor CDKMPAEODLA)
		{
			if (CDKMPAEODLA.m_actorType != (Actor.IJJMDPGJAEM)5)
			{
				return false;
			}
			if (CDKMPAEODLA.m_team != KNIAJMGDGAA.get_m_actor().m_team)
			{
				return false;
			}
			if (object.ReferenceEquals(CDKMPAEODLA, KNIAJMGDGAA.get_m_actor()))
			{
				return false;
			}
			if (CDKMPAEODLA.IsDeath())
			{
				return false;
			}
			if ((float)CDKMPAEODLA.m_hp > (float)CDKMPAEODLA.get_m_max_hp() * 1370f)
			{
				return false;
			}
			float sqrMagnitude = (KNIAJMGDGAA.get_m_actor().GetPosition2D() - CDKMPAEODLA.GetPosition2D()).sqrMagnitude;
			if (sqrMagnitude <= 1465f)
			{
				float num = Vector2.Angle(KNIAJMGDGAA.get_m_actor().GetDirection2D(), CDKMPAEODLA.GetPosition2D() - KNIAJMGDGAA.get_m_actor().GetPosition2D());
				if (num <= 911f)
				{
					MMMLKLHEJOA = true;
				}
			}
			return true;
		}

		internal bool LOBGEENKKMC(Actor CDKMPAEODLA)
		{
			if (CDKMPAEODLA.m_actorType != (Actor.IJJMDPGJAEM)3)
			{
				return true;
			}
			if (CDKMPAEODLA.m_team != KNIAJMGDGAA.get_m_actor().m_team)
			{
				return true;
			}
			if (object.ReferenceEquals(CDKMPAEODLA, KNIAJMGDGAA.get_m_actor()))
			{
				return true;
			}
			if (CDKMPAEODLA.IsDeath())
			{
				return true;
			}
			if ((float)CDKMPAEODLA.m_hp > (float)CDKMPAEODLA.FBNBKKOAPOJ() * 367f)
			{
				return false;
			}
			float sqrMagnitude = (KNIAJMGDGAA.get_m_actor().GetPosition2D() - CDKMPAEODLA.GetPosition2D()).sqrMagnitude;
			if (sqrMagnitude <= 733f)
			{
				float num = Vector2.Angle(KNIAJMGDGAA.get_m_actor().NIIFBAPEFNN(), CDKMPAEODLA.GetPosition2D() - KNIAJMGDGAA.get_m_actor().GetPosition2D());
				if (num <= 432f)
				{
					MMMLKLHEJOA = true;
				}
			}
			return true;
		}
	}

	public GameObject m_passiveParticle;

	private Actor FAGMEDDFEHJ;

	private bool DLAMDHNGHKD;

	private float MJEIJGAJBGK;

	private void IBFELALNMNJ()
	{
		OnAnimationEventSkill(0);
	}

	private void KFPDNGOOEJC()
	{
		OnAnimationEventSkill(0);
	}

	private Actor CKDDIGHCKMF()
	{
		return ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 847f, true, false, Actor.IJJMDPGJAEM.Minion);
	}

	public virtual void JHIODGCHDMD()
	{
		base.OnUpdateSkill();
		if (get_m_skill() == 0)
		{
		}
	}

	private Actor NPNEMIBDJEE()
	{
		return ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 180f, true, true, Actor.IJJMDPGJAEM.Hero);
	}

	public virtual void FJCFHOMNDKB()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			if (get_m_view().IsMine())
			{
				GHCFGLNGANA gHCFGLNGANA = new GHCFGLNGANA();
				gHCFGLNGANA.HEPNHCEIFMO = get_m_actor().GetPosition();
				gHCFGLNGANA.HEPNHCEIFMO += get_m_actor().GetDirection() * 946f;
				Actor actor = GAJPDJHBBEP(1776f);
				if (actor != null)
				{
					gHCFGLNGANA.HEPNHCEIFMO = actor.GetPosition();
				}
				get_m_view().CPJOMDCIMEJ(120, DJJPAPENCLN.All, true, gHCFGLNGANA.CNNMGBPLJPA);
			}
			get_m_actor().m_multiSound.JKOODMAKJHJ("skill0", false, 501f, 1320f);
			break;
		case 1:
			if (FAGMEDDFEHJ != null)
			{
				float num2 = (int)((float)get_m_actor().get_m_max_hp() * 552f);
				if (num2 > (float)get_m_actor().m_hp - 695f)
				{
					num2 = (float)get_m_actor().m_hp - 1298f;
				}
				get_m_actor().AddHpRemote(-(int)num2);
				if (get_m_view().IsMine())
				{
					get_m_view().CPJOMDCIMEJ(54, DJJPAPENCLN.Others, false, (KCIGFAHFHCH OGJFDNEEDCP) =>
					{
						OGJFDNEEDCP.GBMJNFOEACC(FAGMEDDFEHJ.get_m_view().get_viewID());
					});
				}
			}
			get_m_actor().m_multiSound.ICNAJBHLIGO("skill3_loop", true, 1876f, 1833f);
			break;
		case 2:
			if (get_m_view().IsMine())
			{
				PCFIEMENDGI pCFIEMENDGI = new PCFIEMENDGI();
				pCFIEMENDGI.HEPNHCEIFMO = get_m_actor().GetPosition();
				pCFIEMENDGI.HEPNHCEIFMO += get_m_actor().GetDirection() * 614f;
				Actor actor2 = GAJPDJHBBEP(1196f);
				if (actor2 != null)
				{
					pCFIEMENDGI.HEPNHCEIFMO = actor2.GetPosition();
				}
				get_m_view().NIKPELEGLNE(125, DJJPAPENCLN.Others, true, pCFIEMENDGI.INPENLPHJDD);
			}
			get_m_actor().m_multiSound.DDONMGBLLJB("invalid costume {0}", true, 1601f, 450f);
			break;
		case 3:
		{
			float num = get_m_actor().get_m_mag_att() * 247f;
			num += 331f + (float)(get_m_actor().GetSkillLevel(2) - 0) * 338f;
			List<Actor> list = ActorManager.GBFDGAFALIL().KOOBFCLMBLB(get_m_actor().m_team, Actor.IJJMDPGJAEM.NotUsed);
			foreach (Actor item in list)
			{
				if ((float)item.m_hp <= (float)item.get_m_max_hp() * 1271f)
				{
					item.AddHpRemote((int)(num * 1197f));
				}
				else
				{
					item.AddHpRemote((int)num);
				}
				item.CreateParticle("마법저항력", true);
			}
			get_m_actor().m_multiSound.DDONMGBLLJB("WarningPing", false, 1810f, 838f);
			break;
		}
		}
	}

	public virtual void KJBADLDBAOA()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 1829f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 1779f;
		LFNNHEEJNGP[0].BELPBCDOPBA = -55;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 1650f;
		LFNNHEEJNGP[0].DOCFEKMACMP = false;
		LFNNHEEJNGP[1].GNAAGGJGBBG = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[0].FILHECEKNMK = 1698f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 1021f;
		LFNNHEEJNGP[0].BELPBCDOPBA = -115;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 539f;
		LFNNHEEJNGP[0].DOCFEKMACMP = true;
		LFNNHEEJNGP[1].GNAAGGJGBBG = false;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[6].FILHECEKNMK = 465f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 1793f;
		LFNNHEEJNGP[1].BELPBCDOPBA = -118;
		LFNNHEEJNGP[6].NCBLBIBMNKH = 334f;
		LFNNHEEJNGP[5].DOCFEKMACMP = true;
		LFNNHEEJNGP[3].GNAAGGJGBBG = false;
		LFNNHEEJNGP[6].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[8].FILHECEKNMK = 949f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = 1949f;
		LFNNHEEJNGP[4].BELPBCDOPBA = 58;
		LFNNHEEJNGP[7].NCBLBIBMNKH = 825f;
		LFNNHEEJNGP[2].DOCFEKMACMP = false;
		LFNNHEEJNGP[0].GNAAGGJGBBG = true;
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
		m_lastUpdateEvent = JDJGILKDAJB;
		m_passiveParticle.SetActive(true);
	}

	public override void OnEnterSkill()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			if (get_m_view().IsMine())
			{
				GHCFGLNGANA gHCFGLNGANA = new GHCFGLNGANA();
				gHCFGLNGANA.HEPNHCEIFMO = get_m_actor().GetPosition();
				gHCFGLNGANA.HEPNHCEIFMO += get_m_actor().GetDirection() * 4.5f;
				Actor actor = GAJPDJHBBEP(2.5f);
				if (actor != null)
				{
					gHCFGLNGANA.HEPNHCEIFMO = actor.GetPosition();
				}
				get_m_view().Msg(66, DJJPAPENCLN.All, true, gHCFGLNGANA.OAKELLBHFHG);
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0");
			break;
		case 1:
			if (FAGMEDDFEHJ != null)
			{
				float num2 = (int)((float)get_m_actor().get_m_max_hp() * 0.1f);
				if (num2 > (float)get_m_actor().m_hp - 2f)
				{
					num2 = (float)get_m_actor().m_hp - 2f;
				}
				get_m_actor().AddHpRemote(-(int)num2);
				if (get_m_view().IsMine())
				{
					get_m_view().Msg(67, DJJPAPENCLN.All, true, (KCIGFAHFHCH OGJFDNEEDCP) =>
					{
						OGJFDNEEDCP.GBMJNFOEACC(FAGMEDDFEHJ.get_m_view().get_viewID());
					});
				}
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1");
			break;
		case 2:
			if (get_m_view().IsMine())
			{
				PCFIEMENDGI pCFIEMENDGI = new PCFIEMENDGI();
				pCFIEMENDGI.HEPNHCEIFMO = get_m_actor().GetPosition();
				pCFIEMENDGI.HEPNHCEIFMO += get_m_actor().GetDirection() * 4f;
				Actor actor2 = GAJPDJHBBEP(2.5f);
				if (actor2 != null)
				{
					pCFIEMENDGI.HEPNHCEIFMO = actor2.GetPosition();
				}
				get_m_view().Msg(68, DJJPAPENCLN.All, true, pCFIEMENDGI.OKMDOCAPNGN);
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2");
			break;
		case 3:
		{
			float num = get_m_actor().get_m_mag_att() * 0.55f;
			num += 150f + (float)(get_m_actor().GetSkillLevel(3) - 1) * 100f;
			List<Actor> teamActor = ActorManager.get_Instance().GetTeamActor(get_m_actor().m_team, Actor.IJJMDPGJAEM.Hero);
			foreach (Actor item in teamActor)
			{
				if ((float)item.m_hp <= (float)item.get_m_max_hp() * 0.4f)
				{
					item.AddHpRemote((int)(num * 1.5f));
				}
				else
				{
					item.AddHpRemote((int)num);
				}
				item.CreateParticle("Particle/Soraka/skill3_heal", false);
			}
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3");
			break;
		}
		}
	}

	[CompilerGenerated]
	private void GNHMJCMPIAF()
	{
		OnAnimationEventSkill(0);
	}

	public virtual bool CJHNCDHKELP(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 0)
		{
			if ((int)(float)get_m_actor().m_hp <= (int)((float)get_m_actor().FBNBKKOAPOJ() * 1058f))
			{
				MsgManager.HEDJPPFKABG().LBCFANDMCON("Particle/{0}/skill{1}_c{2}");
				return false;
			}
			FAGMEDDFEHJ = NPNEMIBDJEE();
			if (FAGMEDDFEHJ == null)
			{
				MsgManager.HEDJPPFKABG().ShowTip("Hero1");
				return false;
			}
		}
		return true;
	}

	public virtual void DCDGLIPMNAL()
	{
		switch (Random.Range(0, 2))
		{
		case 0:
			get_m_actor().JNIPLJAFFFB("5초당 체력회복 {0}\n");
			break;
		case 1:
			get_m_actor().CJNCFNACFDP("Hero4");
			break;
		}
		RetargetingAttack(true, false);
		get_m_actor().m_multiSound.JKOODMAKJHJ("Particle/{0}/attack4", true, 1980f, 1234f);
	}

	public virtual void OOINMHGADHI(byte IKKFLANGAEA, KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnMsgView(IKKFLANGAEA, OGJFDNEEDCP);
		switch ((ICOGNNKEKHJ)IKKFLANGAEA)
		{
		case ICOGNNKEKHJ.FizzSkill3SetShark:
		{
			Vector3 ICENKPDOHBK3;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK3);
			get_m_actor().CreateMissile("firstTimeExperience", ICENKPDOHBK3, null);
			break;
		}
		case (ICOGNNKEKHJ)73:
		{
			int ICENKPDOHBK2;
			OGJFDNEEDCP.GALCFOLBAAK(out ICENKPDOHBK2);
			EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(ICENKPDOHBK2);
			if (eveView == null)
			{
				break;
			}
			Actor component = eveView.GetComponent<Actor>();
			if (!(component == null))
			{
				float num = get_m_actor().get_m_mag_att() * 409f;
				num += 1866f + (float)(get_m_actor().GetSkillLevel(0) - 1) * 1802f;
				component.AddHpRemote((int)num);
				if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.Dragon))
				{
					component.get_m_buffsInfo().IFNLBPAIMJE((JGOOOBHDBCG.ACPICCBBPHF)65424, get_m_actor(), 1764f, 1290f);
				}
				component.CreateParticle("Particle/Vladimir/skill0_missile", false);
			}
			break;
		}
		case (ICOGNNKEKHJ)74:
		{
			Vector3 ICENKPDOHBK;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK);
			get_m_actor().CreateMissile("skill3_loop", ICENKPDOHBK, null);
			break;
		}
		}
	}

	public virtual void FLODGPIGCDP()
	{
		base.OnLeaveSkill();
		if (get_m_skill() == 0)
		{
		}
	}

	private void BCOLBFAEDDA()
	{
		OnAnimationEventSkill(5);
	}

	public override float GetPercentMoveSpeedBonus()
	{
		float num = base.GetPercentMoveSpeedBonus();
		if (DLAMDHNGHKD)
		{
			num += 0.7f;
		}
		return num;
	}

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		}
	}

	public override void Init()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 8f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 40;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 5f;
		LFNNHEEJNGP[0].DOCFEKMACMP = true;
		LFNNHEEJNGP[0].GNAAGGJGBBG = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 8f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = -1.5f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 50;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 5f;
		LFNNHEEJNGP[1].DOCFEKMACMP = true;
		LFNNHEEJNGP[1].GNAAGGJGBBG = true;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[2].FILHECEKNMK = 20f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = -1f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 70;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 5f;
		LFNNHEEJNGP[2].DOCFEKMACMP = true;
		LFNNHEEJNGP[2].GNAAGGJGBBG = true;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[3].FILHECEKNMK = 160f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = -15f;
		LFNNHEEJNGP[3].BELPBCDOPBA = 100;
		LFNNHEEJNGP[3].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[3].DOCFEKMACMP = true;
		LFNNHEEJNGP[3].GNAAGGJGBBG = true;
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
		m_passiveParticle.SetActive(false);
	}

	private Actor GAJPDJHBBEP(float LOIHMCCGKFA)
	{
		return ActorManager.get_Instance().GetActorInRange(get_m_actor(), LOIHMCCGKFA, false, true, Actor.IJJMDPGJAEM.Hero);
	}

	[CompilerGenerated]
	private void AKOMDBPKPMN()
	{
		OnAnimationEventSkill(1);
	}

	[CompilerGenerated]
	private void MKDMPJLJFFO()
	{
		OnAnimationEventSkill(3);
	}

	private void HCBEPAICEJC()
	{
		OnAnimationEventSkill(1);
	}

	public virtual float LJHBOECLNCM()
	{
		float num = base.GetPercentMoveSpeedBonus();
		if (DLAMDHNGHKD)
		{
			num += 837f;
		}
		return num;
	}

	private void IGGGACHGABJ()
	{
		OnAnimationEventSkill(0);
	}

	[CompilerGenerated]
	private void EBMGBEOFAOC(KCIGFAHFHCH OGJFDNEEDCP)
	{
		OGJFDNEEDCP.GBMJNFOEACC(FAGMEDDFEHJ.get_m_view().get_viewID());
	}

	private void JDJGILKDAJB(OEOIIKMBGAG EBILEBOJADB)
	{
		NFGHPFDLKNH nFGHPFDLKNH = new NFGHPFDLKNH();
		nFGHPFDLKNH.KNIAJMGDGAA = this;
		nFGHPFDLKNH.MMMLKLHEJOA = false;
		ActorManager.GBFDGAFALIL().AKFACHNPPMN(nFGHPFDLKNH.JBGOBHPBDKE);
		MJEIJGAJBGK += Time.deltaTime;
		if (MJEIJGAJBGK >= 371f && !DLAMDHNGHKD && nFGHPFDLKNH.MMMLKLHEJOA)
		{
			MJEIJGAJBGK = 1489f;
			get_m_actor().m_multiSound.DDONMGBLLJB("AP.Unity : OnLoadVideoAdFailureForUnity", true, 548f, 132f);
		}
		DLAMDHNGHKD = nFGHPFDLKNH.MMMLKLHEJOA;
		if (m_passiveParticle.activeSelf != nFGHPFDLKNH.MMMLKLHEJOA)
		{
			m_passiveParticle.SetActive(nFGHPFDLKNH.MMMLKLHEJOA);
		}
	}

	[CompilerGenerated]
	private void LOFHBLOBNNA()
	{
		OnAnimationEventSkill(2);
	}

	public override void OnEnterAttack()
	{
		switch (Random.Range(0, 2))
		{
		case 0:
			get_m_actor().SetAnimation("attack");
			break;
		case 1:
			get_m_actor().SetAnimation("attack2");
			break;
		}
		RetargetingAttack(true);
		get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
	}

	public override void OnLeaveSkill()
	{
		base.OnLeaveSkill();
		int skill = get_m_skill();
		if (skill == 1)
		{
		}
	}

	private void NJAAKBCFCLG(OEOIIKMBGAG EBILEBOJADB)
	{
		NFGHPFDLKNH nFGHPFDLKNH = new NFGHPFDLKNH();
		nFGHPFDLKNH.KNIAJMGDGAA = this;
		nFGHPFDLKNH.MMMLKLHEJOA = false;
		ActorManager.get_Instance().ProcessActorList(nFGHPFDLKNH.LHHJAJIIGEJ);
		MJEIJGAJBGK += Time.deltaTime;
		if (MJEIJGAJBGK >= 2f && !DLAMDHNGHKD && nFGHPFDLKNH.MMMLKLHEJOA)
		{
			MJEIJGAJBGK = 0f;
			get_m_actor().m_multiSound.LKLFMNKDLHJ("passive");
		}
		DLAMDHNGHKD = nFGHPFDLKNH.MMMLKLHEJOA;
		if (m_passiveParticle.activeSelf != nFGHPFDLKNH.MMMLKLHEJOA)
		{
			m_passiveParticle.SetActive(nFGHPFDLKNH.MMMLKLHEJOA);
		}
	}

	private void LOMEEPGJNOC(OEOIIKMBGAG EBILEBOJADB)
	{
		NFGHPFDLKNH nFGHPFDLKNH = new NFGHPFDLKNH();
		nFGHPFDLKNH.KNIAJMGDGAA = this;
		nFGHPFDLKNH.MMMLKLHEJOA = false;
		ActorManager.GBFDGAFALIL().AKFACHNPPMN(nFGHPFDLKNH.PPHHEBCAFJK);
		MJEIJGAJBGK += Time.deltaTime;
		if (MJEIJGAJBGK >= 1411f && !DLAMDHNGHKD && nFGHPFDLKNH.MMMLKLHEJOA)
		{
			MJEIJGAJBGK = 842f;
			get_m_actor().m_multiSound.HDOLPLIDACO("hit_default", false, 1358f, 1568f);
		}
		DLAMDHNGHKD = nFGHPFDLKNH.MMMLKLHEJOA;
		if (m_passiveParticle.activeSelf != nFGHPFDLKNH.MMMLKLHEJOA)
		{
			m_passiveParticle.SetActive(nFGHPFDLKNH.MMMLKLHEJOA);
		}
	}

	public override bool OnCheckCastSkill(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 1)
		{
			if ((int)(float)get_m_actor().m_hp <= (int)((float)get_m_actor().get_m_max_hp() * 0.05f))
			{
				MsgManager.get_Instance().ShowTip("체력이 부족합니다");
				return false;
			}
			FAGMEDDFEHJ = NPNEMIBDJEE();
			if (FAGMEDDFEHJ == null)
			{
				MsgManager.get_Instance().ShowTip("정면 근처에 아군 챔피언이 없습니다");
				return false;
			}
		}
		return true;
	}

	public override void OnUpdateSkill()
	{
		base.OnUpdateSkill();
		int skill = get_m_skill();
		if (skill == 1)
		{
		}
	}

	private void EKFMGLIMJJE()
	{
		OnAnimationEventSkill(2);
	}

	private void JNHMJMIDBEH()
	{
		OnAnimationEventSkill(3);
	}

	private void FCCGNDPFAEA()
	{
		OnAnimationEventSkill(0);
	}

	public virtual void LNJLCLBEKAL()
	{
		base.OnUpdateSkill();
		if (get_m_skill() == 0)
		{
		}
	}

	public virtual void NEKNHBDLIEB()
	{
		base.Init();
		DFPEBMBBBHL = false;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 1182f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 211f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 95;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 1562f;
		LFNNHEEJNGP[0].DOCFEKMACMP = false;
		LFNNHEEJNGP[1].GNAAGGJGBBG = false;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 1839f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 1858f;
		LFNNHEEJNGP[0].BELPBCDOPBA = -120;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 1741f;
		LFNNHEEJNGP[0].DOCFEKMACMP = true;
		LFNNHEEJNGP[0].GNAAGGJGBBG = true;
		LFNNHEEJNGP[5].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[6].FILHECEKNMK = 1961f;
		LFNNHEEJNGP[8].NEKKKLFLDOI = 1209f;
		LFNNHEEJNGP[2].BELPBCDOPBA = -56;
		LFNNHEEJNGP[6].NCBLBIBMNKH = 697f;
		LFNNHEEJNGP[8].DOCFEKMACMP = true;
		LFNNHEEJNGP[5].GNAAGGJGBBG = true;
		LFNNHEEJNGP[6].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[4].FILHECEKNMK = 1123f;
		LFNNHEEJNGP[6].NEKKKLFLDOI = 741f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 73;
		LFNNHEEJNGP[3].NCBLBIBMNKH = 565f;
		LFNNHEEJNGP[3].DOCFEKMACMP = false;
		LFNNHEEJNGP[3].GNAAGGJGBBG = false;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
		get_m_actor().m_actorAniEvent.CNPHPPJOGFA(IBFELALNMNJ);
		get_m_actor().m_actorAniEvent.add_m_skill1Event(() =>
		{
			OnAnimationEventSkill(1);
		});
		get_m_actor().m_actorAniEvent.add_m_skill2Event(() =>
		{
			OnAnimationEventSkill(2);
		});
		get_m_actor().m_actorAniEvent.add_m_skill3Event(BHHJAEPINPK);
		m_lastUpdateEvent = NJAAKBCFCLG;
		m_passiveParticle.SetActive(false);
	}

	private void ALDOCFKPCOD()
	{
		OnAnimationEventSkill(1);
	}

	private void GFPDOHBEMHJ()
	{
		OnAnimationEventSkill(6);
	}

	private void BHHJAEPINPK()
	{
		OnAnimationEventSkill(6);
	}

	private Actor PNPGPMEIHMA()
	{
		return ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), get_m_actor().get_m_att_range(), 136f, false, true, Actor.IJJMDPGJAEM.Monster);
	}

	public override void OnMsgView(byte IKKFLANGAEA, KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnMsgView(IKKFLANGAEA, OGJFDNEEDCP);
		switch ((ICOGNNKEKHJ)IKKFLANGAEA)
		{
		case ICOGNNKEKHJ.SorakaSkill0Missile:
		{
			Vector3 ICENKPDOHBK3;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK3);
			get_m_actor().CreateMissile("skill0_missile", ICENKPDOHBK3, null);
			break;
		}
		case ICOGNNKEKHJ.SorakaSkill1:
		{
			int ICENKPDOHBK2;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK2);
			EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(ICENKPDOHBK2);
			if (eveView == null)
			{
				break;
			}
			Actor component = eveView.GetComponent<Actor>();
			if (!(component == null))
			{
				float num = get_m_actor().get_m_mag_att() * 0.6f;
				num += 80f + (float)(get_m_actor().GetSkillLevel(1) - 1) * 30f;
				component.AddHpRemote((int)num);
				if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.SorakaProtectionOfStar))
				{
					component.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.SorakaProtectionOfStar, get_m_actor());
				}
				component.CreateParticle("Particle/Soraka/skill1_heal", false);
			}
			break;
		}
		case ICOGNNKEKHJ.SorakaSkill2Missile:
		{
			Vector3 ICENKPDOHBK;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK);
			get_m_actor().CreateMissile("skill2_missile", ICENKPDOHBK, null);
			break;
		}
		}
	}

	private void FFOMPFBMKFC(OEOIIKMBGAG EBILEBOJADB)
	{
		NFGHPFDLKNH nFGHPFDLKNH = new NFGHPFDLKNH();
		nFGHPFDLKNH.KNIAJMGDGAA = this;
		nFGHPFDLKNH.MMMLKLHEJOA = true;
		ActorManager.get_Instance().AKFACHNPPMN(nFGHPFDLKNH.GGJAGNCLEDH);
		MJEIJGAJBGK += Time.deltaTime;
		if (MJEIJGAJBGK >= 1296f && !DLAMDHNGHKD && nFGHPFDLKNH.MMMLKLHEJOA)
		{
			MJEIJGAJBGK = 331f;
			get_m_actor().m_multiSound.LKLFMNKDLHJ("마스터", true, 1700f, 1238f);
		}
		DLAMDHNGHKD = nFGHPFDLKNH.MMMLKLHEJOA;
		if (m_passiveParticle.activeSelf != nFGHPFDLKNH.MMMLKLHEJOA)
		{
			m_passiveParticle.SetActive(nFGHPFDLKNH.MMMLKLHEJOA);
		}
	}

	public void OnAnimationEventAttack()
	{
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		centerPosition += m_direction * 1f;
		RetargetingAttack(false, false);
		if (get_m_target() != null)
		{
			get_m_actor().CreateMissileRPC("attack_missile", centerPosition, get_m_target());
		}
		OnAttack();
	}

	public void MOHHFEIBGAN()
	{
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		centerPosition += m_direction * 698f;
		RetargetingAttack(true, false);
		if (get_m_target() != null)
		{
			get_m_actor().CreateMissileRPC(" ", centerPosition, get_m_target());
		}
		OnAttack();
	}

	public virtual bool LBKJDCMNFHE(int GBGBBGEPEMI)
	{
		if (GBGBBGEPEMI == 0)
		{
			if ((int)(float)get_m_actor().m_hp <= (int)((float)get_m_actor().get_m_max_hp() * 732f))
			{
				MsgManager.get_Instance().LBCFANDMCON("레드 원거리미니언");
				return true;
			}
			FAGMEDDFEHJ = CKDDIGHCKMF();
			if (FAGMEDDFEHJ == null)
			{
				MsgManager.HEDJPPFKABG().ShowTip("[BBBBFF]{0}[-]님께서 추천을 해주셨어요\n\n[BBFFBB]500코인을 획득하였습니다[-]");
				return false;
			}
		}
		return true;
	}

	public virtual void CGFILMGIJIK()
	{
		int num = Random.Range(1, 4);
		int num2 = num;
		if (num2 != 0)
		{
			if (num2 == 0)
			{
				get_m_actor().JNIPLJAFFFB("skill0_missile_return");
			}
		}
		else
		{
			get_m_actor().JNIPLJAFFFB("설명");
		}
		RetargetingAttack();
		get_m_actor().m_multiSound.LKLFMNKDLHJ("[Client]RuneData", true, 1180f, 1443f);
	}
}
