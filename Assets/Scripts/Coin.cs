using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    SpriteRenderer sRenderer;
    CircleCollider2D coll;

    [SerializeField,Header("再出現時間")] float displayTime = 0; 

    // Start is called before the first frame update
    void Start()
    {
       sRenderer = GetComponent<SpriteRenderer>();
        coll = GetComponent<CircleCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            sRenderer.enabled = false;
            coll.enabled = false;
            Invoke("OnEnabled", displayTime);
        }
    }

    void OnEnabled()
    {
        sRenderer.enabled = true;
        coll.enabled = true;
        //this.gameObject.transform.Translate(Random.Range(-3.0f, 3.0f), 0, 0);
    }
}
