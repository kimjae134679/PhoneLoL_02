using UnityEngine;

[DefaultExecutionOrder(-900)]
public class ParticleRenderer : MonoBehaviour
{
    public float lengthScale = 2, velocityScale, cameraVelocityScale, maxParticleSize = 0.25f;
    public Material[] materials = new Material[0];
    public int stretchParticles, sortingLayerID, sortingOrder, uvTilesX = 1, uvTilesY = 1;
    public float uvCycles = 1;
    private ParticleSystemRenderer target;
    public Material material
    {
        get { return Target == null ? null : Target.material; }
        set { materials = new[] { value }; if (Target != null) Target.material = value; }
    }
    private ParticleSystemRenderer Target
    {
        get
        {
            if (target != null) return target;
            var emitter = GetComponent<ParticleEmitter>();
            if (emitter == null) return null;
            var initialized = emitter.System;
            target = GetComponent<ParticleSystemRenderer>();
            return target;
        }
    }
    private void Start()
    {
        if (Target == null) return;
        Target.sharedMaterials = materials;
        Target.sortingLayerID = sortingLayerID; Target.sortingOrder = sortingOrder;
        Target.renderMode = stretchParticles == 1 ? ParticleSystemRenderMode.Stretch :
            stretchParticles == 3 ? ParticleSystemRenderMode.HorizontalBillboard :
            stretchParticles == 4 ? ParticleSystemRenderMode.VerticalBillboard : ParticleSystemRenderMode.Billboard;
        Target.sortMode = stretchParticles == 2 ? ParticleSystemSortMode.OldestInFront : ParticleSystemSortMode.Distance;
        var texture = GetComponent<ParticleEmitter>().System.textureSheetAnimation;
        texture.enabled = uvTilesX > 1 || uvTilesY > 1;
        if (texture.enabled)
        {
            texture.numTilesX = Mathf.Max(1, uvTilesX); texture.numTilesY = Mathf.Max(1, uvTilesY);
            texture.cycleCount = Mathf.Max(1, Mathf.RoundToInt(uvCycles));
            texture.frameOverTime = new ParticleSystem.MinMaxCurve(1, AnimationCurve.Linear(0, 0, 1, 1));
        }
        Apply();
    }
    private void LateUpdate() { Apply(); }
    private void Apply()
    {
        if (Target == null) return;
        Target.enabled = enabled; Target.lengthScale = lengthScale;
        Target.velocityScale = velocityScale; Target.cameraVelocityScale = cameraVelocityScale;
        Target.maxParticleSize = maxParticleSize;
    }
    private void OnDisable() { if (target != null) target.enabled = false; }
}
