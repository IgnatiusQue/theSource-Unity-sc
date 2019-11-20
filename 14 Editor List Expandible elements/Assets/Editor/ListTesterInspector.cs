using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ListTester))]
public class ListTesterInspector : Editor {

	public override void OnInspectorGUI () {
		serializedObject.Update();


        EditorList.Show(serializedObject.FindProperty("anim"), new EditorList.Options(true));

		 
		serializedObject.ApplyModifiedProperties();
	}
}
