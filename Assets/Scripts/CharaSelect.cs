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
    private static int selectNo = 0;

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
    void ChooseCharacter()
    {
        float choose = Input.GetAxis("Choose" + (int)playerNo);
        

        if (choose > 0 && beforeChoose == 0.0f && decideFlag == false)
        {
            selectNo++;
            if (selectNo > 3)
            {
                selectNo = 0;
            }
            sprite = gameChara[selectNo];
            image = this.GetComponent<Image>();
            image.sprite = sprite;

        }
        else if (choose < 0 && beforeChoose == 0.0f && decideFlag == false)
        {
            selectNo--;
            if (selectNo < 0)
            {
                selectNo = 3;
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

    //public static Sprite MyChara()
    //{
    //    return gameChara[selectNo];
    //}
}
