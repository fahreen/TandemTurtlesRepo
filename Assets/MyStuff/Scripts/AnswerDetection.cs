//using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerDetection : MonoBehaviour
{
    public GameObject otherObstacle;
    public GameObject question;
    public UI_Manager M;
    //public KartGame.KartSystems.ArcadeKart x;

    private void OnTriggerEnter(Collider other)
    {
        if(this.tag== "Right" && other.tag == "Player")
        {
            
           // Debug.Log("SpeedUP!");

            this.transform.localScale = new Vector3(0, 0, 0);
            this.otherObstacle.transform.localScale = new Vector3(0, 0, 0);

            this.question.gameObject.SetActive(false);
            M.ShowRight();

        }

        if (this.tag == "Wrong" && other.tag == "Player")
        {
            
           // Debug.Log("SlowDown!");

            this.transform.localScale = new Vector3(0, 0, 0);
            this.otherObstacle.transform.localScale = new Vector3(0, 0, 0);
            this.question.gameObject.SetActive(false);

            M.ShowWrong();



        }

    }
}
