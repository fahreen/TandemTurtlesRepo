using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathQuestion : MonoBehaviour
{
    public GameObject Question;
    public Text QuestionText;

    public GameObject Right;
    public GameObject RightText;
    public GameObject Left;
    public GameObject LeftText;
    public GameObject speedR;
    public GameObject speedL;
    bool Triggered;



    private void Start()
    {
        Triggered = false;
        this.Question.SetActive(false);
        this.Right.SetActive(false);
        this.Left.SetActive(false);

        this.speedL.gameObject.SetActive(true);
        this.speedR.gameObject.SetActive(true);


    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && !Triggered)
        {
            Triggered = true;
            Question.SetActive(true);

            this.Right.SetActive(true);
            this.Left.SetActive(true);

            // randomly generate question
            float f = Random.Range(10f, 100f);

            float Q = Mathf.Round(f);

            if (Q % 5 == 0)
            {
                Q++;
            }
            QuestionText.text = Q.ToString();

            // generate answer
            float ans =  Mathf.Round(Q / 10f)*10;
            float wrongAns;
            if(ans > Q)
            {
                wrongAns = Mathf.Floor(Q / 10f)*10;
            }
            else
            {
                wrongAns = Mathf.Ceil(Q / 10f) * 10;
            }


            //randomly assign Left or right obstacle to right or wrong answers

            float assign = Random.Range(0f, 1f);
            
            if(assign > 0.5) // set left obstacle as right answer
            {
                this.Left.tag = "Right";
                this.LeftText.GetComponent<TextMesh>().text = ans.ToString();

                this.Right.tag = "Wrong";
                this.RightText.GetComponent<TextMesh>().text = wrongAns.ToString();
                //turn off speed pad
                this.speedR.gameObject.SetActive(false);
            }

            else // set right obstacle as right answer
            {
                this.Right.tag = "Right";
                this.RightText.GetComponent<TextMesh>().text = ans.ToString();

                this.Left.tag = "Wrong";
                this.LeftText.GetComponent<TextMesh>().text = wrongAns.ToString();
                //turn off speed pad
                this.speedL.gameObject.SetActive(false);
            }

            StartCoroutine(delay());
            
        }
    }


    IEnumerator delay()
    {
        yield return new WaitForSeconds(5);
       // this.Question.SetActive(false);
        this.gameObject.SetActive(false);
        // this.Right.SetActive(false);
        //this.Left.SetActive(false);
        this.Right.transform.localScale = new Vector3(0, 0, 0);
        this.Left.transform.localScale = new Vector3(0, 0, 0);
    }

}
