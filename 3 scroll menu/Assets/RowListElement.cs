using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RowListElement : MonoBehaviour {




    public Text myText;
    public Button myButton;


    private string data;
    //Construc
 /*   public RowListElement(string _data)
    {
        data = _data;
    }*/
    // Use this for initialization
   public void SetData (string data) {
        // acceso a otro script
        myButton.GetComponent<RowListButton>().SetText(" Row " + data);
        myText.text = "txt " + data;
    }
	
 
}
