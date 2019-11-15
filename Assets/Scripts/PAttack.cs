using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAttack : MonoBehaviour
{
    private Collider2D col2d;

    public float attaktime;//判定持続時間

    private float timecount;//時間計測

    private bool nowattack;//攻撃中か？


    // Start is called before the first frame update
    void Start()
    {
        col2d = this.GetComponent<BoxCollider2D>();
        nowattack = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (nowattack)
        {
            timecount += Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space) && !nowattack)
        {
            OnAttack();
        }

        if (attaktime < timecount)
        {
            OffAttack();
        }

    }

    void OnAttack()
    {
        Debug.Log("攻撃");
        col2d.enabled = true;

        nowattack = true;
    }

    void OffAttack()
    {
        Debug.Log("攻撃終了");
        col2d.enabled = false;

        nowattack = false;
        timecount = 0;
    }
}
