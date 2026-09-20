using UnityEngine;

public class ParticleAnimator : MonoBehaviour
{
    public bool autodestruct, doesAnimateColor, stopSimulation;
    public Vector3 force, rndForce, localRotationAxis, worldRotationAxis;
    public float sizeGrow, damping;
    public Color[] colorAnimation = { Color.white, Color.white, Color.white, Color.white, Color.white };
    private ParticleEmitter emitter;
    private ParticleSystem.Particle[] buffer = new ParticleSystem.Particle[0];
    private bool hadParticles;
    private void LateUpdate()
    {
        if (emitter == null) emitter = GetComponent<ParticleEmitter>();
        if (emitter == null) return;
        var ps = emitter.System;
        if (stopSimulation) { ps.Pause(false); return; }
        if (ps.isPaused) ps.Play(false);
        if (buffer.Length < ps.particleCount) buffer = new ParticleSystem.Particle[ps.particleCount + 64];
        int count = ps.GetParticles(buffer);
        float dt = Time.deltaTime;
        for (int i = 0; i < count; i++)
        {
            Vector3 acceleration = force + new Vector3(Random.Range(-rndForce.x, rndForce.x),
                Random.Range(-rndForce.y, rndForce.y), Random.Range(-rndForce.z, rndForce.z));
            if (!emitter.useWorldSpace) acceleration = transform.InverseTransformDirection(acceleration);
            buffer[i].velocity = (buffer[i].velocity + acceleration * dt) * Mathf.Pow(Mathf.Clamp01(1 - damping), dt);
            buffer[i].startSize = Mathf.Max(0, buffer[i].startSize + sizeGrow * dt);
            Vector3 axis = worldRotationAxis + transform.TransformDirection(localRotationAxis);
            if (!emitter.useWorldSpace) axis = transform.InverseTransformDirection(axis);
            if (axis.sqrMagnitude > 0)
            {
                Vector3 origin = emitter.useWorldSpace ? transform.position : Vector3.zero;
                buffer[i].position = origin + Quaternion.Euler(axis * dt) * (buffer[i].position - origin);
            }
            if (doesAnimateColor && colorAnimation != null && colorAnimation.Length > 0)
            {
                float age = 1 - buffer[i].remainingLifetime / Mathf.Max(0.001f, buffer[i].startLifetime);
                float key = Mathf.Clamp01(age) * (colorAnimation.Length - 1);
                int index = Mathf.Min(Mathf.FloorToInt(key), colorAnimation.Length - 1);
                buffer[i].startColor = Color.Lerp(colorAnimation[index],
                    colorAnimation[Mathf.Min(index + 1, colorAnimation.Length - 1)], key - index);
            }
        }
        ps.SetParticles(buffer, count);
        if (count > 0) hadParticles = true;
        if (autodestruct && hadParticles && count == 0 && (!emitter.emit || emitter.oneShot))
            Destroy(gameObject);
    }
}
