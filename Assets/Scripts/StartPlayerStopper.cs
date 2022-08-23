using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlayerStopper : MonoBehaviour
{
    [SerializeField] GameObject _playerStartStopper;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(_playerStartStopper);
        }
    }
}
