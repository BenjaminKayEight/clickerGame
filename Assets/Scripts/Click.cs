using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {
    public UnityEngine.UI.Text goldDisplay;
    public UnityEngine.UI.Text gpc;

    public float gold = 0;
    public int goldperclick = 1;

    private void Update(){
        goldDisplay.text = "Gold: " + gold;
        gpc.text = "GPC: " + goldperclick;
        
    }

    public void Clicked() {
        gold += goldperclick;


    }

}
