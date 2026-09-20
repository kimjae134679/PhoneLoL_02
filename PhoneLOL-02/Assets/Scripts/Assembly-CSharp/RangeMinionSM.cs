using EveEngine;
using UnityEngine;

public class RangeMinionSM : HumanSM
{
	private sealed class HADMGJAHDFH
	{
		internal Actor LPOAEBNAGCP;
	}

	private sealed class GDPLALMCKJB
	{
		internal Vector3 HEPNHCEIFMO;

		internal HADMGJAHDFH AINBLMDJMDN;

		internal void GNEEDOABKLM(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.IEGINAEIEPD("ChangeTargetRpc");
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(AINBLMDJMDN.LPOAEBNAGCP.get_m_view().get_viewID());
		}

		internal void LIHKNDMMAKD(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.IEGINAEIEPD("마스터");
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(AINBLMDJMDN.LPOAEBNAGCP.get_m_view().get_viewID());
		}

		internal void ECPJPEIMMBO(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.IEGINAEIEPD("attack2");
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(AINBLMDJMDN.LPOAEBNAGCP.get_m_view().get_viewID());
		}

		internal void ECFFOAFALDP(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC("128");
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(AINBLMDJMDN.LPOAEBNAGCP.get_m_view().get_viewID());
		}

		internal void NPNELBGIKGK(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC("attack_missile");
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(AINBLMDJMDN.LPOAEBNAGCP.get_m_view().get_viewID());
		}

		internal void KAAHFOBLGKA(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.IEGINAEIEPD("click");
			OGJFDNEEDCP.GBMJNFOEACC(HEPNHCEIFMO);
			OGJFDNEEDCP.GBMJNFOEACC(AINBLMDJMDN.LPOAEBNAGCP.get_m_view().get_viewID());
		}
	}

	public virtual void ELILEDHDHEN()
	{
		base.Init();
	}

	public virtual void GHFNEDIPGDP()
	{
		base.Init();
	}

