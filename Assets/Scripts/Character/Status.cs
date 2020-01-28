using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Status : MonoBehaviour
{
    public enum PlayerNo
    {
        p1 = 1,
        p2 = 2,
        p3 = 3,
        p4 = 4
    }
    protected GameObject _parent;
    protected int pNum;

    protected ChangeWeather weather;
    protected PleyerController pCon;

    //コイン関係
    public CoinCountText cct;

    protected int beforeWeather; //天気格納用変数
    protected int nowWeather; //天気格納用変数
    protected float magnification; //倍率
    protected float jumpP;

    protected PowerColor powerColor;

    protected AudioSource audioSource;
    [SerializeField] protected AudioClip changeSE;


    // Start is called before the first frame update
    public virtual void Start()
    {
        _parent = transform.root.gameObject;
        pNum = _parent.GetComponent<PlayerNoSelect>().num;

        weather = GameObject.Find("backG").GetComponent<ChangeWeather>();
        pCon = this.GetComponent<PleyerController>();

        cct = GameObject.Find(pNum + "PCount").GetComponent<CoinCountText>();

        nowWeather = (int)weather.NowWeather();

        ChangeStatus();
        //powersprite = transform.GetChild(2).GetComponent<GameObject>();

        //audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    public virtual void Update()
    {
        if (Input.GetButtonDown("Jump" + pNum) && pCon.CanJump())
        {
            pCon.Jump(jumpP);
        }

        nowWeather = (int)weather.NowWeather();

        if (nowWeather != beforeWeather) //天気が変わったら
        {
            ChangeStatus();
            //audioSource.clip = changeSE;
            //audioSource.Play();
        }
        pCon.Move(magnification);
        beforeWeather = nowWeather;
    }

    //コイン加算
    public virtual void GetCoin()
    {
        cct.AddCount(1);
    }

    //コイン減算
    public virtual void LostCoin()
    {
        if (cct.NowCoin() <= 0)
        {
            return;
        }
        cct.LostCount(1);
        pCon.Hit();
    }

    /// <summary>
    /// 天候でステータス変化
    /// </summary>
    public virtual void ChangeStatus() { }

    
    //{
    //powerColor = transform.GetChild(2).gameObject.GetComponent<PowerColor>();
    //switch (transform.name)
    //{
    //    case "Csun(Clone)":
    //        {
    //            if (nowWeather == 0)
    //            {
    //                magnification = 1.1f;
    //                powerColor.SpriteOn();
    //            }
    //            else if (nowWeather == 1)
    //            {

    //                powerColor.SpriteOff();
    //            }
    //            else
    //            {
    //                magnification = 0.9f;
    //                powerColor.SpriteOff();
    //            }
    //            break;
    //        }
    //    case "Crai(Clone)":
    //        {
    //            if (nowWeather == 1)
    //            {

    //                powerColor.SpriteOn();
    //            }
    //            else if (nowWeather == 2)
    //            {

    //                powerColor.SpriteOff();
    //            }
    //            else
    //            {
    //                magnification = 1.0f;
    //                powerColor.SpriteOff();
    //            };
    //            break;
    //        }
    //    case "Cwin(Clone)":
    //        {
    //            if (nowWeather == 2)
    //            {
    //                magnification = 1.5f;
    //                powerColor.SpriteOn();
    //            }
    //            else if (nowWeather == 3)
    //            {
    //                magnification = 0.6f;
    //                powerColor.SpriteOff();
    //            }
    //            else
    //            {
    //                magnification = 1.0f;
    //                powerColor.SpriteOff();
    //            }
    //            break;
    //        }
    //    case "Csno(Clone)":
    //        {
    //            if (nowWeather == 3)
    //            {
    //                magnification = 1.2f;
    //                powerColor.SpriteOn();
    //            }
    //            else if (nowWeather == 0)
    //            {
    //                magnification = 0.8f;
    //                powerColor.SpriteOff();
    //            }
    //            else
    //            {
    //                magnification = 1.0f;
    //                powerColor.SpriteOff();
    //            }
    //            break;
    //        }

    //}

    //}

}
