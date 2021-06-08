using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedbackController : MonoBehaviour
{
    public Text VsText;
    public Text ResponseText;
    
    public void LoadVsText(string writer)
    {
        VsText.text = writer;
    }

    public void LoadResponseText(string writer)
    {
        ResponseText.text = writer;
    }

    public void ClearText()
    {
        VsText.text = "";
        ResponseText.text = "";
    }
    

}
