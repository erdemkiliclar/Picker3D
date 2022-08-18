using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] Rigidbody _player;
    public float _playerSpeed = 1f;
    [SerializeField] float _playerHorizontalSpeed = 1f;
    float _horizontalInput;
    private void FixedUpdate()
    {
        PlayerMovement();
    }
    private void Update()
    {
        PlayerHorizontalMovement();
    }
    public void PlayerMovement()
    {
        Vector3 forwardMove = transform.forward * _playerSpeed * Time.deltaTime;
        Vector3 horizontalMove = transform.right * _horizontalInput * _playerHorizontalSpeed * Time.deltaTime;
        _player.MovePosition(_player.position + forwardMove + horizontalMove);
    }
    public void PlayerHorizontalMovement()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
    }
}
