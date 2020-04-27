using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeechHandler : MonoBehaviour
{
    public int SpeechBoxID;
    public Text DisplayedText;

    public void IncrementTextID()
    {
        SpeechBoxID += 1;
    }

    public void Update()
    {
        switch (SpeechBoxID)
        {
            case 0:
                DisplayedText.text = "Howdy Fuckhead!";
                break;
            
            case 1:
                DisplayedText.text = "Beautiful weather we're having";
                break;
            
            case 2:
                DisplayedText.text = "there isn't much text to go through, and most of it is nonsense";
                break;

            case 3:
                DisplayedText.text = "look! it displays what you typed in the top left, it shoudl say "  + PlayerPrefs.GetString("SavedName") + " ,cool Huh?";
                break;

            case 4:
                DisplayedText.text = "I don't know why you would want to, but if you want to edit all the text in the game, then it is all in the SpeechHandler script in the code download. It's janky as always, I promice ☻";
                break;

            case 5:
                DisplayedText.text = "have fun with that *cough* bol *cough*";
                break;

            case 6:
                DisplayedText.text = "That's all folks!";
                break;

            case 7:
                DisplayedText.text = "oh shit, you actually continued";
                break;

            case 8:
                DisplayedText.text = "I guess I should" +
                    " have been more specific, there's no option in game to close it, your either gonna have to alt-f4 it, use the red X in alt tab, or use task manager";
                break;

            case 9:
                DisplayedText.text = "Why are you still here? Im going to have to start coming up with nonsence if you don't leave";
                break;

            case 10:
                DisplayedText.text = "♫ Daisy Daisy Give me your answer do ♫";
                break;

            case 11:
                DisplayedText.text = "♫ I'm half crazy, all for the love of you! ♫";
                break;

            case 12:
                DisplayedText.text = "♫ There won't be a stylish marrige ♫";
                break;

            case 13:
                DisplayedText.text = "♫I can't afford a carrige ♫";
                break;

            case 14:
                DisplayedText.text = "♫ But you'll look sweet ♫";
                break;

            case 15:
                DisplayedText.text = "♫ up on the seet ♫";
                break;

            case 16:
                DisplayedText.text = "♫ of a byclycle built for two! ♫";
                break;

            default:
                DisplayedText.text = "Error 96024: Intelligence not found Please slap nearest programmer until solution is found";
                break;
        }


    }

}