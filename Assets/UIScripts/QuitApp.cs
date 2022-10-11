using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class QuitApp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Exit()
    {
        EditorApplication.ExitPlaymode();

        Application.Quit(); // original code to quit Unity player

    }
}
