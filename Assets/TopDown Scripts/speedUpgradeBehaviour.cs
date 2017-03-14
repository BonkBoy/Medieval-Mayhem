using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speedUpgradeBehaviour : MonoBehaviour {

    int currency;
    public Dropdown speedSelector;
    List<string> speedValues = new List<string>();
    public Text indicator;

	// Use this for initialization
	void Start () {

        populateList();
        speedSelector.ClearOptions();
        speedSelector.AddOptions(speedValues);
        currency = PlayerPrefs.GetInt("playerCurrency");
        speedSelector.value = PlayerPrefs.GetInt("speedSelectorValue");

	}
	
    void populateList()
    {
        speedValues.Add("x1 - Free");
        speedValues.Add("x1.25 - 50 Gold");
        speedValues.Add("x1.5 - 100 Gold");
        speedValues.Add("x1.75 - 1000 Gold");
        speedValues.Add("x2 - 10000 Gold");
    }

    public void speedSelection()
    {

        int i = speedSelector.value;

        if(i == 0)
        {
            PlayerPrefs.SetInt("speedSelectorValue", speedSelector.value);
            PlayerPrefs.SetFloat("speedMultiplier", 1f);
            PlayerPrefs.Save();
        }

        if(i == 1)
        {
            if(currency < 50)
            {
                indicator.text = "Insufficient Funds";
            }
            else
            {
                PlayerPrefs.SetInt("speedSelectorValue", speedSelector.value);
                PlayerPrefs.SetFloat("speedMultiplier", 1.25f);
                currency = currency - 50;
                PlayerPrefs.SetInt("playerCurrency", currency);
                PlayerPrefs.Save();
            }
        }

        if (i == 2)
        {
            if (currency < 100)
            {
                indicator.text = "Insufficient Funds";
            }
            else
            {
                PlayerPrefs.SetInt("speedSelectorValue", speedSelector.value);
                PlayerPrefs.SetFloat("speedMultiplier", 1.5f);
                currency = currency - 100;
                PlayerPrefs.SetInt("playerCurrency", currency);
                PlayerPrefs.Save();
            }
        }

        if (i == 3)
        {
            if (currency < 1000)
            {
                indicator.text = "Insufficient Funds";
            }
            else
            {
                PlayerPrefs.SetInt("speedSelectorValue", speedSelector.value);
                PlayerPrefs.SetFloat("speedMultiplier", 1.75f);
                currency = currency - 1000;
                PlayerPrefs.SetInt("playerCurrency", currency);
                PlayerPrefs.Save();
            }
        }

        if (i == 4)
        {
            if (currency < 10000)
            {
                indicator.text = "Insufficient Funds";
            }
            else
            {
                PlayerPrefs.SetInt("speedSelectorValue", speedSelector.value);
                PlayerPrefs.SetFloat("speedMultiplier", 2f);
                currency = currency - 10000;
                PlayerPrefs.SetInt("playerCurrency", currency);
                PlayerPrefs.Save();
            }
        }

    }

}
