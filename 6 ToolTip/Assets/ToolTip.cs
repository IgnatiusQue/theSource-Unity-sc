using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 

public class ToolTip : MonoBehaviour
{

    private static ToolTip instance;
 

   
    private Text tooltipText;
    private RectTransform backgroundRectTransform;

    private void Awake()
    {
         
        backgroundRectTransform = transform.Find("Background").GetComponent<RectTransform>();
        tooltipText = transform.Find("Text").GetComponent<Text>();

        HideTooltip();




    }

    private void Update()
    {
     
     
 transform.position = Input.mousePosition;

    }

    public void ShowTooltip(string tooltipString)
    {
         
        
        //    yield return new WaitForSeconds(1);

            // Code to execute after the delay
        
        tooltipText.text = tooltipString;
        float textPaddingSize = 4f;
        Vector2 backgroundSize = new Vector2(tooltipText.preferredWidth + textPaddingSize * 2f, tooltipText.preferredHeight + textPaddingSize * 2f);
        backgroundRectTransform.sizeDelta = backgroundSize;
        Update();
        gameObject.SetActive(true);
    }

    public void HideTooltip()
    {
        gameObject.SetActive(false);
    }

    

}
