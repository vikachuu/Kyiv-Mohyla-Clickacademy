using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour {
    public Slider hungerSlider;
    private float currentHunger;

	// Use this for initialization
	void Start () {
        currentHunger = hungerSlider.maxValue;
	}
	
	// Update is called once per frame
	void Update () {
        currentHunger -= Time.deltaTime;
        hungerSlider.value = currentHunger;
        if(hungerSlider.value <= 0)
        {
            //TODO: if player is _
            currentHunger = hungerSlider.maxValue;
            hungerSlider.value = hungerSlider.maxValue;
        }
	}
}
