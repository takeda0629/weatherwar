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

    // Start is called before the first frame update
    void Start()
    {
        num = (int)playerNo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int Renum()
    {
        return num;
    }

}
