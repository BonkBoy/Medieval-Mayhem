using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityStandardAssets.Effects;

public class sliderBehaviour : MonoBehaviour {

    public Slider brightnessSlider;
    public Color rbgvalue;

    public void brightnessControl()
    {
        rbgvalue.r = brightnessSlider.value;
        rbgvalue.g = brightnessSlider.value;
        rbgvalue.b = brightnessSlider.value;
       
    }    
     
    public void Update()
    {
        RenderSettings.ambientLight = new Color(rbgvalue.r, rbgvalue.b, rbgvalue.g, 1);
    }


}
