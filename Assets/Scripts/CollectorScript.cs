using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectorScript : MonoBehaviour
{
    [SerializeField] TextMeshPro _objectText;
    [SerializeField] GameObject _player, _stopper;
    [SerializeField] Animator _collectorPlane,_gate;
    int _objectCount = 10;
    int _collectedObject = 0;
    private void Start()
    {
        _objectCount = Random.Range(10, 20);
        _objectText.text = ( "0" + "/" + _objectCount);   
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Object"))
        {
            _collectedObject += 1;
            _objectText.text = (_collectedObject + "/" + _objectCount);
        }
    }
    private void Update()
    {
        GoOrStay(); 
    }
    void GoOrStay()
    {
        if (_collectedObject >= _objectCount)
        {
            StartCoroutine(Cont());
        }
    }
    IEnumerator Cont()
    {
        yield return new WaitForSeconds(3);
        _collectorPlane.Play("CollectorPlane");
        _gate.Play("Gate");
        _player.GetComponent<PlayerMove>()._playerSpeed = 1;
        _stopper.GetComponent<BoxCollider>().enabled = false;
        _collectedObject = 0;
        yield return new WaitForSeconds(3);
        _stopper.GetComponent<BoxCollider>().enabled = true;
        //Destroy(_stopper.gameObject);
    }
}
