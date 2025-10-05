// Optional: Editor build script placeholder for CI use.
#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

public static class BuildScript
{
    public static void BuildWindows()
    {
        string[] scenes = { "Assets/Scenes/ArenaScene.unity" };
        BuildPipeline.BuildPlayer(scenes, "Builds/WWG_Windows/WWG.exe", BuildTarget.StandaloneWindows64, BuildOptions.None);
    }

    public static void BuildAndroid()
    {
        string[] scenes = { "Assets/Scenes/ArenaScene.unity" };
        BuildPipeline.BuildPlayer(scenes, "Builds/WWG_Android/WWG.apk", BuildTarget.Android, BuildOptions.None);
    }
}
#endif
