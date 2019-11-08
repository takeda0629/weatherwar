using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeWeather : MonoBehaviour
{
    public enum Weather
    {
        sun,
        rain
    }

    public Sprite sprite1; //晴れ
    public Sprite sprite2; //雨
    private bool chFlg = false;

    float cMAX; //カウンター上限値--->タイマーから数字引っ張ってくる奴
    private float cCounter; //天候変更用カウンター
    public float addSaving; //外部からのカウンター干渉用

    public Weather weather; //初期値用

    void Start()
    {
        cMAX = GameObject.Find("").gameObject.GetComponent<Timer>().totalTime / 2;//enumの中身の数参照できるように改造予定。できないなら書き換え忘れないように注意
        cCounter = 0;
        addSaving = 0;

        weather = Weather.sun;
        
    }

    //更新処理
    void Update()
    {
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
                    gameObject.GetComponent<Image>().sprite = sprite2;//雨用スプライトに切り替え
                    weather = Weather.rain;//ステータスを雨に変更
                    break;
                }

            case Weather.rain://現在雨
                {
                    gameObject.GetComponent<Image>().sprite = sprite1;//晴れ用スプライトに切り替え
                    weather = Weather.sun;//ステータスを晴れに変更
                    break;
                }
        }



    }
}
