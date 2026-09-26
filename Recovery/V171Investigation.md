# 1.7.1 attack and control follow-up

## Evidence
- User desktop aaaaa.jpg shows Teemo's animation event reaches Actor.CreateMissile, then a NullReferenceException in the allocation callback.
- Real 1.7.0 phone diagnostics also contain repeated TargetMissileAI.Attack exceptions and a Graves CreateSkill0Missile exception.
- Removing a projectile target reproduces the common impact exception. A missing target or owner now retires the projectile, and flight lifetime advances in Run instead of only during the initial delay.
- Teemo, Vayne and Tristana override the base attack method; their corresponding paths were covered too.
- Comparing 0a3529d to 7ad052c shows the nexus projectile override added to Actor.CreateMissile. No basic projectile asset was changed there.
- Teemo adopting a turret attack after the enemy nexus fires was NOT reproduced in Editor. Both Editor and the generated Android string hash algorithm were checked against canonical resource paths; no collision was found. A hash collision is not an established cause.
- Missile creation now loads and validates the exact GameObject resource before allocating, bypassing the hash-only effect cache. Fresh inactive clones are activated before resetting their actor state. These are defensive fixes for the creation path, not proof of the reported cross-projectile root cause.

## Changes
- Both maps: combat-control group 1.06 -> 1.22 (about 15% larger than 1.7.0), matching visual/collider transforms.
- Bottom controls, skill upgrades, pause, pings and scoreboard button enlarged 15%. Upgrade and ping spacing adjusted.
- Eight active-item slots now use full-size 4x2 rows, replacing the old 0.625-scale single row. Five-slot mode retains its existing row, enlarged with the control group.
- Enemy SubHero targets are included in basic-attack targeting, enabling the stationary Alistar. Friendly-team exclusion remains.
- Alistar position: spawn + world Z4 for blue, Z-4 for red, snapped to nearby NavMesh when available. These maps' game camera projects +Z upward.
- Startup server/diagnostics GUI defaults hidden. Ordinary log/warning/error entries do not open the developer console. Exception/Assert or an unhandled exception request it on the main thread. Background diagnostics remain available.
- Version 1.7.1, Android code198, ARM64. No server or account database change.

## Verification and limits
See V171AttackVerification.txt and V171UIVerification.txt.
- 30 alternating Teemo/Nexus creations/reuses retain their prefab AI, owner and target.
- 17 basic projectile prefabs initialize. Homing attacks deliver a normal hit to an Editor-only endpoint and retire missing targets; Tristana's custom normal damage path was not exercised, only creation/missing-target handling.
- Missing-owner retirement, enemy Alistar selection, friendly exclusion and three immediate revivals pass.
- Both maps: 14 combat controls, four edge raycasts per control, no attack/skill/item/upgrade overlap in the inspected layout.
- No Android phone is connected by ADB. Real device rendering, physical damage calculation/network delivery and the reported Teemo/turret transition still require phone confirmation.
- Existing lighting/audio/material/navigation fixes were preserved. Scene reserialization was discarded; only explicit HUD transform fields were retained.
- The old iOS 1.7.0 Xcode export is not updated by this Android build. Future Mac work must export/build the current source, sign it and produce an installable distribution.
