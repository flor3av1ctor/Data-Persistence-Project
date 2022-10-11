using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScenes : MonoBehaviour
{
    public InputField playerName;
    public static MainManager Instance;

    public void StartScene()
    {
        Debug.Log("Player name is: "+ playerName.text);
        PlayerName.playerNameString = playerName.text;
        SceneManager.LoadScene(0);
    }

    
}
