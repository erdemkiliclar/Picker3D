using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStopperScript : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _gamePlatform;
    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _player.GetComponent<PlayerMove>()._playerSpeed = 0;
            StartCoroutine(DestroyPlatform());
        }
    }    
    IEnumerator DestroyPlatform()
    {
        yield return new WaitForSeconds(8);
        Destroy(_gamePlatform);
    }
}
