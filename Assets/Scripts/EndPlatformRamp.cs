using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPlatformRamp : MonoBehaviour
{
    [SerializeField] GameObject _player;

    private void Start()
    {
        _player = GameObject.Find("Player");
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {   
            _player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            _player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX;
            _player.GetComponent<Movement>().enabled = false;
            _player.GetComponent<PlayerMove>()._playerSpeed = 8;
        }
    }
}
