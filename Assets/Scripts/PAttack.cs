using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAttack : MonoBehaviour
{
    private Collider2D col2d;
    private SpriteRenderer spr;

    public float attaktime;//判定持続時間

    private float timecount;//時間計測

    private bool nowattack;//攻撃中か？

    private int num; //プレイヤー番号取得

    GameObject _parent;
    GameObject _parent2;
    PleyerController pcon;

    // Start is called before the first frame update
    void Start()
    {
        col2d = this.GetComponent<BoxCollider2D>();
        spr = this.GetComponent<SpriteRenderer>();
        nowattack = false;

        _parent = transform.root.gameObject;
        num = _parent.GetComponent<PlayerNoSelect>().num;

        _parent2 = transform.parent.gameObject;
        pcon = _parent2.GetComponent<PleyerController>();
         
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(_parent);

        if (nowattack)
        {
            timecount += Time.deltaTime;
        }

        if (Input.GetButtonDown("Attack"+num) && !nowattack)
        {
            OnAttack();
        }

        if (attaktime < timecount)
        {
            OffAttack();
        }

    }

    void OnAttack()
    {
        //Debug.Log("攻撃");
        col2d.enabled = true;
        spr.enabled = true;

        nowattack = true;
    }

    void OffAttack()
    {
        //Debug.Log("攻撃終了");
        col2d.enabled = false;
        spr.enabled = false;

        nowattack = false;
        timecount = 0;
    }

    
    //攻撃が当たった時
    void OnCollisionEnter2D(Collision2D other)
    {
         if(other.gameObject.tag == "Player")
        {
            pcon.GetCoin();
        }
    }
}
