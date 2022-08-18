using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStopperScript : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] Animator _collectorPlane;

    CollectorScript _collectorScript;
    

    private void Awake()
    {
        _collectorScript = new CollectorScript();
    }
    
    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _player.GetComponent<PlayerMove>().enabled = false;
            
        }
        else
        {
            Debug.Log("Çalıştı");
            //StartCoroutine(Cont());
        }
    }

    IEnumerator Cont()
    {
        yield return new WaitForSeconds(5);
        _collectorPlane.Play("CollectorPlane");
        _player.GetComponent<PlayerMove>().enabled = true;
        Destroy(this.gameObject);
    }
}
