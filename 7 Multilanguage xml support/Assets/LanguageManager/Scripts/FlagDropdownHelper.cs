using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Localization drop down example.
/// </summary>
public class FlagDropdownHelper : MonoBehaviour
{
    private LanguageManager languageManager;
    public Dropdown dropDown;

  

    public void OnChange(Dropdown change)
    {

       
        switch (change.value)
        {
            
            case 0: languageManager.SelectLanguage("en", languageManager.isLocal); break;
            case 1: languageManager.SelectLanguage("es", languageManager.isLocal); break;
            case 2: languageManager.SelectLanguage("it", languageManager.isLocal); break;
          
           


        }

    }

        void Start()
    {
        languageManager = GameObject.FindWithTag("LanguageManager").GetComponent<LanguageManager>();
        
    }



}
