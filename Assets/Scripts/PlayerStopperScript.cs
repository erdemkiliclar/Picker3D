using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStopperScript : MonoBehaviour
{
    [SerializeField] GameObject _player;  
    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _player.GetComponent<PlayerMove>()._playerSpeed = 0;    
        }
    }    
}
