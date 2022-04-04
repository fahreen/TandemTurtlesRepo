using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    int counter;
    bool gameOver;
    public GameObject player;
    public GameObject boundary;
    public GameObject boundary2;
    Vector3 pos;
    private void Start()
    {
        counter = 0;
        gameOver = false;
        boundary.SetActive(false);
        boundary2.SetActive(false);
    }



    private void Update()
    {
        if(gameOver && Manager.rank.Count == 5)
        {
            
            SceneManager.LoadScene("MyStuff/Scenes/GameOver");
        }

       
        
    }




    IEnumerator delay()
    {
        yield return new WaitForSeconds(1f);
        boundary.SetActive(true);
        boundary2.SetActive(true);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            counter++;
            Debug.Log(Manager.TurtleName +" is the player's name!");
            if (counter == 2)
            {
                Manager.rank.Add(Manager.TurtleName);
                pos = other.transform.position;
                gameOver = true;
                StartCoroutine(delay());
               

            }
        }
    }
}
