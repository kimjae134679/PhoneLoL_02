using System;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;

public static class PhoneLOLBuild
{
    // This produces a migration candidate, not a validated replacement for 1.15.11.
    [MenuItem("PhoneLOL/Build 1.16.5 ARM64 candidate")]
    public static void BuildAndroidCandidate()
    {
        if (!BuildPipeline.IsBuildTargetSupported(BuildTargetGroup.Android, BuildTarget.Android))
            throw new InvalidOperationException("Install this Editor's Android Build Support first.");
        PlayerSettings.bundleVersion = "1.16.5";
        PlayerSettings.Android.bundleVersionCode = 191;
        PlayerSettings.SetApplicationIdentifier(NamedBuildTarget.Android, "com.jcl.lmulti");
        PlayerSettings.SetScriptingBackend(NamedBuildTarget.Android, ScriptingImplementation.IL2CPP);
        PlayerSettings.Android.targetArchitectures = AndroidArchitecture.ARM64;
        PlayerSettings.Android.forceInternetPermission = true;
        PlayerSettings.SetManagedStrippingLevel(NamedBuildTarget.Android, ManagedStrippingLevel.Minimal);
        PlayerSettings.SplashScreen.show = false;
        PlayerSettings.SplashScreen.showUnityLogo = false;
        PlayerSettings.colorSpace = ColorSpace.Gamma;
        UnityEditor.PlayerSettings.defaultInterfaceOrientation = UnityEditor.UIOrientation.AutoRotation;
UnityEditor.PlayerSettings.allowedAutorotateToPortrait = false;
UnityEditor.PlayerSettings.allowedAutorotateToPortraitUpsideDown = false;
UnityEditor.PlayerSettings.allowedAutorotateToLandscapeLeft = true;
UnityEditor.PlayerSettings.allowedAutorotateToLandscapeRight = true;
        EditorUserBuildSettings.buildAppBundle = false;
        EditorUserBuildSettings.exportAsGoogleAndroidProject = false;
        string[] names = { "Login", "Lobby", "MultiGameLoading", "MultiGame", "MtmGameLoading", "MtmGame" };
        string[] scenes = names.Select(name => "Assets/Scenes/" + name + ".unity").ToArray();
        foreach (string scene in scenes)
            if (!File.Exists(scene)) throw new FileNotFoundException("Missing original scene", scene);
        string output = Path.GetFullPath("Builds/PhoneLOL-v1.16.5-arm64-candidate.apk");
        Directory.CreateDirectory(Path.GetDirectoryName(output));
        var report = BuildPipeline.BuildPlayer(new BuildPlayerOptions {
            scenes = scenes, locationPathName = output, target = BuildTarget.Android,
            options = BuildOptions.Development
        });
        string status = "Result: " + report.summary.result + "\nErrors: " + report.summary.totalErrors +
            "\nWarnings: " + report.summary.totalWarnings + "\nOutput: " + output +
            "\nGameplay, legacy native host, and shader parity are not certified by a successful build.";
        File.WriteAllText("Builds/build-result.txt", status);
        if (report.summary.result != BuildResult.Succeeded)
            throw new InvalidOperationException(status);
        Debug.Log(status);
    }
}
