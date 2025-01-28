using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class barrelUIActive : MonoBehaviour
{
    public GameObject barrelUI;
    public Boolean isClose;
    

    // Start is called before the first frame update
    void Start()
    {
        barrelUI.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
