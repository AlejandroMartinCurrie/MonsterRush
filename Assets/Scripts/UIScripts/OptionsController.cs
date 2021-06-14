using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    public GameObject optionsCanvas;
    public Animator optionsAnimator;
    void Start()
    {
        optionsCanvas.SetActive(false);
    }

    public void ActivateOptionsWindows()
    {
        optionsCanvas.SetActive(true);
        optionsAnimator.Play("OptionsMoveAnimation");
    } 
    public void DeActivateOptionsWindows()
    {
        optionsCanvas.SetActive(false);
    }


    public void CloseGameOptions()
    {
        print("Has Salido del juego");
        Application.Quit();
    }

}
