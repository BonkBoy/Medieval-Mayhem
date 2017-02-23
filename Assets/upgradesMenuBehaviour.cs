using UnityEngine;
using System.Collections;

public class upgradesMenuBehaviour : MonoBehaviour {

    public Transform upgrades, character, weapons, powerUps;

	public void characterMenu(bool clicked)
    {
        if(clicked == true)
        {
            character.gameObject.SetActive(clicked);
            upgrades.gameObject.SetActive(false);
        }
        else
        {
            character.gameObject.SetActive(clicked);
            upgrades.gameObject.SetActive(true);
        }
    }

    public void weaponsMenu(bool clicked)
    {
        if (clicked == true)
        {
            weapons.gameObject.SetActive(clicked);
            upgrades.gameObject.SetActive(false);
        }
        else
        {
            weapons.gameObject.SetActive(clicked);
            upgrades.gameObject.SetActive(false);
        }
    }

    public void powerUpsMenu(bool clicked)
    {
        if(clicked == true)
        {
            powerUps.gameObject.SetActive(clicked);
            upgrades.gameObject.SetActive(false);
        }
        else
        {
            powerUps.gameObject.SetActive(clicked);
            upgrades.gameObject.SetActive(true);
        }
    }
}
