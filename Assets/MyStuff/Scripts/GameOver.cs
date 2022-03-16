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
    private void Start()
    {
        counter = 0;
        gameOver = false;
        boundary.SetActive(false);
    }



    private void Update()
    {
        if(gameOver && Manager.rank.Count == 5)
        {
            
            SceneManager.LoadScene("MyStuff/Scenes/GameOver");
        }
        
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
                gameOver = true;
                boundary.SetActive(true);
                
                
            }
        }
    }
}
