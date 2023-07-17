using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class TextDisplay : MonoBehaviour

{   // UGUI makes it inside canvas
    public TextMeshProUGUI myText;
    public string outputString;
    public bool hasError = false;

    public void ClearText()
    {
        // emptys the output (holds the text that will then be displayed on the UI) string 
        outputString = "";
        // sets the text of the outputString 
        myText.text = outputString;

    }

    public void AddText(string stringToAdd)
    {
        // if there is an error, don't dispaly anything new
        if (hasError == true)
        {
            return;
        }
        // fills the the output string with stringToAdd
        outputString = stringToAdd;
        // sets the text of the outputString
        myText.text = outputString;

    }

    public void Problems()
    {
        // clears the UI Text 
        myText.text = "";
        // reports a console error 
        Debug.Log("There was an error");
        // has an error 
        hasError = true;
       

    }
}
