﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager:MonoBehaviour {

    public UnityEngine.UI.Text itemInfo;
    public Click click;
    public float cost;
    public int tickValue;
    public int count;
    public string itemName;
    private float baseCost;
    public Color affordable;
    public Color standard;

    private void Start() {
        baseCost = cost;
    }

    private void Update() {
        itemInfo.text = itemName + "\nCost: " +cost +"\nGold: " + tickValue + "/s";
        //check if enough gold for upgrade
        if(click.gold >= cost) {
            GetComponent<Image>().color = affordable;
        } else {
            GetComponent<Image>().color = standard;
        }
    }
    public void PurchasedItem() {
        if(click.gold >= cost) {
            click.gold -= cost;
            count += 1;
            cost = Mathf.Round(baseCost * Mathf.Pow(1.15f, count));
        }
    }
}
