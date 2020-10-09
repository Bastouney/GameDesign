using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EcologyProgressBar : MonoBehaviour
{
    private Slider slider;

    public float FillSpeed = 0.05f;
    public float targetProgress = 1f;
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
            slider.value -= 0.01f;        
        }
        Debug.Log(slider.value);
        if (slider.value <= 0)
        {
            SceneManager.LoadScene("Lost");
        }
    }

    public void decreaseProgress(float newProgress)
    {
        targetProgress -= newProgress;
    }
}
