using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseWindow : MonoBehaviour
{
    private GameObject screen;

    void Update()
    {
        screen=GameObject.FindGameObjectWithTag("Screen");
    }
    public void close()
    {
        Destroy(screen);
    }
}
