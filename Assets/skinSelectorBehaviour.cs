using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skinSelectorBehaviour : MonoBehaviour {

    public Image skin;
    public Dropdown skinMenu;
    public List<string> skinNames = new List<string>();

    // Use this for initialization
    void Start () {
        skinMenu.ClearOptions();
        populateList();
        skinMenu.AddOptions(skinNames);
	}

    void characterSkins()
    {

        int i = skinMenu.value;

        if (i == 0)
        {

            string imageFile = "defaultSkin.png";
            PlayerPrefs.SetString("playerSkin", imageFile);

        }

        if (i == 1)
        {

            string imageFile = "skin1.png";
            PlayerPrefs.SetString("playerSkin", imageFile);
        }

        if (i == 2)
        {

            string imageFile = "skin2.png";
            PlayerPrefs.SetString("playerSkin", imageFile);
        }

        if (i == 3)
        {

            string imageFile = "skin3.png";
            PlayerPrefs.SetString("playerSkin", imageFile);
        }

        if (i == 4)
        {

            string imageFile = "skin4.png";
            PlayerPrefs.SetString("playerSkin", imageFile);
        }

        if (i == 5)
        {

            string imageFile = "skin5.png";
            PlayerPrefs.SetString("playerSkin", imageFile);
        }

        if (i == 6)
        {

            string imageFile = "skin6.png";
            PlayerPrefs.SetString("playerSkin", imageFile);
        }

        if (i == 7)
        {

            string imageFile = "skin7.png";
            PlayerPrefs.SetString("playerSkin", imageFile);
        }

        if (i == 8)
        {

            string imageFile = "skin8.png";
            PlayerPrefs.SetString("playerSkin", imageFile);
        }

        if (i == 9)
        {

            string imageFile = "skin9.png";
            PlayerPrefs.SetString("playerSkin", imageFile);
        }

    }

    void populateList()
    {

        skinNames.Add("Default");
        skinNames.Add("skin1");
        skinNames.Add("skin2");
        skinNames.Add("skin3");
        skinNames.Add("skin4");
        skinNames.Add("skin5");
        skinNames.Add("skin6");
        skinNames.Add("skin7");
        skinNames.Add("skin8");
        skinNames.Add("skin9");

    }

    // Update is called once per frame
    void Update () {
		
	}
}
