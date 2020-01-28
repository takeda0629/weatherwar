using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Signal : MonoBehaviour
{
    [SerializeField]
    private Text signalText;

   
    [SerializeField] float second;

    void Start()
    {
        
        StartCoroutine(Countdown(second));
        
    }


    void Update()
    {
        if(second >= 0)
        {
            second -= Time.deltaTime;
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
