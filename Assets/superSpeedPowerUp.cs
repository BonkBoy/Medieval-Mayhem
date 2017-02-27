using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superSpeedPowerUp : MonoBehaviour {

    float superSpeedDuration;
    bool disableSuperSpeed = true;

	// Use this for initialization
	void Start () {

        superSpeedDuration = PlayerPrefs.GetInt("superSpeedDuration");

	}

    private void OnTriggerEnter2D(Collider2D coll)
    {

        Invoke("superSpeed", 0);
        Invoke("enableSpeed", superSpeedDuration);
        disableSuperSpeed = true;

    }

    void superSpeed()
    {
        if (disableSuperSpeed == true)
        {
            PlayerPrefs.SetInt("superSpeedMultiplier", 2);

        }else
        {
            PlayerPrefs.SetInt("superSpeedMultiplier", 1);
        }
    }

    void enableSpeed()
    {
        disableSuperSpeed = false;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
