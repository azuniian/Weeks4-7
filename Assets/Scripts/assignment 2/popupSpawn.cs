using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class popupSpawn : MonoBehaviour
{
    public GameObject popup;
    public popupDestroy destroy;
    public Boolean isOpen;
    public float destroyCountdown = 0;
    public Canvas clippyUI; //canvas holding the text

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        //timer-based destroy, without any visual slider aspects
        //check if a popup is open
        if (isOpen == true) //yes
        {
            clippyUI.enabled = true;
            destroyCountdown += Time.deltaTime; //counting up every frame

            //check where countdown is at
            if (destroyCountdown >= 7) //when the countdown reaches 7
            {
                Close(); //run the close function
                isOpen = false; //allows for popup to be opened again
            }
        }
    }

    public void Open() //open the application
    {
        //check if the popup is already open

        if(isOpen == false)  //no, so open one
        { 
            //background of popup
            GameObject newPopup = Instantiate(popup); //create popup
            destroy = newPopup.GetComponent<popupDestroy>(); //get a component from the popup destroy script to allow for this script to also destroy

            isOpen = true; //ensure the same popup can't be opened again
        }
        

    }

    public void Close() //close the application
    {
        destroy.closePressed = true; //change variable value in popup destroy script
        clippyUI.enabled = false;
        destroyCountdown = 0;
    }
}
