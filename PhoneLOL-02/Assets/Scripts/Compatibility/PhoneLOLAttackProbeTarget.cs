#if UNITY_EDITOR
using UnityEngine;

// Editor-only endpoint for verifying that a projectile actually delivers an attack.
public sealed class PhoneLOLAttackProbeTarget : Actor
{
    public int receivedAttacks;
    public override float OnAttackDamage(Actor source, double physical = 0.0, double magical = 0.0, double pure = 0.0)
    {
        receivedAttacks++;
        return 1f;
    }
}
#endif
