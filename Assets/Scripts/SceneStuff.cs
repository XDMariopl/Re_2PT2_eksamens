using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStuff : MonoBehaviour
{
    public ObjectScript objectScript;
    public string NextScene;
    public string CurrentScene;

    void Start()
    {
         
    }

    public void howToPlay(bool variable)
    {
        objectScript.howToPanel.SetActive(variable);
        objectScript.howToPlayGroup.SetActive(variable);
    }

    public void toNextScene()
    {
        SceneManager.LoadScene(NextScene, LoadSceneMode.Single);
    }

    public void StartScene(bool variable)
    {
        if(StaticVariables.ReadTutorial==false) 
        {
            objectScript.TutorialPanel.SetActive(variable);
            objectScript.TutorialGroup.SetActive(variable);
            StaticVariables.ReadTutorial = true;
        }
        else
        {
            SceneManager.LoadScene(NextScene, LoadSceneMode.Single);
        }
    }

    public void exit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        for(int i = 0; i < StaticVariables.firstTry.Length; i++)
        {
            StaticVariables.firstTry[i] = true;
        }
        SceneManager.LoadScene("Start_scene",LoadSceneMode.Single);
    }

    public void Reaload_Scene()
    {
        SceneManager.LoadScene(CurrentScene);
    }
}

