using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CursorsExample : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Texture2D cursor;

 
        
        void Start()
    {

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
  
}
