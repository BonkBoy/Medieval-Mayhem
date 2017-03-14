using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeStopBehaviour : MonoBehaviour {

    public Dropdown timeStopMenu;
    public Text timeStopIndicator;
    List<string> timeValues = new List<string>();
    int currency;

	// Use this for initialization
	void Start () {

        populateList();
        timeStopMenu.ClearOptions();
        timeStopMenu.AddOptions(timeValues);
        currency = PlayerPrefs.GetInt("playerCurrency");
        timeStopMenu.value = PlayerPrefs.GetInt("timeStopMenuValue");

    }

    void populateList()
    {

        timeValues.Add("0.1 Second - Free");
        timeValues.Add("0.25 Seconds - 50 Gold");
        timeValues.Add("0.5 Seconds - 100 Gold");
        timeValues.Add("0.75 Seconds - 1000 Gold");
        timeValues.Add("1 Second - 10000 Gold");

    }

    public void timeSelection()
    {

        int i = timeStopMenu.value;

        if (i == 0)
        {
            PlayerPrefs.SetInt("timeStopMenuValue", i);
            PlayerPrefs.SetFloat("timeStopDuration", 0.1f);
            PlayerPrefs.Save();
        }

        if (i == 1)
        {
            if (currency < 50)
            {
                timeStopIndicator.text = "Insufficient Funds";
            }
            else
            {
                PlayerPrefs.SetInt("timeStopMenuValue", i);
                PlayerPrefs.SetFloat("timeStopDuration", 0.25f);
                currency = currency - 50;
                PlayerPrefs.SetInt("playerCurrency", currency);
                PlayerPrefs.Save();
            }
        }

        if (i == 2)
        {
            if (currency < 100)
            {
                timeStopIndicator.text = "Insufficient Funds";
            }
            else
            {
                PlayerPrefs.SetInt("timeStopMenuValue", i);
                PlayerPrefs.SetFloat("timeStopDuration", 0.5f);
                currency = currency - 100;
                PlayerPrefs.SetInt("playerCurrency", currency);
                PlayerPrefs.Save();
            }
        }

        if (i == 3)
        {
            if (currency < 1000)
            {
                timeStopIndicator.text = "Insufficient Funds";
            }
            else
            {
                PlayerPrefs.SetInt("timeStopMenuValue", i);
                PlayerPrefs.SetFloat("timeStopDuration", 0.75f);
                currency = currency - 1000;
                PlayerPrefs.SetInt("playerCurrency", currency);
                PlayerPrefs.Save();
            }
        }

        if (i == 4)
        {
            if (currency < 10000)
            {
                timeStopIndicator.text = "Insufficient Funds";
            }
            else
            {
                PlayerPrefs.SetInt("timeStopMenuValue", i);
                PlayerPrefs.SetFloat("timeStopDuration", 1f);
                currency = currency - 10000;
                PlayerPrefs.SetInt("playerCurrency", currency);
                PlayerPrefs.Save();
            }
        }

    }

}
