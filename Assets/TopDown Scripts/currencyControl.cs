using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class currencyControl : MonoBehaviour {

    public Text currencyIndicator;
    int currency;

	// Use this for initialization
	void Start () {
        currency = PlayerPrefs.GetInt("playerCurrency");
        currencyIndicator.text = "Gold: " + currency.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        currency = PlayerPrefs.GetInt("playerCurrency");
        currencyIndicator.text = "Gold: " + currency.ToString();
    }
}
