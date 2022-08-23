using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextLevelStopper : MonoBehaviour
{
    [SerializeField] GameObject _nextLevelPanel;
    [SerializeField] GameObject _joystick;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            _joystick.SetActive(false);
            _nextLevelPanel.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
