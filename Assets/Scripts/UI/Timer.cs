using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float totalTime;
    [SerializeField]
    public int minute;
    [SerializeField]
    public float seconds;
    private float oldSeconds;
    private Text timerText;

    //-----------カウントダウンの点滅処理に使う-----------
    public float speed = 0.8f;
    private float time;
    //---------------------------------------------------

    void Start()
    {     
        totalTime = minute * 60 + seconds;
        oldSeconds = 0f;
        timerText = GetComponentInChildren<Text>();

    }


    void Update()
    {
        Invoke("CountDown", 4);
        //if (totalTime <= 0f)
        //{
        //    return;
        //}
        //totalTime = minute * 60 + seconds;
        //totalTime -= Time.deltaTime;

        //minute = (int)totalTime / 60;
        //seconds = totalTime - minute * 60;

        //if ((int)seconds != (int)oldSeconds)
        //{
        //    timerText.text = minute.ToString("00") + ":" +
        //        ((int)seconds).ToString("00");
        //}
        //oldSeconds = seconds;
        //if (totalTime <= 0f)
        //{

        //}
    }

    void CountDown()
    {
        if (totalTime < 0f)
        {
            return;
        }
        totalTime = minute * 60 + seconds;
        totalTime -= Time.deltaTime;

        minute = (int)totalTime / 60;
        seconds = totalTime - minute * 60;

        if ((int)seconds != (int)oldSeconds)
        {
            timerText.text = minute.ToString("00") + ":" +
                ((int)seconds).ToString("00");
        }
        oldSeconds = seconds;
        
    }

    /// <summary>
    /// 残り時間
    /// </summary>
    /// <returns></returns>
    public float TimeRemaining()
    {
        return totalTime;
    }

    /// <summary>
    /// テキストの色を赤に変更
    /// </summary>
    public void ChangeTextColor()
    {
        timerText.color = new Color(255f / 255f, 0f / 255f, 0f / 255f);
    }

    //Alpha値を更新してColorを返す
    private Color GetAlphaColor(Color color)
    {
        time += Time.deltaTime * 5.0f * speed;
        color.a = Mathf.Sin(time) * 0.5f + 0.5f;

        return color;
    }

    /// <summary>
    /// テキストのアルファ値変更
    /// </summary>
    public void Blink()
    {
        timerText.color = GetAlphaColor(timerText.color);
    }
}
