using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Application : MonoBehaviour
{
    public PlayerPrefsControl playerPrefsControl;
    // Start is called before the first frame update
    void Start()
    {
        playerPrefsControl = GameObject.Find("PlayerPrefsManager").GetComponent<PlayerPrefsControl>();

        // Initializing the SecurePlayerPrefs
        playerPrefsControl.Init();

        // Setting a high score but encrypted ;)
        playerPrefsControl.SetInt("HIGH_SCORE", 1223);

        // Getting the highscore back.
        int highScore = playerPrefsControl.GetInt("HIGH_SCORE");
        print(highScore);
        // Just setting a string.
        playerPrefsControl.SetString("A key name", "This is so simple");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
