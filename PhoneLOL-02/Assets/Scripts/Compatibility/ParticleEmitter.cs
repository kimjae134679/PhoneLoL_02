using UnityEngine;

[DefaultExecutionOrder(-1000)]
public class ParticleEmitter : MonoBehaviour
{
    public bool emit = true, useWorldSpace = true, oneShot, rndRotation;
    public float minSize = 1, maxSize = 1, minEnergy = 1, maxEnergy = 1;
    public float minEmission, maxEmission, angularVelocity, rndAngularVelocity, emitterVelocityScale;
    public Vector3 worldVelocity, localVelocity, rndVelocity, tangentVelocity;
    private ParticleSystem system;
    private Vector3 previousPosition;
    private float emissionRemainder;
    private bool burstEmitted;
    internal ParticleSystem System
    {
        get
        {
            if (system != null) return system;
            system = GetComponent<ParticleSystem>();
            if (system == null) system = gameObject.AddComponent<ParticleSystem>();
            system.Stop(false, ParticleSystemStopBehavior.StopEmittingAndClear);
            var main = system.main;
            main.playOnAwake = false; main.loop = true; main.startSpeed = 0;
            main.maxParticles = 10000; main.scalingMode = ParticleSystemScalingMode.Local;
            var emission = system.emission; emission.enabled = false;
            var shape = system.shape; shape.enabled = false;
            ApplySpace();
            system.Play(false);
            return system;
        }
    }
    private void ApplySpace()
    {
        var main = system.main;
        main.simulationSpace = useWorldSpace ? ParticleSystemSimulationSpace.World : ParticleSystemSimulationSpace.Local;
    }
    protected virtual void Awake() { var initialized = System; previousPosition = transform.position; }
    protected virtual void OnEnable() { previousPosition = transform.position; burstEmitted = false; }
    private void Update()
    {
        var initialized = System;
        ApplySpace();
        if (!emit) { burstEmitted = false; previousPosition = transform.position; return; }
        if (oneShot)
        {
            if (!burstEmitted) { Emit(); burstEmitted = true; }
        }
        else
        {
            emissionRemainder += Mathf.Max(0, Random.Range(minEmission, maxEmission)) * Time.deltaTime;
            int count = Mathf.FloorToInt(emissionRemainder);
            emissionRemainder -= count;
            if (count > 0) Emit(count);
        }
        previousPosition = transform.position;
    }
    protected virtual Vector3 SpawnPosition(out Vector3 normal)
    { normal = Vector3.up; return Vector3.zero; }
    protected virtual float NormalSpeed() { return 0; }
    public void Emit() { Emit(Mathf.Max(0, Mathf.RoundToInt(Random.Range(minEmission, maxEmission)))); }
    public void Emit(int count)
    {
        var ps = System;
        ApplySpace();
        for (int i = 0; i < Mathf.Clamp(count, 0, 10000); i++)
        {
            Vector3 normal;
            Vector3 position = SpawnPosition(out normal);
            Vector3 random = new Vector3(Random.Range(-rndVelocity.x, rndVelocity.x),
                Random.Range(-rndVelocity.y, rndVelocity.y), Random.Range(-rndVelocity.z, rndVelocity.z));
            Vector3 local = localVelocity + random + normal * NormalSpeed() + Vector3.Cross(position, tangentVelocity);
            Vector3 inherited = Time.deltaTime > 0 ? (transform.position - previousPosition) / Time.deltaTime * emitterVelocityScale : Vector3.zero;
            Vector3 velocity = transform.TransformDirection(local) + worldVelocity + inherited;
            if (useWorldSpace) position = transform.TransformPoint(position);
            else velocity = transform.InverseTransformDirection(velocity);
            var parameters = new ParticleSystem.EmitParams
            {
                position = position, velocity = velocity,
                startLifetime = Mathf.Max(0.001f, Random.Range(minEnergy, maxEnergy)),
                startSize = Mathf.Max(0, Random.Range(minSize, maxSize)),
                startColor = Color.white, rotation = rndRotation ? Random.Range(0, 360f) : 0,
                angularVelocity = angularVelocity + Random.Range(-rndAngularVelocity, rndAngularVelocity),
                applyShapeToPosition = false
            };
            ps.Emit(parameters, 1);
        }
    }
    public Particle[] particles
    {
        get
        {
            var ps = System;
            var values = new ParticleSystem.Particle[ps.particleCount];
            int count = ps.GetParticles(values);
            var result = new Particle[count];
            for (int i = 0; i < count; i++) result[i] = Particle.FromNative(values[i]);
            return result;
        }
        set
        {
            var values = new ParticleSystem.Particle[value == null ? 0 : value.Length];
            for (int i = 0; i < values.Length; i++) values[i] = value[i].ToNative();
            System.SetParticles(values, values.Length);
        }
    }
    public int particleCount { get { return System.particleCount; } }
    public void ClearParticles() { System.Clear(false); }
}
