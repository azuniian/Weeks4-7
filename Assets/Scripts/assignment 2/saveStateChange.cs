using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//was not able to properly connect this without the interaction between the save button and the dropdown being backwards, but I tried my best :P

public class saveStateChange : MonoBehaviour
{
    //public colourDropdown buttonPressed;
    //public GameObject background;
    public colourDropdown choiceIndex;
    public SpriteRenderer backgroundColour;

    // Start is called before the first frame update
    void Start()
    {
        //buttonPressed = background.GetComponent<colourDropdown>();
        choiceIndex = GetComponent<colourDropdown>();
        backgroundColour = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pressButton()
    {
        //buttonPressed.savePressed = true;
        choiceIndex.colourChange(choiceIndex.currentIndex);
    }
}
