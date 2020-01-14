using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RsultCoinText : MonoBehaviour
{
    enum PlayerNo
    {
        p1 = 1,
        p2 = 2,
        p3 = 3,
        p4 = 4,
    }

    [SerializeField] PlayerNo pNum;
    int[] finCoin;
    [SerializeField]Text coinText;

    // Start is called before the first frame update
    void Start()
    {
        finCoin = GamePlay.FinishCoin();
        coinText.text = (int)pNum + "Pのコイン："+ finCoin[(int)pNum - 1].ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int FinCoin(int num)
    {
        //foreach (var a in finCoin)
        //{
        //    Debug.Log(a);
        //}
        return finCoin[num];
    }
}
