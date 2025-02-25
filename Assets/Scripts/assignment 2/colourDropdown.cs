using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class colourDropdown : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public SpriteRenderer background;
    public Image previewColour;
    public Boolean savePressed;

    // Start is called before the first frame update
    void Start()
    {
        background = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void colourChange(int listIndex)
    {
        if (listIndex == 0)
        {
            if(savePressed == true)
            {
                background.color = new Color(0.05098039f, 0.5058824f, 0.5019608f);
                savePressed = false;
            }
            previewColour.color = new Color(0.05098039f, 0.5058824f, 0.5019608f);
        }

        else if (listIndex == 1)
        {
            if(savePressed == true)
            {
                background.color = new Color(0.455263f, 0.36076f, 0.6320754f);
                savePressed = false;
            }
            previewColour.color = new Color(0.455263f, 0.36076f, 0.6320754f);
        }

        else if(listIndex == 2)
        {
            if(savePressed == true)
            {
                background.color = new Color(0.250445f, 0.6461223f, 0.7924528f);
                savePressed = false;
            }
            previewColour.color = new Color(0.250445f, 0.6461223f, 0.7924528f);
        }

        else if(listIndex == 3)
        {
            if(savePressed == true)
            {
                background.color = new Color(255, 255, 255);
                savePressed = false;
            }
            previewColour.color = new Color(255, 255, 255);
        }

        else if(listIndex == 4)
        {
            if (savePressed == true)
            {
                background.color = new Color(0, 0, 0);
                savePressed = false;
            }
            previewColour.color = new Color(0, 0, 0);
        }

        else
        {
            background.color = new Color(0.05098039f, 0.5058824f, 0.5019608f);
            previewColour.color = new Color(0.05098039f, 0.5058824f, 0.5019608f);
        }
       
    }
}
