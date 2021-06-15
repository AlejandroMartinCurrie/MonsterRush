using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharUIController : MonoBehaviour
{
    public GameObject characterCanvas;
    public Animator charSelectAnim;

    void Start()
    {
        characterCanvas.SetActive(false);
    }

    public void ActivateCharacterSelect()
    {
        characterCanvas.SetActive(true);
        charSelectAnim.Play("CharacterAnimationController");
    }
    public void CloseCharacterSelect()
    {
        characterCanvas.SetActive(false);
    }
}
