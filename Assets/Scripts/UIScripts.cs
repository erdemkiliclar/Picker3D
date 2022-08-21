using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScripts : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] Text _levelText;
    [SerializeField] GameObject _restartPanel;
    [SerializeField] GameObject _nextLevelPanel;
    int _lastLevel = 1;

    private void Awake()
    {
        PlayerPrefs.SetInt("Level", _lastLevel);
    }
    public void RestartButton()
    {
        
        Time.timeScale = 1;
        _restartPanel.SetActive(false);
        SceneManager.LoadScene(0);

    }

    public void NextLevelButton()
    {
        Time.timeScale = 1;
        _lastLevel++;
        PlayerPrefs.SetInt("Level", _lastLevel);
        _levelText.text = "Level - " + _lastLevel;
        _nextLevelPanel.SetActive(false);

    }
}
