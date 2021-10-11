using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.0f;
    public float distance = 0.0f;
    public float time = 0.0f;
    void Start()
    {
        speed = distance / time;
        print("you are traveling at " + speed + "MPH");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
