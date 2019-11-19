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

    public float jumpP;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        _parent = transform.root.gameObject;

       // pNum = _parent.GetComponent<PlayerNoSelect>().num;
    }


    void FixedUpdate()
    {
        Move();

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Jump();
        }
    }

    /// <summary>
    /// Player1の操作スクリプト
    /// </summary>
    void Move()
    {
        Vector2 velocity = rb.velocity;

        float x = Input.GetAxisRaw("Horizontal" + (int)playerNo)*speed;
        //float x = Input.GetAxisRaw("Horizontal" + pNum)*speed   ;//キャラクターセレクト連動
        //float y = Input.GetAxisRaw("Vertical" + (int)playerNo);
        //float y = Input.GetAxisRaw("Vertical" + pNum);
        Vector2 dir = new Vector2(x, velocity.y);
        this.rb.velocity = dir;
    }

    void Jump()
    {
        Debug.Log("ｼﾞｬﾝﾌﾟ");
        Vector2 vel = rb.velocity;

        vel.y = jumpP;

        //rb.AddForce(Vector2.up*jumpP);

        rb.velocity = vel;
        

        
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
