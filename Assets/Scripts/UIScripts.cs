using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScripts : MonoBehaviour
{
    
    [SerializeField] Text _levelText;
    [SerializeField] GameObject _restartPanel;
    [SerializeField] GameObject _levelPickPanel;
    [SerializeField] GameObject _levelImage;
    [SerializeField] GameObject _joystick;

    int _level ;
    string currentScene;
    string spliced;
    int levelNumber;

    private void Awake()
    {
        PlayerPrefs.SetInt("Level", _level);
    }

    private void Update()
    {
        
    }
    public void RestartButton()
    {
        Time.timeScale = 1;
        _restartPanel.SetActive(false);
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
    public void NextLevelButton()
    {
        if (levelNumber <= 10)
        {
            currentScene = SceneManager.GetActiveScene().name;
            spliced = currentScene.Substring(currentScene.Length - 1, 1);
            levelNumber = int.Parse(spliced) + 1;

            SceneManager.LoadScene("Picker3D-Level" + levelNumber.ToString());
            Time.timeScale = 1;
            _levelText.text = "Level - " + levelNumber;
        }
        else
        {
            levelNumber = Random.Range(1, 10);
            NextLevelButton();
        }
        
    }


    public void OpenLevelPickScreen()
    {
        Time.timeScale = 0;
        _levelImage.SetActive(false);
        _joystick.SetActive(false);
        _levelPickPanel.SetActive(true);
    }
    public void CloseLevelPickScreen()
    {
        Time.timeScale = 1;
        _levelImage.SetActive(true);
        _joystick.SetActive(true);
        _levelPickPanel.SetActive(false);
    }
    public void SelectLevel1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
        _levelText.text = "Level -"+ spliced ;
    } 
    public void SelectLevel2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
        _levelText.text = "Level -"+ spliced;
    } 
    public void SelectLevel3()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(3);
        _levelText.text = "Level - 3";
    }
    public void SelectLevel4()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(4);
        _levelText.text = "Level - 4";
    }
    public void SelectLevel5()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(5);
        _levelText.text = "Level - 5";
    }
    public void SelectLevel6()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(6);
        _levelText.text = "Level - 6";
    }
    public void SelectLevel7()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(7);
        _levelText.text = "Level - 7";
    }
    public void SelectLevel8()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(8);
        _levelText.text = "Level - 8";
    }
    public void SelectLevel9()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(9);
        _levelText.text = "Level - 9";
    }
    public void SelectLevel10()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(10);
        _levelText.text = "Level - 10";
    }

}
