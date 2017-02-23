using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class gameOver : MonoBehaviour {

    public GameObject mainGame;
    public GameObject gameMenu;
    public InputField playerInput;
    string playerName;
    

    void Start()
    {

        int score = PlayerPrefs.GetInt("playerScore");

        List<int> scores = new List<int>(PlayerPrefsX.GetIntArray("scores"));

        scores.Add(score);

        PlayerPrefsX.SetIntArray("scores", scores.ToArray());

        PlayerPrefs.Save();

    }

    public void restartGame(bool clicked)
    {
        if(clicked == true)
        {
            PlayerPrefs.DeleteKey("levelCounter");
            PlayerPrefs.DeleteKey("playerScore");
            PlayerPrefs.SetInt("levelCounter", 1);
            PlayerPrefs.SetInt("playerScore", 0);
            PlayerPrefs.Save();
            SceneManager.LoadScene("adas");
        }
        
    }

    public void exitGame(bool clicked)
    {
        if(clicked == true)
        {
            PlayerPrefs.DeleteKey("levelCounter");
            PlayerPrefs.DeleteKey("playerScore");
            PlayerPrefs.SetInt("levelCounter", 1);
            PlayerPrefs.SetInt("playerScore", 0);
            PlayerPrefs.Save();
            SceneManager.LoadScene("loadScreen");
        }
    }

    public void submitName(bool clicked)
    {

        if (clicked == true)
        {
            playerName = playerInput.text;

            List<string> namesToBeEntered = new List<string>(PlayerPrefsX.GetStringArray("playerNames"));

            namesToBeEntered.Add(playerName);

            PlayerPrefsX.SetStringArray("playerNames", namesToBeEntered.ToArray());

            PlayerPrefs.Save();

            playerInput.text = "Thank You!";

        }
    }
}
