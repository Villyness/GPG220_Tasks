using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MacGuffinLocations))]
public class MacGuffinLocationEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        MacGuffinLocations ItemLocations = (MacGuffinLocations)target;

        ItemLocations.Location = EditorGUILayout.TextField("Location", ItemLocations.Location);
        EditorGUILayout.LabelField("Element", ItemLocations.Element);
        if (GUILayout.Button("Spawn Object"))
        {
            ItemLocations.SpawnObject();
        }
    }
}
