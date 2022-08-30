using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NextLevelStopper : MonoBehaviour
{
    [SerializeField] GameObject _player;
    GameObject _panel;
    
    private void Start()
    {
        _player = GameObject.Find("Player");
        _panel = GameObject.Find("Panel");
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _player.GetComponent<PlayerMove>()._playerSpeed = 0;
            _panel.transform.GetChild(0).gameObject.SetActive(true);
        }
    }  
}
