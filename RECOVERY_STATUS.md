# 1.16.9 / 195 — 전투·조명·애니메이션 복구 및 모드대전 — 2026-09-24

작성: [B계정] Nova / Codex Work. 사용자의 이어서 작업 요청으로 진행했다. 아래가 최신 상태이며, 아래쪽 버전 기록은 과거 이력이다. **실기기 전투·화면 확인은 사용자가 담당한다. 코드·계약 검사와 빌드가 실제 플레이 성공을 보증하지 않는다.**

## GitHub 반영 상태

구현/복구 소스는 로컬 커밋 `a64e535670e2bc2ca0517737c628a1b563172fae`에 보존됐다. GitHub push는 자동 승인 심사에서 두 번 거절되어 **원격 저장소에는 아직 반영되지 않았다**. 기존에 승인한 동일 저장소임을 확인했고 현재 계정 ADMIN 권한과 공개 상태도 확인했지만, 심사는 이번 소스·복구 데이터·운영 기록을 공개 저장소 kimjae134679/PhoneLoL_02에 게시하는 별도 명시적 승인이 필요하다고 판단했다. 우회 업로드는 하지 않았다. 사용자 승인 뒤 이 로컬 브랜치를 push하고 운영 허브의 보류 상태를 갱신한다.

## 전달 상태

- APK: `D:\A_KJ\AI\PhoneLoL_02\PhoneLOL-02\Builds\PhoneLOL-v1.16.9-arm64-candidate.apk`.
- ARM64 / IL2CPP / com.jcl.lmulti / 1.16.9 / versionCode 195. Unity splash disabled; iOS source boundaries retained.
- Build succeeded: 0 errors / 760 warnings, 401847 ms. APK 136944006 bytes; SHA-256 `8d8afbe292385af089a2fac69fbcb4241e2189e42e7ab2f9d9fbf17e3513788c`. All 6 packaged native libraries are arm64-v8a / ELF64. Build job e0101bfe351a48449205898ec2dfb423.
- 멀티플레이 테스트에 참여하는 모든 기기는 1.16.9로 맞춘다. 모드대전 아이템 전송·결과가 8칸이므로 1.16.8과 혼합한 모드대전은 지원하지 않는다.

## 전투와 방 이동

- Previous WIP used `(native_session_key + 1) * 1000 + 1` for champion view IDs. Disposable-server verification found signed Int32 overflow because native session keys can be large. The WIP was never deployed in that state.
- ManagedBattle now allocates unique bounded Eve session keys (1..2147481), independently of native transport sessions. The same key is used in player/roster/start/group registration and directed relay. Champion view IDs match Eve ownership decoding and cannot collide with scene IDs below 1000. Native sessions/accounts are unchanged.
- Packet 61001 moves an unready player into a vacant opposite-team slot before countdown. It preserves actual membership and rune/role selection. Tests cover both directions, solo readiness and two-peer starts.
- Original pre-baked walkable polygons were converted into Unity 6 NavMeshData for both maps; scene references now use m_NavMeshData. Main-lane connectivity and all sixteen mode-wave spawn points are checked. No visually guessed walkable geometry was substituted.
- The existing 1v1 ping/null guard and managed world initialization remain. These are targeted fixes for observed blockers; full combat, reconnect and match completion on phones remain unverified.

## 원본 조명과 애니메이션

- Unity 4 scene lightmap records were not loaded by Unity 6. PhoneLOLLegacyLightmaps applies the original two baked textures per map and restores 296 MultiGame / 638 MtmGame renderer/terrain bindings at early Awake.
- Recovered static-batch meshes already contain atlas-space UV2, so their lightmap transform is identity. Other original scale/offset values remain. The Mobile/Unlit lightmap shader uses the archived RGBM equation (`rgb * alpha * 8`) and per-renderer bindings in Gamma space. No full dynamic-light replacement or new light baking was introduced.
- Rebuilt 44 original controllers from Recovery/OriginalControllers.json: 316 states / 178 transitions. The root controller must have m_ObjectHideFlags=0; prior WIP incorrectly hid the main asset. State sub-assets remain hidden. Unity read-back now finds all 316 states, with zero missing motions. There are 45 controller files total, including one existing empty controller.
- Recovery scripts retain original GUIDs and the exact clip/state/transition data. Visual parity, animation poses and phone performance are not certified by import checks.

## 모드대전 — 기존 일반대전(mode 10)에만 적용

- Lobby buttons renamed to 모드대전. Ranked and friendly rules remain unchanged; mode comes from the authenticated server room snapshot, not a local toggle.
- Item capacity 5 → 8. Constructor, peer serialization/deserialization, purchase duplicate restriction, HUD, shop, active item presses, scoreboard writer/reader and server result parser all use the mode capacity. Unique equipment can occupy separate slots; normal consumable stacking and shared item-ID cooldown behavior are retained.
- Existing NGUI widgets are cloned and fitted within their original horizontal space. Shop/HUD/result icon scale is 0.625; all eight use buttons get their own press callback. Phone touch usability needs user feedback.
- Passive automatic gold is doubled after the existing rune modifier: a normal tick of 4 becomes 8. Kill/sale/reward gold is unchanged.
- Exactly 8 minions per team per mode wave (16 total), with unique host-allocated scene view IDs. Existing origins are retained. Cannon replaces a melee slot after wave 5; a super-minion buff replaces the first slot. Ranked/friendly wave progression remains original.
- Jungle respawn delay is halved, including buffs/dragon/baron: 300→150, 360→180, 180→90 seconds. Initial spawn timing is unchanged.
- Result inventory uses 8 UInt16 IDs for mode 10 and 5 otherwise. No fake rewards/history or ranking gains were added. Existing replacement Elo ranking policy remains documented below.

## 검증과 운영 반영

