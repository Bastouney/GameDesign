using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    [SerializeReference] public int ScienceEvolve1 = 1000;
    [SerializeReference] public int ScienceEvolve2 = 2000;
    private Camera cam;
    private int Science = 0;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        cam.orthographicSize = 5;
    }

    // Update is called once per frame
    void Update()
    {
        //Science++;
        if (Science == ScienceEvolve1)
            cam.orthographicSize = 7;
        if (Science == ScienceEvolve2)
            cam.orthographicSize = 9;

    }
}
