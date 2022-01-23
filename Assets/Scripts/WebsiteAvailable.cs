using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebsiteAvailable : MonoBehaviour
{
    public GameObject webview;
    public GameObject[] website;
    private int a;
    // Start is called before the first frame update
    void Start()
    {
        a= Random.Range(0, website.Length-1);
        website[a].SetActive(true);
                switch(a){
            case 0:
                webview.GetComponent<SampleWebView>().Url="https://www.youtube.com";
            break;
            case 1:
                webview.GetComponent<SampleWebView>().Url="https://www.google.com";
            break;
        }
    }
}
