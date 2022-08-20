using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBooster : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] float _speed = 250;
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Object") && _player.GetComponent<PlayerMove>()._playerSpeed == 0)
        {
            collision.gameObject.GetComponent<Rigidbody>().mass = 0.5f;
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * Time.deltaTime * _speed);
        }  
    }
}
