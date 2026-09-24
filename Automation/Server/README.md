# Managed battle, results and rankings (1.16.8)

Patch the existing V3.3 runtime; this folder is not a standalone replacement for inherited server modules.

Deploy the files listed in central_v33_runtime_files.json into the existing runtime. Updated managed files are server_central_authority_v33.py, account_services_v1158.py, managed_battle_v1167.py, managed_results_v1168.py and managed_rune_catalog.json. Keep the existing launcher, environment, database and public tunnel. Back up replaced sources/manifest and use SQLite backup before deployment.

The current deployment and APK are recorded at the top of ../../RECOVERY_STATUS.md. Backup before this release: recovery/04_runtime/backups/before-v1168-20260924-170631. That backup contains a runtime unexpectedly reverted to pre-1.16.7 behavior; the cause is unknown. Prefer code-only rollback and do not restore the database just to roll back code.

Managed transport is central 66/67; account RPC is 64/65. Native client contracts and minimum-player policy remain unchanged. Managed rooms accept one or more actual authenticated ready players, without artificial opponents.

The result service verifies the authenticated room host, roster, slot/device/hero identity, initialization and frame boundaries. It persists the outcome once and broadcasts the recovered scoreboard. It does not independently simulate combat. Packet 27 returns the participant's 85-byte result/account data; packet 33 returns persisted top-100 rankings.

Ranking policy is a replacement because the original server's scoring formula is unavailable: initial competitive rating 1000, K=32 Elo against opposing team average, floor zero. Only ranked modes 0 and 20 in the ranked managed group with both teams represented affect ranking. Solo, normal and friendly play are stored but do not alter ranking. Ties sort by wins then account ID. No historical records are invented.

New SQLite tables are managed_rank_stats, managed_match_results and managed_match_members. Existing account data and balances remain. Original currency/experience reward rules are not recovered, so result rewards remain zero; this does not fabricate account rewards.

Run check_managed_v1167.py with the inherited runtime dependencies available. The existing filename is retained. It uses a temporary database/local server and now covers two-peer start/load/relay, solo completion, host-only result submission, duplicate settlement, ranking/result contracts and free repeated renames. It is not a full gameplay or device test.

Disconnect/rejoin, original visual parity, every room-control operation, old-native cross-play, combat anti-cheat and iOS are not certified. Actual phone validation remains with the user.
