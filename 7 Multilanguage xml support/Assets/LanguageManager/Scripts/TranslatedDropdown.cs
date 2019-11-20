using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// This class will allow us to have a "DropDown" totally translated.
/// For the dropdown was not possible to have a class like "TranslatedText.cs", because it works with Options and not present textes.
/// This class allow us to have a dropdown with any lenght you want
/// </summary>
public class TranslatedDropdown : MonoBehaviour
{
    //We check if the dropdown is updated or not
    public bool updated = false;

    private LanguageManager lang;
    List<string> Keys = new List<string>();

    //This list will contain the Translated Textes of the keys that we've inserted in the editor
    public List<Dropdown.OptionData> TranslatedKeys;

    private Dropdown Dropdown;

    // Use this for initialization
    void Awake()
    {
        lang = GameObject.FindWithTag("LanguageManager").GetComponent<LanguageManager>();
        Dropdown = GetComponent<Dropdown>(); //then we get a reference to the dropdown element
        GetKeys();
    }
        void OnEnable()
    {

        
        //Like always, at the start we update the dropdown
        if (lang != null && lang.langReader != null)
            UpdateDropDown();
    }

    void Update()
    {
        //We check if we should update the dropdown
        if (lang != null && lang.langReader != null)
            if (lang.langReader.update && !updated)
                UpdateDropDown();


        //We check if we've updated the dropdown and should reset the "update" state
        if (lang != null && lang.langReader != null)
            if (updated && lang.langReader.update)
                updated = false;
    }

    /// <summary>
    /// This function will update the dropdown by adding the result of the keys that we've inserted in the "TranslatedKeys" list
    /// </summary>
    /// 

    void GetKeys() {

      
       
        for (int i = 0; i < Dropdown.options.Count; i++)
        {
            Keys.Add(Dropdown.options[i].text);

        }

    }
    void UpdateDropDown()
    {
      
        TranslatedKeys.Clear(); //Firstly we remove every translated text

        //Secondly we translate everything we've inserted and put them in the TranslatedKeys list
       // for (int i = 0; i < Keys.Count; i++)
        for (int i = 0; i < Dropdown.options.Count; i++)
        {
            //TranslatedKeys.Add(lang.langReader.getString(Keys[i]));


            if (Dropdown.options[i].image == null)
            {
                print(lang.langReader);
                TranslatedKeys.Add(new Dropdown.OptionData(lang.langReader.getString(Keys[i])));
                // TranslatedKeys.Add(new Dropdown.OptionData(i+""));
            }
            else
            {
                TranslatedKeys.Add(new Dropdown.OptionData(lang.langReader.getString(Keys[i]), Dropdown.options[i].image));

            }
        }

   

        Dropdown.ClearOptions(); //we remove all the previous options

        Dropdown.AddOptions(TranslatedKeys); //we add the new options
        
        updated = true; //we set the update state to true

    }

}
