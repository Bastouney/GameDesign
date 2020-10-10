using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Terre : MonoBehaviour
{
    // Start is called before the first frame update

    public int nb = 0;
    public GameObject openWindow = null;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nb == 7)
        {
            SceneManager.LoadScene("GoodEnd");
        }
    }

    public void setOpenWindow(GameObject window)
    {
        if (openWindow != null && openWindow.activeSelf == true)
        {
            openWindow.SetActive(false);
        }
        openWindow = window;
    }

}
