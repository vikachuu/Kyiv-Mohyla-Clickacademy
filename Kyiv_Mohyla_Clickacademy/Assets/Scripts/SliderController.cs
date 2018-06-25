using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour {
    public SliderScript sliderType;
    public float addPerClick = 1;

	void Start () {

    }
	
	void Update () {
        sliderType.slider.value = sliderType.current;        
    }

    public void Clicked()
    {
       sliderType.current += addPerClick;
        if (sliderType.current >= sliderType.slider.maxValue)
        {
            sliderType.current = sliderType.slider.maxValue;
        }else if (sliderType.current <= 0)
        {
            sliderType.current = 0;
        }
    }
}
