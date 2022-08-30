using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    Rigidbody rigi;
    float Xaxis;
    float move_count = 0.66f;
    float lastlocation;
    void Start()
    {
        rigi = GetComponent<Rigidbody>();
        Application.targetFrameRate = 100;

        Xaxis = transform.position.x;
        lastlocation = Xaxis;
    }



    void Update()
    {



        if (Input.touchCount > 0)
        {


            Touch finger = Input.GetTouch(0);
            if (finger.deltaPosition.x > 7.0f)
            {
                lastlocation = transform.position.x + move_count;

            }
            else if (finger.deltaPosition.x < -7.0f)
            {
                lastlocation = transform.position.x - move_count;
            }

        }

        lastlocation = Mathf.Clamp(lastlocation, Xaxis - move_count, Xaxis + move_count);
        transform.position = Vector3.Lerp(transform.position, new Vector3(lastlocation, transform.position.y, transform.position.z), 1.5f * Time.deltaTime);

    }
}