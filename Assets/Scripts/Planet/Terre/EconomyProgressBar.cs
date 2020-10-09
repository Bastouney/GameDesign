using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class EconomyProgressBar : MonoBehaviour
{
    public Slider slider;

    public float FillSpeed = 0.5f;
    public float targetProgress = 0.5f;
    public int frameNb = 0;

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
        frameNb++;
        if (frameNb % 1000 == 0)
        {
            targetProgress += 0.01f;
        }
        if (slider.value < targetProgress)
            slider.value += FillSpeed * Time.deltaTime;
        if (slider.value > targetProgress)
            slider.value -= FillSpeed * Time.deltaTime;
    }

    public void incrementProgress(float newProgress)
    {
        targetProgress += newProgress;
    }

    public void decreaseProgress(float newProgress)
    {
        targetProgress -= newProgress;
    }
}
