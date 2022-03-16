using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;
public class Opponentpath : MonoBehaviour
{


    public PathCreator pathCreator;
    public float speed = 5;
    float distancetravelled;
    Quaternion r;
    bool raceStarted;
    int lap = 0;

    private void Start()
    {
        this.transform.rotation = r;
        raceStarted = false;
        StartCoroutine(delay());



        
    }
    

    IEnumerator delay()
    {
        yield return new WaitForSeconds(3);
        raceStarted = true;
    }



    private void Update()
    {
        if (raceStarted && lap < 2)
        {
            distancetravelled += speed * Time.deltaTime;
            this.transform.position = new Vector3(pathCreator.path.GetPointAtDistance(distancetravelled).x, 0.2500009f, pathCreator.path.GetPointAtDistance(distancetravelled).z);
             r = pathCreator.path.GetRotationAtDistance(distancetravelled);
            r *= Quaternion.Euler(0, 0, 90);
            this.transform.rotation = Quaternion.Slerp(transform.rotation, r, Time.deltaTime );
        }



    }

   

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "FinishLine")
            lap++;
        if (lap > 1)
        {
            Debug.Log(this.gameObject.name + "just finished the race!");
            Manager.rank.Add(this.gameObject.name);
           
        }
        
    }
}
