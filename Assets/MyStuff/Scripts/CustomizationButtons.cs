using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomizationButtons : MonoBehaviour
{
   
    public static Color ColourSelected = Color.white;
    public static string tName;

    public GameObject B1;
    public GameObject B2;


    private string input;
    // Start is called before the first frame update
    public void Default()
    {
        ColourSelected = Color.white;

    }

    public void Red()
    {
        ColourSelected = Color.red;
    }

    public void Green()
    {
        ColourSelected = Color.green;
    }

    public void Pink()
    {
        ColourSelected = Color.magenta;
    }

    public void Blue()
    {
        ColourSelected = Color.blue;
    }

    public void Cyan()
    {
        ColourSelected = Color.cyan;
    }

    private void Update()
    {
        B1.GetComponent<Renderer>().material.SetColor("_Color", ColourSelected);
        B2.GetComponent<Renderer>().material.SetColor("_Color", ColourSelected);

    }




}


