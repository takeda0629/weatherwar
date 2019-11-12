using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravity : MonoBehaviour
{

    //
    Rigidbody2D rBody;

    float myGravity = -9.81f;



    // Use this for initialization
    private void Start()
    {
        rBody = this.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 addGravity = new Vector2(0, myGravity);

        rBody.AddForce(addGravity);
    }

}
