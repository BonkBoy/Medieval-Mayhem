using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leaderBoardsBehaviour : MonoBehaviour {

    string[] playerNames;
    int[] playerScores;

	// Use this for initialization
	void Start () {

        playerNames = PlayerPrefsX.GetStringArray("playerNames");
        playerScores = PlayerPrefsX.GetIntArray("scores");

        leaderBoardSort();
	}

    private void OnGUI()
    {

        for(int i = 0; i < playerNames.Length; i++)
        {

            GUILayout.Box(playerNames[i]);

        }

        for (int i = 0; i < playerScores.Length; i++)
        {

            GUILayout.Box(playerScores[i].ToString());

        }

    }

    void leaderBoardSort()
    {

        int hole;
        int left;

        for (int i = 0; i < playerScores.Length; i++)
        {
            hole = playerScores[i];
            left = i - 1;

            while (left >= 0 && playerScores[left] > hole)
            {
                playerScores[left + 1] = playerScores[left];
                left--;
            }

            playerScores[left + 1] = hole;

        }

    }
}
