using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastCountDown : MonoBehaviour
{
    [SerializeField] private Text countDownText;
    public AudioClip endSE;

    AudioSource audio;

    void Awake()
    {
        audio = gameObject.GetComponent<AudioSource>();
        audio.PlayOneShot(endSE);

        countDownText.text = "TIME UP!!";

        //StartCoroutine(Countdown());
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //IEnumerator Countdown()
    //{
    //    countDownText.text = " 5";
    //    yield return new WaitForSeconds(1.0f);

    //    countDownText.text = " 4";
    //    yield return new WaitForSeconds(1.0f);

    //    countDownText.text = " 3";
    //    yield return new WaitForSeconds(1.0f);

    //    countDownText.text = " 2";
    //    yield return new WaitForSeconds(1.0f);

    //    countDownText.text = " 1";
    //    yield return new WaitForSeconds(1.0f);

    //    countDownText.text = "TIME UP!!";

    //}
}
