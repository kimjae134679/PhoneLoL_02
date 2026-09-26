"""Restore actor sound references by original asset identity, never by clip name."""
from pathlib import Path
import collections, hashlib, json, re
from RecoverOriginalActorData import Archive, BLOCK
ROOT=Path(__file__).resolve().parents[1]
APK=Path(r"C:\Users\user\Documents\MultiGod\PhoneLOL_LocalRuntime\00_PHONELOL_TEST_HERE\PhoneLOL_v1.15.11.apk")
assert hashlib.sha256(APK.read_bytes()).hexdigest()=="6f4a76b66a730a8ae49d5c6c9309990722f58da25eb64c0fd063b49f296cbe2f"
archive=Archive(APK)
rows=json.loads((ROOT/"Recovery/OriginalActorData.json").read_text(encoding="utf-8"))["actors"]
source_cache={}; files={}; clips={}; report=[]
for row in rows:
    source=archive.load(row["sourceAsset"])
    if source.name not in source_cache:
        source_cache[source.name]={o.path_id:d for o,d in archive.actors(source)}
    data=source_cache[source.name][row["sourcePathID"]]
    refs=[]
    for ptr in data["m_audioClips"]:
        obj=archive.resolve(source,ptr)
        if obj is None:
            refs.append("  - {fileID: 0}");continue
        key=f"{obj.assets_file.name}:{obj.path_id}"
        if key not in clips:
            clip=obj.read();raw=bytes(clip.m_AudioData)
            assert clip.m_Type==13 and raw, (key,clip.m_Type)
            assert "/" not in clip.m_Name and "\\" not in clip.m_Name
            guid=hashlib.md5(("PhoneLOL.original-audio:"+key).encode()).hexdigest()
            path=ROOT/"PhoneLOL-02/Assets/AudioClip/OriginalActorAudio"/guid/(clip.m_Name+".mp3")
            path.parent.mkdir(parents=True,exist_ok=True)
            path.write_bytes(raw)
            Path(str(path)+".meta").write_text(f"fileFormatVersion: 2\nguid: {guid}\nAudioImporter:\n  externalObjects: {{}}\n  serializedVersion: 7\n  defaultSettings:\n    serializedVersion: 2\n    loadType: 0\n    sampleRateSetting: 0\n    sampleRateOverride: 44100\n    compressionFormat: 1\n    quality: 1\n    conversionMode: 0\n  platformSettingOverrides: {{}}\n  forceToMono: 0\n  normalize: 0\n  preloadAudioData: 1\n  loadInBackground: 0\n  ambisonic: 0\n  3D: 0\n",encoding="utf-8")
            clips[key]=dict(guid=guid,path=path.relative_to(ROOT).as_posix(),name=clip.m_Name,sha256=hashlib.sha256(raw).hexdigest())
        refs.append("  - {fileID: 8300000, guid: "+clips[key]["guid"]+", type: 3}")
    path=ROOT/row["asset"]
    text=files.setdefault(path,path.read_text(encoding="utf-8-sig"))
    matches=[m for m in BLOCK.finditer(text) if int(m[2])==row["component"]]
    assert len(matches)==1
    m=matches[0];block=m[0]
    replacement="  m_audioClips:\n"+"\n".join(refs)+"\n" if refs else "  m_audioClips: []\n"
    edited,n=re.subn(r"(?m)^  m_audioClips:[^\n]*\n(?:  -[^\n]*\n)*",replacement,block)
    assert n==1
    files[path]=text[:m.start()]+edited+text[m.end():]
    report.append(dict(asset=row["asset"],component=row["component"],clipCount=len(refs)))
for path,text in files.items():path.write_text(text,encoding="utf-8")
(ROOT/"Recovery/OriginalAudioBindings.json").write_text(json.dumps(dict(clips=clips,actors=report),indent=2,ensure_ascii=False)+"\n",encoding="utf-8")
print(f"Restored {len(rows)} actor audio arrays in {len(files)} assets from {len(clips)} exact original MP3 objects.")
