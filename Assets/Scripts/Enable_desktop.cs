using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enable_desktop : MonoBehaviour
{
    private GameObject KeyBoard;

    void Update(){
        if(KeyBoard!=null){
        KeyBoard=GameObject.FindGameObjectWithTag("Keyboard");
        }
    }
    public void makeVisible(){
        KeyBoard.SetActive(true);
    }
}
