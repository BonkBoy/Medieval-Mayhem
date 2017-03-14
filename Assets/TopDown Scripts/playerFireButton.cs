using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFireButton : MonoBehaviour {

    public GameObject bullet;
    public GameObject bulletEmitter;
    float attackSpeed;
    bool enableFiring;

    void Start()
    {
        enableFiring = true;
        attackSpeed = PlayerPrefs.GetFloat("attackSpeed");
    }

    public void playerShoot() {

        if (enableFiring == true) { 
            GameObject firedBullet = Instantiate(bullet);
            firedBullet.transform.position = bulletEmitter.transform.position;
            firedBullet.transform.rotation = bulletEmitter.transform.rotation;
            firedBullet.tag = "playerBullet";

            enableFiring = false;
            Invoke("enableFiringButton", attackSpeed);
        }
    }

    void enableFiringButton()
    {
        enableFiring = true;
    }
}
