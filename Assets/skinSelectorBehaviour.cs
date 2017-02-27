using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skinSelectorBehaviour : MonoBehaviour {


    Texture2D skin;
    public Dropdown skinMenu;
    public List<string> skinNames = new List<string>();
    public Image skinShowcase;

    // Use this for initialization
    void Start () {
        skin = new Texture2D(2, 2);
        skinMenu.ClearOptions();
        populateList();
        skinMenu.AddOptions(skinNames);
        skinMenu.value = PlayerPrefs.GetInt("skinMenuValue");
	}

    void characterSkins()
    {

        int i = skinMenu.value;

        if (i == 0)
        {

            string imageFile = "defaultSkin.png";
            WWW filePath = new WWW("jar:file://" + Application.dataPath + "!/assets/" + imageFile);
            skin.LoadImage(filePath.bytes);
            skinShowcase.GetComponent<Renderer>().material.mainTexture = skin;
            PlayerPrefs.SetString("playerSkin", filePath.ToString());
            PlayerPrefs.SetInt("skinMenuValue", i);

        }

        if (i == 1)
        {

            string imageFile = "skin1.png";
            WWW filePath = new WWW("jar:file://" + Application.dataPath + "!/assets/" + imageFile);
            skin.LoadImage(filePath.bytes);
            skinShowcase.GetComponent<Renderer>().material.mainTexture = skin;
            PlayerPrefs.SetString("playerSkin", filePath.ToString());
            PlayerPrefs.SetInt("skinMenuValue", i);

        }

        if (i == 2)
        {

            string imageFile = "skin2.png";
            WWW filePath = new WWW("jar:file://" + Application.dataPath + "!/assets/" + imageFile);
            skin.LoadImage(filePath.bytes);
            skinShowcase.GetComponent<Renderer>().material.mainTexture = skin;
            PlayerPrefs.SetString("playerSkin", filePath.ToString());
            PlayerPrefs.SetInt("skinMenuValue", i);

        }

        if (i == 3)
        {

            string imageFile = "skin3.png";
            WWW filePath = new WWW("jar:file://" + Application.dataPath + "!/assets/" + imageFile);
            skin.LoadImage(filePath.bytes);
            skinShowcase.GetComponent<Renderer>().material.mainTexture = skin;
            PlayerPrefs.SetString("playerSkin", filePath.ToString());
            PlayerPrefs.SetInt("skinMenuValue", i);

        }

        if (i == 4)
        {

            string imageFile = "skin4.png";
            WWW filePath = new WWW("jar:file://" + Application.dataPath + "!/assets/" + imageFile);
            skin.LoadImage(filePath.bytes);
            skinShowcase.GetComponent<Renderer>().material.mainTexture = skin;
            PlayerPrefs.SetString("playerSkin", filePath.ToString());
            PlayerPrefs.SetInt("skinMenuValue", i);

        }

        if (i == 5)
        {

            string imageFile = "skin5.png";
            WWW filePath = new WWW("jar:file://" + Application.dataPath + "!/assets/" + imageFile);
            skin.LoadImage(filePath.bytes);
            skinShowcase.GetComponent<Renderer>().material.mainTexture = skin;
            PlayerPrefs.SetString("playerSkin", filePath.ToString());
            PlayerPrefs.SetInt("skinMenuValue", i);

        }

        if (i == 6)
        {

            string imageFile = "skin6.png";
            WWW filePath = new WWW("jar:file://" + Application.dataPath + "!/assets/" + imageFile);
            skin.LoadImage(filePath.bytes);
            skinShowcase.GetComponent<Renderer>().material.mainTexture = skin;
            PlayerPrefs.SetString("playerSkin", filePath.ToString());
            PlayerPrefs.SetInt("skinMenuValue", i);

        }

        if (i == 7)
        {

            string imageFile = "skin7.png";
            WWW filePath = new WWW("jar:file://" + Application.dataPath + "!/assets/" + imageFile);
            skin.LoadImage(filePath.bytes);
            skinShowcase.GetComponent<Renderer>().material.mainTexture = skin;
            PlayerPrefs.SetString("playerSkin", filePath.ToString());
            PlayerPrefs.SetInt("skinMenuValue", i);

        }

        if (i == 8)
        {

            string imageFile = "skin8.png";
            WWW filePath = new WWW("jar:file://" + Application.dataPath + "!/assets/" + imageFile);
            skin.LoadImage(filePath.bytes);
            skinShowcase.GetComponent<Renderer>().material.mainTexture = skin;
            PlayerPrefs.SetString("playerSkin", filePath.ToString());
            PlayerPrefs.SetInt("skinMenuValue", i);

        }

        if (i == 9)
        {

            string imageFile = "skin9.png";
            WWW filePath = new WWW("jar:file://" + Application.dataPath + "!/assets/" + imageFile);
            skin.LoadImage(filePath.bytes);
            skinShowcase.GetComponent<Renderer>().material.mainTexture = skin;
            PlayerPrefs.SetString("playerSkin", filePath.ToString());
            PlayerPrefs.SetInt("skinMenuValue", i);

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
