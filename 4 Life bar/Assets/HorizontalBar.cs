using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HorizontalBar : MonoBehaviour {
    public Image Shape;
    private float value;
     private float maxValue;

	// Use this for initialization
	void Start () {
        //SetData(8, 10);
    }

    public void SetData(float _value, float _maxValue)
    {
        maxValue = _maxValue;
        value = _value;
        value = Mathf.Clamp(value, 0f, maxValue);
        Shape.transform.localScale = new Vector2(value / maxValue, 1);
    }
      

}
