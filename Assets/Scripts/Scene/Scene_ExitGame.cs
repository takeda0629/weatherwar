using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_ExitGame : MonoBehaviour
{
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
        UnityEngine.Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDARD
        UnityEngine.Application.Quit();
#endif
    }
}
