using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popupSpawn : MonoBehaviour
{
    public GameObject popup;
    public popupDestroy destroy;
    public Boolean isOpen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    public void Open() //open the application
    {
        //check if the popup is already open
        if(isOpen == true) //yes
        {
            //do not open another tab
        }

        else //no
        {
            GameObject newPopup = Instantiate(popup); //create popup
            destroy = newPopup.GetComponent<popupDestroy>(); //get a component from the destroy script to allow for this script to also destroy
            isOpen = true; //ensure the same popup can't be opened again
        }
        

    }

    public void Close() //close the application
    {
        destroy.closePressed = true; //reference variable in destroy script
        isOpen = false; //allows for popup to be opened again
    }
}
