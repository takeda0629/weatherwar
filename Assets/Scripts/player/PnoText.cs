using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class PnoText : MonoBehaviour
{

    public enum PlayerNo
    {
        p1 = 1,
        p2 = 2,
        p3 = 3,
        p4 = 4
    }

    private GameObject _parent;
    private int pNum;
    private RectTransform rectTransform;


    Text pNo;

    // Start is called before the first frame update
    void Start()
    {
        //_parent = transform.root.gameObject;
        //pNum = _parent.GetComponent<PlayerNoSelect>().num;

        //pNo = this.gameObject.GetComponent<Text>();
        //pNo.text = string.Format("{0}P", pNum);

        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Camera.main.transform.rotation;
    }
}
