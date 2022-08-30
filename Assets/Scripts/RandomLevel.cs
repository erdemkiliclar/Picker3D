using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLevel : MonoBehaviour
{
    [SerializeField] GameObject _otherLevel;
    GameObject _player, _endPlane,_main;
    NextLevel _nextLevel;
    public int levelIndex;


    private void Awake()
    {
        _nextLevel = new NextLevel();
    }

    GameObject[] _levels = new GameObject[10];
    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
    public GameObject Level4;
    public GameObject Level5;
    public GameObject Level6;
    public GameObject Level7;
    public GameObject Level8;
    public GameObject Level9;
    public GameObject Level10;

    private void Update()
    {
        
        _endPlane = GameObject.Find("EndPlane");
    }
    public void Start()
    {
        _main = GameObject.Find("Main");
        _player = GameObject.Find("Player");

    }

    public void LevelInstantiate()
    {

        _levels[0] = Level1;
        _levels[1] = Level2;
        _levels[2] = Level3;
        _levels[3] = Level4;
        _levels[4] = Level5;
        _levels[5] = Level6;
        _levels[6] = Level7;
        _levels[7] = Level8;
        _levels[8] = Level9;
        _levels[9] = Level10;

        levelIndex = Random.Range(0, 9);

        Instantiate(_levels[levelIndex], new Vector3(0, 0, _endPlane.transform.position.z + 15), transform.rotation);
        
    }

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {

            if (_main.GetComponent<NextLevel>()._level>=10)
            {
                LevelInstantiate();
            }
            else
            {
                Instantiate(_otherLevel, new Vector3(0, 0, _endPlane.transform.position.z + 15), transform.rotation);
                
                
            }

        }
    }
    
}