- `Automation/VerifyV1169.cs` / `Recovery/V1169Verification.txt`: mode isolation (0/10/20/101/102), inventory round-trip with sentinel, shop/HUD/use/result arrays, lightmap bindings, navigation spawn samples, all recovered animation motions.
- `Automation/Server/check_managed_v1167.py`: disposable DB only; free renames, two real peers, bounded champion IDs, shared loading, broadcast/directed relay, both team-move directions, solo mode start/result with eight items, persisted rankings and duplicate settlement prevention.
- `Recovery/V1169Deployment.txt`: backup location, diagnostic marker, observed process IDs. Only managed_battle_v1167.py and managed_results_v1168.py replaced in the existing runtime. Original launcher/port/tunnel/account DB retained.
- Backup: `C:\Users\user\Documents\MultiGod\PhoneLOL_LocalRuntime\recovery\04_runtime\backups\before-v1169-20260924-212259`. SQLite backup completed before deployment; source matched recorded 1.16.8 before replacement.
- New server listening on 29000; local and public diagnostic POST returned HTTP 204. Public endpoint remains uko9ef6n.free.pwrp.cc:10045. Marker: V1169_DEPLOY_20260924T122454Z. This proves diagnostic reachability, not phone gameplay.
- Rollback requires a matching old client/server pair. Restore backed-up source files and restart the existing launcher; do not restore the account DB just to roll back code.
- No new programs installed. Existing user-selected D:\A_KJ\AI\PhoneLoL_02 project, Unity installation, Python311 and C:\TempPy13 server were reused. The AI default install-root policy did not require moving existing installations.
- User's separate UnityConnectSettings.asset change is excluded from the commit and left untouched.

## 다음 확인

사용자는 1.16.9를 설치해 챔피언 조작·공격·애니메이션, 두 맵 조명/경계, 방 팀 이동, 모드대전 8칸 구매·사용·판매와 양 기기 동기화를 확인한다. 진단 ID/시각에 맞춰 PHONE_CLIENT_TRACE에서 남은 오류를 좁힌다. 출석/무료보상 알림 억제, 무료 닉네임, 친구 입력 보호와 원본 아이콘을 유지했다. 원본과 시각적으로 완전히 동일하거나 실전 플레이가 전부 해결됐다고 아직 선언하지 않는다.

---
# 1.16.8 / 194 — 복구본 빌드·서버 반영 — 2026-09-24

사용자의 작업 재개 요청에 따라 이전 WIP를 이어서 수정했다. Unity Package Manager 오류도 해결했다. **아래가 현재 상태이며, 이전 인수인계와 버전별 구역은 과거 기록이다. 실기기 화면·플레이 검증은 사용자가 담당하며 정상 전투 전체를 인증한 것은 아니다.**

## 전달 APK

- 경로: `D:\A_KJ\AI\PhoneLoL_02\PhoneLOL-02\Builds\PhoneLOL-v1.16.8-arm64-candidate.apk`
- 버전: 1.16.8 / Android versionCode 194, com.jcl.lmulti.
- 117508955 bytes; SHA-256 `81881b91b5080f7e34949b323168a8676fb77f24afffc9cdc2690ef664fd17e5`.
- Unity Android build: Succeeded, 0 errors / 760 warnings. Build job `a6e3d778d62b4989b985868265149d5c`, 374982 ms.
- Packaged native libraries: 6, all arm64-v8a / ELF64. Unity splash remains disabled. iOS source boundaries remain; no iOS build was performed.
- 기존 1.16.7 APK와 1.15.11 기준 자료는 보존했다. 새 파일은 candidate이며 실제 화면·입력·전투는 사용자 확인이 필요하다.

## 이번에 변경한 내용

### Original Actor data and map recovery

- `Automation/RecoverOriginalActorData.py` restores 193 Actor components across 165 resource prefabs and 2 scenes (167 files). Actual stable APK values replace missing serialization; no NPC stats are guessed.
- Restored hero ID, costume, self-create flag, team/type, lifetime/movement flags, damage HUD reference and audio clip references.
- Provenance and values: `Recovery/OriginalActorData.json`. The extractor checks the exact stable APK SHA and consumes the entire original Actor byte record.
- Unity 4 MonoBehaviour header alignment comes from UnityPy's built-in type tree. Generated Actor fields omit the patched DLL's absent m_v093RuneGoldTick tail. ObscuredByte has no serialized children in these assets.
- mainData contains the first built scene; later scenes are level(index-1). Duplicate object names are matched through hierarchy plus local position, not name alone. All HUD/audio mappings resolved without fallback.
- Representative Unity imports: Turret0 hero=30000/selfCreate=false; Dragon hero=20002/selfCreate=true.
- Retained the checkpoint's 932 recovered static-batch meshes: MultiGame 296 and MtmGame 636. Unity read-back confirmed all references and material/submesh counts.
- Fixed the two map shaders' missing closing braces from the unbuilt checkpoint. Both shaders now import without shader errors and retain the archived original GLES equations.
- `Automation/VerifyRecoveryAssets.cs` records this narrow Editor check. It is not a phone screenshot comparison. NavMesh, particles, animation and all original visual details still require real play feedback.

### Champion bootstrap and lobby exceptions

- Confirmed the recovered NEFBHKKAMJF.JCOLMPJMMEB reads three UInt32 values after hero ID/skin metadata. The existing central legacy p5 builder sends three bytes.
- PhoneLOLLocalHost expands those three existing values to UInt32 at the managed boundary, preserving the native server contract and actual inventory. Count, record boundaries, duplicate IDs and trailing bytes are checked.
- Bootstrap now sends profile 4 → runes 7 → owned heroes 5 → ready 12, so selection does not begin without its inventory.
- UIBattleReadyHeroInfo.Update handles the interval with no room and a missing native server-ping peer. It does not fabricate a ping measurement.
- Legacy diagnostic game packet 63 is fire-and-forget; the adapter no longer generates an unregistered 255 reply. Existing realtime error/stack capture remains.

### Solo/multiplayer, results and rankings

- Managed rooms can start with one authenticated, ready player and a valid owned hero. Real connected membership is used; no artificial opponent is inserted.
- The older/native minimum-two rule and launcher setting are unchanged. The solo rule is restricted to managed rooms.
- Loading packet 19 / shared start 20 remain. World-initialized marker 21 is accepted without a bogus response.
- Only the active room host can submit battle result 22, after participant world initialization. The server checks roster, slot, device, hero, frame boundaries and duplicate/conflicting result identity before persisting.
- A validated result is sent to every room participant in the recovered scoreboard format. The server does not run a full authoritative combat simulation; host-reported combat statistics are not independently proven.
- Added `Automation/Server/managed_results_v1168.py` and SQLite tables managed_match_results, managed_match_members, managed_rank_stats. Existing account tables and balances are retained.
- Result lookup game packet 27 returns the recovered 85-byte account/result contract to authenticated participants only. UI now requests the server result instead of immediately marking an unqueried result complete. After 12 seconds without a response it displays an error and permits exit, without claiming settlement success.
- Game packet 33 returns a real persisted top-100 list for 3v3/1v1, with exact ushort count / nickname / byte position / int32 points layout. Profile scores, positions and win/loss counts use the same database.
- **원본 서버의 점수 산식은 확보하지 못했다.** 복구 서버는 별도 Elo 정책을 사용한다: first competitive rating 1000, K=32, team-average expected score, floor 0. This is an explicit replacement policy, not a recovered original formula.
- Only completed managed ranked modes 0 and 20 with actual players on both teams and the ranked matchmaking group affect rating. Solo, normal and friendly results are retained but do not farm ranking points.
- No historical matches/rankings are invented. Ties in the list sort by wins then account ID. The existing client maps ranking-position thresholds to badge names.
- Original currency/experience reward rules remain unrecovered, so result rewards stay zero and current account balances/level/experience are returned unchanged. This preserves the earlier unpaid-reward behavior rather than fabricating rewards.

