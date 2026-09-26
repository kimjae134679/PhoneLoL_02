using UnityEngine;

// Preserve the legacy editable particle data while retaining native particle identity.
[System.Serializable]
public struct Particle
{
    internal ParticleSystem.Particle native;
    public Vector3 position, velocity;
    public float energy, startEnergy, size, angularVelocity, rotation;
    public Color color;
    internal static Particle FromNative(ParticleSystem.Particle p)
    {
        return new Particle { native = p, position = p.position, velocity = p.velocity,
            energy = p.remainingLifetime, startEnergy = p.startLifetime, size = p.startSize,
            angularVelocity = p.angularVelocity, rotation = p.rotation, color = p.startColor };
    }
    internal ParticleSystem.Particle ToNative()
    {
        var p = native;
        p.position = position; p.velocity = velocity; p.remainingLifetime = energy;
        p.startLifetime = startEnergy; p.startSize = size; p.angularVelocity = angularVelocity;
        p.rotation = rotation; p.startColor = color;
        return p;
    }
}
