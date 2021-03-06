using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatManager : MonoBehaviour
{
    public GameObject talkPanel;
    public Text dialogText;
    public bool isAction;
    public void Action()
    {
        if(isAction) { // Exit dialog
            isAction = false;
            Time.timeScale = 1;  
        }
        else { // Enter dialog
            isAction = true;
            dialogText.text = "Hi";
            Time.timeScale = 0;
        }
        talkPanel.SetActive(isAction);
    }
}