### Icon and Unity startup

- OriginalAppIcon.png remains unchanged. Android post-generation removes adaptive app_icon XML overrides only when matching legacy PNG fallbacks exist, so the original full image is not enlarged as both adaptive layers.
- Generated launcher check: 0 adaptive app_icon XML overrides, 12 legacy app_icon PNGs. Actual launcher display still belongs to device testing.
- The Package Manager executable itself ran successfully. The remote launch environment was missing standard Windows variables including ProgramData, ALLUSERSPROFILE, TMP, ComSpec and ProgramFiles(x86).
- Filling missing values in the process environment allowed the diagnostic tool and Unity/Pipeline to start. Machine/user environment settings and antivirus configuration were not changed.
- Added `Automation/OpenUnity.ps1` to repeat the corrected launch and avoid opening a second copy of the project. No editor/package reinstall was necessary.
- Unity Editor 6000.3.14f1 / Pipeline 0.7.0-exp.1 / port 7800. Final C# compilation state was not failed and reported 0 current console errors before build.
- The existing Python311 / TypeTreeGeneratorAPI 0.0.10 installation was reused. Project/tool paths remain in the user-selected existing locations; no new system-wide AI installation or Jev dependency was introduced.

## Live deployment and evidence

At resume, live server_central_authority_v33.py, account_services_v1158.py and the runtime manifest had reverted to the pre-1.16.7 behavior: managed bridge hooks absent, paid/two-week nickname restriction restored, managed dependencies missing from the manifest. The cause of that reversion was **not established**. These files were compared with the recorded release before replacement; no unrelated newer changes appeared in that comparison.

- Consistent SQLite/source/launcher backup:
  `C:\Users\user\Documents\MultiGod\PhoneLOL_LocalRuntime\recovery\04_runtime\backups\before-v1168-20260924-170631`.
- Replaced only the existing runtime's managed entry/account/battle/result/rune files and added their dependencies to central_v33_runtime_files.json. The complete dependency manifest is mirrored under Automation/Server.
- Existing launcher, listen port 29000, DB path and public tunnel were retained. New server PID at deployment: 27800; launcher PID: 32508. PIDs are observations, not permanent identifiers.
- Free unlimited nickname changes and managed invitation translation were restored along with the new fixes.
- Local and public POST /phonelol-diag/v1 both returned HTTP 204. Synthetic marker: V1168_DEPLOY_20260924T080926Z.
- Public endpoint remains uko9ef6n.free.pwrp.cc:10045. Existing tunnel replacement/autostart guidance below still applies. No production test account was created.
- Code-only rollback uses the source backup, but note that it contains the unexpectedly reverted pre-1.16.7 runtime. Do not blindly restore its DB: that would discard subsequent user activity. New result/rank tables may remain harmlessly if older code is restored.

One disposable-server check passed:
1. Free repeated nickname changes without balance loss.
2. Two real authenticated peers in one room, champion selection, shared start/load and relay.
3. Rejection of a non-host result; persisted outcome; exact ranking/result frames; duplicate submission cannot award twice.
4. One authenticated player can start, load and complete without a fake opponent or ranking gain.

These checks plus the Editor import check and final build are the verification performed. They do not certify combat responsiveness, original visual parity, all UI actions, reconnect/disconnect recovery, old-native cross-play, iOS or anti-cheat robustness. The user performs phone testing.

## 다음 담당자 / 다음 사용자 테스트

현재 candidate에서 먼저 아이콘 크기, 챔피언 목록, 1인 시작, 두 명 동시 진행, 두 맵 배경/Actor HUD, 종료·랭킹을 확인한다. 추가 문제가 나오면 진단 ID와 PHONE_CLIENT_TRACE를 같은 화면/시각에 맞춰 확인한다. 임의의 전체 재복구나 가짜 성공 처리 대신 실패 지점을 좁힌다.

기존 출석/무료보상 자동 알림 억제, 친구 입력 보호, 무료 닉네임, 교체 가능한 서버 설정을 유지한다. 사용자 별도 변경 `PhoneLOL-02/ProjectSettings/UnityConnectSettings.asset`는 이번 커밋에서도 제외했다.

---

# 인수인계 체크포인트 — 2026-09-23 — 미완료 복구 작업 포함

작성: [B계정] Nova / Codex. 최신 사용자 요청에 따라 추가 기능 수정·배포·빌드를 멈추고, 다음 담당자가 이어받을 수 있도록 작업 상태를 보존한다. **작업 완료 선언이 아니다. 아래 구역이 현재 상태이며, 아래쪽 1.16.7~1.16.4 기록은 각 시점의 이력이다.**

## 바로 이어받기

- 실제 작업 저장소: https://github.com/kimjae134679/PhoneLoL_02
- 작업 브랜치: `work/v1164-unity6-recovery`
- 실제 PC 저장소: `D:\A_KJ\AI\PhoneLoL_02`; Unity 프로젝트는 그 안의 `PhoneLOL-02`.
- 마지막 배포 소스 기준: `d97a5a0` (1.16.7). 그 이후 이번 체크포인트는 **WIP 소스/에셋 보존**이다.
- 최신 제공 APK는 여전히 `D:\A_KJ\AI\PhoneLoL_02\PhoneLOL-02\Builds\PhoneLOL-v1.16.7-arm64-candidate.apk`.
- APK: 143707366 bytes, SHA-256 `5fc9b82f669ba5f3d2bf40d5bc7abeb0894e14d0e8eb02faf7ff9f8f1cd85140`.
- 앱 버전은 아직 1.16.7 / versionCode 193. **1.16.8 APK는 만들지 않았다.** 다음 배포 때 1.16.8 / 194로 올릴 예정이며, 아직 버전 파일은 바꾸지 않았다.
- 이번 WIP에는 서버 변경·재시작·DB 변경이 없다. WIP 전체의 컴파일, 새 APK 빌드, 원본 대비 화면 검증, 실기기 검증은 미실행이다.
- `PhoneLOL-02/ProjectSettings/UnityConnectSettings.asset`의 로컬 변경은 작업 전부터 있던 별도 변경이다. 이번 커밋에서 제외했으며 되돌리지 않았다.

