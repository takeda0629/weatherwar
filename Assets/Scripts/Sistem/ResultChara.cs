using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ResultChara : MonoBehaviour
{
    public enum PlayerNo
    {
        p1 = 1,
        p2 = 2,
        p3 = 3,
        p4 = 4,
    }
    [SerializeField] PlayerNo playerNo;
    private int[] chara_Nos;
    [SerializeField] private Sprite[] gameChara;

    Sprite sprite;
    [SerializeField] private Image image;

    // Start is called before the first frame update
    void Start()
    {
        chara_Nos = Select.PlayerSelectChara();
        sprite = gameChara[chara_Nos[(int)playerNo - 1] - 1];
        image = this.GetComponent<Image>();
        image.sprite = sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
