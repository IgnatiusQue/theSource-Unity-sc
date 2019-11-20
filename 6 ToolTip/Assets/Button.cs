using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

   public  GameObject tooltip;
    void Start()
    {

        

     //   tooltip = GameObject.Find("/Canvas/ToolTip").GetComponent<ToolTip>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
       
        tooltip.GetComponent<ToolTip>().ShowTooltip("Hello");

    }



    public void OnPointerExit(PointerEventData eventData)
    {
       // tooltip.HideTooltip();
        tooltip.SetActive(false);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
