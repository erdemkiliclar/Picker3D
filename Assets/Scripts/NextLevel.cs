using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NextLevel : MonoBehaviour
{
    GameObject _player, _panel;
    [SerializeField] TextMeshProUGUI _levelText;
    public int _level;


    private void Awake()
    {
        
        _level = PlayerPrefs.GetInt("Level", _level);
    }

    private void Start()
    {
        _player = GameObject.Find("Player");
        _panel = GameObject.Find("Panel");
    }

   

    public void NextLevelButton()
    {
        _level = _level + 1;
        _levelText.text = "LEVEL" + _level.ToString();
        _player.GetComponent<PlayerMove>()._playerSpeed = 1.6f;
        _panel.transform.GetChild(0).gameObject.SetActive(false);
        PlayerPrefs.SetInt("Level", _level);
    }
}