## 사용자가 요구한 최종 결과와 제약

1. 매우 안정적이었던 **1.15.11을 동작/화면 기준**으로 Android 64비트 전용 기기에서 실제 실행. 이후 백업본들은 실패했으므로 기준으로 삼지 않는다. 원래 Unity 프로젝트 원본은 없고 APK/복구 자료가 있다.
2. 원본과 동일한 배경·맵·아이콘·게임 동작. Unity 로고 표시 금지. 최신 엔진 사용은 허용하지만 실제 작동이 핵심이다.
3. 1인일 때도 정상 진행. 일반/랭크/친선 모두 방 입장뿐 아니라 실제 게임 시작·진행이 되어야 한다. 여러 명도 같은 게임을 정상 진행해야 한다.
4. 랭킹을 실제 데이터와 결과에 맞게 구현. 가짜 사용자/승리/보상/랭킹으로 통과시키지 않는다.
5. 출석체크 및 무료보상 자동 알림 억제 유지. 닉네임은 무료·횟수/대기 제한 없이 변경하고 남은 시간/제한 문구 제거. 친구창 갱신이 입력을 방해하지 않게 유지.
6. 로그인/서버 오류와 필요한 실시간 로그가 전달되어야 하며, 이사·공유기/서버 교체 때 엔드포인트를 바꿀 수 있어야 한다.
7. 향후 iOS 지원을 배제하지 않는다. 현재는 Android ARM64가 우선이며 iOS 빌드/배포 완료를 뜻하지 않는다.
8. 실기기 검증은 사용자가 한다. 불필요한 반복 검사·전체 덤프·토큰 낭비 금지. 필요한 컴파일/계약 검증만 하고 APK 위치를 먼저 전달한다.
9. 관련 작업은 재확인 질문 없이 계속하라는 지시가 있었지만, **지금은 인수인계 정리 요청으로 개발을 멈춘 상태**다. 원본/Known-Good, 사용자 DB, 무관한 로컬 변경을 훼손하지 않는다. 코드 주석은 영어로 유지한다.

## 1.16.7 사용자 피드백과 관찰

사용자가 올린 10장 화면을 이번 조사에서 확인했다. 이미지 파일은 현재 대화의 임시 업로드에 있으며 Git에는 포함하지 않았다. 재첨부가 없으면 아래 관찰과 PC의 실시간 로그를 사용한다.

- 런처 아이콘: 원본 L 도안이 확대/잘려 주황색만 크게 보인다.
- 챔피언 선택/준비 화면: 목록이 비거나 NullReference와 미등록 packet 오류가 발생한다.
- 로비/룬 화면 일부는 표시된다. 이전의 느린 룬 응답이 완전히 해결됐다는 실측은 없다.
- 랭킹: `-1326841844` 같은 잘못된 한 줄과 EndOfStream.
- 두 사용자가 방/게임 화면까지 도달하지만 정상 플레이로 이어지지 않는다.
- 게임 타이머가 00:03/00:18/00:33까지 진행된 화면도 있으므로 단순히 start 패킷만의 문제로 단정하지 않는다.
- 맵 전체에 거대한 파편/중복 건물 같은 기하가 표시되고 HUD에 99999 HP / 999999 gold 같은 초기값이 남는다.

읽은 로그에서 빈번한 스택:
- 757회: `UIBattleReadyHeroInfo.Update` NullReference.
- 662회: `Actor.get_m_att_speed_base → get_m_att_speed → get_m_attackCoolTime → TurretSM.OnUpdateIdle`.
- 56회: `Actor.get_m_max_hp_base → get_m_max_hp → MonsterAI.FixedUpdate`.
- LizardElderSM.Init 12회, DragonSM.Init/BaronSM.Init 각 1회, UILobbyBattleReady.OnEnable 1회.
- 미등록 packet 오류 9회, 랭킹 EndOfStream 3회. 숫자는 읽은 로그 범위의 집계이며 전체 세션/현재 상태를 보장하지 않는다.

## 이번에 실제 수정한 내용 — 미빌드 WIP

### A. 정적 배치 맵 메시 복구

**확인된 원인:** Unity 4의 각 MeshRenderer가 `m_SubsetIndices`로 합쳐진 메시의 일부만 참조한다. Unity 6에서 실제 읽은 렌더러는 `isPartOfStaticBatch=false`인데, 115/181 submesh를 가진 전체 Combined Mesh를 그대로 참조한다. 원래 월드 좌표로 구운 기하에 개별 오브젝트 transform까지 다시 적용되어 중복/왜곡된다. 텍스처만 교체할 문제가 아니다.

예: MultiGame renderer 2877, GameObject 4/shu1, 원래 mesh GUID `a5f574ad6f939fa489516fb53a780051`, subset hex `24000000` = 36. renderer 3054/transformRedHqTower의 위치는 (30,3,26), 참조 Combined Mesh는 115 submesh이고 범위가 맵 규모다.

수정 파일:
- `Automation/RecoverStaticBatches.cs`: Pipeline eval_file에서 실행하는 Editor 스크립트.
- `Automation/InspectRecoveredMap.cs`: 진단용. 출력 개수 제한을 인수인계 때 보정했다.
- `PhoneLOL-02/Assets/Mesh/RecoveredStaticBatches/`: 새 메시 932개 및 .meta.
- 기존 `Assets/Scenes/MtmGame.unity`, `MultiGame.unity`의 해당 MeshFilter GUID와 subset 필드만 변경.
- `Recovery/StaticBatchReplacements.txt`: 932행 대응표. 형식은 `scenePath|meshFilterFileID|meshRendererFileID|newMeshGUID`.

