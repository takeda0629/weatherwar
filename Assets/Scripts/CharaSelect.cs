using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class CharaSelect : MonoBehaviour
{
    public enum PlayerNo
    {
        p1 = 1,
        p2 = 2,
        p3 = 3,
        p4 = 4,
    }
    [SerializeField] PlayerNo playerNo;

    [SerializeField]  Sprite[] gameChara;
    private int selectNo = 0;  //配列の番号
    public int charaNo = 1;  //キャラ番号

    private Sprite sprite;
    [SerializeField] private Image image;

    [SerializeField]private bool decideFlag = false;
    private float beforeChoose;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        ChooseCharacter();
        DecidedCharacter();
        
    }

    /// <summary>
    /// キャラクターの確定・キャンセル
    /// </summary>
    void DecidedCharacter()
    {
        if(Input.GetButton("Decide" + (int)playerNo) )
        {
            decideFlag = true;
        }

        if(Input.GetButton("Cancel" + (int)playerNo))
        {
            decideFlag = false;
        }
    }

    /// <summary>
    /// キャラクター選択
    /// </summary>
    public void ChooseCharacter()
    {
        float choose = Input.GetAxis("Choose" + (int)playerNo);


        if (choose > 0 && beforeChoose == 0.0f && decideFlag == false)
        {
            selectNo++;
            charaNo++;
            if (selectNo > 3)
            {
                selectNo = 0;
            }
            if(charaNo > 4)
            {
                charaNo = 1;
            }
            sprite = gameChara[selectNo];
            image = this.GetComponent<Image>();
            image.sprite = sprite;

        }
        else if (choose < 0 && beforeChoose == 0.0f && decideFlag == false)
        {
            selectNo--;
            charaNo--;
            if (selectNo < 0)
            {
                selectNo = 3;
            }
            if(charaNo < 1)
            {
                charaNo = 4;
            }
            sprite = gameChara[selectNo];
            image = this.GetComponent<Image>();
            image.sprite = sprite;
        }

        beforeChoose = choose;
    }

    /// <summary>
    /// 決定したかどうか
    /// </summary>
    /// <returns></returns>
    public bool IsDecided()
    {
        return decideFlag;
    }

    /// <summary>
    /// 選んだキャラ番号の変数を返す
    /// </summary>
    /// <returns></returns>
    public int MyChara()
    {
        return charaNo;
    }
}
