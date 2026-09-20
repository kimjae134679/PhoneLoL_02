using UnityEngine;

public class MeshParticleEmitter : ParticleEmitter
{
    public Mesh mesh;
    public float minNormalVelocity, maxNormalVelocity;
    public bool interpolateTriangles = true, systematic;
    private int vertexIndex;
    protected override Vector3 SpawnPosition(out Vector3 normal)
    {
        normal = Vector3.up;
        if (mesh == null || !mesh.isReadable) return Vector3.zero;
        var vertices = mesh.vertices;
        var normals = mesh.normals;
        if (vertices.Length == 0) return Vector3.zero;
        var triangles = mesh.triangles;
        if (interpolateTriangles && triangles.Length >= 3)
        {
            int t = Random.Range(0, triangles.Length / 3) * 3;
            int a = triangles[t], b = triangles[t + 1], c = triangles[t + 2];
            float u = Random.value, v = Random.value;
            if (u + v > 1) { u = 1 - u; v = 1 - v; }
            if (normals.Length == vertices.Length)
                normal = (normals[a] * (1 - u - v) + normals[b] * u + normals[c] * v).normalized;
            return vertices[a] * (1 - u - v) + vertices[b] * u + vertices[c] * v;
        }
        int index = systematic ? vertexIndex++ % vertices.Length : Random.Range(0, vertices.Length);
        if (normals.Length == vertices.Length) normal = normals[index];
        return vertices[index];
    }
    protected override float NormalSpeed() { return Random.Range(minNormalVelocity, maxNormalVelocity); }
}
