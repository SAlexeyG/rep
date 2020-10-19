using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Wall))]
public class WallEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        var script = (Wall)target;
        if (GUILayout.Button("DefaultColor"))
            script.SetDefaultColor();
    }
}
