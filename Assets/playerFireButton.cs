using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFireButton : MonoBehaviour {

    public GameObject bullet;
    public GameObject bulletEmitter;
    float attackSpeed;
    bool disableFiring = false;

    void Start()
    {
        attackSpeed = PlayerPrefs.GetFloat("attackSpeed");
    }

    public void playerShoot() {

        if (!disableFiring) { 
            GameObject firedBullet = Instantiate(bullet);
            firedBullet.transform.position = bulletEmitter.transform.position;
            firedBullet.transform.rotation = bulletEmitter.transform.rotation;
            firedBullet.tag = "playerBullet";

            disableFiring = true;
            Invoke("enableFiring", attackSpeed);
        }
    }

    void enableFiring()
    {
        disableFiring = false;
    }
}
