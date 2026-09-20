from pathlib import Path
import re
r=Path(r'D:\A_KJ\AI\PhoneLoL_02\PhoneLOL-02\Assets\Scripts')
changed=[]
for p in r.rglob('*.cs'):
 s=p.read_text(encoding='utf-8-sig');t=s
 t=re.sub(r'\.particleEmitter\b','.GetComponent<ParticleEmitter>()',t)
 if 'using GooglePlayGames.OurUtils;' in t and re.search(r'\bLogger\.',t) and 'using Logger =' not in t:
  t='using Logger = GooglePlayGames.OurUtils.Logger;\n'+t
 t=t.replace('RuntimePlatform.OSXWebPlayer','((RuntimePlatform)3)').replace('RuntimePlatform.WindowsWebPlayer','((RuntimePlatform)5)')
 t=t.replace('System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EVector3_003E_002EGetEnumerator()', '((System.Collections.Generic.IEnumerable<UnityEngine.Vector3>)this).GetEnumerator()')
 t=t.replace('System_002ECollections_002EGeneric_002EIEnumerable_003CSimpleJSON_002EJSONNode_003E_002EGetEnumerator()', '((System.Collections.Generic.IEnumerable<FEAILBGBEPH>)this).GetEnumerator()')
 # Preserve invalid IL array allocations as runtime failures, not invented sizes.
 t=re.sub(r'new ([\w<>.]+)\[(-\d+)\]',r'new \1[System.Convert.ToInt32(\2)]',t)
 # Decompiled parameterized setters retain a C# property keyword instead of the real argument.
 t=re.sub(r'(\bvoid set_\w+\([^)]*\bICENKPDOHBK\)\s*\{)([^{}]*)(\})',
   lambda m:m[1]+re.sub(r'\bvalue\b','ICENKPDOHBK',m[2])+m[3],t)
 if p.name=='DFGJOKLEJPI.cs':t=t.replace('JNFLFDGHELC__BackingField','JNFLFDGHELC')
 if p.name=='NLDABIMKKMP.cs':
  t=t.replace('textEditor.content.text','textEditor.text').replace('textEditor.content = new GUIContent(ICENKPDOHBK);','textEditor.text = ICENKPDOHBK;')
 if p.name=='Actor.cs':t=t.replace('\t\tnew Action<KCIGFAHFHCH>(dMNCNEAHLPN.KGAIOHCFKOH);','\t\t_ = new Action<KCIGFAHFHCH>(dMNCNEAHLPN.KGAIOHCFKOH);')
 if t!=s:p.write_text(t,encoding='utf-8');changed.append(p.name)
print('Updated',len(changed),'source files')
