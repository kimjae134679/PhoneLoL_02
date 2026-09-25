# iOS 1.7.0 — BLOCKED

No Xcode export or IPA has been produced.

- Connected build device: Windows KJW, Unity 6000.3.14f1. No connected Mac/Xcode/signing environment.
- Official iOS Build Support installation was attempted. Installer result: ELEVATION_CANCELLED — Windows elevation prompt cancelled or timed out.
- Editor verification: BuildPipeline.IsBuildTargetSupported(iOS, iOS) == false.
- Added PhoneLOLBuild.BuildIOSCandidate(), menu PhoneLOL/Export 1.7.0 iOS Xcode project. It uses the six existing scenes, IL2CPP, landscape orientation, version 1.7.0/build 197 and com.jcl.lmulti.
- This export method compiles in the Editor but has not run successfully. iOS native plugin linking, Xcode compilation, signing and device execution remain unverified.
- To resume: finish installing this Editor's iOS module with the Windows administrator prompt, then run the export method. Build/sign the exported project on a Mac with Xcode and the user's signing setup.
- Existing project/tool locations were retained; no new standalone tool was installed. Sources remain D:/A_KJ/AI/PhoneLoL_02; Unity remains at the user's existing Program Files_My/A_3D/Unity_Hub/Unity_Editor path. This is an existing-location exception to the hub's default C:/Program Files/_My/AI root.

Official Unity build process:
https://docs.unity.com/en-us/engine/6000.3/manual/platform-specific/iphone/ios-building-and-delivering/build-process
