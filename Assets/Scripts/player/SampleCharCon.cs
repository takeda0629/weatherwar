using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleCharCon : MonoBehaviour
{
    [SerializeField] float speed = 8.0f;
    private Rigidbody2D rb;
    bool isGround = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector2 velocity = rb.velocity;

        float x = Input.GetAxisRaw("Horizontal1");
        float y = Input.GetAxisRaw("Vertical1");
        Vector2 dir = new Vector2(x, y).normalized;
        GetComponent<Rigidbody2D>().velocity = dir * speed;
        //if(Input.GetButtonDown("Jump1") && isGround)
        //{
        //    velocity.y = 10;
        //    isGround = false;
        //}

        //if(x != 0)
        //{
        //    velocity.x = x * speed;
        //}

        //rb.velocity = velocity;


    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Floor"))
        {
            isGround = true;

        }
    }
}
