using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerColor : MonoBehaviour
{
    new SpriteRenderer renderer;

    // Start is called before the first frame update
    void Awake()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpriteOn()
    {
        renderer.enabled = true;
    }

    public void SpriteOff()
    {
        //Debug.Log("ふつー");
        renderer.enabled = false;
    }
}
