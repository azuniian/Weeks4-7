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
        if(closePressed == true)
        {
            Destroy(gameObject);
            closePressed = false;
        }
    }
}
