using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public static Manager instance;
    public static List<string> rank = new List<string>();
    public static Color turtleColour = Color.white;

    public static string TurtleName; 
    
    //singleton 
    void Awake()
    {
        if(TurtleName == null)
        {
            TurtleName = "Player";
        }
        if (instance == null)
        {
            instance = this;
        }
    }
    
}
