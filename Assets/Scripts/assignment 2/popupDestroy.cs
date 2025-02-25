using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popupDestroy : MonoBehaviour
{
    public Boolean closePressed;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(closePressed == true) //check if spawner script says to close the popup
        {
            Destroy(gameObject); //destroy the popup prefab
            closePressed = false; //turn the boolean to false so it can be re-used
        }
    }
}
