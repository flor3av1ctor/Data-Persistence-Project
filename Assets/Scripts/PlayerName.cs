using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    // Start is called before the first frame update
    public static string playerNameString;
    public Text playername;

    void Start()
    {
        playername.text = "Best score of " +playerNameString+ " is: " ;
    }



}
