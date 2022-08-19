﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectorScript : MonoBehaviour
{
    [SerializeField] TextMeshPro _objectText;
    [SerializeField] GameObject _player, _stopper,_restartPanel;
    [SerializeField] Animator _collectorPlane,_gate;

    public float _estTime = 0;
    public bool _timerIsRunning = false;

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
        _player.GetComponent<PlayerMove>()._playerSpeed = 1.2f;
        _stopper.GetComponent<BoxCollider>().enabled = false;
        _collectedObject = 0;
        _estTime = 0;
        _timerIsRunning = false;

        yield return new WaitForSeconds(3);
        _stopper.GetComponent<BoxCollider>().enabled = true;
        
    }

    IEnumerator Stop()
    {
        yield return new WaitForSeconds(1);
        _restartPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
