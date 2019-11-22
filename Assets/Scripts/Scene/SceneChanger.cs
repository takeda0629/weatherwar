using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public enum Scenes
{
    Title,
    CharaSelect,
    GamePlay,
    Result,
}
public class SceneChanger : MonoBehaviour
{
    [SerializeField] Scenes next;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        switch(next)
        {
            case Scenes.Title:
                {
                    SceneManager.LoadScene("Title");
                }
                break;
            case Scenes.CharaSelect:
                {
                    SceneManager.LoadScene("Select");
                }
                break;
            case Scenes.GamePlay:
                {
                    SceneManager.LoadScene("GamePlay");
                }
                break;
            case Scenes.Result:
                {
                    SceneManager.LoadScene("Result");
                }
                break;
        }
    }
}
