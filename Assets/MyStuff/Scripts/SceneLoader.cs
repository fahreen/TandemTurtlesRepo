using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    


    public void LoadGame()
    {
        SceneManager.LoadScene("MyStuff/Scenes/MainScene");
        Manager.turtleColour = CustomizationButtons.ColourSelected;
        Manager.TurtleName = ReadInput.TName;
        Manager.rank = new List<string>();
        
       
    }


}