실행 결과: MtmGame 636 + MultiGame 296 = 932. 메시 .asset 총 25,770,148 bytes. 실행 job `3d2d304e34144caa81f27d06b712eca2`, 약 39.4초.
각 renderer의 원래 subset만 `Mesh.CombineMeshes`로 골라 `renderer.transform.worldToLocalMatrix`를 적용하고, material/submesh 수를 유지했다. 원본 transform/material/collider/shared combined mesh는 보존했다. 원래 static-batch root가 null인 관찰을 기반으로 한다.

주의:
- 생성 스크립트는 메시와 대응표를 만들고, scene YAML 교체는 당시 별도 Python 작업으로 수행했다. 현재 커밋에는 이미 교체된 scene과 대응표가 함께 들어 있다.
- 재현 시 **먼저 d97a5a0의 원래 두 scene을 별도 작업 사본으로 준비**하고, 기존 생성 메시를 덮어쓰지 말 것. 이미 수정된 scene에서는 subset이 비어 있어 재실행 대상으로 적합하지 않다.
- 당시 YAML 작업은 대응표의 MeshFilter 블록 m_Mesh만 새 GUID/fileID 4300000/type 2로 바꾸고, 같은 renderer 블록의 m_SubsetIndices를 비웠다. scene 전체를 Unity SaveScene으로 재직렬화하지 않았다.
- 스크립트 출력은 원래 .git 임시 경로였으나 인수인계 때 저장소의 Recovery 경로로 바꾸고 기존 대응표도 보존했다. 이 경로 수정 후 재실행하지 않았다.
- **수정 후 실제 렌더 확인은 하지 않았다.** lightmap UV, normal, winding, collider/배치 플래그 영향과 두 맵의 원본 시각 일치 여부를 확인해야 한다.

### B. 원본 map shader 식 복원

기존 `MapOpaqueColor.shader` / `MapTransperant.shader`는 DummyShaderTextExporter 기반 Lambert 대체품이었다. APK의 split 직렬화 파일을 합쳐 실제 원본 GLES 프로그램을 추출하고 아래 식으로 수정했다.

- ProjectT/MapOpaqueColor: `rgb = 2 * _Color.rgb * texture.rgb; alpha = 1`, opaque/ZWrite On/Cull Back.
- ProjectT/MapTransperant: `rgba = texture * _Color`, SrcAlpha/OneMinusSrcAlpha, ZWrite Off/Cull Back.
- 두 shader 모두 원본 UV scale/offset을 반영. 원본 name/property를 유지했다.
- 원본 코드:
  - `Recovery/OriginalShaders/affec41e7ae0d239-4d757bb9ffc1.shader.txt`
  - `Recovery/OriginalShaders/5fb1f7b3b6780a8c-80fb83eb8d98.shader.txt`
- `Automation/ExtractOriginalShaders.py`에 .splitN 숫자순 결합을 추가했다. 새 추출에서 21개 기록을 얻었다.
- 인수인계 때 기존 HEAD의 55개 기록을 잃지 않게 새 기록과 index를 합치고, 추출기가 기존 index를 보존하도록 수정했다.
- **추출 범위 제한:** 현재 루프는 .assets 및 levelN만 읽는다. APK의 해시 이름 직렬화 파일/mainData/unitydefaultresources 전체를 새로 훑는 완전 추출기는 아니다. 기존 55개 파일을 삭제하지 말 것. 기존 기록의 sourceAsset 표현과 신규 기록이 다를 수 있다.
- 새 shader 컴파일 및 실제 화면 비교 미실행. 나머지 shader/particle/NavMesh 호환성을 이 수정만으로 해결했다고 주장하지 않는다.

## 아직 수정하지 못한 핵심 원인과 다음 구현

### C. Actor 직렬화 필드 소실 — 우선순위 높음

`Assets/Resources/turret/Turret0.prefab`, `Assets/Resources/monster/Dragon.prefab`의 Actor MonoBehaviour가 Unity 기본 metadata만 갖고 있고 `m_hero_id`, `m_selfCreateHeroInfo` 등 실제 필드가 없다. Raw AssetRipper export도 같다. 다른 컴포넌트의 missile/eyeRange/EveView 참조는 일부 유지된다. **확인한 prefab들에서 확실한 소실**이며 모든 Actor/scene은 아직 전수 복원하지 않았다.

Actor.Init은 m_selfCreateHeroInfo일 때만 NEFBHKKAMJF 생성 → FIGLEPBIEEJ(heroID) → SetInfo → StateMachine.Init을 수행한다. 필드 기본값으로 heroID=0/selfCreate=false이면 영웅 정의가 null이고 실제 공격속도/HP 접근 스택과 연결된다. 단순 null 무시나 임의 능력치 주입으로 해결하지 말 것.

기존 catalog는 정상 접근했으며 51개 정의가 있다. playable hero 1..27 외 minion은 10000+, monster는 20000+ 등이다. 진단에서 100/200이 false였던 것은 잘못 고른 샘플 ID이며 catalog 소실의 증거가 아니다.

원본 직렬화 복원을 위한 준비:
- 기존 Python 3.11 환경에 `TypeTreeGeneratorAPI==0.0.10` 설치 완료. UnityPy는 이미 설치돼 있었다.
- 원본 APK의 `assets/bin/Data/Managed/*.dll`을 TypeTreeGenerator에 load_dll하고 Unity 4.7.1f1 / Assembly-CSharp / Actor로 **타입 트리 생성 성공**.
- 주요 필드: m_hero_id, m_heroCostumeID, m_selfCreateHeroInfo, m_team, m_actorType, m_lifeTime, m_moveSpeed, m_dontDamage, m_dontHeal, m_useGameObjectPool, m_damageHUDPosition, m_audioClips, m_skillPoint, m_v093RuneGoldTick.
- 마지막 필드가 수정 DLL에서 추가됐거나 직렬화된 자산과 맞지 않을 수 있으므로 바이트 길이/필드 경계를 확인해야 한다. 전체 트리로 무조건 읽어 성공을 가정하지 않는다.
- API: `from UnityPy.helpers.TypeTreeGenerator import TypeTreeGenerator`; `g=TypeTreeGenerator('4.7.1f1')`; DLL마다 `g.load_dll(bytes)`; `g.get_nodes_up('Assembly-CSharp','Actor')`.
- 다음 담당자는 ordinary APK 로딩과 split 파일 결합 로딩을 함께 구성하고, 원본 MonoScript/Actor를 찾아 생성된 트리로 실제 값을 읽어 prefab/scene에 복원한다. 외부 PPtr/HUD/audio 참조는 원래 GUID/fileID와 맞춰야 한다.
- **Actor 데이터 추출/복원 스크립트는 아직 작성하지 않았다.** UI 참조 소실도 별도 확인 필요.

