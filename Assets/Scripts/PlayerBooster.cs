using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBooster : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] float _speed = 0.00001f;
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && _player.GetComponent<PlayerMove>()._playerSpeed == 0)
        {
            Debug.Log("Çalıştı");
            //gameObject.GetComponent<Rigidbody>().AddForce(this.transform.forward*Time.deltaTime*_speed); 

            
            
        }
    }


    //private void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    if (hit.gameObject.GetComponent<Rigidbody>() != null)
    //        hit.gameObject.GetComponent<Rigidbody>().AddForce(collision.transform.forward);
    //}

}
