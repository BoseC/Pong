using UnityEngine;
using System.Collections;
using System;

public class PlayerControl : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed = 5f;

    void movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0f, speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0f, -speed);

        }
        else
            rb.velocity = new Vector2(0f, 0f);
    }

    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }
}
