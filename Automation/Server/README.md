# 1.7.0 room expansion

Display version is 1.7.0, with Android versionCode 197 for upgrade continuity. Next versions are 1.7.1, 1.7.2.
Mode 101 has two seats. Modes 102 and 103 have ten seats. Mode 103 uses the existing mode-10 rules and eight-item result payloads.
Both the managed adapter and central-authority capacity mapping must be updated; the latter previously forced mode 102 back to four seats.
Run check_v170.py for disposable 2/10/10-player selection, start/load/results and nickname reconnect/server-restart persistence. It includes a Korean nickname.
Keep the existing launcher and database. The deployed backup and source hashes are in Recovery/V170Deployment.txt.
All participants in expanded rooms must use the new client; old six-slot clients cannot parse ten-slot room snapshots.

---

# Managed battle, results and rankings (1.16.9)

Patch the existing V3.3 runtime; this folder is not a standalone replacement for inherited server modules.

Deploy the files listed in central_v33_runtime_files.json into the existing runtime. Updated managed files are server_central_authority_v33.py, account_services_v1158.py, managed_battle_v1167.py, managed_results_v1168.py and managed_rune_catalog.json. Keep the existing launcher, environment, database and public tunnel. Back up replaced sources/manifest and use SQLite backup before deployment.

The current deployment and APK are recorded at the top of ../../RECOVERY_STATUS.md. Backup before this release: recovery/04_runtime/backups/before-v1168-20260924-170631. That backup contains a runtime reverted to pre-1.16.7 behavior. On 2026-09-25 the cause was traced to the legacy test launcher's startup sync; see the startup repair below. Prefer code-only rollback and do not restore the database just to roll back code.

In 1.16.9, bounded Eve sessions are separate from native transport sessions to prevent champion view-ID collision and overflow. Team movement uses managed packet 61001. Mode 10 results carry eight item IDs per player; ranked/friendly results retain five. All mode participants must install 1.16.9. See Recovery/V1169Deployment.txt and the top of RECOVERY_STATUS.md for the current deployment and backup.

Managed transport is central 66/67; account RPC is 64/65. Native client contracts and minimum-player policy remain unchanged. Managed rooms accept one or more actual authenticated ready players, without artificial opponents.

The result service verifies the authenticated room host, roster, slot/device/hero identity, initialization and frame boundaries. It persists the outcome once and broadcasts the recovered scoreboard. It does not independently simulate combat. Packet 27 returns the participant's 85-byte result/account data; packet 33 returns persisted top-100 rankings.

Ranking policy is a replacement because the original server's scoring formula is unavailable: initial competitive rating 1000, K=32 Elo against opposing team average, floor zero. Only ranked modes 0 and 20 in the ranked managed group with both teams represented affect ranking. Solo, normal and friendly play are stored but do not alter ranking. Ties sort by wins then account ID. No historical records are invented.

New SQLite tables are managed_rank_stats, managed_match_results and managed_match_members. Existing account data and balances remain. Original currency/experience reward rules are not recovered, so result rewards remain zero; this does not fabricate account rewards.

Run check_managed_v1167.py with the inherited runtime dependencies available. The existing filename is retained. It uses a temporary database/local server and now covers two-peer start/load/relay, solo completion, host-only result submission, duplicate settlement, ranking/result contracts and free repeated renames. It is not a full gameplay or device test.

Disconnect/rejoin, original visual parity, every room-control operation, old-native cross-play, combat anti-cheat and iOS are not certified. Actual phone validation remains with the user.

## Startup repair (2026-09-25)

The current Windows Startup wrapper invokes the runtime's 00_PHONELOL_TEST_HERE/PHONELOL_TEST_V213.ps1. The old launcher copied obsolete sources from PhoneLOL_v1155/APK on every detected bundle mismatch, reverting the managed entrypoint and account services after reboot.

The tracked PHONELOL_TEST_V213.ps1 is the deployed repair. It selects this folder's manifest and five required managed files, and resolves inherited dependencies from the preserved legacy bundle. Missing managed files fail the isolated preflight; the preflight also requires managed battle and results services. Sync excludes the legacy launcher itself so it cannot overwrite this fix.

To redeploy this repair, back up the active launcher, server bundle and SQLite database first, copy this launcher to the existing runtime's 00_PHONELOL_TEST_HERE folder, then run START_REMOTE_STACK.ps1. Run it again to verify the current process is preserved and compare the five managed sources plus manifest. Paths are pinned to the current Windows installation; update them explicitly if moving installations. Keep the separate existing Portwarp startup shortcut. Do not restore the account database merely to roll back code.

Verified with the actual startup entrypoint twice, exact source/manifest comparisons, disposable managed protocol checks and local/public diagnostic HTTP 204. No second full PC reboot or phone gameplay test was performed.
