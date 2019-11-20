using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(XUIAnimationData))]
public class ColorPointDrawer : PropertyDrawer {

	public override float GetPropertyHeight (SerializedProperty property, GUIContent label) {
        //return label != GUIContent.none && Screen.width < 333 ? (16f + 18f + 18f) : 16f;
        //  return   16f + 18f + 18f+ 18f;
        return property.FindPropertyRelative("EditorElementExpanded").boolValue ? 18f + 18f + 18f + 18f : 18f;
          return   16f + 18f + 18f+ 18f;

    }
 

    public override void OnGUI (Rect position, SerializedProperty property, GUIContent label) {



        int oldIndentLevel = EditorGUI.indentLevel;
         
       

        label = EditorGUI.BeginProperty(position, label, property);

		Rect contentRect = EditorGUI.PrefixLabel(position, label);


        if (!property.FindPropertyRelative("EditorElementExpanded").boolValue) {
            EditorGUI.EndProperty();
            EditorGUI.indentLevel = oldIndentLevel;
            return;
        }


        position.height = 16f;
			EditorGUI.indentLevel += 1;
			contentRect = EditorGUI.IndentedRect(position);
			contentRect.y += 18f;
     

        EditorGUI.indentLevel = 0;

       // Rect r = EditorGUI.IndentedRect(position);
         

        contentRect.width = EditorGUI.IndentedRect(position).width / 2;

        EditorGUIUtility.labelWidth = contentRect.width / 2;
        EditorGUI.PropertyField(contentRect, property.FindPropertyRelative("color2"), new GUIContent("St Color"));

        contentRect.x += contentRect.width;

        EditorGUIUtility.labelWidth = contentRect.width/2;
        EditorGUI.PropertyField(contentRect, property.FindPropertyRelative("color"), new GUIContent("Ed Color"));

  
        contentRect.x = EditorGUI.IndentedRect(position).x;
        contentRect.y += 18f; 
        EditorGUI.PropertyField(contentRect, property.FindPropertyRelative("EditorElementExpanded"), new GUIContent("Expanded"));
        /*
		contentPosition.width *= 0.75f;
		EditorGUI.indentLevel = 0;
		EditorGUI.PropertyField(contentPosition, property.FindPropertyRelative("position"), GUIContent.none);
		contentPosition.x += contentPosition.width;

		contentPosition.width /= 3f;
		EditorGUIUtility.labelWidth = 14f;
		EditorGUI.PropertyField(contentPosition, property.FindPropertyRelative("color"), new GUIContent("C"));



 
        contentPosition.y += 18f;
        EditorGUI.indentLevel = 0;
        EditorGUI.PropertyField(contentPosition, property.FindPropertyRelative("color2"), new GUIContent("K"));
        */

        EditorGUI.EndProperty();
		EditorGUI.indentLevel = oldIndentLevel;
	}
}