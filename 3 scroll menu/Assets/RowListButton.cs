using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RowListButton : MonoBehaviour
{

    [SerializeField]
    private Text myText;


    [SerializeField]
    private RowListControl RowControl;

    private string data;
    // Use this for initialization
    public void SetText(string text)
    {
        myText.text = text;
        data = text;

    }


 public   void OnClick()
    {
     //   RowControl.ButtonClicked(ASimpleString);

        print("Click" +data);
       // print(ASimpleString);

    }
}
