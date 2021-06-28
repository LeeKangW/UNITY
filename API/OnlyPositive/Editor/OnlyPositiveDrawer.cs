using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(OnlyPositiveAttribute),true)]
public class OnlyPositiveDrawer : PropertyDrawer
{
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return base.GetPropertyHeight(property, label);
    }
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        bool OnlyPositive = ((OnlyPositiveAttribute)attribute).isPositive;

        if(property.propertyType == SerializedPropertyType.Integer)
        {
            property.intValue = OnlyPositive ? (property.intValue <= 0 ? 0 : property.intValue) : (property.intValue >=0 ? 0 : property.intValue);
            EditorGUI.PropertyField(position, property, label, true);
        }
        else if(property.propertyType == SerializedPropertyType.Float)
        {
            property.floatValue = OnlyPositive ? (property.floatValue <= 0 ? 0 : property.floatValue) : (property.floatValue >= 0 ? 0 : property.floatValue);
            EditorGUI.PropertyField(position, property, label, true);
        }
        else
        {
            EditorGUI.PropertyField(position, property, label, true);
        }
    }
}
