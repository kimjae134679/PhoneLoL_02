"""Migrate removed Unity 4 components while preserving their file IDs and references.
Run on the recovered project only; the raw APK export remains untouched.
"""
from pathlib import Path
import re, hashlib, collections
ROOT = Path(__file__).resolve().parents[1] / "PhoneLOL-02" / "Assets"
TYPES = {15: "EllipsoidParticleEmitter", 87: "MeshParticleEmitter", 12: "ParticleAnimator", 26: "ParticleRenderer"}
RENAME = {
    "m_Emit": "emit", "Simulate in Worldspace?": "useWorldSpace", "m_OneShot": "oneShot",
    "m_Ellipsoid": "ellipsoid", "m_MinEmitterRange": "minEmitterRange",
    "m_MinNormalVelocity": "minNormalVelocity", "m_MaxNormalVelocity": "maxNormalVelocity",
    "m_InterpolateTriangles": "interpolateTriangles", "m_Systematic": "systematic", "m_Mesh": "mesh",
    "Does Animate Color?": "doesAnimateColor", "m_Materials": "materials",
    "m_LengthScale": "lengthScale", "m_VelocityScale": "velocityScale",
    "m_CameraVelocityScale": "cameraVelocityScale", "m_MaxParticleSize": "maxParticleSize",
    "m_StretchParticles": "stretchParticles", "m_SortingLayerID": "sortingLayerID",
    "m_SortingOrder": "sortingOrder"
}
ALLOWED = set(RENAME.values()) | set("""minSize maxSize minEnergy maxEnergy minEmission maxEmission
worldVelocity localVelocity rndVelocity emitterVelocityScale tangentVelocity angularVelocity rndAngularVelocity
rndRotation worldRotationAxis localRotationAxis sizeGrow rndForce force damping stopSimulation autodestruct""".split())
counts = collections.Counter()
def fields(block):
    result = {}
    for m in re.finditer(r"^  ([^ \n][^:\n]*):(.*(?:\n(?!  [^ \n][^:\n]*:|---).*)*)", block, re.M):
        result[m[1]] = m[2]
    return result
def convert(block):
    match = re.match(r"--- !u!(\d+) &(-?\d+)\n", block)
    if not match or int(match[1]) not in TYPES:
        return block
    type_id = int(match[1]); name = TYPES[type_id]
    f = fields(block)
    guid = hashlib.md5(("PhoneLOL.v1164.compat." + name + ".cs").encode()).hexdigest()
    output = [f"--- !u!114 &{match[2]}", "MonoBehaviour:",
        "  m_ObjectHideFlags: 0", "  m_CorrespondingSourceObject: {fileID: 0}",
        "  m_PrefabInstance: {fileID: 0}", "  m_PrefabAsset: {fileID: 0}",
        "  m_GameObject:" + f["m_GameObject"].splitlines()[0],
        "  m_Enabled:" + f.get("m_Enabled", " 1").splitlines()[0],
        "  m_EditorHideFlags: 0",
        f"  m_Script: {{fileID: 11500000, guid: {guid}, type: 3}}",
        "  m_Name: ", "  m_EditorClassIdentifier: "]
    for key, value in f.items():
        new_key = RENAME.get(key, key)
        if new_key in ALLOWED:
            output.append("  " + new_key + ":" + value.rstrip())
    if type_id == 12:
        output.append("  colorAnimation:")
        for i in range(5):
            value = f.get(f"colorAnimation[{i}]", "")
            m = re.search(r"rgba: (\d+)", value)
            if not m:
                raise ValueError("Missing legacy particle color")
            n = int(m[1])
            c = [(n >> (8 * j) & 255) / 255 for j in range(4)]
            output.append("  - {r: %s, g: %s, b: %s, a: %s}" % tuple(c))
    if type_id == 26:
        uv = f.get("UV Animation", "")
        for old, new, default in [("x Tile", "uvTilesX", 1), ("y Tile", "uvTilesY", 1), ("cycles", "uvCycles", 1)]:
            m = re.search(re.escape(old) + r": ([^\n]+)", uv)
            output.append(f"  {new}: {m[1] if m else default}")
    counts[name] += 1
    return "\n".join(output) + "\n"
for path in ROOT.rglob("*"):
    if path.suffix not in (".prefab", ".unity", ".asset"):
        continue
    text = path.read_text(encoding="utf-8-sig", errors="strict")
    if not re.search(r"^--- !u!(15|87|12|26) ", text, re.M):
        continue
    result = "".join(convert(b) for b in re.split(r"(?=^--- !u!)", text, flags=re.M))
    # Unity 4 component lists encode class IDs as YAML mapping keys.
    result = re.sub(r"^(  - )(?:15|87|12|26)(: \{fileID:)", r"\g<1>114\2", result, flags=re.M)
    path.write_text(result, encoding="utf-8")
for path in (ROOT / "Scripts").rglob("*.cs"):
    text = path.read_text(encoding="utf-8-sig")
    result = re.sub(r"\.guiText\b", ".GetComponent<GUIText>()", text)
    if path.name == "NcParticleSystem.cs":
        result = result.replace("return base.GetComponent<ParticleSystem>() != null;",
            "return GetComponent<ParticleEmitter>() == null && base.GetComponent<ParticleSystem>() != null;")
    if result != text:
        path.write_text(result, encoding="utf-8")
print("Migrated legacy components:", dict(counts))
