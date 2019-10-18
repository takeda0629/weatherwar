using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player1 : MonoBehaviour
{
    Rigidbody2D rigidPlayer;
    [SerializeField] float speed = 8.0f;
    private Rigidbody2D rb;
    public bool isGround = false;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector2 velocity = rb.velocity;

        float x = Input.GetAxisRaw("Horizontal1");
        if(Input.GetButtonDown("Jump1") && isGround)
        {
            velocity.y = 10;
            isGround = false;
        }
       
        if(x != 0)
        {
            velocity.x = x * speed;
        }

        rb.velocity = velocity;


    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Floor") )
        {
            isGround = true;
           
        }
    }
}
