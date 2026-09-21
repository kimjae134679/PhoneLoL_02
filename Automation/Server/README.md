# Managed battle and account update (1.16.7)

These files patch the existing V3.3 runtime; this directory is not a standalone replacement for its inherited V3.2/V2/server_v4 modules.

- Copy account_services_v1158.py, server_central_authority_v33.py, managed_battle_v1167.py and managed_rune_catalog.json into the existing APK server directory.
- Keep the existing launcher, environment, database path and inherited runtime files. Add the two new managed files to central_v33_runtime_files.json.
- Back up replaced files and use SQLite's backup API for the active account database before deployment. Restart only the identified V3.3 server.
- Runtime deployment performed on 2026-09-21. The pre-deployment backup is recovery/04_runtime/backups/before-v1167-20260921-233855.
- To roll back code, stop V3.3, restore account_services_v1158.py, server_central_authority_v33.py and central_v33_runtime_files.json from that backup, and restart the original launcher. The added managed files are then unused. Do not restore the database merely to roll back code: that would discard subsequent account changes.

The managed client uses central request/response types 66/67 for encrypted legacy battle traffic adapted by its local C# transport. Actual authentication, room membership, champion ownership and readiness remain checked by the existing server. Group values isolate these managed rooms from older native clients.

Focused check: run check_managed_v1167.py with the existing runtime dependencies available as configured in that script. It creates a temporary database and loopback server, not production accounts. CheckManagedRoom.cs reads its generated probe through the recovered Unity packet readers.

Covered: game prepare, battle authentication, create/find/join, room snapshots, champion/skin/lane/rune page, ready/start, load barrier and in-room Eve relay. Unsupported battle operations fail explicitly. Match results/rewards/rank settlement, old-native cross-play, disconnect/rejoin recovery, team-move/kick controls and complete on-device combat are not certified. Two real connected players are required; no artificial opponent or reward is injected.

The rune catalog contains stat definitions extracted from the stable recovered client, not account inventory or credentials. Nickname changes retain name/uniqueness validation but cost zero and have no cooldown.
