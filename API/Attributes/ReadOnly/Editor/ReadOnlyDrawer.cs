using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(ReadOnlyAttribute), true)]
public class ReadOnlyDrawer : PropertyDrawer
{
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return base.GetPropertyHeight(property, label);
    }

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        GUI.enabled = (!Application.isPlaying) && ((ReadOnlyAttribute)attribute).isRunTimeOnly;
        EditorGUI.PropertyField(position, property, label, true);
        GUI.enabled = true;
    }
}
