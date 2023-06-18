using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questions : MonoBehaviour {

    public ObjectScript objectScript;

    private int correct=0;
    private bool wrong = false;

    public void CheckCorrect()
    {
        for(int i = 0;i < objectScript.WrongToggle.Length; i++)
        {

            if (objectScript.WrongToggle[i].GetComponent<Toggle>().isOn == true)
            {
                objectScript.WrongPanel.SetActive(true);
                objectScript.WrongGroup.SetActive(true);
                objectScript.nextButton.SetActive(true);
                i=objectScript.WrongToggle.Length;
                wrong = true;
                StaticVariables.WrongQ++;
            }
        }

        if (wrong == false)
        {
            for( int i = 0;i<objectScript.CorrectToggle.Length;i++) 
            {
                if (objectScript.CorrectToggle[i].GetComponent<Toggle>().isOn == true)
                {
                    correct++;
                }
            }
            if (correct == objectScript.CorrectToggle.Length)
            {
                objectScript.AnswerGroup.SetActive(true);
                objectScript.AnswerPanel.SetActive(true);
                objectScript.nextButton.SetActive(true);
            }
            else
            {
                objectScript.WrongPanel.SetActive(true);
                objectScript.WrongGroup.SetActive(true);
                objectScript.nextButton.SetActive(true);
                StaticVariables.WrongQ++;
            }
        }
        StaticVariables.Q++;
    }
}
