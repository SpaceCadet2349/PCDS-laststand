using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHandler : MonoBehaviour
{
    public int DialougID = 1;
    Text UnConvertedString;
    public Text DisplayedText; 
    public void DisplayNextDiloug() 
    {
        switch (DialougID)
        {
            case 1:
                Debug.Log("Entered Dialoug ID swich and chose 1");
                //PlayerPrefs.SetString("CurrentDisplayedText", "Hello! Welcome to PC Dating Simulator! What do you want us to call you?");
                UnConvertedString.text = PlayerPrefs.GetString("CurrentDisplayedText");
                Debug.Log("set text to '");
                DisplayedText.text = "Hello! Welcome to PC Dating Simulator! What do you want us to call you?";
                break;
            default:
                PlayerPrefs.SetString("CurrentDisplayedText", "Punch the nearest programmer square in the nose, even if it's you.");
                break;

        }
    }

    void Update()
    {
        DisplayNextDiloug();
        //DisplayedText.text = UnConvertedString.text.ToString();
    }
}   
