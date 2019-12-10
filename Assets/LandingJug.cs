using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingJug : MonoBehaviour
{
    GameObject _parent;
    PleyerController pcon;

    // Start is called before the first frame update
    void Start()
    {
        _parent = transform.parent.gameObject;
        pcon = _parent.GetComponent<PleyerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        pcon.canJump = true;

    }

    //void OnCollisionStat2D(Collision2D other)
    //{
    //    Debug.Log(pcon.canJump);
    //    pcon.canJump = true;

    //}
}
