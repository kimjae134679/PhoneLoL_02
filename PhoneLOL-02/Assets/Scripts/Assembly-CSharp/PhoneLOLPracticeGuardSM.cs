using UnityEngine;

// A networked practice target; it has no participant or scoreboard entry.
public sealed class PhoneLOLPracticeGuardSM : HumanSM
{
    public const int MaxHealth = 20000;
    public const int KillGold = 1000;

    public byte SpawnTeam { get; private set; }

    public void Configure(byte spawnTeam)
    {
        SpawnTeam = spawnTeam;
        var actor = GetComponent<Actor>();
        actor.m_actorType = Actor.IJJMDPGJAEM.Monster;
        actor.m_team = 2; // The same neutral combat team used by jungle monsters.
        actor.m_dontDamage = false;
        GetComponent<EveView>().set_isSceneObject(true);
    }

    public static Vector3 GetSpawnPosition(Vector3 spawn, Vector3 oppositeSpawn, byte team)
    {
        // Mirror the sketch: bottom spawn's target to the right; top spawn's to the left.
        float side = team == 0 ? 1f : -1f;
        var position = spawn + Vector3.right * (28f * side);
        // The straight map also needs lateral separation from the central travel lane.
        if (Mathf.Abs(spawn.z - oppositeSpawn.z) < 1f) position.z -= 8f * side;
        UnityEngine.AI.NavMeshHit ground;
        if (UnityEngine.AI.NavMesh.SamplePosition(position, out ground, 3f, UnityEngine.AI.NavMesh.AllAreas))
            position = ground.position;
        return position;
    }

    private Vector3 home;
    private bool initialized;
    public override void Init() { base.Init(); home = transform.position; initialized = true; }
    public override void OnUpdateIdle() { }
    public override void OnEnterAttack() { SetState(OEOIIKMBGAG.Idle); }
    public override void OnUpdateAttack() { SetState(OEOIIKMBGAG.Idle); }
    public override void OnUpdateRun() { SetState(OEOIIKMBGAG.Idle); }
    public void ApplyKillReward(int attackerViewID)
    {
        var view = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(attackerViewID);
        var killer = view == null ? null : view.GetComponent<Actor>();
        if (killer != null && killer.get_m_stateMachine().get_m_owner() != null)
            killer = killer.get_m_stateMachine().get_m_owner();
        // Damage messages run once on each peer; update the same killer replica as normal kill gold.
        if (killer != null && killer.m_actorType == Actor.IJJMDPGJAEM.Hero)
            killer.IncreaseMoney(KillGold);
    }

    public override void OnEnterDeath()
    {
        // Revive the same scene identity immediately on every damage recipient.
        get_m_actor().m_hp = MaxHealth;
        transform.position = home;
        get_m_actor().get_m_buffsInfo().DOGNNGPHIDC();
        SetStateForce(OEOIIKMBGAG.Idle);
        get_m_actor().SetAnimation("idle");
    }
    private void LateUpdate()
    {
        if (!initialized) return;
        transform.position = home;
    }
}
