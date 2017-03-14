using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class playMusic : MonoBehaviour {

    string[] filePaths;
    public AudioSource musicPlayer;
    int currentIndex = 0;
    WWW filePath;
    public Text CHECK;

	void Start () {

        filePaths = PlayerPrefsX.GetStringArray("filePaths");
        DontDestroyOnLoad(gameObject);

        if(filePaths.Length > 0)
        {
            CHECK.text = "Files Present";
        }

        playClip();
    }

    void playClip()
    {

        if(currentIndex <= filePaths.Length)
        {
            filePath = new WWW(filePaths[currentIndex]);
            musicPlayer.clip = filePath.audioClip;
            musicPlayer.Play();
        }

    }

    // Update is called once per frame
    void Update () {
		
        if(musicPlayer.time >= musicPlayer.clip.length)
        {
            currentIndex = currentIndex + 1;
        }

        Start();

	}
}
