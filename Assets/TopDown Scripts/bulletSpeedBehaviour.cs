using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletSpeedBehaviour : MonoBehaviour {

    public Dropdown bulletSpeedSelector;
    public Text indicator;
    List<string> bulletSpeedValues = new List<string>();
    int currency;
    float bulletSpeed;

    // Use this for initialization
    void Start () {

        populateList();
        bulletSpeedSelector.ClearOptions();
        bulletSpeedSelector.AddOptions(bulletSpeedValues);
        currency = PlayerPrefs.GetInt("playerCurrency");
        bulletSpeedSelector.value = PlayerPrefs.GetInt("bulletpeedSelectorValue");
        bulletSpeed = PlayerPrefs.GetFloat("bulletSpeedMultiplier");
        indicator.text = bulletSpeed.ToString();

    }

    void populateList()
    {
        bulletSpeedValues.Add("x1 - Free");
        bulletSpeedValues.Add("x1.25 - 50 Gold");
        bulletSpeedValues.Add("x1.5 - 100 Gold");
        bulletSpeedValues.Add("x1.75 - 1000 Gold");
        bulletSpeedValues.Add("x2 - 10000 Gold");
    }

    public void speedSelection()
    {

        int i = bulletSpeedSelector.value;

        if (i == 0)
        {
            PlayerPrefs.SetInt("bulletSpeedSelectorValue", bulletSpeedSelector.value);
            PlayerPrefs.SetFloat("bulletSpeedMultiplier", 1f);
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
                PlayerPrefs.SetInt("bulletSpeedSelectorValue", bulletSpeedSelector.value);
                PlayerPrefs.SetFloat("bulletSpeedMultiplier", 1.25f);
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
                PlayerPrefs.SetInt("bulletSpeedSelectorValue", bulletSpeedSelector.value);
                PlayerPrefs.SetFloat("bulletSpeedMultiplier", 1.5f);
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
                PlayerPrefs.SetInt("bulletSpeedSelectorValue", bulletSpeedSelector.value);
                PlayerPrefs.SetFloat("bulletSpeedMultiplier", 1.75f);
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
                PlayerPrefs.SetInt("bulletSpeedSelectorValue", bulletSpeedSelector.value);
                PlayerPrefs.SetFloat("bulletSpeedMultiplier", 2f);
                currency = currency - 10000;
                PlayerPrefs.SetInt("playerCurrency", currency);
                PlayerPrefs.Save();
            }
        }

    }
}
