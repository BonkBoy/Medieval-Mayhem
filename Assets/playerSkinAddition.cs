using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSkinAddition : MonoBehaviour {

    public GameObject player;
    Texture2D playerSkin;
    string playerSkinPath;

	// Use this for initialization
	void Start () {
        playerSkin = player.GetComponent<Texture2D>();

        playerSkinPath = PlayerPrefs.GetString("playerSkin");
        WWW imageConversion = new WWW(playerSkinPath);

        imageConversion.LoadImageIntoTexture(playerSkin);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
