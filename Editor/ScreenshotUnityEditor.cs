using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Codice.CM.Client.Gui;

[CustomEditor(typeof(ScreenshotUnity))]
public class ScreenshotUnityEditor : Editor
{
    public override void OnInspectorGUI() {
        ScreenshotUnity screenshotUnity = (ScreenshotUnity)target;

        screenshotUnity.keyCode = (KeyCode)EditorGUILayout.EnumPopup("Key", screenshotUnity.keyCode);
        
        // Don't forget to call this at the end to apply changes
        if (GUI.changed) {
            EditorUtility.SetDirty(screenshotUnity);
        }

        if(GUILayout.Button("Take Screenshot")) {
            screenshotUnity.CaptureScreenshot();
        }
    }
}
