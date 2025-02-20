using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popupSpawn : MonoBehaviour
{
    public GameObject popup;
    public Boolean buttonOpen;
    public Boolean buttonClose;
    public popupDestroy destroy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonOpen == true)
        {
            Open();
            buttonOpen = false;
        }

        else if(buttonClose == true)
        {
            Close();
            buttonClose = false;
        }
    }

    void Open()
    {
        GameObject newPopup = Instantiate(popup);
        destroy = newPopup.GetComponent<popupDestroy>();

    }

    void Close()
    {
        destroy.closePressed = true;
    }
}
