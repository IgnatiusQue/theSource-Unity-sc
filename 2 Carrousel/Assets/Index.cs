using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diapositiva {
    public string tit;
    public string desc;
    public Sprite foto;


    //Constructor
    public Diapositiva(string _tit,string _desc, string _foto) {
        tit = _tit;
        desc = _desc;
        foto = Resources.Load<Sprite>(_foto); 


    }
}

public class Index : MonoBehaviour {
    public Text title;
    public Text description;
    public Image image;
    // Use this for initialization
    public List<Diapositiva> Diapositivas = new List<Diapositiva>();
    public int currentPosition = 0;
	void Start () {


 Diapositivas.Add(new Diapositiva("Everest", "Everest description", "Images/Everest"));
 Diapositivas.Add(new Diapositiva("K2", "K2 description", "Images/K2"));
 Diapositivas.Add(new Diapositiva("Kangchenjunga", "Kangchenjunga description", "Images/Kangchenjunga"));
 Diapositivas.Add(new Diapositiva("Lhotse", "Lhotse description", "Images/Lhotse"));


        title.text = Diapositivas[0].tit;
        description.text = Diapositivas[0].desc;
        image.sprite = Diapositivas[0].foto;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            if (currentPosition == 0) { return;   }
            currentPosition--;
            title.text = Diapositivas[currentPosition].tit;
            description.text = Diapositivas[currentPosition].desc;
            image.sprite = Diapositivas[currentPosition].foto;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))   {
            if (currentPosition == Diapositivas.Count-1) { return; }
            currentPosition++;
            title.text = Diapositivas[currentPosition].tit;
            description.text = Diapositivas[currentPosition].desc;
            image.sprite = Diapositivas[currentPosition].foto;
        }
    }
}
