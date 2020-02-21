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

    void Start()
    {
        StartCoroutine(Countdown(second));
        audioSource = GetComponent<AudioSource>();
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

        if (second >= 2.9f && second <= 2.91f)
        {
            //audioSource.clip = countdownSE;
            //audioSource.Play();
            audioSource.PlayOneShot(countdownSE);
            Debug.Log("3");
        }
        else if (second >= 2 && second <= 2.01f)
        {
            //audioSource.clip = countdownSE;
            //audioSource.Play();
            audioSource.PlayOneShot(countdownSE);
            Debug.Log("2");
        }
        else if (second >= 1 && second <= 1.01f)
        {
            //audioSource.clip = countdownSE;
            //audioSource.Play();
            audioSource.PlayOneShot(countdownSE);
            Debug.Log("1");
        }
        else if (second >= 0 && second <= 0.01f)
        {
            //audioSource.clip = whistleSE;
            //audioSource.Play();
            audioSource.PlayOneShot(whistleSE);
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
