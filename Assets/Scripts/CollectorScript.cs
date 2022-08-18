using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectorScript : MonoBehaviour
{
    [SerializeField] TextMeshPro _objectText;

    int _objectCount = 10;
    int _collectedObject = 0;
    public int _goOrStay = 0;

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
        if (_collectedObject >= _objectCount)
        {
            _goOrStay = 1;
        }

        else 
        {
            _goOrStay = 0;
        }
        
    }
}
