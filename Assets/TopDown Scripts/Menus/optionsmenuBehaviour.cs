using UnityEngine;
using System.Collections;


public class optionsmenuBehaviour : MonoBehaviour {

    public Transform optionsMenu, graphicsSettings, audioSettings, helpMenu;

    public void graphicssettingsMenu(bool clicked)
    {
        if (clicked == true)
        {
            graphicsSettings.gameObject.SetActive(clicked);
            optionsMenu.gameObject.SetActive(false);
        }
        else
        {
            graphicsSettings.gameObject.SetActive(clicked);
            optionsMenu.gameObject.SetActive(true);
        }
    }

    public void audiosettingsMenu(bool clicked)
    {
        if (clicked == true)
        {
            audioSettings.gameObject.SetActive(clicked);
            optionsMenu.gameObject.SetActive(false);
        }
        else
        {
            audioSettings.gameObject.SetActive(clicked);
            optionsMenu.gameObject.SetActive(true);
        }
    }


    public void Help(bool clicked)
    {
        if (clicked == true)
        {
            helpMenu.gameObject.SetActive(clicked);
            optionsMenu.gameObject.SetActive(false);
        }
        else
        {
            helpMenu.gameObject.SetActive(clicked);
            optionsMenu.gameObject.SetActive(true);
        }

    }

}
