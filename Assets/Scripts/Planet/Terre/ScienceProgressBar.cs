using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ScienceProgressBar : MonoBehaviour
{
    public Slider slider;

    public float FillSpeed = 0.5f;
    private float targetProgress = 0f;

    private Camera cam;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        cam.orthographicSize = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < targetProgress)
            slider.value += FillSpeed * Time.deltaTime;
    }

    public void incrementProgress(float newProgress)
    {
        targetProgress = slider.value + newProgress;
        if (targetProgress >= 0.5f)
        {
            cam.orthographicSize = 7;
        }
        if (targetProgress >= 1f)
        {
            cam.orthographicSize = 9;
        }
    }
}
