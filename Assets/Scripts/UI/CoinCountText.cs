using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCountText : MonoBehaviour
{
    public Text countText;
    public int coinCount = 0;
    private  int finCoin = 0;

    void Start()
    {
        
    }


    void Update()
    {
        if(coinCount < 0 || finCoin < 0)
        {
            coinCount = 0;
            finCoin = 0;
        }
        countText.text = coinCount.ToString();
    }

    public void AddCount(int coin)
    {
        coinCount += coin;
        finCoin += coin;
    }

    public void LostCount(int coin)
    {
        coinCount -= coin;
        finCoin -= coin;
    }

    public int NowCoin()
    {
        return coinCount;
    }

    public  int CoinCount()
    {
        return finCoin;
    }

}
