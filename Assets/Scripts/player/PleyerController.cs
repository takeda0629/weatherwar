using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PleyerController : MonoBehaviour
{

    [SerializeField] float speed = 8.0f;
    private Rigidbody2D rb;
    public bool isSelectFlag = false;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Move();
    }

    /// <summary>
    /// Player1の操作スクリプト
    /// </summary>
    void Move()
    {
        Vector2 velocity = rb.velocity;

        float x = Input.GetAxisRaw("Horizontal1");
        float y = Input.GetAxisRaw("Vertical1");
        Vector2 dir = new Vector2(x, y).normalized;
        GetComponent<Rigidbody2D>().velocity = dir * speed;

    }

    void CharaSelect()
    {
        if (isSelectFlag == true)
        {

        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Character"))
        {
            isSelectFlag = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Character"))
        {
            isSelectFlag = false;
        }
    }

}
