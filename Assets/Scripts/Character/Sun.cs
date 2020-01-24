using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//晴れが得意なキャラ：攻撃力が高いが足が遅い
public class Sun : Status
{
    

    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        ChangeStatus();
        
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
        if (nowWeather == 0)
        {
            jumpP = 1.0f;
            magnification = 1.1f;
            powerColor.SpriteOn();
        }
        else if (nowWeather == 1)
        {
            jumpP = 1.0f;
            magnification = 0.9f;
            powerColor.SpriteOff();
        }
        else
        {
            jumpP = 1.0f;
            magnification = 0.9f;
            powerColor.SpriteOff();
        }
    }

    
}
