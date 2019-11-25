using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    // Start is called before the first frame update
    ChangeWeather weather;
    PleyerController pCon;

    int beforeWeather; //天気格納用変数
    int nowWeather; //天気格納用変数
    public float magnification; //倍率



    // Start is called before the first frame update
    void Start()
    {
        weather = GameObject.Find("backG").GetComponent<ChangeWeather>();
        pCon = this.GetComponent<PleyerController>();
        nowWeather = (int)weather.NowWeather();

        magnification = 1f;
        ChangeStatus();

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Now magnification =" + magnification);

        nowWeather = (int)weather.NowWeather();

        if (nowWeather != beforeWeather) //天気が変わったら
        {
            ChangeStatus();
        }
        //pCon.Move(magnification);
        beforeWeather = nowWeather;
    }

    /// <summary>
    /// 天候でステータス変化
    /// </summary>
    public void ChangeStatus()
    {
        Debug.Log("Call ChangeStatus");
        Debug.Log("transflom.name = " + transform.name);
        switch (transform.name)
        {
            case "Csun(Clone)":
                {
                    Debug.Log("case Csun");
                    if (nowWeather == 0)
                    {
                        magnification = 1.2f;
                    }
                    else if (nowWeather == 1)
                    {
                        magnification = 0.8f;
                    }
                    else magnification = 1.0f;
                    break;
                }
            case "Crai":
                {
                    if (nowWeather == 1)
                    {
                        magnification = 1.2f;
                    }
                    else if (nowWeather == 2)
                    {
                        magnification = 0.8f;
                    }
                    else magnification = 1.0f;
                    break;
                }
            case "Cwin":
                {
                    if (nowWeather == 2)
                    {
                        magnification = 1.2f;
                    }
                    else if (nowWeather == 3)
                    {
                        magnification = 0.8f;
                    }
                    else magnification = 1.0f;
                    break;
                }
            case "Csno":
                {
                    if (nowWeather == 3)
                    {
                        magnification = 1.2f;
                    }
                    else if (nowWeather == 0)
                    {
                        magnification = 0.8f;
                    }
                    else magnification = 1.0f;
                    break;
                }
        }

    }
}
