using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shieldDurationBehaviour : MonoBehaviour {

    public Dropdown shieldDuration;
    public Text shieldDurationIndicator;
    List<string> shieldDurationValues = new List<string>();
    int currency;

    // Use this for initialization
    void Start()
    {

        populateList();
        shieldDuration.ClearOptions();
        shieldDuration.AddOptions(shieldDurationValues);
        currency = PlayerPrefs.GetInt("playerCurrency");
        shieldDuration.value = PlayerPrefs.GetInt("shieldDurationMenuValue");

    }

    void populateList()
    {

        shieldDurationValues.Add("1 Second - Free");
        shieldDurationValues.Add("2 Seconds - 50 Gold");
        shieldDurationValues.Add("3 Seconds - 100 Gold");
        shieldDurationValues.Add("4 Seconds - 1000 Gold");
        shieldDurationValues.Add("5 Seconds - 10000 Gold");

    }

    public void timeSelection()
    {

        int i = shieldDuration.value;

        if (i == 0)
        {
            PlayerPrefs.SetInt("shieldDurationMenuValue", i);
            PlayerPrefs.SetFloat("shieldDuration", 1f);
            PlayerPrefs.Save();
        }

        if (i == 1)
        {
            if (currency < 50)
            {
                shieldDurationIndicator.text = "Insufficient Funds";
            }
            else
            {
                PlayerPrefs.SetInt("shieldDurationMenuValue", i);
                PlayerPrefs.SetFloat("shieldDuration", 2f);
                currency = currency - 50;
                PlayerPrefs.SetInt("playerCurrency", currency);
                PlayerPrefs.Save();
            }
        }

        if (i == 2)
        {
            if (currency < 100)
            {
                shieldDurationIndicator.text = "Insufficient Funds";
            }
            else
            {
                PlayerPrefs.SetInt("shieldDurationMenuValue", i);
                PlayerPrefs.SetFloat("shieldDuration", 3f);
                currency = currency - 100;
                PlayerPrefs.SetInt("playerCurrency", currency);
                PlayerPrefs.Save();
            }
        }

        if (i == 3)
        {
            if (currency < 1000)
            {
                shieldDurationIndicator.text = "Insufficient Funds";
            }
            else
            {
                PlayerPrefs.SetInt("shieldDurationMenuValue", i);
                PlayerPrefs.SetFloat("shieldDuration", 4f);
                currency = currency - 1000;
                PlayerPrefs.SetInt("playerCurrency", currency);
                PlayerPrefs.Save();
            }
        }

        if (i == 4)
        {
            if (currency < 10000)
            {
                shieldDurationIndicator.text = "Insufficient Funds";
            }
            else
            {
                PlayerPrefs.SetInt("shieldDurationMenuValue", i);
                PlayerPrefs.SetFloat("shieldDuration", 5f);
                currency = currency - 10000;
                PlayerPrefs.SetInt("playerCurrency", currency);
                PlayerPrefs.Save();
            }

        }

    }
}
