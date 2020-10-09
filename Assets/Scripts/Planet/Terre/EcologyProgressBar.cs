using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class EcologyProgressBar : MonoBehaviour
{
    private Slider slider;

    public float FillSpeed = 0.5f;
    private float targetProgress = 1;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }

    // Start is called before the first frame update
    void Start()
    {
        decreaseProgress(0.75f);
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value > targetProgress)
            slider.value -= FillSpeed * Time.deltaTime;
    }

    public void decreaseProgress(float newProgress)
    {
        targetProgress = slider.value - newProgress;
    }
}
