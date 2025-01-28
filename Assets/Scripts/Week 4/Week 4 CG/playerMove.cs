using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{

    public Transform pirateTransform;
    Vector2 piratePosition;
    Vector2 movement;
    float speed = 0.03f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //attempt 3: getAxis to check for keypress in movement variable, then translate by movement variable times speed
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        pirateTransform.Translate(movement * speed);


        //attempt 2: getAxis to check for keypress, then manually adding speed times movement direction to each component
        /*if(movement.x != 0)
        {
            piratePosition.x += (movement.x * speed);
            pirateTransform.Translate(piratePosition.x, 0, 0);
        }

        if(movement.y != 0)
        {
            piratePosition.y += (movement.y * speed);
            pirateTransform.Translate(0, piratePosition.y, 0);
        }*/


        //attempt 1: manually check for keypresses, then manually add speed and translate
        /*if (Input.GetAxis("Horizontal") > 0)
        {
            piratePosition.x += speed;
            pirateTransform.Translate(piratePosition.x, piratePosition.y, 0);
        }

        else if(Input.GetAxis("Horizontal") < 0)
        {
            piratePosition.x -= speed;
            pirateTransform.Translate(piratePosition.x, piratePosition.y, 0);
        }

        else if(Input.GetAxis("Vertical") > 0)
        {
            piratePosition.y += speed;
            pirateTransform.Translate(piratePosition.x, piratePosition.y, 0);
        } 

        else if(Input.GetAxis("Vertical") < 0)
        {
            piratePosition.y -= speed;
            pirateTransform.Translate(piratePosition.x, piratePosition.y, 0);
        }*/


    }
}
