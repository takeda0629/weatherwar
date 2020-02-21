using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Select : MonoBehaviour
{
    static CharaSelect p1Sel;
    static CharaSelect p2Sel;
    static CharaSelect p3Sel;
    static CharaSelect p4Sel;

    

    public static int[] characters;

    // Start is called before the first frame update
    void Start()
    {
        p1Sel = GameObject.Find("P1Select").GetComponent<CharaSelect>();
        p2Sel = GameObject.Find("P2Select").GetComponent<CharaSelect>();
        p3Sel = GameObject.Find("P3Select").GetComponent<CharaSelect>();
        p4Sel = GameObject.Find("P4Select").GetComponent<CharaSelect>();
        

        characters = new int[4];
    }

    // Update is called once per frame
    void Update()
    {
        
        LoadScene();
    }

    void LoadScene()
    {
        bool P1 = p1Sel.IsDecided();
        bool P2 = p2Sel.IsDecided();
        bool P3 = p3Sel.IsDecided();
        bool P4 = p4Sel.IsDecided();

        if (Input.GetButtonDown("LoadButton"))
        {
            P1 = p1Sel.LastResort();
            P2 = p2Sel.LastResort();
            P3 = p3Sel.LastResort();
            P4 = p4Sel.LastResort();
        }

        if (P1 == true && P2 == true && P3 == true && P4 == true)
        {
            SceneManager.LoadScene("GamePlay");
            //SceneManager.LoadScene("Stage1");
            //SceneManager.LoadScene("Sample_I_play");
        }
    }

    public static int[] PlayerSelectChara()
    {
        
        int p1 = p1Sel.MyChara();
        int p2 = p2Sel.MyChara();
        int p3 = p3Sel.MyChara();
        int p4 = p4Sel.MyChara();

        characters[0] = p1;
        characters[1] = p2;
        characters[2] = p3;
        characters[3] = p4;

        

        return characters;

    }
}
