using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player2 : MonoBehaviour
{
    Rigidbody2D rigidPlayer;
    public float speed = 8.0f;
    void Start()
    {
        
    }


    void Update()
    {
       
    }

    public void Move()
    {
        float x = Input.GetAxisRaw("Horizontal2");
        float y = Input.GetAxisRaw("Vertical2");
        Vector2 dir = new Vector2(x, y).normalized;
        GetComponent<Rigidbody2D>().velocity = dir * speed;
    }
}
