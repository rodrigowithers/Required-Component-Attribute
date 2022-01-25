using UnityEditor;
using UnityEngine;

namespace RequiredFieldAttribute.Editor
{
    [CustomPropertyDrawer(typeof(RequiredField))]
    public class RequiredFieldPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            RequiredField requiredField = attribute as RequiredField;

            if (property.objectReferenceValue == null)
            {
                GUI.color = requiredField.Color;
                EditorGUI.PropertyField(position, property, label);
                GUI.color = Color.white;
            }
            else
            {
                EditorGUI.PropertyField(position, property, label);
            }
        }
    }
}