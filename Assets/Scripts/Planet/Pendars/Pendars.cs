using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendars : MonoBehaviour
{
    public GameObject Panel;
    public ResourceProgressBar progressBar;

    void Start()
    {
    }

    private void OnMouseDown()
    {
        if (Panel != null && Panel.activeSelf == false)
        {
            Panel.SetActive(true);
        } else
        {
            Panel.SetActive(false);
        }
    }


}
