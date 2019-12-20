using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    SpriteRenderer sRenderer;
    CircleCollider2D coll;
    public GameObject coinPrefab;
    //int count = 0;
    //int max = 6;
    //[SerializeField, Header("生存時間")] private float lifeTime = 0;
    //float time = 0f;

    [SerializeField,Header("再出現時間")] float displayTime = 0; 

    // Start is called before the first frame update
    void Start()
    {
        //time = 0;
       sRenderer = GetComponent<SpriteRenderer>();
        coll = GetComponent<CircleCollider2D>();
        for (int i = 0; i < 12; i++)
        {
            GameObject coin = Instantiate(coinPrefab) as GameObject;
            coin.transform.position = new Vector2(Random.Range(-7f, 7f), Random.Range(-4, 4f));
        }
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
        this.gameObject.transform.Translate(Random.Range(-3.0f, 3.0f), Random.Range(-1f, 1f), 0);
        //if (count == max) return;
        //float x = Random.Range(-7f, 7f);
        //float y = Random.Range(-2f, 4f);
        //Vector2 coinpos = new Vector2(x, y);
        
    }
}
