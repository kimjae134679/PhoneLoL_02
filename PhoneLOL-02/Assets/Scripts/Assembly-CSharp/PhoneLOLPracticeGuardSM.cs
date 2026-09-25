using EveEngine;
using UnityEngine;

// A networked practice target; it has no participant or scoreboard entry.
public sealed class PhoneLOLPracticeGuardSM : HumanSM
{
    public const int MaxHealth = 20000;
    public const int KillGold = 1000;
    public const float RespawnDelay = 1f;
    private bool respawning;
    private float respawnAt;

    public byte SpawnTeam { get; private set; }

    public void Configure(byte spawnTeam)
    {
        SpawnTeam = spawnTeam;
        var actor = GetComponent<Actor>();
        actor.m_actorType = Actor.IJJMDPGJAEM.Monster;
        actor.m_team = spawnTeam; // Only the opposite team may attack its base target.
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
    private static Actor ResolveOwner(Actor actor)
    {
        if (actor != null && actor.get_m_stateMachine() != null &&
            actor.get_m_stateMachine().get_m_owner() != null)
            return actor.get_m_stateMachine().get_m_owner();
        return actor;
    }

    public bool CanReceiveDamage(Actor attacker)
    {
        attacker = ResolveOwner(attacker);
        return !respawning && attacker != null && attacker.m_team == 1 - SpawnTeam;
    }

    public bool CanReceiveDamage(int attackerViewID)
    {
        var view = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(attackerViewID);
        return CanReceiveDamage(view == null ? null : view.GetComponent<Actor>());
    }

    public void ApplyKillReward(int attackerViewID)
    {
        var view = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(attackerViewID);
        var killer = ResolveOwner(view == null ? null : view.GetComponent<Actor>());
        // The authoritative damage message updates each replica's killer once.
        if (CanReceiveDamage(killer) && killer.m_actorType == Actor.IJJMDPGJAEM.Hero)
            killer.IncreaseMoney(KillGold);
    }

    public override void OnEnterDeath()
    {
        if (respawning) return;
        respawning = true;
        respawnAt = Time.time + RespawnDelay;
        get_m_actor().m_hp = 0f;
        get_m_actor().m_dontDamage = true;
        SetStateForce(OEOIIKMBGAG.Death);
        // Use Alistar's existing death animation and death audio.
        base.OnEnterDeath();
    }

    public override void OnUpdateDeath()
    {
        // The current scene owner also handles this after a host migration.
        if (respawning && Time.time >= respawnAt && get_m_view().IsMine())
            get_m_view().RPC("RespawnPracticeGuardRPC", DJJPAPENCLN.All);
    }

    [JDLHECHNNDH]
    public void RespawnPracticeGuardRPC()
    {
        if (!respawning) return;
        var actor = get_m_actor();
        transform.position = home;
        actor.get_m_buffsInfo().DOGNNGPHIDC();
        actor.m_hp = MaxHealth;
        actor.m_dontDamage = false;
        respawning = false;
        SetStateForce(OEOIIKMBGAG.Idle);
        actor.SetAnimation("idle");
        if (actor.get_m_damageHUD() != null) {
            actor.get_m_damageHUD().gameObject.SetActive(true);
            actor.get_m_damageHUD().Refresh();
        }
    }

    private void LateUpdate()
    {
        if (!initialized) return;
        transform.position = home;
    }
}