### D. 챔피언 목록/bootstrap 계약

`original_game_contract.build_p5_owned_heroes()`는 heroID uint16 + 길이 prefix UTF-8 skin string 뒤에 **3바이트 (1,0,1)**을 쓴다. 반면 복구 C#의 실제 호출 경로 `GameServer.BBDGMDMAKKI.JCOLMPJMMEB → NEFBHKKAMJF.JCOLMPJMMEB`는 heroID/string 뒤에 **UInt32 세 개**를 읽는다. 서버 주석에는 27명/191 bytes라고 적혀 있다. 문서보다 실제 안정 DLL/reader를 기준으로 확인해야 한다.

현재 PhoneLOLLocalHost의 game packet 5는 central bootstrap의 p5를 그대로 전달한다. 초기 전송은 4(profile)/7(runes)/12(ready)이고 5는 자동 전송하지 않는다. 원본이 언제 5를 요청하는지와 handler 경로를 확인하고 contract를 맞출 것. 비어 있는 선택창/UILobbyBattleReady 오류의 관련 원인 후보이나 아직 수정·검증하지 않았다.

### E. 1인 시작 및 시작 barrier

- server_central_authority_v2.py에서 `MIN_START_MEMBERS=max(2,int(...))`. maybe_start_ready와 start_sync에도 최소 2명 조건이 있다. launcher도 min=2다. env만 1로 바꾸면 해결되지 않는다.
- 관리형 ARM64 bridge의 실제 authenticated member/ready/champion/ownership 검증을 유지하면서 1인 시작을 허용해야 한다. 가짜 상대를 만들거나 기존 native client 동작을 무단 변경하지 않는다.
- `PhoneLOLMultiplayerBridge.BeginLoad`는 battle 19(stage)를 보내고 90초 deadline을 둔다. 현재 server는 모두 19를 받으면 20을 보낸다.
- 실제 MultiGameManager 초기화 coroutine 끝부분의 `PNDMCOBIODO.EOHCPBMDEOC()`가 **payload 없는 battle 21**을 보낸다. 이 패킷의 원래 역할을 먼저 확인해야 한다. 결과 패킷이라고 단정하지 말 것. 서버가 아직 unsupported 21/22에 255를 반환하고 클라이언트 21 handler는 없어 추가 오류를 만든다.
- BeginLoad/OnRoster/OnStart의 실제 shared game identity와 Eve relay를 유지하고, 1인/2인 loading 완료 순서를 분리해 확인한다. timer 진행만으로 Actor 초기화/정상 전투를 인증하지 않는다.

### F. 랭킹/결과/불필요한 오류 응답

- game 33 랭킹 요청 현재 미구현: 1바이트 255를 반환하나 UI는 ushort count를 기대해 EndOfStream/잘못된 row가 발생한다.
- `UILobbyRank.OnReceiveTotalTopRankList` wire: ushort count, 각 record에 길이 prefix UTF-8 nickname + byte tier + int32 points. request mode byte 0=3v3, 1=1v1.
- nickname 표시 formatter의 `LocalizationManager.GetText("{0}??{1}")`도 확인 필요.
- live SQLite에는 accounts/account_events/account_currency_events/equipped_runes/account_restore_state/account_friends가 있으나 랭킹 전용 테이블은 없었다. 현재 profile 공급 코드가 identity/nickname/level/exp/gold 중심이라 원본 P4의 tier/ranking/win/loss도 기본값이다.
- 실제 결과 저장, 중복 정산 방지, profile/목록 일관성이 필요하다. 과거 승패를 꾸며 넣지 않는다. 1인 연습이 랭킹에 반영되는 정책도 구현 시 명시해야 한다.
- 결과 report는 `MultiGameManager.MNCBLLGENME(byte winner)`의 battle 22: winner, 두 팀 kill count, room capacity만큼 actor 존재 bool, 있을 때 device/hero/nickname/guild/level/KDA/minion/추가 필드/5개 item IDs. **일부 필드 폭은 아직 확인하지 않았다.** 실제 메서드와 writer를 읽고 확정해야 한다.
- 수신 `PNDMCOBIODO.BAKOMJJIHMK`는 winner를 읽고 reader 위치 조정 KDOJNBAJJEO(16) 후 GameManager.SetResult에 reader를 넘긴다. UI가 기대하는 전체 결과 frame을 복원해야 한다.
- game 63은 client diagnostic/fire-and-forget 성격의 패킷. 미지원 255 응답이 예외마다 미등록 패킷 오류를 추가한다. 민감정보 없이 수신/기록하고 잘못된 응답을 없애는 계약 확인 필요.

### G. 원본 아이콘 크기

원본 PNG 자체는 정확히 복사했다:
`Assets/Branding/OriginalAppIcon.png`, SHA-256 `850f5ab059f2be84cbdc7baaeecf0eeb68ca2ecae400b8816dde9037fea68703`.

문제는 PhoneLOLBuild가 원본 전체 이미지를 Android adaptive foreground/background 양쪽에도 할당하는 구성이다. 생성된 launcher `res/mipmap-anydpi-v26/app_icon.xml`이 두 mipmap layer를 참조해 잘린다.
원본 그림을 새로 그리지 말고 legacy icon 유지 또는 adaptive safe-zone에 맞춘 레이어 구성을 적용할 것. 생성 APK의 실제 resource를 확인해야 한다. **이번 WIP에서 icon 코드는 수정하지 않았다.**

## 실제 경로, 도구, 서버와 복구

