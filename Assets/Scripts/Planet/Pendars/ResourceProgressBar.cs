using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ResourceProgressBar : MonoBehaviour
{
    public Slider slider;

    public float FillSpeed = 0.5f;
    private float targetProgress = 1;

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
        if (slider.value > targetProgress)
            slider.value -= FillSpeed * Time.deltaTime;
    }

    public void decreaseResource(float newProgress)
    {
        targetProgress = slider.value - newProgress;
    }
}
