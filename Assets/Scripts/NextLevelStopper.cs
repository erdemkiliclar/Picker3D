using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextLevelStopper : MonoBehaviour
{
    [SerializeField] GameObject _nextLevelPanel;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            _nextLevelPanel.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
