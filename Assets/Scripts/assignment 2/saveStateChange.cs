using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveStateChange : MonoBehaviour
{
    colourDropdown saveValue;

    // Start is called before the first frame update
    void Start()
    {
        saveValue = GetComponent<colourDropdown>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pressButton()
    {
        saveValue.savePressed = true;
    }
}
