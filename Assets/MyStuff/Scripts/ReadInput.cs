using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadInput : MonoBehaviour
{

    private string input;
    public GameObject t;
    public static string TName;
    public void ReadSteingInput()
    {

        TName = t.GetComponent<Text>().text;
    }
}
