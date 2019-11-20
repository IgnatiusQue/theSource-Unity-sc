using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
  public  void Say(string str)
    {
        print(str);
    }


    public void GetParamsData()
    {


        Button button = GameObject.Find("Canvas/Button").GetComponent<Button>();


        SerializedObject so = new SerializedObject(button);
        SerializedProperty persistentCalls = so.FindProperty("m_OnClick.m_PersistentCalls.m_Calls");



        for (int i = 0; i < persistentCalls.arraySize; ++i)
        {  
            print("Target CS: " + button.onClick.GetPersistentTarget(i).name);
        print("Method name: " + button.onClick.GetPersistentMethodName(i));
        print("Method Param: " + persistentCalls.GetArrayElementAtIndex(i).FindPropertyRelative("m_Arguments.m_StringArgument").stringValue);
         }
    }

}