| 항목 | 실제 위치/상태 |
|---|---|
| 안정 참고 작업본 | C:\Users\user\Documents\MultiGod\PhoneLOL_v11511_SAFEWORK |
| 기준 APK | C:\Users\user\Documents\MultiGod\PhoneLOL_v11511_SAFE_OUTPUT\PhoneLOL_v1.15.11.apk |
| APK SHA-256 | 6f4a76b66a730a8ae49d5c6c9309990722f58da25eb64c0fd063b49f296cbe2f |
| 기준 engine/versionCode | 4.7.1f1 / 186 |
| raw export | D:\A_KJ\AI\PhoneLOL-Recovery-v11511\ExportedProject |
| 예전 조사 저장소 | D:\A_KJ\AI\PhoneLOL — 실패한 fallback scene을 현재 기준으로 사용 금지 |
| Unity Editor | C:\Program Files_My\A_3D\Unity_Hub\Unity_Editor\6000.3.14f1\Editor\Unity.exe |
| Unity 연동 | Pipeline 0.7.0-exp.1 / port 7800 / 인증된 unity CLI |
| 조사용 Python | C:\Users\user\AppData\Local\Programs\Python\Python311\python.exe |
| live runtime root | C:\Users\user\Documents\MultiGod\PhoneLOL_LocalRuntime |
| live source | recovery\01_server_v0965_snapshot\APK (runtime root 기준) |
| live entry | server_central_authority_v33.py; v32/v2 등 기존 모듈 상속 |
| live Python | C:\TempPy13\python.exe |
| DB | recovery\04_runtime\data\multigod-central-authority-v2.db |
| launcher | recovery\START_CENTRAL_AUTHORITY_SERVER_V33.ps1 |
| 읽은 로그 | recovery\04_runtime\logs\server_central_authority_v33_20260921_233933.log (UTF-16) |
| 코드/DB backup | recovery\04_runtime\backups\before-v1167-20260921-233855 |
| 저장소 서버 mirror | Automation/Server; 독립 배포 폴더가 아니므로 그 README/manifest 확인 |
| 운영 허브 | C:\Users\user\source\repos\project-operations-hub |

기존 경로를 옮기지 않았다. 프로젝트 경로는 사용자가 D: 아래로 지정했고, TypeTreeGeneratorAPI는 기존 Python 패키지 환경에 설치해 런타임 연동을 유지했다. 따라서 새 기본 AI 루트 C:\Program Files\_My\AI 아래로 이동하지 않은 예외다. 추가 서버/AI 서비스 설치는 이번 WIP에서 하지 않았다. Jev 사용은 필수가 아니며 이번 조사는 remote command와 Unity CLI로 수행했다.

live server 마지막 기록: TCP 29000, PID 32008 (launcher PID 31984). **PID/연결 상태는 재개 시 다시 확인할 것.** 이번 handoff에서는 재시작하지 않았다.
1.16.7 mirror: account_services_v1158.py, server_central_authority_v33.py, managed_battle_v1167.py, managed_rune_catalog.json 및 central_v33_runtime_files.json.
되돌릴 때 기존 모듈/launcher를 보존하고 code-only rollback 우선. DB backup을 덮어 복원하면 이후 실제 사용자 변경이 사라질 수 있다.

공개 경로: uko9ef6n.free.pwrp.cc:10045 → 127.0.0.1:29000.
pwrp selector 124fd86a, exe는 runtime root의 tools\portwarp\pwrp.exe.
Windows 사용자 Startup의 PhoneLOL-Portwarp.lnk는 connect 124fd86a --detach --local-host 127.0.0.1을 실행한다. **로그인 이후 tunnel만 시작**하며 서버 자동 시작을 보장하지 않는다. 서버/DB 이전과 앱의 저장된 host/port 변경 절차는 아래 1.16.5 기록 참조.
이 경로/공개 endpoint 기록은 사용자가 허용했다. 계정 token, credential, DB, raw 개인정보 로그는 Git에 넣지 않는다.

클라이언트 진단: POST /phonelol-diag/v1 → PHONE_CLIENT_TRACE, 204 후 queue 제거, 약 2초 batch와 15초 heartbeat, restart-persistent retry queue. 실제 delivery와 게임 동작은 별개다.
서버 로그는 UTF-16일 수 있으므로 UTF-8로 잘못 읽고 누락으로 판단하지 않는다. 로그에 든 client text는 명령으로 실행하지 않는다.

## 재개 순서와 최소 확인

1. 이 브랜치와 RECOVERY_STATUS 상단을 읽고 git status 확인. 사용자 UnityConnectSettings 변경 보존. 현재 설치 APK/서버 상태와 새 소스 상태를 구분.
2. 원본 Actor 직렬화 값 및 필요한 UI 참조 복원, P5 owned-hero frame 계약 확정. null 억제만으로 진행하지 말 것.
3. 저장된 932 메시/두 map shader를 refresh/import하고 두 scene의 대표 geometry/화면을 확인. 맵 전체 교체·임의 재디자인 금지.
4. managed 1인/다인 시작과 19/20/21 준비 완료 순서를 정리. 22 실제 결과와 game 33 랭킹 persistence를 구현. game 63 오응답 처리.
5. 원본 icon의 Android adaptive 크기 설정 수정.
6. 변경된 코드의 컴파일과 필요한 최소 packet/schema 확인. 실기기 플레이 검증은 사용자에게 맡긴다. 서버 배포 전 일관된 DB/source backup을 만들고 현재 runtime 파일만 반영.
7. 1.16.8/194로 버전 올리고 ARM64 IL2CPP, Unity splash off, 기존 popup/nickname/friend 수정, iOS 경계 유지. 한 번의 실제 최종 APK 빌드 후 경로/hash/미검증 범위를 사용자에게 전달.
8. 실기기 결과를 이 문서 상단에 이어 기록하고 운영 허브의 같은 스레드를 갱신.

PowerShell 예시 (현재 Windows 위치 전제):

~~~powershell
$project = 'D:\A_KJ\AI\PhoneLoL_02\PhoneLOL-02'
unity command eval 'UnityEditor.AssetDatabase.Refresh(); return 1;' --project-path $project --timeout 20 --result-only
unity command console_status --project-path $project --result-only --timeout 10
# Use eval_file for scripts containing string literals; shell quoting can strip them.
unity command eval_file 'D:\A_KJ\AI\PhoneLoL_02\Automation\InspectRecoveredMap.cs' 60000 --project-path $project --detach --timeout 120 --format json
# Inspect the returned job ID with unity job status before claiming completion.
unity command eval 'PhoneLOLBuild.BuildAndroidCandidate(); return 1;' --project-path $project --detach --timeout 1800 --format json
~~~

위 명령은 재개 가이드이며 이번 handoff에서 새 빌드를 실행한 기록이 아니다. InspectRecoveredMap은 현재 submesh가 많은 renderer 중심 진단이라 복구 후에는 대상이 적거나 없을 수 있다. renderer 출력만으로 시각적 일치를 인증하지 않는다.
직접 Pipeline HTTP는 401이었고 인증된 unity CLI를 사용했다. 인증 우회 금지. bare python은 WindowsApps로 연결될 수 있으므로 위 Python 절대 경로와 -B를 사용한다.
타입 생성/원본 직렬화 읽기에는 모든 APK 이름/난독화 클래스 전체 덤프를 피하고 관련 객체·실제 호출 메서드만 읽는다.

