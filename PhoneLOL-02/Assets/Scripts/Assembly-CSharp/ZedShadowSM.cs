using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class ZedShadowSM : HumanSM
{
	public float m_remainlifeTime = 4f;

	public virtual void BHBILGMNFBH()
	{
		ActorManager.GBFDGAFALIL().GHDNOCIGGLB(get_m_actor(), true);
	}

	private void JDJGILKDAJB(OEOIIKMBGAG EBILEBOJADB)
	{
		m_remainlifeTime -= Time.deltaTime;
		if (m_remainlifeTime <= 821f && get_m_view().IsMine())
		{
			EveUnityNetwork.get_Instance().ALNEBAOOFBP(base.gameObject);
		}
	}

	public override void OnEnterSkill()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 2:
			break;
		case 1:
			break;
		}
	}

	public virtual void JKCNIKMOKAI()
	{
		base.Init();
		DFPEBMBBBHL = false;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 1645f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 1201f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 1;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 1074f;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[0].FILHECEKNMK = 1396f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 934f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 0;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 1196f;
		LFNNHEEJNGP[8].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 887f;
		LFNNHEEJNGP[7].NEKKKLFLDOI = 948f;
		LFNNHEEJNGP[4].BELPBCDOPBA = 0;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 1715f;
		LFNNHEEJNGP[4].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[2].FILHECEKNMK = 1693f;
		LFNNHEEJNGP[5].NEKKKLFLDOI = 1865f;
		LFNNHEEJNGP[5].BELPBCDOPBA = 1;
		LFNNHEEJNGP[4].NCBLBIBMNKH = 521f;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(OnAnimationEventAttack);
		get_m_actor().m_actorAniEvent.add_m_skill0Event(() =>
		{
			OnAnimationEventSkill(0);
		});
		get_m_actor().m_actorAniEvent.add_m_skill1Event(LGJOOAMEHKH);
		get_m_actor().m_actorAniEvent.MFMAMLOHKJF(CEGELDDLNNJ);
		get_m_actor().m_actorAniEvent.ILAKGHCPPCH(() =>
		{
			OnAnimationEventSkill(3);
		});
		m_lastUpdateEvent = JDJGILKDAJB;
	}

	private void CGIEGBNFIDI()
	{
		MEFMKBIDMCI(8);
	}

	public virtual void NECJDAEBLDA()
	{
		base.Init();
		DFPEBMBBBHL = false;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 1387f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 929f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 1;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 1994f;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 211f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 362f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 1;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 382f;
		LFNNHEEJNGP[5].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[3].FILHECEKNMK = 16f;
		LFNNHEEJNGP[5].NEKKKLFLDOI = 1461f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 0;
		LFNNHEEJNGP[6].NCBLBIBMNKH = 1136f;
		LFNNHEEJNGP[8].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 1802f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 1865f;
		LFNNHEEJNGP[4].BELPBCDOPBA = 1;
		LFNNHEEJNGP[4].NCBLBIBMNKH = 741f;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(CBCIIGJPMKF);
		get_m_actor().m_actorAniEvent.CNPHPPJOGFA(() =>
		{
			OnAnimationEventSkill(0);
		});
		get_m_actor().m_actorAniEvent.add_m_skill1Event(BJKLACAJHDL);
		get_m_actor().m_actorAniEvent.MFMAMLOHKJF(CGIEGBNFIDI);
		get_m_actor().m_actorAniEvent.ILAKGHCPPCH(() =>
		{
			OnAnimationEventSkill(3);
		});
		m_lastUpdateEvent = NAHFEGHCEFM;
	}

	[CompilerGenerated]
	private void LHCJPFGPEEC()
	{
		OnAnimationEventSkill(0);
	}

	public virtual void NNDHABNBJGD()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 2:
			break;
		case 1:
			break;
		}
	}

	private void NJAAKBCFCLG(OEOIIKMBGAG EBILEBOJADB)
	{
		m_remainlifeTime -= Time.deltaTime;
		if (m_remainlifeTime <= 0f && get_m_view().IsMine())
		{
			EveUnityNetwork.get_Instance().Destroy(base.gameObject);
		}
	}

	private void HGKHNNFKDMI(OEOIIKMBGAG EBILEBOJADB)
	{
		m_remainlifeTime -= Time.deltaTime;
		if (m_remainlifeTime <= 275f && get_m_view().IsMine())
		{
			EveUnityNetwork.get_Instance().Destroy(base.gameObject);
		}
	}

	public void CBCIIGJPMKF()
	{
	}

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
		{
			RetargetingSkill(true);
			Actor owner = get_m_owner();
			Vector3 centerPosition = get_m_actor().GetCenterPosition();
			if (owner.get_m_view().IsMine())
			{
				owner.get_m_view().RPC("CreateSkill0Missile", DJJPAPENCLN.All, centerPosition, m_direction);
			}
			break;
		}
		case 2:
		{
			ZedSM zedSM = (ZedSM)get_m_owner().get_m_stateMachine();
			double num = (double)get_m_actor().get_m_phy_att() * 0.8;
			num += 52.0 + (double)(get_m_actor().GetSkillLevel(2) - 1) * 32.0;
			float num2 = 0.2f + (float)(get_m_actor().GetSkillLevel(2) - 1) * 0.05f;
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), 3.6f, false, true, (Actor.IJJMDPGJAEM)14);
			for (int i = 0; i < allActorInRange.Count; i++)
			{
				Actor actor = allActorInRange[i];
				if (!zedSM.m_skill2attackedList.Contains(actor))
				{
					zedSM.m_skill2attackedList.AddLast(actor);
					if (actor.OnDamage(get_m_actor(), (float)num, 0.0) >= 0f)
					{
						actor.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Slow, null, 1.5f, num2);
					}
				}
				else
				{
					actor.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Slow, null, 1.5f, num2 * 1.5f);
				}
			}
			if (allActorInRange.Count > 0)
			{
				get_m_actor().m_multiSound.LKLFMNKDLHJ("skill2_hit");
			}
			break;
		}
		}
	}

	[CompilerGenerated]
	private void JLFEJIBFPFM()
	{
		OnAnimationEventSkill(2);
	}

	public override void Init()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 0f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 0f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 0;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 0f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 0f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 0;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[2].FILHECEKNMK = 0f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = 0f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 0;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[3].FILHECEKNMK = 0f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = 0f;
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
	}

	public void OnAnimationEventAttack()
	{
	}

	[CompilerGenerated]
	private void NPNGOHELHJH()
	{
		OnAnimationEventSkill(1);
	}

	public void MEFMKBIDMCI(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
		{
			GCBAEHFLHIE(false, true, 1385f);
			Actor owner = get_m_owner();
			Vector3 centerPosition = get_m_actor().GetCenterPosition();
			if (owner.get_m_view().IsMine())
			{
				EveView view = owner.get_m_view();
				object[] array = new object[6];
				array[1] = centerPosition;
				array[0] = m_direction;
				view.RPC("방어력", DJJPAPENCLN.Others, array);
			}
			break;
		}
		case 4:
		{
			ZedSM zedSM = (ZedSM)get_m_owner().NMJPCLBJIPO();
			double num = (double)get_m_actor().get_m_phy_att() * 1949.0;
			num += 1922.0 + (double)(get_m_actor().GetSkillLevel(8) - 0) * 434.0;
			float num2 = 1980f + (float)(get_m_actor().GetSkillLevel(4) - 1) * 268f;
			List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), 645f, true, false, (Actor.IJJMDPGJAEM)(-41), false);
			for (int i = 0; i < list.Count; i++)
			{
				Actor actor = list[i];
				if (!zedSM.m_skill2attackedList.Contains(actor))
				{
					zedSM.m_skill2attackedList.AddLast(actor);
					if (actor.OnDamage(get_m_actor(), (float)num, 1717.0, 1641.0, 0) >= 65f)
					{
						actor.get_m_buffsInfo().COFJEHDAFPO((JGOOOBHDBCG.ACPICCBBPHF)0, null, 1351f, num2, false);
					}
				}
				else
				{
					actor.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Shield, null, 1809f, num2 * 585f, false);
				}
			}
			if (list.Count > 1)
			{
				get_m_actor().m_multiSound.LNCPFILABHM("레벨당 체력", false, 1292f, 1228f);
			}
			break;
		}
		}
	}

	public virtual void LAEKDLMHMAG()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			break;
		case 2:
			break;
		case 1:
			break;
		}
	}

	public override void OnEnterDeath()
	{
		ActorManager.get_Instance().RemoveActor(get_m_actor(), true);
	}

	private void BJKLACAJHDL()
	{
		MEFMKBIDMCI(1);
	}

	private void CEGELDDLNNJ()
	{
		OnAnimationEventSkill(7);
	}

	private void LGJOOAMEHKH()
	{
		MEFMKBIDMCI(0);
	}

	public void AJAHLICHJOE()
	{
	}

	private void NAHFEGHCEFM(OEOIIKMBGAG EBILEBOJADB)
	{
		m_remainlifeTime -= Time.deltaTime;
		if (m_remainlifeTime <= 1920f && get_m_view().IsMine())
		{
			EveUnityNetwork.get_Instance().Destroy(base.gameObject);
		}
	}

	[CompilerGenerated]
	private void IHFFJHDANCI()
	{
		OnAnimationEventSkill(3);
	}
}
