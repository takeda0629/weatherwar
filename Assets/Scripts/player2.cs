using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player2 : MonoBehaviour
{
    Rigidbody2D rigidPlayer;
    public float speed = 8.0f;

    public enum playerNo
    {
        p1 = 1,
        p2 = 2,
        p3 = 3,
        p4 = 4
    }

    public playerNo playerno;
    void Start()
    {
       
    }


    void Update()
    {
        Debug.Log((int)playerno);
        float x = Input.GetAxisRaw("Horizontal" + (int)playerno);
        float y = Input.GetAxisRaw("Vertical" + (int)playerno);
        Vector2 dir = new Vector2(x, y).normalized;
        GetComponent<Rigidbody2D>().velocity = dir * speed;
    }
}
