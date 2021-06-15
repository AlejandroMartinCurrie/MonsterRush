using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapSelectionController : MonoBehaviour
{
    public Sprite[] MapImages;
    public int mapSelected = 0;

    public Image currentMapImage;

    void Start()
    {
        currentMapImage.sprite = MapImages[mapSelected];
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void NextMap()
    {
        mapSelected = (mapSelected + 1) % MapImages.Length;
        currentMapImage.sprite = MapImages[mapSelected];
    }

    public void PreviousMap()
    {
        mapSelected--;
        if(mapSelected <0)
        {
            mapSelected += MapImages.Length;
        
        }
        currentMapImage.sprite = MapImages[mapSelected];
    }



}
