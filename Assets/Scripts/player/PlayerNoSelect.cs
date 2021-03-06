﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNoSelect : MonoBehaviour
{
    public enum PlayerNo
    {
        p1 = 1,
        p2 = 2,
        p3 = 3,
        p4 = 4
    }

   

    [SerializeField] PlayerNo playerNo;
    public int num;

    public GameObject[] obj;
    
    GameObject character1;

    ChangeWeather cWeather;

    int[] charaNos;  //キャラナンバーの配列
    Status childStatus;

    // Start is called before the first frame update
    void Start()
    {
        num = (int)playerNo;
        //Debug.Log(num);
        cWeather = GameObject.Find("backG").GetComponent<ChangeWeather>();
        charaNos = Select.PlayerSelectChara();
        character1 = Instantiate(obj[charaNos[num - 1] - 1], this.transform.position, Quaternion.identity);
        character1.transform.parent = this.transform;

        //GetChild();

    }

    // Update is called once per frame
    void Update()
    {

      
       
    }

    public int Renum()
    {
        return num;
    }

    /// <summary>
    /// 自分の選んだキャラを子オブジェクトとして取得
    /// </summary>
    void GetChild()
    {
        childStatus = transform.GetChild(0).gameObject.GetComponent<Status>();
        
    }

    //void test()
    //{
    //    int a = (int)cWeather.NowWeather();
    //    int nowwether = a;
        
    //    if(nowwether != a)
    //    {
    //        childStatus.ChangeStatus(childStatus);
    //    }
    //}
}
