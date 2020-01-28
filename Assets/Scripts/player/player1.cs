using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class player1 : MonoBehaviour
{
    public enum PlayerNo
    {
        p1 = 1,
        p2 = 2,
        p3 = 3,
        p4 = 4
    }

    [SerializeField] float speed = 8.0f;
    private Rigidbody2D rb;
    public bool isSelectFlag = false;


    bool getcoin = false;
    public CoinCountText cct;
    public int counter = 0;

    public int loop;
    [SerializeField] PlayerNo playerNo;
    [SerializeField] float widthRight;
    [SerializeField] float widthLeft;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //eventSystem1 = GameObject.Find("1PCount");
        cct = GameObject.Find((int)playerNo + "PCount").GetComponent<CoinCountText>();
    }


    void Update()
    {
        Move();
        FieldLoop();
    }

    /// <summary>
    /// Player1の操作スクリプト
    /// </summary>
    void Move()
    {
        Vector2 velocity = rb.velocity;

        float x = Input.GetAxisRaw("Horizontal" + (int)playerNo);
        float y = Input.GetAxisRaw("Vertical" + (int)playerNo);
        Vector2 dir = new Vector2(x, y).normalized;
        GetComponent<Rigidbody2D>().velocity = dir * speed;

        if (x > 0)  // スティックを右に倒したら
        {
            transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);   // 右向き
        }
        if (x < 0)  // スティックを左に倒したら
        {
            transform.localScale = new Vector3(-1.5f, 1.5f, 1.5f);  // 左向き
        }
        
    }

    void CharaSelect()
    {
        if(isSelectFlag == true)
        {

        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if(col.CompareTag("Character"))
        {
            isSelectFlag = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.CompareTag("Character"))
        {
            isSelectFlag = false;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Item")
        {
            Debug.Log("get");
            cct.AddCount(1);
            counter += 1;
        }
    }

    void FieldLoop()  // 画面端ループ処理
    {
        if (rb.transform.position.x > widthRight)
        {
            Vector3 rbPos = rb.transform.position;
            rbPos.x = rbPos.x -17f;
            rb.transform.position = rbPos;
        }

        if (rb.transform.position.x < -widthLeft)
        {
            Vector3 rbPos = rb.transform.position;
            rbPos.x = rbPos.x + 17f;
            rb.transform.position = rbPos;
        }
    }
}
