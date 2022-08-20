using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPlatformRamp : MonoBehaviour
{
    [SerializeField] GameObject _player;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            _player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX;
            _player.GetComponent<PlayerMove>()._playerSpeed = 7;

        }
    }
}
