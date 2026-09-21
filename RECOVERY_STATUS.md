# 1.16.5 login / diagnostics update ? 2026-09-21

User device result for 1.16.4: login screen renders, login connection fails, landscape direction is reversed. Screenshot shows missing legacy ZAndroid, immersive-mode, Tapjoy and NAS Java classes. Current work addresses these reported symptoms and live diagnostics; no gameplay validation is claimed.

- Replaced the absent ARMv7 login/game-account/community host with a shared C# loopback adapter (20000/20001/20100). It uses existing central server protocol 4 and RPC 64/65, preserving the original encrypted client frame format and profile -> runes -> ready order (4/7/12).
- Stable account identity hashing is recovered from libmght.so login_client_thread 0x30bc?0x3100: FNV-1a over the original login payload, then the original mask/fold/minimum rule. Existing PlayerPrefs identity/model/name/OS keys are retained.
- Login succeeds only after a real central account response. Game/community tokens must match that response. Unsupported battle/menu messages fail explicitly; the battle host/room translation is STILL NOT IMPLEMENTED.
- Startup guards missing optional Android SDKs; immersive fullscreen uses Unity. IL2CPP no longer attempts to read an absent managed Assembly-CSharp.dll for the old plugin. No advertising success/reward is fabricated.
- Both landscape orientations enabled; portrait disabled. Displayed version now follows Application.version.
- Login screen has server/log settings. Host/port persist in PhoneLOL-server-settings.json under persistentDataPath. Default: uko9ef6n.free.pwrp.cc:10045. Each new connection resolves the hostname; changing routers does not require recompiling the app if the existing tunnel/domain is retained. A changed endpoint can be saved in-app.
- Live diagnostics capture pre-login startup, Unity logs with stack traces, scene/focus/pause, connection/protocol errors, packet IDs/lengths (not account payloads/tokens), and 15-second heartbeats. Batches upload approximately every 2 seconds; errors/checkpoints can flush immediately. Local queue survives restart; HTTP 204 acknowledgement is required before deletion. Retry backoff is bounded at 30 seconds. Queue limit: 512 batches; overflow is explicitly recorded. Delivery is at least once, with event/chunk/session IDs for correlation.
- Logs are received by the existing server on POST /phonelol-diag/v1, as PHONE_CLIENT_TRACE records. This replaces obsolete Google-script uploads and nonexistent localhost:8080 diagnostics from the recovered code. No secrets need to be embedded in the new uploader.

## Focused checks

- Unity C# compile completed without errors.
- A disposable central server/database accepted original encrypted request frames and returned account authentication, profile, rune inventory and ready in the correct order. The original recovered packet reader decoded the replacement host's response. No production account was created by this check.
- New C# diagnostics uploader received HTTP 204 from the existing local server. A synthetic probe also appears in the server's actual log.
- Phone gameplay, community UI and visual parity are not certified. User performs device validation.

## External connectivity restored (2026-09-21)

The user explicitly approved restoring the existing public tunnel and background operation, and requested future replacement support. The existing V3.3 server remains on TCP 29000; its code and database were not replaced.

- Mapping: uko9ef6n.free.pwrp.cc:10045 -> 127.0.0.1:29000. Only one tunnel was configured/enabled before connecting. Tunnel selector: 124fd86a.
- Started the existing tunnel using pwrp connect --all --save --detach --local-host 127.0.0.1. The command reported "already starting", but the subsequent daemon status confirmed exactly one live session with local reachability OK. Do not treat the CLI exit alone as proof of failure or success.
- A synthetic POST through the public hostname received HTTP/1.1 204 No Content. Marker V1165_PUBLIC_TUNNEL_PROBE_20260921T021939Z appeared in the live server log as PHONE_CLIENT_TRACE at 2026-09-21 11:19:39.918 (PC local time). This verifies the public diagnostic path, not phone gameplay.
- The daemon continues after the terminal closes. Saved boot-all is on; OS autostart is disabled. Do not add unrelated enabled tunnels without reviewing this saved selection.
- Automatic review previously blocked restoration until explicit approval; that approval was then supplied. A later attempt to install OS boot/login autostart was separately rejected because background approval did not explicitly cover system autostart. That rejected command was not executed; no bypass was attempted. Boot/login registration still needs explicit user approval.

### Reconnect and replace later

Manual reconnect in PowerShell (only this existing tunnel; no OS autostart registration):

```powershell
& 'C:\Users\user\Documents\MultiGod\PhoneLOL_LocalRuntime\tools\portwarp\pwrp.exe' connect 124fd86a --detach --local-host 127.0.0.1
```

In the 1.16.5 app, open the server/log settings on the login screen, change the host and port, then save. Both game connections and diagnostic uploads use the current settings. For the restored tunnel use host uko9ef6n.free.pwrp.cc and port 10045. No APK rebuild is needed for an endpoint change.

After a router change, retain the public domain/port and run the tunnel on the server PC; 127.0.0.1 remains the local destination on that PC. After moving to another PC/provider, first migrate the actual server and its account database safely, configure the new tunnel/domain, then update the app endpoint if necessary. The replacement server must implement the existing central protocol and diagnostic endpoint; editing the address alone does not migrate data or translate protocols. Keep credentials and account data out of git.

Same-LAN fallback: use the server PC's current LAN IPv4 address with port 29000. The previously observed Wi-Fi address 192.168.219.106 can change. Never enter 127.0.0.1 as the remote PC address on the phone. No router/firewall settings were changed.

## Artifact

- APK: PhoneLOL-02/Builds/PhoneLOL-v1.16.5-arm64-candidate.apk
- SHA-256: 803962fce46f19649ab2b0465cdc4a36e18b9fa8cdbb952789f0d6d9e86d74af
- Size: 143002705 bytes

1.16.5 / Android versionCode 191, ARM64 IL2CPP development candidate, Unity splash disabled. Final APK build succeeded, including the lobby SDK guard: 0 errors. All six packaged native libraries are arm64-v8a ELF64. Internet permission is present. Device tests remain with the user.

Server logs: C:\Users\user\Documents\MultiGod\PhoneLOL_LocalRuntime\recovery\04_runtime\logs. Find PHONE_CLIENT_TRACE and the diagnostic ID displayed by the app. Client retry queue: Application.persistentDataPath/PhoneLOL-live-logs; upload-status.txt records the last delivery/error status.

---

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
