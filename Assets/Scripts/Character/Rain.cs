using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//雨が得意なキャラ：ジャンプ力が高い
public class Rain : Status
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
        //    //audioSource.clip = changeSE;
        //    //audioSource.Play();
        //}
        //pCon.Move(magnification);
        //beforeWeather = nowWeather;
    }

   

    public override void ChangeStatus()
    {
        powerColor = transform.GetChild(2).gameObject.GetComponent<PowerColor>();
        if (nowWeather == 1)
        {
            jumpP = 1.5f;
            magnification = 1.0f;
            powerColor.SpriteOn();
        }
        else if (nowWeather == 2)
        {
            jumpP = 0.84f;
            magnification = 1.0f;
            powerColor.SpriteOff();
        }
        else
        {
            jumpP = 1.3f;
            magnification = 1.0f;
            powerColor.SpriteOff();
        }
    }
}
