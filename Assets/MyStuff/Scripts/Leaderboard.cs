using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Leaderboard : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;

    public Text result;
    private bool valid;

    void Start()
    {
        valid = true;
        result.text = "You Got " + Manager.Correct + " Right Out of 7!";
    }

    // Update is called once per frame
    void Update()
    {
        if (valid)
        {
            int k = 0;
            for (int i = 0; i < Manager.rank.Count; i++)
            {
                if (!Manager.rank[i].StartsWith("Op_"))
                {
                    k = i;
                }
            }

            Manager.rank[k] = "♛ " + Manager.rank[k] + " ♛";
            
            text1.text += Manager.rank[0];
            text2.text += Manager.rank[1];
            text3.text += Manager.rank[2];
            text4.text += Manager.rank[3];
            text5.text += Manager.rank[4];
            
            valid = false;
        }
    }

    public void ClickMainMenuButton()
    {
        SceneManager.LoadScene("Customization");
    }
}
