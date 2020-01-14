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
        

        //GetChild();

    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 vec3 = this.transform.position;//からオブジェクトの位置

<<<<<<< HEAD
            
            character1 = Instantiate(obj[0/*charaNos[num - 1] - 1*/], this.transform.position, Quaternion.identity);
=======
            //if(charaNos == null)
            //{
            //    for(int i= 0; i < 4; i++)
            //    {
            //        charaNos[i] = i;
            //    }
            //}
            character1 = Instantiate(obj[/*charaNos[num - 1] -*/ 0], this.transform.position, Quaternion.identity);
>>>>>>> c73059933c9be4bee8965065b9cd54ccc7d229be
            character1.transform.parent = this.transform;
        }
       
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
