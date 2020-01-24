using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Signal : MonoBehaviour
{
    [SerializeField]
    private Text signalText;

    void Start()
    {
        StartCoroutine(Countdown(3));
    }


    void Update()
    {
        
    }

    IEnumerator Countdown(int seconds)
    {
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
}
