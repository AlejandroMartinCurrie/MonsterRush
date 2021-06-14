using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSoundController : MonoBehaviour
{
    public Button sound_icon;
    public Sprite onImage;
    public Sprite offImage;
    public bool sound_active;



    private void Start()
    {
        sound_active = true;
    }




    public void ChageSoundState()
    {
        if (sound_active)
        {
            sound_active = false;
            sound_icon.image.sprite = offImage;
        }
        else if (!sound_active)
        {
            sound_active = true;
            sound_icon.image.sprite = onImage;
        }

    }
   
}
