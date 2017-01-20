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
    public int getGoldPerSec() {
        int tick = 0;
        foreach(ItemManager item in items) {
            tick += item.count * item.tickValue;

        }
        return tick;
    }

    public void AutoGoldPerSec() {
        click.gold += getGoldPerSec();
    }

    IEnumerator AutoTick() {
        while(true) {
            AutoGoldPerSec();
            yield return new WaitForSeconds(1);
        }
    }


}
