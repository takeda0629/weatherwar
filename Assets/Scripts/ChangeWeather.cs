using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeWeather : MonoBehaviour
{
    public enum Weather
    {
        sun,
        rain,
        wind,
        snow,
        Max
    }


    public Sprite sprite1; //晴れ
    public Sprite sprite2; //雨

    public Sprite[] sprites;//背景画像用配列

    private bool chFlg = false;//フラグ管理

    float cMAX; //カウンター上限値--->タイマーから数字引っ張ってくる奴
    private float cCounter; //天候変更用カウンター
    public float addSaving; //外部からのカウンター干渉用

    public Weather weather; //初期値用


    void Start()
    {
        cMAX = GameObject.Find("Timer").gameObject.GetComponent<Timer>().totalTime / (int)Weather.Max;//enumの中身の数参照できるように改造予定。できないなら書き換え忘れないように注意
        cCounter = 0;
        addSaving = 0;

        weather = Weather.sun;
        
    }

    //更新処理
    void Update()
    {
        Debug.Log(cMAX+"秒");
        //cCounterのカウントアップ処理
        cCounter += Time.deltaTime;
        if(addSaving != 0)
        {
            cCounter += addSaving;
            addSaving = 0;
        }

        if(cCounter >= cMAX)
        {
            Wchange();
            cCounter = 0;
        }
       
    }

    public void changeSprite()
    {
        this.gameObject.GetComponent<Image>().sprite = sprite2;

        if (!chFlg)
        {
            this.gameObject.GetComponent<Image>().sprite = sprite2;
            chFlg = true;
        }
        else
        {
            this.gameObject.GetComponent<Image>().sprite = sprite1;
            chFlg = false;
        }
    }

    //天候変更処理
    public void Wchange()
    {
        switch(weather)//
        {
            case Weather.sun://現在晴れ
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite =  sprites[(int)Weather.rain] ;//雨用スプライトに切り替え
                    weather = Weather.rain;//ステータスを雨に変更
                    break;
                }

            case Weather.rain://現在雨
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[(int)Weather.wind];//風用スプライトに切り替え
                    weather = Weather.wind;//ステータスを風に変更
                    break;
                }
            case Weather.wind://現在風
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[(int)Weather.snow];//雪用スプライトに切り替え
                    weather = Weather.snow;//ステータスを雪に変更
                    break;
                }
            case Weather.snow://現在雪
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[(int)Weather.sun];//晴れ用スプライトに切り替え
                    weather = Weather.sun;//ステータスを晴れに変更
                    break;
                }
        }



    }
}
