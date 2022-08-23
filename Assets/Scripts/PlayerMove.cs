using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] Rigidbody _player;
    public float _playerSpeed = 1.6f;
    [SerializeField] float _playerHorizontalSpeed = 1;
    float _horizontalInput;
    [SerializeField] Joystick _joystick;

    [SerializeField] AudioSource _objectFX;
    [SerializeField] bool _isAudioOn;
    [SerializeField] GameObject _sourceOn, _sourceOff;

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
        
        _horizontalInput = _joystick.Horizontal;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Object") && _isAudioOn==true)
        {
            _objectFX.Play();
        }
    }

    public void SoundOn()
    {
        _sourceOn.SetActive(false);
        _sourceOff.SetActive(true);
        _isAudioOn = true;
    }
    public void SoundOff()
    {
        _sourceOn.SetActive(true);
        _sourceOff.SetActive(false);
        _isAudioOn = false;
    }
}
