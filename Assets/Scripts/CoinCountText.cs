using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCountText : MonoBehaviour
{
    public Text countText;
    public int coinCount = 0;


    void Start()
    {
        
    }


    void Update()
    {
        countText.text = coinCount.ToString();
    }

    public void AddCount(GameObject players)
    {
        coinCount += 1;
    }
}
