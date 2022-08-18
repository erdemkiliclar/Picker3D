using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform _player;
    Vector3 offset;

    private void Start()
    {
        offset = transform.position - _player.position;

    }

    private void Update()
    {
        Vector3 targetPos = _player.position + offset;
        targetPos.x = 0;
        transform.position = targetPos;
    }
}
