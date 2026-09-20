"""Apply mechanical Unity API migrations to recovered source files."""
from pathlib import Path
import re

root = Path(__file__).resolve().parents[1] / "PhoneLOL-02" / "Assets"
changed = []
for path in (root / "Plugins").rglob("*.cs"):
    text = path.read_text(encoding="utf-8-sig")
    updated = re.sub(r"\.camera\b", ".GetComponent<Camera>()", text)
    updated = updated.replace("GetComponent<Camera>().hdr", "GetComponent<Camera>().allowHDR")
    if updated != text:
        path.write_text(updated, encoding="utf-8")
        changed.append(str(path.relative_to(root)))
print("Migrated camera API files:", len(changed))
