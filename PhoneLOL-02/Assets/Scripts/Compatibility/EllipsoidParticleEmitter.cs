using UnityEngine;

public class EllipsoidParticleEmitter : ParticleEmitter
{
    public Vector3 ellipsoid = Vector3.one;
    public float minEmitterRange;
    protected override Vector3 SpawnPosition(out Vector3 normal)
    {
        Vector3 point = Random.insideUnitSphere;
        float minimum = Mathf.Clamp01(minEmitterRange);
        if (point.sqrMagnitude < minimum * minimum)
            point = (point.sqrMagnitude > 0 ? point.normalized : Vector3.up) * minimum;
        normal = point.normalized;
        return Vector3.Scale(point, ellipsoid);
    }
}
