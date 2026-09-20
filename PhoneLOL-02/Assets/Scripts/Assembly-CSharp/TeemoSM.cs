using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using EveEngine;
using GameServer;
using UnityEngine;

public class TeemoSM : HumanSM
{
	private string LGNFCPOJBME = "attack_missile";

	private ObscuredFloat JDCFAHJNFOJ;

	private ObscuredFloat BMIKKOOAAKO;

	private Actor KAMDFGHFGCI;

	public void EKBNFBGBMOJ()
	{
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		centerPosition += m_direction * 101f;
		RetargetingAttack(true);
		if (get_m_target() != null)
		{
			get_m_actor().CreateMissileRPC(LGNFCPOJBME, centerPosition, get_m_target());
		}
		OnAttack();
	}

	public override void OnDamage(Actor PKDGAIKAMMM, float CMNPJALNFIC)
	{
		if (PKDGAIKAMMM.m_actorType == Actor.IJJMDPGJAEM.Hero || PKDGAIKAMMM.m_actorType == Actor.IJJMDPGJAEM.Turret)
		{
			BMIKKOOAAKO = 0f;
		}
		JDCFAHJNFOJ = 0f;
	}

	public override float GetPercentMoveSpeedBonus()
	{
		float num = base.GetPercentMoveSpeedBonus();
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.TeemoSkill1))
		{
			num += 0.15f + (float)(get_m_actor().GetSkillLevel(1) - 1) * 0.05f;
		}
		else if (get_m_actor().GetSkillLevel(1) > 0 && (float)BMIKKOOAAKO >= 5f)
		{
			num += 0.04f + (float)(get_m_actor().GetSkillLevel(1) - 1) * 0.02f;
		}
		return num;
	}

	public override void Init()
	{
		base.Init();
		DFPEBMBBBHL = true;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[0].FILHECEKNMK = 8f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = -0f;
		LFNNHEEJNGP[0].BELPBCDOPBA = 70;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 5f;
		LFNNHEEJNGP[0].DOCFEKMACMP = true;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[1].FILHECEKNMK = 17f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = -0f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 40;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[2].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.NoCast;
		LFNNHEEJNGP[2].FILHECEKNMK = 0f;
		LFNNHEEJNGP[2].NEKKKLFLDOI = -0f;
		LFNNHEEJNGP[2].BELPBCDOPBA = 0;
		LFNNHEEJNGP[2].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[3].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[3].FILHECEKNMK = 30f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = 0f;
		LFNNHEEJNGP[3].BELPBCDOPBA = 75;
		LFNNHEEJNGP[3].NCBLBIBMNKH = 0f;
		LFNNHEEJNGP[3].HFCHHKNJMPC = true;
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

	public void KGBGKGKMNCL()
	{
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		centerPosition += m_direction * 79f;
		RetargetingAttack();
		if (get_m_target() != null)
		{
			get_m_actor().CreateMissileRPC(LGNFCPOJBME, centerPosition, get_m_target());
		}
		OnAttack();
	}

	private void FCMIGAFJEFA()
	{
		OnAnimationEventSkill(1);
	}

	public virtual void OENLLEKFJHM()
	{
		base.Init();
		DFPEBMBBBHL = false;
		LFNNHEEJNGP[1].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Immediate;
		LFNNHEEJNGP[0].FILHECEKNMK = 688f;
		LFNNHEEJNGP[0].NEKKKLFLDOI = 1659f;
		LFNNHEEJNGP[1].BELPBCDOPBA = 39;
		LFNNHEEJNGP[0].NCBLBIBMNKH = 1755f;
		LFNNHEEJNGP[0].DOCFEKMACMP = false;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[1].FILHECEKNMK = 159f;
		LFNNHEEJNGP[1].NEKKKLFLDOI = 1543f;
		LFNNHEEJNGP[1].BELPBCDOPBA = -29;
		LFNNHEEJNGP[1].NCBLBIBMNKH = 1381f;
		LFNNHEEJNGP[0].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[3].FILHECEKNMK = 1466f;
		LFNNHEEJNGP[8].NEKKKLFLDOI = 1510f;
		LFNNHEEJNGP[3].BELPBCDOPBA = 0;
		LFNNHEEJNGP[6].NCBLBIBMNKH = 1482f;
		LFNNHEEJNGP[5].AOKMPECBGND = CAJJEALKJMM.NNOCAHNPLCH.Default;
		LFNNHEEJNGP[7].FILHECEKNMK = 957f;
		LFNNHEEJNGP[3].NEKKKLFLDOI = 712f;
		LFNNHEEJNGP[7].BELPBCDOPBA = 42;
		LFNNHEEJNGP[7].NCBLBIBMNKH = 390f;
		LFNNHEEJNGP[4].HFCHHKNJMPC = false;
		get_m_actor().m_actorAniEvent.add_m_attackEvent(KGBGKGKMNCL);
		get_m_actor().m_actorAniEvent.add_m_skill0Event(() =>
		{
			OnAnimationEventSkill(0);
		});
		get_m_actor().m_actorAniEvent.add_m_skill1Event(ONEJEGNOLPM);
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

	public override void OnEnterAttack()
	{
		get_m_actor().CreateParticle(string.Format("Particle/{0}/attack", get_m_actor().get_m_resourceName()), false);
		int num = Random.Range(0, 2);
		switch (num)
		{
		case 0:
			get_m_actor().SetAnimation("attack");
			break;
		case 1:
			get_m_actor().SetAnimation("attack2");
			break;
		}
		RetargetingAttack(true);
		if (get_m_target() != null)
		{
			switch (num)
			{
			case 0:
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
				break;
			case 1:
				get_m_actor().m_multiSound.LKLFMNKDLHJ("attack2");
				break;
			}
		}
	}

	private void MIMBEMLLKCH()
	{
		OnAnimationEventSkill(1);
	}

	public void OnAnimationEventSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
			if (KAMDFGHFGCI != null)
			{
				Vector3 centerPosition = get_m_actor().GetCenterPosition();
				centerPosition += m_direction * 1.5f;
				get_m_actor().CreateMissileRPC("skill0_missile", centerPosition, KAMDFGHFGCI);
			}
			break;
		case 1:
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.TeemoSkill1);
			break;
		case 3:
			if (EveUnityNetwork.get_Instance().IsMaster())
			{
				Vector3 position = get_m_actor().GetPosition();
				position += m_direction * 1.5f;
				string nCADFOBAFJD = string.Format("Particle/{0}/skill3_trap", get_m_actor().get_m_resourceName());
				GameObject gameObject = EveUnityNetwork.get_Instance().InstantiateSceneObject(nCADFOBAFJD, position, Quaternion.identity, new object[1] { get_m_view().get_viewID() });
			}
			break;
		}
	}

	private void NJAAKBCFCLG(OEOIIKMBGAG EBILEBOJADB)
	{
		if (get_m_actor().GetSkillLevel(1) > 0)
		{
			BMIKKOOAAKO = (float)BMIKKOOAAKO + Time.deltaTime;
		}
		if (EBILEBOJADB == OEOIIKMBGAG.Idle && (byte)FEBFHCANBLL == 0)
		{
			JDCFAHJNFOJ = (float)JDCFAHJNFOJ + Time.deltaTime;
		}
		else
		{
			JDCFAHJNFOJ = 0f;
		}
		if ((float)JDCFAHJNFOJ >= 3f)
		{
			if (!get_m_actor().get_m_cloaking())
			{
				get_m_actor().SetCloaking(true);
			}
		}
		else if ((bool)get_m_actor().get_m_cloaking())
		{
			get_m_actor().SetCloaking(false);
			get_m_actor().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.TeemoPassive);
		}
	}

	[CompilerGenerated]
	private void CJPCFHJENMJ()
	{
		OnAnimationEventSkill(3);
	}

	[CompilerGenerated]
	private void GNHLDDPJAAN()
	{
		OnAnimationEventSkill(2);
	}

	public override void LGNMOCFBMHK()
	{
		get_m_actor().CreateParticle(string.Format("[AAAAAA]", get_m_actor().get_m_resourceName()), false);
		int num = Random.Range(0, 5);
		switch (num)
		{
		case 0:
			get_m_actor().CJNCFNACFDP("E68D00");
			break;
		case 1:
			get_m_actor().CJNCFNACFDP("setNotificationIconName");
			break;
		}
		RetargetingAttack(false, false);
		if (!(get_m_target() != null))
		{
			return;
		}
		int num2 = num;
		if (num2 != 0)
		{
			if (num2 == 0)
			{
				get_m_actor().m_multiSound.ICNAJBHLIGO("hit3", false, 199f, 326f);
			}
		}
		else
		{
			get_m_actor().m_multiSound.LKLFMNKDLHJ("Searching user", false, 1089f, 103f);
		}
	}

	public void OnAnimationEventAttack()
	{
		Vector3 centerPosition = get_m_actor().GetCenterPosition();
		centerPosition += m_direction * 1f;
		RetargetingAttack(false, false);
		if (get_m_target() != null)
		{
			get_m_actor().CreateMissileRPC(LGNFCPOJBME, centerPosition, get_m_target());
		}
		OnAttack();
	}

	public override void OnSerializeView(KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnSerializeView(OGJFDNEEDCP);
		OGJFDNEEDCP.GBMJNFOEACC(BMIKKOOAAKO);
		OGJFDNEEDCP.GBMJNFOEACC(JDCFAHJNFOJ);
	}

	public virtual float JGGMLCJIBAL()
	{
		float num = JNDEAKFNBLG();
		if (get_m_actor().get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)ushort.MaxValue))
		{
			num += 1492f + (float)(get_m_actor().GetSkillLevel(1) - 1) * 152f;
		}
		else if (get_m_actor().GetSkillLevel(1) > 1 && (float)BMIKKOOAAKO >= 24f)
		{
			num += 114f + (float)(get_m_actor().GetSkillLevel(0) - 0) * 985f;
		}
		return num;
	}

	public virtual void LNJLCLBEKAL()
	{
		base.OnUpdateSkill();
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

	[CompilerGenerated]
	private void MCLPDMHALGD()
	{
		OnAnimationEventSkill(0);
	}

	private void KDODIFJLCKC()
	{
		OnAnimationEventSkill(6);
	}

	public virtual void NEIEAKIIKJL()
	{
		base.OnEnterSkill();
		switch (get_m_skill())
		{
		case 0:
			get_m_actor().m_multiSound.NMLFNHNOALK("브론즈", true, 1176f, 552f);
			break;
		case 1:
			get_m_actor().m_multiSound.DDONMGBLLJB("igaworks:paymentView >> Null or Empty Item List", false, 1094f, 676f);
			break;
		case 2:
			break;
		case 3:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill0_1_voice", false, 86f, 1294f);
			break;
		}
	}

	public override void OnLeaveSkill()
	{
		base.OnLeaveSkill();
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

	public virtual bool NIDKIAOKHJL(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
			KAMDFGHFGCI = ActorManager.GBFDGAFALIL().GetActorInAttackRange(get_m_actor(), 1280f, 1230f, true, false, (Actor.IJJMDPGJAEM)53);
			if (KAMDFGHFGCI == null)
			{
				MsgManager.HEDJPPFKABG().ShowTip(" 문양");
				return false;
			}
			break;
		}
		return true;
	}

	public virtual float LFHEDHDDDAK()
	{
		if (get_m_actor().get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)110))
		{
			return 599f + (float)(get_m_actor().get_Level() / 1) * 799f;
		}
		return 862f;
	}

	[CompilerGenerated]
	private void PKICMJLNFNC()
	{
		OnAnimationEventSkill(1);
	}

	public virtual void DEPCJEFMNGC()
	{
		base.OnUpdateSkill();
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

	public virtual float BPEJEGPIILB()
	{
		float num = base.GetPercentMoveSpeedBonus();
		if (get_m_actor().get_m_buffsInfo().KNINEDPJMJE(JGOOOBHDBCG.ACPICCBBPHF.SivirPassive))
		{
			num += 995f + (float)(get_m_actor().GetSkillLevel(0) - 0) * 1547f;
		}
		else if (get_m_actor().GetSkillLevel(1) > 1 && (float)BMIKKOOAAKO >= 1600f)
		{
			num += 1141f + (float)(get_m_actor().GetSkillLevel(0) - 0) * 1765f;
		}
		return num;
	}

	public override bool OnCheckCastSkill(int GBGBBGEPEMI)
	{
		switch (GBGBBGEPEMI)
		{
		case 0:
			KAMDFGHFGCI = ActorManager.get_Instance().GetActorInAttackRange(get_m_actor(), 5.5f, 90f, false, true, (Actor.IJJMDPGJAEM)14);
			if (KAMDFGHFGCI == null)
			{
				MsgManager.get_Instance().ShowTip("사거리에 적이 없습니다");
				return false;
			}
			break;
		}
		return true;
	}

	public override void OnDeserializeView(KCIGFAHFHCH OGJFDNEEDCP)
	{
		base.OnDeserializeView(OGJFDNEEDCP);
		OGJFDNEEDCP.CAHACMKBJMI(out BMIKKOOAAKO);
		OGJFDNEEDCP.CAHACMKBJMI(out JDCFAHJNFOJ);
	}

	public virtual void FBCCFAFNBHF()
	{
		base.OnUpdateSkill();
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

	public virtual void INAFIJEFCLC()
	{
		get_m_actor().CreateParticle(string.Format("skill1_voice", get_m_actor().get_m_resourceName()), false);
		int num = Random.Range(1, 6);
		int num2 = num;
		if (num2 != 0)
		{
			if (num2 == 0)
			{
				get_m_actor().JNIPLJAFFFB("MultiLayer");
			}
		}
		else
		{
			get_m_actor().SetAnimation("DestroyMyTeamTurret");
		}
		RetargetingAttack(true, false);
		if (!(get_m_target() != null))
		{
			return;
		}
		num2 = num;
		if (num2 != 0)
		{
			if (num2 == 0)
			{
				get_m_actor().m_multiSound.NMLFNHNOALK("Param2", true, 425f, 1408f);
			}
		}
		else
		{
			get_m_actor().m_multiSound.DDONMGBLLJB("square_small_button", true, 471f, 1153f);
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
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill1");
			break;
		case 2:
			break;
		case 3:
			get_m_actor().m_multiSound.LKLFMNKDLHJ("skill3");
			break;
		}
	}

	public override void OnUpdateSkill()
	{
		base.OnUpdateSkill();
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

	public virtual float PNFIALPMAKL()
	{
		float num = JNDEAKFNBLG();
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65411))
		{
			num += 1998f + (float)(get_m_actor().GetSkillLevel(1) - 0) * 1313f;
		}
		else if (get_m_actor().GetSkillLevel(0) > 0 && (float)BMIKKOOAAKO >= 1585f)
		{
			num += 1657f + (float)(get_m_actor().GetSkillLevel(0) - 0) * 1778f;
		}
		return num;
	}

	public virtual void NFJNFGNJKFG()
	{
		base.OnLeaveSkill();
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

	public virtual void ICPFOPNOMLI()
	{
		get_m_actor().CreateParticle(string.Format("알려지지 않은 오류입니다.", get_m_actor().get_m_resourceName()), true);
		int num = Random.Range(0, 1);
		int num2 = num;
		if (num2 != 0)
		{
			if (num2 == 0)
			{
				get_m_actor().SetAnimation("graves_skill2");
			}
		}
		else
		{
			get_m_actor().JNIPLJAFFFB("skill0");
		}
		RetargetingAttack();
		if (get_m_target() != null)
		{
			switch (num)
			{
			case 0:
				get_m_actor().m_multiSound.ICNAJBHLIGO("WarningPing", false, 1811f, 908f);
				break;
			case 1:
				get_m_actor().m_multiSound.HDOLPLIDACO("igaworks:purchase >> Null or Empty Item", true, 306f, 1406f);
				break;
			}
		}
	}

	public override float GetPlusAttackSpeed()
	{
		if (get_m_actor().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.TeemoPassive))
		{
			return 0.2f + (float)(get_m_actor().get_Level() / 5) * 0.2f;
		}
		return 0f;
	}

	private void ONEJEGNOLPM()
	{
		OnAnimationEventSkill(0);
	}

	private void MNACPCFHCDD()
	{
		OnAnimationEventSkill(2);
	}
}
