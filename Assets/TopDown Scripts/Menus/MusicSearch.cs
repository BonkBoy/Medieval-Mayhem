using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class MusicSearch : MonoBehaviour
{

    FileInfo[] musicFiles;
    WWW filePath;
    List<string> filePaths = new List<string>();

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        DirectoryInfo musicFolder = new DirectoryInfo("/storage/emulated/0/Music/");
        musicFiles = musicFolder.GetFiles("*.mp3", SearchOption.AllDirectories);

        loadMusic();
    }

    void loadMusic()
    {
        for(int i = 0; i <= musicFiles.Length; i++)
        {
            filePath = new WWW("File://" + musicFiles[i]);
            filePaths.Add(filePath.ToString());
        }
    }

    public void Update()
    {
        PlayerPrefsX.SetStringArray("filePaths", filePaths.ToArray());
        PlayerPrefs.Save();
    }

}