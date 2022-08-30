using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] Rigidbody _player;
    public float _playerSpeed;



    

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
        transform.position += new Vector3(0, 0, _playerSpeed*Time.deltaTime);
    }





    public void PlayerHorizontalMovement()
    {
        

       
    }
    

}
