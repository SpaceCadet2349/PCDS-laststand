using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NameHandler : MonoBehaviour
{
    public Text NameInput;
    public Text NameOutput;
    public void CreateName()
    {
        PlayerPrefs.SetString("SavedName", NameInput.text.ToString());
        NameOutput.text = PlayerPrefs.GetString("SavedName");
        
    }


}
