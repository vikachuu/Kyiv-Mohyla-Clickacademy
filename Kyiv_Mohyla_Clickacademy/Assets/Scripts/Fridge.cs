using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fridge : MonoBehaviour {
    public SliderScript sliderType;
    public float addPerClick;

	void Start () {
		
	}
	
	void Update () {
        sliderType.slider.value = sliderType.current;
    }

    public void Clicked()
    {
        Debug.Log("clicked");
        sliderType.current += addPerClick;
        if (sliderType.current >= sliderType.slider.maxValue)
        {
            sliderType.current = sliderType.slider.maxValue;
        }
    }
}
