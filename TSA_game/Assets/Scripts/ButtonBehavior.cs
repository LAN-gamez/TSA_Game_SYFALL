using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonBehavior : MonoBehaviour
{

    public GameObject menuCanvas;
    public GameObject howToCanvas;
    public GameObject locationsCanvas;
    public GameObject playCanvas;
    void Start()
    {
        menuCanvas.SetActive(true);
        howToCanvas.SetActive(false);
        locationsCanvas.SetActive(false);
    }
    public void PlayButtonPress()
    {
        menuCanvas.SetActive(false);
        playCanvas.SetActive(true);
    }
    public void HowToButtonPress()
    {
        menuCanvas.SetActive(false);
        howToCanvas.SetActive(true);
    }
    public void LocationsButtonPress()
    {
        menuCanvas.SetActive(false);
        locationsCanvas.SetActive(true);
    }
    public void QuitButtonPress()
    {
        //Application.Quit;
    }
    public void backToMenu()
    {
        menuCanvas.SetActive(true);
        howToCanvas.SetActive(false);
        locationsCanvas.SetActive(false);
    }
}
