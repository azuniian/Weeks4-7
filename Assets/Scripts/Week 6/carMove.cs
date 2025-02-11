using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMove : MonoBehaviour
{
    
    public float speed = 0.005f;
    public Vector2 carPos;
    public float screenWidth;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 ScreenSize = new Vector2 (Screen.width, Screen.height);
        Vector2 ScreenSizeInWorld = new Vector2();
        ScreenSizeInWorld = Camera.main.ScreenToWorldPoint(ScreenSize);
        screenWidth = ScreenSizeInWorld.x;

        carPos.x = -12;
        int value = Random.Range(-3, 3);
        carPos.y = value;
        speed = Random.Range(0.005f, 0.025f);

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if(carPos.x > screenWidth)
        {
            carPos.x = -12;
        }

        carPos.x += speed;
        transform.position = carPos;
        
    }
}
