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
        //if (totalTime <= 0f)
        //{

        //}
    }

    /// <summary>
    /// 残り時間
    /// </summary>
    /// <returns></returns>
    public float TimeRemaining()
    {
        return totalTime;
    }

    public void ChangeTextColor()
    {
        timerText.color = new Color(255f / 255f, 0f / 255f, 0f / 255f);
    }
}
