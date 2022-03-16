using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public   GameObject greenScreen;
    public  GameObject redScreen;


   
    public static Color PlayerColour;

    public GameObject B1;
    public GameObject B2;



    // Start is called before the first frame update


    private void Start()
    {
        greenScreen.gameObject.SetActive(false);
        redScreen.gameObject.SetActive(false);

       B1.GetComponent<Renderer>().material.SetColor("_Color", Manager.turtleColour);
        B2.GetComponent<Renderer>().material.SetColor("_Color", Manager.turtleColour);
    }





    public  void ShowWrong()
    {
        redScreen.gameObject.SetActive(true);
        StartCoroutine(delay());
    }

    public  void ShowRight()
    {
        greenScreen.gameObject.SetActive(true);
        StartCoroutine(delay());
    }

    
 

    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.5f);
        greenScreen.gameObject.SetActive(false);
        redScreen.gameObject.SetActive(false);
    }
}
