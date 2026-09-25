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
        Vector3 position;
        if (!TryGetSpawnPosition(spawn, oppositeSpawn, team, out position))
            throw new System.InvalidOperationException("Practice target base flank is not navigable.");
        return position;
    }

    public static bool TryGetSpawnPosition(Vector3 spawn, Vector3 oppositeSpawn, byte team, out Vector3 position)
    {
        // Keep both targets beside the spawn circles inside their bases.
        // A 28-unit offset with a 20-unit snap previously moved them into the jungle.
        float side = team == 0 ? 1f : -1f;
        bool straightMap = Mathf.Abs(spawn.z - oppositeSpawn.z) < 1f;
        position = spawn + new Vector3((straightMap ? 10f : 12f) * side, 0f,
                                      straightMap ? -4f * side : 0f);
        UnityEngine.AI.NavMeshHit ground, edge;
        if (!UnityEngine.AI.NavMesh.SamplePosition(position, out ground, 1f, UnityEngine.AI.NavMesh.AllAreas) ||
            !UnityEngine.AI.NavMesh.FindClosestEdge(ground.position, out edge, UnityEngine.AI.NavMesh.AllAreas) ||
            edge.distance < 1f)
            return false; // Retry after navigation loads; do not jump to another area.
        position = ground.position;
        foreach (var terrain in Terrain.activeTerrains) {
            var origin = terrain.transform.position;
            var size = terrain.terrainData.size;
            if (position.x >= origin.x && position.x <= origin.x + size.x &&
                position.z >= origin.z && position.z <= origin.z + size.z)
                position.y = Mathf.Max(position.y, terrain.SampleHeight(position) + origin.y + 0.05f);
        }
        return true;
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