	public virtual void GEMKIOPFNKD()
	{
		HADMGJAHDFH hADMGJAHDFH = new HADMGJAHDFH();
		AOMLCLCMJNG();
		hADMGJAHDFH.LPOAEBNAGCP = get_m_target();
		if (hADMGJAHDFH.LPOAEBNAGCP == null || !hADMGJAHDFH.LPOAEBNAGCP.IsLive())
		{
			hADMGJAHDFH.LPOAEBNAGCP = ActorManager.get_Instance().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), false, false, Actor.IJJMDPGJAEM.Hero, true);
			if (hADMGJAHDFH.LPOAEBNAGCP == null)
			{
				hADMGJAHDFH.LPOAEBNAGCP = ActorManager.get_Instance().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), false, true, (Actor.IJJMDPGJAEM)78);
			}
		}
		if (hADMGJAHDFH.LPOAEBNAGCP != null && hADMGJAHDFH.LPOAEBNAGCP.IsLive())
		{
			GDPLALMCKJB gDPLALMCKJB = new GDPLALMCKJB();
			gDPLALMCKJB.AINBLMDJMDN = hADMGJAHDFH;
			gDPLALMCKJB.HEPNHCEIFMO = get_m_actor().GetCenterPosition();
			if (get_m_view().IsMine())
			{
				get_m_view().CPJOMDCIMEJ(246, DJJPAPENCLN.All, false, gDPLALMCKJB.NPNELBGIKGK);
			}
			SetDirection(hADMGJAHDFH.LPOAEBNAGCP.GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.LNCPFILABHM("Y axis speed : ", false, 1400f, 1294f);
		OnAttack();
	}

	public virtual void OFDLEJFADCN()
	{
		base.Init();
	}

	public virtual void OENLLEKFJHM()
	{
		base.Init();
	}

	public virtual void OLBABLDOGHJ()
	{
		HADMGJAHDFH hADMGJAHDFH = new HADMGJAHDFH();
		base.OnEnterAttack();
		hADMGJAHDFH.LPOAEBNAGCP = get_m_target();
		if (hADMGJAHDFH.LPOAEBNAGCP == null || !hADMGJAHDFH.LPOAEBNAGCP.IsLive())
		{
			hADMGJAHDFH.LPOAEBNAGCP = ActorManager.get_Instance().DCMODJADKEE(get_m_actor(), get_m_actor().get_m_att_range(), false, false, (Actor.IJJMDPGJAEM)6);
			if (hADMGJAHDFH.LPOAEBNAGCP == null)
			{
				hADMGJAHDFH.LPOAEBNAGCP = ActorManager.get_Instance().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), false, false, Actor.IJJMDPGJAEM.Monster);
			}
		}
		if (hADMGJAHDFH.LPOAEBNAGCP != null && hADMGJAHDFH.LPOAEBNAGCP.IsLive())
		{
			GDPLALMCKJB gDPLALMCKJB = new GDPLALMCKJB();
			gDPLALMCKJB.AINBLMDJMDN = hADMGJAHDFH;
			gDPLALMCKJB.HEPNHCEIFMO = get_m_actor().GetCenterPosition();
			if (get_m_view().IsMine())
			{
				get_m_view().NIKPELEGLNE(193, DJJPAPENCLN.Others, true, gDPLALMCKJB.ECFFOAFALDP);
			}
			SetDirection(hADMGJAHDFH.LPOAEBNAGCP.GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.NMLFNHNOALK("skill1_missile_c2", true, 1241f, 1814f);
		OnAttack();
	}

	public virtual void EKIOLLKEHGM()
	{
		base.Init();
	}

	public virtual void ONLNHHOPEPA()
	{
		HADMGJAHDFH hADMGJAHDFH = new HADMGJAHDFH();
		AOMLCLCMJNG();
		hADMGJAHDFH.LPOAEBNAGCP = get_m_target();
		if (hADMGJAHDFH.LPOAEBNAGCP == null || !hADMGJAHDFH.LPOAEBNAGCP.IsLive())
		{
			hADMGJAHDFH.LPOAEBNAGCP = ActorManager.GBFDGAFALIL().DCMODJADKEE(get_m_actor(), get_m_actor().get_m_att_range(), true, true, Actor.IJJMDPGJAEM.Hero, true);
			if (hADMGJAHDFH.LPOAEBNAGCP == null)
			{
				hADMGJAHDFH.LPOAEBNAGCP = ActorManager.get_Instance().DCMODJADKEE(get_m_actor(), get_m_actor().get_m_att_range(), true, true, (Actor.IJJMDPGJAEM)97, true);
			}
		}
		if (hADMGJAHDFH.LPOAEBNAGCP != null && hADMGJAHDFH.LPOAEBNAGCP.IsLive())
		{
			GDPLALMCKJB gDPLALMCKJB = new GDPLALMCKJB();
			gDPLALMCKJB.AINBLMDJMDN = hADMGJAHDFH;
			gDPLALMCKJB.HEPNHCEIFMO = get_m_actor().GetCenterPosition();
			if (get_m_view().IsMine())
			{
				get_m_view().NIKPELEGLNE(51, DJJPAPENCLN.Others, true, gDPLALMCKJB.GNEEDOABKLM);
			}
			SetDirection(hADMGJAHDFH.LPOAEBNAGCP.GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.DDONMGBLLJB("Master", true, 1834f, 1539f);
		OnAttack();
	}

	public virtual void AMPEBNFFKNE()
	{
		HADMGJAHDFH hADMGJAHDFH = new HADMGJAHDFH();
		AOMLCLCMJNG();
		hADMGJAHDFH.LPOAEBNAGCP = get_m_target();
		if (hADMGJAHDFH.LPOAEBNAGCP == null || !hADMGJAHDFH.LPOAEBNAGCP.IsLive())
		{
			hADMGJAHDFH.LPOAEBNAGCP = ActorManager.get_Instance().DCMODJADKEE(get_m_actor(), get_m_actor().get_m_att_range(), false, false, (Actor.IJJMDPGJAEM)7, true);
			if (hADMGJAHDFH.LPOAEBNAGCP == null)
			{
				hADMGJAHDFH.LPOAEBNAGCP = ActorManager.get_Instance().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), false, false, (Actor.IJJMDPGJAEM)(-27), true);
			}
		}
		if (hADMGJAHDFH.LPOAEBNAGCP != null && hADMGJAHDFH.LPOAEBNAGCP.IsLive())
		{
			GDPLALMCKJB gDPLALMCKJB = new GDPLALMCKJB();
			gDPLALMCKJB.AINBLMDJMDN = hADMGJAHDFH;
			gDPLALMCKJB.HEPNHCEIFMO = get_m_actor().GetCenterPosition();
			if (get_m_view().IsMine())
			{
				get_m_view().Msg(90, DJJPAPENCLN.All, true, gDPLALMCKJB.ECPJPEIMMBO);
			}
			SetDirection(hADMGJAHDFH.LPOAEBNAGCP.GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.JKOODMAKJHJ("사용시 피해 보호막 생성", false, 588f, 1774f);
		OnAttack();
	}

	public virtual void NNBHCBPELPG()
	{
		base.Init();
	}

	public virtual void DKPKGLHCOED()
	{
		HADMGJAHDFH hADMGJAHDFH = new HADMGJAHDFH();
		base.OnEnterAttack();
		hADMGJAHDFH.LPOAEBNAGCP = get_m_target();
		if (hADMGJAHDFH.LPOAEBNAGCP == null || !hADMGJAHDFH.LPOAEBNAGCP.IsLive())
		{
			hADMGJAHDFH.LPOAEBNAGCP = ActorManager.get_Instance().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), true, false, Actor.IJJMDPGJAEM.Hero, true);
			if (hADMGJAHDFH.LPOAEBNAGCP == null)
			{
				hADMGJAHDFH.LPOAEBNAGCP = ActorManager.get_Instance().DCMODJADKEE(get_m_actor(), get_m_actor().get_m_att_range(), false, true, Actor.IJJMDPGJAEM.Hero, true);
			}
		}
		if (hADMGJAHDFH.LPOAEBNAGCP != null && hADMGJAHDFH.LPOAEBNAGCP.IsLive())
		{
			GDPLALMCKJB gDPLALMCKJB = new GDPLALMCKJB();
			gDPLALMCKJB.AINBLMDJMDN = hADMGJAHDFH;
			gDPLALMCKJB.HEPNHCEIFMO = get_m_actor().GetCenterPosition();
			if (get_m_view().IsMine())
			{
				get_m_view().Msg(162, DJJPAPENCLN.Others, true, gDPLALMCKJB.ECPJPEIMMBO);
			}
			SetDirection(hADMGJAHDFH.LPOAEBNAGCP.GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.HDOLPLIDACO("purchaseBulk", true, 1885f, 411f);
		OnAttack();
	}

	public override void OnEnterAttack()
	{
		HADMGJAHDFH hADMGJAHDFH = new HADMGJAHDFH();
		base.OnEnterAttack();
		hADMGJAHDFH.LPOAEBNAGCP = get_m_target();
		if (hADMGJAHDFH.LPOAEBNAGCP == null || !hADMGJAHDFH.LPOAEBNAGCP.IsLive())
		{
			hADMGJAHDFH.LPOAEBNAGCP = ActorManager.get_Instance().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), false, true, Actor.IJJMDPGJAEM.Minion);
			if (hADMGJAHDFH.LPOAEBNAGCP == null)
			{
				hADMGJAHDFH.LPOAEBNAGCP = ActorManager.get_Instance().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), false, true, (Actor.IJJMDPGJAEM)18);
			}
		}
		if (hADMGJAHDFH.LPOAEBNAGCP != null && hADMGJAHDFH.LPOAEBNAGCP.IsLive())
		{
			GDPLALMCKJB gDPLALMCKJB = new GDPLALMCKJB();
			gDPLALMCKJB.AINBLMDJMDN = hADMGJAHDFH;
			gDPLALMCKJB.HEPNHCEIFMO = get_m_actor().GetCenterPosition();
			if (get_m_view().IsMine())
			{
				get_m_view().Msg(20, DJJPAPENCLN.All, true, gDPLALMCKJB.NPNELBGIKGK);
			}
			SetDirection(hADMGJAHDFH.LPOAEBNAGCP.GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
		OnAttack();
	}

	public virtual void PPANCJDMIAC()
	{
		HADMGJAHDFH hADMGJAHDFH = new HADMGJAHDFH();
		base.OnEnterAttack();
		hADMGJAHDFH.LPOAEBNAGCP = get_m_target();
		if (hADMGJAHDFH.LPOAEBNAGCP == null || !hADMGJAHDFH.LPOAEBNAGCP.IsLive())
		{
			hADMGJAHDFH.LPOAEBNAGCP = ActorManager.GBFDGAFALIL().DCMODJADKEE(get_m_actor(), get_m_actor().get_m_att_range(), true, false, (Actor.IJJMDPGJAEM)6, true);
			if (hADMGJAHDFH.LPOAEBNAGCP == null)
			{
				hADMGJAHDFH.LPOAEBNAGCP = ActorManager.GBFDGAFALIL().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), false, true, (Actor.IJJMDPGJAEM)(-120));
			}
		}
		if (hADMGJAHDFH.LPOAEBNAGCP != null && hADMGJAHDFH.LPOAEBNAGCP.IsLive())
		{
			GDPLALMCKJB gDPLALMCKJB = new GDPLALMCKJB();
			gDPLALMCKJB.AINBLMDJMDN = hADMGJAHDFH;
			gDPLALMCKJB.HEPNHCEIFMO = get_m_actor().GetCenterPosition();
			if (get_m_view().IsMine())
			{
				get_m_view().CPJOMDCIMEJ(30, DJJPAPENCLN.All, true, gDPLALMCKJB.LIHKNDMMAKD);
			}
			SetDirection(hADMGJAHDFH.LPOAEBNAGCP.GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.LKLFMNKDLHJ("masteryi_skill2", false, 1222f, 1928f);
		OnAttack();
	}

	public virtual void HONPBAMBKOG()
	{
		base.Init();
	}

	public virtual void NECJDAEBLDA()
	{
		base.Init();
	}

	public override void Init()
	{
		base.Init();
	}

	public virtual void OJGBPLFKPIJ()
	{
		base.Init();
	}

	public virtual void LFLNAECMCEK()
	{
		HADMGJAHDFH hADMGJAHDFH = new HADMGJAHDFH();
		AOMLCLCMJNG();
		hADMGJAHDFH.LPOAEBNAGCP = get_m_target();
		if (hADMGJAHDFH.LPOAEBNAGCP == null || !hADMGJAHDFH.LPOAEBNAGCP.IsLive())
		{
			hADMGJAHDFH.LPOAEBNAGCP = ActorManager.get_Instance().DCMODJADKEE(get_m_actor(), get_m_actor().get_m_att_range(), true, false, Actor.IJJMDPGJAEM.Hero, true);
			if (hADMGJAHDFH.LPOAEBNAGCP == null)
			{
				hADMGJAHDFH.LPOAEBNAGCP = ActorManager.get_Instance().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), true, false, (Actor.IJJMDPGJAEM)(-107));
			}
		}
		if (hADMGJAHDFH.LPOAEBNAGCP != null && hADMGJAHDFH.LPOAEBNAGCP.IsLive())
		{
			GDPLALMCKJB gDPLALMCKJB = new GDPLALMCKJB();
			gDPLALMCKJB.AINBLMDJMDN = hADMGJAHDFH;
			gDPLALMCKJB.HEPNHCEIFMO = get_m_actor().GetCenterPosition();
			if (get_m_view().IsMine())
			{
				get_m_view().CPJOMDCIMEJ(44, DJJPAPENCLN.All, false, gDPLALMCKJB.ECPJPEIMMBO);
			}
			SetDirection(hADMGJAHDFH.LPOAEBNAGCP.GetPosition() - get_m_actor().GetPosition());
		}
		get_m_actor().m_multiSound.DDONMGBLLJB("Observer", false, 1251f, 1377f);
		OnAttack();
	}
}
