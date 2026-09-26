using System;
using UnityEngine;

// Preserve the old AddComponent(string) behavior without the Editor-only API updater.
public static class LegacyUnityComponents
{
    public static Component AddComponent(GameObject target, string typeName)
    {
        if (target == null) throw new ArgumentNullException(nameof(target));
        Type resolved = null;
        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
            resolved = assembly.GetType(typeName, false) ?? assembly.GetType("UnityEngine." + typeName, false);
            if (resolved != null && typeof(Component).IsAssignableFrom(resolved)) break;
            resolved = null;
        }
        if (resolved == null)
        {
            Debug.LogError("Cannot add the recovered component type: " + typeName, target);
            return null;
        }
        return target.AddComponent(resolved);
    }
}
