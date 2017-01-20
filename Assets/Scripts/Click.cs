using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {
    public UnityEngine.UI.Text goldDisplay;
    public UnityEngine.UI.Text gpc;

    public float gold = 0;
    public int goldperclick = 1;
    //gold.ToString("F0")
    private void Update(){
        goldDisplay.text = "Gold: " + CurrencyConverter.Instance.GetCurrencyIntoString(gold, false, false);
        gpc.text = CurrencyConverter.Instance.GetCurrencyIntoString(goldperclick,false,true);
        
    }

    public void Clicked() {
        gold += goldperclick;


    }

}
