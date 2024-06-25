using UnityEditor;
using System.IO;
[InitializeOnLoadAttribute]
public static class CopyEditor
{
    static CopyEditor()
    {
        EditorApplication.playModeStateChanged += LogPlayModeState;
    }
 
    private static void LogPlayModeState(PlayModeStateChange state)
    {
        if (File.Exists("QualitySettings.asset"))
        {
            File.Delete("ProjectSettings/QualitySettings.asset");
            File.Copy("QualitySettings.asset", "ProjectSettings/QualitySettings.asset");
        }
    }
 
}
