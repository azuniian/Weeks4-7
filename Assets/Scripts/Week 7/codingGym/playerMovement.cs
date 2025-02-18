using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyrMovement : MonoBehaviour
{
    public Vector2 playerPos;
    public Transform positionChange;
    public Vector2 movement;
    public float speed = 0.05f;
    public float gravity = 0.075f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical") - gravity;

        playerPos = playerPos + movement;

        if (playerPos.y < -2.6)
        {
            movement.y = 0;
            playerPos.y = -2.6f;
        }

        positionChange.Translate(movement * speed);

    }
}
