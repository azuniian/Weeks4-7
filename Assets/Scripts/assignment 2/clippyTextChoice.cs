using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using System;

public class clippyTextChoice : MonoBehaviour
{

    public int clicks = 0; //counter for how many times the button has been pressed
    public TextMeshProUGUI clippyTips; //reference to the text component
    string textClip; //what the text will say in the text component
    

    // Start is called before the first frame update
    void Start()
    {
        clicks = 0; //ensure the starting value is 0
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateText()
    {
        //check for number of clicks to determine text content
        if (clicks == 0) //first click
        {
            textClip = "Hi! I'm your new friend Clippy! How can I help you?"; //what the text will be
            clippyTips.text = textClip; //set the text component to equal the above text
            clicks++; //add one click
        }

        else if (clicks == 1) //second click
        {
            textClip = "Do you need some help?";
            clippyTips.text = textClip;
            clicks++;
        }

        else if (clicks == 2) //third click
        {
            textClip = "Why do you keep clicking me if you don't need help?";
            clippyTips.text = textClip;
            clicks++;
        }

        else if (clicks == 3) //fourth click
        {
            textClip = "Are you doing this to annoy me? Well fine!";
            clippyTips.text = textClip;
            clicks++;
        }

        else if (clicks >= 4)
        {
            textClip = "Hmph! I'm not helping you anymore.";
            clippyTips.text = textClip;
            clicks++;
        }
    }
}
