using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlay : MonoBehaviour
{
    int[] charaNos;  //キャラナンバーの配列

    // Start is called before the first frame update
    void Start()
    {
        charaNos = Select.PlayerSelectChara();

        foreach(var a in charaNos)
        {
            Debug.Log(a);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("LoadButton"))
        {
            SceneManager.LoadScene("Result");
        }
    }
}
