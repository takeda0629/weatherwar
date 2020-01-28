using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//雪が得意なキャラ：バランス型
public class Snow : Status
{
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        //if (Input.GetButtonDown("Jump" + pNum) && pCon.CanJump())
        //{
        //    pCon.Jump(jumpP);
        //}

        //nowWeather = (int)weather.NowWeather();

        //if (nowWeather != beforeWeather) //天気が変わったら
        //{
        //    ChangeStatus();
        //    audioSource.clip = changeSE;
        //    audioSource.Play();
        //}
        //pCon.Move(magnification);
        //beforeWeather = nowWeather;
    }

    

    public override void ChangeStatus()
    {
        powerColor = transform.GetChild(2).gameObject.GetComponent<PowerColor>();
        if (nowWeather == 3)
        {
            jumpP = 1.2f;
            magnification = 1.3f;
            powerColor.SpriteOn();
        }
        else if (nowWeather == 0)
        {
            jumpP = 0.9f;
            magnification = 0.8f;
            powerColor.SpriteOff();
        }
        else
        {
            jumpP = 1.1f;
            magnification = 1.15f;
            powerColor.SpriteOff();
        }
    }
}
