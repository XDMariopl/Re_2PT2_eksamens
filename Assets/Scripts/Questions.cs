using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
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
                objectScript.tryAgainButton.SetActive(true);
                i=objectScript.WrongToggle.Length;
                wrong = true;
                if (StaticVariables.firstTry[StaticVariables.firstTryIndex] == true)
                {
                    StaticVariables.firstTryIndex++;
                    StaticVariables.firstTry[StaticVariables.firstTryIndex] = false;
                }
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
                StaticVariables.firstTryIndex++;
            }
            else
            {
                objectScript.WrongPanel.SetActive(true);
                objectScript.WrongGroup.SetActive(true);
                objectScript.tryAgainButton.SetActive(true);
                if (StaticVariables.firstTry[StaticVariables.firstTryIndex] == true)
                {
                    StaticVariables.firstTryIndex++;
                    StaticVariables.firstTry[StaticVariables.firstTryIndex] = false;
                }
            }
        }
    }
}