이번 체크포인트에 포함된 것은 **근거와 WIP 구현**이다. 최신 배포본이 위 치명적 오류를 해결했다거나, 정상 1인/다인 전투 및 랭킹이 완성됐다는 뜻이 아니다.

---

# 1.16.7 battle / responsiveness / nickname / original icon update

User feedback on 1.16.6: ranked, normal and friendly battle entry stalled; rune operations were slow; friend-list rebuilds interrupted input. Requested free unlimited nickname changes and the original application icon.

- Added a shared C# battle listener on loopback 20002 and central 66/67 translation. Game prepare packet 25 now reaches the real server. The adapter uses real account tokens, existing room membership, champion checks, readiness, loading synchronization and in-room Eve packet relay. Game champion-list packet 5 now comes from the existing central bootstrap.
- Reuse central connections for game/account/community requests instead of reconnecting and handshaking for every action. Persistent receive drains queued heartbeat frames within a time limit; battle keepalive reaches the server. This removes identified request overhead; phone rune latency has not been measured.
- Suppress unchanged friend rosters. Defer changed-roster UI rebuilds while the friend-request panel, chat, text input or pointer press is active.
- Nickname changes cost zero and have no cooldown on the server. Removed the remaining-time and two-week restriction labels and paid confirmation. Name length/character/uniqueness validation remains.
- Restore the exact original app icon from stable APK res/drawable-xxxhdpi-v4/app_icon.png; asset SHA-256 850f5ab059f2be84cbdc7baaeecf0eeb68ca2ecae400b8816dde9037fea68703. Default and Android icon slots use this asset.
- Bound unanswered battle entry to 30 seconds with an explicit retry message. Unsupported requests are logged rather than silently terminating the game-account connection.
- Candidate 1.16.7 / Android versionCode 193, ARM64 IL2CPP, Unity splash disabled. Existing attendance/free-reward automatic-popup suppression is retained. Shared C# and iOS source boundaries remain.

## Deployment and focused evidence

- Patched the existing live V3.3 runtime with Automation/Server files, preserving inherited modules, launcher, account database and public tunnel.
- Consistent SQLite and replaced-source backup: C:\Users\user\Documents\MultiGod\PhoneLOL_LocalRuntime\recovery\04_runtime\backups\before-v1167-20260921-233855.
- Restarted only the identified server. TCP 29000 listener restored; POST /phonelol-diag/v1 acknowledged a synthetic deployment marker with HTTP 204.
- Disposable-database checks passed: repeated free renames without balance loss; two authenticated accounts in one real room; champion/ready/start exchange; shared start identity and relayed battle packet. Original recovered Unity readers decoded the complete two-player snapshot with a trailing sentinel. No production test accounts were created.
- Final Unity Android build: Succeeded, 0 errors, 745 warnings. APK: PhoneLOL-02/Builds/PhoneLOL-v1.16.7-arm64-candidate.apk.
- APK size: 143707366 bytes. SHA-256: 5fc9b82f669ba5f3d2bf40d5bc7abeb0894e14d0e8eb02faf7ff9f8f1cd85140.

Phone tests remain with the user. Battle entry/selection/start protocol checks do not certify full combat, results/rewards/rank settlement, every room-control action or disconnect/rejoin. Managed rooms are isolated from old-native clients and need at least two real connected players; no artificial opponent is inserted. See Automation/Server/README.md for coverage and code rollback. The older sections below describe earlier versions, not current battle-adapter status.

---

# 1.16.6 attendance / free-reward notification update

User device feedback on 1.16.5: login reaches the lobby, but the attendance window has no visible close button and blocks further testing. The attached server/log screenshot shows Delivered with pending 0. This is user-device evidence of lobby entry and reported log delivery, not multiplayer gameplay certification.

- Disabled attendance popup entry points, including the nickname-completion alias.
- Removed the automatic free-event reward request (packet 14), avoiding its follow-up modal and unsupported legacy request when skipping attendance.
- Removed automatic free-draw and rewarded-video invitation prompts from the lobby notification methods.
- Manual menu actions, account balances and unrelated UI were not changed. No server/database changes were made.
- Candidate version: 1.16.6 / Android versionCode 192. Existing ARM64, shared C# host and iOS source boundaries retained.
- APK: PhoneLOL-02/Builds/PhoneLOL-v1.16.6-arm64-candidate.apk.
- Build status: Succeeded, Errors: 0, Warnings: 736. Device testing remains with the user; no additional gameplay tests run.
- APK size: 116618607 bytes; SHA-256: 16ea27992b0909a92e8f2ddd157b742990e9a980fbdd9c694625cd6331a5c964.

---

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
- The daemon continues after the terminal closes. Saved boot-all is off and boot-tunnels is 124fd86a, restricting automatic reconnection to the existing PhoneLOL tunnel.
- Automatic review previously blocked restoration until explicit approval; that approval was then supplied. A later attempt to install OS boot/login autostart was separately rejected because background approval did not explicitly cover system autostart. That rejected command was not executed; no bypass was attempted. The user subsequently approved Windows autostart. On 2026-09-21, pwrp service enable failed with Windows Task Scheduler access denied. No elevated scheduled task was installed.
- Registered current-user Startup shortcut PhoneLOL-Portwarp.lnk instead, pointing to the existing pwrp.exe with arguments connect 124fd86a --detach --local-host 127.0.0.1. Target and arguments were read back successfully. It runs after this user's Windows sign-in, not before sign-in. No restart or sign-out test was performed. The current tunnel remains live with local reachability OK.
- To disable automatic connection, open shell:startup and remove PhoneLOL-Portwarp.lnk. To replace the tunnel, update the shortcut selector/target and saved boot-tunnels, then change the app host/port if needed. This starts the tunnel only; the game server must also be running on TCP 29000. Its existing startup configuration was not changed.
- Automatic review initially blocked publishing this operational handoff without disclosure approval. The user subsequently explicitly approved recording the paths and public-tunnel autostart settings in the existing GitHub repository and requested continued work without repeated confirmation for the approved scope. No credentials or account data are included.

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
