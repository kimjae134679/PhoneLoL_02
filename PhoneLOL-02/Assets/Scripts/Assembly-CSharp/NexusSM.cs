using UnityEngine;

public class NexusSM : RangeMonsterSM
{
    private bool defenseConfigured;
    private float defenseElapsed;

    public override void OnUpdateIdle()
    {
        base.OnUpdateIdle();
        var actor = get_m_actor();
        if (actor == null || actor.GetHeroInfo() == null || !actor.IsLive()) return;
        if (!defenseConfigured) {
            // Use the inner turret's attack stats without changing nexus identity or health.
            var turret = new GameServer.NEFBHKKAMJF();
            turret.FIGLEPBIEEJ(30002);
            var source = turret.GPNKIAHCKMG.IIJMLJCIJFD();
            var stats = actor.GetHeroInfo().GPNKIAHCKMG.IIJMLJCIJFD();
            stats.IIICODNIMNN = source.IIICODNIMNN;
            stats.LOJEMAMKHFD = source.LOJEMAMKHFD;
            stats.ELDBGIKHAIO = source.ELDBGIKHAIO;
            stats.LNKFLFOGCCD = source.LNKFLFOGCCD;
            stats.FHJCBAOBGPG = source.FHJCBAOBGPG;
            defenseConfigured = true;
            ActorManager.get_Instance().EnsurePracticeGuard((byte)actor.m_team);
            defenseElapsed = actor.get_m_attackCoolTime();
        }
        if (!EveUnityNetwork.get_Instance().IsMaster()) return;
        defenseElapsed += Time.deltaTime;
        if (defenseElapsed < actor.get_m_attackCoolTime()) return;
        var target = ActorManager.get_Instance().GetActorInRange(actor, actor.get_m_att_range(), false, true,
            Actor.IJJMDPGJAEM.Minion | Actor.IJJMDPGJAEM.SubHero, true);
        if (target == null) target = ActorManager.get_Instance().GetActorInRange(actor, actor.get_m_att_range(), false, true, Actor.IJJMDPGJAEM.Hero, true);
        if (target == null || !target.IsLive()) return;
        IAKBNJEFLAN(target);
        actor.CreateMissileRPC("attack_missile", actor.GetPosition() + Vector3.up * 2.5f, target);
        defenseElapsed = 0f;
    }

	public virtual void EANGPHJBBHH()
	{
		base.INOKJCKAONB();
	}

	public virtual void LACFCPENMII()
	{
		base.OnEnterDeath();
		get_m_actor().CreateParticle(string.Format("campaignkey", get_m_actor().get_m_resourceName()), false);
		CALECABBOMG = 1643f;
	}

	public virtual void KGEGGNFOKML()
	{
		base.OnEnterDeath();
		get_m_actor().CreateParticle(string.Format("setExceptionPermissionList", get_m_actor().get_m_resourceName()), false);
		CALECABBOMG = 790f;
	}

	public override void OnEnterDeath()
	{
		base.OnEnterDeath();
		get_m_actor().CreateParticle(string.Format("Particle/{0}/death", get_m_actor().get_m_resourceName()), false);
		CALECABBOMG = 1f;
	}

	public virtual void FLPLDJOAGNB()
	{
		base.OnEnterDeath();
		get_m_actor().CreateParticle(string.Format("中級", get_m_actor().get_m_resourceName()), false);
		CALECABBOMG = 188f;
	}

	public virtual void FOPBBEOKKDF()
	{
		base.OnEnterDeath();
		get_m_actor().CreateParticle(string.Format("설명", get_m_actor().get_m_resourceName()), false);
		CALECABBOMG = 368f;
	}

	public virtual void OAADIIIMNDE()
	{
		base.Init();
	}

	public virtual void EONJGMEGPED()
	{
		base.OnEnterDeath();
		get_m_actor().CreateParticle(string.Format("KEY", get_m_actor().get_m_resourceName()), true);
		CALECABBOMG = 662f;
	}

	public virtual void HADPFKLIECN()
	{
		base.OnEnterDeath();
		get_m_actor().CreateParticle(string.Format("skill2_voice", get_m_actor().get_m_resourceName()), true);
		CALECABBOMG = 1388f;
	}

	public virtual void DCGNEDBKNHP()
	{
		base.OnEnterDeath();
		get_m_actor().CreateParticle(string.Format("0.0", get_m_actor().get_m_resourceName()), false);
		CALECABBOMG = 1113f;
	}

	public override void INOKJCKAONB()
	{
		base.Init();
	}

	public virtual void DPKPIOOHDMJ()
	{
		base.Init();
	}

	public virtual void PCLCGMPPOLJ()
	{
		base.OnEnterDeath();
		get_m_actor().CreateParticle(string.Format("yyyy년 MM월 dd일", get_m_actor().get_m_resourceName()), true);
		CALECABBOMG = 1117f;
	}

	public virtual void OFDLEJFADCN()
	{
		base.INOKJCKAONB();
	}

	public virtual void HEFDBBEPIIB()
	{
		base.OnEnterDeath();
		get_m_actor().CreateParticle(string.Format("skill1_shot", get_m_actor().get_m_resourceName()), false);
		CALECABBOMG = 67f;
	}

	public virtual void GIAPAPFONAE()
	{
		base.OnEnterDeath();
		get_m_actor().CreateParticle(string.Format("다행히 생각보다 상처가 심한거 같지는 않군..\n라이너! 치료 할 수 있겠지?!", get_m_actor().get_m_resourceName()), false);
		CALECABBOMG = 783f;
	}

	public virtual void KJBADLDBAOA()
	{
		base.Init();
	}

	public virtual void MKLOAONHAGL()
	{
		base.OnEnterDeath();
		get_m_actor().CreateParticle(string.Format("hit2", get_m_actor().get_m_resourceName()), false);
		CALECABBOMG = 306f;
	}

	public virtual void IAEJDLCFJID()
	{
		base.OnEnterDeath();
		get_m_actor().CreateParticle(string.Format("ReqeustRecoveryRPC", get_m_actor().get_m_resourceName()), true);
		CALECABBOMG = 397f;
	}

	public virtual void NDAONEEABHA()
	{
		base.OnEnterDeath();
		get_m_actor().CreateParticle(string.Format("Particle/Vladimir/skill3_ex", get_m_actor().get_m_resourceName()), false);
		CALECABBOMG = 1636f;
	}

	public override void Init()
	{
		base.Init();
	}
}
