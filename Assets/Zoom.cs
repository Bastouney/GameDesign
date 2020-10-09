using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Zoom : MonoBehaviour
{
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
        cam.orthographicSize = 5;
    }

    private void OnMouseDown()
    {
        if (cam.orthographicSize >= 7)
            cam.orthographicSize = 9;
        if (cam.orthographicSize < 7)
            cam.orthographicSize = 7;
    }
}
