using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectorScript : MonoBehaviour
{
    [SerializeField] TextMeshPro _objectText;
    [SerializeField] GameObject _player, _stopper;
    [SerializeField] Animator _collectorPlane,_gate;
    [SerializeField] int _objectCount = 10;
    [SerializeField] bool _isRandomActive = false;
    float _estTime = 0;
    bool _timerIsRunning = false;
    int _collectedObject = 0;



    private void Start()
    {
        if (_isRandomActive)
        {
            _objectCount = Random.Range(10, 50);
        }
        _objectText.text = ( "0" + "/" + _objectCount);
        _player = GameObject.Find("Player");
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Object"))
        {
            _collectedObject += 1;
            _objectText.text = (_collectedObject + "/" + _objectCount);
            _timerIsRunning = true;
        }
    }

    private void Update()
    {
        GoOrStay();
        if (_timerIsRunning)
        {
            _estTime += Time.deltaTime;
        }
    }

    void GoOrStay()
    {
        if (_collectedObject >= _objectCount)
        {
            _estTime = 0;
            StartCoroutine(Cont());
        }
        if (_collectedObject < _objectCount && _estTime > 5)
        {
            Debug.Log("Stop Çalıştı");
            StartCoroutine(Stop());
        }
    }

    IEnumerator Cont()
    {
        yield return new WaitForSeconds(3);
        _collectorPlane.Play("CollectorPlane");
        _gate.Play("Gate");
        _player.GetComponent<PlayerMove>()._playerSpeed = 1.6f;
        _stopper.GetComponent<BoxCollider>().enabled = false;
        _collectedObject = 0;
        _estTime = 0;
        _timerIsRunning = false;

        yield return new WaitForSeconds(2);
        _stopper.GetComponent<BoxCollider>().enabled = true;
        
        Destroy(this.gameObject); 
    }

    IEnumerator Stop()
    {
        yield return new WaitForSeconds(1);
        Time.timeScale = 0;
    }
}
