using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    player2 sample;

    // Start is called before the first frame update
    void Start()
    {
        sample = transform.GetChild(0).gameObject.GetComponent<player2>();
    }

    // Update is called once per frame
    void Update()
    {
        sample.Move();
    }
}
