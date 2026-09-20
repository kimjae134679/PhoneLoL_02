using UnityEngine;

// Analytics are optional; an absent legacy Java SDK must not abort game startup.
public static class LegacyAndroidServices
{
    private static bool checkedAnalytics;
    private static bool analyticsAvailable;
    public static bool AnalyticsAvailable
    {
        get
        {
            if (checkedAnalytics) return analyticsAvailable;
            checkedAnalytics = true;
#if UNITY_ANDROID && !UNITY_EDITOR
            try
            {
                using (var sdk = new AndroidJavaClass("com.igaworks.unity.plugin.IgaworksUnityPluginAos"))
                    analyticsAvailable = sdk.GetRawClass() != System.IntPtr.Zero;
            }
            catch (AndroidJavaException)
            {
                Debug.LogWarning("Legacy Igaworks analytics SDK is absent; analytics startup is skipped.");
            }
#endif
            return analyticsAvailable;
        }
    }
}
