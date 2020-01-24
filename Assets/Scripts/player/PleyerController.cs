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

    //コイン関係
    public CoinCountText cct;
    public int counter = 0;

    public float jumpP;

    //画面端ループ用関数
    [SerializeField] float widthRight;
    [SerializeField] float widthLeft;

    public float loop;

    //ジャンプ回数制限用
    public bool canJump;

    //天候に応じた係数
    float mg;

    //被弾フラグ
    bool hitflag;

    ChangeWeather weather;

    // SE関係
    AudioSource audioSource;
    public AudioClip jumpSE;
    public AudioClip coinSE;
    public AudioClip damageSE;

    [SerializeField] Object charStatus;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        _parent = transform.root.gameObject;
        pNum = _parent.GetComponent<PlayerNoSelect>().num;

        cct = GameObject.Find(pNum + "PCount").GetComponent<CoinCountText>();
        weather = GameObject.Find("backG").GetComponent<ChangeWeather>();
        hitflag = false;
        canJump = true;

        audioSource = GetComponent<AudioSource>();
    }


    void /*Fixed*/Update()
    {

        FieldLoop();
        //if (Input.GetKeyDown(KeyCode.UpArrow))
        if (Input.GetButtonDown("Jump" + pNum) && canJump)
        {
            //Jump();
        }
    }

    /// <summary>
    /// Player1の操作スクリプト
    /// </summary>
    public void Move(float magnification)
    {
        if(hitflag == true)
        {
            return;
        }

        Vector2 velocity = rb.velocity;

        //float x = Input.GetAxisRaw("Horizontal" + (int)playerNo)*speed;
        float x = Input.GetAxisRaw("Horizontal" + pNum) * speed * magnification;//キャラクターセレクト連動
        //float y = Input.GetAxisRaw("Vertical" + (int)playerNo);
        //float y = Input.GetAxisRaw("Vertical" + pNum);
        Vector2 dir = new Vector2(x, velocity.y);
        this.rb.velocity = dir;

        if (x > 0)  // スティックを右に倒したら
        {
            transform.localScale = new Vector3(1f, 1f, 1f);   // 右向き
        }
        if (x < 0)  // スティックを左に倒したら
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);  // 左向き
        }
    }

    public void Knockback(float x)
    {
        Debug.Log("ノックバック");
        //float dirx = this.transform.localScale.x;
        this.rb.AddForce(new Vector2(x * 5.5f, 0.5f), ForceMode2D.Impulse);

        Invoke("Hitflagon", 0.5f);
    }

    //被弾の判定処理
    void Hitflagon()
    {
        hitflag = false;

    }

    //ジャンプ
    public void Jump(float jumpMg)
    {
        Vector2 vel = rb.velocity;

        vel.y = jumpP * jumpMg;

        //rb.AddForce(Vector2.up*jumpP);

        rb.velocity = vel;
        rb.velocity = vel;

        canJump = false;

        audioSource.clip = jumpSE;
        audioSource.Play();
    }


    //画面端ループ処理
    void FieldLoop()
    {
        if (rb.transform.position.x > widthRight)
        {
            Vector3 rbPos = rb.transform.position;
            rbPos.x = rbPos.x - loop;
            rb.transform.position = rbPos;
        }
        else if (rb.transform.position.x < widthLeft)
        {
            Vector3 rbPos = rb.transform.position;
            rbPos.x = rbPos.x + loop;
            rb.transform.position = rbPos;
        }
    }

    //コイン獲得
    void OnTriggerEnter2D(Collider2D col)
    {
        //通常コイン
        if (col.gameObject.tag == "Item")
        {
            cct.AddCount();
            counter += 1;
            weather.addSaving += 0.05f;
            audioSource.clip = coinSE;
            audioSource.Play();
        }
        //大コイン
        if (col.gameObject.tag == "Item2")
        {
            Debug.Log("get");
            cct.coinCount += 10;
            counter += 10;
            audioSource.clip = coinSE;
            audioSource.Play();
        }
    }


    //当たり判定処理
    void OnCollisionEnter2D(Collision2D other)
    {
        //敵の攻被弾
        if (other.gameObject.tag == "Attackobj")
        {
            Debug.Log("被弾");
            LostCoin();
            
        }
    }


    //コイン加算
    public void GetCoin()
    {
        cct.AddCount();
        counter += 1;
    }

    //コイン減算
    public void LostCoin()
    {
        if (cct.coinCount <= 0)
        {
            return;
        }
        Debug.Log("やられた！！");
        cct.coinCount -= 1;
        counter -= 1;
        hitflag = true;
    }

    public bool CanJump()
    {
        return canJump;
    }
}
