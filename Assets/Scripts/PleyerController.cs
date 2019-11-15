using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PleyerController : MonoBehaviour
{

    public enum PlayerNo
    {
        p1 = 1,
        p2 = 2,
        p3 = 3,
        p4 = 4
    }
    private GameObject _parent;
    private int pNum;

    [SerializeField] float speed = 8.0f;
    private Rigidbody2D rb;
    public bool isSelectFlag = false;
    [SerializeField] PlayerNo playerNo;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        _parent = transform.root.gameObject;

        pNum = _parent.GetComponent<PlayerNoSelect>().num;
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

        //float x = Input.GetAxisRaw("Horizontal" + (int)playerNo);
        float x = Input.GetAxisRaw("Horizontal" + pNum);//キャラクターセレクト連動
        //float y = Input.GetAxisRaw("Vertical" + (int)playerNo);
        float y = Input.GetAxisRaw("Vertical" + pNum);
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
