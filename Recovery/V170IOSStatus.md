# iOS 1.7.0 / 197 — Xcode export complete; Mac build and signing pending

- Official iOS Build Support 6000.3.14f1 installed successfully on Windows KJW.
- Module path: C:/Program Files_My/A_3D/Unity_Hub/Unity_Editor/6000.3.14f1/Editor/Data/PlaybackEngines/iOSSupport. Existing-editor dependency exception to the default C:/Program Files/_My/AI installation root.
- Restart after module installation is required. The first attempt reported success despite 2 errors and no project. The export method now rejects nonzero errors and missing project/Info.plist.
- Remote raw Editor launch lacked Windows environment variables and could not start UPM. The existing Automation/OpenUnity.ps1 supplies them; use this script for subsequent remote launches. No firewall/Defender change was needed.
- Successful export job d659c4b760a74ee08f9893c8af8660b2: 40500 ms, 0 errors, 35 warnings.
- Verified real Unity-iPhone.xcodeproj/project.pbxproj and Info.plist, version 1.7.0, build197, com.jcl.lmulti, ARM64/Metal and landscape orientation.
- Export moved after build to PhoneLOL-02/Builds/iOS/PhoneLOL-1.7.0 to honor the user's no-suffix naming request. Recovery/V170IOSExport.txt retains the original build-time path.
- Combined delivery: C:/Users/user/Documents/MultiGod/PhoneLOL_LocalRuntime/00_PHONELOL_TEST_HERE/PhoneLOL-1.7.0.zip
- Contents: Android/PhoneLOL-1.7.0.apk and iOS/PhoneLOL-1.7.0/ (Xcode project), with Korean instructions. ZIP integrity and embedded APK SHA-256 verified; shell scripts/usymtool executable bits preserved for Mac.
- Archive: 648469575 bytes, SHA-256 d0307a14902138020384cf92f72eaa0b7d7f9e111bdc0b116ecf9c3014750522.
- Only Windows KJW is connected. Xcode compilation, native linking, Apple signing/provisioning, IPA generation and actual iPhone execution remain unperformed. This ZIP is not a finished iOS app.
- Next: obtain access to the user's Mac and Apple signing setup; open Unity-iPhone.xcodeproj, build/sign/install and verify actual iPhone behavior. No account passwords, certificates or private keys were added to the archive.
- Android APK contents and live server/account database were unchanged during iOS preparation. Public GitHub publishing remains withheld.

Official Unity build process:
https://docs.unity3d.com/kr/6000.0/Manual/iphone-BuildProcess.html
