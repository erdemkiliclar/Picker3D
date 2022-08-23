using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartUI : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitApp()
    {
        Application.Quit();
    }
    public void OpenLinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/ozgurbosnali/");
    }
}
