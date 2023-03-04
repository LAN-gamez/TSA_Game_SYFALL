using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonBehavior : MonoBehaviour
{
    public GameObject menuCanvas;
    public GameObject currentCanvas;
    public GameObject nextCanvas;
    public GameObject[] hideCanvas;
    void Start()
    {
        menuCanvas.SetActive(true);
        for (int i = 0; i< hideCanvas.Length; i++)
        {
            hideCanvas[i].SetActive(false);
        }
    }
    public void CanvasChangeButtonPress()
    {
        currentCanvas.SetActive(false);
        nextCanvas.SetActive(true);
    }


    public void QuitButtonPress()
    {
        //Application.Quit;
    }
}
