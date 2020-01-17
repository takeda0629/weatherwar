using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Judge : MonoBehaviour
{
    [SerializeField] RsultCoinText player1;
    [SerializeField] RsultCoinText player2;
    [SerializeField] RsultCoinText player3;
    [SerializeField] RsultCoinText player4;

    int p1Coin;
    int p2Coin;
    int p3Coin;
    int p4Coin;

    [SerializeField] Text wineerText;

    bool once = true;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(once)
        {
            p1Coin = player1.FinCoin(0);
            p2Coin = player2.FinCoin(1);
            p3Coin = player3.FinCoin(2);
            p4Coin = player4.FinCoin(3);
            JudgeMan();
        }
       
    }

    /// <summary>
    /// 勝者を決める
    /// ゴリ押しましたすいません
    /// </summary>
    void JudgeMan()
    {
        if(p1Coin > p2Coin && p1Coin > p3Coin && p1Coin > p4Coin)
        {
            wineerText.text = "Player1の勝ち!!";
        }
        else if(p2Coin > p1Coin && p2Coin > p3Coin && p2Coin > p4Coin)
        {
            wineerText.text = "Player2の勝ち!!";
        }
        else if(p3Coin > p1Coin && p3Coin > p2Coin && p3Coin > p4Coin)
        {
            wineerText.text = "Player3の勝ち!!";
        }
        else if(p4Coin > p1Coin && p4Coin > p2Coin && p4Coin > p3Coin)
        {
            wineerText.text = "Player4の勝ち!!";
        }
        else
        {
            wineerText.text = "1位が誰だっていいじゃないか。人間だもの。\n ウェザ男";
        }

        once = false;
        
    }
}
