using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] GameObject _playerEnd;

   

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("NextLevel"))
        {
            SavePlayer();
            Debug.Log("Trigger calisti");
        }
    }
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        Vector3 position;
        position.x = data._position[0];
        position.y = data._position[1];
        position.z = data._position[2];
        transform.position = position;
    }
}
