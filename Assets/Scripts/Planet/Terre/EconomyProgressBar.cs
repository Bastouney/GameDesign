﻿using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class EconomyProgressBar : MonoBehaviour
{
    private Slider slider;

    public float FillSpeed = 0.5f;
    private float targetProgress = 0.6f;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < targetProgress)
            slider.value += FillSpeed * Time.deltaTime;
        if (slider.value > targetProgress)
            slider.value -= FillSpeed * Time.deltaTime;
    }

    public void incrementProgress(float newProgress)
    {
        targetProgress = slider.value + newProgress;
    }

    public void decreaseProgress(float newProgress)
    {
        Debug.Log(slider.value + newProgress);
        targetProgress = slider.value - newProgress;
    }
}
