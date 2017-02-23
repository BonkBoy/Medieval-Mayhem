using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuBehaviour : MonoBehaviour {

    public Transform mainMenu, optionsMenu, musicMenu, leaderBoards, upgradesMenu;

    public void loadScene(string name){

        SceneManager.LoadScene(name);

    }

    public void quit()
    {
        Application.Quit();
    }

    public void options(bool clicked)
    {
        if (clicked == true)
        {
            optionsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);
        }else
        {
            optionsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(true);
        }
    }

    public void music(bool clicked)
    {
        if (clicked == true)
        {
            musicMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);
        }
        else
        {
            musicMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(true);
        }
    }

    public void leaderboardMenu(bool clicked)
    {
        if (clicked == true)
        {
            leaderBoards.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);
        }
        else
        {
            leaderBoards.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(true);
        }
    }

    public void upgrades(bool clicked)
    {
        if (clicked == true)
        {
            upgradesMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);
        }
        else
        {
            upgradesMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(true);
        }
    }

}
