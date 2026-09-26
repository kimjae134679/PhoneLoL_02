using System;
using System.Collections.Generic;
using UnityEngine;

public static class LegacyAndroidServices
{
    private static readonly Dictionary<string, bool> available = new Dictionary<string, bool>();
    public static bool AnalyticsAvailable { get { return IsAvailable("com.igaworks.unity.plugin.IgaworksUnityPluginAos"); } }
    public static bool IsAvailable(string className)
    {
        bool value;
        if (available.TryGetValue(className, out value)) return value;
#if UNITY_ANDROID && !UNITY_EDITOR
        try {
            using (var plugin = new AndroidJavaClass(className)) value = plugin.GetRawClass() != IntPtr.Zero;
        } catch (AndroidJavaException) { value = false; }
#else
        value = false;
#endif
        available[className] = value;
        if (!value) PhoneLOLRealtimeLog.Record("OPTIONAL_SDK_UNAVAILABLE", className);
        return value;
    }
}
