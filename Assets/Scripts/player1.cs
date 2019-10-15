using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player1 : MonoBehaviour
{
    Rigidbody2D rigidPlayer;
    public float speed = 8.0f;

    void Start()
    {
        
    }


    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal1");
        float y = Input.GetAxisRaw("Vertical1");
        Vector2 dir = new Vector2(x, y).normalized;
        GetComponent<Rigidbody2D>().velocity = dir * speed;
    }
}
