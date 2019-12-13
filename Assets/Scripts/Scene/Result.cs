using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{
    private int[] chara_Nos;

    // Start is called before the first frame update
    void Start()
    {
        chara_Nos = Select.PlayerSelectChara();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("LoadButton"))
        {
            SceneManager.LoadScene("Title");
        }
    }
}
