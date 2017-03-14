using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superSpeedPowerUp : MonoBehaviour {

    float superSpeedDuration;
    bool enableSuperSpeed;

	// Use this for initialization
	void Start () {

        superSpeedDuration = PlayerPrefs.GetInt("superSpeedDuration");

	}

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "player")
        {
            enableSuperSpeed = true;
            Invoke("superSpeed", 0);
            Invoke("disableSpeed", superSpeedDuration);
        }
    }

    void superSpeed()
    {
        if (enableSuperSpeed == true)
        {
            PlayerPrefs.SetInt("superSpeedMultiplier", 2);

        }else
        {
            PlayerPrefs.SetInt("superSpeedMultiplier", 1);
        }
    }

    void disableSpeed()
    {
        enableSuperSpeed = false;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
