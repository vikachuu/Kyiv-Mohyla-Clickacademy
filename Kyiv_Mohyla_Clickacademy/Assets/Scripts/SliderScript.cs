﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour {
    public Slider slider;

    public float current;

	void Start () {
        current = slider.maxValue;
	}
	
	void Update () {
        current -= Time.deltaTime;
        slider.value = current;
	}
}
