using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScripts : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _restartPanel;
   public void RestartButton()
    {
        
        Time.timeScale = 1;
        _restartPanel.SetActive(false);
    }
}
