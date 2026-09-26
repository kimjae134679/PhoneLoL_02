# 1.7.2 / 199 - neutral Alistar target and bounty - 2026-09-25

- Latest user instruction: finish changes, issue the build command, then end without waiting for completion or copying to Desktop.
- Practice Alistar is now a neutral Monster (combat team2), with EveView scene-object authority. Both player teams can select and damage it. SpawnTeam separately records its location side and prevents duplicate spawns.
- Rejoin recovery uses the practice-guard spawn RPC rather than looking for a Monster/Alistar resource.
- Health20000; each lethal damage message awards exactly1000 gold to the killing hero (resolving projectile/summon owner), then immediately revives the guard at its home. Normal monster kill rewards/scoreboard events are bypassed.
- Placement mirrors the user's uploaded sketch: bottom/blue spawn +X28; top/red spawn -X28. Straight map adds Z-8/+8 to separate from the center lane. Nearby NavMesh sampling is retained.
- Level display was inspected ONLY: UIHeroDamageHUD.Update hides m_levelBack due to the earlier request to remove all overhead text. It was not restored.
- Verification passed: both-team targeting and damage permission, actual OnAttackDamage HP20000 ->19959.39, three lethal applications each restoring20000 and awarding exactly1000, mirrored placement. See Recovery/V172PracticeVerification.txt.
- Build command is the final action. Output target: PhoneLOL-02/Builds/PhoneLOL-1.7.2.apk. Consult Recovery/V172BuildJob.json and Builds/build-result.txt; do not claim build completion until they confirm it.
- No Desktop1.7.2 folder, copy, ZIP or iOS export is requested. Existing Desktop1.7.1 APK/ZIP were already produced and tested by the user; preserve them.
- All1.7.1 projectile/UI/logging changes remain. The Teemo/turret visual transition was not reproduced earlier and is not newly certified here.
- No live server/account database change or public GitHub push. Preserve the independent UnityConnectSettings.asset modification.
- Editor test fixture required a real offline PNDMCOBIODO client; the earlier empty-network fixture's GetDefaultGroup exception was a test setup issue. Final actual damage test passed.
