using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityStandardAssets.Effects;

public class sliderBehaviour : MonoBehaviour {

    public Slider brightnessSlider;
    public Image brightness;

    public void Start()
    {
        
    }

    public void brightnessControl()
    {
        Color newColour = brightness.color;
        newColour.a = brightnessSlider.value - 0.1f;
        newColour.b = 0;
        newColour.g = 0;
        newColour.r = 0;
        brightness.color = newColour;
    }    
     
    public void Update()
    {
        
    }


}
