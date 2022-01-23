using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseWebView : MonoBehaviour
{
    public void closeWebView(){
        GameObject.Find("WebViewObject").GetComponent<WebViewObject>().SetVisibility(false);
    }
}
