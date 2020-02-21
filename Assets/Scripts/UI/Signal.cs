using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Signal : MonoBehaviour
{
    [SerializeField]
    private Text signalText;
    [SerializeField] float second;

    AudioSource audioSource;
    public AudioClip countdownSE;
    public AudioClip whistleSE;

    bool Three;
    bool Two;
    bool One;
    bool Go;

    void Start()
    {
        StartCoroutine(Countdown(second));
        audioSource = GetComponent<AudioSource>();
        Three = true;
    }


    void FixedUpdate()
    {
        //Debug.Log(second);
        //if (Three)
        //{
        //    audioSource.clip = countdownSE;
        //    audioSource.Play();
        //    Three = false;
        //}

        //if (second >= 2)
        //{
        //    //audioSource.clip = countdownSE;
        //    //audioSource.Play();
        //}

        //if (second >= 1)
        //{
        //    //audioSource.clip = countdownSE;
        //    //audioSource.Play();
        //}

        //if (second >= 0)
        //{
        //    audioSource.clip = whistleSE;
        //    audioSource.Play();
        //    second -= Time.deltaTime;
        //}

        Debug.Log(second);
        second -= Time.deltaTime;

        if (second == 3)
        {
            audioSource.clip = countdownSE;
            audioSource.Play();
            Debug.Log("3");
        }
        else if (second >= 2 && second <= 3)
        {
            audioSource.clip = countdownSE;
            audioSource.Play();
            Debug.Log("2");
        }
        else if (second >= 1 && second <= 2)
        {
            audioSource.clip = countdownSE;
            audioSource.Play();
            Debug.Log("1");
        }
        else if (second <=1 && second >= 0)
        {
            audioSource.clip = whistleSE;
            audioSource.Play();
            
            Debug.Log("Go");
        }
        else
        {
            return;
        }
    }

    IEnumerator Countdown(float seconds)
    {
        seconds = second;
        signalText.text = " 3";

        yield return new WaitForSeconds(1.0f);

        signalText.text = " 2";

        yield return new WaitForSeconds(1.0f);

        signalText.text = " 1";

        yield return new WaitForSeconds(1.0f);

        signalText.text = "GO!";
        yield return new WaitForSeconds(1.0f);

        signalText.text = "";

    }

    public float StartCount()
    {
        return second;
    }
}
