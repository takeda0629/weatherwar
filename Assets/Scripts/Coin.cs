using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    SpriteRenderer sRenderer;
    CircleCollider2D coll;
    public GameObject coinPrefab;
    private Camera _mainCamera;

    float Minx;
    float Maxx;
    float Miny;
    float Maxy;

    //int count = 0;
    //int max = 6;
    //[SerializeField, Header("生存時間")] private float lifeTime = 0;
    //float time = 0f;

    [SerializeField, Header("再出現時間")] float displayTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        // カメラオブジェクトを取得
        GameObject obj = GameObject.Find("Main Camera");
        _mainCamera = obj.GetComponent<Camera>();

        // 座標値を出力
        Debug.Log(getScreenTopLeft().x + ", " + getScreenTopLeft().y);
        Debug.Log(getScreenBottomRight().x + ", " + getScreenBottomRight().y);

        Minx = getScreenTopLeft().x;
        Maxx = getScreenBottomRight().x;
        Maxy = getScreenTopLeft().y-1f;
        Miny = getScreenBottomRight().y;

        //time = 0;
        sRenderer = GetComponent<SpriteRenderer>();
        coll = GetComponent<CircleCollider2D>();

        OnEnabled();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
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
        int value = Random.Range((int)Miny, (int)Maxy );
        this.gameObject.transform.position = new Vector3(Random.Range(Minx, Maxx),(float)value+0.5f , 0);

    }

    private Vector3 getScreenTopLeft()
    {
        // 画面の左上を取得
        Vector3 topLeft = _mainCamera.ScreenToWorldPoint(Vector3.zero);
        // 上下反転させる
        topLeft.Scale(new Vector3(1f, -1f, 1f));
        return topLeft;
    }

    private Vector3 getScreenBottomRight()
    {
        // 画面の右下を取得
        Vector3 bottomRight = _mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0.0f));
        // 上下反転させる
        bottomRight.Scale(new Vector3(1f, -1f, 1f));
        return bottomRight;
    }
}
