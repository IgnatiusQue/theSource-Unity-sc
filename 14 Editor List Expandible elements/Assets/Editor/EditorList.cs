using UnityEditor;
using UnityEngine;
using System;
using System.Collections.Generic;

public static class EditorList {




    //Create Button Controls 
    private static GUIContent
		minimizeButtonContent = new GUIContent("^", "Maximize / Minimize"),
		moveButtonContent = new GUIContent("\u21b4", "move down"),
		duplicateButtonContent = new GUIContent("+", "duplicate"),
		deleteButtonContent = new GUIContent("-", "delete"),
		addButtonContent = new GUIContent("+", "add element");

	private static GUILayoutOption miniButtonWidth = GUILayout.Width(20f);




    public static void Show(SerializedProperty list,  Options options)
    {
        if (false)
        {
            EditorGUILayout.HelpBox(list.name + " is neither an array nor a list!", MessageType.Error);
            return;
        }


    //    bool showListLabel = true;// (options & EditorListOption.ListLabel) != 0,
     //   bool showListSize = true; //(options & EditorListOption.ListSize) != 0;

       // if (showListLabel)
      //  {
            EditorGUILayout.PropertyField(list);
            EditorGUI.indentLevel += 1;
       // }
         if ( list.isExpanded)
        {
            SerializedProperty size = list.FindPropertyRelative("Array.size");
            
                EditorGUILayout.PropertyField(size); 
            ShowElements(list);
        } 
      
            EditorGUI.indentLevel -= 1;
         
    }


	private static void ShowElements (SerializedProperty list) {

     

		for (int i = 0; i < list.arraySize; i++) {
	//		if (showButtons) {
				EditorGUILayout.BeginHorizontal();
	//		}
	//		if (showElementLabels) {
				EditorGUILayout.PropertyField(list.GetArrayElementAtIndex(i));
		//	}
		//	else {
		//		EditorGUILayout.PropertyField(list.GetArrayElementAtIndex(i), GUIContent.none);
		//	}
		//	if (showButtons) {
				ShowButtons(list, i);
				EditorGUILayout.EndHorizontal();
		//	}
		}
		if ( list.arraySize == 0 && GUILayout.Button(addButtonContent, EditorStyles.miniButton)) {
			list.arraySize += 1;
		}
	}

	private static void ShowButtons (SerializedProperty list, int index) {
		if (GUILayout.Button(moveButtonContent, EditorStyles.miniButtonLeft, miniButtonWidth)) {
			list.MoveArrayElement(index, index + 1);
		}
		if (GUILayout.Button(duplicateButtonContent, EditorStyles.miniButtonMid, miniButtonWidth)) {
			list.InsertArrayElementAtIndex(index);
		}
		if (GUILayout.Button(deleteButtonContent, EditorStyles.miniButtonMid, miniButtonWidth)) {
			int oldSize = list.arraySize;
			list.DeleteArrayElementAtIndex(index);
			if (list.arraySize == oldSize) {
				list.DeleteArrayElementAtIndex(index);
			}
		}
        if (GUILayout.Button(minimizeButtonContent, EditorStyles.miniButtonRight, miniButtonWidth))
        {
         
             SerializedProperty p =list.GetArrayElementAtIndex(index).FindPropertyRelative("EditorElementExpanded");

            p.boolValue = !p.boolValue;
          //  Debug.Log(p.boolValue);
          //  Debug.Log(list.GetArrayElementAtIndex(index).FindPropertyRelative("expanded").boolValue);
          //   Debug.Log(list.GetArrayElementAtIndex(index).GetType().ToString());

        }
    }

  

    public class Options
    {
        bool Expanded = true;

        public Options(bool expanded)
        {
            Expanded = expanded;

        }
    }
}