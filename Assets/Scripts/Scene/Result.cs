using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{
    float diltime;
    float keeptime;

    bool titleFlag;

    // Start is called before the first frame update
    void Start()
    {
        diltime = 0;
        keeptime = 3f;
        titleFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        diltime += Time.deltaTime;
        if(diltime >= keeptime)
        {
            titleFlag = true;
        }

        if (Input.GetButtonDown("Jump")&&titleFlag)
        {
            SceneManager.LoadScene("Title");
        }
    }
}
