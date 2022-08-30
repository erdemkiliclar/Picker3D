using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
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
            
            _player.GetComponent<Transform>().rotation = new Quaternion(0, 0, 0,0);
            _player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
            _player.GetComponent<Movement>().enabled = true;
            _player.GetComponent<PlayerMove>()._playerSpeed = 7;

            


        }
    }
}
