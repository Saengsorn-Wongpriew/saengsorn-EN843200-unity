using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.0f;
    public float distance = 0.0f;
    public float time = 0.0f;
    void Start()
    {
        
    }

    void SpeedCheck()
    {
        speed = distance / time;
        if (speed > 70 || speed < 40)
        {
            print("You are breaking the law!");
        }
        print("you are traveling at " + speed + "MPH");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpeedCheck();
        }
    }
}
