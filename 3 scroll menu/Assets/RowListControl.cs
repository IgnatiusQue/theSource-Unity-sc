using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RowListControl : MonoBehaviour
{

    [SerializeField]
    private GameObject RowTemplate;
    // Use this for initialization



    void Start()
    {
        print("Hello");
        for (int i = 0; i < 30; i++)
        {
            GameObject row = Instantiate(RowTemplate) as GameObject;
            row.SetActive(true);

          // GameObject  row.Find("rowButton0");
          // acceso a otro script
         
           row.GetComponent<RowListElement>().SetData(" Row number " + i);
            row.transform.SetParent(RowTemplate.transform.parent, false);
        }
    }

    // Update is called once per frame
    public void ButtonClicked(string myTextString)
    {
        print(myTextString);
    }
}
