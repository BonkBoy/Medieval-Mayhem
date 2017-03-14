using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class superSpeedMenu : MonoBehaviour {

    public Dropdown superSpeed;
    public Text superSpeedIndicator;
    List<string> superSpeedValues = new List<string>();
    int currency;

    // Use this for initialization
    void Start()
    {

        populateList();
        superSpeed.ClearOptions();
        superSpeed.AddOptions(superSpeedValues);
        currency = PlayerPrefs.GetInt("playerCurrency");
        superSpeed.value = PlayerPrefs.GetInt("superSpeedMenuValue");

    }

    void populateList()
    {

        superSpeedValues.Add("1 Second - Free");
        superSpeedValues.Add("2 Seconds - 50 Gold");
        superSpeedValues.Add("3 Seconds - 100 Gold");
        superSpeedValues.Add("4 Seconds - 1000 Gold");
        superSpeedValues.Add("5 Seconds - 10000 Gold");

    }

    public void timeSelection()
    {

        int i = superSpeed.value;

        if (i == 0)
        {
            PlayerPrefs.SetInt("superSpeedMenuValue", i);
            PlayerPrefs.SetFloat("superSpeedDuration", 1f);
            PlayerPrefs.Save();
        }

        if (i == 1)
        {
            if (currency < 50)
            {
                superSpeedIndicator.text = "Insufficient Funds";
            }
            else
            {
                PlayerPrefs.SetInt("superSpeedMenuValue", i);
                PlayerPrefs.SetFloat("superSpeedDuration", 2f);
                currency = currency - 50;
                PlayerPrefs.SetInt("playerCurrency", currency);
                PlayerPrefs.Save();
            }
        }

        if (i == 2)
        {
            if (currency < 100)
            {
                superSpeedIndicator.text = "Insufficient Funds";
            }
            else
            {
                PlayerPrefs.SetInt("superSpeedMenuValue", i);
                PlayerPrefs.SetFloat("superSpeedDuration", 3f);
                currency = currency - 100;
                PlayerPrefs.SetInt("playerCurrency", currency);
                PlayerPrefs.Save();
            }
        }

        if (i == 3)
        {
            if (currency < 1000)
            {
                superSpeedIndicator.text = "Insufficient Funds";
            }
            else
            {
                PlayerPrefs.SetInt("superSpeedMenuValue", i);
                PlayerPrefs.SetFloat("superSpeedDuration", 4f);
                currency = currency - 1000;
                PlayerPrefs.SetInt("playerCurrency", currency);
                PlayerPrefs.Save();
            }
        }

        if (i == 4)
        {
            if (currency < 10000)
            {
                superSpeedIndicator.text = "Insufficient Funds";
            }
            else
            {
                PlayerPrefs.SetInt("superSpeedMenuValue", i);
                PlayerPrefs.SetFloat("superSpeedDuration", 5f);
                currency = currency - 10000;
                PlayerPrefs.SetInt("playerCurrency", currency);
                PlayerPrefs.Save();
            }
        }

    }
}
