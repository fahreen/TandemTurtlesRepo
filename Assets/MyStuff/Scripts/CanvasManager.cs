using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public Canvas mainCanvas;
    public GameObject turtle;
    public Image instructions;

    public void ClickPlayButton()
    {
        mainCanvas.gameObject.SetActive(false);
        turtle.gameObject.SetActive(true);
    }

    public void ClickInstructionsButtion()
    {
        instructions.gameObject.SetActive(true);
    }

    public void ClickCloseButton()
    {
        instructions.gameObject.SetActive(false);
    }

}
