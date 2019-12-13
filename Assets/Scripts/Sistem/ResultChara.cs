using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ResultChara : MonoBehaviour
{
    private int[] chara_Nos;
    [SerializeField] private Sprite[] gameChara;

    Sprite sprite;
    [SerializeField] private Image image;

    // Start is called before the first frame update
    void Start()
    {
        chara_Nos = Select.PlayerSelectChara();
        sprite = gameChara[chara_Nos[0] - 1];
        image = this.GetComponent<Image>();
        image.sprite = sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
