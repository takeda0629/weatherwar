using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNoSelect : MonoBehaviour
{
    public enum PlayerNo
    {
        p1 = 1,
        p2 = 2,
        p3 = 3,
        p4 = 4
    }

    [SerializeField] PlayerNo playerNo;
    public int num;

    public GameObject obj;
    GameObject character1;

    int[] charaNos;  //キャラナンバーの配列
    Status childStatus;

    // Start is called before the first frame update
    void Start()
    {
        num = (int)playerNo;
        charaNos = Select.PlayerSelectChara();
        GetChild();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 vec3 = this.transform.position;//からオブジェクトの位置

            character1 = Instantiate(obj, this.transform.position,Quaternion.identity);
            character1.transform.parent = this.transform;
        }
    }

    public int Renum()
    {
        return num;
    }

    /// <summary>
    /// 自分の選んだキャラを子オブジェクトとして取得
    /// </summary>
    void GetChild()
    {
        childStatus = transform.GetChild(0).gameObject.GetComponent<Status>();
        
    }
}
