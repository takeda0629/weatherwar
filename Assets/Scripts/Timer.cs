using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float totalTime;
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
        if (totalTime <= 0f)
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
}
