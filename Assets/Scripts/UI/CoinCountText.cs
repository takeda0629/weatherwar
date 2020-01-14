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
        countText.text = coinCount.ToString();
    }

    public void AddCount()
    {
        coinCount += 1;
        finCoin += 1;
    }

    public  int CoinCount()
    {
        return finCoin;
    }

}
