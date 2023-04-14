using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieControl : MonoBehaviour
{
    public float xVelocity =10f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var yVelocity =rb.velocity.y;
        rb.velocity=new Vector2(0,yVelocity);
        if (Input.GetKey(KeyCode.RightArrow))
        rb.velocity =new Vector2 (5, yVelocity);
        if (Input.GetKey(KeyCode.LeftArrow))
        rb.velocity =new Vector2 (-5, yVelocity);
    }

    
}

