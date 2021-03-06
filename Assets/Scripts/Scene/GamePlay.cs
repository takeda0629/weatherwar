﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlay : MonoBehaviour
{
    [SerializeField]Timer timer;

    static CoinCountText p1Count;
    static CoinCountText p2Count;
    static CoinCountText p3Count;
    static CoinCountText p4Count;

    private bool gameFlag = false;

    static int[] finCoin;

    [SerializeField] GameObject cdText;

    // Start is called before the first frame update
    void Start()
    {
        p1Count = GameObject.Find("1PCount").GetComponent<CoinCountText>();
        p2Count = GameObject.Find("2PCount").GetComponent<CoinCountText>();
        p3Count = GameObject.Find("3PCount").GetComponent<CoinCountText>();
        p4Count = GameObject.Find("4PCount").GetComponent<CoinCountText>();

        

        finCoin = new int[4];
    }

    // Update is called once per frame
    void Update()
    {
        if(gameFlag == false && timer.TimeRemaining() < 120 && timer.TimeRemaining() > 0)
        {
            gameFlag = true;
        }

        if(gameFlag == true && timer.TimeRemaining() <= 30)
        {
            timer.ChangeTextColor();
            timer.Blink();
        }

        if (gameFlag == true && timer.TimeRemaining() <= 0)
        {
            cdText.SetActive(true);
            gameFlag = false;
            Invoke("LoadScene", 3);
        }
    }

    public static int[] FinishCoin()
    {
        int p1coin = p1Count.CoinCount();
        int p2coin = p2Count.CoinCount();
        int p3coin = p3Count.CoinCount();
        int p4coin = p4Count.CoinCount();

        finCoin[0] = p1coin;
        finCoin[1] = p2coin;
        finCoin[2] = p3coin;
        finCoin[3] = p4coin;

        return finCoin;
    }

    void LoadScene()
    {
        SceneManager.LoadScene("Result");
    }

    public bool IsGame()
    {
        return gameFlag;
    }
}
