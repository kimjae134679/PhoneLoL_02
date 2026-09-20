# PhoneLOL 1.16.4 recovery

This branch restores the original six scenes and their coherent assets from the stable 1.15.11 APK into the user's new Unity 6 project. It is a migration candidate, not a playable release certification.

## Reference and provenance

- Stable APK: PhoneLOL_v1.15.11.apk, versionCode 186, engine 4.7.1f1.
- SHA-256: 6f4a76b66a730a8ae49d5c6c9309990722f58da25eb64c0fd063b49f296cbe2f
- Exporter: official AssetRipper 2.0.0.
- Raw export is retained separately at D:\A_KJ\AI\PhoneLOL-Recovery-v11511\ExportedProject.
- The original stable checkout and APK are unchanged.
- Later failed recovery branches are not the gameplay baseline.

## Implemented

- Imported matching source/assets/GUIDs for Login, Lobby, MultiGameLoading, MultiGame, MtmGameLoading, MtmGame.
- Unity 6000.3.14f1 with the user's Pipeline 0.7.0-exp.1 package preserved.
- Version 1.16.4 / 190, com.jcl.lmulti, ARM64 only, IL2CPP, no Unity splash.
- Original input axes, legacy input backend, Gamma color space, layers, sorting IDs, fixed timestep.
- Corrected removed component APIs, namespace changes, Social callback interfaces, duplicate/invalid attributes, decompiler setter and iterator errors.
- Preserved invalid obfuscated negative-size allocations as runtime failures; did not invent replacement sizes or return success from broken paths.
- Recovered the missing StartupManager initializer from the actual stable DLL's field RVA bytes with Mono.Cecil; no zero-return placeholder.
- Converted 354 ellipsoid emitters, 2 mesh emitters, 356 animators, and 356 particle renderers to functional compatibility components, preserving file IDs, materials, colors, emission/lifetime parameters.
- Particle adapters emit and render with ParticleSystem. Forces, growth, color animation, clipping, exact timing and mesh distribution still require visual comparison; conversion is not proof of parity.
- Reflected recovered game code is retained through link.xml for AOT builds.

## Verification performed

Unity Editor completed C# script compilation with compilationFailed=false on 2026-09-20.
No device gameplay tests, login success, multiplayer success, or visual parity are claimed. User will validate actual gameplay.

## Remaining release blockers

1. The old embedded libmght.so host is ARMv7-only. Its full native source is absent. The recovered client still addresses loopback login/game ports 20000/20001, additional service port 20100, and battle host ports 20002/20003. A real ARM64 or managed implementation is required; selecting ARM64 does not solve this.
2. AssetRipper initially exported 54 dummy shaders. 55 original shader program records are now archived with hashes. 17 project shaders still contain dummy implementations; original visual parity remains incomplete.
3. Old Android SDK Java/native integrations (Igaworks, Google Play Games, etc.) are not present as a complete modern Android plugin set. Startup code must guard optional services and replace required integrations.
4. Compilation does not establish compatibility of old serialized scenes, native NavMesh data, shaders, or IL2CPP reflection. An ARM64 development APK has been built successfully. Device checks remain necessary.
5. Server invitation fixes are recorded in the earlier PhoneLOL work branch. They have not been deployed to the live runtime. Do not modify the preserved live runtime/database casually.

## Working locations

- This repo: D:\A_KJ\AI\PhoneLoL_02
- Unity project: PhoneLOL-02
- Branch: work/v1164-unity6-recovery
- Earlier server/native research: D:\A_KJ\AI\PhoneLOL, branch work/v1164-original-arm64
- Do not confuse this source restoration with the failed fallback battle scenes in the older project.

## Build

Android modules are installed for 6000.3.14f1 using Unity CLI install-modules and official dependencies.
In Unity: PhoneLOL > Build 1.16.4 ARM64 candidate.
Output: PhoneLOL-02/Builds/PhoneLOL-v1.16.4-arm64-candidate.apk (ignored by git).
The build command fails explicitly on build errors and never labels the candidate a stable release.

Unity CLI module reference: https://docs.unity.com/en-us/unity-cli/unity-cli-reference

## 2026-09-20 continuation

- Android player compile errors fixed: removed BB10 enum reference and replaced the Editor-only AddComponent updater calls with a runtime type resolver. Invalid obfuscated type names still report an error; no fabricated component is substituted.
- Scoped three GoogleMobileAds iOS sources to UNITY_IOS, fixing Android IL2CPP linker failures for GADU symbols.
- Ported 8 character/skill shaders and 6 particle shaders from archived original GLES equations. These cover base/effect passes; full shadow/additional-light and visual parity are not certified.
- Added availability checks around optional Igaworks startup/pause calls so an absent Java SDK cannot abort those startup paths. This does not supply Google authentication or the missing native game host.
- Final candidate rebuild including the analytics availability guard succeeded: 0 errors, 725 warnings. No device gameplay validation was performed.
- Gameplay/phone testing intentionally remains with the user. No live server/database deployment was made.

## Platform scope (user clarification, 2026-09-20)

Android ARM64 is the current delivery target; iOS is also a required future target. Preserve iOS source and integration boundaries. UNITY_IOS guards isolate iOS native symbols from Android; they do not remove iOS support.

Implement the replacement game/network host in shared managed code where possible. Keep native SDK integration, permissions, storage and platform startup behind separate Android/iOS adapters. Do not make an Android-only host architecture the permanent solution. Existing iOS plugin source is retained, but a working iOS build has not been established.

## Candidate artifact (2026-09-20)

- File: `PhoneLOL-02/Builds/PhoneLOL-v1.16.4-arm64-candidate.apk`
- Size: 120569295 bytes
- SHA-256: `6416365cf1d2c214ca8b6c8dfa56af220371cc1353f6e7b51bf61d03f8bc592b`
- APK native libraries: 6; all arm64-v8a and ELF64: True.
- Development candidate only. The missing legacy host remains a gameplay blocker.
