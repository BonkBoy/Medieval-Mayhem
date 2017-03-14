using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class attackSpeedBehaviour : MonoBehaviour {

    public Dropdown attackSpeedSelector;
    public Text indicator;
    List<string> attackSpeedValues = new List<string>();
    int currency;

	// Use this for initialization
	void Start () {

        populateList();
        attackSpeedSelector.ClearOptions();
        attackSpeedSelector.AddOptions(attackSpeedValues);
        currency = PlayerPrefs.GetInt("playerCurrency");
        attackSpeedSelector.value = PlayerPrefs.GetInt("attackSpeedSelectorValue");

	}

    void populateList()
    {
        attackSpeedValues.Add("x1 - Free");
        attackSpeedValues.Add("x1.25 - 50 Gold");
        attackSpeedValues.Add("x1.5 - 100 Gold");
        attackSpeedValues.Add("x1.75 - 1000 Gold");
        attackSpeedValues.Add("x2 - 10000 Gold");
    }

    public void speedSelection()
    {

        int i = attackSpeedSelector.value;

        if(i == 0)
        {
            PlayerPrefs.SetInt("attackSpeedSelectorValue", attackSpeedSelector.value);
            PlayerPrefs.SetFloat("attackSpeed", 1f);
            PlayerPrefs.Save();
        }

        if (i == 1)
        {
            if (currency < 50)
            {
                indicator.text = "Insufficient Funds";
            }
            else
            {
                PlayerPrefs.SetInt("attackSpeedSelectorValue", attackSpeedSelector.value);
                PlayerPrefs.SetFloat("attackSpeed", 0.75f);
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
                PlayerPrefs.SetInt("attackSpeedSelectorValue", attackSpeedSelector.value);
                PlayerPrefs.SetFloat("attackSpeed", 0.5f);
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
                PlayerPrefs.SetInt("attackSpeedSelectorValue", attackSpeedSelector.value);
                PlayerPrefs.SetFloat("attackSpeed", 0.25f);
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
                PlayerPrefs.SetInt("attackSpeedSelectorValue", attackSpeedSelector.value);
                PlayerPrefs.SetFloat("attackSpeed", 0.1f);
                currency = currency - 10000;
                PlayerPrefs.SetInt("playerCurrency", currency);
                PlayerPrefs.Save();
            }
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
