﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletSkinBehaviour : MonoBehaviour {

    Texture2D bulletSkin;
    public Dropdown bulletSkinMenu;
    public List<string> bulletSkinNames = new List<string>();
    public Image bulletSkinShowcase;

    // Use this for initialization
    void Start () {
        bulletSkin = new Texture2D(2, 2);
        bulletSkinMenu.ClearOptions();
        populateList();
        bulletSkinMenu.AddOptions(bulletSkinNames);
        bulletSkinMenu.value = PlayerPrefs.GetInt("bulletSkinMenuValue");
    }

    public void bulletSkins()
    {

        int i = bulletSkinMenu.value;

        if (i == 0)
        {

            string imageFile = "defaultBulletSkin.png";
            WWW filePath = new WWW("jar:file://" + Application.dataPath + "!/assets/" + imageFile);
            bulletSkin.LoadImage(filePath.bytes);
            bulletSkinShowcase.GetComponent<Renderer>().material.mainTexture = bulletSkin;
            PlayerPrefs.SetString("bulletSkin", filePath.ToString());
            PlayerPrefs.SetInt("bulletSkinMenuValue", i);
            PlayerPrefs.Save();

        }

        if (i == 1)
        {

            string imageFile = "bulletSkin1.png";
            WWW filePath = new WWW("jar:file://" + Application.dataPath + "!/assets/" + imageFile);
            bulletSkin.LoadImage(filePath.bytes);
            bulletSkinShowcase.GetComponent<Renderer>().material.mainTexture = bulletSkin;
            PlayerPrefs.SetString("bulletSkin", filePath.ToString());
            PlayerPrefs.SetInt("bulletSkinMenuValue", i);
            PlayerPrefs.Save();

        }

        if (i == 2)
        {

            string imageFile = "bulletSkin2.png";
            WWW filePath = new WWW("jar:file://" + Application.dataPath + "!/assets/" + imageFile);
            bulletSkin.LoadImage(filePath.bytes);
            bulletSkinShowcase.GetComponent<Renderer>().material.mainTexture = bulletSkin;
            PlayerPrefs.SetString("bulletSkin", filePath.ToString());
            PlayerPrefs.SetInt("bulletSkinMenuValue", i);
            PlayerPrefs.Save();

        }

        if (i == 3)
        {

            string imageFile = "bulletSkin3.png";
            WWW filePath = new WWW("jar:file://" + Application.dataPath + "!/assets/" + imageFile);
            bulletSkin.LoadImage(filePath.bytes);
            bulletSkinShowcase.GetComponent<Renderer>().material.mainTexture = bulletSkin;
            PlayerPrefs.SetString("bulletSkin", filePath.ToString());
            PlayerPrefs.SetInt("bulletSkinMenuValue", i);
            PlayerPrefs.Save();

        }

    }

    void populateList()
    {

        bulletSkinNames.Add("White Arrow");
        bulletSkinNames.Add("Red Arrow");
        bulletSkinNames.Add("Magic Bolt");
        bulletSkinNames.Add("Fire Bolt");

    }
}
