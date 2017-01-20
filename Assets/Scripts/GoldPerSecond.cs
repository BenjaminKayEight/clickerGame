using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPerSecond : MonoBehaviour {

    public UnityEngine.UI.Text gpsDisplay;
    public Click click;
    public ItemManager[] items;

    private void Start() {
        StartCoroutine(AutoTick());
    }

    private void Update() {
        gpsDisplay.text = getGoldPerSec() + " gold/sec";
    }
    public float getGoldPerSec() {
        float tick = 0;
        foreach(ItemManager item in items) {
            tick += item.count * item.tickValue;

        }
        return tick;
    }

    public void AutoGoldPerSec() {
        click.gold += getGoldPerSec() /10;
    }

    IEnumerator AutoTick() {
        while(true) {
            AutoGoldPerSec();
            yield return new WaitForSeconds(0.10f);
        }
    }


}
