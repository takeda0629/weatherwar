using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeWeather : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    private bool chFlg = false;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void changeSprite()
    {
        this.gameObject.GetComponent<Image>().sprite = sprite2;

        if (!chFlg)
        {
            this.gameObject.GetComponent<Image>().sprite = sprite2;
            chFlg = true;
        }
        else
        {
            this.gameObject.GetComponent<Image>().sprite = sprite1;
            chFlg = false;
        }
    }
}
