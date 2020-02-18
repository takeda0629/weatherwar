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

    private Vector3 setScale = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        //_parent = transform.root.gameObject;
        //pNum = _parent.GetComponent<PlayerNoSelect>().num;

        //pNo = this.gameObject.GetComponent<Text>();
        //pNo.text = string.Format("{0}P", pNum);

        setScale = this.transform.lossyScale;
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localScale = new Vector3(Mathf.Abs(setScale.x), setScale.y, setScale.z);
        Debug.Log("setScale:" + setScale);
        Debug.Log("localScale" + transform.localScale);
    }
}
