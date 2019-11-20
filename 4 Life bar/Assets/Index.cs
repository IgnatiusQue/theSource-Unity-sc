using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Index : MonoBehaviour {

    public GameObject BarTemplate;
    public GameObject Container;
    // Use this for initialization
    void Start () {



        for (int i = 0; i < 4; i++)
        {
            GameObject bar = Instantiate(BarTemplate) as GameObject;
            bar.SetActive(true);

          bar.GetComponent<HorizontalBar>().SetData(i,8);
           //bar.transform.SetParent(BarTemplate.transform.parent, false);
           bar.transform.SetParent(Container.transform, false);
        }


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
