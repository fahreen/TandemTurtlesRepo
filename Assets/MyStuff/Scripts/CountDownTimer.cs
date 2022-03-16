using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{

    public int countDownTime;
    public Text  Display;


    private void Start()
    {
        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        while(countDownTime > 0)
        {
            Display.text = countDownTime.ToString();
            yield return new WaitForSeconds(1f);
            countDownTime--;
        }
        Display.text = "GO!";
        yield return new WaitForSeconds(1f);
        Display.gameObject.SetActive(false);
    }


}
