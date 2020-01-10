using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerColor : MonoBehaviour
{
    SpriteRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpriteOn()
    {
        Debug.Log("つよい");
        renderer.enabled = true;
    }

    public void SpriteOff()
    {
        Debug.Log("ふつー");
        renderer.enabled = false;
    }
}
