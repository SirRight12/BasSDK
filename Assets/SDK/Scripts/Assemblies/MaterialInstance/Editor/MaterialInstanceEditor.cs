using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace ThunderRoad
{
    [CustomEditor(typeof(MaterialInstance))]
    public class MaterialInstanceEditor : Editor
    {
        SerializedProperty isInstanced;
        SerializedProperty defaultMaterials;
        SerializedProperty instanceMaterials;

        private void OnEnable()
        {
            isInstanced = serializedObject.FindProperty("isInstanced");
            defaultMaterials = serializedObject.FindProperty("defaultMaterials");
            instanceMaterials = serializedObject.FindProperty("instanceMaterials");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            DrawPropertiesExcluding(serializedObject);
            EditorGUI.BeginDisabledGroup(true);
            EditorGUILayout.PropertyField(isInstanced);
            EditorGUILayout.PropertyField(defaultMaterials, true);
            EditorGUILayout.PropertyField(instanceMaterials, true);
            EditorGUI.EndDisabledGroup();
            serializedObject.ApplyModifiedProperties();
            
            var obj = target as MaterialInstance;
            if (GUILayout.Button("AcquireMaterials")) obj.AcquireMaterials();
            if (GUILayout.Button("RestoreRenderer")) obj.RestoreRenderer();
        }
    }
}
