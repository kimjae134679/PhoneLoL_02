using UnityEngine;

// A networked practice target; it has no participant or scoreboard entry.
public sealed class PhoneLOLPracticeGuardSM : HumanSM
{
    private Vector3 home;
    private bool initialized;
    public override void Init() { base.Init(); home = transform.position; initialized = true; }
    public override void OnUpdateIdle() { }
    public override void OnEnterAttack() { SetState(OEOIIKMBGAG.Idle); }
    public override void OnUpdateAttack() { SetState(OEOIIKMBGAG.Idle); }
    public override void OnUpdateRun() { SetState(OEOIIKMBGAG.Idle); }
    public override void OnEnterDeath()
    {
        // Revive the same scene identity immediately on every damage recipient.
        get_m_actor().m_hp = 100000;
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
