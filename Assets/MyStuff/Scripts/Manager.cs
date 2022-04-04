using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public static Manager instance;
    public static List<string> rank;
    public static Color turtleColour = Color.white;

    public static  int Correct;

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


    private void Start()
    {
        rank =  new List<string>();
        Correct = 0;
    }

}
