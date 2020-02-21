using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//風が得意なキャラ：足が速い
 public class Wind : Status
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
        if (nowWeather == 2)
        {
            jumpP = 1.0f;
            magnification = 2.0f;
            powerColor.SpriteOn();
        }
        else if (nowWeather == 3)
        {
            jumpP = 1.0f;
            magnification = -2f;
            powerColor.SpriteOff();
        }
        else
        {
            jumpP = 1.0f;
            magnification = 1.25f;
            powerColor.SpriteOff();
        }
    }
}
