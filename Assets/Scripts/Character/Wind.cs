using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    ChangeWeather weather;
    PleyerController pCon;

    int beforeWeather; //天気格納用変数
    int nowWeather; //天気格納用変数
    private float magnification; //倍率

    PowerColor powerColor;

    AudioSource audioSource;
    public AudioClip changeSE;

    // Start is called before the first frame update
    void Start()
    {
        weather = GameObject.Find("backG").GetComponent<ChangeWeather>();
        pCon = this.GetComponent<PleyerController>();


        nowWeather = (int)weather.NowWeather();
        ChangeStatus();

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        nowWeather = (int)weather.NowWeather();

        if (nowWeather != beforeWeather) //天気が変わったら
        {
            ChangeStatus();
            audioSource.clip = changeSE;
            audioSource.Play();
        }
        pCon.Move(magnification);
        beforeWeather = nowWeather;
    }

    public void ChangeStatus()
    {
        powerColor = transform.GetChild(2).gameObject.GetComponent<PowerColor>();
        if (nowWeather == 2)
        {
            magnification = 1.5f;
            powerColor.SpriteOn();
        }
        else if (nowWeather == 3)
        {
            magnification = 0.6f;
            powerColor.SpriteOff();
        }
        else
        {
            magnification = 1.0f;
            powerColor.SpriteOff();
        }
    }
}
