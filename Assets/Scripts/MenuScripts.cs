using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScripts : MonoBehaviour
{
    
    [SerializeField] GameObject _pausePanel, _gameOverPanel;

    


    public void Pause()
    {
        
        _pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        _pausePanel.SetActive(false);
        Time.timeScale = 1;
    }


    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        _gameOverPanel.SetActive(false);
        Time.timeScale = 1;
        
    }

    
    public void Restart()
    {
        SceneManager.LoadScene(0);
        _gameOverPanel.SetActive(false);
        Time.timeScale = 1;
    }


    public void Quit()
    {
        Application.Quit();
    }


}
