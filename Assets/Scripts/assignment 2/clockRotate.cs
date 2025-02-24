using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockRotate : MonoBehaviour
{
    public float rotSpeed = 1f; //public variable for the clock hand rotation
    //set to 0.01 for hour hand, and 0.6 for minute hand to simulate similar time movement to real life

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -rotSpeed * Time.deltaTime); //rotates the center, which in turn rotates the hand due to parent/child properties
    }
}

