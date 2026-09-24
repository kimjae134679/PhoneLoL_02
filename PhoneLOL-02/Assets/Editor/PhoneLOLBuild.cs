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
    [MenuItem("PhoneLOL/Build 1.16.10 ARM64 candidate")]
    public static void BuildAndroidCandidate()
    {
        if (!BuildPipeline.IsBuildTargetSupported(BuildTargetGroup.Android, BuildTarget.Android))
            throw new InvalidOperationException("Install this Editor's Android Build Support first.");
        var originalIcon = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Branding/OriginalAppIcon.png");
        if (originalIcon == null) throw new FileNotFoundException("Original app icon is missing.");
        PlayerSettings.SetIconsForTargetGroup(BuildTargetGroup.Unknown, new[] { originalIcon });
        foreach (var kind in PlayerSettings.GetSupportedIconKindsForPlatform(BuildTargetGroup.Android)) {
            var icons = PlayerSettings.GetPlatformIcons(NamedBuildTarget.Android, kind);
            foreach (var icon in icons)
                for (int layer = 0; layer < icon.minLayerCount; layer++) icon.SetTexture(originalIcon, layer);
            PlayerSettings.SetPlatformIcons(NamedBuildTarget.Android, kind, icons);
        }
        PlayerSettings.bundleVersion = "1.16.10";
        PlayerSettings.Android.bundleVersionCode = 196;
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
        string output = Path.GetFullPath("Builds/PhoneLOL-v1.16.10-arm64-candidate.apk");
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

public sealed class PhoneLOLLegacyIconPostprocessor : UnityEditor.Android.IPostGenerateGradleAndroidProject
{
    public int callbackOrder { get { return 1000; } }

    public void OnPostGenerateGradleAndroidProject(string path)
    {
        string root = Path.GetDirectoryName(path);
        string resources = Path.Combine(root, "launcher", "src", "main", "res");
        if (!Directory.Exists(resources))
            throw new DirectoryNotFoundException("Generated launcher resources are missing: " + resources);
        // Preserve the original full legacy icon instead of cropping it as two adaptive layers.
        foreach (string xml in Directory.GetFiles(resources, "app_icon*.xml", SearchOption.AllDirectories)) {
            var document = System.Xml.Linq.XDocument.Load(xml);
            if (document.Root == null || document.Root.Name.LocalName != "adaptive-icon") continue;
            string fallback = Path.GetFileNameWithoutExtension(xml) + ".png";
            if (Directory.GetFiles(resources, fallback, SearchOption.AllDirectories).Length == 0)
                throw new FileNotFoundException("Legacy icon fallback is missing: " + fallback);
            File.Delete(xml);
        }
    }
}
