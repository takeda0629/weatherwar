using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Select : MonoBehaviour
{
    GameObject p1Sel;
    GameObject p2Sel;
    GameObject p3Sel;
    GameObject p4Sel;

    CharaSelect sel1;
    CharaSelect sel2;
    CharaSelect sel3;
    CharaSelect sel4;

    // Start is called before the first frame update
    void Start()
    {
        p1Sel = GameObject.Find("P1Select");
        p2Sel = GameObject.Find("P2Select");
        p3Sel = GameObject.Find("P3Select");
        p4Sel = GameObject.Find("P4Select");

        sel1 = p1Sel.GetComponent<CharaSelect>();
        sel2 = p2Sel.GetComponent<CharaSelect>();
        sel3 = p3Sel.GetComponent<CharaSelect>();
        sel4 = p4Sel.GetComponent<CharaSelect>();
    }

    // Update is called once per frame
    void Update()
    {
        LoadScene();
    }

    void LoadScene()
    {
        bool P1 = sel1.IsDecided();
        bool P2 = sel2.IsDecided();
        bool P3 = sel3.IsDecided();
        bool P4 = sel4.IsDecided();

        if(P1 == true && P2 == true && P3 == true && P4 == true)
        {
            SceneManager.LoadScene("GamePlayScene");
        }
    }
}
